open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open Resource_Identifier
open Internationalized_Resource_Identifier

#r "nuget: Unquote"

open Unicode_Standard

open SetErgonomics

open Swensen.Unquote.Assertions

#r "nuget: FsCheck"

open FsCheck
open XParsecErgonomics
open XParsec


#r "nuget: FSharp.UMX"

open FSharp.UMX




























let inline as_string_of (parsed: ^Parsed) : ^MeasuredString =

    (^Parsed: (member as_string: ^MeasuredString) parsed)


let inline parse_succeeds_with_as_string
    (parser: Parser< ^Parsed, int, unit, ReadableArray<int>, ReadableArraySlice<int> >)
    (input: string)
    (expected_string: ^MeasuredString)
    =

    let result = complete_parse parser input

    match result with
    | Result.Ok parsed ->
        let actual_string = as_string_of parsed

        test <@ actual_string = expected_string @>

    | Result.Error error -> test <@ false @>

let parse_succeeds (parser: Parser<'Parsed, int, unit, ReadableArray<int>, ReadableArraySlice<int>>) (input: string) =

    let result = complete_parse parser input

    test
        <@ match result with
           | Result.Ok _ -> true
           | Result.Error _ -> false @>


let parse_fails (parser: Parser<'Parsed, int, unit, ReadableArray<int>, ReadableArraySlice<int>>) (input: string) =

    let result = complete_parse parser input

    test
        <@ match result with
           | Result.Ok _ -> false
           | Result.Error _ -> true @>



// IRI examples: Unicode host/path/query/fragment acceptance.
// Adjust parser/type names here if your IRI module uses different names.
let iri_accepts_unicode_examples () =
    [| "http://résumé.example.org"
       "http://example.com/résumé.html"
       "http://example.com/𐌀𐌁𐌂"
       "http://example.com/path?clé=valeur"
       "http://example.com/path#français" |]
    |> Array.iter (parse_succeeds IRI.parse)

iri_accepts_unicode_examples ()


// IRI should also accept ordinary URI examples, because URI syntax is contained by IRI syntax.
let iri_accepts_uri_examples () =
    [| "http://www.ietf.org/rfc/rfc2396.txt"
       "ldap://[2001:db8::7]/c=GB?objectClass?one"
       "urn:oasis:names:specification:docbook:dtd:xml:4.1.2" |]
    |> Array.iter (parse_succeeds IRI.parse)

iri_accepts_uri_examples ()
