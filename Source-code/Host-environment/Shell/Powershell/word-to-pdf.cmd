@echo off
PowerShell.exe -NoLogo -NoProfile -NoExit -ExecutionPolicy RemoteSigned -File "C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Shell\Powershell\doc_to_pdf.ps1" %*
