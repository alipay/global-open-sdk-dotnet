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
    if(type.IsArray) return new {type="array",items=Shape(type.GetElementType()!)};
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
    if(type.IsArray) {var a=Array.CreateInstance(type.GetElementType()!,2);a.SetValue(Sample(type.GetElementType()!),0);a.SetValue(Sample(type.GetElementType()!),1);return a;}
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
        Type wireType=p.PropertyType;
        var converter=p.GetCustomAttribute<JsonConverterAttribute>();
        var declaredWireType=converter?.ConverterType?.GetProperty("WireType",BindingFlags.Public|BindingFlags.Static)?.GetValue(null) as Type;
        if(declaredWireType!=null)wireType=declaredWireType;
        p.SetValue(obj,Sample(wireType));props[key]=Shape(wireType);
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
    var oldBuyer=new com.alipay.ams.api.entities.BaselineBuyer();
    var shared=new com.alipay.ams.api.entities.Buyer();
    Check(Wire(oldBuyer)==Wire(shared),"baseline empty Buyer JSON");
    foreach(var prop in oldBuyer.GetType().GetProperties()) {var value=Sample(prop.PropertyType);prop.SetValue(oldBuyer,value);shared.GetType().GetProperty(prop.Name)!.SetValue(shared,value);}
    Check(Wire(oldBuyer)==Wire(shared),"baseline populated Buyer JSON and field order");
    foreach(var ctor in oldBuyer.GetType().GetConstructors()) {var types=ctor.GetParameters().Select(x=>x.ParameterType).ToArray();var current=shared.GetType().GetConstructor(types);Check(current!=null,"legacy constructor signature");var values=types.Select(Sample).ToArray();Check(Wire(ctor.Invoke(values))==Wire(current!.Invoke(values)),"old constructor wire behavior");}
    int sharedRequests=0;
    foreach(var q in sdk.GetTypes().Where(t=>t.Name.EndsWith("Request")&&!t.IsAbstract&&t.GetConstructor(Type.EmptyTypes)!=null&&t.GetProperty("Buyer")?.PropertyType==shared.GetType())) {
      var instance=Activator.CreateInstance(q)!;q.GetProperty("Buyer")!.SetValue(instance,shared);
      var b=JsonDocument.Parse(Wire(instance)).RootElement.GetProperty("buyer");
      Check(b.ToString()==JsonDocument.Parse(Wire(oldBuyer)).RootElement.ToString()&&!b.TryGetProperty("buyerAccessGroupFlag",out _),"unset Buyer across "+q.Name);sharedRequests++;
    }
    Check(sharedRequests>1,"multiple shared Buyer requests");evidence.Add("Pinned baseline empty/populated JSON, exact old constructors and "+sharedRequests+" shared Buyer request bindings verified with flag unset");
    var buyerType=sdk.GetTypes().FirstOrDefault(t=>t.Name=="Buyer");
    if(buyerType!=null) {
      com.alipay.ams.api.entities.Buyer legacyBuyer = new com.alipay.ams.api.entities.Buyer { ReferenceBuyerId = "legacy_buyer" };
      com.alipay.ams.api.request.pay.AlipayPayConsultRequest legacyRequest = new com.alipay.ams.api.request.pay.AlipayPayConsultRequest { Buyer = legacyBuyer };
      com.alipay.ams.api.entities.Buyer legacyReadback = legacyRequest.Buyer;
      Check(Object.ReferenceEquals(legacyReadback,legacyBuyer)&&legacyReadback.ReferenceBuyerId=="legacy_buyer","legacy Buyer identity and assignment");

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
