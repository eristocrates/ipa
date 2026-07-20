namespace https.w3id.org.emmo.domain.characterisation_methodology.chameo.hash

open DoxAletheia

module chameo =
    let _namespace_name =
        "https://w3id.org/emmo/domain/characterisation-methodology/chameo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicChronopotentiometry"></see>
    /// </summary>
    let CyclicChronopotentiometry = _prefix "CyclicChronopotentiometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CompressionTest"></see>
    /// </summary>
    let CompressionTest = _prefix "CompressionTest"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CreepTest"></see>
    /// </summary>
    let CreepTest = _prefix "CreepTest"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalAnalysis"></see>
    /// </summary>
    let DynamicMechanicalAnalysis = _prefix "DynamicMechanicalAnalysis"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FatigueTesting"></see>
    /// </summary>
    let FatigueTesting = _prefix "FatigueTesting"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FibDic"></see>
    /// </summary>
    let FibDic = _prefix "FibDic"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HardnessTesting"></see>
    /// </summary>
    let HardnessTesting = _prefix "HardnessTesting"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nanoindentation"></see>
    /// </summary>
    let Nanoindentation = _prefix "Nanoindentation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ShearOrTorsionTests"></see>
    /// </summary>
    let ShearOrTorsionTests = _prefix "ShearOrTorsionTests"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TensileTest"></see>
    /// </summary>
    let TensileTest = _prefix "TensileTest"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#WearTest"></see>
    /// </summary>
    let WearTest = _prefix "WearTest"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StepChronopotentiometry"></see>
    /// </summary>
    let StepChronopotentiometry = _prefix "StepChronopotentiometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrogravimetry"></see>
    /// </summary>
    let Electrogravimetry = _prefix "Electrogravimetry"
    /// <summary>
    ///
    /// electrochemical method where traces of solid particles are abrasively transferred onto the surface of an electrode, followed by an electrochemical dissolution (anodic or cathodic dissolution) that is recorded as a current–voltage curve
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AbrasiveStrippingVoltammetry"></see></summary>
    let AbrasiveStrippingVoltammetry = _prefix "AbrasiveStrippingVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearChronopotentiometry"></see>
    /// </summary>
    let LinearChronopotentiometry = _prefix "LinearChronopotentiometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationProcess"></see>
    /// </summary>
    let CalibrationProcess = _prefix "CalibrationProcess"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationDataValidation"></see>
    /// </summary>
    let CharacterisationDataValidation = _prefix "CharacterisationDataValidation"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementProcess"></see>
    /// </summary>
    let CharacterisationMeasurementProcess =
        _prefix "CharacterisationMeasurementProcess"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAnalysis"></see>
    /// </summary>
    let DataAnalysis = _prefix "DataAnalysis"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPostProcessing"></see>
    /// </summary>
    let DataPostProcessing = _prefix "DataPostProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPreparation"></see>
    /// </summary>
    let DataPreparation = _prefix "DataPreparation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspection"></see>
    /// </summary>
    let SampleInspection = _prefix "SampleInspection"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparation"></see>
    /// </summary>
    let SamplePreparation = _prefix "SamplePreparation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplingProcess"></see>
    /// </summary>
    let SamplingProcess = _prefix "SamplingProcess"
    /// <summary>
    /// the stripping potentiogram shows staircase curves of potential as a function of time. Frequently, the first derivative is displayed (dE/dt=f(t)), as this produces peak-shaped signals. The time between transitions (peaks) is proportional to the concentration of analyte in the test solution
    ///
    /// historically for the analysis of metal ions, mercury ions were added to the test solution to form a mercury amalgam when reduced. Alternatively, an HMDE or MFE was used and the oxidizing agent added after amalgam formation. However, the toxicity of mercury and its compounds have all but precluded the present-day use of mercury
    /// the accumulation is similar to that used in stripping voltammetry
    /// the time between changes in potential in step 2 is related to the concentration of analyte in the solution
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PotentiometricStrippingAnalysis"></see></summary>
    let PotentiometricStrippingAnalysis = _prefix "PotentiometricStrippingAnalysis"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialStaircasePulseVoltammetry"></see>
    /// </summary>
    let DifferentialStaircasePulseVoltammetry =
        _prefix "DifferentialStaircasePulseVoltammetry"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialLinearPulseVoltammetry"></see>
    /// </summary>
    let DifferentialLinearPulseVoltammetry =
        _prefix "DifferentialLinearPulseVoltammetry"

    /// <summary>
    ///
    /// The resulting alternating current is plotted versus imposed DC potential. The obtained AC voltammogram is peak-shaped.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ACVoltammetry"></see></summary>
    let ACVoltammetry = _prefix "ACVoltammetry"
    /// <summary>
    ///
    /// The current vs. potential (I-E) curve is called a voltammogram.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Voltammetry"></see></summary>
    let Voltammetry = _prefix "Voltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AccessConditions"></see>
    /// </summary>
    let AccessConditions = _prefix "AccessConditions"
    /// <summary>
    /// AdSV is usually employed for analysis of organic compounds or metal complexes with organic ligands. Stripping is done by means of an anodic or a cathodic voltammetric scan (linear or pulse), during which the adsorbed compound is oxidized or reduced.
    ///
    /// A peak-shaped adsorptive stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AdsorptiveStrippingVoltammetry"></see></summary>
    let AdsorptiveStrippingVoltammetry = _prefix "AdsorptiveStrippingVoltammetry"
    /// <summary>
    /// Anodic stripping voltammetry (ASV) was historically used to measure concentrations of metal ions in solution using cathodic accumulation with mercury to form an amalgam. Due to the toxicity of mercury and its compounds, inductively coupled plasma optical emission spectrometry and inductively coupled plasma mass spectrometry have frequently replaced ASV at mercury electrodes in the laboratory, often sacrificing the probing of speciation and lability in complex matrices. Mercury has now been replaced by non-toxic bismuth or anti- mony as films on a solid electrode support (such as glassy carbon) with equally good sensi- tivity and detection limits.
    /// Types of stripping voltammetry refer to the kind of accumulation (e.g. adsorptive stripping voltammetry) or the polarity of the stripping electrochemistry (anodic, cathodic stripping voltammetry).
    /// Often the product of the electrochemical stripping is identical to the analyte before the accumulation.
    /// Because the accumulation (pre-concentration) step can be prolonged, increasing the amount of material at the electrode, stripping voltammetry is able to measure very small concentrations of analyte.
    ///
    /// Stripping voltammetry is a calibrated method to establish the relation between amount accumulated in a given time and the concentration of the analyte in solution.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StrippingVoltammetry"></see></summary>
    let StrippingVoltammetry = _prefix "StrippingVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AlphaSpectrometry"></see>
    /// </summary>
    let AlphaSpectrometry = _prefix "AlphaSpectrometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectrometry"></see>
    /// </summary>
    let Spectrometry = _prefix "Spectrometry"
    /// <summary>
    /// Amperometry can be distinguished from voltammetry by the parameter being controlled (electrode potential E) and the parameter being measured (electrode current I which is usually a function of time – see chronoamperometry).
    /// The current is usually faradaic and the applied potential is usually constant.
    ///
    /// The integral of current with time is the electric charge, which may be related to the amount of substance reacted by Faraday’s laws of electrolysis.
    /// In a non-stirred solution, a diffusion-limited current is usually measured, which is propor-tional to the concentration of an electroactive analyte.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Amperometry"></see></summary>
    let Amperometry = _prefix "Amperometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrochemical"></see>
    /// </summary>
    let Electrochemical = _prefix "Electrochemical"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnalyticalElectronMicroscopy"></see>
    /// </summary>
    let AnalyticalElectronMicroscopy = _prefix "AnalyticalElectronMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Microscopy"></see>
    /// </summary>
    let Microscopy = _prefix "Microscopy"
    /// <summary>
    ///
    /// A peak-shaped anodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.
    /// A solid electrode, carbon paste or composite electrode, bismuth film electrode, mercury film electrode, or static mercury drop electrode may be used.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnodicStrippingVoltammetry"></see></summary>
    let AnodicStrippingVoltammetry = _prefix "AnodicStrippingVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomProbeTomography"></see>
    /// </summary>
    let AtomProbeTomography = _prefix "AtomProbeTomography"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Tomography"></see>
    /// </summary>
    let Tomography = _prefix "Tomography"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomicForceMicroscopy"></see>
    /// </summary>
    let AtomicForceMicroscopy = _prefix "AtomicForceMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationData"></see>
    /// </summary>
    let CalibrationData = _prefix "CalibrationData"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationData"></see>
    /// </summary>
    let CharacterisationData = _prefix "CharacterisationData"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationDataPostProcessing"></see>
    /// </summary>
    let CalibrationDataPostProcessing = _prefix "CalibrationDataPostProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedure"></see>
    /// </summary>
    let CharacterisationProcedure = _prefix "CharacterisationProcedure"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationInstrument"></see>
    /// </summary>
    let CharacterisationInstrument = _prefix "CharacterisationInstrument"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationTask"></see>
    /// </summary>
    let CalibrationTask = _prefix "CalibrationTask"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationTask"></see>
    /// </summary>
    let CharacterisationTask = _prefix "CharacterisationTask"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Calorimetry"></see>
    /// </summary>
    let Calorimetry = _prefix "Calorimetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermochemical"></see>
    /// </summary>
    let Thermochemical = _prefix "Thermochemical"
    /// <summary>
    /// A peak-shaped cathodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.
    ///
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CathodicStrippingVoltammetry"></see></summary>
    let CathodicStrippingVoltammetry = _prefix "CathodicStrippingVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironment"></see>
    /// </summary>
    let CharacterisationEnvironment = _prefix "CharacterisationEnvironment"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironmentProperty"></see>
    /// </summary>
    let CharacterisationEnvironmentProperty =
        _prefix "CharacterisationEnvironmentProperty"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationExperiment"></see>
    /// </summary>
    let CharacterisationExperiment = _prefix "CharacterisationExperiment"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardware"></see>
    /// </summary>
    let CharacterisationHardware = _prefix "CharacterisationHardware"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareManufacturer"></see>
    /// </summary>
    let CharacterisationHardwareManufacturer =
        _prefix "CharacterisationHardwareManufacturer"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareSpecification"></see>
    /// </summary>
    let CharacterisationHardwareSpecification =
        _prefix "CharacterisationHardwareSpecification"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareModel"></see>
    /// </summary>
    let CharacterisationHardwareModel = _prefix "CharacterisationHardwareModel"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Probe"></see>
    /// </summary>
    let Probe = _prefix "Probe"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Detector"></see>
    /// </summary>
    let Detector = _prefix "Detector"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Sample"></see>
    /// </summary>
    let Sample = _prefix "Sample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementParameter"></see>
    /// </summary>
    let MeasurementParameter = _prefix "MeasurementParameter"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementTask"></see>
    /// </summary>
    let CharacterisationMeasurementTask = _prefix "CharacterisationMeasurementTask"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMethod"></see>
    /// </summary>
    let CharacterisationMethod = _prefix "CharacterisationMethod"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedureValidation"></see>
    /// </summary>
    let CharacterisationProcedureValidation =
        _prefix "CharacterisationProcedureValidation"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProperty"></see>
    /// </summary>
    let CharacterisationProperty = _prefix "CharacterisationProperty"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryData"></see>
    /// </summary>
    let SecondaryData = _prefix "SecondaryData"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProtocol"></see>
    /// </summary>
    let CharacterisationProtocol = _prefix "CharacterisationProtocol"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSoftware"></see>
    /// </summary>
    let CharacterisationSoftware = _prefix "CharacterisationSoftware"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSystem"></see>
    /// </summary>
    let CharacterisationSystem = _prefix "CharacterisationSystem"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationWorkflow"></see>
    /// </summary>
    let CharacterisationWorkflow = _prefix "CharacterisationWorkflow"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisedSample"></see>
    /// </summary>
    let CharacterisedSample = _prefix "CharacterisedSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ChargeDistribution"></see>
    /// </summary>
    let ChargeDistribution = _prefix "ChargeDistribution"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chromatography"></see>
    /// </summary>
    let Chromatography = _prefix "Chromatography"
    /// <summary>
    ///
    /// If the potential step is from a potential at which no current flows (i.e., at which the oxidation or reduction of the electrochemically active species does not take place) to one at which the current is limited by diffusion (see diffusion-limited current), the current obeys the Cottrell equation.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronoamperometry"></see></summary>
    let Chronoamperometry = _prefix "Chronoamperometry"
    /// <summary>
    ///
    /// Chronocoulometry provides the same information that is provided by chronoamperometry, since it is based on the integration of the I-t curve. Nevertheless, chronocoulometry offers important experimental advantages, such as (i) the measured signal usually increases with time and hence the later parts of the transient can be detected more accurately, (ii) a better signal-to-noise ratio can be achieved, and (iii) other contributions to overall charge passed as a function of time can be discriminated from those due to the diffusion of electroactive substances.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronocoulometry"></see></summary>
    let Chronocoulometry = _prefix "Chronocoulometry"
    /// <summary>
    /// The coulometric experiment can be carried out at controlled (constant) potential (see direct coulometry at controlled potential) or controlled (constant) current (see direct coulometry at controlled current).
    ///
    /// Coulometry used to measure the amount of substance is a primary reference measurement procedure [VIM 2.8] not requiring calibration with a standard for a quantity of the same kind (i.e. amount of substance).
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Coulometry"></see></summary>
    let Coulometry = _prefix "Coulometry"
    /// <summary>
    ///
    /// The change in applied current is usually a step, but cyclic current reversals or linearly increasing currents are also used.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronopotentiometry"></see></summary>
    let Chronopotentiometry = _prefix "Chronopotentiometry"
    /// <summary>
    ///
    /// For measurements using ion-selective electrodes, the measurement is made under equi- librium conditions what means that the macroscopic electric current is zero and the con- centrations of all species are uniform throughout the solution. The indicator electrode is in direct contact with the analyte solution, whereas the reference electrode is usually separated from the analyte solution by a salt bridge. The potential difference between the indicator and reference electrodes is normally directly proportional to the logarithm of the activity (concentration) of the analyte in the solution (Nernst equation). See also ion selec- tive electrode.
    /// Method of electroanalytical chemistry based on measurement of an electrode potential.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Potentiometry"></see></summary>
    let Potentiometry = _prefix "Potentiometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Mechanical"></see>
    /// </summary>
    let Mechanical = _prefix "Mechanical"
    /// <summary>
    /// The method can be used for deeply coloured or turbid solutions. Acid-base and precipita- tion reactions are most frequently used.
    /// The equivalence-point is obtained as the intersection of linear parts of the conductance G, versus titrant volume V, curve (see
    /// The method is based on replacing an ionic species of the analyte with another species, cor- responding to the titrant or the product with significantly different conductance.
    ///
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConductometricTitration"></see></summary>
    let ConductometricTitration = _prefix "ConductometricTitration"
    /// <summary>
    ///
    /// The conductivity of a solution depends on the concentration and nature of ions present.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Conductometry"></see></summary>
    let Conductometry = _prefix "Conductometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConfocalMicroscopy"></see>
    /// </summary>
    let ConfocalMicroscopy = _prefix "ConfocalMicroscopy"
    /// <summary>
    ///
    /// The main advantages are that titration is possible with less stable titrants, the standardi- zation of titrant is not necessary, the volume of the test solution is not changed, and the method is easily automated.
    /// Coulometric titrations are usually carried out in convective mass transfer mode using a large surface working electrode. The reference and auxiliary electrodes are located in sepa- rate compartments. A basic requirement is a 100 % current efficiency of titrant generation at the working electrode. End-point detection can be accomplished with potentiometry, amperometry, biamperometry, bipotentiometry, photometry, or by using a visual indicator.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CoulometricTitration"></see></summary>
    let CoulometricTitration = _prefix "CoulometricTitration"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CriticalAndSupercriticalChromatography"></see>
    /// </summary>
    let CriticalAndSupercriticalChromatography =
        _prefix "CriticalAndSupercriticalChromatography"

    /// <summary>
    /// The plot of current against potential is termed a cyclic voltammogram. Usually peak-shaped responses are obtained for scans in both directions.
    ///
    /// Normally the initial potential is chosen where no electrode reaction occurs and the switch- ing potential is greater (more positive for an oxidation or more negative for a reduction) than the peak potential of the analyte reaction.
    /// The initial potential is usually the negative or positive limit of the cycle but can have any value between the two limits, as can the initial scan direction. The limits of the potential are known as the switching potentials.
    /// Cyclic voltammetry is frequently used for the investigation of mechanisms of electrochemi- cal/electrode reactions. The current-potential curve may be modelled to obtain reaction mechanisms and electrochemical parameters.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicVoltammetry"></see></summary>
    let CyclicVoltammetry = _prefix "CyclicVoltammetry"
    /// <summary>
    /// Usually the drop time is between 1 and 5 s and the pseudo-steady-state wave-shaped dependence on potential is called a polarogram. If the limiting current is controlled by dif- fusion, it is expressed by the Ilkovich equation.
    ///
    /// If the whole scan is performed on a single growing drop, the technique should be called single drop scan voltammetry. The term polarography in this context is discouraged.
    /// This is the oldest variant of polarographic techniques, introduced by Jaroslav Heyrovský (1890 – 1967).
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DCPolarography"></see></summary>
    let DCPolarography = _prefix "DCPolarography"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAcquisitionRate"></see>
    /// </summary>
    let DataAcquisitionRate = _prefix "DataAcquisitionRate"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataFiltering"></see>
    /// </summary>
    let DataFiltering = _prefix "DataFiltering"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataNormalisation"></see>
    /// </summary>
    let DataNormalisation = _prefix "DataNormalisation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataProcessingThroughCalibration"></see>
    /// </summary>
    let DataProcessingThroughCalibration = _prefix "DataProcessingThroughCalibration"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataQuality"></see>
    /// </summary>
    let DataQuality = _prefix "DataQuality"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DielectricAndImpedanceSpectroscopy"></see>
    /// </summary>
    let DielectricAndImpedanceSpectroscopy =
        _prefix "DielectricAndImpedanceSpectroscopy"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectroscopy"></see>
    /// </summary>
    let Spectroscopy = _prefix "Spectroscopy"
    /// <summary>
    ///
    /// The method is used to monitor the purity of dielectrics, for example to detect small amounts of moisture.
    /// Dielectrometric titrations use dielectrometry for the end-point detection.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dielectrometry"></see></summary>
    let Dielectrometry = _prefix "Dielectrometry"
    /// <summary>
    ///
    /// The ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated in the same way as in normal pulse voltammetry (NPV). Moreover, subtraction of the charging current sampled before the application of the pulse further decreases its negative influence. Due to the more enhanced signal (faradaic current) to noise (charging current) ratio, the limit of detection is lower than with NPV.
    /// Differential pulse polarography is differential pulse voltammetry in which a dropping mercury electrode is used as the working electrode. A pulse is applied before the mechani- cally enforced end of the drop and the current is sampled twice: just before the onset of the pulse and just before its end. The pulse width is usually 10 to 20 % of the drop life. The drop dislodgement is synchronized with current sampling, which is carried out as in DPV.
    /// The sensitivity of DPV depends on the reversibility of the electrode reaction of the analyte.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialPulseVoltammetry"></see></summary>
    let DifferentialPulseVoltammetry = _prefix "DifferentialPulseVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialRefractiveIndex"></see>
    /// </summary>
    let DifferentialRefractiveIndex = _prefix "DifferentialRefractiveIndex"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Optical"></see>
    /// </summary>
    let Optical = _prefix "Optical"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialScanningCalorimetry"></see>
    /// </summary>
    let DifferentialScanningCalorimetry = _prefix "DifferentialScanningCalorimetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialThermalAnalysis"></see>
    /// </summary>
    let DifferentialThermalAnalysis = _prefix "DifferentialThermalAnalysis"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dilatometry"></see>
    /// </summary>
    let Dilatometry = _prefix "Dilatometry"

    /// <summary>
    ///
    /// The advantage of this method is that the electric charge consumed during the electrode reaction is directly proportional to the electrolysis time. Care must be taken to avoid the potential region where another electrode reaction may occur.
    /// Direct coulometry at controlled current is usually carried out in convective mass transfer mode. The end-point of the electrolysis, at which the current is stopped, must be determined either from the inflection point in the E–t curve or by using visual or objective end-point indi- cation, similar to volumetric methods. The total electric charge is calculated as the product of the constant current and time of electrolysis or can be measured directly using a coulometer.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledCurrent"></see></summary>
    let DirectCoulometryAtControlledCurrent =
        _prefix "DirectCoulometryAtControlledCurrent"

    /// <summary>
    ///
    /// In principle, the end point at which I = 0, i.e. when the concentration of species under study becomes zero, can be reached only at infinite time. However, in practice, the electrolysis is stopped when the current has decayed to a few percent of the initial value and the charge passed at infinite time is calculated from a plot of charge Q(t) against time t. For a simple system under diffusion control Qt= Q∞[1 − exp(−DAt/Vδ)], where Q∞ = limt→∞Q(t) is the total charge passed at infinite time, D is the diffusion coefficient of the electroactive species, A the electrode area, δ the diffusion layer thickness, and V the volume of the solution.
    /// Direct coulometry at controlled potential is usually carried out in convective mass trans- fer mode using a large surface working electrode. Reference and auxiliary electrodes are placed in separate compartments. The total electric charge is obtained by integration of the I–t curve or can be measured directly using a coulometer.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledPotential"></see></summary>
    let DirectCoulometryAtControlledPotential =
        _prefix "DirectCoulometryAtControlledPotential"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicLightScattering"></see>
    /// </summary>
    let DynamicLightScattering = _prefix "DynamicLightScattering"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalSpectroscopy"></see>
    /// </summary>
    let DynamicMechanicalSpectroscopy = _prefix "DynamicMechanicalSpectroscopy"

    /// <summary>
    /// The sinusoidal current response lags behind the sinusoidal voltage perturbation by a phase angle φ. Resistances (e.g. to charge transfer) give a response in phase with the voltage perturbation; capacitances (e.g. double layer) give a response 90° out of phase; combinations of resistances and capacitances give phase angles between 0 and 90°. Plots of the out of phase vs. the in phase component of the impedance for all the frequencies tested are called complex plane (or Nyquist) plots. Plots of the phase angle and the magnitude of the impedance vs. the logarithm of perturbation frequency are called Bode diagrams. Complex plane plots are the more commonly used for electrochemical sensors.
    /// Impedimetric sensors are based on measurement of a concentration-dependent parameter taken from analysis of the respective electrochemical impedance spectra, or from the impedance magnitudes at a chosen fixed frequency.
    ///
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalImpedanceSpectroscopy"></see></summary>
    let ElectrochemicalImpedanceSpectroscopy =
        _prefix "ElectrochemicalImpedanceSpectroscopy"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Impedimetry"></see>
    /// </summary>
    let Impedimetry = _prefix "Impedimetry"

    /// <summary>
    ///
    /// The change of mass is, for rigid deposits, linearly proportional to the change of the reso- nance frequency of the quartz crystal, according to the Sauerbrey equation. For non- rigid deposits, corrections must be made.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalPiezoelectricMicrogravimetry"></see></summary>
    let ElectrochemicalPiezoelectricMicrogravimetry =
        _prefix "ElectrochemicalPiezoelectricMicrogravimetry"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronBackscatterDiffraction"></see>
    /// </summary>
    let ElectronBackscatterDiffraction = _prefix "ElectronBackscatterDiffraction"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScatteringAndDiffraction"></see>
    /// </summary>
    let ScatteringAndDiffraction = _prefix "ScatteringAndDiffraction"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningElectronMicroscopy"></see>
    /// </summary>
    let ScanningElectronMicroscopy = _prefix "ScanningElectronMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronProbeMicroanalysis"></see>
    /// </summary>
    let ElectronProbeMicroanalysis = _prefix "ElectronProbeMicroanalysis"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ellipsometry"></see>
    /// </summary>
    let Ellipsometry = _prefix "Ellipsometry"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#EnvironmentalScanningElectronMicroscopy"></see>
    /// </summary>
    let EnvironmentalScanningElectronMicroscopy =
        _prefix "EnvironmentalScanningElectronMicroscopy"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Exafs"></see>
    /// </summary>
    let Exafs = _prefix "Exafs"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FieldEmissionScanningElectronMicroscopy"></see>
    /// </summary>
    let FieldEmissionScanningElectronMicroscopy =
        _prefix "FieldEmissionScanningElectronMicroscopy"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Fractography"></see>
    /// </summary>
    let Fractography = _prefix "Fractography"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FreezingPointDepressionOsmometry"></see>
    /// </summary>
    let FreezingPointDepressionOsmometry = _prefix "FreezingPointDepressionOsmometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Osmometry"></see>
    /// </summary>
    let Osmometry = _prefix "Osmometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GITT"></see>
    /// </summary>
    let GITT = _prefix "GITT"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GammaSpectrometry"></see>
    /// </summary>
    let GammaSpectrometry = _prefix "GammaSpectrometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HPPC"></see>
    /// </summary>
    let HPPC = _prefix "HPPC"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Hazard"></see>
    /// </summary>
    let Hazard = _prefix "Hazard"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Holder"></see>
    /// </summary>
    let Holder = _prefix "Holder"
    /// <summary>
    /// A linear potential scan, at sufficiently slow scan rates so as to ensure a steady state response, is usually applied.
    /// Mass transport of a redox species enhanced by convection in this way results in a greater electric current. Convective mass transfer occurs up to the diffusion-limiting layer, within which the mass transfer is controlled by diffusion. Electroactive substance depletion outside the diffusion layer is annulled by convective mass transfer, which results in steady- state sigmoidal wave-shaped current-potential curves.
    ///
    /// The forced flow can be accomplished by movement either of the solution (solution stirring, or channel flow), or of the electrode (electrode rotation or vibration).
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HydrodynamicVoltammetry"></see></summary>
    let HydrodynamicVoltammetry = _prefix "HydrodynamicVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ICI"></see>
    /// </summary>
    let ICI = _prefix "ICI"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#InteractionVolume"></see>
    /// </summary>
    let InteractionVolume = _prefix "InteractionVolume"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IntermediateSample"></see>
    /// </summary>
    let IntermediateSample = _prefix "IntermediateSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonChromatography"></see>
    /// </summary>
    let IonChromatography = _prefix "IonChromatography"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonMobilitySpectrometry"></see>
    /// </summary>
    let IonMobilitySpectrometry = _prefix "IonMobilitySpectrometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IsothermalMicrocalorimetry"></see>
    /// </summary>
    let IsothermalMicrocalorimetry = _prefix "IsothermalMicrocalorimetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Laboratory"></see>
    /// </summary>
    let Laboratory = _prefix "Laboratory"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfAutomation"></see>
    /// </summary>
    let LevelOfAutomation = _prefix "LevelOfAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfExpertise"></see>
    /// </summary>
    let LevelOfExpertise = _prefix "LevelOfExpertise"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LightScattering"></see>
    /// </summary>
    let LightScattering = _prefix "LightScattering"
    /// <summary>
    /// LSV corresponds to the first half cycle of cyclic voltammetry.
    /// The scan is usually started at a potential where no electrode reaction occurs.
    ///
    /// The peak current is expressed by the Randles-Ševčík equation.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearScanVoltammetry"></see></summary>
    let LinearScanVoltammetry = _prefix "LinearScanVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MassSpectrometry"></see>
    /// </summary>
    let MassSpectrometry = _prefix "MassSpectrometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementDataPostProcessing"></see>
    /// </summary>
    let MeasurementDataPostProcessing = _prefix "MeasurementDataPostProcessing"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementSystemAdjustment"></see>
    /// </summary>
    let MeasurementSystemAdjustment = _prefix "MeasurementSystemAdjustment"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementTime"></see>
    /// </summary>
    let MeasurementTime = _prefix "MeasurementTime"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MembraneOsmometry"></see>
    /// </summary>
    let MembraneOsmometry = _prefix "MembraneOsmometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NeutronSpinEchoSpectroscopy"></see>
    /// </summary>
    let NeutronSpinEchoSpectroscopy = _prefix "NeutronSpinEchoSpectroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nexafs"></see>
    /// </summary>
    let Nexafs = _prefix "Nexafs"
    /// <summary>
    /// Sigmoidal wave-shaped voltammograms are obtained.
    /// The current is sampled at the end of the pulse and then plotted versus the potential of the pulse.
    /// The sensitivity of NPV is not affected by the reversibility of the electrode reaction of the analyte.
    ///
    /// Normal pulse polarography is NPV in which a dropping mercury electrode is used as the working electrode. A pulse is applied just before the mechanically enforced end of the drop. The pulse width is usually 10 to 20 % of the drop time. The drop dislodgment is synchro- nized with current sampling, which is carried out just before the end of the pulse, as in NPV.
    /// The current is sampled just before the end of the pulse, when the charging current is greatly diminished. In this way, the ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detec- tion is lowered.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NormalPulseVoltammetry"></see></summary>
    let NormalPulseVoltammetry = _prefix "NormalPulseVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NuclearMagneticResonance"></see>
    /// </summary>
    let NuclearMagneticResonance = _prefix "NuclearMagneticResonance"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpenCircuitHold"></see>
    /// </summary>
    let OpenCircuitHold = _prefix "OpenCircuitHold"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Operator"></see>
    /// </summary>
    let Operator = _prefix "Operator"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpticalMicroscopy"></see>
    /// </summary>
    let OpticalMicroscopy = _prefix "OpticalMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhotoluminescenceMicroscopy"></see>
    /// </summary>
    let PhotoluminescenceMicroscopy = _prefix "PhotoluminescenceMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhysicsOfInteraction"></see>
    /// </summary>
    let PhysicsOfInteraction = _prefix "PhysicsOfInteraction"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PostProcessingModel"></see>
    /// </summary>
    let PostProcessingModel = _prefix "PostProcessingModel"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PreparedSample"></see>
    /// </summary>
    let PreparedSample = _prefix "PreparedSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ReferenceSample"></see>
    /// </summary>
    let ReferenceSample = _prefix "ReferenceSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PrimaryData"></see>
    /// </summary>
    let PrimaryData = _prefix "PrimaryData"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProbeSampleInteraction"></see>
    /// </summary>
    let ProbeSampleInteraction = _prefix "ProbeSampleInteraction"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Signal"></see>
    /// </summary>
    let Signal = _prefix "Signal"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProcessingReproducibility"></see>
    /// </summary>
    let ProcessingReproducibility = _prefix "ProcessingReproducibility"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Profilometry"></see>
    /// </summary>
    let Profilometry = _prefix "Profilometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PulsedElectroacousticMethod"></see>
    /// </summary>
    let PulsedElectroacousticMethod = _prefix "PulsedElectroacousticMethod"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RamanSpectroscopy"></see>
    /// </summary>
    let RamanSpectroscopy = _prefix "RamanSpectroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawData"></see>
    /// </summary>
    let RawData = _prefix "RawData"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawSample"></see>
    /// </summary>
    let RawSample = _prefix "RawSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspectionInstrument"></see>
    /// </summary>
    let SampleInspectionInstrument = _prefix "SampleInspectionInstrument"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationParameter"></see>
    /// </summary>
    let SamplePreparationParameter = _prefix "SamplePreparationParameter"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationHardware"></see>
    /// </summary>
    let SamplePreparationHardware = _prefix "SamplePreparationHardware"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationInstrument"></see>
    /// </summary>
    let SamplePreparationInstrument = _prefix "SamplePreparationInstrument"
    /// <summary>
    ///
    /// In this way, the ratio of faradaic current to double layer charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detection is lowered.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampledDCPolarography"></see></summary>
    let SampledDCPolarography = _prefix "SampledDCPolarography"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningAugerElectronMicroscopy"></see>
    /// </summary>
    let ScanningAugerElectronMicroscopy = _prefix "ScanningAugerElectronMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningKelvinProbe"></see>
    /// </summary>
    let ScanningKelvinProbe = _prefix "ScanningKelvinProbe"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningProbeMicroscopy"></see>
    /// </summary>
    let ScanningProbeMicroscopy = _prefix "ScanningProbeMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningTunnelingMicroscopy"></see>
    /// </summary>
    let ScanningTunnelingMicroscopy = _prefix "ScanningTunnelingMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryIonMassSpectrometry"></see>
    /// </summary>
    let SecondaryIonMassSpectrometry = _prefix "SecondaryIonMassSpectrometry"
    /// <summary>
    ///
    /// Most instruments show plots of the current at the end of the forward-going pulse and of the backward-going pulse vs. the potential, as well as their difference. This can give valuable information on the kinetics of the electrode reaction and the electrode process.
    /// The current is sampled just before the end of the forward- going pulse and of the backward-going pulse and the difference of the two sampled currents is plotted versus the applied potential of the potential or staircase ramp. The square-wave voltammogram is peak-shaped
    /// The sensitivity of SWV depends on the reversibility of the electrode reaction of the analyte.
    /// <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SquareWaveVoltammetry"></see></summary>
    let SquareWaveVoltammetry = _prefix "SquareWaveVoltammetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Synchrotron"></see>
    /// </summary>
    let Synchrotron = _prefix "Synchrotron"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermogravimetry"></see>
    /// </summary>
    let Thermogravimetry = _prefix "Thermogravimetry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TransmissionElectronMicroscopy"></see>
    /// </summary>
    let TransmissionElectronMicroscopy = _prefix "TransmissionElectronMicroscopy"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ultrasonic"></see>
    /// </summary>
    let Ultrasonic = _prefix "Ultrasonic"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VaporPressureDepressionOsmometry"></see>
    /// </summary>
    let VaporPressureDepressionOsmometry = _prefix "VaporPressureDepressionOsmometry"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Viscometry"></see>
    /// </summary>
    let Viscometry = _prefix "Viscometry"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VoltammetryAtARotatingDiskElectrode"></see>
    /// </summary>
    let VoltammetryAtARotatingDiskElectrode =
        _prefix "VoltammetryAtARotatingDiskElectrode"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XpsVariableKinetic"></see>
    /// </summary>
    let XpsVariableKinetic = _prefix "XpsVariableKinetic"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XrdGrazingIncidence"></see>
    /// </summary>
    let XrdGrazingIncidence = _prefix "XrdGrazingIncidence"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#characterisationProcedureHasSubProcedure"></see>
    /// </summary>
    let characterisationProcedureHasSubProcedure =
        _prefix "characterisationProcedureHasSubProcedure"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasAccessConditions"></see>
    /// </summary>
    let hasAccessConditions = _prefix "hasAccessConditions"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironment"></see>
    /// </summary>
    let hasCharacterisationEnvironment = _prefix "hasCharacterisationEnvironment"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironmentProperty"></see>
    /// </summary>
    let hasCharacterisationEnvironmentProperty =
        _prefix "hasCharacterisationEnvironmentProperty"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProcedureValidation"></see>
    /// </summary>
    let hasCharacterisationProcedureValidation =
        _prefix "hasCharacterisationProcedureValidation"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProperty"></see>
    /// </summary>
    let hasCharacterisationProperty = _prefix "hasCharacterisationProperty"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationSoftware"></see>
    /// </summary>
    let hasCharacterisationSoftware = _prefix "hasCharacterisationSoftware"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataAcquisitionRate"></see>
    /// </summary>
    let hasDataAcquisitionRate = _prefix "hasDataAcquisitionRate"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataProcessingThroughCalibration"></see>
    /// </summary>
    let hasDataProcessingThroughCalibration =
        _prefix "hasDataProcessingThroughCalibration"

    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataQuality"></see>
    /// </summary>
    let hasDataQuality = _prefix "hasDataQuality"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataset"></see>
    /// </summary>
    let hasDataset = _prefix "hasDataset"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHardwareSpecification"></see>
    /// </summary>
    let hasHardwareSpecification = _prefix "hasHardwareSpecification"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHazard"></see>
    /// </summary>
    let hasHazard = _prefix "hasHazard"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHolder"></see>
    /// </summary>
    let hasHolder = _prefix "hasHolder"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionVolume"></see>
    /// </summary>
    let hasInteractionVolume = _prefix "hasInteractionVolume"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithProbe"></see>
    /// </summary>
    let hasInteractionWithProbe = _prefix "hasInteractionWithProbe"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithSample"></see>
    /// </summary>
    let hasInteractionWithSample = _prefix "hasInteractionWithSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLab"></see>
    /// </summary>
    let hasLab = _prefix "hasLab"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLevelOfAutomation"></see>
    /// </summary>
    let hasLevelOfAutomation = _prefix "hasLevelOfAutomation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementDetector"></see>
    /// </summary>
    let hasMeasurementDetector = _prefix "hasMeasurementDetector"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementParameter"></see>
    /// </summary>
    let hasMeasurementParameter = _prefix "hasMeasurementParameter"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementProbe"></see>
    /// </summary>
    let hasMeasurementProbe = _prefix "hasMeasurementProbe"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementSample"></see>
    /// </summary>
    let hasMeasurementSample = _prefix "hasMeasurementSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementTime"></see>
    /// </summary>
    let hasMeasurementTime = _prefix "hasMeasurementTime"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasOperator"></see>
    /// </summary>
    let hasOperator = _prefix "hasOperator"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPeerReviewedArticle"></see>
    /// </summary>
    let hasPeerReviewedArticle = _prefix "hasPeerReviewedArticle"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPhysicsOfInteraction"></see>
    /// </summary>
    let hasPhysicsOfInteraction = _prefix "hasPhysicsOfInteraction"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPostProcessingModel"></see>
    /// </summary>
    let hasPostProcessingModel = _prefix "hasPostProcessingModel"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasProcessingReproducibility"></see>
    /// </summary>
    let hasProcessingReproducibility = _prefix "hasProcessingReproducibility"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampleBeforeSamplePreparation"></see>
    /// </summary>
    let hasSampleBeforeSamplePreparation = _prefix "hasSampleBeforeSamplePreparation"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationHardware"></see>
    /// </summary>
    let hasSamplePreparationHardware = _prefix "hasSamplePreparationHardware"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationInput"></see>
    /// </summary>
    let hasSamplePreparationInput = _prefix "hasSamplePreparationInput"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationOutput"></see>
    /// </summary>
    let hasSamplePreparationOutput = _prefix "hasSamplePreparationOutput"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationParameter"></see>
    /// </summary>
    let hasSamplePreparationParameter = _prefix "hasSamplePreparationParameter"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampledSample"></see>
    /// </summary>
    let hasSampledSample = _prefix "hasSampledSample"
    /// <summary>
    ///   <see href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#requiresLevelOfExpertise"></see>
    /// </summary>
    let requiresLevelOfExpertise = _prefix "requiresLevelOfExpertise"
