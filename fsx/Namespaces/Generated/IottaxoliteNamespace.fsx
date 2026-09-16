#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module iottaxolite =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/iot/vocab/iot-taxonomy-lite#" "iottaxolite"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ABS (Anti-lock Braking System) Actuating Device</para>
    ///   <para>rdfs:comment : The ABS (Anti-lock Braking System) receives information from ABS computer to control the pressure on the breaks, This helps the wheels not to get locked up, it adjust the break pressure and prevents the wheels from locking. (Definition Source Google).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ABS">iottaxolite:ABS</a>
    /// </summary>
    let ABS = _prefixId.prefix "ABS"
    /// <summary>
    ///   <para>rdfs:label : Initial E-RAB Establishment Success Rate</para>
    ///   <para>rdfs:comment : Initial E-UTRAN Radio Access Bearer establishment success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabEstabSuccRate">iottaxolite:AccInitialERabEstabSuccRate</a>
    /// </summary>
    let AccInitialERabEstabSuccRate = _prefixId.prefix "AccInitialERabEstabSuccRate"
    /// <summary>
    ///   <para>rdfs:label : Initial E-RAB Setup Success Rate</para>
    ///   <para>rdfs:comment : Initial E-UTRAN Radio Access Bearer setup success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabSetupSuccRate">iottaxolite:AccInitialERabSetupSuccRate</a>
    /// </summary>
    let AccInitialERabSetupSuccRate = _prefixId.prefix "AccInitialERabSetupSuccRate"
    /// <summary>
    ///   <para>rdfs:label : RRC Connection Setup Success Rate</para>
    ///   <para>rdfs:comment : Radio Resource Control connection setup success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccRrcConnSetupSuccRate">iottaxolite:AccRrcConnSetupSuccRate</a>
    /// </summary>
    let AccRrcConnSetupSuccRate = _prefixId.prefix "AccRrcConnSetupSuccRate"
    /// <summary>
    ///   <para>rdfs:label : S1 Signalling Establishment Success Rate</para>
    ///   <para>rdfs:comment : S1 (S1 standardized interface between eNB and Evolved Packet Core) signalling establishment success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccS1SigEstabSuccRate">iottaxolite:AccS1SigEstabSuccRate</a>
    /// </summary>
    let AccS1SigEstabSuccRate = _prefixId.prefix "AccS1SigEstabSuccRate"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/dim#Acceleration^^xsd:string</para>
    ///   <para>rdfs:label : Acceleration</para>
    ///   <para>rdfs:comment : The rate of change of the velocity of a particle with respect to time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Acceleration">iottaxolite:Acceleration</a>
    /// </summary>
    let Acceleration = _prefixId.prefix "Acceleration"
    /// <summary>
    ///   <para>rdfs:comment : The acceleration at a given instant of time.</para>
    ///   <para>rdfs:label : Instantaneous Acceleration</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccelerationInstantaneous">iottaxolite:AccelerationInstantaneous</a>
    /// </summary>
    let AccelerationInstantaneous = _prefixId.prefix "AccelerationInstantaneous"
    /// <summary>
    ///   <para>rdfs:label : Accelerometer</para>
    ///   <para>rdfs:comment :  Accelerometers are used to automatically determine the orientation in which the user is holding the IoT Object (portrait or landscape).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Accelerometer">iottaxolite:Accelerometer</a>
    /// </summary>
    let Accelerometer = _prefixId.prefix "Accelerometer"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#activePower^^xsd:string</para>
    ///   <para>rdfs:label : Active Power</para>
    ///   <para>rdfs:comment : The product of the voltage across a branch of an alternating-current circuit and the component of the electric current that is in phase with the voltage.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ActivePower">iottaxolite:ActivePower</a>
    /// </summary>
    let ActivePower = _prefixId.prefix "ActivePower"
    /// <summary>
    ///   <para>rdfs:label : Agriculture DOI</para>
    ///   <para>rdfs:comment : Agriculture, Smart farm as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Agriculture">iottaxolite:Agriculture</a>
    /// </summary>
    let Agriculture = _prefixId.prefix "Agriculture"
    /// <summary>
    ///   <para>rdfs:label : Air Conditioner Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the air conditioner.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirConditioner">iottaxolite:AirConditioner</a>
    /// </summary>
    let AirConditioner = _prefixId.prefix "AirConditioner"
    /// <summary>
    ///   <para>rdfs:label : Air Humidity Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure air humidity.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirHumiditySensor">iottaxolite:AirHumiditySensor</a>
    /// </summary>
    let AirHumiditySensor = _prefixId.prefix "AirHumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Air Pollutant Sensor</para>
    ///   <para>rdfs:comment : Air Pollutant Sensor are devices that detect and monitor the presence of air pollution in the surrounding area (source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollutantSensor">iottaxolite:AirPollutantSensor</a>
    /// </summary>
    let AirPollutantSensor = _prefixId.prefix "AirPollutantSensor"
    /// <summary>
    ///   <para>rdfs:label : Air Pollution Quantity Kind</para>
    ///   <para>rdfs:comment : Usually measured using Air Quality Index (AQI), it is the measure of Air Pollution in the environment. It is similar to Air Quality.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollution">iottaxolite:AirPollution</a>
    /// </summary>
    let AirPollution = _prefixId.prefix "AirPollution"
    /// <summary>
    ///   <para>rdfs:label : Air Quality Quantity Kind</para>
    ///   <para>rdfs:comment : Usually measured using an air quality index (AQI) that is a number used by government agencies to communicate to the public how polluted the air currently is or how polluted it is forecast to become. Different countries have their own air quality indices, corresponding to different national air quality standards. It is the measure of Air Quality of the environment. It is similar to Air Pollution. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirQuality">iottaxolite:AirQuality</a>
    /// </summary>
    let AirQuality = _prefixId.prefix "AirQuality"
    /// <summary>
    ///   <para>rdfs:label : Air Temperature, Weather Temperature, Ambient Temperature</para>
    ///   <para>rdfs:comment : The temperature of the air that would be indicated by a thermometer exposed to the air at a location sheltered from direct solar radiation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirTemperature">iottaxolite:AirTemperature</a>
    /// </summary>
    let AirTemperature = _prefixId.prefix "AirTemperature"
    /// <summary>
    ///   <para>rdfs:label : Air Thermometer</para>
    ///   <para>rdfs:comment : Device to measure the Air temperature of either indoor or outdoor atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirThermometer">iottaxolite:AirThermometer</a>
    /// </summary>
    let AirThermometer = _prefixId.prefix "AirThermometer"
    /// <summary>
    ///   <para>rdfs:label : Alarm System Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the alarm system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlarmSystem">iottaxolite:AlarmSystem</a>
    /// </summary>
    let AlarmSystem = _prefixId.prefix "AlarmSystem"
    /// <summary>
    ///   <para>rdfs:label : Alcohol Level Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Alcohol Level in the system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevel">iottaxolite:AlcoholLevel</a>
    /// </summary>
    let AlcoholLevel = _prefixId.prefix "AlcoholLevel"
    /// <summary>
    ///   <para>rdfs:label : Alcohol Level Sensor</para>
    ///   <para>rdfs:comment : Device used to detect and measure Alcohol Level in the system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevelSensor">iottaxolite:AlcoholLevelSensor</a>
    /// </summary>
    let AlcoholLevelSensor = _prefixId.prefix "AlcoholLevelSensor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#ampere^^xsd:string</para>
    ///   <para>rdfs:label : Ampere (A)</para>
    ///   <para>rdfs:comment : The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ampere">iottaxolite:Ampere</a>
    /// </summary>
    let Ampere = _prefixId.prefix "Ampere"
    /// <summary>
    ///   <para>rdfs:label : Angular Speed</para>
    ///   <para>rdfs:comment : It is the rate of change of angular displacement and is a vector quantity (more precisely, a pseudovector) that specifies the angular speed (rotational speed) of an object and the axis about which the object is rotating. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AngularSpeed">iottaxolite:AngularSpeed</a>
    /// </summary>
    let AngularSpeed = _prefixId.prefix "AngularSpeed"
    /// <summary>
    ///   <para>rdfs:label : Animals as Sound Source</para>
    ///   <para>rdfs:comment : when the source of the sound were animals.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Animals">iottaxolite:Animals</a>
    /// </summary>
    let Animals = _prefixId.prefix "Animals"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#atmosphericPressure^^xsd:string</para>
    ///   <para>rdfs:label : Atmospheric Pressure</para>
    ///   <para>rdfs:comment : The pressure exerted by the atmosphere as a consequence of gravitational attraction exerted upon the column of air lying directly above the point in question.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressure">iottaxolite:AtmosphericPressure</a>
    /// </summary>
    let AtmosphericPressure = _prefixId.prefix "AtmosphericPressure"
    /// <summary>
    ///   <para>rdfs:label : Atmospheric Pressure Sensor</para>
    ///   <para>rdfs:comment : Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used in meteorology to measure atmospheric pressure.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressureSensor">iottaxolite:AtmosphericPressureSensor</a>
    /// </summary>
    let AtmosphericPressureSensor = _prefixId.prefix "AtmosphericPressureSensor"
    /// <summary>
    ///   <para>rdfs:label : Automatic Measurement Type</para>
    ///   <para>rdfs:comment : When the devices are set to take the observations Automatically without any external aid.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#AutomaticSensing">iottaxolite:AutomaticSensing</a>
    /// </summary>
    let AutomaticSensing = _prefixId.prefix "AutomaticSensing"
    /// <summary>
    ///   <para>rdfs:label : Bad</para>
    ///   <para>rdfs:comment : When the quality of observation is bad</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bad">iottaxolite:Bad</a>
    /// </summary>
    let Bad = _prefixId.prefix "Bad"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/unit#Bar^^xsd:string</para>
    ///   <para>rdfs:label : Bar</para>
    ///   <para>rdfs:comment : Metric unit of atmospheric pressure equal to 14.50 pounds per square inch (lb/in2), 1.02 kilograms per square centimetre (kg/cm2), 29.53 inches of mercury (in Hg), or 0.9869 atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bar">iottaxolite:Bar</a>
    /// </summary>
    let Bar = _prefixId.prefix "Bar"
    /// <summary>
    ///   <para>rdfs:label : Barcode Tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be Barcode.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Barcode">iottaxolite:Barcode</a>
    /// </summary>
    let Barcode = _prefixId.prefix "Barcode"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.w3.org/2007/uwa/context/deliveryContext.owl#BatteryLevel^^xsd:string</para>
    ///   <para>rdfs:label : Battery Level Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of the percentage of the battery capacity that remains available.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BatteryLevel">iottaxolite:BatteryLevel</a>
    /// </summary>
    let BatteryLevel = _prefixId.prefix "BatteryLevel"
    /// <summary>
    ///   <para>rdfs:label : Beat Per Minute (bpm)</para>
    ///   <para>rdfs:comment : Beat Per Minute (bpm) is the unit to measure heart rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BeatPerMinute">iottaxolite:BeatPerMinute</a>
    /// </summary>
    let BeatPerMinute = _prefixId.prefix "BeatPerMinute"
    /// <summary>
    ///   <para>rdfs:label : Blind Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the window blinds.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Blind">iottaxolite:Blind</a>
    /// </summary>
    let Blind = _prefixId.prefix "Blind"
    /// <summary>
    ///   <para>rdfs:label : Blood Coagulation</para>
    ///   <para>dc11:description : Blood Coagulation is the process by which blood changes from  liquid to gel to form a blood clot. It allows the cessation of blood loss from an injury.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodCoagulation">iottaxolite:BloodCoagulation</a>
    /// </summary>
    let BloodCoagulation = _prefixId.prefix "BloodCoagulation"
    /// <summary>
    ///   <para>rdfs:label : Blood Glucose Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Blood glucose level or blood sugar level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodGlucose">iottaxolite:BloodGlucose</a>
    /// </summary>
    let BloodGlucose = _prefixId.prefix "BloodGlucose"
    /// <summary>
    ///   <para>rdfs:label : Blood Pressure</para>
    ///   <para>rdfs:comment : Measure of the pressure in your blood vessels when your heart rests between beats.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressure">iottaxolite:BloodPressure</a>
    /// </summary>
    let BloodPressure = _prefixId.prefix "BloodPressure"
    /// <summary>
    ///   <para>rdfs:label : Blood Pressure Sensor</para>
    ///   <para>rdfs:comment : Device used to measure Blood Pressure.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressureSensor">iottaxolite:BloodPressureSensor</a>
    /// </summary>
    let BloodPressureSensor = _prefixId.prefix "BloodPressureSensor"
    /// <summary>
    ///   <para>rdfs:label : Board Temperature</para>
    ///   <para>rdfs:comment : Measure of board temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardTemperature">iottaxolite:BoardTemperature</a>
    /// </summary>
    let BoardTemperature = _prefixId.prefix "BoardTemperature"
    /// <summary>
    ///   <para>rdfs:label : Board Thermometer</para>
    ///   <para>rdfs:comment : Device used to measure board temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardThermometer">iottaxolite:BoardThermometer</a>
    /// </summary>
    let BoardThermometer = _prefixId.prefix "BoardThermometer"
    /// <summary>
    ///   <para>rdfs:label : Board Voltage Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure board input voltage.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardVoltageSensor">iottaxolite:BoardVoltageSensor</a>
    /// </summary>
    let BoardVoltageSensor = _prefixId.prefix "BoardVoltageSensor"
    /// <summary>
    ///   <para>rdfs:label : Body Temperature</para>
    ///   <para>rdfs:comment : Measure of body temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyTemperature">iottaxolite:BodyTemperature</a>
    /// </summary>
    let BodyTemperature = _prefixId.prefix "BodyTemperature"
    /// <summary>
    ///   <para>rdfs:label : Body Thermometer</para>
    ///   <para>rdfs:comment : Device used to measure body temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyThermometer">iottaxolite:BodyThermometer</a>
    /// </summary>
    let BodyThermometer = _prefixId.prefix "BodyThermometer"
    /// <summary>
    ///   <para>rdfs:label : Boiler Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the boiler.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Boiler">iottaxolite:Boiler</a>
    /// </summary>
    let Boiler = _prefixId.prefix "Boiler"
    /// <summary>
    ///   <para>rdfs:label : Smart Building DOI</para>
    ///   <para>rdfs:comment : Smart Home/Building Automation as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingAutomation">iottaxolite:BuildingAutomation</a>
    /// </summary>
    let BuildingAutomation = _prefixId.prefix "BuildingAutomation"
    /// <summary>
    ///   <para>rdfs:label : Building/Room Temperature</para>
    ///   <para>rdfs:comment : Measure of building or room temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingTemperature">iottaxolite:BuildingTemperature</a>
    /// </summary>
    let BuildingTemperature = _prefixId.prefix "BuildingTemperature"
    /// <summary>
    ///   <para>rdfs:label : Bus</para>
    ///   <para>rdfs:comment : A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bus">iottaxolite:Bus</a>
    /// </summary>
    let Bus = _prefixId.prefix "Bus"
    /// <summary>
    ///   <para>rdfs:label : Carbon Dioxide (CO2) Quantity Kind</para>
    ///   <para>rdfs:comment : Carbon Dioxide (CO2) measure in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2">iottaxolite:CO2</a>
    /// </summary>
    let CO2 = _prefixId.prefix "CO2"
    /// <summary>
    ///   <para>rdfs:label : Carbon Dioxide (CO2) Sensor</para>
    ///   <para>rdfs:comment : Carbon Dioxide (CO2) Sensor used to measure level of CO2 in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2Sensor">iottaxolite:CO2Sensor</a>
    /// </summary>
    let CO2Sensor = _prefixId.prefix "CO2Sensor"
    /// <summary>
    ///   <para>rdfs:label : Carbon Monoxide (CO) Sensor</para>
    ///   <para>rdfs:comment : Device to detect Carbon Monoxide (CO) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#COSensor">iottaxolite:COSensor</a>
    /// </summary>
    let COSensor = _prefixId.prefix "COSensor"
    /// <summary>
    ///   <para>rdfs:label : Calcium Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of blood calcium level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Calcium">iottaxolite:Calcium</a>
    /// </summary>
    let Calcium = _prefixId.prefix "Calcium"
    /// <summary>
    ///   <para>rdfs:label : Calculate Energy Consumption</para>
    ///   <para>rdfs:comment : Purpose of calculating energy consumption by a resource.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalculateEnergyConsumption">iottaxolite:CalculateEnergyConsumption</a>
    /// </summary>
    let CalculateEnergyConsumption = _prefixId.prefix "CalculateEnergyConsumption"
    /// <summary>
    ///   <para>rdfs:label : Calibration Measurement Type</para>
    ///   <para>rdfs:comment : If the measurement was taken when the sensor was being calibrated.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalibrationSensing">iottaxolite:CalibrationSensing</a>
    /// </summary>
    let CalibrationSensing = _prefixId.prefix "CalibrationSensing"
    /// <summary>
    ///   <para>rdfs:label : Candela</para>
    ///   <para>rdfs:comment : Candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 10^12 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Candela">iottaxolite:Candela</a>
    /// </summary>
    let Candela = _prefixId.prefix "Candela"
    /// <summary>
    ///   <para>rdfs:label : Capacitance</para>
    ///   <para>rdfs:comment : Measure of the ability of a system to store an electric charge.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Capacitance">iottaxolite:Capacitance</a>
    /// </summary>
    let Capacitance = _prefixId.prefix "Capacitance"
    /// <summary>
    ///   <para>rdfs:label : Centibar</para>
    ///   <para>rdfs:comment : The centibar is a unit of pressure defined as 1e-2 bar.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centibar">iottaxolite:Centibar</a>
    /// </summary>
    let Centibar = _prefixId.prefix "Centibar"
    /// <summary>
    ///   <para>rdfs:comment : A metric unit of length, equal to one hundredth of a metre.</para>
    ///   <para>rdfs:label : Centimetre, Centimeter</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centimetre">iottaxolite:Centimetre</a>
    /// </summary>
    let Centimetre = _prefixId.prefix "Centimetre"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Atmospheric Concentration Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Chemical Agent Atmospheric Concentration</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentration">iottaxolite:ChemicalAgentAtmosphericConcentration</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentration = _prefixId.prefix "ChemicalAgentAtmosphericConcentration"

    /// <summary>
    ///   <para>rdfs:label : Air Particles Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of chemical particles suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationAirParticles">iottaxolite:ChemicalAgentAtmosphericConcentrationAirParticles</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationAirParticles = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationAirParticles"

    /// <summary>
    ///   <para>rdfs:label : Carbon Monoxide (CO) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationCO">iottaxolite:ChemicalAgentAtmosphericConcentrationCO</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationCO = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationCO"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Atmospheric Concentration Dust</para>
    ///   <para>rdfs:comment : Measure of the concentration of dust suspended in the air.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationDust">iottaxolite:ChemicalAgentAtmosphericConcentrationDust</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationDust = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationDust"

    /// <summary>
    ///   <para>rdfs:label : Ammonia (NH3) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Ammonia (NH3) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNH3">iottaxolite:ChemicalAgentAtmosphericConcentrationNH3</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationNH3 = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationNH3"

    /// <summary>
    ///   <para>rdfs:label : Nitrogen Monoxide (NO) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO">iottaxolite:ChemicalAgentAtmosphericConcentrationNO</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationNO = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationNO"

    /// <summary>
    ///   <para>rdfs:label : NO2 Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of NO2 gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO2">iottaxolite:ChemicalAgentAtmosphericConcentrationNO2</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationNO2 = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationNO2"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Atmospheric Concentration O3</para>
    ///   <para>rdfs:comment : The concentration of ozone (O3) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationO3">iottaxolite:ChemicalAgentAtmosphericConcentrationO3</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationO3 = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationO3"

    /// <summary>
    ///   <para>rdfs:label : Sulphur dioxide (SO2) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Sulphur dioxide (SO2) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationSO2">iottaxolite:ChemicalAgentAtmosphericConcentrationSO2</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationSO2 = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationSO2"

    /// <summary>
    ///   <para>rdfs:label : Volatile Organic Compound Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Volatile Organic Compound gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationVOC">iottaxolite:ChemicalAgentAtmosphericConcentrationVOC</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationVOC = _prefixId.prefix "ChemicalAgentAtmosphericConcentrationVOC"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Concentration Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Chemical Agent Concentration</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentConcentration">iottaxolite:ChemicalAgentConcentration</a>
    /// </summary>
    let ChemicalAgentConcentration = _prefixId.prefix "ChemicalAgentConcentration"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Water Concentration Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Chemical Agent Concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentration">iottaxolite:ChemicalAgentWaterConcentration</a>
    /// </summary>
    let ChemicalAgentWaterConcentration = _prefixId.prefix "ChemicalAgentWaterConcentration"

    /// <summary>
    ///   <para>rdfs:label : Ammonium ion (NH4+) Chemical Agent Water Concentration</para>
    ///   <para>rdfs:comment : Measure of NH4 ion concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNH4Ion">iottaxolite:ChemicalAgentWaterConcentrationNH4Ion</a>
    /// </summary>
    let ChemicalAgentWaterConcentrationNH4Ion = _prefixId.prefix "ChemicalAgentWaterConcentrationNH4Ion"

    /// <summary>
    ///   <para>rdfs:label : Nitrate Ion (NO3-) Chemical Agent Water Concentration</para>
    ///   <para>rdfs:comment : Measure of NO3 ion concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNO3Ion">iottaxolite:ChemicalAgentWaterConcentrationNO3Ion</a>
    /// </summary>
    let ChemicalAgentWaterConcentrationNO3Ion = _prefixId.prefix "ChemicalAgentWaterConcentrationNO3Ion"

    /// <summary>
    ///   <para>rdfs:label : Oxygen (O2) Chemical Agent Water Concentration</para>
    ///   <para>rdfs:comment : Measure of O2 concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationO2">iottaxolite:ChemicalAgentWaterConcentrationO2</a>
    /// </summary>
    let ChemicalAgentWaterConcentrationO2 = _prefixId.prefix "ChemicalAgentWaterConcentrationO2"

    /// <summary>
    ///   <para>rdfs:label : Cholesterol Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of the cholesterol level in a system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cholesterol">iottaxolite:Cholesterol</a>
    /// </summary>
    let Cholesterol = _prefixId.prefix "Cholesterol"
    /// <summary>
    ///   <para>rdfs:label : Cholesterol Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the cholesterol level in a system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CholesterolSensor">iottaxolite:CholesterolSensor</a>
    /// </summary>
    let CholesterolSensor = _prefixId.prefix "CholesterolSensor"
    /// <summary>
    ///   <para>rdfs:label : Smart City DOI</para>
    ///   <para>rdfs:comment : Smart City as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#City">iottaxolite:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : Clock</para>
    ///   <para>rdfs:comment : sensor that measures time</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Clock">iottaxolite:Clock</a>
    /// </summary>
    let Clock = _prefixId.prefix "Clock"
    /// <summary>
    ///   <para>rdfs:label : Cloud Cover Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of cloud cover at a certain time. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCover">iottaxolite:CloudCover</a>
    /// </summary>
    let CloudCover = _prefixId.prefix "CloudCover"
    /// <summary>
    ///   <para>rdfs:label : Cloud Cover Sensor</para>
    ///   <para>rdfs:comment : Cloud Cover Sensor is used to detect whether it is sunny, cloudy, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCoverSensor">iottaxolite:CloudCoverSensor</a>
    /// </summary>
    let CloudCoverSensor = _prefixId.prefix "CloudCoverSensor"
    /// <summary>
    ///   <para>rdfs:label : Coagulometer^^xsd:string</para>
    ///   <para>dc11:description : Coagulometer is a medical device used for measuring the coagulation of a patient's blood and testing of the hemostasis system.^^xsd:string</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coagulometer">iottaxolite:Coagulometer</a>
    /// </summary>
    let Coagulometer = _prefixId.prefix "Coagulometer"
    /// <summary>
    ///   <para>rdfs:label : Coffee Machine, Coffee Maker Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the coffee machine.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CoffeeMachine">iottaxolite:CoffeeMachine</a>
    /// </summary>
    let CoffeeMachine = _prefixId.prefix "CoffeeMachine"
    /// <summary>
    ///   <para>rdfs:label : Communication</para>
    ///   <para>rdfs:comment : Communication related properties.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Communication">iottaxolite:Communication</a>
    /// </summary>
    let Communication = _prefixId.prefix "Communication"
    /// <summary>
    ///   <para>rdfs:label : Computer, PC Actuating Device</para>
    ///   <para>rdfs:comment : Actuating devices for Computer or PC.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Computer">iottaxolite:Computer</a>
    /// </summary>
    let Computer = _prefixId.prefix "Computer"
    /// <summary>
    ///   <para>rdfs:label : Conductivity</para>
    ///   <para>rdfs:comment : Measure of ability to conduct electricity. It is measured in siemens per metre (S/m).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Conductivity">iottaxolite:Conductivity</a>
    /// </summary>
    let Conductivity = _prefixId.prefix "Conductivity"
    /// <summary>
    ///   <para>rdfs:label : Conductivity Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the conductivity of a system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConductivitySensor">iottaxolite:ConductivitySensor</a>
    /// </summary>
    let ConductivitySensor = _prefixId.prefix "ConductivitySensor"
    /// <summary>
    ///   <para>rdfs:label : Construction Work Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was a construction work.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConstructionWork">iottaxolite:ConstructionWork</a>
    /// </summary>
    let ConstructionWork = _prefixId.prefix "ConstructionWork"
    /// <summary>
    ///   <para>rdfs:label : Coordinates</para>
    ///   <para>rdfs:comment : Triples for location in the (Latitude, Longitude, Altitude) format.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coordinates">iottaxolite:Coordinates</a>
    /// </summary>
    let Coordinates = _prefixId.prefix "Coordinates"
    /// <summary>
    ///   <para>rdfs:label : Coulomb</para>
    ///   <para>rdfs:comment : SI unit of electric charge.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coulomb">iottaxolite:Coulomb</a>
    /// </summary>
    let Coulomb = _prefixId.prefix "Coulomb"
    /// <summary>
    ///   <para>rdfs:label : Count</para>
    ///   <para>rdfs:comment : Number of available particular things.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Count">iottaxolite:Count</a>
    /// </summary>
    let Count = _prefixId.prefix "Count"
    /// <summary>
    ///   <para>rdfs:label : Count Available Bicycles</para>
    ///   <para>rdfs:comment : Number of available bicycles at a particular bicycle docking station.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableBicycles">iottaxolite:CountAvailableBicycles</a>
    /// </summary>
    let CountAvailableBicycles = _prefixId.prefix "CountAvailableBicycles"
    /// <summary>
    ///   <para>rdfs:label : Count Available Taxis</para>
    ///   <para>rdfs:comment : Number of taxis available at a particular taxi stop.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableTaxis">iottaxolite:CountAvailableTaxis</a>
    /// </summary>
    let CountAvailableTaxis = _prefixId.prefix "CountAvailableTaxis"
    /// <summary>
    ///   <para>rdfs:label : Count Empty Docking Points</para>
    ///   <para>rdfs:comment : Number of empty docking points at a particular bicycle docking station.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountEmptyDockingPoints">iottaxolite:CountEmptyDockingPoints</a>
    /// </summary>
    let CountEmptyDockingPoints = _prefixId.prefix "CountEmptyDockingPoints"
    /// <summary>
    ///   <para>rdfs:label : Count People</para>
    ///   <para>rdfs:comment : Number of people within a particular area</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeople">iottaxolite:CountPeople</a>
    /// </summary>
    let CountPeople = _prefixId.prefix "CountPeople"
    /// <summary>
    ///   <para>rdfs:label : Count People Moving</para>
    ///   <para>rdfs:comment : Number of people that moved outside an area towards another area during a time window.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleMoving">iottaxolite:CountPeopleMoving</a>
    /// </summary>
    let CountPeopleMoving = _prefixId.prefix "CountPeopleMoving"
    /// <summary>
    ///   <para>rdfs:label : Count People Staying</para>
    ///   <para>rdfs:comment : Number of people that stayed within an area for more than a threshold of time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleStaying">iottaxolite:CountPeopleStaying</a>
    /// </summary>
    let CountPeopleStaying = _prefixId.prefix "CountPeopleStaying"

    /// <summary>
    ///   <para>rdfs:label : Count Statellites Signal Received</para>
    ///   <para>rdfs:comment : Count of satellites from which a signal is received</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountStatellitesSignalReceived">iottaxolite:CountStatellitesSignalReceived</a>
    /// </summary>
    let CountStatellitesSignalReceived = _prefixId.prefix "CountStatellitesSignalReceived"

    /// <summary>
    ///   <para>rdfs:label : Counter</para>
    ///   <para>rdfs:comment : Sensors that reckons occurrences or repetitions of physical objects, phenomena or events.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Counter">iottaxolite:Counter</a>
    /// </summary>
    let Counter = _prefixId.prefix "Counter"
    /// <summary>
    ///   <para>rdfs:label : Crowd Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was crowd.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Crowd">iottaxolite:Crowd</a>
    /// </summary>
    let Crowd = _prefixId.prefix "Crowd"
    /// <summary>
    ///   <para>rdfs:label : Cupboard Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the cupboard.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cupboard">iottaxolite:Cupboard</a>
    /// </summary>
    let Cupboard = _prefixId.prefix "Cupboard"
    /// <summary>
    ///   <para>rdfs:label : Current Sensor</para>
    ///   <para>rdfs:comment : A current sensor is a device that detects electric current in a wire, and generates a signal proportional to that current.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#CurrentSensor">iottaxolite:CurrentSensor</a>
    /// </summary>
    let CurrentSensor = _prefixId.prefix "CurrentSensor"
    /// <summary>
    ///   <para>rdfs:label : Curtain Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the curtain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Curtain">iottaxolite:Curtain</a>
    /// </summary>
    let Curtain = _prefixId.prefix "Curtain"
    /// <summary>
    ///   <para>rdfs:label : Day</para>
    ///   <para>rdfs:comment : Day is a unit of time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Day">iottaxolite:Day</a>
    /// </summary>
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#decibel^^xsd:string</para>
    ///   <para>rdfs:label : Decibel (dB)</para>
    ///   <para>rdfs:comment : Decibel is a logarithmic unit used to express the ratio of two values of a physical quantity. It is often used to measure sound level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Decibel">iottaxolite:Decibel</a>
    /// </summary>
    let Decibel = _prefixId.prefix "Decibel"
    /// <summary>
    ///   <para>rdfs:label : DecibelA (dB(A))</para>
    ///   <para>rdfs:comment : Sound pressure sensed by the human ear.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelA">iottaxolite:DecibelA</a>
    /// </summary>
    let DecibelA = _prefixId.prefix "DecibelA"
    /// <summary>
    ///   <para>rdfs:label : Decibel Milliwatt</para>
    ///   <para>rdfs:comment : It describes power ratio in decibels of the measured power referenced to one milliwatt.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelMilliwatt">iottaxolite:DecibelMilliwatt</a>
    /// </summary>
    let DecibelMilliwatt = _prefixId.prefix "DecibelMilliwatt"
    /// <summary>
    ///   <para>rdfs:label : Degree</para>
    ///   <para>rdfs:comment : Degree.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Degree">iottaxolite:Degree</a>
    /// </summary>
    let Degree = _prefixId.prefix "Degree"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/unit#DegreeAngle^^xsd:string</para>
    ///   <para>rdfs:label : Degree Angle</para>
    ///   <para>rdfs:comment : A plane angle unit which is equal to 1/360 of a full rotation or pi/180 rad.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeAngle">iottaxolite:DegreeAngle</a>
    /// </summary>
    let DegreeAngle = _prefixId.prefix "DegreeAngle"
    /// <summary>
    ///   <para>rdfs:label : Degree Celsius</para>
    ///   <para>rdfs:comment : A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeCelsius">iottaxolite:DegreeCelsius</a>
    /// </summary>
    let DegreeCelsius = _prefixId.prefix "DegreeCelsius"
    /// <summary>
    ///   <para>rdfs:label : Degree Fahrenheit</para>
    ///   <para>rdfs:comment : Measurement Unit to represent temperature on the Fahrenheit scale.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeFahrenheit">iottaxolite:DegreeFahrenheit</a>
    /// </summary>
    let DegreeFahrenheit = _prefixId.prefix "DegreeFahrenheit"
    /// <summary>
    ///   <para>rdfs:label : Delta Dew Point</para>
    ///   <para>rdfs:comment : Difference between Dewpoint and surface temperatures.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPoint">iottaxolite:DeltaDewPoint</a>
    /// </summary>
    let DeltaDewPoint = _prefixId.prefix "DeltaDewPoint"
    /// <summary>
    ///   <para>rdfs:label : Delta Dew Point Sensor</para>
    ///   <para>rdfs:comment : Device that measures the difference between Dewpoint and surface temperatures.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPointSensor">iottaxolite:DeltaDewPointSensor</a>
    /// </summary>
    let DeltaDewPointSensor = _prefixId.prefix "DeltaDewPointSensor"
    /// <summary>
    ///   <para>rdfs:label : Device Uptime</para>
    ///   <para>rdfs:comment : Time a device is working and is available</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptime">iottaxolite:DeviceUptime</a>
    /// </summary>
    let DeviceUptime = _prefixId.prefix "DeviceUptime"
    /// <summary>
    ///   <para>rdfs:label : Device Uptime Clock</para>
    ///   <para>rdfs:comment : Sensor that measures time a device is working and is available.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptimeClock">iottaxolite:DeviceUptimeClock</a>
    /// </summary>
    let DeviceUptimeClock = _prefixId.prefix "DeviceUptimeClock"
    /// <summary>
    ///   <para>rdfs:label : Dew Point</para>
    ///   <para>rdfs:comment : It is the temperature to which air must be cooled at constant pressure to condense to form liquid.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPoint">iottaxolite:DewPoint</a>
    /// </summary>
    let DewPoint = _prefixId.prefix "DewPoint"
    /// <summary>
    ///   <para>rdfs:label : Dew Point Sensor</para>
    ///   <para>rdfs:comment : Device that measures dew point.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointSensor">iottaxolite:DewPointSensor</a>
    /// </summary>
    let DewPointSensor = _prefixId.prefix "DewPointSensor"
    /// <summary>
    ///   <para>rdfs:label : Dew Point Temperature</para>
    ///   <para>rdfs:comment : The temperature at which dew forms and is a measure of atmospheric moisture. It is the temperature to which air must be cooled at constant pressure and water content to reach saturation. A higher dew point indicates more moisture in the air; a dew point greater than 20 Degree C (68 Degree F) is considered uncomfortable and greater than 22 Degree C (72 Degree F) is considered to be extremely humid.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointTemperature">iottaxolite:DewPointTemperature</a>
    /// </summary>
    let DewPointTemperature = _prefixId.prefix "DewPointTemperature"
    /// <summary>
    ///   <para>rdfs:label : Diastolic Blood Pressure</para>
    ///   <para>rdfs:comment :  Measure of the pressure in the arteries when the heart rests between beats.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiastolicBloodPressure">iottaxolite:DiastolicBloodPressure</a>
    /// </summary>
    let DiastolicBloodPressure = _prefixId.prefix "DiastolicBloodPressure"
    /// <summary>
    ///   <para>rdfs:label : Dimensionless</para>
    ///   <para>rdfs:comment : Without dimensions; having no appreciable or noteworthy extent. Without physical meaning.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Dimensionless">iottaxolite:Dimensionless</a>
    /// </summary>
    let Dimensionless = _prefixId.prefix "Dimensionless"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of sensors are affected by the direction of the sensing device. This concept is used to reflect it.</para>
    ///   <para>rdfs:label : Direction</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Direction">iottaxolite:Direction</a>
    /// </summary>
    let Direction = _prefixId.prefix "Direction"
    /// <summary>
    ///   <para>rdfs:label : Direction Azimuth</para>
    ///   <para>rdfs:comment : The geodetic azimuth of the direction towards which an object is point to.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionAzimuth">iottaxolite:DirectionAzimuth</a>
    /// </summary>
    let DirectionAzimuth = _prefixId.prefix "DirectionAzimuth"
    /// <summary>
    ///   <para>rdfs:label : Direction Heading</para>
    ///   <para>rdfs:comment : The course or direction in which a object (vehicle, person, ...) is moving.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionHeading">iottaxolite:DirectionHeading</a>
    /// </summary>
    let DirectionHeading = _prefixId.prefix "DirectionHeading"
    /// <summary>
    ///   <para>rdfs:label : Direction Of Arrival</para>
    ///   <para>rdfs:comment : The azimuth direction of a  source relative to the azimuth direction of the DOA sensor.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrival">iottaxolite:DirectionOfArrival</a>
    /// </summary>
    let DirectionOfArrival = _prefixId.prefix "DirectionOfArrival"
    /// <summary>
    ///   <para>rdfs:label : Direction Of Arrival (DOA) Sensor</para>
    ///   <para>rdfs:comment : Sensor that estimates the azimuth direction of sources relative to the sensor’s position.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrivalSensor">iottaxolite:DirectionOfArrivalSensor</a>
    /// </summary>
    let DirectionOfArrivalSensor = _prefixId.prefix "DirectionOfArrivalSensor"
    /// <summary>
    ///   <para>rdfs:label : Discover Observsation</para>
    ///   <para>rdfs:comment : Action related to finding observsations either of a particular kind or all.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverObservsation">iottaxolite:DiscoverObservsation</a>
    /// </summary>
    let DiscoverObservsation = _prefixId.prefix "DiscoverObservsation"
    /// <summary>
    ///   <para>rdfs:label : Discover Sensors</para>
    ///   <para>rdfs:comment : Discover sensors in a given context</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverSensors">iottaxolite:DiscoverSensors</a>
    /// </summary>
    let DiscoverSensors = _prefixId.prefix "DiscoverSensors"
    /// <summary>
    ///   <para>rdfs:label : Dish Washer Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the dishwasher.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DishWasher">iottaxolite:DishWasher</a>
    /// </summary>
    let DishWasher = _prefixId.prefix "DishWasher"
    /// <summary>
    ///   <para>rdfs:label : Distance</para>
    ///   <para>rdfs:comment : Measure of how far apart objects are.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Distance">iottaxolite:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    /// <summary>
    ///   <para>rdfs:label : Driving distance between a bus and the next bus stop</para>
    ///   <para>rdfs:comment : Estimated driving distance (in meters) between a bus and the next bus stop. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBus">iottaxolite:DistanceNextBus</a>
    /// </summary>
    let DistanceNextBus = _prefixId.prefix "DistanceNextBus"
    /// <summary>
    ///   <para>rdfs:label : Sensor measuring the driving distance between a bus and the next bus stop</para>
    ///   <para>rdfs:comment :  Virtual device that represents a bus stop X and a bus line Y; it measures the driving distance between the next bus (belonging to line Y) and the bus stop X. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBusSensor">iottaxolite:DistanceNextBusSensor</a>
    /// </summary>
    let DistanceNextBusSensor = _prefixId.prefix "DistanceNextBusSensor"
    /// <summary>
    ///   <para>rdfs:label : Distance Sensor</para>
    ///   <para>rdfs:comment : Distance Sensor is used to detect distance between two objects for example:  the safety distance with other cars. Distance sensor can be a laser.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceSensor">iottaxolite:DistanceSensor</a>
    /// </summary>
    let DistanceSensor = _prefixId.prefix "DistanceSensor"
    /// <summary>
    ///   <para>rdfs:label : Domain Of Interest</para>
    ///   <para>rdfs:comment : Application Domain for example: health, environment, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DomainOfInterest">iottaxolite:DomainOfInterest</a>
    /// </summary>
    let DomainOfInterest = _prefixId.prefix "DomainOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Door Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the door.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Door">iottaxolite:Door</a>
    /// </summary>
    let Door = _prefixId.prefix "Door"
    /// <summary>
    ///   <para>rdfs:label : Door State Sensor</para>
    ///   <para>rdfs:comment : This sensor detects if a door is in the state of OPEN or CLOSED.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStateSensor">iottaxolite:DoorStateSensor</a>
    /// </summary>
    let DoorStateSensor = _prefixId.prefix "DoorStateSensor"
    /// <summary>
    ///   <para>rdfs:label : Door Status</para>
    ///   <para>rdfs:comment : Describes if a door is OPEN or CLOSED.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStatus">iottaxolite:DoorStatus</a>
    /// </summary>
    let DoorStatus = _prefixId.prefix "DoorStatus"
    /// <summary>
    ///   <para>rdfs:label : Drawer Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the drawer.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Drawer">iottaxolite:Drawer</a>
    /// </summary>
    let Drawer = _prefixId.prefix "Drawer"
    /// <summary>
    ///   <para>rdfs:label : Dust Sensor</para>
    ///   <para>rdfs:comment : A sensing device that measures dust particle concentration.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#DustSensor">iottaxolite:DustSensor</a>
    /// </summary>
    let DustSensor = _prefixId.prefix "DustSensor"
    /// <summary>
    ///   <para>rdfs:label : European Air Quality Index (EAQI)</para>
    ///   <para>rdfs:comment : Unit to measure Air Quality in European cities.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#EAQI">iottaxolite:EAQI</a>
    /// </summary>
    let EAQI = _prefixId.prefix "EAQI"
    /// <summary>
    ///   <para>rdfs:label : ECG or EKG (Electrocardiogram)</para>
    ///   <para>rdfs:comment : ECG or EKG (Electrocardiogram) device.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ECG">iottaxolite:ECG</a>
    /// </summary>
    let ECG = _prefixId.prefix "ECG"
    /// <summary>
    ///   <para>rdfs:label : ESP (Electronic Stability Program) Actuating device</para>
    ///   <para>rdfs:comment : The actuator for turning ESP on/off.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ESP">iottaxolite:ESP</a>
    /// </summary>
    let ESP = _prefixId.prefix "ESP"
    /// <summary>
    ///   <para>rdfs:label : Electric Charge</para>
    ///   <para>rdfs:comment : It is the physical property of matter that causes it to experience a force when placed in an electromagnetic field. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCharge">iottaxolite:ElectricCharge</a>
    /// </summary>
    let ElectricCharge = _prefixId.prefix "ElectricCharge"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/quantity#ElectricCurrent^^xsd:string</para>
    ///   <para>rdfs:label : Electric Current</para>
    ///   <para>rdfs:comment : Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time. Electric Current is the flow (movement) of electric charge. The amount of electric current through some surface, e.g., a section through a copper conductor, is defined as the amount of electric charge flowing through that surface over time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCurrent">iottaxolite:ElectricCurrent</a>
    /// </summary>
    let ElectricCurrent = _prefixId.prefix "ElectricCurrent"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/quantity#ElectricField^^xsd:string</para>
    ///   <para>rdfs:comment : Electric field is the electric force per unit charge.</para>
    ///   <para>rdfs:label : Electric Field</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField">iottaxolite:ElectricField</a>
    /// </summary>
    let ElectricField = _prefixId.prefix "ElectricField"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 1800 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 1800 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField1800MHz">iottaxolite:ElectricField1800MHz</a>
    /// </summary>
    let ElectricField1800MHz = _prefixId.prefix "ElectricField1800MHz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 2100 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2100 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2100MHz">iottaxolite:ElectricField2100MHz</a>
    /// </summary>
    let ElectricField2100MHz = _prefixId.prefix "ElectricField2100MHz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 2400 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2400 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2400MHz">iottaxolite:ElectricField2400MHz</a>
    /// </summary>
    let ElectricField2400MHz = _prefixId.prefix "ElectricField2400MHz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 900 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 900 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField900Mhz">iottaxolite:ElectricField900Mhz</a>
    /// </summary>
    let ElectricField900Mhz = _prefixId.prefix "ElectricField900Mhz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field Sensor</para>
    ///   <para>rdfs:comment : Scientific instrument for measuring electromagnetic fields (EMF). Most of them measure the electromagnetic radiation flux density (DC fields) or the change in an electromagnetic field over time (AC fields).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricFieldSensor">iottaxolite:ElectricFieldSensor</a>
    /// </summary>
    let ElectricFieldSensor = _prefixId.prefix "ElectricFieldSensor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/dim#ElectricPotential^^xsd:string</para>
    ///   <para>rdfs:label : Electric Potential</para>
    ///   <para>rdfs:comment : Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricPotential">iottaxolite:ElectricPotential</a>
    /// </summary>
    let ElectricPotential = _prefixId.prefix "ElectricPotential"
    /// <summary>
    ///   <para>rdfs:label : Electrical Resistance</para>
    ///   <para>rdfs:comment : The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalResistance">iottaxolite:ElectricalResistance</a>
    /// </summary>
    let ElectricalResistance = _prefixId.prefix "ElectricalResistance"
    /// <summary>
    ///   <para>rdfs:label : Electrical Sensor</para>
    ///   <para>rdfs:comment : Sensor that measures the changes in electrical or magnetic signals based on an environmental input.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalSensor">iottaxolite:ElectricalSensor</a>
    /// </summary>
    let ElectricalSensor = _prefixId.prefix "ElectricalSensor"
    /// <summary>
    ///   <para>rdfs:label : Emotion DOI</para>
    ///   <para>rdfs:comment : Affective Science, Emotion, Mood, Emotional State, Brain Wave as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Emotion">iottaxolite:Emotion</a>
    /// </summary>
    let Emotion = _prefixId.prefix "Emotion"
    /// <summary>
    ///   <para>rdfs:label : Energy</para>
    ///   <para>rdfs:comment : Energy is the property that must be transferred to an object in order to perform work on. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Energy">iottaxolite:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : Energy DOI</para>
    ///   <para>rdfs:comment : Energy or Smart Grid as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyDOI">iottaxolite:EnergyDOI</a>
    /// </summary>
    let EnergyDOI = _prefixId.prefix "EnergyDOI"
    /// <summary>
    ///   <para>rdfs:label : Energy Meter</para>
    ///   <para>rdfs:comment : Sensor to measure power or energy consumption.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyMeter">iottaxolite:EnergyMeter</a>
    /// </summary>
    let EnergyMeter = _prefixId.prefix "EnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Enter Room</para>
    ///   <para>rdfs:comment : Purpose for requesting to enter a room.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnterRoom">iottaxolite:EnterRoom</a>
    /// </summary>
    let EnterRoom = _prefixId.prefix "EnterRoom"
    /// <summary>
    ///   <para>rdfs:label : Environment DOI</para>
    ///   <para>rdfs:comment : Environment (earthquake, flooding, fire, pollution) as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Environment">iottaxolite:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:label : Environmental Chatbot</para>
    ///   <para>rdfs:comment : Purpose to create a chatbot that could provide environment related knowledge in a userfriendly manner.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalChatbot">iottaxolite:EnvironmentalChatbot</a>
    /// </summary>
    let EnvironmentalChatbot = _prefixId.prefix "EnvironmentalChatbot"
    /// <summary>
    ///   <para>rdfs:label : Environmental Dashboard</para>
    ///   <para>rdfs:comment : Purpose to create a dashbord that could provide environment related knowledge to the people.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalDashboard">iottaxolite:EnvironmentalDashboard</a>
    /// </summary>
    let EnvironmentalDashboard = _prefixId.prefix "EnvironmentalDashboard"
    /// <summary>
    ///   <para>rdfs:label : Error Correction</para>
    ///   <para>rdfs:comment : Action related to finding error in the data and correcting them</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ErrorCorrection">iottaxolite:ErrorCorrection</a>
    /// </summary>
    let ErrorCorrection = _prefixId.prefix "ErrorCorrection"
    /// <summary>
    ///   <para>rdfs:label : Experiment Measurement Type</para>
    ///   <para>rdfs:comment : Experiment based measurements.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Experiment">iottaxolite:Experiment</a>
    /// </summary>
    let Experiment = _prefixId.prefix "Experiment"
    /// <summary>
    ///   <para>rdfs:label : Fair</para>
    ///   <para>rdfs:comment : When the quality of observation is fair</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fair">iottaxolite:Fair</a>
    /// </summary>
    let Fair = _prefixId.prefix "Fair"
    /// <summary>
    ///   <para>rdfs:label : Fall Detector</para>
    ///   <para>rdfs:comment : Device to detect is a person has fallen.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FallDetector">iottaxolite:FallDetector</a>
    /// </summary>
    let FallDetector = _prefixId.prefix "FallDetector"
    /// <summary>
    ///   <para>rdfs:label : Fan Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was Fan.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fan">iottaxolite:Fan</a>
    /// </summary>
    let Fan = _prefixId.prefix "Fan"
    /// <summary>
    ///   <para>rdfs:label : Farad</para>
    ///   <para>rdfs:comment : SI unit of electrical capacitance.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Farad">iottaxolite:Farad</a>
    /// </summary>
    let Farad = _prefixId.prefix "Farad"
    /// <summary>
    ///   <para>rdfs:comment : Property used to determine the level a certain object such as waste bin is filled upto.</para>
    ///   <para>rdfs:label : Fill Level</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevel">iottaxolite:FillLevel</a>
    /// </summary>
    let FillLevel = _prefixId.prefix "FillLevel"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Gas Tank</para>
    ///   <para>rdfs:comment : Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTank">iottaxolite:FillLevelGasTank</a>
    /// </summary>
    let FillLevelGasTank = _prefixId.prefix "FillLevelGasTank"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Gas Tank 1</para>
    ///   <para>rdfs:comment : Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the primary tank of the vehicle.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankOne">iottaxolite:FillLevelGasTankOne</a>
    /// </summary>
    let FillLevelGasTankOne = _prefixId.prefix "FillLevelGasTankOne"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Gas Tank 2</para>
    ///   <para>rdfs:comment : Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the secondary tank of the vehicle.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankTwo">iottaxolite:FillLevelGasTankTwo</a>
    /// </summary>
    let FillLevelGasTankTwo = _prefixId.prefix "FillLevelGasTankTwo"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Waste Container</para>
    ///   <para>rdfs:comment : Ratio between the current filleage level and the total capacity of a waste container.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelWasteContainer">iottaxolite:FillLevelWasteContainer</a>
    /// </summary>
    let FillLevelWasteContainer = _prefixId.prefix "FillLevelWasteContainer"
    /// <summary>
    ///   <para>rdfs:label : FloorSensor</para>
    ///   <para>dc11:description : A floor sensor is a set of sensors covering a floor that can be used for measuring load and proximity. By using this information the floor sensor can be also used for detecting activity in a room^^xsd:string</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FloorSensor">iottaxolite:FloorSensor</a>
    /// </summary>
    let FloorSensor = _prefixId.prefix "FloorSensor"
    /// <summary>
    ///   <para>rdfs:label : Fog Lamp Actuating Device</para>
    ///   <para>rdfs:comment : The actuator for turning on or off the fog lamp.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FogLamp">iottaxolite:FogLamp</a>
    /// </summary>
    let FogLamp = _prefixId.prefix "FogLamp"
    /// <summary>
    ///   <para>rdfs:label : Food Temperature</para>
    ///   <para>rdfs:comment : Measure of temperature of the food.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FoodTemperature">iottaxolite:FoodTemperature</a>
    /// </summary>
    let FoodTemperature = _prefixId.prefix "FoodTemperature"
    /// <summary>
    ///   <para>rdfs:label : Freezer, Chiller Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the freezer.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Freezer">iottaxolite:Freezer</a>
    /// </summary>
    let Freezer = _prefixId.prefix "Freezer"
    /// <summary>
    ///   <para>rdfs:label : Frequency</para>
    ///   <para>rdfs:comment : Frequency is the number of occurrences of a repeating event per unit time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Frequency">iottaxolite:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : Frequency Sensor</para>
    ///   <para>rdfs:comment : Device used to detect the frequency.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FrequencySensor">iottaxolite:FrequencySensor</a>
    /// </summary>
    let FrequencySensor = _prefixId.prefix "FrequencySensor"
    /// <summary>
    ///   <para>rdfs:label : Fridge, Refrigerator Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the fridge.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fridge">iottaxolite:Fridge</a>
    /// </summary>
    let Fridge = _prefixId.prefix "Fridge"
    /// <summary>
    ///   <para>rdfs:comment : The amount of fuel a vehicle uses to travel a particular distance at a particular speed.</para>
    ///   <para>rdfs:label : Fuel Consumption Quantity Kind</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumption">iottaxolite:FuelConsumption</a>
    /// </summary>
    let FuelConsumption = _prefixId.prefix "FuelConsumption"
    /// <summary>
    ///   <para>rdfs:label : Fuel Consumption Instantaneous</para>
    ///   <para>rdfs:comment : A measure that displays the instantaneous fuel consumption of a vehicle during its operation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionInstantaneous">iottaxolite:FuelConsumptionInstantaneous</a>
    /// </summary>
    let FuelConsumptionInstantaneous = _prefixId.prefix "FuelConsumptionInstantaneous"
    /// <summary>
    ///   <para>rdfs:label : Fuel Consumption Total</para>
    ///   <para>rdfs:comment : Accumulated amount of fuel used during vehicle operation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionTotal">iottaxolite:FuelConsumptionTotal</a>
    /// </summary>
    let FuelConsumptionTotal = _prefixId.prefix "FuelConsumptionTotal"
    /// <summary>
    ///   <para>rdfs:label : Fuel Level Sensor</para>
    ///   <para>rdfs:comment : Device used to detect fuel level in a system such a car.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelLevel">iottaxolite:FuelLevel</a>
    /// </summary>
    let FuelLevel = _prefixId.prefix "FuelLevel"
    /// <summary>
    ///   <para>rdfs:label : GPS Sensor</para>
    ///   <para>rdfs:comment : Device that allows an object to localize itself.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GPSSensor">iottaxolite:GPSSensor</a>
    /// </summary>
    let GPSSensor = _prefixId.prefix "GPSSensor"
    /// <summary>
    ///   <para>rdfs:label : Gas Detector</para>
    ///   <para>rdfs:comment : Device that detects the presence of gases in an area, often as part of a safety system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GasDetector">iottaxolite:GasDetector</a>
    /// </summary>
    let GasDetector = _prefixId.prefix "GasDetector"
    /// <summary>
    ///   <para>rdfs:label : Gaseous Pollutant Sensor</para>
    ///   <para>rdfs:comment : Device used to detect poisonous gaseous in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GaseousPollutantSensor">iottaxolite:GaseousPollutantSensor</a>
    /// </summary>
    let GaseousPollutantSensor = _prefixId.prefix "GaseousPollutantSensor"
    /// <summary>
    ///   <para>rdfs:label : Gauss</para>
    ///   <para>rdfs:comment : Gauss is the CGS unit of measurement of magnetic flux density (or magnetic induction) (B) (Source Wikipedia)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gauss">iottaxolite:Gauss</a>
    /// </summary>
    let Gauss = _prefixId.prefix "Gauss"
    /// <summary>
    ///   <para>rdfs:label : Glucometer Sensor</para>
    ///   <para>rdfs:comment : Device used to detect glucometer, blood sugar, blood glucose level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Glucometer">iottaxolite:Glucometer</a>
    /// </summary>
    let Glucometer = _prefixId.prefix "Glucometer"
    /// <summary>
    ///   <para>rdfs:label : Good</para>
    ///   <para>rdfs:comment : When the quality of observation is good</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Good">iottaxolite:Good</a>
    /// </summary>
    let Good = _prefixId.prefix "Good"
    /// <summary>
    ///   <para>rdfs:comment : It is a metric system unit of mass^^xsd:string</para>
    ///   <para>rdfs:label : Gram (g)^^xsd:string</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gram">iottaxolite:Gram</a>
    /// </summary>
    let Gram = _prefixId.prefix "Gram"
    /// <summary>
    ///   <para>rdfs:label : Gram Per Cubic Metre, Gram Per Cubic Meter</para>
    ///   <para>rdfs:comment : It is defined by mass in grams divided by volume in cubic metres.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerCubicMetre">iottaxolite:GramPerCubicMetre</a>
    /// </summary>
    let GramPerCubicMetre = _prefixId.prefix "GramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:label : Gram Per Litre, Gram Per Liter (g/L)</para>
    ///   <para>rdfs:comment : It shows how many grams of a certain substance are present in one litre of a usually liquid or gaseous mixture.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerLitre">iottaxolite:GramPerLitre</a>
    /// </summary>
    let GramPerLitre = _prefixId.prefix "GramPerLitre"
    /// <summary>
    ///   <para>rdfs:label : Gyrometer Sensor</para>
    ///   <para>rdfs:comment : A gyrometer is an instrument which measures an angular speed.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyrometerSensor">iottaxolite:GyrometerSensor</a>
    /// </summary>
    let GyrometerSensor = _prefixId.prefix "GyrometerSensor"
    /// <summary>
    ///   <para>rdfs:label : Gyroscope Sensor</para>
    ///   <para>rdfs:comment : A gyroscope is a device for measuring or maintaining orientation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyroscopeSensor">iottaxolite:GyroscopeSensor</a>
    /// </summary>
    let GyroscopeSensor = _prefixId.prefix "GyroscopeSensor"
    /// <summary>
    ///   <para>rdfs:label : H2S Sensor</para>
    ///   <para>rdfs:comment : Device used to measure of hydrogen sulphide in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#H2SSensor">iottaxolite:H2SSensor</a>
    /// </summary>
    let H2SSensor = _prefixId.prefix "H2SSensor"
    /// <summary>
    ///   <para>rdfs:label : Horizontal Dilution of Precision</para>
    ///   <para>rdfs:comment : Describes the preceision of the GPS signal. Smaller the value is, more precise the signal is.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#HDOP">iottaxolite:HDOP</a>
    /// </summary>
    let HDOP = _prefixId.prefix "HDOP"
    /// <summary>
    ///   <para>rdfs:label : Health Care DOI</para>
    ///   <para>rdfs:comment : Healthcare as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Health">iottaxolite:Health</a>
    /// </summary>
    let Health = _prefixId.prefix "Health"
    /// <summary>
    ///   <para>rdfs:label : Heart Beat</para>
    ///   <para>rdfs:comment : The number of times your heart beats each minute (bpm).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeat">iottaxolite:HeartBeat</a>
    /// </summary>
    let HeartBeat = _prefixId.prefix "HeartBeat"
    /// <summary>
    ///   <para>rdfs:label : Heart Beat Sensor</para>
    ///   <para>rdfs:comment : Device to count heart beats per minute.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeatSensor">iottaxolite:HeartBeatSensor</a>
    /// </summary>
    let HeartBeatSensor = _prefixId.prefix "HeartBeatSensor"
    /// <summary>
    ///   <para>rdfs:label : Heating Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the heating.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Heating">iottaxolite:Heating</a>
    /// </summary>
    let Heating = _prefixId.prefix "Heating"
    /// <summary>
    ///   <para>rdfs:label : Hertz</para>
    ///   <para>rdfs:comment : The SI unit of frequency, equal to one cycle per second.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hertz">iottaxolite:Hertz</a>
    /// </summary>
    let Hertz = _prefixId.prefix "Hertz"
    /// <summary>
    ///   <para>rdfs:label : Hour</para>
    ///   <para>rdfs:comment : Hour of the day.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hour">iottaxolite:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>rdfs:label : Household Appliance Temperature</para>
    ///   <para>rdfs:comment : Measure of Household Appliance Temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#HouseholdApplianceTemperature">iottaxolite:HouseholdApplianceTemperature</a>
    /// </summary>
    let HouseholdApplianceTemperature = _prefixId.prefix "HouseholdApplianceTemperature"
    /// <summary>
    ///   <para>rdfs:label :  Human Presence Detector</para>
    ///   <para>rdfs:comment : Device used to detect if an object (vehicle, room, place, etc.) is occupied by Human.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumanPresenceDetector">iottaxolite:HumanPresenceDetector</a>
    /// </summary>
    let HumanPresenceDetector = _prefixId.prefix "HumanPresenceDetector"
    /// <summary>
    ///   <para>rdfs:label : Humidity</para>
    ///   <para>rdfs:comment : A quantity representing the amount of water vapour in the atmosphere or in a gas.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Humidity">iottaxolite:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:label : Humidity Sensor</para>
    ///   <para>rdfs:comment : Humidity sensor or hygrometer is an instrument used for measuring the moisture concent in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumiditySensor">iottaxolite:HumiditySensor</a>
    /// </summary>
    let HumiditySensor = _prefixId.prefix "HumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Hydrophone</para>
    ///   <para>rdfs:comment : A hydrophone is a microphone designed to be used underwater for recording or listening to underwater sound.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hydrophone">iottaxolite:Hydrophone</a>
    /// </summary>
    let Hydrophone = _prefixId.prefix "Hydrophone"

    /// <summary>
    ///   <para>rdfs:label : IEEE802.15.4 Interface Energy Meter</para>
    ///   <para>rdfs:comment : Sensor that measures the power consumption of the IEEE802.15.4 interface nodes.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IEEE802154InterfaceEnergyMeter">iottaxolite:IEEE802154InterfaceEnergyMeter</a>
    /// </summary>
    let IEEE802154InterfaceEnergyMeter = _prefixId.prefix "IEEE802154InterfaceEnergyMeter"

    /// <summary>
    ///   <para>rdfs:label : International Normalized Ratio</para>
    ///   <para>dc11:description : A system established by the World Health Organization (WHO) and the International Committee on Thrombosis and Hemostasis for reporting the results of blood coagulation (clotting) tests. Abbreviated INR. Under the INR system, all results are standardized. For example, a person taking the anticoagulant warfarin (brand name: Coumadin) would regularly have blood tested to measure the INR. The INR permits patients on anticoagulants to travel and obtain comparable test results wherever they are.
    ///         Medical Definition of International normalized ratio, MedicineNet</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#INR">iottaxolite:INR</a>
    /// </summary>
    let INR = _prefixId.prefix "INR"
    /// <summary>
    ///   <para>rdfs:label : Identify Outlier Observsations</para>
    ///   <para>rdfs:comment : Purpose to identify if an observation is outlier or not.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IdentifyOutlierObservsations">iottaxolite:IdentifyOutlierObservsations</a>
    /// </summary>
    let IdentifyOutlierObservsations = _prefixId.prefix "IdentifyOutlierObservsations"
    /// <summary>
    ///   <para>rdfs:label : Illuminance</para>
    ///   <para>rdfs:comment : Illuminance is the total luminous flux incident on a surface, per unit area.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Illuminance">iottaxolite:Illuminance</a>
    /// </summary>
    let Illuminance = _prefixId.prefix "Illuminance"
    /// <summary>
    ///   <para>rdfs:label : Image Sensor</para>
    ///   <para>rdfs:comment : Sensor that detects and conveys the information that constitutes an image.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ImageSensor">iottaxolite:ImageSensor</a>
    /// </summary>
    let ImageSensor = _prefixId.prefix "ImageSensor"
    /// <summary>
    ///   <para>rdfs:label : Inch</para>
    ///   <para>rdfs:comment : Length in inches.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Inch">iottaxolite:Inch</a>
    /// </summary>
    let Inch = _prefixId.prefix "Inch"
    /// <summary>
    ///   <para>rdfs:label : Index</para>
    ///   <para>rdfs:comment : Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Index">iottaxolite:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:label : Downlink Latency</para>
    ///   <para>rdfs:comment : Downlink Latency.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlLatency">iottaxolite:IntDlLatency</a>
    /// </summary>
    let IntDlLatency = _prefixId.prefix "IntDlLatency"
    /// <summary>
    ///   <para>rdfs:label : Downlink Throughput</para>
    ///   <para>rdfs:comment : Downlink Throughput.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlThroughputKbps">iottaxolite:IntDlThroughputKbps</a>
    /// </summary>
    let IntDlThroughputKbps = _prefixId.prefix "IntDlThroughputKbps"
    /// <summary>
    ///   <para>rdfs:label : Uplink Packet Loss</para>
    ///   <para>rdfs:comment : Uplink Packet Loss.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlPacketLoss">iottaxolite:IntUlPacketLoss</a>
    /// </summary>
    let IntUlPacketLoss = _prefixId.prefix "IntUlPacketLoss"
    /// <summary>
    ///   <para>rdfs:label : Uplink Throughput</para>
    ///   <para>rdfs:comment : Uplink Throughput.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlThroughputKbps">iottaxolite:IntUlThroughputKbps</a>
    /// </summary>
    let IntUlThroughputKbps = _prefixId.prefix "IntUlThroughputKbps"
    /// <summary>
    ///   <para>rdfs:label : Invalid Measurement Type</para>
    ///   <para>rdfs:comment : If the measurement was tagged invalid.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Invalid">iottaxolite:Invalid</a>
    /// </summary>
    let Invalid = _prefixId.prefix "Invalid"
    /// <summary>
    ///   <para>rdfs:label : Ionising Radiation</para>
    ///   <para>rdfs:comment : Ionising radiation is radiation that carries enough energy to free electrons from atoms or molecules, thereby ionizing them. Gamma rays, X-rays, and the higher ultraviolet part of the electromagnetic spectrum are ionizing, whereas the lower ultraviolet part of the electromagnetic spectrum, and also the lower part of the spectrum below UV, including visible light (including nearly all types of laser light), infrared, microwaves, and radio waves are all considered non-ionizing radiation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#IonisingRadiation">iottaxolite:IonisingRadiation</a>
    /// </summary>
    let IonisingRadiation = _prefixId.prefix "IonisingRadiation"
    /// <summary>
    ///   <para>rdfs:label : Irrigation Actuation Device</para>
    ///   <para>rdfs:comment : An actuator to automatically irrigate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Irrigation">iottaxolite:Irrigation</a>
    /// </summary>
    let Irrigation = _prefixId.prefix "Irrigation"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : Each of the accountable elements within a group.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Item">iottaxolite:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Kelvin, Degree Kelvin</para>
    ///   <para>rdfs:comment : Kelvin is a unit of measurement for temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kelvin">iottaxolite:Kelvin</a>
    /// </summary>
    let Kelvin = _prefixId.prefix "Kelvin"
    /// <summary>
    ///   <para>rdfs:label : Kilo Watt Hour</para>
    ///   <para>rdfs:comment : Measure of electrical energy equivalent to a power consumption of one thousand watts for one hour.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#KiloWattHour">iottaxolite:KiloWattHour</a>
    /// </summary>
    let KiloWattHour = _prefixId.prefix "KiloWattHour"
    /// <summary>
    ///   <para>rdfs:label : Kilobits Per Second</para>
    ///   <para>rdfs:comment : It is a unit of data transfer rate equal to: 1,000 bits per second.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilobitsPerSecond">iottaxolite:KilobitsPerSecond</a>
    /// </summary>
    let KilobitsPerSecond = _prefixId.prefix "KilobitsPerSecond"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#kilogram^^xsd:string</para>
    ///   <para>rdfs:label : Kilogram (kg)</para>
    ///   <para>rdfs:comment : The SI unit of mass, it is equal to the mass of the international prototype of the kilogram.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilogram">iottaxolite:Kilogram</a>
    /// </summary>
    let Kilogram = _prefixId.prefix "Kilogram"
    /// <summary>
    ///   <para>rdfs:comment : It is SI derived unit of density, defined by mass in kilograms divided by volume in cubic metres.</para>
    ///   <para>rdfs:label : Kilogram Per Cubic Metre, Kilogram Per Cubic Meter</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilogramPerCubicMetre">iottaxolite:KilogramPerCubicMetre</a>
    /// </summary>
    let KilogramPerCubicMetre = _prefixId.prefix "KilogramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:comment : A metric unit of measurement equal to 1,000 metres (approx 0.62 miles).</para>
    ///   <para>rdfs:label : Kilometre, Kilometer</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilometre">iottaxolite:Kilometre</a>
    /// </summary>
    let Kilometre = _prefixId.prefix "Kilometre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://data.qudt.org/qudt/owl/1.0.0/unit.owl#KilometerPerHour^^xsd:string</para>
    ///   <para>rdfs:comment : It is a unit of speed, expressing the number of kilometres travelled in one hour.</para>
    ///   <para>rdfs:label : Kilometre Per Hour, Kilometer Per Hour</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilometrePerHour">iottaxolite:KilometrePerHour</a>
    /// </summary>
    let KilometrePerHour = _prefixId.prefix "KilometrePerHour"
    /// <summary>
    ///   <para>rdfs:label : Know Sensors In The Area</para>
    ///   <para>rdfs:comment : Purpose to know sensors in the given area</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#KnowSensorsInTheArea">iottaxolite:KnowSensorsInTheArea</a>
    /// </summary>
    let KnowSensorsInTheArea = _prefixId.prefix "KnowSensorsInTheArea"
    /// <summary>
    ///   <para>rdfs:label : Lamp Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the lamp.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lamp">iottaxolite:Lamp</a>
    /// </summary>
    let Lamp = _prefixId.prefix "Lamp"
    /// <summary>
    ///   <para>rdfs:label : Lavatory Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the lavatory.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lavatory">iottaxolite:Lavatory</a>
    /// </summary>
    let Lavatory = _prefixId.prefix "Lavatory"
    /// <summary>
    ///   <para>rdfs:label : Leaf Wetness</para>
    ///   <para>rdfs:comment : Leaf wetness is a meteorological parameter that describes the amount of dew and precipitation left on surfaces. It is used for monitoring leaf moisture for agricultural purposes, such as fungus and disease control, for control of irrigation systems, and for detection of fog and dew conditions, and early detection of rainfall. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetness">iottaxolite:LeafWetness</a>
    /// </summary>
    let LeafWetness = _prefixId.prefix "LeafWetness"
    /// <summary>
    ///   <para>rdfs:label : Leaf Wetness Sensor</para>
    ///   <para>rdfs:comment : Leaf Wetness Sensor is used in agriculture to check whether the plants need to be watered.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetnessSensor">iottaxolite:LeafWetnessSensor</a>
    /// </summary>
    let LeafWetnessSensor = _prefixId.prefix "LeafWetnessSensor"
    /// <summary>
    ///   <para>rdfs:label : Light Sensor</para>
    ///   <para>rdfs:comment : Light/Illuminance Sensor is used to adjust the brightness of the surface.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LightSensor">iottaxolite:LightSensor</a>
    /// </summary>
    let LightSensor = _prefixId.prefix "LightSensor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#litre^^xsd:string</para>
    ///   <para>rdfs:label : Litre, Liter</para>
    ///   <para>rdfs:comment : A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Litre">iottaxolite:Litre</a>
    /// </summary>
    let Litre = _prefixId.prefix "Litre"
    /// <summary>
    ///   <para>rdfs:label : Litre Per 100 Kilometres, Liter Per 100 Kilometers</para>
    ///   <para>rdfs:comment : A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LitrePer100Kilometres">iottaxolite:LitrePer100Kilometres</a>
    /// </summary>
    let LitrePer100Kilometres = _prefixId.prefix "LitrePer100Kilometres"
    /// <summary>
    ///   <para>rdfs:label : LoRa Interface</para>
    ///   <para>rdfs:comment : This device is used for long range low power wireless communications. We can use this device to report network metrics (SNR, latence, etc.)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterface">iottaxolite:LoRaInterface</a>
    /// </summary>
    let LoRaInterface = _prefixId.prefix "LoRaInterface"
    /// <summary>
    ///   <para>rdfs:label : LoRa Interface Energy Meter</para>
    ///   <para>rdfs:comment : Measure the average power consumption of the LoRa interface nodes.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterfaceEnergyMeter">iottaxolite:LoRaInterfaceEnergyMeter</a>
    /// </summary>
    let LoRaInterfaceEnergyMeter = _prefixId.prefix "LoRaInterfaceEnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Location Quantity Kind</para>
    ///   <para>rdfs:comment : A particular place or position.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LocationQK">iottaxolite:LocationQK</a>
    /// </summary>
    let LocationQK = _prefixId.prefix "LocationQK"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#lumen^^xsd:string</para>
    ///   <para>rdfs:label : Lumen (lm)</para>
    ///   <para>rdfs:comment : The SI unit of luminous flux, equal to the amount of light emitted per second in a unit solid angle of one steradian from a uniform source of one candela.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lumen">iottaxolite:Lumen</a>
    /// </summary>
    let Lumen = _prefixId.prefix "Lumen"
    /// <summary>
    ///   <para>rdfs:label : Luminous Flux</para>
    ///   <para>rdfs:comment : Luminous Flux is the measure of the perceived power of light.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousFlux">iottaxolite:LuminousFlux</a>
    /// </summary>
    let LuminousFlux = _prefixId.prefix "LuminousFlux"
    /// <summary>
    ///   <para>rdfs:label : Luminous Intensity</para>
    ///   <para>rdfs:comment :  It is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye. The SI unit of luminous intensity is the candela (cd), an SI base unit. (Source Wikipedia)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousIntensity">iottaxolite:LuminousIntensity</a>
    /// </summary>
    let LuminousIntensity = _prefixId.prefix "LuminousIntensity"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#lux^^xsd:string</para>
    ///   <para>rdfs:label : Lux (lx)</para>
    ///   <para>rdfs:comment : The SI unit of illuminance, equal to one lumen per square metre.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lux">iottaxolite:Lux</a>
    /// </summary>
    let Lux = _prefixId.prefix "Lux"
    /// <summary>
    ///   <para>rdfs:label : Magnetic Field</para>
    ///   <para>rdfs:comment : A region around a magnetic material or a moving electric charge within which the force of magnetism acts.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticField">iottaxolite:MagneticField</a>
    /// </summary>
    let MagneticField = _prefixId.prefix "MagneticField"
    /// <summary>
    ///   <para>rdfs:label : Magnetic Flux Density</para>
    ///   <para>rdfs:comment : It is the magnetic flux  through a surface is the surface integral of the normal component of the magnetic field (B) passing through that surface. The SI unit of magnetic flux is the weber (Wb). (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticFluxDensity">iottaxolite:MagneticFluxDensity</a>
    /// </summary>
    let MagneticFluxDensity = _prefixId.prefix "MagneticFluxDensity"
    /// <summary>
    ///   <para>rdfs:label : Magnetometer</para>
    ///   <para>rdfs:comment : A magnetometer is an device that measures magnetism—either magnetization of magnetic material like a ferromagnet, or the strength and, in some cases, direction of the magnetic field at a point in space. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Magnetometer">iottaxolite:Magnetometer</a>
    /// </summary>
    let Magnetometer = _prefixId.prefix "Magnetometer"
    /// <summary>
    ///   <para>rdfs:label : Manual Measurement Type</para>
    ///   <para>rdfs:comment : If the measurement was taken when human effort was involved.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Manual">iottaxolite:Manual</a>
    /// </summary>
    let Manual = _prefixId.prefix "Manual"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#mass^^xsd:string</para>
    ///   <para>rdfs:label : Mass</para>
    ///   <para>rdfs:comment : Mass is a property of a physical body. It is the measure of an object's resistance to acceleration when a net force is applied.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mass">iottaxolite:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>rdfs:label : Measurement Type</para>
    ///   <para>rdfs:comment : Type of Measurement done using a device.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeasurementType">iottaxolite:MeasurementType</a>
    /// </summary>
    let MeasurementType = _prefixId.prefix "MeasurementType"
    /// <summary>
    ///   <para>rdfs:label : Meet For Coffee</para>
    ///   <para>rdfs:comment : Purpose of meeting a person for a coffee or arranging a meeting</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeetForCoffee">iottaxolite:MeetForCoffee</a>
    /// </summary>
    let MeetForCoffee = _prefixId.prefix "MeetForCoffee"
    /// <summary>
    ///   <para>rdfs:label : Meeting</para>
    ///   <para>rdfs:comment : Purpose for either arranging a meeting or actually meeting someone.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Meeting">iottaxolite:Meeting</a>
    /// </summary>
    let Meeting = _prefixId.prefix "Meeting"
    /// <summary>
    ///   <para>rdfs:label : Methane (CH4) Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Methane in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MethaneSensor">iottaxolite:MethaneSensor</a>
    /// </summary>
    let MethaneSensor = _prefixId.prefix "MethaneSensor"
    /// <summary>
    ///   <para>rdfs:label : Metre, Meter</para>
    ///   <para>rdfs:comment : It is the unit of length.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Metre">iottaxolite:Metre</a>
    /// </summary>
    let Metre = _prefixId.prefix "Metre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#metrePerSecond^^xsd:string</para>
    ///   <para>rdfs:label : Metre Per Second, Meter Per Second  (m/s)</para>
    ///   <para>rdfs:comment : A speed/velocity unit which is equal to the speed of an object traveling 1 metre distance in one second.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecond">iottaxolite:MetrePerSecond</a>
    /// </summary>
    let MetrePerSecond = _prefixId.prefix "MetrePerSecond"
    /// <summary>
    ///   <para>rdfs:label : Metre Per Second Square, Meter Per Second Square</para>
    ///   <para>rdfs:comment : It is the unit of acceleration (Metre Per Second Square, Meter Per Second Square)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecondSquare">iottaxolite:MetrePerSecondSquare</a>
    /// </summary>
    let MetrePerSecondSquare = _prefixId.prefix "MetrePerSecondSquare"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of electric current, or amount of electric charge per second.</para>
    ///   <para>rdfs:label : Microampere (uA)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microampere">iottaxolite:Microampere</a>
    /// </summary>
    let Microampere = _prefixId.prefix "Microampere"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of mass equal to one billionth (1×10^−9) of a kilogram.</para>
    ///   <para>rdfs:label : Microgram (ug)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microgram">iottaxolite:Microgram</a>
    /// </summary>
    let Microgram = _prefixId.prefix "Microgram"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#microgramPerCubicMetre^^xsd:string</para>
    ///   <para>rdfs:label : Microgram Per Cubic Metre, Microgram Per Cubic Meter</para>
    ///   <para>rdfs:comment : Microgram per cubic metre is a unit of density defined as microgram divided by cubic metre. Milligram per cubic metre is a derived unit in the International System of Units.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrogramPerCubicMetre">iottaxolite:MicrogramPerCubicMetre</a>
    /// </summary>
    let MicrogramPerCubicMetre = _prefixId.prefix "MicrogramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of electromotive force or potential difference equal to one millionth of a volt. </para>
    ///   <para>rdfs:label : Microvolt (uV)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microvolt">iottaxolite:Microvolt</a>
    /// </summary>
    let Microvolt = _prefixId.prefix "Microvolt"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of power.</para>
    ///   <para>rdfs:label : Microwatt (uW)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwatt">iottaxolite:Microwatt</a>
    /// </summary>
    let Microwatt = _prefixId.prefix "Microwatt"
    /// <summary>
    ///   <para>rdfs:label : Microwatt Per Square Centimetre, Microwatt Per Square Centimeter</para>
    ///   <para>rdfs:comment : It is one of the unit for radiative and other energy fluxes.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrowattPerSquareCentimetre">iottaxolite:MicrowattPerSquareCentimetre</a>
    /// </summary>
    let MicrowattPerSquareCentimetre = _prefixId.prefix "MicrowattPerSquareCentimetre"
    /// <summary>
    ///   <para>rdfs:label : Microwave Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the Microwave.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwave">iottaxolite:Microwave</a>
    /// </summary>
    let Microwave = _prefixId.prefix "Microwave"
    /// <summary>
    ///   <para>rdfs:comment : Measure of the number of miles or the average distance that a vehicle can travel on a specified quantity of fuel</para>
    ///   <para>rdfs:label : Mileage</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mileage">iottaxolite:Mileage</a>
    /// </summary>
    let Mileage = _prefixId.prefix "Mileage"
    /// <summary>
    ///   <para>rdfs:label : Mileage Distance To Service</para>
    ///   <para>rdfs:comment : The distance which can be travelled by the vehicle before the next service inspection is required.  A negative distance is transmitted if the service inspection has been passed.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageDistanceToService">iottaxolite:MileageDistanceToService</a>
    /// </summary>
    let MileageDistanceToService = _prefixId.prefix "MileageDistanceToService"
    /// <summary>
    ///   <para>rdfs:label : Mileage Total</para>
    ///   <para>rdfs:comment : The total distance travelled by the particular vehicle since its initial production.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageTotal">iottaxolite:MileageTotal</a>
    /// </summary>
    let MileageTotal = _prefixId.prefix "MileageTotal"
    /// <summary>
    ///   <para>rdfs:label : Miles</para>
    ///   <para>rdfs:comment : It is a unit of length that is equal to 1,760 yards (approx. 1.609 kilometres).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Miles">iottaxolite:Miles</a>
    /// </summary>
    let Miles = _prefixId.prefix "Miles"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of an ampere.</para>
    ///   <para>rdfs:label : Milliampere (mA)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliampere">iottaxolite:Milliampere</a>
    /// </summary>
    let Milliampere = _prefixId.prefix "Milliampere"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a bar.</para>
    ///   <para>rdfs:label : Millibar</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millibar">iottaxolite:Millibar</a>
    /// </summary>
    let Millibar = _prefixId.prefix "Millibar"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a gram.</para>
    ///   <para>rdfs:label : Milligram (mg)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milligram">iottaxolite:Milligram</a>
    /// </summary>
    let Milligram = _prefixId.prefix "Milligram"
    /// <summary>
    ///   <para>rdfs:comment : It is a density measurement unit.</para>
    ///   <para>rdfs:label : Milligram Per Cubic Metre, Milligram Per Cubic Meter</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerCubicMetre">iottaxolite:MilligramPerCubicMetre</a>
    /// </summary>
    let MilligramPerCubicMetre = _prefixId.prefix "MilligramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:label : Milligram Per Litre, Milligram Per Liter</para>
    ///   <para>rdfs:comment : Level of Dissolved substance in liquid measured in mg per litre.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerLitre">iottaxolite:MilligramPerLitre</a>
    /// </summary>
    let MilligramPerLitre = _prefixId.prefix "MilligramPerLitre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#milligramPerSquareMetre^^xsd:string</para>
    ///   <para>rdfs:label : Milligram Per Square Metre, Milligram Per Square Meter</para>
    ///   <para>rdfs:comment : A dose unit which is equal to 1 milligram of a substance per square metre of surface area of the recipient subject.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerSquareMetre">iottaxolite:MilligramPerSquareMetre</a>
    /// </summary>
    let MilligramPerSquareMetre = _prefixId.prefix "MilligramPerSquareMetre"
    /// <summary>
    ///   <para>rdfs:label : Millilitre, Milliliter</para>
    ///   <para>rdfs:comment : One thousandth of a litre (0.002 pint).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millilitre">iottaxolite:Millilitre</a>
    /// </summary>
    let Millilitre = _prefixId.prefix "Millilitre"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a metre (0.039 in).</para>
    ///   <para>rdfs:label : Millimetre, Millimeter</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millimetre">iottaxolite:Millimetre</a>
    /// </summary>
    let Millimetre = _prefixId.prefix "Millimetre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#millimetrePerHour^^xsd:string</para>
    ///   <para>rdfs:label : Millimetre Per Hour, Millimeter Per Hour</para>
    ///   <para>rdfs:comment : A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimetre travelled per unit hour.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillimetrePerHour">iottaxolite:MillimetrePerHour</a>
    /// </summary>
    let MillimetrePerHour = _prefixId.prefix "MillimetrePerHour"
    /// <summary>
    ///   <para>rdfs:label : Millisecond</para>
    ///   <para>rdfs:comment : One thousandth of a second.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millisecond">iottaxolite:Millisecond</a>
    /// </summary>
    let Millisecond = _prefixId.prefix "Millisecond"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a volt.</para>
    ///   <para>rdfs:label : Millivolt (mV)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millivolt">iottaxolite:Millivolt</a>
    /// </summary>
    let Millivolt = _prefixId.prefix "Millivolt"
    /// <summary>
    ///   <para>rdfs:comment : It is a measure of the intensity of the signal of a radio transmitter.</para>
    ///   <para>rdfs:label : Millivolt Per Metre, Millivolt Per Meter</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillivoltPerMetre">iottaxolite:MillivoltPerMetre</a>
    /// </summary>
    let MillivoltPerMetre = _prefixId.prefix "MillivoltPerMetre"
    /// <summary>
    ///   <para>rdfs:comment : A unit of power equal to one thousandth of a watt.</para>
    ///   <para>rdfs:label : Milliwatt (mW)</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliwatt">iottaxolite:Milliwatt</a>
    /// </summary>
    let Milliwatt = _prefixId.prefix "Milliwatt"
    /// <summary>
    ///   <para>rdfs:label : Minute Angle</para>
    ///   <para>rdfs:comment : A Minute of Angle (MOA) is an angular measurement. A MOA is 1/60th of a degree.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteAngle">iottaxolite:MinuteAngle</a>
    /// </summary>
    let MinuteAngle = _prefixId.prefix "MinuteAngle"
    /// <summary>
    ///   <para>rdfs:label : Minute Time</para>
    ///   <para>rdfs:comment : A unit of time equal to 60 seconds or 1/60th of an hour.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteTime">iottaxolite:MinuteTime</a>
    /// </summary>
    let MinuteTime = _prefixId.prefix "MinuteTime"
    /// <summary>
    ///   <para>rdfs:label : MmHg</para>
    ///   <para>rdfs:comment : A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmHg">iottaxolite:MmHg</a>
    /// </summary>
    let MmHg = _prefixId.prefix "MmHg"
    /// <summary>
    ///   <para>rdfs:label : Mmol Per Litre, Mmol Per Liter</para>
    ///   <para>rdfs:comment : It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLitre is used to measure cholesterol.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmolPerLitre">iottaxolite:MmolPerLitre</a>
    /// </summary>
    let MmolPerLitre = _prefixId.prefix "MmolPerLitre"
    /// <summary>
    ///   <para>rdfs:label : Handover Execution</para>
    ///   <para>rdfs:comment : Handover Execution.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoExecSuccRate">iottaxolite:MobHoExecSuccRate</a>
    /// </summary>
    let MobHoExecSuccRate = _prefixId.prefix "MobHoExecSuccRate"
    /// <summary>
    ///   <para>rdfs:label : Handover Preparation Success Rate</para>
    ///   <para>rdfs:comment : Handover Preparation Success Rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoPrepSuccRate">iottaxolite:MobHoPrepSuccRate</a>
    /// </summary>
    let MobHoPrepSuccRate = _prefixId.prefix "MobHoPrepSuccRate"
    /// <summary>
    ///   <para>rdfs:label : Handover Mobility Success Rate</para>
    ///   <para>rdfs:comment : Handover Mobility Success Rate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobMobilitySuccRate">iottaxolite:MobMobilitySuccRate</a>
    /// </summary>
    let MobMobilitySuccRate = _prefixId.prefix "MobMobilitySuccRate"
    /// <summary>
    ///   <para>rdfs:label : Monitor Temperature</para>
    ///   <para>rdfs:comment : Purpose for monitoring temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MonitorTemperature">iottaxolite:MonitorTemperature</a>
    /// </summary>
    let MonitorTemperature = _prefixId.prefix "MonitorTemperature"
    /// <summary>
    ///   <para>rdfs:label : Motion</para>
    ///   <para>rdfs:comment : It is the action or process of moving or being moved.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Motion">iottaxolite:Motion</a>
    /// </summary>
    let Motion = _prefixId.prefix "Motion"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether a person (or object) is detected upon his/her/its movement.</para>
    ///   <para>rdfs:label : Motion State</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionState">iottaxolite:MotionState</a>
    /// </summary>
    let MotionState = _prefixId.prefix "MotionState"
    /// <summary>
    ///   <para>rdfs:label : Motion State Vehicle</para>
    ///   <para>rdfs:comment : Indicates whether motion of the vehicle is detected or not.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionStateVehicle">iottaxolite:MotionStateVehicle</a>
    /// </summary>
    let MotionStateVehicle = _prefixId.prefix "MotionStateVehicle"
    /// <summary>
    ///   <para>rdfs:label : NFC Tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be NFC (Near Field Communication).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#NFC">iottaxolite:NFC</a>
    /// </summary>
    let NFC = _prefixId.prefix "NFC"
    /// <summary>
    ///   <para>rdfs:label : NH3 Sensor</para>
    ///   <para>rdfs:comment : Device used to detect NH3 level in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#NH3Sensor">iottaxolite:NH3Sensor</a>
    /// </summary>
    let NH3Sensor = _prefixId.prefix "NH3Sensor"
    /// <summary>
    ///   <para>rdfs:label : Nitrogen Dioxide (NO2) Sensor</para>
    ///   <para>rdfs:comment : Sensor detecting levels of Nitrogen Dioxide (NO2) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#NO2Sensor">iottaxolite:NO2Sensor</a>
    /// </summary>
    let NO2Sensor = _prefixId.prefix "NO2Sensor"
    /// <summary>
    ///   <para>rdfs:label : Nitrogen Oxide (NO) Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Nitrogen Oxide (NO) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#NOSensor">iottaxolite:NOSensor</a>
    /// </summary>
    let NOSensor = _prefixId.prefix "NOSensor"
    /// <summary>
    ///   <para>rdfs:label : Neighbours Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound were noisy neighbours.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Neighbours">iottaxolite:Neighbours</a>
    /// </summary>
    let Neighbours = _prefixId.prefix "Neighbours"
    /// <summary>
    ///   <para>rdfs:label : Ozone (O3) Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Ozone (O3) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#O3Sensor">iottaxolite:O3Sensor</a>
    /// </summary>
    let O3Sensor = _prefixId.prefix "O3Sensor"
    /// <summary>
    ///   <para>rdfs:label : Odometer</para>
    ///   <para>rdfs:comment : An odometer or odograph is an instrument that indicates distance travelled by a vehicle, such as bicycle or automobile.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Odometer">iottaxolite:Odometer</a>
    /// </summary>
    let Odometer = _prefixId.prefix "Odometer"
    /// <summary>
    ///   <para>rdfs:label : Ohm</para>
    ///   <para>rdfs:comment : Ohm is the unit of electrical resistance.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ohm">iottaxolite:Ohm</a>
    /// </summary>
    let Ohm = _prefixId.prefix "Ohm"
    /// <summary>
    ///   <para>rdfs:label : Okta</para>
    ///   <para>rdfs:comment : Okta is the unit to measure the cloud cover.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Okta">iottaxolite:Okta</a>
    /// </summary>
    let Okta = _prefixId.prefix "Okta"
    /// <summary>
    ///   <para>rdfs:label : Open The Door</para>
    ///   <para>rdfs:comment : Action related to either request for opening the door or actually opening it.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpenTheDoor">iottaxolite:OpenTheDoor</a>
    /// </summary>
    let OpenTheDoor = _prefixId.prefix "OpenTheDoor"
    /// <summary>
    ///   <para>rdfs:label : Optical Dust Sensor</para>
    ///   <para>rdfs:comment : A sensing device that measures dust particle concentration using optical sensing mean.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpticalDustSensor">iottaxolite:OpticalDustSensor</a>
    /// </summary>
    let OpticalDustSensor = _prefixId.prefix "OpticalDustSensor"
    /// <summary>
    ///   <para>rdfs:label : Others</para>
    ///   <para>rdfs:comment : Relates to phenomenon and unit that are not available currently in the current version of Taxonomy.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Others">iottaxolite:Others</a>
    /// </summary>
    let Others = _prefixId.prefix "Others"

    /// <summary>
    ///   <para>rdfs:label : Oxidation Reduction Potential (ORP) Sensor</para>
    ///   <para>rdfs:comment : Measures the Water Oxidation Reduction Potential (ORP) as the tendency of a chemical species to acquire electrons and thereby be reduced.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxidationReductionPotentialSensor">iottaxolite:OxidationReductionPotentialSensor</a>
    /// </summary>
    let OxidationReductionPotentialSensor = _prefixId.prefix "OxidationReductionPotentialSensor"

    /// <summary>
    ///   <para>rdfs:label : Oxygen Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Oxygen (O2) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxygenSensor">iottaxolite:OxygenSensor</a>
    /// </summary>
    let OxygenSensor = _prefixId.prefix "OxygenSensor"
    /// <summary>
    ///   <para>rdfs:label : PH</para>
    ///   <para>rdfs:comment : It is a numeric scale used to specify the acidity or basicity of an aqueous solution.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PH">iottaxolite:PH</a>
    /// </summary>
    let PH = _prefixId.prefix "PH"
    /// <summary>
    ///   <para>rdfs:label : PH Sensor</para>
    ///   <para>rdfs:comment : Device used to detect PH level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PHSensor">iottaxolite:PHSensor</a>
    /// </summary>
    let PHSensor = _prefixId.prefix "PHSensor"
    /// <summary>
    ///   <para>rdfs:label : PPM (parts per million)</para>
    ///   <para>rdfs:comment : It describes the concentration of something in water or soil.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PPM">iottaxolite:PPM</a>
    /// </summary>
    let PPM = _prefixId.prefix "PPM"
    /// <summary>
    ///   <para>rdfs:label : Parts Per Billion</para>
    ///   <para>rdfs:comment : It describes the concentration of something in parts per billion parts of water or soil, expressed in any (but common) unit of measurement.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PartsPerBillion">iottaxolite:PartsPerBillion</a>
    /// </summary>
    let PartsPerBillion = _prefixId.prefix "PartsPerBillion"
    /// <summary>
    ///   <para>rdfs:label : Pascal</para>
    ///   <para>rdfs:comment : Unit for pressure (e.g., atmospheric pressure).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pascal">iottaxolite:Pascal</a>
    /// </summary>
    let Pascal = _prefixId.prefix "Pascal"
    /// <summary>
    ///   <para>rdfs:label : Pedometer</para>
    ///   <para>rdfs:comment : Pedometer is used to count the number of steps when walking, running, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pedometer">iottaxolite:Pedometer</a>
    /// </summary>
    let Pedometer = _prefixId.prefix "Pedometer"
    /// <summary>
    ///   <para>rdfs:label : People Count Sensor</para>
    ///   <para>rdfs:comment : Device used to count the number of people (eg., used within an indoor area).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleCountSensor">iottaxolite:PeopleCountSensor</a>
    /// </summary>
    let PeopleCountSensor = _prefixId.prefix "PeopleCountSensor"
    /// <summary>
    ///   <para>rdfs:label : People Flow Count Sensor</para>
    ///   <para>rdfs:comment : Device used to count the number of people the moves from an area towards another area during a time window.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleFlowCountSensor">iottaxolite:PeopleFlowCountSensor</a>
    /// </summary>
    let PeopleFlowCountSensor = _prefixId.prefix "PeopleFlowCountSensor"
    /// <summary>
    ///   <para>rdfs:label : People Stay Duration Average </para>
    ///   <para>rdfs:comment : Average time people stays within an area.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationAverage">iottaxolite:PeopleStayDurationAverage</a>
    /// </summary>
    let PeopleStayDurationAverage = _prefixId.prefix "PeopleStayDurationAverage"
    /// <summary>
    ///   <para>rdfs:label : People Stay Duration Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the time people stays within an area.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationSensor">iottaxolite:PeopleStayDurationSensor</a>
    /// </summary>
    let PeopleStayDurationSensor = _prefixId.prefix "PeopleStayDurationSensor"
    /// <summary>
    ///   <para>rdfs:label : Percent</para>
    ///   <para>rdfs:comment : It is the amount in or for every hundred.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Percent">iottaxolite:Percent</a>
    /// </summary>
    let Percent = _prefixId.prefix "Percent"
    /// <summary>
    ///   <para>rdfs:label : Place DOI</para>
    ///   <para>rdfs:comment : Location, Place, GPS coordinates as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Place">iottaxolite:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Potassium</para>
    ///   <para>rdfs:comment : It is the measure of Blood Potassium Level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Potassium">iottaxolite:Potassium</a>
    /// </summary>
    let Potassium = _prefixId.prefix "Potassium"
    /// <summary>
    ///   <para>rdfs:label : Pound</para>
    ///   <para>rdfs:comment : A unit of weight equal to 16 oz. 1 pound= 453.592 grams</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pound">iottaxolite:Pound</a>
    /// </summary>
    let Pound = _prefixId.prefix "Pound"
    /// <summary>
    ///   <para>rdfs:label : Power</para>
    ///   <para>rdfs:comment : It is the rate, per unit time, at which electrical energy is transferred by an electric circuit.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Power">iottaxolite:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:label : Precipitation</para>
    ///   <para>rdfs:comment : It is any product of the condensation of atmospheric water vapour that falls under gravity.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Precipitation">iottaxolite:Precipitation</a>
    /// </summary>
    let Precipitation = _prefixId.prefix "Precipitation"
    /// <summary>
    ///   <para>rdfs:label : Precipitation Sensor</para>
    ///   <para>rdfs:comment : It is a device measuring the amount of precipitation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PrecipitationSensor">iottaxolite:PrecipitationSensor</a>
    /// </summary>
    let PrecipitationSensor = _prefixId.prefix "PrecipitationSensor"
    /// <summary>
    ///   <para>rdfs:comment : Measure to know if an object is present. It is usually boolean.</para>
    ///   <para>rdfs:label : Presence</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Presence">iottaxolite:Presence</a>
    /// </summary>
    let Presence = _prefixId.prefix "Presence"
    /// <summary>
    ///   <para>rdfs:label : Presence Detector</para>
    ///   <para>rdfs:comment : Device used to detect if on object is occupied or not.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceDetector">iottaxolite:PresenceDetector</a>
    /// </summary>
    let PresenceDetector = _prefixId.prefix "PresenceDetector"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the presence of the first driver card.</para>
    ///   <para>rdfs:label : Presence State Driver Card</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCard">iottaxolite:PresenceStateDriverCard</a>
    /// </summary>
    let PresenceStateDriverCard = _prefixId.prefix "PresenceStateDriverCard"
    /// <summary>
    ///   <para>rdfs:label : Presence State Driver Card 1</para>
    ///   <para>rdfs:comment : Indicates the presence of the first driver card.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardOne">iottaxolite:PresenceStateDriverCardOne</a>
    /// </summary>
    let PresenceStateDriverCardOne = _prefixId.prefix "PresenceStateDriverCardOne"
    /// <summary>
    ///   <para>rdfs:label : Presence State Driver Card 2</para>
    ///   <para>rdfs:comment : Indicates the presence of the second driver card.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardTwo">iottaxolite:PresenceStateDriverCardTwo</a>
    /// </summary>
    let PresenceStateDriverCardTwo = _prefixId.prefix "PresenceStateDriverCardTwo"
    /// <summary>
    ///   <para>rdfs:label : Presence State Emergency Vehicle</para>
    ///   <para>rdfs:comment : The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateEmergencyVehicle">iottaxolite:PresenceStateEmergencyVehicle</a>
    /// </summary>
    let PresenceStateEmergencyVehicle = _prefixId.prefix "PresenceStateEmergencyVehicle"
    /// <summary>
    ///   <para>rdfs:label : Presence State Parking</para>
    ///   <para>rdfs:comment : The presence or absence of a vehicle parked.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateParking">iottaxolite:PresenceStateParking</a>
    /// </summary>
    let PresenceStateParking = _prefixId.prefix "PresenceStateParking"
    /// <summary>
    ///   <para>rdfs:label : Presence State People</para>
    ///   <para>rdfs:comment : The presence or absence of people passing.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStatePeople">iottaxolite:PresenceStatePeople</a>
    /// </summary>
    let PresenceStatePeople = _prefixId.prefix "PresenceStatePeople"
    /// <summary>
    ///   <para>rdfs:label : Pressure</para>
    ///   <para>rdfs:comment : It is the physical force exerted on or against an object by something in contact with it.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pressure">iottaxolite:Pressure</a>
    /// </summary>
    let Pressure = _prefixId.prefix "Pressure"
    /// <summary>
    ///   <para>rdfs:label : Pressure Sensor</para>
    ///   <para>rdfs:comment : A device used to detect pressure. For example, it can be attached on the bed to infer if the user is lying, sleeping, sitting, bed occupancy, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PressureSensor">iottaxolite:PressureSensor</a>
    /// </summary>
    let PressureSensor = _prefixId.prefix "PressureSensor"
    /// <summary>
    ///   <para>rdfs:label : Proximity</para>
    ///   <para>rdfs:comment : Measure to detect proximity.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Proximity">iottaxolite:Proximity</a>
    /// </summary>
    let Proximity = _prefixId.prefix "Proximity"
    /// <summary>
    ///   <para>rdfs:label : Proximity Sensor</para>
    ///   <para>rdfs:comment : Detect if something is within proximity of a sensor.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ProximitySensor">iottaxolite:ProximitySensor</a>
    /// </summary>
    let ProximitySensor = _prefixId.prefix "ProximitySensor"
    /// <summary>
    ///   <para>rdfs:label : Public Transit Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was public transit.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PublicTransit">iottaxolite:PublicTransit</a>
    /// </summary>
    let PublicTransit = _prefixId.prefix "PublicTransit"
    /// <summary>
    ///   <para>rdfs:label : Pulse Oxymeter</para>
    ///   <para>rdfs:comment : Pulse Oxymeter, SpO2, Blood Oxygen Saturation Sensor are used to measure the concentration of oxygen in the blood.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#PulseOxymeter">iottaxolite:PulseOxymeter</a>
    /// </summary>
    let PulseOxymeter = _prefixId.prefix "PulseOxymeter"
    /// <summary>
    ///   <para>rdfs:label : QR Code tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be QRCode.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#QRCode">iottaxolite:QRCode</a>
    /// </summary>
    let QRCode = _prefixId.prefix "QRCode"
    /// <summary>
    ///   <para>rdfs:label : Quality Of Observation</para>
    ///   <para>rdfs:comment : It identifies the quality of observation taken by a sensor or an actuator</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#QualityOfObservation">iottaxolite:QualityOfObservation</a>
    /// </summary>
    let QualityOfObservation = _prefixId.prefix "QualityOfObservation"
    /// <summary>
    ///   <para>rdfs:label : RFID Tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be RFID.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RFID">iottaxolite:RFID</a>
    /// </summary>
    let RFID = _prefixId.prefix "RFID"
    /// <summary>
    ///   <para>rdfs:label : Received Signal Strength Indicator</para>
    ///   <para>rdfs:comment : Received Signal Strength Indicator is the signal strength in a wireless network environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RSSI">iottaxolite:RSSI</a>
    /// </summary>
    let RSSI = _prefixId.prefix "RSSI"
    /// <summary>
    ///   <para>rdfs:label : Radian</para>
    ///   <para>rdfs:comment : The radian is a unit of angular measure defined such that an angle of one radian subtended from the centre of a unit circle produces an arc with arc length 1.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Radian">iottaxolite:Radian</a>
    /// </summary>
    let Radian = _prefixId.prefix "Radian"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#radianPerSecond^^xsd:string</para>
    ///   <para>rdfs:label : Radian Per Second</para>
    ///   <para>rdfs:comment : The radian per second is defined as the change in the orientation of an object, in radians, every second. The radian per second is the SI unit of angular (rotational) speed.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadianPerSecond">iottaxolite:RadianPerSecond</a>
    /// </summary>
    let RadianPerSecond = _prefixId.prefix "RadianPerSecond"
    /// <summary>
    ///   <para>rdfs:label : Radiation Particle Detector</para>
    ///   <para>rdfs:comment : A particle detector, also known as a radiation detector or Geiger counter, is a device used to detect, track, and/or identify ionising particles, such as those produced by nuclear decay, cosmic radiation, or reactions in a particle accelerator.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticleDetector">iottaxolite:RadiationParticleDetector</a>
    /// </summary>
    let RadiationParticleDetector = _prefixId.prefix "RadiationParticleDetector"
    /// <summary>
    ///   <para>rdfs:label : Radiation Particles Per Minute</para>
    ///   <para>rdfs:comment : The number of ionizing events detected in one minute.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticlesPerMinute">iottaxolite:RadiationParticlesPerMinute</a>
    /// </summary>
    let RadiationParticlesPerMinute = _prefixId.prefix "RadiationParticlesPerMinute"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://sweet.jpl.nasa.gov/ontology/property.owl#Rainfall^^xsd:string</para>
    ///   <para>rdfs:label : Rainfall</para>
    ///   <para>rdfs:comment : The depth of precipitation (water-equivalent) that accumulated over a measurement time quantity.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Rainfall">iottaxolite:Rainfall</a>
    /// </summary>
    let Rainfall = _prefixId.prefix "Rainfall"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/dim#ReactivePower^^xsd:string</para>
    ///   <para>rdfs:label : Reactive Power</para>
    ///   <para>rdfs:comment : The portion of electricity that establishes and sustains the electric and magnetic fields of alternating-current equipment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ReactivePower">iottaxolite:ReactivePower</a>
    /// </summary>
    let ReactivePower = _prefixId.prefix "ReactivePower"
    /// <summary>
    ///   <para>rdfs:label : Recognized Activity</para>
    ///   <para>rdfs:comment : Activity Recognized. This is usually made available as a part of analysis done by Google. The available activities recognized are IN_VEHICLE, ON_BICYCLE, ON_FOOT, RUNNING, STILL, TILTING, UNKNOWN, and WALKING.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RecognizedActivity">iottaxolite:RecognizedActivity</a>
    /// </summary>
    let RecognizedActivity = _prefixId.prefix "RecognizedActivity"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://sweet.jpl.nasa.gov/ontology/property.owl#RelativeHumidity^^xsd:string</para>
    ///   <para>rdfs:label : Relative Humidity</para>
    ///   <para>rdfs:comment : The ratio of vapour pressure to saturation vapour pressure, where vapour pressure is the pressure exerted by the molecules of water vapour and saturation vapour pressure is the pressure exerted by molecules of water vapour in AIR that has attained saturation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RelativeHumidity">iottaxolite:RelativeHumidity</a>
    /// </summary>
    let RelativeHumidity = _prefixId.prefix "RelativeHumidity"
    /// <summary>
    ///   <para>rdfs:label : Connected Users</para>
    ///   <para>rdfs:comment : Connected Users to a communication channel/platform</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ResAverageLicConnectedUsers">iottaxolite:ResAverageLicConnectedUsers</a>
    /// </summary>
    let ResAverageLicConnectedUsers = _prefixId.prefix "ResAverageLicConnectedUsers"
    /// <summary>
    ///   <para>rdfs:label : ERAB Drop</para>
    ///   <para>rdfs:comment : ERAB Drop.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RetERabDrop">iottaxolite:RetERabDrop</a>
    /// </summary>
    let RetERabDrop = _prefixId.prefix "RetERabDrop"
    /// <summary>
    ///   <para>rdfs:label : Revolutions Per Minute</para>
    ///   <para>rdfs:comment : Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RevolutionsPerMinute">iottaxolite:RevolutionsPerMinute</a>
    /// </summary>
    let RevolutionsPerMinute = _prefixId.prefix "RevolutionsPerMinute"
    /// <summary>
    ///   <para>rdfs:label : Road Occupancy</para>
    ///   <para>rdfs:comment : Ratio of time on which a road lane section is occupied by vehicles within a given period of time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadOccupancy">iottaxolite:RoadOccupancy</a>
    /// </summary>
    let RoadOccupancy = _prefixId.prefix "RoadOccupancy"
    /// <summary>
    ///   <para>rdfs:label : Road Surface Thermometer</para>
    ///   <para>rdfs:comment : Device used to measure the road Surface temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadSurfaceThermometer">iottaxolite:RoadSurfaceThermometer</a>
    /// </summary>
    let RoadSurfaceThermometer = _prefixId.prefix "RoadSurfaceThermometer"
    /// <summary>
    ///   <para>rdfs:label : Road Temperature</para>
    ///   <para>rdfs:comment : Temperature of the road.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadTemperature">iottaxolite:RoadTemperature</a>
    /// </summary>
    let RoadTemperature = _prefixId.prefix "RoadTemperature"
    /// <summary>
    ///   <para>rdfs:label : Room</para>
    ///   <para>rdfs:comment : When the feature of interest is room</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Room">iottaxolite:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:label : Room Temperature</para>
    ///   <para>rdfs:comment : Temperature of a room.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoomTemperature">iottaxolite:RoomTemperature</a>
    /// </summary>
    let RoomTemperature = _prefixId.prefix "RoomTemperature"
    /// <summary>
    ///   <para>rdfs:comment : Rotational speed (or speed of revolution) of an object rotating around an axis is the number of turns of the object divided by time, specified as revolutions per minute (rpm), revolutions per second (rev/s), or radians per second (rad/s). (Source Wikipedia)</para>
    ///   <para>rdfs:label : Rotational Speed</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeed">iottaxolite:RotationalSpeed</a>
    /// </summary>
    let RotationalSpeed = _prefixId.prefix "RotationalSpeed"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#rotationalSpeed^^xsd:string</para>
    ///   <para>rdfs:label : Rotational Speed Engine</para>
    ///   <para>rdfs:comment : Rotational speed is a property that is the rate of rotation of a material around an axis, in this case the engine cylinders.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeedEngine">iottaxolite:RotationalSpeedEngine</a>
    /// </summary>
    let RotationalSpeedEngine = _prefixId.prefix "RotationalSpeedEngine"
    /// <summary>
    ///   <para>rdfs:label : Signal to Noise Ratio</para>
    ///   <para>rdfs:comment : Compares the level of a desired signal to the level of noise. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SNR">iottaxolite:SNR</a>
    /// </summary>
    let SNR = _prefixId.prefix "SNR"
    /// <summary>
    ///   <para>rdfs:label : Sulphur Dioxide (SO2) Sensor</para>
    ///   <para>rdfs:comment : Device use to detect Sulphur Dioxide (SO2) level in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SO2Sensor">iottaxolite:SO2Sensor</a>
    /// </summary>
    let SO2Sensor = _prefixId.prefix "SO2Sensor"
    /// <summary>
    ///   <para>rdfs:label : SPO2</para>
    ///   <para>rdfs:comment : It is a measure of the amount of oxygenated haemoglobin in the blood.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SPO2">iottaxolite:SPO2</a>
    /// </summary>
    let SPO2 = _prefixId.prefix "SPO2"
    /// <summary>
    ///   <para>rdfs:label : Salinity</para>
    ///   <para>rdfs:comment : It is the measure of all the salts dissolved in water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Salinity">iottaxolite:Salinity</a>
    /// </summary>
    let Salinity = _prefixId.prefix "Salinity"
    /// <summary>
    ///   <para>rdfs:label : Salt Meter</para>
    ///   <para>rdfs:comment : Device use to detect salinity of water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SaltMeter">iottaxolite:SaltMeter</a>
    /// </summary>
    let SaltMeter = _prefixId.prefix "SaltMeter"
    /// <summary>
    ///   <para>rdfs:label : Scale</para>
    ///   <para>rdfs:comment : Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values are part of a continuous variable which can take any numeric value.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Scale">iottaxolite:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:label : Seat Belt Tension Actuating Device</para>
    ///   <para>rdfs:comment :  Actuator used to turn Seat Belt Tension Actuator on or off. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SeatBeltTensionSensor">iottaxolite:SeatBeltTensionSensor</a>
    /// </summary>
    let SeatBeltTensionSensor = _prefixId.prefix "SeatBeltTensionSensor"
    /// <summary>
    ///   <para>rdfs:label : Second Angle</para>
    ///   <para>rdfs:comment : It is a unit of angular measurement equal to 1/60 of one degree.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondAngle">iottaxolite:SecondAngle</a>
    /// </summary>
    let SecondAngle = _prefixId.prefix "SecondAngle"
    /// <summary>
    ///   <para>rdfs:label : Second Time</para>
    ///   <para>rdfs:comment : Qualitatively defined as the second division of the hour by sixty, the first division by sixty being the minute. SI definition of second is "the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium 133 atom.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondTime">iottaxolite:SecondTime</a>
    /// </summary>
    let SecondTime = _prefixId.prefix "SecondTime"
    /// <summary>
    ///   <para>rdfs:label : Seismometer</para>
    ///   <para>rdfs:comment : Seismometers are instruments that measure motions of the ground, including those of seismic waves generated by earthquakes, volcanic eruptions, and other seismic sources.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Seismometer">iottaxolite:Seismometer</a>
    /// </summary>
    let Seismometer = _prefixId.prefix "Seismometer"
    /// <summary>
    ///   <para>rdfs:label : Shake Sensor</para>
    ///   <para>rdfs:comment : Shake sensor is used to deduce the quality of the road, earthquakes.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ShakeSensor">iottaxolite:ShakeSensor</a>
    /// </summary>
    let ShakeSensor = _prefixId.prefix "ShakeSensor"
    /// <summary>
    ///   <para>rdfs:label : Shower Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the shower.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Shower">iottaxolite:Shower</a>
    /// </summary>
    let Shower = _prefixId.prefix "Shower"
    /// <summary>
    ///   <para>rdfs:label : Siemens Per Metre, Siemens Per Meter</para>
    ///   <para>rdfs:comment : Conductivity is measured in Siemens per metre (S/m).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SiemensPerMetre">iottaxolite:SiemensPerMetre</a>
    /// </summary>
    let SiemensPerMetre = _prefixId.prefix "SiemensPerMetre"
    /// <summary>
    ///   <para>rdfs:label : Sink Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the sink.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sink">iottaxolite:Sink</a>
    /// </summary>
    let Sink = _prefixId.prefix "Sink"
    /// <summary>
    ///   <para>rdfs:label : Sirens Sound Source</para>
    ///   <para>rdfs:comment : When source of the sound were sirens either from ambulance, police car or factory etc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sirens">iottaxolite:Sirens</a>
    /// </summary>
    let Sirens = _prefixId.prefix "Sirens"
    /// <summary>
    ///   <para>rdfs:label : Skin conductance, GSR</para>
    ///   <para>rdfs:comment : Electroderal activity (also known as skin conductance or galvanic skin response) directly correlates to the sympathetic nervous system activity and thus provides a powerful tool for monitoring arousal and certain aspects of autonomic regulation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductance">iottaxolite:SkinConductance</a>
    /// </summary>
    let SkinConductance = _prefixId.prefix "SkinConductance"
    /// <summary>
    ///   <para>rdfs:label : Skin Conductance Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Skin Conductance.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductanceSensor">iottaxolite:SkinConductanceSensor</a>
    /// </summary>
    let SkinConductanceSensor = _prefixId.prefix "SkinConductanceSensor"
    /// <summary>
    ///   <para>rdfs:label : Sleep Detector</para>
    ///   <para>rdfs:comment : A sleep detector sensor which detects whether the human falls asleep or wakes up.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepDetector">iottaxolite:SleepDetector</a>
    /// </summary>
    let SleepDetector = _prefixId.prefix "SleepDetector"
    /// <summary>
    ///   <para>rdfs:label : Sleep Monitor</para>
    ///   <para>rdfs:comment : A sleep monitor sensor which tracks the human sleep state.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepMonitor">iottaxolite:SleepMonitor</a>
    /// </summary>
    let SleepMonitor = _prefixId.prefix "SleepMonitor"
    /// <summary>
    ///   <para>rdfs:label : Sleep Sensor</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepSensor">iottaxolite:SleepSensor</a>
    /// </summary>
    let SleepSensor = _prefixId.prefix "SleepSensor"
    /// <summary>
    ///   <para>rdfs:label : Sleep State</para>
    ///   <para>dc11:description : The event at which a person or animal sleep state has been detected. This could be measured as a Boolean, or labels if the state is not binary</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepState">iottaxolite:SleepState</a>
    /// </summary>
    let SleepState = _prefixId.prefix "SleepState"
    /// <summary>
    ///   <para>rdfs:label : Smoke Detector</para>
    ///   <para>rdfs:comment : Device used to detect if there is a fire or the smoke.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SmokeDetector">iottaxolite:SmokeDetector</a>
    /// </summary>
    let SmokeDetector = _prefixId.prefix "SmokeDetector"
    /// <summary>
    ///   <para>rdfs:label : Snow Chains Actuating Device</para>
    ///   <para>rdfs:comment : The actuator that turn Snow chains on/off.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SnowChains">iottaxolite:SnowChains</a>
    /// </summary>
    let SnowChains = _prefixId.prefix "SnowChains"
    /// <summary>
    ///   <para>rdfs:label : Sodium</para>
    ///   <para>rdfs:comment : Measure of Blood Sodium level.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sodium">iottaxolite:Sodium</a>
    /// </summary>
    let Sodium = _prefixId.prefix "Sodium"
    /// <summary>
    ///   <para>rdfs:label : Soil Humidity</para>
    ///   <para>rdfs:comment : It is the quantity of water contained in a material, such as soil. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumidity">iottaxolite:SoilHumidity</a>
    /// </summary>
    let SoilHumidity = _prefixId.prefix "SoilHumidity"
    /// <summary>
    ///   <para>rdfs:label : Soil Humidity Sensor</para>
    ///   <para>rdfs:comment : Soil Humidity sensor, Soil moisture, Hygrometer are an instrument used for measuring the soil moisture or soil humidity.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumiditySensor">iottaxolite:SoilHumiditySensor</a>
    /// </summary>
    let SoilHumiditySensor = _prefixId.prefix "SoilHumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Soil Moisture Tension</para>
    ///   <para>rdfs:comment : The force per unit area required to remove film water from soil.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilMoistureTension">iottaxolite:SoilMoistureTension</a>
    /// </summary>
    let SoilMoistureTension = _prefixId.prefix "SoilMoistureTension"
    /// <summary>
    ///   <para>rdfs:label : Soil Temperature</para>
    ///   <para>rdfs:comment : Soil temperature is the bulk temperature of the soil, not the surface (skin) temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilTemperature">iottaxolite:SoilTemperature</a>
    /// </summary>
    let SoilTemperature = _prefixId.prefix "SoilTemperature"
    /// <summary>
    ///   <para>rdfs:label : Soil Thermometer</para>
    ///   <para>rdfs:comment : This sensor reports Soil temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilThermometer">iottaxolite:SoilThermometer</a>
    /// </summary>
    let SoilThermometer = _prefixId.prefix "SoilThermometer"
    /// <summary>
    ///   <para>rdfs:label : Solar Radiation Measurement, PAR Measurement (Photosynthetically Active Radiation)</para>
    ///   <para>rdfs:comment : It is the power per unit area received from the Sun in the form of electromagnetic radiation in the wavelength range of the measuring instrument. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiation">iottaxolite:SolarRadiation</a>
    /// </summary>
    let SolarRadiation = _prefixId.prefix "SolarRadiation"
    /// <summary>
    ///   <para>rdfs:label : Solar Radiation Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Solar Radiation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiationSensor">iottaxolite:SolarRadiationSensor</a>
    /// </summary>
    let SolarRadiationSensor = _prefixId.prefix "SolarRadiationSensor"
    /// <summary>
    ///   <para>rdfs:label : Sound, Noise Level</para>
    ///   <para>rdfs:comment : Measure of noise level in the environment</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sound">iottaxolite:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#soundPressure^^xsd:string</para>
    ///   <para>rdfs:label : Sound Pressure Level</para>
    ///   <para>rdfs:comment : Sound pressure level is a logarithmic measure of the RMS sound pressure of a sound relative to a reference value, the threshold of hearing. The reference sound pressure was chosen conventionally to correspond to the quietest sound at 1000 Hz that the human ear can detect (20 uPa). In this case, the specific parameter is measured in an open environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevel">iottaxolite:SoundPressureLevel</a>
    /// </summary>
    let SoundPressureLevel = _prefixId.prefix "SoundPressureLevel"
    /// <summary>
    ///   <para>rdfs:comment : Similar to Sound.</para>
    ///   <para>rdfs:label : Sound Pressure Level Ambient</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevelAmbient">iottaxolite:SoundPressureLevelAmbient</a>
    /// </summary>
    let SoundPressureLevelAmbient = _prefixId.prefix "SoundPressureLevelAmbient"
    /// <summary>
    ///   <para>rdfs:label : Sound Sensor</para>
    ///   <para>rdfs:comment : Sensor used to detect Noise level. It can be Sound Sensor, Noise level Sensor, Volume sensor, Microphone</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSensor">iottaxolite:SoundSensor</a>
    /// </summary>
    let SoundSensor = _prefixId.prefix "SoundSensor"
    /// <summary>
    ///   <para>rdfs:label : Sound Source</para>
    ///   <para>rdfs:comment : Source where the sound originated.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSource">iottaxolite:SoundSource</a>
    /// </summary>
    let SoundSource = _prefixId.prefix "SoundSource"
    /// <summary>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : Environmental Origin of a particular observation. With respect to one kind of Source (Sound source), it can be coming from traffic, siren of a police car, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Source">iottaxolite:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#speed^^xsd:string</para>
    ///   <para>rdfs:label : Speed</para>
    ///   <para>rdfs:comment : The rate at which someone or something moves or operates or is able to move or operate.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Speed">iottaxolite:Speed</a>
    /// </summary>
    let Speed = _prefixId.prefix "Speed"
    /// <summary>
    ///   <para>rdfs:label : Speed Average</para>
    ///   <para>rdfs:comment : A measure of the average rate of motion of an object.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedAverage">iottaxolite:SpeedAverage</a>
    /// </summary>
    let SpeedAverage = _prefixId.prefix "SpeedAverage"
    /// <summary>
    ///   <para>rdfs:label : Speed Instantaneous</para>
    ///   <para>rdfs:comment : A measure of the instantaneous rate of motion of an object.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedInstantaneous">iottaxolite:SpeedInstantaneous</a>
    /// </summary>
    let SpeedInstantaneous = _prefixId.prefix "SpeedInstantaneous"
    /// <summary>
    ///   <para>rdfs:label : Speed Median</para>
    ///   <para>rdfs:comment : A measure of the median rate of motion of an object.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedMedian">iottaxolite:SpeedMedian</a>
    /// </summary>
    let SpeedMedian = _prefixId.prefix "SpeedMedian"
    /// <summary>
    ///   <para>rdfs:label : Speed Sensor</para>
    ///   <para>rdfs:comment : Sensor used to detect speed.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedSensor">iottaxolite:SpeedSensor</a>
    /// </summary>
    let SpeedSensor = _prefixId.prefix "SpeedSensor"
    /// <summary>
    ///   <para>rdfs:label : Staying People Count Sensor</para>
    ///   <para>rdfs:comment : Device used to count the number of people that stays within an area for more than a threshold of time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#StayingPeopleCountSensor">iottaxolite:StayingPeopleCountSensor</a>
    /// </summary>
    let StayingPeopleCountSensor = _prefixId.prefix "StayingPeopleCountSensor"
    /// <summary>
    ///   <para>rdfs:label : Step</para>
    ///   <para>rdfs:comment : It is a measure of number of Step taken.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Step">iottaxolite:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Direction</para>
    ///   <para>rdfs:comment : The position of the Sun in the sky is a function of both time and the geographic coordinates of the observer on the surface of the Earth. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirection">iottaxolite:SunPositionDirection</a>
    /// </summary>
    let SunPositionDirection = _prefixId.prefix "SunPositionDirection"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Direction Sensor</para>
    ///   <para>rdfs:comment : Sensor used to detect sun position.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirectionSensor">iottaxolite:SunPositionDirectionSensor</a>
    /// </summary>
    let SunPositionDirectionSensor = _prefixId.prefix "SunPositionDirectionSensor"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Elevation</para>
    ///   <para>rdfs:comment : It is the altitude of the sun, the angle between the horizon and the centre of the sun's disc.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevation">iottaxolite:SunPositionElevation</a>
    /// </summary>
    let SunPositionElevation = _prefixId.prefix "SunPositionElevation"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Elevation Sensor</para>
    ///   <para>rdfs:comment : Device used to detect sun elevation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevationSensor">iottaxolite:SunPositionElevationSensor</a>
    /// </summary>
    let SunPositionElevationSensor = _prefixId.prefix "SunPositionElevationSensor"
    /// <summary>
    ///   <para>rdfs:label : Systolic Blood Pressure</para>
    ///   <para>rdfs:comment : It is the pressure when the heart beats while pumping blood.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#SystolicBloodPressure">iottaxolite:SystolicBloodPressure</a>
    /// </summary>
    let SystolicBloodPressure = _prefixId.prefix "SystolicBloodPressure"
    /// <summary>
    ///   <para>rdfs:label : TV Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the television.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TV">iottaxolite:TV</a>
    /// </summary>
    let TV = _prefixId.prefix "TV"
    /// <summary>
    ///   <para>rdfs:label : Telephone Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the Telephone.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Telephone">iottaxolite:Telephone</a>
    /// </summary>
    let Telephone = _prefixId.prefix "Telephone"
    /// <summary>
    ///   <para>rdfs:label : Temperature</para>
    ///   <para>rdfs:comment : It is the air temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Temperature">iottaxolite:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : Temperature Engine</para>
    ///   <para>rdfs:comment : The temperature of a vehicle engine.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureEngine">iottaxolite:TemperatureEngine</a>
    /// </summary>
    let TemperatureEngine = _prefixId.prefix "TemperatureEngine"
    /// <summary>
    ///   <para>rdfs:label : Temperature Waste Container</para>
    ///   <para>rdfs:comment : The temperature of the air that would be indicated by a thermometer exposed to the air inside a waste container.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureWasteContainer">iottaxolite:TemperatureWasteContainer</a>
    /// </summary>
    let TemperatureWasteContainer = _prefixId.prefix "TemperatureWasteContainer"
    /// <summary>
    ///   <para>rdfs:label : Tesla</para>
    ///   <para>rdfs:comment : It is the SI unit of magnetic flux density.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tesla">iottaxolite:Tesla</a>
    /// </summary>
    let Tesla = _prefixId.prefix "Tesla"
    /// <summary>
    ///   <para>rdfs:label : Thermometer</para>
    ///   <para>rdfs:comment : A device to measure the temperature in a room or outside.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Thermometer">iottaxolite:Thermometer</a>
    /// </summary>
    let Thermometer = _prefixId.prefix "Thermometer"
    /// <summary>
    ///   <para>rdfs:label : Throttle Position Sensor</para>
    ///   <para>rdfs:comment : It is a device used to monitor the throttle position of a vehicle.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#ThrottleSensor">iottaxolite:ThrottleSensor</a>
    /// </summary>
    let ThrottleSensor = _prefixId.prefix "ThrottleSensor"
    /// <summary>
    ///   <para>rdfs:label : Time of arrival</para>
    ///   <para>rdfs:comment : Estimated time till an object is arriving to a specific location (typically used in transportation).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrival">iottaxolite:TimeOfArrival</a>
    /// </summary>
    let TimeOfArrival = _prefixId.prefix "TimeOfArrival"
    /// <summary>
    ///   <para>rdfs:label : Time of arrival for the next bus</para>
    ///   <para>rdfs:comment : Estimated time (in seconds) till a bus will arrive at a specific bus stop. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBus">iottaxolite:TimeOfArrivalNextBus</a>
    /// </summary>
    let TimeOfArrivalNextBus = _prefixId.prefix "TimeOfArrivalNextBus"
    /// <summary>
    ///   <para>rdfs:label : Time of arrival sensor for the next bus</para>
    ///   <para>rdfs:comment : Virtual device that represents a bus stop X and a bus line Y; it estimates the remaining time the next bus (belonging to line Y) will arrive at bus stop X. </para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBusSensor">iottaxolite:TimeOfArrivalNextBusSensor</a>
    /// </summary>
    let TimeOfArrivalNextBusSensor = _prefixId.prefix "TimeOfArrivalNextBusSensor"
    /// <summary>
    ///   <para>rdfs:label : Time of Arrival Sensor</para>
    ///   <para>rdfs:comment : Virtual device that estimates the remaining time for an object to arrive at a specific location.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalSensor">iottaxolite:TimeOfArrivalSensor</a>
    /// </summary>
    let TimeOfArrivalSensor = _prefixId.prefix "TimeOfArrivalSensor"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether a person (or object) has overpassed a particular time threshold (e.g. maximum number of hours driving, etc.)</para>
    ///   <para>rdfs:label : Time Related State</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedState">iottaxolite:TimeRelatedState</a>
    /// </summary>
    let TimeRelatedState = _prefixId.prefix "TimeRelatedState"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether the driver of a vehicle approaches or exceeds his/her working time limits.</para>
    ///   <para>rdfs:label : Time Related State Driver</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriver">iottaxolite:TimeRelatedStateDriver</a>
    /// </summary>
    let TimeRelatedStateDriver = _prefixId.prefix "TimeRelatedStateDriver"
    /// <summary>
    ///   <para>rdfs:label : Time Related State Driver 1</para>
    ///   <para>rdfs:comment : Indicates if the first driver approaches or exceeds working time limits (or other limits).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverOne">iottaxolite:TimeRelatedStateDriverOne</a>
    /// </summary>
    let TimeRelatedStateDriverOne = _prefixId.prefix "TimeRelatedStateDriverOne"
    /// <summary>
    ///   <para>rdfs:label : Time Related State Driver 2</para>
    ///   <para>rdfs:comment : Indicates if the second driver approaches or exceeds working time limits (or other limits).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverTwo">iottaxolite:TimeRelatedStateDriverTwo</a>
    /// </summary>
    let TimeRelatedStateDriverTwo = _prefixId.prefix "TimeRelatedStateDriverTwo"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://sweet.jpl.nasa.gov/2.3/propTime.owl#Timestamp^^xsd:string</para>
    ///   <para>rdfs:label : Timestamp</para>
    ///   <para>rdfs:comment : Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Timestamp">iottaxolite:Timestamp</a>
    /// </summary>
    let Timestamp = _prefixId.prefix "Timestamp"
    /// <summary>
    ///   <para>rdfs:label : Tonne</para>
    ///   <para>rdfs:comment : It is a non-SI metric unit of mass equal to 1,000 kilograms.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tonne">iottaxolite:Tonne</a>
    /// </summary>
    let Tonne = _prefixId.prefix "Tonne"
    /// <summary>
    ///   <para>rdfs:label : Touch Sensor</para>
    ///   <para>rdfs:comment : Device that captures and records physical touch or embrace on a device and/or object.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TouchSensor">iottaxolite:TouchSensor</a>
    /// </summary>
    let TouchSensor = _prefixId.prefix "TouchSensor"
    /// <summary>
    ///   <para>rdfs:label : Tourism DOI</para>
    ///   <para>rdfs:comment : Tourism as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tourism">iottaxolite:Tourism</a>
    /// </summary>
    let Tourism = _prefixId.prefix "Tourism"
    /// <summary>
    ///   <para>rdfs:label : Traffic</para>
    ///   <para>rdfs:comment : When the source of the sound was traffic.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Traffic">iottaxolite:Traffic</a>
    /// </summary>
    let Traffic = _prefixId.prefix "Traffic"
    /// <summary>
    ///   <para>rdfs:label : Traffic Intensity</para>
    ///   <para>rdfs:comment : The intensity of a traffic flow is the number of vehicles passing a cross section of a road in a unit of time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#TrafficIntensity">iottaxolite:TrafficIntensity</a>
    /// </summary>
    let TrafficIntensity = _prefixId.prefix "TrafficIntensity"
    /// <summary>
    ///   <para>rdfs:label : Transportation DOI</para>
    ///   <para>rdfs:comment : Transportation, Smart Car/Vehicle, Intelligent Transport System (ITS) as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Transportation">iottaxolite:Transportation</a>
    /// </summary>
    let Transportation = _prefixId.prefix "Transportation"
    /// <summary>
    ///   <para>rdfs:label : Ultrasonic Sensor</para>
    ///   <para>rdfs:comment : Ultrasonic sensors are used to deduce human posture in smart home for example.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#UltrasonicSensor">iottaxolite:UltrasonicSensor</a>
    /// </summary>
    let UltrasonicSensor = _prefixId.prefix "UltrasonicSensor"
    /// <summary>
    ///   <para>rdfs:label : Volatile Organic Compound (VOC) Sensor</para>
    ///   <para>rdfs:comment : Sensor that detects levels of Volatile Organic Components (VOC) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VOCSensor">iottaxolite:VOCSensor</a>
    /// </summary>
    let VOCSensor = _prefixId.prefix "VOCSensor"
    /// <summary>
    ///   <para>rdfs:label : Vehicle Count Sensor</para>
    ///   <para>rdfs:comment : Device used to count the number of vehicles (e.g., used within the Citypulse project).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleCountSensor">iottaxolite:VehicleCountSensor</a>
    /// </summary>
    let VehicleCountSensor = _prefixId.prefix "VehicleCountSensor"
    /// <summary>
    ///   <para>rdfs:label : Vehicle Overspeed State</para>
    ///   <para>rdfs:comment : Measure to indicates whether the vehicle is exceeding the legal speed limit.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleOverspeedState">iottaxolite:VehicleOverspeedState</a>
    /// </summary>
    let VehicleOverspeedState = _prefixId.prefix "VehicleOverspeedState"
    /// <summary>
    ///   <para>rdfs:label :  Vehicle Presence Detector</para>
    ///   <para>rdfs:comment : Device used to detect if an vehicle is present at a place.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclePresenceDetector">iottaxolite:VehiclePresenceDetector</a>
    /// </summary>
    let VehiclePresenceDetector = _prefixId.prefix "VehiclePresenceDetector"
    /// <summary>
    ///   <para>rdfs:label : Vehicles Per Minute</para>
    ///   <para>rdfs:comment : Number of vehicles that traverse a concrete region of the space in one minute.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclesPerMinute">iottaxolite:VehiclesPerMinute</a>
    /// </summary>
    let VehiclesPerMinute = _prefixId.prefix "VehiclesPerMinute"
    /// <summary>
    ///   <para>rdfs:label : Ventilation Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the ventilation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ventilation">iottaxolite:Ventilation</a>
    /// </summary>
    let Ventilation = _prefixId.prefix "Ventilation"
    /// <summary>
    ///   <para>rdfs:label : Visibility</para>
    ///   <para>rdfs:comment : The state of being able to see or be seen.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Visibility">iottaxolite:Visibility</a>
    /// </summary>
    let Visibility = _prefixId.prefix "Visibility"
    /// <summary>
    ///   <para>rdfs:label : Visibility Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Visibility.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VisibilitySensor">iottaxolite:VisibilitySensor</a>
    /// </summary>
    let VisibilitySensor = _prefixId.prefix "VisibilitySensor"
    /// <summary>
    ///   <para>rdfs:label : Voice Command</para>
    ///   <para>rdfs:comment : A voice command to control a voice controlled system or environment, such as a smart home.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommand">iottaxolite:VoiceCommand</a>
    /// </summary>
    let VoiceCommand = _prefixId.prefix "VoiceCommand"
    /// <summary>
    ///   <para>rdfs:label : Voice Command Controller</para>
    ///   <para>rdfs:comment : An actuating device called  that allows to semi-control the environment of the Voice Command Sensor.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandController">iottaxolite:VoiceCommandController</a>
    /// </summary>
    let VoiceCommandController = _prefixId.prefix "VoiceCommandController"
    /// <summary>
    ///   <para>rdfs:label : Voice Command Sensor</para>
    ///   <para>rdfs:comment : Sensor that uses automatic speech recognition technology to match or reject a recorded voice command according to a specified set of available voice commands.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandSensor">iottaxolite:VoiceCommandSensor</a>
    /// </summary>
    let VoiceCommandSensor = _prefixId.prefix "VoiceCommandSensor"
    /// <summary>
    ///   <para>rdfs:label : Volt</para>
    ///   <para>rdfs:comment : The SI unit of electromotive force, the difference of potential that would carry one ampere of current against one ohm resistance.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Volt">iottaxolite:Volt</a>
    /// </summary>
    let Volt = _prefixId.prefix "Volt"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#var^^xsd:string</para>
    ///   <para>rdfs:label : Volt Ampere Reactive, VAR</para>
    ///   <para>rdfs:comment : In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltAmpereReactive">iottaxolite:VoltAmpereReactive</a>
    /// </summary>
    let VoltAmpereReactive = _prefixId.prefix "VoltAmpereReactive"
    /// <summary>
    ///   <para>rdfs:label : Voltage</para>
    ///   <para>rdfs:comment : An electromotive force or potential difference expressed in volts (Source Google).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Voltage">iottaxolite:Voltage</a>
    /// </summary>
    let Voltage = _prefixId.prefix "Voltage"
    /// <summary>
    ///   <para>rdfs:label : Voltage Sensor</para>
    ///   <para>rdfs:comment : Device which can measure the difference in electric potential energy between two points per unit electric charge.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltageSensor">iottaxolite:VoltageSensor</a>
    /// </summary>
    let VoltageSensor = _prefixId.prefix "VoltageSensor"
    /// <summary>
    ///   <para>rdfs:label : Washing Machine Actuation Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the washing machine.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WashingMachine">iottaxolite:WashingMachine</a>
    /// </summary>
    let WashingMachine = _prefixId.prefix "WashingMachine"
    /// <summary>
    ///   <para>rdfs:label : Water Conductivity Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the conductivity of water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterConductivitySensor">iottaxolite:WaterConductivitySensor</a>
    /// </summary>
    let WaterConductivitySensor = _prefixId.prefix "WaterConductivitySensor"
    /// <summary>
    ///   <para>rdfs:label : Water Level</para>
    ///   <para>rdfs:comment : The height reached by the water in a reservoir, river, storage tank, or similar.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterLevel">iottaxolite:WaterLevel</a>
    /// </summary>
    let WaterLevel = _prefixId.prefix "WaterLevel"
    /// <summary>
    ///   <para>rdfs:label : Water NH4 Ion Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure NH4 concentration level in the water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNH4IonSensor">iottaxolite:WaterNH4IonSensor</a>
    /// </summary>
    let WaterNH4IonSensor = _prefixId.prefix "WaterNH4IonSensor"
    /// <summary>
    ///   <para>rdfs:label : Water NO3 Ion Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure NO3 concentration level in the water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNO3IonSensor">iottaxolite:WaterNO3IonSensor</a>
    /// </summary>
    let WaterNO3IonSensor = _prefixId.prefix "WaterNO3IonSensor"
    /// <summary>
    ///   <para>rdfs:label : Water O2 Ion Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure O2 concentration level in the water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterO2IonSensor">iottaxolite:WaterO2IonSensor</a>
    /// </summary>
    let WaterO2IonSensor = _prefixId.prefix "WaterO2IonSensor"
    /// <summary>
    ///   <para>rdfs:label : Water PH Sensor</para>
    ///   <para>rdfs:comment : Device used to detect PH level of water.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterPHSensor">iottaxolite:WaterPHSensor</a>
    /// </summary>
    let WaterPHSensor = _prefixId.prefix "WaterPHSensor"
    /// <summary>
    ///   <para>rdfs:label : Water Temperature</para>
    ///   <para>rdfs:comment : Sea surface temperature (SST) is the water temperature close to the ocean's surface.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterTemperature">iottaxolite:WaterTemperature</a>
    /// </summary>
    let WaterTemperature = _prefixId.prefix "WaterTemperature"
    /// <summary>
    ///   <para>rdfs:label : Water Thermometer</para>
    ///   <para>rdfs:comment : This sensor reports Water temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterThermometer">iottaxolite:WaterThermometer</a>
    /// </summary>
    let WaterThermometer = _prefixId.prefix "WaterThermometer"
    /// <summary>
    ///   <para>rdfs:label : Watt (W)</para>
    ///   <para>rdfs:comment : It is the SI unit of power, equivalent to one joule per second, corresponding to the rate of consumption of energy in an electric circuit where the potential difference is one volt and the current one ampere.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Watt">iottaxolite:Watt</a>
    /// </summary>
    let Watt = _prefixId.prefix "Watt"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#wattPerSquareMetre^^xsd:string</para>
    ///   <para>rdfs:label : Watt Per Square Metre, Watt Per Square Meter</para>
    ///   <para>rdfs:comment : It is the SI unit for radiative and other energy fluxes.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WattPerSquareMetre">iottaxolite:WattPerSquareMetre</a>
    /// </summary>
    let WattPerSquareMetre = _prefixId.prefix "WattPerSquareMetre"
    /// <summary>
    ///   <para>rdfs:label : Weather Forecasting DOI</para>
    ///   <para>rdfs:comment : Weather Forecasting, Meterology as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weather">iottaxolite:Weather</a>
    /// </summary>
    let Weather = _prefixId.prefix "Weather"
    /// <summary>
    ///   <para>rdfs:label : Weather Luminosity</para>
    ///   <para>rdfs:comment : Luminosity in the weather</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherLuminosity">iottaxolite:WeatherLuminosity</a>
    /// </summary>
    let WeatherLuminosity = _prefixId.prefix "WeatherLuminosity"
    /// <summary>
    ///   <para>rdfs:label : Weather Precipitation</para>
    ///   <para>rdfs:comment : Weather Precipitation.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherPrecipitation">iottaxolite:WeatherPrecipitation</a>
    /// </summary>
    let WeatherPrecipitation = _prefixId.prefix "WeatherPrecipitation"
    /// <summary>
    ///   <para>rdfs:label : Weight</para>
    ///   <para>rdfs:comment : A body's relative mass or the quantity of matter contained by it, giving rise to a downward force; the heaviness of a person or thing.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weight">iottaxolite:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>rdfs:label : Weight Sensor</para>
    ///   <para>rdfs:comment : Device used to weight an object.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeightSensor">iottaxolite:WeightSensor</a>
    /// </summary>
    let WeightSensor = _prefixId.prefix "WeightSensor"
    /// <summary>
    ///   <para>rdfs:label : WiFi Interface Energy Meter</para>
    ///   <para>rdfs:comment : Measure the average power consumption of the WiFi interface nodes.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WiFiInterfaceEnergyMeter">iottaxolite:WiFiInterfaceEnergyMeter</a>
    /// </summary>
    let WiFiInterfaceEnergyMeter = _prefixId.prefix "WiFiInterfaceEnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Wind Chill</para>
    ///   <para>rdfs:comment : The cooling effect of wind blowing on a surface.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChill">iottaxolite:WindChill</a>
    /// </summary>
    let WindChill = _prefixId.prefix "WindChill"
    /// <summary>
    ///   <para>rdfs:label : Wind Chill Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Wind Chill.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChillSensor">iottaxolite:WindChillSensor</a>
    /// </summary>
    let WindChillSensor = _prefixId.prefix "WindChillSensor"
    /// <summary>
    ///   <para>rdfs:label : Wind Direction</para>
    ///   <para>rdfs:comment : The geodetic azimuth of the direction from which the wind is blowing.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirection">iottaxolite:WindDirection</a>
    /// </summary>
    let WindDirection = _prefixId.prefix "WindDirection"
    /// <summary>
    ///   <para>rdfs:label : Wind Direction Sensor</para>
    ///   <para>rdfs:comment : Device used to detect wind direction.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirectionSensor">iottaxolite:WindDirectionSensor</a>
    /// </summary>
    let WindDirectionSensor = _prefixId.prefix "WindDirectionSensor"
    /// <summary>
    ///   <para>rdfs:label : Wind Velocity, Wind Speed</para>
    ///   <para>rdfs:comment : The ratio of the distance covered by moving air to the time quantity taken to cover it.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeed">iottaxolite:WindSpeed</a>
    /// </summary>
    let WindSpeed = _prefixId.prefix "WindSpeed"
    /// <summary>
    ///   <para>rdfs:label : Wind Speed Sensor</para>
    ///   <para>rdfs:comment : Wind Speed Sensor, Anemometer or Wind Velocity Sensor is used to measure the wind speed.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeedSensor">iottaxolite:WindSpeedSensor</a>
    /// </summary>
    let WindSpeedSensor = _prefixId.prefix "WindSpeedSensor"
    /// <summary>
    ///   <para>rdfs:label : Window Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the window.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Window">iottaxolite:Window</a>
    /// </summary>
    let Window = _prefixId.prefix "Window"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether a person (or object) is working or not</para>
    ///   <para>rdfs:label : Working State</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingState">iottaxolite:WorkingState</a>
    /// </summary>
    let WorkingState = _prefixId.prefix "WorkingState"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether the driver of a vehicle is present or not</para>
    ///   <para>rdfs:label : Working State Driver</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriver">iottaxolite:WorkingStateDriver</a>
    /// </summary>
    let WorkingStateDriver = _prefixId.prefix "WorkingStateDriver"
    /// <summary>
    ///   <para>rdfs:label : Working State Driver 1</para>
    ///   <para>rdfs:comment : State of work of the first driver as defined in the FMS standard.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverOne">iottaxolite:WorkingStateDriverOne</a>
    /// </summary>
    let WorkingStateDriverOne = _prefixId.prefix "WorkingStateDriverOne"
    /// <summary>
    ///   <para>rdfs:label : Working State Driver 2</para>
    ///   <para>rdfs:comment : State of work of the second driver as defined in the FMS standard.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverTwo">iottaxolite:WorkingStateDriverTwo</a>
    /// </summary>
    let WorkingStateDriverTwo = _prefixId.prefix "WorkingStateDriverTwo"
    /// <summary>
    ///   <para>rdfs:label : W/out</para>
    ///   <para>rdfs:comment : This unit is used to measure delta dew point. Natural number (W/out unit).</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Wout">iottaxolite:Wout</a>
    /// </summary>
    let Wout = _prefixId.prefix "Wout"
    /// <summary>
    ///   <para>rdfs:label : Year</para>
    ///   <para>rdfs:comment : Year as a unit of time.</para>
    ///   <a href="http://purl.org/iot/vocab/iot-taxonomy-lite#Year">iottaxolite:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
