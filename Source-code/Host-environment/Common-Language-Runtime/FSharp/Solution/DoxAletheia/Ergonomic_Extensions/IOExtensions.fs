module DoxAletheia.IOExtensions
open System
open System.IO
open System.IO.Compression
open FsHttp

[<Literal>]
let userAgent =
    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3739.0 Safari/537.36 Edg/75.0.115.0"


module MediaType =
    let any = "*/*"

    module text =
        [<Literal>]
        let turtle = "text/turtle"

        [<Literal>]
        let plain = "text/plain"

        [<Literal>]
        let xml = "text/xml"

        [<Literal>]
        let html = "text/html"

    module application =

        [<Literal>]
        let ntriples = "application/n-triples"

        [<Literal>]
        let rdfxml = "application/rdf+xml"

        [<Literal>]
        let trig = "application/trig"

        [<Literal>]
        let nquads = "application/n-quads"

        [<Literal>]
        let ldjson = "application/ld+json"

        [<Literal>]
        let json = "application/json"

        [<Literal>]
        let xml = "application/xml"

let download_remote_to_local (remote_path: string) (local_path: string) =
    http {
        GET remote_path

    }
    |> Request.send
    |> Response.saveFile local_path


type DirectoryInfo with 
    member this.CreateChildFile (file_name:string) = 
        let file_path = Path.Combine(this.FullName, file_name)
        new FileInfo(file_path)
        member this.CreateChildDirectory(directory_name:string) = this.CreateSubdirectory(directory_name)
        
                


                
let decompress_gzip_file (source_path: string) (destination_path: string) =
    use source_stream = File.OpenRead(source_path)

    use gzip_stream = new GZipStream(source_stream, CompressionMode.Decompress)

    use destination_stream = File.Create(destination_path)

    gzip_stream.CopyTo(destination_stream)








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
let iri_to_relative_path (namespaceIriString: string) =
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


let relative_path_to_iri(relativePath: string) =
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
