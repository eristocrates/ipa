#r @"C:\Repositories\ipa\visual_studio_solutions\shared_kernel\bin\Debug\net10.0\shared_kernel.dll"
#r "nuget: dotNetRdf"
#r "nuget: Iride"
#r "nuget: Fantomas.Core"
#r "nuget: Fabulous.AST"
#r "nuget: Fantomas.FCS"

open System
open System.IO
open VDS.RDF
open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Ontology
open Fabulous.AST
open Fantomas.FCS.Text

open type Fabulous.AST.Ast

let ontologyGraph = new OntologyGraph()
let loader = new Loader()
let distributionUriString = "https://www.w3.org/1999/02/22-rdf-syntax-ns#"
let distributionUri = UriFactory.Create distributionUriString
loader.LoadGraph(ontologyGraph, distributionUri)

let classTestContent =
    ontologyGraph.AllClasses
    |> Seq.map (fun ontologyClass -> ontologyClass.Resource.ToString())

let testInputFilePath =
    @"C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework\test.ttl"

let textReader =
    ParsingTextReader.Create(File.Open(testInputFilePath, FileMode.Open))

let turtleTokeniser = new TurtleTokeniser(textReader)
let tokenQueue = new AsynchronousBufferedTokenQueue(turtleTokeniser)
tokenQueue.InitialiseBuffer()












let outputDirectory = "Artifact"

let testOutputFilePath =
    @"C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework\test.txt"

let tokenTestOutputFilePath =
    @"C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework\tokenTest.txt"

let codeGenFilePath =
    @"C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework\codegen.txt"

let tokenList = tokenQueue.Tokens |> List.ofSeq


type PrefixID = { label: string; uriString: string }

type PrefixedName =
    { prefixIdLabel: string
      localName: string }



let prefixIds = ResizeArray<PrefixID>()
let unmatchedTokens = ResizeArray<IToken>()
let fullUriStrings = ResizeArray<string>()
let prefixedNames = ResizeArray<PrefixedName>()
let prefixLabels = ResizeArray<string>()
let prefixUriStrings = ResizeArray<string>()

type TripleString = TripleString of string * string * string



let tokenIsA<'TokenType> (token: IToken) = (token.GetType() = typeof<'TokenType>)

let rec scan (tokens: IToken list) =
    match tokens with
    | first :: second :: third :: fourth :: fifth :: rest when
        tokenIsA<ATToken> first
        && tokenIsA<PrefixDirectiveToken> second
        && tokenIsA<PrefixToken> third
        && tokenIsA<UriToken> fourth
        && tokenIsA<DotToken> fifth
        ->
        let label = third.Value.TrimEnd(':')
        let uriString = fourth.Value
        let prefixId = { label = label; uriString = uriString }
        prefixIds.Add prefixId
        prefixUriStrings.Add uriString

        scan rest
    | first :: rest when tokenIsA<UriToken> first ->
        fullUriStrings.Add(first.Value)
        unmatchedTokens.Add first
        scan rest
    | first :: rest when tokenIsA<QNameToken> first ->
        let splitQname = first.Value.Split(":")
        let prefixIdLabel = splitQname[0]
        let localName = splitQname[1]
        prefixLabels.Add prefixIdLabel

        prefixedNames.Add(
            { prefixIdLabel = prefixIdLabel
              localName = localName }
        )

        unmatchedTokens.Add first
        scan rest
    | first :: rest when tokenIsA<BOFToken> first ->
        // intentionally skipped from unmatched
        scan rest
    | first :: rest ->
        unmatchedTokens.Add first
        scan rest

    | [] -> ()

scan tokenList
// let testJsonFilePath = @"D:\Artifact\LCPW_OverlayStormwaterInfrastructure_D_WM.json"

let unmatchedTokenContent =
    unmatchedTokens
    |> Seq.map (fun token ->

        $"{token.Value} : {token.GetType().Name}"

    )


File.WriteAllLines(Path.Combine(outputDirectory, "unmatchedTokens.txt"), unmatchedTokenContent)

File.WriteAllLines(Path.Combine(outputDirectory, "fullUris.txt"), (fullUriStrings |> Seq.distinct))
// File.WriteAllLines(Path.Combine(outputDirectory, "prefixedNames.txt"), (prefixedNames |> Seq.distinct))


let prefixIdFromPrefixLabel: Map<string, PrefixID> =
    prefixIds
    |> Seq.map (fun prefixId -> (prefixId.label, prefixId))
    |> Map.ofSeq

let prefixIdFromUriString: Map<string, PrefixID> =
    prefixIds
    |> Seq.map (fun prefixId -> (prefixId.uriString, prefixId))
    |> Map.ofSeq

let localNamesFromPrefixLabel: Map<string, Set<string>> =
    prefixLabels
    |> Seq.map (fun prefixLabel ->
        let localNames =
            prefixedNames
            |> Seq.filter (fun prefixedName -> prefixedName.prefixIdLabel = prefixLabel)
            |> Seq.map (fun prefixedName -> prefixedName.localName)
            |> Set.ofSeq

        (prefixLabel, localNames)

    )
    |> Map.ofSeq


let sanatizeIdentifier (rawIdentifier: string) =
    if SharedKernel.InvalidFSharpIdentifier.reservedKeywordSet.Contains rawIdentifier then
        let backtickableName =
            rawIdentifier
                // .Replace('.', '_')
                .Replace('+', '_')
                .Replace('$', '_')
                .Replace('&', '_')
                .Replace('[', '_')
                .Replace(']', '_')
                .Replace('/', '_')
                .Replace('\\', '_')
                .Replace('*', '_')
                .Replace('\"', '_')
                .Replace('`', '_')

        $"``{backtickableName}``"
    else
        rawIdentifier

module identifier =
    let prefixIdLabel = "prefixIdLabel"
    let prefixIriReference = "prefixIriReference"
    let localName = "localName"

localNamesFromPrefixLabel
|> Map.iter (fun prefixIdLabel localNames ->
    let content =
        Oak() {

            Namespace($"ResourceDescriptionFramework.{prefixIdLabel}.Namespace") {
                TypeDefn((sanatizeIdentifier prefixIdLabel)) {
                    let iriReference =
                        match prefixIdFromPrefixLabel.TryFind prefixIdLabel with
                        | prefixId when prefixId.IsSome -> prefixId.Value.uriString

                    Member("_namespaceUriString", String(iriReference))
                        .toStatic ()

                    Member("_remoteFileUriString", String("http://www.w3.org/1999/02/22-rdf-syntax-ns#"))
                        .toStatic ()

                    Member("_namespacePrefixLabel", String(prefixIdLabel))
                        .toStatic ()

                    Member("_localFileUriString", String("http://www.w3.org/1999/02/22-rdf-syntax-ns#"))
                        .toStatic ()



                    for localName in localNames do


                        Member((sanatizeIdentifier localName), String localName)
                            .toStatic ()
                }
            }
        }
        |> Gen.mkOak
        |> Gen.run

    File.WriteAllText(Path.Combine(outputDirectory, $"{prefixIdLabel}.fs"), content)

)

prefixIds
