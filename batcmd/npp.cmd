@echo off
set "notepadPlusPlus=D:\Program_Files\notepadPlusPlus\npp.8.9.8.portable.x64\notepad++.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:notepadPlusPlus" %*
