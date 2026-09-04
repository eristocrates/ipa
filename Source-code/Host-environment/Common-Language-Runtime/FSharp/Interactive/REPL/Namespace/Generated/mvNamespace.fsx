#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module mv =
    let _prefixId = PrefixId.fromNamespaceLabel "http://schema.mobivoc.org/" "mv"
    let _namespaceIri = _prefixId.prefix ""
    let AS_3112_Type_I = _prefixId.prefix "AS_3112_Type_I"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-08-29^^xsd:date</para>
    ///   <para>rdfs:label : Access conditionrdfs:label : Zugangsbedingung</para>
    ///   <para>rdfs:comment : A condition that has to be fullfilled to get access to a civic structure.</para>
    ///   <a href="http://schema.mobivoc.org/AccessCondition">mv:AccessCondition</a>
    /// </summary>
    let AccessCondition = _prefixId.prefix "AccessCondition"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-06-23^^xsd:date</para>
    ///   <para>rdfs:label : Aktionrdfs:label : Action</para>
    ///   <para>rdfs:comment : Action that is done.</para>
    ///   <a href="http://schema.mobivoc.org/Action">mv:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    let AllParkingFacilitiesFull = _prefixId.prefix "AllParkingFacilitiesFull"
    let Allow = _prefixId.prefix "Allow"
    let AngleParking = _prefixId.prefix "AngleParking"
    /// <summary>
    ///   <para>rdfs:comment : Art und Weise, wie ein Fahrzeug auf einer Parkfläche aufgestellt wird.rdfs:comment : Pattern how parking spaces are arranged in a parking facility or at roadside.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <para>rdfs:label : Arrangement patternrdfs:label : Aufstellart</para>
    ///   <a href="http://schema.mobivoc.org/ArrangementPattern">mv:ArrangementPattern</a>
    /// </summary>
    let ArrangementPattern = _prefixId.prefix "ArrangementPattern"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Parking garage with an automated parking system that automatically moves cars to the available parking space somewhere in the garage.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Automatisches Parkhausrdfs:label : Automated parking garage</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/AutomatedParkingGarage">mv:AutomatedParkingGarage</a>
    /// </summary>
    let AutomatedParkingGarage = _prefixId.prefix "AutomatedParkingGarage"
    let BS1363 = _prefixId.prefix "BS1363"
    let Bicycle = _prefixId.prefix "Bicycle"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fahrradparkstationrdfs:label : Bicycle parking station</para>
    ///   <para>rdfs:comment : Building or structure designed for use as a bicycle parking facility.</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/BicycleParkingStation">mv:BicycleParkingStation</a>
    /// </summary>
    let BicycleParkingStation = _prefixId.prefix "BicycleParkingStation"
    let BikeAndRide = _prefixId.prefix "BikeAndRide"
    let BusOrCoach = _prefixId.prefix "BusOrCoach"
    let CCS_Type2 = _prefixId.prefix "CCS_Type2"
    let CEE_7_Pin = _prefixId.prefix "CEE_7-Pin"
    let CEE_7_16 = _prefixId.prefix "CEE_7_16"
    let CEE_7_4 = _prefixId.prefix "CEE_7_4"
    let CEE_7_5 = _prefixId.prefix "CEE_7_5"
    let CHAdeMO = _prefixId.prefix "CHAdeMO"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>rdfs:label : Kapazitätrdfs:label : Capacity</para>
    ///   <para>rdfs:comment : Capacity of a civic structure.</para>
    ///   <a href="http://schema.mobivoc.org/Capacity">mv:Capacity</a>
    /// </summary>
    let Capacity = _prefixId.prefix "Capacity"
    let Car = _prefixId.prefix "Car"
    let Carpooling = _prefixId.prefix "Carpooling"
    let CarsharingUsers = _prefixId.prefix "CarsharingUsers"
    /// <summary>
    ///   <para>rdfs:label : Ladegerätrdfs:label : Charger</para>
    ///   <para>rdfs:comment : Component of a charging point used to charge electric vehicles. A charging point can have one or more chargers.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/Charger">mv:Charger</a>
    /// </summary>
    let Charger = _prefixId.prefix "Charger"
    /// <summary>
    ///   <para>rdfs:label : Charging pointrdfs:label : Ladestation</para>
    ///   <para>rdfs:comment : Civic structure that supplies electric energy for the recharging of electric vehicles.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/ChargingPoint">mv:ChargingPoint</a>
    /// </summary>
    let ChargingPoint = _prefixId.prefix "ChargingPoint"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2018-01-11^^xsd:date</para>
    ///   <para>rdfs:label : Civic structure statusrdfs:label : Status der Parkeinrichtung</para>
    ///   <para>rdfs:comment : Status information of a civic structure.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/CivicStructureStatus">mv:CivicStructureStatus</a>
    /// </summary>
    let CivicStructureStatus = _prefixId.prefix "CivicStructureStatus"
    let Closed = _prefixId.prefix "Closed"
    let ElectricVehicle = _prefixId.prefix "ElectricVehicle"
    let EnoughParkingSpacesAvailable = _prefixId.prefix "EnoughParkingSpacesAvailable"
    let Families = _prefixId.prefix "Families"
    let Faulty = _prefixId.prefix "Faulty"
    let Full = _prefixId.prefix "Full"
    let IEC_60309_16A_2_E = _prefixId.prefix "IEC_60309_16A_2_E"
    let IEC_60309_3_pin = _prefixId.prefix "IEC_60309_3-pin"
    let IEC_60309_5_pin = _prefixId.prefix "IEC_60309_5-pin"
    let IEC_62196_Type_3A = _prefixId.prefix "IEC_62196_Type_3A"
    let IEC_62196_Type_3C = _prefixId.prefix "IEC_62196_Type_3C"
    let Inhabitants = _prefixId.prefix "Inhabitants"
    let Mennekes_Type_2 = _prefixId.prefix "Mennekes_Type_2"
    let Motorbike = _prefixId.prefix "Motorbike"
    let NEMA_14_30 = _prefixId.prefix "NEMA_14-30"
    let NEMA_14_50 = _prefixId.prefix "NEMA_14-50"
    let NEMA_5_15R = _prefixId.prefix "NEMA_5-15R"
    let NEMA_5_20R = _prefixId.prefix "NEMA_5-20R"
    let NEMA_6_15 = _prefixId.prefix "NEMA_6-15"
    let NEMA_6_20 = _prefixId.prefix "NEMA_6-20"
    let NoParkAndRideInformation = _prefixId.prefix "NoParkAndRideInformation"
    let NoParkingAllowed = _prefixId.prefix "NoParkingAllowed"
    let NoParkingInformationAvailable = _prefixId.prefix "NoParkingInformationAvailable"

    let NormalParkingRestrictionsLifted =
        _prefixId.prefix "NormalParkingRestrictionsLifted"

    let OnlyAFewParkingSpacesAvailable =
        _prefixId.prefix "OnlyAFewParkingSpacesAvailable"

    let Operational = _prefixId.prefix "Operational"
    let ParallelParking = _prefixId.prefix "ParallelParking"
    let ParkAndFly = _prefixId.prefix "ParkAndFly"
    let ParkAndRail = _prefixId.prefix "ParkAndRail"
    let ParkAndRide = _prefixId.prefix "ParkAndRide"

    let ParkAndRideServiceNotOperating =
        _prefixId.prefix "ParkAndRideServiceNotOperating"

    let ParkAndRideServiceOperating = _prefixId.prefix "ParkAndRideServiceOperating"
    let ParkingBarrier = _prefixId.prefix "ParkingBarrier"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2014-10-16^^xsd:date</para>
    ///   <para>rdfs:label : Parking facilityrdfs:label : Parkeinrichtung</para>
    ///   <para>rdfs:comment : Any facility or area assigned for parking vehicles. A parking facility can provide one or more parking spaces.</para>
    ///   <a href="http://schema.mobivoc.org/ParkingFacility">mv:ParkingFacility</a>
    /// </summary>
    let ParkingFacility = _prefixId.prefix "ParkingFacility"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-06-09^^xsd:date</para>
    ///   <para>rdfs:label : Parking facility connectionsrdfs:label : Anschlussmöglichkeiten der Parkeinrichtung</para>
    ///   <para>rdfs:comment : Transport connections available at the parking facility (e.g. Park &amp; Ride).^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/ParkingFacilityConnection">mv:ParkingFacilityConnection</a>
    /// </summary>
    let ParkingFacilityConnection = _prefixId.prefix "ParkingFacilityConnection"
    /// <summary>
    ///   <para>rdfs:comment : Entrance of a parking facility where vehicles can enter the parking facility.</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : Entrancerdfs:label : Einfahrt</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/ParkingFacilityEntrance">mv:ParkingFacilityEntrance</a>
    /// </summary>
    let ParkingFacilityEntrance = _prefixId.prefix "ParkingFacilityEntrance"
    /// <summary>
    ///   <para>rdfs:comment : Exit of a parking facility where vehicles can leave the parking facility.</para>
    ///   <para>rdfs:label : Ausfahrtrdfs:label : Exit</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/ParkingFacilityExit">mv:ParkingFacilityExit</a>
    /// </summary>
    let ParkingFacilityExit = _prefixId.prefix "ParkingFacilityExit"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>rdfs:label : Parking facility featurerdfs:label : Ausstattung der Parkeinrichtung</para>
    ///   <para>rdfs:comment : Features of the parking facility (e.g. parking for disabled people).^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/ParkingFacilityFeature">mv:ParkingFacilityFeature</a>
    /// </summary>
    let ParkingFacilityFeature = _prefixId.prefix "ParkingFacilityFeature"
    /// <summary>
    ///   <para>skos:altLabel : Hochgarageskos:altLabel : Parking structureskos:altLabel : Car parkskos:altLabel : Parking building</para>
    ///   <para>rdfs:label : Parking garagerdfs:label : Parkhaus</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>skos:prefLabel : Parking garageskos:prefLabel : Parkhaus</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : A single level or multilevel parking building to park at.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/ParkingGarage">mv:ParkingGarage</a>
    /// </summary>
    let ParkingGarage = _prefixId.prefix "ParkingGarage"
    /// <summary>
    ///   <para>rdfs:label : Parking lotrdfs:label : Parkplatz</para>
    ///   <para>rdfs:comment : Parking area on a single groundfloor level that is usually located outdoor.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>skos:altLabel : car lotskos:altLabel : Parkfläche</para>
    ///   <para>dcterms:created : 2017-05-30^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:prefLabel : Parking lotskos:prefLabel : Parkplatzskos:prefLabel : Car park</para>
    ///   <a href="http://schema.mobivoc.org/ParkingLot">mv:ParkingLot</a>
    /// </summary>
    let ParkingLot = _prefixId.prefix "ParkingLot"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:prefLabel : Stellplatzskos:prefLabel : Parking space</para>
    ///   <para>rdfs:label : Parking spacerdfs:label : Stellplatz</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : A parking space is a location that is designated for parking a vehicle. A parking space has a certain size, is sometimes marked and can be located at roadside or inside a parking facility. Depending on the location of the parking space, there can be regulations regarding the time allowed to park and a fee paid to use the parking space.</para>
    ///   <para>skos:hiddenLabel : Parkplatz</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/ParkingSpace">mv:ParkingSpace</a>
    /// </summary>
    let ParkingSpace = _prefixId.prefix "ParkingSpace"
    let PayStation = _prefixId.prefix "PayStation"
    let PerpendicularParking = _prefixId.prefix "PerpendicularParking"

    let PersonsWithDisabledParkingPermit =
        _prefixId.prefix "PersonsWithDisabledParkingPermit"

    /// <summary>
    ///   <para>rdfs:label : Plugrdfs:label : Anschluss</para>
    ///   <para>rdfs:comment : Component of a charger to connect an electric vehicle. There are different plug types used for charging electric vehicles.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/Plug">mv:Plug</a>
    /// </summary>
    let Plug = _prefixId.prefix "Plug"
    /// <summary>
    ///   <para>rdfs:label : Plug typerdfs:label : Steckertyp</para>
    ///   <para>rdfs:comment : Type of a plug that is used to connect electric vehicles.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/PlugType">mv:PlugType</a>
    /// </summary>
    let PlugType = _prefixId.prefix "PlugType"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Real-time capacity of a parking facility or parking space.rdfs:comment : Real-time capacity of a civic structure.</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-04-05^^xsd:datedcterms:created : 2017-05-15^^xsd:date</para>
    ///   <para>rdfs:label : Echtzeit Kapazitätrdfs:label : Real time capacity</para>
    ///   <a href="http://schema.mobivoc.org/RealTimeCapacity">mv:RealTimeCapacity</a>
    /// </summary>
    let RealTimeCapacity = _prefixId.prefix "RealTimeCapacity"
    let RecreationalVehicle = _prefixId.prefix "RecreationalVehicle"
    let Restrict = _prefixId.prefix "Restrict"
    let SAE_Combo = _prefixId.prefix "SAE_Combo"
    let SAE_J1772_2001 = _prefixId.prefix "SAE_J1772-2001"
    let SAE_J1772_2009 = _prefixId.prefix "SAE_J1772-2009"
    let SEV1011_Type_J = _prefixId.prefix "SEV1011_Type_J"

    let SpecialParkingRestrictionsInForce =
        _prefixId.prefix "SpecialParkingRestrictionsInForce"

    let StatusUnknown = _prefixId.prefix "StatusUnknown"
    let SurveillanceBySecurityGuards = _prefixId.prefix "SurveillanceBySecurityGuards"
    let TaxiDrivers = _prefixId.prefix "TaxiDrivers"
    let Tesla_Supercharger = _prefixId.prefix "Tesla_Supercharger"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>rdfs:label : Time specificationrdfs:label : Zeitspezifikation</para>
    ///   <para>rdfs:comment : Specific time a price specification is due for.</para>
    ///   <a href="http://schema.mobivoc.org/TimeSpecification">mv:TimeSpecification</a>
    /// </summary>
    let TimeSpecification = _prefixId.prefix "TimeSpecification"
    let Truck = _prefixId.prefix "Truck"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>skos:altLabel : Rampengarage</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>skos:prefLabel : Tiefgarageskos:prefLabel : Underground parking garage</para>
    ///   <para>rdfs:label : Tiefgaragerdfs:label : Underground parking garage</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>rdfs:comment : Parking facility with one or more levels below the surface and none above ground.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/UndergroundParkingGarage">mv:UndergroundParkingGarage</a>
    /// </summary>
    let UndergroundParkingGarage = _prefixId.prefix "UndergroundParkingGarage"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>rdfs:label : User grouprdfs:label : Nutzergruppe</para>
    ///   <para>rdfs:comment : A group of users having a common characteristic.</para>
    ///   <a href="http://schema.mobivoc.org/UserGroup">mv:UserGroup</a>
    /// </summary>
    let UserGroup = _prefixId.prefix "UserGroup"
    let VideoSurveillance = _prefixId.prefix "VideoSurveillance"
    let Women = _prefixId.prefix "Women"
    let XLR4 = _prefixId.prefix "XLR4"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a civic structure can only be accessed when certain conditions are fullfilled.</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>rdfs:label : access</para>
    ///   <a href="http://schema.mobivoc.org/access">mv:access</a>
    /// </summary>
    let access = _prefixId.prefix "access"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates which action is applied.</para>
    ///   <para>dcterms:created : 2017-06-23^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : action</para>
    ///   <a href="http://schema.mobivoc.org/action">mv:action</a>
    /// </summary>
    let action = _prefixId.prefix "action"
    /// <summary>
    ///   <para>rdfs:comment : Further information about the civic structure or facility.</para>
    ///   <para>rdfs:label : additional informationrdfs:label : zusätzliche Information</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-04-07^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/additionalInformation">mv:additionalInformation</a>
    /// </summary>
    let additionalInformation = _prefixId.prefix "additionalInformation"
    /// <summary>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates in which pattern a parking space is arranged.^^xsd:string</para>
    ///   <para>rdfs:label : arrangement patternrdfs:label : Anordnung</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/arrangement">mv:arrangement</a>
    /// </summary>
    let arrangement = _prefixId.prefix "arrangement"
    /// <summary>
    ///   <para>rdfs:label : Markerdfs:label : brand</para>
    ///   <para>rdfs:comment : Indicates the brand of a charger.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/brand">mv:brand</a>
    /// </summary>
    let brand = _prefixId.prefix "brand"
    /// <summary>
    ///   <para>rdfs:label : cable availablerdfs:label : Kabel verfügbar</para>
    ///   <para>rdfs:comment : Indicates whether the plug has a cable.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/cableAvailable">mv:cableAvailable</a>
    /// </summary>
    let cableAvailable = _prefixId.prefix "cableAvailable"
    /// <summary>
    ///   <para>rdfs:comment : Relates the civic structure to its capacity.</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>rdfs:label : hat Kapazitätrdfs:label : has capacity</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/capacity">mv:capacity</a>
    /// </summary>
    let capacity = _prefixId.prefix "capacity"
    /// <summary>
    ///   <para>rdfs:label : charger</para>
    ///   <para>rdfs:comment : Describes the charger available at a charging point. A charging point can have more than one charger.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/charger">mv:charger</a>
    /// </summary>
    let charger = _prefixId.prefix "charger"
    /// <summary>
    ///   <para>rdfs:label : Anzahl Ladepunkterdfs:label : charger quantity</para>
    ///   <para>rdfs:comment : Indicates the amount of chargers available at the charging point.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/chargerQuantity">mv:chargerQuantity</a>
    /// </summary>
    let chargerQuantity = _prefixId.prefix "chargerQuantity"
    /// <summary>
    ///   <para>rdfs:label : has charging pointrdfs:label : hat Ladestation</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates whether charging points are available.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/chargingPoint">mv:chargingPoint</a>
    /// </summary>
    let chargingPoint = _prefixId.prefix "chargingPoint"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-06-23^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the current status of the civil structure.^^xsd:string</para>
    ///   <para>rdfs:label : civic structure statusrdfs:label : hat Status der zivilen Struktur</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/civicStructureStatus">mv:civicStructureStatus</a>
    /// </summary>
    let civicStructureStatus = _prefixId.prefix "civicStructureStatus"
    /// <summary>
    ///   <para>dcterms:created : 2017-05-30^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : connected to^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the transport connections available.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/connectedTo">mv:connectedTo</a>
    /// </summary>
    let connectedTo = _prefixId.prefix "connectedTo"
    /// <summary>
    ///   <para>rdfs:label : current in A</para>
    ///   <para>rdfs:comment : Indicates the current of a charger or plug in ampere.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/currentInA">mv:currentInA</a>
    /// </summary>
    let currentInA = _prefixId.prefix "currentInA"
    /// <summary>
    ///   <para>rdfs:label : current type</para>
    ///   <para>rdfs:comment : Indicates the current type (AC/DC) of the plug.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/currentType">mv:currentType</a>
    /// </summary>
    let currentType = _prefixId.prefix "currentType"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the current value of the real-time capacity.</para>
    ///   <para>dcterms:created : 2015-05-15^^xsd:date</para>
    ///   <para>rdfs:label : current value</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/currentValue">mv:currentValue</a>
    /// </summary>
    let currentValue = _prefixId.prefix "currentValue"
    /// <summary>
    ///   <para>rdfs:label : Kunde vonrdfs:label : customer of</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-06-23^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates that a group is customer of a specific business entity.</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/customerOf">mv:customerOf</a>
    /// </summary>
    let customerOf = _prefixId.prefix "customerOf"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a price specification is due for a certain time specification.</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : due for timerdfs:label : fällig für Zeitdauer</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/dueForTime">mv:dueForTime</a>
    /// </summary>
    let dueForTime = _prefixId.prefix "dueForTime"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : employee ofrdfs:label : Mitarbeiter von</para>
    ///   <para>rdfs:comment : Indicates that a group is employee of a specific business entity.</para>
    ///   <para>dcterms:created : 2017-06-23^^xsd:date</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/employeeOf">mv:employeeOf</a>
    /// </summary>
    let employeeOf = _prefixId.prefix "employeeOf"
    /// <summary>
    ///   <para>rdfs:label : energy source</para>
    ///   <para>rdfs:comment : Indicates the energy source used for the charging point i.e. renewable etc.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/energySource">mv:energySource</a>
    /// </summary>
    let energySource = _prefixId.prefix "energySource"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : entrancerdfs:label : hat Einfahrt</para>
    ///   <para>dcterms:created : 2017-05-15^^xsd:date</para>
    ///   <para>rdfs:comment : Describes the entrance of a parking facility.</para>
    ///   <a href="http://schema.mobivoc.org/entrance">mv:entrance</a>
    /// </summary>
    let entrance = _prefixId.prefix "entrance"
    /// <summary>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <para>rdfs:comment : Describes the exit of a parking facility.^^xsd:string</para>
    ///   <para>rdfs:label : hat Ausfahrtrdfs:label : exit</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/exit">mv:exit</a>
    /// </summary>
    let exit = _prefixId.prefix "exit"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : exit rate</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>rdfs:comment : The rate at which vehicles are exiting the parking facility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/exitRate">mv:exitRate</a>
    /// </summary>
    let exitRate = _prefixId.prefix "exitRate"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates which feature the parking facility provides.^^xsd:string</para>
    ///   <para>dcterms:created : 2017-09-01^^xsd:date</para>
    ///   <para>rdfs:label : feature</para>
    ///   <a href="http://schema.mobivoc.org/feature">mv:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:comment : The rate at which vehicles are entering the parking facility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : fill rate</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/fillRate">mv:fillRate</a>
    /// </summary>
    let fillRate = _prefixId.prefix "fillRate"
    /// <summary>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : free of chargerdfs:label : kostenlos</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates that the usage of the civic structure is for free.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/freeOfCharge">mv:freeOfCharge</a>
    /// </summary>
    let freeOfCharge = _prefixId.prefix "freeOfCharge"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-05-11^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : IDrdfs:label : ID</para>
    ///   <para>rdfs:comment : ID of the entity.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/id">mv:id</a>
    /// </summary>
    let id = _prefixId.prefix "id"
    /// <summary>
    ///   <para>rdfs:label : erlaubt Schnellladenrdfs:label : is fast charge capable</para>
    ///   <para>rdfs:comment : Indicates that the charger is able to fast charge.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/isFastChargeCapable">mv:isFastChargeCapable</a>
    /// </summary>
    let isFastChargeCapable = _prefixId.prefix "isFastChargeCapable"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the level of a parking facility the parking space is located in.</para>
    ///   <para>rdfs:label : Ebenerdfs:label : level</para>
    ///   <para>dcterms:created : 2018-01-11^^xsd:date</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/level">mv:level</a>
    /// </summary>
    let level = _prefixId.prefix "level"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the maximum value of the capacity.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2015-05-15^^xsd:date</para>
    ///   <para>rdfs:label : maximum value</para>
    ///   <a href="http://schema.mobivoc.org/maximumValue">mv:maximumValue</a>
    /// </summary>
    let maximumValue = _prefixId.prefix "maximumValue"
    /// <summary>
    ///   <para>rdfs:label : Modellrdfs:label : model</para>
    ///   <para>rdfs:comment : Indicates the charger model of the charging point.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/model">mv:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>rdfs:label : Namerdfs:label : name</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Name of the civic structure or facility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/name">mv:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>dcterms:created : 2018-01-11^^xsd:date</para>
    ///   <para>rdfs:label : Anzahl Ebenenrdfs:label : number of levels</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the total number of levels a parking facility has.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/numberOfLevels">mv:numberOfLevels</a>
    /// </summary>
    let numberOfLevels = _prefixId.prefix "numberOfLevels"
    /// <summary>
    ///   <para>rdfs:label : ocm connection ID</para>
    ///   <para>rdfs:comment : The OpenChargeMap ID used for the Connection / Plug.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/ocmConnectionID">mv:ocmConnectionID</a>
    /// </summary>
    let ocmConnectionID = _prefixId.prefix "ocmConnectionID"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : betrieben vonrdfs:label : operated by</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : The operator of a civic structure or facility. Operator and owner can be different business entitites.</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/operatedBy">mv:operatedBy</a>
    /// </summary>
    let operatedBy = _prefixId.prefix "operatedBy"
    /// <summary>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>rdfs:label : über Nachtrdfs:label : overnight</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates that a time period overnight is possible.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/overnight">mv:overnight</a>
    /// </summary>
    let overnight = _prefixId.prefix "overnight"
    /// <summary>
    ///   <para>rdfs:label : in Besitz vonrdfs:label : owned by</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-04-05^^xsd:date</para>
    ///   <para>rdfs:comment : The owner of a civic structure or facility. Owner and operator can be different business entities.</para>
    ///   <a href="http://schema.mobivoc.org/ownedBy">mv:ownedBy</a>
    /// </summary>
    let ownedBy = _prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-05-15^^xsd:date</para>
    ///   <para>rdfs:label : parking spacerdfs:label : hat Stellplatz</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Relates the parking facility to a contained parking space.</para>
    ///   <a href="http://schema.mobivoc.org/parkingSpace">mv:parkingSpace</a>
    /// </summary>
    let parkingSpace = _prefixId.prefix "parkingSpace"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : Bildrdfs:label : picture</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : URL of the picture of a civic structure or facility.</para>
    ///   <a href="http://schema.mobivoc.org/picture">mv:picture</a>
    /// </summary>
    let picture = _prefixId.prefix "picture"
    /// <summary>
    ///   <para>rdfs:label : plug</para>
    ///   <para>rdfs:comment : Indicates the plugs available at a charger.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/plug">mv:plug</a>
    /// </summary>
    let plug = _prefixId.prefix "plug"
    /// <summary>
    ///   <para>rdfs:label : plug type</para>
    ///   <para>rdfs:comment : Indicates the type of a plug.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/plugType">mv:plugType</a>
    /// </summary>
    let plugType = _prefixId.prefix "plugType"
    /// <summary>
    ///   <para>rdfs:label : power in kW</para>
    ///   <para>rdfs:comment : Indicates the power of a charger or plug in kilowatts.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/powerInKW">mv:powerInKW</a>
    /// </summary>
    let powerInKW = _prefixId.prefix "powerInKW"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : pricerdfs:label : Preis</para>
    ///   <para>rdfs:comment : Indicates that a civic structure can be used for a specific price.</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/price">mv:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : Wartezeitrdfs:label : queuing time</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : The current queuing time (duration) for entering the parking facility.^^xsd:string</para>
    ///   <para>dcterms:created : 2017-05-15^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/queuingTime">mv:queuingTime</a>
    /// </summary>
    let queuingTime = _prefixId.prefix "queuingTime"
    /// <summary>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <para>rdfs:label : Belegungsraterdfs:label : rate of occupancy</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the percentage value of parking spaces occupied in a parking facility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/rateOfOccupancy">mv:rateOfOccupancy</a>
    /// </summary>
    let rateOfOccupancy = _prefixId.prefix "rateOfOccupancy"
    /// <summary>
    ///   <para>rdfs:label : three-phased current available</para>
    ///   <para>rdfs:comment : Indicates whether three-phased current is available.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/threePhasedCurrentAvailable">mv:threePhasedCurrentAvailable</a>
    /// </summary>
    let threePhasedCurrentAvailable = _prefixId.prefix "threePhasedCurrentAvailable"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the end value of a time period.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : time end valuerdfs:label : Endzeit</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/timeEndValue">mv:timeEndValue</a>
    /// </summary>
    let timeEndValue = _prefixId.prefix "timeEndValue"
    /// <summary>
    ///   <para>rdfs:label : time start valuerdfs:label : Anfangszeit</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the start value of a time period.^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/timeStartValue">mv:timeStartValue</a>
    /// </summary>
    let timeStartValue = _prefixId.prefix "timeStartValue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : time unitrdfs:label : Zeiteinheit</para>
    ///   <para>rdfs:comment : Indicates the time unit a value is specified for.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/timeUnit">mv:timeUnit</a>
    /// </summary>
    let timeUnit = _prefixId.prefix "timeUnit"
    /// <summary>
    ///   <para>rdfs:label : total capacityrdfs:label : Gesamtkapazität</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the total number of parking spaces of a parking facility.^^xsd:string</para>
    ///   <para>dcterms:created : 2017-05-10^^xsd:date</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/totalCapacity">mv:totalCapacity</a>
    /// </summary>
    let totalCapacity = _prefixId.prefix "totalCapacity"
    /// <summary>
    ///   <para>rdfs:comment : Indicates that a charge has to be paid for the usage of the civic structure.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>rdfs:label : kostenpflichtigrdfs:label : unspecified charge</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/unspecifiedCharge">mv:unspecifiedCharge</a>
    /// </summary>
    let unspecifiedCharge = _prefixId.prefix "unspecifiedCharge"
    /// <summary>
    ///   <para>rdfs:label : valid for user grouprdfs:label : gültig für Nutzergruppe</para>
    ///   <para>rdfs:comment : Indicates that an entity is valid for a specific group of users.</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>dcterms:created : 2017-09-01^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/validForUserGroup">mv:validForUserGroup</a>
    /// </summary>
    let validForUserGroup = _prefixId.prefix "validForUserGroup"
    /// <summary>
    ///   <para>rdfs:label : gültig für Fahrzeugrdfs:label : valid for vehicle</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates that an entity is valid for a specific type of vehicle.</para>
    ///   <para>dcterms:created : 2017-08-29^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/validForVehicle">mv:validForVehicle</a>
    /// </summary>
    let validForVehicle = _prefixId.prefix "validForVehicle"
    /// <summary>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the height limit in meter for vehicles using the parking facility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Höhenbegrenzung für Fahrzeugerdfs:label : vechicle height limit</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/vehicleHeightLimitInM">mv:vehicleHeightLimitInM</a>
    /// </summary>
    let vehicleHeightLimitInM = _prefixId.prefix "vehicleHeightLimitInM"
    /// <summary>
    ///   <para>rdfs:label : Längenbegrenzung für Fahrzeugerdfs:label : vehicle length limit</para>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:comment : Indicates the length limit in meter for vehicles using the parking facility.^^xsd:string</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>dcterms:created : 2017-04-13^^xsd:date</para>
    ///   <a href="http://schema.mobivoc.org/vehicleLengthLimitInM">mv:vehicleLengthLimitInM</a>
    /// </summary>
    let vehicleLengthLimitInM = _prefixId.prefix "vehicleLengthLimitInM"
    /// <summary>
    ///   <para>dcterms:modified : 2018-01-12^^xsd:date</para>
    ///   <para>rdfs:label : vehicle width limitrdfs:label : Breitenbegrenzung für Fahrzeuge</para>
    ///   <para>rdfs:comment : Indicates the width limit in meter for vehicles using the parking facility.^^xsd:string</para>
    ///   <para>dcterms:created : 2017-06-07^^xsd:date</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/vehicleWidthLimitInM">mv:vehicleWidthLimitInM</a>
    /// </summary>
    let vehicleWidthLimitInM = _prefixId.prefix "vehicleWidthLimitInM"
    /// <summary>
    ///   <para>rdfs:label : voltage in V</para>
    ///   <para>rdfs:comment : Indicates the voltage of a charger or plug in volt.^^xsd:string</para>
    ///   <a href="http://schema.mobivoc.org/voltageInV">mv:voltageInV</a>
    /// </summary>
    let voltageInV = _prefixId.prefix "voltageInV"
