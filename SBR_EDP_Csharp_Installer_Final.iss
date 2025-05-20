; -- Inno Setup Script for SBR EDP C# Application --

[Setup]
AppName=SBR EDP C# Application
AppVersion=1.0
DefaultDirName={pf}\SBR_EDP_Csharp_App
OutputDir=.
OutputBaseFilename=SBR_EDP_Installer
Compression=lzma
SolidCompression=yes

[Files]
; Application executable
Source: "EDPProjSetup\Debug\EDPProjSetup.msi"; DestDir: "{app}"; Flags: ignoreversion

; DLL dependencies
Source: "bin\Debug\net8.0-windows\EDP_Project.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\EPPlus.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\System.IO.Pipelines.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\System.Security.Cryptography.Pkcs.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\System.Security.Cryptography.Xml.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\System.Text.Encodings.Web.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\System.Text.Json.dll"; DestDir: "{app}"; Flags: ignoreversion

Source: "bin\Debug\net8.0-windows\BouncyCastle.Cryptography.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\EPPlus.Interfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\K4os.Compression.LZ4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\K4os.Compression.LZ4.Streams.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\K4os.Hash.xxHash.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.Configuration.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.Configuration.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.Configuration.FileExtensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.Configuration.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.FileProviders.Abstractions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.FileProviders.Physical.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.FileSystemGlobbing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.Extensions.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\Microsoft.IO.RecyclableMemoryStream.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "bin\Debug\net8.0-windows\ZstdSharp.dll"; DestDir: "{app}"; Flags: ignoreversion

; MySQL setup files
Source: "init_db.sql"; DestDir: "{app}"; Flags: ignoreversion
Source: "SBRDB.sql"; DestDir: "{app}"; Flags: ignoreversion
Source: "setup_mysql.bat"; DestDir: "{app}"; Flags: ignoreversion

; MySQL Installer
Source: "mysql-installer-community-8.0.42.0.msi"; DestDir: "{tmp}"; Flags: ignoreversion

[Run]
; Silent installation of MySQL
Filename: "msiexec.exe"; Parameters: "/i ""{tmp}\mysql-installer-community-8.0.42.0.msi"" /qn /norestart"; Flags: runhidden waituntilterminated

; Execute MySQL configuration and DB restoration
Filename: "cmd.exe"; Parameters: "/C ""{app}\setup_mysql.bat"""; Flags: runhidden waituntilterminated

; Launch the C# application
Filename: "{app}\EDPProjSetup.msi"; Description: "Launch Application"; Flags: nowait postinstall skipifsilent

[Icons]
Name: "{group}\SBR EDP App"; Filename: "{app}\EDPProjSetup.msi"
