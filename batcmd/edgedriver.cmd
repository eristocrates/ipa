@echo off
set "msedgedriver=D:\Program_Files\Microsoft\Edge\Version156.0.4314.50\msedgedriver.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:msedgedriver --port=9515 --verbose --log-path=D:\Program_Files\Microsoft\Edge\edgedriver.log" %*