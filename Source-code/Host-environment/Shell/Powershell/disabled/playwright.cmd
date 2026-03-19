@echo off
PowerShell.exe -NoLogo -NoProfile -NoExit -ExecutionPolicy RemoteSigned -File "C:\rdfsharp\rdfsharpconsole\bin\Debug\net9.0\playwright.ps1" %*
