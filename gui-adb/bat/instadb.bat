@echo off
set err=0 
:begin
if %err%==0 (call:question)
echo Please enter a valid option
echo.
:question
echo This program needs adb to work
echo.
set ch=Y
set /p ch="Install Adb ? (Y/n) Defaul(Y): "
if "%ch%"=="Y" goto install
if "%ch%"=="y" goto install
if "%ch%"=="n" call:eof
if "%ch%"=="N" goto eof
cls
set err=1
call:begin

:install

echo ^>Copying ADB Files
echo.
xcopy /R/Y .\dependencies\adbd\*.* C:\adb_by_dharmi\adb_v1.0.26\*.*
echo ^>ADB files copied
echo.
echo ^>Copying adb_usb.ini 
echo.
echo f|xcopy /R /Y /F .\dependencies\adb_usb.ini ""%userprofile%"\.android\adb_usb.ini"
if not "%ANDROID_SDK_HOME%" equ "" (xcopy /R /Y .\adb_usb\adb_usb.ini "%ANDROID_SDK_HOME%\.android\adb_usb.ini")
echo ^>Done
echo.
echo Setting enviromental Variables
echo.
set path|find "C:\adb_by_dharmi\adb_v1.0.26"
if "%ERRORLEVEL%" equ "1" call:env_var
echo Environmental Variable previously set
call:eof

:env_var
set path=C:\adb_by_dharmi\adb_v1.0.26;%PATH%
:: reg add "HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Session Manager\Environment" /v Path /t REG_EXPAND_SZ /d "%PATH%" /f
wmic ENVIRONMENT where "name='path' and username='<SYSTEM>'" set VariableValue='C:\adb_by_dharmi\adb_v1.0.26;%PATH%'
:eof
exit