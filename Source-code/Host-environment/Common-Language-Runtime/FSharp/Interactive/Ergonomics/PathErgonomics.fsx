open System
open System.Reflection
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





let pathSegments (segments: string array) =
    segments
    |> Array.filter (fun segment -> segment <> "/")
    |> Array.map (fun segment ->

        let trimmedSegment = segment.TrimEnd('/')
        let decodedSegment = WebUtility.UrlDecode(trimmedSegment)
        decodedSegment

    )

type LocalPathIntroduction =
    {

      absolutePath: string

     }


type LocalPath =
    {

      Name: System.String
      Drive: DriveInfo option
      ExistsAsDirectory: bool
      ExistsAsFile: bool
      ParentDirectory: System.IO.DirectoryInfo
      Root: System.IO.DirectoryInfo
      Length: System.Int64
      DirectoryName: System.String
      Directory: System.IO.DirectoryInfo
      IsReadOnly: System.Boolean
      FullName: System.String
      Extension: System.String
      CreationTime: System.DateTime
      CreationTimeUtc: System.DateTime
      LastAccessTime: System.DateTime
      LastAccessTimeUtc: System.DateTime
      LastWriteTime: System.DateTime
      LastWriteTimeUtc: System.DateTime
      LinkTarget: System.String option
      UnixFileMode: System.IO.UnixFileMode
      Attributes: System.IO.FileAttributes

      AbsolutePath: System.String
      AbsoluteUri: System.String
      LocalPath: System.String
      Authority: System.String option
      HostNameType: System.UriHostNameType
      IsDefaultPort: System.Boolean
      IsFileScheme: System.Boolean
      IsLoopback: System.Boolean
      PathAndQuery: System.String
      PathSegments: System.String []
      NameSegments: string array
      IsUnc: System.Boolean
      Host: System.String option
      Port: System.Int32
      Query: System.String option
      Fragment: System.String option
      Scheme: System.String
      OriginalString: System.String
      DnsSafeHost: System.String option
      IdnHost: System.String option
      IsAbsoluteUri: System.Boolean
      UserEscaped: System.Boolean
      UserInfo: System.String option

     }
    member this.SegmentTokensFromRootDirectory(rootPathString: string) =
        let rootUri = new Uri(rootPathString)


        let secondToLastIndex = this.PathSegments.Length - 2

        let relativeStartIndex = rootUri.Segments.Length - 1

        let relativeSegments =
            this.PathSegments[relativeStartIndex..secondToLastIndex]
            |> Array.toList

        let pathSegmentList =
            relativeSegments
            @ Array.toList (this.NameSegments)

        pathSegmentList |> List.toArray

    static member inhabitant(introduction: LocalPathIntroduction) =
        let clrUri = new Uri(introduction.absolutePath)

        let clrDriveInfo =
            try
                Some(new DriveInfo(introduction.absolutePath))
            with
            | _ -> None

        let clrFileInfo = new FileInfo(introduction.absolutePath)
        let clrDirectoryInfo = new DirectoryInfo(introduction.absolutePath)
        let clrUri = new Uri(introduction.absolutePath)

        let nameSegments = clrFileInfo.Name.Split(".")





        {


          Name = clrDirectoryInfo.Name
          Drive = clrDriveInfo
          ExistsAsDirectory = clrDirectoryInfo.Exists
          ExistsAsFile = clrFileInfo.Exists
          ParentDirectory = clrDirectoryInfo.Parent
          Root = clrDirectoryInfo.Root
          Length =
            if clrFileInfo.Exists then
                clrFileInfo.Length
            else
                0
          DirectoryName = clrFileInfo.DirectoryName
          Directory = clrFileInfo.Directory
          IsReadOnly = clrFileInfo.IsReadOnly
          FullName = clrDirectoryInfo.FullName
          Extension = clrDirectoryInfo.Extension
          CreationTime = clrDirectoryInfo.CreationTime
          CreationTimeUtc = clrDirectoryInfo.CreationTimeUtc
          LastAccessTime = clrDirectoryInfo.LastAccessTime
          LastAccessTimeUtc = clrDirectoryInfo.LastAccessTimeUtc
          LastWriteTime = clrDirectoryInfo.LastWriteTime
          LastWriteTimeUtc = clrDirectoryInfo.LastWriteTimeUtc
          LinkTarget =
            if clrDirectoryInfo.LinkTarget = null then
                None
            else
                Some(clrDirectoryInfo.LinkTarget)
          UnixFileMode = clrDirectoryInfo.UnixFileMode
          Attributes = clrDirectoryInfo.Attributes
          AbsolutePath = clrUri.AbsolutePath
          AbsoluteUri = clrUri.AbsoluteUri
          LocalPath = clrUri.LocalPath
          Authority = nonEmptyString clrUri.Authority
          HostNameType = clrUri.HostNameType
          IsDefaultPort = clrUri.IsDefaultPort
          IsFileScheme = clrUri.IsFile
          IsLoopback = clrUri.IsLoopback
          PathAndQuery = clrUri.PathAndQuery
          PathSegments = pathSegments clrUri.Segments
          NameSegments = nameSegments
          IsUnc = clrUri.IsUnc
          Host = nonEmptyString clrUri.Host
          Port = clrUri.Port
          Query = nonEmptyString clrUri.Query
          Fragment = nonEmptyString clrUri.Fragment
          Scheme = clrUri.Scheme
          OriginalString = clrUri.OriginalString
          DnsSafeHost = nonEmptyString clrUri.DnsSafeHost
          IdnHost = nonEmptyString clrUri.IdnHost
          IsAbsoluteUri = clrUri.IsAbsoluteUri
          UserEscaped = clrUri.UserEscaped
          UserInfo = nonEmptyString clrUri.UserInfo
        // ChildTracePath = childTracePath


        }


    member this.AncestorDirectories (rootAncestorPathString: string) (directoryTrace: LocalPath List) : LocalPath List =




        if this.ParentDirectory.FullName
           <> rootAncestorPathString then
            let parentPath =
                LocalPath.inhabitant { absolutePath = this.ParentDirectory.FullName }

            parentPath.AncestorDirectories rootAncestorPathString (parentPath :: directoryTrace)
        else
            // let rootPath = LocalPathInfo.inhabitant this.ParentDirectory.FullName (Some(this))
            // rootPath :: directoryTrace
            directoryTrace




































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




let getAllInterfacePropertiesOrdered (interfaceType: Type) =
    if not interfaceType.IsInterface then
        invalidArg (nameof interfaceType) "Expected an interface type."

    seq {
        yield interfaceType
        yield! interfaceType.GetInterfaces()
    }
    |> Seq.collect (fun currentInterfaceType ->
        currentInterfaceType.GetProperties(BindingFlags.Instance ||| BindingFlags.Public))
    |> Seq.distinctBy (fun property ->
        property.Name, property.PropertyType, property.GetIndexParameters() |> Array.length)
    |> Seq.sortBy (fun property -> property.Name)
    |> Seq.toArray










let getAllInterfaceProperties (interfaceType: Type) =
    if not interfaceType.IsInterface then
        invalidArg (nameof interfaceType) "Expected an interface type."

    seq {
        yield interfaceType
        yield! interfaceType.GetInterfaces()
    }
    |> Seq.collect (fun currentInterfaceType ->
        currentInterfaceType.GetProperties(BindingFlags.Instance ||| BindingFlags.Public))
    |> Seq.distinctBy (fun property ->
        property.Name, property.PropertyType, property.GetIndexParameters() |> Array.length)
    |> Seq.toArray






type DriveVolume =
    abstract member fileSystemName: String
    abstract member volumeName: String
    abstract member volumeLabel: String
    abstract member totalSize: Int64
    abstract member totalFreeSpace: Int64
    abstract member availableFreeSpace: Int64
    abstract member driveType: DriveType
    abstract member isReady: Boolean

type FileSystemEntryPath =
    abstract member driveVolumeName: string
    abstract member creationTimeUtc: DateTime
    abstract member fileSystemEntryAttribute: FileSystemEntryAttribute
    abstract member unixFileSystemPermission: UnixFileSystemPermission
    abstract member exists: bool
    abstract member lastAccessTimeUtc: System.DateTime
    abstract member lastWriteTimeUtc: System.DateTime


type DirectoryPath =
    inherit FileSystemEntryPath
    abstract member directoryName: string
    abstract member absoluteDirectoryPathString: string

type FilePath =
    inherit FileSystemEntryPath
    abstract member fileName: string
    abstract member extension: string
    abstract member stem: string
    abstract member directoryPath: DirectoryPath
    abstract member absoluteFilePathString: string


type ParentDirectoryPath =
    inherit DirectoryPath
    abstract member childDirectoryPaths: ChildDirectoryPath array

and ChildDirectoryPath =
    inherit DirectoryPath
    abstract member parentDirectoryPath: DirectoryPath




let inspect<'InterfaceType> (interfaceObject: 'InterfaceType) =
    let interfaceType = typeof<'InterfaceType>

    getAllInterfacePropertiesOrdered interfaceType
    |> Array.iter (fun property ->
        let value =
            try
                property.GetValue(interfaceObject, null)
            with
            | ex -> $"<error: {ex.Message}>"

        printfn "%s = %A" property.Name value)




let DirectoryPath_from_string (directoryPathString: string) =

    let directoryInfo = new DirectoryInfo(directoryPathString)

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
        member this.directoryName = directoryInfo.Name
        member this.absoluteDirectoryPathString = directoryInfo.FullName }



let ChildDirectory_from_DirectoryPath (directoryPath: DirectoryPath) =
    let parentDirectoryInfo =
        Directory.GetParent(directoryPath.absoluteDirectoryPathString)


    { new ChildDirectoryPath with
        member this.driveVolumeName = directoryPath.driveVolumeName
        member this.creationTimeUtc = directoryPath.creationTimeUtc

        member this.fileSystemEntryAttribute = directoryPath.fileSystemEntryAttribute
        member this.unixFileSystemPermission = directoryPath.unixFileSystemPermission
        member this.exists = directoryPath.exists
        member this.lastAccessTimeUtc = directoryPath.lastAccessTimeUtc
        member this.lastWriteTimeUtc = directoryPath.lastWriteTimeUtc
        member this.directoryName = directoryPath.directoryName
        member this.absoluteDirectoryPathString = directoryPath.absoluteDirectoryPathString

        member this.parentDirectoryPath =
            DirectoryPath_from_string parentDirectoryInfo.FullName }


(*
let ParentChildDirectoryPaths_from_DirectoryPath(directoryPath:DirectoryPath) =

    let parentDirectoryPathString = Directory.GetParent(directoryPath.asString)
    let directoryInfo = new DirectoryInfo(parentDirectoryPathString)

    let parentDirectoryPathString =
        if directoryInfo.Parent = null then
            directoryPathString
        else
            directoryInfo.Parent.FullName

*)
let FilePath_from_string (filePathString: string) =
    let fileInfo = new FileInfo(filePathString)

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
        member this.directoryPath = DirectoryPath_from_string fileInfo.DirectoryName
        member this.fileName = fileInfo.Name
        member this.absoluteFilePathString = fileInfo.FullName }

let testFilePathString =
    @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData\MetaData.xml"

let testFilePathString'FileInfo = new FileInfo(testFilePathString)
new DriveInfo(testFilePathString)
let testFilePathString'DirectoryInfo = new DirectoryInfo(testFilePathString)
let testFilePathString'Uri = new Uri(testFilePathString)
// if testFilePathString'FileInfo.Exists && not testFilePathString'DirectoryInfo.Exists then

let testFilePathString'FilePath = FilePath_from_string testFilePathString


let testDirectoryPathString =
    @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\Deployment Files\MetaData"

let testDirectoryPathString'FileInfo = new FileInfo(testDirectoryPathString)


let testDirectoryPathString'DirectoryInfo =
    new DirectoryInfo(testDirectoryPathString)

testDirectoryPathString'DirectoryInfo.Name

let testDirectoryPathString'Uri = new Uri(testDirectoryPathString)
// if testDirectoryPathString'FileInfo.Exists && not testDirectoryPathString'DirectoryInfo.Exists then
let testDirectoryPathString'FilePath =
    DirectoryPath_from_string testDirectoryPathString


inspect<FilePath> testFilePathString'FilePath
let testFilePathString'DirectoryPath = ChildDirectory_from_DirectoryPath testFilePathString'FilePath.directoryPath
inspect<ChildDirectoryPath> testFilePathString'DirectoryPath

testFilePathString'DirectoryPath.GetType().GetInterfaces()
|> Array.map (fun interfaceType -> interfaceType.Name)


inspect<DirectoryPath> testDirectoryPathString'FilePath
