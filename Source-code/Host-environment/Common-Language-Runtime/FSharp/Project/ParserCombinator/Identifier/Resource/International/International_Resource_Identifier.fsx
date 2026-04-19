open System
open System.Web
open System.Text
open System.IO
open System.Globalization
open System.Collections.Immutable

#r "nuget: FSharp.Data"
#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\ParserCombinator\Identifier\Resource\Uniform\Uniform_Resource_Identifier.fsx"

open Uniform_Resource_Identifier

open XParsec
open XParsecErgonomics

open FSharp.Data
open UnicodeStandard







let iprivate =
    {

      partition_name = "iprivate"
      unicodepoint_set =
        Unicodepoint_Set.from'ranges
            [| Unicodepoint_Range.from'ints 0xE000 0xF8FF
               Unicodepoint_Range.from'ints 0xF0000 0xFFFFD
               Unicodepoint_Range.from'ints 0x100000 0x10FFFD |]


    }

let ucschar =
    { partition_name = "uschar"
      unicodepoint_set =
        Unicodepoint_Set.from'ranges
            [| Unicodepoint_Range.from'ints 0xA0 0xD7FF
               Unicodepoint_Range.from'ints 0xF900 0xFDCF
               Unicodepoint_Range.from'ints 0xFDF0 0xFFEF
               Unicodepoint_Range.from'ints 0x10000 0x1FFFD
               Unicodepoint_Range.from'ints 0x20000 0x2FFFD
               Unicodepoint_Range.from'ints 0x30000 0x3FFFD
               Unicodepoint_Range.from'ints 0x40000 0x4FFFD
               Unicodepoint_Range.from'ints 0x50000 0x5FFFD
               Unicodepoint_Range.from'ints 0x60000 0x6FFFD
               Unicodepoint_Range.from'ints 0x70000 0x7FFFD
               Unicodepoint_Range.from'ints 0x80000 0x8FFFD
               Unicodepoint_Range.from'ints 0x90000 0x9FFFD
               Unicodepoint_Range.from'ints 0xA0000 0xAFFFD
               Unicodepoint_Range.from'ints 0xB0000 0xBFFFD
               Unicodepoint_Range.from'ints 0xC0000 0xCFFFD
               Unicodepoint_Range.from'ints 0xD0000 0xDFFFD
               Unicodepoint_Range.from'ints 0xE1000 0xEFFFD |] }

let ireserved =
    {

      partition_name = "ireserved"
      unicodepoint_set = Unicodepoint_Set.from'union [| reserved.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let iunreserved =
    {

      partition_name = "iunreserved"
      unicodepoint_set = Unicodepoint_Set.from'union [| unreserved.unicodepoint_set; ucschar.unicodepoint_set |]

    }


let ireg_name =

    {

      partition_name = "ireg-name"
      unicodepoint_set = Unicodepoint_Set.from'union [| reg_name.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let iuserinfo =

    {

      partition_name = "iuserinfo"
      unicodepoint_set = Unicodepoint_Set.from'union [| userinfo.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let isegment_nz_nc =

    {

      partition_name = "isegment-nz-nc"
      unicodepoint_set = Unicodepoint_Set.from'union [| segment_nz_nc.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let ipchar =
    {

      partition_name = "ipchar"
      unicodepoint_set = Unicodepoint_Set.from'union [| pchar_.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let ifragment =
    {

      partition_name = "ifragment"
      unicodepoint_set = Unicodepoint_Set.from'union [| fragment.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let iquery =
    {

      partition_name = "iquery"
      unicodepoint_set =
        Unicodepoint_Set.from'union
            [| query_.unicodepoint_set
               iprivate.unicodepoint_set
               ucschar.unicodepoint_set |]

    }

let isegment_nz =
    {

      partition_name = "isegment-nz"
      unicodepoint_set = Unicodepoint_Set.from'union [| segment_nz.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let isegment =
    {

      partition_name = "isegment"
      unicodepoint_set = Unicodepoint_Set.from'union [| segment.unicodepoint_set; ucschar.unicodepoint_set |]

    }

let iabempty =
    {

      partition_name = "ipath-abempty"
      unicodepoint_set = Unicodepoint_Set.from'union [| abempty.unicodepoint_set; ucschar.unicodepoint_set |]

    }

[<Struct>]
type International_Private_Character =
    {

      as'string: string
      as'int: int

    }



    static member parse
        : Parser<
              International_Private_Character,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (unicodepoint_from iprivate
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 })
            """ iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD """

type UCS_Character =
    {

      as'string: string
      as'int: int

    }


    static member parse
        : Parser<UCS_Character, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (unicodepoint_from ucschar
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 })
            """ ucschar        = %xA0-D7FF / %xF900-FDCF / %xFDF0-FFEF
                              / %x10000-1FFFD / %x20000-2FFFD / %x30000-3FFFD
                              / %x40000-4FFFD / %x50000-5FFFD / %x60000-6FFFD
                              / %x70000-7FFFD / %x80000-8FFFD / %x90000-9FFFD
                              / %xA0000-AFFFD / %xB0000-BFFFD / %xC0000-CFFFD
                              / %xD0000-DFFFD / %xE1000-EFFFD """


[<Struct>]
type International_Unreserved_Character =
    {

      as'string: string
      as'int: int

    }

    static member parse
        : Parser<
              International_Unreserved_Character,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (unicodepoint_from iunreserved
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 })
            """    iunreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" / ucschar """


[<Struct>]
type International_PCharacter =
    {

      as'string: string
      as'int: int

    }

    static member parse
        : Parser<
              International_PCharacter,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (Percent_Encoded_Character.or'unicodepoint_from ipchar
             |>> fun unicodepoint ->
                 {

                   as'string = unicodepoint.as'string
                   as'int = unicodepoint.as'int

                 }


            )
            """    ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@" """


[<Struct>]
type International_Fragment =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

    }

    static member parse
        : Parser<
              International_Fragment,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (

            skip_unicodepoint '#'
            >>. many (Percent_Encoded_Character.or'unicodepoint_from ifragment)
            |>> fun unicodepoints ->

                {

                  as'string = unicodepoints |> Unicodepoint.sequence'to'string
                  as'unicodepoints = unicodepoints |> Seq.toArray

                }

            )
            """   ifragment      = *( ipchar / "/" / "?" ) """



[<Struct>]
type International_Query =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

    }

    static member parse
        : Parser<International_Query, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (

            skip_unicodepoint '?'
            >>. many (Percent_Encoded_Character.or'unicodepoint_from iquery)
            |>> fun unicodepoints ->

                {

                  as'string = unicodepoints |> Unicodepoint.sequence'to'string
                  as'unicodepoints = unicodepoints |> Seq.toArray

                }

            )
            """ iquery         = *( ipchar / iprivate / "/" / "?" ) """


[<Struct>]
type International_Segment =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array
      guaranteed'nonzero_length: bool
      excludes'colon: bool

    }

    static member parse'nonzero_noncolon
        : Parser<
              International_Segment,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (

            many1 (Percent_Encoded_Character.or'unicodepoint_from isegment_nz_nc)
            |>> fun unicodepoints ->

                {

                  as'string = unicodepoints |> Unicodepoint.sequence'to'string
                  as'unicodepoints = unicodepoints |> Seq.toArray
                  guaranteed'nonzero_length = true
                  excludes'colon = true

                }

            )
            """ isegment-nz-nc = 1*( iunreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":" """

    static member parse'nonzero
        : Parser<
              International_Segment,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (

            many1 (Percent_Encoded_Character.or'unicodepoint_from ipchar)
            |>> fun unicodepoints ->

                {

                  as'string = unicodepoints |> Unicodepoint.sequence'to'string
                  as'unicodepoints = unicodepoints |> Seq.toArray
                  guaranteed'nonzero_length = true
                  excludes'colon = false

                }

            )
            """ isegment-nz    = 1*ipchar """

    static member parse
        : Parser<
              International_Segment,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (many (Percent_Encoded_Character.or'unicodepoint_from ipchar)
             |>> fun unicodepoints ->

                 {

                   as'string = unicodepoints |> Unicodepoint.sequence'to'string
                   as'unicodepoints = unicodepoints |> Seq.toArray
                   guaranteed'nonzero_length = false
                   excludes'colon = false

                 }

            )
            """ isegment       = *ipchar """

[<Struct>]
type International_Registered_Name =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

    }

    static member parse
        : Parser<
              International_Registered_Name,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (many (Percent_Encoded_Character.or'unicodepoint_from ireg_name)
             |>> fun unicodepoints ->

                 {

                   as'string = unicodepoints |> Unicodepoint.sequence'to'string
                   as'unicodepoints = unicodepoints |> Seq.toArray

                 }

            )
            """ ireg-name      = *( iunreserved / pct-encoded / sub-delims ) """

[<Struct>]
type International_Host =
    {

      as_string: string
      as'unicodepoints: Unicodepoint array
      path_kind: Host_Kind

    }

    static member parse
        : Parser<International_Host, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice
                [

                  IPv4address.parse
                  |>> fun ipv4address ->
                      {

                        as_string = ipv4address.as'string
                        as'unicodepoints = ipv4address.as'unicodepoints
                        path_kind = Host_Kind.IPv4address

                      }
                  International_Registered_Name.parse
                  |>> fun international_registered_name ->
                      {

                        as_string = international_registered_name.as'string
                        as'unicodepoints = international_registered_name.as'unicodepoints
                        path_kind = Host_Kind.International_Registered_Name

                      }


                  ])
            """ ihost          = IP-literal / IPv4address / ireg-name """


[<Struct>]
type International_Userinfo =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array

    }

    static member parse
        : Parser<
              International_Userinfo,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (

            many (Percent_Encoded_Character.or'unicodepoint_from iuserinfo)
            .>> skip_unicodepoint '@'
            |>> fun unicodepoints ->
                {

                  as'string = unicodepoints |> Unicodepoint.sequence'to'string
                  as'unicodepoints = unicodepoints |> Seq.toArray

                }

            )
            """ iuserinfo      = *( iunreserved / pct-encoded / sub-delims / ":" ) """

[<Struct>]
type International_Authority =
    {

      as'string: string
      as'unicodepoints: Unicodepoint array
      userinfo: International_Userinfo ValueOption
      host: International_Host
      port: Port ValueOption

    }



    static member parse
        : Parser<
              International_Authority,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (parser {
                let! userinfo = opt International_Userinfo.parse
                let! host = International_Host.parse
                let! port = opt Port.parse
                return (userinfo, host, port)
             }
             |>> fun (userinfo_option, host, port_option) ->

                 let authority_string =
                     let userinfoString =
                         match userinfo_option with
                         | ValueSome userinfo -> $"{userinfo.as'string}@"
                         | _ -> String.Empty

                     let portString =
                         match port_option with
                         | ValueSome port -> $":{string port.as'int}"
                         | _ -> String.Empty

                     $"{userinfoString}{host.as_string}{portString}"

                 let unicodepoints =

                     let userinfoUnicodepoints =
                         match userinfo_option with
                         | ValueSome userinfo -> userinfo.as'unicodepoints
                         | _ -> [||]

                     let portUnicodepoints =
                         match port_option with
                         | ValueSome port -> [| Unicodepoint.from'int port.as'int |]
                         | _ -> [||]

                     Seq.concat [ userinfoUnicodepoints; host.as'unicodepoints; portUnicodepoints ]
                     |> Seq.toArray

                 {

                   as'string = authority_string
                   as'unicodepoints = unicodepoints
                   userinfo = userinfo_option
                   host = host
                   port = port_option

                 })
            """  iauthority     = [ iuserinfo "@" ] ihost [ ":" port ] """




[<Struct>]
type IRI_Path =
    {

      as'string: string
      as'segments: International_Segment array
      path_segments: string array
      path_kind: Path_Kind

    }


    static member Empty =
        {

          as'string = String.Empty
          as'segments = [||]
          path_segments = [||]
          path_kind = Path_Kind.empty

        }

    static member parse'rootless
        : Parser<IRI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (International_Segment.parse'nonzero
             .>>. many (skip_unicodepoint '/' >>. International_Segment.parse)
             |>> fun struct (head, tail) ->
                 let segments = Seq.insertAt 0 head tail |> Seq.toArray
                 let path_segments = segments |> Array.map (fun segment -> segment.as'string)

                 {

                   path_segments = path_segments
                   as'string = path_segments |> String.concat "/"
                   as'segments = segments
                   path_kind = Path_Kind.rootless

                 })
            """ ipath-rootless = isegment-nz *( "/" isegment ) """

    static member parse'noscheme
        : Parser<IRI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (International_Segment.parse'nonzero_noncolon
             .>>. many (skip_unicodepoint '/' >>. International_Segment.parse)
             |>> fun struct (head, tail) ->
                 let segments = Seq.insertAt 0 head tail |> Seq.toArray
                 let path_segments = segments |> Array.map (fun segment -> segment.as'string)

                 {

                   path_segments = path_segments

                   as'string = segments |> Seq.map (fun segment -> segment.as'string) |> String.concat "/"
                   as'segments = segments
                   path_kind = Path_Kind.noscheme

                 })
            """ ipath-noscheme = isegment-nz-nc *( "/" isegment ) """

    static member parse'absolute
        : Parser<IRI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (skip_unicodepoint '/' >>. opt (IRI_Path.parse'rootless)
             |>> fun path_absolute_option ->
                 match path_absolute_option with
                 | ValueSome rootless_path ->
                     let path_segments =
                         rootless_path.as'segments |> Array.map (fun segment -> segment.as'string)

                     {

                       path_segments = path_segments
                       as'string = "/" + (rootless_path.as'string)
                       as'segments = rootless_path.as'segments
                       path_kind = Path_Kind.absolute

                     }
                 | _ ->
                     { as'string = "/"
                       path_segments = [||]
                       as'segments = [||]
                       path_kind = Path_Kind.absolute

                     }



            )
            """ ipath-absolute = "/" [ isegment-nz *( "/" isegment ) ] """


    static member parse'abempty
        : Parser<IRI_Path, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (many (skip_unicodepoint '/' >>. International_Segment.parse)
             |>> fun segments ->
                 if segments.Length > 0 then
                     let path_segments =
                         segments |> Seq.toArray |> Array.map (fun segment -> segment.as'string)

                     {

                       path_segments = path_segments

                       as'segments = segments |> Seq.toArray
                       path_kind = Path_Kind.abempty
                       as'string =
                         "/"
                         + (segments |> Seq.map (fun segment -> segment.as'string) |> String.concat "/")

                     }
                 else
                     IRI_Path.Empty




            )
            """ ipath-abempty  = *( "/" isegment ) """
































[<Struct>]
type IRI_Part =
    {

      as'string: string
      authority: International_Authority voption
      iri_path: IRI_Path
      path_kind: Path_Kind

    }


    static member parse
        : Parser<IRI_Part, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice
                [ parser {
                      do! skip_unicodepoint '/'
                      do! skip_unicodepoint '/'
                      let! authority = International_Authority.parse
                      let! path_abempty = IRI_Path.parse'abempty
                      return (authority, path_abempty)
                  }
                  |>> fun (authority, path_abempty) ->
                      {

                        as'string = $"//{authority.as'string}{path_abempty.as'string}"
                        authority = ValueSome authority
                        iri_path = path_abempty
                        path_kind = Path_Kind.authority_abempty

                      }
                  IRI_Path.parse'absolute
                  |>> fun absolute_path ->
                      {

                        as'string = absolute_path.as'string
                        authority = ValueNone
                        iri_path = absolute_path
                        path_kind = absolute_path.path_kind

                      }

                  ]


            )
            """
                      "//" iauthority ipath-abempty
                      / ipath-absolute
"""













[<Struct>]
type International_Relative_Part =
    {

      as'string: string
      authority: International_Authority voption
      iri_path: IRI_Path
      path_kind: Path_Kind

    }

    static member Empty =
        {

          as'string = String.Empty
          authority = ValueNone
          iri_path = IRI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse
        : Parser<
              International_Relative_Part,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (opt (
                choice
                    [ IRI_Part.parse
                      |>> fun iri_part ->
                          {

                            as'string = iri_part.as'string
                            authority = iri_part.authority
                            iri_path = iri_part.iri_path
                            path_kind = iri_part.path_kind

                          }
                      IRI_Path.parse'noscheme
                      |>> fun noscheme_path ->
                          {

                            as'string = noscheme_path.as'string
                            authority = ValueNone
                            iri_path = noscheme_path
                            path_kind = noscheme_path.path_kind

                          } ]
             )
             |>> fun relative_part_option -> defaultValueArg relative_part_option International_Relative_Part.Empty

            )
            """
   irelative-part = "//" iauthority ipath-abempty
                      / ipath-absolute
                      / ipath-noscheme
                      / ipath-empty
"""

[<Struct>]
type International_Relative_Reference =
    {

      as'string: string
      relative_part: International_Relative_Part
      query: Query voption
      fragment: Fragment voption

    }

    static member parse
        : Parser<
              International_Relative_Reference,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (parser {

                let! relative_part = International_Relative_Part.parse
                let! query = opt Query.parse
                let! fragment = opt Fragment.parse
                return (relative_part, query, fragment)
             }
             |>> fun (relative_part, query_option, fragment_option) ->

                 let queryString =
                     match query_option with
                     | ValueSome query -> $"?{query.as'string}"
                     | _ -> String.Empty

                 let fragmentString =
                     match fragment_option with
                     | ValueSome fragment -> $"#{fragment.as'string}"
                     | _ -> String.Empty

                 {

                   as'string = $"{relative_part.as'string}{queryString}{fragmentString}"
                   relative_part = relative_part
                   query = query_option
                   fragment = fragment_option

                 }

            )
            """ irelative-ref  = irelative-part [ "?" iquery ] [ "#" ifragment ] """

[<Struct>]
type International_Hierarchical_Part =
    {

      as'string: string
      authority: International_Authority voption
      iri_path: IRI_Path
      path_kind: Path_Kind

    }

    static member Empty =
        {

          as'string = String.Empty
          authority = ValueNone
          iri_path = IRI_Path.Empty
          path_kind = Path_Kind.empty

        }

    static member parse
        : Parser<
              International_Hierarchical_Part,
              Unicodepoint,
              unit,
              ReadableArray<Unicodepoint>,
              ReadableArraySlice<Unicodepoint>
           > =
        parse_expecting
            (opt (
                choice
                    [ IRI_Part.parse
                      |>> fun iri_part ->
                          {

                            as'string = iri_part.as'string
                            authority = iri_part.authority
                            iri_path = iri_part.iri_path
                            path_kind = iri_part.path_kind

                          }
                      IRI_Path.parse'rootless
                      |>> fun rootless_path ->
                          {

                            as'string = rootless_path.as'string
                            authority = ValueNone
                            iri_path = rootless_path
                            path_kind = rootless_path.path_kind

                          }

                      ]
             )
             |>> fun hierarchical_part_option ->
                 defaultValueArg hierarchical_part_option International_Hierarchical_Part.Empty


            )
            """
   ihier-part     = "//" iauthority ipath-abempty
                  / ipath-absolute
                  / ipath-rootless
                  / ipath-empty
"""

[<Struct>]
type IRI =
    {

      as'string: string
      scheme: Scheme
      hierarchical_part: International_Hierarchical_Part
      query: International_Query voption
      fragment: International_Fragment voption

    }

    static member parse: Parser<IRI, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (parser {

                let! scheme = Scheme.parse
                do! skip_unicodepoint ':'
                let! hierarchical_part = International_Hierarchical_Part.parse
                let! query = opt International_Query.parse
                let! fragment = opt International_Fragment.parse
                return (scheme, hierarchical_part, query, fragment)
             }
             |>> fun (scheme, hierarchical_part, query_option, fragment_option) ->

                 let queryString =
                     match query_option with
                     | ValueSome query -> $"?{query.as'string}"
                     | _ -> String.Empty

                 let fragmentString =
                     match fragment_option with
                     | ValueSome fragment -> $"#{fragment.as'string}"
                     | _ -> String.Empty

                 {

                   as'string = $"{scheme.as'string}:{hierarchical_part.as'string}{queryString}{fragmentString}"
                   scheme = scheme
                   hierarchical_part = hierarchical_part
                   query = query_option
                   fragment = fragment_option

                 }

            )
            """ IRI            = scheme ":" ihier-part [ "?" iquery ] [ "#" ifragment ] """

[<Struct>]
type IRI_Reference =
    {

      as'string: string
      iri: IRI voption
      relative_reference: International_Relative_Reference voption
      is'relative: bool

    }

    static member parse
        : Parser<IRI_Reference, Unicodepoint, unit, ReadableArray<Unicodepoint>, ReadableArraySlice<Unicodepoint>> =
        parse_expecting
            (choice
                [

                  IRI.parse
                  |>> fun iri ->
                      {

                        as'string = iri.as'string
                        iri = ValueSome iri
                        relative_reference = ValueNone
                        is'relative = false

                      }
                  International_Relative_Reference.parse
                  |>> fun relative_reference ->
                      {

                        as'string = relative_reference.as'string
                        iri = ValueNone
                        relative_reference = ValueSome relative_reference
                        is'relative = true

                      }

                  ])
            """ IRI-reference = IRI / irelative-ref """
