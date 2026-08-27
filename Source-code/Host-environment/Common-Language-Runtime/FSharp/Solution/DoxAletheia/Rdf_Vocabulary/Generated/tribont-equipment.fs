namespace https.w3id.org.tribont.equipment.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont_equipment =
    let _namespace_iri = Namespace_Iri tribont_equipment |> NamespaceIRI

    /// <summary>
    ///   <para>w3id:tribont/equipment#AbrasionTester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" An equipment that measures the abrasion resistance of something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbrasionTester"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#AbrasionTester">https://w3id.org/tribont/equipment#AbrasionTester</seealso>
    let AbrasionTester =
        Prefixed_Name(tribont_equipment, "AbrasionTester") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#Calibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The action or process of calibrating something to maintain accuracy, and repeatability in measurements, assuring reliable results."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Calibration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Calibration">https://w3id.org/tribont/equipment#Calibration</seealso>
    let Calibration = Prefixed_Name(tribont_equipment, "Calibration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#CalibrationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document that contains all the relevant information related to a specific calibration."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CalibrationDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#CalibrationDocument">https://w3id.org/tribont/equipment#CalibrationDocument</seealso>
    let CalibrationDocument =
        Prefixed_Name(tribont_equipment, "CalibrationDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An object which is instrumental for reaching a particular purpose through its characteristic functioning process."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Equipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Equipment">https://w3id.org/tribont/equipment#Equipment</seealso>
    let Equipment = Prefixed_Name(tribont_equipment, "Equipment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#EquipmentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An aggrupation of equipments with a set of common atributes of characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EquipmentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#EquipmentClass">https://w3id.org/tribont/equipment#EquipmentClass</seealso>
    let EquipmentClass =
        Prefixed_Name(tribont_equipment, "EquipmentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#EquipmentStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document approved by a recognized body that provides common to by fullfiled by an equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EquipmentStandard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#EquipmentStandard">https://w3id.org/tribont/equipment#EquipmentStandard</seealso>
    let EquipmentStandard =
        Prefixed_Name(tribont_equipment, "EquipmentStandard") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#ExperimentalEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment that reproduces certain operation conditions for experimentation purposes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalEquipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ExperimentalEquipment">https://w3id.org/tribont/equipment#ExperimentalEquipment</seealso>
    let ExperimentalEquipment =
        Prefixed_Name(tribont_equipment, "ExperimentalEquipment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#ExperimentalEquipmentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An aggrupation of experimental equipments with a set of common atributes of characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ExperimentalEquipmentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ExperimentalEquipmentClass">https://w3id.org/tribont/equipment#ExperimentalEquipmentClass</seealso>
    let ExperimentalEquipmentClass =
        Prefixed_Name(tribont_equipment, "ExperimentalEquipmentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#HardnessTester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment that measures the hardness of a material, "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardnessTester"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#HardnessTester">https://w3id.org/tribont/equipment#HardnessTester</seealso>
    let HardnessTester =
        Prefixed_Name(tribont_equipment, "HardnessTester") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#HardnessTesterClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An aggrupation of hardness testers with a set of common atributes of characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardnessTesterClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#HardnessTesterClass">https://w3id.org/tribont/equipment#HardnessTesterClass</seealso>
    let HardnessTesterClass =
        Prefixed_Name(tribont_equipment, "HardnessTesterClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#MachineryBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document providing all the relevant information of the technical characteristics of an equipment, and describes how and when to use and mantain it. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MachineryBook"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#MachineryBook">https://w3id.org/tribont/equipment#MachineryBook</seealso>
    let MachineryBook =
        Prefixed_Name(tribont_equipment, "MachineryBook") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#ManufacturerDataSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A document provided by the manufacturer that includes a summary of technical characteristics, and describes how and when to use something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ManufacturerDataSheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ManufacturerDataSheet">https://w3id.org/tribont/equipment#ManufacturerDataSheet</seealso>
    let ManufacturerDataSheet =
        Prefixed_Name(tribont_equipment, "ManufacturerDataSheet") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#MeasuringEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to measure technical attributes or characteristics of something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasuringEquipment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#MeasuringEquipment">https://w3id.org/tribont/equipment#MeasuringEquipment</seealso>
    let MeasuringEquipment =
        Prefixed_Name(tribont_equipment, "MeasuringEquipment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#MeasuringEquipmentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An aggrupation of measuring equipment with a set of common atributes of characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasuringEquipmentClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#MeasuringEquipmentClass">https://w3id.org/tribont/equipment#MeasuringEquipmentClass</seealso>
    let MeasuringEquipmentClass =
        Prefixed_Name(tribont_equipment, "MeasuringEquipmentClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#OpticalMicroscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to assess surfaces by magnifying images with visible light."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpticalMicroscope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#OpticalMicroscope">https://w3id.org/tribont/equipment#OpticalMicroscope</seealso>
    let OpticalMicroscope =
        Prefixed_Name(tribont_equipment, "OpticalMicroscope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#OpticalProfilometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to measure precisely surface profiles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpticalProfilometer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#OpticalProfilometer">https://w3id.org/tribont/equipment#OpticalProfilometer</seealso>
    let OpticalProfilometer =
        Prefixed_Name(tribont_equipment, "OpticalProfilometer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to measure the weigth of somebody or something."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Scale"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Scale">https://w3id.org/tribont/equipment#Scale</seealso>
    let Scale = Prefixed_Name(tribont_equipment, "Scale") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#ScanningElectronMicroscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to assess the materials surfaces by producing images of a sample."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScanningElectronMicroscope"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ScanningElectronMicroscope">https://w3id.org/tribont/equipment#ScanningElectronMicroscope</seealso>
    let ScanningElectronMicroscope =
        Prefixed_Name(tribont_equipment, "ScanningElectronMicroscope") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#ScratchTester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to assess the coating adhesion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScratchTester"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ScratchTester">https://w3id.org/tribont/equipment#ScratchTester</seealso>
    let ScratchTester =
        Prefixed_Name(tribont_equipment, "ScratchTester") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#TechnicalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Information on how to to use and maintain something as for e.g. drawings, manuals, technical reports, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TechnicalDocument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#TechnicalDocument">https://w3id.org/tribont/equipment#TechnicalDocument</seealso>
    let TechnicalDocument =
        Prefixed_Name(tribont_equipment, "TechnicalDocument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#Tribometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An equipment used to measure tribological properties (e.g. friction coefficients, wear, etc.) by simulating the interaction of between two surfaces in contact under specific operation conditions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tribometer"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Tribometer">https://w3id.org/tribont/equipment#Tribometer</seealso>
    let Tribometer = Prefixed_Name(tribont_equipment, "Tribometer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#TribometerClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An aggrupation of tribometers with a set of common atributes of characteristics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TribometerClass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#TribometerClass">https://w3id.org/tribont/equipment#TribometerClass</seealso>
    let TribometerClass =
        Prefixed_Name(tribont_equipment, "TribometerClass") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#executionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date when a specific action has been performed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"executionDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#executionDate">https://w3id.org/tribont/equipment#executionDate</seealso>
    let executionDate =
        Prefixed_Name(tribont_equipment, "executionDate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#hasCalibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The relation between a specific equipment and the calibrations performed on it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCalibration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#hasCalibration">https://w3id.org/tribont/equipment#hasCalibration</seealso>
    let hasCalibration =
        Prefixed_Name(tribont_equipment, "hasCalibration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#holdsMovingSampleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an equipment and the moving sample  body it can hold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"holdsMovingSampleBody"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#holdsMovingSampleBody">https://w3id.org/tribont/equipment#holdsMovingSampleBody</seealso>
    let holdsMovingSampleBody =
        Prefixed_Name(tribont_equipment, "holdsMovingSampleBody") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#holdsSampleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an equipment and the sample body it can hold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"holdsSampleBody"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#holdsSampleBody">https://w3id.org/tribont/equipment#holdsSampleBody</seealso>
    let holdsSampleBody =
        Prefixed_Name(tribont_equipment, "holdsSampleBody") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#holdsStaticSampleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between an equipment and the static sample  body it can hold"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"holdsStaticSampleBody"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#holdsStaticSampleBody">https://w3id.org/tribont/equipment#holdsStaticSampleBody</seealso>
    let holdsStaticSampleBody =
        Prefixed_Name(tribont_equipment, "holdsStaticSampleBody") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#isHeldMovingSampleBodyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a movig sample body and the equipment that hold it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isHeldMovingSampleBodyBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy">https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy</seealso>
    let isHeldMovingSampleBodyBy =
        Prefixed_Name(tribont_equipment, "isHeldMovingSampleBodyBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#isHeldSampleBodyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between a sample body and the equipment that hold it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isHeldSampleBodyBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#isHeldSampleBodyBy">https://w3id.org/tribont/equipment#isHeldSampleBodyBy</seealso>
    let isHeldSampleBodyBy =
        Prefixed_Name(tribont_equipment, "isHeldSampleBodyBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#isHeldStaticSampleBodyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relationship between astatic  sample body and the equipment that hold it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isHeldStaticSampleBodyBy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy">https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy</seealso>
    let isHeldStaticSampleBodyBy =
        Prefixed_Name(tribont_equipment, "isHeldStaticSampleBodyBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#measuringPrinciple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The measuring principle followed by an equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"measuringPrinciple"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#measuringPrinciple">https://w3id.org/tribont/equipment#measuringPrinciple</seealso>
    let measuringPrinciple =
        Prefixed_Name(tribont_equipment, "measuringPrinciple") |> PrefixedName

    /// <summary>
    ///   <para>w3id:tribont/equipment#purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The puspose of an equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"purpose"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#purpose">https://w3id.org/tribont/equipment#purpose</seealso>
    let purpose = Prefixed_Name(tribont_equipment, "purpose") |> PrefixedName
    /// <summary>
    ///   <para>w3id:tribont/equipment#validityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date until which a given action is valid and after which it is necessary to repeat it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"validityDate"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#validityDate">https://w3id.org/tribont/equipment#validityDate</seealso>
    let validityDate = Prefixed_Name(tribont_equipment, "validityDate") |> PrefixedName
