module DoxAletheia.GrammarErgonomics

open System
open System.Text
open XParsec

open ArrayErgonomics
open StringExtensions

open XParsecExtensions
open XParsecExtensions.Code_Parsers



#noward 57

[<Struct>]
type Code_Point_Rule =
    {

      code_points: Code_Point array
      metasyntax: string


     }
    member this.code_point_octet_key(target_code_point: Code_Point) =
        match this.code_points
              |> Array.sort
              |> Array.tryFindIndex (fun code_point -> code_point = target_code_point)
            with
        | Some index ->
            if index + 1 > 255 then
                invalidArg (nameof this) "code_point_octet_key requires a key no larger than 255."

            byte (index + 1)
        | None -> 0uy

    member this.rune_octet_key(target_rune: Rune) =
        this.code_point_octet_key target_rune.Value

    member this.code_point_parser: Parser<Code_Point, Code_Point, unit, ReadableMemory<Code_Point>> =
        any_from_code_points this.code_points


module Code_Point_Rule =
    let octet_map (code_point_rule: Code_Point_Rule) =
        if code_point_rule.code_points.Length > 255 then
            invalidArg (nameof code_point_rule) "Terminal_Rule.octet_map requires at most 255 code_points."

        code_point_rule.code_points
        |> Array.sort
        |> Array.mapi (fun index code_point -> byte (index + 1), code_point)
        |> Array.insertAt 0 (0uy, 0)
        |> Map.ofArray



type Code_Line_Rule =
    {

      code_line_parser: Parser<Code_Line, Code_Point, unit, ReadableMemory<Code_Point>>
      metasyntax: string }


type Code_Square_Rule =
    {

      code_square_parser: Parser<Code_Square, Code_Point, unit, ReadableMemory<Code_Point>>
      metasyntax: string }

type Code_Cube_Rule =
    {

      code_cube_parser: Parser<Code_Cube, Code_Point, unit, ReadableMemory<Code_Point>>
      metasyntax: string }




type String with

    static member indexed_code_points_from_rule (code_point_rule: Code_Point_Rule) (string_value: string) =
        let octet_map = Code_Point_Rule.octet_map code_point_rule

        string_value.as_code_line
        |> Array.sort
        |> Array.Parallel.vectorize (fun code_point -> octet_map[code_point_rule.code_point_octet_key code_point])
        |> Array.Parallel.mapi (fun index code_point -> index, code_point)
        |> Array.Parallel.filter (fun (index, code_point) -> code_point <> 0)
        |> Array.Parallel.map (fun (index, code_point) -> index, String.from_code_point code_point)

    member this.indexed_code_points_from_rule(code_point_rule: Code_Point_Rule) =
        String.indexed_code_points_from_rule code_point_rule this
