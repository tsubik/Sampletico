@echo off
set msbuild=%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
%msbuild% /m build.xml /v:m /p:VisualStudioVersion=12.0 /t:RebuildDataProject 

Sampletico.Data\bin\Release\Sampletico.Data.exe /migrations