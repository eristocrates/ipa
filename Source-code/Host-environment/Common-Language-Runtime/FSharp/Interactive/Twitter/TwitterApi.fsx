open System
open System.IO
open System.Globalization
open System.Security.Cryptography
open System.Text

#r "nuget: FsHttp"
#r "nuget: FSharpPlus"
#load @"C:\Secret\TwitterSecrets.fsx"

open TwitterSecrets
open FsHttp
open FSharpPlus
open FSharpPlus.Data




type OAuth1Credentials =
    { ConsumerKey: string
      ConsumerSecret: string
      AccessToken: string
      AccessTokenSecret: string }

let credentials =
    { ConsumerKey = consumer_key
      ConsumerSecret = consumer_key_secret
      AccessToken = access_token
      AccessTokenSecret = access_token_secret }

module private OAuth1 =
    let percentEncode (value: string) =
        if isNull value then
            ""
        else
            Uri
                .EscapeDataString(value)
                .Replace("!", "%21")
                .Replace("*", "%2A")
                .Replace("'", "%27")
                .Replace("(", "%28")
                .Replace(")", "%29")

    let unixTimestamp () =
        DateTimeOffset
            .UtcNow
            .ToUnixTimeSeconds()
            .ToString(CultureInfo.InvariantCulture)

    let nonce () =
        Convert
            .ToBase64String(Guid.NewGuid().ToByteArray())
            .TrimEnd('=')
            .Replace("+", "")
            .Replace("/", "")

    let parseQueryParams (uri: Uri) =
        let q = uri.Query

        if String.IsNullOrWhiteSpace(q) then
            []
        else
            q
                .TrimStart('?')
                .Split('&', StringSplitOptions.RemoveEmptyEntries)
            |> Array.toList
            |> List.map (fun pair ->
                match pair.Split('=', 2) with
                | [| k; v |] -> Uri.UnescapeDataString(k), Uri.UnescapeDataString(v)
                | [| k |] -> Uri.UnescapeDataString(k), ""
                | _ -> failwith "Invalid query parameter")

    let normalizeBaseUrl (uri: Uri) =
        let scheme = uri.Scheme.ToLowerInvariant()
        let host = uri.Host.ToLowerInvariant()

        let includePort =
            not (
                (scheme = "http" && uri.Port = 80)
                || (scheme = "https" && uri.Port = 443)
            )

        let authority =
            if includePort then
                $"{host}:{uri.Port}"
            else
                host

        $"{scheme}://{authority}{uri.AbsolutePath}"

    let normalizeParameters (allParams: (string * string) list) =
        allParams
        |> List.map (fun (k, v) -> percentEncode k, percentEncode v)
        |> List.sortBy (fun (k, v) -> k, v)
        |> List.map (fun (k, v) -> $"{k}={v}")
        |> String.concat "&"

    let signatureBaseString (httpMethod: string) (baseUrl: string) (normalizedParams: string) =
        let methodUpper = httpMethod.ToUpperInvariant()
        $"{percentEncode methodUpper}&{percentEncode baseUrl}&{percentEncode normalizedParams}"

    let signingKey (consumerSecret: string) (tokenSecret: string) =
        $"{percentEncode consumerSecret}&{percentEncode tokenSecret}"

    let hmacSha1Base64 (key: string) (text: string) =
        use hmac = new HMACSHA1(Encoding.ASCII.GetBytes(key))

        text
        |> Encoding.ASCII.GetBytes
        |> hmac.ComputeHash
        |> Convert.ToBase64String

    let buildAuthorizationHeader
        (credentials: OAuth1Credentials)
        (httpMethod: string)
        (url: string)
        (extraParams: (string * string) list)
        =

        let uri = Uri(url)
        let timestamp = unixTimestamp ()
        let nonceValue = nonce ()

        let oauthParams =
            [ "oauth_consumer_key", credentials.ConsumerKey
              "oauth_nonce", nonceValue
              "oauth_signature_method", "HMAC-SHA1"
              "oauth_timestamp", timestamp
              "oauth_token", credentials.AccessToken
              "oauth_version", "1.0" ]

        let queryParams = parseQueryParams uri

        let allParams = queryParams @ extraParams @ oauthParams

        let baseUrl = normalizeBaseUrl uri
        let normalizedParams = normalizeParameters allParams
        let baseString = signatureBaseString httpMethod baseUrl normalizedParams
        let key = signingKey credentials.ConsumerSecret credentials.AccessTokenSecret
        let signature = hmacSha1Base64 key baseString

        let headerParams =
            oauthParams @ [ "oauth_signature", signature ]
            |> List.map (fun (k, v) -> $"{percentEncode k}=\"{percentEncode v}\"")
            |> String.concat ", "

        $"OAuth {headerParams}"

module twitter =
    module api =
        module GET =

            let user_by_username (username: string) =

                let baseUrl = $"https://api.x.com/2/users/by/username/{username}"

                let queryParams =
                    [ "user.fields",
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
                      "expansions", "affiliation.user_id,most_recent_tweet_id,pinned_tweet_id"
                      "tweet.fields",
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
                            "withheld" ] ]

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

            let community_by_id (id: string) =

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
                            "name" ] ]

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

            let community_members_by_id (id: string) =


                http {
                    GET $"https://api.twitterapi.io/twitter/community/members"
                    query [ "community_id", id ]
                    header "X-API-Key" api_key
                    header "User-Agent" "FsHttp"
                    header "Accept-Language" "en-US"
                }
                |> Request.send

            let community_by_url (url: string) =
                community_by_id (url.Replace("https://x.com/i/communities/", ""))

            let community_members_by_url (url: string) =

                community_members_by_id (
                    url
                        .Replace("https://x.com/i/communities/", "")
                        .Replace("/members", "")
                )

let getUserByUsernameSample =
    twitter.api.GET.user_by_username "TRAYFEY2"
    |> Response.toText

File.WriteAllText(Path.Combine(__SOURCE_DIRECTORY__, "getUserByUsernameSample.json"), getUserByUsernameSample)

let getCommunityMembersByIdSample =
    twitter.api.GET.community_members_by_url "https://x.com/i/communities/1695187660526981214"
    |> Response.toText

File.WriteAllText(
    Path.Combine(__SOURCE_DIRECTORY__, "getCommunityMembersByIdSample.json"),
    getCommunityMembersByIdSample
)
