module ParserCombinator.URI
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








[<RequireQualifiedAccess>]
type Subcomponent_Delimiter_Character =
    | FromExclamationMark of Exclamation_Mark
    | FromDollarSign of Dollar_Sign
    | FromAmpersand of Ampersand
    | FromApostrophe of Apostrophe
    | FromLeftParenthesis of Left_Parenthesis
    | FromRightParenthesis of Right_Parenthesis
    | FromAsterisk of Asterisk
    | FromPlusSign of Plus_Sign
    | FromComma of Comma
    | FromSemicolon of Semicolon
    | FromEqualsSign of Equals_Sign
    member this.as_rune =
        match this with
        | FromExclamationMark exclamation_mark -> exclamation_mark.as_rune
        | FromDollarSign dollar_sign -> dollar_sign.as_rune
        | FromAmpersand ampersand -> ampersand.as_rune
        | FromApostrophe apostrophe -> apostrophe.as_rune
        | FromLeftParenthesis left_parenthesis -> left_parenthesis.as_rune
        | FromRightParenthesis right_parenthesis -> right_parenthesis.as_rune
        | FromAsterisk asterisk -> asterisk.as_rune
        | FromPlusSign plus_sign -> plus_sign.as_rune
        | FromComma comma -> comma.as_rune
        | FromSemicolon semicolon -> semicolon.as_rune
        | FromEqualsSign equals_sign -> equals_sign.as_rune

    static member parse: Parser<Subcomponent_Delimiter_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Exclamation_Mark.parse |>> FromExclamationMark
                      Dollar_Sign.parse |>> FromDollarSign
                      Ampersand.parse |>> FromAmpersand
                      Apostrophe.parse |>> FromApostrophe
                      Left_Parenthesis.parse |>> FromLeftParenthesis
                      Right_Parenthesis.parse |>> FromRightParenthesis
                      Asterisk.parse |>> FromAsterisk
                      Plus_Sign.parse |>> FromPlusSign
                      Comma.parse |>> FromComma
                      Semicolon.parse |>> FromSemicolon
                      Equals_Sign.parse |>> FromEqualsSign

                       ])
            """ sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "=" """

[<RequireQualifiedAccess>]
type General_Component_Delimiter_Character =
    | FromColon of Colon
    | FromSolidus of Solidus
    | FromQuestionMark of Question_Mark
    | FromNumberSign of Number_Sign
    | FromLeftSquareBracket of Left_Square_Bracket
    | FromRightSquareBracket of Right_Square_Bracket
    | FromCommercialAt of Commercial_At

    member this.as_rune =
        match this with
        | FromColon colon -> colon.as_rune
        | FromSolidus solidus -> solidus.as_rune
        | FromQuestionMark question_mark -> question_mark.as_rune
        | FromNumberSign number_sign -> number_sign.as_rune
        | FromLeftSquareBracket left_square_bracket -> left_square_bracket.as_rune
        | FromRightSquareBracket right_square_bracket -> right_square_bracket.as_rune
        | FromCommercialAt commercial_at -> commercial_at.as_rune

    static member parse: Parser<General_Component_Delimiter_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Colon.parse |>> FromColon
                      Solidus.parse |>> FromSolidus
                      Question_Mark.parse |>> FromQuestionMark
                      Number_Sign.parse |>> FromNumberSign
                      Left_Square_Bracket.parse
                      |>> FromLeftSquareBracket
                      Right_Square_Bracket.parse
                      |>> FromRightSquareBracket
                      Commercial_At.parse |>> FromCommercialAt

                       ])
            """ gen-delims  = ":" / "/" / "?" / "#" / "[" / "]" / "@" """

[<RequireQualifiedAccess>]
type Unreserved_Character =
    | FromALPHA of ABNF.ALPHA
    | FromDIGIT of ABNF.DIGIT
    | FromHyphenMinus of Hyphen_Minus
    | FromFullStop of Full_Stop
    | FromLowLine of Low_Line
    | FromTilde of Tilde

    member this.as_rune =
        match this with
        | FromALPHA alpha -> alpha.as_rune
        | FromDIGIT digit -> digit.as_rune
        | FromHyphenMinus hyphen_minus -> hyphen_minus.as_rune
        | FromFullStop full_stop -> full_stop.as_rune
        | FromLowLine low_line -> low_line.as_rune
        | FromTilde tilde -> tilde.as_rune

    static member parse: Parser<Unreserved_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      ABNF.ALPHA.parse |>> FromALPHA
                      ABNF.DIGIT.parse |>> FromDIGIT
                      Hyphen_Minus.parse |>> FromHyphenMinus
                      Full_Stop.parse |>> FromFullStop
                      Low_Line.parse |>> FromLowLine
                      Tilde.parse |>> FromTilde

                       ])
            """ unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~" """

[<RequireQualifiedAccess>]
type Reserved_Character =
    | FromSubcomponentDelimiterCharacter of Subcomponent_Delimiter_Character
    | FromGeneralComponentDelimiterCharacter of General_Component_Delimiter_Character

    member this.as_rune =
        match this with
        | FromSubcomponentDelimiterCharacter subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune
        | FromGeneralComponentDelimiterCharacter general_component_delimiter_character ->
            general_component_delimiter_character.as_rune

    static member parse: Parser<Reserved_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Subcomponent_Delimiter_Character.parse
                      |>> FromSubcomponentDelimiterCharacter
                      General_Component_Delimiter_Character.parse
                      |>> FromGeneralComponentDelimiterCharacter


                       ])

            """ reserved      = gen-delims / sub-delims """




type Percent_Encoded_Character =
    {

      left_digit: ABNF.HEXDIGIT
      right_digit: ABNF.HEXDIGIT
      as_literal: string
      as_rune: Rune

     }

    static member parse: Parser<Percent_Encoded_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                do! skip_rune '%'
                let! leftHexDigit = ABNF.HEXDIGIT.parse
                let! rightHexDigit = ABNF.HEXDIGIT.parse

                return (leftHexDigit, rightHexDigit)

             }
             |>> fun (leftHexDigit, rightHexDigit) ->
                     let encodedLiteral = $"%%{leftHexDigit.as_rune}{rightHexDigit.as_rune}"
                     let rune = Rune(char (HttpUtility.UrlDecode encodedLiteral))

                     {

                       left_digit = leftHexDigit
                       right_digit = rightHexDigit
                       as_rune = rune
                       as_literal = encodedLiteral

                     }

            )

            """pct-encoded   = "%" HEXDIG HEXDIG"""

[<RequireQualifiedAccess>]
type Registered_Name_Character =
    | FromUnreservedCharacter of Unreserved_Character
    | FromPercentEncodedCharacter of Percent_Encoded_Character
    | FromSubcomponentDelimiterCharacter of Subcomponent_Delimiter_Character

    member this.as_rune =
        match this with
        | FromUnreservedCharacter unreserved_character -> unreserved_character.as_rune
        | FromPercentEncodedCharacter percent_encoded_character -> percent_encoded_character.as_rune
        | FromSubcomponentDelimiterCharacter subcomponent_delimiter_character ->
            subcomponent_delimiter_character.as_rune

    static member parse: Parser<Registered_Name_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Unreserved_Character.parse
                      |>> FromUnreservedCharacter
                      Percent_Encoded_Character.parse
                      |>> FromPercentEncodedCharacter
                      Subcomponent_Delimiter_Character.parse
                      |>> FromSubcomponentDelimiterCharacter

                       ])
            """  unreserved / pct-encoded / sub-delims  """

[<RequireQualifiedAccess>]
type NonColon_Path_Character =
    | FromRegisteredNameCharacter of Registered_Name_Character
    | FromCommercialAt of Commercial_At

    member this.as_rune =
        match this with
        | FromRegisteredNameCharacter registered_name_character -> registered_name_character.as_rune
        | FromCommercialAt ampersand -> ampersand.as_rune

    static member parse: Parser<NonColon_Path_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Registered_Name_Character.parse
                      |>> FromRegisteredNameCharacter
                      Commercial_At.parse |>> FromCommercialAt

                       ])
            """  unreserved / pct-encoded / sub-delims / "@"  """

[<RequireQualifiedAccess>]
type Path_Character =
    | FromNonColonPathCharacter of NonColon_Path_Character
    | FromColon of Colon

    member this.as_rune =
        match this with
        | FromNonColonPathCharacter noncolon_path_character -> noncolon_path_character.as_rune
        | FromColon colon -> colon.as_rune

    static member parse: Parser<Path_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      NonColon_Path_Character.parse
                      |>> FromNonColonPathCharacter
                      Colon.parse |>> FromColon

                       ])
            """ pchar         = unreserved / pct-encoded / sub-delims / ":" / "@" """

[<RequireQualifiedAccess>]
type QueryOrFragment_Character =
    | FromPathCharacter of Path_Character
    | FromSolidus of Solidus
    | FromQuestionMark of Question_Mark

    member this.as_rune =
        match this with
        | FromPathCharacter path_character -> path_character.as_rune
        | FromSolidus solidus -> solidus.as_rune
        | FromQuestionMark question_mark -> question_mark.as_rune

    static member parse: Parser<QueryOrFragment_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Path_Character.parse |>> FromPathCharacter
                      Solidus.parse |>> FromSolidus
                      Question_Mark.parse |>> FromQuestionMark

                       ])
            """  pchar / "/" / "?"  """

type NonColon_NonEmpty_Segment =
    {

      as_characters: ImmutableArray<NonColon_Path_Character>

     }

    member this.as_string = string_from_characters this.as_characters

    static member parse: Parser<NonColon_NonEmpty_Segment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many1 NonColon_Path_Character.parse
             |>> fun characters ->
                     {

                       as_characters = characters

                     })
            """ segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":" """

type NonEmpty_Segment =
    { nonempty_segment: ImmutableArray<Path_Character> }
    member this.as_string = string_from_characters this.nonempty_segment
    member this.as_characters = this.nonempty_segment

    static member parse: Parser<NonEmpty_Segment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many1 Path_Character.parse
             |>> fun characters -> { nonempty_segment = characters })
            """ segment-nz    = 1*pchar """

type Empty_Segment =
    | Empty_Segment of unit
    static member as_characters: ImmutableArray<Path_Character> = ImmutableArray.Empty
    static member as_string = String.Empty

// TODO character dependent delimiters like . for "subsegments"?
type Segment =
    { segment: ImmutableArray<Path_Character> }

    member this.as_characters = this.segment
    member this.as_string = string_from_characters this.segment
    static member Empty = Empty_Segment()

    static member parse: Parser<Segment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many Path_Character.parse
             |>> fun characters -> { segment = characters })
            """ segment       = *pchar """


type Empty_Path =
    | Empty_Path of unit
    static member as_string = String.Empty
    static member head = Segment.Empty
    static member tail: ImmutableArray<Segment> = ImmutableArray.Empty
    static member tail_string = String.Empty


type Rootless_Path =
    {

      head: NonEmpty_Segment
      tail: ImmutableArray<Segment>

     }

    member this.tail_string_segments =
        this.tail
        |> Seq.map (fun segment -> segment.as_string)

    member this.tail_string = string_from_segments this.tail
    member this.as_string = $"{this.head.as_string}{this.tail_string}"

    static member parse: Parser<Rootless_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (NonEmpty_Segment.parse
             .>>. many (Solidus.parse >>. Segment.parse)
             |>> fun struct (head, tail) -> { head = head; tail = tail })
            """ path-rootless = segment-nz *( "/" segment ) """



type NoScheme_Path =
    {

      head: NonColon_NonEmpty_Segment
      tail: ImmutableArray<Segment>

     }


    member this.tail_string_segments =
        this.tail
        |> Seq.map (fun segment -> segment.as_string)

    member this.tail_string = string_from_segments this.tail
    member this.as_string = $"{this.head.as_string}{this.tail_string}"

    static member parse: Parser<NoScheme_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (NonColon_NonEmpty_Segment.parse
             .>>. many (Solidus.parse >>. Segment.parse)
             |>> fun struct (head, tail) -> { head = head; tail = tail })
            """ path-noscheme = segment-nz-nc *( "/" segment ) """

type Absolute_Path =
    {

      head: Segment
      tail: ImmutableArray<Segment>

     }


    member this.tail_string_segments =
        this.tail
        |> Seq.map (fun segment -> segment.as_string)

    member this.tail_string = string_from_segments this.tail
    member this.as_string = $"/{this.head.as_string}{this.tail_string}"

    static member parse: Parser<Absolute_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Solidus.parse >>. opt (Rootless_Path.parse)

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

            """ path-absolute = "/" [ segment-nz *( "/" segment ) ] """

type Abempty_Path =
    {

      segments: ImmutableArray<Segment>

     }

    // member this.as_string = "/" + string_from_segments this.segments
    member this.as_string = string_from_segments this.segments


    static member parse: Parser<Abempty_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many (Solidus.parse >>. Segment.parse)

             |>> fun segments -> { segments = segments }

            )

            """ path-abempty  = *( "/" segment ) """

[<RequireQualifiedAccess>]
type URI_Path =
    | FromAbemptyPath of Abempty_Path
    | FromAbsolutePath of Absolute_Path
    | FromNoSchemePath of NoScheme_Path
    | FromRootlessPath of Rootless_Path
    | FromEmptyPath of Empty_Path


    member this.as_string =
        match this with
        | FromRootlessPath rootless_path -> rootless_path.as_string
        | FromNoSchemePath noscheme_path -> noscheme_path.as_string
        | FromAbsolutePath absolute_path -> absolute_path.as_string
        | FromAbemptyPath abempty_path -> abempty_path.as_string
        | FromEmptyPath _ -> String.Empty

    static member Empty = Empty_Path()

    static member parse: Parser<URI_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (opt (
                choice [

                         Absolute_Path.parse |>> FromAbsolutePath
                         Rootless_Path.parse |>> FromRootlessPath
                         NoScheme_Path.parse |>> FromNoSchemePath
                         Abempty_Path.parse |>> FromAbemptyPath

                          ]
             )
             |>> fun hierarchical_path_option -> defaultValueArg hierarchical_path_option (FromEmptyPath(Empty_Path())))

            """
path          = path-abempty    ; begins with "/" or is empty
             / path-absolute   ; begins with "/" but not "//"
             / path-noscheme   ; begins with a non-colon segment
             / path-rootless   ; begins with a segment
             / path-empty      ; zero characters
            """


type Registered_Name =
    { registered_name: ImmutableArray<Registered_Name_Character> }

    member this.as_characters = this.registered_name
    member this.as_string = string_from_characters this.registered_name

    static member parse: Parser<Registered_Name, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (many Registered_Name_Character.parse
             |>> fun characters -> { registered_name = characters })
            """ reg-name      = *( unreserved / pct-encoded / sub-delims ) """

type Decimal_Octet =
    {

      as_int: int

     }
    static member from_int(int_: int) = { as_int = int_ }



    static member parse'0_9: Parser<Decimal_Octet, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (anyRune "0123456789"
             .>> notFollowedBy (anyRune "0123456789")
             |>> fun singleDigit -> { as_int = int_from_singleDigit singleDigit })
            """     DIGIT                 ; 0-9 """

    static member parse'10_99: Parser<Decimal_Octet, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_rune '1'
                let! rightDigit = anyRune "0123456789"
                return (leftDigit, rightDigit)

             }
             |>> fun (leftDigit, rightDigit) -> { as_int = int_from_doubleDigit leftDigit rightDigit })
            """    %x31-39 DIGIT         ; 10-99 """

    static member parse'100_199: Parser<Decimal_Octet, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_rune '1'
                let! centerDigit = anyRune "0123456789"
                let! rightDigit = anyRune "0123456789"
                return (leftDigit, centerDigit, rightDigit)

             }
             |>> fun (leftDigit, centerDigit, rightDigit) ->
                     { as_int = int_from_tripleDigit leftDigit centerDigit rightDigit })
            """    "1" 2DIGIT            ; 100-199 """

    static member parse'200_249: Parser<Decimal_Octet, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_rune '2'
                let! centerDigit = anyRune "01234"
                let! rightDigit = anyRune "0123456789"
                return (leftDigit, centerDigit, rightDigit)

             }
             |>> fun (leftDigit, centerDigit, rightDigit) ->
                     { as_int = int_from_tripleDigit leftDigit centerDigit rightDigit })
            """    "2" %x30-34 DIGIT     ; 200-249 """

    static member parse'250_255: Parser<Decimal_Octet, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! leftDigit = parse_rune '2'
                let! centerDigit = parse_rune '5'
                let! rightDigit = anyRune "012345"
                return (leftDigit, centerDigit, rightDigit)

             }
             |>> fun (leftDigit, centerDigit, rightDigit) ->
                     { as_int = int_from_tripleDigit leftDigit centerDigit rightDigit })
            """    "2" %x30-34 DIGIT     ; 200-249 """

    static member parse: Parser<Decimal_Octet, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Decimal_Octet.parse'250_255
                      Decimal_Octet.parse'200_249
                      Decimal_Octet.parse'100_199
                      Decimal_Octet.parse'10_99
                      Decimal_Octet.parse'0_9

                       ])
            """
    dec-octet     = DIGIT                 ; 0-9
                 / %x31-39 DIGIT         ; 10-99
                 / "1" 2DIGIT            ; 100-199
                 / "2" %x30-34 DIGIT     ; 200-249
                 / "25" %x30-35          ; 250-255
    """

type IPv4address =
    { outer_left_octet: Decimal_Octet
      inner_left_octet: Decimal_Octet
      inner_right_octet: Decimal_Octet
      outer_right_octet: Decimal_Octet

     }

    member this.as_string =
        $"{this.outer_left_octet.as_int}.{this.inner_left_octet.as_int}.{this.inner_right_octet.as_int}.{this.outer_right_octet.as_int}"

    static member parse: Parser<IPv4address, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! outer_left = Decimal_Octet.parse
                do! skip_rune '.'
                let! inner_left = Decimal_Octet.parse
                do! skip_rune '.'
                let! inner_right = Decimal_Octet.parse
                do! skip_rune '.'
                let! outer_right = Decimal_Octet.parse
                return (outer_left, inner_left, inner_right, outer_right)


             }
             |>> fun (outer_left, inner_left, inner_right, outer_right) ->
                     { outer_left_octet = outer_left
                       inner_left_octet = inner_left
                       inner_right_octet = inner_right
                       outer_right_octet = outer_right }


            )
            """ /// IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet """

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
type Port =
    { as_int: int
      as_characters: ImmutableArray<ABNF.DIGIT> }
    static member parse: Parser<Port, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (skip_rune ':' >>. (many1 (ABNF.DIGIT.parse))
             |>> fun digits ->
                     let stringNumeral = string_from_characters digits

                     {

                       as_int = int_from_stringNumeral stringNumeral
                       as_characters = digits

                     }

            )
            """ port          = *DIGIT """

[<RequireQualifiedAccess>]
type Host =
    | FromIPv4address of IPv4address
    | FromRegisteredName of Registered_Name

    member this.as_string =
        match this with
        | FromIPv4address ipv4address -> ipv4address.as_string
        | FromRegisteredName registered_name -> registered_name.as_string

    static member parse: Parser<Host, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      IPv4address.parse |>> FromIPv4address
                      Registered_Name.parse |>> FromRegisteredName


                       ])
            """ host          =  IPv4address / reg-name """

[<RequireQualifiedAccess>]
type Userinfo_Character =
    | FromRegisteredNameCharacter of Registered_Name_Character
    | FromColon of Colon

    member this.as_rune =
        match this with
        | FromRegisteredNameCharacter registered_name_character -> registered_name_character.as_rune
        | FromColon colon -> colon.as_rune

    static member parse: Parser<Userinfo_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      Registered_Name_Character.parse
                      |>> FromRegisteredNameCharacter
                      Colon.parse |>> FromColon

                       ])
            """  unreserved / pct-encoded / sub-delims / ":"  """

type Userinfo =
    {

      userinfo: ImmutableArray<Userinfo_Character>

     }
    member this.as_string = string_from_characters this.userinfo
    member this.as_characters = this.userinfo

    static member parse: Parser<Userinfo, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (

            many Userinfo_Character.parse
            .>> Commercial_At.parse
            |>> fun characters -> { userinfo = characters }

            )
            """ userinfo      = *( unreserved / pct-encoded / sub-delims / ":" ) """


type Authority =
    { userinfo: Userinfo ValueOption
      host: Host
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

    static member parse: Parser<Authority, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {
                let! userinfo = opt Userinfo.parse
                let! host = Host.parse
                let! port = opt Port.parse
                return (userinfo, host, port)
             }
             |>> fun (userinfo_option, host, port_option) ->

                     {

                       userinfo = userinfo_option
                       host = host
                       port = port_option

                     })
            """  authority     = [ userinfo "@" ] host [ ":" port ] """

type Scheme_Character =
    | FromALPHA of ABNF.ALPHA
    | FromDIGIT of ABNF.DIGIT
    | FromPlusSign of Plus_Sign
    | FromHyphenMinus of Hyphen_Minus
    | FromFullStop of Full_Stop

    member this.as_rune =
        match this with
        | FromALPHA alpha -> alpha.as_rune
        | FromDIGIT digit -> digit.as_rune
        | FromPlusSign plus_sign -> plus_sign.as_rune
        | FromHyphenMinus hyphen_minus -> hyphen_minus.as_rune
        | FromFullStop full_stop -> full_stop.as_rune

    static member parse: Parser<Scheme_Character, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      ABNF.ALPHA.parse |>> FromALPHA
                      ABNF.DIGIT.parse |>> FromDIGIT
                      Plus_Sign.parse |>> FromPlusSign
                      Hyphen_Minus.parse |>> FromHyphenMinus
                      Full_Stop.parse |>> FromFullStop

                       ])
            """  ALPHA / DIGIT / "+" / "-" / "."  """


// TODO scheme dependent segment delimiters like colon in urn?
type Scheme =
    { head: ABNF.ALPHA
      tail: ImmutableArray<Scheme_Character> }

    member this.as_characters =
        Seq.append (seq { Scheme_Character.FromALPHA this.head }) this.tail

    member this.as_string = string_from_characters this.as_characters

    static member parse: Parser<Scheme, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (ABNF.ALPHA.parse .>>. many Scheme_Character.parse
             |>> fun struct (head, tail) ->

                     { head = head; tail = tail }

            )
            """ scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." ) """




type Authority_Path =
    {

      head: Authority
      tail: Abempty_Path

     }


    member this.as_string = $"//{this.head.as_string}{this.tail.as_string}"

    member this.tail_string_segments =
        this.tail.segments
        |> Seq.map (fun segment -> segment.as_string)


    static member parse: Parser<Authority_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {
                let! _ = Solidus.parse
                let! _ = Solidus.parse
                let! head = Authority.parse
                let! tail = Abempty_Path.parse
                return (head, tail)
             }

             |>> fun (head, tail) ->

                     {

                       head = head
                       tail = tail

                     }

            )

            """ path-absolute = "/" [ segment-nz *( "/" segment ) ] """


[<RequireQualifiedAccess>]
type Relative_Path =
    | FromAuthorityPath of Authority_Path
    | FromAbsolutePath of Absolute_Path
    | FromNoSchemePath of NoScheme_Path
    | FromEmptyPath of Empty_Path

    member this.as_string =
        match this with
        | FromAuthorityPath authority_path -> authority_path.as_string
        | FromNoSchemePath noscheme_path -> noscheme_path.as_string
        | FromAbsolutePath absolute_path -> absolute_path.as_string
        | FromEmptyPath empty_path -> String.Empty


    static member parse: Parser<Relative_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (opt (
                choice [

                         Authority_Path.parse |>> FromAuthorityPath
                         Absolute_Path.parse |>> FromAbsolutePath
                         NoScheme_Path.parse |>> FromNoSchemePath


                          ]
             )
             |>> fun hierarchical_path_option -> defaultValueArg hierarchical_path_option (FromEmptyPath(Empty_Path())))
            """
relative-part = "//" authority path-abempty
             / path-absolute
             / path-noscheme
             / path-empty
            """
// TODO handle key value paired query strings
type Query =
    { query_: ImmutableArray<QueryOrFragment_Character> }
    member this.as_characters = this.query_
    member this.as_string = string_from_characters this.query_

    static member string_from_option(query_option: Query ValueOption) =
        match query_option with
        | ValueSome query -> $"?{query.as_string}"
        | _ -> String.Empty


    static member parse: Parser<Query, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Question_Mark.parse
             >>. many QueryOrFragment_Character.parse
             |>> fun characters -> { query_ = characters })
            """query         = *( pchar / "/" / "?" ) """

type Fragment =
    { fragment: ImmutableArray<QueryOrFragment_Character> }
    member this.as_characters = this.fragment
    member this.as_string = string_from_characters this.fragment

    static member string_from_option(fragment_option: Fragment ValueOption) =
        match fragment_option with
        | ValueSome fragment -> $"#{fragment.as_string}"
        | _ -> String.Empty

    static member parse: Parser<Fragment, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (Number_Sign.parse
             >>. many QueryOrFragment_Character.parse
             |>> fun characters -> { fragment = characters })
            """ fragment      = *( pchar / "/" / "?" ) """

type Relative_Reference =
    {

      relative_path: Relative_Path
      query: Query ValueOption
      fragment: Fragment ValueOption

     }
    member this.as_string =
        $"{this.relative_path.as_string}{Query.string_from_option this.query}{Fragment.string_from_option this.fragment}"

    static member parse: Parser<Relative_Reference, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! relative_path = Relative_Path.parse
                let! query = opt Query.parse
                let! fragment = opt Fragment.parse
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
type Hierarchical_Path =
    | FromAuthorityPath of Authority_Path
    | FromAbsolutePath of Absolute_Path
    | FromRootlessPath of Rootless_Path
    | FromEmptyPath of Empty_Path

    member this.as_string =
        match this with
        | FromAuthorityPath authority_path -> authority_path.as_string
        | FromAbsolutePath absolute_path -> absolute_path.as_string
        | FromRootlessPath rootless_path -> rootless_path.as_string
        | FromEmptyPath _ -> String.Empty


    static member parse: Parser<Hierarchical_Path, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (opt (
                choice [

                         Authority_Path.parse |>> FromAuthorityPath
                         Absolute_Path.parse |>> FromAbsolutePath
                         Rootless_Path.parse |>> FromRootlessPath


                          ]
             )
             |>> fun hierarchical_path_option -> defaultValueArg hierarchical_path_option (FromEmptyPath(Empty_Path())))
            """
hier-part     = "//" authority path-abempty
             / path-absolute
             / path-rootless
             / path-empty
            """

type Absolute_URI =
    {

      scheme: Scheme
      hierarchical_path: Hierarchical_Path
      query: Query ValueOption

     }
    member this.as_string =
        $"{this.scheme.as_string}:{this.hierarchical_path.as_string}{Query.string_from_option this.query}"

    static member parse: Parser<Absolute_URI, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! scheme = Scheme.parse
                do! skip_rune ':'
                let! hierarchical_path = Hierarchical_Path.parse
                let! query = opt Query.parse
                return (scheme, hierarchical_path, query)

             }
             |>> fun (scheme, hierarchical_path, query) ->

                     {

                       scheme = scheme
                       hierarchical_path = hierarchical_path
                       query = query

                     }


            )
            """ absolute-URI  = scheme ":" hier-part [ "?" query ] """

type URI =
    {

      scheme: Scheme
      hierarchical_path: Hierarchical_Path
      query: Query ValueOption
      fragment: Fragment ValueOption

     }
    member this.as_string =
        $"{this.scheme.as_string}:{this.hierarchical_path.as_string}{Query.string_from_option this.query}{Fragment.string_from_option this.fragment}"

    member this.absolute_uri: Absolute_URI =
        {

          scheme = this.scheme
          hierarchical_path = this.hierarchical_path
          query = this.query }

    static member parse: Parser<URI, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (parser {

                let! absolute_uri = Absolute_URI.parse
                let! fragment = opt Fragment.parse
                return (absolute_uri, fragment)

             }
             |>> fun (absolute_uri, fragment) ->

                     {

                       scheme = absolute_uri.scheme
                       hierarchical_path = absolute_uri.hierarchical_path
                       query = absolute_uri.query
                       fragment = fragment

                     }


            )
            """ URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ] """

[<RequireQualifiedAccess>]
type URI_Reference =
    | FromURI of URI
    | FromRelativeReference of Relative_Reference
    member this.path =
        match this with
        | FromURI uri ->
            match uri.hierarchical_path with
            | Hierarchical_Path.FromAuthorityPath authority_path -> URI_Path.FromAbemptyPath authority_path.tail
            | Hierarchical_Path.FromAbsolutePath absolute_path -> URI_Path.FromAbsolutePath absolute_path
            | Hierarchical_Path.FromRootlessPath rootless_path -> URI_Path.FromRootlessPath rootless_path
            | Hierarchical_Path.FromEmptyPath empty_path -> URI_Path.FromEmptyPath empty_path

        | FromRelativeReference relative_reference ->
            match relative_reference.relative_path with
            | Relative_Path.FromAuthorityPath authority_path -> URI_Path.FromAbemptyPath authority_path.tail
            | Relative_Path.FromAbsolutePath absolute_path -> URI_Path.FromAbsolutePath absolute_path
            | Relative_Path.FromNoSchemePath noscheme_path -> URI_Path.FromNoSchemePath noscheme_path
            | Relative_Path.FromEmptyPath empty_path -> URI_Path.FromEmptyPath empty_path


    member this.query =
        match this with
        | FromURI uri -> uri.query
        | FromRelativeReference relative_reference -> relative_reference.query

    member this.fragment =
        match this with
        | FromURI uri -> uri.fragment
        | FromRelativeReference relative_reference -> relative_reference.fragment

    member this.as_string =
        match this with
        | FromURI uri -> uri.as_string
        | FromRelativeReference relative_reference -> relative_reference.as_string

    static member parse: Parser<URI_Reference, Rune, unit, ReadableArray<Rune>, ReadableArraySlice<Rune>> =
        parse_expecting
            (choice [

                      URI.parse |>> FromURI
                      Relative_Reference.parse |>> FromRelativeReference

                       ])
            """  URI-reference = URI / relative-ref """
