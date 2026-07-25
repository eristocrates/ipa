namespace http.purl.org.vso.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module vso =
    let _namespace_iri = Namespace_Iri vso |> NamespaceIRI
    /// <summary>
    ///   <para>vso:feature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates a built-in feature, accessory, or component of the vehicle.
    ///
    /// Use DBPedia resources to indicate the features, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Anti-lock_braking_system
    ///   http://dbpedia.org/resource/Electronic_stability_control
    ///   http://dbpedia.org/resource/Armrest
    ///   http://dbpedia.org/resource/Spoiler_%28automotive%29
    ///   http://dbpedia.org/resource/CD_Changer
    ///   http://dbpedia.org/resource/Cup_holder
    ///   http://dbpedia.org/resource/Tow_hitch
    ///   http://dbpedia.org/resource/Power_window
    ///   http://dbpedia.org/resource/Power_steering
    ///   http://dbpedia.org/resource/Air_conditioner
    ///   http://dbpedia.org/resource/Child_safety_lock
    ///   http://dbpedia.org/resource/Parking_sensors
    ///
    /// See also http://en.wikipedia.org/wiki/Category:Automotive_accessories.
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:FeatureValue.</para>
    /// labels<para>feature (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#feature">http://purl.org/vso/ns#feature</seealso>
    let feature = Prefixed_Name(vso, "feature") |> PrefixedName
    /// <summary>
    ///   <para>vso:fuelConsumption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km)
    /// Typical unit code(s): LTR for liters, GLL of US Gallons, GLI for UK / Imperial Gallons
    ///
    /// Note 1: There are unfortunately no standard unit codes for "liters per 100 km". Simply use "LTR" for liters, "GLL" of US Gallons, or "GLI" for UK / Imperial Gallons, and indicate the distance in the rdfs:label of the gr:QuantitativeValueFloat or use vso:referenceDistance to model the reference distance (e.g. 100 km).
    /// Note 2: There are two ways of indicating the fuel consumption, vso:fuelConsumption (e.g. 8 liters per 100 km) and vso:fuelEconomy (e.g. 30 miles per gallon). They are reciprocal.
    /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use gr:valueReference to link the value for the fuel consumption to another value.</para>
    /// labels<para>fuelConsumption (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#fuelConsumption">http://purl.org/vso/ns#fuelConsumption</seealso>
    let fuelConsumption = Prefixed_Name(vso, "fuelConsumption") |> PrefixedName
    /// <summary>
    ///   <para>vso:Canoe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A canoe (American English) or Canadian canoe (British English) is a small narrow boat, typically human-powered, though it may also be powered by sails or small electric or gas motors.</para>
    /// labels<para>Canoe (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Canoe">http://purl.org/vso/ns#Canoe</seealso>
    let Canoe = Prefixed_Name(vso, "Canoe") |> PrefixedName
    /// <summary>
    ///   <para>vso:tongueWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The permited vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR).
    /// 	Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>tongueWeight (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#tongueWeight">http://purl.org/vso/ns#tongueWeight</seealso>
    let tongueWeight = Prefixed_Name(vso, "tongueWeight") |> PrefixedName
    /// <summary>
    ///   <para>vso:0to100KMH</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:SpeedInterval</para>
    ///   <para>The speed interval from 0 to 100 km/h</para>
    /// labels<para>0to100KMH (vso:SpeedInterval)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#0to100KMH">http://purl.org/vso/ns#0to100KMH</seealso>
    let _0to100KMH = Prefixed_Name(vso, "0to100KMH") |> PrefixedName
    /// <summary>
    ///   <para>vso:1GLI</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelQuantity</para>
    ///   <para>The fuel quantity of 1 British (imperial) gallon</para>
    /// labels<para>1GLI (vso:FuelQuantity)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#1GLI">http://purl.org/vso/ns#1GLI</seealso>
    let _1GLI = Prefixed_Name(vso, "1GLI") |> PrefixedName

    /// <summary>
    ///   <para>vso:driveWheelConfiguration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain</para>
    /// labels<para>driveWheelConfiguration (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#driveWheelConfiguration">http://purl.org/vso/ns#driveWheelConfiguration</seealso>
    let driveWheelConfiguration =
        Prefixed_Name(vso, "driveWheelConfiguration") |> PrefixedName

    /// <summary>
    ///   <para>vso:enginePower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The power of the vehicle's engine. If there are multiple engines, simply attach this property multiple times.
    /// Typical unit code(s): KWT for kilowatt
    ///
    /// Note 1: There are many different ways of measuring an engine's power. For an overview, see  http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes.
    /// Note 2: You can link to information about how the given value has been determined using the gr:valueReference property.
    /// Note 3: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>enginePower (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#enginePower">http://purl.org/vso/ns#enginePower</seealso>
    let enginePower = Prefixed_Name(vso, "enginePower") |> PrefixedName
    /// <summary>
    ///   <para>vso:engineType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of engine or engines powering the vehicle. If there are multiple engines, simply attach this property multiple times.
    ///
    /// Use DBPedia resources to indicate the engine type. Popular identifiers are
    ///   http://dbpedia.org/resource/Two-stroke_engine
    ///   http://dbpedia.org/resource/Four-stroke_engine
    ///   http://dbpedia.org/resource/Wankel_engine
    ///   http://dbpedia.org/resource/Electric_motor
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EngineTypeValue.</para>
    /// labels<para>engineType (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#engineType">http://purl.org/vso/ns#engineType</seealso>
    let engineType = Prefixed_Name(vso, "engineType") |> PrefixedName
    /// <summary>
    ///   <para>vso:MotorizedBicycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.</para>
    /// labels<para>Motorized bicycle (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#MotorizedBicycle">http://purl.org/vso/ns#MotorizedBicycle</seealso>
    let MotorizedBicycle = Prefixed_Name(vso, "MotorizedBicycle") |> PrefixedName
    /// <summary>
    ///   <para>vso:RWD</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:DriveWheelConfigurationValue</para>
    ///   <para>Rear-wheel drive is a transmission layout where the engine drives the rear wheels.</para>
    /// labels<para>Rear-wheel drive, RWD (vso:DriveWheelConfigurationValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#RWD">http://purl.org/vso/ns#RWD</seealso>
    let RWD = Prefixed_Name(vso, "RWD") |> PrefixedName
    /// <summary>
    ///   <para>vso:Rickshaw</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A rickshaw (or ricksha) is a two-wheeled cart which seats one or two persons and is being drawn by a runner.</para>
    /// labels<para>Rickshaw (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Rickshaw">http://purl.org/vso/ns#Rickshaw</seealso>
    let Rickshaw = Prefixed_Name(vso, "Rickshaw") |> PrefixedName
    /// <summary>
    ///   <para>vso:acceleration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time needed to accelerate the vehicle from a given start velocity to a given target velocity
    /// Typical unit code(s): SEC for seconds
    ///
    /// Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the rdfs:label of the gr:QuantitativeValueFloat, or use vso:referenceSpeeds with vso:0to60MPH (0..60 mph) or vso:0to100KMH (0..100 km/h) to specify the reference speeds.</para>
    /// labels<para>acceleration (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#acceleration">http://purl.org/vso/ns#acceleration</seealso>
    let acceleration = Prefixed_Name(vso, "acceleration") |> PrefixedName
    /// <summary>
    ///   <para>vso:SpeedInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating a speed interval, mostly for explaining vso:acceleration data</para>
    /// labels<para>SpeedInterval</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#SpeedInterval">http://purl.org/vso/ns#SpeedInterval</seealso>
    let SpeedInterval = Prefixed_Name(vso, "SpeedInterval") |> PrefixedName
    /// <summary>
    ///   <para>vso:damages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual description of known damages, both repaired and unrepaired.
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.</para>
    /// labels<para>damages (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#damages">http://purl.org/vso/ns#damages</seealso>
    let damages = Prefixed_Name(vso, "damages") |> PrefixedName
    /// <summary>
    ///   <para>vso:engineDisplacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. If there are multiple engines, simply attach this property multiple times.
    /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
    ///
    /// Note 1: You can link to information about how the given value has been determined using the gr:valueReference property.
    /// Note 2: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>engineDisplacement (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#engineDisplacement">http://purl.org/vso/ns#engineDisplacement</seealso>
    let engineDisplacement = Prefixed_Name(vso, "engineDisplacement") |> PrefixedName
    /// <summary>
    ///   <para>vso:engineName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A short text indicating the engine(s) of the vehicle</para>
    /// labels<para>engineName (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#engineName">http://purl.org/vso/ns#engineName</seealso>
    let engineName = Prefixed_Name(vso, "engineName") |> PrefixedName
    /// <summary>
    ///   <para>vso:Truck</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A lorry (British English) or truck (American English) is a motor vehicle designed to transport cargo.</para>
    /// labels<para>Truck (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Truck">http://purl.org/vso/ns#Truck</seealso>
    let Truck = Prefixed_Name(vso, "Truck") |> PrefixedName
    /// <summary>
    ///   <para>vso:TwoStrokeMixture</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelTypeValue</para>
    ///   <para>A pre-mixed fuel-oil mixture</para>
    /// labels<para>Two-Stroke Mixture (vso:FuelTypeValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#TwoStrokeMixture">http://purl.org/vso/ns#TwoStrokeMixture</seealso>
    let TwoStrokeMixture = Prefixed_Name(vso, "TwoStrokeMixture") |> PrefixedName
    /// <summary>
    ///   <para>vso:1GLL</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelQuantity</para>
    ///   <para>The fuel quantity of 1 US gallon</para>
    /// labels<para>1GLL (vso:FuelQuantity)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#1GLL">http://purl.org/vso/ns#1GLL</seealso>
    let _1GLL = Prefixed_Name(vso, "1GLL") |> PrefixedName
    /// <summary>
    ///   <para>vso:1LTR</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:FuelQuantity</para>
    ///   <para>The fuel quantity of 1 liter</para>
    /// labels<para>1LTR (vso:FuelQuantity)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#1LTR">http://purl.org/vso/ns#1LTR</seealso>
    let _1LTR = Prefixed_Name(vso, "1LTR") |> PrefixedName
    /// <summary>
    ///   <para>vso:AWD</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:DriveWheelConfigurationValue</para>
    ///   <para>All-wheel Drive is a transmission layout where the engine drives all four wheels.</para>
    /// labels<para>All-wheel drive (vso:DriveWheelConfigurationValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#AWD">http://purl.org/vso/ns#AWD</seealso>
    let AWD = Prefixed_Name(vso, "AWD") |> PrefixedName
    /// <summary>
    ///   <para>vso:Automobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An automobile, motor car, or car is a wheeled motor vehicle used for transporting passengers, which also carries its own engine or motor.</para>
    /// labels<para>Automobile (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Automobile">http://purl.org/vso/ns#Automobile</seealso>
    let Automobile = Prefixed_Name(vso, "Automobile") |> PrefixedName
    /// <summary>
    ///   <para>vso:Bicycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A bicycle or bike is a pedal-driven, human-powered, single-track vehicle, having two wheels attached to a frame, one behind the other. Some bicycles have a small combustion or electric engine that assists with the pedaling.</para>
    /// labels<para>Bicycle (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Bicycle">http://purl.org/vso/ns#Bicycle</seealso>
    let Bicycle = Prefixed_Name(vso, "Bicycle") |> PrefixedName
    /// <summary>
    ///   <para>vso:Vehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.</para>
    /// labels<para>Vehicle (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Vehicle">http://purl.org/vso/ns#Vehicle</seealso>
    let Vehicle = Prefixed_Name(vso, "Vehicle") |> PrefixedName
    /// <summary>
    ///   <para>vso:Boat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A boat is a watercraft of modest size designed to float or plane, to provide passage across water.</para>
    /// labels<para>Boat (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Boat">http://purl.org/vso/ns#Boat</seealso>
    let Boat = Prefixed_Name(vso, "Boat") |> PrefixedName

    /// <summary>
    ///   <para>vso:meetsEmissionStandard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that the vehicle meets the respective emission standard.
    ///
    /// Use DBPedia resources to indicate the standard, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Super_Ultra_Low_Emission_Vehicle
    ///   http://dbpedia.org/resource/Partial_zero-emissions_vehicle
    ///
    /// See also http://en.wikipedia.org/wiki/Emissions_standard.
    ///
    /// Unfortunately, there are no DBPedia identifiers for the popular Euro 1 - Euro 5 standards available.
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EmissionStandardValue.</para>
    /// labels<para>meetsEmissionStandard (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#meetsEmissionStandard">http://purl.org/vso/ns#meetsEmissionStandard</seealso>
    let meetsEmissionStandard =
        Prefixed_Name(vso, "meetsEmissionStandard") |> PrefixedName

    /// <summary>
    ///   <para>vso:modelDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The release date of a vehicle model (often used to differentiate versions of the same make and model)</para>
    /// labels<para>modelDate (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#modelDate">http://purl.org/vso/ns#modelDate</seealso>
    let modelDate = Prefixed_Name(vso, "modelDate") |> PrefixedName
    /// <summary>
    ///   <para>vso:previousOwners</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The number of previous owners of the vehicle, including the current one
    /// Typical unit code(s): C62
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.</para>
    /// labels<para>previousOwners (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#previousOwners">http://purl.org/vso/ns#previousOwners</seealso>
    let previousOwners = Prefixed_Name(vso, "previousOwners") |> PrefixedName
    /// <summary>
    ///   <para>vso:rentalUsage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Indicates whether the vehicle has been used for commercial rental. The legislation in many countries requires this information to be revealed when offering a car for sale.
    ///
    /// Note 1: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.
    /// Note 2: This property is relevant mainly for offers to SELL the vehicle (gr:hasBusinessFunction gr:Sell).</para>
    /// labels<para>rentalUsage (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#rentalUsage">http://purl.org/vso/ns#rentalUsage</seealso>
    let rentalUsage = Prefixed_Name(vso, "rentalUsage") |> PrefixedName
    /// <summary>
    ///   <para>vso:FuelQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating an amount of fuel</para>
    /// labels<para>FuelQuantity</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#FuelQuantity">http://purl.org/vso/ns#FuelQuantity</seealso>
    let FuelQuantity = Prefixed_Name(vso, "FuelQuantity") |> PrefixedName
    /// <summary>
    ///   <para>vso:4WD</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:DriveWheelConfigurationValue</para>
    ///   <para>Four-wheel Drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.</para>
    /// labels<para>Four-wheel drive (vso:DriveWheelConfigurationValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#4WD">http://purl.org/vso/ns#4WD</seealso>
    let _4WD = Prefixed_Name(vso, "4WD") |> PrefixedName

    /// <summary>
    ///   <para>vso:DriveWheelConfigurationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating which roadwheels will receive torque</para>
    /// labels<para>Drive wheel configuration value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#DriveWheelConfigurationValue">http://purl.org/vso/ns#DriveWheelConfigurationValue</seealso>
    let DriveWheelConfigurationValue =
        Prefixed_Name(vso, "DriveWheelConfigurationValue") |> PrefixedName

    /// <summary>
    ///   <para>vso:ACRISSCode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.</para>
    /// labels<para>ACRISSCode (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#ACRISSCode">http://purl.org/vso/ns#ACRISSCode</seealso>
    let ACRISSCode = Prefixed_Name(vso, "ACRISSCode") |> PrefixedName

    /// <summary>
    ///   <para>vso:MotorizedRoadVehicle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A motorized road vehicle is a wheeled land vehicle whose main propulsion is provided by an engine or motor.</para>
    /// labels<para>Motorized road vehicle (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#MotorizedRoadVehicle">http://purl.org/vso/ns#MotorizedRoadVehicle</seealso>
    let MotorizedRoadVehicle =
        Prefixed_Name(vso, "MotorizedRoadVehicle") |> PrefixedName

    /// <summary>
    ///   <para>vso:firstRegistration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of the first registration of the vehicle with the respective public authorities. This property should be used mainly with gr:ActualProductOrServiceInstance.</para>
    /// labels<para>firstRegistration (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#firstRegistration">http://purl.org/vso/ns#firstRegistration</seealso>
    let firstRegistration = Prefixed_Name(vso, "firstRegistration") |> PrefixedName
    /// <summary>
    ///   <para>vso:fuelEconomy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L)
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    ///
    /// Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter.
    /// Simply use "SMI" for statute miles (common miles in the US and UK) or "KMT" for kilometers, and indicate
    /// the fuel amount of reference in the rdfs:label of the gr:QuantitativeValueFloat, or use vso:referenceFuelQuantity with vso:1LTR (1 liter), vso:1GLL (1 US Gallon), or vso:1GLI (1 British Gallon).
    /// Note 2: In the absence of a vso:referenceFuelQuantity one may assume that the quantity of reference is 1 gallon for distances given in miles and 1 liter for distances given in kilometers. However, note that the original unit may be obscured by unit conversion services, so this heuristic is far from perfect.
    /// Note 3: There are two ways of indicating the fuel consumption, vso:fuelConsumption (e.g. 8 liters per 100 km) and vso:fuelEconomy (e.g. 30 miles per gallon). They are reciprocal.
    /// Note 4: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use gr:valueReference to link the value for the fuel economy to another value.</para>
    /// labels<para>fuelEconomy (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#fuelEconomy">http://purl.org/vso/ns#fuelEconomy</seealso>
    let fuelEconomy = Prefixed_Name(vso, "fuelEconomy") |> PrefixedName
    /// <summary>
    ///   <para>vso:fuelTankVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The volume of the fuel tank. If there are multiple tanks, this should indicate the total of all tanks.
    /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons</para>
    /// labels<para>fuelTankVolume (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#fuelTankVolume">http://purl.org/vso/ns#fuelTankVolume</seealso>
    let fuelTankVolume = Prefixed_Name(vso, "fuelTankVolume") |> PrefixedName
    /// <summary>
    ///   <para>vso:gearsTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The total number of forward and reverse gears available for the transmission system of the vehicle
    /// Typical unit code(s): C62</para>
    /// labels<para>gearsTotal (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#gearsTotal">http://purl.org/vso/ns#gearsTotal</seealso>
    let gearsTotal = Prefixed_Name(vso, "gearsTotal") |> PrefixedName
    /// <summary>
    ///   <para>vso:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The outer height of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    /// labels<para>height (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#height">http://purl.org/vso/ns#height</seealso>
    let height = Prefixed_Name(vso, "height") |> PrefixedName
    /// <summary>
    ///   <para>vso:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The outer length of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    /// labels<para>length (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#length">http://purl.org/vso/ns#length</seealso>
    let length = Prefixed_Name(vso, "length") |> PrefixedName
    /// <summary>
    ///   <para>vso:mileageFromOdometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The total distance travelled by the particular vehicle since its initial production, as read from its odometer
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.</para>
    /// labels<para>mileageFromOdometer (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#mileageFromOdometer">http://purl.org/vso/ns#mileageFromOdometer</seealso>
    let mileageFromOdometer = Prefixed_Name(vso, "mileageFromOdometer") |> PrefixedName
    /// <summary>
    ///   <para>vso:payload</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The permited weight of passengers and cargo, EXCLUDING the weight of the empty vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of vso:weight and vso:payload.
    /// Note 2: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 3: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 4: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>payload (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#payload">http://purl.org/vso/ns#payload</seealso>
    let payload = Prefixed_Name(vso, "payload") |> PrefixedName
    /// <summary>
    ///   <para>vso:productionDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The date of production of the vehicle. This property should be used mainly with gr:ActualProductOrServiceInstance.</para>
    /// labels<para>productionDate (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#productionDate">http://purl.org/vso/ns#productionDate</seealso>
    let productionDate = Prefixed_Name(vso, "productionDate") |> PrefixedName
    /// <summary>
    ///   <para>vso:referenceDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The distance to which a vso:fuelConsumption value refers</para>
    /// labels<para>referenceDistance (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#referenceDistance">http://purl.org/vso/ns#referenceDistance</seealso>
    let referenceDistance = Prefixed_Name(vso, "referenceDistance") |> PrefixedName

    /// <summary>
    ///   <para>vso:referenceFuelQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The quantity of fuel to which a vso:fuelEconomy value refers</para>
    /// labels<para>referenceFuelQuantity (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#referenceFuelQuantity">http://purl.org/vso/ns#referenceFuelQuantity</seealso>
    let referenceFuelQuantity =
        Prefixed_Name(vso, "referenceFuelQuantity") |> PrefixedName

    /// <summary>
    ///   <para>vso:referenceSpeeds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The interval of initial and target speed to which a vso:acceleration value refers</para>
    /// labels<para>referenceSpeeds (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#referenceSpeeds">http://purl.org/vso/ns#referenceSpeeds</seealso>
    let referenceSpeeds = Prefixed_Name(vso, "referenceSpeeds") |> PrefixedName
    /// <summary>
    ///   <para>vso:roofLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The permited total weight of cargo and installations (e.g. a roof rack) on top of the vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>roofLoad (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#roofLoad">http://purl.org/vso/ns#roofLoad</seealso>
    let roofLoad = Prefixed_Name(vso, "roofLoad") |> PrefixedName
    /// <summary>
    ///   <para>vso:seatingCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law
    /// Typical unit code(s): C62 for persons </para>
    /// labels<para>seatingCapacity (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#seatingCapacity">http://purl.org/vso/ns#seatingCapacity</seealso>
    let seatingCapacity = Prefixed_Name(vso, "seatingCapacity") |> PrefixedName
    /// <summary>
    ///   <para>vso:speed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by gr:hasMaxValueFloat) should be the maximum speed achievable under regular conditions.
    /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot
    ///
    /// Note 1: Use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate the range. Typically, the minimal value is zero.
    /// Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the gr:valueReference property.</para>
    /// labels<para>speed (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#speed">http://purl.org/vso/ns#speed</seealso>
    let speed = Prefixed_Name(vso, "speed") |> PrefixedName
    /// <summary>
    ///   <para>vso:steeringPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The position of the steering wheel or similar device (mostly for cars)</para>
    /// labels<para>steeringPosition (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#steeringPosition">http://purl.org/vso/ns#steeringPosition</seealso>
    let steeringPosition = Prefixed_Name(vso, "steeringPosition") |> PrefixedName
    /// <summary>
    ///   <para>vso:trailerWeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The permited weight of a trailer attached to the vehicle.
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>trailerWeight (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#trailerWeight">http://purl.org/vso/ns#trailerWeight</seealso>
    let trailerWeight = Prefixed_Name(vso, "trailerWeight") |> PrefixedName
    /// <summary>
    ///   <para>vso:transmission</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of component used for transmitting the power from a rotating power source to the wheels or propeller(s) ("gearbox" for cars).
    ///
    /// Use DBPedia resources to indicate the transmission type, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Manual_transmission
    ///   http://dbpedia.org/resource/Automatic_transmission
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:TransmissionTypeValue.</para>
    /// labels<para>transmission (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#transmission">http://purl.org/vso/ns#transmission</seealso>
    let transmission = Prefixed_Name(vso, "transmission") |> PrefixedName
    /// <summary>
    ///   <para>vso:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The weight of the empty vehicle ("curb weight" for cars), i.e. with standard equipment, all necessary operating consumables (e.g. motor oil and coolant), a full tank of fuel, while not loaded with either passengers or cargo
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: There are many varying definitions in place for specifying the weight of a vehicle. E.g., the many European Union car manufacturers include the weight of a 75 kilogram driver to follow European Directive 95/48/EC. Make sure to subtract those 75 kg when converting respective data.
    /// Note 2: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 3: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 4: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>weight (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#weight">http://purl.org/vso/ns#weight</seealso>
    let weight = Prefixed_Name(vso, "weight") |> PrefixedName
    /// <summary>
    ///   <para>vso:weightTotal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The permited total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>weightTotal (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#weightTotal">http://purl.org/vso/ns#weightTotal</seealso>
    let weightTotal = Prefixed_Name(vso, "weightTotal") |> PrefixedName
    /// <summary>
    ///   <para>vso:wheelbase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The distance between the centers of the front and rear wheels
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    /// labels<para>wheelbase (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#wheelbase">http://purl.org/vso/ns#wheelbase</seealso>
    let wheelbase = Prefixed_Name(vso, "wheelbase") |> PrefixedName
    /// <summary>
    ///   <para>vso:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The outer width of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    /// labels<para>width (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#width">http://purl.org/vso/ns#width</seealso>
    let width = Prefixed_Name(vso, "width") |> PrefixedName
    /// <summary>
    ///   <para>vso:fuelType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The type of fuel suitable for the engine or engines of the vehicle.
    ///
    /// Use DBPedia resources to indicate the fuel type. Popular identifiers are
    ///   http://dbpedia.org/resource/Gasoline
    ///   http://dbpedia.org/resource/Diesel
    ///   http://dbpedia.org/resource/Biodiesel
    ///   http://dbpedia.org/resource/Kerosene
    ///
    /// For two-stroke mixtures, use vso:TwoStrokeMixture. </para>
    /// labels<para>fuelType (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#fuelType">http://purl.org/vso/ns#fuelType</seealso>
    let fuelType = Prefixed_Name(vso, "fuelType") |> PrefixedName
    /// <summary>
    ///   <para>vso:Watercraft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A watercraft is a vehicle, vessel or craft designed to move across or through water.</para>
    /// labels<para>Watercraft (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Watercraft">http://purl.org/vso/ns#Watercraft</seealso>
    let Watercraft = Prefixed_Name(vso, "Watercraft") |> PrefixedName
    /// <summary>
    ///   <para>vso:EngineTypeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating an engine type.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Two-stroke_engine
    ///   http://dbpedia.org/resource/Four-stroke_engine
    ///   http://dbpedia.org/resource/Wankel_engine
    ///   http://dbpedia.org/resource/Electric_motor</para>
    /// labels<para>Engine type value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#EngineTypeValue">http://purl.org/vso/ns#EngineTypeValue</seealso>
    let EngineTypeValue = Prefixed_Name(vso, "EngineTypeValue") |> PrefixedName
    /// <summary>
    ///   <para>vso:FuelTypeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating a type of fuel.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Gasoline
    ///   http://dbpedia.org/resource/Diesel
    ///   http://dbpedia.org/resource/Biodiesel
    ///   http://dbpedia.org/resource/Kerosene</para>
    /// labels<para>Fuel type value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#FuelTypeValue">http://purl.org/vso/ns#FuelTypeValue</seealso>
    let FuelTypeValue = Prefixed_Name(vso, "FuelTypeValue") |> PrefixedName
    /// <summary>
    ///   <para>vso:Kayak</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A kayak is a small human-powered watercraft that traditionally has a covered deck, and one or more cockpits, each seating one paddler who strokes a double-bladed paddle. In this ontology, kayaks are considered watercrafts of their own kind, not a subtype of vso:Boat.</para>
    /// labels<para>Kayak (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Kayak">http://purl.org/vso/ns#Kayak</seealso>
    let Kayak = Prefixed_Name(vso, "Kayak") |> PrefixedName

    /// <summary>
    ///   <para>vso:SteeringPositionValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating a steering position</para>
    /// labels<para>Steering position value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#SteeringPositionValue">http://purl.org/vso/ns#SteeringPositionValue</seealso>
    let SteeringPositionValue =
        Prefixed_Name(vso, "SteeringPositionValue") |> PrefixedName

    /// <summary>
    ///   <para>vso:MotorBoat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A motorboat is a boat which is powered by an engine.</para>
    /// labels<para>Motor boat (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#MotorBoat">http://purl.org/vso/ns#MotorBoat</seealso>
    let MotorBoat = Prefixed_Name(vso, "MotorBoat") |> PrefixedName
    /// <summary>
    ///   <para>vso:BodyStyleValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating the body style of a vehicle.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Convertible
    ///   http://dbpedia.org/resource/Hatchback
    ///   http://dbpedia.org/resource/Station_wagon
    ///   http://dbpedia.org/resource/Sport_utility_vehicle
    ///   http://dbpedia.org/resource/Roadster</para>
    /// labels<para>Body style value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#BodyStyleValue">http://purl.org/vso/ns#BodyStyleValue</seealso>
    let BodyStyleValue = Prefixed_Name(vso, "BodyStyleValue") |> PrefixedName

    /// <summary>
    ///   <para>vso:EmissionStandardValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating the an emission standard.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Super_Ultra_Low_Emission_Vehicle
    ///   http://dbpedia.org/resource/Partial_zero-emissions_vehicle
    ///
    /// See also http://en.wikipedia.org/wiki/Emissions_standard.
    ///
    /// Unfortunately, there are no DBPedia identifiers for the popular Euro 1 - Euro 5 standards available.
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EmissionStandardValue.</para>
    /// labels<para>Emission standard value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#EmissionStandardValue">http://purl.org/vso/ns#EmissionStandardValue</seealso>
    let EmissionStandardValue =
        Prefixed_Name(vso, "EmissionStandardValue") |> PrefixedName

    /// <summary>
    ///   <para>vso:BusOrCoach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Buses have a capacity as high as 300 passengers and are widely used for public transportation.
    /// Coaches are luxury busses, usually in service for long distance travel.</para>
    /// labels<para>Bus or coach (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#BusOrCoach">http://purl.org/vso/ns#BusOrCoach</seealso>
    let BusOrCoach = Prefixed_Name(vso, "BusOrCoach") |> PrefixedName
    /// <summary>
    ///   <para>vso:FWD</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:DriveWheelConfigurationValue</para>
    ///   <para>Front-wheel drive is a transmission layout where the engine drives the front wheels.</para>
    /// labels<para>Front-wheel drive, FWD (vso:DriveWheelConfigurationValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#FWD">http://purl.org/vso/ns#FWD</seealso>
    let FWD = Prefixed_Name(vso, "FWD") |> PrefixedName
    /// <summary>
    ///   <para>vso:FeatureValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating the features or accessories that are attached to or belong to a vehicle.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Anti-lock_braking_system
    ///   http://dbpedia.org/resource/Electronic_stability_control
    ///   http://dbpedia.org/resource/Armrest
    ///   http://dbpedia.org/resource/Spoiler_%28automotive%29
    ///   http://dbpedia.org/resource/CD_Changer
    ///   http://dbpedia.org/resource/Cup_holder
    ///   http://dbpedia.org/resource/Tow_hitch
    ///   http://dbpedia.org/resource/Power_window
    ///   http://dbpedia.org/resource/Power_steering
    ///   http://dbpedia.org/resource/Air_conditioner
    ///   http://dbpedia.org/resource/Child_safety_lock
    ///   http://dbpedia.org/resource/Parking_sensors</para>
    /// labels<para>Feature value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#FeatureValue">http://purl.org/vso/ns#FeatureValue</seealso>
    let FeatureValue = Prefixed_Name(vso, "FeatureValue") |> PrefixedName
    /// <summary>
    ///   <para>vso:Left</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:SteeringPositionValue</para>
    ///   <para>The steering position is on the left side of the vehicle (viewed from the main direction of driving). For cars this means that you drive on the right side of the road.</para>
    /// labels<para>Left Hand Drive (vso:SteeringPositionValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Left">http://purl.org/vso/ns#Left</seealso>
    let Left = Prefixed_Name(vso, "Left") |> PrefixedName
    /// <summary>
    ///   <para>vso:Motorcycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.</para>
    /// labels<para>Motorcycle (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Motorcycle">http://purl.org/vso/ns#Motorcycle</seealso>
    let Motorcycle = Prefixed_Name(vso, "Motorcycle") |> PrefixedName
    /// <summary>
    ///   <para>vso:Quadracycle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A quadracycle is a four-wheeled human-powered vehicle. It is also referred to as a quadricycle, quadcycle pedal car or four-wheeled bicycle.</para>
    /// labels<para>Quadracycle (gr:ProductOrService) </para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Quadracycle">http://purl.org/vso/ns#Quadracycle</seealso>
    let Quadracycle = Prefixed_Name(vso, "Quadracycle") |> PrefixedName
    /// <summary>
    ///   <para>vso:SailingBoat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A sailboat or sailing boat is a boat propelled partly or entirely by sails.</para>
    /// labels<para>Sailing boat (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#SailingBoat">http://purl.org/vso/ns#SailingBoat</seealso>
    let SailingBoat = Prefixed_Name(vso, "SailingBoat") |> PrefixedName
    /// <summary>
    ///   <para>vso:Ship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A ship is a large watercraft that floats on water.</para>
    /// labels<para>Ship (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Ship">http://purl.org/vso/ns#Ship</seealso>
    let Ship = Prefixed_Name(vso, "Ship") |> PrefixedName
    /// <summary>
    ///   <para>vso:Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:SteeringPositionValue</para>
    ///   <para>The steering position is on the right side of the vehicle (viewed from the main direction of driving). For cars this means that you drive on the left side of the road.</para>
    /// labels<para>Right Hand Drive (vso:SteeringPositionValue)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Right">http://purl.org/vso/ns#Right</seealso>
    let Right = Prefixed_Name(vso, "Right") |> PrefixedName

    /// <summary>
    ///   <para>vso:TransmissionTypeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A value indicating a type of transmission.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Manual_transmission
    ///   http://dbpedia.org/resource/Automatic_transmission</para>
    /// labels<para>Transmission type value (the class of predefined values)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#TransmissionTypeValue">http://purl.org/vso/ns#TransmissionTypeValue</seealso>
    let TransmissionTypeValue =
        Prefixed_Name(vso, "TransmissionTypeValue") |> PrefixedName

    /// <summary>
    ///   <para>vso:VIN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A unique serial number used by the automotive industry to identify individual motor vehicles</para>
    /// labels<para>VIN [Vehicle Identification Number] (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#VIN">http://purl.org/vso/ns#VIN</seealso>
    let VIN = Prefixed_Name(vso, "VIN") |> PrefixedName
    /// <summary>
    ///   <para>vso:Van</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A van is a kind of vehicle used for transporting  goods or groups of people. It is usually a box-shaped vehicle on four wheels, about the same width and length as a large automobile,
    /// but taller and usually higher off the ground, also referred to as a light commercial vehicle or LCV.</para>
    /// labels<para>Van (gr:ProductOrService)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#Van">http://purl.org/vso/ns#Van</seealso>
    let Van = Prefixed_Name(vso, "Van") |> PrefixedName
    /// <summary>
    ///   <para>vso:axles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The number of axles
    /// Typical unit code(s): C62</para>
    /// labels<para>axles (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#axles">http://purl.org/vso/ns#axles</seealso>
    let axles = Prefixed_Name(vso, "axles") |> PrefixedName
    /// <summary>
    ///   <para>vso:bodyStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates the design and body style of the vehicle.
    ///
    /// Use DBPedia resources to indicate the features, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Convertible
    ///   http://dbpedia.org/resource/Hatchback
    ///   http://dbpedia.org/resource/Station_wagon
    ///   http://dbpedia.org/resource/Sport_utility_vehicle
    ///   http://dbpedia.org/resource/Roadster
    ///
    /// See also http://en.wikipedia.org/wiki/Car_body_styles.
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:BodyStyleValue.</para>
    /// labels<para>bodyStyle (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#bodyStyle">http://purl.org/vso/ns#bodyStyle</seealso>
    let bodyStyle = Prefixed_Name(vso, "bodyStyle") |> PrefixedName
    /// <summary>
    ///   <para>vso:cargoVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The available volume for cargo or luggage. For automobiles, this is usually the trunk space.
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    /// labels<para>cargoVolume (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#cargoVolume">http://purl.org/vso/ns#cargoVolume</seealso>
    let cargoVolume = Prefixed_Name(vso, "cargoVolume") |> PrefixedName
    /// <summary>
    ///   <para>vso:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The color of the vehicle</para>
    /// labels<para>color (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#color">http://purl.org/vso/ns#color</seealso>
    let color = Prefixed_Name(vso, "color") |> PrefixedName
    /// <summary>
    ///   <para>vso:0to60MPH</para>
    /// </summary>
    /// <remarks>
    ///   <para>vso:SpeedInterval</para>
    ///   <para>The speed interval from 0 to 60 mph</para>
    /// labels<para>0to60MPH (vso:SpeedInterval)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#0to60MPH">http://purl.org/vso/ns#0to60MPH</seealso>
    let _0to60MPH = Prefixed_Name(vso, "0to60MPH") |> PrefixedName
    /// <summary>
    ///   <para>vso:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>A textual description of the condition of the vehicle. This property should be mainly used with gr:ActualProductOrServiceInstance.</para>
    /// labels<para>condition (0..*)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#condition">http://purl.org/vso/ns#condition</seealso>
    let condition = Prefixed_Name(vso, "condition") |> PrefixedName
    /// <summary>
    ///   <para>vso:doors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The number of doors
    /// Typical unit code(s): C62</para>
    /// labels<para>doors (0..1)</para></remarks>
    /// <seealso href="http://purl.org/vso/ns#doors">http://purl.org/vso/ns#doors</seealso>
    let doors = Prefixed_Name(vso, "doors") |> PrefixedName
