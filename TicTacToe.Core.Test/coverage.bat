
@ECHO OFF
REM ..\..\..\packages\OpenCover.4.5.2506\OpenCover.Console.exe -target:..\..\..\packages\NUnit.Runners.2.6.3\tools\nunit-console.exe -targetargs:"<ASSEMBLY>.UnitTest.dll /noshadow /nologo" -register:user -filter:"+[<assembly>*]* -[<assembly>.DataModel]* -[<assembly>.UnitTest]* -[<assembly>.Diagrams]*"" -filter:-excludebyfile:*\*Designer.cs -mergebyhash
..\..\..\packages\OpenCover.4.5.2506\OpenCover.Console.exe -target:..\..\..\packages\NUnit.Runners.2.6.3\tools\nunit-console.exe -targetargs:"TicTacToe.Core.Test.dll /noshadow /nologo /framework:net-4.5" -register:user -mergebyhash
REM Default filters are: -[mscorlib]* -[mscorlib.*]* -[System]* -[System.*]* -[Microsoft.VisualBasic]*
REM delete old coverage files
REM /F /Q switches to delete files and directories even with readonly attribute without confirmation
DEL /F /Q .\coverage\*.*
REM Generate HTML based coverage reports
..\..\..\packages\ReportGenerator.1.9.1.0\reportgenerator.exe -reports:results.xml -targetdir:coverage Verbosity: Error
REM invoke the html coverage summary in browser
"C:\Program Files (x86)\Mozilla Firefox\firefox.exe" .\coverage\index.htm