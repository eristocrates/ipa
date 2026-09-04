#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-seuj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/SouthernEuropeGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-seuj"

    let _namespaceIri = _prefixId.prefix ""
    let AlbanianEntity = _prefixId.prefix "AlbanianEntity"
    let AndorranEntity = _prefixId.prefix "AndorranEntity"
    let BosnianAndHerzegovinianEntity = _prefixId.prefix "BosnianAndHerzegovinianEntity"
    let CroatianEntity = _prefixId.prefix "CroatianEntity"
    let GovernmentOfMontenegro = _prefixId.prefix "GovernmentOfMontenegro"

    let GovernmentOfTheFederationOfBosniaAndHerzegovina =
        _prefixId.prefix "GovernmentOfTheFederationOfBosniaAndHerzegovina"

    let GovernmentOfTheHellenicRepublic =
        _prefixId.prefix "GovernmentOfTheHellenicRepublic"

    let GovernmentOfTheHolySee = _prefixId.prefix "GovernmentOfTheHolySee"
    let GovernmentOfTheKingdomOfSpain = _prefixId.prefix "GovernmentOfTheKingdomOfSpain"

    let GovernmentOfThePortugueseRepublic =
        _prefixId.prefix "GovernmentOfThePortugueseRepublic"

    let GovernmentOfThePrincipalityOfAndorra =
        _prefixId.prefix "GovernmentOfThePrincipalityOfAndorra"

    let GovernmentOfTheRepublicOfAlbania =
        _prefixId.prefix "GovernmentOfTheRepublicOfAlbania"

    let GovernmentOfTheRepublicOfCroatia =
        _prefixId.prefix "GovernmentOfTheRepublicOfCroatia"

    let GovernmentOfTheRepublicOfItaly =
        _prefixId.prefix "GovernmentOfTheRepublicOfItaly"

    let GovernmentOfTheRepublicOfMalta =
        _prefixId.prefix "GovernmentOfTheRepublicOfMalta"

    let GovernmentOfTheRepublicOfNorthMacedonia =
        _prefixId.prefix "GovernmentOfTheRepublicOfNorthMacedonia"

    let GovernmentOfTheRepublicOfSanMarino =
        _prefixId.prefix "GovernmentOfTheRepublicOfSanMarino"

    let GovernmentOfTheRepublicOfSerbia =
        _prefixId.prefix "GovernmentOfTheRepublicOfSerbia"

    let GovernmentOfTheRepublicOfSlovenia =
        _prefixId.prefix "GovernmentOfTheRepublicOfSlovenia"

    let GreekEntity = _prefixId.prefix "GreekEntity"
    let HolySeeEntity = _prefixId.prefix "HolySeeEntity"
    let ItalianEntity = _prefixId.prefix "ItalianEntity"
    let JurisdictionOfAlbania = _prefixId.prefix "JurisdictionOfAlbania"
    let JurisdictionOfAndorra = _prefixId.prefix "JurisdictionOfAndorra"

    let JurisdictionOfBosniaAndHerzegovina =
        _prefixId.prefix "JurisdictionOfBosniaAndHerzegovina"

    let JurisdictionOfCroatia = _prefixId.prefix "JurisdictionOfCroatia"
    let JurisdictionOfGreece = _prefixId.prefix "JurisdictionOfGreece"
    let JurisdictionOfItaly = _prefixId.prefix "JurisdictionOfItaly"
    let JurisdictionOfMalta = _prefixId.prefix "JurisdictionOfMalta"
    let JurisdictionOfMontenegro = _prefixId.prefix "JurisdictionOfMontenegro"
    let JurisdictionOfNorthMacedonia = _prefixId.prefix "JurisdictionOfNorthMacedonia"
    let JurisdictionOfPortugal = _prefixId.prefix "JurisdictionOfPortugal"
    let JurisdictionOfSanMarino = _prefixId.prefix "JurisdictionOfSanMarino"
    let JurisdictionOfSerbia = _prefixId.prefix "JurisdictionOfSerbia"
    let JurisdictionOfSlovenia = _prefixId.prefix "JurisdictionOfSlovenia"
    let JurisdictionOfSpain = _prefixId.prefix "JurisdictionOfSpain"
    let JurisdictionOfTheHolySee = _prefixId.prefix "JurisdictionOfTheHolySee"
    let MalteseEntity = _prefixId.prefix "MalteseEntity"
    let MontenegrinEntity = _prefixId.prefix "MontenegrinEntity"
    let NorthMacedonianEntity = _prefixId.prefix "NorthMacedonianEntity"
    let PortugueseEntity = _prefixId.prefix "PortugueseEntity"
    let SammarineseEntity = _prefixId.prefix "SammarineseEntity"
    let SerbianEntity = _prefixId.prefix "SerbianEntity"
    let SloveneEntity = _prefixId.prefix "SloveneEntity"
    let SpanishEntity = _prefixId.prefix "SpanishEntity"
