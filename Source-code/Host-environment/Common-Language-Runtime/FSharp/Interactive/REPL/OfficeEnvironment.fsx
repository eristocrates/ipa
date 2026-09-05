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


#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
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

open Dubzer.WhatwgUrl
open PuppeteerSharp
open FsHttp
open System.IO.Compression
open System.IO
open VDS.RDF.Query.Datasets
open VDS.RDF
open VDS.RDF.Parsing
open System
open FolkerKinzel.MimeTypes
open System.Threading



#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\Namespace\Generated"

#r "rdfNamespace.dll"
open RdfNamespace
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

#r "fibo-fbc-fct-fseNamespace.dll"
open ``Fibo-fbc-fct-fseNamespace``
module fse = ``fibo-fbc-fct-fse``
#r "fibo-fbc-pas-caaNamespace.dll"
open ``Fibo-fbc-pas-caaNamespace``
module caa = ``fibo-fbc-pas-caa``
#r "fibo-loan-spc-crdNamespace.dll"
open ``Fibo-loan-spc-crdNamespace``
module crd = ``fibo-loan-spc-crd``

#r "fibo-loan-ln-lnNamespace.dll"
open ``Fibo-loan-ln-lnNamespace``
module ln = ``fibo-loan-ln-ln``



let a = rdf.type_



module dbug = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/"  "dbug"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"

module commonplace = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/commonplace/"  "commonplace"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let eristocrates = _prefix "eristocrates"
    let syrislove = _prefix "syrislove"

module governmentjobs = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.governmentjobs.com/careers/leoncountyfl/classspecs/"  "governmentjobs"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let ApplicationsSystemsAnalystI = _prefix "1183950"

module fuelmasterjob = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://myfuelmaster.com/job/"  "fuelmasterjob"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let desktop_support_technician = _prefix "desktop-support-technician-8"


module wellsFargoAccount = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://connect.secure.wellsfargo.com/accounts/start#"  "wellsFargoAccount"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let everydayChecking = _prefix "everydayChecking" 
    let platinumCard = _prefix "platinumCard"
    let installmentLoans = _prefix "installmentLoans"
    let wellsFargoRewards = _prefix "wellsFargoRewards"
    

module usaaAccount = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://mobile.usaa.com/my/logon?acf=1#"  "usaaAccount"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let checking = _prefix "checking"
    let platinumVisa = _prefix "platinumVisa"
    let usaaSavings = _prefix "usaaSavings"



// foaf.currentProject
// foaf.geekcode
// foaf.img
// foaf.pastProject
// foaf.plan
// foaf.publications
// foaf.schoolHomepage

type Birthday = 
    | Birthday of DateOnly
    member this.date = 
        match this with 
        | Birthday date -> date
    // TODO Adjust for manths pre/post birthdate
    member this.currentAge = DateTime.Now.Year - this.date.Year

let erisBirthday = new DateOnly(1991,7,5) |> Birthday
let syrisBirthday = new DateOnly(1993,5,28) |> Birthday



!> commonplace.eristocrates -~|> [
    a ->- foaf.Person
    foaf.firstName ->= "Brandon"
    foaf.familyName ->= "Collier"
    foaf.lastName ->= "Collier"
    foaf.surname ->= "Collier"
    foaf.knows ->- commonplace.syrislove
    foaf.workInfoHomepage ->- governmentjobs.ApplicationsSystemsAnalystI
    foaf.workplaceHomepage ->= (Uri "https://cms.leoncountyfl.gov/Government/Departments/Information-and-Technology/Office-of-Information-Technology")
    foaf.age ->= erisBirthday.currentAge
    foaf.nick ->= "eristocrates"

] 
-!> commonplace.syrislove  -~|> [
    a ->- foaf.Person
    
    foaf.firstName ->= "Tierra"
    foaf.familyName ->= "Fisher"
    foaf.lastName ->= "Fisher"
    foaf.surname ->= "Fisher"
    foaf.knows ->- commonplace.eristocrates
    foaf.workInfoHomepage ->- fuelmasterjob.desktop_support_technician
    foaf.workplaceHomepage ->= (Uri "https://myfuelmaster.com/")
    foaf.age ->= syrisBirthday.currentAge
    foaf.nick ->= "syrislove"


] 
-!| [ 
    wellsFargoAccount.installmentLoans
] --- a --> ln.LoanSpecificCustomerAccount
-!| [ 
    wellsFargoAccount.wellsFargoRewards
] --- a --> caa.Account
-!| [ 
    
    usaaAccount.usaaSavings
] --- a --> caa.DepositAccount
-!| [ 
    wellsFargoAccount.everydayChecking
    usaaAccount.checking
] --- a --> crd.DebitCardAccount
-!| [ 
    wellsFargoAccount.platinumCard
    usaaAccount.platinumVisa
] --- a --> crd.CreditCardAccount
-!| [ 
    wellsFargoAccount.everydayChecking
    wellsFargoAccount.platinumCard
    wellsFargoAccount.installmentLoans
    wellsFargoAccount.wellsFargoRewards

     ] -~|> [
    
    caa.AccountHolder ->- commonplace.eristocrates
]
-!| [ 
    usaaAccount.checking
    usaaAccount.platinumVisa
    usaaAccount.usaaSavings

     ] -~|> [
    
    caa.AccountHolder ->- commonplace.syrislove
]
|> writeDraft Folder.Scratch.FullName "scratch"

