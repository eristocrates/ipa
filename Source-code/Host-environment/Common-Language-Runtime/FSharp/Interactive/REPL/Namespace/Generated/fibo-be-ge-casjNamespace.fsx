#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-casj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/CentralAsiaGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-casj"

    let _namespaceIri = _prefixId.prefix ""
    let GovernmentOfTheKyrgyzRepublic = _prefixId.prefix "GovernmentOfTheKyrgyzRepublic"

    let GovernmentOfTheRepublicOfKazakhstan =
        _prefixId.prefix "GovernmentOfTheRepublicOfKazakhstan"

    let GovernmentOfTheRepublicOfTajikistan =
        _prefixId.prefix "GovernmentOfTheRepublicOfTajikistan"

    let GovernmentOfTheRepublicOfUzbekistan =
        _prefixId.prefix "GovernmentOfTheRepublicOfUzbekistan"

    let GovernmentOfTurkmenistan = _prefixId.prefix "GovernmentOfTurkmenistan"

    let JurisdictionOfTheKyrgyzRepublic =
        _prefixId.prefix "JurisdictionOfTheKyrgyzRepublic"

    let JurisdictionOfTheRepublicOfKazakhstan =
        _prefixId.prefix "JurisdictionOfTheRepublicOfKazakhstan"

    let JurisdictionOfTheRepublicOfTajikistan =
        _prefixId.prefix "JurisdictionOfTheRepublicOfTajikistan"

    let JurisdictionOfTheRepublicOfUzbekistan =
        _prefixId.prefix "JurisdictionOfTheRepublicOfUzbekistan"

    let JurisdictionOfTurkmenistan = _prefixId.prefix "JurisdictionOfTurkmenistan"
    let StateOfKazakhstan = _prefixId.prefix "StateOfKazakhstan"
    let StateOfKyrgyzstan = _prefixId.prefix "StateOfKyrgyzstan"
    let StateOfTajikistan = _prefixId.prefix "StateOfTajikistan"
    let StateOfTurkmenistan = _prefixId.prefix "StateOfTurkmenistan"
    let StateOfUzbekistan = _prefixId.prefix "StateOfUzbekistan"
