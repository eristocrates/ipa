open System
open System.IO

let invalid_directory_path_char_set = Path.GetInvalidPathChars() |> Set.ofArray
let invalid_file_name_char_set = Path.GetInvalidFileNameChars() |> Set.ofArray

let sanitize_path (raw_path: string) (replacement: char) =
    // Isolate invalid characters for both paths and filenames
    let invalidPathChars = Path.GetInvalidPathChars()
    let invalidFileChars = Path.GetInvalidFileNameChars()

    let sanitizePart (part: string) (invalidChars: char array) =
        // Replaces each invalid character with the designated replacement
        Array.fold (fun (acc: string) (c: char) -> acc.Replace(c, replacement)) part invalidChars

    let directory = Path.GetDirectoryName(raw_path)
    let fileName = Path.GetFileName(raw_path)

    let sanitizedDir = sanitizePart directory invalidPathChars
    let sanitizedFile = sanitizePart fileName invalidFileChars

    Path.Combine(sanitizedDir, sanitizedFile)

let ensure_path (raw_path: string) : string =
    let sanitized_path = sanitize_path raw_path '_'

    if
        not (String.IsNullOrWhiteSpace(sanitized_path))
        && not (Directory.Exists(sanitized_path))
    then
        Directory.CreateDirectory(sanitized_path)
        |> ignore

    sanitized_path
