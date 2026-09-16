#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.Linq
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
#r "RdfAsm.dll"
open RdfAsm
#r "RdfIO.dll"
open RdfIO
#r "Lov.dll"

open Lov
#r "FSLang.dll"
open PuppeteerSharp.Cdp
open PuppeteerSharp
open Meziantou.Framework
open VDS.RDF
open VDS.RDF.Parsing
open RDFSharp.Model
open System.Net.Http
open VDS.RDF.Query.Datasets



let loaderHttpClient = new HttpClient()

[|
    "application/trig;q=1"
    "application/n-quads;q=0.95"
    "text/turtle;q=0.9"
    "application/n-triples;q=0.85"
    "application/rdf+xml;q=0.8"
    "application/ld+json;q=0.75"
    "application/json;q=0.7"
    "application/xml;q=0.6"
    "text/xml;q=0.55"
    "text/html;q=0.4"
    "text/plain;q=0.2"
    "text/plain;charset=utf-8;q=0.2"
    "*/*;q=0.1"

|]
|> Array.iter (fun contentType -> loaderHttpClient.DefaultRequestHeaders.Accept.ParseAdd(contentType))



let rdfLoader = new Loader(loaderHttpClient)
rdfLoader.FollowRedirects <- true


let loaderGraph = new ThreadSafeGraph()


let chrome = CdpBrowser.Connect()




let vocabularyTab = chrome.NewPageAsync(backgroundOption).await.asCdp


let distributionMap = graphDistributions |> Map.ofArray



let registeredPrefixIds =
    graphDistributions
    |> Array.choose (fun (namespaceName, distributionResource) -> RDFNamespaceRegister.GetByUri(namespaceName, false) |> Option.ofNullOrWhiteSpace)
    |> Array.choose (fun rdfNamespace ->

        try
            PrefixId.fromNamespaceLabel rdfNamespace.NamespaceName rdfNamespace.NamespacePrefix
            |> Some
        with err ->
            printfn "%s errored with %s" rdfNamespace.NamespaceUri.OriginalString err.Message
            None)




(*
http://purl.org/dc/dcam/ errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://purl.org/dc/dcmitype/ errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://purl.org/dc/elements/1.1/ errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://purl.org/dc/terms/ errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.opengis.net/ont/geosparql# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.opengis.net/ont/sf# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/1999/02/22-rdf-syntax-ns# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/2000/01/rdf-schema# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/2001/XMLSchema# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/2002/07/owl# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/2004/02/skos/core# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/2006/time# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://www.w3.org/ns/shacl# errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
http://xmlns.com/foaf/0.1/ errored with The type initializer for '<StartupCode$RdfAsm>.$RdfAsm$fsx' threw an exception.
*)

registeredPrefixIds
|> Array.iter (fun prefixId ->
    match prefixId.namespaceTurtleFilePath, (ResolvedResource.fromUri prefixId.namespaceUri).asFileInfo with
    | namespaceTurtleFilePath, localReferenceFile when namespaceTurtleFilePath.Exists = false && localReferenceFile.Exists = true ->
        try
            let downloadedGraph = new ThreadSafeGraph()
            FileLoader.Load(downloadedGraph, localReferenceFile.FullName)
            downloadedGraph
            |> Turtle.writeIgraph
                prefixId.namespaceTurtleFilePath.DirectoryPath.WeakString
                prefixId.namespaceTurtleFilePath.FileNameWithoutExtension.WeakString
                (downloadedGraph.NamespaceMap :?> NamespaceMapper)
            printfn "created namespace turtle file for %s" prefixId.namespaceName
        with err ->
            printfn "\t\t\terror creating namespace turtle file for %s" prefixId.namespaceName
    | namespaceTurtleFilePath, localReferenceFile -> ())









let recursionLimit = 3
let rec tryResponse (counter: int) (prefixId: PrefixId) (response: CdpHttpResponse) =

    if counter + 1 > recursionLimit then
        printfn "recursion limitereached for %s" prefixId.namespaceName
        false
    else
        match response.mediaType.file with
        | "text/turtle" ->
            prefixId.namespaceAbsoluteDirectoryPath / response.mediaType.asRelativeFilePath
            |> response.WriteAllText
            true
        | "text/plain"
        | "text/html" ->
            match distributionMap.TryFind prefixId.namespaceName with
            | Some distribution ->
                try
                    vocabularyTab.GoToAsync(distribution.remoteReference).await.asCdp
                    |> tryResponse (counter + 1) prefixId
                with err ->
                    let downloadedFile =
                        Path.Combine(ResolvedResource.Downloads.localReference, distribution.asFileInfo.Name)
                        |> FileInfo
                    printfn "%s %s tab response text failed" prefixId.namespaceName distribution.remoteReference
                    printfn "%s %s checking for %s in Downloads " prefixId.namespaceName distribution.remoteReference downloadedFile.FullName
                    if downloadedFile.Exists then
                        printfn "%s %s text found in download folder" prefixId.namespaceName distribution.remoteReference
                        let downloadedGraph = new ThreadSafeGraph()
                        FileLoader.Load(downloadedGraph, downloadedFile.FullName)
                        downloadedGraph
                        |> Turtle.writeIgraph
                            prefixId.namespaceTurtleFilePath.DirectoryPath.WeakString
                            prefixId.namespaceTurtleFilePath.FileNameWithoutExtension.WeakString
                            (downloadedGraph.NamespaceMap :?> NamespaceMapper)
                        true
                    else
                        printfn "%s %s no text found in downloded folder" prefixId.namespaceName distribution.remoteReference
                        false
            | None ->
                printfn "no distribution found for %s" prefixId.namespaceName
                false
        | contentType ->
            printfn "unhandled mime type %s" contentType
            false

let problemPrefixIds =
    Task.Run(fun () ->
        registeredPrefixIds
        |> Array.filter (fun prefixId -> not prefixId.namespaceTurtleFilePath.Exists)
        |> Array.filter (fun prefixId -> not (ResolvedResource.fromUri prefixId.namespaceUri).asFileInfo.Exists)
        |> Array.filter (fun prefixId ->
            try
                vocabularyTab.GoToAsync(prefixId.namespaceName).await.asCdp
                |> tryResponse 0 prefixId
                |> not
            with _ ->
                false))


type IGraph with
    member this.namespaceMapper = this.NamespaceMap :?> NamespaceMapper


(*

let lov_n3 = https.es.linkeddata.lov.n3.resource
let lov_nq = https.es.linkeddata.lov.nq.resource
let nqParser = NQuadsParser()
let lovGraph = new ThreadSafeGraph()

FileLoader.Load(lovGraph, lov_n3.localReference)



let vann_preferredNamespacePrefix = Uri "http://purl.org/vocab/vann/preferredNamespacePrefix" |> UriNode
let vann_preferredNamespaceUri = Uri "http://purl.org/vocab/vann/preferredNamespaceUri" |> UriNode
let dcat_distribution = Uri "http://www.w3.org/ns/dcat#distribution" |> UriNode


let lovTripleStore = new ThreadSafeTripleStore()
nqParser.Load(lovTripleStore, lov_nq.localReference)
let lovDataset = new InMemoryQuadDataset(lovTripleStore)
let graphCount = lovDataset.GraphNames.Count()




let missingNamespaceDistributions =
    graphDistributions
    |> Array.filter (fun (namespaceName, namespaceDistribution) ->
        let prefixId = PrefixId.fromNamespaceLabel namespaceName String.Empty
        not prefixId.namespaceTurtleFilePath.Exists)
missingNamespaceDistributions[0]

let downloadDistributions (distributionFilter: string * ResolvedResource -> bool) (distributions: array<string * ResolvedResource>) =
    distributions
    |> Array.filter distributionFilter
    |> Array.Parallel.iter (fun (namespaceName, namespaceDistribution) ->
        try
            let namespaceDirectoryPath = namespaceAbsoluteDirectoryPath namespaceName
            let namespaceResource = Uri namespaceName |> ResolvedResource.fromUri
            printfn "namespaceName : %s\n\tnamespaceDistribution : %s\n\n" namespaceName namespaceDistribution.remoteReference
            let options = new CreatePageOptions()
            options.Background <- true
            let distributionTab = chrome.NewPageAsync(options).await.asCdp
            let distributionFile =
                try
                    match IanaMediaTypesByDotExtension.TryFind namespaceDistribution.asAbsoluteFilePath.FileExtension.WeakString with
                    | Some [| distributionMediaType |] -> namespaceDirectoryPath / distributionMediaType.asRelativeFilePath
                    | _ -> namespaceDistribution.asAbsoluteFilePath
                with _ ->
                    namespaceResource.asAbsoluteFilePath
            let downloadedFile =
                Path.Combine(ResolvedResource.Downloads.localReference, namespaceDistribution.asFileInfo.Name)
                |> FileInfo
            let maybeDistributionText =
                if not downloadedFile.Exists then
                    try
                        printfn "%s %s trying to get text from tab" namespaceResource.remoteReference namespaceDistribution.remoteReference
                        distributionTab.GoToAsync(namespaceDistribution.remoteReference).await.asCdp.TextAsync().await
                        |> Some
                    with _ ->
                        printfn "%s %s tab response text failed" namespaceResource.remoteReference namespaceDistribution.remoteReference
                        printfn "%s %s checking for %s in Downloads " namespaceResource.remoteReference namespaceDistribution.remoteReference downloadedFile.FullName
                        if downloadedFile.Exists then
                            printfn "%s %s text found in download folder" namespaceResource.remoteReference namespaceDistribution.remoteReference
                            File.ReadAllText(downloadedFile.FullName) |> Some
                        else
                            printfn "%s %s no text found in downloded folder" namespaceResource.remoteReference namespaceDistribution.remoteReference
                            None
                else if downloadedFile.Exists then
                    printfn "%s %s text found in download folder" namespaceResource.remoteReference namespaceDistribution.remoteReference
                    File.ReadAllText(downloadedFile.FullName) |> Some
                else
                    printfn "%s %s no text found in downloded folder" namespaceResource.remoteReference namespaceDistribution.remoteReference
                    None
            match maybeDistributionText with
            | Some distributionText ->
                printfn "%s %s distribution text found" namespaceResource.remoteReference namespaceDistribution.remoteReference
                Directory.CreateDirectory distributionFile.DirectoryPath.WeakString |> ignore
                File.WriteAllText(distributionFile.WeakString, distributionText)
                printfn "%s %s saved text at %s" namespaceResource.remoteReference namespaceDistribution.remoteReference distributionFile.WeakString
                match namespaceDistribution.extension with
                | Some ".ttl" ->
                    try
                        let distributionGraph = new ThreadSafeGraph()
                        FileLoader.Load(distributionGraph, distributionFile.WeakString)
                        let parentDirectory = Path.Combine(namespaceDirectoryPath.WeakString, "text")
                        distributionGraph |> Turtle.writeIgraph parentDirectory "turtle" namespaceMapper
                    with _ ->
                        ()
                | _ -> ()
            | None -> printfn "%s %s no distribution text found" namespaceResource.remoteReference namespaceDistribution.remoteReference
            distributionTab.CloseAsync() |> ignore
        with err ->
            printfn "namespaceName %s  failed with error %s" namespaceName err.Message
        Thread.Sleep(1000))




let distributionFilter (namespaceName: string, namespaceDistribution: ResolvedResource) = true
// namespaceName.absoluteRoot.asRemoteUrl.Host = "www.semanticdesktop.org"



graphDistributions
// |> Array.take 10
|> Array.chunkBySize 10
|> Array.iter (fun chunk ->
    chunk |> downloadDistributions distributionFilter
    Thread.Sleep(5000))






// TODO process Lov, then reference all prefixes across downloaded files
// TODO figure out datasetDistributions

let maybePrefixIdFromUrl (namespaceName: string) =
    match RDFNamespaceRegister.GetByUri(namespaceName, true) with
    | null -> None
    | rdfNamespace -> Some rdfNamespace.asPrefixId


*)

let ttlFiles =
    let httpDirectory = DirectoryInfo "D:\http"
    let httpsDirectory = DirectoryInfo "D:\https"
    Array.concat [|
        httpDirectory.GetFiles("*.ttl", SearchOption.AllDirectories)
        httpsDirectory.GetFiles("*.ttl", SearchOption.AllDirectories)
    |]

let rawPrefixIds =
    ttlFiles
    |> Array.Parallel.collect (fun ttlFile ->
        let ttlGraph = new ThreadSafeGraph()
        try
            FileLoader.Load(ttlGraph, ttlFile.FullName)
            ttlGraph.namespaceMapper.prefixIds |> Set.toArray
        with err ->
            printfn "%s errored with %s" ttlFile.FullName err.Message
            [||])
    |> Array.distinct




let namespaceName_prefixes =
    rawPrefixIds
    |> Array.groupBy (fun prefixId -> prefixId.namespaceName)
    |> Array.Parallel.map (fun (namespaceName, prefixIds) ->
        namespaceName,
        prefixIds
        |> Array.map (fun prefixId -> prefixId.prefixLabel)
        |> Array.filter (fun prefix -> not (prefix.StartsWith("ns") && Char.IsAsciiDigit(prefix.ToCharArray() |> Array.last)))
        |> Array.sortBy (fun prefix -> prefix.Length)
        |> Array.rev)
    |> Array.sortBy (fun (namespaceName, prefixes) -> prefixes.Length)
    |> Array.rev




let prefixIds =
    namespaceName_prefixes
    |> Array.filter (fun (namespaceName, prefixes) -> prefixes.Length > 0)
    |> Array.filter (fun (namespaceName, prefixes) -> not (String.IsNullOrWhiteSpace prefixes[0]))
    |> Array.map (fun (namespaceName, prefixes) ->
        let prefix =
            match namespaceName with
            | "http://qudt.org/2.1/vocab/sou/" -> "sou21"
            | "http://id.loc.gov/authorities/genreForms/" -> "genreForms"
            | "http://purl.org/ontology/bibo/status/" -> "biboStatus"
            | "http://purl.org/ontology/cco/core#" -> "ccore"
            | "http://purl.org/NET/c4dm/event.owl#" -> "c4dmEvent"
            | "https://schema.org/" -> "schemas"
            | "http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#" -> "reprSciUnits"
            | "http://www.w3.org/2006/time#" -> "owltime"
            | "http://spdx.org/rdfterms/spdx#" -> "spdxterms"
            | "https://www.omg.org/spec/Commons/TextDatatype/" -> "cmns-txtdt"
            | "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#" -> "observation"
            | "http://www.w3.org/2000/10/swap/pim/doc#" -> "docpim"
            | "https://spdx.org/rdf/3.1/terms/Service/" -> "spdxService"
            | "https://spdx.org/rdf/3.1/terms/Core/" -> "spdxCore"
            | "https://spdx.org/rdf/3.1/terms/Hardware/" -> "spdxHardware"
            | "https://spdx.org/rdf/3.1/terms/FunctionalSafety/" -> "spdxFunctionalSafety"
            | "https://spdx.org/rdf/3.1/terms/Dataset/" -> "spdxDataset"
            | "https://spdx.org/rdf/3.1/terms/Security/" -> "spdxSecurity"
            | "https://spdx.org/rdf/3.1/terms/AI/" -> "spdxAI"
            | "https://spdx.org/rdf/3.1/terms/Software/" -> "spdxSoftware"
            | "https://spdx.org/rdf/3.1/terms/SupplyChain/" -> "spdxSupplyChain"
            | "https://spdx.org/rdf/3.1/terms/ExpandedLicensing/" -> "spdxExpandedLicensing"
            | "http://purl.obolibrary.org/obo/bfo#" -> "bfo"
            | "http://kaiko.getalp.org/dbnary#" -> "dbnary"
            | "http://www.lexinfo.net/ontology/3.0/lexinfo#" -> "lexinfo"
            | "https://w3id.org/function/vocabulary/implementation#" -> "fnoi"
            | "https://w3id.org/function/vocabulary/mapping#" -> "fnom"
            | "https://w3id.org/function/vocabulary/composition#" -> "fnoc"
            | "http://www.daml.org/services/owl-s/1.2/generic/Expression.owl#" -> "damlExpression"
            | "https://www.commoncoreontologies.org/BarcodeOntology/" -> "ccoBarcode"
            | "https://www.commoncoreontologies.org/FamilialRelationsOntology/" -> "ccoFamilial"
            | "https://w3id.org/function/ontology#" -> "fno"
            | "https://www.commoncoreontologies.org/QualityOntology/" -> "ccoQuality"
            | "http://www.w3.org/ns/dcat#" -> "dcat"
            | _ -> prefixes[0]
        PrefixId.fromNamespaceLabel namespaceName prefix)




let rdfVocabularies =
    prefixIds
    |> Array.filter (fun prefixId -> (FileInfo prefixId.namespaceTurtleFilePath.WeakString).Exists)
    |> Array.map (fun prefixId -> RdfVocabulary.fromPrefixId prefixId)
    |> Array.sortBy (fun rdfVocabulary -> rdfVocabulary.namespaceDocument.graphFile.Length)
(*

let vocabularyCount = rdfVocabularies.Length

Task.Run(fun () ->

    rdfVocabularies
    |> Array.skip 898
    |> Array.iteri (fun index rdfVocabulary ->
        try
            printfn "%d of %d:\t\t%s %s" index vocabularyCount rdfVocabulary.prefixId.namespaceName rdfVocabulary.fsxFile.FullName
            File.WriteAllText(rdfVocabulary.fsxFile.FullName, RdfVocabulary.asModule rdfVocabulary)
        with err ->
            printfn "%s had error %s" rdfVocabulary.prefixId.namespaceName err.Message))





*)







(*

sprintf
    "%A"
    (prefixIds
     |> Array.groupBy (fun prefixId -> prefixId.prefixLabel)
     |> Array.filter (fun (prefixLabel, prefixIds) -> prefixIds.Length > 1))
|> String.clip

let namespaceNamesNeedingPrefix = 
    Array.concat [|
        namespaceName_prefixes |> Array.filter (fun (namespaceName, prefixes) -> prefixes.Length = 0)
        namespaceName_prefixes |> Array.filter (fun (namespaceName, prefixes) -> prefixes.Length = 1 && String.IsNullOrWhiteSpace prefixes[0])
    |]
    |> Array.map (fun (namespaceName, _) -> namespaceName)
    |> Array.distinct
sprintf "%A" namespaceNamesNeedingPrefix |> String.clip



prefixIds
|> Array.map (fun prefixId -> 
    let letBinder = FSLang.VariableBinder prefixId.prefixLabel
    sprintf "static member %s = PrefixId.fromNamespaceLabel \"%s\" \"%s\"" letBinder.binding prefixId.namespaceName prefixId.prefixLabel
)
|> Array.sort
|> String.concat "\n"
|> String.clip
*)

(*
D:\https\org\w3id\amv&num;\text\turtle.ttl errored with [DotToken at Line 521 Column 19 to Line 521 Column 20] Unexpected Token 'VDS.RDF.Parsing.Tokens.DotToken' encountered while trying to parse a Predicate Object list
D:\http\org\example\dctap&num;\text\turtle.ttl errored with Unable to resolve the QName 'dcterms:title' due to the following error:
The Namespace URI for the given Prefix 'dcterms' is not known by the in-scope NamespaceMapper
D:\http\org\purl\spar\fivestars&sol;\text\turtle.ttl errored with [Line 2 Column 21] The value of the Plain Literal 'Too' is not valid in Turtle.  Turtle supports Boolean, Integer, Decimal and Double Plain Literals
D:\http\org\purl\spar\fr&sol;\text\turtle.ttl errored with [Line 2 Column 21] The value of the Plain Literal 'Too' is not valid in Turtle.  Turtle supports Boolean, Integer, Decimal and Double Plain Literals
D:\http\org\purl\spar\frbr&sol;\text\turtle.ttl errored with [Line 2 Column 21] The value of the Plain Literal 'Too' is not valid in Turtle.  Turtle supports Boolean, Integer, Decimal and Double Plain Literals
D:\https\cc\prefix\popular\all.ttl errored with Didn't find expected : Character while attempting to parse Prefix at content:
PREFIX
Prefixes must end in a Colon Character
*)







type PrefixId with
    static member CPSWatch = PrefixId.fromNamespaceLabel "https://w3id.org/CPSWatch#" "CPSWatch"
    static member IIoT = PrefixId.fromNamespaceLabel "https://w3id.org/IIoT#" "IIoT"
    static member SAN = PrefixId.fromNamespaceLabel "http://www.irit.fr/recherches/MELODI/ontologies/SAN#" "SAN"
    static member a4bdg = PrefixId.fromNamespaceLabel "https://w3id.org/aerOS/building#" "a4bdg"
    static member a_loc = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/location/" "a-loc"
    static member ac = PrefixId.fromNamespaceLabel "http://rs.tdwg.org/ac/terms/" "ac"
    static member acco = PrefixId.fromNamespaceLabel "http://purl.org/acco/ns#" "acco"
    static member acl = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/auth/acl#" "acl"
    static member acm = PrefixId.fromNamespaceLabel "http://acm.rkbexplorer.com/ontologies/acm#" "acm"
    static member acrt = PrefixId.fromNamespaceLabel "http://privatealpha.com/ontology/certification/1#" "acrt"
    static member adms = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/adms#" "adms"
    static member aeros = PrefixId.fromNamespaceLabel "https://w3id.org/aerOS/continuum#" "aeros"
    static member af = PrefixId.fromNamespaceLabel "http://purl.org/ontology/af/" "af"
    static member agent = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/agent#" "agent"
    static member agls = PrefixId.fromNamespaceLabel "http://www.agls.gov.au/agls/terms/" "agls"
    static member agr = PrefixId.fromNamespaceLabel "http://promsns.org/def/agr#" "agr"
    static member agrelon = PrefixId.fromNamespaceLabel "http://d-nb.info/standards/elementset/agrelon#" "agrelon"
    static member aiiso = PrefixId.fromNamespaceLabel "http://purl.org/vocab/aiiso/schema#" "aiiso"
    static member airo = PrefixId.fromNamespaceLabel "https://w3id.org/airo#" "airo"
    static member airs = PrefixId.fromNamespaceLabel "https://raw.githubusercontent.com/airs-linked-data/lov/latest/src/airs_vocabulary.ttl#" "airs"
    static member akt = PrefixId.fromNamespaceLabel "http://www.aktors.org/ontology/portal#" "akt"
    static member akts = PrefixId.fromNamespaceLabel "http://www.aktors.org/ontology/support#" "akts"
    static member algo = PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/securityAlgorithms#" "algo"
    static member alignment = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/alignmentType/" "alignment"
    static member am = PrefixId.fromNamespaceLabel "http://open-services.net/ns/asset#" "am"
    static member aml = PrefixId.fromNamespaceLabel "https://w3id.org/i40/aml#" "aml"
    static member amlo_core = PrefixId.fromNamespaceLabel "http://w3id.org/amlo/core#" "amlo-core"
    static member ao = PrefixId.fromNamespaceLabel "http://purl.org/ontology/ao/core#" "ao"
    static member aos = PrefixId.fromNamespaceLabel "http://rdf.muninn-project.org/ontologies/appearances#" "aos"
    static member apco = PrefixId.fromNamespaceLabel "https://purl.org/cm/onto/apco#" "apco"
    static member api = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/api/vocab#" "api"
    static member apps4X = PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/apps4X#" "apps4X"
    static member arch = PrefixId.fromNamespaceLabel "http://purl.org/archival/vocab/arch#" "arch"
    static member arco = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/core/" "arco"
    static member arp = PrefixId.fromNamespaceLabel "http://www.arpenteur.org/ontology/Arpenteur.owl#" "arp"
    static member as_ = PrefixId.fromNamespaceLabel "https://www.w3.org/ns/activitystreams#" "as"
    static member atd = PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/data#" "atd"
    static member atm = PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/ATM#" "atm"
    static member attack = PrefixId.fromNamespaceLabel "http://w3id.org/sepses/vocab/ref/attack#" "attack"
    static member atts = PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/general#" "atts"
    static member audRole = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/educationalAudienceRole/" "audRole"
    static member authn_provider = PrefixId.fromNamespaceLabel "https://w3id.org/inrupt/namespace/vocab/authn_provider/" "authn_provider"
    static member awol = PrefixId.fromNamespaceLabel "http://bblfish.net/work/atom-owl/2006-06-06/#" "awol"
    static member aws = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/meteo/aws#" "aws"
    static member bag = PrefixId.fromNamespaceLabel "http://bag.basisregistraties.overheid.nl/def/bag#" "bag"
    static member basic = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19103/2005/basic#" "basic"
    static member bato = PrefixId.fromNamespaceLabel "http://w3id.org/emmo-bto/bto#" "bato"
    static member bbc = PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/bbc/" "bbc"
    static member bbccms = PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/cms/" "bbccms"
    static member bbccore = PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/coreconcepts/" "bbccore"
    static member bbcprov = PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/provenance/" "bbcprov"
    static member bci = PrefixId.fromNamespaceLabel "https://w3id.org/BCI-ontology#" "bci"
    static member bcom = PrefixId.fromNamespaceLabel "https://w3id.org/bcom#" "bcom"
    static member bdi = PrefixId.fromNamespaceLabel "https://w3id.org/fossr/ontology/bdi/" "bdi"
    static member being = PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/ext/common/being#" "being"
    static member bevon = PrefixId.fromNamespaceLabel "http://rdfs.co/bevon/" "bevon"
    static member bf = PrefixId.fromNamespaceLabel "http://id.loc.gov/ontologies/bibframe/" "bf"
    static member bflc = PrefixId.fromNamespaceLabel "http://id.loc.gov/ontologies/bflc/" "bflc"
    static member bibo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/bibo/" "bibo"
    static member biboStatus = PrefixId.fromNamespaceLabel "http://purl.org/ontology/bibo/status/" "biboStatus"
    static member bibtex = PrefixId.fromNamespaceLabel "http://purl.org/net/nknouf/ns/bibtex#" "bibtex"
    static member bido = PrefixId.fromNamespaceLabel "http://purl.org/spar/bido/" "bido"
    static member bimerr_op = PrefixId.fromNamespaceLabel "http://bimerr.iot.linkeddata.es/def/occupancy-profile#" "bimerr-op"
    static member bio = PrefixId.fromNamespaceLabel "http://purl.org/vocab/bio/0.1/" "bio"
    static member biol = PrefixId.fromNamespaceLabel "http://purl.org/NET/biol/ns#" "biol"
    static member biopax = PrefixId.fromNamespaceLabel "http://www.biopax.org/release/biopax-level3.owl#" "biopax"
    static member biotop = PrefixId.fromNamespaceLabel "http://purl.org/biotop/biotop.owl#" "biotop"
    static member biro = PrefixId.fromNamespaceLabel "http://purl.org/spar/biro/" "biro"
    static member bisko = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/bioSKOSSchemes#" "bisko"
    static member blt = PrefixId.fromNamespaceLabel "http://www.bl.uk/schemas/bibliographic/blterms#" "blt"
    static member bot = PrefixId.fromNamespaceLabel "http://swa.cefriel.it/ontologies/botdcat-ap#" "bot"
    static member botany = PrefixId.fromNamespaceLabel "http://purl.org/NET/biol/botany#" "botany"
    static member bperson = PrefixId.fromNamespaceLabel "http://data.vlaanderen.be/ns/persoon#" "bperson"
    static member br = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/br#" "br"
    static member brk = PrefixId.fromNamespaceLabel "http://brk.basisregistraties.overheid.nl/def/brk#" "brk"
    static member brt = PrefixId.fromNamespaceLabel "http://brt.basisregistraties.overheid.nl/def/top10nl#" "brt"
    static member bto = PrefixId.fromNamespaceLabel "https://w3id.org/bot#" "bto"
    static member c4dmEvent = PrefixId.fromNamespaceLabel "http://purl.org/NET/c4dm/event.owl#" "c4dmEvent"
    static member c4n = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/c4n#" "c4n"
    static member c4o = PrefixId.fromNamespaceLabel "http://purl.org/spar/c4o/" "c4o"
    static member cal = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/12/cal/ical#" "cal"
    static member care = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/care#" "care"
    static member caresses = PrefixId.fromNamespaceLabel "http://caressesrobot.org/ontology#" "caresses"
    static member cart = PrefixId.fromNamespaceLabel "http://purl.org/net/cartCoord#" "cart"
    static member caso = PrefixId.fromNamespaceLabel "http://www.w3id.org/def/caso#" "caso"
    static member cbcm = PrefixId.fromNamespaceLabel "http://w3id.org/um/cbcm/eu-cm-ontology#" "cbcm"
    static member cbo = PrefixId.fromNamespaceLabel "http://comicmeta.org/cbo/" "cbo"
    static member cbs = PrefixId.fromNamespaceLabel "http://betalinkeddata.cbs.nl/def/cbs#" "cbs"
    static member cc = PrefixId.fromNamespaceLabel "http://creativecommons.org/ns#" "cc"
    static member cci = PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccinstances#" "cci"
    static member cco = PrefixId.fromNamespaceLabel "https://www.commoncoreontologies.org/" "cco"
    static member ccore = PrefixId.fromNamespaceLabel "http://purl.org/ontology/cco/core#" "ccore"
    static member ccp = PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccpricing#" "ccp"
    static member ccr = PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccregions#" "ccr"
    static member ccsla = PrefixId.fromNamespaceLabel "http://cookingbigdata.com/linkeddata/ccsla#" "ccsla"
    static member cdc = PrefixId.fromNamespaceLabel "https://w3id.org/cdc#" "cdc"
    static member cdesc = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/context-description/" "cdesc"
    static member cdm = PrefixId.fromNamespaceLabel "http://purl.org/twc/ontology/cdm.owl#" "cdm"
    static member cdtype = PrefixId.fromNamespaceLabel "http://purl.org/cld/cdtype/" "cdtype"
    static member ce = PrefixId.fromNamespaceLabel "https://purl.org/cityexplorer#" "ce"
    static member cem = PrefixId.fromNamespaceLabel "https://w3id.org/CEMontology/" "cem"
    static member ceo = PrefixId.fromNamespaceLabel "http://www.ebusiness-unibw.org/ontologies/consumerelectronics/v1#" "ceo"
    static member ceon_actor = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/actor/" "ceon-actor"
    static member ceon_actorODP = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/actorODP/" "ceon-actorODP"
    static member ceon_cvn = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/cvn/" "ceon-cvn"
    static member ceon_energy = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/energy/" "ceon-energy"
    static member ceon_material = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/material/" "ceon-material"
    static member ceon_plan = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/plan/" "ceon-plan"
    static member ceon_process = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/process/" "ceon-process"
    static member ceon_processODP = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/processODP/" "ceon-processODP"
    static member ceon_product = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/product/" "ceon-product"
    static member ceon_resourceODP = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/resourceODP/" "ceon-resourceODP"
    static member ceon_value = PrefixId.fromNamespaceLabel "http://w3id.org/CEON/ontology/value/" "ceon-value"
    static member cerif = PrefixId.fromNamespaceLabel "http://www.eurocris.org/ontologies/cerif/1.3#" "cerif"
    static member cert = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/auth/cert#" "cert"
    static member cevent = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/cultural-event/" "cevent"
    static member cff = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/cf/cf-feature#" "cff"
    static member cfp = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/cf/cf-property#" "cfp"
    static member cfrl = PrefixId.fromNamespaceLabel "http://linkeddata.finki.ukim.mk/lod/ontology/cfrl#" "cfrl"
    static member cgov = PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/central-government/" "cgov"
    static member chameo = PrefixId.fromNamespaceLabel "https://w3id.org/emmo/domain/characterisation-methodology/chameo#" "chameo"
    static member chord = PrefixId.fromNamespaceLabel "http://purl.org/ontology/chord/" "chord"
    static member ci = PrefixId.fromNamespaceLabel "https://privatealpha.com/ontology/content-inventory/1#" "ci"
    static member cis = PrefixId.fromNamespaceLabel "http://dati.beniculturali.it/cis/" "cis"
    static member citedcat = PrefixId.fromNamespaceLabel "https://w3id.org/citedcat-ap/" "citedcat"
    static member cito = PrefixId.fromNamespaceLabel "http://purl.org/spar/cito/" "cito"
    static member citof = PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2013/03/cito-functions/" "citof"
    static member cl = PrefixId.fromNamespaceLabel "http://advene.org/ns/cinelab/ld#" "cl"
    static member cld = PrefixId.fromNamespaceLabel "http://purl.org/cld/terms/" "cld"
    static member clinskosch = PrefixId.fromNamespaceLabel "http://www.agfa.com/w3c/2009/clinicalSKOSSchemes#" "clinskosch"
    static member cmd = PrefixId.fromNamespaceLabel "https://w3id.org/cmd#" "cmd"
    static member cmns_bauth = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/BusinessAuthorizations/" "cmns-bauth"
    static member cmns_cds = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/CodesAndCodeSets/" "cmns-cds"
    static member cmns_cls = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Classifiers/" "cmns-cls"
    static member cmns_col = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Collections/" "cmns-col"
    static member cmns_cxtdsg = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/ContextualDesignators/" "cmns-cxtdsg"
    static member cmns_cxtid = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/ContextualIdentifiers/" "cmns-cxtid"
    static member cmns_doc = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Documents/" "cmns-doc"
    static member cmns_dsg = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Designators/" "cmns-dsg"
    static member cmns_dt = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/DatesAndTimes/" "cmns-dt"
    static member cmns_ge = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/GeopoliticalEntities/" "cmns-ge"
    static member cmns_id = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Identifiers/" "cmns-id"
    static member cmns_loc = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Locations/" "cmns-loc"
    static member cmns_org = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Organizations/" "cmns-org"
    static member cmns_pts = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/PartiesAndSituations/" "cmns-pts"
    static member cmns_q = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Quantities/" "cmns-q"
    static member cmns_qtu = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/QuantitiesAndUnits/" "cmns-qtu"
    static member cmns_ra = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/RegistrationAuthorities/" "cmns-ra"
    static member cmns_rga = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/RegulatoryAgencies/" "cmns-rga"
    static member cmns_rlcmp = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/RolesAndCompositions/" "cmns-rlcmp"
    static member cmns_sfc = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/SitesAndFacilities/" "cmns-sfc"
    static member cmns_txt = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/Text/" "cmns-txt"
    static member cmns_txtdt = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/TextDatatype/" "cmns-txtdt"
    static member cmo = PrefixId.fromNamespaceLabel "http://purl.org/twc/ontologies/cmo.owl#" "cmo"
    static member cnt = PrefixId.fromNamespaceLabel "http://www.w3.org/2011/content#" "cnt"
    static member co = PrefixId.fromNamespaceLabel "http://purl.org/ontology/co/core#" "co"
    static member coach = PrefixId.fromNamespaceLabel "https://w3id.org/coach#" "coach"
    static member cochrane = PrefixId.fromNamespaceLabel "http://data.cochrane.org/ontologies/core/" "cochrane"
    static member cocoon = PrefixId.fromNamespaceLabel "https://w3id.org/cocoon/v1.0#" "cocoon"
    static member cogs = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/cogs#" "cogs"
    static member cold = PrefixId.fromNamespaceLabel "http://purl.org/configurationontology#" "cold"
    static member coll = PrefixId.fromNamespaceLabel "http://purl.org/co/" "coll"
    static member comm = PrefixId.fromNamespaceLabel "http://vocab.resc.info/communication#" "comm"
    static member common = PrefixId.fromNamespaceLabel "http://www.w3.org/2007/uwa/context/common.owl#" "common"
    static member con = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/10/swap/pim/contact#" "con"
    static member constant = PrefixId.fromNamespaceLabel "http://qudt.org/vocab/constant/" "constant"
    static member contax = PrefixId.fromNamespaceLabel "https://w3id.org/con-tax#" "contax"
    static member conversion = PrefixId.fromNamespaceLabel "http://purl.org/twc/vocab/conversion/" "conversion"
    static member coo = PrefixId.fromNamespaceLabel "http://purl.org/coo/ns#" "coo"
    static member core = PrefixId.fromNamespaceLabel "https://w3id.org/mdo/core/" "core"
    static member coreo = PrefixId.fromNamespaceLabel "http://purl.org/coreo#" "coreo"
    static member coun = PrefixId.fromNamespaceLabel "http://www.daml.org/2001/09/countries/iso-3166-ont#" "coun"
    static member country = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/countries#" "country"
    static member cpa = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/schemas/cpannotationschema.owl#" "cpa"
    static member cpmeta = PrefixId.fromNamespaceLabel "http://meta.icos-cp.eu/ontologies/cpmeta/" "cpmeta"
    static member crm = PrefixId.fromNamespaceLabel "http://www.cidoc-crm.org/cidoc-crm/" "crm"
    static member cro = PrefixId.fromNamespaceLabel "http://rhizomik.net/ontologies/copyrightonto.owl#" "cro"
    static member crsw = PrefixId.fromNamespaceLabel "http://courseware.rkbexplorer.com/ontologies/courseware#" "crsw"
    static member cs = PrefixId.fromNamespaceLabel "http://purl.org/vocab/changeset/schema#" "cs"
    static member csp = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/csp#" "csp"
    static member csvw = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/csvw#" "csvw"
    static member ct = PrefixId.fromNamespaceLabel "http://www.tele.pw.edu.pl/~sims-onto/ConnectivityType.owl#" "ct"
    static member ctag = PrefixId.fromNamespaceLabel "http://commontag.org/ns#" "ctag"
    static member ctlog = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/catalogue/" "ctlog"
    static member cto = PrefixId.fromNamespaceLabel "https://w3id.org/cto#" "cto"
    static member ctorg = PrefixId.fromNamespaceLabel "http://purl.org/ctic/infraestructuras/organizacion#" "ctorg"
    static member ctrl = PrefixId.fromNamespaceLabel "https://w3id.org/ibp/CTRLont#" "ctrl"
    static member ctxdesc = PrefixId.fromNamespaceLabel "http://www.demcare.eu/ontologies/contextdescriptor.owl#" "ctxdesc"
    static member cv = PrefixId.fromNamespaceLabel "http://data.europa.eu/m8g/" "cv"
    static member cwmo = PrefixId.fromNamespaceLabel "http://purl.org/cwmo/#" "cwmo"
    static member cwork = PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/creativework/" "cwork"
    static member cwrc = PrefixId.fromNamespaceLabel "http://sparql.cwrc.ca/ontologies/cwrc#" "cwrc"
    static member d2rq = PrefixId.fromNamespaceLabel "http://www.wiwiss.fu-berlin.de/suhl/bizer/D2RQ/0.1#" "d2rq"
    static member dady = PrefixId.fromNamespaceLabel "http://purl.org/NET/dady#" "dady"
    static member daia = PrefixId.fromNamespaceLabel "http://purl.org/ontology/daia/" "daia"
    static member daq = PrefixId.fromNamespaceLabel "http://purl.org/eis/vocab/daq#" "daq"
    static member dash = PrefixId.fromNamespaceLabel "http://datashapes.org/dash#" "dash"
    static member dataid = PrefixId.fromNamespaceLabel "http://dataid.dbpedia.org/ns/core#" "dataid"
    static member date = PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/misc/date#" "date"
    static member datex = PrefixId.fromNamespaceLabel "http://vocab.datex.org/terms#" "datex"
    static member dave = PrefixId.fromNamespaceLabel "http://theme-e.adaptcentre.ie/dave#" "dave"
    static member dba = PrefixId.fromNamespaceLabel "https://w3id.org/dba/ontology/" "dba"
    static member dbm = PrefixId.fromNamespaceLabel "http://purl.org/net/dbm/ontology#" "dbm"
    static member dbowl = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/dbowl/relational-to-ontology-mapping-primitive.owl#" "dbowl"
    static member dbpedia_owl = PrefixId.fromNamespaceLabel "http://dbpedia.org/ontology/" "dbpedia-owl"
    static member dbug = PrefixId.fromNamespaceLabel "http://ontologi.es/doap-bugs#" "dbug"
    static member dc = PrefixId.fromNamespaceLabel "http://dublincore.org/elements/1.1/" "dc"
    static member dc11 = PrefixId.fromNamespaceLabel "http://purl.org/dc/elements/1.1/" "dc11"
    static member dcam = PrefixId.fromNamespaceLabel "http://purl.org/dc/dcam/" "dcam"
    static member dcat = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dcat#" "dcat"
    static member dcite = PrefixId.fromNamespaceLabel "http://purl.org/spar/datacite/" "dcite"
    static member dcndl = PrefixId.fromNamespaceLabel "http://ndl.go.jp/dcndl/terms/" "dcndl"
    static member dco = PrefixId.fromNamespaceLabel "https://w3id.org/dco#" "dco"
    static member dcterms = PrefixId.fromNamespaceLabel "http://purl.org/dc/terms/" "dcterms"
    static member dctype = PrefixId.fromNamespaceLabel "http://purl.org/dc/dcmitype/" "dctype"
    static member ddesc = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/denotative-description/" "ddesc"
    static member decision = PrefixId.fromNamespaceLabel "https://decision-ontology.googlecode.com/svn/trunk/decision.owl#" "decision"
    static member demlab = PrefixId.fromNamespaceLabel "http://www.demcare.eu/ontologies/demlab.owl#" "demlab"
    static member deo = PrefixId.fromNamespaceLabel "http://purl.org/spar/deo/" "deo"
    static member deps = PrefixId.fromNamespaceLabel "http://ontologi.es/doap-deps#" "deps"
    static member dfc = PrefixId.fromNamespaceLabel "http://static.datafoodconsortium.org/ontologies/DFC_FullModel.owl#" "dfc"
    static member dfc_b = PrefixId.fromNamespaceLabel "http://static.datafoodconsortium.org/ontologies/DFC_BusinessOntology.owl#" "dfc-b"
    static member dfc_p = PrefixId.fromNamespaceLabel "http://static.datafoodconsortium.org/ontologies/DFC_ProductGlossary.owl#" "dfc-p"
    static member dfc_t = PrefixId.fromNamespaceLabel "http://static.datafoodconsortium.org/ontologies/DFC_TechnicalOntology.owl#" "dfc-t"
    static member dg = PrefixId.fromNamespaceLabel "https://w3id.org/dingo#" "dg"
    static member dicom = PrefixId.fromNamespaceLabel "http://purl.org/healthcarevocab/v1#" "dicom"
    static member dio = PrefixId.fromNamespaceLabel "https://w3id.org/dio#" "dio"
    static member disco = PrefixId.fromNamespaceLabel "http://rdf-vocabulary.ddialliance.org/discovery#" "disco"
    static member dita = PrefixId.fromNamespaceLabel "http://purl.org/dita/ns#" "dita"
    static member dk = PrefixId.fromNamespaceLabel "http://www.data-knowledge.org/dk/" "dk"
    static member dm2e = PrefixId.fromNamespaceLabel "http://onto.dm2e.eu/schemas/dm2e/" "dm2e"
    static member dnbt = PrefixId.fromNamespaceLabel "http://d-nb.info/standards/elementset/dnb#" "dnbt"
    static member doap = PrefixId.fromNamespaceLabel "http://usefulinc.com/ns/doap#" "doap"
    static member doc = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/document#" "doc"
    static member doco = PrefixId.fromNamespaceLabel "http://purl.org/spar/doco/" "doco"
    static member docpim = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/10/swap/pim/doc#" "docpim"
    static member docso = PrefixId.fromNamespaceLabel "http://purl.org/ontology/dso#" "docso"
    static member dogont = PrefixId.fromNamespaceLabel "http://elite.polito.it/ontologies/dogont" "dogont"
    static member donto = PrefixId.fromNamespaceLabel "http://reference.data.gov.au/def/ont/dataset#" "donto"
    static member dot = PrefixId.fromNamespaceLabel "https://w3id.org/dot#" "dot"
    static member dpn = PrefixId.fromNamespaceLabel "http://purl.org/dpn#" "dpn"
    static member dpo = PrefixId.fromNamespaceLabel "http://purl.org/twc/dpo/ont/" "dpo"
    static member dpp = PrefixId.fromNamespaceLabel "https://ns.verisav.fr/dpp#" "dpp"
    static member dprod = PrefixId.fromNamespaceLabel "https://ekgf.github.io/dprod/" "dprod"
    static member dprov = PrefixId.fromNamespaceLabel "http://promsns.org/def/do#" "dprov"
    static member dpv = PrefixId.fromNamespaceLabel "https://w3id.org/dpv#" "dpv"
    static member dq = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/dataquality#" "dq"
    static member dqc = PrefixId.fromNamespaceLabel "http://semwebquality.org/ontologies/dq-constraints#" "dqc"
    static member dqm = PrefixId.fromNamespaceLabel "http://purl.org/dqm-vocabulary/v1/dqm#" "dqm"
    static member dqv = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dqv#" "dqv"
    static member dr = PrefixId.fromNamespaceLabel "http://purl.org/swan/2.0/discourse-relationships/" "dr"
    static member drama = PrefixId.fromNamespaceLabel "http://www.purl.org/drammar#" "drama"
    static member drm = PrefixId.fromNamespaceLabel "http://vocab.data.gov/def/drm#" "drm"
    static member drs = PrefixId.fromNamespaceLabel "http://cs-www.cs.yale.edu/homes/dvm/daml/drsonto040520.owl#" "drs"
    static member ds = PrefixId.fromNamespaceLabel "http://purl.org/ctic/dcat#" "ds"
    static member dsd = PrefixId.fromNamespaceLabel "https://w3id.org/dsd#" "dsd"
    static member dsn = PrefixId.fromNamespaceLabel "http://purl.org/dsnotify/vocab/eventset/" "dsn"
    static member dso = PrefixId.fromNamespaceLabel "http://inference-web.org/2.0/ds.owl#" "dso"
    static member dstv = PrefixId.fromNamespaceLabel "http://w3id.org/dstv#" "dstv"
    static member dsv = PrefixId.fromNamespaceLabel "https://w3id.org/dsv#" "dsv"
    static member dt = PrefixId.fromNamespaceLabel "https://w3id.org/dt#" "dt"
    static member dtw = PrefixId.fromNamespaceLabel "https://w3id.org/def/dtw#" "dtw"
    static member dtx_srti = PrefixId.fromNamespaceLabel "http://cef.uv.es/lodroadtran18/def/transporte/dtx_srti#" "dtx_srti"
    static member dtype = PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/dtype#" "dtype"
    static member dul = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/dul/DUL.owl#" "dul"
    static member duv = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/duv#" "duv"
    static member dvia = PrefixId.fromNamespaceLabel "http://purl.org/ontology/dvia#" "dvia"
    static member e = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/log-rules#" "e"
    static member eac_cpf = PrefixId.fromNamespaceLabel "http://archivi.ibc.regione.emilia-romagna.it/ontology/eac-cpf/" "eac-cpf"
    static member earl = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/earl#" "earl"
    static member earth = PrefixId.fromNamespaceLabel "http://linked.earth/ontology#" "earth"
    static member ebg = PrefixId.fromNamespaceLabel "http://data.businessgraph.io/ontology#" "ebg"
    static member ebucore = PrefixId.fromNamespaceLabel "http://www.ebu.ch/metadata/ontologies/ebucore/ebucore#" "ebucore"
    static member eccrev = PrefixId.fromNamespaceLabel "https://vocab.eccenca.com/revision/" "eccrev"
    static member ecfo = PrefixId.fromNamespaceLabel "https://w3id.org/ecfo#" "ecfo"
    static member eclap = PrefixId.fromNamespaceLabel "http://www.eclap.eu/schema/eclap/" "eclap"
    static member ecpo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/ecpo#" "ecpo"
    static member ecrm = PrefixId.fromNamespaceLabel "http://erlangen-crm.org/current/" "ecrm"
    static member edUse = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/educationalUse/" "edUse"
    static member edac = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-edac.owl#" "edac"
    static member edifact_o = PrefixId.fromNamespaceLabel "https://purl.org/edifact/ontology#" "edifact-o"
    static member edm = PrefixId.fromNamespaceLabel "http://www.europeana.eu/schemas/edm/" "edm"
    static member edu = PrefixId.fromNamespaceLabel "https://schema.edu.ee/" "edu"
    static member edupro = PrefixId.fromNamespaceLabel "http://ns.inria.fr/semed/eduprogression#" "edupro"
    static member eem = PrefixId.fromNamespaceLabel "http://purl.org/eem#" "eem"
    static member eeo = PrefixId.fromNamespaceLabel "https://w3id.org/eeo#" "eeo"
    static member ei2a = PrefixId.fromNamespaceLabel "http://opendata.aragon.es/def/ei2a#" "ei2a"
    static member ekc = PrefixId.fromNamespaceLabel "http://dh.aks.ac.kr/ontologies/ekc#" "ekc"
    static member elec = PrefixId.fromNamespaceLabel "http://purl.org/ctic/sector-publico/elecciones#" "elec"
    static member eli = PrefixId.fromNamespaceLabel "http://data.europa.eu/eli/ontology#" "eli"
    static member emmo = PrefixId.fromNamespaceLabel "https://w3id.org/emmo#" "emmo"
    static member emotion = PrefixId.fromNamespaceLabel "http://ns.inria.fr/emoca#" "emotion"
    static member emp = PrefixId.fromNamespaceLabel "http://purl.org/ctic/empleo/oferta#" "emp"
    static member ends = PrefixId.fromNamespaceLabel "http://labs.mondeca.com/vocab/endpointStatus#" "ends"
    static member env = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/environment#" "env"
    static member ep = PrefixId.fromNamespaceLabel "http://eprints.org/ontology/" "ep"
    static member eppl = PrefixId.fromNamespaceLabel "https://w3id.org/ep-plan#" "eppl"
    static member eqp = PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/equipment#" "eqp"
    static member era = PrefixId.fromNamespaceLabel "http://data.europa.eu/949/" "era"
    static member esco = PrefixId.fromNamespaceLabel "http://data.europa.eu/esco/model#" "esco"
    static member essglobal = PrefixId.fromNamespaceLabel "http://purl.org/essglobal/vocab/" "essglobal"
    static member eupont = PrefixId.fromNamespaceLabel "http://elite.polito.it/ontologies/eupont.owl#" "eupont"
    static member eurio = PrefixId.fromNamespaceLabel "http://data.europa.eu/s66#" "eurio"
    static member euvoc = PrefixId.fromNamespaceLabel "http://publications.europa.eu/ontology/euvoc#" "euvoc"
    static member event_ = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/event#" "event"
    static member ex = PrefixId.fromNamespaceLabel "http://purl.org/net/ns/ex#" "ex"
    static member exif = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/12/exif/ns#" "exif"
    static member experts = PrefixId.fromNamespaceLabel "http://w3id.org/emmo-maeo/maeo#" "experts"
    static member ext = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/extent#" "ext"
    static member fabio = PrefixId.fromNamespaceLabel "http://purl.org/spar/fabio/" "fabio"
    static member faldo = PrefixId.fromNamespaceLabel "http://biohackathon.org/resource/faldo#" "faldo"
    static member fea = PrefixId.fromNamespaceLabel "http://vocab.data.gov/def/fea#" "fea"
    static member fel = PrefixId.fromNamespaceLabel "http://w3id.org/vcb/fel#" "fel"
    static member fibo_actus_act = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTerms/" "fibo-actus-act"
    static member fibo_actus_actm = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSContractTermMapping/" "fibo-actus-actm"
    static member fibo_actus_acv = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/ACTUS/ACTUSTaxonomy/" "fibo-actus-acv"
    static member fibo_actus_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/ACTUS/MetadataACTUS/" "fibo-actus-mod"
    static member fibo_be_corp_corp = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Corporations/Corporations/" "fibo-be-corp-corp"
    static member fibo_be_fct_fct = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/FunctionalEntities/" "fibo-be-fct-fct"
    static member fibo_be_fct_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/MetadataBEFunctionalEntities/" "fibo-be-fct-mod"
    static member fibo_be_fct_pub = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/FunctionalEntities/Publishers/" "fibo-be-fct-pub"
    static member fibo_be_ge_caj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-caj"
    static member fibo_be_ge_casj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/CentralAsiaGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-casj"
    static member fibo_be_ge_cbj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CaribbeanGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-cbj"
    static member fibo_be_ge_ctlaj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-ctlaj"
    static member fibo_be_ge_easj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-easj"
    static member fibo_be_ge_eeuj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-eeuj"
    static member fibo_be_ge_euj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EUGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-euj"
    static member fibo_be_ge_ge = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/GovernmentEntities/" "fibo-be-ge-ge"
    static member fibo_be_ge_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/MetadataBEGovernmentEntities/" "fibo-be-ge-mod"
    static member fibo_be_ge_mxj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/MXGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-mxj"
    static member fibo_be_ge_neuj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-neuj"
    static member fibo_be_ge_saj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/SouthAmericanGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-saj"
    static member fibo_be_ge_sasj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/SouthernAsiaGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-sasj"
    static member fibo_be_ge_seasj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/SoutheasternAsiaGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-seasj"
    static member fibo_be_ge_seuj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/SouthernEuropeGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-seuj"
    static member fibo_be_ge_ukj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-ukj"
    static member fibo_be_ge_usj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-usj"
    static member fibo_be_ge_wasj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/WesternAsiaGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-wasj"
    static member fibo_be_ge_weuj =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/"
            "fibo-be-ge-weuj"
    static member fibo_be_le_cb = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/CorporateBodies/" "fibo-be-le-cb"
    static member fibo_be_le_fbo = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/FormalBusinessOrganizations/" "fibo-be-le-fbo"
    static member fibo_be_le_lei = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LEIEntities/" "fibo-be-le-lei"
    static member fibo_be_le_lp = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/LegalPersons/" "fibo-be-le-lp"
    static member fibo_be_le_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/LegalEntities/MetadataBELegalEntities/" "fibo-be-le-mod"
    static member fibo_be_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/MetadataBE/" "fibo-be-mod"
    static member fibo_be_nfp_nfp =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/NotForProfitOrganizations/NotForProfitOrganizations/" "fibo-be-nfp-nfp"
    static member fibo_be_oac_cctl = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateControl/" "fibo-be-oac-cctl"
    static member fibo_be_oac_cown = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/CorporateOwnership/" "fibo-be-oac-cown"
    static member fibo_be_oac_cpty = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/ControlParties/" "fibo-be-oac-cpty"
    static member fibo_be_oac_exec = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/Executives/" "fibo-be-oac-exec"
    static member fibo_be_oac_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/MetadataBEOwnershipAndControl/" "fibo-be-oac-mod"
    static member fibo_be_oac_opty = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/OwnershipAndControl/OwnershipParties/" "fibo-be-oac-opty"
    static member fibo_be_plc_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/MetadataBEPrivateLimitedCompanies/" "fibo-be-plc-mod"
    static member fibo_be_plc_plc =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/PrivateLimitedCompanies/PrivateLimitedCompanies/" "fibo-be-plc-plc"
    static member fibo_be_ptr_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/MetadataBEPartnerships/" "fibo-be-ptr-mod"
    static member fibo_be_ptr_ptr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Partnerships/Partnerships/" "fibo-be-ptr-ptr"
    static member fibo_be_sps_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/MetadataBESoleProprietorships/" "fibo-be-sps-mod"
    static member fibo_be_sps_sps = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/SoleProprietorships/SoleProprietorships/" "fibo-be-sps-sps"
    static member fibo_be_tr_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/MetadataBETrusts/" "fibo-be-tr-mod"
    static member fibo_be_tr_tr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/Trusts/Trusts/" "fibo-be-tr-tr"
    static member fibo_bp_iss_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BP/SecuritiesIssuance/MetadataBPSecuritiesIssuance/" "fibo-bp-iss-mod"
    static member fibo_bp_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BP/MetadataBP/" "fibo-bp-mod"
    static member fibo_bp_prc_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BP/Process/MetadataBPProcess/" "fibo-bp-prc-mod"
    static member fibo_cae_ce_act = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/CorporateActions/" "fibo-cae-ce-act"
    static member fibo_cae_ce_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/CAE/CorporateEvents/MetadataCAECorporateEvents/" "fibo-cae-ce-mod"
    static member fibo_cae_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/CAE/MetadataCAE/" "fibo-cae-mod"
    static member fibo_der_cr_cds = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/CreditDefaultSwaps/" "fibo-der-cr-cds"
    static member fibo_der_cr_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/CreditDerivatives/MetadataDERCreditDerivatives/" "fibo-der-cr-mod"
    static member fibo_der_drc_bsc = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesBasics/" "fibo-der-drc-bsc"
    static member fibo_der_drc_comm =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CommoditiesContracts/" "fibo-der-drc-comm"
    static member fibo_der_drc_cur = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/CurrencyContracts/" "fibo-der-drc-cur"
    static member fibo_der_drc_exo = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/ExoticOptions/" "fibo-der-drc-exo"
    static member fibo_der_drc_ff = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/FuturesAndForwards/" "fibo-der-drc-ff"
    static member fibo_der_drc_ma =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/DerivativesMasterAgreements/" "fibo-der-drc-ma"
    static member fibo_der_drc_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/MetadataDERDerivativesContracts/" "fibo-der-drc-mod"
    static member fibo_der_drc_opt = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Options/" "fibo-der-drc-opt"
    static member fibo_der_drc_raw = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/RightsAndWarrants/" "fibo-der-drc-raw"
    static member fibo_der_drc_str =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/StructuredInstruments/" "fibo-der-drc-str"
    static member fibo_der_drc_swp = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/Swaps/" "fibo-der-drc-swp"
    static member fibo_der_drc_swpind =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/DerivativesContracts/SwapsIndividuals/" "fibo-der-drc-swpind"
    static member fibo_der_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/MetadataDER/" "fibo-der-mod"
    static member fibo_der_rat_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/MetadataDERRateDerivatives/" "fibo-der-rat-mod"
    static member fibo_der_rtd_irswp = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/IRSwaps/" "fibo-der-rtd-irswp"
    static member fibo_der_rtd_rtd = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/RateDerivatives/RateDerivatives/" "fibo-der-rtd-rtd"
    static member fibo_der_sbd_eqs = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/EquitySwaps/" "fibo-der-sbd-eqs"
    static member fibo_der_sbd_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/MetadataDERSecurityBasedDerivatives/" "fibo-der-sbd-mod"
    static member fibo_der_sbd_sbd =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/DER/SecurityBasedDerivatives/SecurityBasedDerivatives/" "fibo-der-sbd-sbd"
    static member fibo_exmp_le_djiac =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageCompanies/" "fibo-exmp-le-djiac"
    static member fibo_exmp_le_djiaex =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/DowJonesIndustrialAverageExecutives/" "fibo-exmp-le-djiaex"
    static member fibo_exmp_le_finst =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/FinancialInstitutionExamples/" "fibo-exmp-le-finst"
    static member fibo_exmp_le_mktex =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MarketsAndExchangesExamples/" "fibo-exmp-le-mktex"
    static member fibo_exmp_le_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/LegalEntities/MetadataEXMPLegalEntities/" "fibo-exmp-le-mod"
    static member fibo_exmp_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/MetadataEXMP/" "fibo-exmp-mod"
    static member fibo_exmp_sec_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/EXMP/Securities/MetadataEXMPSecurities/" "fibo-exmp-sec-mod"
    static member fibo_fbc_dae_cre = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/CreditEvents/" "fibo-fbc-dae-cre"
    static member fibo_fbc_dae_dbt = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Debt/" "fibo-fbc-dae-dbt"
    static member fibo_fbc_dae_gty = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/Guaranty/" "fibo-fbc-dae-gty"
    static member fibo_fbc_dae_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/DebtAndEquities/MetadataFBCDebtAndEquities/" "fibo-fbc-dae-mod"
    static member fibo_fbc_fct_bc = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCenters/" "fibo-fbc-fct-bc"
    static member fibo_fbc_fct_bci =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessCentersIndividuals/" "fibo-fbc-fct-bci"
    static member fibo_fbc_fct_breg = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/BusinessRegistries/" "fibo-fbc-fct-breg"
    static member fibo_fbc_fct_cafse =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CAFinancialServicesEntities/"
            "fibo-fbc-fct-cafse"
    static member fibo_fbc_fct_cajrga =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/CARegulatoryAgencies/" "fibo-fbc-fct-cajrga"
    static member fibo_fbc_fct_cra =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/CommercialRegistrationAuthorities/" "fibo-fbc-fct-cra"
    static member fibo_fbc_fct_eufse =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EUFinancialServicesEntities/" "fibo-fbc-fct-eufse"
    static member fibo_fbc_fct_eufseind =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EuropeanFinancialServicesEntitiesIndividuals/"
            "fibo-fbc-fct-eufseind"
    static member fibo_fbc_fct_eurga =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/EuropeanEntities/EURegulatoryAgencies/" "fibo-fbc-fct-eurga"
    static member fibo_fbc_fct_fse =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/FinancialServicesEntities/" "fibo-fbc-fct-fse"
    static member fibo_fbc_fct_ireg =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/InternationalRegistriesAndAuthorities/" "fibo-fbc-fct-ireg"
    static member fibo_fbc_fct_mkt = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/Markets/" "fibo-fbc-fct-mkt"
    static member fibo_fbc_fct_mkti = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MarketsIndividuals/" "fibo-fbc-fct-mkti"
    static member fibo_fbc_fct_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/MetadataFBCFunctionalEntities/" "fibo-fbc-fct-mod"
    static member fibo_fbc_fct_rga = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/RegulatoryAgencies/" "fibo-fbc-fct-rga"
    static member fibo_fbc_fct_usfse =
        PrefixId.fromNamespaceLabel
            "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USFinancialServicesEntities/"
            "fibo-fbc-fct-usfse"
    static member fibo_fbc_fct_usjrga =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FunctionalEntities/NorthAmericanEntities/USRegulatoryAgencies/" "fibo-fbc-fct-usjrga"
    static member fibo_fbc_fi_fi = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/FinancialInstruments/" "fibo-fbc-fi-fi"
    static member fibo_fbc_fi_ip = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/InstrumentPricing/" "fibo-fbc-fi-ip"
    static member fibo_fbc_fi_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/MetadataFBCFinancialInstruments/" "fibo-fbc-fi-mod"
    static member fibo_fbc_fi_stl = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/FinancialInstruments/Settlement/" "fibo-fbc-fi-stl"
    static member fibo_fbc_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/MetadataFBC/" "fibo-fbc-mod"
    static member fibo_fbc_pas_caa = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/ClientsAndAccounts/" "fibo-fbc-pas-caa"
    static member fibo_fbc_pas_fpas =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/FinancialProductsAndServices/" "fibo-fbc-pas-fpas"
    static member fibo_fbc_pas_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FBC/ProductsAndServices/MetadataFBCProductsAndServices/" "fibo-fbc-pas-mod"
    static member fibo_fnd_aap_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/MetadataFNDAgentsAndPeople/" "fibo-fnd-aap-mod"
    static member fibo_fnd_aap_ppl = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/AgentsAndPeople/People/" "fibo-fnd-aap-ppl"
    static member fibo_fnd_acc_4217 = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/ISO4217-CurrencyCodes/" "fibo-fnd-acc-4217"
    static member fibo_fnd_acc_csf = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CashFlows/" "fibo-fnd-acc-csf"
    static member fibo_fnd_acc_cur = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/CurrencyAmount/" "fibo-fnd-acc-cur"
    static member fibo_fnd_acc_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Accounting/MetadataFNDAccounting/" "fibo-fnd-acc-mod"
    static member fibo_fnd_agr_agr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Agreements/" "fibo-fnd-agr-agr"
    static member fibo_fnd_agr_ctr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/Contracts/" "fibo-fnd-agr-ctr"
    static member fibo_fnd_agr_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Agreements/MetadataFNDAgreements/" "fibo-fnd-agr-mod"
    static member fibo_fnd_arr_arr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Arrangements/" "fibo-fnd-arr-arr"
    static member fibo_fnd_arr_asmt = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Assessments/" "fibo-fnd-arr-asmt"
    static member fibo_fnd_arr_cls = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/ClassificationSchemes/" "fibo-fnd-arr-cls"
    static member fibo_fnd_arr_doc = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Documents/" "fibo-fnd-arr-doc"
    static member fibo_fnd_arr_id = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/IdentifiersAndIndices/" "fibo-fnd-arr-id"
    static member fibo_fnd_arr_lif = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Lifecycles/" "fibo-fnd-arr-lif"
    static member fibo_fnd_arr_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/MetadataFNDArrangements/" "fibo-fnd-arr-mod"
    static member fibo_fnd_arr_rep = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Reporting/" "fibo-fnd-arr-rep"
    static member fibo_fnd_arr_rt = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Arrangements/Ratings/" "fibo-fnd-arr-rt"
    static member fibo_fnd_dt_bd = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/BusinessDates/" "fibo-fnd-dt-bd"
    static member fibo_fnd_dt_fd = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/FinancialDates/" "fibo-fnd-dt-fd"
    static member fibo_fnd_dt_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/MetadataFNDDatesAndTimes/" "fibo-fnd-dt-mod"
    static member fibo_fnd_dt_oc = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/DatesAndTimes/Occurrences/" "fibo-fnd-dt-oc"
    static member fibo_fnd_gao_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/MetadataFNDGoalsAndObjectives/" "fibo-fnd-gao-mod"
    static member fibo_fnd_gao_obj = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/GoalsAndObjectives/Objectives/" "fibo-fnd-gao-obj"
    static member fibo_fnd_law_cor = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCore/" "fibo-fnd-law-cor"
    static member fibo_fnd_law_lcap = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Law/LegalCapacity/" "fibo-fnd-law-lcap"
    static member fibo_fnd_law_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Law/MetadataFNDLaw/" "fibo-fnd-law-mod"
    static member fibo_fnd_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/MetadataFND/" "fibo-fnd-mod"
    static member fibo_fnd_oac_ctl = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Control/" "fibo-fnd-oac-ctl"
    static member fibo_fnd_oac_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/MetadataFNDOwnershipAndControl/" "fibo-fnd-oac-mod"
    static member fibo_fnd_oac_oac = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/OwnershipAndControl/" "fibo-fnd-oac-oac"
    static member fibo_fnd_oac_own = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/OwnershipAndControl/Ownership/" "fibo-fnd-oac-own"
    static member fibo_fnd_org_fm = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/FormalOrganizations/" "fibo-fnd-org-fm"
    static member fibo_fnd_org_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/" "fibo-fnd-org-mod"
    static member fibo_fnd_org_org = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/Organizations/" "fibo-fnd-org-org"
    static member fibo_fnd_pas_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/MetadataFNDProductsAndServices/" "fibo-fnd-pas-mod"
    static member fibo_fnd_pas_pas = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/ProductsAndServices/" "fibo-fnd-pas-pas"
    static member fibo_fnd_pas_psch =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/ProductsAndServices/PaymentsAndSchedules/" "fibo-fnd-pas-psch"
    static member fibo_fnd_plc_adr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/Addresses/" "fibo-fnd-plc-adr"
    static member fibo_fnd_plc_loc = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/Locations/" "fibo-fnd-plc-loc"
    static member fibo_fnd_plc_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/MetadataFNDPlaces/" "fibo-fnd-plc-mod"
    static member fibo_fnd_plc_rp = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/RealProperty/" "fibo-fnd-plc-rp"
    static member fibo_fnd_plc_uspsa =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddresses/" "fibo-fnd-plc-uspsa"
    static member fibo_fnd_plc_uspsai =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/NorthAmerica/USPostalServiceAddressesIndividuals/" "fibo-fnd-plc-uspsai"
    static member fibo_fnd_plc_vrt = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Places/VirtualPlaces/" "fibo-fnd-plc-vrt"
    static member fibo_fnd_pty_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/MetadataFNDParties/" "fibo-fnd-pty-mod"
    static member fibo_fnd_pty_pty = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Parties/Parties/" "fibo-fnd-pty-pty"
    static member fibo_fnd_rel_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/MetadataFNDRelations/" "fibo-fnd-rel-mod"
    static member fibo_fnd_rel_rel = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Relations/Relations/" "fibo-fnd-rel-rel"
    static member fibo_fnd_txn_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/TransactionsExt/MetadataFNDTransactionsExt/" "fibo-fnd-txn-mod"
    static member fibo_fnd_utl_alx = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/Analytics/" "fibo-fnd-utl-alx"
    static member fibo_fnd_utl_av = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/AnnotationVocabulary/" "fibo-fnd-utl-av"
    static member fibo_fnd_utl_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Utilities/MetadataFNDUtilities/" "fibo-fnd-utl-mod"
    static member fibo_ind_ei_caei =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/CAEconomicIndicators/" "fibo-ind-ei-caei"
    static member fibo_ind_ei_ei = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/EconomicIndicators/" "fibo-ind-ei-ei"
    static member fibo_ind_ei_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/MetadataINDEconomicIndicators/" "fibo-ind-ei-mod"
    static member fibo_ind_ei_usei =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/EconomicIndicators/NorthAmericanIndicators/USEconomicIndicators/" "fibo-ind-ei-usei"
    static member fibo_ind_fx_fx = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/ForeignExchange/" "fibo-ind-fx-fx"
    static member fibo_ind_fx_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/ForeignExchange/MetadataINDForeignExchange/" "fibo-ind-fx-mod"
    static member fibo_ind_ind_ind = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/Indicators/" "fibo-ind-ind-ind"
    static member fibo_ind_ind_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/Indicators/MetadataINDIndicators/" "fibo-ind-ind-mod"
    static member fibo_ind_ir_cm = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/CommonInterestRates/" "fibo-ind-ir-cm"
    static member fibo_ind_ir_ir = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/InterestRates/" "fibo-ind-ir-ir"
    static member fibo_ind_ir_mdp = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MarketDataProviders/" "fibo-ind-ir-mdp"
    static member fibo_ind_ir_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/InterestRates/MetadataINDInterestRates/" "fibo-ind-ir-mod"
    static member fibo_ind_mkt_bas = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/BasketIndices/" "fibo-ind-mkt-bas"
    static member fibo_ind_mkt_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/MarketIndices/MetadataINDMarketIndices/" "fibo-ind-mkt-mod"
    static member fibo_ind_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/IND/MetadataIND/" "fibo-ind-mod"
    static member fibo_loan_ln_ln = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/Loans/" "fibo-loan-ln-ln"
    static member fibo_loan_ln_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansGeneral/MetadataLOANLoansGeneral/" "fibo-loan-ln-mod"
    static member fibo_loan_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/MetadataLOAN/" "fibo-loan-mod"
    static member fibo_loan_reln_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/MetadataLOANRealEstateLoans/" "fibo-loan-reln-mod"
    static member fibo_loan_reln_mtg = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/RealEstateLoans/Mortgages/" "fibo-loan-reln-mtg"
    static member fibo_loan_spc_cns = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/ConsumerLoans/" "fibo-loan-spc-cns"
    static member fibo_loan_spc_com = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CommercialLoans/" "fibo-loan-spc-com"
    static member fibo_loan_spc_crd = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/CardAccounts/" "fibo-loan-spc-crd"
    static member fibo_loan_spc_grn = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/GreenLoans/" "fibo-loan-spc-grn"
    static member fibo_loan_spc_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/MetadataLOANLoansSpecific/" "fibo-loan-spc-mod"
    static member fibo_loan_spc_stu = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/LOAN/LoansSpecific/StudentLoans/" "fibo-loan-spc-stu"
    static member fibo_md_civx_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/MD/CIVTemporal/MetadataMDCIVTemporal/" "fibo-md-civx-mod"
    static member fibo_md_dbtx_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/MD/DebtTemporal/MetadataMDDebtTemporal/" "fibo-md-dbtx-mod"
    static member fibo_md_derx_mod =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/MD/DerivativesTemporal/MetadataMDDerivativesTemporal/" "fibo-md-derx-mod"
    static member fibo_md_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/MD/MetadataMD/" "fibo-md-mod"
    static member fibo_md_temx_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/MD/TemporalCore/MetadataMDTemporalCore/" "fibo-md-temx-mod"
    static member fibo_pay_ps_ps = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/PAY/PaymentServices/PaymentServices/" "fibo-pay-ps-ps"
    static member fibo_prod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/AboutFIBOProd/" "fibo-prod"
    static member fibo_sec_dbt_abs = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/AssetBackedSecurities/" "fibo-sec-dbt-abs"
    static member fibo_sec_dbt_bnd = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/Bonds/" "fibo-sec-dbt-bnd"
    static member fibo_sec_dbt_dbti = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DebtInstruments/" "fibo-sec-dbt-dbti"
    static member fibo_sec_dbt_dln = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/DistributedLoans/" "fibo-sec-dbt-dln"
    static member fibo_sec_dbt_ex = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/ExerciseConventions/" "fibo-sec-dbt-ex"
    static member fibo_sec_dbt_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/MetadataSECDebt/" "fibo-sec-dbt-mod"
    static member fibo_sec_dbt_pbs = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/PoolBackedSecurities/" "fibo-sec-dbt-pbs"
    static member fibo_sec_dbt_tstd = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Debt/TradedShortTermDebt/" "fibo-sec-dbt-tstd"
    static member fibo_sec_eq_10962 =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityCFIClassificationIndividuals/" "fibo-sec-eq-10962"
    static member fibo_sec_eq_dr = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/DepositaryReceipts/" "fibo-sec-eq-dr"
    static member fibo_sec_eq_eq = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/EquityInstruments/" "fibo-sec-eq-eq"
    static member fibo_sec_eq_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Equities/MetadataSECEquities/" "fibo-sec-eq-mod"
    static member fibo_sec_fnd_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/MetadataSECFunds/" "fibo-sec-fnd-mod"
    static member fibo_sec_fund_fund = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Funds/Funds/" "fibo-sec-fund-fund"
    static member fibo_sec_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/MetadataSEC/" "fibo-sec-mod"
    static member fibo_sec_sec_bsk = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Baskets/" "fibo-sec-sec-bsk"
    static member fibo_sec_sec_cls = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesClassification/" "fibo-sec-sec-cls"
    static member fibo_sec_sec_eurst =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/EuropeanSecurities/EUSecuritiesRestrictions/" "fibo-sec-sec-eurst"
    static member fibo_sec_sec_id = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentification/" "fibo-sec-sec-id"
    static member fibo_sec_sec_idind =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIdentificationIndividuals/" "fibo-sec-sec-idind"
    static member fibo_sec_sec_iss = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesIssuance/" "fibo-sec-sec-iss"
    static member fibo_sec_sec_lst = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesListings/" "fibo-sec-sec-lst"
    static member fibo_sec_sec_mod = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/MetadataSECSecurities/" "fibo-sec-sec-mod"
    static member fibo_sec_sec_pls = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/Pools/" "fibo-sec-sec-pls"
    static member fibo_sec_sec_rst = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/SecuritiesRestrictions/" "fibo-sec-sec-rst"
    static member fibo_sec_sec_sch = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/ParametricSchedules/" "fibo-sec-sec-sch"
    static member fibo_sec_sec_usrst =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/SEC/Securities/NorthAmericanSecurities/USSecuritiesRestrictions/" "fibo-sec-sec-usrst"
    static member fibo_spec = PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/MetadataFIBO/" "fibo-spec"
    static member fiesta_iot = PrefixId.fromNamespaceLabel "http://purl.org/iot/ontology/fiesta-iot#" "fiesta-iot"
    static member foaf = PrefixId.fromNamespaceLabel "http://xmlns.com/foaf/0.1/" "foaf"
    static member fog = PrefixId.fromNamespaceLabel "https://w3id.org/fog#" "fog"
    static member foio = PrefixId.fromNamespaceLabel "https://w3id.org/seas/FeatureOfInterestOntology/" "foio"
    static member foo = PrefixId.fromNamespaceLabel "https://w3id.org/def/foo#" "foo"
    static member food = PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/food#" "food"
    static member fos = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/foster#" "fos"
    static member fowl = PrefixId.fromNamespaceLabel "http://www.w3.org/TR/2003/PR-owl-guide-20031209/food#" "fowl"
    static member frad = PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/fr/frad/" "frad"
    static member frapo = PrefixId.fromNamespaceLabel "http://purl.org/cerif/frapo/" "frapo"
    static member frappe = PrefixId.fromNamespaceLabel "http://streamreasoning.org/ontologies/frappe#" "frappe"
    static member frbr = PrefixId.fromNamespaceLabel "http://purl.org/vocab/frbr/core#" "frbr"
    static member frbre = PrefixId.fromNamespaceLabel "http://purl.org/vocab/frbr/extended#" "frbre"
    static member frbrer = PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/fr/frbr/frbrer/" "frbrer"
    static member fresnel = PrefixId.fromNamespaceLabel "http://www.w3.org/2004/09/fresnel#" "fresnel"
    static member fwo = PrefixId.fromNamespaceLabel "https://w3id.org/foodwaste/ontology#" "fwo"
    static member g50k = PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/50kGazetteer/" "g50k"
    static member game = PrefixId.fromNamespaceLabel "http://data.totl.net/game/" "game"
    static member gc = PrefixId.fromNamespaceLabel "http://www.oegov.org/core/owl/gc#" "gc"
    static member gci = PrefixId.fromNamespaceLabel "http://ontology.eil.utoronto.ca/GCI/Foundation/GCI-Foundation.owl#" "gci"
    static member gcon = PrefixId.fromNamespaceLabel "https://w3id.org/GConsent#" "gcon"
    static member gd = PrefixId.fromNamespaceLabel "http://reference.data.gov/def/govdata/" "gd"
    static member gdprov = PrefixId.fromNamespaceLabel "https://w3id.org/GDPRov#" "gdprov"
    static member gdprt = PrefixId.fromNamespaceLabel "https://w3id.org/GDPRtEXT#" "gdprt"
    static member gen = PrefixId.fromNamespaceLabel "http://purl.org/gen/0.1#" "gen"
    static member genomab = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/genomeAbnormality#" "genomab"
    static member genreForms = PrefixId.fromNamespaceLabel "http://id.loc.gov/authorities/genreForms/" "genreForms"
    static member geo = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/01/geo/wgs84_pos#" "geo"
    static member geod = PrefixId.fromNamespaceLabel "http://vocab.lenka.no/geo-deling#" "geod"
    static member geof = PrefixId.fromNamespaceLabel "http://www.mindswap.org/2003/owl/geo/geoFeatures20040307.owl#" "geof"
    static member geofla = PrefixId.fromNamespaceLabel "http://data.ign.fr/def/geofla#" "geofla"
    static member geom = PrefixId.fromNamespaceLabel "http://data.ign.fr/def/geometrie#" "geom"
    static member geop = PrefixId.fromNamespaceLabel "http://aims.fao.org/aos/geopolitical.owl#" "geop"
    static member geosp = PrefixId.fromNamespaceLabel "http://rdf.geospecies.org/ont/geospecies#" "geosp"
    static member geosparql = PrefixId.fromNamespaceLabel "http://www.opengis.net/ont/geosparql#" "geosparql"
    static member gf = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19109/2005/feature#" "gf"
    static member glc = PrefixId.fromNamespaceLabel "https://glaciation-project.eu/MetadataReferenceModel#" "glc"
    static member gleif_L1 = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/L1/" "gleif-L1"
    static member gleif_L1_data = PrefixId.fromNamespaceLabel "https://rdf.gleif.org/L1/" "gleif-L1-data"
    static member gleif_L2 = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/L2/" "gleif-L2"
    static member gleif_L2parent = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/L2Parent/" "gleif-L2parent"
    static member gleif_base = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/Base/" "gleif-base"
    static member gleif_elf = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/EntityLegalForm/" "gleif-elf"
    static member gleif_geo = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/Geocoding/" "gleif-geo"
    static member gleif_ra = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/RegistrationAuthority/" "gleif-ra"
    static member gleif_repex = PrefixId.fromNamespaceLabel "https://www.gleif.org/ontology/ReportingException/" "gleif-repex"
    static member gm = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19107/2003/geometry#" "gm"
    static member gml = PrefixId.fromNamespaceLabel "http://www.opengis.net/ont/gml#" "gml"
    static member gn = PrefixId.fromNamespaceLabel "http://www.geonames.org/ontology#" "gn"
    static member gndo = PrefixId.fromNamespaceLabel "http://d-nb.info/standards/elementset/gnd#" "gndo"
    static member gold = PrefixId.fromNamespaceLabel "http://purl.org/linguistics/gold/" "gold"
    static member gom = PrefixId.fromNamespaceLabel "https://w3id.org/gom#" "gom"
    static member gov = PrefixId.fromNamespaceLabel "http://gov.genealogy.net/ontology.owl#" "gov"
    static member gr = PrefixId.fromNamespaceLabel "http://purl.org/goodrelations/v1#" "gr"
    static member graphql = PrefixId.fromNamespaceLabel "http://datashapes.org/graphql#" "graphql"
    static member grddl = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/g/data-view#" "grddl"
    static member gs1 = PrefixId.fromNamespaceLabel "https://ref.gs1.org/voc/" "gs1"
    static member gsn = PrefixId.fromNamespaceLabel "https://w3id.org/OntoGSN/ontology#" "gsn"
    static member gso = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/gen/ont#" "gso"
    static member gtfs = PrefixId.fromNamespaceLabel "http://vocab.gtfs.org/terms#" "gtfs"
    static member gtm = PrefixId.fromNamespaceLabel "https://www.goudatijdmachine.nl/def#" "gtm"
    static member gts = PrefixId.fromNamespaceLabel "http://resource.geosciml.org/ontology/timescale/gts#" "gts"
    static member gufo = PrefixId.fromNamespaceLabel "http://purl.org/nemo/gufo#" "gufo"
    static member gvp = PrefixId.fromNamespaceLabel "http://vocab.getty.edu/ontology#" "gvp"
    static member h2o = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19150/-2/2012/basic#" "h2o"
    static member ha = PrefixId.fromNamespaceLabel "http://sensormeasurement.appspot.com/ont/home/homeActivity#" "ha"
    static member hctl = PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/hypermedia#" "hctl"
    static member hdo = PrefixId.fromNamespaceLabel "http://www.samos.gr/ontologies/helpdeskOnto.owl#" "hdo"
    static member hht = PrefixId.fromNamespaceLabel "https://w3id.org/HHT#" "hht"
    static member hifm = PrefixId.fromNamespaceLabel "http://purl.org/net/hifm/ontology#" "hifm"
    static member holding = PrefixId.fromNamespaceLabel "http://purl.org/ontology/holding#" "holding"
    static member holy = PrefixId.fromNamespaceLabel "http://purl.org/holy/ns#" "holy"
    static member hosp = PrefixId.fromNamespaceLabel "http://health.data.gov/def/hospital/" "hosp"
    static member hpo = PrefixId.fromNamespaceLabel "http://w3id.org/emmo-hpo/hpo#" "hpo"
    static member hpont = PrefixId.fromNamespaceLabel "https://w3id.org/hpont#" "hpont"
    static member hr = PrefixId.fromNamespaceLabel "http://iserve.kmi.open.ac.uk/ns/hrests#" "hr"
    static member hto = PrefixId.fromNamespaceLabel "http://vcharpenay.github.io/hto/hto.xml#" "hto"
    static member http = PrefixId.fromNamespaceLabel "http://www.w3.org/2011/http#" "http"
    static member human = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/human#" "human"
    static member humanbody = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/humanBody#" "humanbody"
    static member hurifa = PrefixId.fromNamespaceLabel "http://www.agfa.com/w3c/2009/humanRiskFactors#" "hurifa"
    static member hw = PrefixId.fromNamespaceLabel "https://www.auto.tuwien.ac.at/downloads/thinkhome/ontology/WeatherOntology.owl" "hw"
    static member hydra = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/hydra/core#" "hydra"
    static member iadopt = PrefixId.fromNamespaceLabel "https://w3id.org/iadopt/ont/" "iadopt"
    static member ibis = PrefixId.fromNamespaceLabel "https://privatealpha.com/ontology/ibis/1#" "ibis"
    static member ic = PrefixId.fromNamespaceLabel "http://ontology.eil.utoronto.ca/icontact.owl#" "ic"
    static member icb = PrefixId.fromNamespaceLabel "https://w3id.org/isCharacterisedBy#" "icb"
    static member icon = PrefixId.fromNamespaceLabel "https://w3id.org/icon/ontology/" "icon"
    static member iddo = PrefixId.fromNamespaceLabel "https://w3id.org/iddo#" "iddo"
    static member idemo = PrefixId.fromNamespaceLabel "http://rdf.insee.fr/def/demo#" "idemo"
    static member identity = PrefixId.fromNamespaceLabel "http://www.identity.org/ontologies/identity.owl#" "identity"
    static member ids = PrefixId.fromNamespaceLabel "https://w3id.org/idsa/core/" "ids"
    static member ifc = PrefixId.fromNamespaceLabel "https://w3id.org/ifc/IFC4_ADD1#" "ifc"
    static member igeo = PrefixId.fromNamespaceLabel "http://rdf.insee.fr/def/geo#" "igeo"
    static member ignf = PrefixId.fromNamespaceLabel "http://data.ign.fr/def/ignf#" "ignf"
    static member imo = PrefixId.fromNamespaceLabel "http://imgpedia.dcc.uchile.cl/ontology#" "imo"
    static member incident = PrefixId.fromNamespaceLabel "http://vocab.resc.info/incident#" "incident"
    static member infor = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/informationrealization.owl#" "infor"
    static member inno = PrefixId.fromNamespaceLabel "http://purl.org/innovation/ns#" "inno"
    static member interact = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/interactivityType/" "interact"
    static member interval = PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/intervals/" "interval"
    static member intro = PrefixId.fromNamespaceLabel "https://w3id.org/lso/intro/beta202408#" "intro"
    static member ioc = PrefixId.fromNamespaceLabel "http://w3id.org/ioc#" "ioc"
    static member iol = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/dul/IOLite.owl#" "iol"
    static member iot_lite = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/UNIS/fiware/iot-lite#" "iot-lite"
    static member ioto = PrefixId.fromNamespaceLabel "http://www.irit.fr/recherches/MELODI/ontologies/IoT-O#" "ioto"
    static member iottaxolite = PrefixId.fromNamespaceLabel "http://purl.org/iot/vocab/iot-taxonomy-lite#" "iottaxolite"
    static member ipo = PrefixId.fromNamespaceLabel "http://purl.org/ipo/core#" "ipo"
    static member irao = PrefixId.fromNamespaceLabel "http://ontology.ethereal.cz/irao/" "irao"
    static member irw = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/web/irw.owl#" "irw"
    static member is = PrefixId.fromNamespaceLabel "http://purl.org/ontology/is/core#" "is"
    static member isbd = PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/isbd/elements/" "isbd"
    static member ishi = PrefixId.fromNamespaceLabel "https://w3id.org/ishikawa-diagram-ontology#" "ishi"
    static member iso37120 = PrefixId.fromNamespaceLabel "http://ontology.eil.utoronto.ca/ISO37120.owl#" "iso37120"
    static member isoadr = PrefixId.fromNamespaceLabel "http://reference.data.gov.au/def/ont/iso19160-1-address#" "isoadr"
    static member isoprops = PrefixId.fromNamespaceLabel "https://w3id.org/isoprops#" "isoprops"
    static member ispra = PrefixId.fromNamespaceLabel "http://dati.isprambiente.it/ontology/core#" "ispra"
    static member istex = PrefixId.fromNamespaceLabel "https://data.istex.fr/ontology/istex#" "istex"
    static member itm = PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/genericTools/itm/1.0#" "itm"
    static member itsmo = PrefixId.fromNamespaceLabel "http://ontology.it/itsmo/v1#" "itsmo"
    static member ivoam = PrefixId.fromNamespaceLabel "http://www.ivoa.net/rdf/messenger#" "ivoam"
    static member jsonsc = PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/json-schema#" "jsonsc"
    static member jup = PrefixId.fromNamespaceLabel "http://w3id.org/charta77/jup/" "jup"
    static member jur = PrefixId.fromNamespaceLabel "http://sweet.jpl.nasa.gov/2.3/humanJurisdiction.owl#" "jur"
    static member juso = PrefixId.fromNamespaceLabel "http://rdfs.co/juso/" "juso"
    static member juso'_period_'kr = PrefixId.fromNamespaceLabel "http://rdfs.co/juso/kr/" "juso.kr"
    static member kdo = PrefixId.fromNamespaceLabel "http://kdo.render-project.eu/kdo#" "kdo"
    static member kees = PrefixId.fromNamespaceLabel "http://linkeddata.center/kees/v1#" "kees"
    static member keys = PrefixId.fromNamespaceLabel "http://purl.org/NET/c4dm/keys.owl#" "keys"
    static member kgc = PrefixId.fromNamespaceLabel "http://kgc.knowledge-graph.jp/ontology/kgc.owl#" "kgc"
    static member km4c = PrefixId.fromNamespaceLabel "http://www.disit.org/km4city/schema#" "km4c"
    static member label = PrefixId.fromNamespaceLabel "http://purl.org/net/vocab/2004/03/label#" "label"
    static member language = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/languages#" "language"
    static member lawd = PrefixId.fromNamespaceLabel "http://lawd.info/ontology/" "lawd"
    static member lc = PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/linkedconnections#" "lc"
    static member lcc_3166_1 = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/ISO3166-1-CountryCodes/" "lcc-3166-1"
    static member lcc_3166_2 = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/ISO3166-2-SubdivisionCodes/" "lcc-3166-2"
    static member lcc_3166_2_ca = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-CA/" "lcc-3166-2-ca"
    static member lcc_3166_2_gb = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-GB/" "lcc-3166-2-gb"
    static member lcc_3166_2_mx = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-MX/" "lcc-3166-2-mx"
    static member lcc_3166_2_us = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/Regions/ISO3166-2-SubdivisionCodes-US/" "lcc-3166-2-us"
    static member lcc_639_1 = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Languages/ISO639-1-LanguageCodes/" "lcc-639-1"
    static member lcc_639_2 = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Languages/ISO639-2-LanguageCodes/" "lcc-639-2"
    static member lcc_cr = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Countries/CountryRepresentation/" "lcc-cr"
    static member lcc_lr = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/LCC/Languages/LanguageRepresentation/" "lcc-lr"
    static member ldp = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ldp#" "ldp"
    static member ldr = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ldr/ns#" "ldr"
    static member ldvm = PrefixId.fromNamespaceLabel "http://linked.opendata.cz/ontology/ldvm/" "ldvm"
    static member lemon = PrefixId.fromNamespaceLabel "http://lemon-model.net/lemon#" "lemon"
    static member lexdcp = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/decomp#" "lexdcp"
    static member lexinfo = PrefixId.fromNamespaceLabel "http://www.lexinfo.net/ontology/2.0/lexinfo#" "lexinfo"
    static member lgdo = PrefixId.fromNamespaceLabel "http://linkedgeodata.org/ontology/" "lgdo"
    static member lh = PrefixId.fromNamespaceLabel "https://w3id.org/legalhtml/ov#" "lh"
    static member li = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/lineage#" "li"
    static member lib = PrefixId.fromNamespaceLabel "http://purl.org/library/" "lib"
    static member lifecycle = PrefixId.fromNamespaceLabel "http://purl.org/vocab/lifecycle/schema#" "lifecycle"
    static member lime = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/lime#" "lime"
    static member limo = PrefixId.fromNamespaceLabel "http://purl.org/limo-ontology/limo#" "limo"
    static member limoo = PrefixId.fromNamespaceLabel "http://purl.org/LiMo/0.1#" "limoo"
    static member lingvo = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/lingvoj#" "lingvo"
    static member lio = PrefixId.fromNamespaceLabel "http://purl.org/net/lio#" "lio"
    static member llont = PrefixId.fromNamespaceLabel "http://www.linklion.org/ontology#" "llont"
    static member lmm1 = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/lmm/LMM_L1.owl#" "lmm1"
    static member lmm2 = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/lmm/LMM_L2.owl#" "lmm2"
    static member loc = PrefixId.fromNamespaceLabel "http://purl.org/ctic/infraestructuras/localizacion#" "loc"
    static member locah = PrefixId.fromNamespaceLabel "http://data.archiveshub.ac.uk/def/" "locah"
    static member locn = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/locn#" "locn"
    static member lode = PrefixId.fromNamespaceLabel "http://linkedevents.org/ontology/" "lode"
    static member log = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/10/swap/log#" "log"
    static member loin = PrefixId.fromNamespaceLabel "https://w3id.org/loin#" "loin"
    static member lom = PrefixId.fromNamespaceLabel "http://data.opendiscoveryspace.eu/lom_ontology_ods.owl#" "lom"
    static member losp = PrefixId.fromNamespaceLabel "http://sparql.sstu.ru:3030/speciality/" "losp"
    static member loted = PrefixId.fromNamespaceLabel "http://loted.eu/ontology#" "loted"
    static member lrmi = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-terms/" "lrmi"
    static member lrmoo = PrefixId.fromNamespaceLabel "http://iflastandards.info/ns/lrm/lrmoo/" "lrmoo"
    static member lsc = PrefixId.fromNamespaceLabel "http://linkedscience.org/lsc/ns#" "lsc"
    static member lslife = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper.owl#" "lslife"
    static member lsmap = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-data.owl#" "lsmap"
    static member lsq = PrefixId.fromNamespaceLabel "http://lsq.aksw.org/vocab#" "lsq"
    static member lswmo = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-modelling.owl#" "lswmo"
    static member lswpm = PrefixId.fromNamespaceLabel "http://ontology.cybershare.utep.edu/ELSEWeb/elseweb-lifemapper-parameters.owl#" "lswpm"
    static member ludo = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo" "ludo"
    static member ludo_gm = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/gamemodel#" "ludo-gm"
    static member ludo_gp = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/gamepresentation#" "ludo-gp"
    static member ludo_vc = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/virtualcontext#" "ludo-vc"
    static member ludo_xapi = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ludo/v1/xapi#" "ludo-xapi"
    static member lv = PrefixId.fromNamespaceLabel "http://purl.org/lobid/lv#" "lv"
    static member lvont = PrefixId.fromNamespaceLabel "http://lexvo.org/ontology#" "lvont"
    static member lyou = PrefixId.fromNamespaceLabel "http://purl.org/linkingyou/" "lyou"
    static member m3lite = PrefixId.fromNamespaceLabel "http://purl.org/iot/vocab/m3-lite#" "m3lite"
    static member m4i = PrefixId.fromNamespaceLabel "http://w3id.org/nfdi4ing/metadata4ing#" "m4i"
    static member ma_ont = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ma-ont#" "ma-ont"
    static member mads = PrefixId.fromNamespaceLabel "http://www.loc.gov/mads/rdf/v1#" "mads"
    static member marl = PrefixId.fromNamespaceLabel "http://www.gsi.dit.upm.es/ontologies/marl/ns#" "marl"
    static member maso = PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/MASO#" "maso"
    static member md = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19115/2003/metadata#" "md"
    static member mdi = PrefixId.fromNamespaceLabel "https://w3id.org/multidimensional-interface/ontology#" "mdi"
    static member mdo = PrefixId.fromNamespaceLabel "https://w3id.org/mdo/full/" "mdo"
    static member mdo_calc = PrefixId.fromNamespaceLabel "https://w3id.org/mdo/calculation/" "mdo-calc"
    static member mdo_struc = PrefixId.fromNamespaceLabel "https://w3id.org/mdo/structure/" "mdo-struc"
    static member mdoprov = PrefixId.fromNamespaceLabel "https://w3id.org/mdo/provenance/" "mdoprov"
    static member mdr = PrefixId.fromNamespaceLabel "http://semanticturkey.uniroma2.it/ns/mdr#" "mdr"
    static member meb = PrefixId.fromNamespaceLabel "http://rdf.myexperiment.org/ontologies/base/" "meb"
    static member media = PrefixId.fromNamespaceLabel "http://purl.org/media#" "media"
    static member medred = PrefixId.fromNamespaceLabel "http://w3id.org/medred/medred#" "medred"
    static member mexalgo = PrefixId.fromNamespaceLabel "http://mex.aksw.org/mex-algo#" "mexalgo"
    static member mexcore = PrefixId.fromNamespaceLabel "http://mex.aksw.org/mex-core#" "mexcore"
    static member mexperf = PrefixId.fromNamespaceLabel "http://mex.aksw.org/mex-perf#" "mexperf"
    static member mil = PrefixId.fromNamespaceLabel "http://rdf.muninn-project.org/ontologies/military#" "mil"
    static member mito = PrefixId.fromNamespaceLabel "http://purl.org/spar/mito/" "mito"
    static member mls = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/mls#" "mls"
    static member mo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/mo/" "mo"
    static member moac = PrefixId.fromNamespaceLabel "http://observedchange.com/moac/ns#" "moac"
    static member moat = PrefixId.fromNamespaceLabel "http://moat-project.org/ns#" "moat"
    static member mod_ = PrefixId.fromNamespaceLabel "http://www.isibang.ac.in/ns/mod#" "mod"
    static member modp = PrefixId.fromNamespaceLabel "https://w3id.org/mod#" "modp"
    static member modsci = PrefixId.fromNamespaceLabel "https://w3id.org/skgo/modsci#" "modsci"
    static member mrel = PrefixId.fromNamespaceLabel "http://id.loc.gov/vocabulary/relators/" "mrel"
    static member mrela = PrefixId.fromNamespaceLabel "http://sweet.jpl.nasa.gov/2.3/relaMath.owl#" "mrela"
    static member mro = PrefixId.fromNamespaceLabel "https://www.commoncoreontologies.org/mro/" "mro"
    static member msm = PrefixId.fromNamespaceLabel "http://iserve.kmi.open.ac.uk/ns/msm#" "msm"
    static member mso_em = PrefixId.fromNamespaceLabel "https://www.purl.org/mso-em#" "mso-em"
    static member msr = PrefixId.fromNamespaceLabel "http://www.telegraphis.net/ontology/measurement/measurement#" "msr"
    static member mtlo = PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/MarineTLO/v4/marinetlo.owl#" "mtlo"
    static member munc = PrefixId.fromNamespaceLabel "http://ns.inria.fr/munc#" "munc"
    static member mus = PrefixId.fromNamespaceLabel "http://data.doremus.org/ontology#" "mus"
    static member music = PrefixId.fromNamespaceLabel "http://www.kanzaki.com/ns/music#" "music"
    static member muto = PrefixId.fromNamespaceLabel "http://purl.org/muto/core#" "muto"
    static member mv = PrefixId.fromNamespaceLabel "http://schema.mobivoc.org/" "mv"
    static member mvco = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/mvco.owl#" "mvco"
    static member nao = PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/08/15/nao#" "nao"
    static member nas = PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/NAS#" "nas"
    static member ncal = PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/04/02/ncal#" "ncal"
    static member nco = PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/03/22/nco#" "nco"
    static member nen2660 = PrefixId.fromNamespaceLabel "https://w3id.org/nen2660/def#" "nen2660"
    static member nen3610 = PrefixId.fromNamespaceLabel "http://modellen.geostandaarden.nl/def/nen3610#" "nen3610"
    static member nfo = PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/03/22/nfo#" "nfo"
    static member ngeo = PrefixId.fromNamespaceLabel "http://geovocab.org/geometry#" "ngeo"
    static member nie = PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/01/19/nie#" "nie"
    static member nif = PrefixId.fromNamespaceLabel "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/nif-core#" "nif"
    static member nlon = PrefixId.fromNamespaceLabel "http://lod.nl.go.kr/ontology/" "nlon"
    static member nno = PrefixId.fromNamespaceLabel "https://w3id.org/nno/ontology#" "nno"
    static member noria = PrefixId.fromNamespaceLabel "https://w3id.org/noria/ontology/" "noria"
    static member np = PrefixId.fromNamespaceLabel "http://www.nanopub.org/nschema#" "np"
    static member npg = PrefixId.fromNamespaceLabel "http://ns.nature.com/terms/" "npg"
    static member nrl = PrefixId.fromNamespaceLabel "http://www.semanticdesktop.org/ontologies/2007/08/15/nrl#" "nrl"
    static member nrv = PrefixId.fromNamespaceLabel "http://ns.inria.fr/nrv#" "nrv"
    static member nsl = PrefixId.fromNamespaceLabel "http://purl.org/ontology/storyline/" "nsl"
    static member ntag = PrefixId.fromNamespaceLabel "http://ns.inria.fr/nicetag/2010/09/09/voc#" "ntag"
    static member nyon = PrefixId.fromNamespaceLabel "https://w3id.org/def/nyon#" "nyon"
    static member oa = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/oa#" "oa"
    static member oad = PrefixId.fromNamespaceLabel "http://culturalis.org/oad#" "oad"
    static member oae = PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/oae/core#" "oae"
    static member oan = PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/oan/" "oan"
    static member obo = PrefixId.fromNamespaceLabel "http://purl.obolibrary.org/obo/" "obo"
    static member observation = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#" "observation"
    static member obsm = PrefixId.fromNamespaceLabel "http://rdf.geospecies.org/methods/observationMethod#" "obsm"
    static member obws = PrefixId.fromNamespaceLabel "http://delicias.dia.fi.upm.es/ontologies/ObjectWithStates.owl#" "obws"
    static member oc = PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/core/expression#" "oc"
    static member ocd = PrefixId.fromNamespaceLabel "http://dati.camera.it/ocd/" "ocd"
    static member ocds = PrefixId.fromNamespaceLabel "http://purl.org/onto-ocds/ocds#" "ocds"
    static member och = PrefixId.fromNamespaceLabel "https://w3id.org/def/och#" "och"
    static member ocmv = PrefixId.fromNamespaceLabel "https://w3id.org/ontouml-models/vocabulary#" "ocmv"
    static member odapp = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/odapp#" "odapp"
    static member odapps = PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/odapps#" "odapps"
    static member odpart = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/participation.owl#" "odpart"
    static member odrl = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/odrl/2/" "odrl"
    static member odrs = PrefixId.fromNamespaceLabel "http://schema.theodi.org/odrs#" "odrs"
    static member odv = PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/organogram/" "odv"
    static member oecc = PrefixId.fromNamespaceLabel "http://www.oegov.org/core/owl/cc#" "oecc"
    static member of_ = PrefixId.fromNamespaceLabel "http://owlrep.eu01.aws.af.cm/fridge#" "of"
    static member ofo = PrefixId.fromNamespaceLabel "https://w3id.org/ofo#" "ofo"
    static member ofrd = PrefixId.fromNamespaceLabel "http://purl.org/opdm/refrigerator#" "ofrd"
    static member og = PrefixId.fromNamespaceLabel "http://ogp.me/ns#" "og"
    static member oh = PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/oh#" "oh"
    static member okh = PrefixId.fromNamespaceLabel "https://w3id.org/oseg/ont/okh#" "okh"
    static member olca = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/olca#" "olca"
    static member olo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/olo/core#" "olo"
    static member om = PrefixId.fromNamespaceLabel "https://open-metadata.org/ontology/" "om"
    static member omg = PrefixId.fromNamespaceLabel "https://w3id.org/omg#" "omg"
    static member omg_ann = PrefixId.fromNamespaceLabel "https://www.omg.org/spec/Commons/AnnotationVocabulary/" "omg-ann"
    static member oml = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/ontology/om/om-lite#" "oml"
    static member omn = PrefixId.fromNamespaceLabel "http://open-multinet.info/ontology/omn#" "omn"
    static member omnfed = PrefixId.fromNamespaceLabel "http://open-multinet.info/ontology/omn-federation#" "omnfed"
    static member omnlc = PrefixId.fromNamespaceLabel "http://open-multinet.info/ontology/omn-lifecycle#" "omnlc"
    static member onc = PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/oncm/core#" "onc"
    static member ont = PrefixId.fromNamespaceLabel "http://purl.org/net/ns/ontology-annot#" "ont"
    static member ontolex = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/ontolex#" "ontolex"
    static member ontopic = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/ont/dul/ontopic.owl#" "ontopic"
    static member ontosec = PrefixId.fromNamespaceLabel "http://www.semanticweb.org/ontologies/2008/11/OntologySecurity.owl#" "ontosec"
    static member ontouml = PrefixId.fromNamespaceLabel "https://w3id.org/ontouml#" "ontouml"
    static member onyx = PrefixId.fromNamespaceLabel "http://www.gsi.dit.upm.es/ontologies/onyx/ns#" "onyx"
    static member oo = PrefixId.fromNamespaceLabel "http://purl.org/openorg/" "oo"
    static member op = PrefixId.fromNamespaceLabel "http://environment.data.gov.au/def/op#" "op"
    static member openwemi = PrefixId.fromNamespaceLabel "https://ns.dublincore.org/openwemi/" "openwemi"
    static member opmo = PrefixId.fromNamespaceLabel "http://openprovenance.org/model/opmo#" "opmo"
    static member opmv = PrefixId.fromNamespaceLabel "http://purl.org/net/opmv/ns#" "opmv"
    static member opmw = PrefixId.fromNamespaceLabel "http://www.opmw.org/ontology/" "opmw"
    static member opo = PrefixId.fromNamespaceLabel "http://online-presence.net/opo/ns#" "opo"
    static member opti = PrefixId.fromNamespaceLabel "https://w3id.org/optimar#" "opti"
    static member opus = PrefixId.fromNamespaceLabel "http://lsdis.cs.uga.edu/projects/semdis/opus#" "opus"
    static member orca = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/orca#" "orca"
    static member ore = PrefixId.fromNamespaceLabel "http://www.openarchives.org/ore/terms/" "ore"
    static member org = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/org#" "org"
    static member organism = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/organism#" "organism"
    static member organization = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/organization#" "organization"
    static member orges = PrefixId.fromNamespaceLabel "http://datos.gob.es/def/sector-publico/organizacion#" "orges"
    static member osadm = PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/admingeo/" "osadm"
    static member osgeom = PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/geometry/" "osgeom"
    static member oslc = PrefixId.fromNamespaceLabel "http://open-services.net/ns/core#" "oslc"
    static member oslc_am = PrefixId.fromNamespaceLabel "http://open-services.net/ns/am#" "oslc_am"
    static member oslc_auto = PrefixId.fromNamespaceLabel "http://open-services.net/ns/auto#" "oslc_auto"
    static member oslc_cm = PrefixId.fromNamespaceLabel "http://open-services.net/ns/cm#" "oslc_cm"
    static member oslc_config = PrefixId.fromNamespaceLabel "http://open-services.net/ns/config#" "oslc_config"
    static member oslc_rm = PrefixId.fromNamespaceLabel "http://open-services.net/ns/rm#" "oslc_rm"
    static member oslc_sysmlv2 = PrefixId.fromNamespaceLabel "http://open-services.net/ns/sysmlv2#" "oslc_sysmlv2"
    static member oslo = PrefixId.fromNamespaceLabel "http://purl.org/oslo/ns/localgov#" "oslo"
    static member oso = PrefixId.fromNamespaceLabel "https://w3id.org/earthsemantics/OSO#" "oso"
    static member osp = PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/osp#" "osp"
    static member osr = PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/core/space#" "osr"
    static member osspr = PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/spatialrelations/" "osspr"
    static member ostop = PrefixId.fromNamespaceLabel "http://www.ordnancesurvey.co.uk/ontology/Topography/v0.1/Topography.owl#" "ostop"
    static member otl = PrefixId.fromNamespaceLabel "https://w3id.org/opentrafficlights#" "otl"
    static member oum = PrefixId.fromNamespaceLabel "http://www.ontology-of-units-of-measure.org/resource/om-2/" "oum"
    static member ov = PrefixId.fromNamespaceLabel "http://open.vocab.org/terms/" "ov"
    static member owl = PrefixId.fromNamespaceLabel "http://www.w3.org/2002/07/owl#" "owl"
    static member owltime = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time#" "owltime"
    static member p_plan = PrefixId.fromNamespaceLabel "http://purl.org/net/p-plan#" "p-plan"
    static member parl = PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/parliament/" "parl"
    static member part = PrefixId.fromNamespaceLabel "http://purl.org/vocab/participation/schema#" "part"
    static member passim = PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/passim#" "passim"
    static member pat = PrefixId.fromNamespaceLabel "http://purl.org/hpi/patchr#" "pat"
    static member pattern = PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2008/12/pattern#" "pattern"
    static member pav = PrefixId.fromNamespaceLabel "http://purl.org/pav/" "pav"
    static member pay = PrefixId.fromNamespaceLabel "http://reference.data.gov.uk/def/payment#" "pay"
    static member pbo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/pbo/core#" "pbo"
    static member pc = PrefixId.fromNamespaceLabel "http://purl.org/procurement/public-contracts#" "pc"
    static member pd = PrefixId.fromNamespaceLabel "https://w3id.org/dpv/pd#" "pd"
    static member pdo = PrefixId.fromNamespaceLabel "http://ontologies.smile.deri.ie/pdo#" "pdo"
    static member peco = PrefixId.fromNamespaceLabel "https://w3id.org/peco#" "peco"
    static member pep = PrefixId.fromNamespaceLabel "https://w3id.org/pep/" "pep"
    static member person = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/person#" "person"
    static member pext = PrefixId.fromNamespaceLabel "http://www.ontotext.com/proton/protonext#" "pext"
    static member pghdprovo = PrefixId.fromNamespaceLabel "https://w3id.org/pghdprovo#" "pghdprovo"
    static member phdd = PrefixId.fromNamespaceLabel "http://rdf-vocabulary.ddialliance.org/phdd#" "phdd"
    static member physical = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/physicalResource#" "physical"
    static member pico = PrefixId.fromNamespaceLabel "http://data.cochrane.org/ontologies/pico/" "pico"
    static member pimsii = PrefixId.fromNamespaceLabel "http://www.molmod.info/semantics/pims-ii.ttl#" "pimsii"
    static member pko = PrefixId.fromNamespaceLabel "https://w3id.org/pko#" "pko"
    static member place = PrefixId.fromNamespaceLabel "http://purl.org/ontology/places#" "place"
    static member plink = PrefixId.fromNamespaceLabel "http://cedric.cnam.fr/isid/ontologies/PersonLink.owl#" "plink"
    static member plo = PrefixId.fromNamespaceLabel "http://purl.org/net/po#" "plo"
    static member pmlp = PrefixId.fromNamespaceLabel "http://inference-web.org/2.0/pml-provenance.owl#" "pmlp"
    static member pmofn = PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/fn#" "pmofn"
    static member pmonb = PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/nb#" "pmonb"
    static member pmopb = PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/pb#" "pmopb"
    static member pmovn = PrefixId.fromNamespaceLabel "http://premon.fbk.eu/ontology/vn#" "pmovn"
    static member pna = PrefixId.fromNamespaceLabel "http://data.press.net/ontology/asset/" "pna"
    static member pne = PrefixId.fromNamespaceLabel "http://data.press.net/ontology/event/" "pne"
    static member pni = PrefixId.fromNamespaceLabel "http://data.press.net/ontology/identifier/" "pni"
    static member pns = PrefixId.fromNamespaceLabel "http://data.press.net/ontology/stuff/" "pns"
    static member pnt = PrefixId.fromNamespaceLabel "http://data.press.net/ontology/tag/" "pnt"
    static member po = PrefixId.fromNamespaceLabel "http://purl.org/ontology/po/" "po"
    static member poder = PrefixId.fromNamespaceLabel "http://dev.poderopedia.com/vocab/" "poder"
    static member poso = PrefixId.fromNamespaceLabel "http://purl.org/poso/" "poso"
    static member posocm = PrefixId.fromNamespaceLabel "http://purl.org/poso/common/" "posocm"
    static member postcode = PrefixId.fromNamespaceLabel "http://data.ordnancesurvey.co.uk/ontology/postcode/" "postcode"
    static member poste = PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/poste#" "poste"
    static member ppo = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/ppo#" "ppo"
    static member pproc = PrefixId.fromNamespaceLabel "http://contsem.unizar.es/def/sector-publico/pproc#" "pproc"
    static member pr = PrefixId.fromNamespaceLabel "http://purl.org/ontology/prv/core#" "pr"
    static member premis = PrefixId.fromNamespaceLabel "http://www.loc.gov/premis/rdf/v1#" "premis"
    static member prissma = PrefixId.fromNamespaceLabel "http://ns.inria.fr/prissma/v2#" "prissma"
    static member pro = PrefixId.fromNamespaceLabel "http://purl.org/spar/pro/" "pro"
    static member prof = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/dx/prof/" "prof"
    static member prog = PrefixId.fromNamespaceLabel "http://purl.org/prog/" "prog"
    static member prov = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/prov#" "prov"
    static member provoc = PrefixId.fromNamespaceLabel "http://ns.inria.fr/provoc#" "provoc"
    static member prv = PrefixId.fromNamespaceLabel "http://purl.org/net/provenance/ns#" "prv"
    static member prvt = PrefixId.fromNamespaceLabel "http://purl.org/net/provenance/types#" "prvt"
    static member psh = PrefixId.fromNamespaceLabel "http://ns.inria.fr/probabilistic-shacl/" "psh"
    static member psn = PrefixId.fromNamespaceLabel "https://purl.org/psn/vocab#" "psn"
    static member pso = PrefixId.fromNamespaceLabel "http://purl.org/spar/pso/" "pso"
    static member ptop = PrefixId.fromNamespaceLabel "http://www.ontotext.com/proton/protontop#" "ptop"
    static member pubsub = PrefixId.fromNamespaceLabel "https://vocab.eccenca.com/pubsub/" "pubsub"
    static member puv = PrefixId.fromNamespaceLabel "https://w3id.org/env/puv#" "puv"
    static member pwo = PrefixId.fromNamespaceLabel "http://purl.org/spar/pwo/" "pwo"
    static member qb = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/cube#" "qb"
    static member qb4o = PrefixId.fromNamespaceLabel "http://purl.org/qb4olap/cubes#" "qb4o"
    static member qkdv = PrefixId.fromNamespaceLabel "http://qudt.org/vocab/dimensionvector/" "qkdv"
    static member qu = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/qu/qu#" "qu"
    static member quant = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/quantities#" "quant"
    static member quantitykind = PrefixId.fromNamespaceLabel "http://qudt.org/vocab/quantitykind/" "quantitykind"
    static member qudt = PrefixId.fromNamespaceLabel "http://qudt.org/schema/qudt/" "qudt"
    static member r4r = PrefixId.fromNamespaceLabel "http://guava.iis.sinica.edu.tw/r4r/" "r4r"
    static member r_arco = PrefixId.fromNamespaceLabel "https://w3id.org/arco/ontology/arco/" "r-arco"
    static member radion = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/radion#" "radion"
    static member rains = PrefixId.fromNamespaceLabel "https://w3id.org/rains#" "rains"
    static member rami = PrefixId.fromNamespaceLabel "http://iais.fraunhofer.de/vocabs/rami#" "rami"
    static member raul = PrefixId.fromNamespaceLabel "http://purl.org/NET/raul#" "raul"
    static member rb = PrefixId.fromNamespaceLabel "https://w3id.org/riverbench/schema/metadata#" "rb"
    static member rbdoc = PrefixId.fromNamespaceLabel "https://w3id.org/riverbench/schema/documentation#" "rbdoc"
    static member rdaa = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/a/" "rdaa"
    static member rdac = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/c/" "rdac"
    static member rdae = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/e/" "rdae"
    static member rdafrbr = PrefixId.fromNamespaceLabel "http://rdvocab.info/uri/schema/FRBRentitiesRDA/" "rdafrbr"
    static member rdag1 = PrefixId.fromNamespaceLabel "http://rdvocab.info/Elements/" "rdag1"
    static member rdag2 = PrefixId.fromNamespaceLabel "http://rdvocab.info/ElementsGr2/" "rdag2"
    static member rdag3 = PrefixId.fromNamespaceLabel "http://rdvocab.info/ElementsGr3/" "rdag3"
    static member rdai = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/i/" "rdai"
    static member rdam = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/m/" "rdam"
    static member rdarel = PrefixId.fromNamespaceLabel "http://rdvocab.info/RDARelationshipsWEMI/" "rdarel"
    static member rdarel2 = PrefixId.fromNamespaceLabel "http://metadataregistry.org/uri/schema/RDARelationshipsGR2/" "rdarel2"
    static member rdarole = PrefixId.fromNamespaceLabel "http://rdvocab.info/roles/" "rdarole"
    static member rdau = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/u/" "rdau"
    static member rdaw = PrefixId.fromNamespaceLabel "http://rdaregistry.info/Elements/w/" "rdaw"
    static member rddl = PrefixId.fromNamespaceLabel "http://www.rddl.org/" "rddl"
    static member rdf = PrefixId.fromNamespaceLabel "http://www.w3.org/1999/02/22-rdf-syntax-ns#" "rdf"
    static member rdfa = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/rdfa#" "rdfa"
    static member rdfc = PrefixId.fromNamespaceLabel "https://w3id.org/rdf-connect#" "rdfc"
    static member rdfg = PrefixId.fromNamespaceLabel "http://www.w3.org/2004/03/trix/rdfg-1/" "rdfg"
    static member rdfp = PrefixId.fromNamespaceLabel "https://w3id.org/rdfp/" "rdfp"
    static member rdfs = PrefixId.fromNamespaceLabel "http://www.w3.org/2000/01/rdf-schema#" "rdfs"
    static member rdft = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/rdftest#" "rdft"
    static member react = PrefixId.fromNamespaceLabel "https://w3id.org/react#" "react"
    static member rec54 = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/02pd/rec54#" "rec54"
    static member rec_ = PrefixId.fromNamespaceLabel "http://purl.org/ontology/rec/core#" "rec"
    static member reco = PrefixId.fromNamespaceLabel "http://purl.org/reco#" "reco"
    static member reegle = PrefixId.fromNamespaceLabel "http://reegle.info/schema#" "reegle"
    static member reg = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/registry#" "reg"
    static member rel = PrefixId.fromNamespaceLabel "http://purl.org/vocab/relationship/" "rel"
    static member remetca = PrefixId.fromNamespaceLabel "http://www.purl.org/net/remetca#" "remetca"
    static member reprSciUnits = PrefixId.fromNamespaceLabel "http://sweet.jpl.nasa.gov/2.3/reprSciUnits.owl#" "reprSciUnits"
    static member resourceType = PrefixId.fromNamespaceLabel "http://purl.org/dcx/lrmi-vocabs/learningResourceType/" "resourceType"
    static member rev = PrefixId.fromNamespaceLabel "http://purl.org/stuff/rev#" "rev"
    static member rico = PrefixId.fromNamespaceLabel "https://www.ica.org/standards/RiC/ontology#" "rico"
    static member rlog = PrefixId.fromNamespaceLabel "http://persistence.uni-leipzig.org/nlp2rdf/ontologies/rlog#" "rlog"
    static member rma = PrefixId.fromNamespaceLabel "https://ns.verisav.fr/rma#" "rma"
    static member rml_star = PrefixId.fromNamespaceLabel "http://w3id.org/rml/" "rml-star"
    static member ro = PrefixId.fromNamespaceLabel "http://purl.org/wf4ever/ro#" "ro"
    static member roh = PrefixId.fromNamespaceLabel "http://w3id.org/roh#" "roh"
    static member rooms = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/rooms#" "rooms"
    static member rov = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/regorg#" "rov"
    static member rr = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/r2rml#" "rr"
    static member rsctx = PrefixId.fromNamespaceLabel "http://softeng.polito.it/rsctx#" "rsctx"
    static member rss = PrefixId.fromNamespaceLabel "http://purl.org/rss/1.0/" "rss"
    static member ru = PrefixId.fromNamespaceLabel "http://purl.org/imbi/ru-meta.owl#" "ru"
    static member ruto = PrefixId.fromNamespaceLabel "http://rdfunit.aksw.org/ns/core#" "ruto"
    static member s4ac = PrefixId.fromNamespaceLabel "http://ns.inria.fr/s4ac/v2#" "s4ac"
    static member s4agri = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4agri/" "s4agri"
    static member s4bldg = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4bldg/" "s4bldg"
    static member s4city = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4city/" "s4city"
    static member s4ehaw = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4ehaw/" "s4ehaw"
    static member s4ener = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4ener/" "s4ener"
    static member s4envi = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4envi/" "s4envi"
    static member s4inma = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4inma/" "s4inma"
    static member s4syst = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4syst/" "s4syst"
    static member s4watr = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4watr/" "s4watr"
    static member s4wear = PrefixId.fromNamespaceLabel "https://saref.etsi.org/saref4wear/" "s4wear"
    static member sam = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#" "sam"
    static member samfl = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/ontology/om/sam-lite#" "samfl"
    static member san_lod = PrefixId.fromNamespaceLabel "http://dati.san.beniculturali.it/SAN/" "san-lod"
    static member sao = PrefixId.fromNamespaceLabel "http://salt.semanticauthoring.org/ontologies/sao#" "sao"
    static member saont = PrefixId.fromNamespaceLabel "https://w3id.org/sao#" "saont"
    static member saref = PrefixId.fromNamespaceLabel "https://saref.etsi.org/core/" "saref"
    static member sarif = PrefixId.fromNamespaceLabel "http://sarif.info/" "sarif"
    static member saws = PrefixId.fromNamespaceLabel "http://purl.org/saws/ontology#" "saws"
    static member sbeo = PrefixId.fromNamespaceLabel "https://w3id.org/sbeo#" "sbeo"
    static member schema = PrefixId.fromNamespaceLabel "http://schema.org/" "schema"
    static member schemas = PrefixId.fromNamespaceLabel "https://schema.org/" "schemas"
    static member scip = PrefixId.fromNamespaceLabel "http://lod.taxonconcept.org/ontology/sci_people.owl#" "scip"
    static member scoro = PrefixId.fromNamespaceLabel "http://purl.org/spar/scoro/" "scoro"
    static member scot = PrefixId.fromNamespaceLabel "http://rdfs.org/scot/ns#" "scot"
    static member scovo = PrefixId.fromNamespaceLabel "http://purl.org/NET/scovo#" "scovo"
    static member screla = PrefixId.fromNamespaceLabel "http://sweet.jpl.nasa.gov/2.3/relaSci.owl#" "screla"
    static member scsv = PrefixId.fromNamespaceLabel "http://purl.org/NET/schema-org-csv#" "scsv"
    static member sd = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/sparql-service-description#" "sd"
    static member sdm = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/sdm#" "sdm"
    static member sdmx = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/sdmx#" "sdmx"
    static member sdmx_code = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/sdmx/2009/code#" "sdmx-code"
    static member sdmx_dimension = PrefixId.fromNamespaceLabel "http://purl.org/linked-data/sdmx/2009/dimension#" "sdmx-dimension"
    static member sdo = PrefixId.fromNamespaceLabel "http://salt.semanticauthoring.org/ontologies/sdo#" "sdo"
    static member sdom = PrefixId.fromNamespaceLabel "https://w3id.org/okn/o/sdm#" "sdom"
    static member sdont = PrefixId.fromNamespaceLabel "https://w3id.org/okn/o/sd#" "sdont"
    static member sealit = PrefixId.fromNamespaceLabel "http://www.sealitproject.eu/ontology/" "sealit"
    static member search = PrefixId.fromNamespaceLabel "http://sindice.com/vocab/search#" "search"
    static member seasbo = PrefixId.fromNamespaceLabel "https://w3id.org/seas/" "seasbo"
    static member security = PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/securityMain#" "security"
    static member sem = PrefixId.fromNamespaceLabel "http://semanticweb.cs.vu.nl/2009/11/sem/" "sem"
    static member semio = PrefixId.fromNamespaceLabel "http://www.lingvoj.org/semio#" "semio"
    static member semiotics = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/semiotics.owl#" "semiotics"
    static member semsur = PrefixId.fromNamespaceLabel "http://purl.org/SemSur/" "semsur"
    static member semts = PrefixId.fromNamespaceLabel "https://w3id.org/semts/ontology#" "semts"
    static member seo = PrefixId.fromNamespaceLabel "https://w3id.org/seo#" "seo"
    static member seq = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/sequence.owl#" "seq"
    static member server = PrefixId.fromNamespaceLabel "https://w3id.org/yang/server#" "server"
    static member service = PrefixId.fromNamespaceLabel "http://purl.org/ontology/service#" "service"
    static member sf = PrefixId.fromNamespaceLabel "http://www.opengis.net/ont/sf#" "sf"
    static member sh = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/shacl#" "sh"
    static member shex = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/shex#" "shex"
    static member shoah = PrefixId.fromNamespaceLabel "http://dati.cdec.it/lod/shoah/" "shoah"
    static member shsh = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/shacl-shacl#" "shsh"
    static member shw = PrefixId.fromNamespaceLabel "http://paul.staroch.name/thesis/SmartHomeWeather.owl#" "shw"
    static member si_constant = PrefixId.fromNamespaceLabel "https://si-digital-framework.org/constants/" "si-constant"
    static member sim = PrefixId.fromNamespaceLabel "http://purl.org/ontology/similarity/" "sim"
    static member simu = PrefixId.fromNamespaceLabel "https://www.w3id.org/simulation/ontology/" "simu"
    static member sio = PrefixId.fromNamespaceLabel "http://semanticscience.org/resource/" "sio"
    static member sioc = PrefixId.fromNamespaceLabel "http://rdfs.org/sioc/ns#" "sioc"
    static member situ = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/situation.owl#" "situ"
    static member skos = PrefixId.fromNamespaceLabel "http://www.w3.org/2004/02/skos/core#" "skos"
    static member skosthes = PrefixId.fromNamespaceLabel "http://purl.org/iso25964/skos-thes#" "skosthes"
    static member skosxl = PrefixId.fromNamespaceLabel "http://www.w3.org/2008/05/skos-xl#" "skosxl"
    static member sm = PrefixId.fromNamespaceLabel "http://www.omg.org/techprocess/ab/SpecificationMetadata/" "sm"
    static member smg = PrefixId.fromNamespaceLabel "http://ns.cerise-project.nl/energy/def/cim-smartgrid#" "smg"
    static member snarm = PrefixId.fromNamespaceLabel "http://rdf.myexperiment.org/ontologies/snarm/" "snarm"
    static member snomed = PrefixId.fromNamespaceLabel "http://purl.bioontology.org/ontology/SNOMEDCT/" "snomed"
    static member solid = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/solid/terms#" "solid"
    static member sor = PrefixId.fromNamespaceLabel "http://purl.org/net/soron/" "sor"
    static member sosa = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/sosa/" "sosa"
    static member sou = PrefixId.fromNamespaceLabel "http://qudt.org/vocab/sou/" "sou"
    static member sou21 = PrefixId.fromNamespaceLabel "http://qudt.org/2.1/vocab/sou/" "sou21"
    static member sp = PrefixId.fromNamespaceLabel "http://spinrdf.org/sp#" "sp"
    static member space = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/space#" "space"
    static member spatial = PrefixId.fromNamespaceLabel "http://geovocab.org/spatial#" "spatial"
    static member spcm = PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/deployment/spcm/1.0#" "spcm"
    static member spdx = PrefixId.fromNamespaceLabel "https://spdx.org/rdf/3.1/terms/" "spdx"
    static member spdxl = PrefixId.fromNamespaceLabel "https://spdx.org/licenses/" "spdxl"
    static member spdxt = PrefixId.fromNamespaceLabel "http://spdx.org/rdf/terms#" "spdxt"
    static member spdxterms = PrefixId.fromNamespaceLabel "http://spdx.org/rdfterms/spdx#" "spdxterms"
    static member spfood = PrefixId.fromNamespaceLabel "http://kmi.open.ac.uk/projects/smartproducts/ontologies/food.owl#" "spfood"
    static member spin = PrefixId.fromNamespaceLabel "http://spinrdf.org/spin#" "spin"
    static member sport = PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/sport/" "sport"
    static member spt = PrefixId.fromNamespaceLabel "http://spitfire-project.eu/ontology/ns/" "spt"
    static member spvqa = PrefixId.fromNamespaceLabel "https://bmake.th-brandenburg.de/spv#" "spvqa"
    static member sql = PrefixId.fromNamespaceLabel "http://ns.inria.fr/ast/sql#" "sql"
    static member sri = PrefixId.fromNamespaceLabel "https://w3id.org/sri#" "sri"
    static member ssso = PrefixId.fromNamespaceLabel "http://purl.org/ontology/ssso#" "ssso"
    static member st = PrefixId.fromNamespaceLabel "http://semweb.mmlab.be/ns/stoptimes#" "st"
    static member stac = PrefixId.fromNamespaceLabel "http://securitytoolbox.appspot.com/stac#" "stac"
    static member stax = PrefixId.fromNamespaceLabel "https://w3id.org/stax/ontology#" "stax"
    static member step = PrefixId.fromNamespaceLabel "http://purl.org/net/step#" "step"
    static member sto = PrefixId.fromNamespaceLabel "https://w3id.org/i40/sto#" "sto"
    static member stories = PrefixId.fromNamespaceLabel "http://purl.org/ontology/stories/" "stories"
    static member sulo = PrefixId.fromNamespaceLabel "https://w3id.org/sulo/" "sulo"
    static member summa = PrefixId.fromNamespaceLabel "http://purl.org/voc/summa/" "summa"
    static member sur = PrefixId.fromNamespaceLabel "https://w3id.org/survey-ontology#" "sur"
    static member sw_quality = PrefixId.fromNamespaceLabel "https://w3id.org/squap/SoftwareQuality/" "sw-quality"
    static member swc = PrefixId.fromNamespaceLabel "http://data.semanticweb.org/ns/swc/ontology#" "swc"
    static member swemls = PrefixId.fromNamespaceLabel "https://w3id.org/semsys/ns/swemls#" "swemls"
    static member swp = PrefixId.fromNamespaceLabel "http://www.w3.org/2004/03/trix/swp-1/" "swp"
    static member swpm = PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/deployment/swpm/1.0#" "swpm"
    static member swpo = PrefixId.fromNamespaceLabel "http://sw-portal.deri.org/ontologies/swportal#" "swpo"
    static member swrc = PrefixId.fromNamespaceLabel "http://swrc.ontoware.org/ontology#" "swrc"
    static member swrl = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/11/swrl#" "swrl"
    static member synsem = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/synsem#" "synsem"
    static member tac = PrefixId.fromNamespaceLabel "http://ns.bergnet.org/tac/0.1/triple-access-control#" "tac"
    static member tag = PrefixId.fromNamespaceLabel "http://www.holygoat.co.uk/owl/redwood/0.1/tags/" "tag"
    static member tao = PrefixId.fromNamespaceLabel "http://vocab.deri.ie/tao#" "tao"
    static member tax = PrefixId.fromNamespaceLabel "https://w3id.org/EUTaxO#" "tax"
    static member taxon = PrefixId.fromNamespaceLabel "http://purl.org/biodiversity/taxon/" "taxon"
    static member taxref_ld = PrefixId.fromNamespaceLabel "http://taxref.mnhn.fr/lod/" "taxref-ld"
    static member tb = PrefixId.fromNamespaceLabel "https://w3id.org/timebank#" "tb"
    static member td = PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/td#" "td"
    static member tddfa = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododfa#" "tddfa"
    static member tddial = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododial#" "tddial"
    static member tddm = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododm#" "tddm"
    static member tddom = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododom#" "tddom"
    static member tddt = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododt#" "tddt"
    static member tddw = PrefixId.fromNamespaceLabel "https://w3id.org/todo/tododw#" "tddw"
    static member te = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/time-entry#" "te"
    static member teach = PrefixId.fromNamespaceLabel "http://linkedscience.org/teach/ns#" "teach"
    static member tempo = PrefixId.fromNamespaceLabel "http://purl.org/tempo/" "tempo"
    static member test = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/03/test-description#" "test"
    static member theatre = PrefixId.fromNamespaceLabel "http://purl.org/theatre#" "theatre"
    static member thors = PrefixId.fromNamespaceLabel "http://resource.geosciml.org/ontology/timescale/thors#" "thors"
    static member ti = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/timeinterval.owl#" "ti"
    static member tido = PrefixId.fromNamespaceLabel "https://w3id.org/tido#" "tido"
    static member time = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/time#" "time"
    static member tio = PrefixId.fromNamespaceLabel "http://purl.org/tio/ns#" "tio"
    static member tis = PrefixId.fromNamespaceLabel "http://www.ontologydesignpatterns.org/cp/owl/timeindexedsituation.owl" "tis"
    static member tisc = PrefixId.fromNamespaceLabel "http://observedchange.com/tisc/ns#" "tisc"
    static member tl = PrefixId.fromNamespaceLabel "http://purl.org/NET/c4dm/timeline.owl#" "tl"
    static member tm = PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19108/2002/temporal#" "tm"
    static member tmo = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/sw/hcls/ns/transmed/" "tmo"
    static member toco = PrefixId.fromNamespaceLabel "http://purl.org/toco/" "toco"
    static member todo = PrefixId.fromNamespaceLabel "https://w3id.org/todo#" "todo"
    static member topo = PrefixId.fromNamespaceLabel "http://data.ign.fr/def/topo#" "topo"
    static member tosh = PrefixId.fromNamespaceLabel "http://topbraid.org/tosh#" "tosh"
    static member tp = PrefixId.fromNamespaceLabel "http://tour-pedia.org/download/tp.owl#" "tp"
    static member traffic = PrefixId.fromNamespaceLabel "http://www.sensormeasurement.appspot.com/ont/transport/traffic#" "traffic"
    static member trait_ = PrefixId.fromNamespaceLabel "http://contextus.net/ontology/ontomedia/ext/common/trait#" "trait"
    static member transit = PrefixId.fromNamespaceLabel "http://vocab.org/transit/terms/" "transit"
    static member trao = PrefixId.fromNamespaceLabel "http://linkeddata.finki.ukim.mk/lod/ontology/tao#" "trao"
    static member tree = PrefixId.fromNamespaceLabel "https://w3id.org/tree#" "tree"
    static member tresiot = PrefixId.fromNamespaceLabel "https://liidr.org/trust-recommendation-in-social-internet-of-things/" "tresiot"
    static member tribont = PrefixId.fromNamespaceLabel "https://w3id.org/tribont#" "tribont"
    static member tribont_core = PrefixId.fromNamespaceLabel "https://w3id.org/tribont/core#" "tribont-core"
    static member tribont_equipment = PrefixId.fromNamespaceLabel "https://w3id.org/tribont/equipment#" "tribont-equipment"
    static member tribont_material = PrefixId.fromNamespaceLabel "https://w3id.org/tribont/material#" "tribont-material"
    static member tribont_sample = PrefixId.fromNamespaceLabel "https://w3id.org/tribont/sample#" "tribont-sample"
    static member tro = PrefixId.fromNamespaceLabel "https://w3id.org/TRO#" "tro"
    static member trs = PrefixId.fromNamespaceLabel "http://open-services.net/ns/core/trs#" "trs"
    static member trspatch = PrefixId.fromNamespaceLabel "http://open-services.net/ns/core/trspatch#" "trspatch"
    static member tsioc = PrefixId.fromNamespaceLabel "http://rdfs.org/sioc/types#" "tsioc"
    static member tsn = PrefixId.fromNamespaceLabel "http://purl.org/net/tsn#" "tsn"
    static member tsnc = PrefixId.fromNamespaceLabel "http://purl.org/net/tsnchange#" "tsnc"
    static member turismo = PrefixId.fromNamespaceLabel "http://idi.fundacionctic.org/cruzar/turismo#" "turismo"
    static member tvc = PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2012/04/tvc/" "tvc"
    static member txn = PrefixId.fromNamespaceLabel "http://lod.taxonconcept.org/ontology/txn.owl#" "txn"
    static member tzont = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/timezone#" "tzont"
    static member uby = PrefixId.fromNamespaceLabel "http://purl.org/olia/ubyCat.owl#" "uby"
    static member uco = PrefixId.fromNamespaceLabel "http://purl.org/uco/ns#" "uco"
    static member ucum = PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/muo/ucum/" "ucum"
    static member ui = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/ui#" "ui"
    static member uiot = PrefixId.fromNamespaceLabel "http://www.w3id.org/urban-iot/core#" "uiot"
    static member uiote = PrefixId.fromNamespaceLabel "http://www.w3id.org/urban-iot/electric#" "uiote"
    static member umbel = PrefixId.fromNamespaceLabel "http://umbel.org/umbel#" "umbel"
    static member unece = PrefixId.fromNamespaceLabel "http://unece.org/vocab#" "unece"
    static member uneskos = PrefixId.fromNamespaceLabel "http://purl.org/umu/uneskos#" "uneskos"
    static member unicore = PrefixId.fromNamespaceLabel "http://purl.uniprot.org/core/" "unicore"
    static member unit = PrefixId.fromNamespaceLabel "http://qudt.org/vocab/unit/" "unit"
    static member units = PrefixId.fromNamespaceLabel "http://eulersharp.sourceforge.net/2003/03swap/units#" "units"
    static member uri4uri = PrefixId.fromNamespaceLabel "http://uri4uri.net/vocab#" "uri4uri"
    static member usability = PrefixId.fromNamespaceLabel "https://w3id.org/usability#" "usability"
    static member va = PrefixId.fromNamespaceLabel "http://code-research.eu/ontology/visual-analytics#" "va"
    static member vaem = PrefixId.fromNamespaceLabel "http://www.linkedmodel.org/schema/vaem#" "vaem"
    static member vag = PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2013/10/vagueness/" "vag"
    static member vair = PrefixId.fromNamespaceLabel "https://w3id.org/vair#" "vair"
    static member vann = PrefixId.fromNamespaceLabel "http://purl.org/vocab/vann/" "vann"
    static member vartrans = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/lemon/vartrans#" "vartrans"
    static member vas = PrefixId.fromNamespaceLabel "https://robotica.uv.es/proyectos/ASOTVAS/def/ciencia-tecnologia/vas#" "vas"
    static member vcard = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/vcard/ns#" "vcard"
    static member vdpp = PrefixId.fromNamespaceLabel "http://data.lirmm.fr/ontologies/vdpp#" "vdpp"
    static member veo = PrefixId.fromNamespaceLabel "http://linkeddata.finki.ukim.mk/lod/ontology/veo#" "veo"
    static member vf = PrefixId.fromNamespaceLabel "https://w3id.org/valueflows/ont/vf#" "vf"
    static member vgo = PrefixId.fromNamespaceLabel "http://purl.org/net/VideoGameOntology#" "vgo"
    static member vin = PrefixId.fromNamespaceLabel "http://www.w3.org/TR/2003/PR-owl-guide-20031209/wine#" "vin"
    static member vir = PrefixId.fromNamespaceLabel "http://w3id.org/vir#" "vir"
    static member vivo = PrefixId.fromNamespaceLabel "http://vivoweb.org/ontology/core#" "vivo"
    static member vmm = PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/genericTools/vmm/1.0#" "vmm"
    static member voaf = PrefixId.fromNamespaceLabel "http://purl.org/vocommons/voaf#" "voaf"
    static member voag = PrefixId.fromNamespaceLabel "http://voag.linkedmodel.org/voag#" "voag"
    static member vocals = PrefixId.fromNamespaceLabel "http://w3id.org/rsp/vocals#" "vocals"
    static member void_ = PrefixId.fromNamespaceLabel "http://rdfs.org/ns/void#" "void"
    static member voidext = PrefixId.fromNamespaceLabel "http://purl.org/query/voidext#" "voidext"
    static member voidwh = PrefixId.fromNamespaceLabel "http://www.ics.forth.gr/isl/VoIDWarehouse/VoID_Extension_Schema.owl" "voidwh"
    static member vpa = PrefixId.fromNamespaceLabel "https://w3id.org/vpa#" "vpa"
    static member vra = PrefixId.fromNamespaceLabel "http://simile.mit.edu/2003/10/ontologies/vraCore3#" "vra"
    static member vrank = PrefixId.fromNamespaceLabel "http://purl.org/voc/vrank#" "vrank"
    static member vs = PrefixId.fromNamespaceLabel "http://www.w3.org/2003/06/sw-vocab-status/ns#" "vs"
    static member vsearch = PrefixId.fromNamespaceLabel "http://purl.org/vsearch/" "vsearch"
    static member vso = PrefixId.fromNamespaceLabel "http://purl.org/vso/ns#" "vso"
    static member vvo = PrefixId.fromNamespaceLabel "http://purl.org/vvo/ns#" "vvo"
    static member w3c_ssn = PrefixId.fromNamespaceLabel "https://www.w3.org/ns/ssn/" "w3c-ssn"
    static member wai = PrefixId.fromNamespaceLabel "http://purl.org/wai#" "wai"
    static member wdrs = PrefixId.fromNamespaceLabel "http://www.w3.org/2007/05/powder-s#" "wdrs"
    static member wf_invoc = PrefixId.fromNamespaceLabel "http://purl.org/net/wf-invocation#" "wf-invoc"
    static member wfdesc = PrefixId.fromNamespaceLabel "http://purl.org/wf4ever/wfdesc#" "wfdesc"
    static member wfm = PrefixId.fromNamespaceLabel "http://purl.org/net/wf-motifs#" "wfm"
    static member wfont = PrefixId.fromNamespaceLabel "https://w3id.org/wfont#" "wfont"
    static member wfprov = PrefixId.fromNamespaceLabel "http://purl.org/wf4ever/wfprov#" "wfprov"
    static member whisky = PrefixId.fromNamespaceLabel "http://vocab.org/whisky/terms/" "whisky"
    static member whois = PrefixId.fromNamespaceLabel "http://www.kanzaki.com/ns/whois#" "whois"
    static member wi = PrefixId.fromNamespaceLabel "http://purl.org/ontology/wi/core#" "wi"
    static member wikibase = PrefixId.fromNamespaceLabel "http://wikiba.se/ontology#" "wikibase"
    static member wikim = PrefixId.fromNamespaceLabel "http://spi-fm.uca.es/spdef/models/genericTools/wikim/1.0#" "wikim"
    static member wl = PrefixId.fromNamespaceLabel "http://www.wsmo.org/ns/wsmo-lite#" "wl"
    static member wlo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/wo/" "wlo"
    static member wn20schema = PrefixId.fromNamespaceLabel "http://www.w3.org/2006/03/wn/wn20/schema/" "wn20schema"
    static member wo = PrefixId.fromNamespaceLabel "http://purl.org/ontology/wo/core#" "wo"
    static member wot = PrefixId.fromNamespaceLabel "http://xmlns.com/wot/0.1/" "wot"
    static member wotsec = PrefixId.fromNamespaceLabel "https://www.w3.org/2019/wot/security#" "wotsec"
    static member ws = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/pim/space#" "ws"
    static member wty = PrefixId.fromNamespaceLabel "https://ns.verisav.fr/wty#" "wty"
    static member xapi = PrefixId.fromNamespaceLabel "http://purl.org/xapi/ontology#" "xapi"
    static member xbrll = PrefixId.fromNamespaceLabel "https://w3id.org/vocab/xbrll#" "xbrll"
    static member xhv = PrefixId.fromNamespaceLabel "http://www.w3.org/1999/xhtml/vocab#" "xhv"
    static member xkos = PrefixId.fromNamespaceLabel "http://rdf-vocabulary.ddialliance.org/xkos#" "xkos"
    static member xls2rdf = PrefixId.fromNamespaceLabel "https://xls2rdf.sparna.fr/vocabulary#" "xls2rdf"
    static member xml = PrefixId.fromNamespaceLabel "http://www.w3.org/XML/1998/namespace" "xml"
    static member xsd = PrefixId.fromNamespaceLabel "http://www.w3.org/2001/XMLSchema#" "xsd"
    static member yoga = PrefixId.fromNamespaceLabel "https://yogaontology.org/ontology/" "yoga"
    static member zbwext = PrefixId.fromNamespaceLabel "http://zbw.eu/namespaces/zbw-extensions/" "zbwext"
