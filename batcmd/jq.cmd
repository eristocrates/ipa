@echo off
set "jq=D:\https\com\github\eristocrates\ipa\exe\jq\jq-windows-amd64.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:jq" %*
