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


let current_directory_file_path (file_name:string) = Path.Combine(__SOURCE_DIRECTORY__,file_name)

let math_file_path = current_directory_file_path "math.bnf"















module Terminal = 

    let letter  = 
    
            {

                code_points = 
                    Code_Line.from_chars 
                        [|

                                'A' ; 'B' ; 'C' ; 'D' ; 'E' ; 'F' ; 'G' ; 'H' ; 'I' ; 'J' ; 'K' ; 'L' ; 'M' ; 'N' ; 'O' ; 'P' ; 'Q' ; 'R' ; 'S' ; 'T' ; 'U' ; 'V' ; 'W' ; 'X' ; 'Y' ; 'Z' ; 'a' ; 'b' ; 'c' ; 'd' ; 'e' ; 'f' ; 'g' ; 'h' ; 'i' ; 'j' ; 'k' ; 'l' ; 'm' ; 'n' ; 'o' ; 'p' ; 'q' ; 'r' ; 's' ; 't' ; 'u' ; 'v' ; 'w' ; 'x' ; 'y' ; 'z'

                        |]
                
                 
                metasyntax = 
            
                                  """
                                  <letter>         ::= "A" | "B" | "C" | "D" | "E" | "F" | "G" | "H" | "I" | "J" | "K" | "L" | "M" | "N" | "O" | "P" | "Q" | "R" | "S" | "T" | "U" | "V" | "W" | "X" | "Y" | "Z" | "a" | "b" | "c" | "d" | "e" | "f" | "g" | "h" | "i" | "j" | "k" | "l" | "m" | "n" | "o" | "p" | "q" | "r" | "s" | "t" | "u" | "v" | "w" | "x" | "y" | "z"
                                  """ 

            }
    
    let digit  = 
    
            {

                code_points = 
                    Code_Line.from_chars 
                        [|

                                '0' ; '1' ; '2' ; '3' ; '4' ; '5' ; '6' ; '7' ; '8' ; '9'

                        |]
                
                 
                metasyntax = 
            
                                  """
                                  <digit>          ::= "0" | "1" | "2" | "3" | "4" | "5" | "6" | "7" | "8" | "9"
                                  """ 

            }
    
    let symbol  = 
    
            {

                code_points = 
                    Code_Line.from_chars 
                        [|

                                '|'
                                ' '
                                '!'
                                '#'
                                '$'
                                '%'
                                '&'
                                '('
                                ')'
                                '*'
                                '+'
                                ','
                                '-'
                                '.'
                                '/'
                                ':'
                                ';'
                                '>'
                                '='
                                '<'
                                '?'
                                '@'
                                '['
                                '\\'
                                ']'
                                '^'
                                '_'
                                '`'
                                '{'
                                '}'
                                '~'

                        |]
                
                 
                metasyntax = 
            
                                  """
                                  <symbol>         ::= "|" | " " | "!" | "#" | "$" | "%" | "&" | "(" | ")" | "*" | "+" | "," | "-" | "." | "/" | ":" | ";" | ">" | "=" | "<" | "?" | "@" | "[" | "\" | "]" | "^" | "_" | "`" | "{" | "}" | "~"
                                  """ 

            }
    
    let rule_char  = 
    
            {

                code_points = 
                    Array.concat 
                        [| 
                        
                            letter.code_points 
                            digit.code_points
                            [| int '-'|]
                    
                        |]
                
                 
                metasyntax = 
            
                                  """
                                  <rule-char>      ::= <letter> | <digit> | "-"
                                  """ 

            }
    

    let character  = 
    
            {

                code_points = 
                    Array.concat 
                        [| 
                        
                            letter.code_points 
                            digit.code_points
                            symbol.code_points
                    
                        |]
                
                 
                metasyntax = 
            
                                  """
                                  <character>      ::= <letter> | <digit> | <symbol>
                                  """ 

            }




let happy_sad_result  happy_path sad_path parse_result = 

    match parse_result with 
    | Ok success-> happy_path success
    | Error failure -> sad_path failure




















module Nonterminal = 


    /// <opt-whitespace> ::= " " <opt-whitespace> | ""
    /// overidden to spaces
    let opt_whitespace = many (skipAnyOf whitespace_code_points)
    let rule_name = 
        {

            code_line_parser = 
                parser {


                    let! immutable_code_points = circumfixed_parser '<' ( any_from_code_points Terminal.rule_char.code_points |> many1 ) '>'
                    return immutable_code_points  |> Code_Line.from_immutable_code_line


                }
        
            metasyntax = 
            
                                  """
                                  <rule-name>      ::= <rule-char> | <rule-name> <rule-char>
                                  """ 

        }
    let text = 
        {

            code_line_parser = 
                parser {

                    let! immutable_code_points = many1 Terminal.character.code_point_parser
                    return immutable_code_points  |> Code_Line.from_immutable_code_line


                }
        
            metasyntax = 
            
                                  """
                                <text1>          ::= "" | <character1> <text1>
                                <text2>          ::= "" | <character2> <text2>
                                  """ 

        }


    let literal = 
        {

            code_line_parser = 
                parser {

                    let! immutable_line_square = 
                         choice [ 

                                circumfixed_parser ''' (many1 text.code_line_parser) '''
                                circumfixed_parser '"' (many1 text.code_line_parser) '"'
                            
                                ]
                    return immutable_line_square |> Code_Line.from_immutable_code_square

                }
        
            metasyntax = 
            
                                  """
                                <literal>        ::= '"' <text1> '"' | "'" <text2> "'"
                                  """ 

        }
    let term = 
        {

            code_line_parser = 
                parser {

                    return! choice [ literal.code_line_parser ; rule_name.code_line_parser ]

                }
        
            metasyntax = 
            
                                  """
                                <term>           ::= <literal> | "<" <rule-name> ">"
                                  """ 

        }
    let list_ = 
        {

            code_square_parser = 
                parser {

                    let! immutable_code_line = many1 (term.code_line_parser .>> opt_whitespace )
                    return immutable_code_line |> Code_Square.from_immutable_code_square

                }
        
            metasyntax = 
            
                                  """
                                <list>           ::= <term> | <term> <opt-whitespace> <list>
                                  """ 

        }
    let line_end = 
        {

            code_line_parser = newline
        
            metasyntax = 
            
                                  sprintf """
                                <line-end>       ::= <opt-whitespace> <EOL> | <line-end> <line-end>
                                overriden to %s parser
                                  """ (nameof newline)

        }




    let expression = 
        {

            code_square_parser = 
                parser {

                    let! expr =  list_.code_square_parser
                    return expr
                        

                }
        
            metasyntax = 
                                """
                                <expression>     ::= <list> | <list> <opt-whitespace> "|" <opt-whitespace> <expression>
                                  """

        }



(*



    // TODO deal with return valuesp

/// <rule>           ::= <opt-whitespace> "<" <rule-name> ">" <opt-whitespace> "::=" <opt-whitespace> <expression> <line-end>
type Bnf_Rule = 
    {

        rule_name:string
        bnf_expression:string array

    }
    static member parser  = 
    
                parser {
                    do! spaces
                    let! name = Nonterminal.rule_name.code_line_parser
                    do! spaces
                    do! skip_string "::="
                    do! spaces
                    let! expr = Nonterminal.expression.code_square_parser
                    do!spaces
                    let! _ = Nonterminal.line_end.code_line_parser
                    return {
                            
                            rule_name = String.from_code_line name
                            bnf_expression = Strings.from_code_square expr
                            
                            }

                }
    static member parse (code_line: int array) =
        let metasyntax = 
                                            """
                                <rule>           ::= <opt-whitespace> "<" <rule-name> ">" <opt-whitespace> "::=" <opt-whitespace> <expression> <line-end> 
                                """

        match Reader.from_code_line code_line |> Bnf_Rule.parser with
        | Ok rule -> rule
        | Error err -> failwith (Error.code_line_failed_rule_message code_line metasyntax)


*)




(*
<expression> ::= <digit> | <expression> "+" <digit>
<digit>      ::= "0" | "1" | "2" | "3" | "4" | "5" | "6" | "7" | "8" | "9"
*)






let test_string = """<digit> | <expression> "+" <digit>"""





Nonterminal.list_.code_square_parser test_string.as_parser_input


let test_output = Nonterminal.list_.code_square_parser test_string.as_parser_input |> happy_sad_result Result.Ok.with_some_output Result.with_none




"-"
|> String.as_code_point
|> Terminal.rule_char.code_point_parser

 Ok.with_some_code_line_string Error.with_none



// """<expression> "+" <digit>"""

"""<expression> ::= <digit> | <expression> "+" <digit>"""




let parser_result_from_string (input_string:string) = 
    let parser_result = 
        parser {
            let! name =  Nonterminal.rule_name.parser
            do! spaces

            do! skip_string "::="
            do! spaces
            let! expr = Nonterminal.expression.parser
            return name,expr
        } <| Reader.from_string input_string 
    match parser_result with 
    | Ok parsed -> 
        let name, expr = parsed 
        Ok.with_some_code_line_string name,Ok.with_some_code_square_string expr
    | Error error ->  None,None

parser_result_from_string """<expression> ::= <digit> | <expression> "+" <digit>"""

// |> String.as_code_line
// |> Nonterminal.rule_name.parse Ok.with_some_code_line_string Error.with_none

