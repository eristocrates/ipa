#r "nuget: DocX"

open System
open System.IO
open Xceed.Words.NET



let docxRootDirectoryPath =
    @"D:\Surface\Government\United_States\State\Florida\County\Leon\Geographic_Information_Systems"




module Stormwater_Editing_Training_Manual_CN = 
    let docx = DocX.Load @"D:\Surface\Government\United_States\State\Florida\County\Leon\Geographic_Information_Systems\LCSW_Inventory\Documents\Stormwater Editing Training Manual_CN.docx"


let docxFilePaths =
    Directory.EnumerateFiles(docxRootDirectoryPath, "*.docx", SearchOption.AllDirectories)

docxFilePaths
|> Seq.iter (fun docxFilePath ->

    printfn "Opening: %s" docxFilePath


    let docxDirectoryPath = (Directory.GetParent docxFilePath).FullName
    let docxFileStem = Path.GetFileNameWithoutExtension docxFilePath
    let tsvFilePath = Path.Combine(docxDirectoryPath, $"{docxFileStem}.txt")



)
