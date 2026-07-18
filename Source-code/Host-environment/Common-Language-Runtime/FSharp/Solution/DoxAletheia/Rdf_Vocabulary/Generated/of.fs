namespace http.owlrep.eu01.aws.af.cm.fridge.hash

open DoxAletheia.Rdf_Vocabulary

module of_ =
    let _namespace_name = "http://owlrep.eu01.aws.af.cm/fridge#"

    /// <summary>
    /// An energy observation is the main class of the measurment system. The observation connects to the sensing device, the measurement property, the observed appliance, the measurment result, and the time of measurement.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#EnergyObservation"></see></summary>
    let EnergyObservation =
        Namespaced_IRI.parse _namespace_name "EnergyObservation" |> NamespacedName

    /// <summary>
    /// Power is the observed measurment property
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#Power"></see></summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName

    /// <summary>
    /// An energy sensing device is sensing device for sensing energy consumption data
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#EnergySensingDevice"></see></summary>
    let EnergySensingDevice =
        Namespaced_IRI.parse _namespace_name "EnergySensingDevice" |> NamespacedName

    /// <summary>
    /// Information about the household of the open fridge user
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeHousehold"></see></summary>
    let OpenFridgeHousehold =
        Namespaced_IRI.parse _namespace_name "OpenFridgeHousehold" |> NamespacedName

    /// <summary>
    /// The main user of the system, which lives in a household with a energy consumption measuring system.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeUser"></see></summary>
    let OpenFridgeUser =
        Namespaced_IRI.parse _namespace_name "OpenFridgeUser" |> NamespacedName

    /// <summary>
    /// Open fridge user has an open fridge household
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#hasHousehold"></see></summary>
    let hasHousehold =
        Namespaced_IRI.parse _namespace_name "hasHousehold" |> NamespacedName

    /// <summary>
    /// The date when an product or service was bought or brought into service.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#dateBringIntoService"></see></summary>
    let dateBringIntoService =
        Namespaced_IRI.parse _namespace_name "dateBringIntoService" |> NamespacedName

    /// <summary>
    /// The appliance ID of an energy sensing device
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#energySensingDeviceID"></see></summary>
    let energySensingDeviceID =
        Namespaced_IRI.parse _namespace_name "energySensingDeviceID" |> NamespacedName

    /// <summary>
    /// Number of people that live in the household
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#numberOfPeople"></see></summary>
    let numberOfPeople =
        Namespaced_IRI.parse _namespace_name "numberOfPeople" |> NamespacedName

    /// <summary>
    /// Property of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationProperty"></see></summary>
    let observationProperty =
        Namespaced_IRI.parse _namespace_name "observationProperty" |> NamespacedName

    /// <summary>
    /// The average filling level of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyFillingLevel"></see></summary>
    let observationPropertyFillingLevel =
        Namespaced_IRI.parse _namespace_name "observationPropertyFillingLevel" |> NamespacedName

    /// <summary>
    /// The number of door openings of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyNumberOfOpening"></see></summary>
    let observationPropertyNumberOfOpening =
        Namespaced_IRI.parse _namespace_name "observationPropertyNumberOfOpening" |> NamespacedName

    /// <summary>
    /// The average temperature of the room where the refrigerator stands observed in a time period.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyRoomTemperature"></see></summary>
    let observationPropertyRoomTemperature =
        Namespaced_IRI.parse _namespace_name "observationPropertyRoomTemperature" |> NamespacedName

    /// <summary>
    /// The average temperature of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyTemperature"></see></summary>
    let observationPropertyTemperature =
        Namespaced_IRI.parse _namespace_name "observationPropertyTemperature" |> NamespacedName

    /// <summary>
    /// An open user owns a refrigerator.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#ownsFridge"></see></summary>
    let ownsFridge = Namespaced_IRI.parse _namespace_name "ownsFridge" |> NamespacedName
    /// <summary>
    /// Is the refrigerator located to the southwards or not.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#standSouth"></see></summary>
    let standSouth = Namespaced_IRI.parse _namespace_name "standSouth" |> NamespacedName
