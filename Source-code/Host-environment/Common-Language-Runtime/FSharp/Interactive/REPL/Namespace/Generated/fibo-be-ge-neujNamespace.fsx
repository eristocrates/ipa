#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-neuj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/NorthernEuropeGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-neuj"

    let _namespaceIri = _prefixId.prefix ""
    let AlandIslandsJurisdiction = _prefixId.prefix "AlandIslandsJurisdiction"
    let AlandicEntity = _prefixId.prefix "AlandicEntity"
    let DanishEntity = _prefixId.prefix "DanishEntity"
    let EstonianEntity = _prefixId.prefix "EstonianEntity"
    let FinnishEntity = _prefixId.prefix "FinnishEntity"
    let GovernmentOfAland = _prefixId.prefix "GovernmentOfAland"
    let GovernmentOfIceland = _prefixId.prefix "GovernmentOfIceland"

    let GovernmentOfTheKingdomOfDenmark =
        _prefixId.prefix "GovernmentOfTheKingdomOfDenmark"

    let GovernmentOfTheKingdomOfNorway =
        _prefixId.prefix "GovernmentOfTheKingdomOfNorway"

    let GovernmentOfTheKingdomOfSweden =
        _prefixId.prefix "GovernmentOfTheKingdomOfSweden"

    let GovernmentOfTheRepublicOfEstonia =
        _prefixId.prefix "GovernmentOfTheRepublicOfEstonia"

    let GovernmentOfTheRepublicOfFinland =
        _prefixId.prefix "GovernmentOfTheRepublicOfFinland"

    let GovernmentOfTheRepublicOfIreland =
        _prefixId.prefix "GovernmentOfTheRepublicOfIreland"

    let GovernmentOfTheRepublicOfLatvia =
        _prefixId.prefix "GovernmentOfTheRepublicOfLatvia"

    let GovernmentOfTheRepublicOfLithuania =
        _prefixId.prefix "GovernmentOfTheRepublicOfLithuania"

    let IcelandicEntity = _prefixId.prefix "IcelandicEntity"
    let IrishEntity = _prefixId.prefix "IrishEntity"
    let JurisdictionOfDenmark = _prefixId.prefix "JurisdictionOfDenmark"
    let JurisdictionOfEstonia = _prefixId.prefix "JurisdictionOfEstonia"
    let JurisdictionOfFinland = _prefixId.prefix "JurisdictionOfFinland"
    let JurisdictionOfIceland = _prefixId.prefix "JurisdictionOfIceland"
    let JurisdictionOfIreland = _prefixId.prefix "JurisdictionOfIreland"
    let JurisdictionOfLatvia = _prefixId.prefix "JurisdictionOfLatvia"
    let JurisdictionOfLithuania = _prefixId.prefix "JurisdictionOfLithuania"
    let JurisdictionOfNorway = _prefixId.prefix "JurisdictionOfNorway"
    let JurisdictionOfSweden = _prefixId.prefix "JurisdictionOfSweden"
    let LatvianEntity = _prefixId.prefix "LatvianEntity"
    let LithuanianEntity = _prefixId.prefix "LithuanianEntity"
    let NorwegianEntity = _prefixId.prefix "NorwegianEntity"
    let SwedishEntity = _prefixId.prefix "SwedishEntity"
