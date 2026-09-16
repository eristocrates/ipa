#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text
open System.Threading
open System.Threading.Tasks

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"

open Ipa

#r "Iana.dll"
open Iana
#r "IanaScheme.dll"
#r "ResolvedResource.dll"
#r "ManualDistributions.dll"
open ManualDistributions

open PuppeteerSharp.Cdp
open PuppeteerSharp
open Meziantou.Framework
open VDS.RDF
open VDS.RDF.Parsing


open VDS.RDF.Parsing
open System.Text
open VDS.RDF.Writing.Formatting
open VDS.RDF.Writing
open VDS.RDF.Parsing.Handlers
open System.IO.Compression




let syntax = {
    syntaxName = "NQuads"
    fileExtension = ".nq"
}
let decompressNqGzipFile (nqgzipFile: FileInfo) =

    if not (File.Exists nqgzipFile.FullName) then
        raise (FileNotFoundException("The N-Quads gzip file does not exist.", nqgzipFile.FullName))

    if not (nqgzipFile.Name.EndsWith(".nq.gz", StringComparison.OrdinalIgnoreCase)) then
        invalidArg (nameof nqgzipFile) $"Expected an .nq.gz file, received {nqgzipFile.Name}."

    // Removes only the final ".gz":
    // foo.nq.gz -> foo.nq
    let nqFile = Path.ChangeExtension(nqgzipFile.FullName, null) |> FileInfo

    // Do not expose a partially-written "clean" .nq file.
    let temporaryFile = Path.Combine(nqFile.DirectoryName, Path.GetRandomFileName()) |> FileInfo

    let parser = NQuadsParser()
    let handler = NullHandler()

    let mutable kept = 0L
    let mutable rejected = 0L
    let mutable repaired = 0L

    try
        do
            use sourceStream = nqgzipFile.OpenRead()

            use gzipStream = new GZipStream(sourceStream, CompressionMode.Decompress)

            use reader = new StreamReader(gzipStream, utf8Encoding, detectEncodingFromByteOrderMarks = true)

            use writer = new StreamWriter(temporaryFile.FullName, append = false, encoding = utf8Encoding)

            while not reader.EndOfStream do
                let line = reader.ReadLine()

                if not (String.IsNullOrWhiteSpace line) then
                    let normalizedLine = line.normalizeEscapedSurrogatePairs

                    if not (Object.ReferenceEquals(normalizedLine, line)) && normalizedLine <> line then
                        repaired <- repaired + 1L

                    try
                        use lineReader = new StringReader(normalizedLine)

                        parser.Load(handler, lineReader)

                        writer.WriteLine(normalizedLine)
                        kept <- kept + 1L

                    with :? RdfParseException ->
                        rejected <- rejected + 1L

        File.Move(temporaryFile.FullName, nqFile.FullName, overwrite = true)

        // File.Delete(nqgzipFile.FullName)

        printfn "Created %s — kept %i statements; repaired %i lines; rejected %i invalid statements." nqFile.FullName kept repaired rejected

        FileInfo(nqFile.FullName)

    with _ ->
        if File.Exists temporaryFile.FullName then
            File.Delete temporaryFile.FullName

        reraise ()
