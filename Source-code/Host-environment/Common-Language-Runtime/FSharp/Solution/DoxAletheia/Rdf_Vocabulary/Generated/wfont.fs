namespace https.w3id.org.wfont.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module wfont =
    let _namespace_iri = Namespace_Iri wfont |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:wfont#</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/wfont#">https://w3id.org/wfont#</seealso>
    let _prefix_iri = Prefixed_Name(wfont, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#AbrasiveWearLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having abrasive particles in the oil, it is calculated using Cutting parameter of the sensor."</para>
    /// labels<para>"Abrasive Wear Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#AbrasiveWearLevel">https://w3id.org/wfont#AbrasiveWearLevel</seealso>
    let AbrasiveWearLevel = Prefixed_Name(wfont, "AbrasiveWearLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#AdhesiveWearLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having sliding particles in the oil, it is calculated using Sliding parameter of the sensor."</para>
    /// labels<para>"Adhesive Wear Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#AdhesiveWearLevel">https://w3id.org/wfont#AdhesiveWearLevel</seealso>
    let AdhesiveWearLevel = Prefixed_Name(wfont, "AdhesiveWearLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#AirContentLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having bubbles in the oil, it is calculated using Bubbles parameter of the sensor."</para>
    /// labels<para>"Air Content Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#AirContentLevel">https://w3id.org/wfont#AirContentLevel</seealso>
    let AirContentLevel = Prefixed_Name(wfont, "AirContentLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#BigBubbles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of bubbles per milimiter bigger than 21 μm."</para>
    /// labels<para>"Big Bubbles"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#BigBubbles">https://w3id.org/wfont#BigBubbles</seealso>
    let BigBubbles = Prefixed_Name(wfont, "BigBubbles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#BigParticles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles per milimiter bigger than 21 μm."</para>
    /// labels<para>"Big Particles"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#BigParticles">https://w3id.org/wfont#BigParticles</seealso>
    let BigParticles = Prefixed_Name(wfont, "BigParticles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Bubbles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of bubbles per milimiter."</para>
    /// labels<para>"Bubbles"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Bubbles">https://w3id.org/wfont#Bubbles</seealso>
    let Bubbles = Prefixed_Name(wfont, "Bubbles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Bushing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A mechanical device used to reduce vibrations."</para>
    /// labels<para>"Bushing"</para><para>"Buje"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Bushing">https://w3id.org/wfont#Bushing</seealso>
    let Bushing = Prefixed_Name(wfont, "Bushing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#CarrierBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the bearing that support the carrier. The carrier holds the planet gears at different radio from the sun gear centerline."</para>
    /// labels<para>"Carrier Bearing"</para><para>"Rodamiento Portador"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#CarrierBearing">https://w3id.org/wfont#CarrierBearing</seealso>
    let CarrierBearing = Prefixed_Name(wfont, "CarrierBearing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#CleanlinessLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having particles in the oil, it is calculated using ISO4, ISO6 and ISO14 parameter of the sensor."</para>
    /// labels<para>"Cleanliness Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#CleanlinessLevel">https://w3id.org/wfont#CleanlinessLevel</seealso>
    let CleanlinessLevel = Prefixed_Name(wfont, "CleanlinessLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#CoolantPump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Circulates the liquid from the cooling system."</para>
    /// labels<para>"Coolant Pump"</para><para>"Bomba de Refrigerante"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#CoolantPump">https://w3id.org/wfont#CoolantPump</seealso>
    let CoolantPump = Prefixed_Name(wfont, "CoolantPump") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#CoolingSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Reduces the temperature of the oil from the lubricating system."</para>
    /// labels<para>"Cooling System"</para><para>"Sistema de Refrigeración"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#CoolingSystem">https://w3id.org/wfont#CoolingSystem</seealso>
    let CoolingSystem = Prefixed_Name(wfont, "CoolingSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Cutting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles related to cutting wear per milimiter."</para>
    /// labels<para>"Cutting"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Cutting">https://w3id.org/wfont#Cutting</seealso>
    let Cutting = Prefixed_Name(wfont, "Cutting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Fatigue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles related to fatigue wear per milimiter."</para>
    /// labels<para>"Fatigue"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Fatigue">https://w3id.org/wfont#Fatigue</seealso>
    let Fatigue = Prefixed_Name(wfont, "Fatigue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#FatigueWearLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having fatigue particles in the oil, it is calculated using Fatigue parameter of the sensor."</para>
    /// labels<para>"Fatigue Wear Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#FatigueWearLevel">https://w3id.org/wfont#FatigueWearLevel</seealso>
    let FatigueWearLevel = Prefixed_Name(wfont, "FatigueWearLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Fiber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles related to fiber particles per milimiter."</para>
    /// labels<para>"Fiber"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Fiber">https://w3id.org/wfont#Fiber</seealso>
    let Fiber = Prefixed_Name(wfont, "Fiber") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#FibreContaminationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having fibre particles in the oil, it is calculated using Fibre parameter of the sensor."</para>
    /// labels<para>"Fibre Contamination Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#FibreContaminationLevel">https://w3id.org/wfont#FibreContaminationLevel</seealso>
    let FibreContaminationLevel =
        Prefixed_Name(wfont, "FibreContaminationLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#Gearbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A set of gears with its casing, aimed at increasing or reducing speed."</para>
    /// labels<para>"Gearbox"</para><para>"Multiplicadora"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Gearbox">https://w3id.org/wfont#Gearbox</seealso>
    let Gearbox = Prefixed_Name(wfont, "Gearbox") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#GearboxBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Consists of rings with raceway (inner ring and outer ring), rolling elements (either balls or rollers) and cage. The cage separates the rolling elements at regular intervals, holds them in place within the inner and outer raceways, and allows them to rotate freely."</para>
    /// labels<para>"Bearing"</para><para>"Rodamiento"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#GearboxBearing">https://w3id.org/wfont#GearboxBearing</seealso>
    let GearboxBearing = Prefixed_Name(wfont, "GearboxBearing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#GearboxComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Constituting part or element of a gearbox."</para>
    /// labels<para>"Gearbox Component"</para><para>"Componente de Multiplicadora"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#GearboxComponent">https://w3id.org/wfont#GearboxComponent</seealso>
    let GearboxComponent = Prefixed_Name(wfont, "GearboxComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#GearboxGears</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a rotating circular machine part having teeth which mesh with another (compatible) toothed part to transmit (convert) torque and speed."</para>
    /// labels<para>"Gears"</para><para>"Engranaje"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#GearboxGears">https://w3id.org/wfont#GearboxGears</seealso>
    let GearboxGears = Prefixed_Name(wfont, "GearboxGears") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#GearboxHousing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A protective casing providing a reservoir of oil or grease for the gearing."</para>
    /// labels<para>"Housing"</para><para>"Alojamiento"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#GearboxHousing">https://w3id.org/wfont#GearboxHousing</seealso>
    let GearboxHousing = Prefixed_Name(wfont, "GearboxHousing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#GearboxLubeSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It controls the shifting process of the transmission, lubrication of the transmission parts to prevent frictional damage, and cooling of the transmission. "</para>
    /// labels<para>"Sistema de Lubricación"</para><para>"Lube System"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#GearboxLubeSystem">https://w3id.org/wfont#GearboxLubeSystem</seealso>
    let GearboxLubeSystem = Prefixed_Name(wfont, "GearboxLubeSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#GearboxTorqueArmSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a long suspension arm that attaches between the housing and the Nacelle. Its primary job is to control axle housing rotation."</para>
    /// labels<para>"Sistema de Brazo de Torque"</para><para>"Torque Arm System"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#GearboxTorqueArmSystem">https://w3id.org/wfont#GearboxTorqueArmSystem</seealso>
    let GearboxTorqueArmSystem =
        Prefixed_Name(wfont, "GearboxTorqueArmSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#HollowShaft</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ouput shaft of the gearbox witch has empty space inside."</para>
    /// labels<para>"Eje hueco"</para><para>"Hollow Shaft"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#HollowShaft">https://w3id.org/wfont#HollowShaft</seealso>
    let HollowShaft = Prefixed_Name(wfont, "HollowShaft") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Hose-Fitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Flexible tube and part attached to it where lube is carried."</para>
    /// labels<para>"Manguera"</para><para>"Hose/Fitting"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Hose-Fitting">https://w3id.org/wfont#Hose-Fitting</seealso>
    let Hose_Fitting = Prefixed_Name(wfont, "Hose-Fitting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#ISO14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles per milimiter bigger than 14 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles."</para>
    /// labels<para>"ISO14"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#ISO14">https://w3id.org/wfont#ISO14</seealso>
    let ISO14 = Prefixed_Name(wfont, "ISO14") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#ISO4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles per milimiter bigger than 4 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles."</para>
    /// labels<para>"ISO4"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#ISO4">https://w3id.org/wfont#ISO4</seealso>
    let ISO4 = Prefixed_Name(wfont, "ISO4") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#ISO6</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles per milimiter bigger than 6 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles."</para>
    /// labels<para>"ISO6"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#ISO6">https://w3id.org/wfont#ISO6</seealso>
    let ISO6 = Prefixed_Name(wfont, "ISO6") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Indicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Something that shows what a situation is like."</para>
    /// labels<para>"Indicator"</para><para>"Indicador"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Indicator">https://w3id.org/wfont#Indicator</seealso>
    let Indicator = Prefixed_Name(wfont, "Indicator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#LubePump</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Circulates the lubricant from the lube system."</para>
    /// labels<para>"Bomba de Lubricación"</para><para>"Lube Pump"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#LubePump">https://w3id.org/wfont#LubePump</seealso>
    let LubePump = Prefixed_Name(wfont, "LubePump") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#LubePumpMotor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It supplies motive power to the pump."</para>
    /// labels<para>"Motor de Bomba de Lubricación"</para><para>"Lube Pump Motor"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#LubePumpMotor">https://w3id.org/wfont#LubePumpMotor</seealso>
    let LubePumpMotor = Prefixed_Name(wfont, "LubePumpMotor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Nacelle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A housing which contains the drive‑train and other elements on top of a horizontal axis wind turbine tower."</para>
    /// labels<para>"Góndola"</para><para>"Nacelle"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Nacelle">https://w3id.org/wfont#Nacelle</seealso>
    let Nacelle = Prefixed_Name(wfont, "Nacelle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#OilDegradation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"State of the oil degradation level in the different stages of its useful life."</para>
    /// labels<para>"Oil Degradation"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#OilDegradation">https://w3id.org/wfont#OilDegradation</seealso>
    let OilDegradation = Prefixed_Name(wfont, "OilDegradation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#OilDegradationLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for oil degradation in the oil, it is calculated using OD parameter of the sensor."</para>
    /// labels<para>"Oil Degradation Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#OilDegradationLevel">https://w3id.org/wfont#OilDegradationLevel</seealso>
    let OilDegradationLevel =
        Prefixed_Name(wfont, "OilDegradationLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#Particles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles per milimiter."</para>
    /// labels<para>"Particles"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Particles">https://w3id.org/wfont#Particles</seealso>
    let Particles = Prefixed_Name(wfont, "Particles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#PlanetBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Consists of the bearing mounted in the planet gear."</para>
    /// labels<para>"Rodamiento Planetario"</para><para>"Planet Bearing"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#PlanetBearing">https://w3id.org/wfont#PlanetBearing</seealso>
    let PlanetBearing = Prefixed_Name(wfont, "PlanetBearing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#PlanetGear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the gear that rotates around the sun gear."</para>
    /// labels<para>"Planet Gear"</para><para>"Engranaje Planetario"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#PlanetGear">https://w3id.org/wfont#PlanetGear</seealso>
    let PlanetGear = Prefixed_Name(wfont, "PlanetGear") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#PrimaryFiltration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"First step of lube filtration system."</para>
    /// labels<para>"Filtración Primaria"</para><para>"Primary Filtration"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#PrimaryFiltration">https://w3id.org/wfont#PrimaryFiltration</seealso>
    let PrimaryFiltration = Prefixed_Name(wfont, "PrimaryFiltration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Radiator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is a heat exchanger use to transfer thermal energy from one medium to another."</para>
    /// labels<para>"Radiator"</para><para>"Radiador"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Radiator">https://w3id.org/wfont#Radiator</seealso>
    let Radiator = Prefixed_Name(wfont, "Radiator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Reservoir</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Lube compartment or tank that collect oil."</para>
    /// labels<para>"Depósito"</para><para>"Reservoir"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Reservoir">https://w3id.org/wfont#Reservoir</seealso>
    let Reservoir = Prefixed_Name(wfont, "Reservoir") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#RingGear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An outer ring with inward-facing teeth that mesh with the planet gear or gears."</para>
    /// labels<para>"Engranaje de Anillo"</para><para>"Ring Gear"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#RingGear">https://w3id.org/wfont#RingGear</seealso>
    let RingGear = Prefixed_Name(wfont, "RingGear") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#SecondaryFiltration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Second step of lube filtration system."</para>
    /// labels<para>"Filtración Secundaria"</para><para>"Secondary Filtration"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#SecondaryFiltration">https://w3id.org/wfont#SecondaryFiltration</seealso>
    let SecondaryFiltration =
        Prefixed_Name(wfont, "SecondaryFiltration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that converts a physical pehnomenon into a measurable data. In lube systems, collects information of the oil wear or operation."</para>
    /// labels<para>"Sensor"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Sensor">https://w3id.org/wfont#Sensor</seealso>
    let Sensor = Prefixed_Name(wfont, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#SevereWearLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having big particles in the oil, it is calculated using BigParticles parameter of the sensor."</para>
    /// labels<para>"Severe Wear Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#SevereWearLevel">https://w3id.org/wfont#SevereWearLevel</seealso>
    let SevereWearLevel = Prefixed_Name(wfont, "SevereWearLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#ShaftBearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Bearing which supports the intermediate shafting."</para>
    /// labels<para>"Shaft Bearing"</para><para>"Rodamiento de Eje"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#ShaftBearing">https://w3id.org/wfont#ShaftBearing</seealso>
    let ShaftBearing = Prefixed_Name(wfont, "ShaftBearing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#Sliding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles related to slidding wear per milimiter."</para>
    /// labels<para>"Sliding"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Sliding">https://w3id.org/wfont#Sliding</seealso>
    let Sliding = Prefixed_Name(wfont, "Sliding") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#SpurGear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It has straight teeth and are parallel to the axis of the wheel."</para>
    /// labels<para>"Engranaje Recto"</para><para>"Spur Gear"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#SpurGear">https://w3id.org/wfont#SpurGear</seealso>
    let SpurGear = Prefixed_Name(wfont, "SpurGear") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#SunGear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"It is the central gear."</para>
    /// labels<para>"Sun Gear"</para><para>"Engranaje Solar"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#SunGear">https://w3id.org/wfont#SunGear</seealso>
    let SunGear = Prefixed_Name(wfont, "SunGear") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#UnclassifiedWearLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates the warning and alarm level for having unclassified particles in the oil, it is calculated using Unknown parameter of the sensor."</para>
    /// labels<para>"Unclassified Wear Level"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#UnclassifiedWearLevel">https://w3id.org/wfont#UnclassifiedWearLevel</seealso>
    let UnclassifiedWearLevel =
        Prefixed_Name(wfont, "UnclassifiedWearLevel") |> PrefixedName

    /// <summary>
    ///   <para>w3id:wfont#Unknown</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Number of particles related to unknown particles per milimiter."</para>
    /// labels<para>"Unknown"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#Unknown">https://w3id.org/wfont#Unknown</seealso>
    let Unknown = Prefixed_Name(wfont, "Unknown") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#WindFarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A group of wind turbine generator jointly operated."</para>
    /// labels<para>"Wind Farm"</para><para>"Parque Eólico"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#WindFarm">https://w3id.org/wfont#WindFarm</seealso>
    let WindFarm = Prefixed_Name(wfont, "WindFarm") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#WindTurbine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A rotating machinery in which the kinetic wind energy is transformed into another form of energy."</para>
    /// labels<para>"Wind Turbine"</para><para>"Aerogenerador"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#WindTurbine">https://w3id.org/wfont#WindTurbine</seealso>
    let WindTurbine = Prefixed_Name(wfont, "WindTurbine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#hasIndicator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation that links a Gearbox to the indicators that describe its situation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasIndicator"</para><para>"tieneIndicador"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#hasIndicator">https://w3id.org/wfont#hasIndicator</seealso>
    let hasIndicator = Prefixed_Name(wfont, "hasIndicator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:wfont#hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation that links an element and the parts is composed of."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"hasPart"</para><para>"tieneParte"</para></remarks>
    /// <seealso href="https://w3id.org/wfont#hasPart">https://w3id.org/wfont#hasPart</seealso>
    let hasPart = Prefixed_Name(wfont, "hasPart") |> PrefixedName
