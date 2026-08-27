namespace http.purl.org.iot.vocab.m3_lite.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module m3lite =
    let _namespace_iri = Namespace_Iri m3lite |> NamespaceIRI
    /// <summary>
    ///   <para>m3lite:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"The M3-lite is a taxonomy that enables testbeds to semantically annotate the IoT data produced by heterogeneous devices and store them in a federated datastore such as FIESTA-IoT. In this taxonomy, we classify devices, the domain of interests (health, smart home, smart kitchen, environmental monitoring, etc.), phenomena and unit of measurements."</para>
    /// </remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#">http://purl.org/iot/vocab/m3-lite#</seealso>
    let _prefix_iri = Prefixed_Name(m3lite, "") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ABS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ABS (Anti-lock Braking System) receives information from ABS computer to control the pressure on the breaks, This helps the wheels not to get locked up, it adjust the break pressure and prevents the wheels from locking. (Definition Source Google)."</para>
    /// labels<para>"ABS (Anti-lock Braking System) Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ABS">http://purl.org/iot/vocab/m3-lite#ABS</seealso>
    let ABS = Prefixed_Name(m3lite, "ABS") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AccInitialERabEstabSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Initial E-UTRAN Radio Access Bearer establishment success rate."</para>
    /// labels<para>"Initial E-RAB Establishment Success Rate"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AccInitialERabEstabSuccRate">http://purl.org/iot/vocab/m3-lite#AccInitialERabEstabSuccRate</seealso>
    let AccInitialERabEstabSuccRate =
        Prefixed_Name(m3lite, "AccInitialERabEstabSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AccInitialERabSetupSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Initial E-UTRAN Radio Access Bearer setup success rate."</para>
    /// labels<para>"Initial E-RAB Setup Success Rate"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AccInitialERabSetupSuccRate">http://purl.org/iot/vocab/m3-lite#AccInitialERabSetupSuccRate</seealso>
    let AccInitialERabSetupSuccRate =
        Prefixed_Name(m3lite, "AccInitialERabSetupSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AccRrcConnSetupSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Radio Resource Control connection setup success rate."</para>
    /// labels<para>"RRC Connection Setup Success Rate"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AccRrcConnSetupSuccRate">http://purl.org/iot/vocab/m3-lite#AccRrcConnSetupSuccRate</seealso>
    let AccRrcConnSetupSuccRate =
        Prefixed_Name(m3lite, "AccRrcConnSetupSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AccS1SigEstabSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"S1 (S1 standardized interface between eNB and Evolved Packet Core) signalling establishment success rate."</para>
    ///   <para>"S1 (S1 standardized interface between eNB and Evolved Packet Core) signaling establishment success rate."</para>
    /// labels<para>"S1 Signaling Establishment Success Rate"</para><para>"S1 Signalling Establishment Success Rate"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AccS1SigEstabSuccRate">http://purl.org/iot/vocab/m3-lite#AccS1SigEstabSuccRate</seealso>
    let AccS1SigEstabSuccRate =
        Prefixed_Name(m3lite, "AccS1SigEstabSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The rate of change of the velocity of a particle with respect to time."</para>
    /// labels<para>"Acceleration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Acceleration">http://purl.org/iot/vocab/m3-lite#Acceleration</seealso>
    let Acceleration = Prefixed_Name(m3lite, "Acceleration") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AccelerationInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The acceleration at a given instant of time."</para>
    /// labels<para>"Instantaneous Acceleration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AccelerationInstantaneous">http://purl.org/iot/vocab/m3-lite#AccelerationInstantaneous</seealso>
    let AccelerationInstantaneous =
        Prefixed_Name(m3lite, "AccelerationInstantaneous") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Accelerometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" Accelerometers are used to automatically determine the orientation in which the user is holding the IoT Object (portrait or landscape)."</para>
    /// labels<para>"Accelerometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Accelerometer">http://purl.org/iot/vocab/m3-lite#Accelerometer</seealso>
    let Accelerometer = Prefixed_Name(m3lite, "Accelerometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ActivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The product of the voltage across a branch of an alternating-current circuit and the component of the electric current that is in phase with the voltage."</para>
    /// labels<para>"Active Power"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ActivePower">http://purl.org/iot/vocab/m3-lite#ActivePower</seealso>
    let ActivePower = Prefixed_Name(m3lite, "ActivePower") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Agriculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Agriculture, Smart farm as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Agriculture DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Agriculture">http://purl.org/iot/vocab/m3-lite#Agriculture</seealso>
    let Agriculture = Prefixed_Name(m3lite, "Agriculture") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirConditioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the air conditioner."</para>
    /// labels<para>"Air Conditioner Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirConditioner">http://purl.org/iot/vocab/m3-lite#AirConditioner</seealso>
    let AirConditioner = Prefixed_Name(m3lite, "AirConditioner") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to measure air humidity."</para>
    /// labels<para>"Air Humidity Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirHumiditySensor">http://purl.org/iot/vocab/m3-lite#AirHumiditySensor</seealso>
    let AirHumiditySensor = Prefixed_Name(m3lite, "AirHumiditySensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirPollutantSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Air Pollutant Sensor are devices that detect and monitor the presence of air pollution in the surrounding area (source Wikipedia)."</para>
    /// labels<para>"Air Pollutant Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirPollutantSensor">http://purl.org/iot/vocab/m3-lite#AirPollutantSensor</seealso>
    let AirPollutantSensor = Prefixed_Name(m3lite, "AirPollutantSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usually measured using Air Quality Index (AQI), it is the measure of Air Pollution in the environment. It is similar to Air Quality."</para>
    /// labels<para>"Air Pollution Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirPollution">http://purl.org/iot/vocab/m3-lite#AirPollution</seealso>
    let AirPollution = Prefixed_Name(m3lite, "AirPollution") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Usually measured using an air quality index (AQI) that is a number used by government agencies to communicate to the public how polluted the air currently is or how polluted it is forecast to become. Different countries have their own air quality indices, corresponding to different national air quality standards. It is the measure of Air Quality of the environment. It is similar to Air Pollution. (Source Wikipedia)."</para>
    /// labels<para>"Air Quality Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirQuality">http://purl.org/iot/vocab/m3-lite#AirQuality</seealso>
    let AirQuality = Prefixed_Name(m3lite, "AirQuality") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The temperature of the air that would be indicated by a thermometer exposed to the air at a location sheltered from direct solar radiation."</para>
    /// labels<para>"Air Temperature, Weather Temperature, Ambient Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirTemperature">http://purl.org/iot/vocab/m3-lite#AirTemperature</seealso>
    let AirTemperature = Prefixed_Name(m3lite, "AirTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AirThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device to measure the Air temperature of either indoor or outdoor atmosphere."</para>
    /// labels<para>"Air Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AirThermometer">http://purl.org/iot/vocab/m3-lite#AirThermometer</seealso>
    let AirThermometer = Prefixed_Name(m3lite, "AirThermometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AlarmSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the alarm system."</para>
    /// labels<para>"Alarm System Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AlarmSystem">http://purl.org/iot/vocab/m3-lite#AlarmSystem</seealso>
    let AlarmSystem = Prefixed_Name(m3lite, "AlarmSystem") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AlcoholLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Alcohol Level in the system."</para>
    /// labels<para>"Alcohol Level Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AlcoholLevel">http://purl.org/iot/vocab/m3-lite#AlcoholLevel</seealso>
    let AlcoholLevel = Prefixed_Name(m3lite, "AlcoholLevel") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AlcoholLevelSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect and measure Alcohol Level in the system."</para>
    /// labels<para>"Alcohol Level Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AlcoholLevelSensor">http://purl.org/iot/vocab/m3-lite#AlcoholLevelSensor</seealso>
    let AlcoholLevelSensor = Prefixed_Name(m3lite, "AlcoholLevelSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Ampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second."</para>
    /// labels<para>"Ampere (A)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Ampere">http://purl.org/iot/vocab/m3-lite#Ampere</seealso>
    let Ampere = Prefixed_Name(m3lite, "Ampere") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:AngularSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the rate of change of angular displacement and is a vector quantity (more precisely, a pseudovector) that specifies the angular speed (rotational speed) of an object and the axis about which the object is rotating. (Source Wikipedia)."</para>
    /// labels<para>"Angular Speed"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AngularSpeed">http://purl.org/iot/vocab/m3-lite#AngularSpeed</seealso>
    let AngularSpeed = Prefixed_Name(m3lite, "AngularSpeed") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Animals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"when the source of the sound were animals."</para>
    /// labels<para>"Animals as Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Animals">http://purl.org/iot/vocab/m3-lite#Animals</seealso>
    let Animals = Prefixed_Name(m3lite, "Animals") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The pressure exerted by the atmosphere as a consequence of gravitational attraction exerted upon the column of air lying directly above the point in question."</para>
    /// labels<para>"Atmospheric Pressure"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AtmosphericPressure">http://purl.org/iot/vocab/m3-lite#AtmosphericPressure</seealso>
    let AtmosphericPressure =
        Prefixed_Name(m3lite, "AtmosphericPressure") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AtmosphericPressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used in meteorology to measure atmospheric pressure."</para>
    ///   <para>"Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used im meteorology to measure atmospheric pressure."</para>
    /// labels<para>"Atmospheric Pressure Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AtmosphericPressureSensor">http://purl.org/iot/vocab/m3-lite#AtmosphericPressureSensor</seealso>
    let AtmosphericPressureSensor =
        Prefixed_Name(m3lite, "AtmosphericPressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:AutomaticSensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the devices are set to take the observations Automatically without any external aid."</para>
    /// labels<para>"Automatic Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#AutomaticSensing">http://purl.org/iot/vocab/m3-lite#AutomaticSensing</seealso>
    let AutomaticSensing = Prefixed_Name(m3lite, "AutomaticSensing") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Metric unit of atmospheric pressure equal to 14.50 pounds per square inch (lb/in2), 1.02 kilograms per square centimetre (kg/cm2), 29.53 inches of mercury (in Hg), or 0.9869 atmosphere."</para>
    /// labels<para>"Bar"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Bar">http://purl.org/iot/vocab/m3-lite#Bar</seealso>
    let Bar = Prefixed_Name(m3lite, "Bar") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Barcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tagging device can be Barcode."</para>
    /// labels<para>"Barcode Tagging Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Barcode">http://purl.org/iot/vocab/m3-lite#Barcode</seealso>
    let Barcode = Prefixed_Name(m3lite, "Barcode") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BatteryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the percentage of the battery capacity that remains available."</para>
    /// labels<para>"Battery Level Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BatteryLevel">http://purl.org/iot/vocab/m3-lite#BatteryLevel</seealso>
    let BatteryLevel = Prefixed_Name(m3lite, "BatteryLevel") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BeatPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Beat Per Minute (bpm) is the unit to measure heart rate."</para>
    ///   <para>"BeatPerMinute (bpm) is the unit to measure heart rate."</para>
    /// labels<para>"Beat Per Minute (bpm)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BeatPerMinute">http://purl.org/iot/vocab/m3-lite#BeatPerMinute</seealso>
    let BeatPerMinute = Prefixed_Name(m3lite, "BeatPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Blind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the window blinds."</para>
    /// labels<para>"Blind Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Blind">http://purl.org/iot/vocab/m3-lite#Blind</seealso>
    let Blind = Prefixed_Name(m3lite, "Blind") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BloodGlucose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Blood glucose level or blood sugar level."</para>
    /// labels<para>"Blood Glucose Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BloodGlucose">http://purl.org/iot/vocab/m3-lite#BloodGlucose</seealso>
    let BloodGlucose = Prefixed_Name(m3lite, "BloodGlucose") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the pressure in your blood vessels when your heart rests between beats."</para>
    /// labels<para>"Blood Pressure"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BloodPressure">http://purl.org/iot/vocab/m3-lite#BloodPressure</seealso>
    let BloodPressure = Prefixed_Name(m3lite, "BloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:BloodPressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure Blood Pressure."</para>
    /// labels<para>"Blood Pressure Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BloodPressureSensor">http://purl.org/iot/vocab/m3-lite#BloodPressureSensor</seealso>
    let BloodPressureSensor =
        Prefixed_Name(m3lite, "BloodPressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:BoardTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of board temperature."</para>
    /// labels<para>"Board Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BoardTemperature">http://purl.org/iot/vocab/m3-lite#BoardTemperature</seealso>
    let BoardTemperature = Prefixed_Name(m3lite, "BoardTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BoardThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure board temperature."</para>
    /// labels<para>"Board Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BoardThermometer">http://purl.org/iot/vocab/m3-lite#BoardThermometer</seealso>
    let BoardThermometer = Prefixed_Name(m3lite, "BoardThermometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BoardVoltageSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to measure board input voltage."</para>
    /// labels<para>"Board Voltage Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BoardVoltageSensor">http://purl.org/iot/vocab/m3-lite#BoardVoltageSensor</seealso>
    let BoardVoltageSensor = Prefixed_Name(m3lite, "BoardVoltageSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BodyTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of body temperature."</para>
    /// labels<para>"Body Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BodyTemperature">http://purl.org/iot/vocab/m3-lite#BodyTemperature</seealso>
    let BodyTemperature = Prefixed_Name(m3lite, "BodyTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BodyThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure body temperature."</para>
    /// labels<para>"Body Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BodyThermometer">http://purl.org/iot/vocab/m3-lite#BodyThermometer</seealso>
    let BodyThermometer = Prefixed_Name(m3lite, "BodyThermometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the boiler."</para>
    /// labels<para>"Boiler Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Boiler">http://purl.org/iot/vocab/m3-lite#Boiler</seealso>
    let Boiler = Prefixed_Name(m3lite, "Boiler") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:BuildingAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Smart Home/Building Automation as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Smart Building DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BuildingAutomation">http://purl.org/iot/vocab/m3-lite#BuildingAutomation</seealso>
    let BuildingAutomation = Prefixed_Name(m3lite, "BuildingAutomation") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:BuildingTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of building or room temperature."</para>
    /// labels<para>"Building/Room Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#BuildingTemperature">http://purl.org/iot/vocab/m3-lite#BuildingTemperature</seealso>
    let BuildingTemperature =
        Prefixed_Name(m3lite, "BuildingTemperature") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:CO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Carbon Dioxide (CO2) measure in the atmosphere."</para>
    /// labels<para>"Carbon Dioxide (CO2) Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CO2">http://purl.org/iot/vocab/m3-lite#CO2</seealso>
    let CO2 = Prefixed_Name(m3lite, "CO2") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:CO2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Carbon Dioxide (CO2) Sensor used to measure level of CO2 in the atmosphere."</para>
    /// labels<para>"Carbon Dioxide (CO2) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CO2Sensor">http://purl.org/iot/vocab/m3-lite#CO2Sensor</seealso>
    let CO2Sensor = Prefixed_Name(m3lite, "CO2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:COSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device to detect Carbon Monoxide (CO) in the environment."</para>
    /// labels<para>"Carbon Monoxide (CO) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#COSensor">http://purl.org/iot/vocab/m3-lite#COSensor</seealso>
    let COSensor = Prefixed_Name(m3lite, "COSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Calcium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of blood calcium level."</para>
    /// labels<para>"Calcium Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Calcium">http://purl.org/iot/vocab/m3-lite#Calcium</seealso>
    let Calcium = Prefixed_Name(m3lite, "Calcium") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Calibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of blood calcium level."</para>
    /// labels<para>"Calcium Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Calibration">http://purl.org/iot/vocab/m3-lite#Calibration</seealso>
    let Calibration = Prefixed_Name(m3lite, "Calibration") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:CalibrationSensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If the measurement was taken when the sensor was being calibrated."</para>
    /// labels<para>"Calibration Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CalibrationSensing">http://purl.org/iot/vocab/m3-lite#CalibrationSensing</seealso>
    let CalibrationSensing = Prefixed_Name(m3lite, "CalibrationSensing") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Candela</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 10^12 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian. (Source Wikipedia)."</para>
    /// labels<para>"Candela"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Candela">http://purl.org/iot/vocab/m3-lite#Candela</seealso>
    let Candela = Prefixed_Name(m3lite, "Candela") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Capacitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the ability of a system to store an electric charge."</para>
    /// labels<para>"Capacitance"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Capacitance">http://purl.org/iot/vocab/m3-lite#Capacitance</seealso>
    let Capacitance = Prefixed_Name(m3lite, "Capacitance") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Centibar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The centibar is a unit of pressure defined as 1e-2 bar."</para>
    /// labels<para>"Centibar"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Centibar">http://purl.org/iot/vocab/m3-lite#Centibar</seealso>
    let Centibar = Prefixed_Name(m3lite, "Centibar") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Centimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metric unit of length, equal to one hundredth of a metre."</para>
    /// labels<para>"Centimetre, Centimeter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Centimetre">http://purl.org/iot/vocab/m3-lite#Centimetre</seealso>
    let Centimetre = Prefixed_Name(m3lite, "Centimetre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Chemical Agent Atmospheric Concentration"</para>
    /// labels<para>"Chemical Agent Atmospheric Concentration Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentration">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentration</seealso>
    let ChemicalAgentAtmosphericConcentration =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentration") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationAirParticles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of chemical particles suspended in the atmosphere."</para>
    /// labels<para>"Air Particles Chemical Agent Atmospheric Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationAirParticles">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationAirParticles</seealso>
    let ChemicalAgentAtmosphericConcentrationAirParticles =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationAirParticles") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationCO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere."</para>
    /// labels<para>"Carbon Monoxide (CO) Chemical Agent Atmospheric Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationCO">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationCO</seealso>
    let ChemicalAgentAtmosphericConcentrationCO =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationCO") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationDust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of dust suspended in the air."</para>
    /// labels<para>"Chemical Agent Atmospheric Concentration Dust"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationDust">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationDust</seealso>
    let ChemicalAgentAtmosphericConcentrationDust =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationDust") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere."</para>
    /// labels<para>"Nitrogen Monoxide (NO) Chemical Agent Atmospheric Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationNO">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationNO</seealso>
    let ChemicalAgentAtmosphericConcentrationNO =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationNO") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationNO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of NO2 gas suspended in the atmosphere."</para>
    /// labels<para>"NO2 Chemical Agent Atmospheric Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationNO2">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationNO2</seealso>
    let ChemicalAgentAtmosphericConcentrationNO2 =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationNO2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationO3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The concentration of ozone (O3) gas suspended in the atmosphere."</para>
    /// labels<para>"Chemical Agent Atmospheric Concentration O3"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationO3">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationO3</seealso>
    let ChemicalAgentAtmosphericConcentrationO3 =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationO3") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationSO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of Sulphur dioxide (SO2) gas suspended in the atmosphere."</para>
    /// labels<para>"Sulphur dioxide (SO2) Chemical Agent Atmospheric Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationSO2">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationSO2</seealso>
    let ChemicalAgentAtmosphericConcentrationSO2 =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationSO2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentAtmosphericConcentrationVOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the concentration of Volatile Organic Compound gas suspended in the atmosphere."</para>
    /// labels<para>"Volatile Organic Compound Chemical Agent Atmospheric Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationVOC">http://purl.org/iot/vocab/m3-lite#ChemicalAgentAtmosphericConcentrationVOC</seealso>
    let ChemicalAgentAtmosphericConcentrationVOC =
        Prefixed_Name(m3lite, "ChemicalAgentAtmosphericConcentrationVOC") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Chemical Agent Concentration"</para>
    /// labels<para>"Chemical Agent Concentration Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentConcentration">http://purl.org/iot/vocab/m3-lite#ChemicalAgentConcentration</seealso>
    let ChemicalAgentConcentration =
        Prefixed_Name(m3lite, "ChemicalAgentConcentration") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentWaterConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Chemical Agent Concentration in Water "</para>
    /// labels<para>"Chemical Agent Water Concentration Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentration">http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentration</seealso>
    let ChemicalAgentWaterConcentration =
        Prefixed_Name(m3lite, "ChemicalAgentWaterConcentration") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentWaterConcentrationNH4Ion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of NH4 ion concentration in Water "</para>
    /// labels<para>"Ammonium ion (NH4+) Chemical Agent Water Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationNH4Ion">http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationNH4Ion</seealso>
    let ChemicalAgentWaterConcentrationNH4Ion =
        Prefixed_Name(m3lite, "ChemicalAgentWaterConcentrationNH4Ion") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentWaterConcentrationNO3Ion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of NO3 ion concentration in Water "</para>
    /// labels<para>"Nitrate Ion (NO3-) Chemical Agent Water Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationNO3Ion">http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationNO3Ion</seealso>
    let ChemicalAgentWaterConcentrationNO3Ion =
        Prefixed_Name(m3lite, "ChemicalAgentWaterConcentrationNO3Ion") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ChemicalAgentWaterConcentrationO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of O2 concentration in Water "</para>
    /// labels<para>"Oxygen (O2) Chemical Agent Water Concentration"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationO2">http://purl.org/iot/vocab/m3-lite#ChemicalAgentWaterConcentrationO2</seealso>
    let ChemicalAgentWaterConcentrationO2 =
        Prefixed_Name(m3lite, "ChemicalAgentWaterConcentrationO2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Cholesterol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the cholesterol level in a system."</para>
    /// labels<para>"Cholesterol Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Cholesterol">http://purl.org/iot/vocab/m3-lite#Cholesterol</seealso>
    let Cholesterol = Prefixed_Name(m3lite, "Cholesterol") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:CholesterolSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure the cholesterol level in a system."</para>
    /// labels<para>"Cholesterol Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CholesterolSensor">http://purl.org/iot/vocab/m3-lite#CholesterolSensor</seealso>
    let CholesterolSensor = Prefixed_Name(m3lite, "CholesterolSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Smart City as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Smart City DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#City">http://purl.org/iot/vocab/m3-lite#City</seealso>
    let City = Prefixed_Name(m3lite, "City") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Clock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"sensor that measures time"</para>
    /// labels<para>"Clock"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Clock">http://purl.org/iot/vocab/m3-lite#Clock</seealso>
    let Clock = Prefixed_Name(m3lite, "Clock") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:CloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of cloud cover at a certain time. "</para>
    /// labels<para>"Cloud Cover Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CloudCover">http://purl.org/iot/vocab/m3-lite#CloudCover</seealso>
    let CloudCover = Prefixed_Name(m3lite, "CloudCover") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:CloudCoverSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cloud Cover Sensor is used to detect whether it is sunny, cloudy, etc."</para>
    /// labels<para>"Cloud Cover Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CloudCoverSensor">http://purl.org/iot/vocab/m3-lite#CloudCoverSensor</seealso>
    let CloudCoverSensor = Prefixed_Name(m3lite, "CloudCoverSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:CoffeeMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the coffee machine."</para>
    /// labels<para>"Coffee Machine, Coffee Maker Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CoffeeMachine">http://purl.org/iot/vocab/m3-lite#CoffeeMachine</seealso>
    let CoffeeMachine = Prefixed_Name(m3lite, "CoffeeMachine") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Communication related properties."</para>
    /// labels<para>"Communication Related Quantity Kind"</para><para>"Communication Properties"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Communication">http://purl.org/iot/vocab/m3-lite#Communication</seealso>
    let Communication = Prefixed_Name(m3lite, "Communication") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actuating devices for Computer or PC."</para>
    /// labels<para>"Computer, PC Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Computer">http://purl.org/iot/vocab/m3-lite#Computer</seealso>
    let Computer = Prefixed_Name(m3lite, "Computer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Conductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of ability to conduct electricity. It is measured in siemens per meter (S/m)."</para>
    ///   <para>"Measure of ability to conduct electricity. It is measured in siemens per metre (S/m)."</para>
    /// labels<para>"Conductivity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Conductivity">http://purl.org/iot/vocab/m3-lite#Conductivity</seealso>
    let Conductivity = Prefixed_Name(m3lite, "Conductivity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ConductivitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure the conductivity of a system."</para>
    /// labels<para>"Conductivity Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ConductivitySensor">http://purl.org/iot/vocab/m3-lite#ConductivitySensor</seealso>
    let ConductivitySensor = Prefixed_Name(m3lite, "ConductivitySensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ConstructionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound was a construction work."</para>
    /// labels<para>"Construction Work Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ConstructionWork">http://purl.org/iot/vocab/m3-lite#ConstructionWork</seealso>
    let ConstructionWork = Prefixed_Name(m3lite, "ConstructionWork") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Triples for location in the (Latitude, Longitude, Altitude) format."</para>
    /// labels<para>"Coordinates"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Coordinates">http://purl.org/iot/vocab/m3-lite#Coordinates</seealso>
    let Coordinates = Prefixed_Name(m3lite, "Coordinates") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Coulomb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SI unit of electric charge."</para>
    /// labels<para>"Coulomb"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Coulomb">http://purl.org/iot/vocab/m3-lite#Coulomb</seealso>
    let Coulomb = Prefixed_Name(m3lite, "Coulomb") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of available particular things."</para>
    /// labels<para>"Count"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Count">http://purl.org/iot/vocab/m3-lite#Count</seealso>
    let Count = Prefixed_Name(m3lite, "Count") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:CountAvailableBicycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of available bicycles at a particular bicycle docking station."</para>
    /// labels<para>"Count Available Bicycles"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CountAvailableBicycles">http://purl.org/iot/vocab/m3-lite#CountAvailableBicycles</seealso>
    let CountAvailableBicycles =
        Prefixed_Name(m3lite, "CountAvailableBicycles") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:CountAvailableTaxis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of taxis available at a particular taxi stop."</para>
    /// labels<para>"Count Available Taxis"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CountAvailableTaxis">http://purl.org/iot/vocab/m3-lite#CountAvailableTaxis</seealso>
    let CountAvailableTaxis =
        Prefixed_Name(m3lite, "CountAvailableTaxis") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:CountEmptyDockingPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of empty docking points at a particular bicycle docking station."</para>
    /// labels<para>"Count Empty Docking Points"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#CountEmptyDockingPoints">http://purl.org/iot/vocab/m3-lite#CountEmptyDockingPoints</seealso>
    let CountEmptyDockingPoints =
        Prefixed_Name(m3lite, "CountEmptyDockingPoints") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Counter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensors that reckons occurrences or repetitions of physical objects, phenomena or events."</para>
    /// labels<para>"Counter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Counter">http://purl.org/iot/vocab/m3-lite#Counter</seealso>
    let Counter = Prefixed_Name(m3lite, "Counter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Crowd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound was crowd."</para>
    /// labels<para>"Crowd Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Crowd">http://purl.org/iot/vocab/m3-lite#Crowd</seealso>
    let Crowd = Prefixed_Name(m3lite, "Crowd") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Cupboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the cupboard."</para>
    /// labels<para>"Cupboard Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Cupboard">http://purl.org/iot/vocab/m3-lite#Cupboard</seealso>
    let Cupboard = Prefixed_Name(m3lite, "Cupboard") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Curtain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the curtain."</para>
    /// labels<para>"Curtain Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Curtain">http://purl.org/iot/vocab/m3-lite#Curtain</seealso>
    let Curtain = Prefixed_Name(m3lite, "Curtain") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Day is a unit of time."</para>
    /// labels<para>"Day"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Day">http://purl.org/iot/vocab/m3-lite#Day</seealso>
    let Day = Prefixed_Name(m3lite, "Day") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Decibel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Decibel is a logarithmic unit used to express the ratio of two values of a physical quantity. It is often used to measure sound level."</para>
    /// labels<para>"Decibel (dB)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Decibel">http://purl.org/iot/vocab/m3-lite#Decibel</seealso>
    let Decibel = Prefixed_Name(m3lite, "Decibel") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DecibelA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sound pressure sensed by the human ear."</para>
    /// labels<para>"DecibelA (dB(A))"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DecibelA">http://purl.org/iot/vocab/m3-lite#DecibelA</seealso>
    let DecibelA = Prefixed_Name(m3lite, "DecibelA") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DecibelMilliwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes power ratio in decibels of the measured power referenced to one milliwatt."</para>
    /// labels<para>"Decibel Milliwatt"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DecibelMilliwatt">http://purl.org/iot/vocab/m3-lite#DecibelMilliwatt</seealso>
    let DecibelMilliwatt = Prefixed_Name(m3lite, "DecibelMilliwatt") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Degree."</para>
    ///   <para>"Degree"</para>
    /// labels<para>"Degree"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Degree">http://purl.org/iot/vocab/m3-lite#Degree</seealso>
    let Degree = Prefixed_Name(m3lite, "Degree") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DegreeAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A plane angle unit which is equal to 1/360 of a full rotation or pi/180 rad."</para>
    /// labels<para>"Degree Angle"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DegreeAngle">http://purl.org/iot/vocab/m3-lite#DegreeAngle</seealso>
    let DegreeAngle = Prefixed_Name(m3lite, "DegreeAngle") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DegreeCelsius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K."</para>
    /// labels<para>"Degree Celsius"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DegreeCelsius">http://purl.org/iot/vocab/m3-lite#DegreeCelsius</seealso>
    let DegreeCelsius = Prefixed_Name(m3lite, "DegreeCelsius") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DegreeFahrenheit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measurement Unit to represent temperature on the Fahrenheit scale."</para>
    /// labels<para>"Degree Fahrenheit"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DegreeFahrenheit">http://purl.org/iot/vocab/m3-lite#DegreeFahrenheit</seealso>
    let DegreeFahrenheit = Prefixed_Name(m3lite, "DegreeFahrenheit") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DeltaDewPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Difference between Dewpoint and surface temperatures."</para>
    /// labels<para>"Delta Dew Point"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DeltaDewPoint">http://purl.org/iot/vocab/m3-lite#DeltaDewPoint</seealso>
    let DeltaDewPoint = Prefixed_Name(m3lite, "DeltaDewPoint") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:DeltaDewPointSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that measures the difference between Dewpoint and surface temperatures."</para>
    /// labels<para>"Delta Dew Point Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DeltaDewPointSensor">http://purl.org/iot/vocab/m3-lite#DeltaDewPointSensor</seealso>
    let DeltaDewPointSensor =
        Prefixed_Name(m3lite, "DeltaDewPointSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:DeviceUptime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Time a device is working and is available"</para>
    /// labels<para>"Device Uptime"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DeviceUptime">http://purl.org/iot/vocab/m3-lite#DeviceUptime</seealso>
    let DeviceUptime = Prefixed_Name(m3lite, "DeviceUptime") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DeviceUptimeClock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that measures time a device is working and is available."</para>
    /// labels<para>"Device Uptime Clock"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DeviceUptimeClock">http://purl.org/iot/vocab/m3-lite#DeviceUptimeClock</seealso>
    let DeviceUptimeClock = Prefixed_Name(m3lite, "DeviceUptimeClock") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DewPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the temperature to which air must be cooled at constant pressure to condense to form liquid."</para>
    /// labels<para>"Dew Point"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DewPoint">http://purl.org/iot/vocab/m3-lite#DewPoint</seealso>
    let DewPoint = Prefixed_Name(m3lite, "DewPoint") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DewPointSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that measures dew point."</para>
    /// labels<para>"Dew Point Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DewPointSensor">http://purl.org/iot/vocab/m3-lite#DewPointSensor</seealso>
    let DewPointSensor = Prefixed_Name(m3lite, "DewPointSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:DewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The temperature at which dew forms and is a measure of atmospheric moisture. It is the temperature to which air must be cooled at constant pressure and water content to reach saturation. A higher dew point indicates more moisture in the air; a dew point greater than 20 Degree C (68 Degree F) is considered uncomfortable and greater than 22 Degree C (72 Degree F) is considered to be extremely humid."</para>
    /// labels<para>"Dew Point Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DewPointTemperature">http://purl.org/iot/vocab/m3-lite#DewPointTemperature</seealso>
    let DewPointTemperature =
        Prefixed_Name(m3lite, "DewPointTemperature") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:DiastolicBloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" Measure of the pressure in the arteries when the heart rests between beats."</para>
    /// labels<para>"Diastolic Blood Pressure"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DiastolicBloodPressure">http://purl.org/iot/vocab/m3-lite#DiastolicBloodPressure</seealso>
    let DiastolicBloodPressure =
        Prefixed_Name(m3lite, "DiastolicBloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Dimensionless</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Without dimensions; having no appreciable or noteworthy extent. Without physical meaning."</para>
    /// labels<para>"Dimensionless"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Dimensionless">http://purl.org/iot/vocab/m3-lite#Dimensionless</seealso>
    let Dimensionless = Prefixed_Name(m3lite, "Dimensionless") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measurements of sensors are affected by the direction of the sensing device. This concept is used to reflect it."</para>
    ///   <para>"Measurments of sensors are affected by the direction of the sensing device. This concept is used to reflect it."</para>
    /// labels<para>"Direction"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Direction">http://purl.org/iot/vocab/m3-lite#Direction</seealso>
    let Direction = Prefixed_Name(m3lite, "Direction") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DirectionAzimuth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The geodetic azimuth of the direction towards which an object is point to."</para>
    /// labels<para>"Direction Azimuth"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DirectionAzimuth">http://purl.org/iot/vocab/m3-lite#DirectionAzimuth</seealso>
    let DirectionAzimuth = Prefixed_Name(m3lite, "DirectionAzimuth") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DirectionHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The course or direction in which a object (vehicle, person, ...) is moving."</para>
    /// labels<para>"Direction Heading"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DirectionHeading">http://purl.org/iot/vocab/m3-lite#DirectionHeading</seealso>
    let DirectionHeading = Prefixed_Name(m3lite, "DirectionHeading") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DirectionOfArrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The azimuth direction of a  source relative to the azimuth direction of the DOA sensor."</para>
    /// labels<para>"Direction Of Arrival"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DirectionOfArrival">http://purl.org/iot/vocab/m3-lite#DirectionOfArrival</seealso>
    let DirectionOfArrival = Prefixed_Name(m3lite, "DirectionOfArrival") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:DirectionOfArrivalSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that estimates the azimuth direction of sources relative to the sensor’s position."</para>
    /// labels<para>"Direction Of Arrival (DOA) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DirectionOfArrivalSensor">http://purl.org/iot/vocab/m3-lite#DirectionOfArrivalSensor</seealso>
    let DirectionOfArrivalSensor =
        Prefixed_Name(m3lite, "DirectionOfArrivalSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:DishWasher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the dishwasher."</para>
    /// labels<para>"Dish Washer Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DishWasher">http://purl.org/iot/vocab/m3-lite#DishWasher</seealso>
    let DishWasher = Prefixed_Name(m3lite, "DishWasher") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of how far apart objects are."</para>
    /// labels<para>"Distance"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Distance">http://purl.org/iot/vocab/m3-lite#Distance</seealso>
    let Distance = Prefixed_Name(m3lite, "Distance") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DistanceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Distance Sensor is used to detect distance between two objects for example:  the safety distance with other cars. Distance sensor can be a laser."</para>
    /// labels<para>"Distance Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DistanceSensor">http://purl.org/iot/vocab/m3-lite#DistanceSensor</seealso>
    let DistanceSensor = Prefixed_Name(m3lite, "DistanceSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DomainOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Application Domain for example: health, environment, etc."</para>
    ///   <para>"Domain of Interest."</para>
    /// labels<para>"Domain Of Interest"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DomainOfInterest">http://purl.org/iot/vocab/m3-lite#DomainOfInterest</seealso>
    let DomainOfInterest = Prefixed_Name(m3lite, "DomainOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the door."</para>
    /// labels<para>"Door Actuating Device"</para><para>"Door Accuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Door">http://purl.org/iot/vocab/m3-lite#Door</seealso>
    let Door = Prefixed_Name(m3lite, "Door") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DoorStateSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This sensor detects if a door is in the state of OPEN or CLOSED."</para>
    /// labels<para>"Door State Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DoorStateSensor">http://purl.org/iot/vocab/m3-lite#DoorStateSensor</seealso>
    let DoorStateSensor = Prefixed_Name(m3lite, "DoorStateSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DoorStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Describes if a door is OPEN or CLOSED."</para>
    /// labels<para>"Door Status"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DoorStatus">http://purl.org/iot/vocab/m3-lite#DoorStatus</seealso>
    let DoorStatus = Prefixed_Name(m3lite, "DoorStatus") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Drawer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the drawer."</para>
    /// labels<para>"Drawer Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Drawer">http://purl.org/iot/vocab/m3-lite#Drawer</seealso>
    let Drawer = Prefixed_Name(m3lite, "Drawer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:DustSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensing device that measures dust particle concentration."</para>
    /// labels<para>"Dust Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#DustSensor">http://purl.org/iot/vocab/m3-lite#DustSensor</seealso>
    let DustSensor = Prefixed_Name(m3lite, "DustSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:EAQI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unit to measure Air Quality in European cities."</para>
    /// labels<para>"European Air Quality Index (EAQI)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#EAQI">http://purl.org/iot/vocab/m3-lite#EAQI</seealso>
    let EAQI = Prefixed_Name(m3lite, "EAQI") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ECG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ECG or EKG (Electrocardiogram) device."</para>
    /// labels<para>"ECG or EKG (Electrocardiogram)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ECG">http://purl.org/iot/vocab/m3-lite#ECG</seealso>
    let ECG = Prefixed_Name(m3lite, "ECG") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ESP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actuator for turning ESP on/off."</para>
    ///   <para>"The actuator for turing ESP on/off."</para>
    /// labels<para>"ESP (Electronic Stability Program) Actuating device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ESP">http://purl.org/iot/vocab/m3-lite#ESP</seealso>
    let ESP = Prefixed_Name(m3lite, "ESP") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the physical property of matter that causes it to experience a force when placed in an electromagnetic field. (Source Wikipedia)."</para>
    /// labels<para>"Electric Charge"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricCharge">http://purl.org/iot/vocab/m3-lite#ElectricCharge</seealso>
    let ElectricCharge = Prefixed_Name(m3lite, "ElectricCharge") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time. Electric Current is the flow (movement) of electric charge. The amount of electric current through some surface, e.g., a section through a copper conductor, is defined as the amount of electric charge flowing through that surface over time."</para>
    /// labels<para>"Electric Current"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricCurrent">http://purl.org/iot/vocab/m3-lite#ElectricCurrent</seealso>
    let ElectricCurrent = Prefixed_Name(m3lite, "ElectricCurrent") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ElectricField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electric field is the electric force per unit charge."</para>
    /// labels<para>"Electric Field"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricField">http://purl.org/iot/vocab/m3-lite#ElectricField</seealso>
    let ElectricField = Prefixed_Name(m3lite, "ElectricField") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricField1800MHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 1800 MHz UHF band."</para>
    /// labels<para>"Electric Field 1800 MHz"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricField1800MHz">http://purl.org/iot/vocab/m3-lite#ElectricField1800MHz</seealso>
    let ElectricField1800MHz =
        Prefixed_Name(m3lite, "ElectricField1800MHz") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricField2100MHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2100 MHz UHF band."</para>
    /// labels<para>"Electric Field 2100 MHz"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricField2100MHz">http://purl.org/iot/vocab/m3-lite#ElectricField2100MHz</seealso>
    let ElectricField2100MHz =
        Prefixed_Name(m3lite, "ElectricField2100MHz") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricField2400MHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2400 MHz UHF band."</para>
    /// labels<para>"Electric Field 2400 MHz"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricField2400MHz">http://purl.org/iot/vocab/m3-lite#ElectricField2400MHz</seealso>
    let ElectricField2400MHz =
        Prefixed_Name(m3lite, "ElectricField2400MHz") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricField900Mhz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 900 MHz UHF band."</para>
    /// labels<para>"Electric Field 900 MHz"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricField900Mhz">http://purl.org/iot/vocab/m3-lite#ElectricField900Mhz</seealso>
    let ElectricField900Mhz =
        Prefixed_Name(m3lite, "ElectricField900Mhz") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricFieldSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Scientific instrument for measuring electromagnetic fields (EMF). Most of them measure the electromagnetic radiation flux density (DC fields) or the change in an electromagnetic field over time (AC fields)."</para>
    /// labels<para>"Electric Field Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricFieldSensor">http://purl.org/iot/vocab/m3-lite#ElectricFieldSensor</seealso>
    let ElectricFieldSensor =
        Prefixed_Name(m3lite, "ElectricFieldSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field."</para>
    /// labels<para>"Electric Potential"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricPotential">http://purl.org/iot/vocab/m3-lite#ElectricPotential</seealso>
    let ElectricPotential = Prefixed_Name(m3lite, "ElectricPotential") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricalResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The electrical resitance of an electrical conductor is the opposition to the passage of an electric current through that conductor."</para>
    ///   <para>"The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor."</para>
    /// labels<para>"Electrical Resistance"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricalResistance">http://purl.org/iot/vocab/m3-lite#ElectricalResistance</seealso>
    let ElectricalResistance =
        Prefixed_Name(m3lite, "ElectricalResistance") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ElectricalSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that measures the changes in electrical or magnetic signals based on an environmental input."</para>
    ///   <para>"Electrical Sensor."</para>
    /// labels<para>"Electrical Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ElectricalSensor">http://purl.org/iot/vocab/m3-lite#ElectricalSensor</seealso>
    let ElectricalSensor = Prefixed_Name(m3lite, "ElectricalSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Emotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Affective Science, Emotion, Mood, Emotional State, Brain Wave as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Emotion DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Emotion">http://purl.org/iot/vocab/m3-lite#Emotion</seealso>
    let Emotion = Prefixed_Name(m3lite, "Emotion") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Energy is the property that must be transferred to an object in order to perform work on. (Source Wikipedia)."</para>
    /// labels<para>"Energy"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Energy">http://purl.org/iot/vocab/m3-lite#Energy</seealso>
    let Energy = Prefixed_Name(m3lite, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:EnergyDOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Energy or Smart Grid as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Energy DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#EnergyDOI">http://purl.org/iot/vocab/m3-lite#EnergyDOI</seealso>
    let EnergyDOI = Prefixed_Name(m3lite, "EnergyDOI") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:EnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor to measure power or energy consumption."</para>
    /// labels<para>"Energy Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#EnergyMeter">http://purl.org/iot/vocab/m3-lite#EnergyMeter</seealso>
    let EnergyMeter = Prefixed_Name(m3lite, "EnergyMeter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Environment (earthquake, flooding, fire, pollution) as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Environment DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Environment">http://purl.org/iot/vocab/m3-lite#Environment</seealso>
    let Environment = Prefixed_Name(m3lite, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Experiment based measurements."</para>
    /// labels<para>"Experiment Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Experiment">http://purl.org/iot/vocab/m3-lite#Experiment</seealso>
    let Experiment = Prefixed_Name(m3lite, "Experiment") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FallDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device to detect is a person has fallen."</para>
    /// labels<para>"Fall Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FallDetector">http://purl.org/iot/vocab/m3-lite#FallDetector</seealso>
    let FallDetector = Prefixed_Name(m3lite, "FallDetector") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound was Fan."</para>
    /// labels<para>"Fan Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Fan">http://purl.org/iot/vocab/m3-lite#Fan</seealso>
    let Fan = Prefixed_Name(m3lite, "Fan") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Farad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"SI unit of electrical capacitance."</para>
    /// labels<para>"Farad"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Farad">http://purl.org/iot/vocab/m3-lite#Farad</seealso>
    let Farad = Prefixed_Name(m3lite, "Farad") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FillLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Property used to determine the level a certain object such as waste bin is filled upto."</para>
    /// labels<para>"Fill Level"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FillLevel">http://purl.org/iot/vocab/m3-lite#FillLevel</seealso>
    let FillLevel = Prefixed_Name(m3lite, "FillLevel") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FillLevelGasTank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container."</para>
    /// labels<para>"Fill Level Gas Tank"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FillLevelGasTank">http://purl.org/iot/vocab/m3-lite#FillLevelGasTank</seealso>
    let FillLevelGasTank = Prefixed_Name(m3lite, "FillLevelGasTank") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FillLevelGasTank1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the primary tank of the vehicle."</para>
    /// labels<para>"Fill Level Gas Tank 1"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FillLevelGasTank1">http://purl.org/iot/vocab/m3-lite#FillLevelGasTank1</seealso>
    let FillLevelGasTank1 = Prefixed_Name(m3lite, "FillLevelGasTank1") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FillLevelGasTank2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the secondary tank of the vehicle."</para>
    /// labels<para>"Fill Level Gas Tank 2"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FillLevelGasTank2">http://purl.org/iot/vocab/m3-lite#FillLevelGasTank2</seealso>
    let FillLevelGasTank2 = Prefixed_Name(m3lite, "FillLevelGasTank2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:FillLevelWasteContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio between the current filleage level and the total capacity of a waste container."</para>
    /// labels<para>"Fill Level Waste Container"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FillLevelWasteContainer">http://purl.org/iot/vocab/m3-lite#FillLevelWasteContainer</seealso>
    let FillLevelWasteContainer =
        Prefixed_Name(m3lite, "FillLevelWasteContainer") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:FogLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actuator for turing on or off the fog lamp."</para>
    ///   <para>"The actuator for turning on or off the fog lamp."</para>
    /// labels<para>"Fog Lamp Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FogLamp">http://purl.org/iot/vocab/m3-lite#FogLamp</seealso>
    let FogLamp = Prefixed_Name(m3lite, "FogLamp") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FoodTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of temperature of the food."</para>
    /// labels<para>"Food Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FoodTemperature">http://purl.org/iot/vocab/m3-lite#FoodTemperature</seealso>
    let FoodTemperature = Prefixed_Name(m3lite, "FoodTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Freezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the freezer."</para>
    /// labels<para>"Freezer, Chiller Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Freezer">http://purl.org/iot/vocab/m3-lite#Freezer</seealso>
    let Freezer = Prefixed_Name(m3lite, "Freezer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Frequency is the number of occurrences of a repeating event per unit time."</para>
    /// labels<para>"Frequency"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Frequency">http://purl.org/iot/vocab/m3-lite#Frequency</seealso>
    let Frequency = Prefixed_Name(m3lite, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FrequencySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect the frequency."</para>
    /// labels<para>"Frequency Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FrequencySensor">http://purl.org/iot/vocab/m3-lite#FrequencySensor</seealso>
    let FrequencySensor = Prefixed_Name(m3lite, "FrequencySensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the fridge."</para>
    /// labels<para>"Fridge, Refrigerator Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Fridge">http://purl.org/iot/vocab/m3-lite#Fridge</seealso>
    let Fridge = Prefixed_Name(m3lite, "Fridge") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:FuelConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The amount of fuel a vehicle uses to travel a particular distance at a particular speed."</para>
    /// labels<para>"Fuel Consumption Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FuelConsumption">http://purl.org/iot/vocab/m3-lite#FuelConsumption</seealso>
    let FuelConsumption = Prefixed_Name(m3lite, "FuelConsumption") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:FuelConsumptionInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A measure that displays the instantaneous fuel consumption of a vehicle during its operation."</para>
    /// labels<para>"Fuel Consumption Instantaneous"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FuelConsumptionInstantaneous">http://purl.org/iot/vocab/m3-lite#FuelConsumptionInstantaneous</seealso>
    let FuelConsumptionInstantaneous =
        Prefixed_Name(m3lite, "FuelConsumptionInstantaneous") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:FuelConsumptionTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Accumulated amount of fuel used during vehicle operation."</para>
    /// labels<para>"Fuel Consumption Total"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FuelConsumptionTotal">http://purl.org/iot/vocab/m3-lite#FuelConsumptionTotal</seealso>
    let FuelConsumptionTotal =
        Prefixed_Name(m3lite, "FuelConsumptionTotal") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:FuelLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect fuel level in a system such a car."</para>
    /// labels<para>"Fuel Level Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#FuelLevel">http://purl.org/iot/vocab/m3-lite#FuelLevel</seealso>
    let FuelLevel = Prefixed_Name(m3lite, "FuelLevel") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GPSSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that allows an object to localize itself."</para>
    /// labels<para>"GPS Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GPSSensor">http://purl.org/iot/vocab/m3-lite#GPSSensor</seealso>
    let GPSSensor = Prefixed_Name(m3lite, "GPSSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GasDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that detects the presence of gases in an area, often as part of a safety system."</para>
    /// labels<para>"Gas Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GasDetector">http://purl.org/iot/vocab/m3-lite#GasDetector</seealso>
    let GasDetector = Prefixed_Name(m3lite, "GasDetector") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:GaseousPollutantSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect poisonous gaseous in the environment."</para>
    /// labels<para>"Gaseous Pollutant Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GaseousPollutantSensor">http://purl.org/iot/vocab/m3-lite#GaseousPollutantSensor</seealso>
    let GaseousPollutantSensor =
        Prefixed_Name(m3lite, "GaseousPollutantSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Gauss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Gauss is the CGS unit of measurement of magnetic flux density (or magnetic induction) (B) (Source Wikipedia)"</para>
    /// labels<para>"Gauss"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Gauss">http://purl.org/iot/vocab/m3-lite#Gauss</seealso>
    let Gauss = Prefixed_Name(m3lite, "Gauss") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Glucometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect glucometer, blood sugar, blood glucose level"</para>
    ///   <para>"Device used to detect glucometer, blood sugar, blood glucose level."</para>
    /// labels<para>"Glucometer Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Glucometer">http://purl.org/iot/vocab/m3-lite#Glucometer</seealso>
    let Glucometer = Prefixed_Name(m3lite, "Glucometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Gram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a metric system unit of mass"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gram (g)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Gram">http://purl.org/iot/vocab/m3-lite#Gram</seealso>
    let Gram = Prefixed_Name(m3lite, "Gram") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is defined by mass in grams divided by volume in cubic metres."</para>
    /// labels<para>"Gram Per Cubic Metre"</para><para>"Gram Per Cubic Metre, Gram Per Cubic Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GramPerCubicMetre">http://purl.org/iot/vocab/m3-lite#GramPerCubicMetre</seealso>
    let GramPerCubicMetre = Prefixed_Name(m3lite, "GramPerCubicMetre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GramPerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It shows how many grams of a certain substance are present in one liter of a usually liquid or gaseous mixture."</para>
    /// labels<para>"Gram Per Liter (g/L)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GramPerLiter">http://purl.org/iot/vocab/m3-lite#GramPerLiter</seealso>
    let GramPerLiter = Prefixed_Name(m3lite, "GramPerLiter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GramPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It shows how many grams of a certain substance are present in one litre of a usually liquid or gaseous mixture."</para>
    /// labels<para>"Gram Per Litre, Gram Per Liter (g/L)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GramPerLitre">http://purl.org/iot/vocab/m3-lite#GramPerLitre</seealso>
    let GramPerLitre = Prefixed_Name(m3lite, "GramPerLitre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GyrometerSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gyrometer is an instrument which measures an angular speed."</para>
    /// labels<para>"Gyrometer Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GyrometerSensor">http://purl.org/iot/vocab/m3-lite#GyrometerSensor</seealso>
    let GyrometerSensor = Prefixed_Name(m3lite, "GyrometerSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:GyroscopeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A gyroscope is a device for measuring or maintening orientation."</para>
    ///   <para>"A gyroscope is a device for measuring or maintaining orientation."</para>
    /// labels<para>"Gyroscope Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#GyroscopeSensor">http://purl.org/iot/vocab/m3-lite#GyroscopeSensor</seealso>
    let GyroscopeSensor = Prefixed_Name(m3lite, "GyroscopeSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:H2SSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure of hydrogen sulfide in the environment."</para>
    ///   <para>"Device used to measure of hydrogen sulphide in the environment."</para>
    /// labels<para>"H2S Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#H2SSensor">http://purl.org/iot/vocab/m3-lite#H2SSensor</seealso>
    let H2SSensor = Prefixed_Name(m3lite, "H2SSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Health</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Healthcare as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Health Care DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Health">http://purl.org/iot/vocab/m3-lite#Health</seealso>
    let Health = Prefixed_Name(m3lite, "Health") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:HeartBeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The number of times your heart beats each minute (bpm)."</para>
    /// labels<para>"Heart Beat"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#HeartBeat">http://purl.org/iot/vocab/m3-lite#HeartBeat</seealso>
    let HeartBeat = Prefixed_Name(m3lite, "HeartBeat") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:HeartBeatSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device to count heart beats per minute."</para>
    /// labels<para>"Heart Beat Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#HeartBeatSensor">http://purl.org/iot/vocab/m3-lite#HeartBeatSensor</seealso>
    let HeartBeatSensor = Prefixed_Name(m3lite, "HeartBeatSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the heating."</para>
    /// labels<para>"Heating Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Heating">http://purl.org/iot/vocab/m3-lite#Heating</seealso>
    let Heating = Prefixed_Name(m3lite, "Heating") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Hertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SI unit of frequency, equal to one cycle per second."</para>
    /// labels<para>"Hertz"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Hertz">http://purl.org/iot/vocab/m3-lite#Hertz</seealso>
    let Hertz = Prefixed_Name(m3lite, "Hertz") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Hour of the day."</para>
    /// labels<para>"Hour"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Hour">http://purl.org/iot/vocab/m3-lite#Hour</seealso>
    let Hour = Prefixed_Name(m3lite, "Hour") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:HouseholdApplianceTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Household Appliance Temperature."</para>
    /// labels<para>"Household Appliance Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#HouseholdApplianceTemperature">http://purl.org/iot/vocab/m3-lite#HouseholdApplianceTemperature</seealso>
    let HouseholdApplianceTemperature =
        Prefixed_Name(m3lite, "HouseholdApplianceTemperature") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:HumanPresenceDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect if an object (vehicle, room, place, etc.) is occupied by Human."</para>
    /// labels<para>" Human Presence Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#HumanPresenceDetector">http://purl.org/iot/vocab/m3-lite#HumanPresenceDetector</seealso>
    let HumanPresenceDetector =
        Prefixed_Name(m3lite, "HumanPresenceDetector") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quantity representing the amount of water vapour in the atmosphere or in a gas."</para>
    /// labels<para>"Humidity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Humidity">http://purl.org/iot/vocab/m3-lite#Humidity</seealso>
    let Humidity = Prefixed_Name(m3lite, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Humidity sensor or hygrometer is an instrument used for measuring the moisture concent in the environment."</para>
    /// labels<para>"Humidity Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#HumiditySensor">http://purl.org/iot/vocab/m3-lite#HumiditySensor</seealso>
    let HumiditySensor = Prefixed_Name(m3lite, "HumiditySensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Hydrophone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A hydrophone is a microphone designed to be used underwater for recording or listening to underwater sound."</para>
    /// labels<para>"Hydrophone"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Hydrophone">http://purl.org/iot/vocab/m3-lite#Hydrophone</seealso>
    let Hydrophone = Prefixed_Name(m3lite, "Hydrophone") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:IEEE802154InterfaceEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that measures the power consumption of the IEEE802.15.4 interface nodes."</para>
    /// labels<para>"IEEE802.15.4 Interface Energy Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#IEEE802154InterfaceEnergyMeter">http://purl.org/iot/vocab/m3-lite#IEEE802154InterfaceEnergyMeter</seealso>
    let IEEE802154InterfaceEnergyMeter =
        Prefixed_Name(m3lite, "IEEE802154InterfaceEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Illuminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Illuminance is the total luminous flux incident on a surface, per unit area."</para>
    /// labels<para>"Illuminance"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Illuminance">http://purl.org/iot/vocab/m3-lite#Illuminance</seealso>
    let Illuminance = Prefixed_Name(m3lite, "Illuminance") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ImageSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects and conveys the information that constitutes an image."</para>
    /// labels<para>"Image Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ImageSensor">http://purl.org/iot/vocab/m3-lite#ImageSensor</seealso>
    let ImageSensor = Prefixed_Name(m3lite, "ImageSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Inch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Length in inches."</para>
    /// labels<para>"Inch"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Inch">http://purl.org/iot/vocab/m3-lite#Inch</seealso>
    let Inch = Prefixed_Name(m3lite, "Inch") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set."</para>
    ///   <para>"Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Index"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Index">http://purl.org/iot/vocab/m3-lite#Index</seealso>
    let Index = Prefixed_Name(m3lite, "Index") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:IntDlLatency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Downlink Latency."</para>
    /// labels<para>"Downlink Latency"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#IntDlLatency">http://purl.org/iot/vocab/m3-lite#IntDlLatency</seealso>
    let IntDlLatency = Prefixed_Name(m3lite, "IntDlLatency") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:IntDlThroughputKbps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Downlink Throughput."</para>
    /// labels<para>"Downlink Throughput"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#IntDlThroughputKbps">http://purl.org/iot/vocab/m3-lite#IntDlThroughputKbps</seealso>
    let IntDlThroughputKbps =
        Prefixed_Name(m3lite, "IntDlThroughputKbps") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:IntUlPacketLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uplink Packet Loss."</para>
    /// labels<para>"Uplink Packet Loss"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#IntUlPacketLoss">http://purl.org/iot/vocab/m3-lite#IntUlPacketLoss</seealso>
    let IntUlPacketLoss = Prefixed_Name(m3lite, "IntUlPacketLoss") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:IntUlThroughputKbps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uplink Throughput."</para>
    /// labels<para>"Uplink Throughput"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#IntUlThroughputKbps">http://purl.org/iot/vocab/m3-lite#IntUlThroughputKbps</seealso>
    let IntUlThroughputKbps =
        Prefixed_Name(m3lite, "IntUlThroughputKbps") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If the measurement was tagged invalid."</para>
    /// labels<para>"Invalid Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Invalid">http://purl.org/iot/vocab/m3-lite#Invalid</seealso>
    let Invalid = Prefixed_Name(m3lite, "Invalid") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:IonisingRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ionising radiation is radiation that carries enough energy to free electrons from atoms or molecules, thereby ionizing them. Gamma rays, X-rays, and the higher ultraviolet part of the electromagnetic spectrum are ionizing, whereas the lower ultraviolet part of the electromagnetic spectrum, and also the lower part of the spectrum below UV, including visible light (including nearly all types of laser light), infrared, microwaves, and radio waves are all considered non-ionizing radiation."</para>
    /// labels<para>"Ionising Radiation"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#IonisingRadiation">http://purl.org/iot/vocab/m3-lite#IonisingRadiation</seealso>
    let IonisingRadiation = Prefixed_Name(m3lite, "IonisingRadiation") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Irrigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically irrigate."</para>
    /// labels<para>"Irrigation Actuation Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Irrigation">http://purl.org/iot/vocab/m3-lite#Irrigation</seealso>
    let Irrigation = Prefixed_Name(m3lite, "Irrigation") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Each of the accountable elements within a group."</para>
    /// labels<para>"Item"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Item">http://purl.org/iot/vocab/m3-lite#Item</seealso>
    let Item = Prefixed_Name(m3lite, "Item") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Kelvin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Kelvin is a unit of measurement for temperature."</para>
    /// labels<para>"Kelvin, Degree Kelvin"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Kelvin">http://purl.org/iot/vocab/m3-lite#Kelvin</seealso>
    let Kelvin = Prefixed_Name(m3lite, "Kelvin") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:KiloWattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of electrical energy equivalent to a power consumption of one thousand watts for one hour."</para>
    /// labels<para>"Kilo Watt Hour"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#KiloWattHour">http://purl.org/iot/vocab/m3-lite#KiloWattHour</seealso>
    let KiloWattHour = Prefixed_Name(m3lite, "KiloWattHour") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:KilobitsPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of data transfer rate equal to: 1,000 bits per second."</para>
    /// labels<para>"Kilobits Per Second"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#KilobitsPerSecond">http://purl.org/iot/vocab/m3-lite#KilobitsPerSecond</seealso>
    let KilobitsPerSecond = Prefixed_Name(m3lite, "KilobitsPerSecond") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Kilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SI unit of mass, it is equal to the mass of the international prototype of the kilogram."</para>
    /// labels<para>"Kilogram (kg)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Kilogram">http://purl.org/iot/vocab/m3-lite#Kilogram</seealso>
    let Kilogram = Prefixed_Name(m3lite, "Kilogram") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:KilogramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is SI derived unit of density, defined by mass in kilograms divided by volume in cubic metres."</para>
    /// labels<para>"Kilogram Per Cubic Metre, Kilogram Per Cubic Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#KilogramPerCubicMetre">http://purl.org/iot/vocab/m3-lite#KilogramPerCubicMetre</seealso>
    let KilogramPerCubicMetre =
        Prefixed_Name(m3lite, "KilogramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:KilometerPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of speed, expressing the number of kilometres travelled in one hour."</para>
    /// labels<para>"Kilometer Per Hour"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#KilometerPerHour">http://purl.org/iot/vocab/m3-lite#KilometerPerHour</seealso>
    let KilometerPerHour = Prefixed_Name(m3lite, "KilometerPerHour") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Kilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metric unit of measurement equal to 1,000 metres (approx 0.62 miles)."</para>
    /// labels<para>"Kilometre, Kilometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Kilometre">http://purl.org/iot/vocab/m3-lite#Kilometre</seealso>
    let Kilometre = Prefixed_Name(m3lite, "Kilometre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:KilometrePerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of speed, expressing the number of kilometres travelled in one hour."</para>
    /// labels<para>"Kilometre Per Hour, Kilometer Per Hour"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#KilometrePerHour">http://purl.org/iot/vocab/m3-lite#KilometrePerHour</seealso>
    let KilometrePerHour = Prefixed_Name(m3lite, "KilometrePerHour") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Lamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the lamp."</para>
    /// labels<para>"Lamp Actuatating Device"</para><para>"Lamp Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Lamp">http://purl.org/iot/vocab/m3-lite#Lamp</seealso>
    let Lamp = Prefixed_Name(m3lite, "Lamp") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Lavatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the lavatory."</para>
    /// labels<para>"Lavatory"</para><para>"Lavatory Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Lavatory">http://purl.org/iot/vocab/m3-lite#Lavatory</seealso>
    let Lavatory = Prefixed_Name(m3lite, "Lavatory") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:LeafWetness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Leaf wetness is a meteorological parameter that describes the amount of dew and precipitation left on surfaces. It is used for monitoring leaf moisture for agricultural purposes, such as fungus and disease control, for control of irrigation systems, and for detection of fog and dew conditions, and early detection of rainfall. (Source Wikipedia)."</para>
    /// labels<para>"Leaf Wetness"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LeafWetness">http://purl.org/iot/vocab/m3-lite#LeafWetness</seealso>
    let LeafWetness = Prefixed_Name(m3lite, "LeafWetness") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:LeafWetnessSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Leaf Wetness Sensor is used in agriculture to check whether the plants need to be watered."</para>
    /// labels<para>"Leaf Wetness Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LeafWetnessSensor">http://purl.org/iot/vocab/m3-lite#LeafWetnessSensor</seealso>
    let LeafWetnessSensor = Prefixed_Name(m3lite, "LeafWetnessSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:LightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Light/Illuminance Sensor is used to adjust the brightness of the surface."</para>
    /// labels<para>"Light Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LightSensor">http://purl.org/iot/vocab/m3-lite#LightSensor</seealso>
    let LightSensor = Prefixed_Name(m3lite, "LightSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Liter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres."</para>
    /// labels<para>"Liter, Litre"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Liter">http://purl.org/iot/vocab/m3-lite#Liter</seealso>
    let Liter = Prefixed_Name(m3lite, "Liter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Litre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres."</para>
    /// labels<para>"Litre, Liter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Litre">http://purl.org/iot/vocab/m3-lite#Litre</seealso>
    let Litre = Prefixed_Name(m3lite, "Litre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:LitrePer100Kilometres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres."</para>
    /// labels<para>"Litre Per 100 Kilometres, Liter Per 100 Kilometers"</para><para>"Litre Per 100 Kilometres, Liter Per 100 Kilometers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LitrePer100Kilometres">http://purl.org/iot/vocab/m3-lite#LitrePer100Kilometres</seealso>
    let LitrePer100Kilometres =
        Prefixed_Name(m3lite, "LitrePer100Kilometres") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:LoRaInterfaceEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure the average power consumption of the LoRa interface nodes."</para>
    /// labels<para>"LoRa Interface Energy Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LoRaInterfaceEnergyMeter">http://purl.org/iot/vocab/m3-lite#LoRaInterfaceEnergyMeter</seealso>
    let LoRaInterfaceEnergyMeter =
        Prefixed_Name(m3lite, "LoRaInterfaceEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:LocationQK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particular place or position."</para>
    /// labels<para>"Location Quantity Kind"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LocationQK">http://purl.org/iot/vocab/m3-lite#LocationQK</seealso>
    let LocationQK = Prefixed_Name(m3lite, "LocationQK") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Lumen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SI unit of luminous flux, equal to the amount of light emitted per second in a unit solid angle of one steradian from a uniform source of one candela."</para>
    /// labels<para>"Lumen (lm)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Lumen">http://purl.org/iot/vocab/m3-lite#Lumen</seealso>
    let Lumen = Prefixed_Name(m3lite, "Lumen") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:LuminousFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Luminous Flux is the measure of the perceived power of light."</para>
    /// labels<para>"Luminous Flux"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LuminousFlux">http://purl.org/iot/vocab/m3-lite#LuminousFlux</seealso>
    let LuminousFlux = Prefixed_Name(m3lite, "LuminousFlux") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:LuminousIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" It is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye. The SI unit of luminous intensity is the candela (cd), an SI base unit. (Source Wikipedia)"</para>
    /// labels<para>"Luminous Intensity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#LuminousIntensity">http://purl.org/iot/vocab/m3-lite#LuminousIntensity</seealso>
    let LuminousIntensity = Prefixed_Name(m3lite, "LuminousIntensity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Lux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SI unit of illuminance, equal to one lumen per square metre."</para>
    /// labels<para>"Lux (lx)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Lux">http://purl.org/iot/vocab/m3-lite#Lux</seealso>
    let Lux = Prefixed_Name(m3lite, "Lux") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MagneticField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A region around a magnetic material or a moving electric charge within which the force of magnetism acts."</para>
    /// labels<para>"Magnetic Field"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MagneticField">http://purl.org/iot/vocab/m3-lite#MagneticField</seealso>
    let MagneticField = Prefixed_Name(m3lite, "MagneticField") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the magnetic flux  through a surface is the surface integral of the normal component of the magnetic field (B) passing through that surface. The SI unit of magnetic flux is the weber (Wb). (Source Wikipedia)."</para>
    /// labels<para>"Magnetic Flux Density"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MagneticFluxDensity">http://purl.org/iot/vocab/m3-lite#MagneticFluxDensity</seealso>
    let MagneticFluxDensity =
        Prefixed_Name(m3lite, "MagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Magnetometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A magnetometer is an device that measures magnetism—either magnetization of magnetic material like a ferromagnet, or the strength and, in some cases, direction of the magnetic field at a point in space. (Source Wikipedia)."</para>
    /// labels<para>"Magnetometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Magnetometer">http://purl.org/iot/vocab/m3-lite#Magnetometer</seealso>
    let Magnetometer = Prefixed_Name(m3lite, "Magnetometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"If the measurement was taken when human effort was involved."</para>
    /// labels<para>"Manual Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Manual">http://purl.org/iot/vocab/m3-lite#Manual</seealso>
    let Manual = Prefixed_Name(m3lite, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Mass is a property of a physical body. It is the measure of an object's resistance to acceleration when a net force is applied."</para>
    /// labels<para>"Mass"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Mass">http://purl.org/iot/vocab/m3-lite#Mass</seealso>
    let Mass = Prefixed_Name(m3lite, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MeasurementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Type of Measurement done using a device."</para>
    /// labels<para>"Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MeasurementType">http://purl.org/iot/vocab/m3-lite#MeasurementType</seealso>
    let MeasurementType = Prefixed_Name(m3lite, "MeasurementType") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Meter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the unit of length."</para>
    /// labels<para>"Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Meter">http://purl.org/iot/vocab/m3-lite#Meter</seealso>
    let Meter = Prefixed_Name(m3lite, "Meter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MeterPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A speed/velocity unit which is equal to the speed of an object traveling 1 meter distance in one second."</para>
    /// labels<para>"Meter Per Second (m/s)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MeterPerSecond">http://purl.org/iot/vocab/m3-lite#MeterPerSecond</seealso>
    let MeterPerSecond = Prefixed_Name(m3lite, "MeterPerSecond") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MeterPerSecondSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the unit of acceleration."</para>
    /// labels<para>"Meter Per Second Square"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MeterPerSecondSquare">http://purl.org/iot/vocab/m3-lite#MeterPerSecondSquare</seealso>
    let MeterPerSecondSquare =
        Prefixed_Name(m3lite, "MeterPerSecondSquare") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MethaneSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Methane in the environment."</para>
    /// labels<para>"Methane (CH4) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MethaneSensor">http://purl.org/iot/vocab/m3-lite#MethaneSensor</seealso>
    let MethaneSensor = Prefixed_Name(m3lite, "MethaneSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Metre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the unit of length."</para>
    /// labels<para>"Metre, Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Metre">http://purl.org/iot/vocab/m3-lite#Metre</seealso>
    let Metre = Prefixed_Name(m3lite, "Metre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MetrePerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A speed/velocity unit which is equal to the speed of an object traveling 1 metre distance in one second."</para>
    /// labels<para>"Metre Per Second, Meter Per Second  (m/s)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MetrePerSecond">http://purl.org/iot/vocab/m3-lite#MetrePerSecond</seealso>
    let MetrePerSecond = Prefixed_Name(m3lite, "MetrePerSecond") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MetrePerSecondSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the unit of acceleration."</para>
    /// labels<para>"Metre Per Second Square, Meter Per Second Square"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MetrePerSecondSquare">http://purl.org/iot/vocab/m3-lite#MetrePerSecondSquare</seealso>
    let MetrePerSecondSquare =
        Prefixed_Name(m3lite, "MetrePerSecondSquare") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MicroWattPerSquareCentiMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is one of the unit for radiative and other energy fluxes."</para>
    /// labels<para>"Microwatt Per Square Centimetre, Microwatt Per Square Centimeter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MicroWattPerSquareCentiMeter">http://purl.org/iot/vocab/m3-lite#MicroWattPerSquareCentiMeter</seealso>
    let MicroWattPerSquareCentiMeter =
        Prefixed_Name(m3lite, "MicroWattPerSquareCentiMeter") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Microampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of electric current, or amount of electric charge per second."</para>
    /// labels<para>"Microampere (uA)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Microampere">http://purl.org/iot/vocab/m3-lite#Microampere</seealso>
    let Microampere = Prefixed_Name(m3lite, "Microampere") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Microgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of mass equal to one billionth (1×10^−9) of a kilogram."</para>
    /// labels<para>"Microgram (ug)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Microgram">http://purl.org/iot/vocab/m3-lite#Microgram</seealso>
    let Microgram = Prefixed_Name(m3lite, "Microgram") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MicrogramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Microgram per cubic metre is a unit of density defined as microgram divided by cubic metre. Milligram per cubic metre is a derived unit in the International System of Units."</para>
    /// labels<para>"Microgram Per Cubic Metre, Microgram Per Cubic Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MicrogramPerCubicMetre">http://purl.org/iot/vocab/m3-lite#MicrogramPerCubicMetre</seealso>
    let MicrogramPerCubicMetre =
        Prefixed_Name(m3lite, "MicrogramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Microvolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of electromotive force or potential difference equal to one millionth of a volt. "</para>
    /// labels<para>"Microvolt (uV)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Microvolt">http://purl.org/iot/vocab/m3-lite#Microvolt</seealso>
    let Microvolt = Prefixed_Name(m3lite, "Microvolt") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Microwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of power."</para>
    /// labels<para>"Microwatt (uW)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Microwatt">http://purl.org/iot/vocab/m3-lite#Microwatt</seealso>
    let Microwatt = Prefixed_Name(m3lite, "Microwatt") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MicrowattPerSquareCentimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is one of the unit for radiative and other energy fluxes."</para>
    /// labels<para>"Microwatt Per Square Centimetre, Microwatt Per Square Centimeter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MicrowattPerSquareCentimetre">http://purl.org/iot/vocab/m3-lite#MicrowattPerSquareCentimetre</seealso>
    let MicrowattPerSquareCentimetre =
        Prefixed_Name(m3lite, "MicrowattPerSquareCentimetre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Microwave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the Microwave."</para>
    /// labels<para>"Microwave Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Microwave">http://purl.org/iot/vocab/m3-lite#Microwave</seealso>
    let Microwave = Prefixed_Name(m3lite, "Microwave") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Mileage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of the number of miles or the average distance that a vehicle can travel on a specified quantity of fuel"</para>
    /// labels<para>"Mileage"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Mileage">http://purl.org/iot/vocab/m3-lite#Mileage</seealso>
    let Mileage = Prefixed_Name(m3lite, "Mileage") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MileageDistanceToService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The distance which can be travelled by the vehicle before the next service inspection is required.  A negative distance is transmitted if the service inspection has been passed."</para>
    /// labels<para>"Mileage Distance To Service"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MileageDistanceToService">http://purl.org/iot/vocab/m3-lite#MileageDistanceToService</seealso>
    let MileageDistanceToService =
        Prefixed_Name(m3lite, "MileageDistanceToService") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MileageTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The total distance travelled by the particular vehicle since its initial production."</para>
    /// labels<para>"Mileage Total"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MileageTotal">http://purl.org/iot/vocab/m3-lite#MileageTotal</seealso>
    let MileageTotal = Prefixed_Name(m3lite, "MileageTotal") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Miles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of length that is equal to 1,760 yards (approx. 1.609 kilometres)."</para>
    /// labels<para>"Miles"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Miles">http://purl.org/iot/vocab/m3-lite#Miles</seealso>
    let Miles = Prefixed_Name(m3lite, "Miles") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Milliampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of an ampere."</para>
    /// labels<para>"Milliampere (mA)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Milliampere">http://purl.org/iot/vocab/m3-lite#Milliampere</seealso>
    let Milliampere = Prefixed_Name(m3lite, "Milliampere") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Millibar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of a bar."</para>
    /// labels<para>"Millibar"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Millibar">http://purl.org/iot/vocab/m3-lite#Millibar</seealso>
    let Millibar = Prefixed_Name(m3lite, "Millibar") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Milligram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of a gram."</para>
    /// labels<para>"Milligram (mg)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Milligram">http://purl.org/iot/vocab/m3-lite#Milligram</seealso>
    let Milligram = Prefixed_Name(m3lite, "Milligram") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MilligramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a density measurement unit."</para>
    /// labels<para>"Milligram Per Cubic Metre, Milligram Per Cubic Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MilligramPerCubicMetre">http://purl.org/iot/vocab/m3-lite#MilligramPerCubicMetre</seealso>
    let MilligramPerCubicMetre =
        Prefixed_Name(m3lite, "MilligramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MilligramPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Level of Dissolved substance in liquid measured in mg per litre."</para>
    /// labels<para>"Milligram Per Litre, Milligram Per Liter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MilligramPerLitre">http://purl.org/iot/vocab/m3-lite#MilligramPerLitre</seealso>
    let MilligramPerLitre = Prefixed_Name(m3lite, "MilligramPerLitre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MilligramPerSquareMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A dose unit which is equal to 1 milligram of a substance per square metre of surface area of the recipient subject."</para>
    ///   <para>"A dose unit which is equal to 1 milligram of a substance per square meter of surface area of the recipient subject."</para>
    /// labels<para>"Milligram Per Square Metre, Milligram Per Square Meter"</para><para>"Milligram Per Square Metre"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MilligramPerSquareMetre">http://purl.org/iot/vocab/m3-lite#MilligramPerSquareMetre</seealso>
    let MilligramPerSquareMetre =
        Prefixed_Name(m3lite, "MilligramPerSquareMetre") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Millilitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of a litre (0.002 pint)."</para>
    /// labels<para>"Millilitre"</para><para>"Millilitre, Milliliter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Millilitre">http://purl.org/iot/vocab/m3-lite#Millilitre</seealso>
    let Millilitre = Prefixed_Name(m3lite, "Millilitre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MillimeterPerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimeter travelled per unit hour."</para>
    /// labels<para>"Millimeter Per Hour, Millimetre Per Hour"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MillimeterPerHour">http://purl.org/iot/vocab/m3-lite#MillimeterPerHour</seealso>
    let MillimeterPerHour = Prefixed_Name(m3lite, "MillimeterPerHour") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Millimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of a metre (0.039 in)."</para>
    /// labels<para>"Millimetre, Millimeter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Millimetre">http://purl.org/iot/vocab/m3-lite#Millimetre</seealso>
    let Millimetre = Prefixed_Name(m3lite, "Millimetre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MillimetrePerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimetre travelled per unit hour."</para>
    /// labels<para>"Millimetre Per Hour, Millimeter Per Hour"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MillimetrePerHour">http://purl.org/iot/vocab/m3-lite#MillimetrePerHour</seealso>
    let MillimetrePerHour = Prefixed_Name(m3lite, "MillimetrePerHour") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Millisecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of a second."</para>
    /// labels<para>"Millisecond"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Millisecond">http://purl.org/iot/vocab/m3-lite#Millisecond</seealso>
    let Millisecond = Prefixed_Name(m3lite, "Millisecond") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Millivolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"One thousandth of a volt."</para>
    /// labels<para>"Millivolt (mV)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Millivolt">http://purl.org/iot/vocab/m3-lite#Millivolt</seealso>
    let Millivolt = Prefixed_Name(m3lite, "Millivolt") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MillivoltPerMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a measure of the intensity of the signal of a radio transmitter."</para>
    /// labels<para>"Millivolt Per Meter, Millivolt Per Metre"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MillivoltPerMeter">http://purl.org/iot/vocab/m3-lite#MillivoltPerMeter</seealso>
    let MillivoltPerMeter = Prefixed_Name(m3lite, "MillivoltPerMeter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MillivoltPerMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a measure of the intensity of the signal of a radio transmitter."</para>
    /// labels<para>"Millivolt Per Metre, Millivolt Per Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MillivoltPerMetre">http://purl.org/iot/vocab/m3-lite#MillivoltPerMetre</seealso>
    let MillivoltPerMetre = Prefixed_Name(m3lite, "MillivoltPerMetre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Milliwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of power equal to one thousandth of a watt."</para>
    /// labels<para>"Milliwatt (mW)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Milliwatt">http://purl.org/iot/vocab/m3-lite#Milliwatt</seealso>
    let Milliwatt = Prefixed_Name(m3lite, "Milliwatt") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MinuteAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Minute of Angle (MOA) is an angular measurement. A MOA is 1/60th of a degree."</para>
    /// labels<para>"Minute Angle"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MinuteAngle">http://purl.org/iot/vocab/m3-lite#MinuteAngle</seealso>
    let MinuteAngle = Prefixed_Name(m3lite, "MinuteAngle") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MinuteTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of time equal to 60 seconds or 1/60th of an hour."</para>
    /// labels<para>"Minute Time"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MinuteTime">http://purl.org/iot/vocab/m3-lite#MinuteTime</seealso>
    let MinuteTime = Prefixed_Name(m3lite, "MinuteTime") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MmHg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic)."</para>
    ///   <para>"A millimeter of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic)."</para>
    /// labels<para>"MmHg"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MmHg">http://purl.org/iot/vocab/m3-lite#MmHg</seealso>
    let MmHg = Prefixed_Name(m3lite, "MmHg") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MmolPerLiter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLiter is used to measure cholesterol."</para>
    /// labels<para>"Mmol Per Liter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MmolPerLiter">http://purl.org/iot/vocab/m3-lite#MmolPerLiter</seealso>
    let MmolPerLiter = Prefixed_Name(m3lite, "MmolPerLiter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MmolPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLitre is used to measure cholesterol."</para>
    /// labels<para>"Mmol Per Litre, Mmol Per Liter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MmolPerLitre">http://purl.org/iot/vocab/m3-lite#MmolPerLitre</seealso>
    let MmolPerLitre = Prefixed_Name(m3lite, "MmolPerLitre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MobHoExecSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Handover Execution."</para>
    /// labels<para>"Handover Execution"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MobHoExecSuccRate">http://purl.org/iot/vocab/m3-lite#MobHoExecSuccRate</seealso>
    let MobHoExecSuccRate = Prefixed_Name(m3lite, "MobHoExecSuccRate") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MobHoPrepSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Handover Preparation Success Rate."</para>
    /// labels<para>"Handover Preparation Success Rate"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MobHoPrepSuccRate">http://purl.org/iot/vocab/m3-lite#MobHoPrepSuccRate</seealso>
    let MobHoPrepSuccRate = Prefixed_Name(m3lite, "MobHoPrepSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:MobMobilitySuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Handover Mobility Success Rate."</para>
    /// labels<para>"Handover Mobility Success Rate"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MobMobilitySuccRate">http://purl.org/iot/vocab/m3-lite#MobMobilitySuccRate</seealso>
    let MobMobilitySuccRate =
        Prefixed_Name(m3lite, "MobMobilitySuccRate") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Motion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the action or process of moving or being moved."</para>
    /// labels<para>"Motion"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Motion">http://purl.org/iot/vocab/m3-lite#Motion</seealso>
    let Motion = Prefixed_Name(m3lite, "Motion") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MotionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicator of whether a person (or object) is detected upon his/her/its movement."</para>
    /// labels<para>"Motion State"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MotionState">http://purl.org/iot/vocab/m3-lite#MotionState</seealso>
    let MotionState = Prefixed_Name(m3lite, "MotionState") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:MotionStateVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates whether motion of the vehicle is detected or not."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Indicates whether motion of the vehicle is detected or not."</para>
    /// labels<para>"Motion State Vehicle"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#MotionStateVehicle">http://purl.org/iot/vocab/m3-lite#MotionStateVehicle</seealso>
    let MotionStateVehicle = Prefixed_Name(m3lite, "MotionStateVehicle") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:NFC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tagging device can be NFC (Near Field Communication)."</para>
    /// labels<para>"NFC Tagging Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#NFC">http://purl.org/iot/vocab/m3-lite#NFC</seealso>
    let NFC = Prefixed_Name(m3lite, "NFC") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:NH3Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect NH3 level in the environment."</para>
    /// labels<para>"NH3 Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#NH3Sensor">http://purl.org/iot/vocab/m3-lite#NH3Sensor</seealso>
    let NH3Sensor = Prefixed_Name(m3lite, "NH3Sensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:NO2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor detecting levels of Nitrogen Dioxide (NO2) in the environment."</para>
    /// labels<para>"Nitrogen Dioxide (NO2) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#NO2Sensor">http://purl.org/iot/vocab/m3-lite#NO2Sensor</seealso>
    let NO2Sensor = Prefixed_Name(m3lite, "NO2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:NOSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Nitrogen Oxide (NO) in the environment."</para>
    /// labels<para>"Nitrogen Oxide (NO) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#NOSensor">http://purl.org/iot/vocab/m3-lite#NOSensor</seealso>
    let NOSensor = Prefixed_Name(m3lite, "NOSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Neighbors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound were noisy neighbors."</para>
    /// labels<para>"Neighbors Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Neighbors">http://purl.org/iot/vocab/m3-lite#Neighbors</seealso>
    let Neighbors = Prefixed_Name(m3lite, "Neighbors") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Neighbours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound were noisy neighbours."</para>
    /// labels<para>"Neighbours Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Neighbours">http://purl.org/iot/vocab/m3-lite#Neighbours</seealso>
    let Neighbours = Prefixed_Name(m3lite, "Neighbours") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:O3Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Ozone (O3) in the environment."</para>
    /// labels<para>"Ozone (O3) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#O3Sensor">http://purl.org/iot/vocab/m3-lite#O3Sensor</seealso>
    let O3Sensor = Prefixed_Name(m3lite, "O3Sensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:OccupancyDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect if on object is occupied or not."</para>
    /// labels<para>"Occupancy Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#OccupancyDetector">http://purl.org/iot/vocab/m3-lite#OccupancyDetector</seealso>
    let OccupancyDetector = Prefixed_Name(m3lite, "OccupancyDetector") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Odometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An odometer or odograph is an instrument that indicates distance traveled by a vehicle, such as bicycle or automobile."</para>
    ///   <para>"An odometer or odograph is an instrument that indicates distance travelled by a vehicle, such as bicycle or automobile."</para>
    /// labels<para>"Odometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Odometer">http://purl.org/iot/vocab/m3-lite#Odometer</seealso>
    let Odometer = Prefixed_Name(m3lite, "Odometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Ohm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ohm is the unit of electrical resistance."</para>
    /// labels<para>"Ohm"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Ohm">http://purl.org/iot/vocab/m3-lite#Ohm</seealso>
    let Ohm = Prefixed_Name(m3lite, "Ohm") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Okta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Okta is the unit to measure the cloud cover."</para>
    /// labels<para>"Okta"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Okta">http://purl.org/iot/vocab/m3-lite#Okta</seealso>
    let Okta = Prefixed_Name(m3lite, "Okta") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:OpticalDustSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensing device that measures dust particle concentration using optical sensing mean."</para>
    /// labels<para>"Optical Dust Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#OpticalDustSensor">http://purl.org/iot/vocab/m3-lite#OpticalDustSensor</seealso>
    let OpticalDustSensor = Prefixed_Name(m3lite, "OpticalDustSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Others</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Relates to phenomenon and unit that are not available currently in the current version of Taxonomy."</para>
    /// labels<para>"Others"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Others">http://purl.org/iot/vocab/m3-lite#Others</seealso>
    let Others = Prefixed_Name(m3lite, "Others") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:OxygenSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Oxygen (O2) in the environment."</para>
    /// labels<para>"Oxygen Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#OxygenSensor">http://purl.org/iot/vocab/m3-lite#OxygenSensor</seealso>
    let OxygenSensor = Prefixed_Name(m3lite, "OxygenSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a numeric scale used to specify the acidity or basicity of an aqueous solution."</para>
    /// labels<para>"PH"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PH">http://purl.org/iot/vocab/m3-lite#PH</seealso>
    let PH = Prefixed_Name(m3lite, "PH") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PHSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect PH level."</para>
    /// labels<para>"PH Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PHSensor">http://purl.org/iot/vocab/m3-lite#PHSensor</seealso>
    let PHSensor = Prefixed_Name(m3lite, "PHSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PPM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the concentration of something in water or soil."</para>
    /// labels<para>"PPM (parts per million)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PPM">http://purl.org/iot/vocab/m3-lite#PPM</seealso>
    let PPM = Prefixed_Name(m3lite, "PPM") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PartsPerBillion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It describes the concentration of something in parts per billion parts of water or soil, expressed in any (but common) unit of measurement."</para>
    /// labels<para>"Parts Per Billion"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PartsPerBillion">http://purl.org/iot/vocab/m3-lite#PartsPerBillion</seealso>
    let PartsPerBillion = Prefixed_Name(m3lite, "PartsPerBillion") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Pascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Unit for pressure (e.g., atmospheric pressure)."</para>
    /// labels<para>"Pascal"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Pascal">http://purl.org/iot/vocab/m3-lite#Pascal</seealso>
    let Pascal = Prefixed_Name(m3lite, "Pascal") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Pedometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pedometer is used to count the number of steps when walking, running, etc."</para>
    /// labels<para>"Pedometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Pedometer">http://purl.org/iot/vocab/m3-lite#Pedometer</seealso>
    let Pedometer = Prefixed_Name(m3lite, "Pedometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Percent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the amount in or for every hundred."</para>
    /// labels<para>"Percent"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Percent">http://purl.org/iot/vocab/m3-lite#Percent</seealso>
    let Percent = Prefixed_Name(m3lite, "Percent") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Location, Place, GPS coordinates as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Place DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Place">http://purl.org/iot/vocab/m3-lite#Place</seealso>
    let Place = Prefixed_Name(m3lite, "Place") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Potassium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the measure of Blood Potassium Level."</para>
    /// labels<para>"Potassium"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Potassium">http://purl.org/iot/vocab/m3-lite#Potassium</seealso>
    let Potassium = Prefixed_Name(m3lite, "Potassium") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Pound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A unit of weight equal to 16 oz. 1 pound= 453.592 grams"</para>
    /// labels<para>"Pound"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Pound">http://purl.org/iot/vocab/m3-lite#Pound</seealso>
    let Pound = Prefixed_Name(m3lite, "Pound") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the rate, per unit time, at which electrical energy is transferred by an electric circuit."</para>
    /// labels<para>"Power"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Power">http://purl.org/iot/vocab/m3-lite#Power</seealso>
    let Power = Prefixed_Name(m3lite, "Power") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is any product of the condensation of atmospheric water vapor that falls under gravity."</para>
    ///   <para>"It is any product of the condensation of atmospheric water vapour that falls under gravity."</para>
    /// labels<para>"Precipitation"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Precipitation">http://purl.org/iot/vocab/m3-lite#Precipitation</seealso>
    let Precipitation = Prefixed_Name(m3lite, "Precipitation") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PrecipitationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a device measuring the amount of precipitation."</para>
    /// labels<para>"Precipitation Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PrecipitationSensor">http://purl.org/iot/vocab/m3-lite#PrecipitationSensor</seealso>
    let PrecipitationSensor =
        Prefixed_Name(m3lite, "PrecipitationSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Presence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure to know if an object is present. It is usually boolean."</para>
    /// labels<para>"Presence"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Presence">http://purl.org/iot/vocab/m3-lite#Presence</seealso>
    let Presence = Prefixed_Name(m3lite, "Presence") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PresenceDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect if on object is occupied or not."</para>
    /// labels<para>"Presence Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceDetector">http://purl.org/iot/vocab/m3-lite#PresenceDetector</seealso>
    let PresenceDetector = Prefixed_Name(m3lite, "PresenceDetector") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PresenceStateDriverCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the presence of the first driver card."</para>
    /// labels<para>"Presence State Driver Card"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard">http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard</seealso>
    let PresenceStateDriverCard =
        Prefixed_Name(m3lite, "PresenceStateDriverCard") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PresenceStateDriverCard1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the presence of the first driver card."</para>
    /// labels<para>"Presence State Driver Card 1"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard1">http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard1</seealso>
    let PresenceStateDriverCard1 =
        Prefixed_Name(m3lite, "PresenceStateDriverCard1") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PresenceStateDriverCard2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the presence of the second driver card."</para>
    /// labels<para>"Presence State Driver Card 2"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard2">http://purl.org/iot/vocab/m3-lite#PresenceStateDriverCard2</seealso>
    let PresenceStateDriverCard2 =
        Prefixed_Name(m3lite, "PresenceStateDriverCard2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PresenceStateEmergencyVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.)."</para>
    /// labels<para>"Presence State Emergency Vehicle"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceStateEmergencyVehicle">http://purl.org/iot/vocab/m3-lite#PresenceStateEmergencyVehicle</seealso>
    let PresenceStateEmergencyVehicle =
        Prefixed_Name(m3lite, "PresenceStateEmergencyVehicle") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PresenceStateParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The presence or absence of a vehicle parked."</para>
    ///   <para>"The presence or absence of a vehicle parked."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Presence State Parking"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceStateParking">http://purl.org/iot/vocab/m3-lite#PresenceStateParking</seealso>
    let PresenceStateParking =
        Prefixed_Name(m3lite, "PresenceStateParking") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:PresenceStatePeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The presence or absence of people passing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The presence or absence of people passing."</para>
    /// labels<para>"Presence State People"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PresenceStatePeople">http://purl.org/iot/vocab/m3-lite#PresenceStatePeople</seealso>
    let PresenceStatePeople =
        Prefixed_Name(m3lite, "PresenceStatePeople") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the physical force exerted on or against an object by something in contact with it."</para>
    /// labels<para>"Pressure"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Pressure">http://purl.org/iot/vocab/m3-lite#Pressure</seealso>
    let Pressure = Prefixed_Name(m3lite, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device used to detect pressure. For example, it can be attached on the bed to infer if the user is lying, sleeping, sitting, bed occupancy, etc."</para>
    /// labels<para>"Pressure Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PressureSensor">http://purl.org/iot/vocab/m3-lite#PressureSensor</seealso>
    let PressureSensor = Prefixed_Name(m3lite, "PressureSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Proximity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure to detect proximity."</para>
    /// labels<para>"Proximity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Proximity">http://purl.org/iot/vocab/m3-lite#Proximity</seealso>
    let Proximity = Prefixed_Name(m3lite, "Proximity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ProximitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Detect if something is within proximity of a sensor."</para>
    /// labels<para>"Proximity Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ProximitySensor">http://purl.org/iot/vocab/m3-lite#ProximitySensor</seealso>
    let ProximitySensor = Prefixed_Name(m3lite, "ProximitySensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PublicTransit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound was public transit."</para>
    ///   <para>"When the source of the sound was Public transit."</para>
    /// labels<para>"Public Transit"</para><para>"Public Transit Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PublicTransit">http://purl.org/iot/vocab/m3-lite#PublicTransit</seealso>
    let PublicTransit = Prefixed_Name(m3lite, "PublicTransit") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:PulseOxymeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Pulse Oxymeter, SpO2, Blood Oxygen Saturation Sensor are used to measure the concentration of oxygen in the blood."</para>
    /// labels<para>"Pulse Oxymeter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#PulseOxymeter">http://purl.org/iot/vocab/m3-lite#PulseOxymeter</seealso>
    let PulseOxymeter = Prefixed_Name(m3lite, "PulseOxymeter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:QRCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tagging device can be QRCode."</para>
    /// labels<para>"QR Code tagging Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#QRCode">http://purl.org/iot/vocab/m3-lite#QRCode</seealso>
    let QRCode = Prefixed_Name(m3lite, "QRCode") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:RFID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A tagging device can be RFID."</para>
    /// labels<para>"RFID Tagging Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RFID">http://purl.org/iot/vocab/m3-lite#RFID</seealso>
    let RFID = Prefixed_Name(m3lite, "RFID") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Radian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The radian is a unit of angular measure defined such that an angle of one radian subtended from the center of a unit circle produces an arc with arc length 1."</para>
    ///   <para>"The radian is a unit of angular measure defined such that an angle of one radian subtended from the centre of a unit circle produces an arc with arc length 1."</para>
    /// labels<para>"Radian"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Radian">http://purl.org/iot/vocab/m3-lite#Radian</seealso>
    let Radian = Prefixed_Name(m3lite, "Radian") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:RadianPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The radian per second is defined as the change in the orientation of an object, in radians, every second. The radian per second is the SI unit of angular (rotational) speed."</para>
    /// labels<para>"Radian Per Second"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RadianPerSecond">http://purl.org/iot/vocab/m3-lite#RadianPerSecond</seealso>
    let RadianPerSecond = Prefixed_Name(m3lite, "RadianPerSecond") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RadiationParticleDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A particle detector, also known as a radiation detector or Geiger counter, is a device used to detect, track, and/or identify ionising particles, such as those produced by nuclear decay, cosmic radiation, or reactions in a particle accelerator."</para>
    /// labels<para>"Radiation Particle Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RadiationParticleDetector">http://purl.org/iot/vocab/m3-lite#RadiationParticleDetector</seealso>
    let RadiationParticleDetector =
        Prefixed_Name(m3lite, "RadiationParticleDetector") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RadiationParticlesPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The number of ionizing events detected in one minute."</para>
    /// labels<para>"Radiation Particles Per Minute"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RadiationParticlesPerMinute">http://purl.org/iot/vocab/m3-lite#RadiationParticlesPerMinute</seealso>
    let RadiationParticlesPerMinute =
        Prefixed_Name(m3lite, "RadiationParticlesPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Rainfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The depth of precipitation (water-equivalent) that accumulated over a measurement time quantity."</para>
    /// labels<para>"Rainfall"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Rainfall">http://purl.org/iot/vocab/m3-lite#Rainfall</seealso>
    let Rainfall = Prefixed_Name(m3lite, "Rainfall") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ReactivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The portion of electricity that establishes and sustains the electric and magnetic fields of alternating-current equipment."</para>
    /// labels<para>"Reactive Power"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ReactivePower">http://purl.org/iot/vocab/m3-lite#ReactivePower</seealso>
    let ReactivePower = Prefixed_Name(m3lite, "ReactivePower") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:RecognizedActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Activity Recognized. This is usually made available as a part of analysis done by Google. The available activities recognized are IN_VEHICLE, ON_BICYCLE, ON_FOOT, RUNNING, STILL, TILTING, UNKNOWN, and WALKING."</para>
    /// labels<para>"Recognized Activity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RecognizedActivity">http://purl.org/iot/vocab/m3-lite#RecognizedActivity</seealso>
    let RecognizedActivity = Prefixed_Name(m3lite, "RecognizedActivity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:RelativeHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ratio of vapour pressure to saturation vapour pressure, where vapour pressure is the pressure exerted by the molecules of water vapour and saturation vapour pressure is the pressure exerted by molecules of water vapour in AIR that has attained saturation."</para>
    /// labels<para>"Relative Humidity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RelativeHumidity">http://purl.org/iot/vocab/m3-lite#RelativeHumidity</seealso>
    let RelativeHumidity = Prefixed_Name(m3lite, "RelativeHumidity") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:ResAverageLicConnectedUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Connected Users to a communication channel/platform"</para>
    /// labels<para>"Connected Users"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ResAverageLicConnectedUsers">http://purl.org/iot/vocab/m3-lite#ResAverageLicConnectedUsers</seealso>
    let ResAverageLicConnectedUsers =
        Prefixed_Name(m3lite, "ResAverageLicConnectedUsers") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RetERabDrop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"ERAB Drop."</para>
    /// labels<para>"ERAB Drop"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RetERabDrop">http://purl.org/iot/vocab/m3-lite#RetERabDrop</seealso>
    let RetERabDrop = Prefixed_Name(m3lite, "RetERabDrop") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RevolutionsPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component."</para>
    ///   <para>"Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Revolutions Per Minute"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RevolutionsPerMinute">http://purl.org/iot/vocab/m3-lite#RevolutionsPerMinute</seealso>
    let RevolutionsPerMinute =
        Prefixed_Name(m3lite, "RevolutionsPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RoadOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ratio of time on which a road lane section is occupied by vehicles within a given period of time."</para>
    ///   <para>"Ratio of time on which a road lane section is occupied by vehicles within a given period of time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Road Occupancy"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RoadOccupancy">http://purl.org/iot/vocab/m3-lite#RoadOccupancy</seealso>
    let RoadOccupancy = Prefixed_Name(m3lite, "RoadOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RoadSurfaceThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure the road Surface temperature."</para>
    /// labels<para>"Road Surface Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RoadSurfaceThermometer">http://purl.org/iot/vocab/m3-lite#RoadSurfaceThermometer</seealso>
    let RoadSurfaceThermometer =
        Prefixed_Name(m3lite, "RoadSurfaceThermometer") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RoadTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Temperature of the road."</para>
    /// labels<para>"Road Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RoadTemperature">http://purl.org/iot/vocab/m3-lite#RoadTemperature</seealso>
    let RoadTemperature = Prefixed_Name(m3lite, "RoadTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:RoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Temperature of a room."</para>
    /// labels<para>"Room Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RoomTemperature">http://purl.org/iot/vocab/m3-lite#RoomTemperature</seealso>
    let RoomTemperature = Prefixed_Name(m3lite, "RoomTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:RotationalSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Rotational speed (or speed of revolution) of an object rotating around an axis is the number of turns of the object divided by time, specified as revolutions per minute (rpm), revolutions per second (rev/s), or radians per second (rad/s). (Source Wikipedia)"</para>
    /// labels<para>"Rotational Speed"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RotationalSpeed">http://purl.org/iot/vocab/m3-lite#RotationalSpeed</seealso>
    let RotationalSpeed = Prefixed_Name(m3lite, "RotationalSpeed") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:RotationalSpeedEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Rotational speed is a property that is the rate of rotation of a material around an axis, in this case the engine cylinders."</para>
    /// labels<para>"Rotational Speed Engine"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#RotationalSpeedEngine">http://purl.org/iot/vocab/m3-lite#RotationalSpeedEngine</seealso>
    let RotationalSpeedEngine =
        Prefixed_Name(m3lite, "RotationalSpeedEngine") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SO2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device use to detect Sulphur Dioxide (SO2) level in the environment."</para>
    /// labels<para>"Sulphur Dioxide (SO2) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SO2Sensor">http://purl.org/iot/vocab/m3-lite#SO2Sensor</seealso>
    let SO2Sensor = Prefixed_Name(m3lite, "SO2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SPO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a measure of the amount of oxygenated haemoglobin in the blood."</para>
    /// labels<para>"SPO2"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SPO2">http://purl.org/iot/vocab/m3-lite#SPO2</seealso>
    let SPO2 = Prefixed_Name(m3lite, "SPO2") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Salinity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the measure of all the salts dissolved in water."</para>
    /// labels<para>"Salinity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Salinity">http://purl.org/iot/vocab/m3-lite#Salinity</seealso>
    let Salinity = Prefixed_Name(m3lite, "Salinity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SaltMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device use to detect salinity of water."</para>
    /// labels<para>"Salt Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SaltMeter">http://purl.org/iot/vocab/m3-lite#SaltMeter</seealso>
    let SaltMeter = Prefixed_Name(m3lite, "SaltMeter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values are part of a continuous variable which can take any numeric value."</para>
    /// labels<para>"Scale"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Scale">http://purl.org/iot/vocab/m3-lite#Scale</seealso>
    let Scale = Prefixed_Name(m3lite, "Scale") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SeatBeltTensionSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>" Actuator used to turn Seat Belt Tension Actuator on or off. "</para>
    /// labels<para>"Seat Belt Tension Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SeatBeltTensionSensor">http://purl.org/iot/vocab/m3-lite#SeatBeltTensionSensor</seealso>
    let SeatBeltTensionSensor =
        Prefixed_Name(m3lite, "SeatBeltTensionSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SecondAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a unit of angular measurement equal to 1/60 of one degree."</para>
    /// labels<para>"Second Angle"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SecondAngle">http://purl.org/iot/vocab/m3-lite#SecondAngle</seealso>
    let SecondAngle = Prefixed_Name(m3lite, "SecondAngle") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SecondTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Qualitatively defined as the second division of the hour by sixty, the first division by sixty being the minute. SI definition of second is "the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium 133 atom."</para>
    /// labels<para>"Second Time"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SecondTime">http://purl.org/iot/vocab/m3-lite#SecondTime</seealso>
    let SecondTime = Prefixed_Name(m3lite, "SecondTime") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Seismometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Seismometers are instruments that measure motions of the ground, including those of seismic waves generated by earthquakes, volcanic eruptions, and other seismic sources."</para>
    /// labels<para>"Seismometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Seismometer">http://purl.org/iot/vocab/m3-lite#Seismometer</seealso>
    let Seismometer = Prefixed_Name(m3lite, "Seismometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ShakeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Shake sensor is used to deduce the quality of the road, earthquakes."</para>
    /// labels<para>"Shake Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ShakeSensor">http://purl.org/iot/vocab/m3-lite#ShakeSensor</seealso>
    let ShakeSensor = Prefixed_Name(m3lite, "ShakeSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Shower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the shower."</para>
    /// labels<para>"Shower Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Shower">http://purl.org/iot/vocab/m3-lite#Shower</seealso>
    let Shower = Prefixed_Name(m3lite, "Shower") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SiemensPerMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Conductivity is measured in Siemens per metre (S/m)."</para>
    /// labels<para>"Siemens Per Metre, Siemens Per Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SiemensPerMetre">http://purl.org/iot/vocab/m3-lite#SiemensPerMetre</seealso>
    let SiemensPerMetre = Prefixed_Name(m3lite, "SiemensPerMetre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Sink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the sink."</para>
    /// labels<para>"Sink Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Sink">http://purl.org/iot/vocab/m3-lite#Sink</seealso>
    let Sink = Prefixed_Name(m3lite, "Sink") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Sirens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When source of the sound were sirens either from ambulence, police car or factory etc."</para>
    ///   <para>"When source of the sound were sirens either from ambulance, police car or factory etc."</para>
    /// labels<para>"Sirens Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Sirens">http://purl.org/iot/vocab/m3-lite#Sirens</seealso>
    let Sirens = Prefixed_Name(m3lite, "Sirens") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SkinConductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Electroderal activity (also known as skin conductance or galvanic skin response) directly correlates to the sympathetic nervous system activity and thus provides a powerful tool for monitoring arousal and certain aspects of autonomic regulation."</para>
    ///   <para>"Skin conductance (or GSR: Galvanic Skin Response)"</para>
    /// labels<para>"Skin conductance, GSR"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SkinConductance">http://purl.org/iot/vocab/m3-lite#SkinConductance</seealso>
    let SkinConductance = Prefixed_Name(m3lite, "SkinConductance") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SkinConductanceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Skin Conductance."</para>
    ///   <para>"Device used to detecte Skin Conductance."</para>
    /// labels<para>"Skin Conductance Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SkinConductanceSensor">http://purl.org/iot/vocab/m3-lite#SkinConductanceSensor</seealso>
    let SkinConductanceSensor =
        Prefixed_Name(m3lite, "SkinConductanceSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SmokeDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect if there is a fire or the smoke."</para>
    /// labels<para>"Smoke Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SmokeDetector">http://purl.org/iot/vocab/m3-lite#SmokeDetector</seealso>
    let SmokeDetector = Prefixed_Name(m3lite, "SmokeDetector") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SnowChains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actuator that turn Snow chains on/off."</para>
    /// labels<para>"Snow Chains Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SnowChains">http://purl.org/iot/vocab/m3-lite#SnowChains</seealso>
    let SnowChains = Prefixed_Name(m3lite, "SnowChains") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Sodium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of Blood Sodium level."</para>
    /// labels<para>"Sodium"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Sodium">http://purl.org/iot/vocab/m3-lite#Sodium</seealso>
    let Sodium = Prefixed_Name(m3lite, "Sodium") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SoilHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the quantity of water contained in a material, such as soil. "</para>
    /// labels<para>"Soil Humidity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoilHumidity">http://purl.org/iot/vocab/m3-lite#SoilHumidity</seealso>
    let SoilHumidity = Prefixed_Name(m3lite, "SoilHumidity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SoilHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soil Humidity sensor, Soil moisture, Hygrometer are an instrument used for measuring the soil moisture or soil humidity."</para>
    /// labels<para>"Soil Humidity Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoilHumiditySensor">http://purl.org/iot/vocab/m3-lite#SoilHumiditySensor</seealso>
    let SoilHumiditySensor = Prefixed_Name(m3lite, "SoilHumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SoilMoistureTension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The force per unit area required to remove film water from soil."</para>
    /// labels<para>"Soil Moisture Tension"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoilMoistureTension">http://purl.org/iot/vocab/m3-lite#SoilMoistureTension</seealso>
    let SoilMoistureTension =
        Prefixed_Name(m3lite, "SoilMoistureTension") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SoilTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Soil temperature is the bulk temperature of the soil, not the surface (skin) temperature."</para>
    /// labels<para>"Soil Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoilTemperature">http://purl.org/iot/vocab/m3-lite#SoilTemperature</seealso>
    let SoilTemperature = Prefixed_Name(m3lite, "SoilTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SoilThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This sensor reports Soil temperature."</para>
    /// labels<para>"Soil Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoilThermometer">http://purl.org/iot/vocab/m3-lite#SoilThermometer</seealso>
    let SoilThermometer = Prefixed_Name(m3lite, "SoilThermometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SolarRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the power per unit area received from the Sun in the form of electromagnetic radiation in the wavelength range of the measuring instrument. (Source Wikipedia)."</para>
    /// labels<para>"Solar Radiation Measurement, PAR Measurement (Photosynthetically Active Radiation)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SolarRadiation">http://purl.org/iot/vocab/m3-lite#SolarRadiation</seealso>
    let SolarRadiation = Prefixed_Name(m3lite, "SolarRadiation") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SolarRadiationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Solar Radiation."</para>
    /// labels<para>"Solar Radiation Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SolarRadiationSensor">http://purl.org/iot/vocab/m3-lite#SolarRadiationSensor</seealso>
    let SolarRadiationSensor =
        Prefixed_Name(m3lite, "SolarRadiationSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure of noise level in the environment"</para>
    /// labels<para>"Sound, Noise Level"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Sound">http://purl.org/iot/vocab/m3-lite#Sound</seealso>
    let Sound = Prefixed_Name(m3lite, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SoundPressureLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sound pressure level is a logarithmic measure of the RMS sound pressure of a sound relative to a reference value, the threshold of hearing. The reference sound pressure was chosen conventionally to correspond to the quietest sound at 1000 Hz that the human ear can detect (20 uPa). In this case, the specific parameter is measured in an open environment."</para>
    /// labels<para>"Sound Pressure Level"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoundPressureLevel">http://purl.org/iot/vocab/m3-lite#SoundPressureLevel</seealso>
    let SoundPressureLevel = Prefixed_Name(m3lite, "SoundPressureLevel") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SoundPressureLevelAmbient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Similar to Sound."</para>
    /// labels<para>"Sound Pressure Level Ambient"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoundPressureLevelAmbient">http://purl.org/iot/vocab/m3-lite#SoundPressureLevelAmbient</seealso>
    let SoundPressureLevelAmbient =
        Prefixed_Name(m3lite, "SoundPressureLevelAmbient") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SoundSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to detect Noise level. It can be Sound Sensor, Noise level Sensor, Volume sensor, Microphone"</para>
    /// labels<para>"Sound Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoundSensor">http://purl.org/iot/vocab/m3-lite#SoundSensor</seealso>
    let SoundSensor = Prefixed_Name(m3lite, "SoundSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SoundSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Source where the sound originated."</para>
    /// labels<para>"Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SoundSource">http://purl.org/iot/vocab/m3-lite#SoundSource</seealso>
    let SoundSource = Prefixed_Name(m3lite, "SoundSource") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Environmental Origin of a particular observation. With respect to one kind of Source (Sound source), it can be coming from traffic, siren of a police car, etc."</para>
    ///   <para>"Environmental Source."</para>
    /// labels<para>"Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Source">http://purl.org/iot/vocab/m3-lite#Source</seealso>
    let Source = Prefixed_Name(m3lite, "Source") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The rate at which someone or something moves or operates or is able to move or operate."</para>
    /// labels<para>"Speed"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Speed">http://purl.org/iot/vocab/m3-lite#Speed</seealso>
    let Speed = Prefixed_Name(m3lite, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SpeedAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A measure of the average rate of motion of an object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A measure of the average rate of motion of an object."</para>
    /// labels<para>"Speed Average"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SpeedAverage">http://purl.org/iot/vocab/m3-lite#SpeedAverage</seealso>
    let SpeedAverage = Prefixed_Name(m3lite, "SpeedAverage") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SpeedInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A measure of the instantaneous rate of motion of an object."</para>
    ///   <para>"A measure of the instantaneous rate of motion of an object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Speed Instantaneous"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SpeedInstantaneous">http://purl.org/iot/vocab/m3-lite#SpeedInstantaneous</seealso>
    let SpeedInstantaneous = Prefixed_Name(m3lite, "SpeedInstantaneous") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SpeedMedian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A measure of the median rate of motion of an object."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A measure of the median rate of motion of an object."</para>
    /// labels<para>"Speed Median"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SpeedMedian">http://purl.org/iot/vocab/m3-lite#SpeedMedian</seealso>
    let SpeedMedian = Prefixed_Name(m3lite, "SpeedMedian") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:SpeedSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to detect speed."</para>
    /// labels<para>"Speed Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SpeedSensor">http://purl.org/iot/vocab/m3-lite#SpeedSensor</seealso>
    let SpeedSensor = Prefixed_Name(m3lite, "SpeedSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a measure of number of Step taken."</para>
    /// labels<para>"Step"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Step">http://purl.org/iot/vocab/m3-lite#Step</seealso>
    let Step = Prefixed_Name(m3lite, "Step") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SunPositionDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The position of the Sun in the sky is a function of both time and the geographic coordinates of the observer on the surface of the Earth. (Source Wikipedia)."</para>
    /// labels<para>"Sun Position Direction"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SunPositionDirection">http://purl.org/iot/vocab/m3-lite#SunPositionDirection</seealso>
    let SunPositionDirection =
        Prefixed_Name(m3lite, "SunPositionDirection") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SunPositionDirectionSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to detect sun position."</para>
    /// labels<para>"Sun Position Direction Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SunPositionDirectionSensor">http://purl.org/iot/vocab/m3-lite#SunPositionDirectionSensor</seealso>
    let SunPositionDirectionSensor =
        Prefixed_Name(m3lite, "SunPositionDirectionSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SunPositionElevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the altitude of the sun, the angle between the horizon and the centre of the sun's disc."</para>
    /// labels<para>"Sun Position Elevation"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SunPositionElevation">http://purl.org/iot/vocab/m3-lite#SunPositionElevation</seealso>
    let SunPositionElevation =
        Prefixed_Name(m3lite, "SunPositionElevation") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SunPositionElevationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect sun elevation."</para>
    /// labels<para>"Sun Position Elevation Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SunPositionElevationSensor">http://purl.org/iot/vocab/m3-lite#SunPositionElevationSensor</seealso>
    let SunPositionElevationSensor =
        Prefixed_Name(m3lite, "SunPositionElevationSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:SystolicBloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the pressure when the heart beats while pumping blood."</para>
    /// labels<para>"Systolic Blood Pressure"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#SystolicBloodPressure">http://purl.org/iot/vocab/m3-lite#SystolicBloodPressure</seealso>
    let SystolicBloodPressure =
        Prefixed_Name(m3lite, "SystolicBloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:TV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the television."</para>
    /// labels<para>"TV Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TV">http://purl.org/iot/vocab/m3-lite#TV</seealso>
    let TV = Prefixed_Name(m3lite, "TV") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the Telephone."</para>
    /// labels<para>"Telephone Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Telephone">http://purl.org/iot/vocab/m3-lite#Telephone</seealso>
    let Telephone = Prefixed_Name(m3lite, "Telephone") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the air temperature."</para>
    /// labels<para>"Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Temperature">http://purl.org/iot/vocab/m3-lite#Temperature</seealso>
    let Temperature = Prefixed_Name(m3lite, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:TemperatureEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The temperature of a vehicle engine."</para>
    /// labels<para>"Temperature Engine"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TemperatureEngine">http://purl.org/iot/vocab/m3-lite#TemperatureEngine</seealso>
    let TemperatureEngine = Prefixed_Name(m3lite, "TemperatureEngine") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:TemperatureWasteContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The temperature of the air that would be indicated by a thermometer exposed to the air inside a waste container."</para>
    /// labels<para>"Temperature Waste Container"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TemperatureWasteContainer">http://purl.org/iot/vocab/m3-lite#TemperatureWasteContainer</seealso>
    let TemperatureWasteContainer =
        Prefixed_Name(m3lite, "TemperatureWasteContainer") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Tesla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the SI unit of magnetic flux density."</para>
    /// labels<para>"Tesla"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Tesla">http://purl.org/iot/vocab/m3-lite#Tesla</seealso>
    let Tesla = Prefixed_Name(m3lite, "Tesla") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Thermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device to measure the temperature in a room or outside."</para>
    /// labels<para>"Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Thermometer">http://purl.org/iot/vocab/m3-lite#Thermometer</seealso>
    let Thermometer = Prefixed_Name(m3lite, "Thermometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:ThrottleSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a device used to monitor the throttle position of a vehicle."</para>
    /// labels<para>"Throttle Position Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#ThrottleSensor">http://purl.org/iot/vocab/m3-lite#ThrottleSensor</seealso>
    let ThrottleSensor = Prefixed_Name(m3lite, "ThrottleSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:TimeRelatedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicator of whether a person (or object) has overpassed a particular time threshold (e.g. maximum number of hours driving, etc.)"</para>
    /// labels<para>"Time Related State"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TimeRelatedState">http://purl.org/iot/vocab/m3-lite#TimeRelatedState</seealso>
    let TimeRelatedState = Prefixed_Name(m3lite, "TimeRelatedState") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:TimeRelatedStateDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicator of whether the driver of a vehicle approaches or exceeds his/her working time limits."</para>
    /// labels<para>"Time Related State Driver"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver">http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver</seealso>
    let TimeRelatedStateDriver =
        Prefixed_Name(m3lite, "TimeRelatedStateDriver") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:TimeRelatedStateDriver1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates if the first driver approaches or exceeds working time limits (or other limits)."</para>
    /// labels<para>"Time Related State Driver 1"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver1">http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver1</seealso>
    let TimeRelatedStateDriver1 =
        Prefixed_Name(m3lite, "TimeRelatedStateDriver1") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:TimeRelatedStateDriver2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates if the second driver approaches or exceeds working time limits (or other limits)."</para>
    /// labels<para>"Time Related State Driver 2"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver2">http://purl.org/iot/vocab/m3-lite#TimeRelatedStateDriver2</seealso>
    let TimeRelatedStateDriver2 =
        Prefixed_Name(m3lite, "TimeRelatedStateDriver2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601."</para>
    /// labels<para>"Timestamp"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Timestamp">http://purl.org/iot/vocab/m3-lite#Timestamp</seealso>
    let Timestamp = Prefixed_Name(m3lite, "Timestamp") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Tonne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a non-SI metric unit of mass equal to 1,000 kilograms."</para>
    /// labels<para>"Tonne"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Tonne">http://purl.org/iot/vocab/m3-lite#Tonne</seealso>
    let Tonne = Prefixed_Name(m3lite, "Tonne") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:TouchSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that captures and records physical touch or embrace on a device and/or object."</para>
    /// labels<para>"Touch Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TouchSensor">http://purl.org/iot/vocab/m3-lite#TouchSensor</seealso>
    let TouchSensor = Prefixed_Name(m3lite, "TouchSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Tourism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Tourism as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Tourism DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Tourism">http://purl.org/iot/vocab/m3-lite#Tourism</seealso>
    let Tourism = Prefixed_Name(m3lite, "Tourism") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Traffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"When the source of the sound was traffic."</para>
    /// labels<para>"Traffic"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Traffic">http://purl.org/iot/vocab/m3-lite#Traffic</seealso>
    let Traffic = Prefixed_Name(m3lite, "Traffic") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:TrafficIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The intensity of a traffic flow is the number of vehicles passing a cross section of a road in a unit of time."</para>
    /// labels<para>"Traffic Intensity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#TrafficIntensity">http://purl.org/iot/vocab/m3-lite#TrafficIntensity</seealso>
    let TrafficIntensity = Prefixed_Name(m3lite, "TrafficIntensity") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Transportation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Transportation, Smart Car/Vehicle, Intelligent Transport System (ITS) as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Transportation DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Transportation">http://purl.org/iot/vocab/m3-lite#Transportation</seealso>
    let Transportation = Prefixed_Name(m3lite, "Transportation") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:UltrasonicSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Ultrasonic sensors are used to deduce human posture in smart home for example."</para>
    /// labels<para>"Ultrasonic Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#UltrasonicSensor">http://purl.org/iot/vocab/m3-lite#UltrasonicSensor</seealso>
    let UltrasonicSensor = Prefixed_Name(m3lite, "UltrasonicSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:VOCSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that detects levels of Volatile Organic Components (VOC) in the environment."</para>
    /// labels<para>"Volatile Organic Compound (VOC) Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VOCSensor">http://purl.org/iot/vocab/m3-lite#VOCSensor</seealso>
    let VOCSensor = Prefixed_Name(m3lite, "VOCSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:VehicleCountSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to count the number of vehicles (e.g., used within the Citypulse project)."</para>
    /// labels<para>"Vehicle Count Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VehicleCountSensor">http://purl.org/iot/vocab/m3-lite#VehicleCountSensor</seealso>
    let VehicleCountSensor = Prefixed_Name(m3lite, "VehicleCountSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:VehicleOverspeedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure to indicates whether the vehicle is exceeding the legal speed limit."</para>
    /// labels<para>"Vehicle Overspeed State"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VehicleOverspeedState">http://purl.org/iot/vocab/m3-lite#VehicleOverspeedState</seealso>
    let VehicleOverspeedState =
        Prefixed_Name(m3lite, "VehicleOverspeedState") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:VehiclePresenceDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect if an vehicle is present at a place."</para>
    /// labels<para>" Vehicle Presence Detector"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VehiclePresenceDetector">http://purl.org/iot/vocab/m3-lite#VehiclePresenceDetector</seealso>
    let VehiclePresenceDetector =
        Prefixed_Name(m3lite, "VehiclePresenceDetector") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:VehiclesPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of vehicles that traverse a concrete region of the space in one minute."</para>
    /// labels<para>"Vehicles Per Minute"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VehiclesPerMinute">http://purl.org/iot/vocab/m3-lite#VehiclesPerMinute</seealso>
    let VehiclesPerMinute = Prefixed_Name(m3lite, "VehiclesPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Ventilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the ventilation."</para>
    /// labels<para>"Ventilation Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Ventilation">http://purl.org/iot/vocab/m3-lite#Ventilation</seealso>
    let Ventilation = Prefixed_Name(m3lite, "Ventilation") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The state of being able to see or be seen."</para>
    /// labels<para>"Visibility"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Visibility">http://purl.org/iot/vocab/m3-lite#Visibility</seealso>
    let Visibility = Prefixed_Name(m3lite, "Visibility") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:VisibilitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Visibility."</para>
    /// labels<para>"Visibility Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VisibilitySensor">http://purl.org/iot/vocab/m3-lite#VisibilitySensor</seealso>
    let VisibilitySensor = Prefixed_Name(m3lite, "VisibilitySensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:VoiceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A voice command to control a voice controlled system or environment, such as a smart home."</para>
    /// labels<para>"Voice Command"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VoiceCommand">http://purl.org/iot/vocab/m3-lite#VoiceCommand</seealso>
    let VoiceCommand = Prefixed_Name(m3lite, "VoiceCommand") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:VoiceCommandController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuating device called  that allows to semi-control the environment of the Voice Command Sensor."</para>
    /// labels<para>"Voice Command Controller"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VoiceCommandController">http://purl.org/iot/vocab/m3-lite#VoiceCommandController</seealso>
    let VoiceCommandController =
        Prefixed_Name(m3lite, "VoiceCommandController") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:VoiceCommandSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor that uses automatic speech recognition technology to match or reject a recorded voice command according to a specified set of available voice commands."</para>
    /// labels<para>"Voice Command Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VoiceCommandSensor">http://purl.org/iot/vocab/m3-lite#VoiceCommandSensor</seealso>
    let VoiceCommandSensor = Prefixed_Name(m3lite, "VoiceCommandSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Volt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The SI unit of electromotive force, the difference of potential that would carry one ampere of current against one ohm resistance."</para>
    /// labels<para>"Volt"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Volt">http://purl.org/iot/vocab/m3-lite#Volt</seealso>
    let Volt = Prefixed_Name(m3lite, "Volt") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:VoltAmpereReactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system."</para>
    /// labels<para>"Volt Ampere Reactive, VAR"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VoltAmpereReactive">http://purl.org/iot/vocab/m3-lite#VoltAmpereReactive</seealso>
    let VoltAmpereReactive = Prefixed_Name(m3lite, "VoltAmpereReactive") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An electromotive force or potential difference expressed in volts (Source Google)."</para>
    /// labels<para>"Voltage"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Voltage">http://purl.org/iot/vocab/m3-lite#Voltage</seealso>
    let Voltage = Prefixed_Name(m3lite, "Voltage") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:VoltageSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device which can measure the difference in electric potential energy between two points per unit electric charge."</para>
    ///   <para>"A device designed to respond to physical stimuli such as temperature, light, magnetism, or movement, and to transmit resulting impulses for interpretation."</para>
    /// labels<para>"Voltage Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#VoltageSensor">http://purl.org/iot/vocab/m3-lite#VoltageSensor</seealso>
    let VoltageSensor = Prefixed_Name(m3lite, "VoltageSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WashingMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically switch on/off the washing machine."</para>
    /// labels<para>"Washing Machine Actuation Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WashingMachine">http://purl.org/iot/vocab/m3-lite#WashingMachine</seealso>
    let WashingMachine = Prefixed_Name(m3lite, "WashingMachine") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WaterConductivitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to measure the conductivity of water."</para>
    /// labels<para>"Water Conductivity Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterConductivitySensor">http://purl.org/iot/vocab/m3-lite#WaterConductivitySensor</seealso>
    let WaterConductivitySensor =
        Prefixed_Name(m3lite, "WaterConductivitySensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WaterLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The height reached by the water in a reservoir, river, storage tank, or similar."</para>
    /// labels<para>"Water Level"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterLevel">http://purl.org/iot/vocab/m3-lite#WaterLevel</seealso>
    let WaterLevel = Prefixed_Name(m3lite, "WaterLevel") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WaterNH4IonSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to measure NH4 concentration level in the water."</para>
    /// labels<para>"Water NH4 Ion Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterNH4IonSensor">http://purl.org/iot/vocab/m3-lite#WaterNH4IonSensor</seealso>
    let WaterNH4IonSensor = Prefixed_Name(m3lite, "WaterNH4IonSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WaterNO3IonSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to measure NO3 concentration level in the water."</para>
    /// labels<para>"Water NO3 Ion Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterNO3IonSensor">http://purl.org/iot/vocab/m3-lite#WaterNO3IonSensor</seealso>
    let WaterNO3IonSensor = Prefixed_Name(m3lite, "WaterNO3IonSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WaterO2IonSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor used to measure O2 concentration level in the water."</para>
    /// labels<para>"Water O2 Ion Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterO2IonSensor">http://purl.org/iot/vocab/m3-lite#WaterO2IonSensor</seealso>
    let WaterO2IonSensor = Prefixed_Name(m3lite, "WaterO2IonSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WaterPHSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect PH level of water."</para>
    /// labels<para>"Water PH Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterPHSensor">http://purl.org/iot/vocab/m3-lite#WaterPHSensor</seealso>
    let WaterPHSensor = Prefixed_Name(m3lite, "WaterPHSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WaterTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sea surface temperature (SST) is the water temperature close to the ocean's surface."</para>
    /// labels<para>"Water Temperature"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterTemperature">http://purl.org/iot/vocab/m3-lite#WaterTemperature</seealso>
    let WaterTemperature = Prefixed_Name(m3lite, "WaterTemperature") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WaterThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This sensor reports Water temperature."</para>
    /// labels<para>"Water Thermometer"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WaterThermometer">http://purl.org/iot/vocab/m3-lite#WaterThermometer</seealso>
    let WaterThermometer = Prefixed_Name(m3lite, "WaterThermometer") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Watt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the SI unit of power, equivalent to one joule per second, corresponding to the rate of consumption of energy in an electric circuit where the potential difference is one volt and the current one ampere."</para>
    /// labels<para>"Watt (W)"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Watt">http://purl.org/iot/vocab/m3-lite#Watt</seealso>
    let Watt = Prefixed_Name(m3lite, "Watt") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WattPerSquareMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the SI unit for radiative and other energy fluxes."</para>
    /// labels<para>"Watt Per Square Metre, Watt Per Square Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WattPerSquareMeter">http://purl.org/iot/vocab/m3-lite#WattPerSquareMeter</seealso>
    let WattPerSquareMeter = Prefixed_Name(m3lite, "WattPerSquareMeter") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WattPerSquareMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the SI unit for radiative and other energy fluxes."</para>
    /// labels<para>"Watt Per Square Metre, Watt Per Square Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WattPerSquareMetre">http://purl.org/iot/vocab/m3-lite#WattPerSquareMetre</seealso>
    let WattPerSquareMetre = Prefixed_Name(m3lite, "WattPerSquareMetre") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Weather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Weather Forecasting, Meterology as an Internet of Things (IoT) applicative domain."</para>
    /// labels<para>"Weather Forecasting DOI"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Weather">http://purl.org/iot/vocab/m3-lite#Weather</seealso>
    let Weather = Prefixed_Name(m3lite, "Weather") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WeatherLuminosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Luminosity."</para>
    /// labels<para>"Weather Luminosity"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WeatherLuminosity">http://purl.org/iot/vocab/m3-lite#WeatherLuminosity</seealso>
    let WeatherLuminosity = Prefixed_Name(m3lite, "WeatherLuminosity") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WeatherPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Weather Precipitation."</para>
    /// labels<para>"Weather Precipitation"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WeatherPrecipitation">http://purl.org/iot/vocab/m3-lite#WeatherPrecipitation</seealso>
    let WeatherPrecipitation =
        Prefixed_Name(m3lite, "WeatherPrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A body's relative mass or the quantity of matter contained by it, giving rise to a downward force; the heaviness of a person or thing."</para>
    /// labels<para>"Weight"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Weight">http://purl.org/iot/vocab/m3-lite#Weight</seealso>
    let Weight = Prefixed_Name(m3lite, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WeightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to weight an object."</para>
    /// labels<para>"Weight Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WeightSensor">http://purl.org/iot/vocab/m3-lite#WeightSensor</seealso>
    let WeightSensor = Prefixed_Name(m3lite, "WeightSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WiFiInterfaceEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Measure the average power consumption of the WiFi interface nodes."</para>
    /// labels<para>"WiFi Interface Energy Meter"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WiFiInterfaceEnergyMeter">http://purl.org/iot/vocab/m3-lite#WiFiInterfaceEnergyMeter</seealso>
    let WiFiInterfaceEnergyMeter =
        Prefixed_Name(m3lite, "WiFiInterfaceEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WindChill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The cooling effect of wind blowing on a surface."</para>
    /// labels<para>"Wind Chill"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WindChill">http://purl.org/iot/vocab/m3-lite#WindChill</seealso>
    let WindChill = Prefixed_Name(m3lite, "WindChill") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WindChillSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect Wind Chill."</para>
    /// labels<para>"Wind Chill Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WindChillSensor">http://purl.org/iot/vocab/m3-lite#WindChillSensor</seealso>
    let WindChillSensor = Prefixed_Name(m3lite, "WindChillSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WindDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The geodetic azimuth of the direction from which the wind is blowing."</para>
    /// labels<para>"Wind Direction"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WindDirection">http://purl.org/iot/vocab/m3-lite#WindDirection</seealso>
    let WindDirection = Prefixed_Name(m3lite, "WindDirection") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WindDirectionSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device used to detect wind direction."</para>
    /// labels<para>"Wind Direction Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WindDirectionSensor">http://purl.org/iot/vocab/m3-lite#WindDirectionSensor</seealso>
    let WindDirectionSensor =
        Prefixed_Name(m3lite, "WindDirectionSensor") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WindSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ratio of the distance covered by moving air to the time quantity taken to cover it."</para>
    /// labels<para>"Wind Velocity, Wind Speed"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WindSpeed">http://purl.org/iot/vocab/m3-lite#WindSpeed</seealso>
    let WindSpeed = Prefixed_Name(m3lite, "WindSpeed") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WindSpeedSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Wind Speed Sensor, Anemometer or Wind Velocity Sensor is used to measure the wind speed."</para>
    /// labels<para>"Wind Speed Sensor"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WindSpeedSensor">http://purl.org/iot/vocab/m3-lite#WindSpeedSensor</seealso>
    let WindSpeedSensor = Prefixed_Name(m3lite, "WindSpeedSensor") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Window</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An actuator to automatically open/close the window."</para>
    /// labels<para>"Window Actuating Device"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Window">http://purl.org/iot/vocab/m3-lite#Window</seealso>
    let Window = Prefixed_Name(m3lite, "Window") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WorkingState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicator of whether a person (or object) is working or not"</para>
    /// labels<para>"Working State"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WorkingState">http://purl.org/iot/vocab/m3-lite#WorkingState</seealso>
    let WorkingState = Prefixed_Name(m3lite, "WorkingState") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:WorkingStateDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicator of whether the driver of a vehicle is present or not"</para>
    /// labels<para>"Working State Driver"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WorkingStateDriver">http://purl.org/iot/vocab/m3-lite#WorkingStateDriver</seealso>
    let WorkingStateDriver = Prefixed_Name(m3lite, "WorkingStateDriver") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WorkingStateDriver1</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State of work of the first driver as defined in the FMS standard."</para>
    ///   <para>"State of work of the first driver as defined in the FMS standard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Working State Driver 1"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WorkingStateDriver1">http://purl.org/iot/vocab/m3-lite#WorkingStateDriver1</seealso>
    let WorkingStateDriver1 =
        Prefixed_Name(m3lite, "WorkingStateDriver1") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:WorkingStateDriver2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State of work of the second driver as defined in the FMS standard."</para>
    ///   <para>"State of work of the second driver as defined in the FMS standard."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Working State Driver 2"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#WorkingStateDriver2">http://purl.org/iot/vocab/m3-lite#WorkingStateDriver2</seealso>
    let WorkingStateDriver2 =
        Prefixed_Name(m3lite, "WorkingStateDriver2") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:Wout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This unit is used to measure delta dew point within the Com4Innov tesbed. Natural number (W/out unit)."</para>
    /// labels<para>"W/out"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Wout">http://purl.org/iot/vocab/m3-lite#Wout</seealso>
    let Wout = Prefixed_Name(m3lite, "Wout") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Year as a unit of time."</para>
    /// labels<para>"Year"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#Year">http://purl.org/iot/vocab/m3-lite#Year</seealso>
    let Year = Prefixed_Name(m3lite, "Year") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:chemicalAgentAtmosphericConcentrationO3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The concentration of ozone (O3) gas suspended in the atmosphere."</para>
    /// labels<para>"Chemical Agent Atmospheric Concentration O3"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#chemicalAgentAtmosphericConcentrationO3">http://purl.org/iot/vocab/m3-lite#chemicalAgentAtmosphericConcentrationO3</seealso>
    let chemicalAgentAtmosphericConcentrationO3 =
        Prefixed_Name(m3lite, "chemicalAgentAtmosphericConcentrationO3") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:hasDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The observations made by the sensors are affected by the direction of the sensing device. This property allows observations of the sensor to be associated to the Direction concept."</para>
    ///   <para>"The observations made by the sensors are affected by the direction of the sensing device. This property allows observations of the sensor to be associated to the Direction concept"</para>
    /// labels<para>"Has Direction"</para><para>"has Direction"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#hasDirection">http://purl.org/iot/vocab/m3-lite#hasDirection</seealso>
    let hasDirection = Prefixed_Name(m3lite, "hasDirection") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:hasDomainOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to classify devices by DomainOfInterest (e.g., blood pressure sensor is used in healthcare)."</para>
    ///   <para>"This property is used to classify devices by DomainOfInterest (e.g., blood pressure sensor is used in healthcare)"</para>
    /// labels<para>"has Domain Of Interest"</para><para>"Has Domain Of Interest"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#hasDomainOfInterest">http://purl.org/iot/vocab/m3-lite#hasDomainOfInterest</seealso>
    let hasDomainOfInterest =
        Prefixed_Name(m3lite, "hasDomainOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:hasMeasurementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Each sensing device can have a different sensing mechanism which may result in different kinds of sensor data. This property links observation of the sensor to the associated MeasurementType."</para>
    /// labels<para>"Has Measurement Type"</para><para>"has Measurement Type"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#hasMeasurementType">http://purl.org/iot/vocab/m3-lite#hasMeasurementType</seealso>
    let hasMeasurementType = Prefixed_Name(m3lite, "hasMeasurementType") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:hasSoundSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links sound to its environmental source."</para>
    /// labels<para>"has Sound Source"</para><para>"Has Sound Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#hasSoundSource">http://purl.org/iot/vocab/m3-lite#hasSoundSource</seealso>
    let hasSoundSource = Prefixed_Name(m3lite, "hasSoundSource") |> PrefixedName
    /// <summary>
    ///   <para>m3lite:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property links sensed phenomena to its environmental source."</para>
    /// labels<para>"Has Source"</para><para>"has Source"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#hasSource">http://purl.org/iot/vocab/m3-lite#hasSource</seealso>
    let hasSource = Prefixed_Name(m3lite, "hasSource") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:intDlThroughputKbps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Downlink Throughput."</para>
    /// labels<para>"Downlink Throughput"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#intDlThroughputKbps">http://purl.org/iot/vocab/m3-lite#intDlThroughputKbps</seealso>
    let intDlThroughputKbps =
        Prefixed_Name(m3lite, "intDlThroughputKbps") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:intUlPacketLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uplink Packet Loss."</para>
    /// labels<para>"Uplink Packet Loss"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#intUlPacketLoss">http://purl.org/iot/vocab/m3-lite#intUlPacketLoss</seealso>
    let intUlPacketLoss = Prefixed_Name(m3lite, "intUlPacketLoss") |> PrefixedName

    /// <summary>
    ///   <para>m3lite:intUlThroughputKbps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Uplink Throughput."</para>
    /// labels<para>"Uplink Throughput"</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/m3-lite#intUlThroughputKbps">http://purl.org/iot/vocab/m3-lite#intUlThroughputKbps</seealso>
    let intUlThroughputKbps =
        Prefixed_Name(m3lite, "intUlThroughputKbps") |> PrefixedName
