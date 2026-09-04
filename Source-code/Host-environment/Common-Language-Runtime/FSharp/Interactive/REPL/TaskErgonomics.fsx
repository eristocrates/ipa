#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open System.Threading.Tasks

type Task<'OutputType> with
    member this.await = this.GetAwaiter().GetResult()

type Task with
    member this.await = this.GetAwaiter().GetResult()

let await (operation: Task<'OutputType>) : 'OutputType = operation.GetAwaiter().GetResult()

let awaitUnit (task: Task) = task.GetAwaiter().GetResult()
