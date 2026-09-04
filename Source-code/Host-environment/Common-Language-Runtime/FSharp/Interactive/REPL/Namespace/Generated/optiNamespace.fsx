#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module opti =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/optimar#" "opti"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Actorrdfs:label : Actor</para>
    ///   <para>rdfs:comment : Un actor que interactúa o gestiona la plataforma eólica.rdfs:comment : An actor that interacts or manages the offshore wind power platform.</para>
    ///   <a href="https://w3id.org/optimar#Actor">opti:Actor</a>
    /// </summary>
    let Actor = _prefixId.prefix "Actor"
    /// <summary>
    ///   <para>rdfs:label : Rol analíticordfs:label : Analytical Role</para>
    ///   <para>rdfs:comment : Rol orientado al analisis de datos y generación de información útil para la toma de decisiones.rdfs:comment : Role focused on data analysis and generation of useful information for decision-making.</para>
    ///   <a href="https://w3id.org/optimar#AnalyticalRole">opti:AnalyticalRole</a>
    /// </summary>
    let AnalyticalRole = _prefixId.prefix "AnalyticalRole"
    /// <summary>
    ///   <para>rdfs:label : Anemómetrordfs:label : Anemometer</para>
    ///   <para>rdfs:comment : Sensor que mide la velocidad y dirección del viento en el parque eólico.rdfs:comment : Sensor that measures wind speed and direction in the wind farm.</para>
    ///   <a href="https://w3id.org/optimar#Anemometer">opti:Anemometer</a>
    /// </summary>
    let Anemometer = _prefixId.prefix "Anemometer"
    /// <summary>
    ///   <para>rdfs:label : Base (subestructura flotante)rdfs:label : Base (floating substructure)</para>
    ///   <para>rdfs:comment : La base que soporta la plataforma flotante.rdfs:comment : The base that supports the floating platform.</para>
    ///   <a href="https://w3id.org/optimar#Base">opti:Base</a>
    /// </summary>
    let Base = _prefixId.prefix "Base"
    /// <summary>
    ///   <para>rdfs:label : Palardfs:label : Blade</para>
    ///   <para>rdfs:comment : Las palas de la turbina que capturan la energía eólica.rdfs:comment : The blades of the turbine that capture the wind energy.</para>
    ///   <a href="https://w3id.org/optimar#Blade">opti:Blade</a>
    /// </summary>
    let Blade = _prefixId.prefix "Blade"
    /// <summary>
    ///   <para>rdfs:label : Administrador de nuberdfs:label : Cloud Administrator</para>
    ///   <para>rdfs:comment : Responsable de la administración y seguridad de los servicios en la nube que procesan los datos de la plataforma.rdfs:comment : Responsible for managing and securing cloud services that process data from the platform.</para>
    ///   <a href="https://w3id.org/optimar#CloudAdministrator">opti:CloudAdministrator</a>
    /// </summary>
    let CloudAdministrator = _prefixId.prefix "CloudAdministrator"
    /// <summary>
    ///   <para>rdfs:label : Componenterdfs:label : Component</para>
    ///   <para>rdfs:comment : Un componente de una plataforma eólica offshore, como las palas, torres, sistema de pitch, etc.rdfs:comment : An component of an offshore wind power platform, such as blades, towers, pitch system, etc.</para>
    ///   <a href="https://w3id.org/optimar#Component">opti:Component</a>
    /// </summary>
    let Component = _prefixId.prefix "Component"
    /// <summary>
    ///   <para>rdfs:label : Rotura de componenterdfs:label : Component Breakage</para>
    ///   <para>rdfs:comment : Fallo originado por la fractura o rotura de un componente de la plataforma eólica.rdfs:comment : Failure caused by the fracture or breakage of an offshore wind turbine component.</para>
    ///   <a href="https://w3id.org/optimar#ComponentBreakage">opti:ComponentBreakage</a>
    /// </summary>
    let ComponentBreakage = _prefixId.prefix "ComponentBreakage"
    /// <summary>
    ///   <para>rdfs:label : Corrosiónrdfs:label : Corrosion</para>
    ///   <para>rdfs:comment : Índice general de corrosión detectada en un componente.rdfs:comment : General corrosion index detected in a component.</para>
    ///   <a href="https://w3id.org/optimar#Corrosion">opti:Corrosion</a>
    /// </summary>
    let Corrosion = _prefixId.prefix "Corrosion"
    /// <summary>
    ///   <para>rdfs:label : Cámara corrosiónrdfs:label : Corrosion Camera</para>
    ///   <para>rdfs:comment : Cámara utilizada para detectar y monitorear corrosión en la estructura de la plataforma.rdfs:comment : Camera used to detect and monitor corrosion in the platform structure.</para>
    ///   <a href="https://w3id.org/optimar#CorrosionCamera">opti:CorrosionCamera</a>
    /// </summary>
    let CorrosionCamera = _prefixId.prefix "CorrosionCamera"
    /// <summary>
    ///   <para>rdfs:label : Evento de Corrosiónrdfs:label : Corrosion Event</para>
    ///   <para>rdfs:comment : Degradación de la estructura metálica de la plataforma por efectos de corrosión.rdfs:comment : Degradation of the platform's metallic structure due to corrosion effects.</para>
    ///   <a href="https://w3id.org/optimar#CorrosionEvent">opti:CorrosionEvent</a>
    /// </summary>
    let CorrosionEvent = _prefixId.prefix "CorrosionEvent"
    /// <summary>
    ///   <para>rdfs:label : Datordfs:label : Data</para>
    ///   <para>rdfs:comment : Una clase general para representar los datos de medición recolectados por sensores u otros sistemas.rdfs:comment : A class for representing the measurement data collected by sensors or other systems.</para>
    ///   <a href="https://w3id.org/optimar#Data">opti:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:label : Analista de datosrdfs:label : Data Analyst</para>
    ///   <para>rdfs:comment : Especialista que analiza los datos recolectados para detectar patrones, fallos y oportunidades de optimización.rdfs:comment : Specialist who analyzes collected data to detect patterns, failures, and optimization opportunities.</para>
    ///   <a href="https://w3id.org/optimar#DataAnalyst">opti:DataAnalyst</a>
    /// </summary>
    let DataAnalyst = _prefixId.prefix "DataAnalyst"
    /// <summary>
    ///   <para>rdfs:label : Deformaciónrdfs:label : Deformation</para>
    ///   <para>rdfs:comment : Grado de deformación registrado en el componente.rdfs:comment : Degree of deformation recorded in the component.</para>
    ///   <a href="https://w3id.org/optimar#Deformation">opti:Deformation</a>
    /// </summary>
    let Deformation = _prefixId.prefix "Deformation"
    /// <summary>
    ///   <para>rdfs:label : Monitor dinámicordfs:label : Dynamic Monitor</para>
    ///   <para>rdfs:comment : Dispositivo que mide parámetros dinámicos de la plataforma como vibraciones y movimientos.rdfs:comment : Device that measures dynamic parameters of the platform, such as vibrations and movements.</para>
    ///   <a href="https://w3id.org/optimar#DynamicMonitor">opti:DynamicMonitor</a>
    /// </summary>
    let DynamicMonitor = _prefixId.prefix "DynamicMonitor"
    /// <summary>
    ///   <para>rdfs:label : Condición ambientalrdfs:label : Environmental Condition</para>
    ///   <para>rdfs:comment : Las condiciones ambientales que afectan a la plataforma eólica, como la velocidad del viento, la temperatura, etc.rdfs:comment : The environmental conditions that affect the offshore wind power platform, such as wind speed, temperature, etc.</para>
    ///   <a href="https://w3id.org/optimar#EnvironmentalCondition">opti:EnvironmentalCondition</a>
    /// </summary>
    let EnvironmentalCondition = _prefixId.prefix "EnvironmentalCondition"
    /// <summary>
    ///   <para>rdfs:label : Eventordfs:label : Event</para>
    ///   <para>rdfs:comment : Un evento que ocurre en la plataforma eólica, como la detección de un fallo.rdfs:comment : An event that occurs in the offshore wind power platform, such as a failure detection.</para>
    ///   <a href="https://w3id.org/optimar#Event">opti:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    /// <summary>
    ///   <para>rdfs:label : Fallordfs:label : Failure</para>
    ///   <para>rdfs:comment : Una clase que representa fallos identificados en la plataforma eólica.rdfs:comment : A class that represents identified failures in the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#Failure">opti:Failure</a>
    /// </summary>
    let Failure = _prefixId.prefix "Failure"
    /// <summary>
    ///   <para>rdfs:label : Evento de fallordfs:label : Failure Event</para>
    ///   <para>rdfs:comment : Evento que representa un fallo detectado en el sistema, debe estar causado por al menos un fallo. rdfs:comment : Event that represents a detected failure in the system, must be caused by at least one failure.</para>
    ///   <a href="https://w3id.org/optimar#FailureEvent">opti:FailureEvent</a>
    /// </summary>
    let FailureEvent = _prefixId.prefix "FailureEvent"
    /// <summary>
    ///   <para>rdfs:label : Plataforma flotanterdfs:label : Floating Platform</para>
    ///   <para>rdfs:comment : Una plataforma flotante que sirve de base para la turbina eólica.rdfs:comment : A floating platform that serves as a base for the wind turbine.</para>
    ///   <a href="https://w3id.org/optimar#FloatingPlatform">opti:FloatingPlatform</a>
    /// </summary>
    let FloatingPlatform = _prefixId.prefix "FloatingPlatform"
    /// <summary>
    ///   <para>rdfs:label : Subestructura flotanterdfs:label : Floating Substructure</para>
    ///   <para>rdfs:comment : La subestructura flotante que permite que la plataforma sea estable en el mar.rdfs:comment : The floating substructure that allows the platform to be stable at sea.</para>
    ///   <a href="https://w3id.org/optimar#FloatingSubstructure">opti:FloatingSubstructure</a>
    /// </summary>
    let FloatingSubstructure = _prefixId.prefix "FloatingSubstructure"
    /// <summary>
    ///   <para>rdfs:label : Sistema de galgasrdfs:label : Gauge System</para>
    ///   <para>rdfs:comment : Sistema de galgas extensiométricas utilizado para medir tensiones y deformaciones en la estructura.rdfs:comment : Strain gauge system used to measure stresses and deformations in the structure.</para>
    ///   <a href="https://w3id.org/optimar#GaugeSystem">opti:GaugeSystem</a>
    /// </summary>
    let GaugeSystem = _prefixId.prefix "GaugeSystem"
    /// <summary>
    ///   <para>rdfs:label : Hubrdfs:label : Hub</para>
    ///   <para>rdfs:comment : La parte central de la turbina donde se conectan las palas.rdfs:comment : The central part of the turbine where the blades are connected.</para>
    ///   <a href="https://w3id.org/optimar#Hub">opti:Hub</a>
    /// </summary>
    let Hub = _prefixId.prefix "Hub"
    /// <summary>
    ///   <para>rdfs:label : Sistema ISUMrdfs:label : ISUM System</para>
    ///   <para>rdfs:comment : Sistema especializado para la monitorización integrada de la plataforma offshore.rdfs:comment : Specialized system for integrated monitoring of the offshore platform.</para>
    ///   <a href="https://w3id.org/optimar#ISUMSystem">opti:ISUMSystem</a>
    /// </summary>
    let ISUMSystem = _prefixId.prefix "ISUMSystem"
    /// <summary>
    ///   <para>rdfs:label : Imagenrdfs:label : Image</para>
    ///   <para>rdfs:comment : Una clase que representa una imagen que soporta la medición.rdfs:comment : A class that represents an image that supports the measurement.</para>
    ///   <a href="https://w3id.org/optimar#Image">opti:Image</a>
    /// </summary>
    let Image = _prefixId.prefix "Image"
    /// <summary>
    ///   <para>rdfs:label : Ubicaciónrdfs:label : Location</para>
    ///   <para>rdfs:comment : La ubicación geográfica de la plataforma eólica.rdfs:comment : The geographic location of the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#Location">opti:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Mantenimientordfs:label : Maintenance</para>
    ///   <para>rdfs:comment : Una clase que representa el mantenimiento de la plataforma eólica.rdfs:comment : A class that represents the maintenance of the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#Maintenance">opti:Maintenance</a>
    /// </summary>
    let Maintenance = _prefixId.prefix "Maintenance"
    /// <summary>
    ///   <para>rdfs:label : Operador de mantenimientordfs:label : Maintenance Operator</para>
    ///   <para>rdfs:comment : Persona encargada de realizar el mantenimiento preventivo y correctivo en la plataforma.rdfs:comment : Person responsible for carrying out preventive and corrective maintenance on the platform.</para>
    ///   <a href="https://w3id.org/optimar#MaintenanceOperator">opti:MaintenanceOperator</a>
    /// </summary>
    let MaintenanceOperator = _prefixId.prefix "MaintenanceOperator"
    /// <summary>
    ///   <para>rdfs:label : Rol de gestiónrdfs:label : Management Role</para>
    ///   <para>rdfs:comment : Rol encargado de la coordinación, planificación y gestión de recursos en la plataforma eólica.rdfs:comment : Role responsible for coordination, planning, and resource management in the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#ManagementRole">opti:ManagementRole</a>
    /// </summary>
    let ManagementRole = _prefixId.prefix "ManagementRole"
    /// <summary>
    ///   <para>rdfs:label : Fatiga del materialrdfs:label : Material Fatigue</para>
    ///   <para>rdfs:comment : Fallo en el material estructural causado por ciclos repetidos de carga.rdfs:comment : Structural material failure caused by repeated load cycles.</para>
    ///   <a href="https://w3id.org/optimar#MaterialFatigue">opti:MaterialFatigue</a>
    /// </summary>
    let MaterialFatigue = _prefixId.prefix "MaterialFatigue"
    /// <summary>
    ///   <para>rdfs:label : Mediciónrdfs:label : Measurement</para>
    ///   <para>rdfs:comment : Representa una medición tomada por un sensor.rdfs:comment : Represents a measurement taken by a sensor.</para>
    ///   <a href="https://w3id.org/optimar#Measurement">opti:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Desalineaciónrdfs:label : Misalignment</para>
    ///   <para>rdfs:comment : Fallo causado por el desajuste o falta de alineación entre los componentes de la plataforma.rdfs:comment : Failure caused by misalignment or lack of proper adjustment between platform components.</para>
    ///   <a href="https://w3id.org/optimar#Misalignment">opti:Misalignment</a>
    /// </summary>
    let Misalignment = _prefixId.prefix "Misalignment"
    /// <summary>
    ///   <para>rdfs:label : Tarea de monitoreordfs:label : Monitoring Task</para>
    ///   <para>rdfs:comment : Una tarea destinada a supervisar el estado de la plataforma mediante sensores y sistemas de monitorización.rdfs:comment : A task aimed at supervising the condition of the platform through sensors and monitoring systems.</para>
    ///   <a href="https://w3id.org/optimar#MonitoringTask">opti:MonitoringTask</a>
    /// </summary>
    let MonitoringTask = _prefixId.prefix "MonitoringTask"
    /// <summary>
    ///   <para>rdfs:label : Sistema de amarrerdfs:label : Mooring System</para>
    ///   <para>rdfs:comment : El sistema de amarre que mantiene la plataforma flotante en su ubicación.rdfs:comment : The mooring system that keeps the floating platform in place.</para>
    ///   <a href="https://w3id.org/optimar#MooringSystem">opti:MooringSystem</a>
    /// </summary>
    let MooringSystem = _prefixId.prefix "MooringSystem"
    /// <summary>
    ///   <para>rdfs:label : Nacellerdfs:label : Nacelle</para>
    ///   <para>rdfs:comment : El compartimento de la turbina que aloja el generador y otros componentes mecánicos.rdfs:comment : The turbine component that houses the generator and other mechanical components.</para>
    ///   <a href="https://w3id.org/optimar#Nacelle">opti:Nacelle</a>
    /// </summary>
    let Nacelle = _prefixId.prefix "Nacelle"
    /// <summary>
    ///   <para>rdfs:label : Observaciónrdfs:label : Observation</para>
    ///   <para>rdfs:comment : El resultado de registrar un fenómeno o condición, normalmente a través de un sensor o sistema de monitorización.rdfs:comment : The result of recording a phenomenon or condition, usually through a sensor or monitoring system.</para>
    ///   <a href="https://w3id.org/optimar#Observation">opti:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>rdfs:label : Propietario de parquerdfs:label : Park Owner</para>
    ///   <para>rdfs:comment : Entidad o persona propietaria del parque eólico offshore y responsable de su operación general.rdfs:comment : Entity or individual owning the offshore wind farm and responsible for its overall operation.</para>
    ///   <a href="https://w3id.org/optimar#ParkOwner">opti:ParkOwner</a>
    /// </summary>
    let ParkOwner = _prefixId.prefix "ParkOwner"
    /// <summary>
    ///   <para>rdfs:label : Sistema de pitchrdfs:label : Pitch System</para>
    ///   <para>rdfs:comment : El sistema que ajusta el ángulo de las palas de la turbina.rdfs:comment : The system that adjusts the angle of the blades of the turbine.</para>
    ///   <a href="https://w3id.org/optimar#PitchSystem">opti:PitchSystem</a>
    /// </summary>
    let PitchSystem = _prefixId.prefix "PitchSystem"
    /// <summary>
    ///   <para>rdfs:label : Actuador de plataformardfs:label : Platform Actuator</para>
    ///   <para>rdfs:comment : Encargado de realizar ajustes sobre la plataforma, como ajustes mecánicos o hidráulicos.rdfs:comment : Responsible for making adjustments on the platform, such as mechanical or hydraulic adjustments.</para>
    ///   <a href="https://w3id.org/optimar#PlatformActuator">opti:PlatformActuator</a>
    /// </summary>
    let PlatformActuator = _prefixId.prefix "PlatformActuator"
    /// <summary>
    ///   <para>rdfs:label : Rolrdfs:label : Role</para>
    ///   <para>rdfs:comment : Los roles de los actores que gestionan, operan o mantienen la plataforma eólica.rdfs:comment : The roles of the actors that manage, operate or maintain the offshore wind power platform.</para>
    ///   <a href="https://w3id.org/optimar#Role">opti:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:label : Sensorrdfs:label : Sensor</para>
    ///   <para>rdfs:comment : Un dispositivo que mide o monitorea parámetros de la plataforma eólica, como viento, corrosión, vibraciones, etc.rdfs:comment : A device that measures or monitors parameters of the wind platform, such as wind, corrosion, vibrations, etc.</para>
    ///   <a href="https://w3id.org/optimar#Sensor">opti:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Datos de tensiónrdfs:label : Stress Data</para>
    ///   <para>rdfs:comment : Datos de tensión medidos por un sensor.rdfs:comment : Stress data measured by a sensor.</para>
    ///   <a href="https://w3id.org/optimar#StressData">opti:StressData</a>
    /// </summary>
    let StressData = _prefixId.prefix "StressData"
    /// <summary>
    ///   <para>rdfs:label : Cámara estructuralrdfs:label : Structural Camera</para>
    ///   <para>rdfs:comment : Cámara dedicada a la inspección visual del estado estructural de la plataforma.rdfs:comment : Camera dedicated to visual inspection of the structural condition of the platform.</para>
    ///   <a href="https://w3id.org/optimar#StructuralCamera">opti:StructuralCamera</a>
    /// </summary>
    let StructuralCamera = _prefixId.prefix "StructuralCamera"
    /// <summary>
    ///   <para>rdfs:label : Componentes estructuralesrdfs:label : Structural Components</para>
    ///   <para>rdfs:comment : Los componentes estructurales que componen la infraestructura básica de la plataforma eólica.rdfs:comment : The structural components that make up the basic infrastructure of the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#StructuralComponent">opti:StructuralComponent</a>
    /// </summary>
    let StructuralComponent = _prefixId.prefix "StructuralComponent"
    /// <summary>
    ///   <para>rdfs:label : Inestabilidad estructuralrdfs:label : Structural Instability</para>
    ///   <para>rdfs:comment : Fallo que compromete la estabilidad estructural de la plataforma flotante.rdfs:comment : Failure that compromises the structural stability of the floating platform.</para>
    ///   <a href="https://w3id.org/optimar#StructuralInstability">opti:StructuralInstability</a>
    /// </summary>
    let StructuralInstability = _prefixId.prefix "StructuralInstability"
    /// <summary>
    ///   <para>rdfs:label : Tareardfs:label : Task</para>
    ///   <para>rdfs:comment : Una tarea general relacionada con la operación, supervisión o mantenimiento de la plataforma eólica.rdfs:comment : A general task related to the operation, monitoring, or maintenance of the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#Task">opti:Task</a>
    /// </summary>
    let Task = _prefixId.prefix "Task"
    /// <summary>
    ///   <para>rdfs:label : Rol técnicordfs:label : Technical Role</para>
    ///   <para>rdfs:comment : Rol asociado a actividades técnicas como operación, reparación y supervisión de sistemas.rdfs:comment : Role associated with technical activities such as operation, repair, and system supervision.</para>
    ///   <a href="https://w3id.org/optimar#TechnicalRole">opti:TechnicalRole</a>
    /// </summary>
    let TechnicalRole = _prefixId.prefix "TechnicalRole"
    /// <summary>
    ///   <para>rdfs:label : Torrerdfs:label : Tower</para>
    ///   <para>rdfs:comment : La estructura que sostiene la turbina eólica.rdfs:comment : The structure that supports the wind turbine.</para>
    ///   <a href="https://w3id.org/optimar#Tower">opti:Tower</a>
    /// </summary>
    let Tower = _prefixId.prefix "Tower"
    /// <summary>
    ///   <para>rdfs:label : Turbinardfs:label : Turbine</para>
    ///   <para>rdfs:comment : Una turbina de viento que forma parte de la plataforma eólica.rdfs:comment : A wind turbine that is part of the wind platform.</para>
    ///   <a href="https://w3id.org/optimar#Turbine">opti:Turbine</a>
    /// </summary>
    let Turbine = _prefixId.prefix "Turbine"
    /// <summary>
    ///   <para>rdfs:label : Componentes de turbinardfs:label : Turbine Components</para>
    ///   <para>rdfs:comment : Los componentes de la turbina eólica que generan energía a partir del viento.rdfs:comment : The turbine components that generate energy from the wind.</para>
    ///   <a href="https://w3id.org/optimar#TurbineComponent">opti:TurbineComponent</a>
    /// </summary>
    let TurbineComponent = _prefixId.prefix "TurbineComponent"
    /// <summary>
    ///   <para>rdfs:label : Datos de vibraciónrdfs:label : Vibration Data</para>
    ///   <para>rdfs:comment : Datos de vibracion medidos por un sensor.rdfs:comment : Vibration data measured by a sensor.</para>
    ///   <a href="https://w3id.org/optimar#VibrationData">opti:VibrationData</a>
    /// </summary>
    let VibrationData = _prefixId.prefix "VibrationData"
    /// <summary>
    ///   <para>rdfs:label : Plataforma eólica offshorerdfs:label : Offshore Wind Power Platform</para>
    ///   <para>rdfs:comment : Una plataforma eólica offshore que genera energía electrica a partir del viento.rdfs:comment : An offshore wind power platform that generates electricity from wind.</para>
    ///   <a href="https://w3id.org/optimar#WindPowerPlatform">opti:WindPowerPlatform</a>
    /// </summary>
    let WindPowerPlatform = _prefixId.prefix "WindPowerPlatform"
    /// <summary>
    ///   <para>rdfs:label : Ajustardfs:label : Adjusts</para>
    ///   <para>rdfs:comment : Indica que un actor realiza ajustes sobre un componente o sistema de pitch.rdfs:comment : Indicas that an actor makes adjustments on a component or pitch system.</para>
    ///   <a href="https://w3id.org/optimar#adjusts">opti:adjusts</a>
    /// </summary>
    let adjusts = _prefixId.prefix "adjusts"
    /// <summary>
    ///   <para>rdfs:label : Analizardfs:label : Analyzes</para>
    ///   <para>rdfs:comment : Relaciona a un actor con los datos o fallos que estudia o interpreta.rdfs:comment : Relates an actor to the data or failures that it studies or interprets.</para>
    ///   <a href="https://w3id.org/optimar#analyzes">opti:analyzes</a>
    /// </summary>
    let analyzes = _prefixId.prefix "analyzes"
    /// <summary>
    ///   <para>rdfs:label : Causado porrdfs:label : Caused by</para>
    ///   <para>rdfs:comment : Relaciona un evento con el fallo que lo provocó.rdfs:comment : Relates an event with the failure that caused it.</para>
    ///   <a href="https://w3id.org/optimar#causedBy">opti:causedBy</a>
    /// </summary>
    let causedBy = _prefixId.prefix "causedBy"
    /// <summary>
    ///   <para>rdfs:label : Conectado ardfs:label : Connected to</para>
    ///   <para>rdfs:comment : Indica que un componente está conectado a otro.rdfs:comment : Indicates that a component is connected to another.</para>
    ///   <a href="https://w3id.org/optimar#connectedTo">opti:connectedTo</a>
    /// </summary>
    let connectedTo = _prefixId.prefix "connectedTo"
    /// <summary>
    ///   <para>rdfs:label : Corrosión oscurardfs:label : Dark corrosion</para>
    ///   <para>rdfs:comment : Nivel de corrosión oscura detectada en la superficie del material.rdfs:comment : Level of dark corrosion detected on the mmaterial surface.</para>
    ///   <a href="https://w3id.org/optimar#darkCorrosion">opti:darkCorrosion</a>
    /// </summary>
    let darkCorrosion = _prefixId.prefix "darkCorrosion"
    /// <summary>
    ///   <para>rdfs:label : Fecha y horardfs:label : Date and time</para>
    ///   <para>rdfs:comment : Marca temporal asociada a la medición.rdfs:comment : Associated temporal mark to the measurement.</para>
    ///   <a href="https://w3id.org/optimar#dateTime">opti:dateTime</a>
    /// </summary>
    let dateTime = _prefixId.prefix "dateTime"
    /// <summary>
    ///   <para>rdfs:label : Detectado porrdfs:label : Detected by</para>
    ///   <para>rdfs:comment : Relaciona un evento con el sensor que lo detectó.rdfs:comment : Relates an event to the sensor that detected it.</para>
    ///   <a href="https://w3id.org/optimar#detectedBy">opti:detectedBy</a>
    /// </summary>
    let detectedBy = _prefixId.prefix "detectedBy"
    /// <summary>
    ///   <para>rdfs:label : Detecta corrosiónrdfs:label : Detects corrosion</para>
    ///   <para>rdfs:comment : Relaciona un sensor con la medición de corrosión detectada.rdfs:comment : Relates a sensor with the detected corrosion measurement.</para>
    ///   <a href="https://w3id.org/optimar#detectsCorrosion">opti:detectsCorrosion</a>
    /// </summary>
    let detectsCorrosion = _prefixId.prefix "detectsCorrosion"
    /// <summary>
    ///   <para>rdfs:label : Diámetrordfs:label : Diameter</para>
    ///   <para>rdfs:comment : Diámetro del componente medido en unidades QUDT.rdfs:comment : Diameter of the component measured in QUDT units.</para>
    ///   <a href="https://w3id.org/optimar#diameter">opti:diameter</a>
    /// </summary>
    let diameter = _prefixId.prefix "diameter"
    /// <summary>
    ///   <para>rdfs:label : Desplazamientordfs:label : Displacement</para>
    ///   <para>rdfs:comment : Desplazamiento o cambio de posición registrado en el componente.rdfs:comment : Displacement or position change recorded in the component.</para>
    ///   <a href="https://w3id.org/optimar#displacement">opti:displacement</a>
    /// </summary>
    let displacement = _prefixId.prefix "displacement"
    /// <summary>
    ///   <para>rdfs:label : Forma externardfs:label : External shape</para>
    ///   <para>rdfs:comment : Describe la forma externa o geometría del componente.rdfs:comment : Describe the external shape or geometric of the component.</para>
    ///   <a href="https://w3id.org/optimar#externalShape">opti:externalShape</a>
    /// </summary>
    let externalShape = _prefixId.prefix "externalShape"
    /// <summary>
    ///   <para>rdfs:label : Observación de fallordfs:label : Failure observation</para>
    ///   <para>rdfs:comment : Relación entre un evento de fallo y la observación realizada por un sensor.rdfs:comment : Relationship between a failure event and the observation made by a sensor.</para>
    ///   <a href="https://w3id.org/optimar#failureObservation">opti:failureObservation</a>
    /// </summary>
    let failureObservation = _prefixId.prefix "failureObservation"
    /// <summary>
    ///   <para>rdfs:label : Capacidadrdfs:label : Capacity</para>
    ///   <para>rdfs:comment : Capacidad nominal de generación de la turbina.rdfs:comment : Rated generation capacity of the turbine.</para>
    ///   <a href="https://w3id.org/optimar#hasCapacity">opti:hasCapacity</a>
    /// </summary>
    let hasCapacity = _prefixId.prefix "hasCapacity"
    /// <summary>
    ///   <para>rdfs:label : Causa de fallordfs:label : Failure cause</para>
    ///   <para>rdfs:comment : Indica que un fallo tiene su origen en una condición ambiental específica.rdfs:comment : Indicates that a failure is caused by a specific environmental condition.</para>
    ///   <a href="https://w3id.org/optimar#hasFailureCause">opti:hasFailureCause</a>
    /// </summary>
    let hasFailureCause = _prefixId.prefix "hasFailureCause"
    /// <summary>
    ///   <para>rdfs:label : Tiene rolrdfs:label : Has role</para>
    ///   <para>rdfs:comment : Indica el rol que desempeña un actor dentro del sistema.rdfs:comment : Indicas the role that an actor performs within the system.</para>
    ///   <a href="https://w3id.org/optimar#hasRole">opti:hasRole</a>
    /// </summary>
    let hasRole = _prefixId.prefix "hasRole"
    /// <summary>
    ///   <para>rdfs:label : Alturardfs:label : Height</para>
    ///   <para>rdfs:comment : Altura del componente expresada como un valor con unidad QUDT.rdfs:comment : Height of the component expressed as a QUDT quantity value.</para>
    ///   <a href="https://w3id.org/optimar#height">opti:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:label : Alojardfs:label : Houses</para>
    ///   <para>rdfs:comment : Indica que un componente contiene o aloja fisicamente a otro en su estructura.rdfs:comment : Indicates that a component contains or houses physically another in its structure.</para>
    ///   <a href="https://w3id.org/optimar#houses">opti:houses</a>
    /// </summary>
    let houses = _prefixId.prefix "houses"
    /// <summary>
    ///   <para>rdfs:label : URL de la imagenrdfs:label : Image URL</para>
    ///   <para>rdfs:comment : Dirección de acceso a la imagen generada o almacenada.rdfs:comment : Access URL of the generated or stored image.</para>
    ///   <a href="https://w3id.org/optimar#imageURL">opti:imageURL</a>
    /// </summary>
    let imageURL = _prefixId.prefix "imageURL"
    /// <summary>
    ///   <para>rdfs:label : Es soportado porrdfs:label : Is supported by</para>
    ///   <para>rdfs:comment : Indica que un componente depende estructural o funcionalmente de otro para su soporte.rdfs:comment : Indicates that a component is structurally or functionally supported by another.</para>
    ///   <a href="https://w3id.org/optimar#isSupportedBy">opti:isSupportedBy</a>
    /// </summary>
    let isSupportedBy = _prefixId.prefix "isSupportedBy"
    /// <summary>
    ///   <para>rdfs:label : Longitudrdfs:label : Length</para>
    ///   <para>rdfs:comment : Longitud de un componente, expresada como un valor con unidad QUDTrdfs:comment : Length of a component, expressed as a QUDT quantity value</para>
    ///   <a href="https://w3id.org/optimar#length">opti:length</a>
    /// </summary>
    let length = _prefixId.prefix "length"
    /// <summary>
    ///   <para>rdfs:label : Corrosión clarardfs:label : Light corrosion</para>
    ///   <para>rdfs:comment : Nivel de corrosión clara detectada en la superficie del material.rdfs:comment : Level of light corrosion detected on the material surface.</para>
    ///   <a href="https://w3id.org/optimar#lightCorrosion">opti:lightCorrosion</a>
    /// </summary>
    let lightCorrosion = _prefixId.prefix "lightCorrosion"
    /// <summary>
    ///   <para>rdfs:label : Ubicado enrdfs:label : Located in</para>
    ///   <para>rdfs:comment : Indica el lugar en el que se encuentra la plataforma eólica.rdfs:comment : Indicates the location where the wind power platform is located.</para>
    ///   <a href="https://w3id.org/optimar#locatedIn">opti:locatedIn</a>
    /// </summary>
    let locatedIn = _prefixId.prefix "locatedIn"
    /// <summary>
    ///   <para>rdfs:label : Realizada por sensorrdfs:label : Made by sensor</para>
    ///   <para>rdfs:comment : Relaciona una observación con el sensor que la realizó.rdfs:comment : Relates an observation to the sensor that made it.</para>
    ///   <a href="https://w3id.org/optimar#madeBySensor">opti:madeBySensor</a>
    /// </summary>
    let madeBySensor = _prefixId.prefix "madeBySensor"
    /// <summary>
    ///   <para>rdfs:label : Administrardfs:label : Manages</para>
    ///   <para>rdfs:comment : Infica que un actor se encarga de la gestión de una plataforma eólica o su sistema de anclaje.rdfs:comment : Indicates that an actor is responsible for managing a wind power platform or its mooring system.</para>
    ///   <a href="https://w3id.org/optimar#manages">opti:manages</a>
    /// </summary>
    let manages = _prefixId.prefix "manages"
    /// <summary>
    ///   <para>rdfs:label : Masardfs:label : Mass</para>
    ///   <para>rdfs:comment : Masa del componente expresada expresada como un valor con unidad QUDTrdfs:comment : Mass of the component expressed as a QUDT quantity value</para>
    ///   <a href="https://w3id.org/optimar#mass">opti:mass</a>
    /// </summary>
    let mass = _prefixId.prefix "mass"
    /// <summary>
    ///   <para>rdfs:label : Materialrdfs:label : Material</para>
    ///   <para>rdfs:comment : Material de fabricación del componente (ej. acero, compuesto, fibra de vidrio, etc.).rdfs:comment : Material of manufacturing of the component (e.g. steel, composite, fiberglass, etc.).</para>
    ///   <a href="https://w3id.org/optimar#material">opti:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>rdfs:label : Fatiga materialrdfs:label : Material fatigue</para>
    ///   <para>rdfs:comment : Grado de fatiga acumulada en el material.rdfs:comment : Accumulated material fatigue degree.</para>
    ///   <a href="https://w3id.org/optimar#materialFatigue">opti:materialFatigue</a>
    /// </summary>
    let materialFatigue = _prefixId.prefix "materialFatigue"
    /// <summary>
    ///   <para>rdfs:label : Desgaste materialrdfs:label : Material wear</para>
    ///   <para>rdfs:comment : Grado de desgaste de un material en un componente.rdfs:comment : Degree of material wear in a component.</para>
    ///   <a href="https://w3id.org/optimar#materialWear">opti:materialWear</a>
    /// </summary>
    let materialWear = _prefixId.prefix "materialWear"
    /// <summary>
    ///   <para>rdfs:label : Mide tensiónrdfs:label : Measures stress</para>
    ///   <para>rdfs:comment : Indica que un sensor mide la tensión ejercida sobre un componente.rdfs:comment : Indicates that a sensor measures the stress exerted on a component.</para>
    ///   <a href="https://w3id.org/optimar#measuresStress">opti:measuresStress</a>
    /// </summary>
    let measuresStress = _prefixId.prefix "measuresStress"
    /// <summary>
    ///   <para>rdfs:label : Mide vibraciónrdfs:label : Measures vibration</para>
    ///   <para>rdfs:comment : Indica que un sensor obtiene datos de vibración de un componente.rdfs:comment : Indicates that a sensor collects vibration data from a component.</para>
    ///   <a href="https://w3id.org/optimar#measuresVibration">opti:measuresVibration</a>
    /// </summary>
    let measuresVibration = _prefixId.prefix "measuresVibration"
    /// <summary>
    ///   <para>rdfs:label : Mide vientordfs:label : Measures wind</para>
    ///   <para>rdfs:comment : Relaciona un sensor con la medición de velocidad o dirección del viento.rdfs:comment : Relates a sensor with the measurement of wind speed or direction.</para>
    ///   <a href="https://w3id.org/optimar#measuresWind">opti:measuresWind</a>
    /// </summary>
    let measuresWind = _prefixId.prefix "measuresWind"
    /// <summary>
    ///   <para>rdfs:label : Desalineaciónrdfs:label : Misalignment</para>
    ///   <para>rdfs:comment : Medida de la falta de alineación detectada en un componente.rdfs:comment : Measure of the misalignment detected in a component.</para>
    ///   <a href="https://w3id.org/optimar#misalignment">opti:misalignment</a>
    /// </summary>
    let misalignment = _prefixId.prefix "misalignment"
    /// <summary>
    ///   <para>rdfs:label : Monitoreardfs:label : Monitors</para>
    ///   <para>rdfs:comment : Relaciona a un actor con los componentes o sensores que supervisa.rdfs:comment : Relates an actor to the components or sensors they monitor.</para>
    ///   <a href="https://w3id.org/optimar#monitors">opti:monitors</a>
    /// </summary>
    let monitors = _prefixId.prefix "monitors"
    /// <summary>
    ///   <para>rdfs:label : Monitorea deformaciónrdfs:label : Monitors deformation</para>
    ///   <para>rdfs:comment : Relaciona un sensor con la deformación estructural que mide o supervisa.rdfs:comment : Relates a sensor to the structural deformation it measures or monitors.</para>
    ///   <a href="https://w3id.org/optimar#monitorsDeformation">opti:monitorsDeformation</a>
    /// </summary>
    let monitorsDeformation = _prefixId.prefix "monitorsDeformation"
    /// <summary>
    ///   <para>rdfs:label : Estado operativordfs:label : Operational status</para>
    ///   <para>rdfs:comment : Estado de funcionamiento actual de la turbina (ej. operativa, parada, en mantenimiento, etc.).rdfs:comment : Current operational status of the turbine (e.g. operative, stopped, under maintenance, etc.).</para>
    ///   <a href="https://w3id.org/optimar#operationalStatus">opti:operationalStatus</a>
    /// </summary>
    let operationalStatus = _prefixId.prefix "operationalStatus"
    let performedBy = _prefixId.prefix "performedBy"
    /// <summary>
    ///   <para>rdfs:label : Realiza mantenimientordfs:label : Performs maintenance</para>
    ///   <para>rdfs:comment : Relaciona un actor con el mantenimiento que realiza.rdfs:comment : Relates an actor with the maintenance that it performs.</para>
    ///   <a href="https://w3id.org/optimar#performedMaintenance">opti:performedMaintenance</a>
    /// </summary>
    let performedMaintenance = _prefixId.prefix "performedMaintenance"
    /// <summary>
    ///   <para>rdfs:label : Realiza tareardfs:label : Performs task</para>
    ///   <para>rdfs:comment : Relaciona un actor con una tarea que ejecuta como parte de su rol.rdfs:comment : Relates an actor with a task that it performs as part of its role.</para>
    ///   <a href="https://w3id.org/optimar#performsTask">opti:performsTask</a>
    /// </summary>
    let performsTask = _prefixId.prefix "performsTask"
    /// <summary>
    ///   <para>rdfs:label : Presiónrdfs:label : Pressure</para>
    ///   <para>rdfs:comment : Presión ejercida sobre un componente.rdfs:comment : Pressure exerted on a component.</para>
    ///   <a href="https://w3id.org/optimar#pressure">opti:pressure</a>
    /// </summary>
    let pressure = _prefixId.prefix "pressure"
    /// <summary>
    ///   <para>rdfs:label : Relacionado con componenterdfs:label : Related to component</para>
    ///   <para>rdfs:comment : Relaciona un evento con el componente de la plataforma que se ve afectado.rdfs:comment : Relates an event to the platform component that is affected.</para>
    ///   <a href="https://w3id.org/optimar#relatedToComponent">opti:relatedToComponent</a>
    /// </summary>
    let relatedToComponent = _prefixId.prefix "relatedToComponent"
    /// <summary>
    ///   <para>rdfs:label : Velocidad de rotaciónrdfs:label : Rotation speed</para>
    ///   <para>rdfs:comment : Velocidad angular de un componente expresada como un valor con unidad QUDT.rdfs:comment : Angular speed of a component expressed as a QUDT quantity value.</para>
    ///   <a href="https://w3id.org/optimar#rotationSpeed">opti:rotationSpeed</a>
    /// </summary>
    let rotationSpeed = _prefixId.prefix "rotationSpeed"
    /// <summary>
    ///   <para>rdfs:label : Tensiónrdfs:label : Stress</para>
    ///   <para>rdfs:comment : Nivel de tensión registrado en un componente.rdfs:comment : Stress level recorded in a component.</para>
    ///   <a href="https://w3id.org/optimar#stress">opti:stress</a>
    /// </summary>
    let stress = _prefixId.prefix "stress"
    /// <summary>
    ///   <para>rdfs:label : Soporta ardfs:label : Supports</para>
    ///   <para>rdfs:comment : Indica que un componente proporciona soporte estructural o funcional a otro.rdfs:comment : Indicates that a component provides structural or functional support to another.</para>
    ///   <a href="https://w3id.org/optimar#supports">opti:supports</a>
    /// </summary>
    let supports = _prefixId.prefix "supports"
    /// <summary>
    ///   <para>rdfs:label : Temperaturardfs:label : Temperature</para>
    ///   <para>rdfs:comment : Temperatura registrada expresada como un valor con unidad QUDT.rdfs:comment : Temperature recorded expressed as a QUDT quantity value.</para>
    ///   <a href="https://w3id.org/optimar#temperature">opti:temperature</a>
    /// </summary>
    let temperature = _prefixId.prefix "temperature"
    /// <summary>
    ///   <para>rdfs:label : Espesorrdfs:label : Thickness</para>
    ///   <para>rdfs:comment : Espesor de la sección o pared de un componente medido en unidades QUDT.rdfs:comment : Thickness of the section or wall of a component measured in QUDT units.</para>
    ///   <a href="https://w3id.org/optimar#thickness">opti:thickness</a>
    /// </summary>
    let thickness = _prefixId.prefix "thickness"
    /// <summary>
    ///   <para>rdfs:label : Transmite movimiento ardfs:label : Transmits movement to</para>
    ///   <para>rdfs:comment : Indica que un componente transmite movimiento mecánico a otro.rdfs:comment : Indicates that a component transmits mechanical movement to another.</para>
    ///   <a href="https://w3id.org/optimar#transmitsMovementTo">opti:transmitsMovementTo</a>
    /// </summary>
    let transmitsMovementTo = _prefixId.prefix "transmitsMovementTo"
    /// <summary>
    ///   <para>rdfs:label : Unidadrdfs:label : Unit</para>
    ///   <para>rdfs:comment : Unidad de medida del valor registrado (ej. m/s, rpm, °C, etc.).rdfs:comment : Measurement unit of the recorded value (e.g. m/s, rpm, °C, etc.).</para>
    ///   <a href="https://w3id.org/optimar#unit">opti:unit</a>
    /// </summary>
    let unit = _prefixId.prefix "unit"
    /// <summary>
    ///   <para>rdfs:label : Valorrdfs:label : Value</para>
    ///   <para>rdfs:comment : Valor numérico de la medición tomada por un sensor.rdfs:comment : Numeric value of the measurement taken by a sensor.</para>
    ///   <a href="https://w3id.org/optimar#value">opti:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : Vibracionesrdfs:label : Vibrations</para>
    ///   <para>rdfs:comment : Nivel de vibraciones registradas en un componente o sistema.rdfs:comment : Level of vibrations recorded in a component or system.</para>
    ///   <a href="https://w3id.org/optimar#vibrations">opti:vibrations</a>
    /// </summary>
    let vibrations = _prefixId.prefix "vibrations"
    /// <summary>
    ///   <para>rdfs:label : Anchurardfs:label : Width</para>
    ///   <para>rdfs:comment : Anchura del componente expresada como un valor con unidad QUDT.rdfs:comment : Width of the component expressed as a QUDT quantity value.</para>
    ///   <a href="https://w3id.org/optimar#width">opti:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:label : Dirección del vientordfs:label : Wind direction</para>
    ///   <para>rdfs:comment : Dirección desde la que sopla el viento expresada en valores con unidad QUDT.rdfs:comment : Direction from which the wind blows expressed as a QUDT quantity value.</para>
    ///   <a href="https://w3id.org/optimar#windDirection">opti:windDirection</a>
    /// </summary>
    let windDirection = _prefixId.prefix "windDirection"
    /// <summary>
    ///   <para>rdfs:label : Velocidad del vientordfs:label : Wind speed</para>
    ///   <para>rdfs:comment : Velocidad del viento expresada como valor QUDT.rdfs:comment : Wind speed expressed as a QUDT quantity value.</para>
    ///   <a href="https://w3id.org/optimar#windSpeed">opti:windSpeed</a>
    /// </summary>
    let windSpeed = _prefixId.prefix "windSpeed"
