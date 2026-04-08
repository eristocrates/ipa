open System
open System.Globalization
open System.IO
open System.Text.RegularExpressions

#r "nuget: FParsec"
#r "nuget: FParsec-Pipes"
#r "nuget:  Fabulous.AST"


open FParsec
open FParsec.Pipes
open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast


let handleBackickExclusions (inputString : string) =
  inputString
    .Replace('.', '_')
    .Replace('+', '_')
    .Replace('$', '_')
    .Replace('&', '_')
    .Replace('[', '_')
    .Replace(']', '_')
    .Replace('/', '_')
    .Replace('\\', '_')
    .Replace('*', '_')
    .Replace('\"', '_')
    .Replace ('`', '_')

/// https://fsharp.github.io/fslang-spec/lexical-analysis/
module Lexical_Analysis =
  /// https://fsharp.github.io/fslang-spec/lexical-analysis/#31-whitespace
  module Whitespace =
    /// regexp whitespace = ' '+
    let whitespace : Parser<string, unit> = many1Strings (% " ")

    /// regexp newline = '\n' | '\r' '\n'
    let newline : Parser<string, unit> =
      opt (pchar '\r') >>. pchar '\n'
      >>% System.Environment.NewLine

    /// token whitespace-or-newline = whitespace | newline
    let whitespace_or_newline = whitespace <|> newline

  /// https://fsharp.github.io/fslang-spec/lexical-analysis/#32-comments
  module Comments =
    /// token block-comment-start = "(*"
    let block_comment_start : Parser<string, unit> = % "(*"
    /// token block-comment-end = "*)"
    let block_comment_end : Parser<string, unit> = % "*)"
    /// token end-of-line-comment = "//" [^'\n' '\r']*
    let end'of'line'comment : Parser<string, unit> = regex @"// [^'\n' _\r_]*"

  /// https://fsharp.github.io/fslang-spec/lexical-analysis/#34-identifiers-and-keywords
  module Identifiers_and_Keywords =
    /// regexp digit-char = [0-9]
    let digit_char : Parser<char, unit> = digit

    let unicodeCategory categories : Parser<char, unit> =
      satisfy (fun character ->
        let category = Char.GetUnicodeCategory (character)
        List.contains category categories)

    /// regexp letter-char = '\Lu' | '\Ll' | '\Lt' | '\Lm' | '\Lo' | '\Nl'
    let letter_char =
      unicodeCategory [

                        UnicodeCategory.UppercaseLetter
                        UnicodeCategory.LowercaseLetter
                        UnicodeCategory.TitlecaseLetter
                        UnicodeCategory.ModifierLetter
                        UnicodeCategory.OtherLetter
                        UnicodeCategory.LetterNumber

                         ]

    /// regexp connecting-char = '\Pc'
    let connecting_char = unicodeCategory [ UnicodeCategory.ConnectorPunctuation ]

    /// regexp combining-char = '\Mn' | '\Mc'
    let combining_char =
      unicodeCategory [ UnicodeCategory.NonSpacingMark
                        UnicodeCategory.SpacingCombiningMark ]

    /// regexp formatting-char = '\Cf'
    let formatting_char = unicodeCategory [ UnicodeCategory.Format ]


    /// regexp ident-start-char =
    ///     | letter-char
    ///     | _
    let ident_start_char =
      choice [

               letter_char
               pchar '_'

                ]

    /// regexp ident-char =
    ///     | letter-char
    ///     | digit-char
    ///     | connecting-char
    ///     | combining-char
    ///     | formatting-char
    ///     | '
    ///     | _
    let ident_char =
      choice [

               letter_char
               digit_char
               connecting_char
               combining_char
               formatting_char
               pchar '''
               pchar '_'

                ]

    (*

    let ident_text : Parser<string, unit> =
      pipe2 ident_start_char (manyChars ident_char) (fun first rest -> string first + rest)
*)
    let ident_text : Parser<string, unit> =
      %% +.ident_start_char
      -- +.(many1Chars ident_char)
      -- (spaces1 <|> eof)
      -|> fun head tail -> string head + tail








module Ensure =
  let letBinding (raw_text : string) =
    let parserResult = run Lexical_Analysis.Identifiers_and_Keywords.ident_text raw_text

    match parserResult with
    | Success (_, _, _) -> raw_text
    | Failure (_, _, _) -> $"""``{raw_text}``"""


(*

let ident_text : Parser<string, unit> =
  %% +.Lexical_Analysis.Identifiers_and_Keywords.ident_start_char
  -- +.(many1Chars Lexical_Analysis.Identifiers_and_Keywords.ident_char)
  -|> fun head tail -> string head + tail

let testInput = "testing"














let testInputs =
  [|

     "aaa"
     "aaas"
     "about"
     "acap"
     "acct"
     "acd"
     "acr"
     "adiumxtra"
     "adt"
     "afp"
     "afs"
     "aim"
     "amss"
     "android"
     "appdata"
     "apt"
     "ar"
     "ari"
     "ark"
     "at"
     "attachment"
     "aw"
     "barion"
     "bb"
     "beshare"
     "bitcoin"
     "bitcoincash"
     "bl"
     "blob"
     "bluetooth"
     "bolo"
     "brid"
     "browserext"
     "cabal"
     "calculator"
     "callto"
     "cap"
     "caip"
     "cast"
     "casts"
     "chrome"
     "chrome-extension"
     "cid"
     "coap"
     "coap+tcp"
     "coap+ws"
     "coaps"
     "coaps+tcp"
     "coaps+ws"
     "com-eventbrite-attendee"
     "content"
     "content-type"
     "crid"
     "cstr"
     "cvs"
     "dab"
     "dat"
     "data"
     "dav"
     "dhttp"
     "diaspora"
     "dict"
     "did"
     "dilithium3"
     "dis"
     "dlna-playcontainer"
     "dlna-playsingle"
     "dnp"
     "dns"
     "dntp"
     "doi"
     "donau"
     "dpp"
     "drm"
     "drop"
     "dtmi"
     "dtn"
     "dvb"
     "dvx"
     "dweb"
     "ed2k"
     "eid"
     "elsi"
     "embedded"
     "ens"
     "esim"
     "ethereum"
     "example"
     "facetime"
     "fax"
     "feed"
     "feedready"
     "fido"
     "file"
     "filesystem"
     "finger"
     "first-run-pen-experience"
     "fish"
     "fm"
     "ftp"
     "fuchsia-pkg"
     "geo"
     "gg"
     "git"
     "gitoid"
     "gizmoproject"
     "go"
     "gopher"
     "graph"
     "grd"
     "gtalk"
     "h323"
     "ham"
     "hcap"
     "hcp"
     "hs20"
     "http"
     "https"
     "hxxp"
     "hxxps"
     "hydrazone"
     "hyper"
     "i0"
     "iax"
     "ibi"
     "ibi-"
     "ilstring"
     "icap"
     "icon"
     "ilstring"
     "im"
     "imap"
     "info"
     "iotdisco"
     "ipfs"
     "ipn"
     "ipns"
     "ipp"
     "ipps"
     "irc"
     "irc6"
     "ircs"
     "iris"
     "iris.beep"
     "iris.lwz"
     "iris.xpc"
     "iris.xpcs"
     "isostore"
     "itms"
     "jabber"
     "jar"
     "jms"
     "keyparc"
     "lastfm"
     "lbry"
     "ldap"
     "ldaps"
     "leaptofrogans"
     "lid"
     "linkid"
     "lorawan"
     "lpa"
     "lvlt"
     "machineProvisioningProgressReporter"
     "magnet"
     "mailserver"
     "mailto"
     "maps"
     "market"
     "matrix"
     "message"
     "microsoft.windows.camera"
     "microsoft.windows.camera.multipicker"
     "microsoft.windows.camera.picker"
     "mid"
     "mms"
     "modem"
     "mongodb"
     "moz"
     "mqtt"
     "mqtts"
     "ms-access"
     "ms-appinstaller"
     "ms-browser-extension"
     "ms-calculator"
     "ms-drive-to"
     "ms-enrollment"
     "ms-excel"
     "ms-eyecontrolspeech"
     "ms-gamebarservices"
     "ms-gamingoverlay"
     "ms-getoffice"
     "ms-help"
     "ms-infopath"
     "ms-inputapp"
     "ms-launchremotedesktop"
     "ms-lockscreencomponent-config"
     "ms-media-stream-id"
     "ms-meetnow"
     "ms-mixedrealitycapture"
     "ms-mobileplans"
     "ms-newsandinterests"
     "ms-officeapp"
     "ms-people"
     "ms-personacard"
     "ms-powerpoint"
     "ms-project"
     "ms-publisher"
     "ms-recall"
     "ms-remotedesktop"
     "ms-remotedesktop-launch"
     "ms-restoretabcompanion"
     "ms-screenclip"
     "ms-screensketch"
     "ms-search"
     "ms-search-repair"
     "ms-secondary-screen-controller"
     "ms-secondary-screen-setup"
     "ms-settings"
     "ms-settings-airplanemode"
     "ms-settings-bluetooth"
     "ms-settings-camera"
     "ms-settings-cellular"
     "ms-settings-cloudstorage"
     "ms-settings-connectabledevices"
     "ms-settings-displays-topology"
     "ms-settings-emailandaccounts"
     "ms-settings-language"
     "ms-settings-location"
     "ms-settings-lock"
     "ms-settings-nfctransactions"
     "ms-settings-notifications"
     "ms-settings-power"
     "ms-settings-privacy"
     "ms-settings-proximity"
     "ms-settings-screenrotation"
     "ms-settings-wifi"
     "ms-settings-workplace"
     "ms-spd"
     "ms-stickers"
     "ms-sttoverlay"
     "ms-transit-to"
     "ms-useractivityset"
     "ms-uup"
     "ms-virtualtouchpad"
     "ms-visio"
     "ms-walk-to"
     "ms-whiteboard"
     "ms-whiteboard-cmd"
     "ms-widgetboard"
     "ms-widgets"
     "ms-word"
     "msnim"
     "msrp"
     "msrps"
     "mss"
     "mt"
     "mtqp"
     "mtrust"
     "mumble"
     "mupdate"
     "mvn"
     "mvrp"
     "mvrps"
     "news"
     "nfs"
     "ni"
     "nih"
     "nntp"
     "notes"
     "num"
     "ocf"
     "oid"
     "onenote"
     "onenote-cmd"
     "opaquelocktoken"
     "openid"
     "openpgp4fpr"
     "otpauth"
     "p1"
     "pack"
     "palm"
     "paparazzi"
     "payment"
     "payto"
     "pkcs11"
     "platform"
     "pop"
     "pres"
     "prospero"
     "proxy"
     "psyc"
     "pttp"
     "pwid"
     "qb"
     "query"
     "quic-transport"
     "redis"
     "rediss"
     "reload"
     "res"
     "resource"
     "rmi"
     "rsync"
     "rtmfp"
     "rtmp"
     "rtsp"
     "rtsps"
     "rtspu"
     "sarif"
     "secondlife"
     "secret-token"
     "service"
     "session"
     "sftp"
     "sgn"
     "shc"
     "shelter"
     "shttp"
     "sieve"
     "simpleledger"
     "simplex"
     "sip"
     "sips"
     "skype"
     "smb"
     "smp"
     "sms"
     "smtp"
     "snews"
     "snmp"
     "soap.beep"
     "soap.beeps"
     "soldat"
     "spacify"
     "spiffe"
     "spotify"
     "ssb"
     "ssh"
     "starknet"
     "steam"
     "stun"
     "stuns"
     "submit"
     "svn"
     "swh"
     "swid"
     "swidpath"
     "tag"
     "taler"
     "teamspeak"
     "teapot"
     "teapots"
     "tel"
     "teliaeid"
     "telnet"
     "tftp"
     "things"
     "thismessage"
     "thzp"
     "tip"
     "tn3270"
     "tool"
     "turn"
     "turns"
     "tv"
     "udp"
     "unreal"
     "upn"
     "upt"
     "urn"
     "ut2004"
     "uuid-in-package"
     "v-event"
     "vemmi"
     "ventrilo"
     "ves"
     "videotex"
     "view-source"
     "vnc"
     "vscode"
     "vscode-insiders"
     "vsls"
     "w3"
     "wais"
     "wasm"
     "wasm-js"
     "wcr"
     "web+ap"
     "web3"
     "webcal"
     "wifi"
     "wpid"
     "ws"
     "wss"
     "wtai"
     "wyciwyg"
     "xcompute"
     "xcon"
     "xcon-userid"
     "xfire"
     "xftp"
     "xmlrpc.beep"
     "xmlrpc.beeps"
     "xmpp"
     "xrcp"
     "xri"
     "ymsgr"
     "z39.50"
     "z39.50r"
     "z39.50s"

     |]



let results =
  testInputs
  |> Array.Parallel.choose (fun testInput ->

    let parserResult =
      run (Lexical_Analysis.Identifiers_and_Keywords.ident_text) testInput

    match parserResult with
    | Success (_, _, _) -> None
    | Failure (_, _, _) -> Some (testInput)

  )
*)
