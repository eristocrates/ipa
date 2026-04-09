#load @"c:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\WorldWideWeb\Iana.fsx"

type Scheme = 
    {

        lexicalForm:string
        description:string option
        status: Iana.Status
        criSchemeNumber:int
        wellKnownUriSupport: string option

    }
let aaa = 
    {
    
        lexicalForm = "aaa"
        description = Some("""Diameter Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 13862
        wellKnownUriSupport = None
        

    }

let aaas = 
    {
    
        lexicalForm = "aaas"
        description = Some("""Diameter Protocol with Secure Transport""")
        status = Iana.Status.Permanent
        criSchemeNumber = 14526
        wellKnownUriSupport = None
        

    }

let about = 
    {
    
        lexicalForm = "about"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 3786
        wellKnownUriSupport = None
        

    }

let acap = 
    {
    
        lexicalForm = "acap"
        description = Some("""application configuration access protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12705
        wellKnownUriSupport = None
        

    }

let acct = 
    {
    
        lexicalForm = "acct"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 10229
        wellKnownUriSupport = None
        

    }

let acd = 
    {
    
        lexicalForm = "acd"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6840
        wellKnownUriSupport = None
        

    }

let acr = 
    {
    
        lexicalForm = "acr"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10196
        wellKnownUriSupport = None
        

    }

let adiumxtra = 
    {
    
        lexicalForm = "adiumxtra"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6634
        wellKnownUriSupport = None
        

    }

let adt = 
    {
    
        lexicalForm = "adt"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5150
        wellKnownUriSupport = None
        

    }

let afp = 
    {
    
        lexicalForm = "afp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13404
        wellKnownUriSupport = None
        

    }

let afs = 
    {
    
        lexicalForm = "afs"
        description = Some("""Andrew File System global file names""")
        status = Iana.Status.Provisional
        criSchemeNumber = 10687
        wellKnownUriSupport = None
        

    }

let aim = 
    {
    
        lexicalForm = "aim"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10327
        wellKnownUriSupport = None
        

    }

let amss = 
    {
    
        lexicalForm = "amss"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10831
        wellKnownUriSupport = None
        

    }

let android = 
    {
    
        lexicalForm = "android"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15061
        wellKnownUriSupport = None
        

    }

let appdata = 
    {
    
        lexicalForm = "appdata"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7364
        wellKnownUriSupport = None
        

    }

let apt = 
    {
    
        lexicalForm = "apt"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7856
        wellKnownUriSupport = None
        

    }

let ar = 
    {
    
        lexicalForm = "ar"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5099
        wellKnownUriSupport = None
        

    }

let ari = 
    {
    
        lexicalForm = "ari"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3818
        wellKnownUriSupport = None
        

    }

let ark = 
    {
    
        lexicalForm = "ark"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3018
        wellKnownUriSupport = None
        

    }

let at = 
    {
    
        lexicalForm = "at"
        description = Some("""at 
      (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 6007
        wellKnownUriSupport = None
        

    }

let attachment = 
    {
    
        lexicalForm = "attachment"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8577
        wellKnownUriSupport = None
        

    }

let aw = 
    {
    
        lexicalForm = "aw"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16051
        wellKnownUriSupport = None
        

    }

let barion = 
    {
    
        lexicalForm = "barion"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10225
        wellKnownUriSupport = None
        

    }

let bb = 
    {
    
        lexicalForm = "bb"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 5188
        wellKnownUriSupport = None
        

    }

let beshare = 
    {
    
        lexicalForm = "beshare"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4674
        wellKnownUriSupport = None
        

    }

let bitcoin = 
    {
    
        lexicalForm = "bitcoin"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9186
        wellKnownUriSupport = None
        

    }

let bitcoincash = 
    {
    
        lexicalForm = "bitcoincash"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7226
        wellKnownUriSupport = None
        

    }

let bl = 
    {
    
        lexicalForm = "bl"
        description = Some("""bluetooth (shortened)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 10024
        wellKnownUriSupport = None
        

    }

let blob = 
    {
    
        lexicalForm = "blob"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11060
        wellKnownUriSupport = None
        

    }

let bluetooth = 
    {
    
        lexicalForm = "bluetooth"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12052
        wellKnownUriSupport = None
        

    }

let bolo = 
    {
    
        lexicalForm = "bolo"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8765
        wellKnownUriSupport = None
        

    }

let brid = 
    {
    
        lexicalForm = "brid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8251
        wellKnownUriSupport = None
        

    }

let browserext = 
    {
    
        lexicalForm = "browserext"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4327
        wellKnownUriSupport = None
        

    }

let cabal = 
    {
    
        lexicalForm = "cabal"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11393
        wellKnownUriSupport = None
        

    }

let calculator = 
    {
    
        lexicalForm = "calculator"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3783
        wellKnownUriSupport = None
        

    }

let callto = 
    {
    
        lexicalForm = "callto"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8713
        wellKnownUriSupport = None
        

    }

let cap = 
    {
    
        lexicalForm = "cap"
        description = Some("""Calendar Access Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 9204
        wellKnownUriSupport = None
        

    }

let caip = 
    {
    
        lexicalForm = "caip"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1001
        wellKnownUriSupport = None
        

    }

let cast = 
    {
    
        lexicalForm = "cast"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1220
        wellKnownUriSupport = None
        

    }

let casts = 
    {
    
        lexicalForm = "casts"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12718
        wellKnownUriSupport = None
        

    }

let chrome = 
    {
    
        lexicalForm = "chrome"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5728
        wellKnownUriSupport = None
        

    }

let ``chrome-extension`` = 
    {
    
        lexicalForm = "chrome-extension"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14667
        wellKnownUriSupport = None
        

    }

let cid = 
    {
    
        lexicalForm = "cid"
        description = Some("""content identifier""")
        status = Iana.Status.Permanent
        criSchemeNumber = 15202
        wellKnownUriSupport = None
        

    }

let coap = 
    {
    
        lexicalForm = "coap"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 0
        wellKnownUriSupport = None
        

    }

let ``coap+tcp`` = 
    {
    
        lexicalForm = "coap+tcp"
        description = Some("""coap+tcp 
      (see reviewer notes)""")
        status = Iana.Status.Permanent
        criSchemeNumber = 6
        wellKnownUriSupport = None
        

    }

let ``coap+ws`` = 
    {
    
        lexicalForm = "coap+ws"
        description = Some("""coap+ws 
      (see reviewer notes)""")
        status = Iana.Status.Permanent
        criSchemeNumber = 24
        wellKnownUriSupport = None
        

    }

let coaps = 
    {
    
        lexicalForm = "coaps"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 1
        wellKnownUriSupport = None
        

    }

let ``coaps+tcp`` = 
    {
    
        lexicalForm = "coaps+tcp"
        description = Some("""coaps+tcp 
      (see reviewer notes)""")
        status = Iana.Status.Permanent
        criSchemeNumber = 7
        wellKnownUriSupport = None
        

    }

let ``coaps+ws`` = 
    {
    
        lexicalForm = "coaps+ws"
        description = Some("""coaps+ws 
      (see reviewer notes)""")
        status = Iana.Status.Permanent
        criSchemeNumber = 25
        wellKnownUriSupport = None
        

    }

let ``com-eventbrite-attendee`` = 
    {
    
        lexicalForm = "com-eventbrite-attendee"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9278
        wellKnownUriSupport = None
        

    }

let content = 
    {
    
        lexicalForm = "content"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8387
        wellKnownUriSupport = None
        

    }

let ``content-type`` = 
    {
    
        lexicalForm = "content-type"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6030
        wellKnownUriSupport = None
        

    }

let crid = 
    {
    
        lexicalForm = "crid"
        description = Some("""TV-Anytime Content Reference Identifier""")
        status = Iana.Status.Permanent
        criSchemeNumber = 5990
        wellKnownUriSupport = None
        

    }

let cstr = 
    {
    
        lexicalForm = "cstr"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6730
        wellKnownUriSupport = None
        

    }

let cvs = 
    {
    
        lexicalForm = "cvs"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12242
        wellKnownUriSupport = None
        

    }

let dab = 
    {
    
        lexicalForm = "dab"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6774
        wellKnownUriSupport = None
        

    }

let dat = 
    {
    
        lexicalForm = "dat"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10583
        wellKnownUriSupport = None
        

    }

let data = 
    {
    
        lexicalForm = "data"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 1946
        wellKnownUriSupport = None
        

    }

let dav = 
    {
    
        lexicalForm = "dav"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 4373
        wellKnownUriSupport = None
        

    }

let dhttp = 
    {
    
        lexicalForm = "dhttp"
        description = Some("""dhttp 
      (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 4549
        wellKnownUriSupport = None
        

    }

let diaspora = 
    {
    
        lexicalForm = "diaspora"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4598
        wellKnownUriSupport = None
        

    }

let dict = 
    {
    
        lexicalForm = "dict"
        description = Some("""dictionary service protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3886
        wellKnownUriSupport = None
        

    }

let did = 
    {
    
        lexicalForm = "did"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5
        wellKnownUriSupport = None
        

    }

let dilithium3 = 
    {
    
        lexicalForm = "dilithium3"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1005
        wellKnownUriSupport = None
        

    }

let dis = 
    {
    
        lexicalForm = "dis"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17134
        wellKnownUriSupport = None
        

    }

let ``dlna-playcontainer`` = 
    {
    
        lexicalForm = "dlna-playcontainer"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5557
        wellKnownUriSupport = None
        

    }

let ``dlna-playsingle`` = 
    {
    
        lexicalForm = "dlna-playsingle"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6144
        wellKnownUriSupport = None
        

    }

let dnp = 
    {
    
        lexicalForm = "dnp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15819
        wellKnownUriSupport = None
        

    }

let dns = 
    {
    
        lexicalForm = "dns"
        description = Some("""Domain Name System""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12932
        wellKnownUriSupport = None
        

    }

let dntp = 
    {
    
        lexicalForm = "dntp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14347
        wellKnownUriSupport = None
        

    }

let doi = 
    {
    
        lexicalForm = "doi"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 13014
        wellKnownUriSupport = None
        

    }

let donau = 
    {
    
        lexicalForm = "donau"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10150
        wellKnownUriSupport = None
        

    }

let dpp = 
    {
    
        lexicalForm = "dpp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2442
        wellKnownUriSupport = None
        

    }

let drm = 
    {
    
        lexicalForm = "drm"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9859
        wellKnownUriSupport = None
        

    }

let drop = 
    {
    
        lexicalForm = "drop"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 16138
        wellKnownUriSupport = None
        

    }

let dtmi = 
    {
    
        lexicalForm = "dtmi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17097
        wellKnownUriSupport = None
        

    }

let dtn = 
    {
    
        lexicalForm = "dtn"
        description = Some("""DTNRG research and development""")
        status = Iana.Status.Permanent
        criSchemeNumber = 7456
        wellKnownUriSupport = None
        

    }

let dvb = 
    {
    
        lexicalForm = "dvb"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10380
        wellKnownUriSupport = None
        

    }

let dvx = 
    {
    
        lexicalForm = "dvx"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11645
        wellKnownUriSupport = None
        

    }

let dweb = 
    {
    
        lexicalForm = "dweb"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1328
        wellKnownUriSupport = None
        

    }

let ed2k = 
    {
    
        lexicalForm = "ed2k"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2790
        wellKnownUriSupport = None
        

    }

let eid = 
    {
    
        lexicalForm = "eid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4929
        wellKnownUriSupport = None
        

    }

let elsi = 
    {
    
        lexicalForm = "elsi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13680
        wellKnownUriSupport = None
        

    }

let embedded = 
    {
    
        lexicalForm = "embedded"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4193
        wellKnownUriSupport = None
        

    }

let ens = 
    {
    
        lexicalForm = "ens"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1982
        wellKnownUriSupport = None
        

    }

let esim = 
    {
    
        lexicalForm = "esim"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3032
        wellKnownUriSupport = None
        

    }

let ethereum = 
    {
    
        lexicalForm = "ethereum"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7913
        wellKnownUriSupport = None
        

    }

let example = 
    {
    
        lexicalForm = "example"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 5296
        wellKnownUriSupport = None
        

    }

let facetime = 
    {
    
        lexicalForm = "facetime"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3795
        wellKnownUriSupport = None
        

    }

let fax = 
    {
    
        lexicalForm = "fax"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 4053
        wellKnownUriSupport = None
        

    }

let feed = 
    {
    
        lexicalForm = "feed"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7520
        wellKnownUriSupport = None
        

    }

let feedready = 
    {
    
        lexicalForm = "feedready"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11824
        wellKnownUriSupport = None
        

    }

let fido = 
    {
    
        lexicalForm = "fido"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5717
        wellKnownUriSupport = None
        

    }

let file = 
    {
    
        lexicalForm = "file"
        description = Some("""Host-specific file names""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12068
        wellKnownUriSupport = None
        

    }

let filesystem = 
    {
    
        lexicalForm = "filesystem"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 3365
        wellKnownUriSupport = None
        

    }

let finger = 
    {
    
        lexicalForm = "finger"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17315
        wellKnownUriSupport = None
        

    }

let ``first-run-pen-experience`` = 
    {
    
        lexicalForm = "first-run-pen-experience"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16069
        wellKnownUriSupport = None
        

    }

let fish = 
    {
    
        lexicalForm = "fish"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12634
        wellKnownUriSupport = None
        

    }

let fm = 
    {
    
        lexicalForm = "fm"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2806
        wellKnownUriSupport = None
        

    }

let ftp = 
    {
    
        lexicalForm = "ftp"
        description = Some("""File Transfer Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 14878
        wellKnownUriSupport = None
        

    }

let ``fuchsia-pkg`` = 
    {
    
        lexicalForm = "fuchsia-pkg"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12806
        wellKnownUriSupport = None
        

    }

let geo = 
    {
    
        lexicalForm = "geo"
        description = Some("""Geographic Locations""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3342
        wellKnownUriSupport = None
        

    }

let gg = 
    {
    
        lexicalForm = "gg"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11055
        wellKnownUriSupport = None
        

    }

let git = 
    {
    
        lexicalForm = "git"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13068
        wellKnownUriSupport = None
        

    }

let gitoid = 
    {
    
        lexicalForm = "gitoid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3775
        wellKnownUriSupport = None
        

    }

let gizmoproject = 
    {
    
        lexicalForm = "gizmoproject"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10744
        wellKnownUriSupport = None
        

    }

let go = 
    {
    
        lexicalForm = "go"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 5705
        wellKnownUriSupport = None
        

    }

let gopher = 
    {
    
        lexicalForm = "gopher"
        description = Some("""The Gopher Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 8601
        wellKnownUriSupport = None
        

    }

let graph = 
    {
    
        lexicalForm = "graph"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11583
        wellKnownUriSupport = None
        

    }

let grd = 
    {
    
        lexicalForm = "grd"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 9444
        wellKnownUriSupport = None
        

    }

let gtalk = 
    {
    
        lexicalForm = "gtalk"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4709
        wellKnownUriSupport = None
        

    }

let h323 = 
    {
    
        lexicalForm = "h323"
        description = Some("""H.323""")
        status = Iana.Status.Permanent
        criSchemeNumber = 10317
        wellKnownUriSupport = None
        

    }

let ham = 
    {
    
        lexicalForm = "ham"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6503
        wellKnownUriSupport = None
        

    }

let hcap = 
    {
    
        lexicalForm = "hcap"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9875
        wellKnownUriSupport = None
        

    }

let hcp = 
    {
    
        lexicalForm = "hcp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6024
        wellKnownUriSupport = None
        

    }

let hs20 = 
    {
    
        lexicalForm = "hs20"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1273
        wellKnownUriSupport = None
        

    }

let http = 
    {
    
        lexicalForm = "http"
        description = Some("""Hypertext Transfer Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 2
        wellKnownUriSupport = None
        

    }

let https = 
    {
    
        lexicalForm = "https"
        description = Some("""Hypertext Transfer Protocol Secure""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3
        wellKnownUriSupport = None
        

    }

let hxxp = 
    {
    
        lexicalForm = "hxxp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16728
        wellKnownUriSupport = None
        

    }

let hxxps = 
    {
    
        lexicalForm = "hxxps"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4714
        wellKnownUriSupport = None
        

    }

let hydrazone = 
    {
    
        lexicalForm = "hydrazone"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6632
        wellKnownUriSupport = None
        

    }

let hyper = 
    {
    
        lexicalForm = "hyper"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12876
        wellKnownUriSupport = None
        

    }

let i0 = 
    {
    
        lexicalForm = "i0"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10328
        wellKnownUriSupport = None
        

    }

let iax = 
    {
    
        lexicalForm = "iax"
        description = Some("""Inter-Asterisk eXchange Version 2""")
        status = Iana.Status.Permanent
        criSchemeNumber = 7126
        wellKnownUriSupport = None
        

    }

let ibi = 
    {
    
        lexicalForm = "ibi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1002
        wellKnownUriSupport = None
        

    }

let ``ibi-`` = 
    {
    
        lexicalForm = "ibi-"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1003
        wellKnownUriSupport = None
        

    }

let ilstring = 
    {
    
        lexicalForm = "ilstring"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12237
        wellKnownUriSupport = None
        

    }

let icap = 
    {
    
        lexicalForm = "icap"
        description = Some("""Internet Content Adaptation Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12566
        wellKnownUriSupport = None
        

    }

let icon = 
    {
    
        lexicalForm = "icon"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14868
        wellKnownUriSupport = None
        

    }

let im = 
    {
    
        lexicalForm = "im"
        description = Some("""Instant Messaging""")
        status = Iana.Status.Permanent
        criSchemeNumber = 6883
        wellKnownUriSupport = None
        

    }

let imap = 
    {
    
        lexicalForm = "imap"
        description = Some("""internet message access protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 10119
        wellKnownUriSupport = None
        

    }

let info = 
    {
    
        lexicalForm = "info"
        description = Some("""Information Assets with Identifiers in Public Namespaces. 
       (section 3) defines an "info" registry 
        of public namespaces, which is maintained by NISO and can be accessed 
        from .""")
        status = Iana.Status.Permanent
        criSchemeNumber = 13846
        wellKnownUriSupport = None
        

    }

let iotdisco = 
    {
    
        lexicalForm = "iotdisco"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17170
        wellKnownUriSupport = None
        

    }

let ipfs = 
    {
    
        lexicalForm = "ipfs"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15972
        wellKnownUriSupport = None
        

    }

let ipn = 
    {
    
        lexicalForm = "ipn"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 8775
        wellKnownUriSupport = None
        

    }

let ipns = 
    {
    
        lexicalForm = "ipns"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16933
        wellKnownUriSupport = None
        

    }

let ipp = 
    {
    
        lexicalForm = "ipp"
        description = Some("""Internet Printing Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 9318
        wellKnownUriSupport = None
        

    }

let ipps = 
    {
    
        lexicalForm = "ipps"
        description = Some("""Internet Printing Protocol over HTTPS""")
        status = Iana.Status.Permanent
        criSchemeNumber = 4419
        wellKnownUriSupport = None
        

    }

let irc = 
    {
    
        lexicalForm = "irc"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5425
        wellKnownUriSupport = None
        

    }

let irc6 = 
    {
    
        lexicalForm = "irc6"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1905
        wellKnownUriSupport = None
        

    }

let ircs = 
    {
    
        lexicalForm = "ircs"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8687
        wellKnownUriSupport = None
        

    }

let iris = 
    {
    
        lexicalForm = "iris"
        description = Some("""Internet Registry Information Service""")
        status = Iana.Status.Permanent
        criSchemeNumber = 13986
        wellKnownUriSupport = None
        

    }

let ``iris.beep`` = 
    {
    
        lexicalForm = "iris.beep"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 15639
        wellKnownUriSupport = None
        

    }

let ``iris.lwz`` = 
    {
    
        lexicalForm = "iris.lwz"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 4590
        wellKnownUriSupport = None
        

    }

let ``iris.xpc`` = 
    {
    
        lexicalForm = "iris.xpc"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 12422
        wellKnownUriSupport = None
        

    }

let ``iris.xpcs`` = 
    {
    
        lexicalForm = "iris.xpcs"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 16134
        wellKnownUriSupport = None
        

    }

let isostore = 
    {
    
        lexicalForm = "isostore"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7225
        wellKnownUriSupport = None
        

    }

let itms = 
    {
    
        lexicalForm = "itms"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14830
        wellKnownUriSupport = None
        

    }

let jabber = 
    {
    
        lexicalForm = "jabber"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 6109
        wellKnownUriSupport = None
        

    }

let jar = 
    {
    
        lexicalForm = "jar"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1578
        wellKnownUriSupport = None
        

    }

let jms = 
    {
    
        lexicalForm = "jms"
        description = Some("""Java Message Service""")
        status = Iana.Status.Provisional
        criSchemeNumber = 3634
        wellKnownUriSupport = None
        

    }

let keyparc = 
    {
    
        lexicalForm = "keyparc"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9770
        wellKnownUriSupport = None
        

    }

let lastfm = 
    {
    
        lexicalForm = "lastfm"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11742
        wellKnownUriSupport = None
        

    }

let lbry = 
    {
    
        lexicalForm = "lbry"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14010
        wellKnownUriSupport = None
        

    }

let ldap = 
    {
    
        lexicalForm = "ldap"
        description = Some("""Lightweight Directory Access Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 13442
        wellKnownUriSupport = None
        

    }

let ldaps = 
    {
    
        lexicalForm = "ldaps"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3906
        wellKnownUriSupport = None
        

    }

let leaptofrogans = 
    {
    
        lexicalForm = "leaptofrogans"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 16281
        wellKnownUriSupport = None
        

    }

let lid = 
    {
    
        lexicalForm = "lid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10247
        wellKnownUriSupport = None
        

    }

let linkid = 
    {
    
        lexicalForm = "linkid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1819
        wellKnownUriSupport = None
        

    }

let lorawan = 
    {
    
        lexicalForm = "lorawan"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11718
        wellKnownUriSupport = None
        

    }

let lpa = 
    {
    
        lexicalForm = "lpa"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6658
        wellKnownUriSupport = None
        

    }

let lvlt = 
    {
    
        lexicalForm = "lvlt"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5480
        wellKnownUriSupport = None
        

    }

let machineProvisioningProgressReporter = 
    {
    
        lexicalForm = "machineProvisioningProgressReporter"
        description = Some("""Windows Autopilot Modern Device Management status updates""")
        status = Iana.Status.Provisional
        criSchemeNumber = 5477
        wellKnownUriSupport = None
        

    }

let magnet = 
    {
    
        lexicalForm = "magnet"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9805
        wellKnownUriSupport = None
        

    }

let mailserver = 
    {
    
        lexicalForm = "mailserver"
        description = Some("""Access to data available from mail servers""")
        status = Iana.Status.Historical
        criSchemeNumber = 10868
        wellKnownUriSupport = None
        

    }

let mailto = 
    {
    
        lexicalForm = "mailto"
        description = Some("""Electronic mail address""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12102
        wellKnownUriSupport = None
        

    }

let maps = 
    {
    
        lexicalForm = "maps"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14153
        wellKnownUriSupport = None
        

    }

let market = 
    {
    
        lexicalForm = "market"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14595
        wellKnownUriSupport = None
        

    }

let matrix = 
    {
    
        lexicalForm = "matrix"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9487
        wellKnownUriSupport = None
        

    }

let message = 
    {
    
        lexicalForm = "message"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14460
        wellKnownUriSupport = None
        

    }

let ``microsoft.windows.camera`` = 
    {
    
        lexicalForm = "microsoft.windows.camera"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11857
        wellKnownUriSupport = None
        

    }

let ``microsoft.windows.camera.multipicker`` = 
    {
    
        lexicalForm = "microsoft.windows.camera.multipicker"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7942
        wellKnownUriSupport = None
        

    }

let ``microsoft.windows.camera.picker`` = 
    {
    
        lexicalForm = "microsoft.windows.camera.picker"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5883
        wellKnownUriSupport = None
        

    }

let mid = 
    {
    
        lexicalForm = "mid"
        description = Some("""message identifier""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3646
        wellKnownUriSupport = None
        

    }

let mms = 
    {
    
        lexicalForm = "mms"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12337
        wellKnownUriSupport = None
        

    }

let modem = 
    {
    
        lexicalForm = "modem"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 9154
        wellKnownUriSupport = None
        

    }

let mongodb = 
    {
    
        lexicalForm = "mongodb"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13372
        wellKnownUriSupport = None
        

    }

let moz = 
    {
    
        lexicalForm = "moz"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6808
        wellKnownUriSupport = None
        

    }

let mqtt = 
    {
    
        lexicalForm = "mqtt"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10740
        wellKnownUriSupport = None
        

    }

let mqtts = 
    {
    
        lexicalForm = "mqtts"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14906
        wellKnownUriSupport = None
        

    }

let ``ms-access`` = 
    {
    
        lexicalForm = "ms-access"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6863
        wellKnownUriSupport = None
        

    }

let ``ms-appinstaller`` = 
    {
    
        lexicalForm = "ms-appinstaller"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5152
        wellKnownUriSupport = None
        

    }

let ``ms-browser-extension`` = 
    {
    
        lexicalForm = "ms-browser-extension"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14090
        wellKnownUriSupport = None
        

    }

let ``ms-calculator`` = 
    {
    
        lexicalForm = "ms-calculator"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3690
        wellKnownUriSupport = None
        

    }

let ``ms-drive-to`` = 
    {
    
        lexicalForm = "ms-drive-to"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4102
        wellKnownUriSupport = None
        

    }

let ``ms-enrollment`` = 
    {
    
        lexicalForm = "ms-enrollment"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14310
        wellKnownUriSupport = None
        

    }

let ``ms-excel`` = 
    {
    
        lexicalForm = "ms-excel"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5536
        wellKnownUriSupport = None
        

    }

let ``ms-eyecontrolspeech`` = 
    {
    
        lexicalForm = "ms-eyecontrolspeech"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17381
        wellKnownUriSupport = None
        

    }

let ``ms-gamebarservices`` = 
    {
    
        lexicalForm = "ms-gamebarservices"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12823
        wellKnownUriSupport = None
        

    }

let ``ms-gamingoverlay`` = 
    {
    
        lexicalForm = "ms-gamingoverlay"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1059
        wellKnownUriSupport = None
        

    }

let ``ms-getoffice`` = 
    {
    
        lexicalForm = "ms-getoffice"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14366
        wellKnownUriSupport = None
        

    }

let ``ms-help`` = 
    {
    
        lexicalForm = "ms-help"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7809
        wellKnownUriSupport = None
        

    }

let ``ms-infopath`` = 
    {
    
        lexicalForm = "ms-infopath"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8830
        wellKnownUriSupport = None
        

    }

let ``ms-inputapp`` = 
    {
    
        lexicalForm = "ms-inputapp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6792
        wellKnownUriSupport = None
        

    }

let ``ms-launchremotedesktop`` = 
    {
    
        lexicalForm = "ms-launchremotedesktop"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12174
        wellKnownUriSupport = None
        

    }

let ``ms-lockscreencomponent-config`` = 
    {
    
        lexicalForm = "ms-lockscreencomponent-config"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12525
        wellKnownUriSupport = None
        

    }

let ``ms-media-stream-id`` = 
    {
    
        lexicalForm = "ms-media-stream-id"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6388
        wellKnownUriSupport = None
        

    }

let ``ms-meetnow`` = 
    {
    
        lexicalForm = "ms-meetnow"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15645
        wellKnownUriSupport = None
        

    }

let ``ms-mixedrealitycapture`` = 
    {
    
        lexicalForm = "ms-mixedrealitycapture"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6411
        wellKnownUriSupport = None
        

    }

let ``ms-mobileplans`` = 
    {
    
        lexicalForm = "ms-mobileplans"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11945
        wellKnownUriSupport = None
        

    }

let ``ms-newsandinterests`` = 
    {
    
        lexicalForm = "ms-newsandinterests"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2945
        wellKnownUriSupport = None
        

    }

let ``ms-officeapp`` = 
    {
    
        lexicalForm = "ms-officeapp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14168
        wellKnownUriSupport = None
        

    }

let ``ms-people`` = 
    {
    
        lexicalForm = "ms-people"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1528
        wellKnownUriSupport = None
        

    }

let ``ms-personacard`` = 
    {
    
        lexicalForm = "ms-personacard"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1562
        wellKnownUriSupport = None
        

    }

let ``ms-powerpoint`` = 
    {
    
        lexicalForm = "ms-powerpoint"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16645
        wellKnownUriSupport = None
        

    }

let ``ms-project`` = 
    {
    
        lexicalForm = "ms-project"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11130
        wellKnownUriSupport = None
        

    }

let ``ms-publisher`` = 
    {
    
        lexicalForm = "ms-publisher"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16194
        wellKnownUriSupport = None
        

    }

let ``ms-recall`` = 
    {
    
        lexicalForm = "ms-recall"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10183
        wellKnownUriSupport = None
        

    }

let ``ms-remotedesktop`` = 
    {
    
        lexicalForm = "ms-remotedesktop"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5347
        wellKnownUriSupport = None
        

    }

let ``ms-remotedesktop-launch`` = 
    {
    
        lexicalForm = "ms-remotedesktop-launch"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8085
        wellKnownUriSupport = None
        

    }

let ``ms-restoretabcompanion`` = 
    {
    
        lexicalForm = "ms-restoretabcompanion"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17175
        wellKnownUriSupport = None
        

    }

let ``ms-screenclip`` = 
    {
    
        lexicalForm = "ms-screenclip"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10518
        wellKnownUriSupport = None
        

    }

let ``ms-screensketch`` = 
    {
    
        lexicalForm = "ms-screensketch"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9453
        wellKnownUriSupport = None
        

    }

let ``ms-search`` = 
    {
    
        lexicalForm = "ms-search"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14034
        wellKnownUriSupport = None
        

    }

let ``ms-search-repair`` = 
    {
    
        lexicalForm = "ms-search-repair"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15679
        wellKnownUriSupport = None
        

    }

let ``ms-secondary-screen-controller`` = 
    {
    
        lexicalForm = "ms-secondary-screen-controller"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13098
        wellKnownUriSupport = None
        

    }

let ``ms-secondary-screen-setup`` = 
    {
    
        lexicalForm = "ms-secondary-screen-setup"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15254
        wellKnownUriSupport = None
        

    }

let ``ms-settings`` = 
    {
    
        lexicalForm = "ms-settings"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9075
        wellKnownUriSupport = None
        

    }

let ``ms-settings-airplanemode`` = 
    {
    
        lexicalForm = "ms-settings-airplanemode"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5109
        wellKnownUriSupport = None
        

    }

let ``ms-settings-bluetooth`` = 
    {
    
        lexicalForm = "ms-settings-bluetooth"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14180
        wellKnownUriSupport = None
        

    }

let ``ms-settings-camera`` = 
    {
    
        lexicalForm = "ms-settings-camera"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15773
        wellKnownUriSupport = None
        

    }

let ``ms-settings-cellular`` = 
    {
    
        lexicalForm = "ms-settings-cellular"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15361
        wellKnownUriSupport = None
        

    }

let ``ms-settings-cloudstorage`` = 
    {
    
        lexicalForm = "ms-settings-cloudstorage"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10640
        wellKnownUriSupport = None
        

    }

let ``ms-settings-connectabledevices`` = 
    {
    
        lexicalForm = "ms-settings-connectabledevices"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11351
        wellKnownUriSupport = None
        

    }

let ``ms-settings-displays-topology`` = 
    {
    
        lexicalForm = "ms-settings-displays-topology"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12029
        wellKnownUriSupport = None
        

    }

let ``ms-settings-emailandaccounts`` = 
    {
    
        lexicalForm = "ms-settings-emailandaccounts"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11072
        wellKnownUriSupport = None
        

    }

let ``ms-settings-language`` = 
    {
    
        lexicalForm = "ms-settings-language"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9981
        wellKnownUriSupport = None
        

    }

let ``ms-settings-location`` = 
    {
    
        lexicalForm = "ms-settings-location"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10373
        wellKnownUriSupport = None
        

    }

let ``ms-settings-lock`` = 
    {
    
        lexicalForm = "ms-settings-lock"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11950
        wellKnownUriSupport = None
        

    }

let ``ms-settings-nfctransactions`` = 
    {
    
        lexicalForm = "ms-settings-nfctransactions"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10591
        wellKnownUriSupport = None
        

    }

let ``ms-settings-notifications`` = 
    {
    
        lexicalForm = "ms-settings-notifications"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7868
        wellKnownUriSupport = None
        

    }

let ``ms-settings-power`` = 
    {
    
        lexicalForm = "ms-settings-power"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13026
        wellKnownUriSupport = None
        

    }

let ``ms-settings-privacy`` = 
    {
    
        lexicalForm = "ms-settings-privacy"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9198
        wellKnownUriSupport = None
        

    }

let ``ms-settings-proximity`` = 
    {
    
        lexicalForm = "ms-settings-proximity"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3959
        wellKnownUriSupport = None
        

    }

let ``ms-settings-screenrotation`` = 
    {
    
        lexicalForm = "ms-settings-screenrotation"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6755
        wellKnownUriSupport = None
        

    }

let ``ms-settings-wifi`` = 
    {
    
        lexicalForm = "ms-settings-wifi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15994
        wellKnownUriSupport = None
        

    }

let ``ms-settings-workplace`` = 
    {
    
        lexicalForm = "ms-settings-workplace"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14936
        wellKnownUriSupport = None
        

    }

let ``ms-spd`` = 
    {
    
        lexicalForm = "ms-spd"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6189
        wellKnownUriSupport = None
        

    }

let ``ms-stickers`` = 
    {
    
        lexicalForm = "ms-stickers"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10361
        wellKnownUriSupport = None
        

    }

let ``ms-sttoverlay`` = 
    {
    
        lexicalForm = "ms-sttoverlay"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5410
        wellKnownUriSupport = None
        

    }

let ``ms-transit-to`` = 
    {
    
        lexicalForm = "ms-transit-to"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7743
        wellKnownUriSupport = None
        

    }

let ``ms-useractivityset`` = 
    {
    
        lexicalForm = "ms-useractivityset"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9136
        wellKnownUriSupport = None
        

    }

let ``ms-uup`` = 
    {
    
        lexicalForm = "ms-uup"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1560
        wellKnownUriSupport = None
        

    }

let ``ms-virtualtouchpad`` = 
    {
    
        lexicalForm = "ms-virtualtouchpad"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15776
        wellKnownUriSupport = None
        

    }

let ``ms-visio`` = 
    {
    
        lexicalForm = "ms-visio"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15163
        wellKnownUriSupport = None
        

    }

let ``ms-walk-to`` = 
    {
    
        lexicalForm = "ms-walk-to"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14364
        wellKnownUriSupport = None
        

    }

let ``ms-whiteboard`` = 
    {
    
        lexicalForm = "ms-whiteboard"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11467
        wellKnownUriSupport = None
        

    }

let ``ms-whiteboard-cmd`` = 
    {
    
        lexicalForm = "ms-whiteboard-cmd"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14860
        wellKnownUriSupport = None
        

    }

let ``ms-widgetboard`` = 
    {
    
        lexicalForm = "ms-widgetboard"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12603
        wellKnownUriSupport = None
        

    }

let ``ms-widgets`` = 
    {
    
        lexicalForm = "ms-widgets"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4613
        wellKnownUriSupport = None
        

    }

let ``ms-word`` = 
    {
    
        lexicalForm = "ms-word"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16585
        wellKnownUriSupport = None
        

    }

let msnim = 
    {
    
        lexicalForm = "msnim"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8041
        wellKnownUriSupport = None
        

    }

let msrp = 
    {
    
        lexicalForm = "msrp"
        description = Some("""Message Session Relay Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 11315
        wellKnownUriSupport = None
        

    }

let msrps = 
    {
    
        lexicalForm = "msrps"
        description = Some("""Message Session Relay Protocol Secure""")
        status = Iana.Status.Permanent
        criSchemeNumber = 13440
        wellKnownUriSupport = None
        

    }

let mss = 
    {
    
        lexicalForm = "mss"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12493
        wellKnownUriSupport = None
        

    }

let mt = 
    {
    
        lexicalForm = "mt"
        description = Some("""Matter protocol on-boarding payloads that are encoded for use in QR Codes and/or NFC Tags""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12699
        wellKnownUriSupport = None
        

    }

let mtqp = 
    {
    
        lexicalForm = "mtqp"
        description = Some("""Message Tracking Query Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3358
        wellKnownUriSupport = None
        

    }

let mtrust = 
    {
    
        lexicalForm = "mtrust"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13062
        wellKnownUriSupport = None
        

    }

let mumble = 
    {
    
        lexicalForm = "mumble"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11804
        wellKnownUriSupport = None
        

    }

let mupdate = 
    {
    
        lexicalForm = "mupdate"
        description = Some("""Mailbox Update (MUPDATE) Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12569
        wellKnownUriSupport = None
        

    }

let mvn = 
    {
    
        lexicalForm = "mvn"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9585
        wellKnownUriSupport = None
        

    }

let mvrp = 
    {
    
        lexicalForm = "mvrp"
        description = Some("""mvrp
      (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 13451
        wellKnownUriSupport = None
        

    }

let mvrps = 
    {
    
        lexicalForm = "mvrps"
        description = Some("""mvrps
      (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 13228
        wellKnownUriSupport = None
        

    }

let news = 
    {
    
        lexicalForm = "news"
        description = Some("""USENET news""")
        status = Iana.Status.Permanent
        criSchemeNumber = 1895
        wellKnownUriSupport = None
        

    }

let nfs = 
    {
    
        lexicalForm = "nfs"
        description = Some("""network file system protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 6516
        wellKnownUriSupport = None
        

    }

let ni = 
    {
    
        lexicalForm = "ni"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 10926
        wellKnownUriSupport = None
        

    }

let nih = 
    {
    
        lexicalForm = "nih"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 11428
        wellKnownUriSupport = None
        

    }

let nntp = 
    {
    
        lexicalForm = "nntp"
        description = Some("""USENET news using NNTP access""")
        status = Iana.Status.Permanent
        criSchemeNumber = 13499
        wellKnownUriSupport = None
        

    }

let notes = 
    {
    
        lexicalForm = "notes"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8766
        wellKnownUriSupport = None
        

    }

let num = 
    {
    
        lexicalForm = "num"
        description = Some("""Namespace Utility Modules""")
        status = Iana.Status.Provisional
        criSchemeNumber = 9965
        wellKnownUriSupport = None
        

    }

let ocf = 
    {
    
        lexicalForm = "ocf"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10241
        wellKnownUriSupport = None
        

    }

let oid = 
    {
    
        lexicalForm = "oid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16079
        wellKnownUriSupport = None
        

    }

let onenote = 
    {
    
        lexicalForm = "onenote"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13608
        wellKnownUriSupport = None
        

    }

let ``onenote-cmd`` = 
    {
    
        lexicalForm = "onenote-cmd"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16632
        wellKnownUriSupport = None
        

    }

let opaquelocktoken = 
    {
    
        lexicalForm = "opaquelocktoken"
        description = Some("""opaquelocktokent""")
        status = Iana.Status.Permanent
        criSchemeNumber = 6341
        wellKnownUriSupport = None
        

    }

let openid = 
    {
    
        lexicalForm = "openid"
        description = Some("""OpenID Connect""")
        status = Iana.Status.Provisional
        criSchemeNumber = 1242
        wellKnownUriSupport = None
        

    }

let openpgp4fpr = 
    {
    
        lexicalForm = "openpgp4fpr"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13094
        wellKnownUriSupport = None
        

    }

let otpauth = 
    {
    
        lexicalForm = "otpauth"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13829
        wellKnownUriSupport = None
        

    }

let p1 = 
    {
    
        lexicalForm = "p1"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 14982
        wellKnownUriSupport = None
        

    }

let pack = 
    {
    
        lexicalForm = "pack"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 13348
        wellKnownUriSupport = None
        

    }

let palm = 
    {
    
        lexicalForm = "palm"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10238
        wellKnownUriSupport = None
        

    }

let paparazzi = 
    {
    
        lexicalForm = "paparazzi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12599
        wellKnownUriSupport = None
        

    }

let payment = 
    {
    
        lexicalForm = "payment"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 1762
        wellKnownUriSupport = None
        

    }

let payto = 
    {
    
        lexicalForm = "payto"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6992
        wellKnownUriSupport = None
        

    }

let pkcs11 = 
    {
    
        lexicalForm = "pkcs11"
        description = Some("""PKCS#11""")
        status = Iana.Status.Permanent
        criSchemeNumber = 9312
        wellKnownUriSupport = None
        

    }

let platform = 
    {
    
        lexicalForm = "platform"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2754
        wellKnownUriSupport = None
        

    }

let pop = 
    {
    
        lexicalForm = "pop"
        description = Some("""Post Office Protocol v3""")
        status = Iana.Status.Permanent
        criSchemeNumber = 10551
        wellKnownUriSupport = None
        

    }

let pres = 
    {
    
        lexicalForm = "pres"
        description = Some("""Presence""")
        status = Iana.Status.Permanent
        criSchemeNumber = 14972
        wellKnownUriSupport = None
        

    }

let prospero = 
    {
    
        lexicalForm = "prospero"
        description = Some("""Prospero Directory Service""")
        status = Iana.Status.Historical
        criSchemeNumber = 14477
        wellKnownUriSupport = None
        

    }

let proxy = 
    {
    
        lexicalForm = "proxy"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3503
        wellKnownUriSupport = None
        

    }

let psyc = 
    {
    
        lexicalForm = "psyc"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1466
        wellKnownUriSupport = None
        

    }

let pttp = 
    {
    
        lexicalForm = "pttp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6903
        wellKnownUriSupport = None
        

    }

let pwid = 
    {
    
        lexicalForm = "pwid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17068
        wellKnownUriSupport = None
        

    }

let qb = 
    {
    
        lexicalForm = "qb"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12478
        wellKnownUriSupport = None
        

    }

let query = 
    {
    
        lexicalForm = "query"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10147
        wellKnownUriSupport = None
        

    }

let ``quic-transport`` = 
    {
    
        lexicalForm = "quic-transport"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6462
        wellKnownUriSupport = None
        

    }

let redis = 
    {
    
        lexicalForm = "redis"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8099
        wellKnownUriSupport = None
        

    }

let rediss = 
    {
    
        lexicalForm = "rediss"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9338
        wellKnownUriSupport = None
        

    }

let reload = 
    {
    
        lexicalForm = "reload"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 12726
        wellKnownUriSupport = None
        

    }

let res = 
    {
    
        lexicalForm = "res"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4153
        wellKnownUriSupport = None
        

    }

let resource = 
    {
    
        lexicalForm = "resource"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2284
        wellKnownUriSupport = None
        

    }

let rmi = 
    {
    
        lexicalForm = "rmi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16292
        wellKnownUriSupport = None
        

    }

let rsync = 
    {
    
        lexicalForm = "rsync"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 16884
        wellKnownUriSupport = None
        

    }

let rtmfp = 
    {
    
        lexicalForm = "rtmfp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3348
        wellKnownUriSupport = None
        

    }

let rtmp = 
    {
    
        lexicalForm = "rtmp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3920
        wellKnownUriSupport = None
        

    }

let rtsp = 
    {
    
        lexicalForm = "rtsp"
        description = Some("""Real-Time Streaming Protocol (RTSP)""")
        status = Iana.Status.Permanent
        criSchemeNumber = 15267
        wellKnownUriSupport = None
        

    }

let rtsps = 
    {
    
        lexicalForm = "rtsps"
        description = Some("""Real-Time Streaming Protocol (RTSP) over TLS""")
        status = Iana.Status.Permanent
        criSchemeNumber = 4619
        wellKnownUriSupport = None
        

    }

let rtspu = 
    {
    
        lexicalForm = "rtspu"
        description = Some("""Real-Time Streaming Protocol (RTSP) over unreliable datagram transport""")
        status = Iana.Status.Permanent
        criSchemeNumber = 11999
        wellKnownUriSupport = None
        

    }

let sarif = 
    {
    
        lexicalForm = "sarif"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13650
        wellKnownUriSupport = None
        

    }

let secondlife = 
    {
    
        lexicalForm = "secondlife"
        description = Some("""query""")
        status = Iana.Status.Provisional
        criSchemeNumber = 16729
        wellKnownUriSupport = None
        

    }

let ``secret-token`` = 
    {
    
        lexicalForm = "secret-token"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7074
        wellKnownUriSupport = None
        

    }

let service = 
    {
    
        lexicalForm = "service"
        description = Some("""service location""")
        status = Iana.Status.Permanent
        criSchemeNumber = 17264
        wellKnownUriSupport = None
        

    }

let session = 
    {
    
        lexicalForm = "session"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 4355
        wellKnownUriSupport = None
        

    }

let sftp = 
    {
    
        lexicalForm = "sftp"
        description = Some("""query""")
        status = Iana.Status.Provisional
        criSchemeNumber = 5492
        wellKnownUriSupport = None
        

    }

let sgn = 
    {
    
        lexicalForm = "sgn"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4882
        wellKnownUriSupport = None
        

    }

let shc = 
    {
    
        lexicalForm = "shc"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5823
        wellKnownUriSupport = None
        

    }

let shelter = 
    {
    
        lexicalForm = "shelter"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15461
        wellKnownUriSupport = None
        

    }

let sieve = 
    {
    
        lexicalForm = "sieve"
        description = Some("""ManageSieve Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 5472
        wellKnownUriSupport = None
        

    }

let simpleledger = 
    {
    
        lexicalForm = "simpleledger"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9544
        wellKnownUriSupport = None
        

    }

let simplex = 
    {
    
        lexicalForm = "simplex"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15118
        wellKnownUriSupport = None
        

    }

let sip = 
    {
    
        lexicalForm = "sip"
        description = Some("""session initiation protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 12644
        wellKnownUriSupport = None
        

    }

let sips = 
    {
    
        lexicalForm = "sips"
        description = Some("""secure session initiation protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 9535
        wellKnownUriSupport = None
        

    }

let skype = 
    {
    
        lexicalForm = "skype"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2326
        wellKnownUriSupport = None
        

    }

let smb = 
    {
    
        lexicalForm = "smb"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7285
        wellKnownUriSupport = None
        

    }

let smp = 
    {
    
        lexicalForm = "smp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11533
        wellKnownUriSupport = None
        

    }

let sms = 
    {
    
        lexicalForm = "sms"
        description = Some("""Short Message Service""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3524
        wellKnownUriSupport = None
        

    }

let smtp = 
    {
    
        lexicalForm = "smtp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13340
        wellKnownUriSupport = None
        

    }

let snews = 
    {
    
        lexicalForm = "snews"
        description = Some("""NNTP over SSL/TLS""")
        status = Iana.Status.Historical
        criSchemeNumber = 13285
        wellKnownUriSupport = None
        

    }

let snmp = 
    {
    
        lexicalForm = "snmp"
        description = Some("""Simple Network Management Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 1165
        wellKnownUriSupport = None
        

    }

let ``soap.beep`` = 
    {
    
        lexicalForm = "soap.beep"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 8519
        wellKnownUriSupport = None
        

    }

let ``soap.beeps`` = 
    {
    
        lexicalForm = "soap.beeps"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 16300
        wellKnownUriSupport = None
        

    }

let soldat = 
    {
    
        lexicalForm = "soldat"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6349
        wellKnownUriSupport = None
        

    }

let spacify = 
    {
    
        lexicalForm = "spacify"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1000
        wellKnownUriSupport = None
        

    }

let spiffe = 
    {
    
        lexicalForm = "spiffe"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8093
        wellKnownUriSupport = None
        

    }

let spotify = 
    {
    
        lexicalForm = "spotify"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12732
        wellKnownUriSupport = None
        

    }

let ssb = 
    {
    
        lexicalForm = "ssb"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12400
        wellKnownUriSupport = None
        

    }

let ssh = 
    {
    
        lexicalForm = "ssh"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7667
        wellKnownUriSupport = None
        

    }

let starknet = 
    {
    
        lexicalForm = "starknet"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12458
        wellKnownUriSupport = None
        

    }

let steam = 
    {
    
        lexicalForm = "steam"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5134
        wellKnownUriSupport = None
        

    }

let stun = 
    {
    
        lexicalForm = "stun"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 14627
        wellKnownUriSupport = None
        

    }

let stuns = 
    {
    
        lexicalForm = "stuns"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 14901
        wellKnownUriSupport = None
        

    }

let submit = 
    {
    
        lexicalForm = "submit"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4951
        wellKnownUriSupport = None
        

    }

let svn = 
    {
    
        lexicalForm = "svn"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13923
        wellKnownUriSupport = None
        

    }

let swh = 
    {
    
        lexicalForm = "swh"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17039
        wellKnownUriSupport = None
        

    }

let swid = 
    {
    
        lexicalForm = "swid"
        description = Some("""swid (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 14162
        wellKnownUriSupport = None
        

    }

let swidpath = 
    {
    
        lexicalForm = "swidpath"
        description = Some("""swidpath (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 5825
        wellKnownUriSupport = None
        

    }

let tag = 
    {
    
        lexicalForm = "tag"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 16377
        wellKnownUriSupport = None
        

    }

let taler = 
    {
    
        lexicalForm = "taler"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2796
        wellKnownUriSupport = None
        

    }

let teamspeak = 
    {
    
        lexicalForm = "teamspeak"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6924
        wellKnownUriSupport = None
        

    }

let teapot = 
    {
    
        lexicalForm = "teapot"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15026
        wellKnownUriSupport = None
        

    }

let teapots = 
    {
    
        lexicalForm = "teapots"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3375
        wellKnownUriSupport = None
        

    }

let tel = 
    {
    
        lexicalForm = "tel"
        description = Some("""telephone""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3143
        wellKnownUriSupport = None
        

    }

let teliaeid = 
    {
    
        lexicalForm = "teliaeid"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13362
        wellKnownUriSupport = None
        

    }

let telnet = 
    {
    
        lexicalForm = "telnet"
        description = Some("""Reference to interactive sessions""")
        status = Iana.Status.Permanent
        criSchemeNumber = 10995
        wellKnownUriSupport = None
        

    }

let tftp = 
    {
    
        lexicalForm = "tftp"
        description = Some("""Trivial File Transfer Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 8300
        wellKnownUriSupport = None
        

    }

let things = 
    {
    
        lexicalForm = "things"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 2154
        wellKnownUriSupport = None
        

    }

let thismessage = 
    {
    
        lexicalForm = "thismessage"
        description = Some("""multipart/related relative reference resolution""")
        status = Iana.Status.Permanent
        criSchemeNumber = 14367
        wellKnownUriSupport = None
        

    }

let thzp = 
    {
    
        lexicalForm = "thzp"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 11820
        wellKnownUriSupport = None
        

    }

let tip = 
    {
    
        lexicalForm = "tip"
        description = Some("""Transaction Internet Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 6651
        wellKnownUriSupport = None
        

    }

let tn3270 = 
    {
    
        lexicalForm = "tn3270"
        description = Some("""Interactive 3270 emulation sessions""")
        status = Iana.Status.Permanent
        criSchemeNumber = 14962
        wellKnownUriSupport = None
        

    }

let tool = 
    {
    
        lexicalForm = "tool"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15230
        wellKnownUriSupport = None
        

    }

let turn = 
    {
    
        lexicalForm = "turn"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 10333
        wellKnownUriSupport = None
        

    }

let turns = 
    {
    
        lexicalForm = "turns"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 1926
        wellKnownUriSupport = None
        

    }

let tv = 
    {
    
        lexicalForm = "tv"
        description = Some("""TV Broadcasts""")
        status = Iana.Status.Permanent
        criSchemeNumber = 7923
        wellKnownUriSupport = None
        

    }

let udp = 
    {
    
        lexicalForm = "udp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 5217
        wellKnownUriSupport = None
        

    }

let unreal = 
    {
    
        lexicalForm = "unreal"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15206
        wellKnownUriSupport = None
        

    }

let upn = 
    {
    
        lexicalForm = "upn"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 1004
        wellKnownUriSupport = None
        

    }

let upt = 
    {
    
        lexicalForm = "upt"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 2747
        wellKnownUriSupport = None
        

    }

let urn = 
    {
    
        lexicalForm = "urn"
        description = Some("""Uniform Resource Names""")
        status = Iana.Status.Permanent
        criSchemeNumber = 4
        wellKnownUriSupport = None
        

    }

let ut2004 = 
    {
    
        lexicalForm = "ut2004"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 6609
        wellKnownUriSupport = None
        

    }

let ``uuid-in-package`` = 
    {
    
        lexicalForm = "uuid-in-package"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4515
        wellKnownUriSupport = None
        

    }

let ``v-event`` = 
    {
    
        lexicalForm = "v-event"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15579
        wellKnownUriSupport = None
        

    }

let vemmi = 
    {
    
        lexicalForm = "vemmi"
        description = Some("""versatile multimedia interface""")
        status = Iana.Status.Permanent
        criSchemeNumber = 16918
        wellKnownUriSupport = None
        

    }

let ventrilo = 
    {
    
        lexicalForm = "ventrilo"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 12502
        wellKnownUriSupport = None
        

    }

let ves = 
    {
    
        lexicalForm = "ves"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 10176
        wellKnownUriSupport = None
        

    }

let videotex = 
    {
    
        lexicalForm = "videotex"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 2406
        wellKnownUriSupport = None
        

    }

let ``view-source`` = 
    {
    
        lexicalForm = "view-source"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 8506
        wellKnownUriSupport = None
        

    }

let vnc = 
    {
    
        lexicalForm = "vnc"
        description = Some("""Remote Framebuffer Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 11537
        wellKnownUriSupport = None
        

    }

let vscode = 
    {
    
        lexicalForm = "vscode"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 7812
        wellKnownUriSupport = None
        

    }

let ``vscode-insiders`` = 
    {
    
        lexicalForm = "vscode-insiders"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3255
        wellKnownUriSupport = None
        

    }

let vsls = 
    {
    
        lexicalForm = "vsls"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9816
        wellKnownUriSupport = None
        

    }

let w3 = 
    {
    
        lexicalForm = "w3"
        description = Some("""w3 
      (see reviewer notes)""")
        status = Iana.Status.Provisional
        criSchemeNumber = 11799
        wellKnownUriSupport = None
        

    }

let wais = 
    {
    
        lexicalForm = "wais"
        description = Some("""Wide Area Information Servers""")
        status = Iana.Status.Historical
        criSchemeNumber = 8454
        wellKnownUriSupport = None
        

    }

let wasm = 
    {
    
        lexicalForm = "wasm"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15741
        wellKnownUriSupport = None
        

    }

let ``wasm-js`` = 
    {
    
        lexicalForm = "wasm-js"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14709
        wellKnownUriSupport = None
        

    }

let wcr = 
    {
    
        lexicalForm = "wcr"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11892
        wellKnownUriSupport = None
        

    }

let ``web+ap`` = 
    {
    
        lexicalForm = "web+ap"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 17361
        wellKnownUriSupport = None
        

    }

let web3 = 
    {
    
        lexicalForm = "web3"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4559
        wellKnownUriSupport = None
        

    }

let webcal = 
    {
    
        lexicalForm = "webcal"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4183
        wellKnownUriSupport = None
        

    }

let wifi = 
    {
    
        lexicalForm = "wifi"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 14867
        wellKnownUriSupport = None
        

    }

let wpid = 
    {
    
        lexicalForm = "wpid"
        description = None
        status = Iana.Status.Historical
        criSchemeNumber = 1658
        wellKnownUriSupport = None
        

    }

let ws = 
    {
    
        lexicalForm = "ws"
        description = Some("""WebSocket connections""")
        status = Iana.Status.Permanent
        criSchemeNumber = 11962
        wellKnownUriSupport = None
        

    }

let wss = 
    {
    
        lexicalForm = "wss"
        description = Some("""Encrypted WebSocket connections""")
        status = Iana.Status.Permanent
        criSchemeNumber = 3119
        wellKnownUriSupport = None
        

    }

let wtai = 
    {
    
        lexicalForm = "wtai"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 9910
        wellKnownUriSupport = None
        

    }

let wyciwyg = 
    {
    
        lexicalForm = "wyciwyg"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15641
        wellKnownUriSupport = None
        

    }

let xcompute = 
    {
    
        lexicalForm = "xcompute"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 13785
        wellKnownUriSupport = None
        

    }

let xcon = 
    {
    
        lexicalForm = "xcon"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 10467
        wellKnownUriSupport = None
        

    }

let ``xcon-userid`` = 
    {
    
        lexicalForm = "xcon-userid"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 9520
        wellKnownUriSupport = None
        

    }

let xfire = 
    {
    
        lexicalForm = "xfire"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 15306
        wellKnownUriSupport = None
        

    }

let xftp = 
    {
    
        lexicalForm = "xftp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4315
        wellKnownUriSupport = None
        

    }

let ``xmlrpc.beep`` = 
    {
    
        lexicalForm = "xmlrpc.beep"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 3005
        wellKnownUriSupport = None
        

    }

let ``xmlrpc.beeps`` = 
    {
    
        lexicalForm = "xmlrpc.beeps"
        description = None
        status = Iana.Status.Permanent
        criSchemeNumber = 15805
        wellKnownUriSupport = None
        

    }

let xmpp = 
    {
    
        lexicalForm = "xmpp"
        description = Some("""Extensible Messaging and Presence Protocol""")
        status = Iana.Status.Permanent
        criSchemeNumber = 15358
        wellKnownUriSupport = None
        

    }

let xrcp = 
    {
    
        lexicalForm = "xrcp"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 4747
        wellKnownUriSupport = None
        

    }

let xri = 
    {
    
        lexicalForm = "xri"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 11255
        wellKnownUriSupport = None
        

    }

let ymsgr = 
    {
    
        lexicalForm = "ymsgr"
        description = None
        status = Iana.Status.Provisional
        criSchemeNumber = 3837
        wellKnownUriSupport = None
        

    }

let ``z39.50`` = 
    {
    
        lexicalForm = "z39.50"
        description = Some("""Z39.50 information access""")
        status = Iana.Status.Historical
        criSchemeNumber = 1319
        wellKnownUriSupport = None
        

    }

let ``z39.50r`` = 
    {
    
        lexicalForm = "z39.50r"
        description = Some("""Z39.50 Retrieval""")
        status = Iana.Status.Permanent
        criSchemeNumber = 8159
        wellKnownUriSupport = None
        

    }

let ``z39.50s`` = 
    {
    
        lexicalForm = "z39.50s"
        description = Some("""Z39.50 Session""")
        status = Iana.Status.Permanent
        criSchemeNumber = 6380
        wellKnownUriSupport = None
        

    }
let all = [|aaa ; aaas ; about ; acap ; acct ; acd ; acr ; adiumxtra ; adt ; afp ; afs ; aim ; amss ; android ; appdata ; apt ; ar ; ari ; ark ; at ; attachment ; aw ; barion ; bb ; beshare ; bitcoin ; bitcoincash ; bl ; blob ; bluetooth ; bolo ; brid ; browserext ; cabal ; calculator ; callto ; cap ; caip ; cast ; casts ; chrome ; ``chrome-extension`` ; cid ; coap ; ``coap+tcp`` ; ``coap+ws`` ; coaps ; ``coaps+tcp`` ; ``coaps+ws`` ; ``com-eventbrite-attendee`` ; content ; ``content-type`` ; crid ; cstr ; cvs ; dab ; dat ; data ; dav ; dhttp ; diaspora ; dict ; did ; dilithium3 ; dis ; ``dlna-playcontainer`` ; ``dlna-playsingle`` ; dnp ; dns ; dntp ; doi ; donau ; dpp ; drm ; drop ; dtmi ; dtn ; dvb ; dvx ; dweb ; ed2k ; eid ; elsi ; embedded ; ens ; esim ; ethereum ; example ; facetime ; fax ; feed ; feedready ; fido ; file ; filesystem ; finger ; ``first-run-pen-experience`` ; fish ; fm ; ftp ; ``fuchsia-pkg`` ; geo ; gg ; git ; gitoid ; gizmoproject ; go ; gopher ; graph ; grd ; gtalk ; h323 ; ham ; hcap ; hcp ; hs20 ; http ; https ; hxxp ; hxxps ; hydrazone ; hyper ; i0 ; iax ; ibi ; ``ibi-`` ; ilstring ; icap ; icon ; im ; imap ; info ; iotdisco ; ipfs ; ipn ; ipns ; ipp ; ipps ; irc ; irc6 ; ircs ; iris ; ``iris.beep`` ; ``iris.lwz`` ; ``iris.xpc`` ; ``iris.xpcs`` ; isostore ; itms ; jabber ; jar ; jms ; keyparc ; lastfm ; lbry ; ldap ; ldaps ; leaptofrogans ; lid ; linkid ; lorawan ; lpa ; lvlt ; machineProvisioningProgressReporter ; magnet ; mailserver ; mailto ; maps ; market ; matrix ; message ; ``microsoft.windows.camera`` ; ``microsoft.windows.camera.multipicker`` ; ``microsoft.windows.camera.picker`` ; mid ; mms ; modem ; mongodb ; moz ; mqtt ; mqtts ; ``ms-access`` ; ``ms-appinstaller`` ; ``ms-browser-extension`` ; ``ms-calculator`` ; ``ms-drive-to`` ; ``ms-enrollment`` ; ``ms-excel`` ; ``ms-eyecontrolspeech`` ; ``ms-gamebarservices`` ; ``ms-gamingoverlay`` ; ``ms-getoffice`` ; ``ms-help`` ; ``ms-infopath`` ; ``ms-inputapp`` ; ``ms-launchremotedesktop`` ; ``ms-lockscreencomponent-config`` ; ``ms-media-stream-id`` ; ``ms-meetnow`` ; ``ms-mixedrealitycapture`` ; ``ms-mobileplans`` ; ``ms-newsandinterests`` ; ``ms-officeapp`` ; ``ms-people`` ; ``ms-personacard`` ; ``ms-powerpoint`` ; ``ms-project`` ; ``ms-publisher`` ; ``ms-recall`` ; ``ms-remotedesktop`` ; ``ms-remotedesktop-launch`` ; ``ms-restoretabcompanion`` ; ``ms-screenclip`` ; ``ms-screensketch`` ; ``ms-search`` ; ``ms-search-repair`` ; ``ms-secondary-screen-controller`` ; ``ms-secondary-screen-setup`` ; ``ms-settings`` ; ``ms-settings-airplanemode`` ; ``ms-settings-bluetooth`` ; ``ms-settings-camera`` ; ``ms-settings-cellular`` ; ``ms-settings-cloudstorage`` ; ``ms-settings-connectabledevices`` ; ``ms-settings-displays-topology`` ; ``ms-settings-emailandaccounts`` ; ``ms-settings-language`` ; ``ms-settings-location`` ; ``ms-settings-lock`` ; ``ms-settings-nfctransactions`` ; ``ms-settings-notifications`` ; ``ms-settings-power`` ; ``ms-settings-privacy`` ; ``ms-settings-proximity`` ; ``ms-settings-screenrotation`` ; ``ms-settings-wifi`` ; ``ms-settings-workplace`` ; ``ms-spd`` ; ``ms-stickers`` ; ``ms-sttoverlay`` ; ``ms-transit-to`` ; ``ms-useractivityset`` ; ``ms-uup`` ; ``ms-virtualtouchpad`` ; ``ms-visio`` ; ``ms-walk-to`` ; ``ms-whiteboard`` ; ``ms-whiteboard-cmd`` ; ``ms-widgetboard`` ; ``ms-widgets`` ; ``ms-word`` ; msnim ; msrp ; msrps ; mss ; mt ; mtqp ; mtrust ; mumble ; mupdate ; mvn ; mvrp ; mvrps ; news ; nfs ; ni ; nih ; nntp ; notes ; num ; ocf ; oid ; onenote ; ``onenote-cmd`` ; opaquelocktoken ; openid ; openpgp4fpr ; otpauth ; p1 ; pack ; palm ; paparazzi ; payment ; payto ; pkcs11 ; platform ; pop ; pres ; prospero ; proxy ; psyc ; pttp ; pwid ; qb ; query ; ``quic-transport`` ; redis ; rediss ; reload ; res ; resource ; rmi ; rsync ; rtmfp ; rtmp ; rtsp ; rtsps ; rtspu ; sarif ; secondlife ; ``secret-token`` ; service ; session ; sftp ; sgn ; shc ; shelter ; sieve ; simpleledger ; simplex ; sip ; sips ; skype ; smb ; smp ; sms ; smtp ; snews ; snmp ; ``soap.beep`` ; ``soap.beeps`` ; soldat ; spacify ; spiffe ; spotify ; ssb ; ssh ; starknet ; steam ; stun ; stuns ; submit ; svn ; swh ; swid ; swidpath ; tag ; taler ; teamspeak ; teapot ; teapots ; tel ; teliaeid ; telnet ; tftp ; things ; thismessage ; thzp ; tip ; tn3270 ; tool ; turn ; turns ; tv ; udp ; unreal ; upn ; upt ; urn ; ut2004 ; ``uuid-in-package`` ; ``v-event`` ; vemmi ; ventrilo ; ves ; videotex ; ``view-source`` ; vnc ; vscode ; ``vscode-insiders`` ; vsls ; w3 ; wais ; wasm ; ``wasm-js`` ; wcr ; ``web+ap`` ; web3 ; webcal ; wifi ; wpid ; ws ; wss ; wtai ; wyciwyg ; xcompute ; xcon ; ``xcon-userid`` ; xfire ; xftp ; ``xmlrpc.beep`` ; ``xmlrpc.beeps`` ; xmpp ; xrcp ; xri ; ymsgr ; ``z39.50`` ; ``z39.50r`` ; ``z39.50s``|]