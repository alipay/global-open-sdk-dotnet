import json,pathlib,subprocess,sys,tempfile,hashlib,re,tarfile,io
root=pathlib.Path.cwd();req=json.load(sys.stdin);names=set(req['models'])
for target in req['operations']:
 op=target.split(' ',1)[1].split('/requestBody',1)[0].split('/responses',1)[0].rsplit('/',1)[1];names.add('Alipay'+op[0].upper()+op[1:]+'Request')
dlls=list((root/'ams-dotnet/bin').rglob('ams-dotnet.dll'))
latest=max((x.stat().st_mtime for x in (root/'ams-dotnet').rglob('*.cs') if not {'obj','bin'}&set(x.parts)),default=0)
compile_evidence=[]
if not dlls or max(x.stat().st_mtime for x in dlls)<latest:
 # A solution with no Build.0 mappings may be a successful no-op. Compile the
 # actual SDK project and compare its complete warning set to the pinned source.
 build=subprocess.run(['dotnet','build','ams-dotnet/ams-dotnet.csproj','--nologo'],capture_output=True,text=True)
 assert build.returncode==0,build.stdout[-4000:]+build.stderr[-2000:]
 def warnings(text,location):
  return sorted(set(re.sub(r'\(\d+(?:,\d+)?\)(?=:)', '',line.replace(str(location),'<sdk>')).strip() for line in text.splitlines() if re.search(r'\bwarning [A-Z]+[0-9]+:',line,re.I)))
 current=warnings(build.stdout+build.stderr,root)
 baseline=subprocess.check_output(['git','rev-parse','HEAD'],text=True).strip()
 version=subprocess.check_output(['dotnet','--version'],text=True).strip()
 cache_key=hashlib.sha256((baseline+version+str(root)).encode()).hexdigest()
 cache=pathlib.Path(tempfile.gettempdir())/('vcc-dotnet-warning-baseline-'+cache_key+'.json')
 if cache.exists(): old=json.loads(cache.read_text())
 else:
  with tempfile.TemporaryDirectory(prefix='vcc-dotnet-baseline-') as bd:
   dest=pathlib.Path(bd)
   archive=subprocess.check_output(['git','archive','HEAD'])
   with tarfile.open(fileobj=io.BytesIO(archive)) as tar:tar.extractall(dest,filter='data')
   result=subprocess.run(['dotnet','build','ams-dotnet/ams-dotnet.csproj','--nologo'],cwd=dest,capture_output=True,text=True)
   assert result.returncode==0,result.stdout[-4000:]+result.stderr[-2000:]
   old=warnings(result.stdout+result.stderr,dest);cache.write_text(json.dumps(old))
 assert current==old,'New or unverified .NET project compiler warning: '+str(set(current)-set(old))
 compile_evidence=['Actual SDK project build; '+str(len(current))+' unique compiler warnings exactly reproduced at '+baseline]
 dlls=list((root/'ams-dotnet/bin').rglob('ams-dotnet.dll'))
assert dlls,'Native SDK project build did not create an assembly'
dll=next((x for x in dlls if '/ref/' not in str(x)),None);assert dll
with tempfile.TemporaryDirectory(prefix='vcc-dotnet-observer-') as tmp:
 project=pathlib.Path(tmp);(project/'Program.cs').write_text(pathlib.Path(__file__).with_name('Observe.cs').read_text());(project/'Observe.csproj').write_text('<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net8.0</TargetFramework></PropertyGroup></Project>')
 result=subprocess.run(['dotnet','build',str(project/'Observe.csproj'),'--nologo','--verbosity','quiet'],capture_output=True,text=True,check=False)
 assert result.returncode==0,result.stderr[-4000:]+result.stdout[-4000:]
 result=subprocess.run(['dotnet',str(project/'bin/Debug/net8.0/Observe.dll'),str(dll),*sorted(names)],capture_output=True,text=True,check=False)
 assert result.returncode==0,result.stderr[-4000:]+result.stdout[-4000:]
 actual=json.loads(result.stdout);actual['models']={k:v for k,v in actual['models'].items() if k in req['models']};actual['evidence']+=compile_evidence;print(json.dumps(actual))
