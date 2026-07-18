namespace DoxAletheia
open Rdf_Vocabulary
module Mime_Path =
    module application =
        module _1d =
            module interleaved =
                module parityfec =
                    let media_type =
                        { registry = "application"
                          name = "1d-interleaved-parityfec" }

        module _3gpdash =
            module qoe =
                module report =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "3gpdash-qoe-report+xml" }

        module _3gpp =
            module ims =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "3gpp-ims+xml" }

            module mbs =
                module object =
                    module manifest =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "3gpp-mbs-object-manifest+json" }

                module user =
                    module service =
                        module descriptions =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "3gpp-mbs-user-service-descriptions+json" }

            module media =
                module delivery =
                    module metrics =
                        module report =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "3gpp-media-delivery-metrics-report+json" }

        module _3gppHal =
            module json =
                let media_type =
                    { registry = "application"
                      name = "3gppHal+json" }

        module _3gppHalForms =
            module json =
                let media_type =
                    { registry = "application"
                      name = "3gppHalForms+json" }

        module A2L =
            let media_type =
                { registry = "application"
                  name = "A2L" }

        module AML =
            let media_type =
                { registry = "application"
                  name = "AML" }

        module ATF =
            let media_type =
                { registry = "application"
                  name = "ATF" }

        module ATFX =
            let media_type =
                { registry = "application"
                  name = "ATFX" }

        module ATXML =
            let media_type =
                { registry = "application"
                  name = "ATXML" }

        module CALS =
            module _1840 =
                let media_type =
                    { registry = "application"
                      name = "CALS-1840" }

        module CDFX =
            module XML =
                let media_type =
                    { registry = "application"
                      name = "CDFX+XML" }

        module CEA =
            let media_type =
                { registry = "application"
                  name = "CEA" }

        module CSTAdata =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "CSTAdata+xml" }

        module DCD =
            let media_type =
                { registry = "application"
                  name = "DCD" }

        module DII =
            let media_type =
                { registry = "application"
                  name = "DII" }

        module DIT =
            let media_type =
                { registry = "application"
                  name = "DIT" }

        module EDI =
            module X12 =
                let media_type =
                    { registry = "application"
                      name = "EDI-X12" }

            module consent =
                let media_type =
                    { registry = "application"
                      name = "EDI-consent" }

        module EDIFACT =
            let media_type =
                { registry = "application"
                  name = "EDIFACT" }

        module EmergencyCallData =
            module Comment =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.Comment+xml" }

            module Control =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.Control+xml" }

            module DeviceInfo =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.DeviceInfo+xml" }

            module LegacyESN =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.LegacyESN+json" }

            module ProviderInfo =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.ProviderInfo+xml" }

            module ServiceInfo =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.ServiceInfo+xml" }

            module SubscriberInfo =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.SubscriberInfo+xml" }

            module VEDS =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.VEDS+xml" }

            module cap =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.cap+xml" }

            module eCall =
                module MSD =
                    let media_type =
                        { registry = "application"
                          name = "EmergencyCallData.eCall.MSD" }

        module H224 =
            let media_type =
                { registry = "application"
                  name = "H224" }

        module IOTP =
            let media_type =
                { registry = "application"
                  name = "IOTP" }

        module ISUP =
            let media_type =
                { registry = "application"
                  name = "ISUP" }

        module LXF =
            let media_type =
                { registry = "application"
                  name = "LXF" }

        module MF4 =
            let media_type =
                { registry = "application"
                  name = "MF4" }

        module ODA =
            let media_type =
                { registry = "application"
                  name = "ODA" }

        module ODX =
            let media_type =
                { registry = "application"
                  name = "ODX" }

        module PDX =
            let media_type =
                { registry = "application"
                  name = "PDX" }

        module QSIG =
            let media_type =
                { registry = "application"
                  name = "QSIG" }

        module SGML =
            let media_type =
                { registry = "application"
                  name = "SGML" }

        module ST2110 =
            module _41 =
                let media_type =
                    { registry = "application"
                      name = "ST2110-41" }

        module TETRA =
            module ISI =
                let media_type =
                    { registry = "application"
                      name = "TETRA_ISI" }

        module aas =
            module zip =
                let media_type =
                    { registry = "application"
                      name = "aas+zip" }

        module ace =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "ace+cbor" }

            module groupcomm =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "ace-groupcomm+cbor" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "ace+json" }

            module trl =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "ace-trl+cbor" }

        module activemessage =
            let media_type =
                { registry = "application"
                  name = "activemessage" }

        module activity =
            module json =
                let media_type =
                    { registry = "application"
                      name = "activity+json" }

        module aif =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "aif+cbor" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "aif+json" }

        module alto =
            module cdni =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-cdni+json" }

            module cdnifilter =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-cdnifilter+json" }

            module costmap =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-costmap+json" }

            module costmapfilter =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-costmapfilter+json" }

            module directory =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-directory+json" }

            module endpointcost =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-endpointcost+json" }

            module endpointcostparams =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-endpointcostparams+json" }

            module endpointprop =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-endpointprop+json" }

            module endpointpropparams =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-endpointpropparams+json" }

            module error =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-error+json" }

            module networkmap =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-networkmap+json" }

            module networkmapfilter =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-networkmapfilter+json" }

            module propmap =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-propmap+json" }

            module propmapparams =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-propmapparams+json" }

            module tips =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-tips+json" }

            module tipsparams =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-tipsparams+json" }

            module updatestreamcontrol =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-updatestreamcontrol+json" }

            module updatestreamparams =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "alto-updatestreamparams+json" }

        module andrew =
            module inset =
                let media_type =
                    { registry = "application"
                      name = "andrew-inset" }

        module applefile =
            let media_type =
                { registry = "application"
                  name = "applefile" }

        module asyncapi =
            module json =
                let media_type =
                    { registry = "application"
                      name = "asyncapi+json" }

            module yaml =
                let media_type =
                    { registry = "application"
                      name = "asyncapi+yaml" }

        module at =
            module jwt =
                let media_type =
                    { registry = "application"
                      name = "at+jwt" }

        module atom =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "atom+xml" }

        module atomcat =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "atomcat+xml" }

        module atomdeleted =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "atomdeleted+xml" }

        module atomicmail =
            let media_type =
                { registry = "application"
                  name = "atomicmail" }

        module atomsvc =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "atomsvc+xml" }

        module atsc =
            module dwd =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "atsc-dwd+xml" }

            module dynamic =
                module event_ =
                    module message =
                        let media_type =
                            { registry = "application"
                              name = "atsc-dynamic-event-message" }

            module held =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "atsc-held+xml" }

            module rdt =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "atsc-rdt+json" }

            module rsat =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "atsc-rsat+xml" }

        module auth =
            module policy =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "auth-policy+xml" }

        module automationml =
            module aml =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "automationml-aml+xml" }

            module amlx =
                module zip =
                    let media_type =
                        { registry = "application"
                          name = "automationml-amlx+zip" }

        module bacnet =
            module xdd =
                module zip =
                    let media_type =
                        { registry = "application"
                          name = "bacnet-xdd+zip" }

        module batch =
            module SMTP =
                let media_type =
                    { registry = "application"
                      name = "batch-SMTP" }

        module beep =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "beep+xml" }

        module bufr =
            let media_type =
                { registry = "application"
                  name = "bufr" }

        module c2pa =
            let media_type =
                { registry = "application"
                  name = "c2pa" }

        module calendar =
            module json =
                let media_type =
                    { registry = "application"
                      name = "calendar+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "calendar+xml" }

        module call =
            module completion =
                let media_type =
                    { registry = "application"
                      name = "call-completion" }

        module captive =
            module json =
                let media_type =
                    { registry = "application"
                      name = "captive+json" }

        module cbor =
            let media_type =
                { registry = "application"
                  name = "cbor" }

            module seq =
                let media_type =
                    { registry = "application"
                      name = "cbor-seq" }

        module cccex =
            let media_type =
                { registry = "application"
                  name = "cccex" }

        module ccmp =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "ccmp+xml" }

        module ccxml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "ccxml+xml" }

        module cda =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "cda+xml" }

        module cdmi =
            module capability =
                let media_type =
                    { registry = "application"
                      name = "cdmi-capability" }

            module container =
                let media_type =
                    { registry = "application"
                      name = "cdmi-container" }

            module domain =
                let media_type =
                    { registry = "application"
                      name = "cdmi-domain" }

            module object =
                let media_type =
                    { registry = "application"
                      name = "cdmi-object" }

            module queue =
                let media_type =
                    { registry = "application"
                      name = "cdmi-queue" }

        module cdni =
            let media_type =
                { registry = "application"
                  name = "cdni" }

        module ce =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "ce+cbor" }

        module cea =
            module _2018 =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "cea-2018+xml" }

        module cellml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "cellml+xml" }

        module cfw =
            let media_type =
                { registry = "application"
                  name = "cfw" }

        module cid =
            let media_type =
                { registry = "application"
                  name = "cid" }

            module edhoc =
                module cbor =
                    module seq =
                        let media_type =
                            { registry = "application"
                              name = "cid-edhoc+cbor-seq" }

        module city =
            module json =
                let media_type =
                    { registry = "application"
                      name = "city+json" }

                module seq =
                    let media_type =
                        { registry = "application"
                          name = "city+json-seq" }

        module client =
            module authentication =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "client-authentication+jwt" }

        module cloudevents =
            module batch =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "cloudevents-batch+json" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "cloudevents+json" }

        module clr =
            let media_type =
                { registry = "application"
                  name = "clr" }

        module clue =
            module info =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "clue_info+xml" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "clue+xml" }

        module cmcd =
            let media_type =
                { registry = "application"
                  name = "cmcd" }

        module cms =
            let media_type =
                { registry = "application"
                  name = "cms" }

        module cmw =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "cmw+cbor" }

            module cose =
                let media_type =
                    { registry = "application"
                      name = "cmw+cose" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "cmw+json" }

            module jws =
                let media_type =
                    { registry = "application"
                      name = "cmw+jws" }

        module cnrp =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "cnrp+xml" }

        module coap =
            module eap =
                let media_type =
                    { registry = "application"
                      name = "coap-eap" }

            module group =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "coap-group+json" }

            module payload =
                let media_type =
                    { registry = "application"
                      name = "coap-payload" }

        module commonground =
            let media_type =
                { registry = "application"
                  name = "commonground" }

        module concise =
            module problem =
                module details =
                    module cbor =
                        let media_type =
                            { registry = "application"
                              name = "concise-problem-details+cbor" }

        module conference =
            module info =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "conference-info+xml" }

        module cose =
            let media_type =
                { registry = "application"
                  name = "cose" }

            module key =
                let media_type =
                    { registry = "application"
                      name = "cose-key" }

                module set =
                    let media_type =
                        { registry = "application"
                          name = "cose-key-set" }

            module x509 =
                let media_type =
                    { registry = "application"
                      name = "cose-x509" }

        module cpl =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "cpl+xml" }

        module csrattrs =
            let media_type =
                { registry = "application"
                  name = "csrattrs" }

        module csta =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "csta+xml" }

        module csvm =
            module json =
                let media_type =
                    { registry = "application"
                      name = "csvm+json" }

        module cwl =
            let media_type =
                { registry = "application"
                  name = "cwl" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "cwl+json" }

            module yaml =
                let media_type =
                    { registry = "application"
                      name = "cwl+yaml" }

        module cwt =
            let media_type =
                { registry = "application"
                  name = "cwt" }

        module cybercash =
            let media_type =
                { registry = "application"
                  name = "cybercash" }

        module dash =
            module patch =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "dash-patch+xml" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "dash+xml" }

        module dashdelta =
            let media_type =
                { registry = "application"
                  name = "dashdelta" }

        module davmount =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "davmount+xml" }

        module dca =
            module rft =
                let media_type =
                    { registry = "application"
                      name = "dca-rft" }

        module dec =
            module dx =
                let media_type =
                    { registry = "application"
                      name = "dec-dx" }

        module dialog =
            module info =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "dialog-info+xml" }

        module dicom =
            let media_type =
                { registry = "application"
                  name = "dicom" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "dicom+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "dicom+xml" }

        module did =
            let media_type =
                { registry = "application"
                  name = "did" }

        module dns =
            let media_type =
                { registry = "application"
                  name = "dns" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "dns+json" }

            module message =
                let media_type =
                    { registry = "application"
                      name = "dns-message" }

        module dots =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "dots+cbor" }

        module dpop =
            module jwt =
                let media_type =
                    { registry = "application"
                      name = "dpop+jwt" }

        module dskpp =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "dskpp+xml" }

        module dssc =
            module der =
                let media_type =
                    { registry = "application"
                      name = "dssc+der" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "dssc+xml" }

        module dvcs =
            let media_type =
                { registry = "application"
                  name = "dvcs" }

        module eat =
            module bun =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "eat-bun+cbor" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "eat-bun+json" }

            module cwt =
                let media_type =
                    { registry = "application"
                      name = "eat+cwt" }

            module jwt =
                let media_type =
                    { registry = "application"
                      name = "eat+jwt" }

            module ucs =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "eat-ucs+cbor" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "eat-ucs+json" }

        module edhoc =
            module cbor =
                module seq =
                    let media_type =
                        { registry = "application"
                          name = "edhoc+cbor-seq" }

        module efi =
            let media_type =
                { registry = "application"
                  name = "efi" }

        module elm =
            module json =
                let media_type =
                    { registry = "application"
                      name = "elm+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "elm+xml" }

        module emma =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "emma+xml" }

        module emotionml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "emotionml+xml" }

        module encaprtp =
            let media_type =
                { registry = "application"
                  name = "encaprtp" }

        module entity =
            module statement =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "entity-statement+jwt" }

        module epp =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "epp+xml" }

        module epub =
            module zip =
                let media_type =
                    { registry = "application"
                      name = "epub+zip" }

        module eshop =
            let media_type =
                { registry = "application"
                  name = "eshop" }

        module example =
            let media_type =
                { registry = "application"
                  name = "example" }

        module exi =
            let media_type =
                { registry = "application"
                  name = "exi" }

        module expect =
            module ct =
                module report =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "expect-ct-report+json" }

        module explicit =
            module registration =
                module response =
                    module jwt =
                        let media_type =
                            { registry = "application"
                              name = "explicit-registration-response+jwt" }

        module express =
            let media_type =
                { registry = "application"
                  name = "express" }

        module fastinfoset =
            let media_type =
                { registry = "application"
                  name = "fastinfoset" }

        module fastsoap =
            let media_type =
                { registry = "application"
                  name = "fastsoap" }

        module fdf =
            let media_type =
                { registry = "application"
                  name = "fdf" }

        module fdt =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "fdt+xml" }

        module fhir =
            module json =
                let media_type =
                    { registry = "application"
                      name = "fhir+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "fhir+xml" }

        module fits =
            let media_type =
                { registry = "application"
                  name = "fits" }

        module flexfec =
            let media_type =
                { registry = "application"
                  name = "flexfec" }

        module font =
            module tdpfr =
                let media_type =
                    { registry = "application"
                      name = "font-tdpfr" }

        module framework =
            module attributes =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "framework-attributes+xml" }

        module geo =
            module json =
                let media_type =
                    { registry = "application"
                      name = "geo+json" }

                module seq =
                    let media_type =
                        { registry = "application"
                          name = "geo+json-seq" }

        module geofeed =
            module csv =
                let media_type =
                    { registry = "application"
                      name = "geofeed+csv" }

        module geopackage =
            module sqlite3 =
                let media_type =
                    { registry = "application"
                      name = "geopackage+sqlite3" }

        module geopose =
            module json =
                let media_type =
                    { registry = "application"
                      name = "geopose+json" }

        module geoxacml =
            module json =
                let media_type =
                    { registry = "application"
                      name = "geoxacml+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "geoxacml+xml" }

        module gltf =
            module buffer =
                let media_type =
                    { registry = "application"
                      name = "gltf-buffer" }

        module gml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "gml+xml" }

        module gnap =
            module binding =
                module jws =
                    let media_type =
                        { registry = "application"
                          name = "gnap-binding-jws" }

                module jwsd =
                    let media_type =
                        { registry = "application"
                          name = "gnap-binding-jwsd" }

                module rotation =
                    module jws =
                        let media_type =
                            { registry = "application"
                              name = "gnap-binding-rotation-jws" }

                    module jwsd =
                        let media_type =
                            { registry = "application"
                              name = "gnap-binding-rotation-jwsd" }

        module grib =
            let media_type =
                { registry = "application"
                  name = "grib" }

        module gzip =
            let media_type =
                { registry = "application"
                  name = "gzip" }

        module held =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "held+xml" }

        module hl7v2 =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "hl7v2+xml" }

        module http =
            let media_type =
                { registry = "application"
                  name = "http" }

        module hyperstudio =
            let media_type =
                { registry = "application"
                  name = "hyperstudio" }

        module ibe =
            module key =
                module request =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "ibe-key-request+xml" }

            module pkg =
                module reply =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "ibe-pkg-reply+xml" }

            module pp =
                module data =
                    let media_type =
                        { registry = "application"
                          name = "ibe-pp-data" }

        module iges =
            let media_type =
                { registry = "application"
                  name = "iges" }

        module im =
            module iscomposing =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "im-iscomposing+xml" }

        module index =
            let media_type =
                { registry = "application"
                  name = "index" }

            module cmd =
                let media_type =
                    { registry = "application"
                      name = "index.cmd" }

            module obj =
                let media_type =
                    { registry = "application"
                      name = "index.obj" }

            module response =
                let media_type =
                    { registry = "application"
                      name = "index.response" }

            module vnd =
                let media_type =
                    { registry = "application"
                      name = "index.vnd" }

        module inkml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "inkml+xml" }

        module ipfix =
            let media_type =
                { registry = "application"
                  name = "ipfix" }

        module ipp =
            let media_type =
                { registry = "application"
                  name = "ipp" }

        module its =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "its+xml" }

        module java =
            module archive =
                let media_type =
                    { registry = "application"
                      name = "java-archive" }

        module jf2feed =
            module json =
                let media_type =
                    { registry = "application"
                      name = "jf2feed+json" }

        module jose =
            let media_type =
                { registry = "application"
                  name = "jose" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "jose+json" }

        module jrd =
            module json =
                let media_type =
                    { registry = "application"
                      name = "jrd+json" }

        module jscalendar =
            module json =
                let media_type =
                    { registry = "application"
                      name = "jscalendar+json" }

        module jscontact =
            module json =
                let media_type =
                    { registry = "application"
                      name = "jscontact+json" }

        module json =
            let media_type =
                { registry = "application"
                  name = "json" }

            module patch =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "json-patch+json" }

                module query =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "json-patch-query+json" }

            module seq =
                let media_type =
                    { registry = "application"
                      name = "json-seq" }

        module jsonpath =
            let media_type =
                { registry = "application"
                  name = "jsonpath" }

        module jumbf =
            let media_type =
                { registry = "application"
                  name = "jumbf" }

        module jwk =
            module json =
                let media_type =
                    { registry = "application"
                      name = "jwk+json" }

            module set =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "jwk-set+json" }

                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "jwk-set+jwt" }

        module jwt =
            let media_type =
                { registry = "application"
                  name = "jwt" }

        module kb =
            module jwt =
                let media_type =
                    { registry = "application"
                      name = "kb+jwt" }

        module kbl =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "kbl+xml" }

        module kpml =
            module request =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "kpml-request+xml" }

            module response =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "kpml-response+xml" }

        module ld =
            module json =
                let media_type =
                    { registry = "application"
                      name = "ld+json" }

        module lgr =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "lgr+xml" }

        module link =
            module format =
                let media_type =
                    { registry = "application"
                      name = "link-format" }

        module linkset =
            let media_type =
                { registry = "application"
                  name = "linkset" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "linkset+json" }

        module load =
            module control =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "load-control+xml" }

        module logout =
            module jwt =
                let media_type =
                    { registry = "application"
                      name = "logout+jwt" }

        module lost =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "lost+xml" }

        module lostsync =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "lostsync+xml" }

        module lpf =
            module zip =
                let media_type =
                    { registry = "application"
                      name = "lpf+zip" }

        module mac =
            module binhex40 =
                let media_type =
                    { registry = "application"
                      name = "mac-binhex40" }

        module macwriteii =
            let media_type =
                { registry = "application"
                  name = "macwriteii" }

        module mads =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "mads+xml" }

        module manifest =
            module json =
                let media_type =
                    { registry = "application"
                      name = "manifest+json" }

        module marc =
            let media_type =
                { registry = "application"
                  name = "marc" }

        module marcxml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "marcxml+xml" }

        module mathematica =
            let media_type =
                { registry = "application"
                  name = "mathematica" }

        module mathml =
            module content =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mathml-content+xml" }

            module presentation =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mathml-presentation+xml" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "mathml+xml" }

        module mbms =
            module associated =
                module procedure =
                    module description =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "mbms-associated-procedure-description+xml" }

            module deregister =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mbms-deregister+xml" }

            module envelope =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mbms-envelope+xml" }

            module msk =
                module response =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "mbms-msk-response+xml" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mbms-msk+xml" }

            module protection =
                module description =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "mbms-protection-description+xml" }

            module reception =
                module report =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "mbms-reception-report+xml" }

            module register =
                module response =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "mbms-register-response+xml" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mbms-register+xml" }

            module schedule =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mbms-schedule+xml" }

            module user =
                module service =
                    module description =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "mbms-user-service-description+xml" }

        module mbox =
            let media_type =
                { registry = "application"
                  name = "mbox" }

        module measured =
            module component_ =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "measured-component+cbor" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "measured-component+json" }

        module media =
            module control =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "media_control+xml" }

            module policy =
                module dataset =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "media-policy-dataset+xml" }

        module mediaservercontrol =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "mediaservercontrol+xml" }

        module merge =
            module patch =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "merge-patch+json" }

        module metalink4 =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "metalink4+xml" }

        module mets =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "mets+xml" }

        module mikey =
            let media_type =
                { registry = "application"
                  name = "mikey" }

        module mipc =
            let media_type =
                { registry = "application"
                  name = "mipc" }

        module missing =
            module blocks =
                module cbor =
                    module seq =
                        let media_type =
                            { registry = "application"
                              name = "missing-blocks+cbor-seq" }

        module mmt =
            module aei =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mmt-aei+xml" }

            module usd =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mmt-usd+xml" }

        module mods =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "mods+xml" }

        module moss =
            module keys =
                let media_type =
                    { registry = "application"
                      name = "moss-keys" }

            module signature =
                let media_type =
                    { registry = "application"
                      name = "moss-signature" }

        module mosskey =
            module data =
                let media_type =
                    { registry = "application"
                      name = "mosskey-data" }

            module request =
                let media_type =
                    { registry = "application"
                      name = "mosskey-request" }

        module mp21 =
            let media_type =
                { registry = "application"
                  name = "mp21" }

        module mp4 =
            let media_type =
                { registry = "application"
                  name = "mp4" }

        module mpeg4 =
            module generic =
                let media_type =
                    { registry = "application"
                      name = "mpeg4-generic" }

            module iod =
                let media_type =
                    { registry = "application"
                      name = "mpeg4-iod" }

                module xmt =
                    let media_type =
                        { registry = "application"
                          name = "mpeg4-iod-xmt" }

        module mrb =
            module consumer =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mrb-consumer+xml" }

            module publish =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "mrb-publish+xml" }

        module msc =
            module ivr =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "msc-ivr+xml" }

            module mixer =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "msc-mixer+xml" }

        module msword =
            let media_type =
                { registry = "application"
                  name = "msword" }

        module mud =
            module json =
                let media_type =
                    { registry = "application"
                      name = "mud+json" }

        module multipart =
            module core =
                let media_type =
                    { registry = "application"
                      name = "multipart-core" }

        module mxf =
            let media_type =
                { registry = "application"
                  name = "mxf" }

        module n =
            module quads =
                let media_type =
                    { registry = "application"
                      name = "n-quads" }

            module triples =
                let media_type =
                    { registry = "application"
                      name = "n-triples" }

        module nasdata =
            let media_type =
                { registry = "application"
                  name = "nasdata" }

        module news =
            module checkgroups =
                let media_type =
                    { registry = "application"
                      name = "news-checkgroups" }

            module groupinfo =
                let media_type =
                    { registry = "application"
                      name = "news-groupinfo" }

            module transmission =
                let media_type =
                    { registry = "application"
                      name = "news-transmission" }

        module nlsml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "nlsml+xml" }

        module node =
            let media_type =
                { registry = "application"
                  name = "node" }

        module nss =
            let media_type =
                { registry = "application"
                  name = "nss" }

        module oauth =
            module authz =
                module req =
                    module jwt =
                        let media_type =
                            { registry = "application"
                              name = "oauth-authz-req+jwt" }

        module oblivious =
            module dns =
                module message =
                    let media_type =
                        { registry = "application"
                          name = "oblivious-dns-message" }

        module ocsp =
            module request =
                let media_type =
                    { registry = "application"
                      name = "ocsp-request" }

            module response =
                let media_type =
                    { registry = "application"
                      name = "ocsp-response" }

        module octet =
            module stream =
                let media_type =
                    { registry = "application"
                      name = "octet-stream" }

        module odm =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "odm+xml" }

        module oebps =
            module package =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "oebps-package+xml" }

        module ogg =
            let media_type =
                { registry = "application"
                  name = "ogg" }

        module ohttp =
            module keys =
                let media_type =
                    { registry = "application"
                      name = "ohttp-keys" }

        module opc =
            module nodeset =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "opc-nodeset+xml" }

        module oscore =
            let media_type =
                { registry = "application"
                  name = "oscore" }

        module oxps =
            let media_type =
                { registry = "application"
                  name = "oxps" }

        module p21 =
            let media_type =
                { registry = "application"
                  name = "p21" }

            module zip =
                let media_type =
                    { registry = "application"
                      name = "p21+zip" }

        module p2p =
            module overlay =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "p2p-overlay+xml" }

        module parityfec =
            let media_type =
                { registry = "application"
                  name = "parityfec" }

        module passport =
            let media_type =
                { registry = "application"
                  name = "passport" }

        module patch =
            module ops =
                module error =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "patch-ops-error+xml" }

        module pdf =
            let media_type =
                { registry = "application"
                  name = "pdf" }

        module pem =
            module certificate =
                module chain =
                    let media_type =
                        { registry = "application"
                          name = "pem-certificate-chain" }

        module pgp =
            module encrypted =
                let media_type =
                    { registry = "application"
                      name = "pgp-encrypted" }

            module keys =
                let media_type =
                    { registry = "application"
                      name = "pgp-keys" }

            module signature =
                let media_type =
                    { registry = "application"
                      name = "pgp-signature" }

        module pidf =
            module diff =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "pidf-diff+xml" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "pidf+xml" }

        module pkcs10 =
            let media_type =
                { registry = "application"
                  name = "pkcs10" }

        module pkcs12 =
            let media_type =
                { registry = "application"
                  name = "pkcs12" }

        module pkcs7 =
            module mime =
                let media_type =
                    { registry = "application"
                      name = "pkcs7-mime" }

            module signature =
                let media_type =
                    { registry = "application"
                      name = "pkcs7-signature" }

        module pkcs8 =
            let media_type =
                { registry = "application"
                  name = "pkcs8" }

            module encrypted =
                let media_type =
                    { registry = "application"
                      name = "pkcs8-encrypted" }

        module pkix =
            module attr =
                module cert =
                    let media_type =
                        { registry = "application"
                          name = "pkix-attr-cert" }

            module cert =
                let media_type =
                    { registry = "application"
                      name = "pkix-cert" }

            module crl =
                let media_type =
                    { registry = "application"
                      name = "pkix-crl" }

            module pkipath =
                let media_type =
                    { registry = "application"
                      name = "pkix-pkipath" }

        module pkixcmp =
            let media_type =
                { registry = "application"
                  name = "pkixcmp" }

        module pls =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "pls+xml" }

        module poc =
            module settings =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "poc-settings+xml" }

        module postscript =
            let media_type =
                { registry = "application"
                  name = "postscript" }

        module ppsp =
            module tracker =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "ppsp-tracker+json" }

        module private_ =
            module token =
                module issuer =
                    module directory =
                        let media_type =
                            { registry = "application"
                              name = "private-token-issuer-directory" }

                module request =
                    let media_type =
                        { registry = "application"
                          name = "private-token-request" }

                module response =
                    let media_type =
                        { registry = "application"
                          name = "private-token-response" }

        module problem =
            module json =
                let media_type =
                    { registry = "application"
                      name = "problem+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "problem+xml" }

        module protobuf =
            let media_type =
                { registry = "application"
                  name = "protobuf" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "protobuf+json" }

        module provenance =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "provenance+xml" }

        module provided =
            module claims =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "provided-claims+jwt" }

        module prs =
            module alvestrand =
                module titrax =
                    module sheet =
                        let media_type =
                            { registry = "application"
                              name = "prs.alvestrand.titrax-sheet" }

            module bwtc32key =
                let media_type =
                    { registry = "application"
                      name = "prs.bwtc32key" }

            module cww =
                let media_type =
                    { registry = "application"
                      name = "prs.cww" }

            module cyn =
                let media_type =
                    { registry = "application"
                      name = "prs.cyn" }

            module hpub =
                module zip =
                    let media_type =
                        { registry = "application"
                          name = "prs.hpub+zip" }

            module implied =
                module document =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "prs.implied-document+xml" }

                module executable =
                    let media_type =
                        { registry = "application"
                          name = "prs.implied-executable" }

                module object =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "prs.implied-object+json" }

                        module seq =
                            let media_type =
                                { registry = "application"
                                  name = "prs.implied-object+json-seq" }

                    module yaml =
                        let media_type =
                            { registry = "application"
                              name = "prs.implied-object+yaml" }

                module structure =
                    let media_type =
                        { registry = "application"
                          name = "prs.implied-structure" }

            module mayfile =
                let media_type =
                    { registry = "application"
                      name = "prs.mayfile" }

            module nprend =
                let media_type =
                    { registry = "application"
                      name = "prs.nprend" }

            module plucker =
                let media_type =
                    { registry = "application"
                      name = "prs.plucker" }

            module rdf =
                module xml =
                    module crypt =
                        let media_type =
                            { registry = "application"
                              name = "prs.rdf-xml-crypt" }

            module sclt =
                let media_type =
                    { registry = "application"
                      name = "prs.sclt" }

            module vcfbzip2 =
                let media_type =
                    { registry = "application"
                      name = "prs.vcfbzip2" }

            module xsf =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "prs.xsf+xml" }

        module pskc =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "pskc+xml" }

        module pvd =
            module json =
                let media_type =
                    { registry = "application"
                      name = "pvd+json" }

        module raptorfec =
            let media_type =
                { registry = "application"
                  name = "raptorfec" }

        module rdap =
            module json =
                let media_type =
                    { registry = "application"
                      name = "rdap+json" }

        module rdf =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "rdf+xml" }

        module reginfo =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "reginfo+xml" }

        module relax =
            module ng =
                module compact =
                    module syntax =
                        let media_type =
                            { registry = "application"
                              name = "relax-ng-compact-syntax" }

        module reputon =
            module json =
                let media_type =
                    { registry = "application"
                      name = "reputon+json" }

        module resolve =
            module response =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "resolve-response+jwt" }

        module resource =
            module lists =
                module diff =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "resource-lists-diff+xml" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "resource-lists+xml" }

        module rfc =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "rfc+xml" }

        module riscos =
            let media_type =
                { registry = "application"
                  name = "riscos" }

        module rlmi =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "rlmi+xml" }

        module rls =
            module services =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "rls-services+xml" }

        module roughtime =
            module malfeasance =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "roughtime-malfeasance+json" }

            module server =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "roughtime-server+json" }

        module route =
            module apd =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "route-apd+xml" }

            module s =
                module tsid =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "route-s-tsid+xml" }

            module usd =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "route-usd+xml" }

        module rpki =
            module ccr =
                let media_type =
                    { registry = "application"
                      name = "rpki-ccr" }

                module gzip =
                    let media_type =
                        { registry = "application"
                          name = "rpki-ccr+gzip" }

            module checklist =
                let media_type =
                    { registry = "application"
                      name = "rpki-checklist" }

            module manifest =
                let media_type =
                    { registry = "application"
                      name = "rpki-manifest" }

            module publication =
                let media_type =
                    { registry = "application"
                      name = "rpki-publication" }

            module roa =
                let media_type =
                    { registry = "application"
                      name = "rpki-roa" }

            module signed =
                module tal =
                    let media_type =
                        { registry = "application"
                          name = "rpki-signed-tal" }

            module updown =
                let media_type =
                    { registry = "application"
                      name = "rpki-updown" }

        module rs =
            module metadata =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "rs-metadata+xml" }

        module rtf =
            let media_type =
                { registry = "application"
                  name = "rtf" }

        module rtploopback =
            let media_type =
                { registry = "application"
                  name = "rtploopback" }

        module rtx =
            let media_type =
                { registry = "application"
                  name = "rtx" }

        module samlassertion =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "samlassertion+xml" }

        module samlmetadata =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "samlmetadata+xml" }

        module sarif =
            module external_ =
                module properties =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "sarif-external-properties+json" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "sarif+json" }

        module sbe =
            let media_type =
                { registry = "application"
                  name = "sbe" }

        module sbml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "sbml+xml" }

        module scaip =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "scaip+xml" }

        module scim =
            module json =
                let media_type =
                    { registry = "application"
                      name = "scim+json" }

        module scitt =
            module receipt =
                module cose =
                    let media_type =
                        { registry = "application"
                          name = "scitt-receipt+cose" }

            module statement =
                module cose =
                    let media_type =
                        { registry = "application"
                          name = "scitt-statement+cose" }

        module scvp =
            module cv =
                module request =
                    let media_type =
                        { registry = "application"
                          name = "scvp-cv-request" }

                module response =
                    let media_type =
                        { registry = "application"
                          name = "scvp-cv-response" }

            module vp =
                module request =
                    let media_type =
                        { registry = "application"
                          name = "scvp-vp-request" }

                module response =
                    let media_type =
                        { registry = "application"
                          name = "scvp-vp-response" }

        module sd =
            module jwt =
                let media_type =
                    { registry = "application"
                      name = "sd-jwt" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "sd-jwt+json" }

        module sdf =
            module json =
                let media_type =
                    { registry = "application"
                      name = "sdf+json" }

        module sdp =
            let media_type =
                { registry = "application"
                  name = "sdp" }

        module secevent =
            module jwt =
                let media_type =
                    { registry = "application"
                      name = "secevent+jwt" }

        module senml =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "senml+cbor" }

            module etch =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "senml-etch+cbor" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "senml-etch+json" }

            module exi =
                let media_type =
                    { registry = "application"
                      name = "senml-exi" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "senml+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "senml+xml" }

        module sensml =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "sensml+cbor" }

            module exi =
                let media_type =
                    { registry = "application"
                      name = "sensml-exi" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "sensml+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "sensml+xml" }

        module sep =
            module exi =
                let media_type =
                    { registry = "application"
                      name = "sep-exi" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "sep+xml" }

        module session =
            module info =
                let media_type =
                    { registry = "application"
                      name = "session-info" }

        module set =
            module payment =
                let media_type =
                    { registry = "application"
                      name = "set-payment" }

                module initiation =
                    let media_type =
                        { registry = "application"
                          name = "set-payment-initiation" }

            module registration =
                let media_type =
                    { registry = "application"
                      name = "set-registration" }

                module initiation =
                    let media_type =
                        { registry = "application"
                          name = "set-registration-initiation" }

        module sgml =
            module open_ =
                module catalog =
                    let media_type =
                        { registry = "application"
                          name = "sgml-open-catalog" }

        module shf =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "shf+xml" }

        module sieve =
            let media_type =
                { registry = "application"
                  name = "sieve" }

        module simple =
            module filter =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "simple-filter+xml" }

            module message =
                module summary =
                    let media_type =
                        { registry = "application"
                          name = "simple-message-summary" }

        module simpleSymbolContainer =
            let media_type =
                { registry = "application"
                  name = "simpleSymbolContainer" }

        module sipc =
            let media_type =
                { registry = "application"
                  name = "sipc" }

        module slate =
            let media_type =
                { registry = "application"
                  name = "slate" }

        module smil =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "smil+xml" }

        module smpte336m =
            let media_type =
                { registry = "application"
                  name = "smpte336m" }

        module soap =
            module fastinfoset =
                let media_type =
                    { registry = "application"
                      name = "soap+fastinfoset" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "soap+xml" }

        module sparql =
            module query =
                let media_type =
                    { registry = "application"
                      name = "sparql-query" }

            module results =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "sparql-results+xml" }

        module spdx =
            module json =
                let media_type =
                    { registry = "application"
                      name = "spdx+json" }

        module spdx3 =
            module json =
                let media_type =
                    { registry = "application"
                      name = "spdx3+json" }

        module spirits =
            module event_ =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "spirits-event+xml" }

        module sql =
            let media_type =
                { registry = "application"
                  name = "sql" }

        module srgs =
            let media_type =
                { registry = "application"
                  name = "srgs" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "srgs+xml" }

        module sru =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "sru+xml" }

        module sslkeylogfile =
            let media_type =
                { registry = "application"
                  name = "sslkeylogfile" }

        module ssml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "ssml+xml" }

        module statuslist =
            module cwt =
                let media_type =
                    { registry = "application"
                      name = "statuslist+cwt" }

            module jwt =
                let media_type =
                    { registry = "application"
                      name = "statuslist+jwt" }

        module stix =
            module json =
                let media_type =
                    { registry = "application"
                      name = "stix+json" }

        module stratum =
            let media_type =
                { registry = "application"
                  name = "stratum" }

        module suit =
            module envelope =
                module cose =
                    let media_type =
                        { registry = "application"
                          name = "suit-envelope+cose" }

            module report =
                module cose =
                    let media_type =
                        { registry = "application"
                          name = "suit-report+cose" }

        module swid =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "swid+cbor" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "swid+xml" }

        module syslog =
            module msg =
                let media_type =
                    { registry = "application"
                      name = "syslog-msg" }

        module tamp =
            module apex =
                module update =
                    let media_type =
                        { registry = "application"
                          name = "tamp-apex-update" }

                    module confirm =
                        let media_type =
                            { registry = "application"
                              name = "tamp-apex-update-confirm" }

            module community =
                module update =
                    let media_type =
                        { registry = "application"
                          name = "tamp-community-update" }

                    module confirm =
                        let media_type =
                            { registry = "application"
                              name = "tamp-community-update-confirm" }

            module error =
                let media_type =
                    { registry = "application"
                      name = "tamp-error" }

            module sequence =
                module adjust =
                    let media_type =
                        { registry = "application"
                          name = "tamp-sequence-adjust" }

                    module confirm =
                        let media_type =
                            { registry = "application"
                              name = "tamp-sequence-adjust-confirm" }

            module status =
                module query =
                    let media_type =
                        { registry = "application"
                          name = "tamp-status-query" }

                module response =
                    let media_type =
                        { registry = "application"
                          name = "tamp-status-response" }

            module update =
                let media_type =
                    { registry = "application"
                      name = "tamp-update" }

                module confirm =
                    let media_type =
                        { registry = "application"
                          name = "tamp-update-confirm" }

        module taxii =
            module json =
                let media_type =
                    { registry = "application"
                      name = "taxii+json" }

        module td =
            module json =
                let media_type =
                    { registry = "application"
                      name = "td+json" }

        module teep =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "teep+cbor" }

        module tei =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "tei+xml" }

        module texinfo =
            let media_type =
                { registry = "application"
                  name = "texinfo" }

        module thraud =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "thraud+xml" }

        module timestamp =
            module query =
                let media_type =
                    { registry = "application"
                      name = "timestamp-query" }

            module reply =
                let media_type =
                    { registry = "application"
                      name = "timestamp-reply" }

        module timestamped =
            module data =
                let media_type =
                    { registry = "application"
                      name = "timestamped-data" }

        module tlsrpt =
            module gzip =
                let media_type =
                    { registry = "application"
                      name = "tlsrpt+gzip" }

            module json =
                let media_type =
                    { registry = "application"
                      name = "tlsrpt+json" }

        module tm =
            module json =
                let media_type =
                    { registry = "application"
                      name = "tm+json" }

        module tnauthlist =
            let media_type =
                { registry = "application"
                  name = "tnauthlist" }

        module toc =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "toc+cbor" }

        module token =
            module introspection =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "token-introspection+jwt" }

        module toml =
            let media_type =
                { registry = "application"
                  name = "toml" }

        module trickle =
            module ice =
                module sdpfrag =
                    let media_type =
                        { registry = "application"
                          name = "trickle-ice-sdpfrag" }

        module trig =
            let media_type =
                { registry = "application"
                  name = "trig" }

        module trust =
            module chain =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "trust-chain+json" }

            module mark =
                module delegation =
                    module jwt =
                        let media_type =
                            { registry = "application"
                              name = "trust-mark-delegation+jwt" }

                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "trust-mark+jwt" }

                module status =
                    module response =
                        module jwt =
                            let media_type =
                                { registry = "application"
                                  name = "trust-mark-status-response+jwt" }

        module ttml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "ttml+xml" }

        module tve =
            module trigger =
                let media_type =
                    { registry = "application"
                      name = "tve-trigger" }

        module tzif =
            let media_type =
                { registry = "application"
                  name = "tzif" }

            module leap =
                let media_type =
                    { registry = "application"
                      name = "tzif-leap" }

        module uccs =
            module cbor =
                let media_type =
                    { registry = "application"
                      name = "uccs+cbor" }

        module ujcs =
            module json =
                let media_type =
                    { registry = "application"
                      name = "ujcs+json" }

        module ulpfec =
            let media_type =
                { registry = "application"
                  name = "ulpfec" }

        module urc =
            module grpsheet =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "urc-grpsheet+xml" }

            module ressheet =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "urc-ressheet+xml" }

            module targetdesc =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "urc-targetdesc+xml" }

            module uisocketdesc =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "urc-uisocketdesc+xml" }

        module v3c =
            let media_type =
                { registry = "application"
                  name = "v3c" }

        module vc =
            let media_type =
                { registry = "application"
                  name = "vc" }

            module cose =
                let media_type =
                    { registry = "application"
                      name = "vc+cose" }

            module jwt =
                let media_type =
                    { registry = "application"
                      name = "vc+jwt" }

            module sd =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "vc+sd-jwt" }

        module vcard =
            module json =
                let media_type =
                    { registry = "application"
                      name = "vcard+json" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "vcard+xml" }

        module vec =
            module package =
                module gzip =
                    let media_type =
                        { registry = "application"
                          name = "vec-package+gzip" }

                module zip =
                    let media_type =
                        { registry = "application"
                          name = "vec-package+zip" }

            module xml =
                let media_type =
                    { registry = "application"
                      name = "vec+xml" }

        module vemmi =
            let media_type =
                { registry = "application"
                  name = "vemmi" }

        module vnd =
            module _1000minds =
                module decision =
                    module model =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.1000minds.decision-model+xml" }

            module _1ob =
                let media_type =
                    { registry = "application"
                      name = "vnd.1ob" }

            module _3M =
                module Post =
                    module it =
                        module Notes =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3M.Post-it-Notes" }

            module _3gpp =
                module _5gnas =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.5gnas" }

                module _5gsa2x =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.5gsa2x" }

                    module local =
                        module service =
                            module information =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.5gsa2x-local-service-information" }

                module _5gsv2x =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.5gsv2x" }

                    module local =
                        module service =
                            module information =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.5gsv2x-local-service-information" }

                module GMOP =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.GMOP+xml" }

                module SRVCC =
                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.SRVCC-info+xml" }

                module access =
                    module transfer =
                        module events =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.access-transfer-events+xml" }

                module bsf =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.bsf+xml" }

                module crs =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.crs+xml" }

                module current =
                    module location =
                        module discovery =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.current-location-discovery+xml" }

                module gtpc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.gtpc" }

                module interworking =
                    module data =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.interworking-data" }

                module lpp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.lpp" }

                module mc =
                    module signalling =
                        module ear =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mc-signalling-ear" }

                module mcdata =
                    module affiliation =
                        module command =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcdata-affiliation-command+xml" }

                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcdata-info+xml" }

                    module msgstore =
                        module ctrl =
                            module request =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.mcdata-msgstore-ctrl-request+xml" }

                    module payload =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.mcdata-payload" }

                    module regroup =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcdata-regroup+xml" }

                    module service =
                        module config =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcdata-service-config+xml" }

                    module signalling =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.mcdata-signalling" }

                    module ue =
                        module config =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcdata-ue-config+xml" }

                    module user =
                        module profile =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcdata-user-profile+xml" }

                module mcptt =
                    module affiliation =
                        module command =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcptt-affiliation-command+xml" }

                    module floor =
                        module request =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcptt-floor-request+xml" }

                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcptt-info+xml" }

                    module location =
                        module info =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcptt-location-info+xml" }

                    module mbms =
                        module usage =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.mcptt-mbms-usage-info+xml" }

                    module regroup =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcptt-regroup+xml" }

                    module service =
                        module config =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcptt-service-config+xml" }

                    module signed =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcptt-signed+xml" }

                    module ue =
                        module config =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcptt-ue-config+xml" }

                        module init =
                            module config =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.mcptt-ue-init-config+xml" }

                    module user =
                        module profile =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcptt-user-profile+xml" }

                module mcs =
                    module location =
                        module user =
                            module config =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.mcs-location-user-config+xml" }

                module mcvideo =
                    module affiliation =
                        module command =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcvideo-affiliation-command+xml" }

                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcvideo-info+xml" }

                    module location =
                        module info =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcvideo-location-info+xml" }

                    module mbms =
                        module usage =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.mcvideo-mbms-usage-info+xml" }

                    module regroup =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mcvideo-regroup+xml" }

                    module service =
                        module config =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcvideo-service-config+xml" }

                    module transmission =
                        module request =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcvideo-transmission-request+xml" }

                    module ue =
                        module config =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcvideo-ue-config+xml" }

                    module user =
                        module profile =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.mcvideo-user-profile+xml" }

                module mid =
                    module call =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.mid-call+xml" }

                module ngap =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.ngap" }

                module pfcp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.pfcp" }

                module pic =
                    module bw =
                        module large =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.pic-bw-large" }

                        module small =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.pic-bw-small" }

                        module var =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.pic-bw-var" }

                module pinapp =
                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.pinapp-info+xml" }

                module prose =
                    module pc3a =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp-prose-pc3a+xml" }

                    module pc3ach =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp-prose-pc3ach+xml" }

                    module pc3ch =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp-prose-pc3ch+xml" }

                    module pc8 =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp-prose-pc8+xml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp-prose+xml" }

                module s1ap =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.s1ap" }

                module seal =
                    module app =
                        module comm =
                            module requirements =
                                module info =
                                    module xml =
                                        let media_type =
                                            { registry = "application"
                                              name = "vnd.3gpp.seal-app-comm-requirements-info+xml" }

                    module data =
                        module delivery =
                            module info =
                                module cbor =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-data-delivery-info+cbor" }

                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-data-delivery-info+xml" }

                    module group =
                        module doc =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.seal-group-doc+xml" }

                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.seal-info+xml" }

                    module location =
                        module info =
                            module cbor =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.seal-location-info+cbor" }

                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.seal-location-info+xml" }

                    module mbms =
                        module usage =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-mbms-usage-info+xml" }

                    module mbs =
                        module usage =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-mbs-usage-info+xml" }

                    module network =
                        module QoS =
                            module management =
                                module info =
                                    module xml =
                                        let media_type =
                                            { registry = "application"
                                              name = "vnd.3gpp.seal-network-QoS-management-info+xml" }

                        module resource =
                            module info =
                                module cbor =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-network-resource-info+cbor" }

                    module ue =
                        module config =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-ue-config-info+xml" }

                    module unicast =
                        module info =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp.seal-unicast-info+xml" }

                    module user =
                        module profile =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.seal-user-profile-info+xml" }

                module sms =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.sms" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.sms+xml" }

                module srvcc =
                    module ext =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.srvcc-ext+xml" }

                module state =
                    module and_ =
                        module event_ =
                            module info =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.3gpp.state-and-event-info+xml" }

                module ussd =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp.ussd+xml" }

                module v2x =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp.v2x" }

                    module local =
                        module service =
                            module information =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.3gpp-v2x-local-service-information" }

                module vae =
                    module info =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.3gpp.vae-info+xml" }

            module _3gpp2 =
                module bcmcsinfo =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.3gpp2.bcmcsinfo+xml" }

                module sms =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp2.sms" }

                module tcap =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3gpp2.tcap" }

            module _3lightssoftware =
                module imagescal =
                    let media_type =
                        { registry = "application"
                          name = "vnd.3lightssoftware.imagescal" }

            module FloGraphIt =
                let media_type =
                    { registry = "application"
                      name = "vnd.FloGraphIt" }

            module HandHeld =
                module Entertainment =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.HandHeld-Entertainment+xml" }

            module Kinar =
                let media_type =
                    { registry = "application"
                      name = "vnd.Kinar" }

            module MFER =
                let media_type =
                    { registry = "application"
                      name = "vnd.MFER" }

            module Mobius =
                module DAF =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.DAF" }

                module DIS =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.DIS" }

                module MBK =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.MBK" }

                module MQY =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.MQY" }

                module MSL =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.MSL" }

                module PLC =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.PLC" }

                module TXF =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Mobius.TXF" }

            module Quark =
                module QuarkXPress =
                    let media_type =
                        { registry = "application"
                          name = "vnd.Quark.QuarkXPress" }

            module R74n =
                module sandboxels =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.R74n.sandboxels+json" }

            module RenLearn =
                module rlprint =
                    let media_type =
                        { registry = "application"
                          name = "vnd.RenLearn.rlprint" }

            module SimTech =
                module MindMapper =
                    let media_type =
                        { registry = "application"
                          name = "vnd.SimTech-MindMapper" }

            module abdalsecuritygroup =
                module lockbox =
                    let media_type =
                        { registry = "application"
                          name = "vnd.abdalsecuritygroup.lockbox" }

            module accpac =
                module simply =
                    module aso =
                        let media_type =
                            { registry = "application"
                              name = "vnd.accpac.simply.aso" }

                    module imp =
                        let media_type =
                            { registry = "application"
                              name = "vnd.accpac.simply.imp" }

            module acm =
                module addressxfer =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.acm.addressxfer+json" }

                module chatbot =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.acm.chatbot+json" }

            module acucobol =
                let media_type =
                    { registry = "application"
                      name = "vnd.acucobol" }

            module acucorp =
                let media_type =
                    { registry = "application"
                      name = "vnd.acucorp" }

            module adobe =
                module flash =
                    module movie =
                        let media_type =
                            { registry = "application"
                              name = "vnd.adobe.flash.movie" }

                module formscentral =
                    module fcdt =
                        let media_type =
                            { registry = "application"
                              name = "vnd.adobe.formscentral.fcdt" }

                module fxp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.adobe.fxp" }

                module partial =
                    module upload =
                        let media_type =
                            { registry = "application"
                              name = "vnd.adobe.partial-upload" }

                module xdp =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.adobe.xdp+xml" }

            module aether =
                module imp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.aether.imp" }

            module afpc =
                module afplinedata =
                    let media_type =
                        { registry = "application"
                          name = "vnd.afpc.afplinedata" }

                    module pagedef =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.afplinedata-pagedef" }

                module cmoca =
                    module cmresource =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.cmoca-cmresource" }

                module foca =
                    module charset =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.foca-charset" }

                    module codedfont =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.foca-codedfont" }

                    module codepage =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.foca-codepage" }

                module modca =
                    let media_type =
                        { registry = "application"
                          name = "vnd.afpc.modca" }

                    module cmtable =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.modca-cmtable" }

                    module formdef =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.modca-formdef" }

                    module mediummap =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.modca-mediummap" }

                    module objectcontainer =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.modca-objectcontainer" }

                    module overlay =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.modca-overlay" }

                    module pagesegment =
                        let media_type =
                            { registry = "application"
                              name = "vnd.afpc.modca-pagesegment" }

            module age =
                let media_type =
                    { registry = "application"
                      name = "vnd.age" }

            module agtp =
                module identity =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.agtp.identity+json" }

                    module yaml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.agtp.identity+yaml" }

            module ah =
                module barcode =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ah-barcode" }

            module ahead =
                module space =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ahead.space" }

            module aia =
                let media_type =
                    { registry = "application"
                      name = "vnd.aia" }

            module airzip =
                module filesecure =
                    module azf =
                        let media_type =
                            { registry = "application"
                              name = "vnd.airzip.filesecure.azf" }

                    module azs =
                        let media_type =
                            { registry = "application"
                              name = "vnd.airzip.filesecure.azs" }

            module amadeus =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.amadeus+json" }

            module amazon =
                module mobi8 =
                    module ebook =
                        let media_type =
                            { registry = "application"
                              name = "vnd.amazon.mobi8-ebook" }

            module americandynamics =
                module acc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.americandynamics.acc" }

            module amiga =
                module ami =
                    let media_type =
                        { registry = "application"
                          name = "vnd.amiga.ami" }

            module amundsen =
                module maze =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.amundsen.maze+xml" }

            module android =
                module ota =
                    let media_type =
                        { registry = "application"
                          name = "vnd.android.ota" }

            module anki =
                let media_type =
                    { registry = "application"
                      name = "vnd.anki" }

            module anser =
                module web =
                    module certificate =
                        module issue =
                            module initiation =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.anser-web-certificate-issue-initiation" }

            module antix =
                module game =
                    module component_ =
                        let media_type =
                            { registry = "application"
                              name = "vnd.antix.game-component" }

            module apache =
                module arrow =
                    module file =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apache.arrow.file" }

                    module stream =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apache.arrow.stream" }

                module parquet =
                    let media_type =
                        { registry = "application"
                          name = "vnd.apache.parquet" }

                module thrift =
                    module binary =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apache.thrift.binary" }

                    module compact =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apache.thrift.compact" }

                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apache.thrift.json" }

            module apexlang =
                let media_type =
                    { registry = "application"
                      name = "vnd.apexlang" }

            module api =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.api+json" }

            module aplextor =
                module warrp =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.aplextor.warrp+json" }

            module apothekende =
                module reservation =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apothekende.reservation+json" }

            module apple =
                module installer =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apple.installer+xml" }

                module keynote =
                    let media_type =
                        { registry = "application"
                          name = "vnd.apple.keynote" }

                module mpegurl =
                    let media_type =
                        { registry = "application"
                          name = "vnd.apple.mpegurl" }

                module numbers =
                    let media_type =
                        { registry = "application"
                          name = "vnd.apple.numbers" }

                module pages =
                    let media_type =
                        { registry = "application"
                          name = "vnd.apple.pages" }

                module steering =
                    module list =
                        let media_type =
                            { registry = "application"
                              name = "vnd.apple.steering-list" }

            module aristanetworks =
                module swi =
                    let media_type =
                        { registry = "application"
                          name = "vnd.aristanetworks.swi" }

            module artisan =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.artisan+json" }

            module artsquare =
                let media_type =
                    { registry = "application"
                      name = "vnd.artsquare" }

            module as207960 =
                module vas =
                    module config =
                        module jer =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.as207960.vas.config+jer" }

                        module uper =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.as207960.vas.config+uper" }

                    module tap =
                        module jer =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.as207960.vas.tap+jer" }

                        module uper =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.as207960.vas.tap+uper" }

            module astraea =
                module software =
                    module iota =
                        let media_type =
                            { registry = "application"
                              name = "vnd.astraea-software.iota" }

            module audiograph =
                let media_type =
                    { registry = "application"
                      name = "vnd.audiograph" }

            module aumtrix =
                module aum =
                    let media_type =
                        { registry = "application"
                          name = "vnd.aumtrix.aum" }

            module autopackage =
                let media_type =
                    { registry = "application"
                      name = "vnd.autopackage" }

            module avalon =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.avalon+json" }

            module avistar =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.avistar+xml" }

            module balsamiq =
                module bmml =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.balsamiq.bmml+xml" }

                module bmpr =
                    let media_type =
                        { registry = "application"
                          name = "vnd.balsamiq.bmpr" }

            module banana =
                module accounting =
                    let media_type =
                        { registry = "application"
                          name = "vnd.banana-accounting" }

            module bbf =
                module usp =
                    module error =
                        let media_type =
                            { registry = "application"
                              name = "vnd.bbf.usp.error" }

                    module msg =
                        let media_type =
                            { registry = "application"
                              name = "vnd.bbf.usp.msg" }

                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.bbf.usp.msg+json" }

            module bekitzur =
                module stech =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.bekitzur-stech+json" }

            module belightsoft =
                module lhzd =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.belightsoft.lhzd+zip" }

                module lhzl =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.belightsoft.lhzl+zip" }

            module bint =
                module med =
                    module content =
                        let media_type =
                            { registry = "application"
                              name = "vnd.bint.med-content" }

            module biopax =
                module rdf =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.biopax.rdf+xml" }

            module blink =
                module idb =
                    module value =
                        module wrapper =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.blink-idb-value-wrapper" }

            module blockfact =
                module facts =
                    let media_type =
                        { registry = "application"
                          name = "vnd.blockfact.facts" }

            module blueice =
                module multipass =
                    let media_type =
                        { registry = "application"
                          name = "vnd.blueice.multipass" }

            module bluetooth =
                module ep =
                    module oob =
                        let media_type =
                            { registry = "application"
                              name = "vnd.bluetooth.ep.oob" }

                module le =
                    module oob =
                        let media_type =
                            { registry = "application"
                              name = "vnd.bluetooth.le.oob" }

            module bmi =
                let media_type =
                    { registry = "application"
                      name = "vnd.bmi" }

            module bpf =
                let media_type =
                    { registry = "application"
                      name = "vnd.bpf" }

            module bpf3 =
                let media_type =
                    { registry = "application"
                      name = "vnd.bpf3" }

            module businessobjects =
                let media_type =
                    { registry = "application"
                      name = "vnd.businessobjects" }

            module byu =
                module uapi =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.byu.uapi+json" }

            module bzip3 =
                let media_type =
                    { registry = "application"
                      name = "vnd.bzip3" }

            module c3voc =
                module schedule =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.c3voc.schedule+xml" }

            module cab =
                module jscript =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cab-jscript" }

            module canon =
                module cpdl =
                    let media_type =
                        { registry = "application"
                          name = "vnd.canon-cpdl" }

                module lips =
                    let media_type =
                        { registry = "application"
                          name = "vnd.canon-lips" }

            module capasystems =
                module pg =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.capasystems-pg+json" }

            module cel =
                let media_type =
                    { registry = "application"
                      name = "vnd.cel" }

            module cendio =
                module thinlinc =
                    module clientconf =
                        let media_type =
                            { registry = "application"
                              name = "vnd.cendio.thinlinc.clientconf" }

            module century =
                module systems =
                    module tcp =
                        module stream =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.century-systems.tcp_stream" }

            module chemdraw =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.chemdraw+xml" }

            module chess =
                module pgn =
                    let media_type =
                        { registry = "application"
                          name = "vnd.chess-pgn" }

            module chipnuts =
                module karaoke =
                    module mmd =
                        let media_type =
                            { registry = "application"
                              name = "vnd.chipnuts.karaoke-mmd" }

            module ciedi =
                let media_type =
                    { registry = "application"
                      name = "vnd.ciedi" }

            module cinderella =
                let media_type =
                    { registry = "application"
                      name = "vnd.cinderella" }

            module cirpack =
                module isdn =
                    module ext =
                        let media_type =
                            { registry = "application"
                              name = "vnd.cirpack.isdn-ext" }

            module citationstyles =
                module style =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.citationstyles.style+xml" }

            module claymore =
                let media_type =
                    { registry = "application"
                      name = "vnd.claymore" }

            module cloanto =
                module rp9 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cloanto.rp9" }

            module clonk =
                module c4group =
                    let media_type =
                        { registry = "application"
                          name = "vnd.clonk.c4group" }

            module cluetrust =
                module cartomobile =
                    module config =
                        let media_type =
                            { registry = "application"
                              name = "vnd.cluetrust.cartomobile-config" }

                        module pkg =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.cluetrust.cartomobile-config-pkg" }

            module cmmf =
                module configuration =
                    module information =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.cmmf-configuration-information+json" }

                module efd =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.cmmf-efd+xml" }

                module encoder =
                    module configuration =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.cmmf-encoder-configuration+json" }

            module cncf =
                module helm =
                    module chart =
                        module content =
                            module v1 =
                                module tar =
                                    module gzip =
                                        let media_type =
                                            { registry = "application"
                                              name = "vnd.cncf.helm.chart.content.v1.tar+gzip" }

                        module provenance =
                            module v1 =
                                module prov =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.cncf.helm.chart.provenance.v1.prov" }

                    module config =
                        module v1 =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.cncf.helm.config.v1+json" }

            module coffeescript =
                let media_type =
                    { registry = "application"
                      name = "vnd.coffeescript" }

            module collabio =
                module xodocuments =
                    module document =
                        let media_type =
                            { registry = "application"
                              name = "vnd.collabio.xodocuments.document" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.collabio.xodocuments.document-template" }

                    module presentation =
                        let media_type =
                            { registry = "application"
                              name = "vnd.collabio.xodocuments.presentation" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.collabio.xodocuments.presentation-template" }

                    module spreadsheet =
                        let media_type =
                            { registry = "application"
                              name = "vnd.collabio.xodocuments.spreadsheet" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.collabio.xodocuments.spreadsheet-template" }

            module collection =
                module doc =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.collection.doc+json" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.collection+json" }

                module next =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.collection.next+json" }

            module comicbook =
                module rar =
                    let media_type =
                        { registry = "application"
                          name = "vnd.comicbook-rar" }

                module zip =
                    let media_type =
                        { registry = "application"
                          name = "vnd.comicbook+zip" }

            module commerce =
                module battelle =
                    let media_type =
                        { registry = "application"
                          name = "vnd.commerce-battelle" }

            module commonspace =
                let media_type =
                    { registry = "application"
                      name = "vnd.commonspace" }

            module contact =
                module cmsg =
                    let media_type =
                        { registry = "application"
                          name = "vnd.contact.cmsg" }

            module coreos =
                module ignition =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.coreos.ignition+json" }

            module cosmocaller =
                let media_type =
                    { registry = "application"
                      name = "vnd.cosmocaller" }

            module crick =
                module clicker =
                    let media_type =
                        { registry = "application"
                          name = "vnd.crick.clicker" }

                    module keyboard =
                        let media_type =
                            { registry = "application"
                              name = "vnd.crick.clicker.keyboard" }

                    module palette =
                        let media_type =
                            { registry = "application"
                              name = "vnd.crick.clicker.palette" }

                    module template =
                        let media_type =
                            { registry = "application"
                              name = "vnd.crick.clicker.template" }

                    module wordbank =
                        let media_type =
                            { registry = "application"
                              name = "vnd.crick.clicker.wordbank" }

            module criticaltools =
                module wbs =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.criticaltools.wbs+xml" }

            module cryptii =
                module pipe =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.cryptii.pipe+json" }

            module crypto =
                module shade =
                    module file =
                        let media_type =
                            { registry = "application"
                              name = "vnd.crypto-shade-file" }

            module cryptomator =
                module encrypted =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cryptomator.encrypted" }

                module vault =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cryptomator.vault" }

            module ctc =
                module posml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ctc-posml" }

            module ctct =
                module ws =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ctct.ws+xml" }

            module cups =
                module pdf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cups-pdf" }

                module postscript =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cups-postscript" }

                module ppd =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cups-ppd" }

                module raster =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cups-raster" }

                module raw =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cups-raw" }

            module curl =
                let media_type =
                    { registry = "application"
                      name = "vnd.curl" }

            module cxtf =
                let media_type =
                    { registry = "application"
                      name = "vnd.cxtf" }

            module cxzip =
                let media_type =
                    { registry = "application"
                      name = "vnd.cxzip" }

            module cyan =
                module dean =
                    module root =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.cyan.dean.root+xml" }

            module cybank =
                let media_type =
                    { registry = "application"
                      name = "vnd.cybank" }

            module cyclonedx =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cyclonedx+json" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.cyclonedx+xml" }

            module d2l =
                module coursepackage1p0 =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.d2l.coursepackage1p0+zip" }

            module d3m =
                module dataset =
                    let media_type =
                        { registry = "application"
                          name = "vnd.d3m-dataset" }

                module problem =
                    let media_type =
                        { registry = "application"
                          name = "vnd.d3m-problem" }

            module dart =
                let media_type =
                    { registry = "application"
                      name = "vnd.dart" }

            module data =
                module vision =
                    module rdz =
                        let media_type =
                            { registry = "application"
                              name = "vnd.data-vision.rdz" }

            module datalog =
                let media_type =
                    { registry = "application"
                      name = "vnd.datalog" }

            module datapackage =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.datapackage+json" }

            module dataresource =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dataresource+json" }

            module dbf =
                let media_type =
                    { registry = "application"
                      name = "vnd.dbf" }

            module dcmp =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dcmp+xml" }

            module debian =
                module binary =
                    module package =
                        let media_type =
                            { registry = "application"
                              name = "vnd.debian.binary-package" }

            module dece =
                module data =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dece.data" }

                module ttml =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dece.ttml+xml" }

                module unspecified =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dece.unspecified" }

                module zip =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dece.zip" }

            module denovo =
                module fcselayout =
                    module link =
                        let media_type =
                            { registry = "application"
                              name = "vnd.denovo.fcselayout-link" }

            module desmume =
                module movie =
                    let media_type =
                        { registry = "application"
                          name = "vnd.desmume.movie" }

            module deut =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.deut+json" }

            module digitalstack =
                module document =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.digitalstack.document+zip" }

            module dir =
                module bi =
                    module plate =
                        module dl =
                            module nosuffix =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.dir-bi.plate-dl-nosuffix" }

            module dm =
                module delegation =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dm.delegation+xml" }

            module dna =
                let media_type =
                    { registry = "application"
                      name = "vnd.dna" }

            module document =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.document+json" }

            module dolby =
                module mobile =
                    module _1 =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dolby.mobile.1" }

                    module _2 =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dolby.mobile.2" }

            module doremir =
                module scorecloud =
                    module binary =
                        module document =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.doremir.scorecloud-binary-document" }

            module dpgraph =
                let media_type =
                    { registry = "application"
                      name = "vnd.dpgraph" }

            module dreamfactory =
                let media_type =
                    { registry = "application"
                      name = "vnd.dreamfactory" }

            module drive =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.drive+json" }

            module dtg =
                module local =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dtg.local" }

                    module flash =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dtg.local.flash" }

                    module html =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dtg.local.html" }

            module dvb =
                module ait =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.ait" }

                module dvbisl =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.dvb.dvbisl+xml" }

                module dvbj =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.dvbj" }

                module esgcontainer =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.esgcontainer" }

                module ipdcdftnotifaccess =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.ipdcdftnotifaccess" }

                module ipdcesgaccess =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.ipdcesgaccess" }

                module ipdcesgaccess2 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.ipdcesgaccess2" }

                module ipdcesgpdd =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.ipdcesgpdd" }

                module ipdcroaming =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.ipdcroaming" }

                module iptv =
                    module alfec =
                        module base_ =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.dvb.iptv.alfec-base" }

                        module enhancement =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.dvb.iptv.alfec-enhancement" }

                module notif =
                    module aggregate =
                        module root =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.dvb.notif-aggregate-root+xml" }

                    module container =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.dvb.notif-container+xml" }

                    module generic =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.dvb.notif-generic+xml" }

                    module ia =
                        module msglist =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.dvb.notif-ia-msglist+xml" }

                        module registration =
                            module request =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.dvb.notif-ia-registration-request+xml" }

                            module response =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.dvb.notif-ia-registration-response+xml" }

                    module init =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.dvb.notif-init+xml" }

                module pfr =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.pfr" }

                module service =
                    let media_type =
                        { registry = "application"
                          name = "vnd.dvb.service" }

            module dxr =
                let media_type =
                    { registry = "application"
                      name = "vnd.dxr" }

            module dynageo =
                let media_type =
                    { registry = "application"
                      name = "vnd.dynageo" }

            module dzr =
                let media_type =
                    { registry = "application"
                      name = "vnd.dzr" }

            module easykaraoke =
                module cdgdownload =
                    let media_type =
                        { registry = "application"
                          name = "vnd.easykaraoke.cdgdownload" }

            module ecdis =
                module update =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecdis-update" }

            module ecip =
                module rlp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecip.rlp" }

            module eclipse =
                module ditto =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.eclipse.ditto+json" }

            module ecowin =
                module chart =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecowin.chart" }

                module filerequest =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecowin.filerequest" }

                module fileupdate =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecowin.fileupdate" }

                module series =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecowin.series" }

                module seriesrequest =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecowin.seriesrequest" }

                module seriesupdate =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ecowin.seriesupdate" }

            module edulith =
                module edux =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.edulith.edux+json" }

            module efi =
                module img =
                    let media_type =
                        { registry = "application"
                          name = "vnd.efi.img" }

                module iso =
                    let media_type =
                        { registry = "application"
                          name = "vnd.efi.iso" }

            module eln =
                module zip =
                    let media_type =
                        { registry = "application"
                          name = "vnd.eln+zip" }

            module emclient =
                module accessrequest =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.emclient.accessrequest+xml" }

            module enliven =
                let media_type =
                    { registry = "application"
                      name = "vnd.enliven" }

            module enphase =
                module envoy =
                    let media_type =
                        { registry = "application"
                          name = "vnd.enphase.envoy" }

            module eprints =
                module data =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.eprints.data+xml" }

            module epson =
                module esf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.epson.esf" }

                module msf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.epson.msf" }

                module quickanime =
                    let media_type =
                        { registry = "application"
                          name = "vnd.epson.quickanime" }

                module salt =
                    let media_type =
                        { registry = "application"
                          name = "vnd.epson.salt" }

                module ssf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.epson.ssf" }

            module ericsson =
                module quickcall =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ericsson.quickcall" }

            module erofs =
                let media_type =
                    { registry = "application"
                      name = "vnd.erofs" }

            module espass =
                module espass =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.espass-espass+zip" }

            module eszigno3 =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.eszigno3+xml" }

            module etsi =
                module aoc =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.aoc+xml" }

                module asic =
                    module e =
                        module zip =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.etsi.asic-e+zip" }

                    module s =
                        module zip =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.etsi.asic-s+zip" }

                module cug =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.cug+xml" }

                module iptvcommand =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.iptvcommand+xml" }

                module iptvdiscovery =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.iptvdiscovery+xml" }

                module iptvprofile =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.iptvprofile+xml" }

                module iptvsad =
                    module bc =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.etsi.iptvsad-bc+xml" }

                    module cod =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.etsi.iptvsad-cod+xml" }

                    module npvr =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.etsi.iptvsad-npvr+xml" }

                module iptvservice =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.iptvservice+xml" }

                module iptvsync =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.iptvsync+xml" }

                module iptvueprofile =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.iptvueprofile+xml" }

                module mcid =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.mcid+xml" }

                module mheg5 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.etsi.mheg5" }

                module overload =
                    module control =
                        module policy =
                            module dataset =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.etsi.overload-control-policy-dataset+xml" }

                module pstn =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.pstn+xml" }

                module sci =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.sci+xml" }

                module simservs =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.simservs+xml" }

                module timestamp =
                    module token =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.timestamp-token" }

                module tsl =
                    module der =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.tsl.der" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.etsi.tsl+xml" }

            module eu =
                module kasparian =
                    module car =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.eu.kasparian.car+json" }

            module eudora =
                module data =
                    let media_type =
                        { registry = "application"
                          name = "vnd.eudora.data" }

            module evolv =
                module ecig =
                    module profile =
                        let media_type =
                            { registry = "application"
                              name = "vnd.evolv.ecig.profile" }

                    module settings =
                        let media_type =
                            { registry = "application"
                              name = "vnd.evolv.ecig.settings" }

                    module theme =
                        let media_type =
                            { registry = "application"
                              name = "vnd.evolv.ecig.theme" }

            module exstream =
                module empower =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.exstream-empower+zip" }

                module package =
                    let media_type =
                        { registry = "application"
                          name = "vnd.exstream-package" }

            module ezpix =
                module album =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ezpix-album" }

                module package =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ezpix-package" }

            module f =
                module secure =
                    module mobile =
                        let media_type =
                            { registry = "application"
                              name = "vnd.f-secure.mobile" }

            module faf =
                module yaml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.faf+yaml" }

            module fafa =
                module yaml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fafa+yaml" }

            module fafm =
                module yaml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fafm+yaml" }

            module familysearch =
                module gedcom =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.familysearch.gedcom+zip" }

            module fastcopy =
                module disk =
                    module image =
                        let media_type =
                            { registry = "application"
                              name = "vnd.fastcopy-disk-image" }

            module fdsn =
                module mseed =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fdsn.mseed" }

                module seed =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fdsn.seed" }

                module stationxml =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.fdsn.stationxml+xml" }

            module ffsns =
                let media_type =
                    { registry = "application"
                      name = "vnd.ffsns" }

            module fgb =
                let media_type =
                    { registry = "application"
                      name = "vnd.fgb" }

            module ficlab =
                module flb =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ficlab.flb+zip" }

            module filmit =
                module zfc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.filmit.zfc" }

            module fints =
                let media_type =
                    { registry = "application"
                      name = "vnd.fints" }

            module firemonkeys =
                module cloudcell =
                    let media_type =
                        { registry = "application"
                          name = "vnd.firemonkeys.cloudcell" }

            module fluxtime =
                module clip =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fluxtime.clip" }

            module font =
                module fontforge =
                    module sfd =
                        let media_type =
                            { registry = "application"
                              name = "vnd.font-fontforge-sfd" }

            module foritech =
                module container =
                    let media_type =
                        { registry = "application"
                          name = "vnd.foritech.container" }

            module framemaker =
                let media_type =
                    { registry = "application"
                      name = "vnd.framemaker" }

            module freelog =
                module comic =
                    let media_type =
                        { registry = "application"
                          name = "vnd.freelog.comic" }

            module fsc =
                module weblaunch =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fsc.weblaunch" }

            module fujifilm =
                module fb =
                    module docuworks =
                        let media_type =
                            { registry = "application"
                              name = "vnd.fujifilm.fb.docuworks" }

                        module binder =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.fujifilm.fb.docuworks.binder" }

                        module container =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.fujifilm.fb.docuworks.container" }

                    module jfi =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.fujifilm.fb.jfi+xml" }

            module fujitsu =
                module oasys =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujitsu.oasys" }

                module oasys2 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujitsu.oasys2" }

                module oasys3 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujitsu.oasys3" }

                module oasysgp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujitsu.oasysgp" }

                module oasysprs =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujitsu.oasysprs" }

            module fujixerox =
                module ART =
                    module EX =
                        let media_type =
                            { registry = "application"
                              name = "vnd.fujixerox.ART-EX" }

                module ART4 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujixerox.ART4" }

                module HBPL =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujixerox.HBPL" }

                module ddd =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujixerox.ddd" }

                module docuworks =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fujixerox.docuworks" }

                    module binder =
                        let media_type =
                            { registry = "application"
                              name = "vnd.fujixerox.docuworks.binder" }

                    module container =
                        let media_type =
                            { registry = "application"
                              name = "vnd.fujixerox.docuworks.container" }

            module fut =
                module misnet =
                    let media_type =
                        { registry = "application"
                          name = "vnd.fut-misnet" }

            module futoin =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "vnd.futoin+cbor" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.futoin+json" }

            module fuzzysheet =
                let media_type =
                    { registry = "application"
                      name = "vnd.fuzzysheet" }

            module g3pix =
                module g3fc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.g3pix.g3fc" }

            module ga4gh =
                module passport =
                    module jwt =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ga4gh.passport+jwt" }

            module genomatix =
                module tuxedo =
                    let media_type =
                        { registry = "application"
                          name = "vnd.genomatix.tuxedo" }

            module genozip =
                let media_type =
                    { registry = "application"
                      name = "vnd.genozip" }

            module gentics =
                module grd =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.gentics.grd+json" }

            module gentoo =
                module catmetadata =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.gentoo.catmetadata+xml" }

                module ebuild =
                    let media_type =
                        { registry = "application"
                          name = "vnd.gentoo.ebuild" }

                module eclass =
                    let media_type =
                        { registry = "application"
                          name = "vnd.gentoo.eclass" }

                module gpkg =
                    let media_type =
                        { registry = "application"
                          name = "vnd.gentoo.gpkg" }

                module manifest =
                    let media_type =
                        { registry = "application"
                          name = "vnd.gentoo.manifest" }

                module pkgmetadata =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.gentoo.pkgmetadata+xml" }

                module xpak =
                    let media_type =
                        { registry = "application"
                          name = "vnd.gentoo.xpak" }

            module geogebra =
                module file =
                    let media_type =
                        { registry = "application"
                          name = "vnd.geogebra.file" }

                module pinboard =
                    let media_type =
                        { registry = "application"
                          name = "vnd.geogebra.pinboard" }

                module slides =
                    let media_type =
                        { registry = "application"
                          name = "vnd.geogebra.slides" }

                module tool =
                    let media_type =
                        { registry = "application"
                          name = "vnd.geogebra.tool" }

            module geometry =
                module explorer =
                    let media_type =
                        { registry = "application"
                          name = "vnd.geometry-explorer" }

            module geonext =
                let media_type =
                    { registry = "application"
                      name = "vnd.geonext" }

            module geoplan =
                let media_type =
                    { registry = "application"
                      name = "vnd.geoplan" }

            module geospace =
                let media_type =
                    { registry = "application"
                      name = "vnd.geospace" }

            module gerber =
                let media_type =
                    { registry = "application"
                      name = "vnd.gerber" }

            module globalplatform =
                module card =
                    module content =
                        module mgt =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.globalplatform.card-content-mgt" }

                            module response =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.globalplatform.card-content-mgt-response" }

            module gnu =
                module taler =
                    module exchange =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.gnu.taler.exchange+json" }

                    module merchant =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.gnu.taler.merchant+json" }

            module google =
                module earth =
                    module kml =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.google-earth.kml+xml" }

                    module kmz =
                        let media_type =
                            { registry = "application"
                              name = "vnd.google-earth.kmz" }

            module gov =
                module sk =
                    module e =
                        module form =
                            module zip =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.gov.sk.e-form+zip" }

                    module xmldatacontainer =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.gov.sk.xmldatacontainer+xml" }

            module gp3 =
                let media_type =
                    { registry = "application"
                      name = "vnd.gp3" }

            module gpxsee =
                module map =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.gpxsee.map+xml" }

            module grafeq =
                let media_type =
                    { registry = "application"
                      name = "vnd.grafeq" }

            module gridmp =
                let media_type =
                    { registry = "application"
                      name = "vnd.gridmp" }

            module groove =
                module account =
                    let media_type =
                        { registry = "application"
                          name = "vnd.groove-account" }

                module help =
                    let media_type =
                        { registry = "application"
                          name = "vnd.groove-help" }

                module identity =
                    module message =
                        let media_type =
                            { registry = "application"
                              name = "vnd.groove-identity-message" }

                module injector =
                    let media_type =
                        { registry = "application"
                          name = "vnd.groove-injector" }

                module tool =
                    module message =
                        let media_type =
                            { registry = "application"
                              name = "vnd.groove-tool-message" }

                    module template =
                        let media_type =
                            { registry = "application"
                              name = "vnd.groove-tool-template" }

                module vcard =
                    let media_type =
                        { registry = "application"
                          name = "vnd.groove-vcard" }

            module hal =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hal+json" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hal+xml" }

            module hbci =
                let media_type =
                    { registry = "application"
                      name = "vnd.hbci" }

            module hc =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hc+json" }

            module hcl =
                module bireports =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hcl-bireports" }

            module hdfgroup =
                module hdf4 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hdfgroup.hdf4" }

                module hdf5 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hdfgroup.hdf5" }

            module hdt =
                let media_type =
                    { registry = "application"
                      name = "vnd.hdt" }

            module heroku =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.heroku+json" }

            module hhe =
                module lesson =
                    module player =
                        let media_type =
                            { registry = "application"
                              name = "vnd.hhe.lesson-player" }

            module hp =
                module HPGL =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hp-HPGL" }

                module PCL =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hp-PCL" }

                module PCLXL =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hp-PCLXL" }

                module hpid =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hp-hpid" }

                module hps =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hp-hps" }

                module jlyt =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hp-jlyt" }

            module hsl =
                let media_type =
                    { registry = "application"
                      name = "vnd.hsl" }

            module httphone =
                let media_type =
                    { registry = "application"
                      name = "vnd.httphone" }

            module hydrostatix =
                module sof =
                    module data =
                        let media_type =
                            { registry = "application"
                              name = "vnd.hydrostatix.sof-data" }

            module hyper =
                module item =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.hyper-item+json" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hyper+json" }

            module hyperdrive =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.hyperdrive+json" }

            module hzn =
                module _3d =
                    module crossword =
                        let media_type =
                            { registry = "application"
                              name = "vnd.hzn-3d-crossword" }

            module ibm =
                module MiniPay =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ibm.MiniPay" }

                module electronic =
                    module media =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ibm.electronic-media" }

                module rights =
                    module management =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ibm.rights-management" }

                module secure =
                    module container =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ibm.secure-container" }

            module iccprofile =
                let media_type =
                    { registry = "application"
                      name = "vnd.iccprofile" }

            module ieee =
                module _1905 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ieee.1905" }

            module igloader =
                let media_type =
                    { registry = "application"
                      name = "vnd.igloader" }

            module imagemeter =
                module folder =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.imagemeter.folder+zip" }

                module image =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.imagemeter.image+zip" }

            module immervision =
                module ivp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.immervision-ivp" }

                module ivu =
                    let media_type =
                        { registry = "application"
                          name = "vnd.immervision-ivu" }

            module ims =
                module imsccv1p1 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ims.imsccv1p1" }

                module imsccv1p2 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ims.imsccv1p2" }

                module imsccv1p3 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ims.imsccv1p3" }

                module lis =
                    module v2 =
                        module result =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ims.lis.v2.result+json" }

                module lti =
                    module v2 =
                        module toolconsumerprofile =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ims.lti.v2.toolconsumerprofile+json" }

                        module toolproxy =
                            module id =
                                module json =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.ims.lti.v2.toolproxy.id+json" }

                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ims.lti.v2.toolproxy+json" }

                        module toolsettings =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ims.lti.v2.toolsettings+json" }

                            module simple =
                                module json =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.ims.lti.v2.toolsettings.simple+json" }

            module informedcontrol =
                module rms =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.informedcontrol.rms+xml" }

            module infotech =
                module project =
                    let media_type =
                        { registry = "application"
                          name = "vnd.infotech.project" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.infotech.project+xml" }

            module innopath =
                module wamp =
                    module notification =
                        let media_type =
                            { registry = "application"
                              name = "vnd.innopath.wamp.notification" }

            module insors =
                module igm =
                    let media_type =
                        { registry = "application"
                          name = "vnd.insors.igm" }

            module intercon =
                module formnet =
                    let media_type =
                        { registry = "application"
                          name = "vnd.intercon.formnet" }

            module intergeo =
                let media_type =
                    { registry = "application"
                      name = "vnd.intergeo" }

            module intertrust =
                module digibox =
                    let media_type =
                        { registry = "application"
                          name = "vnd.intertrust.digibox" }

                module nncp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.intertrust.nncp" }

            module intu =
                module qbo =
                    let media_type =
                        { registry = "application"
                          name = "vnd.intu.qbo" }

                module qfx =
                    let media_type =
                        { registry = "application"
                          name = "vnd.intu.qfx" }

            module ipfs =
                module ipns =
                    module record =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ipfs.ipns-record" }

            module ipld =
                module car =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ipld.car" }

                module dag =
                    module cbor =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ipld.dag-cbor" }

                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ipld.dag-json" }

                module raw =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ipld.raw" }

            module iptc =
                module g2 =
                    module catalogitem =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.catalogitem+xml" }

                    module conceptitem =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.conceptitem+xml" }

                    module knowledgeitem =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.knowledgeitem+xml" }

                    module newsitem =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.newsitem+xml" }

                    module newsmessage =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.newsmessage+xml" }

                    module packageitem =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.packageitem+xml" }

                    module planningitem =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.iptc.g2.planningitem+xml" }

            module ipunplugged =
                module rcprofile =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ipunplugged.rcprofile" }

            module irepository =
                module package =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.irepository.package+xml" }

            module is =
                module xpr =
                    let media_type =
                        { registry = "application"
                          name = "vnd.is-xpr" }

            module isac =
                module fcs =
                    let media_type =
                        { registry = "application"
                          name = "vnd.isac.fcs" }

            module iso11783 =
                module _10 =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.iso11783-10+zip" }

            module jam =
                let media_type =
                    { registry = "application"
                      name = "vnd.jam" }

            module japannet =
                module directory =
                    module service =
                        let media_type =
                            { registry = "application"
                              name = "vnd.japannet-directory-service" }

                module jpnstore =
                    module wakeup =
                        let media_type =
                            { registry = "application"
                              name = "vnd.japannet-jpnstore-wakeup" }

                module payment =
                    module wakeup =
                        let media_type =
                            { registry = "application"
                              name = "vnd.japannet-payment-wakeup" }

                module registration =
                    let media_type =
                        { registry = "application"
                          name = "vnd.japannet-registration" }

                    module wakeup =
                        let media_type =
                            { registry = "application"
                              name = "vnd.japannet-registration-wakeup" }

                module setstore =
                    module wakeup =
                        let media_type =
                            { registry = "application"
                              name = "vnd.japannet-setstore-wakeup" }

                module verification =
                    let media_type =
                        { registry = "application"
                          name = "vnd.japannet-verification" }

                    module wakeup =
                        let media_type =
                            { registry = "application"
                              name = "vnd.japannet-verification-wakeup" }

            module jcp =
                module javame =
                    module midlet =
                        module rms =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.jcp.javame.midlet-rms" }

            module jisp =
                let media_type =
                    { registry = "application"
                      name = "vnd.jisp" }

            module joost =
                module joda =
                    module archive =
                        let media_type =
                            { registry = "application"
                              name = "vnd.joost.joda-archive" }

            module jsk =
                module isdn =
                    module ngn =
                        let media_type =
                            { registry = "application"
                              name = "vnd.jsk.isdn-ngn" }

            module kahootz =
                let media_type =
                    { registry = "application"
                      name = "vnd.kahootz" }

            module kde =
                module karbon =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.karbon" }

                module kchart =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kchart" }

                module kformula =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kformula" }

                module kivio =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kivio" }

                module kontour =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kontour" }

                module kpresenter =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kpresenter" }

                module kspread =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kspread" }

                module kword =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kde.kword" }

            module kdl =
                let media_type =
                    { registry = "application"
                      name = "vnd.kdl" }

            module kenameaapp =
                let media_type =
                    { registry = "application"
                      name = "vnd.kenameaapp" }

            module keyman =
                module kmp =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.keyman.kmp+zip" }

                module kmx =
                    let media_type =
                        { registry = "application"
                          name = "vnd.keyman.kmx" }

            module kidspiration =
                let media_type =
                    { registry = "application"
                      name = "vnd.kidspiration" }

            module koan =
                let media_type =
                    { registry = "application"
                      name = "vnd.koan" }

            module kodak =
                module descriptor =
                    let media_type =
                        { registry = "application"
                          name = "vnd.kodak-descriptor" }

            module las =
                let media_type =
                    { registry = "application"
                      name = "vnd.las" }

                module las =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.las.las+json" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.las.las+xml" }

            module laszip =
                let media_type =
                    { registry = "application"
                      name = "vnd.laszip" }

            module ldev =
                module productlicensing =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ldev.productlicensing" }

            module leap =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.leap+json" }

            module liberty =
                module request =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.liberty-request+xml" }

            module llamagraphics =
                module life =
                    module balance =
                        module desktop =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.llamagraphics.life-balance.desktop" }

                        module exchange =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.llamagraphics.life-balance.exchange+xml" }

            module logipipe =
                module circuit =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.logipipe.circuit+zip" }

            module loom =
                let media_type =
                    { registry = "application"
                      name = "vnd.loom" }

            module lotus =
                module _1 =
                    module _2 =
                        module _3 =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.lotus-1-2-3" }

                module approach =
                    let media_type =
                        { registry = "application"
                          name = "vnd.lotus-approach" }

                module freelance =
                    let media_type =
                        { registry = "application"
                          name = "vnd.lotus-freelance" }

                module notes =
                    let media_type =
                        { registry = "application"
                          name = "vnd.lotus-notes" }

                module organizer =
                    let media_type =
                        { registry = "application"
                          name = "vnd.lotus-organizer" }

                module screencam =
                    let media_type =
                        { registry = "application"
                          name = "vnd.lotus-screencam" }

                module wordpro =
                    let media_type =
                        { registry = "application"
                          name = "vnd.lotus-wordpro" }

            module lukuid =
                module package =
                    module zip =
                        let media_type =
                            { registry = "application"
                              name = "vnd.lukuid.package+zip" }

            module macports =
                module portpkg =
                    let media_type =
                        { registry = "application"
                          name = "vnd.macports.portpkg" }

            module majikah =
                module bundle =
                    let media_type =
                        { registry = "application"
                          name = "vnd.majikah.bundle" }

            module maml =
                let media_type =
                    { registry = "application"
                      name = "vnd.maml" }

            module mapbox =
                module vector =
                    module tile =
                        let media_type =
                            { registry = "application"
                              name = "vnd.mapbox-vector-tile" }

            module marlin =
                module drm =
                    module actiontoken =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.marlin.drm.actiontoken+xml" }

                    module conftoken =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.marlin.drm.conftoken+xml" }

                    module license =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.marlin.drm.license+xml" }

                    module mdcf =
                        let media_type =
                            { registry = "application"
                              name = "vnd.marlin.drm.mdcf" }

            module mason =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.mason+json" }

            module maxar =
                module archive =
                    module _3tz =
                        module zip =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.maxar.archive.3tz+zip" }

            module maxmind =
                module maxmind =
                    module db =
                        let media_type =
                            { registry = "application"
                              name = "vnd.maxmind.maxmind-db" }

            module mcd =
                let media_type =
                    { registry = "application"
                      name = "vnd.mcd" }

            module mdl =
                let media_type =
                    { registry = "application"
                      name = "vnd.mdl" }

                module mbsdf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.mdl-mbsdf" }

            module medcalcdata =
                let media_type =
                    { registry = "application"
                      name = "vnd.medcalcdata" }

            module mediastation =
                module cdkey =
                    let media_type =
                        { registry = "application"
                          name = "vnd.mediastation.cdkey" }

            module medicalholodeck =
                module recordxr =
                    let media_type =
                        { registry = "application"
                          name = "vnd.medicalholodeck.recordxr" }

            module meridian =
                module slingshot =
                    let media_type =
                        { registry = "application"
                          name = "vnd.meridian-slingshot" }

            module mermaid =
                let media_type =
                    { registry = "application"
                      name = "vnd.mermaid" }

            module mfmp =
                let media_type =
                    { registry = "application"
                      name = "vnd.mfmp" }

            module micro =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.micro+json" }

            module micrografx =
                module flo =
                    let media_type =
                        { registry = "application"
                          name = "vnd.micrografx.flo" }

                module igx =
                    let media_type =
                        { registry = "application"
                          name = "vnd.micrografx.igx" }

            module microsoft =
                module portable =
                    module executable =
                        let media_type =
                            { registry = "application"
                              name = "vnd.microsoft.portable-executable" }

                module windows =
                    module thumbnail =
                        module cache =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.microsoft.windows.thumbnail-cache" }

            module miele =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.miele+json" }

            module mif =
                let media_type =
                    { registry = "application"
                      name = "vnd.mif" }

            module minisoft =
                module hp3000 =
                    module save =
                        let media_type =
                            { registry = "application"
                              name = "vnd.minisoft-hp3000-save" }

            module mitsubishi =
                module misty =
                    module guard =
                        module trustweb =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.mitsubishi.misty-guard.trustweb" }

            module modl =
                let media_type =
                    { registry = "application"
                      name = "vnd.modl" }

            module mohnetic =
                let media_type =
                    { registry = "application"
                      name = "vnd.mohnetic" }

            module mophun =
                module application =
                    let media_type =
                        { registry = "application"
                          name = "vnd.mophun.application" }

                module certificate =
                    let media_type =
                        { registry = "application"
                          name = "vnd.mophun.certificate" }

            module motorola =
                module flexsuite =
                    let media_type =
                        { registry = "application"
                          name = "vnd.motorola.flexsuite" }

                    module adsi =
                        let media_type =
                            { registry = "application"
                              name = "vnd.motorola.flexsuite.adsi" }

                    module fis =
                        let media_type =
                            { registry = "application"
                              name = "vnd.motorola.flexsuite.fis" }

                    module gotap =
                        let media_type =
                            { registry = "application"
                              name = "vnd.motorola.flexsuite.gotap" }

                    module kmr =
                        let media_type =
                            { registry = "application"
                              name = "vnd.motorola.flexsuite.kmr" }

                    module ttc =
                        let media_type =
                            { registry = "application"
                              name = "vnd.motorola.flexsuite.ttc" }

                    module wem =
                        let media_type =
                            { registry = "application"
                              name = "vnd.motorola.flexsuite.wem" }

                module iprm =
                    let media_type =
                        { registry = "application"
                          name = "vnd.motorola.iprm" }

            module mozilla =
                module xul =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.mozilla.xul+xml" }

            module ms =
                module _3mfdocument =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-3mfdocument" }

                module PrintDeviceCapabilities =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ms-PrintDeviceCapabilities+xml" }

                module PrintSchemaTicket =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ms-PrintSchemaTicket+xml" }

                module artgalry =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-artgalry" }

                module asf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-asf" }

                module cab =
                    module compressed =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ms-cab-compressed" }

                module excel =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-excel" }

                    module addin =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-excel.addin.macroEnabled.12" }

                    module sheet =
                        module binary =
                            module macroEnabled =
                                module _12 =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.ms-excel.sheet.binary.macroEnabled.12" }

                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-excel.sheet.macroEnabled.12" }

                    module template =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-excel.template.macroEnabled.12" }

                module fontobject =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-fontobject" }

                module htmlhelp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-htmlhelp" }

                module ims =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-ims" }

                module lrm =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-lrm" }

                module office =
                    module activeX =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ms-office.activeX+xml" }

                module officetheme =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-officetheme" }

                module playready =
                    module initiator =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ms-playready.initiator+xml" }

                module powerpoint =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-powerpoint" }

                    module addin =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-powerpoint.addin.macroEnabled.12" }

                    module presentation =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-powerpoint.presentation.macroEnabled.12" }

                    module slide =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-powerpoint.slide.macroEnabled.12" }

                    module slideshow =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-powerpoint.slideshow.macroEnabled.12" }

                    module template =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-powerpoint.template.macroEnabled.12" }

                module project =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-project" }

                module tnef =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-tnef" }

                module windows =
                    module devicepairing =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ms-windows.devicepairing" }

                    module nwprinting =
                        module oob =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ms-windows.nwprinting.oob" }

                    module printerpairing =
                        let media_type =
                            { registry = "application"
                              name = "vnd.ms-windows.printerpairing" }

                    module wsd =
                        module oob =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ms-windows.wsd.oob" }

                module wmdrm =
                    module lic =
                        module chlg =
                            module req =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-wmdrm.lic-chlg-req" }

                        module resp =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ms-wmdrm.lic-resp" }

                    module meter =
                        module chlg =
                            module req =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-wmdrm.meter-chlg-req" }

                        module resp =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ms-wmdrm.meter-resp" }

                module word =
                    module document =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-word.document.macroEnabled.12" }

                    module template =
                        module macroEnabled =
                            module _12 =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ms-word.template.macroEnabled.12" }

                module works =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-works" }

                module wpl =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-wpl" }

                module xpsdocument =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ms-xpsdocument" }

            module msa =
                module disk =
                    module image =
                        let media_type =
                            { registry = "application"
                              name = "vnd.msa-disk-image" }

            module mseq =
                let media_type =
                    { registry = "application"
                      name = "vnd.mseq" }

            module msgpack =
                let media_type =
                    { registry = "application"
                      name = "vnd.msgpack" }

            module msign =
                let media_type =
                    { registry = "application"
                      name = "vnd.msign" }

            module multiad =
                module creator =
                    let media_type =
                        { registry = "application"
                          name = "vnd.multiad.creator" }

                    module cif =
                        let media_type =
                            { registry = "application"
                              name = "vnd.multiad.creator.cif" }

            module music =
                module niff =
                    let media_type =
                        { registry = "application"
                          name = "vnd.music-niff" }

            module musician =
                let media_type =
                    { registry = "application"
                      name = "vnd.musician" }

            module muvee =
                module style =
                    let media_type =
                        { registry = "application"
                          name = "vnd.muvee.style" }

            module mynfc =
                let media_type =
                    { registry = "application"
                      name = "vnd.mynfc" }

            module nacamar =
                module ybrid =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nacamar.ybrid+json" }

            module nato =
                module bindingdataobject =
                    module cbor =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nato.bindingdataobject+cbor" }

                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nato.bindingdataobject+json" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nato.bindingdataobject+xml" }

                module openxmlformats =
                    module package =
                        module iepd =
                            module zip =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.nato.openxmlformats-package.iepd+zip" }

            module ncd =
                module control =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ncd.control" }

                module reference =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ncd.reference" }

            module nearst =
                module inv =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nearst.inv+json" }

            module nebumind =
                module line =
                    let media_type =
                        { registry = "application"
                          name = "vnd.nebumind.line" }

            module nervana =
                let media_type =
                    { registry = "application"
                      name = "vnd.nervana" }

            module netfpx =
                let media_type =
                    { registry = "application"
                      name = "vnd.netfpx" }

            module neurolanguage =
                module nlu =
                    let media_type =
                        { registry = "application"
                          name = "vnd.neurolanguage.nlu" }

            module nila =
                module protobuf =
                    module bundle =
                        module zip =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.nila.protobuf-bundle+zip" }

            module nimn =
                let media_type =
                    { registry = "application"
                      name = "vnd.nimn" }

            module nintendo =
                module nitro =
                    module rom =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nintendo.nitro.rom" }

                module snes =
                    module rom =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nintendo.snes.rom" }

            module nitf =
                let media_type =
                    { registry = "application"
                      name = "vnd.nitf" }

            module noblenet =
                module directory =
                    let media_type =
                        { registry = "application"
                          name = "vnd.noblenet-directory" }

                module sealer =
                    let media_type =
                        { registry = "application"
                          name = "vnd.noblenet-sealer" }

                module web =
                    let media_type =
                        { registry = "application"
                          name = "vnd.noblenet-web" }

            module nokia =
                module catalogs =
                    let media_type =
                        { registry = "application"
                          name = "vnd.nokia.catalogs" }

                module conml =
                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.conml+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.conml+xml" }

                module iSDS =
                    module radio =
                        module presets =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.nokia.iSDS-radio-presets" }

                module iptv =
                    module config =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.nokia.iptv.config+xml" }

                module landmark =
                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.landmark+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.landmark+xml" }

                module landmarkcollection =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.landmarkcollection+xml" }

                module n =
                    module gage =
                        module ac =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.nokia.n-gage.ac+xml" }

                        module data =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.nokia.n-gage.data" }

                module ncd =
                    let media_type =
                        { registry = "application"
                          name = "vnd.nokia.ncd" }

                module pcd =
                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.pcd+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.pcd+xml" }

                module radio =
                    module preset =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.radio-preset" }

                    module presets =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nokia.radio-presets" }

            module novadigm =
                module EDM =
                    let media_type =
                        { registry = "application"
                          name = "vnd.novadigm.EDM" }

                module EDX =
                    let media_type =
                        { registry = "application"
                          name = "vnd.novadigm.EDX" }

                module EXT =
                    let media_type =
                        { registry = "application"
                          name = "vnd.novadigm.EXT" }

            module ntt =
                module local =
                    module content =
                        module share =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ntt-local.content-share" }

                    module file =
                        module transfer =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.ntt-local.file-transfer" }

                    module ogw =
                        module remote =
                            module access =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ntt-local.ogw_remote-access" }

                    module sip =
                        module ta =
                            module remote =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.ntt-local.sip-ta_remote" }

                            module tcp =
                                module stream =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.ntt-local.sip-ta_tcp_stream" }

            module nubaltec =
                module nudoku =
                    module game =
                        let media_type =
                            { registry = "application"
                              name = "vnd.nubaltec.nudoku-game" }

            module oai =
                module workflows =
                    let media_type =
                        { registry = "application"
                          name = "vnd.oai.workflows" }

                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oai.workflows+json" }

                    module yaml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oai.workflows+yaml" }

            module oasis =
                module opendocument =
                    module base_ =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.base" }

                    module chart =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.chart" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.chart-template" }

                    module formula =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.formula" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.formula-template" }

                    module graphics =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.graphics" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.graphics-template" }

                    module image =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.image" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.image-template" }

                    module presentation =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.presentation" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.presentation-template" }

                    module spreadsheet =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.spreadsheet" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.spreadsheet-template" }

                    module text =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oasis.opendocument.text" }

                        module master =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.text-master" }

                            module template =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oasis.opendocument.text-master-template" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.text-template" }

                        module web =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oasis.opendocument.text-web" }

            module obn =
                let media_type =
                    { registry = "application"
                      name = "vnd.obn" }

            module ocf =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ocf+cbor" }

            module oci =
                module image =
                    module manifest =
                        module v1 =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oci.image.manifest.v1+json" }

            module oftn =
                module l10n =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oftn.l10n+json" }

            module oipf =
                module contentaccessdownload =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.contentaccessdownload+xml" }

                module contentaccessstreaming =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.contentaccessstreaming+xml" }

                module cspg =
                    module hexbinary =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.cspg-hexbinary" }

                module dae =
                    module svg =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oipf.dae.svg+xml" }

                    module xhtml =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oipf.dae.xhtml+xml" }

                module mippvcontrolmessage =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.mippvcontrolmessage+xml" }

                module pae =
                    module gem =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.pae.gem" }

                module spdiscovery =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.spdiscovery+xml" }

                module spdlist =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.spdlist+xml" }

                module ueprofile =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.ueprofile+xml" }

                module userprofile =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oipf.userprofile+xml" }

            module olpc =
                module sugar =
                    let media_type =
                        { registry = "application"
                          name = "vnd.olpc-sugar" }

            module oma =
                module bcast =
                    module associated =
                        module procedure =
                            module parameter =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.oma.bcast.associated-procedure-parameter+xml" }

                    module drm =
                        module trigger =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.bcast.drm-trigger+xml" }

                    module imd =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.bcast.imd+xml" }

                    module ltkm =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.bcast.ltkm" }

                    module notification =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.bcast.notification+xml" }

                    module provisioningtrigger =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.bcast.provisioningtrigger" }

                    module sgboot =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.bcast.sgboot" }

                    module sgdd =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.bcast.sgdd+xml" }

                    module sgdu =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.bcast.sgdu" }

                    module simple =
                        module symbol =
                            module container =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.bcast.simple-symbol-container" }

                    module smartcard =
                        module trigger =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.bcast.smartcard-trigger+xml" }

                    module sprov =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.bcast.sprov+xml" }

                    module stkm =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.bcast.stkm" }

                module cab =
                    module address =
                        module book =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.cab-address-book+xml" }

                    module feature =
                        module handler =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.cab-feature-handler+xml" }

                    module pcc =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.cab-pcc+xml" }

                    module subs =
                        module invite =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.cab-subs-invite+xml" }

                    module user =
                        module prefs =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.cab-user-prefs+xml" }

                module dcd =
                    let media_type =
                        { registry = "application"
                          name = "vnd.oma.dcd" }

                module dcdc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.oma.dcdc" }

                module dd2 =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.dd2+xml" }

                module drm =
                    module risd =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.drm.risd+xml" }

                module group =
                    module usage =
                        module list =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.group-usage-list+xml" }

                module lwm2m =
                    module cbor =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.lwm2m+cbor" }

                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.lwm2m+json" }

                    module tlv =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.lwm2m+tlv" }

                module pal =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma.pal+xml" }

                module poc =
                    module detailed =
                        module progress =
                            module report =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.oma.poc.detailed-progress-report+xml" }

                    module final =
                        module report =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.poc.final-report+xml" }

                    module groups =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.poc.groups+xml" }

                    module invocation =
                        module descriptor =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oma.poc.invocation-descriptor+xml" }

                    module optimized =
                        module progress =
                            module report =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.oma.poc.optimized-progress-report+xml" }

                module push =
                    let media_type =
                        { registry = "application"
                          name = "vnd.oma.push" }

                module scidm =
                    module messages =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.scidm.messages+xml" }

                module scws =
                    module config =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oma-scws-config" }

                    module http =
                        module request =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma-scws-http-request" }

                        module response =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma-scws-http-response" }

                module xcap =
                    module directory =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.oma.xcap-directory+xml" }

            module omads =
                module email =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.omads-email+xml" }

                module file =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.omads-file+xml" }

                module folder =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.omads-folder+xml" }

            module omaloc =
                module supl =
                    module init =
                        let media_type =
                            { registry = "application"
                              name = "vnd.omaloc-supl-init" }

            module oms =
                module cellular =
                    module cose =
                        module content =
                            module cbor =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.oms.cellular-cose-content+cbor" }

            module onepager =
                let media_type =
                    { registry = "application"
                      name = "vnd.onepager" }

            module onepagertamp =
                let media_type =
                    { registry = "application"
                      name = "vnd.onepagertamp" }

            module onepagertamx =
                let media_type =
                    { registry = "application"
                      name = "vnd.onepagertamx" }

            module onepagertat =
                let media_type =
                    { registry = "application"
                      name = "vnd.onepagertat" }

            module onepagertatp =
                let media_type =
                    { registry = "application"
                      name = "vnd.onepagertatp" }

            module onepagertatx =
                let media_type =
                    { registry = "application"
                      name = "vnd.onepagertatx" }

            module onvif =
                module metadata =
                    let media_type =
                        { registry = "application"
                          name = "vnd.onvif.metadata" }

            module openblox =
                module game =
                    module binary =
                        let media_type =
                            { registry = "application"
                              name = "vnd.openblox.game-binary" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.openblox.game+xml" }

            module openeye =
                module oeb =
                    let media_type =
                        { registry = "application"
                          name = "vnd.openeye.oeb" }

            module openprinttag =
                let media_type =
                    { registry = "application"
                      name = "vnd.openprinttag" }

            module openstreetmap =
                module data =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.openstreetmap.data+xml" }

            module opentimestamps =
                module ots =
                    let media_type =
                        { registry = "application"
                          name = "vnd.opentimestamps.ots" }

            module openvpi =
                module dspx =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.openvpi.dspx+json" }

            module openxmlformats =
                module officedocument =
                    module custom =
                        module properties =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.custom-properties+xml" }

                    module customXmlProperties =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.customXmlProperties+xml" }

                    module drawing =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.drawing+xml" }

                    module drawingml =
                        module chart =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.drawingml.chart+xml" }

                        module chartshapes =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.drawingml.chartshapes+xml" }

                        module diagramColors =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.drawingml.diagramColors+xml" }

                        module diagramData =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.drawingml.diagramData+xml" }

                        module diagramLayout =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.drawingml.diagramLayout+xml" }

                        module diagramStyle =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.drawingml.diagramStyle+xml" }

                    module extended =
                        module properties =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.extended-properties+xml" }

                    module presentationml =
                        module commentAuthors =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.commentAuthors+xml" }

                        module comments =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.comments+xml" }

                        module handoutMaster =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.handoutMaster+xml" }

                        module notesMaster =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.notesMaster+xml" }

                        module notesSlide =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.notesSlide+xml" }

                        module presProps =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.presProps+xml" }

                        module presentation =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.presentationml.presentation" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name =
                                            "vnd.openxmlformats-officedocument.presentationml.presentation.main+xml" }

                        module slide =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.presentationml.slide" }

                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.slide+xml" }

                        module slideLayout =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.slideLayout+xml" }

                        module slideMaster =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.slideMaster+xml" }

                        module slideUpdateInfo =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.slideUpdateInfo+xml" }

                        module slideshow =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.presentationml.slideshow" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-officedocument.presentationml.slideshow.main+xml" }

                        module tableStyles =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.tableStyles+xml" }

                        module tags =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.tags+xml" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.presentationml.template" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-officedocument.presentationml.template.main+xml" }

                        module viewProps =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.presentationml.viewProps+xml" }

                    module spreadsheetml =
                        module calcChain =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.calcChain+xml" }

                        module chartsheet =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.chartsheet+xml" }

                        module comments =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.comments+xml" }

                        module connections =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.connections+xml" }

                        module dialogsheet =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.dialogsheet+xml" }

                        module externalLink =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.externalLink+xml" }

                        module pivotCacheDefinition =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheDefinition+xml" }

                        module pivotCacheRecords =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.pivotCacheRecords+xml" }

                        module pivotTable =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.pivotTable+xml" }

                        module queryTable =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.queryTable+xml" }

                        module revisionHeaders =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.revisionHeaders+xml" }

                        module revisionLog =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.revisionLog+xml" }

                        module sharedStrings =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.sharedStrings+xml" }

                        module sheet =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.spreadsheetml.sheet" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml" }

                        module sheetMetadata =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.sheetMetadata+xml" }

                        module styles =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.styles+xml" }

                        module table =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.table+xml" }

                        module tableSingleCells =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.tableSingleCells+xml" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.spreadsheetml.template" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-officedocument.spreadsheetml.template.main+xml" }

                        module userNames =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.userNames+xml" }

                        module volatileDependencies =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.volatileDependencies+xml" }

                        module worksheet =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml" }

                    module theme =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.theme+xml" }

                    module themeOverride =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.themeOverride+xml" }

                    module vmlDrawing =
                        let media_type =
                            { registry = "application"
                              name = "vnd.openxmlformats-officedocument.vmlDrawing" }

                    module wordprocessingml =
                        module comments =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.comments+xml" }

                        module document =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.wordprocessingml.document" }

                            module glossary =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name =
                                            "vnd.openxmlformats-officedocument.wordprocessingml.document.glossary+xml" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml" }

                        module endnotes =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml" }

                        module fontTable =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml" }

                        module footer =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.footer+xml" }

                        module footnotes =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml" }

                        module numbering =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.numbering+xml" }

                        module settings =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.settings+xml" }

                        module styles =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.styles+xml" }

                        module template =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-officedocument.wordprocessingml.template" }

                            module main =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-officedocument.wordprocessingml.template.main+xml" }

                        module webSettings =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml" }

                module package =
                    module core =
                        module properties =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.openxmlformats-package.core-properties+xml" }

                    module digital =
                        module signature =
                            module xmlsignature =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.openxmlformats-package.digital-signature-xmlsignature+xml" }

                    module relationships =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.openxmlformats-package.relationships+xml" }

            module oracle =
                module resource =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.oracle.resource+json" }

            module orange =
                module indata =
                    let media_type =
                        { registry = "application"
                          name = "vnd.orange.indata" }

            module osa =
                module netdeploy =
                    let media_type =
                        { registry = "application"
                          name = "vnd.osa.netdeploy" }

            module osgeo =
                module mapguide =
                    module package =
                        let media_type =
                            { registry = "application"
                              name = "vnd.osgeo.mapguide.package" }

            module osgi =
                module bundle =
                    let media_type =
                        { registry = "application"
                          name = "vnd.osgi.bundle" }

                module dp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.osgi.dp" }

                module subsystem =
                    let media_type =
                        { registry = "application"
                          name = "vnd.osgi.subsystem" }

            module otps =
                module ct =
                    module kip =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.otps.ct-kip+xml" }

            module oxli =
                module countgraph =
                    let media_type =
                        { registry = "application"
                          name = "vnd.oxli.countgraph" }

            module pagerduty =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pagerduty+json" }

            module palm =
                let media_type =
                    { registry = "application"
                      name = "vnd.palm" }

            module panoply =
                let media_type =
                    { registry = "application"
                      name = "vnd.panoply" }

            module paos =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.paos.xml" }

            module pasti =
                module stx =
                    module disk =
                        module image =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.pasti-stx-disk-image" }

            module patentdive =
                let media_type =
                    { registry = "application"
                      name = "vnd.patentdive" }

            module patientecommsdoc =
                let media_type =
                    { registry = "application"
                      name = "vnd.patientecommsdoc" }

            module pawaafile =
                let media_type =
                    { registry = "application"
                      name = "vnd.pawaafile" }

            module pcos =
                let media_type =
                    { registry = "application"
                      name = "vnd.pcos" }

            module pg =
                module format =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pg.format" }

                module osasli =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pg.osasli" }

            module phbk =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.phbk+xml" }

            module piaccess =
                module application =
                    module licence =
                        let media_type =
                            { registry = "application"
                              name = "vnd.piaccess.application-licence" }

            module picsel =
                let media_type =
                    { registry = "application"
                      name = "vnd.picsel" }

            module pmi =
                module widget =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pmi.widget" }

            module pmtiles =
                let media_type =
                    { registry = "application"
                      name = "vnd.pmtiles" }

            module poc =
                module group =
                    module advertisement =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.poc.group-advertisement+xml" }

            module pocketlearn =
                let media_type =
                    { registry = "application"
                      name = "vnd.pocketlearn" }

            module powerbuilder6 =
                let media_type =
                    { registry = "application"
                      name = "vnd.powerbuilder6" }

                module s =
                    let media_type =
                        { registry = "application"
                          name = "vnd.powerbuilder6-s" }

            module powerbuilder7 =
                let media_type =
                    { registry = "application"
                      name = "vnd.powerbuilder7" }

                module s =
                    let media_type =
                        { registry = "application"
                          name = "vnd.powerbuilder7-s" }

            module powerbuilder75 =
                let media_type =
                    { registry = "application"
                      name = "vnd.powerbuilder75" }

                module s =
                    let media_type =
                        { registry = "application"
                          name = "vnd.powerbuilder75-s" }

            module pp =
                module systemverify =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.pp.systemverify+xml" }

            module preminet =
                let media_type =
                    { registry = "application"
                      name = "vnd.preminet" }

            module previewsystems =
                module box =
                    let media_type =
                        { registry = "application"
                          name = "vnd.previewsystems.box" }

            module project =
                module graph =
                    let media_type =
                        { registry = "application"
                          name = "vnd.project-graph" }

            module proteus =
                module magazine =
                    let media_type =
                        { registry = "application"
                          name = "vnd.proteus.magazine" }

            module psfs =
                let media_type =
                    { registry = "application"
                      name = "vnd.psfs" }

            module pt =
                module mundusmundi =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pt.mundusmundi" }

            module publishare =
                module delta =
                    module tree =
                        let media_type =
                            { registry = "application"
                              name = "vnd.publishare-delta-tree" }

            module pvi =
                module ptid1 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pvi.ptid1" }

            module pwg =
                module multiplexed =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pwg-multiplexed" }

                module xhtml =
                    module print =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.pwg-xhtml-print+xml" }

            module pyon =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.pyon+json" }

            module qualcomm =
                module brew =
                    module app =
                        module res =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.qualcomm.brew-app-res" }

            module quarantainenet =
                let media_type =
                    { registry = "application"
                      name = "vnd.quarantainenet" }

            module quobject =
                module quoxdocument =
                    let media_type =
                        { registry = "application"
                          name = "vnd.quobject-quoxdocument" }

            module radisys =
                module moml =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.radisys.moml+xml" }

                module msml =
                    module audit =
                        module conf =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-audit-conf+xml" }

                        module conn =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-audit-conn+xml" }

                        module dialog =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-audit-dialog+xml" }

                        module stream =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-audit-stream+xml" }

                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.radisys.msml-audit+xml" }

                    module conf =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.radisys.msml-conf+xml" }

                    module dialog =
                        module base_ =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-dialog-base+xml" }

                        module fax =
                            module detect =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.radisys.msml-dialog-fax-detect+xml" }

                            module sendrecv =
                                module xml =
                                    let media_type =
                                        { registry = "application"
                                          name = "vnd.radisys.msml-dialog-fax-sendrecv+xml" }

                        module group =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-dialog-group+xml" }

                        module speech =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-dialog-speech+xml" }

                        module transform =
                            module xml =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.radisys.msml-dialog-transform+xml" }

                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.radisys.msml-dialog+xml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.radisys.msml+xml" }

            module rainstor =
                module data =
                    let media_type =
                        { registry = "application"
                          name = "vnd.rainstor.data" }

            module rapid =
                let media_type =
                    { registry = "application"
                      name = "vnd.rapid" }

            module rar =
                let media_type =
                    { registry = "application"
                      name = "vnd.rar" }

            module realvnc =
                module bed =
                    let media_type =
                        { registry = "application"
                          name = "vnd.realvnc.bed" }

            module recordare =
                module musicxml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.recordare.musicxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.recordare.musicxml+xml" }

            module rego =
                let media_type =
                    { registry = "application"
                      name = "vnd.rego" }

            module relpipe =
                let media_type =
                    { registry = "application"
                      name = "vnd.relpipe" }

            module resilient =
                module logic =
                    let media_type =
                        { registry = "application"
                          name = "vnd.resilient.logic" }

            module restful =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.restful+json" }

            module rig =
                module cryptonote =
                    let media_type =
                        { registry = "application"
                          name = "vnd.rig.cryptonote" }

            module route66 =
                module link66 =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.route66.link66+xml" }

            module rs =
                module _274x =
                    let media_type =
                        { registry = "application"
                          name = "vnd.rs-274x" }

            module ruckus =
                module download =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ruckus.download" }

            module s3sms =
                let media_type =
                    { registry = "application"
                      name = "vnd.s3sms" }

            module sailingtracker =
                module track =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sailingtracker.track" }

            module sar =
                let media_type =
                    { registry = "application"
                      name = "vnd.sar" }

            module sbm =
                module cid =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sbm.cid" }

                module mid2 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sbm.mid2" }

            module scribus =
                let media_type =
                    { registry = "application"
                      name = "vnd.scribus" }

            module sealed_ =
                module _3df =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.3df" }

                module csf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.csf" }

                module doc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.doc" }

                module eml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.eml" }

                module mht =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.mht" }

                module net =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.net" }

                module ppt =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.ppt" }

                module tiff =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.tiff" }

                module xls =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sealed.xls" }

            module sealedmedia =
                module softseal =
                    module html =
                        let media_type =
                            { registry = "application"
                              name = "vnd.sealedmedia.softseal.html" }

                    module pdf =
                        let media_type =
                            { registry = "application"
                              name = "vnd.sealedmedia.softseal.pdf" }

            module seemail =
                let media_type =
                    { registry = "application"
                      name = "vnd.seemail" }

            module seis =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.seis+json" }

            module sema =
                let media_type =
                    { registry = "application"
                      name = "vnd.sema" }

            module semd =
                let media_type =
                    { registry = "application"
                      name = "vnd.semd" }

            module semf =
                let media_type =
                    { registry = "application"
                      name = "vnd.semf" }

            module shade =
                module save =
                    module file =
                        let media_type =
                            { registry = "application"
                              name = "vnd.shade-save-file" }

            module shana =
                module informed =
                    module formdata =
                        let media_type =
                            { registry = "application"
                              name = "vnd.shana.informed.formdata" }

                    module formtemplate =
                        let media_type =
                            { registry = "application"
                              name = "vnd.shana.informed.formtemplate" }

                    module interchange =
                        let media_type =
                            { registry = "application"
                              name = "vnd.shana.informed.interchange" }

                    module package =
                        let media_type =
                            { registry = "application"
                              name = "vnd.shana.informed.package" }

            module shootproof =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.shootproof+json" }

            module shopkick =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.shopkick+json" }

            module shp =
                let media_type =
                    { registry = "application"
                      name = "vnd.shp" }

            module shx =
                let media_type =
                    { registry = "application"
                      name = "vnd.shx" }

            module sigrok =
                module session =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sigrok.session" }

            module siren =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.siren+json" }

            module sirtx =
                module vmv0 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sirtx.vmv0" }

            module sketchometry =
                let media_type =
                    { registry = "application"
                      name = "vnd.sketchometry" }

            module smaf =
                let media_type =
                    { registry = "application"
                      name = "vnd.smaf" }

            module smart =
                module notebook =
                    let media_type =
                        { registry = "application"
                          name = "vnd.smart.notebook" }

                module teacher =
                    let media_type =
                        { registry = "application"
                          name = "vnd.smart.teacher" }

            module smintio =
                module portals =
                    module archive =
                        let media_type =
                            { registry = "application"
                              name = "vnd.smintio.portals.archive" }

            module snesdev =
                module page =
                    module table =
                        let media_type =
                            { registry = "application"
                              name = "vnd.snesdev-page-table" }

            module softpres =
                module ipf =
                    module disk =
                        module image =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.softpres-ipf-disk-image" }

            module software602 =
                module filler =
                    module form =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.software602.filler.form+xml" }

                            module zip =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.software602.filler.form-xml-zip" }

            module solent =
                module sdkm =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.solent.sdkm+xml" }

            module spotfire =
                module dxp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.spotfire.dxp" }

                module sfs =
                    let media_type =
                        { registry = "application"
                          name = "vnd.spotfire.sfs" }

            module sqlite3 =
                let media_type =
                    { registry = "application"
                      name = "vnd.sqlite3" }

            module sri =
                let media_type =
                    { registry = "application"
                      name = "vnd.sri" }

            module sss =
                module cod =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sss-cod" }

                module dtf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sss-dtf" }

                module ntf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sss-ntf" }

            module stepmania =
                module package =
                    let media_type =
                        { registry = "application"
                          name = "vnd.stepmania.package" }

                module stepchart =
                    let media_type =
                        { registry = "application"
                          name = "vnd.stepmania.stepchart" }

            module street =
                module stream =
                    let media_type =
                        { registry = "application"
                          name = "vnd.street-stream" }

            module sun =
                module wadl =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.sun.wadl+xml" }

            module supercard =
                module pro =
                    module disk =
                        module image =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.supercard-pro-disk-image" }

            module superfile =
                module super =
                    let media_type =
                        { registry = "application"
                          name = "vnd.superfile.super" }

            module sus =
                module calendar =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sus-calendar" }

            module svd =
                let media_type =
                    { registry = "application"
                      name = "vnd.svd" }

            module svr =
                module receipt =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.svr.receipt+json" }

            module swiftview =
                module ics =
                    let media_type =
                        { registry = "application"
                          name = "vnd.swiftview-ics" }

            module sybyl =
                module mol2 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sybyl.mol2" }

            module sycle =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.sycle+xml" }

            module syft =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.syft+json" }

            module syncml =
                module dm =
                    module notification =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dm.notification" }

                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dm+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dm+xml" }

                module dmddf =
                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dmddf+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dmddf+xml" }

                module dmtnds =
                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dmtnds+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.dmtnds+xml" }

                module ds =
                    module notification =
                        let media_type =
                            { registry = "application"
                              name = "vnd.syncml.ds.notification" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.syncml+xml" }

            module tableschema =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.tableschema+json" }

            module tao =
                module intent =
                    module module_ =
                        module archive =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.tao.intent-module-archive" }

            module tcpdump =
                module pcap =
                    let media_type =
                        { registry = "application"
                          name = "vnd.tcpdump.pcap" }

            module think =
                module cell =
                    module ppttc =
                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.think-cell.ppttc+json" }

            module tmd =
                module mediaflex =
                    module api =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.tmd.mediaflex.api+xml" }

            module tml =
                let media_type =
                    { registry = "application"
                      name = "vnd.tml" }

            module tmobile =
                module livetv =
                    let media_type =
                        { registry = "application"
                          name = "vnd.tmobile-livetv" }

            module tri =
                module onesource =
                    let media_type =
                        { registry = "application"
                          name = "vnd.tri.onesource" }

            module trid =
                module tpt =
                    let media_type =
                        { registry = "application"
                          name = "vnd.trid.tpt" }

            module triscape =
                module mxs =
                    let media_type =
                        { registry = "application"
                          name = "vnd.triscape.mxs" }

            module trueapp =
                let media_type =
                    { registry = "application"
                      name = "vnd.trueapp" }

            module truedoc =
                let media_type =
                    { registry = "application"
                      name = "vnd.truedoc" }

            module ubisoft =
                module webplayer =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ubisoft.webplayer" }

            module ufdl =
                let media_type =
                    { registry = "application"
                      name = "vnd.ufdl" }

            module uic =
                module dosipas =
                    module v1 =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uic.dosipas.v1" }

                    module v2 =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uic.dosipas.v2" }

                module osdm =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uic.osdm+json" }

                module tlb =
                    module fcb =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uic.tlb-fcb" }

            module uiq =
                module theme =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uiq.theme" }

            module umajin =
                let media_type =
                    { registry = "application"
                      name = "vnd.umajin" }

            module unity =
                let media_type =
                    { registry = "application"
                      name = "vnd.unity" }

            module uoml =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uoml+xml" }

            module uplanet =
                module alert =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uplanet.alert" }

                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uplanet.alert-wbxml" }

                module bearer =
                    module choice =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uplanet.bearer-choice" }

                        module wbxml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.uplanet.bearer-choice-wbxml" }

                module cacheop =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uplanet.cacheop" }

                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uplanet.cacheop-wbxml" }

                module channel =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uplanet.channel" }

                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uplanet.channel-wbxml" }

                module list =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uplanet.list" }

                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uplanet.list-wbxml" }

                module listcmd =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uplanet.listcmd" }

                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.uplanet.listcmd-wbxml" }

                module signal =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uplanet.signal" }

            module uri =
                module map =
                    let media_type =
                        { registry = "application"
                          name = "vnd.uri-map" }

            module valve =
                module source =
                    module material =
                        let media_type =
                            { registry = "application"
                              name = "vnd.valve.source.material" }

            module vcx =
                let media_type =
                    { registry = "application"
                      name = "vnd.vcx" }

            module vd =
                module study =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vd-study" }

            module vectorworks =
                let media_type =
                    { registry = "application"
                      name = "vnd.vectorworks" }

            module vel =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vel+json" }

            module veraison =
                module nvidia =
                    module gpu =
                        module evidence =
                            module json =
                                let media_type =
                                    { registry = "application"
                                      name = "vnd.veraison.nvidia-gpu-evidence+json" }

                module tsm =
                    module report =
                        module cbor =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.veraison.tsm-report+cbor" }

                        module json =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.veraison.tsm-report+json" }

            module verifier =
                module attestation =
                    module jwt =
                        let media_type =
                            { registry = "application"
                              name = "vnd.verifier-attestation+jwt" }

            module verimatrix =
                module vcas =
                    let media_type =
                        { registry = "application"
                          name = "vnd.verimatrix.vcas" }

            module veritone =
                module aion =
                    module json =
                        let media_type =
                            { registry = "application"
                              name = "vnd.veritone.aion+json" }

            module vertifile =
                module pvf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vertifile.pvf" }

            module veryant =
                module thin =
                    let media_type =
                        { registry = "application"
                          name = "vnd.veryant.thin" }

            module ves =
                module encrypted =
                    let media_type =
                        { registry = "application"
                          name = "vnd.ves.encrypted" }

            module vidsoft =
                module vidconference =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vidsoft.vidconference" }

            module vimina =
                module vma =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vimina.vma" }

            module visio =
                let media_type =
                    { registry = "application"
                      name = "vnd.visio" }

            module visionary =
                let media_type =
                    { registry = "application"
                      name = "vnd.visionary" }

            module vividence =
                module scriptfile =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vividence.scriptfile" }

            module vocalshaper =
                module vsp4 =
                    let media_type =
                        { registry = "application"
                          name = "vnd.vocalshaper.vsp4" }

            module vsf =
                let media_type =
                    { registry = "application"
                      name = "vnd.vsf" }

            module vuq =
                let media_type =
                    { registry = "application"
                      name = "vnd.vuq" }

            module wantverse =
                let media_type =
                    { registry = "application"
                      name = "vnd.wantverse" }

            module wap =
                module sic =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wap.sic" }

                module slc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wap.slc" }

                module wbxml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wap.wbxml" }

                module wmlc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wap.wmlc" }

                module wmlscriptc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wap.wmlscriptc" }

            module wasmflow =
                module wafl =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wasmflow.wafl" }

            module webturbo =
                let media_type =
                    { registry = "application"
                      name = "vnd.webturbo" }

            module wfa =
                module dpp =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wfa.dpp" }

                module p2p =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wfa.p2p" }

                module wsc =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wfa.wsc" }

            module windows =
                module devicepairing =
                    let media_type =
                        { registry = "application"
                          name = "vnd.windows.devicepairing" }

            module wmap =
                let media_type =
                    { registry = "application"
                      name = "vnd.wmap" }

            module wmc =
                let media_type =
                    { registry = "application"
                      name = "vnd.wmc" }

            module wmf =
                module bootstrap =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wmf.bootstrap" }

            module wolfram =
                module mathematica =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wolfram.mathematica" }

                    module package =
                        let media_type =
                            { registry = "application"
                              name = "vnd.wolfram.mathematica.package" }

                module player =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wolfram.player" }

            module wordlift =
                let media_type =
                    { registry = "application"
                      name = "vnd.wordlift" }

            module wordperfect =
                let media_type =
                    { registry = "application"
                      name = "vnd.wordperfect" }

            module wqd =
                let media_type =
                    { registry = "application"
                      name = "vnd.wqd" }

            module wrq =
                module hp3000 =
                    module labelled =
                        let media_type =
                            { registry = "application"
                              name = "vnd.wrq-hp3000-labelled" }

            module wt =
                module stf =
                    let media_type =
                        { registry = "application"
                          name = "vnd.wt.stf" }

            module wv =
                module csp =
                    module wbxml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.wv.csp+wbxml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.wv.csp+xml" }

                module ssp =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.wv.ssp+xml" }

            module xacml =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xacml+json" }

            module xara =
                let media_type =
                    { registry = "application"
                      name = "vnd.xara" }

            module xarin =
                module cpj =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xarin.cpj" }

            module xcdn =
                let media_type =
                    { registry = "application"
                      name = "vnd.xcdn" }

            module xecrets =
                module encrypted =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xecrets-encrypted" }

            module xfdl =
                let media_type =
                    { registry = "application"
                      name = "vnd.xfdl" }

                module webform =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xfdl.webform" }

            module xmi =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xmi+xml" }

            module xmpie =
                module cpkg =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xmpie.cpkg" }

                module dpkg =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xmpie.dpkg" }

                module plan =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xmpie.plan" }

                module ppkg =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xmpie.ppkg" }

                module xlim =
                    let media_type =
                        { registry = "application"
                          name = "vnd.xmpie.xlim" }

            module yamaha =
                module hv =
                    module dic =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.hv-dic" }

                    module script =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.hv-script" }

                    module voice =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.hv-voice" }

                module openscoreformat =
                    let media_type =
                        { registry = "application"
                          name = "vnd.yamaha.openscoreformat" }

                    module osfpvg =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "vnd.yamaha.openscoreformat.osfpvg+xml" }

                module remote =
                    module setup =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.remote-setup" }

                module smaf =
                    module audio =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.smaf-audio" }

                    module phrase =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.smaf-phrase" }

                module through =
                    module ngn =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.through-ngn" }

                module tunnel =
                    module udpencap =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yamaha.tunnel-udpencap" }

            module yaoweme =
                let media_type =
                    { registry = "application"
                      name = "vnd.yaoweme" }

            module yellowriver =
                module custom =
                    module menu =
                        let media_type =
                            { registry = "application"
                              name = "vnd.yellowriver-custom-menu" }

            module zoho =
                module document =
                    module writer =
                        let media_type =
                            { registry = "application"
                              name = "vnd.zoho-document.writer" }

                module presentation =
                    module show =
                        let media_type =
                            { registry = "application"
                              name = "vnd.zoho-presentation.show" }

                module spreadsheetml =
                    module sheet =
                        let media_type =
                            { registry = "application"
                              name = "vnd.zoho.spreadsheetml.sheet" }

            module zul =
                let media_type =
                    { registry = "application"
                      name = "vnd.zul" }

            module zzazz =
                module deck =
                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "vnd.zzazz.deck+xml" }

        module voicexml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "voicexml+xml" }

        module voucher =
            module cms =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "voucher-cms+json" }

            module jws =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "voucher-jws+json" }

        module vp =
            let media_type =
                { registry = "application"
                  name = "vp" }

            module cose =
                let media_type =
                    { registry = "application"
                      name = "vp+cose" }

            module jwt =
                let media_type =
                    { registry = "application"
                      name = "vp+jwt" }

            module sd =
                module jwt =
                    let media_type =
                        { registry = "application"
                          name = "vp+sd-jwt" }

        module vq =
            module rtcpxr =
                let media_type =
                    { registry = "application"
                      name = "vq-rtcpxr" }

        module wasm =
            let media_type =
                { registry = "application"
                  name = "wasm" }

        module watcherinfo =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "watcherinfo+xml" }

        module webpush =
            module options =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "webpush-options+json" }

        module whoispp =
            module query =
                let media_type =
                    { registry = "application"
                      name = "whoispp-query" }

            module response =
                let media_type =
                    { registry = "application"
                      name = "whoispp-response" }

        module widget =
            let media_type =
                { registry = "application"
                  name = "widget" }

        module wita =
            let media_type =
                { registry = "application"
                  name = "wita" }

        module wordperfect5 =
            module _1 =
                let media_type =
                    { registry = "application"
                      name = "wordperfect5.1" }

        module wsdl =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "wsdl+xml" }

        module wspolicy =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "wspolicy+xml" }

        module x =
            module pki =
                module message =
                    let media_type =
                        { registry = "application"
                          name = "x-pki-message" }

            module www =
                module form =
                    module urlencoded =
                        let media_type =
                            { registry = "application"
                              name = "x-www-form-urlencoded" }

            module x509 =
                module ca =
                    module cert =
                        let media_type =
                            { registry = "application"
                              name = "x-x509-ca-cert" }

                    module ra =
                        module cert =
                            let media_type =
                                { registry = "application"
                                  name = "x-x509-ca-ra-cert" }

                module next =
                    module ca =
                        module cert =
                            let media_type =
                                { registry = "application"
                                  name = "x-x509-next-ca-cert" }

        module x400 =
            module bp =
                let media_type =
                    { registry = "application"
                      name = "x400-bp" }

        module xacml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xacml+xml" }

        module xcap =
            module att =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xcap-att+xml" }

            module caps =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xcap-caps+xml" }

            module diff =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xcap-diff+xml" }

            module el =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xcap-el+xml" }

            module error =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xcap-error+xml" }

            module ns =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xcap-ns+xml" }

        module xcon =
            module conference =
                module info =
                    module diff =
                        module xml =
                            let media_type =
                                { registry = "application"
                                  name = "xcon-conference-info-diff+xml" }

                    module xml =
                        let media_type =
                            { registry = "application"
                              name = "xcon-conference-info+xml" }

        module xenc =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xenc+xml" }

        module xfdf =
            let media_type =
                { registry = "application"
                  name = "xfdf" }

        module xhtml =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xhtml+xml" }

        module xliff =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xliff+xml" }

        module xml =
            let media_type =
                { registry = "application"
                  name = "xml" }

            module dtd =
                let media_type =
                    { registry = "application"
                      name = "xml-dtd" }

            module external_ =
                module parsed =
                    module entity =
                        let media_type =
                            { registry = "application"
                              name = "xml-external-parsed-entity" }

            module patch =
                module xml =
                    let media_type =
                        { registry = "application"
                          name = "xml-patch+xml" }

        module xmpp =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xmpp+xml" }

        module xop =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xop+xml" }

        module xslt =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xslt+xml" }

        module xv =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "xv+xml" }

        module yaml =
            let media_type =
                { registry = "application"
                  name = "yaml" }

        module yang =
            let media_type =
                { registry = "application"
                  name = "yang" }

            module data =
                module cbor =
                    let media_type =
                        { registry = "application"
                          name = "yang-data+cbor" }

                module json =
                    let media_type =
                        { registry = "application"
                          name = "yang-data+json" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "yang-data+xml" }

            module patch =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "yang-patch+json" }

                module xml =
                    let media_type =
                        { registry = "application"
                          name = "yang-patch+xml" }

            module sid =
                module json =
                    let media_type =
                        { registry = "application"
                          name = "yang-sid+json" }

        module yin =
            module xml =
                let media_type =
                    { registry = "application"
                      name = "yin+xml" }

        module zip =
            let media_type =
                { registry = "application"
                  name = "zip" }

        module zlib =
            let media_type =
                { registry = "application"
                  name = "zlib" }

        module zstd =
            let media_type =
                { registry = "application"
                  name = "zstd" }

    module audio =
        module _1d =
            module interleaved =
                module parityfec =
                    let media_type =
                        { registry = "audio"
                          name = "1d-interleaved-parityfec" }

        module _32kadpcm =
            let media_type =
                { registry = "audio"
                  name = "32kadpcm" }

        module _3gpp =
            let media_type = { registry = "audio"; name = "3gpp" }

        module _3gpp2 =
            let media_type = { registry = "audio"; name = "3gpp2" }

        module AMR =
            let media_type = { registry = "audio"; name = "AMR" }

            module WB =
                let media_type = { registry = "audio"; name = "AMR-WB" }

        module ATRAC =
            module ADVANCED =
                module LOSSLESS =
                    let media_type =
                        { registry = "audio"
                          name = "ATRAC-ADVANCED-LOSSLESS" }

            module X =
                let media_type = { registry = "audio"; name = "ATRAC-X" }

        module ATRAC3 =
            let media_type = { registry = "audio"; name = "ATRAC3" }

        module BV16 =
            let media_type = { registry = "audio"; name = "BV16" }

        module BV32 =
            let media_type = { registry = "audio"; name = "BV32" }

        module CN =
            let media_type = { registry = "audio"; name = "CN" }

        module DAT12 =
            let media_type = { registry = "audio"; name = "DAT12" }

        module DV =
            let media_type = { registry = "audio"; name = "DV" }

        module DVI4 =
            let media_type = { registry = "audio"; name = "DVI4" }

        module EVRC =
            let media_type = { registry = "audio"; name = "EVRC" }

            module QCP =
                let media_type =
                    { registry = "audio"
                      name = "EVRC-QCP" }

        module EVRC0 =
            let media_type = { registry = "audio"; name = "EVRC0" }

        module EVRC1 =
            let media_type = { registry = "audio"; name = "EVRC1" }

        module EVRCB =
            let media_type = { registry = "audio"; name = "EVRCB" }

        module EVRCB0 =
            let media_type = { registry = "audio"; name = "EVRCB0" }

        module EVRCB1 =
            let media_type = { registry = "audio"; name = "EVRCB1" }

        module EVRCNW =
            let media_type = { registry = "audio"; name = "EVRCNW" }

        module EVRCNW0 =
            let media_type = { registry = "audio"; name = "EVRCNW0" }

        module EVRCNW1 =
            let media_type = { registry = "audio"; name = "EVRCNW1" }

        module EVRCWB =
            let media_type = { registry = "audio"; name = "EVRCWB" }

        module EVRCWB0 =
            let media_type = { registry = "audio"; name = "EVRCWB0" }

        module EVRCWB1 =
            let media_type = { registry = "audio"; name = "EVRCWB1" }

        module EVS =
            let media_type = { registry = "audio"; name = "EVS" }

        module G711 =
            module _0 =
                let media_type = { registry = "audio"; name = "G711-0" }

        module G719 =
            let media_type = { registry = "audio"; name = "G719" }

        module G722 =
            let media_type = { registry = "audio"; name = "G722" }

        module G7221 =
            let media_type = { registry = "audio"; name = "G7221" }

        module G723 =
            let media_type = { registry = "audio"; name = "G723" }

        module G726 =
            module _16 =
                let media_type = { registry = "audio"; name = "G726-16" }

            module _24 =
                let media_type = { registry = "audio"; name = "G726-24" }

            module _32 =
                let media_type = { registry = "audio"; name = "G726-32" }

            module _40 =
                let media_type = { registry = "audio"; name = "G726-40" }

        module G728 =
            let media_type = { registry = "audio"; name = "G728" }

        module G729 =
            let media_type = { registry = "audio"; name = "G729" }

        module G7291 =
            let media_type = { registry = "audio"; name = "G7291" }

        module G729D =
            let media_type = { registry = "audio"; name = "G729D" }

        module G729E =
            let media_type = { registry = "audio"; name = "G729E" }

        module GSM =
            let media_type = { registry = "audio"; name = "GSM" }

            module EFR =
                let media_type = { registry = "audio"; name = "GSM-EFR" }

            module HR =
                module _08 =
                    let media_type =
                        { registry = "audio"
                          name = "GSM-HR-08" }

        module L16 =
            let media_type = { registry = "audio"; name = "L16" }

        module L20 =
            let media_type = { registry = "audio"; name = "L20" }

        module L24 =
            let media_type = { registry = "audio"; name = "L24" }

        module L8 =
            let media_type = { registry = "audio"; name = "L8" }

        module LPC =
            let media_type = { registry = "audio"; name = "LPC" }

        module MELP =
            let media_type = { registry = "audio"; name = "MELP" }

        module MELP1200 =
            let media_type =
                { registry = "audio"
                  name = "MELP1200" }

        module MELP2400 =
            let media_type =
                { registry = "audio"
                  name = "MELP2400" }

        module MELP600 =
            let media_type = { registry = "audio"; name = "MELP600" }

        module MP4A =
            module LATM =
                let media_type =
                    { registry = "audio"
                      name = "MP4A-LATM" }

        module MPA =
            let media_type = { registry = "audio"; name = "MPA" }

        module PCMA =
            let media_type = { registry = "audio"; name = "PCMA" }

            module WB =
                let media_type = { registry = "audio"; name = "PCMA-WB" }

        module PCMU =
            let media_type = { registry = "audio"; name = "PCMU" }

            module WB =
                let media_type = { registry = "audio"; name = "PCMU-WB" }

        module QCELP =
            let media_type = { registry = "audio"; name = "QCELP" }

        module RED =
            let media_type = { registry = "audio"; name = "RED" }

        module SMV =
            let media_type = { registry = "audio"; name = "SMV" }

            module QCP =
                let media_type = { registry = "audio"; name = "SMV-QCP" }

        module SMV0 =
            let media_type = { registry = "audio"; name = "SMV0" }

        module TETRA =
            module ACELP =
                let media_type =
                    { registry = "audio"
                      name = "TETRA_ACELP" }

                module BB =
                    let media_type =
                        { registry = "audio"
                          name = "TETRA_ACELP_BB" }

        module TSVCIS =
            let media_type = { registry = "audio"; name = "TSVCIS" }

        module UEMCLIP =
            let media_type = { registry = "audio"; name = "UEMCLIP" }

        module VDVI =
            let media_type = { registry = "audio"; name = "VDVI" }

        module VMR =
            module WB =
                let media_type = { registry = "audio"; name = "VMR-WB" }

        module aac =
            let media_type = { registry = "audio"; name = "aac" }

        module ac3 =
            let media_type = { registry = "audio"; name = "ac3" }

        module amr =
            module wb =
                let media_type = { registry = "audio"; name = "amr-wb+" }

        module aptx =
            let media_type = { registry = "audio"; name = "aptx" }

        module asc =
            let media_type = { registry = "audio"; name = "asc" }

        module basic =
            let media_type = { registry = "audio"; name = "basic" }

        module clearmode =
            let media_type =
                { registry = "audio"
                  name = "clearmode" }

        module dls =
            let media_type = { registry = "audio"; name = "dls" }

        module dsr =
            module es201108 =
                let media_type =
                    { registry = "audio"
                      name = "dsr-es201108" }

            module es202050 =
                let media_type =
                    { registry = "audio"
                      name = "dsr-es202050" }

            module es202211 =
                let media_type =
                    { registry = "audio"
                      name = "dsr-es202211" }

            module es202212 =
                let media_type =
                    { registry = "audio"
                      name = "dsr-es202212" }

        module eac3 =
            let media_type = { registry = "audio"; name = "eac3" }

        module encaprtp =
            let media_type =
                { registry = "audio"
                  name = "encaprtp" }

        module example =
            let media_type = { registry = "audio"; name = "example" }

        module flac =
            let media_type = { registry = "audio"; name = "flac" }

        module flexfec =
            let media_type = { registry = "audio"; name = "flexfec" }

        module fwdred =
            let media_type = { registry = "audio"; name = "fwdred" }

        module iLBC =
            let media_type = { registry = "audio"; name = "iLBC" }

        module ip =
            module mr =
                module v2 =
                    module _5 =
                        let media_type =
                            { registry = "audio"
                              name = "ip-mr_v2.5" }

        module matroska =
            let media_type =
                { registry = "audio"
                  name = "matroska" }

        module mhas =
            let media_type = { registry = "audio"; name = "mhas" }

        module midi =
            module clip =
                let media_type =
                    { registry = "audio"
                      name = "midi-clip" }

        module mobile =
            module xmf =
                let media_type =
                    { registry = "audio"
                      name = "mobile-xmf" }

        module mp4 =
            let media_type = { registry = "audio"; name = "mp4" }

        module mpa =
            module robust =
                let media_type =
                    { registry = "audio"
                      name = "mpa-robust" }

        module mpeg =
            let media_type = { registry = "audio"; name = "mpeg" }

        module mpeg4 =
            module generic =
                let media_type =
                    { registry = "audio"
                      name = "mpeg4-generic" }

        module ogg =
            let media_type = { registry = "audio"; name = "ogg" }

        module opus =
            let media_type = { registry = "audio"; name = "opus" }

        module parityfec =
            let media_type =
                { registry = "audio"
                  name = "parityfec" }

        module prs =
            module aaud =
                let media_type =
                    { registry = "audio"
                      name = "prs.aaud" }

            module sid =
                let media_type = { registry = "audio"; name = "prs.sid" }

        module raptorfec =
            let media_type =
                { registry = "audio"
                  name = "raptorfec" }

        module rtp =
            module enc =
                module aescm128 =
                    let media_type =
                        { registry = "audio"
                          name = "rtp-enc-aescm128" }

            module midi =
                let media_type =
                    { registry = "audio"
                      name = "rtp-midi" }

        module rtploopback =
            let media_type =
                { registry = "audio"
                  name = "rtploopback" }

        module rtx =
            let media_type = { registry = "audio"; name = "rtx" }

        module scip =
            let media_type = { registry = "audio"; name = "scip" }

        module sofa =
            let media_type = { registry = "audio"; name = "sofa" }

        module soundfont =
            let media_type =
                { registry = "audio"
                  name = "soundfont" }

        module sp =
            module midi =
                let media_type = { registry = "audio"; name = "sp-midi" }

        module speex =
            let media_type = { registry = "audio"; name = "speex" }

        module t140c =
            let media_type = { registry = "audio"; name = "t140c" }

        module t38 =
            let media_type = { registry = "audio"; name = "t38" }

        module telephone =
            module event_ =
                let media_type =
                    { registry = "audio"
                      name = "telephone-event" }

        module tone =
            let media_type = { registry = "audio"; name = "tone" }

        module ulpfec =
            let media_type = { registry = "audio"; name = "ulpfec" }

        module usac =
            let media_type = { registry = "audio"; name = "usac" }

        module vnd =
            module _3gpp =
                module iufp =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.3gpp.iufp" }

            module _4SB =
                let media_type = { registry = "audio"; name = "vnd.4SB" }

            module CELP =
                let media_type =
                    { registry = "audio"
                      name = "vnd.CELP" }

            module audiokoz =
                let media_type =
                    { registry = "audio"
                      name = "vnd.audiokoz" }

            module blockfact =
                module facta =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.blockfact.facta" }

            module cisco =
                module nse =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.cisco.nse" }

            module cmles =
                module radio =
                    module events =
                        let media_type =
                            { registry = "audio"
                              name = "vnd.cmles.radio-events" }

            module cns =
                module anp1 =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.cns.anp1" }

                module inf1 =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.cns.inf1" }

            module dece =
                module audio =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dece.audio" }

            module digital =
                module winds =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.digital-winds" }

            module dlna =
                module adts =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dlna.adts" }

            module dolby =
                module heaac =
                    module _1 =
                        let media_type =
                            { registry = "audio"
                              name = "vnd.dolby.heaac.1" }

                    module _2 =
                        let media_type =
                            { registry = "audio"
                              name = "vnd.dolby.heaac.2" }

                module mlp =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dolby.mlp" }

                module mps =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dolby.mps" }

                module pl2 =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dolby.pl2" }

                module pl2x =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dolby.pl2x" }

                module pl2z =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dolby.pl2z" }

                module pulse =
                    module _1 =
                        let media_type =
                            { registry = "audio"
                              name = "vnd.dolby.pulse.1" }

            module dra =
                let media_type = { registry = "audio"; name = "vnd.dra" }

            module dts =
                let media_type = { registry = "audio"; name = "vnd.dts" }

                module hd =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dts.hd" }

                module uhd =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dts.uhd" }

            module dvb =
                module file =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.dvb.file" }

            module everad =
                module plj =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.everad.plj" }

            module hns =
                module audio =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.hns.audio" }

            module lucent =
                module voice =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.lucent.voice" }

            module ms =
                module playready =
                    module media =
                        module pya =
                            let media_type =
                                { registry = "audio"
                                  name = "vnd.ms-playready.media.pya" }

            module nokia =
                module mobile =
                    module xmf =
                        let media_type =
                            { registry = "audio"
                              name = "vnd.nokia.mobile-xmf" }

            module nortel =
                module vbk =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.nortel.vbk" }

            module nuera =
                module ecelp4800 =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.nuera.ecelp4800" }

                module ecelp7470 =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.nuera.ecelp7470" }

                module ecelp9600 =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.nuera.ecelp9600" }

            module octel =
                module sbc =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.octel.sbc" }

            module presonus =
                module multitrack =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.presonus.multitrack" }

            module rhetorex =
                module _32kadpcm =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.rhetorex.32kadpcm" }

            module rip =
                let media_type = { registry = "audio"; name = "vnd.rip" }

            module sealedmedia =
                module softseal =
                    module mpeg =
                        let media_type =
                            { registry = "audio"
                              name = "vnd.sealedmedia.softseal.mpeg" }

            module vmx =
                module cvsd =
                    let media_type =
                        { registry = "audio"
                          name = "vnd.vmx.cvsd" }

        module vorbis =
            let media_type = { registry = "audio"; name = "vorbis" }

            module config =
                let media_type =
                    { registry = "audio"
                      name = "vorbis-config" }

    module font =
        module collection =
            let media_type =
                { registry = "font"
                  name = "collection" }

        module otf =
            let media_type = { registry = "font"; name = "otf" }

        module sfnt =
            let media_type = { registry = "font"; name = "sfnt" }

        module ttf =
            let media_type = { registry = "font"; name = "ttf" }

        module woff =
            let media_type = { registry = "font"; name = "woff" }

        module woff2 =
            let media_type = { registry = "font"; name = "woff2" }

    module haptics =
        module hjif =
            let media_type = { registry = "haptics"; name = "hjif" }

        module hmpg =
            let media_type = { registry = "haptics"; name = "hmpg" }

        module ivs =
            let media_type = { registry = "haptics"; name = "ivs" }

    module image =
        module aces =
            let media_type = { registry = "image"; name = "aces" }

        module apng =
            let media_type = { registry = "image"; name = "apng" }

        module avci =
            let media_type = { registry = "image"; name = "avci" }

        module avcs =
            let media_type = { registry = "image"; name = "avcs" }

        module avif =
            let media_type = { registry = "image"; name = "avif" }

        module bmp =
            let media_type = { registry = "image"; name = "bmp" }

        module cgm =
            let media_type = { registry = "image"; name = "cgm" }

        module dicom =
            module rle =
                let media_type =
                    { registry = "image"
                      name = "dicom-rle" }

        module dpx =
            let media_type = { registry = "image"; name = "dpx" }

        module emf =
            let media_type = { registry = "image"; name = "emf" }

        module example =
            let media_type = { registry = "image"; name = "example" }

        module fits =
            let media_type = { registry = "image"; name = "fits" }

        module g3fax =
            let media_type = { registry = "image"; name = "g3fax" }

        module gif =
            let media_type = { registry = "image"; name = "gif" }

        module heic =
            let media_type = { registry = "image"; name = "heic" }

            module sequence =
                let media_type =
                    { registry = "image"
                      name = "heic-sequence" }

        module heif =
            let media_type = { registry = "image"; name = "heif" }

            module sequence =
                let media_type =
                    { registry = "image"
                      name = "heif-sequence" }

        module hej2k =
            let media_type = { registry = "image"; name = "hej2k" }

        module ief =
            let media_type = { registry = "image"; name = "ief" }

        module j2c =
            let media_type = { registry = "image"; name = "j2c" }

        module jaii =
            let media_type = { registry = "image"; name = "jaii" }

        module jais =
            let media_type = { registry = "image"; name = "jais" }

        module jls =
            let media_type = { registry = "image"; name = "jls" }

        module jp2 =
            let media_type = { registry = "image"; name = "jp2" }

        module jpeg =
            let media_type = { registry = "image"; name = "jpeg" }

        module jph =
            let media_type = { registry = "image"; name = "jph" }

        module jphc =
            let media_type = { registry = "image"; name = "jphc" }

        module jpm =
            let media_type = { registry = "image"; name = "jpm" }

        module jpx =
            let media_type = { registry = "image"; name = "jpx" }

        module jxl =
            let media_type = { registry = "image"; name = "jxl" }

        module jxr =
            let media_type = { registry = "image"; name = "jxr" }

        module jxrA =
            let media_type = { registry = "image"; name = "jxrA" }

        module jxrS =
            let media_type = { registry = "image"; name = "jxrS" }

        module jxs =
            let media_type = { registry = "image"; name = "jxs" }

        module jxsc =
            let media_type = { registry = "image"; name = "jxsc" }

        module jxsi =
            let media_type = { registry = "image"; name = "jxsi" }

        module jxss =
            let media_type = { registry = "image"; name = "jxss" }

        module ktx =
            let media_type = { registry = "image"; name = "ktx" }

        module ktx2 =
            let media_type = { registry = "image"; name = "ktx2" }

        module naplps =
            let media_type = { registry = "image"; name = "naplps" }

        module png =
            let media_type = { registry = "image"; name = "png" }

        module prs =
            module aimg =
                let media_type =
                    { registry = "image"
                      name = "prs.aimg" }

            module btif =
                let media_type =
                    { registry = "image"
                      name = "prs.btif" }

            module pti =
                let media_type = { registry = "image"; name = "prs.pti" }

        module pwg =
            module raster =
                let media_type =
                    { registry = "image"
                      name = "pwg-raster" }

        module svg =
            module xml =
                let media_type = { registry = "image"; name = "svg+xml" }

        module t38 =
            let media_type = { registry = "image"; name = "t38" }

        module tiff =
            let media_type = { registry = "image"; name = "tiff" }

            module fx =
                let media_type = { registry = "image"; name = "tiff-fx" }

        module vnd =
            module adobe =
                module photoshop =
                    let media_type =
                        { registry = "image"
                          name = "vnd.adobe.photoshop" }

            module airzip =
                module accelerator =
                    module azv =
                        let media_type =
                            { registry = "image"
                              name = "vnd.airzip.accelerator.azv" }

            module blockfact =
                module facti =
                    let media_type =
                        { registry = "image"
                          name = "vnd.blockfact.facti" }

            module clip =
                let media_type =
                    { registry = "image"
                      name = "vnd.clip" }

            module cns =
                module inf2 =
                    let media_type =
                        { registry = "image"
                          name = "vnd.cns.inf2" }

            module dece =
                module graphic =
                    let media_type =
                        { registry = "image"
                          name = "vnd.dece.graphic" }

            module djvu =
                let media_type =
                    { registry = "image"
                      name = "vnd.djvu" }

            module dvb =
                module subtitle =
                    let media_type =
                        { registry = "image"
                          name = "vnd.dvb.subtitle" }

            module dwg =
                let media_type = { registry = "image"; name = "vnd.dwg" }

            module dxf =
                let media_type = { registry = "image"; name = "vnd.dxf" }

            module fastbidsheet =
                let media_type =
                    { registry = "image"
                      name = "vnd.fastbidsheet" }

            module fpx =
                let media_type = { registry = "image"; name = "vnd.fpx" }

            module fst =
                let media_type = { registry = "image"; name = "vnd.fst" }

            module fujixerox =
                module edmics =
                    module mmr =
                        let media_type =
                            { registry = "image"
                              name = "vnd.fujixerox.edmics-mmr" }

                    module rlc =
                        let media_type =
                            { registry = "image"
                              name = "vnd.fujixerox.edmics-rlc" }

            module globalgraphics =
                module pgb =
                    let media_type =
                        { registry = "image"
                          name = "vnd.globalgraphics.pgb" }

            module microsoft =
                module icon =
                    let media_type =
                        { registry = "image"
                          name = "vnd.microsoft.icon" }

            module mix =
                let media_type = { registry = "image"; name = "vnd.mix" }

            module mozilla =
                module apng =
                    let media_type =
                        { registry = "image"
                          name = "vnd.mozilla.apng" }

            module ms =
                module modi =
                    let media_type =
                        { registry = "image"
                          name = "vnd.ms-modi" }

            module net =
                module fpx =
                    let media_type =
                        { registry = "image"
                          name = "vnd.net-fpx" }

            module pco =
                module b16 =
                    let media_type =
                        { registry = "image"
                          name = "vnd.pco.b16" }

            module radiance =
                let media_type =
                    { registry = "image"
                      name = "vnd.radiance" }

            module sealed_ =
                module png =
                    let media_type =
                        { registry = "image"
                          name = "vnd.sealed.png" }

            module sealedmedia =
                module softseal =
                    module gif =
                        let media_type =
                            { registry = "image"
                              name = "vnd.sealedmedia.softseal.gif" }

                    module jpg =
                        let media_type =
                            { registry = "image"
                              name = "vnd.sealedmedia.softseal.jpg" }

            module sld =
                let media_type = { registry = "image"; name = "vnd.sld" }

            module svf =
                let media_type = { registry = "image"; name = "vnd.svf" }

            module tencent =
                module tap =
                    let media_type =
                        { registry = "image"
                          name = "vnd.tencent.tap" }

            module valve =
                module source =
                    module texture =
                        let media_type =
                            { registry = "image"
                              name = "vnd.valve.source.texture" }

            module wap =
                module wbmp =
                    let media_type =
                        { registry = "image"
                          name = "vnd.wap.wbmp" }

            module xiff =
                let media_type =
                    { registry = "image"
                      name = "vnd.xiff" }

            module zbrush =
                module pcx =
                    let media_type =
                        { registry = "image"
                          name = "vnd.zbrush.pcx" }

        module webp =
            let media_type = { registry = "image"; name = "webp" }

        module wmf =
            let media_type = { registry = "image"; name = "wmf" }

    module message =
        module CPIM =
            let media_type = { registry = "message"; name = "CPIM" }

        module bhttp =
            let media_type = { registry = "message"; name = "bhttp" }

        module delivery =
            module status =
                let media_type =
                    { registry = "message"
                      name = "delivery-status" }

        module disposition =
            module notification =
                let media_type =
                    { registry = "message"
                      name = "disposition-notification" }

        module example =
            let media_type =
                { registry = "message"
                  name = "example" }

        module external_ =
            module body =
                let media_type =
                    { registry = "message"
                      name = "external-body" }

        module feedback =
            module report =
                let media_type =
                    { registry = "message"
                      name = "feedback-report" }

        module global_ =
            let media_type =
                { registry = "message"
                  name = "global" }

            module delivery =
                module status =
                    let media_type =
                        { registry = "message"
                          name = "global-delivery-status" }

            module disposition =
                module notification =
                    let media_type =
                        { registry = "message"
                          name = "global-disposition-notification" }

            module headers =
                let media_type =
                    { registry = "message"
                      name = "global-headers" }

        module http =
            let media_type = { registry = "message"; name = "http" }

        module imdn =
            module xml =
                let media_type =
                    { registry = "message"
                      name = "imdn+xml" }

        module mls =
            let media_type = { registry = "message"; name = "mls" }

        module ohttp =
            module chunked =
                module req =
                    let media_type =
                        { registry = "message"
                          name = "ohttp-chunked-req" }

                module res =
                    let media_type =
                        { registry = "message"
                          name = "ohttp-chunked-res" }

            module req =
                let media_type =
                    { registry = "message"
                      name = "ohttp-req" }

            module res =
                let media_type =
                    { registry = "message"
                      name = "ohttp-res" }

        module partial =
            let media_type =
                { registry = "message"
                  name = "partial" }

        module rfc822 =
            let media_type =
                { registry = "message"
                  name = "rfc822" }

        module sip =
            let media_type = { registry = "message"; name = "sip" }

        module sipfrag =
            let media_type =
                { registry = "message"
                  name = "sipfrag" }

        module tracking =
            module status =
                let media_type =
                    { registry = "message"
                      name = "tracking-status" }

        module vnd =
            module wfa =
                module wsc =
                    let media_type =
                        { registry = "message"
                          name = "vnd.wfa.wsc" }

    module model =
        module _3mf =
            let media_type = { registry = "model"; name = "3mf" }

        module JT =
            let media_type = { registry = "model"; name = "JT" }

        module e57 =
            let media_type = { registry = "model"; name = "e57" }

        module example =
            let media_type = { registry = "model"; name = "example" }

        module gltf =
            module binary =
                let media_type =
                    { registry = "model"
                      name = "gltf-binary" }

            module json =
                let media_type =
                    { registry = "model"
                      name = "gltf+json" }

        module iges =
            let media_type = { registry = "model"; name = "iges" }

        module mesh =
            let media_type = { registry = "model"; name = "mesh" }

        module mtl =
            let media_type = { registry = "model"; name = "mtl" }

        module obj =
            let media_type = { registry = "model"; name = "obj" }

        module prc =
            let media_type = { registry = "model"; name = "prc" }

        module step =
            let media_type = { registry = "model"; name = "step" }

            module xml =
                let media_type =
                    { registry = "model"
                      name = "step+xml" }

                module zip =
                    let media_type =
                        { registry = "model"
                          name = "step-xml+zip" }

            module zip =
                let media_type =
                    { registry = "model"
                      name = "step+zip" }

        module stl =
            let media_type = { registry = "model"; name = "stl" }

        module u3d =
            let media_type = { registry = "model"; name = "u3d" }

        module vnd =
            module bary =
                let media_type =
                    { registry = "model"
                      name = "vnd.bary" }

            module cld =
                let media_type = { registry = "model"; name = "vnd.cld" }

            module collada =
                module xml =
                    let media_type =
                        { registry = "model"
                          name = "vnd.collada+xml" }

            module dwf =
                let media_type = { registry = "model"; name = "vnd.dwf" }

            module flatland =
                module _3dml =
                    let media_type =
                        { registry = "model"
                          name = "vnd.flatland.3dml" }

            module gdl =
                let media_type = { registry = "model"; name = "vnd.gdl" }

            module gs =
                module gdl =
                    let media_type =
                        { registry = "model"
                          name = "vnd.gs-gdl" }

            module gtw =
                let media_type = { registry = "model"; name = "vnd.gtw" }

            module moml =
                module xml =
                    let media_type =
                        { registry = "model"
                          name = "vnd.moml+xml" }

            module mts =
                let media_type = { registry = "model"; name = "vnd.mts" }

            module opengex =
                let media_type =
                    { registry = "model"
                      name = "vnd.opengex" }

            module parasolid =
                module transmit =
                    module binary =
                        let media_type =
                            { registry = "model"
                              name = "vnd.parasolid.transmit.binary" }

                    module text =
                        let media_type =
                            { registry = "model"
                              name = "vnd.parasolid.transmit.text" }

            module pytha =
                module pyox =
                    let media_type =
                        { registry = "model"
                          name = "vnd.pytha.pyox" }

            module rosette =
                module annotated =
                    module data =
                        module model =
                            let media_type =
                                { registry = "model"
                                  name = "vnd.rosette.annotated-data-model" }

            module sap =
                module vds =
                    let media_type =
                        { registry = "model"
                          name = "vnd.sap.vds" }

            module usda =
                let media_type =
                    { registry = "model"
                      name = "vnd.usda" }

            module usdz =
                module zip =
                    let media_type =
                        { registry = "model"
                          name = "vnd.usdz+zip" }

            module valve =
                module source =
                    module compiled =
                        module map =
                            let media_type =
                                { registry = "model"
                                  name = "vnd.valve.source.compiled-map" }

            module vtu =
                let media_type = { registry = "model"; name = "vnd.vtu" }

        module vrml =
            let media_type = { registry = "model"; name = "vrml" }

        module x3d =
            module fastinfoset =
                let media_type =
                    { registry = "model"
                      name = "x3d+fastinfoset" }

            module vrml =
                let media_type =
                    { registry = "model"
                      name = "x3d-vrml" }

            module xml =
                let media_type = { registry = "model"; name = "x3d+xml" }

    module multipart =
        module alternative =
            let media_type =
                { registry = "multipart"
                  name = "alternative" }

        module appledouble =
            let media_type =
                { registry = "multipart"
                  name = "appledouble" }

        module byteranges =
            let media_type =
                { registry = "multipart"
                  name = "byteranges" }

        module digest =
            let media_type =
                { registry = "multipart"
                  name = "digest" }

        module encrypted =
            let media_type =
                { registry = "multipart"
                  name = "encrypted" }

        module example =
            let media_type =
                { registry = "multipart"
                  name = "example" }

        module form =
            module data =
                let media_type =
                    { registry = "multipart"
                      name = "form-data" }

        module header =
            module set =
                let media_type =
                    { registry = "multipart"
                      name = "header-set" }

        module mixed =
            let media_type =
                { registry = "multipart"
                  name = "mixed" }

        module multilingual =
            let media_type =
                { registry = "multipart"
                  name = "multilingual" }

        module parallel_ =
            let media_type =
                { registry = "multipart"
                  name = "parallel" }

        module related =
            let media_type =
                { registry = "multipart"
                  name = "related" }

        module report =
            let media_type =
                { registry = "multipart"
                  name = "report" }

        module signed =
            let media_type =
                { registry = "multipart"
                  name = "signed" }

        module vnd =
            module bint =
                module med =
                    module plus =
                        let media_type =
                            { registry = "multipart"
                              name = "vnd.bint.med-plus" }

        module voice =
            module message =
                let media_type =
                    { registry = "multipart"
                      name = "voice-message" }

        module x =
            module mixed =
                module replace =
                    let media_type =
                        { registry = "multipart"
                          name = "x-mixed-replace" }

    module text =
        module _1d =
            module interleaved =
                module parityfec =
                    let media_type =
                        { registry = "text"
                          name = "1d-interleaved-parityfec" }

        module RED =
            let media_type = { registry = "text"; name = "RED" }

        module SGML =
            let media_type = { registry = "text"; name = "SGML" }

        module cache =
            module manifest =
                let media_type =
                    { registry = "text"
                      name = "cache-manifest" }

        module calendar =
            let media_type = { registry = "text"; name = "calendar" }

        module cql =
            let media_type = { registry = "text"; name = "cql" }

            module expression =
                let media_type =
                    { registry = "text"
                      name = "cql-expression" }

            module identifier =
                let media_type =
                    { registry = "text"
                      name = "cql-identifier" }

        module css =
            let media_type = { registry = "text"; name = "css" }

        module csv =
            let media_type = { registry = "text"; name = "csv" }

            module schema =
                let media_type =
                    { registry = "text"
                      name = "csv-schema" }

        module dns =
            let media_type = { registry = "text"; name = "dns" }

        module encaprtp =
            let media_type = { registry = "text"; name = "encaprtp" }

        module enriched =
            let media_type = { registry = "text"; name = "enriched" }

        module example =
            let media_type = { registry = "text"; name = "example" }

        module fhirpath =
            let media_type = { registry = "text"; name = "fhirpath" }

        module flexfec =
            let media_type = { registry = "text"; name = "flexfec" }

        module fwdred =
            let media_type = { registry = "text"; name = "fwdred" }

        module gff3 =
            let media_type = { registry = "text"; name = "gff3" }

        module grammar =
            module ref =
                module list =
                    let media_type =
                        { registry = "text"
                          name = "grammar-ref-list" }

        module hl7v2 =
            let media_type = { registry = "text"; name = "hl7v2" }

        module html =
            let media_type = { registry = "text"; name = "html" }

        module javascript =
            let media_type =
                { registry = "text"
                  name = "javascript" }

        module jcr =
            module cnd =
                let media_type = { registry = "text"; name = "jcr-cnd" }

        module markdown =
            let media_type = { registry = "text"; name = "markdown" }

        module mizar =
            let media_type = { registry = "text"; name = "mizar" }

        module n3 =
            let media_type = { registry = "text"; name = "n3" }

        module org =
            let media_type = { registry = "text"; name = "org" }

        module parameters =
            let media_type =
                { registry = "text"
                  name = "parameters" }

        module parityfec =
            let media_type =
                { registry = "text"
                  name = "parityfec" }

        module plain =
            let media_type = { registry = "text"; name = "plain" }

        module provenance =
            module notation =
                let media_type =
                    { registry = "text"
                      name = "provenance-notation" }

        module prs =
            module fallenstein =
                module rst =
                    let media_type =
                        { registry = "text"
                          name = "prs.fallenstein.rst" }

            module lines =
                module tag =
                    let media_type =
                        { registry = "text"
                          name = "prs.lines.tag" }

            module prop =
                module logic =
                    let media_type =
                        { registry = "text"
                          name = "prs.prop.logic" }

            module texi =
                let media_type = { registry = "text"; name = "prs.texi" }

        module raptorfec =
            let media_type =
                { registry = "text"
                  name = "raptorfec" }

        module rfc822 =
            module headers =
                let media_type =
                    { registry = "text"
                      name = "rfc822-headers" }

        module richtext =
            let media_type = { registry = "text"; name = "richtext" }

        module rtf =
            let media_type = { registry = "text"; name = "rtf" }

        module rtp =
            module enc =
                module aescm128 =
                    let media_type =
                        { registry = "text"
                          name = "rtp-enc-aescm128" }

        module rtploopback =
            let media_type =
                { registry = "text"
                  name = "rtploopback" }

        module rtx =
            let media_type = { registry = "text"; name = "rtx" }

        module shaclc =
            let media_type = { registry = "text"; name = "shaclc" }

        module shex =
            let media_type = { registry = "text"; name = "shex" }

        module spdx =
            let media_type = { registry = "text"; name = "spdx" }

        module strings =
            let media_type = { registry = "text"; name = "strings" }

        module t140 =
            let media_type = { registry = "text"; name = "t140" }

        module tab =
            module separated =
                module values =
                    let media_type =
                        { registry = "text"
                          name = "tab-separated-values" }

        module troff =
            let media_type = { registry = "text"; name = "troff" }

        module turtle =
            let media_type = { registry = "text"; name = "turtle" }

        module ulpfec =
            let media_type = { registry = "text"; name = "ulpfec" }

        module uri =
            module list =
                let media_type = { registry = "text"; name = "uri-list" }

        module vcard =
            let media_type = { registry = "text"; name = "vcard" }

        module vnd =
            module DMClientScript =
                let media_type =
                    { registry = "text"
                      name = "vnd.DMClientScript" }

            module IPTC =
                module NITF =
                    let media_type =
                        { registry = "text"
                          name = "vnd.IPTC.NITF" }

                module NewsML =
                    let media_type =
                        { registry = "text"
                          name = "vnd.IPTC.NewsML" }

            module a =
                let media_type = { registry = "text"; name = "vnd.a" }

            module abc =
                let media_type = { registry = "text"; name = "vnd.abc" }

            module ascii =
                module art =
                    let media_type =
                        { registry = "text"
                          name = "vnd.ascii-art" }

            module bovnar =
                let media_type =
                    { registry = "text"
                      name = "vnd.bovnar" }

            module curl =
                let media_type = { registry = "text"; name = "vnd.curl" }

            module debian =
                module copyright =
                    let media_type =
                        { registry = "text"
                          name = "vnd.debian.copyright" }

            module dvb =
                module subtitle =
                    let media_type =
                        { registry = "text"
                          name = "vnd.dvb.subtitle" }

            module esmertec =
                module theme =
                    module descriptor =
                        let media_type =
                            { registry = "text"
                              name = "vnd.esmertec.theme-descriptor" }

            module exchangeable =
                let media_type =
                    { registry = "text"
                      name = "vnd.exchangeable" }

            module familysearch =
                module gedcom =
                    let media_type =
                        { registry = "text"
                          name = "vnd.familysearch.gedcom" }

            module ficlab =
                module flt =
                    let media_type =
                        { registry = "text"
                          name = "vnd.ficlab.flt" }

            module fly =
                let media_type = { registry = "text"; name = "vnd.fly" }

            module fmi =
                module flexstor =
                    let media_type =
                        { registry = "text"
                          name = "vnd.fmi.flexstor" }

            module gist =
                module mx =
                    let media_type =
                        { registry = "text"
                          name = "vnd.gist.mx" }

            module gml =
                let media_type = { registry = "text"; name = "vnd.gml" }

            module graphviz =
                let media_type =
                    { registry = "text"
                      name = "vnd.graphviz" }

            module hans =
                let media_type = { registry = "text"; name = "vnd.hans" }

            module hekaya =
                let media_type =
                    { registry = "text"
                      name = "vnd.hekaya" }

            module hgl =
                let media_type = { registry = "text"; name = "vnd.hgl" }

            module in3d =
                module _3dml =
                    let media_type =
                        { registry = "text"
                          name = "vnd.in3d.3dml" }

                module spot =
                    let media_type =
                        { registry = "text"
                          name = "vnd.in3d.spot" }

            module latex =
                module z =
                    let media_type =
                        { registry = "text"
                          name = "vnd.latex-z" }

            module longform =
                let media_type =
                    { registry = "text"
                      name = "vnd.longform" }

            module motorola =
                module reflex =
                    let media_type =
                        { registry = "text"
                          name = "vnd.motorola.reflex" }

            module ms =
                module mediapackage =
                    let media_type =
                        { registry = "text"
                          name = "vnd.ms-mediapackage" }

            module net2phone =
                module commcenter =
                    module command =
                        let media_type =
                            { registry = "text"
                              name = "vnd.net2phone.commcenter.command" }

            module radisys =
                module msml =
                    module basic =
                        module layout =
                            let media_type =
                                { registry = "text"
                                  name = "vnd.radisys.msml-basic-layout" }

            module senx =
                module warpscript =
                    let media_type =
                        { registry = "text"
                          name = "vnd.senx.warpscript" }

            module sosi =
                let media_type = { registry = "text"; name = "vnd.sosi" }

            module sun =
                module j2me =
                    module app =
                        module descriptor =
                            let media_type =
                                { registry = "text"
                                  name = "vnd.sun.j2me.app-descriptor" }

            module tps =
                let media_type = { registry = "text"; name = "vnd.tps" }

            module trolltech =
                module linguist =
                    let media_type =
                        { registry = "text"
                          name = "vnd.trolltech.linguist" }

            module typst =
                let media_type =
                    { registry = "text"
                      name = "vnd.typst" }

            module vcf =
                let media_type = { registry = "text"; name = "vnd.vcf" }

            module vri =
                let media_type = { registry = "text"; name = "vnd.vri" }

            module wap =
                module si =
                    let media_type =
                        { registry = "text"
                          name = "vnd.wap.si" }

                module sl =
                    let media_type =
                        { registry = "text"
                          name = "vnd.wap.sl" }

                module wml =
                    let media_type =
                        { registry = "text"
                          name = "vnd.wap.wml" }

                module wmlscript =
                    let media_type =
                        { registry = "text"
                          name = "vnd.wap.wmlscript" }

            module zoo =
                module kcl =
                    let media_type =
                        { registry = "text"
                          name = "vnd.zoo.kcl" }

        module vtt =
            let media_type = { registry = "text"; name = "vtt" }

        module wgsl =
            let media_type = { registry = "text"; name = "wgsl" }

        module xml =
            let media_type = { registry = "text"; name = "xml" }

            module external_ =
                module parsed =
                    module entity =
                        let media_type =
                            { registry = "text"
                              name = "xml-external-parsed-entity" }

    module video =
        module _1d =
            module interleaved =
                module parityfec =
                    let media_type =
                        { registry = "video"
                          name = "1d-interleaved-parityfec" }

        module _3gpp =
            let media_type = { registry = "video"; name = "3gpp" }

            module tt =
                let media_type = { registry = "video"; name = "3gpp-tt" }

        module _3gpp2 =
            let media_type = { registry = "video"; name = "3gpp2" }

        module AV1 =
            let media_type = { registry = "video"; name = "AV1" }

        module BMPEG =
            let media_type = { registry = "video"; name = "BMPEG" }

        module BT656 =
            let media_type = { registry = "video"; name = "BT656" }

        module CelB =
            let media_type = { registry = "video"; name = "CelB" }

        module DV =
            let media_type = { registry = "video"; name = "DV" }

        module FFV1 =
            let media_type = { registry = "video"; name = "FFV1" }

        module H261 =
            let media_type = { registry = "video"; name = "H261" }

        module H263 =
            let media_type = { registry = "video"; name = "H263" }

            module _1998 =
                let media_type =
                    { registry = "video"
                      name = "H263-1998" }

            module _2000 =
                let media_type =
                    { registry = "video"
                      name = "H263-2000" }

        module H264 =
            let media_type = { registry = "video"; name = "H264" }

            module RCDO =
                let media_type =
                    { registry = "video"
                      name = "H264-RCDO" }

            module SVC =
                let media_type =
                    { registry = "video"
                      name = "H264-SVC" }

        module H265 =
            let media_type = { registry = "video"; name = "H265" }

        module H266 =
            let media_type = { registry = "video"; name = "H266" }

        module JPEG =
            let media_type = { registry = "video"; name = "JPEG" }

        module MP1S =
            let media_type = { registry = "video"; name = "MP1S" }

        module MP2P =
            let media_type = { registry = "video"; name = "MP2P" }

        module MP2T =
            let media_type = { registry = "video"; name = "MP2T" }

        module MP4V =
            module ES =
                let media_type = { registry = "video"; name = "MP4V-ES" }

        module MPV =
            let media_type = { registry = "video"; name = "MPV" }

        module SMPTE292M =
            let media_type =
                { registry = "video"
                  name = "SMPTE292M" }

        module VP8 =
            let media_type = { registry = "video"; name = "VP8" }

        module VP9 =
            let media_type = { registry = "video"; name = "VP9" }

        module encaprtp =
            let media_type =
                { registry = "video"
                  name = "encaprtp" }

        module evc =
            let media_type = { registry = "video"; name = "evc" }

        module example =
            let media_type = { registry = "video"; name = "example" }

        module flexfec =
            let media_type = { registry = "video"; name = "flexfec" }

        module iso =
            module segment =
                let media_type =
                    { registry = "video"
                      name = "iso.segment" }

        module jpeg2000 =
            let media_type =
                { registry = "video"
                  name = "jpeg2000" }

            module scl =
                let media_type =
                    { registry = "video"
                      name = "jpeg2000-scl" }

        module jxsv =
            let media_type = { registry = "video"; name = "jxsv" }

        module lottie =
            module json =
                let media_type =
                    { registry = "video"
                      name = "lottie+json" }

        module matroska =
            let media_type =
                { registry = "video"
                  name = "matroska" }

            module _3d =
                let media_type =
                    { registry = "video"
                      name = "matroska-3d" }

        module mj2 =
            let media_type = { registry = "video"; name = "mj2" }

        module mp4 =
            let media_type = { registry = "video"; name = "mp4" }

        module mpeg =
            let media_type = { registry = "video"; name = "mpeg" }

        module mpeg4 =
            module generic =
                let media_type =
                    { registry = "video"
                      name = "mpeg4-generic" }

        module nv =
            let media_type = { registry = "video"; name = "nv" }

        module ogg =
            let media_type = { registry = "video"; name = "ogg" }

        module parityfec =
            let media_type =
                { registry = "video"
                  name = "parityfec" }

        module pointer =
            let media_type = { registry = "video"; name = "pointer" }

        module prs =
            module avid =
                let media_type =
                    { registry = "video"
                      name = "prs.avid" }

        module quicktime =
            let media_type =
                { registry = "video"
                  name = "quicktime" }

        module raptorfec =
            let media_type =
                { registry = "video"
                  name = "raptorfec" }

        module raw =
            let media_type = { registry = "video"; name = "raw" }

        module rtp =
            module enc =
                module aescm128 =
                    let media_type =
                        { registry = "video"
                          name = "rtp-enc-aescm128" }

        module rtploopback =
            let media_type =
                { registry = "video"
                  name = "rtploopback" }

        module rtx =
            let media_type = { registry = "video"; name = "rtx" }

        module scip =
            let media_type = { registry = "video"; name = "scip" }

        module smpte291 =
            let media_type =
                { registry = "video"
                  name = "smpte291" }

        module ulpfec =
            let media_type = { registry = "video"; name = "ulpfec" }

        module vc1 =
            let media_type = { registry = "video"; name = "vc1" }

        module vc2 =
            let media_type = { registry = "video"; name = "vc2" }

        module vnd =
            module CCTV =
                let media_type =
                    { registry = "video"
                      name = "vnd.CCTV" }

            module blockfact =
                module factv =
                    let media_type =
                        { registry = "video"
                          name = "vnd.blockfact.factv" }

            module dece =
                module hd =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dece.hd" }

                module mobile =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dece.mobile" }

                module mp4 =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dece.mp4" }

                module pd =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dece.pd" }

                module sd =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dece.sd" }

                module video =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dece.video" }

            module directv =
                module mpeg =
                    let media_type =
                        { registry = "video"
                          name = "vnd.directv.mpeg" }

                    module tts =
                        let media_type =
                            { registry = "video"
                              name = "vnd.directv.mpeg-tts" }

            module dlna =
                module mpeg =
                    module tts =
                        let media_type =
                            { registry = "video"
                              name = "vnd.dlna.mpeg-tts" }

            module dvb =
                module file =
                    let media_type =
                        { registry = "video"
                          name = "vnd.dvb.file" }

            module fvt =
                let media_type = { registry = "video"; name = "vnd.fvt" }

            module hns =
                module video =
                    let media_type =
                        { registry = "video"
                          name = "vnd.hns.video" }

            module iptvforum =
                module _1dparityfec =
                    module _1010 =
                        let media_type =
                            { registry = "video"
                              name = "vnd.iptvforum.1dparityfec-1010" }

                    module _2005 =
                        let media_type =
                            { registry = "video"
                              name = "vnd.iptvforum.1dparityfec-2005" }

                module _2dparityfec =
                    module _1010 =
                        let media_type =
                            { registry = "video"
                              name = "vnd.iptvforum.2dparityfec-1010" }

                    module _2005 =
                        let media_type =
                            { registry = "video"
                              name = "vnd.iptvforum.2dparityfec-2005" }

                module ttsavc =
                    let media_type =
                        { registry = "video"
                          name = "vnd.iptvforum.ttsavc" }

                module ttsmpeg2 =
                    let media_type =
                        { registry = "video"
                          name = "vnd.iptvforum.ttsmpeg2" }

            module motorola =
                module video =
                    let media_type =
                        { registry = "video"
                          name = "vnd.motorola.video" }

                module videop =
                    let media_type =
                        { registry = "video"
                          name = "vnd.motorola.videop" }

            module mpegurl =
                let media_type =
                    { registry = "video"
                      name = "vnd.mpegurl" }

            module ms =
                module playready =
                    module media =
                        module pyv =
                            let media_type =
                                { registry = "video"
                                  name = "vnd.ms-playready.media.pyv" }

            module nokia =
                module interleaved =
                    module multimedia =
                        let media_type =
                            { registry = "video"
                              name = "vnd.nokia.interleaved-multimedia" }

                module mp4vr =
                    let media_type =
                        { registry = "video"
                          name = "vnd.nokia.mp4vr" }

                module videovoip =
                    let media_type =
                        { registry = "video"
                          name = "vnd.nokia.videovoip" }

            module objectvideo =
                let media_type =
                    { registry = "video"
                      name = "vnd.objectvideo" }

            module planar =
                let media_type =
                    { registry = "video"
                      name = "vnd.planar" }

            module radgamettools =
                module bink =
                    let media_type =
                        { registry = "video"
                          name = "vnd.radgamettools.bink" }

                module smacker =
                    let media_type =
                        { registry = "video"
                          name = "vnd.radgamettools.smacker" }

            module sealed_ =
                module mpeg1 =
                    let media_type =
                        { registry = "video"
                          name = "vnd.sealed.mpeg1" }

                module mpeg4 =
                    let media_type =
                        { registry = "video"
                          name = "vnd.sealed.mpeg4" }

                module swf =
                    let media_type =
                        { registry = "video"
                          name = "vnd.sealed.swf" }

            module sealedmedia =
                module softseal =
                    module mov =
                        let media_type =
                            { registry = "video"
                              name = "vnd.sealedmedia.softseal.mov" }

            module uvvu =
                module mp4 =
                    let media_type =
                        { registry = "video"
                          name = "vnd.uvvu.mp4" }

            module vivo =
                let media_type =
                    { registry = "video"
                      name = "vnd.vivo" }

            module youtube =
                module yt =
                    let media_type =
                        { registry = "video"
                          name = "vnd.youtube.yt" }
