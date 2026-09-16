@echo off
REM === Saxon XSLT transformation wrapper ===
REM Usage: run-xslt.bat input.xml transform.xsl output.xml

if "%~3"=="" (
  echo ❌ Usage: %~nx0 input.xml transform.xsl output.xml
  exit /b 1
)

REM Set your Saxon JAR path here
set SAXON_JAR=C:\Users\CollierB\.path\sembin\saxon9he.jar

java -jar "%SAXON_JAR%" -s:"%~1" -xsl:"%~2" -o:"%~3"
if errorlevel 1 (
  echo ❌ Transformation failed.
  exit /b %errorlevel%
)

echo ✅ Transformation complete. Output saved to %~3
