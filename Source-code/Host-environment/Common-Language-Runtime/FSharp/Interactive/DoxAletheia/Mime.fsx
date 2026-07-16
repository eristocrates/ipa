fsi.ShowDeclarationValues <- false

open System
open System.IO


#r "nuget: FSharp.Compiler.Service, 43.10.102"

open FSharp.Compiler.Syntax
open FSharp.Compiler.Tokenization

#r "nuget:  Fabulous.AST"

open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast


#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: FsHttp"
open FsHttp

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\ArrayExtensions.fsx"
open ArrayExtensions

#r "nuget: FSharp.Compiler.Service, 43.10.102"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\PrettierNaming.fsx"

open PrettierNaming
open PrettierNaming.FSharp_Keywords

module media_types =
    [<Literal>]
    let url = "https://www.iana.org/assignments/media-types/media-types.xml"

    let xml = XmlProvider<url>.Load (url)

media_types.xml.Category
media_types.xml.Expert
media_types.xml.Id

media_types.xml.Notes
|> Array.choose (fun Note -> Note.Value)


let PN_LOCAL_ESC =
    [|

       '_'
       '~'
       '.'
       '-'
       '!'
       '$'
       '&'
       '''
       '('
       ')'
       '*'
       '+'
       ','
       ';'
       '='
       '/'
       '?'
       '#'
       '@'
       '%'

       |]

type Mime =
    {

      registry: string
      name: string
      tokens: string array
      type_iri: string
      resource_iri: string

     }
    member this.long_ident =
        this.tokens[.. this.tokens.last_index - 1]
        |> String.concat "."
    member this.data_namespace_name = sprintf "data:%s;charset=UTF-8;" this.name



let mime_types =
    media_types.xml.Registries
    |> Array.Parallel.collect (fun Registry ->


        Registry.Records
        |> Array.Parallel.map (fun Record ->
            let iana_media_type = Record.Name.Value.Value

            { registry = Registry.Id
              name = iana_media_type
              tokens =
                iana_media_type.Split(PN_LOCAL_ESC, StringSplitOptions.RemoveEmptyEntries)
                |> Array.insertAt 0 Registry.Id

              type_iri = $"https://www.iana.org/assignments/media-types/{Registry.Title}/{iana_media_type}"
              resource_iri = $"http://www.w3.org/ns/iana/media-types/{iana_media_type}#Resource" }

        )


    )
    |> Array.Parallel.filter (fun mime_type ->
        not (
            mime_type
                .name
                .ToLowerInvariant()
                .Contains("deprecate")
        ))
    |> Array.Parallel.filter (fun mime_type ->
        not (
            mime_type
                .name
                .ToLowerInvariant()
                .Contains("obsolete")
        ))
    |> Array.Parallel.filter (fun mime_type ->
        not (
            mime_type
                .name
                .ToLowerInvariant()
                .Contains("no replacement")
        ))


let mime_tokens =


    mime_types
    |> Array.Parallel.collect (fun mime_type -> mime_type.tokens)
    |> Array.distinct
    |> Array.sort
    |> Array.Parallel.filter (fun token -> not (String.IsNullOrWhiteSpace(token)))

let max_tokens_length =
    mime_types
    |> Array.map (fun mime_type -> mime_type.tokens.Length)
    |> Array.sort
    |> Array.last

let max_index = max_tokens_length - 1

let nonterminal_tokens_at_index (target_index: int) =
    mime_types
    |> Array.Parallel.choose (fun mime_type ->
        if target_index < mime_type.tokens.last_index then
            Some(mime_type.tokens[target_index])
        else
            None)
    |> Array.distinct
    |> Array.sort



let terminal_tokens_at_index (target_index: int) =
    mime_types
    |> Array.Parallel.choose (fun mime_type ->
        if target_index = mime_type.tokens.last_index then
            Some(mime_type.tokens[target_index])
        else
            None

    )
    |> Array.distinct
    |> Array.sort


let registries =
    mime_types
    |> Array.Parallel.map (fun mime_type -> mime_type.registry)
    |> Array.distinct
    |> Array.sort

// TODO gather tokes per index, emmitting terminals at types and nonterminals as nested modules
// maybe try using recursion

let types_by_token =
    mime_tokens
    |> Array.Parallel.map (fun token ->

        token,
        mime_types
        |> Array.Parallel.choose (fun mime_type ->

            if mime_type.tokens |> Array.contains token then
                Some mime_type
            else
                None

        )

    )
    |> Array.sortBy (fun (token, types) -> types.Length)
    |> Array.rev



types_by_token
|> Array.Parallel.map (fun (token, types) ->

    token,
    types
    |> Array.Parallel.map (fun mime_type -> mime_type.name))


let media_type_record_expr (mime_type: Mime) =
    RecordExpr(
        [ RecordFieldExpr("registry", String(mime_type.registry))
          RecordFieldExpr("name", String(mime_type.name)) ]
    )



let rec nested_module (nonterminal_token: string) depth candidates =
    let module_binding = nonterminal_token.normalize_identifier
    Module(module_binding) {

        let terminal_here =
            candidates
            |> Array.filter (fun mime_type -> mime_type.tokens.Length = depth)

        for mime_type in terminal_here do
            Value("media_type", media_type_record_expr mime_type)

        let child_groups =
            candidates
            |> Array.choose (fun mime_type ->
                if mime_type.tokens.Length > depth then
                    Some(mime_type.tokens[depth], mime_type)
                else
                    None)
            |> Array.groupBy fst
            |> Array.sortBy fst

        for child_token, grouped_items in child_groups do
            let child_candidates = grouped_items |> Array.map snd

            nested_module child_token (depth + 1) child_candidates
    }


// TODO keep parity with actual namespace
let my_namespace = "DoxAletheia"



let all_types =
    Oak() {
        Namespace(my_namespace) {
            Module("Mime_Types") {
                Value(
                    "all",
                    ArrayExpr(
                        [

                          for mime_type in mime_types do
                              media_type_record_expr mime_type

                          ]
                    ),
                    "Mime_Type array"
                )

            }


        }
    }
    |> Gen.mkOak
    |> Gen.run

let by_path =
    Oak() {
        Namespace(my_namespace) {
            nested_module "Mime_Path" 0 mime_types


        }
    }
    |> Gen.mkOak
    |> Gen.run

let by_substring =

    Oak() {
        Namespace(my_namespace) {

            Module("Mime_Substring") {
                for mime_token, mime_types in types_by_token do
                    let module_binding = mime_token.normalize_identifier
                    Module(module_binding) {
                        for mime_type in mime_types do
                            let type_binding = mime_type.tokens |> String.concat "_"
                            Value(
                                type_binding,
                                RecordExpr(
                                    [

                                      RecordFieldExpr("registry", String(mime_type.registry))
                                      RecordFieldExpr("name", String(mime_type.name))

                                      ]
                                )
                            )



                    }

            }

        }
    }
    |> Gen.mkOak
    |> Gen.run


let mime_types_fs =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\MimeTypes.fs"

let mime_path_fs =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\MimePath.fs"

let mime_substring_fs =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\MimeSubstring.fs"

File.WriteAllText(mime_path_fs, by_path)
File.WriteAllText(mime_substring_fs, by_substring)
File.WriteAllText(mime_types_fs, all_types)
