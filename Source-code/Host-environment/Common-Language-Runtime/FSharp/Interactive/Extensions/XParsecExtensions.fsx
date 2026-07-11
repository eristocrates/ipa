#time on

open System
open System.Collections.Immutable
open System.Globalization
open System.Net
open System.Numerics
open System.Runtime.Intrinsics
open System.Text
open System.Numerics
open System.Threading.Tasks
open System.Diagnostics

#r "nuget: CommunityToolkit.HighPerformance"
open CommunityToolkit.HighPerformance

#r "nuget: Unquote"
open Swensen.Unquote.Assertions

#r "nuget: XParsec"

open XParsec
open XParsec.Parsers
open XParsec.Combinators

#r "nuget: FSharp.UMX"
open FSharp.UMX

#r "nuget: Hedgehog"

open Hedgehog
open Hedgehog.FSharp

#r "nuget: NUnit.Framework"
#r "nuget: FsUnit"

open NUnit.Framework
open FsUnit

#r "nuget: FsCheck"
open FsCheck

#r "nuget: MathNet.Numerics"
open MathNet.Numerics

#r "nuget: FRange"
open FRange


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DiagnosticsErgonomics.fsx"
open DiagnosticsErgonomics

// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\IntervalErgonomics.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\Unicodepoint.fsx"

open IntervalErgonomics
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\ArrayExtensions.fsx"
open ArrayExtensions



Vector.IsHardwareAccelerated

module ImmutableArray =
    let toArray (immutable_array: ImmutableArray<_>) =
        immutable_array
        |> Seq.collect (fun element -> element)
        |> Seq.toArray


let byte_from_bool (predicate_is_true:bool) = if predicate_is_true then 1uy else 0uy
let bool_from_byte (byte_value:byte) = byte_value <> 0uy

module Scalar = 
    let from_char (char_:char ) = Rune(char_).Value
module Scalars = 
    let from_chars (chars:char array) = chars |> Array.map (fun character -> int character )
    let from_chars_sorted (chars:char array) = chars |> Array.map (fun character -> int character ) |> Array.sort

type String with 
    member this.runes = this.EnumerateRunes() |> Seq.toArray
    member this.scalars = this.EnumerateRunes() |> Seq.toArray |> Array.map (fun rune -> rune.Value)
    member this.as_rune = this.EnumerateRunes() |> Seq.toArray |> Array.exactlyOne
    member this.as_scalar = this.EnumerateRunes() |> Seq.toArray |> Array.map (fun rune -> rune.Value) |> Array.exactlyOne
    static member from_scalar (scalar:int) = Rune(scalar).ToString()
    static member from_scalars (scalars :int array) = 
        scalars
        |> Array.map (fun scalar -> Rune(scalar).ToString())
        |> String.concat ""
    member this.url_decoded = WebUtility.UrlDecode(this)
    member this.url_encoded = WebUtility.UrlEncode(this)
    member this.html_encoded = WebUtility.HtmlEncode(this)
    member this.html_decoded = WebUtility.HtmlDecode(this)





module String = 
    let as_scalar (string_value:string) = string_value.as_scalar
    let scalars (string_value:string) = string_value.scalars

type Rune with 
    member this.as_string = this.ToString()
    member this.hex_literal = sprintf "%X" this.Value
    member this.Uhex_literal = $"U+{this.hex_literal}"


type Byte with 
    static member from_bool (predicate_is_true:bool) = byte_from_bool predicate_is_true
    member this.to_bool  = bool_from_byte this

type Boolean with 
    static member from_byte (byte_value:byte) = bool_from_byte byte_value
    member this.to_byte  = byte_from_bool this
























module ICharParsers =



    module Reader =


        let from_scalars (scalars:int array) =
            let memory = ReadOnlyMemory<int>(scalars)
            Reader.ofMemory memory ()
        let from_runes (runes: Rune array) = runes  |> Array.map (fun rune -> rune.Value)  |> from_scalars
        let from_string (string_input: string) = string_input.scalars |> from_scalars

        let from_scalar (scalar: int) = from_scalars [| scalar |]
        let from_rune (rune: Rune) = from_scalars [| rune.Value |]
        let from_char (character: char) = from_scalars [| int character |]
    



    let any_scalar_from (scalars:int array) = anyOf scalars
    let any_scalar_from_string (string_set:string) = anyOf string_set.scalars
    let any_scalar_from_chars (chars:char array) = chars |> Array.map (fun character -> int character ) |> anyOf 
    
    let skip_char (char_:char) = Scalar.from_char char_ |> skipItem
    let parse_char (char_:char) = Scalar.from_char char_ |> pitem



    // parse results
    module Ok =


        let with_true (scalars: int array) = true
        let with_false (scalars: int array) = false
        let with_scalar_array (scalars: int array) = scalars

        let with_some_scalars (scalars: int array) = 
            if scalars.Length < 1 then 
                None 
            else Some [|scalars|]


        let with_string (scalars: int array) = String.from_scalars scalars
        let with_some_string (scalars: int array) = Some(String.from_scalars scalars)

        let with_measured_string<[<Measure>] 'Umx> (scalars: int array) : string<'Umx> = %(String.from_scalars scalars)

        let with_some_measured_string<[<Measure>] 'Umx> (scalars: int array) : string<'Umx> option =
            Some(%(String.from_scalars scalars))

    module Error =

        let with_none scalars rule = None
        let with_true scalars rule = true
        let with_false scalars rule = false

        let scalar_failed_rule_message (scalar: int) (rule: string) =
            sprintf "Unicode scalar value %d (U+%X) ``%s`` failed rule %s" scalar scalar (String.from_scalar scalar) rule

        let with_scalar_exception (scalar: int ) (rule: string) =
            scalar_failed_rule_message scalar rule
            |> failwith


        let with_scalar_none (scalar: int ) (rule: string) =
            printfn "%s" (scalar_failed_rule_message scalar rule)
            None

        let with_scalar_empty (scalar: int ) (rule: string) =
            printfn "%s" (scalar_failed_rule_message scalar rule)
            [||]

        let scalars_failed_rule_message (scalars: int array) (rule: string) =
            sprintf "Unicode scalar value %A  ``%s`` failed rule %s" scalars (String.from_scalars scalars) rule

        let with_scalars_exception (scalars: int array ) (rule: string) =
            scalars_failed_rule_message scalars rule
            |> failwith


        let with_scalars_none (scalars: int array ) (rule: string) =
            printfn "%s" (scalars_failed_rule_message scalars rule)
            None

        let with_scalars_empty (scalars: int array ) (rule: string) =
            printfn "%s" (scalars_failed_rule_message scalars rule)
            [||]

open ICharParsers

type Metasyntax = 
    | Bnf of string
    | Abnf of string
    | Ebnf of string
    member this.as_string = 
        match this with 
        | Bnf rule -> rule
        | Abnf rule -> rule
        | Ebnf rule -> rule

    



[<Struct>]
type  Terminal_Rule = 
    {

        scalars: int array
        metasyntax:string
         

    }
    member this.octet_key_for_scalar (target_scalar:int) = 
         match this.scalars |> Array.tryFindIndex (fun scalar -> scalar = target_scalar) with
         | Some index -> 
            if index+1 > 255 then
                invalidArg (nameof this) "octet_key_for_scalar requires a key no larger than 255."
            byte (index+1)
         | None -> 0uy
    member this.octet_key_for_rune (target_rune:Rune) = 
            this.octet_key_for_scalar target_rune.Value

    member this.parser: Parser<int, int, unit, ReadableMemory<int>> = 
        any_scalar_from this.scalars
    member this.parse happy_path sad_path (code_point: int) =
        match Reader.from_scalar code_point
              |> this.parser
            with
        | Ok code_point -> [|code_point|] |> happy_path
        | Error err -> sad_path code_point this.metasyntax

module Terminal_Rule = 
        let octet_map (terminal_rule:Terminal_Rule) = 
            if terminal_rule.scalars.Length > 255 then
                invalidArg (nameof terminal_rule) "Terminal_Rule.octet_map requires at most 255 scalars."

            terminal_rule.scalars
            |> Array.mapi (fun index scalar -> byte (index+1), scalar)
            |> Array.insertAt 0 (0uy, 0)
            |> Map.ofArray



type String with 

    static member indexed_terminals_from_rule (terminal_rule:Terminal_Rule) (string_value:string)  =
        let octet_map = Terminal_Rule.octet_map terminal_rule
        string_value.scalars
        |> Array.Parallel.vectorize (fun scalar ->
            octet_map[terminal_rule.octet_key_for_scalar scalar]
        )
        |> Array.Parallel.mapi (fun index scalar -> index, scalar)
        |> Array.Parallel.filter (fun (index , scalar) -> scalar <> 0)
        |> Array.Parallel.map (fun (index , scalar) -> index, String.from_scalar scalar)
    member this.indexed_terminals_from_rule (terminal_rule:Terminal_Rule) = String.indexed_terminals_from_rule   terminal_rule  this




let sub_delims = 
    
        {

            scalars = Scalars.from_chars_sorted
                
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
    
module sub_delims = 
    [<Measure>]
    type umx 


let gen_delims = 

        {

            scalars = Scalars.from_chars_sorted
                
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

            scalars = 
                
                Array.concat [|

                    gen_delims.scalars
                    sub_delims.scalars

                |]  |> Array.sort

            metasyntax = 
            
                              """
                              reserved      = gen-delims / sub-delims
                              """ 

        }




let unreserved = 
        {

            scalars = 
                
                Array.concat [|

                    Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.as_array
                    Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.as_array
                    (Scalars.from_chars [| '-' ; '.' ; '_' ; '~'|])

                |]
                |> Array.sort

            metasyntax = 
            
                              """
                              unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
                              """ 

        }
/// unencoded, as per
/// https://www.w3.org/TR/rdf12-concepts/#section-IRIs
let pchar_unencoded =
        {

            scalars = 
                
                Array.concat [|

                    unreserved.scalars
                    sub_delims.scalars
                    (Scalars.from_chars [| ':' ; '@'|])

                |]
                |> Array.sort

            metasyntax = 
            
                              """
                              pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                              """ 

        }


type Nonterminal_Rule = 
    {

        parser: Parser<int array, int, unit, ReadableMemory<int>>
        metasyntax:string
    }
    member this.parse happy_path sad_path (code_points: int array) =
        match Reader.from_scalars code_points
              |> this.parser
            with
        | Ok code_points -> code_points |> happy_path
        | Error err -> sad_path code_points this.metasyntax



let scheme = 
    {

        parser = 
            parser {

                let! scheme_head = 
                    choice [
                        
                        Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.as_array |> any_scalar_from
                        Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.as_array |> any_scalar_from

                    ]
                let! scheme_tail = 

                        many (choice [

                        
                            Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.as_array |> any_scalar_from
                            Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.as_array |> any_scalar_from
                            Unicodepoint.Partition.Ascii_Digits |> Interval_Range.as_array |> any_scalar_from
                            parse_char '+'
                            parse_char '-'
                            parse_char '.'
            


                        ] )
                return scheme_tail.AsMemory().ToArray() |> Array.insertAt 0 scheme_head


            }
        
        metasyntax = 
            
                              """
                              scheme        = ALPHA *( ALPHA / DIGIT / "+" / "-" / "." )
                              """ 

    }


let fragment = 
    {

        parser = 
            parser {

                do! skip_char '#'
                let! immutable_array = 

                        many (choice [

                            pchar_unencoded.parser
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


type Uri_Term = 

    {
        scheme:string
        authority: string option
        path_abempty: string option
        path_absolute: string option
        path_rootless: string option
        path_empty: string option
    }


"https"
|> String.scalars
|> scheme.parse Ok.with_some_string Error.with_none

"a"
|> String.as_scalar
|> sub_delims.parse Ok.with_scalar_array Error.with_scalar_empty

let predicate_byte_array = 
    Unicodepoint.Codespace
    |> Interval_Range.as_array
    |> Array.Parallel.vectorize (fun code_point -> 

        Unicodepoint.Block.Basic_Latin |> Interval_Range.contains code_point |> Byte.from_bool
    
        )


(*



sample_string.scalars
|> Array.vectorize (fun scalar -> 

    scalar |> sub_delims.parse Ok.with_true Error.with_false |> Byte.from_bool

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


sample_string.indexed_terminals_from_rule pchar_unencoded

