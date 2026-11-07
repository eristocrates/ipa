@echo off
set "msedgedriver=D:\Program_Files\Microsoft\Edge\Version157.0.4341.42\msedgedriver.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:msedgedriver --port=9515 --verbose --log-path=D:\Program_Files\Microsoft\Edge\edgedriver.log" %*