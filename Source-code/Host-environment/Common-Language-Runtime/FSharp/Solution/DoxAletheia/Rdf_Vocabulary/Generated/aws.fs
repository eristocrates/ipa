namespace http.purl.oclc.org.NET.ssnx.meteo.aws.hash

open DoxAletheia.Rdf_Vocabulary

module aws =
    let _namespace_name = "http://purl.oclc.org/NET/ssnx/meteo/aws#"

    /// <summary>
    /// pair of upward and downward facing solarimeters
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Albedometer"></see></summary>
    let Albedometer =
        Namespaced_IRI.parse _namespace_name "Albedometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#RadiationSensor"></see>
    /// </summary>
    let RadiationSensor =
        Namespaced_IRI.parse _namespace_name "RadiationSensor" |> NamespacedName

    /// <summary>
    /// The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AneroidDisplacementTransducer"></see></summary>
    let AneroidDisplacementTransducer =
        Namespaced_IRI.parse _namespace_name "AneroidDisplacementTransducer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmosphericPressureSensor"></see>
    /// </summary>
    let AtmosphericPressureSensor =
        Namespaced_IRI.parse _namespace_name "AtmosphericPressureSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmometerOrSmallSurfaceEvaporimeter"></see>
    /// </summary>
    let AtmometerOrSmallSurfaceEvaporimeter =
        Namespaced_IRI.parse _namespace_name "AtmometerOrSmallSurfaceEvaporimeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ScreenedAndOpenPanEvaporimeter"></see>
    /// </summary>
    let ScreenedAndOpenPanEvaporimeter =
        Namespaced_IRI.parse _namespace_name "ScreenedAndOpenPanEvaporimeter" |> NamespacedName

    /// <summary>
    /// time during which direct radiation (on a plane perpendicular to the Sun’s beam) is larger than 120 Wm-2.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#AutomaticSunshineRecorder"></see></summary>
    let AutomaticSunshineRecorder =
        Namespaced_IRI.parse _namespace_name "AutomaticSunshineRecorder" |> NamespacedName

    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#BimetallicActinograph"></see></summary>
    let BimetallicActinograph =
        Namespaced_IRI.parse _namespace_name "BimetallicActinograph" |> NamespacedName

    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyranometer"></see></summary>
    let Pyranometer =
        Namespaced_IRI.parse _namespace_name "Pyranometer" |> NamespacedName

    /// <summary>
    /// World standard abolished in 1989
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CampbellStokesSunshineMeter"></see></summary>
    let CampbellStokesSunshineMeter =
        Namespaced_IRI.parse _namespace_name "CampbellStokesSunshineMeter" |> NamespacedName

    /// <summary>
    /// certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitanceSensor"></see></summary>
    let CapacitanceSensor =
        Namespaced_IRI.parse _namespace_name "CapacitanceSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HumiditySensor"></see>
    /// </summary>
    let HumiditySensor =
        Namespaced_IRI.parse _namespace_name "HumiditySensor" |> NamespacedName

    /// <summary>
    /// certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAluminumOxide"></see></summary>
    let CapacitiveAluminumOxide =
        Namespaced_IRI.parse _namespace_name "CapacitiveAluminumOxide" |> NamespacedName

    /// <summary>
    /// The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAneroid"></see></summary>
    let CapacitiveAneroid =
        Namespaced_IRI.parse _namespace_name "CapacitiveAneroid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveBead"></see>
    /// </summary>
    let CapacitiveBead =
        Namespaced_IRI.parse _namespace_name "CapacitiveBead" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TemperatureSensor"></see>
    /// </summary>
    let TemperatureSensor =
        Namespaced_IRI.parse _namespace_name "TemperatureSensor" |> NamespacedName

    /// <summary>
    /// certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveThinFilmPolymer"></see></summary>
    let CapacitiveThinFilmPolymer =
        Namespaced_IRI.parse _namespace_name "CapacitiveThinFilmPolymer" |> NamespacedName

    /// <summary>
    /// condensation is detected on the surface of a small polished metal reflecting surface (a mirror), using optical means. The temperature at which condensation is formed is the dew point.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorHygrometer"></see></summary>
    let ChilledMirrorHygrometer =
        Namespaced_IRI.parse _namespace_name "ChilledMirrorHygrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorSystem"></see>
    /// </summary>
    let ChilledMirrorSystem =
        Namespaced_IRI.parse _namespace_name "ChilledMirrorSystem" |> NamespacedName

    /// <summary>
    /// the angular velocity of the cup is directly proportional to the component of the wind speed parallel to the axis of rotation.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CupAnemometer"></see></summary>
    let CupAnemometer =
        Namespaced_IRI.parse _namespace_name "CupAnemometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindSensor"></see>
    /// </summary>
    let WindSensor = Namespaced_IRI.parse _namespace_name "WindSensor" |> NamespacedName

    /// <summary>
    /// A cylindrical resonator barometer (or vibrating cylinder air-pressure transducer) is designed to measure absolute air pressure using the vibrating element principle, providing a frequency output from which pressure is computed.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#CylindricalResonatorBarometer"></see></summary>
    let CylindricalResonatorBarometer =
        Namespaced_IRI.parse _namespace_name "CylindricalResonatorBarometer" |> NamespacedName

    /// <summary>
    /// A dew cell heats a salt solution until its equilibrium vapour pressure equals to the ambient vapour pressure, and maintains this equilibrium The temperature when this occurs is measured and it provides a measure of the ambient vapour pressure
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewCell"></see></summary>
    let DewCell = Namespaced_IRI.parse _namespace_name "DewCell" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewcelSystem"></see>
    /// </summary>
    let DewcelSystem =
        Namespaced_IRI.parse _namespace_name "DewcelSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DifferentialExpansionThermometer"></see>
    /// </summary>
    let DifferentialExpansionThermometer =
        Namespaced_IRI.parse _namespace_name "DifferentialExpansionThermometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DigitalPiezoResistiveBarometer"></see>
    /// </summary>
    let DigitalPiezoResistiveBarometer =
        Namespaced_IRI.parse _namespace_name "DigitalPiezoResistiveBarometer" |> NamespacedName

    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DirmhirmSaubererPyranometer"></see></summary>
    let DirmhirmSaubererPyranometer =
        Namespaced_IRI.parse _namespace_name "DirmhirmSaubererPyranometer" |> NamespacedName

    /// <summary>
    /// Counting the number of uniform droplets corresponding to a fixed volume of water
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#DropCounters"></see></summary>
    let DropCounters =
        Namespaced_IRI.parse _namespace_name "DropCounters" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PrecipitationSensor"></see>
    /// </summary>
    let PrecipitationSensor =
        Namespaced_IRI.parse _namespace_name "PrecipitationSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness"></see>
    /// </summary>
    let ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness =
        Namespaced_IRI.parse _namespace_name "ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceBlock"></see>
    /// </summary>
    let ElectricalResistanceBlock =
        Namespaced_IRI.parse _namespace_name "ElectricalResistanceBlock" |> NamespacedName

    /// <summary>
    /// certain materials interact with water vapour and undergo a change in electrical resistance, in relation to ambient humidity.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceHumiditySensor"></see></summary>
    let ElectricalResistanceHumiditySensor =
        Namespaced_IRI.parse _namespace_name "ElectricalResistanceHumiditySensor" |> NamespacedName

    /// <summary>
    /// For small temperature changes, the increase in resistance of pure metals is proportional to the change in temperature. Often made in Platinum.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceThermometer"></see></summary>
    let ElectricalResistanceThermometer =
        Namespaced_IRI.parse _namespace_name "ElectricalResistanceThermometer" |> NamespacedName

    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#EppleyPyranometer"></see></summary>
    let EppleyPyranometer =
        Namespaced_IRI.parse _namespace_name "EppleyPyranometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#FiberGlassBlock"></see>
    /// </summary>
    let FiberGlassBlock =
        Namespaced_IRI.parse _namespace_name "FiberGlassBlock" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#FrequencyDomainReflectometryCapacitance"></see>
    /// </summary>
    let FrequencyDomainReflectometryCapacitance =
        Namespaced_IRI.parse _namespace_name "FrequencyDomainReflectometryCapacitance" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#GammaAbsorption"></see>
    /// </summary>
    let GammaAbsorption =
        Namespaced_IRI.parse _namespace_name "GammaAbsorption" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#GypsumBlock"></see>
    /// </summary>
    let GypsumBlock =
        Namespaced_IRI.parse _namespace_name "GypsumBlock" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotBeadAnemometer"></see>
    /// </summary>
    let HotBeadAnemometer =
        Namespaced_IRI.parse _namespace_name "HotBeadAnemometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotWireAnemometer"></see>
    /// </summary>
    let HotWireAnemometer =
        Namespaced_IRI.parse _namespace_name "HotWireAnemometer" |> NamespacedName

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#HydraulicLysimeterMoreRobustWeighingType"></see></summary>
    let HydraulicLysimeterMoreRobustWeighingType =
        Namespaced_IRI.parse _namespace_name "HydraulicLysimeterMoreRobustWeighingType" |> NamespacedName

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Lysimeter"></see></summary>
    let Lysimeter = Namespaced_IRI.parse _namespace_name "Lysimeter" |> NamespacedName

    /// <summary>
    /// Impact of precipitation particles on a plastic or metal membrane
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ImpactDisdrometer"></see></summary>
    let ImpactDisdrometer =
        Namespaced_IRI.parse _namespace_name "ImpactDisdrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#InfraRedGasAnalyzerHygrometer"></see>
    /// </summary>
    let InfraRedGasAnalyzerHygrometer =
        Namespaced_IRI.parse _namespace_name "InfraRedGasAnalyzerHygrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#KataThermometer"></see>
    /// </summary>
    let KataThermometer =
        Namespaced_IRI.parse _namespace_name "KataThermometer" |> NamespacedName

    /// <summary>
    /// emits modulated visible laser light and determines the distance to an object by comparing phase information
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Laser"></see></summary>
    let Laser = Namespaced_IRI.parse _namespace_name "Laser" |> NamespacedName

    /// <summary>
    /// Measuring the water level in a tube
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#LevelMeasurementRainGauge"></see></summary>
    let LevelMeasurementRainGauge =
        Namespaced_IRI.parse _namespace_name "LevelMeasurementRainGauge" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalAneroidBarometer"></see>
    /// </summary>
    let MechanicalAneroidBarometer =
        Namespaced_IRI.parse _namespace_name "MechanicalAneroidBarometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalHygrometer"></see>
    /// </summary>
    let MechanicalHygrometer =
        Namespaced_IRI.parse _namespace_name "MechanicalHygrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalSensorWithRecorder"></see>
    /// </summary>
    let MechanicalSensorWithRecorder =
        Namespaced_IRI.parse _namespace_name "MechanicalSensorWithRecorder" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MercuryBarometer"></see>
    /// </summary>
    let MercuryBarometer =
        Namespaced_IRI.parse _namespace_name "MercuryBarometer" |> NamespacedName

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Microlysimeter"></see></summary>
    let Microlysimeter =
        Namespaced_IRI.parse _namespace_name "Microlysimeter" |> NamespacedName

    /// <summary>
    /// Backscatter (intensity of backscattered signal related to the number of particles and/or their water content)
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MicrowaveRadarDisdrometer"></see></summary>
    let MicrowaveRadarDisdrometer =
        Namespaced_IRI.parse _namespace_name "MicrowaveRadarDisdrometer" |> NamespacedName

    /// <summary>
    /// total solar irradiance on a horizontal surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#MollGorczynkiPyranometer"></see></summary>
    let MollGorczynkiPyranometer =
        Namespaced_IRI.parse _namespace_name "MollGorczynkiPyranometer" |> NamespacedName

    /// <summary>
    /// Net all-wave radiation (net flux of downward and upward total radiation i.e. solar, terrestrial and atmospheric)
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter"></see></summary>
    let NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter =
        Namespaced_IRI.parse _namespace_name "NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#NeutronProbe"></see>
    /// </summary>
    let NeutronProbe =
        Namespaced_IRI.parse _namespace_name "NeutronProbe" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#NylonUnits"></see>
    /// </summary>
    let NylonUnits = Namespaced_IRI.parse _namespace_name "NylonUnits" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalCapacitiveSensor"></see>
    /// </summary>
    let OpticalCapacitiveSensor =
        Namespaced_IRI.parse _namespace_name "OpticalCapacitiveSensor" |> NamespacedName

    /// <summary>
    /// Thin laser light sheets crossing the measuring volume: particle volume, speed (forward scatter)
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalDisdrometer"></see></summary>
    let OpticalDisdrometer =
        Namespaced_IRI.parse _namespace_name "OpticalDisdrometer" |> NamespacedName

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PopoffLysimeterCombinedDrainageAndWeighingType"></see></summary>
    let PopoffLysimeterCombinedDrainageAndWeighingType =
        Namespaced_IRI.parse _namespace_name "PopoffLysimeterCombinedDrainageAndWeighingType" |> NamespacedName

    /// <summary>
    /// Artificially ventilated psychrometers, such as the Assmann type, the aspirated screen type, and the whirling type,
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PortableAspiratedAndShieldedPsychrometer"></see></summary>
    let PortableAspiratedAndShieldedPsychrometer =
        Namespaced_IRI.parse _namespace_name "PortableAspiratedAndShieldedPsychrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PressureTubeAnemometer"></see>
    /// </summary>
    let PressureTubeAnemometer =
        Namespaced_IRI.parse _namespace_name "PressureTubeAnemometer" |> NamespacedName

    /// <summary>
    /// the angular velocity of the propeller rotor is directly proportional to the component of the wind speed parallel to the axis of rotation.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PropellerAnemometer"></see></summary>
    let PropellerAnemometer =
        Namespaced_IRI.parse _namespace_name "PropellerAnemometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PsychrometerEquippedWithMercuryInGlassThermometer"></see>
    /// </summary>
    let PsychrometerEquippedWithMercuryInGlassThermometer =
        Namespaced_IRI.parse _namespace_name "PsychrometerEquippedWithMercuryInGlassThermometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#PyranometerWithShadeRing"></see>
    /// </summary>
    let PyranometerWithShadeRing =
        Namespaced_IRI.parse _namespace_name "PyranometerWithShadeRing" |> NamespacedName

    /// <summary>
    /// measurement of long-wave radiation from the earth
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyrgeometer"></see></summary>
    let Pyrgeometer =
        Namespaced_IRI.parse _namespace_name "Pyrgeometer" |> NamespacedName

    /// <summary>
    /// measure the PAR directly in the range 0.4 to 0.7 micrometers
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#QuantumSensor"></see></summary>
    let QuantumSensor =
        Namespaced_IRI.parse _namespace_name "QuantumSensor" |> NamespacedName

    /// <summary>
    /// The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ResistiveAneroid"></see></summary>
    let ResistiveAneroid =
        Namespaced_IRI.parse _namespace_name "ResistiveAneroid" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ShadedPicheEvaporimeter"></see>
    /// </summary>
    let ShadedPicheEvaporimeter =
        Namespaced_IRI.parse _namespace_name "ShadedPicheEvaporimeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SingleOrDoubleJunctionPeltierPsychrometer"></see>
    /// </summary>
    let SingleOrDoubleJunctionPeltierPsychrometer =
        Namespaced_IRI.parse _namespace_name "SingleOrDoubleJunctionPeltierPsychrometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowGauge"></see>
    /// </summary>
    let SnowGauge = Namespaced_IRI.parse _namespace_name "SnowGauge" |> NamespacedName
    /// <summary>
    /// Tensiometric sensors detect the hydrostatic pressure caused by the layer of snow on top of the pillow
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowPillow"></see></summary>
    let SnowPillow = Namespaced_IRI.parse _namespace_name "SnowPillow" |> NamespacedName

    /// <summary>
    /// measure the elapsed time between emission and return of an ultrasonic pulse sent vertically down to the snow covered ground surface
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SonicRanging"></see></summary>
    let SonicRanging =
        Namespaced_IRI.parse _namespace_name "SonicRanging" |> NamespacedName

    /// <summary>
    /// measurements of infra-red radiation emitted from near or remote surfaces
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#SurfaceTemperatureRadiometer"></see></summary>
    let SurfaceTemperatureRadiometer =
        Namespaced_IRI.parse _namespace_name "SurfaceTemperatureRadiometer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Tensiometer"></see>
    /// </summary>
    let Tensiometer =
        Namespaced_IRI.parse _namespace_name "Tensiometer" |> NamespacedName

    /// <summary>
    /// Based on the variation of resistance of a semiconductor with a relatively large temperature coefficient of resistance, either positive (PTC) or negative (NTC) depending upon the actual material
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermistor"></see></summary>
    let Thermistor = Namespaced_IRI.parse _namespace_name "Thermistor" |> NamespacedName

    /// <summary>
    /// Based on the generation of an electromotive force at the junction between two metals in contact, which is function of the temperature of the two metals
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermocouple"></see></summary>
    let Thermocouple =
        Namespaced_IRI.parse _namespace_name "Thermocouple" |> NamespacedName

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#ThornthwaiteLysimeterDrainageType"></see></summary>
    let ThornthwaiteLysimeterDrainageType =
        Namespaced_IRI.parse _namespace_name "ThornthwaiteLysimeterDrainageType" |> NamespacedName

    /// <summary>
    /// Time domain reflectometry (TDR) and time delay transmission
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TimeDomainReflectometry"></see></summary>
    let TimeDomainReflectometry =
        Namespaced_IRI.parse _namespace_name "TimeDomainReflectometry" |> NamespacedName

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGauge"></see></summary>
    let TippingBucketRainGauge =
        Namespaced_IRI.parse _namespace_name "TippingBucketRainGauge" |> NamespacedName

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeTbrgWithoutCorrection"></see></summary>
    let TippingBucketRainGaugeTbrgWithoutCorrection =
        Namespaced_IRI.parse _namespace_name "TippingBucketRainGaugeTbrgWithoutCorrection" |> NamespacedName

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc"></see></summary>
    let TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc =
        Namespaced_IRI.parse _namespace_name "TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc" |> NamespacedName

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc"></see></summary>
    let TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc =
        Namespaced_IRI.parse _namespace_name "TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc" |> NamespacedName

    /// <summary>
    /// Tipping balance of two buckets
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc"></see></summary>
    let TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc =
        Namespaced_IRI.parse _namespace_name "TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#TubeSolarimeter"></see>
    /// </summary>
    let TubeSolarimeter =
        Namespaced_IRI.parse _namespace_name "TubeSolarimeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicSensorVirtualTemperature"></see>
    /// </summary>
    let UltrasonicSensorVirtualTemperature =
        Namespaced_IRI.parse _namespace_name "UltrasonicSensorVirtualTemperature" |> NamespacedName

    /// <summary>
    /// A sonic signal is emitted by sensor transducers
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicWindSensor"></see></summary>
    let UltrasonicWindSensor =
        Namespaced_IRI.parse _namespace_name "UltrasonicWindSensor" |> NamespacedName

    /// <summary>
    /// Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingLysimeter"></see></summary>
    let WeighingLysimeter =
        Namespaced_IRI.parse _namespace_name "WeighingLysimeter" |> NamespacedName

    /// <summary>
    /// Weighing of precipitation accumulated in a storage container
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGauge"></see></summary>
    let WeighingRainGauge =
        Namespaced_IRI.parse _namespace_name "WeighingRainGauge" |> NamespacedName

    /// <summary>
    /// Weighing of precipitation accumulated in a storage container
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGaugeWithPressureMeasurement"></see></summary>
    let WeighingRainGaugeWithPressureMeasurement =
        Namespaced_IRI.parse _namespace_name "WeighingRainGaugeWithPressureMeasurement" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WetBulbTemperatureMeasurementSystem"></see>
    /// </summary>
    let WetBulbTemperatureMeasurementSystem =
        Namespaced_IRI.parse _namespace_name "WetBulbTemperatureMeasurementSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WettingFrontDetection"></see>
    /// </summary>
    let WettingFrontDetection =
        Namespaced_IRI.parse _namespace_name "WettingFrontDetection" |> NamespacedName

    /// <summary>
    /// The signal generator is a shaft angle transducer: potentiometers, alternating and direct current synchros, digital angle-encoder disks, direct reading dials, and rotary switches
    /// <see href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindVane"></see></summary>
    let WindVane = Namespaced_IRI.parse _namespace_name "WindVane" |> NamespacedName
