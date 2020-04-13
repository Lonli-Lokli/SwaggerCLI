# SwaggerCLI

1. Clone repository
2. Build solution
3. Open cmd prompt in WebApplication folder, near csproj file
4. Run 
    swagger tofile --output v1.json --host example.com bin\Debug\netcoreapp2.1\WebApplication1.dll v1
    
    
    D:\PetProjects\SwaggerCLI\WebApplication1>swagger tofile --output v1.json --host example.com bin\Debug\netcoreapp2.1\WebApplication1.dll v1

Unhandled Exception: System.IO.FileLoadException: Could not load file or assembly 'System.Runtime.Loader, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'. The located assembly's manifest definition does not match the assembly reference. (Exception from HRESULT: 0x80131040)
   at Swashbuckle.AspNetCore.Cli.Program.<>c.<Main>b__0_3(IDictionary`2 namedArgs)
   at Swashbuckle.AspNetCore.Cli.CommandRunner.Run(IEnumerable`1 args) in C:\projects\ahoy\src\Swashbuckle.AspNetCore.Cli\CommandRunner.cs:line 68
   at Swashbuckle.AspNetCore.Cli.CommandRunner.Run(IEnumerable`1 args) in C:\projects\ahoy\src\Swashbuckle.AspNetCore.Cli\CommandRunner.cs:line 68
   at Swashbuckle.AspNetCore.Cli.Program.Main(String[] args) in C:\projects\ahoy\src\Swashbuckle.AspNetCore.Cli\Program.cs:line 107
   
   Additional info:
   
   D:\PetProjects\SwaggerCLI\WebApplication1>dotnet --info
.NET Core SDK (reflecting any global.json):
 Version:   3.1.101
 Commit:    b377529961

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.18363
 OS Platform: Windows
 RID:         win10-x64
 Base Path:   C:\Program Files\dotnet\sdk\3.1.101\

Host (useful for support):
  Version: 3.1.1
  Commit:  a1388f194c

.NET Core SDKs installed:
  3.1.101 [C:\Program Files\dotnet\sdk]

.NET Core runtimes installed:
  Microsoft.AspNetCore.All 2.1.14 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.All 2.2.8 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.All]
  Microsoft.AspNetCore.App 2.1.14 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 2.2.8 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 3.1.1 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 2.1.14 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 2.2.8 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 3.1.1 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 3.1.1 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]

To install additional .NET Core runtimes or SDKs:
  https://aka.ms/dotnet-download
   
