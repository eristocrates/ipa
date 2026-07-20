namespace http.rdf.muninn_project.org.ontologies.military.hash

open DoxAletheia

module mil =
    let _namespace_name = "http://rdf.muninn-project.org/ontologies/military#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This object is void dataset container for covinience.
    /// <see href="http://rdf.muninn-project.org/ontologies/military#datasetdefinition"></see></summary>
    let datasetdefinition = _prefix "datasetdefinition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndCorporal"></see>
    /// </summary>
    let _1AIFRank2ndCorporal = _prefix "1AIFRank2ndCorporal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#rankOf"></see>
    /// </summary>
    let rankOf = _prefix "rankOf"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Infantry"></see>
    /// </summary>
    let Infantry = _prefix "Infantry"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryAppointment"></see>
    /// </summary>
    let MilitaryAppointment = _prefix "MilitaryAppointment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Soldier"></see>
    /// </summary>
    let Soldier = _prefix "Soldier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryRank"></see>
    /// </summary>
    let MilitaryRank = _prefix "MilitaryRank"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Corporal_EnglishTradition"></see>
    /// </summary>
    let Rank_Corporal_EnglishTradition = _prefix "Rank_Corporal_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndLieutenant"></see>
    /// </summary>
    let _1AIFRank2ndLieutenant = _prefix "1AIFRank2ndLieutenant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_EnglishTradition"></see>
    /// </summary>
    let Rank_Lieutenant_EnglishTradition = _prefix "Rank_Lieutenant_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenant"></see>
    /// </summary>
    let _1AIFRankLieutenant = _prefix "1AIFRankLieutenant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAbleSeaman"></see>
    /// </summary>
    let _1AIFRankAbleSeaman = _prefix "1AIFRankAbleSeaman"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyServiceBranch"></see>
    /// </summary>
    let NavyServiceBranch = _prefix "NavyServiceBranch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrade"></see>
    /// </summary>
    let MilitaryTrade = _prefix "MilitaryTrade"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman"></see>
    /// </summary>
    let RankAbleSeaman = _prefix "RankAbleSeaman"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanic"></see>
    /// </summary>
    let _1AIFRankAirMechanic = _prefix "1AIFRankAirMechanic"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ProtoAirForce"></see>
    /// </summary>
    let ProtoAirForce = _prefix "ProtoAirForce"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassI"></see>
    /// </summary>
    let _1AIFRankAirMechanicClassI = _prefix "1AIFRankAirMechanicClassI"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassII"></see>
    /// </summary>
    let _1AIFRankAirMechanicClassII = _prefix "1AIFRankAirMechanicClassII"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankBombardier"></see>
    /// </summary>
    let _1AIFRankBombardier = _prefix "1AIFRankBombardier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier"></see>
    /// </summary>
    let Rank_Bombardier = _prefix "Rank_Bombardier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCaptain"></see>
    /// </summary>
    let _1AIFRankCaptain = _prefix "1AIFRankCaptain"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_EnglishTradition"></see>
    /// </summary>
    let Rank_Captain_EnglishTradition = _prefix "Rank_Captain_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankChaplain"></see>
    /// </summary>
    let _1AIFRankChaplain = _prefix "1AIFRankChaplain"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Chaplain"></see>
    /// </summary>
    let Chaplain = _prefix "Chaplain"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanyQuartermasterSergeant"></see>
    /// </summary>
    let _1AIFRankCompanyQuartermasterSergeant =
        _prefix "1AIFRankCompanyQuartermasterSergeant"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant =
        _prefix "Rank_Company_Quartermaster_Sergeant"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanySergeantMajor"></see>
    /// </summary>
    let _1AIFRankCompanySergeantMajor = _prefix "1AIFRankCompanySergeantMajor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajor"></see>
    /// </summary>
    let RankCompanySergeantMajor = _prefix "RankCompanySergeantMajor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCorporal"></see>
    /// </summary>
    let _1AIFRankCorporal = _prefix "1AIFRankCorporal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankDriver"></see>
    /// </summary>
    let _1AIFRankDriver = _prefix "1AIFRankDriver"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriver"></see>
    /// </summary>
    let RankDriver = _prefix "RankDriver"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankEngineer"></see>
    /// </summary>
    let _1AIFRankEngineer = _prefix "1AIFRankEngineer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankEngineer"></see>
    /// </summary>
    let RankEngineer = _prefix "RankEngineer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankGunner"></see>
    /// </summary>
    let _1AIFRankGunner = _prefix "1AIFRankGunner"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Artillery"></see>
    /// </summary>
    let Artillery = _prefix "Artillery"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankGunner"></see>
    /// </summary>
    let RankGunner = _prefix "RankGunner"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceCorporal"></see>
    /// </summary>
    let _1AIFRankLanceCorporal = _prefix "1AIFRankLanceCorporal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceSergeant"></see>
    /// </summary>
    let _1AIFRankLanceSergeant = _prefix "1AIFRankLanceSergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_EnglishTradition"></see>
    /// </summary>
    let Rank_Sergeant_EnglishTradition = _prefix "Rank_Sergeant_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLeadingStoker"></see>
    /// </summary>
    let _1AIFRankLeadingStoker = _prefix "1AIFRankLeadingStoker"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLeadingStoker"></see>
    /// </summary>
    let RankLeadingStoker = _prefix "RankLeadingStoker"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenantColonel"></see>
    /// </summary>
    let _1AIFRankLieutenantColonel = _prefix "1AIFRankLieutenantColonel"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmy"></see>
    /// </summary>
    let RankLieutenantColonelArmy = _prefix "RankLieutenantColonelArmy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankMajor"></see>
    /// </summary>
    let _1AIFRankMajor = _prefix "1AIFRankMajor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_EnglishTradition"></see>
    /// </summary>
    let Rank_Major_EnglishTradition = _prefix "Rank_Major_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankNurse"></see>
    /// </summary>
    let _1AIFRankNurse = _prefix "1AIFRankNurse"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankPettyOfficer"></see>
    /// </summary>
    let _1AIFRankPettyOfficer = _prefix "1AIFRankPettyOfficer"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Petty_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Petty_officer_EnglishTradition =
        _prefix "Rank_Petty_officer_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankPrivate"></see>
    /// </summary>
    let _1AIFRankPrivate = _prefix "1AIFRankPrivate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_EnglishTradition"></see>
    /// </summary>
    let Rank_Private_EnglishTradition = _prefix "Rank_Private_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalQuartermasterSergeant"></see>
    /// </summary>
    let _1AIFRankRegimentalQuartermasterSergeant =
        _prefix "1AIFRankRegimentalQuartermasterSergeant"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant =
        _prefix "Rank_Regimental_Quartermaster_Sergeant"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalSergeantMajor"></see>
    /// </summary>
    let _1AIFRankRegimentalSergeantMajor = _prefix "1AIFRankRegimentalSergeantMajor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major = _prefix "Rank_Regimental_sergeant_major"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSapper"></see>
    /// </summary>
    let _1AIFRankSapper = _prefix "1AIFRankSapper"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSapper"></see>
    /// </summary>
    let RankSapper = _prefix "RankSapper"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeant"></see>
    /// </summary>
    let _1AIFRankSergeant = _prefix "1AIFRankSergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeantMajor"></see>
    /// </summary>
    let _1AIFRankSergeantMajor = _prefix "1AIFRankSergeantMajor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSergeant"></see>
    /// </summary>
    let RankSergeant = _prefix "RankSergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSignaller"></see>
    /// </summary>
    let _1AIFRankSignaller = _prefix "1AIFRankSignaller"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSignaller"></see>
    /// </summary>
    let RankSignaller = _prefix "RankSignaller"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankStaffSergeant"></see>
    /// </summary>
    let _1AIFRankStaffSergeant = _prefix "1AIFRankStaffSergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant"></see>
    /// </summary>
    let Rank_Staff_sergeant = _prefix "Rank_Staff_sergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankTrooper"></see>
    /// </summary>
    let _1AIFRankTrooper = _prefix "1AIFRankTrooper"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Cavalry"></see>
    /// </summary>
    let Cavalry = _prefix "Cavalry"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper"></see>
    /// </summary>
    let Rank_Trooper = _prefix "Rank_Trooper"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficer"></see>
    /// </summary>
    let _1AIFRankWarrantOfficer = _prefix "1AIFRankWarrantOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#WarrantOfficer"></see>
    /// </summary>
    let WarrantOfficer = _prefix "WarrantOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficerClass2"></see>
    /// </summary>
    let _1AIFRankWarrantOfficerClass2 = _prefix "1AIFRankWarrantOfficerClass2"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ActingRank"></see>
    /// </summary>
    let ActingRank = _prefix "ActingRank"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirDivision"></see>
    /// </summary>
    let AirDivision = _prefix "AirDivision"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NamedAirForceUnit"></see>
    /// </summary>
    let NamedAirForceUnit = _prefix "NamedAirForceUnit"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceServiceBranch"></see>
    /// </summary>
    let AirForceServiceBranch = _prefix "AirForceServiceBranch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceCommand"></see>
    /// </summary>
    let AirForceCommand = _prefix "AirForceCommand"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#TacticalAirForce"></see>
    /// </summary>
    let TacticalAirForce = _prefix "TacticalAirForce"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceDetail"></see>
    /// </summary>
    let AirForceDetail = _prefix "AirForceDetail"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceGroup"></see>
    /// </summary>
    let AirForceGroup = _prefix "AirForceGroup"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceSquadron"></see>
    /// </summary>
    let AirForceSquadron = _prefix "AirForceSquadron"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmsType"></see>
    /// </summary>
    let ArmsType = _prefix "ArmsType"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryServiceBranch"></see>
    /// </summary>
    let MilitaryServiceBranch = _prefix "MilitaryServiceBranch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyInAir"></see>
    /// </summary>
    let FightsPrimarilyInAir = _prefix "FightsPrimarilyInAir"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Squadron"></see>
    /// </summary>
    let Squadron = _prefix "Squadron"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryFlightUnit"></see>
    /// </summary>
    let MilitaryFlightUnit = _prefix "MilitaryFlightUnit"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceWing"></see>
    /// </summary>
    let AirForceWing = _prefix "AirForceWing"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceStation"></see>
    /// </summary>
    let AirForceStation = _prefix "AirForceStation"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceStationRAF"></see>
    /// </summary>
    let AirForceStationRAF = _prefix "AirForceStationRAF"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Appointment"></see>
    /// </summary>
    let Appointment = _prefix "Appointment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Armor"></see>
    /// </summary>
    let Armor = _prefix "Armor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyCompany"></see>
    /// </summary>
    let ArmyCompany = _prefix "ArmyCompany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#nominalSize"></see>
    /// </summary>
    let nominalSize = _prefix "nominalSize"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Platoon"></see>
    /// </summary>
    let Platoon = _prefix "Platoon"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyServiceBranch"></see>
    /// </summary>
    let ArmyServiceBranch = _prefix "ArmyServiceBranch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Battalion"></see>
    /// </summary>
    let Battalion = _prefix "Battalion"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyFront"></see>
    /// </summary>
    let ArmyFront = _prefix "ArmyFront"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FieldArmy"></see>
    /// </summary>
    let FieldArmy = _prefix "FieldArmy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyGroup"></see>
    /// </summary>
    let ArmyGroup = _prefix "ArmyGroup"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmySection"></see>
    /// </summary>
    let ArmySection = _prefix "ArmySection"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#GroundBasedOrganization"></see>
    /// </summary>
    let GroundBasedOrganization = _prefix "GroundBasedOrganization"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInLand"></see>
    /// </summary>
    let FightsPrimarilyOnAndInLand = _prefix "FightsPrimarilyOnAndInLand"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmySquad"></see>
    /// </summary>
    let ArmySquad = _prefix "ArmySquad"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyTroop"></see>
    /// </summary>
    let ArmyTroop = _prefix "ArmyTroop"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBattery"></see>
    /// </summary>
    let ArtilleryBattery = _prefix "ArtilleryBattery"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBatteryDivision"></see>
    /// </summary>
    let ArtilleryBatteryDivision = _prefix "ArtilleryBatteryDivision"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArtilleryEmplacement"></see>
    /// </summary>
    let ArtilleryEmplacement = _prefix "ArtilleryEmplacement"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AssaultGroupInfantry"></see>
    /// </summary>
    let AssaultGroupInfantry = _prefix "AssaultGroupInfantry"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Brigade"></see>
    /// </summary>
    let Brigade = _prefix "Brigade"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Battle"></see>
    /// </summary>
    let Battle = _prefix "Battle"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryEvent"></see>
    /// </summary>
    let MilitaryEvent = _prefix "MilitaryEvent"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BattleSpace"></see>
    /// </summary>
    let BattleSpace = _prefix "BattleSpace"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BattleStandard"></see>
    /// </summary>
    let BattleStandard = _prefix "BattleStandard"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BrevetRank"></see>
    /// </summary>
    let BrevetRank = _prefix "BrevetRank"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Division"></see>
    /// </summary>
    let Division = _prefix "Division"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BrigadeAirCorps"></see>
    /// </summary>
    let BrigadeAirCorps = _prefix "BrigadeAirCorps"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general"></see>
    /// </summary>
    let Rank_Brigadier_general = _prefix "Rank_Brigadier_general"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Campaign"></see>
    /// </summary>
    let Campaign = _prefix "Campaign"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CarrierBattleGroup"></see>
    /// </summary>
    let CarrierBattleGroup = _prefix "CarrierBattleGroup"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Flotilla"></see>
    /// </summary>
    let Flotilla = _prefix "Flotilla"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalTaskForce"></see>
    /// </summary>
    let NavalTaskForce = _prefix "NavalTaskForce"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CavalrySquadron"></see>
    /// </summary>
    let CavalrySquadron = _prefix "CavalrySquadron"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CavalryTroop"></see>
    /// </summary>
    let CavalryTroop = _prefix "CavalryTroop"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Civilian"></see>
    /// </summary>
    let Civilian = _prefix "Civilian"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Non-Combatant"></see>
    /// </summary>
    let ``Non-Combatant`` = _prefix "Non-Combatant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Combatant"></see>
    /// </summary>
    let Combatant = _prefix "Combatant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Role"></see>
    /// </summary>
    let Role = _prefix "Role"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Corps"></see>
    /// </summary>
    let Corps = _prefix "Corps"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Corps_list"></see>
    /// </summary>
    let Corps_list = _prefix "Corps_list"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CorpsUnit"></see>
    /// </summary>
    let CorpsUnit = _prefix "CorpsUnit"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CorpsFormation"></see>
    /// </summary>
    let CorpsFormation = _prefix "CorpsFormation"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DemiBrigade"></see>
    /// </summary>
    let DemiBrigade = _prefix "DemiBrigade"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#regiment"></see>
    /// </summary>
    let regiment = _prefix "regiment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Depot"></see>
    /// </summary>
    let Depot = _prefix "Depot"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Detachment"></see>
    /// </summary>
    let Detachment = _prefix "Detachment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryOrganization"></see>
    /// </summary>
    let MilitaryOrganization = _prefix "MilitaryOrganization"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalEstablishment"></see>
    /// </summary>
    let DivisionNavalEstablishment = _prefix "DivisionNavalEstablishment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Navy"></see>
    /// </summary>
    let Navy = _prefix "Navy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalSquadron"></see>
    /// </summary>
    let NavalSquadron = _prefix "NavalSquadron"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalUnit"></see>
    /// </summary>
    let DivisionNavalUnit = _prefix "DivisionNavalUnit"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DraftedSoldier"></see>
    /// </summary>
    let DraftedSoldier = _prefix "DraftedSoldier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RegularForceSoldier"></see>
    /// </summary>
    let RegularForceSoldier = _prefix "RegularForceSoldier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#EnglishTradition"></see>
    /// </summary>
    let EnglishTradition = _prefix "EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Enlisted"></see>
    /// </summary>
    let Enlisted = _prefix "Enlisted"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ExchangeOfficer"></see>
    /// </summary>
    let ExchangeOfficer = _prefix "ExchangeOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Officer"></see>
    /// </summary>
    let Officer = _prefix "Officer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FieldArtillery"></see>
    /// </summary>
    let FieldArtillery = _prefix "FieldArtillery"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInWater"></see>
    /// </summary>
    let FightsPrimarilyOnAndInWater = _prefix "FightsPrimarilyOnAndInWater"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Fireteam"></see>
    /// </summary>
    let Fireteam = _prefix "Fireteam"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FlagOfficer"></see>
    /// </summary>
    let FlagOfficer = _prefix "FlagOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalOfficer"></see>
    /// </summary>
    let NavalOfficer = _prefix "NavalOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Frigate"></see>
    /// </summary>
    let Frigate = _prefix "Frigate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Warship"></see>
    /// </summary>
    let Warship = _prefix "Warship"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FrontLine"></see>
    /// </summary>
    let FrontLine = _prefix "FrontLine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#WarTheater"></see>
    /// </summary>
    let WarTheater = _prefix "WarTheater"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Garrison"></see>
    /// </summary>
    let Garrison = _prefix "Garrison"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#GeneralOfficer"></see>
    /// </summary>
    let GeneralOfficer = _prefix "GeneralOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#GrandeBatterie"></see>
    /// </summary>
    let GrandeBatterie = _prefix "GrandeBatterie"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#HorseArtillery"></see>
    /// </summary>
    let HorseArtillery = _prefix "HorseArtillery"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#HouseholdCavalry"></see>
    /// </summary>
    let HouseholdCavalry = _prefix "HouseholdCavalry"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Invasion"></see>
    /// </summary>
    let Invasion = _prefix "Invasion"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#LiaisonOfficer"></see>
    /// </summary>
    let LiaisonOfficer = _prefix "LiaisonOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#LightInfantry"></see>
    /// </summary>
    let LightInfantry = _prefix "LightInfantry"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryAirborneFlight"></see>
    /// </summary>
    let MilitaryAirborneFlight = _prefix "MilitaryAirborneFlight"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryGroundFlight"></see>
    /// </summary>
    let MilitaryGroundFlight = _prefix "MilitaryGroundFlight"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryOperation"></see>
    /// </summary>
    let MilitaryOperation = _prefix "MilitaryOperation"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryRaid"></see>
    /// </summary>
    let MilitaryRaid = _prefix "MilitaryRaid"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrench"></see>
    /// </summary>
    let MilitaryTrench = _prefix "MilitaryTrench"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryUniform"></see>
    /// </summary>
    let MilitaryUniform = _prefix "MilitaryUniform"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MountainArtillery"></see>
    /// </summary>
    let MountainArtillery = _prefix "MountainArtillery"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-1"></see>
    /// </summary>
    let ``NatoRankOF-1`` = _prefix "NatoRankOF-1"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRanks"></see>
    /// </summary>
    let NatoRanks = _prefix "NatoRanks"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-10"></see>
    /// </summary>
    let ``NatoRankOF-10`` = _prefix "NatoRankOF-10"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-2"></see>
    /// </summary>
    let ``NatoRankOF-2`` = _prefix "NatoRankOF-2"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Nato_Ranks"></see>
    /// </summary>
    let Nato_Ranks = _prefix "Nato_Ranks"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-3"></see>
    /// </summary>
    let ``NatoRankOF-3`` = _prefix "NatoRankOF-3"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-4"></see>
    /// </summary>
    let ``NatoRankOF-4`` = _prefix "NatoRankOF-4"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-5"></see>
    /// </summary>
    let ``NatoRankOF-5`` = _prefix "NatoRankOF-5"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-6"></see>
    /// </summary>
    let ``NatoRankOF-6`` = _prefix "NatoRankOF-6"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-7"></see>
    /// </summary>
    let ``NatoRankOF-7`` = _prefix "NatoRankOF-7"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-8"></see>
    /// </summary>
    let ``NatoRankOF-8`` = _prefix "NatoRankOF-8"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-9"></see>
    /// </summary>
    let ``NatoRankOF-9`` = _prefix "NatoRankOF-9"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-1"></see>
    /// </summary>
    let ``NatoRankOR-1`` = _prefix "NatoRankOR-1"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NonCommissionedOfficer"></see>
    /// </summary>
    let NonCommissionedOfficer = _prefix "NonCommissionedOfficer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-2"></see>
    /// </summary>
    let ``NatoRankOR-2`` = _prefix "NatoRankOR-2"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-3"></see>
    /// </summary>
    let ``NatoRankOR-3`` = _prefix "NatoRankOR-3"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-4"></see>
    /// </summary>
    let ``NatoRankOR-4`` = _prefix "NatoRankOR-4"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-5"></see>
    /// </summary>
    let ``NatoRankOR-5`` = _prefix "NatoRankOR-5"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-6"></see>
    /// </summary>
    let ``NatoRankOR-6`` = _prefix "NatoRankOR-6"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-7"></see>
    /// </summary>
    let ``NatoRankOR-7`` = _prefix "NatoRankOR-7"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-8"></see>
    /// </summary>
    let ``NatoRankOR-8`` = _prefix "NatoRankOR-8"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-9"></see>
    /// </summary>
    let ``NatoRankOR-9`` = _prefix "NatoRankOR-9"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-1"></see>
    /// </summary>
    let ``NatoRankWO-1`` = _prefix "NatoRankWO-1"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-2"></see>
    /// </summary>
    let ``NatoRankWO-2`` = _prefix "NatoRankWO-2"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-3"></see>
    /// </summary>
    let ``NatoRankWO-3`` = _prefix "NatoRankWO-3"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-4"></see>
    /// </summary>
    let ``NatoRankWO-4`` = _prefix "NatoRankWO-4"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-5"></see>
    /// </summary>
    let ``NatoRankWO-5`` = _prefix "NatoRankWO-5"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalArtillery"></see>
    /// </summary>
    let NavalArtillery = _prefix "NavalArtillery"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalFleet"></see>
    /// </summary>
    let NavalFleet = _prefix "NavalFleet"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyBigFleet"></see>
    /// </summary>
    let NavyBigFleet = _prefix "NavyBigFleet"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#SeamanMilitary"></see>
    /// </summary>
    let SeamanMilitary = _prefix "SeamanMilitary"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalRating"></see>
    /// </summary>
    let NavalRating = _prefix "NavalRating"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyAirStation"></see>
    /// </summary>
    let NavyAirStation = _prefix "NavyAirStation"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyMerchant"></see>
    /// </summary>
    let NavyMerchant = _prefix "NavyMerchant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#WaterBasedOrganization"></see>
    /// </summary>
    let WaterBasedOrganization = _prefix "WaterBasedOrganization"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#PostToUnit"></see>
    /// </summary>
    let PostToUnit = _prefix "PostToUnit"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#PrivilegedCombatant"></see>
    /// </summary>
    let PrivilegedCombatant = _prefix "PrivilegedCombatant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#UnprivilegedCombatant"></see>
    /// </summary>
    let UnprivilegedCombatant = _prefix "UnprivilegedCombatant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank"></see>
    /// </summary>
    let Rank = _prefix "Rank"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Canada"></see>
    /// </summary>
    let RankAbleSeaman_Canada = _prefix "RankAbleSeaman_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Commonwealth_of_Nations"></see>
    /// </summary>
    let RankAbleSeaman_Commonwealth_of_Nations =
        _prefix "RankAbleSeaman_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBandsmanArmyCanada+"></see>
    /// </summary>
    let ``RankBandsmanArmyCanada+`` = _prefix "RankBandsmanArmyCanada+"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBatterySergeantMajorArmyCanada"></see>
    /// </summary>
    let RankBatterySergeantMajorArmyCanada =
        _prefix "RankBatterySergeantMajorArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBombardierArmyCanada"></see>
    /// </summary>
    let RankBombardierArmyCanada = _prefix "RankBombardierArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBoyArmyCanada"></see>
    /// </summary>
    let RankBoyArmyCanada = _prefix "RankBoyArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBrigadierGeneralArmyCanada"></see>
    /// </summary>
    let RankBrigadierGeneralArmyCanada = _prefix "RankBrigadierGeneralArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCadetArmyCanada"></see>
    /// </summary>
    let RankCadetArmyCanada = _prefix "RankCadetArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainArmyCanada"></see>
    /// </summary>
    let RankCaptainArmyCanada = _prefix "RankCaptainArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval"></see>
    /// </summary>
    let RankCaptainNaval = _prefix "RankCaptainNaval"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Australia"></see>
    /// </summary>
    let RankCaptainNaval_Australia = _prefix "RankCaptainNaval_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Canada"></see>
    /// </summary>
    let RankCaptainNaval_Canada = _prefix "RankCaptainNaval_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankChaplainArmyCanada"></see>
    /// </summary>
    let RankChaplainArmyCanada = _prefix "RankChaplainArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankClerkArmyCanada+"></see>
    /// </summary>
    let ``RankClerkArmyCanada+`` = _prefix "RankClerkArmyCanada+"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankColonelArmyCanada"></see>
    /// </summary>
    let RankColonelArmyCanada = _prefix "RankColonelArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank"></see>
    /// </summary>
    let RankCombatMilitaryRank = _prefix "RankCombatMilitaryRank"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Russia"></see>
    /// </summary>
    let RankCombatMilitaryRank_Russia = _prefix "RankCombatMilitaryRank_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Soviet_Union"></see>
    /// </summary>
    let RankCombatMilitaryRank_Soviet_Union =
        _prefix "RankCombatMilitaryRank_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCommandant"></see>
    /// </summary>
    let RankCommandant = _prefix "RankCommandant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCommandant_France"></see>
    /// </summary>
    let RankCommandant_France = _prefix "RankCommandant_France"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCommandant_Republic_of_Ireland"></see>
    /// </summary>
    let RankCommandant_Republic_of_Ireland =
        _prefix "RankCommandant_Republic_of_Ireland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCompanyQuarterMasterSergeantArmyCanada+"></see>
    /// </summary>
    let ``RankCompanyQuarterMasterSergeantArmyCanada+`` =
        _prefix "RankCompanyQuarterMasterSergeantArmyCanada+"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajorArmyCanada"></see>
    /// </summary>
    let RankCompanySergeantMajorArmyCanada =
        _prefix "RankCompanySergeantMajorArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankConductorArmyCanada"></see>
    /// </summary>
    let RankConductorArmyCanada = _prefix "RankConductorArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCorporalArmyCanada+"></see>
    /// </summary>
    let ``RankCorporalArmyCanada+`` = _prefix "RankCorporalArmyCanada+"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriverArmyCanada"></see>
    /// </summary>
    let RankDriverArmyCanada = _prefix "RankDriverArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriver_Australia"></see>
    /// </summary>
    let RankDriver_Australia = _prefix "RankDriver_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriver_Canada"></see>
    /// </summary>
    let RankDriver_Canada = _prefix "RankDriver_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankGeneralArmyCanada"></see>
    /// </summary>
    let RankGeneralArmyCanada = _prefix "RankGeneralArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankGunnerArmyCanada"></see>
    /// </summary>
    let RankGunnerArmyCanada = _prefix "RankGunnerArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLanceCorporalArmyCanada"></see>
    /// </summary>
    let RankLanceCorporalArmyCanada = _prefix "RankLanceCorporalArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLanceSergeantArmyCanada+"></see>
    /// </summary>
    let ``RankLanceSergeantArmyCanada+`` = _prefix "RankLanceSergeantArmyCanada+"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankStoker"></see>
    /// </summary>
    let RankStoker = _prefix "RankStoker"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantArmyCanada"></see>
    /// </summary>
    let RankLieutenantArmyCanada = _prefix "RankLieutenantArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada"></see>
    /// </summary>
    let RankLieutenantColonelArmyCanada = _prefix "RankLieutenantColonelArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada+"></see>
    /// </summary>
    let ``RankLieutenantColonelArmyCanada+`` =
        _prefix "RankLieutenantColonelArmyCanada+"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantGeneralArmyCanada"></see>
    /// </summary>
    let RankLieutenantGeneralArmyCanada = _prefix "RankLieutenantGeneralArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankMajorArmyCanada"></see>
    /// </summary>
    let RankMajorArmyCanada = _prefix "RankMajorArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankMasterGunnerArmyCanada"></see>
    /// </summary>
    let RankMasterGunnerArmyCanada = _prefix "RankMasterGunnerArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankNursingSisterArmyCanada"></see>
    /// </summary>
    let RankNursingSisterArmyCanada = _prefix "RankNursingSisterArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankOrderlyRoomSergeantArmyCanada"></see>
    /// </summary>
    let RankOrderlyRoomSergeantArmyCanada = _prefix "RankOrderlyRoomSergeantArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankPioneerArmyCanada"></see>
    /// </summary>
    let RankPioneerArmyCanada = _prefix "RankPioneerArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankPrivateArmyCanada"></see>
    /// </summary>
    let RankPrivateArmyCanada = _prefix "RankPrivateArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantArmyCanada"></see>
    /// </summary>
    let RankQuartermasterSergeantArmyCanada =
        _prefix "RankQuartermasterSergeantArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantMajorArmyCanada"></see>
    /// </summary>
    let RankQuartermasterSergeantMajorArmyCanada =
        _prefix "RankQuartermasterSergeantMajorArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankRegimentalSergeantMajorArmyCanada"></see>
    /// </summary>
    let RankRegimentalSergeantMajorArmyCanada =
        _prefix "RankRegimentalSergeantMajorArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankRiflemanArmyCanada"></see>
    /// </summary>
    let RankRiflemanArmyCanada = _prefix "RankRiflemanArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSaddlerArmyCanada"></see>
    /// </summary>
    let RankSaddlerArmyCanada = _prefix "RankSaddlerArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSapperArmyCanada"></see>
    /// </summary>
    let RankSapperArmyCanada = _prefix "RankSapperArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankScoutArmyCanada"></see>
    /// </summary>
    let RankScoutArmyCanada = _prefix "RankScoutArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSecondCorporalArmyCanada"></see>
    /// </summary>
    let RankSecondCorporalArmyCanada = _prefix "RankSecondCorporalArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSecondLieutenantArmyCanada"></see>
    /// </summary>
    let RankSecondLieutenantArmyCanada = _prefix "RankSecondLieutenantArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSergeantArmyCanada"></see>
    /// </summary>
    let RankSergeantArmyCanada = _prefix "RankSergeantArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSergeantMajorArmyCanada"></see>
    /// </summary>
    let RankSergeantMajorArmyCanada = _prefix "RankSergeantMajorArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSignallerArmyCanada"></see>
    /// </summary>
    let RankSignallerArmyCanada = _prefix "RankSignallerArmyCanada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSquadronSergeantMajorArmyCanada+"></see>
    /// </summary>
    let ``RankSquadronSergeantMajorArmyCanada+`` =
        _prefix "RankSquadronSergeantMajorArmyCanada+"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankStaffSergeantArmyCanada"></see>
    /// </summary>
    let RankStaffSergeantArmyCanada = _prefix "RankStaffSergeantArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankTrooperArmyCanada"></see>
    /// </summary>
    let RankTrooperArmyCanada = _prefix "RankTrooperArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankWarrantOfficerArmyCanada"></see>
    /// </summary>
    let RankWarrantOfficerArmyCanada = _prefix "RankWarrantOfficerArmyCanada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_EnglishTradition"></see>
    /// </summary>
    let Rank_Admiral_EnglishTradition = _prefix "Rank_Admiral_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_marshal_EnglishTradition"></see>
    /// </summary>
    let Rank_Air_marshal_EnglishTradition = _prefix "Rank_Air_marshal_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_General_officer_EnglishTradition =
        _prefix "Rank_General_officer_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_fleet_EnglishTradition"></see>
    /// </summary>
    let Rank_Admiral_of_the_fleet_EnglishTradition =
        _prefix "Rank_Admiral_of_the_fleet_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commodore_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Commodore_(rank)_EnglishTradition`` =
        _prefix "Rank_Commodore_(rank)_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia"></see>
    /// </summary>
    let Rank_Admiral_of_the_Fleet_Russia = _prefix "Rank_Admiral_of_the_Fleet_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Russia"></see>
    /// </summary>
    let Rank_Admiral_of_the_Fleet_Russia_Russia =
        _prefix "Rank_Admiral_of_the_Fleet_Russia_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Soviet_Union"></see>
    /// </summary>
    let Rank_Admiral_of_the_Fleet_Russia_Soviet_Union =
        _prefix "Rank_Admiral_of_the_Fleet_Russia_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_air_force_EnglishTradition"></see>
    /// </summary>
    let Rank_Marshal_of_the_air_force_EnglishTradition =
        _prefix "Rank_Marshal_of_the_air_force_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Field_marshal_EnglishTradition"></see>
    /// </summary>
    let Rank_Field_marshal_EnglishTradition =
        _prefix "Rank_Field_marshal_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_EnglishTradition"></see>
    /// </summary>
    let Rank_Marshal_EnglishTradition = _prefix "Rank_Marshal_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha"></see>
    /// </summary>
    let Rank_Agha = _prefix "Rank_Agha"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Agha_Cossack_Hetmanate = _prefix "Rank_Agha_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Agha_Ottoman_Empire = _prefix "Rank_Agha_Ottoman_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Agha_Septinsular_Republic = _prefix "Rank_Agha_Septinsular_Republic"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal"></see>
    /// </summary>
    let Rank_Air_chief_marshal = _prefix "Rank_Air_chief_marshal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Australia = _prefix "Rank_Air_chief_marshal_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia_Australia"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Australia_Australia =
        _prefix "Rank_Air_chief_marshal_Australia_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Canada"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Canada = _prefix "Rank_Air_chief_marshal_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Commonwealth_of_Nations =
        _prefix "Rank_Air_chief_marshal_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_commodore_EnglishTradition"></see>
    /// </summary>
    let Rank_Air_commodore_EnglishTradition =
        _prefix "Rank_Air_commodore_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_EnglishTradition"></see>
    /// </summary>
    let Rank_Brigadier_EnglishTradition = _prefix "Rank_Brigadier_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Group_captain_EnglishTradition"></see>
    /// </summary>
    let Rank_Group_captain_EnglishTradition =
        _prefix "Rank_Group_captain_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal`` = _prefix "Rank_Air_vice-marshal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Australia"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal_Australia`` = _prefix "Rank_Air_vice-marshal_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Canada"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal_Canada`` = _prefix "Rank_Air_vice-marshal_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Commonwealth_of_Nations"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal_Commonwealth_of_Nations`` =
        _prefix "Rank_Air_vice-marshal_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aircraftman_EnglishTradition"></see>
    /// </summary>
    let Rank_Aircraftman_EnglishTradition = _prefix "Rank_Aircraftman_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Seaman_EnglishTradition"></see>
    /// </summary>
    let Rank_Seaman_EnglishTradition = _prefix "Rank_Seaman_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos"></see>
    /// </summary>
    let Rank_Anthypolochagos = _prefix "Rank_Anthypolochagos"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Greece"></see>
    /// </summary>
    let Rank_Anthypolochagos_Greece = _prefix "Rank_Anthypolochagos_Greece"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis"></see>
    /// </summary>
    let Rank_Antisyntagmatarchis = _prefix "Rank_Antisyntagmatarchis"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Greece"></see>
    /// </summary>
    let Rank_Antisyntagmatarchis_Greece = _prefix "Rank_Antisyntagmatarchis_Greece"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Italy"></see>
    /// </summary>
    let Rank_Appointee_Italy = _prefix "Rank_Appointee_Italy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee"></see>
    /// </summary>
    let Rank_Appointee = _prefix "Rank_Appointee"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Switzerland"></see>
    /// </summary>
    let Rank_Appointee_Switzerland = _prefix "Rank_Appointee_Switzerland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia"></see>
    /// </summary>
    let Rank_Army_General_Russia = _prefix "Rank_Army_General_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Russia"></see>
    /// </summary>
    let Rank_Army_General_Russia_Russia = _prefix "Rank_Army_General_Russia_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Soviet_Union"></see>
    /// </summary>
    let Rank_Army_General_Russia_Soviet_Union =
        _prefix "Rank_Army_General_Russia_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant"></see>
    /// </summary>
    let Rank_Aspirant = _prefix "Rank_Aspirant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_France"></see>
    /// </summary>
    let Rank_Aspirant_France = _prefix "Rank_Aspirant_France"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania"></see>
    /// </summary>
    let Rank_Aspirant_Romania = _prefix "Rank_Aspirant_Romania"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania_Romania"></see>
    /// </summary>
    let Rank_Aspirant_Romania_Romania = _prefix "Rank_Aspirant_Romania_Romania"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman"></see>
    /// </summary>
    let Rank_Ataman = _prefix "Rank_Ataman"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Russia"></see>
    /// </summary>
    let Rank_Ataman_Russia = _prefix "Rank_Ataman_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Soviet_Union"></see>
    /// </summary>
    let Rank_Ataman_Soviet_Union = _prefix "Rank_Ataman_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Ukraine"></see>
    /// </summary>
    let Rank_Ataman_Ukraine = _prefix "Rank_Ataman_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Battery_sergeant_major"></see>
    /// </summary>
    let Rank_Battery_sergeant_major = _prefix "Rank_Battery_sergeant_major"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik"></see>
    /// </summary>
    let Rank_Birinci_Ferik = _prefix "Rank_Birinci_Ferik"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Birinci_Ferik_Cossack_Hetmanate =
        _prefix "Rank_Birinci_Ferik_Cossack_Hetmanate"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Birinci_Ferik_Ottoman_Empire = _prefix "Rank_Birinci_Ferik_Ottoman_Empire"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Birinci_Ferik_Septinsular_Republic =
        _prefix "Rank_Birinci_Ferik_Septinsular_Republic"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Australia"></see>
    /// </summary>
    let Rank_Bombardier_Australia = _prefix "Rank_Bombardier_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_%28rank%29"></see>
    /// </summary>
    let ``Rank_Bombardier_%28rank%29`` = _prefix "Rank_Bombardier_%28rank%29"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Canada"></see>
    /// </summary>
    let Rank_Bombardier_Canada = _prefix "Rank_Bombardier_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Bombardier_Commonwealth_of_Nations =
        _prefix "Rank_Bombardier_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann"></see>
    /// </summary>
    let Rank_Bootsmann = _prefix "Rank_Bootsmann"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Germany"></see>
    /// </summary>
    let Rank_Bootsmann_Germany = _prefix "Rank_Bootsmann_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Russia"></see>
    /// </summary>
    let Rank_Bootsmann_Russia = _prefix "Rank_Bootsmann_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Soviet_Union"></see>
    /// </summary>
    let Rank_Bootsmann_Soviet_Union = _prefix "Rank_Bootsmann_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General"></see>
    /// </summary>
    let Rank_Brigade_General = _prefix "Rank_Brigade_General"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Australia"></see>
    /// </summary>
    let Rank_Brigade_General_Australia = _prefix "Rank_Brigade_General_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Canada"></see>
    /// </summary>
    let Rank_Brigade_General_Canada = _prefix "Rank_Brigade_General_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Colonel_EnglishTradition"></see>
    /// </summary>
    let Rank_Colonel_EnglishTradition = _prefix "Rank_Colonel_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Australia"></see>
    /// </summary>
    let Rank_Brigadier_general_Australia = _prefix "Rank_Brigadier_general_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Canada"></see>
    /// </summary>
    let Rank_Brigadier_general_Canada = _prefix "Rank_Brigadier_general_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy"></see>
    /// </summary>
    let Rank_Buffer_Navy = _prefix "Rank_Buffer_Navy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Australia"></see>
    /// </summary>
    let Rank_Buffer_Navy_Australia = _prefix "Rank_Buffer_Navy_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Buffer_Navy_Commonwealth_of_Nations =
        _prefix "Rank_Buffer_Navy_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain"></see>
    /// </summary>
    let Rank_Captain = _prefix "Rank_Captain"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_(naval)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Captain_(naval)_EnglishTradition`` =
        _prefix "Rank_Captain_(naval)_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commander_EnglishTradition"></see>
    /// </summary>
    let Rank_Commander_EnglishTradition = _prefix "Rank_Commander_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Australia"></see>
    /// </summary>
    let Rank_Captain_Australia = _prefix "Rank_Captain_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Canada"></see>
    /// </summary>
    let Rank_Captain_Canada = _prefix "Rank_Captain_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_lieutenant_EnglishTradition"></see>
    /// </summary>
    let Rank_Flight_lieutenant_EnglishTradition =
        _prefix "Rank_Flight_lieutenant_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_(navy)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Lieutenant_(navy)_EnglishTradition`` =
        _prefix "Rank_Lieutenant_(navy)_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandant_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Commandant_(rank)_EnglishTradition`` =
        _prefix "Rank_Commandant_(rank)_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant"></see>
    /// </summary>
    let Rank_Captain_Lieutenant = _prefix "Rank_Captain_Lieutenant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Germany"></see>
    /// </summary>
    let Rank_Captain_Lieutenant_Germany = _prefix "Rank_Captain_Lieutenant_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Russia"></see>
    /// </summary>
    let Rank_Captain_Lieutenant_Russia = _prefix "Rank_Captain_Lieutenant_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Soviet_Union"></see>
    /// </summary>
    let Rank_Captain_Lieutenant_Soviet_Union =
        _prefix "Rank_Captain_Lieutenant_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Captain_Republic_of_Ireland = _prefix "Rank_Captain_Republic_of_Ireland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Russia"></see>
    /// </summary>
    let Rank_Captain_Russia = _prefix "Rank_Captain_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Singapore"></see>
    /// </summary>
    let Rank_Captain_Singapore = _prefix "Rank_Captain_Singapore"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Soviet_Union"></see>
    /// </summary>
    let Rank_Captain_Soviet_Union = _prefix "Rank_Captain_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Sweden"></see>
    /// </summary>
    let Rank_Captain_Sweden = _prefix "Rank_Captain_Sweden"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant"></see>
    /// </summary>
    let Rank_Captain_lieutenant = _prefix "Rank_Captain_lieutenant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Germany"></see>
    /// </summary>
    let Rank_Captain_lieutenant_Germany = _prefix "Rank_Captain_lieutenant_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Russia"></see>
    /// </summary>
    let Rank_Captain_lieutenant_Russia = _prefix "Rank_Captain_lieutenant_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Soviet_Union"></see>
    /// </summary>
    let Rank_Captain_lieutenant_Soviet_Union =
        _prefix "Rank_Captain_lieutenant_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal"></see>
    /// </summary>
    let Rank_Chief_Marshal = _prefix "Rank_Chief_Marshal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Russia"></see>
    /// </summary>
    let Rank_Chief_Marshal_Russia = _prefix "Rank_Chief_Marshal_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Soviet_Union"></see>
    /// </summary>
    let Rank_Chief_Marshal_Soviet_Union = _prefix "Rank_Chief_Marshal_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer"></see>
    /// </summary>
    let Rank_Chief_petty_officer = _prefix "Rank_Chief_petty_officer"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class_Canada"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_1st_class_Canada`` =
        _prefix "Rank_Chief_petty_officer,_1st_class_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_1st_class`` =
        _prefix "Rank_Chief_petty_officer,_1st_class"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class_Canada"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_2nd_class_Canada`` =
        _prefix "Rank_Chief_petty_officer,_2nd_class_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_2nd_class`` =
        _prefix "Rank_Chief_petty_officer,_2nd_class"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Australia"></see>
    /// </summary>
    let Rank_Chief_petty_officer_Australia =
        _prefix "Rank_Chief_petty_officer_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Canada"></see>
    /// </summary>
    let Rank_Chief_petty_officer_Canada = _prefix "Rank_Chief_petty_officer_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Chief_petty_officer_Commonwealth_of_Nations =
        _prefix "Rank_Chief_petty_officer_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch"></see>
    /// </summary>
    let Rank_Chiliarch = _prefix "Rank_Chiliarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Achaean_League"></see>
    /// </summary>
    let Rank_Chiliarch_Achaean_League = _prefix "Rank_Chiliarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Chiliarch_Byzantine_Empire = _prefix "Rank_Chiliarch_Byzantine_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Greece"></see>
    /// </summary>
    let Rank_Chiliarch_Greece = _prefix "Rank_Chiliarch_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Macedonia"></see>
    /// </summary>
    let Rank_Chiliarch_Macedonia = _prefix "Rank_Chiliarch_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Chiliarch_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Chiliarch_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji"></see>
    /// </summary>
    let Rank_Chorbaji = _prefix "Rank_Chorbaji"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Chorbaji_Cossack_Hetmanate = _prefix "Rank_Chorbaji_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Chorbaji_Ottoman_Empire = _prefix "Rank_Chorbaji_Ottoman_Empire"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Chorbaji_Septinsular_Republic =
        _prefix "Rank_Chorbaji_Septinsular_Republic"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy"></see>
    /// </summary>
    let Rank_Chowqzy = _prefix "Rank_Chowqzy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Poland"></see>
    /// </summary>
    let Rank_Chowqzy_Poland = _prefix "Rank_Chowqzy_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Russia"></see>
    /// </summary>
    let Rank_Chowqzy_Russia = _prefix "Rank_Chowqzy_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Soviet_Union"></see>
    /// </summary>
    let Rank_Chowqzy_Soviet_Union = _prefix "Rank_Chowqzy_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Ukraine"></see>
    /// </summary>
    let Rank_Chowqzy_Ukraine = _prefix "Rank_Chowqzy_Ukraine"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_colonel_EnglishTradition"></see>
    /// </summary>
    let Rank_Lieutenant_colonel_EnglishTradition =
        _prefix "Rank_Lieutenant_colonel_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm"></see>
    /// </summary>
    let Rank_Comandarm = _prefix "Rank_Comandarm"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Russia"></see>
    /// </summary>
    let Rank_Comandarm_Russia = _prefix "Rank_Comandarm_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Soviet_Union"></see>
    /// </summary>
    let Rank_Comandarm_Soviet_Union = _prefix "Rank_Comandarm_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig"></see>
    /// </summary>
    let Rank_Combrig = _prefix "Rank_Combrig"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Russia"></see>
    /// </summary>
    let Rank_Combrig_Russia = _prefix "Rank_Combrig_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Soviet_Union"></see>
    /// </summary>
    let Rank_Combrig_Soviet_Union = _prefix "Rank_Combrig_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor"></see>
    /// </summary>
    let Rank_Comcor = _prefix "Rank_Comcor"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Russia"></see>
    /// </summary>
    let Rank_Comcor_Russia = _prefix "Rank_Comcor_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Soviet_Union"></see>
    /// </summary>
    let Rank_Comcor_Soviet_Union = _prefix "Rank_Comcor_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv"></see>
    /// </summary>
    let Rank_Comdiv = _prefix "Rank_Comdiv"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Russia"></see>
    /// </summary>
    let Rank_Comdiv_Russia = _prefix "Rank_Comdiv_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Soviet_Union"></see>
    /// </summary>
    let Rank_Comdiv_Soviet_Union = _prefix "Rank_Comdiv_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_commander_EnglishTradition"></see>
    /// </summary>
    let Rank_Lieutenant_commander_EnglishTradition =
        _prefix "Rank_Lieutenant_commander_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Squadron_leader_EnglishTradition"></see>
    /// </summary>
    let Rank_Squadron_leader_EnglishTradition =
        _prefix "Rank_Squadron_leader_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Wing_commander_(rank)_EnglishTradition`` =
        _prefix "Rank_Wing_commander_(rank)_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur"></see>
    /// </summary>
    let Rank_Commandeur = _prefix "Rank_Commandeur"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_France"></see>
    /// </summary>
    let Rank_Commandeur_France = _prefix "Rank_Commandeur_France"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_Netherlands"></see>
    /// </summary>
    let Rank_Commandeur_Netherlands = _prefix "Rank_Commandeur_Netherlands"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations =
        _prefix "Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_England"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_England =
        _prefix "Rank_Company_Quartermaster_Sergeant_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland =
        _prefix "Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Scotland"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Scotland =
        _prefix "Rank_Company_Quartermaster_Sergeant_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Wales"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Wales =
        _prefix "Rank_Company_Quartermaster_Sergeant_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major"></see>
    /// </summary>
    let Rank_Company_sergeant_major = _prefix "Rank_Company_sergeant_major"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Australia"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Australia =
        _prefix "Rank_Company_sergeant_major_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Canada"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Canada =
        _prefix "Rank_Company_sergeant_major_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Commonwealth_of_Nations =
        _prefix "Rank_Company_sergeant_major_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_England"></see>
    /// </summary>
    let Rank_Company_sergeant_major_England =
        _prefix "Rank_Company_sergeant_major_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Scotland"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Scotland =
        _prefix "Rank_Company_sergeant_major_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Singapore"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Singapore =
        _prefix "Rank_Company_sergeant_major_Singapore"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Wales"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Wales = _prefix "Rank_Company_sergeant_major_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army"></see>
    /// </summary>
    let Rank_Conductor_army = _prefix "Rank_Conductor_army"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Australia"></see>
    /// </summary>
    let Rank_Conductor_army_Australia = _prefix "Rank_Conductor_army_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_England"></see>
    /// </summary>
    let Rank_Conductor_army_England = _prefix "Rank_Conductor_army_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Scotland"></see>
    /// </summary>
    let Rank_Conductor_army_Scotland = _prefix "Rank_Conductor_army_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Wales"></see>
    /// </summary>
    let Rank_Conductor_army_Wales = _prefix "Rank_Conductor_army_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_seaman_EnglishTradition"></see>
    /// </summary>
    let Rank_Leading_seaman_EnglishTradition =
        _prefix "Rank_Leading_seaman_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang"></see>
    /// </summary>
    let Rank_Daejang = _prefix "Rank_Daejang"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_North_Korea"></see>
    /// </summary>
    let Rank_Daejang_North_Korea = _prefix "Rank_Daejang_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_South_Korea"></see>
    /// </summary>
    let Rank_Daejang_South_Korea = _prefix "Rank_Daejang_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar"></see>
    /// </summary>
    let Rank_Daffadar = _prefix "Rank_Daffadar"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Havildar"></see>
    /// </summary>
    let Rank_Havildar = _prefix "Rank_Havildar"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar_British_India"></see>
    /// </summary>
    let Rank_Daffadar_British_India = _prefix "Rank_Daffadar_British_India"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant"></see>
    /// </summary>
    let Rank_Sergeant = _prefix "Rank_Sergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral"></see>
    /// </summary>
    let Rank_Divisional_Admiral = _prefix "Rank_Divisional_Admiral"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Belgium"></see>
    /// </summary>
    let Rank_Divisional_Admiral_Belgium = _prefix "Rank_Divisional_Admiral_Belgium"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Italy"></see>
    /// </summary>
    let Rank_Divisional_Admiral_Italy = _prefix "Rank_Divisional_Admiral_Italy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General"></see>
    /// </summary>
    let Rank_Divisional_General = _prefix "Rank_Divisional_General"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_France"></see>
    /// </summary>
    let Rank_Divisional_General_France = _prefix "Rank_Divisional_General_France"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_Poland"></see>
    /// </summary>
    let Rank_Divisional_General_Poland = _prefix "Rank_Divisional_General_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General"></see>
    /// </summary>
    let Rank_Drum_Major_General = _prefix "Rank_Drum_Major_General"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Drum_Major_General_Commonwealth_of_Nations =
        _prefix "Rank_Drum_Major_General_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_England"></see>
    /// </summary>
    let Rank_Drum_Major_General_England = _prefix "Rank_Drum_Major_General_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Scotland"></see>
    /// </summary>
    let Rank_Drum_Major_General_Scotland = _prefix "Rank_Drum_Major_General_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Wales"></see>
    /// </summary>
    let Rank_Drum_Major_General_Wales = _prefix "Rank_Drum_Major_General_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major"></see>
    /// </summary>
    let Rank_Drum_major = _prefix "Rank_Drum_major"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Drum_major_Commonwealth_of_Nations =
        _prefix "Rank_Drum_major_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_England"></see>
    /// </summary>
    let Rank_Drum_major_England = _prefix "Rank_Drum_major_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Scotland"></see>
    /// </summary>
    let Rank_Drum_major_Scotland = _prefix "Rank_Drum_major_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Wales"></see>
    /// </summary>
    let Rank_Drum_major_Wales = _prefix "Rank_Drum_major_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ensign_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Ensign_(rank)_EnglishTradition`` =
        _prefix "Rank_Ensign_(rank)_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_lieutenant_EnglishTradition"></see>
    /// </summary>
    let Rank_Second_lieutenant_EnglishTradition =
        _prefix "Rank_Second_lieutenant_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pilot_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Pilot_officer_EnglishTradition =
        _prefix "Rank_Pilot_officer_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sub-lieutenant_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Sub-lieutenant_EnglishTradition`` =
        _prefix "Rank_Sub-lieutenant_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Midshipman_EnglishTradition"></see>
    /// </summary>
    let Rank_Midshipman_EnglishTradition = _prefix "Rank_Midshipman_EnglishTradition"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch"></see>
    /// </summary>
    let Rank_Epihipparch = _prefix "Rank_Epihipparch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Achaean_League"></see>
    /// </summary>
    let Rank_Epihipparch_Achaean_League = _prefix "Rank_Epihipparch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Macedonia"></see>
    /// </summary>
    let Rank_Epihipparch_Macedonia = _prefix "Rank_Epihipparch_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik"></see>
    /// </summary>
    let Rank_Ferik = _prefix "Rank_Ferik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Ferik_Cossack_Hetmanate = _prefix "Rank_Ferik_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Ferik_Ottoman_Empire = _prefix "Rank_Ferik_Ottoman_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Ferik_Septinsular_Republic = _prefix "Rank_Ferik_Septinsular_Republic"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board"></see>
    /// </summary>
    let Rank_Fleet_Board = _prefix "Rank_Fleet_Board"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_England"></see>
    /// </summary>
    let Rank_Fleet_Board_England = _prefix "Rank_Fleet_Board_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Scotland"></see>
    /// </summary>
    let Rank_Fleet_Board_Scotland = _prefix "Rank_Fleet_Board_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Wales"></see>
    /// </summary>
    let Rank_Fleet_Board_Wales = _prefix "Rank_Fleet_Board_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flying_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Flying_officer_EnglishTradition =
        _prefix "Rank_Flying_officer_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant"></see>
    /// </summary>
    let Rank_Flight_sergeant = _prefix "Rank_Flight_sergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Australia"></see>
    /// </summary>
    let Rank_Flight_sergeant_Australia = _prefix "Rank_Flight_sergeant_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Canada"></see>
    /// </summary>
    let Rank_Flight_sergeant_Canada = _prefix "Rank_Flight_sergeant_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Flight_sergeant_Commonwealth_of_Nations =
        _prefix "Rank_Flight_sergeant_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Flight_sergeant_Republic_of_Ireland =
        _prefix "Rank_Flight_sergeant_Republic_of_Ireland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major = _prefix "Rank_Garrison_Sergeant_Major"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_England"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major_England =
        _prefix "Rank_Garrison_Sergeant_Major_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Scotland"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major_Scotland =
        _prefix "Rank_Garrison_Sergeant_Major_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Wales"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major_Wales =
        _prefix "Rank_Garrison_Sergeant_Major_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter"></see>
    /// </summary>
    let Rank_Gefreiter = _prefix "Rank_Gefreiter"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Germany"></see>
    /// </summary>
    let Rank_Gefreiter_Germany = _prefix "Rank_Gefreiter_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Russia"></see>
    /// </summary>
    let Rank_Gefreiter_Russia = _prefix "Rank_Gefreiter_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Soviet_Union"></see>
    /// </summary>
    let Rank_Gefreiter_Soviet_Union = _prefix "Rank_Gefreiter_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief"></see>
    /// </summary>
    let ``Rank_General-in-Chief`` = _prefix "Rank_General-in-Chief"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Russia"></see>
    /// </summary>
    let ``Rank_General-in-Chief_Russia`` = _prefix "Rank_General-in-Chief_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Soviet_Union"></see>
    /// </summary>
    let ``Rank_General-in-Chief_Soviet_Union`` =
        _prefix "Rank_General-in-Chief_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral"></see>
    /// </summary>
    let Rank_General_Admiral = _prefix "Rank_General_Admiral"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Germany"></see>
    /// </summary>
    let Rank_General_Admiral_Germany = _prefix "Rank_General_Admiral_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Russia"></see>
    /// </summary>
    let Rank_General_Admiral_Russia = _prefix "Rank_General_Admiral_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Soviet_Union"></see>
    /// </summary>
    let Rank_General_Admiral_Soviet_Union = _prefix "Rank_General_Admiral_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa"></see>
    /// </summary>
    let Rank_Hasa = _prefix "Rank_Hasa"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_North_Korea"></see>
    /// </summary>
    let Rank_Hasa_North_Korea = _prefix "Rank_Hasa_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_South_Korea"></see>
    /// </summary>
    let Rank_Hasa_South_Korea = _prefix "Rank_Hasa_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Havildar_British_India"></see>
    /// </summary>
    let Rank_Havildar_British_India = _prefix "Rank_Havildar_British_India"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman"></see>
    /// </summary>
    let Rank_Hetman = _prefix "Rank_Hetman"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Belarus"></see>
    /// </summary>
    let Rank_Hetman_Belarus = _prefix "Rank_Hetman_Belarus"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Lithuania"></see>
    /// </summary>
    let Rank_Hetman_Lithuania = _prefix "Rank_Hetman_Lithuania"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Poland"></see>
    /// </summary>
    let Rank_Hetman_Poland = _prefix "Rank_Hetman_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Ukraine"></see>
    /// </summary>
    let Rank_Hetman_Ukraine = _prefix "Rank_Hetman_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry"></see>
    /// </summary>
    let Rank_Hipparchus_Cavalry = _prefix "Rank_Hipparchus_Cavalry"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Achaean_League"></see>
    /// </summary>
    let Rank_Hipparchus_Cavalry_Achaean_League =
        _prefix "Rank_Hipparchus_Cavalry_Achaean_League"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Macedonia"></see>
    /// </summary>
    let Rank_Hipparchus_Cavalry_Macedonia = _prefix "Rank_Hipparchus_Cavalry_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa"></see>
    /// </summary>
    let Rank_Jungsa = _prefix "Rank_Jungsa"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_North_Korea"></see>
    /// </summary>
    let Rank_Jungsa_North_Korea = _prefix "Rank_Jungsa_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_South_Korea"></see>
    /// </summary>
    let Rank_Jungsa_South_Korea = _prefix "Rank_Jungsa_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi"></see>
    /// </summary>
    let Rank_Jungwi = _prefix "Rank_Jungwi"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_North_Korea"></see>
    /// </summary>
    let Rank_Jungwi_North_Korea = _prefix "Rank_Jungwi_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_South_Korea"></see>
    /// </summary>
    let Rank_Jungwi_South_Korea = _prefix "Rank_Jungwi_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant"></see>
    /// </summary>
    let Rank_Junior_sergeant = _prefix "Rank_Junior_sergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Estonia"></see>
    /// </summary>
    let Rank_Junior_sergeant_Estonia = _prefix "Rank_Junior_sergeant_Estonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Junior_sergeant_Republic_of_Estonia_1920-1940`` =
        _prefix "Rank_Junior_sergeant_Republic_of_Estonia_1920-1940"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang"></see>
    /// </summary>
    let Rank_Junjang = _prefix "Rank_Junjang"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_North_Korea"></see>
    /// </summary>
    let Rank_Junjang_North_Korea = _prefix "Rank_Junjang_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_South_Korea"></see>
    /// </summary>
    let Rank_Junjang_South_Korea = _prefix "Rank_Junjang_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha"></see>
    /// </summary>
    let Rank_Kapudan_Pasha = _prefix "Rank_Kapudan_Pasha"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Kapudan_Pasha_Cossack_Hetmanate =
        _prefix "Rank_Kapudan_Pasha_Cossack_Hetmanate"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Kapudan_Pasha_Ottoman_Empire = _prefix "Rank_Kapudan_Pasha_Ottoman_Empire"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Kapudan_Pasha_Septinsular_Republic =
        _prefix "Rank_Kapudan_Pasha_Septinsular_Republic"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral"></see>
    /// </summary>
    let Rank_Kindral = _prefix "Rank_Kindral"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Estonia"></see>
    /// </summary>
    let Rank_Kindral_Estonia = _prefix "Rank_Kindral_Estonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Kindral_Republic_of_Estonia_1920-1940`` =
        _prefix "Rank_Kindral_Republic_of_Estonia_1920-1940"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi"></see>
    /// </summary>
    let Rank_Kolagasi = _prefix "Rank_Kolagasi"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Kolagasi_Cossack_Hetmanate = _prefix "Rank_Kolagasi_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Kolagasi_Ottoman_Empire = _prefix "Rank_Kolagasi_Ottoman_Empire"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Kolagasi_Septinsular_Republic =
        _prefix "Rank_Kolagasi_Septinsular_Republic"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel"></see>
    /// </summary>
    let Rank_Kolonel = _prefix "Rank_Kolonel"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Belgium"></see>
    /// </summary>
    let Rank_Kolonel_Belgium = _prefix "Rank_Kolonel_Belgium"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Estonia"></see>
    /// </summary>
    let Rank_Kolonel_Estonia = _prefix "Rank_Kolonel_Estonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Netherlands"></see>
    /// </summary>
    let Rank_Kolonel_Netherlands = _prefix "Rank_Kolonel_Netherlands"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Kolonel_Republic_of_Estonia_1920-1940`` =
        _prefix "Rank_Kolonel_Republic_of_Estonia_1920-1940"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse`` = _prefix "Rank_Lance-corporal_of_horse"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_England"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse_England`` =
        _prefix "Rank_Lance-corporal_of_horse_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Scotland"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse_Scotland`` =
        _prefix "Rank_Lance-corporal_of_horse_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Wales"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse_Wales`` =
        _prefix "Rank_Lance-corporal_of_horse_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal"></see>
    /// </summary>
    let Rank_Lance_corporal = _prefix "Rank_Lance_corporal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Australia"></see>
    /// </summary>
    let Rank_Lance_corporal_Australia = _prefix "Rank_Lance_corporal_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Lance_corporal_Commonwealth_of_Nations =
        _prefix "Rank_Lance_corporal_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_England"></see>
    /// </summary>
    let Rank_Lance_corporal_England = _prefix "Rank_Lance_corporal_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Scotland"></see>
    /// </summary>
    let Rank_Lance_corporal_Scotland = _prefix "Rank_Lance_corporal_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Singapore"></see>
    /// </summary>
    let Rank_Lance_corporal_Singapore = _prefix "Rank_Lance_corporal_Singapore"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Wales"></see>
    /// </summary>
    let Rank_Lance_corporal_Wales = _prefix "Rank_Lance_corporal_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant"></see>
    /// </summary>
    let Rank_Lance_sergeant = _prefix "Rank_Lance_sergeant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Australia"></see>
    /// </summary>
    let Rank_Lance_sergeant_Australia = _prefix "Rank_Lance_sergeant_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Lance_sergeant_Commonwealth_of_Nations =
        _prefix "Rank_Lance_sergeant_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_England"></see>
    /// </summary>
    let Rank_Lance_sergeant_England = _prefix "Rank_Lance_sergeant_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Scotland"></see>
    /// </summary>
    let Rank_Lance_sergeant_Scotland = _prefix "Rank_Lance_sergeant_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Wales"></see>
    /// </summary>
    let Rank_Lance_sergeant_Wales = _prefix "Rank_Lance_sergeant_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman"></see>
    /// </summary>
    let Rank_Leading_aircraftman = _prefix "Rank_Leading_aircraftman"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Australia"></see>
    /// </summary>
    let Rank_Leading_aircraftman_Australia =
        _prefix "Rank_Leading_aircraftman_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Canada"></see>
    /// </summary>
    let Rank_Leading_aircraftman_Canada = _prefix "Rank_Leading_aircraftman_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Leading_aircraftman_Commonwealth_of_Nations =
        _prefix "Rank_Leading_aircraftman_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos"></see>
    /// </summary>
    let Rank_Lochagos = _prefix "Rank_Lochagos"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Achaean_League"></see>
    /// </summary>
    let Rank_Lochagos_Achaean_League = _prefix "Rank_Lochagos_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Greece"></see>
    /// </summary>
    let Rank_Lochagos_Greece = _prefix "Rank_Lochagos_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Macedonia"></see>
    /// </summary>
    let Rank_Lochagos_Macedonia = _prefix "Rank_Lochagos_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Lochagos_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Lochagos_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash =
        _prefix "Rank_Lord_High_Admiral_of_the_Wash"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_England"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash_England =
        _prefix "Rank_Lord_High_Admiral_of_the_Wash_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Scotland"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash_Scotland =
        _prefix "Rank_Lord_High_Admiral_of_the_Wash_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Wales"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash_Wales =
        _prefix "Rank_Lord_High_Admiral_of_the_Wash_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general"></see>
    /// </summary>
    let Rank_Major_general = _prefix "Rank_Major_general"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Australia"></see>
    /// </summary>
    let Rank_Major_general_Australia = _prefix "Rank_Major_general_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Canada"></see>
    /// </summary>
    let Rank_Major_general_Canada = _prefix "Rank_Major_general_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union"></see>
    /// </summary>
    let Rank_Marshal_of_the_Soviet_Union = _prefix "Rank_Marshal_of_the_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union_Soviet_Union"></see>
    /// </summary>
    let Rank_Marshal_of_the_Soviet_Union_Soviet_Union =
        _prefix "Rank_Marshal_of_the_Soviet_Union_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer"></see>
    /// </summary>
    let Rank_Master_warrant_officer = _prefix "Rank_Master_warrant_officer"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Canada"></see>
    /// </summary>
    let Rank_Master_warrant_officer_Canada =
        _prefix "Rank_Master_warrant_officer_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Singapore"></see>
    /// </summary>
    let Rank_Master_warrant_officer_Singapore =
        _prefix "Rank_Master_warrant_officer_Singapore"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Officer_cadet_EnglishTradition"></see>
    /// </summary>
    let Rank_Officer_cadet_EnglishTradition =
        _prefix "Rank_Officer_cadet_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Warrant_officer_EnglishTradition =
        _prefix "Rank_Warrant_officer_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva"></see>
    /// </summary>
    let Rank_Mirliva = _prefix "Rank_Mirliva"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Mirliva_Cossack_Hetmanate = _prefix "Rank_Mirliva_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Mirliva_Ottoman_Empire = _prefix "Rank_Mirliva_Ottoman_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Mirliva_Septinsular_Republic = _prefix "Rank_Mirliva_Septinsular_Republic"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir"></see>
    /// </summary>
    let Rank_Musir = _prefix "Rank_Musir"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Musir_Cossack_Hetmanate = _prefix "Rank_Musir_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Musir_Ottoman_Empire = _prefix "Rank_Musir_Ottoman_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Musir_Septinsular_Republic = _prefix "Rank_Musir_Septinsular_Republic"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch"></see>
    /// </summary>
    let Rank_Navarch = _prefix "Rank_Navarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Achaean_League"></see>
    /// </summary>
    let Rank_Navarch_Achaean_League = _prefix "Rank_Navarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Greece"></see>
    /// </summary>
    let Rank_Navarch_Greece = _prefix "Rank_Navarch_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Macedonia"></see>
    /// </summary>
    let Rank_Navarch_Macedonia = _prefix "Rank_Navarch_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Navarch_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Navarch_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter"></see>
    /// </summary>
    let Rank_Obergefreiter = _prefix "Rank_Obergefreiter"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Germany"></see>
    /// </summary>
    let Rank_Obergefreiter_Germany = _prefix "Rank_Obergefreiter_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Switzerland"></see>
    /// </summary>
    let Rank_Obergefreiter_Switzerland = _prefix "Rank_Obergefreiter_Switzerland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst"></see>
    /// </summary>
    let Rank_Oberst = _prefix "Rank_Oberst"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Austria"></see>
    /// </summary>
    let Rank_Oberst_Austria = _prefix "Rank_Oberst_Austria"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Denmark"></see>
    /// </summary>
    let Rank_Oberst_Denmark = _prefix "Rank_Oberst_Denmark"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Finland"></see>
    /// </summary>
    let Rank_Oberst_Finland = _prefix "Rank_Oberst_Finland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Germany"></see>
    /// </summary>
    let Rank_Oberst_Germany = _prefix "Rank_Oberst_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Kingdom_of_Denmark"></see>
    /// </summary>
    let Rank_Oberst_Kingdom_of_Denmark = _prefix "Rank_Oberst_Kingdom_of_Denmark"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Norway"></see>
    /// </summary>
    let Rank_Oberst_Norway = _prefix "Rank_Oberst_Norway"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Sweden"></see>
    /// </summary>
    let Rank_Oberst_Sweden = _prefix "Rank_Oberst_Sweden"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Switzerland"></see>
    /// </summary>
    let Rank_Oberst_Switzerland = _prefix "Rank_Oberst_Switzerland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant_Germany"></see>
    /// </summary>
    let Rank_Oberstleutnant_Germany = _prefix "Rank_Oberstleutnant_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant"></see>
    /// </summary>
    let Rank_Oberstleutnant = _prefix "Rank_Oberstleutnant"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_major_EnglishTradition"></see>
    /// </summary>
    let Rank_Sergeant_major_EnglishTradition =
        _prefix "Rank_Sergeant_major_EnglishTradition"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating = _prefix "Rank_Ordinary_seaman_rating"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Australia"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating_Australia =
        _prefix "Rank_Ordinary_seaman_rating_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Canada"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating_Canada =
        _prefix "Rank_Ordinary_seaman_rating_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating_Commonwealth_of_Nations =
        _prefix "Rank_Ordinary_seaman_rating_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch"></see>
    /// </summary>
    let Rank_Phrourarch = _prefix "Rank_Phrourarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Achaean_League"></see>
    /// </summary>
    let Rank_Phrourarch_Achaean_League = _prefix "Rank_Phrourarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Greece"></see>
    /// </summary>
    let Rank_Phrourarch_Greece = _prefix "Rank_Phrourarch_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Macedonia"></see>
    /// </summary>
    let Rank_Phrourarch_Macedonia = _prefix "Rank_Phrourarch_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Phrourarch_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Phrourarch_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major"></see>
    /// </summary>
    let Rank_Pipe_Major = _prefix "Rank_Pipe_Major"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Pipe_Major_Commonwealth_of_Nations =
        _prefix "Rank_Pipe_Major_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_England"></see>
    /// </summary>
    let Rank_Pipe_Major_England = _prefix "Rank_Pipe_Major_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Scotland"></see>
    /// </summary>
    let Rank_Pipe_Major_Scotland = _prefix "Rank_Pipe_Major_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Wales"></see>
    /// </summary>
    let Rank_Pipe_Major_Wales = _prefix "Rank_Pipe_Major_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik"></see>
    /// </summary>
    let Rank_Podpolkovnik = _prefix "Rank_Podpolkovnik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Poland"></see>
    /// </summary>
    let Rank_Podpolkovnik_Poland = _prefix "Rank_Podpolkovnik_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Russia"></see>
    /// </summary>
    let Rank_Podpolkovnik_Russia = _prefix "Rank_Podpolkovnik_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Soviet_Union"></see>
    /// </summary>
    let Rank_Podpolkovnik_Soviet_Union = _prefix "Rank_Podpolkovnik_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Ukraine"></see>
    /// </summary>
    let Rank_Podpolkovnik_Ukraine = _prefix "Rank_Podpolkovnik_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik"></see>
    /// </summary>
    let Rank_Podpraporshchik = _prefix "Rank_Podpraporshchik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Russia"></see>
    /// </summary>
    let Rank_Podpraporshchik_Russia = _prefix "Rank_Podpraporshchik_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Soviet_Union"></see>
    /// </summary>
    let Rank_Podpraporshchik_Soviet_Union = _prefix "Rank_Podpraporshchik_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch"></see>
    /// </summary>
    let Rank_Polemarch = _prefix "Rank_Polemarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Achaean_League"></see>
    /// </summary>
    let Rank_Polemarch_Achaean_League = _prefix "Rank_Polemarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Macedonia"></see>
    /// </summary>
    let Rank_Polemarch_Macedonia = _prefix "Rank_Polemarch_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik"></see>
    /// </summary>
    let Rank_Polkovnik = _prefix "Rank_Polkovnik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Poland"></see>
    /// </summary>
    let Rank_Polkovnik_Poland = _prefix "Rank_Polkovnik_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Russia"></see>
    /// </summary>
    let Rank_Polkovnik_Russia = _prefix "Rank_Polkovnik_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Soviet_Union"></see>
    /// </summary>
    let Rank_Polkovnik_Soviet_Union = _prefix "Rank_Polkovnik_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Ukraine"></see>
    /// </summary>
    let Rank_Polkovnik_Ukraine = _prefix "Rank_Polkovnik_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik"></see>
    /// </summary>
    let Rank_Poruchik = _prefix "Rank_Poruchik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Poland"></see>
    /// </summary>
    let Rank_Poruchik_Poland = _prefix "Rank_Poruchik_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Russia"></see>
    /// </summary>
    let Rank_Poruchik_Russia = _prefix "Rank_Poruchik_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Soviet_Union"></see>
    /// </summary>
    let Rank_Poruchik_Soviet_Union = _prefix "Rank_Poruchik_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik"></see>
    /// </summary>
    let Rank_Praporshchik = _prefix "Rank_Praporshchik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Russia"></see>
    /// </summary>
    let Rank_Praporshchik_Russia = _prefix "Rank_Praporshchik_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Soviet_Union"></see>
    /// </summary>
    let Rank_Praporshchik_Soviet_Union = _prefix "Rank_Praporshchik_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private"></see>
    /// </summary>
    let Rank_Private = _prefix "Rank_Private"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Australia"></see>
    /// </summary>
    let Rank_Private_Australia = _prefix "Rank_Private_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Canada"></see>
    /// </summary>
    let Rank_Private_Canada = _prefix "Rank_Private_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_England"></see>
    /// </summary>
    let Rank_Private_England = _prefix "Rank_Private_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Private_Republic_of_Ireland = _prefix "Rank_Private_Republic_of_Ireland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Scotland"></see>
    /// </summary>
    let Rank_Private_Scotland = _prefix "Rank_Private_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Wales"></see>
    /// </summary>
    let Rank_Private_Wales = _prefix "Rank_Private_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral"></see>
    /// </summary>
    let Rank_Rear_admiral = _prefix "Rank_Rear_admiral"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Australia"></see>
    /// </summary>
    let Rank_Rear_admiral_Australia = _prefix "Rank_Rear_admiral_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Canada"></see>
    /// </summary>
    let Rank_Rear_admiral_Canada = _prefix "Rank_Rear_admiral_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Australia"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Australia =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Canada"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Canada =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_England"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_England =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Scotland"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Scotland =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Wales"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Wales =
        _prefix "Rank_Regimental_Quartermaster_Sergeant_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Australia"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major_Australia =
        _prefix "Rank_Regimental_sergeant_major_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major_Commonwealth_of_Nations =
        _prefix "Rank_Regimental_sergeant_major_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Singapore"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major_Singapore =
        _prefix "Rank_Regimental_sergeant_major_Singapore"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa"></see>
    /// </summary>
    let Rank_Sangsa = _prefix "Rank_Sangsa"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_North_Korea"></see>
    /// </summary>
    let Rank_Sangsa_North_Korea = _prefix "Rank_Sangsa_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_South_Korea"></see>
    /// </summary>
    let Rank_Sangsa_South_Korea = _prefix "Rank_Sangsa_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht`` = _prefix "Rank_Schout-bij-nacht"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Netherlands"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht_Netherlands`` =
        _prefix "Rank_Schout-bij-nacht_Netherlands"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Russia"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht_Russia`` = _prefix "Rank_Schout-bij-nacht_Russia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Soviet_Union"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht_Soviet_Union`` =
        _prefix "Rank_Schout-bij-nacht_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal"></see>
    /// </summary>
    let Rank_Second_Corporal = _prefix "Rank_Second_Corporal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_England"></see>
    /// </summary>
    let Rank_Second_Corporal_England = _prefix "Rank_Second_Corporal_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Scotland"></see>
    /// </summary>
    let Rank_Second_Corporal_Scotland = _prefix "Rank_Second_Corporal_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Wales"></see>
    /// </summary>
    let Rank_Second_Corporal_Wales = _prefix "Rank_Second_Corporal_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor = _prefix "Rank_Sergeant_Major_Instructor"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_England"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor_England =
        _prefix "Rank_Sergeant_Major_Instructor_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Scotland"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor_Scotland =
        _prefix "Rank_Sergeant_Major_Instructor_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Wales"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor_Wales =
        _prefix "Rank_Sergeant_Major_Instructor_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot"></see>
    /// </summary>
    let Rank_Sergeant_Pilot = _prefix "Rank_Sergeant_Pilot"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Australia"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Australia = _prefix "Rank_Sergeant_Pilot_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Canada"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Canada = _prefix "Rank_Sergeant_Pilot_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Commonwealth_of_Nations =
        _prefix "Rank_Sergeant_Pilot_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_England"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_England = _prefix "Rank_Sergeant_Pilot_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Scotland"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Scotland = _prefix "Rank_Sergeant_Pilot_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Wales"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Wales = _prefix "Rank_Sergeant_Pilot_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros"></see>
    /// </summary>
    let Rank_Skeuophoros = _prefix "Rank_Skeuophoros"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Achaean_League"></see>
    /// </summary>
    let Rank_Skeuophoros_Achaean_League = _prefix "Rank_Skeuophoros_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Macedonia"></see>
    /// </summary>
    let Rank_Skeuophoros_Macedonia = _prefix "Rank_Skeuophoros_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes"></see>
    /// </summary>
    let Rank_Somatophylakes = _prefix "Rank_Somatophylakes"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Achaean_League"></see>
    /// </summary>
    let Rank_Somatophylakes_Achaean_League =
        _prefix "Rank_Somatophylakes_Achaean_League"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Macedonia"></see>
    /// </summary>
    let Rank_Somatophylakes_Macedonia = _prefix "Rank_Somatophylakes_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik"></see>
    /// </summary>
    let Rank_Sotnik = _prefix "Rank_Sotnik"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Russia"></see>
    /// </summary>
    let Rank_Sotnik_Russia = _prefix "Rank_Sotnik_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Soviet_Union"></see>
    /// </summary>
    let Rank_Sotnik_Soviet_Union = _prefix "Rank_Sotnik_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Ukraine"></see>
    /// </summary>
    let Rank_Sotnik_Ukraine = _prefix "Rank_Sotnik_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi"></see>
    /// </summary>
    let Rank_Sowi = _prefix "Rank_Sowi"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_North_Korea"></see>
    /// </summary>
    let Rank_Sowi_North_Korea = _prefix "Rank_Sowi_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_South_Korea"></see>
    /// </summary>
    let Rank_Sowi_South_Korea = _prefix "Rank_Sowi_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten"></see>
    /// </summary>
    let Rank_Staabikapten = _prefix "Rank_Staabikapten"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Estonia"></see>
    /// </summary>
    let Rank_Staabikapten_Estonia = _prefix "Rank_Staabikapten_Estonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Staabikapten_Republic_of_Estonia_1920-1940`` =
        _prefix "Rank_Staabikapten_Republic_of_Estonia_1920-1940"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan"></see>
    /// </summary>
    let Rank_Stabskapitan = _prefix "Rank_Stabskapitan"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Germany"></see>
    /// </summary>
    let Rank_Stabskapitan_Germany = _prefix "Rank_Stabskapitan_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Russia"></see>
    /// </summary>
    let Rank_Stabskapitan_Russia = _prefix "Rank_Stabskapitan_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Soviet_Union"></see>
    /// </summary>
    let Rank_Stabskapitan_Soviet_Union = _prefix "Rank_Stabskapitan_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant_Germany"></see>
    /// </summary>
    let Rank_Stabskapitanleutnant_Germany = _prefix "Rank_Stabskapitanleutnant_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant"></see>
    /// </summary>
    let Rank_Stabskapitanleutnant = _prefix "Rank_Stabskapitanleutnant"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal"></see>
    /// </summary>
    let Rank_Staff_Corporal = _prefix "Rank_Staff_Corporal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_England"></see>
    /// </summary>
    let Rank_Staff_Corporal_England = _prefix "Rank_Staff_Corporal_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Scotland"></see>
    /// </summary>
    let Rank_Staff_Corporal_Scotland = _prefix "Rank_Staff_Corporal_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Wales"></see>
    /// </summary>
    let Rank_Staff_Corporal_Wales = _prefix "Rank_Staff_Corporal_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major = _prefix "Rank_Staff_Sergeant_Major"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_England"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major_England = _prefix "Rank_Staff_Sergeant_Major_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Scotland"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major_Scotland =
        _prefix "Rank_Staff_Sergeant_Major_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Wales"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major_Wales = _prefix "Rank_Staff_Sergeant_Major_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Australia"></see>
    /// </summary>
    let Rank_Staff_sergeant_Australia = _prefix "Rank_Staff_sergeant_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Canada"></see>
    /// </summary>
    let Rank_Staff_sergeant_Canada = _prefix "Rank_Staff_sergeant_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Staff_sergeant_Commonwealth_of_Nations =
        _prefix "Rank_Staff_sergeant_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Singapore"></see>
    /// </summary>
    let Rank_Staff_sergeant_Singapore = _prefix "Rank_Staff_sergeant_Singapore"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina"></see>
    /// </summary>
    let Rank_Starshina = _prefix "Rank_Starshina"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Russia"></see>
    /// </summary>
    let Rank_Starshina_Russia = _prefix "Rank_Starshina_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Soviet_Union"></see>
    /// </summary>
    let Rank_Starshina_Soviet_Union = _prefix "Rank_Starshina_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Ukraine"></see>
    /// </summary>
    let Rank_Starshina_Ukraine = _prefix "Rank_Starshina_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches"></see>
    /// </summary>
    let Rank_Stratarches = _prefix "Rank_Stratarches"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Stratarches_Byzantine_Empire = _prefix "Rank_Stratarches_Byzantine_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Greece"></see>
    /// </summary>
    let Rank_Stratarches_Greece = _prefix "Rank_Stratarches_Greece"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Stratarches_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Stratarches_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos"></see>
    /// </summary>
    let Rank_Strategos = _prefix "Rank_Strategos"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Achaean_League"></see>
    /// </summary>
    let Rank_Strategos_Achaean_League = _prefix "Rank_Strategos_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Strategos_Byzantine_Empire = _prefix "Rank_Strategos_Byzantine_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Greece"></see>
    /// </summary>
    let Rank_Strategos_Greece = _prefix "Rank_Strategos_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Macedonia"></see>
    /// </summary>
    let Rank_Strategos_Macedonia = _prefix "Rank_Strategos_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Strategos_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Strategos_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Strategos_autokrator_Byzantine_Empire =
        _prefix "Rank_Strategos_autokrator_Byzantine_Empire"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator"></see>
    /// </summary>
    let Rank_Strategos_autokrator = _prefix "Rank_Strategos_autokrator"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Suba%C5%9Fi"></see>
    /// </summary>
    let ``Rank_Suba%C5%9Fi`` = _prefix "Rank_Suba%C5%9Fi"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern"></see>
    /// </summary>
    let Rank_Subaltern = _prefix "Rank_Subaltern"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_England"></see>
    /// </summary>
    let Rank_Subaltern_England = _prefix "Rank_Subaltern_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Scotland"></see>
    /// </summary>
    let Rank_Subaltern_Scotland = _prefix "Rank_Subaltern_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Wales"></see>
    /// </summary>
    let Rank_Subaltern_Wales = _prefix "Rank_Subaltern_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Subasi_Cossack_Hetmanate = _prefix "Rank_Subasi_Cossack_Hetmanate"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi"></see>
    /// </summary>
    let Rank_Subasi = _prefix "Rank_Subasi"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Subasi_Ottoman_Empire = _prefix "Rank_Subasi_Ottoman_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Subasi_Septinsular_Republic = _prefix "Rank_Subasi_Septinsular_Republic"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis"></see>
    /// </summary>
    let Rank_Syntagmatarchis = _prefix "Rank_Syntagmatarchis"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Achaean_League"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Achaean_League =
        _prefix "Rank_Syntagmatarchis_Achaean_League"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Greece"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Greece = _prefix "Rank_Syntagmatarchis_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Macedonia"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Macedonia = _prefix "Rank_Syntagmatarchis_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis"></see>
    /// </summary>
    let Rank_Tagmatarchis = _prefix "Rank_Tagmatarchis"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Achaean_League"></see>
    /// </summary>
    let Rank_Tagmatarchis_Achaean_League = _prefix "Rank_Tagmatarchis_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Greece"></see>
    /// </summary>
    let Rank_Tagmatarchis_Greece = _prefix "Rank_Tagmatarchis_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Macedonia"></see>
    /// </summary>
    let Rank_Tagmatarchis_Macedonia = _prefix "Rank_Tagmatarchis_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch"></see>
    /// </summary>
    let Rank_Taxiarch = _prefix "Rank_Taxiarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Achaean_League"></see>
    /// </summary>
    let Rank_Taxiarch_Achaean_League = _prefix "Rank_Taxiarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Taxiarch_Byzantine_Empire = _prefix "Rank_Taxiarch_Byzantine_Empire"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Greece"></see>
    /// </summary>
    let Rank_Taxiarch_Greece = _prefix "Rank_Taxiarch_Greece"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Macedonia"></see>
    /// </summary>
    let Rank_Taxiarch_Macedonia = _prefix "Rank_Taxiarch_Macedonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Taxiarch_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Taxiarch_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch"></see>
    /// </summary>
    let Rank_Tetrarch = _prefix "Rank_Tetrarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Achaean_League"></see>
    /// </summary>
    let Rank_Tetrarch_Achaean_League = _prefix "Rank_Tetrarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Macedonia"></see>
    /// </summary>
    let Rank_Tetrarch_Macedonia = _prefix "Rank_Tetrarch_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch"></see>
    /// </summary>
    let Rank_Trierarch = _prefix "Rank_Trierarch"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Achaean_League"></see>
    /// </summary>
    let Rank_Trierarch_Achaean_League = _prefix "Rank_Trierarch_Achaean_League"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Macedonia"></see>
    /// </summary>
    let Rank_Trierarch_Macedonia = _prefix "Rank_Trierarch_Macedonia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Australia"></see>
    /// </summary>
    let Rank_Trooper_Australia = _prefix "Rank_Trooper_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Canada"></see>
    /// </summary>
    let Rank_Trooper_Canada = _prefix "Rank_Trooper_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Trooper_Commonwealth_of_Nations =
        _prefix "Rank_Trooper_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major"></see>
    /// </summary>
    let Rank_Trumpet_Major = _prefix "Rank_Trumpet_Major"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Trumpet_Major_Commonwealth_of_Nations =
        _prefix "Rank_Trumpet_Major_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_England"></see>
    /// </summary>
    let Rank_Trumpet_Major_England = _prefix "Rank_Trumpet_Major_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Scotland"></see>
    /// </summary>
    let Rank_Trumpet_Major_Scotland = _prefix "Rank_Trumpet_Major_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Wales"></see>
    /// </summary>
    let Rank_Trumpet_Major_Wales = _prefix "Rank_Trumpet_Major_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky"></see>
    /// </summary>
    let Rank_Tysyatsky = _prefix "Rank_Tysyatsky"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Russia"></see>
    /// </summary>
    let Rank_Tysyatsky_Russia = _prefix "Rank_Tysyatsky_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Soviet_Union"></see>
    /// </summary>
    let Rank_Tysyatsky_Soviet_Union = _prefix "Rank_Tysyatsky_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer"></see>
    /// </summary>
    let Rank_Under_Officer = _prefix "Rank_Under_Officer"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Australia"></see>
    /// </summary>
    let Rank_Under_Officer_Australia = _prefix "Rank_Under_Officer_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Under_Officer_Commonwealth_of_Nations =
        _prefix "Rank_Under_Officer_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_England"></see>
    /// </summary>
    let Rank_Under_Officer_England = _prefix "Rank_Under_Officer_England"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Scotland"></see>
    /// </summary>
    let Rank_Under_Officer_Scotland = _prefix "Rank_Under_Officer_Scotland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Wales"></see>
    /// </summary>
    let Rank_Under_Officer_Wales = _prefix "Rank_Under_Officer_Wales"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli"></see>
    /// </summary>
    let Rank_Vaapeli = _prefix "Rank_Vaapeli"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Finland"></see>
    /// </summary>
    let Rank_Vaapeli_Finland = _prefix "Rank_Vaapeli_Finland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Sweden"></see>
    /// </summary>
    let Rank_Vaapeli_Sweden = _prefix "Rank_Vaapeli_Sweden"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel"></see>
    /// </summary>
    let Rank_Veebel = _prefix "Rank_Veebel"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Estonia"></see>
    /// </summary>
    let Rank_Veebel_Estonia = _prefix "Rank_Veebel_Estonia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Veebel_Republic_of_Estonia_1920-1940`` =
        _prefix "Rank_Veebel_Republic_of_Estonia_1920-1940"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast`` = _prefix "Rank_Vice-Admiral_of_the_Coast"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_England"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast_England`` =
        _prefix "Rank_Vice-Admiral_of_the_Coast_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Scotland"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast_Scotland`` =
        _prefix "Rank_Vice-Admiral_of_the_Coast_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Wales"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast_Wales`` =
        _prefix "Rank_Vice-Admiral_of_the_Coast_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West`` = _prefix "Rank_Vice-Admiral_of_the_West"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_England"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West_England`` =
        _prefix "Rank_Vice-Admiral_of_the_West_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Scotland"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West_Scotland`` =
        _prefix "Rank_Vice-Admiral_of_the_West_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Wales"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West_Wales`` =
        _prefix "Rank_Vice-Admiral_of_the_West_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral"></see>
    /// </summary>
    let Rank_Vice_admiral = _prefix "Rank_Vice_admiral"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia"></see>
    /// </summary>
    let Rank_Vice_admiral_Australia = _prefix "Rank_Vice_admiral_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia_Australia"></see>
    /// </summary>
    let Rank_Vice_admiral_Australia_Australia =
        _prefix "Rank_Vice_admiral_Australia_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Canada"></see>
    /// </summary>
    let Rank_Vice_admiral_Canada = _prefix "Rank_Vice_admiral_Canada"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister"></see>
    /// </summary>
    let Rank_Wachtmeister = _prefix "Rank_Wachtmeister"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Germany"></see>
    /// </summary>
    let Rank_Wachtmeister_Germany = _prefix "Rank_Wachtmeister_Germany"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Russia"></see>
    /// </summary>
    let Rank_Wachtmeister_Russia = _prefix "Rank_Wachtmeister_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Soviet_Union"></see>
    /// </summary>
    let Rank_Wachtmeister_Soviet_Union = _prefix "Rank_Wachtmeister_Soviet_Union"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom =
        _prefix "Rank_Warrant_officer_United_Kingdom"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Australia"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Australia =
        _prefix "Rank_Warrant_officer_United_Kingdom_Australia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Canada"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Canada =
        _prefix "Rank_Warrant_officer_United_Kingdom_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations =
        _prefix "Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_England"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_England =
        _prefix "Rank_Warrant_officer_United_Kingdom_England"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Scotland"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Scotland =
        _prefix "Rank_Warrant_officer_United_Kingdom_Scotland"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Wales"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Wales =
        _prefix "Rank_Warrant_officer_United_Kingdom_Wales"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander"></see>
    /// </summary>
    let Rank_Wing_commander = _prefix "Rank_Wing_commander"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Australia"></see>
    /// </summary>
    let Rank_Wing_commander_Australia = _prefix "Rank_Wing_commander_Australia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Canada"></see>
    /// </summary>
    let Rank_Wing_commander_Canada = _prefix "Rank_Wing_commander_Canada"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Wing_commander_Commonwealth_of_Nations =
        _prefix "Rank_Wing_commander_Commonwealth_of_Nations"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski"></see>
    /// </summary>
    let Rank_Wojski = _prefix "Rank_Wojski"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Lithuania"></see>
    /// </summary>
    let Rank_Wojski_Lithuania = _prefix "Rank_Wojski_Lithuania"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Poland"></see>
    /// </summary>
    let Rank_Wojski_Poland = _prefix "Rank_Wojski_Poland"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu"></see>
    /// </summary>
    let Rank_Wonsu = _prefix "Rank_Wonsu"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_North_Korea"></see>
    /// </summary>
    let Rank_Wonsu_North_Korea = _prefix "Rank_Wonsu_North_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_South_Korea"></see>
    /// </summary>
    let Rank_Wonsu_South_Korea = _prefix "Rank_Wonsu_South_Korea"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul"></see>
    /// </summary>
    let Rank_Yesaul = _prefix "Rank_Yesaul"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Russia"></see>
    /// </summary>
    let Rank_Yesaul_Russia = _prefix "Rank_Yesaul_Russia"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Soviet_Union"></see>
    /// </summary>
    let Rank_Yesaul_Soviet_Union = _prefix "Rank_Yesaul_Soviet_Union"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Ukraine"></see>
    /// </summary>
    let Rank_Yesaul_Ukraine = _prefix "Rank_Yesaul_Ukraine"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos"></see>
    /// </summary>
    let Rank_Ypolochagos = _prefix "Rank_Ypolochagos"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Greece"></see>
    /// </summary>
    let Rank_Ypolochagos_Greece = _prefix "Rank_Ypolochagos_Greece"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Ypolochagos_Official_Timocracy_of_Sapinetia =
        _prefix "Rank_Ypolochagos_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Regiment"></see>
    /// </summary>
    let Regiment = _prefix "Regiment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RegimentalColours"></see>
    /// </summary>
    let RegimentalColours = _prefix "RegimentalColours"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Reservist"></see>
    /// </summary>
    let Reservist = _prefix "Reservist"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Ship"></see>
    /// </summary>
    let Ship = _prefix "Ship"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ShoreEstablishment"></see>
    /// </summary>
    let ShoreEstablishment = _prefix "ShoreEstablishment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#warship"></see>
    /// </summary>
    let warship = _prefix "warship"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ship"></see>
    /// </summary>
    let ship = _prefix "ship"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Spy"></see>
    /// </summary>
    let Spy = _prefix "Spy"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#SupplyTrain"></see>
    /// </summary>
    let SupplyTrain = _prefix "SupplyTrain"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Trade"></see>
    /// </summary>
    let Trade = _prefix "Trade"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#TrenchObstacle"></see>
    /// </summary>
    let TrenchObstacle = _prefix "TrenchObstacle"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#VolunteerSoldier"></see>
    /// </summary>
    let VolunteerSoldier = _prefix "VolunteerSoldier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#War"></see>
    /// </summary>
    let War = _prefix "War"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Weapon"></see>
    /// </summary>
    let Weapon = _prefix "Weapon"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#allegiance"></see>
    /// </summary>
    let allegiance = _prefix "allegiance"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#commanderInChiefOf"></see>
    /// </summary>
    let commanderInChiefOf = _prefix "commanderInChiefOf"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#hasCommanderInChief"></see>
    /// </summary>
    let hasCommanderInChief = _prefix "hasCommanderInChief"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#deathDay"></see>
    /// </summary>
    let deathDay = _prefix "deathDay"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#epauletDepiction"></see>
    /// </summary>
    let epauletDepiction = _prefix "epauletDepiction"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CommanderInChiefOf"></see>
    /// </summary>
    let CommanderInChiefOf = _prefix "CommanderInChiefOf"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#hasPrincipal"></see>
    /// </summary>
    let hasPrincipal = _prefix "hasPrincipal"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#hasUniform"></see>
    /// </summary>
    let hasUniform = _prefix "hasUniform"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#heldRank"></see>
    /// </summary>
    let heldRank = _prefix "heldRank"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#idANZACNumber"></see>
    /// </summary>
    let idANZACNumber = _prefix "idANZACNumber"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#inUse"></see>
    /// </summary>
    let inUse = _prefix "inUse"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#information"></see>
    /// </summary>
    let information = _prefix "information"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#militaryServiceNumber"></see>
    /// </summary>
    let militaryServiceNumber = _prefix "militaryServiceNumber"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#nextOfKin"></see>
    /// </summary>
    let nextOfKin = _prefix "nextOfKin"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#placeOfEnlistment"></see>
    /// </summary>
    let placeOfEnlistment = _prefix "placeOfEnlistment"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#spacethefinalfrontier"></see>
    /// </summary>
    let spacethefinalfrontier = _prefix "spacethefinalfrontier"
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#toUnit"></see>
    /// </summary>
    let toUnit = _prefix "toUnit"
