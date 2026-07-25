namespace http.purl.org.iot.vocab.iot_taxonomy_lite.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module iottaxolite =
    let _namespace_iri = Namespace_Iri iottaxolite |> NamespaceIRI

    /// <summary>
    ///   <para>iottaxolite:AtmosphericPressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Atmospheric Pressure Sensor, Barometer or Barometric Pressure Sensor is a scientific instrument used in meteorology to measure atmospheric pressure.</para>
    /// labels<para>Atmospheric Pressure Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressureSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressureSensor</seealso>
    let AtmosphericPressureSensor =
        Prefixed_Name(iottaxolite, "AtmosphericPressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:QualityOfObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It identifies the quality of observation taken by a sensor or an actuator</para>
    /// labels<para>Quality Of Observation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#QualityOfObservation">http://purl.org/iot/vocab/iot-taxonomy-lite#QualityOfObservation</seealso>
    let QualityOfObservation =
        Prefixed_Name(iottaxolite, "QualityOfObservation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Bar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Metric unit of atmospheric pressure equal to 14.50 pounds per square inch (lb/in2), 1.02 kilograms per square centimetre (kg/cm2), 29.53 inches of mercury (in Hg), or 0.9869 atmosphere.</para>
    /// labels<para>Bar</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bar">http://purl.org/iot/vocab/iot-taxonomy-lite#Bar</seealso>
    let Bar = Prefixed_Name(iottaxolite, "Bar") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Blind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the window blinds.</para>
    /// labels<para>Blind Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Blind">http://purl.org/iot/vocab/iot-taxonomy-lite#Blind</seealso>
    let Blind = Prefixed_Name(iottaxolite, "Blind") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Cholesterol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the cholesterol level in a system.</para>
    /// labels<para>Cholesterol Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cholesterol">http://purl.org/iot/vocab/iot-taxonomy-lite#Cholesterol</seealso>
    let Cholesterol = Prefixed_Name(iottaxolite, "Cholesterol") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:City</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Smart City as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Smart City DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#City">http://purl.org/iot/vocab/iot-taxonomy-lite#City</seealso>
    let City = Prefixed_Name(iottaxolite, "City") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:CloudCover</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of cloud cover at a certain time. </para>
    /// labels<para>Cloud Cover Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCover">http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCover</seealso>
    let CloudCover = Prefixed_Name(iottaxolite, "CloudCover") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CloudCoverSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cloud Cover Sensor is used to detect whether it is sunny, cloudy, etc.</para>
    /// labels<para>Cloud Cover Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCoverSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#CloudCoverSensor</seealso>
    let CloudCoverSensor =
        Prefixed_Name(iottaxolite, "CloudCoverSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Coagulometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Coagulometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coagulometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Coagulometer</seealso>
    let Coagulometer = Prefixed_Name(iottaxolite, "Coagulometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Actuating devices for Computer or PC.</para>
    /// labels<para>Computer, PC Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Computer">http://purl.org/iot/vocab/iot-taxonomy-lite#Computer</seealso>
    let Computer = Prefixed_Name(iottaxolite, "Computer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ConductivitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure the conductivity of a system.</para>
    /// labels<para>Conductivity Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConductivitySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ConductivitySensor</seealso>
    let ConductivitySensor =
        Prefixed_Name(iottaxolite, "ConductivitySensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Coordinates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Triples for location in the (Latitude, Longitude, Altitude) format.</para>
    /// labels<para>Coordinates</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coordinates">http://purl.org/iot/vocab/iot-taxonomy-lite#Coordinates</seealso>
    let Coordinates = Prefixed_Name(iottaxolite, "Coordinates") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of available particular things.</para>
    /// labels<para>Count</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Count">http://purl.org/iot/vocab/iot-taxonomy-lite#Count</seealso>
    let Count = Prefixed_Name(iottaxolite, "Count") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountAvailableTaxis</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of taxis available at a particular taxi stop.</para>
    /// labels<para>Count Available Taxis</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableTaxis">http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableTaxis</seealso>
    let CountAvailableTaxis =
        Prefixed_Name(iottaxolite, "CountAvailableTaxis") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountPeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of people within a particular area</para>
    /// labels<para>Count People</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeople">http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeople</seealso>
    let CountPeople = Prefixed_Name(iottaxolite, "CountPeople") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountPeopleMoving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of people that moved outside an area towards another area during a time window.</para>
    /// labels<para>Count People Moving</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleMoving">http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleMoving</seealso>
    let CountPeopleMoving =
        Prefixed_Name(iottaxolite, "CountPeopleMoving") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Source</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Environmental Origin of a particular observation. With respect to one kind of Source (Sound source), it can be coming from traffic, siren of a police car, etc.</para>
    /// labels<para>Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Source">http://purl.org/iot/vocab/iot-taxonomy-lite#Source</seealso>
    let Source = Prefixed_Name(iottaxolite, "Source") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:OxidationReductionPotentialSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measures the Water Oxidation Reduction Potential (ORP) as the tendency of a chemical species to acquire electrons and thereby be reduced.</para>
    /// labels<para>Oxidation Reduction Potential (ORP) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxidationReductionPotentialSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#OxidationReductionPotentialSensor</seealso>
    let OxidationReductionPotentialSensor =
        Prefixed_Name(iottaxolite, "OxidationReductionPotentialSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:OxygenSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Oxygen (O2) in the environment.</para>
    /// labels<para>Oxygen Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#OxygenSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#OxygenSensor</seealso>
    let OxygenSensor = Prefixed_Name(iottaxolite, "OxygenSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:PHSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect PH level.</para>
    /// labels<para>PH Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PHSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#PHSensor</seealso>
    let PHSensor = Prefixed_Name(iottaxolite, "PHSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:PPM</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It describes the concentration of something in water or soil.</para>
    /// labels<para>PPM (parts per million)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PPM">http://purl.org/iot/vocab/iot-taxonomy-lite#PPM</seealso>
    let PPM = Prefixed_Name(iottaxolite, "PPM") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:PartsPerBillion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It describes the concentration of something in parts per billion parts of water or soil, expressed in any (but common) unit of measurement.</para>
    /// labels<para>Parts Per Billion</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PartsPerBillion">http://purl.org/iot/vocab/iot-taxonomy-lite#PartsPerBillion</seealso>
    let PartsPerBillion = Prefixed_Name(iottaxolite, "PartsPerBillion") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Pedometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pedometer is used to count the number of steps when walking, running, etc.</para>
    /// labels<para>Pedometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pedometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Pedometer</seealso>
    let Pedometer = Prefixed_Name(iottaxolite, "Pedometer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PeopleCountSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to count the number of people (eg., used within an indoor area).</para>
    /// labels<para>People Count Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleCountSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleCountSensor</seealso>
    let PeopleCountSensor =
        Prefixed_Name(iottaxolite, "PeopleCountSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PeopleFlowCountSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to count the number of people the moves from an area towards another area during a time window.</para>
    /// labels<para>People Flow Count Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleFlowCountSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleFlowCountSensor</seealso>
    let PeopleFlowCountSensor =
        Prefixed_Name(iottaxolite, "PeopleFlowCountSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PeopleStayDurationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure the time people stays within an area.</para>
    /// labels<para>People Stay Duration Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationSensor</seealso>
    let PeopleStayDurationSensor =
        Prefixed_Name(iottaxolite, "PeopleStayDurationSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Percent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the amount in or for every hundred.</para>
    /// labels<para>Percent</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Percent">http://purl.org/iot/vocab/iot-taxonomy-lite#Percent</seealso>
    let Percent = Prefixed_Name(iottaxolite, "Percent") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Potassium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the measure of Blood Potassium Level.</para>
    /// labels<para>Potassium</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Potassium">http://purl.org/iot/vocab/iot-taxonomy-lite#Potassium</seealso>
    let Potassium = Prefixed_Name(iottaxolite, "Potassium") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Pound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit of weight equal to 16 oz. 1 pound= 453.592 grams</para>
    /// labels<para>Pound</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pound">http://purl.org/iot/vocab/iot-taxonomy-lite#Pound</seealso>
    let Pound = Prefixed_Name(iottaxolite, "Pound") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PrecipitationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a device measuring the amount of precipitation.</para>
    /// labels<para>Precipitation Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PrecipitationSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#PrecipitationSensor</seealso>
    let PrecipitationSensor =
        Prefixed_Name(iottaxolite, "PrecipitationSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Presence</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure to know if an object is present. It is usually boolean.</para>
    /// labels<para>Presence</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Presence">http://purl.org/iot/vocab/iot-taxonomy-lite#Presence</seealso>
    let Presence = Prefixed_Name(iottaxolite, "Presence") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceStateDriverCardOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the presence of the first driver card.</para>
    /// labels<para>Presence State Driver Card 1</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardOne">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardOne</seealso>
    let PresenceStateDriverCardOne =
        Prefixed_Name(iottaxolite, "PresenceStateDriverCardOne") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceStateDriverCardTwo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the presence of the second driver card.</para>
    /// labels<para>Presence State Driver Card 2</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardTwo">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCardTwo</seealso>
    let PresenceStateDriverCardTwo =
        Prefixed_Name(iottaxolite, "PresenceStateDriverCardTwo") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceStateEmergencyVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The presence or absence of an emergency vehicle (ambulance, fire fighters, etc.).</para>
    /// labels<para>Presence State Emergency Vehicle</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateEmergencyVehicle">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateEmergencyVehicle</seealso>
    let PresenceStateEmergencyVehicle =
        Prefixed_Name(iottaxolite, "PresenceStateEmergencyVehicle") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceStatePeople</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The presence or absence of people passing.</para>
    /// labels<para>Presence State People</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStatePeople">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStatePeople</seealso>
    let PresenceStatePeople =
        Prefixed_Name(iottaxolite, "PresenceStatePeople") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device used to detect pressure. For example, it can be attached on the bed to infer if the user is lying, sleeping, sitting, bed occupancy, etc.</para>
    /// labels<para>Pressure Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PressureSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#PressureSensor</seealso>
    let PressureSensor = Prefixed_Name(iottaxolite, "PressureSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Proximity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure to detect proximity.</para>
    /// labels<para>Proximity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Proximity">http://purl.org/iot/vocab/iot-taxonomy-lite#Proximity</seealso>
    let Proximity = Prefixed_Name(iottaxolite, "Proximity") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ProximitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Detect if something is within proximity of a sensor.</para>
    /// labels<para>Proximity Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ProximitySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ProximitySensor</seealso>
    let ProximitySensor = Prefixed_Name(iottaxolite, "ProximitySensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:QRCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tagging device can be QRCode.</para>
    /// labels<para>QR Code tagging Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#QRCode">http://purl.org/iot/vocab/iot-taxonomy-lite#QRCode</seealso>
    let QRCode = Prefixed_Name(iottaxolite, "QRCode") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:RFID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tagging device can be RFID.</para>
    /// labels<para>RFID Tagging Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RFID">http://purl.org/iot/vocab/iot-taxonomy-lite#RFID</seealso>
    let RFID = Prefixed_Name(iottaxolite, "RFID") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:RSSI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Received Signal Strength Indicator is the signal strength in a wireless network environment.</para>
    /// labels<para>Received Signal Strength Indicator</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RSSI">http://purl.org/iot/vocab/iot-taxonomy-lite#RSSI</seealso>
    let RSSI = Prefixed_Name(iottaxolite, "RSSI") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Radian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The radian is a unit of angular measure defined such that an angle of one radian subtended from the centre of a unit circle produces an arc with arc length 1.</para>
    /// labels<para>Radian</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Radian">http://purl.org/iot/vocab/iot-taxonomy-lite#Radian</seealso>
    let Radian = Prefixed_Name(iottaxolite, "Radian") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RadiationParticleDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A particle detector, also known as a radiation detector or Geiger counter, is a device used to detect, track, and/or identify ionising particles, such as those produced by nuclear decay, cosmic radiation, or reactions in a particle accelerator.</para>
    /// labels<para>Radiation Particle Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticleDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticleDetector</seealso>
    let RadiationParticleDetector =
        Prefixed_Name(iottaxolite, "RadiationParticleDetector") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RadiationParticlesPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The number of ionizing events detected in one minute.</para>
    /// labels<para>Radiation Particles Per Minute</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticlesPerMinute">http://purl.org/iot/vocab/iot-taxonomy-lite#RadiationParticlesPerMinute</seealso>
    let RadiationParticlesPerMinute =
        Prefixed_Name(iottaxolite, "RadiationParticlesPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Rainfall</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The depth of precipitation (water-equivalent) that accumulated over a measurement time quantity.</para>
    /// labels<para>Rainfall</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Rainfall">http://purl.org/iot/vocab/iot-taxonomy-lite#Rainfall</seealso>
    let Rainfall = Prefixed_Name(iottaxolite, "Rainfall") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ReactivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The portion of electricity that establishes and sustains the electric and magnetic fields of alternating-current equipment.</para>
    /// labels<para>Reactive Power</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ReactivePower">http://purl.org/iot/vocab/iot-taxonomy-lite#ReactivePower</seealso>
    let ReactivePower = Prefixed_Name(iottaxolite, "ReactivePower") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RecognizedActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Activity Recognized. This is usually made available as a part of analysis done by Google. The available activities recognized are IN_VEHICLE, ON_BICYCLE, ON_FOOT, RUNNING, STILL, TILTING, UNKNOWN, and WALKING.</para>
    /// labels<para>Recognized Activity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RecognizedActivity">http://purl.org/iot/vocab/iot-taxonomy-lite#RecognizedActivity</seealso>
    let RecognizedActivity =
        Prefixed_Name(iottaxolite, "RecognizedActivity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RetERabDrop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ERAB Drop.</para>
    /// labels<para>ERAB Drop</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RetERabDrop">http://purl.org/iot/vocab/iot-taxonomy-lite#RetERabDrop</seealso>
    let RetERabDrop = Prefixed_Name(iottaxolite, "RetERabDrop") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RevolutionsPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Revolutions per minute (abbreviated rpm, RPM, rev/min, r/min) is a measure of the frequency of rotation, specifically the number of rotations around a fixed axis in one minute. It is used as a measure of rotational speed of a mechanical component.</para>
    /// labels<para>Revolutions Per Minute</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RevolutionsPerMinute">http://purl.org/iot/vocab/iot-taxonomy-lite#RevolutionsPerMinute</seealso>
    let RevolutionsPerMinute =
        Prefixed_Name(iottaxolite, "RevolutionsPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RoadOccupancy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ratio of time on which a road lane section is occupied by vehicles within a given period of time.</para>
    /// labels<para>Road Occupancy</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadOccupancy">http://purl.org/iot/vocab/iot-taxonomy-lite#RoadOccupancy</seealso>
    let RoadOccupancy = Prefixed_Name(iottaxolite, "RoadOccupancy") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RoadSurfaceThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure the road Surface temperature.</para>
    /// labels<para>Road Surface Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadSurfaceThermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#RoadSurfaceThermometer</seealso>
    let RoadSurfaceThermometer =
        Prefixed_Name(iottaxolite, "RoadSurfaceThermometer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RoadTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temperature of the road.</para>
    /// labels<para>Road Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoadTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#RoadTemperature</seealso>
    let RoadTemperature = Prefixed_Name(iottaxolite, "RoadTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RotationalSpeedEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rotational speed is a property that is the rate of rotation of a material around an axis, in this case the engine cylinders.</para>
    /// labels<para>Rotational Speed Engine</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeedEngine">http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeedEngine</seealso>
    let RotationalSpeedEngine =
        Prefixed_Name(iottaxolite, "RotationalSpeedEngine") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SNR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Compares the level of a desired signal to the level of noise. </para>
    /// labels<para>Signal to Noise Ratio</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SNR">http://purl.org/iot/vocab/iot-taxonomy-lite#SNR</seealso>
    let SNR = Prefixed_Name(iottaxolite, "SNR") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SO2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device use to detect Sulphur Dioxide (SO2) level in the environment.</para>
    /// labels<para>Sulphur Dioxide (SO2) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SO2Sensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SO2Sensor</seealso>
    let SO2Sensor = Prefixed_Name(iottaxolite, "SO2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SPO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a measure of the amount of oxygenated haemoglobin in the blood.</para>
    /// labels<para>SPO2</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SPO2">http://purl.org/iot/vocab/iot-taxonomy-lite#SPO2</seealso>
    let SPO2 = Prefixed_Name(iottaxolite, "SPO2") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Salinity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the measure of all the salts dissolved in water.</para>
    /// labels<para>Salinity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Salinity">http://purl.org/iot/vocab/iot-taxonomy-lite#Salinity</seealso>
    let Salinity = Prefixed_Name(iottaxolite, "Salinity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AccRrcConnSetupSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Radio Resource Control connection setup success rate.</para>
    /// labels<para>RRC Connection Setup Success Rate</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccRrcConnSetupSuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#AccRrcConnSetupSuccRate</seealso>
    let AccRrcConnSetupSuccRate =
        Prefixed_Name(iottaxolite, "AccRrcConnSetupSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AccS1SigEstabSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>S1 (S1 standardized interface between eNB and Evolved Packet Core) signalling establishment success rate.</para>
    /// labels<para>S1 Signalling Establishment Success Rate</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccS1SigEstabSuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#AccS1SigEstabSuccRate</seealso>
    let AccS1SigEstabSuccRate =
        Prefixed_Name(iottaxolite, "AccS1SigEstabSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Accelerometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Accelerometers are used to automatically determine the orientation in which the user is holding the IoT Object (portrait or landscape).</para>
    /// labels<para>Accelerometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Accelerometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Accelerometer</seealso>
    let Accelerometer = Prefixed_Name(iottaxolite, "Accelerometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Agriculture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agriculture, Smart farm as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Agriculture DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Agriculture">http://purl.org/iot/vocab/iot-taxonomy-lite#Agriculture</seealso>
    let Agriculture = Prefixed_Name(iottaxolite, "Agriculture") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DomainOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Application Domain for example: health, environment, etc.</para>
    /// labels<para>Domain Of Interest</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DomainOfInterest">http://purl.org/iot/vocab/iot-taxonomy-lite#DomainOfInterest</seealso>
    let DomainOfInterest =
        Prefixed_Name(iottaxolite, "DomainOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AirPollution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Usually measured using Air Quality Index (AQI), it is the measure of Air Pollution in the environment. It is similar to Air Quality.</para>
    /// labels<para>Air Pollution Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollution">http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollution</seealso>
    let AirPollution = Prefixed_Name(iottaxolite, "AirPollution") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SoundSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Source where the sound originated.</para>
    /// labels<para>Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSource">http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSource</seealso>
    let SoundSource = Prefixed_Name(iottaxolite, "SoundSource") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Bus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare.</para>
    /// labels<para>Bus</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bus">http://purl.org/iot/vocab/iot-taxonomy-lite#Bus</seealso>
    let Bus = Prefixed_Name(iottaxolite, "Bus") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:COSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device to detect Carbon Monoxide (CO) in the environment.</para>
    /// labels<para>Carbon Monoxide (CO) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#COSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#COSensor</seealso>
    let COSensor = Prefixed_Name(iottaxolite, "COSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationSO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of Sulphur dioxide (SO2) gas suspended in the atmosphere.</para>
    /// labels<para>Sulphur dioxide (SO2) Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationSO2">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationSO2</seealso>
    let ChemicalAgentAtmosphericConcentrationSO2 =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationSO2") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentWaterConcentrationNH4Ion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of NH4 ion concentration in Water </para>
    /// labels<para>Ammonium ion (NH4+) Chemical Agent Water Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNH4Ion">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNH4Ion</seealso>
    let ChemicalAgentWaterConcentrationNH4Ion =
        Prefixed_Name(iottaxolite, "ChemicalAgentWaterConcentrationNH4Ion") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentWaterConcentrationNO3Ion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of NO3 ion concentration in Water </para>
    /// labels<para>Nitrate Ion (NO3-) Chemical Agent Water Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNO3Ion">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationNO3Ion</seealso>
    let ChemicalAgentWaterConcentrationNO3Ion =
        Prefixed_Name(iottaxolite, "ChemicalAgentWaterConcentrationNO3Ion") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentWaterConcentrationO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of O2 concentration in Water </para>
    /// labels<para>Oxygen (O2) Chemical Agent Water Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationO2">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentrationO2</seealso>
    let ChemicalAgentWaterConcentrationO2 =
        Prefixed_Name(iottaxolite, "ChemicalAgentWaterConcentrationO2") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CholesterolSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure the cholesterol level in a system.</para>
    /// labels<para>Cholesterol Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CholesterolSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#CholesterolSensor</seealso>
    let CholesterolSensor =
        Prefixed_Name(iottaxolite, "CholesterolSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountStatellitesSignalReceived</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Count of satellites from which a signal is received</para>
    /// labels<para>Count Statellites Signal Received</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountStatellitesSignalReceived">http://purl.org/iot/vocab/iot-taxonomy-lite#CountStatellitesSignalReceived</seealso>
    let CountStatellitesSignalReceived =
        Prefixed_Name(iottaxolite, "CountStatellitesSignalReceived") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Counter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensors that reckons occurrences or repetitions of physical objects, phenomena or events.</para>
    /// labels<para>Counter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Counter">http://purl.org/iot/vocab/iot-taxonomy-lite#Counter</seealso>
    let Counter = Prefixed_Name(iottaxolite, "Counter") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Cupboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the cupboard.</para>
    /// labels<para>Cupboard Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Cupboard">http://purl.org/iot/vocab/iot-taxonomy-lite#Cupboard</seealso>
    let Cupboard = Prefixed_Name(iottaxolite, "Cupboard") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Day</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Day is a unit of time.</para>
    /// labels<para>Day</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Day">http://purl.org/iot/vocab/iot-taxonomy-lite#Day</seealso>
    let Day = Prefixed_Name(iottaxolite, "Day") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DecibelA</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sound pressure sensed by the human ear.</para>
    /// labels<para>DecibelA (dB(A))</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelA">http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelA</seealso>
    let DecibelA = Prefixed_Name(iottaxolite, "DecibelA") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:HeartBeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The number of times your heart beats each minute (bpm).</para>
    /// labels<para>Heart Beat</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeat">http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeat</seealso>
    let HeartBeat = Prefixed_Name(iottaxolite, "HeartBeat") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Heating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the heating.</para>
    /// labels<para>Heating Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Heating">http://purl.org/iot/vocab/iot-taxonomy-lite#Heating</seealso>
    let Heating = Prefixed_Name(iottaxolite, "Heating") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Hour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Hour of the day.</para>
    /// labels<para>Hour</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hour">http://purl.org/iot/vocab/iot-taxonomy-lite#Hour</seealso>
    let Hour = Prefixed_Name(iottaxolite, "Hour") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:HouseholdApplianceTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Household Appliance Temperature.</para>
    /// labels<para>Household Appliance Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#HouseholdApplianceTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#HouseholdApplianceTemperature</seealso>
    let HouseholdApplianceTemperature =
        Prefixed_Name(iottaxolite, "HouseholdApplianceTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:HumanPresenceDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect if an object (vehicle, room, place, etc.) is occupied by Human.</para>
    /// labels<para> Human Presence Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumanPresenceDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#HumanPresenceDetector</seealso>
    let HumanPresenceDetector =
        Prefixed_Name(iottaxolite, "HumanPresenceDetector") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:INR</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>International Normalized Ratio</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#INR">http://purl.org/iot/vocab/iot-taxonomy-lite#INR</seealso>
    let INR = Prefixed_Name(iottaxolite, "INR") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Illuminance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Illuminance is the total luminous flux incident on a surface, per unit area.</para>
    /// labels<para>Illuminance</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Illuminance">http://purl.org/iot/vocab/iot-taxonomy-lite#Illuminance</seealso>
    let Illuminance = Prefixed_Name(iottaxolite, "Illuminance") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ImageSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects and conveys the information that constitutes an image.</para>
    /// labels<para>Image Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ImageSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ImageSensor</seealso>
    let ImageSensor = Prefixed_Name(iottaxolite, "ImageSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Index</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values can only take certain values from a finite set.</para>
    /// labels<para>Index</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Index">http://purl.org/iot/vocab/iot-taxonomy-lite#Index</seealso>
    let Index = Prefixed_Name(iottaxolite, "Index") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:IntUlPacketLoss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Uplink Packet Loss.</para>
    /// labels<para>Uplink Packet Loss</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlPacketLoss">http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlPacketLoss</seealso>
    let IntUlPacketLoss = Prefixed_Name(iottaxolite, "IntUlPacketLoss") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:IntUlThroughputKbps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Uplink Throughput.</para>
    /// labels<para>Uplink Throughput</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlThroughputKbps">http://purl.org/iot/vocab/iot-taxonomy-lite#IntUlThroughputKbps</seealso>
    let IntUlThroughputKbps =
        Prefixed_Name(iottaxolite, "IntUlThroughputKbps") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Irrigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically irrigate.</para>
    /// labels<para>Irrigation Actuation Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Irrigation">http://purl.org/iot/vocab/iot-taxonomy-lite#Irrigation</seealso>
    let Irrigation = Prefixed_Name(iottaxolite, "Irrigation") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Each of the accountable elements within a group.</para>
    /// labels<para>Item</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Item">http://purl.org/iot/vocab/iot-taxonomy-lite#Item</seealso>
    let Item = Prefixed_Name(iottaxolite, "Item") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RelativeHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ratio of vapour pressure to saturation vapour pressure, where vapour pressure is the pressure exerted by the molecules of water vapour and saturation vapour pressure is the pressure exerted by molecules of water vapour in AIR that has attained saturation.</para>
    /// labels<para>Relative Humidity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RelativeHumidity">http://purl.org/iot/vocab/iot-taxonomy-lite#RelativeHumidity</seealso>
    let RelativeHumidity =
        Prefixed_Name(iottaxolite, "RelativeHumidity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ResAverageLicConnectedUsers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Connected Users to a communication channel/platform</para>
    /// labels<para>Connected Users</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ResAverageLicConnectedUsers">http://purl.org/iot/vocab/iot-taxonomy-lite#ResAverageLicConnectedUsers</seealso>
    let ResAverageLicConnectedUsers =
        Prefixed_Name(iottaxolite, "ResAverageLicConnectedUsers") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Room</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the feature of interest is room</para>
    /// labels<para>Room</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Room">http://purl.org/iot/vocab/iot-taxonomy-lite#Room</seealso>
    let Room = Prefixed_Name(iottaxolite, "Room") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:RoomTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temperature of a room.</para>
    /// labels<para>Room Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RoomTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#RoomTemperature</seealso>
    let RoomTemperature = Prefixed_Name(iottaxolite, "RoomTemperature") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the air temperature.</para>
    /// labels<para>Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Temperature">http://purl.org/iot/vocab/iot-taxonomy-lite#Temperature</seealso>
    let Temperature = Prefixed_Name(iottaxolite, "Temperature") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Thermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A device to measure the temperature in a room or outside.</para>
    /// labels<para>Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Thermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Thermometer</seealso>
    let Thermometer = Prefixed_Name(iottaxolite, "Thermometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:AlcoholLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Alcohol Level in the system.</para>
    /// labels<para>Alcohol Level Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevel">http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevel</seealso>
    let AlcoholLevel = Prefixed_Name(iottaxolite, "AlcoholLevel") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountPeopleStaying</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of people that stayed within an area for more than a threshold of time.</para>
    /// labels<para>Count People Staying</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleStaying">http://purl.org/iot/vocab/iot-taxonomy-lite#CountPeopleStaying</seealso>
    let CountPeopleStaying =
        Prefixed_Name(iottaxolite, "CountPeopleStaying") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Crowd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the source of the sound was crowd.</para>
    /// labels<para>Crowd Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Crowd">http://purl.org/iot/vocab/iot-taxonomy-lite#Crowd</seealso>
    let Crowd = Prefixed_Name(iottaxolite, "Crowd") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Health</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Healthcare as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Health Care DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Health">http://purl.org/iot/vocab/iot-taxonomy-lite#Health</seealso>
    let Health = Prefixed_Name(iottaxolite, "Health") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Hydrophone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A hydrophone is a microphone designed to be used underwater for recording or listening to underwater sound.</para>
    /// labels<para>Hydrophone</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hydrophone">http://purl.org/iot/vocab/iot-taxonomy-lite#Hydrophone</seealso>
    let Hydrophone = Prefixed_Name(iottaxolite, "Hydrophone") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:IEEE802154InterfaceEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that measures the power consumption of the IEEE802.15.4 interface nodes.</para>
    /// labels<para>IEEE802.15.4 Interface Energy Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IEEE802154InterfaceEnergyMeter">http://purl.org/iot/vocab/iot-taxonomy-lite#IEEE802154InterfaceEnergyMeter</seealso>
    let IEEE802154InterfaceEnergyMeter =
        Prefixed_Name(iottaxolite, "IEEE802154InterfaceEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:IdentifyOutlierObservsations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose to identify if an observation is outlier or not.</para>
    /// labels<para>Identify Outlier Observsations</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IdentifyOutlierObservsations">http://purl.org/iot/vocab/iot-taxonomy-lite#IdentifyOutlierObservsations</seealso>
    let IdentifyOutlierObservsations =
        Prefixed_Name(iottaxolite, "IdentifyOutlierObservsations") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Inch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Length in inches.</para>
    /// labels<para>Inch</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Inch">http://purl.org/iot/vocab/iot-taxonomy-lite#Inch</seealso>
    let Inch = Prefixed_Name(iottaxolite, "Inch") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:IntDlLatency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Downlink Latency.</para>
    /// labels<para>Downlink Latency</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlLatency">http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlLatency</seealso>
    let IntDlLatency = Prefixed_Name(iottaxolite, "IntDlLatency") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:IntDlThroughputKbps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Downlink Throughput.</para>
    /// labels<para>Downlink Throughput</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlThroughputKbps">http://purl.org/iot/vocab/iot-taxonomy-lite#IntDlThroughputKbps</seealso>
    let IntDlThroughputKbps =
        Prefixed_Name(iottaxolite, "IntDlThroughputKbps") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Invalid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>If the measurement was tagged invalid.</para>
    /// labels<para>Invalid Measurement Type</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Invalid">http://purl.org/iot/vocab/iot-taxonomy-lite#Invalid</seealso>
    let Invalid = Prefixed_Name(iottaxolite, "Invalid") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:IonisingRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ionising radiation is radiation that carries enough energy to free electrons from atoms or molecules, thereby ionizing them. Gamma rays, X-rays, and the higher ultraviolet part of the electromagnetic spectrum are ionizing, whereas the lower ultraviolet part of the electromagnetic spectrum, and also the lower part of the spectrum below UV, including visible light (including nearly all types of laser light), infrared, microwaves, and radio waves are all considered non-ionizing radiation.</para>
    /// labels<para>Ionising Radiation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#IonisingRadiation">http://purl.org/iot/vocab/iot-taxonomy-lite#IonisingRadiation</seealso>
    let IonisingRadiation =
        Prefixed_Name(iottaxolite, "IonisingRadiation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Kelvin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Kelvin is a unit of measurement for temperature.</para>
    /// labels<para>Kelvin, Degree Kelvin</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kelvin">http://purl.org/iot/vocab/iot-taxonomy-lite#Kelvin</seealso>
    let Kelvin = Prefixed_Name(iottaxolite, "Kelvin") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:KilobitsPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of data transfer rate equal to: 1,000 bits per second.</para>
    /// labels<para>Kilobits Per Second</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilobitsPerSecond">http://purl.org/iot/vocab/iot-taxonomy-lite#KilobitsPerSecond</seealso>
    let KilobitsPerSecond =
        Prefixed_Name(iottaxolite, "KilobitsPerSecond") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:KilogramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is SI derived unit of density, defined by mass in kilograms divided by volume in cubic metres.</para>
    /// labels<para>Kilogram Per Cubic Metre, Kilogram Per Cubic Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilogramPerCubicMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#KilogramPerCubicMetre</seealso>
    let KilogramPerCubicMetre =
        Prefixed_Name(iottaxolite, "KilogramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Kilometre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A metric unit of measurement equal to 1,000 metres (approx 0.62 miles).</para>
    /// labels<para>Kilometre, Kilometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilometre">http://purl.org/iot/vocab/iot-taxonomy-lite#Kilometre</seealso>
    let Kilometre = Prefixed_Name(iottaxolite, "Kilometre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:KilometrePerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of speed, expressing the number of kilometres travelled in one hour.</para>
    /// labels<para>Kilometre Per Hour, Kilometer Per Hour</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#KilometrePerHour">http://purl.org/iot/vocab/iot-taxonomy-lite#KilometrePerHour</seealso>
    let KilometrePerHour =
        Prefixed_Name(iottaxolite, "KilometrePerHour") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Lamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the lamp.</para>
    /// labels<para>Lamp Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lamp">http://purl.org/iot/vocab/iot-taxonomy-lite#Lamp</seealso>
    let Lamp = Prefixed_Name(iottaxolite, "Lamp") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Lavatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the lavatory.</para>
    /// labels<para>Lavatory Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lavatory">http://purl.org/iot/vocab/iot-taxonomy-lite#Lavatory</seealso>
    let Lavatory = Prefixed_Name(iottaxolite, "Lavatory") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:LeafWetness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Leaf wetness is a meteorological parameter that describes the amount of dew and precipitation left on surfaces. It is used for monitoring leaf moisture for agricultural purposes, such as fungus and disease control, for control of irrigation systems, and for detection of fog and dew conditions, and early detection of rainfall. (Source Wikipedia).</para>
    /// labels<para>Leaf Wetness</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetness">http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetness</seealso>
    let LeafWetness = Prefixed_Name(iottaxolite, "LeafWetness") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:LightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Light/Illuminance Sensor is used to adjust the brightness of the surface.</para>
    /// labels<para>Light Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LightSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#LightSensor</seealso>
    let LightSensor = Prefixed_Name(iottaxolite, "LightSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Litre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A metric unit of capacity defined as the volume of one kilogram of water under standard conditions. It is equal to 1,000 cubic centimetres.</para>
    /// labels<para>Litre, Liter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Litre">http://purl.org/iot/vocab/iot-taxonomy-lite#Litre</seealso>
    let Litre = Prefixed_Name(iottaxolite, "Litre") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:LoRaInterface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This device is used for long range low power wireless communications. We can use this device to report network metrics (SNR, latence, etc.)</para>
    /// labels<para>LoRa Interface</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterface">http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterface</seealso>
    let LoRaInterface = Prefixed_Name(iottaxolite, "LoRaInterface") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:LoRaInterfaceEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure the average power consumption of the LoRa interface nodes.</para>
    /// labels<para>LoRa Interface Energy Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterfaceEnergyMeter">http://purl.org/iot/vocab/iot-taxonomy-lite#LoRaInterfaceEnergyMeter</seealso>
    let LoRaInterfaceEnergyMeter =
        Prefixed_Name(iottaxolite, "LoRaInterfaceEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:LocationQK</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A particular place or position.</para>
    /// labels<para>Location Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LocationQK">http://purl.org/iot/vocab/iot-taxonomy-lite#LocationQK</seealso>
    let LocationQK = Prefixed_Name(iottaxolite, "LocationQK") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:LuminousFlux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Luminous Flux is the measure of the perceived power of light.</para>
    /// labels<para>Luminous Flux</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousFlux">http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousFlux</seealso>
    let LuminousFlux = Prefixed_Name(iottaxolite, "LuminousFlux") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:LuminousIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> It is a measure of the wavelength-weighted power emitted by a light source in a particular direction per unit solid angle, based on the luminosity function, a standardized model of the sensitivity of the human eye. The SI unit of luminous intensity is the candela (cd), an SI base unit. (Source Wikipedia)</para>
    /// labels<para>Luminous Intensity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousIntensity">http://purl.org/iot/vocab/iot-taxonomy-lite#LuminousIntensity</seealso>
    let LuminousIntensity =
        Prefixed_Name(iottaxolite, "LuminousIntensity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MagneticField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A region around a magnetic material or a moving electric charge within which the force of magnetism acts.</para>
    /// labels<para>Magnetic Field</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticField">http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticField</seealso>
    let MagneticField = Prefixed_Name(iottaxolite, "MagneticField") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MagneticFluxDensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the magnetic flux  through a surface is the surface integral of the normal component of the magnetic field (B) passing through that surface. The SI unit of magnetic flux is the weber (Wb). (Source Wikipedia).</para>
    /// labels<para>Magnetic Flux Density</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticFluxDensity">http://purl.org/iot/vocab/iot-taxonomy-lite#MagneticFluxDensity</seealso>
    let MagneticFluxDensity =
        Prefixed_Name(iottaxolite, "MagneticFluxDensity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Manual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>If the measurement was taken when human effort was involved.</para>
    /// labels<para>Manual Measurement Type</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Manual">http://purl.org/iot/vocab/iot-taxonomy-lite#Manual</seealso>
    let Manual = Prefixed_Name(iottaxolite, "Manual") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Mass is a property of a physical body. It is the measure of an object's resistance to acceleration when a net force is applied.</para>
    /// labels<para>Mass</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mass">http://purl.org/iot/vocab/iot-taxonomy-lite#Mass</seealso>
    let Mass = Prefixed_Name(iottaxolite, "Mass") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SnowChains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The actuator that turn Snow chains on/off.</para>
    /// labels<para>Snow Chains Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SnowChains">http://purl.org/iot/vocab/iot-taxonomy-lite#SnowChains</seealso>
    let SnowChains = Prefixed_Name(iottaxolite, "SnowChains") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Sodium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Blood Sodium level.</para>
    /// labels<para>Sodium</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sodium">http://purl.org/iot/vocab/iot-taxonomy-lite#Sodium</seealso>
    let Sodium = Prefixed_Name(iottaxolite, "Sodium") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SoilMoistureTension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The force per unit area required to remove film water from soil.</para>
    /// labels<para>Soil Moisture Tension</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilMoistureTension">http://purl.org/iot/vocab/iot-taxonomy-lite#SoilMoistureTension</seealso>
    let SoilMoistureTension =
        Prefixed_Name(iottaxolite, "SoilMoistureTension") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SoilTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Soil temperature is the bulk temperature of the soil, not the surface (skin) temperature.</para>
    /// labels<para>Soil Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#SoilTemperature</seealso>
    let SoilTemperature = Prefixed_Name(iottaxolite, "SoilTemperature") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SoilThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This sensor reports Soil temperature.</para>
    /// labels<para>Soil Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilThermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#SoilThermometer</seealso>
    let SoilThermometer = Prefixed_Name(iottaxolite, "SoilThermometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SolarRadiation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the power per unit area received from the Sun in the form of electromagnetic radiation in the wavelength range of the measuring instrument. (Source Wikipedia).</para>
    /// labels<para>Solar Radiation Measurement, PAR Measurement (Photosynthetically Active Radiation)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiation">http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiation</seealso>
    let SolarRadiation = Prefixed_Name(iottaxolite, "SolarRadiation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SolarRadiationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Solar Radiation.</para>
    /// labels<para>Solar Radiation Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiationSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SolarRadiationSensor</seealso>
    let SolarRadiationSensor =
        Prefixed_Name(iottaxolite, "SolarRadiationSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SoundPressureLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sound pressure level is a logarithmic measure of the RMS sound pressure of a sound relative to a reference value, the threshold of hearing. The reference sound pressure was chosen conventionally to correspond to the quietest sound at 1000 Hz that the human ear can detect (20 uPa). In this case, the specific parameter is measured in an open environment.</para>
    /// labels<para>Sound Pressure Level</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevel">http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevel</seealso>
    let SoundPressureLevel =
        Prefixed_Name(iottaxolite, "SoundPressureLevel") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SoundPressureLevelAmbient</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Similar to Sound.</para>
    /// labels<para>Sound Pressure Level Ambient</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevelAmbient">http://purl.org/iot/vocab/iot-taxonomy-lite#SoundPressureLevelAmbient</seealso>
    let SoundPressureLevelAmbient =
        Prefixed_Name(iottaxolite, "SoundPressureLevelAmbient") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SoundSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to detect Noise level. It can be Sound Sensor, Noise level Sensor, Volume sensor, Microphone</para>
    /// labels<para>Sound Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SoundSensor</seealso>
    let SoundSensor = Prefixed_Name(iottaxolite, "SoundSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SpeedAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure of the average rate of motion of an object.</para>
    /// labels<para>Speed Average</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedAverage">http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedAverage</seealso>
    let SpeedAverage = Prefixed_Name(iottaxolite, "SpeedAverage") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SpeedInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure of the instantaneous rate of motion of an object.</para>
    /// labels<para>Speed Instantaneous</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedInstantaneous">http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedInstantaneous</seealso>
    let SpeedInstantaneous =
        Prefixed_Name(iottaxolite, "SpeedInstantaneous") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SpeedMedian</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure of the median rate of motion of an object.</para>
    /// labels<para>Speed Median</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedMedian">http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedMedian</seealso>
    let SpeedMedian = Prefixed_Name(iottaxolite, "SpeedMedian") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SpeedSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to detect speed.</para>
    /// labels<para>Speed Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SpeedSensor</seealso>
    let SpeedSensor = Prefixed_Name(iottaxolite, "SpeedSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:StayingPeopleCountSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to count the number of people that stays within an area for more than a threshold of time.</para>
    /// labels<para>Staying People Count Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#StayingPeopleCountSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#StayingPeopleCountSensor</seealso>
    let StayingPeopleCountSensor =
        Prefixed_Name(iottaxolite, "StayingPeopleCountSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SunPositionElevationSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect sun elevation.</para>
    /// labels<para>Sun Position Elevation Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevationSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevationSensor</seealso>
    let SunPositionElevationSensor =
        Prefixed_Name(iottaxolite, "SunPositionElevationSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SystolicBloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the pressure when the heart beats while pumping blood.</para>
    /// labels<para>Systolic Blood Pressure</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SystolicBloodPressure">http://purl.org/iot/vocab/iot-taxonomy-lite#SystolicBloodPressure</seealso>
    let SystolicBloodPressure =
        Prefixed_Name(iottaxolite, "SystolicBloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the television.</para>
    /// labels<para>TV Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TV">http://purl.org/iot/vocab/iot-taxonomy-lite#TV</seealso>
    let TV = Prefixed_Name(iottaxolite, "TV") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Telephone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the Telephone.</para>
    /// labels<para>Telephone Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Telephone">http://purl.org/iot/vocab/iot-taxonomy-lite#Telephone</seealso>
    let Telephone = Prefixed_Name(iottaxolite, "Telephone") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TemperatureEngine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The temperature of a vehicle engine.</para>
    /// labels<para>Temperature Engine</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureEngine">http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureEngine</seealso>
    let TemperatureEngine =
        Prefixed_Name(iottaxolite, "TemperatureEngine") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TemperatureWasteContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The temperature of the air that would be indicated by a thermometer exposed to the air inside a waste container.</para>
    /// labels<para>Temperature Waste Container</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureWasteContainer">http://purl.org/iot/vocab/iot-taxonomy-lite#TemperatureWasteContainer</seealso>
    let TemperatureWasteContainer =
        Prefixed_Name(iottaxolite, "TemperatureWasteContainer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Tesla</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the SI unit of magnetic flux density.</para>
    /// labels<para>Tesla</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tesla">http://purl.org/iot/vocab/iot-taxonomy-lite#Tesla</seealso>
    let Tesla = Prefixed_Name(iottaxolite, "Tesla") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ThrottleSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a device used to monitor the throttle position of a vehicle.</para>
    /// labels<para>Throttle Position Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ThrottleSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ThrottleSensor</seealso>
    let ThrottleSensor = Prefixed_Name(iottaxolite, "ThrottleSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:TimeOfArrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Estimated time till an object is arriving to a specific location (typically used in transportation).</para>
    /// labels<para>Time of arrival</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrival">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrival</seealso>
    let TimeOfArrival = Prefixed_Name(iottaxolite, "TimeOfArrival") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeOfArrivalNextBus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Estimated time (in seconds) till a bus will arrive at a specific bus stop. </para>
    /// labels<para>Time of arrival for the next bus</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBus">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBus</seealso>
    let TimeOfArrivalNextBus =
        Prefixed_Name(iottaxolite, "TimeOfArrivalNextBus") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeOfArrivalNextBusSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Virtual device that represents a bus stop X and a bus line Y; it estimates the remaining time the next bus (belonging to line Y) will arrive at bus stop X. </para>
    /// labels<para>Time of arrival sensor for the next bus</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBusSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalNextBusSensor</seealso>
    let TimeOfArrivalNextBusSensor =
        Prefixed_Name(iottaxolite, "TimeOfArrivalNextBusSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeOfArrivalSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Virtual device that estimates the remaining time for an object to arrive at a specific location.</para>
    /// labels<para>Time of Arrival Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeOfArrivalSensor</seealso>
    let TimeOfArrivalSensor =
        Prefixed_Name(iottaxolite, "TimeOfArrivalSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeRelatedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicator of whether a person (or object) has overpassed a particular time threshold (e.g. maximum number of hours driving, etc.)</para>
    /// labels<para>Time Related State</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedState">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedState</seealso>
    let TimeRelatedState =
        Prefixed_Name(iottaxolite, "TimeRelatedState") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeRelatedStateDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicator of whether the driver of a vehicle approaches or exceeds his/her working time limits.</para>
    /// labels<para>Time Related State Driver</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriver">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriver</seealso>
    let TimeRelatedStateDriver =
        Prefixed_Name(iottaxolite, "TimeRelatedStateDriver") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Tonne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a non-SI metric unit of mass equal to 1,000 kilograms.</para>
    /// labels<para>Tonne</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tonne">http://purl.org/iot/vocab/iot-taxonomy-lite#Tonne</seealso>
    let Tonne = Prefixed_Name(iottaxolite, "Tonne") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:TouchSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that captures and records physical touch or embrace on a device and/or object.</para>
    /// labels<para>Touch Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TouchSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#TouchSensor</seealso>
    let TouchSensor = Prefixed_Name(iottaxolite, "TouchSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Tourism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Tourism as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Tourism DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Tourism">http://purl.org/iot/vocab/iot-taxonomy-lite#Tourism</seealso>
    let Tourism = Prefixed_Name(iottaxolite, "Tourism") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Traffic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the source of the sound was traffic.</para>
    /// labels<para>Traffic</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Traffic">http://purl.org/iot/vocab/iot-taxonomy-lite#Traffic</seealso>
    let Traffic = Prefixed_Name(iottaxolite, "Traffic") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TrafficIntensity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The intensity of a traffic flow is the number of vehicles passing a cross section of a road in a unit of time.</para>
    /// labels<para>Traffic Intensity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TrafficIntensity">http://purl.org/iot/vocab/iot-taxonomy-lite#TrafficIntensity</seealso>
    let TrafficIntensity =
        Prefixed_Name(iottaxolite, "TrafficIntensity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VehicleCountSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to count the number of vehicles (e.g., used within the Citypulse project).</para>
    /// labels<para>Vehicle Count Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleCountSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleCountSensor</seealso>
    let VehicleCountSensor =
        Prefixed_Name(iottaxolite, "VehicleCountSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VehicleOverspeedState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure to indicates whether the vehicle is exceeding the legal speed limit.</para>
    /// labels<para>Vehicle Overspeed State</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleOverspeedState">http://purl.org/iot/vocab/iot-taxonomy-lite#VehicleOverspeedState</seealso>
    let VehicleOverspeedState =
        Prefixed_Name(iottaxolite, "VehicleOverspeedState") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VehiclePresenceDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect if an vehicle is present at a place.</para>
    /// labels<para> Vehicle Presence Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclePresenceDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclePresenceDetector</seealso>
    let VehiclePresenceDetector =
        Prefixed_Name(iottaxolite, "VehiclePresenceDetector") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VehiclesPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of vehicles that traverse a concrete region of the space in one minute.</para>
    /// labels<para>Vehicles Per Minute</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclesPerMinute">http://purl.org/iot/vocab/iot-taxonomy-lite#VehiclesPerMinute</seealso>
    let VehiclesPerMinute =
        Prefixed_Name(iottaxolite, "VehiclesPerMinute") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Ventilation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the ventilation.</para>
    /// labels<para>Ventilation Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ventilation">http://purl.org/iot/vocab/iot-taxonomy-lite#Ventilation</seealso>
    let Ventilation = Prefixed_Name(iottaxolite, "Ventilation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AlcoholLevelSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect and measure Alcohol Level in the system.</para>
    /// labels<para>Alcohol Level Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevelSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#AlcoholLevelSensor</seealso>
    let AlcoholLevelSensor =
        Prefixed_Name(iottaxolite, "AlcoholLevelSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AngularSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the rate of change of angular displacement and is a vector quantity (more precisely, a pseudovector) that specifies the angular speed (rotational speed) of an object and the axis about which the object is rotating. (Source Wikipedia).</para>
    /// labels<para>Angular Speed</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AngularSpeed">http://purl.org/iot/vocab/iot-taxonomy-lite#AngularSpeed</seealso>
    let AngularSpeed = Prefixed_Name(iottaxolite, "AngularSpeed") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Animals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>when the source of the sound were animals.</para>
    /// labels<para>Animals as Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Animals">http://purl.org/iot/vocab/iot-taxonomy-lite#Animals</seealso>
    let Animals = Prefixed_Name(iottaxolite, "Animals") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AtmosphericPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The pressure exerted by the atmosphere as a consequence of gravitational attraction exerted upon the column of air lying directly above the point in question.</para>
    /// labels<para>Atmospheric Pressure</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressure">http://purl.org/iot/vocab/iot-taxonomy-lite#AtmosphericPressure</seealso>
    let AtmosphericPressure =
        Prefixed_Name(iottaxolite, "AtmosphericPressure") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AutomaticSensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the devices are set to take the observations Automatically without any external aid.</para>
    /// labels<para>Automatic Measurement Type</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AutomaticSensing">http://purl.org/iot/vocab/iot-taxonomy-lite#AutomaticSensing</seealso>
    let AutomaticSensing =
        Prefixed_Name(iottaxolite, "AutomaticSensing") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MeasurementType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Type of Measurement done using a device.</para>
    /// labels<para>Measurement Type</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeasurementType">http://purl.org/iot/vocab/iot-taxonomy-lite#MeasurementType</seealso>
    let MeasurementType = Prefixed_Name(iottaxolite, "MeasurementType") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Bad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the quality of observation is bad</para>
    /// labels<para>Bad</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Bad">http://purl.org/iot/vocab/iot-taxonomy-lite#Bad</seealso>
    let Bad = Prefixed_Name(iottaxolite, "Bad") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationAirParticles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of chemical particles suspended in the atmosphere.</para>
    /// labels<para>Air Particles Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationAirParticles">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationAirParticles</seealso>
    let ChemicalAgentAtmosphericConcentrationAirParticles =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationAirParticles") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationCO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.</para>
    /// labels<para>Carbon Monoxide (CO) Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationCO">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationCO</seealso>
    let ChemicalAgentAtmosphericConcentrationCO =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationCO") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationDust</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of dust suspended in the air.</para>
    /// labels<para>Chemical Agent Atmospheric Concentration Dust</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationDust">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationDust</seealso>
    let ChemicalAgentAtmosphericConcentrationDust =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationDust") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationNH3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of Ammonia (NH3) gas suspended in the atmosphere.</para>
    /// labels<para>Ammonia (NH3) Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNH3">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNH3</seealso>
    let ChemicalAgentAtmosphericConcentrationNH3 =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationNH3") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FillLevelGasTankTwo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the secondary tank of the vehicle.</para>
    /// labels<para>Fill Level Gas Tank 2</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankTwo">http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankTwo</seealso>
    let FillLevelGasTankTwo =
        Prefixed_Name(iottaxolite, "FillLevelGasTankTwo") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FloorSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>FloorSensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FloorSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#FloorSensor</seealso>
    let FloorSensor = Prefixed_Name(iottaxolite, "FloorSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:FoodTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of temperature of the food.</para>
    /// labels<para>Food Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FoodTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#FoodTemperature</seealso>
    let FoodTemperature = Prefixed_Name(iottaxolite, "FoodTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MobMobilitySuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Handover Mobility Success Rate.</para>
    /// labels<para>Handover Mobility Success Rate</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobMobilitySuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#MobMobilitySuccRate</seealso>
    let MobMobilitySuccRate =
        Prefixed_Name(iottaxolite, "MobMobilitySuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Motion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the action or process of moving or being moved.</para>
    /// labels<para>Motion</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Motion">http://purl.org/iot/vocab/iot-taxonomy-lite#Motion</seealso>
    let Motion = Prefixed_Name(iottaxolite, "Motion") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MotionStateVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates whether motion of the vehicle is detected or not.</para>
    /// labels<para>Motion State Vehicle</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionStateVehicle">http://purl.org/iot/vocab/iot-taxonomy-lite#MotionStateVehicle</seealso>
    let MotionStateVehicle =
        Prefixed_Name(iottaxolite, "MotionStateVehicle") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:NH3Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect NH3 level in the environment.</para>
    /// labels<para>NH3 Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#NH3Sensor">http://purl.org/iot/vocab/iot-taxonomy-lite#NH3Sensor</seealso>
    let NH3Sensor = Prefixed_Name(iottaxolite, "NH3Sensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:NO2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor detecting levels of Nitrogen Dioxide (NO2) in the environment.</para>
    /// labels<para>Nitrogen Dioxide (NO2) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#NO2Sensor">http://purl.org/iot/vocab/iot-taxonomy-lite#NO2Sensor</seealso>
    let NO2Sensor = Prefixed_Name(iottaxolite, "NO2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:NOSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Nitrogen Oxide (NO) in the environment.</para>
    /// labels<para>Nitrogen Oxide (NO) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#NOSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#NOSensor</seealso>
    let NOSensor = Prefixed_Name(iottaxolite, "NOSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:O3Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Ozone (O3) in the environment.</para>
    /// labels<para>Ozone (O3) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#O3Sensor">http://purl.org/iot/vocab/iot-taxonomy-lite#O3Sensor</seealso>
    let O3Sensor = Prefixed_Name(iottaxolite, "O3Sensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Odometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An odometer or odograph is an instrument that indicates distance travelled by a vehicle, such as bicycle or automobile.</para>
    /// labels<para>Odometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Odometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Odometer</seealso>
    let Odometer = Prefixed_Name(iottaxolite, "Odometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Ohm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ohm is the unit of electrical resistance.</para>
    /// labels<para>Ohm</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ohm">http://purl.org/iot/vocab/iot-taxonomy-lite#Ohm</seealso>
    let Ohm = Prefixed_Name(iottaxolite, "Ohm") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:OpenTheDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action related to either request for opening the door or actually opening it.</para>
    /// labels<para>Open The Door</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpenTheDoor">http://purl.org/iot/vocab/iot-taxonomy-lite#OpenTheDoor</seealso>
    let OpenTheDoor = Prefixed_Name(iottaxolite, "OpenTheDoor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:OpticalDustSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensing device that measures dust particle concentration using optical sensing mean.</para>
    /// labels<para>Optical Dust Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#OpticalDustSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#OpticalDustSensor</seealso>
    let OpticalDustSensor =
        Prefixed_Name(iottaxolite, "OpticalDustSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Others</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Relates to phenomenon and unit that are not available currently in the current version of Taxonomy.</para>
    /// labels<para>Others</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Others">http://purl.org/iot/vocab/iot-taxonomy-lite#Others</seealso>
    let Others = Prefixed_Name(iottaxolite, "Others") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Wout</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This unit is used to measure delta dew point. Natural number (W/out unit).</para>
    /// labels<para>W/out</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Wout">http://purl.org/iot/vocab/iot-taxonomy-lite#Wout</seealso>
    let Wout = Prefixed_Name(iottaxolite, "Wout") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Year as a unit of time.</para>
    /// labels<para>Year</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Year">http://purl.org/iot/vocab/iot-taxonomy-lite#Year</seealso>
    let Year = Prefixed_Name(iottaxolite, "Year") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Ampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.The ampere is the SI unit for measuring an electric current which is the flow of electric charges through a surface at the rate of one coulomb per second.</para>
    /// labels<para>Ampere (A)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Ampere">http://purl.org/iot/vocab/iot-taxonomy-lite#Ampere</seealso>
    let Ampere = Prefixed_Name(iottaxolite, "Ampere") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:AirThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device to measure the Air temperature of either indoor or outdoor atmosphere.</para>
    /// labels<para>Air Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirThermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#AirThermometer</seealso>
    let AirThermometer = Prefixed_Name(iottaxolite, "AirThermometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:AlarmSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the alarm system.</para>
    /// labels<para>Alarm System Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AlarmSystem">http://purl.org/iot/vocab/iot-taxonomy-lite#AlarmSystem</seealso>
    let AlarmSystem = Prefixed_Name(iottaxolite, "AlarmSystem") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BloodCoagulation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Blood Coagulation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodCoagulation">http://purl.org/iot/vocab/iot-taxonomy-lite#BloodCoagulation</seealso>
    let BloodCoagulation =
        Prefixed_Name(iottaxolite, "BloodCoagulation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BloodGlucose</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Blood glucose level or blood sugar level.</para>
    /// labels<para>Blood Glucose Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodGlucose">http://purl.org/iot/vocab/iot-taxonomy-lite#BloodGlucose</seealso>
    let BloodGlucose = Prefixed_Name(iottaxolite, "BloodGlucose") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:BloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the pressure in your blood vessels when your heart rests between beats.</para>
    /// labels<para>Blood Pressure</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressure">http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressure</seealso>
    let BloodPressure = Prefixed_Name(iottaxolite, "BloodPressure") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the fridge.</para>
    /// labels<para>Fridge, Refrigerator Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fridge">http://purl.org/iot/vocab/iot-taxonomy-lite#Fridge</seealso>
    let Fridge = Prefixed_Name(iottaxolite, "Fridge") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:GasDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that detects the presence of gases in an area, often as part of a safety system.</para>
    /// labels<para>Gas Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GasDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#GasDetector</seealso>
    let GasDetector = Prefixed_Name(iottaxolite, "GasDetector") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:WindSpeedSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Wind Speed Sensor, Anemometer or Wind Velocity Sensor is used to measure the wind speed.</para>
    /// labels<para>Wind Speed Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeedSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeedSensor</seealso>
    let WindSpeedSensor = Prefixed_Name(iottaxolite, "WindSpeedSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the physical force exerted on or against an object by something in contact with it.</para>
    /// labels<para>Pressure</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pressure">http://purl.org/iot/vocab/iot-taxonomy-lite#Pressure</seealso>
    let Pressure = Prefixed_Name(iottaxolite, "Pressure") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ECG</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ECG or EKG (Electrocardiogram) device.</para>
    /// labels<para>ECG or EKG (Electrocardiogram)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ECG">http://purl.org/iot/vocab/iot-taxonomy-lite#ECG</seealso>
    let ECG = Prefixed_Name(iottaxolite, "ECG") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:BeatPerMinute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Beat Per Minute (bpm) is the unit to measure heart rate.</para>
    /// labels<para>Beat Per Minute (bpm)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BeatPerMinute">http://purl.org/iot/vocab/iot-taxonomy-lite#BeatPerMinute</seealso>
    let BeatPerMinute = Prefixed_Name(iottaxolite, "BeatPerMinute") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Conductivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of ability to conduct electricity. It is measured in siemens per metre (S/m).</para>
    /// labels<para>Conductivity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Conductivity">http://purl.org/iot/vocab/iot-taxonomy-lite#Conductivity</seealso>
    let Conductivity = Prefixed_Name(iottaxolite, "Conductivity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ConstructionWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the source of the sound was a construction work.</para>
    /// labels<para>Construction Work Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ConstructionWork">http://purl.org/iot/vocab/iot-taxonomy-lite#ConstructionWork</seealso>
    let ConstructionWork =
        Prefixed_Name(iottaxolite, "ConstructionWork") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Coulomb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>SI unit of electric charge.</para>
    /// labels<para>Coulomb</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Coulomb">http://purl.org/iot/vocab/iot-taxonomy-lite#Coulomb</seealso>
    let Coulomb = Prefixed_Name(iottaxolite, "Coulomb") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountAvailableBicycles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of available bicycles at a particular bicycle docking station.</para>
    /// labels<para>Count Available Bicycles</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableBicycles">http://purl.org/iot/vocab/iot-taxonomy-lite#CountAvailableBicycles</seealso>
    let CountAvailableBicycles =
        Prefixed_Name(iottaxolite, "CountAvailableBicycles") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CountEmptyDockingPoints</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Number of empty docking points at a particular bicycle docking station.</para>
    /// labels<para>Count Empty Docking Points</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CountEmptyDockingPoints">http://purl.org/iot/vocab/iot-taxonomy-lite#CountEmptyDockingPoints</seealso>
    let CountEmptyDockingPoints =
        Prefixed_Name(iottaxolite, "CountEmptyDockingPoints") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:GramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is defined by mass in grams divided by volume in cubic metres.</para>
    /// labels<para>Gram Per Cubic Metre, Gram Per Cubic Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerCubicMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerCubicMetre</seealso>
    let GramPerCubicMetre =
        Prefixed_Name(iottaxolite, "GramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PH</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a numeric scale used to specify the acidity or basicity of an aqueous solution.</para>
    /// labels<para>PH</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PH">http://purl.org/iot/vocab/iot-taxonomy-lite#PH</seealso>
    let PH = Prefixed_Name(iottaxolite, "PH") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Pascal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unit for pressure (e.g., atmospheric pressure).</para>
    /// labels<para>Pascal</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Pascal">http://purl.org/iot/vocab/iot-taxonomy-lite#Pascal</seealso>
    let Pascal = Prefixed_Name(iottaxolite, "Pascal") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PeopleStayDurationAverage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Average time people stays within an area.</para>
    /// labels<para>People Stay Duration Average </para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationAverage">http://purl.org/iot/vocab/iot-taxonomy-lite#PeopleStayDurationAverage</seealso>
    let PeopleStayDurationAverage =
        Prefixed_Name(iottaxolite, "PeopleStayDurationAverage") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location, Place, GPS coordinates as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Place DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Place">http://purl.org/iot/vocab/iot-taxonomy-lite#Place</seealso>
    let Place = Prefixed_Name(iottaxolite, "Place") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Precipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is any product of the condensation of atmospheric water vapour that falls under gravity.</para>
    /// labels<para>Precipitation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Precipitation">http://purl.org/iot/vocab/iot-taxonomy-lite#Precipitation</seealso>
    let Precipitation = Prefixed_Name(iottaxolite, "Precipitation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceStateDriverCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates the presence of the first driver card.</para>
    /// labels<para>Presence State Driver Card</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCard">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateDriverCard</seealso>
    let PresenceStateDriverCard =
        Prefixed_Name(iottaxolite, "PresenceStateDriverCard") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MmolPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the amount of a substance that corresponds to its formula mass in milligrams. MmolPerLitre is used to measure cholesterol.</para>
    /// labels<para>Mmol Per Litre, Mmol Per Liter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmolPerLitre">http://purl.org/iot/vocab/iot-taxonomy-lite#MmolPerLitre</seealso>
    let MmolPerLitre = Prefixed_Name(iottaxolite, "MmolPerLitre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterNH4IonSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to measure NH4 concentration level in the water.</para>
    /// labels<para>Water NH4 Ion Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNH4IonSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNH4IonSensor</seealso>
    let WaterNH4IonSensor =
        Prefixed_Name(iottaxolite, "WaterNH4IonSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterPHSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect PH level of water.</para>
    /// labels<para>Water PH Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterPHSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterPHSensor</seealso>
    let WaterPHSensor = Prefixed_Name(iottaxolite, "WaterPHSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Clock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>sensor that measures time</para>
    /// labels<para>Clock</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Clock">http://purl.org/iot/vocab/iot-taxonomy-lite#Clock</seealso>
    let Clock = Prefixed_Name(iottaxolite, "Clock") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:CoffeeMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the coffee machine.</para>
    /// labels<para>Coffee Machine, Coffee Maker Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CoffeeMachine">http://purl.org/iot/vocab/iot-taxonomy-lite#CoffeeMachine</seealso>
    let CoffeeMachine = Prefixed_Name(iottaxolite, "CoffeeMachine") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Neighbours</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the source of the sound were noisy neighbours.</para>
    /// labels<para>Neighbours Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Neighbours">http://purl.org/iot/vocab/iot-taxonomy-lite#Neighbours</seealso>
    let Neighbours = Prefixed_Name(iottaxolite, "Neighbours") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Okta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Okta is the unit to measure the cloud cover.</para>
    /// labels<para>Okta</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Okta">http://purl.org/iot/vocab/iot-taxonomy-lite#Okta</seealso>
    let Okta = Prefixed_Name(iottaxolite, "Okta") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BloodPressureSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure Blood Pressure.</para>
    /// labels<para>Blood Pressure Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressureSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#BloodPressureSensor</seealso>
    let BloodPressureSensor =
        Prefixed_Name(iottaxolite, "BloodPressureSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BoardThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure board temperature.</para>
    /// labels<para>Board Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardThermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#BoardThermometer</seealso>
    let BoardThermometer =
        Prefixed_Name(iottaxolite, "BoardThermometer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CurrentSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A current sensor is a device that detects electric current in a wire, and generates a signal proportional to that current.</para>
    /// labels<para>Current Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CurrentSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#CurrentSensor</seealso>
    let CurrentSensor = Prefixed_Name(iottaxolite, "CurrentSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Curtain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the curtain.</para>
    /// labels<para>Curtain Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Curtain">http://purl.org/iot/vocab/iot-taxonomy-lite#Curtain</seealso>
    let Curtain = Prefixed_Name(iottaxolite, "Curtain") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SecondTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Qualitatively defined as the second division of the hour by sixty, the first division by sixty being the minute. SI definition of second is "the duration of 9 192 631 770 periods of the radiation corresponding to the transition between the two hyperfine levels of the ground state of the cesium 133 atom.</para>
    /// labels<para>Second Time</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondTime">http://purl.org/iot/vocab/iot-taxonomy-lite#SecondTime</seealso>
    let SecondTime = Prefixed_Name(iottaxolite, "SecondTime") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Decibel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Decibel is a logarithmic unit used to express the ratio of two values of a physical quantity. It is often used to measure sound level.</para>
    /// labels<para>Decibel (dB)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Decibel">http://purl.org/iot/vocab/iot-taxonomy-lite#Decibel</seealso>
    let Decibel = Prefixed_Name(iottaxolite, "Decibel") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DecibelMilliwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It describes power ratio in decibels of the measured power referenced to one milliwatt.</para>
    /// labels<para>Decibel Milliwatt</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelMilliwatt">http://purl.org/iot/vocab/iot-taxonomy-lite#DecibelMilliwatt</seealso>
    let DecibelMilliwatt =
        Prefixed_Name(iottaxolite, "DecibelMilliwatt") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DegreeAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A plane angle unit which is equal to 1/360 of a full rotation or pi/180 rad.</para>
    /// labels<para>Degree Angle</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeAngle">http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeAngle</seealso>
    let DegreeAngle = Prefixed_Name(iottaxolite, "DegreeAngle") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DegreeCelsius</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A temperature unit which is equal to one kelvin degree. However, they have their zeros at different points. The centigrade scale has its zero at 273.15 K.</para>
    /// labels<para>Degree Celsius</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeCelsius">http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeCelsius</seealso>
    let DegreeCelsius = Prefixed_Name(iottaxolite, "DegreeCelsius") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DegreeFahrenheit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurement Unit to represent temperature on the Fahrenheit scale.</para>
    /// labels<para>Degree Fahrenheit</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeFahrenheit">http://purl.org/iot/vocab/iot-taxonomy-lite#DegreeFahrenheit</seealso>
    let DegreeFahrenheit =
        Prefixed_Name(iottaxolite, "DegreeFahrenheit") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DewPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the temperature to which air must be cooled at constant pressure to condense to form liquid.</para>
    /// labels<para>Dew Point</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPoint">http://purl.org/iot/vocab/iot-taxonomy-lite#DewPoint</seealso>
    let DewPoint = Prefixed_Name(iottaxolite, "DewPoint") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DeltaDewPointSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that measures the difference between Dewpoint and surface temperatures.</para>
    /// labels<para>Delta Dew Point Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPointSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPointSensor</seealso>
    let DeltaDewPointSensor =
        Prefixed_Name(iottaxolite, "DeltaDewPointSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DeviceUptimeClock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that measures time a device is working and is available.</para>
    /// labels<para>Device Uptime Clock</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptimeClock">http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptimeClock</seealso>
    let DeviceUptimeClock =
        Prefixed_Name(iottaxolite, "DeviceUptimeClock") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceStateParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The presence or absence of a vehicle parked.</para>
    /// labels<para>Presence State Parking</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateParking">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceStateParking</seealso>
    let PresenceStateParking =
        Prefixed_Name(iottaxolite, "PresenceStateParking") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PublicTransit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the source of the sound was public transit.</para>
    /// labels<para>Public Transit Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PublicTransit">http://purl.org/iot/vocab/iot-taxonomy-lite#PublicTransit</seealso>
    let PublicTransit = Prefixed_Name(iottaxolite, "PublicTransit") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:PulseOxymeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Pulse Oxymeter, SpO2, Blood Oxygen Saturation Sensor are used to measure the concentration of oxygen in the blood.</para>
    /// labels<para>Pulse Oxymeter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PulseOxymeter">http://purl.org/iot/vocab/iot-taxonomy-lite#PulseOxymeter</seealso>
    let PulseOxymeter = Prefixed_Name(iottaxolite, "PulseOxymeter") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:RadianPerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The radian per second is defined as the change in the orientation of an object, in radians, every second. The radian per second is the SI unit of angular (rotational) speed.</para>
    /// labels<para>Radian Per Second</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RadianPerSecond">http://purl.org/iot/vocab/iot-taxonomy-lite#RadianPerSecond</seealso>
    let RadianPerSecond = Prefixed_Name(iottaxolite, "RadianPerSecond") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BoardTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of board temperature.</para>
    /// labels<para>Board Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#BoardTemperature</seealso>
    let BoardTemperature =
        Prefixed_Name(iottaxolite, "BoardTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BoardVoltageSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to measure board input voltage.</para>
    /// labels<para>Board Voltage Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BoardVoltageSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#BoardVoltageSensor</seealso>
    let BoardVoltageSensor =
        Prefixed_Name(iottaxolite, "BoardVoltageSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BodyTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of body temperature.</para>
    /// labels<para>Body Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#BodyTemperature</seealso>
    let BodyTemperature = Prefixed_Name(iottaxolite, "BodyTemperature") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Degree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Degree.</para>
    /// labels<para>Degree</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Degree">http://purl.org/iot/vocab/iot-taxonomy-lite#Degree</seealso>
    let Degree = Prefixed_Name(iottaxolite, "Degree") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DeltaDewPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Difference between Dewpoint and surface temperatures.</para>
    /// labels<para>Delta Dew Point</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPoint">http://purl.org/iot/vocab/iot-taxonomy-lite#DeltaDewPoint</seealso>
    let DeltaDewPoint = Prefixed_Name(iottaxolite, "DeltaDewPoint") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:HeartBeatSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device to count heart beats per minute.</para>
    /// labels<para>Heart Beat Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeatSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#HeartBeatSensor</seealso>
    let HeartBeatSensor = Prefixed_Name(iottaxolite, "HeartBeatSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Hertz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The SI unit of frequency, equal to one cycle per second.</para>
    /// labels<para>Hertz</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Hertz">http://purl.org/iot/vocab/iot-taxonomy-lite#Hertz</seealso>
    let Hertz = Prefixed_Name(iottaxolite, "Hertz") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:PresenceDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect if on object is occupied or not.</para>
    /// labels<para>Presence Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#PresenceDetector</seealso>
    let PresenceDetector =
        Prefixed_Name(iottaxolite, "PresenceDetector") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Humidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quantity representing the amount of water vapour in the atmosphere or in a gas.</para>
    /// labels<para>Humidity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Humidity">http://purl.org/iot/vocab/iot-taxonomy-lite#Humidity</seealso>
    let Humidity = Prefixed_Name(iottaxolite, "Humidity") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:VoltageSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device which can measure the difference in electric potential energy between two points per unit electric charge.</para>
    /// labels<para>Voltage Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltageSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#VoltageSensor</seealso>
    let VoltageSensor = Prefixed_Name(iottaxolite, "VoltageSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:BodyThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure body temperature.</para>
    /// labels<para>Body Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BodyThermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#BodyThermometer</seealso>
    let BodyThermometer = Prefixed_Name(iottaxolite, "BodyThermometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Boiler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the boiler.</para>
    /// labels<para>Boiler Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Boiler">http://purl.org/iot/vocab/iot-taxonomy-lite#Boiler</seealso>
    let Boiler = Prefixed_Name(iottaxolite, "Boiler") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BuildingAutomation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Smart Home/Building Automation as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Smart Building DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingAutomation">http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingAutomation</seealso>
    let BuildingAutomation =
        Prefixed_Name(iottaxolite, "BuildingAutomation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:BuildingTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of building or room temperature.</para>
    /// labels<para>Building/Room Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#BuildingTemperature</seealso>
    let BuildingTemperature =
        Prefixed_Name(iottaxolite, "BuildingTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DiscoverObservsation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action related to finding observsations either of a particular kind or all.</para>
    /// labels<para>Discover Observsation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverObservsation">http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverObservsation</seealso>
    let DiscoverObservsation =
        Prefixed_Name(iottaxolite, "DiscoverObservsation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DishWasher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the dishwasher.</para>
    /// labels<para>Dish Washer Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DishWasher">http://purl.org/iot/vocab/iot-taxonomy-lite#DishWasher</seealso>
    let DishWasher = Prefixed_Name(iottaxolite, "DishWasher") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DistanceNextBus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Estimated driving distance (in meters) between a bus and the next bus stop. </para>
    /// labels<para>Driving distance between a bus and the next bus stop</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBus">http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBus</seealso>
    let DistanceNextBus = Prefixed_Name(iottaxolite, "DistanceNextBus") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DistanceNextBusSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Virtual device that represents a bus stop X and a bus line Y; it measures the driving distance between the next bus (belonging to line Y) and the bus stop X. </para>
    /// labels<para>Sensor measuring the driving distance between a bus and the next bus stop</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBusSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceNextBusSensor</seealso>
    let DistanceNextBusSensor =
        Prefixed_Name(iottaxolite, "DistanceNextBusSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DistanceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Distance Sensor is used to detect distance between two objects for example:  the safety distance with other cars. Distance sensor can be a laser.</para>
    /// labels<para>Distance Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DistanceSensor</seealso>
    let DistanceSensor = Prefixed_Name(iottaxolite, "DistanceSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Seismometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Seismometers are instruments that measure motions of the ground, including those of seismic waves generated by earthquakes, volcanic eruptions, and other seismic sources.</para>
    /// labels<para>Seismometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Seismometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Seismometer</seealso>
    let Seismometer = Prefixed_Name(iottaxolite, "Seismometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ShakeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Shake sensor is used to deduce the quality of the road, earthquakes.</para>
    /// labels<para>Shake Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ShakeSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ShakeSensor</seealso>
    let ShakeSensor = Prefixed_Name(iottaxolite, "ShakeSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SiemensPerMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Conductivity is measured in Siemens per metre (S/m).</para>
    /// labels<para>Siemens Per Metre, Siemens Per Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SiemensPerMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#SiemensPerMetre</seealso>
    let SiemensPerMetre = Prefixed_Name(iottaxolite, "SiemensPerMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SkinConductanceSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Skin Conductance.</para>
    /// labels<para>Skin Conductance Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductanceSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductanceSensor</seealso>
    let SkinConductanceSensor =
        Prefixed_Name(iottaxolite, "SkinConductanceSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SleepSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sleep Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SleepSensor</seealso>
    let SleepSensor = Prefixed_Name(iottaxolite, "SleepSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SleepMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sleep monitor sensor which tracks the human sleep state.</para>
    /// labels<para>Sleep Monitor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepMonitor">http://purl.org/iot/vocab/iot-taxonomy-lite#SleepMonitor</seealso>
    let SleepMonitor = Prefixed_Name(iottaxolite, "SleepMonitor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DeviceUptime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Time a device is working and is available</para>
    /// labels<para>Device Uptime</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptime">http://purl.org/iot/vocab/iot-taxonomy-lite#DeviceUptime</seealso>
    let DeviceUptime = Prefixed_Name(iottaxolite, "DeviceUptime") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DewPointTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The temperature at which dew forms and is a measure of atmospheric moisture. It is the temperature to which air must be cooled at constant pressure and water content to reach saturation. A higher dew point indicates more moisture in the air; a dew point greater than 20 Degree C (68 Degree F) is considered uncomfortable and greater than 22 Degree C (72 Degree F) is considered to be extremely humid.</para>
    /// labels<para>Dew Point Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointTemperature</seealso>
    let DewPointTemperature =
        Prefixed_Name(iottaxolite, "DewPointTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Dimensionless</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Without dimensions; having no appreciable or noteworthy extent. Without physical meaning.</para>
    /// labels<para>Dimensionless</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Dimensionless">http://purl.org/iot/vocab/iot-taxonomy-lite#Dimensionless</seealso>
    let Dimensionless = Prefixed_Name(iottaxolite, "Dimensionless") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measurements of sensors are affected by the direction of the sensing device. This concept is used to reflect it.</para>
    /// labels<para>Direction</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Direction">http://purl.org/iot/vocab/iot-taxonomy-lite#Direction</seealso>
    let Direction = Prefixed_Name(iottaxolite, "Direction") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DirectionHeading</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The course or direction in which a object (vehicle, person, ...) is moving.</para>
    /// labels<para>Direction Heading</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionHeading">http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionHeading</seealso>
    let DirectionHeading =
        Prefixed_Name(iottaxolite, "DirectionHeading") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DirectionOfArrivalSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that estimates the azimuth direction of sources relative to the sensor’s position.</para>
    /// labels<para>Direction Of Arrival (DOA) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrivalSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrivalSensor</seealso>
    let DirectionOfArrivalSensor =
        Prefixed_Name(iottaxolite, "DirectionOfArrivalSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:RotationalSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rotational speed (or speed of revolution) of an object rotating around an axis is the number of turns of the object divided by time, specified as revolutions per minute (rpm), revolutions per second (rev/s), or radians per second (rad/s). (Source Wikipedia)</para>
    /// labels<para>Rotational Speed</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeed">http://purl.org/iot/vocab/iot-taxonomy-lite#RotationalSpeed</seealso>
    let RotationalSpeed = Prefixed_Name(iottaxolite, "RotationalSpeed") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SaltMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device use to detect salinity of water.</para>
    /// labels<para>Salt Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SaltMeter">http://purl.org/iot/vocab/iot-taxonomy-lite#SaltMeter</seealso>
    let SaltMeter = Prefixed_Name(iottaxolite, "SaltMeter") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Scale</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Arbitrary indirect reference which should be translated into meaningful measurements by using the corresponding decoding algorithm detailed in the resource description. In this case the returned values are part of a continuous variable which can take any numeric value.</para>
    /// labels<para>Scale</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Scale">http://purl.org/iot/vocab/iot-taxonomy-lite#Scale</seealso>
    let Scale = Prefixed_Name(iottaxolite, "Scale") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DewPointSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that measures dew point.</para>
    /// labels<para>Dew Point Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DewPointSensor</seealso>
    let DewPointSensor = Prefixed_Name(iottaxolite, "DewPointSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DiastolicBloodPressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Measure of the pressure in the arteries when the heart rests between beats.</para>
    /// labels<para>Diastolic Blood Pressure</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiastolicBloodPressure">http://purl.org/iot/vocab/iot-taxonomy-lite#DiastolicBloodPressure</seealso>
    let DiastolicBloodPressure =
        Prefixed_Name(iottaxolite, "DiastolicBloodPressure") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DirectionAzimuth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The geodetic azimuth of the direction towards which an object is point to.</para>
    /// labels<para>Direction Azimuth</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionAzimuth">http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionAzimuth</seealso>
    let DirectionAzimuth =
        Prefixed_Name(iottaxolite, "DirectionAzimuth") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DirectionOfArrival</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The azimuth direction of a  source relative to the azimuth direction of the DOA sensor.</para>
    /// labels<para>Direction Of Arrival</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrival">http://purl.org/iot/vocab/iot-taxonomy-lite#DirectionOfArrival</seealso>
    let DirectionOfArrival =
        Prefixed_Name(iottaxolite, "DirectionOfArrival") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DiscoverSensors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discover sensors in a given context</para>
    /// labels<para>Discover Sensors</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverSensors">http://purl.org/iot/vocab/iot-taxonomy-lite#DiscoverSensors</seealso>
    let DiscoverSensors = Prefixed_Name(iottaxolite, "DiscoverSensors") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Distance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of how far apart objects are.</para>
    /// labels<para>Distance</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Distance">http://purl.org/iot/vocab/iot-taxonomy-lite#Distance</seealso>
    let Distance = Prefixed_Name(iottaxolite, "Distance") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:KnowSensorsInTheArea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose to know sensors in the given area</para>
    /// labels<para>Know Sensors In The Area</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#KnowSensorsInTheArea">http://purl.org/iot/vocab/iot-taxonomy-lite#KnowSensorsInTheArea</seealso>
    let KnowSensorsInTheArea =
        Prefixed_Name(iottaxolite, "KnowSensorsInTheArea") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:LeafWetnessSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Leaf Wetness Sensor is used in agriculture to check whether the plants need to be watered.</para>
    /// labels<para>Leaf Wetness Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetnessSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#LeafWetnessSensor</seealso>
    let LeafWetnessSensor =
        Prefixed_Name(iottaxolite, "LeafWetnessSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:LitrePer100Kilometres</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A consumption unit which is equal to the one of a vehicle which needs 1 fuel litre in order to traverse 100 kilometres.</para>
    /// labels<para>Litre Per 100 Kilometres, Liter Per 100 Kilometers</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#LitrePer100Kilometres">http://purl.org/iot/vocab/iot-taxonomy-lite#LitrePer100Kilometres</seealso>
    let LitrePer100Kilometres =
        Prefixed_Name(iottaxolite, "LitrePer100Kilometres") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Lumen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The SI unit of luminous flux, equal to the amount of light emitted per second in a unit solid angle of one steradian from a uniform source of one candela.</para>
    /// labels<para>Lumen (lm)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lumen">http://purl.org/iot/vocab/iot-taxonomy-lite#Lumen</seealso>
    let Lumen = Prefixed_Name(iottaxolite, "Lumen") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Lux</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The SI unit of illuminance, equal to one lumen per square metre.</para>
    /// labels<para>Lux (lx)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Lux">http://purl.org/iot/vocab/iot-taxonomy-lite#Lux</seealso>
    let Lux = Prefixed_Name(iottaxolite, "Lux") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Sirens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When source of the sound were sirens either from ambulance, police car or factory etc.</para>
    /// labels<para>Sirens Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sirens">http://purl.org/iot/vocab/iot-taxonomy-lite#Sirens</seealso>
    let Sirens = Prefixed_Name(iottaxolite, "Sirens") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:CO2Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Carbon Dioxide (CO2) Sensor used to measure level of CO2 in the atmosphere.</para>
    /// labels<para>Carbon Dioxide (CO2) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2Sensor">http://purl.org/iot/vocab/iot-taxonomy-lite#CO2Sensor</seealso>
    let CO2Sensor = Prefixed_Name(iottaxolite, "CO2Sensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Calcium</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of blood calcium level.</para>
    /// labels<para>Calcium Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Calcium">http://purl.org/iot/vocab/iot-taxonomy-lite#Calcium</seealso>
    let Calcium = Prefixed_Name(iottaxolite, "Calcium") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CalculateEnergyConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose of calculating energy consumption by a resource.</para>
    /// labels<para>Calculate Energy Consumption</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalculateEnergyConsumption">http://purl.org/iot/vocab/iot-taxonomy-lite#CalculateEnergyConsumption</seealso>
    let CalculateEnergyConsumption =
        Prefixed_Name(iottaxolite, "CalculateEnergyConsumption") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Candela</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Candela is the luminous intensity, in a given direction, of a source that emits monochromatic radiation of frequency 540 x 10^12 hertz and that has a radiant intensity in that direction of 1/683 watt per steradian. (Source Wikipedia).</para>
    /// labels<para>Candela</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Candela">http://purl.org/iot/vocab/iot-taxonomy-lite#Candela</seealso>
    let Candela = Prefixed_Name(iottaxolite, "Candela") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Capacitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the ability of a system to store an electric charge.</para>
    /// labels<para>Capacitance</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Capacitance">http://purl.org/iot/vocab/iot-taxonomy-lite#Capacitance</seealso>
    let Capacitance = Prefixed_Name(iottaxolite, "Capacitance") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricalResistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The electrical resistance of an electrical conductor is the opposition to the passage of an electric current through that conductor.</para>
    /// labels<para>Electrical Resistance</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalResistance">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalResistance</seealso>
    let ElectricalResistance =
        Prefixed_Name(iottaxolite, "ElectricalResistance") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricalSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that measures the changes in electrical or magnetic signals based on an environmental input.</para>
    /// labels<para>Electrical Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricalSensor</seealso>
    let ElectricalSensor =
        Prefixed_Name(iottaxolite, "ElectricalSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Emotion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Affective Science, Emotion, Mood, Emotional State, Brain Wave as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Emotion DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Emotion">http://purl.org/iot/vocab/iot-taxonomy-lite#Emotion</seealso>
    let Emotion = Prefixed_Name(iottaxolite, "Emotion") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Energy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Energy is the property that must be transferred to an object in order to perform work on. (Source Wikipedia).</para>
    /// labels<para>Energy</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Energy">http://purl.org/iot/vocab/iot-taxonomy-lite#Energy</seealso>
    let Energy = Prefixed_Name(iottaxolite, "Energy") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:EnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor to measure power or energy consumption.</para>
    /// labels<para>Energy Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyMeter">http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyMeter</seealso>
    let EnergyMeter = Prefixed_Name(iottaxolite, "EnergyMeter") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:EnterRoom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose for requesting to enter a room.</para>
    /// labels<para>Enter Room</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnterRoom">http://purl.org/iot/vocab/iot-taxonomy-lite#EnterRoom</seealso>
    let EnterRoom = Prefixed_Name(iottaxolite, "EnterRoom") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Environment (earthquake, flooding, fire, pollution) as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Environment DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Environment">http://purl.org/iot/vocab/iot-taxonomy-lite#Environment</seealso>
    let Environment = Prefixed_Name(iottaxolite, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:KiloWattHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of electrical energy equivalent to a power consumption of one thousand watts for one hour.</para>
    /// labels<para>Kilo Watt Hour</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#KiloWattHour">http://purl.org/iot/vocab/iot-taxonomy-lite#KiloWattHour</seealso>
    let KiloWattHour = Prefixed_Name(iottaxolite, "KiloWattHour") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Kilogram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The SI unit of mass, it is equal to the mass of the international prototype of the kilogram.</para>
    /// labels<para>Kilogram (kg)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Kilogram">http://purl.org/iot/vocab/iot-taxonomy-lite#Kilogram</seealso>
    let Kilogram = Prefixed_Name(iottaxolite, "Kilogram") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:MetrePerSecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A speed/velocity unit which is equal to the speed of an object traveling 1 metre distance in one second.</para>
    /// labels<para>Metre Per Second, Meter Per Second  (m/s)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecond">http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecond</seealso>
    let MetrePerSecond = Prefixed_Name(iottaxolite, "MetrePerSecond") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SeatBeltTensionSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para> Actuator used to turn Seat Belt Tension Actuator on or off. </para>
    /// labels<para>Seat Belt Tension Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SeatBeltTensionSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SeatBeltTensionSensor</seealso>
    let SeatBeltTensionSensor =
        Prefixed_Name(iottaxolite, "SeatBeltTensionSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SecondAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of angular measurement equal to 1/60 of one degree.</para>
    /// labels<para>Second Angle</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SecondAngle">http://purl.org/iot/vocab/iot-taxonomy-lite#SecondAngle</seealso>
    let SecondAngle = Prefixed_Name(iottaxolite, "SecondAngle") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Shower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the shower.</para>
    /// labels<para>Shower Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Shower">http://purl.org/iot/vocab/iot-taxonomy-lite#Shower</seealso>
    let Shower = Prefixed_Name(iottaxolite, "Shower") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Sink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the sink.</para>
    /// labels<para>Sink Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sink">http://purl.org/iot/vocab/iot-taxonomy-lite#Sink</seealso>
    let Sink = Prefixed_Name(iottaxolite, "Sink") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SkinConductance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electroderal activity (also known as skin conductance or galvanic skin response) directly correlates to the sympathetic nervous system activity and thus provides a powerful tool for monitoring arousal and certain aspects of autonomic regulation.</para>
    /// labels<para>Skin conductance, GSR</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductance">http://purl.org/iot/vocab/iot-taxonomy-lite#SkinConductance</seealso>
    let SkinConductance = Prefixed_Name(iottaxolite, "SkinConductance") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SleepDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sleep detector sensor which detects whether the human falls asleep or wakes up.</para>
    /// labels<para>Sleep Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#SleepDetector</seealso>
    let SleepDetector = Prefixed_Name(iottaxolite, "SleepDetector") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SleepState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sleep State</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SleepState">http://purl.org/iot/vocab/iot-taxonomy-lite#SleepState</seealso>
    let SleepState = Prefixed_Name(iottaxolite, "SleepState") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SmokeDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect if there is a fire or the smoke.</para>
    /// labels<para>Smoke Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SmokeDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#SmokeDetector</seealso>
    let SmokeDetector = Prefixed_Name(iottaxolite, "SmokeDetector") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:SoilHumidity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the quantity of water contained in a material, such as soil. </para>
    /// labels<para>Soil Humidity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumidity">http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumidity</seealso>
    let SoilHumidity = Prefixed_Name(iottaxolite, "SoilHumidity") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:CO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Carbon Dioxide (CO2) measure in the atmosphere.</para>
    /// labels<para>Carbon Dioxide (CO2) Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CO2">http://purl.org/iot/vocab/iot-taxonomy-lite#CO2</seealso>
    let CO2 = Prefixed_Name(iottaxolite, "CO2") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Magnetometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A magnetometer is an device that measures magnetism—either magnetization of magnetic material like a ferromagnet, or the strength and, in some cases, direction of the magnetic field at a point in space. (Source Wikipedia).</para>
    /// labels<para>Magnetometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Magnetometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Magnetometer</seealso>
    let Magnetometer = Prefixed_Name(iottaxolite, "Magnetometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Meeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose for either arranging a meeting or actually meeting someone.</para>
    /// labels<para>Meeting</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Meeting">http://purl.org/iot/vocab/iot-taxonomy-lite#Meeting</seealso>
    let Meeting = Prefixed_Name(iottaxolite, "Meeting") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:MethaneSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Methane in the environment.</para>
    /// labels<para>Methane (CH4) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MethaneSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#MethaneSensor</seealso>
    let MethaneSensor = Prefixed_Name(iottaxolite, "MethaneSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Sound</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of noise level in the environment</para>
    /// labels<para>Sound, Noise Level</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Sound">http://purl.org/iot/vocab/iot-taxonomy-lite#Sound</seealso>
    let Sound = Prefixed_Name(iottaxolite, "Sound") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the door.</para>
    /// labels<para>Door Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Door">http://purl.org/iot/vocab/iot-taxonomy-lite#Door</seealso>
    let Door = Prefixed_Name(iottaxolite, "Door") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DoorStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes if a door is OPEN or CLOSED.</para>
    /// labels<para>Door Status</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStatus">http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStatus</seealso>
    let DoorStatus = Prefixed_Name(iottaxolite, "DoorStatus") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:DustSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sensing device that measures dust particle concentration.</para>
    /// labels<para>Dust Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DustSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DustSensor</seealso>
    let DustSensor = Prefixed_Name(iottaxolite, "DustSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ESP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The actuator for turning ESP on/off.</para>
    /// labels<para>ESP (Electronic Stability Program) Actuating device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ESP">http://purl.org/iot/vocab/iot-taxonomy-lite#ESP</seealso>
    let ESP = Prefixed_Name(iottaxolite, "ESP") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ElectricCurrent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electric current is the flow of electric charge. It is a base quantity in the International System of Units. Electric current is electric charge divided by time. Electric Current is the flow (movement) of electric charge. The amount of electric current through some surface, e.g., a section through a copper conductor, is defined as the amount of electric charge flowing through that surface over time.</para>
    /// labels<para>Electric Current</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCurrent">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCurrent</seealso>
    let ElectricCurrent = Prefixed_Name(iottaxolite, "ElectricCurrent") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ElectricField</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electric field is the electric force per unit charge.</para>
    /// labels<para>Electric Field</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField</seealso>
    let ElectricField = Prefixed_Name(iottaxolite, "ElectricField") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricField2100MHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2100 MHz UHF band.</para>
    /// labels<para>Electric Field 2100 MHz</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2100MHz">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2100MHz</seealso>
    let ElectricField2100MHz =
        Prefixed_Name(iottaxolite, "ElectricField2100MHz") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricField2400MHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 2400 MHz UHF band.</para>
    /// labels<para>Electric Field 2400 MHz</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2400MHz">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField2400MHz</seealso>
    let ElectricField2400MHz =
        Prefixed_Name(iottaxolite, "ElectricField2400MHz") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricField900Mhz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 900 MHz UHF band.</para>
    /// labels<para>Electric Field 900 MHz</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField900Mhz">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField900Mhz</seealso>
    let ElectricField900Mhz =
        Prefixed_Name(iottaxolite, "ElectricField900Mhz") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricPotential</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Electric potential is the potential energy per unit charge associated with static (time-invariant) electric field.</para>
    /// labels<para>Electric Potential</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricPotential">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricPotential</seealso>
    let ElectricPotential =
        Prefixed_Name(iottaxolite, "ElectricPotential") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Microampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of electric current, or amount of electric charge per second.</para>
    /// labels<para>Microampere (uA)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microampere">http://purl.org/iot/vocab/iot-taxonomy-lite#Microampere</seealso>
    let Microampere = Prefixed_Name(iottaxolite, "Microampere") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Microgram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of mass equal to one billionth (1×10^−9) of a kilogram.</para>
    /// labels<para>Microgram (ug)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microgram">http://purl.org/iot/vocab/iot-taxonomy-lite#Microgram</seealso>
    let Microgram = Prefixed_Name(iottaxolite, "Microgram") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Volt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The SI unit of electromotive force, the difference of potential that would carry one ampere of current against one ohm resistance.</para>
    /// labels<para>Volt</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Volt">http://purl.org/iot/vocab/iot-taxonomy-lite#Volt</seealso>
    let Volt = Prefixed_Name(iottaxolite, "Volt") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Microwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of power.</para>
    /// labels<para>Microwatt (uW)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwatt">http://purl.org/iot/vocab/iot-taxonomy-lite#Microwatt</seealso>
    let Microwatt = Prefixed_Name(iottaxolite, "Microwatt") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Microwave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the Microwave.</para>
    /// labels<para>Microwave Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microwave">http://purl.org/iot/vocab/iot-taxonomy-lite#Microwave</seealso>
    let Microwave = Prefixed_Name(iottaxolite, "Microwave") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Mileage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the number of miles or the average distance that a vehicle can travel on a specified quantity of fuel</para>
    /// labels<para>Mileage</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Mileage">http://purl.org/iot/vocab/iot-taxonomy-lite#Mileage</seealso>
    let Mileage = Prefixed_Name(iottaxolite, "Mileage") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Miles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of length that is equal to 1,760 yards (approx. 1.609 kilometres).</para>
    /// labels<para>Miles</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Miles">http://purl.org/iot/vocab/iot-taxonomy-lite#Miles</seealso>
    let Miles = Prefixed_Name(iottaxolite, "Miles") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SunPositionDirectionSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to detect sun position.</para>
    /// labels<para>Sun Position Direction Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirectionSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirectionSensor</seealso>
    let SunPositionDirectionSensor =
        Prefixed_Name(iottaxolite, "SunPositionDirectionSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:GaseousPollutantSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect poisonous gaseous in the environment.</para>
    /// labels<para>Gaseous Pollutant Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GaseousPollutantSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#GaseousPollutantSensor</seealso>
    let GaseousPollutantSensor =
        Prefixed_Name(iottaxolite, "GaseousPollutantSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:DoorStateSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This sensor detects if a door is in the state of OPEN or CLOSED.</para>
    /// labels<para>Door State Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStateSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#DoorStateSensor</seealso>
    let DoorStateSensor = Prefixed_Name(iottaxolite, "DoorStateSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Drawer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the drawer.</para>
    /// labels<para>Drawer Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Drawer">http://purl.org/iot/vocab/iot-taxonomy-lite#Drawer</seealso>
    let Drawer = Prefixed_Name(iottaxolite, "Drawer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:EAQI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Unit to measure Air Quality in European cities.</para>
    /// labels<para>European Air Quality Index (EAQI)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#EAQI">http://purl.org/iot/vocab/iot-taxonomy-lite#EAQI</seealso>
    let EAQI = Prefixed_Name(iottaxolite, "EAQI") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ElectricCharge</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the physical property of matter that causes it to experience a force when placed in an electromagnetic field. (Source Wikipedia).</para>
    /// labels<para>Electric Charge</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCharge">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricCharge</seealso>
    let ElectricCharge = Prefixed_Name(iottaxolite, "ElectricCharge") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricField1800MHz</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A field of force associated with a moving electric charge equivalent to an electric field and a magnetic field at right angles to each other and to the direction of propagation. Applied to the 1800 MHz UHF band.</para>
    /// labels<para>Electric Field 1800 MHz</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField1800MHz">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricField1800MHz</seealso>
    let ElectricField1800MHz =
        Prefixed_Name(iottaxolite, "ElectricField1800MHz") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MeetForCoffee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose of meeting a person for a coffee or arranging a meeting</para>
    /// labels<para>Meet For Coffee</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MeetForCoffee">http://purl.org/iot/vocab/iot-taxonomy-lite#MeetForCoffee</seealso>
    let MeetForCoffee = Prefixed_Name(iottaxolite, "MeetForCoffee") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MetrePerSecondSquare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the unit of acceleration (Metre Per Second Square, Meter Per Second Square)</para>
    /// labels<para>Metre Per Second Square, Meter Per Second Square</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecondSquare">http://purl.org/iot/vocab/iot-taxonomy-lite#MetrePerSecondSquare</seealso>
    let MetrePerSecondSquare =
        Prefixed_Name(iottaxolite, "MetrePerSecondSquare") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MicrogramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Microgram per cubic metre is a unit of density defined as microgram divided by cubic metre. Milligram per cubic metre is a derived unit in the International System of Units.</para>
    /// labels<para>Microgram Per Cubic Metre, Microgram Per Cubic Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrogramPerCubicMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#MicrogramPerCubicMetre</seealso>
    let MicrogramPerCubicMetre =
        Prefixed_Name(iottaxolite, "MicrogramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Microvolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a unit of electromotive force or potential difference equal to one millionth of a volt. </para>
    /// labels<para>Microvolt (uV)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Microvolt">http://purl.org/iot/vocab/iot-taxonomy-lite#Microvolt</seealso>
    let Microvolt = Prefixed_Name(iottaxolite, "Microvolt") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MicrowattPerSquareCentimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is one of the unit for radiative and other energy fluxes.</para>
    /// labels<para>Microwatt Per Square Centimetre, Microwatt Per Square Centimeter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MicrowattPerSquareCentimetre">http://purl.org/iot/vocab/iot-taxonomy-lite#MicrowattPerSquareCentimetre</seealso>
    let MicrowattPerSquareCentimetre =
        Prefixed_Name(iottaxolite, "MicrowattPerSquareCentimetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WattPerSquareMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the SI unit for radiative and other energy fluxes.</para>
    /// labels<para>Watt Per Square Metre, Watt Per Square Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WattPerSquareMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#WattPerSquareMetre</seealso>
    let WattPerSquareMetre =
        Prefixed_Name(iottaxolite, "WattPerSquareMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MileageTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The total distance travelled by the particular vehicle since its initial production.</para>
    /// labels<para>Mileage Total</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageTotal">http://purl.org/iot/vocab/iot-taxonomy-lite#MileageTotal</seealso>
    let MileageTotal = Prefixed_Name(iottaxolite, "MileageTotal") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Milliampere</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of an ampere.</para>
    /// labels<para>Milliampere (mA)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliampere">http://purl.org/iot/vocab/iot-taxonomy-lite#Milliampere</seealso>
    let Milliampere = Prefixed_Name(iottaxolite, "Milliampere") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Millibar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of a bar.</para>
    /// labels<para>Millibar</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millibar">http://purl.org/iot/vocab/iot-taxonomy-lite#Millibar</seealso>
    let Millibar = Prefixed_Name(iottaxolite, "Millibar") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Milligram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of a gram.</para>
    /// labels<para>Milligram (mg)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milligram">http://purl.org/iot/vocab/iot-taxonomy-lite#Milligram</seealso>
    let Milligram = Prefixed_Name(iottaxolite, "Milligram") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MilligramPerCubicMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a density measurement unit.</para>
    /// labels<para>Milligram Per Cubic Metre, Milligram Per Cubic Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerCubicMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerCubicMetre</seealso>
    let MilligramPerCubicMetre =
        Prefixed_Name(iottaxolite, "MilligramPerCubicMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MilligramPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Level of Dissolved substance in liquid measured in mg per litre.</para>
    /// labels<para>Milligram Per Litre, Milligram Per Liter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerLitre">http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerLitre</seealso>
    let MilligramPerLitre =
        Prefixed_Name(iottaxolite, "MilligramPerLitre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MilligramPerSquareMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A dose unit which is equal to 1 milligram of a substance per square metre of surface area of the recipient subject.</para>
    /// labels<para>Milligram Per Square Metre, Milligram Per Square Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerSquareMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#MilligramPerSquareMetre</seealso>
    let MilligramPerSquareMetre =
        Prefixed_Name(iottaxolite, "MilligramPerSquareMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Millilitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of a litre (0.002 pint).</para>
    /// labels<para>Millilitre, Milliliter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millilitre">http://purl.org/iot/vocab/iot-taxonomy-lite#Millilitre</seealso>
    let Millilitre = Prefixed_Name(iottaxolite, "Millilitre") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Millimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of a metre (0.039 in).</para>
    /// labels<para>Millimetre, Millimeter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millimetre">http://purl.org/iot/vocab/iot-taxonomy-lite#Millimetre</seealso>
    let Millimetre = Prefixed_Name(iottaxolite, "Millimetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeRelatedStateDriverTwo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates if the second driver approaches or exceeds working time limits (or other limits).</para>
    /// labels<para>Time Related State Driver 2</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverTwo">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverTwo</seealso>
    let TimeRelatedStateDriverTwo =
        Prefixed_Name(iottaxolite, "TimeRelatedStateDriverTwo") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Timestamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sequence of characters or encoded information identifying when a certain event occurred, usually giving date and time of day, sometimes accurate to a small fraction of a second. This representation should be encoded following ISO8601.</para>
    /// labels<para>Timestamp</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Timestamp">http://purl.org/iot/vocab/iot-taxonomy-lite#Timestamp</seealso>
    let Timestamp = Prefixed_Name(iottaxolite, "Timestamp") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Transportation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Transportation, Smart Car/Vehicle, Intelligent Transport System (ITS) as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Transportation DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Transportation">http://purl.org/iot/vocab/iot-taxonomy-lite#Transportation</seealso>
    let Transportation = Prefixed_Name(iottaxolite, "Transportation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:UltrasonicSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ultrasonic sensors are used to deduce human posture in smart home for example.</para>
    /// labels<para>Ultrasonic Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#UltrasonicSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#UltrasonicSensor</seealso>
    let UltrasonicSensor =
        Prefixed_Name(iottaxolite, "UltrasonicSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VOCSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that detects levels of Volatile Organic Components (VOC) in the environment.</para>
    /// labels<para>Volatile Organic Compound (VOC) Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VOCSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#VOCSensor</seealso>
    let VOCSensor = Prefixed_Name(iottaxolite, "VOCSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Visibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The state of being able to see or be seen.</para>
    /// labels<para>Visibility</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Visibility">http://purl.org/iot/vocab/iot-taxonomy-lite#Visibility</seealso>
    let Visibility = Prefixed_Name(iottaxolite, "Visibility") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VisibilitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Visibility.</para>
    /// labels<para>Visibility Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VisibilitySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#VisibilitySensor</seealso>
    let VisibilitySensor =
        Prefixed_Name(iottaxolite, "VisibilitySensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VoiceCommand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A voice command to control a voice controlled system or environment, such as a smart home.</para>
    /// labels<para>Voice Command</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommand">http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommand</seealso>
    let VoiceCommand = Prefixed_Name(iottaxolite, "VoiceCommand") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VoiceCommandSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor that uses automatic speech recognition technology to match or reject a recorded voice command according to a specified set of available voice commands.</para>
    /// labels<para>Voice Command Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandSensor</seealso>
    let VoiceCommandSensor =
        Prefixed_Name(iottaxolite, "VoiceCommandSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VoltAmpereReactive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In electric power transmission and distribution, volt-ampere reactive (var) is a unit in which reactive power is expressed in an AC electric power system.</para>
    /// labels<para>Volt Ampere Reactive, VAR</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoltAmpereReactive">http://purl.org/iot/vocab/iot-taxonomy-lite#VoltAmpereReactive</seealso>
    let VoltAmpereReactive =
        Prefixed_Name(iottaxolite, "VoltAmpereReactive") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WashingMachine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the washing machine.</para>
    /// labels<para>Washing Machine Actuation Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WashingMachine">http://purl.org/iot/vocab/iot-taxonomy-lite#WashingMachine</seealso>
    let WashingMachine = Prefixed_Name(iottaxolite, "WashingMachine") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterConductivitySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure the conductivity of water.</para>
    /// labels<para>Water Conductivity Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterConductivitySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterConductivitySensor</seealso>
    let WaterConductivitySensor =
        Prefixed_Name(iottaxolite, "WaterConductivitySensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterNO3IonSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to measure NO3 concentration level in the water.</para>
    /// labels<para>Water NO3 Ion Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNO3IonSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterNO3IonSensor</seealso>
    let WaterNO3IonSensor =
        Prefixed_Name(iottaxolite, "WaterNO3IonSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterO2IonSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to measure O2 concentration level in the water.</para>
    /// labels<para>Water O2 Ion Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterO2IonSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterO2IonSensor</seealso>
    let WaterO2IonSensor =
        Prefixed_Name(iottaxolite, "WaterO2IonSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sea surface temperature (SST) is the water temperature close to the ocean's surface.</para>
    /// labels<para>Water Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterTemperature</seealso>
    let WaterTemperature =
        Prefixed_Name(iottaxolite, "WaterTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WaterThermometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This sensor reports Water temperature.</para>
    /// labels<para>Water Thermometer</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterThermometer">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterThermometer</seealso>
    let WaterThermometer =
        Prefixed_Name(iottaxolite, "WaterThermometer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Weather</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weather Forecasting, Meterology as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Weather Forecasting DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weather">http://purl.org/iot/vocab/iot-taxonomy-lite#Weather</seealso>
    let Weather = Prefixed_Name(iottaxolite, "Weather") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WeatherLuminosity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Luminosity in the weather</para>
    /// labels<para>Weather Luminosity</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherLuminosity">http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherLuminosity</seealso>
    let WeatherLuminosity =
        Prefixed_Name(iottaxolite, "WeatherLuminosity") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WeatherPrecipitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Weather Precipitation.</para>
    /// labels<para>Weather Precipitation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherPrecipitation">http://purl.org/iot/vocab/iot-taxonomy-lite#WeatherPrecipitation</seealso>
    let WeatherPrecipitation =
        Prefixed_Name(iottaxolite, "WeatherPrecipitation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A body's relative mass or the quantity of matter contained by it, giving rise to a downward force; the heaviness of a person or thing.</para>
    /// labels<para>Weight</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Weight">http://purl.org/iot/vocab/iot-taxonomy-lite#Weight</seealso>
    let Weight = Prefixed_Name(iottaxolite, "Weight") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:WeightSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to weight an object.</para>
    /// labels<para>Weight Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WeightSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WeightSensor</seealso>
    let WeightSensor = Prefixed_Name(iottaxolite, "WeightSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WiFiInterfaceEnergyMeter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure the average power consumption of the WiFi interface nodes.</para>
    /// labels<para>WiFi Interface Energy Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WiFiInterfaceEnergyMeter">http://purl.org/iot/vocab/iot-taxonomy-lite#WiFiInterfaceEnergyMeter</seealso>
    let WiFiInterfaceEnergyMeter =
        Prefixed_Name(iottaxolite, "WiFiInterfaceEnergyMeter") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WindChillSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect Wind Chill.</para>
    /// labels<para>Wind Chill Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChillSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WindChillSensor</seealso>
    let WindChillSensor = Prefixed_Name(iottaxolite, "WindChillSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:WindDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The geodetic azimuth of the direction from which the wind is blowing.</para>
    /// labels<para>Wind Direction</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirection">http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirection</seealso>
    let WindDirection = Prefixed_Name(iottaxolite, "WindDirection") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WindDirectionSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect wind direction.</para>
    /// labels<para>Wind Direction Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirectionSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#WindDirectionSensor</seealso>
    let WindDirectionSensor =
        Prefixed_Name(iottaxolite, "WindDirectionSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WindSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ratio of the distance covered by moving air to the time quantity taken to cover it.</para>
    /// labels<para>Wind Velocity, Wind Speed</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeed">http://purl.org/iot/vocab/iot-taxonomy-lite#WindSpeed</seealso>
    let WindSpeed = Prefixed_Name(iottaxolite, "WindSpeed") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Window</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the window.</para>
    /// labels<para>Window Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Window">http://purl.org/iot/vocab/iot-taxonomy-lite#Window</seealso>
    let Window = Prefixed_Name(iottaxolite, "Window") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:WorkingState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicator of whether a person (or object) is working or not</para>
    /// labels<para>Working State</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingState">http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingState</seealso>
    let WorkingState = Prefixed_Name(iottaxolite, "WorkingState") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WorkingStateDriver</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicator of whether the driver of a vehicle is present or not</para>
    /// labels<para>Working State Driver</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriver">http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriver</seealso>
    let WorkingStateDriver =
        Prefixed_Name(iottaxolite, "WorkingStateDriver") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WorkingStateDriverOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State of work of the first driver as defined in the FMS standard.</para>
    /// labels<para>Working State Driver 1</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverOne">http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverOne</seealso>
    let WorkingStateDriverOne =
        Prefixed_Name(iottaxolite, "WorkingStateDriverOne") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:WorkingStateDriverTwo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>State of work of the second driver as defined in the FMS standard.</para>
    /// labels<para>Working State Driver 2</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverTwo">http://purl.org/iot/vocab/iot-taxonomy-lite#WorkingStateDriverTwo</seealso>
    let WorkingStateDriverTwo =
        Prefixed_Name(iottaxolite, "WorkingStateDriverTwo") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:CalibrationSensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>If the measurement was taken when the sensor was being calibrated.</para>
    /// labels<para>Calibration Measurement Type</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#CalibrationSensing">http://purl.org/iot/vocab/iot-taxonomy-lite#CalibrationSensing</seealso>
    let CalibrationSensing =
        Prefixed_Name(iottaxolite, "CalibrationSensing") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Centibar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The centibar is a unit of pressure defined as 1e-2 bar.</para>
    /// labels<para>Centibar</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centibar">http://purl.org/iot/vocab/iot-taxonomy-lite#Centibar</seealso>
    let Centibar = Prefixed_Name(iottaxolite, "Centibar") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ErrorCorrection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Action related to finding error in the data and correcting them</para>
    /// labels<para>Error Correction</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ErrorCorrection">http://purl.org/iot/vocab/iot-taxonomy-lite#ErrorCorrection</seealso>
    let ErrorCorrection = Prefixed_Name(iottaxolite, "ErrorCorrection") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Experiment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Experiment based measurements.</para>
    /// labels<para>Experiment Measurement Type</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Experiment">http://purl.org/iot/vocab/iot-taxonomy-lite#Experiment</seealso>
    let Experiment = Prefixed_Name(iottaxolite, "Experiment") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Fair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the quality of observation is fair</para>
    /// labels<para>Fair</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fair">http://purl.org/iot/vocab/iot-taxonomy-lite#Fair</seealso>
    let Fair = Prefixed_Name(iottaxolite, "Fair") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:FallDetector</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device to detect is a person has fallen.</para>
    /// labels<para>Fall Detector</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FallDetector">http://purl.org/iot/vocab/iot-taxonomy-lite#FallDetector</seealso>
    let FallDetector = Prefixed_Name(iottaxolite, "FallDetector") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Watt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the SI unit of power, equivalent to one joule per second, corresponding to the rate of consumption of energy in an electric circuit where the potential difference is one volt and the current one ampere.</para>
    /// labels<para>Watt (W)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Watt">http://purl.org/iot/vocab/iot-taxonomy-lite#Watt</seealso>
    let Watt = Prefixed_Name(iottaxolite, "Watt") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MileageDistanceToService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The distance which can be travelled by the vehicle before the next service inspection is required.  A negative distance is transmitted if the service inspection has been passed.</para>
    /// labels<para>Mileage Distance To Service</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MileageDistanceToService">http://purl.org/iot/vocab/iot-taxonomy-lite#MileageDistanceToService</seealso>
    let MileageDistanceToService =
        Prefixed_Name(iottaxolite, "MileageDistanceToService") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rate at which someone or something moves or operates or is able to move or operate.</para>
    /// labels<para>Speed</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Speed">http://purl.org/iot/vocab/iot-taxonomy-lite#Speed</seealso>
    let Speed = Prefixed_Name(iottaxolite, "Speed") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Step</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a measure of number of Step taken.</para>
    /// labels<para>Step</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Step">http://purl.org/iot/vocab/iot-taxonomy-lite#Step</seealso>
    let Step = Prefixed_Name(iottaxolite, "Step") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SunPositionDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The position of the Sun in the sky is a function of both time and the geographic coordinates of the observer on the surface of the Earth. (Source Wikipedia).</para>
    /// labels<para>Sun Position Direction</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirection">http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionDirection</seealso>
    let SunPositionDirection =
        Prefixed_Name(iottaxolite, "SunPositionDirection") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SunPositionElevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the altitude of the sun, the angle between the horizon and the centre of the sun's disc.</para>
    /// labels<para>Sun Position Elevation</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevation">http://purl.org/iot/vocab/iot-taxonomy-lite#SunPositionElevation</seealso>
    let SunPositionElevation =
        Prefixed_Name(iottaxolite, "SunPositionElevation") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ElectricFieldSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scientific instrument for measuring electromagnetic fields (EMF). Most of them measure the electromagnetic radiation flux density (DC fields) or the change in an electromagnetic field over time (AC fields).</para>
    /// labels<para>Electric Field Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricFieldSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#ElectricFieldSensor</seealso>
    let ElectricFieldSensor =
        Prefixed_Name(iottaxolite, "ElectricFieldSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:SoilHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Soil Humidity sensor, Soil moisture, Hygrometer are an instrument used for measuring the soil moisture or soil humidity.</para>
    /// labels<para>Soil Humidity Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumiditySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#SoilHumiditySensor</seealso>
    let SoilHumiditySensor =
        Prefixed_Name(iottaxolite, "SoilHumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:EnergyDOI</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Energy or Smart Grid as an Internet of Things (IoT) applicative domain.</para>
    /// labels<para>Energy DOI</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyDOI">http://purl.org/iot/vocab/iot-taxonomy-lite#EnergyDOI</seealso>
    let EnergyDOI = Prefixed_Name(iottaxolite, "EnergyDOI") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:EnvironmentalChatbot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose to create a chatbot that could provide environment related knowledge in a userfriendly manner.</para>
    /// labels<para>Environmental Chatbot</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalChatbot">http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalChatbot</seealso>
    let EnvironmentalChatbot =
        Prefixed_Name(iottaxolite, "EnvironmentalChatbot") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:EnvironmentalDashboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose to create a dashbord that could provide environment related knowledge to the people.</para>
    /// labels<para>Environmental Dashboard</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalDashboard">http://purl.org/iot/vocab/iot-taxonomy-lite#EnvironmentalDashboard</seealso>
    let EnvironmentalDashboard =
        Prefixed_Name(iottaxolite, "EnvironmentalDashboard") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Centimetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A metric unit of length, equal to one hundredth of a metre.</para>
    /// labels<para>Centimetre, Centimeter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Centimetre">http://purl.org/iot/vocab/iot-taxonomy-lite#Centimetre</seealso>
    let Centimetre = Prefixed_Name(iottaxolite, "Centimetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:TimeRelatedStateDriverOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates if the first driver approaches or exceeds working time limits (or other limits).</para>
    /// labels<para>Time Related State Driver 1</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverOne">http://purl.org/iot/vocab/iot-taxonomy-lite#TimeRelatedStateDriverOne</seealso>
    let TimeRelatedStateDriverOne =
        Prefixed_Name(iottaxolite, "TimeRelatedStateDriverOne") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Metre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the unit of length.</para>
    /// labels<para>Metre, Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Metre">http://purl.org/iot/vocab/iot-taxonomy-lite#Metre</seealso>
    let Metre = Prefixed_Name(iottaxolite, "Metre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Chemical Agent Concentration</para>
    /// labels<para>Chemical Agent Concentration Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentConcentration">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentConcentration</seealso>
    let ChemicalAgentConcentration =
        Prefixed_Name(iottaxolite, "ChemicalAgentConcentration") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Farad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>SI unit of electrical capacitance.</para>
    /// labels<para>Farad</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Farad">http://purl.org/iot/vocab/iot-taxonomy-lite#Farad</seealso>
    let Farad = Prefixed_Name(iottaxolite, "Farad") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MillimetrePerHour</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit of both speed (scalar) and velocity (vector), defined as the distance of one millimetre travelled per unit hour.</para>
    /// labels<para>Millimetre Per Hour, Millimeter Per Hour</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillimetrePerHour">http://purl.org/iot/vocab/iot-taxonomy-lite#MillimetrePerHour</seealso>
    let MillimetrePerHour =
        Prefixed_Name(iottaxolite, "MillimetrePerHour") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Millivolt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of a volt.</para>
    /// labels<para>Millivolt (mV)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millivolt">http://purl.org/iot/vocab/iot-taxonomy-lite#Millivolt</seealso>
    let Millivolt = Prefixed_Name(iottaxolite, "Millivolt") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Milliwatt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit of power equal to one thousandth of a watt.</para>
    /// labels<para>Milliwatt (mW)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Milliwatt">http://purl.org/iot/vocab/iot-taxonomy-lite#Milliwatt</seealso>
    let Milliwatt = Prefixed_Name(iottaxolite, "Milliwatt") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:VoiceCommandController</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuating device called  that allows to semi-control the environment of the Voice Command Sensor.</para>
    /// labels<para>Voice Command Controller</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandController">http://purl.org/iot/vocab/iot-taxonomy-lite#VoiceCommandController</seealso>
    let VoiceCommandController =
        Prefixed_Name(iottaxolite, "VoiceCommandController") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Voltage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An electromotive force or potential difference expressed in volts (Source Google).</para>
    /// labels<para>Voltage</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Voltage">http://purl.org/iot/vocab/iot-taxonomy-lite#Voltage</seealso>
    let Voltage = Prefixed_Name(iottaxolite, "Voltage") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:WaterLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The height reached by the water in a reservoir, river, storage tank, or similar.</para>
    /// labels<para>Water Level</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WaterLevel">http://purl.org/iot/vocab/iot-taxonomy-lite#WaterLevel</seealso>
    let WaterLevel = Prefixed_Name(iottaxolite, "WaterLevel") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Chemical Agent Atmospheric Concentration</para>
    /// labels<para>Chemical Agent Atmospheric Concentration Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentration">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentration</seealso>
    let ChemicalAgentAtmosphericConcentration =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentration") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Fan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the source of the sound was Fan.</para>
    /// labels<para>Fan Sound Source</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Fan">http://purl.org/iot/vocab/iot-taxonomy-lite#Fan</seealso>
    let Fan = Prefixed_Name(iottaxolite, "Fan") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Millisecond</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>One thousandth of a second.</para>
    /// labels<para>Millisecond</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Millisecond">http://purl.org/iot/vocab/iot-taxonomy-lite#Millisecond</seealso>
    let Millisecond = Prefixed_Name(iottaxolite, "Millisecond") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MillivoltPerMetre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a measure of the intensity of the signal of a radio transmitter.</para>
    /// labels<para>Millivolt Per Metre, Millivolt Per Meter</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MillivoltPerMetre">http://purl.org/iot/vocab/iot-taxonomy-lite#MillivoltPerMetre</seealso>
    let MillivoltPerMetre =
        Prefixed_Name(iottaxolite, "MillivoltPerMetre") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MinuteAngle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Minute of Angle (MOA) is an angular measurement. A MOA is 1/60th of a degree.</para>
    /// labels<para>Minute Angle</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteAngle">http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteAngle</seealso>
    let MinuteAngle = Prefixed_Name(iottaxolite, "MinuteAngle") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:MinuteTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit of time equal to 60 seconds or 1/60th of an hour.</para>
    /// labels<para>Minute Time</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteTime">http://purl.org/iot/vocab/iot-taxonomy-lite#MinuteTime</seealso>
    let MinuteTime = Prefixed_Name(iottaxolite, "MinuteTime") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:MmHg</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high and now defined as precisely 133.322387415 pascals. It is denoted by the symbol mmHg. It  is used to measure blood pressure measurements (systolic and diastolic).</para>
    /// labels<para>MmHg</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MmHg">http://purl.org/iot/vocab/iot-taxonomy-lite#MmHg</seealso>
    let MmHg = Prefixed_Name(iottaxolite, "MmHg") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MobHoPrepSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Handover Preparation Success Rate.</para>
    /// labels<para>Handover Preparation Success Rate</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoPrepSuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoPrepSuccRate</seealso>
    let MobHoPrepSuccRate =
        Prefixed_Name(iottaxolite, "MobHoPrepSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MonitorTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Purpose for monitoring temperature.</para>
    /// labels<para>Monitor Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MonitorTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#MonitorTemperature</seealso>
    let MonitorTemperature =
        Prefixed_Name(iottaxolite, "MonitorTemperature") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FillLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Property used to determine the level a certain object such as waste bin is filled upto.</para>
    /// labels<para>Fill Level</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevel">http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevel</seealso>
    let FillLevel = Prefixed_Name(iottaxolite, "FillLevel") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FillLevelGasTankOne</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container. This is the value for the primary tank of the vehicle.</para>
    /// labels<para>Fill Level Gas Tank 1</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankOne">http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTankOne</seealso>
    let FillLevelGasTankOne =
        Prefixed_Name(iottaxolite, "FillLevelGasTankOne") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FillLevelWasteContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ratio between the current filleage level and the total capacity of a waste container.</para>
    /// labels<para>Fill Level Waste Container</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelWasteContainer">http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelWasteContainer</seealso>
    let FillLevelWasteContainer =
        Prefixed_Name(iottaxolite, "FillLevelWasteContainer") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FogLamp</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The actuator for turning on or off the fog lamp.</para>
    /// labels<para>Fog Lamp Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FogLamp">http://purl.org/iot/vocab/iot-taxonomy-lite#FogLamp</seealso>
    let FogLamp = Prefixed_Name(iottaxolite, "FogLamp") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MobHoExecSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Handover Execution.</para>
    /// labels<para>Handover Execution</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoExecSuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#MobHoExecSuccRate</seealso>
    let MobHoExecSuccRate =
        Prefixed_Name(iottaxolite, "MobHoExecSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:MotionState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicator of whether a person (or object) is detected upon his/her/its movement.</para>
    /// labels<para>Motion State</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#MotionState">http://purl.org/iot/vocab/iot-taxonomy-lite#MotionState</seealso>
    let MotionState = Prefixed_Name(iottaxolite, "MotionState") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:NFC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tagging device can be NFC (Near Field Communication).</para>
    /// labels<para>NFC Tagging Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#NFC">http://purl.org/iot/vocab/iot-taxonomy-lite#NFC</seealso>
    let NFC = Prefixed_Name(iottaxolite, "NFC") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:WindChill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The cooling effect of wind blowing on a surface.</para>
    /// labels<para>Wind Chill</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#WindChill">http://purl.org/iot/vocab/iot-taxonomy-lite#WindChill</seealso>
    let WindChill = Prefixed_Name(iottaxolite, "WindChill") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FillLevelGasTank</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Ratio of volume of combustible exhaust fluid to the total volume of diesel exhaust fluid storage container.</para>
    /// labels<para>Fill Level Gas Tank</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTank">http://purl.org/iot/vocab/iot-taxonomy-lite#FillLevelGasTank</seealso>
    let FillLevelGasTank =
        Prefixed_Name(iottaxolite, "FillLevelGasTank") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The IoT-Taxonomy-lite is adapted from M3-lite taxonomy. This taxonomy is refactored and defines many other concepts such as subclasses of Feature-of-Interest and Quality-of-Observation. </para>
    /// </remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#">http://purl.org/iot/vocab/iot-taxonomy-lite#</seealso>
    let _prefix_iri = Prefixed_Name(iottaxolite, "") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:ABS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The ABS (Anti-lock Braking System) receives information from ABS computer to control the pressure on the breaks, This helps the wheels not to get locked up, it adjust the break pressure and prevents the wheels from locking. (Definition Source Google).</para>
    /// labels<para>ABS (Anti-lock Braking System) Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ABS">http://purl.org/iot/vocab/iot-taxonomy-lite#ABS</seealso>
    let ABS = Prefixed_Name(iottaxolite, "ABS") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AccInitialERabEstabSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Initial E-UTRAN Radio Access Bearer establishment success rate.</para>
    /// labels<para>Initial E-RAB Establishment Success Rate</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabEstabSuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabEstabSuccRate</seealso>
    let AccInitialERabEstabSuccRate =
        Prefixed_Name(iottaxolite, "AccInitialERabEstabSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Communication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Communication related properties.</para>
    /// labels<para>Communication</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Communication">http://purl.org/iot/vocab/iot-taxonomy-lite#Communication</seealso>
    let Communication = Prefixed_Name(iottaxolite, "Communication") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AccInitialERabSetupSuccRate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Initial E-UTRAN Radio Access Bearer setup success rate.</para>
    /// labels<para>Initial E-RAB Setup Success Rate</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabSetupSuccRate">http://purl.org/iot/vocab/iot-taxonomy-lite#AccInitialERabSetupSuccRate</seealso>
    let AccInitialERabSetupSuccRate =
        Prefixed_Name(iottaxolite, "AccInitialERabSetupSuccRate") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The rate of change of the velocity of a particle with respect to time.</para>
    /// labels<para>Acceleration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Acceleration">http://purl.org/iot/vocab/iot-taxonomy-lite#Acceleration</seealso>
    let Acceleration = Prefixed_Name(iottaxolite, "Acceleration") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AccelerationInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The acceleration at a given instant of time.</para>
    /// labels<para>Instantaneous Acceleration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AccelerationInstantaneous">http://purl.org/iot/vocab/iot-taxonomy-lite#AccelerationInstantaneous</seealso>
    let AccelerationInstantaneous =
        Prefixed_Name(iottaxolite, "AccelerationInstantaneous") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ActivePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The product of the voltage across a branch of an alternating-current circuit and the component of the electric current that is in phase with the voltage.</para>
    /// labels<para>Active Power</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ActivePower">http://purl.org/iot/vocab/iot-taxonomy-lite#ActivePower</seealso>
    let ActivePower = Prefixed_Name(iottaxolite, "ActivePower") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Power</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is the rate, per unit time, at which electrical energy is transferred by an electric circuit.</para>
    /// labels<para>Power</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Power">http://purl.org/iot/vocab/iot-taxonomy-lite#Power</seealso>
    let Power = Prefixed_Name(iottaxolite, "Power") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:AirConditioner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically switch on/off the air conditioner.</para>
    /// labels<para>Air Conditioner Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirConditioner">http://purl.org/iot/vocab/iot-taxonomy-lite#AirConditioner</seealso>
    let AirConditioner = Prefixed_Name(iottaxolite, "AirConditioner") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AirHumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor used to measure air humidity.</para>
    /// labels<para>Air Humidity Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirHumiditySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#AirHumiditySensor</seealso>
    let AirHumiditySensor =
        Prefixed_Name(iottaxolite, "AirHumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:HumiditySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Humidity sensor or hygrometer is an instrument used for measuring the moisture concent in the environment.</para>
    /// labels<para>Humidity Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#HumiditySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#HumiditySensor</seealso>
    let HumiditySensor = Prefixed_Name(iottaxolite, "HumiditySensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AirPollutantSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Air Pollutant Sensor are devices that detect and monitor the presence of air pollution in the surrounding area (source Wikipedia).</para>
    /// labels<para>Air Pollutant Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollutantSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#AirPollutantSensor</seealso>
    let AirPollutantSensor =
        Prefixed_Name(iottaxolite, "AirPollutantSensor") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:AirQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Usually measured using an air quality index (AQI) that is a number used by government agencies to communicate to the public how polluted the air currently is or how polluted it is forecast to become. Different countries have their own air quality indices, corresponding to different national air quality standards. It is the measure of Air Quality of the environment. It is similar to Air Pollution. (Source Wikipedia).</para>
    /// labels<para>Air Quality Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirQuality">http://purl.org/iot/vocab/iot-taxonomy-lite#AirQuality</seealso>
    let AirQuality = Prefixed_Name(iottaxolite, "AirQuality") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:AirTemperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The temperature of the air that would be indicated by a thermometer exposed to the air at a location sheltered from direct solar radiation.</para>
    /// labels<para>Air Temperature, Weather Temperature, Ambient Temperature</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#AirTemperature">http://purl.org/iot/vocab/iot-taxonomy-lite#AirTemperature</seealso>
    let AirTemperature = Prefixed_Name(iottaxolite, "AirTemperature") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Barcode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A tagging device can be Barcode.</para>
    /// labels<para>Barcode Tagging Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Barcode">http://purl.org/iot/vocab/iot-taxonomy-lite#Barcode</seealso>
    let Barcode = Prefixed_Name(iottaxolite, "Barcode") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:BatteryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the percentage of the battery capacity that remains available.</para>
    /// labels<para>Battery Level Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#BatteryLevel">http://purl.org/iot/vocab/iot-taxonomy-lite#BatteryLevel</seealso>
    let BatteryLevel = Prefixed_Name(iottaxolite, "BatteryLevel") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationNO</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of Carbon Monoxide (CO) gas suspended in the atmosphere.</para>
    /// labels<para>Nitrogen Monoxide (NO) Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO</seealso>
    let ChemicalAgentAtmosphericConcentrationNO =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationNO") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationNO2</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of NO2 gas suspended in the atmosphere.</para>
    /// labels<para>NO2 Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO2">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationNO2</seealso>
    let ChemicalAgentAtmosphericConcentrationNO2 =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationNO2") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationO3</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The concentration of ozone (O3) gas suspended in the atmosphere.</para>
    /// labels<para>Chemical Agent Atmospheric Concentration O3</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationO3">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationO3</seealso>
    let ChemicalAgentAtmosphericConcentrationO3 =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationO3") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentAtmosphericConcentrationVOC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of the concentration of Volatile Organic Compound gas suspended in the atmosphere.</para>
    /// labels<para>Volatile Organic Compound Chemical Agent Atmospheric Concentration</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationVOC">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentAtmosphericConcentrationVOC</seealso>
    let ChemicalAgentAtmosphericConcentrationVOC =
        Prefixed_Name(iottaxolite, "ChemicalAgentAtmosphericConcentrationVOC") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:ChemicalAgentWaterConcentration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Measure of Chemical Agent Concentration in Water </para>
    /// labels<para>Chemical Agent Water Concentration Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentration">http://purl.org/iot/vocab/iot-taxonomy-lite#ChemicalAgentWaterConcentration</seealso>
    let ChemicalAgentWaterConcentration =
        Prefixed_Name(iottaxolite, "ChemicalAgentWaterConcentration") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:Freezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An actuator to automatically open/close the freezer.</para>
    /// labels<para>Freezer, Chiller Actuating Device</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Freezer">http://purl.org/iot/vocab/iot-taxonomy-lite#Freezer</seealso>
    let Freezer = Prefixed_Name(iottaxolite, "Freezer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Frequency is the number of occurrences of a repeating event per unit time.</para>
    /// labels<para>Frequency</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Frequency">http://purl.org/iot/vocab/iot-taxonomy-lite#Frequency</seealso>
    let Frequency = Prefixed_Name(iottaxolite, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:FrequencySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect the frequency.</para>
    /// labels<para>Frequency Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FrequencySensor">http://purl.org/iot/vocab/iot-taxonomy-lite#FrequencySensor</seealso>
    let FrequencySensor = Prefixed_Name(iottaxolite, "FrequencySensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:FuelConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The amount of fuel a vehicle uses to travel a particular distance at a particular speed.</para>
    /// labels<para>Fuel Consumption Quantity Kind</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumption">http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumption</seealso>
    let FuelConsumption = Prefixed_Name(iottaxolite, "FuelConsumption") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FuelConsumptionInstantaneous</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A measure that displays the instantaneous fuel consumption of a vehicle during its operation.</para>
    /// labels<para>Fuel Consumption Instantaneous</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionInstantaneous">http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionInstantaneous</seealso>
    let FuelConsumptionInstantaneous =
        Prefixed_Name(iottaxolite, "FuelConsumptionInstantaneous") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FuelConsumptionTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Accumulated amount of fuel used during vehicle operation.</para>
    /// labels<para>Fuel Consumption Total</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionTotal">http://purl.org/iot/vocab/iot-taxonomy-lite#FuelConsumptionTotal</seealso>
    let FuelConsumptionTotal =
        Prefixed_Name(iottaxolite, "FuelConsumptionTotal") |> PrefixedName

    /// <summary>
    ///   <para>iottaxolite:FuelLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect fuel level in a system such a car.</para>
    /// labels<para>Fuel Level Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#FuelLevel">http://purl.org/iot/vocab/iot-taxonomy-lite#FuelLevel</seealso>
    let FuelLevel = Prefixed_Name(iottaxolite, "FuelLevel") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:GPSSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that allows an object to localize itself.</para>
    /// labels<para>GPS Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GPSSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#GPSSensor</seealso>
    let GPSSensor = Prefixed_Name(iottaxolite, "GPSSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Gauss</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Gauss is the CGS unit of measurement of magnetic flux density (or magnetic induction) (B) (Source Wikipedia)</para>
    /// labels<para>Gauss</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gauss">http://purl.org/iot/vocab/iot-taxonomy-lite#Gauss</seealso>
    let Gauss = Prefixed_Name(iottaxolite, "Gauss") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Glucometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to detect glucometer, blood sugar, blood glucose level.</para>
    /// labels<para>Glucometer Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Glucometer">http://purl.org/iot/vocab/iot-taxonomy-lite#Glucometer</seealso>
    let Glucometer = Prefixed_Name(iottaxolite, "Glucometer") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Good</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When the quality of observation is good</para>
    /// labels<para>Good</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Good">http://purl.org/iot/vocab/iot-taxonomy-lite#Good</seealso>
    let Good = Prefixed_Name(iottaxolite, "Good") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:Gram</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It is a metric system unit of mass</para>
    /// labels<para>Gram (g)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#Gram">http://purl.org/iot/vocab/iot-taxonomy-lite#Gram</seealso>
    let Gram = Prefixed_Name(iottaxolite, "Gram") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:GramPerLitre</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>It shows how many grams of a certain substance are present in one litre of a usually liquid or gaseous mixture.</para>
    /// labels<para>Gram Per Litre, Gram Per Liter (g/L)</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerLitre">http://purl.org/iot/vocab/iot-taxonomy-lite#GramPerLitre</seealso>
    let GramPerLitre = Prefixed_Name(iottaxolite, "GramPerLitre") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:GyrometerSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A gyrometer is an instrument which measures an angular speed.</para>
    /// labels<para>Gyrometer Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyrometerSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#GyrometerSensor</seealso>
    let GyrometerSensor = Prefixed_Name(iottaxolite, "GyrometerSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:GyroscopeSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A gyroscope is a device for measuring or maintaining orientation.</para>
    /// labels<para>Gyroscope Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#GyroscopeSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#GyroscopeSensor</seealso>
    let GyroscopeSensor = Prefixed_Name(iottaxolite, "GyroscopeSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:H2SSensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device used to measure of hydrogen sulphide in the environment.</para>
    /// labels<para>H2S Sensor</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#H2SSensor">http://purl.org/iot/vocab/iot-taxonomy-lite#H2SSensor</seealso>
    let H2SSensor = Prefixed_Name(iottaxolite, "H2SSensor") |> PrefixedName
    /// <summary>
    ///   <para>iottaxolite:HDOP</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Describes the preceision of the GPS signal. Smaller the value is, more precise the signal is.</para>
    /// labels<para>Horizontal Dilution of Precision</para></remarks>
    /// <seealso href="http://purl.org/iot/vocab/iot-taxonomy-lite#HDOP">http://purl.org/iot/vocab/iot-taxonomy-lite#HDOP</seealso>
    let HDOP = Prefixed_Name(iottaxolite, "HDOP") |> PrefixedName
