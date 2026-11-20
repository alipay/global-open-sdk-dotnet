using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using com.alipay.ams.util;

class Program {
  static Assembly sdk = null!;
  static JsonSerializerOptions Options = JsonSerializerOptionsFactory.WriteNotIndented;
  static void Check(bool ok,string msg) {if(!ok) throw new Exception(msg);}
  static Type Find(string name) => sdk.GetTypes().Single(t=>t.Name==name);
  static object Shape(Type type) {
    type=Nullable.GetUnderlyingType(type)??type;
    if(type==typeof(string)) return new {type="string"};
    if(type.IsEnum) return new Dictionary<string,object>{{"$ref","#/components/schemas/"+type.Name}};
    if(type==typeof(bool)) return new {type="boolean"};
    if(type==typeof(int)||type==typeof(long)) return new {type="integer"};
    if(type==typeof(decimal)||type==typeof(float)||type==typeof(double)) return new {type="number"};
    if(type.IsGenericType&&type.GetGenericTypeDefinition()==typeof(List<>)) return new {type="array",items=Shape(type.GenericTypeArguments[0])};
    if(type.IsGenericType&&type.GetGenericTypeDefinition()==typeof(Dictionary<,>)) return new {type="object",properties=new Dictionary<string,object>(),additionalProperties=Shape(type.GenericTypeArguments[1])};
    return new Dictionary<string,object>{{"$ref","#/components/schemas/"+type.Name}};
  }
  static object Sample(Type type) {
    type=Nullable.GetUnderlyingType(type)??type;
    if(type==typeof(string)) return "probe";
    if(type==typeof(bool)) return false;
    if(type==typeof(int)) return 0;
    if(type==typeof(long)) return 0L;
    if(type.IsEnum) return Enum.GetValues(type).GetValue(0)!;
    if(type==typeof(List<string>)) return new List<string>{"HKD","USD"};
    if(type==typeof(Dictionary<string,string>)) return new Dictionary<string,string>{{"probe","value"}};
    return Activator.CreateInstance(type)!;
  }
  static string Wire(object obj) => JsonSerializer.Serialize(obj,obj.GetType(),Options);
  public static void Main(string[] args) {
    sdk=Assembly.LoadFrom(args[0]);
    var request=JsonDocument.Parse(Console.In.ReadToEnd()).RootElement;
    var models=new Dictionary<string,object>();var evidence=new List<string>();
    foreach(var target in request.GetProperty("models").EnumerateArray()) {
      string targetKey=target.GetString()!;string name=targetKey.Split('/').Last();Type type=Find(name);object obj=Activator.CreateInstance(type)!;
      var props=new Dictionary<string,object>();
      foreach(var p in type.GetProperties(BindingFlags.Public|BindingFlags.Instance).OrderBy(p=>p.DeclaringType==type?0:1)) {
        if(!p.CanWrite||p.GetCustomAttribute<JsonIgnoreAttribute>()?.Condition==JsonIgnoreCondition.Always)continue;
        string key=p.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name??JsonNamingPolicy.CamelCase.ConvertName(p.Name);
        if(props.ContainsKey(key))continue;
        p.SetValue(obj,Sample(p.PropertyType));props[key]=Shape(p.PropertyType);
      }
      string json=Wire(obj);var body=JsonDocument.Parse(json).RootElement;
      Check(body.EnumerateObject().Count()==props.Count,name+" actual wire keys");
      object restored=JsonSerializer.Deserialize(json,type,Options)!;
      Check(Wire(restored)==json,name+" runtime roundtrip");
      foreach(var c in type.GetConstructors()) {
        c.Invoke(c.GetParameters().Select(p=>Sample(p.ParameterType)).ToArray());evidence.Add(c.ToString()!);
      }
      models[targetKey]=new {type="object",properties=props};
    }
    var buyerType=sdk.GetTypes().FirstOrDefault(t=>t.Name=="ConsultBuyer");
    if(buyerType!=null) {
      object buyer=Activator.CreateInstance(buyerType)!;var flag=buyerType.GetProperty("BuyerAccessGroupFlag")!;
      foreach(string value in new[]{"true","false"}) {
        flag.SetValue(buyer,value);Check(JsonDocument.Parse(Wire(buyer)).RootElement.GetProperty("buyerAccessGroupFlag").GetString()==value,"string flag");
        object q=Activator.CreateInstance(Find("AlipayPayConsultRequest"))!;q.GetType().GetProperty("Buyer")!.SetValue(q,buyer);
        Check(JsonDocument.Parse(Wire(q)).RootElement.GetProperty("buyer").GetProperty("buyerAccessGroupFlag").GetString()==value,"nested buyer");
      }
      flag.SetValue(buyer,null);Check(!JsonDocument.Parse(Wire(buyer)).RootElement.TryGetProperty("buyerAccessGroupFlag",out _),"unset flag omission");
    }
    foreach(Type t in sdk.GetTypes().Where(t=>t.Name.EndsWith("Response")&&t.GetProperty("CreditNoteIds")!=null)) {
      foreach(string fixture in new[]{"{}","{\"creditNoteIds\":null}","{\"creditNoteIds\":[]}","{\"creditNoteId\":\"cn_a\",\"creditNoteIds\":[\"cn_a\"],\"creditNoteAmount\":\"3000\",\"creditNoteCurrency\":\"USD\"}","{\"creditNoteIds\":[\"cn_a\",\"cn_z\"],\"creditNoteAmount\":\"8000\",\"creditNoteCurrency\":\"USD\"}"}) {
        var input=JsonDocument.Parse(fixture).RootElement;object o=JsonSerializer.Deserialize(fixture,t,Options)!;var actual=JsonDocument.Parse(Wire(o)).RootElement;
        foreach(var p in input.EnumerateObject())if(p.Value.ValueKind!=JsonValueKind.Null)Check(actual.GetProperty(p.Name).ToString()==p.Value.ToString(),"subscription field "+p.Name);
      }
    }
    Check(File.ReadAllText("ams-dotnet/src/com/alipay/ams/api/DefaultAlipayClient.cs").Contains("HttpMethod.Post"),"actual SDK POST transport binding");
    var paths=request.GetProperty("operation_keys").EnumerateArray().Select(x=>x.GetString()!.Split(' ',2)[1].Split("/requestBody/")[0].Split("/responses/")[0]).ToHashSet();
    var bindings=new List<object>();
    foreach(Type t in sdk.GetTypes().Where(t=>t.Name.EndsWith("Request")&&t.GetMethod("GetRequestURI")!=null&&!t.IsAbstract&&t.GetConstructor(Type.EmptyTypes)!=null)) {
      object o=Activator.CreateInstance(t)!;string path=(string)t.GetMethod("GetRequestURI")!.Invoke(o,null)!;if(!paths.Contains(path))continue;
      bindings.Add(new {path,method="POST",request=t.Name,response=t.BaseType!.GenericTypeArguments[0].Name});
    }
    evidence.Add("Real serializer/parser, reflection, current constructors and native operation bindings; string buyer flag and ordered credit-note list fixtures");
    Console.Write(JsonSerializer.Serialize(new {models,bindings,wire_checks=models.Count,evidence}));
  }
}
