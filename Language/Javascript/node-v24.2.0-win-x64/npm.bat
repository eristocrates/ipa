@echo off
REM === Shadow shim for npm to bypass npm.ps1 execution policy ===
SETLOCAL
CALL "C:\Users\CollierB\Programs\node-v24.2.0-win-x64\npm.cmd" %*
