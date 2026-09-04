#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-eeuj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/EasternEuropeGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-eeuj"

    let _namespaceIri = _prefixId.prefix ""
    let BelarusianEntity = _prefixId.prefix "BelarusianEntity"
    let BulgarianEntity = _prefixId.prefix "BulgarianEntity"
    let CzechEntity = _prefixId.prefix "CzechEntity"
    let GovernmentOfHungary = _prefixId.prefix "GovernmentOfHungary"
    let GovernmentOfRomania = _prefixId.prefix "GovernmentOfRomania"
    let GovernmentOfTheCzechRepublic = _prefixId.prefix "GovernmentOfTheCzechRepublic"

    let GovernmentOfTheRepublicOfBelarus =
        _prefixId.prefix "GovernmentOfTheRepublicOfBelarus"

    let GovernmentOfTheRepublicOfBulgaria =
        _prefixId.prefix "GovernmentOfTheRepublicOfBulgaria"

    let GovernmentOfTheRepublicOfMoldova =
        _prefixId.prefix "GovernmentOfTheRepublicOfMoldova"

    let GovernmentOfTheRepublicOfPoland =
        _prefixId.prefix "GovernmentOfTheRepublicOfPoland"

    let GovernmentOfTheRussianFederation =
        _prefixId.prefix "GovernmentOfTheRussianFederation"

    let GovernmentOfTheSlovakRepublic = _prefixId.prefix "GovernmentOfTheSlovakRepublic"
    let GovernmentOfUkraine = _prefixId.prefix "GovernmentOfUkraine"
    let HungarianEntity = _prefixId.prefix "HungarianEntity"
    let JurisdictionOfBelarus = _prefixId.prefix "JurisdictionOfBelarus"
    let JurisdictionOfBulgaria = _prefixId.prefix "JurisdictionOfBulgaria"
    let JurisdictionOfCzechia = _prefixId.prefix "JurisdictionOfCzechia"
    let JurisdictionOfHungary = _prefixId.prefix "JurisdictionOfHungary"
    let JurisdictionOfMoldova = _prefixId.prefix "JurisdictionOfMoldova"
    let JurisdictionOfPoland = _prefixId.prefix "JurisdictionOfPoland"
    let JurisdictionOfRomania = _prefixId.prefix "JurisdictionOfRomania"

    let JurisdictionOfRussianFederation =
        _prefixId.prefix "JurisdictionOfRussianFederation"

    let JurisdictionOfSlovakia = _prefixId.prefix "JurisdictionOfSlovakia"
    let JurisdictionOfUkraine = _prefixId.prefix "JurisdictionOfUkraine"
    let MoldovanEntity = _prefixId.prefix "MoldovanEntity"
    let PolishEntity = _prefixId.prefix "PolishEntity"
    let RomanianEntity = _prefixId.prefix "RomanianEntity"
    let RussianEntity = _prefixId.prefix "RussianEntity"
    let SlovakEntity = _prefixId.prefix "SlovakEntity"
    let UkranianEntity = _prefixId.prefix "UkranianEntity"
