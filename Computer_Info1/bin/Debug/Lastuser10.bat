@echo off
Color 0a
mode con:cols=120 lines=40
echo.
echo.
echo.
echo Zmiana ostatnio zalogowanego uzytkownika
echo.
echo.
echo.
set /p username=Wpisz nazwe uzytkownika: 
set domain=C4CR
ECHO Windows Registry Editor Version 5.00 >> change1.reg  
ECHO Windows Registry Editor Version 5.00 >> change2.reg
ECHO Windows Registry Editor Version 5.00 >> change3.reg  
ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI] >> change1.reg 
ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI] >> change2.reg 
ECHO [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI] >> change3.reg 
ECHO "LastLoggedOnUser"="%domain%\\%username%" >> change1.reg
ECHO "LastLoggedOnSAMUser"="%domain%\\%username%" >> change2.reg
ECHO "LastLoggedOnDisplayName"="%domain%\\%username%" >> change3.reg
C:\WINDOWS\regedit.exe /s change1.reg 
C:\WINDOWS\regedit.exe /s change2.reg 
C:\WINDOWS\regedit.exe /s change3.reg 
DEL change1.reg
DEL change2.reg
DEL change3.reg
echo.
echo.
echo.
echo.
echo I po robocie ;)                                                                 
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
color 9                                                                    
echo                       88      a8P          88        ,ad88PPP88ba,         ,ad8888ba,         ,d8    
echo                       88    ,88'           88       d8"  .ama.a "8a       d8"'    `"8b      ,d888    
echo                       88  ,88"             88      d8'  ,8P"88"  88      d8'              ,d8" 88    
echo                       88,d88'              88      88  .8P  8P   88      88             ,d8"   88    
echo                       8888"88,             88      88  88   8'   8P      88           ,d8"     88    
echo                       88P   Y8b            88      88  8B ,d8 ,ad8'      Y8,          8888888888888  
echo                       88     "88,  88,   ,d88      "8a "88P"888P"         Y8a.    .a8P         88    
echo                       88       Y8b  "Y8888P"        `Y8aaaaaaaad8P         `"Y8888Y"'          88    
echo                                                       """""""""""                                     
echo.
echo.
echo.
echo.
echo.
pause




