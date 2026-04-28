open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Resource_Identifier.fsx"

open Resource_Identifier


open XParsec
open XParsecErgonomics

open Unicode_Standard


#r "nuget: FSharp.UMX"

open FSharp.UMX


[<Measure>]
type IRI_Private_Character

let parse_IRI_Private_Character: Parser<string<IRI_Private_Character>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_code_point_expecting<IRI_Private_Character>
        iprivate
        """ iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD """

[<Measure>]
type UCS_Character



let parse_UCS_Character: Parser<string<UCS_Character>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_code_point_expecting<UCS_Character>
        ucschar
        """ ucschar        = %xA0-D7FF / %xF900-FDCF / %xFDF0-FFEF
                              / %x10000-1FFFD / %x20000-2FFFD / %x30000-3FFFD
                              / %x40000-4FFFD / %x50000-5FFFD / %x60000-6FFFD
                              / %x70000-7FFFD / %x80000-8FFFD / %x90000-9FFFD
                              / %xA0000-AFFFD / %xB0000-BFFFD / %xC0000-CFFFD
                              / %xD0000-DFFFD / %xE1000-EFFFD """

[<Measure>]
type IRI_Unreserved_Character


let parse_IRI_Unreserved_Character =
    parse_code_point_expecting<IRI_Unreserved_Character>
        iunreserved
        """ iunreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" / ucschar """



[<Measure>]
type IRI_PCharacter


let parse_IRI_PCharacter: Parser<string<IRI_PCharacter>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_code_point_or_Percent_Encoded_Character_expecting<IRI_PCharacter>
        ipchar
        """    ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@" """



[<Measure>]
type IRI_Fragment

let parse_IRI_Fragment: Parser<string<IRI_Fragment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many_skip_sigil_prefix<IRI_Fragment>
        '#'
        ifragment
        """   ifragment      = *( ipchar / "/" / "?" ) """

[<Measure>]
type IRI_Query

let parse_IRI_Query: Parser<string<IRI_Query>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many_skip_sigil_prefix<IRI_Query>
        '?'
        iquery
        """iquery         = *( ipchar / iprivate / "/" / "?" ) """

[<Measure>]
type IRI_Segment


let parse_IRI_Segment_nonzero_noncolon: Parser<string<IRI_Segment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many1<IRI_Segment>
        isegment_nz_nc
        """ isegment-nz-nc = 1*( iunreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":" """

let parse_IRI_Segment_nonzero: Parser<string<IRI_Segment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many1<IRI_Segment> isegment_nz """ isegment-nz    = 1*ipchar """


let parse_IRI_Segment: Parser<string<IRI_Segment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many<IRI_Segment> isegment """ isegment       = *ipchar """

[<Measure>]
type IRI_Registered_Name

let parse_IRI_Registered_Name: Parser<string<IRI_Registered_Name>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many ireg_name """ ireg-name      = *( iunreserved / pct-encoded / sub-delims ) """


[<Measure>]
type IRI_Host_Name

[<RequireQualifiedAccess>]
type IRI_Host =
    | FromIPv4address of IPv4address
    | FromIRIRegisteredName of string<IRI_Registered_Name>
    | FromIPLiteral of IP_Literal
    member this.as_string: string<IRI_Host_Name> =
        match this with
        | FromIPv4address ipv4address -> UMX.retag_string<ipv4address, IRI_Host_Name> ipv4address.as_string
        | FromIRIRegisteredName registered_name -> UMX.retag_string<IRI_Registered_Name, IRI_Host_Name> registered_name
        | FromIPLiteral ip_literal -> UMX.retag_string<ip_literal, IRI_Host_Name> ip_literal.as_string

    static member parse: Parser<IRI_Host, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [

                      IP_Literal.parse |>> FromIPLiteral
                      IPv4address.parse |>> FromIPv4address
                      parse_IRI_Registered_Name
                      |>> FromIRIRegisteredName

                       ])
            """ ihost          = IP-literal / IPv4address / ireg-name """

[<Measure>]
type IRI_Userinfo


let parse_IRI_Userinfo: Parser<string<IRI_Userinfo>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many_skip_sigil_postfix<IRI_Userinfo>
        iuserinfo
        '@'
        """ iuserinfo      = *( iunreserved / pct-encoded / sub-delims / ":" ) """



[<Measure>]
type iri_authority

[<Struct>]
type IRI_Authority =
    {

      as_string: string<iri_authority>
      userinfo: string<IRI_Userinfo> ValueOption
      host: IRI_Host
      port: string<Port> ValueOption

     }



    static member parse: Parser<IRI_Authority, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {
                let! userinfo = opt parse_IRI_Userinfo
                let! host = IRI_Host.parse
                let! port = opt parse_Port
                return (userinfo, host, port)
             }
             |>> fun (userinfo_option, host, port_option) ->

                     let authority_string: string<iri_authority> =
                         let userinfoString =
                             match userinfo_option with
                             | ValueSome userinfo -> $"{userinfo}@"
                             | _ -> String.Empty

                         let portString =
                             match port_option with
                             | ValueSome port -> $":{port}"
                             | _ -> String.Empty

                         % $"{userinfoString}{host.as_string}{portString}"

                     {

                       as_string = authority_string
                       userinfo = userinfo_option
                       host = host
                       port = port_option

                     })
            """  iauthority     = [ iuserinfo "@" ] ihost [ ":" port ] """



[<Measure>]
type iri_path

[<Struct>]
type IRI_Path =
    {

      as_string: string<iri_path>
      segments: string<IRI_Segment> array
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as_string = %String.Empty
          segments = [||]
          path_kind = Path_Kind.empty

        }

    static member parse_rootless: Parser<IRI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parse_IRI_Segment_nonzero
             .>>. many (skipcode_point '/' >>. parse_IRI_Segment)
             |>> fun struct (head, tail) ->
                     let segments = Seq.insertAt 0 head tail |> Seq.toArray

                     let raw_string =
                         segments
                         |> Seq.map (fun segment -> UMX.untag segment)
                         |> String.concat "/"

                     {

                       segments = segments
                       as_string = %raw_string
                       path_kind = Path_Kind.rootless

                     })
            """ ipath-rootless = isegment-nz *( "/" isegment ) """

    static member parse_noscheme: Parser<IRI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parse_IRI_Segment_nonzero_noncolon
             .>>. many (skipcode_point '/' >>. parse_IRI_Segment)
             |>> fun struct (head, tail) ->
                     let segments = Seq.insertAt 0 head tail |> Seq.toArray

                     let raw_string =
                         segments
                         |> Seq.map (fun segment -> UMX.untag segment)
                         |> String.concat "/"

                     {

                       segments = segments
                       as_string = %raw_string
                       path_kind = Path_Kind.noscheme

                     })
            """ ipath-noscheme = isegment-nz-nc *( "/" isegment ) """

    static member parse_absolute: Parser<IRI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (skipcode_point '/'
             >>. opt (IRI_Path.parse_rootless)
             |>> fun path_absolute_option ->
                     match path_absolute_option with
                     | ValueSome rootless_path ->
                         let raw_string = "/" + (UMX.untag rootless_path.as_string)

                         {

                           segments = rootless_path.segments
                           as_string = %raw_string
                           path_kind = Path_Kind.absolute

                         }
                     | _ ->
                         { as_string = % "/"
                           segments = [||]
                           path_kind = Path_Kind.absolute

                         }



            )
            """ ipath-absolute = "/" [ isegment-nz *( "/" isegment ) ] """


    static member parse_abempty: Parser<IRI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (many (skipcode_point '/' >>. parse_IRI_Segment)
             |>> fun immutable_array ->
                     if immutable_array.Length > 0 then
                         let segments = immutable_array |> Seq.toArray

                         let raw_string =
                             "/"
                             + (segments
                                |> Array.map (fun segment -> UMX.untag segment)
                                |> String.concat "/")

                         {

                           segments = segments
                           path_kind = Path_Kind.abempty
                           as_string = %raw_string

                         }

                     else
                         IRI_Path.Empty


            )
            """ ipath-abempty  = *( "/" isegment ) """



[<Struct>]
type IRI_Part =
    {

      as_string: string
      authority: IRI_Authority voption
      uri_path: IRI_Path
      path_kind: Path_Kind

     }

    static member parse: Parser<IRI_Part, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [ parser {
                          do! skipcode_point '/'
                          do! skipcode_point '/'
                          let! authority = IRI_Authority.parse
                          let! path_abempty = IRI_Path.parse_abempty
                          return (authority, path_abempty)
                      }
                      |>> fun (authority, path_abempty) ->
                              {

                                as_string = $"//{authority.as_string}{path_abempty.as_string}"
                                authority = ValueSome authority
                                uri_path = path_abempty
                                path_kind = Path_Kind.authority_abempty

                              }

                      IRI_Path.parse_absolute
                      |>> fun absolute_path ->
                              {

                                as_string = UMX.untag absolute_path.as_string
                                authority = ValueNone
                                uri_path = absolute_path
                                path_kind = absolute_path.path_kind

                              }

                       ])
            """
                      "//" iauthority ipath-abempty
                      / ipath-absolute
             
"""



[<Struct>]
type Relative_IRI_Part =
    {

      as_string: string
      authority: IRI_Authority voption
      uri_path: IRI_Path
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as_string = String.Empty
          authority = ValueNone
          uri_path = IRI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse: Parser<Relative_IRI_Part, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (opt (
                choice [ IRI_Part.parse
                         |>> fun uri_part ->
                                 {

                                   as_string = uri_part.as_string
                                   authority = uri_part.authority
                                   uri_path = uri_part.uri_path
                                   path_kind = uri_part.path_kind

                                 }

                         IRI_Path.parse_noscheme
                         |>> fun noscheme_path ->
                                 {

                                   as_string = UMX.untag noscheme_path.as_string
                                   authority = ValueNone
                                   uri_path = noscheme_path
                                   path_kind = noscheme_path.path_kind

                                 }

                          ]
             )
             |>> fun relative_part_option -> defaultValueArg relative_part_option Relative_IRI_Part.Empty

            )
            """
   irelative-part = "//" iauthority ipath-abempty
                      / ipath-absolute
                      / ipath-noscheme
                      / ipath-empty
"""



[<Measure>]
type relative_iri_reference

[<Struct>]
type Relative_IRI_Reference =
    {

      as_string: string<relative_iri_reference>
      relative_part: Relative_IRI_Part
      query: string<IRI_Query> voption
      fragment: string<IRI_Fragment> voption }

    static member parse: Parser<Relative_IRI_Reference, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! relative_part = Relative_IRI_Part.parse
                let! query = opt parse_IRI_Query
                let! fragment = opt parse_IRI_Fragment
                return (relative_part, query, fragment)
             }
             |>> fun (relative_part, query_option, fragment_option) ->

                     let queryString =
                         match query_option with
                         | ValueSome query -> $"?{query}"
                         | _ -> String.Empty

                     let fragmentString =
                         match fragment_option with
                         | ValueSome fragment -> $"#{fragment}"
                         | _ -> String.Empty

                     {

                       as_string = % $"{relative_part.as_string}{queryString}{fragmentString}"
                       relative_part = relative_part
                       query = query_option
                       fragment = fragment_option

                     }

            )
            """ irelative-ref  = irelative-part [ "?" iquery ] [ "#" ifragment ] """





[<Struct>]
type Hierarchical_IRI_Part =
    {

      as_string: string
      authority: IRI_Authority voption
      uri_path: IRI_Path
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as_string = String.Empty
          authority = ValueNone
          uri_path = IRI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse: Parser<Hierarchical_IRI_Part, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (opt (
                choice [

                         IRI_Part.parse
                         |>> fun uri_part ->
                                 {

                                   as_string = uri_part.as_string
                                   authority = uri_part.authority
                                   uri_path = uri_part.uri_path
                                   path_kind = uri_part.path_kind

                                 }
                         IRI_Path.parse_rootless
                         |>> fun rootless_path ->
                                 {

                                   as_string = UMX.untag rootless_path.as_string
                                   authority = ValueNone
                                   uri_path = rootless_path
                                   path_kind = rootless_path.path_kind

                                 }

                          ]
             )
             |>> fun hierarchical_part_option -> defaultValueArg hierarchical_part_option Hierarchical_IRI_Part.Empty)
            """
   ihier-part     = "//" iauthority ipath-abempty
                  / ipath-absolute
                  / ipath-rootless
                  / ipath-empty
"""



[<Measure>]
type absolute_iri

[<Struct>]
type Absolute_IRI =
    {

      as_string: string<absolute_iri>
      scheme: string<resource_scheme>
      hierarchical_part: Hierarchical_IRI_Part
      query: string<IRI_Query> voption

     }

    static member parse: Parser<Absolute_IRI, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! scheme = parse_resource_scheme
                do! skipcode_point ':'
                let! hierarchical_part = Hierarchical_IRI_Part.parse
                let! query = opt parse_IRI_Query
                return (scheme, hierarchical_part, query)
             }
             |>> fun (scheme, hierarchical_part, query_option) ->

                     let queryString =
                         match query_option with
                         | ValueSome query -> $"?{query}"
                         | _ -> String.Empty


                     {

                       as_string = % $"{scheme}:{hierarchical_part.as_string}{queryString}"
                       scheme = scheme
                       hierarchical_part = hierarchical_part
                       query = query_option

                     }

            )
            """ absolute-IRI   = scheme ":" ihier-part [ "?" iquery ] """




[<Measure>]
type iri

[<Struct>]
type IRI =
    {

      as_string: string<iri>
      scheme: string<resource_scheme>
      hierarchical_part: Hierarchical_IRI_Part
      query: string<IRI_Query> voption
      fragment: string<IRI_Fragment> voption

     }

    static member parse: Parser<IRI, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! absolute_iri = Absolute_IRI.parse
                let! fragment = opt parse_IRI_Fragment
                return (absolute_iri, fragment)
             }
             |>> fun (absolute_iri, fragment_option) ->


                     let fragmentString =
                         match fragment_option with
                         | ValueSome fragment -> $"#{fragment}"
                         | _ -> String.Empty

                     {

                       as_string = % $"{absolute_iri.as_string}{fragmentString}"
                       scheme = absolute_iri.scheme
                       hierarchical_part = absolute_iri.hierarchical_part
                       query = absolute_iri.query
                       fragment = fragment_option

                     }

            )
            """ IRI            = scheme ":" ihier-part [ "?" iquery ] [ "#" ifragment ] """


[<Measure>]
type iri_reference

type IRI_Reference =
    | FromIRI of IRI
    | FromRelativeIRIReference of Relative_IRI_Reference

    member this.as_string: string<iri_reference> =
        match this with
        | FromIRI iri -> UMX.retag_string<iri, iri_reference> iri.as_string
        | FromRelativeIRIReference relative_iri_reference ->
            UMX.retag_string<relative_iri_reference, iri_reference> relative_iri_reference.as_string

    static member parse: Parser<IRI_Reference, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [

                      IRI.parse |>> FromIRI

                      Relative_IRI_Reference.parse
                      |>> FromRelativeIRIReference


                       ])
            """ IRI-reference = IRI / relative-ref """
