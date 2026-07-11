namespace Communication

open FSharp.Core
open System
open System.Net
open System.Net.Http
open System.Threading.Tasks
open VDS.RDF
open System.Collections.Generic

module Internet =
    module Standard =
        module Resource =
            module Identifier =
                module System_ =
                    module Name =
                        module Domain =
                            module Sub =
                                type Type = string
                                let inhabitant (inputString: string) : Type = inputString

                            module Level =
                                module Top =
                                    type Type = string
                                    let inhabitant (inputString: string) : Type = inputString

                                module Second =
                                    type Type = string
                                    let inhabitant (inputString: string) : Type = inputString

                            module Name =
                                type Type = string

                                let inhabitant
                                    (secondLevelDomainName: Level.Second.Type)
                                    (topLevelDomainName: Level.Top.Type)
                                    : Type =
                                    $"{secondLevelDomainName}.{topLevelDomainName}"

                module Uniform =
                    type Type = Uri


                    module Scheme =
                        type Type = string
                        let inhabitant (inputString: string) : Type = inputString
                        // Diameter Protocol
                        let aaa = inhabitant "aaa"
                        // Diameter Protocol with Secure Transport
                        let aaas = inhabitant "aaas"
                        // about
                        let about = inhabitant "about"
                        // application configuration access protocol
                        let acap = inhabitant "acap"
                        // acct
                        let acct = inhabitant "acct"
                        // acd
                        let acd = inhabitant "acd"
                        // acr
                        let acr = inhabitant "acr"
                        // adiumxtra
                        let adiumxtra = inhabitant "adiumxtra"
                        // adt
                        let adt = inhabitant "adt"
                        // afp
                        let afp = inhabitant "afp"
                        // Andrew File System global file names
                        let afs = inhabitant "afs"
                        // aim
                        let aim = inhabitant "aim"
                        // amss
                        let amss = inhabitant "amss"
                        // android
                        let android = inhabitant "android"
                        // appdata
                        let appdata = inhabitant "appdata"
                        // apt
                        let apt = inhabitant "apt"
                        // ar
                        let ar = inhabitant "ar"
                        // ari
                        let ari = inhabitant "ari"
                        // ark
                        let ark = inhabitant "ark"
                        // at (see [reviewer notes])
                        let at = inhabitant "at"
                        // attachment
                        let attachment = inhabitant "attachment"
                        // aw
                        let aw = inhabitant "aw"
                        // barion
                        let barion = inhabitant "barion"
                        // bb
                        let bb = inhabitant "bb"
                        // beshare
                        let beshare = inhabitant "beshare"
                        // bitcoin
                        let bitcoin = inhabitant "bitcoin"
                        // bitcoincash
                        let bitcoincash = inhabitant "bitcoincash"
                        // bluetooth (shortened)
                        let bl = inhabitant "bl"
                        // blob
                        let blob = inhabitant "blob"
                        // bluetooth
                        let bluetooth = inhabitant "bluetooth"
                        // bolo
                        let bolo = inhabitant "bolo"
                        // brid
                        let brid = inhabitant "brid"
                        // browserext
                        let browserext = inhabitant "browserext"
                        // cabal
                        let cabal = inhabitant "cabal"
                        // calculator
                        let calculator = inhabitant "calculator"
                        // callto
                        let callto = inhabitant "callto"
                        // Calendar Access Protocol
                        let cap = inhabitant "cap"
                        // caip
                        let caip = inhabitant "caip"
                        // cast
                        let cast = inhabitant "cast"
                        // casts
                        let casts = inhabitant "casts"
                        // chrome
                        let chrome = inhabitant "chrome"
                        // chrome-extension
                        let ``chrome-extension`` = inhabitant "chrome-extension"
                        // content identifier
                        let cid = inhabitant "cid"
                        // coap
                        let coap = inhabitant "coap"
                        // coap+tcp (see [reviewer notes])
                        let ``coap+tcp`` = inhabitant "coap+tcp"
                        // coap+ws (see [reviewer notes])
                        let ``coap+ws`` = inhabitant "coap+ws"
                        // coaps
                        let coaps = inhabitant "coaps"
                        // coaps+tcp (see [reviewer notes])
                        let ``coaps+tcp`` = inhabitant "coaps+tcp"
                        // coaps+ws (see [reviewer notes])
                        let ``coaps+ws`` = inhabitant "coaps+ws"
                        // com-eventbrite-attendee
                        let ``com-eventbrite-attendee`` = inhabitant "com-eventbrite-attendee"
                        // content
                        let content = inhabitant "content"
                        // content-type
                        let ``content-type`` = inhabitant "content-type"
                        // TV-Anytime Content Reference Identifier
                        let crid = inhabitant "crid"
                        // cstr
                        let cstr = inhabitant "cstr"
                        // cvs
                        let cvs = inhabitant "cvs"
                        // dab
                        let dab = inhabitant "dab"
                        // dat
                        let dat = inhabitant "dat"
                        // data
                        let data = inhabitant "data"
                        // dav
                        let dav = inhabitant "dav"
                        // dhttp (see [reviewer notes])
                        let dhttp = inhabitant "dhttp"
                        // diaspora
                        let diaspora = inhabitant "diaspora"
                        // dictionary service protocol
                        let dict = inhabitant "dict"
                        // did
                        let did = inhabitant "did"
                        // dis
                        let dis = inhabitant "dis"
                        // dlna-playcontainer
                        let ``dlna-playcontainer`` = inhabitant "dlna-playcontainer"
                        // dlna-playsingle
                        let ``dlna-playsingle`` = inhabitant "dlna-playsingle"
                        // dnp
                        let dnp = inhabitant "dnp"
                        // Domain Name System
                        let dns = inhabitant "dns"
                        // dntp
                        let dntp = inhabitant "dntp"
                        // doi
                        let doi = inhabitant "doi"
                        // donau
                        let donau = inhabitant "donau"
                        // dpp
                        let dpp = inhabitant "dpp"
                        // drm
                        let drm = inhabitant "drm"
                        // drop
                        let drop = inhabitant "drop"
                        // dtmi
                        let dtmi = inhabitant "dtmi"
                        // DTNRG research and development
                        let dtn = inhabitant "dtn"
                        // dvb
                        let dvb = inhabitant "dvb"
                        // dvx
                        let dvx = inhabitant "dvx"
                        // dweb
                        let dweb = inhabitant "dweb"
                        // ed2k
                        let ed2k = inhabitant "ed2k"
                        // eid
                        let eid = inhabitant "eid"
                        // elsi
                        let elsi = inhabitant "elsi"
                        // embedded
                        let embedded = inhabitant "embedded"
                        // ens
                        let ens = inhabitant "ens"
                        // esim
                        let esim = inhabitant "esim"
                        // ethereum
                        let ethereum = inhabitant "ethereum"
                        // example
                        let example = inhabitant "example"
                        // facetime
                        let facetime = inhabitant "facetime"
                        // fax
                        let fax = inhabitant "fax"
                        // feed
                        let feed = inhabitant "feed"
                        // feedready
                        let feedready = inhabitant "feedready"
                        // fido
                        let fido = inhabitant "fido"
                        // Host-specific file names
                        let file = inhabitant "file"
                        // filesystem
                        let filesystem = inhabitant "filesystem"
                        // finger
                        let finger = inhabitant "finger"
                        // first-run-pen-experience
                        let ``first-run-pen-experience`` = inhabitant "first-run-pen-experience"
                        // fish
                        let fish = inhabitant "fish"
                        // fm
                        let fm = inhabitant "fm"
                        // File Transfer Protocol
                        let ftp = inhabitant "ftp"
                        // fuchsia-pkg
                        let ``fuchsia-pkg`` = inhabitant "fuchsia-pkg"
                        // Geographic Locations
                        let geo = inhabitant "geo"
                        // gg
                        let gg = inhabitant "gg"
                        // git
                        let git = inhabitant "git"
                        // gitoid
                        let gitoid = inhabitant "gitoid"
                        // gizmoproject
                        let gizmoproject = inhabitant "gizmoproject"
                        // go
                        let go = inhabitant "go"
                        // The Gopher Protocol
                        let gopher = inhabitant "gopher"
                        // graph
                        let graph = inhabitant "graph"
                        // grd
                        let grd = inhabitant "grd"
                        // gtalk
                        let gtalk = inhabitant "gtalk"
                        // H.323
                        let h323 = inhabitant "h323"
                        // ham
                        let ham = inhabitant "ham"
                        // hcap
                        let hcap = inhabitant "hcap"
                        // hcp
                        let hcp = inhabitant "hcp"
                        // hs20
                        let hs20 = inhabitant "hs20"
                        // Hypertext Transfer Protocol
                        let http = inhabitant "http"
                        // Hypertext Transfer Protocol Secure
                        let https = inhabitant "https"
                        // hxxp
                        let hxxp = inhabitant "hxxp"
                        // hxxps
                        let hxxps = inhabitant "hxxps"
                        // hydrazone
                        let hydrazone = inhabitant "hydrazone"
                        // hyper
                        let hyper = inhabitant "hyper"
                        // i0
                        let i0 = inhabitant "i0"
                        // Inter-Asterisk eXchange Version 2
                        let iax = inhabitant "iax"
                        // Internet Content Adaptation Protocol
                        let icap = inhabitant "icap"
                        // icon
                        let icon = inhabitant "icon"
                        // ilstring
                        let ilstring = inhabitant "ilstring"
                        // Instant Messaging
                        let im = inhabitant "im"
                        // internet message access protocol
                        let imap = inhabitant "imap"
                        // Information Assets with Identifiers in Public Namespaces. [RFC4452] (section 3) defines an "info" registry of public namespaces, which is maintained by NISO and can be accessed from [http://info-uri.info/].
                        let info = inhabitant "info"
                        // iotdisco
                        let iotdisco = inhabitant "iotdisco"
                        // ipfs
                        let ipfs = inhabitant "ipfs"
                        // ipn
                        let ipn = inhabitant "ipn"
                        // ipns
                        let ipns = inhabitant "ipns"
                        // Internet Printing Protocol
                        let ipp = inhabitant "ipp"
                        // Internet Printing Protocol over HTTPS
                        let ipps = inhabitant "ipps"
                        // irc
                        let irc = inhabitant "irc"
                        // irc6
                        let irc6 = inhabitant "irc6"
                        // ircs
                        let ircs = inhabitant "ircs"
                        // Internet Registry Information Service
                        let iris = inhabitant "iris"
                        // iris.beep
                        let ``iris.beep`` = inhabitant "iris.beep"
                        // iris.lwz
                        let ``iris.lwz`` = inhabitant "iris.lwz"
                        // iris.xpc
                        let ``iris.xpc`` = inhabitant "iris.xpc"
                        // iris.xpcs
                        let ``iris.xpcs`` = inhabitant "iris.xpcs"
                        // isostore
                        let isostore = inhabitant "isostore"
                        // itms
                        let itms = inhabitant "itms"
                        // jabber
                        let jabber = inhabitant "jabber"
                        // jar
                        let jar = inhabitant "jar"
                        // Java Message Service
                        let jms = inhabitant "jms"
                        // keyparc
                        let keyparc = inhabitant "keyparc"
                        // lastfm
                        let lastfm = inhabitant "lastfm"
                        // lbry
                        let lbry = inhabitant "lbry"
                        // Lightweight Directory Access Protocol
                        let ldap = inhabitant "ldap"
                        // ldaps
                        let ldaps = inhabitant "ldaps"
                        // leaptofrogans
                        let leaptofrogans = inhabitant "leaptofrogans"
                        // lid
                        let lid = inhabitant "lid"
                        // linkid
                        let linkid = inhabitant "linkid"
                        // lorawan
                        let lorawan = inhabitant "lorawan"
                        // lpa
                        let lpa = inhabitant "lpa"
                        // lvlt
                        let lvlt = inhabitant "lvlt"
                        // Windows Autopilot Modern Device Management status updates
                        let machineProvisioningProgressReporter =
                            inhabitant "machineProvisioningProgressReporter"
                        // magnet
                        let magnet = inhabitant "magnet"
                        // Access to data available from mail servers
                        let mailserver = inhabitant "mailserver"
                        // Electronic mail address
                        let mailto = inhabitant "mailto"
                        // maps
                        let maps = inhabitant "maps"
                        // market
                        let market = inhabitant "market"
                        // matrix
                        let matrix = inhabitant "matrix"
                        // message
                        let message = inhabitant "message"
                        // microsoft.windows.camera
                        let ``microsoft.windows.camera`` = inhabitant "microsoft.windows.camera"
                        // microsoft.windows.camera.multipicker
                        let ``microsoft.windows.camera.multipicker`` =
                            inhabitant "microsoft.windows.camera.multipicker"
                        // microsoft.windows.camera.picker
                        let ``microsoft.windows.camera.picker`` =
                            inhabitant "microsoft.windows.camera.picker"
                        // message identifier
                        let mid = inhabitant "mid"
                        // mms
                        let mms = inhabitant "mms"
                        // modem
                        let modem = inhabitant "modem"
                        // mongodb
                        let mongodb = inhabitant "mongodb"
                        // moz
                        let moz = inhabitant "moz"
                        // mqtt
                        let mqtt = inhabitant "mqtt"
                        // mqtts
                        let mqtts = inhabitant "mqtts"
                        // ms-access
                        let ``ms-access`` = inhabitant "ms-access"
                        // ms-appinstaller
                        let ``ms-appinstaller`` = inhabitant "ms-appinstaller"
                        // ms-browser-extension
                        let ``ms-browser-extension`` = inhabitant "ms-browser-extension"
                        // ms-calculator
                        let ``ms-calculator`` = inhabitant "ms-calculator"
                        // ms-drive-to
                        let ``ms-drive-to`` = inhabitant "ms-drive-to"
                        // ms-enrollment
                        let ``ms-enrollment`` = inhabitant "ms-enrollment"
                        // ms-excel
                        let ``ms-excel`` = inhabitant "ms-excel"
                        // ms-eyecontrolspeech
                        let ``ms-eyecontrolspeech`` = inhabitant "ms-eyecontrolspeech"
                        // ms-gamebarservices
                        let ``ms-gamebarservices`` = inhabitant "ms-gamebarservices"
                        // ms-gamingoverlay
                        let ``ms-gamingoverlay`` = inhabitant "ms-gamingoverlay"
                        // ms-getoffice
                        let ``ms-getoffice`` = inhabitant "ms-getoffice"
                        // ms-help
                        let ``ms-help`` = inhabitant "ms-help"
                        // ms-infopath
                        let ``ms-infopath`` = inhabitant "ms-infopath"
                        // ms-inputapp
                        let ``ms-inputapp`` = inhabitant "ms-inputapp"
                        // ms-launchremotedesktop
                        let ``ms-launchremotedesktop`` = inhabitant "ms-launchremotedesktop"
                        // ms-lockscreencomponent-config
                        let ``ms-lockscreencomponent-config`` = inhabitant "ms-lockscreencomponent-config"
                        // ms-media-stream-id
                        let ``ms-media-stream-id`` = inhabitant "ms-media-stream-id"
                        // ms-meetnow
                        let ``ms-meetnow`` = inhabitant "ms-meetnow"
                        // ms-mixedrealitycapture
                        let ``ms-mixedrealitycapture`` = inhabitant "ms-mixedrealitycapture"
                        // ms-mobileplans
                        let ``ms-mobileplans`` = inhabitant "ms-mobileplans"
                        // ms-newsandinterests
                        let ``ms-newsandinterests`` = inhabitant "ms-newsandinterests"
                        // ms-officeapp
                        let ``ms-officeapp`` = inhabitant "ms-officeapp"
                        // ms-people
                        let ``ms-people`` = inhabitant "ms-people"
                        // ms-personacard
                        let ``ms-personacard`` = inhabitant "ms-personacard"
                        // ms-powerpoint
                        let ``ms-powerpoint`` = inhabitant "ms-powerpoint"
                        // ms-project
                        let ``ms-project`` = inhabitant "ms-project"
                        // ms-publisher
                        let ``ms-publisher`` = inhabitant "ms-publisher"
                        // ms-recall
                        let ``ms-recall`` = inhabitant "ms-recall"
                        // ms-remotedesktop
                        let ``ms-remotedesktop`` = inhabitant "ms-remotedesktop"
                        // ms-remotedesktop-launch
                        let ``ms-remotedesktop-launch`` = inhabitant "ms-remotedesktop-launch"
                        // ms-restoretabcompanion
                        let ``ms-restoretabcompanion`` = inhabitant "ms-restoretabcompanion"
                        // ms-screenclip
                        let ``ms-screenclip`` = inhabitant "ms-screenclip"
                        // ms-screensketch
                        let ``ms-screensketch`` = inhabitant "ms-screensketch"
                        // ms-search
                        let ``ms-search`` = inhabitant "ms-search"
                        // ms-search-repair
                        let ``ms-search-repair`` = inhabitant "ms-search-repair"
                        // ms-secondary-screen-controller
                        let ``ms-secondary-screen-controller`` = inhabitant "ms-secondary-screen-controller"
                        // ms-secondary-screen-setup
                        let ``ms-secondary-screen-setup`` = inhabitant "ms-secondary-screen-setup"
                        // ms-settings
                        let ``ms-settings`` = inhabitant "ms-settings"
                        // ms-settings-airplanemode
                        let ``ms-settings-airplanemode`` = inhabitant "ms-settings-airplanemode"
                        // ms-settings-bluetooth
                        let ``ms-settings-bluetooth`` = inhabitant "ms-settings-bluetooth"
                        // ms-settings-camera
                        let ``ms-settings-camera`` = inhabitant "ms-settings-camera"
                        // ms-settings-cellular
                        let ``ms-settings-cellular`` = inhabitant "ms-settings-cellular"
                        // ms-settings-cloudstorage
                        let ``ms-settings-cloudstorage`` = inhabitant "ms-settings-cloudstorage"
                        // ms-settings-connectabledevices
                        let ``ms-settings-connectabledevices`` = inhabitant "ms-settings-connectabledevices"
                        // ms-settings-displays-topology
                        let ``ms-settings-displays-topology`` = inhabitant "ms-settings-displays-topology"
                        // ms-settings-emailandaccounts
                        let ``ms-settings-emailandaccounts`` = inhabitant "ms-settings-emailandaccounts"
                        // ms-settings-language
                        let ``ms-settings-language`` = inhabitant "ms-settings-language"
                        // ms-settings-location
                        let ``ms-settings-location`` = inhabitant "ms-settings-location"
                        // ms-settings-lock
                        let ``ms-settings-lock`` = inhabitant "ms-settings-lock"
                        // ms-settings-nfctransactions
                        let ``ms-settings-nfctransactions`` = inhabitant "ms-settings-nfctransactions"
                        // ms-settings-notifications
                        let ``ms-settings-notifications`` = inhabitant "ms-settings-notifications"
                        // ms-settings-power
                        let ``ms-settings-power`` = inhabitant "ms-settings-power"
                        // ms-settings-privacy
                        let ``ms-settings-privacy`` = inhabitant "ms-settings-privacy"
                        // ms-settings-proximity
                        let ``ms-settings-proximity`` = inhabitant "ms-settings-proximity"
                        // ms-settings-screenrotation
                        let ``ms-settings-screenrotation`` = inhabitant "ms-settings-screenrotation"
                        // ms-settings-wifi
                        let ``ms-settings-wifi`` = inhabitant "ms-settings-wifi"
                        // ms-settings-workplace
                        let ``ms-settings-workplace`` = inhabitant "ms-settings-workplace"
                        // ms-spd
                        let ``ms-spd`` = inhabitant "ms-spd"
                        // ms-stickers
                        let ``ms-stickers`` = inhabitant "ms-stickers"
                        // ms-sttoverlay
                        let ``ms-sttoverlay`` = inhabitant "ms-sttoverlay"
                        // ms-transit-to
                        let ``ms-transit-to`` = inhabitant "ms-transit-to"
                        // ms-useractivityset
                        let ``ms-useractivityset`` = inhabitant "ms-useractivityset"
                        // ms-uup
                        let ``ms-uup`` = inhabitant "ms-uup"
                        // ms-virtualtouchpad
                        let ``ms-virtualtouchpad`` = inhabitant "ms-virtualtouchpad"
                        // ms-visio
                        let ``ms-visio`` = inhabitant "ms-visio"
                        // ms-walk-to
                        let ``ms-walk-to`` = inhabitant "ms-walk-to"
                        // ms-whiteboard
                        let ``ms-whiteboard`` = inhabitant "ms-whiteboard"
                        // ms-whiteboard-cmd
                        let ``ms-whiteboard-cmd`` = inhabitant "ms-whiteboard-cmd"
                        // ms-widgetboard
                        let ``ms-widgetboard`` = inhabitant "ms-widgetboard"
                        // ms-widgets
                        let ``ms-widgets`` = inhabitant "ms-widgets"
                        // ms-word
                        let ``ms-word`` = inhabitant "ms-word"
                        // msnim
                        let msnim = inhabitant "msnim"
                        // Message Session Relay Protocol
                        let msrp = inhabitant "msrp"
                        // Message Session Relay Protocol Secure
                        let msrps = inhabitant "msrps"
                        // mss
                        let mss = inhabitant "mss"
                        // Matter protocol on-boarding payloads that are encoded for use in QR Codes and/or NFC Tags
                        let mt = inhabitant "mt"
                        // Message Tracking Query Protocol
                        let mtqp = inhabitant "mtqp"
                        // mtrust
                        let mtrust = inhabitant "mtrust"
                        // mumble
                        let mumble = inhabitant "mumble"
                        // Mailbox Update (MUPDATE) Protocol
                        let mupdate = inhabitant "mupdate"
                        // mvn
                        let mvn = inhabitant "mvn"
                        // "mvrp
                        let mvrp = inhabitant "mvrp"
                        // "mvrps
                        let mvrps = inhabitant "mvrps"
                        // USENET news
                        let news = inhabitant "news"
                        // network file system protocol
                        let nfs = inhabitant "nfs"
                        // ni
                        let ni = inhabitant "ni"
                        // nih
                        let nih = inhabitant "nih"
                        // USENET news using NNTP access
                        let nntp = inhabitant "nntp"
                        // notes
                        let notes = inhabitant "notes"
                        // Namespace Utility Modules
                        let num = inhabitant "num"
                        // ocf
                        let ocf = inhabitant "ocf"
                        // oid
                        let oid = inhabitant "oid"
                        // onenote
                        let onenote = inhabitant "onenote"
                        // onenote-cmd
                        let ``onenote-cmd`` = inhabitant "onenote-cmd"
                        // opaquelocktokent
                        let opaquelocktoken = inhabitant "opaquelocktoken"
                        // OpenID Connect
                        let openid = inhabitant "openid"
                        // openpgp4fpr
                        let openpgp4fpr = inhabitant "openpgp4fpr"
                        // otpauth
                        let otpauth = inhabitant "otpauth"
                        // p1
                        let p1 = inhabitant "p1"
                        // pack
                        let pack = inhabitant "pack"
                        // palm
                        let palm = inhabitant "palm"
                        // paparazzi
                        let paparazzi = inhabitant "paparazzi"
                        // payment
                        let payment = inhabitant "payment"
                        // payto
                        let payto = inhabitant "payto"
                        // PKCS#11
                        let pkcs11 = inhabitant "pkcs11"
                        // platform
                        let platform = inhabitant "platform"
                        // Post Office Protocol v3
                        let pop = inhabitant "pop"
                        // Presence
                        let pres = inhabitant "pres"
                        // Prospero Directory Service
                        let prospero = inhabitant "prospero"
                        // proxy
                        let proxy = inhabitant "proxy"
                        // psyc
                        let psyc = inhabitant "psyc"
                        // pttp
                        let pttp = inhabitant "pttp"
                        // pwid
                        let pwid = inhabitant "pwid"
                        // qb
                        let qb = inhabitant "qb"
                        // query
                        let query = inhabitant "query"
                        // quic-transport
                        let ``quic-transport`` = inhabitant "quic-transport"
                        // redis
                        let redis = inhabitant "redis"
                        // rediss
                        let rediss = inhabitant "rediss"
                        // reload
                        let reload = inhabitant "reload"
                        // res
                        let res = inhabitant "res"
                        // resource
                        let resource = inhabitant "resource"
                        // rmi
                        let rmi = inhabitant "rmi"
                        // rsync
                        let rsync = inhabitant "rsync"
                        // rtmfp
                        let rtmfp = inhabitant "rtmfp"
                        // rtmp
                        let rtmp = inhabitant "rtmp"
                        // Real-Time Streaming Protocol (RTSP)
                        let rtsp = inhabitant "rtsp"
                        // Real-Time Streaming Protocol (RTSP) over TLS
                        let rtsps = inhabitant "rtsps"
                        // Real-Time Streaming Protocol (RTSP) over unreliable datagram transport
                        let rtspu = inhabitant "rtspu"
                        // sarif
                        let sarif = inhabitant "sarif"
                        // query
                        let secondlife = inhabitant "secondlife"
                        // secret-token
                        let ``secret-token`` = inhabitant "secret-token"
                        // service location
                        let service = inhabitant "service"
                        // session
                        let session = inhabitant "session"
                        // query
                        let sftp = inhabitant "sftp"
                        // sgn
                        let sgn = inhabitant "sgn"
                        // shc
                        let shc = inhabitant "shc"
                        // shelter
                        let shelter = inhabitant "shelter"
                        // (OBSOLETE)	Secure Hypertext Transfer Protocol
                        let shttp = inhabitant "shttp"
                        // ManageSieve Protocol
                        let sieve = inhabitant "sieve"
                        // simpleledger
                        let simpleledger = inhabitant "simpleledger"
                        // simplex
                        let simplex = inhabitant "simplex"
                        // session initiation protocol
                        let sip = inhabitant "sip"
                        // secure session initiation protocol
                        let sips = inhabitant "sips"
                        // skype
                        let skype = inhabitant "skype"
                        // smb
                        let smb = inhabitant "smb"
                        // smp
                        let smp = inhabitant "smp"
                        // Short Message Service
                        let sms = inhabitant "sms"
                        // smtp
                        let smtp = inhabitant "smtp"
                        // NNTP over SSL/TLS
                        let snews = inhabitant "snews"
                        // Simple Network Management Protocol
                        let snmp = inhabitant "snmp"
                        // soap.beep
                        let ``soap.beep`` = inhabitant "soap.beep"
                        // soap.beeps
                        let ``soap.beeps`` = inhabitant "soap.beeps"
                        // soldat
                        let soldat = inhabitant "soldat"
                        // spacify
                        let spacify = inhabitant "spacify"
                        // spiffe
                        let spiffe = inhabitant "spiffe"
                        // spotify
                        let spotify = inhabitant "spotify"
                        // ssb
                        let ssb = inhabitant "ssb"
                        // ssh
                        let ssh = inhabitant "ssh"
                        // starknet
                        let starknet = inhabitant "starknet"
                        // steam
                        let steam = inhabitant "steam"
                        // stun
                        let stun = inhabitant "stun"
                        // stuns
                        let stuns = inhabitant "stuns"
                        // submit
                        let submit = inhabitant "submit"
                        // svn
                        let svn = inhabitant "svn"
                        // swh
                        let swh = inhabitant "swh"
                        // swid (see [reviewer notes])
                        let swid = inhabitant "swid"
                        // swidpath (see [reviewer notes])
                        let swidpath = inhabitant "swidpath"
                        // tag
                        let tag = inhabitant "tag"
                        // taler
                        let taler = inhabitant "taler"
                        // teamspeak
                        let teamspeak = inhabitant "teamspeak"
                        // teapot
                        let teapot = inhabitant "teapot"
                        // teapots
                        let teapots = inhabitant "teapots"
                        // telephone
                        let tel = inhabitant "tel"
                        // teliaeid
                        let teliaeid = inhabitant "teliaeid"
                        // Reference to interactive sessions
                        let telnet = inhabitant "telnet"
                        // Trivial File Transfer Protocol
                        let tftp = inhabitant "tftp"
                        // things
                        let things = inhabitant "things"
                        // multipart/related relative reference resolution
                        let thismessage = inhabitant "thismessage"
                        // thzp
                        let thzp = inhabitant "thzp"
                        // Transaction Internet Protocol
                        let tip = inhabitant "tip"
                        // Interactive 3270 emulation sessions
                        let tn3270 = inhabitant "tn3270"
                        // tool
                        let tool = inhabitant "tool"
                        // turn
                        let turn = inhabitant "turn"
                        // turns
                        let turns = inhabitant "turns"
                        // TV Broadcasts
                        let tv = inhabitant "tv"
                        // udp
                        let udp = inhabitant "udp"
                        // unreal
                        let unreal = inhabitant "unreal"
                        // upt
                        let upt = inhabitant "upt"
                        // Uniform Resource Names
                        let urn = inhabitant "urn"
                        // ut2004
                        let ut2004 = inhabitant "ut2004"
                        // uuid-in-package
                        let ``uuid-in-package`` = inhabitant "uuid-in-package"
                        // v-event
                        let ``v-event`` = inhabitant "v-event"
                        // versatile multimedia interface
                        let vemmi = inhabitant "vemmi"
                        // ventrilo
                        let ventrilo = inhabitant "ventrilo"
                        // ves
                        let ves = inhabitant "ves"
                        // videotex
                        let videotex = inhabitant "videotex"
                        // view-source
                        let ``view-source`` = inhabitant "view-source"
                        // Remote Framebuffer Protocol
                        let vnc = inhabitant "vnc"
                        // vscode
                        let vscode = inhabitant "vscode"
                        // vscode-insiders
                        let ``vscode-insiders`` = inhabitant "vscode-insiders"
                        // vsls
                        let vsls = inhabitant "vsls"
                        // w3 (see [reviewer notes])
                        let w3 = inhabitant "w3"
                        // Wide Area Information Servers
                        let wais = inhabitant "wais"
                        // wasm
                        let wasm = inhabitant "wasm"
                        // wasm-js
                        let ``wasm-js`` = inhabitant "wasm-js"
                        // wcr
                        let wcr = inhabitant "wcr"
                        // web+ap
                        let ``web+ap`` = inhabitant "web+ap"
                        // web3
                        let web3 = inhabitant "web3"
                        // webcal
                        let webcal = inhabitant "webcal"
                        // wifi
                        let wifi = inhabitant "wifi"
                        // wpid
                        let wpid = inhabitant "wpid"
                        // WebSocket connections
                        let ws = inhabitant "ws"
                        // Encrypted WebSocket connections
                        let wss = inhabitant "wss"
                        // wtai
                        let wtai = inhabitant "wtai"
                        // wyciwyg
                        let wyciwyg = inhabitant "wyciwyg"
                        // xcompute
                        let xcompute = inhabitant "xcompute"
                        // xcon
                        let xcon = inhabitant "xcon"
                        // xcon-userid
                        let ``xcon-userid`` = inhabitant "xcon-userid"
                        // xfire
                        let xfire = inhabitant "xfire"
                        // xftp
                        let xftp = inhabitant "xftp"
                        // xmlrpc.beep
                        let ``xmlrpc.beep`` = inhabitant "xmlrpc.beep"
                        // xmlrpc.beeps
                        let ``xmlrpc.beeps`` = inhabitant "xmlrpc.beeps"
                        // Extensible Messaging and Presence Protocol
                        let xmpp = inhabitant "xmpp"
                        // xrcp
                        let xrcp = inhabitant "xrcp"
                        // xri
                        let xri = inhabitant "xri"
                        // ymsgr
                        let ymsgr = inhabitant "ymsgr"
                        // Z39.50 information access
                        let ``z39.50`` = inhabitant "z39.50"
                        // Z39.50 Retrieval
                        let ``z39.50r`` = inhabitant "z39.50r"
                        // Z39.50 Session
                        let ``z39.50s`` = inhabitant "z39.50s"

                    let isHttp (uri: Type) =
                        uri.Scheme.Equals(Scheme.http, StringComparison.OrdinalIgnoreCase)

                    let isHttps (uri: Type) =
                        uri.Scheme.Equals(Scheme.https, StringComparison.OrdinalIgnoreCase)

                    let isHttpOrHttps (uri: Type) = isHttp uri || isHttps uri

                    let isFile (uri: Type) =
                        uri.Scheme.Equals(Scheme.file, StringComparison.OrdinalIgnoreCase)

                    let inhabitant (uriString: string) = UriFactory.Create(uriString)




                    module Host =
                        type Type = string

                        let inhabitant
                            (subdomain: System_.Name.Domain.Sub.Type)
                            (domainName: System_.Name.Domain.Name.Type)
                            : Type =
                            $"{subdomain}.{domainName}"

                module Locator =
                    type Type = string

                    let inhabitant (scheme: Uniform.Scheme.Type) (host: Uniform.Host.Type) : Type = $"{scheme}://{host}"

                    let queryString (parameterList: string list) =
                        parameterList
                        |> List.map (fun parameter -> parameter)
                        |> String.concat "&"

                module Internationalized =
                    type Type =
                        { _namespaceUri: Uniform.Type
                          _distributionUriString: string option
                          _namespacePrefix: string option
                          _localName: string }

                        member this._isHashNamespace = this._namespaceUri.OriginalString.EndsWith('#')
                        member this._isSlashNamespace = this._namespaceUri.OriginalString.EndsWith('/')


                        member this._uri: Uniform.Type =
                            let uriString = $"{this._namespaceUri}{this._localName}"
                            let uri = UriFactory.Create(uriString)

                            if isNull (box uri) then
                                invalidOp (
                                    $"UriFactory.Create returned null.\n  namespaceUri: {this._namespaceUri.OriginalString}\n  localName: {this._localName}\n  combined: {uriString}"
                                )

                            uri

                        member this._vocabularyUri: Uniform.Type =
                            if this._isHashNamespace then
                                let namespaceUriString = this._namespaceUri.OriginalString
                                let namespaceUriFragment = this._namespaceUri.Fragment
                                let vocabularyUriString = namespaceUriString.Replace(namespaceUriFragment, "")
                                UriFactory.Create($"{vocabularyUriString}")
                            else
                                this._namespaceUri


                        member this._nodeFromGraph(g: IGraph) = g.CreateUriNode(this._uri)
                        member this._namespaceNode = new UriNode(this._namespaceUri)
                        member this._node = new UriNode(this._uri)

                        member this._prefix(localName: string) = { this with _localName = localName }

                    let inhabitant
                        (uriString: string)
                        (namespaceDistribution: string option)
                        (namespacePrefix: string option)
                        (localName: string option)
                        : Type =
                        { _namespaceUri = UriFactory.Create(uriString)
                          _distributionUriString = namespaceDistribution
                          _namespacePrefix = namespacePrefix
                          _localName = defaultArg localName "" }

    module ProtocolSuite =
        module Layer =
            module Application =
                module Protocol =
                    module Transfer =
                        module Text =
                            module Hyper =
                                module Client =
                                    type Type = HttpClient

                                    module Handler =
                                        type Type = HttpClientHandler

                                        let inhabitant =
                                            let handler = new HttpClientHandler()
                                            handler.AllowAutoRedirect <- true

                                            handler.AutomaticDecompression <-
                                                DecompressionMethods.GZip
                                                ||| DecompressionMethods.Deflate
                                                ||| DecompressionMethods.Brotli

                                            handler

                                    let inhabitant = new HttpClient(Handler.inhabitant, disposeHandler = true)

                                module Message =
                                    module Request =
                                        module Method =
                                            open System.Collections.Generic
                                            open System.Net.Http.Headers

                                            let GET (uriString: string) (client: Client.Type) =
                                                task {
                                                    let! response =
                                                        client.GetAsync(
                                                            Standard.Resource.Identifier.Uniform.inhabitant uriString
                                                        )

                                                    return response
                                                }

                                            let GET_withHeaders (uriString: string) (client: Client.Type) =
                                                task {
                                                    let uri = Standard.Resource.Identifier.Uniform.inhabitant uriString
                                                    use req = new HttpRequestMessage(HttpMethod.Get, uri)

                                                    // A boring “browser-like enough” UA; servers often gate on this.
                                                    req.Headers.UserAgent.Clear()
                                                    req.Headers.UserAgent.Add(ProductInfoHeaderValue("Mozilla", "5.0"))

                                                    // Ask for RDF first, but allow anything.
                                                    req.Headers.Accept.Clear()

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("text/turtle")
                                                    )

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("application/n-triples")
                                                    )

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("application/rdf+xml")
                                                    )

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("application/trig")
                                                    )

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("application/n-quads")
                                                    )

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("application/ld+json")
                                                    )

                                                    req.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("text/plain", 0.8)
                                                    )

                                                    req.Headers.Accept.Add(MediaTypeWithQualityHeaderValue("*/*", 0.1))

                                                    let! response = client.SendAsync(req)
                                                    return response
                                                }

                                            let POST
                                                (endpointUriString: string)
                                                (content: seq<KeyValuePair<string, string>>)
                                                (client: HttpClient)
                                                : Task<HttpResponseMessage> =
                                                task {
                                                    let endpointUri =
                                                        Standard.Resource.Identifier.Uniform.inhabitant
                                                            endpointUriString

                                                    let urlEncodedContent = new FormUrlEncodedContent(content)

                                                    // If you *really* want to mirror charset=UTF-8 explicitly:
                                                    urlEncodedContent.Headers.ContentType.CharSet <- "UTF-8"

                                                    let request = new HttpRequestMessage(HttpMethod.Post, endpointUri)
                                                    request.Content <- urlEncodedContent

                                                    // Accept: text/turtle,*/*;q=0.9
                                                    request.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("text/turtle")
                                                    )

                                                    request.Headers.Accept.Add(
                                                        MediaTypeWithQualityHeaderValue("*/*", 0.9)
                                                    )

                                                    // Optional: only add these if you see CSRF-ish failures (403 etc.)
                                                    // req.Headers.Referrer <- Uri("https://lov.linkeddata.es/")
                                                    // req.Headers.TryAddWithoutValidation("Origin", "https://lov.linkeddata.es") |> ignore
                                                    // Optional: XHR marker (rarely needed)
                                                    // req.Headers.TryAddWithoutValidation("X-Requested-With", "XMLHttpRequest") |> ignore

                                                    let! response = client.SendAsync(request)
                                                    return response
                                                }
