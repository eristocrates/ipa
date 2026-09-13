(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)

// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\fsx"

#r "IanaSchemes.dll"
open IanaSchemes

#r "TaskErgonomics.dll"

open TaskErgonomics
#r "PageErgonomics.dll"

open PageErgonomics
#r "UrlErgonomics.dll"

open UrlErgonomics


#r "RdfAsm.dll"
open RdfAsm

open System
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Dubzer.WhatwgUrl
open System.IO
open System.Net
open WebDriverBiDi
open WebDriverBiDi.Session
open WebDriverBiDi.BrowsingContext
open FolkerKinzel.MimeTypes
open IriTools
open ktsu.Semantics.Strings
open ktsu.Semantics.Strings.Identifiers
open ktsu.Semantics.Paths
open Meziantou.Framework
open System.IO
open AngleSharp.Html
open Microsoft.AspNetCore.Http
open ModelingEvolution.Ipv4
open Nager.PublicSuffix
open Nager.PublicSuffix.RuleProviders


let HttpRuleProvider = new SimpleHttpRuleProvider()
do HttpRuleProvider.BuildAsync().await |> ignore
let RegistrableDomainParser = new DomainParser(HttpRuleProvider)

type DriveInfo with
    static member C = DriveInfo.GetDrives() |> Array.find (fun drive -> drive.Name[0] = 'C')
    // static member D = DriveInfo.GetDrives() |> Array.find (fun drive -> drive.Name[0] = 'D')
    static member byChar =
        DriveInfo.GetDrives()
        |> Array.map (fun drive -> drive.Name[0], drive)
        |> Map.ofArray


let personalDriveReference = DriveInfo.C.Name
let personalSiteReference = "https://eristocrates.dev"

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







































type ResolvedResource = {
    absoluteRoot: AbsoluteRoot
    pathSegments: string array
    fragmentString: FragmentString option
    queryString: QueryString option
}

and AbsoluteRoot =
    | DriveRoot of DriveInfo
    | SiteRoot of WhatwgSite

and WhatwgSite = {
    scheme: IanaScheme
    host: HostName
    port: int option
}
and HostName =
    | Ipv4Host of Ipv4Address
    | DomainHost of RegistrableDomain
and RegistrableDomain = { domainName: DomainInfo }


































type Ipv4Address with
    member this.remoteReference = this.ToString()
    member this.asIpAddress = IPAddress.Parse this.remoteReference
    member this.outerLeft = int this.A
    member this.innerLeft = int this.B
    member this.innerRight = int this.C
    member this.outerRight = int this.D
    member this.localReference = this.remoteReference.Replace(".", "/")



type RelativeDirectoryPath with
    static member EnsureCreate(rawPath: string) =
        let invalidChars = Path.GetInvalidFileNameChars() |> Set.ofArray
        rawPath.Split([| '/'; '\\' |], StringSplitOptions.TrimEntries)
        |> Array.filter (fun segment -> not (String.IsNullOrWhiteSpace segment))
        |> Array.map (fun segment ->
            segment
            |> String.collect (fun character ->
                if invalidChars.Contains character then
                    match HtmlEntityProvider.ReverseResolver.GetName(string character) with
                    | null -> $"&#x{int character:X};"
                    | name -> $"&{name}"
                else
                    string character))
        // |> String.concat "\\"
        // |> RelativeDirectoryPath.Create


type RegistrableDomain with
    static member (..//)((scheme: IanaScheme), (domain: RegistrableDomain)) =
        {
            scheme = scheme
            host = DomainHost domain
            port = None
        }
        |> SiteRoot
    static member Parse(originalString: string) = {
        domainName = RegistrableDomainParser.Parse originalString
    }
    member this.topLevelDomain = this.domainName.TopLevelDomainRule
    member this.remoteReference = this.domainName.FullyQualifiedDomainName
    member this.secondLevelDomain = this.domainName.Domain
    member this.subdomain = Option.ofNullOrWhiteSpace this.domainName.Subdomain
    member this.dnsDomain = this.domainName.RegistrableDomain
    member this.localReference =
        match this.subdomain with
        | Some subdomain -> Path.Combine(this.topLevelDomain.Name, this.secondLevelDomain, subdomain)
        | None -> Path.Combine(this.topLevelDomain.Name, this.secondLevelDomain)

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
    member this.ipAddresses =
        try
            Dns.GetHostAddresses this.dnsDomain
        with _ -> [||]
    member this.ipv4Addresses = this.ipAddresses |> Array.map Ipv4Address.FromIPAddress
type HostName with
    member this.remoteReference =
        match this with
        | Ipv4Host ipv4 -> ipv4.remoteReference
        | DomainHost domain -> domain.remoteReference
    member this.localReference =
        match this with
        | Ipv4Host ipv4 -> ipv4.localReference
        | DomainHost domain -> domain.localReference
type WhatwgSite with
    static member op_Addition((site: WhatwgSite), (port: int)) = { site with port = Some port }
    member this.localReference = Path.Combine(personalDriveReference, this.scheme.lexicalForm, this.host.localReference)
    member this.remoteReference =
        match this.port with
        | Some port -> $"{this.scheme.lexicalForm}://{this.host.remoteReference}:{port}"
        | None -> $"{this.scheme.lexicalForm}://{this.host.remoteReference}"
    member this.asLocalUri = Uri this.localReference
    member this.asRemoteUri = Uri this.remoteReference
    member this.asLocalUrl = DomUrl this.localReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asLocalIri = IriReference this.localReference |> IRIREF
    member this.asRemoteIri = IriReference this.remoteReference |> IRIREF

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
type DriveInfo with
    member this.localReference = string this.Name[0]
    member this.remoteReference = $"{personalSiteReference}/{this.Name}"
    member this.asLocalUri = Uri this.Name
    member this.asLocalUrl = DomUrl this.Name
    member this.asLocalIri = IriReference this.Name |> IRIREF
    member this.asRemoteUri = Uri this.remoteReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asRemoteIri = IriReference this.remoteReference |> IRIREF
    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference

type AbsoluteRoot with
    static member op_Addition((root: AbsoluteRoot), (port: int)) =
        match root with
        | DriveRoot driveInfo -> root
        | SiteRoot whatwgSite -> { whatwgSite with port = Some port } |> SiteRoot

    static member (./)((root: AbsoluteRoot), (relativeString: string)) = {
        absoluteRoot = root
        pathSegments = relativeString.Split([| '/'; '\\'|], StringSplitOptions.TrimEntries) |> Array.filter (fun segment -> not (String.IsNullOrWhiteSpace segment))
        fragmentString = None
        queryString = None
    }

    member this.localReference =
        match this with
        | DriveRoot driveInfo -> driveInfo.localReference
        | SiteRoot whatwgSite -> whatwgSite.localReference
    member this.remoteReference =
        match this with
        | DriveRoot driveInfo -> driveInfo.remoteReference
        | SiteRoot whatwgSite -> whatwgSite.remoteReference
    member this.asLocalUri = Uri this.localReference
    member this.asLocalUrl = DomUrl this.localReference
    member this.asLocalIri = IriReference this.localReference |> IRIREF
    member this.asRemoteUri = Uri this.remoteReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asRemoteIri = IriReference this.remoteReference |> IRIREF

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
    member this.asAbsoluteDirectoryPath = AbsoluteDirectoryPath.Create this.localReference
    member this.asAbsoluteFilePath = AbsoluteFilePath.Create this.localReference

type RelativePath with
    member this.asRelativeUri = Uri(this.WeakString, UriKind.Relative)
    member this.asResolvedUri(baseUri: Uri) = Uri(baseUri, this.WeakString)
    member this.asResolvedUrl(baseUrl: DomUrl) = DomUrl(this.WeakString, baseUrl)
    member this.asRelativeIriReference = IriReference this.WeakString

    member this.asResolvedIri(baseIri: Iri) =
        IriReference $"{baseIri.lexicalForm}/{this.WeakString}" |> IRIREF
    member this.asPrefixedName(prefixId: PrefixId) = prefixId.prefix this.WeakString

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.WeakString
    member this.asRelativeFilePath = RelativeFilePath.Create this.WeakString
    member this.asPathString = PathString $"/{this.WeakString}"
    member this.asDirectoryName = DirectoryName.Create this.WeakString
    member this.asFileName = FileName.Create this.WeakString


type ResolvedResource with

    member this.localReference = Path.Combine(this.absoluteRoot.localReference, this.pathSegments |> String.concat "\\")
    member this.remoteReference = this.absoluteRoot.remoteReference + "/" + (this.pathSegments |> String.concat "/")

    member this.asLocalUri = Uri this.localReference
    member this.asRemoteUri = Uri this.remoteReference
    member this.asLocalUrl = DomUrl this.localReference
    member this.asRemoteUrl = DomUrl this.remoteReference
    member this.asLocalIri = IriReference this.localReference |> IRIREF
    member this.asRemoteIri = IriReference this.remoteReference |> IRIREF

    member this.asRelativeDirectoryPath = RelativeDirectoryPath.EnsureCreate this.localReference
    member this.asRelativeFilePath = RelativeFilePath.Create this.localReference
    member this.asAbsoluteDirectoryPath = AbsoluteDirectoryPath.Create this.localReference
    member this.asAbsoluteFilePath = AbsoluteFilePath.Create this.localReference
    member this.asDirectoryPath = AbsoluteDirectoryPath.Create this.localReference
    member this.asFilePath = AbsoluteFilePath.Create this.localReference
    member this.asFileInfo = FileInfo this.localReference
    member this.asDirectoryInfo = DirectoryInfo this.localReference
    member this.asFullPath = FullPath.FromPath this.localReference


type FullPath with
    static member CurrentFile() =
        Path.Combine(FullPath.CurrentDirectory().RawValue, __SOURCE_FILE__)
        |> FileInfo
        |> FullPath.FromFileSystemInfo



type ResourceIdentifier =
    | GloballyUniqueIdentifier of Guid
    | UniversallyUniqueIdentifier of Uuid
    | UniversallyUniqueLexicographicallySortableIdentifier of Ulid
    | InternationalStandardBookNumber of Isbn


type MimeType with
    static member FromFileName(fileName: FileName) =
        MimeType.FromFileName fileName.WeakString

fsi.AddPrinter<RelativeDirectoryPath>(fun path -> path.WeakString)
fsi.AddPrinter<RelativeFilePath>(fun path -> path.WeakString)
fsi.AddPrinter<RelativePath>(fun path -> path.WeakString)
fsi.AddPrinter<AbsoluteDirectoryPath>(fun path -> path.WeakString)
fsi.AddPrinter<AbsoluteFilePath>(fun path -> path.WeakString)
fsi.AddPrinter<AbsolutePath>(fun path -> path.WeakString)















let IanaSchemeDomain (scheme: IanaScheme) (domainString: string) =
    scheme ..// RegistrableDomain.Parse domainString




module https =
    let https (domainString: string) =
        IanaSchemeDomain IanaScheme.https domainString

    module dev =
        let eristocrates = https "eristocrates.dev"
    module gov =
        module leoncountyfl =
            module bannerprodssb =
                let site = https "bannerprodssb.leoncountyfl.gov" + 8449
                module EmployeeSelfService =
                    let resource = site ./ "EmployeeSelfService"






type QueryString with
    member this.parameterCollection = QueryStringUtilities.ParseQuery this.Value
// member this.AppendFileName (fileName:FileName) = let mimeType = MimeType.FromFileName fileName
















type QueryParameter =
    | ParameterKeyValue of string * string
    | ParameterKeyValues of string * string array

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








(*







// TODO work on separating fragment and query strings into resolved resource



https.gov.leoncountyfl.bannerprodssb.EmployeeSelfService.resource.asAbsoluteDirectoryPath
https.gov.leoncountyfl.bannerprodssb.EmployeeSelfService.resource.localReference
https.gov.leoncountyfl.bannerprodssb.EmployeeSelfService.resource.remoteReference



let myIpv4 = Ipv4Address.Parse "170.85.130.82"

let uriTest = Uri "https://www.cambiaresearch.com"

let cambiaresearch = IanaScheme.https ..// RegistrableDomain.Parse "www.cambiaresearch.com"
cambiaresearch

let relativeResourceTest = RelativePath.Create "articles/730004/the-dotnet-uri-class-and-the-cambia.uriextensions-nuget-package#sec-4EIL2NFFDJUQ2XHLG2FPTXKIT"


relativeResourceTest.asRelativeDirectoryPath
relativeResourceTest.asRelativeDirectoryPath.Parent
relativeResourceTest.asRelativeDirectoryPath.Parent.Parent


let xn__6qq79v = IanaScheme.http ..// RegistrableDomain.Parse "你好.cn"
let googleSite = IanaScheme.http ..// RegistrableDomain.Parse "www.google.com"



let testUri =
    Uri
        "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/payStubDetail/getPayStubDetail.json?payDate=20251231&payId=BW&payNumber=27&paySequence=0&payYear=2025#testFragment"

let pathString = PathString.FromUriComponent testUri
let queryString = QueryString.FromUriComponent testUri
queryString





let baseTest = RegistrableDomain.Parse "https://google.com"










let absoluteResource = AbsoluteResource.fromRawString "https://bannerprodssb.leoncountyfl.gov:8449"
let relativeResource =
    RelativeResource.fromString "/EmployeeSelfService/ssb/payStubDetail/getPayStubDetail.json?payDate=20251231&payId=BW&payNumber=27&paySequence=0&payYear=2025#testFragment"

absoluteResource.scheme
absoluteResource.topLevelDomain
absoluteResource.secondLevelDomain
absoluteResource.subdomain
absoluteResource.port
absoluteResource.absoluteUri
absoluteResource.absolutePath
absoluteResource.localPath
FileInfo absoluteResource.localPath


absoluteResource
absoluteResource.hierarchicalRelativeFilePath.As<RelativeDirectoryPath>()
absoluteResource.asUrl.Pathname


QueryStringUtilities.ParseQuery absoluteResource.asUri.Query

absoluteResource.asUrl
absoluteResource.asUri

let testResourceIdentifier = DomUrl "https://www.iana.org/assignments/media-types" |> AbsoluteResourceLocator
testResourceIdentifier.AppendPathSegment "media-types.xml"
testResourceIdentifier.tokens
testResourceIdentifier.asUri.AbsolutePath
testResourceIdentifier.asUri.LocalPath

let testUri = Uri(@"/api/v1/users", UriKind.Relative) |> AbsoluteResourceIdentifier


module org =
    module iana =
        module www =
            module assignments =
                let media_types = DomUrl "https://www.iana.org/assignments/media-types" |> AbsoluteResourceLocator
*)
