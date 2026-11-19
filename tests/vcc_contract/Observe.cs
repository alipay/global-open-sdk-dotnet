using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
class Observe {
 static Assembly sdk=null!;static JsonSerializerOptions options=null!;
 static Dictionary<string,object> Obj(params object[] kv){var d=new Dictionary<string,object>();for(int i=0;i<kv.Length;i+=2)d[(string)kv[i]]=kv[i+1];return d;}
 static object Shape(Type t){t=Nullable.GetUnderlyingType(t)??t;
  if(t==typeof(string)||t==typeof(DateTime)||t==typeof(DateTimeOffset))return Obj("type","string");
  if(t==typeof(bool))return Obj("type","boolean");
  if(new[]{typeof(byte),typeof(short),typeof(int),typeof(long)}.Contains(t))return Obj("type","integer");
  if(new[]{typeof(float),typeof(double),typeof(decimal)}.Contains(t))return Obj("type","number");
  if(t.IsArray)return Obj("type","array","items",Shape(t.GetElementType()!));
  if(t.IsGenericType){var g=t.GetGenericTypeDefinition();var a=t.GetGenericArguments();if(g==typeof(List<>))return Obj("type","array","items",Shape(a[0]));if(g==typeof(Dictionary<,>))return Obj("type","object","additionalProperties",Shape(a[1]),"properties",Obj());}
  if(t==typeof(object))return Obj();return Obj("$ref","#/components/schemas/"+t.Name);
 }
 static PropertyInfo[] Props(Type t)=>t.GetProperties(BindingFlags.Public|BindingFlags.Instance|BindingFlags.DeclaredOnly).Where(p=>p.CanRead&&p.CanWrite&&p.GetCustomAttribute<JsonIgnoreAttribute>()==null).ToArray();
 static string Key(PropertyInfo p)=>p.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name??options.PropertyNamingPolicy!.ConvertName(p.Name);
 static object? Sample(Type t,int depth=0){t=Nullable.GetUnderlyingType(t)??t;if(depth>8)return null;
  if(t==typeof(string))return "USD";if(t==typeof(bool))return false;if(t.IsPrimitive||t==typeof(decimal))return Activator.CreateInstance(t);if(t.IsEnum)return Enum.GetValues(t).GetValue(0);
  if(t.IsGenericType){var a=t.GetGenericArguments();if(t.GetGenericTypeDefinition()==typeof(List<>)){var v=(IList)Activator.CreateInstance(t)!;v.Add(Sample(a[0],depth+1));return v;}if(t.GetGenericTypeDefinition()==typeof(Dictionary<,>)){var v=(IDictionary)Activator.CreateInstance(t)!;v.Add("key",Sample(a[1],depth+1));return v;}}
  var item=Activator.CreateInstance(t)!;foreach(var p in Props(t))p.SetValue(item,Sample(p.PropertyType,depth+1));return item;
 }
 static void Main(string[] argv){
  sdk=Assembly.LoadFrom(argv[0]);var factory=sdk.GetType("com.alipay.ams.util.JsonSerializerOptionsFactory")!;options=(JsonSerializerOptions)factory.GetField("WriteNotIndented")!.GetValue(null)!;
  var models=Obj();var bindings=Obj();foreach(var name in argv.Skip(1)){
   var t=sdk.GetTypes().Single(x=>x.Name==name);var props=Props(t);var value=Sample(t)!;
   var encoded=JsonSerializer.Serialize(value,t,options);using var doc=JsonDocument.Parse(encoded);
   var schema=Obj();foreach(var p in props){var key=Key(p);if(!doc.RootElement.TryGetProperty(key,out var _))throw new Exception("serializer omitted "+name+"."+key);schema[key]=Shape(p.PropertyType);}
   var parsed=JsonSerializer.Deserialize(encoded,t,options)!;if(JsonSerializer.Serialize(parsed,t,options)!=encoded)throw new Exception("typed roundtrip "+name);
   if(name.EndsWith("PaymentPreference")){
    var property=t.GetProperty("CurrencyOrder")!;
    foreach(var currencies in new[]{new List<string>{"HKD","USD"},new List<string>{"USD","HKD"},new List<string>()}){
     var policy=Activator.CreateInstance(t)!;property.SetValue(policy,currencies);var decoded=JsonSerializer.Deserialize(JsonSerializer.Serialize(policy,t,options),t,options)!;
     if(!((List<string>)property.GetValue(decoded)!).SequenceEqual(currencies))throw new Exception("ordered/empty list lost "+name);
    }
   }
   models[name]=Obj("type","object","properties",schema);
   if(name.StartsWith("Alipay")&&name.EndsWith("Request")){var op=name.Substring(6,name.Length-13);op=char.ToLowerInvariant(op[0])+op.Substring(1);bindings[op]=Obj("path",t.GetMethod("GetRequestURI")!.Invoke(Activator.CreateInstance(t),null)!,"request",name,"response",t.BaseType!.GetGenericArguments()[0].Name);}
  }
  Console.Write(JsonSerializer.Serialize(Obj("models",models,"bindings",bindings,"evidence",new[]{"Compiled property/type reflection; SDK JsonSerializerOptionsFactory; typed JSON serialization/parsing; no-argument/property construction"})));
 }
}
