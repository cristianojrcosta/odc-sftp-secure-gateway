# Builds the ODC external library package (.NET 10, linux-x64) into ..\Dist\ODC-SFTP.zip
Set-Location $PSScriptRoot
Remove-Item -Recurse -Force .\bin, .\obj -ErrorAction SilentlyContinue
New-Item -ItemType Directory -Force ..\Dist | Out-Null
dotnet publish .\DoiTLean.SFTP.csproj -c Release -r linux-x64 --no-self-contained
if ($LASTEXITCODE -ne 0) { throw "dotnet publish failed" }
Compress-Archive -Path .\bin\Release\net10.0\linux-x64\publish\* -DestinationPath ..\Dist\ODC-SFTP.zip -Force
