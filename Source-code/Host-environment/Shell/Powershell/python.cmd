@echo off
setlocal
rem === configure your portable interpreter ===
set "PY=C:\Repositories\eristocrates\ipa\Language\Python\python-full-3.13.4-windows-x86_64\bin\python.exe"

rem === discover the user-site directory for this interpreter ===
for /f "usebackq delims=" %%S in (`"%PY%" -m site --user-site`) do set "US=%%S"

rem === expose it for THIS process only (no global changes) ===
set "PYTHONPATH=%US%"
set "PYTHONNOUSERSITE="

rem === pass-through to Python ===
"%PY%" %*
endlocal & exit /b %errorlevel%
