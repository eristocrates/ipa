open System

#r "nuget: FParsec"
open FParsec

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive"
#load @"Microsoft\Windows\API\Technologies\Desktop_Technologies\Data_Access_and_Storage\Local_file_systems\Local_File_System.fsx"

[<RequireQualifiedAccess>]
type Input_Stream =
    | file of Local_File_System.Logical_File
    | string of string

type Output<'Output_Type, 'User_State_Type> =
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
        | Input_Stream.file digital_file ->
            runParserOnFile parser initial_state digital_file.absolute_path Text.Encoding.UTF8
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
