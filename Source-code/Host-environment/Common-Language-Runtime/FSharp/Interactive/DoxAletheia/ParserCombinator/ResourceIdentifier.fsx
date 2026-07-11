#time on

open System
open System.IO
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics


#r "nuget: XParsec"
open XParsec
open XParsec.Combinators

#r "nuget: NeatIntervals"
#r "nuget: FRange"




#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\ParserCombinator\bin\Release\net10.0"
#r "Ergonomic_Extensions.dll"
#r "ParserCombinator.dll"
#r "Unicodepoint.dll"
#r "Interval_Range.dll"
open DoxAletheia

// TODO next adjust to renamed code point/line/square functions


open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions
open XParsecExtensions.Code_Parsers
open ArrayExtensions
open ByteExtensions
open XParsec.Parsers
open Interval_Range


let current_directory_file_path (file_name:string) = Path.Combine(__SOURCE_DIRECTORY__,file_name)







type String with 
    member this.as_int_option = 
        match Int32.TryParse this with 
        | true, integer -> Some integer
        | false, _  -> None








let happy_sad_result  happy_path sad_path parse_result = 

    match parse_result with 
    | Ok success-> happy_path success
    | Error failure -> sad_path failure










    







module Terminal = 

    let sub_delims = 
    
            {

                code_points = Code_Line.from_chars_sorted
                
                    [| '!'
                       '$'
                       '&'
                       '''
                       '('
                       ')'
                       '*'
                       '+'
                       ','
                       ';'
                       '=' |]  
                 
                metasyntax = 
            
                                  """
                                  sub-delims    = "!" / "$" / "&" / "'" / "(" / ")" / "*" / "+" / "," / ";" / "="
                                  """ 

            }
    

    let gen_delims = 

            {

                code_points = Code_Line.from_chars_sorted
                
                    [|

                             ':'
                             '/'
                             '?'
                             '#'
                             '['
                             ']'
                             '@'


                    |]  

                metasyntax = 
            
                                  """
                                  gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
                                  """ 

            }


    let reserved = 
            {

                code_points = 
                
                    Array.concat [|

                        gen_delims.code_points
                        sub_delims.code_points

                    |]  |> Array.sort

                metasyntax = 
            
                                  """
                                  reserved      = gen-delims / sub-delims
                                  """ 

            }




    let unreserved = 
            {

                code_points = 
                
                    Array.concat [|

                        Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.as_array
                        Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.as_array
                        (Code_Line.from_chars [| '-' ; '.' ; '_' ; '~'|])

                    |]
                    |> Array.sort

                metasyntax = 
            
                                  """
                                  unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
                                  """ 

            }
    let reg_name = 
            {

                code_points = 
                
                    Array.concat [|

                        unreserved.code_points
                        sub_delims.code_points

                    |]
                    |> Array.sort

                metasyntax = 
            
                                  """
                                   unreserved / pct-encoded / sub-delims 
                                  """ 

            }
    /// unencoded, as per
    /// https://www.w3.org/TR/rdf12-concepts/#section-IRIs
    let pchar_unencoded_noncolon =
            {

                code_points = 
                
                    Array.concat [|

                        reg_name.code_points
                        (Code_Line.from_chars [| '@'|])

                    |]
                    |> Array.sort

                metasyntax = 
            
                                  """
                                  ( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                                  """ 

            }
    let pchar_unencoded =
            {

                code_points = 
                
                    Array.concat [|

                        pchar_unencoded_noncolon.code_points
                        (Code_Line.from_chars [| ':' |])

                    |]
                    |> Array.sort

                metasyntax = 
            
                                  """
                                  pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                                  """ 

            }
    let userinfo = 
    
            {

                code_points = 
                
                    Array.concat [|

                        unreserved.code_points
                        sub_delims.code_points
                        [|int ':'|]

                    |]
                    |> Array.sort

                metasyntax = 
            
                                  """
                                    unreserved / pct-encoded / sub-delims / ":"  
                                  """ 

            }
    // TODO consider how to deal with case sensitivity
    let hexdigit =
            {

                code_points = 
                
                    Array.concat [|

                        Unicodepoint.Partition.Ascii_Digits |> Interval_Range.as_array
                        Unicodepoint.Partition.A_to_F |>  Interval_Range.as_array

                    |]
                    |> Array.sort

                metasyntax = 
            
                                  """
                                  HEXDIG = DIGIT / "A" / "B" / "C" / "D" / "E" / "F"
                                  """ 

            }

module Nonterminal = 

    let query_fragment = 
        {

            code_line_parser = 
                parser {

                    let! immutable_array = 

                            many (choice [

                                Terminal.pchar_unencoded.code_point_parser
                                parse_char '/'
                                parse_char '?'
            


                            ] )
                    return immutable_array.AsMemory().ToArray()


                }
        
            metasyntax = 
            
                                  """
                                  fragment      = *( pchar / "/" / "?" )
                                  """ 

        }



type Code_Point_Parser = Parser<Code_Point, Code_Point, unit, ReadableMemory<Code_Point>>
type Code_Line_Parser = Parser<Code_Line, Code_Point, unit, ReadableMemory<Code_Point>>
type Code_Square_Parser = Parser<Code_Square, Code_Point, unit, ReadableMemory<Code_Point>>
type Code_Cube_Parser = Parser<Code_Cube, Code_Point, unit, ReadableMemory<Code_Point>>

type Scheme =
     private
     | Scheme of Code_Line
     static member parser :Parser<Scheme, Code_Point, unit, ReadableMemory<Code_Point>>= 
     
                parser {

                    let! scheme_head = 
                        choice [
                        
                            Unicodepoint.Partition.Latin_Majuscule |> any_point_from_interval
                            Unicodepoint.Partition.Latin_Minuscule |> any_point_from_interval

                        ]
                    let! scheme_tail = 

                            many (choice [

                        
                                Unicodepoint.Partition.Latin_Majuscule |> any_point_from_interval 
                                Unicodepoint.Partition.Latin_Minuscule |> any_point_from_interval 
                                Unicodepoint.Partition.Ascii_Digits |> any_point_from_interval 
                                parse_char '+'
                                parse_char '-'
                                parse_char '.'
            


                            ] )
                    return scheme_tail.AsMemory().ToArray() |> Array.insertAt 0 scheme_head |> Scheme


                }
     static member metasyntax =
                                  """
                                  scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
                                  """ 
     static member parse (input_string:string) =  
        match Scheme.parser input_string.as_parser_input with 
        | Ok success -> success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Scheme.metasyntax}"
     member this.as_code_line = 
        let (Scheme code_line) = this
        code_line
     member this.as_raw_string = this.as_code_line |> String.from_code_line
     member this.as_rendered_string = sprintf "%s://" this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string



type Fragment =
     private
     | Fragment of Code_Line
     static member parser :Parser<Fragment, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {  

                    do! skip_char '#'
                    return! Nonterminal.query_fragment.code_line_parser |>> Fragment

                }
     static member metasyntax = 
                                  """
                                  fragment      = *( pchar / "/" / "?" )
                                  """ 
     static member parse (input_string:string) =  
        match Fragment.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Fragment.metasyntax}"
     member this.as_code_line = 
        let (Fragment code_line) = this
        code_line
     member this.as_raw_string = this.as_code_line |> String.from_code_line
     member this.as_rendered_string = sprintf ":%s" this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string


type Query =
     private
     | Query of Code_Line
     static member parser :Parser<Query, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    do! skip_char '?'
                    return! Nonterminal.query_fragment.code_line_parser |>> Query

                }
     static member metasyntax = 
                                  """
                                  query         = *( pchar / "/" / "?" )
                                  """ 
     static member parse (input_string:string) =  
        match Query.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Query.metasyntax}"
     member this.as_code_line = 
        let (Query code_line) = this
        code_line
     member this.as_raw_string = this.as_code_line |> String.from_code_line
     member this.as_rendered_string = sprintf "?%s" this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string

type Port =
     private
     | Port of Code_Line
     static member parser :Parser<Port, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {  

                    do! skip_char ':'
                    let! digits = many (any_point_from_interval Unicodepoint.Partition.Ascii_Digits) |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)
                    return Port digits

                }
     static member metasyntax = 
                                  """
                                  ":" port
                                  port          = *DIGIT
                                  """ 
     static member parse (input_string:string) =  
        match Port.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Port.metasyntax}"
     member this.as_code_line = 
        let (Port code_line) = this
        code_line
     member this.as_raw_string = (this.as_code_line |> String.from_code_line)
     member this.as_rendered_string = sprintf ":%s" this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string
type Userinfo =
     private
     | Userinfo of Code_Line
     static member parser :Parser<Userinfo, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {  

                    let! userinfo = many Terminal.userinfo.code_point_parser |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)
                    do! skip_char '@'
                    return Userinfo userinfo

                }
     static member metasyntax = 
                                  """
                                  userinfo "@"
                                  userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
                                  """ 
     static member parse (input_string:string) =  
        match Userinfo.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Userinfo.metasyntax}"
     member this.as_code_line = 
        let (Userinfo code_line) = this
        code_line
     member this.as_raw_string = (this.as_code_line |> String.from_code_line)
     member this.as_rendered_string = sprintf "%s@" this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string


type Segment = 
    private
    | Segment of Code_Line
    | FromNonzeroSegment of Code_Line
    | FromNonzeroNoncolonSegment of Code_Line
    static member parser: Parser<Segment, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! immutable_code_line = many Terminal.pchar_unencoded.code_point_parser
                    return immutable_code_line.AsSpan().ToArray() |> Segment

                }
    static member metasyntax = 
                """
                segment       = *pchar
                """

    static member parse (input_string:string) =  
        match Segment.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Segment.metasyntax}"

    member this.as_code_line = 
        match this with 
        | Segment  code_line -> code_line
        | FromNonzeroSegment  code_line -> code_line
    static member code_line(segment : Segment) = segment.as_code_line
    member this.as_raw_string = this.as_code_line |> String.from_code_line
    static member raw_string(segment : Segment) = segment.as_raw_string
    member this.as_rendered_string = this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string

type Nonzero_Segment = 
    private
    | NonzeroSegment of Code_Line

    static member parser:Parser<Nonzero_Segment, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! immutable_code_line = many1 Terminal.pchar_unencoded.code_point_parser
                    return immutable_code_line.AsSpan().ToArray() |> NonzeroSegment

                }
    static member metasyntax = 
                """
                segment-nz    = 1*pchar
                """

    static member parse (input_string:string) =  
        match Nonzero_Segment.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Nonzero_Segment.metasyntax}"

    member this.as_code_line = 
        match this with 
        | NonzeroSegment  code_line -> code_line
    member this.as_raw_string = this.as_code_line |> String.from_code_line
    member this.as_rendered_string = this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string

type Nonzero_Noncolon_Segment = 
    private
    | NonzeroNoncolonSegment of Code_Line
    static member parser:Parser<Nonzero_Noncolon_Segment, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! immutable_code_line = many1 Terminal.pchar_unencoded_noncolon.code_point_parser
                    return immutable_code_line.AsSpan().ToArray() |> NonzeroNoncolonSegment

                }
    static member metasyntax = 
                """
                segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
                """

    static member parse_nz_nc (input_string:string) =  
        match Segment.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Nonzero_Noncolon_Segment.metasyntax}"
    member this.as_code_line = 
        match this with 
        | NonzeroNoncolonSegment  code_line -> code_line
    member this.as_raw_string = this.as_code_line |> String.from_code_line
    member this.as_rendered_string = this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string

type Path_Abempty = 
    private
    | PathAbempty of Segment array
    static member parser:Parser<Path_Abempty, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! immutable_array = many (skip_char '/' >>. Segment.parser)
                    return immutable_array.AsSpan().ToArray() |> PathAbempty

                }
    static member metasyntax = 
                """
                path-abempty  = *( "/" segment )
                """

    static member parse (input_string:string) =  
        match Path_Abempty.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Path_Abempty.metasyntax}"
        
    member this.as_raw_segments = 
        match this with 
        | PathAbempty  segments -> segments
    member this.as_code_square = 
        match this with 
        | PathAbempty segments -> segments |> Array.map (fun segment -> segment.as_code_line)
    member this.as_string_segments = this.as_raw_segments |> Array.map Segment.raw_string
    member this.as_rendered_string = this.as_string_segments |> String.concat "/"
     member this.fsi_printer = 
        let unames = this.as_raw_segments |> Array.map Segment.code_line |> Code_Square.Unames 
        sprintf "%A %A ``%A``" this unames  this.as_string_segments

type Path_Rootless = 
    private
    | PathRootless of Nonzero_Segment * Path_Abempty
        
    static member parser:Parser<Path_Rootless, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! segment_nz = Nonzero_Segment.parser
                    let! abempty = Path_Abempty.parser
                    return PathRootless(segment_nz,abempty)

                }
    static member metasyntax = 
                """
                path-rootless = segment-nz *( "/" segment )
                """

    static member parse (input_string:string) =  
        match Path_Rootless.parser input_string.as_parser_input with 
        | Ok success -> success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Path_Rootless.metasyntax}"

        
    member this.as_raw_segments = 
        match this with 
        | PathRootless(NonzeroSegment( segment_nz),path_abempty) -> path_abempty.as_raw_segments |> Array.insertAt 0 (Segment.FromNonzeroSegment segment_nz)
    member this.as_code_square = 
        match this with 
        | PathRootless(segment_nz,path_abempty) -> path_abempty.as_code_square |> Array.insertAt 0 segment_nz.as_code_line
    member this.as_string_segments = this.as_raw_segments |> Array.map Segment.raw_string
    member this.as_rendered_string = this.as_string_segments |> String.concat "/"
     member this.fsi_printer = 
        let unames = this.as_raw_segments |> Array.map Segment.code_line |> Code_Square.Unames 
        sprintf "%A %A ``%A``" this unames  this.as_string_segments
type Path_Absolute = 
    private
        | AbsoluteRootPath of Path_Rootless
        | AbsoluteRoot


    static member parser:Parser<Path_Absolute, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    do! skip_char '/'
                    let! maybe_path = opt Path_Rootless.parser
                    return
                        match maybe_path with 
                        | ValueSome path -> AbsoluteRootPath path 
                        | ValueNone -> AbsoluteRoot

                }
    static member metasyntax = 
                """
                path-absolute = "/" [ segment-nz *( "/" segment ) ]
                """

    static member parse (input_string:string) =  
        match Path_Absolute.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Path_Absolute.metasyntax}"

    member this.as_code_square = 
        match this with 
        | AbsoluteRootPath path_rootless -> path_rootless.as_code_square
        | AbsoluteRoot -> [||]
    member this.as_raw_segments = 
        match this with 
        | AbsoluteRootPath path_rootless -> path_rootless.as_raw_segments
        | AbsoluteRoot -> [||]
    static member code_line(segment : Segment) = segment.as_code_line
    member this.as_string_segments = this.as_raw_segments |> Array.map Segment.raw_string
    member this.as_rendered_string = this.as_string_segments |> String.concat "/"
     member this.fsi_printer = 
        let unames = this.as_raw_segments |> Array.map Segment.code_line |> Code_Square.Unames 
        sprintf "%A %A ``%A``" this unames  this.as_string_segments

type Path_Noscheme = 
    private
    | PathNoscheme of Nonzero_Noncolon_Segment * Path_Abempty


    static member parser:Parser<Path_Noscheme, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! segment_nz_nc = Nonzero_Noncolon_Segment.parser
                    let! abempty = Path_Abempty.parser
                    return PathNoscheme(segment_nz_nc, abempty )

                }
    static member metasyntax = 
                """
                path-noscheme = segment-nz *( "/" segment )
                """

    static member parse (input_string:string) =  
        match Path_Noscheme.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Path_Noscheme.metasyntax}"
    member this.as_raw_segments = 
        match this with 
        | PathNoscheme(NonzeroNoncolonSegment segment_nz_nc,path_abempty) -> path_abempty.as_raw_segments |> Array.insertAt 0 (Segment.FromNonzeroNoncolonSegment segment_nz_nc)
    member this.as_code_square = 
        match this with 
        | PathNoscheme(segment_nz_nc,path_abempty) -> path_abempty.as_code_square |> Array.insertAt 0 segment_nz_nc.as_code_line
    member this.as_string_segments = this.as_raw_segments |> Array.map Segment.raw_string
    member this.as_rendered_string = this.as_string_segments |> String.concat "/"
     member this.fsi_printer = 
        let unames = this.as_raw_segments |> Array.map Segment.code_line |> Code_Square.Unames 
        sprintf "%A %A ``%A``" this unames  this.as_string_segments

type URI_Path = 
    | From_Abempty of Path_Abempty
    | FromAbsolute of Path_Absolute
    | FromNoscheme of Path_Noscheme
    | FromRootless of Path_Rootless
    | FromEmpty


type Registered_Name = 
     private
     | RegisteredName of Code_Line
     static member parser :Parser<Registered_Name, Code_Point, unit, ReadableMemory<Code_Point>>  = 
                parser {  

                    let! immutable_code_line = many Terminal.reg_name.code_point_parser
                    return immutable_code_line.AsSpan().ToArray() |> RegisteredName

                }
     static member metasyntax = 
                                  """
                                  reg-name      = *( unreserved / pct-encoded / sub-delims )
                                  """ 
     static member parse (input_string:string) =  
        match Registered_Name.parser input_string.as_parser_input with 
        | Ok success ->  success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Registered_Name.metasyntax}"
     member this.as_code_line = 
        let (RegisteredName code_line) = this
        code_line
     member this.as_raw_string = this.as_code_line |> String.from_code_line
     member this.as_rendered_string = this.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string



type Octet = 
    private
    | Octet of Code_Line
    static let interval_0_4 = 0 +-+ 4
    static let interval_0_5 = 0 +-+ 4
    static let interval_1_9 = 1 +-+ 9
    static member parser :Parser<Octet, Code_Point, unit, ReadableMemory<Code_Point>>  = 
                parser {
                    let! digits = 
                        choice [

                            tuple3 (parse_char '2') (parse_char '5')(any_point_from_interval interval_0_5 ) |>> (fun struct (left_digit, center_digit, right_digit) -> [|left_digit ; center_digit ; right_digit|] )
                            tuple3 (parse_char '2') (any_point_from_interval interval_0_4 )(any_point_from_interval Unicodepoint.Partition.Ascii_Digits ) |>> (fun struct (left_digit, center_digit, right_digit) -> [|left_digit ; center_digit ; right_digit|] )
                            tuple3 (parse_char '1') (any_point_from_interval Unicodepoint.Partition.Ascii_Digits )(any_point_from_interval Unicodepoint.Partition.Ascii_Digits )  |>> (fun struct (left_digit, center_digit, right_digit) -> [|left_digit ; center_digit ; right_digit|] )
                            tuple2 (any_point_from_interval interval_1_9) (any_point_from_interval Unicodepoint.Partition.Ascii_Digits )  |>> (fun struct (left_digit,  right_digit) -> [|left_digit ;  right_digit|] )
                            any_point_from_interval Unicodepoint.Partition.Ascii_Digits  |>> (fun digit -> [|digit|] )

                        ]
                    return Octet digits

                }
                
     static member metasyntax = 
                                  """
                                    dec-octet     = DIGIT                 ; 0-9
                                                 / %x31-39 DIGIT         ; 10-99
                                                 / "1" 2DIGIT            ; 100-199
                                                 / "2" %x30-34 DIGIT     ; 200-249
                                                 / "25" %x30-35          ; 250-255

                                  """ 
    static member parse (input_string:string) =  
        match Octet.parser input_string.as_parser_input with 
        | Ok success -> success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Octet.metasyntax}"
    member this.as_code_line = 
        let (Octet code_line) = this
        code_line
    static member code_line(octet : Octet) = octet.as_code_line
    member this.as_raw_string = 
        String.from_code_line this.as_code_line
    member this.as_int = int this.as_raw_string
        
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%d``" this unames  this.as_int

type IPv4_Address = 
    private
    | IPv4 of Octet * Octet * Octet * Octet

     static member parser :Parser<IPv4_Address, Code_Point, unit, ReadableMemory<Code_Point>> = 
                parser {

                    let! outer_left = Octet.parser
                    do! skip_char '.'
                    let! inner_left = Octet.parser
                    do! skip_char '.'
                    let! inner_right = Octet.parser
                    do! skip_char '.'
                    let! outer_right = Octet.parser
                    return IPv4 (outer_left , inner_left , inner_right , outer_right)

                }
     static member metasyntax = 
                                  """
                                    IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
                                  """ 
     static member parse (input_string:string) =  
        match IPv4_Address.parser input_string.as_parser_input with 
        | Ok success -> success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  IPv4_Address.metasyntax}"
     member this.as_raw_octets = 
        match this with 
        | IPv4  (outer_left , inner_left , inner_right , outer_right) -> [|outer_left ; inner_left ; inner_right ; outer_right|]
    member this.as_code_square:Code_Square = this.as_raw_octets  |> Array.map Octet.code_line
    member this.outer_left_octet = this.as_raw_octets[0] 
    member this.inner_left_octet = this.as_raw_octets[1] 
    member this.inner_right_octet = this.as_raw_octets[2] 
    member this.outer_right_octet = this.as_raw_octets[3] 
    member this.as_rendered_string = sprintf "%d.%d.%d.%d" this.outer_left_octet.as_int this.inner_left_octet.as_int this.inner_right_octet.as_int this.outer_right_octet.as_int
     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%s``" this unames  this.as_rendered_string

type Hextet = 
    private
    | Hextet of Code_Line
    static member parser :Parser<Hextet, Code_Point, unit, ReadableMemory<Code_Point>> = 
    
                parser {

                    let! h16 = 

                            choice [

                                 parray 4 (Terminal.hexdigit.code_point_parser)
                                 parray 3 (Terminal.hexdigit.code_point_parser)
                                 parray 2 (Terminal.hexdigit.code_point_parser)
                                 parray 1 (Terminal.hexdigit.code_point_parser) 
                         
                         ]


                    return h16.AsMemory().ToArray() |> Hextet


                }
    static member colon_suffixed_parser :Parser<Hextet, Code_Point, unit, ReadableMemory<Code_Point>> = 
    
                parser {

                    let! h16 = Hextet.parser
                    do! skip_char ':'

                    return h16


                }

    static member metasyntax = 
            
                                  """
                                  h16           = 1*4HEXDIG
                                  """ 

    static member parse (input_string:string) =  
        match Hextet.parser input_string.as_parser_input with 
        | Ok success -> success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Hextet.metasyntax}"

(*
    static member colon_sequence_exactly (count: int) : Code_Square_Parser =
        parser {

            if count = 0 then
                return  [||]
            else
                let! hextet_code_square = parray count Hextet.parser |>> (fun immutable -> immutable.AsSpan().ToArray() |> Array.map (fun hextet -> hextet.as_code_line))
                let! colon =  parse_char ':'
                return  hextet_code_square |> Array.append [|[|colon|]|]
        }
    static member colon_parser : Code_Line_Parser = 
            parser {
                let! colon = parse_char ':'
                let! h16 = Hextet.parser

                return Array.concat [| [|colon|]; h16 |]
            }
        
    static member sequence_exactly (count: int) : Code_Square_Parser =

            if count = 0 then
                parser { return [||] }

            elif count = 1 then
                Hextet.parser |>> (fun hextet -> [|hextet|])

            else
                parser {
                    let! first_h16 = Hextet.parser

                    let! immutable_code_square = parray (count - 1) Hextet.colon_parser
                    let remaining_h16s = Code_Square.from_immutable_code_square immutable_code_square 

                    return remaining_h16s |> Array.insertAt 0 first_h16
                }

    // TODO make this more legible
    static member optional_h16_sequence_up_to (maximum_count: int) : Code_Square_Parser =

            let alternatives =
                [| maximum_count .. -1 .. 1 |]
                |> Array.map Hextet.sequence_exactly

            choice (alternatives |> Array.append [| parser { return [||] } |])
        
*)
     member this.as_code_line = 
        let (Hextet code_line) = this
        code_line
     member this.as_raw_string = this.as_code_line |> String.from_code_line
     static member raw_string(hextet:Hextet) = hextet.as_raw_string
     member this.fsi_printer = 
        let unames = Code_Line.Unames this.as_code_line
        sprintf "%A %A ``%s``" this unames  this.as_raw_string

type Least_Significant_32_Bits = 
    | FromHextetPair of Hextet * Hextet
    | FromIPv4Address of IPv4_Address


    static member parser:Parser<Least_Significant_32_Bits, Code_Point, unit, ReadableMemory<Code_Point>>  = 
    
                parser {

                    let! ls32 = 

                            choice [

                                 Hextet.parser .>> skip_char ':' .>>. Hextet.parser |>> (fun struct (left_hextet,right_hextet) -> FromHextetPair(left_hextet, right_hextet)  )
                                 IPv4_Address.parser |>> FromIPv4Address
                         
                         ]


                    return ls32


                }
    static member metasyntax = 
                                    """
                                    ls32          = ( h16 ":" h16 ) / IPv4address
                                    """
    static member parse (input_string:string) =  
        match Least_Significant_32_Bits.parser input_string.as_parser_input with 
        | Ok success  -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Least_Significant_32_Bits.metasyntax}"
    
     member this.as_code_square = 
        match this with
        | FromHextetPair( Hextet left_hextet, Hextet right_hextet) -> [|left_hextet ; right_hextet|]
        | FromIPv4Address (IPv4 (outer_left, inner_left, inner_right,outer_right)) ->  [|outer_left.as_code_line ; inner_left.as_code_line ; inner_right.as_code_line ;outer_right.as_code_line|]
    member this.as_rendered_string = 
        match this with
        | FromHextetPair( left_h16, right_h16) -> sprintf "%s:%s" left_h16.as_raw_string right_h16.as_raw_string
        | FromIPv4Address ipv4_address ->  ipv4_address.as_rendered_string
        
     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  (Strings.from_code_square this.as_code_square)


type IPv6_Address = 
    private
    | Six_h16__ls32 of Hextet array * Least_Significant_32_Bits
    | Five_h16__ls32 of Hextet array * Least_Significant_32_Bits
    | Maybe_One_h16__Four_h16__ls32 of Hextet voption * Hextet array * Least_Significant_32_Bits
    | Maybe_Two_h16__Three_h16__ls32 of Hextet array voption * Hextet array * Least_Significant_32_Bits
    | Maybe_Three_h16__Two_h16__ls32 of Hextet array voption * Hextet array * Least_Significant_32_Bits
    | Maybe_Four_h16__One_h16__ls32 of Hextet array voption * Hextet * Least_Significant_32_Bits
    | Maybe_Five_h16__ls32 of Hextet array voption *  Least_Significant_32_Bits
    | Maybe_Six_h16__h16 of Hextet array voption * Hextet 
    | Maybe_Seven_h16 of Hextet array voption



    ///  =                            6( h16 ":" ) ls32
    static member Six_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! hextets = parray 6 Hextet.colon_suffixed_parser |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                return Six_h16__ls32(hextets, ls32)

            }

    ///                       "::" 5( h16 ":" ) ls32
    static member Five_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                do! skip_string "::"
                let! hextets = parray 5 Hextet.colon_suffixed_parser |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                return Five_h16__ls32(hextets, ls32)

            }
    /// [               h16 ] "::" 4( h16 ":" ) ls32
    static member Maybe_One_h16__Four_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_hextet = opt Hextet.parser
                do! skip_string "::"
                let! hextets = parray 4 Hextet.colon_suffixed_parser |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                return Maybe_One_h16__Four_h16__ls32(maybe_hextet,hextets, ls32)

            }



    /// [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
    static member Maybe_Two_h16__Three_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_two_hextets = 
                    opt (
                            choice [

                                Hextet.colon_suffixed_parser .>>. Hextet.parser |>> (fun struct (h16_colon,h16) -> [|h16_colon ; h16|]) 
                                Hextet.parser |>> (fun h16 -> [|h16|])

                                ]
                            
                            )

                do! skip_string "::"
                let! hextets = parray 4 Hextet.colon_suffixed_parser |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                return Maybe_Two_h16__Three_h16__ls32(maybe_two_hextets,hextets, ls32)



            }



    /// [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
    static member Maybe_Three_h16__Two_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_three_hextets = 
                    opt (
                            choice [

                                parray 2 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                Hextet.colon_suffixed_parser .>>. Hextet.parser |>> (fun struct (h16_colon,h16) -> [|h16_colon ; h16|]) 
                                Hextet.parser |>> (fun h16 -> [|h16|])

                                ]
                            
                            )

                do! skip_string "::"
                let! hextets = parray 2 Hextet.colon_suffixed_parser |>> (fun immutable_hextets -> immutable_hextets.AsSpan().ToArray())
                let! ls32 = Least_Significant_32_Bits.parser
                return Maybe_Three_h16__Two_h16__ls32(maybe_three_hextets,hextets, ls32)



            }
    /// [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
    static member Maybe_Four_h16__One_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_four_hextets = 
                    opt (
                            choice [

                                parray 3 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 2 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                Hextet.colon_suffixed_parser .>>. Hextet.parser |>> (fun struct (h16_colon,h16) -> [|h16_colon ; h16|]) 
                                Hextet.parser |>> (fun h16 -> [|h16|])

                                ]
                            
                            )

                do! skip_string "::"
                let! h16 = Hextet.colon_suffixed_parser
                let! ls32 = Least_Significant_32_Bits.parser
                return Maybe_Four_h16__One_h16__ls32(maybe_four_hextets,h16, ls32)



            }
    /// [ *4( h16 ":" ) h16 ] "::"              ls32
    static member Maybe_Five_h16__ls32_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_five_hextets = 
                    opt (
                            choice [

                                parray 4 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 3 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 2 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                Hextet.colon_suffixed_parser .>>. Hextet.parser |>> (fun struct (h16_colon,h16) -> [|h16_colon ; h16|]) 
                                Hextet.parser |>> (fun h16 -> [|h16|])

                                ]
                            
                            )

                do! skip_string "::"
                let! ls32 = Least_Significant_32_Bits.parser
                return Maybe_Five_h16__ls32(maybe_five_hextets, ls32)



            }
    /// [ *5( h16 ":" ) h16 ] "::"              h16
    static member Maybe_Six_h16__h16_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_six_hextets = 
                    opt (
                            choice [

                                parray 5 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 4 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 3 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 2 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                Hextet.colon_suffixed_parser .>>. Hextet.parser |>> (fun struct (h16_colon,h16) -> [|h16_colon ; h16|]) 
                                Hextet.parser |>> (fun h16 -> [|h16|])

                                ]
                            
                            )

                do! skip_string "::"
                let! h16 = Hextet.parser
                return Maybe_Six_h16__h16(maybe_six_hextets, h16)



            }
    /// [ *6( h16 ":" ) h16 ] "::"
    static member Maybe_Seven_h16_parser : Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
            parser {
                let! maybe_seven_hextets = 
                    opt (
                            choice [

                                parray 5 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 4 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 3 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                parray 2 Hextet.colon_suffixed_parser .>>.  Hextet.parser |>> (fun struct(immutable_hextets,h16) -> immutable_hextets.AsSpan().ToArray() |> Array.append [|h16|]) 
                                Hextet.colon_suffixed_parser .>>. Hextet.parser |>> (fun struct (h16_colon,h16) -> [|h16_colon ; h16|]) 
                                Hextet.parser |>> (fun h16 -> [|h16|])

                                ]
                            
                            )

                do! skip_string "::"
                return Maybe_Seven_h16(maybe_seven_hextets)



            }
    static member parser: Parser<IPv6_Address, Code_Point, unit, ReadableMemory<Code_Point>>   = 
    
                parser {

                    let! ipv6 = 

                            choice [ 

                                    IPv6_Address.Six_h16__ls32_parser
                                    IPv6_Address.Five_h16__ls32_parser
                                    IPv6_Address.Maybe_One_h16__Four_h16__ls32_parser
                                    IPv6_Address.Maybe_Two_h16__Three_h16__ls32_parser
                                    IPv6_Address.Maybe_Three_h16__Two_h16__ls32_parser
                                    IPv6_Address.Maybe_Four_h16__One_h16__ls32_parser
                                    IPv6_Address.Maybe_Five_h16__ls32_parser
                                    IPv6_Address.Maybe_Six_h16__h16_parser
                                    IPv6_Address.Maybe_Seven_h16_parser
                                
                                     

                            ]


                    return ipv6


                }
    static member metasyntax = 
                    """
        IPv6address   =                            6( h16 ":" ) ls32
                     /                       "::" 5( h16 ":" ) ls32
                     / [               h16 ] "::" 4( h16 ":" ) ls32
                     / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
                     / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
                     / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
                     / [ *4( h16 ":" ) h16 ] "::"              ls32
                     / [ *5( h16 ":" ) h16 ] "::"              h16
                     / [ *6( h16 ":" ) h16 ] "::"
        """
    static member parse (input_string:string) =  
        match IPv6_Address.parser input_string.as_parser_input with 
        | Ok success -> success 
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  IPv6_Address.metasyntax}"




    // TODO next handle other members like codes and strings    

    
     member this.as_code_square = 
        match this with 
        | Six_h16__ls32 (h16_array,ls32) -> h16_array |> Array.map (fun h16 -> h16.as_code_line) |> Array.append ls32.as_code_square
        | Five_h16__ls32 (h16_array,ls32) -> h16_array |> Array.map (fun h16 -> h16.as_code_line) |> Array.append ls32.as_code_square
        | Maybe_One_h16__Four_h16__ls32 (maybe_hextet,hextets, ls32) -> 
            let prefix_hextets = 
                match maybe_hextet with 
                | ValueSome hextet -> [|hextet.as_code_line|]
                | ValueNone -> [||]
            let hextet_code_lines = hextets |> Array.map  (fun hextet -> hextet.as_code_line)
            prefix_hextets |> Array.append hextet_code_lines   |> Array.append ls32.as_code_square
        | Maybe_Two_h16__Three_h16__ls32(maybe_two_hextets,hextets, ls32) -> 
            let prefix_hextets = 
                match maybe_two_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]
            let hextet_code_lines = hextets |> Array.map  (fun hextet -> hextet.as_code_line)
            prefix_hextets |> Array.append hextet_code_lines   |> Array.append ls32.as_code_square
        | Maybe_Three_h16__Two_h16__ls32(maybe_three_hextets,hextets, ls32) ->
            let prefix_hextets = 
                match maybe_three_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]
            let hextet_code_lines = hextets |> Array.map  (fun hextet -> hextet.as_code_line)
            prefix_hextets |> Array.append hextet_code_lines   |> Array.append ls32.as_code_square
        | Maybe_Four_h16__One_h16__ls32(maybe_four_hextets,h16, ls32) -> 
            let prefix_hextets = 
                match maybe_four_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]
            let hextet_code_lines = prefix_hextets |> Array.append [|h16.as_code_line|]
            hextet_code_lines   |> Array.append ls32.as_code_square
        | Maybe_Five_h16__ls32(maybe_five_hextets, ls32) ->
            let prefix_hextets = 
                match maybe_five_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]
            prefix_hextets   |> Array.append ls32.as_code_square
        | Maybe_Six_h16__h16 (maybe_six_hextets, h16) ->
            let prefix_hextets = 
                match maybe_six_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]
            prefix_hextets   |> Array.append [|h16.as_code_line|]
        | Maybe_Seven_h16 maybe_seven_hextets -> 
                match maybe_seven_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_code_line)
                | ValueNone -> [||]
    member this.as_raw_string = Strings.from_code_square this.as_code_square |> String.concat ""
    member this.as_rendered_string = 
        match this with 
        | Six_h16__ls32 (hextets,ls32) -> 
            let hextet_suffix =
                hextets
                |> Array.map Hextet.raw_string 
                |> String.concat ":"
            hextet_suffix + ls32.as_rendered_string
            
        | Five_h16__ls32 (hextets,ls32) -> 
        
            let hextet_suffix =
                hextets
                |> Array.map Hextet.raw_string 
                |> String.concat ":"
            "::" + hextet_suffix + ls32.as_rendered_string
        | Maybe_One_h16__Four_h16__ls32 (maybe_hextet,h16_array, ls32) -> 
            let hextet_prefix = 
                match maybe_hextet with 
                | ValueSome hextet -> hextet.as_raw_string
                | ValueNone -> String.Empty
            let hextet_suffix =
                h16_array
                |> Array.map Hextet.raw_string 
                |> String.concat ":"

            hextet_prefix + "::" + hextet_suffix + ls32.as_rendered_string
        | Maybe_Two_h16__Three_h16__ls32(maybe_two_hextets,hextets, ls32) -> 
            let hextet_prefix = 
                match maybe_two_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
                | ValueNone -> String.Empty
            let hextet_suffix = hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
            hextet_prefix + "::" + hextet_suffix + ls32.as_rendered_string
        | Maybe_Three_h16__Two_h16__ls32(maybe_three_hextets,hextets, ls32) ->
            let hextet_prefix = 
                match maybe_three_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
                | ValueNone -> String.Empty
            let hextet_suffix = hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
            hextet_prefix + "::" + hextet_suffix + ls32.as_rendered_string
        | Maybe_Four_h16__One_h16__ls32(maybe_four_hextets,h16, ls32) -> 
            let hextet_prefix = 
                match maybe_four_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
                | ValueNone -> String.Empty
            hextet_prefix + "::" + h16.as_raw_string + ":" + ls32.as_rendered_string
        | Maybe_Five_h16__ls32(maybe_five_hextets, ls32) ->
            let hextet_prefix = 
                match maybe_five_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
                | ValueNone -> String.Empty
            hextet_prefix + "::" +  ls32.as_rendered_string
        | Maybe_Six_h16__h16 (maybe_six_hextets, h16) ->
            let hextet_prefix = 
                match maybe_six_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
                | ValueNone -> String.Empty
            hextet_prefix + "::" +  h16.as_raw_string
        | Maybe_Seven_h16 maybe_seven_hextets -> 
            let hextet_prefix = 
                match maybe_seven_hextets with 
                | ValueSome hextets -> hextets |> Array.map  (fun hextet -> hextet.as_raw_string) |> String.concat ":"
                | ValueNone -> String.Empty
            hextet_prefix + "::" 
     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%s``" this unames  this.as_raw_string
    
type IPvFuture = 
    private
    | IPvF of Code_Line * Code_Line

    
     static member parser :Parser<IPvFuture, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {

                    do! skip_any_from_string "vV"
                    let! hexdigits = many1 Terminal.hexdigit.code_point_parser |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)
                    do! skip_char '.'
                    let! address = many1 (Terminal.userinfo.code_point_parser) |>> (fun immutable_code_line -> Code_Line.from_immutable_code_line immutable_code_line)
                    return IPvF(hexdigits,  address)
                        

                }
     static member metasyntax = 
                            """
                            IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
                            """
     static member parse (input_string:string) =  
        match IPvFuture.parser input_string.as_parser_input with 
        | Ok success ->  success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  IPvFuture.metasyntax}"
     member this.as_code_square = 
        match this with 
        | IPvF(hexdigits,  address)  -> [|hexdigits ; address|]
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        sprintf "v%s.%s" (String.from_code_line this.as_code_square[0]) (String.from_code_line  this.as_code_square[1])
     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings


type IP_Literal = 
    private
    | FromIPv6Address of IPv6_Address
    | FromIPvFuture of IPvFuture

    
     static member parser :Parser<IP_Literal, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {

                    do! skip_char '['
                    let! literal = 
                        choice [
                            IPv6_Address.parser |>> FromIPv6Address
                            IPvFuture.parser |>> FromIPvFuture
                        ]
                    do! skip_char ']'
                    return literal
                        

                }
    static member metasyntax = 
        """
        IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
        """
    static member parse (input_string:string) =  
        match IP_Literal.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  IP_Literal.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromIPv6Address ipv6_address -> ipv6_address.as_code_square
        | FromIPvFuture ipvfuture -> ipvfuture.as_code_square
    member this.as_raw_strings = 
            match this with 
            | FromIPv6Address ipv6_address -> [|ipv6_address.as_raw_string|]
            | FromIPvFuture ipvfuture ->  ipvfuture.as_raw_strings
    
    member this.as_rendered_string = 
        let literal_string = 
            match this with 
            | FromIPv6Address ipv6_address -> ipv6_address.as_rendered_string
            | FromIPvFuture ipvfuture ->  ipvfuture.as_rendered_string
        sprintf "[%s]" literal_string
     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings


type Host = 
    | FromIPLiteral of IP_Literal
    | FromIPv4Address of IPv4_Address
    | FromRegisteredName of Registered_Name
    
    
     static member parser :Parser<Host, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {

                    let! host = 
                        choice [
                            IP_Literal.parser |>> FromIPLiteral
                            IPv4_Address.parser |>> FromIPv4Address
                            Registered_Name.parser |>> FromRegisteredName
                        ]
                    return host
                        

                }
    static member metasyntax = 
        """
        host          = IP-literal / IPv4address / reg-name
        """

    static member parse (input_string:string) =  
        match Host.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  IP_Literal.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromIPLiteral ip_literal -> ip_literal.as_code_square
        | FromIPv4Address ipv4_address -> ipv4_address.as_code_square
        | FromRegisteredName registered_name -> [|registered_name.as_code_line|]

    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromIPLiteral ip_literal -> ip_literal.as_rendered_string
        | FromIPv4Address ipv4_address -> ipv4_address.as_rendered_string
        | FromRegisteredName registered_name -> registered_name.as_rendered_string
     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings

type Authority = 
    | FromHost of Host
    | FromUserinfoHost of Userinfo * Host
    | FromHostPort of Host * Port
    | FromUserinfoHostPort of Userinfo * Host * Port
    

     static member parser :Parser<Authority, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    let! maybe_userinfo = opt Userinfo.parser
                    let! host = Host.parser
                    let! maybe_port = opt Port.parser

                    return 
                        match maybe_userinfo,host,maybe_port with 
                        | ValueNone, host, ValueNone -> FromHost host
                        | ValueSome userinfo,host, ValueNone -> FromUserinfoHost (userinfo,host)
                        | ValueNone,host,ValueSome port -> FromHostPort(host,port)
                        | ValueSome userinfo,host,ValueSome port -> FromUserinfoHostPort(userinfo,host,port)
                        
                }
    static member metasyntax = 
        """
        authority     = [ userinfo "@" ] host [ ":" port ]
        """

    static member parse (input_string:string) =  
        match Authority.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Authority.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromHost  host -> host.as_code_square
        | FromUserinfoHost  (userinfo,host) -> host.as_code_square  |> Array.insertAt 0 userinfo.as_code_line 
        | FromHostPort (host,port) -> host.as_code_square |> Array.append [|port.as_code_line|]
        | FromUserinfoHostPort (userinfo,host,port) -> 
            Array.concat  [|

                    [|userinfo.as_code_line|]
                    host.as_code_square
                    [|port.as_code_line|]

            |]
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromHost  host -> host.as_rendered_string
        | FromUserinfoHost  (userinfo,host) -> userinfo.as_rendered_string + host.as_rendered_string
        | FromHostPort (host,port) -> host.as_rendered_string + port.as_rendered_string
        | FromUserinfoHostPort (userinfo,host,port) -> userinfo.as_rendered_string + host.as_rendered_string + port.as_rendered_string


     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings





type Relative_Part = 
    | FromAuthorityAbempty of Authority * Path_Abempty
    | FromAbsolute of Path_Absolute
    | FromNoscheme of Path_Noscheme
    | FromEmpty
     static member parser :Parser<Relative_Part, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    let! maybe_part = opt (
                        choice [

                            skip_string "//" >>. Authority.parser .>>. Path_Abempty.parser |>> (fun struct (authority,abempty) -> FromAuthorityAbempty(authority,abempty))
                            Path_Absolute.parser |>> FromAbsolute
                            Path_Noscheme.parser |>> FromNoscheme

                        ]
                    )

                    return 
                        match maybe_part with 
                        | ValueSome part -> part
                        | ValueNone -> FromEmpty
                        
                }
    static member metasyntax = 
        """
        relative-part = "//" authority path-abempty
             / path-absolute
             / path-noscheme
             / path-empty

        """

    static member parse (input_string:string) =  
        match Authority.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Authority.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromAuthorityAbempty(authority,abempty) -> 
            Array.concat [| authority.as_code_square ; abempty.as_code_square |]
        | FromAbsolute absolute -> absolute.as_code_square
        | FromNoscheme noscheme -> noscheme.as_code_square
        | FromEmpty -> [||]
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromAuthorityAbempty(authority,abempty) -> "//" + authority.as_rendered_string + abempty.as_rendered_string
        | FromAbsolute absolute -> absolute.as_rendered_string
        | FromNoscheme noscheme -> noscheme.as_rendered_string
        | FromEmpty -> String.Empty


     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings


type Hierarchical_Part = 
    | FromAuthorityAbempty of Authority * Path_Abempty
    | FromAbsolute of Path_Absolute
    | FromRootless of Path_Rootless
    | FromEmpty
     static member parser :Parser<Hierarchical_Part, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    let! maybe_part = opt (
                        choice [

                            skip_string "//" >>. Authority.parser .>>. Path_Abempty.parser |>> (fun struct (authority,abempty) -> FromAuthorityAbempty(authority,abempty))
                            Path_Absolute.parser |>> FromAbsolute
                            Path_Rootless.parser |>> FromRootless

                        ]
                    )

                    return 
                        match maybe_part with 
                        | ValueSome part -> part
                        | ValueNone -> FromEmpty
                        
                }
    static member metasyntax = 
        """
        hier-part     = "//" authority path-abempty
                     / path-absolute
                     / path-rootless
                     / path-empty
        """

    static member parse (input_string:string) =  
        match Authority.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Authority.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromAuthorityAbempty(authority,abempty) -> 
            Array.concat [| authority.as_code_square ; abempty.as_code_square |]
        | FromAbsolute absolute -> absolute.as_code_square
        | FromRootless rootless -> rootless.as_code_square
        | FromEmpty -> [||]
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromAuthorityAbempty(authority,abempty) -> "//" + authority.as_rendered_string + abempty.as_rendered_string
        | FromAbsolute absolute -> absolute.as_rendered_string
        | FromRootless rootless -> rootless.as_rendered_string
        | FromEmpty -> String.Empty


     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings

type Relative_Reference = 
    | FromPart of Relative_Part
    | FromPartQuery of Relative_Part * Query
    | FromPartFragment of Relative_Part * Fragment
    | FromPartQueryFragment of Relative_Part * Query * Fragment



     static member parser :Parser<Relative_Reference, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    let! relative_part = Relative_Part.parser
                    let! maybe_query = opt Query.parser
                    let! maybe_fragment = opt Fragment.parser

                    return 
                        match relative_part, maybe_query, maybe_fragment with 
                        | part, ValueNone, ValueNone -> FromPart part
                        | part, ValueSome query_, ValueNone -> FromPartQuery(part,query_)
                        | part, ValueNone, ValueSome fragment -> FromPartFragment(part, fragment)
                        | part, ValueSome query_, ValueSome fragment -> FromPartQueryFragment(part,query_, fragment)
                        
                }
    static member metasyntax = 
        """
            relative-ref  = relative-part [ "?" query ] [ "#" fragment ]

        """

    static member parse (input_string:string) =  
        match Relative_Reference.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Relative_Reference.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromPart part -> part.as_code_square
        | FromPartQuery(part,query_) -> part.as_code_square |> Array.append [|query_.as_code_line|]
        | FromPartFragment(part,fragment) -> part.as_code_square |> Array.append [|fragment.as_code_line|]
        | FromPartQueryFragment(part,query_,fragment) -> 
            Array.concat [|
                
                        part.as_code_square
                        [|query_.as_code_line|]
                        [|fragment.as_code_line|]

            |]
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromPart part -> part.as_rendered_string
        | FromPartQuery(part,query_) -> part.as_rendered_string + query_.as_rendered_string
        | FromPartFragment(part,fragment) -> part.as_rendered_string + fragment.as_rendered_string
        | FromPartQueryFragment(part,query_,fragment) -> part.as_rendered_string  + query_.as_rendered_string + fragment.as_rendered_string

     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings


type Absolute_URI = 
    | FromSchemePart of Scheme * Hierarchical_Part
    | FromSchemePartQuery of Scheme * Hierarchical_Part * Query

     static member parser :Parser<Absolute_URI, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    let! scheme = Scheme.parser
                    do! skip_char ':'
                    let! hier_part = Hierarchical_Part.parser
                    let! maybe_query = opt Query.parser

                    return 
                        match maybe_query  with 
                        | ValueSome query_ -> FromSchemePartQuery(scheme,hier_part,query_)
                        | ValueNone -> FromSchemePart(scheme,hier_part)
                        
                }
    static member metasyntax = 
        """
            absolute-URI  = scheme ":" hier-part [ "?" query ]

        """

    static member parse (input_string:string) =  
        match Absolute_URI.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  Absolute_URI.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromSchemePart(scheme,hier_part) -> hier_part.as_code_square |> Array.insertAt 0 scheme.as_code_line
        | FromSchemePartQuery(scheme,hier_part,query_) -> 
            Array.concat [|

                [|scheme.as_code_line|]
                hier_part.as_code_square
                [|query_.as_code_line|]

            |]
        
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromSchemePart(scheme,hier_part) -> scheme.as_rendered_string + ":" + hier_part.as_rendered_string
        | FromSchemePartQuery(scheme,hier_part,query_) -> scheme.as_rendered_string + ":" + hier_part.as_rendered_string + query_.as_rendered_string

     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings



type URI = 
    | FromSchemePart of Scheme * Hierarchical_Part
    | FromSchemePartQuery of Scheme * Hierarchical_Part * Query
    | FromSchemePartFragment of Scheme * Hierarchical_Part * Fragment
    | FromSchemePartQueryFragment of Scheme * Hierarchical_Part * Query * Fragment

     static member parser :Parser<URI, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    let! scheme = Scheme.parser
                    do! skip_char ':'
                    let! hier_part = Hierarchical_Part.parser
                    let! maybe_query = opt Query.parser
                    let! maybe_fragment = opt Fragment.parser

                    return 
                        match maybe_query, maybe_fragment  with 
                        | ValueNone, ValueNone  -> FromSchemePart(scheme,hier_part)
                        | ValueSome query_, ValueNone -> FromSchemePartQuery(scheme,hier_part,query_)
                        | ValueNone, ValueSome fragment -> FromSchemePartFragment(scheme,hier_part,fragment)
                        | ValueSome query_, ValueSome fragment -> FromSchemePartQueryFragment(scheme,hier_part,query_,fragment)
                        
                }
    static member metasyntax = 
        """
            URI           = scheme ":" hier-part [ "?" query ] [ "#" fragment ]

        """

    static member parse (input_string:string) =  
        match URI.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  URI.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromSchemePart(scheme,hier_part) -> hier_part.as_code_square |> Array.insertAt 0 scheme.as_code_line
        | FromSchemePartQuery(scheme,hier_part,query_) -> 
            Array.concat [|

                [|scheme.as_code_line|]
                hier_part.as_code_square
                [|query_.as_code_line|]

            |]
        
        | FromSchemePartFragment(scheme,hier_part,fragment) -> 
        
            Array.concat [|

                [|scheme.as_code_line|]
                hier_part.as_code_square
                [|fragment.as_code_line|]

            |]
        | FromSchemePartQueryFragment(scheme,hier_part,query_,fragment) -> 
        
            Array.concat [|

                [|scheme.as_code_line|]
                hier_part.as_code_square
                [|fragment.as_code_line|]

            |]
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromSchemePart(scheme,hier_part) -> scheme.as_rendered_string + ":" + hier_part.as_rendered_string
        | FromSchemePartQuery(scheme,hier_part,query_) -> scheme.as_rendered_string + ":" + hier_part.as_rendered_string + query_.as_rendered_string
        | FromSchemePartFragment(scheme,hier_part,fragment) -> scheme.as_rendered_string + ":" + hier_part.as_rendered_string + fragment.as_rendered_string
        | FromSchemePartQueryFragment(scheme,hier_part,query_,fragment) -> scheme.as_rendered_string + ":" + hier_part.as_rendered_string + query_.as_rendered_string + fragment.as_rendered_string

     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings


type URI_Reference = 
    | FromURI of URI
    | FromRelative of Relative_Reference

     static member parser :Parser<URI_Reference, Code_Point, unit, ReadableMemory<Code_Point>>   = 
                parser {
                    return! 
                        choice [

                                URI.parser |>> FromURI
                                Relative_Reference.parser |>> FromRelative
                            
                            ]

                        
                }
    static member metasyntax = 
        """
            URI-reference = URI / relative-ref

        """

    static member parse (input_string:string) =  
        match URI_Reference.parser input_string.as_parser_input with 
        | Ok success -> success
        | Error failure -> failwith $"{failure} : {code_line_message input_string.as_code_line  URI_Reference.metasyntax}"
     member this.as_code_square = 
        match this with 
        | FromURI uri -> uri.as_code_square
        | FromRelative relative_ref -> relative_ref.as_code_square
        
    member this.as_raw_strings = Strings.from_code_square this.as_code_square
    member this.as_rendered_string = 
        match this with 
        | FromURI uri -> uri.as_rendered_string
        | FromRelative relative_ref -> relative_ref.as_rendered_string

     member this.fsi_printer = 
        let unames = Code_Square.Unames this.as_code_square
        sprintf "%A %A ``%A``" this unames  this.as_raw_strings



fsi.AddPrinter<Scheme>(fun scheme -> scheme.fsi_printer)
fsi.AddPrinter<Fragment>(fun fragment -> fragment.fsi_printer)
fsi.AddPrinter<Query>(fun query -> query.fsi_printer)
fsi.AddPrinter<Port>(fun port -> port.fsi_printer)
fsi.AddPrinter<Userinfo>(fun userinfo -> userinfo.fsi_printer)
fsi.AddPrinter<Segment>(fun segment -> segment.fsi_printer)
fsi.AddPrinter<Nonzero_Segment>(fun nonzero_segment -> nonzero_segment.fsi_printer)
fsi.AddPrinter<Nonzero_Noncolon_Segment>(fun nonzero_noncolon_segment -> nonzero_noncolon_segment.fsi_printer)
fsi.AddPrinter<Path_Abempty>(fun path_abempty -> path_abempty.fsi_printer)
fsi.AddPrinter<Path_Rootless>(fun path_rootless -> path_rootless.fsi_printer)
fsi.AddPrinter<Path_Absolute>(fun path_absolute -> path_absolute.fsi_printer)
fsi.AddPrinter<Path_Noscheme>(fun path_noscheme -> path_noscheme.fsi_printer)
fsi.AddPrinter<Registered_Name>(fun registered_name -> registered_name.fsi_printer)
fsi.AddPrinter<Octet>(fun octet -> octet.fsi_printer)
fsi.AddPrinter<IPv4_Address>(fun ipv4_address -> ipv4_address.fsi_printer)
fsi.AddPrinter<Hextet>(fun hextet -> hextet.fsi_printer)
fsi.AddPrinter<Least_Significant_32_Bits>(fun least_significant_32_bits -> least_significant_32_bits.fsi_printer)
fsi.AddPrinter<IPv6_Address>(fun ipv6_address -> ipv6_address.fsi_printer)
fsi.AddPrinter<IPvFuture>(fun ipvfuture -> ipvfuture.fsi_printer)
fsi.AddPrinter<IP_Literal>(fun ip_literal -> ip_literal.fsi_printer)
fsi.AddPrinter<Host>(fun host -> host.fsi_printer)
fsi.AddPrinter<Authority>(fun authority -> authority.fsi_printer)
fsi.AddPrinter<Relative_Part>(fun relative_part -> relative_part.fsi_printer)
fsi.AddPrinter<Hierarchical_Part>(fun hierarchical_part -> hierarchical_part.fsi_printer)
fsi.AddPrinter<Relative_Reference>(fun relative_reference -> relative_reference.fsi_printer)
fsi.AddPrinter<Absolute_URI>(fun absolute_uri -> absolute_uri.fsi_printer)
fsi.AddPrinter<URI>(fun uri -> uri.fsi_printer)
fsi.AddPrinter<URI_Reference>(fun uri_reference -> uri_reference.fsi_printer)





(*








Uri_Fragment.parse_input "#Error-Customization-Combinators"

Uri_Query.parse_input "?http"
Uri_Nonzero_Segment.parse_input "XParsec"


let test_string = "https"
let test_uri = "https://roboz0r.github.io/XParsec/combinators.html#Error-Customization-Combinators"


















(*

type Uri_Term = 

    {
        scheme:string
        authority: string option
        path_abempty: string option
        path_absolute: string option
        path_rootless: string option
        path_empty: string option
    }

// "a"
// |> String.as_code_point
// |> Terminal.sub_delims.parse Ok.with_code_point_array Error.with_code_point_empty


let predicate_byte_array = 
    Unicodepoint.Codespace
    |> Interval_Range.as_array
    |> Array.Parallel.vectorize (fun code_point -> 

        Unicodepoint.Block.Basic_Latin |> Interval_Range.contains code_point |> Byte.from_bool
    
        )





sample_string.code_points
|> Array.vectorize (fun code_point -> 

    code_point |> sub_delims.parse Ok.with_true Error.with_false |> Byte.from_bool

)
|> Array.Parallel.mapi (fun index byte_bool -> index,byte_bool)
|> Array.Parallel.filter (fun (index, byte_bool) -> byte_bool <> 0uy)
|> Array.iter(fun (index, _) -> Console.WriteLine $"index {index} = {sample_string[index]}")



*)

type Code_Point_Store = 
    {
        is_surrogate:int -> byte
    }



let sample_string = "Hello, World! Did you know that the system needs exactly 100% (or \(\frac{100}{100}\)) of the requested data to process the file? Check your local directory (e.g., C:\documents) to see if 'Sample_Text.txt' is ready; if not, contact the administrator immediately!"


sample_string.indexed_code_points_from_rule Terminal.pchar_unencoded
*)
