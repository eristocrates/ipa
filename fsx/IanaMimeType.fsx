open System
#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\dll\"
#r @"Internet.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx\"
open Internet
open FolkerKinzel.MimeTypes

module application =
    module _1d =
        module interleaved =
            let parityfec = MimeType.Parse "application/1d-interleaved-parityfec"

    module _3gpdash =
        module qoe =
            module report =
                let xml = MimeType.Parse "application/3gpdash-qoe-report+xml"

    module _3gpp =
        module ims =
            let xml = MimeType.Parse "application/3gpp-ims+xml"

        module mbs =
            module object =
                module manifest =
                    let json = MimeType.Parse "application/3gpp-mbs-object-manifest+json"

            module user =
                module service =
                    module descriptions =
                        let json = MimeType.Parse "application/3gpp-mbs-user-service-descriptions+json"

        module media =
            module delivery =
                module metrics =
                    module report =
                        let json = MimeType.Parse "application/3gpp-media-delivery-metrics-report+json"

    module _3gppHal =
        let json = MimeType.Parse "application/3gppHal+json"

    module _3gppHalForms =
        let json = MimeType.Parse "application/3gppHalForms+json"

    module aas =
        let zip = MimeType.Parse "application/aas+zip"

    let A2L = MimeType.Parse "application/A2L"

    module ace =
        module groupcomm =
            let cbor = MimeType.Parse "application/ace-groupcomm+cbor"

        module trl =
            let cbor = MimeType.Parse "application/ace-trl+cbor"

        let cbor = MimeType.Parse "application/ace+cbor"
        let json = MimeType.Parse "application/ace+json"

    let activemessage = MimeType.Parse "application/activemessage"

    module activity =
        let json = MimeType.Parse "application/activity+json"

    module aif =
        let cbor = MimeType.Parse "application/aif+cbor"
        let json = MimeType.Parse "application/aif+json"

    module alto =
        module cdni =
            let json = MimeType.Parse "application/alto-cdni+json"

        module cdnifilter =
            let json = MimeType.Parse "application/alto-cdnifilter+json"

        module costmap =
            let json = MimeType.Parse "application/alto-costmap+json"

        module costmapfilter =
            let json = MimeType.Parse "application/alto-costmapfilter+json"

        module directory =
            let json = MimeType.Parse "application/alto-directory+json"

        module endpointprop =
            let json = MimeType.Parse "application/alto-endpointprop+json"

        module endpointpropparams =
            let json = MimeType.Parse "application/alto-endpointpropparams+json"

        module endpointcost =
            let json = MimeType.Parse "application/alto-endpointcost+json"

        module endpointcostparams =
            let json = MimeType.Parse "application/alto-endpointcostparams+json"

        module error =
            let json = MimeType.Parse "application/alto-error+json"

        module networkmapfilter =
            let json = MimeType.Parse "application/alto-networkmapfilter+json"

        module networkmap =
            let json = MimeType.Parse "application/alto-networkmap+json"

        module propmap =
            let json = MimeType.Parse "application/alto-propmap+json"

        module propmapparams =
            let json = MimeType.Parse "application/alto-propmapparams+json"

        module tips =
            let json = MimeType.Parse "application/alto-tips+json"

        module tipsparams =
            let json = MimeType.Parse "application/alto-tipsparams+json"

        module updatestreamcontrol =
            let json = MimeType.Parse "application/alto-updatestreamcontrol+json"

        module updatestreamparams =
            let json = MimeType.Parse "application/alto-updatestreamparams+json"

    let AML = MimeType.Parse "application/AML"

    module andrew =
        let inset = MimeType.Parse "application/andrew-inset"

    let applefile = MimeType.Parse "application/applefile"

    module asyncapi =
        let json = MimeType.Parse "application/asyncapi+json"
        let yaml = MimeType.Parse "application/asyncapi+yaml"

    module at =
        let jwt = MimeType.Parse "application/at+jwt"

    let ATF = MimeType.Parse "application/ATF"
    let ATFX = MimeType.Parse "application/ATFX"

    module atom =
        let xml = MimeType.Parse "application/atom+xml"

    module atomcat =
        let xml = MimeType.Parse "application/atomcat+xml"

    module atomdeleted =
        let xml = MimeType.Parse "application/atomdeleted+xml"

    let atomicmail = MimeType.Parse "application/atomicmail"

    module atomsvc =
        let xml = MimeType.Parse "application/atomsvc+xml"

    module atsc =
        module dwd =
            let xml = MimeType.Parse "application/atsc-dwd+xml"

        module dynamic =
            module event_ =
                let message = MimeType.Parse "application/atsc-dynamic-event-message"

        module held =
            let xml = MimeType.Parse "application/atsc-held+xml"

        module rdt =
            let json = MimeType.Parse "application/atsc-rdt+json"

        module rsat =
            let xml = MimeType.Parse "application/atsc-rsat+xml"

    let ATXML = MimeType.Parse "application/ATXML"

    module auth =
        module policy =
            let xml = MimeType.Parse "application/auth-policy+xml"

    module automationml =
        module aml =
            let xml = MimeType.Parse "application/automationml-aml+xml"

        module amlx =
            let zip = MimeType.Parse "application/automationml-amlx+zip"

    module bacnet =
        module xdd =
            let zip = MimeType.Parse "application/bacnet-xdd+zip"

    module batch =
        let SMTP = MimeType.Parse "application/batch-SMTP"

    module beep =
        let xml = MimeType.Parse "application/beep+xml"

    let bufr = MimeType.Parse "application/bufr"
    let c2pa = MimeType.Parse "application/c2pa"

    module calendar =
        let json = MimeType.Parse "application/calendar+json"
        let xml = MimeType.Parse "application/calendar+xml"

    module call =
        let completion = MimeType.Parse "application/call-completion"

    module CALS =
        let _1840 = MimeType.Parse "application/CALS-1840"

    module captive =
        let json = MimeType.Parse "application/captive+json"

    module cbor =
        let seq = MimeType.Parse "application/cbor-seq"

    let cccex = MimeType.Parse "application/cccex"

    module ccmp =
        let xml = MimeType.Parse "application/ccmp+xml"

    module ccxml =
        let xml = MimeType.Parse "application/ccxml+xml"

    module cda =
        let xml = MimeType.Parse "application/cda+xml"

    module CDFX =
        let XML = MimeType.Parse "application/CDFX+XML"

    module cdmi =
        let capability = MimeType.Parse "application/cdmi-capability"
        let container = MimeType.Parse "application/cdmi-container"
        let domain = MimeType.Parse "application/cdmi-domain"
        let object = MimeType.Parse "application/cdmi-object"
        let queue = MimeType.Parse "application/cdmi-queue"

    let cdni = MimeType.Parse "application/cdni"

    module ce =
        let cbor = MimeType.Parse "application/ce+cbor"

    let CEA = MimeType.Parse "application/CEA"

    module cea =
        module _2018 =
            let xml = MimeType.Parse "application/cea-2018+xml"

    module cellml =
        let xml = MimeType.Parse "application/cellml+xml"

    let cfw = MimeType.Parse "application/cfw"

    module cid =
        module edhoc =
            module cbor =
                let seq = MimeType.Parse "application/cid-edhoc+cbor-seq"

    module city =
        module json =
            let seq = MimeType.Parse "application/city+json-seq"

    module client =
        module authentication =
            let jwt = MimeType.Parse "application/client-authentication+jwt"

    module cloudevents =
        module batch =
            let json = MimeType.Parse "application/cloudevents-batch+json"

        let json = MimeType.Parse "application/cloudevents+json"

    let clr = MimeType.Parse "application/clr"

    module clue_info =
        let xml = MimeType.Parse "application/clue_info+xml"

    module clue =
        let xml = MimeType.Parse "application/clue+xml"

    let cmcd = MimeType.Parse "application/cmcd"
    let cms = MimeType.Parse "application/cms"

    module cmw =
        let cbor = MimeType.Parse "application/cmw+cbor"
        let cose = MimeType.Parse "application/cmw+cose"
        let json = MimeType.Parse "application/cmw+json"
        let jws = MimeType.Parse "application/cmw+jws"

    module cnrp =
        let xml = MimeType.Parse "application/cnrp+xml"

    module coap =
        let eap = MimeType.Parse "application/coap-eap"

        module group =
            let json = MimeType.Parse "application/coap-group+json"

        let payload = MimeType.Parse "application/coap-payload"

    let commonground = MimeType.Parse "application/commonground"

    module concise =
        module problem =
            module details =
                let cbor = MimeType.Parse "application/concise-problem-details+cbor"

    module conference =
        module info =
            let xml = MimeType.Parse "application/conference-info+xml"

    module cpl =
        let xml = MimeType.Parse "application/cpl+xml"

    module cose =
        module c509 =
            let cbor = MimeType.Parse "application/cose-c509+cbor"

            module cert =
                let cbor = MimeType.Parse "application/cose-c509-cert+cbor"

            module crtemplate =
                let cbor = MimeType.Parse "application/cose-c509-crtemplate+cbor"

            module pem =
                let cbor = MimeType.Parse "application/cose-c509-pem+cbor"

            module pkcs10 =
                let cbor = MimeType.Parse "application/cose-c509-pkcs10+cbor"

            module privkey =
                let cbor = MimeType.Parse "application/cose-c509-privkey+cbor"

        module certhash =
            let cbor = MimeType.Parse "application/cose-certhash+cbor"

        module key =
            let set = MimeType.Parse "application/cose-key-set"

        let x509 = MimeType.Parse "application/cose-x509"

    let csrattrs = MimeType.Parse "application/csrattrs"

    module csta =
        let xml = MimeType.Parse "application/csta+xml"

    module CSTAdata =
        let xml = MimeType.Parse "application/CSTAdata+xml"

    module csvm =
        let json = MimeType.Parse "application/csvm+json"

    module cwl =
        let json = MimeType.Parse "application/cwl+json"
        let yaml = MimeType.Parse "application/cwl+yaml"

    let cwt = MimeType.Parse "application/cwt"

    module vnd =
        let cxtf = MimeType.Parse "application/vnd.cxtf"
        let cxzip = MimeType.Parse "application/vnd.cxzip"

        module _1000minds =
            module decision =
                module model =
                    let xml = MimeType.Parse "application/vnd.1000minds.decision-model+xml"

        let _1ob = MimeType.Parse "application/vnd.1ob"

        module _3gpp =
            let _5gnas = MimeType.Parse "application/vnd.3gpp.5gnas"

            module _5gsa2x =
                module local =
                    module service =
                        let information =
                            MimeType.Parse "application/vnd.3gpp.5gsa2x-local-service-information"

            module _5gsv2x =
                module local =
                    module service =
                        let information =
                            MimeType.Parse "application/vnd.3gpp.5gsv2x-local-service-information"

            module access =
                module transfer =
                    module events =
                        let xml = MimeType.Parse "application/vnd.3gpp.access-transfer-events+xml"

            module bsf =
                let xml = MimeType.Parse "application/vnd.3gpp.bsf+xml"

            module crs =
                let xml = MimeType.Parse "application/vnd.3gpp.crs+xml"

            module current =
                module location =
                    module discovery =
                        let xml = MimeType.Parse "application/vnd.3gpp.current-location-discovery+xml"

            module GMOP =
                let xml = MimeType.Parse "application/vnd.3gpp.GMOP+xml"

            let gtpc = MimeType.Parse "application/vnd.3gpp.gtpc"

            module interworking =
                let data = MimeType.Parse "application/vnd.3gpp.interworking-data"

            let lpp = MimeType.Parse "application/vnd.3gpp.lpp"

            module mc =
                module signalling =
                    let ear = MimeType.Parse "application/vnd.3gpp.mc-signalling-ear"

            module mcdata =
                module affiliation =
                    module command =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcdata-affiliation-command+xml"

                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcdata-info+xml"

                module msgstore =
                    module ctrl =
                        module request =
                            let xml = MimeType.Parse "application/vnd.3gpp.mcdata-msgstore-ctrl-request+xml"

                let payload = MimeType.Parse "application/vnd.3gpp.mcdata-payload"

                module regroup =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcdata-regroup+xml"

                module service =
                    module config =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcdata-service-config+xml"

                let signalling = MimeType.Parse "application/vnd.3gpp.mcdata-signalling"

                module ue =
                    module config =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcdata-ue-config+xml"

                module user =
                    module profile =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcdata-user-profile+xml"

            module mcptt =
                module affiliation =
                    module command =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcptt-affiliation-command+xml"

                module floor =
                    module request =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcptt-floor-request+xml"

                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcptt-info+xml"

                module location =
                    module info =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcptt-location-info+xml"

                module mbms =
                    module usage =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.mcptt-mbms-usage-info+xml"

                module regroup =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcptt-regroup+xml"

                module service =
                    module config =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcptt-service-config+xml"

                module signed =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcptt-signed+xml"

                module ue =
                    module config =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcptt-ue-config+xml"

                    module init =
                        module config =
                            let xml = MimeType.Parse "application/vnd.3gpp.mcptt-ue-init-config+xml"

                module user =
                    module profile =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcptt-user-profile+xml"

            module mcs =
                module location =
                    module user =
                        module config =
                            let xml = MimeType.Parse "application/vnd.3gpp.mcs-location-user-config+xml"

            module mcvideo =
                module affiliation =
                    module command =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-affiliation-command+xml"

                    module info =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-affiliation-info+xml"

                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-info+xml"

                module location =
                    module info =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-location-info+xml"

                module mbms =
                    module usage =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-mbms-usage-info+xml"

                module regroup =
                    let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-regroup+xml"

                module service =
                    module config =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-service-config+xml"

                module transmission =
                    module request =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-transmission-request+xml"

                module ue =
                    module config =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-ue-config+xml"

                module user =
                    module profile =
                        let xml = MimeType.Parse "application/vnd.3gpp.mcvideo-user-profile+xml"

            module mid =
                module call =
                    let xml = MimeType.Parse "application/vnd.3gpp.mid-call+xml"

            let ngap = MimeType.Parse "application/vnd.3gpp.ngap"
            let pfcp = MimeType.Parse "application/vnd.3gpp.pfcp"

            module pic =
                module bw =
                    let large = MimeType.Parse "application/vnd.3gpp.pic-bw-large"
                    let small = MimeType.Parse "application/vnd.3gpp.pic-bw-small"
                    let var = MimeType.Parse "application/vnd.3gpp.pic-bw-var"

            module pinapp =
                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.pinapp-info+xml"

            module prose =
                module pc3a =
                    let xml = MimeType.Parse "application/vnd.3gpp-prose-pc3a+xml"

                module pc3ach =
                    let xml = MimeType.Parse "application/vnd.3gpp-prose-pc3ach+xml"

                module pc3ch =
                    let xml = MimeType.Parse "application/vnd.3gpp-prose-pc3ch+xml"

                module pc8 =
                    let xml = MimeType.Parse "application/vnd.3gpp-prose-pc8+xml"

                let xml = MimeType.Parse "application/vnd.3gpp-prose+xml"

            let s1ap = MimeType.Parse "application/vnd.3gpp.s1ap"

            module seal =
                module app =
                    module comm =
                        module requirements =
                            module info =
                                let xml = MimeType.Parse "application/vnd.3gpp.seal-app-comm-requirements-info+xml"

                module data =
                    module delivery =
                        module info =
                            let cbor = MimeType.Parse "application/vnd.3gpp.seal-data-delivery-info+cbor"
                            let xml = MimeType.Parse "application/vnd.3gpp.seal-data-delivery-info+xml"

                module group =
                    module doc =
                        let xml = MimeType.Parse "application/vnd.3gpp.seal-group-doc+xml"

                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.seal-info+xml"

                module location =
                    module info =
                        let cbor = MimeType.Parse "application/vnd.3gpp.seal-location-info+cbor"
                        let xml = MimeType.Parse "application/vnd.3gpp.seal-location-info+xml"

                module mbms =
                    module usage =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.seal-mbms-usage-info+xml"

                module mbs =
                    module usage =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.seal-mbs-usage-info+xml"

                module network =
                    module QoS =
                        module management =
                            module info =
                                let xml = MimeType.Parse "application/vnd.3gpp.seal-network-QoS-management-info+xml"

                    module resource =
                        module info =
                            let cbor = MimeType.Parse "application/vnd.3gpp.seal-network-resource-info+cbor"

                module store =
                    module forward =
                        module events =
                            module info =
                                let xml = MimeType.Parse "application/vnd.3gpp.seal-store-forward-events-info+xml"

                module ue =
                    module config =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.seal-ue-config-info+xml"

                module unicast =
                    module info =
                        let xml = MimeType.Parse "application/vnd.3gpp.seal-unicast-info+xml"

                module user =
                    module profile =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.seal-user-profile-info+xml"

            module sms =
                let xml = MimeType.Parse "application/vnd.3gpp.sms+xml"

            module srvcc =
                module ext =
                    let xml = MimeType.Parse "application/vnd.3gpp.srvcc-ext+xml"

            module SRVCC =
                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.SRVCC-info+xml"

            module state =
                module and_ =
                    module event_ =
                        module info =
                            let xml = MimeType.Parse "application/vnd.3gpp.state-and-event-info+xml"

            module ussd =
                let xml = MimeType.Parse "application/vnd.3gpp.ussd+xml"

            module vae =
                module info =
                    let xml = MimeType.Parse "application/vnd.3gpp.vae-info+xml"

            module v2x =
                module local =
                    module service =
                        let information =
                            MimeType.Parse "application/vnd.3gpp-v2x-local-service-information"

        module _3gpp2 =
            module bcmcsinfo =
                let xml = MimeType.Parse "application/vnd.3gpp2.bcmcsinfo+xml"

            let sms = MimeType.Parse "application/vnd.3gpp2.sms"
            let tcap = MimeType.Parse "application/vnd.3gpp2.tcap"

        module _3lightssoftware =
            let imagescal = MimeType.Parse "application/vnd.3lightssoftware.imagescal"

        module _3M =
            module Post =
                module it =
                    let Notes = MimeType.Parse "application/vnd.3M.Post-it-Notes"

        module abdalsecuritygroup =
            let lockbox = MimeType.Parse "application/vnd.abdalsecuritygroup.lockbox"

        module accpac =
            module simply =
                let aso = MimeType.Parse "application/vnd.accpac.simply.aso"
                let imp = MimeType.Parse "application/vnd.accpac.simply.imp"

        module acm =
            module addressxfer =
                let json = MimeType.Parse "application/vnd.acm.addressxfer+json"

            module chatbot =
                let json = MimeType.Parse "application/vnd.acm.chatbot+json"

        let acucobol = MimeType.Parse "application/vnd.acucobol"
        let acucorp = MimeType.Parse "application/vnd.acucorp"

        module adobe =
            module flash =
                let movie = MimeType.Parse "application/vnd.adobe.flash.movie"

            module formscentral =
                let fcdt = MimeType.Parse "application/vnd.adobe.formscentral.fcdt"

            let fxp = MimeType.Parse "application/vnd.adobe.fxp"

            module partial =
                let upload = MimeType.Parse "application/vnd.adobe.partial-upload"

            module xdp =
                let xml = MimeType.Parse "application/vnd.adobe.xdp+xml"

        module aep =
            let zip = MimeType.Parse "application/vnd.aep+zip"

        module aether =
            let imp = MimeType.Parse "application/vnd.aether.imp"

        module afpc =
            module afplinedata =
                let pagedef = MimeType.Parse "application/vnd.afpc.afplinedata-pagedef"

            module cmoca =
                let cmresource = MimeType.Parse "application/vnd.afpc.cmoca-cmresource"

            module foca =
                let charset = MimeType.Parse "application/vnd.afpc.foca-charset"
                let codedfont = MimeType.Parse "application/vnd.afpc.foca-codedfont"
                let codepage = MimeType.Parse "application/vnd.afpc.foca-codepage"

            module modca =
                let cmtable = MimeType.Parse "application/vnd.afpc.modca-cmtable"
                let formdef = MimeType.Parse "application/vnd.afpc.modca-formdef"
                let mediummap = MimeType.Parse "application/vnd.afpc.modca-mediummap"
                let objectcontainer = MimeType.Parse "application/vnd.afpc.modca-objectcontainer"
                let overlay = MimeType.Parse "application/vnd.afpc.modca-overlay"
                let pagesegment = MimeType.Parse "application/vnd.afpc.modca-pagesegment"

        let age = MimeType.Parse "application/vnd.age"

        module agentmug =
            module agent =
                let json = MimeType.Parse "application/vnd.agentmug.agent+json"

        module agtp =
            module identity =
                let json = MimeType.Parse "application/vnd.agtp.identity+json"
                let yaml = MimeType.Parse "application/vnd.agtp.identity+yaml"

        module ah =
            let barcode = MimeType.Parse "application/vnd.ah-barcode"

        module ahead =
            let space = MimeType.Parse "application/vnd.ahead.space"

        let aia = MimeType.Parse "application/vnd.aia"

        module airzip =
            module filesecure =
                let azf = MimeType.Parse "application/vnd.airzip.filesecure.azf"
                let azs = MimeType.Parse "application/vnd.airzip.filesecure.azs"

        module amadeus =
            let json = MimeType.Parse "application/vnd.amadeus+json"

        module amazon =
            module mobi8 =
                let ebook = MimeType.Parse "application/vnd.amazon.mobi8-ebook"

        module americandynamics =
            let acc = MimeType.Parse "application/vnd.americandynamics.acc"

        module amiga =
            let ami = MimeType.Parse "application/vnd.amiga.ami"

        module amundsen =
            module maze =
                let xml = MimeType.Parse "application/vnd.amundsen.maze+xml"

        module android =
            let ota = MimeType.Parse "application/vnd.android.ota"

        let anki = MimeType.Parse "application/vnd.anki"

        module anser =
            module web =
                module certificate =
                    module issue =
                        let initiation =
                            MimeType.Parse "application/vnd.anser-web-certificate-issue-initiation"

        module antix =
            module game =
                let component_ = MimeType.Parse "application/vnd.antix.game-component"

        module apache =
            module arrow =
                let file = MimeType.Parse "application/vnd.apache.arrow.file"
                let stream = MimeType.Parse "application/vnd.apache.arrow.stream"

            let parquet = MimeType.Parse "application/vnd.apache.parquet"

            module thrift =
                let binary = MimeType.Parse "application/vnd.apache.thrift.binary"
                let compact = MimeType.Parse "application/vnd.apache.thrift.compact"
                let json = MimeType.Parse "application/vnd.apache.thrift.json"

        let apexlang = MimeType.Parse "application/vnd.apexlang"

        module api =
            let json = MimeType.Parse "application/vnd.api+json"

        module aplextor =
            module warrp =
                let json = MimeType.Parse "application/vnd.aplextor.warrp+json"

        module apothekende =
            module reservation =
                let json = MimeType.Parse "application/vnd.apothekende.reservation+json"

        module apple =
            module installer =
                let xml = MimeType.Parse "application/vnd.apple.installer+xml"

            let keynote = MimeType.Parse "application/vnd.apple.keynote"
            let mpegurl = MimeType.Parse "application/vnd.apple.mpegurl"
            let numbers = MimeType.Parse "application/vnd.apple.numbers"
            let pages = MimeType.Parse "application/vnd.apple.pages"

            module steering =
                let list = MimeType.Parse "application/vnd.apple.steering-list"

        module arastra =
            let swi = MimeType.Parse "application/vnd.arastra.swi"

        module aristanetworks =
            let swi = MimeType.Parse "application/vnd.aristanetworks.swi"

        module artisan =
            let json = MimeType.Parse "application/vnd.artisan+json"

        let artsquare = MimeType.Parse "application/vnd.artsquare"

        module as207960 =
            module vas =
                module config =
                    let jer = MimeType.Parse "application/vnd.as207960.vas.config+jer"
                    let uper = MimeType.Parse "application/vnd.as207960.vas.config+uper"

                module tap =
                    let jer = MimeType.Parse "application/vnd.as207960.vas.tap+jer"
                    let uper = MimeType.Parse "application/vnd.as207960.vas.tap+uper"

        module astraea =
            module software =
                let iota = MimeType.Parse "application/vnd.astraea-software.iota"

        let audiograph = MimeType.Parse "application/vnd.audiograph"

        module aumtrix =
            let aum = MimeType.Parse "application/vnd.aumtrix.aum"

        let autopackage = MimeType.Parse "application/vnd.autopackage"

        module avalon =
            let json = MimeType.Parse "application/vnd.avalon+json"

        module avistar =
            let xml = MimeType.Parse "application/vnd.avistar+xml"

        module balsamiq =
            module bmml =
                let xml = MimeType.Parse "application/vnd.balsamiq.bmml+xml"

            let bmpr = MimeType.Parse "application/vnd.balsamiq.bmpr"

        module banana =
            let accounting = MimeType.Parse "application/vnd.banana-accounting"

        module bbf =
            module usp =
                let error = MimeType.Parse "application/vnd.bbf.usp.error"

                module msg =
                    let json = MimeType.Parse "application/vnd.bbf.usp.msg+json"

        module bekitzur =
            module stech =
                let json = MimeType.Parse "application/vnd.bekitzur-stech+json"

        module belightsoft =
            module lhzd =
                let zip = MimeType.Parse "application/vnd.belightsoft.lhzd+zip"

            module lhzl =
                let zip = MimeType.Parse "application/vnd.belightsoft.lhzl+zip"

        module bint =
            module med =
                let content = MimeType.Parse "application/vnd.bint.med-content"

        module biopax =
            module rdf =
                let xml = MimeType.Parse "application/vnd.biopax.rdf+xml"

        module blink =
            module idb =
                module value =
                    let wrapper = MimeType.Parse "application/vnd.blink-idb-value-wrapper"

        module blockfact =
            let facts = MimeType.Parse "application/vnd.blockfact.facts"

        module blueice =
            let multipass = MimeType.Parse "application/vnd.blueice.multipass"

        module bluetooth =
            module ep =
                let oob = MimeType.Parse "application/vnd.bluetooth.ep.oob"

            module le =
                let oob = MimeType.Parse "application/vnd.bluetooth.le.oob"

        let bmi = MimeType.Parse "application/vnd.bmi"
        let bpf = MimeType.Parse "application/vnd.bpf"
        let bpf3 = MimeType.Parse "application/vnd.bpf3"
        let businessobjects = MimeType.Parse "application/vnd.businessobjects"

        module byu =
            module uapi =
                let json = MimeType.Parse "application/vnd.byu.uapi+json"

        let bzip3 = MimeType.Parse "application/vnd.bzip3"

        module c3voc =
            module schedule =
                let xml = MimeType.Parse "application/vnd.c3voc.schedule+xml"

        module cab =
            let jscript = MimeType.Parse "application/vnd.cab-jscript"

        module canon =
            let cpdl = MimeType.Parse "application/vnd.canon-cpdl"
            let lips = MimeType.Parse "application/vnd.canon-lips"

        module capasystems =
            module pg =
                let json = MimeType.Parse "application/vnd.capasystems-pg+json"

        let cel = MimeType.Parse "application/vnd.cel"

        module cendio =
            module thinlinc =
                let clientconf = MimeType.Parse "application/vnd.cendio.thinlinc.clientconf"

        module century =
            module systems =
                let tcp_stream = MimeType.Parse "application/vnd.century-systems.tcp_stream"

        module chemdraw =
            let xml = MimeType.Parse "application/vnd.chemdraw+xml"

        module chess =
            let pgn = MimeType.Parse "application/vnd.chess-pgn"

        module chipnuts =
            module karaoke =
                let mmd = MimeType.Parse "application/vnd.chipnuts.karaoke-mmd"

        let ciedi = MimeType.Parse "application/vnd.ciedi"
        let cinderella = MimeType.Parse "application/vnd.cinderella"

        module cirpack =
            module isdn =
                let ext = MimeType.Parse "application/vnd.cirpack.isdn-ext"

        module citationstyles =
            module style =
                let xml = MimeType.Parse "application/vnd.citationstyles.style+xml"

        let claymore = MimeType.Parse "application/vnd.claymore"

        module cloanto =
            let rp9 = MimeType.Parse "application/vnd.cloanto.rp9"

        module clonk =
            let c4group = MimeType.Parse "application/vnd.clonk.c4group"

        module cluetrust =
            module cartomobile =
                module config =
                    let pkg = MimeType.Parse "application/vnd.cluetrust.cartomobile-config-pkg"

        module cmmf =
            module configuration =
                module information =
                    let json = MimeType.Parse "application/vnd.cmmf-configuration-information+json"

            module efd =
                let xml = MimeType.Parse "application/vnd.cmmf-efd+xml"

            module encoder =
                module configuration =
                    let json = MimeType.Parse "application/vnd.cmmf-encoder-configuration+json"

        module cncf =
            module helm =
                module chart =
                    module content =
                        module v1 =
                            module tar =
                                let gzip = MimeType.Parse "application/vnd.cncf.helm.chart.content.v1.tar+gzip"

                    module provenance =
                        module v1 =
                            let prov = MimeType.Parse "application/vnd.cncf.helm.chart.provenance.v1.prov"

                module config =
                    module v1 =
                        let json = MimeType.Parse "application/vnd.cncf.helm.config.v1+json"

        let coffeescript = MimeType.Parse "application/vnd.coffeescript"

        module collabio =
            module xodocuments =
                module document =
                    let template =
                        MimeType.Parse "application/vnd.collabio.xodocuments.document-template"

                module presentation =
                    let template =
                        MimeType.Parse "application/vnd.collabio.xodocuments.presentation-template"

                module spreadsheet =
                    let template =
                        MimeType.Parse "application/vnd.collabio.xodocuments.spreadsheet-template"

        module collection =
            module doc =
                let json = MimeType.Parse "application/vnd.collection.doc+json"

            let json = MimeType.Parse "application/vnd.collection+json"

            module next =
                let json = MimeType.Parse "application/vnd.collection.next+json"

        module comicbook =
            let rar = MimeType.Parse "application/vnd.comicbook-rar"
            let zip = MimeType.Parse "application/vnd.comicbook+zip"

        module commerce =
            let battelle = MimeType.Parse "application/vnd.commerce-battelle"

        let commonspace = MimeType.Parse "application/vnd.commonspace"

        module coreos =
            module ignition =
                let json = MimeType.Parse "application/vnd.coreos.ignition+json"

        let cosmocaller = MimeType.Parse "application/vnd.cosmocaller"

        module contact =
            let cmsg = MimeType.Parse "application/vnd.contact.cmsg"

        module crick =
            module clicker =
                let keyboard = MimeType.Parse "application/vnd.crick.clicker.keyboard"
                let palette = MimeType.Parse "application/vnd.crick.clicker.palette"
                let template = MimeType.Parse "application/vnd.crick.clicker.template"
                let wordbank = MimeType.Parse "application/vnd.crick.clicker.wordbank"

        module criticaltools =
            module wbs =
                let xml = MimeType.Parse "application/vnd.criticaltools.wbs+xml"

        module cryptii =
            module pipe =
                let json = MimeType.Parse "application/vnd.cryptii.pipe+json"

        module crypto =
            module shade =
                let file = MimeType.Parse "application/vnd.crypto-shade-file"

        module cryptomator =
            let encrypted = MimeType.Parse "application/vnd.cryptomator.encrypted"
            let vault = MimeType.Parse "application/vnd.cryptomator.vault"

        module ctc =
            let posml = MimeType.Parse "application/vnd.ctc-posml"

        module ctct =
            module ws =
                let xml = MimeType.Parse "application/vnd.ctct.ws+xml"

        module cups =
            let pdf = MimeType.Parse "application/vnd.cups-pdf"
            let postscript = MimeType.Parse "application/vnd.cups-postscript"
            let ppd = MimeType.Parse "application/vnd.cups-ppd"
            let raster = MimeType.Parse "application/vnd.cups-raster"
            let raw = MimeType.Parse "application/vnd.cups-raw"

        let curl = MimeType.Parse "application/vnd.curl"

        module cyan =
            module dean =
                module root =
                    let xml = MimeType.Parse "application/vnd.cyan.dean.root+xml"

        let cybank = MimeType.Parse "application/vnd.cybank"

        module cyclonedx =
            let json = MimeType.Parse "application/vnd.cyclonedx+json"
            let xml = MimeType.Parse "application/vnd.cyclonedx+xml"

        module d2l =
            module coursepackage1p0 =
                let zip = MimeType.Parse "application/vnd.d2l.coursepackage1p0+zip"

        module d3m =
            let dataset = MimeType.Parse "application/vnd.d3m-dataset"
            let problem = MimeType.Parse "application/vnd.d3m-problem"

        let dart = MimeType.Parse "application/vnd.dart"

        module data =
            module vision =
                let rdz = MimeType.Parse "application/vnd.data-vision.rdz"

        let datalog = MimeType.Parse "application/vnd.datalog"

        module datapackage =
            let json = MimeType.Parse "application/vnd.datapackage+json"

        module dataresource =
            let json = MimeType.Parse "application/vnd.dataresource+json"

        let dbf = MimeType.Parse "application/vnd.dbf"

        module dcmp =
            let xml = MimeType.Parse "application/vnd.dcmp+xml"

        module debian =
            module binary =
                let package = MimeType.Parse "application/vnd.debian.binary-package"

        module dece =
            let data = MimeType.Parse "application/vnd.dece.data"

            module ttml =
                let xml = MimeType.Parse "application/vnd.dece.ttml+xml"

            let unspecified = MimeType.Parse "application/vnd.dece.unspecified"
            let zip = MimeType.Parse "application/vnd.dece.zip"

        module deckyard =
            let deck = MimeType.Parse "application/vnd.deckyard.deck"

        module denovo =
            module fcselayout =
                let link = MimeType.Parse "application/vnd.denovo.fcselayout-link"

        module desmume =
            let movie = MimeType.Parse "application/vnd.desmume.movie"

        module deut =
            let json = MimeType.Parse "application/vnd.deut+json"

        let dgl = MimeType.Parse "application/vnd.dgl"

        module digitalstack =
            module document =
                let zip = MimeType.Parse "application/vnd.digitalstack.document+zip"

        module dir =
            module bi =
                module plate =
                    module dl =
                        let nosuffix = MimeType.Parse "application/vnd.dir-bi.plate-dl-nosuffix"

        module dm =
            module delegation =
                let xml = MimeType.Parse "application/vnd.dm.delegation+xml"

        let dna = MimeType.Parse "application/vnd.dna"

        module document =
            let json = MimeType.Parse "application/vnd.document+json"

        module dolby =
            module mobile =
                let _1 = MimeType.Parse "application/vnd.dolby.mobile.1"
                let _2 = MimeType.Parse "application/vnd.dolby.mobile.2"

        module doremir =
            module scorecloud =
                module binary =
                    let document = MimeType.Parse "application/vnd.doremir.scorecloud-binary-document"

        let dpgraph = MimeType.Parse "application/vnd.dpgraph"
        let dreamfactory = MimeType.Parse "application/vnd.dreamfactory"

        module drive =
            let json = MimeType.Parse "application/vnd.drive+json"

        module dtg =
            module local =
                let flash = MimeType.Parse "application/vnd.dtg.local.flash"
                let html = MimeType.Parse "application/vnd.dtg.local.html"

        module dvb =
            let ait = MimeType.Parse "application/vnd.dvb.ait"

            module dash =
                module playlist =
                    let xml = MimeType.Parse "application/vnd.dvb.dash-playlist+xml"

            module dvbisl =
                let xml = MimeType.Parse "application/vnd.dvb.dvbisl+xml"

            let dvbj = MimeType.Parse "application/vnd.dvb.dvbj"
            let esgcontainer = MimeType.Parse "application/vnd.dvb.esgcontainer"
            let ipdcdftnotifaccess = MimeType.Parse "application/vnd.dvb.ipdcdftnotifaccess"
            let ipdcesgaccess = MimeType.Parse "application/vnd.dvb.ipdcesgaccess"
            let ipdcesgaccess2 = MimeType.Parse "application/vnd.dvb.ipdcesgaccess2"
            let ipdcesgpdd = MimeType.Parse "application/vnd.dvb.ipdcesgpdd"
            let ipdcroaming = MimeType.Parse "application/vnd.dvb.ipdcroaming"

            module iptv =
                module alfec =
                    let base_ = MimeType.Parse "application/vnd.dvb.iptv.alfec-base"
                    let enhancement = MimeType.Parse "application/vnd.dvb.iptv.alfec-enhancement"

            module notif =
                module aggregate =
                    module root =
                        let xml = MimeType.Parse "application/vnd.dvb.notif-aggregate-root+xml"

                module container =
                    let xml = MimeType.Parse "application/vnd.dvb.notif-container+xml"

                module generic =
                    let xml = MimeType.Parse "application/vnd.dvb.notif-generic+xml"

                module ia =
                    module msglist =
                        let xml = MimeType.Parse "application/vnd.dvb.notif-ia-msglist+xml"

                    module registration =
                        module request =
                            let xml = MimeType.Parse "application/vnd.dvb.notif-ia-registration-request+xml"

                        module response =
                            let xml = MimeType.Parse "application/vnd.dvb.notif-ia-registration-response+xml"

                module init =
                    let xml = MimeType.Parse "application/vnd.dvb.notif-init+xml"

            let pfr = MimeType.Parse "application/vnd.dvb.pfr"
            let service = MimeType.Parse "application/vnd.dvb.service"

        let dxr = MimeType.Parse "application/vnd.dxr"
        let dynageo = MimeType.Parse "application/vnd.dynageo"
        let dzr = MimeType.Parse "application/vnd.dzr"

        module easykaraoke =
            let cdgdownload = MimeType.Parse "application/vnd.easykaraoke.cdgdownload"

        module ecip =
            let rlp = MimeType.Parse "application/vnd.ecip.rlp"

        module edulith =
            module edux =
                let json = MimeType.Parse "application/vnd.edulith.edux+json"

        module ecdis =
            let update = MimeType.Parse "application/vnd.ecdis-update"

        module eclipse =
            module ditto =
                let json = MimeType.Parse "application/vnd.eclipse.ditto+json"

        module ecowin =
            let chart = MimeType.Parse "application/vnd.ecowin.chart"
            let filerequest = MimeType.Parse "application/vnd.ecowin.filerequest"
            let fileupdate = MimeType.Parse "application/vnd.ecowin.fileupdate"
            let series = MimeType.Parse "application/vnd.ecowin.series"
            let seriesrequest = MimeType.Parse "application/vnd.ecowin.seriesrequest"
            let seriesupdate = MimeType.Parse "application/vnd.ecowin.seriesupdate"

        module efi =
            let img = MimeType.Parse "application/vnd.efi.img"
            let iso = MimeType.Parse "application/vnd.efi.iso"

        module eln =
            let zip = MimeType.Parse "application/vnd.eln+zip"

        module emclient =
            module accessrequest =
                let xml = MimeType.Parse "application/vnd.emclient.accessrequest+xml"

        let enliven = MimeType.Parse "application/vnd.enliven"

        module enphase =
            let envoy = MimeType.Parse "application/vnd.enphase.envoy"

        module eprints =
            module data =
                let xml = MimeType.Parse "application/vnd.eprints.data+xml"

        module epson =
            let esf = MimeType.Parse "application/vnd.epson.esf"
            let msf = MimeType.Parse "application/vnd.epson.msf"
            let quickanime = MimeType.Parse "application/vnd.epson.quickanime"
            let salt = MimeType.Parse "application/vnd.epson.salt"
            let ssf = MimeType.Parse "application/vnd.epson.ssf"

        module ericsson =
            let quickcall = MimeType.Parse "application/vnd.ericsson.quickcall"

        let erofs = MimeType.Parse "application/vnd.erofs"

        module espass =
            module espass =
                let zip = MimeType.Parse "application/vnd.espass-espass+zip"

        module eszigno3 =
            let xml = MimeType.Parse "application/vnd.eszigno3+xml"

        module etsi =
            module aoc =
                let xml = MimeType.Parse "application/vnd.etsi.aoc+xml"

            module asic =
                module s =
                    let zip = MimeType.Parse "application/vnd.etsi.asic-s+zip"

                module e =
                    let zip = MimeType.Parse "application/vnd.etsi.asic-e+zip"

            module cug =
                let xml = MimeType.Parse "application/vnd.etsi.cug+xml"

            module iptvcommand =
                let xml = MimeType.Parse "application/vnd.etsi.iptvcommand+xml"

            module iptvdiscovery =
                let xml = MimeType.Parse "application/vnd.etsi.iptvdiscovery+xml"

            module iptvprofile =
                let xml = MimeType.Parse "application/vnd.etsi.iptvprofile+xml"

            module iptvsad =
                module bc =
                    let xml = MimeType.Parse "application/vnd.etsi.iptvsad-bc+xml"

                module cod =
                    let xml = MimeType.Parse "application/vnd.etsi.iptvsad-cod+xml"

                module npvr =
                    let xml = MimeType.Parse "application/vnd.etsi.iptvsad-npvr+xml"

            module iptvservice =
                let xml = MimeType.Parse "application/vnd.etsi.iptvservice+xml"

            module iptvsync =
                let xml = MimeType.Parse "application/vnd.etsi.iptvsync+xml"

            module iptvueprofile =
                let xml = MimeType.Parse "application/vnd.etsi.iptvueprofile+xml"

            module mcid =
                let xml = MimeType.Parse "application/vnd.etsi.mcid+xml"

            let mheg5 = MimeType.Parse "application/vnd.etsi.mheg5"

            module overload =
                module control =
                    module policy =
                        module dataset =
                            let xml = MimeType.Parse "application/vnd.etsi.overload-control-policy-dataset+xml"

            module pstn =
                let xml = MimeType.Parse "application/vnd.etsi.pstn+xml"

            module sci =
                let xml = MimeType.Parse "application/vnd.etsi.sci+xml"

            module simservs =
                let xml = MimeType.Parse "application/vnd.etsi.simservs+xml"

            module timestamp =
                let token = MimeType.Parse "application/vnd.etsi.timestamp-token"

            module tsl =
                let xml = MimeType.Parse "application/vnd.etsi.tsl+xml"
                let der = MimeType.Parse "application/vnd.etsi.tsl.der"

        module eu =
            module kasparian =
                module car =
                    let json = MimeType.Parse "application/vnd.eu.kasparian.car+json"

        module eudora =
            let data = MimeType.Parse "application/vnd.eudora.data"

        module evolv =
            module ecig =
                let profile = MimeType.Parse "application/vnd.evolv.ecig.profile"
                let settings = MimeType.Parse "application/vnd.evolv.ecig.settings"
                let theme = MimeType.Parse "application/vnd.evolv.ecig.theme"

        module excelano =
            module slipcase =
                let zip = MimeType.Parse "application/vnd.excelano.slipcase+zip"

        module exstream =
            module empower =
                let zip = MimeType.Parse "application/vnd.exstream-empower+zip"

            let package = MimeType.Parse "application/vnd.exstream-package"

        module ezpix =
            let album = MimeType.Parse "application/vnd.ezpix-album"
            let package = MimeType.Parse "application/vnd.ezpix-package"

        module f =
            module secure =
                let mobile = MimeType.Parse "application/vnd.f-secure.mobile"

        module faf =
            let yaml = MimeType.Parse "application/vnd.faf+yaml"

        module fafa =
            let yaml = MimeType.Parse "application/vnd.fafa+yaml"

        module fafm =
            let yaml = MimeType.Parse "application/vnd.fafm+yaml"

        module fastcopy =
            module disk =
                let image = MimeType.Parse "application/vnd.fastcopy-disk-image"

        module familysearch =
            module gedcom =
                let zip = MimeType.Parse "application/vnd.familysearch.gedcom+zip"

        module fdsn =
            let mseed = MimeType.Parse "application/vnd.fdsn.mseed"
            let seed = MimeType.Parse "application/vnd.fdsn.seed"

            module stationxml =
                let xml = MimeType.Parse "application/vnd.fdsn.stationxml+xml"

        let ffsns = MimeType.Parse "application/vnd.ffsns"
        let fgb = MimeType.Parse "application/vnd.fgb"

        module ficlab =
            module flb =
                let zip = MimeType.Parse "application/vnd.ficlab.flb+zip"

        module fiduswriter =
            module book =
                let zip = MimeType.Parse "application/vnd.fiduswriter.book+zip"

            module template =
                let zip = MimeType.Parse "application/vnd.fiduswriter.template+zip"

            let zip = MimeType.Parse "application/vnd.fiduswriter+zip"

        module filmit =
            let zfc = MimeType.Parse "application/vnd.filmit.zfc"

        let fints = MimeType.Parse "application/vnd.fints"

        module firemonkeys =
            let cloudcell = MimeType.Parse "application/vnd.firemonkeys.cloudcell"

        let FloGraphIt = MimeType.Parse "application/vnd.FloGraphIt"

        module fluxtime =
            let clip = MimeType.Parse "application/vnd.fluxtime.clip"

        module font =
            module fontforge =
                let sfd = MimeType.Parse "application/vnd.font-fontforge-sfd"

        module foritech =
            let container = MimeType.Parse "application/vnd.foritech.container"

        let framemaker = MimeType.Parse "application/vnd.framemaker"

        module freelog =
            let comic = MimeType.Parse "application/vnd.freelog.comic"

        module frogans =
            let fnc = MimeType.Parse "application/vnd.frogans.fnc"
            let ltf = MimeType.Parse "application/vnd.frogans.ltf"

        module fsc =
            let weblaunch = MimeType.Parse "application/vnd.fsc.weblaunch"

        module fujifilm =
            module fb =
                module docuworks =
                    let binder = MimeType.Parse "application/vnd.fujifilm.fb.docuworks.binder"
                    let container = MimeType.Parse "application/vnd.fujifilm.fb.docuworks.container"

                module jfi =
                    let xml = MimeType.Parse "application/vnd.fujifilm.fb.jfi+xml"

        module fujitsu =
            let oasys = MimeType.Parse "application/vnd.fujitsu.oasys"
            let oasys2 = MimeType.Parse "application/vnd.fujitsu.oasys2"
            let oasys3 = MimeType.Parse "application/vnd.fujitsu.oasys3"
            let oasysgp = MimeType.Parse "application/vnd.fujitsu.oasysgp"
            let oasysprs = MimeType.Parse "application/vnd.fujitsu.oasysprs"

        module fujixerox =
            let ART4 = MimeType.Parse "application/vnd.fujixerox.ART4"

            module ART =
                let EX = MimeType.Parse "application/vnd.fujixerox.ART-EX"

            let ddd = MimeType.Parse "application/vnd.fujixerox.ddd"

            module docuworks =
                let binder = MimeType.Parse "application/vnd.fujixerox.docuworks.binder"
                let container = MimeType.Parse "application/vnd.fujixerox.docuworks.container"

            let HBPL = MimeType.Parse "application/vnd.fujixerox.HBPL"

        module fut =
            let misnet = MimeType.Parse "application/vnd.fut-misnet"

        module futoin =
            let cbor = MimeType.Parse "application/vnd.futoin+cbor"
            let json = MimeType.Parse "application/vnd.futoin+json"

        let fuzzysheet = MimeType.Parse "application/vnd.fuzzysheet"

        module g3pix =
            let g3fc = MimeType.Parse "application/vnd.g3pix.g3fc"

        module ga4gh =
            module passport =
                let jwt = MimeType.Parse "application/vnd.ga4gh.passport+jwt"

        module genomatix =
            let tuxedo = MimeType.Parse "application/vnd.genomatix.tuxedo"

        let genozip = MimeType.Parse "application/vnd.genozip"

        module gentics =
            module grd =
                let json = MimeType.Parse "application/vnd.gentics.grd+json"

        module gentoo =
            module catmetadata =
                let xml = MimeType.Parse "application/vnd.gentoo.catmetadata+xml"

            let ebuild = MimeType.Parse "application/vnd.gentoo.ebuild"
            let eclass = MimeType.Parse "application/vnd.gentoo.eclass"
            let gpkg = MimeType.Parse "application/vnd.gentoo.gpkg"
            let manifest = MimeType.Parse "application/vnd.gentoo.manifest"
            let xpak = MimeType.Parse "application/vnd.gentoo.xpak"

            module pkgmetadata =
                let xml = MimeType.Parse "application/vnd.gentoo.pkgmetadata+xml"

        module geo =
            let json = MimeType.Parse "application/vnd.geo+json"

        module geocube =
            let xml = MimeType.Parse "application/vnd.geocube+xml"

        module geogebra =
            let file = MimeType.Parse "application/vnd.geogebra.file"
            let pinboard = MimeType.Parse "application/vnd.geogebra.pinboard"
            let slides = MimeType.Parse "application/vnd.geogebra.slides"
            let tool = MimeType.Parse "application/vnd.geogebra.tool"

        module geometry =
            let explorer = MimeType.Parse "application/vnd.geometry-explorer"

        let geonext = MimeType.Parse "application/vnd.geonext"
        let geoplan = MimeType.Parse "application/vnd.geoplan"
        let geospace = MimeType.Parse "application/vnd.geospace"
        let gerber = MimeType.Parse "application/vnd.gerber"

        module globalplatform =
            module card =
                module content =
                    module mgt =
                        let response =
                            MimeType.Parse "application/vnd.globalplatform.card-content-mgt-response"

        let gmx = MimeType.Parse "application/vnd.gmx"

        module gnu =
            module taler =
                module exchange =
                    let json = MimeType.Parse "application/vnd.gnu.taler.exchange+json"

                module merchant =
                    let json = MimeType.Parse "application/vnd.gnu.taler.merchant+json"

        module google =
            module earth =
                module kml =
                    let xml = MimeType.Parse "application/vnd.google-earth.kml+xml"

                let kmz = MimeType.Parse "application/vnd.google-earth.kmz"

        module gov =
            module sk =
                module e =
                    module form =
                        let xml = MimeType.Parse "application/vnd.gov.sk.e-form+xml"
                        let zip = MimeType.Parse "application/vnd.gov.sk.e-form+zip"

                module xmldatacontainer =
                    let xml = MimeType.Parse "application/vnd.gov.sk.xmldatacontainer+xml"

        let gp3 = MimeType.Parse "application/vnd.gp3"

        module gpxsee =
            module map =
                let xml = MimeType.Parse "application/vnd.gpxsee.map+xml"

        let grafeq = MimeType.Parse "application/vnd.grafeq"
        let gridmp = MimeType.Parse "application/vnd.gridmp"

        module groove =
            let account = MimeType.Parse "application/vnd.groove-account"
            let help = MimeType.Parse "application/vnd.groove-help"

            module identity =
                let message = MimeType.Parse "application/vnd.groove-identity-message"

            let injector = MimeType.Parse "application/vnd.groove-injector"

            module tool =
                let message = MimeType.Parse "application/vnd.groove-tool-message"
                let template = MimeType.Parse "application/vnd.groove-tool-template"

            let vcard = MimeType.Parse "application/vnd.groove-vcard"

        module hal =
            let json = MimeType.Parse "application/vnd.hal+json"
            let xml = MimeType.Parse "application/vnd.hal+xml"

        module HandHeld =
            module Entertainment =
                let xml = MimeType.Parse "application/vnd.HandHeld-Entertainment+xml"

        let hbci = MimeType.Parse "application/vnd.hbci"

        module hc =
            let json = MimeType.Parse "application/vnd.hc+json"

        module hcl =
            let bireports = MimeType.Parse "application/vnd.hcl-bireports"

        module hdfgroup =
            let hdf4 = MimeType.Parse "application/vnd.hdfgroup.hdf4"
            let hdf5 = MimeType.Parse "application/vnd.hdfgroup.hdf5"

        let hdt = MimeType.Parse "application/vnd.hdt"

        module heroku =
            let json = MimeType.Parse "application/vnd.heroku+json"

        module hhe =
            module lesson =
                let player = MimeType.Parse "application/vnd.hhe.lesson-player"

        module hp =
            let HPGL = MimeType.Parse "application/vnd.hp-HPGL"
            let hpid = MimeType.Parse "application/vnd.hp-hpid"
            let hps = MimeType.Parse "application/vnd.hp-hps"
            let jlyt = MimeType.Parse "application/vnd.hp-jlyt"
            let PCL = MimeType.Parse "application/vnd.hp-PCL"
            let PCLXL = MimeType.Parse "application/vnd.hp-PCLXL"

        let hsl = MimeType.Parse "application/vnd.hsl"
        let httphone = MimeType.Parse "application/vnd.httphone"

        module hydrostatix =
            module sof =
                let data = MimeType.Parse "application/vnd.hydrostatix.sof-data"

        module hyper =
            module item =
                let json = MimeType.Parse "application/vnd.hyper-item+json"

            let json = MimeType.Parse "application/vnd.hyper+json"

        module hyperdrive =
            let json = MimeType.Parse "application/vnd.hyperdrive+json"

        module hzn =
            module _3d =
                let crossword = MimeType.Parse "application/vnd.hzn-3d-crossword"

        module ibm =
            let afplinedata = MimeType.Parse "application/vnd.ibm.afplinedata"

            module electronic =
                let media = MimeType.Parse "application/vnd.ibm.electronic-media"

            let MiniPay = MimeType.Parse "application/vnd.ibm.MiniPay"
            let modcap = MimeType.Parse "application/vnd.ibm.modcap"

            module rights =
                let management = MimeType.Parse "application/vnd.ibm.rights-management"

            module secure =
                let container = MimeType.Parse "application/vnd.ibm.secure-container"

        let iccprofile = MimeType.Parse "application/vnd.iccprofile"

        module ieee =
            let _1905 = MimeType.Parse "application/vnd.ieee.1905"

        let igloader = MimeType.Parse "application/vnd.igloader"

        module imagemeter =
            module folder =
                let zip = MimeType.Parse "application/vnd.imagemeter.folder+zip"

            module image =
                let zip = MimeType.Parse "application/vnd.imagemeter.image+zip"

        module immervision =
            let ivp = MimeType.Parse "application/vnd.immervision-ivp"
            let ivu = MimeType.Parse "application/vnd.immervision-ivu"

        module ims =
            let imsccv1p1 = MimeType.Parse "application/vnd.ims.imsccv1p1"
            let imsccv1p2 = MimeType.Parse "application/vnd.ims.imsccv1p2"
            let imsccv1p3 = MimeType.Parse "application/vnd.ims.imsccv1p3"

            module lis =
                module v2 =
                    module result =
                        let json = MimeType.Parse "application/vnd.ims.lis.v2.result+json"

            module lti =
                module v2 =
                    module toolconsumerprofile =
                        let json = MimeType.Parse "application/vnd.ims.lti.v2.toolconsumerprofile+json"

                    module toolproxy =
                        module id =
                            let json = MimeType.Parse "application/vnd.ims.lti.v2.toolproxy.id+json"

                        let json = MimeType.Parse "application/vnd.ims.lti.v2.toolproxy+json"

                    module toolsettings =
                        let json = MimeType.Parse "application/vnd.ims.lti.v2.toolsettings+json"

                        module simple =
                            let json = MimeType.Parse "application/vnd.ims.lti.v2.toolsettings.simple+json"

        module informedcontrol =
            module rms =
                let xml = MimeType.Parse "application/vnd.informedcontrol.rms+xml"

        module infotech =
            module project =
                let xml = MimeType.Parse "application/vnd.infotech.project+xml"

        module informix =
            let visionary = MimeType.Parse "application/vnd.informix-visionary"

        module innopath =
            module wamp =
                let notification = MimeType.Parse "application/vnd.innopath.wamp.notification"

        module insors =
            let igm = MimeType.Parse "application/vnd.insors.igm"

        module intercon =
            let formnet = MimeType.Parse "application/vnd.intercon.formnet"

        let intergeo = MimeType.Parse "application/vnd.intergeo"

        module intertrust =
            let digibox = MimeType.Parse "application/vnd.intertrust.digibox"
            let nncp = MimeType.Parse "application/vnd.intertrust.nncp"

        module intu =
            let qbo = MimeType.Parse "application/vnd.intu.qbo"
            let qfx = MimeType.Parse "application/vnd.intu.qfx"

        module ipfs =
            module ipns =
                let record = MimeType.Parse "application/vnd.ipfs.ipns-record"

        module ipld =
            let car = MimeType.Parse "application/vnd.ipld.car"

            module dag =
                let cbor = MimeType.Parse "application/vnd.ipld.dag-cbor"
                let json = MimeType.Parse "application/vnd.ipld.dag-json"

            let raw = MimeType.Parse "application/vnd.ipld.raw"

        module iptc =
            module g2 =
                module catalogitem =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.catalogitem+xml"

                module conceptitem =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.conceptitem+xml"

                module knowledgeitem =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.knowledgeitem+xml"

                module newsitem =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.newsitem+xml"

                module newsmessage =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.newsmessage+xml"

                module packageitem =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.packageitem+xml"

                module planningitem =
                    let xml = MimeType.Parse "application/vnd.iptc.g2.planningitem+xml"

        module ipunplugged =
            let rcprofile = MimeType.Parse "application/vnd.ipunplugged.rcprofile"

        module irepository =
            module package =
                let xml = MimeType.Parse "application/vnd.irepository.package+xml"

        module is =
            let xpr = MimeType.Parse "application/vnd.is-xpr"

        module isac =
            let fcs = MimeType.Parse "application/vnd.isac.fcs"

        let jam = MimeType.Parse "application/vnd.jam"

        module iso11783 =
            module _10 =
                let zip = MimeType.Parse "application/vnd.iso11783-10+zip"

        module japannet =
            module directory =
                let service = MimeType.Parse "application/vnd.japannet-directory-service"

            module jpnstore =
                let wakeup = MimeType.Parse "application/vnd.japannet-jpnstore-wakeup"

            module payment =
                let wakeup = MimeType.Parse "application/vnd.japannet-payment-wakeup"

            module registration =
                let wakeup = MimeType.Parse "application/vnd.japannet-registration-wakeup"

            module setstore =
                let wakeup = MimeType.Parse "application/vnd.japannet-setstore-wakeup"

            module verification =
                let wakeup = MimeType.Parse "application/vnd.japannet-verification-wakeup"

        module jcp =
            module javame =
                module midlet =
                    let rms = MimeType.Parse "application/vnd.jcp.javame.midlet-rms"

        let jisp = MimeType.Parse "application/vnd.jisp"

        module joost =
            module joda =
                let archive = MimeType.Parse "application/vnd.joost.joda-archive"

        module jsk =
            module isdn =
                let ngn = MimeType.Parse "application/vnd.jsk.isdn-ngn"

        let jupyter = MimeType.Parse "application/vnd.jupyter"
        let kahootz = MimeType.Parse "application/vnd.kahootz"

        module kde =
            let karbon = MimeType.Parse "application/vnd.kde.karbon"
            let kchart = MimeType.Parse "application/vnd.kde.kchart"
            let kformula = MimeType.Parse "application/vnd.kde.kformula"
            let kivio = MimeType.Parse "application/vnd.kde.kivio"
            let kontour = MimeType.Parse "application/vnd.kde.kontour"
            let kpresenter = MimeType.Parse "application/vnd.kde.kpresenter"
            let kspread = MimeType.Parse "application/vnd.kde.kspread"
            let kword = MimeType.Parse "application/vnd.kde.kword"

        let kdl = MimeType.Parse "application/vnd.kdl"
        let kenameaapp = MimeType.Parse "application/vnd.kenameaapp"

        module keyman =
            module kmp =
                let zip = MimeType.Parse "application/vnd.keyman.kmp+zip"

            let kmx = MimeType.Parse "application/vnd.keyman.kmx"

        let kidspiration = MimeType.Parse "application/vnd.kidspiration"
        let Kinar = MimeType.Parse "application/vnd.Kinar"

        module klypix =
            let zip = MimeType.Parse "application/vnd.klypix+zip"

        let koan = MimeType.Parse "application/vnd.koan"

        module kodak =
            let descriptor = MimeType.Parse "application/vnd.kodak-descriptor"

        module las =
            module las =
                let json = MimeType.Parse "application/vnd.las.las+json"
                let xml = MimeType.Parse "application/vnd.las.las+xml"

        let laszip = MimeType.Parse "application/vnd.laszip"

        module ldev =
            let productlicensing = MimeType.Parse "application/vnd.ldev.productlicensing"

        module leap =
            let json = MimeType.Parse "application/vnd.leap+json"

        module liberty =
            module request =
                let xml = MimeType.Parse "application/vnd.liberty-request+xml"

        module llamagraphics =
            module life =
                module balance =
                    let desktop = MimeType.Parse "application/vnd.llamagraphics.life-balance.desktop"

                    module exchange =
                        let xml = MimeType.Parse "application/vnd.llamagraphics.life-balance.exchange+xml"

        module logipipe =
            module circuit =
                let zip = MimeType.Parse "application/vnd.logipipe.circuit+zip"

        let loom = MimeType.Parse "application/vnd.loom"

        module lotus =
            module _1 =
                module _2 =
                    let _3 = MimeType.Parse "application/vnd.lotus-1-2-3"

            let approach = MimeType.Parse "application/vnd.lotus-approach"
            let freelance = MimeType.Parse "application/vnd.lotus-freelance"
            let notes = MimeType.Parse "application/vnd.lotus-notes"
            let organizer = MimeType.Parse "application/vnd.lotus-organizer"
            let screencam = MimeType.Parse "application/vnd.lotus-screencam"
            let wordpro = MimeType.Parse "application/vnd.lotus-wordpro"

        module lukuid =
            module package =
                let zip = MimeType.Parse "application/vnd.lukuid.package+zip"

        module macports =
            let portpkg = MimeType.Parse "application/vnd.macports.portpkg"

        module majikah =
            let bundle = MimeType.Parse "application/vnd.majikah.bundle"
            let mjksig = MimeType.Parse "application/vnd.majikah.mjksig"

        let maml = MimeType.Parse "application/vnd.maml"

        module mapbox =
            module vector =
                let tile = MimeType.Parse "application/vnd.mapbox-vector-tile"

        module marlin =
            module drm =
                module actiontoken =
                    let xml = MimeType.Parse "application/vnd.marlin.drm.actiontoken+xml"

                module conftoken =
                    let xml = MimeType.Parse "application/vnd.marlin.drm.conftoken+xml"

                module license =
                    let xml = MimeType.Parse "application/vnd.marlin.drm.license+xml"

                let mdcf = MimeType.Parse "application/vnd.marlin.drm.mdcf"

        module mason =
            let json = MimeType.Parse "application/vnd.mason+json"

        module maxar =
            module archive =
                module _3tz =
                    let zip = MimeType.Parse "application/vnd.maxar.archive.3tz+zip"

        module maxmind =
            module maxmind =
                let db = MimeType.Parse "application/vnd.maxmind.maxmind-db"

        let mcd = MimeType.Parse "application/vnd.mcd"

        module mdl =
            let mbsdf = MimeType.Parse "application/vnd.mdl-mbsdf"

        let medcalcdata = MimeType.Parse "application/vnd.medcalcdata"

        module mediastation =
            let cdkey = MimeType.Parse "application/vnd.mediastation.cdkey"

        module medicalholodeck =
            let recordxr = MimeType.Parse "application/vnd.medicalholodeck.recordxr"

        module meridian =
            let slingshot = MimeType.Parse "application/vnd.meridian-slingshot"

        let mermaid = MimeType.Parse "application/vnd.mermaid"
        let MFER = MimeType.Parse "application/vnd.MFER"
        let mfmp = MimeType.Parse "application/vnd.mfmp"

        module micro =
            let json = MimeType.Parse "application/vnd.micro+json"

        module micrografx =
            let flo = MimeType.Parse "application/vnd.micrografx.flo"
            let igx = MimeType.Parse "application/vnd.micrografx.igx"

        module microsoft =
            module portable =
                let executable = MimeType.Parse "application/vnd.microsoft.portable-executable"

            module windows =
                module thumbnail =
                    let cache = MimeType.Parse "application/vnd.microsoft.windows.thumbnail-cache"

        module miele =
            let json = MimeType.Parse "application/vnd.miele+json"

        let mif = MimeType.Parse "application/vnd.mif"

        module minisoft =
            module hp3000 =
                let save = MimeType.Parse "application/vnd.minisoft-hp3000-save"

        module mitsubishi =
            module misty =
                module guard =
                    let trustweb = MimeType.Parse "application/vnd.mitsubishi.misty-guard.trustweb"

        module Mobius =
            let DAF = MimeType.Parse "application/vnd.Mobius.DAF"
            let DIS = MimeType.Parse "application/vnd.Mobius.DIS"
            let MBK = MimeType.Parse "application/vnd.Mobius.MBK"
            let MQY = MimeType.Parse "application/vnd.Mobius.MQY"
            let MSL = MimeType.Parse "application/vnd.Mobius.MSL"
            let PLC = MimeType.Parse "application/vnd.Mobius.PLC"
            let TXF = MimeType.Parse "application/vnd.Mobius.TXF"

        let modl = MimeType.Parse "application/vnd.modl"
        let mohnetic = MimeType.Parse "application/vnd.mohnetic"

        module mophun =
            let application = MimeType.Parse "application/vnd.mophun.application"
            let certificate = MimeType.Parse "application/vnd.mophun.certificate"

        module motorola =
            module flexsuite =
                let adsi = MimeType.Parse "application/vnd.motorola.flexsuite.adsi"
                let fis = MimeType.Parse "application/vnd.motorola.flexsuite.fis"
                let gotap = MimeType.Parse "application/vnd.motorola.flexsuite.gotap"
                let kmr = MimeType.Parse "application/vnd.motorola.flexsuite.kmr"
                let ttc = MimeType.Parse "application/vnd.motorola.flexsuite.ttc"
                let wem = MimeType.Parse "application/vnd.motorola.flexsuite.wem"

            let iprm = MimeType.Parse "application/vnd.motorola.iprm"

        module mozilla =
            module xul =
                let xml = MimeType.Parse "application/vnd.mozilla.xul+xml"

        module ms =
            let artgalry = MimeType.Parse "application/vnd.ms-artgalry"
            let asf = MimeType.Parse "application/vnd.ms-asf"

            module cab =
                let compressed = MimeType.Parse "application/vnd.ms-cab-compressed"

            let _3mfdocument = MimeType.Parse "application/vnd.ms-3mfdocument"

            module excel =
                module addin =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-excel.addin.macroEnabled.12"

                module sheet =
                    module binary =
                        module macroEnabled =
                            let _12 = MimeType.Parse "application/vnd.ms-excel.sheet.binary.macroEnabled.12"

                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-excel.sheet.macroEnabled.12"

                module template =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-excel.template.macroEnabled.12"

            let fontobject = MimeType.Parse "application/vnd.ms-fontobject"
            let htmlhelp = MimeType.Parse "application/vnd.ms-htmlhelp"
            let ims = MimeType.Parse "application/vnd.ms-ims"
            let lrm = MimeType.Parse "application/vnd.ms-lrm"

            module office =
                module activeX =
                    let xml = MimeType.Parse "application/vnd.ms-office.activeX+xml"

            let officetheme = MimeType.Parse "application/vnd.ms-officetheme"

            module playready =
                module initiator =
                    let xml = MimeType.Parse "application/vnd.ms-playready.initiator+xml"

            module powerpoint =
                module addin =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-powerpoint.addin.macroEnabled.12"

                module presentation =
                    module macroEnabled =
                        let _12 =
                            MimeType.Parse "application/vnd.ms-powerpoint.presentation.macroEnabled.12"

                module slide =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-powerpoint.slide.macroEnabled.12"

                module slideshow =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"

                module template =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-powerpoint.template.macroEnabled.12"

            module PrintDeviceCapabilities =
                let xml = MimeType.Parse "application/vnd.ms-PrintDeviceCapabilities+xml"

            module PrintSchemaTicket =
                let xml = MimeType.Parse "application/vnd.ms-PrintSchemaTicket+xml"

            let project = MimeType.Parse "application/vnd.ms-project"
            let tnef = MimeType.Parse "application/vnd.ms-tnef"

            module windows =
                let devicepairing = MimeType.Parse "application/vnd.ms-windows.devicepairing"

                module nwprinting =
                    let oob = MimeType.Parse "application/vnd.ms-windows.nwprinting.oob"

                let printerpairing = MimeType.Parse "application/vnd.ms-windows.printerpairing"

                module wsd =
                    let oob = MimeType.Parse "application/vnd.ms-windows.wsd.oob"

            module wmdrm =
                module lic =
                    module chlg =
                        let req = MimeType.Parse "application/vnd.ms-wmdrm.lic-chlg-req"

                    let resp = MimeType.Parse "application/vnd.ms-wmdrm.lic-resp"

                module meter =
                    module chlg =
                        let req = MimeType.Parse "application/vnd.ms-wmdrm.meter-chlg-req"

                    let resp = MimeType.Parse "application/vnd.ms-wmdrm.meter-resp"

            module word =
                module document =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-word.document.macroEnabled.12"

                module template =
                    module macroEnabled =
                        let _12 = MimeType.Parse "application/vnd.ms-word.template.macroEnabled.12"

            let works = MimeType.Parse "application/vnd.ms-works"
            let wpl = MimeType.Parse "application/vnd.ms-wpl"
            let xpsdocument = MimeType.Parse "application/vnd.ms-xpsdocument"

        module msa =
            module disk =
                let image = MimeType.Parse "application/vnd.msa-disk-image"

        let mseq = MimeType.Parse "application/vnd.mseq"
        let msgpack = MimeType.Parse "application/vnd.msgpack"
        let msign = MimeType.Parse "application/vnd.msign"

        module multiad =
            module creator =
                let cif = MimeType.Parse "application/vnd.multiad.creator.cif"

        let musician = MimeType.Parse "application/vnd.musician"

        module music =
            let niff = MimeType.Parse "application/vnd.music-niff"

        module muvee =
            let style = MimeType.Parse "application/vnd.muvee.style"

        let mynfc = MimeType.Parse "application/vnd.mynfc"

        module nacamar =
            module ybrid =
                let json = MimeType.Parse "application/vnd.nacamar.ybrid+json"

        module nato =
            module bindingdataobject =
                let cbor = MimeType.Parse "application/vnd.nato.bindingdataobject+cbor"
                let json = MimeType.Parse "application/vnd.nato.bindingdataobject+json"
                let xml = MimeType.Parse "application/vnd.nato.bindingdataobject+xml"

            module openxmlformats =
                module package =
                    module iepd =
                        let zip = MimeType.Parse "application/vnd.nato.openxmlformats-package.iepd+zip"

        module ncd =
            let control = MimeType.Parse "application/vnd.ncd.control"
            let reference = MimeType.Parse "application/vnd.ncd.reference"

        module nearst =
            module inv =
                let json = MimeType.Parse "application/vnd.nearst.inv+json"

        module nebumind =
            let line = MimeType.Parse "application/vnd.nebumind.line"

        let nervana = MimeType.Parse "application/vnd.nervana"
        let netfpx = MimeType.Parse "application/vnd.netfpx"

        module neurolanguage =
            let nlu = MimeType.Parse "application/vnd.neurolanguage.nlu"

        module nila =
            module protobuf =
                module bundle =
                    let zip = MimeType.Parse "application/vnd.nila.protobuf-bundle+zip"

        let nimn = MimeType.Parse "application/vnd.nimn"

        module nintendo =
            module snes =
                let rom = MimeType.Parse "application/vnd.nintendo.snes.rom"

            module nitro =
                let rom = MimeType.Parse "application/vnd.nintendo.nitro.rom"

        let nitf = MimeType.Parse "application/vnd.nitf"

        module noblenet =
            let directory = MimeType.Parse "application/vnd.noblenet-directory"
            let sealer = MimeType.Parse "application/vnd.noblenet-sealer"
            let web = MimeType.Parse "application/vnd.noblenet-web"

        module nokia =
            let catalogs = MimeType.Parse "application/vnd.nokia.catalogs"

            module conml =
                let wbxml = MimeType.Parse "application/vnd.nokia.conml+wbxml"
                let xml = MimeType.Parse "application/vnd.nokia.conml+xml"

            module iptv =
                module config =
                    let xml = MimeType.Parse "application/vnd.nokia.iptv.config+xml"

            module iSDS =
                module radio =
                    let presets = MimeType.Parse "application/vnd.nokia.iSDS-radio-presets"

            module landmark =
                let wbxml = MimeType.Parse "application/vnd.nokia.landmark+wbxml"
                let xml = MimeType.Parse "application/vnd.nokia.landmark+xml"

            module landmarkcollection =
                let xml = MimeType.Parse "application/vnd.nokia.landmarkcollection+xml"

            let ncd = MimeType.Parse "application/vnd.nokia.ncd"

            module n =
                module gage =
                    module ac =
                        let xml = MimeType.Parse "application/vnd.nokia.n-gage.ac+xml"

                    let data = MimeType.Parse "application/vnd.nokia.n-gage.data"

                    module symbian =
                        let install = MimeType.Parse "application/vnd.nokia.n-gage.symbian.install"

            module pcd =
                let wbxml = MimeType.Parse "application/vnd.nokia.pcd+wbxml"
                let xml = MimeType.Parse "application/vnd.nokia.pcd+xml"

            module radio =
                let preset = MimeType.Parse "application/vnd.nokia.radio-preset"
                let presets = MimeType.Parse "application/vnd.nokia.radio-presets"

        module nomos =
            let json = MimeType.Parse "application/vnd.nomos+json"

        module novadigm =
            let EDM = MimeType.Parse "application/vnd.novadigm.EDM"
            let EDX = MimeType.Parse "application/vnd.novadigm.EDX"
            let EXT = MimeType.Parse "application/vnd.novadigm.EXT"

        module ntt =
            module local =
                module content =
                    let share = MimeType.Parse "application/vnd.ntt-local.content-share"

                module file =
                    let transfer = MimeType.Parse "application/vnd.ntt-local.file-transfer"

                module ogw_remote =
                    let access = MimeType.Parse "application/vnd.ntt-local.ogw_remote-access"

                module sip =
                    let ta_remote = MimeType.Parse "application/vnd.ntt-local.sip-ta_remote"
                    let ta_tcp_stream = MimeType.Parse "application/vnd.ntt-local.sip-ta_tcp_stream"

        module nubaltec =
            module nudoku =
                let game = MimeType.Parse "application/vnd.nubaltec.nudoku-game"

        module oai =
            module workflows =
                let json = MimeType.Parse "application/vnd.oai.workflows+json"
                let yaml = MimeType.Parse "application/vnd.oai.workflows+yaml"

        module oasis =
            module opendocument =
                let base_ = MimeType.Parse "application/vnd.oasis.opendocument.base"

                module chart =
                    let template = MimeType.Parse "application/vnd.oasis.opendocument.chart-template"

                let database = MimeType.Parse "application/vnd.oasis.opendocument.database"

                module formula =
                    let template = MimeType.Parse "application/vnd.oasis.opendocument.formula-template"

                module graphics =
                    let template = MimeType.Parse "application/vnd.oasis.opendocument.graphics-template"

                module image =
                    let template = MimeType.Parse "application/vnd.oasis.opendocument.image-template"

                module presentation =
                    let template =
                        MimeType.Parse "application/vnd.oasis.opendocument.presentation-template"

                module spreadsheet =
                    let template =
                        MimeType.Parse "application/vnd.oasis.opendocument.spreadsheet-template"

                module text =
                    module master =
                        let template =
                            MimeType.Parse "application/vnd.oasis.opendocument.text-master-template"

                    let template = MimeType.Parse "application/vnd.oasis.opendocument.text-template"
                    let web = MimeType.Parse "application/vnd.oasis.opendocument.text-web"

        let obn = MimeType.Parse "application/vnd.obn"

        module ocf =
            let cbor = MimeType.Parse "application/vnd.ocf+cbor"

        module oci =
            module image =
                module manifest =
                    module v1 =
                        let json = MimeType.Parse "application/vnd.oci.image.manifest.v1+json"

        module oftn =
            module l10n =
                let json = MimeType.Parse "application/vnd.oftn.l10n+json"

        module oipf =
            module contentaccessdownload =
                let xml = MimeType.Parse "application/vnd.oipf.contentaccessdownload+xml"

            module contentaccessstreaming =
                let xml = MimeType.Parse "application/vnd.oipf.contentaccessstreaming+xml"

            module cspg =
                let hexbinary = MimeType.Parse "application/vnd.oipf.cspg-hexbinary"

            module dae =
                module svg =
                    let xml = MimeType.Parse "application/vnd.oipf.dae.svg+xml"

                module xhtml =
                    let xml = MimeType.Parse "application/vnd.oipf.dae.xhtml+xml"

            module mippvcontrolmessage =
                let xml = MimeType.Parse "application/vnd.oipf.mippvcontrolmessage+xml"

            module pae =
                let gem = MimeType.Parse "application/vnd.oipf.pae.gem"

            module spdiscovery =
                let xml = MimeType.Parse "application/vnd.oipf.spdiscovery+xml"

            module spdlist =
                let xml = MimeType.Parse "application/vnd.oipf.spdlist+xml"

            module ueprofile =
                let xml = MimeType.Parse "application/vnd.oipf.ueprofile+xml"

            module userprofile =
                let xml = MimeType.Parse "application/vnd.oipf.userprofile+xml"

        module olpc =
            let sugar = MimeType.Parse "application/vnd.olpc-sugar"

        module oma =
            module bcast =
                module associated =
                    module procedure =
                        module parameter =
                            let xml =
                                MimeType.Parse "application/vnd.oma.bcast.associated-procedure-parameter+xml"

                module drm =
                    module trigger =
                        let xml = MimeType.Parse "application/vnd.oma.bcast.drm-trigger+xml"

                module imd =
                    let xml = MimeType.Parse "application/vnd.oma.bcast.imd+xml"

                let ltkm = MimeType.Parse "application/vnd.oma.bcast.ltkm"

                module notification =
                    let xml = MimeType.Parse "application/vnd.oma.bcast.notification+xml"

                let provisioningtrigger =
                    MimeType.Parse "application/vnd.oma.bcast.provisioningtrigger"

                let sgboot = MimeType.Parse "application/vnd.oma.bcast.sgboot"

                module sgdd =
                    let xml = MimeType.Parse "application/vnd.oma.bcast.sgdd+xml"

                let sgdu = MimeType.Parse "application/vnd.oma.bcast.sgdu"

                module simple =
                    module symbol =
                        let container = MimeType.Parse "application/vnd.oma.bcast.simple-symbol-container"

                module smartcard =
                    module trigger =
                        let xml = MimeType.Parse "application/vnd.oma.bcast.smartcard-trigger+xml"

                module sprov =
                    let xml = MimeType.Parse "application/vnd.oma.bcast.sprov+xml"

                let stkm = MimeType.Parse "application/vnd.oma.bcast.stkm"

            module cab =
                module address =
                    module book =
                        let xml = MimeType.Parse "application/vnd.oma.cab-address-book+xml"

                module feature =
                    module handler =
                        let xml = MimeType.Parse "application/vnd.oma.cab-feature-handler+xml"

                module pcc =
                    let xml = MimeType.Parse "application/vnd.oma.cab-pcc+xml"

                module subs =
                    module invite =
                        let xml = MimeType.Parse "application/vnd.oma.cab-subs-invite+xml"

                module user =
                    module prefs =
                        let xml = MimeType.Parse "application/vnd.oma.cab-user-prefs+xml"

            let dcd = MimeType.Parse "application/vnd.oma.dcd"
            let dcdc = MimeType.Parse "application/vnd.oma.dcdc"

            module dd2 =
                let xml = MimeType.Parse "application/vnd.oma.dd2+xml"

            module drm =
                module risd =
                    let xml = MimeType.Parse "application/vnd.oma.drm.risd+xml"

            module group =
                module usage =
                    module list =
                        let xml = MimeType.Parse "application/vnd.oma.group-usage-list+xml"

            module lwm2m =
                let cbor = MimeType.Parse "application/vnd.oma.lwm2m+cbor"
                let json = MimeType.Parse "application/vnd.oma.lwm2m+json"
                let tlv = MimeType.Parse "application/vnd.oma.lwm2m+tlv"

            module pal =
                let xml = MimeType.Parse "application/vnd.oma.pal+xml"

            module poc =
                module detailed =
                    module progress =
                        module report =
                            let xml = MimeType.Parse "application/vnd.oma.poc.detailed-progress-report+xml"

                module final =
                    module report =
                        let xml = MimeType.Parse "application/vnd.oma.poc.final-report+xml"

                module groups =
                    let xml = MimeType.Parse "application/vnd.oma.poc.groups+xml"

                module invocation =
                    module descriptor =
                        let xml = MimeType.Parse "application/vnd.oma.poc.invocation-descriptor+xml"

                module optimized =
                    module progress =
                        module report =
                            let xml = MimeType.Parse "application/vnd.oma.poc.optimized-progress-report+xml"

            let push = MimeType.Parse "application/vnd.oma.push"

            module scidm =
                module messages =
                    let xml = MimeType.Parse "application/vnd.oma.scidm.messages+xml"

            module xcap =
                module directory =
                    let xml = MimeType.Parse "application/vnd.oma.xcap-directory+xml"

            module scws =
                let config = MimeType.Parse "application/vnd.oma-scws-config"

                module http =
                    let request = MimeType.Parse "application/vnd.oma-scws-http-request"
                    let response = MimeType.Parse "application/vnd.oma-scws-http-response"

        module omads =
            module email =
                let xml = MimeType.Parse "application/vnd.omads-email+xml"

            module file =
                let xml = MimeType.Parse "application/vnd.omads-file+xml"

            module folder =
                let xml = MimeType.Parse "application/vnd.omads-folder+xml"

        module omaloc =
            module supl =
                let init = MimeType.Parse "application/vnd.omaloc-supl-init"

        module oms =
            module cellular =
                module cose =
                    module content =
                        let cbor = MimeType.Parse "application/vnd.oms.cellular-cose-content+cbor"

        let onepager = MimeType.Parse "application/vnd.onepager"
        let onepagertamp = MimeType.Parse "application/vnd.onepagertamp"
        let onepagertamx = MimeType.Parse "application/vnd.onepagertamx"
        let onepagertat = MimeType.Parse "application/vnd.onepagertat"
        let onepagertatp = MimeType.Parse "application/vnd.onepagertatp"
        let onepagertatx = MimeType.Parse "application/vnd.onepagertatx"

        module onvif =
            let metadata = MimeType.Parse "application/vnd.onvif.metadata"

        module ootmm =
            module patch =
                let zip = MimeType.Parse "application/vnd.ootmm.patch+zip"

        module openblox =
            module game =
                let binary = MimeType.Parse "application/vnd.openblox.game-binary"
                let xml = MimeType.Parse "application/vnd.openblox.game+xml"

        module openeye =
            let oeb = MimeType.Parse "application/vnd.openeye.oeb"

        let openprinttag = MimeType.Parse "application/vnd.openprinttag"

        module openstreetmap =
            module data =
                let xml = MimeType.Parse "application/vnd.openstreetmap.data+xml"

        module opentimestamps =
            let ots = MimeType.Parse "application/vnd.opentimestamps.ots"

        module openvpi =
            module dspx =
                let json = MimeType.Parse "application/vnd.openvpi.dspx+json"

        module openxmlformats =
            module officedocument =
                module custom =
                    module properties =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.custom-properties+xml"

                module customXmlProperties =
                    let xml =
                        MimeType.Parse "application/vnd.openxmlformats-officedocument.customXmlProperties+xml"

                module drawing =
                    let xml = MimeType.Parse "application/vnd.openxmlformats-officedocument.drawing+xml"

                module drawingml =
                    module chart =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.drawingml.chart+xml"

                    module chartshapes =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.drawingml.chartshapes+xml"

                    module diagramColors =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.drawingml.diagramColors+xml"

                    module diagramData =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.drawingml.diagramData+xml"

                    module diagramLayout =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml"

                    module diagramStyle =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml"

                module extended =
                    module properties =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.extended-properties+xml"

                module presentationml =
                    module commentAuthors =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.commentAuthors+xml"

                    module comments =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.comments+xml"

                    module handoutMaster =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml"

                    module notesMaster =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.notesMaster+xml"

                    module notesSlide =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.notesSlide+xml"

                    module presentation =
                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.presentation.main+xml"

                    module presProps =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.presProps+xml"

                    module slide =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.slide+xml"

                    module slideLayout =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.slideLayout+xml"

                    module slideMaster =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.slideMaster+xml"

                    module slideshow =
                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml"

                    module slideUpdateInfo =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml"

                    module tableStyles =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.tableStyles+xml"

                    module tags =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.tags+xml"

                    module template =
                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.template.main+xml"

                    module viewProps =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.presentationml.viewProps+xml"

                module spreadsheetml =
                    module calcChain =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml"

                    module chartsheet =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml"

                    module comments =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.comments+xml"

                    module connections =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.connections+xml"

                    module dialogsheet =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml"

                    module externalLink =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml"

                    module pivotCacheDefinition =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml"

                    module pivotCacheRecords =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml"

                    module pivotTable =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml"

                    module queryTable =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml"

                    module revisionHeaders =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml"

                    module revisionLog =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.revisionLog+xml"

                    module sharedStrings =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml"

                    module sheet =
                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml"

                    module sheetMetadata =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml"

                    module styles =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml"

                    module table =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.table+xml"

                    module tableSingleCells =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml"

                    module template =
                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml"

                    module userNames =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.userNames+xml"

                    module volatileDependencies =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.volatileDependencies+xml"

                    module worksheet =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml"

                module theme =
                    let xml = MimeType.Parse "application/vnd.openxmlformats-officedocument.theme+xml"

                module themeOverride =
                    let xml =
                        MimeType.Parse "application/vnd.openxmlformats-officedocument.themeOverride+xml"

                let vmlDrawing =
                    MimeType.Parse "application/vnd.openxmlformats-officedocument.vmlDrawing"

                module wordprocessingml =
                    module comments =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.comments+xml"

                    module document =
                        module glossary =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml"

                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml"

                    module endnotes =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml"

                    module fontTable =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml"

                    module footer =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml"

                    module footnotes =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml"

                    module numbering =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml"

                    module settings =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml"

                    module styles =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml"

                    module template =
                        module main =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml"

                    module webSettings =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml"

            module package =
                module core =
                    module properties =
                        let xml =
                            MimeType.Parse "application/vnd.openxmlformats-package.core-properties+xml"

                module digital =
                    module signature =
                        module xmlsignature =
                            let xml =
                                MimeType.Parse "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml"

                module relationships =
                    let xml = MimeType.Parse "application/vnd.openxmlformats-package.relationships+xml"

        module oracle =
            module resource =
                let json = MimeType.Parse "application/vnd.oracle.resource+json"

        module orange =
            let indata = MimeType.Parse "application/vnd.orange.indata"

        module osa =
            let netdeploy = MimeType.Parse "application/vnd.osa.netdeploy"

        module osgeo =
            module mapguide =
                let package = MimeType.Parse "application/vnd.osgeo.mapguide.package"

        module osgi =
            let bundle = MimeType.Parse "application/vnd.osgi.bundle"
            let dp = MimeType.Parse "application/vnd.osgi.dp"
            let subsystem = MimeType.Parse "application/vnd.osgi.subsystem"

        module otps =
            module ct =
                module kip =
                    let xml = MimeType.Parse "application/vnd.otps.ct-kip+xml"

        module oxli =
            let countgraph = MimeType.Parse "application/vnd.oxli.countgraph"

        module pagerduty =
            let json = MimeType.Parse "application/vnd.pagerduty+json"

        let palm = MimeType.Parse "application/vnd.palm"
        let panoply = MimeType.Parse "application/vnd.panoply"

        module paos =
            let xml = MimeType.Parse "application/vnd.paos.xml"

        module pasti =
            module stx =
                module disk =
                    let image = MimeType.Parse "application/vnd.pasti-stx-disk-image"

        let patentdive = MimeType.Parse "application/vnd.patentdive"
        let patientecommsdoc = MimeType.Parse "application/vnd.patientecommsdoc"
        let pawaafile = MimeType.Parse "application/vnd.pawaafile"
        let pcos = MimeType.Parse "application/vnd.pcos"

        module pg =
            let format = MimeType.Parse "application/vnd.pg.format"
            let osasli = MimeType.Parse "application/vnd.pg.osasli"

        module phbk =
            let xml = MimeType.Parse "application/vnd.phbk+xml"

        module piaccess =
            module application =
                let licence = MimeType.Parse "application/vnd.piaccess.application-licence"

        let picsel = MimeType.Parse "application/vnd.picsel"

        module pmi =
            let widget = MimeType.Parse "application/vnd.pmi.widget"

        let pmtiles = MimeType.Parse "application/vnd.pmtiles"

        module poc =
            module group =
                module advertisement =
                    let xml = MimeType.Parse "application/vnd.poc.group-advertisement+xml"

        let pocketlearn = MimeType.Parse "application/vnd.pocketlearn"

        module portableweb =
            let zip = MimeType.Parse "application/vnd.portableweb+zip"

        module powerbuilder6 =
            let s = MimeType.Parse "application/vnd.powerbuilder6-s"

        module powerbuilder7 =
            let s = MimeType.Parse "application/vnd.powerbuilder7-s"

        module powerbuilder75 =
            let s = MimeType.Parse "application/vnd.powerbuilder75-s"

        module pp =
            module systemverify =
                let xml = MimeType.Parse "application/vnd.pp.systemverify+xml"

        let preminet = MimeType.Parse "application/vnd.preminet"

        module previewsystems =
            let box = MimeType.Parse "application/vnd.previewsystems.box"

        let prismatic = MimeType.Parse "application/vnd.prismatic"

        module prml =
            let yaml = MimeType.Parse "application/vnd.prml+yaml"

        module project =
            let graph = MimeType.Parse "application/vnd.project-graph"

        module proteus =
            let magazine = MimeType.Parse "application/vnd.proteus.magazine"

        let psfs = MimeType.Parse "application/vnd.psfs"

        module pt =
            let mundusmundi = MimeType.Parse "application/vnd.pt.mundusmundi"

        module publishare =
            module delta =
                let tree = MimeType.Parse "application/vnd.publishare-delta-tree"

        module pvi =
            let ptid1 = MimeType.Parse "application/vnd.pvi.ptid1"

        module pwg =
            let multiplexed = MimeType.Parse "application/vnd.pwg-multiplexed"

            module xhtml =
                module print =
                    let xml = MimeType.Parse "application/vnd.pwg-xhtml-print+xml"

        module pyon =
            let json = MimeType.Parse "application/vnd.pyon+json"

        module qualcomm =
            module brew =
                module app =
                    let res = MimeType.Parse "application/vnd.qualcomm.brew-app-res"

        let quarantainenet = MimeType.Parse "application/vnd.quarantainenet"

        module Quark =
            let QuarkXPress = MimeType.Parse "application/vnd.Quark.QuarkXPress"

        module quobject =
            let quoxdocument = MimeType.Parse "application/vnd.quobject-quoxdocument"

        module R74n =
            module sandboxels =
                let json = MimeType.Parse "application/vnd.R74n.sandboxels+json"

        module radisys =
            module moml =
                let xml = MimeType.Parse "application/vnd.radisys.moml+xml"

            module msml =
                module audit =
                    module conf =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-audit-conf+xml"

                    module conn =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-audit-conn+xml"

                    module dialog =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-audit-dialog+xml"

                    module stream =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-audit-stream+xml"

                    let xml = MimeType.Parse "application/vnd.radisys.msml-audit+xml"

                module conf =
                    let xml = MimeType.Parse "application/vnd.radisys.msml-conf+xml"

                module dialog =
                    module base_ =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-dialog-base+xml"

                    module fax =
                        module detect =
                            let xml = MimeType.Parse "application/vnd.radisys.msml-dialog-fax-detect+xml"

                        module sendrecv =
                            let xml = MimeType.Parse "application/vnd.radisys.msml-dialog-fax-sendrecv+xml"

                    module group =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-dialog-group+xml"

                    module speech =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-dialog-speech+xml"

                    module transform =
                        let xml = MimeType.Parse "application/vnd.radisys.msml-dialog-transform+xml"

                    let xml = MimeType.Parse "application/vnd.radisys.msml-dialog+xml"

                let xml = MimeType.Parse "application/vnd.radisys.msml+xml"

        module rainstor =
            let data = MimeType.Parse "application/vnd.rainstor.data"

        let rapid = MimeType.Parse "application/vnd.rapid"
        let rar = MimeType.Parse "application/vnd.rar"

        module realvnc =
            let bed = MimeType.Parse "application/vnd.realvnc.bed"

        module recordare =
            module musicxml =
                let xml = MimeType.Parse "application/vnd.recordare.musicxml+xml"

        let rego = MimeType.Parse "application/vnd.rego"
        let relpipe = MimeType.Parse "application/vnd.relpipe"

        module RenLearn =
            let rlprint = MimeType.Parse "application/vnd.RenLearn.rlprint"

        module resilient =
            let logic = MimeType.Parse "application/vnd.resilient.logic"

        module restful =
            let json = MimeType.Parse "application/vnd.restful+json"

        module rig =
            let cryptonote = MimeType.Parse "application/vnd.rig.cryptonote"

        module route66 =
            module link66 =
                let xml = MimeType.Parse "application/vnd.route66.link66+xml"

        module rs =
            let _274x = MimeType.Parse "application/vnd.rs-274x"

        module ruckus =
            let download = MimeType.Parse "application/vnd.ruckus.download"

        let s3sms = MimeType.Parse "application/vnd.s3sms"

        module sailingtracker =
            let track = MimeType.Parse "application/vnd.sailingtracker.track"

        module salvanote =
            let sal = MimeType.Parse "application/vnd.salvanote.sal"

        let sar = MimeType.Parse "application/vnd.sar"

        module sbm =
            let cid = MimeType.Parse "application/vnd.sbm.cid"
            let mid2 = MimeType.Parse "application/vnd.sbm.mid2"

        let scribus = MimeType.Parse "application/vnd.scribus"

        module sealed_ =
            let _3df = MimeType.Parse "application/vnd.sealed.3df"
            let csf = MimeType.Parse "application/vnd.sealed.csf"
            let doc = MimeType.Parse "application/vnd.sealed.doc"
            let eml = MimeType.Parse "application/vnd.sealed.eml"
            let mht = MimeType.Parse "application/vnd.sealed.mht"
            let net = MimeType.Parse "application/vnd.sealed.net"
            let ppt = MimeType.Parse "application/vnd.sealed.ppt"
            let tiff = MimeType.Parse "application/vnd.sealed.tiff"
            let xls = MimeType.Parse "application/vnd.sealed.xls"

        module sealedmedia =
            module softseal =
                let html = MimeType.Parse "application/vnd.sealedmedia.softseal.html"
                let pdf = MimeType.Parse "application/vnd.sealedmedia.softseal.pdf"

        let seemail = MimeType.Parse "application/vnd.seemail"

        module seis =
            let json = MimeType.Parse "application/vnd.seis+json"

        let sema = MimeType.Parse "application/vnd.sema"
        let semd = MimeType.Parse "application/vnd.semd"
        let semf = MimeType.Parse "application/vnd.semf"

        module shade =
            module save =
                let file = MimeType.Parse "application/vnd.shade-save-file"

        module shana =
            module informed =
                let formdata = MimeType.Parse "application/vnd.shana.informed.formdata"
                let formtemplate = MimeType.Parse "application/vnd.shana.informed.formtemplate"
                let interchange = MimeType.Parse "application/vnd.shana.informed.interchange"
                let package = MimeType.Parse "application/vnd.shana.informed.package"

        module shootproof =
            let json = MimeType.Parse "application/vnd.shootproof+json"

        module shopkick =
            let json = MimeType.Parse "application/vnd.shopkick+json"

        let shp = MimeType.Parse "application/vnd.shp"
        let shx = MimeType.Parse "application/vnd.shx"

        module sigrok =
            let session = MimeType.Parse "application/vnd.sigrok.session"

        module SimTech =
            let MindMapper = MimeType.Parse "application/vnd.SimTech-MindMapper"

        module siren =
            let json = MimeType.Parse "application/vnd.siren+json"

        module sirtx =
            let vmv0 = MimeType.Parse "application/vnd.sirtx.vmv0"

        let sketchometry = MimeType.Parse "application/vnd.sketchometry"
        let smaf = MimeType.Parse "application/vnd.smaf"

        module smart =
            let notebook = MimeType.Parse "application/vnd.smart.notebook"
            let teacher = MimeType.Parse "application/vnd.smart.teacher"

        module smintio =
            module portals =
                let archive = MimeType.Parse "application/vnd.smintio.portals.archive"

        module snesdev =
            module page =
                let table = MimeType.Parse "application/vnd.snesdev-page-table"

        module softpres =
            module ipf =
                module disk =
                    let image = MimeType.Parse "application/vnd.softpres-ipf-disk-image"

        module software602 =
            module filler =
                module form =
                    module xml =
                        let zip = MimeType.Parse "application/vnd.software602.filler.form-xml-zip"

        module solent =
            module sdkm =
                let xml = MimeType.Parse "application/vnd.solent.sdkm+xml"

        module spotfire =
            let dxp = MimeType.Parse "application/vnd.spotfire.dxp"
            let sfs = MimeType.Parse "application/vnd.spotfire.sfs"

        let sqlite3 = MimeType.Parse "application/vnd.sqlite3"
        let sri = MimeType.Parse "application/vnd.sri"

        module sss =
            let cod = MimeType.Parse "application/vnd.sss-cod"
            let dtf = MimeType.Parse "application/vnd.sss-dtf"
            let ntf = MimeType.Parse "application/vnd.sss-ntf"

        module stepmania =
            let package = MimeType.Parse "application/vnd.stepmania.package"
            let stepchart = MimeType.Parse "application/vnd.stepmania.stepchart"

        module street =
            let stream = MimeType.Parse "application/vnd.street-stream"

        module sun =
            module wadl =
                let xml = MimeType.Parse "application/vnd.sun.wadl+xml"

        module supercard =
            module pro =
                module disk =
                    let image = MimeType.Parse "application/vnd.supercard-pro-disk-image"

        module superfile =
            let super = MimeType.Parse "application/vnd.superfile.super"

        module sus =
            let calendar = MimeType.Parse "application/vnd.sus-calendar"

        let svd = MimeType.Parse "application/vnd.svd"

        module svr =
            module receipt =
                let json = MimeType.Parse "application/vnd.svr.receipt+json"

        module swiftview =
            let ics = MimeType.Parse "application/vnd.swiftview-ics"

        module sybyl =
            let mol2 = MimeType.Parse "application/vnd.sybyl.mol2"

        module sycle =
            let xml = MimeType.Parse "application/vnd.sycle+xml"

        module syft =
            let json = MimeType.Parse "application/vnd.syft+json"

        module syncml =
            module dm =
                let notification = MimeType.Parse "application/vnd.syncml.dm.notification"
                let wbxml = MimeType.Parse "application/vnd.syncml.dm+wbxml"
                let xml = MimeType.Parse "application/vnd.syncml.dm+xml"

            module dmddf =
                let xml = MimeType.Parse "application/vnd.syncml.dmddf+xml"
                let wbxml = MimeType.Parse "application/vnd.syncml.dmddf+wbxml"

            module dmtnds =
                let wbxml = MimeType.Parse "application/vnd.syncml.dmtnds+wbxml"
                let xml = MimeType.Parse "application/vnd.syncml.dmtnds+xml"

            module ds =
                let notification = MimeType.Parse "application/vnd.syncml.ds.notification"

            let xml = MimeType.Parse "application/vnd.syncml+xml"

        module tablafocus =
            let notation = MimeType.Parse "application/vnd.tablafocus.notation"

        module tableschema =
            let json = MimeType.Parse "application/vnd.tableschema+json"

        module tao =
            module intent =
                module module_ =
                    let archive = MimeType.Parse "application/vnd.tao.intent-module-archive"

        module tcpdump =
            let pcap = MimeType.Parse "application/vnd.tcpdump.pcap"

        module think =
            module cell =
                module ppttc =
                    let json = MimeType.Parse "application/vnd.think-cell.ppttc+json"

        let tml = MimeType.Parse "application/vnd.tml"

        module tmd =
            module mediaflex =
                module api =
                    let xml = MimeType.Parse "application/vnd.tmd.mediaflex.api+xml"

        module tmobile =
            let livetv = MimeType.Parse "application/vnd.tmobile-livetv"

        module tri =
            let onesource = MimeType.Parse "application/vnd.tri.onesource"

        module trid =
            let tpt = MimeType.Parse "application/vnd.trid.tpt"

        module triscape =
            let mxs = MimeType.Parse "application/vnd.triscape.mxs"

        let trueapp = MimeType.Parse "application/vnd.trueapp"
        let truedoc = MimeType.Parse "application/vnd.truedoc"

        module ubisoft =
            let webplayer = MimeType.Parse "application/vnd.ubisoft.webplayer"

        let ufdl = MimeType.Parse "application/vnd.ufdl"

        module uic =
            module dosipas =
                let v1 = MimeType.Parse "application/vnd.uic.dosipas.v1"
                let v2 = MimeType.Parse "application/vnd.uic.dosipas.v2"

            module osdm =
                let json = MimeType.Parse "application/vnd.uic.osdm+json"

            module tlb =
                let fcb = MimeType.Parse "application/vnd.uic.tlb-fcb"

        module uiq =
            let theme = MimeType.Parse "application/vnd.uiq.theme"

        let umajin = MimeType.Parse "application/vnd.umajin"
        let unity = MimeType.Parse "application/vnd.unity"

        module uoml =
            let xml = MimeType.Parse "application/vnd.uoml+xml"

        module uplanet =
            module alert =
                let wbxml = MimeType.Parse "application/vnd.uplanet.alert-wbxml"

            module bearer =
                module choice =
                    let wbxml = MimeType.Parse "application/vnd.uplanet.bearer-choice-wbxml"

            module cacheop =
                let wbxml = MimeType.Parse "application/vnd.uplanet.cacheop-wbxml"

            module channel =
                let wbxml = MimeType.Parse "application/vnd.uplanet.channel-wbxml"

            module list =
                let wbxml = MimeType.Parse "application/vnd.uplanet.list-wbxml"

            module listcmd =
                let wbxml = MimeType.Parse "application/vnd.uplanet.listcmd-wbxml"

            let signal = MimeType.Parse "application/vnd.uplanet.signal"

        module uri =
            let map = MimeType.Parse "application/vnd.uri-map"

        module valve =
            module source =
                let material = MimeType.Parse "application/vnd.valve.source.material"

        let vcx = MimeType.Parse "application/vnd.vcx"

        module vd =
            let study = MimeType.Parse "application/vnd.vd-study"

        let vectorworks = MimeType.Parse "application/vnd.vectorworks"

        module vel =
            let json = MimeType.Parse "application/vnd.vel+json"

        module veraison =
            module nvidia =
                module gpu =
                    module evidence =
                        let json = MimeType.Parse "application/vnd.veraison.nvidia-gpu-evidence+json"

            module tsm =
                module report =
                    let cbor = MimeType.Parse "application/vnd.veraison.tsm-report+cbor"
                    let json = MimeType.Parse "application/vnd.veraison.tsm-report+json"

        module verifier =
            module attestation =
                let jwt = MimeType.Parse "application/vnd.verifier-attestation+jwt"

        module verimatrix =
            let vcas = MimeType.Parse "application/vnd.verimatrix.vcas"

        module veritone =
            module aion =
                let json = MimeType.Parse "application/vnd.veritone.aion+json"

        module vertifile =
            let pvf = MimeType.Parse "application/vnd.vertifile.pvf"

        module veryant =
            let thin = MimeType.Parse "application/vnd.veryant.thin"

        module ves =
            let encrypted = MimeType.Parse "application/vnd.ves.encrypted"

        module vidsoft =
            let vidconference = MimeType.Parse "application/vnd.vidsoft.vidconference"

        module vimina =
            let vma = MimeType.Parse "application/vnd.vimina.vma"

        let visio = MimeType.Parse "application/vnd.visio"
        let visionary = MimeType.Parse "application/vnd.visionary"

        module vividence =
            let scriptfile = MimeType.Parse "application/vnd.vividence.scriptfile"

        module vocalshaper =
            let vsp4 = MimeType.Parse "application/vnd.vocalshaper.vsp4"

        let vsf = MimeType.Parse "application/vnd.vsf"
        let vuq = MimeType.Parse "application/vnd.vuq"
        let wantverse = MimeType.Parse "application/vnd.wantverse"

        module wap =
            let sic = MimeType.Parse "application/vnd.wap.sic"
            let slc = MimeType.Parse "application/vnd.wap.slc"
            let wbxml = MimeType.Parse "application/vnd.wap.wbxml"
            let wmlc = MimeType.Parse "application/vnd.wap.wmlc"
            let wmlscriptc = MimeType.Parse "application/vnd.wap.wmlscriptc"

        module wasmflow =
            let wafl = MimeType.Parse "application/vnd.wasmflow.wafl"

        let webturbo = MimeType.Parse "application/vnd.webturbo"

        module wfa =
            let dpp = MimeType.Parse "application/vnd.wfa.dpp"
            let p2p = MimeType.Parse "application/vnd.wfa.p2p"
            let wsc = MimeType.Parse "application/vnd.wfa.wsc"

        module windows =
            let devicepairing = MimeType.Parse "application/vnd.windows.devicepairing"

        let wmap = MimeType.Parse "application/vnd.wmap"
        let wmc = MimeType.Parse "application/vnd.wmc"

        module wmf =
            let bootstrap = MimeType.Parse "application/vnd.wmf.bootstrap"

        module wolfram =
            module mathematica =
                let package = MimeType.Parse "application/vnd.wolfram.mathematica.package"

            let player = MimeType.Parse "application/vnd.wolfram.player"

        let wordlift = MimeType.Parse "application/vnd.wordlift"
        let wordperfect = MimeType.Parse "application/vnd.wordperfect"
        let wqd = MimeType.Parse "application/vnd.wqd"

        module wrq =
            module hp3000 =
                let labelled = MimeType.Parse "application/vnd.wrq-hp3000-labelled"

        module wt =
            let stf = MimeType.Parse "application/vnd.wt.stf"

        module wv =
            module csp =
                let xml = MimeType.Parse "application/vnd.wv.csp+xml"
                let wbxml = MimeType.Parse "application/vnd.wv.csp+wbxml"

            module ssp =
                let xml = MimeType.Parse "application/vnd.wv.ssp+xml"

        module xacml =
            let json = MimeType.Parse "application/vnd.xacml+json"

        let xara = MimeType.Parse "application/vnd.xara"

        module xarin =
            let cpj = MimeType.Parse "application/vnd.xarin.cpj"

        let xcdn = MimeType.Parse "application/vnd.xcdn"

        module xecrets =
            let encrypted = MimeType.Parse "application/vnd.xecrets-encrypted"

        module xfdl =
            let webform = MimeType.Parse "application/vnd.xfdl.webform"

        module xmi =
            let xml = MimeType.Parse "application/vnd.xmi+xml"

        module xmpie =
            let cpkg = MimeType.Parse "application/vnd.xmpie.cpkg"
            let dpkg = MimeType.Parse "application/vnd.xmpie.dpkg"
            let plan = MimeType.Parse "application/vnd.xmpie.plan"
            let ppkg = MimeType.Parse "application/vnd.xmpie.ppkg"
            let xlim = MimeType.Parse "application/vnd.xmpie.xlim"

        module yamaha =
            module hv =
                let dic = MimeType.Parse "application/vnd.yamaha.hv-dic"
                let script = MimeType.Parse "application/vnd.yamaha.hv-script"
                let voice = MimeType.Parse "application/vnd.yamaha.hv-voice"

            module openscoreformat =
                module osfpvg =
                    let xml = MimeType.Parse "application/vnd.yamaha.openscoreformat.osfpvg+xml"

            module remote =
                let setup = MimeType.Parse "application/vnd.yamaha.remote-setup"

            module smaf =
                let audio = MimeType.Parse "application/vnd.yamaha.smaf-audio"
                let phrase = MimeType.Parse "application/vnd.yamaha.smaf-phrase"

            module through =
                let ngn = MimeType.Parse "application/vnd.yamaha.through-ngn"

            module tunnel =
                let udpencap = MimeType.Parse "application/vnd.yamaha.tunnel-udpencap"

        let yaoweme = MimeType.Parse "application/vnd.yaoweme"

        module yellowriver =
            module custom =
                let menu = MimeType.Parse "application/vnd.yellowriver-custom-menu"

        module youtube =
            let yt = MimeType.Parse "application/vnd.youtube.yt"

        module zoho =
            module document =
                let writer = MimeType.Parse "application/vnd.zoho-document.writer"

            module presentation =
                let show = MimeType.Parse "application/vnd.zoho-presentation.show"

            module spreadsheetml =
                let sheet = MimeType.Parse "application/vnd.zoho.spreadsheetml.sheet"

        let zul = MimeType.Parse "application/vnd.zul"

        module zzazz =
            module deck =
                let xml = MimeType.Parse "application/vnd.zzazz.deck+xml"

    let cybercash = MimeType.Parse "application/cybercash"

    module dash =
        let xml = MimeType.Parse "application/dash+xml"

        module patch =
            let xml = MimeType.Parse "application/dash-patch+xml"

    let dashdelta = MimeType.Parse "application/dashdelta"

    module davmount =
        let xml = MimeType.Parse "application/davmount+xml"

    module dca =
        let rft = MimeType.Parse "application/dca-rft"

    let DCD = MimeType.Parse "application/DCD"

    module dec =
        let dx = MimeType.Parse "application/dec-dx"

    module dialog =
        module info =
            let xml = MimeType.Parse "application/dialog-info+xml"

    module dicom =
        let json = MimeType.Parse "application/dicom+json"
        let xml = MimeType.Parse "application/dicom+xml"

    let did = MimeType.Parse "application/did"
    let DII = MimeType.Parse "application/DII"
    let DIT = MimeType.Parse "application/DIT"

    module dns =
        let json = MimeType.Parse "application/dns+json"
        let message = MimeType.Parse "application/dns-message"

    module dots =
        let cbor = MimeType.Parse "application/dots+cbor"

    module dpop =
        let jwt = MimeType.Parse "application/dpop+jwt"

    module dskpp =
        let xml = MimeType.Parse "application/dskpp+xml"

    module dssc =
        let der = MimeType.Parse "application/dssc+der"
        let xml = MimeType.Parse "application/dssc+xml"

    let dvcs = MimeType.Parse "application/dvcs"

    module eat =
        let cwt = MimeType.Parse "application/eat+cwt"
        let jwt = MimeType.Parse "application/eat+jwt"

        module bun =
            let cbor = MimeType.Parse "application/eat-bun+cbor"
            let json = MimeType.Parse "application/eat-bun+json"

        module ucs =
            let cbor = MimeType.Parse "application/eat-ucs+cbor"
            let json = MimeType.Parse "application/eat-ucs+json"

    let ecmascript = MimeType.Parse "application/ecmascript"

    module edhoc =
        module cbor =
            let seq = MimeType.Parse "application/edhoc+cbor-seq"

    module EDI =
        let consent = MimeType.Parse "application/EDI-consent"
        let X12 = MimeType.Parse "application/EDI-X12"

    let EDIFACT = MimeType.Parse "application/EDIFACT"
    let efi = MimeType.Parse "application/efi"

    module elm =
        let json = MimeType.Parse "application/elm+json"
        let xml = MimeType.Parse "application/elm+xml"

    module EmergencyCallData =
        module cap =
            let xml = MimeType.Parse "application/EmergencyCallData.cap+xml"

        module Comment =
            let xml = MimeType.Parse "application/EmergencyCallData.Comment+xml"

        module Control =
            let xml = MimeType.Parse "application/EmergencyCallData.Control+xml"

        module DeviceInfo =
            let xml = MimeType.Parse "application/EmergencyCallData.DeviceInfo+xml"

        module eCall =
            let MSD = MimeType.Parse "application/EmergencyCallData.eCall.MSD"

        module LegacyESN =
            let json = MimeType.Parse "application/EmergencyCallData.LegacyESN+json"

        module ProviderInfo =
            let xml = MimeType.Parse "application/EmergencyCallData.ProviderInfo+xml"

        module ServiceInfo =
            let xml = MimeType.Parse "application/EmergencyCallData.ServiceInfo+xml"

        module SubscriberInfo =
            let xml = MimeType.Parse "application/EmergencyCallData.SubscriberInfo+xml"

        module VEDS =
            let xml = MimeType.Parse "application/EmergencyCallData.VEDS+xml"

    module emma =
        let xml = MimeType.Parse "application/emma+xml"

    module emotionml =
        let xml = MimeType.Parse "application/emotionml+xml"

    let encaprtp = MimeType.Parse "application/encaprtp"

    module entity =
        module statement =
            let jwt = MimeType.Parse "application/entity-statement+jwt"

    module epp =
        let xml = MimeType.Parse "application/epp+xml"

    module epub =
        let zip = MimeType.Parse "application/epub+zip"

    let eshop = MimeType.Parse "application/eshop"
    let example = MimeType.Parse "application/example"
    let exi = MimeType.Parse "application/exi"

    module expect =
        module ct =
            module report =
                let json = MimeType.Parse "application/expect-ct-report+json"

    module explicit =
        module registration =
            module response =
                let jwt = MimeType.Parse "application/explicit-registration-response+jwt"

    let express = MimeType.Parse "application/express"
    let fastinfoset = MimeType.Parse "application/fastinfoset"
    let fastsoap = MimeType.Parse "application/fastsoap"
    let fdf = MimeType.Parse "application/fdf"

    module fdt =
        let xml = MimeType.Parse "application/fdt+xml"

    module fhir =
        let json = MimeType.Parse "application/fhir+json"
        let xml = MimeType.Parse "application/fhir+xml"

    let fits = MimeType.Parse "application/fits"
    let flexfec = MimeType.Parse "application/flexfec"

    module font =
        let sfnt = MimeType.Parse "application/font-sfnt"
        let tdpfr = MimeType.Parse "application/font-tdpfr"
        let woff = MimeType.Parse "application/font-woff"

    module framework =
        module attributes =
            let xml = MimeType.Parse "application/framework-attributes+xml"

    module geo =
        module json =
            let seq = MimeType.Parse "application/geo+json-seq"

    module geofeed =
        let csv = MimeType.Parse "application/geofeed+csv"

    module geopackage =
        let sqlite3 = MimeType.Parse "application/geopackage+sqlite3"

    module geopose =
        let json = MimeType.Parse "application/geopose+json"

    module geoxacml =
        let json = MimeType.Parse "application/geoxacml+json"
        let xml = MimeType.Parse "application/geoxacml+xml"

    module gltf =
        let buffer = MimeType.Parse "application/gltf-buffer"

    module gml =
        let xml = MimeType.Parse "application/gml+xml"

    module gnap =
        module binding =
            let jws = MimeType.Parse "application/gnap-binding-jws"
            let jwsd = MimeType.Parse "application/gnap-binding-jwsd"

            module rotation =
                let jws = MimeType.Parse "application/gnap-binding-rotation-jws"
                let jwsd = MimeType.Parse "application/gnap-binding-rotation-jwsd"

    let grib = MimeType.Parse "application/grib"
    let gzip = MimeType.Parse "application/gzip"
    let H224 = MimeType.Parse "application/H224"

    module held =
        let xml = MimeType.Parse "application/held+xml"

    module hl7v2 =
        let xml = MimeType.Parse "application/hl7v2+xml"

    let http = MimeType.Parse "application/http"
    let hyperstudio = MimeType.Parse "application/hyperstudio"

    module ibe =
        module key =
            module request =
                let xml = MimeType.Parse "application/ibe-key-request+xml"

        module pkg =
            module reply =
                let xml = MimeType.Parse "application/ibe-pkg-reply+xml"

        module pp =
            let data = MimeType.Parse "application/ibe-pp-data"

    let iges = MimeType.Parse "application/iges"

    module im =
        module iscomposing =
            let xml = MimeType.Parse "application/im-iscomposing+xml"

    module index =
        let cmd = MimeType.Parse "application/index.cmd"
        let obj = MimeType.Parse "application/index.obj"
        let response = MimeType.Parse "application/index.response"
        let vnd = MimeType.Parse "application/index.vnd"

    module inkml =
        let xml = MimeType.Parse "application/inkml+xml"

    let IOTP = MimeType.Parse "application/IOTP"
    let ipfix = MimeType.Parse "application/ipfix"
    let ipp = MimeType.Parse "application/ipp"
    let ISUP = MimeType.Parse "application/ISUP"

    module its =
        let xml = MimeType.Parse "application/its+xml"

    module java =
        let archive = MimeType.Parse "application/java-archive"

    let javascript = MimeType.Parse "application/javascript"

    module jf2feed =
        let json = MimeType.Parse "application/jf2feed+json"

    module jose =
        let json = MimeType.Parse "application/jose+json"

    module jrd =
        let json = MimeType.Parse "application/jrd+json"

    module jscalendar =
        let json = MimeType.Parse "application/jscalendar+json"

    module jscontact =
        let json = MimeType.Parse "application/jscontact+json"

    module json =
        module patch =
            let json = MimeType.Parse "application/json-patch+json"

            module query =
                let json = MimeType.Parse "application/json-patch-query+json"

        let seq = MimeType.Parse "application/json-seq"

    let jsonpath = MimeType.Parse "application/jsonpath"
    let jumbf = MimeType.Parse "application/jumbf"

    module jwk =
        let json = MimeType.Parse "application/jwk+json"

        module set =
            let json = MimeType.Parse "application/jwk-set+json"
            let jwt = MimeType.Parse "application/jwk-set+jwt"

    let jwt = MimeType.Parse "application/jwt"

    module kb =
        let jwt = MimeType.Parse "application/kb+jwt"

    module kbl =
        let xml = MimeType.Parse "application/kbl+xml"

    module kpml =
        module request =
            let xml = MimeType.Parse "application/kpml-request+xml"

        module response =
            let xml = MimeType.Parse "application/kpml-response+xml"

    module ld =
        let json = MimeType.Parse "application/ld+json"

    module lgr =
        let xml = MimeType.Parse "application/lgr+xml"

    module link =
        let format = MimeType.Parse "application/link-format"

    module linkset =
        let json = MimeType.Parse "application/linkset+json"

    module load =
        module control =
            let xml = MimeType.Parse "application/load-control+xml"

    module logout =
        let jwt = MimeType.Parse "application/logout+jwt"

    module lost =
        let xml = MimeType.Parse "application/lost+xml"

    module lostsync =
        let xml = MimeType.Parse "application/lostsync+xml"

    module lpf =
        let zip = MimeType.Parse "application/lpf+zip"

    let LXF = MimeType.Parse "application/LXF"

    module mac =
        let binhex40 = MimeType.Parse "application/mac-binhex40"

    let macwriteii = MimeType.Parse "application/macwriteii"

    module mads =
        let xml = MimeType.Parse "application/mads+xml"

    module manifest =
        let json = MimeType.Parse "application/manifest+json"

    let marc = MimeType.Parse "application/marc"

    module marcxml =
        let xml = MimeType.Parse "application/marcxml+xml"

    let mathematica = MimeType.Parse "application/mathematica"

    module mathml =
        let xml = MimeType.Parse "application/mathml+xml"

        module content =
            let xml = MimeType.Parse "application/mathml-content+xml"

        module presentation =
            let xml = MimeType.Parse "application/mathml-presentation+xml"

    module mbms =
        module associated =
            module procedure =
                module description =
                    let xml = MimeType.Parse "application/mbms-associated-procedure-description+xml"

        module deregister =
            let xml = MimeType.Parse "application/mbms-deregister+xml"

        module envelope =
            let xml = MimeType.Parse "application/mbms-envelope+xml"

        module msk =
            module response =
                let xml = MimeType.Parse "application/mbms-msk-response+xml"

            let xml = MimeType.Parse "application/mbms-msk+xml"

        module protection =
            module description =
                let xml = MimeType.Parse "application/mbms-protection-description+xml"

        module reception =
            module report =
                let xml = MimeType.Parse "application/mbms-reception-report+xml"

        module register =
            module response =
                let xml = MimeType.Parse "application/mbms-register-response+xml"

            let xml = MimeType.Parse "application/mbms-register+xml"

        module schedule =
            let xml = MimeType.Parse "application/mbms-schedule+xml"

        module user =
            module service =
                module description =
                    let xml = MimeType.Parse "application/mbms-user-service-description+xml"

    let mbox = MimeType.Parse "application/mbox"

    module measured =
        module component_ =
            let cbor = MimeType.Parse "application/measured-component+cbor"
            let json = MimeType.Parse "application/measured-component+json"

    module media_control =
        let xml = MimeType.Parse "application/media_control+xml"

    module media =
        module policy =
            module dataset =
                let xml = MimeType.Parse "application/media-policy-dataset+xml"

    module mediaservercontrol =
        let xml = MimeType.Parse "application/mediaservercontrol+xml"

    module merge =
        module patch =
            let json = MimeType.Parse "application/merge-patch+json"

    module metalink4 =
        let xml = MimeType.Parse "application/metalink4+xml"

    module mets =
        let xml = MimeType.Parse "application/mets+xml"

    let MF4 = MimeType.Parse "application/MF4"
    let mikey = MimeType.Parse "application/mikey"
    let mipc = MimeType.Parse "application/mipc"

    module missing =
        module blocks =
            module cbor =
                let seq = MimeType.Parse "application/missing-blocks+cbor-seq"

    module mmt =
        module aei =
            let xml = MimeType.Parse "application/mmt-aei+xml"

        module usd =
            let xml = MimeType.Parse "application/mmt-usd+xml"

    module mods =
        let xml = MimeType.Parse "application/mods+xml"

    module moss =
        let keys = MimeType.Parse "application/moss-keys"
        let signature = MimeType.Parse "application/moss-signature"

    module mosskey =
        let data = MimeType.Parse "application/mosskey-data"
        let request = MimeType.Parse "application/mosskey-request"

    let mp21 = MimeType.Parse "application/mp21"
    let mp4 = MimeType.Parse "application/mp4"

    module mpeg4 =
        let generic = MimeType.Parse "application/mpeg4-generic"

        module iod =
            let xmt = MimeType.Parse "application/mpeg4-iod-xmt"

    module mrb =
        module consumer =
            let xml = MimeType.Parse "application/mrb-consumer+xml"

        module publish =
            let xml = MimeType.Parse "application/mrb-publish+xml"

    module msc =
        module ivr =
            let xml = MimeType.Parse "application/msc-ivr+xml"

        module mixer =
            let xml = MimeType.Parse "application/msc-mixer+xml"

    let msword = MimeType.Parse "application/msword"

    module mud =
        let json = MimeType.Parse "application/mud+json"

    module multipart =
        let core = MimeType.Parse "application/multipart-core"

    let mxf = MimeType.Parse "application/mxf"

    module n =
        let quads = MimeType.Parse "application/n-quads"
        let triples = MimeType.Parse "application/n-triples"

    let nasdata = MimeType.Parse "application/nasdata"

    module news =
        let checkgroups = MimeType.Parse "application/news-checkgroups"
        let groupinfo = MimeType.Parse "application/news-groupinfo"
        let transmission = MimeType.Parse "application/news-transmission"

    module nlsml =
        let xml = MimeType.Parse "application/nlsml+xml"

    let node = MimeType.Parse "application/node"
    let nss = MimeType.Parse "application/nss"

    module oauth =
        module authz =
            module req =
                let jwt = MimeType.Parse "application/oauth-authz-req+jwt"

    module oblivious =
        module dns =
            let message = MimeType.Parse "application/oblivious-dns-message"

    module ocsp =
        let request = MimeType.Parse "application/ocsp-request"
        let response = MimeType.Parse "application/ocsp-response"

    module octet =
        let stream = MimeType.Parse "application/octet-stream"

    let ODA = MimeType.Parse "application/ODA"

    module odm =
        let xml = MimeType.Parse "application/odm+xml"

    let ODX = MimeType.Parse "application/ODX"

    module oebps =
        module package =
            let xml = MimeType.Parse "application/oebps-package+xml"

    let ogg = MimeType.Parse "application/ogg"

    module ohttp =
        let keys = MimeType.Parse "application/ohttp-keys"

    module opc =
        module nodeset =
            let xml = MimeType.Parse "application/opc-nodeset+xml"

    let oscore = MimeType.Parse "application/oscore"
    let oxps = MimeType.Parse "application/oxps"

    module p21 =
        let zip = MimeType.Parse "application/p21+zip"

    module p2p =
        module overlay =
            let xml = MimeType.Parse "application/p2p-overlay+xml"

    let parityfec = MimeType.Parse "application/parityfec"
    let passport = MimeType.Parse "application/passport"

    module patch =
        module ops =
            module error =
                let xml = MimeType.Parse "application/patch-ops-error+xml"

    let pdf = MimeType.Parse "application/pdf"
    let PDX = MimeType.Parse "application/PDX"

    module pem =
        module certificate =
            let chain = MimeType.Parse "application/pem-certificate-chain"

    module pgp =
        let encrypted = MimeType.Parse "application/pgp-encrypted"
        let keys = MimeType.Parse "application/pgp-keys"
        let signature = MimeType.Parse "application/pgp-signature"

    module pidf =
        module diff =
            let xml = MimeType.Parse "application/pidf-diff+xml"

        let xml = MimeType.Parse "application/pidf+xml"

    let pkcs10 = MimeType.Parse "application/pkcs10"

    module pkcs7 =
        let mime = MimeType.Parse "application/pkcs7-mime"
        let signature = MimeType.Parse "application/pkcs7-signature"

    module pkcs8 =
        let encrypted = MimeType.Parse "application/pkcs8-encrypted"

    let pkcs12 = MimeType.Parse "application/pkcs12"

    module pkix =
        module attr =
            let cert = MimeType.Parse "application/pkix-attr-cert"

        let cert = MimeType.Parse "application/pkix-cert"
        let crl = MimeType.Parse "application/pkix-crl"
        let pkipath = MimeType.Parse "application/pkix-pkipath"

    let pkixcmp = MimeType.Parse "application/pkixcmp"

    module pls =
        let xml = MimeType.Parse "application/pls+xml"

    module poc =
        module settings =
            let xml = MimeType.Parse "application/poc-settings+xml"

    let postscript = MimeType.Parse "application/postscript"

    module ppsp =
        module tracker =
            let json = MimeType.Parse "application/ppsp-tracker+json"

    module private_ =
        module token =
            module issuer =
                let directory = MimeType.Parse "application/private-token-issuer-directory"

            let request = MimeType.Parse "application/private-token-request"
            let response = MimeType.Parse "application/private-token-response"

    module problem =
        let json = MimeType.Parse "application/problem+json"
        let xml = MimeType.Parse "application/problem+xml"

    module protobuf =
        let json = MimeType.Parse "application/protobuf+json"

    module provenance =
        let xml = MimeType.Parse "application/provenance+xml"

    module provided =
        module claims =
            let jwt = MimeType.Parse "application/provided-claims+jwt"

    module prs =
        module alvestrand =
            module titrax =
                let sheet = MimeType.Parse "application/prs.alvestrand.titrax-sheet"

        module archive =
            module markdown =
                let format = MimeType.Parse "application/prs.archive-markdown-format"

        let bwtc32key = MimeType.Parse "application/prs.bwtc32key"
        let cww = MimeType.Parse "application/prs.cww"
        let cyn = MimeType.Parse "application/prs.cyn"

        module hpub =
            let zip = MimeType.Parse "application/prs.hpub+zip"

        module implied =
            module document =
                let xml = MimeType.Parse "application/prs.implied-document+xml"

            let executable = MimeType.Parse "application/prs.implied-executable"

            module object =
                module json =
                    let seq = MimeType.Parse "application/prs.implied-object+json-seq"

                let yaml = MimeType.Parse "application/prs.implied-object+yaml"

            let structure = MimeType.Parse "application/prs.implied-structure"

        let mayfile = MimeType.Parse "application/prs.mayfile"
        let nprend = MimeType.Parse "application/prs.nprend"
        let plucker = MimeType.Parse "application/prs.plucker"

        module rdf =
            module xml =
                let crypt = MimeType.Parse "application/prs.rdf-xml-crypt"

        let sclt = MimeType.Parse "application/prs.sclt"
        let vcfbzip2 = MimeType.Parse "application/prs.vcfbzip2"

        module xsf =
            let xml = MimeType.Parse "application/prs.xsf+xml"

    module pskc =
        let xml = MimeType.Parse "application/pskc+xml"

    module pvd =
        let json = MimeType.Parse "application/pvd+json"

    module rdf =
        let xml = MimeType.Parse "application/rdf+xml"

    module roughtime =
        module malfeasance =
            let json = MimeType.Parse "application/roughtime-malfeasance+json"

        module server =
            let json = MimeType.Parse "application/roughtime-server+json"

    module route =
        module apd =
            let xml = MimeType.Parse "application/route-apd+xml"

        module s =
            module tsid =
                let xml = MimeType.Parse "application/route-s-tsid+xml"

        module usd =
            let xml = MimeType.Parse "application/route-usd+xml"

    module rpki =
        module ccr =
            let gzip = MimeType.Parse "application/rpki-ccr+gzip"

        let checklist = MimeType.Parse "application/rpki-checklist"
        let ghostbusters = MimeType.Parse "application/rpki-ghostbusters"
        let manifest = MimeType.Parse "application/rpki-manifest"
        let publication = MimeType.Parse "application/rpki-publication"
        let roa = MimeType.Parse "application/rpki-roa"

        module signed =
            let tal = MimeType.Parse "application/rpki-signed-tal"

        let updown = MimeType.Parse "application/rpki-updown"

    let QSIG = MimeType.Parse "application/QSIG"
    let raptorfec = MimeType.Parse "application/raptorfec"

    module rdap =
        let json = MimeType.Parse "application/rdap+json"

    module reginfo =
        let xml = MimeType.Parse "application/reginfo+xml"

    module relax =
        module ng =
            module compact =
                let syntax = MimeType.Parse "application/relax-ng-compact-syntax"

    module remote =
        let printing = MimeType.Parse "application/remote-printing"

    module reputon =
        let json = MimeType.Parse "application/reputon+json"

    module resolve =
        module response =
            let jwt = MimeType.Parse "application/resolve-response+jwt"

    module resource =
        module lists =
            module diff =
                let xml = MimeType.Parse "application/resource-lists-diff+xml"

            let xml = MimeType.Parse "application/resource-lists+xml"

    module rfc =
        let xml = MimeType.Parse "application/rfc+xml"

    let riscos = MimeType.Parse "application/riscos"

    module rlmi =
        let xml = MimeType.Parse "application/rlmi+xml"

    module rls =
        module services =
            let xml = MimeType.Parse "application/rls-services+xml"

    module rs =
        module metadata =
            let xml = MimeType.Parse "application/rs-metadata+xml"

    let rtf = MimeType.Parse "application/rtf"
    let rtploopback = MimeType.Parse "application/rtploopback"
    let rtx = MimeType.Parse "application/rtx"

    module samlassertion =
        let xml = MimeType.Parse "application/samlassertion+xml"

    module samlmetadata =
        let xml = MimeType.Parse "application/samlmetadata+xml"

    module sarif =
        module external_ =
            module properties =
                let json = MimeType.Parse "application/sarif-external-properties+json"

        let json = MimeType.Parse "application/sarif+json"

    let sbe = MimeType.Parse "application/sbe"

    module sbml =
        let xml = MimeType.Parse "application/sbml+xml"

    module scaip =
        let xml = MimeType.Parse "application/scaip+xml"

    module scim =
        let json = MimeType.Parse "application/scim+json"

    module scitt =
        module receipt =
            let cose = MimeType.Parse "application/scitt-receipt+cose"

        module statement =
            let cose = MimeType.Parse "application/scitt-statement+cose"

    module scvp =
        module cv =
            let request = MimeType.Parse "application/scvp-cv-request"
            let response = MimeType.Parse "application/scvp-cv-response"

        module vp =
            let request = MimeType.Parse "application/scvp-vp-request"
            let response = MimeType.Parse "application/scvp-vp-response"

    module sd =
        module jwt =
            let json = MimeType.Parse "application/sd-jwt+json"

    module sdf =
        let json = MimeType.Parse "application/sdf+json"

    let sdp = MimeType.Parse "application/sdp"

    module secevent =
        let jwt = MimeType.Parse "application/secevent+jwt"

    module senml =
        module etch =
            let cbor = MimeType.Parse "application/senml-etch+cbor"
            let json = MimeType.Parse "application/senml-etch+json"

        let exi = MimeType.Parse "application/senml-exi"
        let cbor = MimeType.Parse "application/senml+cbor"
        let json = MimeType.Parse "application/senml+json"
        let xml = MimeType.Parse "application/senml+xml"

    module sensml =
        let exi = MimeType.Parse "application/sensml-exi"
        let cbor = MimeType.Parse "application/sensml+cbor"
        let json = MimeType.Parse "application/sensml+json"
        let xml = MimeType.Parse "application/sensml+xml"

    module sep =
        let exi = MimeType.Parse "application/sep-exi"
        let xml = MimeType.Parse "application/sep+xml"

    module session =
        let info = MimeType.Parse "application/session-info"

    module set =
        module payment =
            let initiation = MimeType.Parse "application/set-payment-initiation"

        module registration =
            let initiation = MimeType.Parse "application/set-registration-initiation"

    let SGML = MimeType.Parse "application/SGML"

    module sgml =
        module open_ =
            let catalog = MimeType.Parse "application/sgml-open-catalog"

    module shf =
        let xml = MimeType.Parse "application/shf+xml"

    let sieve = MimeType.Parse "application/sieve"

    module simple =
        module filter =
            let xml = MimeType.Parse "application/simple-filter+xml"

        module message =
            let summary = MimeType.Parse "application/simple-message-summary"

    let simpleSymbolContainer = MimeType.Parse "application/simpleSymbolContainer"
    let sipc = MimeType.Parse "application/sipc"
    let slate = MimeType.Parse "application/slate"

    module smil =
        let xml = MimeType.Parse "application/smil+xml"

    let smpte336m = MimeType.Parse "application/smpte336m"

    module soap =
        let fastinfoset = MimeType.Parse "application/soap+fastinfoset"
        let xml = MimeType.Parse "application/soap+xml"

    module sparql =
        let query = MimeType.Parse "application/sparql-query"

        module results =
            let xml = MimeType.Parse "application/sparql-results+xml"

    module spdx =
        let json = MimeType.Parse "application/spdx+json"

    module spdx3 =
        let json = MimeType.Parse "application/spdx3+json"

    module spirits =
        module event_ =
            let xml = MimeType.Parse "application/spirits-event+xml"

    let sql = MimeType.Parse "application/sql"

    module srgs =
        let xml = MimeType.Parse "application/srgs+xml"

    module sru =
        let xml = MimeType.Parse "application/sru+xml"

    let sslkeylogfile = MimeType.Parse "application/sslkeylogfile"

    module ssml =
        let xml = MimeType.Parse "application/ssml+xml"

    module ST2110 =
        let _41 = MimeType.Parse "application/ST2110-41"

    module statuslist =
        let cwt = MimeType.Parse "application/statuslist+cwt"
        let jwt = MimeType.Parse "application/statuslist+jwt"

    module stix =
        let json = MimeType.Parse "application/stix+json"

    let stratum = MimeType.Parse "application/stratum"

    module suit =
        module envelope =
            let cose = MimeType.Parse "application/suit-envelope+cose"

        module report =
            let cose = MimeType.Parse "application/suit-report+cose"

    module swid =
        let cbor = MimeType.Parse "application/swid+cbor"
        let xml = MimeType.Parse "application/swid+xml"

    module syslog =
        let msg = MimeType.Parse "application/syslog-msg"

    module tamp =
        module apex =
            module update =
                let confirm = MimeType.Parse "application/tamp-apex-update-confirm"

        module community =
            module update =
                let confirm = MimeType.Parse "application/tamp-community-update-confirm"

        let error = MimeType.Parse "application/tamp-error"

        module sequence =
            module adjust =
                let confirm = MimeType.Parse "application/tamp-sequence-adjust-confirm"

        module status =
            let query = MimeType.Parse "application/tamp-status-query"
            let response = MimeType.Parse "application/tamp-status-response"

        module update =
            let confirm = MimeType.Parse "application/tamp-update-confirm"

    module taxii =
        let json = MimeType.Parse "application/taxii+json"

    module td =
        let json = MimeType.Parse "application/td+json"

    module teep =
        let cbor = MimeType.Parse "application/teep+cbor"

    module tei =
        let xml = MimeType.Parse "application/tei+xml"

    let TETRA_ISI = MimeType.Parse "application/TETRA_ISI"
    let texinfo = MimeType.Parse "application/texinfo"

    module thraud =
        let xml = MimeType.Parse "application/thraud+xml"

    module timestamp =
        let query = MimeType.Parse "application/timestamp-query"
        let reply = MimeType.Parse "application/timestamp-reply"

    module timestamped =
        let data = MimeType.Parse "application/timestamped-data"

    module tlsrpt =
        let gzip = MimeType.Parse "application/tlsrpt+gzip"
        let json = MimeType.Parse "application/tlsrpt+json"

    module tm =
        let json = MimeType.Parse "application/tm+json"

    let tnauthlist = MimeType.Parse "application/tnauthlist"

    module toc =
        let cbor = MimeType.Parse "application/toc+cbor"

    module token =
        module introspection =
            let jwt = MimeType.Parse "application/token-introspection+jwt"

    let toml = MimeType.Parse "application/toml"

    module trickle =
        module ice =
            let sdpfrag = MimeType.Parse "application/trickle-ice-sdpfrag"

    let trig = MimeType.Parse "application/trig"

    module trust =
        module chain =
            let json = MimeType.Parse "application/trust-chain+json"

        module mark =
            let jwt = MimeType.Parse "application/trust-mark+jwt"

            module delegation =
                let jwt = MimeType.Parse "application/trust-mark-delegation+jwt"

            module status =
                module response =
                    let jwt = MimeType.Parse "application/trust-mark-status-response+jwt"

    module ttml =
        let xml = MimeType.Parse "application/ttml+xml"

    module tve =
        let trigger = MimeType.Parse "application/tve-trigger"

    module tzif =
        let leap = MimeType.Parse "application/tzif-leap"

    module uccs =
        let cbor = MimeType.Parse "application/uccs+cbor"

    module ujcs =
        let json = MimeType.Parse "application/ujcs+json"

    let ulpfec = MimeType.Parse "application/ulpfec"

    module urc =
        module grpsheet =
            let xml = MimeType.Parse "application/urc-grpsheet+xml"

        module ressheet =
            let xml = MimeType.Parse "application/urc-ressheet+xml"

        module targetdesc =
            let xml = MimeType.Parse "application/urc-targetdesc+xml"

        module uisocketdesc =
            let xml = MimeType.Parse "application/urc-uisocketdesc+xml"

    let v3c = MimeType.Parse "application/v3c"

    module vc =
        let cose = MimeType.Parse "application/vc+cose"
        let jwt = MimeType.Parse "application/vc+jwt"

        module sd =
            let jwt = MimeType.Parse "application/vc+sd-jwt"

    module vcard =
        let json = MimeType.Parse "application/vcard+json"
        let xml = MimeType.Parse "application/vcard+xml"

    module vec =
        let xml = MimeType.Parse "application/vec+xml"

        module package =
            let gzip = MimeType.Parse "application/vec-package+gzip"
            let zip = MimeType.Parse "application/vec-package+zip"

    let vemmi = MimeType.Parse "application/vemmi"

    module voicexml =
        let xml = MimeType.Parse "application/voicexml+xml"

    module voucher =
        module cms =
            let json = MimeType.Parse "application/voucher-cms+json"

        module jws =
            let json = MimeType.Parse "application/voucher-jws+json"

    module vp =
        let cose = MimeType.Parse "application/vp+cose"
        let jwt = MimeType.Parse "application/vp+jwt"

        module sd =
            let jwt = MimeType.Parse "application/vp+sd-jwt"

    module vq =
        let rtcpxr = MimeType.Parse "application/vq-rtcpxr"

    let wasm = MimeType.Parse "application/wasm"

    module watcherinfo =
        let xml = MimeType.Parse "application/watcherinfo+xml"

    module webpush =
        module options =
            let json = MimeType.Parse "application/webpush-options+json"

    module whoispp =
        let query = MimeType.Parse "application/whoispp-query"
        let response = MimeType.Parse "application/whoispp-response"

    let widget = MimeType.Parse "application/widget"
    let wita = MimeType.Parse "application/wita"

    module wordperfect5 =
        let _1 = MimeType.Parse "application/wordperfect5.1"

    module wsdl =
        let xml = MimeType.Parse "application/wsdl+xml"

    module wspolicy =
        let xml = MimeType.Parse "application/wspolicy+xml"

    module x =
        module pki =
            let message = MimeType.Parse "application/x-pki-message"

        module www =
            module form =
                let urlencoded = MimeType.Parse "application/x-www-form-urlencoded"

        module x509 =
            module ca =
                let cert = MimeType.Parse "application/x-x509-ca-cert"

                module ra =
                    let cert = MimeType.Parse "application/x-x509-ca-ra-cert"

            module next =
                module ca =
                    let cert = MimeType.Parse "application/x-x509-next-ca-cert"

    module x400 =
        let bp = MimeType.Parse "application/x400-bp"

    module xacml =
        let xml = MimeType.Parse "application/xacml+xml"

    module xcap =
        module att =
            let xml = MimeType.Parse "application/xcap-att+xml"

        module caps =
            let xml = MimeType.Parse "application/xcap-caps+xml"

        module diff =
            let xml = MimeType.Parse "application/xcap-diff+xml"

        module el =
            let xml = MimeType.Parse "application/xcap-el+xml"

        module error =
            let xml = MimeType.Parse "application/xcap-error+xml"

        module ns =
            let xml = MimeType.Parse "application/xcap-ns+xml"

    module xcon =
        module conference =
            module info =
                module diff =
                    let xml = MimeType.Parse "application/xcon-conference-info-diff+xml"

                let xml = MimeType.Parse "application/xcon-conference-info+xml"

    module xenc =
        let xml = MimeType.Parse "application/xenc+xml"

    let xfdf = MimeType.Parse "application/xfdf"

    module xhtml =
        let xml = MimeType.Parse "application/xhtml+xml"

    module xliff =
        let xml = MimeType.Parse "application/xliff+xml"

    module xml =
        let dtd = MimeType.Parse "application/xml-dtd"

        module external_ =
            module parsed =
                let entity = MimeType.Parse "application/xml-external-parsed-entity"

        module patch =
            let xml = MimeType.Parse "application/xml-patch+xml"

    module xmpp =
        let xml = MimeType.Parse "application/xmpp+xml"

    module xop =
        let xml = MimeType.Parse "application/xop+xml"

    module xslt =
        let xml = MimeType.Parse "application/xslt+xml"

    module xv =
        let xml = MimeType.Parse "application/xv+xml"

    let yaml = MimeType.Parse "application/yaml"

    module yang =
        module data =
            let cbor = MimeType.Parse "application/yang-data+cbor"
            let json = MimeType.Parse "application/yang-data+json"
            let xml = MimeType.Parse "application/yang-data+xml"

        module patch =
            let json = MimeType.Parse "application/yang-patch+json"
            let xml = MimeType.Parse "application/yang-patch+xml"

        module sid =
            let json = MimeType.Parse "application/yang-sid+json"

    module yin =
        let xml = MimeType.Parse "application/yin+xml"

    let zip = MimeType.Parse "application/zip"
    let zlib = MimeType.Parse "application/zlib"
    let zstd = MimeType.Parse "application/zstd"

module audio =
    module _1d =
        module interleaved =
            let parityfec = MimeType.Parse "audio/1d-interleaved-parityfec"

    let _32kadpcm = MimeType.Parse "audio/32kadpcm"
    let _3gpp = MimeType.Parse "audio/3gpp"
    let _3gpp2 = MimeType.Parse "audio/3gpp2"
    let aac = MimeType.Parse "audio/aac"
    let ac3 = MimeType.Parse "audio/ac3"

    module AMR =
        let WB = MimeType.Parse "audio/AMR-WB"

    module amr =
        let wb = MimeType.Parse "audio/amr-wb+"

    let aptx = MimeType.Parse "audio/aptx"
    let asc = MimeType.Parse "audio/asc"

    module ATRAC =
        module ADVANCED =
            let LOSSLESS = MimeType.Parse "audio/ATRAC-ADVANCED-LOSSLESS"

        let X = MimeType.Parse "audio/ATRAC-X"

    let ATRAC3 = MimeType.Parse "audio/ATRAC3"
    let basic = MimeType.Parse "audio/basic"
    let BV16 = MimeType.Parse "audio/BV16"
    let BV32 = MimeType.Parse "audio/BV32"
    let clearmode = MimeType.Parse "audio/clearmode"
    let CN = MimeType.Parse "audio/CN"
    let DAT12 = MimeType.Parse "audio/DAT12"
    let dls = MimeType.Parse "audio/dls"

    module dsr =
        let es201108 = MimeType.Parse "audio/dsr-es201108"
        let es202050 = MimeType.Parse "audio/dsr-es202050"
        let es202211 = MimeType.Parse "audio/dsr-es202211"
        let es202212 = MimeType.Parse "audio/dsr-es202212"

    let DV = MimeType.Parse "audio/DV"
    let DVI4 = MimeType.Parse "audio/DVI4"
    let eac3 = MimeType.Parse "audio/eac3"
    let encaprtp = MimeType.Parse "audio/encaprtp"

    module EVRC =
        let QCP = MimeType.Parse "audio/EVRC-QCP"

    let EVRC0 = MimeType.Parse "audio/EVRC0"
    let EVRC1 = MimeType.Parse "audio/EVRC1"
    let EVRCB = MimeType.Parse "audio/EVRCB"
    let EVRCB0 = MimeType.Parse "audio/EVRCB0"
    let EVRCB1 = MimeType.Parse "audio/EVRCB1"
    let EVRCNW = MimeType.Parse "audio/EVRCNW"
    let EVRCNW0 = MimeType.Parse "audio/EVRCNW0"
    let EVRCNW1 = MimeType.Parse "audio/EVRCNW1"
    let EVRCWB = MimeType.Parse "audio/EVRCWB"
    let EVRCWB0 = MimeType.Parse "audio/EVRCWB0"
    let EVRCWB1 = MimeType.Parse "audio/EVRCWB1"
    let EVS = MimeType.Parse "audio/EVS"
    let example = MimeType.Parse "audio/example"
    let flac = MimeType.Parse "audio/flac"
    let flexfec = MimeType.Parse "audio/flexfec"
    let fwdred = MimeType.Parse "audio/fwdred"

    module G711 =
        let _0 = MimeType.Parse "audio/G711-0"

    let G719 = MimeType.Parse "audio/G719"
    let G7221 = MimeType.Parse "audio/G7221"
    let G722 = MimeType.Parse "audio/G722"
    let G723 = MimeType.Parse "audio/G723"

    module G726 =
        let _16 = MimeType.Parse "audio/G726-16"
        let _24 = MimeType.Parse "audio/G726-24"
        let _32 = MimeType.Parse "audio/G726-32"
        let _40 = MimeType.Parse "audio/G726-40"

    let G728 = MimeType.Parse "audio/G728"
    let G729 = MimeType.Parse "audio/G729"
    let G7291 = MimeType.Parse "audio/G7291"
    let G729D = MimeType.Parse "audio/G729D"
    let G729E = MimeType.Parse "audio/G729E"

    module GSM =
        let EFR = MimeType.Parse "audio/GSM-EFR"

        module HR =
            let _08 = MimeType.Parse "audio/GSM-HR-08"

    let iLBC = MimeType.Parse "audio/iLBC"

    module ip =
        module mr_v2 =
            let _5 = MimeType.Parse "audio/ip-mr_v2.5"

    let L8 = MimeType.Parse "audio/L8"
    let L16 = MimeType.Parse "audio/L16"
    let L20 = MimeType.Parse "audio/L20"
    let L24 = MimeType.Parse "audio/L24"
    let LPC = MimeType.Parse "audio/LPC"
    let matroska = MimeType.Parse "audio/matroska"
    let MELP = MimeType.Parse "audio/MELP"
    let MELP600 = MimeType.Parse "audio/MELP600"
    let MELP1200 = MimeType.Parse "audio/MELP1200"
    let MELP2400 = MimeType.Parse "audio/MELP2400"
    let mhas = MimeType.Parse "audio/mhas"

    module midi =
        let clip = MimeType.Parse "audio/midi-clip"

    module mobile =
        let xmf = MimeType.Parse "audio/mobile-xmf"

    let MPA = MimeType.Parse "audio/MPA"
    let mp4 = MimeType.Parse "audio/mp4"

    module MP4A =
        let LATM = MimeType.Parse "audio/MP4A-LATM"

    module mpa =
        let robust = MimeType.Parse "audio/mpa-robust"

    let mpeg = MimeType.Parse "audio/mpeg"

    module mpeg4 =
        let generic = MimeType.Parse "audio/mpeg4-generic"

    let ogg = MimeType.Parse "audio/ogg"
    let opus = MimeType.Parse "audio/opus"
    let parityfec = MimeType.Parse "audio/parityfec"

    module PCMA =
        let WB = MimeType.Parse "audio/PCMA-WB"

    module PCMU =
        let WB = MimeType.Parse "audio/PCMU-WB"

    module prs =
        let aaud = MimeType.Parse "audio/prs.aaud"
        let sid = MimeType.Parse "audio/prs.sid"

    let QCELP = MimeType.Parse "audio/QCELP"
    let raptorfec = MimeType.Parse "audio/raptorfec"
    let RED = MimeType.Parse "audio/RED"

    module rtp =
        module enc =
            let aescm128 = MimeType.Parse "audio/rtp-enc-aescm128"

        let midi = MimeType.Parse "audio/rtp-midi"

    let rtploopback = MimeType.Parse "audio/rtploopback"
    let rtx = MimeType.Parse "audio/rtx"
    let scip = MimeType.Parse "audio/scip"

    module SMV =
        let QCP = MimeType.Parse "audio/SMV-QCP"

    let SMV0 = MimeType.Parse "audio/SMV0"
    let sofa = MimeType.Parse "audio/sofa"
    let soundfont = MimeType.Parse "audio/soundfont"

    module sp =
        let midi = MimeType.Parse "audio/sp-midi"

    let speex = MimeType.Parse "audio/speex"
    let t140c = MimeType.Parse "audio/t140c"
    let t38 = MimeType.Parse "audio/t38"

    module telephone =
        let event_ = MimeType.Parse "audio/telephone-event"

    let TETRA_ACELP = MimeType.Parse "audio/TETRA_ACELP"
    let TETRA_ACELP_BB = MimeType.Parse "audio/TETRA_ACELP_BB"
    let tone = MimeType.Parse "audio/tone"
    let TSVCIS = MimeType.Parse "audio/TSVCIS"
    let UEMCLIP = MimeType.Parse "audio/UEMCLIP"
    let ulpfec = MimeType.Parse "audio/ulpfec"
    let usac = MimeType.Parse "audio/usac"
    let VDVI = MimeType.Parse "audio/VDVI"

    module VMR =
        let WB = MimeType.Parse "audio/VMR-WB"

    module vnd =
        module _3gpp =
            let iufp = MimeType.Parse "audio/vnd.3gpp.iufp"

        let _4SB = MimeType.Parse "audio/vnd.4SB"
        let audiokoz = MimeType.Parse "audio/vnd.audiokoz"

        module blockfact =
            let facta = MimeType.Parse "audio/vnd.blockfact.facta"

        let CELP = MimeType.Parse "audio/vnd.CELP"

        module cisco =
            let nse = MimeType.Parse "audio/vnd.cisco.nse"

        module cmles =
            module radio =
                let events = MimeType.Parse "audio/vnd.cmles.radio-events"

        module cns =
            let anp1 = MimeType.Parse "audio/vnd.cns.anp1"
            let inf1 = MimeType.Parse "audio/vnd.cns.inf1"

        module dece =
            let audio = MimeType.Parse "audio/vnd.dece.audio"

        module digital =
            let winds = MimeType.Parse "audio/vnd.digital-winds"

        module dlna =
            let adts = MimeType.Parse "audio/vnd.dlna.adts"

        module dolby =
            module heaac =
                let _1 = MimeType.Parse "audio/vnd.dolby.heaac.1"
                let _2 = MimeType.Parse "audio/vnd.dolby.heaac.2"

            let mlp = MimeType.Parse "audio/vnd.dolby.mlp"
            let mps = MimeType.Parse "audio/vnd.dolby.mps"
            let pl2 = MimeType.Parse "audio/vnd.dolby.pl2"
            let pl2x = MimeType.Parse "audio/vnd.dolby.pl2x"
            let pl2z = MimeType.Parse "audio/vnd.dolby.pl2z"

            module pulse =
                let _1 = MimeType.Parse "audio/vnd.dolby.pulse.1"

        let dra = MimeType.Parse "audio/vnd.dra"

        module dts =
            let hd = MimeType.Parse "audio/vnd.dts.hd"
            let uhd = MimeType.Parse "audio/vnd.dts.uhd"

        module dvb =
            let file = MimeType.Parse "audio/vnd.dvb.file"

        module everad =
            let plj = MimeType.Parse "audio/vnd.everad.plj"

        module hns =
            let audio = MimeType.Parse "audio/vnd.hns.audio"

        module lucent =
            let voice = MimeType.Parse "audio/vnd.lucent.voice"

        module ms =
            module playready =
                module media =
                    let pya = MimeType.Parse "audio/vnd.ms-playready.media.pya"

        module nokia =
            module mobile =
                let xmf = MimeType.Parse "audio/vnd.nokia.mobile-xmf"

        module nortel =
            let vbk = MimeType.Parse "audio/vnd.nortel.vbk"

        module nuera =
            let ecelp4800 = MimeType.Parse "audio/vnd.nuera.ecelp4800"
            let ecelp7470 = MimeType.Parse "audio/vnd.nuera.ecelp7470"
            let ecelp9600 = MimeType.Parse "audio/vnd.nuera.ecelp9600"

        module octel =
            let sbc = MimeType.Parse "audio/vnd.octel.sbc"

        module opennbs =
            let nbs = MimeType.Parse "audio/vnd.opennbs.nbs"

        module presonus =
            let multitrack = MimeType.Parse "audio/vnd.presonus.multitrack"

        let qcelp = MimeType.Parse "audio/vnd.qcelp"

        module rhetorex =
            let _32kadpcm = MimeType.Parse "audio/vnd.rhetorex.32kadpcm"

        let rip = MimeType.Parse "audio/vnd.rip"

        module sealedmedia =
            module softseal =
                let mpeg = MimeType.Parse "audio/vnd.sealedmedia.softseal.mpeg"

        module vmx =
            let cvsd = MimeType.Parse "audio/vnd.vmx.cvsd"

    module vorbis =
        let config = MimeType.Parse "audio/vorbis-config"

module font =
    let collection = MimeType.Parse "font/collection"
    let otf = MimeType.Parse "font/otf"
    let sfnt = MimeType.Parse "font/sfnt"
    let ttf = MimeType.Parse "font/ttf"
    let woff = MimeType.Parse "font/woff"
    let woff2 = MimeType.Parse "font/woff2"

module haptics =
    let ivs = MimeType.Parse "haptics/ivs"
    let hjif = MimeType.Parse "haptics/hjif"
    let hmpg = MimeType.Parse "haptics/hmpg"

module image =
    let aces = MimeType.Parse "image/aces"
    let apng = MimeType.Parse "image/apng"
    let avci = MimeType.Parse "image/avci"
    let avcs = MimeType.Parse "image/avcs"
    let avif = MimeType.Parse "image/avif"
    let bmp = MimeType.Parse "image/bmp"
    let cgm = MimeType.Parse "image/cgm"

    module dicom =
        let rle = MimeType.Parse "image/dicom-rle"

    let dpx = MimeType.Parse "image/dpx"
    let emf = MimeType.Parse "image/emf"
    let example = MimeType.Parse "image/example"
    let fits = MimeType.Parse "image/fits"
    let g3fax = MimeType.Parse "image/g3fax"
    let gif = MimeType.Parse "image/gif"

    module heic =
        let sequence = MimeType.Parse "image/heic-sequence"

    module heif =
        let sequence = MimeType.Parse "image/heif-sequence"

    let hej2k = MimeType.Parse "image/hej2k"
    let hsj2 = MimeType.Parse "image/hsj2"
    let ief = MimeType.Parse "image/ief"
    let j2c = MimeType.Parse "image/j2c"
    let jaii = MimeType.Parse "image/jaii"
    let jais = MimeType.Parse "image/jais"
    let jls = MimeType.Parse "image/jls"
    let jp2 = MimeType.Parse "image/jp2"
    let jpeg = MimeType.Parse "image/jpeg"
    let jph = MimeType.Parse "image/jph"
    let jphc = MimeType.Parse "image/jphc"
    let jpm = MimeType.Parse "image/jpm"
    let jpx = MimeType.Parse "image/jpx"
    let jxl = MimeType.Parse "image/jxl"
    let jxr = MimeType.Parse "image/jxr"
    let jxrA = MimeType.Parse "image/jxrA"
    let jxrS = MimeType.Parse "image/jxrS"
    let jxs = MimeType.Parse "image/jxs"
    let jxsc = MimeType.Parse "image/jxsc"
    let jxsi = MimeType.Parse "image/jxsi"
    let jxss = MimeType.Parse "image/jxss"
    let ktx = MimeType.Parse "image/ktx"
    let ktx2 = MimeType.Parse "image/ktx2"
    let naplps = MimeType.Parse "image/naplps"
    let png = MimeType.Parse "image/png"

    module prs =
        let aimg = MimeType.Parse "image/prs.aimg"
        let btif = MimeType.Parse "image/prs.btif"
        let pti = MimeType.Parse "image/prs.pti"

    module pwg =
        let raster = MimeType.Parse "image/pwg-raster"

    module svg =
        let xml = MimeType.Parse "image/svg+xml"

    let t38 = MimeType.Parse "image/t38"

    module tiff =
        let fx = MimeType.Parse "image/tiff-fx"

    module vnd =
        module adobe =
            let photoshop = MimeType.Parse "image/vnd.adobe.photoshop"

        module airzip =
            module accelerator =
                let azv = MimeType.Parse "image/vnd.airzip.accelerator.azv"

        module blockfact =
            let facti = MimeType.Parse "image/vnd.blockfact.facti"

        let clip = MimeType.Parse "image/vnd.clip"

        module cns =
            let inf2 = MimeType.Parse "image/vnd.cns.inf2"

        module dece =
            let graphic = MimeType.Parse "image/vnd.dece.graphic"

        let djvu = MimeType.Parse "image/vnd.djvu"
        let dwg = MimeType.Parse "image/vnd.dwg"
        let dxf = MimeType.Parse "image/vnd.dxf"

        module dvb =
            let subtitle = MimeType.Parse "image/vnd.dvb.subtitle"

        let fastbidsheet = MimeType.Parse "image/vnd.fastbidsheet"
        let fpx = MimeType.Parse "image/vnd.fpx"
        let fst = MimeType.Parse "image/vnd.fst"

        module fujixerox =
            module edmics =
                let mmr = MimeType.Parse "image/vnd.fujixerox.edmics-mmr"
                let rlc = MimeType.Parse "image/vnd.fujixerox.edmics-rlc"

        module globalgraphics =
            let pgb = MimeType.Parse "image/vnd.globalgraphics.pgb"

        module microsoft =
            let icon = MimeType.Parse "image/vnd.microsoft.icon"

        let mix = MimeType.Parse "image/vnd.mix"

        module ms =
            let modi = MimeType.Parse "image/vnd.ms-modi"

        module mozilla =
            let apng = MimeType.Parse "image/vnd.mozilla.apng"

        module net =
            let fpx = MimeType.Parse "image/vnd.net-fpx"

        module pco =
            let b16 = MimeType.Parse "image/vnd.pco.b16"

        let radiance = MimeType.Parse "image/vnd.radiance"

        module sealed_ =
            let png = MimeType.Parse "image/vnd.sealed.png"

        module sealedmedia =
            module softseal =
                let gif = MimeType.Parse "image/vnd.sealedmedia.softseal.gif"
                let jpg = MimeType.Parse "image/vnd.sealedmedia.softseal.jpg"

        let sld = MimeType.Parse "image/vnd.sld"
        let svf = MimeType.Parse "image/vnd.svf"

        module tencent =
            let tap = MimeType.Parse "image/vnd.tencent.tap"

        module valve =
            module source =
                let texture = MimeType.Parse "image/vnd.valve.source.texture"

        module wap =
            let wbmp = MimeType.Parse "image/vnd.wap.wbmp"

        let xiff = MimeType.Parse "image/vnd.xiff"

        module zbrush =
            let pcx = MimeType.Parse "image/vnd.zbrush.pcx"

    let webp = MimeType.Parse "image/webp"
    let wmf = MimeType.Parse "image/wmf"

module message =
    let bhttp = MimeType.Parse "message/bhttp"
    let CPIM = MimeType.Parse "message/CPIM"

    module delivery =
        let status = MimeType.Parse "message/delivery-status"

    module disposition =
        let notification = MimeType.Parse "message/disposition-notification"

    let example = MimeType.Parse "message/example"

    module external_ =
        let body = MimeType.Parse "message/external-body"

    module feedback =
        let report = MimeType.Parse "message/feedback-report"

    module global_ =
        module delivery =
            let status = MimeType.Parse "message/global-delivery-status"

        module disposition =
            let notification = MimeType.Parse "message/global-disposition-notification"

        let headers = MimeType.Parse "message/global-headers"

    let http = MimeType.Parse "message/http"

    module imdn =
        let xml = MimeType.Parse "message/imdn+xml"

    let mls = MimeType.Parse "message/mls"
    let news = MimeType.Parse "message/news"

    module ohttp =
        module chunked =
            let req = MimeType.Parse "message/ohttp-chunked-req"
            let res = MimeType.Parse "message/ohttp-chunked-res"

        let req = MimeType.Parse "message/ohttp-req"
        let res = MimeType.Parse "message/ohttp-res"

    let partial = MimeType.Parse "message/partial"
    let rfc822 = MimeType.Parse "message/rfc822"

    module s =
        let http = MimeType.Parse "message/s-http"

    let sip = MimeType.Parse "message/sip"
    let sipfrag = MimeType.Parse "message/sipfrag"

    module tracking =
        let status = MimeType.Parse "message/tracking-status"

    module vnd =
        module si =
            let simp = MimeType.Parse "message/vnd.si.simp"

        module wfa =
            let wsc = MimeType.Parse "message/vnd.wfa.wsc"

module model =
    let _3mf = MimeType.Parse "model/3mf"
    let e57 = MimeType.Parse "model/e57"
    let example = MimeType.Parse "model/example"

    module gltf =
        let binary = MimeType.Parse "model/gltf-binary"
        let json = MimeType.Parse "model/gltf+json"

    let JT = MimeType.Parse "model/JT"
    let iges = MimeType.Parse "model/iges"
    let mesh = MimeType.Parse "model/mesh"
    let mtl = MimeType.Parse "model/mtl"
    let obj = MimeType.Parse "model/obj"
    let prc = MimeType.Parse "model/prc"

    module step =
        module xml =
            let zip = MimeType.Parse "model/step-xml+zip"

        let zip = MimeType.Parse "model/step+zip"

    let stl = MimeType.Parse "model/stl"
    let u3d = MimeType.Parse "model/u3d"

    module vnd =
        let bary = MimeType.Parse "model/vnd.bary"
        let cld = MimeType.Parse "model/vnd.cld"

        module collada =
            let xml = MimeType.Parse "model/vnd.collada+xml"

        let dwf = MimeType.Parse "model/vnd.dwf"

        module flatland =
            let _3dml = MimeType.Parse "model/vnd.flatland.3dml"

        let gdl = MimeType.Parse "model/vnd.gdl"

        module gs =
            let gdl = MimeType.Parse "model/vnd.gs-gdl"

        let gtw = MimeType.Parse "model/vnd.gtw"

        module moml =
            let xml = MimeType.Parse "model/vnd.moml+xml"

        let mts = MimeType.Parse "model/vnd.mts"
        let opengex = MimeType.Parse "model/vnd.opengex"

        module parasolid =
            module transmit =
                let binary = MimeType.Parse "model/vnd.parasolid.transmit.binary"
                let text = MimeType.Parse "model/vnd.parasolid.transmit.text"

        module pytha =
            let pyox = MimeType.Parse "model/vnd.pytha.pyox"

        module rosette =
            module annotated =
                module data =
                    let model = MimeType.Parse "model/vnd.rosette.annotated-data-model"

        module sap =
            let vds = MimeType.Parse "model/vnd.sap.vds"

        module sdf3d =
            let s3d = MimeType.Parse "model/vnd.sdf3d.s3d"

        let usda = MimeType.Parse "model/vnd.usda"

        module usdz =
            let zip = MimeType.Parse "model/vnd.usdz+zip"

        module valve =
            module source =
                module compiled =
                    let map = MimeType.Parse "model/vnd.valve.source.compiled-map"

        let vtu = MimeType.Parse "model/vnd.vtu"

    let vrml = MimeType.Parse "model/vrml"

    module x3d =
        let vrml = MimeType.Parse "model/x3d-vrml"
        let fastinfoset = MimeType.Parse "model/x3d+fastinfoset"
        let xml = MimeType.Parse "model/x3d+xml"

module multipart =
    let alternative = MimeType.Parse "multipart/alternative"
    let appledouble = MimeType.Parse "multipart/appledouble"
    let byteranges = MimeType.Parse "multipart/byteranges"
    let digest = MimeType.Parse "multipart/digest"
    let encrypted = MimeType.Parse "multipart/encrypted"
    let example = MimeType.Parse "multipart/example"

    module form =
        let data = MimeType.Parse "multipart/form-data"

    module header =
        let set = MimeType.Parse "multipart/header-set"

    let mixed = MimeType.Parse "multipart/mixed"
    let multilingual = MimeType.Parse "multipart/multilingual"
    let parallel_ = MimeType.Parse "multipart/parallel"
    let related = MimeType.Parse "multipart/related"
    let report = MimeType.Parse "multipart/report"
    let signed = MimeType.Parse "multipart/signed"

    module vnd =
        module bint =
            module med =
                let plus = MimeType.Parse "multipart/vnd.bint.med-plus"

    module voice =
        let message = MimeType.Parse "multipart/voice-message"

    module x =
        module mixed =
            let replace = MimeType.Parse "multipart/x-mixed-replace"

module text =
    module _1d =
        module interleaved =
            let parityfec = MimeType.Parse "text/1d-interleaved-parityfec"

    module cache =
        let manifest = MimeType.Parse "text/cache-manifest"

    let calendar = MimeType.Parse "text/calendar"

    module cql =
        let expression = MimeType.Parse "text/cql-expression"
        let identifier = MimeType.Parse "text/cql-identifier"

    let css = MimeType.Parse "text/css"

    module csv =
        let schema = MimeType.Parse "text/csv-schema"

    let directory = MimeType.Parse "text/directory"
    let dns = MimeType.Parse "text/dns"
    let ecmascript = MimeType.Parse "text/ecmascript"
    let encaprtp = MimeType.Parse "text/encaprtp"
    let enriched = MimeType.Parse "text/enriched"
    let example = MimeType.Parse "text/example"
    let fhirpath = MimeType.Parse "text/fhirpath"
    let flexfec = MimeType.Parse "text/flexfec"
    let fwdred = MimeType.Parse "text/fwdred"
    let gff3 = MimeType.Parse "text/gff3"

    module grammar =
        module ref =
            let list = MimeType.Parse "text/grammar-ref-list"

    let hl7v2 = MimeType.Parse "text/hl7v2"
    let html = MimeType.Parse "text/html"
    let javascript = MimeType.Parse "text/javascript"

    module jcr =
        let cnd = MimeType.Parse "text/jcr-cnd"

    let markdown = MimeType.Parse "text/markdown"
    let mizar = MimeType.Parse "text/mizar"
    let n3 = MimeType.Parse "text/n3"
    let org = MimeType.Parse "text/org"
    let parameters = MimeType.Parse "text/parameters"
    let parityfec = MimeType.Parse "text/parityfec"
    let plain = MimeType.Parse "text/plain"

    module provenance =
        let notation = MimeType.Parse "text/provenance-notation"

    module prs =
        module fallenstein =
            let rst = MimeType.Parse "text/prs.fallenstein.rst"

        module lines =
            let tag = MimeType.Parse "text/prs.lines.tag"

        module prop =
            let logic = MimeType.Parse "text/prs.prop.logic"

        let texi = MimeType.Parse "text/prs.texi"

    let qml = MimeType.Parse "text/qml"
    let raptorfec = MimeType.Parse "text/raptorfec"
    let RED = MimeType.Parse "text/RED"

    module rfc822 =
        let headers = MimeType.Parse "text/rfc822-headers"

    let richtext = MimeType.Parse "text/richtext"
    let rtf = MimeType.Parse "text/rtf"

    module rtp =
        module enc =
            let aescm128 = MimeType.Parse "text/rtp-enc-aescm128"

    let rtploopback = MimeType.Parse "text/rtploopback"
    let rtx = MimeType.Parse "text/rtx"
    let SGML = MimeType.Parse "text/SGML"
    let shaclc = MimeType.Parse "text/shaclc"
    let shex = MimeType.Parse "text/shex"
    let spdx = MimeType.Parse "text/spdx"
    let strings = MimeType.Parse "text/strings"
    let t140 = MimeType.Parse "text/t140"

    module tab =
        module separated =
            let values = MimeType.Parse "text/tab-separated-values"

    let troff = MimeType.Parse "text/troff"
    let turtle = MimeType.Parse "text/turtle"
    let ulpfec = MimeType.Parse "text/ulpfec"

    module uri =
        let list = MimeType.Parse "text/uri-list"

    let vcard = MimeType.Parse "text/vcard"

    module vnd =
        let a = MimeType.Parse "text/vnd.a"
        let abc = MimeType.Parse "text/vnd.abc"

        module ascii =
            let art = MimeType.Parse "text/vnd.ascii-art"

        let bovnar = MimeType.Parse "text/vnd.bovnar"
        let curl = MimeType.Parse "text/vnd.curl"

        module debian =
            let copyright = MimeType.Parse "text/vnd.debian.copyright"

        let DMClientScript = MimeType.Parse "text/vnd.DMClientScript"

        module dvb =
            let subtitle = MimeType.Parse "text/vnd.dvb.subtitle"

        module esmertec =
            module theme =
                let descriptor = MimeType.Parse "text/vnd.esmertec.theme-descriptor"

        let exchangeable = MimeType.Parse "text/vnd.exchangeable"

        module familysearch =
            let gedcom = MimeType.Parse "text/vnd.familysearch.gedcom"

        module ficlab =
            let flt = MimeType.Parse "text/vnd.ficlab.flt"

        let fly = MimeType.Parse "text/vnd.fly"

        module fmi =
            let flexstor = MimeType.Parse "text/vnd.fmi.flexstor"

        module gist =
            let mx = MimeType.Parse "text/vnd.gist.mx"

        let gml = MimeType.Parse "text/vnd.gml"
        let graphviz = MimeType.Parse "text/vnd.graphviz"
        let hans = MimeType.Parse "text/vnd.hans"
        let hekaya = MimeType.Parse "text/vnd.hekaya"
        let hgl = MimeType.Parse "text/vnd.hgl"

        module in3d =
            let _3dml = MimeType.Parse "text/vnd.in3d.3dml"
            let spot = MimeType.Parse "text/vnd.in3d.spot"

        module IPTC =
            let NewsML = MimeType.Parse "text/vnd.IPTC.NewsML"
            let NITF = MimeType.Parse "text/vnd.IPTC.NITF"

        module latex =
            let z = MimeType.Parse "text/vnd.latex-z"

        let longform = MimeType.Parse "text/vnd.longform"

        module motorola =
            let reflex = MimeType.Parse "text/vnd.motorola.reflex"

        module ms =
            let mediapackage = MimeType.Parse "text/vnd.ms-mediapackage"

        module net2phone =
            module commcenter =
                let command = MimeType.Parse "text/vnd.net2phone.commcenter.command"

        module radisys =
            module msml =
                module basic =
                    let layout = MimeType.Parse "text/vnd.radisys.msml-basic-layout"

        module senx =
            let warpscript = MimeType.Parse "text/vnd.senx.warpscript"

        module si =
            let uricatalogue = MimeType.Parse "text/vnd.si.uricatalogue"

        module sun =
            module j2me =
                module app =
                    let descriptor = MimeType.Parse "text/vnd.sun.j2me.app-descriptor"

        let sosi = MimeType.Parse "text/vnd.sosi"
        let tps = MimeType.Parse "text/vnd.tps"
        let typst = MimeType.Parse "text/vnd.typst"

        module trolltech =
            let linguist = MimeType.Parse "text/vnd.trolltech.linguist"

        let vcf = MimeType.Parse "text/vnd.vcf"
        let vri = MimeType.Parse "text/vnd.vri"

        module wap =
            let si = MimeType.Parse "text/vnd.wap.si"
            let sl = MimeType.Parse "text/vnd.wap.sl"
            let wml = MimeType.Parse "text/vnd.wap.wml"
            let wmlscript = MimeType.Parse "text/vnd.wap.wmlscript"

        module zoo =
            let kcl = MimeType.Parse "text/vnd.zoo.kcl"

    let vtt = MimeType.Parse "text/vtt"
    let wgsl = MimeType.Parse "text/wgsl"

    module xml =
        module external_ =
            module parsed =
                let entity = MimeType.Parse "text/xml-external-parsed-entity"

module video =
    module _1d =
        module interleaved =
            let parityfec = MimeType.Parse "video/1d-interleaved-parityfec"

    module _3gpp =
        let tt = MimeType.Parse "video/3gpp-tt"

    let _3gpp2 = MimeType.Parse "video/3gpp2"
    let AV1 = MimeType.Parse "video/AV1"
    let BMPEG = MimeType.Parse "video/BMPEG"
    let BT656 = MimeType.Parse "video/BT656"
    let CelB = MimeType.Parse "video/CelB"
    let DV = MimeType.Parse "video/DV"
    let encaprtp = MimeType.Parse "video/encaprtp"
    let evc = MimeType.Parse "video/evc"
    let example = MimeType.Parse "video/example"
    let FFV1 = MimeType.Parse "video/FFV1"
    let flexfec = MimeType.Parse "video/flexfec"
    let H261 = MimeType.Parse "video/H261"

    module H263 =
        let _1998 = MimeType.Parse "video/H263-1998"
        let _2000 = MimeType.Parse "video/H263-2000"

    module H264 =
        let RCDO = MimeType.Parse "video/H264-RCDO"
        let SVC = MimeType.Parse "video/H264-SVC"

    let H265 = MimeType.Parse "video/H265"
    let H266 = MimeType.Parse "video/H266"

    module iso =
        let segment = MimeType.Parse "video/iso.segment"

    let JPEG = MimeType.Parse "video/JPEG"

    module jpeg2000 =
        let scl = MimeType.Parse "video/jpeg2000-scl"

    let jxsv = MimeType.Parse "video/jxsv"

    module lottie =
        let json = MimeType.Parse "video/lottie+json"

    module matroska =
        let _3d = MimeType.Parse "video/matroska-3d"

    let mj2 = MimeType.Parse "video/mj2"
    let MP1S = MimeType.Parse "video/MP1S"
    let MP2P = MimeType.Parse "video/MP2P"
    let MP2T = MimeType.Parse "video/MP2T"
    let mp4 = MimeType.Parse "video/mp4"

    module MP4V =
        let ES = MimeType.Parse "video/MP4V-ES"

    let MPV = MimeType.Parse "video/MPV"
    let mpeg = MimeType.Parse "video/mpeg"

    module mpeg4 =
        let generic = MimeType.Parse "video/mpeg4-generic"

    let nv = MimeType.Parse "video/nv"
    let ogg = MimeType.Parse "video/ogg"
    let parityfec = MimeType.Parse "video/parityfec"
    let pointer = MimeType.Parse "video/pointer"

    module prs =
        let avid = MimeType.Parse "video/prs.avid"

    let quicktime = MimeType.Parse "video/quicktime"
    let raptorfec = MimeType.Parse "video/raptorfec"
    let raw = MimeType.Parse "video/raw"

    module rtp =
        module enc =
            let aescm128 = MimeType.Parse "video/rtp-enc-aescm128"

    let rtploopback = MimeType.Parse "video/rtploopback"
    let rtx = MimeType.Parse "video/rtx"
    let scip = MimeType.Parse "video/scip"
    let smpte291 = MimeType.Parse "video/smpte291"
    let SMPTE292M = MimeType.Parse "video/SMPTE292M"
    let ulpfec = MimeType.Parse "video/ulpfec"
    let vc1 = MimeType.Parse "video/vc1"
    let vc2 = MimeType.Parse "video/vc2"

    module vnd =
        module blockfact =
            let factv = MimeType.Parse "video/vnd.blockfact.factv"

        let CCTV = MimeType.Parse "video/vnd.CCTV"

        module dece =
            let hd = MimeType.Parse "video/vnd.dece.hd"
            let mobile = MimeType.Parse "video/vnd.dece.mobile"
            let mp4 = MimeType.Parse "video/vnd.dece.mp4"
            let pd = MimeType.Parse "video/vnd.dece.pd"
            let sd = MimeType.Parse "video/vnd.dece.sd"
            let video = MimeType.Parse "video/vnd.dece.video"

        module directv =
            module mpeg =
                let tts = MimeType.Parse "video/vnd.directv.mpeg-tts"

        module dlna =
            module mpeg =
                let tts = MimeType.Parse "video/vnd.dlna.mpeg-tts"

        module dvb =
            let file = MimeType.Parse "video/vnd.dvb.file"

        let fvt = MimeType.Parse "video/vnd.fvt"

        module hns =
            let video = MimeType.Parse "video/vnd.hns.video"

        module iptvforum =
            module _1dparityfec =
                let _1010 = MimeType.Parse "video/vnd.iptvforum.1dparityfec-1010"
                let _2005 = MimeType.Parse "video/vnd.iptvforum.1dparityfec-2005"

            module _2dparityfec =
                let _1010 = MimeType.Parse "video/vnd.iptvforum.2dparityfec-1010"
                let _2005 = MimeType.Parse "video/vnd.iptvforum.2dparityfec-2005"

            let ttsavc = MimeType.Parse "video/vnd.iptvforum.ttsavc"
            let ttsmpeg2 = MimeType.Parse "video/vnd.iptvforum.ttsmpeg2"

        module motorola =
            let video = MimeType.Parse "video/vnd.motorola.video"
            let videop = MimeType.Parse "video/vnd.motorola.videop"

        let mpegurl = MimeType.Parse "video/vnd.mpegurl"

        module ms =
            module playready =
                module media =
                    let pyv = MimeType.Parse "video/vnd.ms-playready.media.pyv"

        module nokia =
            module interleaved =
                let multimedia = MimeType.Parse "video/vnd.nokia.interleaved-multimedia"

            let mp4vr = MimeType.Parse "video/vnd.nokia.mp4vr"
            let videovoip = MimeType.Parse "video/vnd.nokia.videovoip"

        let objectvideo = MimeType.Parse "video/vnd.objectvideo"
        let planar = MimeType.Parse "video/vnd.planar"

        module radgamettools =
            let bink = MimeType.Parse "video/vnd.radgamettools.bink"
            let smacker = MimeType.Parse "video/vnd.radgamettools.smacker"

        module sealed_ =
            let mpeg1 = MimeType.Parse "video/vnd.sealed.mpeg1"
            let mpeg4 = MimeType.Parse "video/vnd.sealed.mpeg4"
            let swf = MimeType.Parse "video/vnd.sealed.swf"

        module sealedmedia =
            module softseal =
                let mov = MimeType.Parse "video/vnd.sealedmedia.softseal.mov"

        module uvvu =
            let mp4 = MimeType.Parse "video/vnd.uvvu.mp4"

        module youtube =
            let yt = MimeType.Parse "video/vnd.youtube.yt"

        let vivo = MimeType.Parse "video/vnd.vivo"

    let VP8 = MimeType.Parse "video/VP8"
    let VP9 = MimeType.Parse "video/VP9"
