ECHO OFF
CLS
if NOT [%2] == [] GOTO CONFIG

if not exist %~dp0\bin\%1 (mkdir %~dp0\bin\%1)
if not exist %~dp0\bin\%1\debug (mkdir %~dp0\bin\%1\debug)
dotnet publish -o %~dp0\bin\%1\debug -r %1 --self-contained false -c debug
GOTO END

:CONFIG
if not exist %~dp0\bin\%1 (mkdir %~dp0\bin\%1)
if not exist %~dp0\bin\%1\%2 (mkdir %~dp0\bin\%1\%2)
dotnet publish -o %~dp0\bin\%1\%2 -r %1 --self-contained false -c %2
GOTO END

:END
goto:eof