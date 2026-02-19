#if INTERACTIVE
#load "source_code/Artifact.fsx"
#endif

open System

open System
open System.Net.Http
open AngleSharp.Dom
open AngleSharp.Html.Parser

let page = "https://www.w3.org/TR/xml"



let http = new HttpClient()


module UrlLinks =


    let getHtml (url: string) : string =
        http.GetStringAsync(url) |> Async.AwaitTask |> Async.RunSynchronously

    let parseHtml (html: string) : IDocument =
        let parser = new HtmlParser()
        parser.ParseDocument(html) :> IDocument

    type LinkOptions =
        { IncludeFragments: bool
          IncludeQuery: bool
          SameOriginOnly: bool }

    let defaultLinkOptions =
        { IncludeFragments = false
          IncludeQuery = false
          SameOriginOnly = true }

    let tryNormalizeHref (baseUri: Uri) (opts: LinkOptions) (href: string) : string option =
        if String.IsNullOrWhiteSpace(href) then
            None
        else
            // Exclude schemes that are not navigable web pages
            let h = href.Trim()

            if h.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase) then
                None
            elif h.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase) then
                None
            elif h.StartsWith("tel:", StringComparison.OrdinalIgnoreCase) then
                None
            else
                // Resolve relative URLs against base
                let abs =
                    try
                        Uri(baseUri, h)
                    with _ ->
                        null

                if isNull abs then
                    None
                else if
                    // Optional scoping: same-origin only
                    opts.SameOriginOnly && abs.Host <> baseUri.Host
                then
                    None
                else
                    // Normalize by stripping fragment/query if desired
                    let b = UriBuilder(abs)

                    if not opts.IncludeFragments then
                        b.Fragment <- ""

                    if not opts.IncludeQuery then
                        b.Query <- ""

                    Some b.Uri.AbsoluteUri

    let extractInternalLinks (pageUrl: string) (opts: LinkOptions) : string list =
        let baseUri = Uri(pageUrl)
        let html = getHtml pageUrl
        let doc = parseHtml html

        doc.QuerySelectorAll("a[href]")
        |> Seq.choose (fun a ->
            let href = a.GetAttribute("href")

            if isNull href then
                None
            else
                tryNormalizeHref baseUri opts href)
        |> Seq.distinct
        |> Seq.sort
        |> Seq.toList

    let extractIds (doc: IDocument) : string list =
        // CSS selector [id] matches any element that has an id attribute
        doc.QuerySelectorAll("[id]")
        |> Seq.choose (fun el ->
            // el.Id is AngleSharp’s normalized property for the id attribute.
            // We still guard against empty/whitespace.
            let id = el.Id
            if String.IsNullOrWhiteSpace(id) then None else Some id)
        |> Seq.distinct
        |> Seq.sort
        |> Seq.toList

    let fragmentUrls (baseUrl: string) (ids: string list) : string list =
        let baseUri = Uri(baseUrl)

        ids
        |> List.map (fun id ->
            // UriBuilder.Fragment should be the raw fragment WITHOUT '#'
            let b = UriBuilder(baseUri)
            b.Fragment <- id
            b.Uri.AbsoluteUri)
//
// let links = extractInternalLinks page defaultLinkOptions
//
// printfn "Found %d same-origin links (normalized)\n" links.Length
//
// let linkContent = String.Join('\n', links)
// Artifact.saveToFile Artifact.test.txt linkContent
module UrlFragments =

    let getHtml (url: string) : string =
        http.GetStringAsync(url) |> Async.AwaitTask |> Async.RunSynchronously

    let parseHtml (html: string) : IDocument =
        let parser = new HtmlParser()
        parser.ParseDocument(html) :> IDocument

    // Your existing filters, factored so we can reuse the same exclusion rules everywhere.
    let shouldExcludeFragmentOrId (s: string) : bool =
        if String.IsNullOrWhiteSpace(s) then
            true
        else
            // Mirror your current exclusions (case-sensitive as you wrote them)
            s.Contains("radix") || s.Contains("__next") || s.Contains("__NEXT")

    let extractIds (doc: IDocument) : string list =
        doc.QuerySelectorAll("[id]")
        |> Seq.choose (fun el ->
            let id = el.Id
            if shouldExcludeFragmentOrId id then None else Some id)
        |> Seq.distinct
        |> Seq.sort
        |> Seq.toList

    // OPTIONAL but often important: legacy named anchors (<a name="action">) as fragment targets.
    let extractNames (doc: IDocument) : string list =
        doc.QuerySelectorAll("[name]")
        |> Seq.choose (fun el ->
            let name = el.GetAttribute("name")

            if isNull name || shouldExcludeFragmentOrId name then
                None
            else
                Some name)
        |> Seq.distinct
        |> Seq.sort
        |> Seq.toList

    // NEW: extract fragment identifiers referenced by hyperlinks.
    // Handles:
    //   href="#action"                 -> "action"
    //   href="/docs#action"            -> "action"
    //   href="https://x/y#action"      -> "action"
    // Ignores:
    //   href="#" (empty fragment)
    //   href without '#'
    let extractHrefFragments (baseUrl: string) (doc: IDocument) : string list =
        let baseUri = Uri(baseUrl)

        doc.QuerySelectorAll("a[href]")
        |> Seq.choose (fun a ->
            let href = a.GetAttribute("href")

            if isNull href then
                None
            else
                let hrefTrimmed = href.Trim()

                if String.IsNullOrWhiteSpace(hrefTrimmed) then
                    None
                else
                    // Resolve relative/absolute uniformly, then read Uri.Fragment.
                    // Uri.Fragment includes the leading '#', or "" if none.
                    try
                        let abs = Uri(baseUri, hrefTrimmed)
                        let frag = abs.Fragment

                        if String.IsNullOrWhiteSpace(frag) then
                            None
                        else
                            let raw = if frag.StartsWith("#") then frag.Substring(1) else frag
                            if shouldExcludeFragmentOrId raw then None else Some raw
                    with _ ->
                        // Any unparseable href is ignored; you can log if you want strictness.
                        None)
        |> Seq.distinct
        |> Seq.sort
        |> Seq.toList

    let fragmentUrls (baseUrl: string) (fragments: string list) : string list =
        let baseUri = Uri(baseUrl)

        fragments
        |> List.map (fun frag ->
            let b = UriBuilder(baseUri)
            // Fragment is assigned WITHOUT '#'
            b.Fragment <- frag
            b.Uri.AbsoluteUri)

    // If you want “everything fragment-relevant from this page”:
    let extractAllFragmentsFromPage (baseUrl: string) (doc: IDocument) : string list =
        // Targets (id/name) + references (href fragments)
        let ids = extractIds doc
        printfn "Found %d ids\n" ids.Length
        printfn "IDs:"
        ids |> List.iter (printfn "  %s")
        let names = extractNames doc
        printfn "Names:"
        names |> List.iter (printfn "  %s")

        let hrefFrags = extractHrefFragments baseUrl doc

        ids @ names @ hrefFrags |> Seq.distinct |> Seq.sort |> Seq.toList




let links = UrlLinks.extractInternalLinks page UrlLinks.defaultLinkOptions

printfn "Found %d same-origin links (normalized)\n" links.Length

let linkContent = String.Join('\n', links)
Artifact.saveToFile Artifact.urlLinks.txt linkContent



let html = UrlLinks.getHtml page
let doc = UrlLinks.parseHtml html

let fragments: string list = UrlFragments.extractAllFragmentsFromPage page doc
let fragmentContent = String.Join('\n', fragments)
Artifact.saveToFile Artifact.urlFragments.txt fragmentContent
