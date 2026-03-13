#if INTERACTIVE
#r "nuget: FParsec"
#r "nuget: FSharp.Data"
#r @"C:\Repositories\eristocrates\ipa\MSBuild\Project\Parser_Combinator\bin\Debug\net10.0\Parser_Combinator.dll"
#r @"C:\Repositories\eristocrates\ipa\MSBuild\Project\Computer_Storage\bin\Debug\net10.0\Computer_Storage.dll"


#endif

open System
open System.Xml.Linq

open FParsec
open FSharp.Data

open Parser_Combinator
open Computer_Storage


type User_State'Type = unit

module comment =
    let parser: Parser<string, User_State'Type> =
        pstring ";" >>. spaces >>. restOfLine true

module value =
    type Value'Type = Value of string

module key =
    module name =
        let parser: Parser<string, unit> =
            many1Satisfy (fun character ->
                not (System.Char.IsWhiteSpace character)
                && character <> '=')

    let parser: Parser<string * string, unit> =
        name.parser .>> spaces .>> pstring "=" .>> spaces
        .>>. manySatisfy (fun character -> not (character = '\r') && not (character = '\n'))

module section =
    module name =
        let parser: Parser<string, User_State'Type> =
            pstring "["
            >>. manySatisfy (fun character -> not (character = ']'))
            .>> pstring "]"
            .>> newline





module ini =
    type Ini'Token =
        | White_Space of unit
        | Comment of comment: string
        | Key_Name of string
        | Value of string
        | Key of key_name: string * value: string
        | Section_Name of string
        | Section of section_name: string * key_name: string * equal_sign: string * value: string

    let parser: Parser<Ini'Token list, User_State'Type> =
        spaces
        >>. manyTill
                (choice [

                          spaces1 |>> White_Space
                          comment.parser |>> Comment
                          section.name.parser |>> Section_Name
                          key.parser |>> Key

                           ])
                eof

    let ini =
        {

          absolute_path = @"C:\Repositories\eristocrates\ipa\MSBuild\Project\Parser_Combinator\Initialization\ini.ini"

        }

let test_file = Input_Stream.file ini.ini


let test_result = apply_parser ini.parser test_file ()

let keys =
    test_result.output.Value
    |> List.filter (fun token -> token.IsKey)

let urlToken =
    keys
    |> List.filter (fun token ->
        match token with
        | ini.Ini'Token.Key (name, value) -> name = "url")

    |> List.head

let url =
    match urlToken with
    | ini.Ini'Token.Key (name, value) -> value

// let test_string = Input_Stream.string "name = John Doe"
// apply_parser key.parser test_string ()
