#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-wasj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/AsianJurisdiction/WesternAsiaGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-wasj"

    let _namespaceIri = _prefixId.prefix ""
    let GovernmentOfGeorgia = _prefixId.prefix "GovernmentOfGeorgia"

    let GovernmentOfTheHashemiteKingdomOfJordan =
        _prefixId.prefix "GovernmentOfTheHashemiteKingdomOfJordan"

    let GovernmentOfTheKingdomOfBahrain =
        _prefixId.prefix "GovernmentOfTheKingdomOfBahrain"

    let GovernmentOfTheKingdomOfSaudiArabia =
        _prefixId.prefix "GovernmentOfTheKingdomOfSaudiArabia"

    let GovernmentOfTheLebaneseRepublic =
        _prefixId.prefix "GovernmentOfTheLebaneseRepublic"

    let GovernmentOfTheRepublicOfArmenia =
        _prefixId.prefix "GovernmentOfTheRepublicOfArmenia"

    let GovernmentOfTheRepublicOfAzerbaijan =
        _prefixId.prefix "GovernmentOfTheRepublicOfAzerbaijan"

    let GovernmentOfTheRepublicOfCyprus =
        _prefixId.prefix "GovernmentOfTheRepublicOfCyprus"

    let GovernmentOfTheRepublicOfIraq = _prefixId.prefix "GovernmentOfTheRepublicOfIraq"

    let GovernmentOfTheRepublicOfTurkey =
        _prefixId.prefix "GovernmentOfTheRepublicOfTurkey"

    let GovernmentOfTheRepublicOfYemen =
        _prefixId.prefix "GovernmentOfTheRepublicOfYemen"

    let GovernmentOfTheStateOfIsrael = _prefixId.prefix "GovernmentOfTheStateOfIsrael"
    let GovernmentOfTheStateOfKuwait = _prefixId.prefix "GovernmentOfTheStateOfKuwait"

    let GovernmentOfTheStateOfPalestine =
        _prefixId.prefix "GovernmentOfTheStateOfPalestine"

    let GovernmentOfTheStateOfQatar = _prefixId.prefix "GovernmentOfTheStateOfQatar"

    let GovernmentOfTheSultanateOfOman =
        _prefixId.prefix "GovernmentOfTheSultanateOfOman"

    let GovernmentOfTheSyrianArabRepublic =
        _prefixId.prefix "GovernmentOfTheSyrianArabRepublic"

    let GovernmentOfTheUnitedArabEmirates =
        _prefixId.prefix "GovernmentOfTheUnitedArabEmirates"

    let JurisdictionOfGeorgia = _prefixId.prefix "JurisdictionOfGeorgia"

    let JurisdictionOfTheHashemiteKingdomOfJordan =
        _prefixId.prefix "JurisdictionOfTheHashemiteKingdomOfJordan"

    let JurisdictionOfTheKingdomOfBahrain =
        _prefixId.prefix "JurisdictionOfTheKingdomOfBahrain"

    let JurisdictionOfTheKingdomOfSaudiArabia =
        _prefixId.prefix "JurisdictionOfTheKingdomOfSaudiArabia"

    let JurisdictionOfTheLebaneseRepublic =
        _prefixId.prefix "JurisdictionOfTheLebaneseRepublic"

    let JurisdictionOfTheRepublicOfArmenia =
        _prefixId.prefix "JurisdictionOfTheRepublicOfArmenia"

    let JurisdictionOfTheRepublicOfAzerbaijan =
        _prefixId.prefix "JurisdictionOfTheRepublicOfAzerbaijan"

    let JurisdictionOfTheRepublicOfCyprus =
        _prefixId.prefix "JurisdictionOfTheRepublicOfCyprus"

    let JurisdictionOfTheRepublicOfIraq =
        _prefixId.prefix "JurisdictionOfTheRepublicOfIraq"

    let JurisdictionOfTheRepublicOfTurkey =
        _prefixId.prefix "JurisdictionOfTheRepublicOfTurkey"

    let JurisdictionOfTheRepublicOfYemen =
        _prefixId.prefix "JurisdictionOfTheRepublicOfYemen"

    let JurisdictionOfTheStateOfIsrael =
        _prefixId.prefix "JurisdictionOfTheStateOfIsrael"

    let JurisdictionOfTheStateOfKuwait =
        _prefixId.prefix "JurisdictionOfTheStateOfKuwait"

    let JurisdictionOfTheStateOfPalestine =
        _prefixId.prefix "JurisdictionOfTheStateOfPalestine"

    let JurisdictionOfTheStateOfQatar = _prefixId.prefix "JurisdictionOfTheStateOfQatar"

    let JurisdictionOfTheSultanateOfOman =
        _prefixId.prefix "JurisdictionOfTheSultanateOfOman"

    let JurisdictionOfTheSyrianArabRepublic =
        _prefixId.prefix "JurisdictionOfTheSyrianArabRepublic"

    let JurisdictionOfTheUnitedArabEmirates =
        _prefixId.prefix "JurisdictionOfTheUnitedArabEmirates"

    let SovereignStateOfGeorgia = _prefixId.prefix "SovereignStateOfGeorgia"
    let StateOfArmenia = _prefixId.prefix "StateOfArmenia"
    let StateOfAzerbaijan = _prefixId.prefix "StateOfAzerbaijan"
    let StateOfBahrain = _prefixId.prefix "StateOfBahrain"
    let StateOfCyprus = _prefixId.prefix "StateOfCyprus"
    let StateOfIraq = _prefixId.prefix "StateOfIraq"
    let StateOfIsrael = _prefixId.prefix "StateOfIsrael"
    let StateOfJordan = _prefixId.prefix "StateOfJordan"
    let StateOfKuwait = _prefixId.prefix "StateOfKuwait"
    let StateOfLebanon = _prefixId.prefix "StateOfLebanon"
    let StateOfOman = _prefixId.prefix "StateOfOman"
    let StateOfPalestine = _prefixId.prefix "StateOfPalestine"
    let StateOfQatar = _prefixId.prefix "StateOfQatar"
    let StateOfSaudiArabia = _prefixId.prefix "StateOfSaudiArabia"
    let StateOfSyria = _prefixId.prefix "StateOfSyria"
    let StateOfTurkey = _prefixId.prefix "StateOfTurkey"
    let StateOfUnitedArabEmirates = _prefixId.prefix "StateOfUnitedArabEmirates"
    let StateOfYemen = _prefixId.prefix "StateOfYemen"
