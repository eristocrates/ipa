@echo off
powershell -NoLogo -NoProfile -WindowStyle Hidden -ExecutionPolicy Bypass -Command "python C:\Repositories\eristocrates\ipa\Language\Python\python-full-3.13.4-windows-x86_64\Lib\site-packages\git_filter_repo.py" %* 
