open System.IO

#r "nuget: FsHttp"
open FsHttp

#load @"C:\Secret\TwitterSecrets.fsx"
#load @"TwitterApi.fsx"

open TwitterSecrets
open TwitterApi
// TODO prevent samples from firing if file already exists
// TODO decide on identifier casing sheesh

let getPostsFromUsernameSample =
    twitter.api.GET.posts.from_username "TRAYFEY2" |> Async.RunSynchronously


File.WriteAllText(Path.Combine(__SOURCE_DIRECTORY__, "getPostsFromUsernameSample.json"), getPostsFromUsernameSample)
(*
let getCommunitySearchSample =
    twitter.api.GET.community.search "sneako"
    |> Async.RunSynchronously
    

File.WriteAllText(Path.Combine(__SOURCE_DIRECTORY__, "getCommunitySearchSample.json"), getCommunitySearchSample)

let getUserByUsernameSample =
    twitter.api.GET.user.by_username "TRAYFEY2"
    |> Response.toText

File.WriteAllText(Path.Combine(__SOURCE_DIRECTORY__, "getUserByUsernameSample.json"), getUserByUsernameSample)

let getCommunityMembersByIdSample =
    twitter.api.GET.community.members.by_url "https://x.com/i/communities/1695187660526981214"
    |> Response.toText

File.WriteAllText(
    Path.Combine(__SOURCE_DIRECTORY__, "getCommunityMembersByIdSample.json"),
    getCommunityMembersByIdSample
)
*)
