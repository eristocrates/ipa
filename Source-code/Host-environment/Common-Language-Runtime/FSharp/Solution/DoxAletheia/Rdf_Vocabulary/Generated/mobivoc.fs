namespace http.schema.mobivoc.org.slash

open DoxAletheia.Rdf_Vocabulary

module mobivoc =
    let _namespace_name = "http://schema.mobivoc.org/"

    /// <summary>
    /// Real-time capacity of a parking facility or parking space.
    /// Real-time capacity of a civic structure.
    /// <see href="http://schema.mobivoc.org/RealTimeCapacity"></see></summary>
    let RealTimeCapacity =
        Namespaced_IRI.parse _namespace_name "RealTimeCapacity" |> NamespacedName

    /// <summary>
    /// AS/NZS 3112 are the harmonised Australian and New Zealand standards for AC Plugs and Socket-Outlets.
    /// <see href="http://schema.mobivoc.org/AS_3112_Type_I"></see></summary>
    let AS_3112_Type_I =
        Namespaced_IRI.parse _namespace_name "AS_3112_Type_I" |> NamespacedName

    /// <summary>
    /// The OpenChargeMap ID used for the Connection / Plug.
    /// <see href="http://schema.mobivoc.org/ocmConnectionID"></see></summary>
    let ocmConnectionID =
        Namespaced_IRI.parse _namespace_name "ocmConnectionID" |> NamespacedName

    /// <summary>
    /// Type of a plug that is used to connect electric vehicles.
    /// <see href="http://schema.mobivoc.org/PlugType"></see></summary>
    let PlugType = Namespaced_IRI.parse _namespace_name "PlugType" |> NamespacedName

    /// <summary>
    /// A condition that has to be fullfilled to get access to a civic structure.
    /// <see href="http://schema.mobivoc.org/AccessCondition"></see></summary>
    let AccessCondition =
        Namespaced_IRI.parse _namespace_name "AccessCondition" |> NamespacedName

    /// <summary>
    /// Action that is done.
    /// <see href="http://schema.mobivoc.org/Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName

    /// <summary>
    /// All parking facilities within a specified area are completely occupied.
    /// <see href="http://schema.mobivoc.org/AllParkingFacilitiesFull"></see></summary>
    let AllParkingFacilitiesFull =
        Namespaced_IRI.parse _namespace_name "AllParkingFacilitiesFull" |> NamespacedName

    /// <summary>
    /// Status information of a civic structure.
    /// <see href="http://schema.mobivoc.org/CivicStructureStatus"></see></summary>
    let CivicStructureStatus =
        Namespaced_IRI.parse _namespace_name "CivicStructureStatus" |> NamespacedName

    /// <summary>
    /// Allow to do an action.
    /// <see href="http://schema.mobivoc.org/Allow"></see></summary>
    let Allow = Namespaced_IRI.parse _namespace_name "Allow" |> NamespacedName

    /// <summary>
    /// Parking where the parking spaces are arranged at an acute angle to the direction of approach, allowing the driver to enter a space easily and later reverse back out.
    /// <see href="http://schema.mobivoc.org/AngleParking"></see></summary>
    let AngleParking =
        Namespaced_IRI.parse _namespace_name "AngleParking" |> NamespacedName

    /// <summary>
    /// Pattern how parking spaces are arranged in a parking facility or at roadside.
    /// <see href="http://schema.mobivoc.org/ArrangementPattern"></see></summary>
    let ArrangementPattern =
        Namespaced_IRI.parse _namespace_name "ArrangementPattern" |> NamespacedName

    /// <summary>
    /// Parking garage with an automated parking system that automatically moves cars to the available parking space somewhere in the garage.
    /// <see href="http://schema.mobivoc.org/AutomatedParkingGarage"></see></summary>
    let AutomatedParkingGarage =
        Namespaced_IRI.parse _namespace_name "AutomatedParkingGarage" |> NamespacedName

    /// <summary>
    /// Any facility or area assigned for parking vehicles. A parking facility can provide one or more parking spaces.
    /// <see href="http://schema.mobivoc.org/ParkingFacility"></see></summary>
    let ParkingFacility =
        Namespaced_IRI.parse _namespace_name "ParkingFacility" |> NamespacedName

    /// <summary>
    /// 13 A plugs socket-outlets adaptors and connection units is a British Standard which specifies the most common type of single-phase AC power plugs and sockets that are used in the United Kingdom.
    /// <see href="http://schema.mobivoc.org/BS1363"></see></summary>
    let BS1363 = Namespaced_IRI.parse _namespace_name "BS1363" |> NamespacedName
    /// <summary>
    /// A human-or electric powered, pedal-driven, single-track vehicle, having two wheels attached to a frame, one behind the other.
    /// <see href="http://schema.mobivoc.org/Bicycle"></see></summary>
    let Bicycle = Namespaced_IRI.parse _namespace_name "Bicycle" |> NamespacedName

    /// <summary>
    /// Building or structure designed for use as a bicycle parking facility.
    /// <see href="http://schema.mobivoc.org/BicycleParkingStation"></see></summary>
    let BicycleParkingStation =
        Namespaced_IRI.parse _namespace_name "BicycleParkingStation" |> NamespacedName

    /// <summary>
    /// Parking facilities for bicycles with connection to public transport.
    /// <see href="http://schema.mobivoc.org/BikeAndRide"></see></summary>
    let BikeAndRide =
        Namespaced_IRI.parse _namespace_name "BikeAndRide" |> NamespacedName

    /// <summary>
    /// Transport connections available at the parking facility (e.g. Park &amp; Ride).
    /// <see href="http://schema.mobivoc.org/ParkingFacilityConnection"></see></summary>
    let ParkingFacilityConnection =
        Namespaced_IRI.parse _namespace_name "ParkingFacilityConnection" |> NamespacedName

    /// <summary>
    /// A bus is a road vehicle designed to carry passengers. Coaches are luxury busses, usually in service for long distance travel.
    /// <see href="http://schema.mobivoc.org/BusOrCoach"></see></summary>
    let BusOrCoach = Namespaced_IRI.parse _namespace_name "BusOrCoach" |> NamespacedName
    /// <summary>
    /// The Combined Charging System is a quick charging method for battery electric vehicles delivering high-voltage direct current via a special electrical connector derived from the  IEC Type 2 connector. As the plug is a combination of an AC connector with a DC option the resulting connector is also called Combo Coupler and the variant with Type 2 is abbreviated as Combo2.
    /// <see href="http://schema.mobivoc.org/CCS_Type2"></see></summary>
    let CCS_Type2 = Namespaced_IRI.parse _namespace_name "CCS_Type2" |> NamespacedName

    /// <summary>
    /// CEE 7-Pin 32A / 400V Socket.
    /// <see href="http://schema.mobivoc.org/CEE_7-Pin"></see></summary>
    let ``CEE_7-Pin`` =
        Namespaced_IRI.parse _namespace_name "CEE_7-Pin" |> NamespacedName

    /// <summary>
    /// The CEE 7/16 standard sheet appears in Supplement 2 (June 1962) to the 1951 edition of CEE 7. The CEE 7/16 unearthed plug is used for low power Class II applications, it has two round 4 by 19 mm (0.157 by 0.748 in) pins, rated at 2.5 A. There are two variants.
    /// <see href="http://schema.mobivoc.org/CEE_7_16"></see></summary>
    let CEE_7_16 = Namespaced_IRI.parse _namespace_name "CEE_7_16" |> NamespacedName
    /// <summary>
    /// The CEE 7/3 socket and CEE 7/4 plug are commonly called Schuko. The socket (which is often, in error, also referred to as CEE 7/4) has a predominantly circular recess which is 17.5 mm (0.689 in) deep with two symmetrical round apertures and two earthing clips on the sides of the socket positioned to ensure that the earth is always engaged before live pin contact is made. The plug pins are 4.8 by 19 mm (0.189 by 0.748 in).
    /// <see href="http://schema.mobivoc.org/CEE_7_4"></see></summary>
    let CEE_7_4 = Namespaced_IRI.parse _namespace_name "CEE_7_4" |> NamespacedName
    /// <summary>
    /// The CEE 7/5 socket and CEE 7/6 plug are defined in French standard NF C 61-314 "Plugs and socket-outlets for household and similar purposes" (which also includes CEE 7/7, 7/16 and 7/17 plugs) The socket has a predominantly circular recess which is 15 mm (0.591 in) deep with two symmetrical round apertures and a round 4.8 mm (0.189 in) earth pin projecting from the socket such that the tip is 23 mm (0.906 in) beyond the live contacts, to ensure that the earth is always engaged before live pin contact is made. The earth pin is centred between the apertures, offset by 10 mm (0.394 in). The plug (which is often, in error, also referred to as CEE 7/5) has two round pins measuring 4.8 by 19 mm (0.189 by 0.748 in), spaced 19 mm (0.748 in) apart and with an aperture for the socket's projecting earth pin. This standard is also used in Belgium, Poland, the Czech Republic, Slovakia and some other countries.
    /// <see href="http://schema.mobivoc.org/CEE_7_5"></see></summary>
    let CEE_7_5 = Namespaced_IRI.parse _namespace_name "CEE_7_5" |> NamespacedName
    /// <summary>
    /// CHAdeMO is the trade name of a quick charging method for battery electric vehicles delivering up to 62.5 kW of direct current (500 V, 125 A[1]) via a special electrical connector.
    /// <see href="http://schema.mobivoc.org/CHAdeMO"></see></summary>
    let CHAdeMO = Namespaced_IRI.parse _namespace_name "CHAdeMO" |> NamespacedName
    /// <summary>
    /// Capacity of a civic structure.
    /// <see href="http://schema.mobivoc.org/Capacity"></see></summary>
    let Capacity = Namespaced_IRI.parse _namespace_name "Capacity" |> NamespacedName
    /// <summary>
    /// A wheeled, self-powered motor vehicle used for transportation.
    /// <see href="http://schema.mobivoc.org/Car"></see></summary>
    let Car = Namespaced_IRI.parse _namespace_name "Car" |> NamespacedName
    /// <summary>
    /// Parking facility used for carpooling or ridesharing.
    /// <see href="http://schema.mobivoc.org/Carpooling"></see></summary>
    let Carpooling = Namespaced_IRI.parse _namespace_name "Carpooling" |> NamespacedName

    /// <summary>
    /// User of a car rental model where people rent cars for short periods of time.
    /// <see href="http://schema.mobivoc.org/CarsharingUsers"></see></summary>
    let CarsharingUsers =
        Namespaced_IRI.parse _namespace_name "CarsharingUsers" |> NamespacedName

    /// <summary>
    /// A group of users having a common characteristic.
    /// <see href="http://schema.mobivoc.org/UserGroup"></see></summary>
    let UserGroup = Namespaced_IRI.parse _namespace_name "UserGroup" |> NamespacedName
    /// <summary>
    /// Component of a charging point used to charge electric vehicles. A charging point can have one or more chargers.
    /// <see href="http://schema.mobivoc.org/Charger"></see></summary>
    let Charger = Namespaced_IRI.parse _namespace_name "Charger" |> NamespacedName

    /// <summary>
    /// Civic structure that supplies electric energy for the recharging of electric vehicles.
    /// <see href="http://schema.mobivoc.org/ChargingPoint"></see></summary>
    let ChargingPoint =
        Namespaced_IRI.parse _namespace_name "ChargingPoint" |> NamespacedName

    /// <summary>
    /// The parking facility is closed.
    /// <see href="http://schema.mobivoc.org/Closed"></see></summary>
    let Closed = Namespaced_IRI.parse _namespace_name "Closed" |> NamespacedName

    /// <summary>
    /// A wheeled, self-powered motor vehicle using an electric drivetrain.
    /// <see href="http://schema.mobivoc.org/ElectricVehicle"></see></summary>
    let ElectricVehicle =
        Namespaced_IRI.parse _namespace_name "ElectricVehicle" |> NamespacedName

    /// <summary>
    /// The parking facility has parking spaces available.
    /// <see href="http://schema.mobivoc.org/EnoughParkingSpacesAvailable"></see></summary>
    let EnoughParkingSpacesAvailable =
        Namespaced_IRI.parse _namespace_name "EnoughParkingSpacesAvailable" |> NamespacedName

    /// <summary>
    /// Parents with children.
    /// <see href="http://schema.mobivoc.org/Families"></see></summary>
    let Families = Namespaced_IRI.parse _namespace_name "Families" |> NamespacedName
    /// <summary>
    /// The parking facility is not operating normally.
    /// <see href="http://schema.mobivoc.org/Faulty"></see></summary>
    let Faulty = Namespaced_IRI.parse _namespace_name "Faulty" |> NamespacedName
    /// <summary>
    /// The parking facility is completely occupied.
    /// <see href="http://schema.mobivoc.org/Full"></see></summary>
    let Full = Namespaced_IRI.parse _namespace_name "Full" |> NamespacedName

    /// <summary>
    /// IEC 60309 (formerly IEC 309 and CEE 17, also published by CENELEC as EN 60309) is an international standard from the International Electrotechnical Commission (IEC) for "plugs, socket-outlets and couplers for industrial purposes". The blue P+N+E, 6h (180°) plug is a single phase connector. In particular this smallest (16 A) variant has become especially common in camping vehicles and sockets found in caravan parks and marinas throughout Europe.
    /// <see href="http://schema.mobivoc.org/IEC_60309_16A_2_E"></see></summary>
    let IEC_60309_16A_2_E =
        Namespaced_IRI.parse _namespace_name "IEC_60309_16A_2_E" |> NamespacedName

    /// <summary>
    /// IEC 60309 (formerly IEC 309 and CEE 17, also published by CENELEC as EN 60309) is an international standard from the International Electrotechnical Commission (IEC) for "plugs, socket-outlets and couplers for industrial purposes". 3-Pin connector.
    /// <see href="http://schema.mobivoc.org/IEC_60309_3-pin"></see></summary>
    let ``IEC_60309_3-pin`` =
        Namespaced_IRI.parse _namespace_name "IEC_60309_3-pin" |> NamespacedName

    /// <summary>
    /// IEC 60309 (formerly IEC 309 and CEE 17, also published by CENELEC as EN 60309) is an international standard from the International Electrotechnical Commission (IEC) for "plugs, socket-outlets and couplers for industrial purposes". 5-Pin connector.
    /// <see href="http://schema.mobivoc.org/IEC_60309_5-pin"></see></summary>
    let ``IEC_60309_5-pin`` =
        Namespaced_IRI.parse _namespace_name "IEC_60309_5-pin" |> NamespacedName

    /// <summary>
    /// The type 3A is derived from the Scame charging connectors adding the IEC 62196 pins which is suited for single-phase charging – the connector builds on the experience with the Scame connector for charging of light vehicles (electric motorcycles and scooters).
    /// <see href="http://schema.mobivoc.org/IEC_62196_Type_3A"></see></summary>
    let IEC_62196_Type_3A =
        Namespaced_IRI.parse _namespace_name "IEC_62196_Type_3A" |> NamespacedName

    /// <summary>
    /// The type 3A is derived from the Scame charging connectors adding the IEC 62196 pins which is suited for single-phase charging – the connector builds on the experience with the Scame connector for charging of light vehicles (electric motorcycles and scooters). The additional type 3C adds additional 2 pins for three-phase charging for usage at fast charge stations. Based on its origin the connector is sometimes referred to as the Scame type 3 connector.
    /// <see href="http://schema.mobivoc.org/IEC_62196_Type_3C"></see></summary>
    let IEC_62196_Type_3C =
        Namespaced_IRI.parse _namespace_name "IEC_62196_Type_3C" |> NamespacedName

    /// <summary>
    /// People living on the premises.
    /// <see href="http://schema.mobivoc.org/Inhabitants"></see></summary>
    let Inhabitants =
        Namespaced_IRI.parse _namespace_name "Inhabitants" |> NamespacedName

    /// <summary>
    /// The IEC 62196 Type 2 connector (commonly referred to as Mennekes) is used for charging electric cars within Europe. The connector is circular in shape, with a flattened top edge and originally specified for charging battery electric vehicles at 3–120 kilowatts.
    /// <see href="http://schema.mobivoc.org/Mennekes_Type_2"></see></summary>
    let Mennekes_Type_2 =
        Namespaced_IRI.parse _namespace_name "Mennekes_Type_2" |> NamespacedName

    /// <summary>
    /// A single-track, two-wheeled motor vehicle.
    /// <see href="http://schema.mobivoc.org/Motorbike"></see></summary>
    let Motorbike = Namespaced_IRI.parse _namespace_name "Motorbike" |> NamespacedName

    /// <summary>
    /// NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. The NEMA 14 devices are four-wire grounding devices (hot-hot-neutral-ground) available in ratings from 15 to 60 A. The voltage rating is 250 V. Rated for 30A.
    /// <see href="http://schema.mobivoc.org/NEMA_14-30"></see></summary>
    let ``NEMA_14-30`` =
        Namespaced_IRI.parse _namespace_name "NEMA_14-30" |> NamespacedName

    /// <summary>
    /// NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. The NEMA 14 devices are four-wire grounding devices (hot-hot-neutral-ground) available in ratings from 15 to 60 A. The voltage rating is 250 V. Rated for 60A.
    /// <see href="http://schema.mobivoc.org/NEMA_14-50"></see></summary>
    let ``NEMA_14-50`` =
        Namespaced_IRI.parse _namespace_name "NEMA_14-50" |> NamespacedName

    /// <summary>
    /// NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. All NEMA 5 devices are three-wire grounding devices (hot-neutral-ground) rated for 125 V maximum.
    ///    The 5-15R is by far the most common electrical receptacle in North America in buildings built since the mid-twentieth century. It is usually installed in a duplex configuration; two receptacles may share a common circuit or may each be wired separately, sometimes to a switch.
    /// <see href="http://schema.mobivoc.org/NEMA_5-15R"></see></summary>
    let ``NEMA_5-15R`` =
        Namespaced_IRI.parse _namespace_name "NEMA_5-15R" |> NamespacedName

    /// <summary>
    /// NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association. All NEMA 5 devices are three-wire grounding devices (hot-neutral-ground) rated for 125 V maximum.
    /// <see href="http://schema.mobivoc.org/NEMA_5-20R"></see></summary>
    let ``NEMA_5-20R`` =
        Namespaced_IRI.parse _namespace_name "NEMA_5-20R" |> NamespacedName

    /// <summary>
    /// NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association.
    /// All NEMA 6 devices are three-wire grounding devices (hot-hot-ground) used for 208 and 240 V circuits and rated for 250 V maximum. The 6-15 resembles the 5-15, but with collinear horizontal pins
    /// <see href="http://schema.mobivoc.org/NEMA_6-15"></see></summary>
    let ``NEMA_6-15`` =
        Namespaced_IRI.parse _namespace_name "NEMA_6-15" |> NamespacedName

    /// <summary>
    /// NEMA connectors are power plugs and receptacles used for AC mains electricity in North America and other countries that use the standards set by the US National Electrical Manufacturers Association.
    /// All NEMA 6 devices are three-wire grounding devices (hot-hot-ground) used for 208 and 240 V circuits and rated for 250 V maximum. The 20 A plug has a blade rotated 90°.
    /// <see href="http://schema.mobivoc.org/NEMA_6-20"></see></summary>
    let ``NEMA_6-20`` =
        Namespaced_IRI.parse _namespace_name "NEMA_6-20" |> NamespacedName

    /// <summary>
    /// No park and ride information will be available until the specified time.
    /// <see href="http://schema.mobivoc.org/NoParkAndRideInformation"></see></summary>
    let NoParkAndRideInformation =
        Namespaced_IRI.parse _namespace_name "NoParkAndRideInformation" |> NamespacedName

    /// <summary>
    /// No parking allowed until the specified time.
    /// <see href="http://schema.mobivoc.org/NoParkingAllowed"></see></summary>
    let NoParkingAllowed =
        Namespaced_IRI.parse _namespace_name "NoParkingAllowed" |> NamespacedName

    /// <summary>
    /// Parking information is not available until a specified time.
    /// <see href="http://schema.mobivoc.org/NoParkingInformationAvailable"></see></summary>
    let NoParkingInformationAvailable =
        Namespaced_IRI.parse _namespace_name "NoParkingInformationAvailable" |> NamespacedName

    /// <summary>
    /// The parking restrictions that normally apply in the specified location have been temporarily lifted.
    /// <see href="http://schema.mobivoc.org/NormalParkingRestrictionsLifted"></see></summary>
    let NormalParkingRestrictionsLifted =
        Namespaced_IRI.parse _namespace_name "NormalParkingRestrictionsLifted" |> NamespacedName

    /// <summary>
    /// The parking facility has 95% or greater occupancy.
    /// <see href="http://schema.mobivoc.org/OnlyAFewParkingSpacesAvailable"></see></summary>
    let OnlyAFewParkingSpacesAvailable =
        Namespaced_IRI.parse _namespace_name "OnlyAFewParkingSpacesAvailable" |> NamespacedName

    /// <summary>
    /// The facility is operational.
    /// <see href="http://schema.mobivoc.org/Operational"></see></summary>
    let Operational =
        Namespaced_IRI.parse _namespace_name "Operational" |> NamespacedName

    /// <summary>
    /// With parallel parking, vehicles are arranged in a line, with the front of one vehicle facing the back of an adjacent one. This is done parallel to a curb, when one is provided. Parallel parking is the most common mode of roadside parking for vehicles.
    /// <see href="http://schema.mobivoc.org/ParallelParking"></see></summary>
    let ParallelParking =
        Namespaced_IRI.parse _namespace_name "ParallelParking" |> NamespacedName

    /// <summary>
    /// Connection to airport.
    /// <see href="http://schema.mobivoc.org/ParkAndFly"></see></summary>
    let ParkAndFly = Namespaced_IRI.parse _namespace_name "ParkAndFly" |> NamespacedName

    /// <summary>
    /// Connection to railway station.
    /// <see href="http://schema.mobivoc.org/ParkAndRail"></see></summary>
    let ParkAndRail =
        Namespaced_IRI.parse _namespace_name "ParkAndRail" |> NamespacedName

    /// <summary>
    /// Connection to public transport.
    /// <see href="http://schema.mobivoc.org/ParkAndRide"></see></summary>
    let ParkAndRide =
        Namespaced_IRI.parse _namespace_name "ParkAndRide" |> NamespacedName

    /// <summary>
    /// Park and ride services are not operating until the specified time.
    /// <see href="http://schema.mobivoc.org/ParkAndRideServiceNotOperating"></see></summary>
    let ParkAndRideServiceNotOperating =
        Namespaced_IRI.parse _namespace_name "ParkAndRideServiceNotOperating" |> NamespacedName

    /// <summary>
    /// Park and ride services are operating until the specified time.
    /// <see href="http://schema.mobivoc.org/ParkAndRideServiceOperating"></see></summary>
    let ParkAndRideServiceOperating =
        Namespaced_IRI.parse _namespace_name "ParkAndRideServiceOperating" |> NamespacedName

    /// <summary>
    /// The parking facility has a parking barrier.
    /// <see href="http://schema.mobivoc.org/ParkingBarrier"></see></summary>
    let ParkingBarrier =
        Namespaced_IRI.parse _namespace_name "ParkingBarrier" |> NamespacedName

    /// <summary>
    /// Features of the parking facility (e.g. parking for disabled people).
    /// <see href="http://schema.mobivoc.org/ParkingFacilityFeature"></see></summary>
    let ParkingFacilityFeature =
        Namespaced_IRI.parse _namespace_name "ParkingFacilityFeature" |> NamespacedName

    /// <summary>
    /// Entrance of a parking facility where vehicles can enter the parking facility.
    /// <see href="http://schema.mobivoc.org/ParkingFacilityEntrance"></see></summary>
    let ParkingFacilityEntrance =
        Namespaced_IRI.parse _namespace_name "ParkingFacilityEntrance" |> NamespacedName

    /// <summary>
    /// Exit of a parking facility where vehicles can leave the parking facility.
    /// <see href="http://schema.mobivoc.org/ParkingFacilityExit"></see></summary>
    let ParkingFacilityExit =
        Namespaced_IRI.parse _namespace_name "ParkingFacilityExit" |> NamespacedName

    /// <summary>
    /// A single level or multilevel parking building to park at.
    /// <see href="http://schema.mobivoc.org/ParkingGarage"></see></summary>
    let ParkingGarage =
        Namespaced_IRI.parse _namespace_name "ParkingGarage" |> NamespacedName

    /// <summary>
    /// Parking area on a single groundfloor level that is usually located outdoor.
    /// <see href="http://schema.mobivoc.org/ParkingLot"></see></summary>
    let ParkingLot = Namespaced_IRI.parse _namespace_name "ParkingLot" |> NamespacedName

    /// <summary>
    /// A parking space is a location that is designated for parking a vehicle. A parking space has a certain size, is sometimes marked and can be located at roadside or inside a parking facility. Depending on the location of the parking space, there can be regulations regarding the time allowed to park and a fee paid to use the parking space.
    /// <see href="http://schema.mobivoc.org/ParkingSpace"></see></summary>
    let ParkingSpace =
        Namespaced_IRI.parse _namespace_name "ParkingSpace" |> NamespacedName

    /// <summary>
    /// The parking facility has a pay station.
    /// <see href="http://schema.mobivoc.org/PayStation"></see></summary>
    let PayStation = Namespaced_IRI.parse _namespace_name "PayStation" |> NamespacedName

    /// <summary>
    /// With perpendicular parking, vehicles are parked side to side, perpendicular to an aisle, curb, or wall. This type of parking is commonly used in parking lots and parking facilities.
    /// <see href="http://schema.mobivoc.org/PerpendicularParking"></see></summary>
    let PerpendicularParking =
        Namespaced_IRI.parse _namespace_name "PerpendicularParking" |> NamespacedName

    /// <summary>
    /// Persons with disabilities having a special parking permit that gives the right to use parking spaces reserved for disabled people.
    /// <see href="http://schema.mobivoc.org/PersonsWithDisabledParkingPermit"></see></summary>
    let PersonsWithDisabledParkingPermit =
        Namespaced_IRI.parse _namespace_name "PersonsWithDisabledParkingPermit" |> NamespacedName

    /// <summary>
    /// Component of a charger to connect an electric vehicle. There are different plug types used for charging electric vehicles.
    /// <see href="http://schema.mobivoc.org/Plug"></see></summary>
    let Plug = Namespaced_IRI.parse _namespace_name "Plug" |> NamespacedName

    /// <summary>
    /// A motor vehicle or trailer equipped with living space and amenities found in a home.
    /// <see href="http://schema.mobivoc.org/RecreationalVehicle"></see></summary>
    let RecreationalVehicle =
        Namespaced_IRI.parse _namespace_name "RecreationalVehicle" |> NamespacedName

    /// <summary>
    /// An action is restricted.
    /// <see href="http://schema.mobivoc.org/Restrict"></see></summary>
    let Restrict = Namespaced_IRI.parse _namespace_name "Restrict" |> NamespacedName
    /// <summary>
    /// The Combined Charging System is a quick charging method for battery electric vehicles delivering high-voltage direct current via a special electrical connector derived from the SAE J1772 (IEC Type 1).
    /// <see href="http://schema.mobivoc.org/SAE_Combo"></see></summary>
    let SAE_Combo = Namespaced_IRI.parse _namespace_name "SAE_Combo" |> NamespacedName

    /// <summary>
    /// SAE J1772 (IEC Type 1) is a North American standard for electrical connectors for electric vehicles maintained by the SAE International and has the formal title "SAE Surface Vehicle Recommended Practice J1772, SAE Electric Vehicle Conductive Charge Coupler".
    /// <see href="http://schema.mobivoc.org/SAE_J1772-2001"></see></summary>
    let ``SAE_J1772-2001`` =
        Namespaced_IRI.parse _namespace_name "SAE_J1772-2001" |> NamespacedName

    /// <summary>
    /// SAE J1772 (IEC Type 1) is a North American standard for electrical connectors for electric vehicles maintained by the SAE International and has the formal title "SAE Surface Vehicle Recommended Practice J1772, SAE Electric Vehicle Conductive Charge Coupler".
    ///     The SAE J1772-2009 connector specification has been added to the international IEC 62196-2 standard.
    /// <see href="http://schema.mobivoc.org/SAE_J1772-2009"></see></summary>
    let ``SAE_J1772-2009`` =
        Namespaced_IRI.parse _namespace_name "SAE_J1772-2009" |> NamespacedName

    /// <summary>
    /// The Swiss standard, also used in Liechtenstein, is SN SEV 1011:2009 Plugs and socket-outlets for household and similar purposes. The standard defines a hierarchical system of plugs and sockets with two, three and five pins, and 10 A or 16 A ratings. Sockets will accept plugs with the same or fewer pins and the same or lower ratings.
    /// <see href="http://schema.mobivoc.org/SEV1011_Type_J"></see></summary>
    let SEV1011_Type_J =
        Namespaced_IRI.parse _namespace_name "SEV1011_Type_J" |> NamespacedName

    /// <summary>
    /// Parking restrictions, other than those that normally apply, are in force in a specified area.
    /// <see href="http://schema.mobivoc.org/SpecialParkingRestrictionsInForce"></see></summary>
    let SpecialParkingRestrictionsInForce =
        Namespaced_IRI.parse _namespace_name "SpecialParkingRestrictionsInForce" |> NamespacedName

    /// <summary>
    /// The status of the parking facility is unknown.
    /// <see href="http://schema.mobivoc.org/StatusUnknown"></see></summary>
    let StatusUnknown =
        Namespaced_IRI.parse _namespace_name "StatusUnknown" |> NamespacedName

    /// <summary>
    /// The parking facility is surveilled by security guards.
    /// <see href="http://schema.mobivoc.org/SurveillanceBySecurityGuards"></see></summary>
    let SurveillanceBySecurityGuards =
        Namespaced_IRI.parse _namespace_name "SurveillanceBySecurityGuards" |> NamespacedName

    /// <summary>
    /// Drivers of a vehicle for hire, used by a single passenger or small group of passengers, often for a non-shared ride. Taxi drivers convey passengers between locations of their choice.
    /// <see href="http://schema.mobivoc.org/TaxiDrivers"></see></summary>
    let TaxiDrivers =
        Namespaced_IRI.parse _namespace_name "TaxiDrivers" |> NamespacedName

    /// <summary>
    /// The Tesla Supercharger network is a system of 480-volt DC fast-charging stations built by American vehicle manufacturer Tesla Inc. to allow longer journeys for their all-electric manufactured vehicles (Model S, 3 and X), through quick charging of the vehicle's battery packs.
    /// <see href="http://schema.mobivoc.org/Tesla_Supercharger"></see></summary>
    let Tesla_Supercharger =
        Namespaced_IRI.parse _namespace_name "Tesla_Supercharger" |> NamespacedName

    /// <summary>
    /// Specific time a price specification is due for.
    /// <see href="http://schema.mobivoc.org/TimeSpecification"></see></summary>
    let TimeSpecification =
        Namespaced_IRI.parse _namespace_name "TimeSpecification" |> NamespacedName

    /// <summary>
    /// A motor vehicle designed to transport cargo.
    /// <see href="http://schema.mobivoc.org/Truck"></see></summary>
    let Truck = Namespaced_IRI.parse _namespace_name "Truck" |> NamespacedName

    /// <summary>
    /// Parking facility with one or more levels below the surface and none above ground.
    /// <see href="http://schema.mobivoc.org/UndergroundParkingGarage"></see></summary>
    let UndergroundParkingGarage =
        Namespaced_IRI.parse _namespace_name "UndergroundParkingGarage" |> NamespacedName

    /// <summary>
    /// The parking facility is surveilled by video.
    /// <see href="http://schema.mobivoc.org/VideoSurveillance"></see></summary>
    let VideoSurveillance =
        Namespaced_IRI.parse _namespace_name "VideoSurveillance" |> NamespacedName

    /// <summary>
    /// Female persons.
    /// <see href="http://schema.mobivoc.org/Women"></see></summary>
    let Women = Namespaced_IRI.parse _namespace_name "Women" |> NamespacedName
    /// <summary>
    /// The XLR connector is a style of electrical connector, primarily found on professional audio, video, and stage lighting equipment. The connectors are circular in design and have between 3 and 7 pins. They are most commonly associated with balanced audio interconnection, including AES3 digital audio, but are also used for lighting control, low-voltage power supplies, and other applications. XLR connectors are available from a number of manufacturers and are covered by an international standard for dimensions, IEC 61076-2-103.[1] They are superficially similar to the older and smaller DIN connector range, but are not physically compatible with them.
    /// <see href="http://schema.mobivoc.org/XLR4"></see></summary>
    let XLR4 = Namespaced_IRI.parse _namespace_name "XLR4" |> NamespacedName
    /// <summary>
    /// Indicates that a civic structure can only be accessed when certain conditions are fullfilled.
    /// <see href="http://schema.mobivoc.org/access"></see></summary>
    let access = Namespaced_IRI.parse _namespace_name "access" |> NamespacedName
    /// <summary>
    /// Indicates which action is applied.
    /// <see href="http://schema.mobivoc.org/action"></see></summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName

    /// <summary>
    /// Further information about the civic structure or facility.
    /// <see href="http://schema.mobivoc.org/additionalInformation"></see></summary>
    let additionalInformation =
        Namespaced_IRI.parse _namespace_name "additionalInformation" |> NamespacedName

    /// <summary>
    /// Indicates in which pattern a parking space is arranged.
    /// <see href="http://schema.mobivoc.org/arrangement"></see></summary>
    let arrangement =
        Namespaced_IRI.parse _namespace_name "arrangement" |> NamespacedName

    /// <summary>
    /// Indicates the brand of a charger.
    /// <see href="http://schema.mobivoc.org/brand"></see></summary>
    let brand = Namespaced_IRI.parse _namespace_name "brand" |> NamespacedName

    /// <summary>
    /// Indicates whether the plug has a cable.
    /// <see href="http://schema.mobivoc.org/cableAvailable"></see></summary>
    let cableAvailable =
        Namespaced_IRI.parse _namespace_name "cableAvailable" |> NamespacedName

    /// <summary>
    /// Relates the civic structure to its capacity.
    /// <see href="http://schema.mobivoc.org/capacity"></see></summary>
    let capacity = Namespaced_IRI.parse _namespace_name "capacity" |> NamespacedName
    /// <summary>
    /// Describes the charger available at a charging point. A charging point can have more than one charger.
    /// <see href="http://schema.mobivoc.org/charger"></see></summary>
    let charger = Namespaced_IRI.parse _namespace_name "charger" |> NamespacedName

    /// <summary>
    /// Indicates the amount of chargers available at the charging point.
    /// <see href="http://schema.mobivoc.org/chargerQuantity"></see></summary>
    let chargerQuantity =
        Namespaced_IRI.parse _namespace_name "chargerQuantity" |> NamespacedName

    /// <summary>
    /// Indicates whether charging points are available.
    /// <see href="http://schema.mobivoc.org/chargingPoint"></see></summary>
    let chargingPoint =
        Namespaced_IRI.parse _namespace_name "chargingPoint" |> NamespacedName

    /// <summary>
    /// Indicates the current status of the civil structure.
    /// <see href="http://schema.mobivoc.org/civicStructureStatus"></see></summary>
    let civicStructureStatus =
        Namespaced_IRI.parse _namespace_name "civicStructureStatus" |> NamespacedName

    /// <summary>
    /// Indicates the transport connections available.
    /// <see href="http://schema.mobivoc.org/connectedTo"></see></summary>
    let connectedTo =
        Namespaced_IRI.parse _namespace_name "connectedTo" |> NamespacedName

    /// <summary>
    /// Indicates the current of a charger or plug in ampere.
    /// <see href="http://schema.mobivoc.org/currentInA"></see></summary>
    let currentInA = Namespaced_IRI.parse _namespace_name "currentInA" |> NamespacedName

    /// <summary>
    /// Indicates the current type (AC/DC) of the plug.
    /// <see href="http://schema.mobivoc.org/currentType"></see></summary>
    let currentType =
        Namespaced_IRI.parse _namespace_name "currentType" |> NamespacedName

    /// <summary>
    /// Indicates the current value of the real-time capacity.
    /// <see href="http://schema.mobivoc.org/currentValue"></see></summary>
    let currentValue =
        Namespaced_IRI.parse _namespace_name "currentValue" |> NamespacedName

    /// <summary>
    /// Indicates that a group is customer of a specific business entity.
    /// <see href="http://schema.mobivoc.org/customerOf"></see></summary>
    let customerOf = Namespaced_IRI.parse _namespace_name "customerOf" |> NamespacedName
    /// <summary>
    /// Indicates that a price specification is due for a certain time specification.
    /// <see href="http://schema.mobivoc.org/dueForTime"></see></summary>
    let dueForTime = Namespaced_IRI.parse _namespace_name "dueForTime" |> NamespacedName
    /// <summary>
    /// Indicates that a group is employee of a specific business entity.
    /// <see href="http://schema.mobivoc.org/employeeOf"></see></summary>
    let employeeOf = Namespaced_IRI.parse _namespace_name "employeeOf" |> NamespacedName

    /// <summary>
    /// Indicates the energy source used for the charging point i.e. renewable etc.
    /// <see href="http://schema.mobivoc.org/energySource"></see></summary>
    let energySource =
        Namespaced_IRI.parse _namespace_name "energySource" |> NamespacedName

    /// <summary>
    /// Describes the entrance of a parking facility.
    /// <see href="http://schema.mobivoc.org/entrance"></see></summary>
    let entrance = Namespaced_IRI.parse _namespace_name "entrance" |> NamespacedName
    /// <summary>
    /// Describes the exit of a parking facility.
    /// <see href="http://schema.mobivoc.org/exit"></see></summary>
    let exit = Namespaced_IRI.parse _namespace_name "exit" |> NamespacedName
    /// <summary>
    /// The rate at which vehicles are exiting the parking facility.
    /// <see href="http://schema.mobivoc.org/exitRate"></see></summary>
    let exitRate = Namespaced_IRI.parse _namespace_name "exitRate" |> NamespacedName
    /// <summary>
    /// Indicates which feature the parking facility provides.
    /// <see href="http://schema.mobivoc.org/feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName
    /// <summary>
    /// The rate at which vehicles are entering the parking facility.
    /// <see href="http://schema.mobivoc.org/fillRate"></see></summary>
    let fillRate = Namespaced_IRI.parse _namespace_name "fillRate" |> NamespacedName

    /// <summary>
    /// Indicates that the usage of the civic structure is for free.
    /// <see href="http://schema.mobivoc.org/freeOfCharge"></see></summary>
    let freeOfCharge =
        Namespaced_IRI.parse _namespace_name "freeOfCharge" |> NamespacedName

    /// <summary>
    /// ID of the entity.
    /// <see href="http://schema.mobivoc.org/id"></see></summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName

    /// <summary>
    /// Indicates that the charger is able to fast charge.
    /// <see href="http://schema.mobivoc.org/isFastChargeCapable"></see></summary>
    let isFastChargeCapable =
        Namespaced_IRI.parse _namespace_name "isFastChargeCapable" |> NamespacedName

    /// <summary>
    /// Indicates the level of a parking facility the parking space is located in.
    /// <see href="http://schema.mobivoc.org/level"></see></summary>
    let level = Namespaced_IRI.parse _namespace_name "level" |> NamespacedName

    /// <summary>
    /// Indicates the maximum value of the capacity.
    /// <see href="http://schema.mobivoc.org/maximumValue"></see></summary>
    let maximumValue =
        Namespaced_IRI.parse _namespace_name "maximumValue" |> NamespacedName

    /// <summary>
    /// Indicates the charger model of the charging point.
    /// <see href="http://schema.mobivoc.org/model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName
    /// <summary>
    /// Name of the civic structure or facility.
    /// <see href="http://schema.mobivoc.org/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// Indicates the total number of levels a parking facility has.
    /// <see href="http://schema.mobivoc.org/numberOfLevels"></see></summary>
    let numberOfLevels =
        Namespaced_IRI.parse _namespace_name "numberOfLevels" |> NamespacedName

    /// <summary>
    /// The operator of a civic structure or facility. Operator and owner can be different business entitites.
    /// <see href="http://schema.mobivoc.org/operatedBy"></see></summary>
    let operatedBy = Namespaced_IRI.parse _namespace_name "operatedBy" |> NamespacedName
    /// <summary>
    /// Indicates that a time period overnight is possible.
    /// <see href="http://schema.mobivoc.org/overnight"></see></summary>
    let overnight = Namespaced_IRI.parse _namespace_name "overnight" |> NamespacedName
    /// <summary>
    /// The owner of a civic structure or facility. Owner and operator can be different business entities.
    /// <see href="http://schema.mobivoc.org/ownedBy"></see></summary>
    let ownedBy = Namespaced_IRI.parse _namespace_name "ownedBy" |> NamespacedName

    /// <summary>
    /// Relates the parking facility to a contained parking space.
    /// <see href="http://schema.mobivoc.org/parkingSpace"></see></summary>
    let parkingSpace =
        Namespaced_IRI.parse _namespace_name "parkingSpace" |> NamespacedName

    /// <summary>
    /// URL of the picture of a civic structure or facility.
    /// <see href="http://schema.mobivoc.org/picture"></see></summary>
    let picture = Namespaced_IRI.parse _namespace_name "picture" |> NamespacedName
    /// <summary>
    /// Indicates the plugs available at a charger.
    /// <see href="http://schema.mobivoc.org/plug"></see></summary>
    let plug = Namespaced_IRI.parse _namespace_name "plug" |> NamespacedName
    /// <summary>
    /// Indicates the type of a plug.
    /// <see href="http://schema.mobivoc.org/plugType"></see></summary>
    let plugType = Namespaced_IRI.parse _namespace_name "plugType" |> NamespacedName
    /// <summary>
    /// Indicates the power of a charger or plug in kilowatts.
    /// <see href="http://schema.mobivoc.org/powerInKW"></see></summary>
    let powerInKW = Namespaced_IRI.parse _namespace_name "powerInKW" |> NamespacedName
    /// <summary>
    /// Indicates that a civic structure can be used for a specific price.
    /// <see href="http://schema.mobivoc.org/price"></see></summary>
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName

    /// <summary>
    /// The current queuing time (duration) for entering the parking facility.
    /// <see href="http://schema.mobivoc.org/queuingTime"></see></summary>
    let queuingTime =
        Namespaced_IRI.parse _namespace_name "queuingTime" |> NamespacedName

    /// <summary>
    /// Indicates the percentage value of parking spaces occupied in a parking facility.
    /// <see href="http://schema.mobivoc.org/rateOfOccupancy"></see></summary>
    let rateOfOccupancy =
        Namespaced_IRI.parse _namespace_name "rateOfOccupancy" |> NamespacedName

    /// <summary>
    /// Indicates whether three-phased current is available.
    /// <see href="http://schema.mobivoc.org/threePhasedCurrentAvailable"></see></summary>
    let threePhasedCurrentAvailable =
        Namespaced_IRI.parse _namespace_name "threePhasedCurrentAvailable" |> NamespacedName

    /// <summary>
    /// Indicates the end value of a time period.
    /// <see href="http://schema.mobivoc.org/timeEndValue"></see></summary>
    let timeEndValue =
        Namespaced_IRI.parse _namespace_name "timeEndValue" |> NamespacedName

    /// <summary>
    /// Indicates the start value of a time period.
    /// <see href="http://schema.mobivoc.org/timeStartValue"></see></summary>
    let timeStartValue =
        Namespaced_IRI.parse _namespace_name "timeStartValue" |> NamespacedName

    /// <summary>
    /// Indicates the time unit a value is specified for.
    /// <see href="http://schema.mobivoc.org/timeUnit"></see></summary>
    let timeUnit = Namespaced_IRI.parse _namespace_name "timeUnit" |> NamespacedName

    /// <summary>
    /// Indicates the total number of parking spaces of a parking facility.
    /// <see href="http://schema.mobivoc.org/totalCapacity"></see></summary>
    let totalCapacity =
        Namespaced_IRI.parse _namespace_name "totalCapacity" |> NamespacedName

    /// <summary>
    /// Indicates that a charge has to be paid for the usage of the civic structure.
    /// <see href="http://schema.mobivoc.org/unspecifiedCharge"></see></summary>
    let unspecifiedCharge =
        Namespaced_IRI.parse _namespace_name "unspecifiedCharge" |> NamespacedName

    /// <summary>
    /// Indicates that an entity is valid for a specific group of users.
    /// <see href="http://schema.mobivoc.org/validForUserGroup"></see></summary>
    let validForUserGroup =
        Namespaced_IRI.parse _namespace_name "validForUserGroup" |> NamespacedName

    /// <summary>
    /// Indicates that an entity is valid for a specific type of vehicle.
    /// <see href="http://schema.mobivoc.org/validForVehicle"></see></summary>
    let validForVehicle =
        Namespaced_IRI.parse _namespace_name "validForVehicle" |> NamespacedName

    /// <summary>
    /// Indicates the height limit in meter for vehicles using the parking facility.
    /// <see href="http://schema.mobivoc.org/vehicleHeightLimitInM"></see></summary>
    let vehicleHeightLimitInM =
        Namespaced_IRI.parse _namespace_name "vehicleHeightLimitInM" |> NamespacedName

    /// <summary>
    /// Indicates the length limit in meter for vehicles using the parking facility.
    /// <see href="http://schema.mobivoc.org/vehicleLengthLimitInM"></see></summary>
    let vehicleLengthLimitInM =
        Namespaced_IRI.parse _namespace_name "vehicleLengthLimitInM" |> NamespacedName

    /// <summary>
    /// Indicates the width limit in meter for vehicles using the parking facility.
    /// <see href="http://schema.mobivoc.org/vehicleWidthLimitInM"></see></summary>
    let vehicleWidthLimitInM =
        Namespaced_IRI.parse _namespace_name "vehicleWidthLimitInM" |> NamespacedName

    /// <summary>
    /// Indicates the voltage of a charger or plug in volt.
    /// <see href="http://schema.mobivoc.org/voltageInV"></see></summary>
    let voltageInV = Namespaced_IRI.parse _namespace_name "voltageInV" |> NamespacedName
