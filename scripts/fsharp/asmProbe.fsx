open System
open System.IO
open System.Reflection

let asmPath =
    @"C:\Repositories\Modernization\ConsoleFsharp\bin\Debug\net10.0\ConsoleFsharp.dll"

File.Exists asmPath |> printfn "dll exists: %b"

let asm = Assembly.LoadFrom asmPath

asm.GetTypes()
|> Array.map (fun t -> t.FullName)
|> Array.sort
|> Array.filter (fun n -> n.StartsWith("Namespace", StringComparison.Ordinal))
|> Array.iter (printfn "%s")
