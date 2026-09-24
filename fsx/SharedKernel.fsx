#time on

fsi.PrintLength <- 10
fsi.PrintSize <- 100

// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"

#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"

open System

open TextCopy
open Nager.PublicSuffix
open Nager.PublicSuffix.Models
open Nager.PublicSuffix.RuleProviders
open System.Text
open FsHttp
open System.Net
open System.Xml.Linq
open FSharp.Data
open System.Net.NetworkInformation
open System.Net.Sockets
open System.IO
open System.IO.Compression
open System.Threading.Tasks
open ktsu.Semantics.Paths
open Meziantou.Framework
open VDS.RDF
open VDS.RDF.Storage
open Meziantou.Framework.DnsClient
open Meziantou.Framework.DnsClient.Query
open Meziantou.Framework.DnsClient.Response
open System.Xml.Linq
open FSharp.Data
open Fabulous.AST
open Fantomas.Core
open BrowserApi.Css.Authoring

fsi.AddPrinter<DirectoryPath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<AbsoluteDirectoryPath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<RelativeDirectoryPath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<FilePath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<AbsoluteFilePath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<RelativeFilePath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<AbsolutePath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<RelativePath>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<FileName>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<FileExtension>(fun strongString -> strongString.WeakString)
fsi.AddPrinter<UrlPatternResult>(fun uri ->
    sprintf
        """
Inputs = %A
Hash = %s
Hostname = %s
Password = %s
Pathname = %s
Port = %s
Protocol = %s
Search = %s
Username = %s
"""
        (uri.Inputs |> Seq.map (fun input -> input.Url))
        uri.Hash.Input
        uri.Hostname.Input
        uri.Password.Input
        uri.Pathname.Input
        uri.Port.Input
        uri.Protocol.Input
        uri.Search.Input
        uri.Username.Input)
let HttpRuleProvider = new SimpleHttpRuleProvider()
do HttpRuleProvider.BuildAsync().GetAwaiter().GetResult() |> ignore
let RegistrableDomainParser = new DomainParser(HttpRuleProvider)
let DnsClient = new DnsClient("https://cloudflare-dns.com/dns-query", DnsClientProtocol.Https)

let pathDelimiters = [| '/'; '\\'; ':'; '#' |]
let lexicalDelimiters = [| '-'; '.'; '+'; '/'; '#' |]

type DateOnly with
    static member Now = DateOnly.FromDateTime DateTime.Now
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

type LocalComputer() =
    let _localIPAddress =
        NetworkInterface.GetAllNetworkInterfaces()
        |> Seq.collect (fun networkInterface -> networkInterface.GetIPProperties().UnicastAddresses)
        |> Seq.map (fun unicastIp -> unicastIp.Address)
        |> Seq.pick (fun ipAddress ->
            if ipAddress.AddressFamily = AddressFamily.InterNetwork then
                Some ipAddress
            else
                None)
    member this.machineName = Environment.MachineName
    member this.hostName = Dns.GetHostName()
    member this.hostAddresses = Dns.GetHostAddresses this.hostName
    member this.networkInterfaces = NetworkInterface.GetAllNetworkInterfaces()
    member this.unicastIPAddresses =
        this.networkInterfaces
        |> Array.collect (fun networkInterface -> networkInterface.GetIPProperties().UnicastAddresses |> Seq.toArray)
    member this.localIPAddress = _localIPAddress
    member this.remoteIPAddress =
        http { GET "https://api.ipify.org" }
        |> Request.send
        |> Response.toText
        |> IPAddress.Parse

let decompressGz (sourceFile: FileInfo) =
    let targetFile = sourceFile.FullName[.. sourceFile.FullName.Length - 4] |> FileInfo
    // Open the compressed file stream
    use sourceStream = new FileStream(sourceFile.FullName, FileMode.Open, FileAccess.Read)

    // Create the decompression stream
    use decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress)

    // Create the destination file stream
    use targetStream = new FileStream(targetFile.FullName, FileMode.Create, FileAccess.Write)

    // Copy the decompressed data to the target file
    decompressionStream.CopyTo(targetStream)
    targetFile

type HtmlSelectProvider =
    XmlProvider<
        UseOriginalNames=true,
        Sample="""<select data-is-required="true" class="validation-strict" data-field-id="field9" name="field9" data-placement="right" data-toggle="tooltip" tooltip="" data-trigger="hover" data-html="true" data-original-title="" data-gtm-form-interact-field-id="0" style="border: 1px solid rgb(198, 6, 18); border-radius: 2px; --darkreader-inline-border-top: var(--darkreader-border-c60612, #bc0611); --darkreader-inline-border-right: var(--darkreader-border-c60612, #bc0611); --darkreader-inline-border-bottom: var(--darkreader-border-c60612, #bc0611); --darkreader-inline-border-left: var(--darkreader-border-c60612, #bc0611);" data-darkreader-inline-border-top="" data-darkreader-inline-border-right="" data-darkreader-inline-border-bottom="" data-darkreader-inline-border-left=""><option value="" class=" ">Select An Option</option><option value="Distributor" class=" ">Distributor</option><option value="DoD" class=" ">DoD</option><option value="Maintenance" class=" ">Maintenance</option><option value="Warranty" class=" ">Warranty</option><option value="Unsure" class=" ">Unsure</option></select>"""
     >
module HtmlSelectProvider =
    let codegenAstUnion (unionName: string) (selectText: string) =
        let options =
            (HtmlSelectProvider.Parse selectText).options
            |> Array.choose (fun option -> Option.tryNullOrWhiteSpace option.value)

        Ast.Oak() {
            Ast.AnonymousModule() {
                Ast.Union(unionName) {
                    for option in options do
                        Ast.UnionCase option
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run
