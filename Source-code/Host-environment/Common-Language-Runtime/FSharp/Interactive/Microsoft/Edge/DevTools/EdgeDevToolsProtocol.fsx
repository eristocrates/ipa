open System
open System.IO

#r "nuget: FsHttp"
open FsHttp
#r "nuget: FSharp.Data"
open FSharp.Data


let scheme_string = "http"
let host_string = "localhost"
let port_string = "9222"

let startpoint = new Uri($"{scheme_string}://{host_string}:{port_string}")

let json_endpoint (endpoint: string) = new Uri($"{startpoint}json/{endpoint}")

let runtimeDirectoryPath = Path.Combine(__SOURCE_DIRECTORY__, "runtime")

let file_scheme_string'from'windows_path (windows_path: string) =
    let reverse_solidus_path = windows_path.Replace("\\", "/")
    $"file:///{reverse_solidus_path}"

let runtimeDirectoryUriString =
    file_scheme_string'from'windows_path runtimeDirectoryPath


let runtimeDirectory = new Uri(runtimeDirectoryUriString)


let text_from_http (uri: Uri) =
    http { GET uri.OriginalString } |> Request.send |> Response.toText

module version =
    let endpoint = json_endpoint "version"

    let json_text = text_from_http endpoint


    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\version.json"

    let json = JsonProvider<sampleFilePath>.Parse(json_text)

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



module protocol =
    let endpoint = json_endpoint "protocol"

    let json_text = text_from_http endpoint

    [<Literal>]
    let sampleFilePath =
        @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\protocol.json"

    let json = JsonProvider<sampleFilePath>.Parse(json_text)

    [<Literal>]
    let schemaFilePath =
        @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Microsoft\Edge\TypeProviderSamples\MicrosoftEdgeDevTools\protocol.schema.json"

    let jsonschema = JsonProvider<schemaFilePath>.Load(schemaFilePath)


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

    let get_json_text () =
        let text = text_from_http endpoint

        File.WriteAllText(Path.Combine(runtimeDirectoryPath, "list.json"), text)
        text

    [<Literal>]
    let sampleFilePath = @"D:\Surface\Company\Microsoft\Edge\ChromeDevTools\list.json"

    let json () =
        JsonProvider<sampleFilePath>.Parse(get_json_text ())
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
