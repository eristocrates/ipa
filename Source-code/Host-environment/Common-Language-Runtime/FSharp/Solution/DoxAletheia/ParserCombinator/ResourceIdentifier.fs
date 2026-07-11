// #time on

module DoxAletheia.ParserCombinator.ResourceIdentifier


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



open XParsec
open DoxAletheia
open GrammarErgonomics
open StringExtensions
open IntervalErgonomics
open XParsecExtensions.Code_Parsers
open ArrayExtensions
open ByteExtensions

(*




let sub_delims: Code_Point_Rule = 
    
        {

            scalars = Code_Line.from_chars_sorted
                
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
    


let gen_delims: Code_Point_Rule = 

        {

            scalars = Code_Line.from_chars_sorted
                
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


let reserved: Code_Point_Rule = 
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




let unreserved: Code_Point_Rule = 
        {

            scalars = 
                
                Array.concat [|

                    Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.values
                    Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.values
                    (Code_Line.from_chars [| '-' ; '.' ; '_' ; '~'|])

                |]
                |> Array.sort

            metasyntax = 
            
                              """
                              unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
                              """ 

        }
/// unencoded, as per
/// https://www.w3.org/TR/rdf12-concepts/#section-IRIs
let pchar_unencoded: Code_Point_Rule =
        {

            scalars = 
                
                Array.concat [|

                    unreserved.scalars
                    sub_delims.scalars
                    (Code_Line.from_chars [| ':' ; '@'|])

                |]
                |> Array.sort

            metasyntax = 
            
                              """
                              pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
                              """ 

        }




let scheme : Code_Line_Rule = 
    {

        parser = 
            parser {

                let! scheme_head = 
                    choice [
                        
                        Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.values |> any_point_from_line
                        Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.values |> any_point_from_line

                    ]
                let! scheme_tail = 

                        many (choice [

                        
                            Unicodepoint.Partition.Latin_Majuscule |> Interval_Range.values |> any_point_from_line
                            Unicodepoint.Partition.Latin_Minuscule |> Interval_Range.values |> any_point_from_line
                            Unicodepoint.Partition.Ascii_Digits |> Interval_Range.values |> any_point_from_line
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


let fragment : Code_Line_Rule = 
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

(*


"https"
|> String.as_code_line
|> fragment.parse Ok.with_some_code_line_string Error.with_none

"a"
|> String.as_code_point
|> sub_delims.parse Ok.with_code_line Error.with_code_point_empty
*)

let predicate_byte_array = 
    Unicodepoint.Codespace
    |> Interval_Range.values
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


// sample_string.indexed_terminals_from_rule pchar_unencoded

*)