open System
open System.IO

#r "nuget: FSharp.Compiler.Service, 43.10.102"

open FSharp.Compiler.Syntax
open FSharp.Compiler.Tokenization

#r "nuget: NeatIntervals"
#r "nuget: XParsec"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics
open StringExtensions
open Unicode_Standard
open XParsec
open XParsec.CharParsers
open XParsec.Combinators
open XParsec.Parsers


open System
open System.Text
open System.Security
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Text
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Interactive.Shell



#r "nuget:  Fabulous.AST"
open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"
open XmlErgonomics

let registry_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\LanguageSubtag.txt"
// TODO remember to manually regex comments to a single line

(*

Comments.*\r\n\s

*)

let ocaml_ident_ccccccds =
    set [

          "asr"
          "land"
          "lor"
          "lsl"
          "lsr"
          "lxor"
          "mod"

           ]

let rec fsharp_identifier (logical_string: string) =
    match PrettyNaming.DoesIdentifierNeedBackticks logical_string with
    | _ when ocaml_ident_keywords.Contains(logical_string) -> fsharp_identifier $"{logical_string}_"
    | _ when logical_string.Contains(" ") ->
        logical_string.Replace(" ", "_")
        |> fsharp_identifier
    | _ when logical_string.Contains(".") ->
        logical_string.Replace(".", "_")
        |> fsharp_identifier
    | _ when logical_string.Contains("(") ->
        logical_string.Replace("(", "_")
        |> fsharp_identifier
    | _ when logical_string.Contains(")") ->
        logical_string.Replace(")", "_")
        |> fsharp_identifier
    | true -> PrettyNaming.NormalizeIdentifierBackticks logical_string
    | _ -> logical_string

let registry_content = File.ReadAllText(registry_path)


fsi.ShowDeclarationValues <- true
// TODO next transition xparsec to type provider

let horizontal_spaces = skipMany (choice [ pstring " "; pstring "\t" ])

let key_char = satisfy (fun c -> Char.IsLetterOrDigit c || c = '-')

let key_parser = many1Chars key_char

let key_value_parser =
    parser {
        let! key = key_parser
        do! skipChar ':'
        do! horizontal_spaces

        let! value, _ = manyCharsTill anyChar newline

        return key, value
    }

let delimiter_parser =
    parser {
        let! _ = pstring "%%"
        do! skipNewline
    }

let record_parser = parser { return! many1 key_value_parser }

let registry_parser =
    parser {
        let! records, _ = sepBy record_parser delimiter_parser
        return records
    }

// parse string_parser "hello" from_input_string "hello world" expecting "hello world" return_string

let parsed_registry =
    Reader.ofString registry_content ()
    |> registry_parser







// (string * string) * ImmutableArray<ImmutableArray<string * string>>
let registry =
    match parsed_registry with
    | Ok parsed -> parsed

let records =
    registry
    |> Seq.map (fun tags -> tags |> Seq.map (fun tag -> tag))

(*
let distinct_keys =
    records
    |> Seq.collect (fun language ->

        language |> Seq.map (fun (key, value) -> key)

    )
    |> Seq.distinct
    |> Seq.sort
    |> Seq.toArray

let test_keys =
    records
    |> Seq.choose (fun language ->

        let percent_exists =
            language
            |> Seq.exists (fun (key, value) -> String.IsNullOrWhiteSpace(key))
        if percent_exists then
            Some(language |> Seq.toArray)
        else
            None


    )
    |> Seq.toArray



let distinct_values target_key =
    records
    |> Seq.map (fun key_values ->

        key_values
        |> Seq.tryPick (fun (key, value) ->

            if key = target_key then
                Some value
            else
                None)

    )
    |> Seq.distinct
    |> Seq.sort

let distinct_added_values = distinct_values "Added"
let distinct_comments_values = distinct_values "Comments"
let distinct_deprecated_values = distinct_values "Deprecated"
let distinct_description_values = distinct_values "Description"
let distinct_macrolanguage_values = distinct_values "Macrolanguage"
let distinct_preferred_values_value = distinct_values "Preferred-Value"
let distinct_scope_values = distinct_values "Scope"
let distinct_subtag_values = distinct_values "Subtag"
let distinct_suppress_script_values = distinct_values "Suppress-Script"

let distinct_type_values =
    distinct_values "Type"
    |> Seq.choose (fun type_ -> type_)
    |> Seq.toArray

let language_records =
    records
    |> Seq.choose (fun record ->
        let record_type =
            record
            |> Seq.pick (fun (key, value) ->
                if key = "Type" then
                    Some value
                else
                    None)
        if record_type = "language" then
            Some record
        else
            None)

*)




[<RequireQualifiedAccess>]
type Registry_Type =
    | region
    | language

module RegistryXmlDocs = 
    open Xml_Documentation_Comments
    let xmldoc_by_record record =
        summary {
            for key, value in record do
                match key with 
                | "Comment" -> remarks { $"{SecurityElement.Escape key}: {SecurityElement.Escape value}" }
                | _ -> para { $"{SecurityElement.Escape key}: {SecurityElement.Escape value}" }

        
        }
        |> Render.toXElement
        |> fun xelement -> xelement.ToString()
        |> fun xelement_string -> xelement_string.Split("\n")

        
let codegen_by_registry_type (target_type: Registry_Type) =
    let type_binding =
        match target_type with
        | Registry_Type.language -> "Language_Tag"
        | Registry_Type.region -> "Region_Subtag"
    (Union(type_binding) {

    let target_records = 
        records
        |> Seq.choose (fun record ->
            let record_type =
                record
                |> Seq.pick (fun (key, value) ->
                    if key = "Type" then
                        Some value
                    else
                        None)
            if record_type = target_type.ToString() then
                Some record
            else
                None)
    for record in target_records do

        let subtag =
            record
            |> Seq.pick (fun (key, value) ->

                if key = "Subtag" then
                    Some value
                else
                    None

            )
        let description =
            record
            |> Seq.pick (fun (key, value) ->

                if key = "Description" then
                    Some value
                else
                    None

            )
        UnionCase(fsharp_identifier subtag)
        |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_record record)        


    }
    ).members() {
            Member(
                "this.rdf_string","this.ToString"
            )
    }
    |> _.attribute(Attribute("RequireQualifiedAccess ; StructuralComparison; StructuralEquality"))
    |> _.xmlDocs( XmlDocs "https://www.iana.org/assignments/language-subtag-registry/language-subtag-registry"        )

/// TODO keep namespace in parity
let namespace_binding = "MyNamespace"

module LanguageSubtag = 
    module fs = 
        let text = 
                    Oak() {
                        Namespace(namespace_binding) {
                            codegen_by_registry_type Registry_Type.language
                            codegen_by_registry_type Registry_Type.region

                        }
                    }
                    |> Gen.mkOak
                    |> Gen.run
        let file_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\MyProvider\src\MyProvider.Runtime\LanguageSubtag.fs"

File.WriteAllText(LanguageSubtag.fs.file_path, LanguageSubtag.fs.text)
