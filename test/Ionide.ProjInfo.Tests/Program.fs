// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Ionide.ProjInfo
open Ionide.ProjInfo.ProjectSystem

open Expecto
open Expecto.Impl
open Expecto.Logging


[<EntryPoint>]
let main argv =
    let toolsPath = Init.init (IO.DirectoryInfo Environment.CurrentDirectory) None

    Tests.runTestsWithArgs
        { defaultConfig with
            printer = TestPrinters.summaryPrinter defaultConfig.printer
            verbosity = LogLevel.Verbose }
        argv
        (Tests.tests toolsPath)
