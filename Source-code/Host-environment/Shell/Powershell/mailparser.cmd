@echo off
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "python -m mailparser" %* 
