@echo off
:: This Script is by Genouka
:: Licensed under MPL2.0

set "ExecutePath=%~dp0"
cd /D "%ExecutePath%..\AutoExtractedAssets"
del /q /f "%ExecutePath%..\UndertaleModToolAvalonia\Assets\sth.zip"
"%ExecutePath%7z.exe" a  -tzip "%ExecutePath%..\UndertaleModToolAvalonia\Assets\sth.zip" *