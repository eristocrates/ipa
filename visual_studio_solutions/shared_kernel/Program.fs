namespace SharedKernel

#if INTERACTIVE
#r "nuget: FsHttp"
#endif

open System
open System.IO
open System.Text
open FsHttp
open System.Text.Json.Nodes
open Newtonsoft.Json
open Newtonsoft.Json.Linq


module Ensure =

    let sanitizedFilePath (filePathRaw: string) : string =
        if String.IsNullOrWhiteSpace(filePathRaw) then
            filePathRaw
        else
            // 1) Build a replacement table from your InvalidFileNameCharacter module.
            //    If you later add more bindings there, just extend this list.
            //
            // NOTE: I’m explicitly enumerating the ones that matter for Windows paths.
            // You can add the rest (control chars etc.) if you want stronger escaping.
            let replacementRules: InvalidFileNameCharacter.Type list =
                [ InvalidFileNameCharacter.quotationMark
                  InvalidFileNameCharacter.asterisk
                  InvalidFileNameCharacter.solidus
                  InvalidFileNameCharacter.colon
                  InvalidFileNameCharacter.lessThan
                  InvalidFileNameCharacter.greaterThan
                  InvalidFileNameCharacter.questionMark
                  InvalidFileNameCharacter.nullCharacter
                  InvalidFileNameCharacter.startOfHeading
                  InvalidFileNameCharacter.startOfText
                  InvalidFileNameCharacter.endOfText
                  InvalidFileNameCharacter.endOfTransmission
                  InvalidFileNameCharacter.enquiry
                  InvalidFileNameCharacter.acknowledge
                  InvalidFileNameCharacter.bell
                  InvalidFileNameCharacter.backspace
                  InvalidFileNameCharacter.characterTabulation
                  InvalidFileNameCharacter.lineFeed
                  InvalidFileNameCharacter.lineTabulation
                  InvalidFileNameCharacter.formFeed
                  InvalidFileNameCharacter.carriageReturn
                  InvalidFileNameCharacter.shiftOut
                  InvalidFileNameCharacter.shiftIn
                  InvalidFileNameCharacter.dataLinkEscape
                  InvalidFileNameCharacter.deviceControl1'XON
                  InvalidFileNameCharacter.deviceControl2
                  InvalidFileNameCharacter.deviceControl3'XOFF
                  InvalidFileNameCharacter.deviceControl4
                  InvalidFileNameCharacter.negativeAcknowledge
                  InvalidFileNameCharacter.synchronousIdle
                  InvalidFileNameCharacter.endOfTransmissionBlock
                  InvalidFileNameCharacter.cancel
                  InvalidFileNameCharacter.endOfMedium
                  InvalidFileNameCharacter.substitute
                  InvalidFileNameCharacter.escape
                  InvalidFileNameCharacter.informationSeparator1'fileSeparator
                  InvalidFileNameCharacter.informationSeparator2'groupSeparator
                  InvalidFileNameCharacter.informationSeparator3'recordSeparator'requestToSend
                  InvalidFileNameCharacter.informationSeparator4'unitSeparator
                  InvalidFileNameCharacter.reverseSolidus
                  InvalidFileNameCharacter.lineTabulationb
                  InvalidFileNameCharacter.verticalLine

                  ]

            let replacementMap =
                replacementRules
                |> Seq.map (fun r -> r.character, r.stringReplacement)
                |> dict

            // 2) Invalid chars for a *file name segment* on this OS.
            //    On Windows this includes <>:"/\|?* plus some control chars.
            let invalidFileNameChars = Path.GetInvalidFileNameChars() |> Set.ofArray

            // 3) Sanitize one segment (directory name or file name).
            //    Important: do NOT feed separators here; this is per-segment.
            let sanitizeSegment (segment: string) : string =
                if String.IsNullOrEmpty(segment) then
                    segment
                else
                    let sb = StringBuilder(segment.Length)

                    for c in segment do
                        if invalidFileNameChars.Contains c then
                            match replacementMap.TryGetValue c with
                            | true, repl -> sb.Append(repl) |> ignore
                            | false, _ ->
                                // deterministic escape when your table doesn’t cover it
                                sb.Append($"&u{int c:X4};") |> ignore
                        else
                            sb.Append(c) |> ignore

                    sb.ToString()

            // 4) Rebuild path while preserving separators.
            //    We split on both separators, then re-insert using the platform separator.
            let separators =
                [| Path.DirectorySeparatorChar
                   Path.AltDirectorySeparatorChar |]

            // Preserve whether it was rooted (C:\..., \..., \\server\share\...)
            let isRooted = Path.IsPathRooted(filePathRaw)

            // Capture the root prefix if present (e.g., "C:\", "\\server\share\", or "/" on unix)
            // Path.GetPathRoot returns null/"" if not rooted.
            let root = Path.GetPathRoot(filePathRaw)

            // Strip the root from the remainder so we don’t sanitize root tokens incorrectly.
            let remainder =
                if String.IsNullOrEmpty(root) then
                    filePathRaw
                else
                    filePathRaw.Substring(root.Length)

            // Break remainder into segments, sanitize each, then join.
            let sanitizedRemainder =
                remainder.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                |> Array.map sanitizeSegment
                |> String.concat (string Path.DirectorySeparatorChar)

            // 5) Root handling:
            //    - If root is "C:\" or similar, keep it verbatim (don’t replace the drive colon).
            //    - If UNC root exists, keep it verbatim as well.
            //    - If not rooted, just return sanitized remainder.
            if String.IsNullOrEmpty(root) then
                sanitizedRemainder
            else
            // Ensure we don’t double-separator.
            if sanitizedRemainder.Length = 0 then
                root
            else
                // Root already ends with separator on Windows; Path.GetPathRoot usually does.
                // If it doesn't, we insert one.
                let needsSep =
                    not (root.EndsWith(string Path.DirectorySeparatorChar))
                    && not (root.EndsWith(string Path.AltDirectorySeparatorChar))

                if needsSep then
                    root
                    + string Path.DirectorySeparatorChar
                    + sanitizedRemainder
                else
                    root + sanitizedRemainder

    let path (filePathRaw: string) =
        let filePath = sanitizedFilePath filePathRaw
        let fileName = Path.GetFileName filePath
        let parentDirectory = Path.GetDirectoryName(filePath)

        if
            not (String.IsNullOrWhiteSpace(parentDirectory))
            && not (Directory.Exists(parentDirectory))
        then
            Directory.CreateDirectory(parentDirectory)
            |> ignore

        filePath

module Internet =

    let request (uriString: string) (queryStringKeyValues: Option<List<string * string>>) =
        let queryString = defaultArg queryStringKeyValues [ (String.Empty, String.Empty) ]

        http {
            GET uriString
            query queryString
        }
        |> Request.send

    let download
        (uriString: string)
        (outputRootDirectory: string)
        (outputPath: string)
        (queryStringKeyValues: Option<List<string * string>>)
        =
        request uriString queryStringKeyValues
        |> Response.saveFile (Ensure.path $"{outputRootDirectory}/{outputPath}")

    let jsonObject (uriString: string) (queryStringKeyValues: Option<List<string * string>>) =
        let response =
            request uriString queryStringKeyValues
            |> Response.toJson

        JObject.Parse(response.GetRawText())

module Affix =

    /// If `input` starts with `prefix` and ends with `suffix`, returns the substring between them.
    /// Otherwise returns `input` unchanged. Preserves null.
    let getInfix (prefix: string) (input: string) (suffix: string) : string =
        match input with
        | null -> null
        | inputString ->
            // Treat null prefix/suffix as programmer error; if you want different semantics, change here.
            if isNull prefix then
                invalidArg "prefix" "prefix cannot be null"

            if isNull suffix then
                invalidArg "suffix" "suffix cannot be null"

            if
                inputString.StartsWith(prefix)
                && inputString.EndsWith(suffix)
            then
                let startIndex = prefix.Length
                let innerLength = inputString.Length - prefix.Length - suffix.Length

                if innerLength >= 0 then
                    inputString.Substring(startIndex, innerLength)
                else
                    // This can only happen if prefix+suffix is longer than s; in that case, return unchanged.
                    inputString
            else
                inputString
