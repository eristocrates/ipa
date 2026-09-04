#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-caj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/CAGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-caj"

    let _namespaceIri = _prefixId.prefix ""
    let CanadianEntity = _prefixId.prefix "CanadianEntity"
    let CanadianJurisdiction = _prefixId.prefix "CanadianJurisdiction"
    let GovernmentOfAlberta = _prefixId.prefix "GovernmentOfAlberta"
    let GovernmentOfBritishColumbia = _prefixId.prefix "GovernmentOfBritishColumbia"
    let GovernmentOfCanada = _prefixId.prefix "GovernmentOfCanada"
    let GovernmentOfManitoba = _prefixId.prefix "GovernmentOfManitoba"
    let GovernmentOfNewBrunswick = _prefixId.prefix "GovernmentOfNewBrunswick"

    let GovernmentOfNewfoundlandAndLabrador =
        _prefixId.prefix "GovernmentOfNewfoundlandAndLabrador"

    let GovernmentOfNorthwestTerritories =
        _prefixId.prefix "GovernmentOfNorthwestTerritories"

    let GovernmentOfNovaScotia = _prefixId.prefix "GovernmentOfNovaScotia"
    let GovernmentOfNunavut = _prefixId.prefix "GovernmentOfNunavut"
    let GovernmentOfOntario = _prefixId.prefix "GovernmentOfOntario"

    let GovernmentOfPrinceEdwardIsland =
        _prefixId.prefix "GovernmentOfPrinceEdwardIsland"

    let GovernmentOfQuebec = _prefixId.prefix "GovernmentOfQuebec"
    let GovernmentOfSaskatchewan = _prefixId.prefix "GovernmentOfSaskatchewan"
    let GovernmentOfYukon = _prefixId.prefix "GovernmentOfYukon"
    let NorthwestTerritoriesEntity = _prefixId.prefix "NorthwestTerritoriesEntity"

    let NorthwestTerritoriesJurisdiction =
        _prefixId.prefix "NorthwestTerritoriesJurisdiction"

    let NunavutEntity = _prefixId.prefix "NunavutEntity"
    let NunavutJurisdiction = _prefixId.prefix "NunavutJurisdiction"
    let ProvinceOfAlbertaEntity = _prefixId.prefix "ProvinceOfAlbertaEntity"
    let ProvinceOfAlbertaJurisdiction = _prefixId.prefix "ProvinceOfAlbertaJurisdiction"

    let ProvinceOfBritishColumbiaEntity =
        _prefixId.prefix "ProvinceOfBritishColumbiaEntity"

    let ProvinceOfBritishColumbiaJurisdiction =
        _prefixId.prefix "ProvinceOfBritishColumbiaJurisdiction"

    let ProvinceOfManitobaEntity = _prefixId.prefix "ProvinceOfManitobaEntity"

    let ProvinceOfManitobaJurisdiction =
        _prefixId.prefix "ProvinceOfManitobaJurisdiction"

    let ProvinceOfNewBrunswickEntity = _prefixId.prefix "ProvinceOfNewBrunswickEntity"

    let ProvinceOfNewBrunswickJurisdiction =
        _prefixId.prefix "ProvinceOfNewBrunswickJurisdiction"

    let ProvinceOfNewfoundlandAndLabradorEntity =
        _prefixId.prefix "ProvinceOfNewfoundlandAndLabradorEntity"

    let ProvinceOfNewfoundlandAndLabradorJurisdiction =
        _prefixId.prefix "ProvinceOfNewfoundlandAndLabradorJurisdiction"

    let ProvinceOfNovaScotiaEntity = _prefixId.prefix "ProvinceOfNovaScotiaEntity"

    let ProvinceOfNovaScotiaJurisdiction =
        _prefixId.prefix "ProvinceOfNovaScotiaJurisdiction"

    let ProvinceOfOntarioEntity = _prefixId.prefix "ProvinceOfOntarioEntity"
    let ProvinceOfOntarioJurisdiction = _prefixId.prefix "ProvinceOfOntarioJurisdiction"

    let ProvinceOfPrinceEdwardIslandEntity =
        _prefixId.prefix "ProvinceOfPrinceEdwardIslandEntity"

    let ProvinceOfPrinceEdwardIslandJurisdiction =
        _prefixId.prefix "ProvinceOfPrinceEdwardIslandJurisdiction"

    let ProvinceOfQuebecEntity = _prefixId.prefix "ProvinceOfQuebecEntity"
    let ProvinceOfQuebecJurisdiction = _prefixId.prefix "ProvinceOfQuebecJurisdiction"
    let ProvinceOfSaskatchewanEntity = _prefixId.prefix "ProvinceOfSaskatchewanEntity"

    let ProvinceOfSaskatchewanJurisdiction =
        _prefixId.prefix "ProvinceOfSaskatchewanJurisdiction"

    let YukonEntity = _prefixId.prefix "YukonEntity"
    let YukonJurisdiction = _prefixId.prefix "YukonJurisdiction"
