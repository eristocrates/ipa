open System
open System.IO

#r "nuget: FSharp.ViewEngine"
open FSharp.ViewEngine
open type Html
open type Svg


module Render =
    let toHtmlFile (html_path: string) (html_element: HtmlElement) =
        let parent_directory = Path.GetDirectoryName(html_path)

        Directory.CreateDirectory(parent_directory)
        |> ignore

        let html_content = Render.toHtmlDocString html_element
        File.WriteAllText(html_path, html_content)

let test_html =
    html {
        _lang "en-US"

        head {
            meta {
                _charset "utf-8"
                _name "viewport"
                _content "width=device-width, initial-scale=1.0"
            }

            title "title"
        }

        body {
            h1 { "h1" }
            p { "p" }
        }
    }

let current_directory_path filename =
    Path.Combine(__SOURCE_DIRECTORY__, filename)

let html_path = current_directory_path "test.html"

test_html |> Render.toHtmlFile html_path
