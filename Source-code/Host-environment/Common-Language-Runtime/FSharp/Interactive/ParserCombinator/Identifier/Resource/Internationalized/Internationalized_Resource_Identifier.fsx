open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable



#r "nuget: Unquote"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Resource_Identifier.fsx"

open StringExtensions
open Resource_Identifier
open XParsecErgonomics
open Unicode_Standard
open XParsec


module Private_Character =
    let parser_combinator =
        iprivate.parser_combinator
        |> expecting """ iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD """

module Unicode_Character =
    let parser_combinator =
        ucschar.parser_combinator
        |> expecting """ iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD """


module Unreserved_Character =
    let parser_combinator =
        iunreserved.parser_combinator
        |> expecting """ unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" / ucschar """

module Fragment =
    let parser_combinator =
        prefix_delimited_Kleene_star number_sign ifragment
        |> expecting """ ifragment      = *( ipchar / "/" / "?" ) """



module Query =
    let parser_combinator =
        prefix_delimited_Kleene_star question_mark iquery
        |> expecting """iquery         =  "?" *( ipchar / iprivate / "/" / "?" ) """

module Path_Character =
    let parser_combinator =
        percent_encodable ipchar_unencoded
        |> expecting """ ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@" """

module Segment =
    module NonZero =
        module NonColon =
            let parser_combinator = Kleene.plus (percent_encodable isegment_nz_nc_unencoded)

        let parser_combinator = Kleene.plus Path_Character.parser_combinator

    let parser_combinator = Kleene.star Path_Character.parser_combinator


module Path =
    module Abempty =
        let parser_combinator =
            Kleene.star
            <| parser {
                let! delimiter = solidus.parser_combinator
                let! segment = Kleene.star Path_Character.parser_combinator
                return Array.concat [| delimiter; segment |]
            }

    module Rootless =
        let parser_combinator = prefixed_Kleene_star isegment_nz Abempty.parser_combinator

    module NoScheme =
        let parser_combinator =
            prefixed_Kleene_star isegment_nz_nc Abempty.parser_combinator

    module Absolute =
        let parser_combinator =
            parser {
                let! prefix = solidus.parser_combinator

                let! segments =
                    opt Rootless.parser_combinator
                    |>> fun value_option -> defaultValueArg value_option Array.empty

                return Array.concat [| prefix; segments |]

            }

    let parser_combinator =
        parser {
            let! path =
                opt (
                    choice [

                             Absolute.parser_combinator
                             NoScheme.parser_combinator
                             Rootless.parser_combinator
                             Abempty.parser_combinator

                              ]
                )

            return defaultValueArg path Array.empty
        }


module Registered_Name =
    let parser_combinator = Kleene.star ireg_name



module Host =
    let parser_combinator =
        choice [

                 IP.Literal.parser_combinator
                 IP.v4.address.parser_combinator
                 Registered_Name.parser_combinator

                  ]

module Userinfo =
    let parser_combinator =
        parser {
            let! user_info = Kleene.star iuserinfo
            let! at = commercial_at.parser_combinator
            return Array.concat [| user_info; at |]
        }


module Authority =
    let parser_combinator =
        parser {

            let! userinfo =
                opt Userinfo.parser_combinator
                |>> fun value_option -> defaultValueArg value_option Array.empty

            let! host = Host.parser_combinator

            let! port =
                opt Port.parser_combinator
                |>> fun value_option -> defaultValueArg value_option Array.empty

            return Array.concat [| userinfo; host; port |]

        }

    module path_abempty =
        let parser_combinator =
            parser {

                let! left_solidus = solidus.parser_combinator
                let! right_solidus = solidus.parser_combinator
                let! authority = parser_combinator
                let! abempty = Path.Abempty.parser_combinator

                return
                    Array.concat [| left_solidus
                                    right_solidus
                                    authority
                                    abempty |]

            }

module Relative =
    module Part =
        let parser_combinator =
            opt (
                choice [

                         Authority.path_abempty.parser_combinator
                         Path.Absolute.parser_combinator
                         Path.NoScheme.parser_combinator

                          ]
            )
            |>> fun value_option -> defaultValueArg value_option Array.empty

    module Reference =
        let parser_combinator =
            parser {
                let! relative_part = Part.parser_combinator

                let! query =
                    opt Query.parser_combinator
                    |>> fun value_option -> defaultValueArg value_option Array.empty

                let! fragment =
                    opt Fragment.parser_combinator
                    |>> fun value_option -> defaultValueArg value_option Array.empty

                return
                    Array.concat [| relative_part
                                    query
                                    fragment |]
            }

module Hierarchical =
    module Part =
        let parser_combinator =
            opt (
                choice [

                         Authority.path_abempty.parser_combinator
                         Path.Absolute.parser_combinator
                         Path.Rootless.parser_combinator

                          ]
            )
            |>> fun value_option -> defaultValueArg value_option Array.empty

module IRI =
    module Absolute =
        let parser_combinator =
            parser {

                let! scheme = Scheme.parser_combinator
                let! delimiter = colon.parser_combinator
                let! hierarchical_part = Hierarchical.Part.parser_combinator

                let! query_ =
                    opt Query.parser_combinator
                    |>> fun value_option -> defaultValueArg value_option Array.empty

                return
                    Array.concat [| scheme
                                    delimiter
                                    hierarchical_part
                                    query_ |]
            }

    let parser_combinator =
        parser {

            let! absolute = Absolute.parser_combinator

            let! fragment =
                opt Fragment.parser_combinator
                |>> fun value_option -> defaultValueArg value_option Array.empty

            return Array.concat [| absolute; fragment |]

        }

    module Reference =
        let parser_combinator =
            choice [

                     parser_combinator
                     Relative.Reference.parser_combinator

                      ]


(*

type IRITest =
    {

      scheme: string option
      userinfo: string option
      ip_literal: string option
      ipv4_address: string option
      registered_name: string option
      port: string option
      path_abempty: string array option
      path_absolute: string array option
      path_noscheme: string array option
      path_rootless: string array option
      query: string option
      fragment: string option

     }

let iritest =
    {

      scheme = Some "http"
      userinfo = None
      ip_literal = None
      ipv4_address = None
      registered_name = Some "eristocrates.dev"
      port = None
      path_abempty = Some([| "ontology"; "unicode"; "0041" |])
      path_absolute = None
      path_noscheme = None
      path_rootless = None
      query = None
      fragment = None

    }

*)
