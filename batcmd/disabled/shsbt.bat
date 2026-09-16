@echo off
REM === shadow-sbt.bat ===
REM === Forces sbt to run through your java.bat via JAVA_CMD shim ===

set "JAVA_HOME=C:\Users\CollierB\.shbin\shj"
set "JAVA_CMD=C:\Users\CollierB\.shbin\shj\bat\java.bat"
set "COURSIER_JAVA_HOME=%JAVA_HOME%"
REM Optional: add more memory or debugging
set "JAVA_OPTS=-Dfile.encoding=UTF-8"

REM Call sbt directly
sbt %*
