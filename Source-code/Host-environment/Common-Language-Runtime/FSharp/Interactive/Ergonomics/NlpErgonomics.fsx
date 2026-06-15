open System
#r "nuget: Catalyst.Models.English"

open Catalyst
open Catalyst.Models
open Mosaik.Core
(*
// https://docs.curiosity.ai/catalyst/pipeline#custom-order
Custom Order

When you add a process using Add(), Catalyst automatically maintains a logical order:

    Normalizers
    Tokenizers
    Sentence Detectors
    Taggers
    Others (e.g., Entity Recognizers)
*)

English.Register()
Storage.Current <- DiskStorage("catalyst-models")
let nlp = Pipeline.For(Language.English)

let recognizer =
    AveragePerceptronEntityRecognizer.FromStoreAsync(Language.English, Version.Latest, "WikiNER")
    |> Async.AwaitTask
    |> Async.RunSynchronously

nlp.Add(recognizer) |> ignore

let pipeline (input: string) =
    let doc = Document(input, Language.English)
    nlp.ProcessSingle(doc)

let doc = pipeline "The quick brown fox jumps over the lazy dog"
let tokens = doc.ToTokenList()

tokens[4]
let doc_json = doc.ToJson()
printfn "%s" doc_json
