#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module chameo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/emmo/domain/characterisation-methodology/chameo#" "chameo"

    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The resulting alternating current is plotted versus imposed DC potential. The obtained AC voltammogram is peak-shaped.</para>
    ///   <para>rdfs:label : ACVoltammetry</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q120895154^^xsd:string</para>
    ///   <para>skos:prefLabel : ACVoltammetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : voltammetry in which a sinusoidal alternating potential of small amplitude (10 to 50 mV) of constant frequency (10 Hz to 100 kHz) is superimposed on a slowly and linearly varying potential ramp</para>
    ///   <para>skos:altLabel : ACV</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ACVoltammetry">chameo:ACVoltammetry</a>
    /// </summary>
    let ACVoltammetry = _prefixId.prefix "ACVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : AbrasiveStrippingVoltammetry</para>
    ///   <para>rdfs:label : AbrasiveStrippingVoltammetry</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : electrochemical method where traces of solid particles are abrasively transferred onto the surface of an electrode, followed by an electrochemical dissolution (anodic or cathodic dissolution) that is recorded as a current–voltage curve</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical method where traces of solid particles are abrasively transferred onto the surface of an electrode, followed by an electrochemical dissolution (anodic or cathodic dissolution) that is recorded as a current–voltage curve</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AbrasiveStrippingVoltammetry">chameo:AbrasiveStrippingVoltammetry</a>
    /// </summary>
    let AbrasiveStrippingVoltammetry = _prefixId.prefix "AbrasiveStrippingVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : AccessConditions</para>
    ///   <para>rdfs:label : AccessConditions</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Was the access to your sample preparation an inhouse routine or required a 3rd party service?emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Was the access to your characterisation tool an inhouse routine or required a 3rd party service?emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In case of national or international facilities such as synchrotrons describe the programme that enabled you to access these.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Describes what is needed to repeat the experiment</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AccessConditions">chameo:AccessConditions</a>
    /// </summary>
    let AccessConditions = _prefixId.prefix "AccessConditions"

    /// <summary>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>skos:prefLabel : AdsorptiveStrippingVoltammetry</para>
    ///   <para>skos:altLabel : AdSV</para>
    ///   <para>rdfs:comment : AdSV is usually employed for analysis of organic compounds or metal complexes with organic ligands. Stripping is done by means of an anodic or a cathodic voltammetric scan (linear or pulse), during which the adsorbed compound is oxidized or reduced.rdfs:comment : ^^xsd:stringrdfs:comment : A peak-shaped adsorptive stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Stripping voltammetry involving pre-concentration by adsorption of the analyte (in contrast to electro- chemical accumulation).</para>
    ///   <para>rdfs:label : AdsorptiveStrippingVoltammetry</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AdsorptiveStrippingVoltammetry">chameo:AdsorptiveStrippingVoltammetry</a>
    /// </summary>
    let AdsorptiveStrippingVoltammetry =
        _prefixId.prefix "AdsorptiveStrippingVoltammetry"

    /// <summary>
    ///   <para>skos:prefLabel : AlphaSpectrometry</para>
    ///   <para>rdfs:label : AlphaSpectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Alpha spectrometry (also known as alpha(-particle) spectroscopy) is the quantitative study of the energy of alpha particles emitted by a radioactive nuclide that is an alpha emitter. As emitted alpha particles are mono-energetic (i.e. not emitted with a spectrum of energies, such as beta decay) with energies often distinct to the decay they can be used to identify which radionuclide they originated from.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AlphaSpectrometry">chameo:AlphaSpectrometry</a>
    /// </summary>
    let AlphaSpectrometry = _prefixId.prefix "AlphaSpectrometry"
    /// <summary>
    ///   <para>rdfs:comment : Amperometry can be distinguished from voltammetry by the parameter being controlled (electrode potential E) and the parameter being measured (electrode current I which is usually a function of time – see chronoamperometry).rdfs:comment : The current is usually faradaic and the applied potential is usually constant.rdfs:comment : ^^xsd:stringrdfs:comment : The integral of current with time is the electric charge, which may be related to the amount of substance reacted by Faraday’s laws of electrolysis.rdfs:comment : In a non-stirred solution, a diffusion-limited current is usually measured, which is propor-tional to the concentration of an electroactive analyte.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The amperometric method provides the ability to distinguish selectively between a number of electroactive species in solution by judicious selection of the applied potential and/or choice of electrode material.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>rdfs:label : Amperometry</para>
    ///   <para>skos:prefLabel : Amperometry</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Amperometry">chameo:Amperometry</a>
    /// </summary>
    let Amperometry = _prefixId.prefix "Amperometry"
    /// <summary>
    ///   <para>skos:prefLabel : AnalyticalElectronMicroscopy</para>
    ///   <para>rdfs:label : AnalyticalElectronMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Analytical electron microscopy (AEM) refers to the collection of spectroscopic data in TEM or STEM, enabling qualitative or quantitative compositional analysis.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnalyticalElectronMicroscopy">chameo:AnalyticalElectronMicroscopy</a>
    /// </summary>
    let AnalyticalElectronMicroscopy = _prefixId.prefix "AnalyticalElectronMicroscopy"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : A peak-shaped anodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.rdfs:comment : A solid electrode, carbon paste or composite electrode, bismuth film electrode, mercury film electrode, or static mercury drop electrode may be used.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Stripping voltammetry in which material accumulated at the working electrode is electrochemically oxi- dized in the stripping step.</para>
    ///   <para>skos:prefLabel : AnodicStrippingVoltammetry</para>
    ///   <para>rdfs:label : AnodicStrippingVoltammetry</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q939328^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AnodicStrippingVoltammetry">chameo:AnodicStrippingVoltammetry</a>
    /// </summary>
    let AnodicStrippingVoltammetry = _prefixId.prefix "AnodicStrippingVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : AtomProbeTomography</para>
    ///   <para>rdfs:label : AtomProbeTomography</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : APT^^xsd:stringskos:altLabel : 3D Atom Probe^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Atom Probe Tomography (APT or 3D Atom Probe) is the only material analysis technique offering extensive capabilities for both 3D imaging and chemical composition measurements at the atomic scale (around 0.1-0.3nm resolution in depth and 0.3-0.5nm laterally). Since its early developments, Atom Probe Tomography has contributed to major advances in materials science.
    ///
    /// The sample is prepared in the form of a very sharp tip. The cooled tip is biased at high DC voltage (3-15 kV). The very small radius of the tip and the High Voltage induce a very high electrostatic field (tens V/nm) at the tip surface, just below the point of atom evaporation. Under laser or HV pulsing, one or more atoms are evaporated from the surface, by field effect (near 100% ionization), and projected onto a Position Sensitive Detector (PSD) with a very high detection efficiency. Ion efficiencies are as high as 80%, the highest analytical efficiency of any 3D microscopy.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomProbeTomography">chameo:AtomProbeTomography</a>
    /// </summary>
    let AtomProbeTomography = _prefixId.prefix "AtomProbeTomography"
    /// <summary>
    ///   <para>skos:prefLabel : AtomicForceMicroscopy</para>
    ///   <para>rdfs:label : AtomicForceMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Atomic force microscopy (AFM) is an influential surface analysis technique used for micro/nanostructured coatings. This flexible technique can be used to obtain high-resolution nanoscale images and study local sites in air (conventional AFM) or liquid (electrochemical AFM) surroundings.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#AtomicForceMicroscopy">chameo:AtomicForceMicroscopy</a>
    /// </summary>
    let AtomicForceMicroscopy = _prefixId.prefix "AtomicForceMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : CalibrationData</para>
    ///   <para>rdfs:label : CalibrationData</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Calibration data are used to provide correction of measured data or perform uncertainty calculations. They are generally the result of a measuerement on a reference specimen.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationData">chameo:CalibrationData</a>
    /// </summary>
    let CalibrationData = _prefixId.prefix "CalibrationData"
    /// <summary>
    ///   <para>skos:prefLabel : CalibrationDataPostProcessing</para>
    ///   <para>rdfs:label : CalibrationDataPostProcessing</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Post-processing of the output of the calibration in order to get the actual calibration data to be used as input for the measurement.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationDataPostProcessing">chameo:CalibrationDataPostProcessing</a>
    /// </summary>
    let CalibrationDataPostProcessing = _prefixId.prefix "CalibrationDataPostProcessing"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:prefLabel : CalibrationProcess</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In nanoindentation, the electrical signal coming from capacitive displacement gauge is converted into a real raw-displacement signal after using a proper calibration function (as obtained by the equipment manufacturer). Then, additional calibration procedures are applied to define the point of initial contact and to correct for instrument compliance, thermal drift, and indenter area function to obtain the real useable displacement data.</para>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Operation performed on a measuring instrument or a measuring system that, under specified conditions
    /// 1. establishes a relation between the values with measurement uncertainties provided by measurement standards and corresponding indications with associated measurement uncertainties and
    /// 2. uses this information to establish a relation for obtaining a measurement result from an indication
    /// NOTE 1 The objective of calibration is to provide traceability of measurement results obtained when using a calibrated measuring instrument or measuring system.
    /// NOTE 2 The outcome of a calibration may be expressed by a statement, calibration function, calibration diagram, calibration curve, or calibration table. In some cases, it may consist of an additive or multiplicative correction of the indication with associated measurement uncertainty.
    /// NOTE 3 Calibration should not be confused with adjustment of a measuring system, often mistakenly called “selfcalibration”, nor with verification of calibration. Calibration is sometimes a prerequisite for verification, which provides confirmation that specified requirements (often maximum permissible errors) are met. Calibration is sometimes also a prerequisite for adjustment, which is the set of operations carried out on a measuring system such that the system provides prescribed indications corresponding to given values of quantities being measured, typically obtained from
    /// measurement standards.
    /// NOTE 4 Sometimes the first step alone of the operation mentioned in the definition is intended as being calibration, as it was in previous editions of this Vocabulary. The second step is in fact required to establish instrumental uncertainty
    /// for the measurement results obtained when using the calibrated measuring system. The two steps together aim to demonstrate the metrological traceability of measurement results obtained by a calibrated measuring system. In the
    /// past the second step was usually considered to occur after the calibration.
    /// NOTE 5 A comparison between two measurement standards may be viewed as a calibration if the comparison is used to check and, if necessary, correct the value and measurement uncertainty attributed to one of the measurement
    /// standards.
    ///
    /// -- International Vocabulary of Metrology(VIM)</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : Usually the calibration process involve  a reference sample (with pre-defined, specific, and stable physical characteristics and known properties), in order to extract calibration data. In this way, the accuracy of the measurement tool and its components (for example the probe) will be evaluated and confirmed.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Sequence of operations/actions that are needed to convert the initial signal (as produced by the detector) into a meaningful and useable raw data.</para>
    ///   <para>rdfs:label : CalibrationProcess</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationProcess">chameo:CalibrationProcess</a>
    /// </summary>
    let CalibrationProcess = _prefixId.prefix "CalibrationProcess"
    /// <summary>
    ///   <para>skos:prefLabel : CalibrationTask^^xsd:string</para>
    ///   <para>rdfs:label : CalibrationTask^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Single calibration Task  that is part of a Calibration Process Workflow.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CalibrationTask">chameo:CalibrationTask</a>
    /// </summary>
    let CalibrationTask = _prefixId.prefix "CalibrationTask"
    /// <summary>
    ///   <para>skos:prefLabel : Calorimetry</para>
    ///   <para>rdfs:label : Calorimetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : In chemistry and thermodynamics, calorimetry (from Latin calor 'heat', and Greek μέτρον (metron) 'measure') is the science or act of measuring changes in state variables of a body for the purpose of deriving the heat transfer associated with changes of its state due, for example, to chemical reactions, physical changes, or phase transitions under specified constraints. Calorimetry is performed with a calorimeter.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Calorimetry">chameo:Calorimetry</a>
    /// </summary>
    let Calorimetry = _prefixId.prefix "Calorimetry"
    /// <summary>
    ///   <para>skos:altLabel : CSV</para>
    ///   <para>rdfs:comment : A peak-shaped cathodic stripping voltammogram is obtained. Peak current depends on time of accumulation, mass transport of analyte (stirring), scan rate and mode (linear or pulse), and analyte concentration in solution.rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:prefLabel : CathodicStrippingVoltammetry</para>
    ///   <para>rdfs:label : CathodicStrippingVoltammetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : stripping voltammetry in which material accumulated at the working electrode is electrochemically reduced in the stripping step</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q4016325^^xsd:string</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CathodicStrippingVoltammetry">chameo:CathodicStrippingVoltammetry</a>
    /// </summary>
    let CathodicStrippingVoltammetry = _prefixId.prefix "CathodicStrippingVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationData^^xsd:string</para>
    ///   <para>rdfs:label : CharacterisationData^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Represents every type of data that is produced during a characterisation process</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationData">chameo:CharacterisationData</a>
    /// </summary>
    let CharacterisationData = _prefixId.prefix "CharacterisationData"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationDataValidation</para>
    ///   <para>rdfs:label : CharacterisationDataValidation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Procedures to validate the characterisation data.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationDataValidation">chameo:CharacterisationDataValidation</a>
    /// </summary>
    let CharacterisationDataValidation =
        _prefixId.prefix "CharacterisationDataValidation"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationEnvironment</para>
    ///   <para>rdfs:label : CharacterisationEnvironment</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : Characterisation can either be made in air (ambient conditions, without specific controls on environmental parameters), or at different temperatures, different pressures (or in vacuum), or using different types of working gases (inert or reactive with respect to sample), different levels of humidity, etc.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Medium of the characterisation experiment defined by the set of environmental conditions that are controlled and measured over time during the experiment.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironment">chameo:CharacterisationEnvironment</a>
    /// </summary>
    let CharacterisationEnvironment = _prefixId.prefix "CharacterisationEnvironment"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationEnvironmentProperty^^xsd:string</para>
    ///   <para>rdfs:label : CharacterisationEnvironmentProperty^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationEnvironmentProperty">chameo:CharacterisationEnvironmentProperty</a>
    /// </summary>
    let CharacterisationEnvironmentProperty =
        _prefixId.prefix "CharacterisationEnvironmentProperty"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationExperiment</para>
    ///   <para>rdfs:label : CharacterisationExperiment</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A characterisation experiment is the process by which a material's structure and properties are probed and measured. It is a fundamental process in the field of materials science, without which no scientific understanding of engineering materials could be ascertained.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationExperiment">chameo:CharacterisationExperiment</a>
    /// </summary>
    let CharacterisationExperiment = _prefixId.prefix "CharacterisationExperiment"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationHardware</para>
    ///   <para>rdfs:label : CharacterisationHardware</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Whatever hardware is used during the characterisation process.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardware">chameo:CharacterisationHardware</a>
    /// </summary>
    let CharacterisationHardware = _prefixId.prefix "CharacterisationHardware"

    /// <summary>
    ///   <para>skos:prefLabel : HardwareManufacturer</para>
    ///   <para>rdfs:label : HardwareManufacturer</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareManufacturer">chameo:CharacterisationHardwareManufacturer</a>
    /// </summary>
    let CharacterisationHardwareManufacturer =
        _prefixId.prefix "CharacterisationHardwareManufacturer"

    /// <summary>
    ///   <para>skos:prefLabel : HardwareModel</para>
    ///   <para>rdfs:label : HardwareModel</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareModel">chameo:CharacterisationHardwareModel</a>
    /// </summary>
    let CharacterisationHardwareModel = _prefixId.prefix "CharacterisationHardwareModel"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationHardwareSpecification</para>
    ///   <para>rdfs:label : CharacterisationHardwareSpecification</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationHardwareSpecification">chameo:CharacterisationHardwareSpecification</a>
    /// </summary>
    let CharacterisationHardwareSpecification =
        _prefixId.prefix "CharacterisationHardwareSpecification"

    /// <summary>
    ///   <para>emmo:EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6 : Measuring instrument</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : CharacterisationInstrument^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The instrument used for characterising a material, which usually has a probe and a detector as parts.</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In nanoindentation is the nanoindenter^^xsd:string</para>
    ///   <para>skos:prefLabel : CharacterisationInstrument^^xsd:string</para>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Device used for making measurements, alone or in conjunction with one or more supplementary
    /// devices
    /// NOTE 1 A measuring instrument that can be used alone for making measurements is a measuring system.
    /// NOTE 2 A measuring instrument is either an indicating measuring instrument or a material measure.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationInstrument">chameo:CharacterisationInstrument</a>
    /// </summary>
    let CharacterisationInstrument = _prefixId.prefix "CharacterisationInstrument"

    /// <summary>
    ///   <para>emmo:EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6 : Measurement</para>
    ///   <para>rdfs:label : CharacterisationMeasurementProcess</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The measurement process associates raw data to the sample  through a probe and a detector.</para>
    ///   <para>skos:prefLabel : CharacterisationMeasurementProcess</para>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Process of experimentally obtaining one or more values that can reasonably be attributed to a quantity together with any other available relevant information
    /// NOTE 1 The quantity mentioned in the definition is an individual quantity.
    /// NOTE 2 The relevant information mentioned in the definition may be about the values obtained by the measurement,
    /// such that some may be more representative of the measurand than others.
    /// NOTE 3 Measurement is sometimes considered to apply to nominal properties, but not in this Vocabulary, where the
    /// process of obtaining values of nominal properties is called “examination”.
    /// NOTE 4 Measurement requires both experimental comparison of quantities or experimental counting of entities at
    /// some step of the process and the use of models and calculations that are based on conceptual considerations.
    /// NOTE 5 The conditions of reasonable attribution mentioned in the definition take into account a description of the
    /// quantity commensurate with the intended use of a measurement result, a measurement procedure, and a calibrated
    /// measuring system operating according to the specified measurement procedure, including the measurement
    /// conditions. Moreover, a maximum permissible error and/or a target uncertainty may be specified, and the
    /// measurement procedure and the measuring system should then be chosen in order not to exceed these measuring
    /// system specifications.
    ///
    /// -- International Vocabulary of Metrology(VIM)</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementProcess">chameo:CharacterisationMeasurementProcess</a>
    /// </summary>
    let CharacterisationMeasurementProcess =
        _prefixId.prefix "CharacterisationMeasurementProcess"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationMeasurementTask</para>
    ///   <para>rdfs:label : CharacterisationMeasurementTask</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Single calibration Task  that is part of a Characterisation Measurement Process Workflow.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMeasurementTask">chameo:CharacterisationMeasurementTask</a>
    /// </summary>
    let CharacterisationMeasurementTask =
        _prefixId.prefix "CharacterisationMeasurementTask"

    /// <summary>
    ///   <para>skos:altLabel : Characterisation techniqueskos:altLabel : Characterisation procedure</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:prefLabel : CharacterisationMethod</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The description of the overall characterisation method. It can be composed of different steps (e.g. sample preparation, calibration, measurement, post-processing).</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : A characterisation method is not only related to the measurement process which can be one of its steps.^^xsd:string</para>
    ///   <para>rdfs:label : CharacterisationMethod</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationMethod">chameo:CharacterisationMethod</a>
    /// </summary>
    let CharacterisationMethod = _prefixId.prefix "CharacterisationMethod"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationProcedure</para>
    ///   <para>rdfs:label : CharacterisationProcedure</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : Characterisation procedure may refer to the full characterisation process or just a part of the full process.</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Sample preparation
    /// Sample inspection
    /// Calibration
    /// Microscopy
    /// Viscometry
    /// Data sampling</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The process of performing characterisation by following some existing formalised operative rules.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedure">chameo:CharacterisationProcedure</a>
    /// </summary>
    let CharacterisationProcedure = _prefixId.prefix "CharacterisationProcedure"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationProcedureValidation</para>
    ///   <para>rdfs:label : CharacterisationProcedureValidation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Describes why the characterization procedure was chosen and deemed to be the most useful for the sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProcedureValidation">chameo:CharacterisationProcedureValidation</a>
    /// </summary>
    let CharacterisationProcedureValidation =
        _prefixId.prefix "CharacterisationProcedureValidation"

    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationProperty</para>
    ///   <para>rdfs:label : CharacterisationProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The characterisation property is the investigate property or behaviour of a sample. It is derived from the secondary data, usually after classification or quantification (manually or by a model).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProperty">chameo:CharacterisationProperty</a>
    /// </summary>
    let CharacterisationProperty = _prefixId.prefix "CharacterisationProperty"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationProtocol</para>
    ///   <para>rdfs:label : CharacterisationProtocol</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A characterisation protocol is defined whenever it is desirable to standardize a laboratory method to ensure successful replication of results by others in the same laboratory or by other laboratories.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationProtocol">chameo:CharacterisationProtocol</a>
    /// </summary>
    let CharacterisationProtocol = _prefixId.prefix "CharacterisationProtocol"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationSoftware^^xsd:string</para>
    ///   <para>rdfs:label : CharacterisationSoftware^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In Nanoindentation post-processing the software used to apply the Oliver-Pharr to calculate the characterisation properties (i.e. elastic modulus, hardness) from load and depth data.^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A software application to process characterisation data</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSoftware">chameo:CharacterisationSoftware</a>
    /// </summary>
    let CharacterisationSoftware = _prefixId.prefix "CharacterisationSoftware"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationSystem</para>
    ///   <para>rdfs:label : CharacterisationSystem</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6 : Measuring system</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A set of one or more 'CharacterisationInstruments' and often other devices, including any sample holder, reagent and supply, assembled and adapted to give information used to generate 'MeasuredQuantityProperty' within specified intervals for quantities of specified kinds.</para>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Set of one or more measuring instruments and often other components, assembled and
    /// adapted to give information used to generate measured values within specified intervals for
    /// quantities of specified kinds
    /// NOTE 1 The components mentioned in the definition may be devices, reagents, and supplies.
    /// NOTE 2 A measuring system is sometimes referred to as “measuring equipment” or “device”, for example in ISO 10012,
    /// Measurement management systems – Requirements for measurement processes and measuring equipment and ISO
    /// 17025, General requirements for the competence of testing and calibration laboratories.
    /// NOTE 3 Although the terms “measuring system” and “measurement system” are frequently used synonymously, the
    /// latter is instead sometimes used to refer to a measuring system plus all other entities involved in a measurement,
    /// including the object under measurement and the person(s) performing the measurement.
    /// NOTE 4 A measuring system can be used as a measurement standard.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationSystem">chameo:CharacterisationSystem</a>
    /// </summary>
    let CharacterisationSystem = _prefixId.prefix "CharacterisationSystem"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationTask</para>
    ///   <para>rdfs:label : CharacterisationTask</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationTask">chameo:CharacterisationTask</a>
    /// </summary>
    let CharacterisationTask = _prefixId.prefix "CharacterisationTask"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisationWorkflow</para>
    ///   <para>rdfs:label : CharacterisationWorkflow</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A characterisation procedure that has at least two characterisation tasks as proper parts.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisationWorkflow">chameo:CharacterisationWorkflow</a>
    /// </summary>
    let CharacterisationWorkflow = _prefixId.prefix "CharacterisationWorkflow"
    /// <summary>
    ///   <para>skos:prefLabel : CharacterisedSample^^xsd:string</para>
    ///   <para>rdfs:label : CharacterisedSample^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The sample after having been subjected to a characterization process</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CharacterisedSample">chameo:CharacterisedSample</a>
    /// </summary>
    let CharacterisedSample = _prefixId.prefix "CharacterisedSample"
    /// <summary>
    ///   <para>skos:prefLabel : ChargeDistribution</para>
    ///   <para>rdfs:label : ChargeDistribution</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ChargeDistribution">chameo:ChargeDistribution</a>
    /// </summary>
    let ChargeDistribution = _prefixId.prefix "ChargeDistribution"
    /// <summary>
    ///   <para>skos:prefLabel : Chromatography</para>
    ///   <para>rdfs:label : Chromatography</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Chromatography^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : In chemical analysis, chromatography is a laboratory technique for the separation of a mixture into its components.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chromatography">chameo:Chromatography</a>
    /// </summary>
    let Chromatography = _prefixId.prefix "Chromatography"
    /// <summary>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : amperometry in which the current is measured as a function of time after a change in the applied potential</para>
    ///   <para>skos:prefLabel : Chronoamperometry</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : If the potential step is from a potential at which no current flows (i.e., at which the oxidation or reduction of the electrochemically active species does not take place) to one at which the current is limited by diffusion (see diffusion-limited current), the current obeys the Cottrell equation.</para>
    ///   <para>rdfs:label : Chronoamperometry</para>
    ///   <para>skos:altLabel : AmperiometricDetectionskos:altLabel : AmperometricCurrentTimeCurve</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronoamperometry">chameo:Chronoamperometry</a>
    /// </summary>
    let Chronoamperometry = _prefixId.prefix "Chronoamperometry"
    /// <summary>
    ///   <para>skos:prefLabel : Chronocoulometry</para>
    ///   <para>rdfs:label : Chronocoulometry</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : Chronocoulometry provides the same information that is provided by chronoamperometry, since it is based on the integration of the I-t curve. Nevertheless, chronocoulometry offers important experimental advantages, such as (i) the measured signal usually increases with time and hence the later parts of the transient can be detected more accurately, (ii) a better signal-to-noise ratio can be achieved, and (iii) other contributions to overall charge passed as a function of time can be discriminated from those due to the diffusion of electroactive substances.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : direct coulometry at controlled potential in which the electric charge passed after the application of a potential step perturbation is measured as a function of time (Q-t curve)</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronocoulometry">chameo:Chronocoulometry</a>
    /// </summary>
    let Chronocoulometry = _prefixId.prefix "Chronocoulometry"
    /// <summary>
    ///   <para>skos:prefLabel : Chronopotentiometry</para>
    ///   <para>rdfs:label : Chronopotentiometry</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The change in applied current is usually a step, but cyclic current reversals or linearly increasing currents are also used.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : potentiometry in which the potential is measured with time following a change in applied current</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Chronopotentiometry">chameo:Chronopotentiometry</a>
    /// </summary>
    let Chronopotentiometry = _prefixId.prefix "Chronopotentiometry"
    /// <summary>
    ///   <para>skos:prefLabel : CompressionTest</para>
    ///   <para>rdfs:label : CompressionTest</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Compression tests characterize material and product strength and stiffness under applied crushing loads. These tests are typically conducted by applying compressive pressure to a test specimen using platens or specialized fixtures with a testing machine that produces compressive loads.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CompressionTest">chameo:CompressionTest</a>
    /// </summary>
    let CompressionTest = _prefixId.prefix "CompressionTest"
    /// <summary>
    ///   <para>rdfs:comment : The method can be used for deeply coloured or turbid solutions. Acid-base and precipita- tion reactions are most frequently used.rdfs:comment : The equivalence-point is obtained as the intersection of linear parts of the conductance G, versus titrant volume V, curve (seerdfs:comment : The method is based on replacing an ionic species of the analyte with another species, cor- responding to the titrant or the product with significantly different conductance.rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : titration in which the electric conductivity of a solution is measured as a function of the amount of titrant added</para>
    ///   <para>rdfs:label : ConductometricTitration</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>skos:prefLabel : ConductometricTitration</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q11778221^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConductometricTitration">chameo:ConductometricTitration</a>
    /// </summary>
    let ConductometricTitration = _prefixId.prefix "ConductometricTitration"
    /// <summary>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : measurement principle in which the electric conductivity of a solution is measured</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q901180^^xsd:string</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Monitoring of the purity of deionized water.</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The conductivity of a solution depends on the concentration and nature of ions present.</para>
    ///   <para>skos:prefLabel : Conductometry</para>
    ///   <para>rdfs:label : Conductometry</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Conductometry</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Conductometry">chameo:Conductometry</a>
    /// </summary>
    let Conductometry = _prefixId.prefix "Conductometry"
    /// <summary>
    ///   <para>skos:prefLabel : ConfocalMicroscopy</para>
    ///   <para>rdfs:label : ConfocalMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Confocal microscopy, most frequently confocal laser scanning microscopy (CLSM) or laser scanning confocal microscopy (LSCM), is an optical imaging technique for increasing optical resolution and contrast of a micrograph by means of using a spatial pinhole to block out-of-focus light in image formation.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ConfocalMicroscopy">chameo:ConfocalMicroscopy</a>
    /// </summary>
    let ConfocalMicroscopy = _prefixId.prefix "ConfocalMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : CoulometricTitration</para>
    ///   <para>rdfs:label : CoulometricTitration</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The main advantages are that titration is possible with less stable titrants, the standardi- zation of titrant is not necessary, the volume of the test solution is not changed, and the method is easily automated.rdfs:comment : Coulometric titrations are usually carried out in convective mass transfer mode using a large surface working electrode. The reference and auxiliary electrodes are located in sepa- rate compartments. A basic requirement is a 100 % current efficiency of titrant generation at the working electrode. End-point detection can be accomplished with potentiometry, amperometry, biamperometry, bipotentiometry, photometry, or by using a visual indicator.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : titration in which the titrant is generated electrochemically, either by constant current or at constant potential. The titrant reacts stoichiometrically with the analyte, the amount of which is calculated using Faraday’s laws of electrolysis from the electric charge required to reach the end-point</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CoulometricTitration">chameo:CoulometricTitration</a>
    /// </summary>
    let CoulometricTitration = _prefixId.prefix "CoulometricTitration"
    /// <summary>
    ///   <para>emmo:EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f : https://www.electropedia.org/iev/iev.nsf/display?openform&amp;ievref=114-04-13^^xsd:string</para>
    ///   <para>rdfs:comment : The coulometric experiment can be carried out at controlled (constant) potential (see direct coulometry at controlled potential) or controlled (constant) current (see direct coulometry at controlled current).rdfs:comment : ^^xsd:stringrdfs:comment : Coulometry used to measure the amount of substance is a primary reference measurement procedure [VIM 2.8] not requiring calibration with a standard for a quantity of the same kind (i.e. amount of substance).</para>
    ///   <para>skos:prefLabel : Coulometry</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q1136979^^xsd:string</para>
    ///   <para>rdfs:label : Coulometry</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Coulometry</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical measurement principle in which the electric charge required to carry out a known electrochemical reaction is measured. By Faraday’s laws of electrolysis, the amount of substance is proportional to the charge</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Coulometry">chameo:Coulometry</a>
    /// </summary>
    let Coulometry = _prefixId.prefix "Coulometry"
    /// <summary>
    ///   <para>skos:prefLabel : CreepTest</para>
    ///   <para>rdfs:label : CreepTest</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The creep test is a destructive materials testing method for determination of the long-term strength and heat resistance of a material. When running a creep test, the specimen is subjected to increased temperature conditions for an extended period of time and loaded with a constant tensile force or tensile stress.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CreepTest">chameo:CreepTest</a>
    /// </summary>
    let CreepTest = _prefixId.prefix "CreepTest"

    /// <summary>
    ///   <para>skos:prefLabel : CriticalAndSupercriticalChromatography</para>
    ///   <para>rdfs:label : CriticalAndSupercriticalChromatography</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CriticalAndSupercriticalChromatography">chameo:CriticalAndSupercriticalChromatography</a>
    /// </summary>
    let CriticalAndSupercriticalChromatography =
        _prefixId.prefix "CriticalAndSupercriticalChromatography"

    /// <summary>
    ///   <para>skos:prefLabel : CyclicChronopotentiometry</para>
    ///   <para>rdfs:label : CyclicChronopotentiometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : chronopotentiometry where the change in applied current undergoes a cyclic current reversal</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicChronopotentiometry">chameo:CyclicChronopotentiometry</a>
    /// </summary>
    let CyclicChronopotentiometry = _prefixId.prefix "CyclicChronopotentiometry"
    /// <summary>
    ///   <para>emmo:EMMO_6dd685dd_1895_46e4_b227_be9f7d643c25 : https://dbpedia.org/page/Cyclic_voltammetry^^xsd:anyURI</para>
    ///   <para>skos:altLabel : CV</para>
    ///   <para>rdfs:comment : The plot of current against potential is termed a cyclic voltammogram. Usually peak-shaped responses are obtained for scans in both directions.rdfs:comment : ^^xsd:stringrdfs:comment : Normally the initial potential is chosen where no electrode reaction occurs and the switch- ing potential is greater (more positive for an oxidation or more negative for a reduction) than the peak potential of the analyte reaction.rdfs:comment : The initial potential is usually the negative or positive limit of the cycle but can have any value between the two limits, as can the initial scan direction. The limits of the potential are known as the switching potentials.rdfs:comment : Cyclic voltammetry is frequently used for the investigation of mechanisms of electrochemi- cal/electrode reactions. The current-potential curve may be modelled to obtain reaction mechanisms and electrochemical parameters.</para>
    ///   <para>skos:prefLabel : CyclicVoltammetry</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q1147647^^xsd:string</para>
    ///   <para>rdfs:label : CyclicVoltammetry</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Cyclic_voltammetry^^xsd:anyURI</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : voltammetry in which the electric current is recorded as the electrode potential is varied with time cycli- cally between two potential limits, normally at a constant scan rate</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#CyclicVoltammetry">chameo:CyclicVoltammetry</a>
    /// </summary>
    let CyclicVoltammetry = _prefixId.prefix "CyclicVoltammetry"
    /// <summary>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>rdfs:comment : Usually the drop time is between 1 and 5 s and the pseudo-steady-state wave-shaped dependence on potential is called a polarogram. If the limiting current is controlled by dif- fusion, it is expressed by the Ilkovich equation.rdfs:comment : ^^xsd:stringrdfs:comment : If the whole scan is performed on a single growing drop, the technique should be called single drop scan voltammetry. The term polarography in this context is discouraged.rdfs:comment : This is the oldest variant of polarographic techniques, introduced by Jaroslav Heyrovský (1890 – 1967).</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : linear scan voltammetry with slow scan rate in which a dropping mercury electrode is used as the working electrode</para>
    ///   <para>skos:prefLabel : DCPolarography</para>
    ///   <para>rdfs:label : DCPolarography</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DCPolarography">chameo:DCPolarography</a>
    /// </summary>
    let DCPolarography = _prefixId.prefix "DCPolarography"
    /// <summary>
    ///   <para>skos:prefLabel : DataAcquisitionRate</para>
    ///   <para>rdfs:label : DataAcquisitionRate</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Quantify the raw data acquisition rate, if applicable.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAcquisitionRate">chameo:DataAcquisitionRate</a>
    /// </summary>
    let DataAcquisitionRate = _prefixId.prefix "DataAcquisitionRate"
    /// <summary>
    ///   <para>skos:prefLabel : DataAnalysis</para>
    ///   <para>rdfs:label : DataAnalysis</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Data processing activities performed on the secondary data to determine the characterisation property (e.g. classification, quantification), which can be performed manually or exploiting a model.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataAnalysis">chameo:DataAnalysis</a>
    /// </summary>
    let DataAnalysis = _prefixId.prefix "DataAnalysis"
    /// <summary>
    ///   <para>skos:prefLabel : DataFiltering</para>
    ///   <para>rdfs:label : DataFiltering</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Data filtering is the process of examining a dataset to exclude, rearrange, or apportion data according to certain criteria.^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataFiltering">chameo:DataFiltering</a>
    /// </summary>
    let DataFiltering = _prefixId.prefix "DataFiltering"
    /// <summary>
    ///   <para>skos:prefLabel : DataNormalisation</para>
    ///   <para>rdfs:label : DataNormalisation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : It involves the creation of shifted and/or scaled versions of the values to allow post-processing in a way that eliminates the effects of influences on subsequent properties extraction.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Data normalization involves adjusting raw data to a notionally common scale.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataNormalisation">chameo:DataNormalisation</a>
    /// </summary>
    let DataNormalisation = _prefixId.prefix "DataNormalisation"
    /// <summary>
    ///   <para>skos:prefLabel : DataPostProcessing</para>
    ///   <para>rdfs:label : DataPostProcessing</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Analysis, that allows one to calculate the final material property from the calibrated primary data.^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPostProcessing">chameo:DataPostProcessing</a>
    /// </summary>
    let DataPostProcessing = _prefixId.prefix "DataPostProcessing"
    /// <summary>
    ///   <para>skos:prefLabel : DataPreparation</para>
    ///   <para>rdfs:label : DataPreparation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Data preparation is the process of manipulating (or pre-processing) data (which may come from disparate data sources) to improve their quality or reduce bias in subsequent analysis.^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataPreparation">chameo:DataPreparation</a>
    /// </summary>
    let DataPreparation = _prefixId.prefix "DataPreparation"

    /// <summary>
    ///   <para>skos:prefLabel : DataProcessingThroughCalibration</para>
    ///   <para>rdfs:label : DataProcessingThroughCalibration</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Describes how raw data are corrected and/or modified through calibrations.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataProcessingThroughCalibration">chameo:DataProcessingThroughCalibration</a>
    /// </summary>
    let DataProcessingThroughCalibration =
        _prefixId.prefix "DataProcessingThroughCalibration"

    /// <summary>
    ///   <para>skos:prefLabel : DataQuality</para>
    ///   <para>rdfs:label : DataQuality</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Example evaluation of S/N ratio, or other quality indicators (limits of detection/quantification, statistical analysis of data, data robustness analysis)</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Evaluation of quality indicators to determine how well suited a data set is to be used for the characterisation of a material.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DataQuality">chameo:DataQuality</a>
    /// </summary>
    let DataQuality = _prefixId.prefix "DataQuality"
    /// <summary>
    ///   <para>skos:prefLabel : Detector</para>
    ///   <para>rdfs:label : Detector</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Displacement and force sensors for mechanical testingemmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Back Scattered Electrons (BSE) and Secondary Electrons (SE) detectors for SEM</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Physical device (or the chain of devices) that is used to measure, quantify and store the signal after its interaction with the sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Detector">chameo:Detector</a>
    /// </summary>
    let Detector = _prefixId.prefix "Detector"

    /// <summary>
    ///   <para>skos:prefLabel : DielectricAndImpedanceSpectroscopy</para>
    ///   <para>rdfs:label : DielectricAndImpedanceSpectroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Dielectric spectroscopy (DS) or impedance spectroscopy, also known as electrochemical impedance spectroscopy, is frequently used to study the response of a sample subjected to an applied electric field of fixed or changing frequency. DS describes the dielectric properties of a material as a function of frequency. In DS, the radio and microwave frequency regions of the electromagnetic spectrum have been successfully made to interact with materials, so as to study the behavior of molecules. The interaction of applied alternating electric fields with dipoles possessing reorientation mobility in materials is also dealt by DS.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DielectricAndImpedanceSpectroscopy">chameo:DielectricAndImpedanceSpectroscopy</a>
    /// </summary>
    let DielectricAndImpedanceSpectroscopy =
        _prefixId.prefix "DielectricAndImpedanceSpectroscopy"

    /// <summary>
    ///   <para>skos:prefLabel : Dielectrometry</para>
    ///   <para>rdfs:label : Dielectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The method is used to monitor the purity of dielectrics, for example to detect small amounts of moisture.rdfs:comment : Dielectrometric titrations use dielectrometry for the end-point detection.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical measurement principle based on the measurement of the dielectric constant of a sample resulting from the orientation of particles (molecules or ions) that have a dipole moment in an electric field</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dielectrometry">chameo:Dielectrometry</a>
    /// </summary>
    let Dielectrometry = _prefixId.prefix "Dielectrometry"

    /// <summary>
    ///   <para>skos:prefLabel : DifferentialLinearPulseVoltammetry</para>
    ///   <para>rdfs:label : DifferentialLinearPulseVoltammetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Differential Pulse Voltammetry in which small potential pulses are superimposed onto a linearly varying potential.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialLinearPulseVoltammetry">chameo:DifferentialLinearPulseVoltammetry</a>
    /// </summary>
    let DifferentialLinearPulseVoltammetry =
        _prefixId.prefix "DifferentialLinearPulseVoltammetry"

    /// <summary>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : voltammetry in which small potential pulses (constant height 10 to 100 mV, constant width 10 to 100 ms) are superimposed onto a linearly varying potential or onto a staircase potential ramp. The current is sampled just before the onset of the pulse (e.g. 10 to 20 ms) and for the same sampling time just before the end of the pulse. The difference between the two sampled currents is plotted versus the potential applied before the pulse. Thus, a differential pulse voltammogram is peak-shaped</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated in the same way as in normal pulse voltammetry (NPV). Moreover, subtraction of the charging current sampled before the application of the pulse further decreases its negative influence. Due to the more enhanced signal (faradaic current) to noise (charging current) ratio, the limit of detection is lower than with NPV.rdfs:comment : Differential pulse polarography is differential pulse voltammetry in which a dropping mercury electrode is used as the working electrode. A pulse is applied before the mechani- cally enforced end of the drop and the current is sampled twice: just before the onset of the pulse and just before its end. The pulse width is usually 10 to 20 % of the drop life. The drop dislodgement is synchronized with current sampling, which is carried out as in DPV.rdfs:comment : The sensitivity of DPV depends on the reversibility of the electrode reaction of the analyte.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>rdfs:label : DifferentialPulseVoltammetry</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q5275361^^xsd:string</para>
    ///   <para>skos:prefLabel : DifferentialPulseVoltammetry</para>
    ///   <para>skos:altLabel : DPV</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Differential_pulse_voltammetry</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialPulseVoltammetry">chameo:DifferentialPulseVoltammetry</a>
    /// </summary>
    let DifferentialPulseVoltammetry = _prefixId.prefix "DifferentialPulseVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : DifferentialRefractiveIndex</para>
    ///   <para>rdfs:label : DifferentialRefractiveIndex</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialRefractiveIndex">chameo:DifferentialRefractiveIndex</a>
    /// </summary>
    let DifferentialRefractiveIndex = _prefixId.prefix "DifferentialRefractiveIndex"

    /// <summary>
    ///   <para>skos:prefLabel : DifferentialScanningCalorimetry</para>
    ///   <para>rdfs:label : DifferentialScanningCalorimetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : DSC^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Differential scanning calorimetry (DSC) is a thermoanalytical technique in which the difference in the amount of heat required to increase the temperature of a sample and reference is measured as a function of temperature. Both the sample and reference are maintained at nearly the same temperature throughout the experiment. Generally, the temperature program for a DSC analysis is designed such that the sample holder temperature increases linearly as a function of time. The reference sample should have a well-defined heat capacity over the range of temperatures to be scanned. Additionally, the reference sample must be stable, of high purity, and must not experience much change across the temperature scan. Typically, reference standards have been metals such as indium, tin, bismuth, and lead, but other standards such as polyethylene and fatty acids have been proposed to study polymers and organic compounds, respectively.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialScanningCalorimetry">chameo:DifferentialScanningCalorimetry</a>
    /// </summary>
    let DifferentialScanningCalorimetry =
        _prefixId.prefix "DifferentialScanningCalorimetry"

    /// <summary>
    ///   <para>skos:prefLabel : DifferentialStaircasePulseVoltammetry</para>
    ///   <para>rdfs:label : DifferentialStaircasePulseVoltammetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Differential Pulse Voltammetry in which small potential pulses are superimposed onto a staircase potential ramp.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialStaircasePulseVoltammetry">chameo:DifferentialStaircasePulseVoltammetry</a>
    /// </summary>
    let DifferentialStaircasePulseVoltammetry =
        _prefixId.prefix "DifferentialStaircasePulseVoltammetry"

    /// <summary>
    ///   <para>skos:prefLabel : DifferentialThermalAnalysis</para>
    ///   <para>rdfs:label : DifferentialThermalAnalysis</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : DTA^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Differential thermal analysis (DTA) is a thermoanalytic technique that is similar to differential scanning calorimetry. In DTA, the material under study and an inert reference are made to undergo identical thermal cycles, (i.e., same cooling or heating programme) while recording any temperature difference between sample and reference.[1] This differential temperature is then plotted against time, or against temperature (DTA curve, or thermogram). Changes in the sample, either exothermic or endothermic, can be detected relative to the inert reference. Thus, a DTA curve provides data on the transformations that have occurred, such as glass transitions, crystallization, melting and sublimation. The area under a DTA peak is the enthalpy change and is not affected by the heat capacity of the sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DifferentialThermalAnalysis">chameo:DifferentialThermalAnalysis</a>
    /// </summary>
    let DifferentialThermalAnalysis = _prefixId.prefix "DifferentialThermalAnalysis"
    /// <summary>
    ///   <para>skos:prefLabel : Dilatometry</para>
    ///   <para>rdfs:label : Dilatometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:seeAlso : https://www.lboro.ac.uk/research/lmcc/facilities/dilatometry/#:~:text=Dilatometry%20is%20a%20method%20for,to%20mimic%20an%20industrial%20process.^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Dilatometry is a method for characterising the dimensional changes of materials with variation of temperature conditions.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Dilatometry">chameo:Dilatometry</a>
    /// </summary>
    let Dilatometry = _prefixId.prefix "Dilatometry"

    /// <summary>
    ///   <para>skos:prefLabel : DirectCoulometryAtControlledCurrent</para>
    ///   <para>rdfs:label : DirectCoulometryAtControlledCurrent</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The advantage of this method is that the electric charge consumed during the electrode reaction is directly proportional to the electrolysis time. Care must be taken to avoid the potential region where another electrode reaction may occur.rdfs:comment : Direct coulometry at controlled current is usually carried out in convective mass transfer mode. The end-point of the electrolysis, at which the current is stopped, must be determined either from the inflection point in the E–t curve or by using visual or objective end-point indi- cation, similar to volumetric methods. The total electric charge is calculated as the product of the constant current and time of electrolysis or can be measured directly using a coulometer.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : coulometry at an imposed, constant current in the electrochemical cell</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledCurrent">chameo:DirectCoulometryAtControlledCurrent</a>
    /// </summary>
    let DirectCoulometryAtControlledCurrent =
        _prefixId.prefix "DirectCoulometryAtControlledCurrent"

    /// <summary>
    ///   <para>skos:prefLabel : DirectCoulometryAtControlledPotential</para>
    ///   <para>rdfs:label : DirectCoulometryAtControlledPotential</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : In principle, the end point at which I = 0, i.e. when the concentration of species under study becomes zero, can be reached only at infinite time. However, in practice, the electrolysis is stopped when the current has decayed to a few percent of the initial value and the charge passed at infinite time is calculated from a plot of charge Q(t) against time t. For a simple system under diffusion control Qt= Q∞[1 − exp(−DAt/Vδ)], where Q∞ = limt→∞Q(t) is the total charge passed at infinite time, D is the diffusion coefficient of the electroactive species, A the electrode area, δ the diffusion layer thickness, and V the volume of the solution.rdfs:comment : Direct coulometry at controlled potential is usually carried out in convective mass trans- fer mode using a large surface working electrode. Reference and auxiliary electrodes are placed in separate compartments. The total electric charge is obtained by integration of the I–t curve or can be measured directly using a coulometer.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : coulometry at a preselected constant potential of the working electrode</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DirectCoulometryAtControlledPotential">chameo:DirectCoulometryAtControlledPotential</a>
    /// </summary>
    let DirectCoulometryAtControlledPotential =
        _prefixId.prefix "DirectCoulometryAtControlledPotential"

    /// <summary>
    ///   <para>skos:prefLabel : DynamicLightScattering</para>
    ///   <para>rdfs:label : DynamicLightScattering</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : DLS^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Dynamic light scattering (DLS) is a technique in physics that can be used to determine the size distribution profile of small particles in suspension or polymers in solution. In the scope of DLS, temporal fluctuations are usually analyzed using the intensity or photon auto-correlation function (also known as photon correlation spectroscopy - PCS or quasi-elastic light scattering - QELS).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicLightScattering">chameo:DynamicLightScattering</a>
    /// </summary>
    let DynamicLightScattering = _prefixId.prefix "DynamicLightScattering"
    /// <summary>
    ///   <para>skos:prefLabel : DynamicMechanicalAnalysis</para>
    ///   <para>rdfs:label : DynamicMechanicalAnalysis</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Dynamic mechanical analysis (abbreviated DMA) is a characterisation technique where a sinusoidal stress is applied and the strain in the material is measured, allowing one to determine the complex modulus. The temperature of the sample or the frequency of the stress are often varied, leading to variations in the complex modulus; this approach can be used to locate the glass transition temperature[1] of the material, as well as to identify transitions corresponding to other molecular motions.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalAnalysis">chameo:DynamicMechanicalAnalysis</a>
    /// </summary>
    let DynamicMechanicalAnalysis = _prefixId.prefix "DynamicMechanicalAnalysis"
    /// <summary>
    ///   <para>skos:prefLabel : DynamicMechanicalSpectroscopy</para>
    ///   <para>rdfs:label : DynamicMechanicalSpectroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : DMA^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Dynamic Mechanical Analysis (DMA) is a material characterization technique where a small deformation is applied to a sample in a cyclic manner. This allows measurement of the materials response to stress, temperature, frequency or time. The term is also used to refer to the analyzer that performs the test.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#DynamicMechanicalSpectroscopy">chameo:DynamicMechanicalSpectroscopy</a>
    /// </summary>
    let DynamicMechanicalSpectroscopy = _prefixId.prefix "DynamicMechanicalSpectroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : Electrochemical</para>
    ///   <para>rdfs:label : Electrochemical</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://dx.doi.org/10.1016/B978-0-323-46140-5.00002-9^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : In electrochemical characterization, the measurement of potential, charge, or current is used to determine an analyte's concentration or to characterize an analyte's chemical reactivity</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrochemical">chameo:Electrochemical</a>
    /// </summary>
    let Electrochemical = _prefixId.prefix "Electrochemical"

    /// <summary>
    ///   <para>rdfs:label : ElectrochemicalImpedanceSpectroscopy</para>
    ///   <para>rdfs:comment : The sinusoidal current response lags behind the sinusoidal voltage perturbation by a phase angle φ. Resistances (e.g. to charge transfer) give a response in phase with the voltage perturbation; capacitances (e.g. double layer) give a response 90° out of phase; combinations of resistances and capacitances give phase angles between 0 and 90°. Plots of the out of phase vs. the in phase component of the impedance for all the frequencies tested are called complex plane (or Nyquist) plots. Plots of the phase angle and the magnitude of the impedance vs. the logarithm of perturbation frequency are called Bode diagrams. Complex plane plots are the more commonly used for electrochemical sensors.rdfs:comment : Impedimetric sensors are based on measurement of a concentration-dependent parameter taken from analysis of the respective electrochemical impedance spectra, or from the impedance magnitudes at a chosen fixed frequency.rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : EIS</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical measurement method of the complex impedance of an electrochemical system as a function of the frequency of a small amplitude (normally 5 to 10 mV) sinusoidal voltage perturbation superimposed on a fixed value of applied potential or on the open circuit potential</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>skos:prefLabel : ElectrochemicalImpedanceSpectroscopy</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q3492904</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalImpedanceSpectroscopy">chameo:ElectrochemicalImpedanceSpectroscopy</a>
    /// </summary>
    let ElectrochemicalImpedanceSpectroscopy =
        _prefixId.prefix "ElectrochemicalImpedanceSpectroscopy"

    /// <summary>
    ///   <para>skos:prefLabel : ElectrochemicalPiezoelectricMicrogravimetry</para>
    ///   <para>rdfs:label : ElectrochemicalPiezoelectricMicrogravimetry</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The change of mass is, for rigid deposits, linearly proportional to the change of the reso- nance frequency of the quartz crystal, according to the Sauerbrey equation. For non- rigid deposits, corrections must be made.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Electrogravimetry using an electrochemical quartz crystal microbalance.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectrochemicalPiezoelectricMicrogravimetry">chameo:ElectrochemicalPiezoelectricMicrogravimetry</a>
    /// </summary>
    let ElectrochemicalPiezoelectricMicrogravimetry =
        _prefixId.prefix "ElectrochemicalPiezoelectricMicrogravimetry"

    /// <summary>
    ///   <para>skos:prefLabel : Electrogravimetry</para>
    ///   <para>rdfs:label : Electrogravimetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Electrogravimetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : method of electroanalytical chemistry used to separate by electrolyse ions of a substance and to derive the amount of this substance from the increase in mass of an electrode.</para>
    ///   <para>emmo:EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f : https://www.electropedia.org/iev/iev.nsf/display?openform&amp;ievref=114-04-14</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q902953^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Electrogravimetry">chameo:Electrogravimetry</a>
    /// </summary>
    let Electrogravimetry = _prefixId.prefix "Electrogravimetry"

    /// <summary>
    ///   <para>skos:prefLabel : ElectronBackscatterDiffraction</para>
    ///   <para>rdfs:label : ElectronBackscatterDiffraction</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : EBSD^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Electron backscatter diffraction (EBSD) is a scanning electron microscopy (SEM) technique used to study the crystallographic structure of materials. EBSD is carried out in a scanning electron microscope equipped with an EBSD detector comprising at least a phosphorescent screen, a compact lens and a low-light camera. In this configuration, the SEM incident beam hits the tilted sample. As backscattered electrons leave the sample, they interact with the crystal's periodic atomic lattice planes and diffract according to Bragg's law at various scattering angles before reaching the phosphor screen forming Kikuchi patterns (EBSPs). EBSD spatial resolution depends on many factors, including the nature of the material under study and the sample preparation. Thus, EBSPs can be indexed to provide information about the material's grain structure, grain orientation, and phase at the micro-scale. EBSD is applied for impurities and defect studies, plastic deformation, and statistical analysis for average misorientation, grain size, and crystallographic texture. EBSD can also be combined with energy-dispersive X-ray spectroscopy (EDS), cathodoluminescence (CL), and wavelength-dispersive X-ray spectroscopy (WDS) for advanced phase identification and materials discovery.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronBackscatterDiffraction">chameo:ElectronBackscatterDiffraction</a>
    /// </summary>
    let ElectronBackscatterDiffraction =
        _prefixId.prefix "ElectronBackscatterDiffraction"

    /// <summary>
    ///   <para>skos:prefLabel : ElectronProbeMicroanalysis</para>
    ///   <para>rdfs:label : ElectronProbeMicroanalysis</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Electron probe microanalysis (EPMA) is used for quantitative analysis of the elemental composition of solid specimens at a micrometer scale. The method uses bombardment of the specimen by keV electrons to excite characteristic X-rays from the sample, which are then detected by using wavelength-dispersive (WD) spectrometers.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ElectronProbeMicroanalysis">chameo:ElectronProbeMicroanalysis</a>
    /// </summary>
    let ElectronProbeMicroanalysis = _prefixId.prefix "ElectronProbeMicroanalysis"
    /// <summary>
    ///   <para>skos:prefLabel : Ellipsometry</para>
    ///   <para>rdfs:label : Ellipsometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Ellipsometry is an optical technique that uses polarised light to probe the dielectric
    /// properties of a sample (optical system). The common application of ellipsometry is
    /// the analysis of thin films. Through the analysis of the state of polarisation of the
    /// light that is reflected from the sample, ellipsometry yields information on the layers that are thinner than the wavelength of the light itself, down to a single atomic
    /// layer or less. Depending on what is already known about the sample, the technique
    /// can probe a range of properties including layer thickness, morphology, and chemical composition.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ellipsometry">chameo:Ellipsometry</a>
    /// </summary>
    let Ellipsometry = _prefixId.prefix "Ellipsometry"

    /// <summary>
    ///   <para>skos:prefLabel : EnvironmentalScanningElectronMicroscopy</para>
    ///   <para>rdfs:label : EnvironmentalScanningElectronMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The environmental scanning electron microscope (ESEM) is a scanning electron microscope (SEM) that allows for the option of collecting electron micrographs of specimens that are wet, uncoated, or both by allowing for a gaseous environment in the specimen chamber.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#EnvironmentalScanningElectronMicroscopy">chameo:EnvironmentalScanningElectronMicroscopy</a>
    /// </summary>
    let EnvironmentalScanningElectronMicroscopy =
        _prefixId.prefix "EnvironmentalScanningElectronMicroscopy"

    /// <summary>
    ///   <para>skos:prefLabel : Exafs</para>
    ///   <para>rdfs:label : Exafs</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Extended X-ray absorption fine structure (EXAFS), along with X-ray absorption near edge structure (XANES), is a subset of X-ray absorption spectroscopy (XAS). Like other absorption spectroscopies, XAS techniques follow Beer's law. The X-ray absorption coefficient of a material as a function of energy is obtained by directing X-rays of a narrow energy range at a sample, while recording the incident and transmitted x-ray intensity, as the incident x-ray energy is incremented.
    /// When the incident x-ray energy matches the binding energy of an electron of an atom within the sample, the number of x-rays absorbed by the sample increases dramatically, causing a drop in the transmitted x-ray intensity. This results in an absorption edge. Every element has a set of unique absorption edges corresponding to different binding energies of its electrons, giving XAS element selectivity. XAS spectra are most often collected at synchrotrons because of the high intensity of synchrotron X-ray sources allow the concentration of the absorbing element to reach as low as a few parts per million. Absorption would be undetectable if the source is too weak. Because X-rays are highly penetrating, XAS samples can be gases, solids or liquids.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Exafs">chameo:Exafs</a>
    /// </summary>
    let Exafs = _prefixId.prefix "Exafs"
    /// <summary>
    ///   <para>skos:prefLabel : FatigueTesting</para>
    ///   <para>rdfs:label : FatigueTesting</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Fatigue testing is a specialised form of mechanical testing that is performed by applying cyclic loading to a coupon or structure. These tests are used either to generate fatigue life and crack growth data, identify critical locations or demonstrate the safety of a structure that may be susceptible to fatigue.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FatigueTesting">chameo:FatigueTesting</a>
    /// </summary>
    let FatigueTesting = _prefixId.prefix "FatigueTesting"
    /// <summary>
    ///   <para>skos:prefLabel : FibDic^^xsd:string</para>
    ///   <para>rdfs:label : FibDic^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : FIBDICResidualStressAnalysis^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The FIB-DIC (Focused Ion Beam - Digital Image Correlation) ring-core technique is a powerful method for measuring residual stresses in materials. It is based on milling a ring-shaped sample, or core, from the material of interest using a focused ion beam (FIB).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FibDic">chameo:FibDic</a>
    /// </summary>
    let FibDic = _prefixId.prefix "FibDic"

    /// <summary>
    ///   <para>skos:prefLabel : FieldEmissionScanningElectronMicroscopy</para>
    ///   <para>rdfs:label : FieldEmissionScanningElectronMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : FE-SEM^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Field emission scanning electron microscopy (FE-SEM) is an advanced technology used to capture the microstructure image of the materials. FE-SEM is typically performed in a high vacuum because gas molecules tend to disturb the electron beam and the emitted secondary and backscattered electrons used for imaging.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FieldEmissionScanningElectronMicroscopy">chameo:FieldEmissionScanningElectronMicroscopy</a>
    /// </summary>
    let FieldEmissionScanningElectronMicroscopy =
        _prefixId.prefix "FieldEmissionScanningElectronMicroscopy"

    /// <summary>
    ///   <para>skos:prefLabel : Fractography</para>
    ///   <para>rdfs:label : Fractography</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Fractography is the study of fracture surfaces in order to determine the relation between the microstructure and the mechanism(s) of crack initiation and propagation and, eventually, the root cause of the fracture .Fractography qualitatively interprets the mechanisms of fracture that occur in a sample by microscopic examination of fracture surface morpholog.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Fractography">chameo:Fractography</a>
    /// </summary>
    let Fractography = _prefixId.prefix "Fractography"

    /// <summary>
    ///   <para>skos:prefLabel : FreezingPointDepressionOsmometry</para>
    ///   <para>rdfs:label : FreezingPointDepressionOsmometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The general principle of freezing point depression osmometry involves the relationship between the number of moles of dissolved solute in a solution and the change in freezing point.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#FreezingPointDepressionOsmometry">chameo:FreezingPointDepressionOsmometry</a>
    /// </summary>
    let FreezingPointDepressionOsmometry =
        _prefixId.prefix "FreezingPointDepressionOsmometry"

    /// <summary>
    ///   <para>skos:prefLabel : GITT</para>
    ///   <para>rdfs:label : GITT</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : GalvanostaticIntermittentTitrationTechnique</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical method that applies current pulses to an electrochemical cell at rest and measures the voltage response</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q120906986^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GITT">chameo:GITT</a>
    /// </summary>
    let GITT = _prefixId.prefix "GITT"
    /// <summary>
    ///   <para>skos:prefLabel : GammaSpectrometry</para>
    ///   <para>rdfs:label : GammaSpectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Gamma-ray spectroscopy is the qualitative study of the energy spectra of gamma-ray sources, such as in the nuclear industry, geochemical investigation, and astrophysics.[1] Gamma-ray spectrometry, on the other hand, is the method used to acquire a quantitative spectrum measurement.[2]
    ///
    /// Most radioactive sources produce gamma rays, which are of various energies and intensities. When these emissions are detected and analyzed with a spectroscopy system, a gamma-ray energy spectrum can be produced.
    ///
    /// A detailed analysis of this spectrum is typically used to determine the identity and quantity of gamma emitters present in a gamma source, and is a vital tool in radiometric assay. The gamma spectrum is characteristic of the gamma-emitting nuclides contained in the source, just like in an optical spectrometer, the optical spectrum is characteristic of the material contained in a sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#GammaSpectrometry">chameo:GammaSpectrometry</a>
    /// </summary>
    let GammaSpectrometry = _prefixId.prefix "GammaSpectrometry"
    /// <summary>
    ///   <para>skos:prefLabel : HPPC</para>
    ///   <para>rdfs:label : HPPC</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : HybridPulsePowerCharacterizationskos:altLabel : HybridPulsePowerCharacterisation</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical method that measures the voltage drop of a cell resulting from a square wave current load</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HPPC">chameo:HPPC</a>
    /// </summary>
    let HPPC = _prefixId.prefix "HPPC"
    /// <summary>
    ///   <para>skos:prefLabel : HardnessTesting</para>
    ///   <para>rdfs:label : HardnessTesting</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A test to determine the resistance a material exhibits to permanent deformation by penetration of another harder material.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HardnessTesting">chameo:HardnessTesting</a>
    /// </summary>
    let HardnessTesting = _prefixId.prefix "HardnessTesting"
    /// <summary>
    ///   <para>skos:prefLabel : Hazard</para>
    ///   <para>rdfs:label : Hazard</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Set of inherent properties of a substance, mixture of substances, or a process involving substances that, under production, usage, or disposal conditions, make it capable of causing adverse effects to organisms or the environment, depending on the degree of exposure; in other words, it is a source of danger.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Hazard">chameo:Hazard</a>
    /// </summary>
    let Hazard = _prefixId.prefix "Hazard"
    /// <summary>
    ///   <para>skos:prefLabel : Holder</para>
    ///   <para>rdfs:label : Holder</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : An object which supports the specimen in the correct position for the characterisation process.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Holder">chameo:Holder</a>
    /// </summary>
    let Holder = _prefixId.prefix "Holder"
    /// <summary>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Hydrodynamic_voltammetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : voltammetry with forced flow of the solution towards the electrode surface</para>
    ///   <para>rdfs:label : HydrodynamicVoltammetry</para>
    ///   <para>rdfs:comment : A linear potential scan, at sufficiently slow scan rates so as to ensure a steady state response, is usually applied.rdfs:comment : Mass transport of a redox species enhanced by convection in this way results in a greater electric current. Convective mass transfer occurs up to the diffusion-limiting layer, within which the mass transfer is controlled by diffusion. Electroactive substance depletion outside the diffusion layer is annulled by convective mass transfer, which results in steady- state sigmoidal wave-shaped current-potential curves.rdfs:comment : ^^xsd:stringrdfs:comment : The forced flow can be accomplished by movement either of the solution (solution stirring, or channel flow), or of the electrode (electrode rotation or vibration).</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q17028237^^xsd:string</para>
    ///   <para>skos:prefLabel : HydrodynamicVoltammetry</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#HydrodynamicVoltammetry">chameo:HydrodynamicVoltammetry</a>
    /// </summary>
    let HydrodynamicVoltammetry = _prefixId.prefix "HydrodynamicVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : ICI</para>
    ///   <para>rdfs:label : ICI</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : IntermittentCurrentInterruptionMethod</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : electrochemical method that measures the voltage response of an electrochemical cell under galvanostatic conditions to short interruptions in the current</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ICI">chameo:ICI</a>
    /// </summary>
    let ICI = _prefixId.prefix "ICI"
    /// <summary>
    ///   <para>skos:prefLabel : Impedimetry</para>
    ///   <para>rdfs:label : Impedimetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : measurement principle in which the complex electric impedance of a system is measured, usually as a function of a small amplitude sinusoidal electrode potential</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Impedimetry">chameo:Impedimetry</a>
    /// </summary>
    let Impedimetry = _prefixId.prefix "Impedimetry"
    /// <summary>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In Scanning Electron Microscopy (SEM), the interaction volume is the volume of material that interacts directly with the incident electron beam, is usually much smaller than the entire specimen’s volume, and can be computed by using proper models. The interaction between the scanning probe and the sample generates a series of detectable signals (back scattered electrons, secondary electrons, x-rays, specimen current, etc.) which contain information on sample morphology, microstructure, composition, etc.emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In x-ray diffraction, the interaction volume is the volume of material that interacts directly with the x-ray beam and is usually smaller than the volume of the entire specimen. Depending on sample’s structure and microstructure, the interaction between the sample and the x-ray incident beam generates a secondary (reflected) beam that is measured by a detector and contains information on certain sample’s properties (e.g., crystallographic structure, phase composition, grain size, residual stress, …).</para>
    ///   <para>rdfs:label : InteractionVolume</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : In some cases, (like tribological characterisations) the “sample” can also be the “probe”. When analysing a system of samples that interact each other, finding a clear definition can become a complex problem.emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : It is important to note that, in some cases, the volume of interaction could be different from the volume of detectable signal emission. Example: in Scanning Electron Microscopy (SEM), the volume of interaction between the electron probe and the material is different from the volumes that generate the captured signal.</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The volume of material, and the surrounding environment, that interacts with the probe and generate a detectable (measurable) signal (information).</para>
    ///   <para>skos:prefLabel : InteractionVolume</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#InteractionVolume">chameo:InteractionVolume</a>
    /// </summary>
    let InteractionVolume = _prefixId.prefix "InteractionVolume"
    /// <summary>
    ///   <para>skos:prefLabel : IntermediateSample</para>
    ///   <para>rdfs:label : IntermediateSample</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IntermediateSample">chameo:IntermediateSample</a>
    /// </summary>
    let IntermediateSample = _prefixId.prefix "IntermediateSample"
    /// <summary>
    ///   <para>skos:prefLabel : IonChromatography</para>
    ///   <para>rdfs:label : IonChromatography</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Ion_chromatography^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Ion chromatography (or ion-exchange chromatography) is a form of chromatography that separates ions and ionizable polar molecules based on their affinity to the ion exchanger.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonChromatography">chameo:IonChromatography</a>
    /// </summary>
    let IonChromatography = _prefixId.prefix "IonChromatography"
    /// <summary>
    ///   <para>skos:prefLabel : IonMobilitySpectrometry</para>
    ///   <para>rdfs:label : IonMobilitySpectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : IMS^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Ion mobility spectrometry (IMS) It is a method of conducting analytical research that separates and identifies ionized molecules present in the gas phase based on the mobility of the molecules in a carrier buffer gas. Even though it is used extensively for military or security objectives, such as detecting drugs and explosives, the technology also has many applications in laboratory analysis, including studying small and big biomolecules. IMS instruments are extremely sensitive stand-alone devices, but are often coupled with mass spectrometry, gas chromatography or high-performance liquid chromatography in order to achieve a multi-dimensional separation. They come in various sizes, ranging from a few millimeters to several meters depending on the specific application, and are capable of operating under a broad range of conditions. IMS instruments such as microscale high-field asymmetric-waveform ion mobility spectrometry can be palm-portable for use in a range of applications including volatile organic compound (VOC) monitoring, biological sample analysis, medical diagnosis and food quality monitoring.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IonMobilitySpectrometry">chameo:IonMobilitySpectrometry</a>
    /// </summary>
    let IonMobilitySpectrometry = _prefixId.prefix "IonMobilitySpectrometry"
    /// <summary>
    ///   <para>skos:prefLabel : IsothermalMicrocalorimetry</para>
    ///   <para>rdfs:label : IsothermalMicrocalorimetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : IMC^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Isothermal microcalorimetry (IMC) is a laboratory method for real-time monitoring and dynamic analysis of chemical, physical and biological processes. Over a period of hours or days, IMC determines the onset, rate, extent and energetics of such processes for specimens in small ampoules (e.g. 3–20 ml) at a constant set temperature (c. 15 °C–150 °C).
    ///
    /// IMC accomplishes this dynamic analysis by measuring and recording vs. elapsed time the net rate of heat flow (μJ/s = μW) to or from the specimen ampoule, and the cumulative amount of heat (J) consumed or produced.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#IsothermalMicrocalorimetry">chameo:IsothermalMicrocalorimetry</a>
    /// </summary>
    let IsothermalMicrocalorimetry = _prefixId.prefix "IsothermalMicrocalorimetry"
    /// <summary>
    ///   <para>skos:prefLabel : Laboratory^^xsd:string</para>
    ///   <para>rdfs:label : Laboratory^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The laboratory where the whole characterisation process or some of its stages take place.^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Laboratory">chameo:Laboratory</a>
    /// </summary>
    let Laboratory = _prefixId.prefix "Laboratory"
    /// <summary>
    ///   <para>skos:prefLabel : LevelOfAutomation</para>
    ///   <para>rdfs:label : LevelOfAutomation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Describes the level of automation of the test.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfAutomation">chameo:LevelOfAutomation</a>
    /// </summary>
    let LevelOfAutomation = _prefixId.prefix "LevelOfAutomation"
    /// <summary>
    ///   <para>skos:prefLabel : LevelOfExpertise</para>
    ///   <para>rdfs:label : LevelOfExpertise</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Describes the level of expertise required to carry out a process (the entire test or the data processing).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LevelOfExpertise">chameo:LevelOfExpertise</a>
    /// </summary>
    let LevelOfExpertise = _prefixId.prefix "LevelOfExpertise"
    /// <summary>
    ///   <para>skos:prefLabel : LightScattering</para>
    ///   <para>rdfs:label : LightScattering</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Light scattering is the way light behaves when it interacts with a medium that contains particles or the boundary between different mediums where defects or structures are present. It is different than the effects of refraction, where light undergoes a change in index of refraction as it passes from one medium to another, or reflection, where light reflects back into the same medium, both of which are governed by Snell’s law. Light scattering can be caused by factors such as the nature, texture, or specific structures of a surface and the presence of gas, liquid, or solid particles through which light propagates, as well as the nature of the light itself, of its wavelengths and polarization states. It usually results in diffuse light and can also affect the dispersion of color.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LightScattering">chameo:LightScattering</a>
    /// </summary>
    let LightScattering = _prefixId.prefix "LightScattering"
    /// <summary>
    ///   <para>skos:prefLabel : LinearChronopotentiometry</para>
    ///   <para>rdfs:label : LinearChronopotentiometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : chronopotentiometry where the applied current is changed linearly</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearChronopotentiometry">chameo:LinearChronopotentiometry</a>
    /// </summary>
    let LinearChronopotentiometry = _prefixId.prefix "LinearChronopotentiometry"
    /// <summary>
    ///   <para>rdfs:comment : LSV corresponds to the first half cycle of cyclic voltammetry.rdfs:comment : The scan is usually started at a potential where no electrode reaction occurs.rdfs:comment : ^^xsd:stringrdfs:comment : The peak current is expressed by the Randles-Ševčík equation.</para>
    ///   <para>skos:altLabel : LinearSweepVoltammetryskos:altLabel : LinearPolarizationskos:altLabel : LSV</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Linear_sweep_voltammetry^^xsd:anyURI</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q620700^^xsd:string</para>
    ///   <para>skos:prefLabel : LinearScanVoltammetry</para>
    ///   <para>rdfs:label : LinearScanVoltammetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Voltammetry in which the current is recorded as the electrode potential is varied linearly with time.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#LinearScanVoltammetry">chameo:LinearScanVoltammetry</a>
    /// </summary>
    let LinearScanVoltammetry = _prefixId.prefix "LinearScanVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : MassSpectrometry</para>
    ///   <para>rdfs:label : MassSpectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Mass spectrometry is a powerful analytical technique used to quantify known materials, to identify unknown compounds within a sample, and to elucidate the structure and chemical properties of different molecules.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MassSpectrometry">chameo:MassSpectrometry</a>
    /// </summary>
    let MassSpectrometry = _prefixId.prefix "MassSpectrometry"
    /// <summary>
    ///   <para>skos:prefLabel : MeasurementDataPostProcessing</para>
    ///   <para>rdfs:label : MeasurementDataPostProcessing</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In nanoindentation testing, this is the Oliver-Pharr method, which allows calculating the elastic modulus and hardness of the sample by using the load and depth measured signals.emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Analysis of SEM (or optical) images to gain additional information (image filtering/integration/averaging, microstructural analysis, grain size evaluation, Digital Image Correlation procedures, etc.)</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Application of a post-processing model to signals through a software, in order to calculate the final characterisation property.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementDataPostProcessing">chameo:MeasurementDataPostProcessing</a>
    /// </summary>
    let MeasurementDataPostProcessing = _prefixId.prefix "MeasurementDataPostProcessing"
    /// <summary>
    ///   <para>skos:prefLabel : MeasurementParameter</para>
    ///   <para>rdfs:label : MeasurementParameter</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Describes the main input parameters that are needed to acquire the signal</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementParameter">chameo:MeasurementParameter</a>
    /// </summary>
    let MeasurementParameter = _prefixId.prefix "MeasurementParameter"
    /// <summary>
    ///   <para>skos:prefLabel : MeasurementSystemAdjustment^^xsd:string</para>
    ///   <para>rdfs:label : MeasurementSystemAdjustment^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6 : Adjustment</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Activity which has the goal of adjusting/tuning a measing instrument, without performing a measurement on a reference sample (which is a calibration).
    /// The output of this process can be a specific measurement parameter to be used in the characteriasation measurement process.</para>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Set of operations carried out on a measuring system so that it provides prescribed indications corresponding to given values of a quantity being measured
    /// NOTE 1 If there is any doubt that the context in which the term is being used is that of metrology, the long form
    /// “adjustment of a measuring system” might be used.
    /// NOTE 2 Types of adjustment of a measuring system include zero adjustment, offset adjustment, and span adjustment
    /// (sometimes called “gain adjustment”).
    /// NOTE 3 Adjustment of a measuring system should not be confused with calibration, which is sometimes a prerequisite
    /// for adjustment.
    /// NOTE 4 After an adjustment of a measuring system, the measuring system must usually be recalibrated.
    ///
    /// -- International Vocabulary of Metrology(VIM)</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementSystemAdjustment">chameo:MeasurementSystemAdjustment</a>
    /// </summary>
    let MeasurementSystemAdjustment = _prefixId.prefix "MeasurementSystemAdjustment"
    /// <summary>
    ///   <para>skos:prefLabel : MeasurementTime</para>
    ///   <para>rdfs:label : MeasurementTime</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The overall time needed to acquire the measurement data</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MeasurementTime">chameo:MeasurementTime</a>
    /// </summary>
    let MeasurementTime = _prefixId.prefix "MeasurementTime"
    /// <summary>
    ///   <para>skos:prefLabel : Mechanical</para>
    ///   <para>rdfs:label : Mechanical</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Mechanical_testing^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Mechanical testing covers a wide range of tests, which can be divided broadly into two types:
    /// 1. those that aim to determine a material's mechanical properties, independent of geometry.
    /// 2. those that determine the response of a structure to a given action, e.g. testing of composite beams, aircraft structures to destruction, etc.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Mechanical">chameo:Mechanical</a>
    /// </summary>
    let Mechanical = _prefixId.prefix "Mechanical"
    /// <summary>
    ///   <para>skos:prefLabel : MembraneOsmometry</para>
    ///   <para>rdfs:label : MembraneOsmometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : In the membrane osmometry technique, a pure solvent and polymer solution are separated by a semipermeable membrane, due to the higher chemical potential of the solvent in the pure solvent than in polymer solution, the solvent starts moving towards the polymer solution.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#MembraneOsmometry">chameo:MembraneOsmometry</a>
    /// </summary>
    let MembraneOsmometry = _prefixId.prefix "MembraneOsmometry"
    /// <summary>
    ///   <para>skos:prefLabel : Microscopy</para>
    ///   <para>rdfs:label : Microscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Microscopy is a category of characterization techniques which probe and map the surface and sub-surface structure of a material. These techniques can use photons, electrons, ions or physical cantilever probes to gather data about a sample's structure on a range of length scales.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Microscopy">chameo:Microscopy</a>
    /// </summary>
    let Microscopy = _prefixId.prefix "Microscopy"
    /// <summary>
    ///   <para>skos:prefLabel : Nanoindentation</para>
    ///   <para>rdfs:label : Nanoindentation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : By definition, when someone performs nanoindentation, it refers to either quasistatic or continuous stiffness measurement. However, in reality with a nanoindenter it is also possible to perform scratch testing, scanning probe microscopy, and apply non-contact surface energy mapping, which can also be called nanoindentation, because they are measurements conducted using an nanoindenter.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Nanoindentation (known also as nanoindentation test) is a method for testing the hardness and related mechanical properties of materials, facilitated by high-precision instrumentation in the nanometer scale, as well as analytical and computational algorithms for result evaluation.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nanoindentation">chameo:Nanoindentation</a>
    /// </summary>
    let Nanoindentation = _prefixId.prefix "Nanoindentation"
    /// <summary>
    ///   <para>skos:prefLabel : NeutronSpinEchoSpectroscopy</para>
    ///   <para>rdfs:label : NeutronSpinEchoSpectroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : NSE^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Neutron spin echo spectroscopy is a high resolution inelastic neutron scattering method probing nanosecond dynamics. Neutron spin echo (NSE) spectroscopy uses the precession of neutron spins in a magnetic field to measure the energy transfer at the sample and decouples the energy resolution from beam characteristics like monochromatisation and collimation.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NeutronSpinEchoSpectroscopy">chameo:NeutronSpinEchoSpectroscopy</a>
    /// </summary>
    let NeutronSpinEchoSpectroscopy = _prefixId.prefix "NeutronSpinEchoSpectroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : Nexafs</para>
    ///   <para>rdfs:label : Nexafs</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Near edge X-ray absorption fine structure (NEXAFS), also known as X-ray absorption near edge structure (XANES), is a type of absorption spectroscopy that indicates the features in the X-ray absorption spectra (XAS) of condensed matter due to the photoabsorption cross section for electronic transitions from an atomic core level to final states in the energy region of 50–100 eV above the selected atomic core level ionization energy, where the wavelength of the photoelectron is larger than the interatomic distance between the absorbing atom and its first neighbour atoms.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Nexafs">chameo:Nexafs</a>
    /// </summary>
    let Nexafs = _prefixId.prefix "Nexafs"
    /// <summary>
    ///   <para>rdfs:label : NormalPulseVoltammetry</para>
    ///   <para>skos:altLabel : NPV</para>
    ///   <para>rdfs:comment : Sigmoidal wave-shaped voltammograms are obtained.rdfs:comment : The current is sampled at the end of the pulse and then plotted versus the potential of the pulse.rdfs:comment : The sensitivity of NPV is not affected by the reversibility of the electrode reaction of the analyte.rdfs:comment : ^^xsd:stringrdfs:comment : Normal pulse polarography is NPV in which a dropping mercury electrode is used as the working electrode. A pulse is applied just before the mechanically enforced end of the drop. The pulse width is usually 10 to 20 % of the drop time. The drop dislodgment is synchro- nized with current sampling, which is carried out just before the end of the pulse, as in NPV.rdfs:comment : The current is sampled just before the end of the pulse, when the charging current is greatly diminished. In this way, the ratio of faradaic current to charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detec- tion is lowered.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : voltammetry in which potential pulses of amplitude increasing by a constant increment and with a pulse width of 2 to 200 ms are superimposed on a constant initial potential</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>skos:prefLabel : NormalPulseVoltammetry</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NormalPulseVoltammetry">chameo:NormalPulseVoltammetry</a>
    /// </summary>
    let NormalPulseVoltammetry = _prefixId.prefix "NormalPulseVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : NuclearMagneticResonance</para>
    ///   <para>rdfs:label : NuclearMagneticResonance</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : NMR^^xsd:stringskos:altLabel : Magnetic resonance spectroscopy (MRS)^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Nuclear magnetic resonance spectroscopy, most commonly known as NMR spectroscopy or magnetic resonance spectroscopy (MRS), is a spectroscopic technique to observe local magnetic fields around atomic nuclei. This spectroscopy is based on the measurement of absorption of electromagnetic radiations in the radio frequency region from roughly 4 to 900 MHz. Absorption of radio waves in the presence of magnetic field is accompanied by a special type of nuclear transition, and for this reason, such type of spectroscopy is known as Nuclear Magnetic Resonance Spectroscopy. The sample is placed in a magnetic field and the NMR signal is produced by excitation of the nuclei sample with radio waves into nuclear magnetic resonance, which is detected with sensitive radio receivers. The intramolecular magnetic field around an atom in a molecule changes the resonance frequency, thus giving access to details of the electronic structure of a molecule and its individual functional groups. As the fields are unique or highly characteristic to individual compounds, in modern organic chemistry practice, NMR spectroscopy is the definitive method to identify monomolecular organic compounds.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#NuclearMagneticResonance">chameo:NuclearMagneticResonance</a>
    /// </summary>
    let NuclearMagneticResonance = _prefixId.prefix "NuclearMagneticResonance"
    /// <summary>
    ///   <para>skos:prefLabel : OpenCircuitHold</para>
    ///   <para>rdfs:label : OpenCircuitHold</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : OCVHold</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : a process in which the electric current is kept constant at 0 (i.e., open-circuit conditions)</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpenCircuitHold">chameo:OpenCircuitHold</a>
    /// </summary>
    let OpenCircuitHold = _prefixId.prefix "OpenCircuitHold"
    /// <summary>
    ///   <para>skos:prefLabel : Operator</para>
    ///   <para>rdfs:label : Operator</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The human operator who takes care of the whole characterisation method or sub-processes/stages.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Operator">chameo:Operator</a>
    /// </summary>
    let Operator = _prefixId.prefix "Operator"
    /// <summary>
    ///   <para>skos:prefLabel : Optical</para>
    ///   <para>rdfs:label : Optical</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Optical">chameo:Optical</a>
    /// </summary>
    let Optical = _prefixId.prefix "Optical"
    /// <summary>
    ///   <para>skos:prefLabel : OpticalMicroscopy</para>
    ///   <para>rdfs:label : OpticalMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Optical microscopy is a technique used to closely view a sample through the magnification of a lens with visible light</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#OpticalMicroscopy">chameo:OpticalMicroscopy</a>
    /// </summary>
    let OpticalMicroscopy = _prefixId.prefix "OpticalMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : Osmometry</para>
    ///   <para>rdfs:label : Osmometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Osmometry is an advanced analytical method for determining the osmotic concentration of solutions. The osmotic – or solute – concentration of a colloidal system is expressed in osmoles (Osm) per unit of volume (Osm/L) or weight (Osm/kg).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Osmometry">chameo:Osmometry</a>
    /// </summary>
    let Osmometry = _prefixId.prefix "Osmometry"
    /// <summary>
    ///   <para>skos:prefLabel : PhotoluminescenceMicroscopy</para>
    ///   <para>rdfs:label : PhotoluminescenceMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Photoluminescence spectroscopy is a widely used technique for characterisation of the optical and electronic properties of semiconductors and molecules.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhotoluminescenceMicroscopy">chameo:PhotoluminescenceMicroscopy</a>
    /// </summary>
    let PhotoluminescenceMicroscopy = _prefixId.prefix "PhotoluminescenceMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : PhysicsOfInteraction</para>
    ///   <para>rdfs:label : PhysicsOfInteraction</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In x-ray diffraction, this is represented by the set of physics equations that describe the relation between the incident x-ray beam and the diffracted beam (the most simple form for this being the Bragg’s law).</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Set of physics principles (and associated governing equations) that describes the interaction between the sample and the probe.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PhysicsOfInteraction">chameo:PhysicsOfInteraction</a>
    /// </summary>
    let PhysicsOfInteraction = _prefixId.prefix "PhysicsOfInteraction"
    /// <summary>
    ///   <para>skos:prefLabel : PostProcessingModel</para>
    ///   <para>rdfs:label : PostProcessingModel</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : The PostProcessingModel use is mainly intended to get secondary data from primary data.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Mathematical model used to process data.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PostProcessingModel">chameo:PostProcessingModel</a>
    /// </summary>
    let PostProcessingModel = _prefixId.prefix "PostProcessingModel"

    /// <summary>
    ///   <para>rdfs:comment : the stripping potentiogram shows staircase curves of potential as a function of time. Frequently, the first derivative is displayed (dE/dt=f(t)), as this produces peak-shaped signals. The time between transitions (peaks) is proportional to the concentration of analyte in the test solutionrdfs:comment : ^^xsd:stringrdfs:comment : historically for the analysis of metal ions, mercury ions were added to the test solution to form a mercury amalgam when reduced. Alternatively, an HMDE or MFE was used and the oxidizing agent added after amalgam formation. However, the toxicity of mercury and its compounds have all but precluded the present-day use of mercuryrdfs:comment : the accumulation is similar to that used in stripping voltammetryrdfs:comment : the time between changes in potential in step 2 is related to the concentration of analyte in the solution</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : two-step electrochemical measurement in which 1) material is accumulated at an electrode and 2) the material is removed by chemical reaction or electrochemically at constant current with measurement of electrode potential</para>
    ///   <para>skos:prefLabel : PotentiometricStrippingAnalysis</para>
    ///   <para>rdfs:label : PotentiometricStrippingAnalysis</para>
    ///   <para>skos:altLabel : PSA</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PotentiometricStrippingAnalysis">chameo:PotentiometricStrippingAnalysis</a>
    /// </summary>
    let PotentiometricStrippingAnalysis =
        _prefixId.prefix "PotentiometricStrippingAnalysis"

    /// <summary>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Potentiometric methods are used to measure the electrochemical potentials of a metallic structure in a given environment.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>rdfs:label : Potentiometry</para>
    ///   <para>emmo:EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f : https://www.electropedia.org/iev/iev.nsf/display?openform&amp;ievref=114-04-12^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : For measurements using ion-selective electrodes, the measurement is made under equi- librium conditions what means that the macroscopic electric current is zero and the con- centrations of all species are uniform throughout the solution. The indicator electrode is in direct contact with the analyte solution, whereas the reference electrode is usually separated from the analyte solution by a salt bridge. The potential difference between the indicator and reference electrodes is normally directly proportional to the logarithm of the activity (concentration) of the analyte in the solution (Nernst equation). See also ion selec- tive electrode.rdfs:comment : Method of electroanalytical chemistry based on measurement of an electrode potential.</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q900632^^xsd:string</para>
    ///   <para>skos:prefLabel : Potentiometry</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Potentiometry">chameo:Potentiometry</a>
    /// </summary>
    let Potentiometry = _prefixId.prefix "Potentiometry"
    /// <summary>
    ///   <para>skos:prefLabel : PreparedSample^^xsd:string</para>
    ///   <para>rdfs:label : PreparedSample^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The sample after a preparation process.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PreparedSample">chameo:PreparedSample</a>
    /// </summary>
    let PreparedSample = _prefixId.prefix "PreparedSample"
    /// <summary>
    ///   <para>skos:prefLabel : PrimaryData</para>
    ///   <para>rdfs:label : PrimaryData</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : X and Y axes correctionemmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Noise reductionemmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Baseline subtraction</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Data resulting of a pre-processing of raw data, applying corrections to normalize/harmonize, in order to prepare them for the post-processing.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PrimaryData">chameo:PrimaryData</a>
    /// </summary>
    let PrimaryData = _prefixId.prefix "PrimaryData"
    /// <summary>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In x-ray diffraction, the probe is a beam of x-rays with known energy that is properly focused on the sample’s surface with a well-defined geometryemmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In electron microscopy (SEM or TEM), the probe is a beam of electrons with known energy that is focused (and scanned) on the sample’s surface with a well-defined beam-size and scanning algorithm.emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In spectroscopic methods, the probe is a beam of light with pre-defined energy (for example in the case of laser beam for Raman measurements) or pre-defined polarization (for example in the case of light beam for Spectroscopic Ellipsometry methods), that will be properly focused on the sample’s surface with a welldefined geometry (specific angle of incidence).emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In dynamic light scattering, temporal fluctuations of backscattered light due to Brownian motion and flow of nanoparticles are the probe, resolved as function of pathlength in the sample. From fluctuation analysis (intensity correlations) and the wavelength of light in the medium, the (distribution of) diffusion coefficient(s) can be measured during flow. The Stokes-Einstein relation yields the particle size characteristics.emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In mechanical testing, the probe is a the tip plus a force actuator, which is designed to apply a force over-time on a sample. Many variants can be defined depending on way the force is applied (tensile/compressive uniaxial tests, bending test, indentation test) and its variation with time (static tests, dynamic/cyclic tests, impact tests, etc…)</para>
    ///   <para>skos:prefLabel : Probe</para>
    ///   <para>rdfs:label : Probe</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Probe is the physical tool (i.e., a disturbance, primary solicitation, or a gadget), controlled over time, that generates measurable fields that interact with the sample to acquire information on the specimen’s behaviour and properties.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Probe">chameo:Probe</a>
    /// </summary>
    let Probe = _prefixId.prefix "Probe"
    /// <summary>
    ///   <para>skos:prefLabel : ProbeSampleInteraction</para>
    ///   <para>rdfs:label : ProbeSampleInteraction</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Process representing the interaction between the Probe and the Sample (with a certain Interaction Volume) which generates a Signal</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProbeSampleInteraction">chameo:ProbeSampleInteraction</a>
    /// </summary>
    let ProbeSampleInteraction = _prefixId.prefix "ProbeSampleInteraction"
    /// <summary>
    ///   <para>skos:prefLabel : ProcessingReproducibility</para>
    ///   <para>rdfs:label : ProcessingReproducibility</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Description of performed statistical analysis to check for data reproducibility (e.g.  easily reproducible for everyone, reproducible for a domain expert, reproducible only for Data processing Expert)</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ProcessingReproducibility">chameo:ProcessingReproducibility</a>
    /// </summary>
    let ProcessingReproducibility = _prefixId.prefix "ProcessingReproducibility"
    /// <summary>
    ///   <para>skos:prefLabel : Profilometry</para>
    ///   <para>rdfs:label : Profilometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Profilometry is a technique used to extract topographical data from a surface. This can be a single point, a line scan or even a full three dimensional scan. The purpose of profilometry is to get surface morphology, step heights and surface roughness.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Profilometry">chameo:Profilometry</a>
    /// </summary>
    let Profilometry = _prefixId.prefix "Profilometry"
    /// <summary>
    ///   <para>skos:prefLabel : PulsedElectroacousticMethod</para>
    ///   <para>rdfs:label : PulsedElectroacousticMethod</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1007/s10832-023-00332-y^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The pulsed electroacoustic (PEA) method is an established method for space charge measurements in polymeric dielectrics.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#PulsedElectroacousticMethod">chameo:PulsedElectroacousticMethod</a>
    /// </summary>
    let PulsedElectroacousticMethod = _prefixId.prefix "PulsedElectroacousticMethod"
    /// <summary>
    ///   <para>skos:prefLabel : RamanSpectroscopy</para>
    ///   <para>rdfs:label : RamanSpectroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Raman spectroscopy (/ˈrɑːmən/) (named after physicist C. V. Raman) is a spectroscopic technique typically used to determine vibrational modes of molecules, although rotational and other low-frequency modes of systems may also be observed. Raman spectroscopy is commonly used in chemistry to provide a structural fingerprint by which molecules can be identified.
    ///
    /// Raman spectroscopy relies upon inelastic scattering of photons, known as Raman scattering. A source of monochromatic light, usually from a laser in the visible, near infrared, or near ultraviolet range is used, although X-rays can also be used. The laser light interacts with molecular vibrations, phonons or other excitations in the system, resulting in the energy of the laser photons being shifted up or down. The shift in energy gives information about the vibrational modes in the system. Infrared spectroscopy typically yields similar yet complementary information.
    ///
    /// Typically, a sample is illuminated with a laser beam. Electromagnetic radiation from the illuminated spot is collected with a lens and sent through a monochromator. Elastic scattered radiation at the wavelength corresponding to the laser line (Rayleigh scattering) is filtered out by either a notch filter, edge pass filter, or a band pass filter, while the rest of the collected light is dispersed onto a detector.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RamanSpectroscopy">chameo:RamanSpectroscopy</a>
    /// </summary>
    let RamanSpectroscopy = _prefixId.prefix "RamanSpectroscopy"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The raw data is a set of (unprocessed) data that is given directly as output from the detector, usually expressed as a function of time or position, or photon energy.emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Direct output of the equipment with the manufacturer’s software including automatic pre-processing that is not modified by the user once the acquisition method is defined and the equipment calibrated.</para>
    ///   <para>rdfs:label : RawData</para>
    ///   <para>skos:prefLabel : RawData</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In mechanical testing, examples of raw data are raw-force, raw-displacement, coordinates as function of time.emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In spectroscopic testing, the raw data are light intensity, or refractive index, or optical absorption as a function of the energy (or wavelength) of the incident light beam.</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : In some cases, raw data can be considered to have already some level of data processing, e.g., in electron microscopy a “raw image” that is formed on the screen is already result from multiple processing after the signal is acquired by the detector.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawData">chameo:RawData</a>
    /// </summary>
    let RawData = _prefixId.prefix "RawData"
    /// <summary>
    ///   <para>skos:prefLabel : RawSample</para>
    ///   <para>rdfs:label : RawSample</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#RawSample">chameo:RawSample</a>
    /// </summary>
    let RawSample = _prefixId.prefix "RawSample"
    /// <summary>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Quality control sample used to determine accuracy and precision of method. [ISO 17858:2007]emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : Material, sufficiently homogeneous and stable with reference to one or more specified properties, which has been established to be fit for its intended use in measurement or in examination
    /// NOTE 1 Reference materials can be certified reference materials or reference materials without a certified property
    /// value.
    /// NOTE 2 For a reference material to be used as a measurement standard for calibration purposes it needs to be a certified reference material.
    /// NOTE 3 Reference materials can be used for measurement precision evaluation and quality control.
    /// EXAMPLE Human serum without an assigned quantity value for the amount-of-substance concentration of the inherent cholesterol, used for quality control.
    /// NOTE 4 Properties of reference materials can be quantities or nominal properties.
    /// NOTE 5 A reference material is sometimes incorporated into a specially fabricated device.
    /// EXAMPLE Spheres of uniform size mounted on a microscope slide.
    /// NOTE 6 Some reference materials have assigned values in a unit outside the SI. Such materials include vaccines to
    /// which International Units (IU) have been assigned by the World Health Organization.
    /// NOTE 7 A given reference material can only be used for one purpose in a measurement, either calibration or quality
    /// control, but not both.
    /// NOTE 8 ISO/REMCO has an analogous definition but uses the term “measurement process” (ISO Guide 30, Reference
    /// materials – Selected terms and definitions, definition 2.1.1) for both measurement and examination.
    ///
    /// -- International Vocabulary of Metrology(VIM)</para>
    ///   <para>skos:altLabel : Certified Reference Materialskos:altLabel : Reference materialskos:altLabel : ReferenceSpecimen^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Material, sufficiently homogeneous and stable with respect to one or more specified properties, which has been established to be fit for its intended use in a measurement process”.</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:prefLabel : ReferenceSample</para>
    ///   <para>emmo:EMMO_bb49844b_45d7_4f0d_8cae_8e552cbc20d6 : Reference material</para>
    ///   <para>rdfs:label : ReferenceSample</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ReferenceSample">chameo:ReferenceSample</a>
    /// </summary>
    let ReferenceSample = _prefixId.prefix "ReferenceSample"
    /// <summary>
    ///   <para>skos:prefLabel : Sample</para>
    ///   <para>rdfs:label : Sample</para>
    ///   <para>skos:altLabel : Specimen^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : Sample and Specime are often used interchangeably. However in some cases the term Specimen is used to specify a portion taken under conditions such that the sampling variability cannot be assessed (usually because the population is changing), and is assumed, for convenience, to be zero.^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Portion of material selected from a larger quantity of material. The term needs to be qualified, e.g., bulk sample, representative sample, primary sample, bulked sample, test sample, etc. The term 'sample' implies the existence of a sampling error, i.e., the results obtained on the portions taken are only estimates of the concentration of a constituent or the quantity of a property present in the parent material. If there is no or negligible sampling error, the portion removed is a test portion, aliquot, or specimen.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Sample">chameo:Sample</a>
    /// </summary>
    let Sample = _prefixId.prefix "Sample"
    /// <summary>
    ///   <para>skos:prefLabel : SampleInspection</para>
    ///   <para>rdfs:label : SampleInspection</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : In the Nanoindentation method the Scanning Electron Microscope to determine the indentation area.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Analysis of the sample in order to determine information that are relevant for the characterisation method.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspection">chameo:SampleInspection</a>
    /// </summary>
    let SampleInspection = _prefixId.prefix "SampleInspection"
    /// <summary>
    ///   <para>skos:prefLabel : SampleInspectionInstrument^^xsd:string</para>
    ///   <para>rdfs:label : SampleInspectionInstrument^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampleInspectionInstrument">chameo:SampleInspectionInstrument</a>
    /// </summary>
    let SampleInspectionInstrument = _prefixId.prefix "SampleInspectionInstrument"
    /// <summary>
    ///   <para>skos:prefLabel : SamplePreparation</para>
    ///   <para>rdfs:label : SamplePreparation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Sample preparation processes (e.g., machining, polishing, cutting to size, etc.) before actual observation and measurement.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparation">chameo:SamplePreparation</a>
    /// </summary>
    let SamplePreparation = _prefixId.prefix "SamplePreparation"
    /// <summary>
    ///   <para>skos:prefLabel : SamplePreparationHardware</para>
    ///   <para>rdfs:label : SamplePreparationHardware</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Hardware used for the preparation of the sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationHardware">chameo:SamplePreparationHardware</a>
    /// </summary>
    let SamplePreparationHardware = _prefixId.prefix "SamplePreparationHardware"
    /// <summary>
    ///   <para>skos:prefLabel : SamplePreparationInstrument^^xsd:string</para>
    ///   <para>rdfs:label : SamplePreparationInstrument^^xsd:string</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationInstrument">chameo:SamplePreparationInstrument</a>
    /// </summary>
    let SamplePreparationInstrument = _prefixId.prefix "SamplePreparationInstrument"
    /// <summary>
    ///   <para>skos:prefLabel : SamplePreparationParameter</para>
    ///   <para>rdfs:label : SamplePreparationParameter</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Parameter used for the sample preparation process</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplePreparationParameter">chameo:SamplePreparationParameter</a>
    /// </summary>
    let SamplePreparationParameter = _prefixId.prefix "SamplePreparationParameter"
    /// <summary>
    ///   <para>skos:prefLabel : SampledDCPolarography</para>
    ///   <para>rdfs:label : SampledDCPolarography</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : In this way, the ratio of faradaic current to double layer charging current is enhanced and the negative influence of charging current is partially eliminated. Due to the improved signal (faradaic current) to noise (charging current) ratio, the limit of detection is lowered.</para>
    ///   <para>skos:altLabel : TASTPolarography</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : DC polarography with current sampling at the end of each drop life mechanically enforced by a knocker at a preset drop time value. The current sampling and mechanical drop dislodge are synchronized.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SampledDCPolarography">chameo:SampledDCPolarography</a>
    /// </summary>
    let SampledDCPolarography = _prefixId.prefix "SampledDCPolarography"
    /// <summary>
    ///   <para>skos:prefLabel : SamplingProcess</para>
    ///   <para>rdfs:label : SamplingProcess</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : The term can be used to cover either a unit of supply or a portion for analysis. The portion taken may consist of one or more sub-samples and the batch may be the population from which the sample is taken.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Act of extracting a portion (amount) of material from a larger quantity of material. This operation results in obtaining a sample representative of the batch with respect to the property or properties being investigated.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SamplingProcess">chameo:SamplingProcess</a>
    /// </summary>
    let SamplingProcess = _prefixId.prefix "SamplingProcess"

    /// <summary>
    ///   <para>skos:prefLabel : ScanningAugerElectronMicroscopy</para>
    ///   <para>rdfs:label : ScanningAugerElectronMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : AES^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Auger electron spectroscopy (AES or simply Auger) is a surface analysis technique that uses an electron beam to excite electrons on atoms in the particle. Atoms that are excited by the electron beam can emit “Auger” electrons. AES measures the kinetic energies of the emitted electrons. The energy of the emitted electrons is characteristic of elements present at the surface and near the surface of a sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningAugerElectronMicroscopy">chameo:ScanningAugerElectronMicroscopy</a>
    /// </summary>
    let ScanningAugerElectronMicroscopy =
        _prefixId.prefix "ScanningAugerElectronMicroscopy"

    /// <summary>
    ///   <para>skos:prefLabel : ScanningElectronMicroscopy</para>
    ///   <para>rdfs:label : ScanningElectronMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : SEM^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : The scanning electron microscope (SEM) uses a focused beam of high-energy electrons to generate a variety of signals at the surface of solid specimens. The signals that derive from electron-sample interactions reveal information about the sample including external morphology (texture), chemical composition, and crystalline structure and orientation of materials making up the sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningElectronMicroscopy">chameo:ScanningElectronMicroscopy</a>
    /// </summary>
    let ScanningElectronMicroscopy = _prefixId.prefix "ScanningElectronMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : ScanningKelvinProbe</para>
    ///   <para>rdfs:label : ScanningKelvinProbe</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : SKB^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Scanning Kelvin probe (SKP) and scanning Kelvin probe force microscopy (SKPFM) are probe techniques which permit mapping of topography and Volta potential distribution on electrode surfaces. It measures the surface electrical potential of a sample without requiring an actual physical contact.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningKelvinProbe">chameo:ScanningKelvinProbe</a>
    /// </summary>
    let ScanningKelvinProbe = _prefixId.prefix "ScanningKelvinProbe"
    /// <summary>
    ///   <para>skos:prefLabel : ScanningProbeMicroscopy</para>
    ///   <para>rdfs:label : ScanningProbeMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Scanning probe microscopy (SPM) is a branch of microscopy that forms images of surfaces using a physical probe that scans the specimen.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningProbeMicroscopy">chameo:ScanningProbeMicroscopy</a>
    /// </summary>
    let ScanningProbeMicroscopy = _prefixId.prefix "ScanningProbeMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : ScanningTunnelingMicroscopy</para>
    ///   <para>rdfs:label : ScanningTunnelingMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : STM^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Scanning Tunneling Microscopy, or STM, is an imaging technique used to obtain ultra-high resolution images at the atomic scale, without using light or electron beams.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScanningTunnelingMicroscopy">chameo:ScanningTunnelingMicroscopy</a>
    /// </summary>
    let ScanningTunnelingMicroscopy = _prefixId.prefix "ScanningTunnelingMicroscopy"
    /// <summary>
    ///   <para>skos:prefLabel : ScatteringAndDiffraction</para>
    ///   <para>rdfs:label : ScatteringAndDiffraction</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ScatteringAndDiffraction">chameo:ScatteringAndDiffraction</a>
    /// </summary>
    let ScatteringAndDiffraction = _prefixId.prefix "ScatteringAndDiffraction"
    /// <summary>
    ///   <para>skos:prefLabel : SecondaryData</para>
    ///   <para>rdfs:label : SecondaryData</para>
    ///   <para>skos:altLabel : Elaborated data</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Intensity mapsemmo:EMMO_b432d2d5_25f4_4165_99c5_5935a7763c1a : Deconvoluted curves</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Data resulting from the application of post-processing or model generation to other data.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryData">chameo:SecondaryData</a>
    /// </summary>
    let SecondaryData = _prefixId.prefix "SecondaryData"
    /// <summary>
    ///   <para>skos:prefLabel : SecondaryIonMassSpectrometry</para>
    ///   <para>rdfs:label : SecondaryIonMassSpectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : SIMS^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Secondary-ion mass spectrometry (SIMS) is a technique used to analyze the composition of solid surfaces and thin films by sputtering the surface of the specimen with a focused primary ion beam and collecting and analyzing ejected secondary ions.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SecondaryIonMassSpectrometry">chameo:SecondaryIonMassSpectrometry</a>
    /// </summary>
    let SecondaryIonMassSpectrometry = _prefixId.prefix "SecondaryIonMassSpectrometry"
    /// <summary>
    ///   <para>skos:prefLabel : ShearOrTorsionTest</para>
    ///   <para>rdfs:label : ShearOrTorsionTest</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#ShearOrTorsionTests">chameo:ShearOrTorsionTests</a>
    /// </summary>
    let ShearOrTorsionTests = _prefixId.prefix "ShearOrTorsionTests"
    /// <summary>
    ///   <para>skos:prefLabel : Signal</para>
    ///   <para>rdfs:label : Signal</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_c7b62dd7_063a_4c2a_8504_42f7264ba83f : Signal is usually emitted from a characteristic “emission” volume, which can be different from the sample/probe “interaction” volume and can be usually quantified using proper physics equations and/or modelling of the interaction mechanisms.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Result (effect) of the interaction between the sample and the probe, which usually is a measurable and quantifiable quantity.</para>
    ///   <para>emmo:EMMO_70fe84ff_99b6_4206_a9fc_9a8931836d84 : According to UPAC Compendium of Chemical Terminology, a “signal” is “A representation of a quantity within an analytical instrument” (https://goldbook.iupac.org/terms/view/S05661 ).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Signal">chameo:Signal</a>
    /// </summary>
    let Signal = _prefixId.prefix "Signal"
    /// <summary>
    ///   <para>skos:prefLabel : Spectrometry</para>
    ///   <para>rdfs:label : Spectrometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Spectroscopic techniques are numerous and varied, but all involve measuring the response of a material to different frequencies of electromagnetic radiation. Depending on the technique used, material characterization may be based on the absorption, emission, impedance, or reflection of incident energy by a sample.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectrometry">chameo:Spectrometry</a>
    /// </summary>
    let Spectrometry = _prefixId.prefix "Spectrometry"
    /// <summary>
    ///   <para>skos:prefLabel : Spectroscopy</para>
    ///   <para>rdfs:label : Spectroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Spectroscopy is a category of characterization techniques which use a range of principles to reveal the chemical composition, composition variation, crystal structure and photoelectric properties of materials.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Spectroscopy">chameo:Spectroscopy</a>
    /// </summary>
    let Spectroscopy = _prefixId.prefix "Spectroscopy"
    /// <summary>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : Most instruments show plots of the current at the end of the forward-going pulse and of the backward-going pulse vs. the potential, as well as their difference. This can give valuable information on the kinetics of the electrode reaction and the electrode process.rdfs:comment : The current is sampled just before the end of the forward- going pulse and of the backward-going pulse and the difference of the two sampled currents is plotted versus the applied potential of the potential or staircase ramp. The square-wave voltammogram is peak-shapedrdfs:comment : The sensitivity of SWV depends on the reversibility of the electrode reaction of the analyte.</para>
    ///   <para>rdfs:label : SquareWaveVoltammetry</para>
    ///   <para>skos:prefLabel : SquareWaveVoltammetry</para>
    ///   <para>skos:altLabel : OSWVskos:altLabel : OsteryoungSquareWaveVoltammetryskos:altLabel : SWV</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q4016323^^xsd:string</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Squarewave_voltammetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : voltammetry in which a square-wave potential waveform is superimposed on an underlying linearly varying potential ramp or staircase ramp</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#SquareWaveVoltammetry">chameo:SquareWaveVoltammetry</a>
    /// </summary>
    let SquareWaveVoltammetry = _prefixId.prefix "SquareWaveVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : StepChronopotentiometry</para>
    ///   <para>rdfs:label : StepChronopotentiometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : chronopotentiometry where the applied current is changed in steps</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StepChronopotentiometry">chameo:StepChronopotentiometry</a>
    /// </summary>
    let StepChronopotentiometry = _prefixId.prefix "StepChronopotentiometry"
    /// <summary>
    ///   <para>rdfs:label : StrippingVoltammetry</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Electrochemical_stripping_analysis</para>
    ///   <para>rdfs:comment : Anodic stripping voltammetry (ASV) was historically used to measure concentrations of metal ions in solution using cathodic accumulation with mercury to form an amalgam. Due to the toxicity of mercury and its compounds, inductively coupled plasma optical emission spectrometry and inductively coupled plasma mass spectrometry have frequently replaced ASV at mercury electrodes in the laboratory, often sacrificing the probing of speciation and lability in complex matrices. Mercury has now been replaced by non-toxic bismuth or anti- mony as films on a solid electrode support (such as glassy carbon) with equally good sensi- tivity and detection limits.rdfs:comment : Types of stripping voltammetry refer to the kind of accumulation (e.g. adsorptive stripping voltammetry) or the polarity of the stripping electrochemistry (anodic, cathodic stripping voltammetry).rdfs:comment : Often the product of the electrochemical stripping is identical to the analyte before the accumulation.rdfs:comment : Because the accumulation (pre-concentration) step can be prolonged, increasing the amount of material at the electrode, stripping voltammetry is able to measure very small concentrations of analyte.rdfs:comment : ^^xsd:stringrdfs:comment : Stripping voltammetry is a calibrated method to establish the relation between amount accumulated in a given time and the concentration of the analyte in solution.</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : two-step electrochemical measurement in which 1) material is accumulated at an electrode and 2) the amount of an accumulated species is measured by voltammetry. The measured electric current in step 2 is related to the concentration of analyte in the solution by calibration.</para>
    ///   <para>skos:prefLabel : StrippingVoltammetry</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#StrippingVoltammetry">chameo:StrippingVoltammetry</a>
    /// </summary>
    let StrippingVoltammetry = _prefixId.prefix "StrippingVoltammetry"
    /// <summary>
    ///   <para>skos:prefLabel : Synchrotron</para>
    ///   <para>rdfs:label : Synchrotron</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Synchrotron">chameo:Synchrotron</a>
    /// </summary>
    let Synchrotron = _prefixId.prefix "Synchrotron"
    /// <summary>
    ///   <para>skos:prefLabel : TensileTest</para>
    ///   <para>rdfs:label : TensileTest</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : TensionTest^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Tensile testing, also known as tension testing, is a test in which a sample is subjected to a controlled tension until failure. Properties that are directly measured via a tensile test are ultimate tensile strength, breaking strength, maximum elongation and reduction in area. From these measurements the following properties can also be determined: Young's modulus, Poisson's ratio, yield strength, and strain-hardening characteristics. Uniaxial tensile testing is the most commonly used for obtaining the mechanical characteristics of isotropic materials. Some materials use biaxial tensile testing. The main difference between these testing machines being how load is applied on the materials.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TensileTest">chameo:TensileTest</a>
    /// </summary>
    let TensileTest = _prefixId.prefix "TensileTest"
    /// <summary>
    ///   <para>skos:prefLabel : Thermochemical</para>
    ///   <para>rdfs:label : Thermochemical</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : TMA^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Thermomechanical analysis (TMA) is a technique used in thermal analysis, a branch of materials science which studies the properties of materials as they change with temperature.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermochemical">chameo:Thermochemical</a>
    /// </summary>
    let Thermochemical = _prefixId.prefix "Thermochemical"
    /// <summary>
    ///   <para>skos:prefLabel : Thermogravimetry</para>
    ///   <para>rdfs:label : Thermogravimetry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : TGA^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Thermogravimetric analysis or thermal gravimetric analysis (TGA) is a method of thermal analysis in which the mass of a sample is measured over time as the temperature changes. This measurement provides information about physical phenomena, such as phase transitions, absorption, adsorption and desorption; as well as chemical phenomena including chemisorptions, thermal decomposition, and solid-gas reactions (e.g., oxidation or reduction).</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Thermogravimetry">chameo:Thermogravimetry</a>
    /// </summary>
    let Thermogravimetry = _prefixId.prefix "Thermogravimetry"
    /// <summary>
    ///   <para>skos:prefLabel : Tomography</para>
    ///   <para>rdfs:label : Tomography</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Tomography is imaging by sections or sectioning that uses any kind of penetrating wave. The method is used in radiology, archaeology, biology, atmospheric science, geophysics, oceanography, plasma physics, materials science, cosmochemistry, astrophysics, quantum information, and other areas of science. The word tomography is derived from Ancient Greek τόμος tomos, "slice, section" and γράφω graphō, "to write" or, in this context as well, "to describe." A device used in tomography is called a tomograph, while the image produced is a tomogram.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Tomography">chameo:Tomography</a>
    /// </summary>
    let Tomography = _prefixId.prefix "Tomography"

    /// <summary>
    ///   <para>skos:prefLabel : TransmissionElectronMicroscopy</para>
    ///   <para>rdfs:label : TransmissionElectronMicroscopy</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : TEM^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Transmission electron microscopy (TEM) is a microscopy technique in which a beam of electrons is transmitted through a specimen to form an image. The specimen is most often an ultrathin section less than 100 nm thick or a suspension on a grid. An image is formed from the interaction of the electrons with the sample as the beam is transmitted through the specimen. The image is then magnified and focused onto an imaging device, such as a fluorescent screen, a layer of photographic film, or a sensor such as a scintillator attached to a charge-coupled device.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#TransmissionElectronMicroscopy">chameo:TransmissionElectronMicroscopy</a>
    /// </summary>
    let TransmissionElectronMicroscopy =
        _prefixId.prefix "TransmissionElectronMicroscopy"

    /// <summary>
    ///   <para>skos:prefLabel : Ultrasonic</para>
    ///   <para>rdfs:label : Ultrasonic</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Ultrasonic testing (UT) is a family of non-destructive testing techniques based on the propagation of ultrasonic waves in the object or material tested. In most common UT applications, very short ultrasonic pulse-waves with center frequencies ranging from 0.1-15 MHz, and occasionally up to 50 MHz, are transmitted into materials to detect internal flaws or to characterize materials. A common example is ultrasonic thickness measurement, which tests the thickness of the test object, for example, to monitor pipework corrosion.
    ///
    /// Ultrasonic testing is often performed on steel and other metals and alloys, though it can also be used on concrete, wood and composites, albeit with less resolution. It is used in many industries including steel and aluminium construction, metallurgy, manufacturing, aerospace, automotive and other transportation sectors.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Ultrasonic">chameo:Ultrasonic</a>
    /// </summary>
    let Ultrasonic = _prefixId.prefix "Ultrasonic"

    /// <summary>
    ///   <para>skos:prefLabel : VaporPressureDepressionOsmometry</para>
    ///   <para>rdfs:label : VaporPressureDepressionOsmometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : VPO^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Vapor pressure osmometry measures vapor pressure indirectly by measuring the change in temperature of a polymer solution on dilution by solvent vapor and is generally useful for polymers with Mn below 10,000–40,000 g/mol. When molecular weight is more than that limit, the quantity being measured becomes very small to detect.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VaporPressureDepressionOsmometry">chameo:VaporPressureDepressionOsmometry</a>
    /// </summary>
    let VaporPressureDepressionOsmometry =
        _prefixId.prefix "VaporPressureDepressionOsmometry"

    /// <summary>
    ///   <para>skos:prefLabel : Viscometry</para>
    ///   <para>rdfs:label : Viscometry</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : Viscosity^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Viscometry or viscosity method was one of the first methods used for determining the MW of polymers. In this method, the viscosity of polymer solution is measured, and the simplest method used is capillary viscometry by using the Ubbelohde U-tube viscometer. In this method, both the flow time of the polymer solution (t) and the flow time of the pure solvent (t0) are recorded. The ratio of the polymer solution flow time (t) to the flow time of pure solvent (t0) is equal to the ratio of their viscosities (η/η0) only if they have the same densities.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Viscometry">chameo:Viscometry</a>
    /// </summary>
    let Viscometry = _prefixId.prefix "Viscometry"
    /// <summary>
    ///   <para>rdfs:label : Voltammetry</para>
    ///   <para>emmo:EMMO_26bf1bef_d192_4da6_b0eb_d2209698fb54 : https://www.wikidata.org/wiki/Q904093^^xsd:string</para>
    ///   <para>skos:prefLabel : Voltammetry</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : Voltammetry is an analytical technique based on the measure of the current flowing through an electrode dipped in a solution containing electro-active compounds, while a potential scanning is imposed upon it.</para>
    ///   <para>rdfs:comment : ^^xsd:stringrdfs:comment : The current vs. potential (I-E) curve is called a voltammogram.</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_50c298c2_55a2_4068_b3ac_4e948c33181f : https://www.electropedia.org/iev/iev.nsf/display?openform&amp;ievref=114-04-11^^xsd:string</para>
    ///   <para>emmo:EMMO_c84c6752_6d64_48cc_9500_e54a3c34898d : https://en.wikipedia.org/wiki/Voltammetry^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#Voltammetry">chameo:Voltammetry</a>
    /// </summary>
    let Voltammetry = _prefixId.prefix "Voltammetry"

    /// <summary>
    ///   <para>skos:prefLabel : VoltammetryAtARotatingDiskElectrode</para>
    ///   <para>rdfs:label : VoltammetryAtARotatingDiskElectrode</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_fe015383_afb3_44a6_ae86_043628697aa2 : https://doi.org/10.1515/pac-2018-0109</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : hydrodynamic voltammetry using a a rotating disc electrode, where the limiting current is described by the Levich equation</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#VoltammetryAtARotatingDiskElectrode">chameo:VoltammetryAtARotatingDiskElectrode</a>
    /// </summary>
    let VoltammetryAtARotatingDiskElectrode =
        _prefixId.prefix "VoltammetryAtARotatingDiskElectrode"

    /// <summary>
    ///   <para>skos:prefLabel : WearTest</para>
    ///   <para>rdfs:label : WearTest</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : A wear test measures the changes in conditions caused by friction, and the result is obtained from deformation, scratches, and indentations on the interacting surfaces.
    /// Wear is defined as the progressive removal of the material from a solid surface and manifested by a change in the geometry of the surface.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#WearTest">chameo:WearTest</a>
    /// </summary>
    let WearTest = _prefixId.prefix "WearTest"
    /// <summary>
    ///   <para>skos:prefLabel : XpsVariableKinetic</para>
    ///   <para>rdfs:label : XpsVariableKinetic</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>skos:altLabel : X-ray photoelectron spectroscopy (XPS)^^xsd:stringskos:altLabel : Electron spectroscopy for chemical analysis (ESCA)^^xsd:string</para>
    ///   <para>emmo:EMMO_967080e5_2f42_4eb2_a3a9_c58143e835f9 : X-ray photoelectron spectroscopy (XPS), also known as ESCA (electron spectroscopy for chemical analysis) is a surface analysis technique which provides both elemental and chemical state information virtually without restriction on the type of material which can be analysed. It is a relatively simple technique where the sample is illuminated with X-rays which have enough energy to eject an electron from the atom.  These ejected electrons are known as photoelectrons. The kinetic energy of these emitted electrons is characteristic of the element from which the photoelectron originated. The position and intensity of the peaks in an energy spectrum provide the desired chemical state and quantitative information.  The surface sensitivity of XPS is determined by the distance that that photoelectron can travel through the material without losing any kinteic energy.  These elastiaclly scattered photoelectrons contribute to the photoelectron peak, whilst photoelectrons that have been inelastically scattered, losing some kinetic energy before leaving the material, will contribute to the spectral background.</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XpsVariableKinetic">chameo:XpsVariableKinetic</a>
    /// </summary>
    let XpsVariableKinetic = _prefixId.prefix "XpsVariableKinetic"
    /// <summary>
    ///   <para>skos:prefLabel : XrdGrazingIncidence</para>
    ///   <para>rdfs:label : XrdGrazingIncidence</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#XrdGrazingIncidence">chameo:XrdGrazingIncidence</a>
    /// </summary>
    let XrdGrazingIncidence = _prefixId.prefix "XrdGrazingIncidence"

    /// <summary>
    ///   <para>skos:prefLabel : characterisationProcedureHasSubProcedure</para>
    ///   <para>rdfs:label : characterisationProcedureHasSubProcedure</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#characterisationProcedureHasSubProcedure">chameo:characterisationProcedureHasSubProcedure</a>
    /// </summary>
    let characterisationProcedureHasSubProcedure =
        _prefixId.prefix "characterisationProcedureHasSubProcedure"

    /// <summary>
    ///   <para>skos:prefLabel : hasAccessConditions</para>
    ///   <para>rdfs:label : hasAccessConditions</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasAccessConditions">chameo:hasAccessConditions</a>
    /// </summary>
    let hasAccessConditions = _prefixId.prefix "hasAccessConditions"

    /// <summary>
    ///   <para>skos:prefLabel : hasCharacterisationEnvironment</para>
    ///   <para>rdfs:label : hasCharacterisationEnvironment</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironment">chameo:hasCharacterisationEnvironment</a>
    /// </summary>
    let hasCharacterisationEnvironment =
        _prefixId.prefix "hasCharacterisationEnvironment"

    /// <summary>
    ///   <para>skos:prefLabel : hasCharacterisationEnvironmentProperty</para>
    ///   <para>rdfs:label : hasCharacterisationEnvironmentProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationEnvironmentProperty">chameo:hasCharacterisationEnvironmentProperty</a>
    /// </summary>
    let hasCharacterisationEnvironmentProperty =
        _prefixId.prefix "hasCharacterisationEnvironmentProperty"

    /// <summary>
    ///   <para>skos:prefLabel : hasCharacterisationProcedureValidation</para>
    ///   <para>rdfs:label : hasCharacterisationProcedureValidation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProcedureValidation">chameo:hasCharacterisationProcedureValidation</a>
    /// </summary>
    let hasCharacterisationProcedureValidation =
        _prefixId.prefix "hasCharacterisationProcedureValidation"

    /// <summary>
    ///   <para>skos:prefLabel : hasCharacterisationProperty</para>
    ///   <para>rdfs:label : hasCharacterisationProperty</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationProperty">chameo:hasCharacterisationProperty</a>
    /// </summary>
    let hasCharacterisationProperty = _prefixId.prefix "hasCharacterisationProperty"
    /// <summary>
    ///   <para>skos:prefLabel : hasCharacterisationSoftware</para>
    ///   <para>rdfs:label : hasCharacterisationSoftware</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasCharacterisationSoftware">chameo:hasCharacterisationSoftware</a>
    /// </summary>
    let hasCharacterisationSoftware = _prefixId.prefix "hasCharacterisationSoftware"
    /// <summary>
    ///   <para>skos:prefLabel : hasDataAcquisitionRate</para>
    ///   <para>rdfs:label : hasDataAcquisitionRate</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataAcquisitionRate">chameo:hasDataAcquisitionRate</a>
    /// </summary>
    let hasDataAcquisitionRate = _prefixId.prefix "hasDataAcquisitionRate"

    /// <summary>
    ///   <para>skos:prefLabel : hasDataProcessingThroughCalibration</para>
    ///   <para>rdfs:label : hasDataProcessingThroughCalibration</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataProcessingThroughCalibration">chameo:hasDataProcessingThroughCalibration</a>
    /// </summary>
    let hasDataProcessingThroughCalibration =
        _prefixId.prefix "hasDataProcessingThroughCalibration"

    /// <summary>
    ///   <para>skos:prefLabel : hasDataQuality</para>
    ///   <para>rdfs:label : hasDataQuality</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataQuality">chameo:hasDataQuality</a>
    /// </summary>
    let hasDataQuality = _prefixId.prefix "hasDataQuality"
    /// <summary>
    ///   <para>skos:prefLabel : hasDataset</para>
    ///   <para>rdfs:label : hasDataset</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasDataset">chameo:hasDataset</a>
    /// </summary>
    let hasDataset = _prefixId.prefix "hasDataset"
    /// <summary>
    ///   <para>skos:prefLabel : hasHardwareSpecification</para>
    ///   <para>rdfs:label : hasHardwareSpecification</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHardwareSpecification">chameo:hasHardwareSpecification</a>
    /// </summary>
    let hasHardwareSpecification = _prefixId.prefix "hasHardwareSpecification"
    /// <summary>
    ///   <para>skos:prefLabel : hasHazard</para>
    ///   <para>rdfs:label : hasHazard</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHazard">chameo:hasHazard</a>
    /// </summary>
    let hasHazard = _prefixId.prefix "hasHazard"
    /// <summary>
    ///   <para>skos:prefLabel : hasHolder</para>
    ///   <para>rdfs:label : hasHolder</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasHolder">chameo:hasHolder</a>
    /// </summary>
    let hasHolder = _prefixId.prefix "hasHolder"
    /// <summary>
    ///   <para>skos:prefLabel : hasInteractionVolume</para>
    ///   <para>rdfs:label : hasInteractionVolume</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionVolume">chameo:hasInteractionVolume</a>
    /// </summary>
    let hasInteractionVolume = _prefixId.prefix "hasInteractionVolume"
    /// <summary>
    ///   <para>skos:prefLabel : hasInteractionWithProbe</para>
    ///   <para>rdfs:label : hasInteractionWithProbe</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithProbe">chameo:hasInteractionWithProbe</a>
    /// </summary>
    let hasInteractionWithProbe = _prefixId.prefix "hasInteractionWithProbe"
    /// <summary>
    ///   <para>skos:prefLabel : hasInteractionWithSample</para>
    ///   <para>rdfs:label : hasInteractionWithSample</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasInteractionWithSample">chameo:hasInteractionWithSample</a>
    /// </summary>
    let hasInteractionWithSample = _prefixId.prefix "hasInteractionWithSample"
    /// <summary>
    ///   <para>skos:prefLabel : hasLab</para>
    ///   <para>rdfs:label : hasLab</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLab">chameo:hasLab</a>
    /// </summary>
    let hasLab = _prefixId.prefix "hasLab"
    /// <summary>
    ///   <para>skos:prefLabel : hasLevelOfAutomation</para>
    ///   <para>rdfs:label : hasLevelOfAutomation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasLevelOfAutomation">chameo:hasLevelOfAutomation</a>
    /// </summary>
    let hasLevelOfAutomation = _prefixId.prefix "hasLevelOfAutomation"
    /// <summary>
    ///   <para>skos:prefLabel : hasMeasurementDetector</para>
    ///   <para>rdfs:label : hasMeasurementDetector</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementDetector">chameo:hasMeasurementDetector</a>
    /// </summary>
    let hasMeasurementDetector = _prefixId.prefix "hasMeasurementDetector"
    /// <summary>
    ///   <para>skos:prefLabel : hasMeasurementParameter</para>
    ///   <para>rdfs:label : hasMeasurementParameter</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementParameter">chameo:hasMeasurementParameter</a>
    /// </summary>
    let hasMeasurementParameter = _prefixId.prefix "hasMeasurementParameter"
    /// <summary>
    ///   <para>skos:prefLabel : hasMeasurementProbe</para>
    ///   <para>rdfs:label : hasMeasurementProbe</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementProbe">chameo:hasMeasurementProbe</a>
    /// </summary>
    let hasMeasurementProbe = _prefixId.prefix "hasMeasurementProbe"
    /// <summary>
    ///   <para>skos:prefLabel : hasMeasurementSample</para>
    ///   <para>rdfs:label : hasMeasurementSample</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementSample">chameo:hasMeasurementSample</a>
    /// </summary>
    let hasMeasurementSample = _prefixId.prefix "hasMeasurementSample"
    /// <summary>
    ///   <para>skos:prefLabel : hasMeasurementTime</para>
    ///   <para>rdfs:label : hasMeasurementTime</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasMeasurementTime">chameo:hasMeasurementTime</a>
    /// </summary>
    let hasMeasurementTime = _prefixId.prefix "hasMeasurementTime"
    /// <summary>
    ///   <para>skos:prefLabel : hasOperator</para>
    ///   <para>rdfs:label : hasOperator</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasOperator">chameo:hasOperator</a>
    /// </summary>
    let hasOperator = _prefixId.prefix "hasOperator"
    /// <summary>
    ///   <para>skos:prefLabel : hasPeerReviewedArticle</para>
    ///   <para>rdfs:label : hasPeerReviewedArticle</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPeerReviewedArticle">chameo:hasPeerReviewedArticle</a>
    /// </summary>
    let hasPeerReviewedArticle = _prefixId.prefix "hasPeerReviewedArticle"
    /// <summary>
    ///   <para>skos:prefLabel : hasPhysicsOfInteraction</para>
    ///   <para>rdfs:label : hasPhysicsOfInteraction</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPhysicsOfInteraction">chameo:hasPhysicsOfInteraction</a>
    /// </summary>
    let hasPhysicsOfInteraction = _prefixId.prefix "hasPhysicsOfInteraction"
    /// <summary>
    ///   <para>skos:prefLabel : hasPostProcessingModel</para>
    ///   <para>rdfs:label : hasPostProcessingModel</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasPostProcessingModel">chameo:hasPostProcessingModel</a>
    /// </summary>
    let hasPostProcessingModel = _prefixId.prefix "hasPostProcessingModel"
    /// <summary>
    ///   <para>skos:prefLabel : hasProcessingReproducibility</para>
    ///   <para>rdfs:label : hasProcessingReproducibility</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasProcessingReproducibility">chameo:hasProcessingReproducibility</a>
    /// </summary>
    let hasProcessingReproducibility = _prefixId.prefix "hasProcessingReproducibility"

    /// <summary>
    ///   <para>skos:prefLabel : hasSampleBeforeSamplePreparation</para>
    ///   <para>rdfs:label : hasSampleBeforeSamplePreparation</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampleBeforeSamplePreparation">chameo:hasSampleBeforeSamplePreparation</a>
    /// </summary>
    let hasSampleBeforeSamplePreparation =
        _prefixId.prefix "hasSampleBeforeSamplePreparation"

    /// <summary>
    ///   <para>skos:prefLabel : hasSamplePreparationHardware</para>
    ///   <para>rdfs:label : hasSamplePreparationHardware</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationHardware">chameo:hasSamplePreparationHardware</a>
    /// </summary>
    let hasSamplePreparationHardware = _prefixId.prefix "hasSamplePreparationHardware"
    /// <summary>
    ///   <para>skos:prefLabel : hasSamplePreparationInput</para>
    ///   <para>rdfs:label : hasSamplePreparationInput</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationInput">chameo:hasSamplePreparationInput</a>
    /// </summary>
    let hasSamplePreparationInput = _prefixId.prefix "hasSamplePreparationInput"
    /// <summary>
    ///   <para>skos:prefLabel : hasSamplePreparationOutput</para>
    ///   <para>rdfs:label : hasSamplePreparationOutput</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationOutput">chameo:hasSamplePreparationOutput</a>
    /// </summary>
    let hasSamplePreparationOutput = _prefixId.prefix "hasSamplePreparationOutput"
    /// <summary>
    ///   <para>skos:prefLabel : hasSamplePreparationParameter</para>
    ///   <para>rdfs:label : hasSamplePreparationParameter</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSamplePreparationParameter">chameo:hasSamplePreparationParameter</a>
    /// </summary>
    let hasSamplePreparationParameter = _prefixId.prefix "hasSamplePreparationParameter"
    /// <summary>
    ///   <para>skos:prefLabel : hasSampledSample</para>
    ///   <para>rdfs:label : hasSampledSample</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#hasSampledSample">chameo:hasSampledSample</a>
    /// </summary>
    let hasSampledSample = _prefixId.prefix "hasSampledSample"
    /// <summary>
    ///   <para>skos:prefLabel : requiresLevelOfExpertise</para>
    ///   <para>rdfs:label : requiresLevelOfExpertise</para>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <a href="https://w3id.org/emmo/domain/characterisation-methodology/chameo#requiresLevelOfExpertise">chameo:requiresLevelOfExpertise</a>
    /// </summary>
    let requiresLevelOfExpertise = _prefixId.prefix "requiresLevelOfExpertise"
