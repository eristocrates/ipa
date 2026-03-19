@echo off
set "jq=C:\Repositories\eristocrates\ipa\Language\Json\jq-windows-amd64.exe"
powershell -NoLogo -NoProfile -WindowStyle Hidden -ExecutionPolicy Bypass -Command "& $env:jq" %*
