(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)

// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

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
open ktsu.Semantics.Paths
open ktsu.Semantics.Strings
open ktsu.Semantics.Strings.Identifiers
open Rsft.Net.DomainParser
open Meziantou.Framework
open System.IO
open AngleSharp.Html
open Microsoft.AspNetCore.Http


type Option<'Type> with
    static member ofEmpty value =
        if String.IsNullOrWhiteSpace(string value) then
            None
        else
            Some value



type DomainName(originalString: string) =

    let _domain = DomainParserFactory.Create().Parse originalString
    member this.topLevelDomain = _domain.Tld
    member this.secondLevelDomain = _domain.Sld
    member this.subdomain = Option.ofEmpty _domain.Subdomain
    member this.domainName = originalString

type WHATWGSite = {
    scheme: IanaScheme
    host: DomainName
} with

    member this.weakString = $"{this.scheme.lexicalForm}://{this.host.domainName}"
    member this.asUri = Uri this.weakString
    member this.asUrl = DomUrl this.weakString
    member this.asIriReference = IriReference this.weakString

let (..//) (scheme: IanaScheme) (domain: DomainName) = { scheme = scheme; host = domain }
let xn__6qq79v = IanaScheme.http ..// DomainName "你好.cn"


xn__6qq79v.asUri
xn__6qq79v.asUrl
xn__6qq79v.asIriReference


IanaScheme.https
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

type RelativeDirectoryPath with
    static member EnsureCreate(value: string) =
        let invalidChars = Path.GetInvalidFileNameChars() |> Set.ofArray
        value
        |> String.collect (fun character ->
            if invalidChars.Contains character then
                match HtmlEntityProvider.ReverseResolver.GetName(string character) with
                | null -> $"&#x{int character:X};"
                | name -> $"&{name}"
            else
                string character)
        |> RelativeDirectoryPath.Create

type MimeType with
    static member FromFileName(fileName: FileName) =
        MimeType.FromFileName fileName.WeakString


type WindowsPath =
    | WindowsDirectory of DirectoryInfo
    | WindowsFile of FileInfo

    member this.asFileSystemInfo =
        match this with
        | WindowsDirectory directoryInfo -> directoryInfo :> FileSystemInfo
        | WindowsFile fileInfo -> fileInfo :> FileSystemInfo
    member this.rawString = this.asFileSystemInfo.FullName
    member this.href = this.rawString
    member this.asFullPath = FullPath.FromFileSystemInfo this.asFileSystemInfo
    member this.asAbsoluteDirectoryPath = AbsoluteDirectoryPath.Create this.rawString
    member this.asAbsoluteFilePath = AbsoluteFilePath.Create this.rawString





type AbsoluteResource(originalString: string) =
    member this.weakString = originalString
    member this.asUri = Uri(this.weakString, UriKind.Absolute)
    member this.asUrl = DomUrl this.weakString
    member this.asDirectoryPath = AbsoluteDirectoryPath.Create this.weakString
    member this.asFilePath = AbsoluteFilePath.Create this.weakString
    member this.asFileInfo = FileInfo this.weakString
    member this.asDirectoryInfo = DirectoryInfo this.weakString
    member this.asFullPath = FullPath.FromFileSystemInfo this.asDirectoryInfo
    member this.expand(relativeResource: RelativeResource) = {
        absoluteReference = this
        relativeReference = relativeResource
    }

and RelativeResource(originalString: string) =
    member this.weakString = originalString
    member this.asUri = Uri(this.weakString, UriKind.Relative)
    member this.asDirectoryPath = RelativeDirectoryPath.Create this.weakString
    member this.asFilePath = RelativeFilePath.Create this.weakString
    member this.resolve(absoluteResource: AbsoluteResource) = {
        absoluteReference = absoluteResource
        relativeReference = this
    }
and ResolvedResource = {
    absoluteReference: AbsoluteResource
    relativeReference: RelativeResource
} with

    member this.weakDelimitedString(delimiter: string) =
        this.absoluteReference.weakString
        + delimiter
        + this.relativeReference.weakString
    member this.weakString = this.weakDelimitedString "/"
    member this.resolvedUri = Uri(this.absoluteReference.asUri, this.relativeReference.asUri)
    member this.resolvedUrl = DomUrl(this.relativeReference.weakString, this.absoluteReference.asUrl)


type ResourcePath =
    | AbsoluteResourcePath of AbsoluteResource
    | ResolvedResourcePath of ResolvedResource

    member this.weakString =
        match this with
        | AbsoluteResourcePath absoluteResource -> absoluteResource.weakString
        | ResolvedResourcePath resolvedResource -> resolvedResource.weakString

    member this.asUri = Uri this.weakString
    member this.asUrl = DomUrl this.weakString
    member this.scheme = this.asUri.Scheme.TrimEnd ':'
    member this.username = Option.ofEmpty this.asUrl.Username
    member this.password = Option.ofEmpty this.asUrl.Password
    member this.userinfo =
        match Option.ofEmpty this.asUri.UserInfo, this.username, this.password with
        | Some userinfo, _, _ -> Some userinfo
        | None, Some username, None -> Some username
        | None, None, Some password -> Some password
        | None, Some username, Some password -> Some $"{username}:{password}"
        | _, _, _ -> None
    member this.host = this.asUrl.Host
    member this.domainName = this.asUri.DnsSafeHost
    // member this.topLevelDomain = DomainName.Parse this.domainName |> _.Tld
    // member this.secondLevelDomain = DomainName.Parse this.domainName |> _.Sld
    // member this.subdomain = DomainName.Parse this.domainName |> _.Subdomain
    member this.port = Option.ofEmpty this.asUrl.Port
    member this.authority = this.asUri.Authority
    member this.origin = this.asUrl.Origin
    member this.absolutePath = this.asUri.AbsolutePath
    member this.localPath = this.asUri.LocalPath.TrimStart '/'
    member this.queryString = Option.ofEmpty this.asUri.Query
    member this.fragmentString = Option.ofEmpty this.asUri.Fragment
    member this.originFormRequestTarget = this.asUri.PathAndQuery
    member this.absoluteUri = this.asUri.AbsoluteUri
    member this.absolutePathReference = this.weakString[this.origin.Length ..]
    member this.relativePathReference = this.absolutePathReference.TrimStart '/'
    // member this.originRelativeDirectoryPath = this.schemeRelativeDirectoryPath.WithSuffix(this.hostRelativeDirectoryPath).WithSuffix(this.hierarchicalRelativeDirectoryPath)
    member this.originalStringToAbsoluteDirectoryPath = AbsoluteDirectoryPath.Create this.weakString
    member this.originalStringToRelativeDirectoryPath = RelativeDirectoryPath.Create this.weakString
    member this.originalStringToAbsoluteFilePath = AbsoluteFilePath.Create this.weakString
    member this.originalStringToRelativeFilePath = RelativeFilePath.Create this.weakString
    member this.tokens =
        this.absoluteUri.Split([| '/'; '&'; '='; '?'; ':' |], StringSplitOptions.TrimEntries)
        |> Array.choose (fun segment -> Option.ofEmpty segment)
    member this.queryStringParameterCollection =
        this.queryString
        |> Option.map (fun queryString -> QueryStringUtilities.ParseQuery queryString)
// member this.AppendFileName (fileName:FileName) = let mimeType = MimeType.FromFileName fileName











let relativeTest = RelativeResource "search?q=cat"
let baseTest = AbsoluteResource "https://google.com"

relativeTest.resolve baseTest


















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
        |> RelativeDirectoryPath.Create




(*

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
