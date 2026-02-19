open System
open System.IO
open System.Text
open System.Globalization

open UglyToad.PdfPig
open UglyToad.PdfPig.Content

// --------------------------
// 0) Paths (your conventions)
// --------------------------
let rootFolder = Directory.GetParent(Directory.GetCurrentDirectory()).FullName
let pdfFolder = Path.Combine(rootFolder, "surfaces", "pdfs")

let outFolder =
    Path.Combine(rootFolder, "rdfsharpconsole", "artifacts", "adhoc", "pdfpig-inspect")

Directory.CreateDirectory(outFolder) |> ignore

let pdfPath = Path.Combine(pdfFolder, "pub_2025.x_basics_user__en-us.pdf")

if not (File.Exists(pdfPath)) then
    failwith $"PDF not found at: {pdfPath}"

// --------------------------
// 1) Configuration
// --------------------------
// Choose which page to inspect (1-based).
let pageNumber = 10

// Scale factor for the HTML view.
// 1.0 means 1 PDF unit (point) = 1 CSS pixel.
// If the page is large, try 1.25 or 1.5.
let scale = 1.25

// Limit how many letters we render, to avoid massive HTML on dense pages.
// Set to Int32.MaxValue to render all letters.
let maxLettersToRender = Int32.MaxValue

// --------------------------
// 2) Helpers
// --------------------------
let inv (y: float) = y // placeholder, kept for readability

let invariant (x: float) =
    x.ToString("0.###", CultureInfo.InvariantCulture)

let htmlEscape (s: string) =
    s.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&#39;")

// Convert PDF coords (origin bottom-left) to CSS coords (origin top-left).
// PDF: (0,0) at bottom-left.
// CSS: (0,0) at top-left.
// So: cssTop = pageHeight - pdfTop
let pdfToCssTop (pageHeight: float) (pdfTop: float) = pageHeight - pdfTop

// --------------------------
// 3) Extract primitives
// --------------------------
use doc = PdfDocument.Open(pdfPath)

printfn "Opened: %s" pdfPath
printfn "Pages: %d" doc.NumberOfPages

let page = doc.GetPage(pageNumber)
printfn "Inspect page %d: width=%f height=%f" pageNumber page.Width page.Height

let letters = page.Letters |> Seq.truncate maxLettersToRender |> Seq.toArray
printfn "Letters (truncated to %d): %d" maxLettersToRender letters.Length

// --------------------------
// 4) Build inspectable HTML
// --------------------------
let pageWidthCss = page.Width * scale
let pageHeightCss = page.Height * scale

let sb = StringBuilder()

sb.AppendLine("<!doctype html>") |> ignore
sb.AppendLine("<html>") |> ignore
sb.AppendLine("<head>") |> ignore
sb.AppendLine("<meta charset=\"utf-8\"/>") |> ignore

sb.AppendLine("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>")
|> ignore

sb.AppendLine("<title>PdfPig Inspect</title>") |> ignore

// Minimal styling: a page container, and per-letter overlay boxes.
// We intentionally do NOT attempt to “reflow” or make semantic structure.
// This is an inspection artifact: show what PdfPig says exists, where.
sb.AppendLine("<style>") |> ignore

sb.AppendLine("  body { font-family: system-ui, -apple-system, Segoe UI, Roboto, sans-serif; margin: 16px; }")
|> ignore

sb.AppendLine("  .meta { margin-bottom: 12px; }") |> ignore

sb.AppendLine("  .page { position: relative; background: white; border: 1px solid #999; }")
|> ignore

sb.AppendLine("  .letter-box {") |> ignore
sb.AppendLine("    position: absolute;") |> ignore
sb.AppendLine("    border: 1px solid rgba(255,0,0,0.45);") |> ignore
sb.AppendLine("    background: rgba(255,0,0,0.08);") |> ignore
sb.AppendLine("    box-sizing: border-box;") |> ignore
sb.AppendLine("    pointer-events: auto;") |> ignore
sb.AppendLine("  }") |> ignore
sb.AppendLine("  .glyph {") |> ignore
sb.AppendLine("    position: absolute;") |> ignore
sb.AppendLine("    color: rgba(0,0,0,0.85);") |> ignore
sb.AppendLine("    white-space: pre;") |> ignore
sb.AppendLine("    pointer-events: none;") |> ignore
sb.AppendLine("  }") |> ignore

sb.AppendLine("  .letter-box:hover { outline: 2px solid rgba(0,0,255,0.65); }")
|> ignore

sb.AppendLine("  .table { margin-top: 16px; border-collapse: collapse; }")
|> ignore

sb.AppendLine("  .table th, .table td { border: 1px solid #ccc; padding: 4px 6px; font-size: 12px; }")
|> ignore

sb.AppendLine("  .small { font-size: 12px; color: #333; }") |> ignore
sb.AppendLine("</style>") |> ignore

sb.AppendLine("</head>") |> ignore
sb.AppendLine("<body>") |> ignore

sb.AppendLine("<div class=\"meta\">") |> ignore

sb.AppendLine($"  <div><strong>PDF:</strong> {htmlEscape pdfPath}</div>")
|> ignore

sb.AppendLine($"  <div><strong>Page:</strong> {pageNumber} / {doc.NumberOfPages}</div>")
|> ignore

sb.AppendLine($"  <div><strong>PDF size:</strong> {invariant page.Width} × {invariant page.Height} (PDF units)</div>")
|> ignore

sb.AppendLine($"  <div><strong>Scale:</strong> {invariant scale} (CSS px per PDF unit)</div>")
|> ignore

sb.AppendLine($"  <div><strong>Letters rendered:</strong> {letters.Length}</div>")
|> ignore

sb.AppendLine(
    "  <div class=\"small\">Hover boxes to see the tooltip; this is the direct inventory of glyph placements (PdfPig letters).</div>"
)
|> ignore

sb.AppendLine("</div>") |> ignore

sb.AppendLine($"<div class=\"page\" style=\"width:{invariant pageWidthCss}px; height:{invariant pageHeightCss}px;\">")
|> ignore

// For each letter, place:
// - A red translucent rectangle (bounding box)
// - The glyph itself at approximately the same top-left
// Tooltip includes index, glyph, bbox, font size (when available)
letters
|> Array.iteri (fun i l ->
    let bb = l.GlyphRectangle // PdfPig's rectangle for the glyph (in PDF coords)
    // Some PdfPig types also expose BoundingBox; GlyphRectangle is the more direct one for glyph placement.

    let leftCss = bb.Left * scale
    let topCss = (pdfToCssTop page.Height bb.Top) * scale
    let widthCss = (bb.Right - bb.Left) * scale
    let heightCss = (bb.Top - bb.Bottom) * scale

    let glyphText = l.Value.ToString()

    let tooltip =
        $"#{i + 1} '{glyphText}' | L={invariant bb.Left} B={invariant bb.Bottom} R={invariant bb.Right} T={invariant bb.Top}"

    // Bounding box
    sb.AppendLine(
        $"<div class=\"letter-box\" "
        + $"style=\"left:{invariant leftCss}px; top:{invariant topCss}px; width:{invariant widthCss}px; height:{invariant heightCss}px;\" "
        + $"title=\"{htmlEscape tooltip}\"></div>"
    )
    |> ignore

    // Glyph overlay: we set font-size to the box height as a crude visual approximation.
    // This is NOT “correct rendering”; it is just to help correlate boxes with characters.
    // The true source-of-truth remains the rectangle itself.
    let fontSizeCss = max 6.0 (heightCss * 0.95)

    sb.AppendLine(
        $"<div class=\"glyph\" "
        + $"style=\"left:{invariant leftCss}px; top:{invariant topCss}px; font-size:{invariant fontSizeCss}px;\">"
        + $"{htmlEscape glyphText}</div>"
    )
    |> ignore)

sb.AppendLine("</div>") |> ignore

// Also include a small tabular listing of the first N letters so you can inspect numerically.
let tableCount = min 200 letters.Length
sb.AppendLine("<h3>First letters (tabular)</h3>") |> ignore

sb.AppendLine(
    $"<div class=\"small\">Showing first {tableCount} letters (of {letters.Length}). Indices match the overlay tooltips.</div>"
)
|> ignore

sb.AppendLine("<table class=\"table\">") |> ignore

sb.AppendLine("<thead><tr><th>#</th><th>Glyph</th><th>Left</th><th>Bottom</th><th>Right</th><th>Top</th></tr></thead>")
|> ignore

sb.AppendLine("<tbody>") |> ignore

letters
|> Seq.truncate tableCount
|> Seq.iteri (fun i l ->
    let bb = l.GlyphRectangle

    sb.AppendLine(
        "<tr>"
        + $"<td>{i + 1}</td>"
        + $"<td>{htmlEscape (l.Value.ToString())}</td>"
        + $"<td>{invariant bb.Left}</td>"
        + $"<td>{invariant bb.Bottom}</td>"
        + $"<td>{invariant bb.Right}</td>"
        + $"<td>{invariant bb.Top}</td>"
        + "</tr>"
    )
    |> ignore)

sb.AppendLine("</tbody></table>") |> ignore

sb.AppendLine("</body></html>") |> ignore

let outPath = Path.Combine(outFolder, $"inspect_page_{pageNumber}.html")
File.WriteAllText(outPath, sb.ToString(), Encoding.UTF8)

printfn "Wrote inspection HTML: %s" outPath
printfn "Open it in a browser to inspect bounding boxes and tooltips."
