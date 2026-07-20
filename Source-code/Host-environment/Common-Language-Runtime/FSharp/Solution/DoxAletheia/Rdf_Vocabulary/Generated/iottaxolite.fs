namespace http.purl.org.iot.vocab.iot_taxonomy_lite.hash

open DoxAletheia

module iottaxolite =
    let _namespace_name = "http://purl.org/iot/vocab/iot-taxonomy-lite#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The ABS (Anti-lock Braking System) receives information from ABS computer to control the pressure on the breaks, This helps the wheels not to get locked up, it adjust the break pressure and prevents the wheels from locking. (Definition Source Google).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ABS"></see></summary>
    let ABS = _prefix "ABS"
    /// <summary>
    /// Initial E-UTRAN Radio Access Bearer establishment success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabEstabSuccRate"></see></summary>
    let AccInitialERabEstabSuccRate = _prefix "AccInitialERabEstabSuccRate"
    /// <summary>
    /// Communication related properties.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Communication"></see></summary>
    let Communication = _prefix "Communication"
    /// <summary>
    /// Initial E-UTRAN Radio Access Bearer setup success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabSetupSuccRate"></see></summary>
    let AccInitialERabSetupSuccRate = _prefix "AccInitialERabSetupSuccRate"
    /// <summary>
    /// Radio Resource Control connection setup success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccRrcConnSetupSuccRate"></see></summary>
    let AccRrcConnSetupSuccRate = _prefix "AccRrcConnSetupSuccRate"
    /// <summary>
    /// S1 (S1 standardized interface between eNB and Evolved Packet Core) signalling establishment success rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccS1SigEstabSuccRate"></see></summary>
    let AccS1SigEstabSuccRate = _prefix "AccS1SigEstabSuccRate"
    /// <summary>
    /// The rate of change of the velocity of a particle with respect to time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Acceleration"></see></summary>
    let Acceleration = _prefix "Acceleration"
    /// <summary>
    /// The acceleration at a given instant of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccelerationInstantaneous"></see></summary>
    let AccelerationInstantaneous = _prefix "AccelerationInstantaneous"
    /// <summary>
    ///  Accelerometers are used to automatically determine the orientation in which the user is holding the IoT Object (portrait or landscape).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Accelerometer"></see></summary>
    let Accelerometer = _prefix "Accelerometer"
    /// <summary>
    /// The product of the voltage across a branch of an alternating-current circuit and the component of the electric current that is in phase with the voltage.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ActivePower"></see></summary>
    let ActivePower = _prefix "ActivePower"
    /// <summary>
    /// It is the rate, per unit time, at which electrical energy is transferred by an electric circuit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Power"></see></summary>
    let Power = _prefix "Power"
    /// <summary>
    /// Agriculture, Smart farm as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Agriculture"></see></summary>
    let Agriculture = _prefix "Agriculture"
    /// <summary>
    /// Application Domain for example: health, environment, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DomainOfInterest"></see></summary>
    let DomainOfInterest = _prefix "DomainOfInterest"
    /// <summary>
    /// An actuator to automatically switch on/off the air conditioner.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirConditioner"></see></summary>
    let AirConditioner = _prefix "AirConditioner"
    /// <summary>
    /// Sensor used to measure air humidity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirHumiditySensor"></see></summary>
    let AirHumiditySensor = _prefix "AirHumiditySensor"
    /// <summary>
    /// Humidity sensor or hygrometer is an instrument used for measuring the moisture concent in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumiditySensor"></see></summary>
    let HumiditySensor = _prefix "HumiditySensor"
    /// <summary>
    /// Air Pollutant Sensor are devices that detect and monitor the presence of air pollution in the surrounding area (source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollutantSensor"></see></summary>
    let AirPollutantSensor = _prefix "AirPollutantSensor"
    /// <summary>
    /// Usually measured using Air Quality Index (AQI), it is the measure of Air Pollution in the environment. It is similar to Air Quality.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollution"></see></summary>
    let AirPollution = _prefix "AirPollution"
    /// <summary>
    /// Usually measured using an air quality index (AQI) that is a number used by government agencies to communicate to the public how polluted the air currently is or how polluted it is forecast to become. Different countries have their own air quality indices, corresponding to different national air quality standards. It is the measure of Air Quality of the environment. It is similar to Air Pollution. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirQuality"></see></summary>
    let AirQuality = _prefix "AirQuality"
    /// <summary>
    /// The temperature of the air that would be indicated by a thermometer exposed to the air at a location sheltered from direct solar radiation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirTemperature"></see></summary>
    let AirTemperature = _prefix "AirTemperature"
    /// <summary>
    /// It is the air temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Temperature"></see></summary>
    let Temperature = _prefix "Temperature"
    /// <summary>
    /// Device to measure the Air temperature of either indoor or outdoor atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirThermometer"></see></summary>
    let AirThermometer = _prefix "AirThermometer"
    /// <summary>
    /// A device to measure the temperature in a room or outside.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Thermometer"></see></summary>
    let Thermometer = _prefix "Thermometer"
    /// <summary>
    /// An actuator to automatically switch on/off the alarm system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlarmSystem"></see></summary>
    let AlarmSystem = _prefix "AlarmSystem"
    /// <summary>
    /// Measure of Alcohol Level in the system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevel"></see></summary>
    let AlcoholLevel = _prefix "AlcoholLevel"
    /// <summary>
    /// Device used to detect and measure Alcohol Level in the system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevelSensor"></see></summary>
    let AlcoholLevelSensor = _prefix "AlcoholLevelSensor"
    /// <summary>
    /// The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ampere"></see></summary>
    let Ampere = _prefix "Ampere"
    /// <summary>
    /// It is the rate of change of angular displacement and is a vector quantity (more precisely, a pseudovector) that specifies the angular speed (rotational speed) of an object and the axis about which the object is rotating. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AngularSpeed"></see></summary>
    let AngularSpeed = _prefix "AngularSpeed"
    /// <summary>
    /// when the source of the sound were animals.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Animals"></see></summary>
    let Animals = _prefix "Animals"
    /// <summary>
    /// Source where the sound originated.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSource"></see></summary>
    let SoundSource = _prefix "SoundSource"
    /// <summary>
    /// The pressure exerted by the atmosphere as a consequence of gravitational attraction exerted upon the column of air lying directly above the point in question.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressure"></see></summary>
    let AtmosphericPressure = _prefix "AtmosphericPressure"
    /// <summary>
    /// It is the physical force exerted on or against an object by something in contact with it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pressure"></see></summary>
    let Pressure = _prefix "Pressure"
    /// <summary>
    /// Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used in meteorology to measure atmospheric pressure.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressureSensor"></see></summary>
    let AtmosphericPressureSensor = _prefix "AtmosphericPressureSensor"
    /// <summary>
    /// When the devices are set to take the observations Automatically without any external aid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#AutomaticSensing"></see></summary>
    let AutomaticSensing = _prefix "AutomaticSensing"
    /// <summary>
    /// Type of Measurement done using a device.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeasurementType"></see></summary>
    let MeasurementType = _prefix "MeasurementType"
    /// <summary>
    /// When the quality of observation is bad
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bad"></see></summary>
    let Bad = _prefix "Bad"
    /// <summary>
    /// It identifies the quality of observation taken by a sensor or an actuator
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#QualityOfObservation"></see></summary>
    let QualityOfObservation = _prefix "QualityOfObservation"
    /// <summary>
    /// Metric unit of atmospheric pressure equal to 14.50 pounds per square inch (lb/in2), 1.02 kilograms per square centimetre (kg/cm2), 29.53 inches of mercury (in Hg), or 0.9869 atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bar"></see></summary>
    let Bar = _prefix "Bar"
    /// <summary>
    /// A tagging device can be Barcode.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Barcode"></see></summary>
    let Barcode = _prefix "Barcode"
    /// <summary>
    /// Measure of the percentage of the battery capacity that remains available.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BatteryLevel"></see></summary>
    let BatteryLevel = _prefix "BatteryLevel"
    /// <summary>
    /// Beat Per Minute (bpm) is the unit to measure heart rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BeatPerMinute"></see></summary>
    let BeatPerMinute = _prefix "BeatPerMinute"
    /// <summary>
    /// An actuator to automatically switch on/off the window blinds.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Blind"></see></summary>
    let Blind = _prefix "Blind"
    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodCoagulation"></see>
    /// </summary>
    let BloodCoagulation = _prefix "BloodCoagulation"
    /// <summary>
    /// Measure of Blood glucose level or blood sugar level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodGlucose"></see></summary>
    let BloodGlucose = _prefix "BloodGlucose"
    /// <summary>
    /// Measure of the pressure in your blood vessels when your heart rests between beats.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressure"></see></summary>
    let BloodPressure = _prefix "BloodPressure"
    /// <summary>
    /// Device used to measure Blood Pressure.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressureSensor"></see></summary>
    let BloodPressureSensor = _prefix "BloodPressureSensor"
    /// <summary>
    /// Measure of board temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardTemperature"></see></summary>
    let BoardTemperature = _prefix "BoardTemperature"
    /// <summary>
    /// Device used to measure board temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardThermometer"></see></summary>
    let BoardThermometer = _prefix "BoardThermometer"
    /// <summary>
    /// Sensor used to measure board input voltage.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardVoltageSensor"></see></summary>
    let BoardVoltageSensor = _prefix "BoardVoltageSensor"
    /// <summary>
    /// Device which can measure the difference in electric potential energy between two points per unit electric charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltageSensor"></see></summary>
    let VoltageSensor = _prefix "VoltageSensor"
    /// <summary>
    /// Measure of body temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyTemperature"></see></summary>
    let BodyTemperature = _prefix "BodyTemperature"
    /// <summary>
    /// Device used to measure body temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyThermometer"></see></summary>
    let BodyThermometer = _prefix "BodyThermometer"
    /// <summary>
    /// An actuator to automatically switch on/off the boiler.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Boiler"></see></summary>
    let Boiler = _prefix "Boiler"
    /// <summary>
    /// Smart Home/Building Automation as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingAutomation"></see></summary>
    let BuildingAutomation = _prefix "BuildingAutomation"
    /// <summary>
    /// Measure of building or room temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingTemperature"></see></summary>
    let BuildingTemperature = _prefix "BuildingTemperature"
    /// <summary>
    /// A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bus"></see></summary>
    let Bus = _prefix "Bus"
    /// <summary>
    /// Carbon Dioxide (CO2) measure in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2"></see></summary>
    let CO2 = _prefix "CO2"
    /// <summary>
    /// Carbon Dioxide (CO2) Sensor used to measure level of CO2 in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2Sensor"></see></summary>
    let CO2Sensor = _prefix "CO2Sensor"
    /// <summary>
    /// Device used to detect poisonous gaseous in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GaseousPollutantSensor"></see></summary>
    let GaseousPollutantSensor = _prefix "GaseousPollutantSensor"
    /// <summary>
    /// Device to detect Carbon Monoxide (CO) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#COSensor"></see></summary>
    let COSensor = _prefix "COSensor"
    /// <summary>
    /// Measure of blood calcium level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Calcium"></see></summary>
    let Calcium = _prefix "Calcium"
    /// <summary>
    /// Purpose of calculating energy consumption by a resource.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalculateEnergyConsumption"></see></summary>
    let CalculateEnergyConsumption = _prefix "CalculateEnergyConsumption"
    /// <summary>
    /// If the measurement was taken when the sensor was being calibrated.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalibrationSensing"></see></summary>
    let CalibrationSensing = _prefix "CalibrationSensing"
    /// <summary>
    /// Candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 10^12 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Candela"></see></summary>
    let Candela = _prefix "Candela"
    /// <summary>
    /// Measure of the ability of a system to store an electric charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Capacitance"></see></summary>
    let Capacitance = _prefix "Capacitance"
    /// <summary>
    /// The centibar is a unit of pressure defined as 1e-2 bar.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centibar"></see></summary>
    let Centibar = _prefix "Centibar"
    /// <summary>
    /// A metric unit of length, equal to one hundredth of a metre.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centimetre"></see></summary>
    let Centimetre = _prefix "Centimetre"
    /// <summary>
    /// It is the unit of length.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Metre"></see></summary>
    let Metre = _prefix "Metre"

    /// <summary>
    /// Measure of Chemical Agent Atmospheric Concentration
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentration"></see></summary>
    let ChemicalAgentAtmosphericConcentration =
        _prefix "ChemicalAgentAtmosphericConcentration"

    /// <summary>
    /// Measure of Chemical Agent Concentration
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentConcentration"></see></summary>
    let ChemicalAgentConcentration = _prefix "ChemicalAgentConcentration"

    /// <summary>
    /// Measure of the concentration of chemical particles suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationAirParticles"></see></summary>
    let ChemicalAgentAtmosphericConcentrationAirParticles =
        _prefix "ChemicalAgentAtmosphericConcentrationAirParticles"

    /// <summary>
    /// Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationCO"></see></summary>
    let ChemicalAgentAtmosphericConcentrationCO =
        _prefix "ChemicalAgentAtmosphericConcentrationCO"

    /// <summary>
    /// Measure of the concentration of dust suspended in the air.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationDust"></see></summary>
    let ChemicalAgentAtmosphericConcentrationDust =
        _prefix "ChemicalAgentAtmosphericConcentrationDust"

    /// <summary>
    /// Measure of the concentration of Ammonia (NH3) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNH3"></see></summary>
    let ChemicalAgentAtmosphericConcentrationNH3 =
        _prefix "ChemicalAgentAtmosphericConcentrationNH3"

    /// <summary>
    /// Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO"></see></summary>
    let ChemicalAgentAtmosphericConcentrationNO =
        _prefix "ChemicalAgentAtmosphericConcentrationNO"

    /// <summary>
    /// Measure of the concentration of NO2 gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO2"></see></summary>
    let ChemicalAgentAtmosphericConcentrationNO2 =
        _prefix "ChemicalAgentAtmosphericConcentrationNO2"

    /// <summary>
    /// The concentration of ozone (O3) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationO3"></see></summary>
    let ChemicalAgentAtmosphericConcentrationO3 =
        _prefix "ChemicalAgentAtmosphericConcentrationO3"

    /// <summary>
    /// Measure of the concentration of Sulphur dioxide (SO2) gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationSO2"></see></summary>
    let ChemicalAgentAtmosphericConcentrationSO2 =
        _prefix "ChemicalAgentAtmosphericConcentrationSO2"

    /// <summary>
    /// Measure of the concentration of Volatile Organic Compound gas suspended in the atmosphere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationVOC"></see></summary>
    let ChemicalAgentAtmosphericConcentrationVOC =
        _prefix "ChemicalAgentAtmosphericConcentrationVOC"

    /// <summary>
    /// Measure of Chemical Agent Concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentration"></see></summary>
    let ChemicalAgentWaterConcentration = _prefix "ChemicalAgentWaterConcentration"

    /// <summary>
    /// Measure of NH4 ion concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNH4Ion"></see></summary>
    let ChemicalAgentWaterConcentrationNH4Ion =
        _prefix "ChemicalAgentWaterConcentrationNH4Ion"

    /// <summary>
    /// Measure of NO3 ion concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNO3Ion"></see></summary>
    let ChemicalAgentWaterConcentrationNO3Ion =
        _prefix "ChemicalAgentWaterConcentrationNO3Ion"

    /// <summary>
    /// Measure of O2 concentration in Water
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationO2"></see></summary>
    let ChemicalAgentWaterConcentrationO2 = _prefix "ChemicalAgentWaterConcentrationO2"
    /// <summary>
    /// Measure of the cholesterol level in a system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cholesterol"></see></summary>
    let Cholesterol = _prefix "Cholesterol"
    /// <summary>
    /// Device used to measure the cholesterol level in a system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CholesterolSensor"></see></summary>
    let CholesterolSensor = _prefix "CholesterolSensor"
    /// <summary>
    /// Smart City as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// sensor that measures time
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Clock"></see></summary>
    let Clock = _prefix "Clock"
    /// <summary>
    /// Measure of cloud cover at a certain time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCover"></see></summary>
    let CloudCover = _prefix "CloudCover"
    /// <summary>
    /// Cloud Cover Sensor is used to detect whether it is sunny, cloudy, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCoverSensor"></see></summary>
    let CloudCoverSensor = _prefix "CloudCoverSensor"
    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coagulometer"></see>
    /// </summary>
    let Coagulometer = _prefix "Coagulometer"
    /// <summary>
    /// An actuator to automatically switch on/off the coffee machine.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CoffeeMachine"></see></summary>
    let CoffeeMachine = _prefix "CoffeeMachine"
    /// <summary>
    /// Actuating devices for Computer or PC.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Computer"></see></summary>
    let Computer = _prefix "Computer"
    /// <summary>
    /// Measure of ability to conduct electricity. It is measured in siemens per metre (S/m).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Conductivity"></see></summary>
    let Conductivity = _prefix "Conductivity"
    /// <summary>
    /// Device used to measure the conductivity of a system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConductivitySensor"></see></summary>
    let ConductivitySensor = _prefix "ConductivitySensor"
    /// <summary>
    /// When the source of the sound was a construction work.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConstructionWork"></see></summary>
    let ConstructionWork = _prefix "ConstructionWork"
    /// <summary>
    /// Triples for location in the (Latitude, Longitude, Altitude) format.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coordinates"></see></summary>
    let Coordinates = _prefix "Coordinates"
    /// <summary>
    /// SI unit of electric charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coulomb"></see></summary>
    let Coulomb = _prefix "Coulomb"
    /// <summary>
    /// Number of available particular things.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Count"></see></summary>
    let Count = _prefix "Count"
    /// <summary>
    /// Number of available bicycles at a particular bicycle docking station.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableBicycles"></see></summary>
    let CountAvailableBicycles = _prefix "CountAvailableBicycles"
    /// <summary>
    /// Number of taxis available at a particular taxi stop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableTaxis"></see></summary>
    let CountAvailableTaxis = _prefix "CountAvailableTaxis"
    /// <summary>
    /// Number of empty docking points at a particular bicycle docking station.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountEmptyDockingPoints"></see></summary>
    let CountEmptyDockingPoints = _prefix "CountEmptyDockingPoints"
    /// <summary>
    /// Number of people within a particular area
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeople"></see></summary>
    let CountPeople = _prefix "CountPeople"
    /// <summary>
    /// Number of people that moved outside an area towards another area during a time window.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleMoving"></see></summary>
    let CountPeopleMoving = _prefix "CountPeopleMoving"
    /// <summary>
    /// Number of people that stayed within an area for more than a threshold of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleStaying"></see></summary>
    let CountPeopleStaying = _prefix "CountPeopleStaying"
    /// <summary>
    /// Count of satellites from which a signal is received
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountStatellitesSignalReceived"></see></summary>
    let CountStatellitesSignalReceived = _prefix "CountStatellitesSignalReceived"
    /// <summary>
    /// Sensors that reckons occurrences or repetitions of physical objects, phenomena or events.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Counter"></see></summary>
    let Counter = _prefix "Counter"
    /// <summary>
    /// When the source of the sound was crowd.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Crowd"></see></summary>
    let Crowd = _prefix "Crowd"
    /// <summary>
    /// An actuator to automatically open/close the cupboard.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cupboard"></see></summary>
    let Cupboard = _prefix "Cupboard"
    /// <summary>
    /// A current sensor is a device that detects electric current in a wire, and generates a signal proportional to that current.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#CurrentSensor"></see></summary>
    let CurrentSensor = _prefix "CurrentSensor"
    /// <summary>
    /// An actuator to automatically open/close the curtain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Curtain"></see></summary>
    let Curtain = _prefix "Curtain"
    /// <summary>
    /// Day is a unit of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Day"></see></summary>
    let Day = _prefix "Day"
    /// <summary>
    /// Qualitatively defined as the second division of the hour by sixty, the first division by sixty being the minute. SI definition of second is "the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium 133 atom.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondTime"></see></summary>
    let SecondTime = _prefix "SecondTime"
    /// <summary>
    /// Decibel is a logarithmic unit used to express the ratio of two values of a physical quantity. It is often used to measure sound level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Decibel"></see></summary>
    let Decibel = _prefix "Decibel"
    /// <summary>
    /// Sound pressure sensed by the human ear.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelA"></see></summary>
    let DecibelA = _prefix "DecibelA"
    /// <summary>
    /// It describes power ratio in decibels of the measured power referenced to one milliwatt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelMilliwatt"></see></summary>
    let DecibelMilliwatt = _prefix "DecibelMilliwatt"
    /// <summary>
    /// Degree.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Degree"></see></summary>
    let Degree = _prefix "Degree"
    /// <summary>
    /// A plane angle unit which is equal to 1/360 of a full rotation or pi/180 rad.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeAngle"></see></summary>
    let DegreeAngle = _prefix "DegreeAngle"
    /// <summary>
    /// A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeCelsius"></see></summary>
    let DegreeCelsius = _prefix "DegreeCelsius"
    /// <summary>
    /// Measurement Unit to represent temperature on the Fahrenheit scale.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeFahrenheit"></see></summary>
    let DegreeFahrenheit = _prefix "DegreeFahrenheit"
    /// <summary>
    /// Difference between Dewpoint and surface temperatures.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPoint"></see></summary>
    let DeltaDewPoint = _prefix "DeltaDewPoint"
    /// <summary>
    /// It is the temperature to which air must be cooled at constant pressure to condense to form liquid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPoint"></see></summary>
    let DewPoint = _prefix "DewPoint"
    /// <summary>
    /// Device that measures the difference between Dewpoint and surface temperatures.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPointSensor"></see></summary>
    let DeltaDewPointSensor = _prefix "DeltaDewPointSensor"
    /// <summary>
    /// Time a device is working and is available
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptime"></see></summary>
    let DeviceUptime = _prefix "DeviceUptime"
    /// <summary>
    /// Sensor that measures time a device is working and is available.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptimeClock"></see></summary>
    let DeviceUptimeClock = _prefix "DeviceUptimeClock"
    /// <summary>
    /// Device that measures dew point.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointSensor"></see></summary>
    let DewPointSensor = _prefix "DewPointSensor"
    /// <summary>
    /// The temperature at which dew forms and is a measure of atmospheric moisture. It is the temperature to which air must be cooled at constant pressure and water content to reach saturation. A higher dew point indicates more moisture in the air; a dew point greater than 20 Degree C (68 Degree F) is considered uncomfortable and greater than 22 Degree C (72 Degree F) is considered to be extremely humid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointTemperature"></see></summary>
    let DewPointTemperature = _prefix "DewPointTemperature"
    /// <summary>
    ///  Measure of the pressure in the arteries when the heart rests between beats.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiastolicBloodPressure"></see></summary>
    let DiastolicBloodPressure = _prefix "DiastolicBloodPressure"
    /// <summary>
    /// Without dimensions; having no appreciable or noteworthy extent. Without physical meaning.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Dimensionless"></see></summary>
    let Dimensionless = _prefix "Dimensionless"
    /// <summary>
    /// Measurements of sensors are affected by the direction of the sensing device. This concept is used to reflect it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Direction"></see></summary>
    let Direction = _prefix "Direction"
    /// <summary>
    /// The geodetic azimuth of the direction towards which an object is point to.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionAzimuth"></see></summary>
    let DirectionAzimuth = _prefix "DirectionAzimuth"
    /// <summary>
    /// The course or direction in which a object (vehicle, person, ...) is moving.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionHeading"></see></summary>
    let DirectionHeading = _prefix "DirectionHeading"
    /// <summary>
    /// The azimuth direction of a  source relative to the azimuth direction of the DOA sensor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrival"></see></summary>
    let DirectionOfArrival = _prefix "DirectionOfArrival"
    /// <summary>
    /// Sensor that estimates the azimuth direction of sources relative to the sensor’s position.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrivalSensor"></see></summary>
    let DirectionOfArrivalSensor = _prefix "DirectionOfArrivalSensor"
    /// <summary>
    /// Action related to finding observsations either of a particular kind or all.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverObservsation"></see></summary>
    let DiscoverObservsation = _prefix "DiscoverObservsation"
    /// <summary>
    /// Discover sensors in a given context
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverSensors"></see></summary>
    let DiscoverSensors = _prefix "DiscoverSensors"
    /// <summary>
    /// An actuator to automatically switch on/off the dishwasher.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DishWasher"></see></summary>
    let DishWasher = _prefix "DishWasher"
    /// <summary>
    /// Measure of how far apart objects are.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Distance"></see></summary>
    let Distance = _prefix "Distance"
    /// <summary>
    /// Estimated driving distance (in meters) between a bus and the next bus stop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBus"></see></summary>
    let DistanceNextBus = _prefix "DistanceNextBus"
    /// <summary>
    ///  Virtual device that represents a bus stop X and a bus line Y; it measures the driving distance between the next bus (belonging to line Y) and the bus stop X.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBusSensor"></see></summary>
    let DistanceNextBusSensor = _prefix "DistanceNextBusSensor"
    /// <summary>
    /// Distance Sensor is used to detect distance between two objects for example:  the safety distance with other cars. Distance sensor can be a laser.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceSensor"></see></summary>
    let DistanceSensor = _prefix "DistanceSensor"
    /// <summary>
    /// An actuator to automatically open/close the door.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Door"></see></summary>
    let Door = _prefix "Door"
    /// <summary>
    /// This sensor detects if a door is in the state of OPEN or CLOSED.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStateSensor"></see></summary>
    let DoorStateSensor = _prefix "DoorStateSensor"
    /// <summary>
    /// Describes if a door is OPEN or CLOSED.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStatus"></see></summary>
    let DoorStatus = _prefix "DoorStatus"
    /// <summary>
    /// An actuator to automatically open/close the drawer.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Drawer"></see></summary>
    let Drawer = _prefix "Drawer"
    /// <summary>
    /// A sensing device that measures dust particle concentration.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#DustSensor"></see></summary>
    let DustSensor = _prefix "DustSensor"
    /// <summary>
    /// Unit to measure Air Quality in European cities.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EAQI"></see></summary>
    let EAQI = _prefix "EAQI"
    /// <summary>
    /// ECG or EKG (Electrocardiogram) device.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ECG"></see></summary>
    let ECG = _prefix "ECG"
    /// <summary>
    /// The actuator for turning ESP on/off.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ESP"></see></summary>
    let ESP = _prefix "ESP"
    /// <summary>
    /// It is the physical property of matter that causes it to experience a force when placed in an electromagnetic field. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCharge"></see></summary>
    let ElectricCharge = _prefix "ElectricCharge"
    /// <summary>
    /// Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time. Electric Current is the flow (movement) of electric charge. The amount of electric current through some surface, e.g., a section through a copper conductor, is defined as the amount of electric charge flowing through that surface over time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCurrent"></see></summary>
    let ElectricCurrent = _prefix "ElectricCurrent"
    /// <summary>
    /// Electric field is the electric force per unit charge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField"></see></summary>
    let ElectricField = _prefix "ElectricField"
    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 1800 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField1800MHz"></see></summary>
    let ElectricField1800MHz = _prefix "ElectricField1800MHz"
    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2100 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2100MHz"></see></summary>
    let ElectricField2100MHz = _prefix "ElectricField2100MHz"
    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2400 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2400MHz"></see></summary>
    let ElectricField2400MHz = _prefix "ElectricField2400MHz"
    /// <summary>
    /// A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 900 MHz UHF band.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField900Mhz"></see></summary>
    let ElectricField900Mhz = _prefix "ElectricField900Mhz"
    /// <summary>
    /// Scientific instrument for measuring electromagnetic fields (EMF). Most of them measure the electromagnetic radiation flux density (DC fields) or the change in an electromagnetic field over time (AC fields).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricFieldSensor"></see></summary>
    let ElectricFieldSensor = _prefix "ElectricFieldSensor"
    /// <summary>
    /// Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricPotential"></see></summary>
    let ElectricPotential = _prefix "ElectricPotential"
    /// <summary>
    /// The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalResistance"></see></summary>
    let ElectricalResistance = _prefix "ElectricalResistance"
    /// <summary>
    /// Sensor that measures the changes in electrical or magnetic signals based on an environmental input.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalSensor"></see></summary>
    let ElectricalSensor = _prefix "ElectricalSensor"
    /// <summary>
    /// Affective Science, Emotion, Mood, Emotional State, Brain Wave as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Emotion"></see></summary>
    let Emotion = _prefix "Emotion"
    /// <summary>
    /// Energy is the property that must be transferred to an object in order to perform work on. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Energy"></see></summary>
    let Energy = _prefix "Energy"
    /// <summary>
    /// Energy or Smart Grid as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyDOI"></see></summary>
    let EnergyDOI = _prefix "EnergyDOI"
    /// <summary>
    /// Sensor to measure power or energy consumption.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyMeter"></see></summary>
    let EnergyMeter = _prefix "EnergyMeter"
    /// <summary>
    /// Purpose for requesting to enter a room.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnterRoom"></see></summary>
    let EnterRoom = _prefix "EnterRoom"
    /// <summary>
    /// Environment (earthquake, flooding, fire, pollution) as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Environment"></see></summary>
    let Environment = _prefix "Environment"
    /// <summary>
    /// Purpose to create a chatbot that could provide environment related knowledge in a userfriendly manner.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalChatbot"></see></summary>
    let EnvironmentalChatbot = _prefix "EnvironmentalChatbot"
    /// <summary>
    /// Purpose to create a dashbord that could provide environment related knowledge to the people.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalDashboard"></see></summary>
    let EnvironmentalDashboard = _prefix "EnvironmentalDashboard"
    /// <summary>
    /// Action related to finding error in the data and correcting them
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ErrorCorrection"></see></summary>
    let ErrorCorrection = _prefix "ErrorCorrection"
    /// <summary>
    /// Experiment based measurements.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Experiment"></see></summary>
    let Experiment = _prefix "Experiment"
    /// <summary>
    /// When the quality of observation is fair
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fair"></see></summary>
    let Fair = _prefix "Fair"
    /// <summary>
    /// Device to detect is a person has fallen.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FallDetector"></see></summary>
    let FallDetector = _prefix "FallDetector"
    /// <summary>
    /// When the source of the sound was Fan.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fan"></see></summary>
    let Fan = _prefix "Fan"
    /// <summary>
    /// SI unit of electrical capacitance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Farad"></see></summary>
    let Farad = _prefix "Farad"
    /// <summary>
    /// Property used to determine the level a certain object such as waste bin is filled upto.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevel"></see></summary>
    let FillLevel = _prefix "FillLevel"
    /// <summary>
    /// Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTank"></see></summary>
    let FillLevelGasTank = _prefix "FillLevelGasTank"
    /// <summary>
    /// Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the primary tank of the vehicle.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankOne"></see></summary>
    let FillLevelGasTankOne = _prefix "FillLevelGasTankOne"
    /// <summary>
    /// Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the secondary tank of the vehicle.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankTwo"></see></summary>
    let FillLevelGasTankTwo = _prefix "FillLevelGasTankTwo"
    /// <summary>
    /// Ratio between the current filleage level and the total capacity of a waste container.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelWasteContainer"></see></summary>
    let FillLevelWasteContainer = _prefix "FillLevelWasteContainer"
    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FloorSensor"></see>
    /// </summary>
    let FloorSensor = _prefix "FloorSensor"
    /// <summary>
    /// The actuator for turning on or off the fog lamp.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FogLamp"></see></summary>
    let FogLamp = _prefix "FogLamp"
    /// <summary>
    /// Measure of temperature of the food.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FoodTemperature"></see></summary>
    let FoodTemperature = _prefix "FoodTemperature"
    /// <summary>
    /// An actuator to automatically open/close the freezer.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Freezer"></see></summary>
    let Freezer = _prefix "Freezer"
    /// <summary>
    /// Frequency is the number of occurrences of a repeating event per unit time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Frequency"></see></summary>
    let Frequency = _prefix "Frequency"
    /// <summary>
    /// Device used to detect the frequency.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FrequencySensor"></see></summary>
    let FrequencySensor = _prefix "FrequencySensor"
    /// <summary>
    /// An actuator to automatically switch on/off the fridge.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fridge"></see></summary>
    let Fridge = _prefix "Fridge"
    /// <summary>
    /// The amount of fuel a vehicle uses to travel a particular distance at a particular speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumption"></see></summary>
    let FuelConsumption = _prefix "FuelConsumption"
    /// <summary>
    /// A measure that displays the instantaneous fuel consumption of a vehicle during its operation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionInstantaneous"></see></summary>
    let FuelConsumptionInstantaneous = _prefix "FuelConsumptionInstantaneous"
    /// <summary>
    /// Accumulated amount of fuel used during vehicle operation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionTotal"></see></summary>
    let FuelConsumptionTotal = _prefix "FuelConsumptionTotal"
    /// <summary>
    /// Device used to detect fuel level in a system such a car.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelLevel"></see></summary>
    let FuelLevel = _prefix "FuelLevel"
    /// <summary>
    /// Device that allows an object to localize itself.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GPSSensor"></see></summary>
    let GPSSensor = _prefix "GPSSensor"
    /// <summary>
    /// Device that detects the presence of gases in an area, often as part of a safety system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GasDetector"></see></summary>
    let GasDetector = _prefix "GasDetector"
    /// <summary>
    /// Gauss is the CGS unit of measurement of magnetic flux density (or magnetic induction) (B) (Source Wikipedia)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gauss"></see></summary>
    let Gauss = _prefix "Gauss"
    /// <summary>
    /// Device used to detect glucometer, blood sugar, blood glucose level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Glucometer"></see></summary>
    let Glucometer = _prefix "Glucometer"
    /// <summary>
    /// When the quality of observation is good
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Good"></see></summary>
    let Good = _prefix "Good"
    /// <summary>
    /// It is a metric system unit of mass
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gram"></see></summary>
    let Gram = _prefix "Gram"
    /// <summary>
    /// It is defined by mass in grams divided by volume in cubic metres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerCubicMetre"></see></summary>
    let GramPerCubicMetre = _prefix "GramPerCubicMetre"
    /// <summary>
    /// It shows how many grams of a certain substance are present in one litre of a usually liquid or gaseous mixture.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerLitre"></see></summary>
    let GramPerLitre = _prefix "GramPerLitre"
    /// <summary>
    /// A gyrometer is an instrument which measures an angular speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyrometerSensor"></see></summary>
    let GyrometerSensor = _prefix "GyrometerSensor"
    /// <summary>
    /// A gyroscope is a device for measuring or maintaining orientation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyroscopeSensor"></see></summary>
    let GyroscopeSensor = _prefix "GyroscopeSensor"
    /// <summary>
    /// Device used to measure of hydrogen sulphide in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#H2SSensor"></see></summary>
    let H2SSensor = _prefix "H2SSensor"
    /// <summary>
    /// Describes the preceision of the GPS signal. Smaller the value is, more precise the signal is.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HDOP"></see></summary>
    let HDOP = _prefix "HDOP"
    /// <summary>
    /// Healthcare as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Health"></see></summary>
    let Health = _prefix "Health"
    /// <summary>
    /// The number of times your heart beats each minute (bpm).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeat"></see></summary>
    let HeartBeat = _prefix "HeartBeat"
    /// <summary>
    /// Device to count heart beats per minute.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeatSensor"></see></summary>
    let HeartBeatSensor = _prefix "HeartBeatSensor"
    /// <summary>
    /// An actuator to automatically switch on/off the heating.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Heating"></see></summary>
    let Heating = _prefix "Heating"
    /// <summary>
    /// The SI unit of frequency, equal to one cycle per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hertz"></see></summary>
    let Hertz = _prefix "Hertz"
    /// <summary>
    /// Hour of the day.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hour"></see></summary>
    let Hour = _prefix "Hour"
    /// <summary>
    /// Measure of Household Appliance Temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HouseholdApplianceTemperature"></see></summary>
    let HouseholdApplianceTemperature = _prefix "HouseholdApplianceTemperature"
    /// <summary>
    /// Device used to detect if an object (vehicle, room, place, etc.) is occupied by Human.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumanPresenceDetector"></see></summary>
    let HumanPresenceDetector = _prefix "HumanPresenceDetector"
    /// <summary>
    /// Device used to detect if on object is occupied or not.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceDetector"></see></summary>
    let PresenceDetector = _prefix "PresenceDetector"
    /// <summary>
    /// A quantity representing the amount of water vapour in the atmosphere or in a gas.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Humidity"></see></summary>
    let Humidity = _prefix "Humidity"
    /// <summary>
    /// A hydrophone is a microphone designed to be used underwater for recording or listening to underwater sound.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hydrophone"></see></summary>
    let Hydrophone = _prefix "Hydrophone"
    /// <summary>
    /// Sensor that measures the power consumption of the IEEE802.15.4 interface nodes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IEEE802154InterfaceEnergyMeter"></see></summary>
    let IEEE802154InterfaceEnergyMeter = _prefix "IEEE802154InterfaceEnergyMeter"
    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#INR"></see>
    /// </summary>
    let INR = _prefix "INR"
    /// <summary>
    /// Purpose to identify if an observation is outlier or not.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IdentifyOutlierObservsations"></see></summary>
    let IdentifyOutlierObservsations = _prefix "IdentifyOutlierObservsations"
    /// <summary>
    /// Illuminance is the total luminous flux incident on a surface, per unit area.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Illuminance"></see></summary>
    let Illuminance = _prefix "Illuminance"
    /// <summary>
    /// Sensor that detects and conveys the information that constitutes an image.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ImageSensor"></see></summary>
    let ImageSensor = _prefix "ImageSensor"
    /// <summary>
    /// Length in inches.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Inch"></see></summary>
    let Inch = _prefix "Inch"
    /// <summary>
    /// Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Index"></see></summary>
    let Index = _prefix "Index"
    /// <summary>
    /// Downlink Latency.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlLatency"></see></summary>
    let IntDlLatency = _prefix "IntDlLatency"
    /// <summary>
    /// Downlink Throughput.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlThroughputKbps"></see></summary>
    let IntDlThroughputKbps = _prefix "IntDlThroughputKbps"
    /// <summary>
    /// Uplink Packet Loss.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlPacketLoss"></see></summary>
    let IntUlPacketLoss = _prefix "IntUlPacketLoss"
    /// <summary>
    /// Uplink Throughput.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlThroughputKbps"></see></summary>
    let IntUlThroughputKbps = _prefix "IntUlThroughputKbps"
    /// <summary>
    /// If the measurement was tagged invalid.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Invalid"></see></summary>
    let Invalid = _prefix "Invalid"
    /// <summary>
    /// Ionising radiation is radiation that carries enough energy to free electrons from atoms or molecules, thereby ionizing them. Gamma rays, X-rays, and the higher ultraviolet part of the electromagnetic spectrum are ionizing, whereas the lower ultraviolet part of the electromagnetic spectrum, and also the lower part of the spectrum below UV, including visible light (including nearly all types of laser light), infrared, microwaves, and radio waves are all considered non-ionizing radiation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#IonisingRadiation"></see></summary>
    let IonisingRadiation = _prefix "IonisingRadiation"
    /// <summary>
    /// An actuator to automatically irrigate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Irrigation"></see></summary>
    let Irrigation = _prefix "Irrigation"
    /// <summary>
    /// Each of the accountable elements within a group.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Item"></see></summary>
    let Item = _prefix "Item"
    /// <summary>
    /// Kelvin is a unit of measurement for temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kelvin"></see></summary>
    let Kelvin = _prefix "Kelvin"
    /// <summary>
    /// Measure of electrical energy equivalent to a power consumption of one thousand watts for one hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KiloWattHour"></see></summary>
    let KiloWattHour = _prefix "KiloWattHour"
    /// <summary>
    /// It is a unit of data transfer rate equal to: 1,000 bits per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilobitsPerSecond"></see></summary>
    let KilobitsPerSecond = _prefix "KilobitsPerSecond"
    /// <summary>
    /// The SI unit of mass, it is equal to the mass of the international prototype of the kilogram.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilogram"></see></summary>
    let Kilogram = _prefix "Kilogram"
    /// <summary>
    /// It is SI derived unit of density, defined by mass in kilograms divided by volume in cubic metres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilogramPerCubicMetre"></see></summary>
    let KilogramPerCubicMetre = _prefix "KilogramPerCubicMetre"
    /// <summary>
    /// A metric unit of measurement equal to 1,000 metres (approx 0.62 miles).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilometre"></see></summary>
    let Kilometre = _prefix "Kilometre"
    /// <summary>
    /// It is a unit of speed, expressing the number of kilometres travelled in one hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilometrePerHour"></see></summary>
    let KilometrePerHour = _prefix "KilometrePerHour"
    /// <summary>
    /// A speed/velocity unit which is equal to the speed of an object traveling 1 metre distance in one second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecond"></see></summary>
    let MetrePerSecond = _prefix "MetrePerSecond"
    /// <summary>
    /// Purpose to know sensors in the given area
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#KnowSensorsInTheArea"></see></summary>
    let KnowSensorsInTheArea = _prefix "KnowSensorsInTheArea"
    /// <summary>
    /// An actuator to automatically switch on/off the lamp.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lamp"></see></summary>
    let Lamp = _prefix "Lamp"
    /// <summary>
    /// An actuator to automatically switch on/off the lavatory.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lavatory"></see></summary>
    let Lavatory = _prefix "Lavatory"
    /// <summary>
    /// Leaf wetness is a meteorological parameter that describes the amount of dew and precipitation left on surfaces. It is used for monitoring leaf moisture for agricultural purposes, such as fungus and disease control, for control of irrigation systems, and for detection of fog and dew conditions, and early detection of rainfall. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetness"></see></summary>
    let LeafWetness = _prefix "LeafWetness"
    /// <summary>
    /// Leaf Wetness Sensor is used in agriculture to check whether the plants need to be watered.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetnessSensor"></see></summary>
    let LeafWetnessSensor = _prefix "LeafWetnessSensor"
    /// <summary>
    /// Light/Illuminance Sensor is used to adjust the brightness of the surface.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LightSensor"></see></summary>
    let LightSensor = _prefix "LightSensor"
    /// <summary>
    /// A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Litre"></see></summary>
    let Litre = _prefix "Litre"
    /// <summary>
    /// A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LitrePer100Kilometres"></see></summary>
    let LitrePer100Kilometres = _prefix "LitrePer100Kilometres"
    /// <summary>
    /// This device is used for long range low power wireless communications. We can use this device to report network metrics (SNR, latence, etc.)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterface"></see></summary>
    let LoRaInterface = _prefix "LoRaInterface"
    /// <summary>
    /// Measure the average power consumption of the LoRa interface nodes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterfaceEnergyMeter"></see></summary>
    let LoRaInterfaceEnergyMeter = _prefix "LoRaInterfaceEnergyMeter"
    /// <summary>
    /// A particular place or position.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LocationQK"></see></summary>
    let LocationQK = _prefix "LocationQK"
    /// <summary>
    /// The SI unit of luminous flux, equal to the amount of light emitted per second in a unit solid angle of one steradian from a uniform source of one candela.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lumen"></see></summary>
    let Lumen = _prefix "Lumen"
    /// <summary>
    /// Luminous Flux is the measure of the perceived power of light.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousFlux"></see></summary>
    let LuminousFlux = _prefix "LuminousFlux"
    /// <summary>
    ///  It is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye. The SI unit of luminous intensity is the candela (cd), an SI base unit. (Source Wikipedia)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousIntensity"></see></summary>
    let LuminousIntensity = _prefix "LuminousIntensity"
    /// <summary>
    /// The SI unit of illuminance, equal to one lumen per square metre.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lux"></see></summary>
    let Lux = _prefix "Lux"
    /// <summary>
    /// A region around a magnetic material or a moving electric charge within which the force of magnetism acts.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticField"></see></summary>
    let MagneticField = _prefix "MagneticField"
    /// <summary>
    /// It is the magnetic flux  through a surface is the surface integral of the normal component of the magnetic field (B) passing through that surface. The SI unit of magnetic flux is the weber (Wb). (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticFluxDensity"></see></summary>
    let MagneticFluxDensity = _prefix "MagneticFluxDensity"
    /// <summary>
    /// A magnetometer is an device that measures magnetism—either magnetization of magnetic material like a ferromagnet, or the strength and, in some cases, direction of the magnetic field at a point in space. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Magnetometer"></see></summary>
    let Magnetometer = _prefix "Magnetometer"
    /// <summary>
    /// If the measurement was taken when human effort was involved.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Manual"></see></summary>
    let Manual = _prefix "Manual"
    /// <summary>
    /// Mass is a property of a physical body. It is the measure of an object's resistance to acceleration when a net force is applied.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mass"></see></summary>
    let Mass = _prefix "Mass"
    /// <summary>
    /// Purpose of meeting a person for a coffee or arranging a meeting
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeetForCoffee"></see></summary>
    let MeetForCoffee = _prefix "MeetForCoffee"
    /// <summary>
    /// Purpose for either arranging a meeting or actually meeting someone.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Meeting"></see></summary>
    let Meeting = _prefix "Meeting"
    /// <summary>
    /// Device used to detect Methane in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MethaneSensor"></see></summary>
    let MethaneSensor = _prefix "MethaneSensor"
    /// <summary>
    /// It is the unit of acceleration (Metre Per Second Square, Meter Per Second Square)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecondSquare"></see></summary>
    let MetrePerSecondSquare = _prefix "MetrePerSecondSquare"
    /// <summary>
    /// It is a unit of electric current, or amount of electric charge per second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microampere"></see></summary>
    let Microampere = _prefix "Microampere"
    /// <summary>
    /// It is a unit of mass equal to one billionth (1×10^−9) of a kilogram.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microgram"></see></summary>
    let Microgram = _prefix "Microgram"
    /// <summary>
    /// Microgram per cubic metre is a unit of density defined as microgram divided by cubic metre. Milligram per cubic metre is a derived unit in the International System of Units.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrogramPerCubicMetre"></see></summary>
    let MicrogramPerCubicMetre = _prefix "MicrogramPerCubicMetre"
    /// <summary>
    /// It is a unit of electromotive force or potential difference equal to one millionth of a volt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microvolt"></see></summary>
    let Microvolt = _prefix "Microvolt"
    /// <summary>
    /// The SI unit of electromotive force, the difference of potential that would carry one ampere of current against one ohm resistance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Volt"></see></summary>
    let Volt = _prefix "Volt"
    /// <summary>
    /// It is a unit of power.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwatt"></see></summary>
    let Microwatt = _prefix "Microwatt"
    /// <summary>
    /// It is the SI unit of power, equivalent to one joule per second, corresponding to the rate of consumption of energy in an electric circuit where the potential difference is one volt and the current one ampere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Watt"></see></summary>
    let Watt = _prefix "Watt"
    /// <summary>
    /// It is one of the unit for radiative and other energy fluxes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrowattPerSquareCentimetre"></see></summary>
    let MicrowattPerSquareCentimetre = _prefix "MicrowattPerSquareCentimetre"
    /// <summary>
    /// It is the SI unit for radiative and other energy fluxes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WattPerSquareMetre"></see></summary>
    let WattPerSquareMetre = _prefix "WattPerSquareMetre"
    /// <summary>
    /// An actuator to automatically switch on/off the Microwave.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwave"></see></summary>
    let Microwave = _prefix "Microwave"
    /// <summary>
    /// Measure of the number of miles or the average distance that a vehicle can travel on a specified quantity of fuel
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mileage"></see></summary>
    let Mileage = _prefix "Mileage"
    /// <summary>
    /// The distance which can be travelled by the vehicle before the next service inspection is required.  A negative distance is transmitted if the service inspection has been passed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageDistanceToService"></see></summary>
    let MileageDistanceToService = _prefix "MileageDistanceToService"
    /// <summary>
    /// The total distance travelled by the particular vehicle since its initial production.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageTotal"></see></summary>
    let MileageTotal = _prefix "MileageTotal"
    /// <summary>
    /// It is a unit of length that is equal to 1,760 yards (approx. 1.609 kilometres).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Miles"></see></summary>
    let Miles = _prefix "Miles"
    /// <summary>
    /// One thousandth of an ampere.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliampere"></see></summary>
    let Milliampere = _prefix "Milliampere"
    /// <summary>
    /// One thousandth of a bar.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millibar"></see></summary>
    let Millibar = _prefix "Millibar"
    /// <summary>
    /// One thousandth of a gram.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milligram"></see></summary>
    let Milligram = _prefix "Milligram"
    /// <summary>
    /// It is a density measurement unit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerCubicMetre"></see></summary>
    let MilligramPerCubicMetre = _prefix "MilligramPerCubicMetre"
    /// <summary>
    /// Level of Dissolved substance in liquid measured in mg per litre.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerLitre"></see></summary>
    let MilligramPerLitre = _prefix "MilligramPerLitre"
    /// <summary>
    /// A dose unit which is equal to 1 milligram of a substance per square metre of surface area of the recipient subject.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerSquareMetre"></see></summary>
    let MilligramPerSquareMetre = _prefix "MilligramPerSquareMetre"
    /// <summary>
    /// One thousandth of a litre (0.002 pint).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millilitre"></see></summary>
    let Millilitre = _prefix "Millilitre"
    /// <summary>
    /// One thousandth of a metre (0.039 in).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millimetre"></see></summary>
    let Millimetre = _prefix "Millimetre"
    /// <summary>
    /// A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimetre travelled per unit hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillimetrePerHour"></see></summary>
    let MillimetrePerHour = _prefix "MillimetrePerHour"
    /// <summary>
    /// One thousandth of a second.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millisecond"></see></summary>
    let Millisecond = _prefix "Millisecond"
    /// <summary>
    /// One thousandth of a volt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millivolt"></see></summary>
    let Millivolt = _prefix "Millivolt"
    /// <summary>
    /// It is a measure of the intensity of the signal of a radio transmitter.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillivoltPerMetre"></see></summary>
    let MillivoltPerMetre = _prefix "MillivoltPerMetre"
    /// <summary>
    /// A unit of power equal to one thousandth of a watt.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliwatt"></see></summary>
    let Milliwatt = _prefix "Milliwatt"
    /// <summary>
    /// A Minute of Angle (MOA) is an angular measurement. A MOA is 1/60th of a degree.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteAngle"></see></summary>
    let MinuteAngle = _prefix "MinuteAngle"
    /// <summary>
    /// A unit of time equal to 60 seconds or 1/60th of an hour.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteTime"></see></summary>
    let MinuteTime = _prefix "MinuteTime"
    /// <summary>
    /// A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmHg"></see></summary>
    let MmHg = _prefix "MmHg"
    /// <summary>
    /// It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLitre is used to measure cholesterol.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmolPerLitre"></see></summary>
    let MmolPerLitre = _prefix "MmolPerLitre"
    /// <summary>
    /// Handover Execution.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoExecSuccRate"></see></summary>
    let MobHoExecSuccRate = _prefix "MobHoExecSuccRate"
    /// <summary>
    /// Handover Preparation Success Rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoPrepSuccRate"></see></summary>
    let MobHoPrepSuccRate = _prefix "MobHoPrepSuccRate"
    /// <summary>
    /// Handover Mobility Success Rate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobMobilitySuccRate"></see></summary>
    let MobMobilitySuccRate = _prefix "MobMobilitySuccRate"
    /// <summary>
    /// Purpose for monitoring temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MonitorTemperature"></see></summary>
    let MonitorTemperature = _prefix "MonitorTemperature"
    /// <summary>
    /// It is the action or process of moving or being moved.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Motion"></see></summary>
    let Motion = _prefix "Motion"
    /// <summary>
    /// Indicator of whether a person (or object) is detected upon his/her/its movement.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionState"></see></summary>
    let MotionState = _prefix "MotionState"
    /// <summary>
    /// Indicates whether motion of the vehicle is detected or not.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionStateVehicle"></see></summary>
    let MotionStateVehicle = _prefix "MotionStateVehicle"
    /// <summary>
    /// A tagging device can be NFC (Near Field Communication).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NFC"></see></summary>
    let NFC = _prefix "NFC"
    /// <summary>
    /// Device used to detect NH3 level in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NH3Sensor"></see></summary>
    let NH3Sensor = _prefix "NH3Sensor"
    /// <summary>
    /// Sensor detecting levels of Nitrogen Dioxide (NO2) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NO2Sensor"></see></summary>
    let NO2Sensor = _prefix "NO2Sensor"
    /// <summary>
    /// Device used to detect Nitrogen Oxide (NO) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#NOSensor"></see></summary>
    let NOSensor = _prefix "NOSensor"
    /// <summary>
    /// When the source of the sound were noisy neighbours.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Neighbours"></see></summary>
    let Neighbours = _prefix "Neighbours"
    /// <summary>
    /// Device used to detect Ozone (O3) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#O3Sensor"></see></summary>
    let O3Sensor = _prefix "O3Sensor"
    /// <summary>
    /// An odometer or odograph is an instrument that indicates distance travelled by a vehicle, such as bicycle or automobile.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Odometer"></see></summary>
    let Odometer = _prefix "Odometer"
    /// <summary>
    /// Ohm is the unit of electrical resistance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ohm"></see></summary>
    let Ohm = _prefix "Ohm"
    /// <summary>
    /// Okta is the unit to measure the cloud cover.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Okta"></see></summary>
    let Okta = _prefix "Okta"
    /// <summary>
    /// Action related to either request for opening the door or actually opening it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpenTheDoor"></see></summary>
    let OpenTheDoor = _prefix "OpenTheDoor"
    /// <summary>
    /// A sensing device that measures dust particle concentration using optical sensing mean.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpticalDustSensor"></see></summary>
    let OpticalDustSensor = _prefix "OpticalDustSensor"
    /// <summary>
    /// Relates to phenomenon and unit that are not available currently in the current version of Taxonomy.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Others"></see></summary>
    let Others = _prefix "Others"
    /// <summary>
    /// Environmental Origin of a particular observation. With respect to one kind of Source (Sound source), it can be coming from traffic, siren of a police car, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Source"></see></summary>
    let Source = _prefix "Source"
    /// <summary>
    /// Measures the Water Oxidation Reduction Potential (ORP) as the tendency of a chemical species to acquire electrons and thereby be reduced.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxidationReductionPotentialSensor"></see></summary>
    let OxidationReductionPotentialSensor = _prefix "OxidationReductionPotentialSensor"
    /// <summary>
    /// Device used to detect Oxygen (O2) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxygenSensor"></see></summary>
    let OxygenSensor = _prefix "OxygenSensor"
    /// <summary>
    /// It is a numeric scale used to specify the acidity or basicity of an aqueous solution.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PH"></see></summary>
    let PH = _prefix "PH"
    /// <summary>
    /// Device used to detect PH level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PHSensor"></see></summary>
    let PHSensor = _prefix "PHSensor"
    /// <summary>
    /// It describes the concentration of something in water or soil.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PPM"></see></summary>
    let PPM = _prefix "PPM"
    /// <summary>
    /// It describes the concentration of something in parts per billion parts of water or soil, expressed in any (but common) unit of measurement.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PartsPerBillion"></see></summary>
    let PartsPerBillion = _prefix "PartsPerBillion"
    /// <summary>
    /// Unit for pressure (e.g., atmospheric pressure).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pascal"></see></summary>
    let Pascal = _prefix "Pascal"
    /// <summary>
    /// Pedometer is used to count the number of steps when walking, running, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pedometer"></see></summary>
    let Pedometer = _prefix "Pedometer"
    /// <summary>
    /// Device used to count the number of people (eg., used within an indoor area).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleCountSensor"></see></summary>
    let PeopleCountSensor = _prefix "PeopleCountSensor"
    /// <summary>
    /// Device used to count the number of people the moves from an area towards another area during a time window.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleFlowCountSensor"></see></summary>
    let PeopleFlowCountSensor = _prefix "PeopleFlowCountSensor"
    /// <summary>
    /// Average time people stays within an area.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationAverage"></see></summary>
    let PeopleStayDurationAverage = _prefix "PeopleStayDurationAverage"
    /// <summary>
    /// Device used to measure the time people stays within an area.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationSensor"></see></summary>
    let PeopleStayDurationSensor = _prefix "PeopleStayDurationSensor"
    /// <summary>
    /// It is the amount in or for every hundred.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Percent"></see></summary>
    let Percent = _prefix "Percent"
    /// <summary>
    /// Location, Place, GPS coordinates as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// It is the measure of Blood Potassium Level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Potassium"></see></summary>
    let Potassium = _prefix "Potassium"
    /// <summary>
    /// A unit of weight equal to 16 oz. 1 pound= 453.592 grams
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pound"></see></summary>
    let Pound = _prefix "Pound"
    /// <summary>
    /// It is any product of the condensation of atmospheric water vapour that falls under gravity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Precipitation"></see></summary>
    let Precipitation = _prefix "Precipitation"
    /// <summary>
    /// It is a device measuring the amount of precipitation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PrecipitationSensor"></see></summary>
    let PrecipitationSensor = _prefix "PrecipitationSensor"
    /// <summary>
    /// Measure to know if an object is present. It is usually boolean.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Presence"></see></summary>
    let Presence = _prefix "Presence"
    /// <summary>
    /// Indicates the presence of the first driver card.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCard"></see></summary>
    let PresenceStateDriverCard = _prefix "PresenceStateDriverCard"
    /// <summary>
    /// Indicates the presence of the first driver card.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardOne"></see></summary>
    let PresenceStateDriverCardOne = _prefix "PresenceStateDriverCardOne"
    /// <summary>
    /// Indicates the presence of the second driver card.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardTwo"></see></summary>
    let PresenceStateDriverCardTwo = _prefix "PresenceStateDriverCardTwo"
    /// <summary>
    /// The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateEmergencyVehicle"></see></summary>
    let PresenceStateEmergencyVehicle = _prefix "PresenceStateEmergencyVehicle"
    /// <summary>
    /// The presence or absence of a vehicle parked.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateParking"></see></summary>
    let PresenceStateParking = _prefix "PresenceStateParking"
    /// <summary>
    /// The presence or absence of people passing.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStatePeople"></see></summary>
    let PresenceStatePeople = _prefix "PresenceStatePeople"
    /// <summary>
    /// A device used to detect pressure. For example, it can be attached on the bed to infer if the user is lying, sleeping, sitting, bed occupancy, etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PressureSensor"></see></summary>
    let PressureSensor = _prefix "PressureSensor"
    /// <summary>
    /// Measure to detect proximity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Proximity"></see></summary>
    let Proximity = _prefix "Proximity"
    /// <summary>
    /// Detect if something is within proximity of a sensor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ProximitySensor"></see></summary>
    let ProximitySensor = _prefix "ProximitySensor"
    /// <summary>
    /// When the source of the sound was public transit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PublicTransit"></see></summary>
    let PublicTransit = _prefix "PublicTransit"
    /// <summary>
    /// Pulse Oxymeter, SpO2, Blood Oxygen Saturation Sensor are used to measure the concentration of oxygen in the blood.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#PulseOxymeter"></see></summary>
    let PulseOxymeter = _prefix "PulseOxymeter"
    /// <summary>
    /// A tagging device can be QRCode.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#QRCode"></see></summary>
    let QRCode = _prefix "QRCode"
    /// <summary>
    /// A tagging device can be RFID.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RFID"></see></summary>
    let RFID = _prefix "RFID"
    /// <summary>
    /// Received Signal Strength Indicator is the signal strength in a wireless network environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RSSI"></see></summary>
    let RSSI = _prefix "RSSI"
    /// <summary>
    /// The radian is a unit of angular measure defined such that an angle of one radian subtended from the centre of a unit circle produces an arc with arc length 1.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Radian"></see></summary>
    let Radian = _prefix "Radian"
    /// <summary>
    /// The radian per second is defined as the change in the orientation of an object, in radians, every second. The radian per second is the SI unit of angular (rotational) speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadianPerSecond"></see></summary>
    let RadianPerSecond = _prefix "RadianPerSecond"
    /// <summary>
    /// A particle detector, also known as a radiation detector or Geiger counter, is a device used to detect, track, and/or identify ionising particles, such as those produced by nuclear decay, cosmic radiation, or reactions in a particle accelerator.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticleDetector"></see></summary>
    let RadiationParticleDetector = _prefix "RadiationParticleDetector"
    /// <summary>
    /// The number of ionizing events detected in one minute.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticlesPerMinute"></see></summary>
    let RadiationParticlesPerMinute = _prefix "RadiationParticlesPerMinute"
    /// <summary>
    /// The depth of precipitation (water-equivalent) that accumulated over a measurement time quantity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Rainfall"></see></summary>
    let Rainfall = _prefix "Rainfall"
    /// <summary>
    /// The portion of electricity that establishes and sustains the electric and magnetic fields of alternating-current equipment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ReactivePower"></see></summary>
    let ReactivePower = _prefix "ReactivePower"
    /// <summary>
    /// Activity Recognized. This is usually made available as a part of analysis done by Google. The available activities recognized are IN_VEHICLE, ON_BICYCLE, ON_FOOT, RUNNING, STILL, TILTING, UNKNOWN, and WALKING.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RecognizedActivity"></see></summary>
    let RecognizedActivity = _prefix "RecognizedActivity"
    /// <summary>
    /// The ratio of vapour pressure to saturation vapour pressure, where vapour pressure is the pressure exerted by the molecules of water vapour and saturation vapour pressure is the pressure exerted by molecules of water vapour in AIR that has attained saturation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RelativeHumidity"></see></summary>
    let RelativeHumidity = _prefix "RelativeHumidity"
    /// <summary>
    /// Connected Users to a communication channel/platform
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ResAverageLicConnectedUsers"></see></summary>
    let ResAverageLicConnectedUsers = _prefix "ResAverageLicConnectedUsers"
    /// <summary>
    /// ERAB Drop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RetERabDrop"></see></summary>
    let RetERabDrop = _prefix "RetERabDrop"
    /// <summary>
    /// Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RevolutionsPerMinute"></see></summary>
    let RevolutionsPerMinute = _prefix "RevolutionsPerMinute"
    /// <summary>
    /// Ratio of time on which a road lane section is occupied by vehicles within a given period of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadOccupancy"></see></summary>
    let RoadOccupancy = _prefix "RoadOccupancy"
    /// <summary>
    /// Device used to measure the road Surface temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadSurfaceThermometer"></see></summary>
    let RoadSurfaceThermometer = _prefix "RoadSurfaceThermometer"
    /// <summary>
    /// Temperature of the road.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadTemperature"></see></summary>
    let RoadTemperature = _prefix "RoadTemperature"
    /// <summary>
    /// When the feature of interest is room
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Room"></see></summary>
    let Room = _prefix "Room"
    /// <summary>
    /// Temperature of a room.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoomTemperature"></see></summary>
    let RoomTemperature = _prefix "RoomTemperature"
    /// <summary>
    /// Rotational speed (or speed of revolution) of an object rotating around an axis is the number of turns of the object divided by time, specified as revolutions per minute (rpm), revolutions per second (rev/s), or radians per second (rad/s). (Source Wikipedia)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeed"></see></summary>
    let RotationalSpeed = _prefix "RotationalSpeed"
    /// <summary>
    /// Rotational speed is a property that is the rate of rotation of a material around an axis, in this case the engine cylinders.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeedEngine"></see></summary>
    let RotationalSpeedEngine = _prefix "RotationalSpeedEngine"
    /// <summary>
    /// Compares the level of a desired signal to the level of noise.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SNR"></see></summary>
    let SNR = _prefix "SNR"
    /// <summary>
    /// Device use to detect Sulphur Dioxide (SO2) level in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SO2Sensor"></see></summary>
    let SO2Sensor = _prefix "SO2Sensor"
    /// <summary>
    /// It is a measure of the amount of oxygenated haemoglobin in the blood.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SPO2"></see></summary>
    let SPO2 = _prefix "SPO2"
    /// <summary>
    /// It is the measure of all the salts dissolved in water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Salinity"></see></summary>
    let Salinity = _prefix "Salinity"
    /// <summary>
    /// Device use to detect salinity of water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SaltMeter"></see></summary>
    let SaltMeter = _prefix "SaltMeter"
    /// <summary>
    /// Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values are part of a continuous variable which can take any numeric value.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Scale"></see></summary>
    let Scale = _prefix "Scale"
    /// <summary>
    ///  Actuator used to turn Seat Belt Tension Actuator on or off.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SeatBeltTensionSensor"></see></summary>
    let SeatBeltTensionSensor = _prefix "SeatBeltTensionSensor"
    /// <summary>
    /// It is a unit of angular measurement equal to 1/60 of one degree.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondAngle"></see></summary>
    let SecondAngle = _prefix "SecondAngle"
    /// <summary>
    /// Seismometers are instruments that measure motions of the ground, including those of seismic waves generated by earthquakes, volcanic eruptions, and other seismic sources.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Seismometer"></see></summary>
    let Seismometer = _prefix "Seismometer"
    /// <summary>
    /// Shake sensor is used to deduce the quality of the road, earthquakes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ShakeSensor"></see></summary>
    let ShakeSensor = _prefix "ShakeSensor"
    /// <summary>
    /// An actuator to automatically switch on/off the shower.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Shower"></see></summary>
    let Shower = _prefix "Shower"
    /// <summary>
    /// Conductivity is measured in Siemens per metre (S/m).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SiemensPerMetre"></see></summary>
    let SiemensPerMetre = _prefix "SiemensPerMetre"
    /// <summary>
    /// An actuator to automatically switch on/off the sink.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sink"></see></summary>
    let Sink = _prefix "Sink"
    /// <summary>
    /// When source of the sound were sirens either from ambulance, police car or factory etc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sirens"></see></summary>
    let Sirens = _prefix "Sirens"
    /// <summary>
    /// Electroderal activity (also known as skin conductance or galvanic skin response) directly correlates to the sympathetic nervous system activity and thus provides a powerful tool for monitoring arousal and certain aspects of autonomic regulation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductance"></see></summary>
    let SkinConductance = _prefix "SkinConductance"
    /// <summary>
    /// Device used to detect Skin Conductance.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductanceSensor"></see></summary>
    let SkinConductanceSensor = _prefix "SkinConductanceSensor"
    /// <summary>
    /// A sleep detector sensor which detects whether the human falls asleep or wakes up.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepDetector"></see></summary>
    let SleepDetector = _prefix "SleepDetector"
    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepSensor"></see>
    /// </summary>
    let SleepSensor = _prefix "SleepSensor"
    /// <summary>
    /// A sleep monitor sensor which tracks the human sleep state.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepMonitor"></see></summary>
    let SleepMonitor = _prefix "SleepMonitor"
    /// <summary>
    ///   <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepState"></see>
    /// </summary>
    let SleepState = _prefix "SleepState"
    /// <summary>
    /// Device used to detect if there is a fire or the smoke.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SmokeDetector"></see></summary>
    let SmokeDetector = _prefix "SmokeDetector"
    /// <summary>
    /// The actuator that turn Snow chains on/off.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SnowChains"></see></summary>
    let SnowChains = _prefix "SnowChains"
    /// <summary>
    /// Measure of Blood Sodium level.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sodium"></see></summary>
    let Sodium = _prefix "Sodium"
    /// <summary>
    /// It is the quantity of water contained in a material, such as soil.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumidity"></see></summary>
    let SoilHumidity = _prefix "SoilHumidity"
    /// <summary>
    /// Soil Humidity sensor, Soil moisture, Hygrometer are an instrument used for measuring the soil moisture or soil humidity.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumiditySensor"></see></summary>
    let SoilHumiditySensor = _prefix "SoilHumiditySensor"
    /// <summary>
    /// The force per unit area required to remove film water from soil.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilMoistureTension"></see></summary>
    let SoilMoistureTension = _prefix "SoilMoistureTension"
    /// <summary>
    /// Soil temperature is the bulk temperature of the soil, not the surface (skin) temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilTemperature"></see></summary>
    let SoilTemperature = _prefix "SoilTemperature"
    /// <summary>
    /// This sensor reports Soil temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilThermometer"></see></summary>
    let SoilThermometer = _prefix "SoilThermometer"
    /// <summary>
    /// It is the power per unit area received from the Sun in the form of electromagnetic radiation in the wavelength range of the measuring instrument. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiation"></see></summary>
    let SolarRadiation = _prefix "SolarRadiation"
    /// <summary>
    /// Device used to detect Solar Radiation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiationSensor"></see></summary>
    let SolarRadiationSensor = _prefix "SolarRadiationSensor"
    /// <summary>
    /// Measure of noise level in the environment
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sound"></see></summary>
    let Sound = _prefix "Sound"
    /// <summary>
    /// Sound pressure level is a logarithmic measure of the RMS sound pressure of a sound relative to a reference value, the threshold of hearing. The reference sound pressure was chosen conventionally to correspond to the quietest sound at 1000 Hz that the human ear can detect (20 uPa). In this case, the specific parameter is measured in an open environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevel"></see></summary>
    let SoundPressureLevel = _prefix "SoundPressureLevel"
    /// <summary>
    /// Similar to Sound.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevelAmbient"></see></summary>
    let SoundPressureLevelAmbient = _prefix "SoundPressureLevelAmbient"
    /// <summary>
    /// Sensor used to detect Noise level. It can be Sound Sensor, Noise level Sensor, Volume sensor, Microphone
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSensor"></see></summary>
    let SoundSensor = _prefix "SoundSensor"
    /// <summary>
    /// The rate at which someone or something moves or operates or is able to move or operate.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Speed"></see></summary>
    let Speed = _prefix "Speed"
    /// <summary>
    /// A measure of the average rate of motion of an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedAverage"></see></summary>
    let SpeedAverage = _prefix "SpeedAverage"
    /// <summary>
    /// A measure of the instantaneous rate of motion of an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedInstantaneous"></see></summary>
    let SpeedInstantaneous = _prefix "SpeedInstantaneous"
    /// <summary>
    /// A measure of the median rate of motion of an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedMedian"></see></summary>
    let SpeedMedian = _prefix "SpeedMedian"
    /// <summary>
    /// Sensor used to detect speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedSensor"></see></summary>
    let SpeedSensor = _prefix "SpeedSensor"
    /// <summary>
    /// Device used to count the number of people that stays within an area for more than a threshold of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#StayingPeopleCountSensor"></see></summary>
    let StayingPeopleCountSensor = _prefix "StayingPeopleCountSensor"
    /// <summary>
    /// It is a measure of number of Step taken.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Step"></see></summary>
    let Step = _prefix "Step"
    /// <summary>
    /// The position of the Sun in the sky is a function of both time and the geographic coordinates of the observer on the surface of the Earth. (Source Wikipedia).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirection"></see></summary>
    let SunPositionDirection = _prefix "SunPositionDirection"
    /// <summary>
    /// Sensor used to detect sun position.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirectionSensor"></see></summary>
    let SunPositionDirectionSensor = _prefix "SunPositionDirectionSensor"
    /// <summary>
    /// It is the altitude of the sun, the angle between the horizon and the centre of the sun's disc.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevation"></see></summary>
    let SunPositionElevation = _prefix "SunPositionElevation"
    /// <summary>
    /// Device used to detect sun elevation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevationSensor"></see></summary>
    let SunPositionElevationSensor = _prefix "SunPositionElevationSensor"
    /// <summary>
    /// It is the pressure when the heart beats while pumping blood.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#SystolicBloodPressure"></see></summary>
    let SystolicBloodPressure = _prefix "SystolicBloodPressure"
    /// <summary>
    /// An actuator to automatically switch on/off the television.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TV"></see></summary>
    let TV = _prefix "TV"
    /// <summary>
    /// An actuator to automatically switch on/off the Telephone.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Telephone"></see></summary>
    let Telephone = _prefix "Telephone"
    /// <summary>
    /// The temperature of a vehicle engine.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureEngine"></see></summary>
    let TemperatureEngine = _prefix "TemperatureEngine"
    /// <summary>
    /// The temperature of the air that would be indicated by a thermometer exposed to the air inside a waste container.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureWasteContainer"></see></summary>
    let TemperatureWasteContainer = _prefix "TemperatureWasteContainer"
    /// <summary>
    /// It is the SI unit of magnetic flux density.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tesla"></see></summary>
    let Tesla = _prefix "Tesla"
    /// <summary>
    /// It is a device used to monitor the throttle position of a vehicle.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#ThrottleSensor"></see></summary>
    let ThrottleSensor = _prefix "ThrottleSensor"
    /// <summary>
    /// Estimated time till an object is arriving to a specific location (typically used in transportation).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrival"></see></summary>
    let TimeOfArrival = _prefix "TimeOfArrival"
    /// <summary>
    /// Estimated time (in seconds) till a bus will arrive at a specific bus stop.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBus"></see></summary>
    let TimeOfArrivalNextBus = _prefix "TimeOfArrivalNextBus"
    /// <summary>
    /// Virtual device that represents a bus stop X and a bus line Y; it estimates the remaining time the next bus (belonging to line Y) will arrive at bus stop X.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBusSensor"></see></summary>
    let TimeOfArrivalNextBusSensor = _prefix "TimeOfArrivalNextBusSensor"
    /// <summary>
    /// Virtual device that estimates the remaining time for an object to arrive at a specific location.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalSensor"></see></summary>
    let TimeOfArrivalSensor = _prefix "TimeOfArrivalSensor"
    /// <summary>
    /// Indicator of whether a person (or object) has overpassed a particular time threshold (e.g. maximum number of hours driving, etc.)
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedState"></see></summary>
    let TimeRelatedState = _prefix "TimeRelatedState"
    /// <summary>
    /// Indicator of whether the driver of a vehicle approaches or exceeds his/her working time limits.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriver"></see></summary>
    let TimeRelatedStateDriver = _prefix "TimeRelatedStateDriver"
    /// <summary>
    /// Indicates if the first driver approaches or exceeds working time limits (or other limits).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverOne"></see></summary>
    let TimeRelatedStateDriverOne = _prefix "TimeRelatedStateDriverOne"
    /// <summary>
    /// Indicates if the second driver approaches or exceeds working time limits (or other limits).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverTwo"></see></summary>
    let TimeRelatedStateDriverTwo = _prefix "TimeRelatedStateDriverTwo"
    /// <summary>
    /// Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Timestamp"></see></summary>
    let Timestamp = _prefix "Timestamp"
    /// <summary>
    /// It is a non-SI metric unit of mass equal to 1,000 kilograms.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tonne"></see></summary>
    let Tonne = _prefix "Tonne"
    /// <summary>
    /// Device that captures and records physical touch or embrace on a device and/or object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TouchSensor"></see></summary>
    let TouchSensor = _prefix "TouchSensor"
    /// <summary>
    /// Tourism as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tourism"></see></summary>
    let Tourism = _prefix "Tourism"
    /// <summary>
    /// When the source of the sound was traffic.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Traffic"></see></summary>
    let Traffic = _prefix "Traffic"
    /// <summary>
    /// The intensity of a traffic flow is the number of vehicles passing a cross section of a road in a unit of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#TrafficIntensity"></see></summary>
    let TrafficIntensity = _prefix "TrafficIntensity"
    /// <summary>
    /// Transportation, Smart Car/Vehicle, Intelligent Transport System (ITS) as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Transportation"></see></summary>
    let Transportation = _prefix "Transportation"
    /// <summary>
    /// Ultrasonic sensors are used to deduce human posture in smart home for example.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#UltrasonicSensor"></see></summary>
    let UltrasonicSensor = _prefix "UltrasonicSensor"
    /// <summary>
    /// Sensor that detects levels of Volatile Organic Components (VOC) in the environment.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VOCSensor"></see></summary>
    let VOCSensor = _prefix "VOCSensor"
    /// <summary>
    /// Device used to count the number of vehicles (e.g., used within the Citypulse project).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleCountSensor"></see></summary>
    let VehicleCountSensor = _prefix "VehicleCountSensor"
    /// <summary>
    /// Measure to indicates whether the vehicle is exceeding the legal speed limit.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleOverspeedState"></see></summary>
    let VehicleOverspeedState = _prefix "VehicleOverspeedState"
    /// <summary>
    /// Device used to detect if an vehicle is present at a place.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclePresenceDetector"></see></summary>
    let VehiclePresenceDetector = _prefix "VehiclePresenceDetector"
    /// <summary>
    /// Number of vehicles that traverse a concrete region of the space in one minute.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclesPerMinute"></see></summary>
    let VehiclesPerMinute = _prefix "VehiclesPerMinute"
    /// <summary>
    /// An actuator to automatically open/close the ventilation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ventilation"></see></summary>
    let Ventilation = _prefix "Ventilation"
    /// <summary>
    /// The state of being able to see or be seen.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Visibility"></see></summary>
    let Visibility = _prefix "Visibility"
    /// <summary>
    /// Device used to detect Visibility.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VisibilitySensor"></see></summary>
    let VisibilitySensor = _prefix "VisibilitySensor"
    /// <summary>
    /// A voice command to control a voice controlled system or environment, such as a smart home.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommand"></see></summary>
    let VoiceCommand = _prefix "VoiceCommand"
    /// <summary>
    /// An actuating device called  that allows to semi-control the environment of the Voice Command Sensor.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandController"></see></summary>
    let VoiceCommandController = _prefix "VoiceCommandController"
    /// <summary>
    /// Sensor that uses automatic speech recognition technology to match or reject a recorded voice command according to a specified set of available voice commands.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandSensor"></see></summary>
    let VoiceCommandSensor = _prefix "VoiceCommandSensor"
    /// <summary>
    /// In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltAmpereReactive"></see></summary>
    let VoltAmpereReactive = _prefix "VoltAmpereReactive"
    /// <summary>
    /// An electromotive force or potential difference expressed in volts (Source Google).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Voltage"></see></summary>
    let Voltage = _prefix "Voltage"
    /// <summary>
    /// An actuator to automatically switch on/off the washing machine.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WashingMachine"></see></summary>
    let WashingMachine = _prefix "WashingMachine"
    /// <summary>
    /// Device used to measure the conductivity of water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterConductivitySensor"></see></summary>
    let WaterConductivitySensor = _prefix "WaterConductivitySensor"
    /// <summary>
    /// The height reached by the water in a reservoir, river, storage tank, or similar.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterLevel"></see></summary>
    let WaterLevel = _prefix "WaterLevel"
    /// <summary>
    /// Sensor used to measure NH4 concentration level in the water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNH4IonSensor"></see></summary>
    let WaterNH4IonSensor = _prefix "WaterNH4IonSensor"
    /// <summary>
    /// Sensor used to measure NO3 concentration level in the water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNO3IonSensor"></see></summary>
    let WaterNO3IonSensor = _prefix "WaterNO3IonSensor"
    /// <summary>
    /// Sensor used to measure O2 concentration level in the water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterO2IonSensor"></see></summary>
    let WaterO2IonSensor = _prefix "WaterO2IonSensor"
    /// <summary>
    /// Device used to detect PH level of water.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterPHSensor"></see></summary>
    let WaterPHSensor = _prefix "WaterPHSensor"
    /// <summary>
    /// Sea surface temperature (SST) is the water temperature close to the ocean's surface.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterTemperature"></see></summary>
    let WaterTemperature = _prefix "WaterTemperature"
    /// <summary>
    /// This sensor reports Water temperature.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterThermometer"></see></summary>
    let WaterThermometer = _prefix "WaterThermometer"
    /// <summary>
    /// Weather Forecasting, Meterology as an Internet of Things (IoT) applicative domain.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weather"></see></summary>
    let Weather = _prefix "Weather"
    /// <summary>
    /// Luminosity in the weather
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherLuminosity"></see></summary>
    let WeatherLuminosity = _prefix "WeatherLuminosity"
    /// <summary>
    /// Weather Precipitation.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherPrecipitation"></see></summary>
    let WeatherPrecipitation = _prefix "WeatherPrecipitation"
    /// <summary>
    /// A body's relative mass or the quantity of matter contained by it, giving rise to a downward force; the heaviness of a person or thing.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weight"></see></summary>
    let Weight = _prefix "Weight"
    /// <summary>
    /// Device used to weight an object.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeightSensor"></see></summary>
    let WeightSensor = _prefix "WeightSensor"
    /// <summary>
    /// Measure the average power consumption of the WiFi interface nodes.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WiFiInterfaceEnergyMeter"></see></summary>
    let WiFiInterfaceEnergyMeter = _prefix "WiFiInterfaceEnergyMeter"
    /// <summary>
    /// The cooling effect of wind blowing on a surface.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChill"></see></summary>
    let WindChill = _prefix "WindChill"
    /// <summary>
    /// Device used to detect Wind Chill.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChillSensor"></see></summary>
    let WindChillSensor = _prefix "WindChillSensor"
    /// <summary>
    /// The geodetic azimuth of the direction from which the wind is blowing.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirection"></see></summary>
    let WindDirection = _prefix "WindDirection"
    /// <summary>
    /// Device used to detect wind direction.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirectionSensor"></see></summary>
    let WindDirectionSensor = _prefix "WindDirectionSensor"
    /// <summary>
    /// The ratio of the distance covered by moving air to the time quantity taken to cover it.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeed"></see></summary>
    let WindSpeed = _prefix "WindSpeed"
    /// <summary>
    /// Wind Speed Sensor, Anemometer or Wind Velocity Sensor is used to measure the wind speed.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeedSensor"></see></summary>
    let WindSpeedSensor = _prefix "WindSpeedSensor"
    /// <summary>
    /// An actuator to automatically open/close the window.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Window"></see></summary>
    let Window = _prefix "Window"
    /// <summary>
    /// Indicator of whether a person (or object) is working or not
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingState"></see></summary>
    let WorkingState = _prefix "WorkingState"
    /// <summary>
    /// Indicator of whether the driver of a vehicle is present or not
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriver"></see></summary>
    let WorkingStateDriver = _prefix "WorkingStateDriver"
    /// <summary>
    /// State of work of the first driver as defined in the FMS standard.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverOne"></see></summary>
    let WorkingStateDriverOne = _prefix "WorkingStateDriverOne"
    /// <summary>
    /// State of work of the second driver as defined in the FMS standard.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverTwo"></see></summary>
    let WorkingStateDriverTwo = _prefix "WorkingStateDriverTwo"
    /// <summary>
    /// This unit is used to measure delta dew point. Natural number (W/out unit).
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Wout"></see></summary>
    let Wout = _prefix "Wout"
    /// <summary>
    /// Year as a unit of time.
    /// <see href="http://purl.org/iot/vocab/iot-taxonomy-lite#Year"></see></summary>
    let Year = _prefix "Year"
