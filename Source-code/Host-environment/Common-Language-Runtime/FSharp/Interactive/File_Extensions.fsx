open System
open System.IO

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics
let target_directory = @"D:\Surface\Company\Infor\"

let extension_paths =
    Directory.GetFiles(target_directory, "*", SearchOption.AllDirectories)
    |> PSeq.filter (fun file_path -> Path.GetExtension(file_path).Length > 0)
    |> PSeq.groupBy (fun file_path -> Path.GetExtension(file_path))
    |> PSeq.sortBy (fun (extension, paths) -> PSeq.length paths)


extension_paths
|> Seq.rev
|> Seq.map (fun (extension, paths) -> $"./Operations_and_Regulations/**/*{extension}, {PSeq.length paths}")
|> String.concat "\n"
|> clip


extension_paths
|> Seq.rev
|> PSeq.map (fun (extension, paths) -> extension)
|> String.concat "\n"
|> clip
