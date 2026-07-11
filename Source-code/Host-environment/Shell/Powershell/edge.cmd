@echo off
set "msedge=C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:msedge --remote-debugging-port=9222 --user-data-dir=C:\Repositories\eristocrates\ipa\Application\Microsoft\Edge\data_dir" %*