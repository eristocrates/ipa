namespace http.purl.org.iot.vocab.iot_taxonomy_lite.hash

open DoxAletheia.Rdf_Vocabulary

module iottaxolite =
    let _namespace_name = "http://purl.org/iot/vocab/iot-taxonomy-lite#"
    /// <summary>
    /// The ABS (Anti-lock Braking System) receives information from ABS computer to control the pressure on the breaks, This helps the wheels not to get locked up, it adjust the break pressure and prevents the wheels from locking. (Definition Source Google).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ABS"></see></summary>
    let ABS = Namespaced_IRI.parse _namespace_name "ABS" |> NamespacedName

    /// <summary>
    /// Initial E-UTRAN Radio Access Bearer establishment success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabEstabSuccRate"></see></summary>
    let AccInitialERabEstabSuccRate =
        Namespaced_IRI.parse _namespace_name "AccInitialERabEstabSuccRate" |> NamespacedName

    /// <summary>
    /// Communication related properties.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Communication"></see></summary>
    let Communication =
        Namespaced_IRI.parse _namespace_name "Communication" |> NamespacedName

    /// <summary>
    /// Initial E-UTRAN Radio Access Bearer setup success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabSetupSuccRate"></see></summary>
    let AccInitialERabSetupSuccRate =
        Namespaced_IRI.parse _namespace_name "AccInitialERabSetupSuccRate" |> NamespacedName

    /// <summary>
    /// Radio Resource Control connection setup success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccRrcConnSetupSuccRate"></see></summary>
    let AccRrcConnSetupSuccRate =
        Namespaced_IRI.parse _namespace_name "AccRrcConnSetupSuccRate" |> NamespacedName

    /// <summary>
    /// S1 (S1 standardized interface between eNB and Evolved Packet Core) signalling establishment success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccS1SigEstabSuccRate"></see></summary>
    let AccS1SigEstabSuccRate =
        Namespaced_IRI.parse _namespace_name "AccS1SigEstabSuccRate" |> NamespacedName

    /// <summary>
    /// The rate of change of the velocity of a particle with respect to time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Acceleration"></see></summary>
    let Acceleration =
        Namespaced_IRI.parse _namespace_name "Acceleration" |> NamespacedName

    /// <summary>
    /// The acceleration at a given instant of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccelerationInstantaneous"></see></summary>
    let AccelerationInstantaneous =
        Namespaced_IRI.parse _namespace_name "AccelerationInstantaneous" |> NamespacedName

    /// <summary>
    ///  Accelerometers are used to automatically determine the orientation in which the user is holding the IoT Object (portrait or landscape).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Accelerometer"></see></summary>
    let Accelerometer =
        Namespaced_IRI.parse _namespace_name "Accelerometer" |> NamespacedName

    /// <summary>
    /// The product of the voltage across a branch of an alternating-current circuit and the component of the electric current that is in phase with the voltage.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ActivePower"></see></summary>
    let ActivePower =
        Namespaced_IRI.parse _namespace_name "ActivePower" |> NamespacedName

    /// <summary>
    /// It is the rate, per unit time, at which electrical energy is transferred by an electric circuit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Power"></see></summary>
    let Power = Namespaced_IRI.parse _namespace_name "Power" |> NamespacedName

    /// <summary>
    /// Agriculture, Smart farm as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Agriculture"></see></summary>
    let Agriculture =
        Namespaced_IRI.parse _namespace_name "Agriculture" |> NamespacedName

    /// <summary>
    /// Application Domain for example: health, environment, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DomainOfInterest"></see></summary>
    let DomainOfInterest =
        Namespaced_IRI.parse _namespace_name "DomainOfInterest" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the air conditioner.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirConditioner"></see></summary>
    let AirConditioner =
        Namespaced_IRI.parse _namespace_name "AirConditioner" |> NamespacedName

    /// <summary>
    /// Sensor used to measure air humidity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirHumiditySensor"></see></summary>
    let AirHumiditySensor =
        Namespaced_IRI.parse _namespace_name "AirHumiditySensor" |> NamespacedName

    /// <summary>
    /// Humidity sensor or hygrometer is an instrument used for measuring the moisture concent in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumiditySensor"></see></summary>
    let HumiditySensor =
        Namespaced_IRI.parse _namespace_name "HumiditySensor" |> NamespacedName

    /// <summary>
    /// Air Pollutant Sensor are devices that detect and monitor the presence of air pollution in the surrounding area (source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollutantSensor"></see></summary>
    let AirPollutantSensor =
        Namespaced_IRI.parse _namespace_name "AirPollutantSensor" |> NamespacedName

    /// <summary>
    /// Usually measured using Air Quality Index (AQI), it is the measure of Air Pollution in the environment. It is similar to Air Quality.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollution"></see></summary>
    let AirPollution =
        Namespaced_IRI.parse _namespace_name "AirPollution" |> NamespacedName

    /// <summary>
    /// Usually measured using an air quality index (AQI) that is a number used by government agencies to communicate to the public how polluted the air currently is or how polluted it is forecast to become. Different countries have their own air quality indices, corresponding to different national air quality standards. It is the measure of Air Quality of the environment. It is similar to Air Pollution. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirQuality"></see></summary>
    let AirQuality = Namespaced_IRI.parse _namespace_name "AirQuality" |> NamespacedName

    /// <summary>
    /// The temperature of the air that would be indicated by a thermometer exposed to the air at a location sheltered from direct solar radiation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirTemperature"></see></summary>
    let AirTemperature =
        Namespaced_IRI.parse _namespace_name "AirTemperature" |> NamespacedName

    /// <summary>
    /// It is the air temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Temperature"></see></summary>
    let Temperature =
        Namespaced_IRI.parse _namespace_name "Temperature" |> NamespacedName

    /// <summary>
    /// Device to measure the Air temperature of either indoor or outdoor atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirThermometer"></see></summary>
    let AirThermometer =
        Namespaced_IRI.parse _namespace_name "AirThermometer" |> NamespacedName

    /// <summary>
    /// A device to measure the temperature in a room or outside.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Thermometer"></see></summary>
    let Thermometer =
        Namespaced_IRI.parse _namespace_name "Thermometer" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the alarm system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlarmSystem"></see></summary>
    let AlarmSystem =
        Namespaced_IRI.parse _namespace_name "AlarmSystem" |> NamespacedName

    /// <summary>
    /// Measure of Alcohol Level in the system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevel"></see></summary>
    let AlcoholLevel =
        Namespaced_IRI.parse _namespace_name "AlcoholLevel" |> NamespacedName

    /// <summary>
    /// Device used to detect and measure Alcohol Level in the system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevelSensor"></see></summary>
    let AlcoholLevelSensor =
        Namespaced_IRI.parse _namespace_name "AlcoholLevelSensor" |> NamespacedName

    /// <summary>
    /// The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ampere"></see></summary>
    let Ampere = Namespaced_IRI.parse _namespace_name "Ampere" |> NamespacedName

    /// <summary>
    /// It is the rate of change of angular displacement and is a vector quantity (more precisely, a pseudovector) that specifies the angular speed (rotational speed) of an object and the axis about which the object is rotating. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AngularSpeed"></see></summary>
    let AngularSpeed =
        Namespaced_IRI.parse _namespace_name "AngularSpeed" |> NamespacedName

    /// <summary>
    /// when the source of the sound were animals.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Animals"></see></summary>
    let Animals = Namespaced_IRI.parse _namespace_name "Animals" |> NamespacedName

    /// <summary>
    /// Source where the sound originated.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSource"></see></summary>
    let SoundSource =
        Namespaced_IRI.parse _namespace_name "SoundSource" |> NamespacedName

    /// <summary>
    /// The pressure exerted by the atmosphere as a consequence of gravitational attraction exerted upon the column of air lying directly above the point in question.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressure"></see></summary>
    let AtmosphericPressure =
        Namespaced_IRI.parse _namespace_name "AtmosphericPressure" |> NamespacedName

    /// <summary>
    /// It is the physical force exerted on or against an object by something in contact with it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pressure"></see></summary>
    let Pressure = Namespaced_IRI.parse _namespace_name "Pressure" |> NamespacedName

    /// <summary>
    /// Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used in meteorology to measure atmospheric pressure.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressureSensor"></see></summary>
    let AtmosphericPressureSensor =
        Namespaced_IRI.parse _namespace_name "AtmosphericPressureSensor" |> NamespacedName

    /// <summary>
    /// When the devices are set to take the observations Automatically without any external aid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AutomaticSensing"></see></summary>
    let AutomaticSensing =
        Namespaced_IRI.parse _namespace_name "AutomaticSensing" |> NamespacedName

    /// <summary>
    /// Type of Measurement done using a device.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeasurementType"></see></summary>
    let MeasurementType =
        Namespaced_IRI.parse _namespace_name "MeasurementType" |> NamespacedName

    /// <summary>
    /// When the quality of observation is bad
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bad"></see></summary>
    let Bad = Namespaced_IRI.parse _namespace_name "Bad" |> NamespacedName

    /// <summary>
    /// It identifies the quality of observation taken by a sensor or an actuator
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#QualityOfObservation"></see></summary>
    let QualityOfObservation =
        Namespaced_IRI.parse _namespace_name "QualityOfObservation" |> NamespacedName

    /// <summary>
    /// Metric unit of atmospheric pressure equal to 14.50 pounds per square inch (lb/in2), 1.02 kilograms per square centimetre (kg/cm2), 29.53 inches of mercury (in Hg), or 0.9869 atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bar"></see></summary>
    let Bar = Namespaced_IRI.parse _namespace_name "Bar" |> NamespacedName
    /// <summary>
    /// A tagging device can be Barcode.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Barcode"></see></summary>
    let Barcode = Namespaced_IRI.parse _namespace_name "Barcode" |> NamespacedName

    /// <summary>
    /// Measure of the percentage of the battery capacity that remains available.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BatteryLevel"></see></summary>
    let BatteryLevel =
        Namespaced_IRI.parse _namespace_name "BatteryLevel" |> NamespacedName

    /// <summary>
    /// Beat Per Minute (bpm) is the unit to measure heart rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BeatPerMinute"></see></summary>
    let BeatPerMinute =
        Namespaced_IRI.parse _namespace_name "BeatPerMinute" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the window blinds.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Blind"></see></summary>
    let Blind = Namespaced_IRI.parse _namespace_name "Blind" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodCoagulation"></see>
    /// </summary>
    let BloodCoagulation =
        Namespaced_IRI.parse _namespace_name "BloodCoagulation" |> NamespacedName

    /// <summary>
    /// Measure of Blood glucose level or blood sugar level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodGlucose"></see></summary>
    let BloodGlucose =
        Namespaced_IRI.parse _namespace_name "BloodGlucose" |> NamespacedName

    /// <summary>
    /// Measure of the pressure in your blood vessels when your heart rests between beats.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressure"></see></summary>
    let BloodPressure =
        Namespaced_IRI.parse _namespace_name "BloodPressure" |> NamespacedName

    /// <summary>
    /// Device used to measure Blood Pressure.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressureSensor"></see></summary>
    let BloodPressureSensor =
        Namespaced_IRI.parse _namespace_name "BloodPressureSensor" |> NamespacedName

    /// <summary>
    /// Measure of board temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardTemperature"></see></summary>
    let BoardTemperature =
        Namespaced_IRI.parse _namespace_name "BoardTemperature" |> NamespacedName

    /// <summary>
    /// Device used to measure board temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardThermometer"></see></summary>
    let BoardThermometer =
        Namespaced_IRI.parse _namespace_name "BoardThermometer" |> NamespacedName

    /// <summary>
    /// Sensor used to measure board input voltage.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardVoltageSensor"></see></summary>
    let BoardVoltageSensor =
        Namespaced_IRI.parse _namespace_name "BoardVoltageSensor" |> NamespacedName

    /// <summary>
    /// Device which can measure the difference in electric potential energy between two points per unit electric charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltageSensor"></see></summary>
    let VoltageSensor =
        Namespaced_IRI.parse _namespace_name "VoltageSensor" |> NamespacedName

    /// <summary>
    /// Measure of body temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyTemperature"></see></summary>
    let BodyTemperature =
        Namespaced_IRI.parse _namespace_name "BodyTemperature" |> NamespacedName

    /// <summary>
    /// Device used to measure body temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyThermometer"></see></summary>
    let BodyThermometer =
        Namespaced_IRI.parse _namespace_name "BodyThermometer" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the boiler.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Boiler"></see></summary>
    let Boiler = Namespaced_IRI.parse _namespace_name "Boiler" |> NamespacedName

    /// <summary>
    /// Smart Home/Building Automation as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingAutomation"></see></summary>
    let BuildingAutomation =
        Namespaced_IRI.parse _namespace_name "BuildingAutomation" |> NamespacedName

    /// <summary>
    /// Measure of building or room temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingTemperature"></see></summary>
    let BuildingTemperature =
        Namespaced_IRI.parse _namespace_name "BuildingTemperature" |> NamespacedName

    /// <summary>
    /// A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bus"></see></summary>
    let Bus = Namespaced_IRI.parse _namespace_name "Bus" |> NamespacedName
    /// <summary>
    /// Carbon Dioxide (CO2) measure in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2"></see></summary>
    let CO2 = Namespaced_IRI.parse _namespace_name "CO2" |> NamespacedName
    /// <summary>
    /// Carbon Dioxide (CO2) Sensor used to measure level of CO2 in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2Sensor"></see></summary>
    let CO2Sensor = Namespaced_IRI.parse _namespace_name "CO2Sensor" |> NamespacedName

    /// <summary>
    /// Device used to detect poisonous gaseous in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GaseousPollutantSensor"></see></summary>
    let GaseousPollutantSensor =
        Namespaced_IRI.parse _namespace_name "GaseousPollutantSensor" |> NamespacedName

    /// <summary>
    /// Device to detect Carbon Monoxide (CO) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#COSensor"></see></summary>
    let COSensor = Namespaced_IRI.parse _namespace_name "COSensor" |> NamespacedName
    /// <summary>
    /// Measure of blood calcium level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Calcium"></see></summary>
    let Calcium = Namespaced_IRI.parse _namespace_name "Calcium" |> NamespacedName

    /// <summary>
    /// Purpose of calculating energy consumption by a resource.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalculateEnergyConsumption"></see></summary>
    let CalculateEnergyConsumption =
        Namespaced_IRI.parse _namespace_name "CalculateEnergyConsumption" |> NamespacedName

    /// <summary>
    /// If the measurement was taken when the sensor was being calibrated.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalibrationSensing"></see></summary>
    let CalibrationSensing =
        Namespaced_IRI.parse _namespace_name "CalibrationSensing" |> NamespacedName

    /// <summary>
    /// Candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 10^12 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Candela"></see></summary>
    let Candela = Namespaced_IRI.parse _namespace_name "Candela" |> NamespacedName

    /// <summary>
    /// Measure of the ability of a system to store an electric charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Capacitance"></see></summary>
    let Capacitance =
        Namespaced_IRI.parse _namespace_name "Capacitance" |> NamespacedName

    /// <summary>
    /// The centibar is a unit of pressure defined as 1e-2 bar.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centibar"></see></summary>
    let Centibar = Namespaced_IRI.parse _namespace_name "Centibar" |> NamespacedName
    /// <summary>
    /// A metric unit of length, equal to one hundredth of a metre.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centimetre"></see></summary>
    let Centimetre = Namespaced_IRI.parse _namespace_name "Centimetre" |> NamespacedName
    /// <summary>
    /// It is the unit of length.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Metre"></see></summary>
    let Metre = Namespaced_IRI.parse _namespace_name "Metre" |> NamespacedName

    /// <summary>
    /// Measure of Chemical Agent Atmospheric Concentration
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentration"></see></summary>
    let ChemicalAgentAtmosphericConcentration =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentration" |> NamespacedName

    /// <summary>
    /// Measure of Chemical Agent Concentration
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentConcentration"></see></summary>
    let ChemicalAgentConcentration =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentConcentration" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of chemical particles suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationAirParticles"></see></summary>
    let ChemicalAgentAtmosphericConcentrationAirParticles =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationAirParticles" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationCO"></see></summary>
    let ChemicalAgentAtmosphericConcentrationCO =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationCO" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of dust suspended in the air.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationDust"></see></summary>
    let ChemicalAgentAtmosphericConcentrationDust =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationDust" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of Ammonia (NH3) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNH3"></see></summary>
    let ChemicalAgentAtmosphericConcentrationNH3 =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationNH3" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO"></see></summary>
    let ChemicalAgentAtmosphericConcentrationNO =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationNO" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of NO2 gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO2"></see></summary>
    let ChemicalAgentAtmosphericConcentrationNO2 =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationNO2" |> NamespacedName

    /// <summary>
    /// The concentration of ozone (O3) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationO3"></see></summary>
    let ChemicalAgentAtmosphericConcentrationO3 =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationO3" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of Sulphur dioxide (SO2) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationSO2"></see></summary>
    let ChemicalAgentAtmosphericConcentrationSO2 =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationSO2" |> NamespacedName

    /// <summary>
    /// Measure of the concentration of Volatile Organic Compound gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationVOC"></see></summary>
    let ChemicalAgentAtmosphericConcentrationVOC =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentAtmosphericConcentrationVOC" |> NamespacedName

    /// <summary>
    /// Measure of Chemical Agent Concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentration"></see></summary>
    let ChemicalAgentWaterConcentration =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentWaterConcentration" |> NamespacedName

    /// <summary>
    /// Measure of NH4 ion concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNH4Ion"></see></summary>
    let ChemicalAgentWaterConcentrationNH4Ion =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentWaterConcentrationNH4Ion" |> NamespacedName

    /// <summary>
    /// Measure of NO3 ion concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNO3Ion"></see></summary>
    let ChemicalAgentWaterConcentrationNO3Ion =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentWaterConcentrationNO3Ion" |> NamespacedName

    /// <summary>
    /// Measure of O2 concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationO2"></see></summary>
    let ChemicalAgentWaterConcentrationO2 =
        Namespaced_IRI.parse _namespace_name "ChemicalAgentWaterConcentrationO2" |> NamespacedName

    /// <summary>
    /// Measure of the cholesterol level in a system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cholesterol"></see></summary>
    let Cholesterol =
        Namespaced_IRI.parse _namespace_name "Cholesterol" |> NamespacedName

    /// <summary>
    /// Device used to measure the cholesterol level in a system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CholesterolSensor"></see></summary>
    let CholesterolSensor =
        Namespaced_IRI.parse _namespace_name "CholesterolSensor" |> NamespacedName

    /// <summary>
    /// Smart City as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    /// sensor that measures time
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Clock"></see></summary>
    let Clock = Namespaced_IRI.parse _namespace_name "Clock" |> NamespacedName
    /// <summary>
    /// Measure of cloud cover at a certain time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCover"></see></summary>
    let CloudCover = Namespaced_IRI.parse _namespace_name "CloudCover" |> NamespacedName

    /// <summary>
    /// Cloud Cover Sensor is used to detect whether it is sunny, cloudy, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCoverSensor"></see></summary>
    let CloudCoverSensor =
        Namespaced_IRI.parse _namespace_name "CloudCoverSensor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coagulometer"></see>
    /// </summary>
    let Coagulometer =
        Namespaced_IRI.parse _namespace_name "Coagulometer" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the coffee machine.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CoffeeMachine"></see></summary>
    let CoffeeMachine =
        Namespaced_IRI.parse _namespace_name "CoffeeMachine" |> NamespacedName

    /// <summary>
    /// Actuating devices for Computer or PC.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Computer"></see></summary>
    let Computer = Namespaced_IRI.parse _namespace_name "Computer" |> NamespacedName

    /// <summary>
    /// Measure of ability to conduct electricity. It is measured in siemens per metre (S/m).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Conductivity"></see></summary>
    let Conductivity =
        Namespaced_IRI.parse _namespace_name "Conductivity" |> NamespacedName

    /// <summary>
    /// Device used to measure the conductivity of a system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConductivitySensor"></see></summary>
    let ConductivitySensor =
        Namespaced_IRI.parse _namespace_name "ConductivitySensor" |> NamespacedName

    /// <summary>
    /// When the source of the sound was a construction work.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConstructionWork"></see></summary>
    let ConstructionWork =
        Namespaced_IRI.parse _namespace_name "ConstructionWork" |> NamespacedName

    /// <summary>
    /// Triples for location in the (Latitude, Longitude, Altitude) format.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coordinates"></see></summary>
    let Coordinates =
        Namespaced_IRI.parse _namespace_name "Coordinates" |> NamespacedName

    /// <summary>
    /// SI unit of electric charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coulomb"></see></summary>
    let Coulomb = Namespaced_IRI.parse _namespace_name "Coulomb" |> NamespacedName
    /// <summary>
    /// Number of available particular things.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Count"></see></summary>
    let Count = Namespaced_IRI.parse _namespace_name "Count" |> NamespacedName

    /// <summary>
    /// Number of available bicycles at a particular bicycle docking station.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableBicycles"></see></summary>
    let CountAvailableBicycles =
        Namespaced_IRI.parse _namespace_name "CountAvailableBicycles" |> NamespacedName

    /// <summary>
    /// Number of taxis available at a particular taxi stop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableTaxis"></see></summary>
    let CountAvailableTaxis =
        Namespaced_IRI.parse _namespace_name "CountAvailableTaxis" |> NamespacedName

    /// <summary>
    /// Number of empty docking points at a particular bicycle docking station.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountEmptyDockingPoints"></see></summary>
    let CountEmptyDockingPoints =
        Namespaced_IRI.parse _namespace_name "CountEmptyDockingPoints" |> NamespacedName

    /// <summary>
    /// Number of people within a particular area
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeople"></see></summary>
    let CountPeople =
        Namespaced_IRI.parse _namespace_name "CountPeople" |> NamespacedName

    /// <summary>
    /// Number of people that moved outside an area towards another area during a time window.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleMoving"></see></summary>
    let CountPeopleMoving =
        Namespaced_IRI.parse _namespace_name "CountPeopleMoving" |> NamespacedName

    /// <summary>
    /// Number of people that stayed within an area for more than a threshold of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleStaying"></see></summary>
    let CountPeopleStaying =
        Namespaced_IRI.parse _namespace_name "CountPeopleStaying" |> NamespacedName

    /// <summary>
    /// Count of satellites from which a signal is received
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountStatellitesSignalReceived"></see></summary>
    let CountStatellitesSignalReceived =
        Namespaced_IRI.parse _namespace_name "CountStatellitesSignalReceived" |> NamespacedName

    /// <summary>
    /// Sensors that reckons occurrences or repetitions of physical objects, phenomena or events.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Counter"></see></summary>
    let Counter = Namespaced_IRI.parse _namespace_name "Counter" |> NamespacedName
    /// <summary>
    /// When the source of the sound was crowd.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Crowd"></see></summary>
    let Crowd = Namespaced_IRI.parse _namespace_name "Crowd" |> NamespacedName
    /// <summary>
    /// An actuator to automatically open/close the cupboard.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cupboard"></see></summary>
    let Cupboard = Namespaced_IRI.parse _namespace_name "Cupboard" |> NamespacedName

    /// <summary>
    /// A current sensor is a device that detects electric current in a wire, and generates a signal proportional to that current.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CurrentSensor"></see></summary>
    let CurrentSensor =
        Namespaced_IRI.parse _namespace_name "CurrentSensor" |> NamespacedName

    /// <summary>
    /// An actuator to automatically open/close the curtain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Curtain"></see></summary>
    let Curtain = Namespaced_IRI.parse _namespace_name "Curtain" |> NamespacedName
    /// <summary>
    /// Day is a unit of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Day"></see></summary>
    let Day = Namespaced_IRI.parse _namespace_name "Day" |> NamespacedName
    /// <summary>
    /// Qualitatively defined as the second division of the hour by sixty, the first division by sixty being the minute. SI definition of second is "the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium 133 atom.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondTime"></see></summary>
    let SecondTime = Namespaced_IRI.parse _namespace_name "SecondTime" |> NamespacedName
    /// <summary>
    /// Decibel is a logarithmic unit used to express the ratio of two values of a physical quantity. It is often used to measure sound level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Decibel"></see></summary>
    let Decibel = Namespaced_IRI.parse _namespace_name "Decibel" |> NamespacedName
    /// <summary>
    /// Sound pressure sensed by the human ear.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelA"></see></summary>
    let DecibelA = Namespaced_IRI.parse _namespace_name "DecibelA" |> NamespacedName

    /// <summary>
    /// It describes power ratio in decibels of the measured power referenced to one milliwatt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelMilliwatt"></see></summary>
    let DecibelMilliwatt =
        Namespaced_IRI.parse _namespace_name "DecibelMilliwatt" |> NamespacedName

    /// <summary>
    /// Degree.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Degree"></see></summary>
    let Degree = Namespaced_IRI.parse _namespace_name "Degree" |> NamespacedName

    /// <summary>
    /// A plane angle unit which is equal to 1/360 of a full rotation or pi/180 rad.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeAngle"></see></summary>
    let DegreeAngle =
        Namespaced_IRI.parse _namespace_name "DegreeAngle" |> NamespacedName

    /// <summary>
    /// A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeCelsius"></see></summary>
    let DegreeCelsius =
        Namespaced_IRI.parse _namespace_name "DegreeCelsius" |> NamespacedName

    /// <summary>
    /// Measurement Unit to represent temperature on the Fahrenheit scale.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeFahrenheit"></see></summary>
    let DegreeFahrenheit =
        Namespaced_IRI.parse _namespace_name "DegreeFahrenheit" |> NamespacedName

    /// <summary>
    /// Difference between Dewpoint and surface temperatures.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPoint"></see></summary>
    let DeltaDewPoint =
        Namespaced_IRI.parse _namespace_name "DeltaDewPoint" |> NamespacedName

    /// <summary>
    /// It is the temperature to which air must be cooled at constant pressure to condense to form liquid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPoint"></see></summary>
    let DewPoint = Namespaced_IRI.parse _namespace_name "DewPoint" |> NamespacedName

    /// <summary>
    /// Device that measures the difference between Dewpoint and surface temperatures.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPointSensor"></see></summary>
    let DeltaDewPointSensor =
        Namespaced_IRI.parse _namespace_name "DeltaDewPointSensor" |> NamespacedName

    /// <summary>
    /// Time a device is working and is available
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptime"></see></summary>
    let DeviceUptime =
        Namespaced_IRI.parse _namespace_name "DeviceUptime" |> NamespacedName

    /// <summary>
    /// Sensor that measures time a device is working and is available.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptimeClock"></see></summary>
    let DeviceUptimeClock =
        Namespaced_IRI.parse _namespace_name "DeviceUptimeClock" |> NamespacedName

    /// <summary>
    /// Device that measures dew point.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointSensor"></see></summary>
    let DewPointSensor =
        Namespaced_IRI.parse _namespace_name "DewPointSensor" |> NamespacedName

    /// <summary>
    /// The temperature at which dew forms and is a measure of atmospheric moisture. It is the temperature to which air must be cooled at constant pressure and water content to reach saturation. A higher dew point indicates more moisture in the air; a dew point greater than 20 Degree C (68 Degree F) is considered uncomfortable and greater than 22 Degree C (72 Degree F) is considered to be extremely humid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointTemperature"></see></summary>
    let DewPointTemperature =
        Namespaced_IRI.parse _namespace_name "DewPointTemperature" |> NamespacedName

    /// <summary>
    ///  Measure of the pressure in the arteries when the heart rests between beats.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiastolicBloodPressure"></see></summary>
    let DiastolicBloodPressure =
        Namespaced_IRI.parse _namespace_name "DiastolicBloodPressure" |> NamespacedName

    /// <summary>
    /// Without dimensions; having no appreciable or noteworthy extent. Without physical meaning.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Dimensionless"></see></summary>
    let Dimensionless =
        Namespaced_IRI.parse _namespace_name "Dimensionless" |> NamespacedName

    /// <summary>
    /// Measurements of sensors are affected by the direction of the sensing device. This concept is used to reflect it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Direction"></see></summary>
    let Direction = Namespaced_IRI.parse _namespace_name "Direction" |> NamespacedName

    /// <summary>
    /// The geodetic azimuth of the direction towards which an object is point to.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionAzimuth"></see></summary>
    let DirectionAzimuth =
        Namespaced_IRI.parse _namespace_name "DirectionAzimuth" |> NamespacedName

    /// <summary>
    /// The course or direction in which a object (vehicle, person, ...) is moving.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionHeading"></see></summary>
    let DirectionHeading =
        Namespaced_IRI.parse _namespace_name "DirectionHeading" |> NamespacedName

    /// <summary>
    /// The azimuth direction of a  source relative to the azimuth direction of the DOA sensor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrival"></see></summary>
    let DirectionOfArrival =
        Namespaced_IRI.parse _namespace_name "DirectionOfArrival" |> NamespacedName

    /// <summary>
    /// Sensor that estimates the azimuth direction of sources relative to the sensor’s position.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrivalSensor"></see></summary>
    let DirectionOfArrivalSensor =
        Namespaced_IRI.parse _namespace_name "DirectionOfArrivalSensor" |> NamespacedName

    /// <summary>
    /// Action related to finding observsations either of a particular kind or all.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverObservsation"></see></summary>
    let DiscoverObservsation =
        Namespaced_IRI.parse _namespace_name "DiscoverObservsation" |> NamespacedName

    /// <summary>
    /// Discover sensors in a given context
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverSensors"></see></summary>
    let DiscoverSensors =
        Namespaced_IRI.parse _namespace_name "DiscoverSensors" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the dishwasher.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DishWasher"></see></summary>
    let DishWasher = Namespaced_IRI.parse _namespace_name "DishWasher" |> NamespacedName
    /// <summary>
    /// Measure of how far apart objects are.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Distance"></see></summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName

    /// <summary>
    /// Estimated driving distance (in meters) between a bus and the next bus stop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBus"></see></summary>
    let DistanceNextBus =
        Namespaced_IRI.parse _namespace_name "DistanceNextBus" |> NamespacedName

    /// <summary>
    ///  Virtual device that represents a bus stop X and a bus line Y; it measures the driving distance between the next bus (belonging to line Y) and the bus stop X.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBusSensor"></see></summary>
    let DistanceNextBusSensor =
        Namespaced_IRI.parse _namespace_name "DistanceNextBusSensor" |> NamespacedName

    /// <summary>
    /// Distance Sensor is used to detect distance between two objects for example:  the safety distance with other cars. Distance sensor can be a laser.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceSensor"></see></summary>
    let DistanceSensor =
        Namespaced_IRI.parse _namespace_name "DistanceSensor" |> NamespacedName

    /// <summary>
    /// An actuator to automatically open/close the door.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Door"></see></summary>
    let Door = Namespaced_IRI.parse _namespace_name "Door" |> NamespacedName

    /// <summary>
    /// This sensor detects if a door is in the state of OPEN or CLOSED.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStateSensor"></see></summary>
    let DoorStateSensor =
        Namespaced_IRI.parse _namespace_name "DoorStateSensor" |> NamespacedName

    /// <summary>
    /// Describes if a door is OPEN or CLOSED.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStatus"></see></summary>
    let DoorStatus = Namespaced_IRI.parse _namespace_name "DoorStatus" |> NamespacedName
    /// <summary>
    /// An actuator to automatically open/close the drawer.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Drawer"></see></summary>
    let Drawer = Namespaced_IRI.parse _namespace_name "Drawer" |> NamespacedName
    /// <summary>
    /// A sensing device that measures dust particle concentration.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DustSensor"></see></summary>
    let DustSensor = Namespaced_IRI.parse _namespace_name "DustSensor" |> NamespacedName
    /// <summary>
    /// Unit to measure Air Quality in European cities.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EAQI"></see></summary>
    let EAQI = Namespaced_IRI.parse _namespace_name "EAQI" |> NamespacedName
    /// <summary>
    /// ECG or EKG (Electrocardiogram) device.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ECG"></see></summary>
    let ECG = Namespaced_IRI.parse _namespace_name "ECG" |> NamespacedName
    /// <summary>
    /// The actuator for turning ESP on/off.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ESP"></see></summary>
    let ESP = Namespaced_IRI.parse _namespace_name "ESP" |> NamespacedName

    /// <summary>
    /// It is the physical property of matter that causes it to experience a force when placed in an electromagnetic field. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCharge"></see></summary>
    let ElectricCharge =
        Namespaced_IRI.parse _namespace_name "ElectricCharge" |> NamespacedName

    /// <summary>
    /// Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time. Electric Current is the flow (movement) of electric charge. The amount of electric current through some surface, e.g., a section through a copper conductor, is defined as the amount of electric charge flowing through that surface over time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCurrent"></see></summary>
    let ElectricCurrent =
        Namespaced_IRI.parse _namespace_name "ElectricCurrent" |> NamespacedName

    /// <summary>
    /// Electric field is the electric force per unit charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField"></see></summary>
    let ElectricField =
        Namespaced_IRI.parse _namespace_name "ElectricField" |> NamespacedName

    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 1800 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField1800MHz"></see></summary>
    let ElectricField1800MHz =
        Namespaced_IRI.parse _namespace_name "ElectricField1800MHz" |> NamespacedName

    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2100 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2100MHz"></see></summary>
    let ElectricField2100MHz =
        Namespaced_IRI.parse _namespace_name "ElectricField2100MHz" |> NamespacedName

    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2400 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2400MHz"></see></summary>
    let ElectricField2400MHz =
        Namespaced_IRI.parse _namespace_name "ElectricField2400MHz" |> NamespacedName

    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 900 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField900Mhz"></see></summary>
    let ElectricField900Mhz =
        Namespaced_IRI.parse _namespace_name "ElectricField900Mhz" |> NamespacedName

    /// <summary>
    /// Scientific instrument for measuring electromagnetic fields (EMF). Most of them measure the electromagnetic radiation flux density (DC fields) or the change in an electromagnetic field over time (AC fields).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricFieldSensor"></see></summary>
    let ElectricFieldSensor =
        Namespaced_IRI.parse _namespace_name "ElectricFieldSensor" |> NamespacedName

    /// <summary>
    /// Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricPotential"></see></summary>
    let ElectricPotential =
        Namespaced_IRI.parse _namespace_name "ElectricPotential" |> NamespacedName

    /// <summary>
    /// The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalResistance"></see></summary>
    let ElectricalResistance =
        Namespaced_IRI.parse _namespace_name "ElectricalResistance" |> NamespacedName

    /// <summary>
    /// Sensor that measures the changes in electrical or magnetic signals based on an environmental input.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalSensor"></see></summary>
    let ElectricalSensor =
        Namespaced_IRI.parse _namespace_name "ElectricalSensor" |> NamespacedName

    /// <summary>
    /// Affective Science, Emotion, Mood, Emotional State, Brain Wave as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Emotion"></see></summary>
    let Emotion = Namespaced_IRI.parse _namespace_name "Emotion" |> NamespacedName
    /// <summary>
    /// Energy is the property that must be transferred to an object in order to perform work on. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Energy"></see></summary>
    let Energy = Namespaced_IRI.parse _namespace_name "Energy" |> NamespacedName
    /// <summary>
    /// Energy or Smart Grid as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyDOI"></see></summary>
    let EnergyDOI = Namespaced_IRI.parse _namespace_name "EnergyDOI" |> NamespacedName

    /// <summary>
    /// Sensor to measure power or energy consumption.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyMeter"></see></summary>
    let EnergyMeter =
        Namespaced_IRI.parse _namespace_name "EnergyMeter" |> NamespacedName

    /// <summary>
    /// Purpose for requesting to enter a room.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnterRoom"></see></summary>
    let EnterRoom = Namespaced_IRI.parse _namespace_name "EnterRoom" |> NamespacedName

    /// <summary>
    /// Environment (earthquake, flooding, fire, pollution) as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Environment"></see></summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    /// Purpose to create a chatbot that could provide environment related knowledge in a userfriendly manner.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalChatbot"></see></summary>
    let EnvironmentalChatbot =
        Namespaced_IRI.parse _namespace_name "EnvironmentalChatbot" |> NamespacedName

    /// <summary>
    /// Purpose to create a dashbord that could provide environment related knowledge to the people.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalDashboard"></see></summary>
    let EnvironmentalDashboard =
        Namespaced_IRI.parse _namespace_name "EnvironmentalDashboard" |> NamespacedName

    /// <summary>
    /// Action related to finding error in the data and correcting them
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ErrorCorrection"></see></summary>
    let ErrorCorrection =
        Namespaced_IRI.parse _namespace_name "ErrorCorrection" |> NamespacedName

    /// <summary>
    /// Experiment based measurements.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Experiment"></see></summary>
    let Experiment = Namespaced_IRI.parse _namespace_name "Experiment" |> NamespacedName
    /// <summary>
    /// When the quality of observation is fair
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fair"></see></summary>
    let Fair = Namespaced_IRI.parse _namespace_name "Fair" |> NamespacedName

    /// <summary>
    /// Device to detect is a person has fallen.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FallDetector"></see></summary>
    let FallDetector =
        Namespaced_IRI.parse _namespace_name "FallDetector" |> NamespacedName

    /// <summary>
    /// When the source of the sound was Fan.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fan"></see></summary>
    let Fan = Namespaced_IRI.parse _namespace_name "Fan" |> NamespacedName
    /// <summary>
    /// SI unit of electrical capacitance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Farad"></see></summary>
    let Farad = Namespaced_IRI.parse _namespace_name "Farad" |> NamespacedName
    /// <summary>
    /// Property used to determine the level a certain object such as waste bin is filled upto.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevel"></see></summary>
    let FillLevel = Namespaced_IRI.parse _namespace_name "FillLevel" |> NamespacedName

    /// <summary>
    /// Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTank"></see></summary>
    let FillLevelGasTank =
        Namespaced_IRI.parse _namespace_name "FillLevelGasTank" |> NamespacedName

    /// <summary>
    /// Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the primary tank of the vehicle.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankOne"></see></summary>
    let FillLevelGasTankOne =
        Namespaced_IRI.parse _namespace_name "FillLevelGasTankOne" |> NamespacedName

    /// <summary>
    /// Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the secondary tank of the vehicle.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankTwo"></see></summary>
    let FillLevelGasTankTwo =
        Namespaced_IRI.parse _namespace_name "FillLevelGasTankTwo" |> NamespacedName

    /// <summary>
    /// Ratio between the current filleage level and the total capacity of a waste container.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelWasteContainer"></see></summary>
    let FillLevelWasteContainer =
        Namespaced_IRI.parse _namespace_name "FillLevelWasteContainer" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FloorSensor"></see>
    /// </summary>
    let FloorSensor =
        Namespaced_IRI.parse _namespace_name "FloorSensor" |> NamespacedName

    /// <summary>
    /// The actuator for turning on or off the fog lamp.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FogLamp"></see></summary>
    let FogLamp = Namespaced_IRI.parse _namespace_name "FogLamp" |> NamespacedName

    /// <summary>
    /// Measure of temperature of the food.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FoodTemperature"></see></summary>
    let FoodTemperature =
        Namespaced_IRI.parse _namespace_name "FoodTemperature" |> NamespacedName

    /// <summary>
    /// An actuator to automatically open/close the freezer.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Freezer"></see></summary>
    let Freezer = Namespaced_IRI.parse _namespace_name "Freezer" |> NamespacedName
    /// <summary>
    /// Frequency is the number of occurrences of a repeating event per unit time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Frequency"></see></summary>
    let Frequency = Namespaced_IRI.parse _namespace_name "Frequency" |> NamespacedName

    /// <summary>
    /// Device used to detect the frequency.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FrequencySensor"></see></summary>
    let FrequencySensor =
        Namespaced_IRI.parse _namespace_name "FrequencySensor" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the fridge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fridge"></see></summary>
    let Fridge = Namespaced_IRI.parse _namespace_name "Fridge" |> NamespacedName

    /// <summary>
    /// The amount of fuel a vehicle uses to travel a particular distance at a particular speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumption"></see></summary>
    let FuelConsumption =
        Namespaced_IRI.parse _namespace_name "FuelConsumption" |> NamespacedName

    /// <summary>
    /// A measure that displays the instantaneous fuel consumption of a vehicle during its operation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionInstantaneous"></see></summary>
    let FuelConsumptionInstantaneous =
        Namespaced_IRI.parse _namespace_name "FuelConsumptionInstantaneous" |> NamespacedName

    /// <summary>
    /// Accumulated amount of fuel used during vehicle operation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionTotal"></see></summary>
    let FuelConsumptionTotal =
        Namespaced_IRI.parse _namespace_name "FuelConsumptionTotal" |> NamespacedName

    /// <summary>
    /// Device used to detect fuel level in a system such a car.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelLevel"></see></summary>
    let FuelLevel = Namespaced_IRI.parse _namespace_name "FuelLevel" |> NamespacedName
    /// <summary>
    /// Device that allows an object to localize itself.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GPSSensor"></see></summary>
    let GPSSensor = Namespaced_IRI.parse _namespace_name "GPSSensor" |> NamespacedName

    /// <summary>
    /// Device that detects the presence of gases in an area, often as part of a safety system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GasDetector"></see></summary>
    let GasDetector =
        Namespaced_IRI.parse _namespace_name "GasDetector" |> NamespacedName

    /// <summary>
    /// Gauss is the CGS unit of measurement of magnetic flux density (or magnetic induction) (B) (Source Wikipedia)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gauss"></see></summary>
    let Gauss = Namespaced_IRI.parse _namespace_name "Gauss" |> NamespacedName
    /// <summary>
    /// Device used to detect glucometer, blood sugar, blood glucose level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Glucometer"></see></summary>
    let Glucometer = Namespaced_IRI.parse _namespace_name "Glucometer" |> NamespacedName
    /// <summary>
    /// When the quality of observation is good
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Good"></see></summary>
    let Good = Namespaced_IRI.parse _namespace_name "Good" |> NamespacedName
    /// <summary>
    /// It is a metric system unit of mass
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gram"></see></summary>
    let Gram = Namespaced_IRI.parse _namespace_name "Gram" |> NamespacedName

    /// <summary>
    /// It is defined by mass in grams divided by volume in cubic metres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerCubicMetre"></see></summary>
    let GramPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "GramPerCubicMetre" |> NamespacedName

    /// <summary>
    /// It shows how many grams of a certain substance are present in one litre of a usually liquid or gaseous mixture.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerLitre"></see></summary>
    let GramPerLitre =
        Namespaced_IRI.parse _namespace_name "GramPerLitre" |> NamespacedName

    /// <summary>
    /// A gyrometer is an instrument which measures an angular speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyrometerSensor"></see></summary>
    let GyrometerSensor =
        Namespaced_IRI.parse _namespace_name "GyrometerSensor" |> NamespacedName

    /// <summary>
    /// A gyroscope is a device for measuring or maintaining orientation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyroscopeSensor"></see></summary>
    let GyroscopeSensor =
        Namespaced_IRI.parse _namespace_name "GyroscopeSensor" |> NamespacedName

    /// <summary>
    /// Device used to measure of hydrogen sulphide in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#H2SSensor"></see></summary>
    let H2SSensor = Namespaced_IRI.parse _namespace_name "H2SSensor" |> NamespacedName
    /// <summary>
    /// Describes the preceision of the GPS signal. Smaller the value is, more precise the signal is.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HDOP"></see></summary>
    let HDOP = Namespaced_IRI.parse _namespace_name "HDOP" |> NamespacedName
    /// <summary>
    /// Healthcare as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Health"></see></summary>
    let Health = Namespaced_IRI.parse _namespace_name "Health" |> NamespacedName
    /// <summary>
    /// The number of times your heart beats each minute (bpm).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeat"></see></summary>
    let HeartBeat = Namespaced_IRI.parse _namespace_name "HeartBeat" |> NamespacedName

    /// <summary>
    /// Device to count heart beats per minute.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeatSensor"></see></summary>
    let HeartBeatSensor =
        Namespaced_IRI.parse _namespace_name "HeartBeatSensor" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the heating.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Heating"></see></summary>
    let Heating = Namespaced_IRI.parse _namespace_name "Heating" |> NamespacedName
    /// <summary>
    /// The SI unit of frequency, equal to one cycle per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hertz"></see></summary>
    let Hertz = Namespaced_IRI.parse _namespace_name "Hertz" |> NamespacedName
    /// <summary>
    /// Hour of the day.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hour"></see></summary>
    let Hour = Namespaced_IRI.parse _namespace_name "Hour" |> NamespacedName

    /// <summary>
    /// Measure of Household Appliance Temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HouseholdApplianceTemperature"></see></summary>
    let HouseholdApplianceTemperature =
        Namespaced_IRI.parse _namespace_name "HouseholdApplianceTemperature" |> NamespacedName

    /// <summary>
    /// Device used to detect if an object (vehicle, room, place, etc.) is occupied by Human.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumanPresenceDetector"></see></summary>
    let HumanPresenceDetector =
        Namespaced_IRI.parse _namespace_name "HumanPresenceDetector" |> NamespacedName

    /// <summary>
    /// Device used to detect if on object is occupied or not.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceDetector"></see></summary>
    let PresenceDetector =
        Namespaced_IRI.parse _namespace_name "PresenceDetector" |> NamespacedName

    /// <summary>
    /// A quantity representing the amount of water vapour in the atmosphere or in a gas.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Humidity"></see></summary>
    let Humidity = Namespaced_IRI.parse _namespace_name "Humidity" |> NamespacedName
    /// <summary>
    /// A hydrophone is a microphone designed to be used underwater for recording or listening to underwater sound.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hydrophone"></see></summary>
    let Hydrophone = Namespaced_IRI.parse _namespace_name "Hydrophone" |> NamespacedName

    /// <summary>
    /// Sensor that measures the power consumption of the IEEE802.15.4 interface nodes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IEEE802154InterfaceEnergyMeter"></see></summary>
    let IEEE802154InterfaceEnergyMeter =
        Namespaced_IRI.parse _namespace_name "IEEE802154InterfaceEnergyMeter" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#INR"></see>
    /// </summary>
    let INR = Namespaced_IRI.parse _namespace_name "INR" |> NamespacedName

    /// <summary>
    /// Purpose to identify if an observation is outlier or not.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IdentifyOutlierObservsations"></see></summary>
    let IdentifyOutlierObservsations =
        Namespaced_IRI.parse _namespace_name "IdentifyOutlierObservsations" |> NamespacedName

    /// <summary>
    /// Illuminance is the total luminous flux incident on a surface, per unit area.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Illuminance"></see></summary>
    let Illuminance =
        Namespaced_IRI.parse _namespace_name "Illuminance" |> NamespacedName

    /// <summary>
    /// Sensor that detects and conveys the information that constitutes an image.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ImageSensor"></see></summary>
    let ImageSensor =
        Namespaced_IRI.parse _namespace_name "ImageSensor" |> NamespacedName

    /// <summary>
    /// Length in inches.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Inch"></see></summary>
    let Inch = Namespaced_IRI.parse _namespace_name "Inch" |> NamespacedName
    /// <summary>
    /// Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Index"></see></summary>
    let Index = Namespaced_IRI.parse _namespace_name "Index" |> NamespacedName

    /// <summary>
    /// Downlink Latency.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlLatency"></see></summary>
    let IntDlLatency =
        Namespaced_IRI.parse _namespace_name "IntDlLatency" |> NamespacedName

    /// <summary>
    /// Downlink Throughput.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlThroughputKbps"></see></summary>
    let IntDlThroughputKbps =
        Namespaced_IRI.parse _namespace_name "IntDlThroughputKbps" |> NamespacedName

    /// <summary>
    /// Uplink Packet Loss.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlPacketLoss"></see></summary>
    let IntUlPacketLoss =
        Namespaced_IRI.parse _namespace_name "IntUlPacketLoss" |> NamespacedName

    /// <summary>
    /// Uplink Throughput.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlThroughputKbps"></see></summary>
    let IntUlThroughputKbps =
        Namespaced_IRI.parse _namespace_name "IntUlThroughputKbps" |> NamespacedName

    /// <summary>
    /// If the measurement was tagged invalid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Invalid"></see></summary>
    let Invalid = Namespaced_IRI.parse _namespace_name "Invalid" |> NamespacedName

    /// <summary>
    /// Ionising radiation is radiation that carries enough energy to free electrons from atoms or molecules, thereby ionizing them. Gamma rays, X-rays, and the higher ultraviolet part of the electromagnetic spectrum are ionizing, whereas the lower ultraviolet part of the electromagnetic spectrum, and also the lower part of the spectrum below UV, including visible light (including nearly all types of laser light), infrared, microwaves, and radio waves are all considered non-ionizing radiation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IonisingRadiation"></see></summary>
    let IonisingRadiation =
        Namespaced_IRI.parse _namespace_name "IonisingRadiation" |> NamespacedName

    /// <summary>
    /// An actuator to automatically irrigate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Irrigation"></see></summary>
    let Irrigation = Namespaced_IRI.parse _namespace_name "Irrigation" |> NamespacedName
    /// <summary>
    /// Each of the accountable elements within a group.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Item"></see></summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName
    /// <summary>
    /// Kelvin is a unit of measurement for temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kelvin"></see></summary>
    let Kelvin = Namespaced_IRI.parse _namespace_name "Kelvin" |> NamespacedName

    /// <summary>
    /// Measure of electrical energy equivalent to a power consumption of one thousand watts for one hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KiloWattHour"></see></summary>
    let KiloWattHour =
        Namespaced_IRI.parse _namespace_name "KiloWattHour" |> NamespacedName

    /// <summary>
    /// It is a unit of data transfer rate equal to: 1,000 bits per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilobitsPerSecond"></see></summary>
    let KilobitsPerSecond =
        Namespaced_IRI.parse _namespace_name "KilobitsPerSecond" |> NamespacedName

    /// <summary>
    /// The SI unit of mass, it is equal to the mass of the international prototype of the kilogram.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilogram"></see></summary>
    let Kilogram = Namespaced_IRI.parse _namespace_name "Kilogram" |> NamespacedName

    /// <summary>
    /// It is SI derived unit of density, defined by mass in kilograms divided by volume in cubic metres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilogramPerCubicMetre"></see></summary>
    let KilogramPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "KilogramPerCubicMetre" |> NamespacedName

    /// <summary>
    /// A metric unit of measurement equal to 1,000 metres (approx 0.62 miles).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilometre"></see></summary>
    let Kilometre = Namespaced_IRI.parse _namespace_name "Kilometre" |> NamespacedName

    /// <summary>
    /// It is a unit of speed, expressing the number of kilometres travelled in one hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilometrePerHour"></see></summary>
    let KilometrePerHour =
        Namespaced_IRI.parse _namespace_name "KilometrePerHour" |> NamespacedName

    /// <summary>
    /// A speed/velocity unit which is equal to the speed of an object traveling 1 metre distance in one second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecond"></see></summary>
    let MetrePerSecond =
        Namespaced_IRI.parse _namespace_name "MetrePerSecond" |> NamespacedName

    /// <summary>
    /// Purpose to know sensors in the given area
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KnowSensorsInTheArea"></see></summary>
    let KnowSensorsInTheArea =
        Namespaced_IRI.parse _namespace_name "KnowSensorsInTheArea" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the lamp.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lamp"></see></summary>
    let Lamp = Namespaced_IRI.parse _namespace_name "Lamp" |> NamespacedName
    /// <summary>
    /// An actuator to automatically switch on/off the lavatory.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lavatory"></see></summary>
    let Lavatory = Namespaced_IRI.parse _namespace_name "Lavatory" |> NamespacedName

    /// <summary>
    /// Leaf wetness is a meteorological parameter that describes the amount of dew and precipitation left on surfaces. It is used for monitoring leaf moisture for agricultural purposes, such as fungus and disease control, for control of irrigation systems, and for detection of fog and dew conditions, and early detection of rainfall. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetness"></see></summary>
    let LeafWetness =
        Namespaced_IRI.parse _namespace_name "LeafWetness" |> NamespacedName

    /// <summary>
    /// Leaf Wetness Sensor is used in agriculture to check whether the plants need to be watered.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetnessSensor"></see></summary>
    let LeafWetnessSensor =
        Namespaced_IRI.parse _namespace_name "LeafWetnessSensor" |> NamespacedName

    /// <summary>
    /// Light/Illuminance Sensor is used to adjust the brightness of the surface.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LightSensor"></see></summary>
    let LightSensor =
        Namespaced_IRI.parse _namespace_name "LightSensor" |> NamespacedName

    /// <summary>
    /// A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Litre"></see></summary>
    let Litre = Namespaced_IRI.parse _namespace_name "Litre" |> NamespacedName

    /// <summary>
    /// A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LitrePer100Kilometres"></see></summary>
    let LitrePer100Kilometres =
        Namespaced_IRI.parse _namespace_name "LitrePer100Kilometres" |> NamespacedName

    /// <summary>
    /// This device is used for long range low power wireless communications. We can use this device to report network metrics (SNR, latence, etc.)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterface"></see></summary>
    let LoRaInterface =
        Namespaced_IRI.parse _namespace_name "LoRaInterface" |> NamespacedName

    /// <summary>
    /// Measure the average power consumption of the LoRa interface nodes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterfaceEnergyMeter"></see></summary>
    let LoRaInterfaceEnergyMeter =
        Namespaced_IRI.parse _namespace_name "LoRaInterfaceEnergyMeter" |> NamespacedName

    /// <summary>
    /// A particular place or position.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LocationQK"></see></summary>
    let LocationQK = Namespaced_IRI.parse _namespace_name "LocationQK" |> NamespacedName
    /// <summary>
    /// The SI unit of luminous flux, equal to the amount of light emitted per second in a unit solid angle of one steradian from a uniform source of one candela.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lumen"></see></summary>
    let Lumen = Namespaced_IRI.parse _namespace_name "Lumen" |> NamespacedName

    /// <summary>
    /// Luminous Flux is the measure of the perceived power of light.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousFlux"></see></summary>
    let LuminousFlux =
        Namespaced_IRI.parse _namespace_name "LuminousFlux" |> NamespacedName

    /// <summary>
    ///  It is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye. The SI unit of luminous intensity is the candela (cd), an SI base unit. (Source Wikipedia)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousIntensity"></see></summary>
    let LuminousIntensity =
        Namespaced_IRI.parse _namespace_name "LuminousIntensity" |> NamespacedName

    /// <summary>
    /// The SI unit of illuminance, equal to one lumen per square metre.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lux"></see></summary>
    let Lux = Namespaced_IRI.parse _namespace_name "Lux" |> NamespacedName

    /// <summary>
    /// A region around a magnetic material or a moving electric charge within which the force of magnetism acts.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticField"></see></summary>
    let MagneticField =
        Namespaced_IRI.parse _namespace_name "MagneticField" |> NamespacedName

    /// <summary>
    /// It is the magnetic flux  through a surface is the surface integral of the normal component of the magnetic field (B) passing through that surface. The SI unit of magnetic flux is the weber (Wb). (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticFluxDensity"></see></summary>
    let MagneticFluxDensity =
        Namespaced_IRI.parse _namespace_name "MagneticFluxDensity" |> NamespacedName

    /// <summary>
    /// A magnetometer is an device that measures magnetism—either magnetization of magnetic material like a ferromagnet, or the strength and, in some cases, direction of the magnetic field at a point in space. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Magnetometer"></see></summary>
    let Magnetometer =
        Namespaced_IRI.parse _namespace_name "Magnetometer" |> NamespacedName

    /// <summary>
    /// If the measurement was taken when human effort was involved.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Manual"></see></summary>
    let Manual = Namespaced_IRI.parse _namespace_name "Manual" |> NamespacedName
    /// <summary>
    /// Mass is a property of a physical body. It is the measure of an object's resistance to acceleration when a net force is applied.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mass"></see></summary>
    let Mass = Namespaced_IRI.parse _namespace_name "Mass" |> NamespacedName

    /// <summary>
    /// Purpose of meeting a person for a coffee or arranging a meeting
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeetForCoffee"></see></summary>
    let MeetForCoffee =
        Namespaced_IRI.parse _namespace_name "MeetForCoffee" |> NamespacedName

    /// <summary>
    /// Purpose for either arranging a meeting or actually meeting someone.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Meeting"></see></summary>
    let Meeting = Namespaced_IRI.parse _namespace_name "Meeting" |> NamespacedName

    /// <summary>
    /// Device used to detect Methane in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MethaneSensor"></see></summary>
    let MethaneSensor =
        Namespaced_IRI.parse _namespace_name "MethaneSensor" |> NamespacedName

    /// <summary>
    /// It is the unit of acceleration (Metre Per Second Square, Meter Per Second Square)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecondSquare"></see></summary>
    let MetrePerSecondSquare =
        Namespaced_IRI.parse _namespace_name "MetrePerSecondSquare" |> NamespacedName

    /// <summary>
    /// It is a unit of electric current, or amount of electric charge per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microampere"></see></summary>
    let Microampere =
        Namespaced_IRI.parse _namespace_name "Microampere" |> NamespacedName

    /// <summary>
    /// It is a unit of mass equal to one billionth (1×10^−9) of a kilogram.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microgram"></see></summary>
    let Microgram = Namespaced_IRI.parse _namespace_name "Microgram" |> NamespacedName

    /// <summary>
    /// Microgram per cubic metre is a unit of density defined as microgram divided by cubic metre. Milligram per cubic metre is a derived unit in the International System of Units.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrogramPerCubicMetre"></see></summary>
    let MicrogramPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "MicrogramPerCubicMetre" |> NamespacedName

    /// <summary>
    /// It is a unit of electromotive force or potential difference equal to one millionth of a volt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microvolt"></see></summary>
    let Microvolt = Namespaced_IRI.parse _namespace_name "Microvolt" |> NamespacedName
    /// <summary>
    /// The SI unit of electromotive force, the difference of potential that would carry one ampere of current against one ohm resistance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Volt"></see></summary>
    let Volt = Namespaced_IRI.parse _namespace_name "Volt" |> NamespacedName
    /// <summary>
    /// It is a unit of power.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwatt"></see></summary>
    let Microwatt = Namespaced_IRI.parse _namespace_name "Microwatt" |> NamespacedName
    /// <summary>
    /// It is the SI unit of power, equivalent to one joule per second, corresponding to the rate of consumption of energy in an electric circuit where the potential difference is one volt and the current one ampere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Watt"></see></summary>
    let Watt = Namespaced_IRI.parse _namespace_name "Watt" |> NamespacedName

    /// <summary>
    /// It is one of the unit for radiative and other energy fluxes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrowattPerSquareCentimetre"></see></summary>
    let MicrowattPerSquareCentimetre =
        Namespaced_IRI.parse _namespace_name "MicrowattPerSquareCentimetre" |> NamespacedName

    /// <summary>
    /// It is the SI unit for radiative and other energy fluxes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WattPerSquareMetre"></see></summary>
    let WattPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "WattPerSquareMetre" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the Microwave.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwave"></see></summary>
    let Microwave = Namespaced_IRI.parse _namespace_name "Microwave" |> NamespacedName
    /// <summary>
    /// Measure of the number of miles or the average distance that a vehicle can travel on a specified quantity of fuel
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mileage"></see></summary>
    let Mileage = Namespaced_IRI.parse _namespace_name "Mileage" |> NamespacedName

    /// <summary>
    /// The distance which can be travelled by the vehicle before the next service inspection is required.  A negative distance is transmitted if the service inspection has been passed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageDistanceToService"></see></summary>
    let MileageDistanceToService =
        Namespaced_IRI.parse _namespace_name "MileageDistanceToService" |> NamespacedName

    /// <summary>
    /// The total distance travelled by the particular vehicle since its initial production.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageTotal"></see></summary>
    let MileageTotal =
        Namespaced_IRI.parse _namespace_name "MileageTotal" |> NamespacedName

    /// <summary>
    /// It is a unit of length that is equal to 1,760 yards (approx. 1.609 kilometres).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Miles"></see></summary>
    let Miles = Namespaced_IRI.parse _namespace_name "Miles" |> NamespacedName

    /// <summary>
    /// One thousandth of an ampere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliampere"></see></summary>
    let Milliampere =
        Namespaced_IRI.parse _namespace_name "Milliampere" |> NamespacedName

    /// <summary>
    /// One thousandth of a bar.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millibar"></see></summary>
    let Millibar = Namespaced_IRI.parse _namespace_name "Millibar" |> NamespacedName
    /// <summary>
    /// One thousandth of a gram.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milligram"></see></summary>
    let Milligram = Namespaced_IRI.parse _namespace_name "Milligram" |> NamespacedName

    /// <summary>
    /// It is a density measurement unit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerCubicMetre"></see></summary>
    let MilligramPerCubicMetre =
        Namespaced_IRI.parse _namespace_name "MilligramPerCubicMetre" |> NamespacedName

    /// <summary>
    /// Level of Dissolved substance in liquid measured in mg per litre.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerLitre"></see></summary>
    let MilligramPerLitre =
        Namespaced_IRI.parse _namespace_name "MilligramPerLitre" |> NamespacedName

    /// <summary>
    /// A dose unit which is equal to 1 milligram of a substance per square metre of surface area of the recipient subject.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerSquareMetre"></see></summary>
    let MilligramPerSquareMetre =
        Namespaced_IRI.parse _namespace_name "MilligramPerSquareMetre" |> NamespacedName

    /// <summary>
    /// One thousandth of a litre (0.002 pint).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millilitre"></see></summary>
    let Millilitre = Namespaced_IRI.parse _namespace_name "Millilitre" |> NamespacedName
    /// <summary>
    /// One thousandth of a metre (0.039 in).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millimetre"></see></summary>
    let Millimetre = Namespaced_IRI.parse _namespace_name "Millimetre" |> NamespacedName

    /// <summary>
    /// A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimetre travelled per unit hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillimetrePerHour"></see></summary>
    let MillimetrePerHour =
        Namespaced_IRI.parse _namespace_name "MillimetrePerHour" |> NamespacedName

    /// <summary>
    /// One thousandth of a second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millisecond"></see></summary>
    let Millisecond =
        Namespaced_IRI.parse _namespace_name "Millisecond" |> NamespacedName

    /// <summary>
    /// One thousandth of a volt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millivolt"></see></summary>
    let Millivolt = Namespaced_IRI.parse _namespace_name "Millivolt" |> NamespacedName

    /// <summary>
    /// It is a measure of the intensity of the signal of a radio transmitter.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillivoltPerMetre"></see></summary>
    let MillivoltPerMetre =
        Namespaced_IRI.parse _namespace_name "MillivoltPerMetre" |> NamespacedName

    /// <summary>
    /// A unit of power equal to one thousandth of a watt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliwatt"></see></summary>
    let Milliwatt = Namespaced_IRI.parse _namespace_name "Milliwatt" |> NamespacedName

    /// <summary>
    /// A Minute of Angle (MOA) is an angular measurement. A MOA is 1/60th of a degree.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteAngle"></see></summary>
    let MinuteAngle =
        Namespaced_IRI.parse _namespace_name "MinuteAngle" |> NamespacedName

    /// <summary>
    /// A unit of time equal to 60 seconds or 1/60th of an hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteTime"></see></summary>
    let MinuteTime = Namespaced_IRI.parse _namespace_name "MinuteTime" |> NamespacedName
    /// <summary>
    /// A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmHg"></see></summary>
    let MmHg = Namespaced_IRI.parse _namespace_name "MmHg" |> NamespacedName

    /// <summary>
    /// It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLitre is used to measure cholesterol.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmolPerLitre"></see></summary>
    let MmolPerLitre =
        Namespaced_IRI.parse _namespace_name "MmolPerLitre" |> NamespacedName

    /// <summary>
    /// Handover Execution.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoExecSuccRate"></see></summary>
    let MobHoExecSuccRate =
        Namespaced_IRI.parse _namespace_name "MobHoExecSuccRate" |> NamespacedName

    /// <summary>
    /// Handover Preparation Success Rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoPrepSuccRate"></see></summary>
    let MobHoPrepSuccRate =
        Namespaced_IRI.parse _namespace_name "MobHoPrepSuccRate" |> NamespacedName

    /// <summary>
    /// Handover Mobility Success Rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobMobilitySuccRate"></see></summary>
    let MobMobilitySuccRate =
        Namespaced_IRI.parse _namespace_name "MobMobilitySuccRate" |> NamespacedName

    /// <summary>
    /// Purpose for monitoring temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MonitorTemperature"></see></summary>
    let MonitorTemperature =
        Namespaced_IRI.parse _namespace_name "MonitorTemperature" |> NamespacedName

    /// <summary>
    /// It is the action or process of moving or being moved.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Motion"></see></summary>
    let Motion = Namespaced_IRI.parse _namespace_name "Motion" |> NamespacedName

    /// <summary>
    /// Indicator of whether a person (or object) is detected upon his/her/its movement.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionState"></see></summary>
    let MotionState =
        Namespaced_IRI.parse _namespace_name "MotionState" |> NamespacedName

    /// <summary>
    /// Indicates whether motion of the vehicle is detected or not.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionStateVehicle"></see></summary>
    let MotionStateVehicle =
        Namespaced_IRI.parse _namespace_name "MotionStateVehicle" |> NamespacedName

    /// <summary>
    /// A tagging device can be NFC (Near Field Communication).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NFC"></see></summary>
    let NFC = Namespaced_IRI.parse _namespace_name "NFC" |> NamespacedName
    /// <summary>
    /// Device used to detect NH3 level in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NH3Sensor"></see></summary>
    let NH3Sensor = Namespaced_IRI.parse _namespace_name "NH3Sensor" |> NamespacedName
    /// <summary>
    /// Sensor detecting levels of Nitrogen Dioxide (NO2) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NO2Sensor"></see></summary>
    let NO2Sensor = Namespaced_IRI.parse _namespace_name "NO2Sensor" |> NamespacedName
    /// <summary>
    /// Device used to detect Nitrogen Oxide (NO) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NOSensor"></see></summary>
    let NOSensor = Namespaced_IRI.parse _namespace_name "NOSensor" |> NamespacedName
    /// <summary>
    /// When the source of the sound were noisy neighbours.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Neighbours"></see></summary>
    let Neighbours = Namespaced_IRI.parse _namespace_name "Neighbours" |> NamespacedName
    /// <summary>
    /// Device used to detect Ozone (O3) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#O3Sensor"></see></summary>
    let O3Sensor = Namespaced_IRI.parse _namespace_name "O3Sensor" |> NamespacedName
    /// <summary>
    /// An odometer or odograph is an instrument that indicates distance travelled by a vehicle, such as bicycle or automobile.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Odometer"></see></summary>
    let Odometer = Namespaced_IRI.parse _namespace_name "Odometer" |> NamespacedName
    /// <summary>
    /// Ohm is the unit of electrical resistance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ohm"></see></summary>
    let Ohm = Namespaced_IRI.parse _namespace_name "Ohm" |> NamespacedName
    /// <summary>
    /// Okta is the unit to measure the cloud cover.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Okta"></see></summary>
    let Okta = Namespaced_IRI.parse _namespace_name "Okta" |> NamespacedName

    /// <summary>
    /// Action related to either request for opening the door or actually opening it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpenTheDoor"></see></summary>
    let OpenTheDoor =
        Namespaced_IRI.parse _namespace_name "OpenTheDoor" |> NamespacedName

    /// <summary>
    /// A sensing device that measures dust particle concentration using optical sensing mean.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpticalDustSensor"></see></summary>
    let OpticalDustSensor =
        Namespaced_IRI.parse _namespace_name "OpticalDustSensor" |> NamespacedName

    /// <summary>
    /// Relates to phenomenon and unit that are not available currently in the current version of Taxonomy.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Others"></see></summary>
    let Others = Namespaced_IRI.parse _namespace_name "Others" |> NamespacedName
    /// <summary>
    /// Environmental Origin of a particular observation. With respect to one kind of Source (Sound source), it can be coming from traffic, siren of a police car, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Source"></see></summary>
    let Source = Namespaced_IRI.parse _namespace_name "Source" |> NamespacedName

    /// <summary>
    /// Measures the Water Oxidation Reduction Potential (ORP) as the tendency of a chemical species to acquire electrons and thereby be reduced.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxidationReductionPotentialSensor"></see></summary>
    let OxidationReductionPotentialSensor =
        Namespaced_IRI.parse _namespace_name "OxidationReductionPotentialSensor" |> NamespacedName

    /// <summary>
    /// Device used to detect Oxygen (O2) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxygenSensor"></see></summary>
    let OxygenSensor =
        Namespaced_IRI.parse _namespace_name "OxygenSensor" |> NamespacedName

    /// <summary>
    /// It is a numeric scale used to specify the acidity or basicity of an aqueous solution.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PH"></see></summary>
    let PH = Namespaced_IRI.parse _namespace_name "PH" |> NamespacedName
    /// <summary>
    /// Device used to detect PH level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PHSensor"></see></summary>
    let PHSensor = Namespaced_IRI.parse _namespace_name "PHSensor" |> NamespacedName
    /// <summary>
    /// It describes the concentration of something in water or soil.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PPM"></see></summary>
    let PPM = Namespaced_IRI.parse _namespace_name "PPM" |> NamespacedName

    /// <summary>
    /// It describes the concentration of something in parts per billion parts of water or soil, expressed in any (but common) unit of measurement.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PartsPerBillion"></see></summary>
    let PartsPerBillion =
        Namespaced_IRI.parse _namespace_name "PartsPerBillion" |> NamespacedName

    /// <summary>
    /// Unit for pressure (e.g., atmospheric pressure).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pascal"></see></summary>
    let Pascal = Namespaced_IRI.parse _namespace_name "Pascal" |> NamespacedName
    /// <summary>
    /// Pedometer is used to count the number of steps when walking, running, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pedometer"></see></summary>
    let Pedometer = Namespaced_IRI.parse _namespace_name "Pedometer" |> NamespacedName

    /// <summary>
    /// Device used to count the number of people (eg., used within an indoor area).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleCountSensor"></see></summary>
    let PeopleCountSensor =
        Namespaced_IRI.parse _namespace_name "PeopleCountSensor" |> NamespacedName

    /// <summary>
    /// Device used to count the number of people the moves from an area towards another area during a time window.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleFlowCountSensor"></see></summary>
    let PeopleFlowCountSensor =
        Namespaced_IRI.parse _namespace_name "PeopleFlowCountSensor" |> NamespacedName

    /// <summary>
    /// Average time people stays within an area.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationAverage"></see></summary>
    let PeopleStayDurationAverage =
        Namespaced_IRI.parse _namespace_name "PeopleStayDurationAverage" |> NamespacedName

    /// <summary>
    /// Device used to measure the time people stays within an area.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationSensor"></see></summary>
    let PeopleStayDurationSensor =
        Namespaced_IRI.parse _namespace_name "PeopleStayDurationSensor" |> NamespacedName

    /// <summary>
    /// It is the amount in or for every hundred.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Percent"></see></summary>
    let Percent = Namespaced_IRI.parse _namespace_name "Percent" |> NamespacedName
    /// <summary>
    /// Location, Place, GPS coordinates as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// It is the measure of Blood Potassium Level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Potassium"></see></summary>
    let Potassium = Namespaced_IRI.parse _namespace_name "Potassium" |> NamespacedName
    /// <summary>
    /// A unit of weight equal to 16 oz. 1 pound= 453.592 grams
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pound"></see></summary>
    let Pound = Namespaced_IRI.parse _namespace_name "Pound" |> NamespacedName

    /// <summary>
    /// It is any product of the condensation of atmospheric water vapour that falls under gravity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Precipitation"></see></summary>
    let Precipitation =
        Namespaced_IRI.parse _namespace_name "Precipitation" |> NamespacedName

    /// <summary>
    /// It is a device measuring the amount of precipitation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PrecipitationSensor"></see></summary>
    let PrecipitationSensor =
        Namespaced_IRI.parse _namespace_name "PrecipitationSensor" |> NamespacedName

    /// <summary>
    /// Measure to know if an object is present. It is usually boolean.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Presence"></see></summary>
    let Presence = Namespaced_IRI.parse _namespace_name "Presence" |> NamespacedName

    /// <summary>
    /// Indicates the presence of the first driver card.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCard"></see></summary>
    let PresenceStateDriverCard =
        Namespaced_IRI.parse _namespace_name "PresenceStateDriverCard" |> NamespacedName

    /// <summary>
    /// Indicates the presence of the first driver card.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardOne"></see></summary>
    let PresenceStateDriverCardOne =
        Namespaced_IRI.parse _namespace_name "PresenceStateDriverCardOne" |> NamespacedName

    /// <summary>
    /// Indicates the presence of the second driver card.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardTwo"></see></summary>
    let PresenceStateDriverCardTwo =
        Namespaced_IRI.parse _namespace_name "PresenceStateDriverCardTwo" |> NamespacedName

    /// <summary>
    /// The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateEmergencyVehicle"></see></summary>
    let PresenceStateEmergencyVehicle =
        Namespaced_IRI.parse _namespace_name "PresenceStateEmergencyVehicle" |> NamespacedName

    /// <summary>
    /// The presence or absence of a vehicle parked.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateParking"></see></summary>
    let PresenceStateParking =
        Namespaced_IRI.parse _namespace_name "PresenceStateParking" |> NamespacedName

    /// <summary>
    /// The presence or absence of people passing.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStatePeople"></see></summary>
    let PresenceStatePeople =
        Namespaced_IRI.parse _namespace_name "PresenceStatePeople" |> NamespacedName

    /// <summary>
    /// A device used to detect pressure. For example, it can be attached on the bed to infer if the user is lying, sleeping, sitting, bed occupancy, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PressureSensor"></see></summary>
    let PressureSensor =
        Namespaced_IRI.parse _namespace_name "PressureSensor" |> NamespacedName

    /// <summary>
    /// Measure to detect proximity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Proximity"></see></summary>
    let Proximity = Namespaced_IRI.parse _namespace_name "Proximity" |> NamespacedName

    /// <summary>
    /// Detect if something is within proximity of a sensor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ProximitySensor"></see></summary>
    let ProximitySensor =
        Namespaced_IRI.parse _namespace_name "ProximitySensor" |> NamespacedName

    /// <summary>
    /// When the source of the sound was public transit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PublicTransit"></see></summary>
    let PublicTransit =
        Namespaced_IRI.parse _namespace_name "PublicTransit" |> NamespacedName

    /// <summary>
    /// Pulse Oxymeter, SpO2, Blood Oxygen Saturation Sensor are used to measure the concentration of oxygen in the blood.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PulseOxymeter"></see></summary>
    let PulseOxymeter =
        Namespaced_IRI.parse _namespace_name "PulseOxymeter" |> NamespacedName

    /// <summary>
    /// A tagging device can be QRCode.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#QRCode"></see></summary>
    let QRCode = Namespaced_IRI.parse _namespace_name "QRCode" |> NamespacedName
    /// <summary>
    /// A tagging device can be RFID.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RFID"></see></summary>
    let RFID = Namespaced_IRI.parse _namespace_name "RFID" |> NamespacedName
    /// <summary>
    /// Received Signal Strength Indicator is the signal strength in a wireless network environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RSSI"></see></summary>
    let RSSI = Namespaced_IRI.parse _namespace_name "RSSI" |> NamespacedName
    /// <summary>
    /// The radian is a unit of angular measure defined such that an angle of one radian subtended from the centre of a unit circle produces an arc with arc length 1.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Radian"></see></summary>
    let Radian = Namespaced_IRI.parse _namespace_name "Radian" |> NamespacedName

    /// <summary>
    /// The radian per second is defined as the change in the orientation of an object, in radians, every second. The radian per second is the SI unit of angular (rotational) speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadianPerSecond"></see></summary>
    let RadianPerSecond =
        Namespaced_IRI.parse _namespace_name "RadianPerSecond" |> NamespacedName

    /// <summary>
    /// A particle detector, also known as a radiation detector or Geiger counter, is a device used to detect, track, and/or identify ionising particles, such as those produced by nuclear decay, cosmic radiation, or reactions in a particle accelerator.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticleDetector"></see></summary>
    let RadiationParticleDetector =
        Namespaced_IRI.parse _namespace_name "RadiationParticleDetector" |> NamespacedName

    /// <summary>
    /// The number of ionizing events detected in one minute.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticlesPerMinute"></see></summary>
    let RadiationParticlesPerMinute =
        Namespaced_IRI.parse _namespace_name "RadiationParticlesPerMinute" |> NamespacedName

    /// <summary>
    /// The depth of precipitation (water-equivalent) that accumulated over a measurement time quantity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Rainfall"></see></summary>
    let Rainfall = Namespaced_IRI.parse _namespace_name "Rainfall" |> NamespacedName

    /// <summary>
    /// The portion of electricity that establishes and sustains the electric and magnetic fields of alternating-current equipment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ReactivePower"></see></summary>
    let ReactivePower =
        Namespaced_IRI.parse _namespace_name "ReactivePower" |> NamespacedName

    /// <summary>
    /// Activity Recognized. This is usually made available as a part of analysis done by Google. The available activities recognized are IN_VEHICLE, ON_BICYCLE, ON_FOOT, RUNNING, STILL, TILTING, UNKNOWN, and WALKING.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RecognizedActivity"></see></summary>
    let RecognizedActivity =
        Namespaced_IRI.parse _namespace_name "RecognizedActivity" |> NamespacedName

    /// <summary>
    /// The ratio of vapour pressure to saturation vapour pressure, where vapour pressure is the pressure exerted by the molecules of water vapour and saturation vapour pressure is the pressure exerted by molecules of water vapour in AIR that has attained saturation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RelativeHumidity"></see></summary>
    let RelativeHumidity =
        Namespaced_IRI.parse _namespace_name "RelativeHumidity" |> NamespacedName

    /// <summary>
    /// Connected Users to a communication channel/platform
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ResAverageLicConnectedUsers"></see></summary>
    let ResAverageLicConnectedUsers =
        Namespaced_IRI.parse _namespace_name "ResAverageLicConnectedUsers" |> NamespacedName

    /// <summary>
    /// ERAB Drop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RetERabDrop"></see></summary>
    let RetERabDrop =
        Namespaced_IRI.parse _namespace_name "RetERabDrop" |> NamespacedName

    /// <summary>
    /// Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RevolutionsPerMinute"></see></summary>
    let RevolutionsPerMinute =
        Namespaced_IRI.parse _namespace_name "RevolutionsPerMinute" |> NamespacedName

    /// <summary>
    /// Ratio of time on which a road lane section is occupied by vehicles within a given period of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadOccupancy"></see></summary>
    let RoadOccupancy =
        Namespaced_IRI.parse _namespace_name "RoadOccupancy" |> NamespacedName

    /// <summary>
    /// Device used to measure the road Surface temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadSurfaceThermometer"></see></summary>
    let RoadSurfaceThermometer =
        Namespaced_IRI.parse _namespace_name "RoadSurfaceThermometer" |> NamespacedName

    /// <summary>
    /// Temperature of the road.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadTemperature"></see></summary>
    let RoadTemperature =
        Namespaced_IRI.parse _namespace_name "RoadTemperature" |> NamespacedName

    /// <summary>
    /// When the feature of interest is room
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Room"></see></summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName

    /// <summary>
    /// Temperature of a room.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoomTemperature"></see></summary>
    let RoomTemperature =
        Namespaced_IRI.parse _namespace_name "RoomTemperature" |> NamespacedName

    /// <summary>
    /// Rotational speed (or speed of revolution) of an object rotating around an axis is the number of turns of the object divided by time, specified as revolutions per minute (rpm), revolutions per second (rev/s), or radians per second (rad/s). (Source Wikipedia)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeed"></see></summary>
    let RotationalSpeed =
        Namespaced_IRI.parse _namespace_name "RotationalSpeed" |> NamespacedName

    /// <summary>
    /// Rotational speed is a property that is the rate of rotation of a material around an axis, in this case the engine cylinders.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeedEngine"></see></summary>
    let RotationalSpeedEngine =
        Namespaced_IRI.parse _namespace_name "RotationalSpeedEngine" |> NamespacedName

    /// <summary>
    /// Compares the level of a desired signal to the level of noise.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SNR"></see></summary>
    let SNR = Namespaced_IRI.parse _namespace_name "SNR" |> NamespacedName
    /// <summary>
    /// Device use to detect Sulphur Dioxide (SO2) level in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SO2Sensor"></see></summary>
    let SO2Sensor = Namespaced_IRI.parse _namespace_name "SO2Sensor" |> NamespacedName
    /// <summary>
    /// It is a measure of the amount of oxygenated haemoglobin in the blood.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SPO2"></see></summary>
    let SPO2 = Namespaced_IRI.parse _namespace_name "SPO2" |> NamespacedName
    /// <summary>
    /// It is the measure of all the salts dissolved in water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Salinity"></see></summary>
    let Salinity = Namespaced_IRI.parse _namespace_name "Salinity" |> NamespacedName
    /// <summary>
    /// Device use to detect salinity of water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SaltMeter"></see></summary>
    let SaltMeter = Namespaced_IRI.parse _namespace_name "SaltMeter" |> NamespacedName
    /// <summary>
    /// Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values are part of a continuous variable which can take any numeric value.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Scale"></see></summary>
    let Scale = Namespaced_IRI.parse _namespace_name "Scale" |> NamespacedName

    /// <summary>
    ///  Actuator used to turn Seat Belt Tension Actuator on or off.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SeatBeltTensionSensor"></see></summary>
    let SeatBeltTensionSensor =
        Namespaced_IRI.parse _namespace_name "SeatBeltTensionSensor" |> NamespacedName

    /// <summary>
    /// It is a unit of angular measurement equal to 1/60 of one degree.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondAngle"></see></summary>
    let SecondAngle =
        Namespaced_IRI.parse _namespace_name "SecondAngle" |> NamespacedName

    /// <summary>
    /// Seismometers are instruments that measure motions of the ground, including those of seismic waves generated by earthquakes, volcanic eruptions, and other seismic sources.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Seismometer"></see></summary>
    let Seismometer =
        Namespaced_IRI.parse _namespace_name "Seismometer" |> NamespacedName

    /// <summary>
    /// Shake sensor is used to deduce the quality of the road, earthquakes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ShakeSensor"></see></summary>
    let ShakeSensor =
        Namespaced_IRI.parse _namespace_name "ShakeSensor" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the shower.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Shower"></see></summary>
    let Shower = Namespaced_IRI.parse _namespace_name "Shower" |> NamespacedName

    /// <summary>
    /// Conductivity is measured in Siemens per metre (S/m).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SiemensPerMetre"></see></summary>
    let SiemensPerMetre =
        Namespaced_IRI.parse _namespace_name "SiemensPerMetre" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the sink.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sink"></see></summary>
    let Sink = Namespaced_IRI.parse _namespace_name "Sink" |> NamespacedName
    /// <summary>
    /// When source of the sound were sirens either from ambulance, police car or factory etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sirens"></see></summary>
    let Sirens = Namespaced_IRI.parse _namespace_name "Sirens" |> NamespacedName

    /// <summary>
    /// Electroderal activity (also known as skin conductance or galvanic skin response) directly correlates to the sympathetic nervous system activity and thus provides a powerful tool for monitoring arousal and certain aspects of autonomic regulation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductance"></see></summary>
    let SkinConductance =
        Namespaced_IRI.parse _namespace_name "SkinConductance" |> NamespacedName

    /// <summary>
    /// Device used to detect Skin Conductance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductanceSensor"></see></summary>
    let SkinConductanceSensor =
        Namespaced_IRI.parse _namespace_name "SkinConductanceSensor" |> NamespacedName

    /// <summary>
    /// A sleep detector sensor which detects whether the human falls asleep or wakes up.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepDetector"></see></summary>
    let SleepDetector =
        Namespaced_IRI.parse _namespace_name "SleepDetector" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepSensor"></see>
    /// </summary>
    let SleepSensor =
        Namespaced_IRI.parse _namespace_name "SleepSensor" |> NamespacedName

    /// <summary>
    /// A sleep monitor sensor which tracks the human sleep state.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepMonitor"></see></summary>
    let SleepMonitor =
        Namespaced_IRI.parse _namespace_name "SleepMonitor" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepState"></see>
    /// </summary>
    let SleepState = Namespaced_IRI.parse _namespace_name "SleepState" |> NamespacedName

    /// <summary>
    /// Device used to detect if there is a fire or the smoke.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SmokeDetector"></see></summary>
    let SmokeDetector =
        Namespaced_IRI.parse _namespace_name "SmokeDetector" |> NamespacedName

    /// <summary>
    /// The actuator that turn Snow chains on/off.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SnowChains"></see></summary>
    let SnowChains = Namespaced_IRI.parse _namespace_name "SnowChains" |> NamespacedName
    /// <summary>
    /// Measure of Blood Sodium level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sodium"></see></summary>
    let Sodium = Namespaced_IRI.parse _namespace_name "Sodium" |> NamespacedName

    /// <summary>
    /// It is the quantity of water contained in a material, such as soil.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumidity"></see></summary>
    let SoilHumidity =
        Namespaced_IRI.parse _namespace_name "SoilHumidity" |> NamespacedName

    /// <summary>
    /// Soil Humidity sensor, Soil moisture, Hygrometer are an instrument used for measuring the soil moisture or soil humidity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumiditySensor"></see></summary>
    let SoilHumiditySensor =
        Namespaced_IRI.parse _namespace_name "SoilHumiditySensor" |> NamespacedName

    /// <summary>
    /// The force per unit area required to remove film water from soil.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilMoistureTension"></see></summary>
    let SoilMoistureTension =
        Namespaced_IRI.parse _namespace_name "SoilMoistureTension" |> NamespacedName

    /// <summary>
    /// Soil temperature is the bulk temperature of the soil, not the surface (skin) temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilTemperature"></see></summary>
    let SoilTemperature =
        Namespaced_IRI.parse _namespace_name "SoilTemperature" |> NamespacedName

    /// <summary>
    /// This sensor reports Soil temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilThermometer"></see></summary>
    let SoilThermometer =
        Namespaced_IRI.parse _namespace_name "SoilThermometer" |> NamespacedName

    /// <summary>
    /// It is the power per unit area received from the Sun in the form of electromagnetic radiation in the wavelength range of the measuring instrument. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiation"></see></summary>
    let SolarRadiation =
        Namespaced_IRI.parse _namespace_name "SolarRadiation" |> NamespacedName

    /// <summary>
    /// Device used to detect Solar Radiation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiationSensor"></see></summary>
    let SolarRadiationSensor =
        Namespaced_IRI.parse _namespace_name "SolarRadiationSensor" |> NamespacedName

    /// <summary>
    /// Measure of noise level in the environment
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sound"></see></summary>
    let Sound = Namespaced_IRI.parse _namespace_name "Sound" |> NamespacedName

    /// <summary>
    /// Sound pressure level is a logarithmic measure of the RMS sound pressure of a sound relative to a reference value, the threshold of hearing. The reference sound pressure was chosen conventionally to correspond to the quietest sound at 1000 Hz that the human ear can detect (20 uPa). In this case, the specific parameter is measured in an open environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevel"></see></summary>
    let SoundPressureLevel =
        Namespaced_IRI.parse _namespace_name "SoundPressureLevel" |> NamespacedName

    /// <summary>
    /// Similar to Sound.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevelAmbient"></see></summary>
    let SoundPressureLevelAmbient =
        Namespaced_IRI.parse _namespace_name "SoundPressureLevelAmbient" |> NamespacedName

    /// <summary>
    /// Sensor used to detect Noise level. It can be Sound Sensor, Noise level Sensor, Volume sensor, Microphone
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSensor"></see></summary>
    let SoundSensor =
        Namespaced_IRI.parse _namespace_name "SoundSensor" |> NamespacedName

    /// <summary>
    /// The rate at which someone or something moves or operates or is able to move or operate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Speed"></see></summary>
    let Speed = Namespaced_IRI.parse _namespace_name "Speed" |> NamespacedName

    /// <summary>
    /// A measure of the average rate of motion of an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedAverage"></see></summary>
    let SpeedAverage =
        Namespaced_IRI.parse _namespace_name "SpeedAverage" |> NamespacedName

    /// <summary>
    /// A measure of the instantaneous rate of motion of an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedInstantaneous"></see></summary>
    let SpeedInstantaneous =
        Namespaced_IRI.parse _namespace_name "SpeedInstantaneous" |> NamespacedName

    /// <summary>
    /// A measure of the median rate of motion of an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedMedian"></see></summary>
    let SpeedMedian =
        Namespaced_IRI.parse _namespace_name "SpeedMedian" |> NamespacedName

    /// <summary>
    /// Sensor used to detect speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedSensor"></see></summary>
    let SpeedSensor =
        Namespaced_IRI.parse _namespace_name "SpeedSensor" |> NamespacedName

    /// <summary>
    /// Device used to count the number of people that stays within an area for more than a threshold of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#StayingPeopleCountSensor"></see></summary>
    let StayingPeopleCountSensor =
        Namespaced_IRI.parse _namespace_name "StayingPeopleCountSensor" |> NamespacedName

    /// <summary>
    /// It is a measure of number of Step taken.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Step"></see></summary>
    let Step = Namespaced_IRI.parse _namespace_name "Step" |> NamespacedName

    /// <summary>
    /// The position of the Sun in the sky is a function of both time and the geographic coordinates of the observer on the surface of the Earth. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirection"></see></summary>
    let SunPositionDirection =
        Namespaced_IRI.parse _namespace_name "SunPositionDirection" |> NamespacedName

    /// <summary>
    /// Sensor used to detect sun position.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirectionSensor"></see></summary>
    let SunPositionDirectionSensor =
        Namespaced_IRI.parse _namespace_name "SunPositionDirectionSensor" |> NamespacedName

    /// <summary>
    /// It is the altitude of the sun, the angle between the horizon and the centre of the sun's disc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevation"></see></summary>
    let SunPositionElevation =
        Namespaced_IRI.parse _namespace_name "SunPositionElevation" |> NamespacedName

    /// <summary>
    /// Device used to detect sun elevation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevationSensor"></see></summary>
    let SunPositionElevationSensor =
        Namespaced_IRI.parse _namespace_name "SunPositionElevationSensor" |> NamespacedName

    /// <summary>
    /// It is the pressure when the heart beats while pumping blood.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SystolicBloodPressure"></see></summary>
    let SystolicBloodPressure =
        Namespaced_IRI.parse _namespace_name "SystolicBloodPressure" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the television.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TV"></see></summary>
    let TV = Namespaced_IRI.parse _namespace_name "TV" |> NamespacedName
    /// <summary>
    /// An actuator to automatically switch on/off the Telephone.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Telephone"></see></summary>
    let Telephone = Namespaced_IRI.parse _namespace_name "Telephone" |> NamespacedName

    /// <summary>
    /// The temperature of a vehicle engine.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureEngine"></see></summary>
    let TemperatureEngine =
        Namespaced_IRI.parse _namespace_name "TemperatureEngine" |> NamespacedName

    /// <summary>
    /// The temperature of the air that would be indicated by a thermometer exposed to the air inside a waste container.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureWasteContainer"></see></summary>
    let TemperatureWasteContainer =
        Namespaced_IRI.parse _namespace_name "TemperatureWasteContainer" |> NamespacedName

    /// <summary>
    /// It is the SI unit of magnetic flux density.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tesla"></see></summary>
    let Tesla = Namespaced_IRI.parse _namespace_name "Tesla" |> NamespacedName

    /// <summary>
    /// It is a device used to monitor the throttle position of a vehicle.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ThrottleSensor"></see></summary>
    let ThrottleSensor =
        Namespaced_IRI.parse _namespace_name "ThrottleSensor" |> NamespacedName

    /// <summary>
    /// Estimated time till an object is arriving to a specific location (typically used in transportation).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrival"></see></summary>
    let TimeOfArrival =
        Namespaced_IRI.parse _namespace_name "TimeOfArrival" |> NamespacedName

    /// <summary>
    /// Estimated time (in seconds) till a bus will arrive at a specific bus stop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBus"></see></summary>
    let TimeOfArrivalNextBus =
        Namespaced_IRI.parse _namespace_name "TimeOfArrivalNextBus" |> NamespacedName

    /// <summary>
    /// Virtual device that represents a bus stop X and a bus line Y; it estimates the remaining time the next bus (belonging to line Y) will arrive at bus stop X.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBusSensor"></see></summary>
    let TimeOfArrivalNextBusSensor =
        Namespaced_IRI.parse _namespace_name "TimeOfArrivalNextBusSensor" |> NamespacedName

    /// <summary>
    /// Virtual device that estimates the remaining time for an object to arrive at a specific location.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalSensor"></see></summary>
    let TimeOfArrivalSensor =
        Namespaced_IRI.parse _namespace_name "TimeOfArrivalSensor" |> NamespacedName

    /// <summary>
    /// Indicator of whether a person (or object) has overpassed a particular time threshold (e.g. maximum number of hours driving, etc.)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedState"></see></summary>
    let TimeRelatedState =
        Namespaced_IRI.parse _namespace_name "TimeRelatedState" |> NamespacedName

    /// <summary>
    /// Indicator of whether the driver of a vehicle approaches or exceeds his/her working time limits.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriver"></see></summary>
    let TimeRelatedStateDriver =
        Namespaced_IRI.parse _namespace_name "TimeRelatedStateDriver" |> NamespacedName

    /// <summary>
    /// Indicates if the first driver approaches or exceeds working time limits (or other limits).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverOne"></see></summary>
    let TimeRelatedStateDriverOne =
        Namespaced_IRI.parse _namespace_name "TimeRelatedStateDriverOne" |> NamespacedName

    /// <summary>
    /// Indicates if the second driver approaches or exceeds working time limits (or other limits).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverTwo"></see></summary>
    let TimeRelatedStateDriverTwo =
        Namespaced_IRI.parse _namespace_name "TimeRelatedStateDriverTwo" |> NamespacedName

    /// <summary>
    /// Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Timestamp"></see></summary>
    let Timestamp = Namespaced_IRI.parse _namespace_name "Timestamp" |> NamespacedName
    /// <summary>
    /// It is a non-SI metric unit of mass equal to 1,000 kilograms.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tonne"></see></summary>
    let Tonne = Namespaced_IRI.parse _namespace_name "Tonne" |> NamespacedName

    /// <summary>
    /// Device that captures and records physical touch or embrace on a device and/or object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TouchSensor"></see></summary>
    let TouchSensor =
        Namespaced_IRI.parse _namespace_name "TouchSensor" |> NamespacedName

    /// <summary>
    /// Tourism as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tourism"></see></summary>
    let Tourism = Namespaced_IRI.parse _namespace_name "Tourism" |> NamespacedName
    /// <summary>
    /// When the source of the sound was traffic.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Traffic"></see></summary>
    let Traffic = Namespaced_IRI.parse _namespace_name "Traffic" |> NamespacedName

    /// <summary>
    /// The intensity of a traffic flow is the number of vehicles passing a cross section of a road in a unit of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TrafficIntensity"></see></summary>
    let TrafficIntensity =
        Namespaced_IRI.parse _namespace_name "TrafficIntensity" |> NamespacedName

    /// <summary>
    /// Transportation, Smart Car/Vehicle, Intelligent Transport System (ITS) as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Transportation"></see></summary>
    let Transportation =
        Namespaced_IRI.parse _namespace_name "Transportation" |> NamespacedName

    /// <summary>
    /// Ultrasonic sensors are used to deduce human posture in smart home for example.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#UltrasonicSensor"></see></summary>
    let UltrasonicSensor =
        Namespaced_IRI.parse _namespace_name "UltrasonicSensor" |> NamespacedName

    /// <summary>
    /// Sensor that detects levels of Volatile Organic Components (VOC) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VOCSensor"></see></summary>
    let VOCSensor = Namespaced_IRI.parse _namespace_name "VOCSensor" |> NamespacedName

    /// <summary>
    /// Device used to count the number of vehicles (e.g., used within the Citypulse project).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleCountSensor"></see></summary>
    let VehicleCountSensor =
        Namespaced_IRI.parse _namespace_name "VehicleCountSensor" |> NamespacedName

    /// <summary>
    /// Measure to indicates whether the vehicle is exceeding the legal speed limit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleOverspeedState"></see></summary>
    let VehicleOverspeedState =
        Namespaced_IRI.parse _namespace_name "VehicleOverspeedState" |> NamespacedName

    /// <summary>
    /// Device used to detect if an vehicle is present at a place.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclePresenceDetector"></see></summary>
    let VehiclePresenceDetector =
        Namespaced_IRI.parse _namespace_name "VehiclePresenceDetector" |> NamespacedName

    /// <summary>
    /// Number of vehicles that traverse a concrete region of the space in one minute.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclesPerMinute"></see></summary>
    let VehiclesPerMinute =
        Namespaced_IRI.parse _namespace_name "VehiclesPerMinute" |> NamespacedName

    /// <summary>
    /// An actuator to automatically open/close the ventilation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ventilation"></see></summary>
    let Ventilation =
        Namespaced_IRI.parse _namespace_name "Ventilation" |> NamespacedName

    /// <summary>
    /// The state of being able to see or be seen.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Visibility"></see></summary>
    let Visibility = Namespaced_IRI.parse _namespace_name "Visibility" |> NamespacedName

    /// <summary>
    /// Device used to detect Visibility.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VisibilitySensor"></see></summary>
    let VisibilitySensor =
        Namespaced_IRI.parse _namespace_name "VisibilitySensor" |> NamespacedName

    /// <summary>
    /// A voice command to control a voice controlled system or environment, such as a smart home.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommand"></see></summary>
    let VoiceCommand =
        Namespaced_IRI.parse _namespace_name "VoiceCommand" |> NamespacedName

    /// <summary>
    /// An actuating device called  that allows to semi-control the environment of the Voice Command Sensor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandController"></see></summary>
    let VoiceCommandController =
        Namespaced_IRI.parse _namespace_name "VoiceCommandController" |> NamespacedName

    /// <summary>
    /// Sensor that uses automatic speech recognition technology to match or reject a recorded voice command according to a specified set of available voice commands.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandSensor"></see></summary>
    let VoiceCommandSensor =
        Namespaced_IRI.parse _namespace_name "VoiceCommandSensor" |> NamespacedName

    /// <summary>
    /// In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltAmpereReactive"></see></summary>
    let VoltAmpereReactive =
        Namespaced_IRI.parse _namespace_name "VoltAmpereReactive" |> NamespacedName

    /// <summary>
    /// An electromotive force or potential difference expressed in volts (Source Google).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Voltage"></see></summary>
    let Voltage = Namespaced_IRI.parse _namespace_name "Voltage" |> NamespacedName

    /// <summary>
    /// An actuator to automatically switch on/off the washing machine.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WashingMachine"></see></summary>
    let WashingMachine =
        Namespaced_IRI.parse _namespace_name "WashingMachine" |> NamespacedName

    /// <summary>
    /// Device used to measure the conductivity of water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterConductivitySensor"></see></summary>
    let WaterConductivitySensor =
        Namespaced_IRI.parse _namespace_name "WaterConductivitySensor" |> NamespacedName

    /// <summary>
    /// The height reached by the water in a reservoir, river, storage tank, or similar.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterLevel"></see></summary>
    let WaterLevel = Namespaced_IRI.parse _namespace_name "WaterLevel" |> NamespacedName

    /// <summary>
    /// Sensor used to measure NH4 concentration level in the water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNH4IonSensor"></see></summary>
    let WaterNH4IonSensor =
        Namespaced_IRI.parse _namespace_name "WaterNH4IonSensor" |> NamespacedName

    /// <summary>
    /// Sensor used to measure NO3 concentration level in the water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNO3IonSensor"></see></summary>
    let WaterNO3IonSensor =
        Namespaced_IRI.parse _namespace_name "WaterNO3IonSensor" |> NamespacedName

    /// <summary>
    /// Sensor used to measure O2 concentration level in the water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterO2IonSensor"></see></summary>
    let WaterO2IonSensor =
        Namespaced_IRI.parse _namespace_name "WaterO2IonSensor" |> NamespacedName

    /// <summary>
    /// Device used to detect PH level of water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterPHSensor"></see></summary>
    let WaterPHSensor =
        Namespaced_IRI.parse _namespace_name "WaterPHSensor" |> NamespacedName

    /// <summary>
    /// Sea surface temperature (SST) is the water temperature close to the ocean's surface.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterTemperature"></see></summary>
    let WaterTemperature =
        Namespaced_IRI.parse _namespace_name "WaterTemperature" |> NamespacedName

    /// <summary>
    /// This sensor reports Water temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterThermometer"></see></summary>
    let WaterThermometer =
        Namespaced_IRI.parse _namespace_name "WaterThermometer" |> NamespacedName

    /// <summary>
    /// Weather Forecasting, Meterology as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weather"></see></summary>
    let Weather = Namespaced_IRI.parse _namespace_name "Weather" |> NamespacedName

    /// <summary>
    /// Luminosity in the weather
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherLuminosity"></see></summary>
    let WeatherLuminosity =
        Namespaced_IRI.parse _namespace_name "WeatherLuminosity" |> NamespacedName

    /// <summary>
    /// Weather Precipitation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherPrecipitation"></see></summary>
    let WeatherPrecipitation =
        Namespaced_IRI.parse _namespace_name "WeatherPrecipitation" |> NamespacedName

    /// <summary>
    /// A body's relative mass or the quantity of matter contained by it, giving rise to a downward force; the heaviness of a person or thing.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weight"></see></summary>
    let Weight = Namespaced_IRI.parse _namespace_name "Weight" |> NamespacedName

    /// <summary>
    /// Device used to weight an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeightSensor"></see></summary>
    let WeightSensor =
        Namespaced_IRI.parse _namespace_name "WeightSensor" |> NamespacedName

    /// <summary>
    /// Measure the average power consumption of the WiFi interface nodes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WiFiInterfaceEnergyMeter"></see></summary>
    let WiFiInterfaceEnergyMeter =
        Namespaced_IRI.parse _namespace_name "WiFiInterfaceEnergyMeter" |> NamespacedName

    /// <summary>
    /// The cooling effect of wind blowing on a surface.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChill"></see></summary>
    let WindChill = Namespaced_IRI.parse _namespace_name "WindChill" |> NamespacedName

    /// <summary>
    /// Device used to detect Wind Chill.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChillSensor"></see></summary>
    let WindChillSensor =
        Namespaced_IRI.parse _namespace_name "WindChillSensor" |> NamespacedName

    /// <summary>
    /// The geodetic azimuth of the direction from which the wind is blowing.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirection"></see></summary>
    let WindDirection =
        Namespaced_IRI.parse _namespace_name "WindDirection" |> NamespacedName

    /// <summary>
    /// Device used to detect wind direction.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirectionSensor"></see></summary>
    let WindDirectionSensor =
        Namespaced_IRI.parse _namespace_name "WindDirectionSensor" |> NamespacedName

    /// <summary>
    /// The ratio of the distance covered by moving air to the time quantity taken to cover it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeed"></see></summary>
    let WindSpeed = Namespaced_IRI.parse _namespace_name "WindSpeed" |> NamespacedName

    /// <summary>
    /// Wind Speed Sensor, Anemometer or Wind Velocity Sensor is used to measure the wind speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeedSensor"></see></summary>
    let WindSpeedSensor =
        Namespaced_IRI.parse _namespace_name "WindSpeedSensor" |> NamespacedName

    /// <summary>
    /// An actuator to automatically open/close the window.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Window"></see></summary>
    let Window = Namespaced_IRI.parse _namespace_name "Window" |> NamespacedName

    /// <summary>
    /// Indicator of whether a person (or object) is working or not
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingState"></see></summary>
    let WorkingState =
        Namespaced_IRI.parse _namespace_name "WorkingState" |> NamespacedName

    /// <summary>
    /// Indicator of whether the driver of a vehicle is present or not
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriver"></see></summary>
    let WorkingStateDriver =
        Namespaced_IRI.parse _namespace_name "WorkingStateDriver" |> NamespacedName

    /// <summary>
    /// State of work of the first driver as defined in the FMS standard.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverOne"></see></summary>
    let WorkingStateDriverOne =
        Namespaced_IRI.parse _namespace_name "WorkingStateDriverOne" |> NamespacedName

    /// <summary>
    /// State of work of the second driver as defined in the FMS standard.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverTwo"></see></summary>
    let WorkingStateDriverTwo =
        Namespaced_IRI.parse _namespace_name "WorkingStateDriverTwo" |> NamespacedName

    /// <summary>
    /// This unit is used to measure delta dew point. Natural number (W/out unit).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Wout"></see></summary>
    let Wout = Namespaced_IRI.parse _namespace_name "Wout" |> NamespacedName
    /// <summary>
    /// Year as a unit of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Year"></see></summary>
    let Year = Namespaced_IRI.parse _namespace_name "Year" |> NamespacedName
