namespace https.w3id.org.emmo.domain.characterisation_methodology.chameo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module chameo =
    let _namespace_iri = Namespace_Iri chameo |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ACVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The resulting alternating current is plotted versus imposed DC potential. The obtained AC voltammogram is peak-shaped."</para>
    /// labels<para>"ACVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ACVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ACVoltammetry</seealso>
    let ACVoltammetry = Prefixed_Name(chameo, "ACVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AbrasiveStrippingVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"electrochemical method where traces of solid particles are abrasively transferred onto the surface of an electrode, followed by an electrochemical dissolution (anodic or cathodic dissolution) that is recorded as a current–voltage curve"</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AbrasiveStrippingVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AbrasiveStrippingVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AbrasiveStrippingVoltammetry</seealso>
    let AbrasiveStrippingVoltammetry =
        Prefixed_Name(chameo, "AbrasiveStrippingVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AccessConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AccessConditions"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AccessConditions">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AccessConditions</seealso>
    let AccessConditions = Prefixed_Name(chameo, "AccessConditions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AdsorptiveStrippingVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A peak-shaped adsorptive stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution."</para>
    ///   <para>"AdSV is usually employed for analysis of organic compounds or metal complexes with organic ligands. Stripping is done by means of an anodic or a cathodic voltammetric scan (linear or pulse), during which the adsorbed compound is oxidized or reduced."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AdsorptiveStrippingVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AdsorptiveStrippingVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AdsorptiveStrippingVoltammetry</seealso>
    let AdsorptiveStrippingVoltammetry =
        Prefixed_Name(chameo, "AdsorptiveStrippingVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AlphaSpectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AlphaSpectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AlphaSpectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AlphaSpectrometry</seealso>
    let AlphaSpectrometry = Prefixed_Name(chameo, "AlphaSpectrometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Amperometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In a non-stirred solution, a diffusion-limited current is usually measured, which is propor-tional to the concentration of an electroactive analyte."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The current is usually faradaic and the applied potential is usually constant."</para>
    ///   <para>"The integral of current with time is the electric charge, which may be related to the amount of substance reacted by Faraday’s laws of electrolysis."</para>
    ///   <para>"Amperometry can be distinguished from voltammetry by the parameter being controlled (electrode potential E) and the parameter being measured (electrode current I which is usually a function of time – see chronoamperometry)."</para>
    /// labels<para>"Amperometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Amperometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Amperometry</seealso>
    let Amperometry = Prefixed_Name(chameo, "Amperometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AnalyticalElectronMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AnalyticalElectronMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnalyticalElectronMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnalyticalElectronMicroscopy</seealso>
    let AnalyticalElectronMicroscopy =
        Prefixed_Name(chameo, "AnalyticalElectronMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AnodicStrippingVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A peak-shaped anodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A solid electrode, carbon paste or composite electrode, bismuth film electrode, mercury film electrode, or static mercury drop electrode may be used."</para>
    /// labels<para>"AnodicStrippingVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnodicStrippingVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnodicStrippingVoltammetry</seealso>
    let AnodicStrippingVoltammetry =
        Prefixed_Name(chameo, "AnodicStrippingVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AtomProbeTomography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AtomProbeTomography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomProbeTomography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomProbeTomography</seealso>
    let AtomProbeTomography =
        Prefixed_Name(chameo, "AtomProbeTomography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#AtomicForceMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"AtomicForceMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomicForceMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomicForceMicroscopy</seealso>
    let AtomicForceMicroscopy =
        Prefixed_Name(chameo, "AtomicForceMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CalibrationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CalibrationData"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationData">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationData</seealso>
    let CalibrationData = Prefixed_Name(chameo, "CalibrationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CalibrationDataPostProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CalibrationDataPostProcessing"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationDataPostProcessing">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationDataPostProcessing</seealso>
    let CalibrationDataPostProcessing =
        Prefixed_Name(chameo, "CalibrationDataPostProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CalibrationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CalibrationProcess"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationProcess">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationProcess</seealso>
    let CalibrationProcess = Prefixed_Name(chameo, "CalibrationProcess") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CalibrationTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CalibrationTask"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationTask">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationTask</seealso>
    let CalibrationTask = Prefixed_Name(chameo, "CalibrationTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Calorimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Calorimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Calorimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Calorimetry</seealso>
    let Calorimetry = Prefixed_Name(chameo, "Calorimetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CathodicStrippingVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A peak-shaped cathodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution."</para>
    /// labels<para>"CathodicStrippingVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CathodicStrippingVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CathodicStrippingVoltammetry</seealso>
    let CathodicStrippingVoltammetry =
        Prefixed_Name(chameo, "CathodicStrippingVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationData"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationData">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationData</seealso>
    let CharacterisationData =
        Prefixed_Name(chameo, "CharacterisationData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationDataValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationDataValidation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationDataValidation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationDataValidation</seealso>
    let CharacterisationDataValidation =
        Prefixed_Name(chameo, "CharacterisationDataValidation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationEnvironment"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironment">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironment</seealso>
    let CharacterisationEnvironment =
        Prefixed_Name(chameo, "CharacterisationEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironmentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationEnvironmentProperty"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironmentProperty">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironmentProperty</seealso>
    let CharacterisationEnvironmentProperty =
        Prefixed_Name(chameo, "CharacterisationEnvironmentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationExperiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationExperiment"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationExperiment">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationExperiment</seealso>
    let CharacterisationExperiment =
        Prefixed_Name(chameo, "CharacterisationExperiment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationHardware"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardware">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardware</seealso>
    let CharacterisationHardware =
        Prefixed_Name(chameo, "CharacterisationHardware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardwareManufacturer"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareManufacturer">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareManufacturer</seealso>
    let CharacterisationHardwareManufacturer =
        Prefixed_Name(chameo, "CharacterisationHardwareManufacturer") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardwareModel"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareModel">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareModel</seealso>
    let CharacterisationHardwareModel =
        Prefixed_Name(chameo, "CharacterisationHardwareModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationHardwareSpecification"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareSpecification">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareSpecification</seealso>
    let CharacterisationHardwareSpecification =
        Prefixed_Name(chameo, "CharacterisationHardwareSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationInstrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationInstrument">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationInstrument</seealso>
    let CharacterisationInstrument =
        Prefixed_Name(chameo, "CharacterisationInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationMeasurementProcess"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementProcess">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementProcess</seealso>
    let CharacterisationMeasurementProcess =
        Prefixed_Name(chameo, "CharacterisationMeasurementProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationMeasurementTask"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementTask">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementTask</seealso>
    let CharacterisationMeasurementTask =
        Prefixed_Name(chameo, "CharacterisationMeasurementTask") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationMethod"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMethod">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMethod</seealso>
    let CharacterisationMethod =
        Prefixed_Name(chameo, "CharacterisationMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationProcedure"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedure">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedure</seealso>
    let CharacterisationProcedure =
        Prefixed_Name(chameo, "CharacterisationProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationProcedureValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationProcedureValidation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedureValidation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedureValidation</seealso>
    let CharacterisationProcedureValidation =
        Prefixed_Name(chameo, "CharacterisationProcedureValidation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationProperty"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProperty">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProperty</seealso>
    let CharacterisationProperty =
        Prefixed_Name(chameo, "CharacterisationProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationProtocol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationProtocol"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProtocol">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProtocol</seealso>
    let CharacterisationProtocol =
        Prefixed_Name(chameo, "CharacterisationProtocol") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationSoftware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSoftware">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSoftware</seealso>
    let CharacterisationSoftware =
        Prefixed_Name(chameo, "CharacterisationSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationSystem"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSystem">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSystem</seealso>
    let CharacterisationSystem =
        Prefixed_Name(chameo, "CharacterisationSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationTask"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationTask">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationTask</seealso>
    let CharacterisationTask =
        Prefixed_Name(chameo, "CharacterisationTask") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisationWorkflow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisationWorkflow"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationWorkflow">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationWorkflow</seealso>
    let CharacterisationWorkflow =
        Prefixed_Name(chameo, "CharacterisationWorkflow") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CharacterisedSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CharacterisedSample"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisedSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisedSample</seealso>
    let CharacterisedSample =
        Prefixed_Name(chameo, "CharacterisedSample") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ChargeDistribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ChargeDistribution"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ChargeDistribution">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ChargeDistribution</seealso>
    let ChargeDistribution = Prefixed_Name(chameo, "ChargeDistribution") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Chromatography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chromatography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chromatography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chromatography</seealso>
    let Chromatography = Prefixed_Name(chameo, "Chromatography") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Chronoamperometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If the potential step is from a potential at which no current flows (i.e., at which the oxidation or reduction of the electrochemically active species does not take place) to one at which the current is limited by diffusion (see diffusion-limited current), the current obeys the Cottrell equation."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chronoamperometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronoamperometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronoamperometry</seealso>
    let Chronoamperometry = Prefixed_Name(chameo, "Chronoamperometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Chronocoulometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Chronocoulometry provides the same information that is provided by chronoamperometry, since it is based on the integration of the I-t curve. Nevertheless, chronocoulometry offers important experimental advantages, such as (i) the measured signal usually increases with time and hence the later parts of the transient can be detected more accurately, (ii) a better signal-to-noise ratio can be achieved, and (iii) other contributions to overall charge passed as a function of time can be discriminated from those due to the diffusion of electroactive substances."</para>
    /// labels<para>"Chronocoulometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronocoulometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronocoulometry</seealso>
    let Chronocoulometry = Prefixed_Name(chameo, "Chronocoulometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Chronopotentiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The change in applied current is usually a step, but cyclic current reversals or linearly increasing currents are also used."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Chronopotentiometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronopotentiometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronopotentiometry</seealso>
    let Chronopotentiometry =
        Prefixed_Name(chameo, "Chronopotentiometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CompressionTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CompressionTest"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CompressionTest">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CompressionTest</seealso>
    let CompressionTest = Prefixed_Name(chameo, "CompressionTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ConductometricTitration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The method is based on replacing an ionic species of the analyte with another species, cor- responding to the titrant or the product with significantly different conductance."</para>
    ///   <para>"The equivalence-point is obtained as the intersection of linear parts of the conductance G, versus titrant volume V, curve (see"</para>
    ///   <para>"The method can be used for deeply coloured or turbid solutions. Acid-base and precipita- tion reactions are most frequently used."</para>
    /// labels<para>"ConductometricTitration"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConductometricTitration">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConductometricTitration</seealso>
    let ConductometricTitration =
        Prefixed_Name(chameo, "ConductometricTitration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Conductometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The conductivity of a solution depends on the concentration and nature of ions present."</para>
    /// labels<para>"Conductometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Conductometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Conductometry</seealso>
    let Conductometry = Prefixed_Name(chameo, "Conductometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ConfocalMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ConfocalMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConfocalMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConfocalMicroscopy</seealso>
    let ConfocalMicroscopy = Prefixed_Name(chameo, "ConfocalMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CoulometricTitration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The main advantages are that titration is possible with less stable titrants, the standardi- zation of titrant is not necessary, the volume of the test solution is not changed, and the method is easily automated."</para>
    ///   <para>"Coulometric titrations are usually carried out in convective mass transfer mode using a large surface working electrode. The reference and auxiliary electrodes are located in sepa- rate compartments. A basic requirement is a 100 % current efficiency of titrant generation at the working electrode. End-point detection can be accomplished with potentiometry, amperometry, biamperometry, bipotentiometry, photometry, or by using a visual indicator."</para>
    /// labels<para>"CoulometricTitration"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CoulometricTitration">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CoulometricTitration</seealso>
    let CoulometricTitration =
        Prefixed_Name(chameo, "CoulometricTitration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Coulometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The coulometric experiment can be carried out at controlled (constant) potential (see direct coulometry at controlled potential) or controlled (constant) current (see direct coulometry at controlled current)."</para>
    ///   <para>"Coulometry used to measure the amount of substance is a primary reference measurement procedure [VIM 2.8] not requiring calibration with a standard for a quantity of the same kind (i.e. amount of substance)."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Coulometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Coulometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Coulometry</seealso>
    let Coulometry = Prefixed_Name(chameo, "Coulometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CreepTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CreepTest"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CreepTest">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CreepTest</seealso>
    let CreepTest = Prefixed_Name(chameo, "CreepTest") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CriticalAndSupercriticalChromatography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CriticalAndSupercriticalChromatography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CriticalAndSupercriticalChromatography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CriticalAndSupercriticalChromatography</seealso>
    let CriticalAndSupercriticalChromatography =
        Prefixed_Name(chameo, "CriticalAndSupercriticalChromatography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CyclicChronopotentiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CyclicChronopotentiometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicChronopotentiometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicChronopotentiometry</seealso>
    let CyclicChronopotentiometry =
        Prefixed_Name(chameo, "CyclicChronopotentiometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#CyclicVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The plot of current against potential is termed a cyclic voltammogram. Usually peak-shaped responses are obtained for scans in both directions."</para>
    ///   <para>"Cyclic voltammetry is frequently used for the investigation of mechanisms of electrochemi- cal/electrode reactions. The current-potential curve may be modelled to obtain reaction mechanisms and electrochemical parameters."</para>
    ///   <para>"The initial potential is usually the negative or positive limit of the cycle but can have any value between the two limits, as can the initial scan direction. The limits of the potential are known as the switching potentials."</para>
    ///   <para>"Normally the initial potential is chosen where no electrode reaction occurs and the switch- ing potential is greater (more positive for an oxidation or more negative for a reduction) than the peak potential of the analyte reaction."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CyclicVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicVoltammetry</seealso>
    let CyclicVoltammetry = Prefixed_Name(chameo, "CyclicVoltammetry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DCPolarography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usually the drop time is between 1 and 5 s and the pseudo-steady-state wave-shaped dependence on potential is called a polarogram. If the limiting current is controlled by dif- fusion, it is expressed by the Ilkovich equation."</para>
    ///   <para>"This is the oldest variant of polarographic techniques, introduced by Jaroslav Heyrovský (1890 – 1967)."</para>
    ///   <para>"If the whole scan is performed on a single growing drop, the technique should be called single drop scan voltammetry. The term polarography in this context is discouraged."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DCPolarography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DCPolarography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DCPolarography</seealso>
    let DCPolarography = Prefixed_Name(chameo, "DCPolarography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataAcquisitionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataAcquisitionRate"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAcquisitionRate">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAcquisitionRate</seealso>
    let DataAcquisitionRate =
        Prefixed_Name(chameo, "DataAcquisitionRate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataAnalysis"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAnalysis">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAnalysis</seealso>
    let DataAnalysis = Prefixed_Name(chameo, "DataAnalysis") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataFiltering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataFiltering"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataFiltering">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataFiltering</seealso>
    let DataFiltering = Prefixed_Name(chameo, "DataFiltering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataNormalisation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataNormalisation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataNormalisation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataNormalisation</seealso>
    let DataNormalisation = Prefixed_Name(chameo, "DataNormalisation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataPostProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataPostProcessing"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPostProcessing">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPostProcessing</seealso>
    let DataPostProcessing = Prefixed_Name(chameo, "DataPostProcessing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataPreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataPreparation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPreparation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPreparation</seealso>
    let DataPreparation = Prefixed_Name(chameo, "DataPreparation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataProcessingThroughCalibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataProcessingThroughCalibration"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataProcessingThroughCalibration">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataProcessingThroughCalibration</seealso>
    let DataProcessingThroughCalibration =
        Prefixed_Name(chameo, "DataProcessingThroughCalibration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DataQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DataQuality"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataQuality">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataQuality</seealso>
    let DataQuality = Prefixed_Name(chameo, "DataQuality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Detector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Detector"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Detector">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Detector</seealso>
    let Detector = Prefixed_Name(chameo, "Detector") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DielectricAndImpedanceSpectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DielectricAndImpedanceSpectroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DielectricAndImpedanceSpectroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DielectricAndImpedanceSpectroscopy</seealso>
    let DielectricAndImpedanceSpectroscopy =
        Prefixed_Name(chameo, "DielectricAndImpedanceSpectroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Dielectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The method is used to monitor the purity of dielectrics, for example to detect small amounts of moisture."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Dielectrometric titrations use dielectrometry for the end-point detection."</para>
    /// labels<para>"Dielectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dielectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dielectrometry</seealso>
    let Dielectrometry = Prefixed_Name(chameo, "Dielectrometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DifferentialLinearPulseVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DifferentialLinearPulseVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialLinearPulseVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialLinearPulseVoltammetry</seealso>
    let DifferentialLinearPulseVoltammetry =
        Prefixed_Name(chameo, "DifferentialLinearPulseVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DifferentialPulseVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated in the same way as in normal pulse voltammetry (NPV). Moreover, subtraction of the charging current sampled before the application of the pulse further decreases its negative influence. Due to the more enhanced signal (faradaic current) to noise (charging current) ratio, the limit of detection is lower than with NPV."</para>
    ///   <para>"Differential pulse polarography is differential pulse voltammetry in which a dropping mercury electrode is used as the working electrode. A pulse is applied before the mechani- cally enforced end of the drop and the current is sampled twice: just before the onset of the pulse and just before its end. The pulse width is usually 10 to 20 % of the drop life. The drop dislodgement is synchronized with current sampling, which is carried out as in DPV."</para>
    ///   <para>"The sensitivity of DPV depends on the reversibility of the electrode reaction of the analyte."</para>
    /// labels<para>"DifferentialPulseVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialPulseVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialPulseVoltammetry</seealso>
    let DifferentialPulseVoltammetry =
        Prefixed_Name(chameo, "DifferentialPulseVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DifferentialRefractiveIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DifferentialRefractiveIndex"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialRefractiveIndex">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialRefractiveIndex</seealso>
    let DifferentialRefractiveIndex =
        Prefixed_Name(chameo, "DifferentialRefractiveIndex") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DifferentialScanningCalorimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DifferentialScanningCalorimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialScanningCalorimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialScanningCalorimetry</seealso>
    let DifferentialScanningCalorimetry =
        Prefixed_Name(chameo, "DifferentialScanningCalorimetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DifferentialStaircasePulseVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DifferentialStaircasePulseVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialStaircasePulseVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialStaircasePulseVoltammetry</seealso>
    let DifferentialStaircasePulseVoltammetry =
        Prefixed_Name(chameo, "DifferentialStaircasePulseVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DifferentialThermalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DifferentialThermalAnalysis"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialThermalAnalysis">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialThermalAnalysis</seealso>
    let DifferentialThermalAnalysis =
        Prefixed_Name(chameo, "DifferentialThermalAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Dilatometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dilatometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dilatometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dilatometry</seealso>
    let Dilatometry = Prefixed_Name(chameo, "Dilatometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Direct coulometry at controlled current is usually carried out in convective mass transfer mode. The end-point of the electrolysis, at which the current is stopped, must be determined either from the inflection point in the E–t curve or by using visual or objective end-point indi- cation, similar to volumetric methods. The total electric charge is calculated as the product of the constant current and time of electrolysis or can be measured directly using a coulometer."</para>
    ///   <para>"The advantage of this method is that the electric charge consumed during the electrode reaction is directly proportional to the electrolysis time. Care must be taken to avoid the potential region where another electrode reaction may occur."</para>
    /// labels<para>"DirectCoulometryAtControlledCurrent"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledCurrent">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledCurrent</seealso>
    let DirectCoulometryAtControlledCurrent =
        Prefixed_Name(chameo, "DirectCoulometryAtControlledCurrent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Direct coulometry at controlled potential is usually carried out in convective mass trans- fer mode using a large surface working electrode. Reference and auxiliary electrodes are placed in separate compartments. The total electric charge is obtained by integration of the I–t curve or can be measured directly using a coulometer."</para>
    ///   <para>"In principle, the end point at which I = 0, i.e. when the concentration of species under study becomes zero, can be reached only at infinite time. However, in practice, the electrolysis is stopped when the current has decayed to a few percent of the initial value and the charge passed at infinite time is calculated from a plot of charge Q(t) against time t. For a simple system under diffusion control Qt= Q∞[1 − exp(−DAt/Vδ)], where Q∞ = limt→∞Q(t) is the total charge passed at infinite time, D is the diffusion coefficient of the electroactive species, A the electrode area, δ the diffusion layer thickness, and V the volume of the solution."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DirectCoulometryAtControlledPotential"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledPotential">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledPotential</seealso>
    let DirectCoulometryAtControlledPotential =
        Prefixed_Name(chameo, "DirectCoulometryAtControlledPotential") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DynamicLightScattering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DynamicLightScattering"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicLightScattering">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicLightScattering</seealso>
    let DynamicLightScattering =
        Prefixed_Name(chameo, "DynamicLightScattering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DynamicMechanicalAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DynamicMechanicalAnalysis"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalAnalysis">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalAnalysis</seealso>
    let DynamicMechanicalAnalysis =
        Prefixed_Name(chameo, "DynamicMechanicalAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#DynamicMechanicalSpectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"DynamicMechanicalSpectroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalSpectroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalSpectroscopy</seealso>
    let DynamicMechanicalSpectroscopy =
        Prefixed_Name(chameo, "DynamicMechanicalSpectroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Electrochemical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electrochemical"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrochemical">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrochemical</seealso>
    let Electrochemical = Prefixed_Name(chameo, "Electrochemical") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ElectrochemicalImpedanceSpectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The sinusoidal current response lags behind the sinusoidal voltage perturbation by a phase angle φ. Resistances (e.g. to charge transfer) give a response in phase with the voltage perturbation; capacitances (e.g. double layer) give a response 90° out of phase; combinations of resistances and capacitances give phase angles between 0 and 90°. Plots of the out of phase vs. the in phase component of the impedance for all the frequencies tested are called complex plane (or Nyquist) plots. Plots of the phase angle and the magnitude of the impedance vs. the logarithm of perturbation frequency are called Bode diagrams. Complex plane plots are the more commonly used for electrochemical sensors."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Impedimetric sensors are based on measurement of a concentration-dependent parameter taken from analysis of the respective electrochemical impedance spectra, or from the impedance magnitudes at a chosen fixed frequency."</para>
    /// labels<para>"ElectrochemicalImpedanceSpectroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalImpedanceSpectroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalImpedanceSpectroscopy</seealso>
    let ElectrochemicalImpedanceSpectroscopy =
        Prefixed_Name(chameo, "ElectrochemicalImpedanceSpectroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ElectrochemicalPiezoelectricMicrogravimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The change of mass is, for rigid deposits, linearly proportional to the change of the reso- nance frequency of the quartz crystal, according to the Sauerbrey equation. For non- rigid deposits, corrections must be made."</para>
    /// labels<para>"ElectrochemicalPiezoelectricMicrogravimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalPiezoelectricMicrogravimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalPiezoelectricMicrogravimetry</seealso>
    let ElectrochemicalPiezoelectricMicrogravimetry =
        Prefixed_Name(chameo, "ElectrochemicalPiezoelectricMicrogravimetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Electrogravimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electrogravimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrogravimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrogravimetry</seealso>
    let Electrogravimetry = Prefixed_Name(chameo, "Electrogravimetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ElectronBackscatterDiffraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElectronBackscatterDiffraction"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronBackscatterDiffraction">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronBackscatterDiffraction</seealso>
    let ElectronBackscatterDiffraction =
        Prefixed_Name(chameo, "ElectronBackscatterDiffraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ElectronProbeMicroanalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ElectronProbeMicroanalysis"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronProbeMicroanalysis">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronProbeMicroanalysis</seealso>
    let ElectronProbeMicroanalysis =
        Prefixed_Name(chameo, "ElectronProbeMicroanalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Ellipsometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ellipsometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ellipsometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ellipsometry</seealso>
    let Ellipsometry = Prefixed_Name(chameo, "Ellipsometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#EnvironmentalScanningElectronMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"EnvironmentalScanningElectronMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#EnvironmentalScanningElectronMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#EnvironmentalScanningElectronMicroscopy</seealso>
    let EnvironmentalScanningElectronMicroscopy =
        Prefixed_Name(chameo, "EnvironmentalScanningElectronMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Exafs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Exafs"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Exafs">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Exafs</seealso>
    let Exafs = Prefixed_Name(chameo, "Exafs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#FatigueTesting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FatigueTesting"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FatigueTesting">https://w3id.org/emmo/domain/characterisation-methodology/chameo#FatigueTesting</seealso>
    let FatigueTesting = Prefixed_Name(chameo, "FatigueTesting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#FibDic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FibDic"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FibDic">https://w3id.org/emmo/domain/characterisation-methodology/chameo#FibDic</seealso>
    let FibDic = Prefixed_Name(chameo, "FibDic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#FieldEmissionScanningElectronMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FieldEmissionScanningElectronMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FieldEmissionScanningElectronMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#FieldEmissionScanningElectronMicroscopy</seealso>
    let FieldEmissionScanningElectronMicroscopy =
        Prefixed_Name(chameo, "FieldEmissionScanningElectronMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Fractography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fractography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Fractography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Fractography</seealso>
    let Fractography = Prefixed_Name(chameo, "Fractography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#FreezingPointDepressionOsmometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"FreezingPointDepressionOsmometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FreezingPointDepressionOsmometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#FreezingPointDepressionOsmometry</seealso>
    let FreezingPointDepressionOsmometry =
        Prefixed_Name(chameo, "FreezingPointDepressionOsmometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#GITT</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GITT"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GITT">https://w3id.org/emmo/domain/characterisation-methodology/chameo#GITT</seealso>
    let GITT = Prefixed_Name(chameo, "GITT") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#GammaSpectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"GammaSpectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GammaSpectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#GammaSpectrometry</seealso>
    let GammaSpectrometry = Prefixed_Name(chameo, "GammaSpectrometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#HPPC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HPPC"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HPPC">https://w3id.org/emmo/domain/characterisation-methodology/chameo#HPPC</seealso>
    let HPPC = Prefixed_Name(chameo, "HPPC") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#HardnessTesting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"HardnessTesting"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HardnessTesting">https://w3id.org/emmo/domain/characterisation-methodology/chameo#HardnessTesting</seealso>
    let HardnessTesting = Prefixed_Name(chameo, "HardnessTesting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Hazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hazard"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Hazard">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Hazard</seealso>
    let Hazard = Prefixed_Name(chameo, "Hazard") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Holder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Holder"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Holder">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Holder</seealso>
    let Holder = Prefixed_Name(chameo, "Holder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#HydrodynamicVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The forced flow can be accomplished by movement either of the solution (solution stirring, or channel flow), or of the electrode (electrode rotation or vibration)."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A linear potential scan, at sufficiently slow scan rates so as to ensure a steady state response, is usually applied."</para>
    ///   <para>"Mass transport of a redox species enhanced by convection in this way results in a greater electric current. Convective mass transfer occurs up to the diffusion-limiting layer, within which the mass transfer is controlled by diffusion. Electroactive substance depletion outside the diffusion layer is annulled by convective mass transfer, which results in steady- state sigmoidal wave-shaped current-potential curves."</para>
    /// labels<para>"HydrodynamicVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HydrodynamicVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#HydrodynamicVoltammetry</seealso>
    let HydrodynamicVoltammetry =
        Prefixed_Name(chameo, "HydrodynamicVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ICI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ICI"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ICI">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ICI</seealso>
    let ICI = Prefixed_Name(chameo, "ICI") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Impedimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Impedimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Impedimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Impedimetry</seealso>
    let Impedimetry = Prefixed_Name(chameo, "Impedimetry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#InteractionVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InteractionVolume"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#InteractionVolume">https://w3id.org/emmo/domain/characterisation-methodology/chameo#InteractionVolume</seealso>
    let InteractionVolume = Prefixed_Name(chameo, "InteractionVolume") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#IntermediateSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IntermediateSample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IntermediateSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#IntermediateSample</seealso>
    let IntermediateSample = Prefixed_Name(chameo, "IntermediateSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#IonChromatography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IonChromatography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonChromatography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonChromatography</seealso>
    let IonChromatography = Prefixed_Name(chameo, "IonChromatography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#IonMobilitySpectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IonMobilitySpectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonMobilitySpectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonMobilitySpectrometry</seealso>
    let IonMobilitySpectrometry =
        Prefixed_Name(chameo, "IonMobilitySpectrometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#IsothermalMicrocalorimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IsothermalMicrocalorimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IsothermalMicrocalorimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#IsothermalMicrocalorimetry</seealso>
    let IsothermalMicrocalorimetry =
        Prefixed_Name(chameo, "IsothermalMicrocalorimetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Laboratory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Laboratory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Laboratory">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Laboratory</seealso>
    let Laboratory = Prefixed_Name(chameo, "Laboratory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#LevelOfAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LevelOfAutomation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfAutomation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfAutomation</seealso>
    let LevelOfAutomation = Prefixed_Name(chameo, "LevelOfAutomation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#LevelOfExpertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LevelOfExpertise"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfExpertise">https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfExpertise</seealso>
    let LevelOfExpertise = Prefixed_Name(chameo, "LevelOfExpertise") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#LightScattering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LightScattering"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LightScattering">https://w3id.org/emmo/domain/characterisation-methodology/chameo#LightScattering</seealso>
    let LightScattering = Prefixed_Name(chameo, "LightScattering") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#LinearChronopotentiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LinearChronopotentiometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearChronopotentiometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearChronopotentiometry</seealso>
    let LinearChronopotentiometry =
        Prefixed_Name(chameo, "LinearChronopotentiometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#LinearScanVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The scan is usually started at a potential where no electrode reaction occurs."</para>
    ///   <para>"The peak current is expressed by the Randles-Ševčík equation."</para>
    ///   <para>"LSV corresponds to the first half cycle of cyclic voltammetry."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"LinearScanVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearScanVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearScanVoltammetry</seealso>
    let LinearScanVoltammetry =
        Prefixed_Name(chameo, "LinearScanVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#MassSpectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MassSpectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MassSpectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#MassSpectrometry</seealso>
    let MassSpectrometry = Prefixed_Name(chameo, "MassSpectrometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#MeasurementDataPostProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementDataPostProcessing"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementDataPostProcessing">https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementDataPostProcessing</seealso>
    let MeasurementDataPostProcessing =
        Prefixed_Name(chameo, "MeasurementDataPostProcessing") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#MeasurementParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementParameter"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementParameter">https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementParameter</seealso>
    let MeasurementParameter =
        Prefixed_Name(chameo, "MeasurementParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#MeasurementSystemAdjustment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementSystemAdjustment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementSystemAdjustment">https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementSystemAdjustment</seealso>
    let MeasurementSystemAdjustment =
        Prefixed_Name(chameo, "MeasurementSystemAdjustment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#MeasurementTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementTime"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementTime">https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementTime</seealso>
    let MeasurementTime = Prefixed_Name(chameo, "MeasurementTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Mechanical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mechanical"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Mechanical">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Mechanical</seealso>
    let Mechanical = Prefixed_Name(chameo, "Mechanical") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#MembraneOsmometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MembraneOsmometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MembraneOsmometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#MembraneOsmometry</seealso>
    let MembraneOsmometry = Prefixed_Name(chameo, "MembraneOsmometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Microscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Microscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Microscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Microscopy</seealso>
    let Microscopy = Prefixed_Name(chameo, "Microscopy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Nanoindentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nanoindentation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nanoindentation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nanoindentation</seealso>
    let Nanoindentation = Prefixed_Name(chameo, "Nanoindentation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#NeutronSpinEchoSpectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NeutronSpinEchoSpectroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NeutronSpinEchoSpectroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#NeutronSpinEchoSpectroscopy</seealso>
    let NeutronSpinEchoSpectroscopy =
        Prefixed_Name(chameo, "NeutronSpinEchoSpectroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Nexafs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nexafs"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nexafs">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nexafs</seealso>
    let Nexafs = Prefixed_Name(chameo, "Nexafs") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#NormalPulseVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Normal pulse polarography is NPV in which a dropping mercury electrode is used as the working electrode. A pulse is applied just before the mechanically enforced end of the drop. The pulse width is usually 10 to 20 % of the drop time. The drop dislodgment is synchro- nized with current sampling, which is carried out just before the end of the pulse, as in NPV."</para>
    ///   <para>"The sensitivity of NPV is not affected by the reversibility of the electrode reaction of the analyte."</para>
    ///   <para>"The current is sampled just before the end of the pulse, when the charging current is greatly diminished. In this way, the ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detec- tion is lowered."</para>
    ///   <para>"The current is sampled at the end of the pulse and then plotted versus the potential of the pulse."</para>
    ///   <para>"Sigmoidal wave-shaped voltammograms are obtained."</para>
    /// labels<para>"NormalPulseVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NormalPulseVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#NormalPulseVoltammetry</seealso>
    let NormalPulseVoltammetry =
        Prefixed_Name(chameo, "NormalPulseVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#NuclearMagneticResonance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NuclearMagneticResonance"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NuclearMagneticResonance">https://w3id.org/emmo/domain/characterisation-methodology/chameo#NuclearMagneticResonance</seealso>
    let NuclearMagneticResonance =
        Prefixed_Name(chameo, "NuclearMagneticResonance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#OpenCircuitHold</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpenCircuitHold"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpenCircuitHold">https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpenCircuitHold</seealso>
    let OpenCircuitHold = Prefixed_Name(chameo, "OpenCircuitHold") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Operator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operator"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Operator">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Operator</seealso>
    let Operator = Prefixed_Name(chameo, "Operator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Optical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Optical"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Optical">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Optical</seealso>
    let Optical = Prefixed_Name(chameo, "Optical") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#OpticalMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"OpticalMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpticalMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpticalMicroscopy</seealso>
    let OpticalMicroscopy = Prefixed_Name(chameo, "OpticalMicroscopy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Osmometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Osmometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Osmometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Osmometry</seealso>
    let Osmometry = Prefixed_Name(chameo, "Osmometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PhotoluminescenceMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PhotoluminescenceMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhotoluminescenceMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhotoluminescenceMicroscopy</seealso>
    let PhotoluminescenceMicroscopy =
        Prefixed_Name(chameo, "PhotoluminescenceMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PhysicsOfInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PhysicsOfInteraction"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhysicsOfInteraction">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhysicsOfInteraction</seealso>
    let PhysicsOfInteraction =
        Prefixed_Name(chameo, "PhysicsOfInteraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PostProcessingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PostProcessingModel"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PostProcessingModel">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PostProcessingModel</seealso>
    let PostProcessingModel =
        Prefixed_Name(chameo, "PostProcessingModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PotentiometricStrippingAnalysis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"the stripping potentiogram shows staircase curves of potential as a function of time. Frequently, the first derivative is displayed (dE/dt=f(t)), as this produces peak-shaped signals. The time between transitions (peaks) is proportional to the concentration of analyte in the test solution"</para>
    ///   <para>"the time between changes in potential in step 2 is related to the concentration of analyte in the solution"</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"the accumulation is similar to that used in stripping voltammetry"</para>
    ///   <para>"historically for the analysis of metal ions, mercury ions were added to the test solution to form a mercury amalgam when reduced. Alternatively, an HMDE or MFE was used and the oxidizing agent added after amalgam formation. However, the toxicity of mercury and its compounds have all but precluded the present-day use of mercury"</para>
    /// labels<para>"PotentiometricStrippingAnalysis"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PotentiometricStrippingAnalysis">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PotentiometricStrippingAnalysis</seealso>
    let PotentiometricStrippingAnalysis =
        Prefixed_Name(chameo, "PotentiometricStrippingAnalysis") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Potentiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Method of electroanalytical chemistry based on measurement of an electrode potential."</para>
    ///   <para>"For measurements using ion-selective electrodes, the measurement is made under equi- librium conditions what means that the macroscopic electric current is zero and the con- centrations of all species are uniform throughout the solution. The indicator electrode is in direct contact with the analyte solution, whereas the reference electrode is usually separated from the analyte solution by a salt bridge. The potential difference between the indicator and reference electrodes is normally directly proportional to the logarithm of the activity (concentration) of the analyte in the solution (Nernst equation). See also ion selec- tive electrode."</para>
    /// labels<para>"Potentiometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Potentiometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Potentiometry</seealso>
    let Potentiometry = Prefixed_Name(chameo, "Potentiometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PreparedSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PreparedSample"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PreparedSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PreparedSample</seealso>
    let PreparedSample = Prefixed_Name(chameo, "PreparedSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PrimaryData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PrimaryData"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PrimaryData">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PrimaryData</seealso>
    let PrimaryData = Prefixed_Name(chameo, "PrimaryData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Probe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Probe"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Probe">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Probe</seealso>
    let Probe = Prefixed_Name(chameo, "Probe") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ProbeSampleInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ProbeSampleInteraction"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProbeSampleInteraction">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProbeSampleInteraction</seealso>
    let ProbeSampleInteraction =
        Prefixed_Name(chameo, "ProbeSampleInteraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ProcessingReproducibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ProcessingReproducibility"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProcessingReproducibility">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProcessingReproducibility</seealso>
    let ProcessingReproducibility =
        Prefixed_Name(chameo, "ProcessingReproducibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Profilometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Profilometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Profilometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Profilometry</seealso>
    let Profilometry = Prefixed_Name(chameo, "Profilometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#PulsedElectroacousticMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"PulsedElectroacousticMethod"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PulsedElectroacousticMethod">https://w3id.org/emmo/domain/characterisation-methodology/chameo#PulsedElectroacousticMethod</seealso>
    let PulsedElectroacousticMethod =
        Prefixed_Name(chameo, "PulsedElectroacousticMethod") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#RamanSpectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RamanSpectroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RamanSpectroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#RamanSpectroscopy</seealso>
    let RamanSpectroscopy = Prefixed_Name(chameo, "RamanSpectroscopy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#RawData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RawData"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawData">https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawData</seealso>
    let RawData = Prefixed_Name(chameo, "RawData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#RawSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"RawSample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawSample</seealso>
    let RawSample = Prefixed_Name(chameo, "RawSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ReferenceSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ReferenceSample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ReferenceSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ReferenceSample</seealso>
    let ReferenceSample = Prefixed_Name(chameo, "ReferenceSample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Sample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Sample</seealso>
    let Sample = Prefixed_Name(chameo, "Sample") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SampleInspection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SampleInspection"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspection">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspection</seealso>
    let SampleInspection = Prefixed_Name(chameo, "SampleInspection") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SampleInspectionInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SampleInspectionInstrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspectionInstrument">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspectionInstrument</seealso>
    let SampleInspectionInstrument =
        Prefixed_Name(chameo, "SampleInspectionInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SamplePreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SamplePreparation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparation</seealso>
    let SamplePreparation = Prefixed_Name(chameo, "SamplePreparation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SamplePreparationHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SamplePreparationHardware"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationHardware">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationHardware</seealso>
    let SamplePreparationHardware =
        Prefixed_Name(chameo, "SamplePreparationHardware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SamplePreparationInstrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SamplePreparationInstrument"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationInstrument">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationInstrument</seealso>
    let SamplePreparationInstrument =
        Prefixed_Name(chameo, "SamplePreparationInstrument") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SamplePreparationParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SamplePreparationParameter"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationParameter">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationParameter</seealso>
    let SamplePreparationParameter =
        Prefixed_Name(chameo, "SamplePreparationParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SampledDCPolarography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"In this way, the ratio of faradaic current to double layer charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detection is lowered."</para>
    /// labels<para>"SampledDCPolarography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampledDCPolarography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampledDCPolarography</seealso>
    let SampledDCPolarography =
        Prefixed_Name(chameo, "SampledDCPolarography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SamplingProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SamplingProcess"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplingProcess">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplingProcess</seealso>
    let SamplingProcess = Prefixed_Name(chameo, "SamplingProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ScanningAugerElectronMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScanningAugerElectronMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningAugerElectronMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningAugerElectronMicroscopy</seealso>
    let ScanningAugerElectronMicroscopy =
        Prefixed_Name(chameo, "ScanningAugerElectronMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ScanningElectronMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScanningElectronMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningElectronMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningElectronMicroscopy</seealso>
    let ScanningElectronMicroscopy =
        Prefixed_Name(chameo, "ScanningElectronMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ScanningKelvinProbe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScanningKelvinProbe"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningKelvinProbe">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningKelvinProbe</seealso>
    let ScanningKelvinProbe =
        Prefixed_Name(chameo, "ScanningKelvinProbe") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ScanningProbeMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScanningProbeMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningProbeMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningProbeMicroscopy</seealso>
    let ScanningProbeMicroscopy =
        Prefixed_Name(chameo, "ScanningProbeMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ScanningTunnelingMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScanningTunnelingMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningTunnelingMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningTunnelingMicroscopy</seealso>
    let ScanningTunnelingMicroscopy =
        Prefixed_Name(chameo, "ScanningTunnelingMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ScatteringAndDiffraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ScatteringAndDiffraction"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScatteringAndDiffraction">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScatteringAndDiffraction</seealso>
    let ScatteringAndDiffraction =
        Prefixed_Name(chameo, "ScatteringAndDiffraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SecondaryData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SecondaryData"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryData">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryData</seealso>
    let SecondaryData = Prefixed_Name(chameo, "SecondaryData") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SecondaryIonMassSpectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"SecondaryIonMassSpectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryIonMassSpectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryIonMassSpectrometry</seealso>
    let SecondaryIonMassSpectrometry =
        Prefixed_Name(chameo, "SecondaryIonMassSpectrometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#ShearOrTorsionTests</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ShearOrTorsionTest"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ShearOrTorsionTests">https://w3id.org/emmo/domain/characterisation-methodology/chameo#ShearOrTorsionTests</seealso>
    let ShearOrTorsionTests =
        Prefixed_Name(chameo, "ShearOrTorsionTests") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Signal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Signal"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Signal">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Signal</seealso>
    let Signal = Prefixed_Name(chameo, "Signal") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Spectrometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spectrometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectrometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectrometry</seealso>
    let Spectrometry = Prefixed_Name(chameo, "Spectrometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Spectroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Spectroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectroscopy</seealso>
    let Spectroscopy = Prefixed_Name(chameo, "Spectroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#SquareWaveVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The sensitivity of SWV depends on the reversibility of the electrode reaction of the analyte."</para>
    ///   <para>"Most instruments show plots of the current at the end of the forward-going pulse and of the backward-going pulse vs. the potential, as well as their difference. This can give valuable information on the kinetics of the electrode reaction and the electrode process."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The current is sampled just before the end of the forward- going pulse and of the backward-going pulse and the difference of the two sampled currents is plotted versus the applied potential of the potential or staircase ramp. The square-wave voltammogram is peak-shaped"</para>
    /// labels<para>"SquareWaveVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SquareWaveVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#SquareWaveVoltammetry</seealso>
    let SquareWaveVoltammetry =
        Prefixed_Name(chameo, "SquareWaveVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#StepChronopotentiometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"StepChronopotentiometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StepChronopotentiometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#StepChronopotentiometry</seealso>
    let StepChronopotentiometry =
        Prefixed_Name(chameo, "StepChronopotentiometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#StrippingVoltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Because the accumulation (pre-concentration) step can be prolonged, increasing the amount of material at the electrode, stripping voltammetry is able to measure very small concentrations of analyte."</para>
    ///   <para>"Types of stripping voltammetry refer to the kind of accumulation (e.g. adsorptive stripping voltammetry) or the polarity of the stripping electrochemistry (anodic, cathodic stripping voltammetry)."</para>
    ///   <para>"Anodic stripping voltammetry (ASV) was historically used to measure concentrations of metal ions in solution using cathodic accumulation with mercury to form an amalgam. Due to the toxicity of mercury and its compounds, inductively coupled plasma optical emission spectrometry and inductively coupled plasma mass spectrometry have frequently replaced ASV at mercury electrodes in the laboratory, often sacrificing the probing of speciation and lability in complex matrices. Mercury has now been replaced by non-toxic bismuth or anti- mony as films on a solid electrode support (such as glassy carbon) with equally good sensi- tivity and detection limits."</para>
    ///   <para>"Often the product of the electrochemical stripping is identical to the analyte before the accumulation."</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Stripping voltammetry is a calibrated method to establish the relation between amount accumulated in a given time and the concentration of the analyte in solution."</para>
    /// labels<para>"StrippingVoltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StrippingVoltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#StrippingVoltammetry</seealso>
    let StrippingVoltammetry =
        Prefixed_Name(chameo, "StrippingVoltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Synchrotron</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Synchrotron"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Synchrotron">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Synchrotron</seealso>
    let Synchrotron = Prefixed_Name(chameo, "Synchrotron") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#TensileTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TensileTest"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TensileTest">https://w3id.org/emmo/domain/characterisation-methodology/chameo#TensileTest</seealso>
    let TensileTest = Prefixed_Name(chameo, "TensileTest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Thermochemical</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermochemical"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermochemical">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermochemical</seealso>
    let Thermochemical = Prefixed_Name(chameo, "Thermochemical") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Thermogravimetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thermogravimetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermogravimetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermogravimetry</seealso>
    let Thermogravimetry = Prefixed_Name(chameo, "Thermogravimetry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Tomography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tomography"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Tomography">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Tomography</seealso>
    let Tomography = Prefixed_Name(chameo, "Tomography") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#TransmissionElectronMicroscopy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransmissionElectronMicroscopy"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TransmissionElectronMicroscopy">https://w3id.org/emmo/domain/characterisation-methodology/chameo#TransmissionElectronMicroscopy</seealso>
    let TransmissionElectronMicroscopy =
        Prefixed_Name(chameo, "TransmissionElectronMicroscopy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Ultrasonic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Ultrasonic"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ultrasonic">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ultrasonic</seealso>
    let Ultrasonic = Prefixed_Name(chameo, "Ultrasonic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#VaporPressureDepressionOsmometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VaporPressureDepressionOsmometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VaporPressureDepressionOsmometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#VaporPressureDepressionOsmometry</seealso>
    let VaporPressureDepressionOsmometry =
        Prefixed_Name(chameo, "VaporPressureDepressionOsmometry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Viscometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Viscometry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Viscometry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Viscometry</seealso>
    let Viscometry = Prefixed_Name(chameo, "Viscometry") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#Voltammetry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The current vs. potential (I-E) curve is called a voltammogram."</para>
    /// labels<para>"Voltammetry"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Voltammetry">https://w3id.org/emmo/domain/characterisation-methodology/chameo#Voltammetry</seealso>
    let Voltammetry = Prefixed_Name(chameo, "Voltammetry") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#VoltammetryAtARotatingDiskElectrode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"VoltammetryAtARotatingDiskElectrode"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VoltammetryAtARotatingDiskElectrode">https://w3id.org/emmo/domain/characterisation-methodology/chameo#VoltammetryAtARotatingDiskElectrode</seealso>
    let VoltammetryAtARotatingDiskElectrode =
        Prefixed_Name(chameo, "VoltammetryAtARotatingDiskElectrode") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#WearTest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WearTest"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#WearTest">https://w3id.org/emmo/domain/characterisation-methodology/chameo#WearTest</seealso>
    let WearTest = Prefixed_Name(chameo, "WearTest") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#XpsVariableKinetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XpsVariableKinetic"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XpsVariableKinetic">https://w3id.org/emmo/domain/characterisation-methodology/chameo#XpsVariableKinetic</seealso>
    let XpsVariableKinetic = Prefixed_Name(chameo, "XpsVariableKinetic") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#XrdGrazingIncidence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"XrdGrazingIncidence"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XrdGrazingIncidence">https://w3id.org/emmo/domain/characterisation-methodology/chameo#XrdGrazingIncidence</seealso>
    let XrdGrazingIncidence =
        Prefixed_Name(chameo, "XrdGrazingIncidence") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#characterisationProcedureHasSubProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"characterisationProcedureHasSubProcedure"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#characterisationProcedureHasSubProcedure">https://w3id.org/emmo/domain/characterisation-methodology/chameo#characterisationProcedureHasSubProcedure</seealso>
    let characterisationProcedureHasSubProcedure =
        Prefixed_Name(chameo, "characterisationProcedureHasSubProcedure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasAccessConditions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasAccessConditions"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasAccessConditions">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasAccessConditions</seealso>
    let hasAccessConditions =
        Prefixed_Name(chameo, "hasAccessConditions") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCharacterisationEnvironment"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironment">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironment</seealso>
    let hasCharacterisationEnvironment =
        Prefixed_Name(chameo, "hasCharacterisationEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironmentProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCharacterisationEnvironmentProperty"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironmentProperty">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironmentProperty</seealso>
    let hasCharacterisationEnvironmentProperty =
        Prefixed_Name(chameo, "hasCharacterisationEnvironmentProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasCharacterisationProcedureValidation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCharacterisationProcedureValidation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProcedureValidation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProcedureValidation</seealso>
    let hasCharacterisationProcedureValidation =
        Prefixed_Name(chameo, "hasCharacterisationProcedureValidation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasCharacterisationProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCharacterisationProperty"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProperty">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProperty</seealso>
    let hasCharacterisationProperty =
        Prefixed_Name(chameo, "hasCharacterisationProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasCharacterisationSoftware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasCharacterisationSoftware"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationSoftware">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationSoftware</seealso>
    let hasCharacterisationSoftware =
        Prefixed_Name(chameo, "hasCharacterisationSoftware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasDataAcquisitionRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDataAcquisitionRate"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataAcquisitionRate">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataAcquisitionRate</seealso>
    let hasDataAcquisitionRate =
        Prefixed_Name(chameo, "hasDataAcquisitionRate") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasDataProcessingThroughCalibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDataProcessingThroughCalibration"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataProcessingThroughCalibration">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataProcessingThroughCalibration</seealso>
    let hasDataProcessingThroughCalibration =
        Prefixed_Name(chameo, "hasDataProcessingThroughCalibration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasDataQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDataQuality"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataQuality">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataQuality</seealso>
    let hasDataQuality = Prefixed_Name(chameo, "hasDataQuality") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasDataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasDataset"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataset">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataset</seealso>
    let hasDataset = Prefixed_Name(chameo, "hasDataset") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasHardwareSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasHardwareSpecification"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHardwareSpecification">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHardwareSpecification</seealso>
    let hasHardwareSpecification =
        Prefixed_Name(chameo, "hasHardwareSpecification") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasHazard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasHazard"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHazard">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHazard</seealso>
    let hasHazard = Prefixed_Name(chameo, "hasHazard") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasHolder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasHolder"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHolder">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHolder</seealso>
    let hasHolder = Prefixed_Name(chameo, "hasHolder") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasInteractionVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasInteractionVolume"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionVolume">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionVolume</seealso>
    let hasInteractionVolume =
        Prefixed_Name(chameo, "hasInteractionVolume") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasInteractionWithProbe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasInteractionWithProbe"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithProbe">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithProbe</seealso>
    let hasInteractionWithProbe =
        Prefixed_Name(chameo, "hasInteractionWithProbe") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasInteractionWithSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasInteractionWithSample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithSample</seealso>
    let hasInteractionWithSample =
        Prefixed_Name(chameo, "hasInteractionWithSample") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasLab</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasLab"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLab">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLab</seealso>
    let hasLab = Prefixed_Name(chameo, "hasLab") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasLevelOfAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasLevelOfAutomation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLevelOfAutomation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLevelOfAutomation</seealso>
    let hasLevelOfAutomation =
        Prefixed_Name(chameo, "hasLevelOfAutomation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasMeasurementDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMeasurementDetector"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementDetector">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementDetector</seealso>
    let hasMeasurementDetector =
        Prefixed_Name(chameo, "hasMeasurementDetector") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasMeasurementParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMeasurementParameter"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementParameter">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementParameter</seealso>
    let hasMeasurementParameter =
        Prefixed_Name(chameo, "hasMeasurementParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasMeasurementProbe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMeasurementProbe"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementProbe">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementProbe</seealso>
    let hasMeasurementProbe =
        Prefixed_Name(chameo, "hasMeasurementProbe") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasMeasurementSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMeasurementSample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementSample</seealso>
    let hasMeasurementSample =
        Prefixed_Name(chameo, "hasMeasurementSample") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasMeasurementTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasMeasurementTime"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementTime">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementTime</seealso>
    let hasMeasurementTime = Prefixed_Name(chameo, "hasMeasurementTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasOperator"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasOperator">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasOperator</seealso>
    let hasOperator = Prefixed_Name(chameo, "hasOperator") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasPeerReviewedArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPeerReviewedArticle"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPeerReviewedArticle">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPeerReviewedArticle</seealso>
    let hasPeerReviewedArticle =
        Prefixed_Name(chameo, "hasPeerReviewedArticle") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasPhysicsOfInteraction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPhysicsOfInteraction"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPhysicsOfInteraction">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPhysicsOfInteraction</seealso>
    let hasPhysicsOfInteraction =
        Prefixed_Name(chameo, "hasPhysicsOfInteraction") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasPostProcessingModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPostProcessingModel"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPostProcessingModel">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPostProcessingModel</seealso>
    let hasPostProcessingModel =
        Prefixed_Name(chameo, "hasPostProcessingModel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasProcessingReproducibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasProcessingReproducibility"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasProcessingReproducibility">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasProcessingReproducibility</seealso>
    let hasProcessingReproducibility =
        Prefixed_Name(chameo, "hasProcessingReproducibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasSampleBeforeSamplePreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSampleBeforeSamplePreparation"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampleBeforeSamplePreparation">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampleBeforeSamplePreparation</seealso>
    let hasSampleBeforeSamplePreparation =
        Prefixed_Name(chameo, "hasSampleBeforeSamplePreparation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasSamplePreparationHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSamplePreparationHardware"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationHardware">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationHardware</seealso>
    let hasSamplePreparationHardware =
        Prefixed_Name(chameo, "hasSamplePreparationHardware") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasSamplePreparationInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSamplePreparationInput"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationInput">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationInput</seealso>
    let hasSamplePreparationInput =
        Prefixed_Name(chameo, "hasSamplePreparationInput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasSamplePreparationOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSamplePreparationOutput"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationOutput">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationOutput</seealso>
    let hasSamplePreparationOutput =
        Prefixed_Name(chameo, "hasSamplePreparationOutput") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasSamplePreparationParameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSamplePreparationParameter"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationParameter">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationParameter</seealso>
    let hasSamplePreparationParameter =
        Prefixed_Name(chameo, "hasSamplePreparationParameter") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#hasSampledSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasSampledSample"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampledSample">https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampledSample</seealso>
    let hasSampledSample = Prefixed_Name(chameo, "hasSampledSample") |> PrefixedName

    /// <summary>
    ///   <para>w3id:emmo/domain/characterisation-methodology/chameo#requiresLevelOfExpertise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>""^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"requiresLevelOfExpertise"</para></remarks>
    /// <seealso href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#requiresLevelOfExpertise">https://w3id.org/emmo/domain/characterisation-methodology/chameo#requiresLevelOfExpertise</seealso>
    let requiresLevelOfExpertise =
        Prefixed_Name(chameo, "requiresLevelOfExpertise") |> PrefixedName
