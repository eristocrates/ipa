namespace https.data.nasa.gov.ontologies.atmonto.equipment.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eqp =
    let _namespace_iri = Namespace_Iri eqp |> NamespaceIRI
    /// <summary>
    ///   <para>eqp:AircraftSubsystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An engineering subsystem of an aircraft.</para>
    /// labels<para>Aircraft subsystem</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftSubsystem">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftSubsystem</seealso>
    let AircraftSubsystem = Prefixed_Name(eqp, "AircraftSubsystem") |> PrefixedName
    /// <summary>
    ///   <para>eqp:wakeCategoryID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The wake category identification character (A through F).</para>
    /// labels<para>wake category ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#wakeCategoryID">https://data.nasa.gov/ontologies/atmonto/equipment#wakeCategoryID</seealso>
    let wakeCategoryID = Prefixed_Name(eqp, "wakeCategoryID") |> PrefixedName
    /// <summary>
    ///   <para>eqp:manufacturedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A link to the entity that manufactured the system.</para>
    /// labels<para>manufactured by</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#manufacturedBy">https://data.nasa.gov/ontologies/atmonto/equipment#manufacturedBy</seealso>
    let manufacturedBy = Prefixed_Name(eqp, "manufacturedBy") |> PrefixedName
    /// <summary>
    ///   <para>eqp:AircraftModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aircraft model represents a generic specification that describes the characteristics of a specific type of aircraft to be manufactured.</para>
    /// labels<para>Aircraft model</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftModel">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftModel</seealso>
    let AircraftModel = Prefixed_Name(eqp, "AircraftModel") |> PrefixedName
    /// <summary>
    ///   <para>eqp:AircraftType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aircraft type represents a set of related aircraft models. Each type corresponds to one of the FAA's aircraft type designators (e.g., B777 covers all Boeing 777 models).</para>
    /// labels<para>Aircraft Type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftType">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftType</seealso>
    let AircraftType = Prefixed_Name(eqp, "AircraftType") |> PrefixedName
    /// <summary>
    ///   <para>eqp:EngineeredSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents engineered systems as either decomposable or non-decomposible subsystems.</para>
    /// labels<para>Engineered system</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#EngineeredSystem">https://data.nasa.gov/ontologies/atmonto/equipment#EngineeredSystem</seealso>
    let EngineeredSystem = Prefixed_Name(eqp, "EngineeredSystem") |> PrefixedName

    /// <summary>
    ///   <para>eqp:ElectricalPowerSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aircraft subsystem responsible for generating and distributing electrical power.</para>
    /// labels<para>Electrical power system</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#ElectricalPowerSystem">https://data.nasa.gov/ontologies/atmonto/equipment#ElectricalPowerSystem</seealso>
    let ElectricalPowerSystem =
        Prefixed_Name(eqp, "ElectricalPowerSystem") |> PrefixedName

    /// <summary>
    ///   <para>eqp:DecomposableSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A complex engineering system that can be further decomposed into a set of decomposable subsystems and primitive components.</para>
    /// labels<para>Decomposable system</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#DecomposableSystem">https://data.nasa.gov/ontologies/atmonto/equipment#DecomposableSystem</seealso>
    let DecomposableSystem = Prefixed_Name(eqp, "DecomposableSystem") |> PrefixedName

    /// <summary>
    ///   <para>eqp:aircraftSerialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The manufacturer serial number of the aircraft.</para>
    /// labels<para>serial number</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftSerialNumber">https://data.nasa.gov/ontologies/atmonto/equipment#aircraftSerialNumber</seealso>
    let aircraftSerialNumber =
        Prefixed_Name(eqp, "aircraftSerialNumber") |> PrefixedName

    /// <summary>
    ///   <para>eqp:aircraftWeightHighBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The upper bound of the aircraft weight category.</para>
    /// labels<para>aircraft weight high bound</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightHighBound">https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightHighBound</seealso>
    let aircraftWeightHighBound =
        Prefixed_Name(eqp, "aircraftWeightHighBound") |> PrefixedName

    /// <summary>
    ///   <para>eqp:certificateIssueDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The date that an operating certificate was issued to the aircraft.</para>
    /// labels<para>certificate issue date</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#certificateIssueDate">https://data.nasa.gov/ontologies/atmonto/equipment#certificateIssueDate</seealso>
    let certificateIssueDate =
        Prefixed_Name(eqp, "certificateIssueDate") |> PrefixedName

    /// <summary>
    ///   <para>eqp:AircraftWakeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies a category of aircraft according to their wake turbulance characteristics (including takeoff weight and wingspan). These categories are useful for the purpose of FAA separation assurance. See FAA Order JO 7110.659B, Wake Turbulence Recategorization, effective March 01, 2015.</para>
    /// labels<para>Aircraft Wake Category</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWakeCategory">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWakeCategory</seealso>
    let AircraftWakeCategory =
        Prefixed_Name(eqp, "AircraftWakeCategory") |> PrefixedName

    /// <summary>
    ///   <para>eqp:BallBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit assembly in an aircraft mechanical subsystem, a ball bearing is positioned between a wheel and a fixed axle, in which the rotating part and the stationary part are separated by a ring of small solid metal balls that reduce friction.</para>
    /// labels<para>Ball bearing</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#BallBearing">https://data.nasa.gov/ontologies/atmonto/equipment#BallBearing</seealso>
    let BallBearing = Prefixed_Name(eqp, "BallBearing") |> PrefixedName
    /// <summary>
    ///   <para>eqp:EngineType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents different generic types of aircraft engines.</para>
    /// labels<para>Engine Type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#EngineType">https://data.nasa.gov/ontologies/atmonto/equipment#EngineType</seealso>
    let EngineType = Prefixed_Name(eqp, "EngineType") |> PrefixedName
    /// <summary>
    ///   <para>eqp:NavigationAid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A navaid (navigational aid) is an engineered system on the ground that airplanes can detect based on their emission of radio signals that enable the aircraft to navigate. Modern examples include NDBs and VORs, which both transmit radio signals that aircraft can follow and home in on.</para>
    /// labels<para>Navigation aid</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#NavigationAid">https://data.nasa.gov/ontologies/atmonto/equipment#NavigationAid</seealso>
    let NavigationAid = Prefixed_Name(eqp, "NavigationAid") |> PrefixedName
    /// <summary>
    ///   <para>eqp:aircraftRegistrant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The name of the entity that registered the aircraft with the FAA.</para>
    /// labels<para>aircraft registrant</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftRegistrant">https://data.nasa.gov/ontologies/atmonto/equipment#aircraftRegistrant</seealso>
    let aircraftRegistrant = Prefixed_Name(eqp, "aircraftRegistrant") |> PrefixedName

    /// <summary>
    ///   <para>eqp:aircraftTypeDesignator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The type designator code for this type of aircraft (e.g., B777).</para>
    /// labels<para>aircraft type designator</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftTypeDesignator">https://data.nasa.gov/ontologies/atmonto/equipment#aircraftTypeDesignator</seealso>
    let aircraftTypeDesignator =
        Prefixed_Name(eqp, "aircraftTypeDesignator") |> PrefixedName

    /// <summary>
    ///   <para>eqp:aircraftWeightLowBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The lower bound of the aircraft weight category.</para>
    /// labels<para>aircraft weight low bound</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightLowBound">https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightLowBound</seealso>
    let aircraftWeightLowBound =
        Prefixed_Name(eqp, "aircraftWeightLowBound") |> PrefixedName

    /// <summary>
    ///   <para>eqp:cicttNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>CAST/ICAO Common Taxonomy Team (CICTT) identifier for this model as specified by the International Aircraft Categorisation And Identification Standard (IACIS).</para>
    /// labels<para>CICTT number</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#cicttNumber">https://data.nasa.gov/ontologies/atmonto/equipment#cicttNumber</seealso>
    let cicttNumber = Prefixed_Name(eqp, "cicttNumber") |> PrefixedName
    /// <summary>
    ///   <para>eqp:designedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an aircraft model to the airframe manufacturer that designed the model.</para>
    /// labels<para>designed by</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#designedBy">https://data.nasa.gov/ontologies/atmonto/equipment#designedBy</seealso>
    let designedBy = Prefixed_Name(eqp, "designedBy") |> PrefixedName

    /// <summary>
    ///   <para>eqp:hasAircraftEngineType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an aircraft type to the type of engine it uses.</para>
    /// labels<para>has aircraft engine type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftEngineType">https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftEngineType</seealso>
    let hasAircraftEngineType =
        Prefixed_Name(eqp, "hasAircraftEngineType") |> PrefixedName

    /// <summary>
    ///   <para>eqp:hasAircraftWakeCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Links an aircraft model to its wake category.</para>
    /// labels<para>has aircraft wake category</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWakeCategory">https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWakeCategory</seealso>
    let hasAircraftWakeCategory =
        Prefixed_Name(eqp, "hasAircraftWakeCategory") |> PrefixedName

    /// <summary>
    ///   <para>eqp:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an engineered system to its primitive components.</para>
    /// labels<para>has component</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#hasComponent">https://data.nasa.gov/ontologies/atmonto/equipment#hasComponent</seealso>
    let hasComponent = Prefixed_Name(eqp, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>eqp:manufactureYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The year the system was manufactured.</para>
    /// labels<para>manufacture year</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#manufactureYear">https://data.nasa.gov/ontologies/atmonto/equipment#manufactureYear</seealso>
    let manufactureYear = Prefixed_Name(eqp, "manufactureYear") |> PrefixedName

    /// <summary>
    ///   <para>eqp:maxTakeoffWeightHighBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The upper bound of the maximum takeoff weight for this category.</para>
    /// labels<para>max takeoff weight high bound</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightHighBound">https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightHighBound</seealso>
    let maxTakeoffWeightHighBound =
        Prefixed_Name(eqp, "maxTakeoffWeightHighBound") |> PrefixedName

    /// <summary>
    ///   <para>eqp:maxTakeoffWeightLowBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The lower bound of the maximum takeoff weight for this category.</para>
    /// labels<para>max takeoff weight low bound</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightLowBound">https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightLowBound</seealso>
    let maxTakeoffWeightLowBound =
        Prefixed_Name(eqp, "maxTakeoffWeightLowBound") |> PrefixedName

    /// <summary>
    ///   <para>eqp:modelID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The string identifier of the model for this system/subsystem/assembly.</para>
    /// labels<para>model ID</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#modelID">https://data.nasa.gov/ontologies/atmonto/equipment#modelID</seealso>
    let modelID = Prefixed_Name(eqp, "modelID") |> PrefixedName
    /// <summary>
    ///   <para>eqp:numberOfEngines</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>The number of engines specified for this aircraft model or found on this aircraft.</para>
    /// labels<para>number of engines</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#numberOfEngines">https://data.nasa.gov/ontologies/atmonto/equipment#numberOfEngines</seealso>
    let numberOfEngines = Prefixed_Name(eqp, "numberOfEngines") |> PrefixedName
    /// <summary>
    ///   <para>eqp:numberOfSeats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The number of seats on this aircraft.</para>
    /// labels<para>number of seats</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#numberOfSeats">https://data.nasa.gov/ontologies/atmonto/equipment#numberOfSeats</seealso>
    let numberOfSeats = Prefixed_Name(eqp, "numberOfSeats") |> PrefixedName
    /// <summary>
    ///   <para>eqp:wingSpanHighBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The upper bound of the wingspan for this category.</para>
    /// labels<para>wing span high bound</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanHighBound">https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanHighBound</seealso>
    let wingSpanHighBound = Prefixed_Name(eqp, "wingSpanHighBound") |> PrefixedName
    /// <summary>
    ///   <para>eqp:wingSpanLowBound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The lower bound of the wingspan for this category.</para>
    /// labels<para>wing span low bound</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanLowBound">https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanLowBound</seealso>
    let wingSpanLowBound = Prefixed_Name(eqp, "wingSpanLowBound") |> PrefixedName

    /// <summary>
    ///   <para>eqp:AircraftNavigationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aircraft subsystem responsible for navigation functions.</para>
    /// labels<para>Aircraft navigation system</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftNavigationSystem">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftNavigationSystem</seealso>
    let AircraftNavigationSystem =
        Prefixed_Name(eqp, "AircraftNavigationSystem") |> PrefixedName

    /// <summary>
    ///   <para>eqp:AircraftWeightClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specifies a category of aircraft that can be used to partition aircraft according to their weight.</para>
    /// labels<para>Aircraft Weight Class</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWeightClass">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWeightClass</seealso>
    let AircraftWeightClass = Prefixed_Name(eqp, "AircraftWeightClass") |> PrefixedName
    /// <summary>
    ///   <para>eqp:UnitAssembly</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A primitive, non-decomposible component in an engineered system.</para>
    /// labels<para>Unit assembly</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#UnitAssembly">https://data.nasa.gov/ontologies/atmonto/equipment#UnitAssembly</seealso>
    let UnitAssembly = Prefixed_Name(eqp, "UnitAssembly") |> PrefixedName

    /// <summary>
    ///   <para>eqp:engineTypeDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A text description of the engine type characteristics.</para>
    /// labels<para>engine type description</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#engineTypeDescription">https://data.nasa.gov/ontologies/atmonto/equipment#engineTypeDescription</seealso>
    let engineTypeDescription =
        Prefixed_Name(eqp, "engineTypeDescription") |> PrefixedName

    /// <summary>
    ///   <para>eqp:hasAircraftModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links a specific aircraft to its model.</para>
    /// labels<para>has aircraft model</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftModel">https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftModel</seealso>
    let hasAircraftModel = Prefixed_Name(eqp, "hasAircraftModel") |> PrefixedName

    /// <summary>
    ///   <para>eqp:hasAircraftWeightClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links an aircraft model to its weight class.</para>
    /// labels<para>has aircraft weight class</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWeightClass">https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWeightClass</seealso>
    let hasAircraftWeightClass =
        Prefixed_Name(eqp, "hasAircraftWeightClass") |> PrefixedName

    /// <summary>
    ///   <para>eqp:isAircraftType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Links an aircraft model to its type, where the type represents a set of related models.</para>
    /// labels<para>is aircraft type</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#isAircraftType">https://data.nasa.gov/ontologies/atmonto/equipment#isAircraftType</seealso>
    let isAircraftType = Prefixed_Name(eqp, "isAircraftType") |> PrefixedName
    /// <summary>
    ///   <para>eqp:modeSCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The unique Mode S address of the transponder aboard the aircraft. Mode S equipment on aircraft are assigned a unique ICAO 24-bit address or (informally) Mode S hex code upon national registration and this address becomes a part of the aircraft's Certificate of Registration.</para>
    /// labels<para>mode SCode</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#modeSCode">https://data.nasa.gov/ontologies/atmonto/equipment#modeSCode</seealso>
    let modeSCode = Prefixed_Name(eqp, "modeSCode") |> PrefixedName
    /// <summary>
    ///   <para>eqp:registrationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The aircraft FAA registration number (the tail number, or the N-Number in the US).</para>
    /// labels<para>registration number</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#registrationNumber">https://data.nasa.gov/ontologies/atmonto/equipment#registrationNumber</seealso>
    let registrationNumber = Prefixed_Name(eqp, "registrationNumber") |> PrefixedName
    /// <summary>
    ///   <para>eqp:hasSubsystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Connects an engineered system to its subsystems.</para>
    /// labels<para>has subsystem</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#hasSubsystem">https://data.nasa.gov/ontologies/atmonto/equipment#hasSubsystem</seealso>
    let hasSubsystem = Prefixed_Name(eqp, "hasSubsystem") |> PrefixedName
    /// <summary>
    ///   <para>eqp:Aircraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical realization of an aircraft, produced according to the specifications defined for a specific model type.</para>
    /// labels<para>Aircraft</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#Aircraft">https://data.nasa.gov/ontologies/atmonto/equipment#Aircraft</seealso>
    let Aircraft = Prefixed_Name(eqp, "Aircraft") |> PrefixedName

    /// <summary>
    ///   <para>eqp:AircraftCommunicationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aircraft subsystem involving all voice and data communications functions.</para>
    /// labels<para>Aircraft communication system</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftCommunicationSystem">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftCommunicationSystem</seealso>
    let AircraftCommunicationSystem =
        Prefixed_Name(eqp, "AircraftCommunicationSystem") |> PrefixedName

    /// <summary>
    ///   <para>eqp:AircraftEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aircraft engine is the component of the propulsion system for an aircraft that generates mechanical power.</para>
    /// labels<para>Aircraft engine</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftEngine">https://data.nasa.gov/ontologies/atmonto/equipment#AircraftEngine</seealso>
    let AircraftEngine = Prefixed_Name(eqp, "AircraftEngine") |> PrefixedName

    /// <summary>
    ///   <para>eqp:aircraftModelCertainty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A numeric measure between 0 and 1 reflecting how certain the eqp:hasAircraftModel link is to be correct between the aircraft and the model. A value of one indicates 100% certainty. A lesser value is not to be taken as a percentage, but is a heuristic similarity value taken from the scoring of the TF/IDF similarity assessment performed between the FAA aircraft make/model in the FAA registration database and ICAO make/model names used in the ontology.</para>
    /// labels<para>aircraft model certainty</para></remarks>
    /// <seealso href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftModelCertainty">https://data.nasa.gov/ontologies/atmonto/equipment#aircraftModelCertainty</seealso>
    let aircraftModelCertainty =
        Prefixed_Name(eqp, "aircraftModelCertainty") |> PrefixedName
