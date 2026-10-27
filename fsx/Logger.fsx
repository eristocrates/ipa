#time on

fsi.PrintLength <- 1
// fsi.PrintSize <- Int32.MaxValue
fsi.ShowDeclarationValues <- true
#I @"D:\https\com\github\eristocrates\ipa\dll"
#load @".paket/load/main.group.fsx"

open System
open System.Collections
open System.Globalization
open System.IO

open FSLogger

type Logger =
    | Logger of FSLogger.Logger

    member this.logger =
        match this with
        | Logger logger -> logger

    /// Highest level.
    member this.Fatal = this.logger.F
    /// Higher than the warn level and lower than the fatal level.
    member this.Error = this.logger.E
    /// Higher than the notice level and lower than the error level.
    member this.Warn = this.logger.W
    /// Higher than the info level and lower than the warn level.
    member this.Notice = this.logger.N
    /// Higher than the debug level and lower than the notice level.
    member this.Info = this.logger.I
    /// Higher than the trace level and lower than the info level.
    member this.Debug = this.logger.D
    /// Lowest level.
    member this.Trace = this.logger.T

    member this.WithConsumer(consumer: FSLogger.LogEntry -> unit) =
        this.logger |> FSLogger.Logger.addConsumer consumer |> Logger

    member this.WithPath(path: string) =
        this.logger |> FSLogger.Logger.withPath "%s" path |> Logger
    member this.WithLogFile(filePath: string) =
        let fullPath = Path.GetFullPath filePath

        Directory.CreateDirectory(Path.GetDirectoryName fullPath) |> ignore
        this.WithConsumer(fun entry -> File.AppendAllText(fullPath, entry.ToString() + Environment.NewLine))

let log =
    FSLogger.Logger.ColorConsole
    |> Logger
    |> fun logger -> logger.WithLogFile(sprintf "%s/log/%s.log" __SOURCE_DIRECTORY__ (DateTime.Now.ToString("yyy/MM/dd")))
