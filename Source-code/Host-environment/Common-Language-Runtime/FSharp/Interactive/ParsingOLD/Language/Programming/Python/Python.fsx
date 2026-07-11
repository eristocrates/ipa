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

// TODO comment parser
