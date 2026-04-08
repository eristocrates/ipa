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

#load "MicrosoftEdgeDevToolsProtocol.fsx"
open System.Threading.Tasks

let neogovLogin =
    "https://login.neogov.com/loginwithsso?returnURL=https%3A%2F%2Funified.neogov.com%2Fdashboard&siteCode=US"

let landingPageUrl =
    "https://login.neogov.com/SamlAuthentication/SamlLoginBySamlConfigurationId?agencyCode=leoncountyfl&samlConfigurationId=2744&forceAuthn=False"

let jsonPageUrl =
    "https://unifiedweb-api.neogov.com/api/Employee/employees?Page=1&PageSize=1000"


















let id_from_guid (guid: Guid) = guid.ToString("N").ToUpperInvariant()


type ConsoleLogger() =
    interface ILogger with
        member _.BeginScope(state) = null
        member _.IsEnabled(_) = true
        member _.Log(logLevel, _, state, _, _) = printfn "[%A] %O" logLevel state



type TabResponse =
    {

      PageEnableRequestResult: Domains.Page.EnableRequestResult
      NetworkEnableRequestResult: Domains.Network.EnableRequestResult

     }



type RelocateResponse =
    {

      NavigateRequestResult: Domains.Page.NavigateRequestResult
      NetworkResponseReceived: Domains.Network.ResponseReceived
      NetworkLoadingFinished: Domains.Network.LoadingFinished
      NetworkGetResponseBodyRequestResult: Domains.Network.GetResponseBodyRequestResult

     }

type TabIntroduction =
    {

      devtoolsFrontendUrl: string
      faviconUrl: string option
      guid: Guid
      title: string option
      targetType: string
      url: string
      webSocketDebuggerUrl: string

     }

[<RequireQualifiedAccess>]
type TargetType =
    | background_page
    | iframe
    | other
    | page
    | service_worker
    | worker
    member this.asString = this.ToString()



type Tab =
    {


      devtoolsFrontendUrl: string
      faviconUrl: string option
      guid: Guid
      title: string option
      targetType: string
      url: string
      webSocketDebuggerUrl: string
      client: DefaultProtocolClient


     }

    member this.id = id_from_guid this.guid
    member this.webSocketDebuggerUri = new Uri(this.webSocketDebuggerUrl)

    member this.getTargets() =
        let GetTargetsResponse =
            this.client.SendCommandAsync(Domains.Target.GetTargets())
            |> Async.AwaitTask
            |> Async.RunSynchronously


        GetTargetsResponse.TargetInfos, GetTargetsResponse

    member this.targets_by_type(targetType: TargetType) =
        let targets, _ = this.getTargets ()

        targets
        |> Seq.filter (fun target -> target.Type = targetType.asString)

    member this.getTabs() = this.targets_by_type (TargetType.page)






    member this.relocate(destinationUrl: string) =
        task {
            let networkResponseReceivedCompletionSource =
                TaskCompletionSource<Domains.Network.ResponseReceived>()

            let networkLoadingFinishedCompletionSource =
                TaskCompletionSource<Domains.Network.LoadingFinished>()

            let mutable matchedRequestId: Domains.Network.RequestIdType option = None

            let networkResponseReceivedSubscription =
                this.client.SubscribeAsync<Domains.Network.ResponseReceived> (fun networkResponseReceived ->
                    task {
                        if networkResponseReceived.Response.Url = destinationUrl
                           && networkResponseReceived.Type = Domains.Network.ResourceTypeType("Document") then
                            matchedRequestId <- Some networkResponseReceived.RequestId

                            networkResponseReceivedCompletionSource.TrySetResult(networkResponseReceived)
                            |> ignore
                    }
                    :> Task)

            let networkLoadingFinishedSubscription =
                this.client.SubscribeAsync<Domains.Network.LoadingFinished> (fun networkLoadingFinished ->
                    task {
                        match matchedRequestId with
                        | Some requestId when networkLoadingFinished.RequestId = requestId ->
                            networkLoadingFinishedCompletionSource.TrySetResult(networkLoadingFinished)
                            |> ignore
                        | _ -> ()
                    }
                    :> Task)

            try
                let! navigateRequestResult = this.client.SendCommandAsync(Domains.Page.Navigate(destinationUrl))

                let! networkResponseReceived = networkResponseReceivedCompletionSource.Task

                let! networkLoadingFinished = networkLoadingFinishedCompletionSource.Task

                let! networkGetResponseBodyRequestResult =
                    this.client.SendCommandAsync(Domains.Network.GetResponseBody(networkResponseReceived.RequestId))

                return
                    { NavigateRequestResult = navigateRequestResult
                      NetworkResponseReceived = networkResponseReceived
                      NetworkLoadingFinished = networkLoadingFinished
                      NetworkGetResponseBodyRequestResult = networkGetResponseBodyRequestResult }
            finally
                networkResponseReceivedSubscription.Dispose()
                networkLoadingFinishedSubscription.Dispose()
        }

    static member inhabitant(introduction: TabIntroduction) =
        let defaultProtocolClient =
            new DefaultProtocolClient(new Uri(introduction.webSocketDebuggerUrl), new ConsoleLogger())


        defaultProtocolClient.ConnectAsync()
        |> Async.AwaitTask
        |> Async.RunSynchronously


        let tab =
            {

              devtoolsFrontendUrl = introduction.devtoolsFrontendUrl
              faviconUrl = introduction.faviconUrl
              guid = introduction.guid
              title = introduction.title
              targetType = introduction.targetType
              url = introduction.url
              webSocketDebuggerUrl = introduction.webSocketDebuggerUrl
              client = defaultProtocolClient

            }

        let PageEnableResponse =
            tab.client.SendCommandAsync(Domains.Page.Enable())
            |> Async.AwaitTask
            |> Async.RunSynchronously


        let NetworkEnableResponse =
            tab.client.SendCommandAsync(Domains.Network.Enable())
            |> Async.AwaitTask
            |> Async.RunSynchronously

        let tabResponse: TabResponse =
            {

              PageEnableRequestResult = PageEnableResponse
              NetworkEnableRequestResult = NetworkEnableResponse

            }


        tab, tabResponse


type BrowserIntroduction =
    {

      webSocketDebuggerUrl: string
      localhost: string
      runtimeDirectoryPath: string


     }

type Browser =
    {

      localhost: string
      runtimeDirectoryPath: string
      webSocketDebuggerUrl: string
      client: DefaultProtocolClient

     }
    member this.version =

        let response =
            http { GET $"http://{this.localhost}/json/version" }
            |> Request.send
            |> Response.toText

        JsonProvider<MicrosoftEdgeDevToolsProtocol.version.sampleFilePath>.Parse (response)

    member this.protocol =

        let response =
            http { GET $"http://{this.localhost}/json/protocol" }
            |> Request.send
            |> Response.toText


        JsonProvider<MicrosoftEdgeDevToolsProtocol.protocol.sampleFilePath>.Parse (response)

    member this.targetList() =

        let response () =
            let text =
                http { GET $"http://{this.localhost}/json/list" }
                |> Request.send
                |> Response.toText

            File.WriteAllText(Path.Combine(this.runtimeDirectoryPath, "list.json"), text)
            text


        JsonProvider<MicrosoftEdgeDevToolsProtocol.list.sampleFilePath>.Parse (response ())

    member this.tabList() =
        this.targetList ()
        |> Array.filter (fun target ->

            target.Type = "page"

        )



    member this.Name = this.version.Browser
    member this.Protocol_Version = this.version.ProtocolVersion
    member this.User_Agent = this.version.UserAgent
    member this.V8_Version = this.version.V8Version
    member this.WebKit_Version = this.version.WebKitVersion
    member this.webSocketDebuggerUri = new Uri(this.webSocketDebuggerUrl)


    member this.createTarget(targetUrl: string) =
        let createTargetRequestResponse =
            this.client.SendCommandAsync(Domains.Target.CreateTarget(targetUrl))

        createTargetRequestResponse.Result.TargetId.Value, createTargetRequestResponse

    member this.tab_from_url(tabUrl: string) =

        let targetId, _ = this.createTarget (tabUrl: string)

        let targetJson =
            this.targetList ()
            |> Array.find (fun target ->

                id_from_guid target.Id = targetId

            )

        let introduction =
            {

              devtoolsFrontendUrl = targetJson.DevtoolsFrontendUrl
              faviconUrl = targetJson.FaviconUrl
              guid = targetJson.Id
              title = targetJson.Title
              targetType = targetJson.Type
              url = targetJson.Url
              webSocketDebuggerUrl = targetJson.WebSocketDebuggerUrl

            }

        Tab.inhabitant introduction








    static member inhabitant(introduction: BrowserIntroduction) =

        let defaultProtocolClient =
            new DefaultProtocolClient(new Uri(introduction.webSocketDebuggerUrl), new ConsoleLogger())

        defaultProtocolClient.ConnectAsync()
        |> Async.AwaitTask
        |> Async.RunSynchronously


        {

          localhost = introduction.localhost
          runtimeDirectoryPath = introduction.runtimeDirectoryPath
          webSocketDebuggerUrl = introduction.webSocketDebuggerUrl
          client = defaultProtocolClient

        }



































let edge =
    let introduction =

        {

          webSocketDebuggerUrl = MicrosoftEdgeDevToolsProtocol.version.json.WebSocketDebuggerUrl
          localhost = MicrosoftEdgeDevToolsProtocol.localhost
          runtimeDirectoryPath = MicrosoftEdgeDevToolsProtocol.runtimeDirectoryPath

        }

    Browser.inhabitant introduction
