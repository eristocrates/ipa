open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: Unquote"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Resource_Identifier.fsx"

open Resource_Identifier
open StringExtensions


parse
    complete_parser
    IP.v6.address.parser_combinator
    from_input_string
    "1:2:3:4:5:6:7:8"
    expecting
    ""
    returning_the_value

parse complete_parser IP.v6.address.parser_combinator from_input_string "::1" expecting "" returning_the_value
parse complete_parser IP.v6.address.parser_combinator from_input_string "1::" expecting "" returning_the_value
parse complete_parser IP.v6.address.parser_combinator from_input_string "::" expecting "" returning_the_value
parse complete_parser IP.v6.address.parser_combinator from_input_string "2001:db8::7" expecting "" returning_the_value

parse
    complete_parser
    IP.v6.address.parser_combinator
    from_input_string
    "::ffff:192.0.2.128"
    expecting
    ""
    returning_the_value
