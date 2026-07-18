namespace https.data.nasa.gov.ontologies.atmonto.equipment.hash

open DoxAletheia.Rdf_Vocabulary

module eqp =
    let _namespace_name = "https://data.nasa.gov/ontologies/atmonto/equipment#"
    /// <summary>
    /// A physical realization of an aircraft, produced according to the specifications defined for a specific model type.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#Aircraft"></see></summary>
    let Aircraft = Namespaced_IRI.parse _namespace_name "Aircraft" |> NamespacedName

    /// <summary>
    /// A link to the entity that manufactured the system.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#manufacturedBy"></see></summary>
    let manufacturedBy =
        Namespaced_IRI.parse _namespace_name "manufacturedBy" |> NamespacedName

    /// <summary>
    /// A complex engineering system that can be further decomposed into a set of decomposable subsystems and primitive components.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#DecomposableSystem"></see></summary>
    let DecomposableSystem =
        Namespaced_IRI.parse _namespace_name "DecomposableSystem" |> NamespacedName

    /// <summary>
    /// An aircraft subsystem involving all voice and data communications functions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftCommunicationSystem"></see></summary>
    let AircraftCommunicationSystem =
        Namespaced_IRI.parse _namespace_name "AircraftCommunicationSystem" |> NamespacedName

    /// <summary>
    /// An engineering subsystem of an aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftSubsystem"></see></summary>
    let AircraftSubsystem =
        Namespaced_IRI.parse _namespace_name "AircraftSubsystem" |> NamespacedName

    /// <summary>
    /// An aircraft engine is the component of the propulsion system for an aircraft that generates mechanical power.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftEngine"></see></summary>
    let AircraftEngine =
        Namespaced_IRI.parse _namespace_name "AircraftEngine" |> NamespacedName

    /// <summary>
    /// An aircraft model represents a generic specification that describes the characteristics of a specific type of aircraft to be manufactured.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftModel"></see></summary>
    let AircraftModel =
        Namespaced_IRI.parse _namespace_name "AircraftModel" |> NamespacedName

    /// <summary>
    /// An aircraft subsystem responsible for navigation functions.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftNavigationSystem"></see></summary>
    let AircraftNavigationSystem =
        Namespaced_IRI.parse _namespace_name "AircraftNavigationSystem" |> NamespacedName

    /// <summary>
    /// An aircraft type represents a set of related aircraft models. Each type corresponds to one of the FAA's aircraft type designators (e.g., B777 covers all Boeing 777 models).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftType"></see></summary>
    let AircraftType =
        Namespaced_IRI.parse _namespace_name "AircraftType" |> NamespacedName

    /// <summary>
    /// Specifies a category of aircraft according to their wake turbulance characteristics (including takeoff weight and wingspan). These categories are useful for the purpose of FAA separation assurance. See FAA Order JO 7110.659B, Wake Turbulence Recategorization, effective March 01, 2015.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWakeCategory"></see></summary>
    let AircraftWakeCategory =
        Namespaced_IRI.parse _namespace_name "AircraftWakeCategory" |> NamespacedName

    /// <summary>
    /// Specifies a category of aircraft that can be used to partition aircraft according to their weight.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#AircraftWeightClass"></see></summary>
    let AircraftWeightClass =
        Namespaced_IRI.parse _namespace_name "AircraftWeightClass" |> NamespacedName

    /// <summary>
    /// A unit assembly in an aircraft mechanical subsystem, a ball bearing is positioned between a wheel and a fixed axle, in which the rotating part and the stationary part are separated by a ring of small solid metal balls that reduce friction.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#BallBearing"></see></summary>
    let BallBearing =
        Namespaced_IRI.parse _namespace_name "BallBearing" |> NamespacedName

    /// <summary>
    /// A primitive, non-decomposible component in an engineered system.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#UnitAssembly"></see></summary>
    let UnitAssembly =
        Namespaced_IRI.parse _namespace_name "UnitAssembly" |> NamespacedName

    /// <summary>
    /// Represents engineered systems as either decomposable or non-decomposible subsystems.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#EngineeredSystem"></see></summary>
    let EngineeredSystem =
        Namespaced_IRI.parse _namespace_name "EngineeredSystem" |> NamespacedName

    /// <summary>
    /// An aircraft subsystem responsible for generating and distributing electrical power.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#ElectricalPowerSystem"></see></summary>
    let ElectricalPowerSystem =
        Namespaced_IRI.parse _namespace_name "ElectricalPowerSystem" |> NamespacedName

    /// <summary>
    /// Represents different generic types of aircraft engines.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#EngineType"></see></summary>
    let EngineType = Namespaced_IRI.parse _namespace_name "EngineType" |> NamespacedName

    /// <summary>
    /// A navaid (navigational aid) is an engineered system on the ground that airplanes can detect based on their emission of radio signals that enable the aircraft to navigate. Modern examples include NDBs and VORs, which both transmit radio signals that aircraft can follow and home in on.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#NavigationAid"></see></summary>
    let NavigationAid =
        Namespaced_IRI.parse _namespace_name "NavigationAid" |> NamespacedName

    /// <summary>
    /// A numeric measure between 0 and 1 reflecting how certain the eqp:hasAircraftModel link is to be correct between the aircraft and the model. A value of one indicates 100% certainty. A lesser value is not to be taken as a percentage, but is a heuristic similarity value taken from the scoring of the TF/IDF similarity assessment performed between the FAA aircraft make/model in the FAA registration database and ICAO make/model names used in the ontology.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftModelCertainty"></see></summary>
    let aircraftModelCertainty =
        Namespaced_IRI.parse _namespace_name "aircraftModelCertainty" |> NamespacedName

    /// <summary>
    /// The name of the entity that registered the aircraft with the FAA.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftRegistrant"></see></summary>
    let aircraftRegistrant =
        Namespaced_IRI.parse _namespace_name "aircraftRegistrant" |> NamespacedName

    /// <summary>
    /// The manufacturer serial number of the aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftSerialNumber"></see></summary>
    let aircraftSerialNumber =
        Namespaced_IRI.parse _namespace_name "aircraftSerialNumber" |> NamespacedName

    /// <summary>
    /// The type designator code for this type of aircraft (e.g., B777).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftTypeDesignator"></see></summary>
    let aircraftTypeDesignator =
        Namespaced_IRI.parse _namespace_name "aircraftTypeDesignator" |> NamespacedName

    /// <summary>
    /// The upper bound of the aircraft weight category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightHighBound"></see></summary>
    let aircraftWeightHighBound =
        Namespaced_IRI.parse _namespace_name "aircraftWeightHighBound" |> NamespacedName

    /// <summary>
    /// The lower bound of the aircraft weight category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#aircraftWeightLowBound"></see></summary>
    let aircraftWeightLowBound =
        Namespaced_IRI.parse _namespace_name "aircraftWeightLowBound" |> NamespacedName

    /// <summary>
    /// The date that an operating certificate was issued to the aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#certificateIssueDate"></see></summary>
    let certificateIssueDate =
        Namespaced_IRI.parse _namespace_name "certificateIssueDate" |> NamespacedName

    /// <summary>
    /// CAST/ICAO Common Taxonomy Team (CICTT) identifier for this model as specified by the International Aircraft Categorisation And Identification Standard (IACIS).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#cicttNumber"></see></summary>
    let cicttNumber =
        Namespaced_IRI.parse _namespace_name "cicttNumber" |> NamespacedName

    /// <summary>
    /// Links an aircraft model to the airframe manufacturer that designed the model.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#designedBy"></see></summary>
    let designedBy = Namespaced_IRI.parse _namespace_name "designedBy" |> NamespacedName

    /// <summary>
    /// A text description of the engine type characteristics.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#engineTypeDescription"></see></summary>
    let engineTypeDescription =
        Namespaced_IRI.parse _namespace_name "engineTypeDescription" |> NamespacedName

    /// <summary>
    /// Links an aircraft type to the type of engine it uses.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftEngineType"></see></summary>
    let hasAircraftEngineType =
        Namespaced_IRI.parse _namespace_name "hasAircraftEngineType" |> NamespacedName

    /// <summary>
    /// Links a specific aircraft to its model.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftModel"></see></summary>
    let hasAircraftModel =
        Namespaced_IRI.parse _namespace_name "hasAircraftModel" |> NamespacedName

    /// <summary>
    /// Links an aircraft model to its wake category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWakeCategory"></see></summary>
    let hasAircraftWakeCategory =
        Namespaced_IRI.parse _namespace_name "hasAircraftWakeCategory" |> NamespacedName

    /// <summary>
    /// Links an aircraft model to its weight class.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#hasAircraftWeightClass"></see></summary>
    let hasAircraftWeightClass =
        Namespaced_IRI.parse _namespace_name "hasAircraftWeightClass" |> NamespacedName

    /// <summary>
    /// Connects an engineered system to its primitive components.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#hasComponent"></see></summary>
    let hasComponent =
        Namespaced_IRI.parse _namespace_name "hasComponent" |> NamespacedName

    /// <summary>
    /// Connects an engineered system to its subsystems.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#hasSubsystem"></see></summary>
    let hasSubsystem =
        Namespaced_IRI.parse _namespace_name "hasSubsystem" |> NamespacedName

    /// <summary>
    /// Links an aircraft model to its type, where the type represents a set of related models.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#isAircraftType"></see></summary>
    let isAircraftType =
        Namespaced_IRI.parse _namespace_name "isAircraftType" |> NamespacedName

    /// <summary>
    /// The year the system was manufactured.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#manufactureYear"></see></summary>
    let manufactureYear =
        Namespaced_IRI.parse _namespace_name "manufactureYear" |> NamespacedName

    /// <summary>
    /// The upper bound of the maximum takeoff weight for this category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightHighBound"></see></summary>
    let maxTakeoffWeightHighBound =
        Namespaced_IRI.parse _namespace_name "maxTakeoffWeightHighBound" |> NamespacedName

    /// <summary>
    /// The lower bound of the maximum takeoff weight for this category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#maxTakeoffWeightLowBound"></see></summary>
    let maxTakeoffWeightLowBound =
        Namespaced_IRI.parse _namespace_name "maxTakeoffWeightLowBound" |> NamespacedName

    /// <summary>
    /// The unique Mode S address of the transponder aboard the aircraft. Mode S equipment on aircraft are assigned a unique ICAO 24-bit address or (informally) Mode S hex code upon national registration and this address becomes a part of the aircraft's Certificate of Registration.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#modeSCode"></see></summary>
    let modeSCode = Namespaced_IRI.parse _namespace_name "modeSCode" |> NamespacedName
    /// <summary>
    /// The string identifier of the model for this system/subsystem/assembly.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#modelID"></see></summary>
    let modelID = Namespaced_IRI.parse _namespace_name "modelID" |> NamespacedName

    /// <summary>
    /// The number of engines specified for this aircraft model or found on this aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#numberOfEngines"></see></summary>
    let numberOfEngines =
        Namespaced_IRI.parse _namespace_name "numberOfEngines" |> NamespacedName

    /// <summary>
    /// The number of seats on this aircraft.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#numberOfSeats"></see></summary>
    let numberOfSeats =
        Namespaced_IRI.parse _namespace_name "numberOfSeats" |> NamespacedName

    /// <summary>
    /// The aircraft FAA registration number (the tail number, or the N-Number in the US).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#registrationNumber"></see></summary>
    let registrationNumber =
        Namespaced_IRI.parse _namespace_name "registrationNumber" |> NamespacedName

    /// <summary>
    /// The wake category identification character (A through F).
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#wakeCategoryID"></see></summary>
    let wakeCategoryID =
        Namespaced_IRI.parse _namespace_name "wakeCategoryID" |> NamespacedName

    /// <summary>
    /// The upper bound of the wingspan for this category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanHighBound"></see></summary>
    let wingSpanHighBound =
        Namespaced_IRI.parse _namespace_name "wingSpanHighBound" |> NamespacedName

    /// <summary>
    /// The lower bound of the wingspan for this category.
    /// <see href="https://data.nasa.gov/ontologies/atmonto/equipment#wingSpanLowBound"></see></summary>
    let wingSpanLowBound =
        Namespaced_IRI.parse _namespace_name "wingSpanLowBound" |> NamespacedName
