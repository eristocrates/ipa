namespace http.rdf.muninn_project.org.ontologies.military.hash

open DoxAletheia.Rdf_Vocabulary

module mil =
    let _namespace_name = "http://rdf.muninn-project.org/ontologies/military#"

    /// <summary>
    /// This object is void dataset container for covinience.
    /// <see href="http://rdf.muninn-project.org/ontologies/military#datasetdefinition"></see></summary>
    let datasetdefinition =
        Namespaced_IRI.parse _namespace_name "datasetdefinition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Lance_corporal_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndCorporal"></see>
    /// </summary>
    let _1AIFRank2ndCorporal =
        Namespaced_IRI.parse _namespace_name "1AIFRank2ndCorporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#rankOf"></see>
    /// </summary>
    let rankOf = Namespaced_IRI.parse _namespace_name "rankOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Infantry"></see>
    /// </summary>
    let Infantry = Namespaced_IRI.parse _namespace_name "Infantry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryAppointment"></see>
    /// </summary>
    let MilitaryAppointment =
        Namespaced_IRI.parse _namespace_name "MilitaryAppointment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Soldier"></see>
    /// </summary>
    let Soldier = Namespaced_IRI.parse _namespace_name "Soldier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryRank"></see>
    /// </summary>
    let MilitaryRank =
        Namespaced_IRI.parse _namespace_name "MilitaryRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Corporal_EnglishTradition"></see>
    /// </summary>
    let Rank_Corporal_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Corporal_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRank2ndLieutenant"></see>
    /// </summary>
    let _1AIFRank2ndLieutenant =
        Namespaced_IRI.parse _namespace_name "1AIFRank2ndLieutenant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_EnglishTradition"></see>
    /// </summary>
    let Rank_Lieutenant_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Lieutenant_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenant"></see>
    /// </summary>
    let _1AIFRankLieutenant =
        Namespaced_IRI.parse _namespace_name "1AIFRankLieutenant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAbleSeaman"></see>
    /// </summary>
    let _1AIFRankAbleSeaman =
        Namespaced_IRI.parse _namespace_name "1AIFRankAbleSeaman" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyServiceBranch"></see>
    /// </summary>
    let NavyServiceBranch =
        Namespaced_IRI.parse _namespace_name "NavyServiceBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrade"></see>
    /// </summary>
    let MilitaryTrade =
        Namespaced_IRI.parse _namespace_name "MilitaryTrade" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman"></see>
    /// </summary>
    let RankAbleSeaman =
        Namespaced_IRI.parse _namespace_name "RankAbleSeaman" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanic"></see>
    /// </summary>
    let _1AIFRankAirMechanic =
        Namespaced_IRI.parse _namespace_name "1AIFRankAirMechanic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ProtoAirForce"></see>
    /// </summary>
    let ProtoAirForce =
        Namespaced_IRI.parse _namespace_name "ProtoAirForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassI"></see>
    /// </summary>
    let _1AIFRankAirMechanicClassI =
        Namespaced_IRI.parse _namespace_name "1AIFRankAirMechanicClassI" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankAirMechanicClassII"></see>
    /// </summary>
    let _1AIFRankAirMechanicClassII =
        Namespaced_IRI.parse _namespace_name "1AIFRankAirMechanicClassII" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankBombardier"></see>
    /// </summary>
    let _1AIFRankBombardier =
        Namespaced_IRI.parse _namespace_name "1AIFRankBombardier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier"></see>
    /// </summary>
    let Rank_Bombardier =
        Namespaced_IRI.parse _namespace_name "Rank_Bombardier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCaptain"></see>
    /// </summary>
    let _1AIFRankCaptain =
        Namespaced_IRI.parse _namespace_name "1AIFRankCaptain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_EnglishTradition"></see>
    /// </summary>
    let Rank_Captain_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankChaplain"></see>
    /// </summary>
    let _1AIFRankChaplain =
        Namespaced_IRI.parse _namespace_name "1AIFRankChaplain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Chaplain"></see>
    /// </summary>
    let Chaplain = Namespaced_IRI.parse _namespace_name "Chaplain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanyQuartermasterSergeant"></see>
    /// </summary>
    let _1AIFRankCompanyQuartermasterSergeant =
        Namespaced_IRI.parse _namespace_name "1AIFRankCompanyQuartermasterSergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Company_Quartermaster_Sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCompanySergeantMajor"></see>
    /// </summary>
    let _1AIFRankCompanySergeantMajor =
        Namespaced_IRI.parse _namespace_name "1AIFRankCompanySergeantMajor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajor"></see>
    /// </summary>
    let RankCompanySergeantMajor =
        Namespaced_IRI.parse _namespace_name "RankCompanySergeantMajor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankCorporal"></see>
    /// </summary>
    let _1AIFRankCorporal =
        Namespaced_IRI.parse _namespace_name "1AIFRankCorporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankDriver"></see>
    /// </summary>
    let _1AIFRankDriver =
        Namespaced_IRI.parse _namespace_name "1AIFRankDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriver"></see>
    /// </summary>
    let RankDriver = Namespaced_IRI.parse _namespace_name "RankDriver" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankEngineer"></see>
    /// </summary>
    let _1AIFRankEngineer =
        Namespaced_IRI.parse _namespace_name "1AIFRankEngineer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankEngineer"></see>
    /// </summary>
    let RankEngineer =
        Namespaced_IRI.parse _namespace_name "RankEngineer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankGunner"></see>
    /// </summary>
    let _1AIFRankGunner =
        Namespaced_IRI.parse _namespace_name "1AIFRankGunner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Artillery"></see>
    /// </summary>
    let Artillery = Namespaced_IRI.parse _namespace_name "Artillery" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankGunner"></see>
    /// </summary>
    let RankGunner = Namespaced_IRI.parse _namespace_name "RankGunner" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceCorporal"></see>
    /// </summary>
    let _1AIFRankLanceCorporal =
        Namespaced_IRI.parse _namespace_name "1AIFRankLanceCorporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLanceSergeant"></see>
    /// </summary>
    let _1AIFRankLanceSergeant =
        Namespaced_IRI.parse _namespace_name "1AIFRankLanceSergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_EnglishTradition"></see>
    /// </summary>
    let Rank_Sergeant_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLeadingStoker"></see>
    /// </summary>
    let _1AIFRankLeadingStoker =
        Namespaced_IRI.parse _namespace_name "1AIFRankLeadingStoker" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLeadingStoker"></see>
    /// </summary>
    let RankLeadingStoker =
        Namespaced_IRI.parse _namespace_name "RankLeadingStoker" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankLieutenantColonel"></see>
    /// </summary>
    let _1AIFRankLieutenantColonel =
        Namespaced_IRI.parse _namespace_name "1AIFRankLieutenantColonel" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmy"></see>
    /// </summary>
    let RankLieutenantColonelArmy =
        Namespaced_IRI.parse _namespace_name "RankLieutenantColonelArmy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankMajor"></see>
    /// </summary>
    let _1AIFRankMajor =
        Namespaced_IRI.parse _namespace_name "1AIFRankMajor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_EnglishTradition"></see>
    /// </summary>
    let Rank_Major_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Major_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankNurse"></see>
    /// </summary>
    let _1AIFRankNurse =
        Namespaced_IRI.parse _namespace_name "1AIFRankNurse" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankPettyOfficer"></see>
    /// </summary>
    let _1AIFRankPettyOfficer =
        Namespaced_IRI.parse _namespace_name "1AIFRankPettyOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Petty_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Petty_officer_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Petty_officer_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankPrivate"></see>
    /// </summary>
    let _1AIFRankPrivate =
        Namespaced_IRI.parse _namespace_name "1AIFRankPrivate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_EnglishTradition"></see>
    /// </summary>
    let Rank_Private_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Private_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalQuartermasterSergeant"></see>
    /// </summary>
    let _1AIFRankRegimentalQuartermasterSergeant =
        Namespaced_IRI.parse _namespace_name "1AIFRankRegimentalQuartermasterSergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankRegimentalSergeantMajor"></see>
    /// </summary>
    let _1AIFRankRegimentalSergeantMajor =
        Namespaced_IRI.parse _namespace_name "1AIFRankRegimentalSergeantMajor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_sergeant_major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSapper"></see>
    /// </summary>
    let _1AIFRankSapper =
        Namespaced_IRI.parse _namespace_name "1AIFRankSapper" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSapper"></see>
    /// </summary>
    let RankSapper = Namespaced_IRI.parse _namespace_name "RankSapper" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeant"></see>
    /// </summary>
    let _1AIFRankSergeant =
        Namespaced_IRI.parse _namespace_name "1AIFRankSergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSergeantMajor"></see>
    /// </summary>
    let _1AIFRankSergeantMajor =
        Namespaced_IRI.parse _namespace_name "1AIFRankSergeantMajor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSergeant"></see>
    /// </summary>
    let RankSergeant =
        Namespaced_IRI.parse _namespace_name "RankSergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankSignaller"></see>
    /// </summary>
    let _1AIFRankSignaller =
        Namespaced_IRI.parse _namespace_name "1AIFRankSignaller" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSignaller"></see>
    /// </summary>
    let RankSignaller =
        Namespaced_IRI.parse _namespace_name "RankSignaller" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankStaffSergeant"></see>
    /// </summary>
    let _1AIFRankStaffSergeant =
        Namespaced_IRI.parse _namespace_name "1AIFRankStaffSergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant"></see>
    /// </summary>
    let Rank_Staff_sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankTrooper"></see>
    /// </summary>
    let _1AIFRankTrooper =
        Namespaced_IRI.parse _namespace_name "1AIFRankTrooper" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Cavalry"></see>
    /// </summary>
    let Cavalry = Namespaced_IRI.parse _namespace_name "Cavalry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper"></see>
    /// </summary>
    let Rank_Trooper =
        Namespaced_IRI.parse _namespace_name "Rank_Trooper" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficer"></see>
    /// </summary>
    let _1AIFRankWarrantOfficer =
        Namespaced_IRI.parse _namespace_name "1AIFRankWarrantOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#WarrantOfficer"></see>
    /// </summary>
    let WarrantOfficer =
        Namespaced_IRI.parse _namespace_name "WarrantOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#1AIFRankWarrantOfficerClass2"></see>
    /// </summary>
    let _1AIFRankWarrantOfficerClass2 =
        Namespaced_IRI.parse _namespace_name "1AIFRankWarrantOfficerClass2" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ActingRank"></see>
    /// </summary>
    let ActingRank = Namespaced_IRI.parse _namespace_name "ActingRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirDivision"></see>
    /// </summary>
    let AirDivision =
        Namespaced_IRI.parse _namespace_name "AirDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NamedAirForceUnit"></see>
    /// </summary>
    let NamedAirForceUnit =
        Namespaced_IRI.parse _namespace_name "NamedAirForceUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceServiceBranch"></see>
    /// </summary>
    let AirForceServiceBranch =
        Namespaced_IRI.parse _namespace_name "AirForceServiceBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceCommand"></see>
    /// </summary>
    let AirForceCommand =
        Namespaced_IRI.parse _namespace_name "AirForceCommand" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#TacticalAirForce"></see>
    /// </summary>
    let TacticalAirForce =
        Namespaced_IRI.parse _namespace_name "TacticalAirForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceDetail"></see>
    /// </summary>
    let AirForceDetail =
        Namespaced_IRI.parse _namespace_name "AirForceDetail" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceGroup"></see>
    /// </summary>
    let AirForceGroup =
        Namespaced_IRI.parse _namespace_name "AirForceGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceSquadron"></see>
    /// </summary>
    let AirForceSquadron =
        Namespaced_IRI.parse _namespace_name "AirForceSquadron" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmsType"></see>
    /// </summary>
    let ArmsType = Namespaced_IRI.parse _namespace_name "ArmsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryServiceBranch"></see>
    /// </summary>
    let MilitaryServiceBranch =
        Namespaced_IRI.parse _namespace_name "MilitaryServiceBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyInAir"></see>
    /// </summary>
    let FightsPrimarilyInAir =
        Namespaced_IRI.parse _namespace_name "FightsPrimarilyInAir" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Squadron"></see>
    /// </summary>
    let Squadron = Namespaced_IRI.parse _namespace_name "Squadron" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryFlightUnit"></see>
    /// </summary>
    let MilitaryFlightUnit =
        Namespaced_IRI.parse _namespace_name "MilitaryFlightUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceWing"></see>
    /// </summary>
    let AirForceWing =
        Namespaced_IRI.parse _namespace_name "AirForceWing" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceStation"></see>
    /// </summary>
    let AirForceStation =
        Namespaced_IRI.parse _namespace_name "AirForceStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AirForceStationRAF"></see>
    /// </summary>
    let AirForceStationRAF =
        Namespaced_IRI.parse _namespace_name "AirForceStationRAF" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Appointment"></see>
    /// </summary>
    let Appointment =
        Namespaced_IRI.parse _namespace_name "Appointment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Armor"></see>
    /// </summary>
    let Armor = Namespaced_IRI.parse _namespace_name "Armor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyCompany"></see>
    /// </summary>
    let ArmyCompany =
        Namespaced_IRI.parse _namespace_name "ArmyCompany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#nominalSize"></see>
    /// </summary>
    let nominalSize =
        Namespaced_IRI.parse _namespace_name "nominalSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Platoon"></see>
    /// </summary>
    let Platoon = Namespaced_IRI.parse _namespace_name "Platoon" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyServiceBranch"></see>
    /// </summary>
    let ArmyServiceBranch =
        Namespaced_IRI.parse _namespace_name "ArmyServiceBranch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Battalion"></see>
    /// </summary>
    let Battalion = Namespaced_IRI.parse _namespace_name "Battalion" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyFront"></see>
    /// </summary>
    let ArmyFront = Namespaced_IRI.parse _namespace_name "ArmyFront" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FieldArmy"></see>
    /// </summary>
    let FieldArmy = Namespaced_IRI.parse _namespace_name "FieldArmy" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyGroup"></see>
    /// </summary>
    let ArmyGroup = Namespaced_IRI.parse _namespace_name "ArmyGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmySection"></see>
    /// </summary>
    let ArmySection =
        Namespaced_IRI.parse _namespace_name "ArmySection" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#GroundBasedOrganization"></see>
    /// </summary>
    let GroundBasedOrganization =
        Namespaced_IRI.parse _namespace_name "GroundBasedOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInLand"></see>
    /// </summary>
    let FightsPrimarilyOnAndInLand =
        Namespaced_IRI.parse _namespace_name "FightsPrimarilyOnAndInLand" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmySquad"></see>
    /// </summary>
    let ArmySquad = Namespaced_IRI.parse _namespace_name "ArmySquad" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArmyTroop"></see>
    /// </summary>
    let ArmyTroop = Namespaced_IRI.parse _namespace_name "ArmyTroop" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBattery"></see>
    /// </summary>
    let ArtilleryBattery =
        Namespaced_IRI.parse _namespace_name "ArtilleryBattery" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBatteryDivision"></see>
    /// </summary>
    let ArtilleryBatteryDivision =
        Namespaced_IRI.parse _namespace_name "ArtilleryBatteryDivision" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ArtilleryEmplacement"></see>
    /// </summary>
    let ArtilleryEmplacement =
        Namespaced_IRI.parse _namespace_name "ArtilleryEmplacement" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#AssaultGroupInfantry"></see>
    /// </summary>
    let AssaultGroupInfantry =
        Namespaced_IRI.parse _namespace_name "AssaultGroupInfantry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Brigade"></see>
    /// </summary>
    let Brigade = Namespaced_IRI.parse _namespace_name "Brigade" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Battle"></see>
    /// </summary>
    let Battle = Namespaced_IRI.parse _namespace_name "Battle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryEvent"></see>
    /// </summary>
    let MilitaryEvent =
        Namespaced_IRI.parse _namespace_name "MilitaryEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BattleSpace"></see>
    /// </summary>
    let BattleSpace =
        Namespaced_IRI.parse _namespace_name "BattleSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BattleStandard"></see>
    /// </summary>
    let BattleStandard =
        Namespaced_IRI.parse _namespace_name "BattleStandard" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BrevetRank"></see>
    /// </summary>
    let BrevetRank = Namespaced_IRI.parse _namespace_name "BrevetRank" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Division"></see>
    /// </summary>
    let Division = Namespaced_IRI.parse _namespace_name "Division" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#BrigadeAirCorps"></see>
    /// </summary>
    let BrigadeAirCorps =
        Namespaced_IRI.parse _namespace_name "BrigadeAirCorps" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general"></see>
    /// </summary>
    let Rank_Brigadier_general =
        Namespaced_IRI.parse _namespace_name "Rank_Brigadier_general" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Campaign"></see>
    /// </summary>
    let Campaign = Namespaced_IRI.parse _namespace_name "Campaign" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CarrierBattleGroup"></see>
    /// </summary>
    let CarrierBattleGroup =
        Namespaced_IRI.parse _namespace_name "CarrierBattleGroup" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Flotilla"></see>
    /// </summary>
    let Flotilla = Namespaced_IRI.parse _namespace_name "Flotilla" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalTaskForce"></see>
    /// </summary>
    let NavalTaskForce =
        Namespaced_IRI.parse _namespace_name "NavalTaskForce" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CavalrySquadron"></see>
    /// </summary>
    let CavalrySquadron =
        Namespaced_IRI.parse _namespace_name "CavalrySquadron" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CavalryTroop"></see>
    /// </summary>
    let CavalryTroop =
        Namespaced_IRI.parse _namespace_name "CavalryTroop" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Civilian"></see>
    /// </summary>
    let Civilian = Namespaced_IRI.parse _namespace_name "Civilian" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Non-Combatant"></see>
    /// </summary>
    let ``Non-Combatant`` =
        Namespaced_IRI.parse _namespace_name "Non-Combatant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Combatant"></see>
    /// </summary>
    let Combatant = Namespaced_IRI.parse _namespace_name "Combatant" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Role"></see>
    /// </summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Corps"></see>
    /// </summary>
    let Corps = Namespaced_IRI.parse _namespace_name "Corps" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Corps_list"></see>
    /// </summary>
    let Corps_list = Namespaced_IRI.parse _namespace_name "Corps_list" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CorpsUnit"></see>
    /// </summary>
    let CorpsUnit = Namespaced_IRI.parse _namespace_name "CorpsUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CorpsFormation"></see>
    /// </summary>
    let CorpsFormation =
        Namespaced_IRI.parse _namespace_name "CorpsFormation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DemiBrigade"></see>
    /// </summary>
    let DemiBrigade =
        Namespaced_IRI.parse _namespace_name "DemiBrigade" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#regiment"></see>
    /// </summary>
    let regiment = Namespaced_IRI.parse _namespace_name "regiment" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Depot"></see>
    /// </summary>
    let Depot = Namespaced_IRI.parse _namespace_name "Depot" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Detachment"></see>
    /// </summary>
    let Detachment = Namespaced_IRI.parse _namespace_name "Detachment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryOrganization"></see>
    /// </summary>
    let MilitaryOrganization =
        Namespaced_IRI.parse _namespace_name "MilitaryOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalEstablishment"></see>
    /// </summary>
    let DivisionNavalEstablishment =
        Namespaced_IRI.parse _namespace_name "DivisionNavalEstablishment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Navy"></see>
    /// </summary>
    let Navy = Namespaced_IRI.parse _namespace_name "Navy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalSquadron"></see>
    /// </summary>
    let NavalSquadron =
        Namespaced_IRI.parse _namespace_name "NavalSquadron" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalUnit"></see>
    /// </summary>
    let DivisionNavalUnit =
        Namespaced_IRI.parse _namespace_name "DivisionNavalUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#DraftedSoldier"></see>
    /// </summary>
    let DraftedSoldier =
        Namespaced_IRI.parse _namespace_name "DraftedSoldier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RegularForceSoldier"></see>
    /// </summary>
    let RegularForceSoldier =
        Namespaced_IRI.parse _namespace_name "RegularForceSoldier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#EnglishTradition"></see>
    /// </summary>
    let EnglishTradition =
        Namespaced_IRI.parse _namespace_name "EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Enlisted"></see>
    /// </summary>
    let Enlisted = Namespaced_IRI.parse _namespace_name "Enlisted" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ExchangeOfficer"></see>
    /// </summary>
    let ExchangeOfficer =
        Namespaced_IRI.parse _namespace_name "ExchangeOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Officer"></see>
    /// </summary>
    let Officer = Namespaced_IRI.parse _namespace_name "Officer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FieldArtillery"></see>
    /// </summary>
    let FieldArtillery =
        Namespaced_IRI.parse _namespace_name "FieldArtillery" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FightsPrimarilyOnAndInWater"></see>
    /// </summary>
    let FightsPrimarilyOnAndInWater =
        Namespaced_IRI.parse _namespace_name "FightsPrimarilyOnAndInWater" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Fireteam"></see>
    /// </summary>
    let Fireteam = Namespaced_IRI.parse _namespace_name "Fireteam" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FlagOfficer"></see>
    /// </summary>
    let FlagOfficer =
        Namespaced_IRI.parse _namespace_name "FlagOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalOfficer"></see>
    /// </summary>
    let NavalOfficer =
        Namespaced_IRI.parse _namespace_name "NavalOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Frigate"></see>
    /// </summary>
    let Frigate = Namespaced_IRI.parse _namespace_name "Frigate" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Warship"></see>
    /// </summary>
    let Warship = Namespaced_IRI.parse _namespace_name "Warship" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#FrontLine"></see>
    /// </summary>
    let FrontLine = Namespaced_IRI.parse _namespace_name "FrontLine" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#WarTheater"></see>
    /// </summary>
    let WarTheater = Namespaced_IRI.parse _namespace_name "WarTheater" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Garrison"></see>
    /// </summary>
    let Garrison = Namespaced_IRI.parse _namespace_name "Garrison" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#GeneralOfficer"></see>
    /// </summary>
    let GeneralOfficer =
        Namespaced_IRI.parse _namespace_name "GeneralOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#GrandeBatterie"></see>
    /// </summary>
    let GrandeBatterie =
        Namespaced_IRI.parse _namespace_name "GrandeBatterie" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#HorseArtillery"></see>
    /// </summary>
    let HorseArtillery =
        Namespaced_IRI.parse _namespace_name "HorseArtillery" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#HouseholdCavalry"></see>
    /// </summary>
    let HouseholdCavalry =
        Namespaced_IRI.parse _namespace_name "HouseholdCavalry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Invasion"></see>
    /// </summary>
    let Invasion = Namespaced_IRI.parse _namespace_name "Invasion" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#LiaisonOfficer"></see>
    /// </summary>
    let LiaisonOfficer =
        Namespaced_IRI.parse _namespace_name "LiaisonOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#LightInfantry"></see>
    /// </summary>
    let LightInfantry =
        Namespaced_IRI.parse _namespace_name "LightInfantry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryAirborneFlight"></see>
    /// </summary>
    let MilitaryAirborneFlight =
        Namespaced_IRI.parse _namespace_name "MilitaryAirborneFlight" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryGroundFlight"></see>
    /// </summary>
    let MilitaryGroundFlight =
        Namespaced_IRI.parse _namespace_name "MilitaryGroundFlight" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryOperation"></see>
    /// </summary>
    let MilitaryOperation =
        Namespaced_IRI.parse _namespace_name "MilitaryOperation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryRaid"></see>
    /// </summary>
    let MilitaryRaid =
        Namespaced_IRI.parse _namespace_name "MilitaryRaid" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrench"></see>
    /// </summary>
    let MilitaryTrench =
        Namespaced_IRI.parse _namespace_name "MilitaryTrench" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MilitaryUniform"></see>
    /// </summary>
    let MilitaryUniform =
        Namespaced_IRI.parse _namespace_name "MilitaryUniform" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#MountainArtillery"></see>
    /// </summary>
    let MountainArtillery =
        Namespaced_IRI.parse _namespace_name "MountainArtillery" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-1"></see>
    /// </summary>
    let ``NatoRankOF-1`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-1" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRanks"></see>
    /// </summary>
    let NatoRanks = Namespaced_IRI.parse _namespace_name "NatoRanks" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-10"></see>
    /// </summary>
    let ``NatoRankOF-10`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-10" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-2"></see>
    /// </summary>
    let ``NatoRankOF-2`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-2" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Nato_Ranks"></see>
    /// </summary>
    let Nato_Ranks = Namespaced_IRI.parse _namespace_name "Nato_Ranks" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-3"></see>
    /// </summary>
    let ``NatoRankOF-3`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-3" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-4"></see>
    /// </summary>
    let ``NatoRankOF-4`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-4" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-5"></see>
    /// </summary>
    let ``NatoRankOF-5`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-5" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-6"></see>
    /// </summary>
    let ``NatoRankOF-6`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-6" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-7"></see>
    /// </summary>
    let ``NatoRankOF-7`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-7" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-8"></see>
    /// </summary>
    let ``NatoRankOF-8`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-8" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-9"></see>
    /// </summary>
    let ``NatoRankOF-9`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOF-9" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-1"></see>
    /// </summary>
    let ``NatoRankOR-1`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-1" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NonCommissionedOfficer"></see>
    /// </summary>
    let NonCommissionedOfficer =
        Namespaced_IRI.parse _namespace_name "NonCommissionedOfficer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-2"></see>
    /// </summary>
    let ``NatoRankOR-2`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-2" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-3"></see>
    /// </summary>
    let ``NatoRankOR-3`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-3" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-4"></see>
    /// </summary>
    let ``NatoRankOR-4`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-4" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-5"></see>
    /// </summary>
    let ``NatoRankOR-5`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-5" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-6"></see>
    /// </summary>
    let ``NatoRankOR-6`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-6" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-7"></see>
    /// </summary>
    let ``NatoRankOR-7`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-7" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-8"></see>
    /// </summary>
    let ``NatoRankOR-8`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-8" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-9"></see>
    /// </summary>
    let ``NatoRankOR-9`` =
        Namespaced_IRI.parse _namespace_name "NatoRankOR-9" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-1"></see>
    /// </summary>
    let ``NatoRankWO-1`` =
        Namespaced_IRI.parse _namespace_name "NatoRankWO-1" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-2"></see>
    /// </summary>
    let ``NatoRankWO-2`` =
        Namespaced_IRI.parse _namespace_name "NatoRankWO-2" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-3"></see>
    /// </summary>
    let ``NatoRankWO-3`` =
        Namespaced_IRI.parse _namespace_name "NatoRankWO-3" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-4"></see>
    /// </summary>
    let ``NatoRankWO-4`` =
        Namespaced_IRI.parse _namespace_name "NatoRankWO-4" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-5"></see>
    /// </summary>
    let ``NatoRankWO-5`` =
        Namespaced_IRI.parse _namespace_name "NatoRankWO-5" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalArtillery"></see>
    /// </summary>
    let NavalArtillery =
        Namespaced_IRI.parse _namespace_name "NavalArtillery" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalFleet"></see>
    /// </summary>
    let NavalFleet = Namespaced_IRI.parse _namespace_name "NavalFleet" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyBigFleet"></see>
    /// </summary>
    let NavyBigFleet =
        Namespaced_IRI.parse _namespace_name "NavyBigFleet" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#SeamanMilitary"></see>
    /// </summary>
    let SeamanMilitary =
        Namespaced_IRI.parse _namespace_name "SeamanMilitary" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavalRating"></see>
    /// </summary>
    let NavalRating =
        Namespaced_IRI.parse _namespace_name "NavalRating" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyAirStation"></see>
    /// </summary>
    let NavyAirStation =
        Namespaced_IRI.parse _namespace_name "NavyAirStation" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#NavyMerchant"></see>
    /// </summary>
    let NavyMerchant =
        Namespaced_IRI.parse _namespace_name "NavyMerchant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#WaterBasedOrganization"></see>
    /// </summary>
    let WaterBasedOrganization =
        Namespaced_IRI.parse _namespace_name "WaterBasedOrganization" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#PostToUnit"></see>
    /// </summary>
    let PostToUnit = Namespaced_IRI.parse _namespace_name "PostToUnit" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#PrivilegedCombatant"></see>
    /// </summary>
    let PrivilegedCombatant =
        Namespaced_IRI.parse _namespace_name "PrivilegedCombatant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#UnprivilegedCombatant"></see>
    /// </summary>
    let UnprivilegedCombatant =
        Namespaced_IRI.parse _namespace_name "UnprivilegedCombatant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank"></see>
    /// </summary>
    let Rank = Namespaced_IRI.parse _namespace_name "Rank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Canada"></see>
    /// </summary>
    let RankAbleSeaman_Canada =
        Namespaced_IRI.parse _namespace_name "RankAbleSeaman_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankAbleSeaman_Commonwealth_of_Nations"></see>
    /// </summary>
    let RankAbleSeaman_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "RankAbleSeaman_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBandsmanArmyCanada+"></see>
    /// </summary>
    let ``RankBandsmanArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankBandsmanArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBatterySergeantMajorArmyCanada"></see>
    /// </summary>
    let RankBatterySergeantMajorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankBatterySergeantMajorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBombardierArmyCanada"></see>
    /// </summary>
    let RankBombardierArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankBombardierArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBoyArmyCanada"></see>
    /// </summary>
    let RankBoyArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankBoyArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankBrigadierGeneralArmyCanada"></see>
    /// </summary>
    let RankBrigadierGeneralArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankBrigadierGeneralArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCadetArmyCanada"></see>
    /// </summary>
    let RankCadetArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankCadetArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainArmyCanada"></see>
    /// </summary>
    let RankCaptainArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankCaptainArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval"></see>
    /// </summary>
    let RankCaptainNaval =
        Namespaced_IRI.parse _namespace_name "RankCaptainNaval" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Australia"></see>
    /// </summary>
    let RankCaptainNaval_Australia =
        Namespaced_IRI.parse _namespace_name "RankCaptainNaval_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCaptainNaval_Canada"></see>
    /// </summary>
    let RankCaptainNaval_Canada =
        Namespaced_IRI.parse _namespace_name "RankCaptainNaval_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankChaplainArmyCanada"></see>
    /// </summary>
    let RankChaplainArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankChaplainArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankClerkArmyCanada+"></see>
    /// </summary>
    let ``RankClerkArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankClerkArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankColonelArmyCanada"></see>
    /// </summary>
    let RankColonelArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankColonelArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank"></see>
    /// </summary>
    let RankCombatMilitaryRank =
        Namespaced_IRI.parse _namespace_name "RankCombatMilitaryRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Russia"></see>
    /// </summary>
    let RankCombatMilitaryRank_Russia =
        Namespaced_IRI.parse _namespace_name "RankCombatMilitaryRank_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCombatMilitaryRank_Soviet_Union"></see>
    /// </summary>
    let RankCombatMilitaryRank_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "RankCombatMilitaryRank_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCommandant"></see>
    /// </summary>
    let RankCommandant =
        Namespaced_IRI.parse _namespace_name "RankCommandant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCommandant_France"></see>
    /// </summary>
    let RankCommandant_France =
        Namespaced_IRI.parse _namespace_name "RankCommandant_France" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCommandant_Republic_of_Ireland"></see>
    /// </summary>
    let RankCommandant_Republic_of_Ireland =
        Namespaced_IRI.parse _namespace_name "RankCommandant_Republic_of_Ireland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCompanyQuarterMasterSergeantArmyCanada+"></see>
    /// </summary>
    let ``RankCompanyQuarterMasterSergeantArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankCompanyQuarterMasterSergeantArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCompanySergeantMajorArmyCanada"></see>
    /// </summary>
    let RankCompanySergeantMajorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankCompanySergeantMajorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankConductorArmyCanada"></see>
    /// </summary>
    let RankConductorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankConductorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankCorporalArmyCanada+"></see>
    /// </summary>
    let ``RankCorporalArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankCorporalArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriverArmyCanada"></see>
    /// </summary>
    let RankDriverArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankDriverArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriver_Australia"></see>
    /// </summary>
    let RankDriver_Australia =
        Namespaced_IRI.parse _namespace_name "RankDriver_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankDriver_Canada"></see>
    /// </summary>
    let RankDriver_Canada =
        Namespaced_IRI.parse _namespace_name "RankDriver_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankGeneralArmyCanada"></see>
    /// </summary>
    let RankGeneralArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankGeneralArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankGunnerArmyCanada"></see>
    /// </summary>
    let RankGunnerArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankGunnerArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLanceCorporalArmyCanada"></see>
    /// </summary>
    let RankLanceCorporalArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankLanceCorporalArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLanceSergeantArmyCanada+"></see>
    /// </summary>
    let ``RankLanceSergeantArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankLanceSergeantArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankStoker"></see>
    /// </summary>
    let RankStoker = Namespaced_IRI.parse _namespace_name "RankStoker" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantArmyCanada"></see>
    /// </summary>
    let RankLieutenantArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankLieutenantArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada"></see>
    /// </summary>
    let RankLieutenantColonelArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankLieutenantColonelArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantColonelArmyCanada+"></see>
    /// </summary>
    let ``RankLieutenantColonelArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankLieutenantColonelArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankLieutenantGeneralArmyCanada"></see>
    /// </summary>
    let RankLieutenantGeneralArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankLieutenantGeneralArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankMajorArmyCanada"></see>
    /// </summary>
    let RankMajorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankMajorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankMasterGunnerArmyCanada"></see>
    /// </summary>
    let RankMasterGunnerArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankMasterGunnerArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankNursingSisterArmyCanada"></see>
    /// </summary>
    let RankNursingSisterArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankNursingSisterArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankOrderlyRoomSergeantArmyCanada"></see>
    /// </summary>
    let RankOrderlyRoomSergeantArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankOrderlyRoomSergeantArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankPioneerArmyCanada"></see>
    /// </summary>
    let RankPioneerArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankPioneerArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankPrivateArmyCanada"></see>
    /// </summary>
    let RankPrivateArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankPrivateArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantArmyCanada"></see>
    /// </summary>
    let RankQuartermasterSergeantArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankQuartermasterSergeantArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankQuartermasterSergeantMajorArmyCanada"></see>
    /// </summary>
    let RankQuartermasterSergeantMajorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankQuartermasterSergeantMajorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankRegimentalSergeantMajorArmyCanada"></see>
    /// </summary>
    let RankRegimentalSergeantMajorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankRegimentalSergeantMajorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankRiflemanArmyCanada"></see>
    /// </summary>
    let RankRiflemanArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankRiflemanArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSaddlerArmyCanada"></see>
    /// </summary>
    let RankSaddlerArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSaddlerArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSapperArmyCanada"></see>
    /// </summary>
    let RankSapperArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSapperArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankScoutArmyCanada"></see>
    /// </summary>
    let RankScoutArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankScoutArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSecondCorporalArmyCanada"></see>
    /// </summary>
    let RankSecondCorporalArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSecondCorporalArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSecondLieutenantArmyCanada"></see>
    /// </summary>
    let RankSecondLieutenantArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSecondLieutenantArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSergeantArmyCanada"></see>
    /// </summary>
    let RankSergeantArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSergeantArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSergeantMajorArmyCanada"></see>
    /// </summary>
    let RankSergeantMajorArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSergeantMajorArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSignallerArmyCanada"></see>
    /// </summary>
    let RankSignallerArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankSignallerArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankSquadronSergeantMajorArmyCanada+"></see>
    /// </summary>
    let ``RankSquadronSergeantMajorArmyCanada+`` =
        Namespaced_IRI.parse _namespace_name "RankSquadronSergeantMajorArmyCanada+" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankStaffSergeantArmyCanada"></see>
    /// </summary>
    let RankStaffSergeantArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankStaffSergeantArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankTrooperArmyCanada"></see>
    /// </summary>
    let RankTrooperArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankTrooperArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RankWarrantOfficerArmyCanada"></see>
    /// </summary>
    let RankWarrantOfficerArmyCanada =
        Namespaced_IRI.parse _namespace_name "RankWarrantOfficerArmyCanada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_EnglishTradition"></see>
    /// </summary>
    let Rank_Admiral_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Admiral_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_marshal_EnglishTradition"></see>
    /// </summary>
    let Rank_Air_marshal_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Air_marshal_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_General_officer_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_General_officer_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_fleet_EnglishTradition"></see>
    /// </summary>
    let Rank_Admiral_of_the_fleet_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Admiral_of_the_fleet_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commodore_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Commodore_(rank)_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Commodore_(rank)_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia"></see>
    /// </summary>
    let Rank_Admiral_of_the_Fleet_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Admiral_of_the_Fleet_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Russia"></see>
    /// </summary>
    let Rank_Admiral_of_the_Fleet_Russia_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Admiral_of_the_Fleet_Russia_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Admiral_of_the_Fleet_Russia_Soviet_Union"></see>
    /// </summary>
    let Rank_Admiral_of_the_Fleet_Russia_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Admiral_of_the_Fleet_Russia_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_air_force_EnglishTradition"></see>
    /// </summary>
    let Rank_Marshal_of_the_air_force_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Marshal_of_the_air_force_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Field_marshal_EnglishTradition"></see>
    /// </summary>
    let Rank_Field_marshal_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Field_marshal_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_EnglishTradition"></see>
    /// </summary>
    let Rank_Marshal_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Marshal_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha"></see>
    /// </summary>
    let Rank_Agha = Namespaced_IRI.parse _namespace_name "Rank_Agha" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Agha_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Agha_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Agha_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Agha_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Agha_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Agha_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Agha_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal"></see>
    /// </summary>
    let Rank_Air_chief_marshal =
        Namespaced_IRI.parse _namespace_name "Rank_Air_chief_marshal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Air_chief_marshal_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Australia_Australia"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Australia_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Air_chief_marshal_Australia_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Canada"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Air_chief_marshal_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_chief_marshal_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Air_chief_marshal_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Air_chief_marshal_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_commodore_EnglishTradition"></see>
    /// </summary>
    let Rank_Air_commodore_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Air_commodore_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_EnglishTradition"></see>
    /// </summary>
    let Rank_Brigadier_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Brigadier_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Group_captain_EnglishTradition"></see>
    /// </summary>
    let Rank_Group_captain_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Group_captain_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal`` =
        Namespaced_IRI.parse _namespace_name "Rank_Air_vice-marshal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Australia"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal_Australia`` =
        Namespaced_IRI.parse _namespace_name "Rank_Air_vice-marshal_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Canada"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal_Canada`` =
        Namespaced_IRI.parse _namespace_name "Rank_Air_vice-marshal_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Air_vice-marshal_Commonwealth_of_Nations"></see>
    /// </summary>
    let ``Rank_Air_vice-marshal_Commonwealth_of_Nations`` =
        Namespaced_IRI.parse _namespace_name "Rank_Air_vice-marshal_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aircraftman_EnglishTradition"></see>
    /// </summary>
    let Rank_Aircraftman_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Aircraftman_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Seaman_EnglishTradition"></see>
    /// </summary>
    let Rank_Seaman_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Seaman_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos"></see>
    /// </summary>
    let Rank_Anthypolochagos =
        Namespaced_IRI.parse _namespace_name "Rank_Anthypolochagos" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Greece"></see>
    /// </summary>
    let Rank_Anthypolochagos_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Anthypolochagos_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis"></see>
    /// </summary>
    let Rank_Antisyntagmatarchis =
        Namespaced_IRI.parse _namespace_name "Rank_Antisyntagmatarchis" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Greece"></see>
    /// </summary>
    let Rank_Antisyntagmatarchis_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Antisyntagmatarchis_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Italy"></see>
    /// </summary>
    let Rank_Appointee_Italy =
        Namespaced_IRI.parse _namespace_name "Rank_Appointee_Italy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee"></see>
    /// </summary>
    let Rank_Appointee =
        Namespaced_IRI.parse _namespace_name "Rank_Appointee" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Appointee_Switzerland"></see>
    /// </summary>
    let Rank_Appointee_Switzerland =
        Namespaced_IRI.parse _namespace_name "Rank_Appointee_Switzerland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia"></see>
    /// </summary>
    let Rank_Army_General_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Army_General_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Russia"></see>
    /// </summary>
    let Rank_Army_General_Russia_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Army_General_Russia_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Army_General_Russia_Soviet_Union"></see>
    /// </summary>
    let Rank_Army_General_Russia_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Army_General_Russia_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant"></see>
    /// </summary>
    let Rank_Aspirant =
        Namespaced_IRI.parse _namespace_name "Rank_Aspirant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_France"></see>
    /// </summary>
    let Rank_Aspirant_France =
        Namespaced_IRI.parse _namespace_name "Rank_Aspirant_France" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania"></see>
    /// </summary>
    let Rank_Aspirant_Romania =
        Namespaced_IRI.parse _namespace_name "Rank_Aspirant_Romania" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Aspirant_Romania_Romania"></see>
    /// </summary>
    let Rank_Aspirant_Romania_Romania =
        Namespaced_IRI.parse _namespace_name "Rank_Aspirant_Romania_Romania" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman"></see>
    /// </summary>
    let Rank_Ataman =
        Namespaced_IRI.parse _namespace_name "Rank_Ataman" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Russia"></see>
    /// </summary>
    let Rank_Ataman_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Ataman_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Soviet_Union"></see>
    /// </summary>
    let Rank_Ataman_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Ataman_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ataman_Ukraine"></see>
    /// </summary>
    let Rank_Ataman_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Ataman_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Battery_sergeant_major"></see>
    /// </summary>
    let Rank_Battery_sergeant_major =
        Namespaced_IRI.parse _namespace_name "Rank_Battery_sergeant_major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik"></see>
    /// </summary>
    let Rank_Birinci_Ferik =
        Namespaced_IRI.parse _namespace_name "Rank_Birinci_Ferik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Birinci_Ferik_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Birinci_Ferik_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Birinci_Ferik_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Birinci_Ferik_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Birinci_Ferik_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Birinci_Ferik_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Birinci_Ferik_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Australia"></see>
    /// </summary>
    let Rank_Bombardier_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Bombardier_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_%28rank%29"></see>
    /// </summary>
    let ``Rank_Bombardier_%28rank%29`` =
        Namespaced_IRI.parse _namespace_name "Rank_Bombardier_%28rank%29" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Canada"></see>
    /// </summary>
    let Rank_Bombardier_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Bombardier_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bombardier_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Bombardier_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Bombardier_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann"></see>
    /// </summary>
    let Rank_Bootsmann =
        Namespaced_IRI.parse _namespace_name "Rank_Bootsmann" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Germany"></see>
    /// </summary>
    let Rank_Bootsmann_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Bootsmann_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Russia"></see>
    /// </summary>
    let Rank_Bootsmann_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Bootsmann_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Bootsmann_Soviet_Union"></see>
    /// </summary>
    let Rank_Bootsmann_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Bootsmann_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General"></see>
    /// </summary>
    let Rank_Brigade_General =
        Namespaced_IRI.parse _namespace_name "Rank_Brigade_General" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Australia"></see>
    /// </summary>
    let Rank_Brigade_General_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Brigade_General_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigade_General_Canada"></see>
    /// </summary>
    let Rank_Brigade_General_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Brigade_General_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Colonel_EnglishTradition"></see>
    /// </summary>
    let Rank_Colonel_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Colonel_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Australia"></see>
    /// </summary>
    let Rank_Brigadier_general_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Brigadier_general_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Brigadier_general_Canada"></see>
    /// </summary>
    let Rank_Brigadier_general_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Brigadier_general_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy"></see>
    /// </summary>
    let Rank_Buffer_Navy =
        Namespaced_IRI.parse _namespace_name "Rank_Buffer_Navy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Australia"></see>
    /// </summary>
    let Rank_Buffer_Navy_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Buffer_Navy_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Buffer_Navy_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Buffer_Navy_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Buffer_Navy_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain"></see>
    /// </summary>
    let Rank_Captain =
        Namespaced_IRI.parse _namespace_name "Rank_Captain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_(naval)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Captain_(naval)_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_(naval)_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commander_EnglishTradition"></see>
    /// </summary>
    let Rank_Commander_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Commander_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Australia"></see>
    /// </summary>
    let Rank_Captain_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Canada"></see>
    /// </summary>
    let Rank_Captain_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_lieutenant_EnglishTradition"></see>
    /// </summary>
    let Rank_Flight_lieutenant_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Flight_lieutenant_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_(navy)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Lieutenant_(navy)_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Lieutenant_(navy)_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandant_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Commandant_(rank)_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Commandant_(rank)_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant"></see>
    /// </summary>
    let Rank_Captain_Lieutenant =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Lieutenant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Germany"></see>
    /// </summary>
    let Rank_Captain_Lieutenant_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Lieutenant_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Russia"></see>
    /// </summary>
    let Rank_Captain_Lieutenant_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Lieutenant_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Lieutenant_Soviet_Union"></see>
    /// </summary>
    let Rank_Captain_Lieutenant_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Lieutenant_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Captain_Republic_of_Ireland =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Republic_of_Ireland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Russia"></see>
    /// </summary>
    let Rank_Captain_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Singapore"></see>
    /// </summary>
    let Rank_Captain_Singapore =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Singapore" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Soviet_Union"></see>
    /// </summary>
    let Rank_Captain_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_Sweden"></see>
    /// </summary>
    let Rank_Captain_Sweden =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_Sweden" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant"></see>
    /// </summary>
    let Rank_Captain_lieutenant =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_lieutenant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Germany"></see>
    /// </summary>
    let Rank_Captain_lieutenant_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_lieutenant_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Russia"></see>
    /// </summary>
    let Rank_Captain_lieutenant_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_lieutenant_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Captain_lieutenant_Soviet_Union"></see>
    /// </summary>
    let Rank_Captain_lieutenant_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Captain_lieutenant_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal"></see>
    /// </summary>
    let Rank_Chief_Marshal =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_Marshal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Russia"></see>
    /// </summary>
    let Rank_Chief_Marshal_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_Marshal_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_Marshal_Soviet_Union"></see>
    /// </summary>
    let Rank_Chief_Marshal_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_Marshal_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer"></see>
    /// </summary>
    let Rank_Chief_petty_officer =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class_Canada"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_1st_class_Canada`` =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer,_1st_class_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_1st_class"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_1st_class`` =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer,_1st_class" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class_Canada"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_2nd_class_Canada`` =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer,_2nd_class_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer,_2nd_class"></see>
    /// </summary>
    let ``Rank_Chief_petty_officer,_2nd_class`` =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer,_2nd_class" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Australia"></see>
    /// </summary>
    let Rank_Chief_petty_officer_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Canada"></see>
    /// </summary>
    let Rank_Chief_petty_officer_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chief_petty_officer_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Chief_petty_officer_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Chief_petty_officer_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch"></see>
    /// </summary>
    let Rank_Chiliarch =
        Namespaced_IRI.parse _namespace_name "Rank_Chiliarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Achaean_League"></see>
    /// </summary>
    let Rank_Chiliarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Chiliarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Chiliarch_Byzantine_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Chiliarch_Byzantine_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Greece"></see>
    /// </summary>
    let Rank_Chiliarch_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Chiliarch_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Macedonia"></see>
    /// </summary>
    let Rank_Chiliarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Chiliarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chiliarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Chiliarch_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Chiliarch_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji"></see>
    /// </summary>
    let Rank_Chorbaji =
        Namespaced_IRI.parse _namespace_name "Rank_Chorbaji" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Chorbaji_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Chorbaji_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Chorbaji_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Chorbaji_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chorbaji_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Chorbaji_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Chorbaji_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy"></see>
    /// </summary>
    let Rank_Chowqzy =
        Namespaced_IRI.parse _namespace_name "Rank_Chowqzy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Poland"></see>
    /// </summary>
    let Rank_Chowqzy_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Chowqzy_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Russia"></see>
    /// </summary>
    let Rank_Chowqzy_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Chowqzy_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Soviet_Union"></see>
    /// </summary>
    let Rank_Chowqzy_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Chowqzy_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Chowqzy_Ukraine"></see>
    /// </summary>
    let Rank_Chowqzy_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Chowqzy_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_colonel_EnglishTradition"></see>
    /// </summary>
    let Rank_Lieutenant_colonel_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Lieutenant_colonel_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm"></see>
    /// </summary>
    let Rank_Comandarm =
        Namespaced_IRI.parse _namespace_name "Rank_Comandarm" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Russia"></see>
    /// </summary>
    let Rank_Comandarm_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Comandarm_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comandarm_Soviet_Union"></see>
    /// </summary>
    let Rank_Comandarm_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Comandarm_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig"></see>
    /// </summary>
    let Rank_Combrig =
        Namespaced_IRI.parse _namespace_name "Rank_Combrig" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Russia"></see>
    /// </summary>
    let Rank_Combrig_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Combrig_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Combrig_Soviet_Union"></see>
    /// </summary>
    let Rank_Combrig_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Combrig_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor"></see>
    /// </summary>
    let Rank_Comcor =
        Namespaced_IRI.parse _namespace_name "Rank_Comcor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Russia"></see>
    /// </summary>
    let Rank_Comcor_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Comcor_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comcor_Soviet_Union"></see>
    /// </summary>
    let Rank_Comcor_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Comcor_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv"></see>
    /// </summary>
    let Rank_Comdiv =
        Namespaced_IRI.parse _namespace_name "Rank_Comdiv" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Russia"></see>
    /// </summary>
    let Rank_Comdiv_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Comdiv_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Comdiv_Soviet_Union"></see>
    /// </summary>
    let Rank_Comdiv_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Comdiv_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lieutenant_commander_EnglishTradition"></see>
    /// </summary>
    let Rank_Lieutenant_commander_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Lieutenant_commander_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Squadron_leader_EnglishTradition"></see>
    /// </summary>
    let Rank_Squadron_leader_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Squadron_leader_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Wing_commander_(rank)_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Wing_commander_(rank)_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur"></see>
    /// </summary>
    let Rank_Commandeur =
        Namespaced_IRI.parse _namespace_name "Rank_Commandeur" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_France"></see>
    /// </summary>
    let Rank_Commandeur_France =
        Namespaced_IRI.parse _namespace_name "Rank_Commandeur_France" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Commandeur_Netherlands"></see>
    /// </summary>
    let Rank_Commandeur_Netherlands =
        Namespaced_IRI.parse _namespace_name "Rank_Commandeur_Netherlands" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_England"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_England =
        Namespaced_IRI.parse _namespace_name "Rank_Company_Quartermaster_Sergeant_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland =
        Namespaced_IRI.parse _namespace_name "Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Scotland"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Company_Quartermaster_Sergeant_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_Quartermaster_Sergeant_Wales"></see>
    /// </summary>
    let Rank_Company_Quartermaster_Sergeant_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Company_Quartermaster_Sergeant_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major"></see>
    /// </summary>
    let Rank_Company_sergeant_major =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Australia"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Canada"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_England"></see>
    /// </summary>
    let Rank_Company_sergeant_major_England =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Scotland"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Singapore"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Singapore =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_Singapore" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Company_sergeant_major_Wales"></see>
    /// </summary>
    let Rank_Company_sergeant_major_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Company_sergeant_major_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army"></see>
    /// </summary>
    let Rank_Conductor_army =
        Namespaced_IRI.parse _namespace_name "Rank_Conductor_army" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Australia"></see>
    /// </summary>
    let Rank_Conductor_army_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Conductor_army_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_England"></see>
    /// </summary>
    let Rank_Conductor_army_England =
        Namespaced_IRI.parse _namespace_name "Rank_Conductor_army_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Scotland"></see>
    /// </summary>
    let Rank_Conductor_army_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Conductor_army_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Conductor_army_Wales"></see>
    /// </summary>
    let Rank_Conductor_army_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Conductor_army_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_seaman_EnglishTradition"></see>
    /// </summary>
    let Rank_Leading_seaman_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Leading_seaman_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang"></see>
    /// </summary>
    let Rank_Daejang =
        Namespaced_IRI.parse _namespace_name "Rank_Daejang" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_North_Korea"></see>
    /// </summary>
    let Rank_Daejang_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Daejang_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daejang_South_Korea"></see>
    /// </summary>
    let Rank_Daejang_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Daejang_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar"></see>
    /// </summary>
    let Rank_Daffadar =
        Namespaced_IRI.parse _namespace_name "Rank_Daffadar" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Havildar"></see>
    /// </summary>
    let Rank_Havildar =
        Namespaced_IRI.parse _namespace_name "Rank_Havildar" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Daffadar_British_India"></see>
    /// </summary>
    let Rank_Daffadar_British_India =
        Namespaced_IRI.parse _namespace_name "Rank_Daffadar_British_India" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant"></see>
    /// </summary>
    let Rank_Sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral"></see>
    /// </summary>
    let Rank_Divisional_Admiral =
        Namespaced_IRI.parse _namespace_name "Rank_Divisional_Admiral" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Belgium"></see>
    /// </summary>
    let Rank_Divisional_Admiral_Belgium =
        Namespaced_IRI.parse _namespace_name "Rank_Divisional_Admiral_Belgium" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_Admiral_Italy"></see>
    /// </summary>
    let Rank_Divisional_Admiral_Italy =
        Namespaced_IRI.parse _namespace_name "Rank_Divisional_Admiral_Italy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General"></see>
    /// </summary>
    let Rank_Divisional_General =
        Namespaced_IRI.parse _namespace_name "Rank_Divisional_General" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_France"></see>
    /// </summary>
    let Rank_Divisional_General_France =
        Namespaced_IRI.parse _namespace_name "Rank_Divisional_General_France" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Divisional_General_Poland"></see>
    /// </summary>
    let Rank_Divisional_General_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Divisional_General_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General"></see>
    /// </summary>
    let Rank_Drum_Major_General =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_Major_General" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Drum_Major_General_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_Major_General_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_England"></see>
    /// </summary>
    let Rank_Drum_Major_General_England =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_Major_General_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Scotland"></see>
    /// </summary>
    let Rank_Drum_Major_General_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_Major_General_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_Major_General_Wales"></see>
    /// </summary>
    let Rank_Drum_Major_General_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_Major_General_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major"></see>
    /// </summary>
    let Rank_Drum_major =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Drum_major_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_major_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_England"></see>
    /// </summary>
    let Rank_Drum_major_England =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_major_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Scotland"></see>
    /// </summary>
    let Rank_Drum_major_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_major_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Drum_major_Wales"></see>
    /// </summary>
    let Rank_Drum_major_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Drum_major_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ensign_(rank)_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Ensign_(rank)_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Ensign_(rank)_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_lieutenant_EnglishTradition"></see>
    /// </summary>
    let Rank_Second_lieutenant_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Second_lieutenant_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pilot_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Pilot_officer_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Pilot_officer_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sub-lieutenant_EnglishTradition"></see>
    /// </summary>
    let ``Rank_Sub-lieutenant_EnglishTradition`` =
        Namespaced_IRI.parse _namespace_name "Rank_Sub-lieutenant_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Midshipman_EnglishTradition"></see>
    /// </summary>
    let Rank_Midshipman_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Midshipman_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch"></see>
    /// </summary>
    let Rank_Epihipparch =
        Namespaced_IRI.parse _namespace_name "Rank_Epihipparch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Achaean_League"></see>
    /// </summary>
    let Rank_Epihipparch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Epihipparch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Epihipparch_Macedonia"></see>
    /// </summary>
    let Rank_Epihipparch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Epihipparch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik"></see>
    /// </summary>
    let Rank_Ferik = Namespaced_IRI.parse _namespace_name "Rank_Ferik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Ferik_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Ferik_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Ferik_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Ferik_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ferik_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Ferik_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Ferik_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board"></see>
    /// </summary>
    let Rank_Fleet_Board =
        Namespaced_IRI.parse _namespace_name "Rank_Fleet_Board" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_England"></see>
    /// </summary>
    let Rank_Fleet_Board_England =
        Namespaced_IRI.parse _namespace_name "Rank_Fleet_Board_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Scotland"></see>
    /// </summary>
    let Rank_Fleet_Board_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Fleet_Board_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Fleet_Board_Wales"></see>
    /// </summary>
    let Rank_Fleet_Board_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Fleet_Board_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flying_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Flying_officer_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Flying_officer_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant"></see>
    /// </summary>
    let Rank_Flight_sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Flight_sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Australia"></see>
    /// </summary>
    let Rank_Flight_sergeant_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Flight_sergeant_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Canada"></see>
    /// </summary>
    let Rank_Flight_sergeant_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Flight_sergeant_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Flight_sergeant_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Flight_sergeant_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Flight_sergeant_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Flight_sergeant_Republic_of_Ireland =
        Namespaced_IRI.parse _namespace_name "Rank_Flight_sergeant_Republic_of_Ireland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major =
        Namespaced_IRI.parse _namespace_name "Rank_Garrison_Sergeant_Major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_England"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major_England =
        Namespaced_IRI.parse _namespace_name "Rank_Garrison_Sergeant_Major_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Scotland"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Garrison_Sergeant_Major_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Garrison_Sergeant_Major_Wales"></see>
    /// </summary>
    let Rank_Garrison_Sergeant_Major_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Garrison_Sergeant_Major_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter"></see>
    /// </summary>
    let Rank_Gefreiter =
        Namespaced_IRI.parse _namespace_name "Rank_Gefreiter" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Germany"></see>
    /// </summary>
    let Rank_Gefreiter_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Gefreiter_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Russia"></see>
    /// </summary>
    let Rank_Gefreiter_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Gefreiter_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Gefreiter_Soviet_Union"></see>
    /// </summary>
    let Rank_Gefreiter_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Gefreiter_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief"></see>
    /// </summary>
    let ``Rank_General-in-Chief`` =
        Namespaced_IRI.parse _namespace_name "Rank_General-in-Chief" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Russia"></see>
    /// </summary>
    let ``Rank_General-in-Chief_Russia`` =
        Namespaced_IRI.parse _namespace_name "Rank_General-in-Chief_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General-in-Chief_Soviet_Union"></see>
    /// </summary>
    let ``Rank_General-in-Chief_Soviet_Union`` =
        Namespaced_IRI.parse _namespace_name "Rank_General-in-Chief_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral"></see>
    /// </summary>
    let Rank_General_Admiral =
        Namespaced_IRI.parse _namespace_name "Rank_General_Admiral" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Germany"></see>
    /// </summary>
    let Rank_General_Admiral_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_General_Admiral_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Russia"></see>
    /// </summary>
    let Rank_General_Admiral_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_General_Admiral_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_General_Admiral_Soviet_Union"></see>
    /// </summary>
    let Rank_General_Admiral_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_General_Admiral_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa"></see>
    /// </summary>
    let Rank_Hasa = Namespaced_IRI.parse _namespace_name "Rank_Hasa" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_North_Korea"></see>
    /// </summary>
    let Rank_Hasa_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Hasa_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hasa_South_Korea"></see>
    /// </summary>
    let Rank_Hasa_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Hasa_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Havildar_British_India"></see>
    /// </summary>
    let Rank_Havildar_British_India =
        Namespaced_IRI.parse _namespace_name "Rank_Havildar_British_India" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman"></see>
    /// </summary>
    let Rank_Hetman =
        Namespaced_IRI.parse _namespace_name "Rank_Hetman" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Belarus"></see>
    /// </summary>
    let Rank_Hetman_Belarus =
        Namespaced_IRI.parse _namespace_name "Rank_Hetman_Belarus" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Lithuania"></see>
    /// </summary>
    let Rank_Hetman_Lithuania =
        Namespaced_IRI.parse _namespace_name "Rank_Hetman_Lithuania" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Poland"></see>
    /// </summary>
    let Rank_Hetman_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Hetman_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hetman_Ukraine"></see>
    /// </summary>
    let Rank_Hetman_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Hetman_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry"></see>
    /// </summary>
    let Rank_Hipparchus_Cavalry =
        Namespaced_IRI.parse _namespace_name "Rank_Hipparchus_Cavalry" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Achaean_League"></see>
    /// </summary>
    let Rank_Hipparchus_Cavalry_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Hipparchus_Cavalry_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Hipparchus_Cavalry_Macedonia"></see>
    /// </summary>
    let Rank_Hipparchus_Cavalry_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Hipparchus_Cavalry_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa"></see>
    /// </summary>
    let Rank_Jungsa =
        Namespaced_IRI.parse _namespace_name "Rank_Jungsa" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_North_Korea"></see>
    /// </summary>
    let Rank_Jungsa_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Jungsa_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungsa_South_Korea"></see>
    /// </summary>
    let Rank_Jungsa_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Jungsa_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi"></see>
    /// </summary>
    let Rank_Jungwi =
        Namespaced_IRI.parse _namespace_name "Rank_Jungwi" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_North_Korea"></see>
    /// </summary>
    let Rank_Jungwi_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Jungwi_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Jungwi_South_Korea"></see>
    /// </summary>
    let Rank_Jungwi_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Jungwi_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant"></see>
    /// </summary>
    let Rank_Junior_sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Junior_sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Estonia"></see>
    /// </summary>
    let Rank_Junior_sergeant_Estonia =
        Namespaced_IRI.parse _namespace_name "Rank_Junior_sergeant_Estonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junior_sergeant_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Junior_sergeant_Republic_of_Estonia_1920-1940`` =
        Namespaced_IRI.parse _namespace_name "Rank_Junior_sergeant_Republic_of_Estonia_1920-1940" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang"></see>
    /// </summary>
    let Rank_Junjang =
        Namespaced_IRI.parse _namespace_name "Rank_Junjang" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_North_Korea"></see>
    /// </summary>
    let Rank_Junjang_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Junjang_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Junjang_South_Korea"></see>
    /// </summary>
    let Rank_Junjang_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Junjang_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha"></see>
    /// </summary>
    let Rank_Kapudan_Pasha =
        Namespaced_IRI.parse _namespace_name "Rank_Kapudan_Pasha" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Kapudan_Pasha_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Kapudan_Pasha_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Kapudan_Pasha_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Kapudan_Pasha_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kapudan_Pasha_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Kapudan_Pasha_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Kapudan_Pasha_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral"></see>
    /// </summary>
    let Rank_Kindral =
        Namespaced_IRI.parse _namespace_name "Rank_Kindral" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Estonia"></see>
    /// </summary>
    let Rank_Kindral_Estonia =
        Namespaced_IRI.parse _namespace_name "Rank_Kindral_Estonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kindral_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Kindral_Republic_of_Estonia_1920-1940`` =
        Namespaced_IRI.parse _namespace_name "Rank_Kindral_Republic_of_Estonia_1920-1940" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi"></see>
    /// </summary>
    let Rank_Kolagasi =
        Namespaced_IRI.parse _namespace_name "Rank_Kolagasi" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Kolagasi_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Kolagasi_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Kolagasi_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Kolagasi_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolagasi_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Kolagasi_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Kolagasi_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel"></see>
    /// </summary>
    let Rank_Kolonel =
        Namespaced_IRI.parse _namespace_name "Rank_Kolonel" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Belgium"></see>
    /// </summary>
    let Rank_Kolonel_Belgium =
        Namespaced_IRI.parse _namespace_name "Rank_Kolonel_Belgium" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Estonia"></see>
    /// </summary>
    let Rank_Kolonel_Estonia =
        Namespaced_IRI.parse _namespace_name "Rank_Kolonel_Estonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Netherlands"></see>
    /// </summary>
    let Rank_Kolonel_Netherlands =
        Namespaced_IRI.parse _namespace_name "Rank_Kolonel_Netherlands" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Kolonel_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Kolonel_Republic_of_Estonia_1920-1940`` =
        Namespaced_IRI.parse _namespace_name "Rank_Kolonel_Republic_of_Estonia_1920-1940" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse`` =
        Namespaced_IRI.parse _namespace_name "Rank_Lance-corporal_of_horse" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_England"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse_England`` =
        Namespaced_IRI.parse _namespace_name "Rank_Lance-corporal_of_horse_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Scotland"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse_Scotland`` =
        Namespaced_IRI.parse _namespace_name "Rank_Lance-corporal_of_horse_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance-corporal_of_horse_Wales"></see>
    /// </summary>
    let ``Rank_Lance-corporal_of_horse_Wales`` =
        Namespaced_IRI.parse _namespace_name "Rank_Lance-corporal_of_horse_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal"></see>
    /// </summary>
    let Rank_Lance_corporal =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Australia"></see>
    /// </summary>
    let Rank_Lance_corporal_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_England"></see>
    /// </summary>
    let Rank_Lance_corporal_England =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Scotland"></see>
    /// </summary>
    let Rank_Lance_corporal_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Singapore"></see>
    /// </summary>
    let Rank_Lance_corporal_Singapore =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal_Singapore" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_corporal_Wales"></see>
    /// </summary>
    let Rank_Lance_corporal_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_corporal_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant"></see>
    /// </summary>
    let Rank_Lance_sergeant =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_sergeant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Australia"></see>
    /// </summary>
    let Rank_Lance_sergeant_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_sergeant_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Lance_sergeant_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_sergeant_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_England"></see>
    /// </summary>
    let Rank_Lance_sergeant_England =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_sergeant_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Scotland"></see>
    /// </summary>
    let Rank_Lance_sergeant_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_sergeant_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lance_sergeant_Wales"></see>
    /// </summary>
    let Rank_Lance_sergeant_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Lance_sergeant_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman"></see>
    /// </summary>
    let Rank_Leading_aircraftman =
        Namespaced_IRI.parse _namespace_name "Rank_Leading_aircraftman" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Australia"></see>
    /// </summary>
    let Rank_Leading_aircraftman_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Leading_aircraftman_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Canada"></see>
    /// </summary>
    let Rank_Leading_aircraftman_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Leading_aircraftman_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Leading_aircraftman_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Leading_aircraftman_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Leading_aircraftman_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos"></see>
    /// </summary>
    let Rank_Lochagos =
        Namespaced_IRI.parse _namespace_name "Rank_Lochagos" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Achaean_League"></see>
    /// </summary>
    let Rank_Lochagos_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Lochagos_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Greece"></see>
    /// </summary>
    let Rank_Lochagos_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Lochagos_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Macedonia"></see>
    /// </summary>
    let Rank_Lochagos_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Lochagos_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lochagos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Lochagos_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Lochagos_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash =
        Namespaced_IRI.parse _namespace_name "Rank_Lord_High_Admiral_of_the_Wash" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_England"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash_England =
        Namespaced_IRI.parse _namespace_name "Rank_Lord_High_Admiral_of_the_Wash_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Scotland"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Lord_High_Admiral_of_the_Wash_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Lord_High_Admiral_of_the_Wash_Wales"></see>
    /// </summary>
    let Rank_Lord_High_Admiral_of_the_Wash_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Lord_High_Admiral_of_the_Wash_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general"></see>
    /// </summary>
    let Rank_Major_general =
        Namespaced_IRI.parse _namespace_name "Rank_Major_general" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Australia"></see>
    /// </summary>
    let Rank_Major_general_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Major_general_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Major_general_Canada"></see>
    /// </summary>
    let Rank_Major_general_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Major_general_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union"></see>
    /// </summary>
    let Rank_Marshal_of_the_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Marshal_of_the_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Marshal_of_the_Soviet_Union_Soviet_Union"></see>
    /// </summary>
    let Rank_Marshal_of_the_Soviet_Union_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Marshal_of_the_Soviet_Union_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer"></see>
    /// </summary>
    let Rank_Master_warrant_officer =
        Namespaced_IRI.parse _namespace_name "Rank_Master_warrant_officer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Canada"></see>
    /// </summary>
    let Rank_Master_warrant_officer_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Master_warrant_officer_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Master_warrant_officer_Singapore"></see>
    /// </summary>
    let Rank_Master_warrant_officer_Singapore =
        Namespaced_IRI.parse _namespace_name "Rank_Master_warrant_officer_Singapore" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Officer_cadet_EnglishTradition"></see>
    /// </summary>
    let Rank_Officer_cadet_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Officer_cadet_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_EnglishTradition"></see>
    /// </summary>
    let Rank_Warrant_officer_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva"></see>
    /// </summary>
    let Rank_Mirliva =
        Namespaced_IRI.parse _namespace_name "Rank_Mirliva" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Mirliva_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Mirliva_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Mirliva_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Mirliva_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Mirliva_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Mirliva_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Mirliva_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir"></see>
    /// </summary>
    let Rank_Musir = Namespaced_IRI.parse _namespace_name "Rank_Musir" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Musir_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Musir_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Musir_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Musir_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Musir_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Musir_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Musir_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch"></see>
    /// </summary>
    let Rank_Navarch =
        Namespaced_IRI.parse _namespace_name "Rank_Navarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Achaean_League"></see>
    /// </summary>
    let Rank_Navarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Navarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Greece"></see>
    /// </summary>
    let Rank_Navarch_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Navarch_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Macedonia"></see>
    /// </summary>
    let Rank_Navarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Navarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Navarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Navarch_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Navarch_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter"></see>
    /// </summary>
    let Rank_Obergefreiter =
        Namespaced_IRI.parse _namespace_name "Rank_Obergefreiter" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Germany"></see>
    /// </summary>
    let Rank_Obergefreiter_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Obergefreiter_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Obergefreiter_Switzerland"></see>
    /// </summary>
    let Rank_Obergefreiter_Switzerland =
        Namespaced_IRI.parse _namespace_name "Rank_Obergefreiter_Switzerland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst"></see>
    /// </summary>
    let Rank_Oberst =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Austria"></see>
    /// </summary>
    let Rank_Oberst_Austria =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Austria" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Denmark"></see>
    /// </summary>
    let Rank_Oberst_Denmark =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Denmark" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Finland"></see>
    /// </summary>
    let Rank_Oberst_Finland =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Finland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Germany"></see>
    /// </summary>
    let Rank_Oberst_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Kingdom_of_Denmark"></see>
    /// </summary>
    let Rank_Oberst_Kingdom_of_Denmark =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Kingdom_of_Denmark" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Norway"></see>
    /// </summary>
    let Rank_Oberst_Norway =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Norway" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Sweden"></see>
    /// </summary>
    let Rank_Oberst_Sweden =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Sweden" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberst_Switzerland"></see>
    /// </summary>
    let Rank_Oberst_Switzerland =
        Namespaced_IRI.parse _namespace_name "Rank_Oberst_Switzerland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant_Germany"></see>
    /// </summary>
    let Rank_Oberstleutnant_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Oberstleutnant_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Oberstleutnant"></see>
    /// </summary>
    let Rank_Oberstleutnant =
        Namespaced_IRI.parse _namespace_name "Rank_Oberstleutnant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_major_EnglishTradition"></see>
    /// </summary>
    let Rank_Sergeant_major_EnglishTradition =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_major_EnglishTradition" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating =
        Namespaced_IRI.parse _namespace_name "Rank_Ordinary_seaman_rating" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Australia"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Ordinary_seaman_rating_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Canada"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Ordinary_seaman_rating_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ordinary_seaman_rating_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Ordinary_seaman_rating_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Ordinary_seaman_rating_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch"></see>
    /// </summary>
    let Rank_Phrourarch =
        Namespaced_IRI.parse _namespace_name "Rank_Phrourarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Achaean_League"></see>
    /// </summary>
    let Rank_Phrourarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Phrourarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Greece"></see>
    /// </summary>
    let Rank_Phrourarch_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Phrourarch_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Macedonia"></see>
    /// </summary>
    let Rank_Phrourarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Phrourarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Phrourarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Phrourarch_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Phrourarch_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major"></see>
    /// </summary>
    let Rank_Pipe_Major =
        Namespaced_IRI.parse _namespace_name "Rank_Pipe_Major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Pipe_Major_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Pipe_Major_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_England"></see>
    /// </summary>
    let Rank_Pipe_Major_England =
        Namespaced_IRI.parse _namespace_name "Rank_Pipe_Major_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Scotland"></see>
    /// </summary>
    let Rank_Pipe_Major_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Pipe_Major_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Pipe_Major_Wales"></see>
    /// </summary>
    let Rank_Pipe_Major_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Pipe_Major_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik"></see>
    /// </summary>
    let Rank_Podpolkovnik =
        Namespaced_IRI.parse _namespace_name "Rank_Podpolkovnik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Poland"></see>
    /// </summary>
    let Rank_Podpolkovnik_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Podpolkovnik_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Russia"></see>
    /// </summary>
    let Rank_Podpolkovnik_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Podpolkovnik_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Soviet_Union"></see>
    /// </summary>
    let Rank_Podpolkovnik_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Podpolkovnik_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpolkovnik_Ukraine"></see>
    /// </summary>
    let Rank_Podpolkovnik_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Podpolkovnik_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik"></see>
    /// </summary>
    let Rank_Podpraporshchik =
        Namespaced_IRI.parse _namespace_name "Rank_Podpraporshchik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Russia"></see>
    /// </summary>
    let Rank_Podpraporshchik_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Podpraporshchik_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Podpraporshchik_Soviet_Union"></see>
    /// </summary>
    let Rank_Podpraporshchik_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Podpraporshchik_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch"></see>
    /// </summary>
    let Rank_Polemarch =
        Namespaced_IRI.parse _namespace_name "Rank_Polemarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Achaean_League"></see>
    /// </summary>
    let Rank_Polemarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Polemarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polemarch_Macedonia"></see>
    /// </summary>
    let Rank_Polemarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Polemarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik"></see>
    /// </summary>
    let Rank_Polkovnik =
        Namespaced_IRI.parse _namespace_name "Rank_Polkovnik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Poland"></see>
    /// </summary>
    let Rank_Polkovnik_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Polkovnik_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Russia"></see>
    /// </summary>
    let Rank_Polkovnik_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Polkovnik_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Soviet_Union"></see>
    /// </summary>
    let Rank_Polkovnik_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Polkovnik_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Polkovnik_Ukraine"></see>
    /// </summary>
    let Rank_Polkovnik_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Polkovnik_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik"></see>
    /// </summary>
    let Rank_Poruchik =
        Namespaced_IRI.parse _namespace_name "Rank_Poruchik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Poland"></see>
    /// </summary>
    let Rank_Poruchik_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Poruchik_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Russia"></see>
    /// </summary>
    let Rank_Poruchik_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Poruchik_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Poruchik_Soviet_Union"></see>
    /// </summary>
    let Rank_Poruchik_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Poruchik_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik"></see>
    /// </summary>
    let Rank_Praporshchik =
        Namespaced_IRI.parse _namespace_name "Rank_Praporshchik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Russia"></see>
    /// </summary>
    let Rank_Praporshchik_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Praporshchik_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Praporshchik_Soviet_Union"></see>
    /// </summary>
    let Rank_Praporshchik_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Praporshchik_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private"></see>
    /// </summary>
    let Rank_Private =
        Namespaced_IRI.parse _namespace_name "Rank_Private" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Australia"></see>
    /// </summary>
    let Rank_Private_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Private_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Canada"></see>
    /// </summary>
    let Rank_Private_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Private_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_England"></see>
    /// </summary>
    let Rank_Private_England =
        Namespaced_IRI.parse _namespace_name "Rank_Private_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Private_Republic_of_Ireland =
        Namespaced_IRI.parse _namespace_name "Rank_Private_Republic_of_Ireland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Scotland"></see>
    /// </summary>
    let Rank_Private_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Private_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Private_Wales"></see>
    /// </summary>
    let Rank_Private_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Private_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral"></see>
    /// </summary>
    let Rank_Rear_admiral =
        Namespaced_IRI.parse _namespace_name "Rank_Rear_admiral" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Australia"></see>
    /// </summary>
    let Rank_Rear_admiral_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Rear_admiral_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Rear_admiral_Canada"></see>
    /// </summary>
    let Rank_Rear_admiral_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Rear_admiral_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Australia"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Canada"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_England"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_England =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Scotland"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_Quartermaster_Sergeant_Wales"></see>
    /// </summary>
    let Rank_Regimental_Quartermaster_Sergeant_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_Quartermaster_Sergeant_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Australia"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_sergeant_major_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_sergeant_major_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Regimental_sergeant_major_Singapore"></see>
    /// </summary>
    let Rank_Regimental_sergeant_major_Singapore =
        Namespaced_IRI.parse _namespace_name "Rank_Regimental_sergeant_major_Singapore" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa"></see>
    /// </summary>
    let Rank_Sangsa =
        Namespaced_IRI.parse _namespace_name "Rank_Sangsa" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_North_Korea"></see>
    /// </summary>
    let Rank_Sangsa_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Sangsa_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sangsa_South_Korea"></see>
    /// </summary>
    let Rank_Sangsa_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Sangsa_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht`` =
        Namespaced_IRI.parse _namespace_name "Rank_Schout-bij-nacht" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Netherlands"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht_Netherlands`` =
        Namespaced_IRI.parse _namespace_name "Rank_Schout-bij-nacht_Netherlands" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Russia"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht_Russia`` =
        Namespaced_IRI.parse _namespace_name "Rank_Schout-bij-nacht_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Schout-bij-nacht_Soviet_Union"></see>
    /// </summary>
    let ``Rank_Schout-bij-nacht_Soviet_Union`` =
        Namespaced_IRI.parse _namespace_name "Rank_Schout-bij-nacht_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal"></see>
    /// </summary>
    let Rank_Second_Corporal =
        Namespaced_IRI.parse _namespace_name "Rank_Second_Corporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_England"></see>
    /// </summary>
    let Rank_Second_Corporal_England =
        Namespaced_IRI.parse _namespace_name "Rank_Second_Corporal_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Scotland"></see>
    /// </summary>
    let Rank_Second_Corporal_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Second_Corporal_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Second_Corporal_Wales"></see>
    /// </summary>
    let Rank_Second_Corporal_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Second_Corporal_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Major_Instructor" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_England"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor_England =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Major_Instructor_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Scotland"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Major_Instructor_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Major_Instructor_Wales"></see>
    /// </summary>
    let Rank_Sergeant_Major_Instructor_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Major_Instructor_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot"></see>
    /// </summary>
    let Rank_Sergeant_Pilot =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Australia"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Canada"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_England"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_England =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Scotland"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sergeant_Pilot_Wales"></see>
    /// </summary>
    let Rank_Sergeant_Pilot_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Sergeant_Pilot_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros"></see>
    /// </summary>
    let Rank_Skeuophoros =
        Namespaced_IRI.parse _namespace_name "Rank_Skeuophoros" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Achaean_League"></see>
    /// </summary>
    let Rank_Skeuophoros_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Skeuophoros_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Skeuophoros_Macedonia"></see>
    /// </summary>
    let Rank_Skeuophoros_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Skeuophoros_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes"></see>
    /// </summary>
    let Rank_Somatophylakes =
        Namespaced_IRI.parse _namespace_name "Rank_Somatophylakes" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Achaean_League"></see>
    /// </summary>
    let Rank_Somatophylakes_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Somatophylakes_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Somatophylakes_Macedonia"></see>
    /// </summary>
    let Rank_Somatophylakes_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Somatophylakes_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik"></see>
    /// </summary>
    let Rank_Sotnik =
        Namespaced_IRI.parse _namespace_name "Rank_Sotnik" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Russia"></see>
    /// </summary>
    let Rank_Sotnik_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Sotnik_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Soviet_Union"></see>
    /// </summary>
    let Rank_Sotnik_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Sotnik_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sotnik_Ukraine"></see>
    /// </summary>
    let Rank_Sotnik_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Sotnik_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi"></see>
    /// </summary>
    let Rank_Sowi = Namespaced_IRI.parse _namespace_name "Rank_Sowi" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_North_Korea"></see>
    /// </summary>
    let Rank_Sowi_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Sowi_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Sowi_South_Korea"></see>
    /// </summary>
    let Rank_Sowi_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Sowi_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten"></see>
    /// </summary>
    let Rank_Staabikapten =
        Namespaced_IRI.parse _namespace_name "Rank_Staabikapten" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Estonia"></see>
    /// </summary>
    let Rank_Staabikapten_Estonia =
        Namespaced_IRI.parse _namespace_name "Rank_Staabikapten_Estonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staabikapten_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Staabikapten_Republic_of_Estonia_1920-1940`` =
        Namespaced_IRI.parse _namespace_name "Rank_Staabikapten_Republic_of_Estonia_1920-1940" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan"></see>
    /// </summary>
    let Rank_Stabskapitan =
        Namespaced_IRI.parse _namespace_name "Rank_Stabskapitan" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Germany"></see>
    /// </summary>
    let Rank_Stabskapitan_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Stabskapitan_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Russia"></see>
    /// </summary>
    let Rank_Stabskapitan_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Stabskapitan_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitan_Soviet_Union"></see>
    /// </summary>
    let Rank_Stabskapitan_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Stabskapitan_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant_Germany"></see>
    /// </summary>
    let Rank_Stabskapitanleutnant_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Stabskapitanleutnant_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stabskapitanleutnant"></see>
    /// </summary>
    let Rank_Stabskapitanleutnant =
        Namespaced_IRI.parse _namespace_name "Rank_Stabskapitanleutnant" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal"></see>
    /// </summary>
    let Rank_Staff_Corporal =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Corporal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_England"></see>
    /// </summary>
    let Rank_Staff_Corporal_England =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Corporal_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Scotland"></see>
    /// </summary>
    let Rank_Staff_Corporal_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Corporal_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Corporal_Wales"></see>
    /// </summary>
    let Rank_Staff_Corporal_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Corporal_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Sergeant_Major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_England"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major_England =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Sergeant_Major_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Scotland"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Sergeant_Major_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_Sergeant_Major_Wales"></see>
    /// </summary>
    let Rank_Staff_Sergeant_Major_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_Sergeant_Major_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Australia"></see>
    /// </summary>
    let Rank_Staff_sergeant_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_sergeant_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Canada"></see>
    /// </summary>
    let Rank_Staff_sergeant_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_sergeant_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Staff_sergeant_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_sergeant_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Staff_sergeant_Singapore"></see>
    /// </summary>
    let Rank_Staff_sergeant_Singapore =
        Namespaced_IRI.parse _namespace_name "Rank_Staff_sergeant_Singapore" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina"></see>
    /// </summary>
    let Rank_Starshina =
        Namespaced_IRI.parse _namespace_name "Rank_Starshina" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Russia"></see>
    /// </summary>
    let Rank_Starshina_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Starshina_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Soviet_Union"></see>
    /// </summary>
    let Rank_Starshina_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Starshina_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Starshina_Ukraine"></see>
    /// </summary>
    let Rank_Starshina_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Starshina_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches"></see>
    /// </summary>
    let Rank_Stratarches =
        Namespaced_IRI.parse _namespace_name "Rank_Stratarches" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Stratarches_Byzantine_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Stratarches_Byzantine_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Greece"></see>
    /// </summary>
    let Rank_Stratarches_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Stratarches_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Stratarches_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Stratarches_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Stratarches_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos"></see>
    /// </summary>
    let Rank_Strategos =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Achaean_League"></see>
    /// </summary>
    let Rank_Strategos_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Strategos_Byzantine_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_Byzantine_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Greece"></see>
    /// </summary>
    let Rank_Strategos_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Macedonia"></see>
    /// </summary>
    let Rank_Strategos_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Strategos_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Strategos_autokrator_Byzantine_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_autokrator_Byzantine_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Strategos_autokrator"></see>
    /// </summary>
    let Rank_Strategos_autokrator =
        Namespaced_IRI.parse _namespace_name "Rank_Strategos_autokrator" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Suba%C5%9Fi"></see>
    /// </summary>
    let ``Rank_Suba%C5%9Fi`` =
        Namespaced_IRI.parse _namespace_name "Rank_Suba%C5%9Fi" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern"></see>
    /// </summary>
    let Rank_Subaltern =
        Namespaced_IRI.parse _namespace_name "Rank_Subaltern" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_England"></see>
    /// </summary>
    let Rank_Subaltern_England =
        Namespaced_IRI.parse _namespace_name "Rank_Subaltern_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Scotland"></see>
    /// </summary>
    let Rank_Subaltern_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Subaltern_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subaltern_Wales"></see>
    /// </summary>
    let Rank_Subaltern_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Subaltern_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Cossack_Hetmanate"></see>
    /// </summary>
    let Rank_Subasi_Cossack_Hetmanate =
        Namespaced_IRI.parse _namespace_name "Rank_Subasi_Cossack_Hetmanate" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi"></see>
    /// </summary>
    let Rank_Subasi =
        Namespaced_IRI.parse _namespace_name "Rank_Subasi" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Ottoman_Empire"></see>
    /// </summary>
    let Rank_Subasi_Ottoman_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Subasi_Ottoman_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Subasi_Septinsular_Republic"></see>
    /// </summary>
    let Rank_Subasi_Septinsular_Republic =
        Namespaced_IRI.parse _namespace_name "Rank_Subasi_Septinsular_Republic" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis"></see>
    /// </summary>
    let Rank_Syntagmatarchis =
        Namespaced_IRI.parse _namespace_name "Rank_Syntagmatarchis" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Achaean_League"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Syntagmatarchis_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Greece"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Syntagmatarchis_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Macedonia"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Syntagmatarchis_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis"></see>
    /// </summary>
    let Rank_Tagmatarchis =
        Namespaced_IRI.parse _namespace_name "Rank_Tagmatarchis" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Achaean_League"></see>
    /// </summary>
    let Rank_Tagmatarchis_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Tagmatarchis_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Greece"></see>
    /// </summary>
    let Rank_Tagmatarchis_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Tagmatarchis_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Macedonia"></see>
    /// </summary>
    let Rank_Tagmatarchis_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Tagmatarchis_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch"></see>
    /// </summary>
    let Rank_Taxiarch =
        Namespaced_IRI.parse _namespace_name "Rank_Taxiarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Achaean_League"></see>
    /// </summary>
    let Rank_Taxiarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Taxiarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Byzantine_Empire"></see>
    /// </summary>
    let Rank_Taxiarch_Byzantine_Empire =
        Namespaced_IRI.parse _namespace_name "Rank_Taxiarch_Byzantine_Empire" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Greece"></see>
    /// </summary>
    let Rank_Taxiarch_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Taxiarch_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Macedonia"></see>
    /// </summary>
    let Rank_Taxiarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Taxiarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Taxiarch_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Taxiarch_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Taxiarch_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch"></see>
    /// </summary>
    let Rank_Tetrarch =
        Namespaced_IRI.parse _namespace_name "Rank_Tetrarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Achaean_League"></see>
    /// </summary>
    let Rank_Tetrarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Tetrarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tetrarch_Macedonia"></see>
    /// </summary>
    let Rank_Tetrarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Tetrarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch"></see>
    /// </summary>
    let Rank_Trierarch =
        Namespaced_IRI.parse _namespace_name "Rank_Trierarch" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Achaean_League"></see>
    /// </summary>
    let Rank_Trierarch_Achaean_League =
        Namespaced_IRI.parse _namespace_name "Rank_Trierarch_Achaean_League" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trierarch_Macedonia"></see>
    /// </summary>
    let Rank_Trierarch_Macedonia =
        Namespaced_IRI.parse _namespace_name "Rank_Trierarch_Macedonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Australia"></see>
    /// </summary>
    let Rank_Trooper_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Trooper_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Canada"></see>
    /// </summary>
    let Rank_Trooper_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Trooper_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trooper_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Trooper_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Trooper_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major"></see>
    /// </summary>
    let Rank_Trumpet_Major =
        Namespaced_IRI.parse _namespace_name "Rank_Trumpet_Major" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Trumpet_Major_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Trumpet_Major_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_England"></see>
    /// </summary>
    let Rank_Trumpet_Major_England =
        Namespaced_IRI.parse _namespace_name "Rank_Trumpet_Major_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Scotland"></see>
    /// </summary>
    let Rank_Trumpet_Major_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Trumpet_Major_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Trumpet_Major_Wales"></see>
    /// </summary>
    let Rank_Trumpet_Major_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Trumpet_Major_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky"></see>
    /// </summary>
    let Rank_Tysyatsky =
        Namespaced_IRI.parse _namespace_name "Rank_Tysyatsky" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Russia"></see>
    /// </summary>
    let Rank_Tysyatsky_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Tysyatsky_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Tysyatsky_Soviet_Union"></see>
    /// </summary>
    let Rank_Tysyatsky_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Tysyatsky_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer"></see>
    /// </summary>
    let Rank_Under_Officer =
        Namespaced_IRI.parse _namespace_name "Rank_Under_Officer" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Australia"></see>
    /// </summary>
    let Rank_Under_Officer_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Under_Officer_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Under_Officer_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Under_Officer_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_England"></see>
    /// </summary>
    let Rank_Under_Officer_England =
        Namespaced_IRI.parse _namespace_name "Rank_Under_Officer_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Scotland"></see>
    /// </summary>
    let Rank_Under_Officer_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Under_Officer_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Under_Officer_Wales"></see>
    /// </summary>
    let Rank_Under_Officer_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Under_Officer_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli"></see>
    /// </summary>
    let Rank_Vaapeli =
        Namespaced_IRI.parse _namespace_name "Rank_Vaapeli" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Finland"></see>
    /// </summary>
    let Rank_Vaapeli_Finland =
        Namespaced_IRI.parse _namespace_name "Rank_Vaapeli_Finland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vaapeli_Sweden"></see>
    /// </summary>
    let Rank_Vaapeli_Sweden =
        Namespaced_IRI.parse _namespace_name "Rank_Vaapeli_Sweden" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel"></see>
    /// </summary>
    let Rank_Veebel =
        Namespaced_IRI.parse _namespace_name "Rank_Veebel" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Estonia"></see>
    /// </summary>
    let Rank_Veebel_Estonia =
        Namespaced_IRI.parse _namespace_name "Rank_Veebel_Estonia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Veebel_Republic_of_Estonia_1920-1940"></see>
    /// </summary>
    let ``Rank_Veebel_Republic_of_Estonia_1920-1940`` =
        Namespaced_IRI.parse _namespace_name "Rank_Veebel_Republic_of_Estonia_1920-1940" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_Coast" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_England"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast_England`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_Coast_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Scotland"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast_Scotland`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_Coast_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_Coast_Wales"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_Coast_Wales`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_Coast_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_West" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_England"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West_England`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_West_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Scotland"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West_Scotland`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_West_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice-Admiral_of_the_West_Wales"></see>
    /// </summary>
    let ``Rank_Vice-Admiral_of_the_West_Wales`` =
        Namespaced_IRI.parse _namespace_name "Rank_Vice-Admiral_of_the_West_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral"></see>
    /// </summary>
    let Rank_Vice_admiral =
        Namespaced_IRI.parse _namespace_name "Rank_Vice_admiral" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia"></see>
    /// </summary>
    let Rank_Vice_admiral_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Vice_admiral_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Australia_Australia"></see>
    /// </summary>
    let Rank_Vice_admiral_Australia_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Vice_admiral_Australia_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Vice_admiral_Canada"></see>
    /// </summary>
    let Rank_Vice_admiral_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Vice_admiral_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister"></see>
    /// </summary>
    let Rank_Wachtmeister =
        Namespaced_IRI.parse _namespace_name "Rank_Wachtmeister" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Germany"></see>
    /// </summary>
    let Rank_Wachtmeister_Germany =
        Namespaced_IRI.parse _namespace_name "Rank_Wachtmeister_Germany" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Russia"></see>
    /// </summary>
    let Rank_Wachtmeister_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Wachtmeister_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wachtmeister_Soviet_Union"></see>
    /// </summary>
    let Rank_Wachtmeister_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Wachtmeister_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Australia"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Canada"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_England"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_England =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom_England" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Scotland"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Scotland =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom_Scotland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Warrant_officer_United_Kingdom_Wales"></see>
    /// </summary>
    let Rank_Warrant_officer_United_Kingdom_Wales =
        Namespaced_IRI.parse _namespace_name "Rank_Warrant_officer_United_Kingdom_Wales" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander"></see>
    /// </summary>
    let Rank_Wing_commander =
        Namespaced_IRI.parse _namespace_name "Rank_Wing_commander" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Australia"></see>
    /// </summary>
    let Rank_Wing_commander_Australia =
        Namespaced_IRI.parse _namespace_name "Rank_Wing_commander_Australia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Canada"></see>
    /// </summary>
    let Rank_Wing_commander_Canada =
        Namespaced_IRI.parse _namespace_name "Rank_Wing_commander_Canada" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wing_commander_Commonwealth_of_Nations"></see>
    /// </summary>
    let Rank_Wing_commander_Commonwealth_of_Nations =
        Namespaced_IRI.parse _namespace_name "Rank_Wing_commander_Commonwealth_of_Nations" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski"></see>
    /// </summary>
    let Rank_Wojski =
        Namespaced_IRI.parse _namespace_name "Rank_Wojski" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Lithuania"></see>
    /// </summary>
    let Rank_Wojski_Lithuania =
        Namespaced_IRI.parse _namespace_name "Rank_Wojski_Lithuania" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wojski_Poland"></see>
    /// </summary>
    let Rank_Wojski_Poland =
        Namespaced_IRI.parse _namespace_name "Rank_Wojski_Poland" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu"></see>
    /// </summary>
    let Rank_Wonsu = Namespaced_IRI.parse _namespace_name "Rank_Wonsu" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_North_Korea"></see>
    /// </summary>
    let Rank_Wonsu_North_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Wonsu_North_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Wonsu_South_Korea"></see>
    /// </summary>
    let Rank_Wonsu_South_Korea =
        Namespaced_IRI.parse _namespace_name "Rank_Wonsu_South_Korea" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul"></see>
    /// </summary>
    let Rank_Yesaul =
        Namespaced_IRI.parse _namespace_name "Rank_Yesaul" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Russia"></see>
    /// </summary>
    let Rank_Yesaul_Russia =
        Namespaced_IRI.parse _namespace_name "Rank_Yesaul_Russia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Soviet_Union"></see>
    /// </summary>
    let Rank_Yesaul_Soviet_Union =
        Namespaced_IRI.parse _namespace_name "Rank_Yesaul_Soviet_Union" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Yesaul_Ukraine"></see>
    /// </summary>
    let Rank_Yesaul_Ukraine =
        Namespaced_IRI.parse _namespace_name "Rank_Yesaul_Ukraine" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos"></see>
    /// </summary>
    let Rank_Ypolochagos =
        Namespaced_IRI.parse _namespace_name "Rank_Ypolochagos" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Greece"></see>
    /// </summary>
    let Rank_Ypolochagos_Greece =
        Namespaced_IRI.parse _namespace_name "Rank_Ypolochagos_Greece" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Rank_Ypolochagos_Official_Timocracy_of_Sapinetia"></see>
    /// </summary>
    let Rank_Ypolochagos_Official_Timocracy_of_Sapinetia =
        Namespaced_IRI.parse _namespace_name "Rank_Ypolochagos_Official_Timocracy_of_Sapinetia" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Regiment"></see>
    /// </summary>
    let Regiment = Namespaced_IRI.parse _namespace_name "Regiment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#RegimentalColours"></see>
    /// </summary>
    let RegimentalColours =
        Namespaced_IRI.parse _namespace_name "RegimentalColours" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Reservist"></see>
    /// </summary>
    let Reservist = Namespaced_IRI.parse _namespace_name "Reservist" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Ship"></see>
    /// </summary>
    let Ship = Namespaced_IRI.parse _namespace_name "Ship" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ShoreEstablishment"></see>
    /// </summary>
    let ShoreEstablishment =
        Namespaced_IRI.parse _namespace_name "ShoreEstablishment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#warship"></see>
    /// </summary>
    let warship = Namespaced_IRI.parse _namespace_name "warship" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#ship"></see>
    /// </summary>
    let ship = Namespaced_IRI.parse _namespace_name "ship" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Spy"></see>
    /// </summary>
    let Spy = Namespaced_IRI.parse _namespace_name "Spy" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#SupplyTrain"></see>
    /// </summary>
    let SupplyTrain =
        Namespaced_IRI.parse _namespace_name "SupplyTrain" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Trade"></see>
    /// </summary>
    let Trade = Namespaced_IRI.parse _namespace_name "Trade" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#TrenchObstacle"></see>
    /// </summary>
    let TrenchObstacle =
        Namespaced_IRI.parse _namespace_name "TrenchObstacle" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#VolunteerSoldier"></see>
    /// </summary>
    let VolunteerSoldier =
        Namespaced_IRI.parse _namespace_name "VolunteerSoldier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#War"></see>
    /// </summary>
    let War = Namespaced_IRI.parse _namespace_name "War" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#Weapon"></see>
    /// </summary>
    let Weapon = Namespaced_IRI.parse _namespace_name "Weapon" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#allegiance"></see>
    /// </summary>
    let allegiance = Namespaced_IRI.parse _namespace_name "allegiance" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#commanderInChiefOf"></see>
    /// </summary>
    let commanderInChiefOf =
        Namespaced_IRI.parse _namespace_name "commanderInChiefOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#hasCommanderInChief"></see>
    /// </summary>
    let hasCommanderInChief =
        Namespaced_IRI.parse _namespace_name "hasCommanderInChief" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#deathDay"></see>
    /// </summary>
    let deathDay = Namespaced_IRI.parse _namespace_name "deathDay" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#epauletDepiction"></see>
    /// </summary>
    let epauletDepiction =
        Namespaced_IRI.parse _namespace_name "epauletDepiction" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#CommanderInChiefOf"></see>
    /// </summary>
    let CommanderInChiefOf =
        Namespaced_IRI.parse _namespace_name "CommanderInChiefOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#hasPrincipal"></see>
    /// </summary>
    let hasPrincipal =
        Namespaced_IRI.parse _namespace_name "hasPrincipal" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#hasUniform"></see>
    /// </summary>
    let hasUniform = Namespaced_IRI.parse _namespace_name "hasUniform" |> NamespacedName
    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#heldRank"></see>
    /// </summary>
    let heldRank = Namespaced_IRI.parse _namespace_name "heldRank" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#idANZACNumber"></see>
    /// </summary>
    let idANZACNumber =
        Namespaced_IRI.parse _namespace_name "idANZACNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#inUse"></see>
    /// </summary>
    let inUse = Namespaced_IRI.parse _namespace_name "inUse" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#information"></see>
    /// </summary>
    let information =
        Namespaced_IRI.parse _namespace_name "information" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#militaryServiceNumber"></see>
    /// </summary>
    let militaryServiceNumber =
        Namespaced_IRI.parse _namespace_name "militaryServiceNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#nextOfKin"></see>
    /// </summary>
    let nextOfKin = Namespaced_IRI.parse _namespace_name "nextOfKin" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#placeOfEnlistment"></see>
    /// </summary>
    let placeOfEnlistment =
        Namespaced_IRI.parse _namespace_name "placeOfEnlistment" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#spacethefinalfrontier"></see>
    /// </summary>
    let spacethefinalfrontier =
        Namespaced_IRI.parse _namespace_name "spacethefinalfrontier" |> NamespacedName

    /// <summary>
    ///   <see href="http://rdf.muninn-project.org/ontologies/military#toUnit"></see>
    /// </summary>
    let toUnit = Namespaced_IRI.parse _namespace_name "toUnit" |> NamespacedName
