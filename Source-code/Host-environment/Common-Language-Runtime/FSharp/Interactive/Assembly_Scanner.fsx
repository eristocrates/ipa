open System
open System.IO
open System.Reflection

let inspectAssembly path =
    try
        let name = AssemblyName.GetAssemblyName(path)

        let publicKeyToken =
            name.GetPublicKeyToken()
            |> Array.map (fun b -> b.ToString("x2"))
            |> String.concat ""

        Some(path, name.FullName, publicKeyToken)
    with
    | _ -> None

let rec enumerateFilesSafe root pattern =
    seq {
        let files =
            try
                Directory.EnumerateFiles(root, pattern)
            with
            | _ -> Seq.empty

        yield! files

        let directories =
            try
                Directory.EnumerateDirectories(root)
            with
            | _ -> Seq.empty

        for directory in directories do
            yield! enumerateFilesSafe directory pattern
    }

let roots =
    [ @"C:\Program Files (x86)"
      @"C:\Program Files"
      @"C:\Windows\Microsoft.NET\assembly"
      @"C:\Windows\assembly" ]

roots
|> Seq.filter Directory.Exists
|> Seq.collect (fun root -> enumerateFilesSafe root "System.Security.Permissions*dll")
|> Seq.choose inspectAssembly
//|> Seq.filter (fun (_, fullName, token) -> fullName.StartsWith("System.Security.Permissions, Version=0.0.0.0, PublicKeyToken=cc7b13ffcd2ddd51"))
// || token = "692fbea5521e1304")
|> Seq.iter (fun (path, fullName, token) ->
    printfn ""
    printfn "Path: %s" path
    printfn "FullName: %s" fullName
    printfn "PublicKeyToken: %s" token)
