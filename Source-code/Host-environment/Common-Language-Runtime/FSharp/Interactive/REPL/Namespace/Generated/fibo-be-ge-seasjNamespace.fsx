#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-seasj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/SoutheasternAsiaGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-seasj"

    let _namespaceIri = _prefixId.prefix ""
    let GovernmentOfMalaysia = _prefixId.prefix "GovernmentOfMalaysia"

    let GovernmentOfTheDemocraticRepublicOfTimor_Leste =
        _prefixId.prefix "GovernmentOfTheDemocraticRepublicOfTimor-Leste"

    let GovernmentOfTheKingdomOfCambodia =
        _prefixId.prefix "GovernmentOfTheKingdomOfCambodia"

    let GovernmentOfTheLaoPeoplesDemocraticRepublic =
        _prefixId.prefix "GovernmentOfTheLaoPeoplesDemocraticRepublic"

    let GovernmentOfTheNationOfBruneiTheAbodeOfPeace =
        _prefixId.prefix "GovernmentOfTheNationOfBruneiTheAbodeOfPeace"

    let GovernmentOfTheRepublicOfIndonesia =
        _prefixId.prefix "GovernmentOfTheRepublicOfIndonesia"

    let GovernmentOfTheRepublicOfSingapore =
        _prefixId.prefix "GovernmentOfTheRepublicOfSingapore"

    let GovernmentOfTheRepublicOfThePhilippines =
        _prefixId.prefix "GovernmentOfTheRepublicOfThePhilippines"

    let GovernmentOfTheRepublicOfTheUnionOfMyanmar =
        _prefixId.prefix "GovernmentOfTheRepublicOfTheUnionOfMyanmar"

    let GovernmentOfTheSocialistRepublicOfVietNam =
        _prefixId.prefix "GovernmentOfTheSocialistRepublicOfVietNam"

    let JurisdictionOfBrunei = _prefixId.prefix "JurisdictionOfBrunei"
    let JurisdictionOfCambodia = _prefixId.prefix "JurisdictionOfCambodia"
    let JurisdictionOfIndonesia = _prefixId.prefix "JurisdictionOfIndonesia"
    let JurisdictionOfMalaysia = _prefixId.prefix "JurisdictionOfMalaysia"

    let JurisdictionOfTheDemocraticRepublicOfTimor_Leste =
        _prefixId.prefix "JurisdictionOfTheDemocraticRepublicOfTimor-Leste"

    let JurisdictionOfTheLaoPeoplesDemocraticRepublic =
        _prefixId.prefix "JurisdictionOfTheLaoPeoplesDemocraticRepublic"

    let JurisdictionOfTheRepublicOfSingapore =
        _prefixId.prefix "JurisdictionOfTheRepublicOfSingapore"

    let JurisdictionOfTheRepublicOfThePhilippines =
        _prefixId.prefix "JurisdictionOfTheRepublicOfThePhilippines"

    let JurisdictionOfTheRepublicOfTheUnionOfMyanmar =
        _prefixId.prefix "JurisdictionOfTheRepublicOfTheUnionOfMyanmar"

    let JurisdictionOfTheRoyalThaiGovernment =
        _prefixId.prefix "JurisdictionOfTheRoyalThaiGovernment"

    let JurisdictionOfTheSocialistRepublicOfVietNam =
        _prefixId.prefix "JurisdictionOfTheSocialistRepublicOfVietNam"

    let RoyalThaiGovernment = _prefixId.prefix "RoyalThaiGovernment"
    let StateOfBrunei = _prefixId.prefix "StateOfBrunei"
    let StateOfCambodia = _prefixId.prefix "StateOfCambodia"
    let StateOfIndonesia = _prefixId.prefix "StateOfIndonesia"
    let StateOfLaos = _prefixId.prefix "StateOfLaos"
    let StateOfMalaysia = _prefixId.prefix "StateOfMalaysia"
    let StateOfMyanmar = _prefixId.prefix "StateOfMyanmar"
    let StateOfSingapore = _prefixId.prefix "StateOfSingapore"
    let StateOfThailand = _prefixId.prefix "StateOfThailand"
    let StateOfThePhilippines = _prefixId.prefix "StateOfThePhilippines"
    let StateOfTimor_Leste = _prefixId.prefix "StateOfTimor-Leste"
    let StateOfVietNam = _prefixId.prefix "StateOfVietNam"
