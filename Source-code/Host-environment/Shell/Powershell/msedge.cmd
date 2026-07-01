@echo off
set "msedge=C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:msedge " %*