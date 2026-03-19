@echo off
:: Use PowerShell to get the current directory path and copy it to clipboard.
:: Quotes are added only if the path contains spaces.
powershell -NoLogo -NoProfile -Command ^
  "$p = (Get-Location).Path; if ($p -match ' ') { Set-Clipboard ('\"' + $p + '\"') } else { Set-Clipboard $p }"
