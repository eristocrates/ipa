@echo off
set "jva=C:\Repositories\eristocrates\ipa\Language\Java\jdk-17.0.2\bin\jva.exe"
powershell -NoLogo -NoProfile -WindowStyle Hidden -ExecutionPolicy Bypass -Command "& $env:jva" %*