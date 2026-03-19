@echo off
set "usg=C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Shell\Powershell\usg.ps1"
powershell -NoLogo -NoProfile -WindowStyle Hidden -ExecutionPolicy Bypass -Command "& $env:usg" %*