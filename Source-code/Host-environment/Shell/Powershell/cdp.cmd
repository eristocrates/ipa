@echo off
:: Use PowerShell to get the current directory path and copy it to clipboard.
:: Quotes are added only if the path contains spaces.
powershell -NoLogo -NoProfile -Command ^
  "& 'C:\Program Files\Google\Chrome\Application\chrome.exe' --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation"
