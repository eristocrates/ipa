#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-ctlaj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/CentralAmericanGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-ctlaj"

    let _namespaceIri = _prefixId.prefix ""
    let BelizeanEntity = _prefixId.prefix "BelizeanEntity"
    let CostaRicanEntity = _prefixId.prefix "CostaRicanEntity"
    let GovernmentOfBelize = _prefixId.prefix "GovernmentOfBelize"

    let GovernmentOfTheRepublicOfCostaRica =
        _prefixId.prefix "GovernmentOfTheRepublicOfCostaRica"

    let GovernmentOfTheRepublicOfElSalvador =
        _prefixId.prefix "GovernmentOfTheRepublicOfElSalvador"

    let GovernmentOfTheRepublicOfGuatemala =
        _prefixId.prefix "GovernmentOfTheRepublicOfGuatemala"

    let GovernmentOfTheRepublicOfHonduras =
        _prefixId.prefix "GovernmentOfTheRepublicOfHonduras"

    let GovernmentOfTheRepublicOfNicaragua =
        _prefixId.prefix "GovernmentOfTheRepublicOfNicaragua"

    let GovernmentOfTheRepublicOfPanama =
        _prefixId.prefix "GovernmentOfTheRepublicOfPanama"

    let GuatemalanEntity = _prefixId.prefix "GuatemalanEntity"
    let HonduranEntity = _prefixId.prefix "HonduranEntity"
    let JurisdictionOfBelize = _prefixId.prefix "JurisdictionOfBelize"
    let JurisdictionOfCostaRica = _prefixId.prefix "JurisdictionOfCostaRica"
    let JurisdictionOfElSalvador = _prefixId.prefix "JurisdictionOfElSalvador"
    let JurisdictionOfGuatemala = _prefixId.prefix "JurisdictionOfGuatemala"
    let JurisdictionOfHonduras = _prefixId.prefix "JurisdictionOfHonduras"
    let JurisdictionOfNicaragua = _prefixId.prefix "JurisdictionOfNicaragua"
    let JurisdictionOfPanama = _prefixId.prefix "JurisdictionOfPanama"
    let NicaraguanEntity = _prefixId.prefix "NicaraguanEntity"
    let PanamanianEntity = _prefixId.prefix "PanamanianEntity"
    let SalvadorianEntity = _prefixId.prefix "SalvadorianEntity"
