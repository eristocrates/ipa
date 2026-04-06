open System
open System.Linq

// #r "nuget: CaseConverter"
// open CaseConverter

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\StringErgonomics.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PathErgonomics.fsx"

open StringErgonomics
open PathErgonomics


module MediaType =
    module text =
        [<Literal>]
        let turtle = "text/turtle"

        let plain = "text/plain"

    module application =

        let ntriples = "application/n-triples"
        let rdfxml = "application/rdf+xml"
        let trig = "application/trig"
        let nquads = "application/n-quads"
        let ldjson = "application/ld+json"



type Scheme =

    /// Specifies the characters that separate the communication protocol  scheme from the address portion of the IRI.
    static member Delimiter = Uri.SchemeDelimiter
    /// Specifies that the IRI is a pointer to a file.
    static member File = Uri.UriSchemeFile
    /// Specifies that the IRI is accessed through the File Transfer Protocol (FTP).
    static member Ftp = Uri.UriSchemeFtp
    /// Specifies that the IRI is accessed through the File Transfer Protocol Secure (FTPS).
    static member Ftps = Uri.UriSchemeFtps
    /// Specifies that the IRI is accessed through the Gopher protocol.
    static member Gopher = Uri.UriSchemeGopher
    /// Specifies that the IRI is accessed through the Hypertext Transfer Protocol (HTTP).
    static member Http = Uri.UriSchemeHttp
    /// Specifies that the IRI is accessed through the Secure Hypertext Transfer Protocol (HTTPS).
    static member Https = Uri.UriSchemeHttps
    /// Specifies that the IRI is an email address and is accessed through  the Simple Mail Transport Protocol (SMTP).
    static member Mailto = Uri.UriSchemeMailto
    /// Specifies that the IRI is accessed through the NetPipe scheme used  by Windows Communication Foundation (WCF).
    static member NetPipe = Uri.UriSchemeNetPipe
    /// Specifies that the IRI is accessed through the NetTcp scheme used  by Windows Communication Foundation (WCF).
    static member NetTcp = Uri.UriSchemeNetTcp
    /// Specifies that the IRI is an Internet news group and is accessed  through the Network News Transport Protocol (NNTP). This field is  read-only.
    static member News = Uri.UriSchemeNews
    /// Specifies that the IRI is an Internet news group and is accessed  through the Network News Transport Protocol (NNTP). This field is  read-only.
    static member Nntp = Uri.UriSchemeNntp
    /// Specifies that the IRI is accessed through the SSH File Transfer Protocol (SFTP).
    static member Sftp = Uri.UriSchemeSftp
    /// Specifies that the IRI is accessed through the Secure Socket Shell protocol (SSH).
    static member Ssh = Uri.UriSchemeSsh
    /// Specifies that the IRI is accessed through the Telnet protocol.
    static member Telnet = Uri.UriSchemeTelnet
    /// Specifies that the IRI is accessed through the WebSocket protocol (WS).
    static member Ws = Uri.UriSchemeWs
    /// Specifies that the IRI is accessed through the WebSocket Secure protocol (WSS).
    static member Wss = Uri.UriSchemeWss


/// https://www.w3.org/TR/rdf12-concepts/#dfn-rdf-reference
type Iri =
    abstract member iriString: string
    abstract member scheme: string
    abstract member host: string
    abstract member port: int option
    abstract member path: string option
    abstract member pathSegments: string array
    abstract member leaf: string
    abstract member leafSegments: string array
    abstract member query: string option
    abstract member fragment: string option

type NamespaceIri =
    inherit Iri
    abstract member namespaceLabel: string
    abstract member downloadUri: Uri
    abstract member directoryPath: string

type PrefixedIri =
    inherit Iri
    abstract member namespaceIri: NamespaceIri
    abstract member localName: string

let iri_from_uri (uri: Uri) =
    let host = uri.Host


    let port =
        if uri.Port = -1 then
            None
        else
            Some(uri.Port)

    let segmentsFromUri = pathSegments uri.Segments
    let leaf = segmentsFromUri |> Array.last
    let leafSegments = leaf.Split(".")
    let schemeQualifiedHost = $"{uri.Scheme}{Scheme.Delimiter}{uri.Host}/"
    let from_host = schemeQualifiedHost.Length

    let path =
        let pathString =
            if String.IsNullOrWhiteSpace uri.Fragment then

                uri.OriginalString[from_host..]
            else
                uri
                    .OriginalString[ from_host.. ]
                    .Replace(uri.Fragment, "")

        if String.IsNullOrWhiteSpace pathString then
            None
        else
            Some(pathString)



    { new Iri with
        member this.iriString = uri.OriginalString
        member this.scheme = uri.Scheme
        member this.host = uri.Host
        member this.port = port
        member this.path = path
        member this.pathSegments = segmentsFromUri
        member this.leaf = leaf
        member this.leafSegments = leafSegments
        member this.query = nonEmptyString uri.Query
        member this.fragment = nonEmptyString (uri.Fragment.TrimStart('#')) }



let Iri_from_iriString (iriString: string) = iri_from_uri (new Uri(iriString))
