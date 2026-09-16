@echo off
set "jva=D:\Program_Files\Java\jdk-17.0.2\bin\jva.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:jva" %*