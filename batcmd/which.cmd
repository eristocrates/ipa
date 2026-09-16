@echo off
powershell -NoProfile -Command "$c=Get-Command -ErrorAction SilentlyContinue '%~1'; if($c){$c.Source}else{exit 1}"
