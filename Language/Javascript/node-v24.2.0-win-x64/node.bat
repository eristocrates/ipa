@echo off
REM === Shadow shim for node ===
SETLOCAL ENABLEEXTENSIONS
SET "SCRIPT_DIR=%~dp0"
SET "NODE_REAL=C:\Users\CollierB\Programs\node-v24.2.0-win-x64\nde.exe"

REM === If no arguments, run REPL ===
IF "%~1"=="" (
    "%NODE_REAL%"
) ELSE (
    "%NODE_REAL%" %*
)
