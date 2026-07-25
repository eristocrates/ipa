namespace https.w3id.org.tribont.equipment.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tribont_equipment =
    let _namespace_iri = Namespace_Iri tribont_equipment |> NamespaceIRI

    /// <summary>
    ///   <para>tribont-equipment:EquipmentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggrupation of equipments with a set of common atributes of characteristics.</para>
    /// labels<para>EquipmentClass</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#EquipmentClass">https://w3id.org/tribont/equipment#EquipmentClass</seealso>
    let EquipmentClass =
        Prefixed_Name(tribont_equipment, "EquipmentClass") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:measuringPrinciple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The measuring principle followed by an equipment.</para>
    /// labels<para>measuringPrinciple</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#measuringPrinciple">https://w3id.org/tribont/equipment#measuringPrinciple</seealso>
    let measuringPrinciple =
        Prefixed_Name(tribont_equipment, "measuringPrinciple") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:Equipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An object which is instrumental for reaching a particular purpose through its characteristic functioning process.</para>
    /// labels<para>Equipment</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Equipment">https://w3id.org/tribont/equipment#Equipment</seealso>
    let Equipment = Prefixed_Name(tribont_equipment, "Equipment") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:ExperimentalEquipmentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggrupation of experimental equipments with a set of common atributes of characteristics.</para>
    /// labels<para>ExperimentalEquipmentClass</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ExperimentalEquipmentClass">https://w3id.org/tribont/equipment#ExperimentalEquipmentClass</seealso>
    let ExperimentalEquipmentClass =
        Prefixed_Name(tribont_equipment, "ExperimentalEquipmentClass") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:HardnessTesterClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggrupation of hardness testers with a set of common atributes of characteristics.</para>
    /// labels<para>HardnessTesterClass</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#HardnessTesterClass">https://w3id.org/tribont/equipment#HardnessTesterClass</seealso>
    let HardnessTesterClass =
        Prefixed_Name(tribont_equipment, "HardnessTesterClass") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:ManufacturerDataSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document provided by the manufacturer that includes a summary of technical characteristics, and describes how and when to use something.</para>
    /// labels<para>ManufacturerDataSheet</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ManufacturerDataSheet">https://w3id.org/tribont/equipment#ManufacturerDataSheet</seealso>
    let ManufacturerDataSheet =
        Prefixed_Name(tribont_equipment, "ManufacturerDataSheet") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:Calibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The action or process of calibrating something to maintain accuracy, and repeatability in measurements, assuring reliable results.</para>
    /// labels<para>Calibration</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Calibration">https://w3id.org/tribont/equipment#Calibration</seealso>
    let Calibration = Prefixed_Name(tribont_equipment, "Calibration") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:hasCalibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The relation between a specific equipment and the calibrations performed on it.</para>
    /// labels<para>hasCalibration</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#hasCalibration">https://w3id.org/tribont/equipment#hasCalibration</seealso>
    let hasCalibration =
        Prefixed_Name(tribont_equipment, "hasCalibration") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:isHeldMovingSampleBodyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a movig sample body and the equipment that hold it.</para>
    /// labels<para>isHeldMovingSampleBodyBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy">https://w3id.org/tribont/equipment#isHeldMovingSampleBodyBy</seealso>
    let isHeldMovingSampleBodyBy =
        Prefixed_Name(tribont_equipment, "isHeldMovingSampleBodyBy") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:isHeldSampleBodyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between a sample body and the equipment that hold it.</para>
    /// labels<para>isHeldSampleBodyBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#isHeldSampleBodyBy">https://w3id.org/tribont/equipment#isHeldSampleBodyBy</seealso>
    let isHeldSampleBodyBy =
        Prefixed_Name(tribont_equipment, "isHeldSampleBodyBy") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:isHeldStaticSampleBodyBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between astatic  sample body and the equipment that hold it.</para>
    /// labels<para>isHeldStaticSampleBodyBy</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy">https://w3id.org/tribont/equipment#isHeldStaticSampleBodyBy</seealso>
    let isHeldStaticSampleBodyBy =
        Prefixed_Name(tribont_equipment, "isHeldStaticSampleBodyBy") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:OpticalMicroscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to assess surfaces by magnifying images with visible light.</para>
    /// labels<para>OpticalMicroscope</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#OpticalMicroscope">https://w3id.org/tribont/equipment#OpticalMicroscope</seealso>
    let OpticalMicroscope =
        Prefixed_Name(tribont_equipment, "OpticalMicroscope") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:OpticalProfilometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to measure precisely surface profiles.</para>
    /// labels<para>OpticalProfilometer</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#OpticalProfilometer">https://w3id.org/tribont/equipment#OpticalProfilometer</seealso>
    let OpticalProfilometer =
        Prefixed_Name(tribont_equipment, "OpticalProfilometer") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:ScanningElectronMicroscope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to assess the materials surfaces by producing images of a sample.</para>
    /// labels<para>ScanningElectronMicroscope</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ScanningElectronMicroscope">https://w3id.org/tribont/equipment#ScanningElectronMicroscope</seealso>
    let ScanningElectronMicroscope =
        Prefixed_Name(tribont_equipment, "ScanningElectronMicroscope") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:Tribometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to measure tribological properties (e.g. friction coefficients, wear, etc.) by simulating the interaction of between two surfaces in contact under specific operation conditions.</para>
    /// labels<para>Tribometer</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Tribometer">https://w3id.org/tribont/equipment#Tribometer</seealso>
    let Tribometer = Prefixed_Name(tribont_equipment, "Tribometer") |> PrefixedName
    /// <summary>
    ///   <para>tribont-equipment:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to measure the weigth of somebody or something.</para>
    /// labels<para>Scale</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#Scale">https://w3id.org/tribont/equipment#Scale</seealso>
    let Scale = Prefixed_Name(tribont_equipment, "Scale") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:ScratchTester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to assess the coating adhesion.</para>
    /// labels<para>ScratchTester</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ScratchTester">https://w3id.org/tribont/equipment#ScratchTester</seealso>
    let ScratchTester =
        Prefixed_Name(tribont_equipment, "ScratchTester") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:holdsMovingSampleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an equipment and the moving sample  body it can hold</para>
    /// labels<para>holdsMovingSampleBody</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#holdsMovingSampleBody">https://w3id.org/tribont/equipment#holdsMovingSampleBody</seealso>
    let holdsMovingSampleBody =
        Prefixed_Name(tribont_equipment, "holdsMovingSampleBody") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:holdsStaticSampleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an equipment and the static sample  body it can hold</para>
    /// labels<para>holdsStaticSampleBody</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#holdsStaticSampleBody">https://w3id.org/tribont/equipment#holdsStaticSampleBody</seealso>
    let holdsStaticSampleBody =
        Prefixed_Name(tribont_equipment, "holdsStaticSampleBody") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:TribometerClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggrupation of tribometers with a set of common atributes of characteristics.</para>
    /// labels<para>TribometerClass</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#TribometerClass">https://w3id.org/tribont/equipment#TribometerClass</seealso>
    let TribometerClass =
        Prefixed_Name(tribont_equipment, "TribometerClass") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:purpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The puspose of an equipment.</para>
    /// labels<para>purpose</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#purpose">https://w3id.org/tribont/equipment#purpose</seealso>
    let purpose = Prefixed_Name(tribont_equipment, "purpose") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:AbrasionTester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> An equipment that measures the abrasion resistance of something.</para>
    /// labels<para>AbrasionTester</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#AbrasionTester">https://w3id.org/tribont/equipment#AbrasionTester</seealso>
    let AbrasionTester =
        Prefixed_Name(tribont_equipment, "AbrasionTester") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:MeasuringEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment used to measure technical attributes or characteristics of something.</para>
    /// labels<para>MeasuringEquipment</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#MeasuringEquipment">https://w3id.org/tribont/equipment#MeasuringEquipment</seealso>
    let MeasuringEquipment =
        Prefixed_Name(tribont_equipment, "MeasuringEquipment") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:validityDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date until which a given action is valid and after which it is necessary to repeat it.</para>
    /// labels<para>validityDate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#validityDate">https://w3id.org/tribont/equipment#validityDate</seealso>
    let validityDate = Prefixed_Name(tribont_equipment, "validityDate") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:CalibrationDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document that contains all the relevant information related to a specific calibration.</para>
    /// labels<para>CalibrationDocument</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#CalibrationDocument">https://w3id.org/tribont/equipment#CalibrationDocument</seealso>
    let CalibrationDocument =
        Prefixed_Name(tribont_equipment, "CalibrationDocument") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:executionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date when a specific action has been performed.</para>
    /// labels<para>executionDate</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#executionDate">https://w3id.org/tribont/equipment#executionDate</seealso>
    let executionDate =
        Prefixed_Name(tribont_equipment, "executionDate") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:TechnicalDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information on how to to use and maintain something as for e.g. drawings, manuals, technical reports, etc.</para>
    /// labels<para>TechnicalDocument</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#TechnicalDocument">https://w3id.org/tribont/equipment#TechnicalDocument</seealso>
    let TechnicalDocument =
        Prefixed_Name(tribont_equipment, "TechnicalDocument") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:holdsSampleBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relationship between an equipment and the sample body it can hold</para>
    /// labels<para>holdsSampleBody</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#holdsSampleBody">https://w3id.org/tribont/equipment#holdsSampleBody</seealso>
    let holdsSampleBody =
        Prefixed_Name(tribont_equipment, "holdsSampleBody") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:EquipmentStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document approved by a recognized body that provides common to by fullfiled by an equipment.</para>
    /// labels<para>EquipmentStandard</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#EquipmentStandard">https://w3id.org/tribont/equipment#EquipmentStandard</seealso>
    let EquipmentStandard =
        Prefixed_Name(tribont_equipment, "EquipmentStandard") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:ExperimentalEquipment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment that reproduces certain operation conditions for experimentation purposes.</para>
    /// labels<para>ExperimentalEquipment</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#ExperimentalEquipment">https://w3id.org/tribont/equipment#ExperimentalEquipment</seealso>
    let ExperimentalEquipment =
        Prefixed_Name(tribont_equipment, "ExperimentalEquipment") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:HardnessTester</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An equipment that measures the hardness of a material, </para>
    /// labels<para>HardnessTester</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#HardnessTester">https://w3id.org/tribont/equipment#HardnessTester</seealso>
    let HardnessTester =
        Prefixed_Name(tribont_equipment, "HardnessTester") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:MeasuringEquipmentClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An aggrupation of measuring equipment with a set of common atributes of characteristics.</para>
    /// labels<para>MeasuringEquipmentClass</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#MeasuringEquipmentClass">https://w3id.org/tribont/equipment#MeasuringEquipmentClass</seealso>
    let MeasuringEquipmentClass =
        Prefixed_Name(tribont_equipment, "MeasuringEquipmentClass") |> PrefixedName

    /// <summary>
    ///   <para>tribont-equipment:MachineryBook</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A document providing all the relevant information of the technical characteristics of an equipment, and describes how and when to use and mantain it. </para>
    /// labels<para>MachineryBook</para></remarks>
    /// <seealso href="https://w3id.org/tribont/equipment#MachineryBook">https://w3id.org/tribont/equipment#MachineryBook</seealso>
    let MachineryBook =
        Prefixed_Name(tribont_equipment, "MachineryBook") |> PrefixedName
