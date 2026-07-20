namespace http.owlrep.eu01.aws.af.cm.fridge.hash

open DoxAletheia

module of_ =
    let _namespace_name = "http://owlrep.eu01.aws.af.cm/fridge#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An energy observation is the main class of the measurment system. The observation connects to the sensing device, the measurement property, the observed appliance, the measurment result, and the time of measurement.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#EnergyObservation"></see></summary>
    let EnergyObservation = _prefix "EnergyObservation"
    /// <summary>
    /// Power is the observed measurment property
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#Power"></see></summary>
    let Power = _prefix "Power"
    /// <summary>
    /// An energy sensing device is sensing device for sensing energy consumption data
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#EnergySensingDevice"></see></summary>
    let EnergySensingDevice = _prefix "EnergySensingDevice"
    /// <summary>
    /// Information about the household of the open fridge user
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeHousehold"></see></summary>
    let OpenFridgeHousehold = _prefix "OpenFridgeHousehold"
    /// <summary>
    /// The main user of the system, which lives in a household with a energy consumption measuring system.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#OpenFridgeUser"></see></summary>
    let OpenFridgeUser = _prefix "OpenFridgeUser"
    /// <summary>
    /// Open fridge user has an open fridge household
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#hasHousehold"></see></summary>
    let hasHousehold = _prefix "hasHousehold"
    /// <summary>
    /// The date when an product or service was bought or brought into service.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#dateBringIntoService"></see></summary>
    let dateBringIntoService = _prefix "dateBringIntoService"
    /// <summary>
    /// The appliance ID of an energy sensing device
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#energySensingDeviceID"></see></summary>
    let energySensingDeviceID = _prefix "energySensingDeviceID"
    /// <summary>
    /// Number of people that live in the household
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#numberOfPeople"></see></summary>
    let numberOfPeople = _prefix "numberOfPeople"
    /// <summary>
    /// Property of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationProperty"></see></summary>
    let observationProperty = _prefix "observationProperty"
    /// <summary>
    /// The average filling level of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyFillingLevel"></see></summary>
    let observationPropertyFillingLevel = _prefix "observationPropertyFillingLevel"

    /// <summary>
    /// The number of door openings of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyNumberOfOpening"></see></summary>
    let observationPropertyNumberOfOpening =
        _prefix "observationPropertyNumberOfOpening"

    /// <summary>
    /// The average temperature of the room where the refrigerator stands observed in a time period.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyRoomTemperature"></see></summary>
    let observationPropertyRoomTemperature =
        _prefix "observationPropertyRoomTemperature"

    /// <summary>
    /// The average temperature of a fridge in the time period of observation.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#observationPropertyTemperature"></see></summary>
    let observationPropertyTemperature = _prefix "observationPropertyTemperature"
    /// <summary>
    /// An open user owns a refrigerator.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#ownsFridge"></see></summary>
    let ownsFridge = _prefix "ownsFridge"
    /// <summary>
    /// Is the refrigerator located to the southwards or not.
    /// <see href="http://owlrep.eu01.aws.af.cm/fridge#standSouth"></see></summary>
    let standSouth = _prefix "standSouth"
