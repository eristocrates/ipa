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




let a = rdf.type_



module dbug = 
    let _prefixId = PrefixId.fromNamespaceLabel "https://eristocrates.dev/ontology/dbug/"  "dbug"
    let _prefix (localName:string) = PrefixedIri { prefixId = _prefixId ; localName = localName } 
    let Bob = _prefix "Bob"
    let Alice = _prefix "Alice"
    let this = _prefix "this"
    let test = _prefix "test"


!> vann._prefixId --- a --> voaf.Vocabulary
|> writeDraft Folder.Scratch.FullName "scratch"









