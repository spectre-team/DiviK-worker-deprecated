@echo off
cd C:\projects\spectre\src\Spectre.AngularClient
IF EXIST "C:\projects\spectre\src\Spectre.AngularClient\karma-tests.xml" (
    powershell C:\projects\spectre\scripts\Upload-TestResult.ps1 -fileName C:\projects\spectre\src\Spectre.AngularClient\karma-tests.xml
)
IF EXIST "C:\projects\spectre\src\Spectre.AngularClient\protractor-tests.xml" (
    powershell C:\projects\spectre\scripts\Upload-TestResult.ps1 -fileName C:\projects\spectre\src\Spectre.AngularClient\protractor-tests.xml
)
