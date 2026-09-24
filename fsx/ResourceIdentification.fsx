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
#r "Turtle.dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "PrettierNaming.fsx"
#load "Ast.fsx"

open SharedKernel
open StringModule
open Iana
open Turtle

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
open FSharp.Collections.ParallelSeq
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleProviders
open System.Text
open FSharp.HashCollections
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
open VDS.RDF.Ontology
open VDS.RDF.Query
open VDS.RDF.Query.Builder
open FSharp.Data.Adaptive.Transaction
open VDS.RDF.Query.Patterns
open Nager
open Meziantou.Framework.DnsClient
open Meziantou.Framework.DnsClient.Query
open Meziantou.Framework.DnsClient.Response

type DomUrl with
    member this.HrefPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Protocol with
        | Some value -> init.Protocol <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hash with
        | Some value -> init.Hash <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hostname with
        | Some value -> init.Hostname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Username with
        | Some value -> init.Username <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Password with
        | Some value -> init.Password <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Port with
        | Some value -> init.Port <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Search with
        | Some value -> init.Search <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.OriginPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Protocol with
        | Some value -> init.Protocol <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hash with
        | Some value -> init.Hash <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hostname with
        | Some value -> init.Hostname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Username with
        | Some value -> init.Username <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Password with
        | Some value -> init.Password <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Port with
        | Some value -> init.Port <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.ProtocolPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Protocol with
        | Some value -> init.Protocol <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.HashPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Hash with
        | Some value -> init.Hash <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.HostnamePattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Hostname with
        | Some value -> init.Hostname <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.UsernamePattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Username with
        | Some value -> init.Username <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.PasswordPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Password with
        | Some value -> init.Password <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.PathnamePattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.PortPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Port with
        | Some value -> init.Port <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.SearchPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Search with
        | Some value -> init.Search <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.AbsoluteUrlPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Protocol with
        | Some value -> init.Protocol <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hash with
        | Some value -> init.Hash <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hostname with
        | Some value -> init.Hostname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Username with
        | Some value -> init.Username <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Password with
        | Some value -> init.Password <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Port with
        | Some value -> init.Port <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.HashPathPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hash with
        | Some value -> init.Hash <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.SearchPathPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Search with
        | Some value -> init.Search <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.SearchHashPathPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Search with
        | Some value -> init.Search <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hash with
        | Some value -> init.Hash <- value
        | _ -> ()

        UrlPattern.Create(init)

    member this.RequestTargetPattern =
        let init = new UrlPatternInit()

        match Option.ofNullOrWhiteSpace this.Protocol with
        | Some value -> init.Protocol <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Search with
        | Some value -> init.Search <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Hostname with
        | Some value -> init.Hostname <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Username with
        | Some value -> init.Username <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Password with
        | Some value -> init.Password <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Port with
        | Some value -> init.Port <- value
        | _ -> ()

        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some value -> init.Pathname <- value
        | _ -> ()

        UrlPattern.Create(init)
    member this.NamespacePattern = UrlPattern.Create(sprintf "%s{:localName}" (HttpUtility.UrlDecode this.Href))

type QueryParameter =
    | ParameterKeyValue of string * string
    | ParameterKeyValues of string * string array

[<RequireQualifiedAccess>]
type HTTPMethod =
    | DELETE
    | GET
    | PATCH
    | POST
    | PUT
    | UnknownMethod of string

    static member fromString(rawMethod: string) =
        match rawMethod with
        | "DELETE" -> DELETE
        | "GET" -> GET
        | "PATCH" -> PATCH
        | "POST" -> POST
        | "PUT" -> PUT
        | unknown -> UnknownMethod rawMethod
    member this.asString = this.ToString()

type IPAddress with
    member this.asIpv4 =
        match this.AddressFamily with
        | AddressFamily.InterNetwork -> Ipv4Address.FromIPAddress this
        | _ -> this.MapToIPv4() |> Ipv4Address.FromIPAddress
    member this.remoteReference = this.ToString()
    member this.localReference = this.remoteReference.Replace(".", "//")

type Ipv4Address with
    member this.remoteReference = this.ToString()
    member this.localReference = this.remoteReference.Replace(".", "//")
    member this.asIpAddress = this.ToIPAddress()
    member this.outerLeft = int this.A
    member this.innerLeft = int this.B
    member this.innerRight = int this.C
    member this.outerRight = int this.D

type HostName with
    member this.localReference =
        match this with
        | LocalHost -> "localhost"
        | IPAddressHost ipAddress -> ipAddress.localReference
        | RegistrableDomain domainInfo -> domainInfo.localReference
    member this.topLevelDomain =
        match this with
        | LocalHost -> None
        | IPAddressHost ipAddress -> None
        | RegistrableDomain domainInfo -> Some domainInfo.topLevelDomain
    member this.secondLevelDomain =
        match this with
        | LocalHost -> None
        | IPAddressHost ipAddress -> None
        | RegistrableDomain domainInfo -> Some domainInfo.secondLevelDomain
    member this.subdomain =
        match this with
        | LocalHost -> None
        | IPAddressHost ipAddress -> None
        | RegistrableDomain domainInfo -> domainInfo.subdomain
    member this.reverseDomainName =
        match this with
        | LocalHost -> "localhost"
        | IPAddressHost ipAddress -> ipAddress.remoteReference
        | RegistrableDomain domainInfo -> domainInfo.reverseDomainName
    member this.pathSegments =
        match this with
        | LocalHost -> [| "localhost" |]
        | IPAddressHost ipAddress -> ipAddress.remoteReference.lexicalTokens
        | RegistrableDomain domainInfo -> domainInfo.localReference.pathTokens

type Uri with
    member this.tryIanaScheme = IanaSchemes |> Array.tryFind (fun scheme -> scheme.lexicalForm = this.Scheme)
    member this.PathAndFragment = this.AbsolutePath + this.Fragment
    member this.localPart = this.PathAndFragment.lexicalTokens |> Array.last
    member this.asUrl = DomUrl this.OriginalString
    member this.HostName =
        match this.DnsSafeHost with
        | "localhost" -> LocalHost
        | _ -> DnsDomain this.DnsSafeHost |> RegistrableDomain
    member this.WhatwgSite = {
        scheme = this.Scheme
        host = this.HostName
        port = Option.ofNullOrWhiteSpace this.Port |> Option.map (fun port -> int port)
    }
    member this.terminal = this.PathAndFragment[this.PathAndFragment.Length - this.localPart.Length - 1]
    member this.urlPattern =
        let init = new UrlPatternInit()
        init.Hash <- this.Fragment
        init.Hostname <- this.Host
        match this.UserInfo.Split(':') with
        | [| username; password |] ->
            init.Username <- username
            init.Password <- password
        | [| username |] -> init.Username <- username
        | _ -> ()
        init.Pathname <- this.AbsolutePath
        init.Port <- string this.Port
        init.Protocol <- this.Scheme
        init.Search <- this.Query
        UrlPattern.Create(init)
    member this.relativeLocalPath = this.LocalPath.Replace("/", "\\")

type DomUrl with
    member this.urlPattern =
        let init = new UrlPatternInit()
        match Option.ofNullOrWhiteSpace this.Hash with
        | Some hash -> init.Hash <- hash
        | _ -> ()
        init.Hostname <- this.Hostname
        match Option.ofNullOrWhiteSpace this.Pathname with
        | Some path -> init.Pathname <- path
        | _ -> ()
        match Option.ofNullOrWhiteSpace this.Port with
        | Some port -> init.Port <- port
        | _ -> ()
        init.Protocol <- this.Protocol
        match Option.ofNullOrWhiteSpace this.Search with
        | Some search -> init.Search <- search
        | _ -> ()
        UrlPattern.Create(init)

type UriTemplate with
    member this.asUri = this.Resolve() |> Uri
    member this.asUrl = this.Resolve() |> DomUrl
    member this.asIriReference = this.Resolve() |> IriReference

type UrlPatternResult with
    member this.hostName = DnsDomain this.Hostname.Input |> RegistrableDomain
    member this.site = {
        scheme = this.Protocol.Input
        host = this.hostName
        port = Option.ofNullOrWhiteSpace this.Port.Input |> Option.map (fun port -> int port)
    }
    member this.localPath = this.Pathname.Input.Replace("/", "\\")
    member this.localReference =
        DriveInfo.preferredDrive.Name
        + this.site.scheme
        + this.site.host.localReference
        + this.localPath
        + this.Hash.Input
        + this.Search.Input

type WhatwgSite with

    static member fromUri(uri: Uri) = uri.WhatwgSite
    member this.localReference = Path.Combine(DriveInfo.preferredDrive.Name, this.scheme, this.host.localReference)
    member this.asUri = Uri this.remoteReference
    member this.tryIanaScheme = IanaSchemeByName.TryFind this.scheme

    member this.asUrl = DomUrl this.remoteReference

    // TODO maybe add paths
    // TODO figure out how to group modules from array of iri strings
    // TODO consider generation a file per site, to avoid dealwith with module nesting
    member this.asAstModule =

        let schemeModuleBinder = PrettierNaming.ModuleBinder this.scheme
        let schemeVariableBinder = PrettierNaming.VariableBinder this.scheme

        Ast.Oak() {
            Ast.AnonymousModule() {

                Ast.HashDirective("I", Ast.VerbatimString @"D:\https\com\github\eristocrates\ipa\dll\")
                Ast.HashDirective("r", Ast.VerbatimString @"StringModule.dll")
                Ast.HashDirective("r", Ast.VerbatimString @"Internet.dll")
                Ast.HashDirective("r", Ast.VerbatimString @"TopLevelDomain.dll")
                Ast.HashDirective("r", Ast.VerbatimString @"IanaScheme.dll")
                Ast.HashDirective("I", Ast.VerbatimString @"D:\https\com\github\eristocrates\ipa\fsx\")
                Ast.HashDirective("load", Ast.VerbatimString "PrettierNaming.fsx")
                Ast.Open("Internet")
                Ast.Open("StringModule")
                Ast.HashDirective("load", Ast.VerbatimString @".paket/load/main.group.fsx")
                Ast.Open("System")
                Ast.Module(schemeModuleBinder.binding) {
                    Ast.Value("scheme", $"IanaScheme.{schemeVariableBinder.binding}")
                    match this.host.topLevelDomain with
                    | Some topLevelDomain ->
                        let topLevelDomainModuleBinder = PrettierNaming.ModuleBinder topLevelDomain.tldRule.Name
                        let topLevelDomainVariableBinder = PrettierNaming.VariableBinder topLevelDomain.tldRule.Name
                        Ast.Module(topLevelDomainModuleBinder.binding) {
                            Ast.Value("topLevelDomain", $"TopLevelDomain.{topLevelDomainVariableBinder.binding}")
                            match this.host.secondLevelDomain with
                            | Some secondLevelDomain ->
                                let secondLevelDomainModuleBinder = PrettierNaming.ModuleBinder secondLevelDomain
                                Ast.Module(secondLevelDomainModuleBinder.binding) {
                                    Ast.Value("secondLevelDomain", Ast.String secondLevelDomainModuleBinder.identifier)
                                    Ast.Value("host", Ast.ConstantExpr "secondLevelDomain +. topLevelDomain")
                                    Ast.Value("site", Ast.ConstantExpr "scheme ..// host")
                                    match this.host.subdomain with
                                    | Some subdomain ->
                                        let subdomainModuleBinder = PrettierNaming.ModuleBinder subdomain
                                        Ast.Module(subdomainModuleBinder.binding) {
                                            if subdomain = "www" then
                                                Ast.Value("site", Ast.ConstantExpr "scheme |> www secondLevelDomain topLevelDomain")
                                            else
                                                Ast.Value("site", Ast.ConstantExpr $"site .+ \"{subdomain}\"")
                                        }
                                    | None -> ()
                                }
                            | None -> ()
                        }
                    | None -> ()
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run
    member this.moduleFilePath = AbsoluteFilePath.Create $"{__SOURCE_DIRECTORY__}\Sites\{this.scheme}\{this.host.localReference}\Site.fsx"
    member this.codegenSite() =
        Directory.CreateDirectory this.moduleFilePath.DirectoryPath.WeakString |> ignore
        File.WriteAllText(this.moduleFilePath.WeakString, this.asAstModule)

type PathString with
    member this.pathName = this.Value.TrimStart('/')
    member this.asRelativePath = this.pathName.Replace("/", "\\") |> RelativePath.Create

type FragmentString with
    member this.localPart = this.Value.TrimStart('#')

type QueryParameter with

    member this.parameterKey =
        match this with
        | ParameterKeyValue(parameterKey, parameterValue) -> parameterKey
        | ParameterKeyValues(parameterKey, parameterValues) -> parameterKey

    member this.parameterValue =
        match this with
        | ParameterKeyValue(parameterKey, parameterValue) -> parameterValue
        | ParameterKeyValues(parameterKey, parameterValues) -> parameterValues[0]

    member this.parameterValues =
        match this with
        | ParameterKeyValue(parameterKey, parameterValue) -> [| parameterValue |]
        | ParameterKeyValues(parameterKey, parameterValues) -> parameterValues

type RelativeDirectoryPath with
    static member EnsureCreate(rawPath: string) =
        let invalidChars = Path.GetInvalidFileNameChars() |> Set.ofArray
        rawPath.Split([| '/'; '\\' |], StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofNullOrWhiteSpace segment)
        |> Array.map (fun segment ->
            segment
            |> String.collect (fun character ->
                if invalidChars.Contains character then
                    match character.tryHtmlEntity with
                    | Some htmlEntity -> htmlEntity
                    | None -> String.prepostfix "&#x" character.hexName ";"
                else
                    string character))

type QueryStringParameterCollection with
    member this.parameters =
        this
        |> Seq.map (fun keyValue ->
            match keyValue.Key, keyValue.Value |> Seq.toArray with
            | parameterKey, [| parameterValue |] -> ParameterKeyValue(parameterKey, parameterValue)
            | parameterKey, parameterValues -> ParameterKeyValues(parameterKey, parameterValues))
        |> Seq.toArray

    member this.asRelativeDirectoryPath =
        this.parameters
        |> Array.map (fun parameter ->
            Array.concat [| [| parameter.parameterKey |]; parameter.parameterValues |]
            |> String.concat "\\")
        |> String.concat "\\"
        |> RelativeDirectoryPath.EnsureCreate

type QueryString with
    member this.parameterCollection = QueryStringUtilities.ParseQuery this.Value
    member this.localReference =
        let invalidChars = Path.GetInvalidFileNameChars() |> Set.ofArray
        this.parameterCollection.parameters
        |> Array.map (fun parameter ->
            Array.concat [| [| parameter.parameterKey |]; parameter.parameterValues |]
            |> Array.map (fun segment ->
                segment
                |> String.collect (fun character ->
                    if invalidChars.Contains character then
                        match character.tryHtmlEntity with
                        | Some htmlEntity -> htmlEntity
                        | None -> String.prepostfix "&#x" character.hexName ";"
                    else
                        string character))
            |> String.concat "\\")
        |> String.concat "\\"

type IriReference with
    member this.remoteReference = this.uri.OriginalString
    member this.url = DomUrl this.remoteReference
    member this.Origin = this.url.Origin
    member this.PathQueryFragment = this.remoteReference[this.Origin.Length ..].TrimStart('/')
    member this.tryDnsDomain =
        try
            Some(DnsDomain this.uri.DnsSafeHost)
        with _ ->
            None

    member this.localReference =
        let domainPath =
            match this.tryDnsDomain with
            | Some domainName -> domainName.localReference
            | None -> this.uri.Host

        $"{DriveInfo.preferredDrive.Name}{this.uri.Scheme}\{domainPath.TrimStart('\\')}\{this.uri.relativeLocalPath.TrimStart('\\')}"
    member this.dotExtension = Path.GetExtension this.uri.relativeLocalPath
    member this.extension = this.dotExtension.TrimStart('.')
    member this.tryDotExtension = Option.ofNullOrWhiteSpace this.dotExtension
    member this.tryExtension = this.tryDotExtension |> Option.map (fun extension -> extension.TrimStart('.'))
    member this.fileExtension =
        this.tryDotExtension
        |> Option.map (fun extension -> FileExtension.Create extension)

type IriSpace with
    static member localName(iri: IriReference) =
        let site = WhatwgSite.fromUri iri.uri

        {
            siteRoot = site
            sitePath = iri.remoteReference[site.remoteReference.Length ..]
            templateExpression = "{localName}"
        }
    static member codegenParameter(parameter: string) =
        let variableBinder = PrettierNaming.VariableBinder parameter
        $"let {variableBinder.binding} ({variableBinder.binding}) = space.pathTemplate.AddParameter(\"{parameter}\", {parameter}).Resolve() |> HttpUtility.UrlDecode |> IriReference"
    static member clipParameter(parameter) =
        IriSpace.codegenParameter parameter |> String.Clipboard.SetText

let codegenSites (sites: string array) =
    sites
    |> Array.iter (fun siteString -> (Uri siteString |> WhatwgSite.fromUri).codegenSite ())

let www (secondLevelDomain: string) (topLevelDomain: TopLevelDomain) (scheme: IanaScheme) = {
    scheme = scheme.lexicalForm
    host = DnsDomain(topLevelDomain, secondLevelDomain, Some "www") |> RegistrableDomain
    port = None
}
