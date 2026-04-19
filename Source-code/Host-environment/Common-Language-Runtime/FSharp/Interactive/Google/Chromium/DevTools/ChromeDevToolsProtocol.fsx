open System
open System.Threading.Tasks

#r "nuget: FsHttp"
open FsHttp
#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: ChromeProtocol.Core"
#r "nuget: ChromeProtocol.Domains"
#r "nuget: ChromeProtocol.Runtime"

open ChromeProtocol
open ChromeProtocol.Runtime.Messaging.WebSockets

open Microsoft.Extensions.Logging


#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Microsoft\Edge\DevTools\EdgeDevToolsProtocol.fsx"


open XParsecErgonomics
open Uniform_Resource_Identifier
open International_Resource_Identifier























let id_from_guid (guid: Guid) = guid.ToString("N").ToUpperInvariant()

let resync_task (task: Task<_>) =
    task |> Async.AwaitTask |> Async.RunSynchronously


type ConsoleLogger() =
    interface ILogger with
        member _.BeginScope(state) = null
        member _.IsEnabled(_) = true
        member _.Log(logLevel, _, state, _, _) = printfn "[%A] %O" logLevel state




type Browser =
    {

      client: DefaultProtocolClient

    }

    static member from'debugging_endpoint(debugging_endpoint: URI) =
        let browser =
            {

              client = new DefaultProtocolClient(new Uri(debugging_endpoint.as'string), new ConsoleLogger())

            }

        let PageEnableResponse =
            browser.client.SendCommandAsync(Domains.Page.Enable()) |> resync_task

        let NetworkEnableResponse =
            browser.client.SendCommandAsync(Domains.Network.Enable()) |> resync_task

        let DOMEnableResponse =
            browser.client.SendCommandAsync(Domains.DOM.Enable()) |> resync_task

        let RuntimeEnableResponse =
            browser.client.SendCommandAsync(Domains.Runtime.Enable()) |> resync_task

        browser

    member this.new_tab'from'uri(uri: URI) =
        this.client.SendCommandAsync(Domains.Target.CreateTarget(uri.as'string))
        |> resync_task



let edge_endpoint =
    result'from_parse URI.parse OnInput EdgeDevToolsProtocol.version.json.WebSocketDebuggerUrl

let edge = Browser.from'debugging_endpoint edge_endpoint











(*
{

          localhost = introduction.localhost
          runtimeDirectoryPath = introduction.runtimeDirectoryPath
          webSocketDebuggerUrl = introduction.webSocketDebuggerUrl
          client = defaultProtocolClient

}

let edge =
    let introduction =

        {

          webSocketDebuggerUrl = EdgeDevToolsProtocol.version.json.WebSocketDebuggerUrl
          localhost = EdgeDevToolsProtocol.localhost
          runtimeDirectoryPath = EdgeDevToolsProtocol.runtimeDirectoryPath

        }

    Browser.inhabitant introduction
    *)






(*

type TabResponse =
    {

      PageEnableRequestResult: Domains.Page.EnableRequestResult
      NetworkEnableRequestResult: Domains.Network.EnableRequestResult
      DOMEnableRequestResult: Domains.DOM.EnableRequestResult
      RuntimeEnableResponse: Domains.Runtime.EnableRequestResult

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

        targets |> Seq.filter (fun target -> target.Type = targetType.asString)

    member this.getTabs() = this.targets_by_type (TargetType.page)






    member this.relocate(destinationUrl: string) =
        task {
            let networkResponseReceivedCompletionSource =
                TaskCompletionSource<Domains.Network.ResponseReceived>()

            let networkLoadingFinishedCompletionSource =
                TaskCompletionSource<Domains.Network.LoadingFinished>()

            let mutable matchedRequestId: Domains.Network.RequestIdType option = None

            let networkResponseReceivedSubscription =
                this.client.SubscribeAsync<Domains.Network.ResponseReceived>(fun networkResponseReceived ->
                    task {
                        if
                            networkResponseReceived.Response.Url = destinationUrl
                            && networkResponseReceived.Type = Domains.Network.ResourceTypeType("Document")
                        then
                            matchedRequestId <- Some networkResponseReceived.RequestId

                            networkResponseReceivedCompletionSource.TrySetResult(networkResponseReceived)
                            |> ignore
                    }
                    :> Task)

            let networkLoadingFinishedSubscription =
                this.client.SubscribeAsync<Domains.Network.LoadingFinished>(fun networkLoadingFinished ->
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
                    {

                      NavigateRequestResult = navigateRequestResult
                      NetworkResponseReceived = networkResponseReceived
                      NetworkLoadingFinished = networkLoadingFinished
                      NetworkGetResponseBodyRequestResult = networkGetResponseBodyRequestResult

                    }
            finally
                networkResponseReceivedSubscription.Dispose()
                networkLoadingFinishedSubscription.Dispose()
        }

    member this.navigate(destinationUriString: string) =
        let NavigateRequestResponse =
            this.client.SendCommandAsync(Domains.Page.Navigate(destinationUriString))
            |> Async.AwaitTask
            |> Async.RunSynchronously

        NavigateRequestResponse

    member this.profilePage(screenName: string) =

        let twitterProfileUriString = twitterProfileUriString_from_screenName screenName
        let NavigateRequestResponse = this.navigate twitterProfileUriString
        Thread.Sleep(4000)

        let UserByScreenNameRequest =
            UserByScreenNameRequests
            |> Seq.find (fun network -> network.DocumentURL.Contains(screenName))

        let UserByScreenNameRequestResponse =
            this.client.SendCommandAsync(Domains.Network.GetResponseBody(UserByScreenNameRequest.RequestId))
            |> Async.AwaitTask
            |> Async.RunSynchronously

        Thread.Sleep(3000)
        (UserByScreenName.json UserByScreenNameRequestResponse.Body).Data.User.Result




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

        let DOMEnableResponse =
            tab.client.SendCommandAsync(Domains.DOM.Enable())
            |> Async.AwaitTask
            |> Async.RunSynchronously

        let RuntimeEnableResponse =
            tab.client.SendCommandAsync(Domains.Runtime.Enable())
            |> Async.AwaitTask
            |> Async.RunSynchronously

        let tabResponse: TabResponse =
            {

              PageEnableRequestResult = PageEnableResponse
              NetworkEnableRequestResult = NetworkEnableResponse
              DOMEnableRequestResult = DOMEnableResponse
              RuntimeEnableResponse = RuntimeEnableResponse

            }

        let networkResponseReceivedSubscription =
            tab.client.SubscribeAsync<Domains.Network.RequestWillBeSent>(fun network ->
                task {

                    if network.Request.Url.Contains("graphql") then
                        let uri = new Uri(network.Request.Url)
                        let lastSegment = (uri.Segments |> Array.last).TrimEnd('/')

                        match lastSegment with
                        | "UserByScreenName" -> UserByScreenNameRequests.Add(network)
                        | "HomeTimeline" -> HomeTimelineRequests.Add(network)
                        | "CommunityQuery" -> CommunityQueryRequests.Add(network)
                        | "CommunitiesFetchOneQuery" -> CommunitiesFetchOneQueryRequests.Add(network)
                        | "CommunitiesRankedTimeline" -> CommunitiesRankedTimelineRequests.Add(network)
                        | "CommunitiesExploreTimeline" -> CommunitiesExploreTimelineRequests.Add(network)
                        | "CommunityTweetsTimeline" -> CommunityTweetsTimelineRequests.Add(network)
                        | "membersSliceTimeline_Query" -> membersSliceTimeline_QueryRequests.Add(network)
                        | "UserTweets" -> UserTweetsRequests.Add(network)
                        | "ProfileSpotlightsQuery" -> ProfileSpotlightsQueryRequests.Add(network)
                        | _ -> ()

                    return ()


                }
                :>

                Task)

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

        JsonProvider<EdgeDevToolsProtocol.version.sampleFilePath>.Parse(response)

    member this.protocol =

        let response =
            http { GET $"http://{this.localhost}/json/protocol" }
            |> Request.send
            |> Response.toText


        JsonProvider<EdgeDevToolsProtocol.protocol.sampleFilePath>.Parse(response)

    member this.targetList() =

        let response () =
            let text =
                http { GET $"http://{this.localhost}/json/list" }
                |> Request.send
                |> Response.toText

            File.WriteAllText(Path.Combine(this.runtimeDirectoryPath, "list.json"), text)
            text


        JsonProvider<EdgeDevToolsProtocol.list.sampleFilePath>.Parse(response ())

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

    member this.new_tab(tabUrl: string) =

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
              url = targetJson.Url.Value
              webSocketDebuggerUrl = targetJson.WebSocketDebuggerUrl

            }

        Tab.inhabitant introduction








    static member inhabitant(introduction: BrowserIntroduction) =

*)
