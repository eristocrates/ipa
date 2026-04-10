open System
open System.Text
open System.Linq

#r "nuget: FParsec"
#r "nuget: FParsec-Pipes"

open FParsec
open FParsec.Pipes

let communication_at: Parser<char, unit> = pchar '@'

type Adposition =
    | OnString
    | OnFilePath
    | OnFileContent
    | WithArgument

[<RequireQualifiedAccess>]
type Input_Stream =
    | file_path of string
    | string of string

type OutputResult<'Output_Type, 'User_State_Type> =
    {

      input: Input_Stream
      user_state: 'User_State_Type
      output: 'Output_Type option
      position: Position option
      parser_error: ParserError option

     }

let apply_parser<'Input_Type, 'User_State_Type, 'Output_Type>
    (parser: CharStream<'User_State_Type> -> Reply<'Output_Type>)
    (input_stream: Input_Stream)
    (initial_state: 'User_State_Type)
    =
    let parser_result =
        match input_stream with
        | Input_Stream.file_path input_file_path ->
            runParserOnFile parser initial_state input_file_path Text.Encoding.UTF8
        | Input_Stream.string input_string -> runParserOnString parser initial_state "" input_string

    match parser_result with
    | Success (output, user_state, position) ->
        {

          input = input_stream
          user_state = user_state
          output = Some(output)
          position = Some(position)
          parser_error = None

        }
    | Failure (input_string, parser_error, user_state) ->
        {

          input = input_stream
          user_state = user_state
          output = None
          position = None
          parser_error = Some(parser_error)

        }

let parse_input parser (input: string) =
    let output_result = apply_parser parser (Input_Stream.string input) ()

    match output_result.output with
    | Some output -> output
    | _ -> failwith (output_result.parser_error.Value.ToString())

let parser_withArgument_expecting parser argument (expecting: string) = parser argument <??> expecting
let parser_expecting parser (expecting: string) = parser <??> expecting

(*

    let nz_nc_from_input (input: string) =
        let output_result = apply_parser nz_nc_parser (Input_Stream.string input) ()

        match output_result.output with
        | Some output -> output
        | _ -> failwith (output_result.parser_error.Value.ToString())
*)
let provisional parser = opt (attempt parser)
let succeededBy parser = followedBy parser .>> parser

let string_from_charList (charList: char list) = new String(charList.ToArray())


let zero_or_more = many
let one_or_more = many1
let zero_of = notEmpty

let contiguous parser =
    one_or_more parser .>> (spaces1 <|> eof)

let prepend (head: 'HeadTailType) (tail: List<'HeadTailType>) = head :: tail

let int_from_stringNumeral (stringNumeral: string) =
    match System.Int32.TryParse(stringNumeral) with
    | true, intNumeral -> intNumeral
    | _ -> failwithf "Invalid numeral string: %s" stringNumeral

let intNumeral_from_charNumeral (charNumeral: char) =
    int_from_stringNumeral (string charNumeral)

let int_from_singleDigit (int_from_singleDigit: char) =
    int_from_stringNumeral (string int_from_singleDigit)

let int_from_doubleDigit (leftDigit: char) (rightDigit: char) =
    int_from_stringNumeral $"{leftDigit}{rightDigit}"

let int_from_tripleDigit (leftDigit: char) (centerDigit: char) (rightDigit: char) =
    int_from_stringNumeral $"{leftDigit}{centerDigit}{rightDigit}"


let runParser parser (adposition: Adposition) (inputString: string) =
    match adposition with
    | OnString -> runParserOnString parser () "" inputString

let parseStringVariable parser (stringVariable: string) =
    runParserOnString parser () "" stringVariable
