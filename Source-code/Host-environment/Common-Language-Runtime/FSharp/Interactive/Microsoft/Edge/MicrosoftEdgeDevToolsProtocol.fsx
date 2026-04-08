open System
open System.IO
open System.Text

#r "nuget: FsHttp"
#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Json"

#r "nuget: Fabulous.AST.Json, 2.0.0-pre06"


open FsHttp
open FSharp.Data
open Fabulous.AST
open Fabulous.AST.Json

open type Fabulous.AST.Ast

open Fantomas.FCS.Text
open System.Net.WebSockets

#r "nuget: ChromeDevToolsProtocol"

// #r "nuget: FSharp.Control.Websockets"
// #r "nuget: FSharp.Control.Websockets.TPL"
#r "nuget: ChromeProtocol.Core"
#r "nuget: ChromeProtocol.Domains"
#r "nuget: ChromeProtocol.Runtime"

open ChromeProtocol
open ChromeProtocol.Runtime.Messaging.WebSockets

open Microsoft.Extensions.Logging







let localhost = "localhost:9222"

let runtimeDirectoryPath = Path.Combine(__SOURCE_DIRECTORY__, "runtime")


module version =
    let endpoint = "json/version"

    let response =
        http { GET $"http://{localhost}/{endpoint}" }
        |> Request.send
        |> Response.toText


    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\version.json"

    let json = JsonProvider<sampleFilePath>.Parse (response)

    let fsi =
        Oak() {

            AnonymousModule() {

                Json(response).rootName ("DevToolsVersion")
            }
        }
        |> Gen.mkOak
        |> Gen.run




module protocol =
    let endpoint = "json/protocol"

    let response =
        http { GET $"http://{localhost}/{endpoint}" }
        |> Request.send
        |> Response.toText

    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\protocol.json"

    let json = JsonProvider<sampleFilePath>.Parse (response)

    let fsi =
        Oak() {

            AnonymousModule() {

                Json(response).rootName ("DevToolsProtocol")

            }
        }
        |> Gen.mkOak
        |> Gen.run


module list =
    let endpoint = "json/list"
    let url = $"http://{localhost}/{endpoint}"

    let response () =
        let text =
            http { GET url }
            |> Request.send
            |> Response.toText

        File.WriteAllText(Path.Combine(runtimeDirectoryPath, "list.json"), text)
        text

    [<Literal>]
    let sampleFilePath = @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\list.json"

    let json () =
        JsonProvider<sampleFilePath>.Parse (response ())

    let fsi =
        Oak() {

            AnonymousModule() {

                Json(response ()).rootName ("DevToolsList")
            }
        }
        |> Gen.mkOak
        |> Gen.run


// TODO consider generating An ergonomic wrapper
(*
protocol.json.Domains
|> Array.filter (fun domain -> domain.Experimental.IsNone)

|> Array.map (fun domain -> domain.Domain)

protocol.fsi

let fsi =
    Oak() {

        AnonymousModule() {

            Record("Domain") {

                Field("name", "string")
                Field("experimental", "bool")
                Field("dependencies", "string list option")
            // Field("types", "TypesItem list option")
            // Field("commands", "CommandsItem list")
            // Field("events", "EventsItem list option")
            // Field("description", "string option")
            // Field("deprecated", "bool option")

            }

            Module("Domain") {
                for domain in protocol.json.Domains do
                    let experimental =
                        if domain.Experimental.IsSome then
                            true
                        else
                            false

                    Value(
                        domain.Domain,
                        RecordExpr(
                            [

                              RecordFieldExpr("name", String(domain.Domain))
                              RecordFieldExpr("experimental", Bool(experimental))
                              RecordFieldExpr(
                                  "dependencies",
                                  ListExpr(
                                      [

                                        for dependency in domain.Dependencies do
                                            String(dependency)

                                        ]
                                  )
                              )

                              ]
                        )

                    )


            }

        }

    }
    |> Gen.mkOak
    |> Gen.run

// File.WriteAllText(Path.Combine(__SOURCE_DIRECTORY__, "BrowserProtocol.fsx"), fsx)
*)
