namespace http.schema.mobivoc.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module mobivoc =
    let _namespace_iri = Namespace_Iri mobivoc |> NamespaceIRI
    /// <summary>
    ///   <para>mobivoc:ocmConnectionID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>The OpenChargeMap ID used for the Connection / Plug.</para>
    /// labels<para>ocm connection ID</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ocmConnectionID">http://schema.mobivoc.org/ocmConnectionID</seealso>
    let ocmConnectionID = Prefixed_Name(mobivoc, "ocmConnectionID") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:</para>
    /// </summary>
    /// <remarks>
    ///   <para>voaf:Vocabulary</para>
    ///   <para>owl:Ontology</para>
    ///   <para>Our goal is to significantly improve the data mobility between all stakeholders by providing a standardized vocabulary using Semantic Web technologies and ontologies. For the open vocabulary covering various mobility aspects we use RDF (Resource Description Framework) - a recommended specification of the World Wide Web Consortium (W3C) and the so-called lingua franca for the integration of data and web. We invite everyone who is interested to join our MobiVoc initiative and to participate in the development of the Open Mobility Vocabulary.</para>
    /// labels<para>MobiVoc: Open Mobility Vocabulary</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/">http://schema.mobivoc.org/</seealso>
    let _prefix_iri = Prefixed_Name(mobivoc, "") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:AllParkingFacilitiesFull</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>All parking facilities within a specified area are completely occupied.</para>
    /// labels<para>Alle Parkmöglichkeiten belegt</para><para>All parking facilities full</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/AllParkingFacilitiesFull">http://schema.mobivoc.org/AllParkingFacilitiesFull</seealso>
    let AllParkingFacilitiesFull =
        Prefixed_Name(mobivoc, "AllParkingFacilitiesFull") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:CivicStructureStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Status information of a civic structure.</para>
    /// labels<para>Status der Parkeinrichtung</para><para>Civic structure status</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CivicStructureStatus">http://schema.mobivoc.org/CivicStructureStatus</seealso>
    let CivicStructureStatus =
        Prefixed_Name(mobivoc, "CivicStructureStatus") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ArrangementPattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Pattern how parking spaces are arranged in a parking facility or at roadside.</para>
    ///   <para>Art und Weise, wie ein Fahrzeug auf einer Parkfläche aufgestellt wird.</para>
    /// labels<para>Arrangement pattern</para><para>Aufstellart</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ArrangementPattern">http://schema.mobivoc.org/ArrangementPattern</seealso>
    let ArrangementPattern =
        Prefixed_Name(mobivoc, "ArrangementPattern") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:Carpooling</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityConnection</para>
    ///   <para>Parking facility used for carpooling or ridesharing.</para>
    /// labels<para>Parken und Mitfahren</para><para>Carpooling</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Carpooling">http://schema.mobivoc.org/Carpooling</seealso>
    let Carpooling = Prefixed_Name(mobivoc, "Carpooling") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Charger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Component of a charging point used to charge electric vehicles. A charging point can have one or more chargers.</para>
    /// labels<para>Ladegerät</para><para>Charger</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Charger">http://schema.mobivoc.org/Charger</seealso>
    let Charger = Prefixed_Name(mobivoc, "Charger") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Closed</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The parking facility is closed.</para>
    /// labels<para>Geschlossen</para><para>Closed</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Closed">http://schema.mobivoc.org/Closed</seealso>
    let Closed = Prefixed_Name(mobivoc, "Closed") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Families</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:UserGroup</para>
    ///   <para>Parents with children.</para>
    /// labels<para>Familien</para><para>Families</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Families">http://schema.mobivoc.org/Families</seealso>
    let Families = Prefixed_Name(mobivoc, "Families") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:IEC_60309_3-pin</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>IEC 60309 (formerly IEC 309 and CEE 17, also published by CENELEC as EN 60309) is an international standard from the International Electrotechnical Commission (IEC) for "plugs, socket-outlets and couplers for industrial purposes". 3-Pin connector.</para>
    /// labels<para>IEC_60309 3-pin</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/IEC_60309_3-pin">http://schema.mobivoc.org/IEC_60309_3-pin</seealso>
    let IEC_60309_3_pin = Prefixed_Name(mobivoc, "IEC_60309_3-pin") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Inhabitants</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:UserGroup</para>
    ///   <para>People living on the premises.</para>
    /// labels<para>Inhabitants</para><para>Anwohner</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Inhabitants">http://schema.mobivoc.org/Inhabitants</seealso>
    let Inhabitants = Prefixed_Name(mobivoc, "Inhabitants") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Motorbike</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A single-track, two-wheeled motor vehicle.</para>
    /// labels<para>Motorbike</para><para>Motorrad</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Motorbike">http://schema.mobivoc.org/Motorbike</seealso>
    let Motorbike = Prefixed_Name(mobivoc, "Motorbike") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:SpecialParkingRestrictionsInForce</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>Parking restrictions, other than those that normally apply, are in force in a specified area.</para>
    /// labels<para>Besondere Parkbeschränkungen in Kraft</para><para>Special parking restrictions in force</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/SpecialParkingRestrictionsInForce">http://schema.mobivoc.org/SpecialParkingRestrictionsInForce</seealso>
    let SpecialParkingRestrictionsInForce =
        Prefixed_Name(mobivoc, "SpecialParkingRestrictionsInForce") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:PlugType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Type of a plug that is used to connect electric vehicles.</para>
    /// labels<para>Steckertyp</para><para>Plug type</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/PlugType">http://schema.mobivoc.org/PlugType</seealso>
    let PlugType = Prefixed_Name(mobivoc, "PlugType") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ParkingFacility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Any facility or area assigned for parking vehicles. A parking facility can provide one or more parking spaces.</para>
    /// labels<para>Parking facility</para><para>Parkeinrichtung</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingFacility">http://schema.mobivoc.org/ParkingFacility</seealso>
    let ParkingFacility = Prefixed_Name(mobivoc, "ParkingFacility") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Mennekes_Type_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The IEC 62196 Type 2 connector (commonly referred to as Mennekes) is used for charging electric cars within Europe. The connector is circular in shape, with a flattened top edge and originally specified for charging battery electric vehicles at 3–120 kilowatts.</para>
    /// labels<para>Mennekes (Type 2)</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Mennekes_Type_2">http://schema.mobivoc.org/Mennekes_Type_2</seealso>
    let Mennekes_Type_2 = Prefixed_Name(mobivoc, "Mennekes_Type_2") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:RealTimeCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Real-time capacity of a parking facility or parking space.</para>
    ///   <para>Real-time capacity of a civic structure.</para>
    /// labels<para>Real time capacity</para><para>Echtzeit Kapazität</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/RealTimeCapacity">http://schema.mobivoc.org/RealTimeCapacity</seealso>
    let RealTimeCapacity = Prefixed_Name(mobivoc, "RealTimeCapacity") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action that is done.</para>
    /// labels<para>Aktion</para><para>Action</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Action">http://schema.mobivoc.org/Action</seealso>
    let Action = Prefixed_Name(mobivoc, "Action") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Allow</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:Action</para>
    ///   <para>Allow to do an action.</para>
    /// labels<para>Erlauben</para><para>Allow</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Allow">http://schema.mobivoc.org/Allow</seealso>
    let Allow = Prefixed_Name(mobivoc, "Allow") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:AccessCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A condition that has to be fullfilled to get access to a civic structure.</para>
    /// labels<para>Access condition</para><para>Zugangsbedingung</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/AccessCondition">http://schema.mobivoc.org/AccessCondition</seealso>
    let AccessCondition = Prefixed_Name(mobivoc, "AccessCondition") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:BikeAndRide</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityConnection</para>
    ///   <para>Parking facilities for bicycles with connection to public transport.</para>
    /// labels<para>Bike and Ride</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/BikeAndRide">http://schema.mobivoc.org/BikeAndRide</seealso>
    let BikeAndRide = Prefixed_Name(mobivoc, "BikeAndRide") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingFacilityConnection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Transport connections available at the parking facility (e.g. Park &amp; Ride).</para>
    /// labels<para>Anschlussmöglichkeiten der Parkeinrichtung</para><para>Parking facility connections</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingFacilityConnection">http://schema.mobivoc.org/ParkingFacilityConnection</seealso>
    let ParkingFacilityConnection =
        Prefixed_Name(mobivoc, "ParkingFacilityConnection") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:CEE_7_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The CEE 7/3 socket and CEE 7/4 plug are commonly called Schuko. The socket (which is often, in error, also referred to as CEE 7/4) has a predominantly circular recess which is 17.5 mm (0.689 in) deep with two symmetrical round apertures and two earthing clips on the sides of the socket positioned to ensure that the earth is always engaged before live pin contact is made. The plug pins are 4.8 by 19 mm (0.189 by 0.748 in).</para>
    /// labels<para>CEE 7/4</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CEE_7_4">http://schema.mobivoc.org/CEE_7_4</seealso>
    let CEE_7_4 = Prefixed_Name(mobivoc, "CEE_7_4") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:CHAdeMO</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>CHAdeMO is the trade name of a quick charging method for battery electric vehicles delivering up to 62.5 kW of direct current (500 V, 125 A[1]) via a special electrical connector.</para>
    /// labels<para>CHAdeMO</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CHAdeMO">http://schema.mobivoc.org/CHAdeMO</seealso>
    let CHAdeMO = Prefixed_Name(mobivoc, "CHAdeMO") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:NoParkAndRideInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>No park and ride information will be available until the specified time.</para>
    /// labels<para>No park and ride information</para><para>Keine P+R-Informationen</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NoParkAndRideInformation">http://schema.mobivoc.org/NoParkAndRideInformation</seealso>
    let NoParkAndRideInformation =
        Prefixed_Name(mobivoc, "NoParkAndRideInformation") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:Operational</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The facility is operational.</para>
    /// labels<para>Status operational</para><para>Status in Betrieb</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Operational">http://schema.mobivoc.org/Operational</seealso>
    let Operational = Prefixed_Name(mobivoc, "Operational") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ParallelParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ArrangementPattern</para>
    ///   <para>Bei der Längsaufstellung wird das Fahrzeug (gemäß § 12 StVO) parallel zur Fahrbahn geparkt. Diese Fahrzeugaufstellung ist die gängigste Aufstellungsart an Straßen.</para>
    ///   <para>With parallel parking, vehicles are arranged in a line, with the front of one vehicle facing the back of an adjacent one. This is done parallel to a curb, when one is provided. Parallel parking is the most common mode of roadside parking for vehicles.</para>
    /// labels<para>Parallel parking</para><para>Längsaufstellung</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParallelParking">http://schema.mobivoc.org/ParallelParking</seealso>
    let ParallelParking = Prefixed_Name(mobivoc, "ParallelParking") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkAndRideServiceNotOperating</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>Park and ride services are not operating until the specified time.</para>
    /// labels<para>Park and ride service not operating</para><para>Kein P+R-Service</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkAndRideServiceNotOperating">http://schema.mobivoc.org/ParkAndRideServiceNotOperating</seealso>
    let ParkAndRideServiceNotOperating =
        Prefixed_Name(mobivoc, "ParkAndRideServiceNotOperating") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingFacilityEntrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Entrance of a parking facility where vehicles can enter the parking facility.</para>
    /// labels<para>Einfahrt</para><para>Entrance</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingFacilityEntrance">http://schema.mobivoc.org/ParkingFacilityEntrance</seealso>
    let ParkingFacilityEntrance =
        Prefixed_Name(mobivoc, "ParkingFacilityEntrance") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingLot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Parking area on a single groundfloor level that is usually located outdoor.</para>
    /// labels<para>Parking lot</para><para>Parkplatz</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingLot">http://schema.mobivoc.org/ParkingLot</seealso>
    let ParkingLot = Prefixed_Name(mobivoc, "ParkingLot") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:AS_3112_Type_I</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>AS/NZS 3112 are the harmonised Australian and New Zealand standards for AC Plugs and Socket-Outlets.</para>
    /// labels<para>AS 3112 Type I</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/AS_3112_Type_I">http://schema.mobivoc.org/AS_3112_Type_I</seealso>
    let AS_3112_Type_I = Prefixed_Name(mobivoc, "AS_3112_Type_I") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:AngleParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ArrangementPattern</para>
    ///   <para>Parking where the parking spaces are arranged at an acute angle to the direction of approach, allowing the driver to enter a space easily and later reverse back out.</para>
    ///   <para>Bei der Schrägaufstellung wird das Fahrzeug mit einem Aufstellwinkel zwischen 50 und 90 gon (45° und ca. 81°) geparkt. Das Fahrzeug kann vorwärts in den Parkstand einfahren, muss zum Ausparken jedoch wieder rückwärts herausfahren. Diese Aufstellung wird oft bei Parkplätzen verwendet, da sie schmalere Fahrwege als die Senkrechtaufstellung und bessere Platzausnutzung als Parallelaufstellung ermöglicht.</para>
    /// labels<para>Schrägaufstellung</para><para>Angle parking</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/AngleParking">http://schema.mobivoc.org/AngleParking</seealso>
    let AngleParking = Prefixed_Name(mobivoc, "AngleParking") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:AutomatedParkingGarage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Parking garage with an automated parking system that automatically moves cars to the available parking space somewhere in the garage.</para>
    /// labels<para>Automated parking garage</para><para>Automatisches Parkhaus</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/AutomatedParkingGarage">http://schema.mobivoc.org/AutomatedParkingGarage</seealso>
    let AutomatedParkingGarage =
        Prefixed_Name(mobivoc, "AutomatedParkingGarage") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:BS1363</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>13 A plugs socket-outlets adaptors and connection units is a British Standard which specifies the most common type of single-phase AC power plugs and sockets that are used in the United Kingdom.</para>
    /// labels<para>BS1363</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/BS1363">http://schema.mobivoc.org/BS1363</seealso>
    let BS1363 = Prefixed_Name(mobivoc, "BS1363") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Bicycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A human-or electric powered, pedal-driven, single-track vehicle, having two wheels attached to a frame, one behind the other.</para>
    /// labels<para>Fahrrad</para><para>Bicycle</para><para>Vélo</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Bicycle">http://schema.mobivoc.org/Bicycle</seealso>
    let Bicycle = Prefixed_Name(mobivoc, "Bicycle") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:BicycleParkingStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Building or structure designed for use as a bicycle parking facility.</para>
    /// labels<para>Bicycle parking station</para><para>Fahrradparkstation</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/BicycleParkingStation">http://schema.mobivoc.org/BicycleParkingStation</seealso>
    let BicycleParkingStation =
        Prefixed_Name(mobivoc, "BicycleParkingStation") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:BusOrCoach</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A bus is a road vehicle designed to carry passengers. Coaches are luxury busses, usually in service for long distance travel.</para>
    /// labels<para>Coach</para><para>Bus</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/BusOrCoach">http://schema.mobivoc.org/BusOrCoach</seealso>
    let BusOrCoach = Prefixed_Name(mobivoc, "BusOrCoach") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:CCS_Type2</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The Combined Charging System is a quick charging method for battery electric vehicles delivering high-voltage direct current via a special electrical connector derived from the  IEC Type 2 connector. As the plug is a combination of an AC connector with a DC option the resulting connector is also called Combo Coupler and the variant with Type 2 is abbreviated as Combo2.</para>
    /// labels<para>CCS Type2</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CCS_Type2">http://schema.mobivoc.org/CCS_Type2</seealso>
    let CCS_Type2 = Prefixed_Name(mobivoc, "CCS_Type2") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:CEE_7-Pin</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>CEE 7-Pin 32A / 400V Socket.</para>
    /// labels<para>CEE 7-Pin</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CEE_7-Pin">http://schema.mobivoc.org/CEE_7-Pin</seealso>
    let CEE_7_Pin = Prefixed_Name(mobivoc, "CEE_7-Pin") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:CEE_7_16</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The CEE 7/16 standard sheet appears in Supplement 2 (June 1962) to the 1951 edition of CEE 7. The CEE 7/16 unearthed plug is used for low power Class II applications, it has two round 4 by 19 mm (0.157 by 0.748 in) pins, rated at 2.5 A. There are two variants.</para>
    /// labels<para>CEE 7/16</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CEE_7_16">http://schema.mobivoc.org/CEE_7_16</seealso>
    let CEE_7_16 = Prefixed_Name(mobivoc, "CEE_7_16") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:CEE_7_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The CEE 7/5 socket and CEE 7/6 plug are defined in French standard NF C 61-314 "Plugs and socket-outlets for household and similar purposes" (which also includes CEE 7/7, 7/16 and 7/17 plugs) The socket has a predominantly circular recess which is 15 mm (0.591 in) deep with two symmetrical round apertures and a round 4.8 mm (0.189 in) earth pin projecting from the socket such that the tip is 23 mm (0.906 in) beyond the live contacts, to ensure that the earth is always engaged before live pin contact is made. The earth pin is centred between the apertures, offset by 10 mm (0.394 in). The plug (which is often, in error, also referred to as CEE 7/5) has two round pins measuring 4.8 by 19 mm (0.189 by 0.748 in), spaced 19 mm (0.748 in) apart and with an aperture for the socket's projecting earth pin. This standard is also used in Belgium, Poland, the Czech Republic, Slovakia and some other countries.</para>
    /// labels<para>CEE 7/5</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CEE_7_5">http://schema.mobivoc.org/CEE_7_5</seealso>
    let CEE_7_5 = Prefixed_Name(mobivoc, "CEE_7_5") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Capacity of a civic structure.</para>
    /// labels<para>Kapazität</para><para>Capacity</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Capacity">http://schema.mobivoc.org/Capacity</seealso>
    let Capacity = Prefixed_Name(mobivoc, "Capacity") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Car</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A wheeled, self-powered motor vehicle used for transportation.</para>
    /// labels<para>Voiture</para><para>Auto</para><para>Car</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Car">http://schema.mobivoc.org/Car</seealso>
    let Car = Prefixed_Name(mobivoc, "Car") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:CarsharingUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:UserGroup</para>
    ///   <para>User of a car rental model where people rent cars for short periods of time.</para>
    /// labels<para>Utilisateurs de l'autopartage</para><para>Carsharing-Nutzer</para><para>Carsharing users</para><para>Car club users</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/CarsharingUsers">http://schema.mobivoc.org/CarsharingUsers</seealso>
    let CarsharingUsers = Prefixed_Name(mobivoc, "CarsharingUsers") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:UserGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A group of users having a common characteristic.</para>
    /// labels<para>Nutzergruppe</para><para>User group</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/UserGroup">http://schema.mobivoc.org/UserGroup</seealso>
    let UserGroup = Prefixed_Name(mobivoc, "UserGroup") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ChargingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Civic structure that supplies electric energy for the recharging of electric vehicles.</para>
    /// labels<para>Charging point</para><para>Ladestation</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ChargingPoint">http://schema.mobivoc.org/ChargingPoint</seealso>
    let ChargingPoint = Prefixed_Name(mobivoc, "ChargingPoint") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ElectricVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A wheeled, self-powered motor vehicle using an electric drivetrain.</para>
    /// labels<para>Véhicule électrique</para><para>Electric vehicle</para><para>Elektrofahrzeug</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ElectricVehicle">http://schema.mobivoc.org/ElectricVehicle</seealso>
    let ElectricVehicle = Prefixed_Name(mobivoc, "ElectricVehicle") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:EnoughParkingSpacesAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The parking facility has parking spaces available.</para>
    /// labels<para>Enough parking spaces available</para><para>Genügend Stellplätze frei</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/EnoughParkingSpacesAvailable">http://schema.mobivoc.org/EnoughParkingSpacesAvailable</seealso>
    let EnoughParkingSpacesAvailable =
        Prefixed_Name(mobivoc, "EnoughParkingSpacesAvailable") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:Faulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The parking facility is not operating normally.</para>
    /// labels<para>Faulty</para><para>Defekt</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Faulty">http://schema.mobivoc.org/Faulty</seealso>
    let Faulty = Prefixed_Name(mobivoc, "Faulty") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Full</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The parking facility is completely occupied.</para>
    /// labels<para>Belegt</para><para>Full</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Full">http://schema.mobivoc.org/Full</seealso>
    let Full = Prefixed_Name(mobivoc, "Full") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:IEC_60309_16A_2_E</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>IEC 60309 (formerly IEC 309 and CEE 17, also published by CENELEC as EN 60309) is an international standard from the International Electrotechnical Commission (IEC) for "plugs, socket-outlets and couplers for industrial purposes". The blue P+N+E, 6h (180°) plug is a single phase connector. In particular this smallest (16 A) variant has become especially common in camping vehicles and sockets found in caravan parks and marinas throughout Europe.</para>
    /// labels<para>IEC_60309 16A 2+E</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/IEC_60309_16A_2_E">http://schema.mobivoc.org/IEC_60309_16A_2_E</seealso>
    let IEC_60309_16A_2_E = Prefixed_Name(mobivoc, "IEC_60309_16A_2_E") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:IEC_60309_5-pin</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>IEC 60309 (formerly IEC 309 and CEE 17, also published by CENELEC as EN 60309) is an international standard from the International Electrotechnical Commission (IEC) for "plugs, socket-outlets and couplers for industrial purposes". 5-Pin connector.</para>
    /// labels<para>IEC_60309 5-pin</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/IEC_60309_5-pin">http://schema.mobivoc.org/IEC_60309_5-pin</seealso>
    let IEC_60309_5_pin = Prefixed_Name(mobivoc, "IEC_60309_5-pin") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:IEC_62196_Type_3A</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The type 3A is derived from the Scame charging connectors adding the IEC 62196 pins which is suited for single-phase charging – the connector builds on the experience with the Scame connector for charging of light vehicles (electric motorcycles and scooters).</para>
    /// labels<para>SCAME Type 3A</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/IEC_62196_Type_3A">http://schema.mobivoc.org/IEC_62196_Type_3A</seealso>
    let IEC_62196_Type_3A = Prefixed_Name(mobivoc, "IEC_62196_Type_3A") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:IEC_62196_Type_3C</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The type 3A is derived from the Scame charging connectors adding the IEC 62196 pins which is suited for single-phase charging – the connector builds on the experience with the Scame connector for charging of light vehicles (electric motorcycles and scooters). The additional type 3C adds additional 2 pins for three-phase charging for usage at fast charge stations. Based on its origin the connector is sometimes referred to as the Scame type 3 connector.</para>
    /// labels<para>SCAME Type 3C</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/IEC_62196_Type_3C">http://schema.mobivoc.org/IEC_62196_Type_3C</seealso>
    let IEC_62196_Type_3C = Prefixed_Name(mobivoc, "IEC_62196_Type_3C") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NEMA_14-30</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. The NEMA 14 devices are four-wire grounding devices (hot-hot-neutral-ground) available in ratings from 15 to 60 A. The voltage rating is 250 V. Rated for 30A.</para>
    /// labels<para>NEMA 14-30</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NEMA_14-30">http://schema.mobivoc.org/NEMA_14-30</seealso>
    let NEMA_14_30 = Prefixed_Name(mobivoc, "NEMA_14-30") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NEMA_14-50</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. The NEMA 14 devices are four-wire grounding devices (hot-hot-neutral-ground) available in ratings from 15 to 60 A. The voltage rating is 250 V. Rated for 60A.</para>
    /// labels<para>NEMA 14-50</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NEMA_14-50">http://schema.mobivoc.org/NEMA_14-50</seealso>
    let NEMA_14_50 = Prefixed_Name(mobivoc, "NEMA_14-50") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NEMA_5-15R</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. All NEMA 5 devices are three-wire grounding devices (hot-neutral-ground) rated for 125 V maximum.
    ///    The 5-15R is by far the most common electrical receptacle in North America in buildings built since the mid-twentieth century. It is usually installed in a duplex configuration; two receptacles may share a common circuit or may each be wired separately, sometimes to a switch.</para>
    /// labels<para>NEMA 5-15R</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NEMA_5-15R">http://schema.mobivoc.org/NEMA_5-15R</seealso>
    let NEMA_5_15R = Prefixed_Name(mobivoc, "NEMA_5-15R") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NEMA_5-20R</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. All NEMA 5 devices are three-wire grounding devices (hot-neutral-ground) rated for 125 V maximum.</para>
    /// labels<para>NEMA 5-20R</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NEMA_5-20R">http://schema.mobivoc.org/NEMA_5-20R</seealso>
    let NEMA_5_20R = Prefixed_Name(mobivoc, "NEMA_5-20R") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NEMA_6-15</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association.
    /// All NEMA 6 devices are three-wire grounding devices (hot-hot-ground) used for 208 and 240 V circuits and rated for 250 V maximum. The 6-15 resembles the 5-15, but with collinear horizontal pins</para>
    /// labels<para>NEMA 6-15</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NEMA_6-15">http://schema.mobivoc.org/NEMA_6-15</seealso>
    let NEMA_6_15 = Prefixed_Name(mobivoc, "NEMA_6-15") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NEMA_6-20</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association.
    /// All NEMA 6 devices are three-wire grounding devices (hot-hot-ground) used for 208 and 240 V circuits and rated for 250 V maximum. The 20 A plug has a blade rotated 90°.</para>
    /// labels<para>NEMA 6-20</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NEMA_6-20">http://schema.mobivoc.org/NEMA_6-20</seealso>
    let NEMA_6_20 = Prefixed_Name(mobivoc, "NEMA_6-20") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:NoParkingAllowed</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>No parking allowed until the specified time.</para>
    /// labels<para>No parking allowed</para><para>Parken verboten</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NoParkingAllowed">http://schema.mobivoc.org/NoParkingAllowed</seealso>
    let NoParkingAllowed = Prefixed_Name(mobivoc, "NoParkingAllowed") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:NoParkingInformationAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>Parking information is not available until a specified time.</para>
    /// labels<para>Keine Parkinformationen verfügbar</para><para>No parking information available</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NoParkingInformationAvailable">http://schema.mobivoc.org/NoParkingInformationAvailable</seealso>
    let NoParkingInformationAvailable =
        Prefixed_Name(mobivoc, "NoParkingInformationAvailable") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:NormalParkingRestrictionsLifted</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The parking restrictions that normally apply in the specified location have been temporarily lifted.</para>
    /// labels<para>Normale Parkbeschränkungen aufgehoben</para><para>Normal parking restrictions lifted</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/NormalParkingRestrictionsLifted">http://schema.mobivoc.org/NormalParkingRestrictionsLifted</seealso>
    let NormalParkingRestrictionsLifted =
        Prefixed_Name(mobivoc, "NormalParkingRestrictionsLifted") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:OnlyAFewParkingSpacesAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The parking facility has 95% or greater occupancy.</para>
    /// labels<para>Only a few parking spaces available</para><para>Nur noch wenige Stellplätze frei</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/OnlyAFewParkingSpacesAvailable">http://schema.mobivoc.org/OnlyAFewParkingSpacesAvailable</seealso>
    let OnlyAFewParkingSpacesAvailable =
        Prefixed_Name(mobivoc, "OnlyAFewParkingSpacesAvailable") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkAndFly</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityConnection</para>
    ///   <para>Connection to airport.</para>
    /// labels<para>Parken und Fliegen</para><para>Park &amp; Fly</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkAndFly">http://schema.mobivoc.org/ParkAndFly</seealso>
    let ParkAndFly = Prefixed_Name(mobivoc, "ParkAndFly") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ParkAndRail</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityConnection</para>
    ///   <para>Connection to railway station.</para>
    /// labels<para>Park and Rail</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkAndRail">http://schema.mobivoc.org/ParkAndRail</seealso>
    let ParkAndRail = Prefixed_Name(mobivoc, "ParkAndRail") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ParkAndRide</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityConnection</para>
    ///   <para>Connection to public transport.</para>
    /// labels<para>Parken und Reisen</para><para>Park &amp; Ride</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkAndRide">http://schema.mobivoc.org/ParkAndRide</seealso>
    let ParkAndRide = Prefixed_Name(mobivoc, "ParkAndRide") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkAndRideServiceOperating</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>Park and ride services are operating until the specified time.</para>
    /// labels<para>Park and ride service operating</para><para>P+R-Service vorhanden</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkAndRideServiceOperating">http://schema.mobivoc.org/ParkAndRideServiceOperating</seealso>
    let ParkAndRideServiceOperating =
        Prefixed_Name(mobivoc, "ParkAndRideServiceOperating") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingBarrier</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityFeature</para>
    ///   <para>The parking facility has a parking barrier.</para>
    /// labels<para>Parking barrier</para><para>Parkschranke</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingBarrier">http://schema.mobivoc.org/ParkingBarrier</seealso>
    let ParkingBarrier = Prefixed_Name(mobivoc, "ParkingBarrier") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingFacilityFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Features of the parking facility (e.g. parking for disabled people).</para>
    /// labels<para>Ausstattung der Parkeinrichtung</para><para>Parking facility feature</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingFacilityFeature">http://schema.mobivoc.org/ParkingFacilityFeature</seealso>
    let ParkingFacilityFeature =
        Prefixed_Name(mobivoc, "ParkingFacilityFeature") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingFacilityExit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Exit of a parking facility where vehicles can leave the parking facility.</para>
    /// labels<para>Ausfahrt</para><para>Exit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingFacilityExit">http://schema.mobivoc.org/ParkingFacilityExit</seealso>
    let ParkingFacilityExit =
        Prefixed_Name(mobivoc, "ParkingFacilityExit") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:ParkingGarage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A single level or multilevel parking building to park at.</para>
    /// labels<para>Parking garage</para><para>Parkhaus</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingGarage">http://schema.mobivoc.org/ParkingGarage</seealso>
    let ParkingGarage = Prefixed_Name(mobivoc, "ParkingGarage") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ParkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A parking space is a location that is designated for parking a vehicle. A parking space has a certain size, is sometimes marked and can be located at roadside or inside a parking facility. Depending on the location of the parking space, there can be regulations regarding the time allowed to park and a fee paid to use the parking space.</para>
    /// labels<para>Parking space</para><para>Stellplatz</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ParkingSpace">http://schema.mobivoc.org/ParkingSpace</seealso>
    let ParkingSpace = Prefixed_Name(mobivoc, "ParkingSpace") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:PayStation</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityFeature</para>
    ///   <para>The parking facility has a pay station.</para>
    /// labels<para>Kassenautomat</para><para>Pay station</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/PayStation">http://schema.mobivoc.org/PayStation</seealso>
    let PayStation = Prefixed_Name(mobivoc, "PayStation") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:PerpendicularParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ArrangementPattern</para>
    ///   <para>Bei der Senkrechtaufstellung wird das Fahrzeug mit einem Aufstellwinkel von von 100 gon (90°) geparkt.</para>
    ///   <para>With perpendicular parking, vehicles are parked side to side, perpendicular to an aisle, curb, or wall. This type of parking is commonly used in parking lots and parking facilities.</para>
    /// labels<para>Perpendicular parking</para><para>Senkrechtaufstellung</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/PerpendicularParking">http://schema.mobivoc.org/PerpendicularParking</seealso>
    let PerpendicularParking =
        Prefixed_Name(mobivoc, "PerpendicularParking") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:PersonsWithDisabledParkingPermit</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:UserGroup</para>
    ///   <para>Persons with disabilities having a special parking permit that gives the right to use parking spaces reserved for disabled people.</para>
    /// labels<para>Persons with disabled parking permit</para><para>Personen mit Behindertenparkausweis</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/PersonsWithDisabledParkingPermit">http://schema.mobivoc.org/PersonsWithDisabledParkingPermit</seealso>
    let PersonsWithDisabledParkingPermit =
        Prefixed_Name(mobivoc, "PersonsWithDisabledParkingPermit") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:Plug</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Component of a charger to connect an electric vehicle. There are different plug types used for charging electric vehicles.</para>
    /// labels<para>Anschluss</para><para>Plug</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Plug">http://schema.mobivoc.org/Plug</seealso>
    let Plug = Prefixed_Name(mobivoc, "Plug") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:RecreationalVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A motor vehicle or trailer equipped with living space and amenities found in a home.</para>
    /// labels<para>Recreational vehicle</para><para>Wohnmobil</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/RecreationalVehicle">http://schema.mobivoc.org/RecreationalVehicle</seealso>
    let RecreationalVehicle =
        Prefixed_Name(mobivoc, "RecreationalVehicle") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:Restrict</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:Action</para>
    ///   <para>An action is restricted.</para>
    /// labels<para>Beschränken</para><para>Restrict</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Restrict">http://schema.mobivoc.org/Restrict</seealso>
    let Restrict = Prefixed_Name(mobivoc, "Restrict") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:SAE_Combo</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The Combined Charging System is a quick charging method for battery electric vehicles delivering high-voltage direct current via a special electrical connector derived from the SAE J1772 (IEC Type 1).</para>
    /// labels<para>SAE Combo (DC Fast Charge J1772)</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/SAE_Combo">http://schema.mobivoc.org/SAE_Combo</seealso>
    let SAE_Combo = Prefixed_Name(mobivoc, "SAE_Combo") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:SAE_J1772-2001</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>SAE J1772 (IEC Type 1) is a North American standard for electrical connectors for electric vehicles maintained by the SAE International and has the formal title "SAE Surface Vehicle Recommended Practice J1772, SAE Electric Vehicle Conductive Charge Coupler".</para>
    /// labels<para>J1772</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/SAE_J1772-2001">http://schema.mobivoc.org/SAE_J1772-2001</seealso>
    let SAE_J1772_2001 = Prefixed_Name(mobivoc, "SAE_J1772-2001") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:SAE_J1772-2009</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>SAE J1772 (IEC Type 1) is a North American standard for electrical connectors for electric vehicles maintained by the SAE International and has the formal title "SAE Surface Vehicle Recommended Practice J1772, SAE Electric Vehicle Conductive Charge Coupler".
    ///     The SAE J1772-2009 connector specification has been added to the international IEC 62196-2 standard.</para>
    /// labels<para>J1772 2009</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/SAE_J1772-2009">http://schema.mobivoc.org/SAE_J1772-2009</seealso>
    let SAE_J1772_2009 = Prefixed_Name(mobivoc, "SAE_J1772-2009") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:SEV1011_Type_J</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The Swiss standard, also used in Liechtenstein, is SN SEV 1011:2009 Plugs and socket-outlets for household and similar purposes. The standard defines a hierarchical system of plugs and sockets with two, three and five pins, and 10 A or 16 A ratings. Sockets will accept plugs with the same or fewer pins and the same or lower ratings.</para>
    /// labels<para>SEV1011 Type J</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/SEV1011_Type_J">http://schema.mobivoc.org/SEV1011_Type_J</seealso>
    let SEV1011_Type_J = Prefixed_Name(mobivoc, "SEV1011_Type_J") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:StatusUnknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:CivicStructureStatus</para>
    ///   <para>The status of the parking facility is unknown.</para>
    /// labels<para>Status unbekannt</para><para>Status unknown</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/StatusUnknown">http://schema.mobivoc.org/StatusUnknown</seealso>
    let StatusUnknown = Prefixed_Name(mobivoc, "StatusUnknown") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:SurveillanceBySecurityGuards</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityFeature</para>
    ///   <para>The parking facility is surveilled by security guards.</para>
    /// labels<para>surveillance by security guards</para><para>Bewacht durch Personal</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/SurveillanceBySecurityGuards">http://schema.mobivoc.org/SurveillanceBySecurityGuards</seealso>
    let SurveillanceBySecurityGuards =
        Prefixed_Name(mobivoc, "SurveillanceBySecurityGuards") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:TaxiDrivers</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:UserGroup</para>
    ///   <para>Drivers of a vehicle for hire, used by a single passenger or small group of passengers, often for a non-shared ride. Taxi drivers convey passengers between locations of their choice.</para>
    /// labels<para>Taxi drivers</para><para>Taxifahrer</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/TaxiDrivers">http://schema.mobivoc.org/TaxiDrivers</seealso>
    let TaxiDrivers = Prefixed_Name(mobivoc, "TaxiDrivers") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:Tesla_Supercharger</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The Tesla Supercharger network is a system of 480-volt DC fast-charging stations built by American vehicle manufacturer Tesla Inc. to allow longer journeys for their all-electric manufactured vehicles (Model S, 3 and X), through quick charging of the vehicle's battery packs.</para>
    /// labels<para>Tesla Supercharger</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Tesla_Supercharger">http://schema.mobivoc.org/Tesla_Supercharger</seealso>
    let Tesla_Supercharger =
        Prefixed_Name(mobivoc, "Tesla_Supercharger") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:TimeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specific time a price specification is due for.</para>
    /// labels<para>Time specification</para><para>Zeitspezifikation</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/TimeSpecification">http://schema.mobivoc.org/TimeSpecification</seealso>
    let TimeSpecification = Prefixed_Name(mobivoc, "TimeSpecification") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>schema1:Vehicle</para>
    ///   <para>A motor vehicle designed to transport cargo.</para>
    /// labels<para>Truck</para><para>Lkw</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Truck">http://schema.mobivoc.org/Truck</seealso>
    let Truck = Prefixed_Name(mobivoc, "Truck") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:UndergroundParkingGarage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Parking facility with one or more levels below the surface and none above ground.</para>
    /// labels<para>Underground parking garage</para><para>Tiefgarage</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/UndergroundParkingGarage">http://schema.mobivoc.org/UndergroundParkingGarage</seealso>
    let UndergroundParkingGarage =
        Prefixed_Name(mobivoc, "UndergroundParkingGarage") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:VideoSurveillance</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:ParkingFacilityFeature</para>
    ///   <para>The parking facility is surveilled by video.</para>
    /// labels<para>Video surveillance</para><para>Videoüberwachung</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/VideoSurveillance">http://schema.mobivoc.org/VideoSurveillance</seealso>
    let VideoSurveillance = Prefixed_Name(mobivoc, "VideoSurveillance") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:Women</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:UserGroup</para>
    ///   <para>Female persons.</para>
    /// labels<para>Frauen</para><para>Women</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/Women">http://schema.mobivoc.org/Women</seealso>
    let Women = Prefixed_Name(mobivoc, "Women") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:XLR4</para>
    /// </summary>
    /// <remarks>
    ///   <para>mobivoc:PlugType</para>
    ///   <para>The XLR connector is a style of electrical connector, primarily found on professional audio, video, and stage lighting equipment. The connectors are circular in design and have between 3 and 7 pins. They are most commonly associated with balanced audio interconnection, including AES3 digital audio, but are also used for lighting control, low-voltage power supplies, and other applications. XLR connectors are available from a number of manufacturers and are covered by an international standard for dimensions, IEC 61076-2-103.[1] They are superficially similar to the older and smaller DIN connector range, but are not physically compatible with them.</para>
    /// labels<para>XLR 4-Pin</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/XLR4">http://schema.mobivoc.org/XLR4</seealso>
    let XLR4 = Prefixed_Name(mobivoc, "XLR4") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:access</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a civic structure can only be accessed when certain conditions are fullfilled.</para>
    /// labels<para>access</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/access">http://schema.mobivoc.org/access</seealso>
    let access = Prefixed_Name(mobivoc, "access") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates which action is applied.</para>
    /// labels<para>action</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/action">http://schema.mobivoc.org/action</seealso>
    let action = Prefixed_Name(mobivoc, "action") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:additionalInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Further information about the civic structure or facility.</para>
    /// labels<para>zusätzliche Information</para><para>additional information</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/additionalInformation">http://schema.mobivoc.org/additionalInformation</seealso>
    let additionalInformation =
        Prefixed_Name(mobivoc, "additionalInformation") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:arrangement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates in which pattern a parking space is arranged.</para>
    /// labels<para>arrangement pattern</para><para>Anordnung</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/arrangement">http://schema.mobivoc.org/arrangement</seealso>
    let arrangement = Prefixed_Name(mobivoc, "arrangement") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the brand of a charger.</para>
    /// labels<para>Marke</para><para>brand</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/brand">http://schema.mobivoc.org/brand</seealso>
    let brand = Prefixed_Name(mobivoc, "brand") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:cableAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the plug has a cable.</para>
    /// labels<para>Kabel verfügbar</para><para>cable available</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/cableAvailable">http://schema.mobivoc.org/cableAvailable</seealso>
    let cableAvailable = Prefixed_Name(mobivoc, "cableAvailable") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:capacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the civic structure to its capacity.</para>
    /// labels<para>hat Kapazität</para><para>has capacity</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/capacity">http://schema.mobivoc.org/capacity</seealso>
    let capacity = Prefixed_Name(mobivoc, "capacity") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:charger</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the charger available at a charging point. A charging point can have more than one charger.</para>
    /// labels<para>charger</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/charger">http://schema.mobivoc.org/charger</seealso>
    let charger = Prefixed_Name(mobivoc, "charger") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:chargerQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the amount of chargers available at the charging point.</para>
    /// labels<para>Anzahl Ladepunkte</para><para>charger quantity</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/chargerQuantity">http://schema.mobivoc.org/chargerQuantity</seealso>
    let chargerQuantity = Prefixed_Name(mobivoc, "chargerQuantity") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:chargingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates whether charging points are available.</para>
    /// labels<para>has charging point</para><para>hat Ladestation</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/chargingPoint">http://schema.mobivoc.org/chargingPoint</seealso>
    let chargingPoint = Prefixed_Name(mobivoc, "chargingPoint") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:civicStructureStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the current status of the civil structure.</para>
    /// labels<para>hat Status der zivilen Struktur</para><para>civic structure status</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/civicStructureStatus">http://schema.mobivoc.org/civicStructureStatus</seealso>
    let civicStructureStatus =
        Prefixed_Name(mobivoc, "civicStructureStatus") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:connectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the transport connections available.</para>
    /// labels<para>connected to</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/connectedTo">http://schema.mobivoc.org/connectedTo</seealso>
    let connectedTo = Prefixed_Name(mobivoc, "connectedTo") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:currentInA</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the current of a charger or plug in ampere.</para>
    /// labels<para>current in A</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/currentInA">http://schema.mobivoc.org/currentInA</seealso>
    let currentInA = Prefixed_Name(mobivoc, "currentInA") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:currentType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the current type (AC/DC) of the plug.</para>
    /// labels<para>current type</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/currentType">http://schema.mobivoc.org/currentType</seealso>
    let currentType = Prefixed_Name(mobivoc, "currentType") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:currentValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the current value of the real-time capacity.</para>
    /// labels<para>current value</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/currentValue">http://schema.mobivoc.org/currentValue</seealso>
    let currentValue = Prefixed_Name(mobivoc, "currentValue") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:customerOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a group is customer of a specific business entity.</para>
    /// labels<para>customer of</para><para>Kunde von</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/customerOf">http://schema.mobivoc.org/customerOf</seealso>
    let customerOf = Prefixed_Name(mobivoc, "customerOf") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:dueForTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a price specification is due for a certain time specification.</para>
    /// labels<para>fällig für Zeitdauer</para><para>due for time</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/dueForTime">http://schema.mobivoc.org/dueForTime</seealso>
    let dueForTime = Prefixed_Name(mobivoc, "dueForTime") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:employeeOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a group is employee of a specific business entity.</para>
    /// labels<para>Mitarbeiter von</para><para>employee of</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/employeeOf">http://schema.mobivoc.org/employeeOf</seealso>
    let employeeOf = Prefixed_Name(mobivoc, "employeeOf") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:energySource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the energy source used for the charging point i.e. renewable etc.</para>
    /// labels<para>energy source</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/energySource">http://schema.mobivoc.org/energySource</seealso>
    let energySource = Prefixed_Name(mobivoc, "energySource") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:entrance</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the entrance of a parking facility.</para>
    /// labels<para>hat Einfahrt</para><para>entrance</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/entrance">http://schema.mobivoc.org/entrance</seealso>
    let entrance = Prefixed_Name(mobivoc, "entrance") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:exit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Describes the exit of a parking facility.</para>
    /// labels<para>hat Ausfahrt</para><para>exit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/exit">http://schema.mobivoc.org/exit</seealso>
    let exit = Prefixed_Name(mobivoc, "exit") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:exitRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The rate at which vehicles are exiting the parking facility.</para>
    /// labels<para>exit rate</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/exitRate">http://schema.mobivoc.org/exitRate</seealso>
    let exitRate = Prefixed_Name(mobivoc, "exitRate") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates which feature the parking facility provides.</para>
    /// labels<para>feature</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/feature">http://schema.mobivoc.org/feature</seealso>
    let feature = Prefixed_Name(mobivoc, "feature") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:fillRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The rate at which vehicles are entering the parking facility.</para>
    /// labels<para>fill rate</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/fillRate">http://schema.mobivoc.org/fillRate</seealso>
    let fillRate = Prefixed_Name(mobivoc, "fillRate") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:freeOfCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that the usage of the civic structure is for free.</para>
    /// labels<para>free of charge</para><para>kostenlos</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/freeOfCharge">http://schema.mobivoc.org/freeOfCharge</seealso>
    let freeOfCharge = Prefixed_Name(mobivoc, "freeOfCharge") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>ID of the entity.</para>
    /// labels<para>ID</para><para>ID</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/id">http://schema.mobivoc.org/id</seealso>
    let id = Prefixed_Name(mobivoc, "id") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:isFastChargeCapable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that the charger is able to fast charge.</para>
    /// labels<para>is fast charge capable</para><para>erlaubt Schnellladen</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/isFastChargeCapable">http://schema.mobivoc.org/isFastChargeCapable</seealso>
    let isFastChargeCapable =
        Prefixed_Name(mobivoc, "isFastChargeCapable") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the level of a parking facility the parking space is located in.</para>
    /// labels<para>level</para><para>Ebene</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/level">http://schema.mobivoc.org/level</seealso>
    let level = Prefixed_Name(mobivoc, "level") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:maximumValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the maximum value of the capacity.</para>
    /// labels<para>maximum value</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/maximumValue">http://schema.mobivoc.org/maximumValue</seealso>
    let maximumValue = Prefixed_Name(mobivoc, "maximumValue") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:model</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the charger model of the charging point.</para>
    /// labels<para>Modell</para><para>model</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/model">http://schema.mobivoc.org/model</seealso>
    let model = Prefixed_Name(mobivoc, "model") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Name of the civic structure or facility.</para>
    /// labels<para>name</para><para>Name</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/name">http://schema.mobivoc.org/name</seealso>
    let name = Prefixed_Name(mobivoc, "name") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:numberOfLevels</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the total number of levels a parking facility has.</para>
    /// labels<para>number of levels</para><para>Anzahl Ebenen</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/numberOfLevels">http://schema.mobivoc.org/numberOfLevels</seealso>
    let numberOfLevels = Prefixed_Name(mobivoc, "numberOfLevels") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:operatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The operator of a civic structure or facility. Operator and owner can be different business entitites.</para>
    /// labels<para>betrieben von</para><para>operated by</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/operatedBy">http://schema.mobivoc.org/operatedBy</seealso>
    let operatedBy = Prefixed_Name(mobivoc, "operatedBy") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:overnight</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates that a time period overnight is possible.</para>
    /// labels<para>über Nacht</para><para>overnight</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/overnight">http://schema.mobivoc.org/overnight</seealso>
    let overnight = Prefixed_Name(mobivoc, "overnight") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:ownedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The owner of a civic structure or facility. Owner and operator can be different business entities.</para>
    /// labels<para>in Besitz von</para><para>owned by</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/ownedBy">http://schema.mobivoc.org/ownedBy</seealso>
    let ownedBy = Prefixed_Name(mobivoc, "ownedBy") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:parkingSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates the parking facility to a contained parking space.</para>
    /// labels<para>hat Stellplatz</para><para>parking space</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/parkingSpace">http://schema.mobivoc.org/parkingSpace</seealso>
    let parkingSpace = Prefixed_Name(mobivoc, "parkingSpace") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:picture</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>URL of the picture of a civic structure or facility.</para>
    /// labels<para>picture</para><para>Bild</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/picture">http://schema.mobivoc.org/picture</seealso>
    let picture = Prefixed_Name(mobivoc, "picture") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:plug</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the plugs available at a charger.</para>
    /// labels<para>plug</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/plug">http://schema.mobivoc.org/plug</seealso>
    let plug = Prefixed_Name(mobivoc, "plug") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:plugType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the type of a plug.</para>
    /// labels<para>plug type</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/plugType">http://schema.mobivoc.org/plugType</seealso>
    let plugType = Prefixed_Name(mobivoc, "plugType") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:powerInKW</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the power of a charger or plug in kilowatts.</para>
    /// labels<para>power in kW</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/powerInKW">http://schema.mobivoc.org/powerInKW</seealso>
    let powerInKW = Prefixed_Name(mobivoc, "powerInKW") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:price</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a civic structure can be used for a specific price.</para>
    /// labels<para>Preis</para><para>price</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/price">http://schema.mobivoc.org/price</seealso>
    let price = Prefixed_Name(mobivoc, "price") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:queuingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>The current queuing time (duration) for entering the parking facility.</para>
    /// labels<para>queuing time</para><para>Wartezeit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/queuingTime">http://schema.mobivoc.org/queuingTime</seealso>
    let queuingTime = Prefixed_Name(mobivoc, "queuingTime") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:rateOfOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the percentage value of parking spaces occupied in a parking facility.</para>
    /// labels<para>rate of occupancy</para><para>Belegungsrate</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/rateOfOccupancy">http://schema.mobivoc.org/rateOfOccupancy</seealso>
    let rateOfOccupancy = Prefixed_Name(mobivoc, "rateOfOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:threePhasedCurrentAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether three-phased current is available.</para>
    /// labels<para>three-phased current available</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/threePhasedCurrentAvailable">http://schema.mobivoc.org/threePhasedCurrentAvailable</seealso>
    let threePhasedCurrentAvailable =
        Prefixed_Name(mobivoc, "threePhasedCurrentAvailable") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:timeEndValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the end value of a time period.</para>
    /// labels<para>time end value</para><para>Endzeit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/timeEndValue">http://schema.mobivoc.org/timeEndValue</seealso>
    let timeEndValue = Prefixed_Name(mobivoc, "timeEndValue") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:timeStartValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the start value of a time period.</para>
    /// labels<para>time start value</para><para>Anfangszeit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/timeStartValue">http://schema.mobivoc.org/timeStartValue</seealso>
    let timeStartValue = Prefixed_Name(mobivoc, "timeStartValue") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:timeUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the time unit a value is specified for.</para>
    /// labels<para>Zeiteinheit</para><para>time unit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/timeUnit">http://schema.mobivoc.org/timeUnit</seealso>
    let timeUnit = Prefixed_Name(mobivoc, "timeUnit") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:totalCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the total number of parking spaces of a parking facility.</para>
    /// labels<para>Gesamtkapazität</para><para>total capacity</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/totalCapacity">http://schema.mobivoc.org/totalCapacity</seealso>
    let totalCapacity = Prefixed_Name(mobivoc, "totalCapacity") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:unspecifiedCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that a charge has to be paid for the usage of the civic structure.</para>
    /// labels<para>unspecified charge</para><para>kostenpflichtig</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/unspecifiedCharge">http://schema.mobivoc.org/unspecifiedCharge</seealso>
    let unspecifiedCharge = Prefixed_Name(mobivoc, "unspecifiedCharge") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:validForUserGroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates that an entity is valid for a specific group of users.</para>
    /// labels<para>gültig für Nutzergruppe</para><para>valid for user group</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/validForUserGroup">http://schema.mobivoc.org/validForUserGroup</seealso>
    let validForUserGroup = Prefixed_Name(mobivoc, "validForUserGroup") |> PrefixedName
    /// <summary>
    ///   <para>mobivoc:validForVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that an entity is valid for a specific type of vehicle.</para>
    /// labels<para>gültig für Fahrzeug</para><para>valid for vehicle</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/validForVehicle">http://schema.mobivoc.org/validForVehicle</seealso>
    let validForVehicle = Prefixed_Name(mobivoc, "validForVehicle") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:vehicleHeightLimitInM</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the height limit in meter for vehicles using the parking facility.</para>
    /// labels<para>Höhenbegrenzung für Fahrzeuge</para><para>vechicle height limit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/vehicleHeightLimitInM">http://schema.mobivoc.org/vehicleHeightLimitInM</seealso>
    let vehicleHeightLimitInM =
        Prefixed_Name(mobivoc, "vehicleHeightLimitInM") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:vehicleLengthLimitInM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the length limit in meter for vehicles using the parking facility.</para>
    /// labels<para>Längenbegrenzung für Fahrzeuge</para><para>vehicle length limit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/vehicleLengthLimitInM">http://schema.mobivoc.org/vehicleLengthLimitInM</seealso>
    let vehicleLengthLimitInM =
        Prefixed_Name(mobivoc, "vehicleLengthLimitInM") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:vehicleWidthLimitInM</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates the width limit in meter for vehicles using the parking facility.</para>
    /// labels<para>Breitenbegrenzung für Fahrzeuge</para><para>vehicle width limit</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/vehicleWidthLimitInM">http://schema.mobivoc.org/vehicleWidthLimitInM</seealso>
    let vehicleWidthLimitInM =
        Prefixed_Name(mobivoc, "vehicleWidthLimitInM") |> PrefixedName

    /// <summary>
    ///   <para>mobivoc:voltageInV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>Indicates the voltage of a charger or plug in volt.</para>
    /// labels<para>voltage in V</para></remarks>
    /// <seealso href="http://schema.mobivoc.org/voltageInV">http://schema.mobivoc.org/voltageInV</seealso>
    let voltageInV = Prefixed_Name(mobivoc, "voltageInV") |> PrefixedName
