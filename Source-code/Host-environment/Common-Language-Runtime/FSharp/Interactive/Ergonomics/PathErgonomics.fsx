open System
open System.IO
open System.Text

open System
open System.Net
open System.IO


#r "nuget: Fabulous.AST.Json, 2.0.0-pre06"

open Fabulous.AST
open Fabulous.AST.Json

open type Fabulous.AST.Ast
open Fantomas.FCS.Text

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\InvalidFileNameCharacter.fsx"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\StringErgonomics.fsx"

open StringErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\FsharpErgonomics.fsx"
open FsharpErgonomics



















module Ensure =

    let sanitizedFilePath (rawFilePath: string) : string =
        if String.IsNullOrWhiteSpace(rawFilePath) then
            rawFilePath
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
            let isRooted = Path.IsPathRooted(rawFilePath)

            // Capture the root prefix if present (e.g., "C:\", "\\server\share\", or "/" on unix)
            // Path.GetPathRoot returns null/"" if not rooted.
            let root = Path.GetPathRoot(rawFilePath)

            // Strip the root from the remainder so we don’t sanitize root tokens incorrectly.
            let remainder =
                if String.IsNullOrEmpty(root) then
                    rawFilePath
                else
                    rawFilePath.Substring(root.Length)

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

    let path (rawFilePath: string) : string =
        let filePath = sanitizedFilePath rawFilePath
        let fileName = Path.GetFileName filePath
        let parentDirectory = Path.GetDirectoryName(filePath)

        if
            not (String.IsNullOrWhiteSpace(parentDirectory))
            && not (Directory.Exists(parentDirectory))
        then
            Directory.CreateDirectory(parentDirectory)
            |> ignore

        filePath






type UnixFileSystemPermission =
    | No_permission
    | Execute_permission_for_others
    | Write_permission_for_others
    | Read_permission_for_others
    | Execute_permission_for_group
    | Write_permission_for_group
    | Read_permission_for_group
    | Execute_permission_for_owner
    | Write_permission_for_owner
    | Read_permission_for_owner
    | Sticky_bit_permission
    | Set_group_permission
    | Set_user_permission
    static member fromUnixFileMode(unixFileMode: UnixFileMode) =
        match unixFileMode with
        | UnixFileMode.None -> UnixFileSystemPermission.No_permission
        | UnixFileMode.OtherExecute -> UnixFileSystemPermission.Execute_permission_for_others
        | UnixFileMode.OtherWrite -> UnixFileSystemPermission.Write_permission_for_others
        | UnixFileMode.OtherRead -> UnixFileSystemPermission.Read_permission_for_others
        | UnixFileMode.GroupExecute -> UnixFileSystemPermission.Execute_permission_for_group
        | UnixFileMode.GroupWrite -> UnixFileSystemPermission.Write_permission_for_group
        | UnixFileMode.GroupRead -> UnixFileSystemPermission.Read_permission_for_group
        | UnixFileMode.UserExecute -> UnixFileSystemPermission.Execute_permission_for_owner
        | UnixFileMode.UserWrite -> UnixFileSystemPermission.Write_permission_for_owner
        | UnixFileMode.UserRead -> UnixFileSystemPermission.Read_permission_for_owner
        | UnixFileMode.StickyBit -> UnixFileSystemPermission.Sticky_bit_permission
        | UnixFileMode.SetGroup -> UnixFileSystemPermission.Set_group_permission
        | UnixFileMode.SetUser -> UnixFileSystemPermission.Set_user_permission
        | _ -> UnixFileSystemPermission.No_permission

    member this.toUnixFileMode =
        match this with
        | UnixFileSystemPermission.No_permission -> UnixFileMode.None
        | UnixFileSystemPermission.Execute_permission_for_others -> UnixFileMode.OtherExecute
        | UnixFileSystemPermission.Write_permission_for_others -> UnixFileMode.OtherWrite
        | UnixFileSystemPermission.Read_permission_for_others -> UnixFileMode.OtherRead
        | UnixFileSystemPermission.Execute_permission_for_group -> UnixFileMode.GroupExecute
        | UnixFileSystemPermission.Write_permission_for_group -> UnixFileMode.GroupWrite
        | UnixFileSystemPermission.Read_permission_for_group -> UnixFileMode.GroupRead
        | UnixFileSystemPermission.Execute_permission_for_owner -> UnixFileMode.UserExecute
        | UnixFileSystemPermission.Write_permission_for_owner -> UnixFileMode.UserWrite
        | UnixFileSystemPermission.Read_permission_for_owner -> UnixFileMode.UserRead
        | UnixFileSystemPermission.Sticky_bit_permission -> UnixFileMode.StickyBit
        | UnixFileSystemPermission.Set_group_permission -> UnixFileMode.SetGroup
        | UnixFileSystemPermission.Set_user_permission -> UnixFileMode.SetUser


/// https://learn.microsoft.com/en-us/dotnet/api/system.io.fileattributes?view=net-10.0#fields
type FileSystemEntryAttribute =
    | NoAttribute
    | ReadOnlyEntry
    | HiddenEntry
    | SystemEntry
    | DirectoryEntry
    | Entry_marked_to_be_included_in_incremental_backup_operation
    | DeviceEntry_reserved_for_future_use
    | NormalEntry
    | TemporaryEntry
    | SparseFileEntry
    | Entry_containing_ReparsePoint
    | CompressedEntry
    | OfflineEntry
    | Entry_excluded_from_content_indexing_service
    | EncryptedEntry
    | Entry_includes_data_integrity_support
    | Entry_excluded_from_data_integrity_scan

    static member fromFileAttributes(fileAttribute: FileAttributes) =
        match fileAttribute with
        | FileAttributes.None -> FileSystemEntryAttribute.NoAttribute
        | FileAttributes.ReadOnly -> FileSystemEntryAttribute.ReadOnlyEntry
        | FileAttributes.Hidden -> FileSystemEntryAttribute.HiddenEntry
        | FileAttributes.System -> FileSystemEntryAttribute.SystemEntry
        | FileAttributes.Directory -> FileSystemEntryAttribute.DirectoryEntry
        | FileAttributes.Archive -> FileSystemEntryAttribute.Entry_marked_to_be_included_in_incremental_backup_operation
        | FileAttributes.Device -> FileSystemEntryAttribute.DeviceEntry_reserved_for_future_use
        | FileAttributes.Normal -> FileSystemEntryAttribute.NormalEntry
        | FileAttributes.Temporary -> FileSystemEntryAttribute.TemporaryEntry
        | FileAttributes.SparseFile -> FileSystemEntryAttribute.SparseFileEntry
        | FileAttributes.ReparsePoint -> FileSystemEntryAttribute.Entry_containing_ReparsePoint
        | FileAttributes.Compressed -> FileSystemEntryAttribute.CompressedEntry
        | FileAttributes.Offline -> FileSystemEntryAttribute.OfflineEntry
        | FileAttributes.NotContentIndexed -> FileSystemEntryAttribute.Entry_excluded_from_content_indexing_service
        | FileAttributes.Encrypted -> FileSystemEntryAttribute.EncryptedEntry
        | FileAttributes.IntegrityStream -> FileSystemEntryAttribute.Entry_includes_data_integrity_support
        | FileAttributes.NoScrubData -> FileSystemEntryAttribute.Entry_excluded_from_data_integrity_scan
        | _ -> FileSystemEntryAttribute.NoAttribute

    member this.toFileAttributes =
        match this with
        | FileSystemEntryAttribute.NoAttribute -> FileAttributes.None
        | FileSystemEntryAttribute.ReadOnlyEntry -> FileAttributes.ReadOnly
        | FileSystemEntryAttribute.HiddenEntry -> FileAttributes.Hidden
        | FileSystemEntryAttribute.SystemEntry -> FileAttributes.System
        | FileSystemEntryAttribute.DirectoryEntry -> FileAttributes.Directory
        | FileSystemEntryAttribute.Entry_marked_to_be_included_in_incremental_backup_operation -> FileAttributes.Archive
        | FileSystemEntryAttribute.DeviceEntry_reserved_for_future_use -> FileAttributes.Device
        | FileSystemEntryAttribute.NormalEntry -> FileAttributes.Normal
        | FileSystemEntryAttribute.TemporaryEntry -> FileAttributes.Temporary
        | FileSystemEntryAttribute.SparseFileEntry -> FileAttributes.SparseFile
        | FileSystemEntryAttribute.Entry_containing_ReparsePoint -> FileAttributes.ReparsePoint
        | FileSystemEntryAttribute.CompressedEntry -> FileAttributes.Compressed
        | FileSystemEntryAttribute.OfflineEntry -> FileAttributes.Offline
        | FileSystemEntryAttribute.Entry_excluded_from_content_indexing_service -> FileAttributes.NotContentIndexed
        | FileSystemEntryAttribute.EncryptedEntry -> FileAttributes.Encrypted
        | FileSystemEntryAttribute.Entry_includes_data_integrity_support -> FileAttributes.IntegrityStream
        | FileSystemEntryAttribute.Entry_excluded_from_data_integrity_scan -> FileAttributes.NoScrubData








type DriveVolume =
    abstract member fileSystemName: String
    abstract member volumeName: String
    abstract member volumeLabel: String
    abstract member totalSize: Int64
    abstract member totalFreeSpace: Int64
    abstract member availableFreeSpace: Int64
    abstract member driveType: DriveType
    abstract member isReady: Boolean


type HierarchicalPath =
    abstract member rootSegment: string
    abstract member branchSegments: string seq
    abstract member leafSegment: string
    abstract member pathSegments: string seq
    abstract member asString: string

type FileSystemPath =
    abstract member driveVolumeName: string
    abstract member creationTimeUtc: DateTime
    abstract member fileSystemEntryAttribute: FileSystemEntryAttribute
    abstract member unixFileSystemPermission: UnixFileSystemPermission
    abstract member exists: bool
    abstract member lastAccessTimeUtc: System.DateTime
    abstract member lastWriteTimeUtc: System.DateTime
    abstract member absoluteUriString: string
    abstract member parentDirectoryPathTokens: string array


type DirectoryPath =
    inherit FileSystemPath
    abstract member directoryName: string
    abstract member directoryNameTokens: string array
    abstract member parentDirectoryPathString: string
    abstract member childDirectoryPathStrings: string array
    abstract member originalDirectoryPathString: string

type FilePath =
    inherit FileSystemPath
    abstract member fileName: string
    abstract member fileNameTokens: string array
    abstract member extension: string
    abstract member stem: string
    abstract member directoryPathString: string
    abstract member originalFilePathString: string


type ParentDirectoryPath =
    inherit DirectoryPath
    abstract member childDirectoryPaths: ChildDirectoryPath array

and ChildDirectoryPath =
    inherit DirectoryPath
    abstract member parentDirectoryPath: DirectoryPath






let directoryPathTokens_from_uriSegments (segments: string array) =
    segments
    |> Array.filter (fun segment -> segment <> "/")
    |> Array.filter (fun segment -> segment <> (segments |> Array.last))
    |> Array.map (fun segment ->

        let trimmedSegment = segment.TrimEnd('/')
        let decodedSegment = WebUtility.UrlDecode(trimmedSegment)
        decodedSegment

    )

let FilePath_from_string (filePathString: string) =
    let fileInfo = new FileInfo(filePathString)
    let fileUri = new Uri(filePathString)

    { new FilePath with
        member this.driveVolumeName = fileInfo.Directory.Root.Name
        member this.creationTimeUtc = fileInfo.CreationTimeUtc

        member this.fileSystemEntryAttribute =
            FileSystemEntryAttribute.fromFileAttributes fileInfo.Attributes

        member this.unixFileSystemPermission =
            UnixFileSystemPermission.fromUnixFileMode fileInfo.UnixFileMode

        member this.exists = fileInfo.Exists
        member this.lastAccessTimeUtc = fileInfo.LastAccessTimeUtc
        member this.lastWriteTimeUtc = fileInfo.LastWriteTimeUtc

        member this.extension = fileInfo.Extension.TrimStart('.')
        member this.stem = Path.GetFileNameWithoutExtension(filePathString)
        member this.directoryPathString = fileInfo.DirectoryName
        member this.absoluteUriString = fileUri.AbsoluteUri

        member this.parentDirectoryPathTokens =
            directoryPathTokens_from_uriSegments fileUri.Segments

        member this.fileName = fileInfo.Name
        member this.fileNameTokens = fileInfo.Name.Split(".")
        member this.originalFilePathString = fileInfo.FullName }

let DirectoryPath_from_string (directoryPathString: string) =

    let directoryInfo = new DirectoryInfo(directoryPathString)
    let directoryUri = new Uri(directoryPathString)

    let parentDirectoryPathString =
        if directoryInfo.Parent = null then
            directoryInfo.Root.Name
        else
            directoryInfo.Parent.FullName

    let childDirectoryPathStrings = Directory.GetDirectories(directoryPathString)

    { new DirectoryPath with
        member this.driveVolumeName = directoryInfo.Root.Name
        member this.creationTimeUtc = directoryInfo.CreationTimeUtc

        member this.fileSystemEntryAttribute =
            FileSystemEntryAttribute.fromFileAttributes directoryInfo.Attributes

        member this.unixFileSystemPermission =
            UnixFileSystemPermission.fromUnixFileMode directoryInfo.UnixFileMode

        member this.exists = directoryInfo.Exists
        member this.lastAccessTimeUtc = directoryInfo.LastAccessTimeUtc
        member this.lastWriteTimeUtc = directoryInfo.LastWriteTimeUtc
        member this.parentDirectoryPathString = parentDirectoryPathString
        member this.childDirectoryPathStrings = childDirectoryPathStrings
        member this.directoryName = directoryInfo.Name
        member this.directoryNameTokens = directoryInfo.Name.Split(".")
        member this.absoluteUriString = directoryUri.AbsoluteUri

        member this.parentDirectoryPathTokens =
            directoryPathTokens_from_uriSegments directoryUri.Segments

        member this.originalDirectoryPathString = directoryInfo.FullName }



let ChildDirectoryPath_from_DirectoryPath (pendingChildDirectoryPath: DirectoryPath) =
    let parentDirectoryInfo =
        Directory.GetParent(pendingChildDirectoryPath.originalDirectoryPathString)

    let parentUri = new Uri(pendingChildDirectoryPath.originalDirectoryPathString)

    { new ChildDirectoryPath with
        member this.driveVolumeName = pendingChildDirectoryPath.driveVolumeName
        member this.creationTimeUtc = pendingChildDirectoryPath.creationTimeUtc

        member this.fileSystemEntryAttribute =
            pendingChildDirectoryPath.fileSystemEntryAttribute

        member this.unixFileSystemPermission =
            pendingChildDirectoryPath.unixFileSystemPermission

        member this.exists = pendingChildDirectoryPath.exists
        member this.lastAccessTimeUtc = pendingChildDirectoryPath.lastAccessTimeUtc
        member this.lastWriteTimeUtc = pendingChildDirectoryPath.lastWriteTimeUtc
        member this.directoryName = pendingChildDirectoryPath.directoryName
        member this.directoryNameTokens = pendingChildDirectoryPath.directoryName.Split(".")

        member this.originalDirectoryPathString =
            pendingChildDirectoryPath.originalDirectoryPathString

        member this.parentDirectoryPathString =
            pendingChildDirectoryPath.parentDirectoryPathString

        member this.childDirectoryPathStrings =
            pendingChildDirectoryPath.childDirectoryPathStrings


        member this.absoluteUriString = parentUri.AbsoluteUri


        member this.parentDirectoryPathTokens =
            directoryPathTokens_from_uriSegments parentUri.Segments

        member this.parentDirectoryPath =
            DirectoryPath_from_string parentDirectoryInfo.FullName }

let ParentDirectoryPath_from_DirectoryPath (pendingParentDirectoryPath: DirectoryPath) =
    let childDirectoryPaths =
        pendingParentDirectoryPath.childDirectoryPathStrings
        |> Array.Parallel.choose (fun childDirectoryPathString ->
            try
                childDirectoryPathString
                |> DirectoryPath_from_string
                |> ChildDirectoryPath_from_DirectoryPath
                |> Some
            with
            | :? UnauthorizedAccessException -> None
            | :? Security.SecurityException -> None
            | :? IOException -> None



        )

    let parentUri = new Uri(pendingParentDirectoryPath.originalDirectoryPathString)

    { new ParentDirectoryPath with
        member this.driveVolumeName = pendingParentDirectoryPath.driveVolumeName
        member this.creationTimeUtc = pendingParentDirectoryPath.creationTimeUtc

        member this.fileSystemEntryAttribute =
            pendingParentDirectoryPath.fileSystemEntryAttribute

        member this.unixFileSystemPermission =
            pendingParentDirectoryPath.unixFileSystemPermission

        member this.exists = pendingParentDirectoryPath.exists
        member this.lastAccessTimeUtc = pendingParentDirectoryPath.lastAccessTimeUtc
        member this.lastWriteTimeUtc = pendingParentDirectoryPath.lastWriteTimeUtc
        member this.directoryName = pendingParentDirectoryPath.directoryName
        member this.directoryNameTokens = pendingParentDirectoryPath.directoryName.Split(".")

        member this.originalDirectoryPathString =
            pendingParentDirectoryPath.originalDirectoryPathString

        member this.parentDirectoryPathString =
            pendingParentDirectoryPath.parentDirectoryPathString

        member this.childDirectoryPathStrings =
            pendingParentDirectoryPath.childDirectoryPathStrings

        member this.absoluteUriString = parentUri.AbsoluteUri

        member this.parentDirectoryPathTokens =
            directoryPathTokens_from_uriSegments parentUri.Segments

        member this.childDirectoryPaths = childDirectoryPaths }
