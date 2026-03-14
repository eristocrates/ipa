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

module Ini =

    type Term =
        | White_Space of unit
        | Comment of Comment'Type
        | Key_Name of Key_Name'Type
        | Value of Value'Type
        | Key of Key'Type
        | Section_Name of Section_Name'Type
        | Section of Section'Type

    and Comment'Type = string
    and Key_Name'Type = string
    and Value'Type = string

    and Key'Type =
        { name: Key_Name'Type
          value: Value'Type }

    and Section_Name'Type = string

    and Section'Type =
        { section_name: Section_Name'Type
          name: Key_Name'Type
          value: Value'Type }

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






    let parser: Parser<Term list, User_State'Type> =
        spaces
        >>. manyTill
                (choice [

                          spaces1 |>> White_Space
                          comment.parser |>> Comment
                          section.name.parser |>> Section_Name
                          key.parser
                          |>> (fun (key_name, key_value) -> Key { name = key_name; value = key_value })

                           ])
                eof
