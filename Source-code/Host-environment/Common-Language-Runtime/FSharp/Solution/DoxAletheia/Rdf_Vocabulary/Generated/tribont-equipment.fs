namespace https.w3id.org.tribont.equipment.hash

open DoxAletheia

module tribont_equipment =
    let _namespace_name = "https://w3id.org/tribont/equipment#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An aggrupation of equipments with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#EquipmentClass"></see></summary>
    let EquipmentClass = _prefix "EquipmentClass"
    /// <summary>
    /// An object which is instrumental for reaching a particular purpose through its characteristic functioning process.
    /// <see href="https://w3id.org/tribont/equipment#Equipment"></see></summary>
    let Equipment = _prefix "Equipment"
    /// <summary>
    /// The measuring principle followed by an equipment.
    /// <see href="https://w3id.org/tribont/equipment#measuringPrinciple"></see></summary>
    let measuringPrinciple = _prefix "measuringPrinciple"
    /// <summary>
    /// The action or process of calibrating something to maintain accuracy, and repeatability in measurements, assuring reliable results.
    /// <see href="https://w3id.org/tribont/equipment#Calibration"></see></summary>
    let Calibration = _prefix "Calibration"
    /// <summary>
    /// The relation between a specific equipment and the calibrations performed on it.
    /// <see href="https://w3id.org/tribont/equipment#hasCalibration"></see></summary>
    let hasCalibration = _prefix "hasCalibration"
    /// <summary>
    /// The puspose of an equipment.
    /// <see href="https://w3id.org/tribont/equipment#purpose"></see></summary>
    let purpose = _prefix "purpose"
    /// <summary>
    ///  An equipment that measures the abrasion resistance of something.
    /// <see href="https://w3id.org/tribont/equipment#AbrasionTester"></see></summary>
    let AbrasionTester = _prefix "AbrasionTester"
    /// <summary>
    /// An equipment used to measure technical attributes or characteristics of something.
    /// <see href="https://w3id.org/tribont/equipment#MeasuringEquipment"></see></summary>
    let MeasuringEquipment = _prefix "MeasuringEquipment"
    /// <summary>
    /// The date until which a given action is valid and after which it is necessary to repeat it.
    /// <see href="https://w3id.org/tribont/equipment#validityDate"></see></summary>
    let validityDate = _prefix "validityDate"
    /// <summary>
    /// The date when a specific action has been performed.
    /// <see href="https://w3id.org/tribont/equipment#executionDate"></see></summary>
    let executionDate = _prefix "executionDate"
    /// <summary>
    /// A document that contains all the relevant information related to a specific calibration.
    /// <see href="https://w3id.org/tribont/equipment#CalibrationDocument"></see></summary>
    let CalibrationDocument = _prefix "CalibrationDocument"
    /// <summary>
    /// Information on how to to use and maintain something as for e.g. drawings, manuals, technical reports, etc.
    /// <see href="https://w3id.org/tribont/equipment#TechnicalDocument"></see></summary>
    let TechnicalDocument = _prefix "TechnicalDocument"
    /// <summary>
    /// Relationship between an equipment and the sample body it can hold
    /// <see href="https://w3id.org/tribont/equipment#holdsSampleBody"></see></summary>
    let holdsSampleBody = _prefix "holdsSampleBody"
    /// <summary>
    /// A document approved by a recognized body that provides common to by fullfiled by an equipment.
    /// <see href="https://w3id.org/tribont/equipment#EquipmentStandard"></see></summary>
    let EquipmentStandard = _prefix "EquipmentStandard"
    /// <summary>
    /// An equipment that reproduces certain operation conditions for experimentation purposes.
    /// <see href="https://w3id.org/tribont/equipment#ExperimentalEquipment"></see></summary>
    let ExperimentalEquipment = _prefix "ExperimentalEquipment"
    /// <summary>
    /// An aggrupation of experimental equipments with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#ExperimentalEquipmentClass"></see></summary>
    let ExperimentalEquipmentClass = _prefix "ExperimentalEquipmentClass"
    /// <summary>
    /// An equipment that measures the hardness of a material,
    /// <see href="https://w3id.org/tribont/equipment#HardnessTester"></see></summary>
    let HardnessTester = _prefix "HardnessTester"
    /// <summary>
    /// An aggrupation of hardness testers with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#HardnessTesterClass"></see></summary>
    let HardnessTesterClass = _prefix "HardnessTesterClass"
    /// <summary>
    /// An aggrupation of measuring equipment with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#MeasuringEquipmentClass"></see></summary>
    let MeasuringEquipmentClass = _prefix "MeasuringEquipmentClass"
    /// <summary>
    /// A document providing all the relevant information of the technical characteristics of an equipment, and describes how and when to use and mantain it.
    /// <see href="https://w3id.org/tribont/equipment#MachineryBook"></see></summary>
    let MachineryBook = _prefix "MachineryBook"
    /// <summary>
    /// A document provided by the manufacturer that includes a summary of technical characteristics, and describes how and when to use something.
    /// <see href="https://w3id.org/tribont/equipment#ManufacturerDataSheet"></see></summary>
    let ManufacturerDataSheet = _prefix "ManufacturerDataSheet"
    /// <summary>
    /// An equipment used to assess surfaces by magnifying images with visible light.
    /// <see href="https://w3id.org/tribont/equipment#OpticalMicroscope"></see></summary>
    let OpticalMicroscope = _prefix "OpticalMicroscope"
    /// <summary>
    /// An equipment used to measure precisely surface profiles.
    /// <see href="https://w3id.org/tribont/equipment#OpticalProfilometer"></see></summary>
    let OpticalProfilometer = _prefix "OpticalProfilometer"
    /// <summary>
    /// An equipment used to measure the weigth of somebody or something.
    /// <see href="https://w3id.org/tribont/equipment#Scale"></see></summary>
    let Scale = _prefix "Scale"
    /// <summary>
    /// An equipment used to assess the materials surfaces by producing images of a sample.
    /// <see href="https://w3id.org/tribont/equipment#ScanningElectronMicroscope"></see></summary>
    let ScanningElectronMicroscope = _prefix "ScanningElectronMicroscope"
    /// <summary>
    /// An equipment used to assess the coating adhesion.
    /// <see href="https://w3id.org/tribont/equipment#ScratchTester"></see></summary>
    let ScratchTester = _prefix "ScratchTester"
    /// <summary>
    /// An equipment used to measure tribological properties (e.g. friction coefficients, wear, etc.) by simulating the interaction of between two surfaces in contact under specific operation conditions.
    /// <see href="https://w3id.org/tribont/equipment#Tribometer"></see></summary>
    let Tribometer = _prefix "Tribometer"
    /// <summary>
    /// Relationship between an equipment and the moving sample  body it can hold
    /// <see href="https://w3id.org/tribont/equipment#holdsMovingSampleBody"></see></summary>
    let holdsMovingSampleBody = _prefix "holdsMovingSampleBody"
    /// <summary>
    /// Relationship between an equipment and the static sample  body it can hold
    /// <see href="https://w3id.org/tribont/equipment#holdsStaticSampleBody"></see></summary>
    let holdsStaticSampleBody = _prefix "holdsStaticSampleBody"
    /// <summary>
    /// An aggrupation of tribometers with a set of common atributes of characteristics.
    /// <see href="https://w3id.org/tribont/equipment#TribometerClass"></see></summary>
    let TribometerClass = _prefix "TribometerClass"
    /// <summary>
    /// Relationship between a movig sample body and the equipment that hold it.
    /// <see href="https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy"></see></summary>
    let isHeldMovingSampleBodyBy = _prefix "isHeldMovingSampleBodyBy"
    /// <summary>
    /// Relationship between a sample body and the equipment that hold it.
    /// <see href="https://w3id.org/tribont/equipment#isHeldSampleBodyBy"></see></summary>
    let isHeldSampleBodyBy = _prefix "isHeldSampleBodyBy"
    /// <summary>
    /// Relationship between astatic  sample body and the equipment that hold it.
    /// <see href="https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy"></see></summary>
    let isHeldStaticSampleBodyBy = _prefix "isHeldStaticSampleBodyBy"
