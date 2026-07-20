namespace https.w3id.org.wfont.hash

open DoxAletheia

module wfont =
    let _namespace_name = "https://w3id.org/wfont#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having abrasive particles in the oil, it is calculated using Cutting parameter of the sensor.
    /// <see href="https://w3id.org/wfont#AbrasiveWearLevel"></see></summary>
    let AbrasiveWearLevel = _prefix "AbrasiveWearLevel"
    /// <summary>
    /// Something that shows what a situation is like.
    /// <see href="https://w3id.org/wfont#Indicator"></see></summary>
    let Indicator = _prefix "Indicator"
    /// <summary>
    /// Indicates the warning and alarm level for having sliding particles in the oil, it is calculated using Sliding parameter of the sensor.
    /// <see href="https://w3id.org/wfont#AdhesiveWearLevel"></see></summary>
    let AdhesiveWearLevel = _prefix "AdhesiveWearLevel"
    /// <summary>
    /// Indicates the warning and alarm level for having bubbles in the oil, it is calculated using Bubbles parameter of the sensor.
    /// <see href="https://w3id.org/wfont#AirContentLevel"></see></summary>
    let AirContentLevel = _prefix "AirContentLevel"
    /// <summary>
    /// Number of bubbles per milimiter bigger than 21 μm.
    /// <see href="https://w3id.org/wfont#BigBubbles"></see></summary>
    let BigBubbles = _prefix "BigBubbles"
    /// <summary>
    /// Number of bubbles per milimiter.
    /// <see href="https://w3id.org/wfont#Bubbles"></see></summary>
    let Bubbles = _prefix "Bubbles"
    /// <summary>
    /// Number of particles per milimiter bigger than 21 μm.
    /// <see href="https://w3id.org/wfont#BigParticles"></see></summary>
    let BigParticles = _prefix "BigParticles"
    /// <summary>
    /// Number of particles per milimiter.
    /// <see href="https://w3id.org/wfont#Particles"></see></summary>
    let Particles = _prefix "Particles"
    /// <summary>
    /// A mechanical device used to reduce vibrations.
    /// <see href="https://w3id.org/wfont#Bushing"></see></summary>
    let Bushing = _prefix "Bushing"
    /// <summary>
    /// It is a long suspension arm that attaches between the housing and the Nacelle. Its primary job is to control axle housing rotation.
    /// <see href="https://w3id.org/wfont#GearboxTorqueArmSystem"></see></summary>
    let GearboxTorqueArmSystem = _prefix "GearboxTorqueArmSystem"
    /// <summary>
    /// It is the bearing that support the carrier. The carrier holds the planet gears at different radio from the sun gear centerline.
    /// <see href="https://w3id.org/wfont#CarrierBearing"></see></summary>
    let CarrierBearing = _prefix "CarrierBearing"
    /// <summary>
    /// Consists of rings with raceway (inner ring and outer ring), rolling elements (either balls or rollers) and cage. The cage separates the rolling elements at regular intervals, holds them in place within the inner and outer raceways, and allows them to rotate freely.
    /// <see href="https://w3id.org/wfont#GearboxBearing"></see></summary>
    let GearboxBearing = _prefix "GearboxBearing"
    /// <summary>
    /// Indicates the warning and alarm level for having particles in the oil, it is calculated using ISO4, ISO6 and ISO14 parameter of the sensor.
    /// <see href="https://w3id.org/wfont#CleanlinessLevel"></see></summary>
    let CleanlinessLevel = _prefix "CleanlinessLevel"
    /// <summary>
    /// Circulates the liquid from the cooling system.
    /// <see href="https://w3id.org/wfont#CoolantPump"></see></summary>
    let CoolantPump = _prefix "CoolantPump"
    /// <summary>
    /// Reduces the temperature of the oil from the lubricating system.
    /// <see href="https://w3id.org/wfont#CoolingSystem"></see></summary>
    let CoolingSystem = _prefix "CoolingSystem"
    /// <summary>
    /// It controls the shifting process of the transmission, lubrication of the transmission parts to prevent frictional damage, and cooling of the transmission.
    /// <see href="https://w3id.org/wfont#GearboxLubeSystem"></see></summary>
    let GearboxLubeSystem = _prefix "GearboxLubeSystem"
    /// <summary>
    /// Number of particles related to cutting wear per milimiter.
    /// <see href="https://w3id.org/wfont#Cutting"></see></summary>
    let Cutting = _prefix "Cutting"
    /// <summary>
    /// Number of particles related to fatigue wear per milimiter.
    /// <see href="https://w3id.org/wfont#Fatigue"></see></summary>
    let Fatigue = _prefix "Fatigue"
    /// <summary>
    /// Indicates the warning and alarm level for having fatigue particles in the oil, it is calculated using Fatigue parameter of the sensor.
    /// <see href="https://w3id.org/wfont#FatigueWearLevel"></see></summary>
    let FatigueWearLevel = _prefix "FatigueWearLevel"
    /// <summary>
    /// Number of particles related to fiber particles per milimiter.
    /// <see href="https://w3id.org/wfont#Fiber"></see></summary>
    let Fiber = _prefix "Fiber"
    /// <summary>
    /// Indicates the warning and alarm level for having fibre particles in the oil, it is calculated using Fibre parameter of the sensor.
    /// <see href="https://w3id.org/wfont#FibreContaminationLevel"></see></summary>
    let FibreContaminationLevel = _prefix "FibreContaminationLevel"
    /// <summary>
    /// A set of gears with its casing, aimed at increasing or reducing speed.
    /// <see href="https://w3id.org/wfont#Gearbox"></see></summary>
    let Gearbox = _prefix "Gearbox"
    /// <summary>
    /// Relation that links a Gearbox to the indicators that describe its situation.
    /// <see href="https://w3id.org/wfont#hasIndicator"></see></summary>
    let hasIndicator = _prefix "hasIndicator"
    /// <summary>
    /// Relation that links an element and the parts is composed of.
    /// <see href="https://w3id.org/wfont#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// It is a rotating circular machine part having teeth which mesh with another (compatible) toothed part to transmit (convert) torque and speed.
    /// <see href="https://w3id.org/wfont#GearboxGears"></see></summary>
    let GearboxGears = _prefix "GearboxGears"
    /// <summary>
    /// A protective casing providing a reservoir of oil or grease for the gearing.
    /// <see href="https://w3id.org/wfont#GearboxHousing"></see></summary>
    let GearboxHousing = _prefix "GearboxHousing"
    /// <summary>
    /// Constituting part or element of a gearbox.
    /// <see href="https://w3id.org/wfont#GearboxComponent"></see></summary>
    let GearboxComponent = _prefix "GearboxComponent"
    /// <summary>
    /// The ouput shaft of the gearbox witch has empty space inside.
    /// <see href="https://w3id.org/wfont#HollowShaft"></see></summary>
    let HollowShaft = _prefix "HollowShaft"
    /// <summary>
    /// Flexible tube and part attached to it where lube is carried.
    /// <see href="https://w3id.org/wfont#Hose-Fitting"></see></summary>
    let ``Hose-Fitting`` = _prefix "Hose-Fitting"
    /// <summary>
    /// Number of particles per milimiter bigger than 14 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.
    /// <see href="https://w3id.org/wfont#ISO14"></see></summary>
    let ISO14 = _prefix "ISO14"
    /// <summary>
    /// Number of particles per milimiter bigger than 4 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.
    /// <see href="https://w3id.org/wfont#ISO4"></see></summary>
    let ISO4 = _prefix "ISO4"
    /// <summary>
    /// Number of particles per milimiter bigger than 6 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.
    /// <see href="https://w3id.org/wfont#ISO6"></see></summary>
    let ISO6 = _prefix "ISO6"
    /// <summary>
    /// Circulates the lubricant from the lube system.
    /// <see href="https://w3id.org/wfont#LubePump"></see></summary>
    let LubePump = _prefix "LubePump"
    /// <summary>
    /// It supplies motive power to the pump.
    /// <see href="https://w3id.org/wfont#LubePumpMotor"></see></summary>
    let LubePumpMotor = _prefix "LubePumpMotor"
    /// <summary>
    /// A housing which contains the drive‑train and other elements on top of a horizontal axis wind turbine tower.
    /// <see href="https://w3id.org/wfont#Nacelle"></see></summary>
    let Nacelle = _prefix "Nacelle"
    /// <summary>
    /// State of the oil degradation level in the different stages of its useful life.
    /// <see href="https://w3id.org/wfont#OilDegradation"></see></summary>
    let OilDegradation = _prefix "OilDegradation"
    /// <summary>
    /// Indicates the warning and alarm level for oil degradation in the oil, it is calculated using OD parameter of the sensor.
    /// <see href="https://w3id.org/wfont#OilDegradationLevel"></see></summary>
    let OilDegradationLevel = _prefix "OilDegradationLevel"
    /// <summary>
    /// Consists of the bearing mounted in the planet gear.
    /// <see href="https://w3id.org/wfont#PlanetBearing"></see></summary>
    let PlanetBearing = _prefix "PlanetBearing"
    /// <summary>
    /// It is the gear that rotates around the sun gear.
    /// <see href="https://w3id.org/wfont#PlanetGear"></see></summary>
    let PlanetGear = _prefix "PlanetGear"
    /// <summary>
    /// First step of lube filtration system.
    /// <see href="https://w3id.org/wfont#PrimaryFiltration"></see></summary>
    let PrimaryFiltration = _prefix "PrimaryFiltration"
    /// <summary>
    /// It is a heat exchanger use to transfer thermal energy from one medium to another.
    /// <see href="https://w3id.org/wfont#Radiator"></see></summary>
    let Radiator = _prefix "Radiator"
    /// <summary>
    /// Lube compartment or tank that collect oil.
    /// <see href="https://w3id.org/wfont#Reservoir"></see></summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    /// An outer ring with inward-facing teeth that mesh with the planet gear or gears.
    /// <see href="https://w3id.org/wfont#RingGear"></see></summary>
    let RingGear = _prefix "RingGear"
    /// <summary>
    /// Second step of lube filtration system.
    /// <see href="https://w3id.org/wfont#SecondaryFiltration"></see></summary>
    let SecondaryFiltration = _prefix "SecondaryFiltration"
    /// <summary>
    /// Device that converts a physical pehnomenon into a measurable data. In lube systems, collects information of the oil wear or operation.
    /// <see href="https://w3id.org/wfont#Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// Indicates the warning and alarm level for having big particles in the oil, it is calculated using BigParticles parameter of the sensor.
    /// <see href="https://w3id.org/wfont#SevereWearLevel"></see></summary>
    let SevereWearLevel = _prefix "SevereWearLevel"
    /// <summary>
    /// Bearing which supports the intermediate shafting.
    /// <see href="https://w3id.org/wfont#ShaftBearing"></see></summary>
    let ShaftBearing = _prefix "ShaftBearing"
    /// <summary>
    /// Number of particles related to slidding wear per milimiter.
    /// <see href="https://w3id.org/wfont#Sliding"></see></summary>
    let Sliding = _prefix "Sliding"
    /// <summary>
    /// It has straight teeth and are parallel to the axis of the wheel.
    /// <see href="https://w3id.org/wfont#SpurGear"></see></summary>
    let SpurGear = _prefix "SpurGear"
    /// <summary>
    /// It is the central gear.
    /// <see href="https://w3id.org/wfont#SunGear"></see></summary>
    let SunGear = _prefix "SunGear"
    /// <summary>
    /// Indicates the warning and alarm level for having unclassified particles in the oil, it is calculated using Unknown parameter of the sensor.
    /// <see href="https://w3id.org/wfont#UnclassifiedWearLevel"></see></summary>
    let UnclassifiedWearLevel = _prefix "UnclassifiedWearLevel"
    /// <summary>
    /// Number of particles related to unknown particles per milimiter.
    /// <see href="https://w3id.org/wfont#Unknown"></see></summary>
    let Unknown = _prefix "Unknown"
    /// <summary>
    /// A group of wind turbine generator jointly operated.
    /// <see href="https://w3id.org/wfont#WindFarm"></see></summary>
    let WindFarm = _prefix "WindFarm"
    /// <summary>
    /// A rotating machinery in which the kinetic wind energy is transformed into another form of energy.
    /// <see href="https://w3id.org/wfont#WindTurbine"></see></summary>
    let WindTurbine = _prefix "WindTurbine"
