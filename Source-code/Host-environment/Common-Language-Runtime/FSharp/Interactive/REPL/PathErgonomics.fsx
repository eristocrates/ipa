#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

open System
open System.IO





type FileInfo with
    member this.stem = Path.GetFileNameWithoutExtension this.Name
    member this.stemPath = Path.Combine(this.DirectoryName, this.stem)

type DirectoryInfo with
    member this.CopyTo(targetDirectory: DirectoryInfo) =
        // Create target directory if it doesn't exist
        if not (targetDirectory.Exists) then
            Directory.CreateDirectory targetDirectory.FullName
            |> ignore


        // 1. Copy all files in the current directory
        for file in this.GetFiles() do
            let targetFilePath = Path.Combine(targetDirectory.FullName, file.Name)
            file.CopyTo(targetFilePath, true) |> ignore

        // 2. Recursively copy all subfolders
        for subdirectory in this.GetDirectories() do

            let targetSubdirectory = targetDirectory.CreateSubdirectory subdirectory.Name
            subdirectory.CopyTo targetSubdirectory


module Folder =
    let Generated =
        Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\Namespace\Generated"

    let Scratch =
        Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Scratch"

    let fiboMaster =
        DirectoryInfo @"D:\Iri\https\spec.edmcouncil.org\fibo\ontology\master"

    let ``spec.edmcouncil.org`` = DirectoryInfo @"D:\Iri\https\spec.edmcouncil.org"
    let Downloads = DirectoryInfo @"C:\Users\CollierB\Downloads"
    let Iri = Directory.CreateDirectory @"D:\Iri"

    let DoxAletheia =
        Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia"

    let Vocabulary =
        Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Vocabulary"

    let SolarWinds = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds"
    let NeoGov = Directory.CreateDirectory @"D:\Artifact\Company\NeoGov"
    let SunshineHealth = Directory.CreateDirectory @"D:\Artifact\Company\SunshineHealth"
    let MicrosoftGraph = Directory.CreateDirectory @"D:\Artifact\Company\MicrosoftGraph"


module PathName =
    open System.IO
    open AngleSharp.Html

    let private invalidChars = Path.GetInvalidFileNameChars() |> Set.ofArray

    let makeAcceptable (value: string) =
        value
        |> String.collect (fun character ->
            if invalidChars.Contains character then
                match HtmlEntityProvider.ReverseResolver.GetName(string character) with
                | null -> $"&#x{int character:X};"
                | name -> $"&{name}"
            else
                string character)
