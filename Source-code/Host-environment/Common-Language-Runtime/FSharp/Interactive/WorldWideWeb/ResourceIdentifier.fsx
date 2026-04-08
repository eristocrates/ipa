open System
open System.Linq

// #r "nuget: CaseConverter"
// open CaseConverter

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\StringErgonomics.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PathErgonomics.fsx"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\WorldWideWeb\URISchemes.fsx"

open URISchemes

open StringErgonomics
open PathErgonomics

/// https://www.rfc-editor.org/rfc/rfc3986#section-3.2
type Authority =
    abstract member userinfo: string option
    abstract member host: string
    abstract member port: int option
    abstract member asString: string

// TODO Use URI with webservices
// find a way to map to FileSystemPaths
type URI =
    abstract member scheme: Scheme
    abstract member authority: Authority
    abstract member path: HierarchicalPath
    abstract member query: string option
    abstract member fragment: string option

/// https://www.w3.org/TR/rdf12-concepts/#dfn-rdf-reference
type Iri =
    abstract member iriString: string
    abstract member scheme: Scheme
    abstract member host: Authority option
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

    let segmentsFromUri = directoryPathTokens_from_uriSegments uri.Segments
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
