// F# Interactive script: enumerate Windows Known Folder IDs from the local machine
// Source of truth (runtime): Registry
//   HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions
// Note: This is Windows-specific.

open System
open System.Globalization
open Microsoft.Win32
open System.IO

type KnownFolderRecord =
    { Id: Guid
      KeyName: string
      Name: string option
      Category: string option
      ParsingName: string option
      RelativePath: string option
      ParentFolder: Guid option }

let tryGetString (k: RegistryKey) (valueName: string) =
    try
        match k.GetValue(valueName) with
        | null -> None
        | :? string as s when not (String.IsNullOrWhiteSpace s) -> Some s
        | _ -> None
    with
    | _ -> None

let tryGetGuid (k: RegistryKey) (valueName: string) =
    try
        match k.GetValue(valueName) with
        | null -> None
        | :? string as s ->
            let mutable g = Guid.Empty

            if Guid.TryParse(s, &g) then
                Some g
            else
                None
        | _ -> None
    with
    | _ -> None

let readFolderDescriptions (view: RegistryView) =
    use baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view)

    use root =
        baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FolderDescriptions")

    if isNull root then
        failwith "FolderDescriptions registry key not found. Are you on Windows?"

    root.GetSubKeyNames()
    |> Array.choose (fun subName ->
        let mutable id = Guid.Empty

        if not (Guid.TryParse(subName, &id)) then
            None
        else
            use subKey = root.OpenSubKey(subName)

            if isNull subKey then
                None
            else
                Some
                    { Id = id
                      KeyName = subName
                      Name = tryGetString subKey "Name"
                      Category = tryGetString subKey "Category"
                      ParsingName = tryGetString subKey "ParsingName"
                      RelativePath = tryGetString subKey "RelativePath"
                      ParentFolder = tryGetGuid subKey "ParentFolder" })
    |> Array.sortBy (fun r -> r.Name |> Option.defaultValue r.KeyName)

// Choose RegistryView.Registry64 on 64-bit OS; Registry32 can show additional WOW nodes in some cases.
let folders64 =
    try
        readFolderDescriptions RegistryView.Registry64
    with
    | _ -> [||]

let folders32 =
    try
        readFolderDescriptions RegistryView.Registry32
    with
    | _ -> [||]

// Merge + de-dup by GUID (prefer entries with more metadata)
let merged =
    Array.append folders64 folders32
    |> Array.groupBy (fun r -> r.Id)
    |> Array.map (fun (_id, rs) ->
        rs
        |> Array.sortByDescending (fun r ->
            // crude “metadata richness” score
            [ r.Name
              r.Category
              r.ParsingName
              r.RelativePath ]
            |> List.choose id
            |> List.length)
        |> Array.head)
    |> Array.sortBy (fun r -> r.Name |> Option.defaultValue r.KeyName)

printfn "Known folders found: %d" merged.Length
printfn ""

merged
|> Array.iter (fun r ->
    let name = r.Name |> Option.defaultValue ""
    let cat = r.Category |> Option.defaultValue ""
    let parse = r.ParsingName |> Option.defaultValue ""
    let rel = r.RelativePath |> Option.defaultValue ""

    let parent =
        r.ParentFolder
        |> Option.map string
        |> Option.defaultValue ""

    printfn "%s\t%s\t%s\t%s\t%s\t%s" (string r.Id) name cat parse rel parent)

// Optional: write CSV for later use
let writeCsv (path: string) (rows: KnownFolderRecord []) =
    let esc (s: string) =
        if
            s.Contains("\"")
            || s.Contains(",")
            || s.Contains("\n")
            || s.Contains("\r")
        then
            "\"" + s.Replace("\"", "\"\"") + "\""
        else
            s

    use w = new StreamWriter(path, false, System.Text.Encoding.UTF8)
    w.WriteLine("Id,Name,Category,ParsingName,RelativePath,ParentFolder")

    for r in rows do
        let line =
            [ string r.Id
              r.Name |> Option.defaultValue ""
              r.Category |> Option.defaultValue ""
              r.ParsingName |> Option.defaultValue ""
              r.RelativePath |> Option.defaultValue ""
              r.ParentFolder
              |> Option.map string
              |> Option.defaultValue "" ]
            |> List.map esc
            |> String.concat ","

        w.WriteLine(line)

let outPath = Path.Combine(Environment.CurrentDirectory, "knownfolders.csv")
writeCsv outPath merged
printfn ""
printfn "Wrote: %s" outPath
