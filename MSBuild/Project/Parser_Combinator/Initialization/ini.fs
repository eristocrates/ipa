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



module comment =
    type Comment = Comment of sigil: string * comment: string

    let parser: Parser<Comment, unit> = pstring ";" .>>. restOfLine true |>> Comment

module ini =
    let ini =
        {

          absolute_path = @"C:\Repositories\eristocrates\ipa\MSBuild\Project\Parser_Combinator\Initialization\ini.ini"

        }

let test_file = Input_Stream.file ini.ini

let test_string =
    """; last modified 1 April 2001 by John Doe
"""

let test_result = apply_parser comment.parser test_file ()
