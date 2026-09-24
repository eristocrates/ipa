#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Iana.dll"
#r @"TopLevelDomain.dll"
#r @"IanaScheme.dll"
#r @"IanaMime.dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"
#load "Ast.fsx"

open SharedKernel
open StringModule
open Iana

#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"

open System
open System.Globalization
open System.Text
open System.Text.RegularExpressions
open System.Text.Unicode
open System.IO
open System.Web
open System.Linq
open System.Collections
open FSharp.Data
open TextCopy
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleProviders
open System.Text
open System.Net
open System.IO
open Fabulous.AST
open Fantomas.Core
open System.Globalization
open ModelingEvolution.Ipv4
open System.Net.Sockets
open Dubzer.WhatwgUrl
open VDS.Common.Tries
open Meziantou.Framework
open Microsoft.AspNetCore.Http
open ktsu.Semantics.Paths
open Universal.Common
open FolkerKinzel.MimeTypes
open Tavis.UriTemplates
open Humanizer
open CaseConverter
open PuppeteerSharp
open PuppeteerSharp.Cdp
open BrowserApi
open BrowserApi.Common
open System.Collections.Concurrent
open PuppeteerSharp.Cdp.Messaging
open System.Numerics
open System.Threading.Tasks
open WebDriverBiDi
open WebDriverBiDi.Session
open WebDriverBiDi.BrowsingContext
open BrowserApi.Css.Authoring
open IriTools
open Iride
open VDS.RDF
open VDS.RDF.Storage
open RDFSharp.Model
open FsHttp
open System.Net.Http
open VDS.RDF.Parsing
open VDS.RDF.Query.Datasets

open System.Text
open Meziantou.Framework
open VDS.RDF.Writing.Formatting
open VDS.RDF.Writing
open System.Text

let isInRange lower upper value = value >= lower && value <= upper

let isPnCharsBase (rune: Rune) =
    let c = rune.Value

    isInRange 0x0041 0x005A c
    || isInRange 0x0061 0x007A c
    || isInRange 0x00C0 0x00D6 c
    || isInRange 0x00D8 0x00F6 c
    || isInRange 0x00F8 0x02FF c
    || isInRange 0x0370 0x037D c
    || isInRange 0x037F 0x1FFF c
    || isInRange 0x200C 0x200D c
    || isInRange 0x2070 0x218F c
    || isInRange 0x2C00 0x2FEF c
    || isInRange 0x3001 0xD7FF c
    || isInRange 0xF900 0xFDCF c
    || isInRange 0xFDF0 0xFFFD c
    || isInRange 0x10000 0xEFFFF c

let isPnCharsU (rune: Rune) =
    isPnCharsBase rune || rune.Value = 0x005F // _

let isPnChars (rune: Rune) =
    isPnCharsU rune
    || rune.Value = 0x002D // -
    || isInRange 0x0030 0x0039 rune.Value
    || rune.Value = 0x00B7
    || isInRange 0x0300 0x036F rune.Value
    || isInRange 0x203F 0x2040 rune.Value

let isPnLocalFirst (rune: Rune) =
    isPnCharsU rune
    || rune.Value = 0x003A // :
    || isInRange 0x0030 0x0039 rune.Value

let isPnLocalMiddle (rune: Rune) =
    isPnChars rune
    || rune.Value = 0x002E // .
    || rune.Value = 0x003A // :

let isPnLocalLast (rune: Rune) = isPnChars rune || rune.Value = 0x003A // :

let isValidLocalName (local: string) =
    if String.IsNullOrEmpty(local) then
        false
    else
        let runes = local.EnumerateRunes() |> Seq.toArray

        if runes.Length = 0 then
            false
        elif not (isPnLocalFirst runes.[0]) then
            false
        elif runes.Length = 1 then
            true
        else
            let middleValid = runes.[1 .. runes.Length - 2] |> Array.forall isPnLocalMiddle

            middleValid && isPnLocalLast runes.[runes.Length - 1]

let PN_CHARS_BASE: UnicodeRange array = [|
    UnicodeRange(0x0041, 0x005A) // A-Z
    UnicodeRange(0x0061, 0x007A) // a-z
    UnicodeRange(0x00C0, 0x00D6)
    UnicodeRange(0x00D8, 0x00F6)
    UnicodeRange(0x00F8, 0x02FF)
    UnicodeRange(0x0370, 0x037D)
    UnicodeRange(0x037F, 0x1FFF)
    UnicodeRange(0x200C, 0x200D)
    UnicodeRange(0x2070, 0x218F)
    UnicodeRange(0x2C00, 0x2FEF)
    UnicodeRange(0x3001, 0xD7FF)
    UnicodeRange(0xF900, 0xFDCF)
    UnicodeRange(0xFDF0, 0xFFFD)
    UnicodeRange(0x10000, 0xEFFFF)
|]

let PN_CHARS_U: UnicodeRange array = [|
    yield! PN_CHARS_BASE
    UnicodeRange(0x005F, 0x005F) // _
|]

let PN_CHARS: UnicodeRange array = [|
    yield! PN_CHARS_U
    UnicodeRange(0x002D, 0x002D) // -
    UnicodeRange(0x0030, 0x0039) // 0-9
    UnicodeRange(0x00B7, 0x00B7)
    UnicodeRange(0x0300, 0x036F)
    UnicodeRange(0x203F, 0x2040)
|]

let PN_LOCAL_LITERAL: UnicodeRange array = [|
    yield! PN_CHARS
    UnicodeRange(0x002E, 0x002E) // .
    UnicodeRange(0x003A, 0x003A) // :
|]

type TurtleLocalSlugOptions() =
    inherit SlugOptions()

    override _.IsAllowed(rune: Rune) =
        PN_LOCAL_LITERAL
        |> Array.exists (fun range -> rune.Value >= range.Start && rune.Value <= range.End)

let options =
    let slugOptions = TurtleLocalSlugOptions()

    slugOptions.MaximumLength <- 20
    slugOptions.Separator <- "-"
    slugOptions.CanEndWithSeparator <- false
    slugOptions.CasingTransformation <- CasingTransformation.PreserveCase

    slugOptions

open System
open System.Collections.Generic
open System.IO
open System.Text
open System.Text.RegularExpressions
open VDS.RDF
open VDS.RDF.Writing
open VDS.RDF.Writing.Formatting

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
    let sb = StringBuilder(iri.Length)

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

let tryReduceToPrefixOnly (nsMap: INamespaceMapper) (uriOriginal: string) =
    nsMap.Prefixes
    |> Seq.tryPick (fun prefix ->
        nsMap.GetNamespaceUri(prefix)
        |> Option.ofObj
        |> Option.bind (fun namespaceIri ->
            if uriOriginal.Equals(namespaceIri.OriginalString, StringComparison.Ordinal) then
                Some(prefix + ":")
            else
                None))

let tryReduceToPrefixedNameLongest (nsMap: INamespaceMapper) (uriOriginal: string) =
    nsMap.Prefixes
    |> Seq.choose (fun prefix ->
        nsMap.GetNamespaceUri(prefix)
        |> Option.ofObj
        |> Option.map (fun namespaceIri -> prefix, namespaceIri.OriginalString))
    |> Seq.filter (fun (_, namespaceIri) -> uriOriginal.StartsWith(namespaceIri, StringComparison.Ordinal))
    |> Seq.sortByDescending (fun (_, namespaceIri) -> namespaceIri.Length)
    |> Seq.tryPick (fun (prefix, namespaceIri) ->
        let local = uriOriginal.Substring(namespaceIri.Length)

        if isValidLocalName local then
            Some(prefix + ":" + local)
        else
            None)

let tryReduceToPrefixedName (nsMap: INamespaceMapper) (uriOriginal: string) =
    tryReduceToPrefixOnly nsMap uriOriginal
    |> Option.orElseWith (fun () -> tryReduceToPrefixedNameLongest nsMap uriOriginal)
let formatTurtleIri (nsMap: INamespaceMapper) (uri: Uri) =
    match tryReduceToPrefixedName nsMap uri.OriginalString with
    | Some prefixedName -> prefixedName
    | None -> formatIriRefFromOriginalString uri

type UnicodePrefixedNameTurtleW3CFormatter(graph: IGraph) =
    inherit TurtleW3CFormatter(graph)

    override _.IsValidQName(value: string) = isValidPrefixedNameRelaxed value

    override _.FormatUriNode(uriNode: IUriNode, segment: Nullable<TripleSegment>) =
        let uri = uriNode.Uri

        match Option.ofNullable segment with
        | Some TripleSegment.Predicate when uri.OriginalString.Equals("http://www.w3.org/1999/02/22-rdf-syntax-ns#type", StringComparison.Ordinal) -> "a"

        | _ -> formatTurtleIri graph.NamespaceMap uri

    override this.FormatLiteralNode(literalNode: ILiteralNode, segment: Nullable<TripleSegment>) =
        let formatted = base.FormatLiteralNode(literalNode, segment)

        // The base Turtle formatter may serialize a datatype through its own
        // QName / URI machinery. If it actually emitted an explicit ^^ datatype,
        // replace that suffix with our Turtle IRI serialization.
        let datatypeMarker = formatted.LastIndexOf("^^", StringComparison.Ordinal)

        if datatypeMarker < 0 then
            formatted
        else
            let lexicalPart = formatted.Substring(0, datatypeMarker + 2)

            lexicalPart + formatTurtleIri graph.NamespaceMap literalNode.DataType
type IGraph with

    member graph.SaveToTurtle(path: string) =
        Path.GetDirectoryName(path)
        |> Option.ofObj
        |> Option.filter (String.IsNullOrWhiteSpace >> not)
        |> Option.iter (Directory.CreateDirectory >> ignore)

        RDFNamespaceRegister.NamespacesEnumerator.ToList()
        |> Seq.iter (fun rdfNamespace -> graph.NamespaceMap.AddNamespace(rdfNamespace.NamespacePrefix, rdfNamespace.NamespaceUri))

        let formatter = UnicodePrefixedNameTurtleW3CFormatter(graph)

        let usedPrefixes = HashSet<string>(StringComparer.Ordinal)

        let prefixRegex = Regex(@"(?<![A-Za-z0-9_\-])([A-Za-z][A-Za-z0-9_\-]*):", RegexOptions.Compiled)

        let recordUsedPrefixes (formatted: string) =
            prefixRegex.Matches(formatted)
            |> Seq.cast<Match>
            |> Seq.map (fun m -> m.Groups.[1].Value)
            |> Seq.filter graph.NamespaceMap.HasNamespace
            |> Seq.iter (usedPrefixes.Add >> ignore)

        let formatNode (segment: TripleSegment option) (node: INode) =
            let segment = segment |> Option.map Nullable |> Option.defaultValue (Nullable())

            let formatted = formatter.Format(node, segment)

            recordUsedPrefixes formatted

            formatted

        let formattedTriples =
            graph.Triples
            |> Seq.map (fun triple ->
                let subject = formatNode (Some TripleSegment.Subject) triple.Subject

                let predicate = formatNode (Some TripleSegment.Predicate) triple.Predicate

                let object' = formatNode (Some TripleSegment.Object) triple.Object

                subject + " " + predicate + " " + object' + " .")
            |> Seq.toArray

        let usedNamespaces =
            usedPrefixes
            |> Seq.sort
            |> Seq.choose (fun prefix ->
                graph.NamespaceMap.GetNamespaceUri(prefix)
                |> Option.ofObj
                |> Option.map (fun namespaceIri -> prefix, namespaceIri))
            |> Seq.toArray

        use writer = new StreamWriter(path, false, UTF8Encoding(false))

        usedNamespaces
        |> Array.iter (fun (prefix, namespaceIri) ->
            writer.Write("@prefix ")
            writer.Write(prefix)
            writer.Write(": ")
            writer.Write(formatIriRefFromOriginalString namespaceIri)
            writer.WriteLine(" ."))

        if usedNamespaces.Length > 0 then
            writer.WriteLine()

        formattedTriples |> Array.iter writer.WriteLine
