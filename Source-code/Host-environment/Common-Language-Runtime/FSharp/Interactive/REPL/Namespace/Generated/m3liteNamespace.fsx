#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module m3lite =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/iot/vocab/m3-lite#" "m3lite"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ABS (Anti-lock Braking System) Actuating Device</para>
    ///   <para>rdfs:comment : The ABS (Anti-lock Braking System) receives information from ABS computer to control the pressure on the breaks, This helps the wheels not to get locked up, it adjust the break pressure and prevents the wheels from locking. (Definition Source Google).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ABS">m3lite:ABS</a>
    /// </summary>
    let ABS = _prefixId.prefix "ABS"
    /// <summary>
    ///   <para>rdfs:label : Initial E-RAB Establishment Success Rate</para>
    ///   <para>rdfs:comment : Initial E-UTRAN Radio Access Bearer establishment success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AccInitialERabEstabSuccRate">m3lite:AccInitialERabEstabSuccRate</a>
    /// </summary>
    let AccInitialERabEstabSuccRate = _prefixId.prefix "AccInitialERabEstabSuccRate"
    /// <summary>
    ///   <para>rdfs:label : Initial E-RAB Setup Success Rate</para>
    ///   <para>rdfs:comment : Initial E-UTRAN Radio Access Bearer setup success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AccInitialERabSetupSuccRate">m3lite:AccInitialERabSetupSuccRate</a>
    /// </summary>
    let AccInitialERabSetupSuccRate = _prefixId.prefix "AccInitialERabSetupSuccRate"
    /// <summary>
    ///   <para>rdfs:label : RRC Connection Setup Success Rate</para>
    ///   <para>rdfs:comment : Radio Resource Control connection setup success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AccRrcConnSetupSuccRate">m3lite:AccRrcConnSetupSuccRate</a>
    /// </summary>
    let AccRrcConnSetupSuccRate = _prefixId.prefix "AccRrcConnSetupSuccRate"
    /// <summary>
    ///   <para>rdfs:label : S1 Signalling Establishment Success Rate</para>
    ///   <para>rdfs:comment : S1 (S1 standardized interface between eNB and Evolved Packet Core) signalling establishment success rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AccS1SigEstabSuccRate">m3lite:AccS1SigEstabSuccRate</a>
    /// </summary>
    let AccS1SigEstabSuccRate = _prefixId.prefix "AccS1SigEstabSuccRate"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/dim#Acceleration^^xsd:string</para>
    ///   <para>rdfs:label : Acceleration</para>
    ///   <para>rdfs:comment : The rate of change of the velocity of a particle with respect to time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Acceleration">m3lite:Acceleration</a>
    /// </summary>
    let Acceleration = _prefixId.prefix "Acceleration"
    /// <summary>
    ///   <para>rdfs:comment : The acceleration at a given instant of time.</para>
    ///   <para>rdfs:label : Instantaneous Acceleration</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AccelerationInstantaneous">m3lite:AccelerationInstantaneous</a>
    /// </summary>
    let AccelerationInstantaneous = _prefixId.prefix "AccelerationInstantaneous"
    /// <summary>
    ///   <para>rdfs:label : Accelerometer</para>
    ///   <para>rdfs:comment :  Accelerometers are used to automatically determine the orientation in which the user is holding the IoT Object (portrait or landscape).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Accelerometer">m3lite:Accelerometer</a>
    /// </summary>
    let Accelerometer = _prefixId.prefix "Accelerometer"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#activePower^^xsd:string</para>
    ///   <para>rdfs:label : Active Power</para>
    ///   <para>rdfs:comment : The product of the voltage across a branch of an alternating-current circuit and the component of the electric current that is in phase with the voltage.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ActivePower">m3lite:ActivePower</a>
    /// </summary>
    let ActivePower = _prefixId.prefix "ActivePower"
    /// <summary>
    ///   <para>rdfs:label : Agriculture DOI</para>
    ///   <para>rdfs:comment : Agriculture, Smart farm as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Agriculture">m3lite:Agriculture</a>
    /// </summary>
    let Agriculture = _prefixId.prefix "Agriculture"
    /// <summary>
    ///   <para>rdfs:label : Air Conditioner Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the air conditioner.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirConditioner">m3lite:AirConditioner</a>
    /// </summary>
    let AirConditioner = _prefixId.prefix "AirConditioner"
    /// <summary>
    ///   <para>rdfs:label : Air Humidity Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure air humidity.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirHumiditySensor">m3lite:AirHumiditySensor</a>
    /// </summary>
    let AirHumiditySensor = _prefixId.prefix "AirHumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Air Pollutant Sensor</para>
    ///   <para>rdfs:comment : Air Pollutant Sensor are devices that detect and monitor the presence of air pollution in the surrounding area (source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirPollutantSensor">m3lite:AirPollutantSensor</a>
    /// </summary>
    let AirPollutantSensor = _prefixId.prefix "AirPollutantSensor"
    /// <summary>
    ///   <para>rdfs:label : Air Pollution Quantity Kind</para>
    ///   <para>rdfs:comment : Usually measured using Air Quality Index (AQI), it is the measure of Air Pollution in the environment. It is similar to Air Quality.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirPollution">m3lite:AirPollution</a>
    /// </summary>
    let AirPollution = _prefixId.prefix "AirPollution"
    /// <summary>
    ///   <para>rdfs:label : Air Quality Quantity Kind</para>
    ///   <para>rdfs:comment : Usually measured using an air quality index (AQI) that is a number used by government agencies to communicate to the public how polluted the air currently is or how polluted it is forecast to become. Different countries have their own air quality indices, corresponding to different national air quality standards. It is the measure of Air Quality of the environment. It is similar to Air Pollution. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirQuality">m3lite:AirQuality</a>
    /// </summary>
    let AirQuality = _prefixId.prefix "AirQuality"
    /// <summary>
    ///   <para>rdfs:label : Air Temperature, Weather Temperature, Ambient Temperature</para>
    ///   <para>rdfs:comment : The temperature of the air that would be indicated by a thermometer exposed to the air at a location sheltered from direct solar radiation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirTemperature">m3lite:AirTemperature</a>
    /// </summary>
    let AirTemperature = _prefixId.prefix "AirTemperature"
    /// <summary>
    ///   <para>rdfs:label : Air Thermometer</para>
    ///   <para>rdfs:comment : Device to measure the Air temperature of either indoor or outdoor atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AirThermometer">m3lite:AirThermometer</a>
    /// </summary>
    let AirThermometer = _prefixId.prefix "AirThermometer"
    /// <summary>
    ///   <para>rdfs:label : Alarm System Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the alarm system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AlarmSystem">m3lite:AlarmSystem</a>
    /// </summary>
    let AlarmSystem = _prefixId.prefix "AlarmSystem"
    /// <summary>
    ///   <para>rdfs:label : Alcohol Level Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Alcohol Level in the system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AlcoholLevel">m3lite:AlcoholLevel</a>
    /// </summary>
    let AlcoholLevel = _prefixId.prefix "AlcoholLevel"
    /// <summary>
    ///   <para>rdfs:label : Alcohol Level Sensor</para>
    ///   <para>rdfs:comment : Device used to detect and measure Alcohol Level in the system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AlcoholLevelSensor">m3lite:AlcoholLevelSensor</a>
    /// </summary>
    let AlcoholLevelSensor = _prefixId.prefix "AlcoholLevelSensor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#ampere^^xsd:string</para>
    ///   <para>rdfs:label : Ampere (A)</para>
    ///   <para>rdfs:comment : The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Ampere">m3lite:Ampere</a>
    /// </summary>
    let Ampere = _prefixId.prefix "Ampere"
    /// <summary>
    ///   <para>rdfs:label : Angular Speed</para>
    ///   <para>rdfs:comment : It is the rate of change of angular displacement and is a vector quantity (more precisely, a pseudovector) that specifies the angular speed (rotational speed) of an object and the axis about which the object is rotating. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AngularSpeed">m3lite:AngularSpeed</a>
    /// </summary>
    let AngularSpeed = _prefixId.prefix "AngularSpeed"
    /// <summary>
    ///   <para>rdfs:label : Animals as Sound Source</para>
    ///   <para>rdfs:comment : when the source of the sound were animals.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Animals">m3lite:Animals</a>
    /// </summary>
    let Animals = _prefixId.prefix "Animals"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#atmosphericPressure^^xsd:string</para>
    ///   <para>rdfs:label : Atmospheric Pressure</para>
    ///   <para>rdfs:comment : The pressure exerted by the atmosphere as a consequence of gravitational attraction exerted upon the column of air lying directly above the point in question.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AtmosphericPressure">m3lite:AtmosphericPressure</a>
    /// </summary>
    let AtmosphericPressure = _prefixId.prefix "AtmosphericPressure"
    /// <summary>
    ///   <para>rdfs:label : Atmospheric Pressure Sensor</para>
    ///   <para>rdfs:comment : Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used in meteorology to measure atmospheric pressure.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AtmosphericPressureSensor">m3lite:AtmosphericPressureSensor</a>
    /// </summary>
    let AtmosphericPressureSensor = _prefixId.prefix "AtmosphericPressureSensor"
    /// <summary>
    ///   <para>rdfs:label : Automatic Measurement Type</para>
    ///   <para>rdfs:comment : When the devices are set to take the observations Automatically without any external aid.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#AutomaticSensing">m3lite:AutomaticSensing</a>
    /// </summary>
    let AutomaticSensing = _prefixId.prefix "AutomaticSensing"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/unit#Bar^^xsd:string</para>
    ///   <para>rdfs:label : Bar</para>
    ///   <para>rdfs:comment : Metric unit of atmospheric pressure equal to 14.50 pounds per square inch (lb/in2), 1.02 kilograms per square centimetre (kg/cm2), 29.53 inches of mercury (in Hg), or 0.9869 atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Bar">m3lite:Bar</a>
    /// </summary>
    let Bar = _prefixId.prefix "Bar"
    /// <summary>
    ///   <para>rdfs:label : Barcode Tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be Barcode.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Barcode">m3lite:Barcode</a>
    /// </summary>
    let Barcode = _prefixId.prefix "Barcode"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://www.w3.org/2007/uwa/context/deliveryContext.owl#BatteryLevel^^xsd:string</para>
    ///   <para>rdfs:label : Battery Level Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of the percentage of the battery capacity that remains available.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BatteryLevel">m3lite:BatteryLevel</a>
    /// </summary>
    let BatteryLevel = _prefixId.prefix "BatteryLevel"
    /// <summary>
    ///   <para>rdfs:label : Beat Per Minute (bpm)</para>
    ///   <para>rdfs:comment : Beat Per Minute (bpm) is the unit to measure heart rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BeatPerMinute">m3lite:BeatPerMinute</a>
    /// </summary>
    let BeatPerMinute = _prefixId.prefix "BeatPerMinute"
    /// <summary>
    ///   <para>rdfs:label : Blind Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the window blinds.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Blind">m3lite:Blind</a>
    /// </summary>
    let Blind = _prefixId.prefix "Blind"
    /// <summary>
    ///   <para>rdfs:label : Blood Glucose Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Blood glucose level or blood sugar level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BloodGlucose">m3lite:BloodGlucose</a>
    /// </summary>
    let BloodGlucose = _prefixId.prefix "BloodGlucose"
    /// <summary>
    ///   <para>rdfs:label : Blood Pressure</para>
    ///   <para>rdfs:comment : Measure of the pressure in your blood vessels when your heart rests between beats.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BloodPressure">m3lite:BloodPressure</a>
    /// </summary>
    let BloodPressure = _prefixId.prefix "BloodPressure"
    /// <summary>
    ///   <para>rdfs:label : Blood Pressure Sensor</para>
    ///   <para>rdfs:comment : Device used to measure Blood Pressure.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BloodPressureSensor">m3lite:BloodPressureSensor</a>
    /// </summary>
    let BloodPressureSensor = _prefixId.prefix "BloodPressureSensor"
    /// <summary>
    ///   <para>rdfs:label : Board Temperature</para>
    ///   <para>rdfs:comment : Measure of board temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BoardTemperature">m3lite:BoardTemperature</a>
    /// </summary>
    let BoardTemperature = _prefixId.prefix "BoardTemperature"
    /// <summary>
    ///   <para>rdfs:label : Board Thermometer</para>
    ///   <para>rdfs:comment : Device used to measure board temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BoardThermometer">m3lite:BoardThermometer</a>
    /// </summary>
    let BoardThermometer = _prefixId.prefix "BoardThermometer"
    /// <summary>
    ///   <para>rdfs:label : Board Voltage Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure board input voltage.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BoardVoltageSensor">m3lite:BoardVoltageSensor</a>
    /// </summary>
    let BoardVoltageSensor = _prefixId.prefix "BoardVoltageSensor"
    /// <summary>
    ///   <para>rdfs:label : Body Temperature</para>
    ///   <para>rdfs:comment : Measure of body temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BodyTemperature">m3lite:BodyTemperature</a>
    /// </summary>
    let BodyTemperature = _prefixId.prefix "BodyTemperature"
    /// <summary>
    ///   <para>rdfs:label : Body Thermometer</para>
    ///   <para>rdfs:comment : Device used to measure body temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BodyThermometer">m3lite:BodyThermometer</a>
    /// </summary>
    let BodyThermometer = _prefixId.prefix "BodyThermometer"
    /// <summary>
    ///   <para>rdfs:label : Boiler Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the boiler.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Boiler">m3lite:Boiler</a>
    /// </summary>
    let Boiler = _prefixId.prefix "Boiler"
    /// <summary>
    ///   <para>rdfs:label : Smart Building DOI</para>
    ///   <para>rdfs:comment : Smart Home/Building Automation as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BuildingAutomation">m3lite:BuildingAutomation</a>
    /// </summary>
    let BuildingAutomation = _prefixId.prefix "BuildingAutomation"
    /// <summary>
    ///   <para>rdfs:label : Building/Room Temperature</para>
    ///   <para>rdfs:comment : Measure of building or room temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#BuildingTemperature">m3lite:BuildingTemperature</a>
    /// </summary>
    let BuildingTemperature = _prefixId.prefix "BuildingTemperature"
    /// <summary>
    ///   <para>rdfs:label : Carbon Dioxide (CO2) Quantity Kind</para>
    ///   <para>rdfs:comment : Carbon Dioxide (CO2) measure in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CO2">m3lite:CO2</a>
    /// </summary>
    let CO2 = _prefixId.prefix "CO2"
    /// <summary>
    ///   <para>rdfs:label : Carbon Dioxide (CO2) Sensor</para>
    ///   <para>rdfs:comment : Carbon Dioxide (CO2) Sensor used to measure level of CO2 in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CO2Sensor">m3lite:CO2Sensor</a>
    /// </summary>
    let CO2Sensor = _prefixId.prefix "CO2Sensor"
    /// <summary>
    ///   <para>rdfs:label : Carbon Monoxide (CO) Sensor</para>
    ///   <para>rdfs:comment : Device to detect Carbon Monoxide (CO) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#COSensor">m3lite:COSensor</a>
    /// </summary>
    let COSensor = _prefixId.prefix "COSensor"
    /// <summary>
    ///   <para>rdfs:label : Calcium Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of blood calcium level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Calcium">m3lite:Calcium</a>
    /// </summary>
    let Calcium = _prefixId.prefix "Calcium"
    /// <summary>
    ///   <para>rdfs:label : Calibration Measurement Type</para>
    ///   <para>rdfs:comment : If the measurement was taken when the sensor was being calibrated.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CalibrationSensing">m3lite:CalibrationSensing</a>
    /// </summary>
    let CalibrationSensing = _prefixId.prefix "CalibrationSensing"
    /// <summary>
    ///   <para>rdfs:label : Candela</para>
    ///   <para>rdfs:comment : Candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 10^12 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Candela">m3lite:Candela</a>
    /// </summary>
    let Candela = _prefixId.prefix "Candela"
    /// <summary>
    ///   <para>rdfs:label : Capacitance</para>
    ///   <para>rdfs:comment : Measure of the ability of a system to store an electric charge.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Capacitance">m3lite:Capacitance</a>
    /// </summary>
    let Capacitance = _prefixId.prefix "Capacitance"
    /// <summary>
    ///   <para>rdfs:label : Centibar</para>
    ///   <para>rdfs:comment : The centibar is a unit of pressure defined as 1e-2 bar.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Centibar">m3lite:Centibar</a>
    /// </summary>
    let Centibar = _prefixId.prefix "Centibar"
    /// <summary>
    ///   <para>rdfs:comment : A metric unit of length, equal to one hundredth of a metre.</para>
    ///   <para>rdfs:label : Centimetre, Centimeter</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Centimetre">m3lite:Centimetre</a>
    /// </summary>
    let Centimetre = _prefixId.prefix "Centimetre"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Atmospheric Concentration Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Chemical Agent Atmospheric Concentration</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentration">m3lite:ChemicalAgentAtmosphericConcentration</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentration =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentration"

    /// <summary>
    ///   <para>rdfs:label : Air Particles Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of chemical particles suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationAirParticles">m3lite:ChemicalAgentAtmosphericConcentrationAirParticles</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationAirParticles =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationAirParticles"

    /// <summary>
    ///   <para>rdfs:label : Carbon Monoxide (CO) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationCO">m3lite:ChemicalAgentAtmosphericConcentrationCO</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationCO =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationCO"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Atmospheric Concentration Dust</para>
    ///   <para>rdfs:comment : Measure of the concentration of dust suspended in the air.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationDust">m3lite:ChemicalAgentAtmosphericConcentrationDust</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationDust =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationDust"

    /// <summary>
    ///   <para>rdfs:label : Nitrogen Monoxide (NO) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationNO">m3lite:ChemicalAgentAtmosphericConcentrationNO</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationNO =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationNO"

    /// <summary>
    ///   <para>rdfs:label : NO2 Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of NO2 gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationNO2">m3lite:ChemicalAgentAtmosphericConcentrationNO2</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationNO2 =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationNO2"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Atmospheric Concentration O3</para>
    ///   <para>rdfs:comment : The concentration of ozone (O3) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationO3">m3lite:ChemicalAgentAtmosphericConcentrationO3</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationO3 =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationO3"

    /// <summary>
    ///   <para>rdfs:label : Sulphur dioxide (SO2) Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Sulphur dioxide (SO2) gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationSO2">m3lite:ChemicalAgentAtmosphericConcentrationSO2</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationSO2 =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationSO2"

    /// <summary>
    ///   <para>rdfs:label : Volatile Organic Compound Chemical Agent Atmospheric Concentration</para>
    ///   <para>rdfs:comment : Measure of the concentration of Volatile Organic Compound gas suspended in the atmosphere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationVOC">m3lite:ChemicalAgentAtmosphericConcentrationVOC</a>
    /// </summary>
    let ChemicalAgentAtmosphericConcentrationVOC =
        _prefixId.prefix "ChemicalAgentAtmosphericConcentrationVOC"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Concentration Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Chemical Agent Concentration</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentConcentration">m3lite:ChemicalAgentConcentration</a>
    /// </summary>
    let ChemicalAgentConcentration = _prefixId.prefix "ChemicalAgentConcentration"

    /// <summary>
    ///   <para>rdfs:label : Chemical Agent Water Concentration Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of Chemical Agent Concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentration">m3lite:ChemicalAgentWaterConcentration</a>
    /// </summary>
    let ChemicalAgentWaterConcentration =
        _prefixId.prefix "ChemicalAgentWaterConcentration"

    /// <summary>
    ///   <para>rdfs:label : Ammonium ion (NH4+) Chemical Agent Water Concentration</para>
    ///   <para>rdfs:comment : Measure of NH4 ion concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationNH4Ion">m3lite:ChemicalAgentWaterConcentrationNH4Ion</a>
    /// </summary>
    let ChemicalAgentWaterConcentrationNH4Ion =
        _prefixId.prefix "ChemicalAgentWaterConcentrationNH4Ion"

    /// <summary>
    ///   <para>rdfs:label : Nitrate Ion (NO3-) Chemical Agent Water Concentration</para>
    ///   <para>rdfs:comment : Measure of NO3 ion concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationNO3Ion">m3lite:ChemicalAgentWaterConcentrationNO3Ion</a>
    /// </summary>
    let ChemicalAgentWaterConcentrationNO3Ion =
        _prefixId.prefix "ChemicalAgentWaterConcentrationNO3Ion"

    /// <summary>
    ///   <para>rdfs:label : Oxygen (O2) Chemical Agent Water Concentration</para>
    ///   <para>rdfs:comment : Measure of O2 concentration in Water </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationO2">m3lite:ChemicalAgentWaterConcentrationO2</a>
    /// </summary>
    let ChemicalAgentWaterConcentrationO2 =
        _prefixId.prefix "ChemicalAgentWaterConcentrationO2"

    /// <summary>
    ///   <para>rdfs:label : Cholesterol Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of the cholesterol level in a system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Cholesterol">m3lite:Cholesterol</a>
    /// </summary>
    let Cholesterol = _prefixId.prefix "Cholesterol"
    /// <summary>
    ///   <para>rdfs:label : Cholesterol Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the cholesterol level in a system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CholesterolSensor">m3lite:CholesterolSensor</a>
    /// </summary>
    let CholesterolSensor = _prefixId.prefix "CholesterolSensor"
    /// <summary>
    ///   <para>rdfs:label : Smart City DOI</para>
    ///   <para>rdfs:comment : Smart City as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#City">m3lite:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : Clock</para>
    ///   <para>rdfs:comment : sensor that measures time</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Clock">m3lite:Clock</a>
    /// </summary>
    let Clock = _prefixId.prefix "Clock"
    /// <summary>
    ///   <para>rdfs:label : Cloud Cover Quantity Kind</para>
    ///   <para>rdfs:comment : Measure of cloud cover at a certain time. </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CloudCover">m3lite:CloudCover</a>
    /// </summary>
    let CloudCover = _prefixId.prefix "CloudCover"
    /// <summary>
    ///   <para>rdfs:label : Cloud Cover Sensor</para>
    ///   <para>rdfs:comment : Cloud Cover Sensor is used to detect whether it is sunny, cloudy, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CloudCoverSensor">m3lite:CloudCoverSensor</a>
    /// </summary>
    let CloudCoverSensor = _prefixId.prefix "CloudCoverSensor"
    /// <summary>
    ///   <para>rdfs:label : Coffee Machine, Coffee Maker Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the coffee machine.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CoffeeMachine">m3lite:CoffeeMachine</a>
    /// </summary>
    let CoffeeMachine = _prefixId.prefix "CoffeeMachine"
    /// <summary>
    ///   <para>rdfs:label : Communication Related Quantity Kind</para>
    ///   <para>rdfs:comment : Communication related properties.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Communication">m3lite:Communication</a>
    /// </summary>
    let Communication = _prefixId.prefix "Communication"
    /// <summary>
    ///   <para>rdfs:label : Computer, PC Actuating Device</para>
    ///   <para>rdfs:comment : Actuating devices for Computer or PC.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Computer">m3lite:Computer</a>
    /// </summary>
    let Computer = _prefixId.prefix "Computer"
    /// <summary>
    ///   <para>rdfs:label : Conductivity</para>
    ///   <para>rdfs:comment : Measure of ability to conduct electricity. It is measured in siemens per metre (S/m).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Conductivity">m3lite:Conductivity</a>
    /// </summary>
    let Conductivity = _prefixId.prefix "Conductivity"
    /// <summary>
    ///   <para>rdfs:label : Conductivity Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the conductivity of a system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ConductivitySensor">m3lite:ConductivitySensor</a>
    /// </summary>
    let ConductivitySensor = _prefixId.prefix "ConductivitySensor"
    /// <summary>
    ///   <para>rdfs:label : Construction Work Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was a construction work.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ConstructionWork">m3lite:ConstructionWork</a>
    /// </summary>
    let ConstructionWork = _prefixId.prefix "ConstructionWork"
    /// <summary>
    ///   <para>rdfs:label : Coordinates</para>
    ///   <para>rdfs:comment : Triples for location in the (Latitude, Longitude, Altitude) format.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Coordinates">m3lite:Coordinates</a>
    /// </summary>
    let Coordinates = _prefixId.prefix "Coordinates"
    /// <summary>
    ///   <para>rdfs:label : Coulomb</para>
    ///   <para>rdfs:comment : SI unit of electric charge.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Coulomb">m3lite:Coulomb</a>
    /// </summary>
    let Coulomb = _prefixId.prefix "Coulomb"
    /// <summary>
    ///   <para>rdfs:label : Count</para>
    ///   <para>rdfs:comment : Number of available particular things.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Count">m3lite:Count</a>
    /// </summary>
    let Count = _prefixId.prefix "Count"
    /// <summary>
    ///   <para>rdfs:label : Count Available Bicycles</para>
    ///   <para>rdfs:comment : Number of available bicycles at a particular bicycle docking station.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CountAvailableBicycles">m3lite:CountAvailableBicycles</a>
    /// </summary>
    let CountAvailableBicycles = _prefixId.prefix "CountAvailableBicycles"
    /// <summary>
    ///   <para>rdfs:label : Count Available Taxis</para>
    ///   <para>rdfs:comment : Number of taxis available at a particular taxi stop.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CountAvailableTaxis">m3lite:CountAvailableTaxis</a>
    /// </summary>
    let CountAvailableTaxis = _prefixId.prefix "CountAvailableTaxis"
    /// <summary>
    ///   <para>rdfs:label : Count Empty Docking Points</para>
    ///   <para>rdfs:comment : Number of empty docking points at a particular bicycle docking station.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#CountEmptyDockingPoints">m3lite:CountEmptyDockingPoints</a>
    /// </summary>
    let CountEmptyDockingPoints = _prefixId.prefix "CountEmptyDockingPoints"
    /// <summary>
    ///   <para>rdfs:label : Counter</para>
    ///   <para>rdfs:comment : Sensors that reckons occurrences or repetitions of physical objects, phenomena or events.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Counter">m3lite:Counter</a>
    /// </summary>
    let Counter = _prefixId.prefix "Counter"
    /// <summary>
    ///   <para>rdfs:label : Crowd Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was crowd.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Crowd">m3lite:Crowd</a>
    /// </summary>
    let Crowd = _prefixId.prefix "Crowd"
    /// <summary>
    ///   <para>rdfs:label : Cupboard Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the cupboard.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Cupboard">m3lite:Cupboard</a>
    /// </summary>
    let Cupboard = _prefixId.prefix "Cupboard"
    /// <summary>
    ///   <para>rdfs:label : Curtain Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the curtain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Curtain">m3lite:Curtain</a>
    /// </summary>
    let Curtain = _prefixId.prefix "Curtain"
    /// <summary>
    ///   <para>rdfs:label : Day</para>
    ///   <para>rdfs:comment : Day is a unit of time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Day">m3lite:Day</a>
    /// </summary>
    let Day = _prefixId.prefix "Day"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#decibel^^xsd:string</para>
    ///   <para>rdfs:label : Decibel (dB)</para>
    ///   <para>rdfs:comment : Decibel is a logarithmic unit used to express the ratio of two values of a physical quantity. It is often used to measure sound level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Decibel">m3lite:Decibel</a>
    /// </summary>
    let Decibel = _prefixId.prefix "Decibel"
    /// <summary>
    ///   <para>rdfs:label : DecibelA (dB(A))</para>
    ///   <para>rdfs:comment : Sound pressure sensed by the human ear.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DecibelA">m3lite:DecibelA</a>
    /// </summary>
    let DecibelA = _prefixId.prefix "DecibelA"
    /// <summary>
    ///   <para>rdfs:label : Decibel Milliwatt</para>
    ///   <para>rdfs:comment : It describes power ratio in decibels of the measured power referenced to one milliwatt.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DecibelMilliwatt">m3lite:DecibelMilliwatt</a>
    /// </summary>
    let DecibelMilliwatt = _prefixId.prefix "DecibelMilliwatt"
    /// <summary>
    ///   <para>rdfs:label : Degree</para>
    ///   <para>rdfs:comment : Degree.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Degree">m3lite:Degree</a>
    /// </summary>
    let Degree = _prefixId.prefix "Degree"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/unit#DegreeAngle^^xsd:string</para>
    ///   <para>rdfs:label : Degree Angle</para>
    ///   <para>rdfs:comment : A plane angle unit which is equal to 1/360 of a full rotation or pi/180 rad.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DegreeAngle">m3lite:DegreeAngle</a>
    /// </summary>
    let DegreeAngle = _prefixId.prefix "DegreeAngle"
    /// <summary>
    ///   <para>rdfs:label : Degree Celsius</para>
    ///   <para>rdfs:comment : A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DegreeCelsius">m3lite:DegreeCelsius</a>
    /// </summary>
    let DegreeCelsius = _prefixId.prefix "DegreeCelsius"
    /// <summary>
    ///   <para>rdfs:label : Degree Fahrenheit</para>
    ///   <para>rdfs:comment : Measurement Unit to represent temperature on the Fahrenheit scale.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DegreeFahrenheit">m3lite:DegreeFahrenheit</a>
    /// </summary>
    let DegreeFahrenheit = _prefixId.prefix "DegreeFahrenheit"
    /// <summary>
    ///   <para>rdfs:label : Delta Dew Point</para>
    ///   <para>rdfs:comment : Difference between Dewpoint and surface temperatures.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DeltaDewPoint">m3lite:DeltaDewPoint</a>
    /// </summary>
    let DeltaDewPoint = _prefixId.prefix "DeltaDewPoint"
    /// <summary>
    ///   <para>rdfs:label : Delta Dew Point Sensor</para>
    ///   <para>rdfs:comment : Device that measures the difference between Dewpoint and surface temperatures.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DeltaDewPointSensor">m3lite:DeltaDewPointSensor</a>
    /// </summary>
    let DeltaDewPointSensor = _prefixId.prefix "DeltaDewPointSensor"
    /// <summary>
    ///   <para>rdfs:label : Device Uptime</para>
    ///   <para>rdfs:comment : Time a device is working and is available</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DeviceUptime">m3lite:DeviceUptime</a>
    /// </summary>
    let DeviceUptime = _prefixId.prefix "DeviceUptime"
    /// <summary>
    ///   <para>rdfs:label : Device Uptime Clock</para>
    ///   <para>rdfs:comment : Sensor that measures time a device is working and is available.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DeviceUptimeClock">m3lite:DeviceUptimeClock</a>
    /// </summary>
    let DeviceUptimeClock = _prefixId.prefix "DeviceUptimeClock"
    /// <summary>
    ///   <para>rdfs:label : Dew Point</para>
    ///   <para>rdfs:comment : It is the temperature to which air must be cooled at constant pressure to condense to form liquid.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DewPoint">m3lite:DewPoint</a>
    /// </summary>
    let DewPoint = _prefixId.prefix "DewPoint"
    /// <summary>
    ///   <para>rdfs:label : Dew Point Sensor</para>
    ///   <para>rdfs:comment : Device that measures dew point.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DewPointSensor">m3lite:DewPointSensor</a>
    /// </summary>
    let DewPointSensor = _prefixId.prefix "DewPointSensor"
    /// <summary>
    ///   <para>rdfs:label : Dew Point Temperature</para>
    ///   <para>rdfs:comment : The temperature at which dew forms and is a measure of atmospheric moisture. It is the temperature to which air must be cooled at constant pressure and water content to reach saturation. A higher dew point indicates more moisture in the air; a dew point greater than 20 Degree C (68 Degree F) is considered uncomfortable and greater than 22 Degree C (72 Degree F) is considered to be extremely humid.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DewPointTemperature">m3lite:DewPointTemperature</a>
    /// </summary>
    let DewPointTemperature = _prefixId.prefix "DewPointTemperature"
    /// <summary>
    ///   <para>rdfs:label : Diastolic Blood Pressure</para>
    ///   <para>rdfs:comment :  Measure of the pressure in the arteries when the heart rests between beats.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DiastolicBloodPressure">m3lite:DiastolicBloodPressure</a>
    /// </summary>
    let DiastolicBloodPressure = _prefixId.prefix "DiastolicBloodPressure"
    /// <summary>
    ///   <para>rdfs:label : Dimensionless</para>
    ///   <para>rdfs:comment : Without dimensions; having no appreciable or noteworthy extent. Without physical meaning.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Dimensionless">m3lite:Dimensionless</a>
    /// </summary>
    let Dimensionless = _prefixId.prefix "Dimensionless"
    /// <summary>
    ///   <para>rdfs:comment : Measurements of sensors are affected by the direction of the sensing device. This concept is used to reflect it.</para>
    ///   <para>rdfs:label : Direction</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Direction">m3lite:Direction</a>
    /// </summary>
    let Direction = _prefixId.prefix "Direction"
    /// <summary>
    ///   <para>rdfs:label : Direction Azimuth</para>
    ///   <para>rdfs:comment : The geodetic azimuth of the direction towards which an object is point to.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DirectionAzimuth">m3lite:DirectionAzimuth</a>
    /// </summary>
    let DirectionAzimuth = _prefixId.prefix "DirectionAzimuth"
    /// <summary>
    ///   <para>rdfs:label : Direction Heading</para>
    ///   <para>rdfs:comment : The course or direction in which a object (vehicle, person, ...) is moving.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DirectionHeading">m3lite:DirectionHeading</a>
    /// </summary>
    let DirectionHeading = _prefixId.prefix "DirectionHeading"
    /// <summary>
    ///   <para>rdfs:label : Direction Of Arrival</para>
    ///   <para>rdfs:comment : The azimuth direction of a  source relative to the azimuth direction of the DOA sensor.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DirectionOfArrival">m3lite:DirectionOfArrival</a>
    /// </summary>
    let DirectionOfArrival = _prefixId.prefix "DirectionOfArrival"
    /// <summary>
    ///   <para>rdfs:label : Direction Of Arrival (DOA) Sensor</para>
    ///   <para>rdfs:comment : Sensor that estimates the azimuth direction of sources relative to the sensor’s position.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DirectionOfArrivalSensor">m3lite:DirectionOfArrivalSensor</a>
    /// </summary>
    let DirectionOfArrivalSensor = _prefixId.prefix "DirectionOfArrivalSensor"
    /// <summary>
    ///   <para>rdfs:label : Dish Washer Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the dishwasher.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DishWasher">m3lite:DishWasher</a>
    /// </summary>
    let DishWasher = _prefixId.prefix "DishWasher"
    /// <summary>
    ///   <para>rdfs:label : Distance</para>
    ///   <para>rdfs:comment : Measure of how far apart objects are.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Distance">m3lite:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    /// <summary>
    ///   <para>rdfs:label : Distance Sensor</para>
    ///   <para>rdfs:comment : Distance Sensor is used to detect distance between two objects for example:  the safety distance with other cars. Distance sensor can be a laser.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DistanceSensor">m3lite:DistanceSensor</a>
    /// </summary>
    let DistanceSensor = _prefixId.prefix "DistanceSensor"
    /// <summary>
    ///   <para>rdfs:label : Domain Of Interest</para>
    ///   <para>rdfs:comment : Application Domain for example: health, environment, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DomainOfInterest">m3lite:DomainOfInterest</a>
    /// </summary>
    let DomainOfInterest = _prefixId.prefix "DomainOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Door Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the door.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Door">m3lite:Door</a>
    /// </summary>
    let Door = _prefixId.prefix "Door"
    /// <summary>
    ///   <para>rdfs:label : Door State Sensor</para>
    ///   <para>rdfs:comment : This sensor detects if a door is in the state of OPEN or CLOSED.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DoorStateSensor">m3lite:DoorStateSensor</a>
    /// </summary>
    let DoorStateSensor = _prefixId.prefix "DoorStateSensor"
    /// <summary>
    ///   <para>rdfs:label : Door Status</para>
    ///   <para>rdfs:comment : Describes if a door is OPEN or CLOSED.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DoorStatus">m3lite:DoorStatus</a>
    /// </summary>
    let DoorStatus = _prefixId.prefix "DoorStatus"
    /// <summary>
    ///   <para>rdfs:label : Drawer Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the drawer.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Drawer">m3lite:Drawer</a>
    /// </summary>
    let Drawer = _prefixId.prefix "Drawer"
    /// <summary>
    ///   <para>rdfs:label : Dust Sensor</para>
    ///   <para>rdfs:comment : A sensing device that measures dust particle concentration.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#DustSensor">m3lite:DustSensor</a>
    /// </summary>
    let DustSensor = _prefixId.prefix "DustSensor"
    /// <summary>
    ///   <para>rdfs:label : European Air Quality Index (EAQI)</para>
    ///   <para>rdfs:comment : Unit to measure Air Quality in European cities.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#EAQI">m3lite:EAQI</a>
    /// </summary>
    let EAQI = _prefixId.prefix "EAQI"
    /// <summary>
    ///   <para>rdfs:label : ECG or EKG (Electrocardiogram)</para>
    ///   <para>rdfs:comment : ECG or EKG (Electrocardiogram) device.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ECG">m3lite:ECG</a>
    /// </summary>
    let ECG = _prefixId.prefix "ECG"
    /// <summary>
    ///   <para>rdfs:label : ESP (Electronic Stability Program) Actuating device</para>
    ///   <para>rdfs:comment : The actuator for turning ESP on/off.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ESP">m3lite:ESP</a>
    /// </summary>
    let ESP = _prefixId.prefix "ESP"
    /// <summary>
    ///   <para>rdfs:label : Electric Charge</para>
    ///   <para>rdfs:comment : It is the physical property of matter that causes it to experience a force when placed in an electromagnetic field. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricCharge">m3lite:ElectricCharge</a>
    /// </summary>
    let ElectricCharge = _prefixId.prefix "ElectricCharge"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/quantity#ElectricCurrent^^xsd:string</para>
    ///   <para>rdfs:label : Electric Current</para>
    ///   <para>rdfs:comment : Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time. Electric Current is the flow (movement) of electric charge. The amount of electric current through some surface, e.g., a section through a copper conductor, is defined as the amount of electric charge flowing through that surface over time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricCurrent">m3lite:ElectricCurrent</a>
    /// </summary>
    let ElectricCurrent = _prefixId.prefix "ElectricCurrent"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://qudt.org/vocab/quantity#ElectricField^^xsd:string</para>
    ///   <para>rdfs:comment : Electric field is the electric force per unit charge.</para>
    ///   <para>rdfs:label : Electric Field</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricField">m3lite:ElectricField</a>
    /// </summary>
    let ElectricField = _prefixId.prefix "ElectricField"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 1800 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 1800 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricField1800MHz">m3lite:ElectricField1800MHz</a>
    /// </summary>
    let ElectricField1800MHz = _prefixId.prefix "ElectricField1800MHz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 2100 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2100 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricField2100MHz">m3lite:ElectricField2100MHz</a>
    /// </summary>
    let ElectricField2100MHz = _prefixId.prefix "ElectricField2100MHz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 2400 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2400 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricField2400MHz">m3lite:ElectricField2400MHz</a>
    /// </summary>
    let ElectricField2400MHz = _prefixId.prefix "ElectricField2400MHz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field 900 MHz</para>
    ///   <para>rdfs:comment : A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 900 MHz UHF band.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricField900Mhz">m3lite:ElectricField900Mhz</a>
    /// </summary>
    let ElectricField900Mhz = _prefixId.prefix "ElectricField900Mhz"
    /// <summary>
    ///   <para>rdfs:label : Electric Field Sensor</para>
    ///   <para>rdfs:comment : Scientific instrument for measuring electromagnetic fields (EMF). Most of them measure the electromagnetic radiation flux density (DC fields) or the change in an electromagnetic field over time (AC fields).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricFieldSensor">m3lite:ElectricFieldSensor</a>
    /// </summary>
    let ElectricFieldSensor = _prefixId.prefix "ElectricFieldSensor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/dim#ElectricPotential^^xsd:string</para>
    ///   <para>rdfs:label : Electric Potential</para>
    ///   <para>rdfs:comment : Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricPotential">m3lite:ElectricPotential</a>
    /// </summary>
    let ElectricPotential = _prefixId.prefix "ElectricPotential"
    /// <summary>
    ///   <para>rdfs:label : Electrical Resistance</para>
    ///   <para>rdfs:comment : The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricalResistance">m3lite:ElectricalResistance</a>
    /// </summary>
    let ElectricalResistance = _prefixId.prefix "ElectricalResistance"
    /// <summary>
    ///   <para>rdfs:label : Electrical Sensor</para>
    ///   <para>rdfs:comment : Sensor that measures the changes in electrical or magnetic signals based on an environmental input.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ElectricalSensor">m3lite:ElectricalSensor</a>
    /// </summary>
    let ElectricalSensor = _prefixId.prefix "ElectricalSensor"
    /// <summary>
    ///   <para>rdfs:label : Emotion DOI</para>
    ///   <para>rdfs:comment : Affective Science, Emotion, Mood, Emotional State, Brain Wave as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Emotion">m3lite:Emotion</a>
    /// </summary>
    let Emotion = _prefixId.prefix "Emotion"
    /// <summary>
    ///   <para>rdfs:label : Energy</para>
    ///   <para>rdfs:comment : Energy is the property that must be transferred to an object in order to perform work on. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Energy">m3lite:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : Energy DOI</para>
    ///   <para>rdfs:comment : Energy or Smart Grid as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#EnergyDOI">m3lite:EnergyDOI</a>
    /// </summary>
    let EnergyDOI = _prefixId.prefix "EnergyDOI"
    /// <summary>
    ///   <para>rdfs:label : Energy Meter</para>
    ///   <para>rdfs:comment : Sensor to measure power or energy consumption.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#EnergyMeter">m3lite:EnergyMeter</a>
    /// </summary>
    let EnergyMeter = _prefixId.prefix "EnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Environment DOI</para>
    ///   <para>rdfs:comment : Environment (earthquake, flooding, fire, pollution) as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Environment">m3lite:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:label : Experiment Measurement Type</para>
    ///   <para>rdfs:comment : Experiment based measurements.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Experiment">m3lite:Experiment</a>
    /// </summary>
    let Experiment = _prefixId.prefix "Experiment"
    /// <summary>
    ///   <para>rdfs:label : Fall Detector</para>
    ///   <para>rdfs:comment : Device to detect is a person has fallen.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FallDetector">m3lite:FallDetector</a>
    /// </summary>
    let FallDetector = _prefixId.prefix "FallDetector"
    /// <summary>
    ///   <para>rdfs:label : Fan Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was Fan.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Fan">m3lite:Fan</a>
    /// </summary>
    let Fan = _prefixId.prefix "Fan"
    /// <summary>
    ///   <para>rdfs:label : Farad</para>
    ///   <para>rdfs:comment : SI unit of electrical capacitance.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Farad">m3lite:Farad</a>
    /// </summary>
    let Farad = _prefixId.prefix "Farad"
    /// <summary>
    ///   <para>rdfs:comment : Property used to determine the level a certain object such as waste bin is filled upto.</para>
    ///   <para>rdfs:label : Fill Level</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FillLevel">m3lite:FillLevel</a>
    /// </summary>
    let FillLevel = _prefixId.prefix "FillLevel"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Gas Tank</para>
    ///   <para>rdfs:comment : Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FillLevelGasTank">m3lite:FillLevelGasTank</a>
    /// </summary>
    let FillLevelGasTank = _prefixId.prefix "FillLevelGasTank"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Gas Tank 1</para>
    ///   <para>rdfs:comment : Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the primary tank of the vehicle.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FillLevelGasTank1">m3lite:FillLevelGasTank1</a>
    /// </summary>
    let FillLevelGasTank1 = _prefixId.prefix "FillLevelGasTank1"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Gas Tank 2</para>
    ///   <para>rdfs:comment : Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the secondary tank of the vehicle.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FillLevelGasTank2">m3lite:FillLevelGasTank2</a>
    /// </summary>
    let FillLevelGasTank2 = _prefixId.prefix "FillLevelGasTank2"
    /// <summary>
    ///   <para>rdfs:label : Fill Level Waste Container</para>
    ///   <para>rdfs:comment : Ratio between the current filleage level and the total capacity of a waste container.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FillLevelWasteContainer">m3lite:FillLevelWasteContainer</a>
    /// </summary>
    let FillLevelWasteContainer = _prefixId.prefix "FillLevelWasteContainer"
    /// <summary>
    ///   <para>rdfs:label : Fog Lamp Actuating Device</para>
    ///   <para>rdfs:comment : The actuator for turning on or off the fog lamp.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FogLamp">m3lite:FogLamp</a>
    /// </summary>
    let FogLamp = _prefixId.prefix "FogLamp"
    /// <summary>
    ///   <para>rdfs:label : Food Temperature</para>
    ///   <para>rdfs:comment : Measure of temperature of the food.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FoodTemperature">m3lite:FoodTemperature</a>
    /// </summary>
    let FoodTemperature = _prefixId.prefix "FoodTemperature"
    /// <summary>
    ///   <para>rdfs:label : Freezer, Chiller Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the freezer.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Freezer">m3lite:Freezer</a>
    /// </summary>
    let Freezer = _prefixId.prefix "Freezer"
    /// <summary>
    ///   <para>rdfs:label : Frequency</para>
    ///   <para>rdfs:comment : Frequency is the number of occurrences of a repeating event per unit time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Frequency">m3lite:Frequency</a>
    /// </summary>
    let Frequency = _prefixId.prefix "Frequency"
    /// <summary>
    ///   <para>rdfs:label : Frequency Sensor</para>
    ///   <para>rdfs:comment : Device used to detect the frequency.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FrequencySensor">m3lite:FrequencySensor</a>
    /// </summary>
    let FrequencySensor = _prefixId.prefix "FrequencySensor"
    /// <summary>
    ///   <para>rdfs:label : Fridge, Refrigerator Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the fridge.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Fridge">m3lite:Fridge</a>
    /// </summary>
    let Fridge = _prefixId.prefix "Fridge"
    /// <summary>
    ///   <para>rdfs:comment : The amount of fuel a vehicle uses to travel a particular distance at a particular speed.</para>
    ///   <para>rdfs:label : Fuel Consumption Quantity Kind</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FuelConsumption">m3lite:FuelConsumption</a>
    /// </summary>
    let FuelConsumption = _prefixId.prefix "FuelConsumption"
    /// <summary>
    ///   <para>rdfs:label : Fuel Consumption Instantaneous</para>
    ///   <para>rdfs:comment : A measure that displays the instantaneous fuel consumption of a vehicle during its operation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FuelConsumptionInstantaneous">m3lite:FuelConsumptionInstantaneous</a>
    /// </summary>
    let FuelConsumptionInstantaneous = _prefixId.prefix "FuelConsumptionInstantaneous"
    /// <summary>
    ///   <para>rdfs:label : Fuel Consumption Total</para>
    ///   <para>rdfs:comment : Accumulated amount of fuel used during vehicle operation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FuelConsumptionTotal">m3lite:FuelConsumptionTotal</a>
    /// </summary>
    let FuelConsumptionTotal = _prefixId.prefix "FuelConsumptionTotal"
    /// <summary>
    ///   <para>rdfs:label : Fuel Level Sensor</para>
    ///   <para>rdfs:comment : Device used to detect fuel level in a system such a car.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#FuelLevel">m3lite:FuelLevel</a>
    /// </summary>
    let FuelLevel = _prefixId.prefix "FuelLevel"
    /// <summary>
    ///   <para>rdfs:label : GPS Sensor</para>
    ///   <para>rdfs:comment : Device that allows an object to localize itself.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GPSSensor">m3lite:GPSSensor</a>
    /// </summary>
    let GPSSensor = _prefixId.prefix "GPSSensor"
    /// <summary>
    ///   <para>rdfs:label : Gas Detector</para>
    ///   <para>rdfs:comment : Device that detects the presence of gases in an area, often as part of a safety system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GasDetector">m3lite:GasDetector</a>
    /// </summary>
    let GasDetector = _prefixId.prefix "GasDetector"
    /// <summary>
    ///   <para>rdfs:label : Gaseous Pollutant Sensor</para>
    ///   <para>rdfs:comment : Device used to detect poisonous gaseous in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GaseousPollutantSensor">m3lite:GaseousPollutantSensor</a>
    /// </summary>
    let GaseousPollutantSensor = _prefixId.prefix "GaseousPollutantSensor"
    /// <summary>
    ///   <para>rdfs:label : Gauss</para>
    ///   <para>rdfs:comment : Gauss is the CGS unit of measurement of magnetic flux density (or magnetic induction) (B) (Source Wikipedia)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Gauss">m3lite:Gauss</a>
    /// </summary>
    let Gauss = _prefixId.prefix "Gauss"
    /// <summary>
    ///   <para>rdfs:label : Glucometer Sensor</para>
    ///   <para>rdfs:comment : Device used to detect glucometer, blood sugar, blood glucose level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Glucometer">m3lite:Glucometer</a>
    /// </summary>
    let Glucometer = _prefixId.prefix "Glucometer"
    /// <summary>
    ///   <para>rdfs:comment : It is a metric system unit of mass^^xsd:string</para>
    ///   <para>rdfs:label : Gram (g)^^xsd:string</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Gram">m3lite:Gram</a>
    /// </summary>
    let Gram = _prefixId.prefix "Gram"
    /// <summary>
    ///   <para>rdfs:label : Gram Per Cubic Metre, Gram Per Cubic Meter</para>
    ///   <para>rdfs:comment : It is defined by mass in grams divided by volume in cubic metres.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GramPerCubicMetre">m3lite:GramPerCubicMetre</a>
    /// </summary>
    let GramPerCubicMetre = _prefixId.prefix "GramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:label : Gram Per Litre, Gram Per Liter (g/L)</para>
    ///   <para>rdfs:comment : It shows how many grams of a certain substance are present in one litre of a usually liquid or gaseous mixture.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GramPerLitre">m3lite:GramPerLitre</a>
    /// </summary>
    let GramPerLitre = _prefixId.prefix "GramPerLitre"
    /// <summary>
    ///   <para>rdfs:label : Gyrometer Sensor</para>
    ///   <para>rdfs:comment : A gyrometer is an instrument which measures an angular speed.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GyrometerSensor">m3lite:GyrometerSensor</a>
    /// </summary>
    let GyrometerSensor = _prefixId.prefix "GyrometerSensor"
    /// <summary>
    ///   <para>rdfs:label : Gyroscope Sensor</para>
    ///   <para>rdfs:comment : A gyroscope is a device for measuring or maintaining orientation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#GyroscopeSensor">m3lite:GyroscopeSensor</a>
    /// </summary>
    let GyroscopeSensor = _prefixId.prefix "GyroscopeSensor"
    /// <summary>
    ///   <para>rdfs:label : H2S Sensor</para>
    ///   <para>rdfs:comment : Device used to measure of hydrogen sulphide in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#H2SSensor">m3lite:H2SSensor</a>
    /// </summary>
    let H2SSensor = _prefixId.prefix "H2SSensor"
    /// <summary>
    ///   <para>rdfs:label : Health Care DOI</para>
    ///   <para>rdfs:comment : Healthcare as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Health">m3lite:Health</a>
    /// </summary>
    let Health = _prefixId.prefix "Health"
    /// <summary>
    ///   <para>rdfs:label : Heart Beat</para>
    ///   <para>rdfs:comment : The number of times your heart beats each minute (bpm).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#HeartBeat">m3lite:HeartBeat</a>
    /// </summary>
    let HeartBeat = _prefixId.prefix "HeartBeat"
    /// <summary>
    ///   <para>rdfs:label : Heart Beat Sensor</para>
    ///   <para>rdfs:comment : Device to count heart beats per minute.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#HeartBeatSensor">m3lite:HeartBeatSensor</a>
    /// </summary>
    let HeartBeatSensor = _prefixId.prefix "HeartBeatSensor"
    /// <summary>
    ///   <para>rdfs:label : Heating Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the heating.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Heating">m3lite:Heating</a>
    /// </summary>
    let Heating = _prefixId.prefix "Heating"
    /// <summary>
    ///   <para>rdfs:label : Hertz</para>
    ///   <para>rdfs:comment : The SI unit of frequency, equal to one cycle per second.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Hertz">m3lite:Hertz</a>
    /// </summary>
    let Hertz = _prefixId.prefix "Hertz"
    /// <summary>
    ///   <para>rdfs:label : Hour</para>
    ///   <para>rdfs:comment : Hour of the day.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Hour">m3lite:Hour</a>
    /// </summary>
    let Hour = _prefixId.prefix "Hour"
    /// <summary>
    ///   <para>rdfs:label : Household Appliance Temperature</para>
    ///   <para>rdfs:comment : Measure of Household Appliance Temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#HouseholdApplianceTemperature">m3lite:HouseholdApplianceTemperature</a>
    /// </summary>
    let HouseholdApplianceTemperature = _prefixId.prefix "HouseholdApplianceTemperature"
    /// <summary>
    ///   <para>rdfs:label :  Human Presence Detector</para>
    ///   <para>rdfs:comment : Device used to detect if an object (vehicle, room, place, etc.) is occupied by Human.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#HumanPresenceDetector">m3lite:HumanPresenceDetector</a>
    /// </summary>
    let HumanPresenceDetector = _prefixId.prefix "HumanPresenceDetector"
    /// <summary>
    ///   <para>rdfs:label : Humidity</para>
    ///   <para>rdfs:comment : A quantity representing the amount of water vapour in the atmosphere or in a gas.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Humidity">m3lite:Humidity</a>
    /// </summary>
    let Humidity = _prefixId.prefix "Humidity"
    /// <summary>
    ///   <para>rdfs:label : Humidity Sensor</para>
    ///   <para>rdfs:comment : Humidity sensor or hygrometer is an instrument used for measuring the moisture concent in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#HumiditySensor">m3lite:HumiditySensor</a>
    /// </summary>
    let HumiditySensor = _prefixId.prefix "HumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Hydrophone</para>
    ///   <para>rdfs:comment : A hydrophone is a microphone designed to be used underwater for recording or listening to underwater sound.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Hydrophone">m3lite:Hydrophone</a>
    /// </summary>
    let Hydrophone = _prefixId.prefix "Hydrophone"

    /// <summary>
    ///   <para>rdfs:label : IEEE802.15.4 Interface Energy Meter</para>
    ///   <para>rdfs:comment : Sensor that measures the power consumption of the IEEE802.15.4 interface nodes.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#IEEE802154InterfaceEnergyMeter">m3lite:IEEE802154InterfaceEnergyMeter</a>
    /// </summary>
    let IEEE802154InterfaceEnergyMeter =
        _prefixId.prefix "IEEE802154InterfaceEnergyMeter"

    /// <summary>
    ///   <para>rdfs:label : Illuminance</para>
    ///   <para>rdfs:comment : Illuminance is the total luminous flux incident on a surface, per unit area.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Illuminance">m3lite:Illuminance</a>
    /// </summary>
    let Illuminance = _prefixId.prefix "Illuminance"
    /// <summary>
    ///   <para>rdfs:label : Image Sensor</para>
    ///   <para>rdfs:comment : Sensor that detects and conveys the information that constitutes an image.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ImageSensor">m3lite:ImageSensor</a>
    /// </summary>
    let ImageSensor = _prefixId.prefix "ImageSensor"
    /// <summary>
    ///   <para>rdfs:label : Inch</para>
    ///   <para>rdfs:comment : Length in inches.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Inch">m3lite:Inch</a>
    /// </summary>
    let Inch = _prefixId.prefix "Inch"
    /// <summary>
    ///   <para>rdfs:label : Index</para>
    ///   <para>rdfs:comment : Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Index">m3lite:Index</a>
    /// </summary>
    let Index = _prefixId.prefix "Index"
    /// <summary>
    ///   <para>rdfs:label : Downlink Latency</para>
    ///   <para>rdfs:comment : Downlink Latency.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#IntDlLatency">m3lite:IntDlLatency</a>
    /// </summary>
    let IntDlLatency = _prefixId.prefix "IntDlLatency"
    /// <summary>
    ///   <para>rdfs:label : Downlink Throughput</para>
    ///   <para>rdfs:comment : Downlink Throughput.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#IntDlThroughputKbps">m3lite:IntDlThroughputKbps</a>
    /// </summary>
    let IntDlThroughputKbps = _prefixId.prefix "IntDlThroughputKbps"
    /// <summary>
    ///   <para>rdfs:label : Uplink Packet Loss</para>
    ///   <para>rdfs:comment : Uplink Packet Loss.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#IntUlPacketLoss">m3lite:IntUlPacketLoss</a>
    /// </summary>
    let IntUlPacketLoss = _prefixId.prefix "IntUlPacketLoss"
    /// <summary>
    ///   <para>rdfs:label : Uplink Throughput</para>
    ///   <para>rdfs:comment : Uplink Throughput.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#IntUlThroughputKbps">m3lite:IntUlThroughputKbps</a>
    /// </summary>
    let IntUlThroughputKbps = _prefixId.prefix "IntUlThroughputKbps"
    /// <summary>
    ///   <para>rdfs:label : Invalid Measurement Type</para>
    ///   <para>rdfs:comment : If the measurement was tagged invalid.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Invalid">m3lite:Invalid</a>
    /// </summary>
    let Invalid = _prefixId.prefix "Invalid"
    /// <summary>
    ///   <para>rdfs:label : Ionising Radiation</para>
    ///   <para>rdfs:comment : Ionising radiation is radiation that carries enough energy to free electrons from atoms or molecules, thereby ionizing them. Gamma rays, X-rays, and the higher ultraviolet part of the electromagnetic spectrum are ionizing, whereas the lower ultraviolet part of the electromagnetic spectrum, and also the lower part of the spectrum below UV, including visible light (including nearly all types of laser light), infrared, microwaves, and radio waves are all considered non-ionizing radiation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#IonisingRadiation">m3lite:IonisingRadiation</a>
    /// </summary>
    let IonisingRadiation = _prefixId.prefix "IonisingRadiation"
    /// <summary>
    ///   <para>rdfs:label : Irrigation Actuation Device</para>
    ///   <para>rdfs:comment : An actuator to automatically irrigate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Irrigation">m3lite:Irrigation</a>
    /// </summary>
    let Irrigation = _prefixId.prefix "Irrigation"
    /// <summary>
    ///   <para>rdfs:label : Item</para>
    ///   <para>rdfs:comment : Each of the accountable elements within a group.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Item">m3lite:Item</a>
    /// </summary>
    let Item = _prefixId.prefix "Item"
    /// <summary>
    ///   <para>rdfs:label : Kelvin, Degree Kelvin</para>
    ///   <para>rdfs:comment : Kelvin is a unit of measurement for temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Kelvin">m3lite:Kelvin</a>
    /// </summary>
    let Kelvin = _prefixId.prefix "Kelvin"
    /// <summary>
    ///   <para>rdfs:label : Kilo Watt Hour</para>
    ///   <para>rdfs:comment : Measure of electrical energy equivalent to a power consumption of one thousand watts for one hour.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#KiloWattHour">m3lite:KiloWattHour</a>
    /// </summary>
    let KiloWattHour = _prefixId.prefix "KiloWattHour"
    /// <summary>
    ///   <para>rdfs:label : Kilobits Per Second</para>
    ///   <para>rdfs:comment : It is a unit of data transfer rate equal to: 1,000 bits per second.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#KilobitsPerSecond">m3lite:KilobitsPerSecond</a>
    /// </summary>
    let KilobitsPerSecond = _prefixId.prefix "KilobitsPerSecond"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#kilogram^^xsd:string</para>
    ///   <para>rdfs:label : Kilogram (kg)</para>
    ///   <para>rdfs:comment : The SI unit of mass, it is equal to the mass of the international prototype of the kilogram.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Kilogram">m3lite:Kilogram</a>
    /// </summary>
    let Kilogram = _prefixId.prefix "Kilogram"
    /// <summary>
    ///   <para>rdfs:comment : It is SI derived unit of density, defined by mass in kilograms divided by volume in cubic metres.</para>
    ///   <para>rdfs:label : Kilogram Per Cubic Metre, Kilogram Per Cubic Meter</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#KilogramPerCubicMetre">m3lite:KilogramPerCubicMetre</a>
    /// </summary>
    let KilogramPerCubicMetre = _prefixId.prefix "KilogramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:comment : A metric unit of measurement equal to 1,000 metres (approx 0.62 miles).</para>
    ///   <para>rdfs:label : Kilometre, Kilometer</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Kilometre">m3lite:Kilometre</a>
    /// </summary>
    let Kilometre = _prefixId.prefix "Kilometre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://data.qudt.org/qudt/owl/1.0.0/unit.owl#KilometerPerHour^^xsd:string</para>
    ///   <para>rdfs:comment : It is a unit of speed, expressing the number of kilometres travelled in one hour.</para>
    ///   <para>rdfs:label : Kilometre Per Hour, Kilometer Per Hour</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#KilometrePerHour">m3lite:KilometrePerHour</a>
    /// </summary>
    let KilometrePerHour = _prefixId.prefix "KilometrePerHour"
    /// <summary>
    ///   <para>rdfs:label : Lamp Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the lamp.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Lamp">m3lite:Lamp</a>
    /// </summary>
    let Lamp = _prefixId.prefix "Lamp"
    /// <summary>
    ///   <para>rdfs:label : Lavatory Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the lavatory.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Lavatory">m3lite:Lavatory</a>
    /// </summary>
    let Lavatory = _prefixId.prefix "Lavatory"
    /// <summary>
    ///   <para>rdfs:label : Leaf Wetness</para>
    ///   <para>rdfs:comment : Leaf wetness is a meteorological parameter that describes the amount of dew and precipitation left on surfaces. It is used for monitoring leaf moisture for agricultural purposes, such as fungus and disease control, for control of irrigation systems, and for detection of fog and dew conditions, and early detection of rainfall. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LeafWetness">m3lite:LeafWetness</a>
    /// </summary>
    let LeafWetness = _prefixId.prefix "LeafWetness"
    /// <summary>
    ///   <para>rdfs:label : Leaf Wetness Sensor</para>
    ///   <para>rdfs:comment : Leaf Wetness Sensor is used in agriculture to check whether the plants need to be watered.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LeafWetnessSensor">m3lite:LeafWetnessSensor</a>
    /// </summary>
    let LeafWetnessSensor = _prefixId.prefix "LeafWetnessSensor"
    /// <summary>
    ///   <para>rdfs:label : Light Sensor</para>
    ///   <para>rdfs:comment : Light/Illuminance Sensor is used to adjust the brightness of the surface.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LightSensor">m3lite:LightSensor</a>
    /// </summary>
    let LightSensor = _prefixId.prefix "LightSensor"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#litre^^xsd:string</para>
    ///   <para>rdfs:label : Litre, Liter</para>
    ///   <para>rdfs:comment : A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Litre">m3lite:Litre</a>
    /// </summary>
    let Litre = _prefixId.prefix "Litre"
    /// <summary>
    ///   <para>rdfs:label : Litre Per 100 Kilometres, Liter Per 100 Kilometers</para>
    ///   <para>rdfs:comment : A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LitrePer100Kilometres">m3lite:LitrePer100Kilometres</a>
    /// </summary>
    let LitrePer100Kilometres = _prefixId.prefix "LitrePer100Kilometres"
    /// <summary>
    ///   <para>rdfs:label : LoRa Interface Energy Meter</para>
    ///   <para>rdfs:comment : Measure the average power consumption of the LoRa interface nodes.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LoRaInterfaceEnergyMeter">m3lite:LoRaInterfaceEnergyMeter</a>
    /// </summary>
    let LoRaInterfaceEnergyMeter = _prefixId.prefix "LoRaInterfaceEnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Location Quantity Kind</para>
    ///   <para>rdfs:comment : A particular place or position.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LocationQK">m3lite:LocationQK</a>
    /// </summary>
    let LocationQK = _prefixId.prefix "LocationQK"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#lumen^^xsd:string</para>
    ///   <para>rdfs:label : Lumen (lm)</para>
    ///   <para>rdfs:comment : The SI unit of luminous flux, equal to the amount of light emitted per second in a unit solid angle of one steradian from a uniform source of one candela.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Lumen">m3lite:Lumen</a>
    /// </summary>
    let Lumen = _prefixId.prefix "Lumen"
    /// <summary>
    ///   <para>rdfs:label : Luminous Flux</para>
    ///   <para>rdfs:comment : Luminous Flux is the measure of the perceived power of light.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LuminousFlux">m3lite:LuminousFlux</a>
    /// </summary>
    let LuminousFlux = _prefixId.prefix "LuminousFlux"
    /// <summary>
    ///   <para>rdfs:label : Luminous Intensity</para>
    ///   <para>rdfs:comment :  It is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye. The SI unit of luminous intensity is the candela (cd), an SI base unit. (Source Wikipedia)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#LuminousIntensity">m3lite:LuminousIntensity</a>
    /// </summary>
    let LuminousIntensity = _prefixId.prefix "LuminousIntensity"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#lux^^xsd:string</para>
    ///   <para>rdfs:label : Lux (lx)</para>
    ///   <para>rdfs:comment : The SI unit of illuminance, equal to one lumen per square metre.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Lux">m3lite:Lux</a>
    /// </summary>
    let Lux = _prefixId.prefix "Lux"
    /// <summary>
    ///   <para>rdfs:label : Magnetic Field</para>
    ///   <para>rdfs:comment : A region around a magnetic material or a moving electric charge within which the force of magnetism acts.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MagneticField">m3lite:MagneticField</a>
    /// </summary>
    let MagneticField = _prefixId.prefix "MagneticField"
    /// <summary>
    ///   <para>rdfs:label : Magnetic Flux Density</para>
    ///   <para>rdfs:comment : It is the magnetic flux  through a surface is the surface integral of the normal component of the magnetic field (B) passing through that surface. The SI unit of magnetic flux is the weber (Wb). (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MagneticFluxDensity">m3lite:MagneticFluxDensity</a>
    /// </summary>
    let MagneticFluxDensity = _prefixId.prefix "MagneticFluxDensity"
    /// <summary>
    ///   <para>rdfs:label : Magnetometer</para>
    ///   <para>rdfs:comment : A magnetometer is an device that measures magnetism—either magnetization of magnetic material like a ferromagnet, or the strength and, in some cases, direction of the magnetic field at a point in space. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Magnetometer">m3lite:Magnetometer</a>
    /// </summary>
    let Magnetometer = _prefixId.prefix "Magnetometer"
    /// <summary>
    ///   <para>rdfs:label : Manual Measurement Type</para>
    ///   <para>rdfs:comment : If the measurement was taken when human effort was involved.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Manual">m3lite:Manual</a>
    /// </summary>
    let Manual = _prefixId.prefix "Manual"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#mass^^xsd:string</para>
    ///   <para>rdfs:label : Mass</para>
    ///   <para>rdfs:comment : Mass is a property of a physical body. It is the measure of an object's resistance to acceleration when a net force is applied.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Mass">m3lite:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>rdfs:label : Measurement Type</para>
    ///   <para>rdfs:comment : Type of Measurement done using a device.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MeasurementType">m3lite:MeasurementType</a>
    /// </summary>
    let MeasurementType = _prefixId.prefix "MeasurementType"
    /// <summary>
    ///   <para>rdfs:label : Methane (CH4) Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Methane in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MethaneSensor">m3lite:MethaneSensor</a>
    /// </summary>
    let MethaneSensor = _prefixId.prefix "MethaneSensor"
    /// <summary>
    ///   <para>rdfs:label : Metre, Meter</para>
    ///   <para>rdfs:comment : It is the unit of length.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Metre">m3lite:Metre</a>
    /// </summary>
    let Metre = _prefixId.prefix "Metre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#metrePerSecond^^xsd:string</para>
    ///   <para>rdfs:label : Metre Per Second, Meter Per Second  (m/s)</para>
    ///   <para>rdfs:comment : A speed/velocity unit which is equal to the speed of an object traveling 1 metre distance in one second.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MetrePerSecond">m3lite:MetrePerSecond</a>
    /// </summary>
    let MetrePerSecond = _prefixId.prefix "MetrePerSecond"
    /// <summary>
    ///   <para>rdfs:label : Metre Per Second Square, Meter Per Second Square</para>
    ///   <para>rdfs:comment : It is the unit of acceleration.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MetrePerSecondSquare">m3lite:MetrePerSecondSquare</a>
    /// </summary>
    let MetrePerSecondSquare = _prefixId.prefix "MetrePerSecondSquare"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of electric current, or amount of electric charge per second.</para>
    ///   <para>rdfs:label : Microampere (uA)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Microampere">m3lite:Microampere</a>
    /// </summary>
    let Microampere = _prefixId.prefix "Microampere"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of mass equal to one billionth (1×10^−9) of a kilogram.</para>
    ///   <para>rdfs:label : Microgram (ug)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Microgram">m3lite:Microgram</a>
    /// </summary>
    let Microgram = _prefixId.prefix "Microgram"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#microgramPerCubicMetre^^xsd:string</para>
    ///   <para>rdfs:label : Microgram Per Cubic Metre, Microgram Per Cubic Meter</para>
    ///   <para>rdfs:comment : Microgram per cubic metre is a unit of density defined as microgram divided by cubic metre. Milligram per cubic metre is a derived unit in the International System of Units.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MicrogramPerCubicMetre">m3lite:MicrogramPerCubicMetre</a>
    /// </summary>
    let MicrogramPerCubicMetre = _prefixId.prefix "MicrogramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of electromotive force or potential difference equal to one millionth of a volt. </para>
    ///   <para>rdfs:label : Microvolt (uV)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Microvolt">m3lite:Microvolt</a>
    /// </summary>
    let Microvolt = _prefixId.prefix "Microvolt"
    /// <summary>
    ///   <para>rdfs:comment : It is a unit of power.</para>
    ///   <para>rdfs:label : Microwatt (uW)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Microwatt">m3lite:Microwatt</a>
    /// </summary>
    let Microwatt = _prefixId.prefix "Microwatt"
    /// <summary>
    ///   <para>rdfs:label : Microwatt Per Square Centimetre, Microwatt Per Square Centimeter</para>
    ///   <para>rdfs:comment : It is one of the unit for radiative and other energy fluxes.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MicrowattPerSquareCentimetre">m3lite:MicrowattPerSquareCentimetre</a>
    /// </summary>
    let MicrowattPerSquareCentimetre = _prefixId.prefix "MicrowattPerSquareCentimetre"
    /// <summary>
    ///   <para>rdfs:label : Microwave Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the Microwave.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Microwave">m3lite:Microwave</a>
    /// </summary>
    let Microwave = _prefixId.prefix "Microwave"
    /// <summary>
    ///   <para>rdfs:comment : Measure of the number of miles or the average distance that a vehicle can travel on a specified quantity of fuel</para>
    ///   <para>rdfs:label : Mileage</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Mileage">m3lite:Mileage</a>
    /// </summary>
    let Mileage = _prefixId.prefix "Mileage"
    /// <summary>
    ///   <para>rdfs:label : Mileage Distance To Service</para>
    ///   <para>rdfs:comment : The distance which can be travelled by the vehicle before the next service inspection is required.  A negative distance is transmitted if the service inspection has been passed.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MileageDistanceToService">m3lite:MileageDistanceToService</a>
    /// </summary>
    let MileageDistanceToService = _prefixId.prefix "MileageDistanceToService"
    /// <summary>
    ///   <para>rdfs:label : Mileage Total</para>
    ///   <para>rdfs:comment : The total distance travelled by the particular vehicle since its initial production.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MileageTotal">m3lite:MileageTotal</a>
    /// </summary>
    let MileageTotal = _prefixId.prefix "MileageTotal"
    /// <summary>
    ///   <para>rdfs:label : Miles</para>
    ///   <para>rdfs:comment : It is a unit of length that is equal to 1,760 yards (approx. 1.609 kilometres).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Miles">m3lite:Miles</a>
    /// </summary>
    let Miles = _prefixId.prefix "Miles"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of an ampere.</para>
    ///   <para>rdfs:label : Milliampere (mA)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Milliampere">m3lite:Milliampere</a>
    /// </summary>
    let Milliampere = _prefixId.prefix "Milliampere"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a bar.</para>
    ///   <para>rdfs:label : Millibar</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Millibar">m3lite:Millibar</a>
    /// </summary>
    let Millibar = _prefixId.prefix "Millibar"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a gram.</para>
    ///   <para>rdfs:label : Milligram (mg)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Milligram">m3lite:Milligram</a>
    /// </summary>
    let Milligram = _prefixId.prefix "Milligram"
    /// <summary>
    ///   <para>rdfs:comment : It is a density measurement unit.</para>
    ///   <para>rdfs:label : Milligram Per Cubic Metre, Milligram Per Cubic Meter</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MilligramPerCubicMetre">m3lite:MilligramPerCubicMetre</a>
    /// </summary>
    let MilligramPerCubicMetre = _prefixId.prefix "MilligramPerCubicMetre"
    /// <summary>
    ///   <para>rdfs:label : Milligram Per Litre, Milligram Per Liter</para>
    ///   <para>rdfs:comment : Level of Dissolved substance in liquid measured in mg per litre.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MilligramPerLitre">m3lite:MilligramPerLitre</a>
    /// </summary>
    let MilligramPerLitre = _prefixId.prefix "MilligramPerLitre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#milligramPerSquareMetre^^xsd:string</para>
    ///   <para>rdfs:label : Milligram Per Square Metre, Milligram Per Square Meter</para>
    ///   <para>rdfs:comment : A dose unit which is equal to 1 milligram of a substance per square metre of surface area of the recipient subject.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MilligramPerSquareMetre">m3lite:MilligramPerSquareMetre</a>
    /// </summary>
    let MilligramPerSquareMetre = _prefixId.prefix "MilligramPerSquareMetre"
    /// <summary>
    ///   <para>rdfs:label : Millilitre, Milliliter</para>
    ///   <para>rdfs:comment : One thousandth of a litre (0.002 pint).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Millilitre">m3lite:Millilitre</a>
    /// </summary>
    let Millilitre = _prefixId.prefix "Millilitre"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a metre (0.039 in).</para>
    ///   <para>rdfs:label : Millimetre, Millimeter</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Millimetre">m3lite:Millimetre</a>
    /// </summary>
    let Millimetre = _prefixId.prefix "Millimetre"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#millimetrePerHour^^xsd:string</para>
    ///   <para>rdfs:label : Millimetre Per Hour, Millimeter Per Hour</para>
    ///   <para>rdfs:comment : A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimetre travelled per unit hour.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MillimetrePerHour">m3lite:MillimetrePerHour</a>
    /// </summary>
    let MillimetrePerHour = _prefixId.prefix "MillimetrePerHour"
    /// <summary>
    ///   <para>rdfs:label : Millisecond</para>
    ///   <para>rdfs:comment : One thousandth of a second.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Millisecond">m3lite:Millisecond</a>
    /// </summary>
    let Millisecond = _prefixId.prefix "Millisecond"
    /// <summary>
    ///   <para>rdfs:comment : One thousandth of a volt.</para>
    ///   <para>rdfs:label : Millivolt (mV)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Millivolt">m3lite:Millivolt</a>
    /// </summary>
    let Millivolt = _prefixId.prefix "Millivolt"
    /// <summary>
    ///   <para>rdfs:comment : It is a measure of the intensity of the signal of a radio transmitter.</para>
    ///   <para>rdfs:label : Millivolt Per Metre, Millivolt Per Meter</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MillivoltPerMetre">m3lite:MillivoltPerMetre</a>
    /// </summary>
    let MillivoltPerMetre = _prefixId.prefix "MillivoltPerMetre"
    /// <summary>
    ///   <para>rdfs:comment : A unit of power equal to one thousandth of a watt.</para>
    ///   <para>rdfs:label : Milliwatt (mW)</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Milliwatt">m3lite:Milliwatt</a>
    /// </summary>
    let Milliwatt = _prefixId.prefix "Milliwatt"
    /// <summary>
    ///   <para>rdfs:label : Minute Angle</para>
    ///   <para>rdfs:comment : A Minute of Angle (MOA) is an angular measurement. A MOA is 1/60th of a degree.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MinuteAngle">m3lite:MinuteAngle</a>
    /// </summary>
    let MinuteAngle = _prefixId.prefix "MinuteAngle"
    /// <summary>
    ///   <para>rdfs:label : Minute Time</para>
    ///   <para>rdfs:comment : A unit of time equal to 60 seconds or 1/60th of an hour.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MinuteTime">m3lite:MinuteTime</a>
    /// </summary>
    let MinuteTime = _prefixId.prefix "MinuteTime"
    /// <summary>
    ///   <para>rdfs:label : MmHg</para>
    ///   <para>rdfs:comment : A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MmHg">m3lite:MmHg</a>
    /// </summary>
    let MmHg = _prefixId.prefix "MmHg"
    /// <summary>
    ///   <para>rdfs:label : Mmol Per Litre, Mmol Per Liter</para>
    ///   <para>rdfs:comment : It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLitre is used to measure cholesterol.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MmolPerLitre">m3lite:MmolPerLitre</a>
    /// </summary>
    let MmolPerLitre = _prefixId.prefix "MmolPerLitre"
    /// <summary>
    ///   <para>rdfs:label : Handover Execution</para>
    ///   <para>rdfs:comment : Handover Execution.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MobHoExecSuccRate">m3lite:MobHoExecSuccRate</a>
    /// </summary>
    let MobHoExecSuccRate = _prefixId.prefix "MobHoExecSuccRate"
    /// <summary>
    ///   <para>rdfs:label : Handover Preparation Success Rate</para>
    ///   <para>rdfs:comment : Handover Preparation Success Rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MobHoPrepSuccRate">m3lite:MobHoPrepSuccRate</a>
    /// </summary>
    let MobHoPrepSuccRate = _prefixId.prefix "MobHoPrepSuccRate"
    /// <summary>
    ///   <para>rdfs:label : Handover Mobility Success Rate</para>
    ///   <para>rdfs:comment : Handover Mobility Success Rate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MobMobilitySuccRate">m3lite:MobMobilitySuccRate</a>
    /// </summary>
    let MobMobilitySuccRate = _prefixId.prefix "MobMobilitySuccRate"
    /// <summary>
    ///   <para>rdfs:label : Motion</para>
    ///   <para>rdfs:comment : It is the action or process of moving or being moved.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Motion">m3lite:Motion</a>
    /// </summary>
    let Motion = _prefixId.prefix "Motion"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether a person (or object) is detected upon his/her/its movement.</para>
    ///   <para>rdfs:label : Motion State</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MotionState">m3lite:MotionState</a>
    /// </summary>
    let MotionState = _prefixId.prefix "MotionState"
    /// <summary>
    ///   <para>rdfs:label : Motion State Vehicle</para>
    ///   <para>rdfs:comment : Indicates whether motion of the vehicle is detected or not.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#MotionStateVehicle">m3lite:MotionStateVehicle</a>
    /// </summary>
    let MotionStateVehicle = _prefixId.prefix "MotionStateVehicle"
    /// <summary>
    ///   <para>rdfs:label : NFC Tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be NFC (Near Field Communication).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#NFC">m3lite:NFC</a>
    /// </summary>
    let NFC = _prefixId.prefix "NFC"
    /// <summary>
    ///   <para>rdfs:label : NH3 Sensor</para>
    ///   <para>rdfs:comment : Device used to detect NH3 level in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#NH3Sensor">m3lite:NH3Sensor</a>
    /// </summary>
    let NH3Sensor = _prefixId.prefix "NH3Sensor"
    /// <summary>
    ///   <para>rdfs:label : Nitrogen Dioxide (NO2) Sensor</para>
    ///   <para>rdfs:comment : Sensor detecting levels of Nitrogen Dioxide (NO2) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#NO2Sensor">m3lite:NO2Sensor</a>
    /// </summary>
    let NO2Sensor = _prefixId.prefix "NO2Sensor"
    /// <summary>
    ///   <para>rdfs:label : Nitrogen Oxide (NO) Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Nitrogen Oxide (NO) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#NOSensor">m3lite:NOSensor</a>
    /// </summary>
    let NOSensor = _prefixId.prefix "NOSensor"
    /// <summary>
    ///   <para>rdfs:label : Neighbours Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound were noisy neighbours.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Neighbours">m3lite:Neighbours</a>
    /// </summary>
    let Neighbours = _prefixId.prefix "Neighbours"
    /// <summary>
    ///   <para>rdfs:label : Ozone (O3) Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Ozone (O3) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#O3Sensor">m3lite:O3Sensor</a>
    /// </summary>
    let O3Sensor = _prefixId.prefix "O3Sensor"
    /// <summary>
    ///   <para>rdfs:label : Odometer</para>
    ///   <para>rdfs:comment : An odometer or odograph is an instrument that indicates distance travelled by a vehicle, such as bicycle or automobile.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Odometer">m3lite:Odometer</a>
    /// </summary>
    let Odometer = _prefixId.prefix "Odometer"
    /// <summary>
    ///   <para>rdfs:label : Ohm</para>
    ///   <para>rdfs:comment : Ohm is the unit of electrical resistance.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Ohm">m3lite:Ohm</a>
    /// </summary>
    let Ohm = _prefixId.prefix "Ohm"
    /// <summary>
    ///   <para>rdfs:label : Okta</para>
    ///   <para>rdfs:comment : Okta is the unit to measure the cloud cover.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Okta">m3lite:Okta</a>
    /// </summary>
    let Okta = _prefixId.prefix "Okta"
    /// <summary>
    ///   <para>rdfs:label : Optical Dust Sensor</para>
    ///   <para>rdfs:comment : A sensing device that measures dust particle concentration using optical sensing mean.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#OpticalDustSensor">m3lite:OpticalDustSensor</a>
    /// </summary>
    let OpticalDustSensor = _prefixId.prefix "OpticalDustSensor"
    /// <summary>
    ///   <para>rdfs:label : Others</para>
    ///   <para>rdfs:comment : Relates to phenomenon and unit that are not available currently in the current version of Taxonomy.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Others">m3lite:Others</a>
    /// </summary>
    let Others = _prefixId.prefix "Others"
    /// <summary>
    ///   <para>rdfs:label : Oxygen Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Oxygen (O2) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#OxygenSensor">m3lite:OxygenSensor</a>
    /// </summary>
    let OxygenSensor = _prefixId.prefix "OxygenSensor"
    /// <summary>
    ///   <para>rdfs:label : PH</para>
    ///   <para>rdfs:comment : It is a numeric scale used to specify the acidity or basicity of an aqueous solution.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PH">m3lite:PH</a>
    /// </summary>
    let PH = _prefixId.prefix "PH"
    /// <summary>
    ///   <para>rdfs:label : PH Sensor</para>
    ///   <para>rdfs:comment : Device used to detect PH level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PHSensor">m3lite:PHSensor</a>
    /// </summary>
    let PHSensor = _prefixId.prefix "PHSensor"
    /// <summary>
    ///   <para>rdfs:label : PPM (parts per million)</para>
    ///   <para>rdfs:comment : It describes the concentration of something in water or soil.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PPM">m3lite:PPM</a>
    /// </summary>
    let PPM = _prefixId.prefix "PPM"
    /// <summary>
    ///   <para>rdfs:label : Parts Per Billion</para>
    ///   <para>rdfs:comment : It describes the concentration of something in parts per billion parts of water or soil, expressed in any (but common) unit of measurement.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PartsPerBillion">m3lite:PartsPerBillion</a>
    /// </summary>
    let PartsPerBillion = _prefixId.prefix "PartsPerBillion"
    /// <summary>
    ///   <para>rdfs:label : Pascal</para>
    ///   <para>rdfs:comment : Unit for pressure (e.g., atmospheric pressure).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Pascal">m3lite:Pascal</a>
    /// </summary>
    let Pascal = _prefixId.prefix "Pascal"
    /// <summary>
    ///   <para>rdfs:label : Pedometer</para>
    ///   <para>rdfs:comment : Pedometer is used to count the number of steps when walking, running, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Pedometer">m3lite:Pedometer</a>
    /// </summary>
    let Pedometer = _prefixId.prefix "Pedometer"
    /// <summary>
    ///   <para>rdfs:label : Percent</para>
    ///   <para>rdfs:comment : It is the amount in or for every hundred.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Percent">m3lite:Percent</a>
    /// </summary>
    let Percent = _prefixId.prefix "Percent"
    /// <summary>
    ///   <para>rdfs:label : Place DOI</para>
    ///   <para>rdfs:comment : Location, Place, GPS coordinates as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Place">m3lite:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : Potassium</para>
    ///   <para>rdfs:comment : It is the measure of Blood Potassium Level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Potassium">m3lite:Potassium</a>
    /// </summary>
    let Potassium = _prefixId.prefix "Potassium"
    /// <summary>
    ///   <para>rdfs:label : Pound</para>
    ///   <para>rdfs:comment : A unit of weight equal to 16 oz. 1 pound= 453.592 grams</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Pound">m3lite:Pound</a>
    /// </summary>
    let Pound = _prefixId.prefix "Pound"
    /// <summary>
    ///   <para>rdfs:label : Power</para>
    ///   <para>rdfs:comment : It is the rate, per unit time, at which electrical energy is transferred by an electric circuit.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Power">m3lite:Power</a>
    /// </summary>
    let Power = _prefixId.prefix "Power"
    /// <summary>
    ///   <para>rdfs:label : Precipitation</para>
    ///   <para>rdfs:comment : It is any product of the condensation of atmospheric water vapour that falls under gravity.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Precipitation">m3lite:Precipitation</a>
    /// </summary>
    let Precipitation = _prefixId.prefix "Precipitation"
    /// <summary>
    ///   <para>rdfs:label : Precipitation Sensor</para>
    ///   <para>rdfs:comment : It is a device measuring the amount of precipitation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PrecipitationSensor">m3lite:PrecipitationSensor</a>
    /// </summary>
    let PrecipitationSensor = _prefixId.prefix "PrecipitationSensor"
    /// <summary>
    ///   <para>rdfs:comment : Measure to know if an object is present. It is usually boolean.</para>
    ///   <para>rdfs:label : Presence</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Presence">m3lite:Presence</a>
    /// </summary>
    let Presence = _prefixId.prefix "Presence"
    /// <summary>
    ///   <para>rdfs:label : Presence Detector</para>
    ///   <para>rdfs:comment : Device used to detect if on object is occupied or not.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceDetector">m3lite:PresenceDetector</a>
    /// </summary>
    let PresenceDetector = _prefixId.prefix "PresenceDetector"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the presence of the first driver card.</para>
    ///   <para>rdfs:label : Presence State Driver Card</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard">m3lite:PresenceStateDriverCard</a>
    /// </summary>
    let PresenceStateDriverCard = _prefixId.prefix "PresenceStateDriverCard"
    /// <summary>
    ///   <para>rdfs:label : Presence State Driver Card 1</para>
    ///   <para>rdfs:comment : Indicates the presence of the first driver card.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard1">m3lite:PresenceStateDriverCard1</a>
    /// </summary>
    let PresenceStateDriverCard1 = _prefixId.prefix "PresenceStateDriverCard1"
    /// <summary>
    ///   <para>rdfs:label : Presence State Driver Card 2</para>
    ///   <para>rdfs:comment : Indicates the presence of the second driver card.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard2">m3lite:PresenceStateDriverCard2</a>
    /// </summary>
    let PresenceStateDriverCard2 = _prefixId.prefix "PresenceStateDriverCard2"
    /// <summary>
    ///   <para>rdfs:label : Presence State Emergency Vehicle</para>
    ///   <para>rdfs:comment : The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceStateEmergencyVehicle">m3lite:PresenceStateEmergencyVehicle</a>
    /// </summary>
    let PresenceStateEmergencyVehicle = _prefixId.prefix "PresenceStateEmergencyVehicle"
    /// <summary>
    ///   <para>rdfs:label : Presence State Parking</para>
    ///   <para>rdfs:comment : The presence or absence of a vehicle parked.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceStateParking">m3lite:PresenceStateParking</a>
    /// </summary>
    let PresenceStateParking = _prefixId.prefix "PresenceStateParking"
    /// <summary>
    ///   <para>rdfs:label : Presence State People</para>
    ///   <para>rdfs:comment : The presence or absence of people passing.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PresenceStatePeople">m3lite:PresenceStatePeople</a>
    /// </summary>
    let PresenceStatePeople = _prefixId.prefix "PresenceStatePeople"
    /// <summary>
    ///   <para>rdfs:label : Pressure</para>
    ///   <para>rdfs:comment : It is the physical force exerted on or against an object by something in contact with it.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Pressure">m3lite:Pressure</a>
    /// </summary>
    let Pressure = _prefixId.prefix "Pressure"
    /// <summary>
    ///   <para>rdfs:label : Pressure Sensor</para>
    ///   <para>rdfs:comment : A device used to detect pressure. For example, it can be attached on the bed to infer if the user is lying, sleeping, sitting, bed occupancy, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PressureSensor">m3lite:PressureSensor</a>
    /// </summary>
    let PressureSensor = _prefixId.prefix "PressureSensor"
    /// <summary>
    ///   <para>rdfs:label : Proximity</para>
    ///   <para>rdfs:comment : Measure to detect proximity.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Proximity">m3lite:Proximity</a>
    /// </summary>
    let Proximity = _prefixId.prefix "Proximity"
    /// <summary>
    ///   <para>rdfs:label : Proximity Sensor</para>
    ///   <para>rdfs:comment : Detect if something is within proximity of a sensor.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ProximitySensor">m3lite:ProximitySensor</a>
    /// </summary>
    let ProximitySensor = _prefixId.prefix "ProximitySensor"
    /// <summary>
    ///   <para>rdfs:label : Public Transit Sound Source</para>
    ///   <para>rdfs:comment : When the source of the sound was public transit.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PublicTransit">m3lite:PublicTransit</a>
    /// </summary>
    let PublicTransit = _prefixId.prefix "PublicTransit"
    /// <summary>
    ///   <para>rdfs:label : Pulse Oxymeter</para>
    ///   <para>rdfs:comment : Pulse Oxymeter, SpO2, Blood Oxygen Saturation Sensor are used to measure the concentration of oxygen in the blood.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#PulseOxymeter">m3lite:PulseOxymeter</a>
    /// </summary>
    let PulseOxymeter = _prefixId.prefix "PulseOxymeter"
    /// <summary>
    ///   <para>rdfs:label : QR Code tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be QRCode.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#QRCode">m3lite:QRCode</a>
    /// </summary>
    let QRCode = _prefixId.prefix "QRCode"
    /// <summary>
    ///   <para>rdfs:label : RFID Tagging Device</para>
    ///   <para>rdfs:comment : A tagging device can be RFID.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RFID">m3lite:RFID</a>
    /// </summary>
    let RFID = _prefixId.prefix "RFID"
    /// <summary>
    ///   <para>rdfs:label : Radian</para>
    ///   <para>rdfs:comment : The radian is a unit of angular measure defined such that an angle of one radian subtended from the centre of a unit circle produces an arc with arc length 1.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Radian">m3lite:Radian</a>
    /// </summary>
    let Radian = _prefixId.prefix "Radian"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#radianPerSecond^^xsd:string</para>
    ///   <para>rdfs:label : Radian Per Second</para>
    ///   <para>rdfs:comment : The radian per second is defined as the change in the orientation of an object, in radians, every second. The radian per second is the SI unit of angular (rotational) speed.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RadianPerSecond">m3lite:RadianPerSecond</a>
    /// </summary>
    let RadianPerSecond = _prefixId.prefix "RadianPerSecond"
    /// <summary>
    ///   <para>rdfs:label : Radiation Particle Detector</para>
    ///   <para>rdfs:comment : A particle detector, also known as a radiation detector or Geiger counter, is a device used to detect, track, and/or identify ionising particles, such as those produced by nuclear decay, cosmic radiation, or reactions in a particle accelerator.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RadiationParticleDetector">m3lite:RadiationParticleDetector</a>
    /// </summary>
    let RadiationParticleDetector = _prefixId.prefix "RadiationParticleDetector"
    /// <summary>
    ///   <para>rdfs:label : Radiation Particles Per Minute</para>
    ///   <para>rdfs:comment : The number of ionizing events detected in one minute.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RadiationParticlesPerMinute">m3lite:RadiationParticlesPerMinute</a>
    /// </summary>
    let RadiationParticlesPerMinute = _prefixId.prefix "RadiationParticlesPerMinute"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://sweet.jpl.nasa.gov/ontology/property.owl#Rainfall^^xsd:string</para>
    ///   <para>rdfs:label : Rainfall</para>
    ///   <para>rdfs:comment : The depth of precipitation (water-equivalent) that accumulated over a measurement time quantity.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Rainfall">m3lite:Rainfall</a>
    /// </summary>
    let Rainfall = _prefixId.prefix "Rainfall"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/dim#ReactivePower^^xsd:string</para>
    ///   <para>rdfs:label : Reactive Power</para>
    ///   <para>rdfs:comment : The portion of electricity that establishes and sustains the electric and magnetic fields of alternating-current equipment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ReactivePower">m3lite:ReactivePower</a>
    /// </summary>
    let ReactivePower = _prefixId.prefix "ReactivePower"
    /// <summary>
    ///   <para>rdfs:label : Recognized Activity</para>
    ///   <para>rdfs:comment : Activity Recognized. This is usually made available as a part of analysis done by Google. The available activities recognized are IN_VEHICLE, ON_BICYCLE, ON_FOOT, RUNNING, STILL, TILTING, UNKNOWN, and WALKING.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RecognizedActivity">m3lite:RecognizedActivity</a>
    /// </summary>
    let RecognizedActivity = _prefixId.prefix "RecognizedActivity"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://sweet.jpl.nasa.gov/ontology/property.owl#RelativeHumidity^^xsd:string</para>
    ///   <para>rdfs:label : Relative Humidity</para>
    ///   <para>rdfs:comment : The ratio of vapour pressure to saturation vapour pressure, where vapour pressure is the pressure exerted by the molecules of water vapour and saturation vapour pressure is the pressure exerted by molecules of water vapour in AIR that has attained saturation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RelativeHumidity">m3lite:RelativeHumidity</a>
    /// </summary>
    let RelativeHumidity = _prefixId.prefix "RelativeHumidity"
    /// <summary>
    ///   <para>rdfs:label : Connected Users</para>
    ///   <para>rdfs:comment : Connected Users to a communication channel/platform</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ResAverageLicConnectedUsers">m3lite:ResAverageLicConnectedUsers</a>
    /// </summary>
    let ResAverageLicConnectedUsers = _prefixId.prefix "ResAverageLicConnectedUsers"
    /// <summary>
    ///   <para>rdfs:label : ERAB Drop</para>
    ///   <para>rdfs:comment : ERAB Drop.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RetERabDrop">m3lite:RetERabDrop</a>
    /// </summary>
    let RetERabDrop = _prefixId.prefix "RetERabDrop"
    /// <summary>
    ///   <para>rdfs:label : Revolutions Per Minute</para>
    ///   <para>rdfs:comment : Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RevolutionsPerMinute">m3lite:RevolutionsPerMinute</a>
    /// </summary>
    let RevolutionsPerMinute = _prefixId.prefix "RevolutionsPerMinute"
    /// <summary>
    ///   <para>rdfs:label : Road Occupancy</para>
    ///   <para>rdfs:comment : Ratio of time on which a road lane section is occupied by vehicles within a given period of time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RoadOccupancy">m3lite:RoadOccupancy</a>
    /// </summary>
    let RoadOccupancy = _prefixId.prefix "RoadOccupancy"
    /// <summary>
    ///   <para>rdfs:label : Road Surface Thermometer</para>
    ///   <para>rdfs:comment : Device used to measure the road Surface temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RoadSurfaceThermometer">m3lite:RoadSurfaceThermometer</a>
    /// </summary>
    let RoadSurfaceThermometer = _prefixId.prefix "RoadSurfaceThermometer"
    /// <summary>
    ///   <para>rdfs:label : Road Temperature</para>
    ///   <para>rdfs:comment : Temperature of the road.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RoadTemperature">m3lite:RoadTemperature</a>
    /// </summary>
    let RoadTemperature = _prefixId.prefix "RoadTemperature"
    /// <summary>
    ///   <para>rdfs:label : Room Temperature</para>
    ///   <para>rdfs:comment : Temperature of a room.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RoomTemperature">m3lite:RoomTemperature</a>
    /// </summary>
    let RoomTemperature = _prefixId.prefix "RoomTemperature"
    /// <summary>
    ///   <para>rdfs:comment : Rotational speed (or speed of revolution) of an object rotating around an axis is the number of turns of the object divided by time, specified as revolutions per minute (rpm), revolutions per second (rev/s), or radians per second (rad/s). (Source Wikipedia)</para>
    ///   <para>rdfs:label : Rotational Speed</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RotationalSpeed">m3lite:RotationalSpeed</a>
    /// </summary>
    let RotationalSpeed = _prefixId.prefix "RotationalSpeed"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#rotationalSpeed^^xsd:string</para>
    ///   <para>rdfs:label : Rotational Speed Engine</para>
    ///   <para>rdfs:comment : Rotational speed is a property that is the rate of rotation of a material around an axis, in this case the engine cylinders.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#RotationalSpeedEngine">m3lite:RotationalSpeedEngine</a>
    /// </summary>
    let RotationalSpeedEngine = _prefixId.prefix "RotationalSpeedEngine"
    /// <summary>
    ///   <para>rdfs:label : Sulphur Dioxide (SO2) Sensor</para>
    ///   <para>rdfs:comment : Device use to detect Sulphur Dioxide (SO2) level in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SO2Sensor">m3lite:SO2Sensor</a>
    /// </summary>
    let SO2Sensor = _prefixId.prefix "SO2Sensor"
    /// <summary>
    ///   <para>rdfs:label : SPO2</para>
    ///   <para>rdfs:comment : It is a measure of the amount of oxygenated haemoglobin in the blood.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SPO2">m3lite:SPO2</a>
    /// </summary>
    let SPO2 = _prefixId.prefix "SPO2"
    /// <summary>
    ///   <para>rdfs:label : Salinity</para>
    ///   <para>rdfs:comment : It is the measure of all the salts dissolved in water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Salinity">m3lite:Salinity</a>
    /// </summary>
    let Salinity = _prefixId.prefix "Salinity"
    /// <summary>
    ///   <para>rdfs:label : Salt Meter</para>
    ///   <para>rdfs:comment : Device use to detect salinity of water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SaltMeter">m3lite:SaltMeter</a>
    /// </summary>
    let SaltMeter = _prefixId.prefix "SaltMeter"
    /// <summary>
    ///   <para>rdfs:label : Scale</para>
    ///   <para>rdfs:comment : Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values are part of a continuous variable which can take any numeric value.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Scale">m3lite:Scale</a>
    /// </summary>
    let Scale = _prefixId.prefix "Scale"
    /// <summary>
    ///   <para>rdfs:label : Seat Belt Tension Actuating Device</para>
    ///   <para>rdfs:comment :  Actuator used to turn Seat Belt Tension Actuator on or off. </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SeatBeltTensionSensor">m3lite:SeatBeltTensionSensor</a>
    /// </summary>
    let SeatBeltTensionSensor = _prefixId.prefix "SeatBeltTensionSensor"
    /// <summary>
    ///   <para>rdfs:label : Second Angle</para>
    ///   <para>rdfs:comment : It is a unit of angular measurement equal to 1/60 of one degree.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SecondAngle">m3lite:SecondAngle</a>
    /// </summary>
    let SecondAngle = _prefixId.prefix "SecondAngle"
    /// <summary>
    ///   <para>rdfs:label : Second Time</para>
    ///   <para>rdfs:comment : Qualitatively defined as the second division of the hour by sixty, the first division by sixty being the minute. SI definition of second is "the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium 133 atom.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SecondTime">m3lite:SecondTime</a>
    /// </summary>
    let SecondTime = _prefixId.prefix "SecondTime"
    /// <summary>
    ///   <para>rdfs:label : Seismometer</para>
    ///   <para>rdfs:comment : Seismometers are instruments that measure motions of the ground, including those of seismic waves generated by earthquakes, volcanic eruptions, and other seismic sources.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Seismometer">m3lite:Seismometer</a>
    /// </summary>
    let Seismometer = _prefixId.prefix "Seismometer"
    /// <summary>
    ///   <para>rdfs:label : Shake Sensor</para>
    ///   <para>rdfs:comment : Shake sensor is used to deduce the quality of the road, earthquakes.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ShakeSensor">m3lite:ShakeSensor</a>
    /// </summary>
    let ShakeSensor = _prefixId.prefix "ShakeSensor"
    /// <summary>
    ///   <para>rdfs:label : Shower Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the shower.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Shower">m3lite:Shower</a>
    /// </summary>
    let Shower = _prefixId.prefix "Shower"
    /// <summary>
    ///   <para>rdfs:label : Siemens Per Metre, Siemens Per Meter</para>
    ///   <para>rdfs:comment : Conductivity is measured in Siemens per metre (S/m).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SiemensPerMetre">m3lite:SiemensPerMetre</a>
    /// </summary>
    let SiemensPerMetre = _prefixId.prefix "SiemensPerMetre"
    /// <summary>
    ///   <para>rdfs:label : Sink Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the sink.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Sink">m3lite:Sink</a>
    /// </summary>
    let Sink = _prefixId.prefix "Sink"
    /// <summary>
    ///   <para>rdfs:label : Sirens Sound Source</para>
    ///   <para>rdfs:comment : When source of the sound were sirens either from ambulance, police car or factory etc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Sirens">m3lite:Sirens</a>
    /// </summary>
    let Sirens = _prefixId.prefix "Sirens"
    /// <summary>
    ///   <para>rdfs:label : Skin conductance, GSR</para>
    ///   <para>rdfs:comment : Electroderal activity (also known as skin conductance or galvanic skin response) directly correlates to the sympathetic nervous system activity and thus provides a powerful tool for monitoring arousal and certain aspects of autonomic regulation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SkinConductance">m3lite:SkinConductance</a>
    /// </summary>
    let SkinConductance = _prefixId.prefix "SkinConductance"
    /// <summary>
    ///   <para>rdfs:label : Skin Conductance Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Skin Conductance.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SkinConductanceSensor">m3lite:SkinConductanceSensor</a>
    /// </summary>
    let SkinConductanceSensor = _prefixId.prefix "SkinConductanceSensor"
    /// <summary>
    ///   <para>rdfs:label : Smoke Detector</para>
    ///   <para>rdfs:comment : Device used to detect if there is a fire or the smoke.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SmokeDetector">m3lite:SmokeDetector</a>
    /// </summary>
    let SmokeDetector = _prefixId.prefix "SmokeDetector"
    /// <summary>
    ///   <para>rdfs:label : Snow Chains Actuating Device</para>
    ///   <para>rdfs:comment : The actuator that turn Snow chains on/off.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SnowChains">m3lite:SnowChains</a>
    /// </summary>
    let SnowChains = _prefixId.prefix "SnowChains"
    /// <summary>
    ///   <para>rdfs:label : Sodium</para>
    ///   <para>rdfs:comment : Measure of Blood Sodium level.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Sodium">m3lite:Sodium</a>
    /// </summary>
    let Sodium = _prefixId.prefix "Sodium"
    /// <summary>
    ///   <para>rdfs:label : Soil Humidity</para>
    ///   <para>rdfs:comment : It is the quantity of water contained in a material, such as soil. </para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoilHumidity">m3lite:SoilHumidity</a>
    /// </summary>
    let SoilHumidity = _prefixId.prefix "SoilHumidity"
    /// <summary>
    ///   <para>rdfs:label : Soil Humidity Sensor</para>
    ///   <para>rdfs:comment : Soil Humidity sensor, Soil moisture, Hygrometer are an instrument used for measuring the soil moisture or soil humidity.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoilHumiditySensor">m3lite:SoilHumiditySensor</a>
    /// </summary>
    let SoilHumiditySensor = _prefixId.prefix "SoilHumiditySensor"
    /// <summary>
    ///   <para>rdfs:label : Soil Moisture Tension</para>
    ///   <para>rdfs:comment : The force per unit area required to remove film water from soil.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoilMoistureTension">m3lite:SoilMoistureTension</a>
    /// </summary>
    let SoilMoistureTension = _prefixId.prefix "SoilMoistureTension"
    /// <summary>
    ///   <para>rdfs:label : Soil Temperature</para>
    ///   <para>rdfs:comment : Soil temperature is the bulk temperature of the soil, not the surface (skin) temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoilTemperature">m3lite:SoilTemperature</a>
    /// </summary>
    let SoilTemperature = _prefixId.prefix "SoilTemperature"
    /// <summary>
    ///   <para>rdfs:label : Soil Thermometer</para>
    ///   <para>rdfs:comment : This sensor reports Soil temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoilThermometer">m3lite:SoilThermometer</a>
    /// </summary>
    let SoilThermometer = _prefixId.prefix "SoilThermometer"
    /// <summary>
    ///   <para>rdfs:label : Solar Radiation Measurement, PAR Measurement (Photosynthetically Active Radiation)</para>
    ///   <para>rdfs:comment : It is the power per unit area received from the Sun in the form of electromagnetic radiation in the wavelength range of the measuring instrument. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SolarRadiation">m3lite:SolarRadiation</a>
    /// </summary>
    let SolarRadiation = _prefixId.prefix "SolarRadiation"
    /// <summary>
    ///   <para>rdfs:label : Solar Radiation Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Solar Radiation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SolarRadiationSensor">m3lite:SolarRadiationSensor</a>
    /// </summary>
    let SolarRadiationSensor = _prefixId.prefix "SolarRadiationSensor"
    /// <summary>
    ///   <para>rdfs:label : Sound, Noise Level</para>
    ///   <para>rdfs:comment : Measure of noise level in the environment</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Sound">m3lite:Sound</a>
    /// </summary>
    let Sound = _prefixId.prefix "Sound"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#soundPressure^^xsd:string</para>
    ///   <para>rdfs:label : Sound Pressure Level</para>
    ///   <para>rdfs:comment : Sound pressure level is a logarithmic measure of the RMS sound pressure of a sound relative to a reference value, the threshold of hearing. The reference sound pressure was chosen conventionally to correspond to the quietest sound at 1000 Hz that the human ear can detect (20 uPa). In this case, the specific parameter is measured in an open environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoundPressureLevel">m3lite:SoundPressureLevel</a>
    /// </summary>
    let SoundPressureLevel = _prefixId.prefix "SoundPressureLevel"
    /// <summary>
    ///   <para>rdfs:comment : Similar to Sound.</para>
    ///   <para>rdfs:label : Sound Pressure Level Ambient</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoundPressureLevelAmbient">m3lite:SoundPressureLevelAmbient</a>
    /// </summary>
    let SoundPressureLevelAmbient = _prefixId.prefix "SoundPressureLevelAmbient"
    /// <summary>
    ///   <para>rdfs:label : Sound Sensor</para>
    ///   <para>rdfs:comment : Sensor used to detect Noise level. It can be Sound Sensor, Noise level Sensor, Volume sensor, Microphone</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoundSensor">m3lite:SoundSensor</a>
    /// </summary>
    let SoundSensor = _prefixId.prefix "SoundSensor"
    /// <summary>
    ///   <para>rdfs:label : Sound Source</para>
    ///   <para>rdfs:comment : Source where the sound originated.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SoundSource">m3lite:SoundSource</a>
    /// </summary>
    let SoundSource = _prefixId.prefix "SoundSource"
    /// <summary>
    ///   <para>rdfs:label : Source</para>
    ///   <para>rdfs:comment : Environmental Origin of a particular observation. With respect to one kind of Source (Sound source), it can be coming from traffic, siren of a police car, etc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Source">m3lite:Source</a>
    /// </summary>
    let Source = _prefixId.prefix "Source"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/quantity#speed^^xsd:string</para>
    ///   <para>rdfs:label : Speed</para>
    ///   <para>rdfs:comment : The rate at which someone or something moves or operates or is able to move or operate.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Speed">m3lite:Speed</a>
    /// </summary>
    let Speed = _prefixId.prefix "Speed"
    /// <summary>
    ///   <para>rdfs:label : Speed Average</para>
    ///   <para>rdfs:comment : A measure of the average rate of motion of an object.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SpeedAverage">m3lite:SpeedAverage</a>
    /// </summary>
    let SpeedAverage = _prefixId.prefix "SpeedAverage"
    /// <summary>
    ///   <para>rdfs:label : Speed Instantaneous</para>
    ///   <para>rdfs:comment : A measure of the instantaneous rate of motion of an object.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SpeedInstantaneous">m3lite:SpeedInstantaneous</a>
    /// </summary>
    let SpeedInstantaneous = _prefixId.prefix "SpeedInstantaneous"
    /// <summary>
    ///   <para>rdfs:label : Speed Median</para>
    ///   <para>rdfs:comment : A measure of the median rate of motion of an object.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SpeedMedian">m3lite:SpeedMedian</a>
    /// </summary>
    let SpeedMedian = _prefixId.prefix "SpeedMedian"
    /// <summary>
    ///   <para>rdfs:label : Speed Sensor</para>
    ///   <para>rdfs:comment : Sensor used to detect speed.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SpeedSensor">m3lite:SpeedSensor</a>
    /// </summary>
    let SpeedSensor = _prefixId.prefix "SpeedSensor"
    /// <summary>
    ///   <para>rdfs:label : Step</para>
    ///   <para>rdfs:comment : It is a measure of number of Step taken.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Step">m3lite:Step</a>
    /// </summary>
    let Step = _prefixId.prefix "Step"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Direction</para>
    ///   <para>rdfs:comment : The position of the Sun in the sky is a function of both time and the geographic coordinates of the observer on the surface of the Earth. (Source Wikipedia).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SunPositionDirection">m3lite:SunPositionDirection</a>
    /// </summary>
    let SunPositionDirection = _prefixId.prefix "SunPositionDirection"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Direction Sensor</para>
    ///   <para>rdfs:comment : Sensor used to detect sun position.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SunPositionDirectionSensor">m3lite:SunPositionDirectionSensor</a>
    /// </summary>
    let SunPositionDirectionSensor = _prefixId.prefix "SunPositionDirectionSensor"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Elevation</para>
    ///   <para>rdfs:comment : It is the altitude of the sun, the angle between the horizon and the centre of the sun's disc.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SunPositionElevation">m3lite:SunPositionElevation</a>
    /// </summary>
    let SunPositionElevation = _prefixId.prefix "SunPositionElevation"
    /// <summary>
    ///   <para>rdfs:label : Sun Position Elevation Sensor</para>
    ///   <para>rdfs:comment : Device used to detect sun elevation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SunPositionElevationSensor">m3lite:SunPositionElevationSensor</a>
    /// </summary>
    let SunPositionElevationSensor = _prefixId.prefix "SunPositionElevationSensor"
    /// <summary>
    ///   <para>rdfs:label : Systolic Blood Pressure</para>
    ///   <para>rdfs:comment : It is the pressure when the heart beats while pumping blood.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#SystolicBloodPressure">m3lite:SystolicBloodPressure</a>
    /// </summary>
    let SystolicBloodPressure = _prefixId.prefix "SystolicBloodPressure"
    /// <summary>
    ///   <para>rdfs:label : TV Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the television.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TV">m3lite:TV</a>
    /// </summary>
    let TV = _prefixId.prefix "TV"
    /// <summary>
    ///   <para>rdfs:label : Telephone Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the Telephone.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Telephone">m3lite:Telephone</a>
    /// </summary>
    let Telephone = _prefixId.prefix "Telephone"
    /// <summary>
    ///   <para>rdfs:label : Temperature</para>
    ///   <para>rdfs:comment : It is the air temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Temperature">m3lite:Temperature</a>
    /// </summary>
    let Temperature = _prefixId.prefix "Temperature"
    /// <summary>
    ///   <para>rdfs:label : Temperature Engine</para>
    ///   <para>rdfs:comment : The temperature of a vehicle engine.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TemperatureEngine">m3lite:TemperatureEngine</a>
    /// </summary>
    let TemperatureEngine = _prefixId.prefix "TemperatureEngine"
    /// <summary>
    ///   <para>rdfs:label : Temperature Waste Container</para>
    ///   <para>rdfs:comment : The temperature of the air that would be indicated by a thermometer exposed to the air inside a waste container.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TemperatureWasteContainer">m3lite:TemperatureWasteContainer</a>
    /// </summary>
    let TemperatureWasteContainer = _prefixId.prefix "TemperatureWasteContainer"
    /// <summary>
    ///   <para>rdfs:label : Tesla</para>
    ///   <para>rdfs:comment : It is the SI unit of magnetic flux density.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Tesla">m3lite:Tesla</a>
    /// </summary>
    let Tesla = _prefixId.prefix "Tesla"
    /// <summary>
    ///   <para>rdfs:label : Thermometer</para>
    ///   <para>rdfs:comment : A device to measure the temperature in a room or outside.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Thermometer">m3lite:Thermometer</a>
    /// </summary>
    let Thermometer = _prefixId.prefix "Thermometer"
    /// <summary>
    ///   <para>rdfs:label : Throttle Position Sensor</para>
    ///   <para>rdfs:comment : It is a device used to monitor the throttle position of a vehicle.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#ThrottleSensor">m3lite:ThrottleSensor</a>
    /// </summary>
    let ThrottleSensor = _prefixId.prefix "ThrottleSensor"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether a person (or object) has overpassed a particular time threshold (e.g. maximum number of hours driving, etc.)</para>
    ///   <para>rdfs:label : Time Related State</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TimeRelatedState">m3lite:TimeRelatedState</a>
    /// </summary>
    let TimeRelatedState = _prefixId.prefix "TimeRelatedState"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether the driver of a vehicle approaches or exceeds his/her working time limits.</para>
    ///   <para>rdfs:label : Time Related State Driver</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver">m3lite:TimeRelatedStateDriver</a>
    /// </summary>
    let TimeRelatedStateDriver = _prefixId.prefix "TimeRelatedStateDriver"
    /// <summary>
    ///   <para>rdfs:label : Time Related State Driver 1</para>
    ///   <para>rdfs:comment : Indicates if the first driver approaches or exceeds working time limits (or other limits).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver1">m3lite:TimeRelatedStateDriver1</a>
    /// </summary>
    let TimeRelatedStateDriver1 = _prefixId.prefix "TimeRelatedStateDriver1"
    /// <summary>
    ///   <para>rdfs:label : Time Related State Driver 2</para>
    ///   <para>rdfs:comment : Indicates if the second driver approaches or exceeds working time limits (or other limits).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver2">m3lite:TimeRelatedStateDriver2</a>
    /// </summary>
    let TimeRelatedStateDriver2 = _prefixId.prefix "TimeRelatedStateDriver2"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://sweet.jpl.nasa.gov/2.3/propTime.owl#Timestamp^^xsd:string</para>
    ///   <para>rdfs:label : Timestamp</para>
    ///   <para>rdfs:comment : Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Timestamp">m3lite:Timestamp</a>
    /// </summary>
    let Timestamp = _prefixId.prefix "Timestamp"
    /// <summary>
    ///   <para>rdfs:label : Tonne</para>
    ///   <para>rdfs:comment : It is a non-SI metric unit of mass equal to 1,000 kilograms.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Tonne">m3lite:Tonne</a>
    /// </summary>
    let Tonne = _prefixId.prefix "Tonne"
    /// <summary>
    ///   <para>rdfs:label : Touch Sensor</para>
    ///   <para>rdfs:comment : Device that captures and records physical touch or embrace on a device and/or object.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TouchSensor">m3lite:TouchSensor</a>
    /// </summary>
    let TouchSensor = _prefixId.prefix "TouchSensor"
    /// <summary>
    ///   <para>rdfs:label : Tourism DOI</para>
    ///   <para>rdfs:comment : Tourism as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Tourism">m3lite:Tourism</a>
    /// </summary>
    let Tourism = _prefixId.prefix "Tourism"
    /// <summary>
    ///   <para>rdfs:label : Traffic</para>
    ///   <para>rdfs:comment : When the source of the sound was traffic.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Traffic">m3lite:Traffic</a>
    /// </summary>
    let Traffic = _prefixId.prefix "Traffic"
    /// <summary>
    ///   <para>rdfs:label : Traffic Intensity</para>
    ///   <para>rdfs:comment : The intensity of a traffic flow is the number of vehicles passing a cross section of a road in a unit of time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#TrafficIntensity">m3lite:TrafficIntensity</a>
    /// </summary>
    let TrafficIntensity = _prefixId.prefix "TrafficIntensity"
    /// <summary>
    ///   <para>rdfs:label : Transportation DOI</para>
    ///   <para>rdfs:comment : Transportation, Smart Car/Vehicle, Intelligent Transport System (ITS) as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Transportation">m3lite:Transportation</a>
    /// </summary>
    let Transportation = _prefixId.prefix "Transportation"
    /// <summary>
    ///   <para>rdfs:label : Ultrasonic Sensor</para>
    ///   <para>rdfs:comment : Ultrasonic sensors are used to deduce human posture in smart home for example.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#UltrasonicSensor">m3lite:UltrasonicSensor</a>
    /// </summary>
    let UltrasonicSensor = _prefixId.prefix "UltrasonicSensor"
    /// <summary>
    ///   <para>rdfs:label : Volatile Organic Compound (VOC) Sensor</para>
    ///   <para>rdfs:comment : Sensor that detects levels of Volatile Organic Components (VOC) in the environment.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VOCSensor">m3lite:VOCSensor</a>
    /// </summary>
    let VOCSensor = _prefixId.prefix "VOCSensor"
    /// <summary>
    ///   <para>rdfs:label : Vehicle Count Sensor</para>
    ///   <para>rdfs:comment : Device used to count the number of vehicles (e.g., used within the Citypulse project).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VehicleCountSensor">m3lite:VehicleCountSensor</a>
    /// </summary>
    let VehicleCountSensor = _prefixId.prefix "VehicleCountSensor"
    /// <summary>
    ///   <para>rdfs:label : Vehicle Overspeed State</para>
    ///   <para>rdfs:comment : Measure to indicates whether the vehicle is exceeding the legal speed limit.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VehicleOverspeedState">m3lite:VehicleOverspeedState</a>
    /// </summary>
    let VehicleOverspeedState = _prefixId.prefix "VehicleOverspeedState"
    /// <summary>
    ///   <para>rdfs:label :  Vehicle Presence Detector</para>
    ///   <para>rdfs:comment : Device used to detect if an vehicle is present at a place.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VehiclePresenceDetector">m3lite:VehiclePresenceDetector</a>
    /// </summary>
    let VehiclePresenceDetector = _prefixId.prefix "VehiclePresenceDetector"
    /// <summary>
    ///   <para>rdfs:label : Vehicles Per Minute</para>
    ///   <para>rdfs:comment : Number of vehicles that traverse a concrete region of the space in one minute.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VehiclesPerMinute">m3lite:VehiclesPerMinute</a>
    /// </summary>
    let VehiclesPerMinute = _prefixId.prefix "VehiclesPerMinute"
    /// <summary>
    ///   <para>rdfs:label : Ventilation Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the ventilation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Ventilation">m3lite:Ventilation</a>
    /// </summary>
    let Ventilation = _prefixId.prefix "Ventilation"
    /// <summary>
    ///   <para>rdfs:label : Visibility</para>
    ///   <para>rdfs:comment : The state of being able to see or be seen.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Visibility">m3lite:Visibility</a>
    /// </summary>
    let Visibility = _prefixId.prefix "Visibility"
    /// <summary>
    ///   <para>rdfs:label : Visibility Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Visibility.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VisibilitySensor">m3lite:VisibilitySensor</a>
    /// </summary>
    let VisibilitySensor = _prefixId.prefix "VisibilitySensor"
    /// <summary>
    ///   <para>rdfs:label : Voice Command</para>
    ///   <para>rdfs:comment : A voice command to control a voice controlled system or environment, such as a smart home.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VoiceCommand">m3lite:VoiceCommand</a>
    /// </summary>
    let VoiceCommand = _prefixId.prefix "VoiceCommand"
    /// <summary>
    ///   <para>rdfs:label : Voice Command Controller</para>
    ///   <para>rdfs:comment : An actuating device called  that allows to semi-control the environment of the Voice Command Sensor.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VoiceCommandController">m3lite:VoiceCommandController</a>
    /// </summary>
    let VoiceCommandController = _prefixId.prefix "VoiceCommandController"
    /// <summary>
    ///   <para>rdfs:label : Voice Command Sensor</para>
    ///   <para>rdfs:comment : Sensor that uses automatic speech recognition technology to match or reject a recorded voice command according to a specified set of available voice commands.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VoiceCommandSensor">m3lite:VoiceCommandSensor</a>
    /// </summary>
    let VoiceCommandSensor = _prefixId.prefix "VoiceCommandSensor"
    /// <summary>
    ///   <para>rdfs:label : Volt</para>
    ///   <para>rdfs:comment : The SI unit of electromotive force, the difference of potential that would carry one ampere of current against one ohm resistance.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Volt">m3lite:Volt</a>
    /// </summary>
    let Volt = _prefixId.prefix "Volt"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#var^^xsd:string</para>
    ///   <para>rdfs:label : Volt Ampere Reactive, VAR</para>
    ///   <para>rdfs:comment : In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VoltAmpereReactive">m3lite:VoltAmpereReactive</a>
    /// </summary>
    let VoltAmpereReactive = _prefixId.prefix "VoltAmpereReactive"
    /// <summary>
    ///   <para>rdfs:label : Voltage</para>
    ///   <para>rdfs:comment : An electromotive force or potential difference expressed in volts (Source Google).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Voltage">m3lite:Voltage</a>
    /// </summary>
    let Voltage = _prefixId.prefix "Voltage"
    /// <summary>
    ///   <para>rdfs:label : Voltage Sensor</para>
    ///   <para>rdfs:comment : Device which can measure the difference in electric potential energy between two points per unit electric charge.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#VoltageSensor">m3lite:VoltageSensor</a>
    /// </summary>
    let VoltageSensor = _prefixId.prefix "VoltageSensor"
    /// <summary>
    ///   <para>rdfs:label : Washing Machine Actuation Device</para>
    ///   <para>rdfs:comment : An actuator to automatically switch on/off the washing machine.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WashingMachine">m3lite:WashingMachine</a>
    /// </summary>
    let WashingMachine = _prefixId.prefix "WashingMachine"
    /// <summary>
    ///   <para>rdfs:label : Water Conductivity Sensor</para>
    ///   <para>rdfs:comment : Device used to measure the conductivity of water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterConductivitySensor">m3lite:WaterConductivitySensor</a>
    /// </summary>
    let WaterConductivitySensor = _prefixId.prefix "WaterConductivitySensor"
    /// <summary>
    ///   <para>rdfs:label : Water Level</para>
    ///   <para>rdfs:comment : The height reached by the water in a reservoir, river, storage tank, or similar.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterLevel">m3lite:WaterLevel</a>
    /// </summary>
    let WaterLevel = _prefixId.prefix "WaterLevel"
    /// <summary>
    ///   <para>rdfs:label : Water NH4 Ion Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure NH4 concentration level in the water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterNH4IonSensor">m3lite:WaterNH4IonSensor</a>
    /// </summary>
    let WaterNH4IonSensor = _prefixId.prefix "WaterNH4IonSensor"
    /// <summary>
    ///   <para>rdfs:label : Water NO3 Ion Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure NO3 concentration level in the water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterNO3IonSensor">m3lite:WaterNO3IonSensor</a>
    /// </summary>
    let WaterNO3IonSensor = _prefixId.prefix "WaterNO3IonSensor"
    /// <summary>
    ///   <para>rdfs:label : Water O2 Ion Sensor</para>
    ///   <para>rdfs:comment : Sensor used to measure O2 concentration level in the water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterO2IonSensor">m3lite:WaterO2IonSensor</a>
    /// </summary>
    let WaterO2IonSensor = _prefixId.prefix "WaterO2IonSensor"
    /// <summary>
    ///   <para>rdfs:label : Water PH Sensor</para>
    ///   <para>rdfs:comment : Device used to detect PH level of water.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterPHSensor">m3lite:WaterPHSensor</a>
    /// </summary>
    let WaterPHSensor = _prefixId.prefix "WaterPHSensor"
    /// <summary>
    ///   <para>rdfs:label : Water Temperature</para>
    ///   <para>rdfs:comment : Sea surface temperature (SST) is the water temperature close to the ocean's surface.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterTemperature">m3lite:WaterTemperature</a>
    /// </summary>
    let WaterTemperature = _prefixId.prefix "WaterTemperature"
    /// <summary>
    ///   <para>rdfs:label : Water Thermometer</para>
    ///   <para>rdfs:comment : This sensor reports Water temperature.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WaterThermometer">m3lite:WaterThermometer</a>
    /// </summary>
    let WaterThermometer = _prefixId.prefix "WaterThermometer"
    /// <summary>
    ///   <para>rdfs:label : Watt (W)</para>
    ///   <para>rdfs:comment : It is the SI unit of power, equivalent to one joule per second, corresponding to the rate of consumption of energy in an electric circuit where the potential difference is one volt and the current one ampere.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Watt">m3lite:Watt</a>
    /// </summary>
    let Watt = _prefixId.prefix "Watt"
    /// <summary>
    ///   <para>rdfs:seeAlso : http://purl.oclc.org/NET/ssnx/qu/unit#wattPerSquareMetre^^xsd:string</para>
    ///   <para>rdfs:label : Watt Per Square Metre, Watt Per Square Meter</para>
    ///   <para>rdfs:comment : It is the SI unit for radiative and other energy fluxes.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WattPerSquareMetre">m3lite:WattPerSquareMetre</a>
    /// </summary>
    let WattPerSquareMetre = _prefixId.prefix "WattPerSquareMetre"
    /// <summary>
    ///   <para>rdfs:label : Weather Forecasting DOI</para>
    ///   <para>rdfs:comment : Weather Forecasting, Meterology as an Internet of Things (IoT) applicative domain.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Weather">m3lite:Weather</a>
    /// </summary>
    let Weather = _prefixId.prefix "Weather"
    /// <summary>
    ///   <para>rdfs:label : Weather Luminosity</para>
    ///   <para>rdfs:comment : Luminosity.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WeatherLuminosity">m3lite:WeatherLuminosity</a>
    /// </summary>
    let WeatherLuminosity = _prefixId.prefix "WeatherLuminosity"
    /// <summary>
    ///   <para>rdfs:label : Weather Precipitation</para>
    ///   <para>rdfs:comment : Weather Precipitation.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WeatherPrecipitation">m3lite:WeatherPrecipitation</a>
    /// </summary>
    let WeatherPrecipitation = _prefixId.prefix "WeatherPrecipitation"
    /// <summary>
    ///   <para>rdfs:label : Weight</para>
    ///   <para>rdfs:comment : A body's relative mass or the quantity of matter contained by it, giving rise to a downward force; the heaviness of a person or thing.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Weight">m3lite:Weight</a>
    /// </summary>
    let Weight = _prefixId.prefix "Weight"
    /// <summary>
    ///   <para>rdfs:label : Weight Sensor</para>
    ///   <para>rdfs:comment : Device used to weight an object.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WeightSensor">m3lite:WeightSensor</a>
    /// </summary>
    let WeightSensor = _prefixId.prefix "WeightSensor"
    /// <summary>
    ///   <para>rdfs:label : WiFi Interface Energy Meter</para>
    ///   <para>rdfs:comment : Measure the average power consumption of the WiFi interface nodes.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WiFiInterfaceEnergyMeter">m3lite:WiFiInterfaceEnergyMeter</a>
    /// </summary>
    let WiFiInterfaceEnergyMeter = _prefixId.prefix "WiFiInterfaceEnergyMeter"
    /// <summary>
    ///   <para>rdfs:label : Wind Chill</para>
    ///   <para>rdfs:comment : The cooling effect of wind blowing on a surface.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WindChill">m3lite:WindChill</a>
    /// </summary>
    let WindChill = _prefixId.prefix "WindChill"
    /// <summary>
    ///   <para>rdfs:label : Wind Chill Sensor</para>
    ///   <para>rdfs:comment : Device used to detect Wind Chill.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WindChillSensor">m3lite:WindChillSensor</a>
    /// </summary>
    let WindChillSensor = _prefixId.prefix "WindChillSensor"
    /// <summary>
    ///   <para>rdfs:label : Wind Direction</para>
    ///   <para>rdfs:comment : The geodetic azimuth of the direction from which the wind is blowing.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WindDirection">m3lite:WindDirection</a>
    /// </summary>
    let WindDirection = _prefixId.prefix "WindDirection"
    /// <summary>
    ///   <para>rdfs:label : Wind Direction Sensor</para>
    ///   <para>rdfs:comment : Device used to detect wind direction.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WindDirectionSensor">m3lite:WindDirectionSensor</a>
    /// </summary>
    let WindDirectionSensor = _prefixId.prefix "WindDirectionSensor"
    /// <summary>
    ///   <para>rdfs:label : Wind Velocity, Wind Speed</para>
    ///   <para>rdfs:comment : The ratio of the distance covered by moving air to the time quantity taken to cover it.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WindSpeed">m3lite:WindSpeed</a>
    /// </summary>
    let WindSpeed = _prefixId.prefix "WindSpeed"
    /// <summary>
    ///   <para>rdfs:label : Wind Speed Sensor</para>
    ///   <para>rdfs:comment : Wind Speed Sensor, Anemometer or Wind Velocity Sensor is used to measure the wind speed.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WindSpeedSensor">m3lite:WindSpeedSensor</a>
    /// </summary>
    let WindSpeedSensor = _prefixId.prefix "WindSpeedSensor"
    /// <summary>
    ///   <para>rdfs:label : Window Actuating Device</para>
    ///   <para>rdfs:comment : An actuator to automatically open/close the window.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Window">m3lite:Window</a>
    /// </summary>
    let Window = _prefixId.prefix "Window"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether a person (or object) is working or not</para>
    ///   <para>rdfs:label : Working State</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WorkingState">m3lite:WorkingState</a>
    /// </summary>
    let WorkingState = _prefixId.prefix "WorkingState"
    /// <summary>
    ///   <para>rdfs:comment : Indicator of whether the driver of a vehicle is present or not</para>
    ///   <para>rdfs:label : Working State Driver</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WorkingStateDriver">m3lite:WorkingStateDriver</a>
    /// </summary>
    let WorkingStateDriver = _prefixId.prefix "WorkingStateDriver"
    /// <summary>
    ///   <para>rdfs:label : Working State Driver 1</para>
    ///   <para>rdfs:comment : State of work of the first driver as defined in the FMS standard.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WorkingStateDriver1">m3lite:WorkingStateDriver1</a>
    /// </summary>
    let WorkingStateDriver1 = _prefixId.prefix "WorkingStateDriver1"
    /// <summary>
    ///   <para>rdfs:label : Working State Driver 2</para>
    ///   <para>rdfs:comment : State of work of the second driver as defined in the FMS standard.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#WorkingStateDriver2">m3lite:WorkingStateDriver2</a>
    /// </summary>
    let WorkingStateDriver2 = _prefixId.prefix "WorkingStateDriver2"
    /// <summary>
    ///   <para>rdfs:label : W/out</para>
    ///   <para>rdfs:comment : This unit is used to measure delta dew point within the Com4Innov tesbed. Natural number (W/out unit).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Wout">m3lite:Wout</a>
    /// </summary>
    let Wout = _prefixId.prefix "Wout"
    /// <summary>
    ///   <para>rdfs:label : Year</para>
    ///   <para>rdfs:comment : Year as a unit of time.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#Year">m3lite:Year</a>
    /// </summary>
    let Year = _prefixId.prefix "Year"
    /// <summary>
    ///   <para>rdfs:label : has Direction</para>
    ///   <para>rdfs:comment : The observations made by the sensors are affected by the direction of the sensing device. This property allows observations of the sensor to be associated to the Direction concept.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#hasDirection">m3lite:hasDirection</a>
    /// </summary>
    let hasDirection = _prefixId.prefix "hasDirection"
    /// <summary>
    ///   <para>rdfs:label : has Domain Of Interest</para>
    ///   <para>rdfs:comment : This property is used to classify devices by DomainOfInterest (e.g., blood pressure sensor is used in healthcare).</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#hasDomainOfInterest">m3lite:hasDomainOfInterest</a>
    /// </summary>
    let hasDomainOfInterest = _prefixId.prefix "hasDomainOfInterest"
    /// <summary>
    ///   <para>rdfs:label : has Measurement Type</para>
    ///   <para>rdfs:comment : Each sensing device can have a different sensing mechanism which may result in different kinds of sensor data. This property links observation of the sensor to the associated MeasurementType.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#hasMeasurementType">m3lite:hasMeasurementType</a>
    /// </summary>
    let hasMeasurementType = _prefixId.prefix "hasMeasurementType"
    /// <summary>
    ///   <para>rdfs:label : has Sound Source</para>
    ///   <para>rdfs:comment : This property links sound to its environmental source.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#hasSoundSource">m3lite:hasSoundSource</a>
    /// </summary>
    let hasSoundSource = _prefixId.prefix "hasSoundSource"
    /// <summary>
    ///   <para>rdfs:label : has Source</para>
    ///   <para>rdfs:comment : This property links sensed phenomena to its environmental source.</para>
    ///   <a href="http://purl.org/iot/vocab/m3-lite#hasSource">m3lite:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
