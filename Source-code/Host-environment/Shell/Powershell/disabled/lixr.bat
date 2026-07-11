@echo off
setlocal

set "JAR=C:\Users\CollierB\ontologies\adapters\driven\infrastructure\file-conversion\scala\lixr\target\scala-2.10\lixr-assembly-0.1.jar"
set "JAVA=C:\Users\CollierB\.shbin\shj8\bin\java.exe"

rem Construct full paths to arguments assuming they are in the current directory
set "MODEL=%CD%\%1"
set "INPUT=%CD%\%2"

%JAVA% -jar "%JAR%" "%MODEL%" "%INPUT%"

endlocal
