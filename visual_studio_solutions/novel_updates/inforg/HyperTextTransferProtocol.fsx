#r "nuget: FSharp.Data"


open System
open System.Net
open System.Threading
open FSharp.Data
open System.Net.Http

open System
open FSharp.Data

let dump label (resp: HttpResponse) =
    let bodyPreview =
        match resp.Body with
        | Text t ->
            if t.Length > 300 then
                t.Substring(0, 300)
            else
                t
        | _ -> "<non-text body>"

    printfn "=== %s ===" label
    printfn "Status: %d" resp.StatusCode

    printfn
        "Headers keys: %A"
        (resp.Headers
         |> Seq.map (fun (KeyValue (k, _)) -> k)
         |> Seq.toList)

    printfn "Body preview:\n%s\n" bodyPreview

[<Literal>]
let groupslistUri = "https://www.novelupdates.com/groupslist"
// type provider = HtmlProvider<uri>
let httpClient = new HttpClient()

let response =
    task { return! httpClient.GetAsync(groupslistUri) }
    |> Async.AwaitTask
    |> Async.RunSynchronously

let html = Http.RequestString(groupslistUri)

let resp = Http.Request(groupslistUri, silentHttpErrors = true)
dump "Http.Request baseline" resp
// let page (pageIndex: int) = Http.RequestString($"{uri}?pg={pageIndex}")
