#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "SparqlErgonomics.dll"
open SparqlErgonomics

#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl

#r "UrlErgonomics.dll"

open UrlErgonomics

open FSharp.Data

open Dubzer.WhatwgUrl
open PuppeteerSharp
open FsHttp
open System.IO.Compression
open System.IO
open VDS.RDF.Query.Datasets
open VDS.RDF
open VDS.RDF.Parsing
open System





let localVersionSet =
    Folder.fiboMaster.GetDirectories()
    |> Array.map (fun directory -> directory.Name)
    |> Set.ofArray

let latestRelease = DomUrl "https://github.com/edmcouncil/fibo/releases/latest"

let latestRemoteVersion =
    let master_ = "master_"

    task {
        let options = new CreatePageOptions()
        options.Background <- true
        let browser = CdpBrowser.Connect()
        let! tab = browser.NewPageAsync(options)
        let! response = tab.GoToAsync(latestRelease.Href)
        do! tab.CloseAsync()

        return response.asCdp.DomUrl.pathStem[master_.Length ..]
    }
    |> await

match localVersionSet.Contains(latestRemoteVersion) with
| true -> printfn "fibo version %s already downloaded" latestRemoteVersion
| false ->
    printfn "downloading fibo version %s" latestRemoteVersion

    let fiboZip =
        DomUrl $"https://spec.edmcouncil.org/fibo/ontology/master/{latestRemoteVersion}/prod.ttl.zip"

    let httpGetFiboZip (distribution: string) =
        http {

            GET distribution

        }
        |> Request.send

    let httpResponse = httpGetFiboZip fiboZip.Href

    if httpResponse.originalHttpResponseMessage.IsSuccessStatusCode then
        fiboZip.CreateFileDirectory()
        Response.saveFile fiboZip.asFile.FullName httpResponse

    if fiboZip.asFile.Exists then
        ZipFile.ExtractToDirectory(fiboZip.asFile.FullName, Folder.``spec.edmcouncil.org``.FullName)

Folder.``spec.edmcouncil.org``.FullName |> clip

let latestDirectory =
    Path.Combine(Folder.``spec.edmcouncil.org``.FullName, "fibo", "ontology", "master", latestRemoteVersion)
    |> DirectoryInfo

let fiboDataset = new InMemoryDataset()

[<Literal>]
let catalogFilePath =
    @"D:\Iri\https\spec.edmcouncil.org\fibo\ontology\master\2026Q2\catalog-v001.xml"

type CatalogProvider = XmlProvider<UseOriginalNames=true, PreferDateOnly=true, Sample=catalogFilePath>

let catalog = CatalogProvider.Load catalogFilePath

let fiboNamespaceNames =
    catalog.uris
    |> Array.map (fun fiboNamespace -> fiboNamespace.name)
    |> Set.ofArray

catalog.uris
|> Array.map (fun ontology ->

    let ttlFile =
        latestDirectory.FullName
        + ontology.uri.TrimStart('.').Replace("/", "\\")
        |> FileInfo

    let ttlGraph = new ThreadSafeGraph(Uri ontology.name |> UriNode)
    FileLoader.Load(ttlGraph, ttlFile.FullName)
    fiboDataset.AddGraph(ttlGraph)

)

type InMemoryDataset with
    member this.namespaceMap =
        let namespaceMapper = new NamespaceMapper()

        this.graphNames
        |> Array.iter (fun (graphName: IRefNode) -> namespaceMapper.Import this[graphName].NamespaceMap)

        namespaceMapper

    member this.graphNames =
        this.GraphNames
        |> Seq.filter (fun graphName -> not (isNull graphName))
        |> Seq.toArray

    member this.LoadDirectoryFiles (extensionPattern: string) (turtleDirectory: DirectoryInfo) =
        turtleDirectory.GetFiles(extensionPattern, SearchOption.AllDirectories)
        |> Array.map (fun file ->
            let fileGraph = new ThreadSafeGraph()
            FileLoader.Load(fileGraph, file.FullName)
            fiboDataset.AddGraph(fileGraph))

let fiboNamespaces =
    fiboDataset.namespaceMap.prefixIds
    |> Set.toArray
    |> Array.filter (fun prefixId -> fiboNamespaceNames.Contains prefixId.namespaceName)
    |> Array.map (fun prefixId ->


        ggg.NamespaceMap.AddNamespace prefixId.asNamespaceMap

        let fiboNamespace =
            catalog.uris
            |> Array.find (fun fiboNamespace -> fiboNamespace.name = prefixId.namespaceName)

        let ttlFile =
            latestDirectory.FullName
            + fiboNamespace
                .uri
                .TrimStart('.')
                .Replace("/", "\\")
            |> FileInfo

        let ttlGraph = new ThreadSafeGraph(Uri fiboNamespace.name |> UriNode)
        FileLoader.Load(ttlGraph, ttlFile.FullName)
        fiboDataset.AddGraph(ttlGraph) |> ignore

        { prefixId = prefixId
          namespaceDocument = { graphFile = ttlFile } }



    )
    |> Array.sortBy (fun fiboNamespace -> fiboNamespace.namespaceDocument.graphFile.Length)


let job =
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
