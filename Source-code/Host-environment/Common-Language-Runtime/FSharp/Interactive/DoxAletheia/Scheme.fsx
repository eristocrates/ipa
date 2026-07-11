fsi.ShowDeclarationValues <- false

open System
open System.Text
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

#r "nuget: Siren"
open Siren

#r "nuget: Blake3"
open Blake3

#r "nuget: Fake.Tools.Rsync"

open Fake.Core
open Fake.Tools

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\ArrayExtensions.fsx"
open ArrayExtensions

#r "nuget: FSharp.Compiler.Service, 43.10.102"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\PrettierNaming.fsx"

open PrettierNaming
open PrettierNaming.FSharp_Keywords

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DiagnosticsErgonomics.fsx"
open DiagnosticsErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\MermaidErgonomics.fsx"
open MermaidErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"
open XmlErgonomics



module uri_schemes =
    [<Literal>]
    let url = "https://www.iana.org/assignments/uri-schemes/uri-schemes.xml"

    let xml = XmlProvider<url>.Load (url)


let start_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\Scheme.fsx"


// Path.Combine(__SOURCE_DIRECTORY__, __SOURCE_FILE__)
let source_dependency =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\XParsecExtensions.fsx"
    |> load_dependencies

let rec dependency_mmd (current_file: Load_Dependency) =
    current_file.depends_on
    |> Array.collect (fun dependency ->
        dependency_mmd dependency
        |> Array.append (flowchart_labeled_link_arrow current_file.file_name "depends on" dependency.file_name)

    // (sprintf "%s -> %s : depends on" current_file.file_name dependency.file_name)

    )



let scratch_file_text =
    siren
        .flowchart(direction.td, dependency_mmd source_dependency)
        .write ()

let scratch_file_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Scratch\scratch.mmd"

File.WriteAllText(scratch_file_path, scratch_file_text)




let scheme_iris =
    uri_schemes.xml.Registries[0].Records
    |> Array.Parallel.choose (fun Record ->

        match Record.File with
        | Some file ->
            match file.Value with
            | Some value ->
                Some(
                    Record.Value.Value.String.Value,
                    "https://www.iana.org/assignments/uri-schemes/"
                    + value
                )
            | _ -> None
        | _ -> None



    )

scheme_iris.Length
scheme_iris |> Array.randomSample 3

uri_schemes.xml.Registries[0].Records
|> Array.Parallel.filter (fun Record -> Record.Cri.IsNone)

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

type Iana_Scheme =
    {

      name: string
      tokens: string array
      description: string
      cri: int
      status: string

     }



let iana_schemes =
    uri_schemes.xml.Registries[0].Records
    |> Array.map (fun Record ->
        let name =
            match Record.Value.Value.String.Value with
            | "shttp (OBSOLETE)" -> "shttp"
            | name -> name

        {

          name = name
          tokens = 
            match name with 
            | "ibi-" -> [|"ibi_"|]
            | _ -> name.Split(PN_LOCAL_ESC, StringSplitOptions.RemoveEmptyEntries)

          description = Record.Description.Value.Value.Value
          cri = Record.Cri.Value
          status = Record.Status.Value

        }


    )

iana_schemes |> Array.randomSample 3

let statuses =
    iana_schemes
    |> Array.map (fun iana_scheme -> iana_scheme.status)
    |> Array.distinct
    |> Array.sort


let scheme_tokens =
    iana_schemes
    |> Array.Parallel.collect (fun iana_scheme -> iana_scheme.tokens)
    |> Array.distinct
    |> Array.sort
    |> Array.Parallel.filter (fun token -> not (String.IsNullOrWhiteSpace(token)))


let max_tokens_length =
    iana_schemes
    |> Array.map (fun iana_scheme -> iana_scheme.tokens.Length)
    |> Array.sort
    |> Array.last

let max_index = max_tokens_length - 1


let nonterminal_tokens_at_index (target_index: int) =
    iana_schemes
    |> Array.Parallel.choose (fun iana_scheme ->
        if target_index < iana_scheme.tokens.last_index then
            Some(iana_scheme.tokens[target_index])
        else
            None)
    |> Array.distinct
    |> Array.sort



let terminal_tokens_at_index (target_index: int) =
    iana_schemes
    |> Array.Parallel.choose (fun iana_scheme ->
        if target_index = iana_scheme.tokens.last_index then
            Some(iana_scheme.tokens[target_index])
        else
            None

    )
    |> Array.distinct
    |> Array.sort


let schemes_by_token =
    scheme_tokens
    |> Array.Parallel.map (fun token ->

        token,
        iana_schemes
        |> Array.Parallel.choose (fun iana_scheme ->

            if iana_scheme.tokens |> Array.contains token then
                Some iana_scheme
            else
                None

        )

    )
    |> Array.sortBy (fun (token, types) -> types.Length)
    |> Array.rev





module RegistryXmlDocs = 
    open Xml_Documentation_Comments
    let xmldoc_by_scheme (iana_scheme:Iana_Scheme) =
        summary {
            iana_scheme.description
        
        }
        |> Render.toXElement
        |> fun xelement -> xelement.ToString()
        |> fun xelement_string -> xelement_string.Split("\n")



let scheme_record_expr (iana_scheme: Iana_Scheme) =
    RecordExpr(
        [

          RecordFieldExpr("name", String(iana_scheme.name))
          RecordFieldExpr("description", String(iana_scheme.description))
          RecordFieldExpr("cri", Int(iana_scheme.cri))
          RecordFieldExpr("status", $"{iana_scheme.status}Status")

          ]
    ) 




let rec nested_module (nonterminal_token: string) depth candidates =
    let module_binding = 
        match nonterminal_token with 
        | "ibi-" -> "ibi_"
        | _ -> nonterminal_token.normalize_identifier
    Module(module_binding) {

        let terminal_here =
            candidates
            |> Array.filter (fun iana_scheme -> iana_scheme.tokens.Length = depth)

        for iana_scheme in terminal_here do
            if iana_scheme.name <> iana_scheme.description then
                Value("uri_scheme", scheme_record_expr iana_scheme)
                |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_scheme iana_scheme)        
            else
                Value("uri_scheme", scheme_record_expr iana_scheme)

        let child_groups =
            candidates
            |> Array.choose (fun iana_scheme ->
                if iana_scheme.tokens.Length > depth then
                    Some(iana_scheme.tokens[depth], iana_scheme)
                else
                    None)
            |> Array.groupBy fst
            |> Array.sortBy fst

        for child_token, grouped_items in child_groups do
            let child_candidates = grouped_items |> Array.map snd

            nested_module child_token (depth + 1) child_candidates
    }
















// TODO keep parity with actual namespace
let my_namespace = "MyNamespace"

            (*
            
            Union("Iana_Status") {
                for status in statuses do
                    UnionCase($"{status}Status")
            }
            Record("Uri_Scheme") {
                Field("name", String())
                Field("description", String())
                Field("cri", Int())
                Field("status", "Iana_Status")

            }
            *)
let all_schemes =

    Oak() {
        Namespace(my_namespace) {
            nested_module "Uri_Scheme" 0 iana_schemes

            Module("Uri_Schemes") {
                Value(
                    "all",
                    ArrayExpr(
                        [

                          for iana_scheme in iana_schemes do
                              scheme_record_expr iana_scheme

                          ]
                    ),
                    "Iana_Scheme array"
                )
                Value(
                    "all_names",
                    ArrayExpr(
                        [

                          for iana_scheme in iana_schemes do
                              String(iana_scheme.name)

                          ]
                    ),
                    "string array"
                )

            }

        }
    }
    |> Gen.mkOak
    |> Gen.run

let iana_schemes_fs =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\Iana_Schemes.fs"

File.WriteAllText(iana_schemes_fs, all_schemes)
