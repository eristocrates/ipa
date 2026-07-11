#r @"C:\Repositories\Modernization\ConsoleFsharp\bin\Debug\net10.0\ConsoleFsharp.dll"
#r "nuget: Iride"
#r "nuget: Catalyst"
#r "nuget: Catalyst.Models.English"

open Rdf.Namespace
open Program
open Ergonomics
open Shorthand
open System
open System.Threading.Tasks
open Mosaik.Core
open Catalyst
open Catalyst.Models

let exampleText = "The quick brown fox jumps over the lazy dog"
let rawText = "breakfast"

// One-time global setup (same as C#)
Catalyst.Models.English.Register()
Storage.Current <- new DiskStorage("catalyst-models")

let naturalLanguageProcessingPipeline =
    Pipeline.ForAsync(Language.English)
    |> Async.AwaitTask
    |> Async.RunSynchronously

let tokenizer = new FastTokenizer(Language.English)
naturalLanguageProcessingPipeline.Add(tokenizer)

let tagger =
    AveragePerceptronTagger.FromStoreAsync(Language.English, Version.Latest, "")
    |> Async.AwaitTask
    |> Async.RunSynchronously

naturalLanguageProcessingPipeline.Add(tagger)

let programmingLanguageSpotter =
    new Spotter(Language.Any, 0, "programming", "ProgrammingLanguage")

programmingLanguageSpotter.AddEntry("C#")
programmingLanguageSpotter.AddEntry("F#")



let isAPatternSpotter =
    new PatternSpotter(Language.English, 0, "is-a-pattern", "IsA")

isAPatternSpotter.NewPattern(
    "Is+Noun",
    fun mp ->
        let is =
            new PatternUnit(
                PatternUnitPrototype
                    .Single()
                    .WithToken("is")
                    .WithPOS(PartOfSpeech.VERB)
            )

        let a =
            new PatternUnit(
                PatternUnitPrototype
                    .Multiple()
                    .WithPOS(PartOfSpeech.NOUN, PartOfSpeech.PROPN, PartOfSpeech.DET, PartOfSpeech.ADJ)
            )

        mp.Add(is, a) |> ignore
)

let namedEntityRecognizer =
    AveragePerceptronEntityRecognizer.FromStoreAsync(Language.English, Version.Latest, "WikiNER")
    |> Async.AwaitTask
    |> Async.RunSynchronously

naturalLanguageProcessingPipeline.Add(namedEntityRecognizer)


let annotationDocument = new Document(rawText, Language.English)

// let fastTextEmbedder = new FastText(Language.English, 0, "my-fasttext-model");

naturalLanguageProcessingPipeline.ProcessSingle(annotationDocument)
// fastTextEmbedder.Train(naturalLanguageProcessingPipeline.Process([annotationDocument]));

Console.WriteLine(annotationDocument.ToJson())

// let appleVector = fastTextEmbedder.GetVector("apple", Language.English);
// let orangeVector = fastTextEmbedder.GetVector("orange", Language.English);
// let vectorSimilarity (leftHandSide: float32 array)(rightHandSide:float32 array) = leftHandSide.CosineSimilarityWith rightHandSide
let languageDetector =
    LanguageDetector.FromStoreAsync(Language.Any, Version.Latest, "")
    |> Async.AwaitTask
    |> Async.RunSynchronously

let allTokens = annotationDocument.ToTokenList()

allTokens
|> Seq.iter (fun token -> Console.WriteLine(token))
