// TODO add urn namespaces
// https://www.iana.org/assignments/urn-namespaces
#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"
#load "Ast.fsx"

open SharedKernel
open StringModule

#I @"D:\https\com\github\eristocrates\ipa\fsx\Sites"

#load @".paket/load/main.group.fsx"

open System
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
open Meziantou.Framework.DnsClient.Query
open IriTools

[<RequireQualifiedAccess>]
type IanaStatus =
    | Permanent
    | Provisional
    | Historical
    | UnknownStatus of string

type IanaScheme = {
    lexicalForm: string
    description: string option
    status: IanaStatus
    criSchemeNumber: int
}

let IanaSchemes =
    XmlProvider<UseOriginalNames=true, Sample= @"D:\https\org\iana\www\assignments\uri-schemes\uri-schemes.xml">
        .Load(@"D:\https\org\iana\www\assignments\uri-schemes\uri-schemes.xml")
        .registries
    |> Array.filter (fun registry -> registry.title = "Uniform Resource Identifier (URI) Schemes")
    |> Array.collect (fun schemeRegistry ->

        schemeRegistry.records
        |> Array.distinctBy (fun scheme -> scheme.value.Value.XElement.Value)
        |> Array.Parallel.filter (fun scheme -> not (scheme.value.Value.XElement.Value.Contains("OBSOLETE")))
        |> Array.Parallel.map (fun scheme ->

            let namespaceName = scheme.XElement.Name.NamespaceName
            let lexicalForm = scheme.value.Value.XElement.Value

            let description =
                if scheme.description.Value.Value.Value = lexicalForm then
                    None
                else
                    Some scheme.description.Value.Value.Value

            let status =
                match scheme.status.Value with
                | "Permanent" -> IanaStatus.Permanent
                | "Provisional" -> IanaStatus.Provisional
                | "Historical" -> IanaStatus.Historical
                | unknown -> IanaStatus.UnknownStatus unknown

            let criSchemeNumber = scheme.cri.Value

            {
                lexicalForm = lexicalForm
                description = description
                status = status
                criSchemeNumber = criSchemeNumber

            }))

let IanaSchemeByName =
    IanaSchemes
    |> Array.map (fun scheme -> scheme.lexicalForm, scheme)
    |> Map.ofArray

let IanaContentTypes =
    XmlProvider<UseOriginalNames=true, Sample= @"D:\https\org\iana\www\assignments\media-types\media-types.xml">
        .Load(@"D:\https\org\iana\www\assignments\media-types\media-types.xml")
        .registries
    |> Array.collect (fun registry -> registry.records |> Array.map (fun record -> record.file.Value))

let IanaMimes = IanaContentTypes |> Array.map (fun contentType -> MimeType.Parse contentType)

let IanaMimeByName =
    IanaMimes
    |> Array.map (fun mime -> $"{mime.MediaType}/{mime.SubType}", mime)
    |> Map.ofArray

type MimeType with
    member this.extension = this.GetFileTypeExtension(false)
    member this.dotExtension = this.GetFileTypeExtension(true)
    member this.asFileName = FileName.Create $"{this.SubType}.{this.extension}"

    member this.asRelativeFilePath =
        Path.Combine(this.MediaType, this.asFileName.WeakString)
        |> RelativeFilePath.Create

    static member mimeFilePath(filePath: AbsoluteFilePath) =
        let mimeType = IanaMimeByName[(MimeType.FromFileName filePath.WeakString).contentType]

        let absoluteDirectoryPath = (filePath.DirectoryPath / filePath.FileNameWithoutExtension).As<AbsoluteDirectoryPath>()

        absoluteDirectoryPath / mimeType.asRelativeFilePath

    member this.contentType = $"{this.MediaType}/{this.SubType}"

/// https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/MIME_types/Common_types
let commonContentTypes =
    set [
        "audio/aac"
        "application/x-abiword"
        "image/apng"
        "application/x-freearc"
        "image/avif"
        "video/x-msvideo"
        "application/vnd.amazon.ebook"
        "application/octet-stream"
        "image/bmp"
        "application/x-bzip"
        "application/x-bzip2"
        "application/x-cdf"
        "application/x-csh"
        "text/css"
        "text/csv"
        "application/msword"
        "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
        "application/vnd.ms-fontobject"
        "application/epub+zip"
        "application/gzip"
        "application/x-gzip"
        "image/gif"
        "text/html"
        "image/vnd.microsoft.icon"
        "text/calendar"
        "application/java-archive"
        "image/jpeg"
        "text/javascript"
        "application/json"
        "application/ld+json"
        "text/markdown"
        "audio/midi"
        "audio/x-midi"
        "text/javascript"
        "audio/mp4"
        "audio/mpeg"
        "video/mp4"
        "video/mpeg"
        "application/vnd.apple.installer+xml"
        "application/vnd.oasis.opendocument.presentation"
        "application/vnd.oasis.opendocument.spreadsheet"
        "application/vnd.oasis.opendocument.text"
        "audio/ogg"
        "video/ogg"
        "application/ogg"
        "audio/ogg"
        "font/otf"
        "image/png"
        "application/pdf"
        "application/x-httpd-php"
        "application/vnd.ms-powerpoint"
        "application/vnd.openxmlformats-officedocument.presentationml.presentation"
        "application/vnd.rar"
        "application/rtf"
        "application/x-sh"
        "image/svg+xml"
        "application/x-tar"
        "image/tiff"
        "video/mp2t"
        "font/ttf"
        "text/plain"
        "application/vnd.visio"
        "audio/wav"
        "audio/webm"
        "video/webm"
        "application/manifest+json"
        "image/webp"
        "font/woff"
        "font/woff2"
        "application/xhtml+xml"
        "application/vnd.ms-excel"
        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        "application/xml"
        "application/atom+xml"
        "text/xml"
        "application/vnd.mozilla.xul+xml"
        "application/zip"
        "application/x-zip-compressed"
        "video/3gpp"
        "audio/3gpp"
        "video/3gpp2"
        "audio/3gpp2"
        "application/x-7z-compressed"
    ]

let commonMediaTypes =
    commonContentTypes
    |> Seq.toArray
    |> Array.map (fun contentType -> MimeType.Parse contentType)

let rdfContentTypes =

    set [
        // Core RDF serializations
        "application/rdf+xml"
        "text/turtle"
        "application/n-triples"
        "application/n-quads"
        "application/trig"
        "application/ld+json"

        // Other RDF serializations
        "text/n3"
        "text/rdf+n3"
        "application/n3"
        "application/rdf+json"
        "application/trix"
        "application/trix+xml"
        "application/vnd.hdt"
        "application/x-binary-rdf"
        "application/x-ld+ndjson"
        "application/rdf+thrift"
        "application/rdf+protobuf"

        // RDF Patch
        "application/rdf-patch"
        "application/rdf-patch+thrift"

        // SPARQL
        "application/sparql-query"
        "application/sparql-update"

        // SPARQL result formats
        "application/sparql-results+xml"
        "application/sparql-results+json"
        "application/sparql-results+thrift"
        "application/sparql-results+protobuf"
    ]

let rdfMimeTypes =
    rdfContentTypes
    |> Seq.toArray
    |> Array.map (fun contentType -> MimeType.Parse contentType)

type TopLevelDomain = {
    tldRule: TldRule
} with

    member this.lexicalForm = this.tldRule.Name
    static member fromString(tld: String) =
        let domain = RegistrableDomainParser.Parse $"example.{tld}"
        {
            tldRule = domain.TopLevelDomainRule

        }

type DnsDomain(topLevelDomain: TopLevelDomain, secondLevelDomain: string, maybeSubdomain: string option) =
    let _domain =
        match maybeSubdomain with
        | Some subdomain -> RegistrableDomainParser.Parse $"{subdomain}.{secondLevelDomain}.{topLevelDomain.lexicalForm}"
        | None -> RegistrableDomainParser.Parse $"{secondLevelDomain}.{topLevelDomain.lexicalForm}"
    new(topLevelDomain: TopLevelDomain, secondLevelDomain: string) = DnsDomain(topLevelDomain, secondLevelDomain, None)
    new(domainName: string) =
        let preParse = RegistrableDomainParser.Parse domainName
        DnsDomain(
            {
                tldRule = preParse.TopLevelDomainRule
            },
            preParse.Domain,
            Option.ofNullOrWhiteSpace preParse.Subdomain
        )
    member this.topLevelDomain = topLevelDomain
    member this.secondLevelDomain = secondLevelDomain
    member this.subdomain = maybeSubdomain
    member this.domainName = _domain.FullyQualifiedDomainName
    member this.registrableDomain = _domain.RegistrableDomain

    member this.reverseDomainName = _domain.FullyQualifiedDomainName.Split('.') |> Array.rev |> String.concat "."

    member this.localReference = this.reverseDomainName.Replace(".", "\\")

    member this.IPAddresses =
        try
            Dns.GetHostAddresses _domain.RegistrableDomain
        with _ -> [||]
    member this.dnsQuery(dnsQuery: DnsQueryType) =
        DnsClient.QueryAsync(_domain.FullyQualifiedDomainName, dnsQuery).await

let TopLevelDomains =
    File.ReadAllLines(@"D:\https\org\iana\data\TLD\tlds-alpha-by-domain.txt")[1..]
    |> Array.choose (fun tld ->
        match RegistrableDomainParser.TryParse $"example.{tld}" with
        | true, domain ->
            Some {
                tldRule = domain.TopLevelDomainRule

            }
        | _, _ -> None)

type UrlPatternResult with
    member this.remoteReference = this.Inputs[0].Url
    member this.iriref = IriReference this.remoteReference
type WhatwgSite = {
    scheme: string
    host: HostName
    port: int option
} with

    member this.remoteReference =
        match this.port with
        | Some port -> $"{this.scheme}://{this.host.remoteReference}:{port}"
        | None -> $"{this.scheme}://{this.host.remoteReference}"
    member this.iriref = IriReference this.remoteReference
    member this.urlPattern =
        let init = new UrlPatternInit()
        init.Protocol <- this.scheme
        init.Hostname <- this.host.remoteReference
        UrlPattern.Create(init)
    static member op_Addition((site: WhatwgSite), (port: int)) = { site with port = Some port }
    static member (/)((site: WhatwgSite), (sitePath: string)) = {
        siteRoot = site
        sitePath = sitePath
        templateExpression = String.Empty
    }
    static member (.+)((site: WhatwgSite), (subdomainName: string)) = {
        site with
            host =
                match site.host with
                | RegistrableDomain dnsDomain ->
                    DnsDomain(dnsDomain.topLevelDomain, dnsDomain.secondLevelDomain, Some subdomainName)
                    |> RegistrableDomain
                | _ -> site.host
    }
    static member op_Subtraction((site: WhatwgSite), (rawUri: string)) = (site.urlPattern.Match rawUri).iriref

and HostName =
    | LocalHost
    | IPAddressHost of IPAddress
    | RegistrableDomain of DnsDomain

    static member (..//)((scheme: IanaScheme), (host: HostName)) = {
        scheme = scheme.lexicalForm
        host = host
        port = None
    }
    static member (+.)((subdomainName: string), (host: HostName)) =
        match host with
        | LocalHost -> host
        | IPAddressHost ipAddress -> host
        | RegistrableDomain dnsDomain ->
            DnsDomain(dnsDomain.topLevelDomain, dnsDomain.secondLevelDomain, Some subdomainName)
            |> RegistrableDomain

    member this.remoteReference =
        match this with
        | LocalHost -> "localhost"
        | IPAddressHost ipAddress -> ipAddress.ToString()
        | RegistrableDomain domainInfo -> domainInfo.domainName
and IriSpace = {
    siteRoot: WhatwgSite
    sitePath: string
    templateExpression: string
} with

    static member (*)((space: IriSpace), (templateExpression: string)) = {
        space with
            templateExpression = templateExpression
    }

    static member (/)((space: IriSpace), (pathTemplate: string)) = {
        space with
            sitePath = space.sitePath + $"/{pathTemplate.TrimStart('/')}"
    }
    member this.pathTemplate = UriTemplate(sprintf "%s/%s%s" this.siteRoot.remoteReference (this.sitePath.TrimStart('/')) this.templateExpression)

type TopLevelDomain with
    static member (.+)((tld: TopLevelDomain), (secondLevelDomainName: string)) =
        DnsDomain(tld, secondLevelDomainName) |> RegistrableDomain

    static member (+.)((secondLevelDomainName: string), (tld: TopLevelDomain)) =
        DnsDomain(tld, secondLevelDomainName) |> RegistrableDomain

    static member asAstModule =
        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\dll\"))
                Ast.HashDirective("r", Ast.VerbatimString("Iana.dll"))
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx\"))
                Ast.Open("Iana")
                Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))
                Ast.Open("System")

                for topLevelDomain in TopLevelDomains do
                    let variableBinder = PrettierNaming.VariableBinder topLevelDomain.tldRule.Name
                    Ast.Value(variableBinder.binding, $"TopLevelDomain.fromString \"{topLevelDomain.tldRule.Name}\"")
            }
        }
        |> Gen.mkOak
        |> Gen.run

    static member _txtLines = File.ReadAllLines(@"D:\https\org\iana\data\TLD\tlds-alpha-by-domain.txt")

    static member _comment = TopLevelDomain._txtLines[0]

    static member _versionComment =
        match TopLevelDomain._comment.Split(',', StringSplitOptions.TrimEntries) with
        | [| versionComment; lastUpdatedComment |] -> versionComment

    static member _versionDateOnly = DateOnly.ParseExact(TopLevelDomain._versionComment.Split() |> Array.last, "yyyyMMddhh", CultureInfo.InvariantCulture)

    static member _lastUpdatedComment =
        match TopLevelDomain._comment.Split(',', StringSplitOptions.TrimEntries) with
        | [| versionComment; lastUpdatedComment |] -> lastUpdatedComment

    static member _lastUpdatedCommentDateTimeOffset =
        DateTimeOffset.ParseExact(
            TopLevelDomain._lastUpdatedComment.Replace("Last Updated ", "").Replace("UTC", "-00:00"),
            "ddd MMM dd hh:mm:ss yyyy zzzz",
            CultureInfo.InvariantCulture
        )

type IanaScheme with
    static member asAstModule =
        let schemeTrie = VDS.Common.Tries.Trie<string array, string, IanaScheme>(fun tokens -> tokens :> seq<string>)

        IanaSchemes
        |> Array.map (fun scheme -> scheme, scheme.lexicalForm.lexicalTokens)
        |> Array.iter (fun (scheme, tokens) -> schemeTrie.Add(tokens, scheme))

        let rec processBranchNode (trieNode: ITrieNode<string, IanaScheme>) =
            let moduleBinder = PrettierNaming.ModuleBinder trieNode.KeyBit

            Ast.Module(moduleBinder.binding) {
                for childNode in trieNode.Children do
                    if childNode.IsLeaf then
                        childNode.Value.asAstRecordExprValue
                    else
                        processBranchNode childNode
            }

        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\dll\"))
                Ast.HashDirective("r", Ast.VerbatimString("Iana.dll"))
                Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx\"))
                Ast.Open("Iana")
                Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))
                Ast.Open("System")

                for trieNode in schemeTrie.Root.Children do
                    if trieNode.IsLeaf then
                        trieNode.Value.asAstRecordExprValue
                    else
                        processBranchNode trieNode
            }
        }
        |> Gen.mkOak
        |> Gen.run

    member this.asAstRecordExprValue: WidgetBuilder<SyntaxOak.BindingNode> =
        [|
            Ast.RecordFieldExpr("lexicalForm", Ast.String this.lexicalForm)
            Ast.RecordFieldExpr(
                "description",
                if this.description.IsSome then
                    $"Some(\"\"\"{this.description.Value}\"\"\")"
                else
                    "None"
            )
            Ast.RecordFieldExpr("status", Ast.ConstantExpr $"IanaStatus.{this.status}")
            Ast.RecordFieldExpr("criSchemeNumber", Ast.Int this.criSchemeNumber)
        |]
        |> Ast.RecordExprValue(this.lexicalForm.lexicalTokens |> Array.last)

    member this.urlPattern =
        let init = new UrlPatternInit()
        init.Protocol <- this.lexicalForm
        UrlPattern.Create(init)

let codegenSchemes () =
    File.WriteAllText(@"D:\https\com\github\eristocrates\ipa\fsx\IanaScheme.fsx", IanaScheme.asAstModule)

let codegenDomains () =
    File.WriteAllText(@"D:\https\com\github\eristocrates\ipa\fsx\TopLevelDomain.fsx", TopLevelDomain.asAstModule)

let codegenMimeTypes () =

    let mimeTrie = Trie<string array, string, string>(fun tokens -> tokens :> seq<string>)

    IanaContentTypes
    |> Array.map (fun contentTYpe -> contentTYpe, contentTYpe.lexicalTokens)
    |> Array.iter (fun (contentType, tokens) -> mimeTrie.Add(tokens, contentType))

    let processLeafNode (trieNode: ITrieNode<string, string>) =
        let variableBinder = PrettierNaming.VariableBinder trieNode.KeyBit
        Ast.Value(variableBinder.binding, Ast.ConstantExpr(sprintf "MimeType.Parse \"%s\"" trieNode.Value))

    let rec processBranchNode (trieNode: ITrieNode<string, string>) =
        let moduleBinder = PrettierNaming.ModuleBinder trieNode.KeyBit

        Ast.Module(moduleBinder.binding) {
            for childNode in trieNode.Children do
                if childNode.IsLeaf then
                    processLeafNode childNode
                else
                    processBranchNode childNode
        }

    Ast.Oak() {
        Ast.AnonymousModule() {
            Ast.Open("System")
            Ast.HashDirective("load", Ast.VerbatimString(@".paket/load/main.group.fsx"))
            Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\dll\"))
            Ast.HashDirective("r", Ast.VerbatimString("Iana.dll"))
            Ast.HashDirective("I", Ast.VerbatimString(@"D:\https\com\github\eristocrates\ipa\fsx\"))
            Ast.Open("Iana")
            Ast.Open("FolkerKinzel.MimeTypes")

            for trieNode in mimeTrie.Root.Children do
                processBranchNode trieNode

        }
    }
    |> Gen.mkOak
    |> Gen.run
    |> fun text -> File.WriteAllText(@"D:\https\com\github\eristocrates\ipa\fsx\IanaMime.fsx", text)
