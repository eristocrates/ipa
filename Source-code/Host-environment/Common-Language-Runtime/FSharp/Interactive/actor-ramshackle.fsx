#r "nuget: FParsec"

open System
open System.IO

// https://www.mythicsoft.com/agentransack/


[<RequireQualifiedAccess>]
type Criteria'Type =
    | Enumeration of EnumerationOptions
    | Search of SearchOption

type Filter'Type =
    {

      root_directory_path: string
      file_name_expression: string
      contains_text: string
      criteria: Criteria'Type

     }

let search_file_paths (search_filter: Filter'Type) =
    match search_filter.criteria with
    | Criteria'Type.Enumeration enumeration_criteria ->
        Directory.GetFiles(search_filter.root_directory_path, search_filter.file_name_expression, enumeration_criteria)
    | Criteria'Type.Search search_criteria ->
        Directory.GetFiles(search_filter.root_directory_path, search_filter.file_name_expression, search_criteria)

let filter =
    {

      root_directory_path = @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release"
      file_name_expression = "*xsd"
      contains_text = ""
      criteria = Criteria'Type.Search SearchOption.AllDirectories

    }

let search_results = search_file_paths filter

let filteredResults = search_results
//    |> Array.Parallel.map (fun path -> $"""#r @"{path}" """)
// |> Array.Parallel.map (fun path -> Path.GetFileNameWithoutExtension(path))
(*
    |> Array.Parallel.map (fun path ->
        path.Replace(filter.root_directory_path, "")
        + "?WSDL")
    *)

File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "actor-ramshacle_search_results.txt"), search_results)
