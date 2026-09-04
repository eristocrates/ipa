#load @".paket/load/main.group.fsx"

open System
open FSharp.Compiler
open TextCopy

module FSharpLiteral = FSharp.Literals.Literal

let clipboard = new Clipboard()
let clip (text: string) = clipboard.SetText text

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

    static member BackTickExclusions =
        [| '.'
           '+'
           '$'
           '&'
           '['
           ']'
           '/'
           '\\'
           '*'
           '\"'
           '`' |]

    static member IdentKeywords =
        set [ "abstract"
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

    static member OCamlKeywords =
        set [

              "asr"
              "land"
              "lor"
              "lsl"
              "lsr"
              "lxor"
              "mod"
              "sig"

               ]

    static member ReservedKeywords =

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

    static member KeywordNames =
        Binder.IdentKeywords
        + Binder.OCamlKeywords
        + Binder.ReservedKeywords

    member this.Contains(character: char) = this.identifier.Contains(character)

    member this.isBackTickRestricted =
        match this with
        | TypeBinder identifier -> true
        | CaseBinder identifier -> true
        | ModuleBinder identifier -> true
        | NamespaceBinder identifier -> true
        | VariableBinder identifier -> false

    static member NormalizeCharacters(identifier: string) =
        let sb = System.Text.StringBuilder()

        for character in identifier do
            match character with
            | '#'
            | ':'
            | ','
            | '?'
            | '('
            | ')' -> ()

            | '&' -> sb.Append("and") |> ignore

            | '/'
            | '-'
            | ' ' -> sb.Append('_') |> ignore

            | c when Char.IsWhiteSpace c -> sb.Append('_') |> ignore

            | c -> sb.Append(c) |> ignore

        sb.ToString()

    static member NormalizeFirstCharacter(identifier: string) =
        match identifier with
        | "" -> "_"

        | identifier when Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0] -> identifier

        | identifier -> "_" + identifier

    static member NormalizeKeyword(identifier: string) =
        if Binder.KeywordNames.Contains identifier then
            identifier + "_"
        else
            identifier

    member this.binding =
        this.identifier
        |> Binder.NormalizeFirstCharacter
        |> Binder.NormalizeCharacters
        |> Binder.NormalizeKeyword
        |> Syntax.PrettyNaming.NormalizeIdentifierBackticks


type String with

    member this.NormalizeFirstCharacter =
        match this with
        | "" -> "_"

        | identifier when Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0] -> identifier

        | identifier -> "_" + identifier

    member this.NormalizeKeyword: string =
        if Binder.KeywordNames.Contains this then
            this + "_"
        else
            this
