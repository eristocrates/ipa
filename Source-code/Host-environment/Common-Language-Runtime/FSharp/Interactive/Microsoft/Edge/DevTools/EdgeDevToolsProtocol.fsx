open System
open System.IO
open System.Text
open System.Text.Unicode
open System.Linq
open System.Globalization

#r "nuget: FsHttp"
open FsHttp
#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Project\ParserCombinator\Identifier\Resource\International\International_Resource_Identifier.fsx"

open XParsecErgonomics
open International_Resource_Identifier


let scheme_string = "http"
let host_string = "localhost"
let port_string = "9222"

let startpoint =
    result'from_parse IRI.parse OnInput $"{scheme_string}://{host_string}:{port_string}"

let json_endpoint (endpoint: string) =
    result'from_parse IRI.parse OnInput $"{startpoint.as'string}/json/{endpoint}"

let runtimeDirectoryPath = Path.Combine(__SOURCE_DIRECTORY__, "runtime")

let file_scheme_string'from'windows_path (windows_path: string) =
    let reverse_solidus_path = windows_path.Replace("\\", "/")
    $"file:///{reverse_solidus_path}"

let runtimeDirectoryUriString =
    file_scheme_string'from'windows_path runtimeDirectoryPath


let runtimeDirectory =
    result'from_parse IRI_Reference.parse OnInput runtimeDirectoryUriString


module version =
    let endpoint = json_endpoint "version"

    let response = http { GET endpoint.as'string } |> Request.send |> Response.toText


    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\version.json"

    let json = JsonProvider<sampleFilePath>.Parse(response)

(*
    let fsi =
        Oak() {

            AnonymousModule() {

                Json(response).rootName ("DevToolsVersion")
            }
        }
        |> Gen.mkOak
        |> Gen.run

*)



(*
module protocol =
    let endpoint = json_endpoint "protocol"

    let response = http { GET endpoint.as'string } |> Request.send |> Response.toText

    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\protocol.json"

    let json = JsonProvider<sampleFilePath>.Parse(response)
*)
(*
    let fsi =
        Oak() {

            AnonymousModule() {

                Json(response).rootName ("DevToolsProtocol")

            }
        }
        |> Gen.mkOak
        |> Gen.run

*)

module list =
    let endpoint = json_endpoint "list"
    let url = endpoint.as'string

    let response () =
        let text = http { GET url } |> Request.send |> Response.toText

        File.WriteAllText(Path.Combine(runtimeDirectoryPath, "list.json"), text)
        text

    [<Literal>]
    let sampleFilePath = @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\list.json"

    let json () =
        JsonProvider<sampleFilePath>.Parse(response ())
(*
    let fsi =
        Oak() {

            AnonymousModule() {

                Json(response ()).rootName ("DevToolsList")
            }
        }
        |> Gen.mkOak
        |> Gen.run
*)

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
