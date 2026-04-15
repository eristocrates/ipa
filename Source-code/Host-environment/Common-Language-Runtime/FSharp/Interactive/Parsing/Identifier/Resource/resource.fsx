open System
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XParsecErgonomics.fsx"
open XParsecErgonomics
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\IRI\IRI.fsx"

open IRI
open URI

let input = "http://www.example.org/wine"
let (Result.Error failure) = run_full_parse URI.parse OnInput input
let (Result.Ok result) = run_full_parse URI.parse OnInput input

result.as_string
(*
let windowsPath = @"D:\Surface\Standards\Unicode"
//fileIRIString_from_filePath windowsPath
let IRIString = "https://example.org/has space"


run_full_parse IRI_Reference.parse OnInput IRIString

let iri =
    match run_partial_parse IRI_Reference.parse OnInput IRIString with
    | Ok result -> result

iri.as_string



// iri.absolute_iri.as_string = (new Uri(windowsPath)).AbsoluteUri


let (Hierarchical_Path.FromRootlessPath result_path) = iri.hierarchical_path
result_path.head.as_string
result_path.tail_string_segments
result_path.as_string


let iriStrings =
    [|

        "ftp://ftp.is.co.za/rfc/rfc1808.txt"
        "http://www.ietf.org/rfc/rfc2396.txt"
        // "ldap://[2001:db8::7]/c=GB?objectClass?one"
        "mailto:John.Doe@example.com"
        "news:comp.infosystems.www.servers.unix"
        "tel:+1-816-555-1212"
        "telnet://192.0.2.16:80/"
        "urn:oasis:names:specification:docbook:dtd:xml:4.1.2"
        "http://例え.テスト/"
        "https://δοκιμή.gr/σελίδα"
        "https://مثال.إختبار/مسار"
        "https://실례.테스트/경로"
        "https://例子.测试/路径?键=值#片段"
        "ftp://ユーザー名@例え.テスト/資料"
        "file:///C:/Users/名前/Documents"
        "mailto:ユーザー@example.org"
        "urn:example:書籍:123"
        "https://example.org/café"
        "https://example.org/mañana"
        "https://example.org/straße"
        "https://example.org/π/λ/ω"
        "https://example.org/路径/更多路径"
        "https://example.org/🙂"
        "https://example.org/δοκιμή?α=β&γ=δ"
        "https://example.org/#片段"
        "https://例え.テスト/"
        "https://例え.テスト/パス/次"
        "https://ユーザー名@例え.テスト:8080/道"


        "foo:/α/β"
        "foo:/路径"
        "foo:/café"
        "urn:example:こんにちは"
        "foo:bar"
        "foo:δοκιμή/次"
        "https://example.org/?q=猫"
        "https://example.org/?q=δοκιμή&lang=ελληνικά"
        "https://example.org/#セクション"
        "https://example.org/路?q=値#片段"
        "https://example.org/caf%C3%A9"
        "https://example.org/éclair/%E6%97%A5%E6%9C%AC"
        "https://example.org/%CF%80/λ"

       "/こんにちは"
       "//例え.テスト/道"
       "../café"
       "δοκιμή/次"
       "?q=猫"
       "#片段"


       |]

let results =
    iriStrings
    |> Array.map (fun iriString ->

        run_full_parse IRI_Reference.parse OnInput iriString
        let result =
            match run_parse IRI.parse OnInput iriString with
            | Ok result -> result

        result.as_string

    )
*)
