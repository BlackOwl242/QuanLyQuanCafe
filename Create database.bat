@echo off
setlocal

:: ============================================================================
:: CAU HINH 
:: ============================================================================

:: 1. Ten file SQL (phai duoc dat cung thu muc voi file batch nay)
set "SCRIPT_FILENAME=data.sql"

:: 2. Ten Server va Instance SQL (Vi du: localhost, .\SQLExpress, (localdb)\MSSQLLocalDB)
set "SERVER_INSTANCE=localhost"

:: 3. Ten Database (QUAN TRONG: De trong neu ban khong muon chi dinh database cu the)
set "DATABASE_NAME="

:: 4. Ten thu muc log cho ung dung cua ban
set "APP_NAME=CafeShopManagement"

:: ============================================================================
:: THUC THI 
:: ============================================================================
echo.
echo  ==============================================
echo  ==      SQL SCRIPT EXECUTOR - v2.0          ==
echo  ==============================================

:: --- Buoc 1: Chuan bi duong dan an toan ---
:: Su dung "%~dp0" de lay duong dan tuyet doi den thu muc chua file batch,
:: giai quyet van de "khong tim thay file".
set "SCRIPT_FULL_PATH=%~dp0%SCRIPT_FILENAME%"

:: Su dung "%LOCALAPPDATA%" de lay duong dan den thu muc an toan cua user,
:: giai quyet van de "Access is denied".
set "LOG_DIR=%LOCALAPPDATA%\%APP_NAME%"
set "LOG_FILE=%LOG_DIR%\sql_output.log"

:: --- Buoc 2: Kiem tra moi truong ---
:: Tao thu muc log neu chua ton tai.
if not exist "%LOG_DIR%\" mkdir "%LOG_DIR%"

:: Kiem tra file SQL co thuc su ton tai khong.
if not exist "%SCRIPT_FULL_PATH%" (
    echo.
    echo  [ERROR] Khong tim thay file SQL.
    echo          Kiem tra xem file '%SCRIPT_FILENAME%' co dat cung thu muc voi file batch khong.
    echo          Duong dan dang tim: "%SCRIPT_FULL_PATH%"
    goto :End
)

echo.
echo  - Server:      "%SERVER_INSTANCE%"
echo  - Script:      "%SCRIPT_FULL_PATH%"
echo  - Log se duoc ghi tai: "%LOG_FILE%"
echo  ----------------------------------------------
echo  Dang thuc thi...

:: --- Buoc 3: Thuc thi SQLCMD mot cach an toan ---
:: Xay dung va chay lenh sqlcmd tuy theo DATABASE_NAME co duoc dinh nghia hay khong.
:: Cach nay dam bao cac tham so luon duoc dat trong ngoac kep, tranh loi cu phap.
if defined DATABASE_NAME (
    sqlcmd -E -S "%SERVER_INSTANCE%" -d "%DATABASE_NAME%" -i "%SCRIPT_FULL_PATH%" > "%LOG_FILE%" 2>&1
) else (
    sqlcmd -E -S "%SERVER_INSTANCE%" -i "%SCRIPT_FULL_PATH%" > "%LOG_FILE%" 2>&1
)

:: --- Buoc 4: Kiem tra ket qua ---
if %ERRORLEVEL% neq 0 (
    echo.
    echo  [ERROR] Phat hien loi trong qua trinh thuc thi.
    echo          Vui long mo file log de xem chi tiet.
    echo          Ban co the chay lenh sau de mo file log:
    echo          notepad "%LOG_FILE%"
) else (
    echo.
    echo  [SUCCESS] Thuc thi script thanh cong!
)

:End
echo.
pause
