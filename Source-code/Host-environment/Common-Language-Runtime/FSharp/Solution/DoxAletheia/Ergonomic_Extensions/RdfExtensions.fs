module DoxAletheia.RdfExtensions
open System
open System.Text
open System.IO

open System
open System.IO
open System.Net.Http
open System.IO.Compression
open System.Text.RegularExpressions

open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.JsonLd
open VDS.RDF.Query.Datasets
open VDS.RDF.Storage
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Writing

open PrettierNaming


let rdfsharp_namespace (iri:string) = 
    let uri = Uri(iri)
    let terminal = 
        match iri[iri.Length - 1] with 
        | '#' -> "hash"
        | '/' -> "slash"
        | _ -> "bare"
    let segments = 
        Array.concat [|
            [|uri.Scheme|]
            (uri.Host.Split("."))
            (uri.Segments
            |> Array.collect (fun segment -> segment.Split(".")))
            [|terminal|]

        |]
    segments
            |> Array.map (fun segment -> segment.Replace("/","").Replace("-","_").Replace("~","_"))
            |> Array.filter (fun segment -> segment <> "")
            |> Array.map (fun segment -> 
                let lead = 
                    match segment with 
                    | _ when Char.IsAsciiDigit segment[0] -> "_"
                    |_ when FSharp_Keywords.keyword_names.Contains segment -> "_"
                    | _ -> ""
                lead + segment
            )
            |> String.concat "."













let private is_high_surrogate_code_unit value = value >= 0xD800 && value <= 0xDBFF

let private is_low_surrogate_code_unit value = value >= 0xDC00 && value <= 0xDFFF

let private surrogate_pair_to_code_point high low =
    0x10000
    + ((high - 0xD800) <<< 10)
    + (low - 0xDC00)

let normalize_escaped_surrogate_pairs (text: string) =
    Regex.Replace(
        text,
        @"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})",
        MatchEvaluator (fun m ->
            let high = Convert.ToInt32(m.Groups.[1].Value, 16)
            let low = Convert.ToInt32(m.Groups.[2].Value, 16)

            if is_high_surrogate_code_unit high
               && is_low_surrogate_code_unit low then
                let code_point = surrogate_pair_to_code_point high low
                sprintf "\\U%08X" code_point
            else
                m.Value)
    )




module Turtle =


    let writer =
        let writer = new CompressingTurtleWriter(TurtleSyntax.Rdf11Star)
        writer.HighSpeedModePermitted <- false
        writer.PrettyPrintMode <- true
        writer

    let write (file_path: string) (graph: VDS.RDF.IGraph) = writer.Save(graph, file_path)

// TODO move these to NQuads module
let normalize_nquads_file (source_path: string) (destination_path: string) =
    use reader = new StreamReader(source_path)

    use writer = new StreamWriter(destination_path, false, System.Text.Encoding.UTF8)

    while not reader.EndOfStream do
        let line = reader.ReadLine()
        let normalized_line = normalize_escaped_surrogate_pairs line
        writer.WriteLine(normalized_line)


let find_first_bad_nquad_line (path: string) =
    let parser = NQuadsParser()

    use reader = new StreamReader(path)

    let mutable line_number = 0
    let mutable result: (int * string * string) option = None

    while result.IsNone && not reader.EndOfStream do
        line_number <- line_number + 1

        let line = reader.ReadLine()

        if not (String.IsNullOrWhiteSpace line) then
            try
                let store = new TripleStore()
                use line_reader = new StringReader(line)
                parser.Load(store, line_reader)
            with
            | err -> result <- Some(line_number, err.Message, line)

    result

let write_valid_nquads_only (source_path: string) (destination_path: string) =
    let parser = NQuadsParser()

    use reader = new StreamReader(source_path)
    use writer = new StreamWriter(destination_path, false, System.Text.Encoding.UTF8)

    use error_writer =
        new StreamWriter(destination_path + ".errors.txt", false, System.Text.Encoding.UTF8)

    let mutable line_number = 0
    let mutable kept = 0
    let mutable rejected = 0

    while not reader.EndOfStream do
        line_number <- line_number + 1
        let line = reader.ReadLine()

        if not (String.IsNullOrWhiteSpace line) then
            try
                let store = new TripleStore()
                use line_reader = new StringReader(line)
                parser.Load(store, line_reader)

                writer.WriteLine(line)
                kept <- kept + 1
            with
            | err ->
                rejected <- rejected + 1
                error_writer.WriteLine($"LINE {line_number}")
                error_writer.WriteLine(err.Message)
                error_writer.WriteLine(line)
                error_writer.WriteLine()

    printfn "Kept %i lines; rejected %i lines." kept rejected



