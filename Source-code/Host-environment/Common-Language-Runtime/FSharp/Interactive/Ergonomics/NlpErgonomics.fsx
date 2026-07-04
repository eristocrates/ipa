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

module nlp =
    let pipeline = Pipeline.For(Language.English)

    let recognizer =
        AveragePerceptronEntityRecognizer.FromStoreAsync(Language.English, Version.Latest, "WikiNER")
        |> Async.AwaitTask
        |> Async.RunSynchronously

    pipeline.Add(recognizer) |> ignore

    let process_single (input: string) =
        let document = Document(input, Language.English)
        pipeline.ProcessSingle(document)

    let process_multiple (inputs: string array) =
        let documents =
            inputs
            |> Array.map (fun input -> Document(input, Language.English) :> IDocument)
            |> Array.toSeq

        pipeline.Process documents
