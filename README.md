# odc-sftp


## Getting started
This is a fork from https://github.com/doitleanlabs/odc-sftp, where we simple add Cloud Connector -> Secure Gateway capabilities, all credits go to original creator.
This assets is a source code for OutSystems External Logic SFTP that allows SSH File Transfer Protocol (SFTP) being used in your applications. 
Supported commands: Delete, Get, List, Move, Put, Mkdir, Rmdir, Search.

## Building (.NET 10)

This library targets `net10.0`, as required by ODC for custom code. You need the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

From the `DoiTLean.SFTP` folder run the packaging script in PowerShell:

```powershell
.\generate_upload_package.ps1
```

Or run the steps by hand:

```powershell
cd DoiTLean.SFTP
Remove-Item -Recurse -Force bin, obj -ErrorAction SilentlyContinue
dotnet publish .\DoiTLean.SFTP.csproj -c Release -r linux-x64 --no-self-contained
Compress-Archive -Path bin\Release\net10.0\linux-x64\publish\* -DestinationPath ..\Dist\ODC-SFTP.zip -Force
```

Upload `Dist/ODC-SFTP.zip` in the ODC Portal. The DLLs must be at the root of the ZIP, not inside a folder.

## OutSystems Links

- [ ] [ODC Documentation](https://success.outsystems.com/documentation/outsystems_developer_cloud/)
- [ ] [ODC External Logic](https://success.outsystems.com/documentation/outsystems_developer_cloud/building_apps/extend_your_apps_with_external_logic/)
- [ ] [ODC External Libraries SDK](https://success.outsystems.com/documentation/outsystems_developer_cloud/building_apps/extend_your_apps_with_external_logic/external_libraries_sdk_readme/)
- [ ] https://success.outsystems.com/documentation/outsystems_developer_cloud/building_apps/extend_your_apps_with_custom_code/external_libraries_sdk_readme/#use-with-the-private-gateway-feature

***
