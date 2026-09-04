#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module eqp =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://data.nasa.gov/ontologies/atmonto/equipment#" "eqp"

    /// <summary>
    ///   <para>rdfs:label : Aircraft^^xsd:string</para>
    ///   <para>rdfs:comment : A physical realization of an aircraft, produced according to the specifications defined for a specific model type.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#Aircraft">eqp:Aircraft</a>
    /// </summary>
    let Aircraft = _prefixId.prefix "Aircraft"
    /// <summary>
    ///   <para>rdfs:label : Aircraft communication system^^xsd:string</para>
    ///   <para>rdfs:comment : An aircraft subsystem involving all voice and data communications functions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftCommunicationSystem">eqp:AircraftCommunicationSystem</a>
    /// </summary>
    let AircraftCommunicationSystem = _prefixId.prefix "AircraftCommunicationSystem"
    /// <summary>
    ///   <para>rdfs:label : Aircraft engine^^xsd:string</para>
    ///   <para>rdfs:comment : An aircraft engine is the component of the propulsion system for an aircraft that generates mechanical power.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftEngine">eqp:AircraftEngine</a>
    /// </summary>
    let AircraftEngine = _prefixId.prefix "AircraftEngine"
    /// <summary>
    ///   <para>rdfs:label : Aircraft model^^xsd:string</para>
    ///   <para>rdfs:comment : An aircraft model represents a generic specification that describes the characteristics of a specific type of aircraft to be manufactured.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftModel">eqp:AircraftModel</a>
    /// </summary>
    let AircraftModel = _prefixId.prefix "AircraftModel"
    /// <summary>
    ///   <para>rdfs:label : Aircraft navigation system^^xsd:string</para>
    ///   <para>rdfs:comment : An aircraft subsystem responsible for navigation functions.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftNavigationSystem">eqp:AircraftNavigationSystem</a>
    /// </summary>
    let AircraftNavigationSystem = _prefixId.prefix "AircraftNavigationSystem"
    /// <summary>
    ///   <para>rdfs:label : Aircraft subsystem^^xsd:string</para>
    ///   <para>rdfs:comment : An engineering subsystem of an aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftSubsystem">eqp:AircraftSubsystem</a>
    /// </summary>
    let AircraftSubsystem = _prefixId.prefix "AircraftSubsystem"
    /// <summary>
    ///   <para>rdfs:label : Aircraft Type^^xsd:string</para>
    ///   <para>rdfs:comment : An aircraft type represents a set of related aircraft models. Each type corresponds to one of the FAA's aircraft type designators (e.g., B777 covers all Boeing 777 models).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftType">eqp:AircraftType</a>
    /// </summary>
    let AircraftType = _prefixId.prefix "AircraftType"
    /// <summary>
    ///   <para>rdfs:label : Aircraft Wake Category^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a category of aircraft according to their wake turbulance characteristics (including takeoff weight and wingspan). These categories are useful for the purpose of FAA separation assurance. See FAA Order JO 7110.659B, Wake Turbulence Recategorization, effective March 01, 2015.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWakeCategory">eqp:AircraftWakeCategory</a>
    /// </summary>
    let AircraftWakeCategory = _prefixId.prefix "AircraftWakeCategory"
    /// <summary>
    ///   <para>rdfs:label : Aircraft Weight Class^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a category of aircraft that can be used to partition aircraft according to their weight.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWeightClass">eqp:AircraftWeightClass</a>
    /// </summary>
    let AircraftWeightClass = _prefixId.prefix "AircraftWeightClass"
    /// <summary>
    ///   <para>rdfs:label : Ball bearing^^xsd:string</para>
    ///   <para>rdfs:comment : A unit assembly in an aircraft mechanical subsystem, a ball bearing is positioned between a wheel and a fixed axle, in which the rotating part and the stationary part are separated by a ring of small solid metal balls that reduce friction.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#BallBearing">eqp:BallBearing</a>
    /// </summary>
    let BallBearing = _prefixId.prefix "BallBearing"
    /// <summary>
    ///   <para>rdfs:label : Decomposable system^^xsd:string</para>
    ///   <para>rdfs:comment : A complex engineering system that can be further decomposed into a set of decomposable subsystems and primitive components.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#DecomposableSystem">eqp:DecomposableSystem</a>
    /// </summary>
    let DecomposableSystem = _prefixId.prefix "DecomposableSystem"
    /// <summary>
    ///   <para>rdfs:label : Electrical power system^^xsd:string</para>
    ///   <para>rdfs:comment : An aircraft subsystem responsible for generating and distributing electrical power.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#ElectricalPowerSystem">eqp:ElectricalPowerSystem</a>
    /// </summary>
    let ElectricalPowerSystem = _prefixId.prefix "ElectricalPowerSystem"
    /// <summary>
    ///   <para>rdfs:label : Engine Type^^xsd:string</para>
    ///   <para>rdfs:comment : Represents different generic types of aircraft engines.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#EngineType">eqp:EngineType</a>
    /// </summary>
    let EngineType = _prefixId.prefix "EngineType"
    /// <summary>
    ///   <para>rdfs:label : Engineered system^^xsd:string</para>
    ///   <para>rdfs:comment : Represents engineered systems as either decomposable or non-decomposible subsystems.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#EngineeredSystem">eqp:EngineeredSystem</a>
    /// </summary>
    let EngineeredSystem = _prefixId.prefix "EngineeredSystem"
    /// <summary>
    ///   <para>rdfs:label : Navigation aid^^xsd:string</para>
    ///   <para>rdfs:comment : A navaid (navigational aid) is an engineered system on the ground that airplanes can detect based on their emission of radio signals that enable the aircraft to navigate. Modern examples include NDBs and VORs, which both transmit radio signals that aircraft can follow and home in on.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#NavigationAid">eqp:NavigationAid</a>
    /// </summary>
    let NavigationAid = _prefixId.prefix "NavigationAid"
    /// <summary>
    ///   <para>rdfs:label : Unit assembly^^xsd:string</para>
    ///   <para>rdfs:comment : A primitive, non-decomposible component in an engineered system.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#UnitAssembly">eqp:UnitAssembly</a>
    /// </summary>
    let UnitAssembly = _prefixId.prefix "UnitAssembly"
    /// <summary>
    ///   <para>rdfs:label : aircraft model certainty^^xsd:string</para>
    ///   <para>rdfs:comment : A numeric measure between 0 and 1 reflecting how certain the eqp:hasAircraftModel link is to be correct between the aircraft and the model. A value of one indicates 100% certainty. A lesser value is not to be taken as a percentage, but is a heuristic similarity value taken from the scoring of the TF/IDF similarity assessment performed between the FAA aircraft make/model in the FAA registration database and ICAO make/model names used in the ontology.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftModelCertainty">eqp:aircraftModelCertainty</a>
    /// </summary>
    let aircraftModelCertainty = _prefixId.prefix "aircraftModelCertainty"
    /// <summary>
    ///   <para>rdfs:label : aircraft registrant^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the entity that registered the aircraft with the FAA.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftRegistrant">eqp:aircraftRegistrant</a>
    /// </summary>
    let aircraftRegistrant = _prefixId.prefix "aircraftRegistrant"
    /// <summary>
    ///   <para>rdfs:label : serial number^^xsd:string</para>
    ///   <para>rdfs:comment : The manufacturer serial number of the aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftSerialNumber">eqp:aircraftSerialNumber</a>
    /// </summary>
    let aircraftSerialNumber = _prefixId.prefix "aircraftSerialNumber"
    /// <summary>
    ///   <para>rdfs:label : aircraft type designator^^xsd:string</para>
    ///   <para>rdfs:comment : The type designator code for this type of aircraft (e.g., B777).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftTypeDesignator">eqp:aircraftTypeDesignator</a>
    /// </summary>
    let aircraftTypeDesignator = _prefixId.prefix "aircraftTypeDesignator"
    /// <summary>
    ///   <para>rdfs:label : aircraft weight high bound^^xsd:string</para>
    ///   <para>rdfs:comment : The upper bound of the aircraft weight category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightHighBound">eqp:aircraftWeightHighBound</a>
    /// </summary>
    let aircraftWeightHighBound = _prefixId.prefix "aircraftWeightHighBound"
    /// <summary>
    ///   <para>rdfs:label : aircraft weight low bound^^xsd:string</para>
    ///   <para>rdfs:comment : The lower bound of the aircraft weight category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightLowBound">eqp:aircraftWeightLowBound</a>
    /// </summary>
    let aircraftWeightLowBound = _prefixId.prefix "aircraftWeightLowBound"
    /// <summary>
    ///   <para>rdfs:label : certificate issue date^^xsd:string</para>
    ///   <para>rdfs:comment : The date that an operating certificate was issued to the aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#certificateIssueDate">eqp:certificateIssueDate</a>
    /// </summary>
    let certificateIssueDate = _prefixId.prefix "certificateIssueDate"
    /// <summary>
    ///   <para>rdfs:label : CICTT number^^xsd:string</para>
    ///   <para>rdfs:comment : CAST/ICAO Common Taxonomy Team (CICTT) identifier for this model as specified by the International Aircraft Categorisation And Identification Standard (IACIS).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#cicttNumber">eqp:cicttNumber</a>
    /// </summary>
    let cicttNumber = _prefixId.prefix "cicttNumber"
    /// <summary>
    ///   <para>rdfs:label : designed by^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft model to the airframe manufacturer that designed the model.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#designedBy">eqp:designedBy</a>
    /// </summary>
    let designedBy = _prefixId.prefix "designedBy"
    /// <summary>
    ///   <para>rdfs:label : engine type description^^xsd:string</para>
    ///   <para>rdfs:comment : A text description of the engine type characteristics.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#engineTypeDescription">eqp:engineTypeDescription</a>
    /// </summary>
    let engineTypeDescription = _prefixId.prefix "engineTypeDescription"
    /// <summary>
    ///   <para>rdfs:label : has aircraft engine type^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft type to the type of engine it uses.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftEngineType">eqp:hasAircraftEngineType</a>
    /// </summary>
    let hasAircraftEngineType = _prefixId.prefix "hasAircraftEngineType"
    /// <summary>
    ///   <para>rdfs:label : has aircraft model^^xsd:string</para>
    ///   <para>rdfs:comment : Links a specific aircraft to its model.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftModel">eqp:hasAircraftModel</a>
    /// </summary>
    let hasAircraftModel = _prefixId.prefix "hasAircraftModel"
    /// <summary>
    ///   <para>rdfs:label : has aircraft wake category^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft model to its wake category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWakeCategory">eqp:hasAircraftWakeCategory</a>
    /// </summary>
    let hasAircraftWakeCategory = _prefixId.prefix "hasAircraftWakeCategory"
    /// <summary>
    ///   <para>rdfs:label : has aircraft weight class^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft model to its weight class.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWeightClass">eqp:hasAircraftWeightClass</a>
    /// </summary>
    let hasAircraftWeightClass = _prefixId.prefix "hasAircraftWeightClass"
    /// <summary>
    ///   <para>rdfs:label : has component^^xsd:string</para>
    ///   <para>rdfs:comment : Connects an engineered system to its primitive components.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#hasComponent">eqp:hasComponent</a>
    /// </summary>
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:label : has subsystem^^xsd:string</para>
    ///   <para>rdfs:comment : Connects an engineered system to its subsystems.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#hasSubsystem">eqp:hasSubsystem</a>
    /// </summary>
    let hasSubsystem = _prefixId.prefix "hasSubsystem"
    /// <summary>
    ///   <para>rdfs:label : is aircraft type^^xsd:string</para>
    ///   <para>rdfs:comment : Links an aircraft model to its type, where the type represents a set of related models.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#isAircraftType">eqp:isAircraftType</a>
    /// </summary>
    let isAircraftType = _prefixId.prefix "isAircraftType"
    /// <summary>
    ///   <para>rdfs:label : manufacture year^^xsd:string</para>
    ///   <para>rdfs:comment : The year the system was manufactured.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#manufactureYear">eqp:manufactureYear</a>
    /// </summary>
    let manufactureYear = _prefixId.prefix "manufactureYear"
    /// <summary>
    ///   <para>rdfs:label : manufactured by^^xsd:string</para>
    ///   <para>rdfs:comment : A link to the entity that manufactured the system.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#manufacturedBy">eqp:manufacturedBy</a>
    /// </summary>
    let manufacturedBy = _prefixId.prefix "manufacturedBy"
    /// <summary>
    ///   <para>rdfs:label : max takeoff weight high bound^^xsd:string</para>
    ///   <para>rdfs:comment : The upper bound of the maximum takeoff weight for this category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightHighBound">eqp:maxTakeoffWeightHighBound</a>
    /// </summary>
    let maxTakeoffWeightHighBound = _prefixId.prefix "maxTakeoffWeightHighBound"
    /// <summary>
    ///   <para>rdfs:label : max takeoff weight low bound^^xsd:string</para>
    ///   <para>rdfs:comment : The lower bound of the maximum takeoff weight for this category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightLowBound">eqp:maxTakeoffWeightLowBound</a>
    /// </summary>
    let maxTakeoffWeightLowBound = _prefixId.prefix "maxTakeoffWeightLowBound"
    /// <summary>
    ///   <para>rdfs:label : mode SCode^^xsd:string</para>
    ///   <para>rdfs:comment : The unique Mode S address of the transponder aboard the aircraft. Mode S equipment on aircraft are assigned a unique ICAO 24-bit address or (informally) Mode S hex code upon national registration and this address becomes a part of the aircraft's Certificate of Registration.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#modeSCode">eqp:modeSCode</a>
    /// </summary>
    let modeSCode = _prefixId.prefix "modeSCode"
    /// <summary>
    ///   <para>rdfs:label : model ID^^xsd:string</para>
    ///   <para>rdfs:comment : The string identifier of the model for this system/subsystem/assembly.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#modelID">eqp:modelID</a>
    /// </summary>
    let modelID = _prefixId.prefix "modelID"
    /// <summary>
    ///   <para>rdfs:label : number of engines^^xsd:string</para>
    ///   <para>rdfs:comment : The number of engines specified for this aircraft model or found on this aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#numberOfEngines">eqp:numberOfEngines</a>
    /// </summary>
    let numberOfEngines = _prefixId.prefix "numberOfEngines"
    /// <summary>
    ///   <para>rdfs:label : number of seats^^xsd:string</para>
    ///   <para>rdfs:comment : The number of seats on this aircraft.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#numberOfSeats">eqp:numberOfSeats</a>
    /// </summary>
    let numberOfSeats = _prefixId.prefix "numberOfSeats"
    /// <summary>
    ///   <para>rdfs:label : registration number^^xsd:string</para>
    ///   <para>rdfs:comment : The aircraft FAA registration number (the tail number, or the N-Number in the US).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#registrationNumber">eqp:registrationNumber</a>
    /// </summary>
    let registrationNumber = _prefixId.prefix "registrationNumber"
    /// <summary>
    ///   <para>rdfs:label : wake category ID^^xsd:string</para>
    ///   <para>rdfs:comment : The wake category identification character (A through F).^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#wakeCategoryID">eqp:wakeCategoryID</a>
    /// </summary>
    let wakeCategoryID = _prefixId.prefix "wakeCategoryID"
    /// <summary>
    ///   <para>rdfs:label : wing span high bound^^xsd:string</para>
    ///   <para>rdfs:comment : The upper bound of the wingspan for this category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanHighBound">eqp:wingSpanHighBound</a>
    /// </summary>
    let wingSpanHighBound = _prefixId.prefix "wingSpanHighBound"
    /// <summary>
    ///   <para>rdfs:label : wing span low bound^^xsd:string</para>
    ///   <para>rdfs:comment : The lower bound of the wingspan for this category.^^xsd:string</para>
    ///   <a href="https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanLowBound">eqp:wingSpanLowBound</a>
    /// </summary>
    let wingSpanLowBound = _prefixId.prefix "wingSpanLowBound"
