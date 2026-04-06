@echo off
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "python -m genson -e utf-8" %* 
