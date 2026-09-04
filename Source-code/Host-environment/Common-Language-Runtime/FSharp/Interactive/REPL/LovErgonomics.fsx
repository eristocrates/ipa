# time on
fsi.ShowDeclarationValues <- false

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "UrlErgonomics.dll"
open UrlErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "SparqlErgonomics.dll"
open SparqlErgonomics
#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\Namespace\Generated"
#r "rdfNamespace.dll"

open RdfNamespace
#r "voafNamespace.dll"
open VoafNamespace
#r "vannNamespace.dll"

open VannNamespace




open System
open System.Linq
open System.Text
open System.Text.RegularExpressions
open System.IO
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Handlers
open System.IO.Compression
open Dubzer.WhatwgUrl
open FSharp.Data
open VDS.RDF
open FolkerKinzel.MimeTypes
open IriTools
open RDFSharp.Model



let private utf8 =
    UTF8Encoding(encoderShouldEmitUTF8Identifier = false, throwOnInvalidBytes = true)


let private escapedSurrogatePair =
    Regex(
        @"\\u([dD][89aAbB][0-9a-fA-F]{2})\\u([dD][c-fC-F][0-9a-fA-F]{2})",
        RegexOptions.Compiled
        ||| RegexOptions.CultureInvariant
    )


let normalizeEscapedSurrogatePairs (text: string) =
    if text.IndexOf(@"\uD", StringComparison.OrdinalIgnoreCase) < 0 then
        text
    else
        escapedSurrogatePair.Replace(
            text,
            MatchEvaluator (fun matched ->
                let high =
                    Convert.ToInt32(matched.Groups.[1].Value, 16)
                    |> char

                let low =
                    Convert.ToInt32(matched.Groups.[2].Value, 16)
                    |> char

                Char.ConvertToUtf32(high, low)
                |> sprintf "\\U%08X")
        )


let decompressNqGzipFile (nqgzipFile: FileInfo) =

    if not (File.Exists nqgzipFile.FullName) then
        raise (FileNotFoundException("The N-Quads gzip file does not exist.", nqgzipFile.FullName))

    if not (nqgzipFile.Name.EndsWith(".nq.gz", StringComparison.OrdinalIgnoreCase)) then
        invalidArg (nameof nqgzipFile) $"Expected an .nq.gz file, received {nqgzipFile.Name}."

    // Removes only the final ".gz":
    // foo.nq.gz -> foo.nq
    let nqFile =
        Path.ChangeExtension(nqgzipFile.FullName, null)
        |> FileInfo

    // Do not expose a partially-written "clean" .nq file.
    let temporaryFile =
        Path.Combine(nqFile.DirectoryName, Path.GetRandomFileName())
        |> FileInfo

    let parser = NQuadsParser()
    let handler = NullHandler()

    let mutable kept = 0L
    let mutable rejected = 0L
    let mutable repaired = 0L

    try
        do
            use sourceStream = nqgzipFile.OpenRead()

            use gzipStream = new GZipStream(sourceStream, CompressionMode.Decompress)

            use reader =
                new StreamReader(gzipStream, utf8, detectEncodingFromByteOrderMarks = true)

            use writer =
                new StreamWriter(temporaryFile.FullName, append = false, encoding = utf8)

            while not reader.EndOfStream do
                let line = reader.ReadLine()

                if not (String.IsNullOrWhiteSpace line) then
                    let normalizedLine = normalizeEscapedSurrogatePairs line

                    if
                        not (Object.ReferenceEquals(normalizedLine, line))
                        && normalizedLine <> line
                    then
                        repaired <- repaired + 1L

                    try
                        use lineReader = new StringReader(normalizedLine)

                        parser.Load(handler, lineReader)

                        writer.WriteLine(normalizedLine)
                        kept <- kept + 1L

                    with
                    | :? RdfParseException -> rejected <- rejected + 1L

        File.Move(temporaryFile.FullName, nqFile.FullName, overwrite = true)

        File.Delete(nqgzipFile.FullName)

        printfn
            "Created %s — kept %i statements; repaired %i lines; rejected %i invalid statements."
            nqFile.FullName
            kept
            repaired
            rejected

        FileInfo(nqFile.FullName)

    with
    | _ ->
        if File.Exists temporaryFile.FullName then
            File.Delete temporaryFile.FullName

        reraise ()

let decompressGz (sourceFile: FileInfo) =
    let targetFile =
        sourceFile.FullName[.. sourceFile.FullName.Length - 4]
        |> FileInfo
    // Open the compressed file stream
    use sourceStream =
        new FileStream(sourceFile.FullName, FileMode.Open, FileAccess.Read)

    // Create the decompression stream
    use decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress)

    // Create the destination file stream
    use targetStream =
        new FileStream(targetFile.FullName, FileMode.Create, FileAccess.Write)

    // Copy the decompressed data to the target file
    decompressionStream.CopyTo(targetStream)
    targetFile















[<RequireQualifiedAccess>]
type LovTermType =
    | ``class``
    | property
    | datatype
    | instance

type LovApiTermSearchParameters =
    { /// Full text query.
      q: string
      /// Maximum number of results to return per page (default: 10).
      page_size: int option
      /// Result page to display starting from 1 (default: 1).
      page: int option
      /// Filter query results based on their type. Possible values: [class, propery, datatype, instance]. Multiple values allowed (use coma without space to seperate them).
      types: LovTermType array
      /// Filter query results based on the vocabulary it belongs to (e.g. "foaf"). Expecting only one value.
      vocab: string
      /// Number of elements to display in the vocabulary facet (default: 10).
      vocab_limit: int option
      /// Filter query results based on their tag (e.g. "event"). Multiple values allowed, use coma as a separator (e.g. "event,time").
      tags: string array
      /// Number of elements to display in the tag facet (default: 10).
      tag_limit: int option }

[<Literal>]
let termSearchFilePath =
    @"D:\Iri\https\lov.linkeddata.es\dataset\api\v2\term\search&quest;q=sample.json"

type TermSearchProvider =
    JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="result", Sample=termSearchFilePath>

[<Literal>]
let vocabSearchFilePath =
    @"D:\Iri\https\lov.linkeddata.es\dataset\api\v2\vocabulary\search&quest;q=http%3A%2F%2Fwww.w3.json"

type VocabSearchProvider =
    JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="result", Sample=vocabSearchFilePath>

let lovBase = DomUrl "https://lov.linkeddata.es/dataset/api/v2"

let LovSearchTerm (term: string) =
    use browser = CdpBrowser.Connect()

    let domUrl =
        lovBase.AppendPath "term/search"
        |> DomUrl.AddQueryParameter "q" term

    browser
    |> CdpBrowser.DownloadTextExtension domUrl ".json"

    TermSearchProvider.Load (domUrl.asFileExtension ".json").FullName

let LovSearchVocab (vocab: string) =
    use browser = CdpBrowser.Connect()

    let domUrl =
        lovBase.AppendPath "vocabulary/search"
        |> DomUrl.AddQueryParameter "q" vocab

    browser
    |> CdpBrowser.DownloadTextExtension domUrl ".json"

    VocabSearchProvider.Load (domUrl.asFileExtension ".json").FullName

let n3gzDataDump = DomUrl "https://lov.linkeddata.es/lov.n3.gz"
// n3gzDataDump.HeadlessDownloadFile()
let nqgzDataDump = DomUrl "https://lov.linkeddata.es/lov.nq.gz"
// nqgzDataDump.HeadlessDownloadFile()


module LovKeyword =
    let API = RdfLiteral.simple "API"
    let Academy = RdfLiteral.simple "Academy"
    let Biology = RdfLiteral.simple "Biology"
    let CSV = RdfLiteral.simple "CSV"
    let Catalogs = RdfLiteral.simple "Catalogs"
    let Contracts = RdfLiteral.simple "Contracts"
    let Environment = RdfLiteral.simple "Environment"
    let Events = RdfLiteral.simple "Events"
    let FRBR = RdfLiteral.simple "FRBR"
    let Food = RdfLiteral.simple "Food"
    let Games = RdfLiteral.simple "Games"
    let General_and_Upper = RdfLiteral.simple "General & Upper"
    let Geography = RdfLiteral.simple "Geography"
    let Geometry = RdfLiteral.simple "Geometry"
    let Government = RdfLiteral.simple "Government"
    let Health = RdfLiteral.simple "Health"
    let Image = RdfLiteral.simple "Image"
    let Industry = RdfLiteral.simple "Industry"
    let IoT = RdfLiteral.simple "IoT"
    let Metadata = RdfLiteral.simple "Metadata"
    let Methods = RdfLiteral.simple "Methods"
    let Multimedia = RdfLiteral.simple "Multimedia"
    let Music = RdfLiteral.simple "Music"
    let PLM = RdfLiteral.simple "PLM"
    let PROTON = RdfLiteral.simple "PROTON"
    let People = RdfLiteral.simple "People"
    let Press = RdfLiteral.simple "Press"
    let Quality = RdfLiteral.simple "Quality"
    let RDF = RdfLiteral.simple "RDF"
    let Rec = RdfLiteral.simple "Rec"
    let SPAR = RdfLiteral.simple "SPAR"
    let SSDesk = RdfLiteral.simple "SSDesk"
    let Security = RdfLiteral.simple "Security"
    let Services = RdfLiteral.simple "Services"
    let Society = RdfLiteral.simple "Society"
    let Support = RdfLiteral.simple "Support"
    let Tag = RdfLiteral.simple "Tag"
    let Time = RdfLiteral.simple "Time"
    let Transport = RdfLiteral.simple "Transport"
    let Travel = RdfLiteral.simple "Travel"
    let Vocabularies = RdfLiteral.simple "Vocabularies"
    let W3CRec = RdfLiteral.simple "W3CRec"
    let eBusiness = RdfLiteral.simple "eBusiness"

































let lov_n3 = { graphFile = FileInfo @"D:\Iri\https\lov.linkeddata.es\lov.n3" }
let lov_nq = { datasetFile = FileInfo @"D:\Iri\https\lov.linkeddata.es\lov.nq" }
let lovDataset = lov_nq.asInMemoryQuadDataset
let lov_sparql = DomUrl "https://lov.linkeddata.es/dataset/lov/sparql"







let s = !? "s"
let p = !? "p"
let o = !? "o"

let vocabularyIri = !? "vocabularyIri"
let preferredNamespaceUri = !? "preferredNamespaceUri"
let preferredNamespacePrefix = !? "preferredNamespacePrefix"


let selectVariables =
    [ vocabularyIri
      preferredNamespaceUri
      preferredNamespacePrefix ]

let a = rdf.type_

let vocabularyQuery =

    sparql.select selectVariables {
        where (
            !>vocabularyIri
            -~|> [ a ->- voaf.Vocabulary
                   vann.preferredNamespacePrefix
                   ->- preferredNamespacePrefix
                   vann.preferredNamespaceUri
                   ->- preferredNamespaceUri ]

        )
    }
    |> lov_n3.asSparqlLocalDataset.query


type LovVocabulary =
    { vocabularyIri: Iri
      vocabularyPrefix: RdfLiteral
      vocabularyNamespace: RdfLiteral }
    member this.namespaceUrl = DomUrl this.vocabularyNamespace.lexicalForm
    member this.graphName = this.vocabularyIri.asUriNode :> IRefNode
    member this.asIGraph = lovDataset[this.graphName]

    member this.tryIGraph =
        if lovDataset.HasGraph this.graphName then
            printfn "Loading %s from lov.nq" this.vocabularyIri.lexicalForm
            Some lovDataset[this.graphName]
        else
            printfn "%s not found in lov.nq" this.vocabularyIri.lexicalForm
            None

    member this.asFileExtension(dotExtension: string) =
        let mimeType = MimeType.FromFileName(dotExtension)

        Path.Combine(this.namespaceUrl.asFolder.FullName, mimeType.MediaType, $"{mimeType.SubType}{dotExtension}")
        |> FileInfo

    member this.namespaceIri =
        IriReference this.vocabularyNamespace.lexicalForm
        |> IRIREF

    member this.asPrefixId =
        PrefixId.fromNamespaceLabel this.vocabularyNamespace.lexicalForm this.vocabularyPrefix.lexicalForm

    member this.ttlFile = this.asFileExtension ".ttl"

    member this.tryGraphDocument =
        let ttlFile = this.ttlFile

        match ttlFile.Exists, this.tryIGraph with
        | false, Some igraph ->
            printfn
                "writing %s to  %s"
                this.vocabularyIri.lexicalForm
                (Path.Combine(ttlFile.DirectoryName, $"{ttlFile.stem}.ttl"))

            igraph
            |> Turtle.writeIgraph ttlFile.DirectoryName ttlFile.stem

            Some { graphFile = ttlFile }
        | true, _ -> Some { graphFile = ttlFile }
        | _, _ -> None

    member this.asRdfGraphDocument =
        let ttlFile = this.ttlFile

        if not (ttlFile.Exists) then
            this.asIGraph
            |> Turtle.writeIgraph this.ttlFile.DirectoryName this.ttlFile.stem

        { graphFile = ttlFile }

    member this.tryRdfVocabulary =
        match this.tryGraphDocument with
        | Some document ->
            Some
                { prefixId = this.asPrefixId
                  namespaceDocument = document }
        | None -> None

    member this.asRdfVocabulary =
        { prefixId = this.asPrefixId
          namespaceDocument = this.asRdfGraphDocument }

let lovVocabularies =
    [|

       for index = 0 to vocabularyQuery.Count() - 1 do
           let (IriPoint vocabIri) =
               vocabularyQuery
               |> SparqlResultSet.variableIndex vocabularyIri index

           let (LiteralPoint prefixLabel) =
               vocabularyQuery
               |> SparqlResultSet.variableIndex preferredNamespacePrefix index

           let (LiteralPoint namespaceUri) =
               vocabularyQuery
               |> SparqlResultSet.variableIndex preferredNamespaceUri index

           { vocabularyIri = vocabIri
             vocabularyPrefix = prefixLabel
             vocabularyNamespace = namespaceUri

           }

       |]

let lovVocabularyMap =
    Array.concat [| lovVocabularies
                    |> Array.map (fun vocabulary -> vocabulary.vocabularyNamespace.lexicalForm, vocabulary)
                    lovVocabularies
                    |> Array.map (fun vocabulary -> vocabulary.vocabularyIri.lexicalForm, vocabulary) |]
    |> Array.distinctBy (fun (vocabularyKey, _) -> vocabularyKey)
    |> Map.ofArray

type RDFNamespaceRegister with
    static member rdfNamespaces =
        RDFNamespaceRegister.Instance
        |> Seq.cast<RDFNamespace>
        |> Seq.toArray

    static member hasPrefixRegistered(prefix: string) =
        RDFNamespaceRegister.rdfNamespaces
        |> Array.exists (fun rdfNamespace -> rdfNamespace.NamespacePrefix = prefix)

    static member hasNamespaceNameRegistered(namespaceName: string) =
        RDFNamespaceRegister.rdfNamespaces
        |> Array.exists (fun rdfNamespace -> rdfNamespace.NamespaceUri.OriginalString = namespaceName)

    static member maybePrefixIdCollision(prefixId: PrefixId) =
        match RDFNamespaceRegister.GetByPrefix prefixId.prefixLabel,
              RDFNamespaceRegister.GetByUri prefixId.namespaceName
            with
        | namespaceFromPrefix, namespaceFromName when
            prefixId.asRDFNamespace = namespaceFromPrefix
            && prefixId.asRDFNamespace = namespaceFromName
            ->
            None
        | namespaceFromPrefix, namespaceFromName -> Some(namespaceFromPrefix, namespaceFromName)

    static member lovVocabularyNamespaces =
        RDFNamespaceRegister.rdfNamespaces
        |> Array.choose (fun rdfNamespace -> lovVocabularyMap.TryFind rdfNamespace.NamespaceUri.OriginalString)



let lovNamespaces =
    lovVocabularies
    |> Array.choose (fun vocabulary -> vocabulary.tryRdfVocabulary)
    |> Array.sortBy (fun lovNamespace -> lovNamespace.namespaceDocument.graphFile.Length)

let lovNamespacesByPrefix  =
    lovNamespaces |> Array.groupBy (fun lovNamespace -> lovNamespace.prefixId.prefixLabel )

let singletonPrefixedNamespaces = 
    lovNamespacesByPrefix |> Array.choose (fun (prefix, lovNamespaces) -> 
        if lovNamespaces.Length = 1 then 
            Some lovNamespaces[0]
        else 
            None
        
        )


let multitonPrefixedNamespaces = 
    lovNamespacesByPrefix |> Array.filter (fun (prefix, lovNamespaces) ->  lovNamespaces.Length > 1 )




let start = 800
let stop = 899

let job =
    System.Threading.Tasks.Task.Run(fun () ->
        lovNamespaces[start..stop]
        |> Array.sortBy (fun lovNamespace ->
            lovNamespace.namespaceDocument.graphFile.Length
        )
        |> Array.iteri (fun index lovNamespace ->
            if not lovNamespace.fsxFile.Exists then
                printfn "%d of %d %s"
                    (start + index)
                    stop
                    lovNamespace.prefixId.namespaceName

                RdfVocabulary.asModule lovNamespace
                |> fun fsxText ->
                    File.WriteAllText(
                        lovNamespace.fsxFile.FullName,
                        fsxText
                    )
        )
    )








(*

let lovNamespaceMap =
    lovNamespaces
    |> Array.map (fun lovNamespace -> lovNamespace.prefixId.namespaceName, lovNamespace)
    |> Map.ofArray

let targetNamespaceNames =
    [| "http://www.w3.org/1999/02/22-rdf-syntax-ns#"
       "http://www.w3.org/2000/01/rdf-schema#"
       "http://www.w3.org/2002/07/owl#"
       "http://www.w3.org/2001/XMLSchema#"
       "http://www.w3.org/2001/XMLSchema-instance#"
       "https://www.w3.org/2003/05/xpath-datatypes#"
       "http://www.w3.org/2006/time#"
       "http://purl.org/vocab/vann/"
       "http://xmlns.com/foaf/0.1/"
       "http://www.w3.org/2003/06/sw-vocab-status/ns#"
       "http://www.w3.org/ns/hydra/core#"
       "http://rdfs.org/ns/void#"
       "http://www.linkedmodel.org/schema/vaem#"
       "http://purl.org/vocommons/voaf#"
       "http://purl.org/dc/terms/"
       "http://www.w3.org/ns/dcat#" |]

let missingNamespaceNames =
    targetNamespaceNames
    |> Array.filter (fun namespaceName ->
        match lovNamespaceMap.TryFind namespaceName with
        | Some _ -> false
        | _ -> true)

targetNamespaceNames
|> Array.choose (fun namespaceName -> lovNamespaceMap.TryFind namespaceName)
|> Array.filter (fun vocabulary -> vocabulary.namespaceDocument.graphFile.Exists)
|> Array.map (fun vocabulary ->
    $"let {vocabulary.prefixId.prefixLabel}Vocabulary = PrefixId.fromNamespaceLabel \"{vocabulary.prefixId.namespaceName}\" \"{vocabulary.prefixId.prefixLabel}\" |> RdfVocabulary.fromPrefixId  ")
|> String.concat "\n"
|> clip

targetNamespaceNames
|> Array.choose (fun namespaceName -> lovNamespaceMap.TryFind namespaceName)
|> Array.filter (fun vocabulary -> vocabulary.namespaceDocument.graphFile.Exists)
|> Array.sortBy (fun vocabulary -> vocabulary.prefixId.prefixLabel)
|> Array.map (fun vocabulary -> RdfVocabulary.asModule vocabulary)
|> String.concat "\n\n\n"
|> fun namespaceText ->
    File.WriteAllText(
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\VocabularyModules.txt",
        namespaceText
    )
*)
