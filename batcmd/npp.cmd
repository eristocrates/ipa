@echo off
set "notepadPlusPlus=D:\notepadPlusPlus\npp.8.9.8.1.portable.x64\notepad++.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:notepadPlusPlus" %*
