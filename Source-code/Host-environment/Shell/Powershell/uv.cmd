@echo off
set "uv=C:\Repositories\eristocrates\ipa\Language\Python\uv\uv-x86_64-pc-windows-msvc-0.10.10\uv.exe"
powershell -NoLogo -NoProfile -WindowStyle Hidden -ExecutionPolicy Bypass -Command "& $env:uv" %*