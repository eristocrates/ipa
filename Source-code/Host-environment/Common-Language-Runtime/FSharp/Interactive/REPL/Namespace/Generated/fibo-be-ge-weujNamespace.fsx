#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-weuj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/WesternEuropeGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-weuj"

    let _namespaceIri = _prefixId.prefix ""
    let AustrianEntity = _prefixId.prefix "AustrianEntity"
    let BelgianEntity = _prefixId.prefix "BelgianEntity"
    let FrenchEntity = _prefixId.prefix "FrenchEntity"
    let GermanEntity = _prefixId.prefix "GermanEntity"

    let GovernmentOfTheFederalRepublicOfGermany =
        _prefixId.prefix "GovernmentOfTheFederalRepublicOfGermany"

    let GovernmentOfTheFrenchRepublic = _prefixId.prefix "GovernmentOfTheFrenchRepublic"

    let GovernmentOfTheGrandDuchyOfLuxembourg =
        _prefixId.prefix "GovernmentOfTheGrandDuchyOfLuxembourg"

    let GovernmentOfTheKingdomOfBelgium =
        _prefixId.prefix "GovernmentOfTheKingdomOfBelgium"

    let GovernmentOfTheNetherlands = _prefixId.prefix "GovernmentOfTheNetherlands"

    let GovernmentOfThePrincipalityOfLiechtenstein =
        _prefixId.prefix "GovernmentOfThePrincipalityOfLiechtenstein"

    let GovernmentOfThePrincipalityOfMonaco =
        _prefixId.prefix "GovernmentOfThePrincipalityOfMonaco"

    let GovernmentOfTheRepublicOfAustria =
        _prefixId.prefix "GovernmentOfTheRepublicOfAustria"

    let GovernmentOfTheSwissConfederation =
        _prefixId.prefix "GovernmentOfTheSwissConfederation"

    let JurisdictionOfAustria = _prefixId.prefix "JurisdictionOfAustria"
    let JurisdictionOfBelgium = _prefixId.prefix "JurisdictionOfBelgium"
    let JurisdictionOfFrance = _prefixId.prefix "JurisdictionOfFrance"
    let JurisdictionOfGermany = _prefixId.prefix "JurisdictionOfGermany"
    let JurisdictionOfLiechtenstein = _prefixId.prefix "JurisdictionOfLiechtenstein"
    let JurisdictionOfLuxembourg = _prefixId.prefix "JurisdictionOfLuxembourg"
    let JurisdictionOfMonaco = _prefixId.prefix "JurisdictionOfMonaco"
    let JurisdictionOfSwitzerland = _prefixId.prefix "JurisdictionOfSwitzerland"
    let JurisdictionOfTheNetherlands = _prefixId.prefix "JurisdictionOfTheNetherlands"
    let LiechtensteinerEntity = _prefixId.prefix "LiechtensteinerEntity"
    let LuxembourgerEntity = _prefixId.prefix "LuxembourgerEntity"
    let MonegasqueEntity = _prefixId.prefix "MonegasqueEntity"
    let NetherlandsEntity = _prefixId.prefix "NetherlandsEntity"
    let SwissEntity = _prefixId.prefix "SwissEntity"
