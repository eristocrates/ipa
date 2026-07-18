namespace http.purl.org.vso.ns.hash

open DoxAletheia.Rdf_Vocabulary

module vso =
    let _namespace_name = "http://purl.org/vso/ns#"
    /// <summary>
    /// The speed interval from 0 to 100 km/h
    /// <see href="http://purl.org/vso/ns#0to100KMH"></see></summary>
    let _0to100KMH = Namespaced_IRI.parse _namespace_name "0to100KMH" |> NamespacedName

    /// <summary>
    /// A value indicating a speed interval, mostly for explaining vso:acceleration data
    /// <see href="http://purl.org/vso/ns#SpeedInterval"></see></summary>
    let SpeedInterval =
        Namespaced_IRI.parse _namespace_name "SpeedInterval" |> NamespacedName

    /// <summary>
    /// The speed interval from 0 to 60 mph
    /// <see href="http://purl.org/vso/ns#0to60MPH"></see></summary>
    let _0to60MPH = Namespaced_IRI.parse _namespace_name "0to60MPH" |> NamespacedName
    /// <summary>
    /// The fuel quantity of 1 British (imperial) gallon
    /// <see href="http://purl.org/vso/ns#1GLI"></see></summary>
    let _1GLI = Namespaced_IRI.parse _namespace_name "1GLI" |> NamespacedName

    /// <summary>
    /// A value indicating an amount of fuel
    /// <see href="http://purl.org/vso/ns#FuelQuantity"></see></summary>
    let FuelQuantity =
        Namespaced_IRI.parse _namespace_name "FuelQuantity" |> NamespacedName

    /// <summary>
    /// The fuel quantity of 1 US gallon
    /// <see href="http://purl.org/vso/ns#1GLL"></see></summary>
    let _1GLL = Namespaced_IRI.parse _namespace_name "1GLL" |> NamespacedName
    /// <summary>
    /// The fuel quantity of 1 liter
    /// <see href="http://purl.org/vso/ns#1LTR"></see></summary>
    let _1LTR = Namespaced_IRI.parse _namespace_name "1LTR" |> NamespacedName
    /// <summary>
    /// Four-wheel Drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
    /// <see href="http://purl.org/vso/ns#4WD"></see></summary>
    let _4WD = Namespaced_IRI.parse _namespace_name "4WD" |> NamespacedName

    /// <summary>
    /// A value indicating which roadwheels will receive torque
    /// <see href="http://purl.org/vso/ns#DriveWheelConfigurationValue"></see></summary>
    let DriveWheelConfigurationValue =
        Namespaced_IRI.parse _namespace_name "DriveWheelConfigurationValue" |> NamespacedName

    /// <summary>
    /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.
    /// <see href="http://purl.org/vso/ns#ACRISSCode"></see></summary>
    let ACRISSCode = Namespaced_IRI.parse _namespace_name "ACRISSCode" |> NamespacedName

    /// <summary>
    /// A motorized road vehicle is a wheeled land vehicle whose main propulsion is provided by an engine or motor.
    /// <see href="http://purl.org/vso/ns#MotorizedRoadVehicle"></see></summary>
    let MotorizedRoadVehicle =
        Namespaced_IRI.parse _namespace_name "MotorizedRoadVehicle" |> NamespacedName

    /// <summary>
    /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
    /// <see href="http://purl.org/vso/ns#AWD"></see></summary>
    let AWD = Namespaced_IRI.parse _namespace_name "AWD" |> NamespacedName
    /// <summary>
    /// An automobile, motor car, or car is a wheeled motor vehicle used for transporting passengers, which also carries its own engine or motor.
    /// <see href="http://purl.org/vso/ns#Automobile"></see></summary>
    let Automobile = Namespaced_IRI.parse _namespace_name "Automobile" |> NamespacedName
    /// <summary>
    /// A bicycle or bike is a pedal-driven, human-powered, single-track vehicle, having two wheels attached to a frame, one behind the other. Some bicycles have a small combustion or electric engine that assists with the pedaling.
    /// <see href="http://purl.org/vso/ns#Bicycle"></see></summary>
    let Bicycle = Namespaced_IRI.parse _namespace_name "Bicycle" |> NamespacedName
    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// <see href="http://purl.org/vso/ns#Vehicle"></see></summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName
    /// <summary>
    /// A boat is a watercraft of modest size designed to float or plane, to provide passage across water.
    /// <see href="http://purl.org/vso/ns#Boat"></see></summary>
    let Boat = Namespaced_IRI.parse _namespace_name "Boat" |> NamespacedName
    /// <summary>
    /// A watercraft is a vehicle, vessel or craft designed to move across or through water.
    /// <see href="http://purl.org/vso/ns#Watercraft"></see></summary>
    let Watercraft = Namespaced_IRI.parse _namespace_name "Watercraft" |> NamespacedName

    /// <summary>
    /// A value indicating the body style of a vehicle.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Convertible
    ///   http://dbpedia.org/resource/Hatchback
    ///   http://dbpedia.org/resource/Station_wagon
    ///   http://dbpedia.org/resource/Sport_utility_vehicle
    ///   http://dbpedia.org/resource/Roadster
    /// <see href="http://purl.org/vso/ns#BodyStyleValue"></see></summary>
    let BodyStyleValue =
        Namespaced_IRI.parse _namespace_name "BodyStyleValue" |> NamespacedName

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Buses have a capacity as high as 300 passengers and are widely used for public transportation.
    /// Coaches are luxury busses, usually in service for long distance travel.
    /// <see href="http://purl.org/vso/ns#BusOrCoach"></see></summary>
    let BusOrCoach = Namespaced_IRI.parse _namespace_name "BusOrCoach" |> NamespacedName
    /// <summary>
    /// A canoe (American English) or Canadian canoe (British English) is a small narrow boat, typically human-powered, though it may also be powered by sails or small electric or gas motors.
    /// <see href="http://purl.org/vso/ns#Canoe"></see></summary>
    let Canoe = Namespaced_IRI.parse _namespace_name "Canoe" |> NamespacedName

    /// <summary>
    /// A value indicating the an emission standard.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Super_Ultra_Low_Emission_Vehicle
    ///   http://dbpedia.org/resource/Partial_zero-emissions_vehicle
    ///
    /// See also http://en.wikipedia.org/wiki/Emissions_standard.
    ///
    /// Unfortunately, there are no DBPedia identifiers for the popular Euro 1 - Euro 5 standards available.
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EmissionStandardValue.
    /// <see href="http://purl.org/vso/ns#EmissionStandardValue"></see></summary>
    let EmissionStandardValue =
        Namespaced_IRI.parse _namespace_name "EmissionStandardValue" |> NamespacedName

    /// <summary>
    /// A value indicating an engine type.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Two-stroke_engine
    ///   http://dbpedia.org/resource/Four-stroke_engine
    ///   http://dbpedia.org/resource/Wankel_engine
    ///   http://dbpedia.org/resource/Electric_motor
    /// <see href="http://purl.org/vso/ns#EngineTypeValue"></see></summary>
    let EngineTypeValue =
        Namespaced_IRI.parse _namespace_name "EngineTypeValue" |> NamespacedName

    /// <summary>
    /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
    /// <see href="http://purl.org/vso/ns#FWD"></see></summary>
    let FWD = Namespaced_IRI.parse _namespace_name "FWD" |> NamespacedName

    /// <summary>
    /// A value indicating the features or accessories that are attached to or belong to a vehicle.
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
    ///   http://dbpedia.org/resource/Parking_sensors
    /// <see href="http://purl.org/vso/ns#FeatureValue"></see></summary>
    let FeatureValue =
        Namespaced_IRI.parse _namespace_name "FeatureValue" |> NamespacedName

    /// <summary>
    /// A value indicating a type of fuel.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Gasoline
    ///   http://dbpedia.org/resource/Diesel
    ///   http://dbpedia.org/resource/Biodiesel
    ///   http://dbpedia.org/resource/Kerosene
    /// <see href="http://purl.org/vso/ns#FuelTypeValue"></see></summary>
    let FuelTypeValue =
        Namespaced_IRI.parse _namespace_name "FuelTypeValue" |> NamespacedName

    /// <summary>
    /// A kayak is a small human-powered watercraft that traditionally has a covered deck, and one or more cockpits, each seating one paddler who strokes a double-bladed paddle. In this ontology, kayaks are considered watercrafts of their own kind, not a subtype of vso:Boat.
    /// <see href="http://purl.org/vso/ns#Kayak"></see></summary>
    let Kayak = Namespaced_IRI.parse _namespace_name "Kayak" |> NamespacedName
    /// <summary>
    /// The steering position is on the left side of the vehicle (viewed from the main direction of driving). For cars this means that you drive on the right side of the road.
    /// <see href="http://purl.org/vso/ns#Left"></see></summary>
    let Left = Namespaced_IRI.parse _namespace_name "Left" |> NamespacedName

    /// <summary>
    /// A value indicating a steering position
    /// <see href="http://purl.org/vso/ns#SteeringPositionValue"></see></summary>
    let SteeringPositionValue =
        Namespaced_IRI.parse _namespace_name "SteeringPositionValue" |> NamespacedName

    /// <summary>
    /// A motorboat is a boat which is powered by an engine.
    /// <see href="http://purl.org/vso/ns#MotorBoat"></see></summary>
    let MotorBoat = Namespaced_IRI.parse _namespace_name "MotorBoat" |> NamespacedName
    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// <see href="http://purl.org/vso/ns#Motorcycle"></see></summary>
    let Motorcycle = Namespaced_IRI.parse _namespace_name "Motorcycle" |> NamespacedName

    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// <see href="http://purl.org/vso/ns#MotorizedBicycle"></see></summary>
    let MotorizedBicycle =
        Namespaced_IRI.parse _namespace_name "MotorizedBicycle" |> NamespacedName

    /// <summary>
    /// A quadracycle is a four-wheeled human-powered vehicle. It is also referred to as a quadricycle, quadcycle pedal car or four-wheeled bicycle.
    /// <see href="http://purl.org/vso/ns#Quadracycle"></see></summary>
    let Quadracycle =
        Namespaced_IRI.parse _namespace_name "Quadracycle" |> NamespacedName

    /// <summary>
    /// Rear-wheel drive is a transmission layout where the engine drives the rear wheels.
    /// <see href="http://purl.org/vso/ns#RWD"></see></summary>
    let RWD = Namespaced_IRI.parse _namespace_name "RWD" |> NamespacedName
    /// <summary>
    /// A rickshaw (or ricksha) is a two-wheeled cart which seats one or two persons and is being drawn by a runner.
    /// <see href="http://purl.org/vso/ns#Rickshaw"></see></summary>
    let Rickshaw = Namespaced_IRI.parse _namespace_name "Rickshaw" |> NamespacedName
    /// <summary>
    /// The steering position is on the right side of the vehicle (viewed from the main direction of driving). For cars this means that you drive on the left side of the road.
    /// <see href="http://purl.org/vso/ns#Right"></see></summary>
    let Right = Namespaced_IRI.parse _namespace_name "Right" |> NamespacedName

    /// <summary>
    /// A sailboat or sailing boat is a boat propelled partly or entirely by sails.
    /// <see href="http://purl.org/vso/ns#SailingBoat"></see></summary>
    let SailingBoat =
        Namespaced_IRI.parse _namespace_name "SailingBoat" |> NamespacedName

    /// <summary>
    /// A ship is a large watercraft that floats on water.
    /// <see href="http://purl.org/vso/ns#Ship"></see></summary>
    let Ship = Namespaced_IRI.parse _namespace_name "Ship" |> NamespacedName

    /// <summary>
    /// A value indicating a type of transmission.
    ///
    /// You can safely use any reasonable DBPedia URI, e.g.
    ///   http://dbpedia.org/resource/Manual_transmission
    ///   http://dbpedia.org/resource/Automatic_transmission
    /// <see href="http://purl.org/vso/ns#TransmissionTypeValue"></see></summary>
    let TransmissionTypeValue =
        Namespaced_IRI.parse _namespace_name "TransmissionTypeValue" |> NamespacedName

    /// <summary>
    /// A lorry (British English) or truck (American English) is a motor vehicle designed to transport cargo.
    /// <see href="http://purl.org/vso/ns#Truck"></see></summary>
    let Truck = Namespaced_IRI.parse _namespace_name "Truck" |> NamespacedName

    /// <summary>
    /// A pre-mixed fuel-oil mixture
    /// <see href="http://purl.org/vso/ns#TwoStrokeMixture"></see></summary>
    let TwoStrokeMixture =
        Namespaced_IRI.parse _namespace_name "TwoStrokeMixture" |> NamespacedName

    /// <summary>
    /// A unique serial number used by the automotive industry to identify individual motor vehicles
    /// <see href="http://purl.org/vso/ns#VIN"></see></summary>
    let VIN = Namespaced_IRI.parse _namespace_name "VIN" |> NamespacedName
    /// <summary>
    /// A van is a kind of vehicle used for transporting  goods or groups of people. It is usually a box-shaped vehicle on four wheels, about the same width and length as a large automobile,
    /// but taller and usually higher off the ground, also referred to as a light commercial vehicle or LCV.
    /// <see href="http://purl.org/vso/ns#Van"></see></summary>
    let Van = Namespaced_IRI.parse _namespace_name "Van" |> NamespacedName

    /// <summary>
    /// The time needed to accelerate the vehicle from a given start velocity to a given target velocity
    /// Typical unit code(s): SEC for seconds
    ///
    /// Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the rdfs:label of the gr:QuantitativeValueFloat, or use vso:referenceSpeeds with vso:0to60MPH (0..60 mph) or vso:0to100KMH (0..100 km/h) to specify the reference speeds.
    /// <see href="http://purl.org/vso/ns#acceleration"></see></summary>
    let acceleration =
        Namespaced_IRI.parse _namespace_name "acceleration" |> NamespacedName

    /// <summary>
    /// The number of axles
    /// Typical unit code(s): C62
    /// <see href="http://purl.org/vso/ns#axles"></see></summary>
    let axles = Namespaced_IRI.parse _namespace_name "axles" |> NamespacedName
    /// <summary>
    /// Indicates the design and body style of the vehicle.
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
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:BodyStyleValue.
    /// <see href="http://purl.org/vso/ns#bodyStyle"></see></summary>
    let bodyStyle = Namespaced_IRI.parse _namespace_name "bodyStyle" |> NamespacedName

    /// <summary>
    /// The available volume for cargo or luggage. For automobiles, this is usually the trunk space.
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
    ///
    /// Note: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#cargoVolume"></see></summary>
    let cargoVolume =
        Namespaced_IRI.parse _namespace_name "cargoVolume" |> NamespacedName

    /// <summary>
    /// The color of the vehicle
    /// <see href="http://purl.org/vso/ns#color"></see></summary>
    let color = Namespaced_IRI.parse _namespace_name "color" |> NamespacedName
    /// <summary>
    /// A textual description of the condition of the vehicle. This property should be mainly used with gr:ActualProductOrServiceInstance.
    /// <see href="http://purl.org/vso/ns#condition"></see></summary>
    let condition = Namespaced_IRI.parse _namespace_name "condition" |> NamespacedName
    /// <summary>
    /// A textual description of known damages, both repaired and unrepaired.
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.
    /// <see href="http://purl.org/vso/ns#damages"></see></summary>
    let damages = Namespaced_IRI.parse _namespace_name "damages" |> NamespacedName
    /// <summary>
    /// The number of doors
    /// Typical unit code(s): C62
    /// <see href="http://purl.org/vso/ns#doors"></see></summary>
    let doors = Namespaced_IRI.parse _namespace_name "doors" |> NamespacedName

    /// <summary>
    /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain
    /// <see href="http://purl.org/vso/ns#driveWheelConfiguration"></see></summary>
    let driveWheelConfiguration =
        Namespaced_IRI.parse _namespace_name "driveWheelConfiguration" |> NamespacedName

    /// <summary>
    /// The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. If there are multiple engines, simply attach this property multiple times.
    /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
    ///
    /// Note 1: You can link to information about how the given value has been determined using the gr:valueReference property.
    /// Note 2: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#engineDisplacement"></see></summary>
    let engineDisplacement =
        Namespaced_IRI.parse _namespace_name "engineDisplacement" |> NamespacedName

    /// <summary>
    /// A short text indicating the engine(s) of the vehicle
    /// <see href="http://purl.org/vso/ns#engineName"></see></summary>
    let engineName = Namespaced_IRI.parse _namespace_name "engineName" |> NamespacedName

    /// <summary>
    /// The power of the vehicle's engine. If there are multiple engines, simply attach this property multiple times.
    /// Typical unit code(s): KWT for kilowatt
    ///
    /// Note 1: There are many different ways of measuring an engine's power. For an overview, see  http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes.
    /// Note 2: You can link to information about how the given value has been determined using the gr:valueReference property.
    /// Note 3: You can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#enginePower"></see></summary>
    let enginePower =
        Namespaced_IRI.parse _namespace_name "enginePower" |> NamespacedName

    /// <summary>
    /// The type of engine or engines powering the vehicle. If there are multiple engines, simply attach this property multiple times.
    ///
    /// Use DBPedia resources to indicate the engine type. Popular identifiers are
    ///   http://dbpedia.org/resource/Two-stroke_engine
    ///   http://dbpedia.org/resource/Four-stroke_engine
    ///   http://dbpedia.org/resource/Wankel_engine
    ///   http://dbpedia.org/resource/Electric_motor
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EngineTypeValue.
    /// <see href="http://purl.org/vso/ns#engineType"></see></summary>
    let engineType = Namespaced_IRI.parse _namespace_name "engineType" |> NamespacedName
    /// <summary>
    /// Indicates a built-in feature, accessory, or component of the vehicle.
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
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:FeatureValue.
    /// <see href="http://purl.org/vso/ns#feature"></see></summary>
    let feature = Namespaced_IRI.parse _namespace_name "feature" |> NamespacedName

    /// <summary>
    /// The date of the first registration of the vehicle with the respective public authorities. This property should be used mainly with gr:ActualProductOrServiceInstance.
    /// <see href="http://purl.org/vso/ns#firstRegistration"></see></summary>
    let firstRegistration =
        Namespaced_IRI.parse _namespace_name "firstRegistration" |> NamespacedName

    /// <summary>
    /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km)
    /// Typical unit code(s): LTR for liters, GLL of US Gallons, GLI for UK / Imperial Gallons
    ///
    /// Note 1: There are unfortunately no standard unit codes for "liters per 100 km". Simply use "LTR" for liters, "GLL" of US Gallons, or "GLI" for UK / Imperial Gallons, and indicate the distance in the rdfs:label of the gr:QuantitativeValueFloat or use vso:referenceDistance to model the reference distance (e.g. 100 km).
    /// Note 2: There are two ways of indicating the fuel consumption, vso:fuelConsumption (e.g. 8 liters per 100 km) and vso:fuelEconomy (e.g. 30 miles per gallon). They are reciprocal.
    /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use gr:valueReference to link the value for the fuel consumption to another value.
    /// <see href="http://purl.org/vso/ns#fuelConsumption"></see></summary>
    let fuelConsumption =
        Namespaced_IRI.parse _namespace_name "fuelConsumption" |> NamespacedName

    /// <summary>
    /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L)
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    ///
    /// Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter.
    /// Simply use "SMI" for statute miles (common miles in the US and UK) or "KMT" for kilometers, and indicate
    /// the fuel amount of reference in the rdfs:label of the gr:QuantitativeValueFloat, or use vso:referenceFuelQuantity with vso:1LTR (1 liter), vso:1GLL (1 US Gallon), or vso:1GLI (1 British Gallon).
    /// Note 2: In the absence of a vso:referenceFuelQuantity one may assume that the quantity of reference is 1 gallon for distances given in miles and 1 liter for distances given in kilometers. However, note that the original unit may be obscured by unit conversion services, so this heuristic is far from perfect.
    /// Note 3: There are two ways of indicating the fuel consumption, vso:fuelConsumption (e.g. 8 liters per 100 km) and vso:fuelEconomy (e.g. 30 miles per gallon). They are reciprocal.
    /// Note 4: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use gr:valueReference to link the value for the fuel economy to another value.
    /// <see href="http://purl.org/vso/ns#fuelEconomy"></see></summary>
    let fuelEconomy =
        Namespaced_IRI.parse _namespace_name "fuelEconomy" |> NamespacedName

    /// <summary>
    /// The volume of the fuel tank. If there are multiple tanks, this should indicate the total of all tanks.
    /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons
    /// <see href="http://purl.org/vso/ns#fuelTankVolume"></see></summary>
    let fuelTankVolume =
        Namespaced_IRI.parse _namespace_name "fuelTankVolume" |> NamespacedName

    /// <summary>
    /// The type of fuel suitable for the engine or engines of the vehicle.
    ///
    /// Use DBPedia resources to indicate the fuel type. Popular identifiers are
    ///   http://dbpedia.org/resource/Gasoline
    ///   http://dbpedia.org/resource/Diesel
    ///   http://dbpedia.org/resource/Biodiesel
    ///   http://dbpedia.org/resource/Kerosene
    ///
    /// For two-stroke mixtures, use vso:TwoStrokeMixture.
    /// <see href="http://purl.org/vso/ns#fuelType"></see></summary>
    let fuelType = Namespaced_IRI.parse _namespace_name "fuelType" |> NamespacedName
    /// <summary>
    /// The total number of forward and reverse gears available for the transmission system of the vehicle
    /// Typical unit code(s): C62
    /// <see href="http://purl.org/vso/ns#gearsTotal"></see></summary>
    let gearsTotal = Namespaced_IRI.parse _namespace_name "gearsTotal" |> NamespacedName
    /// <summary>
    /// The outer height of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vso/ns#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// The outer length of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vso/ns#length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    /// Indicates that the vehicle meets the respective emission standard.
    ///
    /// Use DBPedia resources to indicate the standard, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Super_Ultra_Low_Emission_Vehicle
    ///   http://dbpedia.org/resource/Partial_zero-emissions_vehicle
    ///
    /// See also http://en.wikipedia.org/wiki/Emissions_standard.
    ///
    /// Unfortunately, there are no DBPedia identifiers for the popular Euro 1 - Euro 5 standards available.
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:EmissionStandardValue.
    /// <see href="http://purl.org/vso/ns#meetsEmissionStandard"></see></summary>
    let meetsEmissionStandard =
        Namespaced_IRI.parse _namespace_name "meetsEmissionStandard" |> NamespacedName

    /// <summary>
    /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.
    /// <see href="http://purl.org/vso/ns#mileageFromOdometer"></see></summary>
    let mileageFromOdometer =
        Namespaced_IRI.parse _namespace_name "mileageFromOdometer" |> NamespacedName

    /// <summary>
    /// The release date of a vehicle model (often used to differentiate versions of the same make and model)
    /// <see href="http://purl.org/vso/ns#modelDate"></see></summary>
    let modelDate = Namespaced_IRI.parse _namespace_name "modelDate" |> NamespacedName
    /// <summary>
    /// The permited weight of passengers and cargo, EXCLUDING the weight of the empty vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of vso:weight and vso:payload.
    /// Note 2: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 3: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 4: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#payload"></see></summary>
    let payload = Namespaced_IRI.parse _namespace_name "payload" |> NamespacedName

    /// <summary>
    /// The number of previous owners of the vehicle, including the current one
    /// Typical unit code(s): C62
    ///
    /// Note: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.
    /// <see href="http://purl.org/vso/ns#previousOwners"></see></summary>
    let previousOwners =
        Namespaced_IRI.parse _namespace_name "previousOwners" |> NamespacedName

    /// <summary>
    /// The date of production of the vehicle. This property should be used mainly with gr:ActualProductOrServiceInstance.
    /// <see href="http://purl.org/vso/ns#productionDate"></see></summary>
    let productionDate =
        Namespaced_IRI.parse _namespace_name "productionDate" |> NamespacedName

    /// <summary>
    /// The distance to which a vso:fuelConsumption value refers
    /// <see href="http://purl.org/vso/ns#referenceDistance"></see></summary>
    let referenceDistance =
        Namespaced_IRI.parse _namespace_name "referenceDistance" |> NamespacedName

    /// <summary>
    /// The quantity of fuel to which a vso:fuelEconomy value refers
    /// <see href="http://purl.org/vso/ns#referenceFuelQuantity"></see></summary>
    let referenceFuelQuantity =
        Namespaced_IRI.parse _namespace_name "referenceFuelQuantity" |> NamespacedName

    /// <summary>
    /// The interval of initial and target speed to which a vso:acceleration value refers
    /// <see href="http://purl.org/vso/ns#referenceSpeeds"></see></summary>
    let referenceSpeeds =
        Namespaced_IRI.parse _namespace_name "referenceSpeeds" |> NamespacedName

    /// <summary>
    /// Indicates whether the vehicle has been used for commercial rental. The legislation in many countries requires this information to be revealed when offering a car for sale.
    ///
    /// Note 1: This property should be used with gr:ActualProductOrServiceInstance (when offering a vehicle) or gr:ProductOrServicesSomeInstancesPlaceholder (when seeking a vehicle using gr:seeks) only.
    /// Note 2: This property is relevant mainly for offers to SELL the vehicle (gr:hasBusinessFunction gr:Sell).
    /// <see href="http://purl.org/vso/ns#rentalUsage"></see></summary>
    let rentalUsage =
        Namespaced_IRI.parse _namespace_name "rentalUsage" |> NamespacedName

    /// <summary>
    /// The permited total weight of cargo and installations (e.g. a roof rack) on top of the vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#roofLoad"></see></summary>
    let roofLoad = Namespaced_IRI.parse _namespace_name "roofLoad" |> NamespacedName

    /// <summary>
    /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law
    /// Typical unit code(s): C62 for persons
    /// <see href="http://purl.org/vso/ns#seatingCapacity"></see></summary>
    let seatingCapacity =
        Namespaced_IRI.parse _namespace_name "seatingCapacity" |> NamespacedName

    /// <summary>
    /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by gr:hasMaxValueFloat) should be the maximum speed achievable under regular conditions.
    /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot
    ///
    /// Note 1: Use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate the range. Typically, the minimal value is zero.
    /// Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the gr:valueReference property.
    /// <see href="http://purl.org/vso/ns#speed"></see></summary>
    let speed = Namespaced_IRI.parse _namespace_name "speed" |> NamespacedName

    /// <summary>
    /// The position of the steering wheel or similar device (mostly for cars)
    /// <see href="http://purl.org/vso/ns#steeringPosition"></see></summary>
    let steeringPosition =
        Namespaced_IRI.parse _namespace_name "steeringPosition" |> NamespacedName

    /// <summary>
    /// The permited vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR).
    /// 	Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#tongueWeight"></see></summary>
    let tongueWeight =
        Namespaced_IRI.parse _namespace_name "tongueWeight" |> NamespacedName

    /// <summary>
    /// The permited weight of a trailer attached to the vehicle.
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#trailerWeight"></see></summary>
    let trailerWeight =
        Namespaced_IRI.parse _namespace_name "trailerWeight" |> NamespacedName

    /// <summary>
    /// The type of component used for transmitting the power from a rotating power source to the wheels or propeller(s) ("gearbox" for cars).
    ///
    /// Use DBPedia resources to indicate the transmission type, if possible. Popular identifiers are
    ///   http://dbpedia.org/resource/Manual_transmission
    ///   http://dbpedia.org/resource/Automatic_transmission
    ///
    /// If you cannot find a suitable identifier in DBPedia, define your own as an instance of vso:TransmissionTypeValue.
    /// <see href="http://purl.org/vso/ns#transmission"></see></summary>
    let transmission =
        Namespaced_IRI.parse _namespace_name "transmission" |> NamespacedName

    /// <summary>
    /// The weight of the empty vehicle ("curb weight" for cars), i.e. with standard equipment, all necessary operating consumables (e.g. motor oil and coolant), a full tank of fuel, while not loaded with either passengers or cargo
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: There are many varying definitions in place for specifying the weight of a vehicle. E.g., the many European Union car manufacturers include the weight of a 75 kilogram driver to follow European Directive 95/48/EC. Make sure to subtract those 75 kg when converting respective data.
    /// Note 2: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 3: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 4: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName

    /// <summary>
    /// The permited total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle
    /// Typical unit code(s): KGM for kilogram, LBR for pound
    ///
    /// Note 1: You can indicate additional information in the rdfs:label of the gr:QuantitativeValueFloat node.
    /// Note 2: You may also link to a gr:QualitativeValue node that provides additional information using gr:valueReference.
    /// Note 3: Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// <see href="http://purl.org/vso/ns#weightTotal"></see></summary>
    let weightTotal =
        Namespaced_IRI.parse _namespace_name "weightTotal" |> NamespacedName

    /// <summary>
    /// The distance between the centers of the front and rear wheels
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vso/ns#wheelbase"></see></summary>
    let wheelbase = Namespaced_IRI.parse _namespace_name "wheelbase" |> NamespacedName
    /// <summary>
    /// The outer width of the vehicle. Note that you can use gr:hasMinValueFloat and gr:hasMaxValueFloat to indicate ranges.
    /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
    /// <see href="http://purl.org/vso/ns#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
