#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-sasj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/SouthernAsiaGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-sasj"

    let _namespaceIri = _prefixId.prefix ""

    let GovernmentOfTheDemocraticSocialistRepublicOfSriLanka =
        _prefixId.prefix "GovernmentOfTheDemocraticSocialistRepublicOfSriLanka"

    let GovernmentOfTheFederalDemocraticRepublicOfNepal =
        _prefixId.prefix "GovernmentOfTheFederalDemocraticRepublicOfNepal"

    let GovernmentOfTheIslamicRepublicOfAfghanistan =
        _prefixId.prefix "GovernmentOfTheIslamicRepublicOfAfghanistan"

    let GovernmentOfTheIslamicRepublicOfIran =
        _prefixId.prefix "GovernmentOfTheIslamicRepublicOfIran"

    let GovernmentOfTheIslamicRepublicOfPakistan =
        _prefixId.prefix "GovernmentOfTheIslamicRepublicOfPakistan"

    let GovernmentOfTheKingdomOfBhutan =
        _prefixId.prefix "GovernmentOfTheKingdomOfBhutan"

    let GovernmentOfThePeoplesRepublicOfBangladesh =
        _prefixId.prefix "GovernmentOfThePeoplesRepublicOfBangladesh"

    let GovernmentOfTheRepublicOfIndia =
        _prefixId.prefix "GovernmentOfTheRepublicOfIndia"

    let GovernmentOfTheRepublicOfMaldives =
        _prefixId.prefix "GovernmentOfTheRepublicOfMaldives"

    let JurisdictionOfAfghanistan = _prefixId.prefix "JurisdictionOfAfghanistan"
    let JurisdictionOfBangladesh = _prefixId.prefix "JurisdictionOfBangladesh"
    let JurisdictionOfBhutan = _prefixId.prefix "JurisdictionOfBhutan"
    let JurisdictionOfIndia = _prefixId.prefix "JurisdictionOfIndia"
    let JurisdictionOfIran = _prefixId.prefix "JurisdictionOfIran"
    let JurisdictionOfMaldives = _prefixId.prefix "JurisdictionOfMaldives"
    let JurisdictionOfNepal = _prefixId.prefix "JurisdictionOfNepal"
    let JurisdictionOfPakistan = _prefixId.prefix "JurisdictionOfPakistan"
    let JurisdictionOfSriLanka = _prefixId.prefix "JurisdictionOfSriLanka"
    let StateOfAfghanistan = _prefixId.prefix "StateOfAfghanistan"
    let StateOfBangladesh = _prefixId.prefix "StateOfBangladesh"
    let StateOfBhutan = _prefixId.prefix "StateOfBhutan"
    let StateOfIndia = _prefixId.prefix "StateOfIndia"
    let StateOfIran = _prefixId.prefix "StateOfIran"
    let StateOfMaldives = _prefixId.prefix "StateOfMaldives"
    let StateOfNepal = _prefixId.prefix "StateOfNepal"
    let StateOfPakistan = _prefixId.prefix "StateOfPakistan"
    let StateOfSriLanka = _prefixId.prefix "StateOfSriLanka"
