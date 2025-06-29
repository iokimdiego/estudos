@echo off
REM Define o caminho do SDK do .NET (já extraído)
set DOTNET_ROOT=C:\dotnet
set PATH=%DOTNET_ROOT%;%PATH%

REM Vai para a pasta onde o .BAT está (e onde os projetos ficarão)
cd /d "%~dp0"
REM cd "C:\Users\022864012267\OneDrive\Documentos\Cursos\DESENVOLVEDOR FULL STACK\estudos\CSharp"

REM Cria um projeto novo (caso queira, comente essa linha se já tiver o projeto criado)
REM %DOTNET_ROOT%\dotnet.exe new console -o MeuProjeto

REM Acessa o projeto (troque pelo nome do seu projeto se necessário)
cd CSharpPOO\Encapsulamento

REM Executa o projeto
%DOTNET_ROOT%\dotnet.exe run

pause
