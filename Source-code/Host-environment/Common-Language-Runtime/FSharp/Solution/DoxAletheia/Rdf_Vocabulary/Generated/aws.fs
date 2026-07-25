namespace http.purl.oclc.org.NET.ssnx.meteo.aws.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module aws =
    let _namespace_iri = Namespace_Iri aws |> NamespaceIRI
    /// <summary>
    ///   <para>aws:Albedometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>pair of upward and downward facing solarimeters</para>
    /// labels<para>albedometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Albedometer">http://purl.oclc.org/NET/ssnx/meteo/aws#Albedometer</seealso>
    let Albedometer = Prefixed_Name(aws, "Albedometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:CapacitiveAluminumOxide</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.</para>
    /// labels<para>Capacitive - aluminum oxide</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAluminumOxide">http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAluminumOxide</seealso>
    let CapacitiveAluminumOxide =
        Prefixed_Name(aws, "CapacitiveAluminumOxide") |> PrefixedName

    /// <summary>
    ///   <para>aws:CapacitiveAneroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.</para>
    /// labels<para>Capacitive aneroid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAneroid">http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAneroid</seealso>
    let CapacitiveAneroid = Prefixed_Name(aws, "CapacitiveAneroid") |> PrefixedName
    /// <summary>
    ///   <para>aws:Pyranometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>total solar irradiance on a horizontal surface</para>
    /// labels<para>pyranometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyranometer">http://purl.oclc.org/NET/ssnx/meteo/aws#Pyranometer</seealso>
    let Pyranometer = Prefixed_Name(aws, "Pyranometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:CapacitanceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.</para>
    /// labels<para>capacitance sensor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitanceSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitanceSensor</seealso>
    let CapacitanceSensor = Prefixed_Name(aws, "CapacitanceSensor") |> PrefixedName
    /// <summary>
    ///   <para>aws:HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Humidity</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#HumiditySensor">http://purl.oclc.org/NET/ssnx/meteo/aws#HumiditySensor</seealso>
    let HumiditySensor = Prefixed_Name(aws, "HumiditySensor") |> PrefixedName
    /// <summary>
    ///   <para>aws:RadiationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Radiation</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#RadiationSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#RadiationSensor</seealso>
    let RadiationSensor = Prefixed_Name(aws, "RadiationSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:AneroidDisplacementTransducer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.</para>
    /// labels<para>aneroid displacement transducer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#AneroidDisplacementTransducer">http://purl.oclc.org/NET/ssnx/meteo/aws#AneroidDisplacementTransducer</seealso>
    let AneroidDisplacementTransducer =
        Prefixed_Name(aws, "AneroidDisplacementTransducer") |> PrefixedName

    /// <summary>
    ///   <para>aws:AtmosphericPressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Atmospheric pressure</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmosphericPressureSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#AtmosphericPressureSensor</seealso>
    let AtmosphericPressureSensor =
        Prefixed_Name(aws, "AtmosphericPressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:ScreenedAndOpenPanEvaporimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>screened and open pan evaporimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ScreenedAndOpenPanEvaporimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#ScreenedAndOpenPanEvaporimeter</seealso>
    let ScreenedAndOpenPanEvaporimeter =
        Prefixed_Name(aws, "ScreenedAndOpenPanEvaporimeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:AutomaticSunshineRecorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>time during which direct radiation (on a plane perpendicular to the Sun’s beam) is larger than 120 Wm-2.</para>
    /// labels<para>Automatic sunshine recorder</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#AutomaticSunshineRecorder">http://purl.oclc.org/NET/ssnx/meteo/aws#AutomaticSunshineRecorder</seealso>
    let AutomaticSunshineRecorder =
        Prefixed_Name(aws, "AutomaticSunshineRecorder") |> PrefixedName

    /// <summary>
    ///   <para>aws:ChilledMirrorSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Chilled mirror system</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorSystem">http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorSystem</seealso>
    let ChilledMirrorSystem = Prefixed_Name(aws, "ChilledMirrorSystem") |> PrefixedName
    /// <summary>
    ///   <para>aws:CupAnemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the angular velocity of the cup is directly proportional to the component of the wind speed parallel to the axis of rotation.</para>
    /// labels<para>Cup anemometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CupAnemometer">http://purl.oclc.org/NET/ssnx/meteo/aws#CupAnemometer</seealso>
    let CupAnemometer = Prefixed_Name(aws, "CupAnemometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:WindSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Wind</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#WindSensor</seealso>
    let WindSensor = Prefixed_Name(aws, "WindSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:CylindricalResonatorBarometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A cylindrical resonator barometer (or vibrating cylinder air-pressure transducer) is designed to measure absolute air pressure using the vibrating element principle, providing a frequency output from which pressure is computed.</para>
    /// labels<para>cylindrical resonator barometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CylindricalResonatorBarometer">http://purl.oclc.org/NET/ssnx/meteo/aws#CylindricalResonatorBarometer</seealso>
    let CylindricalResonatorBarometer =
        Prefixed_Name(aws, "CylindricalResonatorBarometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:DewCell</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dew cell heats a salt solution until its equilibrium vapour pressure equals to the ambient vapour pressure, and maintains this equilibrium The temperature when this occurs is measured and it provides a measure of the ambient vapour pressure</para>
    /// labels<para>dew cell</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewCell">http://purl.oclc.org/NET/ssnx/meteo/aws#DewCell</seealso>
    let DewCell = Prefixed_Name(aws, "DewCell") |> PrefixedName
    /// <summary>
    ///   <para>aws:DewcelSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Dewcel system</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewcelSystem">http://purl.oclc.org/NET/ssnx/meteo/aws#DewcelSystem</seealso>
    let DewcelSystem = Prefixed_Name(aws, "DewcelSystem") |> PrefixedName

    /// <summary>
    ///   <para>aws:DifferentialExpansionThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>differential expansion thermometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#DifferentialExpansionThermometer">http://purl.oclc.org/NET/ssnx/meteo/aws#DifferentialExpansionThermometer</seealso>
    let DifferentialExpansionThermometer =
        Prefixed_Name(aws, "DifferentialExpansionThermometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:DigitalPiezoResistiveBarometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>digital piezo-resistive barometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#DigitalPiezoResistiveBarometer">http://purl.oclc.org/NET/ssnx/meteo/aws#DigitalPiezoResistiveBarometer</seealso>
    let DigitalPiezoResistiveBarometer =
        Prefixed_Name(aws, "DigitalPiezoResistiveBarometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:DirmhirmSaubererPyranometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>total solar irradiance on a horizontal surface</para>
    /// labels<para>Dirmhirm-Sauberer pyranometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#DirmhirmSaubererPyranometer">http://purl.oclc.org/NET/ssnx/meteo/aws#DirmhirmSaubererPyranometer</seealso>
    let DirmhirmSaubererPyranometer =
        Prefixed_Name(aws, "DirmhirmSaubererPyranometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:HotWireAnemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hot-wire anemometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotWireAnemometer">http://purl.oclc.org/NET/ssnx/meteo/aws#HotWireAnemometer</seealso>
    let HotWireAnemometer = Prefixed_Name(aws, "HotWireAnemometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:PropellerAnemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>the angular velocity of the propeller rotor is directly proportional to the component of the wind speed parallel to the axis of rotation.</para>
    /// labels<para>Propeller anemometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PropellerAnemometer">http://purl.oclc.org/NET/ssnx/meteo/aws#PropellerAnemometer</seealso>
    let PropellerAnemometer = Prefixed_Name(aws, "PropellerAnemometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:PsychrometerEquippedWithMercuryInGlassThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>psychrometer equipped with mercury-in-glass thermometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PsychrometerEquippedWithMercuryInGlassThermometer">http://purl.oclc.org/NET/ssnx/meteo/aws#PsychrometerEquippedWithMercuryInGlassThermometer</seealso>
    let PsychrometerEquippedWithMercuryInGlassThermometer =
        Prefixed_Name(aws, "PsychrometerEquippedWithMercuryInGlassThermometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:PyranometerWithShadeRing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>pyranometer with shade ring</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PyranometerWithShadeRing">http://purl.oclc.org/NET/ssnx/meteo/aws#PyranometerWithShadeRing</seealso>
    let PyranometerWithShadeRing =
        Prefixed_Name(aws, "PyranometerWithShadeRing") |> PrefixedName

    /// <summary>
    ///   <para>aws:Pyrgeometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>measurement of long-wave radiation from the earth</para>
    /// labels<para>Pyrgeometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyrgeometer">http://purl.oclc.org/NET/ssnx/meteo/aws#Pyrgeometer</seealso>
    let Pyrgeometer = Prefixed_Name(aws, "Pyrgeometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:QuantumSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>measure the PAR directly in the range 0.4 to 0.7 micrometers</para>
    /// labels<para>Quantum sensor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#QuantumSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#QuantumSensor</seealso>
    let QuantumSensor = Prefixed_Name(aws, "QuantumSensor") |> PrefixedName
    /// <summary>
    ///   <para>aws:ResistiveAneroid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.</para>
    /// labels<para>Resistive aneroid</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ResistiveAneroid">http://purl.oclc.org/NET/ssnx/meteo/aws#ResistiveAneroid</seealso>
    let ResistiveAneroid = Prefixed_Name(aws, "ResistiveAneroid") |> PrefixedName

    /// <summary>
    ///   <para>aws:ShadedPicheEvaporimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Shaded Piche evaporimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ShadedPicheEvaporimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#ShadedPicheEvaporimeter</seealso>
    let ShadedPicheEvaporimeter =
        Prefixed_Name(aws, "ShadedPicheEvaporimeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:SingleOrDoubleJunctionPeltierPsychrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Single or double-junction peltier psychrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#SingleOrDoubleJunctionPeltierPsychrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#SingleOrDoubleJunctionPeltierPsychrometer</seealso>
    let SingleOrDoubleJunctionPeltierPsychrometer =
        Prefixed_Name(aws, "SingleOrDoubleJunctionPeltierPsychrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:SnowGauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Snow gauge</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowGauge">http://purl.oclc.org/NET/ssnx/meteo/aws#SnowGauge</seealso>
    let SnowGauge = Prefixed_Name(aws, "SnowGauge") |> PrefixedName
    /// <summary>
    ///   <para>aws:SnowPillow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tensiometric sensors detect the hydrostatic pressure caused by the layer of snow on top of the pillow</para>
    /// labels<para>Snow pillow</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowPillow">http://purl.oclc.org/NET/ssnx/meteo/aws#SnowPillow</seealso>
    let SnowPillow = Prefixed_Name(aws, "SnowPillow") |> PrefixedName
    /// <summary>
    ///   <para>aws:HotBeadAnemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Hot-bead anemometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotBeadAnemometer">http://purl.oclc.org/NET/ssnx/meteo/aws#HotBeadAnemometer</seealso>
    let HotBeadAnemometer = Prefixed_Name(aws, "HotBeadAnemometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:CampbellStokesSunshineMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>World standard abolished in 1989</para>
    /// labels<para>Campbell-Stokes sunshine meter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CampbellStokesSunshineMeter">http://purl.oclc.org/NET/ssnx/meteo/aws#CampbellStokesSunshineMeter</seealso>
    let CampbellStokesSunshineMeter =
        Prefixed_Name(aws, "CampbellStokesSunshineMeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:ElectricalResistanceThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>For small temperature changes, the increase in resistance of pure metals is proportional to the change in temperature. Often made in Platinum.</para>
    /// labels<para>Electrical resistance thermometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceThermometer">http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceThermometer</seealso>
    let ElectricalResistanceThermometer =
        Prefixed_Name(aws, "ElectricalResistanceThermometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:EppleyPyranometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>total solar irradiance on a horizontal surface</para>
    /// labels<para>Eppley pyranometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#EppleyPyranometer">http://purl.oclc.org/NET/ssnx/meteo/aws#EppleyPyranometer</seealso>
    let EppleyPyranometer = Prefixed_Name(aws, "EppleyPyranometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:FiberGlassBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Fiber-glass block</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#FiberGlassBlock">http://purl.oclc.org/NET/ssnx/meteo/aws#FiberGlassBlock</seealso>
    let FiberGlassBlock = Prefixed_Name(aws, "FiberGlassBlock") |> PrefixedName

    /// <summary>
    ///   <para>aws:AtmometerOrSmallSurfaceEvaporimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Atmometer or small surface evaporimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmometerOrSmallSurfaceEvaporimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#AtmometerOrSmallSurfaceEvaporimeter</seealso>
    let AtmometerOrSmallSurfaceEvaporimeter =
        Prefixed_Name(aws, "AtmometerOrSmallSurfaceEvaporimeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:BimetallicActinograph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>total solar irradiance on a horizontal surface</para>
    /// labels<para>Bimetallic actinograph</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#BimetallicActinograph">http://purl.oclc.org/NET/ssnx/meteo/aws#BimetallicActinograph</seealso>
    let BimetallicActinograph =
        Prefixed_Name(aws, "BimetallicActinograph") |> PrefixedName

    /// <summary>
    ///   <para>aws:ElectricalResistanceBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Electrical resistance block</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceBlock">http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceBlock</seealso>
    let ElectricalResistanceBlock =
        Prefixed_Name(aws, "ElectricalResistanceBlock") |> PrefixedName

    /// <summary>
    ///   <para>aws:Laser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>emits modulated visible laser light and determines the distance to an object by comparing phase information</para>
    /// labels<para>Laser</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Laser">http://purl.oclc.org/NET/ssnx/meteo/aws#Laser</seealso>
    let Laser = Prefixed_Name(aws, "Laser") |> PrefixedName

    /// <summary>
    ///   <para>aws:FrequencyDomainReflectometryCapacitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Frequency domain reflectometry (capacitance)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#FrequencyDomainReflectometryCapacitance">http://purl.oclc.org/NET/ssnx/meteo/aws#FrequencyDomainReflectometryCapacitance</seealso>
    let FrequencyDomainReflectometryCapacitance =
        Prefixed_Name(aws, "FrequencyDomainReflectometryCapacitance") |> PrefixedName

    /// <summary>
    ///   <para>aws:GammaAbsorption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gamma absorption</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#GammaAbsorption">http://purl.oclc.org/NET/ssnx/meteo/aws#GammaAbsorption</seealso>
    let GammaAbsorption = Prefixed_Name(aws, "GammaAbsorption") |> PrefixedName
    /// <summary>
    ///   <para>aws:GypsumBlock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gypsum block</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#GypsumBlock">http://purl.oclc.org/NET/ssnx/meteo/aws#GypsumBlock</seealso>
    let GypsumBlock = Prefixed_Name(aws, "GypsumBlock") |> PrefixedName
    /// <summary>
    ///   <para>aws:MercuryBarometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mercury barometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#MercuryBarometer">http://purl.oclc.org/NET/ssnx/meteo/aws#MercuryBarometer</seealso>
    let MercuryBarometer = Prefixed_Name(aws, "MercuryBarometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:MicrowaveRadarDisdrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Backscatter (intensity of backscattered signal related to the number of particles and/or their water content)</para>
    /// labels<para>Microwave radar disdrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#MicrowaveRadarDisdrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#MicrowaveRadarDisdrometer</seealso>
    let MicrowaveRadarDisdrometer =
        Prefixed_Name(aws, "MicrowaveRadarDisdrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:NeutronProbe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Neutron probe</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#NeutronProbe">http://purl.oclc.org/NET/ssnx/meteo/aws#NeutronProbe</seealso>
    let NeutronProbe = Prefixed_Name(aws, "NeutronProbe") |> PrefixedName
    /// <summary>
    ///   <para>aws:NylonUnits</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Nylon units</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#NylonUnits">http://purl.oclc.org/NET/ssnx/meteo/aws#NylonUnits</seealso>
    let NylonUnits = Prefixed_Name(aws, "NylonUnits") |> PrefixedName
    /// <summary>
    ///   <para>aws:OpticalDisdrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Thin laser light sheets crossing the measuring volume: particle volume, speed (forward scatter)</para>
    /// labels<para>Optical disdrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalDisdrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalDisdrometer</seealso>
    let OpticalDisdrometer = Prefixed_Name(aws, "OpticalDisdrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:PopoffLysimeterCombinedDrainageAndWeighingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.</para>
    /// labels<para>Popoff lysimeter (combined drainage and weighing type)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PopoffLysimeterCombinedDrainageAndWeighingType">http://purl.oclc.org/NET/ssnx/meteo/aws#PopoffLysimeterCombinedDrainageAndWeighingType</seealso>
    let PopoffLysimeterCombinedDrainageAndWeighingType =
        Prefixed_Name(aws, "PopoffLysimeterCombinedDrainageAndWeighingType") |> PrefixedName

    /// <summary>
    ///   <para>aws:PortableAspiratedAndShieldedPsychrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Artificially ventilated psychrometers, such as the Assmann type, the aspirated screen type, and the whirling type,</para>
    /// labels<para>portable aspirated and shielded psychrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PortableAspiratedAndShieldedPsychrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#PortableAspiratedAndShieldedPsychrometer</seealso>
    let PortableAspiratedAndShieldedPsychrometer =
        Prefixed_Name(aws, "PortableAspiratedAndShieldedPsychrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:PressureTubeAnemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pressure tube anemometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PressureTubeAnemometer">http://purl.oclc.org/NET/ssnx/meteo/aws#PressureTubeAnemometer</seealso>
    let PressureTubeAnemometer =
        Prefixed_Name(aws, "PressureTubeAnemometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:OpticalCapacitiveSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Optical/Capacitive sensor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalCapacitiveSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalCapacitiveSensor</seealso>
    let OpticalCapacitiveSensor =
        Prefixed_Name(aws, "OpticalCapacitiveSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:HydraulicLysimeterMoreRobustWeighingType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.</para>
    /// labels<para>hydraulic lysimeter (more robust weighing type)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#HydraulicLysimeterMoreRobustWeighingType">http://purl.oclc.org/NET/ssnx/meteo/aws#HydraulicLysimeterMoreRobustWeighingType</seealso>
    let HydraulicLysimeterMoreRobustWeighingType =
        Prefixed_Name(aws, "HydraulicLysimeterMoreRobustWeighingType") |> PrefixedName

    /// <summary>
    ///   <para>aws:ImpactDisdrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Impact of precipitation particles on a plastic or metal membrane</para>
    /// labels<para>Impact disdrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ImpactDisdrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#ImpactDisdrometer</seealso>
    let ImpactDisdrometer = Prefixed_Name(aws, "ImpactDisdrometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:Lysimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.</para>
    /// labels<para>lysimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Lysimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#Lysimeter</seealso>
    let Lysimeter = Prefixed_Name(aws, "Lysimeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:InfraRedGasAnalyzerHygrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Infra-red gas analyzer hygrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#InfraRedGasAnalyzerHygrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#InfraRedGasAnalyzerHygrometer</seealso>
    let InfraRedGasAnalyzerHygrometer =
        Prefixed_Name(aws, "InfraRedGasAnalyzerHygrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:KataThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kata thermometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#KataThermometer">http://purl.oclc.org/NET/ssnx/meteo/aws#KataThermometer</seealso>
    let KataThermometer = Prefixed_Name(aws, "KataThermometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:LevelMeasurementRainGauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measuring the water level in a tube</para>
    /// labels<para>Level measurement rain gauge</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#LevelMeasurementRainGauge">http://purl.oclc.org/NET/ssnx/meteo/aws#LevelMeasurementRainGauge</seealso>
    let LevelMeasurementRainGauge =
        Prefixed_Name(aws, "LevelMeasurementRainGauge") |> PrefixedName

    /// <summary>
    ///   <para>aws:SonicRanging</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>measure the elapsed time between emission and return of an ultrasonic pulse sent vertically down to the snow covered ground surface</para>
    /// labels<para>Sonic ranging</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#SonicRanging">http://purl.oclc.org/NET/ssnx/meteo/aws#SonicRanging</seealso>
    let SonicRanging = Prefixed_Name(aws, "SonicRanging") |> PrefixedName

    /// <summary>
    ///   <para>aws:SurfaceTemperatureRadiometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>measurements of infra-red radiation emitted from near or remote surfaces</para>
    /// labels<para>Surface temperature radiometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#SurfaceTemperatureRadiometer">http://purl.oclc.org/NET/ssnx/meteo/aws#SurfaceTemperatureRadiometer</seealso>
    let SurfaceTemperatureRadiometer =
        Prefixed_Name(aws, "SurfaceTemperatureRadiometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:Tensiometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tensiometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Tensiometer">http://purl.oclc.org/NET/ssnx/meteo/aws#Tensiometer</seealso>
    let Tensiometer = Prefixed_Name(aws, "Tensiometer") |> PrefixedName
    /// <summary>
    ///   <para>aws:Thermistor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Based on the variation of resistance of a semiconductor with a relatively large temperature coefficient of resistance, either positive (PTC) or negative (NTC) depending upon the actual material</para>
    /// labels<para>Thermistor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermistor">http://purl.oclc.org/NET/ssnx/meteo/aws#Thermistor</seealso>
    let Thermistor = Prefixed_Name(aws, "Thermistor") |> PrefixedName
    /// <summary>
    ///   <para>aws:Thermocouple</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Based on the generation of an electromotive force at the junction between two metals in contact, which is function of the temperature of the two metals</para>
    /// labels<para>Thermocouple</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermocouple">http://purl.oclc.org/NET/ssnx/meteo/aws#Thermocouple</seealso>
    let Thermocouple = Prefixed_Name(aws, "Thermocouple") |> PrefixedName

    /// <summary>
    ///   <para>aws:ThornthwaiteLysimeterDrainageType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.</para>
    /// labels<para>Thornthwaite lysimeter (drainage type)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ThornthwaiteLysimeterDrainageType">http://purl.oclc.org/NET/ssnx/meteo/aws#ThornthwaiteLysimeterDrainageType</seealso>
    let ThornthwaiteLysimeterDrainageType =
        Prefixed_Name(aws, "ThornthwaiteLysimeterDrainageType") |> PrefixedName

    /// <summary>
    ///   <para>aws:TimeDomainReflectometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time domain reflectometry (TDR) and time delay transmission</para>
    /// labels<para>Time Domain Reflectometry</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TimeDomainReflectometry">http://purl.oclc.org/NET/ssnx/meteo/aws#TimeDomainReflectometry</seealso>
    let TimeDomainReflectometry =
        Prefixed_Name(aws, "TimeDomainReflectometry") |> PrefixedName

    /// <summary>
    ///   <para>aws:TippingBucketRainGauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tipping balance of two buckets</para>
    /// labels<para>Tipping bucket rain gauge</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGauge">http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGauge</seealso>
    let TippingBucketRainGauge =
        Prefixed_Name(aws, "TippingBucketRainGauge") |> PrefixedName

    /// <summary>
    ///   <para>aws:TippingBucketRainGaugeTbrgWithoutCorrection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tipping balance of two buckets</para>
    /// labels<para>Tipping-bucket rain gauge (TBRG) without correction</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeTbrgWithoutCorrection">http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeTbrgWithoutCorrection</seealso>
    let TippingBucketRainGaugeTbrgWithoutCorrection =
        Prefixed_Name(aws, "TippingBucketRainGaugeTbrgWithoutCorrection") |> PrefixedName

    /// <summary>
    ///   <para>aws:TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tipping balance of two buckets</para>
    /// labels<para>Tipping-bucket rain gauge with correction algorithm (TBRG-SC)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc">http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc</seealso>
    let TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc =
        Prefixed_Name(aws, "TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc") |> PrefixedName

    /// <summary>
    ///   <para>aws:TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tipping balance of two buckets</para>
    /// labels<para>Tipping-bucket rain gauge with extra pulse correction (TBRG-PC)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc">http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc</seealso>
    let TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc =
        Prefixed_Name(aws, "TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc") |> PrefixedName

    /// <summary>
    ///   <para>aws:TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tipping balance of two buckets</para>
    /// labels<para>Tipping-bucket rain gauge with mechanical correction (TBRG-MC)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc">http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc</seealso>
    let TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc =
        Prefixed_Name(aws, "TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc") |> PrefixedName

    /// <summary>
    ///   <para>aws:TubeSolarimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tube solarimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TubeSolarimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#TubeSolarimeter</seealso>
    let TubeSolarimeter = Prefixed_Name(aws, "TubeSolarimeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:UltrasonicWindSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sonic signal is emitted by sensor transducers</para>
    /// labels<para>Ultrasonic Wind sensor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicWindSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicWindSensor</seealso>
    let UltrasonicWindSensor =
        Prefixed_Name(aws, "UltrasonicWindSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:WeighingLysimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.</para>
    /// labels<para>weighing lysimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingLysimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingLysimeter</seealso>
    let WeighingLysimeter = Prefixed_Name(aws, "WeighingLysimeter") |> PrefixedName
    /// <summary>
    ///   <para>aws:WeighingRainGauge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weighing of precipitation accumulated in a storage container</para>
    /// labels<para>Weighing rain gauge</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGauge">http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGauge</seealso>
    let WeighingRainGauge = Prefixed_Name(aws, "WeighingRainGauge") |> PrefixedName

    /// <summary>
    ///   <para>aws:WeighingRainGaugeWithPressureMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weighing of precipitation accumulated in a storage container</para>
    /// labels<para>Weighing rain gauge with pressure measurement</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGaugeWithPressureMeasurement">http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGaugeWithPressureMeasurement</seealso>
    let WeighingRainGaugeWithPressureMeasurement =
        Prefixed_Name(aws, "WeighingRainGaugeWithPressureMeasurement") |> PrefixedName

    /// <summary>
    ///   <para>aws:WetBulbTemperatureMeasurementSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Wet-bulb temperature measurement system</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WetBulbTemperatureMeasurementSystem">http://purl.oclc.org/NET/ssnx/meteo/aws#WetBulbTemperatureMeasurementSystem</seealso>
    let WetBulbTemperatureMeasurementSystem =
        Prefixed_Name(aws, "WetBulbTemperatureMeasurementSystem") |> PrefixedName

    /// <summary>
    ///   <para>aws:WettingFrontDetection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Wetting front detection</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WettingFrontDetection">http://purl.oclc.org/NET/ssnx/meteo/aws#WettingFrontDetection</seealso>
    let WettingFrontDetection =
        Prefixed_Name(aws, "WettingFrontDetection") |> PrefixedName

    /// <summary>
    ///   <para>aws:WindVane</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The signal generator is a shaft angle transducer: potentiometers, alternating and direct current synchros, digital angle-encoder disks, direct reading dials, and rotary switches</para>
    /// labels<para>Wind Vane</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindVane">http://purl.oclc.org/NET/ssnx/meteo/aws#WindVane</seealso>
    let WindVane = Prefixed_Name(aws, "WindVane") |> PrefixedName

    /// <summary>
    ///   <para>aws:UltrasonicSensorVirtualTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ultrasonic Sensor (virtual temperature)</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicSensorVirtualTemperature">http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicSensorVirtualTemperature</seealso>
    let UltrasonicSensorVirtualTemperature =
        Prefixed_Name(aws, "UltrasonicSensorVirtualTemperature") |> PrefixedName

    /// <summary>
    ///   <para>aws:MechanicalAneroidBarometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mechanical Aneroid barometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalAneroidBarometer">http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalAneroidBarometer</seealso>
    let MechanicalAneroidBarometer =
        Prefixed_Name(aws, "MechanicalAneroidBarometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:MechanicalHygrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>mechanical hygrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalHygrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalHygrometer</seealso>
    let MechanicalHygrometer =
        Prefixed_Name(aws, "MechanicalHygrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:MechanicalSensorWithRecorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>mechanical sensor with recorder</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalSensorWithRecorder">http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalSensorWithRecorder</seealso>
    let MechanicalSensorWithRecorder =
        Prefixed_Name(aws, "MechanicalSensorWithRecorder") |> PrefixedName

    /// <summary>
    ///   <para>aws:Microlysimeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.</para>
    /// labels<para>Microlysimeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#Microlysimeter">http://purl.oclc.org/NET/ssnx/meteo/aws#Microlysimeter</seealso>
    let Microlysimeter = Prefixed_Name(aws, "Microlysimeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:MollGorczynkiPyranometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>total solar irradiance on a horizontal surface</para>
    /// labels<para>Moll-Gorczynki pyranometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#MollGorczynkiPyranometer">http://purl.oclc.org/NET/ssnx/meteo/aws#MollGorczynkiPyranometer</seealso>
    let MollGorczynkiPyranometer =
        Prefixed_Name(aws, "MollGorczynkiPyranometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Net all-wave radiation (net flux of downward and upward total radiation i.e. solar, terrestrial and atmospheric)</para>
    /// labels<para>Net radiometer or net pyrradiometer or net exchange radiometer or balancemeter</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter">http://purl.oclc.org/NET/ssnx/meteo/aws#NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter</seealso>
    let NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter =
        Prefixed_Name(aws, "NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter") |> PrefixedName

    /// <summary>
    ///   <para>aws:CapacitiveBead</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Capacitive bead</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveBead">http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveBead</seealso>
    let CapacitiveBead = Prefixed_Name(aws, "CapacitiveBead") |> PrefixedName
    /// <summary>
    ///   <para>aws:TemperatureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Temperature</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#TemperatureSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#TemperatureSensor</seealso>
    let TemperatureSensor = Prefixed_Name(aws, "TemperatureSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:CapacitiveThinFilmPolymer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.</para>
    /// labels<para>Capacitive - thin film polymer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveThinFilmPolymer">http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveThinFilmPolymer</seealso>
    let CapacitiveThinFilmPolymer =
        Prefixed_Name(aws, "CapacitiveThinFilmPolymer") |> PrefixedName

    /// <summary>
    ///   <para>aws:ChilledMirrorHygrometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>condensation is detected on the surface of a small polished metal reflecting surface (a mirror), using optical means. The temperature at which condensation is formed is the dew point.</para>
    /// labels<para>chilled-mirror hygrometer</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorHygrometer">http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorHygrometer</seealso>
    let ChilledMirrorHygrometer =
        Prefixed_Name(aws, "ChilledMirrorHygrometer") |> PrefixedName

    /// <summary>
    ///   <para>aws:DropCounters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Counting the number of uniform droplets corresponding to a fixed volume of water</para>
    /// labels<para>Drop counters</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#DropCounters">http://purl.oclc.org/NET/ssnx/meteo/aws#DropCounters</seealso>
    let DropCounters = Prefixed_Name(aws, "DropCounters") |> PrefixedName
    /// <summary>
    ///   <para>aws:PrecipitationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Precipitation</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#PrecipitationSensor">http://purl.oclc.org/NET/ssnx/meteo/aws#PrecipitationSensor</seealso>
    let PrecipitationSensor = Prefixed_Name(aws, "PrecipitationSensor") |> PrefixedName

    /// <summary>
    ///   <para>aws:ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>electric sensor, which exploits the conductivity variation as a function of wetness</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness">http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness</seealso>
    let ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness =
        Prefixed_Name(aws, "ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness") |> PrefixedName

    /// <summary>
    ///   <para>aws:ElectricalResistanceHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>certain materials interact with water vapour and undergo a change in electrical resistance, in relation to ambient humidity.</para>
    /// labels<para>electrical resistance humidity sensor</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceHumiditySensor">http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceHumiditySensor</seealso>
    let ElectricalResistanceHumiditySensor =
        Prefixed_Name(aws, "ElectricalResistanceHumiditySensor") |> PrefixedName
