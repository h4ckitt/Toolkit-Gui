@echo off

set /a rand=%random%


for /F "tokens=*" %%i in (%temp%\toolkit\file.txt) do set x="%%i"

for /F %%a in (%temp%\toolkit\operation.txt) do set y="%%a"

if %y% == "send" (adb push %x% /storage/sdcard0 && del %temp%\toolkit\operation.txt && call:eof)
if %y% == "recovery" (adb reboot recovery && del %temp%\toolkit\operation.txt && call:eof)
if %y% == "reb_btldr" (adb reboot bootloader && del %temp%\toolkit\operation.txt && call:eof)
if %y% == "install" (adb install %x% && del %temp%\toolkit\operation.txt && call:eof)
if %y% == "screencap" (adb shell screencap -p /storage/sdcard0/pic%rand%.png)
:eof
exit