@echo off
powershell -NoLogo -NoProfile -NoExit -ExecutionPolicy RemoteSigned dnx "Microsoft.PowerApps.CLI.Tool --yes " %*
