#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``fibo-be-ge-usj`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://spec.edmcouncil.org/fibo/ontology/BE/GovernmentEntities/NorthAmericanJurisdiction/USGovernmentEntitiesAndJurisdictions/" "fibo-be-ge-usj"

    let _namespaceIri = _prefixId.prefix ""
    let AmericanSamoaEntity = _prefixId.prefix "AmericanSamoaEntity"
    let AmericanSamoaJurisdiction = _prefixId.prefix "AmericanSamoaJurisdiction"

    let CommonwealthOfPuertoRicoEntity =
        _prefixId.prefix "CommonwealthOfPuertoRicoEntity"

    let CommonwealthOfTheNorthernMarianaIslandsEntity =
        _prefixId.prefix "CommonwealthOfTheNorthernMarianaIslandsEntity"

    let DistrictOfColumbiaEntity = _prefixId.prefix "DistrictOfColumbiaEntity"
    let DistrictOfColumbiaGovernment = _prefixId.prefix "DistrictOfColumbiaGovernment"

    let DistrictOfColumbiaJurisdiction =
        _prefixId.prefix "DistrictOfColumbiaJurisdiction"

    let GovernmentOfAmericanSamoa = _prefixId.prefix "GovernmentOfAmericanSamoa"
    let GovernmentOfGuam = _prefixId.prefix "GovernmentOfGuam"

    let GovernmentOfNorthernMarianaIslands =
        _prefixId.prefix "GovernmentOfNorthernMarianaIslands"

    let GovernmentOfPuertoRico = _prefixId.prefix "GovernmentOfPuertoRico"
    let GovernmentOfVirginIslands = _prefixId.prefix "GovernmentOfVirginIslands"
    let GuamEntity = _prefixId.prefix "GuamEntity"
    let GuamJurisdiction = _prefixId.prefix "GuamJurisdiction"

    let NorthernMarianaIslandsJurisdiction =
        _prefixId.prefix "NorthernMarianaIslandsJurisdiction"

    let PuertoRicoJurisdiction = _prefixId.prefix "PuertoRicoJurisdiction"
    let StateOfAlabamaEntity = _prefixId.prefix "StateOfAlabamaEntity"
    let StateOfAlabamaGovernment = _prefixId.prefix "StateOfAlabamaGovernment"
    let StateOfAlabamaJurisdiction = _prefixId.prefix "StateOfAlabamaJurisdiction"
    let StateOfAlaskaEntity = _prefixId.prefix "StateOfAlaskaEntity"
    let StateOfAlaskaGovernment = _prefixId.prefix "StateOfAlaskaGovernment"
    let StateOfAlaskaJurisdiction = _prefixId.prefix "StateOfAlaskaJurisdiction"
    let StateOfArizonaEntity = _prefixId.prefix "StateOfArizonaEntity"
    let StateOfArizonaGovernment = _prefixId.prefix "StateOfArizonaGovernment"
    let StateOfArizonaJurisdiction = _prefixId.prefix "StateOfArizonaJurisdiction"
    let StateOfArkansasEntity = _prefixId.prefix "StateOfArkansasEntity"
    let StateOfArkansasGovernment = _prefixId.prefix "StateOfArkansasGovernment"
    let StateOfArkansasJurisdiction = _prefixId.prefix "StateOfArkansasJurisdiction"
    let StateOfCaliforniaEntity = _prefixId.prefix "StateOfCaliforniaEntity"
    let StateOfCaliforniaGovernment = _prefixId.prefix "StateOfCaliforniaGovernment"
    let StateOfCaliforniaJurisdiction = _prefixId.prefix "StateOfCaliforniaJurisdiction"
    let StateOfColoradoEntity = _prefixId.prefix "StateOfColoradoEntity"
    let StateOfColoradoGovernment = _prefixId.prefix "StateOfColoradoGovernment"
    let StateOfColoradoJurisdiction = _prefixId.prefix "StateOfColoradoJurisdiction"
    let StateOfConnecticutEntity = _prefixId.prefix "StateOfConnecticutEntity"
    let StateOfConnecticutGovernment = _prefixId.prefix "StateOfConnecticutGovernment"

    let StateOfConnecticutJurisdiction =
        _prefixId.prefix "StateOfConnecticutJurisdiction"

    let StateOfDelawareEntity = _prefixId.prefix "StateOfDelawareEntity"
    let StateOfDelawareGovernment = _prefixId.prefix "StateOfDelawareGovernment"
    let StateOfDelawareJurisdiction = _prefixId.prefix "StateOfDelawareJurisdiction"
    let StateOfFloridaEntity = _prefixId.prefix "StateOfFloridaEntity"
    let StateOfFloridaGovernment = _prefixId.prefix "StateOfFloridaGovernment"
    let StateOfFloridaJurisdiction = _prefixId.prefix "StateOfFloridaJurisdiction"
    let StateOfGeorgiaEntity = _prefixId.prefix "StateOfGeorgiaEntity"
    let StateOfGeorgiaGovernment = _prefixId.prefix "StateOfGeorgiaGovernment"
    let StateOfGeorgiaJurisdiction = _prefixId.prefix "StateOfGeorgiaJurisdiction"
    let StateOfHawaiiEntity = _prefixId.prefix "StateOfHawaiiEntity"
    let StateOfHawaiiGovernment = _prefixId.prefix "StateOfHawaiiGovernment"
    let StateOfHawaiiJurisdiction = _prefixId.prefix "StateOfHawaiiJurisdiction"
    let StateOfIdahoEntity = _prefixId.prefix "StateOfIdahoEntity"
    let StateOfIdahoGovernment = _prefixId.prefix "StateOfIdahoGovernment"
    let StateOfIdahoJurisdiction = _prefixId.prefix "StateOfIdahoJurisdiction"
    let StateOfIllinoisEntity = _prefixId.prefix "StateOfIllinoisEntity"
    let StateOfIllinoisGovernment = _prefixId.prefix "StateOfIllinoisGovernment"
    let StateOfIllinoisJurisdiction = _prefixId.prefix "StateOfIllinoisJurisdiction"
    let StateOfIndianaEntity = _prefixId.prefix "StateOfIndianaEntity"
    let StateOfIndianaGovernment = _prefixId.prefix "StateOfIndianaGovernment"
    let StateOfIndianaJurisdiction = _prefixId.prefix "StateOfIndianaJurisdiction"
    let StateOfIowaEntity = _prefixId.prefix "StateOfIowaEntity"
    let StateOfIowaGovernment = _prefixId.prefix "StateOfIowaGovernment"
    let StateOfIowaJurisdiction = _prefixId.prefix "StateOfIowaJurisdiction"
    let StateOfKansasEntity = _prefixId.prefix "StateOfKansasEntity"
    let StateOfKansasGovernment = _prefixId.prefix "StateOfKansasGovernment"
    let StateOfKansasJurisdiction = _prefixId.prefix "StateOfKansasJurisdiction"
    let StateOfKentuckyEntity = _prefixId.prefix "StateOfKentuckyEntity"
    let StateOfKentuckyGovernment = _prefixId.prefix "StateOfKentuckyGovernment"
    let StateOfKentuckyJurisdiction = _prefixId.prefix "StateOfKentuckyJurisdiction"
    let StateOfLouisianaEntity = _prefixId.prefix "StateOfLouisianaEntity"
    let StateOfLouisianaGovernment = _prefixId.prefix "StateOfLouisianaGovernment"
    let StateOfLouisianaJurisdiction = _prefixId.prefix "StateOfLouisianaJurisdiction"
    let StateOfMaineEntity = _prefixId.prefix "StateOfMaineEntity"
    let StateOfMaineGovernment = _prefixId.prefix "StateOfMaineGovernment"
    let StateOfMaineJurisdiction = _prefixId.prefix "StateOfMaineJurisdiction"
    let StateOfMarylandEntity = _prefixId.prefix "StateOfMarylandEntity"
    let StateOfMarylandGovernment = _prefixId.prefix "StateOfMarylandGovernment"
    let StateOfMarylandJurisdiction = _prefixId.prefix "StateOfMarylandJurisdiction"
    let StateOfMassachusettsEntity = _prefixId.prefix "StateOfMassachusettsEntity"

    let StateOfMassachusettsGovernment =
        _prefixId.prefix "StateOfMassachusettsGovernment"

    let StateOfMassachusettsJurisdiction =
        _prefixId.prefix "StateOfMassachusettsJurisdiction"

    let StateOfMichiganEntity = _prefixId.prefix "StateOfMichiganEntity"
    let StateOfMichiganGovernment = _prefixId.prefix "StateOfMichiganGovernment"
    let StateOfMichiganJurisdiction = _prefixId.prefix "StateOfMichiganJurisdiction"
    let StateOfMinnesotaEntity = _prefixId.prefix "StateOfMinnesotaEntity"
    let StateOfMinnesotaGovernment = _prefixId.prefix "StateOfMinnesotaGovernment"
    let StateOfMinnesotaJurisdiction = _prefixId.prefix "StateOfMinnesotaJurisdiction"
    let StateOfMississippiEntity = _prefixId.prefix "StateOfMississippiEntity"
    let StateOfMississippiGovernment = _prefixId.prefix "StateOfMississippiGovernment"

    let StateOfMississippiJurisdiction =
        _prefixId.prefix "StateOfMississippiJurisdiction"

    let StateOfMissouriEntity = _prefixId.prefix "StateOfMissouriEntity"
    let StateOfMissouriGovernment = _prefixId.prefix "StateOfMissouriGovernment"
    let StateOfMissouriJurisdiction = _prefixId.prefix "StateOfMissouriJurisdiction"
    let StateOfMontanaEntity = _prefixId.prefix "StateOfMontanaEntity"
    let StateOfMontanaGovernment = _prefixId.prefix "StateOfMontanaGovernment"
    let StateOfMontanaJurisdiction = _prefixId.prefix "StateOfMontanaJurisdiction"
    let StateOfNebraskaEntity = _prefixId.prefix "StateOfNebraskaEntity"
    let StateOfNebraskaGovernment = _prefixId.prefix "StateOfNebraskaGovernment"
    let StateOfNebraskaJurisdiction = _prefixId.prefix "StateOfNebraskaJurisdiction"
    let StateOfNevadaEntity = _prefixId.prefix "StateOfNevadaEntity"
    let StateOfNevadaGovernment = _prefixId.prefix "StateOfNevadaGovernment"
    let StateOfNevadaJurisdiction = _prefixId.prefix "StateOfNevadaJurisdiction"
    let StateOfNewHampshireEntity = _prefixId.prefix "StateOfNewHampshireEntity"
    let StateOfNewHampshireGovernment = _prefixId.prefix "StateOfNewHampshireGovernment"

    let StateOfNewHampshireJurisdiction =
        _prefixId.prefix "StateOfNewHampshireJurisdiction"

    let StateOfNewJerseyEntity = _prefixId.prefix "StateOfNewJerseyEntity"
    let StateOfNewJerseyGovernment = _prefixId.prefix "StateOfNewJerseyGovernment"
    let StateOfNewJerseyJurisdiction = _prefixId.prefix "StateOfNewJerseyJurisdiction"
    let StateOfNewMexicoEntity = _prefixId.prefix "StateOfNewMexicoEntity"
    let StateOfNewMexicoGovernment = _prefixId.prefix "StateOfNewMexicoGovernment"
    let StateOfNewMexicoJurisdiction = _prefixId.prefix "StateOfNewMexicoJurisdiction"
    let StateOfNewYorkEntity = _prefixId.prefix "StateOfNewYorkEntity"
    let StateOfNewYorkGovernment = _prefixId.prefix "StateOfNewYorkGovernment"
    let StateOfNewYorkJurisdiction = _prefixId.prefix "StateOfNewYorkJurisdiction"
    let StateOfNorthCarolinaEntity = _prefixId.prefix "StateOfNorthCarolinaEntity"

    let StateOfNorthCarolinaGovernment =
        _prefixId.prefix "StateOfNorthCarolinaGovernment"

    let StateOfNorthCarolinaJurisdiction =
        _prefixId.prefix "StateOfNorthCarolinaJurisdiction"

    let StateOfNorthDakotaEntity = _prefixId.prefix "StateOfNorthDakotaEntity"
    let StateOfNorthDakotaGovernment = _prefixId.prefix "StateOfNorthDakotaGovernment"

    let StateOfNorthDakotaJurisdiction =
        _prefixId.prefix "StateOfNorthDakotaJurisdiction"

    let StateOfOhioEntity = _prefixId.prefix "StateOfOhioEntity"
    let StateOfOhioGovernment = _prefixId.prefix "StateOfOhioGovernment"
    let StateOfOhioJurisdiction = _prefixId.prefix "StateOfOhioJurisdiction"
    let StateOfOklahomaEntity = _prefixId.prefix "StateOfOklahomaEntity"
    let StateOfOklahomaGovernment = _prefixId.prefix "StateOfOklahomaGovernment"
    let StateOfOklahomaJurisdiction = _prefixId.prefix "StateOfOklahomaJurisdiction"
    let StateOfOregonEntity = _prefixId.prefix "StateOfOregonEntity"
    let StateOfOregonGovernment = _prefixId.prefix "StateOfOregonGovernment"
    let StateOfOregonJurisdiction = _prefixId.prefix "StateOfOregonJurisdiction"
    let StateOfPennsylvaniaEntity = _prefixId.prefix "StateOfPennsylvaniaEntity"
    let StateOfPennsylvaniaGovernment = _prefixId.prefix "StateOfPennsylvaniaGovernment"

    let StateOfPennsylvaniaJurisdiction =
        _prefixId.prefix "StateOfPennsylvaniaJurisdiction"

    let StateOfRhodeIslandEntity = _prefixId.prefix "StateOfRhodeIslandEntity"
    let StateOfRhodeIslandGovernment = _prefixId.prefix "StateOfRhodeIslandGovernment"

    let StateOfRhodeIslandJurisdiction =
        _prefixId.prefix "StateOfRhodeIslandJurisdiction"

    let StateOfSouthCarolinaEntity = _prefixId.prefix "StateOfSouthCarolinaEntity"

    let StateOfSouthCarolinaGovernment =
        _prefixId.prefix "StateOfSouthCarolinaGovernment"

    let StateOfSouthCarolinaJurisdiction =
        _prefixId.prefix "StateOfSouthCarolinaJurisdiction"

    let StateOfSouthDakotaEntity = _prefixId.prefix "StateOfSouthDakotaEntity"
    let StateOfSouthDakotaGovernment = _prefixId.prefix "StateOfSouthDakotaGovernment"

    let StateOfSouthDakotaJurisdiction =
        _prefixId.prefix "StateOfSouthDakotaJurisdiction"

    let StateOfTennesseeEntity = _prefixId.prefix "StateOfTennesseeEntity"
    let StateOfTennesseeGovernment = _prefixId.prefix "StateOfTennesseeGovernment"
    let StateOfTennesseeJurisdiction = _prefixId.prefix "StateOfTennesseeJurisdiction"
    let StateOfTexasEntity = _prefixId.prefix "StateOfTexasEntity"
    let StateOfTexasGovernment = _prefixId.prefix "StateOfTexasGovernment"
    let StateOfTexasJurisdiction = _prefixId.prefix "StateOfTexasJurisdiction"
    let StateOfUtahEntity = _prefixId.prefix "StateOfUtahEntity"
    let StateOfUtahGovernment = _prefixId.prefix "StateOfUtahGovernment"
    let StateOfUtahJurisdiction = _prefixId.prefix "StateOfUtahJurisdiction"
    let StateOfVermontEntity = _prefixId.prefix "StateOfVermontEntity"
    let StateOfVermontGovernment = _prefixId.prefix "StateOfVermontGovernment"
    let StateOfVermontJurisdiction = _prefixId.prefix "StateOfVermontJurisdiction"
    let StateOfVirginiaEntity = _prefixId.prefix "StateOfVirginiaEntity"
    let StateOfVirginiaGovernment = _prefixId.prefix "StateOfVirginiaGovernment"
    let StateOfVirginiaJurisdiction = _prefixId.prefix "StateOfVirginiaJurisdiction"
    let StateOfWashingtonEntity = _prefixId.prefix "StateOfWashingtonEntity"
    let StateOfWashingtonGovernment = _prefixId.prefix "StateOfWashingtonGovernment"
    let StateOfWashingtonJurisdiction = _prefixId.prefix "StateOfWashingtonJurisdiction"
    let StateOfWestVirginiaEntity = _prefixId.prefix "StateOfWestVirginiaEntity"
    let StateOfWestVirginiaGovernment = _prefixId.prefix "StateOfWestVirginiaGovernment"

    let StateOfWestVirginiaJurisdiction =
        _prefixId.prefix "StateOfWestVirginiaJurisdiction"

    let StateOfWisconsinEntity = _prefixId.prefix "StateOfWisconsinEntity"
    let StateOfWisconsinGovernment = _prefixId.prefix "StateOfWisconsinGovernment"
    let StateOfWisconsinJurisdiction = _prefixId.prefix "StateOfWisconsinJurisdiction"
    let StateOfWyomingEntity = _prefixId.prefix "StateOfWyomingEntity"
    let StateOfWyomingGovernment = _prefixId.prefix "StateOfWyomingGovernment"
    let StateOfWyomingJurisdiction = _prefixId.prefix "StateOfWyomingJurisdiction"
    let UnitedStatesEntity = _prefixId.prefix "UnitedStatesEntity"
    let UnitedStatesGovernment = _prefixId.prefix "UnitedStatesGovernment"
    let UnitedStatesJurisdiction = _prefixId.prefix "UnitedStatesJurisdiction"
    let VirginIslandsEntity = _prefixId.prefix "VirginIslandsEntity"
    let VirginIslandsJurisdiction = _prefixId.prefix "VirginIslandsJurisdiction"
