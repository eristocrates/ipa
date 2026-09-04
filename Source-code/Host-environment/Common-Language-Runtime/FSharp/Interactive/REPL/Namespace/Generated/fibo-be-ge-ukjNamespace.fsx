#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-ukj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/EuropeanJurisdiction/UKGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-ukj"

    let _namespaceIri = _prefixId.prefix ""
    let EnglandAndWalesJurisdiction = _prefixId.prefix "EnglandAndWalesJurisdiction"
    let GovernmentOfGuernsey = _prefixId.prefix "GovernmentOfGuernsey"
    let GovernmentOfJersey = _prefixId.prefix "GovernmentOfJersey"
    let GovernmentOfScotland = _prefixId.prefix "GovernmentOfScotland"
    let GovernmentOfTheIsleOfMan = _prefixId.prefix "GovernmentOfTheIsleOfMan"
    let GovernmentOfTheUnitedKingdom = _prefixId.prefix "GovernmentOfTheUnitedKingdom"
    let GuernseyEntity = _prefixId.prefix "GuernseyEntity"
    let IsleOfManEntity = _prefixId.prefix "IsleOfManEntity"
    let JerseyEntity = _prefixId.prefix "JerseyEntity"
    let JurisdictionOfGuernsey = _prefixId.prefix "JurisdictionOfGuernsey"
    let JurisdictionOfJersey = _prefixId.prefix "JurisdictionOfJersey"
    let JurisdictionOfTheIsleOfMan = _prefixId.prefix "JurisdictionOfTheIsleOfMan"
    let NationalAssemblyForWales = _prefixId.prefix "NationalAssemblyForWales"
    let NorthernIrelandAssembly = _prefixId.prefix "NorthernIrelandAssembly"
    let NorthernIrelandEntity = _prefixId.prefix "NorthernIrelandEntity"
    let NorthernIrelandJurisdiction = _prefixId.prefix "NorthernIrelandJurisdiction"
    let ScotlandEntity = _prefixId.prefix "ScotlandEntity"
    let ScotlandJurisdiction = _prefixId.prefix "ScotlandJurisdiction"
    let UnitedKingdomEntity = _prefixId.prefix "UnitedKingdomEntity"
    let UnitedKingdomJurisdiction = _prefixId.prefix "UnitedKingdomJurisdiction"
    let WelshEntity = _prefixId.prefix "WelshEntity"
