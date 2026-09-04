#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-fnd-org-mod`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/FND/Organizations/MetadataFNDOrganizations/" "fibo-fnd-org-mod"

    let _namespaceIri = _prefixId.prefix ""
    let OrganizationsModule = _prefixId.prefix "OrganizationsModule"
