@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.ShuntingYard\bin\Release\Panosen.ShuntingYard.*.nupkg D:\LocalSavoryNuget\

pause