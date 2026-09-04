#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``tribont-equipment`` =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/tribont/equipment#" "tribont-equipment"

    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : AbrasionTester^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment :  An equipment that measures the abrasion resistance of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#AbrasionTester">tribont-equipment:AbrasionTester</a>
    /// </summary>
    let AbrasionTester = _prefixId.prefix "AbrasionTester"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Calibration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : The action or process of calibrating something to maintain accuracy, and repeatability in measurements, assuring reliable results.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#Calibration">tribont-equipment:Calibration</a>
    /// </summary>
    let Calibration = _prefixId.prefix "Calibration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : CalibrationDocument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : A document that contains all the relevant information related to a specific calibration.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#CalibrationDocument">tribont-equipment:CalibrationDocument</a>
    /// </summary>
    let CalibrationDocument = _prefixId.prefix "CalibrationDocument"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An object which is instrumental for reaching a particular purpose through its characteristic functioning process.^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#Equipment">tribont-equipment:Equipment</a>
    /// </summary>
    let Equipment = _prefixId.prefix "Equipment"
    /// <summary>
    ///   <para>rdfs:comment : An aggrupation of equipments with a set of common atributes of characteristics.^^xsd:string</para>
    ///   <para>rdfs:label : EquipmentClass^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#EquipmentClass">tribont-equipment:EquipmentClass</a>
    /// </summary>
    let EquipmentClass = _prefixId.prefix "EquipmentClass"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : EquipmentStandard^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : A document approved by a recognized body that provides common to by fullfiled by an equipment.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#EquipmentStandard">tribont-equipment:EquipmentStandard</a>
    /// </summary>
    let EquipmentStandard = _prefixId.prefix "EquipmentStandard"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ExperimentalEquipment^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment that reproduces certain operation conditions for experimentation purposes.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#ExperimentalEquipment">tribont-equipment:ExperimentalEquipment</a>
    /// </summary>
    let ExperimentalEquipment = _prefixId.prefix "ExperimentalEquipment"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ExperimentalEquipmentClass^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An aggrupation of experimental equipments with a set of common atributes of characteristics.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#ExperimentalEquipmentClass">tribont-equipment:ExperimentalEquipmentClass</a>
    /// </summary>
    let ExperimentalEquipmentClass = _prefixId.prefix "ExperimentalEquipmentClass"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessTester^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment that measures the hardness of a material, ^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#HardnessTester">tribont-equipment:HardnessTester</a>
    /// </summary>
    let HardnessTester = _prefixId.prefix "HardnessTester"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : HardnessTesterClass^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An aggrupation of hardness testers with a set of common atributes of characteristics.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#HardnessTesterClass">tribont-equipment:HardnessTesterClass</a>
    /// </summary>
    let HardnessTesterClass = _prefixId.prefix "HardnessTesterClass"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MachineryBook^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : A document providing all the relevant information of the technical characteristics of an equipment, and describes how and when to use and mantain it. ^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#MachineryBook">tribont-equipment:MachineryBook</a>
    /// </summary>
    let MachineryBook = _prefixId.prefix "MachineryBook"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ManufacturerDataSheet^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : A document provided by the manufacturer that includes a summary of technical characteristics, and describes how and when to use something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#ManufacturerDataSheet">tribont-equipment:ManufacturerDataSheet</a>
    /// </summary>
    let ManufacturerDataSheet = _prefixId.prefix "ManufacturerDataSheet"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MeasuringEquipment^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment used to measure technical attributes or characteristics of something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#MeasuringEquipment">tribont-equipment:MeasuringEquipment</a>
    /// </summary>
    let MeasuringEquipment = _prefixId.prefix "MeasuringEquipment"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : MeasuringEquipmentClass^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An aggrupation of measuring equipment with a set of common atributes of characteristics.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#MeasuringEquipmentClass">tribont-equipment:MeasuringEquipmentClass</a>
    /// </summary>
    let MeasuringEquipmentClass = _prefixId.prefix "MeasuringEquipmentClass"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OpticalMicroscope^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment used to assess surfaces by magnifying images with visible light.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#OpticalMicroscope">tribont-equipment:OpticalMicroscope</a>
    /// </summary>
    let OpticalMicroscope = _prefixId.prefix "OpticalMicroscope"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : OpticalProfilometer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment used to measure precisely surface profiles.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#OpticalProfilometer">tribont-equipment:OpticalProfilometer</a>
    /// </summary>
    let OpticalProfilometer = _prefixId.prefix "OpticalProfilometer"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment used to measure the weigth of somebody or something.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#Scale">tribont-equipment:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ScanningElectronMicroscope^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment used to assess the materials surfaces by producing images of a sample.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#ScanningElectronMicroscope">tribont-equipment:ScanningElectronMicroscope</a>
    /// </summary>
    let ScanningElectronMicroscope = _prefixId.prefix "ScanningElectronMicroscope"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : ScratchTester^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An equipment used to assess the coating adhesion.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#ScratchTester">tribont-equipment:ScratchTester</a>
    /// </summary>
    let ScratchTester = _prefixId.prefix "ScratchTester"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TechnicalDocument^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Information on how to to use and maintain something as for e.g. drawings, manuals, technical reports, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#TechnicalDocument">tribont-equipment:TechnicalDocument</a>
    /// </summary>
    let TechnicalDocument = _prefixId.prefix "TechnicalDocument"
    /// <summary>
    ///   <para>rdfs:comment : An equipment used to measure tribological properties (e.g. friction coefficients, wear, etc.) by simulating the interaction of between two surfaces in contact under specific operation conditions.^^xsd:string</para>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : Tribometer^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#Tribometer">tribont-equipment:Tribometer</a>
    /// </summary>
    let Tribometer = _prefixId.prefix "Tribometer"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : TribometerClass^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : An aggrupation of tribometers with a set of common atributes of characteristics.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#TribometerClass">tribont-equipment:TribometerClass</a>
    /// </summary>
    let TribometerClass = _prefixId.prefix "TribometerClass"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : executionDate^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : The date when a specific action has been performed.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#executionDate">tribont-equipment:executionDate</a>
    /// </summary>
    let executionDate = _prefixId.prefix "executionDate"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : hasCalibration^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : The relation between a specific equipment and the calibrations performed on it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#hasCalibration">tribont-equipment:hasCalibration</a>
    /// </summary>
    let hasCalibration = _prefixId.prefix "hasCalibration"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : holdsMovingSampleBody^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an equipment and the moving sample  body it can hold^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#holdsMovingSampleBody">tribont-equipment:holdsMovingSampleBody</a>
    /// </summary>
    let holdsMovingSampleBody = _prefixId.prefix "holdsMovingSampleBody"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : holdsSampleBody^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an equipment and the sample body it can hold^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#holdsSampleBody">tribont-equipment:holdsSampleBody</a>
    /// </summary>
    let holdsSampleBody = _prefixId.prefix "holdsSampleBody"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : holdsStaticSampleBody^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between an equipment and the static sample  body it can hold^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#holdsStaticSampleBody">tribont-equipment:holdsStaticSampleBody</a>
    /// </summary>
    let holdsStaticSampleBody = _prefixId.prefix "holdsStaticSampleBody"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isHeldMovingSampleBodyBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a movig sample body and the equipment that hold it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy">tribont-equipment:isHeldMovingSampleBodyBy</a>
    /// </summary>
    let isHeldMovingSampleBodyBy = _prefixId.prefix "isHeldMovingSampleBodyBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isHeldSampleBodyBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between a sample body and the equipment that hold it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#isHeldSampleBodyBy">tribont-equipment:isHeldSampleBodyBy</a>
    /// </summary>
    let isHeldSampleBodyBy = _prefixId.prefix "isHeldSampleBodyBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : isHeldStaticSampleBodyBy^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : Relationship between astatic  sample body and the equipment that hold it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy">tribont-equipment:isHeldStaticSampleBodyBy</a>
    /// </summary>
    let isHeldStaticSampleBodyBy = _prefixId.prefix "isHeldStaticSampleBodyBy"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : measuringPrinciple^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : The measuring principle followed by an equipment.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#measuringPrinciple">tribont-equipment:measuringPrinciple</a>
    /// </summary>
    let measuringPrinciple = _prefixId.prefix "measuringPrinciple"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : purpose^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : The puspose of an equipment.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#purpose">tribont-equipment:purpose</a>
    /// </summary>
    let purpose = _prefixId.prefix "purpose"
    /// <summary>
    ///   <para>vs:term_status : Testing^^xsd:string</para>
    ///   <para>rdfs:label : validityDate^^xsd:string</para>
    ///   <para>rdfs:isDefinedBy : https://w3id.org/tribont/equipment^^xsd:string</para>
    ///   <para>rdfs:comment : The date until which a given action is valid and after which it is necessary to repeat it.^^xsd:string</para>
    ///   <a href="https://w3id.org/tribont/equipment#validityDate">tribont-equipment:validityDate</a>
    /// </summary>
    let validityDate = _prefixId.prefix "validityDate"
