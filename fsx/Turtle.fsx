#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text
open System.Threading
open System.Threading.Tasks

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"

open Ipa

#r "Iana.dll"

open Iana
#r "IanaScheme.dll"
#r "ResolvedResource.dll"
#r "ManualDistributions.dll"
open ManualDistributions

open PuppeteerSharp.Cdp
open PuppeteerSharp
open Meziantou.Framework
open VDS.RDF
open VDS.RDF.Parsing


open VDS.RDF.Parsing
open System.Text
open VDS.RDF.Writing.Formatting
open VDS.RDF.Writing




let syntax = {
    syntaxName = "Turtle"
    fileExtension = ".ttl"
}


let isValidPrefixedNameRelaxed (s: string) =
    if s.Contains(".") then
        true
    else
        TurtleSpecsHelper.IsValidQName(s)

let percentEncodeCharUtf8 (ch: char) =
    Encoding.UTF8.GetBytes([| ch |])
    |> Seq.map (fun b -> "%" + b.ToString("X2"))
    |> String.concat ""

let isForbiddenInTurtleIriRef (ch: char) =
    let code = int ch

    code <= 0x20
    || code = 0x7F
    || ch = '<'
    || ch = '>'
    || ch = '"'
    || ch = '{'
    || ch = '}'
    || ch = '|'
    || ch = '^'
    || ch = '`'
    || ch = '\\'

let escapeIriRefByPercentEncoding (iri: string) =
    let sb = System.Text.StringBuilder(iri.Length)

    for ch in iri do
        if isForbiddenInTurtleIriRef ch then
            sb.Append(percentEncodeCharUtf8 ch) |> ignore
        else
            sb.Append(ch) |> ignore

    sb.ToString()

let formatIriRefFromOriginalString (uri: Uri) =
    "<" + escapeIriRefByPercentEncoding uri.OriginalString + ">"

let isAsciiSafeLocal (local: string) =
    if String.IsNullOrEmpty(local) then
        false
    else
        let isStartOk ch = Char.IsLetterOrDigit(ch) || ch = '_'

        let isRestOk ch =
            Char.IsLetterOrDigit(ch) || ch = '_' || ch = '-' || ch = '.'

        isStartOk local.[0] && local |> Seq.forall isRestOk

let isValidLocalName (local: string) =
    if String.IsNullOrEmpty(local) then
        false
    elif local.Contains("/") then
        false
    else
        TurtleSpecsHelper.IsValidQName("p:" + local) || isAsciiSafeLocal local

let tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
    nsMap.Prefixes
    |> Seq.tryPick (fun (p: string) ->
        let nsUri = nsMap.GetNamespaceUri(p)

        if isNull (box nsUri) then
            None
        else
            let ns = nsUri.OriginalString

            if uriOriginal.Equals(ns, StringComparison.Ordinal) then
                Some(p + ":")
            else
                None)

let tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) : string option =
    let candidates: (string * string) list =
        nsMap.Prefixes
        |> Seq.choose (fun (p: string) ->
            let nsUri = nsMap.GetNamespaceUri(p)

            if isNull (box nsUri) then
                None
            else
                Some(p, nsUri.OriginalString))
        |> Seq.filter (fun (_pfx: string, ns: string) -> uriOriginal.StartsWith(ns, StringComparison.Ordinal))
        |> Seq.sortByDescending (fun (_pfx: string, ns: string) -> ns.Length)
        |> Seq.toList

    let rec pick (xs: (string * string) list) =
        match xs with
        | [] -> None
        | (pfx, ns) :: rest ->
            let local = uriOriginal.Substring(ns.Length)

            if isValidLocalName local then
                Some(pfx + ":" + local)
            else
                pick rest

    pick candidates

let tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
    match tryReduceToPrefixOnly nsMap uriOriginal with
    | Some p -> Some p
    | None -> tryReduceToPrefixedNameLongest nsMap uriOriginal

type UnicodePrefixedNameTurtleW3CFormatter(g: IGraph) =
    inherit TurtleW3CFormatter(g)

    override _.IsValidQName(value: string) = isValidPrefixedNameRelaxed value

    override _.FormatUriNode(u: IUriNode, segment: Nullable<TripleSegment>) =
        let uri = u.Uri

        if
            segment.HasValue
            && segment.Value = TripleSegment.Predicate
            && uri.AbsoluteUri.Equals("http://www.w3.org/1999/02/22-rdf-syntax-ns#type", StringComparison.Ordinal)
        then
            "a"
        else
            match tryReduceToPrefixedName g.NamespaceMap uri.OriginalString with
            | Some prefixedName -> prefixedName
            | None -> formatIriRefFromOriginalString uri

let writeAllPrefixes (tw: TextWriter) (g: IGraph) =
    g.NamespaceMap.Prefixes
    |> Seq.sort
    |> Seq.iter (fun p ->
        let ns = g.NamespaceMap.GetNamespaceUri(p)
        tw.Write("@prefix ")
        tw.Write(p)
        tw.Write(": <")
        tw.Write(ns.OriginalString)
        tw.WriteLine("> ."))

    tw.WriteLine()

let writeIgraph (parentDirectory: string) (stem: string) (namespaceMapper: NamespaceMapper) (graph: VDS.RDF.IGraph) =
    graph.NamespaceMap.Import namespaceMapper

    use fileStream = new FileStream(syntax.filePath parentDirectory stem, FileMode.Create, FileAccess.Write, FileShare.Read)

    use streamWriter = new StreamWriter(fileStream, new UTF8Encoding(false))

    writeAllPrefixes streamWriter graph

    let formatter = UnicodePrefixedNameTurtleW3CFormatter(graph) :> ITripleFormatter

    for triple in graph.Triples do
        streamWriter.WriteLine(formatter.Format(triple))

    streamWriter.Flush()

(*

let writer =
    let writer = new CompressingTurtleWriter(TurtleSyntax.W3C)
    writer.HighSpeedModePermitted <- false
    writer.PrettyPrintMode <- true
    writer

let writeIgraph (parentDirectory: string) (stem: string) (graph: VDS.RDF.IGraph) =
    mapPrefixes graph
    writer.Save(graph, syntax.filePath parentDirectory stem)
*)
