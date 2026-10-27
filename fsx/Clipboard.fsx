// https://fsharpforfunandprofit.com/posts/computation-expressions-intro/
#time on

fsi.PrintLength <- 1
fsi.PrintSize <- 3000
fsi.PrintWidth <- 100
fsi.ShowDeclarationValues <- true

#I @"D:\https\com\github\eristocrates\ipa\dll"
#load @".paket/load/main.group.fsx"

open System
open TextCopy

type Clipboard with
    member this.clip(text: string) = this.SetText text
    member this.clip(lines: #seq<string>) =
        lines |> String.concat "\n" |> this.clip

type String with
    static member Clipboard = new Clipboard()
    member this.clip = String.Clipboard.clip (this)
