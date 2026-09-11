#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"


[<RequireQualifiedAccess>]
type IanaStatus =
    | Permanent
    | Provisional
    | Historical
// TODO look into Constrained Resource Identifiers
// https://www.ietf.org/archive/id/draft-ietf-core-href-26.html
type IanaScheme = {
    lexicalForm: string
    description: string option
    status: IanaStatus
    criSchemeNumber: int
    wellKnownUriSupport: string option
} with

    static member aaa = {

        lexicalForm = "aaa"
        description = Some("""Diameter Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 13862
        wellKnownUriSupport = None


    }

    static member aaas = {

        lexicalForm = "aaas"
        description = Some("""Diameter Protocol with Secure Transport""")
        status = IanaStatus.Permanent
        criSchemeNumber = 14526
        wellKnownUriSupport = None


    }

    static member about = {

        lexicalForm = "about"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 3786
        wellKnownUriSupport = None


    }

    static member acap = {

        lexicalForm = "acap"
        description = Some("""application configuration access protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12705
        wellKnownUriSupport = None


    }

    static member acct = {

        lexicalForm = "acct"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 10229
        wellKnownUriSupport = None


    }

    static member acd = {

        lexicalForm = "acd"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6840
        wellKnownUriSupport = None


    }

    static member acr = {

        lexicalForm = "acr"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10196
        wellKnownUriSupport = None


    }

    static member adiumxtra = {

        lexicalForm = "adiumxtra"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6634
        wellKnownUriSupport = None


    }

    static member adt = {

        lexicalForm = "adt"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5150
        wellKnownUriSupport = None


    }

    static member afp = {

        lexicalForm = "afp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13404
        wellKnownUriSupport = None


    }

    static member afs = {

        lexicalForm = "afs"
        description = Some("""Andrew File System global file names""")
        status = IanaStatus.Provisional
        criSchemeNumber = 10687
        wellKnownUriSupport = None


    }

    static member aim = {

        lexicalForm = "aim"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10327
        wellKnownUriSupport = None


    }

    static member amss = {

        lexicalForm = "amss"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10831
        wellKnownUriSupport = None


    }

    static member android = {

        lexicalForm = "android"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15061
        wellKnownUriSupport = None


    }

    static member appdata = {

        lexicalForm = "appdata"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7364
        wellKnownUriSupport = None


    }

    static member apt = {

        lexicalForm = "apt"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7856
        wellKnownUriSupport = None


    }

    static member ar = {

        lexicalForm = "ar"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5099
        wellKnownUriSupport = None


    }

    static member ari = {

        lexicalForm = "ari"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3818
        wellKnownUriSupport = None


    }

    static member ark = {

        lexicalForm = "ark"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3018
        wellKnownUriSupport = None


    }

    static member at = {

        lexicalForm = "at"
        description = Some("""at (see reviewer notes)""")
        status = IanaStatus.Provisional
        criSchemeNumber = 6007
        wellKnownUriSupport = None


    }

    static member attachment = {

        lexicalForm = "attachment"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8577
        wellKnownUriSupport = None


    }

    static member aw = {

        lexicalForm = "aw"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16051
        wellKnownUriSupport = None


    }

    static member barion = {

        lexicalForm = "barion"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10225
        wellKnownUriSupport = None


    }

    static member bb = {

        lexicalForm = "bb"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 5188
        wellKnownUriSupport = None


    }

    static member beshare = {

        lexicalForm = "beshare"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4674
        wellKnownUriSupport = None


    }

    static member bitcoin = {

        lexicalForm = "bitcoin"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9186
        wellKnownUriSupport = None


    }

    static member bitcoincash = {

        lexicalForm = "bitcoincash"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7226
        wellKnownUriSupport = None


    }

    static member bl = {

        lexicalForm = "bl"
        description = Some("""bluetooth (shortened)""")
        status = IanaStatus.Provisional
        criSchemeNumber = 10024
        wellKnownUriSupport = None


    }

    static member blob = {

        lexicalForm = "blob"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11060
        wellKnownUriSupport = None


    }

    static member bluetooth = {

        lexicalForm = "bluetooth"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12052
        wellKnownUriSupport = None


    }

    static member bolo = {

        lexicalForm = "bolo"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8765
        wellKnownUriSupport = None


    }

    static member brid = {

        lexicalForm = "brid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8251
        wellKnownUriSupport = None


    }

    static member browserext = {

        lexicalForm = "browserext"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4327
        wellKnownUriSupport = None


    }

    static member cabal = {

        lexicalForm = "cabal"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11393
        wellKnownUriSupport = None


    }

    static member calculator = {

        lexicalForm = "calculator"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3783
        wellKnownUriSupport = None


    }

    static member callto = {

        lexicalForm = "callto"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8713
        wellKnownUriSupport = None


    }

    static member cap = {

        lexicalForm = "cap"
        description = Some("""Calendar Access Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 9204
        wellKnownUriSupport = None


    }

    static member caip = {

        lexicalForm = "caip"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1001
        wellKnownUriSupport = None


    }

    static member cast = {

        lexicalForm = "cast"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1220
        wellKnownUriSupport = None


    }

    static member casts = {

        lexicalForm = "casts"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12718
        wellKnownUriSupport = None


    }

    static member chrome = {

        lexicalForm = "chrome"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5728
        wellKnownUriSupport = None


    }

    static member ``chrome-extension`` = {

        lexicalForm = "chrome-extension"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14667
        wellKnownUriSupport = None


    }

    static member cid = {

        lexicalForm = "cid"
        description = Some("""content identifier""")
        status = IanaStatus.Permanent
        criSchemeNumber = 15202
        wellKnownUriSupport = None


    }

    static member coap = {

        lexicalForm = "coap"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 0
        wellKnownUriSupport = None


    }

    static member ``coap+tcp`` = {

        lexicalForm = "coap+tcp"
        description =
            Some(
                """coap+tcp 
          (see reviewer notes)"""
            )
        status = IanaStatus.Permanent
        criSchemeNumber = 6
        wellKnownUriSupport = None


    }

    static member ``coap+ws`` = {

        lexicalForm = "coap+ws"
        description =
            Some(
                """coap+ws 
          (see reviewer notes)"""
            )
        status = IanaStatus.Permanent
        criSchemeNumber = 24
        wellKnownUriSupport = None


    }

    static member coaps = {

        lexicalForm = "coaps"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 1
        wellKnownUriSupport = None


    }

    static member ``coaps+tcp`` = {

        lexicalForm = "coaps+tcp"
        description =
            Some(
                """coaps+tcp 
          (see reviewer notes)"""
            )
        status = IanaStatus.Permanent
        criSchemeNumber = 7
        wellKnownUriSupport = None


    }

    static member ``coaps+ws`` = {

        lexicalForm = "coaps+ws"
        description =
            Some(
                """coaps+ws 
          (see reviewer notes)"""
            )
        status = IanaStatus.Permanent
        criSchemeNumber = 25
        wellKnownUriSupport = None


    }

    static member ``com-eventbrite-attendee`` = {

        lexicalForm = "com-eventbrite-attendee"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9278
        wellKnownUriSupport = None


    }

    static member content = {

        lexicalForm = "content"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8387
        wellKnownUriSupport = None


    }

    static member ``content-type`` = {

        lexicalForm = "content-type"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6030
        wellKnownUriSupport = None


    }

    static member crid = {

        lexicalForm = "crid"
        description = Some("""TV-Anytime Content Reference Identifier""")
        status = IanaStatus.Permanent
        criSchemeNumber = 5990
        wellKnownUriSupport = None


    }

    static member cstr = {

        lexicalForm = "cstr"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6730
        wellKnownUriSupport = None


    }

    static member cvs = {

        lexicalForm = "cvs"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12242
        wellKnownUriSupport = None


    }

    static member dab = {

        lexicalForm = "dab"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6774
        wellKnownUriSupport = None


    }

    static member dat = {

        lexicalForm = "dat"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10583
        wellKnownUriSupport = None


    }

    static member data = {

        lexicalForm = "data"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 1946
        wellKnownUriSupport = None


    }

    static member dav = {

        lexicalForm = "dav"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 4373
        wellKnownUriSupport = None


    }

    static member dhttp = {

        lexicalForm = "dhttp"
        description =
            Some(
                """dhttp 
          (see reviewer notes)"""
            )
        status = IanaStatus.Provisional
        criSchemeNumber = 4549
        wellKnownUriSupport = None


    }

    static member diaspora = {

        lexicalForm = "diaspora"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4598
        wellKnownUriSupport = None


    }

    static member dict = {

        lexicalForm = "dict"
        description = Some("""dictionary service protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3886
        wellKnownUriSupport = None


    }

    static member did = {

        lexicalForm = "did"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5
        wellKnownUriSupport = None


    }

    static member dilithium3 = {

        lexicalForm = "dilithium3"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1005
        wellKnownUriSupport = None


    }

    static member dis = {

        lexicalForm = "dis"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17134
        wellKnownUriSupport = None


    }

    static member ``dlna-playcontainer`` = {

        lexicalForm = "dlna-playcontainer"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5557
        wellKnownUriSupport = None


    }

    static member ``dlna-playsingle`` = {

        lexicalForm = "dlna-playsingle"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6144
        wellKnownUriSupport = None


    }

    static member dnp = {

        lexicalForm = "dnp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15819
        wellKnownUriSupport = None


    }

    static member dns = {

        lexicalForm = "dns"
        description = Some("""Domain Name System""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12932
        wellKnownUriSupport = None


    }

    static member dntp = {

        lexicalForm = "dntp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14347
        wellKnownUriSupport = None


    }

    static member doi = {

        lexicalForm = "doi"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 13014
        wellKnownUriSupport = None


    }

    static member donau = {

        lexicalForm = "donau"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10150
        wellKnownUriSupport = None


    }

    static member dpp = {

        lexicalForm = "dpp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2442
        wellKnownUriSupport = None


    }

    static member drm = {

        lexicalForm = "drm"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9859
        wellKnownUriSupport = None


    }

    static member drop = {

        lexicalForm = "drop"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 16138
        wellKnownUriSupport = None


    }

    static member dtmi = {

        lexicalForm = "dtmi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17097
        wellKnownUriSupport = None


    }

    static member dtn = {

        lexicalForm = "dtn"
        description = Some("""DTNRG research and development""")
        status = IanaStatus.Permanent
        criSchemeNumber = 7456
        wellKnownUriSupport = None


    }

    static member dvb = {

        lexicalForm = "dvb"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10380
        wellKnownUriSupport = None


    }

    static member dvx = {

        lexicalForm = "dvx"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11645
        wellKnownUriSupport = None


    }

    static member dweb = {

        lexicalForm = "dweb"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1328
        wellKnownUriSupport = None


    }

    static member ed2k = {

        lexicalForm = "ed2k"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2790
        wellKnownUriSupport = None


    }

    static member eid = {

        lexicalForm = "eid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4929
        wellKnownUriSupport = None


    }

    static member elsi = {

        lexicalForm = "elsi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13680
        wellKnownUriSupport = None


    }

    static member embedded = {

        lexicalForm = "embedded"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4193
        wellKnownUriSupport = None


    }

    static member ens = {

        lexicalForm = "ens"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1982
        wellKnownUriSupport = None


    }

    static member esim = {

        lexicalForm = "esim"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3032
        wellKnownUriSupport = None


    }

    static member ethereum = {

        lexicalForm = "ethereum"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7913
        wellKnownUriSupport = None


    }

    static member example = {

        lexicalForm = "example"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 5296
        wellKnownUriSupport = None


    }

    static member facetime = {

        lexicalForm = "facetime"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3795
        wellKnownUriSupport = None


    }

    static member fax = {

        lexicalForm = "fax"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 4053
        wellKnownUriSupport = None


    }

    static member feed = {

        lexicalForm = "feed"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7520
        wellKnownUriSupport = None


    }

    static member feedready = {

        lexicalForm = "feedready"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11824
        wellKnownUriSupport = None


    }

    static member fido = {

        lexicalForm = "fido"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5717
        wellKnownUriSupport = None


    }

    static member file = {

        lexicalForm = "file"
        description = Some("""Host-specific file names""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12068
        wellKnownUriSupport = None


    }

    static member filesystem = {

        lexicalForm = "filesystem"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 3365
        wellKnownUriSupport = None


    }

    static member finger = {

        lexicalForm = "finger"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17315
        wellKnownUriSupport = None


    }

    static member ``first-run-pen-experience`` = {

        lexicalForm = "first-run-pen-experience"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16069
        wellKnownUriSupport = None


    }

    static member fish = {

        lexicalForm = "fish"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12634
        wellKnownUriSupport = None


    }

    static member fm = {

        lexicalForm = "fm"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2806
        wellKnownUriSupport = None


    }

    static member ftp = {

        lexicalForm = "ftp"
        description = Some("""File Transfer Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 14878
        wellKnownUriSupport = None


    }

    static member ``fuchsia-pkg`` = {

        lexicalForm = "fuchsia-pkg"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12806
        wellKnownUriSupport = None


    }

    static member geo = {

        lexicalForm = "geo"
        description = Some("""Geographic Locations""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3342
        wellKnownUriSupport = None


    }

    static member gg = {

        lexicalForm = "gg"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11055
        wellKnownUriSupport = None


    }

    static member git = {

        lexicalForm = "git"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13068
        wellKnownUriSupport = None


    }

    static member gitoid = {

        lexicalForm = "gitoid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3775
        wellKnownUriSupport = None


    }

    static member gizmoproject = {

        lexicalForm = "gizmoproject"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10744
        wellKnownUriSupport = None


    }

    static member go = {

        lexicalForm = "go"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 5705
        wellKnownUriSupport = None


    }

    static member gopher = {

        lexicalForm = "gopher"
        description = Some("""The Gopher Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 8601
        wellKnownUriSupport = None


    }

    static member graph = {

        lexicalForm = "graph"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11583
        wellKnownUriSupport = None


    }

    static member grd = {

        lexicalForm = "grd"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 9444
        wellKnownUriSupport = None


    }

    static member gtalk = {

        lexicalForm = "gtalk"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4709
        wellKnownUriSupport = None


    }

    static member h323 = {

        lexicalForm = "h323"
        description = Some("""H.323""")
        status = IanaStatus.Permanent
        criSchemeNumber = 10317
        wellKnownUriSupport = None


    }

    static member ham = {

        lexicalForm = "ham"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6503
        wellKnownUriSupport = None


    }

    static member hcap = {

        lexicalForm = "hcap"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9875
        wellKnownUriSupport = None


    }

    static member hcp = {

        lexicalForm = "hcp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6024
        wellKnownUriSupport = None


    }

    static member hs20 = {

        lexicalForm = "hs20"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1273
        wellKnownUriSupport = None


    }

    static member http = {

        lexicalForm = "http"
        description = Some("""Hypertext Transfer Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 2
        wellKnownUriSupport = None


    }

    static member https = {

        lexicalForm = "https"
        description = Some("""Hypertext Transfer Protocol Secure""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3
        wellKnownUriSupport = None


    }

    static member hxxp = {

        lexicalForm = "hxxp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16728
        wellKnownUriSupport = None


    }

    static member hxxps = {

        lexicalForm = "hxxps"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4714
        wellKnownUriSupport = None


    }

    static member hydrazone = {

        lexicalForm = "hydrazone"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6632
        wellKnownUriSupport = None


    }

    static member hyper = {

        lexicalForm = "hyper"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12876
        wellKnownUriSupport = None


    }

    static member i0 = {

        lexicalForm = "i0"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10328
        wellKnownUriSupport = None


    }

    static member iax = {

        lexicalForm = "iax"
        description = Some("""Inter-Asterisk eXchange Version 2""")
        status = IanaStatus.Permanent
        criSchemeNumber = 7126
        wellKnownUriSupport = None


    }

    static member ibi = {

        lexicalForm = "ibi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1002
        wellKnownUriSupport = None


    }

    static member ``ibi-`` = {

        lexicalForm = "ibi-"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1003
        wellKnownUriSupport = None


    }

    static member ilstring = {

        lexicalForm = "ilstring"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12237
        wellKnownUriSupport = None


    }

    static member icap = {

        lexicalForm = "icap"
        description = Some("""Internet Content Adaptation Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12566
        wellKnownUriSupport = None


    }

    static member icon = {

        lexicalForm = "icon"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14868
        wellKnownUriSupport = None


    }

    static member im = {

        lexicalForm = "im"
        description = Some("""Instant Messaging""")
        status = IanaStatus.Permanent
        criSchemeNumber = 6883
        wellKnownUriSupport = None


    }

    static member imap = {

        lexicalForm = "imap"
        description = Some("""internet message access protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 10119
        wellKnownUriSupport = None


    }

    static member info = {

        lexicalForm = "info"
        description =
            Some(
                """Information Assets with Identifiers in Public Namespaces. 
           (section 3) defines an "info" registry 
            of public namespaces, which is maintained by NISO and can be accessed 
            from ."""
            )
        status = IanaStatus.Permanent
        criSchemeNumber = 13846
        wellKnownUriSupport = None


    }

    static member iotdisco = {

        lexicalForm = "iotdisco"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17170
        wellKnownUriSupport = None


    }

    static member ipfs = {

        lexicalForm = "ipfs"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15972
        wellKnownUriSupport = None


    }

    static member ipn = {

        lexicalForm = "ipn"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 8775
        wellKnownUriSupport = None


    }

    static member ipns = {

        lexicalForm = "ipns"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16933
        wellKnownUriSupport = None


    }

    static member ipp = {

        lexicalForm = "ipp"
        description = Some("""Internet Printing Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 9318
        wellKnownUriSupport = None


    }

    static member ipps = {

        lexicalForm = "ipps"
        description = Some("""Internet Printing Protocol over HTTPS""")
        status = IanaStatus.Permanent
        criSchemeNumber = 4419
        wellKnownUriSupport = None


    }

    static member irc = {

        lexicalForm = "irc"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5425
        wellKnownUriSupport = None


    }

    static member irc6 = {

        lexicalForm = "irc6"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1905
        wellKnownUriSupport = None


    }

    static member ircs = {

        lexicalForm = "ircs"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8687
        wellKnownUriSupport = None


    }

    static member iris = {

        lexicalForm = "iris"
        description = Some("""Internet Registry Information Service""")
        status = IanaStatus.Permanent
        criSchemeNumber = 13986
        wellKnownUriSupport = None


    }

    static member ``iris.beep`` = {

        lexicalForm = "iris.beep"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 15639
        wellKnownUriSupport = None


    }

    static member ``iris.lwz`` = {

        lexicalForm = "iris.lwz"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 4590
        wellKnownUriSupport = None


    }

    static member ``iris.xpc`` = {

        lexicalForm = "iris.xpc"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 12422
        wellKnownUriSupport = None


    }

    static member ``iris.xpcs`` = {

        lexicalForm = "iris.xpcs"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 16134
        wellKnownUriSupport = None


    }

    static member isostore = {

        lexicalForm = "isostore"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7225
        wellKnownUriSupport = None


    }

    static member itms = {

        lexicalForm = "itms"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14830
        wellKnownUriSupport = None


    }

    static member jabber = {

        lexicalForm = "jabber"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 6109
        wellKnownUriSupport = None


    }

    static member jar = {

        lexicalForm = "jar"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1578
        wellKnownUriSupport = None


    }

    static member jms = {

        lexicalForm = "jms"
        description = Some("""Java Message Service""")
        status = IanaStatus.Provisional
        criSchemeNumber = 3634
        wellKnownUriSupport = None


    }

    static member keyparc = {

        lexicalForm = "keyparc"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9770
        wellKnownUriSupport = None


    }

    static member lastfm = {

        lexicalForm = "lastfm"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11742
        wellKnownUriSupport = None


    }

    static member lbry = {

        lexicalForm = "lbry"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14010
        wellKnownUriSupport = None


    }

    static member ldap = {

        lexicalForm = "ldap"
        description = Some("""Lightweight Directory Access Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 13442
        wellKnownUriSupport = None


    }

    static member ldaps = {

        lexicalForm = "ldaps"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3906
        wellKnownUriSupport = None


    }

    static member leaptofrogans = {

        lexicalForm = "leaptofrogans"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 16281
        wellKnownUriSupport = None


    }

    static member lid = {

        lexicalForm = "lid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10247
        wellKnownUriSupport = None


    }

    static member linkid = {

        lexicalForm = "linkid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1819
        wellKnownUriSupport = None


    }

    static member lorawan = {

        lexicalForm = "lorawan"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11718
        wellKnownUriSupport = None


    }

    static member lpa = {

        lexicalForm = "lpa"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6658
        wellKnownUriSupport = None


    }

    static member lvlt = {

        lexicalForm = "lvlt"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5480
        wellKnownUriSupport = None


    }

    static member machineProvisioningProgressReporter = {

        lexicalForm = "machineProvisioningProgressReporter"
        description = Some("""Windows Autopilot Modern Device Management status updates""")
        status = IanaStatus.Provisional
        criSchemeNumber = 5477
        wellKnownUriSupport = None


    }

    static member magnet = {

        lexicalForm = "magnet"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9805
        wellKnownUriSupport = None


    }

    static member mailserver = {

        lexicalForm = "mailserver"
        description = Some("""Access to data available from mail servers""")
        status = IanaStatus.Historical
        criSchemeNumber = 10868
        wellKnownUriSupport = None


    }

    static member mailto = {

        lexicalForm = "mailto"
        description = Some("""Electronic mail address""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12102
        wellKnownUriSupport = None


    }

    static member maps = {

        lexicalForm = "maps"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14153
        wellKnownUriSupport = None


    }

    static member market = {

        lexicalForm = "market"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14595
        wellKnownUriSupport = None


    }

    static member matrix = {

        lexicalForm = "matrix"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9487
        wellKnownUriSupport = None


    }

    static member message = {

        lexicalForm = "message"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14460
        wellKnownUriSupport = None


    }

    static member ``microsoft.windows.camera`` = {

        lexicalForm = "microsoft.windows.camera"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11857
        wellKnownUriSupport = None


    }

    static member ``microsoft.windows.camera.multipicker`` = {

        lexicalForm = "microsoft.windows.camera.multipicker"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7942
        wellKnownUriSupport = None


    }

    static member ``microsoft.windows.camera.picker`` = {

        lexicalForm = "microsoft.windows.camera.picker"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5883
        wellKnownUriSupport = None


    }

    static member mid = {

        lexicalForm = "mid"
        description = Some("""message identifier""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3646
        wellKnownUriSupport = None


    }

    static member mms = {

        lexicalForm = "mms"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12337
        wellKnownUriSupport = None


    }

    static member modem = {

        lexicalForm = "modem"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 9154
        wellKnownUriSupport = None


    }

    static member mongodb = {

        lexicalForm = "mongodb"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13372
        wellKnownUriSupport = None


    }

    static member moz = {

        lexicalForm = "moz"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6808
        wellKnownUriSupport = None


    }

    static member mqtt = {

        lexicalForm = "mqtt"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10740
        wellKnownUriSupport = None


    }

    static member mqtts = {

        lexicalForm = "mqtts"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14906
        wellKnownUriSupport = None


    }

    static member ``ms-access`` = {

        lexicalForm = "ms-access"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6863
        wellKnownUriSupport = None


    }

    static member ``ms-appinstaller`` = {

        lexicalForm = "ms-appinstaller"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5152
        wellKnownUriSupport = None


    }

    static member ``ms-browser-extension`` = {

        lexicalForm = "ms-browser-extension"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14090
        wellKnownUriSupport = None


    }

    static member ``ms-calculator`` = {

        lexicalForm = "ms-calculator"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3690
        wellKnownUriSupport = None


    }

    static member ``ms-drive-to`` = {

        lexicalForm = "ms-drive-to"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4102
        wellKnownUriSupport = None


    }

    static member ``ms-enrollment`` = {

        lexicalForm = "ms-enrollment"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14310
        wellKnownUriSupport = None


    }

    static member ``ms-excel`` = {

        lexicalForm = "ms-excel"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5536
        wellKnownUriSupport = None


    }

    static member ``ms-eyecontrolspeech`` = {

        lexicalForm = "ms-eyecontrolspeech"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17381
        wellKnownUriSupport = None


    }

    static member ``ms-gamebarservices`` = {

        lexicalForm = "ms-gamebarservices"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12823
        wellKnownUriSupport = None


    }

    static member ``ms-gamingoverlay`` = {

        lexicalForm = "ms-gamingoverlay"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1059
        wellKnownUriSupport = None


    }

    static member ``ms-getoffice`` = {

        lexicalForm = "ms-getoffice"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14366
        wellKnownUriSupport = None


    }

    static member ``ms-help`` = {

        lexicalForm = "ms-help"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7809
        wellKnownUriSupport = None


    }

    static member ``ms-infopath`` = {

        lexicalForm = "ms-infopath"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8830
        wellKnownUriSupport = None


    }

    static member ``ms-inputapp`` = {

        lexicalForm = "ms-inputapp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6792
        wellKnownUriSupport = None


    }

    static member ``ms-launchremotedesktop`` = {

        lexicalForm = "ms-launchremotedesktop"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12174
        wellKnownUriSupport = None


    }

    static member ``ms-lockscreencomponent-config`` = {

        lexicalForm = "ms-lockscreencomponent-config"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12525
        wellKnownUriSupport = None


    }

    static member ``ms-media-stream-id`` = {

        lexicalForm = "ms-media-stream-id"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6388
        wellKnownUriSupport = None


    }

    static member ``ms-meetnow`` = {

        lexicalForm = "ms-meetnow"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15645
        wellKnownUriSupport = None


    }

    static member ``ms-mixedrealitycapture`` = {

        lexicalForm = "ms-mixedrealitycapture"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6411
        wellKnownUriSupport = None


    }

    static member ``ms-mobileplans`` = {

        lexicalForm = "ms-mobileplans"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11945
        wellKnownUriSupport = None


    }

    static member ``ms-newsandinterests`` = {

        lexicalForm = "ms-newsandinterests"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2945
        wellKnownUriSupport = None


    }

    static member ``ms-officeapp`` = {

        lexicalForm = "ms-officeapp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14168
        wellKnownUriSupport = None


    }

    static member ``ms-people`` = {

        lexicalForm = "ms-people"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1528
        wellKnownUriSupport = None


    }

    static member ``ms-personacard`` = {

        lexicalForm = "ms-personacard"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1562
        wellKnownUriSupport = None


    }

    static member ``ms-powerpoint`` = {

        lexicalForm = "ms-powerpoint"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16645
        wellKnownUriSupport = None


    }

    static member ``ms-project`` = {

        lexicalForm = "ms-project"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11130
        wellKnownUriSupport = None


    }

    static member ``ms-publisher`` = {

        lexicalForm = "ms-publisher"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16194
        wellKnownUriSupport = None


    }

    static member ``ms-recall`` = {

        lexicalForm = "ms-recall"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10183
        wellKnownUriSupport = None


    }

    static member ``ms-remotedesktop`` = {

        lexicalForm = "ms-remotedesktop"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5347
        wellKnownUriSupport = None


    }

    static member ``ms-remotedesktop-launch`` = {

        lexicalForm = "ms-remotedesktop-launch"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8085
        wellKnownUriSupport = None


    }

    static member ``ms-restoretabcompanion`` = {

        lexicalForm = "ms-restoretabcompanion"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17175
        wellKnownUriSupport = None


    }

    static member ``ms-screenclip`` = {

        lexicalForm = "ms-screenclip"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10518
        wellKnownUriSupport = None


    }

    static member ``ms-screensketch`` = {

        lexicalForm = "ms-screensketch"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9453
        wellKnownUriSupport = None


    }

    static member ``ms-search`` = {

        lexicalForm = "ms-search"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14034
        wellKnownUriSupport = None


    }

    static member ``ms-search-repair`` = {

        lexicalForm = "ms-search-repair"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15679
        wellKnownUriSupport = None


    }

    static member ``ms-secondary-screen-controller`` = {

        lexicalForm = "ms-secondary-screen-controller"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13098
        wellKnownUriSupport = None


    }

    static member ``ms-secondary-screen-setup`` = {

        lexicalForm = "ms-secondary-screen-setup"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15254
        wellKnownUriSupport = None


    }

    static member ``ms-settings`` = {

        lexicalForm = "ms-settings"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9075
        wellKnownUriSupport = None


    }

    static member ``ms-settings-airplanemode`` = {

        lexicalForm = "ms-settings-airplanemode"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5109
        wellKnownUriSupport = None


    }

    static member ``ms-settings-bluetooth`` = {

        lexicalForm = "ms-settings-bluetooth"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14180
        wellKnownUriSupport = None


    }

    static member ``ms-settings-camera`` = {

        lexicalForm = "ms-settings-camera"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15773
        wellKnownUriSupport = None


    }

    static member ``ms-settings-cellular`` = {

        lexicalForm = "ms-settings-cellular"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15361
        wellKnownUriSupport = None


    }

    static member ``ms-settings-cloudstorage`` = {

        lexicalForm = "ms-settings-cloudstorage"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10640
        wellKnownUriSupport = None


    }

    static member ``ms-settings-connectabledevices`` = {

        lexicalForm = "ms-settings-connectabledevices"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11351
        wellKnownUriSupport = None


    }

    static member ``ms-settings-displays-topology`` = {

        lexicalForm = "ms-settings-displays-topology"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12029
        wellKnownUriSupport = None


    }

    static member ``ms-settings-emailandaccounts`` = {

        lexicalForm = "ms-settings-emailandaccounts"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11072
        wellKnownUriSupport = None


    }

    static member ``ms-settings-language`` = {

        lexicalForm = "ms-settings-language"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9981
        wellKnownUriSupport = None


    }

    static member ``ms-settings-location`` = {

        lexicalForm = "ms-settings-location"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10373
        wellKnownUriSupport = None


    }

    static member ``ms-settings-lock`` = {

        lexicalForm = "ms-settings-lock"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11950
        wellKnownUriSupport = None


    }

    static member ``ms-settings-nfctransactions`` = {

        lexicalForm = "ms-settings-nfctransactions"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10591
        wellKnownUriSupport = None


    }

    static member ``ms-settings-notifications`` = {

        lexicalForm = "ms-settings-notifications"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7868
        wellKnownUriSupport = None


    }

    static member ``ms-settings-power`` = {

        lexicalForm = "ms-settings-power"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13026
        wellKnownUriSupport = None


    }

    static member ``ms-settings-privacy`` = {

        lexicalForm = "ms-settings-privacy"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9198
        wellKnownUriSupport = None


    }

    static member ``ms-settings-proximity`` = {

        lexicalForm = "ms-settings-proximity"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3959
        wellKnownUriSupport = None


    }

    static member ``ms-settings-screenrotation`` = {

        lexicalForm = "ms-settings-screenrotation"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6755
        wellKnownUriSupport = None


    }

    static member ``ms-settings-wifi`` = {

        lexicalForm = "ms-settings-wifi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15994
        wellKnownUriSupport = None


    }

    static member ``ms-settings-workplace`` = {

        lexicalForm = "ms-settings-workplace"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14936
        wellKnownUriSupport = None


    }

    static member ``ms-spd`` = {

        lexicalForm = "ms-spd"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6189
        wellKnownUriSupport = None


    }

    static member ``ms-stickers`` = {

        lexicalForm = "ms-stickers"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10361
        wellKnownUriSupport = None


    }

    static member ``ms-sttoverlay`` = {

        lexicalForm = "ms-sttoverlay"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5410
        wellKnownUriSupport = None


    }

    static member ``ms-transit-to`` = {

        lexicalForm = "ms-transit-to"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7743
        wellKnownUriSupport = None


    }

    static member ``ms-useractivityset`` = {

        lexicalForm = "ms-useractivityset"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9136
        wellKnownUriSupport = None


    }

    static member ``ms-uup`` = {

        lexicalForm = "ms-uup"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1560
        wellKnownUriSupport = None


    }

    static member ``ms-virtualtouchpad`` = {

        lexicalForm = "ms-virtualtouchpad"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15776
        wellKnownUriSupport = None


    }

    static member ``ms-visio`` = {

        lexicalForm = "ms-visio"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15163
        wellKnownUriSupport = None


    }

    static member ``ms-walk-to`` = {

        lexicalForm = "ms-walk-to"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14364
        wellKnownUriSupport = None


    }

    static member ``ms-whiteboard`` = {

        lexicalForm = "ms-whiteboard"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11467
        wellKnownUriSupport = None


    }

    static member ``ms-whiteboard-cmd`` = {

        lexicalForm = "ms-whiteboard-cmd"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14860
        wellKnownUriSupport = None


    }

    static member ``ms-widgetboard`` = {

        lexicalForm = "ms-widgetboard"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12603
        wellKnownUriSupport = None


    }

    static member ``ms-widgets`` = {

        lexicalForm = "ms-widgets"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4613
        wellKnownUriSupport = None


    }

    static member ``ms-word`` = {

        lexicalForm = "ms-word"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16585
        wellKnownUriSupport = None


    }

    static member msnim = {

        lexicalForm = "msnim"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8041
        wellKnownUriSupport = None


    }

    static member msrp = {

        lexicalForm = "msrp"
        description = Some("""Message Session Relay Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 11315
        wellKnownUriSupport = None


    }

    static member msrps = {

        lexicalForm = "msrps"
        description = Some("""Message Session Relay Protocol Secure""")
        status = IanaStatus.Permanent
        criSchemeNumber = 13440
        wellKnownUriSupport = None


    }

    static member mss = {

        lexicalForm = "mss"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12493
        wellKnownUriSupport = None


    }

    static member mt = {

        lexicalForm = "mt"
        description = Some("""Matter protocol on-boarding payloads that are encoded for use in QR Codes and/or NFC Tags""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12699
        wellKnownUriSupport = None


    }

    static member mtqp = {

        lexicalForm = "mtqp"
        description = Some("""Message Tracking Query Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3358
        wellKnownUriSupport = None


    }

    static member mtrust = {

        lexicalForm = "mtrust"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13062
        wellKnownUriSupport = None


    }

    static member mumble = {

        lexicalForm = "mumble"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11804
        wellKnownUriSupport = None


    }

    static member mupdate = {

        lexicalForm = "mupdate"
        description = Some("""Mailbox Update (MUPDATE) Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12569
        wellKnownUriSupport = None


    }

    static member mvn = {

        lexicalForm = "mvn"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9585
        wellKnownUriSupport = None


    }

    static member mvrp = {

        lexicalForm = "mvrp"
        description =
            Some(
                """mvrp
          (see reviewer notes)"""
            )
        status = IanaStatus.Provisional
        criSchemeNumber = 13451
        wellKnownUriSupport = None


    }

    static member mvrps = {

        lexicalForm = "mvrps"
        description =
            Some(
                """mvrps
          (see reviewer notes)"""
            )
        status = IanaStatus.Provisional
        criSchemeNumber = 13228
        wellKnownUriSupport = None


    }

    static member news = {

        lexicalForm = "news"
        description = Some("""USENET news""")
        status = IanaStatus.Permanent
        criSchemeNumber = 1895
        wellKnownUriSupport = None


    }

    static member nfs = {

        lexicalForm = "nfs"
        description = Some("""network file system protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 6516
        wellKnownUriSupport = None


    }

    static member ni = {

        lexicalForm = "ni"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 10926
        wellKnownUriSupport = None


    }

    static member nih = {

        lexicalForm = "nih"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 11428
        wellKnownUriSupport = None


    }

    static member nntp = {

        lexicalForm = "nntp"
        description = Some("""USENET news using NNTP access""")
        status = IanaStatus.Permanent
        criSchemeNumber = 13499
        wellKnownUriSupport = None


    }

    static member notes = {

        lexicalForm = "notes"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8766
        wellKnownUriSupport = None


    }

    static member num = {

        lexicalForm = "num"
        description = Some("""Namespace Utility Modules""")
        status = IanaStatus.Provisional
        criSchemeNumber = 9965
        wellKnownUriSupport = None


    }

    static member ocf = {

        lexicalForm = "ocf"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10241
        wellKnownUriSupport = None


    }

    static member oid = {

        lexicalForm = "oid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16079
        wellKnownUriSupport = None


    }

    static member onenote = {

        lexicalForm = "onenote"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13608
        wellKnownUriSupport = None


    }

    static member ``onenote-cmd`` = {

        lexicalForm = "onenote-cmd"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16632
        wellKnownUriSupport = None


    }

    static member opaquelocktoken = {

        lexicalForm = "opaquelocktoken"
        description = Some("""opaquelocktokent""")
        status = IanaStatus.Permanent
        criSchemeNumber = 6341
        wellKnownUriSupport = None


    }

    static member openid = {

        lexicalForm = "openid"
        description = Some("""OpenID Connect""")
        status = IanaStatus.Provisional
        criSchemeNumber = 1242
        wellKnownUriSupport = None


    }

    static member openpgp4fpr = {

        lexicalForm = "openpgp4fpr"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13094
        wellKnownUriSupport = None


    }

    static member otpauth = {

        lexicalForm = "otpauth"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13829
        wellKnownUriSupport = None


    }

    static member p1 = {

        lexicalForm = "p1"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 14982
        wellKnownUriSupport = None


    }

    static member pack = {

        lexicalForm = "pack"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 13348
        wellKnownUriSupport = None


    }

    static member palm = {

        lexicalForm = "palm"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10238
        wellKnownUriSupport = None


    }

    static member paparazzi = {

        lexicalForm = "paparazzi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12599
        wellKnownUriSupport = None


    }

    static member payment = {

        lexicalForm = "payment"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 1762
        wellKnownUriSupport = None


    }

    static member payto = {

        lexicalForm = "payto"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6992
        wellKnownUriSupport = None


    }

    static member pkcs11 = {

        lexicalForm = "pkcs11"
        description = Some("""PKCS#11""")
        status = IanaStatus.Permanent
        criSchemeNumber = 9312
        wellKnownUriSupport = None


    }

    static member platform = {

        lexicalForm = "platform"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2754
        wellKnownUriSupport = None


    }

    static member pop = {

        lexicalForm = "pop"
        description = Some("""Post Office Protocol v3""")
        status = IanaStatus.Permanent
        criSchemeNumber = 10551
        wellKnownUriSupport = None


    }

    static member pres = {

        lexicalForm = "pres"
        description = Some("""Presence""")
        status = IanaStatus.Permanent
        criSchemeNumber = 14972
        wellKnownUriSupport = None


    }

    static member prospero = {

        lexicalForm = "prospero"
        description = Some("""Prospero Directory Service""")
        status = IanaStatus.Historical
        criSchemeNumber = 14477
        wellKnownUriSupport = None


    }

    static member proxy = {

        lexicalForm = "proxy"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3503
        wellKnownUriSupport = None


    }

    static member psyc = {

        lexicalForm = "psyc"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1466
        wellKnownUriSupport = None


    }

    static member pttp = {

        lexicalForm = "pttp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6903
        wellKnownUriSupport = None


    }

    static member pwid = {

        lexicalForm = "pwid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17068
        wellKnownUriSupport = None


    }

    static member qb = {

        lexicalForm = "qb"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12478
        wellKnownUriSupport = None


    }

    static member query = {

        lexicalForm = "query"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10147
        wellKnownUriSupport = None


    }

    static member ``quic-transport`` = {

        lexicalForm = "quic-transport"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6462
        wellKnownUriSupport = None


    }

    static member redis = {

        lexicalForm = "redis"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8099
        wellKnownUriSupport = None


    }

    static member rediss = {

        lexicalForm = "rediss"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9338
        wellKnownUriSupport = None


    }

    static member reload = {

        lexicalForm = "reload"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 12726
        wellKnownUriSupport = None


    }

    static member res = {

        lexicalForm = "res"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4153
        wellKnownUriSupport = None


    }

    static member resource = {

        lexicalForm = "resource"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2284
        wellKnownUriSupport = None


    }

    static member rmi = {

        lexicalForm = "rmi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16292
        wellKnownUriSupport = None


    }

    static member rsync = {

        lexicalForm = "rsync"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 16884
        wellKnownUriSupport = None


    }

    static member rtmfp = {

        lexicalForm = "rtmfp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3348
        wellKnownUriSupport = None


    }

    static member rtmp = {

        lexicalForm = "rtmp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3920
        wellKnownUriSupport = None


    }

    static member rtsp = {

        lexicalForm = "rtsp"
        description = Some("""Real-Time Streaming Protocol (RTSP)""")
        status = IanaStatus.Permanent
        criSchemeNumber = 15267
        wellKnownUriSupport = None


    }

    static member rtsps = {

        lexicalForm = "rtsps"
        description = Some("""Real-Time Streaming Protocol (RTSP) over TLS""")
        status = IanaStatus.Permanent
        criSchemeNumber = 4619
        wellKnownUriSupport = None


    }

    static member rtspu = {

        lexicalForm = "rtspu"
        description = Some("""Real-Time Streaming Protocol (RTSP) over unreliable datagram transport""")
        status = IanaStatus.Permanent
        criSchemeNumber = 11999
        wellKnownUriSupport = None


    }

    static member sarif = {

        lexicalForm = "sarif"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13650
        wellKnownUriSupport = None


    }

    static member secondlife = {

        lexicalForm = "secondlife"
        description = Some("""query""")
        status = IanaStatus.Provisional
        criSchemeNumber = 16729
        wellKnownUriSupport = None


    }

    static member ``secret-token`` = {

        lexicalForm = "secret-token"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7074
        wellKnownUriSupport = None


    }

    static member service = {

        lexicalForm = "service"
        description = Some("""service location""")
        status = IanaStatus.Permanent
        criSchemeNumber = 17264
        wellKnownUriSupport = None


    }

    static member session = {

        lexicalForm = "session"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 4355
        wellKnownUriSupport = None


    }

    static member sftp = {

        lexicalForm = "sftp"
        description = Some("""query""")
        status = IanaStatus.Provisional
        criSchemeNumber = 5492
        wellKnownUriSupport = None


    }

    static member sgn = {

        lexicalForm = "sgn"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4882
        wellKnownUriSupport = None


    }

    static member shc = {

        lexicalForm = "shc"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5823
        wellKnownUriSupport = None


    }

    static member shelter = {

        lexicalForm = "shelter"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15461
        wellKnownUriSupport = None


    }

    static member sieve = {

        lexicalForm = "sieve"
        description = Some("""ManageSieve Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 5472
        wellKnownUriSupport = None


    }

    static member simpleledger = {

        lexicalForm = "simpleledger"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9544
        wellKnownUriSupport = None


    }

    static member simplex = {

        lexicalForm = "simplex"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15118
        wellKnownUriSupport = None


    }

    static member sip = {

        lexicalForm = "sip"
        description = Some("""session initiation protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 12644
        wellKnownUriSupport = None


    }

    static member sips = {

        lexicalForm = "sips"
        description = Some("""secure session initiation protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 9535
        wellKnownUriSupport = None


    }

    static member skype = {

        lexicalForm = "skype"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2326
        wellKnownUriSupport = None


    }

    static member smb = {

        lexicalForm = "smb"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7285
        wellKnownUriSupport = None


    }

    static member smp = {

        lexicalForm = "smp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11533
        wellKnownUriSupport = None


    }

    static member sms = {

        lexicalForm = "sms"
        description = Some("""Short Message Service""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3524
        wellKnownUriSupport = None


    }

    static member smtp = {

        lexicalForm = "smtp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13340
        wellKnownUriSupport = None


    }

    static member snews = {

        lexicalForm = "snews"
        description = Some("""NNTP over SSL/TLS""")
        status = IanaStatus.Historical
        criSchemeNumber = 13285
        wellKnownUriSupport = None


    }

    static member snmp = {

        lexicalForm = "snmp"
        description = Some("""Simple Network Management Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 1165
        wellKnownUriSupport = None


    }

    static member ``soap.beep`` = {

        lexicalForm = "soap.beep"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 8519
        wellKnownUriSupport = None


    }

    static member ``soap.beeps`` = {

        lexicalForm = "soap.beeps"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 16300
        wellKnownUriSupport = None


    }

    static member soldat = {

        lexicalForm = "soldat"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6349
        wellKnownUriSupport = None


    }

    static member spacify = {

        lexicalForm = "spacify"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1000
        wellKnownUriSupport = None


    }

    static member spiffe = {

        lexicalForm = "spiffe"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8093
        wellKnownUriSupport = None


    }

    static member spotify = {

        lexicalForm = "spotify"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12732
        wellKnownUriSupport = None


    }

    static member ssb = {

        lexicalForm = "ssb"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12400
        wellKnownUriSupport = None


    }

    static member ssh = {

        lexicalForm = "ssh"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7667
        wellKnownUriSupport = None


    }

    static member starknet = {

        lexicalForm = "starknet"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12458
        wellKnownUriSupport = None


    }

    static member steam = {

        lexicalForm = "steam"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5134
        wellKnownUriSupport = None


    }

    static member stun = {

        lexicalForm = "stun"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 14627
        wellKnownUriSupport = None


    }

    static member stuns = {

        lexicalForm = "stuns"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 14901
        wellKnownUriSupport = None


    }

    static member submit = {

        lexicalForm = "submit"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4951
        wellKnownUriSupport = None


    }

    static member svn = {

        lexicalForm = "svn"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13923
        wellKnownUriSupport = None


    }

    static member swh = {

        lexicalForm = "swh"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17039
        wellKnownUriSupport = None


    }

    static member swid = {

        lexicalForm = "swid"
        description = Some("""swid (see reviewer notes)""")
        status = IanaStatus.Provisional
        criSchemeNumber = 14162
        wellKnownUriSupport = None


    }

    static member swidpath = {

        lexicalForm = "swidpath"
        description = Some("""swidpath (see reviewer notes)""")
        status = IanaStatus.Provisional
        criSchemeNumber = 5825
        wellKnownUriSupport = None


    }

    static member tag = {

        lexicalForm = "tag"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 16377
        wellKnownUriSupport = None


    }

    static member taler = {

        lexicalForm = "taler"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2796
        wellKnownUriSupport = None


    }

    static member teamspeak = {

        lexicalForm = "teamspeak"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6924
        wellKnownUriSupport = None


    }

    static member teapot = {

        lexicalForm = "teapot"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15026
        wellKnownUriSupport = None


    }

    static member teapots = {

        lexicalForm = "teapots"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3375
        wellKnownUriSupport = None


    }

    static member tel = {

        lexicalForm = "tel"
        description = Some("""telephone""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3143
        wellKnownUriSupport = None


    }

    static member teliaeid = {

        lexicalForm = "teliaeid"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13362
        wellKnownUriSupport = None


    }

    static member telnet = {

        lexicalForm = "telnet"
        description = Some("""Reference to interactive sessions""")
        status = IanaStatus.Permanent
        criSchemeNumber = 10995
        wellKnownUriSupport = None


    }

    static member tftp = {

        lexicalForm = "tftp"
        description = Some("""Trivial File Transfer Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 8300
        wellKnownUriSupport = None


    }

    static member things = {

        lexicalForm = "things"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 2154
        wellKnownUriSupport = None


    }

    static member thismessage = {

        lexicalForm = "thismessage"
        description = Some("""multipart/related relative reference resolution""")
        status = IanaStatus.Permanent
        criSchemeNumber = 14367
        wellKnownUriSupport = None


    }

    static member thzp = {

        lexicalForm = "thzp"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 11820
        wellKnownUriSupport = None


    }

    static member tip = {

        lexicalForm = "tip"
        description = Some("""Transaction Internet Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 6651
        wellKnownUriSupport = None


    }

    static member tn3270 = {

        lexicalForm = "tn3270"
        description = Some("""Interactive 3270 emulation sessions""")
        status = IanaStatus.Permanent
        criSchemeNumber = 14962
        wellKnownUriSupport = None


    }

    static member tool = {

        lexicalForm = "tool"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15230
        wellKnownUriSupport = None


    }

    static member turn = {

        lexicalForm = "turn"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 10333
        wellKnownUriSupport = None


    }

    static member turns = {

        lexicalForm = "turns"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 1926
        wellKnownUriSupport = None


    }

    static member tv = {

        lexicalForm = "tv"
        description = Some("""TV Broadcasts""")
        status = IanaStatus.Permanent
        criSchemeNumber = 7923
        wellKnownUriSupport = None


    }

    static member udp = {

        lexicalForm = "udp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 5217
        wellKnownUriSupport = None


    }

    static member unreal = {

        lexicalForm = "unreal"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15206
        wellKnownUriSupport = None


    }

    static member upn = {

        lexicalForm = "upn"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 1004
        wellKnownUriSupport = None


    }

    static member upt = {

        lexicalForm = "upt"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 2747
        wellKnownUriSupport = None


    }

    static member urn = {

        lexicalForm = "urn"
        description = Some("""Uniform Resource Names""")
        status = IanaStatus.Permanent
        criSchemeNumber = 4
        wellKnownUriSupport = None


    }

    static member ut2004 = {

        lexicalForm = "ut2004"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 6609
        wellKnownUriSupport = None


    }

    static member ``uuid-in-package`` = {

        lexicalForm = "uuid-in-package"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4515
        wellKnownUriSupport = None


    }

    static member ``v-event`` = {

        lexicalForm = "v-event"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15579
        wellKnownUriSupport = None


    }

    static member vemmi = {

        lexicalForm = "vemmi"
        description = Some("""versatile multimedia interface""")
        status = IanaStatus.Permanent
        criSchemeNumber = 16918
        wellKnownUriSupport = None


    }

    static member ventrilo = {

        lexicalForm = "ventrilo"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 12502
        wellKnownUriSupport = None


    }

    static member ves = {

        lexicalForm = "ves"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 10176
        wellKnownUriSupport = None


    }

    static member videotex = {

        lexicalForm = "videotex"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 2406
        wellKnownUriSupport = None


    }

    static member ``view-source`` = {

        lexicalForm = "view-source"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 8506
        wellKnownUriSupport = None


    }

    static member vnc = {

        lexicalForm = "vnc"
        description = Some("""Remote Framebuffer Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 11537
        wellKnownUriSupport = None


    }

    static member vscode = {

        lexicalForm = "vscode"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 7812
        wellKnownUriSupport = None


    }

    static member ``vscode-insiders`` = {

        lexicalForm = "vscode-insiders"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3255
        wellKnownUriSupport = None


    }

    static member vsls = {

        lexicalForm = "vsls"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9816
        wellKnownUriSupport = None


    }

    static member w3 = {

        lexicalForm = "w3"
        description =
            Some(
                """w3 
          (see reviewer notes)"""
            )
        status = IanaStatus.Provisional
        criSchemeNumber = 11799
        wellKnownUriSupport = None


    }

    static member wais = {

        lexicalForm = "wais"
        description = Some("""Wide Area Information Servers""")
        status = IanaStatus.Historical
        criSchemeNumber = 8454
        wellKnownUriSupport = None


    }

    static member wasm = {

        lexicalForm = "wasm"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15741
        wellKnownUriSupport = None


    }

    static member ``wasm-js`` = {

        lexicalForm = "wasm-js"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14709
        wellKnownUriSupport = None


    }

    static member wcr = {

        lexicalForm = "wcr"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11892
        wellKnownUriSupport = None


    }

    static member ``web+ap`` = {

        lexicalForm = "web+ap"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 17361
        wellKnownUriSupport = None


    }

    static member web3 = {

        lexicalForm = "web3"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4559
        wellKnownUriSupport = None


    }

    static member webcal = {

        lexicalForm = "webcal"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4183
        wellKnownUriSupport = None


    }

    static member wifi = {

        lexicalForm = "wifi"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 14867
        wellKnownUriSupport = None


    }

    static member wpid = {

        lexicalForm = "wpid"
        description = None
        status = IanaStatus.Historical
        criSchemeNumber = 1658
        wellKnownUriSupport = None


    }

    static member ws = {

        lexicalForm = "ws"
        description = Some("""WebSocket connections""")
        status = IanaStatus.Permanent
        criSchemeNumber = 11962
        wellKnownUriSupport = None


    }

    static member wss = {

        lexicalForm = "wss"
        description = Some("""Encrypted WebSocket connections""")
        status = IanaStatus.Permanent
        criSchemeNumber = 3119
        wellKnownUriSupport = None


    }

    static member wtai = {

        lexicalForm = "wtai"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 9910
        wellKnownUriSupport = None


    }

    static member wyciwyg = {

        lexicalForm = "wyciwyg"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15641
        wellKnownUriSupport = None


    }

    static member xcompute = {

        lexicalForm = "xcompute"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 13785
        wellKnownUriSupport = None


    }

    static member xcon = {

        lexicalForm = "xcon"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 10467
        wellKnownUriSupport = None


    }

    static member ``xcon-userid`` = {

        lexicalForm = "xcon-userid"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 9520
        wellKnownUriSupport = None


    }

    static member xfire = {

        lexicalForm = "xfire"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 15306
        wellKnownUriSupport = None


    }

    static member xftp = {

        lexicalForm = "xftp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4315
        wellKnownUriSupport = None


    }

    static member ``xmlrpc.beep`` = {

        lexicalForm = "xmlrpc.beep"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 3005
        wellKnownUriSupport = None


    }

    static member ``xmlrpc.beeps`` = {

        lexicalForm = "xmlrpc.beeps"
        description = None
        status = IanaStatus.Permanent
        criSchemeNumber = 15805
        wellKnownUriSupport = None


    }

    static member xmpp = {

        lexicalForm = "xmpp"
        description = Some("""Extensible Messaging and Presence Protocol""")
        status = IanaStatus.Permanent
        criSchemeNumber = 15358
        wellKnownUriSupport = None


    }

    static member xrcp = {

        lexicalForm = "xrcp"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 4747
        wellKnownUriSupport = None


    }

    static member xri = {

        lexicalForm = "xri"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 11255
        wellKnownUriSupport = None


    }

    static member ymsgr = {

        lexicalForm = "ymsgr"
        description = None
        status = IanaStatus.Provisional
        criSchemeNumber = 3837
        wellKnownUriSupport = None


    }

    static member ``z39.50`` = {

        lexicalForm = "z39.50"
        description = Some("""Z39.50 information access""")
        status = IanaStatus.Historical
        criSchemeNumber = 1319
        wellKnownUriSupport = None


    }

    static member ``z39.50r`` = {

        lexicalForm = "z39.50r"
        description = Some("""Z39.50 Retrieval""")
        status = IanaStatus.Permanent
        criSchemeNumber = 8159
        wellKnownUriSupport = None


    }

    static member ``z39.50s`` = {

        lexicalForm = "z39.50s"
        description = Some("""Z39.50 Session""")
        status = IanaStatus.Permanent
        criSchemeNumber = 6380
        wellKnownUriSupport = None


    }
let IanaSchemes = [|
    IanaScheme.aaa
    IanaScheme.aaas
    IanaScheme.about
    IanaScheme.acap
    IanaScheme.acct
    IanaScheme.acd
    IanaScheme.acr
    IanaScheme.adiumxtra
    IanaScheme.adt
    IanaScheme.afp
    IanaScheme.afs
    IanaScheme.aim
    IanaScheme.amss
    IanaScheme.android
    IanaScheme.appdata
    IanaScheme.apt
    IanaScheme.ar
    IanaScheme.ari
    IanaScheme.ark
    IanaScheme.at
    IanaScheme.attachment
    IanaScheme.aw
    IanaScheme.barion
    IanaScheme.bb
    IanaScheme.beshare
    IanaScheme.bitcoin
    IanaScheme.bitcoincash
    IanaScheme.bl
    IanaScheme.blob
    IanaScheme.bluetooth
    IanaScheme.bolo
    IanaScheme.brid
    IanaScheme.browserext
    IanaScheme.cabal
    IanaScheme.calculator
    IanaScheme.callto
    IanaScheme.cap
    IanaScheme.caip
    IanaScheme.cast
    IanaScheme.casts
    IanaScheme.chrome
    IanaScheme.``chrome-extension``
    IanaScheme.cid
    IanaScheme.coap
    IanaScheme.``coap+tcp``
    IanaScheme.``coap+ws``
    IanaScheme.coaps
    IanaScheme.``coaps+tcp``
    IanaScheme.``coaps+ws``
    IanaScheme.``com-eventbrite-attendee``
    IanaScheme.content
    IanaScheme.``content-type``
    IanaScheme.crid
    IanaScheme.cstr
    IanaScheme.cvs
    IanaScheme.dab
    IanaScheme.dat
    IanaScheme.data
    IanaScheme.dav
    IanaScheme.dhttp
    IanaScheme.diaspora
    IanaScheme.dict
    IanaScheme.did
    IanaScheme.dilithium3
    IanaScheme.dis
    IanaScheme.``dlna-playcontainer``
    IanaScheme.``dlna-playsingle``
    IanaScheme.dnp
    IanaScheme.dns
    IanaScheme.dntp
    IanaScheme.doi
    IanaScheme.donau
    IanaScheme.dpp
    IanaScheme.drm
    IanaScheme.drop
    IanaScheme.dtmi
    IanaScheme.dtn
    IanaScheme.dvb
    IanaScheme.dvx
    IanaScheme.dweb
    IanaScheme.ed2k
    IanaScheme.eid
    IanaScheme.elsi
    IanaScheme.embedded
    IanaScheme.ens
    IanaScheme.esim
    IanaScheme.ethereum
    IanaScheme.example
    IanaScheme.facetime
    IanaScheme.fax
    IanaScheme.feed
    IanaScheme.feedready
    IanaScheme.fido
    IanaScheme.file
    IanaScheme.filesystem
    IanaScheme.finger
    IanaScheme.``first-run-pen-experience``
    IanaScheme.fish
    IanaScheme.fm
    IanaScheme.ftp
    IanaScheme.``fuchsia-pkg``
    IanaScheme.geo
    IanaScheme.gg
    IanaScheme.git
    IanaScheme.gitoid
    IanaScheme.gizmoproject
    IanaScheme.go
    IanaScheme.gopher
    IanaScheme.graph
    IanaScheme.grd
    IanaScheme.gtalk
    IanaScheme.h323
    IanaScheme.ham
    IanaScheme.hcap
    IanaScheme.hcp
    IanaScheme.hs20
    IanaScheme.http
    IanaScheme.https
    IanaScheme.hxxp
    IanaScheme.hxxps
    IanaScheme.hydrazone
    IanaScheme.hyper
    IanaScheme.i0
    IanaScheme.iax
    IanaScheme.ibi
    IanaScheme.``ibi-``
    IanaScheme.ilstring
    IanaScheme.icap
    IanaScheme.icon
    IanaScheme.im
    IanaScheme.imap
    IanaScheme.info
    IanaScheme.iotdisco
    IanaScheme.ipfs
    IanaScheme.ipn
    IanaScheme.ipns
    IanaScheme.ipp
    IanaScheme.ipps
    IanaScheme.irc
    IanaScheme.irc6
    IanaScheme.ircs
    IanaScheme.iris
    IanaScheme.``iris.beep``
    IanaScheme.``iris.lwz``
    IanaScheme.``iris.xpc``
    IanaScheme.``iris.xpcs``
    IanaScheme.isostore
    IanaScheme.itms
    IanaScheme.jabber
    IanaScheme.jar
    IanaScheme.jms
    IanaScheme.keyparc
    IanaScheme.lastfm
    IanaScheme.lbry
    IanaScheme.ldap
    IanaScheme.ldaps
    IanaScheme.leaptofrogans
    IanaScheme.lid
    IanaScheme.linkid
    IanaScheme.lorawan
    IanaScheme.lpa
    IanaScheme.lvlt
    IanaScheme.machineProvisioningProgressReporter
    IanaScheme.magnet
    IanaScheme.mailserver
    IanaScheme.mailto
    IanaScheme.maps
    IanaScheme.market
    IanaScheme.matrix
    IanaScheme.message
    IanaScheme.``microsoft.windows.camera``
    IanaScheme.``microsoft.windows.camera.multipicker``
    IanaScheme.``microsoft.windows.camera.picker``
    IanaScheme.mid
    IanaScheme.mms
    IanaScheme.modem
    IanaScheme.mongodb
    IanaScheme.moz
    IanaScheme.mqtt
    IanaScheme.mqtts
    IanaScheme.``ms-access``
    IanaScheme.``ms-appinstaller``
    IanaScheme.``ms-browser-extension``
    IanaScheme.``ms-calculator``
    IanaScheme.``ms-drive-to``
    IanaScheme.``ms-enrollment``
    IanaScheme.``ms-excel``
    IanaScheme.``ms-eyecontrolspeech``
    IanaScheme.``ms-gamebarservices``
    IanaScheme.``ms-gamingoverlay``
    IanaScheme.``ms-getoffice``
    IanaScheme.``ms-help``
    IanaScheme.``ms-infopath``
    IanaScheme.``ms-inputapp``
    IanaScheme.``ms-launchremotedesktop``
    IanaScheme.``ms-lockscreencomponent-config``
    IanaScheme.``ms-media-stream-id``
    IanaScheme.``ms-meetnow``
    IanaScheme.``ms-mixedrealitycapture``
    IanaScheme.``ms-mobileplans``
    IanaScheme.``ms-newsandinterests``
    IanaScheme.``ms-officeapp``
    IanaScheme.``ms-people``
    IanaScheme.``ms-personacard``
    IanaScheme.``ms-powerpoint``
    IanaScheme.``ms-project``
    IanaScheme.``ms-publisher``
    IanaScheme.``ms-recall``
    IanaScheme.``ms-remotedesktop``
    IanaScheme.``ms-remotedesktop-launch``
    IanaScheme.``ms-restoretabcompanion``
    IanaScheme.``ms-screenclip``
    IanaScheme.``ms-screensketch``
    IanaScheme.``ms-search``
    IanaScheme.``ms-search-repair``
    IanaScheme.``ms-secondary-screen-controller``
    IanaScheme.``ms-secondary-screen-setup``
    IanaScheme.``ms-settings``
    IanaScheme.``ms-settings-airplanemode``
    IanaScheme.``ms-settings-bluetooth``
    IanaScheme.``ms-settings-camera``
    IanaScheme.``ms-settings-cellular``
    IanaScheme.``ms-settings-cloudstorage``
    IanaScheme.``ms-settings-connectabledevices``
    IanaScheme.``ms-settings-displays-topology``
    IanaScheme.``ms-settings-emailandaccounts``
    IanaScheme.``ms-settings-language``
    IanaScheme.``ms-settings-location``
    IanaScheme.``ms-settings-lock``
    IanaScheme.``ms-settings-nfctransactions``
    IanaScheme.``ms-settings-notifications``
    IanaScheme.``ms-settings-power``
    IanaScheme.``ms-settings-privacy``
    IanaScheme.``ms-settings-proximity``
    IanaScheme.``ms-settings-screenrotation``
    IanaScheme.``ms-settings-wifi``
    IanaScheme.``ms-settings-workplace``
    IanaScheme.``ms-spd``
    IanaScheme.``ms-stickers``
    IanaScheme.``ms-sttoverlay``
    IanaScheme.``ms-transit-to``
    IanaScheme.``ms-useractivityset``
    IanaScheme.``ms-uup``
    IanaScheme.``ms-virtualtouchpad``
    IanaScheme.``ms-visio``
    IanaScheme.``ms-walk-to``
    IanaScheme.``ms-whiteboard``
    IanaScheme.``ms-whiteboard-cmd``
    IanaScheme.``ms-widgetboard``
    IanaScheme.``ms-widgets``
    IanaScheme.``ms-word``
    IanaScheme.msnim
    IanaScheme.msrp
    IanaScheme.msrps
    IanaScheme.mss
    IanaScheme.mt
    IanaScheme.mtqp
    IanaScheme.mtrust
    IanaScheme.mumble
    IanaScheme.mupdate
    IanaScheme.mvn
    IanaScheme.mvrp
    IanaScheme.mvrps
    IanaScheme.news
    IanaScheme.nfs
    IanaScheme.ni
    IanaScheme.nih
    IanaScheme.nntp
    IanaScheme.notes
    IanaScheme.num
    IanaScheme.ocf
    IanaScheme.oid
    IanaScheme.onenote
    IanaScheme.``onenote-cmd``
    IanaScheme.opaquelocktoken
    IanaScheme.openid
    IanaScheme.openpgp4fpr
    IanaScheme.otpauth
    IanaScheme.p1
    IanaScheme.pack
    IanaScheme.palm
    IanaScheme.paparazzi
    IanaScheme.payment
    IanaScheme.payto
    IanaScheme.pkcs11
    IanaScheme.platform
    IanaScheme.pop
    IanaScheme.pres
    IanaScheme.prospero
    IanaScheme.proxy
    IanaScheme.psyc
    IanaScheme.pttp
    IanaScheme.pwid
    IanaScheme.qb
    IanaScheme.query
    IanaScheme.``quic-transport``
    IanaScheme.redis
    IanaScheme.rediss
    IanaScheme.reload
    IanaScheme.res
    IanaScheme.resource
    IanaScheme.rmi
    IanaScheme.rsync
    IanaScheme.rtmfp
    IanaScheme.rtmp
    IanaScheme.rtsp
    IanaScheme.rtsps
    IanaScheme.rtspu
    IanaScheme.sarif
    IanaScheme.secondlife
    IanaScheme.``secret-token``
    IanaScheme.service
    IanaScheme.session
    IanaScheme.sftp
    IanaScheme.sgn
    IanaScheme.shc
    IanaScheme.shelter
    IanaScheme.sieve
    IanaScheme.simpleledger
    IanaScheme.simplex
    IanaScheme.sip
    IanaScheme.sips
    IanaScheme.skype
    IanaScheme.smb
    IanaScheme.smp
    IanaScheme.sms
    IanaScheme.smtp
    IanaScheme.snews
    IanaScheme.snmp
    IanaScheme.``soap.beep``
    IanaScheme.``soap.beeps``
    IanaScheme.soldat
    IanaScheme.spacify
    IanaScheme.spiffe
    IanaScheme.spotify
    IanaScheme.ssb
    IanaScheme.ssh
    IanaScheme.starknet
    IanaScheme.steam
    IanaScheme.stun
    IanaScheme.stuns
    IanaScheme.submit
    IanaScheme.svn
    IanaScheme.swh
    IanaScheme.swid
    IanaScheme.swidpath
    IanaScheme.tag
    IanaScheme.taler
    IanaScheme.teamspeak
    IanaScheme.teapot
    IanaScheme.teapots
    IanaScheme.tel
    IanaScheme.teliaeid
    IanaScheme.telnet
    IanaScheme.tftp
    IanaScheme.things
    IanaScheme.thismessage
    IanaScheme.thzp
    IanaScheme.tip
    IanaScheme.tn3270
    IanaScheme.tool
    IanaScheme.turn
    IanaScheme.turns
    IanaScheme.tv
    IanaScheme.udp
    IanaScheme.unreal
    IanaScheme.upn
    IanaScheme.upt
    IanaScheme.urn
    IanaScheme.ut2004
    IanaScheme.``uuid-in-package``
    IanaScheme.``v-event``
    IanaScheme.vemmi
    IanaScheme.ventrilo
    IanaScheme.ves
    IanaScheme.videotex
    IanaScheme.``view-source``
    IanaScheme.vnc
    IanaScheme.vscode
    IanaScheme.``vscode-insiders``
    IanaScheme.vsls
    IanaScheme.w3
    IanaScheme.wais
    IanaScheme.wasm
    IanaScheme.``wasm-js``
    IanaScheme.wcr
    IanaScheme.``web+ap``
    IanaScheme.web3
    IanaScheme.webcal
    IanaScheme.wifi
    IanaScheme.wpid
    IanaScheme.ws
    IanaScheme.wss
    IanaScheme.wtai
    IanaScheme.wyciwyg
    IanaScheme.xcompute
    IanaScheme.xcon
    IanaScheme.``xcon-userid``
    IanaScheme.xfire
    IanaScheme.xftp
    IanaScheme.``xmlrpc.beep``
    IanaScheme.``xmlrpc.beeps``
    IanaScheme.xmpp
    IanaScheme.xrcp
    IanaScheme.xri
    IanaScheme.ymsgr
    IanaScheme.``z39.50``
    IanaScheme.``z39.50r``
    IanaScheme.``z39.50s``
|]
