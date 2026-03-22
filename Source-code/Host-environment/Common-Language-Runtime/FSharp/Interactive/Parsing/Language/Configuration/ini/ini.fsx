open System
open System.IO
#r "nuget: FParsec"
#r "nuget:  Fabulous.AST"


open FParsec
open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive"
#load @"Parsing\Parser_Combinator.fsx"
#load "Active_Patterns.fsx"

open Parser_Combinator
open Local_File_System
open Active_Patterns


type Comment'Type = string
type Key_Name'Type = string
type Value'Type = string

type Key'Type =
    { name: Key_Name'Type
      value: Value'Type }

type Section_Name'Type = string

type Section'Type =
    { section_name: Section_Name'Type
      keys: Key'Type list
      comments: Comment'Type list }

type Ini_Ast'Type =
    { sections: Section'Type list
      comments_before_first_section: Comment'Type list }

type Section_Content'Type =
    | Comment of Comment'Type
    | Key of Key'Type

[<RequireQualifiedAccess>]
type Term =
    | White_Space of unit
    | Comment of Comment'Type
    | Key_Name of Key_Name'Type
    | Value of Value'Type
    | Key of Key'Type
    | Section_Name of Section_Name'Type
    | Section of Section'Type



type User_State'Type = unit

module comment =
    let parser: Parser<Comment'Type, User_State'Type> =
        pstring ";" >>. spaces >>. restOfLine true

module value =
    type Value'Type = Value of string

module key =
    module name =
        let parser: Parser<Key_Name'Type, User_State'Type> =
            many1Satisfy (fun character ->
                not (System.Char.IsWhiteSpace character)
                && character <> '=')

    module value =
        let parser: Parser<Value'Type, User_State'Type> =
            manySatisfy (fun character -> character <> '\r' && character <> '\n')

    let parser: Parser<Key'Type, User_State'Type> =
        name.parser .>> spaces .>> pstring "=" .>> spaces
        .>>. value.parser
        |>> (fun (key_name, key_value) -> { name = key_name; value = key_value })

module section =
    module name =
        let parser: Parser<Section_Name'Type, User_State'Type> =
            pstring "["
            >>. manySatisfy (fun character -> character <> ']')
            .>> pstring "]"

    module content =
        let parser: Parser<Section_Content'Type option, User_State'Type> =
            spaces
            >>. choice [ comment.parser
                         |>> (Section_Content'Type.Comment >> Some)
                         key.parser |>> (Section_Content'Type.Key >> Some)
                         preturn None ]
            .>> spaces
            .>> optional newline

    let parser: Parser<Section'Type, User_State'Type> =
        name.parser .>> spaces .>> optional newline
        .>>. manyTill content.parser ((followedBy (pchar '[')) <|> eof)
        |>> (fun (section_name, section_content_items) ->
            let meaningful_items = section_content_items |> List.choose id

            let comments =
                meaningful_items
                |> List.choose (function
                    | Section_Content'Type.Comment comment -> Some comment
                    | Section_Content'Type.Key _ -> None)

            let keys =
                meaningful_items
                |> List.choose (function
                    | Section_Content'Type.Comment _ -> None
                    | Section_Content'Type.Key key -> Some key)

            { section_name = section_name
              keys = keys
              comments = comments })

module line =
    let whitespace: Parser<unit, User_State'Type> = spaces >>% ()

    let empty: Parser<unit, User_State'Type> = spaces >>% ()

    let comment: Parser<Section_Content'Type, User_State'Type> =
        comment.parser |>> Section_Content'Type.Comment

    let key: Parser<Section_Content'Type, User_State'Type> =
        key.parser |>> Section_Content'Type.Key


module ini_file =
    let comment_before_first_section_parser: Parser<Comment'Type option, User_State'Type> =
        spaces
        >>. choice [ comment.parser |>> Some
                     preturn None ]
        .>> spaces
        .>> optional newline

    let parser: Parser<Ini_Ast'Type, User_State'Type> =
        manyTill comment_before_first_section_parser ((followedBy (pchar '[')) <|> eof)
        .>>. many section.parser
        .>> eof
        |>> (fun (comments_before_first_section, sections) ->
            { comments_before_first_section = comments_before_first_section |> List.choose id
              sections = sections })



type Ini_File'Type =
    { logical_file: Logical_File
      ast: Ini_Ast'Type }
    static member inhabitant(absolute_path: string) =
        let logical_file = Logical_File.inhabitant absolute_path
        let parser_result = apply_parser ini_file.parser (Input_Stream.file logical_file) ()

        { logical_file = logical_file
          ast = parser_result.output.Value }






module ini =
    let ini =
        Ini_File'Type.inhabitant
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Configuration\ini\ini.ini"

    let fsx =
        Oak() {
            AnonymousModule() {
                Module(ini.logical_file.file_extension) {
                  for section in ini.ast.sections do
                    Module(section.section_name){

                    for key in section.keys do
                      let  value = 
                          match key.value with
                          | Integer_String integer_string-> integer_string
                          | quoted_value when quoted_value.Contains('"') -> quoted_value
                          | _ -> "\"" + key.value.TrimEnd() + "\""
                        

                      Value(key.name, value)
                    } |> _.triviaBefore(section.comments
                    |> Seq.map (fun comment -> SingleLine(comment) )
                    )
                }
                |> _.triviaBefore(
                    ini.ast.comments_before_first_section
                    |> Seq.map (fun comment -> SingleLine(comment)) 
                )
            }
        }
        |> Gen.mkOak
        |> Gen.run


File.WriteAllText( ini.ini.logical_file.branch_extension("generated.fsx"),ini.fsx)

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Configuration\ini\ini.generated.fsx"
Ini.generated.ini.database.port