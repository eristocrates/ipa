open System
open System.IO

// Strict: keep scheme/host/path structure, and record hash-vs-slash.
let private encodeSegment (segment: string) = Uri.EscapeDataString(segment)

let private decodeSegment (segment: string) = Uri.UnescapeDataString(segment)

let private sanitizeSegment (segment: string) =
    // Keep it conservative: only letters/digits and a small set of safe punctuation.
    // Everything else becomes '_'.
    segment
    |> Seq.map (fun character ->
        if Char.IsLetterOrDigit character
           || character = '.'
           || character = '-'
           || character = '_' then
            character
        else
            '_')
    |> Seq.toArray
    |> String

let private splitPathSegments (path: string) =
    path.Split([| '/' |], StringSplitOptions.RemoveEmptyEntries)
    |> Array.toList
    |> List.map sanitizeSegment

/// Returns a relative directory path + filename.
/// Example:
///   http://www.w3.org/1999/02/22-rdf-syntax-ns#  + "rdf"
/// -> "http/www.w3.org/1999/02/22-rdf-syntax-ns/hash/rdf.fsx"
let iriToRelativePath (namespaceIriString: string) =
    let uri = Uri(namespaceIriString)

    let scheme = [ encodeSegment uri.Scheme ]
    let host = [ encodeSegment uri.Host ]

    let pathSegments =
        splitPathSegments uri.AbsolutePath
        |> List.map encodeSegment

    let delimiterBucket =
        if namespaceIriString.EndsWith("#", StringComparison.Ordinal) then
            [ "hash" ]
        elif namespaceIriString.EndsWith("/", StringComparison.Ordinal) then
            [ "slash" ]
        else
            [ "bare" ]

    let dirs = scheme @ host @ pathSegments @ delimiterBucket

    Path.Combine(dirs |> List.toArray)


let relativePathToIri (relativePath: string) =
    let segments =
        relativePath.Split(
            [| Path.DirectorySeparatorChar
               Path.AltDirectorySeparatorChar |],
            StringSplitOptions.RemoveEmptyEntries
        )
        |> Array.map decodeSegment
        |> Array.toList

    match segments with
    | scheme :: host :: remaining ->
        let pathSegments, delimiter =
            match List.rev remaining with
            | "hash" :: rest -> List.rev rest, "#"
            | "slash" :: rest -> List.rev rest, "/"
            | "bare" :: rest -> List.rev rest, ""
            | _ -> failwith $"Invalid relative path format: {relativePath}"

        let path =
            match pathSegments with
            | [] -> ""
            | _ -> "/" + String.concat "/" pathSegments

        $"{scheme}://{host}{path}{delimiter}"

    | _ -> failwith $"Invalid relative path format: {relativePath}"
