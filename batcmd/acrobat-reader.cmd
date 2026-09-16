@echo off
set "acrobatReader=C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:acrobatReader" %*