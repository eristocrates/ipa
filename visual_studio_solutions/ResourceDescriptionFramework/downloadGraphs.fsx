#r @"C:\Repositories\eristocrates\ipa\visual_studio_solutions\shared_kernel\bin\Debug\net10.0\shared_kernel.dll"
#r "nuget: dotNetRdf"
#r "nuget: FsHttp"
#load "IriPathing.fsx"

open System
open System.IO
open System.Threading.Tasks

open FsHttp
open VDS.RDF
open VDS.RDF.Parsing

open SharedKernel
let generatedOutputDirectoryPath = @"C:\Repositories\eristocrates\ipa\visual_studio_solutions\ResourceDescriptionFramework\Vocabulary\Generated"
type VocabularyNamespace =
  {

    namespaceUriString: string
    remoteFileUriString: string
    namespacePrefixLabel: string

   }
  member this.localFileUriString = IriPathing.iriToRelativePath this.remoteFileUriString

let vocabularyNamespaces =
  [

    {

      namespaceUriString = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
      remoteFileUriString = "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
      namespacePrefixLabel = "rdf"

    }


    ]
let problemHosts = Set.ofList [
    "id.loc.gov"
    "www.w3.org"
    "gitlab.gnome.org"
    "semiceu.github.io"
    "ns.ottr.xyz"
    "spec.ottr.xyz"
    "rdfs.org"
]
  

type Failure =
    { namespaceUriString: string
      stage: string
      exceptionText: string
      httpStatus: int option
      httpMediaType: string option
      dereferencedUrl: string option
      contentSnippet: string option
      attempts: string list option }

type Outcome<'a> = Result<'a, Failure>


type LoadAttempt = { attemptName: string; attemptExecution: unit -> IGraph } // returns a graph or throws

let extensionHint (u: Uri) : string option =
    let path = u.AbsolutePath
    let i = path.LastIndexOf('.')

    if i >= 0 && i < path.Length - 1 then
        Some(path.Substring(i + 1).ToLowerInvariant())
    else
        None

let private parseGraphFromStringWithReader (content: string) (reader: IRdfReader) : IGraph =
    let g = new Graph()
    g.LoadFromString(content, reader)
    g :> IGraph

let private parseGraphFromStringWithStoreReader (content: string) (reader: IStoreReader) : IGraph =
    let store = new TripleStore()
    use sr = new StringReader(content)
    reader.Load(store, sr)
    let g = new Graph()

    for sg in store.Graphs do
        g.Merge(sg, true)

    g :> IGraph

let private tryParseJsonLdIntoGraph (content: string) : IGraph =
    // dotNetRDF version variance:
    // - Some builds: JsonLdParser : IRdfReader
    // - Some builds: JsonLdParser : IStoreReader (or only store-capable)
    //
    // We runtime-dispatch.

    let p = JsonLdParser()

    match box p with
    | :? IRdfReader as r -> parseGraphFromStringWithReader content r
    | :? IStoreReader as sr -> parseGraphFromStringWithStoreReader content sr
    | _ -> failwith "JsonLdParser exists but implements neither IRdfReader nor IStoreReader in this build."
let attemptFetchThenParse (namespaceUriString: string) (uri: Uri) : LoadAttempt =
    { attemptName = "Fetch+Parse (auto by Content-Type)"
      attemptExecution =
        fun () ->
            let response = // probeWithHeaders uri.OriginalString |> result
                http {
                    GET uri.OriginalString
                    UserAgent "Mozilla/5.0"
                    header "Accept" "text/turtle, application/n-triples, application/rdf+xml, application/trig, application/n-quads, application/ld+json, text/plain;q=0.8, */*;q=0.1"
                }
                |> Request.send
                |> Response.assert2xx
                |> Response.asOriginalHttpResponseMessage


            let ct = response.Content.Headers.ContentType

            let mediaType =
                if isNull ct then
                    None
                else
                    Some ct.MediaType

            let characterSet =
                if isNull ct then
                    None
                else
                    Some ct.CharSet
            let content = response.Content.ReadAsStringAsync() |> Async.AwaitTask |> Async.RunSynchronously
            let mt = mediaType |> Option.map (fun s -> s.Trim().ToLowerInvariant())
            let sniff =  content |> Seq.tryFind (fun c -> not (Char.IsWhiteSpace c))

            // Primary decision: Content-Type
            // Secondary decision: trivial sniff
            match mt, sniff with
            | Some ct, _ when
                ct.Contains("text/turtle")
                || ct.Contains("application/turtle")
                || ct.Contains("text/n3")
                ->
                parseGraphFromStringWithReader content (TurtleParser() :> IRdfReader)

            | Some ct, _ when
                ct.Contains("application/rdf+xml")
                || ct.Contains("application/xml")
                || ct.Contains("text/xml")
                ->
                parseGraphFromStringWithReader content (RdfXmlParser() :> IRdfReader)

            | Some ct, _ when ct.Contains("application/n-triples") ->
                parseGraphFromStringWithReader content (NTriplesParser() :> IRdfReader)

            | Some ct, _ when ct.Contains("application/trig") ->
                parseGraphFromStringWithStoreReader content (TriGParser() :> IStoreReader)

            | Some ct, _ when ct.Contains("application/n-quads") ->
                parseGraphFromStringWithStoreReader content (NQuadsParser() :> IStoreReader)

            | Some ct, _ when
                ct.Contains("application/ld+json")
                || ct.Contains("application/json")
                || ct.Contains("text/json")
                ->
                tryParseJsonLdIntoGraph content

            // If Content-Type is missing or useless: sniff
            | _, Some '{' ->
                // almost certainly JSON / JSON-LD
                tryParseJsonLdIntoGraph content

            | _, Some '<' ->
                // probably RDF/XML (or HTML). Try RDF/XML first, then Turtle.
                try
                    parseGraphFromStringWithReader content (RdfXmlParser() :> IRdfReader)
                with
                | _ -> parseGraphFromStringWithReader content (TurtleParser() :> IRdfReader)

            | _ ->
                // last resort: Turtle then RDF/XML
                try
                    parseGraphFromStringWithReader content (TurtleParser() :> IRdfReader)
                with
                | _ -> parseGraphFromStringWithReader content (RdfXmlParser() :> IRdfReader) }
let private attemptGraph (namespaceUri:Uri) (distributionUri: Uri) (attemptName: string) (reader: IRdfReader) : LoadAttempt =
    { attemptName = attemptName
      attemptExecution =
        fun () ->
            let g = new Graph(namespaceUri)
            g.LoadFromUri(distributionUri, reader)
            g :> IGraph }

let private attemptStore (namespaceUri:Uri) (distributionUri: Uri) (attemptName: string) (reader: IStoreReader) : LoadAttempt =
    { attemptName = attemptName
      attemptExecution =
        fun () ->
            let store = new TripleStore()
            store.LoadFromUri(distributionUri, reader)
            let g = new Graph(namespaceUri)

            for sg in store.Graphs do
                g.Merge(sg, true)

            g :> IGraph }

let private attemptDefaultGraphLoad (namespaceUri:Uri) (distributionUri: Uri) : LoadAttempt =
    { attemptName = "Graph.LoadFromUri (default)"
      attemptExecution =
        fun () ->
            let g = new Graph()
            g.LoadFromUri(distributionUri)
            g :> IGraph }
let  attemptsFor (namespaceUriString: string) (distributionUri: Uri) : LoadAttempt list =
    let namespaceUri = UriFactory.Create(namespaceUriString)
    let baseAttempts =
        match extensionHint distributionUri with
        | Some "ttl"
        | Some "ontology"
        | Some "turtle"
        | Some "n3" ->
            [ attemptGraph namespaceUri  distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "rdf"
        | Some "xml"
        | Some "owl" ->
            [ attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "trig" ->
            [ attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "nq" ->
            [ attemptStore namespaceUri distributionUri "NQuadsParser" (NQuadsParser() :> IStoreReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]
        | Some "jsonld"
        | Some "json" ->
            [ attemptDefaultGraphLoad namespaceUri distributionUri
              attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader) ]
        | _ ->
            [ attemptGraph namespaceUri distributionUri "TurtleParser" (TurtleParser() :> IRdfReader)
              attemptGraph namespaceUri distributionUri "RdfXmlParser" (RdfXmlParser() :> IRdfReader)
              attemptStore namespaceUri distributionUri "TriGParser" (TriGParser() :> IStoreReader)
              attemptDefaultGraphLoad namespaceUri distributionUri ]

    if problemHosts.Contains distributionUri.Host then
        // Inject the auto fetch+parse attempt FIRST.
        (attemptFetchThenParse namespaceUriString distributionUri)
        :: baseAttempts
    else
        baseAttempts

let loadGraphFromUriWithFallback (namespaceUriString: string) (distributionUri: Uri) : Outcome<IGraph> =

    let attemptsTried = ResizeArray<string>()

    let rec loopLoadAttempts (loadAttemptList: LoadAttempt list) : Outcome<IGraph> =
        match loadAttemptList with
        | [] ->
            Error
                { namespaceUriString = namespaceUriString
                  stage = "loadGraphFromUriWithFallback"
                  exceptionText = "All attempts failed."
                  httpStatus = None
                  httpMediaType = None
                  dereferencedUrl = Some distributionUri.OriginalString
                  contentSnippet = None
                  attempts = Some(attemptsTried |> Seq.toList) }
        | currentAttempt :: attemptList ->
            attemptsTried.Add currentAttempt.attemptName

            try
                Ok(currentAttempt.attemptExecution ())
            with
            | currentAttemptException ->
                match loopLoadAttempts attemptList with
                | Ok graphFromSuccessfulAttempt -> Ok graphFromSuccessfulAttempt
                | Error failedAttempt -> Error { failedAttempt with exceptionText = currentAttemptException.ToString() }

    try
        loopLoadAttempts (attemptsFor namespaceUriString distributionUri)

    with
    | loadGraphException ->
        Error
            { namespaceUriString = namespaceUriString
              stage = "loadGraphFromUriWithFallback"
              exceptionText = loadGraphException.ToString()
              httpStatus = None
              httpMediaType = None
              dereferencedUrl = Some distributionUri.OriginalString
              contentSnippet = None
              attempts = Some(attemptsTried |> Seq.toList) }
let codegenOutcomes = 
  vocabularyNamespaces
  |> List.map (fun vocabulary ->

      let moduleBasename =  vocabulary.namespacePrefixLabel
      Console.WriteLine moduleBasename
      let moduleParentDirectory = Ensure.path ( Path.Combine(generatedOutputDirectoryPath, vocabulary.localFileUriString))
      let moduleFilePath = Path.Combine(moduleParentDirectory, $"{moduleBasename}.fs")

      let distributionGraphUri = UriFactory.Create vocabulary.remoteFileUriString

      match loadGraphFromUriWithFallback vocabulary.namespaceUriString distributionGraphUri with
      | Error f -> Error { f with stage = "codegenFromNamespaceIris:loadGraphFromUriWithFallback" }

      | Ok unnamedDistributionGraph ->

          let vocabularyUri = UriFactory.Create vocabulary.remoteFileUriString
          let vocabularyNode = new UriNode(vocabularyUri)
          let vocabularyGraph = new ThreadSafeGraph(vocabularyNode)
          vocabularyGraph.Merge unnamedDistributionGraph
          let graphParentDirectory =  Ensure.path (Path.Combine(generatedOutputDirectoryPath,vocabulary.localFileUriString ))
          let graphFilePath = Path.Combine(graphParentDirectory, moduleBasename)
          vocabularyGraph.NamespaceMap.AddNamespace(vocabulary.namespacePrefixLabel, vocabularyUri)
          // TODO remove old templating
          // TODO figure out how to go from trimmed vocabulary to nomed graph
          let distributionNamedGraph =
                      NamedGraph.fromIGraph
                          namespaceIri
                          graphFilePath
                          distributionGraph
       
          
          GraphRuntime.Serialization.Turtle.save distributionNamedGraph
          try
              let namespacePrefixRaw = vocabulary._namespacePrefix.Value

              let cleanNamespace  = cleanNamespace namespacePrefixRaw

              let renderedTrie =
                  renderNameTrie
                      namespaceIri._namespaceUri.OriginalString
                      namespaceIri._distributionUriString
                      namespaceIri._namespacePrefix.Value
                      (buildTrie (localNamesFrom namespaceIri distributionGraph))
              let cleanModule = getLastSegment cleanNamespace '.'
              let templateContent =
                  $"""
namespace {capitalizeFirst cleanNamespace}.Namespace
module {cleanModule} =
let {namespaceBindingString} = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant "{vocabulary._namespaceUri.OriginalString}" {renderStringOption namespaceIri._distributionUriString} {renderStringOption namespaceIri._namespacePrefix} None
{renderedTrie}
                  """
                      .TrimStart()
                      .TrimEnd()

              Artifact.saveToFile moduleFilePath templateContent
              Ok moduleFilePath
          with
          | ex ->
              Error
                  { namespaceUriString = vocabulary._namespaceUri.OriginalString
                    stage = "codegenFromNamespaceIris:templateOrWrite"
                    exceptionText = ex.ToString()
                    httpStatus = None
                    httpMediaType = None
                    dereferencedUrl = vocabulary._distributionUriString
                    contentSnippet = None
                    attempts = None })


let failures =
    codegenOutcomes
    |> List.choose (function
        | Error f -> Some f
        | Ok _ -> None)

if not failures.IsEmpty then
    let report =
        failures
        |> List.map (fun f ->
            $"""FAIL ({f.stage})
  namespaceUriString: {f.namespaceUriString}
  dereferencedUrl: {defaultArg f.dereferencedUrl "<none>"}
  httpStatus: {f.httpStatus
               |> Option.map string
               |> Option.defaultValue "<none>"}
  httpMediaType: {defaultArg f.httpMediaType "<none>"}
  attempts: {f.attempts
             |> Option.map (String.concat ", ")
             |> Option.defaultValue "<none>"}
{f.exceptionText}
{f.contentSnippet |> Option.defaultValue ""}
            """)
        |> String.concat "\n"

    File.WriteAllText(
        @"C:\Repositories\eristocrates\ipa\visual_studio_solutions\ResourceDescriptionFramework\Artifact\CodegenFailures.txt",
        report
    )
