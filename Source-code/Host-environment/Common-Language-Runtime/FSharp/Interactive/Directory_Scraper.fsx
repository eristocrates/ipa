#r "nuget: HtmlAgilityPack"

open System
open System.IO
open System.Net
open System.Net.Http
open HtmlAgilityPack

type Directory_index_entry =
    { uri: Uri
      displayed_name: string
      is_directory: bool }

let http_client = new HttpClient()

http_client.DefaultRequestHeaders.UserAgent.ParseAdd("fsi-html-directory-downloader/1.0")

let ensure_directory_uri (uri: Uri) =
    if uri.AbsoluteUri.EndsWith("/") then
        uri
    else
        Uri(uri.AbsoluteUri + "/")

let remove_query_and_fragment (uri: Uri) =
    let builder = UriBuilder(uri)
    builder.Query <- ""
    builder.Fragment <- ""
    builder.Uri

let is_inside_download_root (download_root_uri: Uri) (candidate_uri: Uri) =
    let normalized_root_uri =
        download_root_uri
        |> ensure_directory_uri
        |> remove_query_and_fragment

    let normalized_candidate_uri = candidate_uri |> remove_query_and_fragment

    normalized_candidate_uri.AbsoluteUri.StartsWith(normalized_root_uri.AbsoluteUri, StringComparison.OrdinalIgnoreCase)

let sanitize_local_path_segment (segment: string) =
    let decoded_segment = WebUtility.UrlDecode(segment.Trim('/'))

    let invalid_file_name_characters = Path.GetInvalidFileNameChars() |> Set.ofArray

    decoded_segment
    |> String.map (fun character ->
        if invalid_file_name_characters.Contains character then
            '_'
        else
            character)

let local_path_for_remote_file (download_root_uri: Uri) (remote_file_uri: Uri) =
    let normalized_root_uri =
        download_root_uri
        |> ensure_directory_uri
        |> remove_query_and_fragment

    let normalized_remote_file_uri = remote_file_uri |> remove_query_and_fragment

    let relative_uri_text =
        normalized_root_uri
            .MakeRelativeUri(normalized_remote_file_uri)
            .ToString()

    let path_segments =
        relative_uri_text.Split([| '/' |], StringSplitOptions.RemoveEmptyEntries)
        |> Array.map sanitize_local_path_segment

    if path_segments.Length = 0 then
        failwithf "Remote file has no relative local path: %O" remote_file_uri

    Path.Combine(path_segments)

let parse_directory_index_entries (current_directory_uri: Uri) (html: string) =
    let document = HtmlDocument()
    document.LoadHtml(html)

    let anchor_nodes = document.DocumentNode.SelectNodes("//a[@href]")

    if isNull anchor_nodes then
        Seq.empty
    else
        anchor_nodes
        |> Seq.cast<HtmlNode>
        |> Seq.choose (fun anchor_node ->
            let raw_href = anchor_node.GetAttributeValue("href", "").Trim()

            if
                String.IsNullOrWhiteSpace(raw_href)
                || raw_href.StartsWith("#")
                || raw_href.StartsWith("?")
                || raw_href.StartsWith("mailto:", StringComparison.OrdinalIgnoreCase)
                || raw_href.StartsWith("javascript:", StringComparison.OrdinalIgnoreCase)
            then
                None
            else
                let resolved_uri = Uri(current_directory_uri, raw_href)

                let displayed_name = WebUtility.HtmlDecode(anchor_node.InnerText.Trim())

                let is_directory = raw_href.EndsWith("/")

                Some
                    { uri = resolved_uri
                      displayed_name =
                        if String.IsNullOrWhiteSpace displayed_name then
                            raw_href
                        else
                            displayed_name
                      is_directory = is_directory })

let download_remote_file (download_root_uri: Uri) (local_output_root_directory: string) (remote_file_uri: Uri) =
    async {
        let relative_local_path =
            local_path_for_remote_file download_root_uri remote_file_uri

        let destination_file_path =
            Path.Combine(local_output_root_directory, relative_local_path)

        let destination_parent_directory = Path.GetDirectoryName(destination_file_path)

        if not (String.IsNullOrWhiteSpace destination_parent_directory) then
            Directory.CreateDirectory(destination_parent_directory)
            |> ignore

        if File.Exists destination_file_path then
            printfn "skip existing: %s" destination_file_path
        else
            use! response =
                http_client.GetAsync(remote_file_uri, HttpCompletionOption.ResponseHeadersRead)
                |> Async.AwaitTask

            // response.EnsureSuccessStatusCode() |> ignore
            if response.IsSuccessStatusCode then

                use! input_stream =
                    response.Content.ReadAsStreamAsync()
                    |> Async.AwaitTask

                use output_stream = File.Create(destination_file_path)

                do!
                    input_stream.CopyToAsync(output_stream)
                    |> Async.AwaitTask

                printfn "downloaded: %s" destination_file_path
            else
                printfn "%O: %s" response.StatusCode destination_file_path
    }

let visited_directory_uris =
    System.Collections.Generic.HashSet<string>(StringComparer.OrdinalIgnoreCase)

let rec download_directory_index_tree
    (download_root_uri: Uri)
    (local_output_root_directory: string)
    (current_directory_uri: Uri)
    =
    async {
        let normalized_current_directory_uri =
            current_directory_uri
            |> ensure_directory_uri
            |> remove_query_and_fragment

        if visited_directory_uris.Add(normalized_current_directory_uri.AbsoluteUri) then
            printfn "index: %O" normalized_current_directory_uri

            let! html =
                http_client.GetStringAsync(normalized_current_directory_uri)
                |> Async.AwaitTask

            let entries =
                parse_directory_index_entries normalized_current_directory_uri html
                |> Seq.map (fun entry -> { entry with uri = remove_query_and_fragment entry.uri })
                |> Seq.filter (fun entry ->
                    is_inside_download_root download_root_uri entry.uri
                    && entry.uri.AbsoluteUri
                       <> normalized_current_directory_uri.AbsoluteUri)
                |> Seq.toList

            for entry in entries do
                if entry.is_directory then
                    do! download_directory_index_tree download_root_uri local_output_root_directory entry.uri
                else
                    do! download_remote_file download_root_uri local_output_root_directory entry.uri
    }


let download_root_uri =
    Uri("https://schema.infor.com/InforOAGIS/")
    |> ensure_directory_uri

let local_output_root_directory =
    @"D:\Surface\Company\Infor\schema.infor.com\InforOAGIS"

download_directory_index_tree download_root_uri local_output_root_directory download_root_uri
|> Async.RunSynchronously
