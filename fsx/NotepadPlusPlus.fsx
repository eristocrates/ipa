#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- true
#r "nuget: Newtonsoft.Json, 13.0.0.0"

#I @"D:\https\com\github\eristocrates\ipa\dll"
#I @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Me.fsx"
#load "Clipboard.fsx"
open Me
open Clipboard
#load @".paket/load/main.group.fsx"
#r "DoxAletheia.Runtime.dll"
open DoxAletheia.Runtime
open type Functional

open Microsoft.VisualBasic.FileIO
open System.IO

let copyDllDirectory (dllFile: FileInfo) =
    let fromDirectory = dllFile.DirectoryName
    let toDirectory = Path.Combine(dllFile.Directory.Parent.Parent.FullName, "plugins", dllFile.stem)
    FileSystem.CopyDirectory(fromDirectory, toDirectory, true)

let pluginslistDirectory = DirectoryInfo @"D:\notepadPlusPlus\npp.8.9.8.1.portable.x64\pluginslist"
let pluginDirectories = pluginslistDirectory.GetDirectories()

let erroredDirectories =
    pluginDirectories
    |> Array.Parallel.map (fun pluginDirectory ->
        match pluginDirectory.Name, pluginDirectory.GetFiles("*.dll") with
        | directoryName, dllFiles when directoryName.StartsWith("GraphBuilder-npp") ->
            let toDirectory = Path.Combine(pluginDirectory.Parent.Parent.FullName, "plugins", "GraphBuilderLaz")
            FileSystem.CopyDirectory(pluginDirectory.FullName, toDirectory, true)
            Ok(pluginDirectory)
        | directoryName, dllFiles when directoryName.StartsWith("LuaScript_") ->
            let toDirectory = Path.Combine(pluginDirectory.Parent.Parent.FullName, "plugins", "LuaScript")
            FileSystem.CopyDirectory(pluginDirectory.FullName, toDirectory, true)
            Ok(pluginDirectory)
        | _, dllFiles when dllFiles.Length = 1 ->
            dllFiles |> Array.iter copyDllDirectory
            Ok(pluginDirectory)
        | _, dllFiles ->
            match dllFiles |> Array.filter (fun file -> pluginDirectory.Name.StartsWith file.stem) with
            | [| dllFile |] ->
                copyDllDirectory dllFile
                Ok(pluginDirectory)
            | _ -> Error(pluginDirectory)

    )
    |> Array.choose (fun directoryResult ->

        match directoryResult with
        | Error directory -> Some directory
        | _ -> None)
erroredDirectories.Length
