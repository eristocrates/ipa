namespace http.purl.oclc.org.NET.ssnx.meteo.aws.hash

open DoxAletheia

module aws =
    let _namespace_name = "http://purl.oclc.org/NET/ssnx/meteo/aws#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// pair of upward and downward facing solarimeters
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Albedometer"></see></summary>
    let Albedometer = _prefix "Albedometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#RadiationSensor"></see>
    /// </summary>
    let RadiationSensor = _prefix "RadiationSensor"
    /// <summary>
    /// The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AneroidDisplacementTransducer"></see></summary>
    let AneroidDisplacementTransducer = _prefix "AneroidDisplacementTransducer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmosphericPressureSensor"></see>
    /// </summary>
    let AtmosphericPressureSensor = _prefix "AtmosphericPressureSensor"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmometerOrSmallSurfaceEvaporimeter"></see>
    /// </summary>
    let AtmometerOrSmallSurfaceEvaporimeter =
        _prefix "AtmometerOrSmallSurfaceEvaporimeter"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ScreenedAndOpenPanEvaporimeter"></see>
    /// </summary>
    let ScreenedAndOpenPanEvaporimeter = _prefix "ScreenedAndOpenPanEvaporimeter"
    /// <summary>
    /// time during which direct radiation (on a plane perpendicular to the Sun’s beam) is larger than 120 Wm-2.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AutomaticSunshineRecorder"></see></summary>
    let AutomaticSunshineRecorder = _prefix "AutomaticSunshineRecorder"
    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#BimetallicActinograph"></see></summary>
    let BimetallicActinograph = _prefix "BimetallicActinograph"
    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyranometer"></see></summary>
    let Pyranometer = _prefix "Pyranometer"
    /// <summary>
    /// World standard abolished in 1989
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CampbellStokesSunshineMeter"></see></summary>
    let CampbellStokesSunshineMeter = _prefix "CampbellStokesSunshineMeter"
    /// <summary>
    /// certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitanceSensor"></see></summary>
    let CapacitanceSensor = _prefix "CapacitanceSensor"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HumiditySensor"></see>
    /// </summary>
    let HumiditySensor = _prefix "HumiditySensor"
    /// <summary>
    /// certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAluminumOxide"></see></summary>
    let CapacitiveAluminumOxide = _prefix "CapacitiveAluminumOxide"
    /// <summary>
    /// The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAneroid"></see></summary>
    let CapacitiveAneroid = _prefix "CapacitiveAneroid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveBead"></see>
    /// </summary>
    let CapacitiveBead = _prefix "CapacitiveBead"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TemperatureSensor"></see>
    /// </summary>
    let TemperatureSensor = _prefix "TemperatureSensor"
    /// <summary>
    /// certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveThinFilmPolymer"></see></summary>
    let CapacitiveThinFilmPolymer = _prefix "CapacitiveThinFilmPolymer"
    /// <summary>
    /// condensation is detected on the surface of a small polished metal reflecting surface (a mirror), using optical means. The temperature at which condensation is formed is the dew point.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorHygrometer"></see></summary>
    let ChilledMirrorHygrometer = _prefix "ChilledMirrorHygrometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorSystem"></see>
    /// </summary>
    let ChilledMirrorSystem = _prefix "ChilledMirrorSystem"
    /// <summary>
    /// the angular velocity of the cup is directly proportional to the component of the wind speed parallel to the axis of rotation.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CupAnemometer"></see></summary>
    let CupAnemometer = _prefix "CupAnemometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindSensor"></see>
    /// </summary>
    let WindSensor = _prefix "WindSensor"
    /// <summary>
    /// A cylindrical resonator barometer (or vibrating cylinder air-pressure transducer) is designed to measure absolute air pressure using the vibrating element principle, providing a frequency output from which pressure is computed.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CylindricalResonatorBarometer"></see></summary>
    let CylindricalResonatorBarometer = _prefix "CylindricalResonatorBarometer"
    /// <summary>
    /// A dew cell heats a salt solution until its equilibrium vapour pressure equals to the ambient vapour pressure, and maintains this equilibrium The temperature when this occurs is measured and it provides a measure of the ambient vapour pressure
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewCell"></see></summary>
    let DewCell = _prefix "DewCell"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewcelSystem"></see>
    /// </summary>
    let DewcelSystem = _prefix "DewcelSystem"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DifferentialExpansionThermometer"></see>
    /// </summary>
    let DifferentialExpansionThermometer = _prefix "DifferentialExpansionThermometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DigitalPiezoResistiveBarometer"></see>
    /// </summary>
    let DigitalPiezoResistiveBarometer = _prefix "DigitalPiezoResistiveBarometer"
    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DirmhirmSaubererPyranometer"></see></summary>
    let DirmhirmSaubererPyranometer = _prefix "DirmhirmSaubererPyranometer"
    /// <summary>
    /// Counting the number of uniform droplets corresponding to a fixed volume of water
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DropCounters"></see></summary>
    let DropCounters = _prefix "DropCounters"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PrecipitationSensor"></see>
    /// </summary>
    let PrecipitationSensor = _prefix "PrecipitationSensor"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness"></see>
    /// </summary>
    let ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness =
        _prefix "ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceBlock"></see>
    /// </summary>
    let ElectricalResistanceBlock = _prefix "ElectricalResistanceBlock"

    /// <summary>
    /// certain materials interact with water vapour and undergo a change in electrical resistance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceHumiditySensor"></see></summary>
    let ElectricalResistanceHumiditySensor =
        _prefix "ElectricalResistanceHumiditySensor"

    /// <summary>
    /// For small temperature changes, the increase in resistance of pure metals is proportional to the change in temperature. Often made in Platinum.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceThermometer"></see></summary>
    let ElectricalResistanceThermometer = _prefix "ElectricalResistanceThermometer"
    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#EppleyPyranometer"></see></summary>
    let EppleyPyranometer = _prefix "EppleyPyranometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#FiberGlassBlock"></see>
    /// </summary>
    let FiberGlassBlock = _prefix "FiberGlassBlock"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#FrequencyDomainReflectometryCapacitance"></see>
    /// </summary>
    let FrequencyDomainReflectometryCapacitance =
        _prefix "FrequencyDomainReflectometryCapacitance"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#GammaAbsorption"></see>
    /// </summary>
    let GammaAbsorption = _prefix "GammaAbsorption"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#GypsumBlock"></see>
    /// </summary>
    let GypsumBlock = _prefix "GypsumBlock"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotBeadAnemometer"></see>
    /// </summary>
    let HotBeadAnemometer = _prefix "HotBeadAnemometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotWireAnemometer"></see>
    /// </summary>
    let HotWireAnemometer = _prefix "HotWireAnemometer"

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HydraulicLysimeterMoreRobustWeighingType"></see></summary>
    let HydraulicLysimeterMoreRobustWeighingType =
        _prefix "HydraulicLysimeterMoreRobustWeighingType"

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Lysimeter"></see></summary>
    let Lysimeter = _prefix "Lysimeter"
    /// <summary>
    /// Impact of precipitation particles on a plastic or metal membrane
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ImpactDisdrometer"></see></summary>
    let ImpactDisdrometer = _prefix "ImpactDisdrometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#InfraRedGasAnalyzerHygrometer"></see>
    /// </summary>
    let InfraRedGasAnalyzerHygrometer = _prefix "InfraRedGasAnalyzerHygrometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#KataThermometer"></see>
    /// </summary>
    let KataThermometer = _prefix "KataThermometer"
    /// <summary>
    /// emits modulated visible laser light and determines the distance to an object by comparing phase information
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Laser"></see></summary>
    let Laser = _prefix "Laser"
    /// <summary>
    /// Measuring the water level in a tube
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#LevelMeasurementRainGauge"></see></summary>
    let LevelMeasurementRainGauge = _prefix "LevelMeasurementRainGauge"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalAneroidBarometer"></see>
    /// </summary>
    let MechanicalAneroidBarometer = _prefix "MechanicalAneroidBarometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalHygrometer"></see>
    /// </summary>
    let MechanicalHygrometer = _prefix "MechanicalHygrometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalSensorWithRecorder"></see>
    /// </summary>
    let MechanicalSensorWithRecorder = _prefix "MechanicalSensorWithRecorder"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MercuryBarometer"></see>
    /// </summary>
    let MercuryBarometer = _prefix "MercuryBarometer"
    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Microlysimeter"></see></summary>
    let Microlysimeter = _prefix "Microlysimeter"
    /// <summary>
    /// Backscatter (intensity of backscattered signal related to the number of particles and/or their water content)
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MicrowaveRadarDisdrometer"></see></summary>
    let MicrowaveRadarDisdrometer = _prefix "MicrowaveRadarDisdrometer"
    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MollGorczynkiPyranometer"></see></summary>
    let MollGorczynkiPyranometer = _prefix "MollGorczynkiPyranometer"

    /// <summary>
    /// Net all-wave radiation (net flux of downward and upward total radiation i.e. solar, terrestrial and atmospheric)
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter"></see></summary>
    let NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter =
        _prefix "NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#NeutronProbe"></see>
    /// </summary>
    let NeutronProbe = _prefix "NeutronProbe"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#NylonUnits"></see>
    /// </summary>
    let NylonUnits = _prefix "NylonUnits"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalCapacitiveSensor"></see>
    /// </summary>
    let OpticalCapacitiveSensor = _prefix "OpticalCapacitiveSensor"
    /// <summary>
    /// Thin laser light sheets crossing the measuring volume: particle volume, speed (forward scatter)
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalDisdrometer"></see></summary>
    let OpticalDisdrometer = _prefix "OpticalDisdrometer"

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PopoffLysimeterCombinedDrainageAndWeighingType"></see></summary>
    let PopoffLysimeterCombinedDrainageAndWeighingType =
        _prefix "PopoffLysimeterCombinedDrainageAndWeighingType"

    /// <summary>
    /// Artificially ventilated psychrometers, such as the Assmann type, the aspirated screen type, and the whirling type,
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PortableAspiratedAndShieldedPsychrometer"></see></summary>
    let PortableAspiratedAndShieldedPsychrometer =
        _prefix "PortableAspiratedAndShieldedPsychrometer"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PressureTubeAnemometer"></see>
    /// </summary>
    let PressureTubeAnemometer = _prefix "PressureTubeAnemometer"
    /// <summary>
    /// the angular velocity of the propeller rotor is directly proportional to the component of the wind speed parallel to the axis of rotation.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PropellerAnemometer"></see></summary>
    let PropellerAnemometer = _prefix "PropellerAnemometer"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PsychrometerEquippedWithMercuryInGlassThermometer"></see>
    /// </summary>
    let PsychrometerEquippedWithMercuryInGlassThermometer =
        _prefix "PsychrometerEquippedWithMercuryInGlassThermometer"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PyranometerWithShadeRing"></see>
    /// </summary>
    let PyranometerWithShadeRing = _prefix "PyranometerWithShadeRing"
    /// <summary>
    /// measurement of long-wave radiation from the earth
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyrgeometer"></see></summary>
    let Pyrgeometer = _prefix "Pyrgeometer"
    /// <summary>
    /// measure the PAR directly in the range 0.4 to 0.7 micrometers
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#QuantumSensor"></see></summary>
    let QuantumSensor = _prefix "QuantumSensor"
    /// <summary>
    /// The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ResistiveAneroid"></see></summary>
    let ResistiveAneroid = _prefix "ResistiveAneroid"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ShadedPicheEvaporimeter"></see>
    /// </summary>
    let ShadedPicheEvaporimeter = _prefix "ShadedPicheEvaporimeter"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SingleOrDoubleJunctionPeltierPsychrometer"></see>
    /// </summary>
    let SingleOrDoubleJunctionPeltierPsychrometer =
        _prefix "SingleOrDoubleJunctionPeltierPsychrometer"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowGauge"></see>
    /// </summary>
    let SnowGauge = _prefix "SnowGauge"
    /// <summary>
    /// Tensiometric sensors detect the hydrostatic pressure caused by the layer of snow on top of the pillow
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowPillow"></see></summary>
    let SnowPillow = _prefix "SnowPillow"
    /// <summary>
    /// measure the elapsed time between emission and return of an ultrasonic pulse sent vertically down to the snow covered ground surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SonicRanging"></see></summary>
    let SonicRanging = _prefix "SonicRanging"
    /// <summary>
    /// measurements of infra-red radiation emitted from near or remote surfaces
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SurfaceTemperatureRadiometer"></see></summary>
    let SurfaceTemperatureRadiometer = _prefix "SurfaceTemperatureRadiometer"
    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Tensiometer"></see>
    /// </summary>
    let Tensiometer = _prefix "Tensiometer"
    /// <summary>
    /// Based on the variation of resistance of a semiconductor with a relatively large temperature coefficient of resistance, either positive (PTC) or negative (NTC) depending upon the actual material
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermistor"></see></summary>
    let Thermistor = _prefix "Thermistor"
    /// <summary>
    /// Based on the generation of an electromotive force at the junction between two metals in contact, which is function of the temperature of the two metals
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermocouple"></see></summary>
    let Thermocouple = _prefix "Thermocouple"
    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ThornthwaiteLysimeterDrainageType"></see></summary>
    let ThornthwaiteLysimeterDrainageType = _prefix "ThornthwaiteLysimeterDrainageType"
    /// <summary>
    /// Time domain reflectometry (TDR) and time delay transmission
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TimeDomainReflectometry"></see></summary>
    let TimeDomainReflectometry = _prefix "TimeDomainReflectometry"
    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGauge"></see></summary>
    let TippingBucketRainGauge = _prefix "TippingBucketRainGauge"

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeTbrgWithoutCorrection"></see></summary>
    let TippingBucketRainGaugeTbrgWithoutCorrection =
        _prefix "TippingBucketRainGaugeTbrgWithoutCorrection"

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc"></see></summary>
    let TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc =
        _prefix "TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc"

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc"></see></summary>
    let TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc =
        _prefix "TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc"

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc"></see></summary>
    let TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc =
        _prefix "TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TubeSolarimeter"></see>
    /// </summary>
    let TubeSolarimeter = _prefix "TubeSolarimeter"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicSensorVirtualTemperature"></see>
    /// </summary>
    let UltrasonicSensorVirtualTemperature =
        _prefix "UltrasonicSensorVirtualTemperature"

    /// <summary>
    /// A sonic signal is emitted by sensor transducers
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicWindSensor"></see></summary>
    let UltrasonicWindSensor = _prefix "UltrasonicWindSensor"
    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingLysimeter"></see></summary>
    let WeighingLysimeter = _prefix "WeighingLysimeter"
    /// <summary>
    /// Weighing of precipitation accumulated in a storage container
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGauge"></see></summary>
    let WeighingRainGauge = _prefix "WeighingRainGauge"

    /// <summary>
    /// Weighing of precipitation accumulated in a storage container
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGaugeWithPressureMeasurement"></see></summary>
    let WeighingRainGaugeWithPressureMeasurement =
        _prefix "WeighingRainGaugeWithPressureMeasurement"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WetBulbTemperatureMeasurementSystem"></see>
    /// </summary>
    let WetBulbTemperatureMeasurementSystem =
        _prefix "WetBulbTemperatureMeasurementSystem"

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WettingFrontDetection"></see>
    /// </summary>
    let WettingFrontDetection = _prefix "WettingFrontDetection"
    /// <summary>
    /// The signal generator is a shaft angle transducer: potentiometers, alternating and direct current synchros, digital angle-encoder disks, direct reading dials, and rotary switches
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindVane"></see></summary>
    let WindVane = _prefix "WindVane"
