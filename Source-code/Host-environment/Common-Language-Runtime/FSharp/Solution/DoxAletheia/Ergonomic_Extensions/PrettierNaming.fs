module DoxAletheia.PrettierNaming
open System


open FSharp.Compiler
// open FSharp.Compiler.Syntax
// open FSharp.Compiler.Tokenization


module FSharp_Keywords =
    let ocaml_keywords =
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

    let reserved_keywords =
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

               ]

    let keyword_names =

        Tokenization.FSharpKeywords.KeywordNames
        |> Set.ofList
        |> Set.union (ocaml_keywords + reserved_keywords)

module Prettier_Naming =
    let does_identifier_need_backticks (identifier: string) =
        FSharp_Keywords.keyword_names.Contains(identifier)
        || Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier

    let rec normalize_identifier (identifier: string) =
        match identifier with
        | _ when identifier.Contains(' ') ->
            identifier.Replace(" ", "_")
            |> normalize_identifier
        | _ when not (Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0]) ->
            "_" + identifier |> normalize_identifier
        | _ when FSharp_Keywords.keyword_names.Contains(identifier) -> identifier + "_" |> normalize_identifier
        | _ when does_identifier_need_backticks identifier ->
            Syntax.PrettyNaming.NormalizeIdentifierBackticks identifier
        | _ -> identifier




type String with
    member this.needs_backticks = Prettier_Naming.does_identifier_need_backticks this
    member this.normalize_identifier = Prettier_Naming.normalize_identifier this



//
