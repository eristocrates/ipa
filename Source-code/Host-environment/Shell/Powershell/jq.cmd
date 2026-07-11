@echo off
set "jq=C:\Repositories\eristocrates\ipa\Language\Json\jq-windows-amd64.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:jq" %*
