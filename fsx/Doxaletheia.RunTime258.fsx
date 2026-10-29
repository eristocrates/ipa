module DoxAletheia.Runtime

open System
open System.Text
open System.Xml
open System.Xml.Linq
open System.IO
open System.Collections

open FSharpPlus
open Microsoft.FSharp.Quotations
open VDS.RDF
open VDS.RDF.Ontology
open VDS.RDF.Parsing

open Microsoft.FSharp.Quotations
open IriTools
open System.Globalization
open RDFSharp.Model
open System.Security.Cryptography
open NLanguageTag
open AngleSharp
open FSharp.Data
open FolkerKinzel.MimeTypes
open NuGet.Common
open NuGet.Protocol
open NuGet.Protocol.Core.Types
open NuGet.Protocol.Resources
open AW.Identifiers
open TypeShape
open TypeShape.Core
open VDS.Common.Tries
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleParsers
open Nager.PublicSuffix.RuleProviders
open Tavis.UriTemplates
open Meziantou.Framework
open Nager.PublicSuffix
open System.Threading.Tasks
open System.Text.RegularExpressions
open Flurl
open Ada.Url
open Dubzer.WhatwgUrl
open AngleSharp.Html
open NuGet.Common
open NuGet.Protocol
open NuGet.Protocol.Core.Types
open NuGet.Protocol.Resources
open ShapeSifter
open TypeShape.Core
open System.Reflection
open Microsoft.FSharp.Linq.RuntimeHelpers
open HCollections
open Microsoft.FSharp.Reflection
open TypeEquality
open FSharp.SystemTextJson
open System.Text.Json
open System.Text.Json.Serialization
open DynamicObj

module FSharpLiteral = FSharp.Literals.Literal
let domainParser =
    lazy
        let ruleProvider = new SimpleHttpRuleProvider()
        ruleProvider.BuildAsync().GetAwaiter().GetResult() |> ignore
        DomainParser(ruleProvider)

let pathDelimiters = [| '/'; '\\'; ':'; '#' |]
let lexicalDelimiters = [| '-'; '.'; '+'; '/'; '#' |]
type NonNegativeInteger = uint32

let utf8Encoding =
    UTF8Encoding(encoderShouldEmitUTF8Identifier = false, throwOnInvalidBytes = true)

let escapedSurrogatePair =
    Regex(
        @"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})",
        RegexOptions.Compiled ||| RegexOptions.CultureInvariant
    )

type GraphemeCluster = { glyph: string; runes: Rune array }

type Option<'Type> with
    static member ofNullOrWhiteSpace(value: 'Type) =
        if String.IsNullOrWhiteSpace(string value) then
            None
        else
            Some value

    static member tryNullOrWhiteSpace(maybeValue: 'Type option) =
        match maybeValue with
        | Some value when String.IsNullOrWhiteSpace(string value) -> None
        | None -> None
        | Some value -> Some value

type Task<'OutputType> with
    member this.await = this.GetAwaiter().GetResult()

type Task with
    member this.await = this.GetAwaiter().GetResult()

let await (operation: Task<'OutputType>) : 'OutputType = operation.GetAwaiter().GetResult()

let awaitUnit (task: Task) = task.GetAwaiter().GetResult()

module String =

    module subString =
        let fromLast (delimeter: string) (superString: string) =
            match superString.LastIndexOf(delimeter) with
            | -1 -> None
            | index -> Some(superString.Substring(index + 1))

        let fromCircumfix (prefix: string) (superstring: string) (suffix: string) =
            match superstring.IndexOf(prefix) + 1, superstring.LastIndexOf(suffix) - 1 with
            | -1, -1 -> None
            | fromPrefix, toSuffix -> Some(superstring[fromPrefix..toSuffix])

        let firstBefore (delimiter: string) (superstring: string) =
            match superstring.IndexOf delimiter with
            | -1 -> None
            | delimiterIndex ->
                let to_delimiter = delimiterIndex - 1
                let substring = superstring.[..to_delimiter]
                Some(substring)

    let untilCharacter (delimiterCharacter: char) (superstring: string) =
        superstring.ToCharArray()
        |> Array.takeWhile (fun character -> character <> delimiterCharacter)
        |> System.String

    let trimmed (text: string) = text.TrimStart().TrimEnd()

    let rev (text: string) =
        text.ToCharArray() |> Array.rev |> String

    /// just a crumb of humor to lighten the day
    let gnirts (text: string) = rev text

    let prepostfix (prefix: string) (text: string) (postfix: string) = prefix + text + postfix
    let circumfix (affix: string) (text: string) = prepostfix affix text affix
    let prefix (affix: string) (text: string) = prepostfix affix text String.Empty
    let postfix (affix: string) (text: string) = prepostfix String.Empty text affix
    let runes (text: string) = text.EnumerateRunes() |> Seq.toArray

    let textElements (text: string) =
        let enumerator = StringInfo.GetTextElementEnumerator(text)

        seq {

            while enumerator.MoveNext() do
                let element = enumerator.GetTextElement()
                yield element
        }
        |> Seq.toArray

    let graphemeClusters (text: string) =
        textElements text
        |> Array.map (fun textElement ->
            { glyph = textElement
              runes = runes textElement })

    let tryGraphemeCluster (text: string) =
        match graphemeClusters text with
        | [| graphemeCluster |] -> Some graphemeCluster
        | _ -> None

    let normalizeEscapedSurrogatePairs (text: string) =
        if text.IndexOf(@"\uD", StringComparison.OrdinalIgnoreCase) < 0 then
            text
        else
            escapedSurrogatePair.Replace(
                text,
                MatchEvaluator(fun matched ->
                    let high = Convert.ToInt32(matched.Groups.[1].Value, 16) |> char

                    let low = Convert.ToInt32(matched.Groups.[2].Value, 16) |> char

                    Char.ConvertToUtf32(high, low) |> sprintf "\\U%08X")
            )

    let pathTokens (text: string) =
        text.Split(pathDelimiters, StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofNullOrWhiteSpace segment)

    let lexicalTokens (text: string) =
        text.Split(lexicalDelimiters, StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofNullOrWhiteSpace segment)

    let asUtf8 (text: string) =
        Encoding.UTF8.GetBytes(text.ToCharArray())

type String with
    member this.trimmed = String.trimmed this
    member this.rev = String.rev this
    /// just a crumb of humor to lighten the day
    member this.gnirts = this.rev
    member this.prefix(affix: string) = String.prefix affix this
    member this.postfix(affix: string) = String.postfix affix this
    member this.circumfix(affix: string) = String.prepostfix affix this affix
    member this.prepostfix(prefix: string, postfix: string) = String.prepostfix prefix this postfix
    member this.runes = String.runes this
    member this.graphemeClusters = String.graphemeClusters this
    member this.tryGraphemeCluster = String.tryGraphemeCluster this
    member this.normalizeEscapedSurrogatePairs = String.normalizeEscapedSurrogatePairs this
    member this.pathTokens = String.pathTokens this
    member this.lexicalTokens = String.lexicalTokens this
    member this.asUtf8 = String.asUtf8 this

module Rune =
    let codePoint (rune: Rune) = rune.Value
    let hexName (rune: Rune) = sprintf "%04X" rune.Value
    let UHexName (rune: Rune) = hexName rune |> String.prefix "U+"

    let UnicodeCategory (rune: Rune) =
        CharUnicodeInfo.GetUnicodeCategory rune.Value

type Rune with
    member this.UnicodeCategory = Rune.UnicodeCategory this
    member this.codePoint = Rune.codePoint this
    member this.hexName = Rune.hexName this
    member this.UHexName = Rune.UHexName this

module GraphemeCluster =

    let tryHtmlName (graphemeCluster: GraphemeCluster) =
        match HtmlEntityProvider.ReverseResolver.GetName(graphemeCluster.glyph) with
        | null -> None
        | name -> Some(name.TrimEnd ';')

    let tryHtmlEntity (graphemeCluster: GraphemeCluster) =
        tryHtmlName graphemeCluster
        |> Option.map (fun name -> name.prepostfix ("&", ";"))

    let hexName (graphemeCluster: GraphemeCluster) =
        graphemeCluster.runes
        |> Array.map (fun rune -> rune.hexName)
        |> String.concat " "

    let UHexName (graphemeCluster: GraphemeCluster) =
        graphemeCluster.runes
        |> Array.map (fun rune -> rune.UHexName)
        |> String.concat " "

type GraphemeCluster with
    member this.tryHtmlName = GraphemeCluster.tryHtmlName this
    member this.tryHtmlEntity = GraphemeCluster.tryHtmlEntity this
    member this.hexName = GraphemeCluster.hexName this
    member this.UHexName = GraphemeCluster.UHexName this

module Char =
    let graphemeCluster (character: char) =
        string character |> String.tryGraphemeCluster |> Option.get

    let tryHtmlName (character: char) =
        graphemeCluster character |> GraphemeCluster.tryHtmlName

    let tryHtmlEntity (character: char) =
        graphemeCluster character |> GraphemeCluster.tryHtmlEntity

    let hexName (character: char) =
        graphemeCluster character |> GraphemeCluster.hexName

    let UHexName (character: char) =
        graphemeCluster character |> GraphemeCluster.UHexName

    let decimalEntity (character: char) = sprintf "&#%i;" (int character)
    let hexadecimalEntity (character: char) = sprintf "&#%i;" (int character)

type Char with
    member this.graphemeCluster = Char.graphemeCluster this
    member this.tryHtmlName = Char.tryHtmlName this

    member this.tryHtmlEntity = Char.tryHtmlEntity this
    member this.hexName = Char.hexName this
    member this.UHexName = Char.UHexName this

type Guid with
    member this.asString = this.ToString("N")
    member this.asHyphenatedString = this.ToString("D")
    member this.asHyphenatedBracedString = this.ToString("B")
    member this.asHyphenatedParenthesizedString = this.ToString("P")
    member this.asHexString = this.ToString("X")

type FileInfo with
    member this.stem = Path.GetFileNameWithoutExtension this.Name
    member this.stemPath = Path.Combine(this.DirectoryName, this.stem)

type DriveInfo with
    static member byLetter =
        DriveInfo.GetDrives()
        |> Array.map (fun hardDrive -> hardDrive.Name[0], hardDrive)
        |> Map.ofArray

    static member preferredDrive =
        match DriveInfo.byLetter.TryFind 'D' with
        | Some drive -> drive
        | None -> DriveInfo.byLetter['C']

type Guid with
    static member ensure(stringValue: string) =
        match Guid.TryParse stringValue with
        | true, guid -> guid
        | false, _ -> new Guid(MD5.HashData(Encoding.UTF8.GetBytes(stringValue)))

type Uri with

    member this.localPart =
        match Option.ofNullOrWhiteSpace this.Fragment with
        | Some fragment -> fragment.TrimStart('#')
        | None -> this.Segments |> Array.last |> _.TrimStart('/')

module Set =
    type OneOrMore<'SetElement when 'SetElement: comparison> =
        private
        | OneOrMoreElements of Set<'SetElement>

        static member One(one: 'SetElement) =
            one |> Set.singleton |> OneOrMoreElements

        static member More(one: 'SetElement, more: Set<'SetElement>) =
            more |> Set.add one |> OneOrMoreElements

        static member More(one: 'SetElement) =
            fun (more: Set<'SetElement>) -> OneOrMore.More(one, more)

        static member ofSet(elements: Set<'SetElement>) =
            if Set.isEmpty elements then
                invalidArg (nameof elements) "OneOrMore requires at least one element."

            OneOrMoreElements elements

        member this.elements =
            let (OneOrMoreElements elements) = this
            elements

    and TwoOrMore<'SetElement when 'SetElement: comparison> =
        private
        | TwoOrMoreElements of Set<'SetElement>

        static member private Create(elements: Set<'SetElement>) =
            if Set.count elements < 2 then
                invalidArg (nameof elements) "TwoOrMoreElements requires at least two distinct elements."

            TwoOrMoreElements elements

        static member Two(one: 'SetElement, two: 'SetElement) = Set [ one; two ] |> TwoOrMore.Create

        static member Two(one: 'SetElement) =
            fun (two: 'SetElement) -> TwoOrMore.Two(one, two)

        static member More(one: 'SetElement, two: 'SetElement, more: Set<'SetElement>) =
            more |> Set.add two |> Set.add one |> TwoOrMore.Create

        static member More(one: 'SetElement) =
            fun (two: 'SetElement) ->
                fun (more: Set<'SetElement>) -> more |> Set.add two |> Set.add one |> TwoOrMore.Create

        member this.elements =
            let (TwoOrMoreElements elements) = this
            elements

        static member map (mapping: 'Value -> 'MappedValue) (values: TwoOrMore<'Value>) : TwoOrMore<'MappedValue> =
            let mapped = values.elements |> Set.map mapping
            let mappedArray = mapped |> Set.toArray

            if mappedArray.Length < 2 then
                invalidOp "map collapsed a two-or-more collection to fewer than two distinct values."

            TwoOrMore.More(mappedArray[0], mappedArray[1], mappedArray[2..] |> Set.ofArray)

module List =
    type OneOrMore<'ListItem> =
        private
        | OneOrMoreItems of 'ListItem list

        static member One(one: 'ListItem) = OneOrMoreItems [ one ]

        static member More(head: 'ListItem, tail: 'ListItem list) = head :: tail |> OneOrMoreItems
        static member More(tail: 'ListItem list, tip: 'ListItem) = tail @ [ tip ] |> OneOrMoreItems

        static member More(head: 'ListItem) =
            fun (tail: 'ListItem list) -> OneOrMore.More(head, tail)

        static member More(tail: 'ListItem list) =
            fun (tip: 'ListItem) -> OneOrMore.More(tail, tip)

        member this.items: 'ListItem list =
            let (OneOrMoreItems items) = this
            items

    and TwoOrMore<'ListItem> =
        private
        | TwoOrMoreItems of 'ListItem list

        static member Two(one: 'ListItem, two: 'ListItem) = [ one; two ] |> TwoOrMoreItems

        static member Two(one: 'ListItem) =
            fun (two: 'ListItem) -> TwoOrMore.Two(one, two)

        static member More(one: 'ListItem, two: 'ListItem, more: 'ListItem list) = one :: two :: more |> TwoOrMoreItems

        static member More(one: 'ListItem) =
            fun (two: 'ListItem) -> fun (more: 'ListItem list) -> TwoOrMore.More(one, two, more)

        static member More(more: 'ListItem list) =
            fun (one: 'ListItem) -> fun (two: 'ListItem) -> more @ [ one; two ] |> TwoOrMoreItems

        member this.items =
            let (TwoOrMoreItems items) = this
            items

let dotNetRdfLoader = Loader()

type RdfConformance =
    | FullNormativeConformance
    | BasicNormativeConformance
    | NonNormativeNonConformance

module private Unsafe =
    let inline cast<'FromType, 'ToType> (fromValue: 'FromType) : 'ToType =
#if !FABLE_COMPILER
        // virtually undocumented inline MSIL escape hatch that technically allows for declaring arbitrary type conversions to accomodate for typing manual IL operations
        // the (# "il instructions" value : Type #) construct is found all over FSharp.Core, and at least mentioned in some articles like https://dev.to/entomy/cs-generic-math-from-f-31a7
        // but by passing no actual IL code in the quotes, the same input value can be effectively retyped at will
        // the developer is taking manual responsibility for ensuring both types are aliases of one another, to accompilsh conversion without runtime exceptions.

        (# "" fromValue : 'ToType #)
#else
        unbox<'ToType> fromValue
#endif

[<AutoOpen>]
[<MeasureAnnotatedAbbreviation>]
type string<[<Measure>] 'DatatypeMeasure> = string

type UMX =
    static member inline tag<[<Measure>] 'DatatypeMeasure>(x: string) : string<'DatatypeMeasure> = Unsafe.cast x
    static member inline untag<[<Measure>] 'DatatypeMeasure>(x: string<'DatatypeMeasure>) : string = Unsafe.cast x

    static member inline cast<[<Measure>] 'FromDatatypeMeasure, [<Measure>] 'ToDatatypeMeasure>
        (literal: string<'FromDatatypeMeasure>)
        : string<'ToDatatypeMeasure> =
        Unsafe.cast literal

module Operators =
    let inline private _cast< ^TC, ^xm, ^xn when (^TC or ^xm or ^xn): (static member cast: ^xm -> ^xn)> (x: ^xm) =
        ((^TC or ^xm or ^xn): (static member cast: ^xm -> ^xn) x)
    // NB the particular infix operator shadows the rarely used quotation splicing operator
    /// Infix operator used for tagging, untagging, or casting units of measure
    let inline (~%) (x: string) : string<'DatatypeMeasure> =
        _cast<UMX, string, string<'DatatypeMeasure>> x
type FSharpRecord<'RecordType> =
    private
    | FSharpRecord of 'RecordType

    member this.value =
        let (FSharpRecord value) = this
        value
    static member Parse
        (value : 'RecordType)
        : FSharpRecord<'RecordType>
        =

        match shapeof<'RecordType> with

        | Shape.FSharpRecord
            (:? ShapeFSharpRecord<'RecordType>) ->

            FSharpRecord value

        | _ ->

            invalidArg
                (nameof value)
                $"{typeof<'RecordType>.FullName} is not an F# record."

    member this.fieldStrings : (string * string) list =

        let value =
            this.value

        match shapeof<'RecordType> with

        | Shape.FSharpRecord
            (:? ShapeFSharpRecord<'RecordType> as recordShape) ->

            recordShape.Fields
            |> Array.map (fun field ->

                field.Accept {
                    new IReadOnlyMemberVisitor<'RecordType, string * string> with

                        member _.Visit<'FieldType>
                            (field : ReadOnlyMember<'RecordType, 'FieldType>)
                            =

                            let fieldValue : 'FieldType =
                                field.Get value

                            let fieldString =
                                if
                                    typeof<'FieldType>.IsGenericType
                                    &&
                                    typeof<'FieldType>.GetGenericTypeDefinition()
                                        = typedefof<list<_>>
                                then

                                    fieldValue
                                    |> box
                                    |> unbox<System.Collections.IEnumerable>
                                    |> Seq.cast<obj>
                                    |> Seq.map string
                                    |> String.concat ","

                                else
                                    string fieldValue

                            field.Label, fieldString
                }
            )
            |> Array.toList

        | _ ->
            invalidOp
                $"FSharpRecord<{typeof<'RecordType>.FullName}> contains a non-record value."

    member this.jsonString =
        let jsonSerializerOptions =
            JsonFSharpOptions.Default()
                .ToJsonSerializerOptions()
        jsonSerializerOptions.NumberHandling  <- JsonNumberHandling.AllowNamedFloatingPointLiterals
        jsonSerializerOptions.ReferenceHandler <- ReferenceHandler.Preserve

        JsonSerializer.Serialize(
            this.value,            
            jsonSerializerOptions
        )
type LanguageTag with
    member this.identity = this.ToString().ToLowerInvariant()

type InitialTextDirection =
    | Ltr
    | Rtl

    static member tryParse(rawString: string) =
        match rawString.ToLowerInvariant() with
        | "ltr" -> Some Ltr
        | "rtl" -> Some Rtl
        | _ -> None

    member this.identity = this.ToString().ToLowerInvariant()

type PublicSuffix =
    | TopLevelDomainRule of TldRule

    member this.domain(label: string) =
        { topLevelDomain = this
          secondLevelDomain = label
          subdomainLabels = [] }

    static member (.+)(suffix: PublicSuffix, label: string) =
        { topLevelDomain = suffix
          secondLevelDomain = label
          subdomainLabels = [] }

    static member (+.)(label: string, suffix: PublicSuffix) =
        { topLevelDomain = suffix
          secondLevelDomain = label
          subdomainLabels = [] }

    static member ofDomainInfo(domainInfo: DomainInfo) =
        TopLevelDomainRule domainInfo.TopLevelDomainRule

    static member ofRule(rule: string) = TopLevelDomainRule(TldRule rule)

    member this.rule =
        match this with
        | TopLevelDomainRule rule -> rule

    member this.division = this.rule.Division
    member this.name = this.rule.Name
    member this.ruleType = this.rule.Type
    member this.labelCardinality = this.rule.LabelCount
    member this.labels = this.name.Split(".")
    member this.reverseName = this.labels |> Array.rev |> String.concat "."

and Domain =
    { topLevelDomain: PublicSuffix
      secondLevelDomain: string
      subdomainLabels: string list }

    member this.labels =
        Array.concat
            [ this.subdomainLabels |> List.toArray
              [| this.secondLevelDomain |]
              this.topLevelDomain.labels ]

    member this.subdomain =
        if this.subdomainLabels.Length > 0 then
            this.subdomainLabels |> String.concat "."
        else
            String.Empty

    member this.domainName =
        List.concat [ this.subdomainLabels; [ this.secondLevelDomain; this.topLevelDomain.name ] ]
        |> String.concat "."

    member this.reverseDomainName =
        List.concat
            [ [ this.topLevelDomain.name; this.secondLevelDomain ]
              this.subdomainLabels |> List.rev ]
        |> String.concat "."

    static member (+.)(domain: Domain, subdomain: string) =
        { domain with
            subdomainLabels = domain.subdomainLabels @ [ subdomain ] }

    static member (.+)(subdomain: string, domain: Domain) =
        { domain with
            subdomainLabels = domain.subdomainLabels @ [ subdomain ] }

    member this.www =
        { this with
            subdomainLabels = [ "www" ] }

module Iana =
    type ProtocolClass =
        | Group of int
        | Registry of int

    type ProtocolRegistryEntry =
        { group: string
          name: string
          localName: string
          documentation: string
          references: string array
          comment: string }

    type Status =
        | Permanent
        | Provisional
        | Historical
        | UnknownStatus of string

        static member ofString(status: string) =
            match status with
            | "Permanent" -> Permanent
            | "Provisional" -> Provisional
            | "Historical" -> Historical
            | unknown -> UnknownStatus unknown

    [<RequireQualifiedAccess>]
    type XRef =
        | draft of _data: string
        | person of _data: string
        | registry of _data: string
        | rfc of _data: string * _value: string option
        | uri of _data: string * _value: string option
        | unknown of _type: string * _data: string * _value: string option

        static member ofElement(_type: string, _data: string, _value: string option) =
            match _type with
            | "draft" -> XRef.draft _data
            | "person" -> XRef.person _data
            | "registry" -> XRef.registry _data
            | "rfc" -> XRef.rfc (_data, _value)
            | "uri" -> XRef.uri (_data, _value)
            | _ -> XRef.unknown (_type, _data, _value)

    type ProtocolScheme =
        { name: string
          date: DateTime option
          updated: DateTime option
          fileTemplate: string option
          description: string option
          status: Status option
          cri: int option
          wellKnown: XRef option
          references: XRef array
          notes: string option }

        static member ByName =
            XmlProvider<UseOriginalNames=true, Sample= @"D:\ftp\org\iana\assignments\uri-schemes\uri-schemes.xml">
                .Load(@"D:\ftp\org\iana\assignments\uri-schemes\uri-schemes.xml")
                .registries
            |> Array.filter (fun registry -> registry.title = "Uniform Resource Identifier (URI) Schemes")
            |> Array.collect (fun schemeRegistry ->

                schemeRegistry.records
                |> Array.distinctBy (fun scheme -> scheme.value.Value.XElement.Value)
                // |> Array.Parallel.filter (fun scheme -> not (scheme.value.Value.XElement.Value.Contains("OBSOLETE")))
                |> Array.map (fun record ->

                    let namespaceName = record.XElement.Name.NamespaceName
                    let value = record.value.Value.XElement.Value

                    let file =
                        match record.file with
                        | Some file -> file.Value
                        | None -> None

                    let description =
                        if record.description.Value.Value.Value = value then
                            None
                        else
                            Some record.description.Value.Value.Value

                    let wellKnown =
                        match record.``well-known`` with
                        | Some wellKnown ->
                            try
                                Some(XRef.ofElement (wellKnown.xref.``type``, wellKnown.xref.data, None))
                            with _ ->
                                None
                        | _ -> None

                    let references =
                        match record.xrefs with
                        | [||] -> [||]
                        | xrefs ->
                            xrefs
                            |> Array.map (fun xref -> XRef.ofElement (xref.``type``, xref.data, xref.Value))

                    let notes =
                        match record.notes with
                        | Some notes when not (String.IsNullOrWhiteSpace notes.XElement.Value) ->
                            Some notes.XElement.Value
                        | _ -> None

                    { date = record.date
                      updated = record.updated
                      fileTemplate = file
                      name = value
                      description = description
                      status = Status.ofString record.status.Value |> Some
                      cri = Some record.cri.Value
                      wellKnown = wellKnown
                      references = references
                      notes = notes }
                    : ProtocolScheme))
            |> Array.map (fun protocolScheme -> protocolScheme.name, protocolScheme)
            |> Map.ofArray

        static member ofString(scheme: string) =
            match ProtocolScheme.ByName.TryFind scheme with
            | Some protocolScheme -> protocolScheme
            | None ->

                { name = scheme
                  date = None
                  updated = None
                  fileTemplate = None
                  description = None
                  status = None
                  cri = None
                  wellKnown = None
                  references = [||]
                  notes = None }

        static member op_Implicit(scheme: string) = ProtocolScheme.ofString scheme
        static member op_Implicit(scheme: ProtocolScheme) = scheme.name

    [<RequireQualifiedAccess>]
    type TopLevelMediaType =
        /// RFC 2046
        /// Application Media Types
        | application
        /// RFC 2046
        /// Audio Media Types
        | audio
        /// RFC 4735
        /// Example Media Types	no registrations, for examples only
        | example
        /// RFC 8081
        /// Font Media Types
        | font
        /// RFC 9695
        /// Haptics Media Types
        | haptics
        /// RFC 2046
        /// Image Media Types
        | image
        /// RFC 2046
        /// Message Media Types
        | message
        /// RFC 2077
        /// Model Media Types
        | model
        /// RFC 2046
        /// Multipart Media Types
        | multipart
        /// RFC 2046
        /// Text Media Types	requires CRLF for newlines
        | text
        /// RFC 2046
        /// Video Media Types
        | video
        | additional of string

        static member ofMimeType(mime: MimeType) =
            match mime.MediaType with
            | "application" -> application
            | "audio" -> audio
            | "example" -> example
            | "font" -> font
            | "haptics" -> haptics
            | "image" -> image
            | "message" -> message
            | "model" -> model
            | "multipart" -> multipart
            | "text" -> text
            | "video" -> video
            | mediaType -> additional mediaType

    /// https://www.rfc-editor.org/info/rfc6838/#section-3
    [<RequireQualifiedAccess>]
    type RegistrationTree =
        /// https://www.rfc-editor.org/info/rfc6838/#section-3.1
        | Standards
        /// https://www.rfc-editor.org/info/rfc6838/#section-3.2
        | Vendor
        /// https://www.rfc-editor.org/info/rfc6838/#section-3.3
        | Personal
        /// https://www.rfc-editor.org/info/rfc6838/#section-3.4
        | Unregistered
        | Additional of string

        static member ofMimeType(mime: MimeType) =
            match mime.SubType.IndexOf(".") with
            | -1 -> Standards
            | dotIndex ->
                match mime.SubType[..dotIndex] with
                | "vnd." -> Vendor
                | "prs." -> Personal
                | "x." -> Unregistered
                | tree -> Additional tree

    /// https://www.rfc-editor.org/info/rfc6838/#section-4.2.8
    type StructuredSyntaxNameSuffix =
        | NameSuffix of string

        static member tryMimeType(mime: MimeType) =
            match mime.SubType.IndexOf("+") with
            | -1 -> None
            | plusIndex -> Some(NameSuffix mime.SubType[plusIndex + 1 ..])

    and InternetMediaType =
        { topLevelMediaType: TopLevelMediaType
          registrationTree: RegistrationTree
          mimeType: MimeType
          suffix: StructuredSyntaxNameSuffix option
          references: XRef array

        }

        static member ofMimeType(mime: MimeType) =
            { topLevelMediaType = TopLevelMediaType.ofMimeType mime
              registrationTree = RegistrationTree.ofMimeType mime
              mimeType = mime
              suffix = StructuredSyntaxNameSuffix.tryMimeType mime
              references = [||]

            }

        static member ofExtension(extension: string) =
            MimeType.FromFileName extension |> InternetMediaType.ofMimeType

        static member ofContentType(contentType: string) =
            MimeType.Parse contentType |> InternetMediaType.ofMimeType

        static member ofRegistryRecord(contentType: string, references: XRef array) =
            { InternetMediaType.ofContentType contentType with
                references = references }

        member this.contentType = this.mimeType.ToString()
        member this.extension = this.mimeType.GetFileTypeExtension(false)
        member this.dotExtension = this.mimeType.GetFileTypeExtension(true)

        member this.tokens =
            let contentType = this.contentType
            let tokens = contentType.lexicalTokens

            match contentType[contentType.Length - 1] with
            | terminal when Char.IsLetterOrDigit terminal -> tokens
            | '+' -> Array.append tokens [| "plus" |]
            | terminal -> Array.append tokens [| $"U{int terminal:X4}" |]

[<CustomEquality; CustomComparison>]
type Iri =
    | IRIREF of IriReference
    | Irl of Irl
    | Irn of Irn
    | SkolemIri of BNode
    | PrefixedName of PrefixedName

    member this.asSubject = IriSubject this
    member this.asPredicate = IriPredicate this
    member this.asObject = IriObject this |> BasicNormativeObject

    static member op_Implicit(iriReference: IriReference) = IRIREF iriReference
    static member op_Implicit(irl: Irl) = Irl irl
    static member op_Implicit(irn: Irn) = Irn irn
    static member op_Implicit(prefixedName: PrefixedName) = PrefixedName prefixedName
    static member op_Implicit(iri: Iri) = iri.identity
    static member ref(iriString: string) = IriReference iriString |> IRIREF
    static member op_Implicit(iriString: string) = Iri.ref iriString
    static member toUri(iri: Iri) = Uri iri.identity
    member this.asUri = Iri.toUri this
    member this.asIriReference = IriReference this.identity
    static member op_Implicit(iri: Iri) = iri.asUri
    static member ofUri(uri: Uri) = IriReference uri |> IRIREF
    static member op_Implicit(uri: Uri) = Iri.ofUri uri

    member this.isInVocabulary(vocabulary: RdfVocabulary) =
        this.identity.StartsWith(vocabulary.identity, StringComparison.Ordinal)

    member this.tryPrefixedName(vocabulary: RdfVocabulary) =
        if this.isInVocabulary vocabulary then
            Some(vocabulary.prefixedName this.identity[vocabulary.identity.Length ..])
        else
            None

    member this.localPart = this.asUri.localPart

    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Iri)) =
        Functional.AnnotationAssertion(annotationProperty, IriSubject this, IriObject annotationObject)

    member this.Annotation(annotationObject: Iri) =
        fun (annotationProperty: AnnotationProperty) ->
            Functional.AnnotationAssertion(annotationProperty, IriSubject this, IriObject annotationObject)

    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: BNode)) =
        Functional.AnnotationAssertion(annotationProperty, IriSubject this, BNodeObject annotationObject)

    member this.Annotation(annotationObject: BNode) =
        fun (annotationProperty: AnnotationProperty) ->
            Functional.AnnotationAssertion(annotationProperty, IriSubject this, BNodeObject annotationObject)

    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Literal)) =
        Functional.AnnotationAssertion(annotationProperty, IriSubject this, LiteralObject annotationObject)

    member this.Annotation(annotationObject: Literal) =
        fun (annotationProperty: AnnotationProperty) ->
            Functional.AnnotationAssertion(annotationProperty, IriSubject this, LiteralObject annotationObject)

    member this.label(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.rdfs'label, annotationObject)

    member this.label(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.rdfs'label, annotationObject)

    member this.label(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.rdfs'label, annotationObject)

    member this.comment(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.rdfs'comment, annotationObject)

    member this.comment(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.rdfs'comment, annotationObject)

    member this.comment(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.rdfs'comment, annotationObject)

    member this.seeAlso(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.rdfs'seeAlso, annotationObject)

    member this.seeAlso(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.rdfs'seeAlso, annotationObject)

    member this.seeAlso(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.rdfs'seeAlso, annotationObject)

    member this.isDefinedBy(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.rdfsIsDefinedBy, annotationObject)

    member this.isDefinedBy(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.rdfsIsDefinedBy, annotationObject)

    member this.isDefinedBy(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.rdfsIsDefinedBy, annotationObject)

    member this.deprecated(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.owlDeprecated, annotationObject)

    member this.deprecated(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.owlDeprecated, annotationObject)

    member this.deprecated(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.owlDeprecated, annotationObject)

    member this.versionInfo(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.owlVersionInfo, annotationObject)

    member this.versionInfo(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.owlVersionInfo, annotationObject)

    member this.versionInfo(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.owlVersionInfo, annotationObject)

    member this.priorVersion(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.owlPriorVersion, annotationObject)

    member this.priorVersion(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.owlPriorVersion, annotationObject)

    member this.priorVersion(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.owlPriorVersion, annotationObject)

    member this.backwardCompatibleWith(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.owlBackwardCompatibleWith, annotationObject)

    member this.backwardCompatibleWith(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.owlBackwardCompatibleWith, annotationObject)

    member this.backwardCompatibleWith(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.owlBackwardCompatibleWith, annotationObject)

    member this.incompatibleWith(annotationObject: Iri) =
        this.Annotation(RdfVocabulary.owlIncompatibleWith, annotationObject)

    member this.incompatibleWith(annotationObject: BNode) =
        this.Annotation(RdfVocabulary.owlIncompatibleWith, annotationObject)

    member this.incompatibleWith(annotationObject: Literal) =
        this.Annotation(RdfVocabulary.owlIncompatibleWith, annotationObject)

    member this.identity =
        match this with
        | IRIREF iriref -> iriref.uri.OriginalString
        | Irl irl -> irl.remoteReference
        | Irn irn -> irn.identity
        | SkolemIri bnode -> (RdfVocabulary.genid: RdfVocabulary).identity + bnode.sinsignId.ToString("N")
        | PrefixedName prefixedName -> prefixedName.identity

    member this.remoteReference = this.identity

    override this.Equals(other: obj) =
        match other with
        | :? Iri as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Iri as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"

and [<CustomEquality; CustomComparison>] PrefixedName =
    { vocabulary: RdfVocabulary
      localName: string }

    member this.namespaceName = this.vocabulary.namespaceIri.identity

    member this.isInVocabulary(vocabulary: RdfVocabulary) =
        this.identity.StartsWith(vocabulary.identity, StringComparison.Ordinal)

    member this.identity = this.namespaceName + this.localName
    member this.remoteReference = this.identity

    override this.Equals(other: obj) =
        match other with
        | :? PrefixedName as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? PrefixedName as other -> compare this.identity other.identity
            | _ -> invalidArg (nameof other) "Incompatible comparison"

and Irl =
    { site: Site
      port: int option
      template: UriTemplate option
      pattern: UrlPattern option
      pathSegments: string list
      hashFragment: string option
      searchQuery: string option

    }

    member this.scheme = this.site.scheme
    member this.domain = this.site.host
    member this.subdomain = this.domain.subdomain
    member this.secondLevelDomain = this.domain.secondLevelDomain
    member this.topLevelDomain = this.domain.topLevelDomain.name
    member this.domainName = this.domain.domainName
    member this.reverseDomainName = this.domain.reverseDomainName
    member this.remotePath = this.pathSegments |> String.concat "/"
    member this.localPath = this.remotePath.Replace("/", "\\").TrimEnd('\\')
    member this.dotExtension = Path.GetExtension this.localPath
    member this.extension = this.dotExtension.TrimStart('.')
    member this.tryDotExtension = Option.ofNullOrWhiteSpace this.dotExtension

    member this.tryExtension =
        this.tryDotExtension |> Option.map (fun extension -> extension.TrimStart('.'))

    static member ofUrl(url: Url) =

        let domainInfo = domainParser.Value.Parse(url.ToUri(): Uri)

        { site =
            { scheme = Iana.ProtocolScheme.ofString url.Scheme
              host =
                { topLevelDomain = TopLevelDomainRule domainInfo.TopLevelDomainRule
                  secondLevelDomain = domainInfo.Domain
                  subdomainLabels =
                    match Option.ofNullOrWhiteSpace domainInfo.Subdomain with
                    | Some subdomain -> subdomain.Split('.') |> Array.toList
                    | None -> [] }

            }

          port = Option.ofNullable url.Port
          template = None
          pattern = None
          pathSegments =
            match Option.ofObj url.PathSegments with
            | Some segments -> segments |> Seq.toList
            | _ -> List.empty
          hashFragment = Option.ofNullOrWhiteSpace url.Fragment
          searchQuery = Option.ofNullOrWhiteSpace url.Query }

    static member op_Implicit(url: Url) = Irl.ofUrl url

    member this.remoteReference =
        this.site.remoteReference
        + (defaultArg (this.port |> Option.map (fun port -> $":{port}")) String.Empty)
        + (match Option.ofNullOrWhiteSpace (this.pathSegments |> String.concat "/") with
           | Some path -> $"/{path}"
           | None -> String.Empty)
        + (

           match this.searchQuery with
           | Some query -> $"?{query.TrimStart('?')}"
           | None -> String.Empty)
        + (

           match this.hashFragment with
           | Some fragment -> $"#{fragment.TrimStart('#')}"
           | None -> String.Empty)

    member this.localReference = Path.Combine(this.site.localReference, this.localPath)
    member this.identity = this.remoteReference
    static member op_Implicit(irl: Irl) = irl.remoteReference
    member this.Iri = Irl this
    member this.Url = Url this.remoteReference
    member this.DomUrl = DomUrl this.remoteReference
    member this.AdaUrl = AdaUrl.Parse this.remoteReference
    static member op_Implicit(irl: Irl) = irl.Url

    member this.terminal = this.identity.ToCharArray() |> Array.last |> string

    member this.terminalName =
        match this.terminal with
        | "/" -> '/'.tryHtmlEntity.Value
        | "#" -> '#'.tryHtmlEntity.Value
        | _ -> String.Empty

    member this.asSubject = this.Iri.asSubject
    member this.asPredicate = this.Iri.asPredicate
    member this.asObject = this.Iri.asObject
    member this.authority = this.Url.Authority
    member this.fragment = this.Url.Fragment
    member this.host = this.Url.Host
    member this.isRelative = this.Url.IsRelative
    member this.isSecureScheme = this.Url.IsSecureScheme
    member this.path = this.Url.Path
    // member this.pathSegments = this.Url.PathSegments
    // member this.port = Option.ofNullable this.Url.Port
    member this.query = this.Url.Query
    member this.queryParams = this.Url.QueryParams
    member this.root = this.Url.Root

    member this.userInfo = this.Url.UserInfo
    member this.queryStringParameterCollection = QueryStringUtilities.ParseQuery this.query

    static member (/)(irl: Irl, segment: string) =
        irl.Url.AppendPathSegment segment |> Irl.ofUrl

    static member (/)(irl: Irl, segments: string list) =
        irl.Url.AppendPathSegment segments |> Irl.ofUrl

    static member (+?)((irl: Irl), (queryParam: string * 'Value)) =
        let parameterKey = fst queryParam
        let parameterValue = string (snd queryParam)

        irl.Url.AppendQueryParam(parameterKey, parameterValue) |> Irl.ofUrl

    static member (+?)((irl: Irl), (queryParam: string * 'Value list)) =
        let parameterKey = fst queryParam
        let parameterValues = snd queryParam |> List.map string

        irl.Url.AppendQueryParam(parameterKey, parameterValues) |> Irl.ofUrl

    static member (!-|)(irl: Irl) = irl.Url.RemoveFragment() |> Irl.ofUrl

    static member (-?)((irl: Irl), (parameterKey: string)) =

        irl.Url.RemoveQueryParam(parameterKey) |> Irl.ofUrl

    static member (-?)((irl: Irl), (parameterKeys: string list)) =

        irl.Url.RemoveQueryParams(parameterKeys) |> Irl.ofUrl

    static member (|=|)(irl: Irl, fragmentString: string) =
        irl.Url.SetFragment(fragmentString) |> Irl.ofUrl

    static member (=?)((irl: Irl), (queryStringParameters: List<string * 'Value>)) =
        let queryParams =
            queryStringParameters
            |> List.map (fun queryStringParameter ->
                let parameterKey = fst queryStringParameter
                let parameterValue = string (snd queryStringParameter)
                parameterKey, parameterValue)

        irl.Url.SetQueryParams queryParams |> Irl.ofUrl

    static member (=?)((irl: Irl), (queryStringParameter: string * 'Value)) =
        let parameterKey = fst queryStringParameter
        let parameterValue = string (snd queryStringParameter)
        irl.Url.SetQueryParam(parameterKey, parameterValue) |> Irl.ofUrl
    static member (=?)
        (
            irl : Irl,
            queryStringParameters : FSharpRecord<'RecordType>
        )
        =
        irl =? queryStringParameters.fieldStrings

    member this.hash = this.DomUrl.Hash
    // member this.host = this.DomUrl.Host
    member this.hostname = this.DomUrl.Hostname
    member this.href = this.DomUrl.Href
    member this.origin = this.DomUrl.Origin

    member this.remotePathQueryFragment =
        this.remoteReference[this.origin.Length ..].TrimStart('/')

    member this.password = this.DomUrl.Password
    member this.pathname = this.DomUrl.Pathname
    member this.portString = this.DomUrl.Port
    member this.protocol = this.DomUrl.Protocol
    member this.search = this.DomUrl.Search
    member this.username = this.DomUrl.Username
    member this.components = this.AdaUrl.Components
    member this.hasCredentials = this.AdaUrl.HasCredentials
    member this.hasEmptyHostname = this.AdaUrl.HasEmptyHostname
    // member this.hash = this.AdaUrl.Hash
    member this.hasHash = this.AdaUrl.HasHash
    member this.hasHostname = this.AdaUrl.HasHostname
    member this.hasNonEmptyPassword = this.AdaUrl.HasNonEmptyPassword
    member this.hasNonEmptyUsername = this.AdaUrl.HasNonEmptyUsername
    member this.hasPassword = this.AdaUrl.HasPassword
    member this.hasPort = this.AdaUrl.HasPort
    member this.hasSearch = this.AdaUrl.HasSearch
    // member this.host = this.AdaUrl.Host
    // member this.hostname = this.AdaUrl.Hostname
    member this.hostType = this.AdaUrl.HostType
    // member this.href = this.AdaUrl.Href
    member this.isValid = this.AdaUrl.IsValid
    // member this.password = this.AdaUrl.Password
    // member this.pathname = this.AdaUrl.Pathname
    // member this.port = this.AdaUrl.Port
    // member this.protocol = this.AdaUrl.Protocol
    member this.schemeType = this.AdaUrl.SchemeType
// member this.search = this.AdaUrl.Search
// member this.username = this.AdaUrl.Username

and Irn =
    { namespaceIdentifier: string
      namespaceSpecificString: string }

    member this.urn =
        Urn.Parse $"urn:{this.namespaceIdentifier}:{this.namespaceSpecificString}"

    member this.identity = this.urn.ToString()
    member this.Iri = Irn this
    member this.asSubject = this.Iri.asSubject
    member this.asPredicate = this.Iri.asPredicate
    member this.asObject = this.Iri.asObject

and Site =
    { scheme: Iana.ProtocolScheme
      host: Domain }

    member this.protocol = this.scheme.name
    member this.origin = $"{this.protocol}://{this.host.domainName}"

    static member (/)(site: Site, segment: string) =
        { site = site
          port = None
          template = None
          pattern = None
          pathSegments = [ segment ]
          hashFragment = None
          searchQuery = None }

    static member (=?)(site: Site, queryString: string) =
        { site = site
          port = None
          template = None
          pattern = None
          pathSegments = List.empty
          hashFragment = None
          searchQuery = Some(queryString.TrimStart('?')) }

    static member (=?)
        (
            site: Site,
            queryStringParameters : FSharpRecord<'RecordType>
        )
        =
        let queryString = 
            queryStringParameters.fieldStrings
            |> List.map (fun (parameter, value) -> $"{parameter}={value}")
            |> String.concat "&"
        site =? queryString

    static member (/=/)(site: Site, fragmentString: string) =
        { site = site
          port = None
          template = None
          pattern = None
          pathSegments = List.empty
          hashFragment = Some(fragmentString.TrimStart('#'))
          searchQuery = None }

    static member (=*)(site: Site, template: UriTemplate) =
        { site = site
          port = None
          template = Some template
          pattern = None
          pathSegments = List.empty
          hashFragment = None
          searchQuery = None }

    static member (.*)(site: Site, pattern: UrlPattern) =
        { site = site
          port = None
          template = None
          pattern = Some pattern
          pathSegments = List.empty
          hashFragment = None
          searchQuery = None }

    static member (..+)(site: Site, port: int) =
        { site = site
          port = Some port
          template = None
          pattern = None
          pathSegments = List.empty
          hashFragment = None
          searchQuery = None }

    member this.remoteReference = $"{this.scheme.name}://{this.host.domainName}"

    member this.localReference =
        Path.Combine(
            DriveInfo.preferredDrive.RootDirectory.FullName,
            this.scheme.name,
            this.host.labels
            |> Array.rev
            |> String.concat (string Path.DirectorySeparatorChar)
        )

    member this.Iri = Iri.op_Implicit this.remoteReference

    member this.asSubject = this.Iri.asSubject
    member this.asPredicate = this.Iri.asPredicate
    member this.asObject = this.Iri.asObject

and RdfVocabulary =
    { namespacePrefix: string
      namespaceIri: Iri
      distributionIris: Iri list
      documentIris: Iri list }

    static member ofPrefixedName((prefixedName: PrefixedName), (suffix: string)) =
        RdfVocabulary.PREFIX(prefixedName.localName, prefixedName.identity + suffix)

    static member slashPrefixedName(prefixedName: PrefixedName) =
        RdfVocabulary.ofPrefixedName (prefixedName, "/")

    static member hashPrefixedName(prefixedName: PrefixedName) =
        RdfVocabulary.ofPrefixedName (prefixedName, "#")

    static member ofPrefixedName(prefixedName: PrefixedName) =
        RdfVocabulary.slashPrefixedName (prefixedName)

    member this.identity = this.namespaceIri.identity

    member this.terminal = this.identity.ToCharArray() |> Array.last |> string

    member this.terminalName =
        match this.terminal with
        | "/" -> '/'.tryHtmlEntity.Value
        | "#" -> '#'.tryHtmlEntity.Value
        | _ -> String.Empty

    member this.remoteReference = this.identity
    member this.Irl = Url this.namespaceIri.remoteReference |> Irl.ofUrl

    member this.localTurtleReference =
        Path.Combine(this.Irl.localReference + this.terminalName, "text", "turtle.ttl")

    member this.asXNamespace = XNamespace.Get this.identity

    member this.prefixedName(localName: string) =
        { vocabulary = this
          localName = localName }

    member this.curie(localName: string) : Iri =
        this.prefixedName localName |> PrefixedName

    static member PREFIX((namespacePrefix: string), (namespaceName: string)) =
        { namespacePrefix = namespacePrefix
          namespaceIri = IriReference namespaceName |> IRIREF
          distributionIris = []
          documentIris = [] }

    static member PREFIX((namespacePrefix: string), (namespaceUri: Uri)) =
        RdfVocabulary.PREFIX(namespacePrefix, namespaceUri.OriginalString)

    static member PREFIX((namespacePrefix: string), (namespaceIri: Iri)) =
        RdfVocabulary.PREFIX(namespacePrefix, namespaceIri.identity)

    static member PREFIX((namespacePrefix: string), (namespaceIrl: Irl)) =
        RdfVocabulary.PREFIX(namespacePrefix, namespaceIrl.identity)

    static member genid =
        RdfVocabulary.PREFIX("genid", $"https://eristocrates.dev/.well-known/genid/")

    static member xml = RdfVocabulary.PREFIX("xml", "http://www.w3.org/XML/1998/namespace#")
    static member xsd = RdfVocabulary.PREFIX("xsd", "http://www.w3.org/2001/XMLSchema#")
    static member xsd'string = RdfVocabulary.xsd.curie "string" |> DatatypeIri
    static member xsd'length = RdfVocabulary.xsd.curie "length" |> FacetIri
    static member xsd'minLength = RdfVocabulary.xsd.curie "minLength" |> FacetIri
    static member xsd'maxLength = RdfVocabulary.xsd.curie "maxLength" |> FacetIri
    static member xsd'pattern = RdfVocabulary.xsd.curie "pattern" |> FacetIri

    static member xsd'nonNegativeInteger =
        RdfVocabulary.xsd.curie "nonNegativeInteger" |> DatatypeIri

    static member rdf = RdfVocabulary.PREFIX("rdf", "http://www.w3.org/1999/02/22-rdf-syntax-ns#")

    static member rdf'type = RdfVocabulary.rdf.curie "type"
    static member rdf'langString = RdfVocabulary.rdf.curie "langString" |> DatatypeIri
    static member rdf'dirLangString = RdfVocabulary.rdf.curie "dirLangString" |> DatatypeIri
    static member rdf'langRange = RdfVocabulary.rdf.curie "langRange" |> FacetIri
    static member rdf'PropositionForm = RdfVocabulary.rdf.curie "PropositionForm"
    static member rdf'PropositionFormSubject = RdfVocabulary.rdf.curie "PropositionFormSubject"

    static member rdf'PropositionFormPredicate =
        RdfVocabulary.rdf.curie "PropositionFormPredicate"

    static member rdf'PropositionFormObject = RdfVocabulary.rdf.curie "PropositionFormObject"
    static member rdfs = RdfVocabulary.PREFIX("rdfs", "http://www.w3.org/2000/01/rdf-schema#")
    static member rdfs'label = RdfVocabulary.rdfs.curie "label" |> AnnotationPropertyIri
    static member rdfs'comment = RdfVocabulary.rdfs.curie "comment" |> AnnotationPropertyIri
    static member rdfs'seeAlso = RdfVocabulary.rdfs.curie "seeAlso" |> AnnotationPropertyIri

    static member rdfsIsDefinedBy =
        RdfVocabulary.rdfs.curie "isDefinedBy" |> AnnotationPropertyIri

    static member owl = RdfVocabulary.PREFIX("owl", "http://www.w3.org/2002/07/owl#")
    static member owlDeprecated = RdfVocabulary.owl.curie "deprecated" |> AnnotationPropertyIri
    static member owlVersionInfo = RdfVocabulary.owl.curie "versionInfo" |> AnnotationPropertyIri

    static member owlPriorVersion =
        RdfVocabulary.owl.curie "priorVersion" |> AnnotationPropertyIri

    static member owlBackwardCompatibleWith =
        RdfVocabulary.owl.curie "backwardCompatibleWith" |> AnnotationPropertyIri

    static member owlIncompatibleWith =
        RdfVocabulary.owl.curie "incompatibleWith" |> AnnotationPropertyIri

    static member rdfa = RdfVocabulary.PREFIX("rdfa", "http://www.w3.org/ns/rdfa#")

    static member xhtml = RdfVocabulary.PREFIX("xhtml", "http://www.w3.org/1999/xhtml/datatypes/")

    static member xsi = RdfVocabulary.PREFIX("xsi", "http://www.w3.org/2001/XMLSchema-instance#")

    static member ianassignments =
        RdfVocabulary.PREFIX("ianassignments", "https://www.iana.org/assignments/")

    static member media_types =
        RdfVocabulary.ianassignments.prefixedName "media-types"
        |> RdfVocabulary.ofPrefixedName

    static member w3id_mediatype =
        RdfVocabulary.PREFIX("mediatype", "https://w3id.org/mediatype/")

    static member spar_mediatype =
        RdfVocabulary.PREFIX("spar_mediatype", "https://w3id.org/https://w3id.org/spar/mediatype/")

    static member spdx = RdfVocabulary.PREFIX("spdx", "https://spdx.org/rdf/3.0.1/terms/Core/")

and [<StructuralEquality; StructuralComparison>] LiteralIdentity =
    private
        { lexicalForm: string
          literalDatatype: DatatypeIri
          languageTag: string option
          baseDirection: InitialTextDirection option }

and DatatypeIri =
    | DatatypeIri of Iri

    static member op_Implicit(iri: Iri) = DatatypeIri iri

    member this.Iri: Iri =
        match this with
        | DatatypeIri iri -> iri

    static member op_Implicit(datatypeIri: DatatypeIri) = datatypeIri.Iri
    member this.identity: string = this.Iri.identity

    member this.length(length: NonNegativeInteger) =
        let facetValue: FacetValue =
            RdfVocabulary.xsd'length
            |> Functional.FacetValue(TypedLiteral.nonNegativeInteger length)

        this |> Functional.DatatypeRestriction(facetValue)

    member this.minLength(minLength: NonNegativeInteger) =
        let facetValue: FacetValue =
            RdfVocabulary.xsd'minLength
            |> Functional.FacetValue(TypedLiteral.nonNegativeInteger minLength)

        this |> Functional.DatatypeRestriction(facetValue)

    member this.maxLength(maxLength: NonNegativeInteger) =
        let facetValue: FacetValue =
            RdfVocabulary.xsd'maxLength
            |> Functional.FacetValue(TypedLiteral.nonNegativeInteger maxLength)

        this |> Functional.DatatypeRestriction(facetValue)

    member this.pattern(pattern: string) =
        let facetValue: FacetValue =
            RdfVocabulary.xsd'pattern |> Functional.FacetValue(Literal.string pattern)

        this |> Functional.DatatypeRestriction(facetValue)

    member this.langRange(langRange: string) =
        let facetValue: FacetValue =
            RdfVocabulary.rdf'langRange |> Functional.FacetValue(Literal.string langRange)

        this |> Functional.DatatypeRestriction(facetValue)

    member this.withRestrictions(facetValues: Set.OneOrMore<FacetValue>) =
        Functional.DatatypeRestriction(this, facetValues)

and FacetValue =
    { constrainingFacet: FacetIri
      restrictionValue: Literal }

and FacetIri =
    | FacetIri of Iri

    static member op_Implicit(iri: Iri) = FacetIri iri

    member this.Iri: Iri =
        match this with
        | FacetIri iri -> iri

    static member op_Implicit(facetIri: FacetIri) = facetIri.Iri
    member this.identity: string = this.Iri.identity

and Datatype<[<Measure>] 'Datatype> =
    private
        { _datatypeIri: DatatypeIri }

    static member ofDatatypeIri(datatypeIri: DatatypeIri) : Datatype<'Datatype> = { _datatypeIri = datatypeIri }
    member this.datatypeIri = this._datatypeIri

    member this.Iri = this._datatypeIri.Iri

    static member (^^)((lexicalForm: System.String), (datatype: Datatype<'Datatype>)) : StaticTypedLiteral<'Datatype> =
        { literal = UMX.tag lexicalForm
          datatype = datatype }

and StaticTypedLiteral<[<Measure>] 'Datatype> =
    { literal: string<'Datatype>
      datatype: Datatype<'Datatype> }

    static member toTypedLiteral(staticTypedLiteral: StaticTypedLiteral<'Datatype>) : TypedLiteral =
        { lexicalForm = UMX.untag staticTypedLiteral.literal

          datatypeIri = staticTypedLiteral.datatype._datatypeIri }

    static member op_Implicit(staticTypedLiteral: StaticTypedLiteral<'Datatype>) =
        StaticTypedLiteral.toTypedLiteral staticTypedLiteral

    static member toLiteral(staticTypedLiteral: StaticTypedLiteral<'Datatype>) =
        StaticTypedLiteral.toTypedLiteral staticTypedLiteral |> TypedLiteral

    static member op_Implicit(staticTypedLiteral: StaticTypedLiteral<'Datatype>) =
        StaticTypedLiteral.toLiteral staticTypedLiteral

    member this.asObject =
        StaticTypedLiteral.toLiteral this |> LiteralObject |> BasicNormativeObject

    member this.identity: LiteralIdentity = (StaticTypedLiteral.toLiteral this).identity

and TypedLiteral =
    { lexicalForm: string
      datatypeIri: DatatypeIri }

    member this.asObject = TypedLiteral this |> LiteralObject |> BasicNormativeObject

    static member nonNegativeInteger(nonNegativeInteger: uint32) : TypedLiteral =
        { lexicalForm = string nonNegativeInteger
          datatypeIri = RdfVocabulary.xsd'nonNegativeInteger }

    static member op_Implicit(value: bool) =
        { lexicalForm = if value then "true" else "false"
          datatypeIri = RdfVocabulary.xsd.curie "boolean" |> DatatypeIri }

    // byte[] -> xsd:base64Binary
    static member op_Implicit(value: byte array) =
        { lexicalForm = Convert.ToBase64String value
          datatypeIri = RdfVocabulary.xsd.curie "base64Binary" |> DatatypeIri }

    // byte -> xsd:unsignedByte
    static member op_Implicit(value: byte) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "unsignedByte" |> DatatypeIri }

    // DateOnly -> xsd:date
    static member op_Implicit(value: DateOnly) =
        { lexicalForm = value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "date" |> DatatypeIri }

    // DateTime -> xsd:dateTime
    static member op_Implicit(value: DateTime) =
        { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "dateTime" |> DatatypeIri }

    // DateTimeOffset -> xsd:dateTimeStamp
    static member op_Implicit(value: DateTimeOffset) =
        { lexicalForm = value.ToString("o", CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "dateTimeStamp" |> DatatypeIri }

    // decimal -> xsd:decimal
    static member op_Implicit(value: decimal) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "decimal" |> DatatypeIri }

    // double -> xsd:double
    static member op_Implicit(value: double) =
        { lexicalForm = Xml.XmlConvert.ToString(value)
          datatypeIri = RdfVocabulary.xsd.curie "double" |> DatatypeIri }

    // int16 -> xsd:short
    static member op_Implicit(value: int16) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "short" |> DatatypeIri }

    // int32 -> xsd:int
    static member op_Implicit(value: int32) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "int" |> DatatypeIri }

    // int64 -> xsd:long
    static member op_Implicit(value: int64) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "long" |> DatatypeIri }

    // sbyte -> xsd:byte
    static member op_Implicit(value: sbyte) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "byte" |> DatatypeIri }

    // single -> xsd:float
    static member op_Implicit(value: single) =
        { lexicalForm = Xml.XmlConvert.ToString(value)
          datatypeIri = RdfVocabulary.xsd.curie "float" |> DatatypeIri }

    // TimeOnly -> xsd:time
    static member op_Implicit(value: TimeOnly) =
        { lexicalForm = value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "time" |> DatatypeIri }

    // TimeSpan -> xsd:duration
    static member op_Implicit(value: TimeSpan) =
        { lexicalForm = Xml.XmlConvert.ToString value
          datatypeIri = RdfVocabulary.xsd.curie "duration" |> DatatypeIri }

    // uint16 -> xsd:unsignedShort
    static member op_Implicit(value: uint16) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "unsignedShort" |> DatatypeIri }

    // uint32 -> xsd:unsignedInt
    static member op_Implicit(value: uint32) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "unsignedInt" |> DatatypeIri }

    // uint64 -> xsd:unsignedLong
    static member op_Implicit(value: uint64) =
        { lexicalForm = Convert.ToString(value, CultureInfo.InvariantCulture)
          datatypeIri = RdfVocabulary.xsd.curie "unsignedLong" |> DatatypeIri }

    // System.Uri -> xsd:anyURI
    static member op_Implicit(value: Uri) =
        { lexicalForm = value.OriginalString
          datatypeIri = RdfVocabulary.xsd.curie "anyURI" |> DatatypeIri }

    static member nil =
        { lexicalForm = "true"
          datatypeIri = RdfVocabulary.xsi.curie "nil" |> DatatypeIri }

    static member inline autotyped(value: ^ValueType) : TypedLiteral = FSharpPlus.Operators.implicit value

    member this.identity: LiteralIdentity =
        {

          lexicalForm = this.lexicalForm

          literalDatatype = this.datatypeIri

          languageTag = None

          baseDirection = None }

and [<CustomEquality; CustomComparison>] Literal =
    | StringLiteral of StringLiteral
    | TypedLiteral of TypedLiteral
    | EmbeddedLiteral of EmbeddedLiteral

    member this.lexicalForm =
        match this with
        | StringLiteral stringLiteral -> stringLiteral.lexicalForm
        | TypedLiteral typedLiteral -> typedLiteral.lexicalForm
        | EmbeddedLiteral embeddedLiteral -> embeddedLiteral.lexicalForm

    member this.datatypeIri =
        match this with
        | StringLiteral stringLiteral -> stringLiteral.datatypeIri
        | TypedLiteral typedLiteral -> typedLiteral.datatypeIri
        | EmbeddedLiteral embeddedLiteral -> embeddedLiteral.datatypeIri

    member this.tryLanguageTag =
        match this with
        | StringLiteral stringLiteral -> stringLiteral.tryLanguageTag
        | TypedLiteral typedLiteral -> None
        | EmbeddedLiteral embeddedLiteral -> None

    static member string(value: string) : Literal =
        SimpleString { simpleString = value } |> StringLiteral

    static member inline autotyped(value: ^ValueType) : Literal =
        TypedLiteral.autotyped value |> TypedLiteral

    member this.asObject = LiteralObject this |> BasicNormativeObject

    static member (!>=)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "minInclusive" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!>)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "minExclusive" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!<=)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "maxInclusive" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!<)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "maxExclusive" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!@)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.rdf.curie "langRange" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!*)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "pattern" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!.<)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "maxLength" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!.=)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "length" |> FacetIri
          restrictionValue = restrictionValue }

    static member (!.>)(restrictionValue: Literal) =
        { constrainingFacet = RdfVocabulary.xsd.curie "minLength" |> FacetIri
          restrictionValue = restrictionValue }

    member this.identity: LiteralIdentity =
        match this with

        | StringLiteral(SimpleString simpleString) -> simpleString.identity

        | StringLiteral(LanguageString languageString) -> languageString.identity

        | TypedLiteral typedLiteral -> typedLiteral.identity

        | EmbeddedLiteral embeddedLiteral -> embeddedLiteral.identity

    override this.Equals(other: obj) =
        match other with
        | :? Literal as other -> this.identity = other.identity

        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? Literal as other -> compare this.identity other.identity

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<Literal>.Name} with {other.GetType().Name}"

and StringLiteral =
    | SimpleString of SimpleString
    | LanguageString of LanguageString

    member this.tryLanguageTag =
        match this with
        | SimpleString stringLiteral -> None
        | LanguageString languageString -> Some languageString.languageTag

    member this.asObject = StringLiteral this |> LiteralObject |> BasicNormativeObject

    member this.identity =
        match this with
        | SimpleString stringLiteral -> stringLiteral.identity
        | LanguageString languageString -> languageString.identity

    member this.lexicalForm =
        match this with
        | SimpleString stringLiteral -> stringLiteral.lexicalForm
        | LanguageString languageString -> languageString.lexicalForm

    member this.datatypeIri =
        match this with
        | SimpleString stringLiteral -> stringLiteral.datatypeIri
        | LanguageString languageString -> languageString.datatypeIri

and SimpleString =
    { simpleString: string }

    member this.datatypeIri = RdfVocabulary.xsd'string
    member this.lexicalForm = this.simpleString

    member this.asObject =
        SimpleString this |> StringLiteral |> LiteralObject |> BasicNormativeObject

    member this.identity: LiteralIdentity =
        { lexicalForm = this.simpleString
          literalDatatype = RdfVocabulary.xsd.curie "string" |> DatatypeIri
          languageTag = None
          baseDirection = None }

and LanguageString =
    { lexicalForm: string
      languageTag: LanguageTag
      baseDirection: InitialTextDirection option }

    member this.datatypeIri =
        match this.baseDirection with
        | Some baseDirection -> RdfVocabulary.rdf'dirLangString
        | None -> RdfVocabulary.rdf'langString

    member this.identity: LiteralIdentity =
        { lexicalForm = this.lexicalForm
          literalDatatype =
            match this.baseDirection with
            | None -> RdfVocabulary.rdf.curie "langString" |> DatatypeIri
            | Some _ -> RdfVocabulary.rdf.curie "dirLangString" |> DatatypeIri
          languageTag = Some this.languageTag.identity
          baseDirection = this.baseDirection }

    member this.asObject =
        LanguageString this |> StringLiteral |> LiteralObject |> BasicNormativeObject

and EmbeddedLiteral =
    | EmbeddedHtml of HtmlLiteral
    | EmbeddedXml of XmlLiteral
    | EmbeddedJson of JsonLiteral
    | EmbeddedJavascript of JavascriptLiteral

    member this.asObject = EmbeddedLiteral this |> LiteralObject |> BasicNormativeObject

    member this.identity: LiteralIdentity =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.identity

        | EmbeddedXml xmlLiteral -> xmlLiteral.identity

        | EmbeddedJson jsonLiteral -> jsonLiteral.identity

        | EmbeddedJavascript javascriptLiteral -> javascriptLiteral.identity

    member this.lexicalForm =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.lexicalForm

        | EmbeddedXml xmlLiteral -> xmlLiteral.lexicalForm

        | EmbeddedJson jsonLiteral -> jsonLiteral.lexicalForm

        | EmbeddedJavascript javascriptLiteral -> javascriptLiteral.lexicalForm

    member this.datatypeIri: DatatypeIri =
        match this with
        | EmbeddedHtml htmlLiteral -> htmlLiteral.datatypeIri

        | EmbeddedXml xmlLiteral -> xmlLiteral.datatypeIri

        | EmbeddedJson jsonLiteral -> jsonLiteral.datatypeIri

        | EmbeddedJavascript javascriptLiteral -> javascriptLiteral.datatypeIri

and HtmlLiteral =
    { htmlString: string }

    member this.asObject =
        EmbeddedHtml this |> EmbeddedLiteral |> LiteralObject |> BasicNormativeObject

    member this.lexicalForm = this.htmlString

    member this.datatypeIri = RdfVocabulary.rdf.curie "HTML" |> DatatypeIri

    member this.identity =
        { lexicalForm = this.htmlString
          literalDatatype = this.datatypeIri
          languageTag = None
          baseDirection = None }

and XmlLiteral =
    { xmlString: string }

    member this.lexicalForm = this.xmlString

    member this.asObject =
        EmbeddedXml this |> EmbeddedLiteral |> LiteralObject |> BasicNormativeObject

    member this.datatypeIri = RdfVocabulary.rdf.curie "XMLLiteral" |> DatatypeIri

    member this.identity =
        { lexicalForm = this.xmlString
          literalDatatype = this.datatypeIri
          languageTag = None
          baseDirection = None }

and JsonLiteral =
    { jsonString: string }

    member this.lexicalForm = this.jsonString

    member this.asObject =
        EmbeddedJson this |> EmbeddedLiteral |> LiteralObject |> BasicNormativeObject

    member this.datatypeIri = RdfVocabulary.rdf.curie "JSON" |> DatatypeIri

    member this.identity =
        { lexicalForm = this.jsonString
          literalDatatype = this.datatypeIri
          languageTag = None
          baseDirection = None }

and JavascriptLiteral =
    { javascriptString: string }

    member this.lexicalForm = this.javascriptString

    member this.asObject =
        EmbeddedJavascript this
        |> EmbeddedLiteral
        |> LiteralObject
        |> BasicNormativeObject

    member this.datatypeIri =
        RdfVocabulary.spar_mediatype.curie "text/javascript" |> DatatypeIri

    member this.identity =
        { lexicalForm = this.javascriptString
          literalDatatype = this.datatypeIri
          languageTag = None
          baseDirection = None }

and NormativeDataset =
    { defaultGraph: NormativeGraph
      namedGraphs: Map<GraphName, NormativeNamedGraph> }

and [<CustomEquality; CustomComparison>] NormativeNamedGraph =
    { normativeGraph: NormativeGraph
      graphName: GraphName }

    static member ofOntology(ontology: Ontology, scope: string) =
        { normativeGraph =
            { context = ontology.tryVersionIri
              normativeTriples = ontology.assertedTriples }
          graphName = GraphName.ofOntology (ontology, scope)

        }

    static member ofOntology(ontology: Annotated<Ontology>, scope: string) =
        NormativeNamedGraph.ofOntology (ontology.value, scope)

    member this.identity = this.graphName

    override this.Equals(other: obj) =
        match other with
        | :? NormativeNamedGraph as other -> this.identity = other.identity
        | _ -> false

    override this.GetHashCode() = this.identity.GetHashCode()

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? NormativeNamedGraph as other -> compare this.identity other.identity
            | _ ->
                invalidArg
                    (nameof other)
                    $"Cannot compare {typeof<NormativeNamedGraph>.Name} with {other.GetType().Name}"

and BasicNormativeGraph =
    { context: Iri option
      basicNormativeTriples: Set<BasicNormativeTriple> }

    member this.normativeTriples =
        this.basicNormativeTriples |> Set.map BasicNormativeTriple.toNormativeTriple

and NormativeGraph =

    { context: Iri option
      normativeTriples: Set<NormativeTriple> }

    member this.BNodes =
        this.normativeTriples
        |> Seq.toArray
        |> Array.collect (fun normativeTriple -> normativeTriple.BNodes)

    member this.Iris =
        this.normativeTriples
        |> Seq.toArray
        |> Array.collect (fun normativeTriple -> normativeTriple.Iris)

    member this.BNodeIdentities =
        this.BNodes |> Array.map (fun (bnode: BNode) -> bnode.identity) |> Set.ofArray

    /// https://w3c.github.io/rdf-interop/spec/#section-basicenc-algo
    member this.basicEncode: BasicNormativeGraph =
        let hasTripleTerms =
            this.normativeTriples
            |> Seq.exists (fun (triple: NormativeTriple) -> triple.normativeObject.IsTripleTermObject)

        let hasPropositionFormMarker =
            this.normativeTriples
            |> Seq.exists (fun triple -> triple.isPropositionFormMarker)

        if hasTripleTerms && hasPropositionFormMarker then
            invalidOp
                "RDF 1.2 basic encoding is undefined for a hybrid graph containing both triple terms and blank-node rdf:PropositionForm markers."
        // Freshness is checked on the exported blank-node identity, not only on
        // Doxaletheia's (scope, identity) equality, because external RDF libraries
        // generally expose the identifier without our scope component.
        let mutable extantBNodeIdentities = this.BNodeIdentities

        let freshBlankNode () =
            let rec create () =
                let sinsignId = Guid.NewGuid()
                let identity = sinsignId.ToString("N")

                if extantBNodeIdentities.Contains identity then
                    create ()
                else
                    extantBNodeIdentities <- extantBNodeIdentities.Add identity

                    { sinsignId = sinsignId
                      scope =
                        this.context
                        |> Option.map (fun iri -> iri.identity)
                        |> Option.defaultValue String.Empty
                      localIdentifier = None }

            create ()

        let tripleTermMap = Generic.Dictionary<NormativeTriple, BNode>()
        let outputTriples = ResizeArray<BasicNormativeTriple>()

        let rec encodeNormativeObject (normativeObject: NormativeObject) : BasicNormativeObject =
            match normativeObject with
            | BasicNormativeObject basicObject -> basicObject
            | TripleTermObject tripleTerm -> encodeTripleTerm tripleTerm |> BNodeObject

        and encodeTripleTerm (tripleTerm: TripleTerm) : BNode =
            let (TripleTerm triple) = tripleTerm

            match tripleTermMap.TryGetValue triple with
            | true, existingBlankNode -> existingBlankNode
            | false, _ ->
                let encodedObject = encodeNormativeObject triple.normativeObject
                let blankNode = freshBlankNode ()
                tripleTermMap.Add(triple, blankNode)

                outputTriples.Add(
                    BasicNormativeTriple.PropositionForm
                        blankNode
                        RdfVocabulary.rdf'type
                        (IriObject RdfVocabulary.rdf'PropositionForm)
                )

                outputTriples.Add(
                    BasicNormativeTriple.PropositionForm
                        blankNode
                        RdfVocabulary.rdf'PropositionFormSubject
                        triple.normativeSubject.asBasicNormativeObject
                )

                outputTriples.Add(
                    BasicNormativeTriple.PropositionForm
                        blankNode
                        RdfVocabulary.rdf'PropositionFormPredicate
                        triple.normativePredicate.asBasicNormativeObject
                )

                outputTriples.Add(
                    BasicNormativeTriple.PropositionForm blankNode RdfVocabulary.rdf'PropositionFormObject encodedObject
                )

                blankNode

        for normativeTriple in this.normativeTriples do
            outputTriples.Add
                { normativeSubject = normativeTriple.normativeSubject
                  normativePredicate = normativeTriple.normativePredicate
                  basicNormativeObject = encodeNormativeObject normativeTriple.normativeObject }

        { context = this.context
          basicNormativeTriples = outputTriples |> Set.ofSeq }

and NormativeQuad =
    { normativeTriple: NormativeTriple
      graphName: GraphName option }

and GraphName =
    | GraphName of NormativeSubject

    member this.normativeSubject =
        match this with
        | GraphName normativeSubject -> normativeSubject

    member this.identity =
        match this.normativeSubject with
        | IriSubject iri -> iri.identity
        | BNodeSubject bnode -> bnode.identity

    static member ofOntology(ontology: Ontology, scope: string) =
        match ontology.tryOntologyIri with
        | Some iri -> IriSubject iri |> GraphName
        | None -> BNode.Mint scope |> BNodeSubject |> GraphName

and BasicNormativeTriple =
    { normativeSubject: NormativeSubject
      normativePredicate: NormativePredicate
      basicNormativeObject: BasicNormativeObject }

    static member SPO((S: NormativeSubject), (P: NormativePredicate), (O: BasicNormativeObject)) =
        { normativeSubject = S
          normativePredicate = P
          basicNormativeObject = O }

    static member SOP((S: NormativeSubject), (O: BasicNormativeObject), (P: NormativePredicate)) =
        BasicNormativeTriple.SPO(S, P, O)

    static member PSO((P: NormativePredicate), (S: NormativeSubject), (O: BasicNormativeObject)) =
        BasicNormativeTriple.SPO(S, P, O)

    static member POS((P: NormativePredicate), (O: BasicNormativeObject), (S: NormativeSubject)) =
        BasicNormativeTriple.SPO(S, P, O)

    static member OSP((O: BasicNormativeObject), (S: NormativeSubject), (P: NormativePredicate)) =
        BasicNormativeTriple.SPO(S, P, O)

    static member OPS((O: BasicNormativeObject), (S: NormativeSubject), (P: NormativePredicate)) =
        BasicNormativeTriple.SPO(S, P, O)

    static member toNormativeTriple(basicNormativeTriple: BasicNormativeTriple) =
        { normativeSubject = basicNormativeTriple.normativeSubject
          normativePredicate = basicNormativeTriple.normativePredicate
          normativeObject = BasicNormativeObject basicNormativeTriple.basicNormativeObject }

    member this.asNormativeTriple = BasicNormativeTriple.toNormativeTriple this
    static member op_Implicit(basicNormativeTriple: BasicNormativeTriple) = basicNormativeTriple.asNormativeTriple

    static member PropositionForm (subject: BNode) (predicate: Iri) (objectValue: BasicNormativeObject) =
        { normativeSubject = BNodeSubject subject
          normativePredicate = IriPredicate predicate
          basicNormativeObject = objectValue }

    member this.BNodes =
        match this.normativeSubject, this.basicNormativeObject with
        | BNodeSubject bnodeSubject, BNodeObject bnodeObject -> [| bnodeSubject; bnodeObject |]
        | BNodeSubject bnodeSubject, _ -> [| bnodeSubject |]
        | _, BNodeObject bnodeObject -> [| bnodeObject |]
        | _, _ -> [||]

    member this.Iris =
        match this.normativeSubject, this.basicNormativeObject with
        | IriSubject iriSubject, IriObject iriObject -> [| iriSubject; this.normativePredicate.Iri; iriObject |]
        | IriSubject iriSubject, _ -> [| iriSubject; this.normativePredicate.Iri |]
        | _, IriObject iriObject -> [| this.normativePredicate.Iri; iriObject |]
        | _, _ -> [| this.normativePredicate.Iri |]

and NormativeTriple =
    { normativeSubject: NormativeSubject
      normativePredicate: NormativePredicate
      normativeObject: NormativeObject }

    static member SPO((S: NormativeSubject), (P: NormativePredicate), (O: NormativeObject)) =
        { normativeSubject = S
          normativePredicate = P
          normativeObject = O }

    static member SOP((S: NormativeSubject), (O: NormativeObject), (P: NormativePredicate)) =
        NormativeTriple.SPO(S, P, O)

    static member PSO((P: NormativePredicate), (S: NormativeSubject), (O: NormativeObject)) =
        NormativeTriple.SPO(S, P, O)

    static member POS((P: NormativePredicate), (O: NormativeObject), (S: NormativeSubject)) =
        NormativeTriple.SPO(S, P, O)

    static member OSP((O: NormativeObject), (S: NormativeSubject), (P: NormativePredicate)) =
        NormativeTriple.SPO(S, P, O)

    static member OPS((O: NormativeObject), (S: NormativeSubject), (P: NormativePredicate)) =
        NormativeTriple.SPO(S, P, O)

    member this.BNodes =
        let subjectBNodes =
            match this.normativeSubject with
            | BNodeSubject bnode -> [| bnode |]
            | IriSubject _ -> [||]

        let objectBNodes =
            match this.normativeObject with
            | BasicNormativeObject(BNodeObject bnode) -> [| bnode |]

            | TripleTermObject(TripleTerm triple) -> triple.BNodes

            | _ -> [||]

        Array.append subjectBNodes objectBNodes

    member this.Iris =
        let subjectIris =
            match this.normativeSubject with
            | IriSubject iri -> [| iri |]
            | BNodeSubject _ -> [||]

        let objectIris =
            match this.normativeObject with
            | BasicNormativeObject(IriObject iri) -> [| iri |]

            | TripleTermObject(TripleTerm triple) -> triple.Iris

            | _ -> [||]

        Array.concat [ subjectIris; [| this.normativePredicate.Iri |]; objectIris ]

    member this.isPropositionFormMarker =
        match this.normativeSubject, this.normativePredicate, this.normativeObject with
        | BNodeSubject _, IriPredicate predicate, BasicNormativeObject(IriObject objectIri) when
            predicate = RdfVocabulary.rdf'type
            && objectIri = RdfVocabulary.rdf'PropositionForm
            ->
            true
        | _ -> false

and NormativeSubject =
    | IriSubject of Iri
    | BNodeSubject of BNode

    member this.asBasicNormativeObject = BasicNormativeObject.ofNormativeSubject this

and NormativePredicate =
    | IriPredicate of Iri

    member inline this.Property((curSubject: NormativeSubject), (curObject: NormativeObject)) =
        NormativeTriple.PSO(this, curSubject, curObject)

    member inline this.Property
        ((curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject)), (curObject: NormativeObject))
        =
        NormativeTriple.PSO(this, curSubject.asSubject, curObject)

    member inline this.Property
        ((curSubject: NormativeSubject), (curObject: ^Object when ^Object: (member asObject: NormativeObject)))
        =
        NormativeTriple.PSO(this, curSubject, curObject.asObject)

    member inline this.Property
        (
            (curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject)),
            (curObject: ^Object when ^Object: (member asObject: NormativeObject))
        ) =
        NormativeTriple.PSO(this, curSubject.asSubject, curObject.asObject)

    static member inline (/->)((predicate: NormativePredicate), (curObject: NormativeObject)) =
        PredicateObject(predicate, curObject)

    static member (/->)(predicate: NormativePredicate, iriObject: Iri) : PredicateObject =
        PredicateObject(predicate, iriObject.asObject)

    static member (/->)(predicate: NormativePredicate, bnodeObject: BNode) : PredicateObject =
        PredicateObject(predicate, bnodeObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalObject: Literal) : PredicateObject =
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: string) : PredicateObject =
        let literalObject = Literal.string literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: bool) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: byte array) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: byte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: DateOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: DateTime) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: DateTimeOffset) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: decimal) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: double) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: int16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: int32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: int64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: sbyte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: single) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: TimeOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: TimeSpan) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: uint16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: uint32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: uint64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, literalValue: Uri) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)
        (predicate: NormativePredicate, ((lexicalForm: System.String), (datatype: Datatype<'Datatype>)))
        : PredicateObject =
        let literalObject = lexicalForm ^^ datatype
        PredicateObject(predicate, literalObject.asObject)

    static member (/->)(predicate: NormativePredicate, tripleTermObject: TripleTerm) : PredicateObject =
        PredicateObject(predicate, tripleTermObject.asObject)

    static member (/->)(predicate: NormativePredicate, namedIndividualObject: NamedIndividual) : PredicateObject =
        PredicateObject(predicate, namedIndividualObject.asObject)

    static member (/->)
        (predicate: NormativePredicate, anonymousIndividualObject: AnonymousIndividual)
        : PredicateObject =
        PredicateObject(predicate, anonymousIndividualObject.asObject)

    static member (/->)(predicate: NormativePredicate, individualObject: Individual) : PredicateObject =
        PredicateObject(predicate, individualObject.asObject)

    static member (/->)(predicate: NormativePredicate, objects: Iri list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member (/->)(predicate: NormativePredicate, objects: BNode list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member (/->)(predicate: NormativePredicate, objects: Literal list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member (/->)(predicate: NormativePredicate, objects: TripleTerm list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member (/->)(predicate: NormativePredicate, objects: NamedIndividual list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member (/->)(predicate: NormativePredicate, objects: AnonymousIndividual list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member (/->)(predicate: NormativePredicate, objects: Individual list) : PredicateObjectList =
        PredicateObject.List(predicate, objects |> List.map _.asObject)

    static member inline (/->)
        ((predicate: NormativePredicate), (curObject: ^Object when ^Object: (member asObject: NormativeObject)))
        =
        predicate /-> curObject.asObject

    static member (/->)((predicate: NormativePredicate), (objectList: NormativeObject list)) =
        PredicateObject.List(predicate, objectList)

    static member inline (/->)
        ((predicate: NormativePredicate), (objectList: ^Object list when ^Object: (member asObject: NormativeObject)))
        =
        PredicateObject.List(predicate, objectList |> List.map _.asObject)

    member this.Iri =
        match this with
        | IriPredicate iri -> iri

    member this.asBasicNormativeObject = BasicNormativeObject.ofNormativePredicate this

and BasicNormativeObject =
    | IriObject of Iri
    | BNodeObject of BNode
    | LiteralObject of Literal

    static member ofNormativeSubject(normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> IriObject iri
        | BNodeSubject bnode -> BNodeObject bnode

    static member ofNormativePredicate(normativePredicate: NormativePredicate) =
        match normativePredicate with
        | IriPredicate iri -> IriObject iri

    member this.asObject = BasicNormativeObject this

and NormativeObject =
    | BasicNormativeObject of BasicNormativeObject
    | TripleTermObject of TripleTerm

and SubjectPredicate =

    { curSubject: NormativeSubject
      curPredicate: NormativePredicate }

and PredicateObject =
    | PredicateObject of NormativePredicate * NormativeObject

    member this.curPredicate =
        match this with
        | PredicateObject(curPredicate, curObject) -> curPredicate

    member this.curObject =
        match this with
        | PredicateObject(curPredicate, curObject) -> curObject

    static member inline (--/)((curSubject: NormativeSubject), (predicateObject: PredicateObject)) =
        NormativeTriple.SPO(curSubject, predicateObject.curPredicate, predicateObject.curObject)

    static member inline (--/)((curSubject: Iri), (predicateObject: PredicateObject)) =
        NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject)

    static member inline (--/)((curSubject: BNode), (predicateObject: PredicateObject)) =
        NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject)

    static member inline (--/)((curSubject: NamedIndividual), (predicateObject: PredicateObject)) =
        NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject)

    static member inline (--/)((curSubject: AnonymousIndividual), (predicateObject: PredicateObject)) =
        NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject)

    static member inline (--/)((curSubject: Individual), (predicateObject: PredicateObject)) =
        NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject)

    static member inline (--/)
        ((curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject)), (predicateObject: PredicateObject))
        =
        curSubject.asSubject --/ predicateObject

    static member inline (-+/)((subjects: NormativeSubject list), (predicateObject: PredicateObject)) =
        subjects
        |> List.map (fun curSubject ->
            NormativeTriple.SPO(curSubject, predicateObject.curPredicate, predicateObject.curObject))

    static member inline (-+/)
        (subjects: seq<#NamedIndividual>, predicateObject: PredicateObject)
        : NormativeTriple list =

        subjects
        |> Seq.map (fun subject ->
            NormativeTriple.SPO(IriSubject subject.Iri, predicateObject.curPredicate, predicateObject.curObject))
        |> Seq.toList

    static member inline (-+/)((subjects: Iri list), (predicateObject: PredicateObject)) =
        subjects
        |> List.map (fun curSubject ->
            NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject))

    static member inline (-+/)((subjects: BNode list), (predicateObject: PredicateObject)) =
        subjects
        |> List.map (fun curSubject ->
            NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject))

    static member inline (-+/)((subjects: NamedIndividual list), (predicateObject: PredicateObject)) =
        subjects
        |> List.map (fun curSubject ->
            NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject))

    static member inline (-+/)((subjects: AnonymousIndividual list), (predicateObject: PredicateObject)) =
        subjects
        |> List.map (fun curSubject ->
            NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject))

    static member inline (-+/)((subjects: Individual list), (predicateObject: PredicateObject)) =
        subjects
        |> List.map (fun curSubject ->
            NormativeTriple.SPO(curSubject.asSubject, predicateObject.curPredicate, predicateObject.curObject))

    static member inline (-+/)
        (
            (subjects: ^Subject list when ^Subject: (member asSubject: NormativeSubject)),
            (predicateObject: PredicateObject)
        ) =
        (subjects |> List.map _.asSubject) -+/ predicateObject

    static member List((curPredicate: NormativePredicate), (objectList: NormativeObject list)) : PredicateObjectList =
        match objectList with
        | [ curObject ] -> PredicateObjectList(curPredicate, List.OneOrMore.One curObject)
        | headObject :: tailObjects -> PredicateObjectList(curPredicate, List.OneOrMore.More headObject tailObjects)
        | [] -> invalidOp "One-or-more List must have at least one item."

    static member inline List
        ((curPredicate: NormativePredicate), (objectList: ^Object list when ^Object: (member asObject: NormativeObject))) =
        PredicateObject.List(curPredicate, objectList |> List.map _.asObject)

    static member inline List
        (
            (curPredicate: ^Predicate when ^Predicate: (member asPredicate: NormativePredicate)),
            (objectList: NormativeObject list)
        ) =
        PredicateObject.List(curPredicate.asPredicate, objectList)

    static member inline List
        (
            (curPredicate: ^Predicate when ^Predicate: (member asPredicate: NormativePredicate)),
            (objectList: ^Object list when ^Object: (member asObject: NormativeObject))
        ) =
        PredicateObject.List(curPredicate.asPredicate, objectList)

and PredicateObjectList =
    | PredicateObjectList of NormativePredicate * List.OneOrMore<NormativeObject>

    member this.curPredicate =
        match this with
        | PredicateObjectList(curPredicate, objectList) -> curPredicate

    member this.objectList =
        match this with
        | PredicateObjectList(curPredicate, objectList) -> objectList

    static member (--/)((curSubject: NormativeSubject), (predicateObjectList: PredicateObjectList)) =
        predicateObjectList.objectList.items
        |> List.map (fun curObject -> NormativeTriple.SPO(curSubject, predicateObjectList.curPredicate, curObject))

    static member inline (--/)
        (
            (curSubject: ^Subject when ^Subject: (member asSubject: NormativeSubject)),
            (predicateObjectList: PredicateObjectList)
        ) =
        curSubject.asSubject --/ predicateObjectList

    static member (-+/)((subjects: NormativeSubject list), (predicateObjectList: PredicateObjectList)) =
        subjects
        |> List.collect (fun curSubject ->
            predicateObjectList.objectList.items
            |> List.map (fun curObject -> NormativeTriple.SPO(curSubject, predicateObjectList.curPredicate, curObject)))

    static member inline (-+/)
        (
            (subjects: ^Subject list when ^Subject: (member asSubject: NormativeSubject)),
            (predicateObjectList: PredicateObjectList)
        ) =
        (subjects |> List.map _.asSubject) -+/ predicateObjectList

    static member append(curObject: NormativeObject) =
        fun (predicateObjectList: PredicateObjectList) ->
            PredicateObjectList(
                predicateObjectList.curPredicate,
                List.OneOrMore<NormativeObject>.More predicateObjectList.objectList.items curObject
            )

    static member inline append(curObject: ^Object when ^Object: (member asObject: NormativeObject)) =
        fun (predicateObjectList: PredicateObjectList) ->
            predicateObjectList |> PredicateObjectList.append curObject.asObject

    static member concat(objectList: NormativeObject list) =
        fun (predicateObjectList: PredicateObjectList) ->
            let headObject :: tailObjects =
                List.concat [ predicateObjectList.objectList.items; objectList ]

            PredicateObjectList(
                predicateObjectList.curPredicate,
                List.OneOrMore<NormativeObject>.More headObject tailObjects
            )

    static member inline concat(objectList: ^Object list when ^Object: (member asObject: NormativeObject)) =
        fun (predicateObjectList: PredicateObjectList) ->
            predicateObjectList
            |> PredicateObjectList.concat (objectList |> List.map _.asObject)

and BasicRdfTerm =
    | IriTerm of Iri
    | LiteralTerm of Literal
    | BlankTerm of BNode

and RdfTerm =
    | BasicRdfTerm of BasicRdfTerm
    | RdfTripleTerm of TripleTerm

and TripleTerm =
    | TripleTerm of NormativeTriple

    member this.triple =
        match this with
        | TripleTerm triple -> triple

    member this.ttSubject = this.triple.normativeSubject
    member this.ttPredicate = this.triple.normativePredicate
    member this.ttObject = this.triple.normativeObject

    member this.asObject = TripleTermObject this

and [<CustomEquality; CustomComparison>] BNode =

    { sinsignId: Guid
      scope: string
      localIdentifier: string option }

    static member Mint(scope: string) =
        { sinsignId = Guid.NewGuid()
          scope = scope
          localIdentifier = None }

    member this.skolem = SkolemIri this

    member this.asSubject = BNodeSubject this
    member this.asObject = BNodeObject this |> BasicNormativeObject
    member this.identity = this.sinsignId.ToString("N")

    override this.Equals(other: obj) =
        match other with
        | :? BNode as other -> this.identity = other.identity && this.scope = other.scope
        | _ -> false

    override this.GetHashCode() =
        HashCode.Combine(this.scope, this.identity)

    interface IComparable with
        member this.CompareTo(other: obj) =
            match other with
            | :? BNode as other -> compare (this.scope, this.identity) (other.scope, other.identity)

            | _ -> invalidArg (nameof other) $"Cannot compare {typeof<BNode>.Name} with {other.GetType().Name}"

    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Iri)) =
        Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, IriObject annotationObject)

    member this.Annotation(annotationObject: Iri) =
        fun (annotationProperty: AnnotationProperty) ->
            Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, IriObject annotationObject)

    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: BNode)) =
        Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, BNodeObject annotationObject)

    member this.Annotation(annotationObject: BNode) =
        fun (annotationProperty: AnnotationProperty) ->
            Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, BNodeObject annotationObject)

    member this.Annotation((annotationProperty: AnnotationProperty), (annotationObject: Literal)) =
        Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, LiteralObject annotationObject)

    member this.Annotation(annotationObject: Literal) =
        fun (annotationProperty: AnnotationProperty) ->
            Functional.AnnotationAssertion(annotationProperty, BNodeSubject this, LiteralObject annotationObject)

and OntologyIri =
    | OntologyIri of Iri

    static member op_Implicit(iri: Iri) = OntologyIri iri

    member this.Iri: Iri =
        match this with
        | OntologyIri iri -> iri

    static member op_Implicit(ontologyIri: OntologyIri) = ontologyIri.Iri
    member this.identity: string = this.Iri.identity

and VersionIri =
    | VersionIri of Iri

    static member op_Implicit(iri: Iri) = VersionIri iri

    member this.Iri: Iri =
        match this with
        | VersionIri iri -> iri

    static member op_Implicit(versionIri: VersionIri) = versionIri.Iri
    member this.identity: string = this.Iri.identity

and AnnotationProperty =
    | AnnotationPropertyIri of Iri

    static member op_Implicit(iri: Iri) = AnnotationPropertyIri iri

    member this.Iri: Iri =
        match this with
        | AnnotationPropertyIri iri -> iri

    static member op_Implicit(annotationProperty: AnnotationProperty) = annotationProperty.Iri
    member this.asPredicate = IriPredicate this.Iri
    static member op_Implicit(annotationProperty: AnnotationProperty) = annotationProperty.asPredicate
    member this.identity: string = this.Iri.identity

    member this.Annotation(value: BasicNormativeObject) = Functional.Annotation(this, value)

    member this.Annotation(value: Iri) =
        Functional.Annotation(this, IriObject value)

    member this.Annotation(value: BNode) =
        Functional.Annotation(this, BNodeObject value)

    member this.Annotation(value: Literal) =
        Functional.Annotation(this, LiteralObject value)

    member this.Assertion(subject: Iri, value: Iri) =
        Functional.AnnotationAssertion(this, IriSubject subject, IriObject value)

    member this.Assertion(subject: Iri, value: BNode) =
        Functional.AnnotationAssertion(this, IriSubject subject, BNodeObject value)

    member this.Assertion(subject: Iri, value: Literal) =
        Functional.AnnotationAssertion(this, IriSubject subject, LiteralObject value)

    member this.Assertion(subject: BNode, value: Iri) =
        Functional.AnnotationAssertion(this, BNodeSubject subject, IriObject value)

    member this.Assertion(subject: BNode, value: BNode) =
        Functional.AnnotationAssertion(this, BNodeSubject subject, BNodeObject value)

    member this.Assertion(subject: BNode, value: Literal) =
        Functional.AnnotationAssertion(this, BNodeSubject subject, LiteralObject value)

    static member inline (/->)((annotationProperty: AnnotationProperty), (curObject: NormativeObject)) =
        PredicateObject(annotationProperty.asPredicate, curObject)

    static member (/->)(annotationProperty: AnnotationProperty, iriObject: Iri) : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, iriObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, bnodeObject: BNode) : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, bnodeObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalObject: Literal) : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: string) : PredicateObject =
        let literalObject = Literal.string literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: bool) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: byte array) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: byte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: DateOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: DateTime) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: DateTimeOffset) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: decimal) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: double) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: int16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: int32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: int64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: sbyte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: single) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: TimeOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: TimeSpan) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: uint16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: uint32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: uint64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, literalValue: Uri) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)
        (annotationProperty: AnnotationProperty, ((lexicalForm: System.String), (datatype: Datatype<'Datatype>)))
        : PredicateObject =
        let literalObject = lexicalForm ^^ datatype
        PredicateObject(annotationProperty.asPredicate, literalObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, tripleTermObject: TripleTerm) : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, tripleTermObject.asObject)

    static member (/->)
        (annotationProperty: AnnotationProperty, namedIndividualObject: NamedIndividual)
        : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, namedIndividualObject.asObject)

    static member (/->)
        (annotationProperty: AnnotationProperty, anonymousIndividualObject: AnonymousIndividual)
        : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, anonymousIndividualObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, individualObject: Individual) : PredicateObject =
        PredicateObject(annotationProperty.asPredicate, individualObject.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, objects: Iri list) : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, objects: BNode list) : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, objects: Literal list) : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, objects: TripleTerm list) : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, objects: NamedIndividual list) : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)
        (annotationProperty: AnnotationProperty, objects: AnonymousIndividual list)
        : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(annotationProperty: AnnotationProperty, objects: Individual list) : PredicateObjectList =
        PredicateObject.List(annotationProperty.asPredicate, objects |> List.map _.asObject)

    static member inline (/->)
        ((annotationProperty: AnnotationProperty), (curObject: ^Object when ^Object: (member asObject: NormativeObject))) =
        annotationProperty /-> curObject.asObject

    static member (/->)((annotationProperty: AnnotationProperty), (objectList: NormativeObject list)) =
        PredicateObject.List(annotationProperty.asPredicate, objectList)

    static member inline (/->)
        (
            (annotationProperty: AnnotationProperty),
            (objectList: ^Object list when ^Object: (member asObject: NormativeObject))
        ) =
        PredicateObject.List(annotationProperty.asPredicate, objectList |> List.map _.asObject)

and Class =
    | ClassIri of Iri

    static member op_Implicit(iri: Iri) = ClassIri iri

    member this.Iri: Iri =
        match this with
        | ClassIri iri -> iri

    member this.asSubject = this.Iri.asSubject
    member this.asObject = this.Iri.asObject
    static member op_Implicit(class_: Class) = class_.Iri
    member this.identity: string = this.Iri.identity

    member this._that(restriction: Restriction) = Conjunction.that (this, restriction)

    member this._that(restrictionPrimary: RestrictionPrimary) =
        Conjunction.that (this, restrictionPrimary)

    member this._that(restrictionPrimaries: List.OneOrMore<RestrictionPrimary>) =
        Conjunction.that (this, restrictionPrimaries)

and DirectlyImportsDocument = Import of Iri

and Annotation =
    { annotationAnnotations: Set<Annotation>
      annotationProperty: AnnotationProperty
      annotationValue: BasicNormativeObject }

and Annotated<'Value> =
    { annotations: Set<Annotation>
      value: 'Value }

    member this.map(mapping: 'Value -> 'MappedValue) : Annotated<'MappedValue> =
        { annotations = this.annotations
          value = mapping this.value }

    static member Unannotated(value: 'Value) =
        { annotations = Set.empty
          value = value }

    static member Annotate(annotations: Set<Annotation>, value: 'Value) =
        { annotations = annotations
          value = value }

    static member Annotate(annotations: Set<Annotation>) =
        fun (value: 'Value) -> Annotated.Annotate(annotations, value)

and PrefixDeclaration = Prefix of string * IriReference

and ObjectProperty =
    | ObjectPropertyIri of Iri

    static member op_Implicit(iri: Iri) = ObjectPropertyIri iri

    member this.Iri: Iri =
        match this with
        | ObjectPropertyIri iri -> iri

    static member op_Implicit(objectProperty: ObjectProperty) = objectProperty.Iri
    member this.asPredicate = IriPredicate this.Iri
    static member op_Implicit(objectProperty: ObjectProperty) = objectProperty.asPredicate
    member this.identity: string = this.Iri.identity

    member this.Fact(individual: Individual) =
        { polarity = Positive
          objectProperty = this
          individual = individual }

    member this.Fact(individual: NamedIndividual) = this.Fact(Individual individual)

    member this.Fact(individual: AnonymousIndividual) =
        this.Fact(AnonymousIndividual individual)

    member this._not(individual: Individual) = !!(this.Fact individual)
    member this._not(individual: NamedIndividual) = !!(this.Fact(Individual individual))

    member this._not(individual: AnonymousIndividual) =
        !!(this.Fact(AnonymousIndividual individual))

    member this._inverse = Functional.ObjectInverseOf this

    static member inline (/->)((objectProperty: ObjectProperty), (curObject: NormativeObject)) =
        PredicateObject(objectProperty.asPredicate, curObject)

    static member (/->)(objectProperty: ObjectProperty, iriObject: Iri) : PredicateObject =
        PredicateObject(objectProperty.asPredicate, iriObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, bnodeObject: BNode) : PredicateObject =
        PredicateObject(objectProperty.asPredicate, bnodeObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalObject: Literal) : PredicateObject =
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: string) : PredicateObject =
        let literalObject = Literal.string literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: bool) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: byte array) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: byte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: DateOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: DateTime) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: DateTimeOffset) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: decimal) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: double) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: int16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: int32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: int64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: sbyte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: single) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: TimeOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: TimeSpan) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: uint16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: uint32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: uint64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, literalValue: Uri) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)
        (objectProperty: ObjectProperty, ((lexicalForm: System.String), (datatype: Datatype<'Datatype>)))
        : PredicateObject =
        let literalObject = lexicalForm ^^ datatype
        PredicateObject(objectProperty.asPredicate, literalObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, tripleTermObject: TripleTerm) : PredicateObject =
        PredicateObject(objectProperty.asPredicate, tripleTermObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, namedIndividualObject: NamedIndividual) : PredicateObject =
        PredicateObject(objectProperty.asPredicate, namedIndividualObject.asObject)

    static member (/->)
        (objectProperty: ObjectProperty, anonymousIndividualObject: AnonymousIndividual)
        : PredicateObject =
        PredicateObject(objectProperty.asPredicate, anonymousIndividualObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, individualObject: Individual) : PredicateObject =
        PredicateObject(objectProperty.asPredicate, individualObject.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: Iri list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: BNode list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: Literal list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: TripleTerm list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: NamedIndividual list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: AnonymousIndividual list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(objectProperty: ObjectProperty, objects: Individual list) : PredicateObjectList =
        PredicateObject.List(objectProperty.asPredicate, objects |> List.map _.asObject)

    static member inline (/->)
        ((objectProperty: ObjectProperty), (curObject: ^Object when ^Object: (member asObject: NormativeObject)))
        =
        objectProperty.asPredicate /-> curObject.asObject

    static member (/->)((objectProperty: ObjectProperty), (objectList: NormativeObject list)) =
        PredicateObject.List(objectProperty.asPredicate, objectList)

    static member inline (/->)
        ((objectProperty: ObjectProperty), (objectList: ^Object list when ^Object: (member asObject: NormativeObject)))
        =
        PredicateObject.List(objectProperty.asPredicate, objectList |> List.map _.asObject)

and DataProperty =
    | DataPropertyIri of Iri

    static member op_Implicit(iri: Iri) = DataPropertyIri iri

    member this.Iri: Iri =
        match this with
        | DataPropertyIri iri -> iri

    static member op_Implicit(objectProperty: DataProperty) = objectProperty.Iri
    member this.asPredicate = IriPredicate this.Iri
    static member op_Implicit(objectProperty: DataProperty) = objectProperty.asPredicate
    member this.identity: string = this.Iri.identity

    member this._some(dataPrimary: DataPrimary) =
        this
        |> Restriction.DataSomeValuesFrom dataPrimary.dataRange
        |> RestrictionPrimary.ofRestriction

    member this._only(dataPrimary: DataPrimary) =
        this
        |> Restriction.DataAllValuesFrom dataPrimary.dataRange
        |> RestrictionPrimary.ofRestriction

    member this._value(literal: Literal) =
        this |> Restriction.DataHasValue literal |> RestrictionPrimary.ofRestriction

    member this._min((nonNegativeInteger: NonNegativeInteger), (dataPrimary: DataPrimary)) =
        Restriction.DataMinCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
        |> RestrictionPrimary.ofRestriction

    member this._min(dataPrimary: DataPrimary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.DataMinCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
            |> RestrictionPrimary.ofRestriction

    member this._min(nonNegativeInteger: NonNegativeInteger) =
        Restriction.DataMinCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._exactly((nonNegativeInteger: NonNegativeInteger), (dataPrimary: DataPrimary)) =
        Restriction.DataExactCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
        |> RestrictionPrimary.ofRestriction

    member this._exactly(dataPrimary: DataPrimary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.DataExactCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
            |> RestrictionPrimary.ofRestriction

    member this._exactly(nonNegativeInteger: NonNegativeInteger) =
        Restriction.DataExactCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._max((nonNegativeInteger: NonNegativeInteger), (dataPrimary: DataPrimary)) =
        Restriction.DataMaxCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
        |> RestrictionPrimary.ofRestriction

    member this._max(dataPrimary: DataPrimary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.DataMaxCardinality(nonNegativeInteger, this, dataPrimary.dataRange)
            |> RestrictionPrimary.ofRestriction

    member this._max(nonNegativeInteger: NonNegativeInteger) =
        Restriction.DataMaxCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this.Fact(literal: Literal) =
        { polarity = Positive
          dataProperty = this
          literal = literal }

    member this.Fact(literal: TypedLiteral) = this.Fact(TypedLiteral literal)

    member this.Fact(literal: StaticTypedLiteral<_>) =
        this.Fact(StaticTypedLiteral.toLiteral literal)

    member this.Fact(value: string) = this.Fact(Literal.string value)

    member this.Fact(value: bool) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: byte array) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: byte) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: DateOnly) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: DateTime) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: DateTimeOffset) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: decimal) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: double) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: int16) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: int32) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: int64) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: sbyte) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: single) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: TimeOnly) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: TimeSpan) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: uint16) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: uint32) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: uint64) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this.Fact(value: Uri) =
        this.Fact(TypedLiteral.op_Implicit value)

    member this._not(literal: Literal) = !!(this.Fact literal)
    member this._not(literal: TypedLiteral) = !!(this.Fact literal)
    member this._not(literal: StaticTypedLiteral<_>) = !!(this.Fact literal)

    member this._not(value: bool) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: byte array) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: byte) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: DateOnly) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: DateTime) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: DateTimeOffset) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: decimal) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: double) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: int16) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: int32) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: int64) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: sbyte) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: single) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: TimeOnly) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: TimeSpan) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: uint16) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: uint32) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: uint64) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    member this._not(value: Uri) =
        !!(this.Fact(TypedLiteral.op_Implicit value))

    static member inline (/->)((dataProperty: DataProperty), (curObject: NormativeObject)) =
        PredicateObject(dataProperty.asPredicate, curObject)

    static member (/->)(dataProperty: DataProperty, iriObject: Iri) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, iriObject.asObject)

    static member (/->)(dataProperty: DataProperty, bnodeObject: BNode) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, bnodeObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalObject: Literal) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: string) : PredicateObject =
        let literalObject = Literal.string literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: bool) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: byte array) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: byte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: DateOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: DateTime) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: DateTimeOffset) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: decimal) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: double) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: int16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: int32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: int64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: sbyte) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: single) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: TimeOnly) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: TimeSpan) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: uint16) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: uint32) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: uint64) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, literalValue: Uri) : PredicateObject =
        let literalObject = TypedLiteral.op_Implicit literalValue
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)
        (dataProperty: DataProperty, ((lexicalForm: System.String), (datatype: Datatype<'Datatype>)))
        : PredicateObject =
        let literalObject = lexicalForm ^^ datatype
        PredicateObject(dataProperty.asPredicate, literalObject.asObject)

    static member (/->)(dataProperty: DataProperty, tripleTermObject: TripleTerm) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, tripleTermObject.asObject)

    static member (/->)(dataProperty: DataProperty, namedIndividualObject: NamedIndividual) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, namedIndividualObject.asObject)

    static member (/->)(dataProperty: DataProperty, anonymousIndividualObject: AnonymousIndividual) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, anonymousIndividualObject.asObject)

    static member (/->)(dataProperty: DataProperty, individualObject: Individual) : PredicateObject =
        PredicateObject(dataProperty.asPredicate, individualObject.asObject)

    static member (/->)(dataProperty: DataProperty, objects: Iri list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(dataProperty: DataProperty, objects: BNode list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(dataProperty: DataProperty, objects: Literal list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(dataProperty: DataProperty, objects: TripleTerm list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(dataProperty: DataProperty, objects: NamedIndividual list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(dataProperty: DataProperty, objects: AnonymousIndividual list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member (/->)(dataProperty: DataProperty, objects: Individual list) : PredicateObjectList =
        PredicateObject.List(dataProperty.asPredicate, objects |> List.map _.asObject)

    static member inline (/->)
        ((dataProperty: DataProperty), (curObject: ^Object when ^Object: (member asObject: NormativeObject)))
        =
        dataProperty.asPredicate /-> curObject.asObject

    static member (/->)((dataProperty: DataProperty), (objectList: NormativeObject list)) =
        PredicateObject.List(dataProperty.asPredicate, objectList)

    static member inline (/->)
        ((dataProperty: DataProperty), (objectList: ^Object list when ^Object: (member asObject: NormativeObject)))
        =
        PredicateObject.List(dataProperty.asPredicate, objectList |> List.map _.asObject)

and NamedIndividual =
    | NamedIndividualIri of Iri

    static member op_Implicit(iri: Iri) = NamedIndividualIri iri

    member this.Iri: Iri =
        match this with
        | NamedIndividualIri iri -> iri

    member this.asSubject = this.Iri.asSubject
    member this.asObject = this.Iri.asObject
    static member op_Implicit(namedIndividual: NamedIndividual) = namedIndividual.Iri
    member this.identity: string = this.Iri.identity

    member this.Annotation(annotationProperty: AnnotationProperty, annotationValue: BasicNormativeObject) =
        annotationProperty.Annotation annotationValue

    member this.Annotation(annotationProperty: AnnotationProperty, annotationValue: Iri) =
        annotationProperty.Annotation annotationValue

    member this.Annotation(annotationProperty: AnnotationProperty, annotationValue: BNode) =
        annotationProperty.Annotation annotationValue

    member this.Annotation(annotationProperty: AnnotationProperty, annotationValue: Literal) =
        annotationProperty.Annotation annotationValue

    member this.SameAs(individual: Individual) =
        Functional.SameIndividual (Individual this) individual

    member this.SameAs(individuals: Individual list) =
        Functional.SameIndividual(Set.TwoOrMore.More (Individual this) individuals[0] (Set.ofList individuals[1..]))

    member this.SameAs(individual: NamedIndividual) =
        Functional.SameIndividual (Individual this) (Individual individual)

    member this.SameAs(individuals: NamedIndividual list) : Annotated<SameIndividual> =
        Functional.SameIndividual(
            Set.TwoOrMore.More
                (Individual this)
                (Individual individuals[0])
                (individuals[1..] |> List.map Individual |> Set.ofList)
        )

    member this.SameAs(individual: AnonymousIndividual) =
        Functional.SameIndividual (Individual this) (AnonymousIndividual individual)

    member this.SameAs(individuals: AnonymousIndividual list) =
        Functional.SameIndividual(
            Set.TwoOrMore.More
                (Individual this)
                (AnonymousIndividual individuals[0])
                (individuals[1..] |> List.map AnonymousIndividual |> Set.ofList)
        )

    member this.DifferentFrom(individual: Individual) =
        Functional.DifferentIndividuals (Individual this) individual

    member this.DifferentFrom(individuals: Individual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More (Individual this) individuals[0] (Set.ofList individuals[1..])
        )

    member this.DifferentFrom(individual: NamedIndividual) =
        Functional.DifferentIndividuals (Individual this) (Individual individual)

    member this.DifferentFrom(individuals: NamedIndividual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More
                (Individual this)
                (Individual individuals[0])
                (individuals[1..] |> List.map Individual |> Set.ofList)
        )

    member this.DifferentFrom(individual: AnonymousIndividual) =
        Functional.DifferentIndividuals (Individual this) (AnonymousIndividual individual)

    member this.DifferentFrom(individuals: AnonymousIndividual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More
                (Individual this)
                (AnonymousIndividual individuals[0])
                (individuals[1..] |> List.map AnonymousIndividual |> Set.ofList)
        )

    member this.Fact(fact: Fact) = fact.Assertion(Individual this)

    member this.Fact(fact: Annotated<Fact>) : Annotated<Assertion> =
        fact.map (fun value -> value.Assertion(Individual this))

    member this.Fact(fact: DataPropertyFact) : Assertion = fact.Assertion(Individual this)

    member this.Fact(fact: ObjectPropertyFact) : Assertion = fact.Assertion(Individual this)

    member this.Facts(facts: Fact list) =
        facts |> List.map (fun fact -> fact.Assertion(Individual this))

    member this.Facts(facts: DataPropertyFact list) =
        facts |> List.map (fun fact -> fact.Assertion(Individual this))

    member this.Facts(facts: ObjectPropertyFact list) =
        facts |> List.map (fun fact -> fact.Assertion(Individual this))

    member this.Facts(facts: Annotated<Fact> list) : Annotated<Assertion> list =
        facts |> List.map (fun fact -> this.Fact fact)

    member this.Type(description: Description) =
        Functional.ClassAssertion (Individual this) description.asClassExpression

    member this.Types(descriptions: Description list) = descriptions |> List.map this.Type

and AnonymousIndividual =
    | AnonymousIndividualBNode of BNode

    static member op_Implicit(bnode: BNode) = AnonymousIndividualBNode bnode

    member this.BNode: BNode =
        match this with
        | AnonymousIndividualBNode bnode -> bnode

    member this.asSubject = this.BNode.asSubject
    member this.asObject = this.BNode.asObject
    static member op_Implicit(namedIndividual: AnonymousIndividual) = namedIndividual.BNode
    member this.identity: string = this.BNode.identity

    member this.SameAs(individual: Individual) =
        Functional.SameIndividual (AnonymousIndividual this) individual

    member this.SameAs(individuals: Individual list) =
        Functional.SameIndividual(
            Set.TwoOrMore.More (AnonymousIndividual this) individuals[0] (Set.ofList individuals[1..])
        )

    member this.SameAs(individual: NamedIndividual) =
        Functional.SameIndividual (AnonymousIndividual this) (Individual individual)

    member this.SameAs(individuals: NamedIndividual list) =
        Functional.SameIndividual(
            Set.TwoOrMore.More
                (AnonymousIndividual this)
                (Individual individuals[0])
                (individuals[1..] |> List.map Individual |> Set.ofList)
        )

    member this.SameAs(individual: AnonymousIndividual) =
        Functional.SameIndividual (AnonymousIndividual this) (AnonymousIndividual individual)

    member this.SameAs(individuals: AnonymousIndividual list) =
        Functional.SameIndividual(
            Set.TwoOrMore.More
                (AnonymousIndividual this)
                (AnonymousIndividual individuals[0])
                (individuals[1..] |> List.map AnonymousIndividual |> Set.ofList)
        )

    member this.DifferentFrom(individual: Individual) =
        Functional.DifferentIndividuals (AnonymousIndividual this) individual

    member this.DifferentFrom(individuals: Individual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More (AnonymousIndividual this) individuals[0] (Set.ofList individuals[1..])
        )

    member this.DifferentFrom(individual: NamedIndividual) =
        Functional.DifferentIndividuals (AnonymousIndividual this) (Individual individual)

    member this.DifferentFrom(individuals: NamedIndividual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More
                (AnonymousIndividual this)
                (Individual individuals[0])
                (individuals[1..] |> List.map Individual |> Set.ofList)
        )

    member this.DifferentFrom(individual: AnonymousIndividual) =
        Functional.DifferentIndividuals (AnonymousIndividual this) (AnonymousIndividual individual)

    member this.DifferentFrom(individuals: AnonymousIndividual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More
                (AnonymousIndividual this)
                (AnonymousIndividual individuals[0])
                (individuals[1..] |> List.map AnonymousIndividual |> Set.ofList)
        )

    member this.Fact(fact: Fact) =
        fact.Assertion(AnonymousIndividual this)

    member this.Facts(facts: Fact list) =
        facts |> List.map (fun fact -> fact.Assertion(AnonymousIndividual this))

    member this.Fact(fact: DataPropertyFact) : Assertion =
        fact.Assertion(AnonymousIndividual this)

    member this.Fact(fact: ObjectPropertyFact) : Assertion =
        fact.Assertion(AnonymousIndividual this)

    member this.Facts(facts: DataPropertyFact list) =
        facts |> List.map (fun fact -> fact.Assertion(AnonymousIndividual this))

    member this.Facts(facts: ObjectPropertyFact list) =
        facts |> List.map (fun fact -> fact.Assertion(AnonymousIndividual this))

    member this.Fact(fact: Annotated<Fact>) : Annotated<Assertion> =
        fact.map (fun value -> value.Assertion(AnonymousIndividual this))

    member this.Facts(facts: Annotated<Fact> list) : Annotated<Assertion> list =
        facts |> List.map (fun fact -> this.Fact fact)

    member this.Type(description: Description) =
        Functional.ClassAssertion (AnonymousIndividual this) description.asClassExpression

    member this.Types(descriptions: Description list) = descriptions |> List.map this.Type

and Individual =
    | Individual of NamedIndividual
    | AnonymousIndividual of AnonymousIndividual

    member this.asSubject =
        match this with
        | Individual namedIndividual -> namedIndividual.asSubject
        | AnonymousIndividual anonymousIndividual -> anonymousIndividual.asSubject

    member this.asObject =
        match this with
        | Individual namedIndividual -> namedIndividual.asObject
        | AnonymousIndividual anonymousIndividual -> anonymousIndividual.asObject

    member this.SameAs(individual: Individual) =
        Functional.SameIndividual this individual

    member this.SameAs(individuals: Individual list) =
        Functional.SameIndividual(Set.TwoOrMore.More this individuals[0] (Set.ofList individuals[1..]))

    member this.SameAs(individual: NamedIndividual) =
        Functional.SameIndividual this (Individual individual)

    member this.SameAs(individuals: NamedIndividual list) =
        Functional.SameIndividual(
            Set.TwoOrMore.More this (Individual individuals[0]) (individuals[1..] |> List.map Individual |> Set.ofList)
        )

    member this.SameAs(individual: AnonymousIndividual) =
        Functional.SameIndividual this (AnonymousIndividual individual)

    member this.SameAs(individuals: AnonymousIndividual list) =
        Functional.SameIndividual(
            Set.TwoOrMore.More
                this
                (AnonymousIndividual individuals[0])
                (individuals[1..] |> List.map AnonymousIndividual |> Set.ofList)
        )

    member this.DifferentFrom(individual: Individual) =
        Functional.DifferentIndividuals this individual

    member this.DifferentFrom(individuals: Individual list) =
        Functional.DifferentIndividuals(Set.TwoOrMore.More this individuals[0] (Set.ofList individuals[1..]))

    member this.DifferentFrom(individual: NamedIndividual) =
        Functional.DifferentIndividuals this (Individual individual)

    member this.DifferentFrom(individuals: NamedIndividual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More this (Individual individuals[0]) (individuals[1..] |> List.map Individual |> Set.ofList)
        )

    member this.DifferentFrom(individual: AnonymousIndividual) =
        Functional.DifferentIndividuals this (AnonymousIndividual individual)

    member this.DifferentFrom(individuals: AnonymousIndividual list) =
        Functional.DifferentIndividuals(
            Set.TwoOrMore.More
                this
                (AnonymousIndividual individuals[0])
                (individuals[1..] |> List.map AnonymousIndividual |> Set.ofList)
        )

    member this.Fact(fact: Fact) = fact.Assertion this

    member this.Facts(facts: Fact list) =
        facts |> List.map (fun fact -> fact.Assertion this)

    member this.Fact(fact: Annotated<Fact>) : Annotated<Assertion> =
        fact.map (fun value -> value.Assertion this)

    member this.Facts(facts: Annotated<Fact> list) : Annotated<Assertion> list =
        facts |> List.map (fun fact -> this.Fact fact)

    member this.Type(description: Description) =
        Functional.ClassAssertion this description.asClassExpression

    member this.Types(descriptions: Description list) = descriptions |> List.map this.Type

and ObjectPropertyExpression =
    | ObjectProperty of ObjectProperty
    | ObjectInverse of ObjectProperty

    member this.objectProperty =
        match this with
        | ObjectProperty objectProperty -> objectProperty
        | ObjectInverse objectProperty -> objectProperty

    member this._some(primary: Primary) =
        this
        |> Restriction.ObjectSomeValuesFrom primary.asClassExpression
        |> RestrictionPrimary.ofRestriction

    member this._only(primary: Primary) =
        this
        |> Restriction.ObjectAllValuesFrom primary.asClassExpression
        |> RestrictionPrimary.ofRestriction

    member this._value(individual: Individual) =
        this
        |> Restriction.ObjectHasValue individual
        |> RestrictionPrimary.ofRestriction

    member this._min((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectMinCardinality(nonNegativeInteger, this, primary.asClassExpression)
        |> RestrictionPrimary.ofRestriction

    member this._min(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectMinCardinality(nonNegativeInteger, this, primary.asClassExpression)
            |> RestrictionPrimary.ofRestriction

    member this._min(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectMinCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._exactly((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectExactCardinality(nonNegativeInteger, this, primary.asClassExpression)
        |> RestrictionPrimary.ofRestriction

    member this._exactly(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectExactCardinality(nonNegativeInteger, this, primary.asClassExpression)
            |> RestrictionPrimary.ofRestriction

    member this._exactly(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectExactCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member this._max((nonNegativeInteger: NonNegativeInteger), (primary: Primary)) =
        Restriction.ObjectMaxCardinality(nonNegativeInteger, this, primary.asClassExpression)
        |> RestrictionPrimary.ofRestriction

    member this._max(primary: Primary) =
        fun (nonNegativeInteger: NonNegativeInteger) ->
            Restriction.ObjectMaxCardinality(nonNegativeInteger, this, primary.asClassExpression)
            |> RestrictionPrimary.ofRestriction

    member this._max(nonNegativeInteger: NonNegativeInteger) =
        Restriction.ObjectMaxCardinality(nonNegativeInteger, this)
        |> RestrictionPrimary.ofRestriction

    member self._Self = Restriction.ObjectHasSelf self |> RestrictionPrimary.ofRestriction

    member this._o(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.ObjectPropertyChain this objectPropertyExpression

and Entity =
    | ClassEntity of Class
    | DatatypeEntity of DatatypeIri
    | ObjectPropertyEntity of ObjectProperty
    | DataPropertyEntity of DataProperty
    | AnnotationPropertyEntity of AnnotationProperty
    | NamedIndividualEntity of NamedIndividual

and Cardinal =
    | MinimumCardinal of NonNegativeInteger
    | ExactCardinal of NonNegativeInteger
    | MaximumCardinal of NonNegativeInteger

and DatatypeRestriction =
    { datatype: DatatypeIri
      facetValues: Set.OneOrMore<FacetValue> }

and DataRange =
    | DatatypeRange of DatatypeIri
    | DataIntersection of Set.TwoOrMore<DataRange>
    | DataUnion of Set.TwoOrMore<DataRange>
    | DataComplement of DataRange
    | DataOne of Set.OneOrMore<Literal>
    | DatatypeRestriction of DatatypeRestriction

and ClassExpression =
    | ClassExpression of Class
    | ObjectIntersection of Set.TwoOrMore<ClassExpression>
    | ObjectUnion of Set.TwoOrMore<ClassExpression>
    | ObjectComplement of ClassExpression
    | ObjectOne of Set.OneOrMore<Individual>
    | RestrictionClassExpression of Restriction

    static member op_Implicit(class_: Class) = ClassExpression class_

and Restriction =
    | ExistentialClassRestriction of ClassExpressionRestriction
    | UniversalClassRestriction of ClassExpressionRestriction
    | IndividualValueRestriction of IndividualRestriction
    | SelfRestriction of ObjectPropertyExpression
    | ExistentialDataRangeRestriction of DataRangeRestriction
    | UniversalDataRangeRestriction of DataRangeRestriction
    | LiteralValueRestriction of LiteralRestriction
    | CardinalityRestriction of CardinalityRestriction

    static member ObjectSomeValuesFrom
        ((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression))
        =
        { onObjectProperty = objectPropertyExpression
          toClassExpression = classExpression }
        |> ExistentialClassRestriction

    static member ObjectSomeValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Restriction.ObjectSomeValuesFrom(objectPropertyExpression, classExpression)

    static member ObjectAllValuesFrom
        ((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression))
        =
        { onObjectProperty = objectPropertyExpression
          toClassExpression = classExpression }
        |> UniversalClassRestriction

    static member ObjectAllValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Restriction.ObjectAllValuesFrom(objectPropertyExpression, classExpression)

    static member ObjectHasValue((objectPropertyExpression: ObjectPropertyExpression), (individual: Individual)) =
        { onObjectPropertyExpression = objectPropertyExpression
          toIndividual = individual }
        |> IndividualValueRestriction

    static member ObjectHasValue(individual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Restriction.ObjectHasValue(objectPropertyExpression, individual)

    static member ObjectHasSelf(objectPropertyExpression: ObjectPropertyExpression) =
        objectPropertyExpression |> SelfRestriction

    // Tupled overloads preserve Restriction Syntax. Curried qualified forms begin
    // with the qualifier, then cardinality, then property expression.
    static member ObjectMinCardinality
        ((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression))
        =
        { cardinality = ObjectCardinality objectPropertyExpression
          cardinal = MinimumCardinal cardinal }
        |> CardinalityRestriction

    static member ObjectMinCardinality
        (
            (cardinal: NonNegativeInteger),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        { cardinality = (objectPropertyExpression, classExpression) |> ObjectQualifiedCardinality
          cardinal = MinimumCardinal cardinal }
        |> CardinalityRestriction

    static member ObjectMinCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression)

    static member ObjectMinCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectMaxCardinality
        ((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression))
        =
        { cardinality = ObjectCardinality objectPropertyExpression
          cardinal = MaximumCardinal cardinal }
        |> CardinalityRestriction

    static member ObjectMaxCardinality
        (
            (cardinal: NonNegativeInteger),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        { cardinality = (objectPropertyExpression, classExpression) |> ObjectQualifiedCardinality
          cardinal = MaximumCardinal cardinal }
        |> CardinalityRestriction

    static member ObjectMaxCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression)

    static member ObjectMaxCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectExactCardinality
        ((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression))
        =
        { cardinality = ObjectCardinality objectPropertyExpression
          cardinal = ExactCardinal cardinal }
        |> CardinalityRestriction

    static member ObjectExactCardinality
        (
            (cardinal: NonNegativeInteger),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        { cardinality = (objectPropertyExpression, classExpression) |> ObjectQualifiedCardinality
          cardinal = ExactCardinal cardinal }
        |> CardinalityRestriction

    static member ObjectExactCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression)

    static member ObjectExactCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression, classExpression)

    static member DataSomeValuesFrom((dataProperties: List.OneOrMore<DataProperty>), (dataRange: DataRange)) =
        { onDataProperties = dataProperties
          toDataRange = dataRange }
        |> ExistentialDataRangeRestriction

    static member DataSomeValuesFrom
        ((firstDataProperty: DataProperty), (moreDataProperties: DataProperty list), (dataRange: DataRange))
        =
        Restriction.DataSomeValuesFrom(List.OneOrMore.More(firstDataProperty, moreDataProperties), dataRange)

    static member DataSomeValuesFrom((dataProperty: DataProperty), (dataRange: DataRange)) =
        Restriction.DataSomeValuesFrom(List.OneOrMore.One dataProperty, dataRange)

    static member DataSomeValuesFrom(dataProperties: List.OneOrMore<DataProperty>) =
        fun (dataRange: DataRange) -> Restriction.DataSomeValuesFrom(dataProperties, dataRange)

    static member DataSomeValuesFrom(dataRange: DataRange) =
        fun (dataProperty: DataProperty) -> Restriction.DataSomeValuesFrom(dataProperty, dataRange)

    static member DataAllValuesFrom((dataProperties: List.OneOrMore<DataProperty>), (dataRange: DataRange)) =
        { onDataProperties = dataProperties
          toDataRange = dataRange }
        |> UniversalDataRangeRestriction

    static member DataAllValuesFrom
        ((firstDataProperty: DataProperty), (moreDataProperties: DataProperty list), (dataRange: DataRange))
        =
        Restriction.DataAllValuesFrom(List.OneOrMore.More(firstDataProperty, moreDataProperties), dataRange)

    static member DataAllValuesFrom((dataProperty: DataProperty), (dataRange: DataRange)) =
        Restriction.DataAllValuesFrom(List.OneOrMore.One dataProperty, dataRange)

    static member DataAllValuesFrom(dataProperties: List.OneOrMore<DataProperty>) =
        fun (dataRange: DataRange) -> Restriction.DataAllValuesFrom(dataProperties, dataRange)

    static member DataAllValuesFrom(dataRange: DataRange) =
        fun (dataProperty: DataProperty) -> Restriction.DataAllValuesFrom(dataProperty, dataRange)

    static member DataHasValue((dataProperty: DataProperty), (literal: Literal)) =
        { onDataProperty = dataProperty
          toLiteral = literal }
        |> LiteralValueRestriction

    static member DataHasValue(literal: Literal) =
        fun (dataProperty: DataProperty) -> Restriction.DataHasValue(dataProperty, literal)

    static member DataMinCardinality((cardinal: NonNegativeInteger), (dataProperty: DataProperty)) =
        { cardinality = DataCardinality dataProperty
          cardinal = MinimumCardinal cardinal }
        |> CardinalityRestriction

    static member DataMinCardinality
        ((cardinal: NonNegativeInteger), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        { cardinality = (dataProperty, dataRange) |> DataQualifiedCardinality
          cardinal = MinimumCardinal cardinal }
        |> CardinalityRestriction

    static member DataMinCardinality(cardinal: NonNegativeInteger) =
        fun (dataProperty: DataProperty) -> Restriction.DataMinCardinality(cardinal, dataProperty)

    static member DataMinCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataProperty: DataProperty) -> Restriction.DataMinCardinality(cardinal, dataProperty, dataRange)

    static member DataMaxCardinality((cardinal: NonNegativeInteger), (dataProperty: DataProperty)) =
        { cardinality = DataCardinality dataProperty
          cardinal = MaximumCardinal cardinal }
        |> CardinalityRestriction

    static member DataMaxCardinality
        ((cardinal: NonNegativeInteger), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        { cardinality = (dataProperty, dataRange) |> DataQualifiedCardinality
          cardinal = MaximumCardinal cardinal }
        |> CardinalityRestriction

    static member DataMaxCardinality(cardinal: NonNegativeInteger) =
        fun (dataProperty: DataProperty) -> Restriction.DataMaxCardinality(cardinal, dataProperty)

    static member DataMaxCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataProperty: DataProperty) -> Restriction.DataMaxCardinality(cardinal, dataProperty, dataRange)

    static member DataExactCardinality((cardinal: NonNegativeInteger), (dataProperty: DataProperty)) =
        { cardinality = DataCardinality dataProperty
          cardinal = ExactCardinal cardinal }
        |> CardinalityRestriction

    static member DataExactCardinality
        ((cardinal: NonNegativeInteger), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        { cardinality = (dataProperty, dataRange) |> DataQualifiedCardinality
          cardinal = ExactCardinal cardinal }
        |> CardinalityRestriction

    static member DataExactCardinality(cardinal: NonNegativeInteger) =
        fun (dataProperty: DataProperty) -> Restriction.DataExactCardinality(cardinal, dataProperty)

    static member DataExactCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataProperty: DataProperty) -> Restriction.DataExactCardinality(cardinal, dataProperty, dataRange)

and Cardinality =
    | ObjectCardinality of ObjectPropertyExpression
    | ObjectQualifiedCardinality of ObjectPropertyExpression * ClassExpression
    | DataCardinality of DataProperty
    | DataQualifiedCardinality of DataProperty * DataRange

and ClassExpressionRestriction =
    { onObjectProperty: ObjectPropertyExpression
      toClassExpression: ClassExpression }

and IndividualRestriction =
    { onObjectPropertyExpression: ObjectPropertyExpression
      toIndividual: Individual }

and DataRangeRestriction =
    { onDataProperties: List.OneOrMore<DataProperty>
      toDataRange: DataRange }

and LiteralRestriction =
    { onDataProperty: DataProperty
      toLiteral: Literal }

and CardinalityRestriction =
    { cardinality: Cardinality
      cardinal: Cardinal }

and Class with
    member this.Class = ClassExpression this

and SubClass =
    { subClassExpression: ClassExpression
      superClassExpression: ClassExpression }

and EquivalentClasses =
    { equivalentClasses: Set.TwoOrMore<ClassExpression> }

and DisjointClasses =
    { disjointClasses: Set.TwoOrMore<ClassExpression> }

and DisjointUnion =
    { disjointClass: Class
      disjointClassExpressions: Set.TwoOrMore<ClassExpression> }

and PropertyExpressionChain =
    { objectPropertyChain: List.TwoOrMore<ObjectPropertyExpression> }

    static member o
        ((propertyExpressionChain: PropertyExpressionChain), (objectPropertyExpression: ObjectPropertyExpression))
        =
        match propertyExpressionChain.objectPropertyChain.items with
        | first :: second :: rest ->
            List.TwoOrMore.More(first, second, rest @ [ objectPropertyExpression ])
            |> Functional.ObjectPropertyChain
        | _ -> invalidOp "Impossible List.TwoOrMore state."

    static member o(objectPropertyExpression: ObjectPropertyExpression) =
        fun (propertyExpressionChain: PropertyExpressionChain) ->
            PropertyExpressionChain.o (propertyExpressionChain, objectPropertyExpression)

    member this._o(objectPropertyExpression: ObjectPropertyExpression) =
        this |> PropertyExpressionChain.o objectPropertyExpression

and SubObjectPropertyExpression =
    | SubObjectPropertyExpression of ObjectPropertyExpression
    | PropertyExpressionChain of PropertyExpressionChain

and SubObjectProperty =
    { subObjectPropertyExpression: SubObjectPropertyExpression
      superObjectPropertyExpression: ObjectPropertyExpression }

and EquivalentObjectPropertyExpressions =
    { equivalentObjectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression> }

and DisjointObjectPropertyExpressions =
    { disjointObjectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression> }

and ObjectPropertyDomain =
    { objectPropertyExpression: ObjectPropertyExpression
      objectPropertyDomain: ClassExpression }

and ObjectPropertyRange =
    { objectPropertyExpression: ObjectPropertyExpression
      objectPropertyRange: ClassExpression }

and InverseObjectProperties =
    { inverseObjectProperties: ObjectPropertyExpression * ObjectPropertyExpression }

and FunctionalObjectProperty =
    { functionalObjectProperty: ObjectPropertyExpression }

and InverseFunctionalObjectProperty =
    { inverseFunctionalObjectProperty: ObjectPropertyExpression }

and ReflexiveObjectProperty =
    { reflexiveObjectProperty: ObjectPropertyExpression }

and IrreflexiveObjectProperty =
    { irreflexiveObjectProperty: ObjectPropertyExpression }

and SymmetricObjectProperty =
    { symmetricObjectProperty: ObjectPropertyExpression }

and AsymmetricObjectProperty =
    { asymmetricObjectProperty: ObjectPropertyExpression }

and TransitiveObjectProperty =
    { transitiveObjectProperty: ObjectPropertyExpression }

and ObjectPropertyAxiom =
    | SubObjectProperty of SubObjectProperty
    | EquivalentObjectProperties of EquivalentObjectPropertyExpressions
    | DisjointObjectProperties of DisjointObjectPropertyExpressions
    | InverseObjectProperties of InverseObjectProperties
    | ObjectPropertyDomain of ObjectPropertyDomain
    | ObjectPropertyRange of ObjectPropertyRange
    | FunctionalObjectProperty of FunctionalObjectProperty
    | InverseFunctionalObjectProperty of InverseFunctionalObjectProperty
    | ReflexiveObjectProperty of ReflexiveObjectProperty
    | IrreflexiveObjectProperty of IrreflexiveObjectProperty
    | SymmetricObjectProperty of SymmetricObjectProperty
    | AsymmetricObjectProperty of AsymmetricObjectProperty
    | TransitiveObjectProperty of TransitiveObjectProperty

and ClassAxiom =
    | SubClassAxiom of SubClass
    | EquivalentClassesAxiom of EquivalentClasses
    | DisjointClassesAxiom of DisjointClasses
    | DisjointUnionAxiom of DisjointUnion

and SubDataProperty =
    { subDataProperty: DataProperty
      superDataProperty: DataProperty }

and EquivalentDataProperties =
    { equivalentDataProperties: Set.TwoOrMore<DataProperty> }

and DisjointDataProperties =
    { disjointDataProperties: Set.TwoOrMore<DataProperty> }

and DataPropertyDomain =
    { dataProperty: DataProperty
      dataPropertyDomain: ClassExpression }

and DataPropertyRange =
    { dataProperty: DataProperty
      dataPropertyRange: DataRange }

and FunctionalDataProperty =
    { functionalDataProperty: DataProperty }

and DataPropertyAxiom =
    | SubDataProperty of SubDataProperty
    | EquivalentDataProperties of EquivalentDataProperties
    | DisjointDataProperties of DisjointDataProperties
    | DataPropertyDomain of DataPropertyDomain
    | DataPropertyRange of DataPropertyRange
    | FunctionalDataProperty of FunctionalDataProperty

and KeyProperties =
    | ObjectDataKeyProperties of Set.OneOrMore<ObjectPropertyExpression> * Set.OneOrMore<DataProperty>
    | ObjectKeyProperties of Set.OneOrMore<ObjectPropertyExpression>
    | DataKeyProperties of Set.OneOrMore<DataProperty>

and SameIndividual =
    { SameIndividual: Set.TwoOrMore<Individual> }

and DifferentIndividuals =
    { DifferentIndividuals: Set.TwoOrMore<Individual> }

and ClassAssertion =
    { individual: Individual
      classExpression: ClassExpression }

and ObjectPropertyAssertion =
    { sourceIndividual: Individual
      objectPropertyExpression: ObjectPropertyExpression
      targetIndividual: Individual }

and NegativeObjectPropertyAssertion =
    { sourceIndividual: Individual
      negativeObjectPropertyExpression: ObjectPropertyExpression
      targetIndividual: Individual }

and DataPropertyAssertion =
    { sourceIndividual: Individual
      dataProperty: DataProperty
      targetValue: Literal }

and NegativeDataPropertyAssertion =
    { sourceIndividual: Individual
      negativeDataProperty: DataProperty
      targetValue: Literal }

and Assertion =
    | SameIndividual of SameIndividual
    | DifferentIndividuals of DifferentIndividuals
    | ClassAssertion of ClassAssertion
    | ObjectPropertyAssertion of ObjectPropertyAssertion
    | NegativeObjectPropertyAssertion of NegativeObjectPropertyAssertion
    | DataPropertyAssertion of DataPropertyAssertion
    | NegativeDataPropertyAssertion of NegativeDataPropertyAssertion

and AnnotationAssertion =
    { annotationSubject: NormativeSubject
      annotationProperty: AnnotationProperty
      annotationValue: BasicNormativeObject }

and SubAnnotationProperty =
    { subAnnotationProperty: AnnotationProperty
      superAnnotationProperty: AnnotationProperty }

and AnnotationPropertyDomain =
    { annotationProperty: AnnotationProperty
      domainIri: Iri }

and AnnotationPropertyRange =
    { annotationProperty: AnnotationProperty
      rangeIri: Iri }

and AnnotationAxiom =
    | AnnotationAssertion of AnnotationAssertion
    | SubAnnotationProperty of SubAnnotationProperty
    | AnnotationPropertyDomain of AnnotationPropertyDomain
    | AnnotationPropertyRange of AnnotationPropertyRange

and Declaration = { entity: Entity }

and DatatypeDefinition =
    { datatype: DatatypeIri
      dataRange: DataRange }

and HasKey =
    { classExpression: ClassExpression
      keyProperties: KeyProperties }

and Axiom =
    | Declaration of Declaration
    | ClassAxiom of ClassAxiom
    | ObjectPropertyAxiom of ObjectPropertyAxiom
    | DataPropertyAxiom of DataPropertyAxiom
    | DatatypeDefinition of DatatypeDefinition
    | HasKey of HasKey
    | Assertion of Assertion
    | AnnotationAxiom of AnnotationAxiom

and Ontology =
    { ontologyIdentifier: (OntologyIri * VersionIri option) option
      directlyImportsDocuments: Set<DirectlyImportsDocument>
      statedAxioms: Set<Annotated<Axiom>>
      constructedFrames: Frame list
      assertedTriples: Set<NormativeTriple> }

    member this.tryOntologyIri =
        match this.ontologyIdentifier with
        | Some(OntologyIri ontologyIri, Some(VersionIri versionIri)) -> Some ontologyIri
        | Some(OntologyIri ontologyIri, _) -> Some ontologyIri
        | _ -> None

    member this.tryVersionIri =
        match this.ontologyIdentifier with
        | Some(OntologyIri ontologyIri, Some(VersionIri versionIri)) -> Some versionIri
        | _ -> None

    member this.triples = this.assertedTriples

    member this.axioms =
        this.statedAxioms
        + (this.constructedFrames
           |> List.collect (fun frame -> frame.axioms |> Set.toList)
           |> Set.ofList)

    static member Import(importIri: DirectlyImportsDocument) =
        fun (ontology: Ontology) ->
            { ontology with
                directlyImportsDocuments = Set.add importIri ontology.directlyImportsDocuments }

    static member Import(directlyImportsDocuments: DirectlyImportsDocument list) =
        fun (ontology: Ontology) ->
            { ontology with
                directlyImportsDocuments =
                    ontology.directlyImportsDocuments
                    |> Set.union (Set.ofList directlyImportsDocuments) }

    static member Import(fromOntology: Ontology) =
        fun (toOntology: Ontology) ->
            match fromOntology.ontologyIdentifier with
            | Some(OntologyIri ontologyIri, Some(VersionIri versionIri)) ->
                { toOntology with
                    directlyImportsDocuments = toOntology.directlyImportsDocuments |> Set.add (Import versionIri) }
            | Some(OntologyIri ontologyIri, _) ->
                { toOntology with
                    directlyImportsDocuments = toOntology.directlyImportsDocuments |> Set.add (Import ontologyIri) }
            | _ -> toOntology

and OntologyDocument =
    | OntologyDocument of Set<PrefixDeclaration> * Annotated<Ontology>
    | Ontology of Annotated<Ontology>

// Tupled overloads preserve OWL Functional-Style Syntax operand order.
// Curried assertion overloads use subject -> predicate -> object order where applicable.
// Other curried overloads favor partial application; qualified cardinalities begin with the qualifier.
// Annotation-bearing productions return Annotated<'T>; the wrapped value remains the bare OWL structural type.
and Functional =

    static member Prefix((prefixName: string), (fullIri: IriReference)) = Prefix(prefixName, fullIri)

    static member Prefix(prefixName: string) =
        fun (fullIri: IriReference) -> Functional.Prefix(prefixName, fullIri)

    static member OntologyDocument(prefixDeclarations: Set<PrefixDeclaration>) =
        fun (ontology: Annotated<Ontology>) -> OntologyDocument(prefixDeclarations, ontology)

    static member OntologyDocument(ontology: Annotated<Ontology>) = OntologyDocument(Set.empty, ontology)

    static member Ontology
        (
            (ontologyIdentifier: (OntologyIri * VersionIri option) option),
            (directlyImportsDocuments: Set<DirectlyImportsDocument>),
            (ontologyAnnotations: Set<Annotation>),
            (axioms: Set<Annotated<Axiom>>)
        ) : Annotated<Ontology> =
        let ontology: Ontology =
            { ontologyIdentifier = ontologyIdentifier
              directlyImportsDocuments = directlyImportsDocuments
              statedAxioms = axioms
              constructedFrames = List.empty
              assertedTriples = Set.empty }

        Annotated.Annotate(ontologyAnnotations, ontology)

    static member Ontology
        (
            (ontologyIri: OntologyIri),
            (versionIri: VersionIri),
            (directlyImportsDocuments: Set<DirectlyImportsDocument>),
            (ontologyAnnotations: Set<Annotation>),
            (axioms: Set<Annotated<Axiom>>)
        ) =
        Functional.Ontology(Some(ontologyIri, Some versionIri), directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Ontology((ontologyIri: OntologyIri), (versionIri: VersionIri)) =
        fun (directlyImportsDocuments: Set<DirectlyImportsDocument>) ->
            fun (ontologyAnnotations: Set<Annotation>) ->
                fun (axioms: Set<Annotated<Axiom>>) ->
                    Functional.Ontology(ontologyIri, versionIri, directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Ontology
        (
            (ontologyIri: OntologyIri),
            (directlyImportsDocuments: Set<DirectlyImportsDocument>),
            (ontologyAnnotations: Set<Annotation>),
            (axioms: Set<Annotated<Axiom>>)
        ) =
        Functional.Ontology(Some(ontologyIri, None), directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Ontology(ontologyIri: OntologyIri) =
        fun (directlyImportsDocuments: Set<DirectlyImportsDocument>) ->
            fun (ontologyAnnotations: Set<Annotation>) ->
                fun (axioms: Set<Annotated<Axiom>>) ->
                    Functional.Ontology(ontologyIri, directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Ontology
        (
            (directlyImportsDocuments: Set<DirectlyImportsDocument>),
            (ontologyAnnotations: Set<Annotation>),
            (axioms: Set<Annotated<Axiom>>)
        ) =
        Functional.Ontology(None, directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Ontology(directlyImportsDocuments: Set<DirectlyImportsDocument>) =
        fun (ontologyAnnotations: Set<Annotation>) ->
            fun (axioms: Set<Annotated<Axiom>>) ->
                Functional.Ontology(directlyImportsDocuments, ontologyAnnotations, axioms)

    static member Declaration((axiomAnnotations: Set<Annotation>), (entity: Entity)) : Annotated<Declaration> =
        let declaration: Declaration = { entity = entity }
        Annotated.Annotate(axiomAnnotations, declaration)

    static member Declaration(axiomAnnotations: Set<Annotation>) =
        fun (entity: Entity) -> Functional.Declaration(axiomAnnotations, entity)

    static member Declaration(entity: Entity) =
        Functional.Declaration(Set.empty, entity)

    static member Class(iri: Iri) = iri |> ClassIri |> ClassEntity
    static member Class(class_: Class) = ClassEntity class_
    static member Datatype(datatype: DatatypeIri) = DatatypeEntity datatype

    static member ObjectProperty(iri: Iri) =
        iri |> ObjectPropertyIri |> ObjectPropertyEntity

    static member ObjectProperty(objectProperty: ObjectProperty) = ObjectPropertyEntity objectProperty

    static member DataProperty(iri: Iri) =
        iri |> DataPropertyIri |> DataPropertyEntity

    static member DataProperty(dataProperty: DataProperty) = DataPropertyEntity dataProperty

    static member AnnotationProperty(iri: Iri) =
        iri |> AnnotationPropertyIri |> AnnotationPropertyEntity

    static member AnnotationProperty(annotationProperty: AnnotationProperty) =
        AnnotationPropertyEntity annotationProperty

    static member NamedIndividual(iri: Iri) =
        iri |> NamedIndividualIri |> NamedIndividualEntity

    static member NamedIndividual(namedIndividual: NamedIndividual) = NamedIndividualEntity namedIndividual

    static member AsClassExpression(class_: Class) = ClassExpression class_
    static member AsObjectPropertyExpression(objectProperty: ObjectProperty) = ObjectProperty objectProperty
    static member AsIndividual(namedIndividual: NamedIndividual) = Individual namedIndividual
    static member AsIndividual(anonymousIndividual: AnonymousIndividual) = AnonymousIndividual anonymousIndividual
    static member AsDataRange(datatype: DatatypeIri) = DatatypeRange datatype

    static member Annotation
        (
            (annotationAnnotations: Set<Annotation>),
            (annotationProperty: AnnotationProperty),
            (annotationValue: BasicNormativeObject)
        ) =
        { annotationAnnotations = annotationAnnotations
          annotationProperty = annotationProperty
          annotationValue = annotationValue }

    static member Annotation(annotationAnnotations: Set<Annotation>) =
        fun (annotationProperty: AnnotationProperty) ->
            fun (annotationValue: BasicNormativeObject) ->
                Functional.Annotation(annotationAnnotations, annotationProperty, annotationValue)

    static member Annotation((annotationProperty: AnnotationProperty), (annotationValue: BasicNormativeObject)) =
        Functional.Annotation(Set.empty, annotationProperty, annotationValue)

    static member Annotation(annotationProperty: AnnotationProperty) =
        fun (annotationValue: BasicNormativeObject) -> Functional.Annotation(annotationProperty, annotationValue)

    static member AnnotationAssertion
        (
            (axiomAnnotations: Set<Annotation>),
            (annotationProperty: AnnotationProperty),
            (annotationSubject: NormativeSubject),
            (annotationValue: BasicNormativeObject)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { annotationSubject = annotationSubject
              annotationProperty = annotationProperty
              annotationValue = annotationValue }
        )

    static member AnnotationAssertion(axiomAnnotations: Set<Annotation>) =
        fun (annotationSubject: NormativeSubject) ->
            fun (annotationProperty: AnnotationProperty) ->
                fun (annotationValue: BasicNormativeObject) ->
                    Functional.AnnotationAssertion(
                        axiomAnnotations,
                        annotationProperty,
                        annotationSubject,
                        annotationValue
                    )

    static member AnnotationAssertion
        (
            (annotationProperty: AnnotationProperty),
            (annotationSubject: NormativeSubject),
            (annotationValue: BasicNormativeObject)
        ) =
        Functional.AnnotationAssertion(Set.empty, annotationProperty, annotationSubject, annotationValue)

    static member AnnotationAssertion(annotationSubject: NormativeSubject) =
        fun (annotationProperty: AnnotationProperty) ->
            fun (annotationValue: BasicNormativeObject) ->
                Functional.AnnotationAssertion(annotationProperty, annotationSubject, annotationValue)

    static member SubAnnotationPropertyOf
        (
            (axiomAnnotations: Set<Annotation>),
            (subAnnotationProperty: AnnotationProperty),
            (superAnnotationProperty: AnnotationProperty)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { subAnnotationProperty = subAnnotationProperty
              superAnnotationProperty = superAnnotationProperty }
        )

    static member SubAnnotationPropertyOf(axiomAnnotations: Set<Annotation>) =
        fun (subAnnotationProperty: AnnotationProperty) ->
            fun (superAnnotationProperty: AnnotationProperty) ->
                Functional.SubAnnotationPropertyOf(axiomAnnotations, subAnnotationProperty, superAnnotationProperty)

    static member SubAnnotationPropertyOf
        ((subAnnotationProperty: AnnotationProperty), (superAnnotationProperty: AnnotationProperty))
        =
        Functional.SubAnnotationPropertyOf(Set.empty, subAnnotationProperty, superAnnotationProperty)

    static member SubAnnotationPropertyOf(subAnnotationProperty: AnnotationProperty) =
        fun (superAnnotationProperty: AnnotationProperty) ->
            Functional.SubAnnotationPropertyOf(subAnnotationProperty, superAnnotationProperty)

    static member AnnotationPropertyDomain
        ((axiomAnnotations: Set<Annotation>), (annotationProperty: AnnotationProperty), (domainIri: Iri))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { annotationProperty = annotationProperty
              domainIri = domainIri }
        )

    static member AnnotationPropertyDomain(axiomAnnotations: Set<Annotation>) =
        fun (annotationProperty: AnnotationProperty) ->
            fun (domainIri: Iri) -> Functional.AnnotationPropertyDomain(axiomAnnotations, annotationProperty, domainIri)

    static member AnnotationPropertyDomain((annotationProperty: AnnotationProperty), (domainIri: Iri)) =
        Functional.AnnotationPropertyDomain(Set.empty, annotationProperty, domainIri)

    static member AnnotationPropertyDomain(annotationProperty: AnnotationProperty) =
        fun (domainIri: Iri) -> Functional.AnnotationPropertyDomain(annotationProperty, domainIri)

    static member AnnotationPropertyRange
        ((axiomAnnotations: Set<Annotation>), (annotationProperty: AnnotationProperty), (rangeIri: Iri))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { annotationProperty = annotationProperty
              rangeIri = rangeIri }
        )

    static member AnnotationPropertyRange(axiomAnnotations: Set<Annotation>) =
        fun (annotationProperty: AnnotationProperty) ->
            fun (rangeIri: Iri) -> Functional.AnnotationPropertyRange(axiomAnnotations, annotationProperty, rangeIri)

    static member AnnotationPropertyRange((annotationProperty: AnnotationProperty), (rangeIri: Iri)) =
        Functional.AnnotationPropertyRange(Set.empty, annotationProperty, rangeIri)

    static member AnnotationPropertyRange(annotationProperty: AnnotationProperty) =
        fun (rangeIri: Iri) -> Functional.AnnotationPropertyRange(annotationProperty, rangeIri)

    static member ObjectInverseOf(objectProperty: ObjectProperty) = ObjectInverse objectProperty

    static member DataIntersectionOf
        ((firstDataRange: DataRange), (secondDataRange: DataRange), (moreDataRanges: Set<DataRange>))
        =
        Set.TwoOrMore.More(firstDataRange, secondDataRange, moreDataRanges)
        |> DataIntersection

    static member DataIntersectionOf((firstDataRange: DataRange), (secondDataRange: DataRange)) =
        Set.TwoOrMore.Two(firstDataRange, secondDataRange) |> DataIntersection

    static member DataIntersectionOf(dataRanges: Set.TwoOrMore<DataRange>) = dataRanges |> DataIntersection

    static member DataIntersectionOf(firstDataRange: DataRange) =
        fun (secondDataRange: DataRange) -> Functional.DataIntersectionOf(firstDataRange, secondDataRange)

    static member DataUnionOf
        ((firstDataRange: DataRange), (secondDataRange: DataRange), (moreDataRanges: Set<DataRange>))
        =
        Set.TwoOrMore.More(firstDataRange, secondDataRange, moreDataRanges) |> DataUnion

    static member DataUnionOf((firstDataRange: DataRange), (secondDataRange: DataRange)) =
        Set.TwoOrMore.Two(firstDataRange, secondDataRange) |> DataUnion

    static member DataUnionOf(dataRanges: Set.TwoOrMore<DataRange>) = dataRanges |> DataUnion

    static member DataUnionOf(firstDataRange: DataRange) =
        fun (secondDataRange: DataRange) -> Functional.DataUnionOf(firstDataRange, secondDataRange)

    static member DataComplementOf(dataRange: DataRange) = dataRange |> DataComplement

    static member DataOneOf((firstLiteral: Literal), (moreLiterals: Set<Literal>)) =
        Set.OneOrMore.More(firstLiteral, moreLiterals) |> DataOne

    static member DataOneOf(literals: Set.OneOrMore<Literal>) = literals |> DataOne

    static member DataOneOf(firstLiteral: Literal) =
        firstLiteral |> Set.OneOrMore.One |> DataOne

    static member FacetValue((constrainingFacet: FacetIri), (restrictionValue: Literal)) =
        { constrainingFacet = constrainingFacet
          restrictionValue = restrictionValue }

    static member FacetValue((constrainingFacet: FacetIri), (staticTypedLiteral: StaticTypedLiteral<_>)) =
        Functional.FacetValue(constrainingFacet, StaticTypedLiteral.toLiteral staticTypedLiteral)

    static member FacetValue((constrainingFacet: FacetIri), (typedLiteral: TypedLiteral)) =
        Functional.FacetValue(constrainingFacet, TypedLiteral typedLiteral)

    static member FacetValue(staticTypedLiteral: StaticTypedLiteral<_>) =
        fun (constrainingFacet: FacetIri) -> Functional.FacetValue(constrainingFacet, staticTypedLiteral)

    static member FacetValue(typedLiteral: TypedLiteral) =
        fun (constrainingFacet: FacetIri) -> Functional.FacetValue(constrainingFacet, typedLiteral)

    static member FacetValue(literal: Literal) =
        fun (constrainingFacet: FacetIri) -> Functional.FacetValue(constrainingFacet, literal)

    static member DatatypeRestriction((datatype: DatatypeIri), (facetValues: Set.OneOrMore<FacetValue>)) =
        { datatype = datatype
          facetValues = facetValues }

    static member DatatypeRestriction((datatype: DatatypeIri), (facetValue: FacetValue)) =
        Functional.DatatypeRestriction(datatype, Set.OneOrMore.One facetValue)

    static member DatatypeRestriction
        ((datatype: DatatypeIri), (firstConstraint: FacetValue), (moreConstraints: Set<FacetValue>))
        =
        Functional.DatatypeRestriction(datatype, Set.OneOrMore.More(firstConstraint, moreConstraints))

    static member DatatypeRestriction
        (
            (datatype: DatatypeIri),
            (constrainingFacet: FacetIri),
            (restrictionValue: Literal),
            (moreConstraints: Set<FacetValue>)
        ) =
        Functional.DatatypeRestriction(
            datatype,
            Functional.FacetValue(constrainingFacet, restrictionValue),
            moreConstraints
        )

    static member DatatypeRestriction
        ((datatype: DatatypeIri), (constrainingFacet: FacetIri), (restrictionValue: Literal))
        =
        Functional.DatatypeRestriction(datatype, Functional.FacetValue(constrainingFacet, restrictionValue))

    static member DatatypeRestriction(datatype: DatatypeIri) =
        fun (constrainingFacet: FacetIri) ->
            fun (restrictionValue: Literal) ->
                Functional.DatatypeRestriction(datatype, constrainingFacet, restrictionValue)

    static member DatatypeRestriction(facetValue: FacetValue) =
        fun (datatype: DatatypeIri) -> Functional.DatatypeRestriction(datatype, facetValue)

    static member ObjectIntersectionOf
        (
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        |> ObjectIntersection

    static member ObjectIntersectionOf
        ((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression))
        =
        Set.TwoOrMore.Two(firstClassExpression, secondClassExpression)
        |> ObjectIntersection

    static member ObjectIntersectionOf(classExpressions: Set.TwoOrMore<ClassExpression>) =
        classExpressions |> ObjectIntersection

    static member ObjectIntersectionOf(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) ->
            Functional.ObjectIntersectionOf(firstClassExpression, secondClassExpression)

    static member ObjectUnionOf
        (
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        |> ObjectUnion

    static member ObjectUnionOf((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Set.TwoOrMore.Two(firstClassExpression, secondClassExpression) |> ObjectUnion

    static member ObjectUnionOf(classExpressions: Set.TwoOrMore<ClassExpression>) = ObjectUnion classExpressions

    static member ObjectUnionOf(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) ->
            Functional.ObjectUnionOf(firstClassExpression, secondClassExpression)

    static member ObjectComplementOf(classExpression: ClassExpression) = ObjectComplement classExpression

    static member ObjectOneOf((firstIndividual: Individual), (moreIndividuals: Set<Individual>)) =
        Set.OneOrMore.More(firstIndividual, moreIndividuals) |> ObjectOne

    static member ObjectOneOf(individuals: Set.OneOrMore<Individual>) = ObjectOne individuals

    static member ObjectOneOf(firstIndividual: Individual) =
        firstIndividual |> Set.OneOrMore.One |> ObjectOne

    static member ObjectSomeValuesFrom
        ((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression))
        =
        objectPropertyExpression
        |> Restriction.ObjectSomeValuesFrom classExpression
        |> RestrictionClassExpression

    static member ObjectSomeValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            objectPropertyExpression
            |> Restriction.ObjectSomeValuesFrom classExpression
            |> RestrictionClassExpression

    static member ObjectAllValuesFrom
        ((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression))
        =
        objectPropertyExpression
        |> Restriction.ObjectAllValuesFrom classExpression
        |> RestrictionClassExpression

    static member ObjectAllValuesFrom(classExpression: ClassExpression) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            objectPropertyExpression
            |> Restriction.ObjectAllValuesFrom classExpression
            |> RestrictionClassExpression

    static member ObjectHasValue((objectPropertyExpression: ObjectPropertyExpression), (individual: Individual)) =
        objectPropertyExpression
        |> Restriction.ObjectHasValue individual
        |> RestrictionClassExpression

    static member ObjectHasValue(individual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            objectPropertyExpression
            |> Restriction.ObjectHasValue individual
            |> RestrictionClassExpression

    static member ObjectHasSelf(objectPropertyExpression: ObjectPropertyExpression) =
        Restriction.ObjectHasSelf objectPropertyExpression |> RestrictionClassExpression

    // Tupled overloads preserve Functional Syntax. Curried qualified forms begin
    // with the qualifier, then cardinality, then property expression.
    static member ObjectMinCardinality
        ((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression)
        |> RestrictionClassExpression

    static member ObjectMinCardinality
        (
            (cardinal: NonNegativeInteger),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        Restriction.ObjectMinCardinality(cardinal, objectPropertyExpression, classExpression)
        |> RestrictionClassExpression

    static member ObjectMinCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.ObjectMinCardinality(cardinal, objectPropertyExpression)

    static member ObjectMinCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                Functional.ObjectMinCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectMaxCardinality
        ((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression)
        |> RestrictionClassExpression

    static member ObjectMaxCardinality
        (
            (cardinal: NonNegativeInteger),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        Restriction.ObjectMaxCardinality(cardinal, objectPropertyExpression, classExpression)
        |> RestrictionClassExpression

    static member ObjectMaxCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.ObjectMaxCardinality(cardinal, objectPropertyExpression)

    static member ObjectMaxCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                Functional.ObjectMaxCardinality(cardinal, objectPropertyExpression, classExpression)

    static member ObjectExactCardinality
        ((cardinal: NonNegativeInteger), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression)
        |> RestrictionClassExpression

    static member ObjectExactCardinality
        (
            (cardinal: NonNegativeInteger),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        Restriction.ObjectExactCardinality(cardinal, objectPropertyExpression, classExpression)
        |> RestrictionClassExpression

    static member ObjectExactCardinality(cardinal: NonNegativeInteger) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.ObjectExactCardinality(cardinal, objectPropertyExpression)

    static member ObjectExactCardinality(classExpression: ClassExpression) =
        fun (cardinal: NonNegativeInteger) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                Functional.ObjectExactCardinality(cardinal, objectPropertyExpression, classExpression)

    static member DataSomeValuesFrom((dataProperties: List.OneOrMore<DataProperty>), (dataRange: DataRange)) =
        Restriction.DataSomeValuesFrom(dataProperties, dataRange)
        |> RestrictionClassExpression

    static member DataSomeValuesFrom
        ((firstDataProperty: DataProperty), (moreDataProperties: DataProperty list), (dataRange: DataRange))
        =
        Functional.DataSomeValuesFrom(List.OneOrMore.More(firstDataProperty, moreDataProperties), dataRange)

    static member DataSomeValuesFrom((dataProperty: DataProperty), (dataRange: DataRange)) =
        Functional.DataSomeValuesFrom(List.OneOrMore.One dataProperty, dataRange)

    static member DataSomeValuesFrom(dataPropertys: List.OneOrMore<DataProperty>) =
        fun (dataRange: DataRange) -> Functional.DataSomeValuesFrom(dataPropertys, dataRange)

    static member DataSomeValuesFrom(dataRange: DataRange) =
        fun (dataProperty: DataProperty) -> Functional.DataSomeValuesFrom(dataProperty, dataRange)

    static member DataAllValuesFrom((dataPropertys: List.OneOrMore<DataProperty>), (dataRange: DataRange)) =
        Restriction.DataAllValuesFrom(dataPropertys, dataRange)
        |> RestrictionClassExpression

    static member DataAllValuesFrom
        ((firstDataProperty: DataProperty), (moreDataPropertys: DataProperty list), (dataRange: DataRange))
        =
        Functional.DataAllValuesFrom(List.OneOrMore.More(firstDataProperty, moreDataPropertys), dataRange)

    static member DataAllValuesFrom((dataProperty: DataProperty), (dataRange: DataRange)) =
        Functional.DataAllValuesFrom(List.OneOrMore.One dataProperty, dataRange)

    static member DataAllValuesFrom(dataPropertys: List.OneOrMore<DataProperty>) =
        fun (dataRange: DataRange) -> Functional.DataAllValuesFrom(dataPropertys, dataRange)

    static member DataAllValuesFrom(dataRange: DataRange) =
        fun (dataProperty: DataProperty) -> Functional.DataAllValuesFrom(dataProperty, dataRange)

    static member DataHasValue((dataProperty: DataProperty), (literal: Literal)) =
        Restriction.DataHasValue(dataProperty, literal) |> RestrictionClassExpression

    static member DataHasValue(literal: Literal) =
        fun (dataProperty: DataProperty) -> Functional.DataHasValue(dataProperty, literal)

    static member DataMinCardinality((cardinal: NonNegativeInteger), (dataProperty: DataProperty)) =
        Restriction.DataMinCardinality(cardinal, dataProperty)
        |> RestrictionClassExpression

    static member DataMinCardinality
        ((cardinal: NonNegativeInteger), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        Restriction.DataMinCardinality(cardinal, dataProperty, dataRange)
        |> RestrictionClassExpression

    static member DataMinCardinality(cardinal: NonNegativeInteger) =
        fun (dataProperty: DataProperty) -> Functional.DataMinCardinality(cardinal, dataProperty)

    static member DataMinCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataProperty: DataProperty) -> Functional.DataMinCardinality(cardinal, dataProperty, dataRange)

    static member DataMaxCardinality((cardinal: NonNegativeInteger), (dataProperty: DataProperty)) =
        Restriction.DataMaxCardinality(cardinal, dataProperty)
        |> RestrictionClassExpression

    static member DataMaxCardinality
        ((cardinal: NonNegativeInteger), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        Restriction.DataMaxCardinality(cardinal, dataProperty, dataRange)
        |> RestrictionClassExpression

    static member DataMaxCardinality(cardinal: NonNegativeInteger) =
        fun (dataProperty: DataProperty) -> Functional.DataMaxCardinality(cardinal, dataProperty)

    static member DataMaxCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataProperty: DataProperty) -> Functional.DataMaxCardinality(cardinal, dataProperty, dataRange)

    static member DataExactCardinality((cardinal: NonNegativeInteger), (dataProperty: DataProperty)) =
        Restriction.DataExactCardinality(cardinal, dataProperty)
        |> RestrictionClassExpression

    static member DataExactCardinality
        ((cardinal: NonNegativeInteger), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        Restriction.DataExactCardinality(cardinal, dataProperty, dataRange)
        |> RestrictionClassExpression

    static member DataExactCardinality(cardinal: NonNegativeInteger) =
        fun (dataProperty: DataProperty) -> Functional.DataExactCardinality(cardinal, dataProperty)

    static member DataExactCardinality(dataRange: DataRange) =
        fun (cardinal: NonNegativeInteger) ->
            fun (dataProperty: DataProperty) -> Functional.DataExactCardinality(cardinal, dataProperty, dataRange)

    static member SubClassOf
        (
            (axiomAnnotations: Set<Annotation>),
            (subClassExpression: ClassExpression),
            (superClassExpression: ClassExpression)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { subClassExpression = subClassExpression
              superClassExpression = superClassExpression }
        )

    static member SubClassOf(axiomAnnotations: Set<Annotation>) =
        fun (subClassExpression: ClassExpression) ->
            fun (superClassExpression: ClassExpression) ->
                Functional.SubClassOf(axiomAnnotations, subClassExpression, superClassExpression)

    static member SubClassOf((subClassExpression: ClassExpression), (superClassExpression: ClassExpression)) =
        Functional.SubClassOf(Set.empty, subClassExpression, superClassExpression)

    static member SubClassOf(subClassExpression: ClassExpression) =
        fun (superClassExpression: ClassExpression) -> Functional.SubClassOf(subClassExpression, superClassExpression)

    static member EquivalentClasses
        ((axiomAnnotations: Set<Annotation>), (classExpressions: Set.TwoOrMore<ClassExpression>))
        =
        Annotated.Annotate(axiomAnnotations, { equivalentClasses = classExpressions })

    static member EquivalentClasses
        (
            (axiomAnnotations: Set<Annotation>),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.EquivalentClasses(
            axiomAnnotations,
            Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        )

    static member EquivalentClasses
        (
            (axiomAnnotations: Set<Annotation>),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression)
        ) =
        Functional.EquivalentClasses(axiomAnnotations, Set.TwoOrMore.Two(firstClassExpression, secondClassExpression))

    static member EquivalentClasses(axiomAnnotations: Set<Annotation>) =
        fun (firstClassExpression: ClassExpression) ->
            fun (secondClassExpression: ClassExpression) ->
                Functional.EquivalentClasses(axiomAnnotations, firstClassExpression, secondClassExpression)

    static member EquivalentClasses(classExpressions: Set.TwoOrMore<ClassExpression>) =
        Functional.EquivalentClasses(Set.empty, classExpressions)

    static member EquivalentClasses
        (
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.EquivalentClasses(Set.empty, firstClassExpression, secondClassExpression, moreClassExpressions)

    static member EquivalentClasses((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.EquivalentClasses(Set.empty, firstClassExpression, secondClassExpression)

    static member EquivalentClasses(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) ->
            Functional.EquivalentClasses(firstClassExpression, secondClassExpression)

    static member DisjointClasses
        ((axiomAnnotations: Set<Annotation>), (classExpressions: Set.TwoOrMore<ClassExpression>))
        =
        Annotated.Annotate(axiomAnnotations, { disjointClasses = classExpressions })

    static member DisjointClasses
        (
            (axiomAnnotations: Set<Annotation>),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.DisjointClasses(
            axiomAnnotations,
            Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        )

    static member DisjointClasses
        (
            (axiomAnnotations: Set<Annotation>),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression)
        ) =
        Functional.DisjointClasses(axiomAnnotations, Set.TwoOrMore.Two(firstClassExpression, secondClassExpression))

    static member DisjointClasses(axiomAnnotations: Set<Annotation>) =
        fun (firstClassExpression: ClassExpression) ->
            fun (secondClassExpression: ClassExpression) ->
                Functional.DisjointClasses(axiomAnnotations, firstClassExpression, secondClassExpression)

    static member DisjointClasses(classExpressions: Set.TwoOrMore<ClassExpression>) =
        Functional.DisjointClasses(Set.empty, classExpressions)

    static member DisjointClasses
        (
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.DisjointClasses(Set.empty, firstClassExpression, secondClassExpression, moreClassExpressions)

    static member DisjointClasses((firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression)) =
        Functional.DisjointClasses(Set.empty, firstClassExpression, secondClassExpression)

    static member DisjointClasses(firstClassExpression: ClassExpression) =
        fun (secondClassExpression: ClassExpression) ->
            Functional.DisjointClasses(firstClassExpression, secondClassExpression)

    static member DisjointUnion
        (
            (axiomAnnotations: Set<Annotation>),
            (disjointClass: Class),
            (disjointExpressions: Set.TwoOrMore<ClassExpression>)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { disjointClass = disjointClass
              disjointClassExpressions = disjointExpressions }
        )

    static member DisjointUnion
        (
            (axiomAnnotations: Set<Annotation>),
            (disjointClass: Class),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.DisjointUnion(
            axiomAnnotations,
            disjointClass,
            Set.TwoOrMore.More(firstClassExpression, secondClassExpression, moreClassExpressions)
        )

    static member DisjointUnion
        (
            (axiomAnnotations: Set<Annotation>),
            (disjointClass: Class),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression)
        ) =
        Functional.DisjointUnion(
            axiomAnnotations,
            disjointClass,
            Set.TwoOrMore.Two(firstClassExpression, secondClassExpression)
        )

    static member DisjointUnion(axiomAnnotations: Set<Annotation>) =
        fun (disjointClass: Class) ->
            fun (firstClassExpression: ClassExpression) ->
                fun (secondClassExpression: ClassExpression) ->
                    Functional.DisjointUnion(
                        axiomAnnotations,
                        disjointClass,
                        firstClassExpression,
                        secondClassExpression
                    )

    static member DisjointUnion((disjointClass: Class), (disjointExpressions: Set.TwoOrMore<ClassExpression>)) =
        Functional.DisjointUnion(Set.empty, disjointClass, disjointExpressions)

    static member DisjointUnion
        (
            (disjointClass: Class),
            (firstClassExpression: ClassExpression),
            (secondClassExpression: ClassExpression),
            (moreClassExpressions: Set<ClassExpression>)
        ) =
        Functional.DisjointUnion(
            Set.empty,
            disjointClass,
            firstClassExpression,
            secondClassExpression,
            moreClassExpressions
        )

    static member DisjointUnion
        ((disjointClass: Class), (firstClassExpression: ClassExpression), (secondClassExpression: ClassExpression))
        =
        Functional.DisjointUnion(Set.empty, disjointClass, firstClassExpression, secondClassExpression)

    static member DisjointUnion(disjointClass: Class) =
        fun (firstClassExpression: ClassExpression) ->
            fun (secondClassExpression: ClassExpression) ->
                Functional.DisjointUnion(disjointClass, firstClassExpression, secondClassExpression)

    static member ObjectPropertyChain
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: ObjectPropertyExpression list)
        ) =
        { objectPropertyChain =
            List.TwoOrMore.More(
                firstObjectPropertyExpression,
                secondObjectPropertyExpression,
                moreobjectPropertyExpressions
            ) }

    static member ObjectPropertyChain
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        { objectPropertyChain = List.TwoOrMore.Two(firstObjectPropertyExpression, secondObjectPropertyExpression) }

    static member ObjectPropertyChain(chain: List.TwoOrMore<ObjectPropertyExpression>) = { objectPropertyChain = chain }

    static member ObjectPropertyChain(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.ObjectPropertyChain(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member SubObjectPropertyExpression(objectPropertyExpression: ObjectPropertyExpression) =
        SubObjectPropertyExpression objectPropertyExpression

    static member SubObjectPropertyOf
        (
            (axiomAnnotations: Set<Annotation>),
            (subObjectPropertyExpression: SubObjectPropertyExpression),
            (superObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { subObjectPropertyExpression = subObjectPropertyExpression
              superObjectPropertyExpression = superObjectPropertyExpression }
        )

    static member SubObjectPropertyOf
        (
            (axiomAnnotations: Set<Annotation>),
            (subObjectPropertyExpression: ObjectPropertyExpression),
            (superObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.SubObjectPropertyOf(
            axiomAnnotations,
            Functional.SubObjectPropertyExpression(subObjectPropertyExpression),
            superObjectPropertyExpression
        )

    static member SubObjectPropertyOf(axiomAnnotations: Set<Annotation>) =
        fun (subObjectPropertyExpression: SubObjectPropertyExpression) ->
            fun (superObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.SubObjectPropertyOf(
                    axiomAnnotations,
                    subObjectPropertyExpression,
                    superObjectPropertyExpression
                )

    static member SubObjectPropertyOf
        (
            (subObjectPropertyExpression: SubObjectPropertyExpression),
            (superObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.SubObjectPropertyOf(Set.empty, subObjectPropertyExpression, superObjectPropertyExpression)

    static member SubObjectPropertyOf
        (
            (subObjectPropertyExpression: ObjectPropertyExpression),
            (superObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.SubObjectPropertyOf(Set.empty, subObjectPropertyExpression, superObjectPropertyExpression)

    static member SubObjectPropertyOf(subObjectPropertyExpression: SubObjectPropertyExpression) =
        fun (superObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.SubObjectPropertyOf(subObjectPropertyExpression, superObjectPropertyExpression)

    static member SubObjectPropertyOf(subObjectPropertyExpression: ObjectPropertyExpression) =
        fun (superObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.SubObjectPropertyOf(subObjectPropertyExpression, superObjectPropertyExpression)

    static member EquivalentObjectProperties
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>))
        =
        Annotated.Annotate(axiomAnnotations, { equivalentObjectPropertyExpressions = objectPropertyExpressions })

    static member EquivalentObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.EquivalentObjectProperties(
            axiomAnnotations,
            Set.TwoOrMore.More(
                firstObjectPropertyExpression,
                secondObjectPropertyExpression,
                moreobjectPropertyExpressions
            )
        )

    static member EquivalentObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.EquivalentObjectProperties(
            axiomAnnotations,
            Set.TwoOrMore.Two(firstObjectPropertyExpression, secondObjectPropertyExpression)
        )

    static member EquivalentObjectProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstObjectPropertyExpression: ObjectPropertyExpression) ->
            fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.EquivalentObjectProperties(
                    axiomAnnotations,
                    firstObjectPropertyExpression,
                    secondObjectPropertyExpression
                )

    static member EquivalentObjectProperties(objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>) =
        Functional.EquivalentObjectProperties(Set.empty, objectPropertyExpressions)

    static member EquivalentObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.EquivalentObjectProperties(
            Set.empty,
            firstObjectPropertyExpression,
            secondObjectPropertyExpression,
            moreobjectPropertyExpressions
        )

    static member EquivalentObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.EquivalentObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member EquivalentObjectProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.EquivalentObjectProperties(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member DisjointObjectProperties
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>))
        =
        Annotated.Annotate(axiomAnnotations, { disjointObjectPropertyExpressions = objectPropertyExpressions })

    static member DisjointObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.DisjointObjectProperties(
            axiomAnnotations,
            Set.TwoOrMore.More(
                firstObjectPropertyExpression,
                secondObjectPropertyExpression,
                moreobjectPropertyExpressions
            )
        )

    static member DisjointObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.DisjointObjectProperties(
            axiomAnnotations,
            Set.TwoOrMore.Two(firstObjectPropertyExpression, secondObjectPropertyExpression)
        )

    static member DisjointObjectProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstObjectPropertyExpression: ObjectPropertyExpression) ->
            fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.DisjointObjectProperties(
                    axiomAnnotations,
                    firstObjectPropertyExpression,
                    secondObjectPropertyExpression
                )

    static member DisjointObjectProperties(objectPropertyExpressions: Set.TwoOrMore<ObjectPropertyExpression>) =
        Functional.DisjointObjectProperties(Set.empty, objectPropertyExpressions)

    static member DisjointObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Functional.DisjointObjectProperties(
            Set.empty,
            firstObjectPropertyExpression,
            secondObjectPropertyExpression,
            moreobjectPropertyExpressions
        )

    static member DisjointObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.DisjointObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member DisjointObjectProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.DisjointObjectProperties(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member InverseObjectProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { inverseObjectProperties = firstObjectPropertyExpression, secondObjectPropertyExpression }
        )

    static member InverseObjectProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstObjectPropertyExpression: ObjectPropertyExpression) ->
            fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
                Functional.InverseObjectProperties(
                    axiomAnnotations,
                    firstObjectPropertyExpression,
                    secondObjectPropertyExpression
                )

    static member InverseObjectProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (secondObjectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.InverseObjectProperties(Set.empty, firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member InverseObjectProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        fun (secondObjectPropertyExpression: ObjectPropertyExpression) ->
            Functional.InverseObjectProperties(firstObjectPropertyExpression, secondObjectPropertyExpression)

    static member ObjectPropertyDomain
        (
            (axiomAnnotations: Set<Annotation>),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { objectPropertyExpression = objectPropertyExpression
              objectPropertyDomain = classExpression }
        )

    static member ObjectPropertyDomain(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (classExpression: ClassExpression) ->
                Functional.ObjectPropertyDomain(axiomAnnotations, objectPropertyExpression, classExpression)

    static member ObjectPropertyDomain
        ((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression))
        =
        Functional.ObjectPropertyDomain(Set.empty, objectPropertyExpression, classExpression)

    static member ObjectPropertyDomain(objectPropertyExpression: ObjectPropertyExpression) =
        fun (classExpression: ClassExpression) ->
            Functional.ObjectPropertyDomain(objectPropertyExpression, classExpression)

    static member ObjectPropertyRange
        (
            (axiomAnnotations: Set<Annotation>),
            (objectPropertyExpression: ObjectPropertyExpression),
            (classExpression: ClassExpression)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { objectPropertyExpression = objectPropertyExpression
              objectPropertyRange = classExpression }
        )

    static member ObjectPropertyRange(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (classExpression: ClassExpression) ->
                Functional.ObjectPropertyRange(axiomAnnotations, objectPropertyExpression, classExpression)

    static member ObjectPropertyRange
        ((objectPropertyExpression: ObjectPropertyExpression), (classExpression: ClassExpression))
        =
        Functional.ObjectPropertyRange(Set.empty, objectPropertyExpression, classExpression)

    static member ObjectPropertyRange(objectPropertyExpression: ObjectPropertyExpression) =
        fun (classExpression: ClassExpression) ->
            Functional.ObjectPropertyRange(objectPropertyExpression, classExpression)

    static member FunctionalObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { functionalObjectProperty = objectPropertyExpression })

    static member FunctionalObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.FunctionalObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member FunctionalObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.FunctionalObjectProperty(Set.empty, objectPropertyExpression)

    static member InverseFunctionalObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { inverseFunctionalObjectProperty = objectPropertyExpression })

    static member InverseFunctionalObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.InverseFunctionalObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member InverseFunctionalObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.InverseFunctionalObjectProperty(Set.empty, objectPropertyExpression)

    static member ReflexiveObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { reflexiveObjectProperty = objectPropertyExpression })

    static member ReflexiveObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.ReflexiveObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member ReflexiveObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.ReflexiveObjectProperty(Set.empty, objectPropertyExpression)

    static member IrreflexiveObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { irreflexiveObjectProperty = objectPropertyExpression })

    static member IrreflexiveObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.IrreflexiveObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member IrreflexiveObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.IrreflexiveObjectProperty(Set.empty, objectPropertyExpression)

    static member SymmetricObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { symmetricObjectProperty = objectPropertyExpression })

    static member SymmetricObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.SymmetricObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member SymmetricObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.SymmetricObjectProperty(Set.empty, objectPropertyExpression)

    static member AsymmetricObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { asymmetricObjectProperty = objectPropertyExpression })

    static member AsymmetricObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.AsymmetricObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member AsymmetricObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.AsymmetricObjectProperty(Set.empty, objectPropertyExpression)

    static member TransitiveObjectProperty
        ((axiomAnnotations: Set<Annotation>), (objectPropertyExpression: ObjectPropertyExpression))
        =
        Annotated.Annotate(axiomAnnotations, { transitiveObjectProperty = objectPropertyExpression })

    static member TransitiveObjectProperty(axiomAnnotations: Set<Annotation>) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            Functional.TransitiveObjectProperty(axiomAnnotations, objectPropertyExpression)

    static member TransitiveObjectProperty(objectPropertyExpression: ObjectPropertyExpression) =
        Functional.TransitiveObjectProperty(Set.empty, objectPropertyExpression)

    static member SubDataPropertyOf
        ((axiomAnnotations: Set<Annotation>), (subDataProperty: DataProperty), (superDataProperty: DataProperty))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { subDataProperty = subDataProperty
              superDataProperty = superDataProperty }
        )

    static member SubDataPropertyOf(axiomAnnotations: Set<Annotation>) =
        fun (subDataProperty: DataProperty) ->
            fun (superDataProperty: DataProperty) ->
                Functional.SubDataPropertyOf(axiomAnnotations, subDataProperty, superDataProperty)

    static member SubDataPropertyOf((subDataProperty: DataProperty), (superDataProperty: DataProperty)) =
        Functional.SubDataPropertyOf(Set.empty, subDataProperty, superDataProperty)

    static member SubDataPropertyOf(subDataProperty: DataProperty) =
        fun (superDataProperty: DataProperty) -> Functional.SubDataPropertyOf(subDataProperty, superDataProperty)

    static member EquivalentDataProperties
        ((axiomAnnotations: Set<Annotation>), (dataProperties: Set.TwoOrMore<DataProperty>))
        =
        Annotated.Annotate(axiomAnnotations, { equivalentDataProperties = dataProperties })

    static member EquivalentDataProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstDataProperty: DataProperty),
            (secondDataProperty: DataProperty),
            (moreDataProperties: Set<DataProperty>)
        ) =
        Functional.EquivalentDataProperties(
            axiomAnnotations,
            Set.TwoOrMore.More(firstDataProperty, secondDataProperty, moreDataProperties)
        )

    static member EquivalentDataProperties
        ((axiomAnnotations: Set<Annotation>), (firstDataProperty: DataProperty), (secondDataProperty: DataProperty))
        =
        Functional.EquivalentDataProperties(axiomAnnotations, Set.TwoOrMore.Two(firstDataProperty, secondDataProperty))

    static member EquivalentDataProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstDataProperty: DataProperty) ->
            fun (secondDataProperty: DataProperty) ->
                Functional.EquivalentDataProperties(axiomAnnotations, firstDataProperty, secondDataProperty)

    static member EquivalentDataProperties(dataProperties: Set.TwoOrMore<DataProperty>) =
        Functional.EquivalentDataProperties(Set.empty, dataProperties)

    static member EquivalentDataProperties
        ((firstDataProperty: DataProperty), (secondDataProperty: DataProperty), (moreDataProperties: Set<DataProperty>))
        =
        Functional.EquivalentDataProperties(Set.empty, firstDataProperty, secondDataProperty, moreDataProperties)

    static member EquivalentDataProperties((firstDataProperty: DataProperty), (secondDataProperty: DataProperty)) =
        Functional.EquivalentDataProperties(Set.empty, firstDataProperty, secondDataProperty)

    static member EquivalentDataProperties(firstDataProperty: DataProperty) =
        fun (secondDataProperty: DataProperty) ->
            Functional.EquivalentDataProperties(firstDataProperty, secondDataProperty)

    static member DisjointDataProperties
        ((axiomAnnotations: Set<Annotation>), (dataProperties: Set.TwoOrMore<DataProperty>))
        =
        Annotated.Annotate(axiomAnnotations, { disjointDataProperties = dataProperties })

    static member DisjointDataProperties
        (
            (axiomAnnotations: Set<Annotation>),
            (firstDataProperty: DataProperty),
            (secondDataProperty: DataProperty),
            (moreDataProperties: Set<DataProperty>)
        ) =
        Functional.DisjointDataProperties(
            axiomAnnotations,
            Set.TwoOrMore.More(firstDataProperty, secondDataProperty, moreDataProperties)
        )

    static member DisjointDataProperties
        ((axiomAnnotations: Set<Annotation>), (firstDataProperty: DataProperty), (secondDataProperty: DataProperty))
        =
        Functional.DisjointDataProperties(axiomAnnotations, Set.TwoOrMore.Two(firstDataProperty, secondDataProperty))

    static member DisjointDataProperties(axiomAnnotations: Set<Annotation>) =
        fun (firstDataProperty: DataProperty) ->
            fun (secondDataProperty: DataProperty) ->
                Functional.DisjointDataProperties(axiomAnnotations, firstDataProperty, secondDataProperty)

    static member DisjointDataProperties(dataProperties: Set.TwoOrMore<DataProperty>) =
        Functional.DisjointDataProperties(Set.empty, dataProperties)

    static member DisjointDataProperties
        ((firstDataProperty: DataProperty), (secondDataProperty: DataProperty), (moreDataProperties: Set<DataProperty>))
        =
        Functional.DisjointDataProperties(Set.empty, firstDataProperty, secondDataProperty, moreDataProperties)

    static member DisjointDataProperties((firstDataProperty: DataProperty), (secondDataProperty: DataProperty)) =
        Functional.DisjointDataProperties(Set.empty, firstDataProperty, secondDataProperty)

    static member DisjointDataProperties(firstDataProperty: DataProperty) =
        fun (secondDataProperty: DataProperty) ->
            Functional.DisjointDataProperties(firstDataProperty, secondDataProperty)

    static member DataPropertyDomain
        ((axiomAnnotations: Set<Annotation>), (dataProperty: DataProperty), (classExpression: ClassExpression))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { dataProperty = dataProperty
              dataPropertyDomain = classExpression }
        )

    static member DataPropertyDomain(axiomAnnotations: Set<Annotation>) =
        curryN
            (Functional.DataPropertyDomain
            : Set<Annotation> * DataProperty * ClassExpression -> Annotated<DataPropertyDomain>)
            axiomAnnotations

    static member DataPropertyDomain((dataProperty: DataProperty), (classExpression: ClassExpression)) =
        Functional.DataPropertyDomain(Set.empty, dataProperty, classExpression)

    static member DataPropertyDomain(dataProperty: DataProperty) =
        curry
            (Functional.DataPropertyDomain: DataProperty * ClassExpression -> Annotated<DataPropertyDomain>)
            dataProperty

    static member DataPropertyRange
        ((axiomAnnotations: Set<Annotation>), (dataProperty: DataProperty), (dataRange: DataRange))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { dataProperty = dataProperty
              dataPropertyRange = dataRange }
        )

    static member DataPropertyRange(axiomAnnotations: Set<Annotation>) =
        fun (dataProperty: DataProperty) ->
            fun (dataRange: DataRange) -> Functional.DataPropertyRange(axiomAnnotations, dataProperty, dataRange)

    static member DataPropertyRange((dataProperty: DataProperty), (dataRange: DataRange)) =
        Functional.DataPropertyRange(Set.empty, dataProperty, dataRange)

    static member DataPropertyRange(dataProperty: DataProperty) =
        fun (dataRange: DataRange) -> Functional.DataPropertyRange(dataProperty, dataRange)

    static member FunctionalDataProperty((axiomAnnotations: Set<Annotation>), (dataProperty: DataProperty)) =
        Annotated.Annotate(axiomAnnotations, { functionalDataProperty = dataProperty })

    static member FunctionalDataProperty(axiomAnnotations: Set<Annotation>) =
        fun (dataProperty: DataProperty) -> Functional.FunctionalDataProperty(axiomAnnotations, dataProperty)

    static member FunctionalDataProperty(dataProperty: DataProperty) =
        Functional.FunctionalDataProperty(Set.empty, dataProperty)

    static member DatatypeDefinition
        ((axiomAnnotations: Set<Annotation>), (datatype: DatatypeIri), (dataRange: DataRange))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { datatype = datatype
              dataRange = dataRange }
        )

    static member DatatypeDefinition(axiomAnnotations: Set<Annotation>) =
        fun (datatype: DatatypeIri) ->
            fun (dataRange: DataRange) -> Functional.DatatypeDefinition(axiomAnnotations, datatype, dataRange)

    static member DatatypeDefinition((datatype: DatatypeIri), (dataRange: DataRange)) =
        Functional.DatatypeDefinition(Set.empty, datatype, dataRange)

    static member DatatypeDefinition(datatype: DatatypeIri) =
        fun (dataRange: DataRange) -> Functional.DatatypeDefinition(datatype, dataRange)

    static member ObjectKeyProperties(objectProperties: Set.OneOrMore<ObjectPropertyExpression>) =
        objectProperties |> ObjectKeyProperties

    static member ObjectKeyProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>)
        ) =
        Set.OneOrMore.More(firstObjectPropertyExpression, moreobjectPropertyExpressions)
        |> ObjectKeyProperties

    static member ObjectKeyProperties(firstObjectPropertyExpression: ObjectPropertyExpression) =
        firstObjectPropertyExpression |> Set.OneOrMore.One |> ObjectKeyProperties

    static member DataKeyProperties(dataProperties: Set.OneOrMore<DataProperty>) = dataProperties |> DataKeyProperties

    static member DataKeyProperties((firstDataProperty: DataProperty), (moreDataPropertys: Set<DataProperty>)) =
        Set.OneOrMore.More(firstDataProperty, moreDataPropertys) |> DataKeyProperties

    static member DataKeyProperties(firstDataProperty: DataProperty) =
        firstDataProperty |> Set.OneOrMore.One |> DataKeyProperties

    static member ObjectDataKeyProperties
        ((objectProperties: Set.OneOrMore<ObjectPropertyExpression>), (dataProperties: Set.OneOrMore<DataProperty>))
        =
        (objectProperties, dataProperties) |> ObjectDataKeyProperties

    static member ObjectDataKeyProperties
        (
            (firstObjectPropertyExpression: ObjectPropertyExpression),
            (moreobjectPropertyExpressions: Set<ObjectPropertyExpression>),
            (firstDataProperty: DataProperty),
            (moreDataPropertys: Set<DataProperty>)
        ) =
        (Set.OneOrMore.More(firstObjectPropertyExpression, moreobjectPropertyExpressions),
         Set.OneOrMore.More(firstDataProperty, moreDataPropertys))
        |> ObjectDataKeyProperties

    static member ObjectDataKeyProperties
        ((firstObjectPropertyExpression: ObjectPropertyExpression), (firstDataProperty: DataProperty))
        =
        (Set.OneOrMore.One firstObjectPropertyExpression, Set.OneOrMore.One firstDataProperty)
        |> ObjectDataKeyProperties

    static member HasKey
        ((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (keyProperties: KeyProperties))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { classExpression = classExpression
              keyProperties = keyProperties }
        )

    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (objectProperties: Set.OneOrMore<ObjectPropertyExpression>),
            (dataProperties: Set.OneOrMore<DataProperty>)
        ) =
        Functional.HasKey(
            axiomAnnotations,
            classExpression,
            Functional.ObjectDataKeyProperties(objectProperties, dataProperties)
        )

    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (objectProperties: Set.OneOrMore<ObjectPropertyExpression>)
        ) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.ObjectKeyProperties(objectProperties))

    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (dataProperties: Set.OneOrMore<DataProperty>)
        ) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.DataKeyProperties(dataProperties))

    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (objectPropertyExpression: ObjectPropertyExpression),
            (dataProperty: DataProperty)
        ) =
        Functional.HasKey(
            axiomAnnotations,
            classExpression,
            Functional.ObjectDataKeyProperties(objectPropertyExpression, dataProperty)
        )

    static member HasKey
        (
            (axiomAnnotations: Set<Annotation>),
            (classExpression: ClassExpression),
            (objectPropertyExpression: ObjectPropertyExpression)
        ) =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.ObjectKeyProperties(objectPropertyExpression))

    static member HasKey
        ((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (dataProperty: DataProperty))
        =
        Functional.HasKey(axiomAnnotations, classExpression, Functional.DataKeyProperties(dataProperty))

    static member HasKey(axiomAnnotations: Set<Annotation>) =
        fun (classExpression: ClassExpression) ->
            fun (keyProperties: KeyProperties) -> Functional.HasKey(axiomAnnotations, classExpression, keyProperties)

    static member HasKey((classExpression: ClassExpression), (keyProperties: KeyProperties)) =
        Functional.HasKey(Set.empty, classExpression, keyProperties)

    static member HasKey
        (
            (classExpression: ClassExpression),
            (objectProperties: Set.OneOrMore<ObjectPropertyExpression>),
            (dataProperties: Set.OneOrMore<DataProperty>)
        ) =
        Functional.HasKey(Set.empty, classExpression, objectProperties, dataProperties)

    static member HasKey
        ((classExpression: ClassExpression), (objectProperties: Set.OneOrMore<ObjectPropertyExpression>))
        =
        Functional.HasKey(Set.empty, classExpression, objectProperties)

    static member HasKey((classExpression: ClassExpression), (dataProperties: Set.OneOrMore<DataProperty>)) =
        Functional.HasKey(Set.empty, classExpression, dataProperties)

    static member HasKey
        (
            (classExpression: ClassExpression),
            (objectPropertyExpression: ObjectPropertyExpression),
            (dataProperty: DataProperty)
        ) =
        Functional.HasKey(Set.empty, classExpression, objectPropertyExpression, dataProperty)

    static member HasKey((classExpression: ClassExpression), (objectPropertyExpression: ObjectPropertyExpression)) =
        Functional.HasKey(Set.empty, classExpression, objectPropertyExpression)

    static member HasKey((classExpression: ClassExpression), (dataProperty: DataProperty)) =
        Functional.HasKey(Set.empty, classExpression, dataProperty)

    static member HasKey(classExpression: ClassExpression) =
        fun (keyProperties: KeyProperties) -> Functional.HasKey(classExpression, keyProperties)

    static member SameIndividual((axiomAnnotations: Set<Annotation>), (individuals: Set.TwoOrMore<Individual>)) =
        Annotated.Annotate(axiomAnnotations, { SameIndividual = individuals })

    static member SameIndividual
        (
            (axiomAnnotations: Set<Annotation>),
            (firstIndividual: Individual),
            (secondIndividual: Individual),
            (moreIndividuals: Set<Individual>)
        ) =
        Functional.SameIndividual(
            axiomAnnotations,
            Set.TwoOrMore.More(firstIndividual, secondIndividual, moreIndividuals)
        )

    static member SameIndividual
        ((axiomAnnotations: Set<Annotation>), (firstIndividual: Individual), (secondIndividual: Individual))
        =
        Functional.SameIndividual(axiomAnnotations, Set.TwoOrMore.Two(firstIndividual, secondIndividual))

    static member SameIndividual(axiomAnnotations: Set<Annotation>) =
        fun (firstIndividual: Individual) ->
            fun (secondIndividual: Individual) ->
                Functional.SameIndividual(axiomAnnotations, firstIndividual, secondIndividual)

    static member SameIndividual(individuals: Set.TwoOrMore<Individual>) =
        Functional.SameIndividual(Set.empty, individuals)

    static member SameIndividual
        ((firstIndividual: Individual), (secondIndividual: Individual), (moreIndividuals: Set<Individual>))
        =
        Functional.SameIndividual(Set.empty, firstIndividual, secondIndividual, moreIndividuals)

    static member SameIndividual((firstIndividual: Individual), (secondIndividual: Individual)) =
        Functional.SameIndividual(Set.empty, firstIndividual, secondIndividual)

    static member SameIndividual(firstIndividual: Individual) =
        fun (secondIndividual: Individual) -> Functional.SameIndividual(firstIndividual, secondIndividual)

    static member DifferentIndividuals((axiomAnnotations: Set<Annotation>), (individuals: Set.TwoOrMore<Individual>)) =
        Annotated.Annotate(axiomAnnotations, { DifferentIndividuals = individuals })

    static member DifferentIndividuals
        (
            (axiomAnnotations: Set<Annotation>),
            (firstIndividual: Individual),
            (secondIndividual: Individual),
            (moreIndividuals: Set<Individual>)
        ) =
        Functional.DifferentIndividuals(
            axiomAnnotations,
            Set.TwoOrMore.More(firstIndividual, secondIndividual, moreIndividuals)
        )

    static member DifferentIndividuals
        ((axiomAnnotations: Set<Annotation>), (firstIndividual: Individual), (secondIndividual: Individual))
        =
        Functional.DifferentIndividuals(axiomAnnotations, Set.TwoOrMore.Two(firstIndividual, secondIndividual))

    static member DifferentIndividuals(axiomAnnotations: Set<Annotation>) =
        fun (firstIndividual: Individual) ->
            fun (secondIndividual: Individual) ->
                Functional.DifferentIndividuals(axiomAnnotations, firstIndividual, secondIndividual)

    static member DifferentIndividuals(individuals: Set.TwoOrMore<Individual>) =
        Functional.DifferentIndividuals(Set.empty, individuals)

    static member DifferentIndividuals
        ((firstIndividual: Individual), (secondIndividual: Individual), (moreIndividuals: Set<Individual>))
        =
        Functional.DifferentIndividuals(Set.empty, firstIndividual, secondIndividual, moreIndividuals)

    static member DifferentIndividuals((firstIndividual: Individual), (secondIndividual: Individual)) =
        Functional.DifferentIndividuals(Set.empty, firstIndividual, secondIndividual)

    static member DifferentIndividuals(firstIndividual: Individual) =
        fun (secondIndividual: Individual) -> Functional.DifferentIndividuals(firstIndividual, secondIndividual)

    // Assertion tupled overloads retain Functional-Syntax order; curried overloads use triple order.
    static member ClassAssertion
        ((axiomAnnotations: Set<Annotation>), (classExpression: ClassExpression), (individual: Individual))
        =
        Annotated.Annotate(
            axiomAnnotations,
            { individual = individual
              classExpression = classExpression }
        )

    static member ClassAssertion(axiomAnnotations: Set<Annotation>) =
        flip (
            curryN
                (Functional.ClassAssertion: Set<Annotation> * ClassExpression * Individual -> Annotated<ClassAssertion>)
                axiomAnnotations
        )

    static member ClassAssertion((classExpression: ClassExpression), (individual: Individual)) =
        Functional.ClassAssertion(Set.empty, classExpression, individual)

    static member ClassAssertion(individual: Individual) =
        flip (curry (Functional.ClassAssertion: ClassExpression * Individual -> Annotated<ClassAssertion>)) individual

    static member ClassAssertion(individuals: Individual list) =
        fun (classExpression: ClassExpression) ->
            individuals
            |> List.map (fun individual -> Functional.ClassAssertion(classExpression, individual))

    static member ObjectPropertyAssertion
        (
            (axiomAnnotations: Set<Annotation>),
            (objectPropertyExpression: ObjectPropertyExpression),
            (sourceIndividual: Individual),
            (targetIndividual: Individual)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { sourceIndividual = sourceIndividual
              objectPropertyExpression = objectPropertyExpression
              targetIndividual = targetIndividual }
        )

    static member ObjectPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                fun (targetIndividual: Individual) ->
                    Functional.ObjectPropertyAssertion(
                        axiomAnnotations,
                        objectPropertyExpression,
                        sourceIndividual,
                        targetIndividual
                    )

    static member ObjectPropertyAssertion
        (
            (objectPropertyExpression: ObjectPropertyExpression),
            (sourceIndividual: Individual),
            (targetIndividual: Individual)
        ) =
        Functional.ObjectPropertyAssertion(Set.empty, objectPropertyExpression, sourceIndividual, targetIndividual)

    static member ObjectPropertyAssertion(sourceIndividual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (targetIndividual: Individual) ->
                Functional.ObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)

    static member NegativeObjectPropertyAssertion
        (
            (axiomAnnotations: Set<Annotation>),
            (objectPropertyExpression: ObjectPropertyExpression),
            (sourceIndividual: Individual),
            (targetIndividual: Individual)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { sourceIndividual = sourceIndividual
              negativeObjectPropertyExpression = objectPropertyExpression
              targetIndividual = targetIndividual }
        )

    static member NegativeObjectPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (objectPropertyExpression: ObjectPropertyExpression) ->
                fun (targetIndividual: Individual) ->
                    Functional.NegativeObjectPropertyAssertion(
                        axiomAnnotations,
                        objectPropertyExpression,
                        sourceIndividual,
                        targetIndividual
                    )

    static member NegativeObjectPropertyAssertion
        (
            (objectPropertyExpression: ObjectPropertyExpression),
            (sourceIndividual: Individual),
            (targetIndividual: Individual)
        ) =
        Functional.NegativeObjectPropertyAssertion(
            Set.empty,
            objectPropertyExpression,
            sourceIndividual,
            targetIndividual
        )

    static member NegativeObjectPropertyAssertion(sourceIndividual: Individual) =
        fun (objectPropertyExpression: ObjectPropertyExpression) ->
            fun (targetIndividual: Individual) ->
                Functional.NegativeObjectPropertyAssertion(objectPropertyExpression, sourceIndividual, targetIndividual)

    static member DataPropertyAssertion
        (
            (axiomAnnotations: Set<Annotation>),
            (dataProperty: DataProperty),
            (sourceIndividual: Individual),
            (targetValue: Literal)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { sourceIndividual = sourceIndividual
              dataProperty = dataProperty
              targetValue = targetValue }
        )

    static member DataPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (dataProperty: DataProperty) ->
                fun (targetValue: Literal) ->
                    Functional.DataPropertyAssertion(axiomAnnotations, dataProperty, sourceIndividual, targetValue)

    static member DataPropertyAssertion
        ((dataProperty: DataProperty), (sourceIndividual: Individual), (targetValue: Literal))
        =
        Functional.DataPropertyAssertion(Set.empty, dataProperty, sourceIndividual, targetValue)

    static member DataPropertyAssertion(sourceIndividual: Individual) =
        fun (dataProperty: DataProperty) ->
            fun (targetValue: Literal) -> Functional.DataPropertyAssertion(dataProperty, sourceIndividual, targetValue)

    static member NegativeDataPropertyAssertion
        (
            (axiomAnnotations: Set<Annotation>),
            (dataProperty: DataProperty),
            (sourceIndividual: Individual),
            (targetValue: Literal)
        ) =
        Annotated.Annotate(
            axiomAnnotations,
            { sourceIndividual = sourceIndividual
              negativeDataProperty = dataProperty
              targetValue = targetValue }
        )

    static member NegativeDataPropertyAssertion(axiomAnnotations: Set<Annotation>) =
        fun (sourceIndividual: Individual) ->
            fun (dataProperty: DataProperty) ->
                fun (targetValue: Literal) ->
                    Functional.NegativeDataPropertyAssertion(
                        axiomAnnotations,
                        dataProperty,
                        sourceIndividual,
                        targetValue
                    )

    static member NegativeDataPropertyAssertion
        ((dataProperty: DataProperty), (sourceIndividual: Individual), (targetValue: Literal))
        =
        Functional.NegativeDataPropertyAssertion(Set.empty, dataProperty, sourceIndividual, targetValue)

    static member NegativeDataPropertyAssertion(sourceIndividual: Individual) =
        fun (dataProperty: DataProperty) ->
            fun (targetValue: Literal) ->
                Functional.NegativeDataPropertyAssertion(dataProperty, sourceIndividual, targetValue)

and Polarity =
    | Positive
    | Negative

    static member (!!)(polarity: Polarity) =
        match polarity with
        | Positive -> Negative
        | Negative -> Positive

    static member not(polarity: Polarity) = !!polarity
    member this._not = !!this

and DataDescription =
    | DataConjunctionOrDataConjunction of List.TwoOrMore<DataConjunction>
    | DataConjunction of DataConjunction

    member this._or(other: DataConjunction) = this .|| other

    member this.dataRange =
        match this with
        | DataConjunctionOrDataConjunction dataConjunctions ->
            Set.TwoOrMore.More
                dataConjunctions.items[0].dataRange
                dataConjunctions.items[1].dataRange
                (dataConjunctions.items[2..]
                 |> List.map (fun item -> item.dataRange)
                 |> Set.ofList)
            |> DataUnion
        | DataConjunction dataConjunction -> dataConjunction.dataRange

and DataConjunction =
    | DataPrimaryAndDataPrimary of List.TwoOrMore<DataPrimary>
    | DataPrimary of DataPrimary

    static member (.||)((one: DataConjunction), (two: DataConjunction)) =
        List.TwoOrMore.Two one two |> DataConjunctionOrDataConjunction

    static member (.||)((dataDescription: DataDescription), (dataConjunction: DataConjunction)) : DataDescription =
        match dataDescription with
        | DataConjunctionOrDataConjunction twoOrMoreDataConjunctions ->
            match twoOrMoreDataConjunctions.items with
            | first :: second :: rest ->
                List.TwoOrMore.More(first, second, rest @ [ dataConjunction ])
                |> DataConjunctionOrDataConjunction
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | DataConjunction oneDataConjunction ->
            List.TwoOrMore.Two oneDataConjunction dataConjunction
            |> DataConjunctionOrDataConjunction

    static member (.||)((dataConjunction: DataConjunction), (dataDescription: DataDescription)) =
        dataDescription .|| dataConjunction

    static member (.&&)((dataConjunction: DataConjunction), (dataPrimary: DataPrimary)) =
        match dataConjunction with
        | DataPrimaryAndDataPrimary dataPrimaries ->
            match dataPrimaries.items with
            | first :: second :: rest ->
                List.TwoOrMore.More(first, second, rest @ [ dataPrimary ])
                |> DataPrimaryAndDataPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | DataPrimary first -> List.TwoOrMore.Two first dataPrimary |> DataPrimaryAndDataPrimary

    static member or_((one: DataConjunction), (two: DataConjunction)) = one .|| two
    static member or_((one: DataDescription), (two: DataConjunction)) = one .|| two
    static member or_((one: DataConjunction), (two: DataDescription)) = one .|| two
    static member and_((one: DataConjunction), (two: DataPrimary)) = one .&& two
    member this._or(other: DataConjunction) = this .|| other
    member this._or(other: DataDescription) = this .|| other
    member this._and(other: DataPrimary) = this .&& other

    member this.dataRange =
        match this with
        | DataPrimaryAndDataPrimary dataPrimaries ->
            Set.TwoOrMore.More
                dataPrimaries.items[0].dataRange
                dataPrimaries.items[1].dataRange
                (dataPrimaries.items[2..] |> List.map (fun item -> item.dataRange) |> Set.ofList)
            |> DataIntersection
        | DataPrimary dataPrimary -> dataPrimary.dataRange

and DataPrimary =
    { polarity: Polarity
      dataAtomic: DataAtomic }

    static member (!!)(primary: DataPrimary) =
        { primary with
            polarity = !!primary.polarity }

    static member (.&&)((one: DataPrimary), (two: DataPrimary)) =
        List.TwoOrMore.Two one two |> DataPrimaryAndDataPrimary

    static member (.&&)((one: DataPrimary), (dataConjunction: DataConjunction)) =
        match dataConjunction with
        | DataPrimaryAndDataPrimary dataPrimaries ->
            match dataPrimaries.items with
            | first :: second :: rest -> List.TwoOrMore.More(one, first, second :: rest) |> DataPrimaryAndDataPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | DataPrimary two -> List.TwoOrMore.Two one two |> DataPrimaryAndDataPrimary

    static member and_((one: DataPrimary), (two: DataPrimary)) = one .&& two
    member this._and(dataPrimary: DataPrimary) = this .&& dataPrimary

    member this.dataRange: DataRange =
        match this.polarity with
        | Positive -> this.dataAtomic.dataRange
        | Negative -> DataComplement this.dataAtomic.dataRange

    static member not(dataPrimary: DataPrimary) = !!dataPrimary
    member this._not = !!this

and DataAtomic =
    | AtomicDatatype of DatatypeIri
    | AtomicLiterals of Set.OneOrMore<Literal>
    | AtomicDatatypeRestriction of DatatypeRestriction
    | AtomicDataDescription of DataDescription

    member this.dataRange: DataRange =
        match this with
        | AtomicDatatype datatype -> DatatypeRange datatype
        | AtomicLiterals literals -> DataOne literals
        | AtomicDatatypeRestriction datatypeRestriction -> DatatypeRestriction datatypeRestriction
        | AtomicDataDescription dataDescription -> dataDescription.dataRange

and Description =
    | ConjunctionOrConjunction of List.TwoOrMore<Conjunction>
    | Conjunction of Conjunction

    member this.asClassExpression =
        match this with
        | ConjunctionOrConjunction conjunctions ->
            Set.TwoOrMore.More
                conjunctions.items[0].asClassExpression
                conjunctions.items[1].asClassExpression
                (conjunctions.items[2..]
                 |> List.map (fun item -> item.asClassExpression)
                 |> Set.ofList)
            |> ObjectUnion
        | Conjunction conjunction -> conjunction.asClassExpression

and Conjunction =
    | ClassThatRestriction of Class * List.OneOrMore<RestrictionPrimary>
    | PrimaryAndPrimary of List.TwoOrMore<Primary>
    | Primary of Primary

    static member (.||)((one: Conjunction), (two: Conjunction)) =
        List.TwoOrMore.Two one two |> ConjunctionOrConjunction

    static member (.||)((description: Description), (conjunction: Conjunction)) =
        match description with
        | ConjunctionOrConjunction twoOrMoreConjunctions ->
            match twoOrMoreConjunctions.items with
            | first :: second :: rest ->
                List.TwoOrMore.More(first, second, rest @ [ conjunction ])
                |> ConjunctionOrConjunction
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | Conjunction oneConjunction -> List.TwoOrMore.Two oneConjunction conjunction |> ConjunctionOrConjunction

    static member (.||)((conjunction: Conjunction), (description: Description)) = description .|| conjunction

    static member (.&&)((conjunction: Conjunction), (primary: Primary)) =
        match conjunction with
        | PrimaryAndPrimary primaries ->
            match primaries.items with
            | first :: second :: rest -> List.TwoOrMore.More(first, second, rest @ [ primary ]) |> PrimaryAndPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | Primary first -> List.TwoOrMore.Two first primary |> PrimaryAndPrimary
        | ClassThatRestriction _ ->
            invalidArg (nameof primary) "A class-that conjunction can only be extended by another restriction primary."

    static member (.&&)((conjunction: Conjunction), (restrictionPrimary: RestrictionPrimary)) =
        match conjunction with
        | ClassThatRestriction(classIRI, restrictions) ->
            ClassThatRestriction(classIRI, List.OneOrMore.More(restrictions.items, restrictionPrimary))
        | _ -> conjunction .&& Primary.RestrictionPrimary restrictionPrimary

    member this.asClassExpression =
        match this with
        | ClassThatRestriction(classIRI, restrictionPrimaries) ->
            match restrictionPrimaries.items with
            | [ restrictionPrimary ] ->
                Set.TwoOrMore.Two classIRI.Class restrictionPrimary.Expression
                |> ObjectIntersection
            | restrictionItems ->
                Set.TwoOrMore.More
                    classIRI.Class
                    restrictionItems[0].Expression
                    (restrictionItems[1..]
                     |> List.map (fun restrictionPrimary -> restrictionPrimary.Expression)
                     |> Set.ofList)
                |> ObjectIntersection
        | PrimaryAndPrimary primaries ->
            Set.TwoOrMore.More
                primaries.items[0].asClassExpression
                primaries.items[1].asClassExpression
                (primaries.items[2..]
                 |> List.map (fun item -> item.asClassExpression)
                 |> Set.ofList)
            |> ObjectIntersection
        | Primary primary -> primary.asClassExpression

    static member or_((one: Conjunction), (two: Conjunction)) = one .|| two
    static member and_((one: Conjunction), (two: Primary)) = one .&& two
    static member and_((one: Conjunction), (two: RestrictionPrimary)) = one .&& two
    member this._or(other: Conjunction) = this .|| other
    member this._and(other: Primary) = this .&& other
    member this._and(other: RestrictionPrimary) = this .&& other

    static member that((classIRI: Class), (restrictionPrimaries: List.OneOrMore<RestrictionPrimary>)) =
        ClassThatRestriction(classIRI, restrictionPrimaries)

    static member that((classIRI: Class), (restrictionPrimary: RestrictionPrimary)) =
        Conjunction.that (classIRI, List.OneOrMore.One restrictionPrimary)

    static member that((classIRI: Class), (polarity: Polarity), (restriction: Restriction)) =
        Conjunction.that (
            classIRI,
            { polarity = polarity
              restriction = restriction }
        )

    static member that((classIRI: Class), (restriction: Restriction)) =
        Conjunction.that (classIRI, Positive, restriction)

    static member that(restriction: Restriction) =
        fun (classIRI: Class) -> Conjunction.that (classIRI, restriction)

    static member that(polarity: Polarity) =
        fun (restriction: Restriction) -> fun (classIRI: Class) -> Conjunction.that (classIRI, polarity, restriction)

    static member that_not((classIRI: Class), (restriction: Restriction)) =
        Conjunction.that (classIRI, Negative, restriction)

    static member that_not(restriction: Restriction) =
        fun (classIRI: Class) -> Conjunction.that_not (classIRI, restriction)

and Primary =
    | RestrictionPrimary of RestrictionPrimary
    | AtomicPrimary of AtomicPrimary

    static member (.&&)((one: Primary), (two: Primary)) =
        List.TwoOrMore.Two one two |> PrimaryAndPrimary

    static member (.&&)((one: Primary), (conjunction: Conjunction)) =
        match conjunction with
        | PrimaryAndPrimary primaries ->
            match primaries.items with
            | first :: second :: rest -> List.TwoOrMore.More(one, first, second :: rest) |> PrimaryAndPrimary
            | _ -> invalidOp "Impossible List.TwoOrMore state."
        | Primary two -> List.TwoOrMore.Two one two |> PrimaryAndPrimary
        | ClassThatRestriction _ ->
            invalidArg
                (nameof conjunction)
                "A class-that conjunction cannot be appended to a primary conjunction without parentheses."

    member this.asClassExpression =
        match this with
        | RestrictionPrimary restrictionPrimary -> restrictionPrimary.Expression
        | AtomicPrimary atomicPrimary -> atomicPrimary.asClassExpression

    static member and_((one: Primary), (two: Primary)) = one .&& two
    member this._and(primary: Primary) = this .&& primary

and RestrictionPrimary =
    { polarity: Polarity
      restriction: Restriction }

    static member ofRestriction(restriction: Restriction) =
        { polarity = Positive
          restriction = restriction }

    static member op_Implicit(restriction: Restriction) =
        RestrictionPrimary.ofRestriction restriction

    member this.primary = Primary.RestrictionPrimary this

    static member (!!)(restrictionPrimary: RestrictionPrimary) =
        { restrictionPrimary with
            polarity = !!restrictionPrimary.polarity }

    static member (.&&)((one: RestrictionPrimary), (two: RestrictionPrimary)) = one.primary .&& two.primary

    member this.Expression =
        match this.polarity with
        | Positive -> RestrictionClassExpression this.restriction
        | Negative -> ObjectComplement(RestrictionClassExpression this.restriction)

    static member not(restrictionPrimary: RestrictionPrimary) = !!restrictionPrimary
    member this._not = !!this
    member this._and(other: RestrictionPrimary) = this .&& other
    static member and_((one: RestrictionPrimary), (two: RestrictionPrimary)) = one .&& two

and AtomicPrimary =
    { polarity: Polarity
      atomic: Atomic }

    static member ofAtomic(atomic: Atomic) =
        { polarity = Positive; atomic = atomic }

    member this.primary = Primary.AtomicPrimary this

    static member (!!)(atomicPrimary: AtomicPrimary) =
        { atomicPrimary with
            polarity = !!atomicPrimary.polarity }

    member this.asClassExpression =
        match this.polarity with
        | Positive -> this.atomic.Expression
        | Negative -> ObjectComplement this.atomic.Expression

    static member not(atomicPrimary: AtomicPrimary) = !!atomicPrimary
    member this._not = !!this

and Atomic =
    | AtomicClass of Class
    | AtomicIndividuals of Set.OneOrMore<Individual>
    | AtomicDescription of Description

    member this.Expression =
        match this with
        | AtomicClass classIRI -> ClassExpression classIRI
        | AtomicIndividuals individuals -> ObjectOne individuals
        | AtomicDescription description -> description.asClassExpression

and ObjectPropertyFact =
    { polarity: Polarity
      objectProperty: ObjectProperty
      individual: Individual }

    static member (!!)(objectPropertyFact: ObjectPropertyFact) : ObjectPropertyFact =
        { objectPropertyFact with
            polarity = !!objectPropertyFact.polarity }

    static member not(objectPropertyFact: ObjectPropertyFact) = !!objectPropertyFact
    member this._not = !!this

    member this.Assertion(sourceIndividual: Individual) : Assertion =
        match this.polarity with
        | Positive ->
            let assertion: ObjectPropertyAssertion =
                { sourceIndividual = sourceIndividual
                  objectPropertyExpression = Functional.AsObjectPropertyExpression this.objectProperty
                  targetIndividual = this.individual }

            Assertion.ObjectPropertyAssertion assertion
        | Negative ->
            let assertion: NegativeObjectPropertyAssertion =
                { sourceIndividual = sourceIndividual
                  negativeObjectPropertyExpression = Functional.AsObjectPropertyExpression this.objectProperty
                  targetIndividual = this.individual }

            Assertion.NegativeObjectPropertyAssertion assertion

    member this.Assertion(individuals: Individual list) : Assertion list =
        individuals
        |> List.map (fun sourceIndividual -> this.Assertion sourceIndividual)

and DataPropertyFact =
    { polarity: Polarity
      dataProperty: DataProperty
      literal: Literal }

    static member (!!)(dataPropertyFact: DataPropertyFact) : DataPropertyFact =
        { dataPropertyFact with
            polarity = !!dataPropertyFact.polarity }

    static member not(dataPropertyFact: DataPropertyFact) = !!dataPropertyFact
    member this._not = !!this

    member this.Assertion(sourceIndividual: Individual) : Assertion =
        match this.polarity with
        | Positive ->
            let assertion: DataPropertyAssertion =
                { sourceIndividual = sourceIndividual
                  dataProperty = this.dataProperty
                  targetValue = this.literal }

            Assertion.DataPropertyAssertion assertion
        | Negative ->
            let assertion: NegativeDataPropertyAssertion =
                { sourceIndividual = sourceIndividual
                  negativeDataProperty = this.dataProperty
                  targetValue = this.literal }

            Assertion.NegativeDataPropertyAssertion assertion

    member this.Assertion(individuals: Individual list) : Assertion list =
        individuals
        |> List.map (fun sourceIndividual -> this.Assertion sourceIndividual)

and Fact =
    | ObjectPropertyFact of ObjectPropertyFact
    | DataPropertyFact of DataPropertyFact

    static member (!!)(fact: Fact) =
        match fact with
        | ObjectPropertyFact objectPropertyFact -> ObjectPropertyFact !!objectPropertyFact
        | DataPropertyFact dataPropertyFact -> DataPropertyFact !!dataPropertyFact

    static member not(fact: Fact) = !!fact

    member this._not = !!this

    member this.Assertion(sourceIndividual: Individual) : Assertion =
        match this with
        | ObjectPropertyFact objectPropertyFact -> objectPropertyFact.Assertion sourceIndividual
        | DataPropertyFact dataPropertyFact -> dataPropertyFact.Assertion sourceIndividual

    member this.Assertion(individuals: Individual list) : Assertion list = individuals |> List.map this.Assertion

and PropertyExpression =
    | ObjectPropertyExpression of ObjectPropertyExpression
    | DataPropertyExpression of DataProperty

and [<RequireQualifiedAccess>] ObjectPropertyCharacteristic =
    | Functional
    | InverseFunctional
    | Reflexive
    | Irreflexive
    | Symmetric
    | Asymmetric
    | Transitive

and [<RequireQualifiedAccess>] DataPropertyCharacteristic = | Functional

and DisjointUnionDescriptions =
    { disjointUnionDescriptions: Set.TwoOrMore<Description> }

and KeyPropertyExpressions =
    { keyPropertyExpressions: List.OneOrMore<PropertyExpression> }

// The following n-ary types correspond to Manchester's top-level misc productions.
and EquivalentDescriptions =
    { equivalentDescriptions: Set.TwoOrMore<Description> }

and DisjointDescriptions =
    { disjointDescriptions: Set.TwoOrMore<Description> }

and EquivalentObjectProperties =
    { equivalentObjectProperties: Set.TwoOrMore<ObjectProperty> }

and DisjointObjectProperties =
    { disjointObjectProperties: Set.TwoOrMore<ObjectProperty> }

and EquivalentDataPropertyExpressions =
    { equivalentDataProperties: Set.TwoOrMore<DataProperty> }

and DisjointDataPropertyExpressions =
    { disjointDataProperties: Set.TwoOrMore<DataProperty> }

and SameIndividuals =
    { sameIndividuals: Set.TwoOrMore<Individual> }

and DifferentIndividualValues =
    { differentIndividuals: Set.TwoOrMore<Individual> }

and [<RequireQualifiedAccess>] Misc =
    | EquivalentClasses of Annotated<EquivalentDescriptions>
    | DisjointClasses of Annotated<DisjointDescriptions>
    | EquivalentObjectProperties of Annotated<EquivalentObjectProperties>
    | DisjointObjectProperties of Annotated<DisjointObjectProperties>
    | EquivalentDataProperties of Annotated<EquivalentDataPropertyExpressions>
    | DisjointDataProperties of Annotated<DisjointDataPropertyExpressions>
    | SameIndividual of Annotated<SameIndividuals>
    | DifferentIndividuals of Annotated<DifferentIndividualValues>

    member this.axioms: Set<Annotated<Axiom>> =
        match this with
        | Misc.EquivalentClasses entry ->
            entry.map (fun equivalentDescriptions ->
                let equivalent: EquivalentClasses =
                    { equivalentClasses =
                        equivalentDescriptions.equivalentDescriptions
                        |> Set.TwoOrMore<Description>.map (fun description -> description.asClassExpression) }

                ClassAxiom.EquivalentClassesAxiom equivalent)
            |> Manchester.classAxiom
            |> Set.singleton

        | Misc.DisjointClasses entry ->
            entry.map (fun disjointDescriptions ->
                let disjoint: DisjointClasses =
                    { disjointClasses =
                        disjointDescriptions.disjointDescriptions
                        |> Set.TwoOrMore<Description>.map (fun description -> description.asClassExpression) }

                ClassAxiom.DisjointClassesAxiom disjoint)
            |> Manchester.classAxiom
            |> Set.singleton

        | Misc.EquivalentObjectProperties entry ->
            entry.map (fun equivalentObjectProperties ->
                let equivalent: EquivalentObjectPropertyExpressions =
                    { equivalentObjectPropertyExpressions =
                        equivalentObjectProperties.equivalentObjectProperties
                        |> Set.TwoOrMore<ObjectProperty>.map Functional.AsObjectPropertyExpression }

                ObjectPropertyAxiom.EquivalentObjectProperties equivalent)
            |> Manchester.objectPropertyAxiom
            |> Set.singleton

        | Misc.DisjointObjectProperties entry ->
            entry.map (fun disjointObjectProperties ->
                let disjoint: DisjointObjectPropertyExpressions =
                    { disjointObjectPropertyExpressions =
                        disjointObjectProperties.disjointObjectProperties
                        |> Set.TwoOrMore<ObjectProperty>.map Functional.AsObjectPropertyExpression }

                ObjectPropertyAxiom.DisjointObjectProperties disjoint)
            |> Manchester.objectPropertyAxiom
            |> Set.singleton

        | Misc.EquivalentDataProperties entry ->
            entry.map (fun equivalentDataProperties ->
                let equivalent: EquivalentDataProperties =
                    { equivalentDataProperties = equivalentDataProperties.equivalentDataProperties }

                DataPropertyAxiom.EquivalentDataProperties equivalent)
            |> Manchester.dataPropertyAxiom
            |> Set.singleton

        | Misc.DisjointDataProperties entry ->
            entry.map (fun disjointDataProperties ->
                let disjoint: DisjointDataProperties =
                    { disjointDataProperties = disjointDataProperties.disjointDataProperties }

                DataPropertyAxiom.DisjointDataProperties disjoint)
            |> Manchester.dataPropertyAxiom
            |> Set.singleton

        | Misc.SameIndividual entry ->
            entry.map (fun sameIndividuals ->
                let same: SameIndividual = { SameIndividual = sameIndividuals.sameIndividuals }
                Assertion.SameIndividual same)
            |> Manchester.assertionAxiom
            |> Set.singleton

        | Misc.DifferentIndividuals entry ->
            entry.map (fun differentIndividuals ->
                let different: DifferentIndividuals =
                    { DifferentIndividuals = differentIndividuals.differentIndividuals }

                Assertion.DifferentIndividuals different)
            |> Manchester.assertionAxiom
            |> Set.singleton

and DatatypeFrame =
    { Datatype: DatatypeIri
      Annotations: Set<Annotation>
      EquivalentTo: Annotated<DataRange> option }

    member this.axioms: Set<Annotated<Axiom>> =
        let annotationSubject = IriSubject this.Datatype.Iri

        let annotations =
            Manchester.annotationAssertions (annotationSubject, this.Annotations)

        let declaration =
            Functional.Datatype this.Datatype |> Manchester.declaration |> Set.singleton

        let definition =
            this.EquivalentTo
            |> Option.map (fun equivalentTo ->
                equivalentTo
                    .map(fun dataRange ->
                        let definition: DatatypeDefinition =
                            { datatype = this.Datatype
                              dataRange = dataRange }

                        definition)
                    .map
                    Axiom.DatatypeDefinition)
            |> Option.toList
            |> Set.ofList

        Set.unionMany [ declaration; annotations; definition ]

and ClassFrame =
    { Class: Class
      Annotations: Set<Annotation>
      SubClassOf: Set<Annotated<Description>>
      EquivalentTo: Set<Annotated<Description>>
      DisjointWith: Set<Annotated<Description>>
      DisjointUnionOf: Set<Annotated<DisjointUnionDescriptions>>
      HasKey: Set<Annotated<KeyPropertyExpressions>> }

    member this.axioms: Set<Annotated<Axiom>> =
        let classExpression = this.Class.Class
        let annotationSubject = IriSubject this.Class.Iri

        let declaration =
            Functional.Class this.Class |> Manchester.declaration |> Set.singleton

        let annotations =
            Manchester.annotationAssertions (annotationSubject, this.Annotations)

        let subClassOf =
            this.SubClassOf
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let subClass: SubClass =
                        { subClassExpression = classExpression
                          superClassExpression = description.asClassExpression }

                    ClassAxiom.SubClassAxiom subClass)
                |> Manchester.classAxiom)

        let equivalentTo =
            this.EquivalentTo
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let equivalentClasses: EquivalentClasses =
                        { equivalentClasses = Set.TwoOrMore.Two(classExpression, description.asClassExpression) }

                    ClassAxiom.EquivalentClassesAxiom equivalentClasses)
                |> Manchester.classAxiom)

        let disjointWith =
            this.DisjointWith
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let disjointClasses: DisjointClasses =
                        { disjointClasses = Set.TwoOrMore.Two(classExpression, description.asClassExpression) }

                    ClassAxiom.DisjointClassesAxiom disjointClasses)
                |> Manchester.classAxiom)

        let disjointUnionOf =
            this.DisjointUnionOf
            |> Set.map (fun entry ->
                entry.map (fun disjointUnionDescriptions ->
                    let disjointUnion: DisjointUnion =
                        { disjointClass = this.Class
                          disjointClassExpressions =
                            disjointUnionDescriptions.disjointUnionDescriptions
                            |> Set.TwoOrMore<Description>
                                .map (fun (description: Description) -> description.asClassExpression) }

                    ClassAxiom.DisjointUnionAxiom disjointUnion)
                |> Manchester.classAxiom)

        let hasKey =
            this.HasKey
            |> Set.map (fun entry ->
                entry.map (fun keyPropertyExpressions ->
                    let hasKey: HasKey =
                        { classExpression = classExpression
                          keyProperties = Manchester.keyProperties keyPropertyExpressions }

                    Axiom.HasKey hasKey))

        Set.unionMany
            [ declaration
              annotations
              subClassOf
              equivalentTo
              disjointWith
              disjointUnionOf
              hasKey ]

and ObjectPropertyFrame =
    { ObjectProperty: ObjectProperty
      Annotations: Set<Annotation>
      Domain: Set<Annotated<Description>>
      Range: Set<Annotated<Description>>
      Characteristics: Set<Annotated<ObjectPropertyCharacteristic>>
      SubPropertyOf: Set<Annotated<ObjectPropertyExpression>>
      EquivalentTo: Set<Annotated<ObjectPropertyExpression>>
      DisjointWith: Set<Annotated<ObjectPropertyExpression>>
      InverseOf: Set<Annotated<ObjectPropertyExpression>>
      SubPropertyChain: Set<Annotated<PropertyExpressionChain>> }

    member this.axioms: Set<Annotated<Axiom>> =
        let objectPropertyExpression =
            Functional.AsObjectPropertyExpression this.ObjectProperty

        let annotationSubject = IriSubject this.ObjectProperty.Iri

        let declaration =
            Functional.ObjectProperty this.ObjectProperty
            |> Manchester.declaration
            |> Set.singleton

        let annotations =
            Manchester.annotationAssertions (annotationSubject, this.Annotations)

        let domain =
            this.Domain
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let domain: ObjectPropertyDomain =
                        { objectPropertyExpression = objectPropertyExpression
                          objectPropertyDomain = description.asClassExpression }

                    ObjectPropertyAxiom.ObjectPropertyDomain domain)
                |> Manchester.objectPropertyAxiom)

        let range =
            this.Range
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let range: ObjectPropertyRange =
                        { objectPropertyExpression = objectPropertyExpression
                          objectPropertyRange = description.asClassExpression }

                    ObjectPropertyAxiom.ObjectPropertyRange range)
                |> Manchester.objectPropertyAxiom)

        let characteristics =
            this.Characteristics
            |> Set.map (fun entry ->
                entry.map (fun characteristic ->
                    match characteristic with
                    | ObjectPropertyCharacteristic.Functional ->
                        ObjectPropertyAxiom.FunctionalObjectProperty
                            { functionalObjectProperty = objectPropertyExpression }
                    | ObjectPropertyCharacteristic.InverseFunctional ->
                        ObjectPropertyAxiom.InverseFunctionalObjectProperty
                            { inverseFunctionalObjectProperty = objectPropertyExpression }
                    | ObjectPropertyCharacteristic.Reflexive ->
                        ObjectPropertyAxiom.ReflexiveObjectProperty
                            { reflexiveObjectProperty = objectPropertyExpression }
                    | ObjectPropertyCharacteristic.Irreflexive ->
                        ObjectPropertyAxiom.IrreflexiveObjectProperty
                            { irreflexiveObjectProperty = objectPropertyExpression }
                    | ObjectPropertyCharacteristic.Symmetric ->
                        ObjectPropertyAxiom.SymmetricObjectProperty
                            { symmetricObjectProperty = objectPropertyExpression }
                    | ObjectPropertyCharacteristic.Asymmetric ->
                        ObjectPropertyAxiom.AsymmetricObjectProperty
                            { asymmetricObjectProperty = objectPropertyExpression }
                    | ObjectPropertyCharacteristic.Transitive ->
                        ObjectPropertyAxiom.TransitiveObjectProperty
                            { transitiveObjectProperty = objectPropertyExpression })
                |> Manchester.objectPropertyAxiom)

        let subPropertyOf =
            this.SubPropertyOf
            |> Set.map (fun entry ->
                entry.map (fun superObjectPropertyExpression ->
                    let subObjectProperty: SubObjectProperty =
                        { subObjectPropertyExpression = SubObjectPropertyExpression objectPropertyExpression
                          superObjectPropertyExpression = superObjectPropertyExpression }

                    ObjectPropertyAxiom.SubObjectProperty subObjectProperty)
                |> Manchester.objectPropertyAxiom)

        let equivalentTo =
            this.EquivalentTo
            |> Set.map (fun entry ->
                entry.map (fun equivalentObjectPropertyExpression ->
                    let equivalent: EquivalentObjectPropertyExpressions =
                        { equivalentObjectPropertyExpressions =
                            Set.TwoOrMore.Two(objectPropertyExpression, equivalentObjectPropertyExpression) }

                    ObjectPropertyAxiom.EquivalentObjectProperties equivalent)
                |> Manchester.objectPropertyAxiom)

        let disjointWith =
            this.DisjointWith
            |> Set.map (fun entry ->
                entry.map (fun disjointObjectPropertyExpression ->
                    let disjoint: DisjointObjectPropertyExpressions =
                        { disjointObjectPropertyExpressions =
                            Set.TwoOrMore.Two(objectPropertyExpression, disjointObjectPropertyExpression) }

                    ObjectPropertyAxiom.DisjointObjectProperties disjoint)
                |> Manchester.objectPropertyAxiom)

        let inverseOf =
            this.InverseOf
            |> Set.map (fun entry ->
                entry.map (fun inverseObjectPropertyExpression ->
                    let inverse: InverseObjectProperties =
                        { inverseObjectProperties = objectPropertyExpression, inverseObjectPropertyExpression }

                    ObjectPropertyAxiom.InverseObjectProperties inverse)
                |> Manchester.objectPropertyAxiom)

        let subPropertyChain =
            this.SubPropertyChain
            |> Set.map (fun entry ->
                entry.map (fun propertyExpressionChain ->
                    let subObjectProperty: SubObjectProperty =
                        { subObjectPropertyExpression = PropertyExpressionChain propertyExpressionChain
                          superObjectPropertyExpression = objectPropertyExpression }

                    ObjectPropertyAxiom.SubObjectProperty subObjectProperty)
                |> Manchester.objectPropertyAxiom)

        Set.unionMany
            [ declaration
              annotations
              domain
              range
              characteristics
              subPropertyOf
              equivalentTo
              disjointWith
              inverseOf
              subPropertyChain ]

and DataPropertyFrame =
    { DataProperty: DataProperty
      Annotations: Set<Annotation>
      Domain: Set<Annotated<Description>>
      Range: Set<Annotated<DataRange>>
      Characteristics: Set<Annotated<DataPropertyCharacteristic>>
      SubPropertyOf: Set<Annotated<DataProperty>>
      EquivalentTo: Set<Annotated<DataProperty>>
      DisjointWith: Set<Annotated<DataProperty>> }

    member this.axioms: Set<Annotated<Axiom>> =
        let dataProperty = this.DataProperty
        let annotationSubject = IriSubject this.DataProperty.Iri

        let declaration =
            Functional.DataProperty this.DataProperty
            |> Manchester.declaration
            |> Set.singleton

        let annotations =
            Manchester.annotationAssertions (annotationSubject, this.Annotations)

        let domain =
            this.Domain
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let domain: DataPropertyDomain =
                        { dataProperty = dataProperty
                          dataPropertyDomain = description.asClassExpression }

                    DataPropertyAxiom.DataPropertyDomain domain)
                |> Manchester.dataPropertyAxiom)

        let range =
            this.Range
            |> Set.map (fun entry ->
                entry.map (fun dataRange ->
                    let range: DataPropertyRange =
                        { dataProperty = dataProperty
                          dataPropertyRange = dataRange }

                    DataPropertyAxiom.DataPropertyRange range)
                |> Manchester.dataPropertyAxiom)

        let characteristics =
            this.Characteristics
            |> Set.map (fun entry ->
                entry.map (fun characteristic ->
                    match characteristic with
                    | DataPropertyCharacteristic.Functional ->
                        DataPropertyAxiom.FunctionalDataProperty { functionalDataProperty = dataProperty })
                |> Manchester.dataPropertyAxiom)

        let subPropertyOf =
            this.SubPropertyOf
            |> Set.map (fun entry ->
                entry.map (fun superDataProperty ->
                    let subDataProperty: SubDataProperty =
                        { subDataProperty = dataProperty
                          superDataProperty = superDataProperty }

                    DataPropertyAxiom.SubDataProperty subDataProperty)
                |> Manchester.dataPropertyAxiom)

        let equivalentTo =
            this.EquivalentTo
            |> Set.map (fun entry ->
                entry.map (fun equivalentDataPropertyExpression ->
                    let equivalent: EquivalentDataProperties =
                        { equivalentDataProperties = Set.TwoOrMore.Two(dataProperty, equivalentDataPropertyExpression) }

                    DataPropertyAxiom.EquivalentDataProperties equivalent)
                |> Manchester.dataPropertyAxiom)

        let disjointWith =
            this.DisjointWith
            |> Set.map (fun entry ->
                entry.map (fun disjointDataPropertyExpression ->
                    let disjoint: DisjointDataProperties =
                        { disjointDataProperties = Set.TwoOrMore.Two(dataProperty, disjointDataPropertyExpression) }

                    DataPropertyAxiom.DisjointDataProperties disjoint)
                |> Manchester.dataPropertyAxiom)

        Set.unionMany
            [ declaration
              annotations
              domain
              range
              characteristics
              subPropertyOf
              equivalentTo
              disjointWith ]

and AnnotationPropertyFrame =
    { AnnotationProperty: AnnotationProperty
      Annotations: Set<Annotation>
      Domain: Set<Annotated<Iri>>
      Range: Set<Annotated<Iri>>
      SubPropertyOf: Set<Annotated<AnnotationProperty>> }

    member this.axioms: Set<Annotated<Axiom>> =
        let annotationSubject = IriSubject this.AnnotationProperty.Iri

        let declaration =
            Functional.AnnotationProperty this.AnnotationProperty
            |> Manchester.declaration
            |> Set.singleton

        let annotations =
            Manchester.annotationAssertions (annotationSubject, this.Annotations)

        let domain =
            this.Domain
            |> Set.map (fun entry ->
                entry.map (fun domainIri ->
                    let domain: AnnotationPropertyDomain =
                        { annotationProperty = this.AnnotationProperty
                          domainIri = domainIri }

                    AnnotationAxiom.AnnotationPropertyDomain domain)
                |> Manchester.annotationAxiom)

        let range =
            this.Range
            |> Set.map (fun entry ->
                entry.map (fun rangeIri ->
                    let range: AnnotationPropertyRange =
                        { annotationProperty = this.AnnotationProperty
                          rangeIri = rangeIri }

                    AnnotationAxiom.AnnotationPropertyRange range)
                |> Manchester.annotationAxiom)

        let subPropertyOf =
            this.SubPropertyOf
            |> Set.map (fun entry ->
                entry.map (fun superAnnotationProperty ->
                    let subProperty: SubAnnotationProperty =
                        { subAnnotationProperty = this.AnnotationProperty
                          superAnnotationProperty = superAnnotationProperty }

                    AnnotationAxiom.SubAnnotationProperty subProperty)
                |> Manchester.annotationAxiom)

        Set.unionMany [ declaration; annotations; domain; range; subPropertyOf ]

and IndividualFrame =
    { Individual: Individual
      Annotations: Set<Annotation>
      Types: Set<Annotated<Description>>
      Facts: Set<Annotated<Fact>>
      SameAs: Set<Annotated<Individual>>
      DifferentFrom: Set<Annotated<Individual>> }

    member this.axioms: Set<Annotated<Axiom>> =
        let annotationSubject = Manchester.individualAnnotationSubject this.Individual

        let declaration =
            Manchester.namedIndividualDeclaration this.Individual
            |> Option.toList
            |> Set.ofList

        let annotations =
            Manchester.annotationAssertions (annotationSubject, this.Annotations)

        let types =
            this.Types
            |> Set.map (fun entry ->
                entry.map (fun description ->
                    let assertion: ClassAssertion =
                        { individual = this.Individual
                          classExpression = description.asClassExpression }

                    Assertion.ClassAssertion assertion)
                |> Manchester.assertionAxiom)

        let facts =
            this.Facts
            |> Set.map (fun entry ->
                entry.map (fun fact -> fact.Assertion this.Individual)
                |> Manchester.assertionAxiom)

        let sameAs =
            this.SameAs
            |> Set.map (fun entry ->
                entry.map (fun sameIndividual ->
                    let same: SameIndividual =
                        { SameIndividual = Set.TwoOrMore.Two(this.Individual, sameIndividual) }

                    Assertion.SameIndividual same)
                |> Manchester.assertionAxiom)

        let differentFrom =
            this.DifferentFrom
            |> Set.map (fun entry ->
                entry.map (fun differentIndividual ->
                    let different: DifferentIndividuals =
                        { DifferentIndividuals = Set.TwoOrMore.Two(this.Individual, differentIndividual) }

                    Assertion.DifferentIndividuals different)
                |> Manchester.assertionAxiom)

        Set.unionMany [ declaration; annotations; types; facts; sameAs; differentFrom ]

and Frame =
    | DatatypeFrame of DatatypeFrame
    | ClassFrame of ClassFrame
    | ObjectPropertyFrame of ObjectPropertyFrame
    | DataPropertyFrame of DataPropertyFrame
    | AnnotationPropertyFrame of AnnotationPropertyFrame
    | IndividualFrame of IndividualFrame
    | Misc of Misc

    member this.axioms: Set<Annotated<Axiom>> =
        match this with
        | DatatypeFrame datatypeFrame -> datatypeFrame.axioms
        | ClassFrame classFrame -> classFrame.axioms
        | ObjectPropertyFrame objectPropertyFrame -> objectPropertyFrame.axioms
        | DataPropertyFrame dataPropertyFrame -> dataPropertyFrame.axioms
        | AnnotationPropertyFrame annotationPropertyFrame -> annotationPropertyFrame.axioms
        | IndividualFrame individualFrame -> individualFrame.axioms
        | Misc misc -> misc.axioms

and Manchester =
    static member inverse(objectProperty: ObjectProperty) =
        Functional.ObjectInverseOf objectProperty

    static member inline mapTwoOrMoreSet
        (mapping: 'Value -> 'MappedValue)
        (values: Set.TwoOrMore<'Value>)
        : Set.TwoOrMore<'MappedValue> =
        let mapped = values.elements |> Set.map mapping
        let mappedArray = mapped |> Set.toArray

        if mappedArray.Length < 2 then
            invalidOp "Lowering collapsed a Manchester two-or-more collection to fewer than two distinct OWL values."

        Set.TwoOrMore.More(mappedArray[0], mappedArray[1], mappedArray[2..] |> Set.ofArray)

    static member annotationAssertions
        (annotationSubject: NormativeSubject, annotations: Set<Annotation>)
        : Set<Annotated<Axiom>> =
        annotations
        |> Set.map (fun annotation ->
            Functional.AnnotationAssertion(
                annotation.annotationAnnotations,
                annotation.annotationProperty,
                annotationSubject,
                annotation.annotationValue
            )
            |> fun assertion -> assertion.map AnnotationAxiom.AnnotationAssertion
            |> fun annotationAxiom -> annotationAxiom.map Axiom.AnnotationAxiom)

    static member declaration(entity: Entity) : Annotated<Axiom> =
        Functional.Declaration entity
        |> fun declaration -> declaration.map Axiom.Declaration

    static member classAxiom(annotatedClassAxiom: Annotated<ClassAxiom>) : Annotated<Axiom> =
        annotatedClassAxiom.map Axiom.ClassAxiom

    static member objectPropertyAxiom(annotatedObjectPropertyAxiom: Annotated<ObjectPropertyAxiom>) : Annotated<Axiom> =
        annotatedObjectPropertyAxiom.map Axiom.ObjectPropertyAxiom

    static member dataPropertyAxiom(annotatedDataPropertyAxiom: Annotated<DataPropertyAxiom>) : Annotated<Axiom> =
        annotatedDataPropertyAxiom.map Axiom.DataPropertyAxiom

    static member assertionAxiom(annotatedAssertion: Annotated<Assertion>) : Annotated<Axiom> =
        annotatedAssertion.map Axiom.Assertion

    static member annotationAxiom(annotatedAnnotationAxiom: Annotated<AnnotationAxiom>) : Annotated<Axiom> =
        annotatedAnnotationAxiom.map Axiom.AnnotationAxiom

    static member keyProperties(keyPropertyExpressions: KeyPropertyExpressions) : KeyProperties =
        let objectPropertyExpressions, dataPropertyExpressions =
            keyPropertyExpressions.keyPropertyExpressions.items
            |> List.fold
                (fun (objectProperties, dataProperties) propertyExpression ->
                    match propertyExpression with
                    | PropertyExpression.ObjectPropertyExpression objectPropertyExpression ->
                        objectPropertyExpression :: objectProperties, dataProperties
                    | PropertyExpression.DataPropertyExpression dataPropertyExpression ->
                        objectProperties, dataPropertyExpression :: dataProperties)
                ([], [])

        let objectPropertySet = objectPropertyExpressions |> Set.ofList
        let dataPropertySet = dataPropertyExpressions |> Set.ofList

        match Set.isEmpty objectPropertySet, Set.isEmpty dataPropertySet with
        | false, false ->
            ObjectDataKeyProperties(Set.OneOrMore.ofSet objectPropertySet, Set.OneOrMore.ofSet dataPropertySet)
        | false, true -> ObjectKeyProperties(Set.OneOrMore.ofSet objectPropertySet)
        | true, false -> DataKeyProperties(Set.OneOrMore.ofSet dataPropertySet)
        | true, true -> invalidOp "A Manchester HasKey entry must contain at least one property expression."

    static member individualAnnotationSubject(individual: Individual) =
        match individual with
        | Individual namedIndividual -> IriSubject namedIndividual.Iri
        | AnonymousIndividual anonymousIndividual -> BNodeSubject anonymousIndividual.BNode

    static member namedIndividualDeclaration(individual: Individual) : Annotated<Axiom> option =
        match individual with
        | Individual namedIndividual -> Functional.NamedIndividual namedIndividual |> Manchester.declaration |> Some
        | AnonymousIndividual _ -> None

and OntologyBuilder(ontologyidentifier: (OntologyIri * VersionIri option) option) =
    let _axioms = ResizeArray<Annotated<Axiom>>()
    let _triples = ResizeArray<NormativeTriple>()
    let _frames = ResizeArray<Frame>()
    let _ontologyAnnotations = ResizeArray<Annotation>()
    let _directlyImportsDocuments = ResizeArray<DirectlyImportsDocument>()
    new() = OntologyBuilder(None)
    new(ontologyIri: Iri) = OntologyBuilder(Some(OntologyIri ontologyIri, None))
    new(ontologyIri: Iri, versionIri: Iri) = OntologyBuilder(Some(OntologyIri ontologyIri, Some(VersionIri versionIri)))

    member _.Yield(ontologyAnnotation: Annotation) =
        _ontologyAnnotations.Add ontologyAnnotation

    member _.Yield(ontologyAnnotations: Annotation list) =
        _ontologyAnnotations.AddRange ontologyAnnotations

    member _.Yield(directlyImportsDocument: DirectlyImportsDocument) =
        _directlyImportsDocuments.Add directlyImportsDocument

    member _.Yield(directlyImportsDocuments: DirectlyImportsDocument list) =
        _directlyImportsDocuments.AddRange directlyImportsDocuments

    member _.Yield(axiom: Annotated<Axiom>) = _axioms.Add axiom
    member _.Yield(axioms: Annotated<Axiom> list) = _axioms.AddRange axioms

    member _.Yield(assertion: Annotated<ClassAssertion>) =
        _axioms.Add(assertion.map (Assertion.ClassAssertion >> Axiom.Assertion))

    member _.Yield(assertions: Annotated<ClassAssertion> list) =
        assertions
        |> List.iter (fun assertion -> _axioms.Add(assertion.map (Assertion.ClassAssertion >> Axiom.Assertion)))

    member _.Yield(triple: NormativeTriple) = _triples.Add triple
    member _.Yield(triples: NormativeTriple list) = _triples.AddRange triples

    member _.Yield(frame: Frame) = _frames.Add frame
    member _.Yield(frames: Frame list) = _frames.AddRange frames

    member _.Yield(declaration: Annotated<Declaration>) =
        _axioms.Add(declaration.map Axiom.Declaration)

    member _.Yield(declarations: Annotated<Declaration> list) =
        declarations
        |> List.iter (fun declaration -> _axioms.Add(declaration.map Axiom.Declaration))

    member _.Yield(classAxiom: Annotated<ClassAxiom>) =
        _axioms.Add(classAxiom.map Axiom.ClassAxiom)

    member _.Yield(classAxioms: Annotated<ClassAxiom> list) =
        classAxioms |> List.iter (fun axiom -> _axioms.Add(axiom.map Axiom.ClassAxiom))

    member _.Yield(objectPropertyAxiom: Annotated<ObjectPropertyAxiom>) =
        _axioms.Add(objectPropertyAxiom.map Axiom.ObjectPropertyAxiom)

    member _.Yield(objectPropertyAxioms: Annotated<ObjectPropertyAxiom> list) =
        objectPropertyAxioms
        |> List.iter (fun axiom -> _axioms.Add(axiom.map Axiom.ObjectPropertyAxiom))

    member _.Yield(dataPropertyAxiom: Annotated<DataPropertyAxiom>) =
        _axioms.Add(dataPropertyAxiom.map Axiom.DataPropertyAxiom)

    member _.Yield(dataPropertyAxioms: Annotated<DataPropertyAxiom> list) =
        dataPropertyAxioms
        |> List.iter (fun axiom -> _axioms.Add(axiom.map Axiom.DataPropertyAxiom))

    member _.Yield(datatypeDefinition: Annotated<DatatypeDefinition>) =
        _axioms.Add(datatypeDefinition.map Axiom.DatatypeDefinition)

    member _.Yield(datatypeDefinitions: Annotated<DatatypeDefinition> list) =
        datatypeDefinitions
        |> List.iter (fun definition -> _axioms.Add(definition.map Axiom.DatatypeDefinition))

    member _.Yield(hasKey: Annotated<HasKey>) = _axioms.Add(hasKey.map Axiom.HasKey)

    member _.Yield(hasKeys: Annotated<HasKey> list) =
        hasKeys |> List.iter (fun hasKey -> _axioms.Add(hasKey.map Axiom.HasKey))

    member _.Yield(assertion: Annotated<Assertion>) =
        _axioms.Add(assertion.map Axiom.Assertion)

    member _.Yield(assertions: Annotated<Assertion> list) =
        assertions
        |> List.iter (fun assertion -> _axioms.Add(assertion.map Axiom.Assertion))

    member _.Yield(assertions: Assertion list) =
        assertions
        |> List.iter (fun assertion ->
            _axioms.Add(
                { annotations = Set.empty
                  value = Assertion assertion }
            ))

    member _.Yield(annotationAxiom: Annotated<AnnotationAxiom>) =
        _axioms.Add(annotationAxiom.map Axiom.AnnotationAxiom)

    member _.Yield(annotationAxioms: Annotated<AnnotationAxiom> list) =
        annotationAxioms
        |> List.iter (fun axiom -> _axioms.Add(axiom.map Axiom.AnnotationAxiom))

    member _.Combine(_: unit, _: unit) =

        ()

    member _.Delay(computation: unit -> unit) : unit = computation ()

    member _.For(source: seq<'T>, body: 'T -> unit) : unit =

        for item in source do
            body item

    member _.Zero() : unit = ()

    member _.Run(_: unit) =
        { annotations = _ontologyAnnotations |> Set.ofSeq
          value =
            { ontologyIdentifier = ontologyidentifier
              directlyImportsDocuments = _directlyImportsDocuments |> Set.ofSeq
              statedAxioms = _axioms |> Set.ofSeq
              constructedFrames = _frames |> List.ofSeq
              assertedTriples = _triples |> Set.ofSeq } }

and NTriples =
    static member IRIREF(iri: Iri) =

        let result = StringBuilder()

        for rune in iri.identity.EnumerateRunes() do
            let cp = rune.Value

            if
                cp <= 0x20
                || cp = 0x3C
                || cp = 0x3E
                || cp = 0x22
                || cp = 0x7B
                || cp = 0x7D
                || cp = 0x7C
                || cp = 0x5E
                || cp = 0x60
                || cp = 0x5C
            then

                if cp <= 0xFFFF then
                    result.Append($"\\u{cp:X4}") |> ignore
                else
                    result.Append($"\\U{cp:X8}") |> ignore
            else
                result.Append(rune.ToString()) |> ignore

        $"<{result.ToString()}>"

    static member BLANK_NODE_LABEL(bnode: BNode) = $"_:{bnode.identity}"

    static member STRING_LITERAL_QUOTE(literal: Literal) =
        let result = StringBuilder()

        result.Append('"') |> ignore

        for rune in literal.identity.lexicalForm.EnumerateRunes() do
            match rune.Value with
            | 0x22 -> result.Append("\\\"") |> ignore
            | 0x5C -> result.Append("\\\\") |> ignore
            | 0x0A -> result.Append("\\n") |> ignore
            | 0x0D -> result.Append("\\r") |> ignore
            | cp when cp <= 0x1F || cp = 0x7F -> result.Append($"\\u{cp:X4}") |> ignore
            | _ -> result.Append(rune.ToString()) |> ignore

        result.Append('"') |> ignore
        result.ToString()

    static member LANG_DIR(languageString: LanguageString) =
        match languageString.baseDirection with
        | Some baseDirection -> $"@{languageString.languageTag.identity}--{baseDirection.identity}"
        | None -> $"@{languageString.languageTag.identity}"

    static member literal(literal: Literal) =
        match literal with
        | StringLiteral(SimpleString simpleString) -> NTriples.STRING_LITERAL_QUOTE literal
        | StringLiteral(LanguageString languageString) ->
            $"{NTriples.STRING_LITERAL_QUOTE literal}{NTriples.LANG_DIR languageString}"
        | TypedLiteral typedLiteral ->
            $"{NTriples.STRING_LITERAL_QUOTE literal}^^{NTriples.IRIREF typedLiteral.datatypeIri}"
        | EmbeddedLiteral embeddedLiteral ->
            $"{NTriples.STRING_LITERAL_QUOTE literal}^^{NTriples.IRIREF embeddedLiteral.datatypeIri}"

    static member subject(normativeSubject: NormativeSubject) =
        match normativeSubject with
        | IriSubject iri -> NTriples.IRIREF iri
        | BNodeSubject bnode -> NTriples.BLANK_NODE_LABEL bnode

    static member predicate(normativePredicate: NormativePredicate) =
        match normativePredicate with
        | IriPredicate iri -> NTriples.IRIREF iri

    static member object_(basicNormativeObject: BasicNormativeObject) =
        match basicNormativeObject with
        | IriObject iri -> NTriples.IRIREF iri
        | BNodeObject bnode -> NTriples.BLANK_NODE_LABEL bnode
        | LiteralObject literal -> NTriples.literal literal

    static member object_(normativeObject: NormativeObject) =
        match normativeObject with
        | BasicNormativeObject basicNormativeObject -> NTriples.object_ basicNormativeObject
        | TripleTermObject tripleTerm -> NTriples.tripleTerm tripleTerm

    static member triple(triple: NormativeTriple) =
        $"{NTriples.subject triple.normativeSubject} {NTriples.predicate triple.normativePredicate} {NTriples.object_ triple.normativeObject} ."

    static member tripleTerm(tripleTerm: TripleTerm) =
        $"<<( {NTriples.subject tripleTerm.triple.normativeSubject} {NTriples.predicate tripleTerm.triple.normativePredicate} {NTriples.object_ tripleTerm.triple.normativeObject} )>>"

    static member ntriplesDoc(triples: Set<NormativeTriple>) =
        triples |> Set.toSeq |> Seq.map NTriples.triple

    static member ntriplesDoc(ontology: Ontology) =
        ontology.assertedTriples |> Set.toSeq |> Seq.map NTriples.triple

    static member ntriplesDoc(ontology: Annotated<Ontology>) =
        ontology.value.assertedTriples |> Set.toSeq |> Seq.map NTriples.triple

type Iana.ProtocolRegistryEntry with
    member this.Iri = RdfVocabulary.ianassignments.curie this.localName

type Iana.InternetMediaType with
    member this.topLevelIri =
        RdfVocabulary.ianassignments.prefixedName this.mimeType.MediaType

    member this.registryIri =
        (RdfVocabulary.ofPrefixedName this.topLevelIri).prefixedName this.mimeType.SubType

    member this.w3idDatatype =
        RdfVocabulary.w3id_mediatype.curie this.contentType |> DatatypeIri

    member this.sparDatatype =
        RdfVocabulary.spar_mediatype.curie this.contentType |> DatatypeIri

module xml =
    open LitXml

    let attrQName (prefix: string) (namespaceIri: string) (localName: string) (attributeValue: 'Value) : Attr =

        Ok((fun writer -> writer.WriteAttributeString(prefix, localName, namespaceIri, string attributeValue)), [])

    let attrNS (namespaceIri: string) (localName: string) (attributeValue: 'Value) : Attr =
        attrQName String.Empty namespaceIri localName attributeValue

    let ns (namespace_: 'Namespace) = attr "xmlns" namespace_

    let lang (language: 'Language) =
        attrQName "xml" "http://www.w3.org/XML/1998/namespace" "lang" language

    type NamespaceElementBuilder(prefix: string, namespaceIri: string, localName: string) =
        new(namespaceIri: string, localName: string) = NamespaceElementBuilder(String.Empty, namespaceIri, localName)

        member _.Yield(part: XmlPart) : XmlPart list = [ part ]

        member _.YieldFrom(parts: seq<XmlPart>) : XmlPart list = List.ofSeq parts

        member _.Zero() : XmlPart list = []

        member _.Combine(first: XmlPart list, second: XmlPart list) : XmlPart list = first @ second

        member _.Delay(computation: unit -> XmlPart list) = computation ()

        member _.For(source: seq<'T>, body: 'T -> XmlPart list) : XmlPart list =

            [ for item in source do
                  yield! body item ]

        member _.Run(parts: XmlPart list) : XmlPart =
            Ok(
                (fun writer ->
                    writer.WriteStartElement(prefix, localName, namespaceIri)

                    for part in parts do
                        part.Invoke writer

                    writer.WriteEndElement()),
                []
            )

    let elemQName (prefix: string) (namespaceIri: string) (localName: string) =

        NamespaceElementBuilder(prefix, namespaceIri, localName)

    let elemNS (namespaceIri: string) (localName: string) =

        NamespaceElementBuilder(namespaceIri, localName)

module xsd =
    let _namespace = RdfVocabulary.xsd

    module Measure =
        [<Measure>]
        type anyURI =

            static member lexicalForm(literal: string<anyURI>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<anyURI> = UMX.tag lexicalForm
            static member canonicalMapping(value: System.Uri) : System.String = value.OriginalString

            static member literal(value: System.Uri) : string<anyURI> =
                anyURI.canonicalMapping value |> anyURI.literal

            static member uriValue(literal: string<anyURI>) : System.Uri =
                literal |> anyURI.lexicalForm |> System.Uri

            static member datatype: Datatype<anyURI> =
                { _datatypeIri = _namespace.curie "anyURI" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Uri) : StaticTypedLiteral<anyURI> =
                { literal = anyURI.literal value
                  datatype = anyURI.datatype }

            static member typedLiteral(value: System.Uri) : TypedLiteral =
                anyURI.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

            static member canonicalMapping(value: Url) : System.String = anyURI.canonicalMapping (value.ToUri())

            static member literal(value: Url) : string<anyURI> =
                anyURI.canonicalMapping value |> anyURI.literal

            static member urlValue(literal: string<anyURI>) : Url = literal |> anyURI.lexicalForm |> Url

            static member staticTypedLiteral(value: Url) : StaticTypedLiteral<anyURI> =
                { literal = anyURI.literal value
                  datatype = anyURI.datatype }

            static member typedLiteral(value: Url) : TypedLiteral =
                anyURI.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

            static member canonicalMapping(value: Irl) : System.String = anyURI.canonicalMapping (value.Url)

            static member literal(value: Irl) : string<anyURI> =
                anyURI.canonicalMapping value |> anyURI.literal

            static member irlValue(literal: string<anyURI>) : Irl =
                literal |> anyURI.lexicalForm |> Url |> Irl.ofUrl

            static member staticTypedLiteral(value: Irl) : StaticTypedLiteral<anyURI> =
                { literal = anyURI.literal value
                  datatype = anyURI.datatype }

            static member typedLiteral(value: Irl) : TypedLiteral =
                anyURI.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

            static member canonicalMapping(value: Iri) : System.String = anyURI.canonicalMapping (value.asUri)

            static member literal(value: Iri) : string<anyURI> =
                anyURI.canonicalMapping value |> anyURI.literal

            static member iriValue(literal: string<anyURI>) : Iri =
                literal |> anyURI.lexicalForm |> Iri.op_Implicit

            static member staticTypedLiteral(value: Iri) : StaticTypedLiteral<anyURI> =
                { literal = anyURI.literal value
                  datatype = anyURI.datatype }

            static member typedLiteral(value: Iri) : TypedLiteral =
                anyURI.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        // Generated declarations to paste inside module xsd.Measure.
        // Requires: open System; open System.Globalization
        // Uses existing UMX, Datatype, TypedLiteral, StaticTypedLiteral, _namespace.
        // `literal(string)` is a tag, not lexical validation.
        // CLR mappings below are selected representations, not exhaustive XSD value spaces.

        [<Measure>]
        type base64Binary =
            static member canonicalMapping(value: System.Byte array) : System.String = Convert.ToBase64String(value)

            static member lexicalForm(literal: string<base64Binary>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<base64Binary> = UMX.tag lexicalForm

            static member literal(value: System.Byte array) : string<base64Binary> =
                base64Binary.canonicalMapping value |> base64Binary.literal

            static member value(literal: string<base64Binary>) : System.Byte array =
                let raw = base64Binary.lexicalForm literal
                let value = Convert.FromBase64String(raw)
                value

            static member datatype: Datatype<base64Binary> =
                { _datatypeIri = _namespace.curie "base64Binary" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Byte array) : StaticTypedLiteral<base64Binary> =
                { literal = base64Binary.literal value
                  datatype = base64Binary.datatype }

            static member typedLiteral(value: System.Byte array) : TypedLiteral =
                base64Binary.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type boolean =
            static member canonicalMapping(value: System.Boolean) : System.String = if value then "true" else "false"

            static member lexicalForm(literal: string<boolean>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<boolean> = UMX.tag lexicalForm

            static member literal(value: System.Boolean) : string<boolean> =
                boolean.canonicalMapping value |> boolean.literal

            static member value(literal: string<boolean>) : System.Boolean =
                let raw = boolean.lexicalForm literal

                let value =
                    match raw with
                    | "true"
                    | "1" -> true
                    | "false"
                    | "0" -> false
                    | _ -> invalidArg "literal" "Invalid xsd:boolean lexical form"

                value

            static member datatype: Datatype<boolean> =
                { _datatypeIri = _namespace.curie "boolean" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Boolean) : StaticTypedLiteral<boolean> =
                { literal = boolean.literal value
                  datatype = boolean.datatype }

            static member typedLiteral(value: System.Boolean) : TypedLiteral =
                boolean.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type date =
            static member canonicalMapping(value: System.DateOnly) : System.String =
                value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<date>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<date> = UMX.tag lexicalForm

            static member literal(value: System.DateOnly) : string<date> =
                date.canonicalMapping value |> date.literal

            static member value(literal: string<date>) : System.DateOnly =
                let raw = date.lexicalForm literal

                let value =
                    System.DateOnly.ParseExact(raw, "yyyy-MM-dd", CultureInfo.InvariantCulture)

                value

            static member datatype: Datatype<date> =
                { _datatypeIri = _namespace.curie "date" |> DatatypeIri }

            static member staticTypedLiteral(value: System.DateOnly) : StaticTypedLiteral<date> =
                { literal = date.literal value
                  datatype = date.datatype }

            static member typedLiteral(value: System.DateOnly) : TypedLiteral =
                date.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type dateTime =
            static member canonicalMapping(value: System.DateTime) : System.String =
                value.ToString("o", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<dateTime>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<dateTime> = UMX.tag lexicalForm

            static member literal(value: System.DateTime) : string<dateTime> =
                dateTime.canonicalMapping value |> dateTime.literal

            static member value(literal: string<dateTime>) : System.DateTime =
                let raw = dateTime.lexicalForm literal

                let value =
                    System.DateTime.Parse(raw, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind)

                value

            static member datatype: Datatype<dateTime> =
                { _datatypeIri = _namespace.curie "dateTime" |> DatatypeIri }

            static member staticTypedLiteral(value: System.DateTime) : StaticTypedLiteral<dateTime> =
                { literal = dateTime.literal value
                  datatype = dateTime.datatype }

            static member typedLiteral(value: System.DateTime) : TypedLiteral =
                dateTime.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type dateTimeStamp =
            static member canonicalMapping(value: System.DateTimeOffset) : System.String =
                value.ToString("o", CultureInfo.InvariantCulture)

            static member literal(lexicalForm: System.String) : string<dateTimeStamp> = UMX.tag lexicalForm

            static member literal(value: DateTimeOffset) : string<dateTimeStamp> =
                dateTimeStamp.canonicalMapping value |> dateTimeStamp.literal

            static member value(literal: string<dateTimeStamp>) : DateTimeOffset =
                dateTimeStamp.lexicalForm literal |> DateTimeOffset.Parse

            static member lexicalForm(literal: string<dateTimeStamp>) : System.String = UMX.untag literal

            static member datatype: Datatype<dateTimeStamp> =
                { _datatypeIri = _namespace.curie "dateTimeStamp" |> DatatypeIri }

            static member staticTypedLiteral(value: System.DateTimeOffset) : StaticTypedLiteral<dateTimeStamp> =

                { literal = dateTimeStamp.canonicalMapping value |> dateTimeStamp.literal
                  datatype = dateTimeStamp.datatype }

            static member typedLiteral(value: System.DateTimeOffset) : TypedLiteral =

                dateTimeStamp.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type decimal =
            static member canonicalMapping(value: System.Decimal) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<decimal>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<decimal> = UMX.tag lexicalForm

            static member literal(value: System.Decimal) : string<decimal> =
                decimal.canonicalMapping value |> decimal.literal

            static member value(literal: string<decimal>) : System.Decimal =
                let raw = decimal.lexicalForm literal

                let value = literal |> decimal.lexicalForm |> System.Xml.XmlConvert.ToDecimal
                value

            static member datatype: Datatype<decimal> =
                { _datatypeIri = _namespace.curie "decimal" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Decimal) : StaticTypedLiteral<decimal> =
                { literal = decimal.literal value
                  datatype = decimal.datatype }

            static member typedLiteral(value: System.Decimal) : TypedLiteral =
                decimal.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type integer =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<integer>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<integer> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<integer> =
                integer.canonicalMapping value |> integer.literal

            static member value(literal: string<integer>) : System.Numerics.BigInteger =
                let raw = integer.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<integer> =
                { _datatypeIri = _namespace.curie "integer" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<integer> =
                { literal = integer.literal value
                  datatype = integer.datatype }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                integer.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type long =
            static member canonicalMapping(value: System.Int64) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<long>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<long> = UMX.tag lexicalForm

            static member literal(value: System.Int64) : string<long> =
                long.canonicalMapping value |> long.literal

            static member value(literal: string<long>) : System.Int64 =
                let raw = long.lexicalForm literal
                let value = System.Int64.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<long> =
                { _datatypeIri = _namespace.curie "long" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Int64) : StaticTypedLiteral<long> =
                { literal = long.literal value
                  datatype = long.datatype }

            static member typedLiteral(value: System.Int64) : TypedLiteral =
                long.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type int =
            static member canonicalMapping(value: System.Int32) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<int>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<int> = UMX.tag lexicalForm

            static member literal(value: System.Int32) : string<int> =
                int.canonicalMapping value |> int.literal

            static member value(literal: string<int>) : System.Int32 =
                let raw = int.lexicalForm literal
                let value = System.Int32.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<int> =
                { _datatypeIri = _namespace.curie "int" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Int32) : StaticTypedLiteral<int> =
                { literal = int.literal value
                  datatype = int.datatype }

            static member typedLiteral(value: System.Int32) : TypedLiteral =
                int.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type short =
            static member canonicalMapping(value: System.Int16) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<short>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<short> = UMX.tag lexicalForm

            static member literal(value: System.Int16) : string<short> =
                short.canonicalMapping value |> short.literal

            static member value(literal: string<short>) : System.Int16 =
                let raw = short.lexicalForm literal
                let value = System.Int16.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<short> =
                { _datatypeIri = _namespace.curie "short" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Int16) : StaticTypedLiteral<short> =
                { literal = short.literal value
                  datatype = short.datatype }

            static member typedLiteral(value: System.Int16) : TypedLiteral =
                short.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type byte =
            static member canonicalMapping(value: System.SByte) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<byte>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<byte> = UMX.tag lexicalForm

            static member literal(value: System.SByte) : string<byte> =
                byte.canonicalMapping value |> byte.literal

            static member value(literal: string<byte>) : System.SByte =
                let raw = byte.lexicalForm literal
                let value = System.SByte.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<byte> =
                { _datatypeIri = _namespace.curie "byte" |> DatatypeIri }

            static member staticTypedLiteral(value: System.SByte) : StaticTypedLiteral<byte> =
                { literal = byte.literal value
                  datatype = byte.datatype }

            static member typedLiteral(value: System.SByte) : TypedLiteral =
                byte.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type nonNegativeInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<nonNegativeInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<nonNegativeInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<nonNegativeInteger> =
                if not (value >= System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:nonNegativeInteger value space"

                nonNegativeInteger.canonicalMapping value |> nonNegativeInteger.literal

            static member value(literal: string<nonNegativeInteger>) : System.Numerics.BigInteger =
                let raw = nonNegativeInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)

                if not (value >= System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:nonNegativeInteger value space"

                value

            static member datatype: Datatype<nonNegativeInteger> =
                { _datatypeIri = _namespace.curie "nonNegativeInteger" |> DatatypeIri }

            static member staticTypedLiteral
                (value: System.Numerics.BigInteger)
                : StaticTypedLiteral<nonNegativeInteger> =
                { literal = nonNegativeInteger.literal value
                  datatype = nonNegativeInteger.datatype }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                nonNegativeInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type positiveInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<positiveInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<positiveInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<positiveInteger> =
                if not (value > System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:positiveInteger value space"

                positiveInteger.canonicalMapping value |> positiveInteger.literal

            static member value(literal: string<positiveInteger>) : System.Numerics.BigInteger =
                let raw = positiveInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)

                if not (value > System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:positiveInteger value space"

                value

            static member datatype: Datatype<positiveInteger> =
                { _datatypeIri = _namespace.curie "positiveInteger" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<positiveInteger> =
                { literal = positiveInteger.literal value
                  datatype = positiveInteger.datatype }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                positiveInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedLong =
            static member canonicalMapping(value: System.UInt64) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedLong>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedLong> = UMX.tag lexicalForm

            static member literal(value: System.UInt64) : string<unsignedLong> =
                unsignedLong.canonicalMapping value |> unsignedLong.literal

            static member value(literal: string<unsignedLong>) : System.UInt64 =
                let raw = unsignedLong.lexicalForm literal
                let value = System.UInt64.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedLong> =
                { _datatypeIri = _namespace.curie "unsignedLong" |> DatatypeIri }

            static member staticTypedLiteral(value: System.UInt64) : StaticTypedLiteral<unsignedLong> =
                { literal = unsignedLong.literal value
                  datatype = unsignedLong.datatype }

            static member typedLiteral(value: System.UInt64) : TypedLiteral =
                unsignedLong.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedInt =
            static member canonicalMapping(value: System.UInt32) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedInt>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedInt> = UMX.tag lexicalForm

            static member literal(value: System.UInt32) : string<unsignedInt> =
                unsignedInt.canonicalMapping value |> unsignedInt.literal

            static member value(literal: string<unsignedInt>) : System.UInt32 =
                let raw = unsignedInt.lexicalForm literal
                let value = System.UInt32.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedInt> =
                { _datatypeIri = _namespace.curie "unsignedInt" |> DatatypeIri }

            static member staticTypedLiteral(value: System.UInt32) : StaticTypedLiteral<unsignedInt> =
                { literal = unsignedInt.literal value
                  datatype = unsignedInt.datatype }

            static member typedLiteral(value: System.UInt32) : TypedLiteral =
                unsignedInt.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedShort =
            static member canonicalMapping(value: System.UInt16) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedShort>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedShort> = UMX.tag lexicalForm

            static member literal(value: System.UInt16) : string<unsignedShort> =
                unsignedShort.canonicalMapping value |> unsignedShort.literal

            static member value(literal: string<unsignedShort>) : System.UInt16 =
                let raw = unsignedShort.lexicalForm literal
                let value = System.UInt16.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedShort> =
                { _datatypeIri = _namespace.curie "unsignedShort" |> DatatypeIri }

            static member staticTypedLiteral(value: System.UInt16) : StaticTypedLiteral<unsignedShort> =
                { literal = unsignedShort.literal value
                  datatype = unsignedShort.datatype }

            static member typedLiteral(value: System.UInt16) : TypedLiteral =
                unsignedShort.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type unsignedByte =
            static member canonicalMapping(value: System.Byte) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<unsignedByte>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<unsignedByte> = UMX.tag lexicalForm

            static member literal(value: System.Byte) : string<unsignedByte> =
                unsignedByte.canonicalMapping value |> unsignedByte.literal

            static member value(literal: string<unsignedByte>) : System.Byte =
                let raw = unsignedByte.lexicalForm literal
                let value = System.Byte.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<unsignedByte> =
                { _datatypeIri = _namespace.curie "unsignedByte" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Byte) : StaticTypedLiteral<unsignedByte> =
                { literal = unsignedByte.literal value
                  datatype = unsignedByte.datatype }

            static member typedLiteral(value: System.Byte) : TypedLiteral =
                unsignedByte.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type nonPositiveInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<nonPositiveInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<nonPositiveInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<nonPositiveInteger> =
                if not (value <= System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:nonPositiveInteger value space"

                nonPositiveInteger.canonicalMapping value |> nonPositiveInteger.literal

            static member value(literal: string<nonPositiveInteger>) : System.Numerics.BigInteger =
                let raw = nonPositiveInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)

                if not (value <= System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:nonPositiveInteger value space"

                value

            static member datatype: Datatype<nonPositiveInteger> =
                { _datatypeIri = _namespace.curie "nonPositiveInteger" |> DatatypeIri }

            static member staticTypedLiteral
                (value: System.Numerics.BigInteger)
                : StaticTypedLiteral<nonPositiveInteger> =
                { literal = nonPositiveInteger.literal value
                  datatype = nonPositiveInteger.datatype }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                nonPositiveInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type negativeInteger =
            static member canonicalMapping(value: System.Numerics.BigInteger) : System.String =
                value.ToString(CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<negativeInteger>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<negativeInteger> = UMX.tag lexicalForm

            static member literal(value: System.Numerics.BigInteger) : string<negativeInteger> =
                if not (value < System.Numerics.BigInteger.Zero) then
                    invalidArg "value" "Value is outside the xsd:negativeInteger value space"

                negativeInteger.canonicalMapping value |> negativeInteger.literal

            static member value(literal: string<negativeInteger>) : System.Numerics.BigInteger =
                let raw = negativeInteger.lexicalForm literal
                let value = System.Numerics.BigInteger.Parse(raw, CultureInfo.InvariantCulture)

                if not (value < System.Numerics.BigInteger.Zero) then
                    invalidArg "literal" "Value is outside the xsd:negativeInteger value space"

                value

            static member datatype: Datatype<negativeInteger> =
                { _datatypeIri = _namespace.curie "negativeInteger" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Numerics.BigInteger) : StaticTypedLiteral<negativeInteger> =
                { literal = negativeInteger.literal value
                  datatype = negativeInteger.datatype }

            static member typedLiteral(value: System.Numerics.BigInteger) : TypedLiteral =
                negativeInteger.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type double =
            static member canonicalMapping(value: System.Double) : System.String =
                match value.ToString("R", CultureInfo.InvariantCulture) with
                | "Infinity" -> "INF"
                | "-Infinity" -> "-INF"
                | lexicalRepresentation -> lexicalRepresentation

            static member lexicalForm(literal: string<double>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<double> = UMX.tag lexicalForm

            static member literal(value: System.Double) : string<double> =
                double.canonicalMapping value |> double.literal

            static member value(literal: string<double>) : System.Double =
                let raw = double.lexicalForm literal
                let value = System.Xml.XmlConvert.ToDouble(raw)
                value

            static member datatype: Datatype<double> =
                { _datatypeIri = _namespace.curie "double" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Double) : StaticTypedLiteral<double> =
                { literal = double.literal value
                  datatype = double.datatype }

            static member typedLiteral(value: System.Double) : TypedLiteral =
                double.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type duration =
            static member canonicalMapping(value: System.TimeSpan) : System.String =
                System.Xml.XmlConvert.ToString(value)

            static member lexicalForm(literal: string<duration>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<duration> = UMX.tag lexicalForm

            static member literal(value: System.TimeSpan) : string<duration> =
                duration.canonicalMapping value |> duration.literal

            static member value(literal: string<duration>) : System.TimeSpan =
                let raw = duration.lexicalForm literal
                let value = System.Xml.XmlConvert.ToTimeSpan(raw)
                value

            static member datatype: Datatype<duration> =
                { _datatypeIri = _namespace.curie "duration" |> DatatypeIri }

            static member staticTypedLiteral(value: System.TimeSpan) : StaticTypedLiteral<duration> =
                { literal = duration.literal value
                  datatype = duration.datatype }

            static member typedLiteral(value: System.TimeSpan) : TypedLiteral =
                duration.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type dayTimeDuration =
            static member canonicalMapping(value: System.TimeSpan) : System.String =
                System.Xml.XmlConvert.ToString(value)

            static member lexicalForm(literal: string<dayTimeDuration>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<dayTimeDuration> = UMX.tag lexicalForm

            static member literal(value: System.TimeSpan) : string<dayTimeDuration> =
                dayTimeDuration.canonicalMapping value |> dayTimeDuration.literal

            static member value(literal: string<dayTimeDuration>) : System.TimeSpan =
                let raw = dayTimeDuration.lexicalForm literal
                let value = System.Xml.XmlConvert.ToTimeSpan(raw)
                value

            static member datatype: Datatype<dayTimeDuration> =
                { _datatypeIri = _namespace.curie "dayTimeDuration" |> DatatypeIri }

            static member staticTypedLiteral(value: System.TimeSpan) : StaticTypedLiteral<dayTimeDuration> =
                { literal = dayTimeDuration.literal value
                  datatype = dayTimeDuration.datatype }

            static member typedLiteral(value: System.TimeSpan) : TypedLiteral =
                dayTimeDuration.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type float =
            static member canonicalMapping(value: System.Single) : System.String =
                match value.ToString("R", CultureInfo.InvariantCulture) with
                | "Infinity" -> "INF"
                | "-Infinity" -> "-INF"
                | lexicalRepresentation -> lexicalRepresentation

            static member lexicalForm(literal: string<float>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<float> = UMX.tag lexicalForm

            static member literal(value: System.Single) : string<float> =
                float.canonicalMapping value |> float.literal

            static member value(literal: string<float>) : System.Single =
                let raw = float.lexicalForm literal
                let value = System.Xml.XmlConvert.ToSingle(raw)
                value

            static member datatype: Datatype<float> =
                { _datatypeIri = _namespace.curie "float" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Single) : StaticTypedLiteral<float> =
                { literal = float.literal value
                  datatype = float.datatype }

            static member typedLiteral(value: System.Single) : TypedLiteral =
                float.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type hexBinary =
            static member canonicalMapping(value: System.Byte array) : System.String = Convert.ToHexString(value)

            static member lexicalForm(literal: string<hexBinary>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<hexBinary> = UMX.tag lexicalForm

            static member literal(value: System.Byte array) : string<hexBinary> =
                hexBinary.canonicalMapping value |> hexBinary.literal

            static member value(literal: string<hexBinary>) : System.Byte array =
                let raw = hexBinary.lexicalForm literal
                let value = Convert.FromHexString(raw)
                value

            static member datatype: Datatype<hexBinary> =
                { _datatypeIri = _namespace.curie "hexBinary" |> DatatypeIri }

            static member staticTypedLiteral(value: System.Byte array) : StaticTypedLiteral<hexBinary> =
                { literal = hexBinary.literal value
                  datatype = hexBinary.datatype }

            static member typedLiteral(value: System.Byte array) : TypedLiteral =
                hexBinary.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type time =
            static member canonicalMapping(value: System.TimeOnly) : System.String =
                value.ToString("HH:mm:ss.fffffff", CultureInfo.InvariantCulture)

            static member lexicalForm(literal: string<time>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<time> = UMX.tag lexicalForm

            static member literal(value: System.TimeOnly) : string<time> =
                time.canonicalMapping value |> time.literal

            static member value(literal: string<time>) : System.TimeOnly =
                let raw = time.lexicalForm literal
                let value = System.TimeOnly.Parse(raw, CultureInfo.InvariantCulture)
                value

            static member datatype: Datatype<time> =
                { _datatypeIri = _namespace.curie "time" |> DatatypeIri }

            static member staticTypedLiteral(value: System.TimeOnly) : StaticTypedLiteral<time> =
                { literal = time.literal value
                  datatype = time.datatype }

            static member typedLiteral(value: System.TimeOnly) : TypedLiteral =
                time.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type yearMonthDuration =
            static member lexicalForm(literal: string<yearMonthDuration>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<yearMonthDuration> = UMX.tag lexicalForm

            static member datatype: Datatype<yearMonthDuration> =
                { _datatypeIri = _namespace.curie "yearMonthDuration" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<yearMonthDuration> =
                { literal = yearMonthDuration.literal lexicalForm
                  datatype = yearMonthDuration.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                yearMonthDuration.staticTypedLiteral lexicalForm
                |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gDay =
            static member lexicalForm(literal: string<gDay>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gDay> = UMX.tag lexicalForm

            static member datatype: Datatype<gDay> =
                { _datatypeIri = _namespace.curie "gDay" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gDay> =
                { literal = gDay.literal lexicalForm
                  datatype = gDay.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gDay.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gMonth =
            static member lexicalForm(literal: string<gMonth>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gMonth> = UMX.tag lexicalForm

            static member datatype: Datatype<gMonth> =
                { _datatypeIri = _namespace.curie "gMonth" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gMonth> =
                { literal = gMonth.literal lexicalForm
                  datatype = gMonth.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gMonth.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gMonthDay =
            static member lexicalForm(literal: string<gMonthDay>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gMonthDay> = UMX.tag lexicalForm

            static member datatype: Datatype<gMonthDay> =
                { _datatypeIri = _namespace.curie "gMonthDay" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gMonthDay> =
                { literal = gMonthDay.literal lexicalForm
                  datatype = gMonthDay.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gMonthDay.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gYear =
            static member lexicalForm(literal: string<gYear>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gYear> = UMX.tag lexicalForm

            static member datatype: Datatype<gYear> =
                { _datatypeIri = _namespace.curie "gYear" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gYear> =
                { literal = gYear.literal lexicalForm
                  datatype = gYear.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gYear.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type gYearMonth =
            static member lexicalForm(literal: string<gYearMonth>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<gYearMonth> = UMX.tag lexicalForm

            static member datatype: Datatype<gYearMonth> =
                { _datatypeIri = _namespace.curie "gYearMonth" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<gYearMonth> =
                { literal = gYearMonth.literal lexicalForm
                  datatype = gYearMonth.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                gYearMonth.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type string =
            static member lexicalForm(literal: string<string>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<string> = UMX.tag lexicalForm

            static member datatype: Datatype<string> =
                { _datatypeIri = _namespace.curie "string" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<string> =
                { literal = string.literal lexicalForm
                  datatype = string.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                string.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type normalizedString =
            static member lexicalForm(literal: string<normalizedString>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<normalizedString> = UMX.tag lexicalForm

            static member datatype: Datatype<normalizedString> =
                { _datatypeIri = _namespace.curie "normalizedString" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<normalizedString> =
                { literal = normalizedString.literal lexicalForm
                  datatype = normalizedString.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                normalizedString.staticTypedLiteral lexicalForm
                |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type token =
            static member lexicalForm(literal: string<token>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<token> = UMX.tag lexicalForm

            static member datatype: Datatype<token> =
                { _datatypeIri = _namespace.curie "token" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<token> =
                { literal = token.literal lexicalForm
                  datatype = token.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                token.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type language =
            static member lexicalForm(literal: string<language>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<language> = UMX.tag lexicalForm

            static member datatype: Datatype<language> =
                { _datatypeIri = _namespace.curie "language" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<language> =
                { literal = language.literal lexicalForm
                  datatype = language.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                language.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type Name =
            static member lexicalForm(literal: string<Name>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<Name> = UMX.tag lexicalForm

            static member datatype: Datatype<Name> =
                { _datatypeIri = _namespace.curie "Name" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<Name> =
                { literal = Name.literal lexicalForm
                  datatype = Name.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                Name.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type NCName =
            static member lexicalForm(literal: string<NCName>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<NCName> = UMX.tag lexicalForm

            static member datatype: Datatype<NCName> =
                { _datatypeIri = _namespace.curie "NCName" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<NCName> =
                { literal = NCName.literal lexicalForm
                  datatype = NCName.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                NCName.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

        [<Measure>]
        type NMTOKEN =
            static member lexicalForm(literal: string<NMTOKEN>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<NMTOKEN> = UMX.tag lexicalForm

            static member datatype: Datatype<NMTOKEN> =
                { _datatypeIri = _namespace.curie "NMTOKEN" |> DatatypeIri }

            static member staticTypedLiteral(lexicalForm: System.String) : StaticTypedLiteral<NMTOKEN> =
                { literal = NMTOKEN.literal lexicalForm
                  datatype = NMTOKEN.datatype }

            static member typedLiteral(lexicalForm: System.String) : TypedLiteral =
                NMTOKEN.staticTypedLiteral lexicalForm |> StaticTypedLiteral.toTypedLiteral

    let anyURI: Datatype<Measure.anyURI> = Measure.anyURI.datatype
    let base64Binary: Datatype<Measure.base64Binary> = Measure.base64Binary.datatype
    let boolean: Datatype<Measure.boolean> = Measure.boolean.datatype
    let date: Datatype<Measure.date> = Measure.date.datatype
    let dateTime: Datatype<Measure.dateTime> = Measure.dateTime.datatype
    let dateTimeStamp: Datatype<Measure.dateTimeStamp> = Measure.dateTimeStamp.datatype
    let decimal: Datatype<Measure.decimal> = Measure.decimal.datatype
    let integer: Datatype<Measure.integer> = Measure.integer.datatype
    let long: Datatype<Measure.long> = Measure.long.datatype
    let int: Datatype<Measure.int> = Measure.int.datatype
    let short: Datatype<Measure.short> = Measure.short.datatype
    let byte: Datatype<Measure.byte> = Measure.byte.datatype

    let nonNegativeInteger: Datatype<Measure.nonNegativeInteger> =
        Measure.nonNegativeInteger.datatype

    let positiveInteger: Datatype<Measure.positiveInteger> =
        Measure.positiveInteger.datatype

    let unsignedLong: Datatype<Measure.unsignedLong> = Measure.unsignedLong.datatype
    let unsignedInt: Datatype<Measure.unsignedInt> = Measure.unsignedInt.datatype
    let unsignedShort: Datatype<Measure.unsignedShort> = Measure.unsignedShort.datatype
    let unsignedByte: Datatype<Measure.unsignedByte> = Measure.unsignedByte.datatype

    let nonPositiveInteger: Datatype<Measure.nonPositiveInteger> =
        Measure.nonPositiveInteger.datatype

    let negativeInteger: Datatype<Measure.negativeInteger> =
        Measure.negativeInteger.datatype

    let double: Datatype<Measure.double> = Measure.double.datatype
    let duration: Datatype<Measure.duration> = Measure.duration.datatype

    let dayTimeDuration: Datatype<Measure.dayTimeDuration> =
        Measure.dayTimeDuration.datatype

    let yearMonthDuration: Datatype<Measure.yearMonthDuration> =
        Measure.yearMonthDuration.datatype

    let float: Datatype<Measure.float> = Measure.float.datatype
    let gDay: Datatype<Measure.gDay> = Measure.gDay.datatype
    let gMonth: Datatype<Measure.gMonth> = Measure.gMonth.datatype
    let gMonthDay: Datatype<Measure.gMonthDay> = Measure.gMonthDay.datatype
    let gYear: Datatype<Measure.gYear> = Measure.gYear.datatype
    let gYearMonth: Datatype<Measure.gYearMonth> = Measure.gYearMonth.datatype
    let hexBinary: Datatype<Measure.hexBinary> = Measure.hexBinary.datatype
    let string: Datatype<Measure.string> = Measure.string.datatype

    let normalizedString: Datatype<Measure.normalizedString> =
        Measure.normalizedString.datatype

    let token: Datatype<Measure.token> = Measure.token.datatype
    let language: Datatype<Measure.language> = Measure.language.datatype
    let Name: Datatype<Measure.Name> = Measure.Name.datatype
    let NCName: Datatype<Measure.NCName> = Measure.NCName.datatype
    let NMTOKEN: Datatype<Measure.NMTOKEN> = Measure.NMTOKEN.datatype
    let time: Datatype<Measure.time> = Measure.time.datatype
    let enumeration = _namespace.curie "enumeration" |> FacetIri
    let fractionDigits = _namespace.curie "fractionDigits" |> FacetIri
    let length = _namespace.curie "length" |> FacetIri
    let maxExclusive = _namespace.curie "maxExclusive" |> FacetIri
    let maxInclusive = _namespace.curie "maxInclusive" |> FacetIri
    let maxLength = _namespace.curie "maxLength" |> FacetIri
    let minExclusive = _namespace.curie "minExclusive" |> FacetIri
    let minInclusive = _namespace.curie "minInclusive" |> FacetIri
    let minLength = _namespace.curie "minLength" |> FacetIri
    let pattern = _namespace.curie "pattern" |> FacetIri
    let totalDigits = _namespace.curie "totalDigits" |> FacetIri
    let whiteSpace = _namespace.curie "whiteSpace" |> FacetIri
    // https://www.w3.org/TR/rdf12-concepts/#xsd-datatypes
    let QName = _namespace.curie "QName"
    let ENTITY = _namespace.curie "ENTITY"
    let ID = _namespace.curie "ID"
    let IDREF = _namespace.curie "IDREF"
    let NOTATION = _namespace.curie "NOTATION"
    let IDREFS = _namespace.curie "IDREFS"
    let ENTITIES = _namespace.curie "ENTITIES"
    let NMTOKENS = _namespace.curie "NMTOKENS"
    let anyType = _namespace.curie "anyType"
    let anySimpleType = _namespace.curie "anySimpleType"
    let anyAtomicType = _namespace.curie "anyAtomicType"
    let element = _namespace.curie "element"
    let attribute = _namespace.curie "attribute"
    let notation = _namespace.curie "notation"
    let schema = _namespace.curie "schema"
    let group = _namespace.curie "group"
    let simpleType = _namespace.curie "simpleType"
    let attributeGroup = _namespace.curie "attributeGroup"
    let anyAttribute = _namespace.curie "anyAttribute"
    let assert_ = _namespace.curie "assert"
    let complexContent = _namespace.curie "complexContent"
    let restriction = _namespace.curie "restriction"
    let extension = _namespace.curie "extension"
    let openContent = _namespace.curie "openContent"
    let any = _namespace.curie "any"
    let defaultOpenContent = _namespace.curie "defaultOpenContent"
    let simpleContent = _namespace.curie "simpleContent"
    let complexType = _namespace.curie "complexType"
    let alternative = _namespace.curie "alternative"
    let all = _namespace.curie "all"
    let choice = _namespace.curie "choice"
    let sequence = _namespace.curie "sequence"
    let include_ = _namespace.curie "include"
    let redefine = _namespace.curie "redefine"
    let override_ = _namespace.curie "override"
    let import = _namespace.curie "import"
    let selector = _namespace.curie "selector"
    let field = _namespace.curie "field"
    let unique = _namespace.curie "unique"
    let key = _namespace.curie "key"
    let keyref = _namespace.curie "keyref"
    let appinfo = _namespace.curie "appinfo"
    let documentation = _namespace.curie "documentation"
    let annotation = _namespace.curie "annotation"
    let facet = _namespace.curie "facet"
    let list = _namespace.curie "list"
    let union = _namespace.curie "union"
    let assertion = _namespace.curie "assertion"
    let explicitTimezone = _namespace.curie "explicitTimezone"

module rdf =
    let _namespace = RdfVocabulary.rdf

    module Measure =
        /// https://www.w3.org/TR/rdf-plain-literal-1/
        [<Measure>]
        type langString =
            static member literal(value: string) : string<langString> = UMX.tag value

            /// https://www.w3.org/TR/rdf-plain-literal-1/
            static member Datatype: Datatype<langString> =
                { _datatypeIri = _namespace.curie "langString" |> DatatypeIri }

        [<Measure>]
        type dirLangString =
            static member literal(value: string) : string<dirLangString> = UMX.tag value

            /// https://www.w3.org/TR/rdf-plain-literal-1/
            static member Datatype: Datatype<dirLangString> =
                { _datatypeIri = _namespace.curie "dirLangString" |> DatatypeIri }

        [<Measure>]
        type PlainLiteral =
            static member literal(value: string) : string<PlainLiteral> = UMX.tag value

            /// https://www.w3.org/TR/rdf-plain-literal-1/
            static member Datatype: Datatype<PlainLiteral> =
                { _datatypeIri = _namespace.curie "PlainLiteral" |> DatatypeIri }

        [<Measure>]
        type HTML =
            static member literal(value: string) : string<HTML> = UMX.tag value

            static member Datatype: Datatype<HTML> =
                { _datatypeIri = _namespace.curie "HTML" |> DatatypeIri }

        [<Measure>]
        type JSON =
            static member literal(value: string) : string<JSON> = UMX.tag value

            static member Datatype: Datatype<JSON> =
                { _datatypeIri = _namespace.curie "JSON" |> DatatypeIri }

        [<Measure>]
        type XMLLiteral =
            static member literal(value: string) : string<XMLLiteral> = UMX.tag value

            static member Datatype: Datatype<XMLLiteral> =
                { _datatypeIri = _namespace.curie "XMLLiteral" |> DatatypeIri }

    let langString = Measure.langString.Datatype
    let dirLangString = Measure.dirLangString.Datatype
    let PlainLiteral = Measure.PlainLiteral.Datatype
    let XMLLiteral = Measure.XMLLiteral.Datatype
    let HTML = Measure.HTML.Datatype
    let JSON = Measure.JSON.Datatype
    let Alt = _namespace.curie "Alt"
    let Bag = _namespace.curie "Bag"
    let CompoundLiteral = _namespace.curie "CompoundLiteral"
    let direction = _namespace.curie "direction"
    let first = _namespace.curie "first"
    let language = _namespace.curie "language"
    let List = _namespace.curie "List"
    let nil = _namespace.curie "nil"
    let object = _namespace.curie "object"
    /// https://www.w3.org/TR/rdf-plain-literal-1/
    let predicate = _namespace.curie "predicate"
    let Property = _namespace.curie "Property"
    let rest = _namespace.curie "rest"
    let Seq = _namespace.curie "Seq"
    let Statement = _namespace.curie "Statement"
    let subject = _namespace.curie "subject"
    let type_ = _namespace.curie "type"
    let value = _namespace.curie "value"
    let langRange = _namespace.curie "langRange" |> FacetIri
    // https://w3c.github.io/rdf-interop/spec/#section-basicenc-definition
    let PropositionForm = _namespace.curie "PropositionForm"
    let propositionFormSubject = _namespace.curie "propositionFormSubject"
    let propositionFormPredicate = _namespace.curie "propositionFormPredicate"
    let propositionFormObject = _namespace.curie "propositionFormObject"
    // https://www.w3.org/TR/rdf12-xml/#coreSyntaxTerms
    let RDF = _namespace.curie "RDF"
    let ID = _namespace.curie "ID"
    let about = _namespace.curie "about"
    let parseType = _namespace.curie "parseType"
    let resource = _namespace.curie "resource"
    let nodeID = _namespace.curie "nodeID"
    let datatype = _namespace.curie "datatype"
    let Description = _namespace.curie "Description"
    // TODO consider conversion to rdf_\d index behavior
    let li = _namespace.curie "li"

// https://www.w3.org/TR/rdf12-xml/#section-Bag-Expand
// let aboutEach = _namespace.curie "aboutEach"
// let aboutEachPrefix = _namespace.curie "aboutEachPrefix"
// let bagID = _namespace.curie "bagID"
/// https://www.w3.org/TR/rdf12-schema/#ch_vocabulary
module rdfs =
    let _namespace = RdfVocabulary.rdfs
    (*
    module Measure =
        [<Measure>]
        type Literal =
            static member literal(value: string) : string<Literal> = UMX.tag value

            static member Datatype: Datatype<Literal> =
                { _datatypeIri = _namespace.curie "Literal" |> DatatypeIri }

    let Literal = Measure.Literal.Datatype
*)
    let Literal = _namespace.curie "Literal"
    let Class = _namespace.curie "Class"
    let comment = _namespace.curie "comment"
    let Container = _namespace.curie "Container"
    let ContainerMembershipProperty = _namespace.curie "ContainerMembershipProperty"
    let Datatype = _namespace.curie "Datatype"
    let domain = _namespace.curie "domain"
    let isDefinedBy = _namespace.curie "isDefinedBy"
    let label = _namespace.curie "label"
    let member_ = _namespace.curie "member"
    let range = _namespace.curie "range"
    let Resource = _namespace.curie "Resource"
    let seeAlso = _namespace.curie "seeAlso"
    let subClassOf = _namespace.curie "subClassOf"
    let subPropertyOf = _namespace.curie "subPropertyOf"

module xhtml =
    let _namespace = RdfVocabulary.xhtml

    module Measure =
        [<Measure>]
        type Length =
            static member literal(value: string) : string<Length> = UMX.tag value

            static member Datatype: Datatype<Length> =
                { _datatypeIri = _namespace.curie "Length" |> DatatypeIri }

        [<Measure>]
        type LinkTypes =
            static member literal(value: string) : string<LinkTypes> = UMX.tag value

            static member Datatype: Datatype<LinkTypes> =
                { _datatypeIri = _namespace.curie "LinkTypes" |> DatatypeIri }

        [<Measure>]
        type MediaDesc =
            static member literal(value: string) : string<MediaDesc> = UMX.tag value

            static member Datatype: Datatype<MediaDesc> =
                { _datatypeIri = _namespace.curie "MediaDesc" |> DatatypeIri }

        [<Measure>]
        type MultiLength =
            static member literal(value: string) : string<MultiLength> = UMX.tag value

            static member Datatype: Datatype<MultiLength> =
                { _datatypeIri = _namespace.curie "MultiLength" |> DatatypeIri }

        [<Measure>]
        type Number =
            static member literal(value: string) : string<Number> = UMX.tag value

            static member Datatype: Datatype<Number> =
                { _datatypeIri = _namespace.curie "Number" |> DatatypeIri }

        [<Measure>]
        type Pixels =
            static member literal(value: string) : string<Pixels> = UMX.tag value

            static member Datatype: Datatype<Pixels> =
                { _datatypeIri = _namespace.curie "Pixels" |> DatatypeIri }

        [<Measure>]
        type Script =
            static member literal(value: string) : string<Script> = UMX.tag value

            static member Datatype: Datatype<Script> =
                { _datatypeIri = _namespace.curie "Script" |> DatatypeIri }

        [<Measure>]
        type Color =
            static member literal(value: string) : string<Color> = UMX.tag value

            static member Datatype: Datatype<Color> =
                { _datatypeIri = _namespace.curie "Color" |> DatatypeIri }

        [<Measure>]
        type Text =
            static member literal(value: string) : string<Text> = UMX.tag value

            static member Datatype: Datatype<Text> =
                { _datatypeIri = _namespace.curie "Text" |> DatatypeIri }

        [<Measure>]
        type Character =
            static member literal(value: string) : string<Character> = UMX.tag value

            static member Datatype: Datatype<Character> =
                { _datatypeIri = _namespace.curie "Character" |> DatatypeIri }

        [<Measure>]
        type Charset =
            static member literal(value: string) : string<Charset> = UMX.tag value

            static member Datatype: Datatype<Charset> =
                { _datatypeIri = _namespace.curie "Charset" |> DatatypeIri }

        [<Measure>]
        type Charsets =
            static member literal(value: string) : string<Charsets> = UMX.tag value

            static member Datatype: Datatype<Charsets> =
                { _datatypeIri = _namespace.curie "Charsets" |> DatatypeIri }

        [<Measure>]
        type ContentType =
            static member literal(value: string) : string<ContentType> = UMX.tag value

            static member Datatype: Datatype<ContentType> =
                { _datatypeIri = _namespace.curie "ContentType" |> DatatypeIri }

        [<Measure>]
        type ContentTypes =
            static member literal(value: string) : string<ContentTypes> = UMX.tag value

            static member Datatype: Datatype<ContentTypes> =
                { _datatypeIri = _namespace.curie "ContentTypes" |> DatatypeIri }

        [<Measure>]
        type Datetime =
            static member literal(value: string) : string<Datetime> = UMX.tag value

            static member Datatype: Datatype<Datetime> =
                { _datatypeIri = _namespace.curie "Datetime" |> DatatypeIri }

        [<Measure>]
        type FPI =
            static member literal(value: string) : string<FPI> = UMX.tag value

            static member Datatype: Datatype<FPI> =
                { _datatypeIri = _namespace.curie "FPI" |> DatatypeIri }

        [<Measure>]
        type FrameTarget =
            static member literal(value: string) : string<FrameTarget> = UMX.tag value

            static member Datatype: Datatype<FrameTarget> =
                { _datatypeIri = _namespace.curie "FrameTarget" |> DatatypeIri }

        [<Measure>]
        type LanguageCode =
            static member literal(value: string) : string<LanguageCode> = UMX.tag value

            static member Datatype: Datatype<LanguageCode> =
                { _datatypeIri = _namespace.curie "LanguageCode" |> DatatypeIri }

        [<Measure>]
        type LanguageCodes =
            static member literal(value: string) : string<LanguageCodes> = UMX.tag value

            static member Datatype: Datatype<LanguageCodes> =
                { _datatypeIri = _namespace.curie "LanguageCodes" |> DatatypeIri }

        [<Measure>]
        type URI =
            static member literal(value: string) : string<URI> = UMX.tag value

            static member Datatype: Datatype<URI> =
                { _datatypeIri = _namespace.curie "URI" |> DatatypeIri }

        [<Measure>]
        type URIs =
            static member literal(value: string) : string<URIs> = UMX.tag value

            static member Datatype: Datatype<URIs> =
                { _datatypeIri = _namespace.curie "URIs" |> DatatypeIri }

        [<Measure>]
        type URIREF =
            static member literal(value: string) : string<URIREF> = UMX.tag value

            static member Datatype: Datatype<URIREF> =
                { _datatypeIri = _namespace.curie "URIREF" |> DatatypeIri }

        [<Measure>]
        type MultiLengths =
            static member literal(value: string) : string<MultiLengths> = UMX.tag value

            static member Datatype: Datatype<MultiLengths> =
                { _datatypeIri = _namespace.curie "MultiLengths" |> DatatypeIri }

        [<Measure>]
        type CDATA =
            static member literal(value: string) : string<CDATA> = UMX.tag value

            static member Datatype: Datatype<CDATA> =
                { _datatypeIri = _namespace.curie "CDATA" |> DatatypeIri }

        [<Measure>]
        type CURIE =
            static member literal(value: string) : string<CURIE> = UMX.tag value

            static member Datatype: Datatype<CURIE> =
                { _datatypeIri = _namespace.curie "CURIE" |> DatatypeIri }

        [<Measure>]
        type CURIEs =
            static member literal(value: string) : string<CURIEs> = UMX.tag value

            static member Datatype: Datatype<CURIEs> =
                { _datatypeIri = _namespace.curie "CURIEs" |> DatatypeIri }

        [<Measure>]
        type SafeCURIE =
            static member literal(value: string) : string<SafeCURIE> = UMX.tag value

            static member Datatype: Datatype<SafeCURIE> =
                { _datatypeIri = _namespace.curie "SafeCURIE" |> DatatypeIri }

        [<Measure>]
        type SafeCURIEs =
            static member literal(value: string) : string<SafeCURIEs> = UMX.tag value

            static member Datatype: Datatype<SafeCURIEs> =
                { _datatypeIri = _namespace.curie "SafeCURIEs" |> DatatypeIri }

        [<Measure>]
        type URIorSafeCURIE =
            static member literal(value: string) : string<URIorSafeCURIE> = UMX.tag value

            static member Datatype: Datatype<URIorSafeCURIE> =
                { _datatypeIri = _namespace.curie "URIorSafeCURIE" |> DatatypeIri }

        [<Measure>]
        type URIorSafeCURIEs =
            static member literal(value: string) : string<URIorSafeCURIEs> = UMX.tag value

            static member Datatype: Datatype<URIorSafeCURIEs> =
                { _datatypeIri = _namespace.curie "URIorSafeCURIEs" |> DatatypeIri }

        [<Measure>]
        type PREFIX =
            static member literal(value: string) : string<PREFIX> = UMX.tag value

            static member Datatype: Datatype<PREFIX> =
                { _datatypeIri = _namespace.curie "PREFIX" |> DatatypeIri }

        [<Measure>]
        type PREFIXes =
            static member literal(value: string) : string<PREFIXes> = UMX.tag value

            static member Datatype: Datatype<PREFIXes> =
                { _datatypeIri = _namespace.curie "PREFIXes" |> DatatypeIri }

        [<Measure>]
        type TERM =
            static member literal(value: string) : string<TERM> = UMX.tag value

            static member Datatype: Datatype<TERM> =
                { _datatypeIri = _namespace.curie "TERM" |> DatatypeIri }

        [<Measure>]
        type CURIEorIri =
            static member literal(value: string) : string<CURIEorIri> = UMX.tag value

            static member Datatype: Datatype<CURIEorIri> =
                { _datatypeIri = _namespace.curie "CURIEorIri" |> DatatypeIri }

        [<Measure>]
        type CURIEorIris =
            static member literal(value: string) : string<CURIEorIris> = UMX.tag value

            static member Datatype: Datatype<CURIEorIris> =
                { _datatypeIri = _namespace.curie "CURIEorIris" |> DatatypeIri }

        [<Measure>]
        type SafeCURIEorCURIEorIri =
            static member literal(value: string) : string<SafeCURIEorCURIEorIri> = UMX.tag value

            static member Datatype: Datatype<SafeCURIEorCURIEorIri> =
                { _datatypeIri = _namespace.curie "SafeCURIEorCURIEorIri" |> DatatypeIri }

        [<Measure>]
        type SafeCURIEorCURIEorIris =
            static member literal(value: string) : string<SafeCURIEorCURIEorIris> = UMX.tag value

            static member Datatype: Datatype<SafeCURIEorCURIEorIris> =
                { _datatypeIri = _namespace.curie "SafeCURIEorCURIEorIris" |> DatatypeIri }

        [<Measure>]
        type AbsIri =
            static member literal(value: string) : string<AbsIri> = UMX.tag value

            static member Datatype: Datatype<AbsIri> =
                { _datatypeIri = _namespace.curie "AbsIri" |> DatatypeIri }

        [<Measure>]
        type TERMorCURIEorAbsIri =
            static member literal(value: string) : string<TERMorCURIEorAbsIri> = UMX.tag value

            static member Datatype: Datatype<TERMorCURIEorAbsIri> =
                { _datatypeIri = _namespace.curie "TERMorCURIEorAbsIri" |> DatatypeIri }

        [<Measure>]
        type TERMorCURIEorAbsIris =
            static member literal(value: string) : string<TERMorCURIEorAbsIris> = UMX.tag value

            static member Datatype: Datatype<TERMorCURIEorAbsIris> =
                { _datatypeIri = _namespace.curie "TERMorCURIEorAbsIris" |> DatatypeIri }

    let Length = Measure.Length.Datatype
    let LinkTypes = Measure.LinkTypes.Datatype
    let MediaDesc = Measure.MediaDesc.Datatype
    let MultiLength = Measure.MultiLength.Datatype
    let Number = Measure.Number.Datatype
    let Pixels = Measure.Pixels.Datatype
    let Script = Measure.Script.Datatype
    let Color = Measure.Color.Datatype
    let Text = Measure.Text.Datatype
    let Character = Measure.Character.Datatype
    let Charset = Measure.Charset.Datatype
    let Charsets = Measure.Charsets.Datatype
    let ContentType = Measure.ContentType.Datatype
    let ContentTypes = Measure.ContentTypes.Datatype
    let Datetime = Measure.Datetime.Datatype
    let FPI = Measure.FPI.Datatype
    let FrameTarget = Measure.FrameTarget.Datatype
    let LanguageCode = Measure.LanguageCode.Datatype
    let LanguageCodes = Measure.LanguageCodes.Datatype
    let URI = Measure.URI.Datatype
    let URIs = Measure.URIs.Datatype
    let URIREF = Measure.URIREF.Datatype
    let MultiLengths = Measure.MultiLengths.Datatype
    let CDATA = Measure.CDATA.Datatype
    let CURIE = Measure.CURIE.Datatype
    let CURIEs = Measure.CURIEs.Datatype
    let SafeCURIE = Measure.SafeCURIE.Datatype
    let SafeCURIEs = Measure.SafeCURIEs.Datatype
    let URIorSafeCURIE = Measure.URIorSafeCURIE.Datatype
    let URIorSafeCURIEs = Measure.URIorSafeCURIEs.Datatype
    let PREFIX = Measure.PREFIX.Datatype
    let PREFIXes = Measure.PREFIXes.Datatype
    let TERM = Measure.TERM.Datatype
    let CURIEorIri = Measure.CURIEorIri.Datatype
    let CURIEorIris = Measure.CURIEorIris.Datatype
    let SafeCURIEorCURIEorIri = Measure.SafeCURIEorCURIEorIri.Datatype
    let SafeCURIEorCURIEorIris = Measure.SafeCURIEorCURIEorIris.Datatype
    let AbsIri = Measure.AbsIri.Datatype
    let TERMorCURIEorAbsIri = Measure.TERMorCURIEorAbsIri.Datatype
    let TERMorCURIEorAbsIris = Measure.TERMorCURIEorAbsIris.Datatype

module rdfa =
    let _namespace = RdfVocabulary.rdfa

    open LitXml
    open FSharp.ViewEngine
    open type Html
    open BrowserApi.Css.Authoring

    type Attribute =
        private
        | RDFa of string

        member this.localName =
            let (RDFa localName) = this
            localName

        member this.Xml = attr this.localName

        member this.Html = _attr this.localName

        member this.css = AttrSelector this.localName

    let about = RDFa "about"
    let content = RDFa "content"
    let datatype = RDFa "datatype"
    let href = RDFa "href"
    let inlist = RDFa "inlist"
    let prefix = RDFa "prefix"
    let property = RDFa "property"
    let rel = RDFa "rel"
    let resource = RDFa "resource"
    let rev = RDFa "rev"
    let src = RDFa "src"
    let typeof_ = RDFa "typeof"
    let vocab = RDFa "vocab"
    let context = _namespace.curie "context"
    let copy = _namespace.curie "copy"
    let DocumentError = _namespace.curie "DocumentError"
    let Error = _namespace.curie "Error"
    let Info = _namespace.curie "Info"
    let Pattern = _namespace.curie "Pattern"
    let PGClass = _namespace.curie "PGClass"
    let PrefixMapping = _namespace.curie "PrefixMapping"
    let PrefixOrTermMapping = _namespace.curie "PrefixOrTermMapping"
    let PrefixRedefinition = _namespace.curie "PrefixRedefinition"
    let term = _namespace.curie "term"
    let TermMapping = _namespace.curie "TermMapping"
    let UnresolvedCURIE = _namespace.curie "UnresolvedCURIE"
    let UnresolvedTerm = _namespace.curie "UnresolvedTerm"
    let uri = _namespace.curie "uri"
    let usesVocabulary = _namespace.curie "usesVocabulary"
    let VocabReferenceError = _namespace.curie "VocabReferenceError"
    let vocabulary = _namespace.curie "vocabulary"
    let Warning = _namespace.curie "Warning"

module spdx =
    let _namespace = RdfVocabulary.spdx

    module Measure =
        [<Measure>]
        type MediaType =

            static member canonicalMapping(value: Iana.InternetMediaType) : System.String = value.contentType

            static member lexicalForm(literal: string<MediaType>) : System.String = UMX.untag literal

            static member literal(lexicalForm: System.String) : string<MediaType> = UMX.tag lexicalForm

            static member literal(value: Iana.InternetMediaType) : string<MediaType> =
                MediaType.canonicalMapping value |> MediaType.literal

            static member value(literal: string<MediaType>) : Iana.InternetMediaType =
                let raw = MediaType.lexicalForm literal
                let value = Iana.InternetMediaType.ofContentType raw
                value

            static member datatype: Datatype<MediaType> =
                { _datatypeIri = _namespace.curie "MediaType" |> DatatypeIri }

            static member staticTypedLiteral(value: Iana.InternetMediaType) : StaticTypedLiteral<MediaType> =
                { literal = MediaType.literal value
                  datatype = MediaType.datatype }

            static member typedLiteral(value: Iana.InternetMediaType) : TypedLiteral =
                MediaType.staticTypedLiteral value |> StaticTypedLiteral.toTypedLiteral

    let MediaType = Measure.MediaType.datatype

module owl =
    let _namespace = RdfVocabulary.owl

    module Measure =
        [<Measure>]
        type rational =
            static member literal(value: string) : string<rational> = UMX.tag value

            static member Datatype: Datatype<rational> =
                { _datatypeIri = _namespace.curie "rational" |> DatatypeIri }

        [<Measure>]
        type real =
            static member literal(value: string) : string<real> = UMX.tag value

            static member Datatype: Datatype<real> =
                { _datatypeIri = _namespace.curie "real" |> DatatypeIri }

    let rational = Measure.rational.Datatype
    let real = Measure.real.Datatype
    let AllDifferent = _namespace.curie "AllDifferent"
    let AllDisjointClasses = _namespace.curie "AllDisjointClasses"
    let AllDisjointProperties = _namespace.curie "AllDisjointProperties"
    let allValuesFrom = _namespace.curie "allValuesFrom"
    let annotatedProperty = _namespace.curie "annotatedProperty"
    let annotatedSource = _namespace.curie "annotatedSource"
    let annotatedTarget = _namespace.curie "annotatedTarget"
    let Annotation = _namespace.curie "Annotation"
    let AnnotationProperty = _namespace.curie "AnnotationProperty"
    let assertionProperty = _namespace.curie "assertionProperty"
    let AsymmetricProperty = _namespace.curie "AsymmetricProperty"
    let Axiom = _namespace.curie "Axiom"
    let backwardCompatibleWith = _namespace.curie "backwardCompatibleWith"
    let bottomDataProperty = _namespace.curie "bottomDataProperty"
    let bottomObjectProperty = _namespace.curie "bottomObjectProperty"
    let cardinality = _namespace.curie "cardinality"
    let Class = _namespace.curie "Class"
    let complementOf = _namespace.curie "complementOf"
    let DataRange = _namespace.curie "DataRange"
    let datatypeComplementOf = _namespace.curie "datatypeComplementOf"
    let DatatypeProperty = _namespace.curie "DatatypeProperty"
    let deprecated = _namespace.curie "deprecated"
    let DeprecatedClass = _namespace.curie "DeprecatedClass"
    let DeprecatedProperty = _namespace.curie "DeprecatedProperty"
    let differentFrom = _namespace.curie "differentFrom"
    let disjointUnionOf = _namespace.curie "disjointUnionOf"
    let disjointWith = _namespace.curie "disjointWith"
    let distinctMembers = _namespace.curie "distinctMembers"
    let equivalentClass = _namespace.curie "equivalentClass"
    let equivalentProperty = _namespace.curie "equivalentProperty"
    let FunctionalProperty = _namespace.curie "FunctionalProperty"
    let hasKey = _namespace.curie "hasKey"
    let hasSelf = _namespace.curie "hasSelf"
    let hasValue = _namespace.curie "hasValue"
    let imports = _namespace.curie "imports"
    let incompatibleWith = _namespace.curie "incompatibleWith"
    let intersectionOf = _namespace.curie "intersectionOf"
    let InverseFunctionalProperty = _namespace.curie "InverseFunctionalProperty"
    let inverseOf = _namespace.curie "inverseOf"
    let IrreflexiveProperty = _namespace.curie "IrreflexiveProperty"
    let maxCardinality = _namespace.curie "maxCardinality"
    let maxQualifiedCardinality = _namespace.curie "maxQualifiedCardinality"
    let members = _namespace.curie "members"
    let minCardinality = _namespace.curie "minCardinality"
    let minQualifiedCardinality = _namespace.curie "minQualifiedCardinality"
    let NamedIndividual = _namespace.curie "NamedIndividual"
    let NegativePropertyAssertion = _namespace.curie "NegativePropertyAssertion"
    let Nothing = _namespace.curie "Nothing"
    let ObjectProperty = _namespace.curie "ObjectProperty"
    let onClass = _namespace.curie "onClass"
    let onDataRange = _namespace.curie "onDataRange"
    let onDatatype = _namespace.curie "onDatatype"
    let oneOf = _namespace.curie "oneOf"
    let onProperties = _namespace.curie "onProperties"
    let onProperty = _namespace.curie "onProperty"
    let Ontology = _namespace.curie "Ontology"
    let OntologyProperty = _namespace.curie "OntologyProperty"
    let priorVersion = _namespace.curie "priorVersion"
    let propertyChainAxiom = _namespace.curie "propertyChainAxiom"
    let propertyDisjointWith = _namespace.curie "propertyDisjointWith"
    let qualifiedCardinality = _namespace.curie "qualifiedCardinality"
    let ReflexiveProperty = _namespace.curie "ReflexiveProperty"
    let Restriction = _namespace.curie "Restriction"
    let sameAs = _namespace.curie "sameAs"
    let someValuesFrom = _namespace.curie "someValuesFrom"
    let sourceIndividual = _namespace.curie "sourceIndividual"
    let SymmetricProperty = _namespace.curie "SymmetricProperty"
    let targetIndividual = _namespace.curie "targetIndividual"
    let targetValue = _namespace.curie "targetValue"
    let Thing = _namespace.curie "Thing"
    let topDataProperty = _namespace.curie "topDataProperty"
    let topObjectProperty = _namespace.curie "topObjectProperty"
    let TransitiveProperty = _namespace.curie "TransitiveProperty"
    let unionOf = _namespace.curie "unionOf"
    let versionInfo = _namespace.curie "versionInfo"
    let versionIri = _namespace.curie "versionIri"
    let withRestrictions = _namespace.curie "withRestrictions"

    module xml =
        open LitXml

        let owlElem (localName: string) =
            xml.elemNS RdfVocabulary.owl.namespaceIri.identity localName

        let Prefix = owlElem "Prefix"
        let Import = owlElem "Import"
        let Ontology = owlElem "Ontology"
        let Class = owlElem "Class"
        let Datatype = owlElem "Datatype"
        let ObjectProperty = owlElem "ObjectProperty"
        let DataProperty = owlElem "DataProperty"
        let AnnotationProperty = owlElem "AnnotationProperty"
        let NamedIndividual = owlElem "NamedIndividual"
        let AnonymousIndividual = owlElem "AnonymousIndividual"
        let Literal = owlElem "Literal"
        let Declaration = owlElem "Declaration"
        let ObjectInverseOf = owlElem "ObjectInverseOf"
        let DataIntersectionOf = owlElem "DataIntersectionOf"
        let DataUnionOf = owlElem "DataUnionOf"
        let DataComplementOf = owlElem "DataComplementOf"
        let DataOneOf = owlElem "DataOneOf"
        let FacetRestriction = owlElem "FacetRestriction"
        let DatatypeRestriction = owlElem "DatatypeRestriction"
        let ObjectIntersectionOf = owlElem "ObjectIntersectionOf"
        let ObjectUnionOf = owlElem "ObjectUnionOf"
        let ObjectComplementOf = owlElem "ObjectComplementOf"
        let ObjectOneOf = owlElem "ObjectOneOf"
        let ObjectSomeValuesFrom = owlElem "ObjectSomeValuesFrom"
        let ObjectAllValuesFrom = owlElem "ObjectAllValuesFrom"
        let ObjectHasValue = owlElem "ObjectHasValue"
        let ObjectHasSelf = owlElem "ObjectHasSelf"
        let ObjectMinCardinality = owlElem "ObjectMinCardinality"
        let ObjectMaxCardinality = owlElem "ObjectMaxCardinality"
        let ObjectExactCardinality = owlElem "ObjectExactCardinality"
        let DataSomeValuesFrom = owlElem "DataSomeValuesFrom"
        let DataAllValuesFrom = owlElem "DataAllValuesFrom"
        let DataHasValue = owlElem "DataHasValue"
        let DataMinCardinality = owlElem "DataMinCardinality"
        let DataMaxCardinality = owlElem "DataMaxCardinality"
        let DataExactCardinality = owlElem "DataExactCardinality"
        let SubClassOf = owlElem "SubClassOf"
        let EquivalentClasses = owlElem "EquivalentClasses"
        let DisjointClasses = owlElem "DisjointClasses"
        let DisjointUnion = owlElem "DisjointUnion"
        let ObjectPropertyChain = owlElem "ObjectPropertyChain"
        let SubObjectPropertyOf = owlElem "SubObjectPropertyOf"
        let EquivalentObjectProperties = owlElem "EquivalentObjectProperties"
        let DisjointObjectProperties = owlElem "DisjointObjectProperties"
        let ObjectPropertyDomain = owlElem "ObjectPropertyDomain"
        let ObjectPropertyRange = owlElem "ObjectPropertyRange"
        let InverseObjectProperties = owlElem "InverseObjectProperties"
        let FunctionalObjectProperty = owlElem "FunctionalObjectProperty"
        let InverseFunctionalObjectProperty = owlElem "InverseFunctionalObjectProperty"
        let ReflexiveObjectProperty = owlElem "ReflexiveObjectProperty"
        let IrreflexiveObjectProperty = owlElem "IrreflexiveObjectProperty"
        let SymmetricObjectProperty = owlElem "SymmetricObjectProperty"
        let AsymmetricObjectProperty = owlElem "AsymmetricObjectProperty"
        let TransitiveObjectProperty = owlElem "TransitiveObjectProperty"
        let SubDataPropertyOf = owlElem "SubDataPropertyOf"
        let EquivalentDataProperties = owlElem "EquivalentDataProperties"
        let DisjointDataProperties = owlElem "DisjointDataProperties"
        let DataPropertyDomain = owlElem "DataPropertyDomain"
        let DataPropertyRange = owlElem "DataPropertyRange"
        let FunctionalDataProperty = owlElem "FunctionalDataProperty"
        let DatatypeDefinition = owlElem "DatatypeDefinition"
        let HasKey = owlElem "HasKey"
        let SameIndividual = owlElem "SameIndividual"
        let DifferentIndividuals = owlElem "DifferentIndividuals"
        let ClassAssertion = owlElem "ClassAssertion"
        let ObjectPropertyAssertion = owlElem "ObjectPropertyAssertion"
        let NegativeObjectPropertyAssertion = owlElem "NegativeObjectPropertyAssertion"
        let DataPropertyAssertion = owlElem "DataPropertyAssertion"
        let NegativeDataPropertyAssertion = owlElem "NegativeDataPropertyAssertion"
        let IRI = owlElem "IRI"
        let AbbreviatedIRI = owlElem "AbbreviatedIRI"
        let Annotation = owlElem "Annotation"
        let AnnotationAssertion = owlElem "AnnotationAssertion"
        let SubAnnotationPropertyOf = owlElem "SubAnnotationPropertyOf"
        let AnnotationPropertyDomain = owlElem "AnnotationPropertyDomain"
        let AnnotationPropertyRange = owlElem "AnnotationPropertyRange"
        let _name (value: 'Value) = attr "name" value
        let _IRI (value: 'Value) = attr "IRI" value
        let _ontologyIRI (value: 'Value) = attr "ontologyIRI" value
        let _versionIRI (value: 'Value) = attr "versionIRI" value
        let _abbreviatedIRI (value: 'Value) = attr "abbreviatedIRI" value
        let _nodeID (value: 'Value) = attr "nodeID" value
        let _datatypeIRI (value: 'Value) = attr "datatypeIRI" value
        let _facet (value: 'Value) = attr "facet" value
        let _cardinality (value: 'Value) = attr "cardinality" value

module Owl =
    open owl
    open LitXml

    type Xml =

        // ----------------------------------------
        // Atomic entities
        // ----------------------------------------

        static member Class(class_: Class) = xml.Class { xml._IRI class_.identity }

        static member NamedIndividual(namedIndividual: NamedIndividual) =
            xml.NamedIndividual { xml._IRI namedIndividual.identity }

        static member AnonymousIndividual(anonymousIndividual: AnonymousIndividual) =
            xml.AnonymousIndividual { xml._nodeID anonymousIndividual.identity }

        static member Individual(individual: Individual) =
            match individual with
            | Individual namedIndividual -> Xml.NamedIndividual namedIndividual
            | AnonymousIndividual anonymousIndividual -> Xml.AnonymousIndividual anonymousIndividual

        static member ObjectProperty(property: ObjectProperty) =
            xml.ObjectProperty { xml._IRI property.identity }

        static member DataProperty(property: DataProperty) =
            xml.DataProperty { xml._IRI property.identity }

        static member AnnotationProperty(property: AnnotationProperty) =
            xml.AnnotationProperty { xml._IRI property.identity }

        static member Datatype(datatype: DatatypeIri) =
            xml.Datatype { xml._IRI datatype.identity }

        // ----------------------------------------
        // Literals
        // ----------------------------------------

        static member Literal(literal: Literal) =
            match literal with
            | StringLiteral(SimpleString simpleString) ->
                xml.Literal {
                    xml._datatypeIRI literal.datatypeIri.identity
                    value simpleString.simpleString
                }

            | StringLiteral(LanguageString languageString) ->
                xml.Literal {
                    xml.lang languageString.languageTag.identity
                    value languageString.lexicalForm
                }

            | TypedLiteral typedLiteral ->
                xml.Literal {
                    xml._datatypeIRI typedLiteral.datatypeIri.identity
                    value typedLiteral.lexicalForm
                }

            | EmbeddedLiteral embeddedLiteral ->
                xml.Literal {
                    xml._datatypeIRI embeddedLiteral.datatypeIri.identity
                    value literal.lexicalForm
                }

        // ----------------------------------------
        // Object property expressions
        // ----------------------------------------

        static member ObjectPropertyExpression(expression: ObjectPropertyExpression) =

            match expression with
            | ObjectProperty objectProperty -> Xml.ObjectProperty objectProperty

            | ObjectInverse objectProperty -> xml.ObjectInverseOf { Xml.ObjectProperty objectProperty }

        // ----------------------------------------
        // Data ranges
        // ----------------------------------------

        static member FacetRestriction(facetValue: FacetValue) =
            xml.FacetRestriction {
                xml._facet facetValue.constrainingFacet.Iri.identity
                Xml.Literal facetValue.restrictionValue
            }

        static member DatatypeRestriction(restriction: DatatypeRestriction) =
            xml.DatatypeRestriction {
                Xml.Datatype restriction.datatype

                for facetValue in restriction.facetValues.elements do
                    Xml.FacetRestriction facetValue
            }

        static member DataRange(dataRange: DataRange) =
            match dataRange with
            | DatatypeRange datatype -> Xml.Datatype datatype

            | DataIntersection dataRanges ->
                xml.DataIntersectionOf {
                    for range in dataRanges.elements do
                        Xml.DataRange range
                }

            | DataUnion dataRanges ->
                xml.DataUnionOf {
                    for range in dataRanges.elements do
                        Xml.DataRange range
                }

            | DataComplement dataRange -> xml.DataComplementOf { Xml.DataRange dataRange }

            | DataOne literals ->
                xml.DataOneOf {
                    for literal in literals.elements do
                        Xml.Literal literal
                }

            | DataRange.DatatypeRestriction restriction -> Xml.DatatypeRestriction restriction

        // ----------------------------------------
        // Cardinality restrictions
        // ----------------------------------------

        static member CardinalityRestriction(restriction: CardinalityRestriction) =

            match restriction.cardinal, restriction.cardinality with

            | MinimumCardinal cardinal, ObjectCardinality property ->
                xml.ObjectMinCardinality {
                    xml._cardinality cardinal
                    Xml.ObjectPropertyExpression property
                }

            | MinimumCardinal cardinal, ObjectQualifiedCardinality(property, classExpression) ->
                xml.ObjectMinCardinality {
                    xml._cardinality cardinal
                    Xml.ObjectPropertyExpression property
                    Xml.ClassExpression classExpression
                }

            | ExactCardinal cardinal, ObjectCardinality property ->
                xml.ObjectExactCardinality {
                    xml._cardinality cardinal
                    Xml.ObjectPropertyExpression property
                }

            | ExactCardinal cardinal, ObjectQualifiedCardinality(property, classExpression) ->
                xml.ObjectExactCardinality {
                    xml._cardinality cardinal
                    Xml.ObjectPropertyExpression property
                    Xml.ClassExpression classExpression
                }

            | MaximumCardinal cardinal, ObjectCardinality property ->
                xml.ObjectMaxCardinality {
                    xml._cardinality cardinal
                    Xml.ObjectPropertyExpression property
                }

            | MaximumCardinal cardinal, ObjectQualifiedCardinality(property, classExpression) ->
                xml.ObjectMaxCardinality {
                    xml._cardinality cardinal
                    Xml.ObjectPropertyExpression property
                    Xml.ClassExpression classExpression
                }

            | MinimumCardinal cardinal, DataCardinality property ->
                xml.DataMinCardinality {
                    xml._cardinality cardinal
                    Xml.DataProperty property
                }

            | MinimumCardinal cardinal, DataQualifiedCardinality(property, dataRange) ->
                xml.DataMinCardinality {
                    xml._cardinality cardinal
                    Xml.DataProperty property
                    Xml.DataRange dataRange
                }

            | ExactCardinal cardinal, DataCardinality property ->
                xml.DataExactCardinality {
                    xml._cardinality cardinal
                    Xml.DataProperty property
                }

            | ExactCardinal cardinal, DataQualifiedCardinality(property, dataRange) ->
                xml.DataExactCardinality {
                    xml._cardinality cardinal
                    Xml.DataProperty property
                    Xml.DataRange dataRange
                }

            | MaximumCardinal cardinal, DataCardinality property ->
                xml.DataMaxCardinality {
                    xml._cardinality cardinal
                    Xml.DataProperty property
                }

            | MaximumCardinal cardinal, DataQualifiedCardinality(property, dataRange) ->
                xml.DataMaxCardinality {
                    xml._cardinality cardinal
                    Xml.DataProperty property
                    Xml.DataRange dataRange
                }

        // ----------------------------------------
        // Class restrictions
        // ----------------------------------------

        static member Restriction(restriction: Restriction) =
            match restriction with
            | ExistentialClassRestriction restriction ->
                xml.ObjectSomeValuesFrom {
                    Xml.ObjectPropertyExpression restriction.onObjectProperty
                    Xml.ClassExpression restriction.toClassExpression
                }

            | UniversalClassRestriction restriction ->
                xml.ObjectAllValuesFrom {
                    Xml.ObjectPropertyExpression restriction.onObjectProperty
                    Xml.ClassExpression restriction.toClassExpression
                }

            | IndividualValueRestriction restriction ->
                xml.ObjectHasValue {
                    Xml.ObjectPropertyExpression restriction.onObjectPropertyExpression
                    Xml.Individual restriction.toIndividual
                }

            | SelfRestriction objectPropertyExpression ->
                xml.ObjectHasSelf { Xml.ObjectPropertyExpression objectPropertyExpression }

            | ExistentialDataRangeRestriction restriction ->
                xml.DataSomeValuesFrom {
                    for dataProperty in restriction.onDataProperties.items do
                        Xml.DataProperty dataProperty

                    Xml.DataRange restriction.toDataRange
                }

            | UniversalDataRangeRestriction restriction ->
                xml.DataAllValuesFrom {
                    for dataProperty in restriction.onDataProperties.items do
                        Xml.DataProperty dataProperty

                    Xml.DataRange restriction.toDataRange
                }

            | LiteralValueRestriction restriction ->
                xml.DataHasValue {
                    Xml.DataProperty restriction.onDataProperty
                    Xml.Literal restriction.toLiteral
                }

            | Restriction.CardinalityRestriction restriction -> Xml.CardinalityRestriction restriction

        // ----------------------------------------
        // Class expressions
        // ----------------------------------------

        static member ClassExpression(expression: ClassExpression) : XmlPart =
            match expression with
            | ClassExpression class_ -> Xml.Class class_

            | ObjectIntersection expressions ->
                xml.ObjectIntersectionOf {
                    for expression in expressions.elements do
                        Xml.ClassExpression expression
                }

            | ObjectUnion expressions ->
                xml.ObjectUnionOf {
                    for expression in expressions.elements do
                        Xml.ClassExpression expression
                }

            | ObjectComplement expression -> xml.ObjectComplementOf { Xml.ClassExpression expression }

            | ObjectOne individuals ->
                xml.ObjectOneOf {
                    for individual in individuals.elements do
                        Xml.Individual individual
                }

            | RestrictionClassExpression restriction -> Xml.Restriction restriction

        // ----------------------------------------
        // Annotation values
        // ----------------------------------------

        static member AnnotationValue(annotationValue: BasicNormativeObject) : XmlPart =
            match annotationValue with
            | IriObject iri -> xml.IRI { value iri.identity }

            | BNodeObject bnode -> xml.AnonymousIndividual { xml._nodeID bnode.identity }

            | LiteralObject literal -> Xml.Literal literal

        // ----------------------------------------
        // Annotations
        // ----------------------------------------

        static member Annotation(annotation: Annotation) : XmlPart =
            xml.Annotation {
                for nestedAnnotation in annotation.annotationAnnotations do
                    Xml.Annotation nestedAnnotation

                Xml.AnnotationProperty annotation.annotationProperty
                Xml.AnnotationValue annotation.annotationValue
            }

        // ----------------------------------------
        // Generic annotated element composition
        // ----------------------------------------

        static member Annotated
            (annotated: Annotated<'T>, serializeContent: 'T -> XmlPart list, constructElement: seq<XmlPart> -> XmlPart)
            : XmlPart =

            let contents =
                seq {
                    for annotation in annotated.annotations do
                        yield Xml.Annotation annotation

                    yield! serializeContent annotated.value
                }

            constructElement contents

        // ----------------------------------------
        // Class assertion content
        // ----------------------------------------

        static member ClassAssertionContent(classAssertion: ClassAssertion) : XmlPart list =

            [ Xml.ClassExpression classAssertion.classExpression
              Xml.Individual classAssertion.individual ]

        // ----------------------------------------
        // Class assertion
        // ----------------------------------------

        static member ClassAssertion(classAssertion: ClassAssertion) : XmlPart =

            xml.ClassAssertion { yield! Xml.ClassAssertionContent classAssertion }

        static member ClassAssertion(annotated: Annotated<ClassAssertion>) : XmlPart =

            Xml.Annotated(annotated, Xml.ClassAssertionContent, fun contents -> xml.ClassAssertion { yield! contents })

        static member SameIndividualContent(assertion: SameIndividual) : XmlPart list =
            [ for individual in assertion.SameIndividual.elements do
                  Xml.Individual individual ]

        static member DifferentIndividualsContent(assertion: DifferentIndividuals) : XmlPart list =
            [ for individual in assertion.DifferentIndividuals.elements do
                  Xml.Individual individual ]

        static member ObjectPropertyAssertionContent(assertion: ObjectPropertyAssertion) : XmlPart list =
            [ Xml.ObjectPropertyExpression assertion.objectPropertyExpression
              Xml.Individual assertion.sourceIndividual
              Xml.Individual assertion.targetIndividual ]

        static member NegativeObjectPropertyAssertionContent
            (assertion: NegativeObjectPropertyAssertion)
            : XmlPart list =
            [ Xml.ObjectPropertyExpression assertion.negativeObjectPropertyExpression
              Xml.Individual assertion.sourceIndividual
              Xml.Individual assertion.targetIndividual ]

        static member DataPropertyAssertionContent(assertion: DataPropertyAssertion) : XmlPart list =
            [ Xml.DataProperty assertion.dataProperty
              Xml.Individual assertion.sourceIndividual
              Xml.Literal assertion.targetValue ]

        static member NegativeDataPropertyAssertionContent(assertion: NegativeDataPropertyAssertion) : XmlPart list =
            [ Xml.DataProperty assertion.negativeDataProperty
              Xml.Individual assertion.sourceIndividual
              Xml.Literal assertion.targetValue ]

        static member Assertion(annotated: Annotated<Assertion>) : XmlPart =

            match annotated.value with

            | Assertion.SameIndividual assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.SameIndividualContent,
                    fun contents -> xml.SameIndividual { yield! contents }
                )

            | Assertion.DifferentIndividuals assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.DifferentIndividualsContent,
                    fun contents -> xml.DifferentIndividuals { yield! contents }
                )

            | Assertion.ClassAssertion assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.ClassAssertionContent,
                    fun contents -> xml.ClassAssertion { yield! contents }
                )

            | Assertion.ObjectPropertyAssertion assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.ObjectPropertyAssertionContent,
                    fun contents -> xml.ObjectPropertyAssertion { yield! contents }
                )

            | Assertion.NegativeObjectPropertyAssertion assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.NegativeObjectPropertyAssertionContent,
                    fun contents -> xml.NegativeObjectPropertyAssertion { yield! contents }
                )

            | Assertion.DataPropertyAssertion assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.DataPropertyAssertionContent,
                    fun contents -> xml.DataPropertyAssertion { yield! contents }
                )

            | Assertion.NegativeDataPropertyAssertion assertion ->
                Xml.Annotated(
                    annotated.map (fun _ -> assertion),
                    Xml.NegativeDataPropertyAssertionContent,
                    fun contents -> xml.NegativeDataPropertyAssertion { yield! contents }
                )

        static member SubClassContent(axiom: SubClass) : XmlPart list =
            [ Xml.ClassExpression axiom.subClassExpression
              Xml.ClassExpression axiom.superClassExpression ]

        static member EquivalentClassesContent(axiom: EquivalentClasses) : XmlPart list =
            [ for expression in axiom.equivalentClasses.elements do
                  Xml.ClassExpression expression ]

        static member DisjointClassesContent(axiom: DisjointClasses) : XmlPart list =
            [ for expression in axiom.disjointClasses.elements do
                  Xml.ClassExpression expression ]

        static member DisjointUnionContent(axiom: DisjointUnion) : XmlPart list =
            [ Xml.Class axiom.disjointClass

              for expression in axiom.disjointClassExpressions.elements do
                  Xml.ClassExpression expression ]

        static member ClassAxiom(annotated: Annotated<ClassAxiom>) : XmlPart =

            match annotated.value with

            | SubClassAxiom axiom ->
                Xml.Annotated(
                    annotated.map (fun _ -> axiom),
                    Xml.SubClassContent,
                    fun contents -> xml.SubClassOf { yield! contents }
                )

            | EquivalentClassesAxiom axiom ->
                Xml.Annotated(
                    annotated.map (fun _ -> axiom),
                    Xml.EquivalentClassesContent,
                    fun contents -> xml.EquivalentClasses { yield! contents }
                )

            | DisjointClassesAxiom axiom ->
                Xml.Annotated(
                    annotated.map (fun _ -> axiom),
                    Xml.DisjointClassesContent,
                    fun contents -> xml.DisjointClasses { yield! contents }
                )

            | DisjointUnionAxiom axiom ->
                Xml.Annotated(
                    annotated.map (fun _ -> axiom),
                    Xml.DisjointUnionContent,
                    fun contents -> xml.DisjointUnion { yield! contents }
                )

        static member SubObjectPropertyContent(axiom: SubObjectProperty) : XmlPart list =

            [ match axiom.subObjectPropertyExpression with
              | SubObjectPropertyExpression expression -> Xml.ObjectPropertyExpression expression

              | PropertyExpressionChain chain ->
                  xml.ObjectPropertyChain {
                      for property in chain.objectPropertyChain.items do
                          Xml.ObjectPropertyExpression property
                  }

              Xml.ObjectPropertyExpression axiom.superObjectPropertyExpression ]

        static member ObjectPropertyAxiom(annotated: Annotated<ObjectPropertyAxiom>) : XmlPart =

            let emit (contents: XmlPart list) (construct: seq<XmlPart> -> XmlPart) =
                Xml.Annotated(annotated, (fun _ -> contents), construct)

            match annotated.value with

            | ObjectPropertyAxiom.SubObjectProperty axiom ->
                emit (Xml.SubObjectPropertyContent axiom) (fun contents -> xml.SubObjectPropertyOf { yield! contents })

            | ObjectPropertyAxiom.EquivalentObjectProperties axiom ->
                emit
                    [ for property in axiom.equivalentObjectPropertyExpressions.elements do
                          Xml.ObjectPropertyExpression property ]
                    (fun contents -> xml.EquivalentObjectProperties { yield! contents })

            | ObjectPropertyAxiom.DisjointObjectProperties axiom ->
                emit
                    [ for property in axiom.disjointObjectPropertyExpressions.elements do
                          Xml.ObjectPropertyExpression property ]
                    (fun contents -> xml.DisjointObjectProperties { yield! contents })

            | ObjectPropertyAxiom.InverseObjectProperties axiom ->
                let first, second = axiom.inverseObjectProperties

                emit [ Xml.ObjectPropertyExpression first; Xml.ObjectPropertyExpression second ] (fun contents ->
                    xml.InverseObjectProperties { yield! contents })

            | ObjectPropertyAxiom.ObjectPropertyDomain axiom ->
                emit
                    [ Xml.ObjectPropertyExpression axiom.objectPropertyExpression
                      Xml.ClassExpression axiom.objectPropertyDomain ]
                    (fun contents -> xml.ObjectPropertyDomain { yield! contents })

            | ObjectPropertyAxiom.ObjectPropertyRange axiom ->
                emit
                    [ Xml.ObjectPropertyExpression axiom.objectPropertyExpression
                      Xml.ClassExpression axiom.objectPropertyRange ]
                    (fun contents -> xml.ObjectPropertyRange { yield! contents })

            | ObjectPropertyAxiom.FunctionalObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.functionalObjectProperty ] (fun contents ->
                    xml.FunctionalObjectProperty { yield! contents })

            | ObjectPropertyAxiom.InverseFunctionalObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.inverseFunctionalObjectProperty ] (fun contents ->
                    xml.InverseFunctionalObjectProperty { yield! contents })

            | ObjectPropertyAxiom.ReflexiveObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.reflexiveObjectProperty ] (fun contents ->
                    xml.ReflexiveObjectProperty { yield! contents })

            | ObjectPropertyAxiom.IrreflexiveObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.irreflexiveObjectProperty ] (fun contents ->
                    xml.IrreflexiveObjectProperty { yield! contents })

            | ObjectPropertyAxiom.SymmetricObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.symmetricObjectProperty ] (fun contents ->
                    xml.SymmetricObjectProperty { yield! contents })

            | ObjectPropertyAxiom.AsymmetricObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.asymmetricObjectProperty ] (fun contents ->
                    xml.AsymmetricObjectProperty { yield! contents })

            | ObjectPropertyAxiom.TransitiveObjectProperty axiom ->
                emit [ Xml.ObjectPropertyExpression axiom.transitiveObjectProperty ] (fun contents ->
                    xml.TransitiveObjectProperty { yield! contents })

        static member DataPropertyAxiom(annotated: Annotated<DataPropertyAxiom>) : XmlPart =

            let emit (contents: XmlPart list) (construct: seq<XmlPart> -> XmlPart) =
                Xml.Annotated(annotated, (fun _ -> contents), construct)

            match annotated.value with

            | DataPropertyAxiom.SubDataProperty axiom ->
                emit
                    [ Xml.DataProperty axiom.subDataProperty
                      Xml.DataProperty axiom.superDataProperty ]
                    (fun contents -> xml.SubDataPropertyOf { yield! contents })

            | DataPropertyAxiom.EquivalentDataProperties axiom ->
                emit
                    [ for property in axiom.equivalentDataProperties.elements do
                          Xml.DataProperty property ]
                    (fun contents -> xml.EquivalentDataProperties { yield! contents })

            | DataPropertyAxiom.DisjointDataProperties axiom ->
                emit
                    [ for property in axiom.disjointDataProperties.elements do
                          Xml.DataProperty property ]
                    (fun contents -> xml.DisjointDataProperties { yield! contents })

            | DataPropertyAxiom.DataPropertyDomain axiom ->
                emit
                    [ Xml.DataProperty axiom.dataProperty
                      Xml.ClassExpression axiom.dataPropertyDomain ]
                    (fun contents -> xml.DataPropertyDomain { yield! contents })

            | DataPropertyAxiom.DataPropertyRange axiom ->
                emit [ Xml.DataProperty axiom.dataProperty; Xml.DataRange axiom.dataPropertyRange ] (fun contents ->
                    xml.DataPropertyRange { yield! contents })

            | DataPropertyAxiom.FunctionalDataProperty axiom ->
                emit [ Xml.DataProperty axiom.functionalDataProperty ] (fun contents ->
                    xml.FunctionalDataProperty { yield! contents })

        static member Entity(entity: Entity) : XmlPart =
            match entity with
            | ClassEntity class_ -> Xml.Class class_

            | DatatypeEntity datatype -> Xml.Datatype datatype

            | ObjectPropertyEntity property -> Xml.ObjectProperty property

            | DataPropertyEntity property -> Xml.DataProperty property

            | AnnotationPropertyEntity property -> Xml.AnnotationProperty property

            | NamedIndividualEntity individual -> Xml.NamedIndividual individual

        static member Declaration(annotated: Annotated<Declaration>) : XmlPart =

            Xml.Annotated(
                annotated,
                (fun declaration -> [ Xml.Entity declaration.entity ]),
                (fun contents -> xml.Declaration { yield! contents })
            )

        static member DatatypeDefinition(annotated: Annotated<DatatypeDefinition>) : XmlPart =

            Xml.Annotated(
                annotated,
                (fun definition -> [ Xml.Datatype definition.datatype; Xml.DataRange definition.dataRange ]),
                (fun contents -> xml.DatatypeDefinition { yield! contents })
            )

        static member KeyProperties(keyProperties: KeyProperties) : XmlPart list =
            match keyProperties with

            | ObjectDataKeyProperties(objectProperties, dataProperties) ->
                [ for property in objectProperties.elements do
                      Xml.ObjectPropertyExpression property

                  for property in dataProperties.elements do
                      Xml.DataProperty property ]

            | ObjectKeyProperties objectProperties ->
                [ for property in objectProperties.elements do
                      Xml.ObjectPropertyExpression property ]

            | DataKeyProperties dataProperties ->
                [ for property in dataProperties.elements do
                      Xml.DataProperty property ]

        static member HasKey(annotated: Annotated<HasKey>) : XmlPart =

            Xml.Annotated(
                annotated,
                (fun hasKey ->
                    [ Xml.ClassExpression hasKey.classExpression
                      yield! Xml.KeyProperties hasKey.keyProperties ]),
                (fun contents -> xml.HasKey { yield! contents })
            )

        static member AnnotationSubject(subject: NormativeSubject) : XmlPart =

            match subject with
            | IriSubject iri -> xml.IRI { value iri.identity }

            | BNodeSubject bnode -> xml.AnonymousIndividual { xml._nodeID bnode.identity }

        static member AnnotationAxiom(annotated: Annotated<AnnotationAxiom>) : XmlPart =

            let emit (contents: XmlPart list) (construct: seq<XmlPart> -> XmlPart) =
                Xml.Annotated(annotated, (fun _ -> contents), construct)

            match annotated.value with

            | AnnotationAxiom.AnnotationAssertion axiom ->
                emit
                    [ Xml.AnnotationProperty axiom.annotationProperty
                      Xml.AnnotationSubject axiom.annotationSubject
                      Xml.AnnotationValue axiom.annotationValue ]
                    (fun contents -> xml.AnnotationAssertion { yield! contents })

            | AnnotationAxiom.SubAnnotationProperty axiom ->
                emit
                    [ Xml.AnnotationProperty axiom.subAnnotationProperty
                      Xml.AnnotationProperty axiom.superAnnotationProperty ]
                    (fun contents -> xml.SubAnnotationPropertyOf { yield! contents })

            | AnnotationAxiom.AnnotationPropertyDomain axiom ->
                emit
                    [ Xml.AnnotationProperty axiom.annotationProperty

                      xml.IRI { value axiom.domainIri.identity } ]
                    (fun contents -> xml.AnnotationPropertyDomain { yield! contents })

            | AnnotationAxiom.AnnotationPropertyRange axiom ->
                emit
                    [ Xml.AnnotationProperty axiom.annotationProperty

                      xml.IRI { value axiom.rangeIri.identity } ]
                    (fun contents -> xml.AnnotationPropertyRange { yield! contents })

        static member Axiom(annotated: Annotated<Axiom>) : XmlPart =
            match annotated.value with

            | Axiom.Declaration declaration -> Xml.Declaration(annotated.map (fun _ -> declaration))

            | Axiom.ClassAxiom classAxiom -> Xml.ClassAxiom(annotated.map (fun _ -> classAxiom))

            | Axiom.ObjectPropertyAxiom objectPropertyAxiom ->
                Xml.ObjectPropertyAxiom(annotated.map (fun _ -> objectPropertyAxiom))

            | Axiom.DataPropertyAxiom dataPropertyAxiom ->
                Xml.DataPropertyAxiom(annotated.map (fun _ -> dataPropertyAxiom))

            | Axiom.DatatypeDefinition datatypeDefinition ->
                Xml.DatatypeDefinition(annotated.map (fun _ -> datatypeDefinition))

            | Axiom.HasKey hasKey -> Xml.HasKey(annotated.map (fun _ -> hasKey))

            | Axiom.Assertion assertion -> Xml.Assertion(annotated.map (fun _ -> assertion))

            | Axiom.AnnotationAxiom annotationAxiom -> Xml.AnnotationAxiom(annotated.map (fun _ -> annotationAxiom))

        static member Prefix(prefixDeclaration: PrefixDeclaration) : XmlPart =
            match prefixDeclaration with
            | Prefix(prefixName, iriReference) ->
                xml.Prefix {
                    xml._name prefixName
                    xml._IRI iriReference.uri.OriginalString
                }

        static member Import(importDocument: DirectlyImportsDocument) : XmlPart =
            match importDocument with
            | Import iri -> xml.Import { value iri.identity }

        static member Ontology(annotated: Annotated<Ontology>, prefixes: Set<PrefixDeclaration>) : XmlPart =

            let ontology = annotated.value

            xml.Ontology {

                match ontology.ontologyIdentifier with
                | Some(ontologyIri, versionIri) ->
                    xml._ontologyIRI ontologyIri.identity

                    match versionIri with
                    | Some versionIri -> xml._versionIRI versionIri.identity
                    | None -> ()

                | None -> ()

                for prefix in prefixes do
                    Xml.Prefix prefix

                for importDocument in ontology.directlyImportsDocuments do
                    Xml.Import importDocument

                for annotation in annotated.annotations do
                    Xml.Annotation annotation

                for axiom in ontology.axioms do
                    Xml.Axiom axiom
            }

        static member Ontology(annotated: Annotated<Ontology>) : XmlPart =

            Xml.Ontology(annotated, Set.empty)

        static member Ontology(ontology: Ontology) : XmlPart =

            Xml.Ontology(Annotated.Unannotated ontology)

        static member OntologyDocument(document: OntologyDocument) : XmlPart =

            match document with
            | OntologyDocument(prefixes, annotated) -> Xml.Ontology(annotated, prefixes)

            | Ontology annotated -> Xml.Ontology annotated

// ----

type RDFNamespace with
    static member toVocabulary(rdfNamespace: RDFNamespace) =
        RdfVocabulary.PREFIX(rdfNamespace.NamespacePrefix, rdfNamespace.NamespaceUri.OriginalString)

    member this.NamespaceIri = Iri.op_Implicit this.NamespaceUri

type RDFNamespaceRegister with
    static member tryFindIri(iri: Iri) =
        match RDFNamespaceRegister.GetByUri(iri, false) |> Option.ofObj with
        | Some rdfNamespace -> Some rdfNamespace
        | None ->
            match RDFNamespaceRegister.GetByUri(iri, true) |> Option.ofObj with
            | Some rdfNamespace -> Some rdfNamespace
            | None -> None

    static member findIri(iri: Iri) =
        RDFNamespaceRegister.tryFindIri iri |> Option.get

    static member tryFindPrefix(prefix: string) =
        match RDFNamespaceRegister.GetByPrefix(prefix, false) |> Option.ofObj with
        | Some rdfNamespace -> Some rdfNamespace
        | None ->
            match RDFNamespaceRegister.GetByPrefix(prefix, true) |> Option.ofObj with
            | Some rdfNamespace -> Some rdfNamespace
            | None -> None

    static member findPrefix(prefix: string) =
        RDFNamespaceRegister.tryFindPrefix prefix |> Option.get

    static member tryAddNamespace(rdfNamespace: RDFNamespace) =
        RDFNamespaceRegister.AddNamespace rdfNamespace

        match RDFNamespaceRegister.tryFindIri rdfNamespace.NamespaceIri with
        | Some registeredNamespace when
            registeredNamespace.NamespacePrefix = rdfNamespace.NamespacePrefix
            && registeredNamespace.NamespaceUri = rdfNamespace.NamespaceUri
            ->
            Ok registeredNamespace
        | _ ->
            match
                RDFNamespaceRegister.tryFindIri rdfNamespace.NamespaceIri,
                RDFNamespaceRegister.tryFindPrefix rdfNamespace.NamespacePrefix
            with
            | Some iriCollision, _ -> Error iriCollision
            | _, Some prefixCollision -> Error prefixCollision
            | _, _ -> Error rdfNamespace

    static member tryAddPrefix((namespacePrefix: string), (namespaceIri: Iri), (dereferenceIri: Iri)) =
        let rdfNamespace = RDFNamespace(namespacePrefix, namespaceIri)

        rdfNamespace.SetDereferenceUri dereferenceIri
        |> RDFNamespaceRegister.tryAddNamespace

    static member tryAddPrefix((namespacePrefix: string), (namespaceIri: Iri)) =
        RDFNamespace(namespacePrefix, namespaceIri)
        |> RDFNamespaceRegister.tryAddNamespace

    static member ensurePrefix((namespacePrefix: string), (namespaceIri: Iri), (dereferenceIri: Iri)) =
        RDFNamespaceRegister.RemoveByUri namespaceIri
        RDFNamespaceRegister.RemoveByPrefix namespacePrefix

        RDFNamespaceRegister.tryAddPrefix (namespacePrefix, namespaceIri, dereferenceIri)
        |> Result.get

    static member ensurePrefix((namespacePrefix: string), (namespaceIri: Iri)) =
        RDFNamespaceRegister.RemoveByUri namespaceIri
        RDFNamespaceRegister.RemoveByPrefix namespacePrefix
        RDFNamespaceRegister.tryAddPrefix (namespacePrefix, namespaceIri) |> Result.get

type Uri with
    member this.isInVocabulary(vocabulary: RdfVocabulary) =
        this.OriginalString.StartsWith(vocabulary.identity, StringComparison.Ordinal)

    member this.tryLocalName(vocabulary: RdfVocabulary) =
        if this.isInVocabulary vocabulary then
            Some this.OriginalString[vocabulary.identity.Length ..]
        else
            None

type UriNode with
    member this.isInVocabulary(vocabulary: RdfVocabulary) = this.Uri.isInVocabulary vocabulary
    member this.tryLocalName(vocabulary: RdfVocabulary) = this.Uri.tryLocalName vocabulary
    member this.localPart = this.Uri.localPart

    static member ofIri(iri: Iri) = UriNode iri.asUri
    member this.asIri = Iri.op_Implicit this.Uri

type BlankNode with
    member this.asBNode(scope: string) =
        match Guid.TryParse this.InternalID with
        | true, guid ->
            { sinsignId = guid
              scope = scope
              localIdentifier = None }
        | false, _ ->
            { sinsignId = Guid.ensure this.InternalID
              scope = scope
              localIdentifier = Some this.InternalID }

type INode with
    member this.tryUriNode =
        match this with
        | :? UriNode as uriNode -> Some(uriNode)
        | _ -> None

    member this.isInVocabulary(vocabulary: RdfVocabulary) =
        match this.tryUriNode with
        | Some uriNode -> uriNode.isInVocabulary vocabulary
        | _ -> false

    member this.tryLocalName(vocabulary: RdfVocabulary) =
        match this.tryUriNode with
        | Some uriNode -> uriNode.tryLocalName vocabulary
        | None -> None

    member this.tryLocalPart =
        match this.tryUriNode with
        | Some uriNode -> Some uriNode.localPart
        | None -> None

type OntologyResource with
    member this.tryUriNode = this.Resource.tryUriNode
    member this.isInVocabulary(vocabulary: RdfVocabulary) = this.Resource.isInVocabulary vocabulary
    member this.tryLocalName(vocabulary: RdfVocabulary) = this.Resource.tryLocalName vocabulary
    member this.tryLocalPart = this.Resource.tryLocalPart

type ThreadSafeGraph with
    static member ofRdfVocabulary(vocabulary: RdfVocabulary) =

        let graph = new ThreadSafeGraph(UriNode.ofIri vocabulary.namespaceIri)

        for documentIri in vocabulary.documentIris do
            let documentUri = documentIri.asUri

            dotNetRdfLoader.LoadGraph(graph, documentUri)

        graph

    member this.prefixedNames(vocabulary: RdfVocabulary) =
        this.AllNodes.UriNodes()
        |> Seq.choose (fun uriNode -> uriNode.tryLocalName vocabulary)
        |> Seq.filter (String.IsNullOrEmpty >> not)
        |> Seq.map vocabulary.prefixedName
        |> Seq.distinctBy _.identity
        |> Seq.sortBy _.localName
        |> Seq.toArray

type LiteralNode with
    member this.asLiteral =

        match Option.ofNullOrWhiteSpace this.Language, Option.ofNullOrWhiteSpace this.DataType with
        | Some language, _ ->
            match language.LastIndexOf("--") with
            | -1 ->
                { lexicalForm = this.Value
                  languageTag = NLanguageTag.LanguageTag.Parse language
                  baseDirection = None }
                |> LanguageString
                |> StringLiteral

            | delimiterIndex ->
                match InitialTextDirection.tryParse language[delimiterIndex + 2 ..] with
                | Some direction ->
                    let rawTag = language[.. delimiterIndex - 1]

                    { lexicalForm = this.Value
                      languageTag = LanguageTag.Parse rawTag
                      baseDirection = Some direction }
                    |> LanguageString
                    |> StringLiteral
                | None ->
                    { lexicalForm = this.Value
                      languageTag = LanguageTag.Parse language
                      baseDirection = None }
                    |> LanguageString
                    |> StringLiteral

        | None, Some datatypeUri ->
            TypedLiteral
                { lexicalForm = this.Value
                  datatypeIri = Iri.ofUri datatypeUri |> DatatypeIri }

        | _, _ -> Literal.string this.Value

type OntologyGraph with
    static member ofRdfVocabulary(vocabulary: RdfVocabulary) =

        let ontologyGraph = new OntologyGraph(UriNode.ofIri vocabulary.namespaceIri)

        for documentIri in vocabulary.documentIris do
            let documentUri = documentIri.asUri

            dotNetRdfLoader.LoadGraph(ontologyGraph, documentUri)

        ontologyGraph

    member this.LiteralNodes =
        this.AllNodes
        |> Seq.choose (fun inode ->
            match inode with
            | :? LiteralNode as literalNode -> Some literalNode
            | _ -> None)

    member this.Literals = this.LiteralNodes |> Seq.map _.asLiteral

    member this.ClassMap =
        this.AllClasses
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.PropertyMap =
        this.AllProperties
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.InstanceMap =
        this.AllClasses
        |> Seq.collect (fun ontologyResource ->
            ontologyResource.Instances
            |> Seq.choose (fun ontologyInstance ->
                match ontologyInstance.tryUriNode with
                | Some uriNode -> Some(uriNode.asIri, ontologyInstance)
                | _ -> None))
        |> Map.ofSeq

    member this.OwlClassMap =
        this.OwlClasses
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.RdfClassMap =
        this.RdfClasses
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.RdfPropertyMap =
        this.RdfProperties
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.OwlAnnotationPropertyMap =
        this.OwlAnnotationProperties
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.OwlDatatypePropertyMap =
        this.OwlDatatypeProperties
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq

    member this.OwlObjectPropertyMap =
        this.OwlObjectProperties
        |> Seq.choose (fun ontologyResource ->
            match ontologyResource.tryUriNode with
            | Some uriNode -> Some(uriNode.asIri, ontologyResource)
            | _ -> None)
        |> Map.ofSeq
type RdfVocabulary with 
    member this.ClassMap(ontologyGraph:OntologyGraph) =

        ontologyGraph.ClassMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.PropertyMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.PropertyMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.OwlClassMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.OwlClassMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.RdfClassMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.RdfClassMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.RdfPropertyMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.RdfPropertyMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.OwlAnnotationPropertyMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.OwlAnnotationPropertyMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.OwlDatatypePropertyMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.OwlDatatypePropertyMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

    member this.OwlObjectPropertyMap(ontologyGraph:OntologyGraph) =
        ontologyGraph.OwlObjectPropertyMap
        |> Map.toSeq
        |> Seq.choose (fun (iri, ontologyResource) ->
            match iri.tryPrefixedName this with
            | Some prefixedName -> Some(prefixedName, ontologyResource)
            | None -> None)
        |> Map.ofSeq

type OntologyClass with
    member this.Properties =
        seq {
            yield this
            yield! this.SuperClasses
        }
        |> Seq.distinctBy _.Resource
        |> Seq.collect _.IsDomainOf
        |> Seq.distinctBy _.Resource
        |> Seq.toArray

type RDFGraph with

    static member ofNTriples(ntriples: seq<string>) =
        task {
            let content = String.Join("\n", ntriples)
            let bytes = Encoding.UTF8.GetBytes(content)

            use stream = new MemoryStream(bytes)

            return! RDFGraph.FromStreamAsync(RDFModelEnums.RDFFormats.NTriples, stream)
        }
        |> _.Result

type ThreadSafeGraph with

    static member ofNTriples(ntriples: seq<string>) =
        let graph = new ThreadSafeGraph()
        use reader = new StringReader(String.Join("\n", ntriples))

        NTriplesParser().Load(graph, reader)
        graph

type OntologyGraph with

    static member ofNTriples(ntriples: seq<string>) =
        let graph = new OntologyGraph()
        use reader = new StringReader(String.Join("\n", ntriples))

        NTriplesParser().Load(graph, reader)
        graph

type OWLSharp.Ontology.OWLOntology with

    static member ofOntology(ontology: Annotated<Ontology>) : OWLSharp.Ontology.OWLOntology =

        let owlXml = Owl.Xml.Ontology ontology |> LitXml.ElementBuilder.writeToString

        let document = XDocument.Parse owlXml

        // OWLSharp expects unqualified XML elements.
        for element in document.Descendants() do
            if element.Name.Namespace = RdfVocabulary.owl.asXNamespace then
                element.Name <- XName.Get element.Name.LocalName

        // Remove namespace declarations that conflict with
        // the now-unqualified XML element names.
        for element in document.Descendants() do
            let declarations =
                element.Attributes()
                |> Seq.filter (fun attribute ->
                    attribute.IsNamespaceDeclaration && attribute.Value = RdfVocabulary.owl.identity)
                |> Seq.toArray

            for declaration in declarations do
                declaration.Remove()

        // OWLSharp uses ontologyVersion rather than versionIRI.
        let root = document.Root

        if not (isNull root) then
            let versionAttribute = root.Attribute(XName.Get "versionIRI")

            if not (isNull versionAttribute) then
                root.SetAttributeValue(XName.Get "ontologyVersion", versionAttribute.Value)

                versionAttribute.Remove()

        let compatibleXml = document.ToString(SaveOptions.DisableFormatting)

        use stream = new MemoryStream(Encoding.UTF8.GetBytes compatibleXml)

        OWLSharp.Ontology.OWLOntology.FromStreamAsync(OWLSharp.OWLEnums.OWLFormats.OWL2XML, stream)
        |> Async.AwaitTask
        |> Async.RunSynchronously

type Iana.ProtocolScheme with
    member this.host(domain: Domain) = { scheme = this; host = domain }

    member this.site(domain: Domain) =
        { site = { scheme = this; host = domain }
          port = None
          template = None
          pattern = None
          pathSegments = List.empty
          hashFragment = None
          searchQuery = None }

    member this.host(subdomain: string) =
        fun (domain: Domain) ->
            { scheme = this
              host = subdomain .+ domain }

type String with
    member this.dot(domain: Domain) =
        { domain with
            subdomainLabels = domain.subdomainLabels @ [ this ] }

    member this.asLiteral = Literal.string this

type ITrieNode<'Key, 'Value when 'Value: not struct> with
    member this.values = this.Values |> Seq.toArray
    member this.children = this.Children |> Seq.toArray

type SourceRepository with
    member this.ResourceTypes =
        Repository.Provider.GetCoreV3()
        |> Seq.map (fun provider -> provider.Value.ResourceType)
        |> Seq.distinct
        |> Seq.choose (fun resourceType ->

            let GetResourceAsync =
                typeof<SourceRepository>.GetMethods()
                |> Array.find (fun methodInfo -> methodInfo.Name = "GetResourceAsync")

            let methodInfo = GetResourceAsync.MakeGenericMethod([| resourceType |])

            let task = methodInfo.Invoke(this, [||]) :?> System.Threading.Tasks.Task

            task.GetAwaiter().GetResult()

            let resource = task.GetType().GetProperty("Result").GetValue(task)

            if isNull resource then None else Some resourceType)
        |> Seq.sortBy (fun resourceType -> resourceType.Name)
        |> Seq.toArray

type Quotation =
    static member ofMember<'T> (memberShape: IShapeMember<'T>) (value: 'T) : Expr =

        memberShape.Accept
            { new IMemberVisitor<'T, Expr> with

                member _.Visit<'Field>(shape: ShapeMember<'T, 'Field>) =

                    let fieldValue = shape.Get value
                    Quotation.ofValue fieldValue :> Expr }

    static member ofNuGetResource<'ResourceType when 'ResourceType: not struct and 'ResourceType :> INuGetResource>
        (serviceIndex: string)
        : Expr<'ResourceType> =

        <@ Repository.Factory.GetCoreV3(serviceIndex).GetResource<'ResourceType>() @>

    static member ofNuGetResource(serviceIndex: string, resourceType: Type) : Expr =
        match resourceType with
        | resource when resource = typeof<AutoCompleteResource> ->
            Quotation.ofNuGetResource<AutoCompleteResource> (serviceIndex)
        | resource when resource = typeof<DependencyInfoResource> ->
            Quotation.ofNuGetResource<DependencyInfoResource> (serviceIndex)
        | resource when resource = typeof<DownloadResource> ->
            Quotation.ofNuGetResource<DownloadResource> (serviceIndex)
        | resource when resource = typeof<FeedTypeResource> ->
            Quotation.ofNuGetResource<FeedTypeResource> (serviceIndex)
        | resource when resource = typeof<FindPackageByIdResource> ->
            Quotation.ofNuGetResource<FindPackageByIdResource> (serviceIndex)
        | resource when resource = typeof<HttpHandlerResource> ->
            Quotation.ofNuGetResource<HttpHandlerResource> (serviceIndex)
        | resource when resource = typeof<HttpSourceResource> ->
            Quotation.ofNuGetResource<HttpSourceResource> (serviceIndex)
        | resource when resource = typeof<IVulnerabilityInfoResource> ->
            Quotation.ofNuGetResource<IVulnerabilityInfoResource> (serviceIndex)
        | resource when resource = typeof<ListResource> -> Quotation.ofNuGetResource<ListResource> (serviceIndex)
        | resource when resource = typeof<MetadataResource> ->
            Quotation.ofNuGetResource<MetadataResource> (serviceIndex)
        | resource when resource = typeof<ODataServiceDocumentResourceV2> ->
            Quotation.ofNuGetResource<ODataServiceDocumentResourceV2> (serviceIndex)
        | resource when resource = typeof<OwnerDetailsUriTemplateResourceV3> ->
            Quotation.ofNuGetResource<OwnerDetailsUriTemplateResourceV3> (serviceIndex)
        | resource when resource = typeof<PackageDetailsUriResourceV3> ->
            Quotation.ofNuGetResource<PackageDetailsUriResourceV3> (serviceIndex)
        | resource when resource = typeof<PackageMetadataResource> ->
            Quotation.ofNuGetResource<PackageMetadataResource> (serviceIndex)
        | resource when resource = typeof<PackageSearchResource> ->
            Quotation.ofNuGetResource<PackageSearchResource> (serviceIndex)
        | resource when resource = typeof<PackageUpdateResource> ->
            Quotation.ofNuGetResource<PackageUpdateResource> (serviceIndex)
        | resource when resource = typeof<RegistrationResourceV3> ->
            Quotation.ofNuGetResource<RegistrationResourceV3> (serviceIndex)
        | resource when resource = typeof<ReportAbuseResourceV3> ->
            Quotation.ofNuGetResource<ReportAbuseResourceV3> (serviceIndex)
        | resource when resource = typeof<RepositorySignatureResource> ->
            Quotation.ofNuGetResource<RepositorySignatureResource> (serviceIndex)
        | resource when resource = typeof<ServiceIndexResourceV3> ->
            Quotation.ofNuGetResource<ServiceIndexResourceV3> (serviceIndex)
        | resource when resource = typeof<SymbolPackageUpdateResourceV3> ->
            Quotation.ofNuGetResource<SymbolPackageUpdateResourceV3> (serviceIndex)
        | _ -> invalidArg (nameof resourceType) $"No quotation defined for {resourceType.FullName}"

    static member ofDateTime(value: DateTime) : Expr<DateTime> =
        let ticks = value.Ticks
        let kind = value.Kind

        <@ DateTime(ticks, kind) @>

    static member ofTldRule(value: TldRule) : Expr<TldRule> =
        let rule = value.Name

        <@ TldRuleParser(TldRuleDivisionFilter.All).ParseRules rule |> Seq.head @>

    static member ofMimeType(value: MimeType) : Expr<MimeType> =
        let contentType = value.ToString()

        <@ MimeType.Parse contentType @>

    static member ofIriReference(value: IriReference) : Expr<IriReference> =
        let stringValue = value.ToString()

        <@ IriReference stringValue @>

    static member ofValue<'Value>(value: 'Value) : Expr<'Value> =

        let expression: Expr =
            match shapeof<'Value> with
            | _ when typeof<'Value> = typeof<IriReference> -> Quotation.ofIriReference (unbox<IriReference> (box value))
            | _ when typeof<'Value> = typeof<IriReference> -> Quotation.ofIriReference (unbox<IriReference> (box value))
            | _ when typeof<'Value> = typeof<MimeType> -> Quotation.ofMimeType (unbox<MimeType> (box value))
            | _ when typeof<'Value> = typeof<TldRule> -> Quotation.ofTldRule (unbox<TldRule> (box value))
            | _ when typeof<'Value> = typeof<DateTime> -> Quotation.ofDateTime (unbox<DateTime> (box value))
            | Shape.FSharpRecord(:? ShapeFSharpRecord<'Value> as shape) ->

                let fields =
                    shape.Fields
                    |> Array.map (fun field -> Quotation.ofMember field value)
                    |> Array.toList

                Expr.NewRecord(typeof<'Value>, fields)

            | Shape.FSharpUnion(:? ShapeFSharpUnion<'Value> as shape) ->

                let tag = shape.GetTag value
                let unionCase = shape.UnionCases[tag]

                let fields =
                    unionCase.Fields
                    |> Array.map (fun field -> Quotation.ofMember field value)
                    |> Array.toList

                Expr.NewUnionCase(unionCase.CaseInfo, fields)

            | Shape.Tuple(:? ShapeTuple<'Value> as shape) ->

                let elements =
                    shape.Elements
                    |> Array.map (fun element -> Quotation.ofMember element value)
                    |> Array.toList

                Expr.NewTuple(elements)

            | Shape.Array shape when shape.Rank = 1 ->

                shape.Element.Accept
                    { new ITypeVisitor<Expr> with

                        member _.Visit<'Element>() =

                            let elements =
                                unbox<'Element array> (box value)
                                |> Array.map Quotation.ofValue
                                |> Array.map (fun expression -> expression :> Expr)
                                |> Array.toList

                            Expr.NewArray(typeof<'Element>, elements) }

            | Shape.Unit
            | Shape.Bool
            | Shape.Byte
            | Shape.Int32
            | Shape.Int64
            | Shape.String ->

                Expr.Value(value, typeof<'Value>)

            | _ -> invalidOp $"Quotation.ofValue does not yet support {typeof<'Value>.FullName}"

        Expr.Cast<'Value> expression

// -----------------------------------------------------------------------------
// Additional type patterns
// -----------------------------------------------------------------------------
type TType<'ValueType> = ShapeSifter.Patterns.TType<'ValueType>
let tType<'ValueType> = ShapeSifter.Patterns.tType<'ValueType>
module TType = ShapeSifter.Patterns
type ShapeSifter.Patterns.TType<'ValueType> with 
    static member TldRule = tType<TldRule>
    static member MimeType = tType<MimeType>
    static member IriReference = tType<IriReference>
    static member Url = tType<Url>
let inline (|TType'Enum|_|) (_ : TType<'ValueType>) =
    if typeof<'ValueType>.IsEnum then
        Some ()
    else
        None

let (|TType'Byte|_|) (_ : 'a TType) : Teq<'a, byte> option = Teq.tryRefl<'a, byte>
type ProjectionContext =
    {
        references : (obj * int) list
        nextReferenceId : int
    }

    static member empty =
        {
            references = []
            nextReferenceId = 1
        }
type SemiStatic<'ValueType> =

    | StaticObject of 'ValueType
    | DynamicObject of ImmutableDynamicObj

    member this.tryStaticObject =
        match this with
        | StaticObject value ->
            Some value

        | DynamicObject _ ->
            None

    member this.tryDynamicObject =
        match this with
        | StaticObject _ ->
            None

        | DynamicObject value ->
            Some value
type ProjectionReference =
    | Untracked
    | FirstOccurrence of _referenceId : int
    | RepeatedOccurrence of _referenceId : int
module ProjectionContext =

    let classify<'ValueType>
        (value : 'ValueType)
        (context : ProjectionContext)
        : ProjectionReference * ProjectionContext
        =

        if typeof<'ValueType>.IsValueType then
            ProjectionReference.Untracked,
            context

        else

            let valueObject =
                box value

            if isNull valueObject then
                ProjectionReference.Untracked,
                context

            else

                match
                    context.references
                    |> List.tryFind (fun (knownObject, _) ->
                        obj.ReferenceEquals(
                            knownObject,
                            valueObject
                        )
                    )
                with

                | Some (_, referenceId) ->

                    ProjectionReference.RepeatedOccurrence referenceId,
                    context

                | None ->

                    let referenceId =
                        context.nextReferenceId

                    ProjectionReference.FirstOccurrence referenceId,
                    {
                        references =
                            (valueObject, referenceId)
                            :: context.references

                        nextReferenceId =
                            referenceId + 1
                    }
  
// -----------------------------------------------------------------------------
// Projection
//
// This is the result context used when an exact quotation of 'ValueType cannot
// be constructed.
//
// -----------------------------------------------------------------------------
type Projection<'ValueType> =
    | NullProduct of
        projectionSource : 'ValueType
    /// An F# record whose original nominal value could not be reconstructed.
    | RecordProduct of
        projectionSource : 'ValueType

    /// An ordinary CLR class or struct whose original nominal value could not
    /// be reconstructed.
    | PocoProduct of
        projectionSource : 'ValueType

    /// A tuple whose original tuple could not be reconstructed because one or
    /// more of its elements required projection.
    | TupleProduct of
        projectionSource : 'ValueType

    /// An F# discriminated union whose original nominal value could not be
    /// reconstructed.
    | UnionProduct of
        projectionSource : 'ValueType

    /// An enumerable whose original container could not be reconstructed.
    | EnumerableProduct of
        projectionSource : 'ValueType
    | RuntimeProduct of
        projectionSource : 'ValueType
    static member projectionSourceType =
        typeof<'ValueType>

    member this.projectionSource =
        match this with
        | NullProduct projectionSource
        | RecordProduct projectionSource
        | PocoProduct projectionSource
        | TupleProduct projectionSource
        | UnionProduct projectionSource
        | EnumerableProduct projectionSource -> projectionSource
        | RuntimeProduct projectionSource -> projectionSource

    static member private namedValue
        (name : string)
        (valueExpression : Expr)
        : Expr
        =

        Expr.NewTuple [
            Expr.Value name
            valueExpression
        ]

    /// Represents one structural level as one heterogeneous product.
    ///
    /// Zero values become unit.
    /// One value remains that value.
    /// Multiple values become one n-ary tuple.
    static member private projectedValues
        (expressions : Expr list)
        : Expr
        =

        match expressions with
        | [] ->
            Expr.Value(())

        | [expression] ->
            expression

        | expressions ->
            Expr.NewTuple expressions

    static member private referenceExpression
        (referenceId : int)
        : Expr
        =

        Projection<'ValueType>.namedValue
            "$ref"
            (Expr.Value referenceId)

    static member private identifiedProjectedValues
        (referenceId : int option)
        (expressions : Expr list)
        : Expr
        =

        let expressions =
            match referenceId with
            | Some referenceId ->
                Projection<'ValueType>.namedValue
                    "$id"
                    (Expr.Value referenceId)
                :: expressions

            | None ->
                expressions

        Projection<'ValueType>.projectedValues
            expressions

    static member usableMember
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : bool
        =

        memberShape.IsPublic
        &&
        match memberShape.MemberInfo with
        | :? PropertyInfo as propertyInfo ->
            propertyInfo.GetIndexParameters().Length = 0

        | _ ->
            true

    static member private projectMemberValue
        (context : ProjectionContext)
        (projectionSource : 'SourceType)
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : Expr * ProjectionContext
        =

        memberShape.Accept {
            new IReadOnlyMemberVisitor<'SourceType, Expr * ProjectionContext> with

                member _.Visit<'MemberType>
                    (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                    =

                    let memberValueResult : Result<'MemberType, exn> =
                        try
                            memberShape.Get projectionSource
                            |> Ok

                        with exception_ ->
                            Error exception_

                    match memberValueResult with

                    | Error _ ->

                        let noneExpression : Expr<'MemberType option> =
                            <@ None @>

                        noneExpression :> Expr,
                        context

                    | Ok memberValue
                        when obj.ReferenceEquals(box memberValue, null) ->

                        let noneExpression : Expr<'MemberType option> =
                            <@ None @>

                        noneExpression :> Expr,
                        context

                    | Ok memberValue ->

                        CodeQuotation<'MemberType>.expressionWithProjectionContext
                            context
                            memberValue
        }
    static member private projectMember
        (context : ProjectionContext)
        (projectionSource : 'SourceType)
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : Expr * ProjectionContext
        =

        let memberExpression, context =
            Projection<'ValueType>.projectMemberValue
                context
                projectionSource
                memberShape

        Projection<'ValueType>.namedValue
            memberShape.Label
            memberExpression,
        context
    static member private projectMembers
        (context : ProjectionContext)
        (referenceId : int option)
        (projectionSource : 'SourceType)
        (members : IShapeReadOnlyMember<'SourceType> array)
        : Expr * ProjectionContext
        =

        let expressions, context =
            members
            |> Array.filter Projection<'ValueType>.usableMember
            |> Array.fold
                (fun (expressions, context) memberShape ->

                    let memberExpression, context =
                        Projection<'ValueType>.projectMember
                            context
                            projectionSource
                            memberShape

                    memberExpression :: expressions,
                    context
                )
                ([], context)

        let expression =
            expressions
            |> List.rev
            |> Projection<'ValueType>.identifiedProjectedValues
                referenceId

        expression,
        context
    static member private projectTupleElements
        (context : ProjectionContext)
        (referenceId : int option)
        (projectionSource : 'SourceType)
        (elements : IShapeReadOnlyMember<'SourceType> array)
        : Expr * ProjectionContext
        =

        let expressions, context =
            elements
            |> Array.fold
                (fun (expressions, context) elementShape ->

                    let elementExpression, context =
                        Projection<'ValueType>.projectMemberValue
                            context
                            projectionSource
                            elementShape

                    elementExpression :: expressions,
                    context
                )
                ([], context)

        let expression =
            expressions
            |> List.rev
            |> Projection<'ValueType>.identifiedProjectedValues
                referenceId

        expression,
        context

    static member private tryNamedPathExpression<'SourceType>
        (projectionSource : 'SourceType)
        (path : string list)
        : Expr option
        =

        if obj.ReferenceEquals(box projectionSource, null) then

            match path with
            | [] ->

                let noneExpression : Expr<'SourceType option> =
                    <@ None @>

                noneExpression :> Expr
                |> Some

            | _ ->
                None

        else

            match path with

            | [] ->

                projectionSource
                |> CodeQuotation<'SourceType>.lift
                |> CodeQuotation<'SourceType>.lower
                |> Some

            | memberName :: remainingPath ->

                let tryMember
                    (members : IShapeReadOnlyMember<'SourceType> array)
                    =

                    members
                    |> Array.filter Projection<'SourceType>.usableMember
                    |> Array.tryFind (fun memberShape ->
                        memberShape.Label = memberName
                    )
                    |> Option.bind (fun memberShape ->

                        memberShape.Accept {
                            new IReadOnlyMemberVisitor<'SourceType, Expr option> with

                                member _.Visit<'MemberType>
                                    (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                                    =
                                    let memberValueResult : Result<'MemberType, exn> =
                                        try
                                            memberShape.Get projectionSource
                                            |> Ok

                                        with exception_ ->
                                            Error exception_

                                    match memberValueResult with

                                    | Error _ ->

                                        match remainingPath with
                                        | [] ->

                                            let noneExpression : Expr<'MemberType option> =
                                                <@ None @>

                                            noneExpression :> Expr
                                            |> Some

                                        | _ ->
                                            None

                                    | Ok memberValue
                                        when obj.ReferenceEquals(box memberValue, null) ->

                                        match remainingPath with
                                        | [] ->

                                            let noneExpression : Expr<'MemberType option> =
                                                <@ None @>

                                            noneExpression :> Expr
                                            |> Some

                                        | _ ->
                                            None

                                    | Ok memberValue ->

                                        Projection<'MemberType>.tryNamedPathExpression
                                            memberValue
                                            remainingPath
                        }
                    )

                match shapeof<'SourceType> with

                | Shape.FSharpRecord
                    (:? ShapeFSharpRecord<'SourceType> as recordShape) ->

                    recordShape.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'SourceType>
                    )
                    |> tryMember

                | Shape.Poco
                    (:? ShapePoco<'SourceType> as pocoShape) ->

                    let publicFields : IShapeReadOnlyMember<'SourceType> array =
                        pocoShape.Fields
                        |> Array.map (fun field ->
                            field :> IShapeReadOnlyMember<'SourceType>
                        )

                    let properties : IShapeReadOnlyMember<'SourceType> array =
                        pocoShape.Properties

                    Array.append
                        publicFields
                        properties
                    |> tryMember

                | Shape.FSharpUnion
                    (:? ShapeFSharpUnion<'SourceType> as unionShape) ->

                    let caseIndex =
                        unionShape.GetTag projectionSource

                    let activeCase =
                        unionShape.UnionCases.[caseIndex]

                    if memberName = "$case" then

                        match remainingPath with

                        | [] ->
                            Expr.Value activeCase.CaseInfo.Name
                            |> Some

                        | _ ->
                            None

                    else

                        activeCase.Fields
                        |> Array.map (fun field ->
                            field :> IShapeReadOnlyMember<'SourceType>
                        )
                        |> tryMember

                | _ ->

                    let valueObject =
                        box projectionSource

                    let runtimeType =
                        valueObject.GetType()

                    if runtimeType <> typeof<'SourceType> then

                        TypeShape.FromValue(valueObject).Accept {
                            new ITypeVisitor<Expr option> with

                                member _.Visit<'RuntimeType>() =

                                    let runtimeValue : 'RuntimeType =
                                        valueObject
                                        |> unbox<'RuntimeType>

                                    Projection<'RuntimeType>.tryNamedPathExpression
                                        runtimeValue
                                        path
                        }

                    else
                        None

    member internal this.expressionWithContext
        (context : ProjectionContext)
        : Expr * ProjectionContext
        =
        match this with

        | NullProduct _ ->

            let noneExpression : Expr<'ValueType option> =
                <@ None @>

            noneExpression :> Expr,
            context

        | RuntimeProduct projectionSource ->

            TypeShape.FromValue(box projectionSource).Accept {
                new ITypeVisitor<Expr * ProjectionContext> with

                    member _.Visit<'RuntimeType>() =

                        let runtimeValue : 'RuntimeType =
                            projectionSource
                            |> box
                            |> unbox<'RuntimeType>

                        CodeQuotation<'RuntimeType>.expressionWithProjectionContext
                            context
                            runtimeValue
            }

        | _ ->

            let projectionSource =
                this.projectionSource

            let projectionReference, context =
                ProjectionContext.classify
                    projectionSource
                    context

            match projectionReference with

            | ProjectionReference.RepeatedOccurrence referenceId ->

                Projection<'ValueType>.referenceExpression referenceId,
                context

            | ProjectionReference.Untracked
            | ProjectionReference.FirstOccurrence _ ->

                let referenceId =
                    match projectionReference with

                    | ProjectionReference.FirstOccurrence referenceId ->
                        Some referenceId

                    | ProjectionReference.Untracked ->
                        None

                    | ProjectionReference.RepeatedOccurrence _ ->
                        None
                match this with

                | RecordProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.FSharpRecord (:? ShapeFSharpRecord<'ValueType> as recordShape) ->

                        recordShape.Fields
                        |> Array.map (fun field ->
                            field :> IShapeReadOnlyMember<'ValueType>
                        )
                        |> Projection<'ValueType>.projectMembers
                            context
                            referenceId
                            projectionSource

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be an F# record."

                | PocoProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.Poco (:? ShapePoco<'ValueType> as pocoShape) ->

                        let publicFields : IShapeReadOnlyMember<'ValueType> array =
                            pocoShape.Fields
                            |> Array.map (fun field ->
                                field :> IShapeReadOnlyMember<'ValueType>
                            )

                        let properties : IShapeReadOnlyMember<'ValueType> array =
                            pocoShape.Properties

                        Array.append
                            publicFields
                            properties
                        |> Projection<'ValueType>.projectMembers
                            context
                            referenceId
                            projectionSource

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be a POCO."

                | TupleProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.Tuple (:? ShapeTuple<'ValueType> as tupleShape) ->

                        tupleShape.Elements
                        |> Array.map (fun element ->
                            element :> IShapeReadOnlyMember<'ValueType>
                        )
                        |> Projection<'ValueType>.projectTupleElements
                            context
                            referenceId
                            projectionSource

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be a tuple."

                | UnionProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.FSharpUnion (:? ShapeFSharpUnion<'ValueType> as unionShape) ->

                        let caseIndex =
                            unionShape.GetTag projectionSource

                        let activeCase =
                            unionShape.UnionCases.[caseIndex]

                        let caseExpression =
                            Projection<'ValueType>.namedValue
                                "$case"
                                (Expr.Value activeCase.CaseInfo.Name)

                        let fieldExpressions, context =
                            activeCase.Fields
                            |> Array.map (fun field ->
                                field :> IShapeReadOnlyMember<'ValueType>
                            )
                            |> Array.filter Projection<'ValueType>.usableMember
                            |> Array.fold
                                (fun (expressions, context) fieldShape ->

                                    let fieldExpression, context =
                                        Projection<'ValueType>.projectMember
                                            context
                                            projectionSource
                                            fieldShape

                                    fieldExpression :: expressions,
                                    context
                                )
                                ([], context)

                        let expression =
                            caseExpression
                            :: List.rev fieldExpressions
                            |> Projection<'ValueType>.identifiedProjectedValues
                                referenceId

                        expression,
                        context

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be an F# union."

                | EnumerableProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.Enumerable enumerableShape ->

                        enumerableShape.Accept {
                            new IEnumerableVisitor<Expr * ProjectionContext> with

                                member _.Visit<'Enumerable, 'Element when 'Enumerable :> seq<'Element>>() =

                                    let enumerableValue : 'Enumerable =
                                        projectionSource
                                        |> box
                                        |> unbox<'Enumerable>

                                    let expressions, context =
                                        enumerableValue
                                        |> Seq.fold
                                            (fun (expressions, context) element ->

                                                let elementExpression, context =
                                                    CodeQuotation<'Element>.expressionWithProjectionContext
                                                        context
                                                        element

                                                elementExpression :: expressions,
                                                context
                                            )
                                            ([], context)

                                    let expression =
                                        expressions
                                        |> List.rev
                                        |> Projection<'ValueType>.identifiedProjectedValues
                                            referenceId

                                    expression,
                                    context
                        }

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be enumerable."
                | NullProduct _
                | RuntimeProduct _ ->
                    invalidOp "Projection case was expected to be handled before reference classification."
    member this.projectionExpression : Expr =

        let expression, _ =
            this.expressionWithContext
                ProjectionContext.empty

        expression
    member this.projectionType =
        this.projectionExpression.Type

    /// Names of the immediate named members represented by this projection.
    ///
    /// Positional projections such as tuples and enumerables have no member
    /// names and therefore return an empty list.
    member this.projectionMemberNames : string list =

        let projectionSource =
            this.projectionSource

        match this with
        | RuntimeProduct projectionSource ->

            TypeShape.FromValue(box projectionSource).Accept {
                new ITypeVisitor<string list> with

                    member _.Visit<'RuntimeType>() =

                        let runtimeValue : 'RuntimeType =
                            projectionSource
                            |> box
                            |> unbox<'RuntimeType>

                        runtimeValue
                        |> Projection<'RuntimeType>.ofValue
                        |> fun projection ->
                            projection.projectionMemberNames
            }
        | RecordProduct _ ->

            match shapeof<'ValueType> with
            | Shape.FSharpRecord (:? ShapeFSharpRecord<'ValueType> as recordShape) ->

                recordShape.Fields
                |> Array.map (fun field ->
                    field :> IShapeReadOnlyMember<'ValueType>
                )
                |> Array.filter Projection<'ValueType>.usableMember
                |> Array.map _.Label
                |> Array.toList

            | _ ->
                []

        | PocoProduct _ ->

            match shapeof<'ValueType> with
            | Shape.Poco (:? ShapePoco<'ValueType> as pocoShape) ->

                let publicFields : IShapeReadOnlyMember<'ValueType> array =
                    pocoShape.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'ValueType>
                    )

                Array.append
                    publicFields
                    pocoShape.Properties
                |> Array.filter Projection<'ValueType>.usableMember
                |> Array.map _.Label
                |> Array.toList

            | _ ->
                []

        | UnionProduct _ ->

            match shapeof<'ValueType> with
            | Shape.FSharpUnion (:? ShapeFSharpUnion<'ValueType> as unionShape) ->

                let activeCase =
                    unionShape.UnionCases.[unionShape.GetTag projectionSource]

                "$case"
                ::
                (
                    activeCase.Fields
                    |> Array.map (fun field ->
                        field :> IShapeReadOnlyMember<'ValueType>
                    )
                    |> Array.filter Projection<'ValueType>.usableMember
                    |> Array.map _.Label
                    |> Array.toList
                )

            | _ ->
                []

        | NullProduct _ 
        | TupleProduct _
        | EnumerableProduct _ ->
            []

    /// Retrieves a lowered expression by following named members of the
    /// original structural value.
    ///
    /// This does not inspect or reverse-engineer the evaluated tuple
    /// representation. It traverses the original typed source.
    member this.tryPathExpression
        (path : string list)
        : Expr option
        =

        match path with
        | [] ->
            Some this.projectionExpression

        | path ->
            Projection<'ValueType>.tryNamedPathExpression
                this.projectionSource
                path

    member this.tryMemberExpression
        (memberName : string)
        : Expr option
        =

        this.tryPathExpression [memberName]

    member this.tryPathValueObject
        (path : string list)
        : obj option
        =

        this.tryPathExpression path
        |> Option.map LeafExpressionConverter.EvaluateQuotation

    member this.tryMemberValueObject
        (memberName : string)
        : obj option
        =

        this.tryPathValueObject [memberName]

    static member ofValue
        (projectionSource : 'ValueType)
        : Projection<'ValueType>
        =

        let valueObject =
            box projectionSource

        if isNull valueObject then

            NullProduct projectionSource

        else

            match shapeof<'ValueType> with

            | Shape.FSharpRecord (:? ShapeFSharpRecord<'ValueType>) ->
                RecordProduct projectionSource

            | Shape.Poco (:? ShapePoco<'ValueType>) ->
                PocoProduct projectionSource

            | Shape.Tuple (:? ShapeTuple<'ValueType>) ->
                TupleProduct projectionSource

            | Shape.FSharpUnion (:? ShapeFSharpUnion<'ValueType>) ->
                UnionProduct projectionSource

            | Shape.Enumerable _ ->
                EnumerableProduct projectionSource

            | shape ->

                let runtimeType =
                    valueObject.GetType()

                if runtimeType <> typeof<'ValueType> then

                    RuntimeProduct projectionSource

                else

                    invalidOp
                        $"Projection does not yet support {shape.Type.FullName}"
    member internal this.dynamicValueObjectWithContext
        (context : ProjectionContext)
        : obj * ProjectionContext
        =

        match this with

        | NullProduct _ ->

            null,
            context

        | RuntimeProduct projectionSource ->

            TypeShape.FromValue(box projectionSource).Accept {
                new ITypeVisitor<obj * ProjectionContext> with

                    member _.Visit<'RuntimeType>() =

                        let runtimeValue : 'RuntimeType =
                            projectionSource
                            |> box
                            |> unbox<'RuntimeType>

                        CodeQuotation<'RuntimeType>.valueObjectWithProjectionContext
                            context
                            runtimeValue
            }

        | _ ->

            let projectionSource =
                this.projectionSource

            let projectionReference, context =
                ProjectionContext.classify
                    projectionSource
                    context

            match projectionReference with

            | ProjectionReference.RepeatedOccurrence referenceId ->

                ImmutableDynamicObj(
                    Map [
                        ("$ref", box referenceId)
                    ]
                )
                |> box,
                context

            | ProjectionReference.Untracked
            | ProjectionReference.FirstOccurrence _ ->

                let referenceId =
                    match projectionReference with
                    | ProjectionReference.FirstOccurrence referenceId ->
                        Some referenceId

                    | ProjectionReference.Untracked ->
                        None

                    | ProjectionReference.RepeatedOccurrence _ ->
                        None

                match this with

                | RecordProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.FSharpRecord
                        (:? ShapeFSharpRecord<'ValueType> as recordShape) ->

                        let dynamicObject, context =
                            recordShape.Fields
                            |> Array.map (fun field ->
                                field :> IShapeReadOnlyMember<'ValueType>
                            )
                            |> Projection<'ValueType>.dynamicMembers context referenceId projectionSource

                        box dynamicObject,
                        context

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be an F# record."

                | PocoProduct _ ->

                    match shapeof<'ValueType> with

                    | Shape.Poco
                        (:? ShapePoco<'ValueType> as pocoShape) ->

                        let publicFields : IShapeReadOnlyMember<'ValueType> array =
                            pocoShape.Fields
                            |> Array.map (fun field ->
                                field :> IShapeReadOnlyMember<'ValueType>
                            )

                        let properties : IShapeReadOnlyMember<'ValueType> array =
                            pocoShape.Properties

                        let dynamicObject, context =
                            Array.append
                                publicFields
                                properties
                            |> Projection<'ValueType>.dynamicMembers
                                context
                                referenceId
                                projectionSource

                        box dynamicObject,
                        context

                    | _ ->
                        invalidOp
                            $"Projection expected {typeof<'ValueType>.FullName} to be a POCO."

                // TupleProduct, UnionProduct, EnumerableProduct follow
                // the same pattern.

                | NullProduct _
                | RuntimeProduct _ ->

                    invalidOp
                        "Projection case should already have been handled."

    member internal this.dynamicObjectWithContext
        (context : ProjectionContext)
        : ImmutableDynamicObj * ProjectionContext
        =

        let valueObject, context =
            this.dynamicValueObjectWithContext context

        unbox<ImmutableDynamicObj> valueObject,
        context
    static member private dynamicMemberValue
        (context : ProjectionContext)
        (projectionSource : 'SourceType)
        (memberShape : IShapeReadOnlyMember<'SourceType>)
        : (string * obj) * ProjectionContext
        =

        memberShape.Accept {
            new IReadOnlyMemberVisitor< 'SourceType, (string * obj) * ProjectionContext > with

                member _.Visit<'MemberType>
                    (memberShape : ReadOnlyMember<'SourceType, 'MemberType>)
                    =

                    let memberValueResult : Result<'MemberType, exn> =
                        try
                            memberShape.Get projectionSource
                            |> Ok

                        with exception_ ->
                            Error exception_

                    match memberValueResult with

                    | Error _ ->

                        (memberShape.Label, null),
                        context

                    | Ok memberValue
                        when obj.ReferenceEquals(box memberValue, null) ->

                        (memberShape.Label, null),
                        context

                    | Ok memberValue ->

                        let valueObject, context =
                            CodeQuotation<'MemberType>.valueObjectWithProjectionContext context memberValue

                        (memberShape.Label, valueObject),
                        context
        }
    static member private dynamicMembers
        (context : ProjectionContext)
        (referenceId : int option)
        (projectionSource : 'SourceType)
        (members : IShapeReadOnlyMember<'SourceType> array)
        : ImmutableDynamicObj * ProjectionContext
        =

        let properties, context =
            members
            |> Array.filter Projection<'ValueType>.usableMember
            |> Array.fold
                (fun (properties, context) memberShape ->

                    let property, context =
                        Projection<'ValueType>.dynamicMemberValue
                            context
                            projectionSource
                            memberShape

                    property :: properties,
                    context
                )
                ([], context)

        let properties =
            properties
            |> List.rev
            |> fun properties ->

                match referenceId with
                | Some referenceId ->
                    ("$id", box referenceId)
                    :: properties

                | None ->
                    properties

        ImmutableDynamicObj(
            properties
            |> Map.ofList
        ),
        context
// -----------------------------------------------------------------------------
// CodeQuotation
// -----------------------------------------------------------------------------

and CodeQuotation<'ValueType> =

    /// The original type can be reconstructed exactly.
    | DirectQuote of Expr<'ValueType>

    /// The original type cannot be reconstructed exactly and therefore needs
    /// to be structurally projected.
    | IndirectQuote of Projection<'ValueType>
    member this.fsharpTypeName = FSharpLiteral.stringifyType<'ValueType>

    static member  lift
        (value : 'ValueType)
        : CodeQuotation<'ValueType>
        =

        CodeQuotation<'ValueType>.ofValue
            value

    static member  lower (quote:CodeQuotation<'ValueType>) : Expr = 
            match quote with 

            | DirectQuote expression -> expression :> Expr

            | IndirectQuote projection -> projection.projectionExpression
    static member expression (value : 'ValueType) : Expr = CodeQuotation.lift value |> CodeQuotation.lower 

    static member internal expressionWithProjectionContext
        (context : ProjectionContext)
        (value : 'ValueType)
        : Expr * ProjectionContext
        =
        if obj.ReferenceEquals(box value, null) then

            let noneExpression : Expr<'ValueType option> =
                <@ None @>

            noneExpression :> Expr,
            context
        else
            match CodeQuotation<'ValueType>.tryDirect value with

            | Some expression ->
                expression :> Expr,
                context

            | None ->

                let projection =
                    Projection<'ValueType>.ofValue value

                projection.expressionWithContext
                    context
    static member inline tryValue
        (quote : CodeQuotation<'ValueType>)
        : 'ValueType option
        =
            match quote with 

            | DirectQuote expression -> 
                LeafExpressionConverter.EvaluateQuotation( expression )
                    :?> 'ValueType
                    |> Some
                
            | _ -> None
    static member inline project
        (quote : CodeQuotation<'ValueType>)
        : Projection<'ValueType>
        =
            match quote with 

            | DirectQuote expression -> 
                LeafExpressionConverter.EvaluateQuotation( expression )
                    :?> 'ValueType
                    |> Projection<'ValueType>.ofValue
                
            | IndirectQuote projection -> projection
    static member valueObject
        (quote : CodeQuotation<'ValueType>)
        : SemiStatic<'ValueType>
        =

        match quote with

        | DirectQuote expression ->

            expression
            |> LeafExpressionConverter.EvaluateQuotation
            :?> 'ValueType
            |> StaticObject

        | IndirectQuote projection ->

            let dynamicObject, _ =
                projection.dynamicObjectWithContext
                    ProjectionContext.empty

            DynamicObject dynamicObject
    member this.lowered = CodeQuotation.lower this
    member this.tryEvaluate = CodeQuotation.tryValue this
    member this.evaluated = CodeQuotation.valueObject this
    member this.projected = CodeQuotation.project this

    // Generic option traversal
    //
    // This is used whenever every constituent must be directly quotable for
    // the enclosing value itself to be directly quotable.
    // -------------------------------------------------------------------------

    static member private traverse<'Input, 'Output>
        (values : seq<'Input>)
        (mapping : 'Input -> 'Output option)
        : 'Output list option
        =

        values
        |> Seq.fold
            (fun state value ->

                match state with
                | None ->
                    None

                | Some results ->
                    match mapping value with
                    | Some result ->
                        Some (result :: results)

                    | None ->
                        None
            )
            (Some [])
        |> Option.map List.rev

    // -------------------------------------------------------------------------
    // Homogeneous structural values
    // -------------------------------------------------------------------------

    static member private ofHomogeneousElements<'Element>
        (elements : seq<'Element>)
        : Expr<'Element array> option
        =

        CodeQuotation<'ValueType>.traverse
            elements
            (fun element ->

                CodeQuotation<'Element>.tryDirect element
                |> Option.map (fun expression ->
                    expression :> Expr
                )
            )
        |> Option.map (fun elementExpressions ->

            Expr.NewArray(
                typeof<'Element>,
                elementExpressions
            )
            |> Expr.Cast<'Element array>
        )

    // -------------------------------------------------------------------------
    // HList
    //
    // Some Expr list means:
    //     every heterogeneous field could be reconstructed exactly.
    //
    // None means:
    //     at least one field requires projection, so anything containing this
    //     HList cannot itself be a DirectQuote.
    // -------------------------------------------------------------------------

    static member private ofHeterogenousList<'Fields>
        (fieldValues : 'Fields HList)
        : Expr list option
        =

        let folder =
            {
                new HListFolder<Expr list option> with

                    member _.Folder<'FieldType>
                        (expressions : Expr list option)
                        (fieldValue : 'FieldType)
                        =

                        match expressions with
                        | None ->
                            None

                        | Some expressions ->

                            match
                                CodeQuotation<'FieldType>.tryDirect
                                    fieldValue
                            with
                            | Some fieldExpression ->
                                Some (
                                    (fieldExpression :> Expr)
                                    :: expressions
                                )

                            | None ->
                                None
            }

        fieldValues
        |> HList.fold folder (Some [])
        |> Option.map List.rev

    // -------------------------------------------------------------------------
    // Union case arguments
    // -------------------------------------------------------------------------

    static member private unionCaseArguments<'Payload>
        (caseInfo : UnionCaseInfo)
        (payload : 'Payload)
        : Expr list option
        =

        let fields =
            caseInfo.GetFields()

        match fields.Length with

        // ShapeSifter represents a zero-field union case with unit,
        // but Expr.NewUnionCase needs no argument expressions.
        | 0 ->
            Some []

        // ShapeSifter represents a one-field union case directly by the
        // field's type.
        | 1 ->

            CodeQuotation<'Payload>.tryDirect payload
            |> Option.map (fun expression ->
                [
                    expression :> Expr
                ]
            )

        // ShapeSifter represents multiple union-case fields as a tuple.
        // Break that tuple back into its individual field expressions.
        | _ ->

            match tType<'Payload> with

            | TType.Tuple tuple ->

                {
                    new TupleConvEvaluator< 'Payload, Expr list option > with

                        member _.Eval<'UnionCaseFields>
                            (
                                _fieldTypes :
                                    TypeList<'UnionCaseFields>
                            )
                            (
                                conversion :
                                    Conv<
                                        'Payload,
                                        'UnionCaseFields HList
                                    >
                            )
                            =

                            let fieldValues :
                                'UnionCaseFields HList
                                =
                                conversion.To payload

                            CodeQuotation<'Payload>
                                .ofHeterogenousList
                                    fieldValues
                }
                |> tuple.Apply

            | _ ->

                invalidOp
                    $"Expected the payload of union case {caseInfo.Name} to be a tuple."

    // -------------------------------------------------------------------------
    // HUnion
    // -------------------------------------------------------------------------

    static member private ofHeterogenousUnion<'Cases>
        (caseIndex : int)
        (caseData : UnionTypeField list)
        (unionValue : 'Cases HUnion)
        : Expr option
        =

        match
            unionValue
            |> HUnion.toTypeList
            |> TypeList.split
        with

        | Choice1Of2 _ ->

            invalidOp
                "A discriminated union cannot have zero cases."

        | Choice2Of2 cons ->

            {
                new TypeListConsEvaluator< 'Cases, Expr option > with

                    member _.Eval<'Payload, 'Tail>
                        (
                            _tailTypes :
                                'Tail TypeList
                        )
                        (
                            typeEquality :
                                Teq<
                                    'Cases,
                                    'Payload -> 'Tail
                                >
                        )
                        =

                        let expandedUnion :
                            ('Payload -> 'Tail) HUnion
                            =
                            unionValue
                            |> Teq.castTo
                                (
                                    HUnion.cong
                                        typeEquality
                                )

                        match HUnion.split expandedUnion with

                        | Choice1Of2 payload ->

                            let caseInfo =
                                caseData
                                |> List.item caseIndex
                                |> fun case ->
                                    case.RawCase

                            CodeQuotation<'ValueType>
                                .unionCaseArguments
                                    caseInfo
                                    payload
                            |> Option.map
                                (fun arguments ->

                                    Expr.NewUnionCase(
                                        caseInfo,
                                        arguments
                                    )
                                )

                        | Choice2Of2 tail ->

                            CodeQuotation<'ValueType>
                                .ofHeterogenousUnion
                                    (caseIndex + 1)
                                    caseData
                                    tail
            }
            |> cons.Apply

    // -------------------------------------------------------------------------
    // Direct quotation
    //
    // This contains the existing ShapeSifter quotation machinery.
    //
    // Crucially:
    //
    //     Some Expr<'ValueType>
    //
    // means the exact nominal type could be reconstructed.
    //
    //     None
    //
    // means exact reconstruction is impossible somewhere in this value's
    // structure and the public operation must return IndirectQuote.
    // -------------------------------------------------------------------------
    
    static member private tryDirect
        (value : 'ValueType)
        : Expr<'ValueType> option
        =

        let expression : Expr option =

            match tType<'ValueType> with

            // -----------------------------------------------------------------
            // Explicit external-type reconstruction
            // -----------------------------------------------------------------

            | TType.Teq TType.Url typeEquality ->

                let typeValue : Url =
                    value
                    |> Teq.castTo typeEquality

                match CodeQuotation<string>.tryDirect (typeValue.ToString()) with

                | Some stringExpression ->

                    <@ Url.Parse %stringExpression @>
                    :> Expr
                    |> Some

                | None ->
                    None
            | TType.Teq TType.IriReference typeEquality ->

                let typeValue : IriReference =
                    value
                    |> Teq.castTo typeEquality

                match CodeQuotation<string>.tryDirect (typeValue.ToString()) with

                | Some stringExpression ->

                    <@ IriReference %stringExpression @>
                    :> Expr
                    |> Some

                | None ->
                    None
            | TType.Teq TType.MimeType typeEquality ->

                let typeValue : MimeType =
                    value
                    |> Teq.castTo typeEquality

                match CodeQuotation<string>.tryDirect (typeValue.ToString()) with

                | Some stringExpression ->

                    <@ MimeType.Parse %stringExpression @>
                    :> Expr
                    |> Some

                | None ->
                    None

            | TType.Teq TType.TldRule typeEquality ->

                let typeValue : TldRule =
                    value
                    |> Teq.castTo typeEquality

                let valueString =
                    match typeValue.Type with

                    | TldRuleType.WildcardException ->
                        "!" + typeValue.Name

                    | _ ->
                        typeValue.Name

                match
                    CodeQuotation<string>.tryDirect valueString,
                    CodeQuotation<TldRuleDivision>.tryDirect typeValue.Division
                with

                | Some ruleDataExpression,
                  Some divisionExpression ->

                    <@
                        TldRule(
                            %ruleDataExpression,
                            %divisionExpression
                        )
                    @>
                    :> Expr
                    |> Some

                | _ ->
                    None

            // -----------------------------------------------------------------
            // CLR enums
            // -----------------------------------------------------------------

            | TType'Enum ->

                Expr.Value(
                    box value,
                    typeof<'ValueType>
                )
                |> Some

            // -----------------------------------------------------------------
            // Primitive/direct values
            // -----------------------------------------------------------------
            | TType'Byte typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some
            | TType.Bool typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.Int typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.Int64 typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.Float typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.String typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.Unit typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.DateTime typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            | TType.TimeSpan typeEquality ->

                value
                |> Teq.castTo typeEquality
                |> Expr.Value
                |> Some

            // -----------------------------------------------------------------
            // Array
            // -----------------------------------------------------------------

            | TType.Array array ->

                {
                    new ArrayTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Element>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element array
                                    >
                            )
                            =

                            let arrayValue :
                                'Element array
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    arrayValue
                            |> Option.map
                                (fun expression ->
                                    expression :> Expr
                                )
                }
                |> array.Apply

            // -----------------------------------------------------------------
            // Seq
            //
            // A seq is materialized into an array expression and then coerced
            // back to seq<'Element>.
            // -----------------------------------------------------------------

            | TType.Seq sequence ->

                {
                    new SeqTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Element>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element seq
                                    >
                            )
                            =

                            let sequenceValue :
                                'Element seq
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    sequenceValue
                            |> Option.map
                                (fun arrayExpression ->

                                    Expr.Coerce(
                                        arrayExpression,
                                        typeof<'Element seq>
                                    )
                                )
                }
                |> sequence.Apply

            // -----------------------------------------------------------------
            // ResizeArray
            // -----------------------------------------------------------------

            | TType.ResizeArray resizeArray ->

                {
                    new ResizeArrayTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Element>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element ResizeArray
                                    >
                            )
                            =

                            let resizeArrayValue :
                                'Element ResizeArray
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    resizeArrayValue
                            |> Option.map
                                (fun arrayExpression ->

                                    let sequenceExpression :
                                        Expr
                                        =
                                        Expr.Coerce(
                                            arrayExpression,
                                            typeof<'Element seq>
                                        )

                                    let constructor =
                                        typeof< ResizeArray<'Element> > .GetConstructor(
                                                [|
                                                    typeof<
                                                        'Element seq
                                                    >
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> resizeArray.Apply

            // -----------------------------------------------------------------
            // Set
            // -----------------------------------------------------------------

            | TType.Set set ->

                {
                    new SetTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<
                            'Element
                                when 'Element : comparison
                        >
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        'Element Set
                                    >
                            )
                            =

                            let setValue :
                                'Element Set
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            CodeQuotation<'ValueType>
                                .ofHomogeneousElements
                                    setValue
                            |> Option.map
                                (fun arrayExpression ->

                                    let sequenceExpression :
                                        Expr
                                        =
                                        Expr.Coerce(
                                            arrayExpression,
                                            typeof<'Element seq>
                                        )

                                    let constructor =
                                        typeof< Set<'Element> >
                                            .GetConstructor(
                                                [|
                                                    typeof<
                                                        'Element seq
                                                    >
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> set.Apply

            // -----------------------------------------------------------------
            // Map
            // -----------------------------------------------------------------

            | TType.Map map ->

                {
                    new MapTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<
                            'Key,
                            'Value
                                when 'Key : comparison
                        >
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        Map<'Key, 'Value>
                                    >
                            )
                            =

                            let mapValue :
                                Map<'Key, 'Value>
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            let pairExpressions =
                                CodeQuotation<'ValueType>
                                    .traverse
                                        mapValue
                                        (fun pair ->

                                            match
                                                CodeQuotation<'Key>
                                                    .tryDirect
                                                        pair.Key,
                                                CodeQuotation<'Value>
                                                    .tryDirect
                                                        pair.Value
                                            with

                                            | Some keyExpression,
                                              Some valueExpression ->

                                                Expr.NewTuple(
                                                    [
                                                        keyExpression
                                                        :> Expr

                                                        valueExpression
                                                        :> Expr
                                                    ]
                                                )
                                                |> Some

                                            | _ ->
                                                None
                                        )

                            pairExpressions
                            |> Option.map
                                (fun pairExpressions ->

                                    let pairType =
                                        typeof<
                                            'Key * 'Value
                                        >

                                    let arrayExpression =
                                        Expr.NewArray(
                                            pairType,
                                            pairExpressions
                                        )

                                    let sequenceExpression =
                                        Expr.Coerce(
                                            arrayExpression,
                                            typeof<
                                                seq<'Key * 'Value>
                                            >
                                        )

                                    let constructor =
                                        typeof< Map<'Key, 'Value> >
                                            .GetConstructor(
                                                [|
                                                    typeof< seq< 'Key * 'Value > >
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> map.Apply

            // -----------------------------------------------------------------
            // Dictionary
            // -----------------------------------------------------------------

            | TType.Dictionary dictionary ->

                {
                    new DictionaryTeqEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Key, 'Value>
                            (
                                typeEquality :
                                    Teq<
                                        'ValueType,
                                        Generic.Dictionary< 'Key, 'Value > 
                                        >
                            )
                            =

                            let dictionaryValue :
                                Generic.Dictionary<'Key, 'Value>
                                =
                                value
                                |> Teq.castTo
                                    typeEquality

                            if
                                not (
                                    obj.ReferenceEquals(
                                        dictionaryValue.Comparer,
                                        Generic.EqualityComparer< 'Key >.Default
                                    )
                                )
                            then

                                invalidOp
                                    $"CodeQuotation of Dictionary<{typeof<'Key>.FullName}, {typeof<'Value>.FullName}> with a custom comparer is not yet supported."

                            let keyValuePairConstructor =
                                typeof< Generic.KeyValuePair< 'Key, 'Value > >
                                    .GetConstructor(
                                        [|
                                            typeof<'Key>
                                            typeof<'Value>
                                        |]
                                    )

                            let pairExpressions =
                                CodeQuotation<'ValueType>
                                    .traverse
                                        dictionaryValue
                                        (fun pair ->

                                            match
                                                CodeQuotation<'Key>
                                                    .tryDirect
                                                        pair.Key,
                                                CodeQuotation<'Value>
                                                    .tryDirect
                                                        pair.Value
                                            with

                                            | Some keyExpression,
                                              Some valueExpression ->

                                                Expr.NewObject(
                                                    keyValuePairConstructor,
                                                    [
                                                        keyExpression
                                                        :> Expr

                                                        valueExpression
                                                        :> Expr
                                                    ]
                                                )
                                                |> Some

                                            | _ ->
                                                None
                                        )

                            pairExpressions
                            |> Option.map
                                (fun pairExpressions ->

                                    let pairType =
                                        typeof< Generic.KeyValuePair< 'Key, 'Value > >

                                    let arrayExpression =
                                        Expr.NewArray(
                                            pairType,
                                            pairExpressions
                                        )

                                    let sequenceType =
                                        typeof< seq< Generic.KeyValuePair< 'Key, 'Value > > >

                                    let sequenceExpression =
                                        Expr.Coerce(
                                            arrayExpression,
                                            sequenceType
                                        )

                                    let constructor =
                                        typeof< Generic.Dictionary< 'Key, 'Value > >
                                            .GetConstructor(
                                                [|
                                                    sequenceType
                                                |]
                                            )

                                    Expr.NewObject(
                                        constructor,
                                        [
                                            sequenceExpression
                                        ]
                                    )
                                )
                }
                |> dictionary.Apply

            // -----------------------------------------------------------------
            // Fun
            //
            // Deliberately excluded for now.
            // -----------------------------------------------------------------

            // | Fun functionShape ->
            //     ...

            // -----------------------------------------------------------------
            // Tuple
            // -----------------------------------------------------------------

            | TType.Tuple tuple ->

                {
                    new TupleConvEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'TupleFields>
                            (
                                _fieldTypes :
                                    TypeList<'TupleFields>
                            )
                            (
                                conversion :
                                    Conv<
                                        'ValueType,
                                        'TupleFields HList
                                    >
                            )
                            =

                            let fieldValues :
                                'TupleFields HList
                                =
                                conversion.To value

                            CodeQuotation<'ValueType>
                                .ofHeterogenousList
                                    fieldValues
                            |> Option.map
                                Expr.NewTuple
                }
                |> tuple.Apply

            // -----------------------------------------------------------------
            // Record
            // -----------------------------------------------------------------

            | TType.Record record ->

                {
                    new RecordConvEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'RecordFields>
                            (
                                _fieldData :
                                    RecordTypeField list
                            )
                            (
                                _fieldTypes :
                                    TypeList<'RecordFields>
                            )
                            (
                                conversion :
                                    Conv<
                                        'ValueType,
                                        'RecordFields HList
                                    >
                            )
                            =

                            let fieldValues :
                                'RecordFields HList
                                =
                                conversion.To value

                            CodeQuotation<'ValueType>
                                .ofHeterogenousList
                                    fieldValues
                            |> Option.map
                                (fun fieldExpressions ->

                                    Expr.NewRecord(
                                        typeof<'ValueType>,
                                        fieldExpressions
                                    )
                                )
                }
                |> record.Apply

            // -----------------------------------------------------------------
            // Union
            //
            // This also accounts for Option, Choice and List.
            // -----------------------------------------------------------------

            | TType.Union union ->

                {
                    new UnionConvEvaluator< 'ValueType, Expr option > with

                        member _.Eval<'Cases>
                            (
                                caseData :
                                    UnionTypeField list
                            )
                            (
                                _caseTypes :
                                    TypeList<'Cases>
                            )
                            (
                                conversion :
                                    Conv<
                                        'ValueType,
                                        'Cases HUnion
                                    >
                            )
                            =

                            let unionValue :
                                'Cases HUnion
                                =
                                conversion.To value

                            CodeQuotation<'ValueType>
                                .ofHeterogenousUnion
                                    0
                                    caseData
                                    unionValue
                }
                |> union.Apply

            // -----------------------------------------------------------------
            // Exact quotation unavailable.
            //
            // This is no longer an exception.
            // It propagates outward until CodeQuotation.ofValue turns it into
            // IndirectQuote.
            // -----------------------------------------------------------------

            | _ ->
                None

        expression
        |> Option.map
            (fun expression ->
                Expr.Cast<'ValueType>
                    expression
            )

    // -------------------------------------------------------------------------
    // Public quotation operation
    // -------------------------------------------------------------------------

    static member ofValue
        (value : 'ValueType)
        : CodeQuotation<'ValueType>
        =

        match
            CodeQuotation<'ValueType>
                .tryDirect value
        with

        | Some expression ->

            DirectQuote expression

        | None ->

            value
            |> Projection<'ValueType>.ofValue
            |> IndirectQuote

    static member internal valueObjectWithProjectionContext
        (context : ProjectionContext)
        (value : 'ValueType)
        : obj * ProjectionContext
        =

        if obj.ReferenceEquals(box value, null) then

            null,
            context

        else

            match CodeQuotation<'ValueType>.tryDirect value with

            | Some _ ->

                box value,
                context

            | None ->

                let projection =
                    Projection<'ValueType>.ofValue value

                projection.dynamicValueObjectWithContext context
type Type with 
    member this.fsharpName = FSharpLiteral.stringifyTypeDynamic this

// Put the TypeProviderAssemblyAttribute in the runtime DLL, pointing to the design-time DLL
[<assembly: CompilerServices.TypeProviderAssembly("DoxAletheia.DesignTime.dll")>]
do ()
