I see the issue. The problem is likely related to how the Twitter API v2 handles pagination for tweets versus communities. Let's fix the `posts.from_username` function to properly handle the Twitter API's response structure for tweets.

Here's the corrected version:

```fsharp
module posts =
    let from_username (username: string) =
        let query = $"from:{username}"

        async {
            let baseUrl = "https://api.x.com/2/tweets/search/all"

            let queryParams =
                [ "query", query
                  "tweet.fields", parameter.tweet.fields
                  "expansions", parameter.expansions
                  "media.fields", parameter.media.fields
                  "poll.fields", parameter.poll.fields
                  "user.fields", parameter.user.fields
                  "place.fields", parameter.place.fields
                  "max_results", "100" ] // Maximum allowed per page

            let queryString =
                queryParams
                |> List.map (fun (k, v) -> $"{Uri.EscapeDataString(k)}={Uri.EscapeDataString(v)}")
                |> String.concat "&"

            let! allTweets = fetchAllPages baseUrl queryString None []

            // The Twitter API returns tweets in a different structure than communities
            // We need to handle the includes and other metadata if needed
            return JsonValue.Array(allTweets |> List.toArray).ToString()
        }
```

The key issues that might be causing empty results:

1. **Missing required fields**: The Twitter API for tweets requires more fields than communities. I've added `user.fields` and `place.fields` which are often necessary.

2. **Pagination token handling**: The Twitter API uses different pagination tokens for different endpoints. Let's update the `fetchAllPages` function to handle this:

```fsharp
let rec fetchAllPages baseUrl queryString paginationToken (accumulator: JsonValue list) =
    async {
        let fullUrl =
            match paginationToken with
            | Some token -> $"{baseUrl}?{queryString}&pagination_token={Uri.EscapeDataString(token)}"
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

        // Debug: Print the raw response to see what we're getting
        printfn "Raw response: %s" responseBody

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
        | Some token ->
            // Add a small delay to avoid rate limiting
            do! Async.Sleep(1000)
            return! fetchAllPages baseUrl queryString (Some token) newAccumulator
        | None -> return newAccumulator
    }
```

3. **Rate limiting**: I've added a small delay between requests to avoid hitting rate limits.

4. **Debugging**: I've added a debug print statement to show the raw response. This will help you see if you're getting any data back from the API.

5. **Max results**: I've explicitly set `max_results=100` which is the maximum allowed per page.

If you're still getting empty results, try these debugging steps:

1. Check the debug output to see the raw API response
2. Verify your OAuth credentials are correct
3. Try a simpler query first to verify the basic connection works
4. Check if the username you're querying actually has tweets
5. Make sure your app has the required permissions in the Twitter Developer Portal

You might also want to add error handling to catch and log any HTTP errors:

```fsharp
let! response =
    try
        http {
            GET fullUrl
            header "Authorization" authHeader
            header "User-Agent" "FsHttp"
            header "Accept-Language" "en-US"
        }
        |> Request.sendAsync
    with
    | ex ->
        printfn "Error making request: %s" ex.Message
        reraise()
```