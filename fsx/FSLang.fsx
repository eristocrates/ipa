#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"

open Ipa

open FSharp.Compiler
open Fabulous.AST
open Fantomas.Core
open CaseConverter
module Literal = FSharp.Literals.Literal


let BackTickExclusions = [| '.'; '+'; '$'; '&'; '['; ']'; '/'; '\\'; '*'; '\"'; '`' |]

let IdentKeywords =
    set [
        "abstract"
        "and"
        "as"
        "assert"
        "base"
        "begin"
        "class"
        "const"
        "default"
        "delegate"
        "do"
        "done"
        "downcast"
        "downto"
        "elif"
        "else"
        "end"
        "exception"
        "extern"
        "false"
        "finally"
        "fixed"
        "for"
        "fun"
        "function"
        "global"
        "if"
        "in"
        "inherit"
        "inline"
        "interface"
        "internal"
        "lazy"
        "let"
        "match"
        "member"
        "module"
        "mutable"
        "namespace"
        "new"
        "null"
        "of"
        "open"
        "or"
        "override"
        "private"
        "public"
        "rec"
        "return"
        "sig"
        "static"
        "struct"
        "then"
        "to"
        "true"
        "try"
        "type"
        "upcast"
        "use"
        "val"
        "void"
        "when"
        "while"
        "with"
        "yield"
    ]

let OCamlKeywords = set [ "asr"; "land"; "lor"; "lsl"; "lsr"; "lxor"; "mod"; "sig" ]

let ReservedKeywords =

    set [
        "break"
        "checked"
        "component"
        "const"
        "constraint"
        "continue"
        "event"
        "external"
        "include"
        "mixin"
        "parallel"
        "process"
        "protected"
        "pure"
        "sealed"
        "tailcall"
        "trait"
        "virtual"
        "fori"
        "params"
    ]

let KeywordNames = IdentKeywords + OCamlKeywords + ReservedKeywords

type Binder =
    | TypeBinder of identifier: string
    | CaseBinder of identifier: string
    | ModuleBinder of identifier: string
    | NamespaceBinder of identifier: string
    | VariableBinder of identifier: string

    member this.identifier =
        match this with
        | TypeBinder identifier -> identifier
        | CaseBinder identifier -> identifier
        | ModuleBinder identifier -> identifier
        | NamespaceBinder identifier -> identifier
        | VariableBinder identifier -> identifier



    member this.ContainsCharacter(character: char) = this.identifier.Contains(character)

    member this.isBackTickRestricted =
        match this with
        | TypeBinder identifier -> true
        | CaseBinder identifier -> true
        | ModuleBinder identifier -> true
        | NamespaceBinder identifier -> true
        | VariableBinder identifier -> false

    static member NormalizeCharacters(identifier: string) =
        identifier
            .ReplaceWhitespace("_")
            .Replace("-", "_")
            .Replace(".", ".".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("+", "+".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("$", "$".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("&", "&".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("[", "[".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("]", "]".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("/", "/".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("\\", "\\".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("*", "*".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))
            .Replace("\"", "\"".tryGraphemeCluster.Value.tryHtmlName.Value.prepostfix ("'_", "_'"))

    static member NormalizeFirstCharacter(identifier: string) =
        match identifier with
        | "" -> "_"
        | identifier when Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0] -> identifier
        | identifier -> "_" + identifier

    static member NormalizeKeyword(identifier: string) =
        if KeywordNames.Contains identifier then
            identifier + "_"
        else
            identifier


    member this.binding =
        this.identifier
        |> Binder.NormalizeFirstCharacter
        |> Binder.NormalizeCharacters
        |> Binder.NormalizeKeyword
        |> Syntax.PrettyNaming.NormalizeIdentifierBackticks
