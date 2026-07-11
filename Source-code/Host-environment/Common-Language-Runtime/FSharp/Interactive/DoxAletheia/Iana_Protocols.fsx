#r "nuget: FluentFTP, 54.2.0"

open System
open System.IO
open System.Net
open FluentFTP

let localDirectory =
    @"D:\Surface\Standards\Internet_Assigned_Numbers_Authority\Protocols"

let ftpHost = "ftp.iana.org"

let remoteDirectory = "/assignments"

Directory.CreateDirectory(localDirectory)
|> ignore

let client = new FtpClient(ftpHost)

// Anonymous FTP.
// The password convention is usually an email-like string.
client.Credentials <- NetworkCredential("anonymous", "anonymous@example.com")

client.Connect()

let results =
    client.DownloadDirectory(localDirectory, remoteDirectory, FtpFolderSyncMode.Mirror, FtpLocalExists.Overwrite, FtpVerify.None)

client.Disconnect()

let downloaded =
    results
    |> Seq.filter (fun r -> r.IsSuccess)
    |> Seq.length

let failed =
    results
    |> Seq.filter (fun r -> r.IsFailed)
    |> Seq.toArray

printfn "Downloaded or confirmed %i FTP objects into: %s" downloaded localDirectory

if failed.Length > 0 then
    printfn "Failed objects:"
    failed
    |> Seq.iter (fun r ->
        printfn "  %s -> %s" r.RemotePath r.LocalPath
        if not (isNull r.Exception) then
            printfn "    %s" r.Exception.Message)

    failwithf "FTP sync completed with %i failed objects." failed.Length

(*
Downloaded or confirmed 9037 FTP objects into: D:\Surface\Standards\Internet_Assigned_Numbers_Authority\Protocols
Failed objects:
  /assignments/collation/i;ascii-casemap.xml -> D:\Surface\Standards\Internet_Assigned_Numbers_Authority\Protocols\collation\i;ascii-casemap.xml
    The FTP path "/assignments/collation/i;ascii-casemap.xml" contains unix commands or newlines that might be used for FTP injection attacks! Set `SanitizeControlChars` to `false` to allow unix commands or newlines, or set `SanitizerMode` to `FtpSanitize.Rename` to silently cleanup such sequences.
  /assignments/collation/i;ascii-numeric.xml -> D:\Surface\Standards\Internet_Assigned_Numbers_Authority\Protocols\collation\i;ascii-numeric.xml
    The FTP path "/assignments/collation/i;ascii-numeric.xml" contains unix commands or newlines that might be used for FTP injection attacks! Set `SanitizeControlChars` to `false` to allow unix commands or newlines, or set `SanitizerMode` to `FtpSanitize.Rename` to silently cleanup such sequences.
  /assignments/collation/i;octet.xml -> D:\Surface\Standards\Internet_Assigned_Numbers_Authority\Protocols\collation\i;octet.xml
    The FTP path "/assignments/collation/i;octet.xml" contains unix commands or newlines that might be used for FTP injection attacks! Set `SanitizeControlChars` to `false` to allow unix commands or newlines, or set `SanitizerMode` to `FtpSanitize.Rename` to silently cleanup such sequences.
  /assignments/collation/i;unicode-casemap.xml -> D:\Surface\Standards\Internet_Assigned_Numbers_Authority\Protocols\collation\i;unicode-casemap.xml
    The FTP path "/assignments/collation/i;unicode-casemap.xml" contains unix commands or newlines that might be used for FTP injection attacks! Set `SanitizeControlChars` to `false` to allow unix commands or newlines, or set `SanitizerMode` to `FtpSanitize.Rename` to silently cleanup such sequences.

*)
