#r "nuget: LightningDB"

open LightningDB
open System
open System.IO

let lmdb_directory_path = @"D:\Persistence\LMDB\LCG"

let GiB = 1024L * 1024L * 1024L
let bytes_to_gib (bytes: int64) = float bytes / 1024.0 / 1024.0 / 1024.0
let map_size = int64 4 * GiB
let mutable batch_size = 250_000

Directory.CreateDirectory(lmdb_directory_path)
|> ignore


let environment = new LightningEnvironment(lmdb_directory_path)


environment.MapSize <- map_size
environment.MaxDatabases <- 30


environment.Open()

let print_stats () =


    let info = environment.Info
    let stat = environment.EnvironmentStats

    let page_size = int64 stat.PageSize

    let used_bytes = (int64 info.LastPageNumber + 1L) * page_size

    let map_size = info.MapSize

    let remaining_bytes = map_size - used_bytes

    let used_percent = (float used_bytes / float map_size) * 100.0

    printfn ""
    printfn "LMDB Environment"
    printfn "----------------"
    printfn "Page Size:        %i bytes" page_size
    printfn "Last Page Number: %i" info.LastPageNumber
    printfn "Map Size:         %.2f GiB" (bytes_to_gib map_size)
    printfn "Used:             %.2f GiB" (bytes_to_gib used_bytes)
    printfn "Remaining:        %.2f GiB" (bytes_to_gib remaining_bytes)
    printfn "Usage:            %.2f%%" used_percent
    printfn ""
