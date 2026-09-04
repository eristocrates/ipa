#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module nas =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/NAS#" "nas"

    /// <summary>
    ///   <para>rdfs:label : ARTCC^^xsd:string</para>
    ///   <para>rdfs:comment : Air Route Traffic Control Center (ARTCC or 'Center') facility^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCC">nas:ARTCC</a>
    /// </summary>
    let ARTCC = _prefixId.prefix "ARTCC"
    /// <summary>
    ///   <para>rdfs:label : ARTCCtier^^xsd:string</para>
    ///   <para>rdfs:comment : A donut-shaped geographical area surrounding a designated central ARTCC. The first tier includes all the ARTCCs that share a boundary with the designated  ARTCC. The tier two ARTCCs includes the first tier ARTCCs plus those adjacent to the first tier ARCCCs. And so on.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#ARTCCtier">nas:ARTCCtier</a>
    /// </summary>
    let ARTCCtier = _prefixId.prefix "ARTCCtier"
    /// <summary>
    ///   <para>rdfs:label : ATCSCC^^xsd:string</para>
    ///   <para>rdfs:comment : Air Traffic Control System Command Center (ATCSCC) facility^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCSCC">nas:ATCSCC</a>
    /// </summary>
    let ATCSCC = _prefixId.prefix "ATCSCC"
    /// <summary>
    ///   <para>rdfs:label : ATCT^^xsd:string</para>
    ///   <para>rdfs:comment : Air Traffic Control Tower (ATCT) facility^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#ATCT">nas:ATCT</a>
    /// </summary>
    let ATCT = _prefixId.prefix "ATCT"
    /// <summary>
    ///   <para>rdfs:label : Air carrier^^xsd:string</para>
    ///   <para>rdfs:comment : An entity that it licensed to operate aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirCarrier">nas:AirCarrier</a>
    /// </summary>
    let AirCarrier = _prefixId.prefix "AirCarrier"
    /// <summary>
    ///   <para>rdfs:label : Aircraft engine manufacturer^^xsd:string</para>
    ///   <para>rdfs:comment : A manufacturer of aircraft engines.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AircraftEngineManufacturer">nas:AircraftEngineManufacturer</a>
    /// </summary>
    let AircraftEngineManufacturer = _prefixId.prefix "AircraftEngineManufacturer"
    /// <summary>
    ///   <para>rdfs:label : Airframe manufacturer^^xsd:string</para>
    ///   <para>rdfs:comment : A manufacturer of physical aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirframeManufacturer">nas:AirframeManufacturer</a>
    /// </summary>
    let AirframeManufacturer = _prefixId.prefix "AirframeManufacturer"
    /// <summary>
    ///   <para>rdfs:label : Airport^^xsd:string</para>
    ///   <para>rdfs:comment : A facility where regularly-scheduled aircraft arrive and depart.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#Airport">nas:Airport</a>
    /// </summary>
    let Airport = _prefixId.prefix "Airport"

    /// <summary>
    ///   <para>rdfs:label : Airport infrastructure component^^xsd:string</para>
    ///   <para>rdfs:comment : Part of an airport's physical infrastructure, including gates, terminals, runways, taxiways, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportInfrastructureComponent">nas:AirportInfrastructureComponent</a>
    /// </summary>
    let AirportInfrastructureComponent =
        _prefixId.prefix "AirportInfrastructureComponent"

    /// <summary>
    ///   <para>rdfs:label : Airport route^^xsd:string</para>
    ///   <para>rdfs:comment : A route within a SID or STAR that connects the common route to one of multiple airports that use the SID/STAR.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportRoute">nas:AirportRoute</a>
    /// </summary>
    let AirportRoute = _prefixId.prefix "AirportRoute"
    /// <summary>
    ///   <para>rdfs:label : Airport service vehicle^^xsd:string</para>
    ///   <para>rdfs:comment : A class of vehicles that service the flights and maintain the airport physical infrastructure.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirportServiceVehicle">nas:AirportServiceVehicle</a>
    /// </summary>
    let AirportServiceVehicle = _prefixId.prefix "AirportServiceVehicle"

    /// <summary>
    ///   <para>rdfs:label : Airspace infrastructure component^^xsd:string</para>
    ///   <para>rdfs:comment : A defined substructure of the airspace used to manage air traffic, including sectors, SIDs, STARs, routes, etc.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceInfrastructureComponent">nas:AirspaceInfrastructureComponent</a>
    /// </summary>
    let AirspaceInfrastructureComponent =
        _prefixId.prefix "AirspaceInfrastructureComponent"

    /// <summary>
    ///   <para>rdfs:label : Airspace layer^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a layer within the airspace, defined by a shear-sided polygon with specified low and high altitudes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceLayer">nas:AirspaceLayer</a>
    /// </summary>
    let AirspaceLayer = _prefixId.prefix "AirspaceLayer"
    /// <summary>
    ///   <para>rdfs:comment : An ordered sequence of navigation elements specifying a path through the airspace.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AirspaceRoute">nas:AirspaceRoute</a>
    /// </summary>
    let AirspaceRoute = _prefixId.prefix "AirspaceRoute"
    /// <summary>
    ///   <para>rdfs:label : Aviation industry manufacturer^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass encompassing the set of airframe and engine manufacturers.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationIndustryManufacturer">nas:AviationIndustryManufacturer</a>
    /// </summary>
    let AviationIndustryManufacturer = _prefixId.prefix "AviationIndustryManufacturer"
    /// <summary>
    ///   <para>rdfs:label : Aviation service provider^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass encompassing all entities that provide aviation services in the public and private sectors.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#AviationServiceProvider">nas:AviationServiceProvider</a>
    /// </summary>
    let AviationServiceProvider = _prefixId.prefix "AviationServiceProvider"
    /// <summary>
    ///   <para>rdfs:label : Continental US airport^^xsd:string</para>
    ///   <para>rdfs:comment : The set of airports in the continental US.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#CONUSairport">nas:CONUSairport</a>
    /// </summary>
    let CONUSairport = _prefixId.prefix "CONUSairport"
    /// <summary>
    ///   <para>rdfs:label : Canadian airport^^xsd:string</para>
    ///   <para>rdfs:comment : The set of Canadian airports.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#CanadianAirport">nas:CanadianAirport</a>
    /// </summary>
    let CanadianAirport = _prefixId.prefix "CanadianAirport"
    /// <summary>
    ///   <para>rdfs:label : Common route^^xsd:string</para>
    ///   <para>rdfs:comment : The backbone portion of a SID or STAR that is flown by all aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#CommonRoute">nas:CommonRoute</a>
    /// </summary>
    let CommonRoute = _prefixId.prefix "CommonRoute"
    /// <summary>
    ///   <para>rdfs:label : Deicing pad^^xsd:string</para>
    ///   <para>rdfs:comment : A physical location in the airport where deicing is performed.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingPad">nas:DeicingPad</a>
    /// </summary>
    let DeicingPad = _prefixId.prefix "DeicingPad"
    /// <summary>
    ///   <para>rdfs:label : Deicing queue^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered sequence of aircraft awaiting deicing at a deicing pad.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingQueue">nas:DeicingQueue</a>
    /// </summary>
    let DeicingQueue = _prefixId.prefix "DeicingQueue"
    /// <summary>
    ///   <para>rdfs:label : Deicing truck^^xsd:string</para>
    ///   <para>rdfs:comment : A vehicle that holds deicing fluid and pumping equipment to support deicing.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#DeicingTruck">nas:DeicingTruck</a>
    /// </summary>
    let DeicingTruck = _prefixId.prefix "DeicingTruck"
    /// <summary>
    ///   <para>rdfs:label : Federal airway^^xsd:string</para>
    ///   <para>rdfs:comment : An airspace route that is defined by FAA and can be filed as part of a flight plan: a jet route, a Q-route,  a T-Route, a Victor route.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#FederalAirway">nas:FederalAirway</a>
    /// </summary>
    let FederalAirway = _prefixId.prefix "FederalAirway"
    /// <summary>
    ///   <para>rdfs:label : Gate^^xsd:string</para>
    ///   <para>rdfs:comment : A physical interface between the aircraft and the terminal, used to board passengers and crew.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#Gate">nas:Gate</a>
    /// </summary>
    let Gate = _prefixId.prefix "Gate"

    /// <summary>
    ///   <para>rdfs:label : Government aviation service provider^^xsd:string</para>
    ///   <para>rdfs:comment : The set of govenment agencies that perform aviation services.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#GovernmentAviationServiceProvider">nas:GovernmentAviationServiceProvider</a>
    /// </summary>
    let GovernmentAviationServiceProvider =
        _prefixId.prefix "GovernmentAviationServiceProvider"

    /// <summary>
    ///   <para>rdfs:label : International airport^^xsd:string</para>
    ///   <para>rdfs:comment : The set of international (i.e., non-US) airports.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#InternationalAirport">nas:InternationalAirport</a>
    /// </summary>
    let InternationalAirport = _prefixId.prefix "InternationalAirport"
    /// <summary>
    ///   <para>rdfs:label : Jet route^^xsd:string</para>
    ///   <para>rdfs:comment : A high altitude airway based on ground-based VOR sensor locations.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#JetRoute">nas:JetRoute</a>
    /// </summary>
    let JetRoute = _prefixId.prefix "JetRoute"
    /// <summary>
    ///   <para>rdfs:label : NAS day^^xsd:string</para>
    ///   <para>rdfs:comment : A class that represents a day of the year. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#NASday">nas:NASday</a>
    /// </summary>
    let NASday = _prefixId.prefix "NASday"
    /// <summary>
    ///   <para>rdfs:label : NAS facility^^xsd:string</para>
    ///   <para>rdfs:comment : The set of FAA and airport facilities involved in operational air traffic management.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#NASfacility">nas:NASfacility</a>
    /// </summary>
    let NASfacility = _prefixId.prefix "NASfacility"
    /// <summary>
    ///   <para>rdfs:label : NAShour^^xsd:string</para>
    ///   <para>rdfs:comment : A class that represents an hour within a day. Events, such as flights, weather forecasts, and other events are linked to the instance of the day they occurred.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#NAShour">nas:NAShour</a>
    /// </summary>
    let NAShour = _prefixId.prefix "NAShour"
    /// <summary>
    ///   <para>rdfs:label : Non CONUS airport^^xsd:string</para>
    ///   <para>rdfs:comment : The set of airports located in the United States, but outside the contiguous lower 48 states.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#NonCONUSairport">nas:NonCONUSairport</a>
    /// </summary>
    let NonCONUSairport = _prefixId.prefix "NonCONUSairport"
    /// <summary>
    ///   <para>rdfs:label : Operational runway^^xsd:string</para>
    ///   <para>rdfs:comment : An operational runway is a named runway one used in airport operations. There are two operational runways corresponding to one physical runway; these operational runways are 180 degrees apart.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#OperationalRunway">nas:OperationalRunway</a>
    /// </summary>
    let OperationalRunway = _prefixId.prefix "OperationalRunway"
    /// <summary>
    ///   <para>rdfs:label : Physical Runway^^xsd:string</para>
    ///   <para>rdfs:comment : A physical runway, defined as a delimited rectangular surface region of the airport. Each physical runway is associated with two operational runways, 180 degrees apart.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#PhysicalRunway">nas:PhysicalRunway</a>
    /// </summary>
    let PhysicalRunway = _prefixId.prefix "PhysicalRunway"
    /// <summary>
    ///   <para>rdfs:label : Q-Route^^xsd:string</para>
    ///   <para>rdfs:comment : A high altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#QRoute">nas:QRoute</a>
    /// </summary>
    let QRoute = _prefixId.prefix "QRoute"
    /// <summary>
    ///   <para>rdfs:label : RNAV route^^xsd:string</para>
    ///   <para>rdfs:comment : An RNAV (Random Navigation) route is defined relative to a network of existing ground-based navigation beacons.  RNAV allows an aircraft to choose any course within the network, rather than navigate using only point-to-point routes defined by the beacons.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#RNAVroute">nas:RNAVroute</a>
    /// </summary>
    let RNAVroute = _prefixId.prefix "RNAVroute"
    /// <summary>
    ///   <para>rdfs:label : Radial Route^^xsd:string</para>
    ///   <para>rdfs:comment : A route that follows a specified radial path emanating from a given fix.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#RadialRoute">nas:RadialRoute</a>
    /// </summary>
    let RadialRoute = _prefixId.prefix "RadialRoute"
    /// <summary>
    ///   <para>rdfs:label : Ramp tower^^xsd:string</para>
    ///   <para>rdfs:comment : A control tower from which ramp controllers guide aircraft movements as they enter and exit the taxiways, and arrive and leave the gates. The ramp is the area of the airport surface where planes, service vehicles, and people meet.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#RampTower">nas:RampTower</a>
    /// </summary>
    let RampTower = _prefixId.prefix "RampTower"
    /// <summary>
    ///   <para>rdfs:label : Refueling truck^^xsd:string</para>
    ///   <para>rdfs:comment : Vechicle that transports and pumps jet fuel to refuel aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#RefuelingTruck">nas:RefuelingTruck</a>
    /// </summary>
    let RefuelingTruck = _prefixId.prefix "RefuelingTruck"
    /// <summary>
    ///   <para>rdfs:label : RVR measurement^^xsd:string</para>
    ///   <para>rdfs:comment : A measurement of the distance over which a pilot of an aircraft on the centerline of a runway can see the runway surface markings delineating the runway and its centerline. RVR (Runway Visible Range) is expressed as an interval specifying the minimum and maximum number of feet visible.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#RunwayVisibleRangeMeasurement">nas:RunwayVisibleRangeMeasurement</a>
    /// </summary>
    let RunwayVisibleRangeMeasurement = _prefixId.prefix "RunwayVisibleRangeMeasurement"
    /// <summary>
    ///   <para>rdfs:label : Standard Instrument Departure^^xsd:string</para>
    ///   <para>rdfs:comment : A SID (Standard Instrument Departure) is an air traffic control coded departure procedure that has been established at certain airports to simplify clearance delivery procedures.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#SID">nas:SID</a>
    /// </summary>
    let SID = _prefixId.prefix "SID"
    /// <summary>
    ///   <para>rdfs:label : SIDSTAR^^xsd:string</para>
    ///   <para>rdfs:comment : A superclass of SID and STAR defining the properties shared by both, specifically the set of common, airport, and transition routes that comprise the SID/STAR.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTAR">nas:SIDSTAR</a>
    /// </summary>
    let SIDSTAR = _prefixId.prefix "SIDSTAR"
    /// <summary>
    ///   <para>rdfs:label : SIDSTARroute^^xsd:string</para>
    ///   <para>rdfs:comment : A route that defines a SID or STAR.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#SIDSTARroute">nas:SIDSTARroute</a>
    /// </summary>
    let SIDSTARroute = _prefixId.prefix "SIDSTARroute"
    /// <summary>
    ///   <para>rdfs:label : Standard Arrival Route^^xsd:string</para>
    ///   <para>rdfs:comment : A STAR (Standard Terminal Arrival Route) is an air traffic control coded arrival route established for application to arriving IFR (Instrument Flight Rules) aircraft destined for certain airports.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#STAR">nas:STAR</a>
    /// </summary>
    let STAR = _prefixId.prefix "STAR"
    /// <summary>
    ///   <para>rdfs:label : Sector^^xsd:string</para>
    ///   <para>rdfs:comment : A defined volume in the the airspace of an ARTCC or TRACON whose flight traffic is typically controlled by a single controller.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#Sector">nas:Sector</a>
    /// </summary>
    let Sector = _prefixId.prefix "Sector"
    /// <summary>
    ///   <para>rdfs:label : Stand-alone weather station^^xsd:string</para>
    ///   <para>rdfs:comment : A non-airport location where operational weather monitoring hardware is installed.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#StandAloneWeatherStation">nas:StandAloneWeatherStation</a>
    /// </summary>
    let StandAloneWeatherStation = _prefixId.prefix "StandAloneWeatherStation"
    /// <summary>
    ///   <para>rdfs:label : TRACON^^xsd:string</para>
    ///   <para>rdfs:comment : Terminal Radar Approach Control (TRACON) facility^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#TRACON">nas:TRACON</a>
    /// </summary>
    let TRACON = _prefixId.prefix "TRACON"
    /// <summary>
    ///   <para>rdfs:label : T-Route^^xsd:string</para>
    ///   <para>rdfs:comment : A low altitude RNAV airway route. (RNAV routes allow an aircraft to choose any course within a network of navigation beacons, rather than navigate directly to and from the beacons.)^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#TRoute">nas:TRoute</a>
    /// </summary>
    let TRoute = _prefixId.prefix "TRoute"
    /// <summary>
    ///   <para>rdfs:label : Taxiway^^xsd:string</para>
    ///   <para>rdfs:comment : An airport surface leading that connects the ramp area (i.e., the area in the vicinity of the gates) with the runways.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#Taxiway">nas:Taxiway</a>
    /// </summary>
    let Taxiway = _prefixId.prefix "Taxiway"
    /// <summary>
    ///   <para>rdfs:label : Terminal^^xsd:string</para>
    ///   <para>rdfs:comment : A structure on the airport surface that serves as an interface between people, baggage, and aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#Terminal">nas:Terminal</a>
    /// </summary>
    let Terminal = _prefixId.prefix "Terminal"
    /// <summary>
    ///   <para>rdfs:label : Transition route^^xsd:string</para>
    ///   <para>rdfs:comment : A route within a SID or STAR that feeds aircraft into or out from the common route of the SID/STAR. In other words, the transition route is a feeder route from the en route segment of a flight into the heart of a STAR for arrival; or an exit route from a SID funneling flights to their appropriate initial jet routes for the en route segment of flight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#TransitionRoute">nas:TransitionRoute</a>
    /// </summary>
    let TransitionRoute = _prefixId.prefix "TransitionRoute"
    /// <summary>
    ///   <para>rdfs:label : USairport^^xsd:string</para>
    ///   <para>rdfs:comment : The set of airports located in the United States.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#USairport">nas:USairport</a>
    /// </summary>
    let USairport = _prefixId.prefix "USairport"
    /// <summary>
    ///   <para>rdfs:label : VOR route^^xsd:string</para>
    ///   <para>rdfs:comment : A VOR route is defined relative to a network of existing ground-based VOR navigation beacons. VOR routes consist of point-to-point segments, where the points are defined by the beacons. More modern RNAV routes allow any path within the network, not limited to VOR-to-VOR segments.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#VORroute">nas:VORroute</a>
    /// </summary>
    let VORroute = _prefixId.prefix "VORroute"
    /// <summary>
    ///   <para>rdfs:label : Victor route^^xsd:string</para>
    ///   <para>rdfs:comment : A low altitude airway based on ground-based VOR sensor locations.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#VictorRoute">nas:VictorRoute</a>
    /// </summary>
    let VictorRoute = _prefixId.prefix "VictorRoute"
    /// <summary>
    ///   <para>rdfs:label : adjacent sector^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sector to an immediately adjacent sector that shares a boundary.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#adjacentSector">nas:adjacentSector</a>
    /// </summary>
    let adjacentSector = _prefixId.prefix "adjacentSector"
    /// <summary>
    ///   <para>rdfs:label : air carrier alias^^xsd:string</para>
    ///   <para>rdfs:comment : An alternative name for an air carrier.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierAlias">nas:airCarrierAlias</a>
    /// </summary>
    let airCarrierAlias = _prefixId.prefix "airCarrierAlias"
    /// <summary>
    ///   <para>rdfs:label : Air carrier name^^xsd:string</para>
    ///   <para>rdfs:comment : The official name of an air carrier.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airCarrierName">nas:airCarrierName</a>
    /// </summary>
    let airCarrierName = _prefixId.prefix "airCarrierName"
    /// <summary>
    ///   <para>rdfs:label : airline callsign^^xsd:string</para>
    ///   <para>rdfs:comment : The radio call sign associated with an the air carrier. Used by pilots and controllers to identify aircraft over radio frequencies.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airlineCallsign">nas:airlineCallsign</a>
    /// </summary>
    let airlineCallsign = _prefixId.prefix "airlineCallsign"
    /// <summary>
    ///   <para>rdfs:label : airport boundary^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport to a representation of its perimeter boundary.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airportBoundary">nas:airportBoundary</a>
    /// </summary>
    let airportBoundary = _prefixId.prefix "airportBoundary"
    /// <summary>
    ///   <para>rdfs:label : airport location^^xsd:string</para>
    ///   <para>rdfs:comment : Links to a geographic point designated as the airport location.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airportLocation">nas:airportLocation</a>
    /// </summary>
    let airportLocation = _prefixId.prefix "airportLocation"
    /// <summary>
    ///   <para>rdfs:label : airport name^^xsd:string</para>
    ///   <para>rdfs:comment : The official name of the airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airportName">nas:airportName</a>
    /// </summary>
    let airportName = _prefixId.prefix "airportName"
    /// <summary>
    ///   <para>rdfs:label : airspace layer high altitude^^xsd:string</para>
    ///   <para>rdfs:comment : The upper altitude bound of an airspace layer.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerHighAltitude">nas:airspaceLayerHighAltitude</a>
    /// </summary>
    let airspaceLayerHighAltitude = _prefixId.prefix "airspaceLayerHighAltitude"
    /// <summary>
    ///   <para>rdfs:label : airspace layer low altitude^^xsd:string</para>
    ///   <para>rdfs:comment : The lower altitude bound of an airspace layer.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#airspaceLayerLowAltitude">nas:airspaceLayerLowAltitude</a>
    /// </summary>
    let airspaceLayerLowAltitude = _prefixId.prefix "airspaceLayerLowAltitude"
    /// <summary>
    ///   <para>rdfs:label : arrival route airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the airport for which this route is destined.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#arrivalRouteAirport">nas:arrivalRouteAirport</a>
    /// </summary>
    let arrivalRouteAirport = _prefixId.prefix "arrivalRouteAirport"
    /// <summary>
    ///   <para>rdfs:label : artcc ID^^xsd:string</para>
    ///   <para>rdfs:comment : The 3-letter ARTCC (Air Route Traffic Control Center) code.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#artccID">nas:artccID</a>
    /// </summary>
    let artccID = _prefixId.prefix "artccID"
    /// <summary>
    ///   <para>rdfs:label : associated airport^^xsd:string</para>
    ///   <para>rdfs:comment : Associates some component of airport infrastructure (runway, terminal, tower, etc.) with its airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedAirport">nas:associatedAirport</a>
    /// </summary>
    let associatedAirport = _prefixId.prefix "associatedAirport"
    /// <summary>
    ///   <para>rdfs:label : associated operational runway^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a physical runway with its two operational runways (180 degrees apart, representing approaches from either end of the physical runway).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#associatedOpRunway">nas:associatedOpRunway</a>
    /// </summary>
    let associatedOpRunway = _prefixId.prefix "associatedOpRunway"
    /// <summary>
    ///   <para>rdfs:comment : The month number associated with a day class.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarMonth">nas:calendarMonth</a>
    /// </summary>
    let calendarMonth = _prefixId.prefix "calendarMonth"
    /// <summary>
    ///   <para>rdfs:comment : The calendar year associated with a day class.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#calendarYear">nas:calendarYear</a>
    /// </summary>
    let calendarYear = _prefixId.prefix "calendarYear"
    /// <summary>
    ///   <para>rdfs:label : country of registry^^xsd:string</para>
    ///   <para>rdfs:comment : The country name of the airline registration.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#countryOfRegistry">nas:countryOfRegistry</a>
    /// </summary>
    let countryOfRegistry = _prefixId.prefix "countryOfRegistry"
    /// <summary>
    ///   <para>rdfs:label : date^^xsd:string</para>
    ///   <para>rdfs:comment : The date corresponding to the day represented by the day class. The value of this property is a date datatype. In contrast, the class represents the day conceptually as an object.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#date">nas:date</a>
    /// </summary>
    let date = _prefixId.prefix "date"
    /// <summary>
    ///   <para>rdfs:comment : The day number associated with a day class.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#dayOfMonth">nas:dayOfMonth</a>
    /// </summary>
    let dayOfMonth = _prefixId.prefix "dayOfMonth"
    /// <summary>
    ///   <para>rdfs:label : deicing pad location^^xsd:string</para>
    ///   <para>rdfs:comment : Links a deicing pad with its location as a two-dimensional bounding polygon.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#deicingPadLocation">nas:deicingPadLocation</a>
    /// </summary>
    let deicingPadLocation = _prefixId.prefix "deicingPadLocation"
    /// <summary>
    ///   <para>rdfs:label : departure route airport^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the airport from which this route is destined.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#departureRouteAirport">nas:departureRouteAirport</a>
    /// </summary>
    let departureRouteAirport = _prefixId.prefix "departureRouteAirport"
    /// <summary>
    ///   <para>rdfs:label : FAA airport code^^xsd:string</para>
    ///   <para>rdfs:comment : The alphanumeric FAA code of lenth 3 or 4 for the airport. Contrasted with the ICAO and IATA codes, which in general are different. Often the IATA and FAA codes are identical.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#faaAirportCode">nas:faaAirportCode</a>
    /// </summary>
    let faaAirportCode = _prefixId.prefix "faaAirportCode"
    /// <summary>
    ///   <para>rdfs:label : gate ID^^xsd:string</para>
    ///   <para>rdfs:comment : The gate identifier assigned by the airport authority.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#gateID">nas:gateID</a>
    /// </summary>
    let gateID = _prefixId.prefix "gateID"
    /// <summary>
    ///   <para>rdfs:label : has airport route^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an airport route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirportRoute">nas:hasAirportRoute</a>
    /// </summary>
    let hasAirportRoute = _prefixId.prefix "hasAirportRoute"
    /// <summary>
    ///   <para>rdfs:label : has airspace layer geometry^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airspace layer with a polygon describing its location in 3-space. A sector is composed of a sequence of layers, each of which is represented as a shear-sided polygonal volume.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasAirspaceLayerGeometry">nas:hasAirspaceLayerGeometry</a>
    /// </summary>
    let hasAirspaceLayerGeometry = _prefixId.prefix "hasAirspaceLayerGeometry"
    /// <summary>
    ///   <para>rdfs:label : has center geometry^^xsd:string</para>
    ///   <para>rdfs:comment : Links an ARTCC to a 2-dimensional bounding polygon.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCenterGeometry">nas:hasCenterGeometry</a>
    /// </summary>
    let hasCenterGeometry = _prefixId.prefix "hasCenterGeometry"
    /// <summary>
    ///   <para>rdfs:label : has common route^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a common route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasCommonRoute">nas:hasCommonRoute</a>
    /// </summary>
    let hasCommonRoute = _prefixId.prefix "hasCommonRoute"
    /// <summary>
    ///   <para>rdfs:label : has gate^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an airport terminal with a aircraft gate located at that terminal.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasGate">nas:hasGate</a>
    /// </summary>
    let hasGate = _prefixId.prefix "hasGate"
    let hasLOAwith = _prefixId.prefix "hasLOAwith"
    /// <summary>
    ///   <para>rdfs:label : has queue^^xsd:string</para>
    ///   <para>rdfs:comment : Links a deicing pad to its queue of aircraft waiting to be deiced.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasQueue">nas:hasQueue</a>
    /// </summary>
    let hasQueue = _prefixId.prefix "hasQueue"
    /// <summary>
    ///   <para>rdfs:label : has ramp tower^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an airport terminal with a ramp tower that controlls the aircraft and vehicle traffic in the vicinity of that terminal.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRampTower">nas:hasRampTower</a>
    /// </summary>
    let hasRampTower = _prefixId.prefix "hasRampTower"
    /// <summary>
    ///   <para>rdfs:label : has runway^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport to a physical runway for that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasRunway">nas:hasRunway</a>
    /// </summary>
    let hasRunway = _prefixId.prefix "hasRunway"
    /// <summary>
    ///   <para>rdfs:label : has SID^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an airport with the the SIDs designated to route aircraft from that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSID">nas:hasSID</a>
    /// </summary>
    let hasSID = _prefixId.prefix "hasSID"
    /// <summary>
    ///   <para>rdfs:label : has STAR^^xsd:string</para>
    ///   <para>rdfs:comment : Associates an airport with the the STARs designated to route aircraft to that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSTAR">nas:hasSTAR</a>
    /// </summary>
    let hasSTAR = _prefixId.prefix "hasSTAR"
    /// <summary>
    ///   <para>rdfs:label : has sector ID^^xsd:string</para>
    ///   <para>rdfs:comment : A sector identifier that consists of the ARTCC identifier concatenated with a three-digit number. This identifier is in general different than the sector name.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorID">nas:hasSectorID</a>
    /// </summary>
    let hasSectorID = _prefixId.prefix "hasSectorID"
    /// <summary>
    ///   <para>rdfs:label : has sector layer^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sector to its vertically-stacked set of layers.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorLayer">nas:hasSectorLayer</a>
    /// </summary>
    let hasSectorLayer = _prefixId.prefix "hasSectorLayer"
    /// <summary>
    ///   <para>rdfs:label : has sector name^^xsd:string</para>
    ///   <para>rdfs:comment : An alphanumeric sector name that is in general different than the sector ID.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasSectorName">nas:hasSectorName</a>
    /// </summary>
    let hasSectorName = _prefixId.prefix "hasSectorName"
    /// <summary>
    ///   <para>rdfs:label : has TRACONcity^^xsd:string</para>
    ///   <para>rdfs:comment : The city name where the TRACON command center is located.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONcity">nas:hasTRACONcity</a>
    /// </summary>
    let hasTRACONcity = _prefixId.prefix "hasTRACONcity"
    /// <summary>
    ///   <para>rdfs:label : has TRACON ID^^xsd:string</para>
    ///   <para>rdfs:comment : The FAA alphanumeric code for the TRACON.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONid">nas:hasTRACONid</a>
    /// </summary>
    let hasTRACONid = _prefixId.prefix "hasTRACONid"
    /// <summary>
    ///   <para>rdfs:label : has TRACON layer^^xsd:string</para>
    ///   <para>rdfs:comment : A link between the TRACON and its geographic extent, represented as a single shear-sided polygonal volume.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONlayer">nas:hasTRACONlayer</a>
    /// </summary>
    let hasTRACONlayer = _prefixId.prefix "hasTRACONlayer"
    /// <summary>
    ///   <para>rdfs:label : has TRACON name^^xsd:string</para>
    ///   <para>rdfs:comment : The common name for the TRACON.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONname">nas:hasTRACONname</a>
    /// </summary>
    let hasTRACONname = _prefixId.prefix "hasTRACONname"
    /// <summary>
    ///   <para>rdfs:label : has TRACONstate^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the US state in which the TRACON command center is located.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONstate">nas:hasTRACONstate</a>
    /// </summary>
    let hasTRACONstate = _prefixId.prefix "hasTRACONstate"
    /// <summary>
    ///   <para>rdfs:label : has TRACONtype^^xsd:string</para>
    ///   <para>rdfs:comment : The type of TRACON: Tower-colocated TRACON or standalone TRACON.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTRACONtype">nas:hasTRACONtype</a>
    /// </summary>
    let hasTRACONtype = _prefixId.prefix "hasTRACONtype"
    /// <summary>
    ///   <para>rdfs:label : has taxiway^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport to a taxiway for that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTaxiway">nas:hasTaxiway</a>
    /// </summary>
    let hasTaxiway = _prefixId.prefix "hasTaxiway"
    /// <summary>
    ///   <para>rdfs:label : has terminal^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport to a terminal for that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTerminal">nas:hasTerminal</a>
    /// </summary>
    let hasTerminal = _prefixId.prefix "hasTerminal"
    /// <summary>
    ///   <para>rdfs:label : has tier^^xsd:string</para>
    ///   <para>rdfs:comment : Asociates an ARTCC with the set of ARTCCs in its nth level tier.  Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTier">nas:hasTier</a>
    /// </summary>
    let hasTier = _prefixId.prefix "hasTier"
    /// <summary>
    ///   <para>rdfs:label : has tower^^xsd:string</para>
    ///   <para>rdfs:comment : Links an airport to an air traffic control tower for that airport.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTower">nas:hasTower</a>
    /// </summary>
    let hasTower = _prefixId.prefix "hasTower"
    /// <summary>
    ///   <para>rdfs:label : has transition route^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a transition route with a SID or STAR. A SID or STAR has a single common route, but can have multiple airport or transition routes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hasTransitionRoute">nas:hasTransitionRoute</a>
    /// </summary>
    let hasTransitionRoute = _prefixId.prefix "hasTransitionRoute"
    /// <summary>
    ///   <para>rdfs:label : hours offset from UTC^^xsd:string</para>
    ///   <para>rdfs:comment : The number of hours that the airport is offset from the UTC timezone.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#hoursOffsetFromUTC">nas:hoursOffsetFromUTC</a>
    /// </summary>
    let hoursOffsetFromUTC = _prefixId.prefix "hoursOffsetFromUTC"
    /// <summary>
    ///   <para>rdfs:label : IATA Airport Code^^xsd:string</para>
    ///   <para>rdfs:comment : The thre-letter IATA code assigned to the airport. Contrast with the ICAO and FAA airport codes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#iataAirportCode">nas:iataAirportCode</a>
    /// </summary>
    let iataAirportCode = _prefixId.prefix "iataAirportCode"
    /// <summary>
    ///   <para>rdfs:label : IATA Carrier Code^^xsd:string</para>
    ///   <para>rdfs:comment : The two-letter IATA code assigned to the carrier.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#iataCarrierCode">nas:iataCarrierCode</a>
    /// </summary>
    let iataCarrierCode = _prefixId.prefix "iataCarrierCode"
    /// <summary>
    ///   <para>rdfs:label : ICAO airport code^^xsd:string</para>
    ///   <para>rdfs:comment : The four-letter ICAO code assignied to the airport. Contrast with the IATA and FAA airport codes.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoAirportCode">nas:icaoAirportCode</a>
    /// </summary>
    let icaoAirportCode = _prefixId.prefix "icaoAirportCode"
    /// <summary>
    ///   <para>rdfs:label : ICAO Air Carrier Code^^xsd:string</para>
    ///   <para>rdfs:comment : The three-letter ICAO code assigned to the airline carrier.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#icaoCarrierCode">nas:icaoCarrierCode</a>
    /// </summary>
    let icaoCarrierCode = _prefixId.prefix "icaoCarrierCode"
    /// <summary>
    ///   <para>rdfs:label : includes ARTCC^^xsd:string</para>
    ///   <para>rdfs:comment : A link between an ARTCC tier and the ARTCCs included in the tier.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#includesARTCC">nas:includesARTCC</a>
    /// </summary>
    let includesARTCC = _prefixId.prefix "includesARTCC"
    /// <summary>
    ///   <para>rdfs:label : is instrument control eligible^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether this airport is capable of an instrument approach.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#isInstrumentControlEligible">nas:isInstrumentControlEligible</a>
    /// </summary>
    let isInstrumentControlEligible = _prefixId.prefix "isInstrumentControlEligible"
    /// <summary>
    ///   <para>rdfs:label : is weather reporting station^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether this airport is a METAR weather reporting station.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#isWeatherReportingStation">nas:isWeatherReportingStation</a>
    /// </summary>
    let isWeatherReportingStation = _prefixId.prefix "isWeatherReportingStation"
    /// <summary>
    ///   <para>rdfs:label : located in Center^^xsd:string</para>
    ///   <para>rdfs:comment : Links a sector to the ARTCC in which the sector is located.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInCenter">nas:locatedInCenter</a>
    /// </summary>
    let locatedInCenter = _prefixId.prefix "locatedInCenter"
    /// <summary>
    ///   <para>rdfs:label : Located in State^^xsd:string</para>
    ///   <para>rdfs:comment : The 2-letter US postal code for the state in which the airport is located.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#locatedInState">nas:locatedInState</a>
    /// </summary>
    let locatedInState = _prefixId.prefix "locatedInState"
    /// <summary>
    ///   <para>rdfs:label : manufacturer country name^^xsd:string</para>
    ///   <para>rdfs:comment : The country name where the manufacturer is established.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerCountryName">nas:manufacturerCountryName</a>
    /// </summary>
    let manufacturerCountryName = _prefixId.prefix "manufacturerCountryName"
    /// <summary>
    ///   <para>rdfs:label : manufacturer full name^^xsd:string</para>
    ///   <para>rdfs:comment : The full name of the manufacturer.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#manufacturerFullName">nas:manufacturerFullName</a>
    /// </summary>
    let manufacturerFullName = _prefixId.prefix "manufacturerFullName"
    /// <summary>
    ///   <para>rdfs:label : max visibility^^xsd:string</para>
    ///   <para>rdfs:comment : The upper bound of visibility in feet over the centerline of the runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#maxVisibility">nas:maxVisibility</a>
    /// </summary>
    let maxVisibility = _prefixId.prefix "maxVisibility"
    /// <summary>
    ///   <para>rdfs:label : min visibility^^xsd:string</para>
    ///   <para>rdfs:comment : The lower bound of visibility in feet over the centerline of the runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#minVisibility">nas:minVisibility</a>
    /// </summary>
    let minVisibility = _prefixId.prefix "minVisibility"
    /// <summary>
    ///   <para>rdfs:label : route ID^^xsd:string</para>
    ///   <para>rdfs:comment : FAA alphanumeric identifier assigned to the route/airway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#routeID">nas:routeID</a>
    /// </summary>
    let routeID = _prefixId.prefix "routeID"
    /// <summary>
    ///   <para>rdfs:label : runway footprint^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a physical runway with its bounding two-dimensional rectangle.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayFootprint">nas:runwayFootprint</a>
    /// </summary>
    let runwayFootprint = _prefixId.prefix "runwayFootprint"
    /// <summary>
    ///   <para>rdfs:label : runway ID^^xsd:string</para>
    ///   <para>rdfs:comment : An identifier for the runway. For physical runways, the convention is to label runways by their heading, dropping the last digit. E.g. for Liverpool, runway 9/27 is facing approximately magnetic heading 90 degrees in one direction, and 270 degrees in the opposite direction. If an airport has parallel runways, these would then be marked Left, Center and Right, e.g. 9L, 9C, 9R. For operational runways, the runway identifiers specifies one direction only: either 9 or 27 in the Liverpool example.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayID">nas:runwayID</a>
    /// </summary>
    let runwayID = _prefixId.prefix "runwayID"
    /// <summary>
    ///   <para>rdfs:label : runway length in feet^^xsd:string</para>
    ///   <para>rdfs:comment : The length in feet of the physical runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayLengthInFeet">nas:runwayLengthInFeet</a>
    /// </summary>
    let runwayLengthInFeet = _prefixId.prefix "runwayLengthInFeet"
    /// <summary>
    ///   <para>rdfs:label : runway measured^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates which operational runway is being measured for visible range.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayMeasured">nas:runwayMeasured</a>
    /// </summary>
    let runwayMeasured = _prefixId.prefix "runwayMeasured"
    /// <summary>
    ///   <para>rdfs:label : runway width in feet^^xsd:string</para>
    ///   <para>rdfs:comment : The width in feet of the physical runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#runwayWidthInFeet">nas:runwayWidthInFeet</a>
    /// </summary>
    let runwayWidthInFeet = _prefixId.prefix "runwayWidthInFeet"
    /// <summary>
    ///   <para>rdfs:label : sidstar ID^^xsd:string</para>
    ///   <para>rdfs:comment : The FAA identifier for the SID or STAR. Typically, but not uniformly, 5 alpha characters plus a revision digit.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#sidstarID">nas:sidstarID</a>
    /// </summary>
    let sidstarID = _prefixId.prefix "sidstarID"
    /// <summary>
    ///   <para>rdfs:label : starting time^^xsd:string</para>
    ///   <para>rdfs:comment : The beginning of the hour stored as a datetime value.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#startingTime">nas:startingTime</a>
    /// </summary>
    let startingTime = _prefixId.prefix "startingTime"
    /// <summary>
    ///   <para>rdfs:label : taxiway location^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a taxiway with its bounding two-dimensional rectangle.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayFootprint">nas:taxiwayFootprint</a>
    /// </summary>
    let taxiwayFootprint = _prefixId.prefix "taxiwayFootprint"
    /// <summary>
    ///   <para>rdfs:label : taxiway ID^^xsd:string</para>
    ///   <para>rdfs:comment : An identifier for the taxiway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#taxiwayID">nas:taxiwayID</a>
    /// </summary>
    let taxiwayID = _prefixId.prefix "taxiwayID"
    /// <summary>
    ///   <para>rdfs:label : terminal ID^^xsd:string</para>
    ///   <para>rdfs:comment : The alphanumeric identifier of the airport terminal.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#terminalID">nas:terminalID</a>
    /// </summary>
    let terminalID = _prefixId.prefix "terminalID"
    /// <summary>
    ///   <para>rdfs:label : tfms monitor alert parameter^^xsd:string</para>
    ///   <para>rdfs:comment : The maximum number of aircraft permitted in a given sector at any time, per agreement between FAA and Air Traffic Controller union. MAP (Monitor Alert Parameter) is a TFMS input parameter.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#tfmsMonitorAlertParameter">nas:tfmsMonitorAlertParameter</a>
    /// </summary>
    let tfmsMonitorAlertParameter = _prefixId.prefix "tfmsMonitorAlertParameter"
    /// <summary>
    ///   <para>rdfs:label : tier level^^xsd:string</para>
    ///   <para>rdfs:comment : The degree number of the ARTCC tier. Tier 1 includes the central ARTCC plus all ARTCCs immediately adjoining the central ARTCC; tier 2 includes tier 1 plus all adjacent ARTCCs two steps away from the central ARTCC. And so on.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#tierLevel">nas:tierLevel</a>
    /// </summary>
    let tierLevel = _prefixId.prefix "tierLevel"
    /// <summary>
    ///   <para>rdfs:label : touchdown point^^xsd:string</para>
    ///   <para>rdfs:comment : Links to the geographical point location that is the touchdown spot on the operational runway.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#touchdownPoint">nas:touchdownPoint</a>
    /// </summary>
    let touchdownPoint = _prefixId.prefix "touchdownPoint"
    /// <summary>
    ///   <para>rdfs:label : tower ID^^xsd:string</para>
    ///   <para>rdfs:comment : The FAA identifier for air traffic control tower.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#towerID">nas:towerID</a>
    /// </summary>
    let towerID = _prefixId.prefix "towerID"
    /// <summary>
    ///   <para>rdfs:label : within ARTCC^^xsd:string</para>
    ///   <para>rdfs:comment : Links the airport to the ARTCC within which it is located.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#withinARTCC">nas:withinARTCC</a>
    /// </summary>
    let withinARTCC = _prefixId.prefix "withinARTCC"
    /// <summary>
    ///   <para>rdfs:label : within timezone^^xsd:string</para>
    ///   <para>rdfs:comment : The timezone identifier for the airport, where the timezone is specified as Area/Location, e.g. America/New_York.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/NAS#withinTimezone">nas:withinTimezone</a>
    /// </summary>
    let withinTimezone = _prefixId.prefix "withinTimezone"
