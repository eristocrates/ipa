namespace https.w3id.org.wfont.hash

open DoxAletheia.Rdf_Vocabulary

module wfont =
    let _namespace_name = "https://w3id.org/wfont#"

    /// <summary>
    /// Indicates the warning and alarm level for having abrasive particles in the oil, it is calculated using Cutting parameter of the sensor.
    /// <see href="https://w3id.org/wfont#AbrasiveWearLevel"></see></summary>
    let AbrasiveWearLevel =
        Namespaced_IRI.parse _namespace_name "AbrasiveWearLevel" |> NamespacedName

    /// <summary>
    /// Something that shows what a situation is like.
    /// <see href="https://w3id.org/wfont#Indicator"></see></summary>
    let Indicator = Namespaced_IRI.parse _namespace_name "Indicator" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having sliding particles in the oil, it is calculated using Sliding parameter of the sensor.
    /// <see href="https://w3id.org/wfont#AdhesiveWearLevel"></see></summary>
    let AdhesiveWearLevel =
        Namespaced_IRI.parse _namespace_name "AdhesiveWearLevel" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having bubbles in the oil, it is calculated using Bubbles parameter of the sensor.
    /// <see href="https://w3id.org/wfont#AirContentLevel"></see></summary>
    let AirContentLevel =
        Namespaced_IRI.parse _namespace_name "AirContentLevel" |> NamespacedName

    /// <summary>
    /// Number of bubbles per milimiter bigger than 21 μm.
    /// <see href="https://w3id.org/wfont#BigBubbles"></see></summary>
    let BigBubbles = Namespaced_IRI.parse _namespace_name "BigBubbles" |> NamespacedName
    /// <summary>
    /// Number of bubbles per milimiter.
    /// <see href="https://w3id.org/wfont#Bubbles"></see></summary>
    let Bubbles = Namespaced_IRI.parse _namespace_name "Bubbles" |> NamespacedName

    /// <summary>
    /// Number of particles per milimiter bigger than 21 μm.
    /// <see href="https://w3id.org/wfont#BigParticles"></see></summary>
    let BigParticles =
        Namespaced_IRI.parse _namespace_name "BigParticles" |> NamespacedName

    /// <summary>
    /// Number of particles per milimiter.
    /// <see href="https://w3id.org/wfont#Particles"></see></summary>
    let Particles = Namespaced_IRI.parse _namespace_name "Particles" |> NamespacedName
    /// <summary>
    /// A mechanical device used to reduce vibrations.
    /// <see href="https://w3id.org/wfont#Bushing"></see></summary>
    let Bushing = Namespaced_IRI.parse _namespace_name "Bushing" |> NamespacedName

    /// <summary>
    /// It is a long suspension arm that attaches between the housing and the Nacelle. Its primary job is to control axle housing rotation.
    /// <see href="https://w3id.org/wfont#GearboxTorqueArmSystem"></see></summary>
    let GearboxTorqueArmSystem =
        Namespaced_IRI.parse _namespace_name "GearboxTorqueArmSystem" |> NamespacedName

    /// <summary>
    /// It is the bearing that support the carrier. The carrier holds the planet gears at different radio from the sun gear centerline.
    /// <see href="https://w3id.org/wfont#CarrierBearing"></see></summary>
    let CarrierBearing =
        Namespaced_IRI.parse _namespace_name "CarrierBearing" |> NamespacedName

    /// <summary>
    /// Consists of rings with raceway (inner ring and outer ring), rolling elements (either balls or rollers) and cage. The cage separates the rolling elements at regular intervals, holds them in place within the inner and outer raceways, and allows them to rotate freely.
    /// <see href="https://w3id.org/wfont#GearboxBearing"></see></summary>
    let GearboxBearing =
        Namespaced_IRI.parse _namespace_name "GearboxBearing" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having particles in the oil, it is calculated using ISO4, ISO6 and ISO14 parameter of the sensor.
    /// <see href="https://w3id.org/wfont#CleanlinessLevel"></see></summary>
    let CleanlinessLevel =
        Namespaced_IRI.parse _namespace_name "CleanlinessLevel" |> NamespacedName

    /// <summary>
    /// Circulates the liquid from the cooling system.
    /// <see href="https://w3id.org/wfont#CoolantPump"></see></summary>
    let CoolantPump =
        Namespaced_IRI.parse _namespace_name "CoolantPump" |> NamespacedName

    /// <summary>
    /// Reduces the temperature of the oil from the lubricating system.
    /// <see href="https://w3id.org/wfont#CoolingSystem"></see></summary>
    let CoolingSystem =
        Namespaced_IRI.parse _namespace_name "CoolingSystem" |> NamespacedName

    /// <summary>
    /// It controls the shifting process of the transmission, lubrication of the transmission parts to prevent frictional damage, and cooling of the transmission.
    /// <see href="https://w3id.org/wfont#GearboxLubeSystem"></see></summary>
    let GearboxLubeSystem =
        Namespaced_IRI.parse _namespace_name "GearboxLubeSystem" |> NamespacedName

    /// <summary>
    /// Number of particles related to cutting wear per milimiter.
    /// <see href="https://w3id.org/wfont#Cutting"></see></summary>
    let Cutting = Namespaced_IRI.parse _namespace_name "Cutting" |> NamespacedName
    /// <summary>
    /// Number of particles related to fatigue wear per milimiter.
    /// <see href="https://w3id.org/wfont#Fatigue"></see></summary>
    let Fatigue = Namespaced_IRI.parse _namespace_name "Fatigue" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having fatigue particles in the oil, it is calculated using Fatigue parameter of the sensor.
    /// <see href="https://w3id.org/wfont#FatigueWearLevel"></see></summary>
    let FatigueWearLevel =
        Namespaced_IRI.parse _namespace_name "FatigueWearLevel" |> NamespacedName

    /// <summary>
    /// Number of particles related to fiber particles per milimiter.
    /// <see href="https://w3id.org/wfont#Fiber"></see></summary>
    let Fiber = Namespaced_IRI.parse _namespace_name "Fiber" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having fibre particles in the oil, it is calculated using Fibre parameter of the sensor.
    /// <see href="https://w3id.org/wfont#FibreContaminationLevel"></see></summary>
    let FibreContaminationLevel =
        Namespaced_IRI.parse _namespace_name "FibreContaminationLevel" |> NamespacedName

    /// <summary>
    /// A set of gears with its casing, aimed at increasing or reducing speed.
    /// <see href="https://w3id.org/wfont#Gearbox"></see></summary>
    let Gearbox = Namespaced_IRI.parse _namespace_name "Gearbox" |> NamespacedName

    /// <summary>
    /// Relation that links a Gearbox to the indicators that describe its situation.
    /// <see href="https://w3id.org/wfont#hasIndicator"></see></summary>
    let hasIndicator =
        Namespaced_IRI.parse _namespace_name "hasIndicator" |> NamespacedName

    /// <summary>
    /// Relation that links an element and the parts is composed of.
    /// <see href="https://w3id.org/wfont#hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// It is a rotating circular machine part having teeth which mesh with another (compatible) toothed part to transmit (convert) torque and speed.
    /// <see href="https://w3id.org/wfont#GearboxGears"></see></summary>
    let GearboxGears =
        Namespaced_IRI.parse _namespace_name "GearboxGears" |> NamespacedName

    /// <summary>
    /// A protective casing providing a reservoir of oil or grease for the gearing.
    /// <see href="https://w3id.org/wfont#GearboxHousing"></see></summary>
    let GearboxHousing =
        Namespaced_IRI.parse _namespace_name "GearboxHousing" |> NamespacedName

    /// <summary>
    /// Constituting part or element of a gearbox.
    /// <see href="https://w3id.org/wfont#GearboxComponent"></see></summary>
    let GearboxComponent =
        Namespaced_IRI.parse _namespace_name "GearboxComponent" |> NamespacedName

    /// <summary>
    /// The ouput shaft of the gearbox witch has empty space inside.
    /// <see href="https://w3id.org/wfont#HollowShaft"></see></summary>
    let HollowShaft =
        Namespaced_IRI.parse _namespace_name "HollowShaft" |> NamespacedName

    /// <summary>
    /// Flexible tube and part attached to it where lube is carried.
    /// <see href="https://w3id.org/wfont#Hose-Fitting"></see></summary>
    let ``Hose-Fitting`` =
        Namespaced_IRI.parse _namespace_name "Hose-Fitting" |> NamespacedName

    /// <summary>
    /// Number of particles per milimiter bigger than 14 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.
    /// <see href="https://w3id.org/wfont#ISO14"></see></summary>
    let ISO14 = Namespaced_IRI.parse _namespace_name "ISO14" |> NamespacedName
    /// <summary>
    /// Number of particles per milimiter bigger than 4 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.
    /// <see href="https://w3id.org/wfont#ISO4"></see></summary>
    let ISO4 = Namespaced_IRI.parse _namespace_name "ISO4" |> NamespacedName
    /// <summary>
    /// Number of particles per milimiter bigger than 6 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.
    /// <see href="https://w3id.org/wfont#ISO6"></see></summary>
    let ISO6 = Namespaced_IRI.parse _namespace_name "ISO6" |> NamespacedName
    /// <summary>
    /// Circulates the lubricant from the lube system.
    /// <see href="https://w3id.org/wfont#LubePump"></see></summary>
    let LubePump = Namespaced_IRI.parse _namespace_name "LubePump" |> NamespacedName

    /// <summary>
    /// It supplies motive power to the pump.
    /// <see href="https://w3id.org/wfont#LubePumpMotor"></see></summary>
    let LubePumpMotor =
        Namespaced_IRI.parse _namespace_name "LubePumpMotor" |> NamespacedName

    /// <summary>
    /// A housing which contains the drive‑train and other elements on top of a horizontal axis wind turbine tower.
    /// <see href="https://w3id.org/wfont#Nacelle"></see></summary>
    let Nacelle = Namespaced_IRI.parse _namespace_name "Nacelle" |> NamespacedName

    /// <summary>
    /// State of the oil degradation level in the different stages of its useful life.
    /// <see href="https://w3id.org/wfont#OilDegradation"></see></summary>
    let OilDegradation =
        Namespaced_IRI.parse _namespace_name "OilDegradation" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for oil degradation in the oil, it is calculated using OD parameter of the sensor.
    /// <see href="https://w3id.org/wfont#OilDegradationLevel"></see></summary>
    let OilDegradationLevel =
        Namespaced_IRI.parse _namespace_name "OilDegradationLevel" |> NamespacedName

    /// <summary>
    /// Consists of the bearing mounted in the planet gear.
    /// <see href="https://w3id.org/wfont#PlanetBearing"></see></summary>
    let PlanetBearing =
        Namespaced_IRI.parse _namespace_name "PlanetBearing" |> NamespacedName

    /// <summary>
    /// It is the gear that rotates around the sun gear.
    /// <see href="https://w3id.org/wfont#PlanetGear"></see></summary>
    let PlanetGear = Namespaced_IRI.parse _namespace_name "PlanetGear" |> NamespacedName

    /// <summary>
    /// First step of lube filtration system.
    /// <see href="https://w3id.org/wfont#PrimaryFiltration"></see></summary>
    let PrimaryFiltration =
        Namespaced_IRI.parse _namespace_name "PrimaryFiltration" |> NamespacedName

    /// <summary>
    /// It is a heat exchanger use to transfer thermal energy from one medium to another.
    /// <see href="https://w3id.org/wfont#Radiator"></see></summary>
    let Radiator = Namespaced_IRI.parse _namespace_name "Radiator" |> NamespacedName
    /// <summary>
    /// Lube compartment or tank that collect oil.
    /// <see href="https://w3id.org/wfont#Reservoir"></see></summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName
    /// <summary>
    /// An outer ring with inward-facing teeth that mesh with the planet gear or gears.
    /// <see href="https://w3id.org/wfont#RingGear"></see></summary>
    let RingGear = Namespaced_IRI.parse _namespace_name "RingGear" |> NamespacedName

    /// <summary>
    /// Second step of lube filtration system.
    /// <see href="https://w3id.org/wfont#SecondaryFiltration"></see></summary>
    let SecondaryFiltration =
        Namespaced_IRI.parse _namespace_name "SecondaryFiltration" |> NamespacedName

    /// <summary>
    /// Device that converts a physical pehnomenon into a measurable data. In lube systems, collects information of the oil wear or operation.
    /// <see href="https://w3id.org/wfont#Sensor"></see></summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having big particles in the oil, it is calculated using BigParticles parameter of the sensor.
    /// <see href="https://w3id.org/wfont#SevereWearLevel"></see></summary>
    let SevereWearLevel =
        Namespaced_IRI.parse _namespace_name "SevereWearLevel" |> NamespacedName

    /// <summary>
    /// Bearing which supports the intermediate shafting.
    /// <see href="https://w3id.org/wfont#ShaftBearing"></see></summary>
    let ShaftBearing =
        Namespaced_IRI.parse _namespace_name "ShaftBearing" |> NamespacedName

    /// <summary>
    /// Number of particles related to slidding wear per milimiter.
    /// <see href="https://w3id.org/wfont#Sliding"></see></summary>
    let Sliding = Namespaced_IRI.parse _namespace_name "Sliding" |> NamespacedName
    /// <summary>
    /// It has straight teeth and are parallel to the axis of the wheel.
    /// <see href="https://w3id.org/wfont#SpurGear"></see></summary>
    let SpurGear = Namespaced_IRI.parse _namespace_name "SpurGear" |> NamespacedName
    /// <summary>
    /// It is the central gear.
    /// <see href="https://w3id.org/wfont#SunGear"></see></summary>
    let SunGear = Namespaced_IRI.parse _namespace_name "SunGear" |> NamespacedName

    /// <summary>
    /// Indicates the warning and alarm level for having unclassified particles in the oil, it is calculated using Unknown parameter of the sensor.
    /// <see href="https://w3id.org/wfont#UnclassifiedWearLevel"></see></summary>
    let UnclassifiedWearLevel =
        Namespaced_IRI.parse _namespace_name "UnclassifiedWearLevel" |> NamespacedName

    /// <summary>
    /// Number of particles related to unknown particles per milimiter.
    /// <see href="https://w3id.org/wfont#Unknown"></see></summary>
    let Unknown = Namespaced_IRI.parse _namespace_name "Unknown" |> NamespacedName
    /// <summary>
    /// A group of wind turbine generator jointly operated.
    /// <see href="https://w3id.org/wfont#WindFarm"></see></summary>
    let WindFarm = Namespaced_IRI.parse _namespace_name "WindFarm" |> NamespacedName

    /// <summary>
    /// A rotating machinery in which the kinetic wind energy is transformed into another form of energy.
    /// <see href="https://w3id.org/wfont#WindTurbine"></see></summary>
    let WindTurbine =
        Namespaced_IRI.parse _namespace_name "WindTurbine" |> NamespacedName
