#if INTERACTIVE
#r "nuget: Microsoft.Extensions.FileSystemGlobbing"
#r "nuget: DotNetConfig"
#endif

open System
open System.IO
open DotNetConfig

// https://www.mythicsoft.com/agentransack/

[<RequireQualifiedAccess>]
type Criteria =
    | Enumeration of EnumerationOptions
    | Search of SearchOption

let search_file_paths
    (root_directory_path: string)
    (file_name_expression: string)
    (contains_text: string)
    (criteria: Criteria)
    =
    match criteria with
    | Criteria.Enumeration enumerationOptions ->
        Directory.GetFiles(root_directory_path, file_name_expression, enumerationOptions)
    | Criteria.Search searchOptions -> Directory.GetFiles(root_directory_path, file_name_expression, searchOptions)

let config_file_paths =
    search_file_paths @"C:\Repositories" "config" "" (Criteria.Search SearchOption.AllDirectories)

let config = Config.Build(config_file_paths[0])
let remote'origin = config.GetSection("remote", "origin")
