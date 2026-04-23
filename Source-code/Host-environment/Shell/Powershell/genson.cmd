@echo off
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "py -m genson -e utf-8" %* 
