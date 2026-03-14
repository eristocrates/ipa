#r "nuget: Microsoft.Extensions.FileSystemGlobbing"
#r "nuget: FParsec"
#r "nuget: DotNetConfig"
#load @"C:\Repositories\eristocrates\ipa\MSBuild\Project\Parser_Combinator\Initialization\Initialization.fsx"

open System
open System.IO
open Computer_Storage
open Initialization

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

let config_files =
    config_file_paths
    |> Array.Parallel.map (fun config_file_path -> { absolute_path = config_file_path })

let config_file = config_files[0]
let config_file_stream = Parser_Combinator.Input_Stream.file config_file

let result = Parser_Combinator.apply_parser Ini.parser config_file_stream ()
let term = result.output.Value[2]

let parser_outcomes =
    config_files
    |> Array.Parallel.map (fun config_file ->
        let config_file_stream = Parser_Combinator.Input_Stream.file config_file
        let outcome = Parser_Combinator.apply_parser Ini.parser config_file_stream ()
        outcome

    )

let terms =
    parser_outcomes
    |> Array.Parallel.filter (fun parser_outcome -> parser_outcome.output.IsSome)
    |> Array.Parallel.collect (fun parser_outcome -> parser_outcome.output.Value |> Array.ofList)

let keys =
    terms
    |> Array.Parallel.filter (fun term -> term.IsKey)
    |> Array.Parallel.map (fun term ->
        match term with
        | Ini.Term.Key key -> key
        | _ -> failwith "Nonkey term encountered after filter"


    )

let urls =
    keys
    |> Array.Parallel.filter (fun key -> key.name = "url")
    |> Array.Parallel.map (fun key -> key.value)
