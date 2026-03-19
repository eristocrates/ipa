@SETLOCAL
@IF EXIST "%~dp0\node.bat" (
  "%~dp0\node.bat"  "%~dp0\node_modules\corepack\dist\corepack.js" %*
) ELSE (
  @SET PATHEXT=%PATHEXT:;.JS;=;%
  node  "%~dp0\node_modules\corepack\dist\corepack.js" %*
)
