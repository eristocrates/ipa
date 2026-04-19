open System
open System.IO
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
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Google\Chromium\DevTools\ChromeDevtoolsProtocol.fsx"

#load @"C:\Secret\TwitterSecrets.fsx"

open XParsecErgonomics
open Uniform_Resource_Identifier
open International_Resource_Identifier
open ChromeDevtoolsProtocol


#r "nuget: QuikGraph"
#r "nuget: QuikGraph.Serialization"
#r "nuget: QuikGraph.Graphviz"
#r "nuget: QuikGraph.Data"
#r "nuget: QuikGraph.MSAGL"
#r "nuget: QuikGraph.Petri"

open QuikGraph
open QuikGraph.Serialization
open QuikGraph.Graphviz
open QuikGraph.Data
open QuikGraph.MSAGL
open QuikGraph.Petri

let output_file_path_string (parent_directory: string) (stem: string) (extension: string) =
    Path.Combine(parent_directory, $"{stem}.{extension}")

type Labeled_MultiGraph = BidirectionalGraph<string, TaggedEdge<string, string>>
type Statement = TaggedEdge<string, string>

let subject_predicate_object_graph subject predicate object (graph: Labeled_MultiGraph) =
    graph.AddVerticesAndEdge(new Statement(subject, object, predicate)) |> ignore
    graph

let deduplicate_edges (old_graph: Labeled_MultiGraph) =
    let new_graph = new Labeled_MultiGraph()
    new_graph.AddVertexRange old_graph.Vertices |> ignore

    new_graph.AddEdgeRange(old_graph.Edges |> Seq.distinctBy (fun edge -> edge.ToString()))
    |> ignore

    new_graph

let render_dot (graph: Labeled_MultiGraph) (parent_directory: string) (stem: string) =
    let dot_graph =
        new GraphvizAlgorithm<string, TaggedEdge<string, string>>(deduplicate_edges graph)

    dot_graph.FormatVertex.Add(fun args ->

        args.VertexFormat.Label <- args.Vertex
    // args.VertexFormat.Shape <- Dot.GraphvizVertexShape.Egg

    )

    dot_graph.FormatEdge.Add(fun args ->

        args.EdgeFormat.Label.Value <- args.Edge.Tag

    )
    // algorithm.CommonEdgeFormat.ToolTip <- "Edge tooltip"



    dot_graph.Generate(new FileDotEngine(), (output_file_path_string parent_directory stem "dot"))
    |> ignore


let default_graph = new Labeled_MultiGraph()

module https =
    module twitter =
        module com =
            let uri = result'from_parse URI.parse OnInput "https://x.com"

            module home =
                let uri = result'from_parse URI.parse OnInput $"https://x.com/home"

            module i =
                module flow =
                    module login =
                        let uri = result'from_parse URI.parse OnInput "https://x.com/i/flow/login"

            let profile'from'screen_name (screen_name: string) =
                result'from_parse URI.parse OnInput $"https://x.com/{screen_name}"



let inputScreenNames =
    [|

       "AngelEyes11357"

       |]

let discovered_screen_names: Set<string> = Set.ofList []



edge.new_tab'from'uri (https.twitter.com.profile'from'screen_name "AngelEyes11357")

(*


let twitterCommunitiesUriString =
    $"https://x.com/{TwitterSecrets.username}/communities"

let twitterProfileUriString_from_screenName (screenName: string) = $"https://x.com/{screenName}"
let twitterSurfaceDirectoryPath = @"D:\Surface\Company\Twitter"

[<Literal>]
let a'href_communities'Sample =
    @"D:\Surface\Company\Twitter\href_containing_communities.html"

type TwitterUser =
    {

      name: string
      screen_name: string
      description: string
      created_at: string
      rest_id: int64
      avatar'image_url: string
      is_blue_verified: bool
      community_uri_strings: string array

    }

type MassBlockTwitterUser =
    {

      id: int64
      screen_name: string
      name: string
      description: string
      profile_image_url: string

    }




module HomeTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\HomeTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunityQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunityQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunitiesFetchOneQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesFetchOneQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunitiesRankedTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesRankedTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunitiesExploreTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunitiesExploreTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module CommunityTweetsTimeline =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\CommunityTweetsTimeline.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module membersSliceTimeline_Query =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\membersSliceTimeline_Query.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module UserByScreenName =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\UserByScreenName.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module UserTweets =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\UserTweets.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

module ProfileSpotlightsQuery =
    [<Literal>]
    let filePath = @"D:\Surface\Company\Twitter\ProfileSpotlightsQuery.json"

    let json (text: string) = JsonProvider<filePath>.Parse(text)

let UserByScreenNameRequests = ResizeArray<Domains.Network.RequestWillBeSent>()
let HomeTimelineRequests = ResizeArray<Domains.Network.RequestWillBeSent>()
let CommunityQueryRequests = ResizeArray<Domains.Network.RequestWillBeSent>()

let CommunitiesFetchOneQueryRequests =
    ResizeArray<Domains.Network.RequestWillBeSent>()

let CommunitiesRankedTimelineRequests =
    ResizeArray<Domains.Network.RequestWillBeSent>()

let CommunitiesExploreTimelineRequests =
    ResizeArray<Domains.Network.RequestWillBeSent>()

let CommunityTweetsTimelineRequests =
    ResizeArray<Domains.Network.RequestWillBeSent>()

let membersSliceTimeline_QueryRequests =
    ResizeArray<Domains.Network.RequestWillBeSent>()

let UserTweetsRequests = ResizeArray<Domains.Network.RequestWillBeSent>()

let ProfileSpotlightsQueryRequests =
    ResizeArray<Domains.Network.RequestWillBeSent>()








let twitterTab, _ = edge.new_tab twitterHomepageUriString




let networkRequests = ResizeArray<Domains.Network.RequestWillBeSent>()

let graphqlSubstringsToIntercept =
    Set.ofList
        [

          "HomeTimeline"
          "CommunityQuery"
          "CommunityTweetsTimeline"
          "PeopleCommunity_Query"
          "membersSliceTimeline_Query"
          "UserByScreenName"
          "UserTweets"
          "ProfileSpotlightsQuery"

          ]

// TODO figure out how to better pair the UserTweetsRequests and UserByScreenNameRequests with the twitter user.
// right now there's a ton of friction trying to find the tweets from screennames alone
let communityUriStrings_from_restId'screenName (screenName: string) =
    Thread.Sleep(3000)

    UserTweetsRequests
    |> Seq.toArray
    |> Array.Parallel.filter (fun UserTweetsRequest -> UserTweetsRequest.DocumentURL.Contains(screenName))
    |> Array.Parallel.collect (fun UserTweetsRequest ->

        let UserTweetsRequestResponseBody =
            twitterTab.client.SendCommandAsync(Domains.Network.GetResponseBody(UserTweetsRequest.RequestId))
            |> Async.AwaitTask
            |> Async.RunSynchronously

        let userTweets = (UserTweets.json UserTweetsRequestResponseBody.Body) //.Data.User.Result.Timeline.Timeline

        userTweets.Data.User.Result.Timeline.Timeline.Instructions
        |> Array.Parallel.collect (fun instruction ->
            instruction.Entries
            |> Array.Parallel.choose (fun entry -> entry.Content.ItemContent

            )
            |> Array.Parallel.filter (fun itemContent ->
                itemContent.TweetResults.Result.Core.UserResults.Result.Core.ScreenName = screenName)
            |> Array.Parallel.choose (fun itemContent -> itemContent.SocialContext)
            |> Array.Parallel.filter (fun socialContext -> socialContext.ContextType = "Community")
            |> Array.Parallel.map (fun socialContext -> socialContext.LandingUrl.Url)
            |> Array.distinct

        )

    )

let twitterUsers_from_screenNames (screenNames: string array) =

    Thread.Sleep(3000)

    screenNames
    |> Array.map (fun screen_name ->

        let userByScreenName = twitterTab.profilePage screen_name

        let name = userByScreenName.Core.Name
        let screen_name = userByScreenName.Core.ScreenName
        let description = userByScreenName.Legacy.Description
        let created_at = userByScreenName.Core.CreatedAt
        let rest_id = userByScreenName.RestId
        let avatar'image_url = userByScreenName.Avatar.ImageUrl
        let is_blue_verified = userByScreenName.IsBlueVerified

        let community_uri_strings = communityUriStrings_from_restId'screenName screen_name

        {

          name = name
          screen_name = screen_name
          description = description
          created_at = created_at
          rest_id = rest_id
          avatar'image_url = avatar'image_url
          is_blue_verified = is_blue_verified
          community_uri_strings = community_uri_strings

        }

    )

let inputTwitterUsers =
    UserByScreenNameRequests.Clear()
    UserTweetsRequests.Clear()
    Thread.Sleep(3000)
    twitterUsers_from_screenNames inputScreenNames



type TwitterCommunity =
    {

      Name: string
      uriString: string
      Description: string
      MemberCount: int
      RestId: int64
      Rules: string array
      memberScreenNames: string array

    }

let there_were_new_requests (current: int) (last: int) =
    if current > last then
        printfn "New membersSliceTimeline_Query request detected. Total count: %d" current
        true
    else
        printfn "No new membersSliceTimeline_Query request detected. Total count remains: %d" last
        false

let countRequests_from_communityMembersPageUriString (substring_to_check: string) =
    membersSliceTimeline_QueryRequests
    |> Seq.filter (fun network -> network.Request.Url.Contains(substring_to_check))
    |> Seq.length

let rec scroll (substring_to_check: string) =

    let lastCount = countRequests_from_communityMembersPageUriString substring_to_check

    Thread.Sleep(1500)

    twitterTab.client.SendCommandAsync(
        Domains.Runtime.Evaluate(
            """
    window.scrollTo({
      top: document.body.scrollHeight,
      left: 0,
      behavior: "smooth",
    });
                """
                .TrimStart()
                .TrimEnd()
        )
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> ignore

    Thread.Sleep(1500)

    let currentCount =
        countRequests_from_communityMembersPageUriString substring_to_check

    if there_were_new_requests currentCount lastCount then
        scroll (substring_to_check)
    else
        printfn "Finished scrolling. Total membersSliceTimeline_Query request count: %d" currentCount

        membersSliceTimeline_QueryRequests
        |> Seq.filter (fun network -> network.Request.Url.Contains(substring_to_check))
        |> Seq.toArray
        |> Array.Parallel.collect (fun membersSliceTimeline_QueryRequest ->

            let membersSliceTimeline_QueryRequestResponse =
                twitterTab.client.SendCommandAsync(
                    Domains.Network.GetResponseBody(membersSliceTimeline_QueryRequest.RequestId)
                )
                |> Async.AwaitTask
                |> Async.RunSynchronously

            let membersSlice =
                (membersSliceTimeline_Query.json membersSliceTimeline_QueryRequestResponse.Body) // Data.CommunityMembersSliceTimeline.CommunityMembersSliceTimeline

            membersSlice.Data.CommunityResults.Result.MembersSlice.ItemsResults
            |> Array.Parallel.map (fun itemResult ->

                itemResult.Result.Core.ScreenName


            )

        )

let memberScreenNames_from_communityPageUriString (communityPageUriString: string) =

    let communityMembersPageUriString = $"{communityPageUriString}/members"

    twitterTab.client.SendCommandAsync(Domains.Page.Navigate(communityMembersPageUriString))
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> ignore

    Thread.Sleep(3000)

    scroll "membersSliceTimeline_Query"


let discoveredCommunities =
    inputTwitterUsers
    |> Array.Parallel.collect (fun twitterUser ->

        twitterUser.community_uri_strings
        |> Array.Parallel.map (fun community_uri_string ->

            let NavigateRequestResponse = twitterTab.navigate community_uri_string
            Thread.Sleep(3000)

            let communityId =
                let uri = new Uri(community_uri_string)
                let lastSegment = (uri.Segments |> Array.last).TrimEnd('/')

                lastSegment

            let communityQueryRequest =
                CommunityQueryRequests
                |> Seq.find (fun network -> network.Request.Url.Contains(communityId))

            let communityQueryRequestResponse =
                twitterTab.client.SendCommandAsync(Domains.Network.GetResponseBody(communityQueryRequest.RequestId))
                |> Async.AwaitTask
                |> Async.RunSynchronously

            let community =
                (CommunityQuery.json communityQueryRequestResponse.Body).Data.CommunityResults.Result

            let memberScreenNames: string array =
                memberScreenNames_from_communityPageUriString community_uri_string

            {

              Name = community.Name
              uriString = community_uri_string
              Description = community.Description
              MemberCount = community.MemberCount
              RestId = community.RestId
              Rules = community.Rules |> Array.map (fun rule -> rule.Name)
              memberScreenNames = memberScreenNames

            }

        )

    )
    |> Array.distinctBy (fun community -> community.RestId)


let discoveredTwitterUsers =
    discoveredCommunities
    |> Array.collect (fun community ->

        twitterUsers_from_screenNames community.memberScreenNames

    )
*)
