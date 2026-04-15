open System
open System.Web
open System.Text
open System.IO
open System.Globalization




#r "nuget: XParsec"

open XParsec
open XParsec.Parsers

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Metalanguage\ABNF\ABNF.fsx"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"

open XParsecErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Language\Codepoints\Punctuation.fsx"

open Punctuation
open System.Collections.Immutable

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\XML\XML.fsx"
open XML
