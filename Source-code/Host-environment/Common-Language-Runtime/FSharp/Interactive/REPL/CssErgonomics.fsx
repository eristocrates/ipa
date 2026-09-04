#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open System
open BrowserApi.Css.Authoring


type El with
    static member Iframe = Selector "iframe"
    static member I = Selector "i"

type Attr with
    static member Tabindex = AttrSelector "tabindex"
