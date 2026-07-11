@echo off
REM === Check for input argument ===
if "%~1"=="" (
    echo Usage: xs2owl.bat path\to\yourfile
    exit /b 1
)

REM === Define paths ===
set SAXON_JAR=C:\Users\CollierB\.path\sembin\saxon9he.jar
set XSLT=C:\Users\CollierB\.path\sembin\xs2owl2.0.10.xsl

REM === Run transformation ===
java -jar "%SAXON_JAR%" -s:"%~1" -xsl:"%XSLT%"

REM === Optional: pause for viewing output ===
REM pause