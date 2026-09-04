#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "UrlErgonomics.dll"

open UrlErgonomics
open Dubzer.WhatwgUrl


module Accela =

    [<RequireQualifiedAccess>]
    type Environment =
        | prod
        | test
        | supp
        member this.asString = this.ToString()
        member this.url = DomUrl $"https://leonco-{this.asString}-av.accela.com/"

        member this.contacts =
            this.url.AppendPath
                "portlets/commons/contact/refContact.jsp?mode=search&spaceName=spaces.leonco.contacts&spaceName=spaces.leonco.contacts&spaceName=spaces.leonco.contacts"

        member this.licenseprofessionals =
            this.url.AppendPath
                "portlets/commons/professional/refProfessional.jsp?spaceName=spaces.leonco.licenseprofessionals&spaceName=spaces.leonco.licenseprofessionals&spaceName=spaces.leonco.licenseprofessionals&spaceName=spaces.leonco.licenseprofessionals"

        member this.record =
            this.url.AppendPath
                "portlets/commons/cap/myCAPDetailPortlet.jsp?module=-select-&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record&spaceName=spaces.leonco.record"

        member this.recordSearch =
            this.url.AppendPath
                "portlets/cap/capSearch.do?mode=search&isFromSearch=true&isSearchButton=true&spaceName=spaces.leonco.record&module=PublicWorks&isGeneralCAP=Y"

        member this.permit(permitNumber: string) =
            this.url.AppendPath
                $"portlets/cap/capsummary/CapTabSummary.do?mode=tabSummary&serviceProviderCode=LEONCO&ID1=EMP26&ID2=00000&ID3=00029&requireNotice=YES&clearForm=clearForm&module=EnvManagement&isFromCapList=true&isGeneralCAP=Y&spaceName=spaces.leonco.{permitNumber.ToLowerInvariant()}&spaceName=spaces.leonco.{permitNumber.ToLowerInvariant()}"

    module DigEplan =
        // https://support.digeplan.com/hc/en-us/articles/51431808148884-Bug-Fixes
        let url = DomUrl "https://leonco.usw.digeplan.app/"

        module DataSheet =
            let May25 =
                DomUrl "https://avolvesoftware.com/wp-content/uploads/2025/07/DigEplan-Data-Sheet-May-25.pdf"

            let AccelaND =
                DomUrl "https://digeplan.com/wp-content/uploads/2020/12/DEP-Data-Sheet-Accela-ND.pdf"


// Accela.DigEplan.DataSheet.AccelaND.DownloadFileText()
let leonco = Accela.Environment.prod


// leonco.permit "LEM26006" |> mainTab.navigate
