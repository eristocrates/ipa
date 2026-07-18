namespace https.w3id.org.tribont.equipment.hash

open DoxAletheia.Rdf_Vocabulary

module tribont_equipment =
    let _namespace_name = "https://w3id.org/tribont/equipment#"

    /// <summary>
    /// An aggrupation of equipments with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#EquipmentClass"></see></summary>
    let EquipmentClass =
        Namespaced_IRI.parse _namespace_name "EquipmentClass" |> NamespacedName

    /// <summary>
    /// An object which is instrumental for reaching a particular purpose through its characteristic functioning process.
    /// <see href="https://w3id.org/tribont/equipment#Equipment"></see></summary>
    let Equipment = Namespaced_IRI.parse _namespace_name "Equipment" |> NamespacedName

    /// <summary>
    /// The measuring principle followed by an equipment.
    /// <see href="https://w3id.org/tribont/equipment#measuringPrinciple"></see></summary>
    let measuringPrinciple =
        Namespaced_IRI.parse _namespace_name "measuringPrinciple" |> NamespacedName

    /// <summary>
    /// The action or process of calibrating something to maintain accuracy, and repeatability in measurements, assuring reliable results.
    /// <see href="https://w3id.org/tribont/equipment#Calibration"></see></summary>
    let Calibration =
        Namespaced_IRI.parse _namespace_name "Calibration" |> NamespacedName

    /// <summary>
    /// The relation between a specific equipment and the calibrations performed on it.
    /// <see href="https://w3id.org/tribont/equipment#hasCalibration"></see></summary>
    let hasCalibration =
        Namespaced_IRI.parse _namespace_name "hasCalibration" |> NamespacedName

    /// <summary>
    /// The puspose of an equipment.
    /// <see href="https://w3id.org/tribont/equipment#purpose"></see></summary>
    let purpose = Namespaced_IRI.parse _namespace_name "purpose" |> NamespacedName

    /// <summary>
    ///  An equipment that measures the abrasion resistance of something.
    /// <see href="https://w3id.org/tribont/equipment#AbrasionTester"></see></summary>
    let AbrasionTester =
        Namespaced_IRI.parse _namespace_name "AbrasionTester" |> NamespacedName

    /// <summary>
    /// An equipment used to measure technical attributes or characteristics of something.
    /// <see href="https://w3id.org/tribont/equipment#MeasuringEquipment"></see></summary>
    let MeasuringEquipment =
        Namespaced_IRI.parse _namespace_name "MeasuringEquipment" |> NamespacedName

    /// <summary>
    /// The date until which a given action is valid and after which it is necessary to repeat it.
    /// <see href="https://w3id.org/tribont/equipment#validityDate"></see></summary>
    let validityDate =
        Namespaced_IRI.parse _namespace_name "validityDate" |> NamespacedName

    /// <summary>
    /// The date when a specific action has been performed.
    /// <see href="https://w3id.org/tribont/equipment#executionDate"></see></summary>
    let executionDate =
        Namespaced_IRI.parse _namespace_name "executionDate" |> NamespacedName

    /// <summary>
    /// A document that contains all the relevant information related to a specific calibration.
    /// <see href="https://w3id.org/tribont/equipment#CalibrationDocument"></see></summary>
    let CalibrationDocument =
        Namespaced_IRI.parse _namespace_name "CalibrationDocument" |> NamespacedName

    /// <summary>
    /// Information on how to to use and maintain something as for e.g. drawings, manuals, technical reports, etc.
    /// <see href="https://w3id.org/tribont/equipment#TechnicalDocument"></see></summary>
    let TechnicalDocument =
        Namespaced_IRI.parse _namespace_name "TechnicalDocument" |> NamespacedName

    /// <summary>
    /// Relationship between an equipment and the sample body it can hold
    /// <see href="https://w3id.org/tribont/equipment#holdsSampleBody"></see></summary>
    let holdsSampleBody =
        Namespaced_IRI.parse _namespace_name "holdsSampleBody" |> NamespacedName

    /// <summary>
    /// A document approved by a recognized body that provides common to by fullfiled by an equipment.
    /// <see href="https://w3id.org/tribont/equipment#EquipmentStandard"></see></summary>
    let EquipmentStandard =
        Namespaced_IRI.parse _namespace_name "EquipmentStandard" |> NamespacedName

    /// <summary>
    /// An equipment that reproduces certain operation conditions for experimentation purposes.
    /// <see href="https://w3id.org/tribont/equipment#ExperimentalEquipment"></see></summary>
    let ExperimentalEquipment =
        Namespaced_IRI.parse _namespace_name "ExperimentalEquipment" |> NamespacedName

    /// <summary>
    /// An aggrupation of experimental equipments with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#ExperimentalEquipmentClass"></see></summary>
    let ExperimentalEquipmentClass =
        Namespaced_IRI.parse _namespace_name "ExperimentalEquipmentClass" |> NamespacedName

    /// <summary>
    /// An equipment that measures the hardness of a material,
    /// <see href="https://w3id.org/tribont/equipment#HardnessTester"></see></summary>
    let HardnessTester =
        Namespaced_IRI.parse _namespace_name "HardnessTester" |> NamespacedName

    /// <summary>
    /// An aggrupation of hardness testers with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#HardnessTesterClass"></see></summary>
    let HardnessTesterClass =
        Namespaced_IRI.parse _namespace_name "HardnessTesterClass" |> NamespacedName

    /// <summary>
    /// An aggrupation of measuring equipment with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#MeasuringEquipmentClass"></see></summary>
    let MeasuringEquipmentClass =
        Namespaced_IRI.parse _namespace_name "MeasuringEquipmentClass" |> NamespacedName

    /// <summary>
    /// A document providing all the relevant information of the technical characteristics of an equipment, and describes how and when to use and mantain it.
    /// <see href="https://w3id.org/tribont/equipment#MachineryBook"></see></summary>
    let MachineryBook =
        Namespaced_IRI.parse _namespace_name "MachineryBook" |> NamespacedName

    /// <summary>
    /// A document provided by the manufacturer that includes a summary of technical characteristics, and describes how and when to use something.
    /// <see href="https://w3id.org/tribont/equipment#ManufacturerDataSheet"></see></summary>
    let ManufacturerDataSheet =
        Namespaced_IRI.parse _namespace_name "ManufacturerDataSheet" |> NamespacedName

    /// <summary>
    /// An equipment used to assess surfaces by magnifying images with visible light.
    /// <see href="https://w3id.org/tribont/equipment#OpticalMicroscope"></see></summary>
    let OpticalMicroscope =
        Namespaced_IRI.parse _namespace_name "OpticalMicroscope" |> NamespacedName

    /// <summary>
    /// An equipment used to measure precisely surface profiles.
    /// <see href="https://w3id.org/tribont/equipment#OpticalProfilometer"></see></summary>
    let OpticalProfilometer =
        Namespaced_IRI.parse _namespace_name "OpticalProfilometer" |> NamespacedName

    /// <summary>
    /// An equipment used to measure the weigth of somebody or something.
    /// <see href="https://w3id.org/tribont/equipment#Scale"></see></summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName

    /// <summary>
    /// An equipment used to assess the materials surfaces by producing images of a sample.
    /// <see href="https://w3id.org/tribont/equipment#ScanningElectronMicroscope"></see></summary>
    let ScanningElectronMicroscope =
        Namespaced_IRI.parse _namespace_name "ScanningElectronMicroscope" |> NamespacedName

    /// <summary>
    /// An equipment used to assess the coating adhesion.
    /// <see href="https://w3id.org/tribont/equipment#ScratchTester"></see></summary>
    let ScratchTester =
        Namespaced_IRI.parse _namespace_name "ScratchTester" |> NamespacedName

    /// <summary>
    /// An equipment used to measure tribological properties (e.g. friction coefficients, wear, etc.) by simulating the interaction of between two surfaces in contact under specific operation conditions.
    /// <see href="https://w3id.org/tribont/equipment#Tribometer"></see></summary>
    let Tribometer = Namespaced_IRI.parse _namespace_name "Tribometer" |> NamespacedName

    /// <summary>
    /// Relationship between an equipment and the moving sample  body it can hold
    /// <see href="https://w3id.org/tribont/equipment#holdsMovingSampleBody"></see></summary>
    let holdsMovingSampleBody =
        Namespaced_IRI.parse _namespace_name "holdsMovingSampleBody" |> NamespacedName

    /// <summary>
    /// Relationship between an equipment and the static sample  body it can hold
    /// <see href="https://w3id.org/tribont/equipment#holdsStaticSampleBody"></see></summary>
    let holdsStaticSampleBody =
        Namespaced_IRI.parse _namespace_name "holdsStaticSampleBody" |> NamespacedName

    /// <summary>
    /// An aggrupation of tribometers with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#TribometerClass"></see></summary>
    let TribometerClass =
        Namespaced_IRI.parse _namespace_name "TribometerClass" |> NamespacedName

    /// <summary>
    /// Relationship between a movig sample body and the equipment that hold it.
    /// <see href="https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy"></see></summary>
    let isHeldMovingSampleBodyBy =
        Namespaced_IRI.parse _namespace_name "isHeldMovingSampleBodyBy" |> NamespacedName

    /// <summary>
    /// Relationship between a sample body and the equipment that hold it.
    /// <see href="https://w3id.org/tribont/equipment#isHeldSampleBodyBy"></see></summary>
    let isHeldSampleBodyBy =
        Namespaced_IRI.parse _namespace_name "isHeldSampleBodyBy" |> NamespacedName

    /// <summary>
    /// Relationship between astatic  sample body and the equipment that hold it.
    /// <see href="https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy"></see></summary>
    let isHeldStaticSampleBodyBy =
        Namespaced_IRI.parse _namespace_name "isHeldStaticSampleBodyBy" |> NamespacedName
