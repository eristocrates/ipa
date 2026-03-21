open System
open System.Globalization
open System.Security.Cryptography
open System.Text

#r "nuget: FsHttp"
#r "nuget: FSharpPlus"
#load @"C:\Secret\TwitterSecrets.fsx"

open TwitterSecrets

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

module OAuth1 =
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
