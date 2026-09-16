@echo off
REM Forward ALL arguments directly to swipl.exe
 %*

@echo off
set "swipl=D:\Program_Files\Prolog\SWI-Prolog\swipl-9.2.9-1.x64\bin\swipl-win.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:swipl" %*
