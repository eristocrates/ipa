#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module aws =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.oclc.org/NET/ssnx/meteo/aws#" "aws"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch albedometer [GAMP 2.3.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : pair of upward and downward facing solarimeters^^xsd:string</para>
    ///   <para>rdfs:label : albedometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Albedometer">aws:Albedometer</a>
    /// </summary>
    let Albedometer = _prefixId.prefix "Albedometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch aneroid displacement transducer [CIMO Guide 3.3.1] http://www.wmo.int/pages/prog/www/IMOP/publications/CIMO-Guide/CIMO%20Guide%207th%20Edition,%202008/Part%20I/Chapter%203.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.^^xsd:string</para>
    ///   <para>rdfs:label : aneroid displacement transducer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#AneroidDisplacementTransducer">aws:AneroidDisplacementTransducer</a>
    /// </summary>
    let AneroidDisplacementTransducer = _prefixId.prefix "AneroidDisplacementTransducer"

    /// <summary>
    ///   <para>rdfs:label : Atmometer or small surface evaporimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmometerOrSmallSurfaceEvaporimeter">aws:AtmometerOrSmallSurfaceEvaporimeter</a>
    /// </summary>
    let AtmometerOrSmallSurfaceEvaporimeter =
        _prefixId.prefix "AtmometerOrSmallSurfaceEvaporimeter"

    /// <summary>
    ///   <para>rdfs:label : Atmospheric pressure^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#AtmosphericPressureSensor">aws:AtmosphericPressureSensor</a>
    /// </summary>
    let AtmosphericPressureSensor = _prefixId.prefix "AtmosphericPressureSensor"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Automatic sunshine recorder [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : time during which direct radiation (on a plane perpendicular to the Sun’s beam) is larger than 120 Wm-2.^^xsd:string</para>
    ///   <para>rdfs:label : Automatic sunshine recorder^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#AutomaticSunshineRecorder">aws:AutomaticSunshineRecorder</a>
    /// </summary>
    let AutomaticSunshineRecorder = _prefixId.prefix "AutomaticSunshineRecorder"
    /// <summary>
    ///   <para>rdfs:comment : total solar irradiance on a horizontal surface^^xsd:string</para>
    ///   <para>rdfs:label : Bimetallic actinograph^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#BimetallicActinograph">aws:BimetallicActinograph</a>
    /// </summary>
    let BimetallicActinograph = _prefixId.prefix "BimetallicActinograph"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Campbell-Stokes sunshine meter [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : World standard abolished in 1989^^xsd:string</para>
    ///   <para>rdfs:label : Campbell-Stokes sunshine meter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CampbellStokesSunshineMeter">aws:CampbellStokesSunshineMeter</a>
    /// </summary>
    let CampbellStokesSunshineMeter = _prefixId.prefix "CampbellStokesSunshineMeter"
    /// <summary>
    ///   <para>rdfs:label : capacitance sensor^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch capacitance sensor [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitanceSensor">aws:CapacitanceSensor</a>
    /// </summary>
    let CapacitanceSensor = _prefixId.prefix "CapacitanceSensor"
    /// <summary>
    ///   <para>rdfs:comment : certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.^^xsd:string</para>
    ///   <para>rdfs:label : Capacitive - aluminum oxide^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAluminumOxide">aws:CapacitiveAluminumOxide</a>
    /// </summary>
    let CapacitiveAluminumOxide = _prefixId.prefix "CapacitiveAluminumOxide"
    /// <summary>
    ///   <para>rdfs:comment : The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.^^xsd:string</para>
    ///   <para>rdfs:label : Capacitive aneroid^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveAneroid">aws:CapacitiveAneroid</a>
    /// </summary>
    let CapacitiveAneroid = _prefixId.prefix "CapacitiveAneroid"
    /// <summary>
    ///   <para>rdfs:label : Capacitive bead^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Capacitive bead [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveBead">aws:CapacitiveBead</a>
    /// </summary>
    let CapacitiveBead = _prefixId.prefix "CapacitiveBead"
    /// <summary>
    ///   <para>rdfs:comment : certain materials interact with water vapour and undergo a change in capacitance, in relation to ambient humidity.^^xsd:string</para>
    ///   <para>rdfs:label : Capacitive - thin film polymer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CapacitiveThinFilmPolymer">aws:CapacitiveThinFilmPolymer</a>
    /// </summary>
    let CapacitiveThinFilmPolymer = _prefixId.prefix "CapacitiveThinFilmPolymer"
    /// <summary>
    ///   <para>rdfs:comment : condensation is detected on the surface of a small polished metal reflecting surface (a mirror), using optical means. The temperature at which condensation is formed is the dew point.^^xsd:string</para>
    ///   <para>dce:source : chilled-mirror hygrometer [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:label : chilled-mirror hygrometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorHygrometer">aws:ChilledMirrorHygrometer</a>
    /// </summary>
    let ChilledMirrorHygrometer = _prefixId.prefix "ChilledMirrorHygrometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Chilled mirror system [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Chilled mirror system^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ChilledMirrorSystem">aws:ChilledMirrorSystem</a>
    /// </summary>
    let ChilledMirrorSystem = _prefixId.prefix "ChilledMirrorSystem"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Cup anemometer [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : the angular velocity of the cup is directly proportional to the component of the wind speed parallel to the axis of rotation.^^xsd:string</para>
    ///   <para>rdfs:label : Cup anemometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CupAnemometer">aws:CupAnemometer</a>
    /// </summary>
    let CupAnemometer = _prefixId.prefix "CupAnemometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch cylindrical resonator barometer [CIMO Guide 3.3.1] http://www.wmo.int/pages/prog/www/IMOP/publications/CIMO-Guide/CIMO%20Guide%207th%20Edition,%202008/Part%20I/Chapter%203.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : A cylindrical resonator barometer (or vibrating cylinder air-pressure transducer) is designed to measure absolute air pressure using the vibrating element principle, providing a frequency output from which pressure is computed.^^xsd:string</para>
    ///   <para>rdfs:label : cylindrical resonator barometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#CylindricalResonatorBarometer">aws:CylindricalResonatorBarometer</a>
    /// </summary>
    let CylindricalResonatorBarometer = _prefixId.prefix "CylindricalResonatorBarometer"
    /// <summary>
    ///   <para>dce:source : dew cell [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : A dew cell heats a salt solution until its equilibrium vapour pressure equals to the ambient vapour pressure, and maintains this equilibrium The temperature when this occurs is measured and it provides a measure of the ambient vapour pressure^^xsd:string</para>
    ///   <para>rdfs:label : dew cell^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewCell">aws:DewCell</a>
    /// </summary>
    let DewCell = _prefixId.prefix "DewCell"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Dewcel system [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Dewcel system^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#DewcelSystem">aws:DewcelSystem</a>
    /// </summary>
    let DewcelSystem = _prefixId.prefix "DewcelSystem"

    /// <summary>
    ///   <para>rdfs:label : differential expansion thermometer^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Differential expansion thermometer [GAMP 2.4.1.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#DifferentialExpansionThermometer">aws:DifferentialExpansionThermometer</a>
    /// </summary>
    let DifferentialExpansionThermometer =
        _prefixId.prefix "DifferentialExpansionThermometer"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch digital piezo-resistive barometer [CIMO Guide 3.3.1] http://www.wmo.int/pages/prog/www/IMOP/publications/CIMO-Guide/CIMO%20Guide%207th%20Edition,%202008/Part%20I/Chapter%203.pdf^^xsd:string</para>
    ///   <para>rdfs:label : digital piezo-resistive barometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#DigitalPiezoResistiveBarometer">aws:DigitalPiezoResistiveBarometer</a>
    /// </summary>
    let DigitalPiezoResistiveBarometer =
        _prefixId.prefix "DigitalPiezoResistiveBarometer"

    /// <summary>
    ///   <para>rdfs:comment : total solar irradiance on a horizontal surface^^xsd:string</para>
    ///   <para>rdfs:label : Dirmhirm-Sauberer pyranometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#DirmhirmSaubererPyranometer">aws:DirmhirmSaubererPyranometer</a>
    /// </summary>
    let DirmhirmSaubererPyranometer = _prefixId.prefix "DirmhirmSaubererPyranometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Drop counters [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Drop counters^^xsd:string</para>
    ///   <para>rdfs:comment : Counting the number of uniform droplets corresponding to a fixed volume of water^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#DropCounters">aws:DropCounters</a>
    /// </summary>
    let DropCounters = _prefixId.prefix "DropCounters"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch electric sensor, which exploits the conductivity variation as a function of wetness [GAMP 2.4.1.6.3] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : electric sensor, which exploits the conductivity variation as a function of wetness^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness">aws:ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness</a>
    /// </summary>
    let ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness =
        _prefixId.prefix "ElectricSensorWhichExploitsTheConductivityVariationAsAFunctionOfWetness"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Electrical resistance block [GAMP 2.4.1.6.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Electrical resistance block^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceBlock">aws:ElectricalResistanceBlock</a>
    /// </summary>
    let ElectricalResistanceBlock = _prefixId.prefix "ElectricalResistanceBlock"

    /// <summary>
    ///   <para>rdfs:comment : certain materials interact with water vapour and undergo a change in electrical resistance, in relation to ambient humidity.^^xsd:string</para>
    ///   <para>rdfs:label : electrical resistance humidity sensor^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch electrical resistance humidity sensor [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceHumiditySensor">aws:ElectricalResistanceHumiditySensor</a>
    /// </summary>
    let ElectricalResistanceHumiditySensor =
        _prefixId.prefix "ElectricalResistanceHumiditySensor"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Resistance thermometer [GAMP 2.4.1.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Electrical resistance thermometer^^xsd:string</para>
    ///   <para>rdfs:comment : For small temperature changes, the increase in resistance of pure metals is proportional to the change in temperature. Often made in Platinum.^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ElectricalResistanceThermometer">aws:ElectricalResistanceThermometer</a>
    /// </summary>
    let ElectricalResistanceThermometer =
        _prefixId.prefix "ElectricalResistanceThermometer"

    /// <summary>
    ///   <para>rdfs:comment : total solar irradiance on a horizontal surface^^xsd:string</para>
    ///   <para>rdfs:label : Eppley pyranometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#EppleyPyranometer">aws:EppleyPyranometer</a>
    /// </summary>
    let EppleyPyranometer = _prefixId.prefix "EppleyPyranometer"
    /// <summary>
    ///   <para>rdfs:label : Fiber-glass block^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#FiberGlassBlock">aws:FiberGlassBlock</a>
    /// </summary>
    let FiberGlassBlock = _prefixId.prefix "FiberGlassBlock"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Frequency domain reflectometry (capacitance).................................................... [Soil Water Monitoring] http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.118.567&amp;rep=rep1&amp;type=pdf^^xsd:string</para>
    ///   <para>rdfs:label : Frequency domain reflectometry (capacitance)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#FrequencyDomainReflectometryCapacitance">aws:FrequencyDomainReflectometryCapacitance</a>
    /// </summary>
    let FrequencyDomainReflectometryCapacitance =
        _prefixId.prefix "FrequencyDomainReflectometryCapacitance"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Gamma absorption [GAMP 2.4.1.6.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Gamma absorption^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#GammaAbsorption">aws:GammaAbsorption</a>
    /// </summary>
    let GammaAbsorption = _prefixId.prefix "GammaAbsorption"
    /// <summary>
    ///   <para>rdfs:label : Gypsum block^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#GypsumBlock">aws:GypsumBlock</a>
    /// </summary>
    let GypsumBlock = _prefixId.prefix "GypsumBlock"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Hot-bead anemometer [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Hot-bead anemometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotBeadAnemometer">aws:HotBeadAnemometer</a>
    /// </summary>
    let HotBeadAnemometer = _prefixId.prefix "HotBeadAnemometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Hot-wire anemometer [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Hot-wire anemometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#HotWireAnemometer">aws:HotWireAnemometer</a>
    /// </summary>
    let HotWireAnemometer = _prefixId.prefix "HotWireAnemometer"
    /// <summary>
    ///   <para>rdfs:label : Humidity^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#HumiditySensor">aws:HumiditySensor</a>
    /// </summary>
    let HumiditySensor = _prefixId.prefix "HumiditySensor"

    /// <summary>
    ///   <para>rdfs:comment : Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.^^xsd:string</para>
    ///   <para>rdfs:label : hydraulic lysimeter (more robust weighing type)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#HydraulicLysimeterMoreRobustWeighingType">aws:HydraulicLysimeterMoreRobustWeighingType</a>
    /// </summary>
    let HydraulicLysimeterMoreRobustWeighingType =
        _prefixId.prefix "HydraulicLysimeterMoreRobustWeighingType"

    /// <summary>
    ///   <para>rdfs:label : Impact disdrometer^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Impact disdrometer [IOM-99_FI-RI 2.2.2b] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : Impact of precipitation particles on a plastic or metal membrane^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ImpactDisdrometer">aws:ImpactDisdrometer</a>
    /// </summary>
    let ImpactDisdrometer = _prefixId.prefix "ImpactDisdrometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Infra-red gas analyzer hygrometer [GAMP 2.4.1.6.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Infra-red gas analyzer hygrometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#InfraRedGasAnalyzerHygrometer">aws:InfraRedGasAnalyzerHygrometer</a>
    /// </summary>
    let InfraRedGasAnalyzerHygrometer = _prefixId.prefix "InfraRedGasAnalyzerHygrometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Kata thermometer [GAMP 2.4.1.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Kata thermometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#KataThermometer">aws:KataThermometer</a>
    /// </summary>
    let KataThermometer = _prefixId.prefix "KataThermometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Laser [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : emits modulated visible laser light and determines the distance to an object by comparing phase information^^xsd:string</para>
    ///   <para>rdfs:label : Laser^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Laser">aws:Laser</a>
    /// </summary>
    let Laser = _prefixId.prefix "Laser"
    /// <summary>
    ///   <para>rdfs:label : Level measurement rain gauge^^xsd:string</para>
    ///   <para>rdfs:comment : Measuring the water level in a tube^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Level measurement rain gauge (LRG) [IOM-99_FI-RI 2.2.1e] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#LevelMeasurementRainGauge">aws:LevelMeasurementRainGauge</a>
    /// </summary>
    let LevelMeasurementRainGauge = _prefixId.prefix "LevelMeasurementRainGauge"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch lysimeter [GAMP 2.4.1.8.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.^^xsd:string</para>
    ///   <para>rdfs:label : lysimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Lysimeter">aws:Lysimeter</a>
    /// </summary>
    let Lysimeter = _prefixId.prefix "Lysimeter"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch conventional aneroid barometer [CIMO Guide 3.4] http://www.wmo.int/pages/prog/www/IMOP/publications/CIMO-Guide/CIMO%20Guide%207th%20Edition,%202008/Part%20I/Chapter%203.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Mechanical Aneroid barometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalAneroidBarometer">aws:MechanicalAneroidBarometer</a>
    /// </summary>
    let MechanicalAneroidBarometer = _prefixId.prefix "MechanicalAneroidBarometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch mechanical hygrometer [GAMP 2.4.1.6.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : mechanical hygrometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalHygrometer">aws:MechanicalHygrometer</a>
    /// </summary>
    let MechanicalHygrometer = _prefixId.prefix "MechanicalHygrometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch mechanical sensor with recorder [GAMP 2.4.1.6.3] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : mechanical sensor with recorder^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#MechanicalSensorWithRecorder">aws:MechanicalSensorWithRecorder</a>
    /// </summary>
    let MechanicalSensorWithRecorder = _prefixId.prefix "MechanicalSensorWithRecorder"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Mercury barometer [CIMO Guide 3.2] http://www.wmo.int/pages/prog/www/IMOP/publications/CIMO-Guide/CIMO%20Guide%207th%20Edition,%202008/Part%20I/Chapter%203.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Mercury barometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#MercuryBarometer">aws:MercuryBarometer</a>
    /// </summary>
    let MercuryBarometer = _prefixId.prefix "MercuryBarometer"
    /// <summary>
    ///   <para>rdfs:comment : Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.^^xsd:string</para>
    ///   <para>rdfs:label : Microlysimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Microlysimeter">aws:Microlysimeter</a>
    /// </summary>
    let Microlysimeter = _prefixId.prefix "Microlysimeter"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Microwave radar disdrometer [IOM-99_FI-RI 2.2.2c] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : Backscatter (intensity of backscattered signal related to the number of particles and/or their water content)^^xsd:string</para>
    ///   <para>rdfs:label : Microwave radar disdrometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#MicrowaveRadarDisdrometer">aws:MicrowaveRadarDisdrometer</a>
    /// </summary>
    let MicrowaveRadarDisdrometer = _prefixId.prefix "MicrowaveRadarDisdrometer"
    /// <summary>
    ///   <para>rdfs:comment : total solar irradiance on a horizontal surface^^xsd:string</para>
    ///   <para>rdfs:label : Moll-Gorczynki pyranometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#MollGorczynkiPyranometer">aws:MollGorczynkiPyranometer</a>
    /// </summary>
    let MollGorczynkiPyranometer = _prefixId.prefix "MollGorczynkiPyranometer"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Net radiometers or net pyrradiometers or net exchange radiometers or balancemeters [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : Net all-wave radiation (net flux of downward and upward total radiation i.e. solar, terrestrial and atmospheric)^^xsd:string</para>
    ///   <para>rdfs:label : Net radiometer or net pyrradiometer or net exchange radiometer or balancemeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter">aws:NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter</a>
    /// </summary>
    let NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter =
        _prefixId.prefix "NetRadiometerOrNetPyrradiometerOrNetExchangeRadiometerOrBalancemeter"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Neutron probe [GAMP 2.4.1.6.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Neutron probe^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#NeutronProbe">aws:NeutronProbe</a>
    /// </summary>
    let NeutronProbe = _prefixId.prefix "NeutronProbe"
    /// <summary>
    ///   <para>rdfs:label : Nylon units^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#NylonUnits">aws:NylonUnits</a>
    /// </summary>
    let NylonUnits = _prefixId.prefix "NylonUnits"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Optical/Capacitive sensor [IOM-99_FI-RI 2.2.2d] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Optical/Capacitive sensor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalCapacitiveSensor">aws:OpticalCapacitiveSensor</a>
    /// </summary>
    let OpticalCapacitiveSensor = _prefixId.prefix "OpticalCapacitiveSensor"
    /// <summary>
    ///   <para>rdfs:label : Optical disdrometer^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Optical disdrometer [IOM-99_FI-RI 2.2.2a] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : Thin laser light sheets crossing the measuring volume: particle volume, speed (forward scatter)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#OpticalDisdrometer">aws:OpticalDisdrometer</a>
    /// </summary>
    let OpticalDisdrometer = _prefixId.prefix "OpticalDisdrometer"

    /// <summary>
    ///   <para>rdfs:comment : Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.^^xsd:string</para>
    ///   <para>rdfs:label : Popoff lysimeter (combined drainage and weighing type)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PopoffLysimeterCombinedDrainageAndWeighingType">aws:PopoffLysimeterCombinedDrainageAndWeighingType</a>
    /// </summary>
    let PopoffLysimeterCombinedDrainageAndWeighingType =
        _prefixId.prefix "PopoffLysimeterCombinedDrainageAndWeighingType"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch portable aspirated and shielded psychrometer [GAMP 2.4.1.6.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : Artificially ventilated psychrometers, such as the Assmann type, the aspirated screen type, and the whirling type,^^xsd:string</para>
    ///   <para>rdfs:label : portable aspirated and shielded psychrometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PortableAspiratedAndShieldedPsychrometer">aws:PortableAspiratedAndShieldedPsychrometer</a>
    /// </summary>
    let PortableAspiratedAndShieldedPsychrometer =
        _prefixId.prefix "PortableAspiratedAndShieldedPsychrometer"

    /// <summary>
    ///   <para>rdfs:label : Precipitation^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PrecipitationSensor">aws:PrecipitationSensor</a>
    /// </summary>
    let PrecipitationSensor = _prefixId.prefix "PrecipitationSensor"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Pressure tube anemometer [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Pressure tube anemometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PressureTubeAnemometer">aws:PressureTubeAnemometer</a>
    /// </summary>
    let PressureTubeAnemometer = _prefixId.prefix "PressureTubeAnemometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Propeller and vane anemometer [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : the angular velocity of the propeller rotor is directly proportional to the component of the wind speed parallel to the axis of rotation.^^xsd:string</para>
    ///   <para>rdfs:label : Propeller anemometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PropellerAnemometer">aws:PropellerAnemometer</a>
    /// </summary>
    let PropellerAnemometer = _prefixId.prefix "PropellerAnemometer"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch psychrometer equipped with mercury-in-glass thermometer [GAMP 2.4.1.6.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : psychrometer equipped with mercury-in-glass thermometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PsychrometerEquippedWithMercuryInGlassThermometer">aws:PsychrometerEquippedWithMercuryInGlassThermometer</a>
    /// </summary>
    let PsychrometerEquippedWithMercuryInGlassThermometer =
        _prefixId.prefix "PsychrometerEquippedWithMercuryInGlassThermometer"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch solarimeter (pyranometer) [GAMP 2.3.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : total solar irradiance on a horizontal surface^^xsd:string</para>
    ///   <para>rdfs:label : pyranometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyranometer">aws:Pyranometer</a>
    /// </summary>
    let Pyranometer = _prefixId.prefix "Pyranometer"
    /// <summary>
    ///   <para>dce:source : skos:broaderMatch solarimeter (pyranometer) [GAMP 2.3.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : pyranometer with shade ring^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#PyranometerWithShadeRing">aws:PyranometerWithShadeRing</a>
    /// </summary>
    let PyranometerWithShadeRing = _prefixId.prefix "PyranometerWithShadeRing"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch pyrgeometer [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : measurement of long-wave radiation from the earth^^xsd:string</para>
    ///   <para>rdfs:label : Pyrgeometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Pyrgeometer">aws:Pyrgeometer</a>
    /// </summary>
    let Pyrgeometer = _prefixId.prefix "Pyrgeometer"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch quantum sensor [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : measure the PAR directly in the range 0.4 to 0.7 micrometers^^xsd:string</para>
    ///   <para>rdfs:label : Quantum sensor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#QuantumSensor">aws:QuantumSensor</a>
    /// </summary>
    let QuantumSensor = _prefixId.prefix "QuantumSensor"
    /// <summary>
    ///   <para>rdfs:label : Radiation^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#RadiationSensor">aws:RadiationSensor</a>
    /// </summary>
    let RadiationSensor = _prefixId.prefix "RadiationSensor"
    /// <summary>
    ///   <para>rdfs:comment : The aneroid displacement transducer contains a sensor with electrical properties (resistance or capacitance) that changes as the atmospheric pressure changes.^^xsd:string</para>
    ///   <para>rdfs:label : Resistive aneroid^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ResistiveAneroid">aws:ResistiveAneroid</a>
    /// </summary>
    let ResistiveAneroid = _prefixId.prefix "ResistiveAneroid"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch screened and open pan evaporimeter [GAMP 2.4.1.8.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : screened and open pan evaporimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ScreenedAndOpenPanEvaporimeter">aws:ScreenedAndOpenPanEvaporimeter</a>
    /// </summary>
    let ScreenedAndOpenPanEvaporimeter =
        _prefixId.prefix "ScreenedAndOpenPanEvaporimeter"

    /// <summary>
    ///   <para>rdfs:label : Shaded Piche evaporimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ShadedPicheEvaporimeter">aws:ShadedPicheEvaporimeter</a>
    /// </summary>
    let ShadedPicheEvaporimeter = _prefixId.prefix "ShadedPicheEvaporimeter"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Single or double-junction peltier psychrometer [GAMP 2.4.1.6.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Single or double-junction peltier psychrometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#SingleOrDoubleJunctionPeltierPsychrometer">aws:SingleOrDoubleJunctionPeltierPsychrometer</a>
    /// </summary>
    let SingleOrDoubleJunctionPeltierPsychrometer =
        _prefixId.prefix "SingleOrDoubleJunctionPeltierPsychrometer"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Snow gauge [GAMP 2.4.1.7] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Snow gauge^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowGauge">aws:SnowGauge</a>
    /// </summary>
    let SnowGauge = _prefixId.prefix "SnowGauge"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Snow pillow [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : Tensiometric sensors detect the hydrostatic pressure caused by the layer of snow on top of the pillow^^xsd:string</para>
    ///   <para>rdfs:label : Snow pillow^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#SnowPillow">aws:SnowPillow</a>
    /// </summary>
    let SnowPillow = _prefixId.prefix "SnowPillow"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Sonic ranging [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:comment : measure the elapsed time between emission and return of an ultrasonic pulse sent vertically down to the snow covered ground surface^^xsd:string</para>
    ///   <para>rdfs:label : Sonic ranging^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#SonicRanging">aws:SonicRanging</a>
    /// </summary>
    let SonicRanging = _prefixId.prefix "SonicRanging"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch surface temperature radiometer [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : measurements of infra-red radiation emitted from near or remote surfaces^^xsd:string</para>
    ///   <para>rdfs:label : Surface temperature radiometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#SurfaceTemperatureRadiometer">aws:SurfaceTemperatureRadiometer</a>
    /// </summary>
    let SurfaceTemperatureRadiometer = _prefixId.prefix "SurfaceTemperatureRadiometer"
    /// <summary>
    ///   <para>rdfs:label : Temperature^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TemperatureSensor">aws:TemperatureSensor</a>
    /// </summary>
    let TemperatureSensor = _prefixId.prefix "TemperatureSensor"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Tensiometer [GAMP 2.4.1.6.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Tensiometer^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Tensiometer">aws:Tensiometer</a>
    /// </summary>
    let Tensiometer = _prefixId.prefix "Tensiometer"
    /// <summary>
    ///   <para>rdfs:comment : Based on the variation of resistance of a semiconductor with a relatively large temperature coefficient of resistance, either positive (PTC) or negative (NTC) depending upon the actual material^^xsd:string</para>
    ///   <para>rdfs:label : Thermistor^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Thermistor [GAMP 2.4.1.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermistor">aws:Thermistor</a>
    /// </summary>
    let Thermistor = _prefixId.prefix "Thermistor"
    /// <summary>
    ///   <para>rdfs:comment : Based on the generation of an electromotive force at the junction between two metals in contact, which is function of the temperature of the two metals^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Thermocouple [GAMP 2.4.1.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Thermocouple^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#Thermocouple">aws:Thermocouple</a>
    /// </summary>
    let Thermocouple = _prefixId.prefix "Thermocouple"

    /// <summary>
    ///   <para>rdfs:comment : Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.^^xsd:string</para>
    ///   <para>rdfs:label : Thornthwaite lysimeter (drainage type)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#ThornthwaiteLysimeterDrainageType">aws:ThornthwaiteLysimeterDrainageType</a>
    /// </summary>
    let ThornthwaiteLysimeterDrainageType =
        _prefixId.prefix "ThornthwaiteLysimeterDrainageType"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Time Domain Reflectometry [GAMP 2.4.1.6.2] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : Time domain reflectometry (TDR) and time delay transmission^^xsd:string</para>
    ///   <para>rdfs:label : Time Domain Reflectometry^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TimeDomainReflectometry">aws:TimeDomainReflectometry</a>
    /// </summary>
    let TimeDomainReflectometry = _prefixId.prefix "TimeDomainReflectometry"
    /// <summary>
    ///   <para>rdfs:comment : Tipping balance of two buckets^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Tipping bucket rain gauge [IOM-99_FI-RI 2.2.1a-d] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Tipping bucket rain gauge^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGauge">aws:TippingBucketRainGauge</a>
    /// </summary>
    let TippingBucketRainGauge = _prefixId.prefix "TippingBucketRainGauge"

    /// <summary>
    ///   <para>rdfs:comment : Tipping balance of two buckets^^xsd:string</para>
    ///   <para>rdfs:label : Tipping-bucket rain gauge (TBRG) without correction^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeTbrgWithoutCorrection">aws:TippingBucketRainGaugeTbrgWithoutCorrection</a>
    /// </summary>
    let TippingBucketRainGaugeTbrgWithoutCorrection =
        _prefixId.prefix "TippingBucketRainGaugeTbrgWithoutCorrection"

    /// <summary>
    ///   <para>rdfs:comment : Tipping balance of two buckets^^xsd:string</para>
    ///   <para>rdfs:label : Tipping-bucket rain gauge with correction algorithm (TBRG-SC)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc">aws:TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc</a>
    /// </summary>
    let TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc =
        _prefixId.prefix "TippingBucketRainGaugeWithCorrectionAlgorithmTbrgSc"

    /// <summary>
    ///   <para>rdfs:comment : Tipping balance of two buckets^^xsd:string</para>
    ///   <para>rdfs:label : Tipping-bucket rain gauge with extra pulse correction (TBRG-PC)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc">aws:TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc</a>
    /// </summary>
    let TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc =
        _prefixId.prefix "TippingBucketRainGaugeWithExtraPulseCorrectionTbrgPc"

    /// <summary>
    ///   <para>rdfs:comment : Tipping balance of two buckets^^xsd:string</para>
    ///   <para>rdfs:label : Tipping-bucket rain gauge with mechanical correction (TBRG-MC)^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc">aws:TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc</a>
    /// </summary>
    let TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc =
        _prefixId.prefix "TippingBucketRainGaugeWithMechanicalCorrectionTbrgMc"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch tube solarimeter [GAMP 2.4.1.1] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:label : Tube solarimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#TubeSolarimeter">aws:TubeSolarimeter</a>
    /// </summary>
    let TubeSolarimeter = _prefixId.prefix "TubeSolarimeter"

    /// <summary>
    ///   <para>rdfs:label : Ultrasonic Sensor (virtual temperature)^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Ultrasonic Sensor (virtual temperature) [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicSensorVirtualTemperature">aws:UltrasonicSensorVirtualTemperature</a>
    /// </summary>
    let UltrasonicSensorVirtualTemperature =
        _prefixId.prefix "UltrasonicSensorVirtualTemperature"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Sonic anemometer [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : A sonic signal is emitted by sensor transducers^^xsd:string</para>
    ///   <para>rdfs:label : Ultrasonic Wind sensor^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#UltrasonicWindSensor">aws:UltrasonicWindSensor</a>
    /// </summary>
    let UltrasonicWindSensor = _prefixId.prefix "UltrasonicWindSensor"
    /// <summary>
    ///   <para>rdfs:comment : Lysimeters are used for measurement of evaporation, transpiration, evapotranspiration (ET), effective rainfall, drainage, chemical contents of drainage water, to study climatic effects of ET on the performance of crops.^^xsd:string</para>
    ///   <para>rdfs:label : weighing lysimeter^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingLysimeter">aws:WeighingLysimeter</a>
    /// </summary>
    let WeighingLysimeter = _prefixId.prefix "WeighingLysimeter"
    /// <summary>
    ///   <para>rdfs:label : Weighing rain gauge^^xsd:string</para>
    ///   <para>rdfs:comment : Weighing of precipitation accumulated in a storage container^^xsd:string</para>
    ///   <para>dce:source : skos:closeMatch Weighing rain gauge (WG) [IOM-99_FI-RI 2.2.1g-h] http://www.wmo.int/pages/prog/www/IMOP/publications/IOM-99_FI-RI.pdf^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGauge">aws:WeighingRainGauge</a>
    /// </summary>
    let WeighingRainGauge = _prefixId.prefix "WeighingRainGauge"

    /// <summary>
    ///   <para>rdfs:comment : Weighing of precipitation accumulated in a storage container^^xsd:string</para>
    ///   <para>rdfs:label : Weighing rain gauge with pressure measurement^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WeighingRainGaugeWithPressureMeasurement">aws:WeighingRainGaugeWithPressureMeasurement</a>
    /// </summary>
    let WeighingRainGaugeWithPressureMeasurement =
        _prefixId.prefix "WeighingRainGaugeWithPressureMeasurement"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Wet-bulb temperature measurement system [ET-AWS] http://www.hydrometeoindustry.org/Meetings2010/ET-AWS-6/Doc8[1]-AWS-MetadataCatalogues.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Wet-bulb temperature measurement system^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WetBulbTemperatureMeasurementSystem">aws:WetBulbTemperatureMeasurementSystem</a>
    /// </summary>
    let WetBulbTemperatureMeasurementSystem =
        _prefixId.prefix "WetBulbTemperatureMeasurementSystem"

    /// <summary>
    ///   <para>dce:source : skos:closeMatch Wetting front detection [Soil Water Monitoring] http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.118.567&amp;rep=rep1&amp;type=pdf^^xsd:string</para>
    ///   <para>rdfs:label : Wetting front detection^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WettingFrontDetection">aws:WettingFrontDetection</a>
    /// </summary>
    let WettingFrontDetection = _prefixId.prefix "WettingFrontDetection"
    /// <summary>
    ///   <para>rdfs:label : Wind^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindSensor">aws:WindSensor</a>
    /// </summary>
    let WindSensor = _prefixId.prefix "WindSensor"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch Wind Vane [GAMP 2.4.1.5] http://www.wmo.int/pages/prog/wcp/agm/gamp/gamp_en.html^^xsd:string</para>
    ///   <para>rdfs:comment : The signal generator is a shaft angle transducer: potentiometers, alternating and direct current synchros, digital angle-encoder disks, direct reading dials, and rotary switches^^xsd:string</para>
    ///   <para>rdfs:label : Wind Vane^^xsd:string</para>
    ///   <a href="http://purl.oclc.org/NET/ssnx/meteo/aws#WindVane">aws:WindVane</a>
    /// </summary>
    let WindVane = _prefixId.prefix "WindVane"
