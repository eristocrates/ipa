open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: Unquote"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Language\Meta\Bacus_Naur_Form\Augmented\Augmented_Bacus_Naur_Form.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Resource_Identifier.fsx"

open Resource_Identifier

open SetErgonomics

open XParsec

open XParsecErgonomics
open Unicode_Standard



#r "nuget: FSharp.UMX"

open FSharp.UMX





















[<Measure>]
type URI_Unreserved_Character


let parse_URI_Unreserved_Character =
    parse_code_point_expecting<URI_Unreserved_Character>
        unreserved
        """ unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" """



[<Measure>]
type URI_PCharacter


let parse_URI_PCharacter: Parser<string<URI_PCharacter>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_code_point_or_Percent_Encoded_Character_expecting<URI_PCharacter>
        pchar_
        """ pchar         = unreserved / pct-encoded / sub-delims / ":" / "@" """


























[<Measure>]
type URI_Fragment

let parse_URI_Fragment: Parser<string<URI_Fragment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many_skip_sigil_prefix<URI_Fragment>
        '#'
        fragment
        """ fragment      = *( pchar / "/" / "?" ) """


[<Measure>]
type URI_Query

let parse_URI_Query: Parser<string<URI_Query>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many_skip_sigil_prefix<URI_Query> '?' query_ """ query         = *( pchar / "/" / "?" ) """



[<Measure>]
type URI_Segment


let parse_URI_Segment_nonzero_noncolon: Parser<string<URI_Segment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many1<URI_Segment>
        segment_nz_nc
        """ segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":" """

let parse_URI_Segment_nonzero: Parser<string<URI_Segment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many1<URI_Segment> segment_nz """ segment-nz    = 1*pchar """


let parse_URI_Segment: Parser<string<URI_Segment>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many<URI_Segment> segment """ segment       = *pchar """



[<Measure>]
type URI_Registered_Name

let parse_URI_Registered_Name: Parser<string<URI_Registered_Name>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many reg_name """ reg-name      = *( unreserved / pct-encoded / sub-delims ) """




[<Measure>]
type URI_Host_Name

[<RequireQualifiedAccess>]
type URI_Host =
    | FromIPv4address of IPv4address
    | FromURIRegisteredName of string<URI_Registered_Name>
    | FromIPLiteral of IP_Literal
    member this.as_string: string<URI_Host_Name> =
        match this with
        | FromIPv4address ipv4address -> UMX.retag_string<ipv4address, URI_Host_Name> ipv4address.as_string
        | FromURIRegisteredName registered_name -> UMX.retag_string<URI_Registered_Name, URI_Host_Name> registered_name
        | FromIPLiteral ip_literal -> UMX.retag_string<ip_literal, URI_Host_Name> ip_literal.as_string

    static member parse: Parser<URI_Host, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [

                      IP_Literal.parse |>> FromIPLiteral
                      IPv4address.parse |>> FromIPv4address
                      parse_URI_Registered_Name
                      |>> FromURIRegisteredName

                       ])
            """ host          = IP-literal / IPv4address / reg-name"""


[<Measure>]
type URI_Userinfo


let parse_URI_Userinfo: Parser<string<URI_Userinfo>, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
    parse_percent_encoded_many_skip_sigil_postfix<URI_Userinfo>
        userinfo
        '@'
        """ userinfo      = *( unreserved / pct-encoded / sub-delims / ":" ) """



[<Measure>]
type uri_authority

[<Struct>]
type URI_Authority =
    {

      as_string: string<uri_authority>
      userinfo: string<URI_Userinfo> ValueOption
      host: URI_Host
      port: string<Port> ValueOption

     }



    static member parse: Parser<URI_Authority, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {
                let! userinfo = opt parse_URI_Userinfo
                let! host = URI_Host.parse
                let! port = opt parse_Port
                return (userinfo, host, port)
             }
             |>> fun (userinfo_option, host, port_option) ->

                     let authority_string: string<uri_authority> =
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
            """  authority     = [ userinfo "@" ] host [ ":" port ] """



[<Measure>]
type uri_path

[<Struct>]
type URI_Path =
    {

      as_string: string<uri_path>
      segments: string<URI_Segment> array
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as_string = %String.Empty
          segments = [||]
          path_kind = Path_Kind.empty

        }

    static member parse_rootless: Parser<URI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parse_URI_Segment_nonzero
             .>>. many (skipcode_point '/' >>. parse_URI_Segment)
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
            """ path-rootless = segment-nz *( "/" segment ) """

    static member parse_noscheme: Parser<URI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parse_URI_Segment_nonzero_noncolon
             .>>. many (skipcode_point '/' >>. parse_URI_Segment)
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
            """ path-noscheme = segment-nz-nc *( "/" segment ) """

    static member parse_absolute: Parser<URI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (skipcode_point '/'
             >>. opt (URI_Path.parse_rootless)
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
            """ path-absolute = "/" [ segment-nz *( "/" segment ) ] """


    static member parse_abempty: Parser<URI_Path, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (many (skipcode_point '/' >>. parse_URI_Segment)
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
                         URI_Path.Empty


            )
            """ path-abempty  = *( "/" segment ) """




[<Struct>]
type URI_Part =
    {

      as_string: string
      authority: URI_Authority voption
      uri_path: URI_Path
      path_kind: Path_Kind

     }

    static member parse: Parser<URI_Part, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [ parser {
                          do! skipcode_point '/'
                          do! skipcode_point '/'
                          let! authority = URI_Authority.parse
                          let! path_abempty = URI_Path.parse_abempty
                          return (authority, path_abempty)
                      }
                      |>> fun (authority, path_abempty) ->
                              {

                                as_string = $"//{authority.as_string}{path_abempty.as_string}"
                                authority = ValueSome authority
                                uri_path = path_abempty
                                path_kind = Path_Kind.authority_abempty

                              }

                      URI_Path.parse_absolute
                      |>> fun absolute_path ->
                              {

                                as_string = UMX.untag absolute_path.as_string
                                authority = ValueNone
                                uri_path = absolute_path
                                path_kind = absolute_path.path_kind

                              }

                       ])
            """
             "//" authority path-abempty
             / path-absolute
             
"""


[<Struct>]
type Relative_URI_Part =
    {

      as_string: string
      authority: URI_Authority voption
      uri_path: URI_Path
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as_string = String.Empty
          authority = ValueNone
          uri_path = URI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse: Parser<Relative_URI_Part, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (opt (
                choice [ URI_Part.parse
                         |>> fun uri_part ->
                                 {

                                   as_string = uri_part.as_string
                                   authority = uri_part.authority
                                   uri_path = uri_part.uri_path
                                   path_kind = uri_part.path_kind

                                 }

                         URI_Path.parse_noscheme
                         |>> fun noscheme_path ->
                                 {

                                   as_string = UMX.untag noscheme_path.as_string
                                   authority = ValueNone
                                   uri_path = noscheme_path
                                   path_kind = noscheme_path.path_kind

                                 }

                          ]
             )
             |>> fun relative_part_option -> defaultValueArg relative_part_option Relative_URI_Part.Empty

            )
            """
relative-part = "//" authority path-abempty
             / path-absolute
             / path-noscheme
             / path-empty
"""




[<Measure>]
type relative_uri_reference

[<Struct>]
type Relative_URI_Reference =
    {

      as_string: string<relative_uri_reference>
      relative_part: Relative_URI_Part
      query: string<URI_Query> voption
      fragment: string<URI_Fragment> voption }

    static member parse: Parser<Relative_URI_Reference, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! relative_part = Relative_URI_Part.parse
                let! query = opt parse_URI_Query
                let! fragment = opt parse_URI_Fragment
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
            """ relative-ref  = relative-part [ "?" query ] [ "#" fragment ] """



[<Struct>]
type Hierarchical_URI_Part =
    {

      as_string: string
      authority: URI_Authority voption
      uri_path: URI_Path
      path_kind: Path_Kind

     }

    static member Empty =
        {

          as_string = String.Empty
          authority = ValueNone
          uri_path = URI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse: Parser<Hierarchical_URI_Part, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (opt (
                choice [

                         URI_Part.parse
                         |>> fun uri_part ->
                                 {

                                   as_string = uri_part.as_string
                                   authority = uri_part.authority
                                   uri_path = uri_part.uri_path
                                   path_kind = uri_part.path_kind

                                 }
                         URI_Path.parse_rootless
                         |>> fun rootless_path ->
                                 {

                                   as_string = UMX.untag rootless_path.as_string
                                   authority = ValueNone
                                   uri_path = rootless_path
                                   path_kind = rootless_path.path_kind

                                 }

                          ]
             )
             |>> fun hierarchical_part_option -> defaultValueArg hierarchical_part_option Hierarchical_URI_Part.Empty)
            """
hier-part     = "//" authority path-abempty
             / path-absolute
             / path-rootless
             / path-empty
"""



[<Measure>]
type absolute_uri

[<Struct>]
type Absolute_URI =
    {

      as_string: string<absolute_uri>
      scheme: string<resource_scheme>
      hierarchical_part: Hierarchical_URI_Part
      query: string<URI_Query> voption

     }

    static member parse: Parser<Absolute_URI, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! scheme = parse_resource_scheme
                do! skipcode_point ':'
                let! hierarchical_part = Hierarchical_URI_Part.parse
                let! query = opt parse_URI_Query
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
            """ absolute-URI  = scheme ":" hier-part [ "?" query ] """



[<Measure>]
type uri

[<Struct>]
type URI =
    {

      as_string: string<uri>
      scheme: string<resource_scheme>
      hierarchical_part: Hierarchical_URI_Part
      query: string<URI_Query> voption
      fragment: string<URI_Fragment> voption

     }

    static member parse: Parser<URI, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (parser {

                let! absolute_uri = Absolute_URI.parse
                let! fragment = opt parse_URI_Fragment
                return (absolute_uri, fragment)
             }
             |>> fun (absolute_uri, fragment_option) ->


                     let fragmentString =
                         match fragment_option with
                         | ValueSome fragment -> $"#{fragment}"
                         | _ -> String.Empty

                     {

                       as_string = % $"{absolute_uri.as_string}{fragmentString}"
                       scheme = absolute_uri.scheme
                       hierarchical_part = absolute_uri.hierarchical_part
                       query = absolute_uri.query
                       fragment = fragment_option

                     }

            )
            """ URI         = scheme ":" hier-part [ "?" query ] [ "#" fragment ] """



[<Measure>]
type uri_reference

type URI_Reference =
    | FromURI of URI
    | FromRelativeURIReference of Relative_URI_Reference

    member this.as_string: string<uri_reference> =
        match this with
        | FromURI uri -> UMX.retag_string<uri, uri_reference> uri.as_string
        | FromRelativeURIReference relative_uri_reference ->
            UMX.retag_string<relative_uri_reference, uri_reference> relative_uri_reference.as_string

    static member parse: Parser<URI_Reference, int, unit, ReadableArray<int>, ReadableArraySlice<int>> =
        parse_expecting
            (choice [

                      URI.parse |>> FromURI

                      Relative_URI_Reference.parse
                      |>> FromRelativeURIReference


                       ])
            """ URI-reference = URI / relative-ref """
