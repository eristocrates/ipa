#load "ProcessExecution.fsx"

open ProcessExecution
open System
open System.IO


module python =
    let filePath =
        @"C:\Users\CollierB\.path\python-full-3.13.4-windows-x86_64\bin\py.cmd"

(*
    usage: genson [-h] [--version] [-d DELIM] [-e ENCODING] [-i SPACES] [-s SCHEMA] [-$ SCHEMA_URI] ...

    Generate one, unified JSON Schema from one or more JSON objects and/or JSON Schemas. Compatible with JSON-Schema Draft 4 and above.

    positional arguments:
      object                Files containing JSON objects (defaults to stdin if no arguments are passed).

    options:
      -h, --help            Show this help message and exit.
      --version             Show version number and exit.
      -d, --delimiter DELIM
                            Set a delimiter. Use this option if the input files contain multiple JSON objects/schemas. You can pass any string. A few cases ('newline', 'tab', 'space') will get converted to a whitespace
                            character. If this option is omitted, the parser will try to auto-detect boundaries.
      -e, --encoding ENCODING
                            Use ENCODING instead of the default system encoding when reading files. ENCODING must be a valid codec name or alias.
      -i, --indent SPACES   Pretty-print the output, indenting SPACES spaces.
      -s, --schema SCHEMA   File containing a JSON Schema (can be specified multiple times to merge schemas).
      -$, --schema-uri SCHEMA_URI
                            The value of the '$schema' keyword (defaults to 'http://json-schema.org/schema#' or can be specified in a schema with the -s option). If 'NULL' is passed, the "$schema" keyword will not be included
                            in the result.
*)
module genson =

    let command (inputFilePath: string) (outputDirectoryPath: string) =
        let inputStem = Path.GetFileNameWithoutExtension inputFilePath

        let outputFilePath = Path.Combine(outputDirectoryPath, $"{inputStem}.schema.json")

        executeProcess python.filePath $""" -m genson "{inputFilePath}" > "{outputFilePath}" """
        |> ignore


genson.command @"D:\Artifact\LCPW_OverlayStormwaterInfrastructure_D_WM.merged.json" @"D:\Artifact"
