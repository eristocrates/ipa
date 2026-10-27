@echo off
set "msedgedriver=D:\Program_Files\Microsoft\Edge\Version156.0.4314.42\msedgedriver.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:msedgedriver --port=9515" %*