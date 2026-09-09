(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)

// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
# time on
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true

#r "PlaidErgonomics.dll"
open PlaidErgonomics


#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "HtmlErgonomics.dll"
open HtmlErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "SparqlErgonomics.dll"
open SparqlErgonomics

#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl

#r "UrlErgonomics.dll"

open UrlErgonomics

open FSharp.Data
open FSharp.Configuration
open Dubzer.WhatwgUrl
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FsHttp
open System.IO.Compression
open System.IO
open VDS.RDF.Query.Datasets
open VDS.RDF
open VDS.RDF.Parsing
open System
open System.Linq
open FolkerKinzel.MimeTypes
open IriTools
open System.Threading
open Humanizer

open BrowserApi.Css.Authoring

#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\Namespace\Generated"

#r "rdfNamespace.dll"
open RdfNamespace
#r "rdfsNamespace.dll"
open RdfsNamespace
#r "voafNamespace.dll"
open VoafNamespace
#r "vannNamespace.dll"
open VannNamespace
#r "foafNamespace.dll"
open FoafNamespace
#r "vsNamespace.dll"
open VsNamespace
#r "hydraNamespace.dll"
open HydraNamespace
#r "voidNamespace.dll"
open VoidNamespace
#r "vaemNamespace.dll"
open VaemNamespace
#r "dctermsNamespace.dll"
open DctermsNamespace
#r "dcatNamespace.dll"
open DcatNamespace
#r "vfNamespace.dll"
open VfNamespace


#r "gleif-raNamespace.dll"
open ``Gleif-raNamespace``
module raGleif = ``gleif-ra``
#r "gleif-elfNamespace.dll"
open ``Gleif-elfNamespace``
module elfGleif = ``gleif-elf``
#r "gleif-repexNamespace.dll"
open ``Gleif-repexNamespace``
module repexGleif = ``gleif-repex``
#r "gleif-geoNamespace.dll"
open ``Gleif-geoNamespace``
module geoGleif = ``gleif-geo``
#r "gleif-L2Namespace.dll"
open ``Gleif-L2Namespace``
module L2Gleif = ``gleif-L2``
#r "gleif-L1Namespace.dll"
open ``Gleif-L1Namespace``
module L1Gleif = ``gleif-L1``
#r "gleif-baseNamespace.dll"
open ``Gleif-baseNamespace``
module gleif = ``gleif-base``
      
#r "cmns-txtNamespace.dll"
open ``Cmns-txtNamespace``
module txtCmns = ``cmns-txt``
#r "cmns-cdsNamespace.dll"
open ``Cmns-cdsNamespace``
module cdsCmns = ``cmns-cds``
#r "cmns-cxtidNamespace.dll"
open ``Cmns-cxtidNamespace``
module cxtidCmns = ``cmns-cxtid``
#r "cmns-idNamespace.dll"
open ``Cmns-idNamespace``
module idCmns = ``cmns-id``
#r "cmns-clsNamespace.dll"
open ``Cmns-clsNamespace``
module clsCmns = ``cmns-cls``
#r "cmns-sfcNamespace.dll"
open ``Cmns-sfcNamespace``
module sfcCmns = ``cmns-sfc``
#r "cmns-cxtdsgNamespace.dll"
open ``Cmns-cxtdsgNamespace``
module cxtdsgCmns = ``cmns-cxtdsg``
#r "cmns-avNamespace.dll"
open ``Cmns-avNamespace``
module avCmns = ``cmns-av``
#r "cmns-rgaNamespace.dll"
open ``Cmns-rgaNamespace``
module rgaCmns = ``cmns-rga``
#r "cmns-raNamespace.dll"
open ``Cmns-raNamespace``
module raCmns = ``cmns-ra``
#r "cmns-rlcmpNamespace.dll"
open ``Cmns-rlcmpNamespace``
module rlcmpCmns = ``cmns-rlcmp``
#r "cmns-bauthNamespace.dll"
open ``Cmns-bauthNamespace``
module bauthCmns = ``cmns-bauth``
#r "cmns-colNamespace.dll"
open ``Cmns-colNamespace``
module colCmns = ``cmns-col``
#r "cmns-dsgNamespace.dll"
open ``Cmns-dsgNamespace``
module dsgCmns = ``cmns-dsg``
#r "cmns-docNamespace.dll"
open ``Cmns-docNamespace``
module docCmns = ``cmns-doc``
#r "cmns-ptsNamespace.dll"
open ``Cmns-ptsNamespace``
module ptsCmns = ``cmns-pts``
#r "cmns-dtNamespace.dll"
open ``Cmns-dtNamespace``
module dtCmns = ``cmns-dt``
#r "cmns-locNamespace.dll"
open ``Cmns-locNamespace``
module locCmns = ``cmns-loc``
#r "cmns-orgNamespace.dll"
open ``Cmns-orgNamespace``
module orgCmns = ``cmns-org``
#r "cmns-qtuNamespace.dll"
open ``Cmns-qtuNamespace``
module qtuCmns = ``cmns-qtu``


#r "fibo-fbc-fct-fseNamespace.dll"
open ``Fibo-fbc-fct-fseNamespace``
module fseFibo = ``fibo-fbc-fct-fse``
#r "fibo-fbc-pas-caaNamespace.dll"
open ``Fibo-fbc-pas-caaNamespace``
module caaFibo = ``fibo-fbc-pas-caa``
#r "fibo-loan-spc-crdNamespace.dll"
open ``Fibo-loan-spc-crdNamespace``
module crdFibo = ``fibo-loan-spc-crd``
#r "fibo-loan-ln-lnNamespace.dll"
open ``Fibo-loan-ln-lnNamespace``
module lnFibo = ``fibo-loan-ln-ln``
#r "fibo-fnd-rel-relNamespace.dll"
open ``Fibo-fnd-rel-relNamespace``
module relFibo = ``fibo-fnd-rel-rel``

#r "fibo-fnd-acc-curNamespace.dll"
open ``Fibo-fnd-acc-curNamespace``
module curFibo = ``fibo-fnd-acc-cur``

#r "fibo-fnd-acc-4217Namespace.dll"
open ``Fibo-fnd-acc-4217Namespace``
module iso4217 = ``fibo-fnd-acc-4217``



let a = rdf.type_

let iriref (iriString:string) = IriReference iriString |> IRIREF



module com = 
    module governmentjobs = 
        let ApplicationsSystemsAnalystI = iriref "https://www.governmentjobs.com/careers/leoncountyfl/classspecs/1183950"
    module myfuelmaster = 
        let https = iriref "https://myfuelmaster.com/"
        let desktop_support_technician = iriref "https://myfuelmaster.com/job/desktop-support-technician-8"
    module wellsfargo = 
        let everydayChecking = iriref "https://www.wellsfargo.com/checking/everyday"
    module usaaBanking = 
        let checking = iriref "https://www.usaa.com/banking/checking"
        let savings = iriref "https://www.usaa.com/banking/savings"
    module trycrew = 
        let checkingAccountDisclosure = iriref "https://www.trycrew.com/pdfjs/web/viewer?file=%2Fdocs%2Fdeposit-agreement.pdf#h.g82ej3s9bgif"
module gov = 
    module leoncountyfl = 
        module cms =
            let OfficeofInformationTechnology = iriref "https://cms.leoncountyfl.gov/Government/Departments/Information-and-Technology/Office-of-Information-Technology"

module leinfo = 
    let _prefixId = PrefixId.fromNamespaceLabel "http://lei.info/"  "lei" 
    let _l1 = PrefixId.fromNamespaceLabel "http://lei.info/voc/l1/"  "leiL1" 
    let _prefix (lei:string) = PrefixedIri { prefixId = _prefixId ; localName = lei } 

type LegalEntityIdentifier = 
    {
        localName: string
        lei : string
    }
    static member fromLocalNameLei (localName:string) (lei:string) = { localName = localName ; lei =  lei }
    
    member this.asIri = leinfo._prefix this.lei
    member this.prefixId = PrefixId.fromNamespaceLabel $"{this.asIri.lexicalForm}#"  this.localName
    member this.ttlUrl = DomUrl $"{this.asIri.lexicalForm}.ttl"
    member this.asSubject = this.asIri.asSubject
    member this.asPredicate = this.asIri.asPredicate
    member this.asObject = this.asIri.asObject
    member this.graphDocument = 
        let ttlUrl = this.ttlUrl
        if not ttlUrl.asFile.Exists then 
            let chrome = CdpBrowser.Connect()
            chrome |> CdpBrowser.DownloadText this.ttlUrl
        { graphFile = ttlUrl.asFile }

module lei = 
    let WellsFargoNationalBank = LegalEntityIdentifier.fromLocalNameLei "WellsFargoNationalBank" "KB1H1DSPRFMYMCUFXT09"
    let USAAFederalSavingsBank = LegalEntityIdentifier.fromLocalNameLei "USAAFederalSavingsBank" "C5654JQHZUHN0772B561"  
    let BangorSavingsBank = LegalEntityIdentifier.fromLocalNameLei "BangorSavingsBank" "549300JEBULFT3BSU682"

// lei.WellsFargoNationalBank.prefixId
// lei.USAAFederalSavingsBank.prefixId
lei.BangorSavingsBank.prefixId

type Birthday = 
    | Birthday of DateOnly

    member this.asDateOnly = 
        match this with 
        | Birthday date -> date

    member this.ageAtDate(date: DateOnly) =
        let birthDate = this.asDateOnly
        let age = date.Year - birthDate.Year

        if (date.Month, date.Day) < (birthDate.Month, birthDate.Day) then
            age - 1
        else
            age

    member this.currentAge =
        DateOnly.FromDateTime(DateTime.Now)
        |> this.ageAtDate
module Me = 
    let myBirthday = new DateOnly(1991,7,5) |> Birthday

let syrisBirthday = new DateOnly(1993,5,28) |> Birthday


module dbug = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/"  "dbug"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"



module wellsfargo = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/wellsfargo/"  "wellsfargo"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let everydayChecking = _prefix "everydayChecking" 
    let platinumCard = _prefix "platinumCard"
    let installmentLoans = _prefix "installmentLoans"
    let wellsFargoRewards = _prefix "wellsFargoRewards"
    

module usaa = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/usaa/"  "usaa"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let checking = _prefix "checking"
    let platinumVisa = _prefix "platinumVisa"
    let usaaSavings = _prefix "usaaSavings"
module commonplace = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/commonplace/"  "commonplace"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let eristocrates = _prefix "eristocrates"
    let syrislove = _prefix "syrislove"
    let WellsFargoEverydayChecking = _prefix "WellsFargoEverydayChecking"
    let WellsFargoEverydayCheckingAccount = _prefix "WellsFargoEverydayCheckingAccount"
    let WellsFargoEverydayCheckingAccountCurrentBalance = _prefix "WellsFargoEverydayCheckingAccountCurrentBalance"
    let WellsFargoEverydayCheckingAccountAvailableBalance = _prefix "WellsFargoEverydayCheckingAccountAvailableBalance"
    let USAAClassicChecking = _prefix "USAAClassicChecking"
    let USAAClassicCheckingAccount = _prefix "USAAClassicCheckingAccount"
    let USAAClassicCheckingAccountCurrentBalance = _prefix "USAAClassicCheckingAccountCurrentBalance"
    let USAAClassicCheckingAccountAvailableBalance = _prefix "USAAClassicCheckingAccountAvailableBalance"
    let USAAClassicSavings = _prefix "USAAClassicSavings"
    let USAAClassicSavingsAccount = _prefix "USAAClassicSavingsAccount"
    let USAAClassicSavingsAccountCurrentBalance = _prefix "USAAClassicSavingsAccountCurrentBalance"
    let USAAClassicSavingsAccountAvailableBalance = _prefix "USAAClassicSavingsAccountAvailableBalance"
    let CrewFinanceChecking = _prefix "CrewFinanceChecking"
    let CrewFinanceCheckingAccount = _prefix "CrewFinanceCheckingAccount"
    let CrewFinanceCheckingAccountCurrentBalance = _prefix "CrewFinanceCheckingAccountCurrentBalance"
    let CrewFinanceCheckingAccountAvailableBalance = _prefix "CrewFinanceCheckingAccountAvailableBalance"
    let hasCurrentBalance = _prefix "hasCurrentBalance"
    let hasAvailableBalance = _prefix "hasAvailableBalance"
    let CurrentBalance = _prefix "CurrentBalance"
    let AvailableBalance = _prefix "AvailableBalance"

































!> commonplace.eristocrates -~|> [
    a ->- foaf.Person
    foaf.firstName ->= "Brandon"
    foaf.familyName ->= "Collier"
    foaf.lastName ->= "Collier"
    foaf.surname ->= "Collier"
    foaf.knows ->- commonplace.syrislove
    foaf.workInfoHomepage ->- com.governmentjobs.ApplicationsSystemsAnalystI
    foaf.workplaceHomepage ->- gov.leoncountyfl.cms.OfficeofInformationTechnology
    foaf.age ->= Me.myBirthday.currentAge
    foaf.nick ->= "eristocrates"

] 
-!> commonplace.syrislove  -~|> [
    a ->- foaf.Person
    foaf.firstName ->= "Tierra"
    foaf.familyName ->= "Fisher"
    foaf.lastName ->= "Fisher"
    foaf.surname ->= "Fisher"
    foaf.knows ->- commonplace.eristocrates
    foaf.workInfoHomepage ->- com.myfuelmaster.desktop_support_technician
    foaf.workplaceHomepage ->- com.myfuelmaster.https
    foaf.age ->= syrisBirthday.currentAge
    foaf.nick ->= "syrislove"


] 
-!| [
        commonplace.WellsFargoEverydayCheckingAccount
        commonplace.CrewFinanceCheckingAccount
    ] --- relFibo.isHeldBy --> commonplace.eristocrates
-!| [
        commonplace.USAAClassicCheckingAccount
        commonplace.USAAClassicSavingsAccount
    ] --- relFibo.isHeldBy --> commonplace.syrislove
-!| [
        commonplace.WellsFargoEverydayCheckingAccount
        commonplace.USAAClassicCheckingAccount
        commonplace.CrewFinanceCheckingAccount
    ] --- a -->  caaFibo.DemandDepositAccount
-!| [
        commonplace.hasCurrentBalance
        commonplace.hasAvailableBalance
] --- rdfs.subPropertyOf --> caaFibo.hasBalance
-!| [
        commonplace.CurrentBalance
        commonplace.AvailableBalance
] --- rdfs.subClassOf --> caaFibo.Balance


-!> commonplace.WellsFargoEverydayCheckingAccount -~|> [
    orgCmns.isProvidedBy ->- lei.WellsFargoNationalBank
    relFibo.exemplifies ->- commonplace.WellsFargoEverydayChecking
    commonplace.hasCurrentBalance ->- commonplace.WellsFargoEverydayCheckingAccountCurrentBalance
    commonplace.hasAvailableBalance ->- commonplace.WellsFargoEverydayCheckingAccountAvailableBalance 
]

-!> commonplace.WellsFargoEverydayChecking --- rdfs.seeAlso --> com.wellsfargo.everydayChecking
-!> commonplace.WellsFargoEverydayCheckingAccountCurrentBalance --- curFibo.hasAmount -->= wellsFargoEveryDayCheckingAccount.currentBalance.Value
-!> commonplace.WellsFargoEverydayCheckingAccountAvailableBalance --- curFibo.hasAmount -->= wellsFargoEveryDayCheckingAccount.availableBalance.Value
// -*| [Formula.fromIGraph lei.WellsFargoNationalBank.graphDocument.asIGraph]


-!> commonplace.CrewFinanceCheckingAccount -~|> [
    orgCmns.isProvidedBy ->- lei.BangorSavingsBank
    relFibo.exemplifies ->- commonplace.CrewFinanceChecking
    commonplace.hasCurrentBalance ->- commonplace.CrewFinanceCheckingAccountCurrentBalance
    commonplace.hasAvailableBalance ->- commonplace.CrewFinanceCheckingAccountAvailableBalance
]
-!> commonplace.CrewFinanceChecking --- rdfs.seeAlso --> com.trycrew.checkingAccountDisclosure
-!> commonplace.CrewFinanceCheckingAccountCurrentBalance --- curFibo.hasAmount -->= crewCheckingAccount.currentBalance.Value
-!> commonplace.CrewFinanceCheckingAccountAvailableBalance --- curFibo.hasAmount -->= crewCheckingAccount.availableBalance.Value
// -*| [Formula.fromIGraph lei.BangorSavingsBank.graphDocument.asIGraph]


-!| [
        commonplace.USAAClassicCheckingAccount
        commonplace.USAAClassicSavingsAccount
    ] --- orgCmns.isProvidedBy  --> lei.USAAFederalSavingsBank
-!> commonplace.USAAClassicCheckingAccount -~|> [
    relFibo.exemplifies ->- commonplace.USAAClassicChecking
    commonplace.hasCurrentBalance ->- commonplace.USAAClassicCheckingAccountCurrentBalance
    commonplace.hasAvailableBalance ->- commonplace.USAAClassicCheckingAccountAvailableBalance
]
-!> commonplace.USAAClassicChecking --- rdfs.seeAlso --> com.usaaBanking.checking
-!> commonplace.USAAClassicCheckingAccountCurrentBalance --- curFibo.hasAmount -->= usaaCheckingAccount.currentBalance.Value
-!> commonplace.USAAClassicCheckingAccountAvailableBalance --- curFibo.hasAmount -->= usaaCheckingAccount.availableBalance.Value

-!> commonplace.USAAClassicSavingsAccount -~|> [
    relFibo.exemplifies ->- commonplace.USAAClassicSavings
    commonplace.hasCurrentBalance ->- commonplace.USAAClassicSavingsAccountCurrentBalance
    commonplace.hasAvailableBalance ->- commonplace.USAAClassicSavingsAccountAvailableBalance
    // TODO double check what kind of account this is 
    a ->- caaFibo.DepositAccount
]
-!> commonplace.USAAClassicSavings --- rdfs.seeAlso --> com.usaaBanking.savings
-!> commonplace.USAAClassicSavingsAccountCurrentBalance --- curFibo.hasAmount -->= usaaSavingsAccount.currentBalance.Value
-!> commonplace.USAAClassicSavingsAccountAvailableBalance --- curFibo.hasAmount -->= usaaSavingsAccount.availableBalance.Value

-!|[ 
        commonplace.WellsFargoEverydayChecking
        commonplace.CrewFinanceChecking
        commonplace.USAAClassicChecking
        commonplace.USAAClassicSavings
     ] --- a --> fseFibo.BankingProduct
-!|[ 
        commonplace.WellsFargoEverydayCheckingAccountCurrentBalance
        commonplace.WellsFargoEverydayCheckingAccountAvailableBalance
        commonplace.CrewFinanceCheckingAccountCurrentBalance
        commonplace.CrewFinanceCheckingAccountAvailableBalance
        commonplace.USAAClassicCheckingAccountCurrentBalance
        commonplace.USAAClassicCheckingAccountAvailableBalance
        commonplace.USAAClassicSavingsAccountCurrentBalance
        commonplace.USAAClassicSavingsAccountAvailableBalance
     ] 
     -~|> [
            curFibo.hasCurrency ->- iso4217.USDollar
            ``cmns-dt``.hasObservedDateTime ->= DateTimeOffset.Now

            ]
-!|[ 
    commonplace.WellsFargoEverydayCheckingAccountCurrentBalance
    commonplace.CrewFinanceCheckingAccountCurrentBalance
    commonplace.USAAClassicCheckingAccountCurrentBalance
    commonplace.USAAClassicSavingsAccountCurrentBalance
     ] 
     -~|> [
            a ->- commonplace.CurrentBalance

            ]
-!|[ 
        commonplace.WellsFargoEverydayCheckingAccountAvailableBalance
        commonplace.CrewFinanceCheckingAccountAvailableBalance
        commonplace.USAAClassicCheckingAccountAvailableBalance
        commonplace.USAAClassicSavingsAccountAvailableBalance
     ] 
     -~|> [
            a ->- commonplace.AvailableBalance

            ]
// -*| [Formula.fromIGraph lei.USAAFederalSavingsBank.graphDocument.asIGraph]
|> writeDraft Folder.Scratch.FullName "scratch"

// 
