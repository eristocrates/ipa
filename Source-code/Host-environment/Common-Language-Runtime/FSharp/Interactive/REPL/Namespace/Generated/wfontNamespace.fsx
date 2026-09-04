#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module wfont =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/wfont#" "wfont"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Abrasive Wear Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having abrasive particles in the oil, it is calculated using Cutting parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#AbrasiveWearLevel">wfont:AbrasiveWearLevel</a>
    /// </summary>
    let AbrasiveWearLevel = _prefixId.prefix "AbrasiveWearLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Adhesive Wear Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having sliding particles in the oil, it is calculated using Sliding parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#AdhesiveWearLevel">wfont:AdhesiveWearLevel</a>
    /// </summary>
    let AdhesiveWearLevel = _prefixId.prefix "AdhesiveWearLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Air Content Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having bubbles in the oil, it is calculated using Bubbles parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#AirContentLevel">wfont:AirContentLevel</a>
    /// </summary>
    let AirContentLevel = _prefixId.prefix "AirContentLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Big Bubbles</para>
    ///   <para>rdfs:comment : Number of bubbles per milimiter bigger than 21 μm.</para>
    ///   <a href="https://w3id.org/wfont#BigBubbles">wfont:BigBubbles</a>
    /// </summary>
    let BigBubbles = _prefixId.prefix "BigBubbles"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Big Particles</para>
    ///   <para>rdfs:comment : Number of particles per milimiter bigger than 21 μm.</para>
    ///   <a href="https://w3id.org/wfont#BigParticles">wfont:BigParticles</a>
    /// </summary>
    let BigParticles = _prefixId.prefix "BigParticles"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Bubbles</para>
    ///   <para>rdfs:comment : Number of bubbles per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Bubbles">wfont:Bubbles</a>
    /// </summary>
    let Bubbles = _prefixId.prefix "Bubbles"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Bujerdfs:label : Bushing</para>
    ///   <para>rdfs:comment : A mechanical device used to reduce vibrations.</para>
    ///   <a href="https://w3id.org/wfont#Bushing">wfont:Bushing</a>
    /// </summary>
    let Bushing = _prefixId.prefix "Bushing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Carrier Bearingrdfs:label : Rodamiento Portador</para>
    ///   <para>rdfs:comment : It is the bearing that support the carrier. The carrier holds the planet gears at different radio from the sun gear centerline.</para>
    ///   <a href="https://w3id.org/wfont#CarrierBearing">wfont:CarrierBearing</a>
    /// </summary>
    let CarrierBearing = _prefixId.prefix "CarrierBearing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Cleanliness Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having particles in the oil, it is calculated using ISO4, ISO6 and ISO14 parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#CleanlinessLevel">wfont:CleanlinessLevel</a>
    /// </summary>
    let CleanlinessLevel = _prefixId.prefix "CleanlinessLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Bomba de Refrigeranterdfs:label : Coolant Pump</para>
    ///   <para>rdfs:comment : Circulates the liquid from the cooling system.</para>
    ///   <a href="https://w3id.org/wfont#CoolantPump">wfont:CoolantPump</a>
    /// </summary>
    let CoolantPump = _prefixId.prefix "CoolantPump"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Cooling Systemrdfs:label : Sistema de Refrigeración</para>
    ///   <para>rdfs:comment : Reduces the temperature of the oil from the lubricating system.</para>
    ///   <a href="https://w3id.org/wfont#CoolingSystem">wfont:CoolingSystem</a>
    /// </summary>
    let CoolingSystem = _prefixId.prefix "CoolingSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Cutting</para>
    ///   <para>rdfs:comment : Number of particles related to cutting wear per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Cutting">wfont:Cutting</a>
    /// </summary>
    let Cutting = _prefixId.prefix "Cutting"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fatigue</para>
    ///   <para>rdfs:comment : Number of particles related to fatigue wear per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Fatigue">wfont:Fatigue</a>
    /// </summary>
    let Fatigue = _prefixId.prefix "Fatigue"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fatigue Wear Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having fatigue particles in the oil, it is calculated using Fatigue parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#FatigueWearLevel">wfont:FatigueWearLevel</a>
    /// </summary>
    let FatigueWearLevel = _prefixId.prefix "FatigueWearLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fiber</para>
    ///   <para>rdfs:comment : Number of particles related to fiber particles per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Fiber">wfont:Fiber</a>
    /// </summary>
    let Fiber = _prefixId.prefix "Fiber"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Fibre Contamination Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having fibre particles in the oil, it is calculated using Fibre parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#FibreContaminationLevel">wfont:FibreContaminationLevel</a>
    /// </summary>
    let FibreContaminationLevel = _prefixId.prefix "FibreContaminationLevel"
    /// <summary>
    ///   <para>rdfs:label : Gearboxrdfs:label : Multiplicadora</para>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:comment : A set of gears with its casing, aimed at increasing or reducing speed.</para>
    ///   <a href="https://w3id.org/wfont#Gearbox">wfont:Gearbox</a>
    /// </summary>
    let Gearbox = _prefixId.prefix "Gearbox"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Bearingrdfs:label : Rodamiento</para>
    ///   <para>rdfs:comment : Consists of rings with raceway (inner ring and outer ring), rolling elements (either balls or rollers) and cage. The cage separates the rolling elements at regular intervals, holds them in place within the inner and outer raceways, and allows them to rotate freely.</para>
    ///   <a href="https://w3id.org/wfont#GearboxBearing">wfont:GearboxBearing</a>
    /// </summary>
    let GearboxBearing = _prefixId.prefix "GearboxBearing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Componente de Multiplicadorardfs:label : Gearbox Component</para>
    ///   <para>rdfs:comment : Constituting part or element of a gearbox.</para>
    ///   <a href="https://w3id.org/wfont#GearboxComponent">wfont:GearboxComponent</a>
    /// </summary>
    let GearboxComponent = _prefixId.prefix "GearboxComponent"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Engranajerdfs:label : Gears</para>
    ///   <para>rdfs:comment : It is a rotating circular machine part having teeth which mesh with another (compatible) toothed part to transmit (convert) torque and speed.</para>
    ///   <a href="https://w3id.org/wfont#GearboxGears">wfont:GearboxGears</a>
    /// </summary>
    let GearboxGears = _prefixId.prefix "GearboxGears"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Alojamientordfs:label : Housing</para>
    ///   <para>rdfs:comment : A protective casing providing a reservoir of oil or grease for the gearing.</para>
    ///   <a href="https://w3id.org/wfont#GearboxHousing">wfont:GearboxHousing</a>
    /// </summary>
    let GearboxHousing = _prefixId.prefix "GearboxHousing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Lube Systemrdfs:label : Sistema de Lubricación</para>
    ///   <para>rdfs:comment : It controls the shifting process of the transmission, lubrication of the transmission parts to prevent frictional damage, and cooling of the transmission. </para>
    ///   <a href="https://w3id.org/wfont#GearboxLubeSystem">wfont:GearboxLubeSystem</a>
    /// </summary>
    let GearboxLubeSystem = _prefixId.prefix "GearboxLubeSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Sistema de Brazo de Torquerdfs:label : Torque Arm System</para>
    ///   <para>rdfs:comment : It is a long suspension arm that attaches between the housing and the Nacelle. Its primary job is to control axle housing rotation.</para>
    ///   <a href="https://w3id.org/wfont#GearboxTorqueArmSystem">wfont:GearboxTorqueArmSystem</a>
    /// </summary>
    let GearboxTorqueArmSystem = _prefixId.prefix "GearboxTorqueArmSystem"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Eje huecordfs:label : Hollow Shaft</para>
    ///   <para>rdfs:comment : The ouput shaft of the gearbox witch has empty space inside.</para>
    ///   <a href="https://w3id.org/wfont#HollowShaft">wfont:HollowShaft</a>
    /// </summary>
    let HollowShaft = _prefixId.prefix "HollowShaft"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Hose/Fittingrdfs:label : Manguera</para>
    ///   <para>rdfs:comment : Flexible tube and part attached to it where lube is carried.</para>
    ///   <a href="https://w3id.org/wfont#Hose-Fitting">wfont:Hose-Fitting</a>
    /// </summary>
    let Hose_Fitting = _prefixId.prefix "Hose-Fitting"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ISO14</para>
    ///   <para>rdfs:comment : Number of particles per milimiter bigger than 14 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.</para>
    ///   <a href="https://w3id.org/wfont#ISO14">wfont:ISO14</a>
    /// </summary>
    let ISO14 = _prefixId.prefix "ISO14"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ISO4</para>
    ///   <para>rdfs:comment : Number of particles per milimiter bigger than 4 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.</para>
    ///   <a href="https://w3id.org/wfont#ISO4">wfont:ISO4</a>
    /// </summary>
    let ISO4 = _prefixId.prefix "ISO4"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : ISO6</para>
    ///   <para>rdfs:comment : Number of particles per milimiter bigger than 6 μm. Related to ISO 4406:1999 method for coding the level of contamination by solid particles.</para>
    ///   <a href="https://w3id.org/wfont#ISO6">wfont:ISO6</a>
    /// </summary>
    let ISO6 = _prefixId.prefix "ISO6"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Indicadorrdfs:label : Indicator</para>
    ///   <para>rdfs:comment : Something that shows what a situation is like.</para>
    ///   <a href="https://w3id.org/wfont#Indicator">wfont:Indicator</a>
    /// </summary>
    let Indicator = _prefixId.prefix "Indicator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Bomba de Lubricaciónrdfs:label : Lube Pump</para>
    ///   <para>rdfs:comment : Circulates the lubricant from the lube system.</para>
    ///   <a href="https://w3id.org/wfont#LubePump">wfont:LubePump</a>
    /// </summary>
    let LubePump = _prefixId.prefix "LubePump"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Lube Pump Motorrdfs:label : Motor de Bomba de Lubricación</para>
    ///   <para>rdfs:comment : It supplies motive power to the pump.</para>
    ///   <a href="https://w3id.org/wfont#LubePumpMotor">wfont:LubePumpMotor</a>
    /// </summary>
    let LubePumpMotor = _prefixId.prefix "LubePumpMotor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Góndolardfs:label : Nacelle</para>
    ///   <para>rdfs:comment : A housing which contains the drive‑train and other elements on top of a horizontal axis wind turbine tower.</para>
    ///   <a href="https://w3id.org/wfont#Nacelle">wfont:Nacelle</a>
    /// </summary>
    let Nacelle = _prefixId.prefix "Nacelle"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Oil Degradation</para>
    ///   <para>rdfs:comment : State of the oil degradation level in the different stages of its useful life.</para>
    ///   <a href="https://w3id.org/wfont#OilDegradation">wfont:OilDegradation</a>
    /// </summary>
    let OilDegradation = _prefixId.prefix "OilDegradation"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Oil Degradation Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for oil degradation in the oil, it is calculated using OD parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#OilDegradationLevel">wfont:OilDegradationLevel</a>
    /// </summary>
    let OilDegradationLevel = _prefixId.prefix "OilDegradationLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Particles</para>
    ///   <para>rdfs:comment : Number of particles per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Particles">wfont:Particles</a>
    /// </summary>
    let Particles = _prefixId.prefix "Particles"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Planet Bearingrdfs:label : Rodamiento Planetario</para>
    ///   <para>rdfs:comment : Consists of the bearing mounted in the planet gear.</para>
    ///   <a href="https://w3id.org/wfont#PlanetBearing">wfont:PlanetBearing</a>
    /// </summary>
    let PlanetBearing = _prefixId.prefix "PlanetBearing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Engranaje Planetariordfs:label : Planet Gear</para>
    ///   <para>rdfs:comment : It is the gear that rotates around the sun gear.</para>
    ///   <a href="https://w3id.org/wfont#PlanetGear">wfont:PlanetGear</a>
    /// </summary>
    let PlanetGear = _prefixId.prefix "PlanetGear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Filtración Primariardfs:label : Primary Filtration</para>
    ///   <para>rdfs:comment : First step of lube filtration system.</para>
    ///   <a href="https://w3id.org/wfont#PrimaryFiltration">wfont:PrimaryFiltration</a>
    /// </summary>
    let PrimaryFiltration = _prefixId.prefix "PrimaryFiltration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Radiadorrdfs:label : Radiator</para>
    ///   <para>rdfs:comment : It is a heat exchanger use to transfer thermal energy from one medium to another.</para>
    ///   <a href="https://w3id.org/wfont#Radiator">wfont:Radiator</a>
    /// </summary>
    let Radiator = _prefixId.prefix "Radiator"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Depósitordfs:label : Reservoir</para>
    ///   <para>rdfs:comment : Lube compartment or tank that collect oil.</para>
    ///   <a href="https://w3id.org/wfont#Reservoir">wfont:Reservoir</a>
    /// </summary>
    let Reservoir = _prefixId.prefix "Reservoir"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Engranaje de Anillordfs:label : Ring Gear</para>
    ///   <para>rdfs:comment : An outer ring with inward-facing teeth that mesh with the planet gear or gears.</para>
    ///   <a href="https://w3id.org/wfont#RingGear">wfont:RingGear</a>
    /// </summary>
    let RingGear = _prefixId.prefix "RingGear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Filtración Secundariardfs:label : Secondary Filtration</para>
    ///   <para>rdfs:comment : Second step of lube filtration system.</para>
    ///   <a href="https://w3id.org/wfont#SecondaryFiltration">wfont:SecondaryFiltration</a>
    /// </summary>
    let SecondaryFiltration = _prefixId.prefix "SecondaryFiltration"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Sensorrdfs:label : Sensor</para>
    ///   <para>rdfs:comment : Device that converts a physical pehnomenon into a measurable data. In lube systems, collects information of the oil wear or operation.</para>
    ///   <a href="https://w3id.org/wfont#Sensor">wfont:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Severe Wear Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having big particles in the oil, it is calculated using BigParticles parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#SevereWearLevel">wfont:SevereWearLevel</a>
    /// </summary>
    let SevereWearLevel = _prefixId.prefix "SevereWearLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Rodamiento de Ejerdfs:label : Shaft Bearing</para>
    ///   <para>rdfs:comment : Bearing which supports the intermediate shafting.</para>
    ///   <a href="https://w3id.org/wfont#ShaftBearing">wfont:ShaftBearing</a>
    /// </summary>
    let ShaftBearing = _prefixId.prefix "ShaftBearing"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Sliding</para>
    ///   <para>rdfs:comment : Number of particles related to slidding wear per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Sliding">wfont:Sliding</a>
    /// </summary>
    let Sliding = _prefixId.prefix "Sliding"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Engranaje Rectordfs:label : Spur Gear</para>
    ///   <para>rdfs:comment : It has straight teeth and are parallel to the axis of the wheel.</para>
    ///   <a href="https://w3id.org/wfont#SpurGear">wfont:SpurGear</a>
    /// </summary>
    let SpurGear = _prefixId.prefix "SpurGear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Engranaje Solarrdfs:label : Sun Gear</para>
    ///   <para>rdfs:comment : It is the central gear.</para>
    ///   <a href="https://w3id.org/wfont#SunGear">wfont:SunGear</a>
    /// </summary>
    let SunGear = _prefixId.prefix "SunGear"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Unclassified Wear Level</para>
    ///   <para>rdfs:comment : Indicates the warning and alarm level for having unclassified particles in the oil, it is calculated using Unknown parameter of the sensor.</para>
    ///   <a href="https://w3id.org/wfont#UnclassifiedWearLevel">wfont:UnclassifiedWearLevel</a>
    /// </summary>
    let UnclassifiedWearLevel = _prefixId.prefix "UnclassifiedWearLevel"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Unknown</para>
    ///   <para>rdfs:comment : Number of particles related to unknown particles per milimiter.</para>
    ///   <a href="https://w3id.org/wfont#Unknown">wfont:Unknown</a>
    /// </summary>
    let Unknown = _prefixId.prefix "Unknown"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:seeAlso : SAND2009-1171 Report - Appendix A: Taxonomy^^xsd:string</para>
    ///   <para>rdfs:label : Parque Eólicordfs:label : Wind Farm</para>
    ///   <para>rdfs:comment : A group of wind turbine generator jointly operated.</para>
    ///   <a href="https://w3id.org/wfont#WindFarm">wfont:WindFarm</a>
    /// </summary>
    let WindFarm = _prefixId.prefix "WindFarm"
    /// <summary>
    ///   <para>vs:term_status : stable^^xsd:string</para>
    ///   <para>rdfs:label : Aerogeneradorrdfs:label : Wind Turbine</para>
    ///   <para>rdfs:comment : A rotating machinery in which the kinetic wind energy is transformed into another form of energy.</para>
    ///   <a href="https://w3id.org/wfont#WindTurbine">wfont:WindTurbine</a>
    /// </summary>
    let WindTurbine = _prefixId.prefix "WindTurbine"
    /// <summary>
    ///   <para>rdfs:label : hasIndicatorrdfs:label : tieneIndicador</para>
    ///   <para>rdfs:comment : Relation that links a Gearbox to the indicators that describe its situation.^^xsd:string</para>
    ///   <a href="https://w3id.org/wfont#hasIndicator">wfont:hasIndicator</a>
    /// </summary>
    let hasIndicator = _prefixId.prefix "hasIndicator"
    /// <summary>
    ///   <para>rdfs:label : hasPartrdfs:label : tieneParte</para>
    ///   <para>rdfs:comment : Relation that links an element and the parts is composed of.^^xsd:string</para>
    ///   <a href="https://w3id.org/wfont#hasPart">wfont:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
