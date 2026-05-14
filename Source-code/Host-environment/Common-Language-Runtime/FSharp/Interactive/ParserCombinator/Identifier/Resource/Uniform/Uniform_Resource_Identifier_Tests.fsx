open System
open System.Text
open System.IO
open System.Globalization

#r "nuget: XParsec"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\Identifier\Resource\Uniform\Uniform_Resource_Identifier.fsx"

open Resource_Identifier
open Uniform_Resource_Identifier

#r "nuget: Unquote"

open Unicode_Standard

open SetErgonomics

open Swensen.Unquote.Assertions

#r "nuget: FsCheck"

open FsCheck
open XParsecErgonomics
open XParsec


#r "nuget: FSharp.UMX"

open FSharp.UMX




























let inline as_string_of (parsed: ^Parsed) : ^MeasuredString =

    (^Parsed: (member as_string: ^MeasuredString) parsed)


let inline parse_succeeds_with_as_string
    (parser: Parser< ^Parsed, int, unit, ReadableArray<int> >)
    (input: string)
    (expected_string: ^MeasuredString)
    =

    let result = complete_parse parser input

    match result with
    | Result.Ok parsed ->
        let actual_string = as_string_of parsed

        test <@ actual_string = expected_string @>

    | Result.Error error -> test <@ false @>

let parse_succeeds (parser: Parser<'Parsed, int, unit, ReadableArray<int>>) (input: string) =

    let result = complete_parse parser input

    test
        <@ match result with
           | Result.Ok _ -> true
           | Result.Error _ -> false @>


let parse_fails (parser: Parser<'Parsed, int, unit, ReadableArray<int>>) (input: string) =

    let result = complete_parse parser input

    test
        <@ match result with
           | Result.Ok _ -> false
           | Result.Error _ -> true @>



parse_succeeds_with_as_string parse_IPv6address "1:2:3:4:5:6:7:8" (% "1:2:3:4:5:6:7:8": string<ipv6address>)





let uri_accepts_rfc3986_example_uris () =
    [| "ftp://ftp.is.co.za/rfc/rfc1808.txt"
       "http://www.ietf.org/rfc/rfc2396.txt"
       "ldap://[2001:db8::7]/c=GB?objectClass?one"
       "mailto:John.Doe@example.com"
       "news:comp.infosystems.www.servers.unix"
       "tel:+1-816-555-1212"
       "telnet://192.0.2.16:80/"
       "urn:oasis:names:specification:docbook:dtd:xml:4.1.2" |]
    |> Array.iter (parse_succeeds URI.parse)

uri_accepts_rfc3986_example_uris ()


let uri_accepts_authority_variants () =
    [| "http://example.com"
       "http://example.com/"
       "http://example.com/path"
       "http://example.com:80/"
       "http://user@example.com/"
       "http://user:pass@example.com/"
       "http://192.168.example/"
       "http://192.168.0.1/"
       "http://[2001:db8::7]/"
       "http://[v1.fe80]/" |]
    |> Array.iter (parse_succeeds URI.parse)

uri_accepts_authority_variants ()


let uri_accepts_path_query_fragment_variants () =
    [| "http://example.com/path?x"
       "http://example.com/path?x#y"
       "http://example.com/path#y"
       "http://example.com/a/b/c"
       "http://example.com/a;b/c,d"
       "http://example.com/path?name=ferret"
       "http://example.com/path?x/y?z"
       "http://example.com/path#x/y?z"
       "scheme:path-rootless"
       "scheme:/path-absolute"
       "scheme:" |]
    |> Array.iter (parse_succeeds URI.parse)

uri_accepts_path_query_fragment_variants ()


let uri_accepts_percent_encoded_components_without_decoding_delimiters () =
    [| "http://example.com/a%2Fb"
       "http://example.com/%7Euser"
       "http://example.com/path?x=%2F"
       "http://example.com/path#frag%3Fment"
       "http://user%3Aname@example.com/" |]
    |> Array.iter (parse_succeeds URI.parse)

uri_accepts_percent_encoded_components_without_decoding_delimiters ()


let uri_reference_accepts_relative_references () =
    [| "g"
       "./g"
       "g/"
       "/g"
       "//g"
       "?y"
       "g?y"
       "#s"
       "g#s"
       "g?y#s"
       ";x"
       "g;x"
       "g;x?y#s"
       ""
       "."
       "./"
       ".."
       "../"
       "../g"
       "../.."
       "../../"
       "../../g" |]
    |> Array.iter (parse_succeeds URI_Reference.parse)

uri_reference_accepts_relative_references ()


let uri_rejects_malformed_scheme_or_missing_scheme () =
    [| "1http://example.com"
       "+http://example.com"
       ".http://example.com"
       "-http://example.com"
       "http//example.com"
       "://example.com" |]
    |> Array.iter (parse_fails URI.parse)

uri_rejects_malformed_scheme_or_missing_scheme ()


let uri_rejects_malformed_percent_encoding () =
    [| "http://example.com/%"
       "http://example.com/%2"
       "http://example.com/%GG"
       "http://example.com/path?x=%"
       "http://example.com/path#x=%" |]
    |> Array.iter (parse_fails URI.parse)

uri_rejects_malformed_percent_encoding ()


let ipv4address_rejects_invalid_ipv4address_literals () =
    [| "256.0.0.1"
       "999.1.1.1"
       "192.168.0"
       "192.168.0.1.5" |]
    |> Array.iter (parse_fails IPv4address.parse)

ipv4address_rejects_invalid_ipv4address_literals ()

let uri_treats_invalid_ipv4_shape_as_registered_name () =
    let result = complete_parse URI.parse "http://256.0.0.1/"

    let expected_registered_name: string<URI_Registered_Name> = % "256.0.0.1"

    test
        <@ match result with
           | Result.Ok uri ->
               match uri.hierarchical_part.authority with
               | ValueSome authority ->
                   match authority.host with
                   | URI_Host.FromURIRegisteredName registered_name -> registered_name = expected_registered_name
                   | _ -> false
               | ValueNone -> false
           | Result.Error _ -> false @>

uri_treats_invalid_ipv4_shape_as_registered_name ()

let uri_rejects_malformed_ip_literals () =
    [| "http://[2001:db8::7/"
       "http://2001:db8::7]/"
       "http://[]/"
       "http://[v.fe80]/"
       "http://[v1.]/" |]
    |> Array.iter (parse_fails URI.parse)

uri_rejects_malformed_ip_literals ()


let uri_rejects_empty_port_by_current_policy () =
    [| "http://example.com:/"
       "http://example.com:" |]
    |> Array.iter (parse_fails URI.parse)

uri_rejects_empty_port_by_current_policy ()


let absolute_uri_rejects_fragment () =
    parse_fails Absolute_URI.parse "http://example.com/path#fragment"

absolute_uri_rejects_fragment ()


let absolute_uri_accepts_query_without_fragment () =
    parse_succeeds Absolute_URI.parse "http://example.com/path?query"

absolute_uri_accepts_query_without_fragment ()


let uri_parses_ipv6_host_as_ip_literal () =
    let result = complete_parse URI.parse "http://[2001:db8::7]/"

    test
        <@ match result with
           | Result.Ok uri ->
               match uri.hierarchical_part.authority with
               | ValueSome authority ->
                   match authority.host with
                   | URI_Host.FromIPLiteral _ -> true
                   | _ -> false
               | ValueNone -> false
           | Result.Error _ -> false @>

uri_parses_ipv6_host_as_ip_literal ()


let uri_parses_ipvfuture_host_as_ip_literal () =
    let result = complete_parse URI.parse "http://[v1.fe80]/"

    test
        <@ match result with
           | Result.Ok uri ->
               match uri.hierarchical_part.authority with
               | ValueSome authority ->
                   match authority.host with
                   | URI_Host.FromIPLiteral _ -> true
                   | _ -> false
               | ValueNone -> false
           | Result.Error _ -> false @>

uri_parses_ipvfuture_host_as_ip_literal ()


let uri_parses_userinfo_and_host_separately () =
    let result = complete_parse URI.parse "http://user:pass@example.com/"

    let expected_userinfo = ValueSome(% "user:pass": string<URI_Userinfo>)

    let expected_registered_name: string<URI_Registered_Name> = % "example.com"

    test
        <@ match result with
           | Result.Ok uri ->
               match uri.hierarchical_part.authority with
               | ValueSome authority ->
                   authority.userinfo = expected_userinfo
                   && match authority.host with
                      | URI_Host.FromURIRegisteredName registered_name -> registered_name = expected_registered_name
                      | _ -> false
               | ValueNone -> false
           | Result.Error _ -> false @>

uri_parses_userinfo_and_host_separately ()

let uri_parses_query_and_fragment_separately () =
    let result = complete_parse URI.parse "http://example.com/path?query#fragment"

    let expected_query = ValueSome(% "query": string<URI_Query>)

    let expected_fragment = ValueSome(% "fragment": string<URI_Fragment>)

    test
        <@ match result with
           | Result.Ok uri ->
               uri.query = expected_query
               && uri.fragment = expected_fragment
           | Result.Error _ -> false @>

uri_parses_query_and_fragment_separately ()








open Swensen.Unquote.Assertions




// Relative-reference examples from RFC 3986 section 5.4.1.
// These test parsing only, not resolution.
let uri_reference_accepts_rfc3986_relative_reference_examples () =
    [| "g"
       "./g"
       "g/"
       "/g"
       "//g"
       "?y"
       "g?y"
       "#s"
       "g#s"
       "g?y#s"
       ";x"
       "g;x"
       "g;x?y#s"
       ""
       "."
       "./"
       ".."
       "../"
       "../g"
       "../.."
       "../../"
       "../../g" |]
    |> Array.iter (parse_succeeds URI_Reference.parse)

uri_reference_accepts_rfc3986_relative_reference_examples ()


// Basic malformed URI cases.
let uri_rejects_malformed_absolute_uri_examples () =
    [| "1http://example.com"
       "+http://example.com"
       ".http://example.com"
       "-http://example.com"
       "http//example.com"
       "://example.com"
       "http://example.com/%"
       "http://example.com/%2"
       "http://example.com/%GG" |]
    |> Array.iter (parse_fails URI.parse)

uri_rejects_malformed_absolute_uri_examples ()




// URI host ambiguity: invalid IPv4-shaped host is still a reg-name.
let uri_accepts_invalid_ipv4_shape_as_registered_name () =
    parse_succeeds URI.parse "http://256.0.0.1/"

uri_accepts_invalid_ipv4_shape_as_registered_name ()


// Your intentional policy: empty port rejected.


// IP-literal / IPv6 / IPvFuture cases.
let uri_accepts_ip_literal_hosts () =
    [| "http://[2001:db8::7]/"
       "ldap://[2001:db8::7]/c=GB?objectClass?one"
       "http://[v1.fe80]/" |]
    |> Array.iter (parse_succeeds URI.parse)

uri_accepts_ip_literal_hosts ()




let absolute_uri_accepts_query () =
    parse_succeeds Absolute_URI.parse "http://example.com/path?query"

absolute_uri_accepts_query ()
