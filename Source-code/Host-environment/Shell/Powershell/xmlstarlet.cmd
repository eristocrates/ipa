@echo off
set "xml=C:\Repositories\eristocrates\ipa\Language\Xml\xmlstarlet-1.6.1\xml.exe"
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "& $env:xml" %*