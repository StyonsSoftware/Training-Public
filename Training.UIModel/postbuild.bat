::assumes two things. without both things, this batch file will silently do nothing.
::1 - post-build event set in visual studio of:    "$(ProjectDir)postbuild.bat" "$(ProjectDir)" "$(TargetFileName)" "$(TargetDir)"
::2 - an environment variable called ROOT_CURRENT, set to the local deploy folder.
::    for example:      setx ROOT_CURRENT "c:\program files\blackbaud"
::    (restart visual studio for it to become aware of new environment variables)

GOTO VERIFY_ENVIRONMENT_VARIABLES
:VERIFY_COMPLETE

set target_bin=%ROOT_CURRENT%\bbappfx\vroot\bin\custom\
set target_htm=%ROOT_CURRENT%\bbappfx\vroot\browser\htmlforms\custom\
if not exist "%target_bin%" mkdir "%target_bin%"
if not exist "%target_htm%" mkdir "%target_htm%"
xcopy "%~3%~2" "%target_bin%" /y /e /d
xcopy "%~1htmlforms\custom\*.*" "%target_htm%" /y /e /d

GOTO :END

:VERIFY_ENVIRONMENT_VARIABLES
SET ANY_PROBLEM=N
IF DEFINED ROOT_CURRENT (
  echo off
) else (
  SET ANY_PROBLEM=Y
)
if %ANY_PROBLEM%==Y (
    GOTO :END
) else (
    echo off
)
GOTO :VERIFY_COMPLETE
:END