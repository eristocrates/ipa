#if INTERACTIVE

#endif

open System
open PdfSharp.Fonts

// Must run before any font operation / document creation.
// Must be run interactively only once
// GlobalFontSettings.UseWindowsFontsUnderWindows <- true

open MigraDoc.DocumentObjectModel
open MigraDoc.Rendering

let writeHelloPdf (outputPath: string) =
    let doc = Document()
    doc.Info.Title <- "Hello PDF (MigraDoc from F#)"

    let section = doc.AddSection()
    let p = section.AddParagraph("Hello PDF")
    p.Format.Font.Name <- "Verdana"
    p.Format.Font.Size <- 24.0
    p.Format.Font.Bold <- true

    section.AddParagraph("Generated with MigraDoc + PDFsharp from F#.") |> ignore

    // No bool parameter in 6.x (Unicode is always on)
    let renderer = PdfDocumentRenderer()
    renderer.Document <- doc
    renderer.RenderDocument()
    renderer.PdfDocument.Save(outputPath)

writeHelloPdf "artifacts/adhoc/hello.pdf"
