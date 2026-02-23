#r @"C:\Repositories\ipa\visual_studio_solutions\shared_kernel\bin\Debug\net10.0\shared_kernel.dll"
#r @"C:\Repositories\ipa\visual_studio_solutions\ResourceDescriptionFramework\bin\Debug\net10.0\ResourceDescriptionFramework.dll"


#r "nuget: Iride"
#r "nuget: FsHttp"
#r "nuget: FSharp.Data"

open FSharp.Data

open System
open System.Reflection

open System.IO
open System.Text
open FSharp.Data

open SharedKernel
open Program

open Ergonomics
open Shorthand
open LangTag
open Rdf.Namespace
open Rdfs.Namespace
open Owl.Namespace
open Xsd.Namespace
open Xs.Namespace
open Xml.spec.Namespace
open Dcat.Namespace
open Dcmi.dcterms.Namespace
open FsHttp

let logLines = ResizeArray<string>()

module songlist =
    [<Literal>]
    let filePath =
        @"C:\Repositories\ipa\visual_studio_solutions\rhythm_games\arcaea\secret\moe.low.arc\files\cb\active\songs\songlist"

    type Provider = JsonProvider<filePath>
    let json = Provider.Load(filePath)

songlist.json.Songs

let (|Contains|_|) (subString: string) (matchedString: string) =
    if matchedString.Contains(subString) then Some() else None

let typeKeys = Set.ofList [ "type" ]

let arcaeaKeys =
    Set.ofList
        [

          "day"
          "night"
          "bg"
          "bg_inverse"
          "artist"
          "jacket_designer"
          "jacket_night"
          "purchase"
          "set"

          ]

let languageExceptionKeys = Set.ofList [ "" ]

let commaSeparatedKeys = Set.ofList [ "" ]

GraphRuntime.inMemoryDataset.Graphs
|> Seq.iter (fun graph ->
    graph.Clear()
    graph.NamespaceMap.Clear())

let a = rdf.``type``
let dbug = mint.prefixID "urn:dbug:" "dbug"

let arcaea =
    NamedGraph.inhabitant (mint.prefixID "https://arcaea.lowiro.com/#" "arcaea") @"Artifacts\arcaea"

let stringFromObjectMember (jsonObject: (string * JsonValue) array) (memberKey: string) =
    jsonObject
    |> Array.filter (fun (layerPropertyKey, layerPropertyValue) -> layerPropertyKey = memberKey)
    |> Array.map (fun (layerPropertyKey, layerPropertyValue) -> layerPropertyValue.AsString())
    |> Array.head

let intFromObjectMember (jsonObject: (string * JsonValue) array) (memberKey: string) =
    jsonObject
    |> Array.filter (fun (layerPropertyKey, layerPropertyValue) -> layerPropertyKey = memberKey)
    |> Array.map (fun (layerPropertyKey, layerPropertyValue) -> layerPropertyValue.AsInteger())
    |> Array.head

let rec TriplifyJsonMember
    (subject: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)
    (predicate: Communication.Internet.Standard.Resource.Identifier.Internationalized.Type)
    (memberKey: string)
    (memberValue: JsonValue)
    (graphs: NamedGraph.Type list)
    (sourceFilePath: string)
    =
    let sourceFile = Path.GetFileName sourceFilePath
    // TODO add member key matching like object and array
    match memberValue with
    | JsonValue.String jsonString ->
        match memberKey with
        | "day"
        | "night"
        | "bg"
        | "bg_inverse"
        | "file_name"
        | "requirement"
        | "zh-Hant"
        | "zh-Hans"

         ->
            match jsonString with
            | _ when commaSeparatedKeys.Contains memberKey ->
                jsonString.Split(",")
                |> Array.iter (fun splitValueRaw ->
                    let splitValue = splitValueRaw.TrimStart().TrimEnd()

                    if languageExceptionKeys.Contains memberKey then
                        subject --- predicate --> splitValue >=: graphs
                    else
                        subject --- predicate --> splitValue @@ en_us >=: graphs

                )
            | _ when jsonString.Length = 0 -> () // intentionally skipped
            | _ when typeKeys.Contains memberKey ->
                let jsonStringClean = jsonString.Replace(" ", "_")

                match jsonStringClean with
                | _ -> subject --- a --> arcaea._prefix jsonStringClean >=: graphs

            | _ when arcaeaKeys.Contains memberKey ->
                subject --- predicate --> arcaea._prefix (jsonString.Replace("arcaea", ""))
                >=: graphs
            | _ when languageExceptionKeys.Contains memberKey -> subject --- predicate --> jsonString >=: graphs

            | _ -> subject --- predicate --> jsonString @@ en_us >=: graphs

        | "snippet"
        | "thumbnail" -> () // intentionally skipped

        | _ -> logLines.Add $"{sourceFile} string {memberKey}"

    | JsonValue.Number jsonNumber ->
        match memberKey with
        | "side" ->
            match jsonNumber with
            | 0m -> subject --- predicate --> arcaea._prefix "light_side" >=: graphs
            | _ -> subject --- predicate --> arcaea._prefix "conflict_side" >=: graphs
        | "audioPreview"
        | "audioPreviewEnd"
        | "bpm_base"
        | "date"
        | "idx"
        | "limitedSaleEndTime"
        | "rating"
        | "ratingClass"

         ->
            match jsonNumber with
            | _ -> subject --- predicate --> jsonNumber >=: graphs
        | _ -> logLines.Add $"{sourceFile} number decimal {memberKey}"

    | JsonValue.Float jsonNumber ->
        match memberKey with
        | "" ->
            match jsonNumber with
            | _ -> subject --- predicate --> jsonNumber >=: graphs

        | _ -> logLines.Add $"{sourceFile} number float {memberKey}"

    | JsonValue.Boolean jsonBoolean -> subject --- predicate --> jsonBoolean >=: graphs
    | JsonValue.Null ->
        // subject --- predicate --> rdf.nil >=: graphs
        () // intentionally skipped
    | JsonValue.Array jsonArray ->
        match memberKey with
        | "songs"
        | "additional_files"

         ->
            jsonArray
            |> Array.iter (fun jsonValue ->
                TriplifyJsonMember subject (arcaea._prefix memberKey) memberKey jsonValue graphs sourceFilePath)

        | "difficulties"
        | "en"
        | "ja"
        | "ko"

         -> () // hanled explicitly elsewhere via type provider

        | "labelingInfo" -> () // intentionally skipped


        | _ -> logLines.Add $"{sourceFile} array {memberKey}"
    | JsonValue.Record jsonObject ->
        match memberKey with
        | "additional_files"
        | "bg_daynight"
        | "jacket_localized"

         ->
            jsonObject
            |> Array.iter (fun (objectMemberKey, objectMemberValue) ->
                subject --- predicate --> subject._prefix memberKey >=: graphs

                TriplifyJsonMember
                    (arcaea._prefix memberKey)
                    (arcaea._prefix objectMemberKey)
                    objectMemberKey
                    objectMemberValue
                    graphs
                    sourceFilePath

            )

        | "difficulties"
        | "search_artist"
        | "search_artist"
        | "source_localized"
        | "title_localized"

         -> () // hanled explicitly elsewhere via type provider
        | "search_title"
        | "" -> () // intentionally skipped

        | _ -> logLines.Add $"{sourceFile} object {memberKey}"

songlist.json.Songs
|> Array.iter (fun song ->
    let songLocalName =
        match song.Id with
        | _ when song.Id.Number.IsSome -> string song.Id.Number.Value
        | _ -> song.Id.String.Value

    let arcaea'song =
        NamedGraph.inhabitant
            (mint.prefixID $"https://arcaea.lowiro.com/#{songLocalName}#" $"arcaea.{songLocalName}")
            $"""Artifacts\{songLocalName}"""



    arcaea._prefix "" --- arcaea._prefix "song" --> arcaea'song._prefix ""
    >-: arcaea'song

    song.JsonValue.Properties()
    |> Array.iter (fun (memberKey, memberValue) ->
        TriplifyJsonMember
            (arcaea'song._prefix "")
            (arcaea._prefix memberKey)
            memberKey
            memberValue
            [ arcaea'song ]
            songlist.filePath)

    song.Difficulties
    |> Array.iter (fun difficulty ->
        let difficultyLocalName =
            match difficulty.RatingClass with
            | 0 -> "PST"
            | 1 -> "PRS"
            | 2 -> "FTR"
            | 3 -> "BYD"
            | _ -> "ETR"

        arcaea'song._prefix "" --- arcaea._prefix "difficulties"
        --> arcaea'song._prefix difficultyLocalName
        >-: arcaea'song

        difficulty.JsonValue.Properties()
        |> Array.iter (fun (memberKey, memberValue) ->
            TriplifyJsonMember
                (arcaea'song._prefix difficultyLocalName)
                (arcaea._prefix memberKey)
                memberKey
                memberValue
                [ arcaea'song ]
                songlist.filePath

        )

    )

    if song.SearchArtist.IsSome then
        song.SearchArtist.Value.Ja
        |> Array.iter (fun japaneseString ->
            arcaea'song._prefix "" --- arcaea._prefix "search_title" --> japaneseString
            @@ ja
            >-: arcaea'song)

        song.SearchArtist.Value.Ko
        |> Array.iter (fun koreanString ->
            arcaea'song._prefix "" --- arcaea._prefix "search_title" --> koreanString @@ ko
            >-: arcaea'song

        )

        song.SearchArtist.Value.En
        |> Array.iter (fun englishString ->
            arcaea'song._prefix "" --- arcaea._prefix "search_title" --> englishString @@ en
            >-: arcaea'song

        )

    if song.SearchTitle.IsSome then
        song.SearchTitle.Value.Ja
        |> Array.iter (fun japaneseString ->
            arcaea'song._prefix "" --- arcaea._prefix "search_title" --> japaneseString
            @@ ja
            >-: arcaea'song)

        song.SearchTitle.Value.Ko
        |> Array.iter (fun koreanString ->
            arcaea'song._prefix "" --- arcaea._prefix "search_title" --> koreanString @@ ko
            >-: arcaea'song

        )

        song.SearchTitle.Value.En
        |> Array.iter (fun englishString ->
            arcaea'song._prefix "" --- arcaea._prefix "search_title" --> englishString @@ en
            >-: arcaea'song

        )

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.Ja.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.Ja.Value
            @@ ja
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.Ko.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.Ko.Value
            @@ ko
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.KoDialog.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.KoDialog.Value
            @@ ko
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.Kr.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.Kr.Value
            @@ ko
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.ZhHans.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.ZhHans.Value
            @@ zh_Hans
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.ZhHansDialog.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.ZhHansDialog.Value
            @@ zh_Hans
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.ZhHant.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.ZhHant.Value
            @@ zh_Hant
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        if song.TitleLocalized.Value.ZhHantDialog.IsSome then
            arcaea'song._prefix "" --- arcaea._prefix "title_localized"
            --> song.TitleLocalized.Value.ZhHantDialog.Value
            @@ zh_Hant
            >-: arcaea'song

    if song.TitleLocalized.IsSome then
        arcaea'song._prefix "" --- arcaea._prefix "title_localized"
        --> song.TitleLocalized.Value.En
        @@ en
        >-: arcaea'song

    if song.SourceLocalized.IsSome then
        arcaea'song._prefix "" --- arcaea._prefix "title_localized"
        --> song.SourceLocalized.Value.En
        @@ en
        >-: arcaea'song




)

let distinctLogLines = logLines |> Seq.distinct |> Seq.sort
File.WriteAllLines("logLines.txt", distinctLogLines)

GraphRuntime.NamedGraphs
|> Seq.iter (fun namedGraph -> GraphRuntime.Serialization.Turtle.save namedGraph)
