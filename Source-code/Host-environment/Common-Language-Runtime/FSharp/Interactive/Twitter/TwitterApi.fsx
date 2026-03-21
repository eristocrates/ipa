open System
open System.IO

#r "nuget: FsHttp"
#r "nuget: FSharp.Data"

open FsHttp
open FSharp.Data


#load @"C:\Secret\TwitterSecrets.fsx"
#load @"TwitterAuth.fsx"

open TwitterSecrets
open TwitterAuth
open OAuth1



module parameter =
    module place =
        let fields =
            String.concat
                ","

                [ "contained_within"
                  "country"
                  "country_code"
                  "full_name"
                  "geo"
                  "id"
                  "name"
                  "place_type" ]

    module community =
        let fields =
            String.concat
                ","
                [ "access"
                  "created_at"
                  "description"
                  "id"
                  "join_policy"
                  "member_count"
                  "name" ]

    module user =
        let fields =
            String.concat
                ","
                [ "affiliation"
                  // "confirmed_email" is intentionally omitted here
                  "connection_status"
                  "created_at"
                  "description"
                  "entities"
                  "id"
                  "is_identity_verified"
                  "location"
                  "most_recent_tweet_id"
                  "name"
                  "parody"
                  "pinned_tweet_id"
                  "profile_banner_url"
                  "profile_image_url"
                  "protected"
                  "public_metrics"
                  "receives_your_dm"
                  "subscription"
                  "subscription_type"
                  "url"
                  "username"
                  "verified"
                  "verified_followers_count"
                  "verified_type"
                  "withheld" ]

    module poll =
        let fields =
            String.concat "," [ "duration_minutes"; "end_datetime"; "id"; "options"; "voting_status" ]





    module media =
        let fields =
            String.concat
                ","
                [ "alt_text"
                  "duration_ms"
                  "height"
                  "media_key"
                  "non_public_metrics"
                  "organic_metrics"
                  "preview_image_url"
                  "promoted_metrics"
                  "public_metrics"
                  "type"
                  "url"
                  "variants"
                  "width" ]

    let expansions =
        String.concat
            ","
            [ "article.cover_media"
              "article.media_entities"
              "attachments.media_keys"
              "attachments.media_source_tweet"
              "attachments.poll_ids"
              "author_id"
              "edit_history_tweet_ids"
              "entities.mentions.username"
              "affiliation.user_id"
              "most_recent_tweet_id"
              "pinned_tweet_id"
              "geo.place_id"
              "in_reply_to_user_id"
              "entities.note.mentions.username"
              "referenced_tweets.id"
              "referenced_tweets.id.attachments.media_keys"
              "referenced_tweets.id.author_id" ]

    module tweet =
        let fields =
            String.concat
                ","
                [ "article"
                  "attachments"
                  "author_id"
                  "card_uri"
                  "community_id"
                  "context_annotations"
                  "conversation_id"
                  "created_at"
                  "display_text_range"
                  "edit_controls"
                  "edit_history_tweet_ids"
                  "entities"
                  "geo"
                  "id"
                  "in_reply_to_user_id"
                  "lang"
                  "media_metadata"
                  // "non_public_metrics"
                  "note_tweet"
                  // "organic_metrics"
                  "possibly_sensitive"
                  // "promoted_metrics"
                  "public_metrics"
                  "referenced_tweets"
                  "reply_settings"
                  "scopes"
                  "source"
                  "suggested_source_links"
                  "suggested_source_links_with_counts"
                  "text"
                  "withheld" ]


module twitter =
    module api =
        module GET =
            let rec fetchAllPages baseUrl queryString paginationToken (accumulator: JsonValue list) =
                async {
                    let fullUrl =
                        match paginationToken with
                        | Some token -> $"{baseUrl}?{queryString}&pagination_token={Uri.EscapeDataString(string token)}"
                        | None -> $"{baseUrl}?{queryString}"

                    let authHeader = OAuth1.buildAuthorizationHeader credentials "GET" fullUrl []

                    let! response =
                        http {
                            GET fullUrl
                            header "Authorization" authHeader
                            header "User-Agent" "FsHttp"
                            header "Accept-Language" "en-US"
                        }
                        |> Request.sendAsync

                    let responseBody = response |> Response.toText
                    let json = JsonValue.Parse(responseBody)

                    let content =
                        match json.TryGetProperty("data") with
                        | Some(JsonValue.Array items) -> items |> Array.toList
                        | _ -> []

                    let newAccumulator = accumulator @ content

                    let nextToken =
                        json.TryGetProperty("meta")
                        |> Option.bind (fun meta -> meta.TryGetProperty("next_token"))
                        |> Option.bind (function
                            | JsonValue.String s -> Some s
                            | _ -> None)

                    match nextToken with
                    | Some token -> return! fetchAllPages baseUrl queryString (Some token) newAccumulator
                    | None -> return newAccumulator
                }


            module posts =
                let from_username (username: string) =
                    let query = $"from:{username}"

                    let baseUrl = "https://api.x.com/2/tweets/search/all"

                    let queryParams =
                        [ "query", query
                          "tweet.fields", parameter.tweet.fields
                          "expansions", parameter.expansions
                          "media.fields", parameter.media.fields
                          "poll.fields", parameter.poll.fields ]

                    let queryString =
                        queryParams
                        |> List.map (fun (k, v) -> $"{Uri.EscapeDataString(k)}={Uri.EscapeDataString(v)}")
                        |> String.concat "&"

                    let fullUrl = $"{baseUrl}?{queryString}"

                    let authHeader = OAuth1.buildAuthorizationHeader credentials "GET" fullUrl []

                    http {
                        GET fullUrl
                        header "Authorization" authHeader
                        header "User-Agent" "FsHttp"
                        header "Accept-Language" "en-US"
                    }
                    |> Request.send
            // let! allCommunities = fetchAllPages baseUrl queryString None []
            // return JsonValue.Array(allCommunities |> List.toArray).ToString()


            module community =

                let search (query: string) =
                    async {
                        let baseUrl = "https://api.x.com/2/communities/search"

                        let queryParams =
                            [ "query", query
                              "community.fields", parameter.community.fields

                              ]

                        let queryString =
                            queryParams
                            |> List.map (fun (k, v) -> $"{Uri.EscapeDataString(k)}={Uri.EscapeDataString(v)}")
                            |> String.concat "&"

                        let! allCommunities = fetchAllPages baseUrl queryString None []

                        // TODO  investigate if flattening to a bare array is destructive
                        return JsonValue.Array(allCommunities |> List.toArray).ToString()
                    }

                let by_id (id: string) =

                    let baseUrl = $"https://api.x.com/2/communities/{id}"

                    let queryParams =
                        [ "community.fields",
                          String.concat
                              ","
                              [ "access"
                                "created_at"
                                "description"
                                "id"
                                "join_policy"
                                "member_count"
                                "name" ]

                          ]

                    let queryString =
                        queryParams
                        |> List.map (fun (k, v) -> $"{Uri.EscapeDataString(k)}={Uri.EscapeDataString(v)}")
                        |> String.concat "&"

                    let fullUrl = $"{baseUrl}?{queryString}"

                    let authHeader = OAuth1.buildAuthorizationHeader credentials "GET" fullUrl []

                    http {
                        GET fullUrl
                        header "Authorization" authHeader
                        header "User-Agent" "FsHttp"
                        header "Accept-Language" "en-US"
                    }
                    |> Request.send



                let by_url (url: string) =
                    by_id (url.Replace("https://x.com/i/communities/", ""))

                module members =
                    let by_id (id: string) =


                        http {
                            GET $"https://api.twitterapi.io/twitter/community/members"
                            query [ "community_id", id ]
                            header "X-API-Key" api_key
                            header "User-Agent" "FsHttp"
                            header "Accept-Language" "en-US"
                        }
                        |> Request.send


                    let by_url (url: string) =

                        by_id (url.Replace("https://x.com/i/communities/", "").Replace("/members", ""))

            module user =

                let by_username (username: string) =

                    let baseUrl = $"https://api.x.com/2/users/by/username/{username}"

                    let queryParams =
                        [ "user.fields", parameter.user.fields
                          "expansions", parameter.expansions
                          "tweet.fields", parameter.tweet.fields

                          ]

                    let queryString =
                        queryParams
                        |> List.map (fun (k, v) -> $"{Uri.EscapeDataString(k)}={Uri.EscapeDataString(v)}")
                        |> String.concat "&"

                    let fullUrl = $"{baseUrl}?{queryString}"

                    let authHeader = OAuth1.buildAuthorizationHeader credentials "GET" fullUrl []

                    http {
                        GET fullUrl
                        header "Authorization" authHeader
                        header "User-Agent" "FsHttp"
                        header "Accept-Language" "en-US"
                    }
                    |> Request.send
