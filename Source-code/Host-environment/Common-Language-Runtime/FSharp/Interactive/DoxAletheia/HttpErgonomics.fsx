open System
#r "nuget: FsHttp"

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
