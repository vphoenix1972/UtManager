@echo off

REM This script allows you to add migration using connection string in appsettings.json

SETLOCAL

SET cmd=%1

IF "%cmd%"=="" GOTO showHelp
IF "%cmd%"=="help" GOTO showHelp
IF "%cmd%"=="add" GOTO addMigration
IF "%cmd%"=="remove" GOTO removeMigration
IF "%cmd%"=="update" GOTO updateDatabase

GOTO end



:addMigration

SET migrationName=%2
IF "%migrationName%"=="" GOTO showHelp

REM Hack: ef migrations starts in bin\Debug\netcoreapp1.1
REM There is no config file there, so copy and delete it after
copy /y appsettings.json bin\Debug\netcoreapp1.1\appsettings.json

dotnet ef migrations add "%migrationName%"

del bin\Debug\netcoreapp1.1\appsettings.json

GOTO end



:removeMigration

copy /y appsettings.json bin\Debug\netcoreapp1.1\appsettings.json

dotnet ef migrations remove

del bin\Debug\netcoreapp1.1\appsettings.json

GOTO end


:updateDatabase

SET migrationName=%2

copy /y appsettings.json bin\Debug\netcoreapp1.1\appsettings.json

dotnet ef database update "%migrationName%"

del bin\Debug\netcoreapp1.1\appsettings.json

GOTO end



:showHelp

ECHO.
ECHO This script allows you to add or remove a migration using connection string from appsettings.json.
ECHO.
ECHO Usage:
ECHO    migrations.cmd add ^<MigrationName^> - adds a new migration
ECHO    migrations.cmd remove - removes latest migration
ECHO    migrations.cmd update ^<MigrationName^> - updates the database the latest version (applies all migrations)
ECHO    help - show this message
ECHO.

GOTO end

:end

ENDLOCAL