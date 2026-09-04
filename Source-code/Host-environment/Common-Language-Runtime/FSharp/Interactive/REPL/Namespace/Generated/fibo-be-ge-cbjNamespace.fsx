#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-cbj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CaribbeanGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-cbj"

    let _namespaceIri = _prefixId.prefix ""
    let AntiguaAndBarbudaEntity = _prefixId.prefix "AntiguaAndBarbudaEntity"
    let BahamianEntity = _prefixId.prefix "BahamianEntity"
    let BarbadianEntity = _prefixId.prefix "BarbadianEntity"
    let BermudanEntity = _prefixId.prefix "BermudanEntity"
    let CaymanIslandsEntity = _prefixId.prefix "CaymanIslandsEntity"
    let CubanEntity = _prefixId.prefix "CubanEntity"
    let DominicaEntity = _prefixId.prefix "DominicaEntity"
    let DominicanRepublicEntity = _prefixId.prefix "DominicanRepublicEntity"
    let GovernmentOfAntiguaAndBarbuda = _prefixId.prefix "GovernmentOfAntiguaAndBarbuda"
    let GovernmentOfBarbados = _prefixId.prefix "GovernmentOfBarbados"
    let GovernmentOfBermuda = _prefixId.prefix "GovernmentOfBermuda"
    let GovernmentOfGrenada = _prefixId.prefix "GovernmentOfGrenada"
    let GovernmentOfJamaica = _prefixId.prefix "GovernmentOfJamaica"
    let GovernmentOfSaintLucia = _prefixId.prefix "GovernmentOfSaintLucia"

    let GovernmentOfSaintVincentAndTheGrenadines =
        _prefixId.prefix "GovernmentOfSaintVincentAndTheGrenadines"

    let GovernmentOfTheCaymanIslands = _prefixId.prefix "GovernmentOfTheCaymanIslands"

    let GovernmentOfTheCommonwealthOfDominica =
        _prefixId.prefix "GovernmentOfTheCommonwealthOfDominica"

    let GovernmentOfTheCommonwealthOfTheBahamas =
        _prefixId.prefix "GovernmentOfTheCommonwealthOfTheBahamas"

    let GovernmentOfTheDominicanRepublic =
        _prefixId.prefix "GovernmentOfTheDominicanRepublic"

    let GovernmentOfTheFederationOfSaintChristopherAndNevis =
        _prefixId.prefix "GovernmentOfTheFederationOfSaintChristopherAndNevis"

    let GovernmentOfTheRepublicOfCuba = _prefixId.prefix "GovernmentOfTheRepublicOfCuba"

    let GovernmentOfTheRepublicOfHaiti =
        _prefixId.prefix "GovernmentOfTheRepublicOfHaiti"

    let GovernmentOfTheRepublicOfTrinidadAndTobago =
        _prefixId.prefix "GovernmentOfTheRepublicOfTrinidadAndTobago"

    let GrenadianEntity = _prefixId.prefix "GrenadianEntity"
    let HaitianEntity = _prefixId.prefix "HaitianEntity"
    let JamaicanEntity = _prefixId.prefix "JamaicanEntity"

    let JurisdictionOfAntiguaAndBarbuda =
        _prefixId.prefix "JurisdictionOfAntiguaAndBarbuda"

    let JurisdictionOfBarbados = _prefixId.prefix "JurisdictionOfBarbados"
    let JurisdictionOfBermuda = _prefixId.prefix "JurisdictionOfBermuda"
    let JurisdictionOfCuba = _prefixId.prefix "JurisdictionOfCuba"
    let JurisdictionOfDominica = _prefixId.prefix "JurisdictionOfDominica"
    let JurisdictionOfGrenada = _prefixId.prefix "JurisdictionOfGrenada"
    let JurisdictionOfHaiti = _prefixId.prefix "JurisdictionOfHaiti"
    let JurisdictionOfJamaica = _prefixId.prefix "JurisdictionOfJamaica"
    let JurisdictionOfSaintLucia = _prefixId.prefix "JurisdictionOfSaintLucia"

    let JurisdictionOfSaintVincentAndTheGrenadines =
        _prefixId.prefix "JurisdictionOfSaintVincentAndTheGrenadines"

    let JurisdictionOfTheCaymanIslands =
        _prefixId.prefix "JurisdictionOfTheCaymanIslands"

    let JurisdictionOfTheCommonwealthOfTheBahamas =
        _prefixId.prefix "JurisdictionOfTheCommonwealthOfTheBahamas"

    let JurisdictionOfTheDominicanRepublic =
        _prefixId.prefix "JurisdictionOfTheDominicanRepublic"

    let JurisdictionOfTheFederationOfSaintChristopherAndNevis =
        _prefixId.prefix "JurisdictionOfTheFederationOfSaintChristopherAndNevis"

    let JurisdictionOfTheRepublicOfTrinidadAndTobago =
        _prefixId.prefix "JurisdictionOfTheRepublicOfTrinidadAndTobago"

    let SaintKittsAndNevisEntity = _prefixId.prefix "SaintKittsAndNevisEntity"
    let SaintLucianEntity = _prefixId.prefix "SaintLucianEntity"
    let SaintVincentianEntity = _prefixId.prefix "SaintVincentianEntity"

    let TrinidadianAndTobagonianEntity =
        _prefixId.prefix "TrinidadianAndTobagonianEntity"
