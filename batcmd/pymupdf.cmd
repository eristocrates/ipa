@echo off
powershell -NoLogo -NoProfile -ExecutionPolicy Bypass -Command "py -m pymupdf" %* 
