(*

& "C:\Program Files\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9222 --user-data-dir=C:\temp\chrome-automation


& "C:\Program Files\Mozilla Firefox\firefox.exe" --remote-debugging-port 9223
*)

// TODO add gnd to known ontologies https:-nb.info/standards/elementset/gnd2012-06-30

#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#time on
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true


#r "SparqlErgonomics.dll"
open SparqlErgonomics

#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl


#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL\Namespace\Generated"

#r "rdfNamespace.dll"
open RdfNamespace
#r "rdfsNamespace.dll"
open RdfsNamespace

#r "owlNamespace.dll"
open OwlNamespace

module dbug =
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/" "dbug"
    let _prefix (localName: string) =
        PrefixedIri {
            prefixId = _prefixId
            localName = localName
        }
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"

module commonplace =
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/commonplace/" "commonplace"
    let _prefix (localName: string) =
        PrefixedIri {
            prefixId = _prefixId
            localName = localName
        }
    let eristocrates = _prefix "eristocrates"
    let syrislove = _prefix "syrislove"



let a = rdf.type_

!>commonplace.eristocrates
-~|> [
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
