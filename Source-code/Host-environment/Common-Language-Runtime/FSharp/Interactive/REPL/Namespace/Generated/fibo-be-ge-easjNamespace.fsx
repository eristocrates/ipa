#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-easj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/EasternAsiaGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-easj"

    let _namespaceIri = _prefixId.prefix ""
    let GovernmentOfJapan = _prefixId.prefix "GovernmentOfJapan"
    let GovernmentOfMongolia = _prefixId.prefix "GovernmentOfMongolia"

    let GovernmentOfTheDemocraticPeoplesRepublicOfKorea =
        _prefixId.prefix "GovernmentOfTheDemocraticPeoplesRepublicOfKorea"

    let GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina =
        _prefixId.prefix "GovernmentOfTheHongKongSpecialAdministrativeRegionOfThePeoplesRepublicOfChina"

    let GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina =
        _prefixId.prefix "GovernmentOfTheMacaoSpecialAdministrativeRegionOfThePeoplesRepublicOfChina"

    let GovernmentOfThePeoplesRepublicOfChina =
        _prefixId.prefix "GovernmentOfThePeoplesRepublicOfChina"

    let GovernmentOfTheRepublicOfChina =
        _prefixId.prefix "GovernmentOfTheRepublicOfChina"

    let GovernmentOfTheRepublicOfKorea =
        _prefixId.prefix "GovernmentOfTheRepublicOfKorea"

    let JurisdictionOfChina = _prefixId.prefix "JurisdictionOfChina"
    let JurisdictionOfHongKong = _prefixId.prefix "JurisdictionOfHongKong"
    let JurisdictionOfJapan = _prefixId.prefix "JurisdictionOfJapan"
    let JurisdictionOfMacao = _prefixId.prefix "JurisdictionOfMacao"
    let JurisdictionOfMongolia = _prefixId.prefix "JurisdictionOfMongolia"

    let JurisdictionOfTheDemocraticPeoplesRepublicOfKorea =
        _prefixId.prefix "JurisdictionOfTheDemocraticPeoplesRepublicOfKorea"

    let JurisdictionOfTheRepublicOfChina =
        _prefixId.prefix "JurisdictionOfTheRepublicOfChina"

    let JurisdictionOfTheRepublicOfKorea =
        _prefixId.prefix "JurisdictionOfTheRepublicOfKorea"

    let RegionalStateOfHongKong = _prefixId.prefix "RegionalStateOfHongKong"
    let RegionalStateOfMacao = _prefixId.prefix "RegionalStateOfMacao"
    let StateOfChina = _prefixId.prefix "StateOfChina"
    let StateOfJapan = _prefixId.prefix "StateOfJapan"
    let StateOfMongolia = _prefixId.prefix "StateOfMongolia"
    let StateOfNorthKorea = _prefixId.prefix "StateOfNorthKorea"
    let StateOfSouthKorea = _prefixId.prefix "StateOfSouthKorea"
    let StateOfTaiwan = _prefixId.prefix "StateOfTaiwan"
