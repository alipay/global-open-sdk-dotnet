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
    if(type==typeof(string)||type.IsEnum) return new {type="string"};
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
      string name=target.GetString()!;Type type=Find(name);object obj=Activator.CreateInstance(type)!;
      var props=new Dictionary<string,object>();
      foreach(var p in type.GetProperties(BindingFlags.Public|BindingFlags.Instance)) {
        if(!p.CanWrite||p.GetCustomAttribute<JsonIgnoreAttribute>()?.Condition==JsonIgnoreCondition.Always)continue;
        string key=p.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name??JsonNamingPolicy.CamelCase.ConvertName(p.Name);
        p.SetValue(obj,Sample(p.PropertyType));props[key]=Shape(p.PropertyType);
      }
      string json=Wire(obj);var body=JsonDocument.Parse(json).RootElement;
      Check(body.EnumerateObject().Count()==props.Count,name+" actual wire keys");
      object restored=JsonSerializer.Deserialize(json,type,Options)!;
      Check(Wire(restored)==json,name+" runtime roundtrip");
      foreach(var c in type.GetConstructors()) {
        c.Invoke(c.GetParameters().Select(p=>Sample(p.ParameterType)).ToArray());evidence.Add(c.ToString()!);
      }
      models[name]=new {type="object",properties=props};
    }
    foreach(string n in new[]{"ApplyCardPaymentPreference","CardPaymentPreference"}) {
      Type t=Find(n);object o=Activator.CreateInstance(t)!;
      Check(JsonDocument.Parse(Wire(o)).RootElement.EnumerateObject().Count()==0,"empty preference must serialize to {}: "+Wire(o));
      t.GetProperty("CurrencyOrder")!.SetValue(o,new List<string>());
      Check(JsonDocument.Parse(Wire(o)).RootElement.GetProperty("currencyOrder").GetArrayLength()==0,"empty array preserved");
      t.GetProperty("CurrencyOrder")!.SetValue(o,new List<string>{"HKD","USD"});
      Check(JsonDocument.Parse(Wire(o)).RootElement.GetProperty("currencyOrder")[0].GetString()=="HKD","ordered array");
    }
    string custom="{\"authorizationControl\":{\"paymentPreference\":{\"currencyOrder\":[\"HKD\",\"USD\"]}}}";
    foreach(string n in new[]{"AlipayInquireCardDetailResponse","AlipayInquireCardSensitiveInfoResponse"}) {
      bool sensitive=n.Contains("Sensitive");string json=sensitive?"{\"cardDetail\":"+custom+"}":custom;
      object o=JsonSerializer.Deserialize(json,Find(n),Options)!;var body=JsonDocument.Parse(Wire(o)).RootElement;
      if(sensitive)body=body.GetProperty("cardDetail");
      Check(body.GetProperty("authorizationControl").GetProperty("paymentPreference").GetProperty("currencyOrder")[1].GetString()=="USD","inquiry parsed model binding");
    }
    // SDK transport constructs POST independently of the DTO's URI getter.
    Check(File.ReadAllText("ams-dotnet/src/com/alipay/ams/api/DefaultAlipayClient.cs").Contains("HttpMethod.Post"),"actual SDK POST transport binding");
    var bindings=new List<object>();
    foreach(string stem in new[]{"ApplyCard","InquireCardDetail","InquireCardSensitiveInfo"}) {
      Type type=Find("Alipay"+stem+"Request");object o=Activator.CreateInstance(type)!;
      bindings.Add(new {path=(string)type.GetMethod("GetRequestURI")!.Invoke(o,null)!,method="POST",request=type.Name,response=type.BaseType!.GenericTypeArguments[0].Name});
    }
    evidence.Add("SDK JsonSerializerOptionsFactory runtime roundtrips, actual no-arg and current all-args constructors/properties, ordered/empty arrays and nested sensitive readback");
    Console.Write(JsonSerializer.Serialize(new {models,bindings,wire_checks=models.Count,evidence}));
  }
}
