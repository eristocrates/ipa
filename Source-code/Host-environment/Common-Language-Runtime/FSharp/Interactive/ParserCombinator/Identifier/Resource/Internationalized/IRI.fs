module ParserCombinator.IRI

open System
open System.Web
open System.Text
open System.IO
open System.Globalization



open System.Collections.Immutable


open XParsec
open XParsec.Parsers


open Ergonomics.XParsecErgonomics



open Unicodepoint.Punctuation






open URI








type Internationalized_Private_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value

        (0xE000 <= codepoint && codepoint <= 0xF8FF)
        || (0xF0000 <= codepoint && codepoint <= 0xFFFFD)
        || (0x100000 <= codepoint && codepoint <= 0x10FFFD)

    static member parse: Parser<Internationalized_Private_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy Internationalized_Private_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            """ iprivate       = %xE000-F8FF / %xF0000-FFFFD / %x100000-10FFFD """

type UCS_Character =
    { as_rune: Rune }

    static member is_in_range(rune: Rune) =
        let codepoint = rune.Value

        (0x00A0 <= codepoint && codepoint <= 0xD7FF)
        || (0xF900 <= codepoint && codepoint <= 0xFDCF)
        || (0xFDF0 <= codepoint && codepoint <= 0xFFEF)
        || (0x10000 <= codepoint && codepoint <= 0x1FFFD)
        || (0x20000 <= codepoint && codepoint <= 0x2FFFD)
        || (0x30000 <= codepoint && codepoint <= 0x3FFFD)
        || (0x40000 <= codepoint && codepoint <= 0x4FFFD)
        || (0x50000 <= codepoint && codepoint <= 0x5FFFD)
        || (0x60000 <= codepoint && codepoint <= 0x6FFFD)
        || (0x70000 <= codepoint && codepoint <= 0x7FFFD)
        || (0x80000 <= codepoint && codepoint <= 0x8FFFD)
        || (0x90000 <= codepoint && codepoint <= 0x9FFFD)
        || (0xA0000 <= codepoint && codepoint <= 0xAFFFD)
        || (0xB0000 <= codepoint && codepoint <= 0xBFFFD)
        || (0xC0000 <= codepoint && codepoint <= 0xCFFFD)
        || (0xD0000 <= codepoint && codepoint <= 0xDFFFD)
        || (0xE1000 <= codepoint && codepoint <= 0xEFFFD)

    static member parse: Parser<UCS_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (satisfy UCS_Character.is_in_range
             |>> fun rune -> { as_rune = rune })
            """ ucschar        = %xA0-D7FF / %xF900-FDCF / %xFDF0-FFEF
                              / %x10000-1FFFD / %x20000-2FFFD / %x30000-3FFFD
                              / %x40000-4FFFD / %x50000-5FFFD / %x60000-6FFFD
                              / %x70000-7FFFD / %x80000-8FFFD / %x90000-9FFFD
                              / %xA0000-AFFFD / %xB0000-BFFFD / %xC0000-CFFFD
                              / %xD0000-DFFFD / %xE1000-EFFFD """

[<RequireQualifiedAccess>]
type Internationalized_Unreserved_Character =
    | FromUnreservedCharacter of Unreserved_Character
    | FromInternationalCharacter of UCS_Character

    member this.as_rune =
        match this with
        | FromUnreservedCharacter unreserved_character -> unreserved_character.as_rune
        | FromInternationalCharacter unicode_character -> unicode_character.as_rune

    static member parse: Parser<Internationalized_Unreserved_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Unreserved_Character.parse
                      |>> FromUnreservedCharacter
                      UCS_Character.parse |>> FromInternationalCharacter

                       ])
            """    iunreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" / ucschar """

[<RequireQualifiedAccess>]
type Internationalized_Registered_Name_Character =

    | FromInternationalUnreservedCharacter of Internationalized_Unreserved_Character
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromSubcomponentDelimiterCharacter of Subcomponent_Delimiter_Character

    member this.as_rune =
        match this with
        | FromInternationalUnreservedCharacter unreserved_character -> unreserved_character.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromSubcomponentDelimiterCharacter subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune

    static member parse: Parser<Internationalized_Registered_Name_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Internationalized_Unreserved_Character.parse
                      |>> FromInternationalUnreservedCharacter
                      Percent_Encoded_Character.parse
                      |>> FromPercentEncodedCharacter
                      Subcomponent_Delimiter_Character.parse
                      |>> FromSubcomponentDelimiterCharacter

                       ])
            """  iunreserved / pct-encoded / sub-delims  """

[<RequireQualifiedAccess>]
type Internationalized_NonColon_Path_Character =

    | FromInternationalRegisteredNameCharacter of Internationalized_Registered_Name_Character
    | FromCommercialAt of Commercial_At

    member this.as_rune =
        match this with
        | FromInternationalRegisteredNameCharacter registered_name_character -> registered_name_character.as_rune
        | FromCommercialAt ampersand -> ampersand.as_rune

    static member parse: Parser<Internationalized_NonColon_Path_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Internationalized_Registered_Name_Character.parse
                      |>> FromInternationalRegisteredNameCharacter
                      Commercial_At.parse |>> FromCommercialAt

                       ])
            """  iunreserved / pct-encoded / sub-delims / "@" """

[<RequireQualifiedAccess>]
type Internationalized_Path_Character =
    | FromInternationalNonColonPathCharacter of Internationalized_NonColon_Path_Character
    | FromColon of Colon

    member this.as_rune =
        match this with
        | FromInternationalNonColonPathCharacter noncolon_path_character -> noncolon_path_character.as_rune
        | FromColon colon -> colon.as_rune

    static member parse: Parser<Internationalized_Path_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Internationalized_NonColon_Path_Character.parse
                      |>> FromInternationalNonColonPathCharacter
                      Colon.parse |>> FromColon

                       ])
            """    ipchar         = iunreserved / pct-encoded / sub-delims / ":" / "@" """

[<RequireQualifiedAccess>]
type Internationalized_Fragment_Character =
    | FromInternationalPathCharacter of Internationalized_Path_Character
    | FromSolidus of Solidus
    | FromQuestionMark of Question_Mark

    member this.as_rune =
        match this with
        | FromInternationalPathCharacter path_character -> path_character.as_rune
        | FromSolidus solidus -> solidus.as_rune
        | FromQuestionMark question_mark -> question_mark.as_rune

    static member parse: Parser<Internationalized_Fragment_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Internationalized_Path_Character.parse
                      |>> FromInternationalPathCharacter
                      Solidus.parse |>> FromSolidus
                      Question_Mark.parse |>> FromQuestionMark

                       ])
            """  ipchar / "/" / "?"  """

[<RequireQualifiedAccess>]
type Internationalized_Query_Character =
    | FromInternationalFragmentCharacter of Internationalized_Fragment_Character
    | FromInternationalPrivateCharacter of Internationalized_Private_Character

    member this.as_rune =
        match this with
        | FromInternationalFragmentCharacter queryOrFragment_character -> queryOrFragment_character.as_rune
        | FromInternationalPrivateCharacter unicode_character -> unicode_character.as_rune

    static member parse: Parser<Internationalized_Query_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Internationalized_Fragment_Character.parse
                      |>> FromInternationalFragmentCharacter
                      Internationalized_Private_Character.parse
                      |>> FromInternationalPrivateCharacter

                       ])
            """   ipchar / iprivate / "/" / "?"   """

type Internationalized_NonColon_NonEmpty_Segment =
    {

      as_characters: ImmutableArray<Internationalized_NonColon_Path_Character>

     }

    member this.as_string = string_from_characters this.as_characters

    static member parse: Parser<Internationalized_NonColon_NonEmpty_Segment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many1 Internationalized_NonColon_Path_Character.parse
             |>> fun characters ->
                     {

                       as_characters = characters

                     })
            """    isegment-nz-nc = 1*( iunreserved / pct-encoded / sub-delims / "@" )
                  ; non-zero-length segment without any colon ":" 
                  """

type Internationalized_NonEmpty_Segment =
    { nonempty_segment: ImmutableArray<Internationalized_Path_Character> }
    member this.as_string = string_from_characters this.nonempty_segment
    member this.as_characters = this.nonempty_segment

    static member parse: Parser<Internationalized_NonEmpty_Segment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many1 Internationalized_Path_Character.parse
             |>> fun characters -> { nonempty_segment = characters })
            """ isegment-nz    = 1*ipchar """


// TODO character dependent delimiters like . for "subsegments"?
type Internationalized_Segment =
    { segment: ImmutableArray<Internationalized_Path_Character> }

    member this.as_characters = this.segment
    member this.as_string = string_from_characters this.segment
    static member Empty = Empty_Segment()

    static member parse: Parser<Internationalized_Segment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many Internationalized_Path_Character.parse
             |>> fun characters -> { segment = characters })
            """   isegment       = *ipchar"""


type Internationalized_Rootless_Path =
    {

      head: Internationalized_NonEmpty_Segment
      tail: ImmutableArray<Internationalized_Segment>

     }

    member this.tail_string_segments =
        this.tail
        |> Seq.map (fun segment -> segment.as_string)

    member this.tail_string = string_from_segments this.tail
    member this.as_string = $"{this.head.as_string}{this.tail_string}"

    static member parse: Parser<Internationalized_Rootless_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Internationalized_NonEmpty_Segment.parse
             .>>. many (Solidus.parse >>. Internationalized_Segment.parse)
             |>> fun struct (head, tail) -> { head = head; tail = tail })
            """    ipath-rootless = isegment-nz *( "/" isegment ) """



type Internationalized_NoScheme_Path =
    {

      head: Internationalized_NonColon_NonEmpty_Segment
      tail: ImmutableArray<Internationalized_Segment>

     }


    member this.tail_string_segments =
        this.tail
        |> Seq.map (fun segment -> segment.as_string)

    member this.tail_string = string_from_segments this.tail
    member this.as_string = $"{this.head.as_string}{this.tail_string}"

    static member parse: Parser<Internationalized_NoScheme_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Internationalized_NonColon_NonEmpty_Segment.parse
             .>>. many (Solidus.parse >>. Internationalized_Segment.parse)
             |>> fun struct (head, tail) -> { head = head; tail = tail })
            """ ipath-noscheme = isegment-nz-nc *( "/" isegment ) """

type Internationalized_Absolute_Path =
    {

      head: Internationalized_Segment
      tail: ImmutableArray<Internationalized_Segment>

     }


    member this.tail_string_segments =
        this.tail
        |> Seq.map (fun segment -> segment.as_string)

    member this.tail_string = string_from_segments this.tail
    member this.as_string = $"/{this.head.as_string}{this.tail_string}"

    static member parse: Parser<Internationalized_Absolute_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Solidus.parse
             >>. opt (Internationalized_Rootless_Path.parse)

             |>> fun rootless_path_option ->
                     let head =
                         match rootless_path_option with
                         | ValueSome rootless_path -> { segment = rootless_path.head.nonempty_segment }
                         | ValueNone -> { segment = ImmutableArray.Empty }

                     let tail =
                         match rootless_path_option with
                         | ValueSome rootless_path -> rootless_path.tail
                         | ValueNone -> ImmutableArray.Empty

                     {

                       head = head
                       tail = tail

                     }

            )

            """    ipath-absolute = "/" [ isegment-nz *( "/" isegment ) ] """

type Internationalized_Abempty_Path =
    {

      segments: ImmutableArray<Internationalized_Segment>

     }

    // member this.as_string = "/" + string_from_segments this.segments
    member this.as_string = string_from_segments this.segments


    static member parse: Parser<Internationalized_Abempty_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many (Solidus.parse >>. Internationalized_Segment.parse)

             |>> fun segments -> { segments = segments }

            )

            """ ipath-abempty  = *( "/" isegment ) """

[<RequireQualifiedAccess>]
type IRI_Path =
    | FromInternationalAbemptyPath of Internationalized_Abempty_Path
    | FromInternationalAbsolutePath of Internationalized_Absolute_Path
    | FromInternationalNoSchemePath of Internationalized_NoScheme_Path
    | FromInternationalRootlessPath of Internationalized_Rootless_Path
    | FromEmptyPath of Empty_Path


    member this.as_string =
        match this with
        | FromInternationalRootlessPath rootless_path -> rootless_path.as_string
        | FromInternationalNoSchemePath noscheme_path -> noscheme_path.as_string
        | FromInternationalAbsolutePath absolute_path -> absolute_path.as_string
        | FromInternationalAbemptyPath abempty_path -> abempty_path.as_string
        | FromEmptyPath _ -> String.Empty


    static member Empty = Empty_Path()

    static member parse: Parser<IRI_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (opt (
                choice [

                         Internationalized_Absolute_Path.parse
                         |>> FromInternationalAbsolutePath
                         Internationalized_Rootless_Path.parse
                         |>> FromInternationalRootlessPath
                         Internationalized_NoScheme_Path.parse
                         |>> FromInternationalNoSchemePath
                         Internationalized_Abempty_Path.parse
                         |>> FromInternationalAbemptyPath

                          ]
             )
             |>> fun hierarchical_path_option -> defaultValueArg hierarchical_path_option (FromEmptyPath(Empty_Path())))

            """
   ipath          = ipath-abempty   ; begins with "/" or is empty
                  / ipath-absolute  ; begins with "/" but not "//"
                  / ipath-noscheme  ; begins with a non-colon segment
                  / ipath-rootless  ; begins with a segment
                  / ipath-empty     ; zero characters
            """


type Internationalized_Registered_Name =
    { registered_name: ImmutableArray<Internationalized_Registered_Name_Character> }

    member this.as_characters = this.registered_name
    member this.as_string = string_from_characters this.registered_name

    static member parse: Parser<Internationalized_Registered_Name, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many Internationalized_Registered_Name_Character.parse
             |>> fun characters -> { registered_name = characters })
            """ ireg-name      = *( iunreserved / pct-encoded / sub-delims ) """

// TODO maybe one day
// IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
//
// IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
//
// IPv6address   =                            6( h16 ":" ) ls32
//              /                       "::" 5( h16 ":" ) ls32
//              / [               h16 ] "::" 4( h16 ":" ) ls32
//              / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
//              / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
//              / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
//              / [ *4( h16 ":" ) h16 ] "::"              ls32
//              / [ *5( h16 ":" ) h16 ] "::"              h16
//              / [ *6( h16 ":" ) h16 ] "::"
//
// h16           = 1*4HEXDIG
// ls32          = ( h16 ":" h16 ) / IPv4address

[<RequireQualifiedAccess>]
type Internationalized_Host =
    | FromIPv4address of IPv4address
    | FromRegisteredName of Internationalized_Registered_Name

    member this.as_string =
        match this with
        | FromIPv4address ipv4address -> ipv4address.as_string
        | FromRegisteredName registered_name -> registered_name.as_string

    static member parse: Parser<Internationalized_Host, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      IPv4address.parse |>> FromIPv4address
                      Internationalized_Registered_Name.parse
                      |>> FromRegisteredName


                       ])
            """ ihost          =  IPv4address / ireg-name """

[<RequireQualifiedAccess>]
type Internationalized_Userinfo_Character =
    | FromInternationalRegisteredNameCharacter of Internationalized_Registered_Name_Character
    | FromColon of Colon

    member this.as_rune =
        match this with
        | FromInternationalRegisteredNameCharacter registered_name_character -> registered_name_character.as_rune
        | FromColon colon -> colon.as_rune

    static member parse: Parser<Internationalized_Userinfo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Internationalized_Registered_Name_Character.parse
                      |>> FromInternationalRegisteredNameCharacter
                      Colon.parse |>> FromColon

                       ])
            """  iunreserved / pct-encoded / sub-delims / ":"  """

type Internationalized_Userinfo =
    {

      userinfo: ImmutableArray<Internationalized_Userinfo_Character>

     }
    member this.as_string = string_from_characters this.userinfo
    member this.as_characters = this.userinfo

    static member parse: Parser<Internationalized_Userinfo, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (

            many Internationalized_Userinfo_Character.parse
            .>> Commercial_At.parse
            |>> fun characters -> { userinfo = characters }

            )
            """ iuserinfo      = *( iunreserved / pct-encoded / sub-delims / ":" ) """


type Internationalized_Authority =
    { userinfo: Internationalized_Userinfo ValueOption
      host: Internationalized_Host
      port: Port ValueOption }


    member this.as_string =

        let userinfoString =
            match this.userinfo with
            | ValueSome userinfo -> $"{userinfo.as_string}@"
            | _ -> String.Empty

        let portString =
            match this.port with
            | ValueSome port -> $":{string port.as_int}"
            | _ -> String.Empty

        $"{userinfoString}{this.host.as_string}{portString}"

    static member parse: Parser<Internationalized_Authority, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {
                let! userinfo = opt Internationalized_Userinfo.parse
                let! host = Internationalized_Host.parse
                let! port = opt Port.parse
                return (userinfo, host, port)
             }
             |>> fun (userinfo_option, host, port_option) ->

                     {

                       userinfo = userinfo_option
                       host = host
                       port = port_option

                     })
            """ iauthority     = [ iuserinfo "@" ] ihost [ ":" port ] """



type Internationalized_Authority_Path =
    {

      head: Internationalized_Authority
      tail: Internationalized_Abempty_Path

     }


    member this.as_string = $"//{this.head.as_string}{this.tail.as_string}"

    member this.tail_string_segments =
        this.tail.segments
        |> Seq.map (fun segment -> segment.as_string)


    static member parse: Parser<Internationalized_Authority_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {
                let! _ = Solidus.parse
                let! _ = Solidus.parse
                let! head = Internationalized_Authority.parse
                let! tail = Internationalized_Abempty_Path.parse
                return (head, tail)
             }

             |>> fun (head, tail) ->

                     {

                       head = head
                       tail = tail

                     }

            )

            """ ipath-absolute = "/" [ isegment-nz *( "/" isegment ) ] """


[<RequireQualifiedAccess>]
type Internationalized_Relative_Path =
    | FromInternationalAuthorityPath of Internationalized_Authority_Path
    | FromInternationalAbsolutePath of Internationalized_Absolute_Path
    | FromInternationalNoSchemePath of Internationalized_NoScheme_Path
    | FromEmptyPath of Empty_Path

    member this.as_string =
        match this with
        | FromInternationalAuthorityPath authority_path -> authority_path.as_string
        | FromInternationalNoSchemePath noscheme_path -> noscheme_path.as_string
        | FromInternationalAbsolutePath absolute_path -> absolute_path.as_string
        | FromEmptyPath empty_path -> String.Empty


    static member parse: Parser<Internationalized_Relative_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (opt (
                choice [

                         Internationalized_Authority_Path.parse
                         |>> FromInternationalAuthorityPath
                         Internationalized_Absolute_Path.parse
                         |>> FromInternationalAbsolutePath
                         Internationalized_NoScheme_Path.parse
                         |>> FromInternationalNoSchemePath


                          ]
             )
             |>> fun hierarchical_path_option -> defaultValueArg hierarchical_path_option (FromEmptyPath(Empty_Path())))
            """
   irelative-part = "//" iauthority ipath-abempty
                      / ipath-absolute
                      / ipath-noscheme
                      / ipath-empty
            """
// TODO handle key value paired query strings
type Internationalized_Query =
    { query_: ImmutableArray<Internationalized_Query_Character> }
    member this.as_characters = this.query_
    member this.as_string = string_from_characters this.query_

    static member string_from_option(query_option: Internationalized_Query ValueOption) =
        match query_option with
        | ValueSome query -> $"?{query.as_string}"
        | _ -> String.Empty


    static member parse: Parser<Internationalized_Query, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Question_Mark.parse
             >>. many Internationalized_Query_Character.parse
             |>> fun characters -> { query_ = characters })
            """ iquery         = *( ipchar / iprivate / "/" / "?" ) """

type Internationalized_Fragment =
    { fragment: ImmutableArray<Internationalized_Fragment_Character> }
    member this.as_characters = this.fragment
    member this.as_string = string_from_characters this.fragment

    static member string_from_option(fragment_option: Internationalized_Fragment ValueOption) =
        match fragment_option with
        | ValueSome fragment -> $"#{fragment.as_string}"
        | _ -> String.Empty

    static member parse: Parser<Internationalized_Fragment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Number_Sign.parse
             >>. many Internationalized_Fragment_Character.parse
             |>> fun characters -> { fragment = characters })
            """    ifragment      = *( ipchar / "/" / "?" ) """

type Internationalized_Relative_Reference =
    {

      relative_path: Internationalized_Relative_Path
      query: Internationalized_Query ValueOption
      fragment: Internationalized_Fragment ValueOption

     }
    member this.as_string =
        $"{this.relative_path.as_string}{Internationalized_Query.string_from_option this.query}{Internationalized_Fragment.string_from_option this.fragment}"

    static member parse: Parser<Internationalized_Relative_Reference, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! relative_path = Internationalized_Relative_Path.parse
                let! query = opt Internationalized_Query.parse
                let! fragment = opt Internationalized_Fragment.parse
                return (relative_path, query, fragment)

             }
             |>> fun (relative_path, query, fragment) ->

                     {

                       relative_path = relative_path
                       query = query
                       fragment = fragment

                     }


            )
            """ relative-ref  = relative-part [ "?" query ] [ "#" fragment ] """


[<RequireQualifiedAccess>]
type Internationalized_Hierarchical_Path =
    | FromInternationalAuthorityPath of Internationalized_Authority_Path
    | FromInternationalAbsolutePath of Internationalized_Absolute_Path
    | FromInternationalRootlessPath of Internationalized_Rootless_Path
    | FromEmptyPath of Empty_Path

    member this.as_string =
        match this with
        | FromInternationalAuthorityPath authority_path -> authority_path.as_string
        | FromInternationalAbsolutePath absolute_path -> absolute_path.as_string
        | FromInternationalRootlessPath rootless_path -> rootless_path.as_string
        | FromEmptyPath _ -> String.Empty


    static member parse: Parser<Internationalized_Hierarchical_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (opt (
                choice [

                         Internationalized_Authority_Path.parse
                         |>> FromInternationalAuthorityPath
                         Internationalized_Absolute_Path.parse
                         |>> FromInternationalAbsolutePath
                         Internationalized_Rootless_Path.parse
                         |>> FromInternationalRootlessPath


                          ]
             )
             |>> fun hierarchical_path_option -> defaultValueArg hierarchical_path_option (FromEmptyPath(Empty_Path())))
            """
hier-part     = "//" authority path-abempty
             / path-absolute
             / path-rootless
             / path-empty
            """

type Absolute_IRI =
    {

      scheme: Scheme
      hierarchical_path: Internationalized_Hierarchical_Path
      query: Internationalized_Query ValueOption

     }
    member this.as_string =
        $"{this.scheme.as_string}:{this.hierarchical_path.as_string}{Internationalized_Query.string_from_option this.query}"

    static member parse: Parser<Absolute_IRI, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! scheme = Scheme.parse
                do! skip_rune ':'
                let! hierarchical_path = Internationalized_Hierarchical_Path.parse
                let! query = opt Internationalized_Query.parse
                return (scheme, hierarchical_path, query)

             }
             |>> fun (scheme, hierarchical_path, query) ->

                     {

                       scheme = scheme
                       hierarchical_path = hierarchical_path
                       query = query

                     }


            )
            """ absolute-IRI  = scheme ":" hier-part [ "?" query ] """

type IRI =
    {

      scheme: Scheme
      hierarchical_path: Internationalized_Hierarchical_Path
      query: Internationalized_Query ValueOption
      fragment: Internationalized_Fragment ValueOption

     }
    member this.as_string =
        $"{this.scheme.as_string}:{this.hierarchical_path.as_string}{Internationalized_Query.string_from_option this.query}{Internationalized_Fragment.string_from_option this.fragment}"

    member this.absolute_iri: Absolute_IRI =
        {

          scheme = this.scheme
          hierarchical_path = this.hierarchical_path
          query = this.query }

    static member parse: Parser<IRI, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! absolute_iri = Absolute_IRI.parse
                let! fragment = opt Internationalized_Fragment.parse
                return (absolute_iri, fragment)

             }
             |>> fun (absolute_iri, fragment) ->

                     {

                       scheme = absolute_iri.scheme
                       hierarchical_path = absolute_iri.hierarchical_path
                       query = absolute_iri.query
                       fragment = fragment

                     }


            )
            """ IRI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ] """

    static member from_string(input: string) =
        result_from_parse IRI.parse OnInput input

[<RequireQualifiedAccess>]
type IRI_Reference =
    | FromIRI of IRI
    | FromRelativeReference of Internationalized_Relative_Reference

    member this.path =
        match this with
        | FromIRI iri ->
            match iri.hierarchical_path with
            | Internationalized_Hierarchical_Path.FromInternationalAuthorityPath authority_path ->
                IRI_Path.FromInternationalAbemptyPath authority_path.tail
            | Internationalized_Hierarchical_Path.FromInternationalAbsolutePath absolute_path ->
                IRI_Path.FromInternationalAbsolutePath absolute_path
            | Internationalized_Hierarchical_Path.FromInternationalRootlessPath rootless_path ->
                IRI_Path.FromInternationalRootlessPath rootless_path
            | Internationalized_Hierarchical_Path.FromEmptyPath empty_path -> IRI_Path.FromEmptyPath empty_path

        | FromRelativeReference relative_reference ->
            match relative_reference.relative_path with
            | Internationalized_Relative_Path.FromInternationalAuthorityPath authority_path ->
                IRI_Path.FromInternationalAbemptyPath authority_path.tail
            | Internationalized_Relative_Path.FromInternationalAbsolutePath absolute_path ->
                IRI_Path.FromInternationalAbsolutePath absolute_path
            | Internationalized_Relative_Path.FromInternationalNoSchemePath noscheme_path ->
                IRI_Path.FromInternationalNoSchemePath noscheme_path
            | Internationalized_Relative_Path.FromEmptyPath empty_path -> IRI_Path.FromEmptyPath empty_path

    member this.query =
        match this with
        | FromIRI iri -> iri.query
        | FromRelativeReference relative_reference -> relative_reference.query

    member this.fragment =
        match this with
        | FromIRI iri -> iri.fragment
        | FromRelativeReference relative_reference -> relative_reference.fragment

    member this.as_string =
        match this with
        | FromIRI iri -> iri.as_string
        | FromRelativeReference relative_reference -> relative_reference.as_string

    static member parse: Parser<IRI_Reference, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      IRI.parse |>> FromIRI
                      Internationalized_Relative_Reference.parse
                      |>> FromRelativeReference

                       ])
            """  IRI-reference = IRI / relative-ref """
