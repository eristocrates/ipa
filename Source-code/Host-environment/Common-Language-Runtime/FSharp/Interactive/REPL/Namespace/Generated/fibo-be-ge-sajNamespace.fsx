#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-saj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/LatinAmericanJurisdiction/SouthAmericanGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-saj"

    let _namespaceIri = _prefixId.prefix ""
    let ArgentinianEntity = _prefixId.prefix "ArgentinianEntity"
    let BolivianEntity = _prefixId.prefix "BolivianEntity"
    let BrazilianEntity = _prefixId.prefix "BrazilianEntity"
    let ChileanEntity = _prefixId.prefix "ChileanEntity"
    let ColombianEntity = _prefixId.prefix "ColombianEntity"
    let EcuadorianEntity = _prefixId.prefix "EcuadorianEntity"

    let GovernmentOfTheArgentineRepublic =
        _prefixId.prefix "GovernmentOfTheArgentineRepublic"

    let GovernmentOfTheBolivarianRepublicOfVenezuela =
        _prefixId.prefix "GovernmentOfTheBolivarianRepublicOfVenezuela"

    let GovernmentOfTheCo_operativeRepublicOfGuyana =
        _prefixId.prefix "GovernmentOfTheCo-operativeRepublicOfGuyana"

    let GovernmentOfTheFederativeRepublicOfBrazil =
        _prefixId.prefix "GovernmentOfTheFederativeRepublicOfBrazil"

    let GovernmentOfTheOrientalRepublicOfUruguay =
        _prefixId.prefix "GovernmentOfTheOrientalRepublicOfUruguay"

    let GovernmentOfThePlurinationalStateOfBolivia =
        _prefixId.prefix "GovernmentOfThePlurinationalStateOfBolivia"

    let GovernmentOfTheRepublicOfChile =
        _prefixId.prefix "GovernmentOfTheRepublicOfChile"

    let GovernmentOfTheRepublicOfColombia =
        _prefixId.prefix "GovernmentOfTheRepublicOfColombia"

    let GovernmentOfTheRepublicOfEcuador =
        _prefixId.prefix "GovernmentOfTheRepublicOfEcuador"

    let GovernmentOfTheRepublicOfParaguay =
        _prefixId.prefix "GovernmentOfTheRepublicOfParaguay"

    let GovernmentOfTheRepublicOfPeru = _prefixId.prefix "GovernmentOfTheRepublicOfPeru"

    let GovernmentOfTheRepublicOfSuriname =
        _prefixId.prefix "GovernmentOfTheRepublicOfSuriname"

    let GuyaneseEntity = _prefixId.prefix "GuyaneseEntity"
    let JurisdictionOfArgentina = _prefixId.prefix "JurisdictionOfArgentina"
    let JurisdictionOfBolivia = _prefixId.prefix "JurisdictionOfBolivia"
    let JurisdictionOfBrazil = _prefixId.prefix "JurisdictionOfBrazil"
    let JurisdictionOfChile = _prefixId.prefix "JurisdictionOfChile"
    let JurisdictionOfColombia = _prefixId.prefix "JurisdictionOfColombia"
    let JurisdictionOfEcuador = _prefixId.prefix "JurisdictionOfEcuador"
    let JurisdictionOfGuyana = _prefixId.prefix "JurisdictionOfGuyana"
    let JurisdictionOfParaguay = _prefixId.prefix "JurisdictionOfParaguay"
    let JurisdictionOfPeru = _prefixId.prefix "JurisdictionOfPeru"
    let JurisdictionOfSuriname = _prefixId.prefix "JurisdictionOfSuriname"
    let JurisdictionOfUruguay = _prefixId.prefix "JurisdictionOfUruguay"
    let JurisdictionOfVenezuela = _prefixId.prefix "JurisdictionOfVenezuela"
    let ParaguayanEntity = _prefixId.prefix "ParaguayanEntity"
    let PeruvianEntity = _prefixId.prefix "PeruvianEntity"
    let SurinameseEntity = _prefixId.prefix "SurinameseEntity"
    let UruguayanEntity = _prefixId.prefix "UruguayanEntity"
    let VenezuelanEntity = _prefixId.prefix "VenezuelanEntity"
