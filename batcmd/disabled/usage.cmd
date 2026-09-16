@echo off
set "usg=D:\https\com\github\eristocrates\ipa\ps1\usg.ps1"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:usg" %*