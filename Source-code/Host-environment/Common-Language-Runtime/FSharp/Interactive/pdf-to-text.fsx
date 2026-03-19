#r "nuget: PdfPig"

open System
open System.IO
open UglyToad.PdfPig
open UglyToad.PdfPig.Content
open UglyToad.PdfPig.Util
open UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor

type ExtractedWord =
    { Text: string
      BoundingBoxLeft: float
      BoundingBoxBottom: float
      BoundingBoxRight: float
      BoundingBoxTop: float }

type ExtractedLine =
    { Text: string
      Y: float
      Words: ExtractedWord list }

type PageInspection =
    { PageNumber: int
      Width: float
      Height: float
      RawText: string
      Words: ExtractedWord list
      Lines: ExtractedLine list }

let private round2 (x: float) = Math.Round(x, 2)

let private fail message = invalidOp message

let openPdf (path: string) =
    if String.IsNullOrWhiteSpace path then
        fail "PDF path is empty."
    elif not (File.Exists path) then
        fail $"PDF file does not exist: {path}"
    else
        PdfDocument.Open(path)

let getPage (document: PdfDocument) (pageNumber: int) =
    if pageNumber < 1
       || pageNumber > document.NumberOfPages then
        fail $"Page {pageNumber} is out of range. Document has {document.NumberOfPages} pages."
    else
        document.GetPage(pageNumber)

let getRawText (page: Page) = ContentOrderTextExtractor.GetText(page)

let getWords (page: Page) =
    page.GetWords()
    |> Seq.map (fun word ->
        let box = word.BoundingBox

        { Text = word.Text
          BoundingBoxLeft = box.Left
          BoundingBoxBottom = box.Bottom
          BoundingBoxRight = box.Right
          BoundingBoxTop = box.Top })
    |> Seq.toList

let private groupWordsIntoLines (words: ExtractedWord list) =
    // Strategy:
    // 1. Sort visually from top-to-bottom, left-to-right.
    // 2. Group words whose vertical centers are sufficiently close.
    // 3. Re-sort each line left-to-right.
    //
    // This is deliberately simple and inspectable, not universally perfect.
    let centerY (w: ExtractedWord) =
        (w.BoundingBoxTop + w.BoundingBoxBottom) / 2.0

    let averageHeight =
        words
        |> List.map (fun w -> abs (w.BoundingBoxTop - w.BoundingBoxBottom))
        |> function
            | [] -> 12.0
            | hs -> List.average hs

    let yTolerance = max 3.0 (averageHeight * 0.5)

    let sorted =
        words
        |> List.sortBy (fun w -> (-centerY w), w.BoundingBoxLeft)

    let folder (lines: ResizeArray<ResizeArray<ExtractedWord * float>>) (word: ExtractedWord) =
        let cy = centerY word

        let mutable placed = false

        for line in lines do
            let lineYs = line |> Seq.map snd |> Seq.toArray
            let avgY = Array.average lineYs

            if abs (cy - avgY) <= yTolerance && not placed then
                line.Add(word, cy)
                placed <- true

        if not placed then
            let newLine = ResizeArray()
            newLine.Add(word, cy)
            lines.Add(newLine)

        lines

    let grouped =
        sorted
        |> List.fold folder (ResizeArray())
        |> Seq.map (fun line ->
            let items =
                line
                |> Seq.map fst
                |> Seq.sortBy (fun w -> w.BoundingBoxLeft)
                |> Seq.toList

            let lineY = items |> List.map centerY |> List.average

            { Text =
                items
                |> List.map (fun w -> w.Text)
                |> String.concat " "
              Y = lineY
              Words = items })
        |> Seq.sortByDescending (fun line -> line.Y)
        |> Seq.toList

    grouped

let inspectPage (document: PdfDocument) (pageNumber: int) =
    let page = getPage document pageNumber
    let words = getWords page
    let lines = groupWordsIntoLines words

    { PageNumber = pageNumber
      Width = page.Width
      Height = page.Height
      RawText = getRawText page
      Words = words
      Lines = lines }

let printPageSummary (inspection: PageInspection) =
    printfn "Page %d" inspection.PageNumber
    printfn "Size: %.2f x %.2f" (round2 inspection.Width) (round2 inspection.Height)
    printfn "Words: %d" inspection.Words.Length
    printfn "Lines: %d" inspection.Lines.Length

let printRawText (inspection: PageInspection) =
    printfn "----- RAW TEXT: PAGE %d -----" inspection.PageNumber
    printfn "%s" inspection.RawText

let printLines (inspection: PageInspection) =
    printfn "----- LINES: PAGE %d -----" inspection.PageNumber

    inspection.Lines
    |> List.iteri (fun i line -> printfn "[%03d] y=%.2f  %s" (i + 1) (round2 line.Y) line.Text)

let printWords (inspection: PageInspection) =
    printfn "----- WORDS: PAGE %d -----" inspection.PageNumber

    inspection.Words
    |> List.sortBy (fun w -> (-(w.BoundingBoxTop + w.BoundingBoxBottom) / 2.0), w.BoundingBoxLeft)
    |> List.iteri (fun i w ->
        printfn
            "[%03d] %-30s  L=%.2f B=%.2f R=%.2f T=%.2f"
            (i + 1)
            w.Text
            (round2 w.BoundingBoxLeft)
            (round2 w.BoundingBoxBottom)
            (round2 w.BoundingBoxRight)
            (round2 w.BoundingBoxTop))

let inspectAllPages (document: PdfDocument) =
    [ 1 .. document.NumberOfPages ]
    |> List.map (inspectPage document)

let printDocumentSummary (document: PdfDocument) =
    printfn "Pages: %d" document.NumberOfPages

    [ 1 .. document.NumberOfPages ]
    |> List.iter (fun pageNumber ->
        let inspection = inspectPage document pageNumber

        printfn
            "Page %d -> size=%.2f x %.2f, words=%d, lines=%d"
            inspection.PageNumber
            (round2 inspection.Width)
            (round2 inspection.Height)
            inspection.Words.Length
            inspection.Lines.Length)

let exportLinesAsTsv (inspection: PageInspection) (outputPath: string) =
    let escape (s: string) =
        s
            .Replace("\t", " ")
            .Replace("\r", " ")
            .Replace("\n", " ")

    use writer = new StreamWriter(outputPath, false)
    writer.WriteLine("line_index\ty\ttext")

    inspection.Lines
    |> List.iteri (fun i line -> writer.WriteLine($"{i + 1}\t{round2 line.Y}\t{escape line.Text}"))

    outputPath

let exportWordsAsTsv (inspection: PageInspection) (outputPath: string) =
    let escape (s: string) =
        s
            .Replace("\t", " ")
            .Replace("\r", " ")
            .Replace("\n", " ")

    use writer = new StreamWriter(outputPath, false)
    writer.WriteLine("word_index\ttext\tleft\tbottom\tright\ttop")

    inspection.Words
    |> List.iteri (fun i w ->
        writer.WriteLine(
            $"{i + 1}\t{escape w.Text}\t{round2 w.BoundingBoxLeft}\t{round2 w.BoundingBoxBottom}\t{round2 w.BoundingBoxRight}\t{round2 w.BoundingBoxTop}"
        ))

    outputPath

let extractPdfTextToFile (pdfPath: string) (outputTextPath: string) =
    use document = PdfDocument.Open(pdfPath)

    let allText =
        [ for pageNumber in 1 .. document.NumberOfPages do
              let page = document.GetPage(pageNumber)
              yield ContentOrderTextExtractor.GetText(page) ]
        |> String.concat "\n\n"

    File.WriteAllText(outputTextPath, allText)

let pdfRootDirectoryPath =
    @"D:\Surface\Company\Environmental_Systems_Research_Institute\Reference"

let pdfFilePaths =
    Directory.EnumerateFiles(pdfRootDirectoryPath, "*.pdf", SearchOption.AllDirectories)

pdfFilePaths
|> Seq.iter (fun pdfFilePath ->

    printfn "Opening: %s" pdfFilePath

    let pdfDirectoryPath = (Directory.GetParent pdfFilePath).FullName
    let pdfFileStem = Path.GetFileNameWithoutExtension pdfFilePath
    let tsvFilePath = Path.Combine(pdfDirectoryPath, $"{pdfFileStem}.txt")


    extractPdfTextToFile pdfFilePath tsvFilePath

)
