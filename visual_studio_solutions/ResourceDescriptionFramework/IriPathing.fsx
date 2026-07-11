open System
open System.IO

let private sanitizeSegment (s: string) =
    // Keep it conservative: only letters/digits and a small set of safe punctuation.
    // Everything else becomes '_'.
    s
    |> Seq.map (fun c ->
        if Char.IsLetterOrDigit c
           || c = '.'
           || c = '-'
           || c = '_' then
            c
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

    let scheme = sanitizeSegment uri.Scheme // "http" / "https"
    let host = sanitizeSegment uri.Host // "www.w3.org"
    let pathSegments = splitPathSegments uri.AbsolutePath // ["1999"; "02"; ...]

    // Disambiguate namespace delimiter style
    // NOTE: Uri.Fragment is "" for a trailing '#', but the original string *does* end with '#'.
    let delimiterBucket =
        if namespaceIriString.EndsWith("#", StringComparison.Ordinal) then
            "hash"
        elif namespaceIriString.EndsWith("/", StringComparison.Ordinal) then
            "slash"
        else
            "bare"


    // Build relative path with forward slashes; Path.Combine can be used later for OS paths.
    let dirs =
        [ scheme; host ]
        @ pathSegments @ [ delimiterBucket ]

    Path.Combine(dirs |> List.toArray)
