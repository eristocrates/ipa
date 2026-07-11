open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Internationalized\Internationalized_Resource_Identifier.fsx"

open XParsecErgonomics
open Internationalized_Resource_Identifier

module com =
    module toscrape =
        module books =
            let iri = result'from_parse Absolute_IRI.parse OnInput "https://books.toscrape.com/"

module org =
    module example =
        module www =
            let iri = result'from_parse Absolute_IRI.parse OnInput "https://www.example.org/"
