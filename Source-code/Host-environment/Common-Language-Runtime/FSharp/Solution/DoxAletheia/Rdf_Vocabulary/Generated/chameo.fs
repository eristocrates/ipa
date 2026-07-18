namespace https.w3id.org.emmo.domain.characterisation_methodology.chameo.hash

open DoxAletheia.Rdf_Vocabulary

module chameo =
    let _namespace_name =
        "https://w3id.org/emmo/domain/characterisation-methodology/chameo#"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicChronopotentiometry"></see>
    /// </summary>
    let CyclicChronopotentiometry =
        Namespaced_IRI.parse _namespace_name "CyclicChronopotentiometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CompressionTest"></see>
    /// </summary>
    let CompressionTest =
        Namespaced_IRI.parse _namespace_name "CompressionTest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CreepTest"></see>
    /// </summary>
    let CreepTest = Namespaced_IRI.parse _namespace_name "CreepTest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalAnalysis"></see>
    /// </summary>
    let DynamicMechanicalAnalysis =
        Namespaced_IRI.parse _namespace_name "DynamicMechanicalAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FatigueTesting"></see>
    /// </summary>
    let FatigueTesting =
        Namespaced_IRI.parse _namespace_name "FatigueTesting" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FibDic"></see>
    /// </summary>
    let FibDic = Namespaced_IRI.parse _namespace_name "FibDic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HardnessTesting"></see>
    /// </summary>
    let HardnessTesting =
        Namespaced_IRI.parse _namespace_name "HardnessTesting" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nanoindentation"></see>
    /// </summary>
    let Nanoindentation =
        Namespaced_IRI.parse _namespace_name "Nanoindentation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ShearOrTorsionTests"></see>
    /// </summary>
    let ShearOrTorsionTests =
        Namespaced_IRI.parse _namespace_name "ShearOrTorsionTests" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TensileTest"></see>
    /// </summary>
    let TensileTest =
        Namespaced_IRI.parse _namespace_name "TensileTest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#WearTest"></see>
    /// </summary>
    let WearTest = Namespaced_IRI.parse _namespace_name "WearTest" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StepChronopotentiometry"></see>
    /// </summary>
    let StepChronopotentiometry =
        Namespaced_IRI.parse _namespace_name "StepChronopotentiometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrogravimetry"></see>
    /// </summary>
    let Electrogravimetry =
        Namespaced_IRI.parse _namespace_name "Electrogravimetry" |> NamespacedName

    /// <summary>
    ///
    /// electrochemical method where traces of solid particles are abrasively transferred onto the surface of an electrode, followed by an electrochemical dissolution (anodic or cathodic dissolution) that is recorded as a current–voltage curve
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AbrasiveStrippingVoltammetry"></see></summary>
    let AbrasiveStrippingVoltammetry =
        Namespaced_IRI.parse _namespace_name "AbrasiveStrippingVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearChronopotentiometry"></see>
    /// </summary>
    let LinearChronopotentiometry =
        Namespaced_IRI.parse _namespace_name "LinearChronopotentiometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationProcess"></see>
    /// </summary>
    let CalibrationProcess =
        Namespaced_IRI.parse _namespace_name "CalibrationProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationDataValidation"></see>
    /// </summary>
    let CharacterisationDataValidation =
        Namespaced_IRI.parse _namespace_name "CharacterisationDataValidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementProcess"></see>
    /// </summary>
    let CharacterisationMeasurementProcess =
        Namespaced_IRI.parse _namespace_name "CharacterisationMeasurementProcess" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAnalysis"></see>
    /// </summary>
    let DataAnalysis =
        Namespaced_IRI.parse _namespace_name "DataAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPostProcessing"></see>
    /// </summary>
    let DataPostProcessing =
        Namespaced_IRI.parse _namespace_name "DataPostProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPreparation"></see>
    /// </summary>
    let DataPreparation =
        Namespaced_IRI.parse _namespace_name "DataPreparation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspection"></see>
    /// </summary>
    let SampleInspection =
        Namespaced_IRI.parse _namespace_name "SampleInspection" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparation"></see>
    /// </summary>
    let SamplePreparation =
        Namespaced_IRI.parse _namespace_name "SamplePreparation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplingProcess"></see>
    /// </summary>
    let SamplingProcess =
        Namespaced_IRI.parse _namespace_name "SamplingProcess" |> NamespacedName

    /// <summary>
    /// the stripping potentiogram shows staircase curves of potential as a function of time. Frequently, the first derivative is displayed (dE/dt=f(t)), as this produces peak-shaped signals. The time between transitions (peaks) is proportional to the concentration of analyte in the test solution
    ///
    /// historically for the analysis of metal ions, mercury ions were added to the test solution to form a mercury amalgam when reduced. Alternatively, an HMDE or MFE was used and the oxidizing agent added after amalgam formation. However, the toxicity of mercury and its compounds have all but precluded the present-day use of mercury
    /// the accumulation is similar to that used in stripping voltammetry
    /// the time between changes in potential in step 2 is related to the concentration of analyte in the solution
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PotentiometricStrippingAnalysis"></see></summary>
    let PotentiometricStrippingAnalysis =
        Namespaced_IRI.parse _namespace_name "PotentiometricStrippingAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialStaircasePulseVoltammetry"></see>
    /// </summary>
    let DifferentialStaircasePulseVoltammetry =
        Namespaced_IRI.parse _namespace_name "DifferentialStaircasePulseVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialLinearPulseVoltammetry"></see>
    /// </summary>
    let DifferentialLinearPulseVoltammetry =
        Namespaced_IRI.parse _namespace_name "DifferentialLinearPulseVoltammetry" |> NamespacedName

    /// <summary>
    ///
    /// The resulting alternating current is plotted versus imposed DC potential. The obtained AC voltammogram is peak-shaped.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ACVoltammetry"></see></summary>
    let ACVoltammetry =
        Namespaced_IRI.parse _namespace_name "ACVoltammetry" |> NamespacedName

    /// <summary>
    ///
    /// The current vs. potential (I-E) curve is called a voltammogram.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Voltammetry"></see></summary>
    let Voltammetry =
        Namespaced_IRI.parse _namespace_name "Voltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AccessConditions"></see>
    /// </summary>
    let AccessConditions =
        Namespaced_IRI.parse _namespace_name "AccessConditions" |> NamespacedName

    /// <summary>
    /// AdSV is usually employed for analysis of organic compounds or metal complexes with organic ligands. Stripping is done by means of an anodic or a cathodic voltammetric scan (linear or pulse), during which the adsorbed compound is oxidized or reduced.
    ///
    /// A peak-shaped adsorptive stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AdsorptiveStrippingVoltammetry"></see></summary>
    let AdsorptiveStrippingVoltammetry =
        Namespaced_IRI.parse _namespace_name "AdsorptiveStrippingVoltammetry" |> NamespacedName

    /// <summary>
    /// Anodic stripping voltammetry (ASV) was historically used to measure concentrations of metal ions in solution using cathodic accumulation with mercury to form an amalgam. Due to the toxicity of mercury and its compounds, inductively coupled plasma optical emission spectrometry and inductively coupled plasma mass spectrometry have frequently replaced ASV at mercury electrodes in the laboratory, often sacrificing the probing of speciation and lability in complex matrices. Mercury has now been replaced by non-toxic bismuth or anti- mony as films on a solid electrode support (such as glassy carbon) with equally good sensi- tivity and detection limits.
    /// Types of stripping voltammetry refer to the kind of accumulation (e.g. adsorptive stripping voltammetry) or the polarity of the stripping electrochemistry (anodic, cathodic stripping voltammetry).
    /// Often the product of the electrochemical stripping is identical to the analyte before the accumulation.
    /// Because the accumulation (pre-concentration) step can be prolonged, increasing the amount of material at the electrode, stripping voltammetry is able to measure very small concentrations of analyte.
    ///
    /// Stripping voltammetry is a calibrated method to establish the relation between amount accumulated in a given time and the concentration of the analyte in solution.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StrippingVoltammetry"></see></summary>
    let StrippingVoltammetry =
        Namespaced_IRI.parse _namespace_name "StrippingVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AlphaSpectrometry"></see>
    /// </summary>
    let AlphaSpectrometry =
        Namespaced_IRI.parse _namespace_name "AlphaSpectrometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectrometry"></see>
    /// </summary>
    let Spectrometry =
        Namespaced_IRI.parse _namespace_name "Spectrometry" |> NamespacedName

    /// <summary>
    /// Amperometry can be distinguished from voltammetry by the parameter being controlled (electrode potential E) and the parameter being measured (electrode current I which is usually a function of time – see chronoamperometry).
    /// The current is usually faradaic and the applied potential is usually constant.
    ///
    /// The integral of current with time is the electric charge, which may be related to the amount of substance reacted by Faraday’s laws of electrolysis.
    /// In a non-stirred solution, a diffusion-limited current is usually measured, which is propor-tional to the concentration of an electroactive analyte.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Amperometry"></see></summary>
    let Amperometry =
        Namespaced_IRI.parse _namespace_name "Amperometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrochemical"></see>
    /// </summary>
    let Electrochemical =
        Namespaced_IRI.parse _namespace_name "Electrochemical" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnalyticalElectronMicroscopy"></see>
    /// </summary>
    let AnalyticalElectronMicroscopy =
        Namespaced_IRI.parse _namespace_name "AnalyticalElectronMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Microscopy"></see>
    /// </summary>
    let Microscopy = Namespaced_IRI.parse _namespace_name "Microscopy" |> NamespacedName

    /// <summary>
    ///
    /// A peak-shaped anodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.
    /// A solid electrode, carbon paste or composite electrode, bismuth film electrode, mercury film electrode, or static mercury drop electrode may be used.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnodicStrippingVoltammetry"></see></summary>
    let AnodicStrippingVoltammetry =
        Namespaced_IRI.parse _namespace_name "AnodicStrippingVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomProbeTomography"></see>
    /// </summary>
    let AtomProbeTomography =
        Namespaced_IRI.parse _namespace_name "AtomProbeTomography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Tomography"></see>
    /// </summary>
    let Tomography = Namespaced_IRI.parse _namespace_name "Tomography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomicForceMicroscopy"></see>
    /// </summary>
    let AtomicForceMicroscopy =
        Namespaced_IRI.parse _namespace_name "AtomicForceMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationData"></see>
    /// </summary>
    let CalibrationData =
        Namespaced_IRI.parse _namespace_name "CalibrationData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationData"></see>
    /// </summary>
    let CharacterisationData =
        Namespaced_IRI.parse _namespace_name "CharacterisationData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationDataPostProcessing"></see>
    /// </summary>
    let CalibrationDataPostProcessing =
        Namespaced_IRI.parse _namespace_name "CalibrationDataPostProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedure"></see>
    /// </summary>
    let CharacterisationProcedure =
        Namespaced_IRI.parse _namespace_name "CharacterisationProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationInstrument"></see>
    /// </summary>
    let CharacterisationInstrument =
        Namespaced_IRI.parse _namespace_name "CharacterisationInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationTask"></see>
    /// </summary>
    let CalibrationTask =
        Namespaced_IRI.parse _namespace_name "CalibrationTask" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationTask"></see>
    /// </summary>
    let CharacterisationTask =
        Namespaced_IRI.parse _namespace_name "CharacterisationTask" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Calorimetry"></see>
    /// </summary>
    let Calorimetry =
        Namespaced_IRI.parse _namespace_name "Calorimetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermochemical"></see>
    /// </summary>
    let Thermochemical =
        Namespaced_IRI.parse _namespace_name "Thermochemical" |> NamespacedName

    /// <summary>
    /// A peak-shaped cathodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.
    ///
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CathodicStrippingVoltammetry"></see></summary>
    let CathodicStrippingVoltammetry =
        Namespaced_IRI.parse _namespace_name "CathodicStrippingVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironment"></see>
    /// </summary>
    let CharacterisationEnvironment =
        Namespaced_IRI.parse _namespace_name "CharacterisationEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironmentProperty"></see>
    /// </summary>
    let CharacterisationEnvironmentProperty =
        Namespaced_IRI.parse _namespace_name "CharacterisationEnvironmentProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationExperiment"></see>
    /// </summary>
    let CharacterisationExperiment =
        Namespaced_IRI.parse _namespace_name "CharacterisationExperiment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardware"></see>
    /// </summary>
    let CharacterisationHardware =
        Namespaced_IRI.parse _namespace_name "CharacterisationHardware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareManufacturer"></see>
    /// </summary>
    let CharacterisationHardwareManufacturer =
        Namespaced_IRI.parse _namespace_name "CharacterisationHardwareManufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareSpecification"></see>
    /// </summary>
    let CharacterisationHardwareSpecification =
        Namespaced_IRI.parse _namespace_name "CharacterisationHardwareSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareModel"></see>
    /// </summary>
    let CharacterisationHardwareModel =
        Namespaced_IRI.parse _namespace_name "CharacterisationHardwareModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Probe"></see>
    /// </summary>
    let Probe = Namespaced_IRI.parse _namespace_name "Probe" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Detector"></see>
    /// </summary>
    let Detector = Namespaced_IRI.parse _namespace_name "Detector" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Sample"></see>
    /// </summary>
    let Sample = Namespaced_IRI.parse _namespace_name "Sample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementParameter"></see>
    /// </summary>
    let MeasurementParameter =
        Namespaced_IRI.parse _namespace_name "MeasurementParameter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementTask"></see>
    /// </summary>
    let CharacterisationMeasurementTask =
        Namespaced_IRI.parse _namespace_name "CharacterisationMeasurementTask" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMethod"></see>
    /// </summary>
    let CharacterisationMethod =
        Namespaced_IRI.parse _namespace_name "CharacterisationMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedureValidation"></see>
    /// </summary>
    let CharacterisationProcedureValidation =
        Namespaced_IRI.parse _namespace_name "CharacterisationProcedureValidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProperty"></see>
    /// </summary>
    let CharacterisationProperty =
        Namespaced_IRI.parse _namespace_name "CharacterisationProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryData"></see>
    /// </summary>
    let SecondaryData =
        Namespaced_IRI.parse _namespace_name "SecondaryData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProtocol"></see>
    /// </summary>
    let CharacterisationProtocol =
        Namespaced_IRI.parse _namespace_name "CharacterisationProtocol" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSoftware"></see>
    /// </summary>
    let CharacterisationSoftware =
        Namespaced_IRI.parse _namespace_name "CharacterisationSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSystem"></see>
    /// </summary>
    let CharacterisationSystem =
        Namespaced_IRI.parse _namespace_name "CharacterisationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationWorkflow"></see>
    /// </summary>
    let CharacterisationWorkflow =
        Namespaced_IRI.parse _namespace_name "CharacterisationWorkflow" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisedSample"></see>
    /// </summary>
    let CharacterisedSample =
        Namespaced_IRI.parse _namespace_name "CharacterisedSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ChargeDistribution"></see>
    /// </summary>
    let ChargeDistribution =
        Namespaced_IRI.parse _namespace_name "ChargeDistribution" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chromatography"></see>
    /// </summary>
    let Chromatography =
        Namespaced_IRI.parse _namespace_name "Chromatography" |> NamespacedName

    /// <summary>
    ///
    /// If the potential step is from a potential at which no current flows (i.e., at which the oxidation or reduction of the electrochemically active species does not take place) to one at which the current is limited by diffusion (see diffusion-limited current), the current obeys the Cottrell equation.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronoamperometry"></see></summary>
    let Chronoamperometry =
        Namespaced_IRI.parse _namespace_name "Chronoamperometry" |> NamespacedName

    /// <summary>
    ///
    /// Chronocoulometry provides the same information that is provided by chronoamperometry, since it is based on the integration of the I-t curve. Nevertheless, chronocoulometry offers important experimental advantages, such as (i) the measured signal usually increases with time and hence the later parts of the transient can be detected more accurately, (ii) a better signal-to-noise ratio can be achieved, and (iii) other contributions to overall charge passed as a function of time can be discriminated from those due to the diffusion of electroactive substances.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronocoulometry"></see></summary>
    let Chronocoulometry =
        Namespaced_IRI.parse _namespace_name "Chronocoulometry" |> NamespacedName

    /// <summary>
    /// The coulometric experiment can be carried out at controlled (constant) potential (see direct coulometry at controlled potential) or controlled (constant) current (see direct coulometry at controlled current).
    ///
    /// Coulometry used to measure the amount of substance is a primary reference measurement procedure [VIM 2.8] not requiring calibration with a standard for a quantity of the same kind (i.e. amount of substance).
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Coulometry"></see></summary>
    let Coulometry = Namespaced_IRI.parse _namespace_name "Coulometry" |> NamespacedName

    /// <summary>
    ///
    /// The change in applied current is usually a step, but cyclic current reversals or linearly increasing currents are also used.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronopotentiometry"></see></summary>
    let Chronopotentiometry =
        Namespaced_IRI.parse _namespace_name "Chronopotentiometry" |> NamespacedName

    /// <summary>
    ///
    /// For measurements using ion-selective electrodes, the measurement is made under equi- librium conditions what means that the macroscopic electric current is zero and the con- centrations of all species are uniform throughout the solution. The indicator electrode is in direct contact with the analyte solution, whereas the reference electrode is usually separated from the analyte solution by a salt bridge. The potential difference between the indicator and reference electrodes is normally directly proportional to the logarithm of the activity (concentration) of the analyte in the solution (Nernst equation). See also ion selec- tive electrode.
    /// Method of electroanalytical chemistry based on measurement of an electrode potential.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Potentiometry"></see></summary>
    let Potentiometry =
        Namespaced_IRI.parse _namespace_name "Potentiometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Mechanical"></see>
    /// </summary>
    let Mechanical = Namespaced_IRI.parse _namespace_name "Mechanical" |> NamespacedName

    /// <summary>
    /// The method can be used for deeply coloured or turbid solutions. Acid-base and precipita- tion reactions are most frequently used.
    /// The equivalence-point is obtained as the intersection of linear parts of the conductance G, versus titrant volume V, curve (see
    /// The method is based on replacing an ionic species of the analyte with another species, cor- responding to the titrant or the product with significantly different conductance.
    ///
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConductometricTitration"></see></summary>
    let ConductometricTitration =
        Namespaced_IRI.parse _namespace_name "ConductometricTitration" |> NamespacedName

    /// <summary>
    ///
    /// The conductivity of a solution depends on the concentration and nature of ions present.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Conductometry"></see></summary>
    let Conductometry =
        Namespaced_IRI.parse _namespace_name "Conductometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConfocalMicroscopy"></see>
    /// </summary>
    let ConfocalMicroscopy =
        Namespaced_IRI.parse _namespace_name "ConfocalMicroscopy" |> NamespacedName

    /// <summary>
    ///
    /// The main advantages are that titration is possible with less stable titrants, the standardi- zation of titrant is not necessary, the volume of the test solution is not changed, and the method is easily automated.
    /// Coulometric titrations are usually carried out in convective mass transfer mode using a large surface working electrode. The reference and auxiliary electrodes are located in sepa- rate compartments. A basic requirement is a 100 % current efficiency of titrant generation at the working electrode. End-point detection can be accomplished with potentiometry, amperometry, biamperometry, bipotentiometry, photometry, or by using a visual indicator.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CoulometricTitration"></see></summary>
    let CoulometricTitration =
        Namespaced_IRI.parse _namespace_name "CoulometricTitration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CriticalAndSupercriticalChromatography"></see>
    /// </summary>
    let CriticalAndSupercriticalChromatography =
        Namespaced_IRI.parse _namespace_name "CriticalAndSupercriticalChromatography" |> NamespacedName

    /// <summary>
    /// The plot of current against potential is termed a cyclic voltammogram. Usually peak-shaped responses are obtained for scans in both directions.
    ///
    /// Normally the initial potential is chosen where no electrode reaction occurs and the switch- ing potential is greater (more positive for an oxidation or more negative for a reduction) than the peak potential of the analyte reaction.
    /// The initial potential is usually the negative or positive limit of the cycle but can have any value between the two limits, as can the initial scan direction. The limits of the potential are known as the switching potentials.
    /// Cyclic voltammetry is frequently used for the investigation of mechanisms of electrochemi- cal/electrode reactions. The current-potential curve may be modelled to obtain reaction mechanisms and electrochemical parameters.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicVoltammetry"></see></summary>
    let CyclicVoltammetry =
        Namespaced_IRI.parse _namespace_name "CyclicVoltammetry" |> NamespacedName

    /// <summary>
    /// Usually the drop time is between 1 and 5 s and the pseudo-steady-state wave-shaped dependence on potential is called a polarogram. If the limiting current is controlled by dif- fusion, it is expressed by the Ilkovich equation.
    ///
    /// If the whole scan is performed on a single growing drop, the technique should be called single drop scan voltammetry. The term polarography in this context is discouraged.
    /// This is the oldest variant of polarographic techniques, introduced by Jaroslav Heyrovský (1890 – 1967).
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DCPolarography"></see></summary>
    let DCPolarography =
        Namespaced_IRI.parse _namespace_name "DCPolarography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAcquisitionRate"></see>
    /// </summary>
    let DataAcquisitionRate =
        Namespaced_IRI.parse _namespace_name "DataAcquisitionRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataFiltering"></see>
    /// </summary>
    let DataFiltering =
        Namespaced_IRI.parse _namespace_name "DataFiltering" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataNormalisation"></see>
    /// </summary>
    let DataNormalisation =
        Namespaced_IRI.parse _namespace_name "DataNormalisation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataProcessingThroughCalibration"></see>
    /// </summary>
    let DataProcessingThroughCalibration =
        Namespaced_IRI.parse _namespace_name "DataProcessingThroughCalibration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataQuality"></see>
    /// </summary>
    let DataQuality =
        Namespaced_IRI.parse _namespace_name "DataQuality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DielectricAndImpedanceSpectroscopy"></see>
    /// </summary>
    let DielectricAndImpedanceSpectroscopy =
        Namespaced_IRI.parse _namespace_name "DielectricAndImpedanceSpectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectroscopy"></see>
    /// </summary>
    let Spectroscopy =
        Namespaced_IRI.parse _namespace_name "Spectroscopy" |> NamespacedName

    /// <summary>
    ///
    /// The method is used to monitor the purity of dielectrics, for example to detect small amounts of moisture.
    /// Dielectrometric titrations use dielectrometry for the end-point detection.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dielectrometry"></see></summary>
    let Dielectrometry =
        Namespaced_IRI.parse _namespace_name "Dielectrometry" |> NamespacedName

    /// <summary>
    ///
    /// The ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated in the same way as in normal pulse voltammetry (NPV). Moreover, subtraction of the charging current sampled before the application of the pulse further decreases its negative influence. Due to the more enhanced signal (faradaic current) to noise (charging current) ratio, the limit of detection is lower than with NPV.
    /// Differential pulse polarography is differential pulse voltammetry in which a dropping mercury electrode is used as the working electrode. A pulse is applied before the mechani- cally enforced end of the drop and the current is sampled twice: just before the onset of the pulse and just before its end. The pulse width is usually 10 to 20 % of the drop life. The drop dislodgement is synchronized with current sampling, which is carried out as in DPV.
    /// The sensitivity of DPV depends on the reversibility of the electrode reaction of the analyte.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialPulseVoltammetry"></see></summary>
    let DifferentialPulseVoltammetry =
        Namespaced_IRI.parse _namespace_name "DifferentialPulseVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialRefractiveIndex"></see>
    /// </summary>
    let DifferentialRefractiveIndex =
        Namespaced_IRI.parse _namespace_name "DifferentialRefractiveIndex" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Optical"></see>
    /// </summary>
    let Optical = Namespaced_IRI.parse _namespace_name "Optical" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialScanningCalorimetry"></see>
    /// </summary>
    let DifferentialScanningCalorimetry =
        Namespaced_IRI.parse _namespace_name "DifferentialScanningCalorimetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialThermalAnalysis"></see>
    /// </summary>
    let DifferentialThermalAnalysis =
        Namespaced_IRI.parse _namespace_name "DifferentialThermalAnalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dilatometry"></see>
    /// </summary>
    let Dilatometry =
        Namespaced_IRI.parse _namespace_name "Dilatometry" |> NamespacedName

    /// <summary>
    ///
    /// The advantage of this method is that the electric charge consumed during the electrode reaction is directly proportional to the electrolysis time. Care must be taken to avoid the potential region where another electrode reaction may occur.
    /// Direct coulometry at controlled current is usually carried out in convective mass transfer mode. The end-point of the electrolysis, at which the current is stopped, must be determined either from the inflection point in the E–t curve or by using visual or objective end-point indi- cation, similar to volumetric methods. The total electric charge is calculated as the product of the constant current and time of electrolysis or can be measured directly using a coulometer.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledCurrent"></see></summary>
    let DirectCoulometryAtControlledCurrent =
        Namespaced_IRI.parse _namespace_name "DirectCoulometryAtControlledCurrent" |> NamespacedName

    /// <summary>
    ///
    /// In principle, the end point at which I = 0, i.e. when the concentration of species under study becomes zero, can be reached only at infinite time. However, in practice, the electrolysis is stopped when the current has decayed to a few percent of the initial value and the charge passed at infinite time is calculated from a plot of charge Q(t) against time t. For a simple system under diffusion control Qt= Q∞[1 − exp(−DAt/Vδ)], where Q∞ = limt→∞Q(t) is the total charge passed at infinite time, D is the diffusion coefficient of the electroactive species, A the electrode area, δ the diffusion layer thickness, and V the volume of the solution.
    /// Direct coulometry at controlled potential is usually carried out in convective mass trans- fer mode using a large surface working electrode. Reference and auxiliary electrodes are placed in separate compartments. The total electric charge is obtained by integration of the I–t curve or can be measured directly using a coulometer.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledPotential"></see></summary>
    let DirectCoulometryAtControlledPotential =
        Namespaced_IRI.parse _namespace_name "DirectCoulometryAtControlledPotential" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicLightScattering"></see>
    /// </summary>
    let DynamicLightScattering =
        Namespaced_IRI.parse _namespace_name "DynamicLightScattering" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalSpectroscopy"></see>
    /// </summary>
    let DynamicMechanicalSpectroscopy =
        Namespaced_IRI.parse _namespace_name "DynamicMechanicalSpectroscopy" |> NamespacedName

    /// <summary>
    /// The sinusoidal current response lags behind the sinusoidal voltage perturbation by a phase angle φ. Resistances (e.g. to charge transfer) give a response in phase with the voltage perturbation; capacitances (e.g. double layer) give a response 90° out of phase; combinations of resistances and capacitances give phase angles between 0 and 90°. Plots of the out of phase vs. the in phase component of the impedance for all the frequencies tested are called complex plane (or Nyquist) plots. Plots of the phase angle and the magnitude of the impedance vs. the logarithm of perturbation frequency are called Bode diagrams. Complex plane plots are the more commonly used for electrochemical sensors.
    /// Impedimetric sensors are based on measurement of a concentration-dependent parameter taken from analysis of the respective electrochemical impedance spectra, or from the impedance magnitudes at a chosen fixed frequency.
    ///
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalImpedanceSpectroscopy"></see></summary>
    let ElectrochemicalImpedanceSpectroscopy =
        Namespaced_IRI.parse _namespace_name "ElectrochemicalImpedanceSpectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Impedimetry"></see>
    /// </summary>
    let Impedimetry =
        Namespaced_IRI.parse _namespace_name "Impedimetry" |> NamespacedName

    /// <summary>
    ///
    /// The change of mass is, for rigid deposits, linearly proportional to the change of the reso- nance frequency of the quartz crystal, according to the Sauerbrey equation. For non- rigid deposits, corrections must be made.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalPiezoelectricMicrogravimetry"></see></summary>
    let ElectrochemicalPiezoelectricMicrogravimetry =
        Namespaced_IRI.parse _namespace_name "ElectrochemicalPiezoelectricMicrogravimetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronBackscatterDiffraction"></see>
    /// </summary>
    let ElectronBackscatterDiffraction =
        Namespaced_IRI.parse _namespace_name "ElectronBackscatterDiffraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScatteringAndDiffraction"></see>
    /// </summary>
    let ScatteringAndDiffraction =
        Namespaced_IRI.parse _namespace_name "ScatteringAndDiffraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningElectronMicroscopy"></see>
    /// </summary>
    let ScanningElectronMicroscopy =
        Namespaced_IRI.parse _namespace_name "ScanningElectronMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronProbeMicroanalysis"></see>
    /// </summary>
    let ElectronProbeMicroanalysis =
        Namespaced_IRI.parse _namespace_name "ElectronProbeMicroanalysis" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ellipsometry"></see>
    /// </summary>
    let Ellipsometry =
        Namespaced_IRI.parse _namespace_name "Ellipsometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#EnvironmentalScanningElectronMicroscopy"></see>
    /// </summary>
    let EnvironmentalScanningElectronMicroscopy =
        Namespaced_IRI.parse _namespace_name "EnvironmentalScanningElectronMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Exafs"></see>
    /// </summary>
    let Exafs = Namespaced_IRI.parse _namespace_name "Exafs" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FieldEmissionScanningElectronMicroscopy"></see>
    /// </summary>
    let FieldEmissionScanningElectronMicroscopy =
        Namespaced_IRI.parse _namespace_name "FieldEmissionScanningElectronMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Fractography"></see>
    /// </summary>
    let Fractography =
        Namespaced_IRI.parse _namespace_name "Fractography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FreezingPointDepressionOsmometry"></see>
    /// </summary>
    let FreezingPointDepressionOsmometry =
        Namespaced_IRI.parse _namespace_name "FreezingPointDepressionOsmometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Osmometry"></see>
    /// </summary>
    let Osmometry = Namespaced_IRI.parse _namespace_name "Osmometry" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GITT"></see>
    /// </summary>
    let GITT = Namespaced_IRI.parse _namespace_name "GITT" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GammaSpectrometry"></see>
    /// </summary>
    let GammaSpectrometry =
        Namespaced_IRI.parse _namespace_name "GammaSpectrometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HPPC"></see>
    /// </summary>
    let HPPC = Namespaced_IRI.parse _namespace_name "HPPC" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Hazard"></see>
    /// </summary>
    let Hazard = Namespaced_IRI.parse _namespace_name "Hazard" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Holder"></see>
    /// </summary>
    let Holder = Namespaced_IRI.parse _namespace_name "Holder" |> NamespacedName

    /// <summary>
    /// A linear potential scan, at sufficiently slow scan rates so as to ensure a steady state response, is usually applied.
    /// Mass transport of a redox species enhanced by convection in this way results in a greater electric current. Convective mass transfer occurs up to the diffusion-limiting layer, within which the mass transfer is controlled by diffusion. Electroactive substance depletion outside the diffusion layer is annulled by convective mass transfer, which results in steady- state sigmoidal wave-shaped current-potential curves.
    ///
    /// The forced flow can be accomplished by movement either of the solution (solution stirring, or channel flow), or of the electrode (electrode rotation or vibration).
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HydrodynamicVoltammetry"></see></summary>
    let HydrodynamicVoltammetry =
        Namespaced_IRI.parse _namespace_name "HydrodynamicVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ICI"></see>
    /// </summary>
    let ICI = Namespaced_IRI.parse _namespace_name "ICI" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#InteractionVolume"></see>
    /// </summary>
    let InteractionVolume =
        Namespaced_IRI.parse _namespace_name "InteractionVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IntermediateSample"></see>
    /// </summary>
    let IntermediateSample =
        Namespaced_IRI.parse _namespace_name "IntermediateSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonChromatography"></see>
    /// </summary>
    let IonChromatography =
        Namespaced_IRI.parse _namespace_name "IonChromatography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonMobilitySpectrometry"></see>
    /// </summary>
    let IonMobilitySpectrometry =
        Namespaced_IRI.parse _namespace_name "IonMobilitySpectrometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IsothermalMicrocalorimetry"></see>
    /// </summary>
    let IsothermalMicrocalorimetry =
        Namespaced_IRI.parse _namespace_name "IsothermalMicrocalorimetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Laboratory"></see>
    /// </summary>
    let Laboratory = Namespaced_IRI.parse _namespace_name "Laboratory" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfAutomation"></see>
    /// </summary>
    let LevelOfAutomation =
        Namespaced_IRI.parse _namespace_name "LevelOfAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfExpertise"></see>
    /// </summary>
    let LevelOfExpertise =
        Namespaced_IRI.parse _namespace_name "LevelOfExpertise" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LightScattering"></see>
    /// </summary>
    let LightScattering =
        Namespaced_IRI.parse _namespace_name "LightScattering" |> NamespacedName

    /// <summary>
    /// LSV corresponds to the first half cycle of cyclic voltammetry.
    /// The scan is usually started at a potential where no electrode reaction occurs.
    ///
    /// The peak current is expressed by the Randles-Ševčík equation.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearScanVoltammetry"></see></summary>
    let LinearScanVoltammetry =
        Namespaced_IRI.parse _namespace_name "LinearScanVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MassSpectrometry"></see>
    /// </summary>
    let MassSpectrometry =
        Namespaced_IRI.parse _namespace_name "MassSpectrometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementDataPostProcessing"></see>
    /// </summary>
    let MeasurementDataPostProcessing =
        Namespaced_IRI.parse _namespace_name "MeasurementDataPostProcessing" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementSystemAdjustment"></see>
    /// </summary>
    let MeasurementSystemAdjustment =
        Namespaced_IRI.parse _namespace_name "MeasurementSystemAdjustment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementTime"></see>
    /// </summary>
    let MeasurementTime =
        Namespaced_IRI.parse _namespace_name "MeasurementTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MembraneOsmometry"></see>
    /// </summary>
    let MembraneOsmometry =
        Namespaced_IRI.parse _namespace_name "MembraneOsmometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NeutronSpinEchoSpectroscopy"></see>
    /// </summary>
    let NeutronSpinEchoSpectroscopy =
        Namespaced_IRI.parse _namespace_name "NeutronSpinEchoSpectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nexafs"></see>
    /// </summary>
    let Nexafs = Namespaced_IRI.parse _namespace_name "Nexafs" |> NamespacedName

    /// <summary>
    /// Sigmoidal wave-shaped voltammograms are obtained.
    /// The current is sampled at the end of the pulse and then plotted versus the potential of the pulse.
    /// The sensitivity of NPV is not affected by the reversibility of the electrode reaction of the analyte.
    ///
    /// Normal pulse polarography is NPV in which a dropping mercury electrode is used as the working electrode. A pulse is applied just before the mechanically enforced end of the drop. The pulse width is usually 10 to 20 % of the drop time. The drop dislodgment is synchro- nized with current sampling, which is carried out just before the end of the pulse, as in NPV.
    /// The current is sampled just before the end of the pulse, when the charging current is greatly diminished. In this way, the ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detec- tion is lowered.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NormalPulseVoltammetry"></see></summary>
    let NormalPulseVoltammetry =
        Namespaced_IRI.parse _namespace_name "NormalPulseVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NuclearMagneticResonance"></see>
    /// </summary>
    let NuclearMagneticResonance =
        Namespaced_IRI.parse _namespace_name "NuclearMagneticResonance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpenCircuitHold"></see>
    /// </summary>
    let OpenCircuitHold =
        Namespaced_IRI.parse _namespace_name "OpenCircuitHold" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Operator"></see>
    /// </summary>
    let Operator = Namespaced_IRI.parse _namespace_name "Operator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpticalMicroscopy"></see>
    /// </summary>
    let OpticalMicroscopy =
        Namespaced_IRI.parse _namespace_name "OpticalMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhotoluminescenceMicroscopy"></see>
    /// </summary>
    let PhotoluminescenceMicroscopy =
        Namespaced_IRI.parse _namespace_name "PhotoluminescenceMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhysicsOfInteraction"></see>
    /// </summary>
    let PhysicsOfInteraction =
        Namespaced_IRI.parse _namespace_name "PhysicsOfInteraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PostProcessingModel"></see>
    /// </summary>
    let PostProcessingModel =
        Namespaced_IRI.parse _namespace_name "PostProcessingModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PreparedSample"></see>
    /// </summary>
    let PreparedSample =
        Namespaced_IRI.parse _namespace_name "PreparedSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ReferenceSample"></see>
    /// </summary>
    let ReferenceSample =
        Namespaced_IRI.parse _namespace_name "ReferenceSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PrimaryData"></see>
    /// </summary>
    let PrimaryData =
        Namespaced_IRI.parse _namespace_name "PrimaryData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProbeSampleInteraction"></see>
    /// </summary>
    let ProbeSampleInteraction =
        Namespaced_IRI.parse _namespace_name "ProbeSampleInteraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Signal"></see>
    /// </summary>
    let Signal = Namespaced_IRI.parse _namespace_name "Signal" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProcessingReproducibility"></see>
    /// </summary>
    let ProcessingReproducibility =
        Namespaced_IRI.parse _namespace_name "ProcessingReproducibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Profilometry"></see>
    /// </summary>
    let Profilometry =
        Namespaced_IRI.parse _namespace_name "Profilometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PulsedElectroacousticMethod"></see>
    /// </summary>
    let PulsedElectroacousticMethod =
        Namespaced_IRI.parse _namespace_name "PulsedElectroacousticMethod" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RamanSpectroscopy"></see>
    /// </summary>
    let RamanSpectroscopy =
        Namespaced_IRI.parse _namespace_name "RamanSpectroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawData"></see>
    /// </summary>
    let RawData = Namespaced_IRI.parse _namespace_name "RawData" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawSample"></see>
    /// </summary>
    let RawSample = Namespaced_IRI.parse _namespace_name "RawSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspectionInstrument"></see>
    /// </summary>
    let SampleInspectionInstrument =
        Namespaced_IRI.parse _namespace_name "SampleInspectionInstrument" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationParameter"></see>
    /// </summary>
    let SamplePreparationParameter =
        Namespaced_IRI.parse _namespace_name "SamplePreparationParameter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationHardware"></see>
    /// </summary>
    let SamplePreparationHardware =
        Namespaced_IRI.parse _namespace_name "SamplePreparationHardware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationInstrument"></see>
    /// </summary>
    let SamplePreparationInstrument =
        Namespaced_IRI.parse _namespace_name "SamplePreparationInstrument" |> NamespacedName

    /// <summary>
    ///
    /// In this way, the ratio of faradaic current to double layer charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detection is lowered.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampledDCPolarography"></see></summary>
    let SampledDCPolarography =
        Namespaced_IRI.parse _namespace_name "SampledDCPolarography" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningAugerElectronMicroscopy"></see>
    /// </summary>
    let ScanningAugerElectronMicroscopy =
        Namespaced_IRI.parse _namespace_name "ScanningAugerElectronMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningKelvinProbe"></see>
    /// </summary>
    let ScanningKelvinProbe =
        Namespaced_IRI.parse _namespace_name "ScanningKelvinProbe" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningProbeMicroscopy"></see>
    /// </summary>
    let ScanningProbeMicroscopy =
        Namespaced_IRI.parse _namespace_name "ScanningProbeMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningTunnelingMicroscopy"></see>
    /// </summary>
    let ScanningTunnelingMicroscopy =
        Namespaced_IRI.parse _namespace_name "ScanningTunnelingMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryIonMassSpectrometry"></see>
    /// </summary>
    let SecondaryIonMassSpectrometry =
        Namespaced_IRI.parse _namespace_name "SecondaryIonMassSpectrometry" |> NamespacedName

    /// <summary>
    ///
    /// Most instruments show plots of the current at the end of the forward-going pulse and of the backward-going pulse vs. the potential, as well as their difference. This can give valuable information on the kinetics of the electrode reaction and the electrode process.
    /// The current is sampled just before the end of the forward- going pulse and of the backward-going pulse and the difference of the two sampled currents is plotted versus the applied potential of the potential or staircase ramp. The square-wave voltammogram is peak-shaped
    /// The sensitivity of SWV depends on the reversibility of the electrode reaction of the analyte.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SquareWaveVoltammetry"></see></summary>
    let SquareWaveVoltammetry =
        Namespaced_IRI.parse _namespace_name "SquareWaveVoltammetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Synchrotron"></see>
    /// </summary>
    let Synchrotron =
        Namespaced_IRI.parse _namespace_name "Synchrotron" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermogravimetry"></see>
    /// </summary>
    let Thermogravimetry =
        Namespaced_IRI.parse _namespace_name "Thermogravimetry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TransmissionElectronMicroscopy"></see>
    /// </summary>
    let TransmissionElectronMicroscopy =
        Namespaced_IRI.parse _namespace_name "TransmissionElectronMicroscopy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ultrasonic"></see>
    /// </summary>
    let Ultrasonic = Namespaced_IRI.parse _namespace_name "Ultrasonic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VaporPressureDepressionOsmometry"></see>
    /// </summary>
    let VaporPressureDepressionOsmometry =
        Namespaced_IRI.parse _namespace_name "VaporPressureDepressionOsmometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Viscometry"></see>
    /// </summary>
    let Viscometry = Namespaced_IRI.parse _namespace_name "Viscometry" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VoltammetryAtARotatingDiskElectrode"></see>
    /// </summary>
    let VoltammetryAtARotatingDiskElectrode =
        Namespaced_IRI.parse _namespace_name "VoltammetryAtARotatingDiskElectrode" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XpsVariableKinetic"></see>
    /// </summary>
    let XpsVariableKinetic =
        Namespaced_IRI.parse _namespace_name "XpsVariableKinetic" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XrdGrazingIncidence"></see>
    /// </summary>
    let XrdGrazingIncidence =
        Namespaced_IRI.parse _namespace_name "XrdGrazingIncidence" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#characterisationProcedureHasSubProcedure"></see>
    /// </summary>
    let characterisationProcedureHasSubProcedure =
        Namespaced_IRI.parse _namespace_name "characterisationProcedureHasSubProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasAccessConditions"></see>
    /// </summary>
    let hasAccessConditions =
        Namespaced_IRI.parse _namespace_name "hasAccessConditions" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironment"></see>
    /// </summary>
    let hasCharacterisationEnvironment =
        Namespaced_IRI.parse _namespace_name "hasCharacterisationEnvironment" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironmentProperty"></see>
    /// </summary>
    let hasCharacterisationEnvironmentProperty =
        Namespaced_IRI.parse _namespace_name "hasCharacterisationEnvironmentProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProcedureValidation"></see>
    /// </summary>
    let hasCharacterisationProcedureValidation =
        Namespaced_IRI.parse _namespace_name "hasCharacterisationProcedureValidation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProperty"></see>
    /// </summary>
    let hasCharacterisationProperty =
        Namespaced_IRI.parse _namespace_name "hasCharacterisationProperty" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationSoftware"></see>
    /// </summary>
    let hasCharacterisationSoftware =
        Namespaced_IRI.parse _namespace_name "hasCharacterisationSoftware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataAcquisitionRate"></see>
    /// </summary>
    let hasDataAcquisitionRate =
        Namespaced_IRI.parse _namespace_name "hasDataAcquisitionRate" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataProcessingThroughCalibration"></see>
    /// </summary>
    let hasDataProcessingThroughCalibration =
        Namespaced_IRI.parse _namespace_name "hasDataProcessingThroughCalibration" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataQuality"></see>
    /// </summary>
    let hasDataQuality =
        Namespaced_IRI.parse _namespace_name "hasDataQuality" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataset"></see>
    /// </summary>
    let hasDataset = Namespaced_IRI.parse _namespace_name "hasDataset" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHardwareSpecification"></see>
    /// </summary>
    let hasHardwareSpecification =
        Namespaced_IRI.parse _namespace_name "hasHardwareSpecification" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHazard"></see>
    /// </summary>
    let hasHazard = Namespaced_IRI.parse _namespace_name "hasHazard" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHolder"></see>
    /// </summary>
    let hasHolder = Namespaced_IRI.parse _namespace_name "hasHolder" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionVolume"></see>
    /// </summary>
    let hasInteractionVolume =
        Namespaced_IRI.parse _namespace_name "hasInteractionVolume" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithProbe"></see>
    /// </summary>
    let hasInteractionWithProbe =
        Namespaced_IRI.parse _namespace_name "hasInteractionWithProbe" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithSample"></see>
    /// </summary>
    let hasInteractionWithSample =
        Namespaced_IRI.parse _namespace_name "hasInteractionWithSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLab"></see>
    /// </summary>
    let hasLab = Namespaced_IRI.parse _namespace_name "hasLab" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLevelOfAutomation"></see>
    /// </summary>
    let hasLevelOfAutomation =
        Namespaced_IRI.parse _namespace_name "hasLevelOfAutomation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementDetector"></see>
    /// </summary>
    let hasMeasurementDetector =
        Namespaced_IRI.parse _namespace_name "hasMeasurementDetector" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementParameter"></see>
    /// </summary>
    let hasMeasurementParameter =
        Namespaced_IRI.parse _namespace_name "hasMeasurementParameter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementProbe"></see>
    /// </summary>
    let hasMeasurementProbe =
        Namespaced_IRI.parse _namespace_name "hasMeasurementProbe" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementSample"></see>
    /// </summary>
    let hasMeasurementSample =
        Namespaced_IRI.parse _namespace_name "hasMeasurementSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementTime"></see>
    /// </summary>
    let hasMeasurementTime =
        Namespaced_IRI.parse _namespace_name "hasMeasurementTime" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasOperator"></see>
    /// </summary>
    let hasOperator =
        Namespaced_IRI.parse _namespace_name "hasOperator" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPeerReviewedArticle"></see>
    /// </summary>
    let hasPeerReviewedArticle =
        Namespaced_IRI.parse _namespace_name "hasPeerReviewedArticle" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPhysicsOfInteraction"></see>
    /// </summary>
    let hasPhysicsOfInteraction =
        Namespaced_IRI.parse _namespace_name "hasPhysicsOfInteraction" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPostProcessingModel"></see>
    /// </summary>
    let hasPostProcessingModel =
        Namespaced_IRI.parse _namespace_name "hasPostProcessingModel" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasProcessingReproducibility"></see>
    /// </summary>
    let hasProcessingReproducibility =
        Namespaced_IRI.parse _namespace_name "hasProcessingReproducibility" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampleBeforeSamplePreparation"></see>
    /// </summary>
    let hasSampleBeforeSamplePreparation =
        Namespaced_IRI.parse _namespace_name "hasSampleBeforeSamplePreparation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationHardware"></see>
    /// </summary>
    let hasSamplePreparationHardware =
        Namespaced_IRI.parse _namespace_name "hasSamplePreparationHardware" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationInput"></see>
    /// </summary>
    let hasSamplePreparationInput =
        Namespaced_IRI.parse _namespace_name "hasSamplePreparationInput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationOutput"></see>
    /// </summary>
    let hasSamplePreparationOutput =
        Namespaced_IRI.parse _namespace_name "hasSamplePreparationOutput" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationParameter"></see>
    /// </summary>
    let hasSamplePreparationParameter =
        Namespaced_IRI.parse _namespace_name "hasSamplePreparationParameter" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampledSample"></see>
    /// </summary>
    let hasSampledSample =
        Namespaced_IRI.parse _namespace_name "hasSampledSample" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#requiresLevelOfExpertise"></see>
    /// </summary>
    let requiresLevelOfExpertise =
        Namespaced_IRI.parse _namespace_name "requiresLevelOfExpertise" |> NamespacedName
