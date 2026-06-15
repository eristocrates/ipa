open System
open System.IO

#r "nuget: Tabula"
#r "nuget: Tabula.Json"
#r "nuget: Tabula.Csv"
#r "nuget: FSharp.Data"

open Tabula
open Tabula.Extractors
open UglyToad.PdfPig

let sanitizeCellText (text: string) =
    text
        .Replace("\t", " ")
        .Replace("\r", " ")
        .Replace("\n", " ")
        .Trim()

let tableHasMeaningfulContent (table: Table) =
    table.Rows
    |> Seq.collect id
    |> Seq.exists (fun cell ->
        let text = sanitizeCellText (cell.GetText())
        not (String.IsNullOrWhiteSpace text))

let writeTableAsTsv (table: Table) (outputPath: string) =
    use writer = new StreamWriter(outputPath, false)

    for row in table.Rows do
        row
        |> Seq.map (fun cell -> sanitizeCellText (cell.GetText()))
        |> String.concat "\t"
        |> writer.WriteLine

let csvEscape (text: string) =
    let escaped = sanitizeCellText (text.Replace("\"", "\"\""))

    $"\"{escaped}\""

let writeTableAsCsv (table: Table) (outputPath: string) =
    use writer = new StreamWriter(outputPath, false)

    for row in table.Rows do
        row
        |> Seq.map (fun cell -> csvEscape (cell.GetText()))
        |> String.concat ","
        |> writer.WriteLine

let extractTablesToDirectory (pdfPath: string) (outputDirectory: string) =
    Directory.CreateDirectory(outputDirectory)
    |> ignore

    use document = PdfDocument.Open(pdfPath)

    // For ruled/grid tables.
    // Switch to BasicExtractionAlgorithm() for whitespace-aligned tables.
    let extractor = SpreadsheetExtractionAlgorithm()

    for pageNumber in 1 .. document.NumberOfPages do
        let page = ObjectExtractor.Extract(document, pageNumber)
        let tables = extractor.Extract(page)

        for tableIndex, table in tables |> Seq.indexed do
            if tableHasMeaningfulContent table then
                let fileName = $"Page_{pageNumber}_Table_{tableIndex + 1}.tsv"

                let outputPath = Path.Combine(outputDirectory, fileName)

                writeTableAsTsv table outputPath

                printfn "Wrote %s" outputPath
            else
                printfn "Skipped empty table on page %d table %d" pageNumber (tableIndex + 1)

extractTablesToDirectory
    @"D:\Surface\Company\Environmental_Systems_Research_Institute\Esri_Reference\ESRI Metadata Profile.pdf"
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\LMDB\Esri_Metadata_Profile"
