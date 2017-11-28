cd C:\projects\DiviK-worker
7z a %1-%CONFIGURATION%.zip "%APPVEYOR_BUILD_FOLDER%\Deployments\%2\*" >nul 2>&1
