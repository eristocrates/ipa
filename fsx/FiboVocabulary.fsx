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
#r "Turtle.dll"
#r "ManualDistributions.dll"
open ManualDistributions

open PuppeteerSharp.Cdp
open PuppeteerSharp
open Meziantou.Framework
open VDS.RDF
open VDS.RDF.Parsing
open RDFSharp.Model
open FsHttp
open System.IO.Compression
open VDS.RDF.Query.Datasets
open FSharp.Data

module https =
    module com =
        module github =
            let site = IanaScheme.https ..// "github.com"
    module org =
        module edmcouncil =
            module spec =
                let site = IanaScheme.https ..// "spec.edmcouncil.org"


let ontology = https.org.edmcouncil.spec.site ./ "fibo/ontology"
let master = https.org.edmcouncil.spec.site ./ "fibo/ontology/master"
let latestRelease = https.com.github.site ./ "edmcouncil/fibo/releases/latest"
let localVersionSet =
    let masterDirectory = Directory.CreateDirectory master.localReference
    masterDirectory.GetDirectories()
    |> Array.map (fun directory -> directory.Name)
    |> Set.ofArray

let latestRemoteVersion =
    task {
        let options = new CreatePageOptions()
        options.Background <- true
        let browser = CdpBrowser.Connect()
        let! tab = browser.NewPageAsync(options)
        let! response = tab.GoToAsync(latestRelease.remoteReference)
        do! tab.CloseAsync()
        return response.asCdp.resource.pathStem["master_".Length ..]
    }
    |> await



match localVersionSet.Contains(latestRemoteVersion) with
| true -> printfn "fibo version %s already downloaded" latestRemoteVersion
| false ->
    printfn "downloading fibo version %s" latestRemoteVersion
    let fiboZip =
        https.org.edmcouncil.spec.site
        ./ $"fibo/ontology/master/{latestRemoteVersion}/prod.ttl.zip"
    let httpResponse = http { GET fiboZip.remoteReference } |> Request.send
    if httpResponse.originalHttpResponseMessage.IsSuccessStatusCode then
        Directory.CreateDirectory fiboZip.asAbsoluteFilePath.DirectoryPath.WeakString
        |> ignore
        Response.saveFile fiboZip.asAbsoluteFilePath.WeakString httpResponse
    if fiboZip.asFileInfo.Exists then
        ZipFile.ExtractToDirectory(fiboZip.asFileInfo.FullName, https.org.edmcouncil.spec.site.asAbsoluteDirectoryPath.WeakString)

let ontologyDirectory = ontology.asDirectoryInfo

let latestDirectory =
    Path.Combine(ontology.asDirectoryInfo.FullName, "master", latestRemoteVersion)
    |> DirectoryInfo
latestDirectory.CopyTo ontologyDirectory

ontologyDirectory.GetFiles("*.zip")
|> Array.iter (fun file -> File.Delete file.FullName)

latestDirectory.GetDirectories()
|> Array.iter (fun latestModuleDirectory -> Directory.Delete(latestModuleDirectory.FullName, true))


[<Literal>]
let catalogFilePath = @"D:\https\org\edmcouncil\spec\fibo\ontology\catalog-v001.xml"

type CatalogProvider = XmlProvider<UseOriginalNames=true, PreferDateOnly=true, Sample=catalogFilePath>

let catalog = CatalogProvider.Load catalogFilePath

let fiboNamespaceNames =
    catalog.uris
    |> Array.map (fun fiboNamespace -> fiboNamespace.name)
    |> Set.ofArray

let fiboDataset = new InMemoryDataset()
catalog.uris
|> Array.choose (fun ontology ->

    let ttlFile =
        ontologyDirectory.FullName + ontology.uri.TrimStart('.').Replace("/", "\\")
        |> FileInfo

    let ttlGraph = new ThreadSafeGraph(Uri ontology.name |> UriNode)
    FileLoader.Load(ttlGraph, ttlFile.FullName)
    match fiboDataset.AddGraph(ttlGraph) with
    | true -> None
    | false -> Some ontology)


(*

let start = 0
let stop = fiboNamespaces.Length

System.Threading.Tasks.Task.Run (fun () ->
    fiboNamespaces
    |> Array.sortBy (fun fiboNamespace -> fiboNamespace.namespaceDocument.graphFile.Length)
    |> Array.iteri (fun index fiboNamespace ->
        if not fiboNamespace.fsxFile.Exists then
            printfn "%d of %d %s" (start + index) stop fiboNamespace.prefixId.namespaceName

            RdfVocabulary.asModule fiboNamespace
            |> fun fsxText -> File.WriteAllText(fiboNamespace.fsxFile.FullName, fsxText)))




let omgCommonsNamespaces =
    fiboDataset.namespaceMap.prefixIds
    |> Set.toArray
    |> Array.filter (fun prefixId -> prefixId.namespaceUrl.Host = "www.omg.org")
    |> Array.map RdfVocabulary.fromPrefixId

omgCommonsNamespaces
|> Array.sortBy (fun omgCommonsNamespace -> omgCommonsNamespace.namespaceDocument.graphFile.Length)
|> Array.iteri (fun index omgCommonsNamespace ->
    if not omgCommonsNamespace.fsxFile.Exists then
        printfn "%d of %d %s" index omgCommonsNamespaces.Length omgCommonsNamespace.prefixId.namespaceName

        RdfVocabulary.asModule omgCommonsNamespace
        |> fun fsxText -> File.WriteAllText(omgCommonsNamespace.fsxFile.FullName, fsxText))
*)
