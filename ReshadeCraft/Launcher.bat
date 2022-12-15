@echo off
echo Getting ReshadeCraft Ready!
echo ----------------------------------
set root=%~dp0
echo %root%
if exist "C:\Users\%username%\Desktop\ReshadeCraft_Launcher" (
	echo Starting ReshadeCraft!
) else (
	echo Performing First Time Setup...
	robocopy %root%ReshadeCraft C:/Users/%username%/Desktop\ReshadeCraft_Launcher
	sleep 5
	start %root%gui/ReshadeCraft_WRAPPER
)
pause