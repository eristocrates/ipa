#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "PathErgonomics.dll"

open PathErgonomics

open System
open System.IO

open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Text


let compileScriptToDll (sourceFilePath: string) =

    async {

        let sourceFilePath = Path.GetFullPath sourceFilePath

        let outputFilePath = Path.ChangeExtension(sourceFilePath, ".dll")

        let outputDirectory = Path.GetDirectoryName outputFilePath

        Directory.CreateDirectory outputDirectory
        |> ignore

        let checker = FSharpChecker.Create()

        let sourceText =
            File.ReadAllText sourceFilePath
            |> SourceText.ofString

        let! projectOptions, optionDiagnostics = checker.GetProjectOptionsFromScript(sourceFilePath, sourceText, assumeDotNetFramework = false, useFsiAuxLib = true, useSdkRefs = true, previewEnabled = true)

        for diagnostic in optionDiagnostics do
            printfn "%O" diagnostic

        let sourceFiles =
            projectOptions.SourceFiles
            |> Array.filter (fun filePath -> not (filePath.EndsWith(".fsproj.fsx")))

        let compilerArguments =
            [|
               // FSharpChecker.Compile explicitly ignores its first
               // argument, but expects one.
               "fsc.exe"

               yield! projectOptions.OtherOptions

               "--target:library"
               $"--out:{outputFilePath}"

               yield! sourceFiles |]

        let! diagnostics, terminatingException = checker.Compile compilerArguments

        for diagnostic in diagnostics do
            printfn "%O" diagnostic

        match terminatingException with
        | Some xception -> return Error xception

        | None ->

            let hasErrors =
                diagnostics
                |> Array.exists (fun diagnostic -> diagnostic.Severity = FSharpDiagnosticSeverity.Error)

            if hasErrors then
                return Error(InvalidOperationException($"Compilation of '{sourceFilePath}' failed."))

            else
                return Ok outputFilePath
    }

let targetFileNames =
    [| "rdf"
       "voaf"
       "vann"
       "foaf"
       "vs"
       "hydra"
       "void"
       "vaem"
       "dcterms"
       "dcat" |]
    |> Array.map (fun prefix -> $"{prefix}Namespace.fsx")
    |> Set.ofArray

let compilationTargets =
    Folder.Generated.GetFiles("*.fsx")
    |> Array.filter (fun fsxFile -> targetFileNames.Contains(fsxFile.Name)
    (*
        let dllFile =
            Path.ChangeExtension(fsxFile.FullName, ".dll")
            |> FileInfo
        not dllFile.Exists
    *)

    )
    |> Array.sortBy (fun fsxFile -> fsxFile.Length)

let totalTargets = compilationTargets.Length
(*

compilationTargets
|> Array.mapi (fun index fsxFile ->
    printfn "%d of %d %s" index totalTargets fsxFile.Name
    compileScriptToDll fsxFile.FullName
    |> Async.RunSynchronously)

*)

compileScriptToDll @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\Namespace\Generated\fibo-loan-ln-lnNamespace.fsx"
|> Async.RunSynchronously
