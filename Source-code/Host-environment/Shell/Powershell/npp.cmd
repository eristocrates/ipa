@echo off
set "notepadPlusPlus=C:\Repositories\eristocrates\ipa\Application\notepadPlusPlus\npp.8.9.8.portable.x64\notepad++.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:notepadPlusPlus" %*
