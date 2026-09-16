@echo off
set "xml=D:\https\com\github\eristocrates\ipa\exe\xmlstarlet\xmlstarlet-1.6.1\xml.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:xml" %*