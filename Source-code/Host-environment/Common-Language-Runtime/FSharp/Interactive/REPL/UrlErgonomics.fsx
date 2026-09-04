#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "PathErgonomics.dll"

open PathErgonomics

open System
open System.IO
open FsHttp
open Dubzer.WhatwgUrl
open Meziantou.Framework
open FolkerKinzel.MimeTypes

let jsonProtocol = DomUrl "localhost:9222/json/protocol"

type QueryParameter =
    | ParameterKeyValue of string * string
    | ParameterKeyValues of string * string array
    member this.parameterKey =
        match this with
        | ParameterKeyValue (parameterKey, parameterValue) -> parameterKey
        | ParameterKeyValues (parameterKey, parameterValues) -> parameterKey

    member this.parameterValue =
        match this with
        | ParameterKeyValue (parameterKey, parameterValue) -> parameterValue
        | ParameterKeyValues (parameterKey, parameterValues) -> parameterValues[0]

    member this.parameterValues =
        match this with
        | ParameterKeyValue (parameterKey, parameterValue) -> [| parameterValue |]
        | ParameterKeyValues (parameterKey, parameterValues) -> parameterValues

    member this.ParameterPath =
        Array.concat [| [| this.parameterKey |]
                        this.parameterValues |]
        |> String.concat "\\"



type DomUrl with
    member this.ConcatFragment(fragment: string) =
        let href =
            if String.IsNullOrWhiteSpace(this.Search) then
                $"{this.Origin}/{this.AbsolutePathName}{this.Hash}/{fragment}"
            else
                $"{this.Origin}/{this.AbsolutePathName}{this.Hash}/{fragment}?{this.Search}"

        DomUrl href

    member this.AppendFragmentPath(fragment: string) =
        let href =
            if String.IsNullOrWhiteSpace(this.Search) then
                $"{this.Origin}/{this.AbsolutePathName}#/{fragment}"
            else
                $"{this.Origin}/{this.AbsolutePathName}#/{fragment}?{this.Search}"

        DomUrl href

    member this.AppendFragment(fragment: string) =
        let href =
            if String.IsNullOrWhiteSpace(this.Search) then
                $"{this.Origin}/{this.AbsolutePathName}#{fragment}"
            else
                $"{this.Origin}/{this.AbsolutePathName}#{fragment}?{this.Search}"

        DomUrl href

    member this.asString = this.ToString()

    member this.QueryStringParameters =
        QueryStringUtilities.ParseQuery this.Search
        |> Seq.map (fun keyValue ->
            match keyValue.Key, keyValue.Value |> Seq.toArray with
            | parameterKey, [| parameterValue |] -> ParameterKeyValue(parameterKey, parameterValue)
            | parameterKey, parameterValues -> ParameterKeyValues(parameterKey, parameterValues))
        |> Seq.toArray
        |> Array.sortBy (fun parameter -> parameter.parameterKey)

    member this.AppendSegments(segments: string array) =
        sprintf "%s/%s" (this.Origin + this.Pathname.TrimEnd('/')) ((segments |> String.concat "/").TrimStart('/'))
        |> DomUrl

    member this.AppendPath(path: string) = this.AppendSegments [| path |]

    member this.AbsolutePathName = this.Pathname[1..]

    member this.QueryPathName =
        this.QueryStringParameters
        |> Array.map (fun parameter -> parameter.ParameterPath)
        |> String.concat "\\"

    member this.terminalName =
        match this.Href.ToCharArray() |> Array.last with
        | '#' -> "hash"
        | '/' -> "slash"
        | _ -> "bare"

    member this.HashTerminated = this.Href + "#" |> DomUrl
    member this.SlashTerminated = this.Href + "/" |> DomUrl
    member this.extension = Path.GetExtension this.AbsolutePathName
    member this.pathStem = Path.GetFileNameWithoutExtension this.AbsolutePathName

    member this.protocolPathPart =
        this.Protocol.TrimEnd ':'
        |> PathName.makeAcceptable

    member this.hostPathPart = this.Host |> PathName.makeAcceptable

    member this.pathSegments =
        this.Pathname.Split('/', StringSplitOptions.RemoveEmptyEntries)

    member this.directorySegments =
        if this.pathSegments.Length <= 1 then
            [||]
        else
            this.pathSegments[.. this.pathSegments.Length - 2]
            |> Array.map PathName.makeAcceptable

    member this.originalFileName =
        if this.pathSegments.Length = 0 then
            invalidArg "DomUrl" $"URL has no file-name component: {this.Href}"

        this.pathSegments[this.pathSegments.Length - 1]
        |> PathName.makeAcceptable

    member this.fileExtension = Path.GetExtension this.originalFileName

    member this.fileStem = Path.GetFileNameWithoutExtension this.originalFileName

    member this.queryPathPart =
        if this.Search <> "" then
            this.Search |> PathName.makeAcceptable
        elif this.Href.Contains "?" then
            "&quest;"
        else
            ""

    member this.fragmentPathPart =
        if this.Hash <> "" then
            "&num;"
            + (this.Hash.TrimStart '#' |> PathName.makeAcceptable)
        elif this.Href.EndsWith "#" then
            "&num;"
        else
            ""

    member this.fileName =
        this.fileStem
        + this.queryPathPart
        + this.fragmentPathPart
        + this.fileExtension

    member this.fileDirectory =
        Array.concat [ [| this.protocolPathPart
                          this.hostPathPart |]
                       this.directorySegments ]
        |> Array.fold (fun path segment -> Path.Combine(path, segment)) Folder.Iri.FullName
        |> Directory.CreateDirectory

    member this.asFile =
        Path.Combine(this.fileDirectory.FullName, this.fileName)
        |> FileInfo

    member this.asFileExtension(extension: string) =
        Path.Combine(this.fileDirectory.FullName, Path.ChangeExtension(this.fileName, extension))
        |> FileInfo

    member this.CreateFileDirectory() =
        Directory.CreateDirectory this.asFile.DirectoryName
        |> ignore

    member this.WriteFileText(text: string) =
        this.CreateFileDirectory()
        File.WriteAllText(this.asFile.FullName, text)

    member this.WriteFileLines(lines: string array) =
        this.CreateFileDirectory()
        File.WriteAllLines(this.asFile.FullName, lines)

    member this.HeadlessDownloadFile() =
        this.CreateFileDirectory()

        http { GET this.Href }
        |> Request.send
        |> Response.saveFile this.asFile.FullName

    member this.HeadlessDownloadFileExtension(extension: string) =
        this.CreateFileDirectory()

        http { GET this.Href }
        |> Request.send
        |> Response.saveFile (Path.ChangeExtension(this.asFile.FullName, extension))

    member this.MimeType = MimeType.FromFileName this.asFile.FullName

    member this.asFolder =

        let href = this.Href

        let protocol =
            this.Protocol.TrimEnd ':'
            |> PathName.makeAcceptable

        let host = this.Host |> PathName.makeAcceptable

        let path =
            this
                .Pathname
                .TrimEnd('/')
                .Split('/', StringSplitOptions.RemoveEmptyEntries)
            |> Array.map PathName.makeAcceptable

        let terminal =
            if href.EndsWith("#") then
                "&num;"
            elif this.Pathname.EndsWith("/") then
                "&sol;"
            else
                "bare"

        Array.concat [ [| protocol; host |]
                       path
                       [| terminal |] ]
        |> Array.fold (fun currentPath segment -> Path.Combine(currentPath, segment)) Folder.Iri.FullName
        |> Directory.CreateDirectory

(*
    member this.ProviderText =
        if not this.asFile.Exists then
            this.HeadedDownloadText()
        let sampleIdentifier = $"{this.pathStem}FilePath"
        let text =
            Ast.Oak(){
                Ast.AnonymousModule(){
                    Ast.Value(sampleIdentifier, Ast.VerbatimString(this.asFile.FullName))
                    |> _.attribute(
                        Ast.Attribute("Literal")
                    )

                    match this.extension with
                    | ".json" -> Ast.Abbrev($"{this.pathStem}JsonProvider", "JsonProvider< UseOriginalNames = true, PreferDateOnly = true, OmitNullFields = true, RootName = \"{this.pathStem}\"")
                    | ".xml" ->
                                Ast.Abbrev($"{this.pathStem}HtmlProvider",$"HtmlProvider<PreferOptionals = true, PreferDateOnly = true, Sample = {sampleIdentifier}>")
                                Ast.Abbrev($"{this.pathStem}XmlProvider", $"XmlProvider<UseOriginalNames = true, PreferDateOnly = true, Sample = {sampleIdentifier}>")
                    | _ -> ()
                }
            }
            |> Gen.mkOak
            |> Gen.run
        text


*)

module DomUrl =

    let AddQueryParameter (parameterKey: string) parameterValue (domUrl: DomUrl) =
        new DomUrl(QueryStringUtilities.AddQueryString(domUrl.Href, parameterKey, string parameterValue))

    let UpsertQueryParameter (parameterKey: string) parameterValue (domUrl: DomUrl) =
        new DomUrl(QueryStringUtilities.AddOrReplaceQueryString(domUrl.Href, parameterKey, string parameterValue))

    let RemoveQueryParameter (parameterKey: string) (domUrl: DomUrl) =
        new DomUrl(QueryStringUtilities.RemoveQueryString(domUrl.Href, parameterKey))

    let WriteFileExtensionText (text: string) (extension: string) (url: DomUrl) =
        url.CreateFileDirectory()
        File.WriteAllText(Path.ChangeExtension(url.asFile.FullName, extension), text)
