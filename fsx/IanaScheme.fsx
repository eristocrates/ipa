#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"Iana.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open Iana
#load @".paket/load/main.group.fsx"
open System

let aaa =
    { lexicalForm = "aaa"
      description = Some("""Diameter Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 13862 }

let aaas =
    { lexicalForm = "aaas"
      description = Some("""Diameter Protocol with Secure Transport""")
      status = IanaStatus.Permanent
      criSchemeNumber = 14526 }

let about =
    { lexicalForm = "about"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 3786 }

let acap =
    { lexicalForm = "acap"
      description = Some("""application configuration access protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12705 }

let acct =
    { lexicalForm = "acct"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 10229 }

let acd =
    { lexicalForm = "acd"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6840 }

let ace =
    { lexicalForm = "ace"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 26 }

let acr =
    { lexicalForm = "acr"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10196 }

let adiumxtra =
    { lexicalForm = "adiumxtra"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6634 }

let adt =
    { lexicalForm = "adt"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5150 }

let aet =
    { lexicalForm = "aet"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1020 }

let afp =
    { lexicalForm = "afp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13404 }

let afs =
    { lexicalForm = "afs"
      description = Some("""Andrew File System global file names""")
      status = IanaStatus.Provisional
      criSchemeNumber = 10687 }

let agtp =
    { lexicalForm = "agtp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1006 }

let aim =
    { lexicalForm = "aim"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10327 }

let amss =
    { lexicalForm = "amss"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10831 }

let android =
    { lexicalForm = "android"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15061 }

let appdata =
    { lexicalForm = "appdata"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7364 }

let apt =
    { lexicalForm = "apt"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7856 }

let ar =
    { lexicalForm = "ar"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5099 }

let ari =
    { lexicalForm = "ari"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3818 }

let ark =
    { lexicalForm = "ark"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3018 }

let ars =
    { lexicalForm = "ars"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1025 }

let at =
    { lexicalForm = "at"
      description =
        Some("""at 
      (see reviewer notes)""")
      status = IanaStatus.Provisional
      criSchemeNumber = 6007 }

let attachment =
    { lexicalForm = "attachment"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8577 }

let aw =
    { lexicalForm = "aw"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 16051 }

let barion =
    { lexicalForm = "barion"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10225 }

let bb =
    { lexicalForm = "bb"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 5188 }

let beshare =
    { lexicalForm = "beshare"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4674 }

let bitcoin =
    { lexicalForm = "bitcoin"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9186 }

let bitcoincash =
    { lexicalForm = "bitcoincash"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7226 }

let bl =
    { lexicalForm = "bl"
      description = Some("""bluetooth (shortened)""")
      status = IanaStatus.Provisional
      criSchemeNumber = 10024 }

let blob =
    { lexicalForm = "blob"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11060 }

let bluetooth =
    { lexicalForm = "bluetooth"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12052 }

let bolo =
    { lexicalForm = "bolo"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8765 }

let brid =
    { lexicalForm = "brid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8251 }

let browserext =
    { lexicalForm = "browserext"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4327 }

let cabal =
    { lexicalForm = "cabal"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11393 }

let calculator =
    { lexicalForm = "calculator"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3783 }

let callto =
    { lexicalForm = "callto"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8713 }

let cap =
    { lexicalForm = "cap"
      description = Some("""Calendar Access Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 9204 }

let caip =
    { lexicalForm = "caip"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1001 }

let cast =
    { lexicalForm = "cast"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1220 }

let casts =
    { lexicalForm = "casts"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12718 }

module chrome =
    let extension =
        { lexicalForm = "chrome-extension"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 14667 }

let cid =
    { lexicalForm = "cid"
      description = Some("""content identifier""")
      status = IanaStatus.Permanent
      criSchemeNumber = 15202 }

let cm =
    { lexicalForm = "cm"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1021 }

module coap =
    let tcp =
        { lexicalForm = "coap+tcp"
          description =
            Some("""coap+tcp 
      (see reviewer notes)""")
          status = IanaStatus.Permanent
          criSchemeNumber = 6 }

    let ws =
        { lexicalForm = "coap+ws"
          description =
            Some("""coap+ws 
      (see reviewer notes)""")
          status = IanaStatus.Permanent
          criSchemeNumber = 24 }

module coaps =
    let tcp =
        { lexicalForm = "coaps+tcp"
          description =
            Some("""coaps+tcp 
      (see reviewer notes)""")
          status = IanaStatus.Permanent
          criSchemeNumber = 7 }

    let ws =
        { lexicalForm = "coaps+ws"
          description =
            Some("""coaps+ws 
      (see reviewer notes)""")
          status = IanaStatus.Permanent
          criSchemeNumber = 25 }

module com =
    module eventbrite =
        let attendee =
            { lexicalForm = "com-eventbrite-attendee"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 9278 }

module content =
    let type_ =
        { lexicalForm = "content-type"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6030 }

let crid =
    { lexicalForm = "crid"
      description = Some("""TV-Anytime Content Reference Identifier""")
      status = IanaStatus.Permanent
      criSchemeNumber = 5990 }

let cstr =
    { lexicalForm = "cstr"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6730 }

let cttps =
    { lexicalForm = "cttps"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1007 }

let cvs =
    { lexicalForm = "cvs"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12242 }

let dab =
    { lexicalForm = "dab"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6774 }

let dat =
    { lexicalForm = "dat"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10583 }

let data =
    { lexicalForm = "data"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 1946 }

let dav =
    { lexicalForm = "dav"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 4373 }

let dhttp =
    { lexicalForm = "dhttp"
      description =
        Some("""dhttp 
      (see reviewer notes)""")
      status = IanaStatus.Provisional
      criSchemeNumber = 4549 }

let diaspora =
    { lexicalForm = "diaspora"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4598 }

let dict =
    { lexicalForm = "dict"
      description = Some("""dictionary service protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3886 }

let did =
    { lexicalForm = "did"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5 }

let dilithium3 =
    { lexicalForm = "dilithium3"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1005 }

let dis =
    { lexicalForm = "dis"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 17134 }

module dlna =
    let playcontainer =
        { lexicalForm = "dlna-playcontainer"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 5557 }

    let playsingle =
        { lexicalForm = "dlna-playsingle"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6144 }

let dnp =
    { lexicalForm = "dnp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15819 }

let dns =
    { lexicalForm = "dns"
      description = Some("""Domain Name System""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12932 }

let dntp =
    { lexicalForm = "dntp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14347 }

let doi =
    { lexicalForm = "doi"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 13014 }

let donau =
    { lexicalForm = "donau"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10150 }

let dpp =
    { lexicalForm = "dpp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2442 }

let drm =
    { lexicalForm = "drm"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9859 }

let drop =
    { lexicalForm = "drop"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 16138 }

let dtmi =
    { lexicalForm = "dtmi"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 17097 }

let dtn =
    { lexicalForm = "dtn"
      description = Some("""DTNRG research and development""")
      status = IanaStatus.Permanent
      criSchemeNumber = 7456 }

let dvb =
    { lexicalForm = "dvb"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10380 }

let dvx =
    { lexicalForm = "dvx"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11645 }

let dweb =
    { lexicalForm = "dweb"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1328 }

let ed2k =
    { lexicalForm = "ed2k"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2790 }

let eid =
    { lexicalForm = "eid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4929 }

let elsi =
    { lexicalForm = "elsi"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13680 }

let embedded =
    { lexicalForm = "embedded"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4193 }

let ens =
    { lexicalForm = "ens"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1982 }

let esim =
    { lexicalForm = "esim"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3032 }

let ethereum =
    { lexicalForm = "ethereum"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7913 }

let example =
    { lexicalForm = "example"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 5296 }

let ez =
    { lexicalForm = "ez"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1010 }

let facetime =
    { lexicalForm = "facetime"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3795 }

let fax =
    { lexicalForm = "fax"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 4053 }

let feed =
    { lexicalForm = "feed"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7520 }

let feedready =
    { lexicalForm = "feedready"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11824 }

let fido =
    { lexicalForm = "fido"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5717 }

let file =
    { lexicalForm = "file"
      description = Some("""Host-specific file names""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12068 }

let filesystem =
    { lexicalForm = "filesystem"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 3365 }

let finger =
    { lexicalForm = "finger"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 17315 }

module first =
    module run =
        module pen =
            let experience =
                { lexicalForm = "first-run-pen-experience"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 16069 }

let fish =
    { lexicalForm = "fish"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12634 }

let fm =
    { lexicalForm = "fm"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2806 }

let ftp =
    { lexicalForm = "ftp"
      description = Some("""File Transfer Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 14878 }

module fuchsia =
    let pkg =
        { lexicalForm = "fuchsia-pkg"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 12806 }

let gcx =
    { lexicalForm = "gcx"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1019 }

let gdsi =
    { lexicalForm = "gdsi"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1022 }

let geo =
    { lexicalForm = "geo"
      description = Some("""Geographic Locations""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3342 }

let gg =
    { lexicalForm = "gg"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11055 }

let git =
    { lexicalForm = "git"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13068 }

let gitoid =
    { lexicalForm = "gitoid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3775 }

let gizmoproject =
    { lexicalForm = "gizmoproject"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10744 }

let go =
    { lexicalForm = "go"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 5705 }

let gopher =
    { lexicalForm = "gopher"
      description = Some("""The Gopher Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 8601 }

let graph =
    { lexicalForm = "graph"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11583 }

let grd =
    { lexicalForm = "grd"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 9444 }

let gtalk =
    { lexicalForm = "gtalk"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4709 }

let h323 =
    { lexicalForm = "h323"
      description = Some("""H.323""")
      status = IanaStatus.Permanent
      criSchemeNumber = 10317 }

let ham =
    { lexicalForm = "ham"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6503 }

let hcap =
    { lexicalForm = "hcap"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9875 }

let hcp =
    { lexicalForm = "hcp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6024 }

let hs20 =
    { lexicalForm = "hs20"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1273 }

let http =
    { lexicalForm = "http"
      description = Some("""Hypertext Transfer Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 2 }

let https =
    { lexicalForm = "https"
      description = Some("""Hypertext Transfer Protocol Secure""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3 }

let hxxp =
    { lexicalForm = "hxxp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 16728 }

let hxxps =
    { lexicalForm = "hxxps"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4714 }

let hydrazone =
    { lexicalForm = "hydrazone"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6632 }

let hyper =
    { lexicalForm = "hyper"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12876 }

let i0 =
    { lexicalForm = "i0"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10328 }

let iax =
    { lexicalForm = "iax"
      description = Some("""Inter-Asterisk eXchange Version 2""")
      status = IanaStatus.Permanent
      criSchemeNumber = 7126 }

let ibi =
    { lexicalForm = "ibi-"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1003 }

let icap =
    { lexicalForm = "icap"
      description = Some("""Internet Content Adaptation Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12566 }

let icon =
    { lexicalForm = "icon"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14868 }

let ilstring =
    { lexicalForm = "ilstring"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12237 }

let im =
    { lexicalForm = "im"
      description = Some("""Instant Messaging""")
      status = IanaStatus.Permanent
      criSchemeNumber = 6883 }

let imap =
    { lexicalForm = "imap"
      description = Some("""internet message access protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 10119 }

let info =
    { lexicalForm = "info"
      description =
        Some("""Information Assets with Identifiers in Public Namespaces. 
       (section 3) defines an "info" registry 
        of public namespaces, which is maintained by NISO and can be accessed 
        from .""")
      status = IanaStatus.Permanent
      criSchemeNumber = 13846 }

let interaction =
    { lexicalForm = "interaction"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1023 }

let iotdisco =
    { lexicalForm = "iotdisco"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 17170 }

let ipfs =
    { lexicalForm = "ipfs"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15972 }

let ipn =
    { lexicalForm = "ipn"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 8775 }

let ipns =
    { lexicalForm = "ipns"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 16933 }

let ipp =
    { lexicalForm = "ipp"
      description = Some("""Internet Printing Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 9318 }

let ipps =
    { lexicalForm = "ipps"
      description = Some("""Internet Printing Protocol over HTTPS""")
      status = IanaStatus.Permanent
      criSchemeNumber = 4419 }

let irc =
    { lexicalForm = "irc"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5425 }

let irc6 =
    { lexicalForm = "irc6"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1905 }

let ircs =
    { lexicalForm = "ircs"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8687 }

module iris =
    let beep =
        { lexicalForm = "iris.beep"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 15639 }

    let lwz =
        { lexicalForm = "iris.lwz"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 4590 }

    let xpc =
        { lexicalForm = "iris.xpc"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 12422 }

    let xpcs =
        { lexicalForm = "iris.xpcs"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 16134 }

let isostore =
    { lexicalForm = "isostore"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7225 }

let itms =
    { lexicalForm = "itms"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14830 }

let jabber =
    { lexicalForm = "jabber"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 6109 }

let jar =
    { lexicalForm = "jar"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1578 }

let jms =
    { lexicalForm = "jms"
      description = Some("""Java Message Service""")
      status = IanaStatus.Provisional
      criSchemeNumber = 3634 }

let keyparc =
    { lexicalForm = "keyparc"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9770 }

let lastfm =
    { lexicalForm = "lastfm"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11742 }

let lbry =
    { lexicalForm = "lbry"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14010 }

let ldap =
    { lexicalForm = "ldap"
      description = Some("""Lightweight Directory Access Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 13442 }

let ldaps =
    { lexicalForm = "ldaps"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3906 }

let leaptofrogans =
    { lexicalForm = "leaptofrogans"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 16281 }

let lid =
    { lexicalForm = "lid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10247 }

let linkid =
    { lexicalForm = "linkid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1819 }

let lorawan =
    { lexicalForm = "lorawan"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11718 }

let lpa =
    { lexicalForm = "lpa"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6658 }

let lvlt =
    { lexicalForm = "lvlt"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5480 }

let machineProvisioningProgressReporter =
    { lexicalForm = "machineProvisioningProgressReporter"
      description = Some("""Windows Autopilot Modern Device Management status updates""")
      status = IanaStatus.Provisional
      criSchemeNumber = 5477 }

let magnet =
    { lexicalForm = "magnet"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9805 }

let mailserver =
    { lexicalForm = "mailserver"
      description = Some("""Access to data available from mail servers""")
      status = IanaStatus.Historical
      criSchemeNumber = 10868 }

let mailto =
    { lexicalForm = "mailto"
      description = Some("""Electronic mail address""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12102 }

let maps =
    { lexicalForm = "maps"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14153 }

let market =
    { lexicalForm = "market"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14595 }

let matrix =
    { lexicalForm = "matrix"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9487 }

module mdoc =
    let openid4vp =
        { lexicalForm = "mdoc-openid4vp"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 1012 }

let message =
    { lexicalForm = "message"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14460 }

module microsoft =
    module windows =
        module camera =
            let multipicker =
                { lexicalForm = "microsoft.windows.camera.multipicker"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 7942 }

            let picker =
                { lexicalForm = "microsoft.windows.camera.picker"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 5883 }

let mid =
    { lexicalForm = "mid"
      description = Some("""message identifier""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3646 }

let mms =
    { lexicalForm = "mms"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12337 }

let modem =
    { lexicalForm = "modem"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 9154 }

let mongodb =
    { lexicalForm = "mongodb"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13372 }

let moz =
    { lexicalForm = "moz"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6808 }

let mqtt =
    { lexicalForm = "mqtt"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10740 }

let mqtts =
    { lexicalForm = "mqtts"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14906 }

module ms =
    let access =
        { lexicalForm = "ms-access"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6863 }

    let appinstaller =
        { lexicalForm = "ms-appinstaller"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 5152 }

    module browser =
        let extension =
            { lexicalForm = "ms-browser-extension"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 14090 }

    let calculator =
        { lexicalForm = "ms-calculator"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 3690 }

    module drive =
        let to_ =
            { lexicalForm = "ms-drive-to"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 4102 }

    let enrollment =
        { lexicalForm = "ms-enrollment"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 14310 }

    let excel =
        { lexicalForm = "ms-excel"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 5536 }

    let eyecontrolspeech =
        { lexicalForm = "ms-eyecontrolspeech"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 17381 }

    let gamebarservices =
        { lexicalForm = "ms-gamebarservices"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 12823 }

    let gamingoverlay =
        { lexicalForm = "ms-gamingoverlay"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 1059 }

    let getoffice =
        { lexicalForm = "ms-getoffice"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 14366 }

    let help =
        { lexicalForm = "ms-help"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 7809 }

    let infopath =
        { lexicalForm = "ms-infopath"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 8830 }

    let inputapp =
        { lexicalForm = "ms-inputapp"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6792 }

    let launchremotedesktop =
        { lexicalForm = "ms-launchremotedesktop"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 12174 }

    module lockscreencomponent =
        let config =
            { lexicalForm = "ms-lockscreencomponent-config"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 12525 }

    module media =
        module stream =
            let id =
                { lexicalForm = "ms-media-stream-id"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 6388 }

    let meetnow =
        { lexicalForm = "ms-meetnow"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 15645 }

    let mixedrealitycapture =
        { lexicalForm = "ms-mixedrealitycapture"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6411 }

    let mobileplans =
        { lexicalForm = "ms-mobileplans"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 11945 }

    let newsandinterests =
        { lexicalForm = "ms-newsandinterests"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 2945 }

    let officeapp =
        { lexicalForm = "ms-officeapp"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 14168 }

    let people =
        { lexicalForm = "ms-people"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 1528 }

    let personacard =
        { lexicalForm = "ms-personacard"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 1562 }

    let powerpoint =
        { lexicalForm = "ms-powerpoint"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 16645 }

    let project =
        { lexicalForm = "ms-project"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 11130 }

    let publisher =
        { lexicalForm = "ms-publisher"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 16194 }

    let recall =
        { lexicalForm = "ms-recall"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 10183 }

    module remotedesktop =
        let launch =
            { lexicalForm = "ms-remotedesktop-launch"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 8085 }

    let restoretabcompanion =
        { lexicalForm = "ms-restoretabcompanion"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 17175 }

    let screenclip =
        { lexicalForm = "ms-screenclip"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 10518 }

    let screensketch =
        { lexicalForm = "ms-screensketch"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 9453 }

    module search =
        let repair =
            { lexicalForm = "ms-search-repair"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 15679 }

    module secondary =
        module screen =
            let controller =
                { lexicalForm = "ms-secondary-screen-controller"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 13098 }

            let setup =
                { lexicalForm = "ms-secondary-screen-setup"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 15254 }

    module settings =
        let airplanemode =
            { lexicalForm = "ms-settings-airplanemode"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 5109 }

        let bluetooth =
            { lexicalForm = "ms-settings-bluetooth"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 14180 }

        let camera =
            { lexicalForm = "ms-settings-camera"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 15773 }

        let cellular =
            { lexicalForm = "ms-settings-cellular"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 15361 }

        let cloudstorage =
            { lexicalForm = "ms-settings-cloudstorage"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 10640 }

        let connectabledevices =
            { lexicalForm = "ms-settings-connectabledevices"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 11351 }

        module displays =
            let topology =
                { lexicalForm = "ms-settings-displays-topology"
                  description = None
                  status = IanaStatus.Provisional
                  criSchemeNumber = 12029 }

        let emailandaccounts =
            { lexicalForm = "ms-settings-emailandaccounts"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 11072 }

        let language =
            { lexicalForm = "ms-settings-language"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 9981 }

        let location =
            { lexicalForm = "ms-settings-location"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 10373 }

        let lock =
            { lexicalForm = "ms-settings-lock"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 11950 }

        let nfctransactions =
            { lexicalForm = "ms-settings-nfctransactions"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 10591 }

        let notifications =
            { lexicalForm = "ms-settings-notifications"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 7868 }

        let power =
            { lexicalForm = "ms-settings-power"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 13026 }

        let privacy =
            { lexicalForm = "ms-settings-privacy"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 9198 }

        let proximity =
            { lexicalForm = "ms-settings-proximity"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 3959 }

        let screenrotation =
            { lexicalForm = "ms-settings-screenrotation"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 6755 }

        let wifi =
            { lexicalForm = "ms-settings-wifi"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 15994 }

        let workplace =
            { lexicalForm = "ms-settings-workplace"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 14936 }

    let spd =
        { lexicalForm = "ms-spd"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6189 }

    let stickers =
        { lexicalForm = "ms-stickers"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 10361 }

    let sttoverlay =
        { lexicalForm = "ms-sttoverlay"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 5410 }

    module transit =
        let to_ =
            { lexicalForm = "ms-transit-to"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 7743 }

    let useractivityset =
        { lexicalForm = "ms-useractivityset"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 9136 }

    let uup =
        { lexicalForm = "ms-uup"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 1560 }

    let virtualtouchpad =
        { lexicalForm = "ms-virtualtouchpad"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 15776 }

    let visio =
        { lexicalForm = "ms-visio"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 15163 }

    module walk =
        let to_ =
            { lexicalForm = "ms-walk-to"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 14364 }

    module whiteboard =
        let cmd =
            { lexicalForm = "ms-whiteboard-cmd"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 14860 }

    let widgetboard =
        { lexicalForm = "ms-widgetboard"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 12603 }

    let widgets =
        { lexicalForm = "ms-widgets"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 4613 }

    let word =
        { lexicalForm = "ms-word"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 16585 }

let msnim =
    { lexicalForm = "msnim"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8041 }

let msrp =
    { lexicalForm = "msrp"
      description = Some("""Message Session Relay Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 11315 }

let msrps =
    { lexicalForm = "msrps"
      description = Some("""Message Session Relay Protocol Secure""")
      status = IanaStatus.Permanent
      criSchemeNumber = 13440 }

let mss =
    { lexicalForm = "mss"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12493 }

let mt =
    { lexicalForm = "mt"
      description =
        Some("""Matter protocol on-boarding payloads that are encoded for use in QR Codes and/or NFC Tags""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12699 }

let mtqp =
    { lexicalForm = "mtqp"
      description = Some("""Message Tracking Query Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3358 }

let mtrust =
    { lexicalForm = "mtrust"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13062 }

let mumble =
    { lexicalForm = "mumble"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11804 }

let mupdate =
    { lexicalForm = "mupdate"
      description = Some("""Mailbox Update (MUPDATE) Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12569 }

let musik =
    { lexicalForm = "musik"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1014 }

let mvn =
    { lexicalForm = "mvn"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9585 }

let mvrp =
    { lexicalForm = "mvrp"
      description =
        Some("""mvrp
      (see reviewer notes)        
      """)
      status = IanaStatus.Provisional
      criSchemeNumber = 13451 }

let mvrps =
    { lexicalForm = "mvrps"
      description =
        Some("""mvrps
      (see reviewer notes)        
      """)
      status = IanaStatus.Provisional
      criSchemeNumber = 13228 }

let news =
    { lexicalForm = "news"
      description = Some("""USENET news""")
      status = IanaStatus.Permanent
      criSchemeNumber = 1895 }

let nfs =
    { lexicalForm = "nfs"
      description = Some("""network file system protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 6516 }

let ni =
    { lexicalForm = "ni"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 10926 }

let nih =
    { lexicalForm = "nih"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 11428 }

let nntp =
    { lexicalForm = "nntp"
      description = Some("""USENET news using NNTP access""")
      status = IanaStatus.Permanent
      criSchemeNumber = 13499 }

let nostr =
    { lexicalForm = "nostr"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1017 }

let notes =
    { lexicalForm = "notes"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8766 }

let npamp =
    { lexicalForm = "npamp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1009 }

let num =
    { lexicalForm = "num"
      description = Some("""Namespace Utility Modules""")
      status = IanaStatus.Provisional
      criSchemeNumber = 9965 }

let ocf =
    { lexicalForm = "ocf"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10241 }

let oid =
    { lexicalForm = "oid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 16079 }

module onenote =
    let cmd =
        { lexicalForm = "onenote-cmd"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 16632 }

let opaquelocktoken =
    { lexicalForm = "opaquelocktoken"
      description = Some("""opaquelocktokent""")
      status = IanaStatus.Permanent
      criSchemeNumber = 6341 }

let openid =
    { lexicalForm = "openid"
      description = Some("""OpenID Connect""")
      status = IanaStatus.Provisional
      criSchemeNumber = 1242 }

let openpgp4fpr =
    { lexicalForm = "openpgp4fpr"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13094 }

let otpauth =
    { lexicalForm = "otpauth"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13829 }

let p1 =
    { lexicalForm = "p1"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 14982 }

let pack =
    { lexicalForm = "pack"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 13348 }

let palm =
    { lexicalForm = "palm"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10238 }

let paparazzi =
    { lexicalForm = "paparazzi"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12599 }

let payment =
    { lexicalForm = "payment"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 1762 }

let payto =
    { lexicalForm = "payto"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6992 }

let pkcs11 =
    { lexicalForm = "pkcs11"
      description = Some("""PKCS#11""")
      status = IanaStatus.Permanent
      criSchemeNumber = 9312 }

let pkg =
    { lexicalForm = "pkg"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1018 }

let platform =
    { lexicalForm = "platform"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2754 }

let pop =
    { lexicalForm = "pop"
      description = Some("""Post Office Protocol v3""")
      status = IanaStatus.Permanent
      criSchemeNumber = 10551 }

let pres =
    { lexicalForm = "pres"
      description = Some("""Presence""")
      status = IanaStatus.Permanent
      criSchemeNumber = 14972 }

let prospero =
    { lexicalForm = "prospero"
      description = Some("""Prospero Directory Service""")
      status = IanaStatus.Historical
      criSchemeNumber = 14477 }

let proxy =
    { lexicalForm = "proxy"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3503 }

let psyc =
    { lexicalForm = "psyc"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1466 }

let pttp =
    { lexicalForm = "pttp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6903 }

let pwid =
    { lexicalForm = "pwid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 17068 }

let qb =
    { lexicalForm = "qb"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12478 }

let query =
    { lexicalForm = "query"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10147 }

module quic =
    let transport =
        { lexicalForm = "quic-transport"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 6462 }

let redis =
    { lexicalForm = "redis"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8099 }

let rediss =
    { lexicalForm = "rediss"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9338 }

let reload =
    { lexicalForm = "reload"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 12726 }

let res =
    { lexicalForm = "res"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4153 }

let resource =
    { lexicalForm = "resource"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2284 }

let rmi =
    { lexicalForm = "rmi"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 16292 }

let rsync =
    { lexicalForm = "rsync"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 16884 }

let rtmfp =
    { lexicalForm = "rtmfp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3348 }

let rtmp =
    { lexicalForm = "rtmp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3920 }

let rtsp =
    { lexicalForm = "rtsp"
      description = Some("""Real-Time Streaming Protocol (RTSP)""")
      status = IanaStatus.Permanent
      criSchemeNumber = 15267 }

let rtsps =
    { lexicalForm = "rtsps"
      description = Some("""Real-Time Streaming Protocol (RTSP) over TLS""")
      status = IanaStatus.Permanent
      criSchemeNumber = 4619 }

let rtspu =
    { lexicalForm = "rtspu"
      description = Some("""Real-Time Streaming Protocol (RTSP) over unreliable datagram transport""")
      status = IanaStatus.Permanent
      criSchemeNumber = 11999 }

let sarif =
    { lexicalForm = "sarif"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13650 }

let secondlife =
    { lexicalForm = "secondlife"
      description = Some("""query""")
      status = IanaStatus.Provisional
      criSchemeNumber = 16729 }

module secret =
    let token =
        { lexicalForm = "secret-token"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 7074 }

let seki =
    { lexicalForm = "seki"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1026 }

let service =
    { lexicalForm = "service"
      description = Some("""service location""")
      status = IanaStatus.Permanent
      criSchemeNumber = 17264 }

let session =
    { lexicalForm = "session"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 4355 }

let sftp =
    { lexicalForm = "sftp"
      description = Some("""query""")
      status = IanaStatus.Provisional
      criSchemeNumber = 5492 }

let sgn =
    { lexicalForm = "sgn"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4882 }

let shc =
    { lexicalForm = "shc"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5823 }

let shelter =
    { lexicalForm = "shelter"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15461 }

let sieve =
    { lexicalForm = "sieve"
      description = Some("""ManageSieve Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 5472 }

let simpleledger =
    { lexicalForm = "simpleledger"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9544 }

let simplex =
    { lexicalForm = "simplex"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15118 }

let sip =
    { lexicalForm = "sip"
      description = Some("""session initiation protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 12644 }

let sips =
    { lexicalForm = "sips"
      description = Some("""secure session initiation protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 9535 }

let skype =
    { lexicalForm = "skype"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2326 }

let smb =
    { lexicalForm = "smb"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7285 }

let smp =
    { lexicalForm = "smp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11533 }

let sms =
    { lexicalForm = "sms"
      description = Some("""Short Message Service""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3524 }

let smtp =
    { lexicalForm = "smtp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13340 }

let snews =
    { lexicalForm = "snews"
      description = Some("""NNTP over SSL/TLS""")
      status = IanaStatus.Historical
      criSchemeNumber = 13285 }

let snmp =
    { lexicalForm = "snmp"
      description = Some("""Simple Network Management Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 1165 }

module soap =
    let beep =
        { lexicalForm = "soap.beep"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 8519 }

    let beeps =
        { lexicalForm = "soap.beeps"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 16300 }

let soldat =
    { lexicalForm = "soldat"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6349 }

let spacify =
    { lexicalForm = "spacify"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1000 }

let spiffe =
    { lexicalForm = "spiffe"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 8093 }

let spotify =
    { lexicalForm = "spotify"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12732 }

let ssb =
    { lexicalForm = "ssb"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12400 }

let ssh =
    { lexicalForm = "ssh"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 7667 }

let sss =
    { lexicalForm = "sss"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 555 }

let starknet =
    { lexicalForm = "starknet"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12458 }

let steam =
    { lexicalForm = "steam"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5134 }

let stun =
    { lexicalForm = "stun"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 14627 }

let stuns =
    { lexicalForm = "stuns"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 14901 }

let submit =
    { lexicalForm = "submit"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4951 }

let svn =
    { lexicalForm = "svn"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13923 }

let swh =
    { lexicalForm = "swh"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 17039 }

let swid =
    { lexicalForm = "swid"
      description = Some("""swid (see reviewer notes)""")
      status = IanaStatus.Provisional
      criSchemeNumber = 14162 }

let swidpath =
    { lexicalForm = "swidpath"
      description = Some("""swidpath (see reviewer notes)""")
      status = IanaStatus.Provisional
      criSchemeNumber = 5825 }

let tag =
    { lexicalForm = "tag"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 16377 }

let taler =
    { lexicalForm = "taler"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2796 }

let teamspeak =
    { lexicalForm = "teamspeak"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6924 }

let teapot =
    { lexicalForm = "teapot"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15026 }

let teapots =
    { lexicalForm = "teapots"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3375 }

let tel =
    { lexicalForm = "tel"
      description = Some("""telephone""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3143 }

let teliaeid =
    { lexicalForm = "teliaeid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13362 }

let telnet =
    { lexicalForm = "telnet"
      description = Some("""Reference to interactive sessions""")
      status = IanaStatus.Permanent
      criSchemeNumber = 10995 }

let tftp =
    { lexicalForm = "tftp"
      description = Some("""Trivial File Transfer Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 8300 }

let things =
    { lexicalForm = "things"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 2154 }

let thismessage =
    { lexicalForm = "thismessage"
      description = Some("""multipart/related relative reference resolution""")
      status = IanaStatus.Permanent
      criSchemeNumber = 14367 }

let thzp =
    { lexicalForm = "thzp"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 11820 }

let tii =
    { lexicalForm = "tii"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1027 }

let tip =
    { lexicalForm = "tip"
      description = Some("""Transaction Internet Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 6651 }

let tn3270 =
    { lexicalForm = "tn3270"
      description = Some("""Interactive 3270 emulation sessions""")
      status = IanaStatus.Permanent
      criSchemeNumber = 14962 }

let tool =
    { lexicalForm = "tool"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15230 }

let tttps =
    { lexicalForm = "tttps"
      description =
        Some("""TLS TimeToken Secure Protocol (TTTPS). A cryptographic 
temporal ordering proof protocol augmenting TLS 1.3 with Proof-of-Time records.""")
      status = IanaStatus.Provisional
      criSchemeNumber = 1011 }

let turn =
    { lexicalForm = "turn"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 10333 }

let turns =
    { lexicalForm = "turns"
      description = None
      status = IanaStatus.Permanent
      criSchemeNumber = 1926 }

let tv =
    { lexicalForm = "tv"
      description = Some("""TV Broadcasts""")
      status = IanaStatus.Permanent
      criSchemeNumber = 7923 }

let udp =
    { lexicalForm = "udp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 5217 }

let unreal =
    { lexicalForm = "unreal"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15206 }

let upn =
    { lexicalForm = "upn"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1004 }

let upt =
    { lexicalForm = "upt"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 2747 }

let urn =
    { lexicalForm = "urn"
      description = Some("""Uniform Resource Names""")
      status = IanaStatus.Permanent
      criSchemeNumber = 4 }

let ust =
    { lexicalForm = "ust"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1016 }

let ut2004 =
    { lexicalForm = "ut2004"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 6609 }

let uuaid =
    { lexicalForm = "uuaid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1015 }

module uuid =
    module in_ =
        let package =
            { lexicalForm = "uuid-in-package"
              description = None
              status = IanaStatus.Provisional
              criSchemeNumber = 4515 }

module v =
    let event_ =
        { lexicalForm = "v-event"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 15579 }

let vemmi =
    { lexicalForm = "vemmi"
      description = Some("""versatile multimedia interface""")
      status = IanaStatus.Permanent
      criSchemeNumber = 16918 }

let ventrilo =
    { lexicalForm = "ventrilo"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 12502 }

let ves =
    { lexicalForm = "ves"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 10176 }

let videotex =
    { lexicalForm = "videotex"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 2406 }

module view =
    let source =
        { lexicalForm = "view-source"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 8506 }

let vnc =
    { lexicalForm = "vnc"
      description = Some("""Remote Framebuffer Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 11537 }

module vscode =
    let insiders =
        { lexicalForm = "vscode-insiders"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 3255 }

let vsls =
    { lexicalForm = "vsls"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9816 }

let w3 =
    { lexicalForm = "w3"
      description =
        Some("""w3 
      (see reviewer notes)""")
      status = IanaStatus.Provisional
      criSchemeNumber = 11799 }

let wais =
    { lexicalForm = "wais"
      description = Some("""Wide Area Information Servers""")
      status = IanaStatus.Historical
      criSchemeNumber = 8454 }

module wasm =
    let js =
        { lexicalForm = "wasm-js"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 14709 }

let wcr =
    { lexicalForm = "wcr"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11892 }

module web =
    let ap =
        { lexicalForm = "web+ap"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 17361 }

    let interaction =
        { lexicalForm = "web+interaction"
          description = None
          status = IanaStatus.Provisional
          criSchemeNumber = 1024 }

let web3 =
    { lexicalForm = "web3"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4559 }

let webcal =
    { lexicalForm = "webcal"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4183 }

let wifi =
    { lexicalForm = "wifi"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 14867 }

let wpid =
    { lexicalForm = "wpid"
      description = None
      status = IanaStatus.Historical
      criSchemeNumber = 1658 }

let ws =
    { lexicalForm = "ws"
      description = Some("""WebSocket connections""")
      status = IanaStatus.Permanent
      criSchemeNumber = 11962 }

let wss =
    { lexicalForm = "wss"
      description = Some("""Encrypted WebSocket connections""")
      status = IanaStatus.Permanent
      criSchemeNumber = 3119 }

let wtai =
    { lexicalForm = "wtai"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 9910 }

let wyciwyg =
    { lexicalForm = "wyciwyg"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15641 }

let xcompute =
    { lexicalForm = "xcompute"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 13785 }

module xcon =
    let userid =
        { lexicalForm = "xcon-userid"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 9520 }

let xfire =
    { lexicalForm = "xfire"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 15306 }

let xftp =
    { lexicalForm = "xftp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4315 }

module xmlrpc =
    let beep =
        { lexicalForm = "xmlrpc.beep"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 3005 }

    let beeps =
        { lexicalForm = "xmlrpc.beeps"
          description = None
          status = IanaStatus.Permanent
          criSchemeNumber = 15805 }

let xmpp =
    { lexicalForm = "xmpp"
      description = Some("""Extensible Messaging and Presence Protocol""")
      status = IanaStatus.Permanent
      criSchemeNumber = 15358 }

let xrcp =
    { lexicalForm = "xrcp"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 4747 }

let xri =
    { lexicalForm = "xri"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 11255 }

let ymsgr =
    { lexicalForm = "ymsgr"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 3837 }

module z39 =
    let _50 =
        { lexicalForm = "z39.50"
          description = Some("""Z39.50 information access""")
          status = IanaStatus.Historical
          criSchemeNumber = 1319 }

    let _50r =
        { lexicalForm = "z39.50r"
          description = Some("""Z39.50 Retrieval""")
          status = IanaStatus.Permanent
          criSchemeNumber = 8159 }

    let _50s =
        { lexicalForm = "z39.50s"
          description = Some("""Z39.50 Session""")
          status = IanaStatus.Permanent
          criSchemeNumber = 6380 }

let ztdnaid =
    { lexicalForm = "ztdnaid"
      description = None
      status = IanaStatus.Provisional
      criSchemeNumber = 1008 }
