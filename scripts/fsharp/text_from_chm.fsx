#load "ProcessExecution.fsx"

open ProcessExecution
open System
open System.IO



let anchorDirectory =
    @"D:\Surface\United_States_Government\County\Leon\Management_Information_Systems\Infor\Documentation\IPS_Reference_Guide_2025_04_01"


let chmFilePaths =
    Directory.EnumerateFiles(anchorDirectory, "*.chm", SearchOption.AllDirectories)



chmFilePaths
|> Seq.iter (fun chmFilePath ->

    printfn "Opening: %s" chmFilePath



    let chmDirectoryPath = (Directory.GetParent chmFilePath).FullName
    let chmFileStem = Path.GetFileNameWithoutExtension chmFilePath
    let outputDirectoryPath = Path.Combine(chmDirectoryPath, chmFileStem)



    if not (Directory.Exists outputDirectoryPath) then
        Directory.CreateDirectory(outputDirectoryPath)
        |> ignore



    // Example usage:
    executeProcess "hh" $"-decompile {outputDirectoryPath} {chmFilePath}"
    |> ignore


)
// TODO rename files based on contents (.hhc), index (.hhk), topic (.html)
// https://learn.microsoft.com/en-us/previous-versions/windows/desktop/htmlhelp/about-the-html-help-compiler
