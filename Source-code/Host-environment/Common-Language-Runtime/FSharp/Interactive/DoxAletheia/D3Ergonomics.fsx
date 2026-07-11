#r "nuget: WebSharper.D3"
#r "nuget: WebSharper.Warp"
#r "nuget: WebSharper.UI"

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Html
open WebSharper.UI.Client
open WebSharper.D3

[<JavaScript>]
module Client =

    let Main () =
        div [] [
            h1 [] [ text "D3 from WebSharper" ]
            div [ attr.id "chart" ] []
            client
                <@ let body = D3.Select("#chart")

                   body
                       .Append("svg")
                       .Attr("width", 400)
                       .Attr("height", 200)
                       .Append("circle")
                       .Attr("cx", 100)
                       .Attr("cy", 100)
                       .Attr("r", 40)
                       .Attr("fill", "steelblue")
                   |> ignore @>
        ]

open WebSharper.Sitelets

let app = Application.SinglePage(fun ctx -> Content.Page(Client.Main()))

do WebSharper.Warp.RunAndWaitForInput app |> ignore
