#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module vso =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/vso/ns#" "vso"
    let _0to100KMH = _prefixId.prefix "0to100KMH"
    let _0to60MPH = _prefixId.prefix "0to60MPH"
    let _1GLI = _prefixId.prefix "1GLI"
    let _1GLL = _prefixId.prefix "1GLL"
    let _1LTR = _prefixId.prefix "1LTR"
    let _4WD = _prefixId.prefix "4WD"
    /// <summary>
    ///   <para>rdfs:label : ACRISSCode (0..1)</para>
    ///   <para>rdfs:comment : The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.</para>
    ///   <a href="http://purl.org/vso/ns#ACRISSCode">vso:ACRISSCode</a>
    /// </summary>
    let ACRISSCode = _prefixId.prefix "ACRISSCode"
    let AWD = _prefixId.prefix "AWD"
    /// <summary>
    ///   <para>rdfs:label : Automobile (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : An automobile, motor car, or car is a wheeled motor vehicle used for transporting passengers, which also carries its own engine or motor.</para>
    ///   <a href="http://purl.org/vso/ns#Automobile">vso:Automobile</a>
    /// </summary>
    let Automobile = _prefixId.prefix "Automobile"
    /// <summary>
    ///   <para>rdfs:label : Bicycle (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A bicycle or bike is a pedal-driven, human-powered, single-track vehicle, having two wheels attached to a frame, one behind the other. Some bicycles have a small combustion or electric engine that assists with the pedaling.</para>
    ///   <a href="http://purl.org/vso/ns#Bicycle">vso:Bicycle</a>
    /// </summary>
    let Bicycle = _prefixId.prefix "Bicycle"
    /// <summary>
    ///   <para>rdfs:label : Boat (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A boat is a watercraft of modest size designed to float or plane, to provide passage across water.</para>
    ///   <a href="http://purl.org/vso/ns#Boat">vso:Boat</a>
    /// </summary>
    let Boat = _prefixId.prefix "Boat"
    /// <summary>
    ///   <para>rdfs:label : Body style value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating the body style of a vehicle.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Convertible
    ///   http://dbpedia.org/resource/Hatchback
    ///   http://dbpedia.org/resource/Station_wagon
    ///   http://dbpedia.org/resource/Sport_utility_vehicle
    ///   http://dbpedia.org/resource/Roadster</para>
    ///   <a href="http://purl.org/vso/ns#BodyStyleValue">vso:BodyStyleValue</a>
    /// </summary>
    let BodyStyleValue = _prefixId.prefix "BodyStyleValue"
    /// <summary>
    ///   <para>rdfs:label : Bus or coach (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Buses have a capacity as high as 300 passengers and are widely used for public transportation.
    /// Coaches are luxury busses, usually in service for long distance travel.</para>
    ///   <a href="http://purl.org/vso/ns#BusOrCoach">vso:BusOrCoach</a>
    /// </summary>
    let BusOrCoach = _prefixId.prefix "BusOrCoach"
    /// <summary>
    ///   <para>rdfs:label : Canoe (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A canoe (American English) or Canadian canoe (British English) is a small narrow boat, typically human-powered, though it may also be powered by sails or small electric or gas motors.</para>
    ///   <a href="http://purl.org/vso/ns#Canoe">vso:Canoe</a>
    /// </summary>
    let Canoe = _prefixId.prefix "Canoe"
    /// <summary>
    ///   <para>rdfs:label : Drive wheel configuration value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating which roadwheels will receive torque</para>
    ///   <a href="http://purl.org/vso/ns#DriveWheelConfigurationValue">vso:DriveWheelConfigurationValue</a>
    /// </summary>
    let DriveWheelConfigurationValue = _prefixId.prefix "DriveWheelConfigurationValue"
    /// <summary>
    ///   <para>rdfs:label : Emission standard value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating the an emission standard.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Super_Ultra_Low_Emission_Vehicle
    ///   http://dbpedia.org/resource/Partial_zero-emissions_vehicle
    ///
    /// See also http://en.wikipedia.org/wiki/Emissions_standard.
    ///
    /// Unfortunately, there are no DBPedia identifiers for the popular Euro 1 - Euro 5 standards available.
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EmissionStandardValue.</para>
    ///   <a href="http://purl.org/vso/ns#EmissionStandardValue">vso:EmissionStandardValue</a>
    /// </summary>
    let EmissionStandardValue = _prefixId.prefix "EmissionStandardValue"
    /// <summary>
    ///   <para>rdfs:label : Engine type value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating an engine type.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Two-stroke_engine
    ///   http://dbpedia.org/resource/Four-stroke_engine
    ///   http://dbpedia.org/resource/Wankel_engine
    ///   http://dbpedia.org/resource/Electric_motor</para>
    ///   <a href="http://purl.org/vso/ns#EngineTypeValue">vso:EngineTypeValue</a>
    /// </summary>
    let EngineTypeValue = _prefixId.prefix "EngineTypeValue"
    let FWD = _prefixId.prefix "FWD"
    /// <summary>
    ///   <para>rdfs:label : Feature value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating the features or accessories that are attached to or belong to a vehicle.
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
    ///   <a href="http://purl.org/vso/ns#FeatureValue">vso:FeatureValue</a>
    /// </summary>
    let FeatureValue = _prefixId.prefix "FeatureValue"
    /// <summary>
    ///   <para>rdfs:label : FuelQuantity</para>
    ///   <para>rdfs:comment : A value indicating an amount of fuel</para>
    ///   <a href="http://purl.org/vso/ns#FuelQuantity">vso:FuelQuantity</a>
    /// </summary>
    let FuelQuantity = _prefixId.prefix "FuelQuantity"
    /// <summary>
    ///   <para>rdfs:label : Fuel type value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating a type of fuel.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Gasoline
    ///   http://dbpedia.org/resource/Diesel
    ///   http://dbpedia.org/resource/Biodiesel
    ///   http://dbpedia.org/resource/Kerosene</para>
    ///   <a href="http://purl.org/vso/ns#FuelTypeValue">vso:FuelTypeValue</a>
    /// </summary>
    let FuelTypeValue = _prefixId.prefix "FuelTypeValue"
    /// <summary>
    ///   <para>rdfs:label : Kayak (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A kayak is a small human-powered watercraft that traditionally has a covered deck, and one or more cockpits, each seating one paddler who strokes a double-bladed paddle. In this ontology, kayaks are considered watercrafts of their own kind, not a subtype of vso:Boat.</para>
    ///   <a href="http://purl.org/vso/ns#Kayak">vso:Kayak</a>
    /// </summary>
    let Kayak = _prefixId.prefix "Kayak"
    let Left = _prefixId.prefix "Left"
    /// <summary>
    ///   <para>rdfs:label : Motor boat (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A motorboat is a boat which is powered by an engine.</para>
    ///   <a href="http://purl.org/vso/ns#MotorBoat">vso:MotorBoat</a>
    /// </summary>
    let MotorBoat = _prefixId.prefix "MotorBoat"
    /// <summary>
    ///   <para>rdfs:label : Motorcycle (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.</para>
    ///   <a href="http://purl.org/vso/ns#Motorcycle">vso:Motorcycle</a>
    /// </summary>
    let Motorcycle = _prefixId.prefix "Motorcycle"
    /// <summary>
    ///   <para>rdfs:label : Motorized bicycle (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.</para>
    ///   <a href="http://purl.org/vso/ns#MotorizedBicycle">vso:MotorizedBicycle</a>
    /// </summary>
    let MotorizedBicycle = _prefixId.prefix "MotorizedBicycle"
    /// <summary>
    ///   <para>rdfs:label : Motorized road vehicle (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A motorized road vehicle is a wheeled land vehicle whose main propulsion is provided by an engine or motor.</para>
    ///   <a href="http://purl.org/vso/ns#MotorizedRoadVehicle">vso:MotorizedRoadVehicle</a>
    /// </summary>
    let MotorizedRoadVehicle = _prefixId.prefix "MotorizedRoadVehicle"
    /// <summary>
    ///   <para>rdfs:label : Quadracycle (gr:ProductOrService) </para>
    ///   <para>rdfs:comment : A quadracycle is a four-wheeled human-powered vehicle. It is also referred to as a quadricycle, quadcycle pedal car or four-wheeled bicycle.</para>
    ///   <a href="http://purl.org/vso/ns#Quadracycle">vso:Quadracycle</a>
    /// </summary>
    let Quadracycle = _prefixId.prefix "Quadracycle"
    let RWD = _prefixId.prefix "RWD"
    /// <summary>
    ///   <para>rdfs:label : Rickshaw (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A rickshaw (or ricksha) is a two-wheeled cart which seats one or two persons and is being drawn by a runner.</para>
    ///   <a href="http://purl.org/vso/ns#Rickshaw">vso:Rickshaw</a>
    /// </summary>
    let Rickshaw = _prefixId.prefix "Rickshaw"
    let Right = _prefixId.prefix "Right"
    /// <summary>
    ///   <para>rdfs:label : Sailing boat (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A sailboat or sailing boat is a boat propelled partly or entirely by sails.</para>
    ///   <a href="http://purl.org/vso/ns#SailingBoat">vso:SailingBoat</a>
    /// </summary>
    let SailingBoat = _prefixId.prefix "SailingBoat"
    /// <summary>
    ///   <para>rdfs:label : Ship (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A ship is a large watercraft that floats on water.</para>
    ///   <a href="http://purl.org/vso/ns#Ship">vso:Ship</a>
    /// </summary>
    let Ship = _prefixId.prefix "Ship"
    /// <summary>
    ///   <para>rdfs:label : SpeedInterval</para>
    ///   <para>rdfs:comment : A value indicating a speed interval, mostly for explaining vso:acceleration data</para>
    ///   <a href="http://purl.org/vso/ns#SpeedInterval">vso:SpeedInterval</a>
    /// </summary>
    let SpeedInterval = _prefixId.prefix "SpeedInterval"
    /// <summary>
    ///   <para>rdfs:label : Steering position value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating a steering position</para>
    ///   <a href="http://purl.org/vso/ns#SteeringPositionValue">vso:SteeringPositionValue</a>
    /// </summary>
    let SteeringPositionValue = _prefixId.prefix "SteeringPositionValue"
    /// <summary>
    ///   <para>rdfs:label : Transmission type value (the class of predefined values)</para>
    ///   <para>rdfs:comment : A value indicating a type of transmission.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Manual_transmission
    ///   http://dbpedia.org/resource/Automatic_transmission</para>
    ///   <a href="http://purl.org/vso/ns#TransmissionTypeValue">vso:TransmissionTypeValue</a>
    /// </summary>
    let TransmissionTypeValue = _prefixId.prefix "TransmissionTypeValue"
    /// <summary>
    ///   <para>rdfs:label : Truck (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A lorry (British English) or truck (American English) is a motor vehicle designed to transport cargo.</para>
    ///   <a href="http://purl.org/vso/ns#Truck">vso:Truck</a>
    /// </summary>
    let Truck = _prefixId.prefix "Truck"
    let TwoStrokeMixture = _prefixId.prefix "TwoStrokeMixture"
    /// <summary>
    ///   <para>rdfs:label : VIN [Vehicle Identification Number] (0..1)</para>
    ///   <para>rdfs:comment : A unique serial number used by the automotive industry to identify individual motor vehicles</para>
    ///   <a href="http://purl.org/vso/ns#VIN">vso:VIN</a>
    /// </summary>
    let VIN = _prefixId.prefix "VIN"
    /// <summary>
    ///   <para>rdfs:label : Van (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A van is a kind of vehicle used for transporting  goods or groups of people. It is usually a box-shaped vehicle on four wheels, about the same width and length as a large automobile,
    /// but taller and usually higher off the ground, also referred to as a light commercial vehicle or LCV.</para>
    ///   <a href="http://purl.org/vso/ns#Van">vso:Van</a>
    /// </summary>
    let Van = _prefixId.prefix "Van"
    /// <summary>
    ///   <para>rdfs:label : Vehicle (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.</para>
    ///   <a href="http://purl.org/vso/ns#Vehicle">vso:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"
    /// <summary>
    ///   <para>rdfs:label : Watercraft (gr:ProductOrService)</para>
    ///   <para>rdfs:comment : A watercraft is a vehicle, vessel or craft designed to move across or through water.</para>
    ///   <a href="http://purl.org/vso/ns#Watercraft">vso:Watercraft</a>
    /// </summary>
    let Watercraft = _prefixId.prefix "Watercraft"
    /// <summary>
    ///   <para>rdfs:label : acceleration (0..*)</para>
    ///   <para>rdfs:comment : The time needed to accelerate the vehicle from a given start velocity to a given target velocity
    /// Typical unit code(s): SEC for seconds
    ///
    /// Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the rdfs:label of the gr:QuantitativeValueFloat, or use vso:referenceSpeeds with vso:0to60MPH (0..60 mph) or vso:0to100KMH (0..100 km/h) to specify the reference speeds.</para>
    ///   <a href="http://purl.org/vso/ns#acceleration">vso:acceleration</a>
    /// </summary>
    let acceleration = _prefixId.prefix "acceleration"
    /// <summary>
    ///   <para>rdfs:label : axles (0..1)</para>
    ///   <para>rdfs:comment : The number of axles
    /// Typical unit code(s): C62</para>
    ///   <a href="http://purl.org/vso/ns#axles">vso:axles</a>
    /// </summary>
    let axles = _prefixId.prefix "axles"
    /// <summary>
    ///   <para>rdfs:label : bodyStyle (0..1)</para>
    ///   <para>rdfs:comment : Indicates the design and body style of the vehicle.
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
    ///   <a href="http://purl.org/vso/ns#bodyStyle">vso:bodyStyle</a>
    /// </summary>
    let bodyStyle = _prefixId.prefix "bodyStyle"
    /// <summary>
    ///   <para>rdfs:label : cargoVolume (0..1)</para>
    ///   <para>rdfs:comment : The available volume for cargo or luggage. For automobiles, this is usually the trunk space.
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#cargoVolume">vso:cargoVolume</a>
    /// </summary>
    let cargoVolume = _prefixId.prefix "cargoVolume"
    /// <summary>
    ///   <para>rdfs:label : color (0..*)</para>
    ///   <para>rdfs:comment : The color of the vehicle</para>
    ///   <a href="http://purl.org/vso/ns#color">vso:color</a>
    /// </summary>
    let color = _prefixId.prefix "color"
    /// <summary>
    ///   <para>rdfs:label : condition (0..*)</para>
    ///   <para>rdfs:comment : A textual description of the condition of the vehicle. This property should be mainly used with gr:ActualProductOrServiceInstance.</para>
    ///   <a href="http://purl.org/vso/ns#condition">vso:condition</a>
    /// </summary>
    let condition = _prefixId.prefix "condition"
    /// <summary>
    ///   <para>rdfs:label : damages (0..*)</para>
    ///   <para>rdfs:comment : A textual description of known damages, both repaired and unrepaired.
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.</para>
    ///   <a href="http://purl.org/vso/ns#damages">vso:damages</a>
    /// </summary>
    let damages = _prefixId.prefix "damages"
    /// <summary>
    ///   <para>rdfs:label : doors (0..1)</para>
    ///   <para>rdfs:comment : The number of doors
    /// Typical unit code(s): C62</para>
    ///   <a href="http://purl.org/vso/ns#doors">vso:doors</a>
    /// </summary>
    let doors = _prefixId.prefix "doors"
    /// <summary>
    ///   <para>rdfs:label : driveWheelConfiguration (0..1)</para>
    ///   <para>rdfs:comment : The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain</para>
    ///   <a href="http://purl.org/vso/ns#driveWheelConfiguration">vso:driveWheelConfiguration</a>
    /// </summary>
    let driveWheelConfiguration = _prefixId.prefix "driveWheelConfiguration"
    /// <summary>
    ///   <para>rdfs:label : engineDisplacement (0..*)</para>
    ///   <para>rdfs:comment : The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. If there are multiple engines, simply attach this property multiple times.
    /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
    ///
    /// Note 1: You can link to information about how the given value has been determined using the gr:valueReference property.
    /// Note 2: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#engineDisplacement">vso:engineDisplacement</a>
    /// </summary>
    let engineDisplacement = _prefixId.prefix "engineDisplacement"
    /// <summary>
    ///   <para>rdfs:label : engineName (0..*)</para>
    ///   <para>rdfs:comment : A short text indicating the engine(s) of the vehicle</para>
    ///   <a href="http://purl.org/vso/ns#engineName">vso:engineName</a>
    /// </summary>
    let engineName = _prefixId.prefix "engineName"
    /// <summary>
    ///   <para>rdfs:label : enginePower (0..*)</para>
    ///   <para>rdfs:comment : The power of the vehicle's engine. If there are multiple engines, simply attach this property multiple times.
    /// Typical unit code(s): KWT for kilowatt
    ///
    /// Note 1: There are many different ways of measuring an engine's power. For an overview, see  http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes.
    /// Note 2: You can link to information about how the given value has been determined using the gr:valueReference property.
    /// Note 3: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#enginePower">vso:enginePower</a>
    /// </summary>
    let enginePower = _prefixId.prefix "enginePower"
    /// <summary>
    ///   <para>rdfs:label : engineType (0..*)</para>
    ///   <para>rdfs:comment : The type of engine or engines powering the vehicle. If there are multiple engines, simply attach this property multiple times.
    ///
    /// Use DBPedia resources to indicate the engine type. Popular identifiers are
    ///   http://dbpedia.org/resource/Two-stroke_engine
    ///   http://dbpedia.org/resource/Four-stroke_engine
    ///   http://dbpedia.org/resource/Wankel_engine
    ///   http://dbpedia.org/resource/Electric_motor
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EngineTypeValue.</para>
    ///   <a href="http://purl.org/vso/ns#engineType">vso:engineType</a>
    /// </summary>
    let engineType = _prefixId.prefix "engineType"
    /// <summary>
    ///   <para>rdfs:label : feature (0..*)</para>
    ///   <para>rdfs:comment : Indicates a built-in feature, accessory, or component of the vehicle.
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
    ///   <a href="http://purl.org/vso/ns#feature">vso:feature</a>
    /// </summary>
    let feature = _prefixId.prefix "feature"
    /// <summary>
    ///   <para>rdfs:label : firstRegistration (0..1)</para>
    ///   <para>rdfs:comment : The date of the first registration of the vehicle with the respective public authorities. This property should be used mainly with gr:ActualProductOrServiceInstance.</para>
    ///   <a href="http://purl.org/vso/ns#firstRegistration">vso:firstRegistration</a>
    /// </summary>
    let firstRegistration = _prefixId.prefix "firstRegistration"
    /// <summary>
    ///   <para>rdfs:label : fuelConsumption (0..*)</para>
    ///   <para>rdfs:comment : The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km)
    /// Typical unit code(s): LTR for liters, GLL of US Gallons, GLI for UK / Imperial Gallons
    ///
    /// Note 1: There are unfortunately no standard unit codes for "liters per 100 km". Simply use "LTR" for liters, "GLL" of US Gallons, or "GLI" for UK / Imperial Gallons, and indicate the distance in the rdfs:label of the gr:QuantitativeValueFloat or use vso:referenceDistance to model the reference distance (e.g. 100 km).
    /// Note 2: There are two ways of indicating the fuel consumption, vso:fuelConsumption (e.g. 8 liters per 100 km) and vso:fuelEconomy (e.g. 30 miles per gallon). They are reciprocal.
    /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use gr:valueReference to link the value for the fuel consumption to another value.</para>
    ///   <a href="http://purl.org/vso/ns#fuelConsumption">vso:fuelConsumption</a>
    /// </summary>
    let fuelConsumption = _prefixId.prefix "fuelConsumption"
    /// <summary>
    ///   <para>rdfs:label : fuelEconomy (0..*)</para>
    ///   <para>rdfs:comment : The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L)
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    ///
    /// Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter.
    /// Simply use "SMI" for statute miles (common miles in the US and UK) or "KMT" for kilometers, and indicate
    /// the fuel amount of reference in the rdfs:label of the gr:QuantitativeValueFloat, or use vso:referenceFuelQuantity with vso:1LTR (1 liter), vso:1GLL (1 US Gallon), or vso:1GLI (1 British Gallon).
    /// Note 2: In the absence of a vso:referenceFuelQuantity one may assume that the quantity of reference is 1 gallon for distances given in miles and 1 liter for distances given in kilometers. However, note that the original unit may be obscured by unit conversion services, so this heuristic is far from perfect.
    /// Note 3: There are two ways of indicating the fuel consumption, vso:fuelConsumption (e.g. 8 liters per 100 km) and vso:fuelEconomy (e.g. 30 miles per gallon). They are reciprocal.
    /// Note 4: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use gr:valueReference to link the value for the fuel economy to another value.</para>
    ///   <a href="http://purl.org/vso/ns#fuelEconomy">vso:fuelEconomy</a>
    /// </summary>
    let fuelEconomy = _prefixId.prefix "fuelEconomy"
    /// <summary>
    ///   <para>rdfs:label : fuelTankVolume (0..1)</para>
    ///   <para>rdfs:comment : The volume of the fuel tank. If there are multiple tanks, this should indicate the total of all tanks.
    /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons</para>
    ///   <a href="http://purl.org/vso/ns#fuelTankVolume">vso:fuelTankVolume</a>
    /// </summary>
    let fuelTankVolume = _prefixId.prefix "fuelTankVolume"
    /// <summary>
    ///   <para>rdfs:label : fuelType (0..*)</para>
    ///   <para>rdfs:comment : The type of fuel suitable for the engine or engines of the vehicle.
    ///
    /// Use DBPedia resources to indicate the fuel type. Popular identifiers are
    ///   http://dbpedia.org/resource/Gasoline
    ///   http://dbpedia.org/resource/Diesel
    ///   http://dbpedia.org/resource/Biodiesel
    ///   http://dbpedia.org/resource/Kerosene
    ///
    /// For two-stroke mixtures, use vso:TwoStrokeMixture. </para>
    ///   <a href="http://purl.org/vso/ns#fuelType">vso:fuelType</a>
    /// </summary>
    let fuelType = _prefixId.prefix "fuelType"
    /// <summary>
    ///   <para>rdfs:label : gearsTotal (0..1)</para>
    ///   <para>rdfs:comment : The total number of forward and reverse gears available for the transmission system of the vehicle
    /// Typical unit code(s): C62</para>
    ///   <a href="http://purl.org/vso/ns#gearsTotal">vso:gearsTotal</a>
    /// </summary>
    let gearsTotal = _prefixId.prefix "gearsTotal"
    /// <summary>
    ///   <para>rdfs:label : height (0..1)</para>
    ///   <para>rdfs:comment : The outer height of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vso/ns#height">vso:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : length (0..1)</para>
    ///   <para>rdfs:comment : The outer length of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vso/ns#length">vso:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : meetsEmissionStandard (0..*)</para>
    ///   <para>rdfs:comment : Indicates that the vehicle meets the respective emission standard.
    ///
    /// Use DBPedia resources to indicate the standard, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Super_Ultra_Low_Emission_Vehicle
    ///   http://dbpedia.org/resource/Partial_zero-emissions_vehicle
    ///
    /// See also http://en.wikipedia.org/wiki/Emissions_standard.
    ///
    /// Unfortunately, there are no DBPedia identifiers for the popular Euro 1 - Euro 5 standards available.
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EmissionStandardValue.</para>
    ///   <a href="http://purl.org/vso/ns#meetsEmissionStandard">vso:meetsEmissionStandard</a>
    /// </summary>
    let meetsEmissionStandard = _prefixId.prefix "meetsEmissionStandard"
    /// <summary>
    ///   <para>rdfs:label : mileageFromOdometer (0..1)</para>
    ///   <para>rdfs:comment : The total distance travelled by the particular vehicle since its initial production, as read from its odometer
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.</para>
    ///   <a href="http://purl.org/vso/ns#mileageFromOdometer">vso:mileageFromOdometer</a>
    /// </summary>
    let mileageFromOdometer = _prefixId.prefix "mileageFromOdometer"
    /// <summary>
    ///   <para>rdfs:label : modelDate (0..1)</para>
    ///   <para>rdfs:comment : The release date of a vehicle model (often used to differentiate versions of the same make and model)</para>
    ///   <a href="http://purl.org/vso/ns#modelDate">vso:modelDate</a>
    /// </summary>
    let modelDate = _prefixId.prefix "modelDate"
    /// <summary>
    ///   <para>rdfs:label : payload (0..1)</para>
    ///   <para>rdfs:comment : The permited weight of passengers and cargo, EXCLUDING the weight of the empty vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of vso:weight and vso:payload.
    /// Note 2: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 3: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 4: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#payload">vso:payload</a>
    /// </summary>
    let payload = _prefixId.prefix "payload"
    /// <summary>
    ///   <para>rdfs:label : previousOwners (0..1)</para>
    ///   <para>rdfs:comment : The number of previous owners of the vehicle, including the current one
    /// Typical unit code(s): C62
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.</para>
    ///   <a href="http://purl.org/vso/ns#previousOwners">vso:previousOwners</a>
    /// </summary>
    let previousOwners = _prefixId.prefix "previousOwners"
    /// <summary>
    ///   <para>rdfs:label : productionDate (0..1)</para>
    ///   <para>rdfs:comment : The date of production of the vehicle. This property should be used mainly with gr:ActualProductOrServiceInstance.</para>
    ///   <a href="http://purl.org/vso/ns#productionDate">vso:productionDate</a>
    /// </summary>
    let productionDate = _prefixId.prefix "productionDate"
    /// <summary>
    ///   <para>rdfs:label : referenceDistance (0..1)</para>
    ///   <para>rdfs:comment : The distance to which a vso:fuelConsumption value refers</para>
    ///   <a href="http://purl.org/vso/ns#referenceDistance">vso:referenceDistance</a>
    /// </summary>
    let referenceDistance = _prefixId.prefix "referenceDistance"
    /// <summary>
    ///   <para>rdfs:label : referenceFuelQuantity (0..1)</para>
    ///   <para>rdfs:comment : The quantity of fuel to which a vso:fuelEconomy value refers</para>
    ///   <a href="http://purl.org/vso/ns#referenceFuelQuantity">vso:referenceFuelQuantity</a>
    /// </summary>
    let referenceFuelQuantity = _prefixId.prefix "referenceFuelQuantity"
    /// <summary>
    ///   <para>rdfs:label : referenceSpeeds (0..1)</para>
    ///   <para>rdfs:comment : The interval of initial and target speed to which a vso:acceleration value refers</para>
    ///   <a href="http://purl.org/vso/ns#referenceSpeeds">vso:referenceSpeeds</a>
    /// </summary>
    let referenceSpeeds = _prefixId.prefix "referenceSpeeds"
    /// <summary>
    ///   <para>rdfs:label : rentalUsage (0..1)</para>
    ///   <para>rdfs:comment : Indicates whether the vehicle has been used for commercial rental. The legislation in many countries requires this information to be revealed when offering a car for sale.
    ///
    /// Note 1: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.
    /// Note 2: This property is relevant mainly for offers to SELL the vehicle (gr:hasBusinessFunction gr:Sell).</para>
    ///   <a href="http://purl.org/vso/ns#rentalUsage">vso:rentalUsage</a>
    /// </summary>
    let rentalUsage = _prefixId.prefix "rentalUsage"
    /// <summary>
    ///   <para>rdfs:label : roofLoad (0..1)</para>
    ///   <para>rdfs:comment : The permited total weight of cargo and installations (e.g. a roof rack) on top of the vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#roofLoad">vso:roofLoad</a>
    /// </summary>
    let roofLoad = _prefixId.prefix "roofLoad"
    /// <summary>
    ///   <para>rdfs:label : seatingCapacity (0..1)</para>
    ///   <para>rdfs:comment : The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law
    /// Typical unit code(s): C62 for persons </para>
    ///   <a href="http://purl.org/vso/ns#seatingCapacity">vso:seatingCapacity</a>
    /// </summary>
    let seatingCapacity = _prefixId.prefix "seatingCapacity"
    /// <summary>
    ///   <para>rdfs:label : speed (0..*)</para>
    ///   <para>rdfs:comment : The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by gr:hasMaxValueFloat) should be the maximum speed achievable under regular conditions.
    /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot
    ///
    /// Note 1: Use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate the range. Typically, the minimal value is zero.
    /// Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the gr:valueReference property.</para>
    ///   <a href="http://purl.org/vso/ns#speed">vso:speed</a>
    /// </summary>
    let speed = _prefixId.prefix "speed"
    /// <summary>
    ///   <para>rdfs:label : steeringPosition (0..1)</para>
    ///   <para>rdfs:comment : The position of the steering wheel or similar device (mostly for cars)</para>
    ///   <a href="http://purl.org/vso/ns#steeringPosition">vso:steeringPosition</a>
    /// </summary>
    let steeringPosition = _prefixId.prefix "steeringPosition"
    /// <summary>
    ///   <para>rdfs:label : tongueWeight (0..1)</para>
    ///   <para>rdfs:comment : The permited vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR).
    /// 	Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#tongueWeight">vso:tongueWeight</a>
    /// </summary>
    let tongueWeight = _prefixId.prefix "tongueWeight"
    /// <summary>
    ///   <para>rdfs:label : trailerWeight (0..1)</para>
    ///   <para>rdfs:comment : The permited weight of a trailer attached to the vehicle.
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#trailerWeight">vso:trailerWeight</a>
    /// </summary>
    let trailerWeight = _prefixId.prefix "trailerWeight"
    /// <summary>
    ///   <para>rdfs:label : transmission (0..*)</para>
    ///   <para>rdfs:comment : The type of component used for transmitting the power from a rotating power source to the wheels or propeller(s) ("gearbox" for cars).
    ///
    /// Use DBPedia resources to indicate the transmission type, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Manual_transmission
    ///   http://dbpedia.org/resource/Automatic_transmission
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:TransmissionTypeValue.</para>
    ///   <a href="http://purl.org/vso/ns#transmission">vso:transmission</a>
    /// </summary>
    let transmission = _prefixId.prefix "transmission"
    /// <summary>
    ///   <para>rdfs:label : weight (0..1)</para>
    ///   <para>rdfs:comment : The weight of the empty vehicle ("curb weight" for cars), i.e. with standard equipment, all necessary operating consumables (e.g. motor oil and coolant), a full tank of fuel, while not loaded with either passengers or cargo
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: There are many varying definitions in place for specifying the weight of a vehicle. E.g., the many European Union car manufacturers include the weight of a 75 kilogram driver to follow European Directive 95/48/EC. Make sure to subtract those 75 kg when converting respective data.
    /// Note 2: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 3: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 4: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#weight">vso:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
    /// <summary>
    ///   <para>rdfs:label : weightTotal (0..1)</para>
    ///   <para>rdfs:comment : The permited total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.</para>
    ///   <a href="http://purl.org/vso/ns#weightTotal">vso:weightTotal</a>
    /// </summary>
    let weightTotal = _prefixId.prefix "weightTotal"
    /// <summary>
    ///   <para>rdfs:label : wheelbase (0..1)</para>
    ///   <para>rdfs:comment : The distance between the centers of the front and rear wheels
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vso/ns#wheelbase">vso:wheelbase</a>
    /// </summary>
    let wheelbase = _prefixId.prefix "wheelbase"
    /// <summary>
    ///   <para>rdfs:label : width (0..1)</para>
    ///   <para>rdfs:comment : The outer width of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet</para>
    ///   <a href="http://purl.org/vso/ns#width">vso:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
