@echo off
set "notepadPlusPlus=C:\Users\CollierB\Programs\npp.8.5.8.portable.x64\notepad++.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:notepadPlusPlus" %*
