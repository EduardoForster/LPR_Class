@echo off
setlocal

:: === CONFIGURAÇÃO INICIAL ===
:: Nome da aula e quantidade de exercícios
set /p AULA=Digite o nome da aula (ex: Aula_10): 
set /p QTD=Quantos exercícios quer criar: 

echo.
echo Criando pasta %AULA% com %QTD% exercicios...
mkdir %AULA%
cd %AULA%

:: === CRIAR PROJETOS ===
for /L %%i in (1,1,%QTD%) do (
    echo.
    echo Criando Ex_%%i...
    mkdir Ex_%%i
    cd Ex_%%i
    dotnet new console -n Ex_%%i >nul
    cd ..
)

:: === CRIAR SOLUÇÃO ===
dotnet new sln -n %AULA%
for /L %%i in (1,1,%QTD%) do (
    dotnet sln %AULA%.sln add Ex_%%i\Ex_%%i.csproj
)

echo.
echo =============================
echo Aula %AULA% criada com sucesso!
echo =============================
pause