; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{33249822-D661-4E07-91C5-821FA8E479DA}
AppName=maycham
AppVersion=1.5
;AppVerName=maycham 1.5
AppPublisher=My Company
DefaultDirName={pf}\maycham
DisableProgramGroupPage=yes
OutputDir=C:\Users\admin\Desktop
OutputBaseFilename=setup_maycham
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "D:\nguyentu\Ho so NCKH may cham trac nghiem\ChamThi\ChamThi\bin\Debug\ChamThi.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\nguyentu\Ho so NCKH may cham trac nghiem\ChamThi\ChamThi\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\maycham"; Filename: "{app}\ChamThi.exe"
Name: "{commondesktop}\maycham"; Filename: "{app}\ChamThi.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\maycham"; Filename: "{app}\ChamThi.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\ChamThi.exe"; Description: "{cm:LaunchProgram,maycham}"; Flags: nowait postinstall skipifsilent

