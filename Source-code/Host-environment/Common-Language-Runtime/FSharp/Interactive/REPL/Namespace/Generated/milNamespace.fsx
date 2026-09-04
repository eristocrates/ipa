#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mil =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://rdf.muninn-project.org/ontologies/military#" "mil"

    let _1AIFRank2ndCorporal = _prefixId.prefix "1AIFRank2ndCorporal"
    let _1AIFRank2ndLieutenant = _prefixId.prefix "1AIFRank2ndLieutenant"
    let _1AIFRankAbleSeaman = _prefixId.prefix "1AIFRankAbleSeaman"
    let _1AIFRankAirMechanic = _prefixId.prefix "1AIFRankAirMechanic"
    let _1AIFRankAirMechanicClassI = _prefixId.prefix "1AIFRankAirMechanicClassI"
    let _1AIFRankAirMechanicClassII = _prefixId.prefix "1AIFRankAirMechanicClassII"
    let _1AIFRankBombardier = _prefixId.prefix "1AIFRankBombardier"
    let _1AIFRankCaptain = _prefixId.prefix "1AIFRankCaptain"
    let _1AIFRankChaplain = _prefixId.prefix "1AIFRankChaplain"

    let _1AIFRankCompanyQuartermasterSergeant =
        _prefixId.prefix "1AIFRankCompanyQuartermasterSergeant"

    let _1AIFRankCompanySergeantMajor = _prefixId.prefix "1AIFRankCompanySergeantMajor"
    let _1AIFRankCorporal = _prefixId.prefix "1AIFRankCorporal"
    let _1AIFRankDriver = _prefixId.prefix "1AIFRankDriver"
    let _1AIFRankEngineer = _prefixId.prefix "1AIFRankEngineer"
    let _1AIFRankGunner = _prefixId.prefix "1AIFRankGunner"
    let _1AIFRankLanceCorporal = _prefixId.prefix "1AIFRankLanceCorporal"
    let _1AIFRankLanceSergeant = _prefixId.prefix "1AIFRankLanceSergeant"
    let _1AIFRankLeadingStoker = _prefixId.prefix "1AIFRankLeadingStoker"
    let _1AIFRankLieutenant = _prefixId.prefix "1AIFRankLieutenant"
    let _1AIFRankLieutenantColonel = _prefixId.prefix "1AIFRankLieutenantColonel"
    let _1AIFRankMajor = _prefixId.prefix "1AIFRankMajor"
    let _1AIFRankNurse = _prefixId.prefix "1AIFRankNurse"
    let _1AIFRankPettyOfficer = _prefixId.prefix "1AIFRankPettyOfficer"
    let _1AIFRankPrivate = _prefixId.prefix "1AIFRankPrivate"

    let _1AIFRankRegimentalQuartermasterSergeant =
        _prefixId.prefix "1AIFRankRegimentalQuartermasterSergeant"

    let _1AIFRankRegimentalSergeantMajor =
        _prefixId.prefix "1AIFRankRegimentalSergeantMajor"

    let _1AIFRankSapper = _prefixId.prefix "1AIFRankSapper"
    let _1AIFRankSergeant = _prefixId.prefix "1AIFRankSergeant"
    let _1AIFRankSergeantMajor = _prefixId.prefix "1AIFRankSergeantMajor"
    let _1AIFRankSignaller = _prefixId.prefix "1AIFRankSignaller"
    let _1AIFRankStaffSergeant = _prefixId.prefix "1AIFRankStaffSergeant"
    let _1AIFRankTrooper = _prefixId.prefix "1AIFRankTrooper"
    let _1AIFRankWarrantOfficer = _prefixId.prefix "1AIFRankWarrantOfficer"
    let _1AIFRankWarrantOfficerClass2 = _prefixId.prefix "1AIFRankWarrantOfficerClass2"
    /// <summary>
    ///   <para>skos:definition : An acting military rank.</para>
    ///   <para>rdfs:label : Handelnden Rang (Militärischen)rdfs:label : Grade Intérimaire (Militare)rdfs:label : Acting Rank (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ActingRank">mil:ActingRank</a>
    /// </summary>
    let ActingRank = _prefixId.prefix "ActingRank"
    /// <summary>
    ///   <para>rdfs:label : Air Division</para>
    ///   <para>foaf:name : Air Division^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirDivision">mil:AirDivision</a>
    /// </summary>
    let AirDivision = _prefixId.prefix "AirDivision"
    /// <summary>
    ///   <para>skos:definition : An air force command. eg: Bomber Command.</para>
    ///   <para>rdfs:label : Command (Air Force)rdfs:label : rdfs:label : </para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceCommand">mil:AirForceCommand</a>
    /// </summary>
    let AirForceCommand = _prefixId.prefix "AirForceCommand"
    /// <summary>
    ///   <para>skos:definition : A detail from an Air Force flight.</para>
    ///   <para>rdfs:label : rdfs:label :  rdfs:label : Detail (Air Force)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceDetail">mil:AirForceDetail</a>
    /// </summary>
    let AirForceDetail = _prefixId.prefix "AirForceDetail"
    /// <summary>
    ///   <para>rdfs:label : Group (military aviation unit)rdfs:label : Groupe (Force Aérienne)rdfs:label : Gruppe (Luftfahrt)</para>
    ///   <para>foaf:name : Group^^xsd:string</para>
    ///   <para>skos:definition : A group is a military aviation unit, a component of military organization and a military formation. Usage of the terms group and wing differ from one country to another, as well as different branches of a defence force, in some cases. Groups therefore vary considerably in size. In most air services and most countries, a group is made up of two to four squadrons and is commanded by a Lieutenant Colonel, Commander or similar ranks.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceGroup">mil:AirForceGroup</a>
    /// </summary>
    let AirForceGroup = _prefixId.prefix "AirForceGroup"
    /// <summary>
    ///   <para>rdfs:label : Air Force (Service Branch)rdfs:label : Force aérienne (Service Militare)rdfs:label : Luftstreitkräfte (Service)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceServiceBranch">mil:AirForceServiceBranch</a>
    /// </summary>
    let AirForceServiceBranch = _prefixId.prefix "AirForceServiceBranch"
    /// <summary>
    ///   <para>rdfs:label : Esquadrillardfs:label : Laivue (ilmavoimat)rdfs:label : Squadron (aviation)rdfs:label : Phi ÄoÃ nrdfs:label : Staffel (Militär)rdfs:label : Escuadrillardfs:label : Ð­ÑÐºÐ°Ð´ÑÐ¸Ð»ÑÑrdfs:label : Esquadrilhardfs:label : Squadronrdfs:label : Skvadron</para>
    ///   <para>foaf:name : Squadron^^xsd:string</para>
    ///   <para>skos:definition : A squadron in air force, army aviation or naval aviation is mainly a unit comprising a number of military aircraft, usually of the same type, typically with 12 to 24 aircraft, sometimes divided into three or four flights, depending on aircraft type and air force. In most air forces, two or more squadrons form a group or wing. Some air forces also use the term squadrons for non-flying ground units. An escadron is the equivalent unit in France's Armée de l'Air.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceSquadron">mil:AirForceSquadron</a>
    /// </summary>
    let AirForceSquadron = _prefixId.prefix "AirForceSquadron"
    /// <summary>
    ///   <para>skos:definition : An Air Force station.</para>
    ///   <para>rdfs:label : Station (Luftfahrt)rdfs:label : Station (Force Aérienne)rdfs:label : Station (Air Force)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceStation">mil:AirForceStation</a>
    /// </summary>
    let AirForceStation = _prefixId.prefix "AirForceStation"
    /// <summary>
    ///   <para>rdfs:label : Royal Air Force station</para>
    ///   <para>skos:definition : A Royal Air Force station is a permanent Royal Air Force operations location. Many RAF stations are aerodromes, or airbases, being the home to one or more flying squadrons. Other RAF stations are training units, administrative units, headquarters (HQ), or carry out ground-based operational tasks. Although many RAF units are often called stations, they can only be properly classified as an RAF station if they are self-accounting with their own station commander and headquarters.</para>
    ///   <para>foaf:name : Royal Air Force station^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceStationRAF">mil:AirForceStationRAF</a>
    /// </summary>
    let AirForceStationRAF = _prefixId.prefix "AirForceStationRAF"
    /// <summary>
    ///   <para>rdfs:label : Ala (militar)rdfs:label : Wing (luchtmacht)rdfs:label : Geschwaderrdfs:label : Wing (military aviation unit)rdfs:label : KhÃ´ng ÄoÃ nrdfs:label : Flygflottiljrdfs:label : SkrzydÅo (oddziaÅ lotnictwa)rdfs:label : Stormo (unità militare)rdfs:label : ÐÐ²Ð¸Ð°ÑÐ¸Ð¾Ð½Ð½Ð¾Ðµ ÐºÑÑÐ»Ð¾rdfs:label : Ving (militær enhet)</para>
    ///   <para>skos:definition : Wing is a term used by different military aviation forces for a unit of command. The terms wing, group or Staffel are used for different-sized units from one country or service to another. In some military aviation services, a wing is a relatively large formation of two or more groups, which in turn control two or more squadrons. In other contexts a wing is a smaller unit, comprising two to four squadrons, with several wings forming a group.</para>
    ///   <para>foaf:name : Wing^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AirForceWing">mil:AirForceWing</a>
    /// </summary>
    let AirForceWing = _prefixId.prefix "AirForceWing"
    /// <summary>
    ///   <para>skos:definition : An appointment / function in a Civil Organization.</para>
    ///   <para>rdfs:label : Appointment (Civil)rdfs:label : Appointment (Civil)rdfs:label : Appointment (Civil)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Appointment">mil:Appointment</a>
    /// </summary>
    let Appointment = _prefixId.prefix "Appointment"
    let Armor = _prefixId.prefix "Armor"
    /// <summary>
    ///   <para>skos:definition : The category of arms in use</para>
    ///   <para>rdfs:label : ?rdfs:label : Type Armes (Military)rdfs:label : Arms Type(Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmsType">mil:ArmsType</a>
    /// </summary>
    let ArmsType = _prefixId.prefix "ArmsType"
    /// <summary>
    ///   <para>rdfs:label : Kompanie (Militär)rdfs:label : Company (Military Unit)rdfs:label : Compagnie (militaire)</para>
    ///   <para>skos:definition : A military company</para>
    ///   <para>mil:nominalSize : 100^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmyCompany">mil:ArmyCompany</a>
    /// </summary>
    let ArmyCompany = _prefixId.prefix "ArmyCompany"
    /// <summary>
    ///   <para>rdfs:label : Front (seregtest)rdfs:label : Rintama (puna-armeija)rdfs:label : Ð¡Ð¾Ð²ÐµÑÑÐºÐ¸Ðµ ÑÑÐ¾Ð½ÑÑ Ð²Ð¾ Ð²ÑÐµÐ¼Ñ ÐÐµÐ»Ð¸ÐºÐ¾Ð¹ ÐÑÐµÑÐµÑÑÐ²ÐµÐ½Ð½Ð¾Ð¹ Ð²Ð¾Ð¹Ð½Ñrdfs:label : Front (Röda armén)rdfs:label : Front (Großverband)rdfs:label : Front (forband)rdfs:label : Front (military formation)rdfs:label : Fronty radzieckierdfs:label : Frontrdfs:label : PhÆ°Æ¡ng diá»n quÃ¢n (LiÃªn XÃ´)rdfs:label : Front (unité soviétique)</para>
    ///   <para>foaf:name : Front^^xsd:string</para>
    ///   <para>skos:definition : A front was a major military formation. Appearing to originate with the Russian Empire, it has been used by the Polish Army, the Red Army and Soviet Army, and by Turkey. It was roughly equivalent to an army group in the militaries of most other countries. It should not to be confused with the more general usage of military front, describing a geographic area in wartime.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmyFront">mil:ArmyFront</a>
    /// </summary>
    let ArmyFront = _prefixId.prefix "ArmyFront"
    /// <summary>
    ///   <para>rdfs:label : Army Grouprdfs:label : Heeresgrupperdfs:label : Groupe d'Armée</para>
    ///   <para>skos:definition : A field army containing Corps, Brigades, Divisions, etc...</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmyGroup">mil:ArmyGroup</a>
    /// </summary>
    let ArmyGroup = _prefixId.prefix "ArmyGroup"
    /// <summary>
    ///   <para>rdfs:label : Abschnitt (Militär)rdfs:label : Section (Military Unit)rdfs:label : Section (Militaire)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmySection">mil:ArmySection</a>
    /// </summary>
    let ArmySection = _prefixId.prefix "ArmySection"
    /// <summary>
    ///   <para>foaf:name : Milliariafoaf:name : Army</para>
    ///   <para>rdfs:label : Armee (Service)rdfs:label : Army (Service Branch)rdfs:label : Armée (Service)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmyServiceBranch">mil:ArmyServiceBranch</a>
    /// </summary>
    let ArmyServiceBranch = _prefixId.prefix "ArmyServiceBranch"
    /// <summary>
    ///   <para>rdfs:label : Squad (Military Unit)rdfs:label : Équipe (Militaire)rdfs:label : Gruppe (Militär)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmySquad">mil:ArmySquad</a>
    /// </summary>
    let ArmySquad = _prefixId.prefix "ArmySquad"
    /// <summary>
    ///   <para>skos:definition : A generic class for an army troop in the Cavalry or a Corps.</para>
    ///   <para>rdfs:label : Truppe (Militär)rdfs:label : Troupe (Militare)rdfs:label : Troop (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArmyTroop">mil:ArmyTroop</a>
    /// </summary>
    let ArmyTroop = _prefixId.prefix "ArmyTroop"
    let Artillery = _prefixId.prefix "Artillery"
    /// <summary>
    ///   <para>rdfs:label : Batterie (armement)rdfs:label : Artillery Batteryrdfs:label : Batterie (Militär)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBattery">mil:ArtilleryBattery</a>
    /// </summary>
    let ArtilleryBattery = _prefixId.prefix "ArtilleryBattery"
    /// <summary>
    ///   <para>rdfs:label : Batterie Division (Militär)rdfs:label : Division de Batterie (armement)rdfs:label : Divisional Artillery</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArtilleryBatteryDivision">mil:ArtilleryBatteryDivision</a>
    /// </summary>
    let ArtilleryBatteryDivision = _prefixId.prefix "ArtilleryBatteryDivision"
    /// <summary>
    ///   <para>skos:definition : A prepared location for an artillery peice where a gun may or may not be.</para>
    ///   <para>rdfs:label : Artillery Emplacement</para>
    ///   <para>foaf:name : Artillery Emplacement^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ArtilleryEmplacement">mil:ArtilleryEmplacement</a>
    /// </summary>
    let ArtilleryEmplacement = _prefixId.prefix "ArtilleryEmplacement"
    /// <summary>
    ///   <para>foaf:name : Assault Group^^xsd:string</para>
    ///   <para>rdfs:label : Assault Group (Infantry)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#AssaultGroupInfantry">mil:AssaultGroupInfantry</a>
    /// </summary>
    let AssaultGroupInfantry = _prefixId.prefix "AssaultGroupInfantry"
    /// <summary>
    ///   <para>mil:nominalSize : 1000^^xsd:string</para>
    ///   <para>rdfs:label : Bataillonrdfs:label : Bataillonrdfs:label : Battalion (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Battalion">mil:Battalion</a>
    /// </summary>
    let Battalion = _prefixId.prefix "Battalion"
    /// <summary>
    ///   <para>foaf:name : Battle^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Battle">mil:Battle</a>
    /// </summary>
    let Battle = _prefixId.prefix "Battle"
    /// <summary>
    ///   <para>skos:definition : A detail from an Air Force flight.</para>
    ///   <para>rdfs:label : rdfs:label : Espace de Battaillerdfs:label : Battle Space</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#BattleSpace">mil:BattleSpace</a>
    /// </summary>
    let BattleSpace = _prefixId.prefix "BattleSpace"
    /// <summary>
    ///   <para>skos:definition : Flag used to represent that unit on a battlefield.</para>
    ///   <para>rdfs:label : étendard de bataillerdfs:label : Battle Standard</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#BattleStandard">mil:BattleStandard</a>
    /// </summary>
    let BattleStandard = _prefixId.prefix "BattleStandard"
    /// <summary>
    ///   <para>skos:definition : A Brevet military rank.</para>
    ///   <para>rdfs:label : Brevet Rang (Militärischen)rdfs:label : Grade Brevet (Militare)rdfs:label : Brevet Rank (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#BrevetRank">mil:BrevetRank</a>
    /// </summary>
    let BrevetRank = _prefixId.prefix "BrevetRank"
    /// <summary>
    ///   <para>rdfs:label : Brigaderdfs:label : Brigade (Military)rdfs:label : Brigade (Militare)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Brigade">mil:Brigade</a>
    /// </summary>
    let Brigade = _prefixId.prefix "Brigade"
    /// <summary>
    ///   <para>foaf:name : Brigade^^xsd:string</para>
    ///   <para>rdfs:label : Brigade (Air Corps)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#BrigadeAirCorps">mil:BrigadeAirCorps</a>
    /// </summary>
    let BrigadeAirCorps = _prefixId.prefix "BrigadeAirCorps"
    /// <summary>
    ///   <para>foaf:name : Campaign^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Campaign">mil:Campaign</a>
    /// </summary>
    let Campaign = _prefixId.prefix "Campaign"
    /// <summary>
    ///   <para>rdfs:label : Groupe aéronavalrdfs:label : Carrier battle grouprdfs:label : ÐÐ²Ð¸Ð°Ð½Ð¾ÑÐ½Ð°Ñ ÑÐ´Ð°ÑÐ½Ð°Ñ Ð³ÑÑÐ¿Ð¿Ð°rdfs:label : Flugzeugträgerkampfgrupperdfs:label : Gruppo da battaglia di una portaereirdfs:label : Carrier Strike Group</para>
    ///   <para>skos:definition : A carrier battle group (CVBG) consists of an aircraft carrier (designated CV) and its escorts, together comprising the group. The first naval task forces built around carriers appeared just prior to and during World War II. The Imperial Japanese Navy was the first to assemble a large number of carriers into a single task force, known as Kido Butai. This task force was used with devastating effect during the Pearl Harbor Attack.</para>
    ///   <para>foaf:name : Carrier battle group^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#CarrierBattleGroup">mil:CarrierBattleGroup</a>
    /// </summary>
    let CarrierBattleGroup = _prefixId.prefix "CarrierBattleGroup"
    let Cavalry = _prefixId.prefix "Cavalry"
    /// <summary>
    ///   <para>rdfs:label : Cavalry Squadronrdfs:label : Kavallerie Schwadronrdfs:label : Escadron de Cavalerie</para>
    ///   <para>skos:definition : A squadron of cavalry.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#CavalrySquadron">mil:CavalrySquadron</a>
    /// </summary>
    let CavalrySquadron = _prefixId.prefix "CavalrySquadron"
    /// <summary>
    ///   <para>rdfs:label : Troupe de Cavalerierdfs:label : Kavallerie Trupperdfs:label : Cavalry Troop</para>
    ///   <para>skos:definition : A troop of Cavalrymen.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#CavalryTroop">mil:CavalryTroop</a>
    /// </summary>
    let CavalryTroop = _prefixId.prefix "CavalryTroop"
    let Chaplain = _prefixId.prefix "Chaplain"
    /// <summary>
    ///   <para>rdfs:label : Civilrdfs:label : Zivilistrdfs:label : Civilian</para>
    ///   <para>skos:definition : A person uninvolved with the conflict and not working for the conflicting powers.</para>
    ///   <para>foaf:name : Civilian^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Civilian">mil:Civilian</a>
    /// </summary>
    let Civilian = _prefixId.prefix "Civilian"
    /// <summary>
    ///   <para>skos:definition : A person engaging in combat and/or war.</para>
    ///   <para>foaf:name : Combatant^^xsd:string</para>
    ///   <para>rdfs:label : Combatantrdfs:label : Combatantrdfs:label : </para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Combatant">mil:Combatant</a>
    /// </summary>
    let Combatant = _prefixId.prefix "Combatant"
    let CommanderInChiefOf = _prefixId.prefix "CommanderInChiefOf"
    /// <summary>
    ///   <para>rdfs:label : Korpsrdfs:label : Corps</para>
    ///   <para>skos:definition : A disambiguation term for a military Corps.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Corps">mil:Corps</a>
    /// </summary>
    let Corps = _prefixId.prefix "Corps"
    /// <summary>
    ///   <para>rdfs:label : Korps (Großverband)rdfs:label : Corps d'arméerdfs:label : Corps (Formation)</para>
    ///   <para>skos:definition : A military formation containing Brigades, Divisions, etc...</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#CorpsFormation">mil:CorpsFormation</a>
    /// </summary>
    let CorpsFormation = _prefixId.prefix "CorpsFormation"
    /// <summary>
    ///   <para>skos:definition : A stand-alone administrative military unit with a specialized function, eg: Medical Corps.</para>
    ///   <para>rdfs:label : Corps (Unité d'armée)rdfs:label : Korps (Unit)rdfs:label : Corps (Unit)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#CorpsUnit">mil:CorpsUnit</a>
    /// </summary>
    let CorpsUnit = _prefixId.prefix "CorpsUnit"
    let Corps_list = _prefixId.prefix "Corps_list"
    /// <summary>
    ///   <para>rdfs:label : Half-Brigaderdfs:label : Demi-brigaderdfs:label : Halbbrigade</para>
    ///   <para>skos:definition : An military organizational unit derived from French Regiments.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#DemiBrigade">mil:DemiBrigade</a>
    /// </summary>
    let DemiBrigade = _prefixId.prefix "DemiBrigade"
    /// <summary>
    ///   <para>skos:definition : A location where military supplies are stored.</para>
    ///   <para>rdfs:label : Depot (Militär)rdfs:label : Dépot (Military)rdfs:label : Depot (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Depot">mil:Depot</a>
    /// </summary>
    let Depot = _prefixId.prefix "Depot"
    /// <summary>
    ///   <para>rdfs:label : Détachement (Militare)rdfs:label : Detachment (military)rdfs:label : Detachement</para>
    ///   <para>skos:definition : A group of people detached from another larger group for a specific purpose.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Detachment">mil:Detachment</a>
    /// </summary>
    let Detachment = _prefixId.prefix "Detachment"
    /// <summary>
    ///   <para>rdfs:label : Division (Militaire)rdfs:label : Division (Military)rdfs:label : Division (Militär)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Division">mil:Division</a>
    /// </summary>
    let Division = _prefixId.prefix "Division"
    /// <summary>
    ///   <para>rdfs:label : Divisionrdfs:label : Division (Navy)rdfs:label : Division (Marine)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalEstablishment">mil:DivisionNavalEstablishment</a>
    /// </summary>
    let DivisionNavalEstablishment = _prefixId.prefix "DivisionNavalEstablishment"
    /// <summary>
    ///   <para>rdfs:label : Divisionrdfs:label : Division de Navire (Marine)rdfs:label : Ship's Division (Navy)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#DivisionNavalUnit">mil:DivisionNavalUnit</a>
    /// </summary>
    let DivisionNavalUnit = _prefixId.prefix "DivisionNavalUnit"
    /// <summary>
    ///   <para>rdfs:label : Soldat (Rédigé)rdfs:label : Soldier (Drafted)rdfs:label : Soldat (eingezogen)</para>
    ///   <para>skos:definition : A soldier which serves on a full-time basis.</para>
    ///   <para>foaf:name : Draftee^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#DraftedSoldier">mil:DraftedSoldier</a>
    /// </summary>
    let DraftedSoldier = _prefixId.prefix "DraftedSoldier"
    let EnglishTradition = _prefixId.prefix "EnglishTradition"
    /// <summary>
    ///   <para>rdfs:label : angeworbenen Soldatenrdfs:label : Enlisted Soldierrdfs:label : Hommes de Troupes</para>
    ///   <para>foaf:name : Enlisted^^xsd:string</para>
    ///   <para>skos:definition : A soldier below the rank of Officer or non-commissioned Officer.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Enlisted">mil:Enlisted</a>
    /// </summary>
    let Enlisted = _prefixId.prefix "Enlisted"
    /// <summary>
    ///   <para>foaf:name : Exchange Officer^^xsd:string</para>
    ///   <para>rdfs:label : Austausch-Offizierrdfs:label : Exchange Officerrdfs:label : Officier d'échange</para>
    ///   <para>skos:definition : An officer exchanged for a set period of time.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ExchangeOfficer">mil:ExchangeOfficer</a>
    /// </summary>
    let ExchangeOfficer = _prefixId.prefix "ExchangeOfficer"
    /// <summary>
    ///   <para>rdfs:label : Armee (Großverband)rdfs:label : Armée (Unité)rdfs:label : Field Army</para>
    ///   <para>skos:definition : A field army containing Corps, Brigades, Divisions, etc...</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#FieldArmy">mil:FieldArmy</a>
    /// </summary>
    let FieldArmy = _prefixId.prefix "FieldArmy"
    /// <summary>
    ///   <para>rdfs:label : Berittene Kampagnerdfs:label : Artillerie de campagnerdfs:label : Field Artillery</para>
    ///   <para>skos:definition : Field, or foot, artillery where the guns are pulled by horses but the gun crews are on foot.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#FieldArtillery">mil:FieldArtillery</a>
    /// </summary>
    let FieldArtillery = _prefixId.prefix "FieldArtillery"
    let FightsPrimarilyInAir = _prefixId.prefix "FightsPrimarilyInAir"
    let FightsPrimarilyOnAndInLand = _prefixId.prefix "FightsPrimarilyOnAndInLand"
    let FightsPrimarilyOnAndInWater = _prefixId.prefix "FightsPrimarilyOnAndInWater"
    /// <summary>
    ///   <para>rdfs:label : Fireteam (Military Unit)rdfs:label : Trupp (Militär)rdfs:label : Fireteam?</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Fireteam">mil:Fireteam</a>
    /// </summary>
    let Fireteam = _prefixId.prefix "Fireteam"
    /// <summary>
    ///   <para>skos:definition : A Commissioned Officer serving in a political entity's Navy.</para>
    ///   <para>rdfs:label : Flaggoffizierrdfs:label : Flag Officer</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#FlagOfficer">mil:FlagOfficer</a>
    /// </summary>
    let FlagOfficer = _prefixId.prefix "FlagOfficer"
    /// <summary>
    ///   <para>foaf:name : Flotilla^^xsd:string</para>
    ///   <para>rdfs:label : Flottieljerdfs:label : Flotilardfs:label : Flottiljrdfs:label : Flottillerdfs:label : Flottillerdfs:label : Ð¤Ð»Ð¾ÑÐ¸Ð»Ð¸Ñrdfs:label : Flotilhardfs:label : Flotillardfs:label : Flotillardfs:label : Flotillardfs:label : Flotylla okrÄtÃ³w</para>
    ///   <para>skos:definition : A flotilla (from Spanish, meaning a small flota of ships, and this from French flotte), or naval flotilla, is a formation of small warships that may be part of a larger fleet. A flotilla is usually composed of a homogeneous group of the same class of warship, such as frigates, destroyers, torpedo boats, submarines, gunboats, or minesweepers.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Flotilla">mil:Flotilla</a>
    /// </summary>
    let Flotilla = _prefixId.prefix "Flotilla"
    /// <summary>
    ///   <para>rdfs:label : rdfs:label : Fregaterdfs:label : Frigate</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Frigate">mil:Frigate</a>
    /// </summary>
    let Frigate = _prefixId.prefix "Frigate"
    /// <summary>
    ///   <para>rdfs:label : Frente de batalhardfs:label : Front militairerdfs:label : VÃ¡leÄnÃ¡ frontardfs:label : Kampfrontrdfs:label : Front (militar)rdfs:label : Front (oorlog)rdfs:label : Frontlinjerdfs:label : Fronte (guerra)rdfs:label : Front (military)rdfs:label : Kriegsfrontrdfs:label : Frente (término militar)</para>
    ///   <para>foaf:name : Front^^xsd:string</para>
    ///   <para>skos:definition : A military front or battlefront is a contested armed frontier between opposing forces. This can be a local or tactical front, or it can range to a theater. A typical front was the Western Front in France and Belgium in World War I. The term "home front" has been used to denote conditions in the civilian sector of a country at war, including those involved in the production of matériel.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#FrontLine">mil:FrontLine</a>
    /// </summary>
    let FrontLine = _prefixId.prefix "FrontLine"
    /// <summary>
    ///   <para>skos:definition : A collection of military units housed and occuping a location.</para>
    ///   <para>rdfs:label : Garnison (Militär)rdfs:label : Garnison (Militaire)rdfs:label : Garrison (military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Garrison">mil:Garrison</a>
    /// </summary>
    let Garrison = _prefixId.prefix "Garrison"
    /// <summary>
    ///   <para>skos:definition : General staff officers</para>
    ///   <para>rdfs:label : allgemeinen Offizierrdfs:label : General Officerrdfs:label : Officiers Généraux</para>
    ///   <para>foaf:name : General Officer^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#GeneralOfficer">mil:GeneralOfficer</a>
    /// </summary>
    let GeneralOfficer = _prefixId.prefix "GeneralOfficer"
    /// <summary>
    ///   <para>rdfs:label : Grand Batteryrdfs:label : Grand-Batterierdfs:label : Grande Batterie</para>
    ///   <para>skos:definition : Large unit of all available artillery batteries.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#GrandeBatterie">mil:GrandeBatterie</a>
    /// </summary>
    let GrandeBatterie = _prefixId.prefix "GrandeBatterie"
    let GroundBasedOrganization = _prefixId.prefix "GroundBasedOrganization"
    /// <summary>
    ///   <para>rdfs:label : Berittene Artillerierdfs:label : Artillerie à chevalrdfs:label : Horse Artillery</para>
    ///   <para>skos:definition : Field, or foot, artillery where the guns and the gun crewa are transported by horses.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#HorseArtillery">mil:HorseArtillery</a>
    /// </summary>
    let HorseArtillery = _prefixId.prefix "HorseArtillery"
    /// <summary>
    ///   <para>rdfs:label : Household Cavalry</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#HouseholdCavalry">mil:HouseholdCavalry</a>
    /// </summary>
    let HouseholdCavalry = _prefixId.prefix "HouseholdCavalry"
    /// <summary>
    ///   <para>rdfs:label : Infantry</para>
    ///   <para>foaf:name : Peditatafoaf:name : Infantry</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Infantry">mil:Infantry</a>
    /// </summary>
    let Infantry = _prefixId.prefix "Infantry"
    /// <summary>
    ///   <para>foaf:name : Invasion^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Invasion">mil:Invasion</a>
    /// </summary>
    let Invasion = _prefixId.prefix "Invasion"
    /// <summary>
    ///   <para>rdfs:label : Officier de Liasonrdfs:label : Verbindungsoffizierrdfs:label : Liaison Officer</para>
    ///   <para>skos:definition : An officer exchanged to another unit for a set purpose.</para>
    ///   <para>foaf:name : Liaison Officer^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#LiaisonOfficer">mil:LiaisonOfficer</a>
    /// </summary>
    let LiaisonOfficer = _prefixId.prefix "LiaisonOfficer"
    /// <summary>
    ///   <para>rdfs:label : Infantry</para>
    ///   <para>foaf:name : Peditatafoaf:name : Infantry</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#LightInfantry">mil:LightInfantry</a>
    /// </summary>
    let LightInfantry = _prefixId.prefix "LightInfantry"
    /// <summary>
    ///   <para>skos:definition : An aviation airborne flight.</para>
    ///   <para>rdfs:label : Schwarm (Luftfahrt)rdfs:label : Escadrillerdfs:label : Aviation Flight (Military Unit)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryAirborneFlight">mil:MilitaryAirborneFlight</a>
    /// </summary>
    let MilitaryAirborneFlight = _prefixId.prefix "MilitaryAirborneFlight"
    /// <summary>
    ///   <para>skos:definition : An appointment / function in a Military Organization.</para>
    ///   <para>rdfs:label : Appointment (Militärischen)rdfs:label : Appointment (Militare)rdfs:label : Appointment (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryAppointment">mil:MilitaryAppointment</a>
    /// </summary>
    let MilitaryAppointment = _prefixId.prefix "MilitaryAppointment"
    /// <summary>
    ///   <para>foaf:name : Military Event^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryEvent">mil:MilitaryEvent</a>
    /// </summary>
    let MilitaryEvent = _prefixId.prefix "MilitaryEvent"
    /// <summary>
    ///   <para>rdfs:label : Flight (military unit)rdfs:label : Schwarmrdfs:label : Escadrillerdfs:label : Phi Äá»irdfs:label : Flight (luchtmacht)</para>
    ///   <para>foaf:name : Flight (military unit)^^xsd:string</para>
    ///   <para>skos:definition : A flight is a military unit in an air force, naval air service, or army air corps. It usually comprises three to six aircraft, with their aircrews and ground staff; or, in the case of a non-flying ground flight, no aircraft and a roughly equivalent number of support personnel. In most usages, multiple flights make up a squadron. The "flight" is also a basic unit for intercontinental ballistic missiles.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryFlightUnit">mil:MilitaryFlightUnit</a>
    /// </summary>
    let MilitaryFlightUnit = _prefixId.prefix "MilitaryFlightUnit"
    /// <summary>
    ///   <para>skos:definition : Consists of ground personel for an Air Force.</para>
    ///   <para>rdfs:label : Schwarm Boden(Luftfahrt)rdfs:label : Escadrille de terrardfs:label : Ground Flight (Military Unit)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryGroundFlight">mil:MilitaryGroundFlight</a>
    /// </summary>
    let MilitaryGroundFlight = _prefixId.prefix "MilitaryGroundFlight"
    /// <summary>
    ///   <para>foaf:name : Military Operation^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryOperation">mil:MilitaryOperation</a>
    /// </summary>
    let MilitaryOperation = _prefixId.prefix "MilitaryOperation"
    /// <summary>
    ///   <para>rdfs:label : A Military Organizationrdfs:label : Une Organisation Militarerdfs:label : </para>
    ///   <para>skos:definition : An organization that is military.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryOrganization">mil:MilitaryOrganization</a>
    /// </summary>
    let MilitaryOrganization = _prefixId.prefix "MilitaryOrganization"
    /// <summary>
    ///   <para>foaf:name : Military Raid^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryRaid">mil:MilitaryRaid</a>
    /// </summary>
    let MilitaryRaid = _prefixId.prefix "MilitaryRaid"
    /// <summary>
    ///   <para>skos:definition : A military rank.</para>
    ///   <para>rdfs:label : Rang (Militärischen)rdfs:label : Grade (Militare)rdfs:label : Rank (Military)</para>
    ///   <para>foaf:name : Military Rank^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryRank">mil:MilitaryRank</a>
    /// </summary>
    let MilitaryRank = _prefixId.prefix "MilitaryRank"
    /// <summary>
    ///   <para>rdfs:label : Teilstreitkraftrdfs:label : Branche du service militairerdfs:label : Service Branch (Military)</para>
    ///   <para>foaf:name : Service Branch^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryServiceBranch">mil:MilitaryServiceBranch</a>
    /// </summary>
    let MilitaryServiceBranch = _prefixId.prefix "MilitaryServiceBranch"
    /// <summary>
    ///   <para>skos:definition : A military trade.</para>
    ///   <para>rdfs:label : Occupation Professionelle (Militare)rdfs:label : Trade (Military)</para>
    ///   <para>foaf:name : Military Trade^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrade">mil:MilitaryTrade</a>
    /// </summary>
    let MilitaryTrade = _prefixId.prefix "MilitaryTrade"
    /// <summary>
    ///   <para>rdfs:label : Tranchée Militairerdfs:label : Military Trench</para>
    ///   <para>skos:definition : A depression in the ground serving as fortification.</para>
    ///   <para>foaf:name : Military Trench^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryTrench">mil:MilitaryTrench</a>
    /// </summary>
    let MilitaryTrench = _prefixId.prefix "MilitaryTrench"
    /// <summary>
    ///   <para>rdfs:label : Military Uniform</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MilitaryUniform">mil:MilitaryUniform</a>
    /// </summary>
    let MilitaryUniform = _prefixId.prefix "MilitaryUniform"
    /// <summary>
    ///   <para>skos:definition : Artillery units capable of disassembling and reassembling their guns for mountain transport.</para>
    ///   <para>rdfs:label : Gebirgsgeschützrdfs:label : Artillerie de Montagnecampagnerdfs:label : Mountain Artillery</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#MountainArtillery">mil:MountainArtillery</a>
    /// </summary>
    let MountainArtillery = _prefixId.prefix "MountainArtillery"
    /// <summary>
    ///   <para>rdfs:label : Força Aérea Numeradardfs:label : KhÃ´ng lá»±c mang sá»rdfs:label : Luftflotten der United States Air Forcerdfs:label : Numbered Air Forcerdfs:label : Numbered Air Force</para>
    ///   <para>foaf:name : Named Air Force^^xsd:string</para>
    ///   <para>skos:definition : Use this for numbered / named air forces, eg: US 8th Air Force. Ambiguous useage over time within the command structure.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NamedAirForceUnit">mil:NamedAirForceUnit</a>
    /// </summary>
    let NamedAirForceUnit = _prefixId.prefix "NamedAirForceUnit"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-1</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-1">mil:NatoRankOF-1</a>
    /// </summary>
    let NatoRankOF_1 = _prefixId.prefix "NatoRankOF-1"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-10</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-10">mil:NatoRankOF-10</a>
    /// </summary>
    let NatoRankOF_10 = _prefixId.prefix "NatoRankOF-10"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-2</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-2">mil:NatoRankOF-2</a>
    /// </summary>
    let NatoRankOF_2 = _prefixId.prefix "NatoRankOF-2"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-3</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-3">mil:NatoRankOF-3</a>
    /// </summary>
    let NatoRankOF_3 = _prefixId.prefix "NatoRankOF-3"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-4</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-4">mil:NatoRankOF-4</a>
    /// </summary>
    let NatoRankOF_4 = _prefixId.prefix "NatoRankOF-4"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-5</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-5">mil:NatoRankOF-5</a>
    /// </summary>
    let NatoRankOF_5 = _prefixId.prefix "NatoRankOF-5"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-6</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-6">mil:NatoRankOF-6</a>
    /// </summary>
    let NatoRankOF_6 = _prefixId.prefix "NatoRankOF-6"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-7</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-7">mil:NatoRankOF-7</a>
    /// </summary>
    let NatoRankOF_7 = _prefixId.prefix "NatoRankOF-7"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-8</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-8">mil:NatoRankOF-8</a>
    /// </summary>
    let NatoRankOF_8 = _prefixId.prefix "NatoRankOF-8"
    /// <summary>
    ///   <para>rdfs:label : NATO Officer Rank OF-9</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOF-9">mil:NatoRankOF-9</a>
    /// </summary>
    let NatoRankOF_9 = _prefixId.prefix "NatoRankOF-9"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-1</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-1">mil:NatoRankOR-1</a>
    /// </summary>
    let NatoRankOR_1 = _prefixId.prefix "NatoRankOR-1"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-2</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-2">mil:NatoRankOR-2</a>
    /// </summary>
    let NatoRankOR_2 = _prefixId.prefix "NatoRankOR-2"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-3</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-3">mil:NatoRankOR-3</a>
    /// </summary>
    let NatoRankOR_3 = _prefixId.prefix "NatoRankOR-3"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-4</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-4">mil:NatoRankOR-4</a>
    /// </summary>
    let NatoRankOR_4 = _prefixId.prefix "NatoRankOR-4"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-5</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-5">mil:NatoRankOR-5</a>
    /// </summary>
    let NatoRankOR_5 = _prefixId.prefix "NatoRankOR-5"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-6</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-6">mil:NatoRankOR-6</a>
    /// </summary>
    let NatoRankOR_6 = _prefixId.prefix "NatoRankOR-6"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-7</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-7">mil:NatoRankOR-7</a>
    /// </summary>
    let NatoRankOR_7 = _prefixId.prefix "NatoRankOR-7"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-8</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-8">mil:NatoRankOR-8</a>
    /// </summary>
    let NatoRankOR_8 = _prefixId.prefix "NatoRankOR-8"
    /// <summary>
    ///   <para>rdfs:label : NATO Other/Enlisted Rank OR-9</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankOR-9">mil:NatoRankOR-9</a>
    /// </summary>
    let NatoRankOR_9 = _prefixId.prefix "NatoRankOR-9"
    /// <summary>
    ///   <para>rdfs:label : NATO Warrant Officer Rank WO-1</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-1">mil:NatoRankWO-1</a>
    /// </summary>
    let NatoRankWO_1 = _prefixId.prefix "NatoRankWO-1"
    /// <summary>
    ///   <para>rdfs:label : NATO Warrant Officer Rank WO-2</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-2">mil:NatoRankWO-2</a>
    /// </summary>
    let NatoRankWO_2 = _prefixId.prefix "NatoRankWO-2"
    /// <summary>
    ///   <para>rdfs:label : NATO Warrant Officer Rank WO-3</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-3">mil:NatoRankWO-3</a>
    /// </summary>
    let NatoRankWO_3 = _prefixId.prefix "NatoRankWO-3"
    /// <summary>
    ///   <para>rdfs:label : NATO Warrant Officer Rank WO-4</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-4">mil:NatoRankWO-4</a>
    /// </summary>
    let NatoRankWO_4 = _prefixId.prefix "NatoRankWO-4"
    /// <summary>
    ///   <para>rdfs:label : NATO Warrant Officer Rank WO-5</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRankWO-5">mil:NatoRankWO-5</a>
    /// </summary>
    let NatoRankWO_5 = _prefixId.prefix "NatoRankWO-5"
    /// <summary>
    ///   <para>rdfs:label : Grades de l'OTANrdfs:label : NATO Rangcoderdfs:label : Ranks of NATO</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NatoRanks">mil:NatoRanks</a>
    /// </summary>
    let NatoRanks = _prefixId.prefix "NatoRanks"
    let Nato_Ranks = _prefixId.prefix "Nato_Ranks"
    /// <summary>
    ///   <para>rdfs:label : Artillerie Navalerdfs:label : Navel Artilleryrdfs:label : Schiffsartillerie</para>
    ///   <para>skos:definition : Naval artillery unit operating from the ship on land.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavalArtillery">mil:NavalArtillery</a>
    /// </summary>
    let NavalArtillery = _prefixId.prefix "NavalArtillery"
    /// <summary>
    ///   <para>rdfs:label : Háº¡m Äá»irdfs:label : Laivasto (sotilasyksikkö)rdfs:label : Vlootrdfs:label : LoÄstvordfs:label : Flottardfs:label : Flottardfs:label : Naval fleetrdfs:label : Flotardfs:label : Flotardfs:label : Flotardfs:label : Flåte (marine)rdfs:label : Frotardfs:label : Flotte (Marine)rdfs:label : Ð¤Ð»Ð¾Ñrdfs:label : Flotte</para>
    ///   <para>skos:definition : A fleet, or naval fleet, is a large formation of warships, and the largest formation in any navy. A fleet at sea is the direct equivalent of an army on land. Fleets are usually, but not necessarily, permanent formations and are generally assigned to a particular ocean or sea. Most fleets are named after that ocean or sea, but the convention in the United States Navy is to use numbers.</para>
    ///   <para>foaf:name : Naval fleet^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavalFleet">mil:NavalFleet</a>
    /// </summary>
    let NavalFleet = _prefixId.prefix "NavalFleet"
    /// <summary>
    ///   <para>skos:definition : A Commissioned Officer serving in a political entity's Navy.</para>
    ///   <para>rdfs:label : Naval Officerrdfs:label : Offiziere (Deutsche Marine)rdfs:label : Officier (Marine)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavalOfficer">mil:NavalOfficer</a>
    /// </summary>
    let NavalOfficer = _prefixId.prefix "NavalOfficer"
    /// <summary>
    ///   <para>skos:definition : A Seaman serving in a political entity's Navy.</para>
    ///   <para>rdfs:label : Unteroffiziere (Deutsche Marine)rdfs:label : Naval Ratingrdfs:label : Maître (Marine de Guerre)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavalRating">mil:NavalRating</a>
    /// </summary>
    let NavalRating = _prefixId.prefix "NavalRating"
    /// <summary>
    ///   <para>rdfs:label : Ð­ÑÐºÐ°Ð´ÑÐ°rdfs:label : Eskadrardfs:label : Eskadrerdfs:label : Esquadra navalrdfs:label : Geschwader (Marine)rdfs:label : Eskaderrdfs:label : Eskaderrdfs:label : Squadron (naval)rdfs:label : Laivue (laivasto)rdfs:label : Escadrerdfs:label : Háº£i ÄoÃ nrdfs:label : Eskadra (marynarka wojenna)</para>
    ///   <para>mil:nominalSize : 4^^xsd:string</para>
    ///   <para>skos:definition : A squadron, or naval squadron, is a unit of 3-4 major warships, transport ships, submarines, or sometimes small craft that may be part of a larger task force or a fleet. A squadron is usually composed of a homogeneous group of the same classification of ships, such as battleships, battlecruisers, cruisers, destroyers or frigates, or of various types tasked with a specific mission such as coastal patrol, blockade, or minesweeping. Smaller warships are usually grouped in flotillas.</para>
    ///   <para>foaf:name : Squadron^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavalSquadron">mil:NavalSquadron</a>
    /// </summary>
    let NavalSquadron = _prefixId.prefix "NavalSquadron"
    /// <summary>
    ///   <para>rdfs:label : Task Force (Marine)rdfs:label : Task Force (Naval)rdfs:label : Force opérationnelle (Marine)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavalTaskForce">mil:NavalTaskForce</a>
    /// </summary>
    let NavalTaskForce = _prefixId.prefix "NavalTaskForce"
    let Navy = _prefixId.prefix "Navy"
    /// <summary>
    ///   <para>skos:definition : An Naval air station.</para>
    ///   <para>rdfs:label : rdfs:label : rdfs:label : Station (Naval Aircraft)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavyAirStation">mil:NavyAirStation</a>
    /// </summary>
    let NavyAirStation = _prefixId.prefix "NavyAirStation"
    /// <summary>
    ///   <para>skos:definition : A named or numbered Navy based on operating area or administrative grouping.</para>
    ///   <para>foaf:name : Navy^^xsd:string</para>
    ///   <para>rdfs:label : Navy (Named or Numbered)rdfs:label : Marine (Boot-Gruppe)rdfs:label : Marine (Groupe de batiment naval)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NavyBigFleet">mil:NavyBigFleet</a>
    /// </summary>
    let NavyBigFleet = _prefixId.prefix "NavyBigFleet"
    let NavyMerchant = _prefixId.prefix "NavyMerchant"
    let NavyServiceBranch = _prefixId.prefix "NavyServiceBranch"
    /// <summary>
    ///   <para>foaf:name : Non-Combatant^^xsd:string</para>
    ///   <para>rdfs:label : rdfs:label : Non-Combatantrdfs:label : Non-Combatant</para>
    ///   <para>skos:definition : A person not engaged in combat and/or war, but which might be involved in a war. This includes nurses, chaplains, medics depending on the era.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Non-Combatant">mil:Non-Combatant</a>
    /// </summary>
    let Non_Combatant = _prefixId.prefix "Non-Combatant"
    /// <summary>
    ///   <para>rdfs:label : Sous-Officier Subalternesrdfs:label : Non Commissioned Officerrdfs:label : Soldatenlaufbahnverordnung</para>
    ///   <para>foaf:name : Non Commissioned Officer^^xsd:string</para>
    ///   <para>skos:definition : A soldier with a rank of Corporal or above.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#NonCommissionedOfficer">mil:NonCommissionedOfficer</a>
    /// </summary>
    let NonCommissionedOfficer = _prefixId.prefix "NonCommissionedOfficer"
    /// <summary>
    ///   <para>rdfs:label : Officierrdfs:label : Officerrdfs:label : Offizier</para>
    ///   <para>skos:definition : A commissioned officer, acting, breveted or confirmed.</para>
    ///   <para>foaf:name : Officer^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Officer">mil:Officer</a>
    /// </summary>
    let Officer = _prefixId.prefix "Officer"
    /// <summary>
    ///   <para>rdfs:label : Platoonrdfs:label : Platoonrdfs:label : Peloton (militaire)</para>
    ///   <para>skos:definition : A platoon</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Platoon">mil:Platoon</a>
    /// </summary>
    let Platoon = _prefixId.prefix "Platoon"
    /// <summary>
    ///   <para>foaf:name : Posted To Unit^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#PostToUnit">mil:PostToUnit</a>
    /// </summary>
    let PostToUnit = _prefixId.prefix "PostToUnit"
    /// <summary>
    ///   <para>foaf:name : Privileged Combatant^^xsd:string</para>
    ///   <para>rdfs:label : privilegierten Kämpferrdfs:label : Privileged Combatantrdfs:label : Combatant privilégié</para>
    ///   <para>skos:definition : A person engaging in combat and/or war as a privileged combatants under the rules of war, circa Great War.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#PrivilegedCombatant">mil:PrivilegedCombatant</a>
    /// </summary>
    let PrivilegedCombatant = _prefixId.prefix "PrivilegedCombatant"
    /// <summary>
    ///   <para>rdfs:label : Proto_air_forcerdfs:label : Proto Air Force</para>
    ///   <para>skos:definition : Use this class for army air corps, naval aviation and army aviation.</para>
    ///   <para>foaf:name : Proto Air Force^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ProtoAirForce">mil:ProtoAirForce</a>
    /// </summary>
    let ProtoAirForce = _prefixId.prefix "ProtoAirForce"
    /// <summary>
    ///   <para>rdfs:label : Rank (Civil)rdfs:label : Rang (Civil)rdfs:label : Grade (Civil)</para>
    ///   <para>skos:definition : A Civilian rank.</para>
    ///   <para>foaf:name : Rank^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Rank">mil:Rank</a>
    /// </summary>
    let Rank = _prefixId.prefix "Rank"
    let RankAbleSeaman = _prefixId.prefix "RankAbleSeaman"
    let RankAbleSeaman_Canada = _prefixId.prefix "RankAbleSeaman_Canada"

    let RankAbleSeaman_Commonwealth_of_Nations =
        _prefixId.prefix "RankAbleSeaman_Commonwealth_of_Nations"

    let ``RankBandsmanArmyCanada+`` = _prefixId.prefix "RankBandsmanArmyCanada+"

    let RankBatterySergeantMajorArmyCanada =
        _prefixId.prefix "RankBatterySergeantMajorArmyCanada"

    let RankBombardierArmyCanada = _prefixId.prefix "RankBombardierArmyCanada"
    let RankBoyArmyCanada = _prefixId.prefix "RankBoyArmyCanada"

    let RankBrigadierGeneralArmyCanada =
        _prefixId.prefix "RankBrigadierGeneralArmyCanada"

    let RankCadetArmyCanada = _prefixId.prefix "RankCadetArmyCanada"
    let RankCaptainArmyCanada = _prefixId.prefix "RankCaptainArmyCanada"
    let RankCaptainNaval = _prefixId.prefix "RankCaptainNaval"
    let RankCaptainNaval_Australia = _prefixId.prefix "RankCaptainNaval_Australia"
    let RankCaptainNaval_Canada = _prefixId.prefix "RankCaptainNaval_Canada"
    let RankChaplainArmyCanada = _prefixId.prefix "RankChaplainArmyCanada"
    let ``RankClerkArmyCanada+`` = _prefixId.prefix "RankClerkArmyCanada+"
    let RankColonelArmyCanada = _prefixId.prefix "RankColonelArmyCanada"
    let RankCombatMilitaryRank = _prefixId.prefix "RankCombatMilitaryRank"
    let RankCombatMilitaryRank_Russia = _prefixId.prefix "RankCombatMilitaryRank_Russia"

    let RankCombatMilitaryRank_Soviet_Union =
        _prefixId.prefix "RankCombatMilitaryRank_Soviet_Union"

    let RankCommandant = _prefixId.prefix "RankCommandant"
    let RankCommandant_France = _prefixId.prefix "RankCommandant_France"

    let RankCommandant_Republic_of_Ireland =
        _prefixId.prefix "RankCommandant_Republic_of_Ireland"

    let ``RankCompanyQuarterMasterSergeantArmyCanada+`` =
        _prefixId.prefix "RankCompanyQuarterMasterSergeantArmyCanada+"

    let RankCompanySergeantMajor = _prefixId.prefix "RankCompanySergeantMajor"

    let RankCompanySergeantMajorArmyCanada =
        _prefixId.prefix "RankCompanySergeantMajorArmyCanada"

    let RankConductorArmyCanada = _prefixId.prefix "RankConductorArmyCanada"
    let ``RankCorporalArmyCanada+`` = _prefixId.prefix "RankCorporalArmyCanada+"
    let RankDriver = _prefixId.prefix "RankDriver"
    let RankDriverArmyCanada = _prefixId.prefix "RankDriverArmyCanada"
    let RankDriver_Australia = _prefixId.prefix "RankDriver_Australia"
    let RankDriver_Canada = _prefixId.prefix "RankDriver_Canada"
    let RankEngineer = _prefixId.prefix "RankEngineer"
    let RankGeneralArmyCanada = _prefixId.prefix "RankGeneralArmyCanada"
    let RankGunner = _prefixId.prefix "RankGunner"
    let RankGunnerArmyCanada = _prefixId.prefix "RankGunnerArmyCanada"
    let RankLanceCorporalArmyCanada = _prefixId.prefix "RankLanceCorporalArmyCanada"

    let ``RankLanceSergeantArmyCanada+`` =
        _prefixId.prefix "RankLanceSergeantArmyCanada+"

    let RankLeadingStoker = _prefixId.prefix "RankLeadingStoker"
    let RankLieutenantArmyCanada = _prefixId.prefix "RankLieutenantArmyCanada"
    let RankLieutenantColonelArmy = _prefixId.prefix "RankLieutenantColonelArmy"

    let RankLieutenantColonelArmyCanada =
        _prefixId.prefix "RankLieutenantColonelArmyCanada"

    let ``RankLieutenantColonelArmyCanada+`` =
        _prefixId.prefix "RankLieutenantColonelArmyCanada+"

    let RankLieutenantGeneralArmyCanada =
        _prefixId.prefix "RankLieutenantGeneralArmyCanada"

    let RankMajorArmyCanada = _prefixId.prefix "RankMajorArmyCanada"
    let RankMasterGunnerArmyCanada = _prefixId.prefix "RankMasterGunnerArmyCanada"
    let RankNursingSisterArmyCanada = _prefixId.prefix "RankNursingSisterArmyCanada"

    let RankOrderlyRoomSergeantArmyCanada =
        _prefixId.prefix "RankOrderlyRoomSergeantArmyCanada"

    let RankPioneerArmyCanada = _prefixId.prefix "RankPioneerArmyCanada"
    let RankPrivateArmyCanada = _prefixId.prefix "RankPrivateArmyCanada"

    let RankQuartermasterSergeantArmyCanada =
        _prefixId.prefix "RankQuartermasterSergeantArmyCanada"

    let RankQuartermasterSergeantMajorArmyCanada =
        _prefixId.prefix "RankQuartermasterSergeantMajorArmyCanada"

    let RankRegimentalSergeantMajorArmyCanada =
        _prefixId.prefix "RankRegimentalSergeantMajorArmyCanada"

    let RankRiflemanArmyCanada = _prefixId.prefix "RankRiflemanArmyCanada"
    let RankSaddlerArmyCanada = _prefixId.prefix "RankSaddlerArmyCanada"
    let RankSapper = _prefixId.prefix "RankSapper"
    let RankSapperArmyCanada = _prefixId.prefix "RankSapperArmyCanada"
    let RankScoutArmyCanada = _prefixId.prefix "RankScoutArmyCanada"
    let RankSecondCorporalArmyCanada = _prefixId.prefix "RankSecondCorporalArmyCanada"

    let RankSecondLieutenantArmyCanada =
        _prefixId.prefix "RankSecondLieutenantArmyCanada"

    let RankSergeant = _prefixId.prefix "RankSergeant"
    let RankSergeantArmyCanada = _prefixId.prefix "RankSergeantArmyCanada"
    let RankSergeantMajorArmyCanada = _prefixId.prefix "RankSergeantMajorArmyCanada"
    let RankSignaller = _prefixId.prefix "RankSignaller"
    let RankSignallerArmyCanada = _prefixId.prefix "RankSignallerArmyCanada"

    let ``RankSquadronSergeantMajorArmyCanada+`` =
        _prefixId.prefix "RankSquadronSergeantMajorArmyCanada+"

    let RankStaffSergeantArmyCanada = _prefixId.prefix "RankStaffSergeantArmyCanada"
    let RankStoker = _prefixId.prefix "RankStoker"
    let RankTrooperArmyCanada = _prefixId.prefix "RankTrooperArmyCanada"
    let RankWarrantOfficerArmyCanada = _prefixId.prefix "RankWarrantOfficerArmyCanada"
    let Rank_Admiral_EnglishTradition = _prefixId.prefix "Rank_Admiral_EnglishTradition"

    let Rank_Admiral_of_the_Fleet_Russia =
        _prefixId.prefix "Rank_Admiral_of_the_Fleet_Russia"

    let Rank_Admiral_of_the_Fleet_Russia_Russia =
        _prefixId.prefix "Rank_Admiral_of_the_Fleet_Russia_Russia"

    let Rank_Admiral_of_the_Fleet_Russia_Soviet_Union =
        _prefixId.prefix "Rank_Admiral_of_the_Fleet_Russia_Soviet_Union"

    let Rank_Admiral_of_the_fleet_EnglishTradition =
        _prefixId.prefix "Rank_Admiral_of_the_fleet_EnglishTradition"

    let Rank_Agha = _prefixId.prefix "Rank_Agha"
    let Rank_Agha_Cossack_Hetmanate = _prefixId.prefix "Rank_Agha_Cossack_Hetmanate"
    let Rank_Agha_Ottoman_Empire = _prefixId.prefix "Rank_Agha_Ottoman_Empire"

    let Rank_Agha_Septinsular_Republic =
        _prefixId.prefix "Rank_Agha_Septinsular_Republic"

    let Rank_Air_chief_marshal = _prefixId.prefix "Rank_Air_chief_marshal"

    let Rank_Air_chief_marshal_Australia =
        _prefixId.prefix "Rank_Air_chief_marshal_Australia"

    let Rank_Air_chief_marshal_Australia_Australia =
        _prefixId.prefix "Rank_Air_chief_marshal_Australia_Australia"

    let Rank_Air_chief_marshal_Canada = _prefixId.prefix "Rank_Air_chief_marshal_Canada"

    let Rank_Air_chief_marshal_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Air_chief_marshal_Commonwealth_of_Nations"

    let Rank_Air_commodore_EnglishTradition =
        _prefixId.prefix "Rank_Air_commodore_EnglishTradition"

    let Rank_Air_marshal_EnglishTradition =
        _prefixId.prefix "Rank_Air_marshal_EnglishTradition"

    let Rank_Air_vice_marshal = _prefixId.prefix "Rank_Air_vice-marshal"

    let Rank_Air_vice_marshal_Australia =
        _prefixId.prefix "Rank_Air_vice-marshal_Australia"

    let Rank_Air_vice_marshal_Canada = _prefixId.prefix "Rank_Air_vice-marshal_Canada"

    let Rank_Air_vice_marshal_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Air_vice-marshal_Commonwealth_of_Nations"

    let Rank_Aircraftman_EnglishTradition =
        _prefixId.prefix "Rank_Aircraftman_EnglishTradition"

    let Rank_Anthypolochagos = _prefixId.prefix "Rank_Anthypolochagos"
    let Rank_Anthypolochagos_Greece = _prefixId.prefix "Rank_Anthypolochagos_Greece"

    let Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Anthypolochagos_Official_Timocracy_of_Sapinetia"

    let Rank_Antisyntagmatarchis = _prefixId.prefix "Rank_Antisyntagmatarchis"

    let Rank_Antisyntagmatarchis_Greece =
        _prefixId.prefix "Rank_Antisyntagmatarchis_Greece"

    let Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Antisyntagmatarchis_Official_Timocracy_of_Sapinetia"

    let Rank_Appointee = _prefixId.prefix "Rank_Appointee"
    let Rank_Appointee_Italy = _prefixId.prefix "Rank_Appointee_Italy"
    let Rank_Appointee_Switzerland = _prefixId.prefix "Rank_Appointee_Switzerland"
    let Rank_Army_General_Russia = _prefixId.prefix "Rank_Army_General_Russia"

    let Rank_Army_General_Russia_Russia =
        _prefixId.prefix "Rank_Army_General_Russia_Russia"

    let Rank_Army_General_Russia_Soviet_Union =
        _prefixId.prefix "Rank_Army_General_Russia_Soviet_Union"

    let Rank_Aspirant = _prefixId.prefix "Rank_Aspirant"
    let Rank_Aspirant_France = _prefixId.prefix "Rank_Aspirant_France"
    let Rank_Aspirant_Romania = _prefixId.prefix "Rank_Aspirant_Romania"
    let Rank_Aspirant_Romania_Romania = _prefixId.prefix "Rank_Aspirant_Romania_Romania"
    let Rank_Ataman = _prefixId.prefix "Rank_Ataman"
    let Rank_Ataman_Russia = _prefixId.prefix "Rank_Ataman_Russia"
    let Rank_Ataman_Soviet_Union = _prefixId.prefix "Rank_Ataman_Soviet_Union"
    let Rank_Ataman_Ukraine = _prefixId.prefix "Rank_Ataman_Ukraine"
    let Rank_Battery_sergeant_major = _prefixId.prefix "Rank_Battery_sergeant_major"
    let Rank_Birinci_Ferik = _prefixId.prefix "Rank_Birinci_Ferik"

    let Rank_Birinci_Ferik_Cossack_Hetmanate =
        _prefixId.prefix "Rank_Birinci_Ferik_Cossack_Hetmanate"

    let Rank_Birinci_Ferik_Ottoman_Empire =
        _prefixId.prefix "Rank_Birinci_Ferik_Ottoman_Empire"

    let Rank_Birinci_Ferik_Septinsular_Republic =
        _prefixId.prefix "Rank_Birinci_Ferik_Septinsular_Republic"

    let Rank_Bombardier = _prefixId.prefix "Rank_Bombardier"
    let ``Rank_Bombardier_%28rank%29`` = _prefixId.prefix "Rank_Bombardier_%28rank%29"
    let Rank_Bombardier_Australia = _prefixId.prefix "Rank_Bombardier_Australia"
    let Rank_Bombardier_Canada = _prefixId.prefix "Rank_Bombardier_Canada"

    let Rank_Bombardier_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Bombardier_Commonwealth_of_Nations"

    let Rank_Bootsmann = _prefixId.prefix "Rank_Bootsmann"
    let Rank_Bootsmann_Germany = _prefixId.prefix "Rank_Bootsmann_Germany"
    let Rank_Bootsmann_Russia = _prefixId.prefix "Rank_Bootsmann_Russia"
    let Rank_Bootsmann_Soviet_Union = _prefixId.prefix "Rank_Bootsmann_Soviet_Union"
    let Rank_Brigade_General = _prefixId.prefix "Rank_Brigade_General"

    let Rank_Brigade_General_Australia =
        _prefixId.prefix "Rank_Brigade_General_Australia"

    let Rank_Brigade_General_Canada = _prefixId.prefix "Rank_Brigade_General_Canada"

    let Rank_Brigadier_EnglishTradition =
        _prefixId.prefix "Rank_Brigadier_EnglishTradition"

    let Rank_Brigadier_general = _prefixId.prefix "Rank_Brigadier_general"

    let Rank_Brigadier_general_Australia =
        _prefixId.prefix "Rank_Brigadier_general_Australia"

    let Rank_Brigadier_general_Canada = _prefixId.prefix "Rank_Brigadier_general_Canada"
    let Rank_Buffer_Navy = _prefixId.prefix "Rank_Buffer_Navy"
    let Rank_Buffer_Navy_Australia = _prefixId.prefix "Rank_Buffer_Navy_Australia"

    let Rank_Buffer_Navy_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Buffer_Navy_Commonwealth_of_Nations"

    let Rank_Captain = _prefixId.prefix "Rank_Captain"

    let Rank_Captain_naval_EnglishTradition =
        _prefixId.prefix "Rank_Captain_(naval)_EnglishTradition"

    let Rank_Captain_Australia = _prefixId.prefix "Rank_Captain_Australia"
    let Rank_Captain_Canada = _prefixId.prefix "Rank_Captain_Canada"
    let Rank_Captain_EnglishTradition = _prefixId.prefix "Rank_Captain_EnglishTradition"
    let Rank_Captain_Lieutenant = _prefixId.prefix "Rank_Captain_Lieutenant"

    let Rank_Captain_Lieutenant_Germany =
        _prefixId.prefix "Rank_Captain_Lieutenant_Germany"

    let Rank_Captain_Lieutenant_Russia =
        _prefixId.prefix "Rank_Captain_Lieutenant_Russia"

    let Rank_Captain_Lieutenant_Soviet_Union =
        _prefixId.prefix "Rank_Captain_Lieutenant_Soviet_Union"

    let Rank_Captain_Republic_of_Ireland =
        _prefixId.prefix "Rank_Captain_Republic_of_Ireland"

    let Rank_Captain_Russia = _prefixId.prefix "Rank_Captain_Russia"
    let Rank_Captain_Singapore = _prefixId.prefix "Rank_Captain_Singapore"
    let Rank_Captain_Soviet_Union = _prefixId.prefix "Rank_Captain_Soviet_Union"
    let Rank_Captain_Sweden = _prefixId.prefix "Rank_Captain_Sweden"
    let Rank_Captain_lieutenant = _prefixId.prefix "Rank_Captain_lieutenant"

    let Rank_Captain_lieutenant_Germany =
        _prefixId.prefix "Rank_Captain_lieutenant_Germany"

    let Rank_Captain_lieutenant_Russia =
        _prefixId.prefix "Rank_Captain_lieutenant_Russia"

    let Rank_Captain_lieutenant_Soviet_Union =
        _prefixId.prefix "Rank_Captain_lieutenant_Soviet_Union"

    let Rank_Chief_Marshal = _prefixId.prefix "Rank_Chief_Marshal"
    let Rank_Chief_Marshal_Russia = _prefixId.prefix "Rank_Chief_Marshal_Russia"

    let Rank_Chief_Marshal_Soviet_Union =
        _prefixId.prefix "Rank_Chief_Marshal_Soviet_Union"

    let Rank_Chief_petty_officer = _prefixId.prefix "Rank_Chief_petty_officer"

    let Rank_Chief_petty_officer_1st_class =
        _prefixId.prefix "Rank_Chief_petty_officer,_1st_class"

    let Rank_Chief_petty_officer_1st_class_Canada =
        _prefixId.prefix "Rank_Chief_petty_officer,_1st_class_Canada"

    let Rank_Chief_petty_officer_2nd_class =
        _prefixId.prefix "Rank_Chief_petty_officer,_2nd_class"

    let Rank_Chief_petty_officer_2nd_class_Canada =
        _prefixId.prefix "Rank_Chief_petty_officer,_2nd_class_Canada"

    let Rank_Chief_petty_officer_Australia =
        _prefixId.prefix "Rank_Chief_petty_officer_Australia"

    let Rank_Chief_petty_officer_Canada =
        _prefixId.prefix "Rank_Chief_petty_officer_Canada"

    let Rank_Chief_petty_officer_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Chief_petty_officer_Commonwealth_of_Nations"

    let Rank_Chiliarch = _prefixId.prefix "Rank_Chiliarch"
    let Rank_Chiliarch_Achaean_League = _prefixId.prefix "Rank_Chiliarch_Achaean_League"

    let Rank_Chiliarch_Byzantine_Empire =
        _prefixId.prefix "Rank_Chiliarch_Byzantine_Empire"

    let Rank_Chiliarch_Greece = _prefixId.prefix "Rank_Chiliarch_Greece"
    let Rank_Chiliarch_Macedonia = _prefixId.prefix "Rank_Chiliarch_Macedonia"

    let Rank_Chiliarch_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Chiliarch_Official_Timocracy_of_Sapinetia"

    let Rank_Chorbaji = _prefixId.prefix "Rank_Chorbaji"

    let Rank_Chorbaji_Cossack_Hetmanate =
        _prefixId.prefix "Rank_Chorbaji_Cossack_Hetmanate"

    let Rank_Chorbaji_Ottoman_Empire = _prefixId.prefix "Rank_Chorbaji_Ottoman_Empire"

    let Rank_Chorbaji_Septinsular_Republic =
        _prefixId.prefix "Rank_Chorbaji_Septinsular_Republic"

    let Rank_Chowqzy = _prefixId.prefix "Rank_Chowqzy"
    let Rank_Chowqzy_Poland = _prefixId.prefix "Rank_Chowqzy_Poland"
    let Rank_Chowqzy_Russia = _prefixId.prefix "Rank_Chowqzy_Russia"
    let Rank_Chowqzy_Soviet_Union = _prefixId.prefix "Rank_Chowqzy_Soviet_Union"
    let Rank_Chowqzy_Ukraine = _prefixId.prefix "Rank_Chowqzy_Ukraine"
    let Rank_Colonel_EnglishTradition = _prefixId.prefix "Rank_Colonel_EnglishTradition"
    let Rank_Comandarm = _prefixId.prefix "Rank_Comandarm"
    let Rank_Comandarm_Russia = _prefixId.prefix "Rank_Comandarm_Russia"
    let Rank_Comandarm_Soviet_Union = _prefixId.prefix "Rank_Comandarm_Soviet_Union"
    let Rank_Combrig = _prefixId.prefix "Rank_Combrig"
    let Rank_Combrig_Russia = _prefixId.prefix "Rank_Combrig_Russia"
    let Rank_Combrig_Soviet_Union = _prefixId.prefix "Rank_Combrig_Soviet_Union"
    let Rank_Comcor = _prefixId.prefix "Rank_Comcor"
    let Rank_Comcor_Russia = _prefixId.prefix "Rank_Comcor_Russia"
    let Rank_Comcor_Soviet_Union = _prefixId.prefix "Rank_Comcor_Soviet_Union"
    let Rank_Comdiv = _prefixId.prefix "Rank_Comdiv"
    let Rank_Comdiv_Russia = _prefixId.prefix "Rank_Comdiv_Russia"
    let Rank_Comdiv_Soviet_Union = _prefixId.prefix "Rank_Comdiv_Soviet_Union"

    let Rank_Commandant_rank_EnglishTradition =
        _prefixId.prefix "Rank_Commandant_(rank)_EnglishTradition"

    let Rank_Commander_EnglishTradition =
        _prefixId.prefix "Rank_Commander_EnglishTradition"

    let Rank_Commandeur = _prefixId.prefix "Rank_Commandeur"
    let Rank_Commandeur_France = _prefixId.prefix "Rank_Commandeur_France"
    let Rank_Commandeur_Netherlands = _prefixId.prefix "Rank_Commandeur_Netherlands"

    let Rank_Commodore_rank_EnglishTradition =
        _prefixId.prefix "Rank_Commodore_(rank)_EnglishTradition"

    let Rank_Company_Quartermaster_Sergeant =
        _prefixId.prefix "Rank_Company_Quartermaster_Sergeant"

    let Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Company_Quartermaster_Sergeant_Commonwealth_of_Nations"

    let Rank_Company_Quartermaster_Sergeant_England =
        _prefixId.prefix "Rank_Company_Quartermaster_Sergeant_England"

    let Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland =
        _prefixId.prefix "Rank_Company_Quartermaster_Sergeant_Republic_of_Ireland"

    let Rank_Company_Quartermaster_Sergeant_Scotland =
        _prefixId.prefix "Rank_Company_Quartermaster_Sergeant_Scotland"

    let Rank_Company_Quartermaster_Sergeant_Wales =
        _prefixId.prefix "Rank_Company_Quartermaster_Sergeant_Wales"

    let Rank_Company_sergeant_major = _prefixId.prefix "Rank_Company_sergeant_major"

    let Rank_Company_sergeant_major_Australia =
        _prefixId.prefix "Rank_Company_sergeant_major_Australia"

    let Rank_Company_sergeant_major_Canada =
        _prefixId.prefix "Rank_Company_sergeant_major_Canada"

    let Rank_Company_sergeant_major_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Company_sergeant_major_Commonwealth_of_Nations"

    let Rank_Company_sergeant_major_England =
        _prefixId.prefix "Rank_Company_sergeant_major_England"

    let Rank_Company_sergeant_major_Scotland =
        _prefixId.prefix "Rank_Company_sergeant_major_Scotland"

    let Rank_Company_sergeant_major_Singapore =
        _prefixId.prefix "Rank_Company_sergeant_major_Singapore"

    let Rank_Company_sergeant_major_Wales =
        _prefixId.prefix "Rank_Company_sergeant_major_Wales"

    let Rank_Conductor_army = _prefixId.prefix "Rank_Conductor_army"
    let Rank_Conductor_army_Australia = _prefixId.prefix "Rank_Conductor_army_Australia"
    let Rank_Conductor_army_England = _prefixId.prefix "Rank_Conductor_army_England"
    let Rank_Conductor_army_Scotland = _prefixId.prefix "Rank_Conductor_army_Scotland"
    let Rank_Conductor_army_Wales = _prefixId.prefix "Rank_Conductor_army_Wales"

    let Rank_Corporal_EnglishTradition =
        _prefixId.prefix "Rank_Corporal_EnglishTradition"

    let Rank_Daejang = _prefixId.prefix "Rank_Daejang"
    let Rank_Daejang_North_Korea = _prefixId.prefix "Rank_Daejang_North_Korea"
    let Rank_Daejang_South_Korea = _prefixId.prefix "Rank_Daejang_South_Korea"
    let Rank_Daffadar = _prefixId.prefix "Rank_Daffadar"
    let Rank_Daffadar_British_India = _prefixId.prefix "Rank_Daffadar_British_India"
    let Rank_Divisional_Admiral = _prefixId.prefix "Rank_Divisional_Admiral"

    let Rank_Divisional_Admiral_Belgium =
        _prefixId.prefix "Rank_Divisional_Admiral_Belgium"

    let Rank_Divisional_Admiral_Italy = _prefixId.prefix "Rank_Divisional_Admiral_Italy"
    let Rank_Divisional_General = _prefixId.prefix "Rank_Divisional_General"

    let Rank_Divisional_General_France =
        _prefixId.prefix "Rank_Divisional_General_France"

    let Rank_Divisional_General_Poland =
        _prefixId.prefix "Rank_Divisional_General_Poland"

    let Rank_Drum_Major_General = _prefixId.prefix "Rank_Drum_Major_General"

    let Rank_Drum_Major_General_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Drum_Major_General_Commonwealth_of_Nations"

    let Rank_Drum_Major_General_England =
        _prefixId.prefix "Rank_Drum_Major_General_England"

    let Rank_Drum_Major_General_Scotland =
        _prefixId.prefix "Rank_Drum_Major_General_Scotland"

    let Rank_Drum_Major_General_Wales = _prefixId.prefix "Rank_Drum_Major_General_Wales"
    let Rank_Drum_major = _prefixId.prefix "Rank_Drum_major"

    let Rank_Drum_major_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Drum_major_Commonwealth_of_Nations"

    let Rank_Drum_major_England = _prefixId.prefix "Rank_Drum_major_England"
    let Rank_Drum_major_Scotland = _prefixId.prefix "Rank_Drum_major_Scotland"
    let Rank_Drum_major_Wales = _prefixId.prefix "Rank_Drum_major_Wales"

    let Rank_Ensign_rank_EnglishTradition =
        _prefixId.prefix "Rank_Ensign_(rank)_EnglishTradition"

    let Rank_Epihipparch = _prefixId.prefix "Rank_Epihipparch"

    let Rank_Epihipparch_Achaean_League =
        _prefixId.prefix "Rank_Epihipparch_Achaean_League"

    let Rank_Epihipparch_Macedonia = _prefixId.prefix "Rank_Epihipparch_Macedonia"
    let Rank_Ferik = _prefixId.prefix "Rank_Ferik"
    let Rank_Ferik_Cossack_Hetmanate = _prefixId.prefix "Rank_Ferik_Cossack_Hetmanate"
    let Rank_Ferik_Ottoman_Empire = _prefixId.prefix "Rank_Ferik_Ottoman_Empire"

    let Rank_Ferik_Septinsular_Republic =
        _prefixId.prefix "Rank_Ferik_Septinsular_Republic"

    let Rank_Field_marshal_EnglishTradition =
        _prefixId.prefix "Rank_Field_marshal_EnglishTradition"

    let Rank_Fleet_Board = _prefixId.prefix "Rank_Fleet_Board"
    let Rank_Fleet_Board_England = _prefixId.prefix "Rank_Fleet_Board_England"
    let Rank_Fleet_Board_Scotland = _prefixId.prefix "Rank_Fleet_Board_Scotland"
    let Rank_Fleet_Board_Wales = _prefixId.prefix "Rank_Fleet_Board_Wales"

    let Rank_Flight_lieutenant_EnglishTradition =
        _prefixId.prefix "Rank_Flight_lieutenant_EnglishTradition"

    let Rank_Flight_sergeant = _prefixId.prefix "Rank_Flight_sergeant"

    let Rank_Flight_sergeant_Australia =
        _prefixId.prefix "Rank_Flight_sergeant_Australia"

    let Rank_Flight_sergeant_Canada = _prefixId.prefix "Rank_Flight_sergeant_Canada"

    let Rank_Flight_sergeant_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Flight_sergeant_Commonwealth_of_Nations"

    let Rank_Flight_sergeant_Republic_of_Ireland =
        _prefixId.prefix "Rank_Flight_sergeant_Republic_of_Ireland"

    let Rank_Flying_officer_EnglishTradition =
        _prefixId.prefix "Rank_Flying_officer_EnglishTradition"

    let Rank_Garrison_Sergeant_Major = _prefixId.prefix "Rank_Garrison_Sergeant_Major"

    let Rank_Garrison_Sergeant_Major_England =
        _prefixId.prefix "Rank_Garrison_Sergeant_Major_England"

    let Rank_Garrison_Sergeant_Major_Scotland =
        _prefixId.prefix "Rank_Garrison_Sergeant_Major_Scotland"

    let Rank_Garrison_Sergeant_Major_Wales =
        _prefixId.prefix "Rank_Garrison_Sergeant_Major_Wales"

    let Rank_Gefreiter = _prefixId.prefix "Rank_Gefreiter"
    let Rank_Gefreiter_Germany = _prefixId.prefix "Rank_Gefreiter_Germany"
    let Rank_Gefreiter_Russia = _prefixId.prefix "Rank_Gefreiter_Russia"
    let Rank_Gefreiter_Soviet_Union = _prefixId.prefix "Rank_Gefreiter_Soviet_Union"
    let Rank_General_in_Chief = _prefixId.prefix "Rank_General-in-Chief"
    let Rank_General_in_Chief_Russia = _prefixId.prefix "Rank_General-in-Chief_Russia"

    let Rank_General_in_Chief_Soviet_Union =
        _prefixId.prefix "Rank_General-in-Chief_Soviet_Union"

    let Rank_General_Admiral = _prefixId.prefix "Rank_General_Admiral"
    let Rank_General_Admiral_Germany = _prefixId.prefix "Rank_General_Admiral_Germany"
    let Rank_General_Admiral_Russia = _prefixId.prefix "Rank_General_Admiral_Russia"

    let Rank_General_Admiral_Soviet_Union =
        _prefixId.prefix "Rank_General_Admiral_Soviet_Union"

    let Rank_General_officer_EnglishTradition =
        _prefixId.prefix "Rank_General_officer_EnglishTradition"

    let Rank_Group_captain_EnglishTradition =
        _prefixId.prefix "Rank_Group_captain_EnglishTradition"

    let Rank_Hasa = _prefixId.prefix "Rank_Hasa"
    let Rank_Hasa_North_Korea = _prefixId.prefix "Rank_Hasa_North_Korea"
    let Rank_Hasa_South_Korea = _prefixId.prefix "Rank_Hasa_South_Korea"
    let Rank_Havildar = _prefixId.prefix "Rank_Havildar"
    let Rank_Havildar_British_India = _prefixId.prefix "Rank_Havildar_British_India"
    let Rank_Hetman = _prefixId.prefix "Rank_Hetman"
    let Rank_Hetman_Belarus = _prefixId.prefix "Rank_Hetman_Belarus"
    let Rank_Hetman_Lithuania = _prefixId.prefix "Rank_Hetman_Lithuania"
    let Rank_Hetman_Poland = _prefixId.prefix "Rank_Hetman_Poland"
    let Rank_Hetman_Ukraine = _prefixId.prefix "Rank_Hetman_Ukraine"
    let Rank_Hipparchus_Cavalry = _prefixId.prefix "Rank_Hipparchus_Cavalry"

    let Rank_Hipparchus_Cavalry_Achaean_League =
        _prefixId.prefix "Rank_Hipparchus_Cavalry_Achaean_League"

    let Rank_Hipparchus_Cavalry_Macedonia =
        _prefixId.prefix "Rank_Hipparchus_Cavalry_Macedonia"

    let Rank_Jungsa = _prefixId.prefix "Rank_Jungsa"
    let Rank_Jungsa_North_Korea = _prefixId.prefix "Rank_Jungsa_North_Korea"
    let Rank_Jungsa_South_Korea = _prefixId.prefix "Rank_Jungsa_South_Korea"
    let Rank_Jungwi = _prefixId.prefix "Rank_Jungwi"
    let Rank_Jungwi_North_Korea = _prefixId.prefix "Rank_Jungwi_North_Korea"
    let Rank_Jungwi_South_Korea = _prefixId.prefix "Rank_Jungwi_South_Korea"
    let Rank_Junior_sergeant = _prefixId.prefix "Rank_Junior_sergeant"
    let Rank_Junior_sergeant_Estonia = _prefixId.prefix "Rank_Junior_sergeant_Estonia"

    let Rank_Junior_sergeant_Republic_of_Estonia_1920_1940 =
        _prefixId.prefix "Rank_Junior_sergeant_Republic_of_Estonia_1920-1940"

    let Rank_Junjang = _prefixId.prefix "Rank_Junjang"
    let Rank_Junjang_North_Korea = _prefixId.prefix "Rank_Junjang_North_Korea"
    let Rank_Junjang_South_Korea = _prefixId.prefix "Rank_Junjang_South_Korea"
    let Rank_Kapudan_Pasha = _prefixId.prefix "Rank_Kapudan_Pasha"

    let Rank_Kapudan_Pasha_Cossack_Hetmanate =
        _prefixId.prefix "Rank_Kapudan_Pasha_Cossack_Hetmanate"

    let Rank_Kapudan_Pasha_Ottoman_Empire =
        _prefixId.prefix "Rank_Kapudan_Pasha_Ottoman_Empire"

    let Rank_Kapudan_Pasha_Septinsular_Republic =
        _prefixId.prefix "Rank_Kapudan_Pasha_Septinsular_Republic"

    let Rank_Kindral = _prefixId.prefix "Rank_Kindral"
    let Rank_Kindral_Estonia = _prefixId.prefix "Rank_Kindral_Estonia"

    let Rank_Kindral_Republic_of_Estonia_1920_1940 =
        _prefixId.prefix "Rank_Kindral_Republic_of_Estonia_1920-1940"

    let Rank_Kolagasi = _prefixId.prefix "Rank_Kolagasi"

    let Rank_Kolagasi_Cossack_Hetmanate =
        _prefixId.prefix "Rank_Kolagasi_Cossack_Hetmanate"

    let Rank_Kolagasi_Ottoman_Empire = _prefixId.prefix "Rank_Kolagasi_Ottoman_Empire"

    let Rank_Kolagasi_Septinsular_Republic =
        _prefixId.prefix "Rank_Kolagasi_Septinsular_Republic"

    let Rank_Kolonel = _prefixId.prefix "Rank_Kolonel"
    let Rank_Kolonel_Belgium = _prefixId.prefix "Rank_Kolonel_Belgium"
    let Rank_Kolonel_Estonia = _prefixId.prefix "Rank_Kolonel_Estonia"
    let Rank_Kolonel_Netherlands = _prefixId.prefix "Rank_Kolonel_Netherlands"

    let Rank_Kolonel_Republic_of_Estonia_1920_1940 =
        _prefixId.prefix "Rank_Kolonel_Republic_of_Estonia_1920-1940"

    let Rank_Lance_corporal_of_horse = _prefixId.prefix "Rank_Lance-corporal_of_horse"

    let Rank_Lance_corporal_of_horse_England =
        _prefixId.prefix "Rank_Lance-corporal_of_horse_England"

    let Rank_Lance_corporal_of_horse_Scotland =
        _prefixId.prefix "Rank_Lance-corporal_of_horse_Scotland"

    let Rank_Lance_corporal_of_horse_Wales =
        _prefixId.prefix "Rank_Lance-corporal_of_horse_Wales"

    let Rank_Lance_corporal = _prefixId.prefix "Rank_Lance_corporal"
    let Rank_Lance_corporal_Australia = _prefixId.prefix "Rank_Lance_corporal_Australia"

    let Rank_Lance_corporal_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Lance_corporal_Commonwealth_of_Nations"

    let Rank_Lance_corporal_England = _prefixId.prefix "Rank_Lance_corporal_England"
    let Rank_Lance_corporal_Scotland = _prefixId.prefix "Rank_Lance_corporal_Scotland"
    let Rank_Lance_corporal_Singapore = _prefixId.prefix "Rank_Lance_corporal_Singapore"
    let Rank_Lance_corporal_Wales = _prefixId.prefix "Rank_Lance_corporal_Wales"
    let Rank_Lance_sergeant = _prefixId.prefix "Rank_Lance_sergeant"
    let Rank_Lance_sergeant_Australia = _prefixId.prefix "Rank_Lance_sergeant_Australia"

    let Rank_Lance_sergeant_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Lance_sergeant_Commonwealth_of_Nations"

    let Rank_Lance_sergeant_England = _prefixId.prefix "Rank_Lance_sergeant_England"
    let Rank_Lance_sergeant_Scotland = _prefixId.prefix "Rank_Lance_sergeant_Scotland"
    let Rank_Lance_sergeant_Wales = _prefixId.prefix "Rank_Lance_sergeant_Wales"
    let Rank_Leading_aircraftman = _prefixId.prefix "Rank_Leading_aircraftman"

    let Rank_Leading_aircraftman_Australia =
        _prefixId.prefix "Rank_Leading_aircraftman_Australia"

    let Rank_Leading_aircraftman_Canada =
        _prefixId.prefix "Rank_Leading_aircraftman_Canada"

    let Rank_Leading_aircraftman_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Leading_aircraftman_Commonwealth_of_Nations"

    let Rank_Leading_seaman_EnglishTradition =
        _prefixId.prefix "Rank_Leading_seaman_EnglishTradition"

    let Rank_Lieutenant_navy_EnglishTradition =
        _prefixId.prefix "Rank_Lieutenant_(navy)_EnglishTradition"

    let Rank_Lieutenant_EnglishTradition =
        _prefixId.prefix "Rank_Lieutenant_EnglishTradition"

    let Rank_Lieutenant_colonel_EnglishTradition =
        _prefixId.prefix "Rank_Lieutenant_colonel_EnglishTradition"

    let Rank_Lieutenant_commander_EnglishTradition =
        _prefixId.prefix "Rank_Lieutenant_commander_EnglishTradition"

    let Rank_Lochagos = _prefixId.prefix "Rank_Lochagos"
    let Rank_Lochagos_Achaean_League = _prefixId.prefix "Rank_Lochagos_Achaean_League"
    let Rank_Lochagos_Greece = _prefixId.prefix "Rank_Lochagos_Greece"
    let Rank_Lochagos_Macedonia = _prefixId.prefix "Rank_Lochagos_Macedonia"

    let Rank_Lochagos_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Lochagos_Official_Timocracy_of_Sapinetia"

    let Rank_Lord_High_Admiral_of_the_Wash =
        _prefixId.prefix "Rank_Lord_High_Admiral_of_the_Wash"

    let Rank_Lord_High_Admiral_of_the_Wash_England =
        _prefixId.prefix "Rank_Lord_High_Admiral_of_the_Wash_England"

    let Rank_Lord_High_Admiral_of_the_Wash_Scotland =
        _prefixId.prefix "Rank_Lord_High_Admiral_of_the_Wash_Scotland"

    let Rank_Lord_High_Admiral_of_the_Wash_Wales =
        _prefixId.prefix "Rank_Lord_High_Admiral_of_the_Wash_Wales"

    let Rank_Major_EnglishTradition = _prefixId.prefix "Rank_Major_EnglishTradition"
    let Rank_Major_general = _prefixId.prefix "Rank_Major_general"
    let Rank_Major_general_Australia = _prefixId.prefix "Rank_Major_general_Australia"
    let Rank_Major_general_Canada = _prefixId.prefix "Rank_Major_general_Canada"
    let Rank_Marshal_EnglishTradition = _prefixId.prefix "Rank_Marshal_EnglishTradition"

    let Rank_Marshal_of_the_Soviet_Union =
        _prefixId.prefix "Rank_Marshal_of_the_Soviet_Union"

    let Rank_Marshal_of_the_Soviet_Union_Soviet_Union =
        _prefixId.prefix "Rank_Marshal_of_the_Soviet_Union_Soviet_Union"

    let Rank_Marshal_of_the_air_force_EnglishTradition =
        _prefixId.prefix "Rank_Marshal_of_the_air_force_EnglishTradition"

    let Rank_Master_warrant_officer = _prefixId.prefix "Rank_Master_warrant_officer"

    let Rank_Master_warrant_officer_Canada =
        _prefixId.prefix "Rank_Master_warrant_officer_Canada"

    let Rank_Master_warrant_officer_Singapore =
        _prefixId.prefix "Rank_Master_warrant_officer_Singapore"

    let Rank_Midshipman_EnglishTradition =
        _prefixId.prefix "Rank_Midshipman_EnglishTradition"

    let Rank_Mirliva = _prefixId.prefix "Rank_Mirliva"

    let Rank_Mirliva_Cossack_Hetmanate =
        _prefixId.prefix "Rank_Mirliva_Cossack_Hetmanate"

    let Rank_Mirliva_Ottoman_Empire = _prefixId.prefix "Rank_Mirliva_Ottoman_Empire"

    let Rank_Mirliva_Septinsular_Republic =
        _prefixId.prefix "Rank_Mirliva_Septinsular_Republic"

    let Rank_Musir = _prefixId.prefix "Rank_Musir"
    let Rank_Musir_Cossack_Hetmanate = _prefixId.prefix "Rank_Musir_Cossack_Hetmanate"
    let Rank_Musir_Ottoman_Empire = _prefixId.prefix "Rank_Musir_Ottoman_Empire"

    let Rank_Musir_Septinsular_Republic =
        _prefixId.prefix "Rank_Musir_Septinsular_Republic"

    let Rank_Navarch = _prefixId.prefix "Rank_Navarch"
    let Rank_Navarch_Achaean_League = _prefixId.prefix "Rank_Navarch_Achaean_League"
    let Rank_Navarch_Greece = _prefixId.prefix "Rank_Navarch_Greece"
    let Rank_Navarch_Macedonia = _prefixId.prefix "Rank_Navarch_Macedonia"

    let Rank_Navarch_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Navarch_Official_Timocracy_of_Sapinetia"

    let Rank_Obergefreiter = _prefixId.prefix "Rank_Obergefreiter"
    let Rank_Obergefreiter_Germany = _prefixId.prefix "Rank_Obergefreiter_Germany"

    let Rank_Obergefreiter_Switzerland =
        _prefixId.prefix "Rank_Obergefreiter_Switzerland"

    let Rank_Oberst = _prefixId.prefix "Rank_Oberst"
    let Rank_Oberst_Austria = _prefixId.prefix "Rank_Oberst_Austria"
    let Rank_Oberst_Denmark = _prefixId.prefix "Rank_Oberst_Denmark"
    let Rank_Oberst_Finland = _prefixId.prefix "Rank_Oberst_Finland"
    let Rank_Oberst_Germany = _prefixId.prefix "Rank_Oberst_Germany"

    let Rank_Oberst_Kingdom_of_Denmark =
        _prefixId.prefix "Rank_Oberst_Kingdom_of_Denmark"

    let Rank_Oberst_Norway = _prefixId.prefix "Rank_Oberst_Norway"
    let Rank_Oberst_Sweden = _prefixId.prefix "Rank_Oberst_Sweden"
    let Rank_Oberst_Switzerland = _prefixId.prefix "Rank_Oberst_Switzerland"
    let Rank_Oberstleutnant = _prefixId.prefix "Rank_Oberstleutnant"
    let Rank_Oberstleutnant_Germany = _prefixId.prefix "Rank_Oberstleutnant_Germany"

    let Rank_Officer_cadet_EnglishTradition =
        _prefixId.prefix "Rank_Officer_cadet_EnglishTradition"

    let Rank_Ordinary_seaman_rating = _prefixId.prefix "Rank_Ordinary_seaman_rating"

    let Rank_Ordinary_seaman_rating_Australia =
        _prefixId.prefix "Rank_Ordinary_seaman_rating_Australia"

    let Rank_Ordinary_seaman_rating_Canada =
        _prefixId.prefix "Rank_Ordinary_seaman_rating_Canada"

    let Rank_Ordinary_seaman_rating_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Ordinary_seaman_rating_Commonwealth_of_Nations"

    let Rank_Petty_officer_EnglishTradition =
        _prefixId.prefix "Rank_Petty_officer_EnglishTradition"

    let Rank_Phrourarch = _prefixId.prefix "Rank_Phrourarch"

    let Rank_Phrourarch_Achaean_League =
        _prefixId.prefix "Rank_Phrourarch_Achaean_League"

    let Rank_Phrourarch_Greece = _prefixId.prefix "Rank_Phrourarch_Greece"
    let Rank_Phrourarch_Macedonia = _prefixId.prefix "Rank_Phrourarch_Macedonia"

    let Rank_Phrourarch_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Phrourarch_Official_Timocracy_of_Sapinetia"

    let Rank_Pilot_officer_EnglishTradition =
        _prefixId.prefix "Rank_Pilot_officer_EnglishTradition"

    let Rank_Pipe_Major = _prefixId.prefix "Rank_Pipe_Major"

    let Rank_Pipe_Major_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Pipe_Major_Commonwealth_of_Nations"

    let Rank_Pipe_Major_England = _prefixId.prefix "Rank_Pipe_Major_England"
    let Rank_Pipe_Major_Scotland = _prefixId.prefix "Rank_Pipe_Major_Scotland"
    let Rank_Pipe_Major_Wales = _prefixId.prefix "Rank_Pipe_Major_Wales"
    let Rank_Podpolkovnik = _prefixId.prefix "Rank_Podpolkovnik"
    let Rank_Podpolkovnik_Poland = _prefixId.prefix "Rank_Podpolkovnik_Poland"
    let Rank_Podpolkovnik_Russia = _prefixId.prefix "Rank_Podpolkovnik_Russia"

    let Rank_Podpolkovnik_Soviet_Union =
        _prefixId.prefix "Rank_Podpolkovnik_Soviet_Union"

    let Rank_Podpolkovnik_Ukraine = _prefixId.prefix "Rank_Podpolkovnik_Ukraine"
    let Rank_Podpraporshchik = _prefixId.prefix "Rank_Podpraporshchik"
    let Rank_Podpraporshchik_Russia = _prefixId.prefix "Rank_Podpraporshchik_Russia"

    let Rank_Podpraporshchik_Soviet_Union =
        _prefixId.prefix "Rank_Podpraporshchik_Soviet_Union"

    let Rank_Polemarch = _prefixId.prefix "Rank_Polemarch"
    let Rank_Polemarch_Achaean_League = _prefixId.prefix "Rank_Polemarch_Achaean_League"
    let Rank_Polemarch_Macedonia = _prefixId.prefix "Rank_Polemarch_Macedonia"
    let Rank_Polkovnik = _prefixId.prefix "Rank_Polkovnik"
    let Rank_Polkovnik_Poland = _prefixId.prefix "Rank_Polkovnik_Poland"
    let Rank_Polkovnik_Russia = _prefixId.prefix "Rank_Polkovnik_Russia"
    let Rank_Polkovnik_Soviet_Union = _prefixId.prefix "Rank_Polkovnik_Soviet_Union"
    let Rank_Polkovnik_Ukraine = _prefixId.prefix "Rank_Polkovnik_Ukraine"
    let Rank_Poruchik = _prefixId.prefix "Rank_Poruchik"
    let Rank_Poruchik_Poland = _prefixId.prefix "Rank_Poruchik_Poland"
    let Rank_Poruchik_Russia = _prefixId.prefix "Rank_Poruchik_Russia"
    let Rank_Poruchik_Soviet_Union = _prefixId.prefix "Rank_Poruchik_Soviet_Union"
    let Rank_Praporshchik = _prefixId.prefix "Rank_Praporshchik"
    let Rank_Praporshchik_Russia = _prefixId.prefix "Rank_Praporshchik_Russia"

    let Rank_Praporshchik_Soviet_Union =
        _prefixId.prefix "Rank_Praporshchik_Soviet_Union"

    let Rank_Private = _prefixId.prefix "Rank_Private"
    let Rank_Private_Australia = _prefixId.prefix "Rank_Private_Australia"
    let Rank_Private_Canada = _prefixId.prefix "Rank_Private_Canada"
    let Rank_Private_England = _prefixId.prefix "Rank_Private_England"
    let Rank_Private_EnglishTradition = _prefixId.prefix "Rank_Private_EnglishTradition"

    let Rank_Private_Republic_of_Ireland =
        _prefixId.prefix "Rank_Private_Republic_of_Ireland"

    let Rank_Private_Scotland = _prefixId.prefix "Rank_Private_Scotland"
    let Rank_Private_Wales = _prefixId.prefix "Rank_Private_Wales"
    let Rank_Rear_admiral = _prefixId.prefix "Rank_Rear_admiral"
    let Rank_Rear_admiral_Australia = _prefixId.prefix "Rank_Rear_admiral_Australia"
    let Rank_Rear_admiral_Canada = _prefixId.prefix "Rank_Rear_admiral_Canada"

    let Rank_Regimental_Quartermaster_Sergeant =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant"

    let Rank_Regimental_Quartermaster_Sergeant_Australia =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_Australia"

    let Rank_Regimental_Quartermaster_Sergeant_Canada =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_Canada"

    let Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_Commonwealth_of_Nations"

    let Rank_Regimental_Quartermaster_Sergeant_England =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_England"

    let Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_Republic_of_Ireland"

    let Rank_Regimental_Quartermaster_Sergeant_Scotland =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_Scotland"

    let Rank_Regimental_Quartermaster_Sergeant_Wales =
        _prefixId.prefix "Rank_Regimental_Quartermaster_Sergeant_Wales"

    let Rank_Regimental_sergeant_major =
        _prefixId.prefix "Rank_Regimental_sergeant_major"

    let Rank_Regimental_sergeant_major_Australia =
        _prefixId.prefix "Rank_Regimental_sergeant_major_Australia"

    let Rank_Regimental_sergeant_major_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Regimental_sergeant_major_Commonwealth_of_Nations"

    let Rank_Regimental_sergeant_major_Singapore =
        _prefixId.prefix "Rank_Regimental_sergeant_major_Singapore"

    let Rank_Sangsa = _prefixId.prefix "Rank_Sangsa"
    let Rank_Sangsa_North_Korea = _prefixId.prefix "Rank_Sangsa_North_Korea"
    let Rank_Sangsa_South_Korea = _prefixId.prefix "Rank_Sangsa_South_Korea"
    let Rank_Schout_bij_nacht = _prefixId.prefix "Rank_Schout-bij-nacht"

    let Rank_Schout_bij_nacht_Netherlands =
        _prefixId.prefix "Rank_Schout-bij-nacht_Netherlands"

    let Rank_Schout_bij_nacht_Russia = _prefixId.prefix "Rank_Schout-bij-nacht_Russia"

    let Rank_Schout_bij_nacht_Soviet_Union =
        _prefixId.prefix "Rank_Schout-bij-nacht_Soviet_Union"

    let Rank_Seaman_EnglishTradition = _prefixId.prefix "Rank_Seaman_EnglishTradition"
    let Rank_Second_Corporal = _prefixId.prefix "Rank_Second_Corporal"
    let Rank_Second_Corporal_England = _prefixId.prefix "Rank_Second_Corporal_England"
    let Rank_Second_Corporal_Scotland = _prefixId.prefix "Rank_Second_Corporal_Scotland"
    let Rank_Second_Corporal_Wales = _prefixId.prefix "Rank_Second_Corporal_Wales"

    let Rank_Second_lieutenant_EnglishTradition =
        _prefixId.prefix "Rank_Second_lieutenant_EnglishTradition"

    let Rank_Sergeant = _prefixId.prefix "Rank_Sergeant"

    let Rank_Sergeant_EnglishTradition =
        _prefixId.prefix "Rank_Sergeant_EnglishTradition"

    let Rank_Sergeant_Major_Instructor =
        _prefixId.prefix "Rank_Sergeant_Major_Instructor"

    let Rank_Sergeant_Major_Instructor_England =
        _prefixId.prefix "Rank_Sergeant_Major_Instructor_England"

    let Rank_Sergeant_Major_Instructor_Scotland =
        _prefixId.prefix "Rank_Sergeant_Major_Instructor_Scotland"

    let Rank_Sergeant_Major_Instructor_Wales =
        _prefixId.prefix "Rank_Sergeant_Major_Instructor_Wales"

    let Rank_Sergeant_Pilot = _prefixId.prefix "Rank_Sergeant_Pilot"
    let Rank_Sergeant_Pilot_Australia = _prefixId.prefix "Rank_Sergeant_Pilot_Australia"
    let Rank_Sergeant_Pilot_Canada = _prefixId.prefix "Rank_Sergeant_Pilot_Canada"

    let Rank_Sergeant_Pilot_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Sergeant_Pilot_Commonwealth_of_Nations"

    let Rank_Sergeant_Pilot_England = _prefixId.prefix "Rank_Sergeant_Pilot_England"
    let Rank_Sergeant_Pilot_Scotland = _prefixId.prefix "Rank_Sergeant_Pilot_Scotland"
    let Rank_Sergeant_Pilot_Wales = _prefixId.prefix "Rank_Sergeant_Pilot_Wales"

    let Rank_Sergeant_major_EnglishTradition =
        _prefixId.prefix "Rank_Sergeant_major_EnglishTradition"

    let Rank_Skeuophoros = _prefixId.prefix "Rank_Skeuophoros"

    let Rank_Skeuophoros_Achaean_League =
        _prefixId.prefix "Rank_Skeuophoros_Achaean_League"

    let Rank_Skeuophoros_Macedonia = _prefixId.prefix "Rank_Skeuophoros_Macedonia"
    let Rank_Somatophylakes = _prefixId.prefix "Rank_Somatophylakes"

    let Rank_Somatophylakes_Achaean_League =
        _prefixId.prefix "Rank_Somatophylakes_Achaean_League"

    let Rank_Somatophylakes_Macedonia = _prefixId.prefix "Rank_Somatophylakes_Macedonia"
    let Rank_Sotnik = _prefixId.prefix "Rank_Sotnik"
    let Rank_Sotnik_Russia = _prefixId.prefix "Rank_Sotnik_Russia"
    let Rank_Sotnik_Soviet_Union = _prefixId.prefix "Rank_Sotnik_Soviet_Union"
    let Rank_Sotnik_Ukraine = _prefixId.prefix "Rank_Sotnik_Ukraine"
    let Rank_Sowi = _prefixId.prefix "Rank_Sowi"
    let Rank_Sowi_North_Korea = _prefixId.prefix "Rank_Sowi_North_Korea"
    let Rank_Sowi_South_Korea = _prefixId.prefix "Rank_Sowi_South_Korea"

    let Rank_Squadron_leader_EnglishTradition =
        _prefixId.prefix "Rank_Squadron_leader_EnglishTradition"

    let Rank_Staabikapten = _prefixId.prefix "Rank_Staabikapten"
    let Rank_Staabikapten_Estonia = _prefixId.prefix "Rank_Staabikapten_Estonia"

    let Rank_Staabikapten_Republic_of_Estonia_1920_1940 =
        _prefixId.prefix "Rank_Staabikapten_Republic_of_Estonia_1920-1940"

    let Rank_Stabskapitan = _prefixId.prefix "Rank_Stabskapitan"
    let Rank_Stabskapitan_Germany = _prefixId.prefix "Rank_Stabskapitan_Germany"
    let Rank_Stabskapitan_Russia = _prefixId.prefix "Rank_Stabskapitan_Russia"

    let Rank_Stabskapitan_Soviet_Union =
        _prefixId.prefix "Rank_Stabskapitan_Soviet_Union"

    let Rank_Stabskapitanleutnant = _prefixId.prefix "Rank_Stabskapitanleutnant"

    let Rank_Stabskapitanleutnant_Germany =
        _prefixId.prefix "Rank_Stabskapitanleutnant_Germany"

    let Rank_Staff_Corporal = _prefixId.prefix "Rank_Staff_Corporal"
    let Rank_Staff_Corporal_England = _prefixId.prefix "Rank_Staff_Corporal_England"
    let Rank_Staff_Corporal_Scotland = _prefixId.prefix "Rank_Staff_Corporal_Scotland"
    let Rank_Staff_Corporal_Wales = _prefixId.prefix "Rank_Staff_Corporal_Wales"
    let Rank_Staff_Sergeant_Major = _prefixId.prefix "Rank_Staff_Sergeant_Major"

    let Rank_Staff_Sergeant_Major_England =
        _prefixId.prefix "Rank_Staff_Sergeant_Major_England"

    let Rank_Staff_Sergeant_Major_Scotland =
        _prefixId.prefix "Rank_Staff_Sergeant_Major_Scotland"

    let Rank_Staff_Sergeant_Major_Wales =
        _prefixId.prefix "Rank_Staff_Sergeant_Major_Wales"

    let Rank_Staff_sergeant = _prefixId.prefix "Rank_Staff_sergeant"
    let Rank_Staff_sergeant_Australia = _prefixId.prefix "Rank_Staff_sergeant_Australia"
    let Rank_Staff_sergeant_Canada = _prefixId.prefix "Rank_Staff_sergeant_Canada"

    let Rank_Staff_sergeant_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Staff_sergeant_Commonwealth_of_Nations"

    let Rank_Staff_sergeant_Singapore = _prefixId.prefix "Rank_Staff_sergeant_Singapore"
    let Rank_Starshina = _prefixId.prefix "Rank_Starshina"
    let Rank_Starshina_Russia = _prefixId.prefix "Rank_Starshina_Russia"
    let Rank_Starshina_Soviet_Union = _prefixId.prefix "Rank_Starshina_Soviet_Union"
    let Rank_Starshina_Ukraine = _prefixId.prefix "Rank_Starshina_Ukraine"
    let Rank_Stratarches = _prefixId.prefix "Rank_Stratarches"

    let Rank_Stratarches_Byzantine_Empire =
        _prefixId.prefix "Rank_Stratarches_Byzantine_Empire"

    let Rank_Stratarches_Greece = _prefixId.prefix "Rank_Stratarches_Greece"

    let Rank_Stratarches_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Stratarches_Official_Timocracy_of_Sapinetia"

    let Rank_Strategos = _prefixId.prefix "Rank_Strategos"
    let Rank_Strategos_Achaean_League = _prefixId.prefix "Rank_Strategos_Achaean_League"

    let Rank_Strategos_Byzantine_Empire =
        _prefixId.prefix "Rank_Strategos_Byzantine_Empire"

    let Rank_Strategos_Greece = _prefixId.prefix "Rank_Strategos_Greece"
    let Rank_Strategos_Macedonia = _prefixId.prefix "Rank_Strategos_Macedonia"

    let Rank_Strategos_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Strategos_Official_Timocracy_of_Sapinetia"

    let Rank_Strategos_autokrator = _prefixId.prefix "Rank_Strategos_autokrator"

    let Rank_Strategos_autokrator_Byzantine_Empire =
        _prefixId.prefix "Rank_Strategos_autokrator_Byzantine_Empire"

    let Rank_Sub_lieutenant_EnglishTradition =
        _prefixId.prefix "Rank_Sub-lieutenant_EnglishTradition"

    let ``Rank_Suba%C5%9Fi`` = _prefixId.prefix "Rank_Suba%C5%9Fi"
    let Rank_Subaltern = _prefixId.prefix "Rank_Subaltern"
    let Rank_Subaltern_England = _prefixId.prefix "Rank_Subaltern_England"
    let Rank_Subaltern_Scotland = _prefixId.prefix "Rank_Subaltern_Scotland"
    let Rank_Subaltern_Wales = _prefixId.prefix "Rank_Subaltern_Wales"
    let Rank_Subasi = _prefixId.prefix "Rank_Subasi"
    let Rank_Subasi_Cossack_Hetmanate = _prefixId.prefix "Rank_Subasi_Cossack_Hetmanate"
    let Rank_Subasi_Ottoman_Empire = _prefixId.prefix "Rank_Subasi_Ottoman_Empire"

    let Rank_Subasi_Septinsular_Republic =
        _prefixId.prefix "Rank_Subasi_Septinsular_Republic"

    let Rank_Syntagmatarchis = _prefixId.prefix "Rank_Syntagmatarchis"

    let Rank_Syntagmatarchis_Achaean_League =
        _prefixId.prefix "Rank_Syntagmatarchis_Achaean_League"

    let Rank_Syntagmatarchis_Greece = _prefixId.prefix "Rank_Syntagmatarchis_Greece"

    let Rank_Syntagmatarchis_Macedonia =
        _prefixId.prefix "Rank_Syntagmatarchis_Macedonia"

    let Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Syntagmatarchis_Official_Timocracy_of_Sapinetia"

    let Rank_Tagmatarchis = _prefixId.prefix "Rank_Tagmatarchis"

    let Rank_Tagmatarchis_Achaean_League =
        _prefixId.prefix "Rank_Tagmatarchis_Achaean_League"

    let Rank_Tagmatarchis_Greece = _prefixId.prefix "Rank_Tagmatarchis_Greece"
    let Rank_Tagmatarchis_Macedonia = _prefixId.prefix "Rank_Tagmatarchis_Macedonia"

    let Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Tagmatarchis_Official_Timocracy_of_Sapinetia"

    let Rank_Taxiarch = _prefixId.prefix "Rank_Taxiarch"
    let Rank_Taxiarch_Achaean_League = _prefixId.prefix "Rank_Taxiarch_Achaean_League"

    let Rank_Taxiarch_Byzantine_Empire =
        _prefixId.prefix "Rank_Taxiarch_Byzantine_Empire"

    let Rank_Taxiarch_Greece = _prefixId.prefix "Rank_Taxiarch_Greece"
    let Rank_Taxiarch_Macedonia = _prefixId.prefix "Rank_Taxiarch_Macedonia"

    let Rank_Taxiarch_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Taxiarch_Official_Timocracy_of_Sapinetia"

    let Rank_Tetrarch = _prefixId.prefix "Rank_Tetrarch"
    let Rank_Tetrarch_Achaean_League = _prefixId.prefix "Rank_Tetrarch_Achaean_League"
    let Rank_Tetrarch_Macedonia = _prefixId.prefix "Rank_Tetrarch_Macedonia"
    let Rank_Trierarch = _prefixId.prefix "Rank_Trierarch"
    let Rank_Trierarch_Achaean_League = _prefixId.prefix "Rank_Trierarch_Achaean_League"
    let Rank_Trierarch_Macedonia = _prefixId.prefix "Rank_Trierarch_Macedonia"
    let Rank_Trooper = _prefixId.prefix "Rank_Trooper"
    let Rank_Trooper_Australia = _prefixId.prefix "Rank_Trooper_Australia"
    let Rank_Trooper_Canada = _prefixId.prefix "Rank_Trooper_Canada"

    let Rank_Trooper_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Trooper_Commonwealth_of_Nations"

    let Rank_Trumpet_Major = _prefixId.prefix "Rank_Trumpet_Major"

    let Rank_Trumpet_Major_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Trumpet_Major_Commonwealth_of_Nations"

    let Rank_Trumpet_Major_England = _prefixId.prefix "Rank_Trumpet_Major_England"
    let Rank_Trumpet_Major_Scotland = _prefixId.prefix "Rank_Trumpet_Major_Scotland"
    let Rank_Trumpet_Major_Wales = _prefixId.prefix "Rank_Trumpet_Major_Wales"
    let Rank_Tysyatsky = _prefixId.prefix "Rank_Tysyatsky"
    let Rank_Tysyatsky_Russia = _prefixId.prefix "Rank_Tysyatsky_Russia"
    let Rank_Tysyatsky_Soviet_Union = _prefixId.prefix "Rank_Tysyatsky_Soviet_Union"
    let Rank_Under_Officer = _prefixId.prefix "Rank_Under_Officer"
    let Rank_Under_Officer_Australia = _prefixId.prefix "Rank_Under_Officer_Australia"

    let Rank_Under_Officer_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Under_Officer_Commonwealth_of_Nations"

    let Rank_Under_Officer_England = _prefixId.prefix "Rank_Under_Officer_England"
    let Rank_Under_Officer_Scotland = _prefixId.prefix "Rank_Under_Officer_Scotland"
    let Rank_Under_Officer_Wales = _prefixId.prefix "Rank_Under_Officer_Wales"
    let Rank_Vaapeli = _prefixId.prefix "Rank_Vaapeli"
    let Rank_Vaapeli_Finland = _prefixId.prefix "Rank_Vaapeli_Finland"
    let Rank_Vaapeli_Sweden = _prefixId.prefix "Rank_Vaapeli_Sweden"
    let Rank_Veebel = _prefixId.prefix "Rank_Veebel"
    let Rank_Veebel_Estonia = _prefixId.prefix "Rank_Veebel_Estonia"

    let Rank_Veebel_Republic_of_Estonia_1920_1940 =
        _prefixId.prefix "Rank_Veebel_Republic_of_Estonia_1920-1940"

    let Rank_Vice_Admiral_of_the_Coast =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_Coast"

    let Rank_Vice_Admiral_of_the_Coast_England =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_Coast_England"

    let Rank_Vice_Admiral_of_the_Coast_Scotland =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_Coast_Scotland"

    let Rank_Vice_Admiral_of_the_Coast_Wales =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_Coast_Wales"

    let Rank_Vice_Admiral_of_the_West = _prefixId.prefix "Rank_Vice-Admiral_of_the_West"

    let Rank_Vice_Admiral_of_the_West_England =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_West_England"

    let Rank_Vice_Admiral_of_the_West_Scotland =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_West_Scotland"

    let Rank_Vice_Admiral_of_the_West_Wales =
        _prefixId.prefix "Rank_Vice-Admiral_of_the_West_Wales"

    let Rank_Vice_admiral = _prefixId.prefix "Rank_Vice_admiral"
    let Rank_Vice_admiral_Australia = _prefixId.prefix "Rank_Vice_admiral_Australia"

    let Rank_Vice_admiral_Australia_Australia =
        _prefixId.prefix "Rank_Vice_admiral_Australia_Australia"

    let Rank_Vice_admiral_Canada = _prefixId.prefix "Rank_Vice_admiral_Canada"
    let Rank_Wachtmeister = _prefixId.prefix "Rank_Wachtmeister"
    let Rank_Wachtmeister_Germany = _prefixId.prefix "Rank_Wachtmeister_Germany"
    let Rank_Wachtmeister_Russia = _prefixId.prefix "Rank_Wachtmeister_Russia"

    let Rank_Wachtmeister_Soviet_Union =
        _prefixId.prefix "Rank_Wachtmeister_Soviet_Union"

    let Rank_Warrant_officer_EnglishTradition =
        _prefixId.prefix "Rank_Warrant_officer_EnglishTradition"

    let Rank_Warrant_officer_United_Kingdom =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom"

    let Rank_Warrant_officer_United_Kingdom_Australia =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom_Australia"

    let Rank_Warrant_officer_United_Kingdom_Canada =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom_Canada"

    let Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom_Commonwealth_of_Nations"

    let Rank_Warrant_officer_United_Kingdom_England =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom_England"

    let Rank_Warrant_officer_United_Kingdom_Scotland =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom_Scotland"

    let Rank_Warrant_officer_United_Kingdom_Wales =
        _prefixId.prefix "Rank_Warrant_officer_United_Kingdom_Wales"

    let Rank_Wing_commander = _prefixId.prefix "Rank_Wing_commander"

    let Rank_Wing_commander_rank_EnglishTradition =
        _prefixId.prefix "Rank_Wing_commander_(rank)_EnglishTradition"

    let Rank_Wing_commander_Australia = _prefixId.prefix "Rank_Wing_commander_Australia"
    let Rank_Wing_commander_Canada = _prefixId.prefix "Rank_Wing_commander_Canada"

    let Rank_Wing_commander_Commonwealth_of_Nations =
        _prefixId.prefix "Rank_Wing_commander_Commonwealth_of_Nations"

    let Rank_Wojski = _prefixId.prefix "Rank_Wojski"
    let Rank_Wojski_Lithuania = _prefixId.prefix "Rank_Wojski_Lithuania"
    let Rank_Wojski_Poland = _prefixId.prefix "Rank_Wojski_Poland"
    let Rank_Wonsu = _prefixId.prefix "Rank_Wonsu"
    let Rank_Wonsu_North_Korea = _prefixId.prefix "Rank_Wonsu_North_Korea"
    let Rank_Wonsu_South_Korea = _prefixId.prefix "Rank_Wonsu_South_Korea"
    let Rank_Yesaul = _prefixId.prefix "Rank_Yesaul"
    let Rank_Yesaul_Russia = _prefixId.prefix "Rank_Yesaul_Russia"
    let Rank_Yesaul_Soviet_Union = _prefixId.prefix "Rank_Yesaul_Soviet_Union"
    let Rank_Yesaul_Ukraine = _prefixId.prefix "Rank_Yesaul_Ukraine"
    let Rank_Ypolochagos = _prefixId.prefix "Rank_Ypolochagos"
    let Rank_Ypolochagos_Greece = _prefixId.prefix "Rank_Ypolochagos_Greece"

    let Rank_Ypolochagos_Official_Timocracy_of_Sapinetia =
        _prefixId.prefix "Rank_Ypolochagos_Official_Timocracy_of_Sapinetia"

    /// <summary>
    ///   <para>skos:definition : A regiment, be it administrative or historical.</para>
    ///   <para>rdfs:label : Régimentrdfs:label : Regimentrdfs:label : Regiment</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Regiment">mil:Regiment</a>
    /// </summary>
    let Regiment = _prefixId.prefix "Regiment"
    /// <summary>
    ///   <para>skos:definition : Flag used by a regiment on a battlefield or on parade.</para>
    ///   <para>rdfs:label : rdfs:label : Drapeau du Regimentrdfs:label : Regimental Colours</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#RegimentalColours">mil:RegimentalColours</a>
    /// </summary>
    let RegimentalColours = _prefixId.prefix "RegimentalColours"
    /// <summary>
    ///   <para>rdfs:label : Soldat Régulierrdfs:label : regulärer Soldatrdfs:label : Regular Soldier</para>
    ///   <para>skos:definition : A soldier who serves on a full-time basis.</para>
    ///   <para>foaf:name : Regular Soldier^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#RegularForceSoldier">mil:RegularForceSoldier</a>
    /// </summary>
    let RegularForceSoldier = _prefixId.prefix "RegularForceSoldier"
    /// <summary>
    ///   <para>rdfs:label : Soldat Réservisterdfs:label : Reservist (Soldier)rdfs:label : Reservist (Soldat)</para>
    ///   <para>skos:definition : A soldier who serves on a part-time basis or when called up.</para>
    ///   <para>foaf:name : Reservist^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Reservist">mil:Reservist</a>
    /// </summary>
    let Reservist = _prefixId.prefix "Reservist"
    /// <summary>
    ///   <para>rdfs:label : Role</para>
    ///   <para>foaf:name : Role^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Role">mil:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Matelot (Militare)rdfs:label : Matrose (Militär)rdfs:label : Seaman (Military)</para>
    ///   <para>skos:definition : A Seaman serving in a political entity's Navy.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#SeamanMilitary">mil:SeamanMilitary</a>
    /// </summary>
    let SeamanMilitary = _prefixId.prefix "SeamanMilitary"
    /// <summary>
    ///   <para>rdfs:label : Navirerdfs:label : Ship</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Ship">mil:Ship</a>
    /// </summary>
    let Ship = _prefixId.prefix "Ship"
    /// <summary>
    ///   <para>rdfs:label : Ufer Gründung (Kriegsmarine)rdfs:label : Shore Establishment (Navy)rdfs:label : Etablishment de Terre (Marine)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#ShoreEstablishment">mil:ShoreEstablishment</a>
    /// </summary>
    let ShoreEstablishment = _prefixId.prefix "ShoreEstablishment"
    /// <summary>
    ///   <para>rdfs:label : Soldatrdfs:label : Soldatrdfs:label : Soldier</para>
    ///   <para>foaf:name : Soldier^^xsd:string</para>
    ///   <para>skos:definition : A soldier serving in a political entity's Army.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Soldier">mil:Soldier</a>
    /// </summary>
    let Soldier = _prefixId.prefix "Soldier"
    /// <summary>
    ///   <para>rdfs:label : Spyrdfs:label : Espionrdfs:label : Spion</para>
    ///   <para>foaf:name : Spy^^xsd:string</para>
    ///   <para>skos:definition : A person engaging in combat, war and/or espionage as an unprivileged combatant under the rules of war.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Spy">mil:Spy</a>
    /// </summary>
    let Spy = _prefixId.prefix "Spy"
    /// <summary>
    ///   <para>rdfs:label : Schwadronrdfs:label : Escadronrdfs:label : Squadron (unit)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Squadron">mil:Squadron</a>
    /// </summary>
    let Squadron = _prefixId.prefix "Squadron"
    /// <summary>
    ///   <para>skos:definition : A supply organization moving military supplies.</para>
    ///   <para>rdfs:label : liefern dem Zug (Militär)rdfs:label : Train D'alimentation (Military)rdfs:label : Supply Train (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#SupplyTrain">mil:SupplyTrain</a>
    /// </summary>
    let SupplyTrain = _prefixId.prefix "SupplyTrain"
    /// <summary>
    ///   <para>rdfs:label : Force Aérienne Tactique rdfs:label : Tactical Air Forcerdfs:label : Luftstreitkräfte (taktisch)</para>
    ///   <para>skos:definition : Tactical Air Force.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#TacticalAirForce">mil:TacticalAirForce</a>
    /// </summary>
    let TacticalAirForce = _prefixId.prefix "TacticalAirForce"
    /// <summary>
    ///   <para>skos:definition : A Civilian trade.</para>
    ///   <para>rdfs:label : Occupation Professionelle (Civil)rdfs:label : Trade (Civil)</para>
    ///   <para>foaf:name : Trade^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Trade">mil:Trade</a>
    /// </summary>
    let Trade = _prefixId.prefix "Trade"
    /// <summary>
    ///   <para>skos:definition : A wooden or metal structure meant to restrict ennemy mouvement.</para>
    ///   <para>rdfs:label : Trench Obstacle</para>
    ///   <para>foaf:name : Trench Obstacle^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#TrenchObstacle">mil:TrenchObstacle</a>
    /// </summary>
    let TrenchObstacle = _prefixId.prefix "TrenchObstacle"
    /// <summary>
    ///   <para>skos:definition : A person engaging in combat and/or war as an unprivileged combatants under the rules of war.</para>
    ///   <para>foaf:name : Unprivileged Combatant^^xsd:string</para>
    ///   <para>rdfs:label : Combatant non-privilégiérdfs:label : Unprivileged Combatantrdfs:label : unprivilegierten Kämpfer</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#UnprivilegedCombatant">mil:UnprivilegedCombatant</a>
    /// </summary>
    let UnprivilegedCombatant = _prefixId.prefix "UnprivilegedCombatant"
    /// <summary>
    ///   <para>foaf:name : Volunteer^^xsd:string</para>
    ///   <para>skos:definition : A soldier which serves on a full-time basis.</para>
    ///   <para>rdfs:label : Soldat (Volontaire)rdfs:label : Soldat (freiwilliger)rdfs:label : Soldier (Volunteer)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#VolunteerSoldier">mil:VolunteerSoldier</a>
    /// </summary>
    let VolunteerSoldier = _prefixId.prefix "VolunteerSoldier"
    /// <summary>
    ///   <para>foaf:name : War^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#War">mil:War</a>
    /// </summary>
    let War = _prefixId.prefix "War"
    /// <summary>
    ///   <para>rdfs:label : Théâtre militairerdfs:label : Theater (warfare)rdfs:label : Kriegsschauplatz</para>
    ///   <para>skos:definition : An army theater of war.</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#WarTheater">mil:WarTheater</a>
    /// </summary>
    let WarTheater = _prefixId.prefix "WarTheater"
    /// <summary>
    ///   <para>skos:definition : A senior non-officer .</para>
    ///   <para>rdfs:label : Warrant Officerrdfs:label : Officiers Mariniersrdfs:label : ?</para>
    ///   <para>foaf:name : Warrant Officer^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#WarrantOfficer">mil:WarrantOfficer</a>
    /// </summary>
    let WarrantOfficer = _prefixId.prefix "WarrantOfficer"
    /// <summary>
    ///   <para>rdfs:label : Navire Militarerdfs:label : Warship</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Warship">mil:Warship</a>
    /// </summary>
    let Warship = _prefixId.prefix "Warship"
    let WaterBasedOrganization = _prefixId.prefix "WaterBasedOrganization"
    /// <summary>
    ///   <para>skos:definition : A weapon type but not a branch.</para>
    ///   <para>rdfs:label : Waffe (Militär)rdfs:label : Arme (Military)rdfs:label : Weapon (Military)</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#Weapon">mil:Weapon</a>
    /// </summary>
    let Weapon = _prefixId.prefix "Weapon"
    /// <summary>
    ///   <para>rdfs:label : Allegiance</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#allegiance">mil:allegiance</a>
    /// </summary>
    let allegiance = _prefixId.prefix "allegiance"
    /// <summary>
    ///   <para>rdfs:label : Commander In Chief of</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#commanderInChiefOf">mil:commanderInChiefOf</a>
    /// </summary>
    let commanderInChiefOf = _prefixId.prefix "commanderInChiefOf"
    let datasetdefinition = _prefixId.prefix "datasetdefinition"
    /// <summary>
    ///   <para>skos:definition : The day on which this agent died. Birthday is inhereited from foaf.</para>
    ///   <para>foaf:name : deathDay^^xsd:string</para>
    ///   <para>rdfs:label : Day of Death</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#deathDay">mil:deathDay</a>
    /// </summary>
    let deathDay = _prefixId.prefix "deathDay"
    /// <summary>
    ///   <para>rdfs:label : Epaulets</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#epauletDepiction">mil:epauletDepiction</a>
    /// </summary>
    let epauletDepiction = _prefixId.prefix "epauletDepiction"
    /// <summary>
    ///   <para>rdfs:label : Commander In Chief</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#hasCommanderInChief">mil:hasCommanderInChief</a>
    /// </summary>
    let hasCommanderInChief = _prefixId.prefix "hasCommanderInChief"
    /// <summary>
    ///   <para>rdfs:label : has Principal</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#hasPrincipal">mil:hasPrincipal</a>
    /// </summary>
    let hasPrincipal = _prefixId.prefix "hasPrincipal"
    /// <summary>
    ///   <para>rdfs:label : Has Uniform</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#hasUniform">mil:hasUniform</a>
    /// </summary>
    let hasUniform = _prefixId.prefix "hasUniform"
    /// <summary>
    ///   <para>rdfs:label : Held Rank</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#heldRank">mil:heldRank</a>
    /// </summary>
    let heldRank = _prefixId.prefix "heldRank"
    /// <summary>
    ///   <para>skos:definition : Identifier used by the Australian archives to uniquely identify people involved in the Great War.</para>
    ///   <para>rdfs:label : Australian Archives Anzac Person Identifier</para>
    ///   <para>foaf:name : Australian Archives Anzac Person Identifier</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#idANZACNumber">mil:idANZACNumber</a>
    /// </summary>
    let idANZACNumber = _prefixId.prefix "idANZACNumber"
    /// <summary>
    ///   <para>rdfs:label : In Use</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#inUse">mil:inUse</a>
    /// </summary>
    let inUse = _prefixId.prefix "inUse"
    let information = _prefixId.prefix "information"
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>skos:definition : A military service number within a military organization which may or might not be unique.</para>
    ///   <para>rdfs:label : Military Service Number</para>
    ///   <para>foaf:name : Military Service Number</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#militaryServiceNumber">mil:militaryServiceNumber</a>
    /// </summary>
    let militaryServiceNumber = _prefixId.prefix "militaryServiceNumber"
    /// <summary>
    ///   <para>skos:definition : A person with a loose family / emotional connection that is listed by someone to be contacted in the event of death. This is a loosely defined term meant for commemoration and honour roll purposes.This term does not provide a hook for provenance information.</para>
    ///   <para>foaf:name : Next Of Kin</para>
    ///   <para>rdfs:label : Next Of Kin</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#nextOfKin">mil:nextOfKin</a>
    /// </summary>
    let nextOfKin = _prefixId.prefix "nextOfKin"
    /// <summary>
    ///   <para>rdfs:label : Nominal Unit Size</para>
    ///   <para>foaf:name : Nominal unit size^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#nominalSize">mil:nominalSize</a>
    /// </summary>
    let nominalSize = _prefixId.prefix "nominalSize"
    /// <summary>
    ///   <para>skos:definition : The place of initial enlistment into a military. This is property that is meant for commemoration purposes. For bureaucratic and historical reasons, this property may occur more than once.This term does not provide a hook for provenance information.</para>
    ///   <para>foaf:name : Place Of Enlistment</para>
    ///   <para>rdfs:label : Place Of Enlistment</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#placeOfEnlistment">mil:placeOfEnlistment</a>
    /// </summary>
    let placeOfEnlistment = _prefixId.prefix "placeOfEnlistment"
    /// <summary>
    ///   <para>rdfs:label : Rank used by</para>
    ///   <para>foaf:name : rankOf^^xsd:string</para>
    ///   <a href="http://rdf.muninn-project.org/ontologies/military#rankOf">mil:rankOf</a>
    /// </summary>
    let rankOf = _prefixId.prefix "rankOf"
    let regiment = _prefixId.prefix "regiment"
    let ship = _prefixId.prefix "ship"
    let spacethefinalfrontier = _prefixId.prefix "spacethefinalfrontier"
    let toUnit = _prefixId.prefix "toUnit"
    let warship = _prefixId.prefix "warship"
