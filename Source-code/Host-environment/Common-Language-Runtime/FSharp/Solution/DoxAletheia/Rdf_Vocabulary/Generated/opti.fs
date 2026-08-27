namespace https.w3id.org.optimar.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opti =
    let _namespace_iri = Namespace_Iri opti |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:optimar#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/optimar#">https://w3id.org/optimar#</seealso>
    let _prefix_iri = Prefixed_Name(opti, "") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Un actor que interactúa o gestiona la plataforma eólica."</para>
    ///   <para>"An actor that interacts or manages the offshore wind power platform."</para>
    /// labels<para>"Actor"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Actor">https://w3id.org/optimar#Actor</seealso>
    let Actor = Prefixed_Name(opti, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#AnalyticalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Role focused on data analysis and generation of useful information for decision-making."</para>
    ///   <para>"Rol orientado al analisis de datos y generación de información útil para la toma de decisiones."</para>
    /// labels<para>"Analytical Role"</para><para>"Rol analítico"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#AnalyticalRole">https://w3id.org/optimar#AnalyticalRole</seealso>
    let AnalyticalRole = Prefixed_Name(opti, "AnalyticalRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Anemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensor que mide la velocidad y dirección del viento en el parque eólico."</para>
    ///   <para>"Sensor that measures wind speed and direction in the wind farm."</para>
    /// labels<para>"Anemómetro"</para><para>"Anemometer"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Anemometer">https://w3id.org/optimar#Anemometer</seealso>
    let Anemometer = Prefixed_Name(opti, "Anemometer") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Base</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The base that supports the floating platform."</para>
    ///   <para>"La base que soporta la plataforma flotante."</para>
    /// labels<para>"Base (subestructura flotante)"</para><para>"Base (floating substructure)"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Base">https://w3id.org/optimar#Base</seealso>
    let Base = Prefixed_Name(opti, "Base") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Blade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Las palas de la turbina que capturan la energía eólica."</para>
    ///   <para>"The blades of the turbine that capture the wind energy."</para>
    /// labels<para>"Blade"</para><para>"Pala"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Blade">https://w3id.org/optimar#Blade</seealso>
    let Blade = Prefixed_Name(opti, "Blade") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#CloudAdministrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Responsable de la administración y seguridad de los servicios en la nube que procesan los datos de la plataforma."</para>
    ///   <para>"Responsible for managing and securing cloud services that process data from the platform."</para>
    /// labels<para>"Administrador de nube"</para><para>"Cloud Administrator"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#CloudAdministrator">https://w3id.org/optimar#CloudAdministrator</seealso>
    let CloudAdministrator = Prefixed_Name(opti, "CloudAdministrator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An component of an offshore wind power platform, such as blades, towers, pitch system, etc."</para>
    ///   <para>"Un componente de una plataforma eólica offshore, como las palas, torres, sistema de pitch, etc."</para>
    /// labels<para>"Componente"</para><para>"Component"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Component">https://w3id.org/optimar#Component</seealso>
    let Component = Prefixed_Name(opti, "Component") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#ComponentBreakage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fallo originado por la fractura o rotura de un componente de la plataforma eólica."</para>
    ///   <para>"Failure caused by the fracture or breakage of an offshore wind turbine component."</para>
    /// labels<para>"Component Breakage"</para><para>"Rotura de componente"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ComponentBreakage">https://w3id.org/optimar#ComponentBreakage</seealso>
    let ComponentBreakage = Prefixed_Name(opti, "ComponentBreakage") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Corrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"General corrosion index detected in a component."</para>
    ///   <para>"Índice general de corrosión detectada en un componente."</para>
    /// labels<para>"Corrosión"</para><para>"Corrosion"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Corrosion">https://w3id.org/optimar#Corrosion</seealso>
    let Corrosion = Prefixed_Name(opti, "Corrosion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#CorrosionCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Cámara utilizada para detectar y monitorear corrosión en la estructura de la plataforma."</para>
    ///   <para>"Camera used to detect and monitor corrosion in the platform structure."</para>
    /// labels<para>"Corrosion Camera"</para><para>"Cámara corrosión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#CorrosionCamera">https://w3id.org/optimar#CorrosionCamera</seealso>
    let CorrosionCamera = Prefixed_Name(opti, "CorrosionCamera") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#CorrosionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Degradación de la estructura metálica de la plataforma por efectos de corrosión."</para>
    ///   <para>"Degradation of the platform's metallic structure due to corrosion effects."</para>
    /// labels<para>"Corrosion Event"</para><para>"Evento de Corrosión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#CorrosionEvent">https://w3id.org/optimar#CorrosionEvent</seealso>
    let CorrosionEvent = Prefixed_Name(opti, "CorrosionEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class for representing the measurement data collected by sensors or other systems."</para>
    ///   <para>"Una clase general para representar los datos de medición recolectados por sensores u otros sistemas."</para>
    /// labels<para>"Data"</para><para>"Dato"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Data">https://w3id.org/optimar#Data</seealso>
    let Data = Prefixed_Name(opti, "Data") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#DataAnalyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Specialist who analyzes collected data to detect patterns, failures, and optimization opportunities."</para>
    ///   <para>"Especialista que analiza los datos recolectados para detectar patrones, fallos y oportunidades de optimización."</para>
    /// labels<para>"Data Analyst"</para><para>"Analista de datos"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#DataAnalyst">https://w3id.org/optimar#DataAnalyst</seealso>
    let DataAnalyst = Prefixed_Name(opti, "DataAnalyst") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Deformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Degree of deformation recorded in the component."</para>
    ///   <para>"Grado de deformación registrado en el componente."</para>
    /// labels<para>"Deformación"</para><para>"Deformation"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Deformation">https://w3id.org/optimar#Deformation</seealso>
    let Deformation = Prefixed_Name(opti, "Deformation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#DynamicMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Device that measures dynamic parameters of the platform, such as vibrations and movements."</para>
    ///   <para>"Dispositivo que mide parámetros dinámicos de la plataforma como vibraciones y movimientos."</para>
    /// labels<para>"Dynamic Monitor"</para><para>"Monitor dinámico"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#DynamicMonitor">https://w3id.org/optimar#DynamicMonitor</seealso>
    let DynamicMonitor = Prefixed_Name(opti, "DynamicMonitor") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#EnvironmentalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Las condiciones ambientales que afectan a la plataforma eólica, como la velocidad del viento, la temperatura, etc."</para>
    ///   <para>"The environmental conditions that affect the offshore wind power platform, such as wind speed, temperature, etc."</para>
    /// labels<para>"Environmental Condition"</para><para>"Condición ambiental"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#EnvironmentalCondition">https://w3id.org/optimar#EnvironmentalCondition</seealso>
    let EnvironmentalCondition =
        Prefixed_Name(opti, "EnvironmentalCondition") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An event that occurs in the offshore wind power platform, such as a failure detection."</para>
    ///   <para>"Un evento que ocurre en la plataforma eólica, como la detección de un fallo."</para>
    /// labels<para>"Evento"</para><para>"Event"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Event">https://w3id.org/optimar#Event</seealso>
    let Event = Prefixed_Name(opti, "Event") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Failure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class that represents identified failures in the wind platform."</para>
    ///   <para>"Una clase que representa fallos identificados en la plataforma eólica."</para>
    /// labels<para>"Failure"</para><para>"Fallo"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Failure">https://w3id.org/optimar#Failure</seealso>
    let Failure = Prefixed_Name(opti, "Failure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#FailureEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Evento que representa un fallo detectado en el sistema, debe estar causado por al menos un fallo. "</para>
    ///   <para>"Event that represents a detected failure in the system, must be caused by at least one failure."</para>
    /// labels<para>"Failure Event"</para><para>"Evento de fallo"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#FailureEvent">https://w3id.org/optimar#FailureEvent</seealso>
    let FailureEvent = Prefixed_Name(opti, "FailureEvent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#FloatingPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A floating platform that serves as a base for the wind turbine."</para>
    ///   <para>"Una plataforma flotante que sirve de base para la turbina eólica."</para>
    /// labels<para>"Plataforma flotante"</para><para>"Floating Platform"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#FloatingPlatform">https://w3id.org/optimar#FloatingPlatform</seealso>
    let FloatingPlatform = Prefixed_Name(opti, "FloatingPlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#FloatingSubstructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La subestructura flotante que permite que la plataforma sea estable en el mar."</para>
    ///   <para>"The floating substructure that allows the platform to be stable at sea."</para>
    /// labels<para>"Floating Substructure"</para><para>"Subestructura flotante"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#FloatingSubstructure">https://w3id.org/optimar#FloatingSubstructure</seealso>
    let FloatingSubstructure =
        Prefixed_Name(opti, "FloatingSubstructure") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#GaugeSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Strain gauge system used to measure stresses and deformations in the structure."</para>
    ///   <para>"Sistema de galgas extensiométricas utilizado para medir tensiones y deformaciones en la estructura."</para>
    /// labels<para>"Sistema de galgas"</para><para>"Gauge System"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#GaugeSystem">https://w3id.org/optimar#GaugeSystem</seealso>
    let GaugeSystem = Prefixed_Name(opti, "GaugeSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Hub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"La parte central de la turbina donde se conectan las palas."</para>
    ///   <para>"The central part of the turbine where the blades are connected."</para>
    /// labels<para>"Hub"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Hub">https://w3id.org/optimar#Hub</seealso>
    let Hub = Prefixed_Name(opti, "Hub") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#ISUMSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sistema especializado para la monitorización integrada de la plataforma offshore."</para>
    ///   <para>"Specialized system for integrated monitoring of the offshore platform."</para>
    /// labels<para>"Sistema ISUM"</para><para>"ISUM System"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ISUMSystem">https://w3id.org/optimar#ISUMSystem</seealso>
    let ISUMSystem = Prefixed_Name(opti, "ISUMSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A class that represents an image that supports the measurement."</para>
    ///   <para>"Una clase que representa una imagen que soporta la medición."</para>
    /// labels<para>"Imagen"</para><para>"Image"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Image">https://w3id.org/optimar#Image</seealso>
    let Image = Prefixed_Name(opti, "Image") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The geographic location of the wind platform."</para>
    ///   <para>"La ubicación geográfica de la plataforma eólica."</para>
    /// labels<para>"Location"</para><para>"Ubicación"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Location">https://w3id.org/optimar#Location</seealso>
    let Location = Prefixed_Name(opti, "Location") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una clase que representa el mantenimiento de la plataforma eólica."</para>
    ///   <para>"A class that represents the maintenance of the wind platform."</para>
    /// labels<para>"Mantenimiento"</para><para>"Maintenance"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Maintenance">https://w3id.org/optimar#Maintenance</seealso>
    let Maintenance = Prefixed_Name(opti, "Maintenance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#MaintenanceOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Person responsible for carrying out preventive and corrective maintenance on the platform."</para>
    ///   <para>"Persona encargada de realizar el mantenimiento preventivo y correctivo en la plataforma."</para>
    /// labels<para>"Operador de mantenimiento"</para><para>"Maintenance Operator"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MaintenanceOperator">https://w3id.org/optimar#MaintenanceOperator</seealso>
    let MaintenanceOperator = Prefixed_Name(opti, "MaintenanceOperator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#ManagementRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Rol encargado de la coordinación, planificación y gestión de recursos en la plataforma eólica."</para>
    ///   <para>"Role responsible for coordination, planning, and resource management in the wind platform."</para>
    /// labels<para>"Management Role"</para><para>"Rol de gestión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ManagementRole">https://w3id.org/optimar#ManagementRole</seealso>
    let ManagementRole = Prefixed_Name(opti, "ManagementRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#MaterialFatigue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fallo en el material estructural causado por ciclos repetidos de carga."</para>
    ///   <para>"Structural material failure caused by repeated load cycles."</para>
    /// labels<para>"Material Fatigue"</para><para>"Fatiga del material"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MaterialFatigue">https://w3id.org/optimar#MaterialFatigue</seealso>
    let MaterialFatigue = Prefixed_Name(opti, "MaterialFatigue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a measurement taken by a sensor."</para>
    ///   <para>"Representa una medición tomada por un sensor."</para>
    /// labels<para>"Measurement"</para><para>"Medición"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Measurement">https://w3id.org/optimar#Measurement</seealso>
    let Measurement = Prefixed_Name(opti, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Misalignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Failure caused by misalignment or lack of proper adjustment between platform components."</para>
    ///   <para>"Fallo causado por el desajuste o falta de alineación entre los componentes de la plataforma."</para>
    /// labels<para>"Misalignment"</para><para>"Desalineación"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Misalignment">https://w3id.org/optimar#Misalignment</seealso>
    let Misalignment = Prefixed_Name(opti, "Misalignment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#MonitoringTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A task aimed at supervising the condition of the platform through sensors and monitoring systems."</para>
    ///   <para>"Una tarea destinada a supervisar el estado de la plataforma mediante sensores y sistemas de monitorización."</para>
    /// labels<para>"Monitoring Task"</para><para>"Tarea de monitoreo"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MonitoringTask">https://w3id.org/optimar#MonitoringTask</seealso>
    let MonitoringTask = Prefixed_Name(opti, "MonitoringTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#MooringSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"El sistema de amarre que mantiene la plataforma flotante en su ubicación."</para>
    ///   <para>"The mooring system that keeps the floating platform in place."</para>
    /// labels<para>"Sistema de amarre"</para><para>"Mooring System"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MooringSystem">https://w3id.org/optimar#MooringSystem</seealso>
    let MooringSystem = Prefixed_Name(opti, "MooringSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Nacelle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"El compartimento de la turbina que aloja el generador y otros componentes mecánicos."</para>
    ///   <para>"The turbine component that houses the generator and other mechanical components."</para>
    /// labels<para>"Nacelle"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Nacelle">https://w3id.org/optimar#Nacelle</seealso>
    let Nacelle = Prefixed_Name(opti, "Nacelle") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The result of recording a phenomenon or condition, usually through a sensor or monitoring system."</para>
    ///   <para>"El resultado de registrar un fenómeno o condición, normalmente a través de un sensor o sistema de monitorización."</para>
    /// labels<para>"Observation"</para><para>"Observación"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Observation">https://w3id.org/optimar#Observation</seealso>
    let Observation = Prefixed_Name(opti, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#ParkOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Entidad o persona propietaria del parque eólico offshore y responsable de su operación general."</para>
    ///   <para>"Entity or individual owning the offshore wind farm and responsible for its overall operation."</para>
    /// labels<para>"Propietario de parque"</para><para>"Park Owner"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ParkOwner">https://w3id.org/optimar#ParkOwner</seealso>
    let ParkOwner = Prefixed_Name(opti, "ParkOwner") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#PitchSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The system that adjusts the angle of the blades of the turbine."</para>
    ///   <para>"El sistema que ajusta el ángulo de las palas de la turbina."</para>
    /// labels<para>"Pitch System"</para><para>"Sistema de pitch"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#PitchSystem">https://w3id.org/optimar#PitchSystem</seealso>
    let PitchSystem = Prefixed_Name(opti, "PitchSystem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#PlatformActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Encargado de realizar ajustes sobre la plataforma, como ajustes mecánicos o hidráulicos."</para>
    ///   <para>"Responsible for making adjustments on the platform, such as mechanical or hydraulic adjustments."</para>
    /// labels<para>"Actuador de plataforma"</para><para>"Platform Actuator"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#PlatformActuator">https://w3id.org/optimar#PlatformActuator</seealso>
    let PlatformActuator = Prefixed_Name(opti, "PlatformActuator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The roles of the actors that manage, operate or maintain the offshore wind power platform."</para>
    ///   <para>"Los roles de los actores que gestionan, operan o mantienen la plataforma eólica."</para>
    /// labels<para>"Rol"</para><para>"Role"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Role">https://w3id.org/optimar#Role</seealso>
    let Role = Prefixed_Name(opti, "Role") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device that measures or monitors parameters of the wind platform, such as wind, corrosion, vibrations, etc."</para>
    ///   <para>"Un dispositivo que mide o monitorea parámetros de la plataforma eólica, como viento, corrosión, vibraciones, etc."</para>
    /// labels<para>"Sensor"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Sensor">https://w3id.org/optimar#Sensor</seealso>
    let Sensor = Prefixed_Name(opti, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#StressData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Datos de tensión medidos por un sensor."</para>
    ///   <para>"Stress data measured by a sensor."</para>
    /// labels<para>"Stress Data"</para><para>"Datos de tensión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StressData">https://w3id.org/optimar#StressData</seealso>
    let StressData = Prefixed_Name(opti, "StressData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#StructuralCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Camera dedicated to visual inspection of the structural condition of the platform."</para>
    ///   <para>"Cámara dedicada a la inspección visual del estado estructural de la plataforma."</para>
    /// labels<para>"Structural Camera"</para><para>"Cámara estructural"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StructuralCamera">https://w3id.org/optimar#StructuralCamera</seealso>
    let StructuralCamera = Prefixed_Name(opti, "StructuralCamera") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#StructuralComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Los componentes estructurales que componen la infraestructura básica de la plataforma eólica."</para>
    ///   <para>"The structural components that make up the basic infrastructure of the wind platform."</para>
    /// labels<para>"Structural Components"</para><para>"Componentes estructurales"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StructuralComponent">https://w3id.org/optimar#StructuralComponent</seealso>
    let StructuralComponent = Prefixed_Name(opti, "StructuralComponent") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#StructuralInstability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Fallo que compromete la estabilidad estructural de la plataforma flotante."</para>
    ///   <para>"Failure that compromises the structural stability of the floating platform."</para>
    /// labels<para>"Inestabilidad estructural"</para><para>"Structural Instability"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StructuralInstability">https://w3id.org/optimar#StructuralInstability</seealso>
    let StructuralInstability =
        Prefixed_Name(opti, "StructuralInstability") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A general task related to the operation, monitoring, or maintenance of the wind platform."</para>
    ///   <para>"Una tarea general relacionada con la operación, supervisión o mantenimiento de la plataforma eólica."</para>
    /// labels<para>"Task"</para><para>"Tarea"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Task">https://w3id.org/optimar#Task</seealso>
    let Task = Prefixed_Name(opti, "Task") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#TechnicalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Role associated with technical activities such as operation, repair, and system supervision."</para>
    ///   <para>"Rol asociado a actividades técnicas como operación, reparación y supervisión de sistemas."</para>
    /// labels<para>"Technical Role"</para><para>"Rol técnico"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#TechnicalRole">https://w3id.org/optimar#TechnicalRole</seealso>
    let TechnicalRole = Prefixed_Name(opti, "TechnicalRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Tower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The structure that supports the wind turbine."</para>
    ///   <para>"La estructura que sostiene la turbina eólica."</para>
    /// labels<para>"Torre"</para><para>"Tower"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Tower">https://w3id.org/optimar#Tower</seealso>
    let Tower = Prefixed_Name(opti, "Tower") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#Turbine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una turbina de viento que forma parte de la plataforma eólica."</para>
    ///   <para>"A wind turbine that is part of the wind platform."</para>
    /// labels<para>"Turbina"</para><para>"Turbine"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Turbine">https://w3id.org/optimar#Turbine</seealso>
    let Turbine = Prefixed_Name(opti, "Turbine") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#TurbineComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Los componentes de la turbina eólica que generan energía a partir del viento."</para>
    ///   <para>"The turbine components that generate energy from the wind."</para>
    /// labels<para>"Componentes de turbina"</para><para>"Turbine Components"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#TurbineComponent">https://w3id.org/optimar#TurbineComponent</seealso>
    let TurbineComponent = Prefixed_Name(opti, "TurbineComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#VibrationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Datos de vibracion medidos por un sensor."</para>
    ///   <para>"Vibration data measured by a sensor."</para>
    /// labels<para>"Datos de vibración"</para><para>"Vibration Data"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#VibrationData">https://w3id.org/optimar#VibrationData</seealso>
    let VibrationData = Prefixed_Name(opti, "VibrationData") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#WindPowerPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Una plataforma eólica offshore que genera energía electrica a partir del viento."</para>
    ///   <para>"An offshore wind power platform that generates electricity from wind."</para>
    /// labels<para>"Plataforma eólica offshore"</para><para>"Offshore Wind Power Platform"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#WindPowerPlatform">https://w3id.org/optimar#WindPowerPlatform</seealso>
    let WindPowerPlatform = Prefixed_Name(opti, "WindPowerPlatform") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#adjusts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicas that an actor makes adjustments on a component or pitch system."</para>
    ///   <para>"Indica que un actor realiza ajustes sobre un componente o sistema de pitch."</para>
    /// labels<para>"Ajusta"</para><para>"Adjusts"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#adjusts">https://w3id.org/optimar#adjusts</seealso>
    let adjusts = Prefixed_Name(opti, "adjusts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#analyzes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an actor to the data or failures that it studies or interprets."</para>
    ///   <para>"Relaciona a un actor con los datos o fallos que estudia o interpreta."</para>
    /// labels<para>"Analiza"</para><para>"Analyzes"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#analyzes">https://w3id.org/optimar#analyzes</seealso>
    let analyzes = Prefixed_Name(opti, "analyzes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relaciona un evento con el fallo que lo provocó."</para>
    ///   <para>"Relates an event with the failure that caused it."</para>
    /// labels<para>"Causado por"</para><para>"Caused by"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#causedBy">https://w3id.org/optimar#causedBy</seealso>
    let causedBy = Prefixed_Name(opti, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#connectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a component is connected to another."</para>
    ///   <para>"Indica que un componente está conectado a otro."</para>
    /// labels<para>"Connected to"</para><para>"Conectado a"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#connectedTo">https://w3id.org/optimar#connectedTo</seealso>
    let connectedTo = Prefixed_Name(opti, "connectedTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#darkCorrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Level of dark corrosion detected on the mmaterial surface."</para>
    ///   <para>"Nivel de corrosión oscura detectada en la superficie del material."</para>
    /// labels<para>"Corrosión oscura"</para><para>"Dark corrosion"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#darkCorrosion">https://w3id.org/optimar#darkCorrosion</seealso>
    let darkCorrosion = Prefixed_Name(opti, "darkCorrosion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Marca temporal asociada a la medición."</para>
    ///   <para>"Associated temporal mark to the measurement."</para>
    /// labels<para>"Fecha y hora"</para><para>"Date and time"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#dateTime">https://w3id.org/optimar#dateTime</seealso>
    let dateTime = Prefixed_Name(opti, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#detectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an event to the sensor that detected it."</para>
    ///   <para>"Relaciona un evento con el sensor que lo detectó."</para>
    /// labels<para>"Detectado por"</para><para>"Detected by"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#detectedBy">https://w3id.org/optimar#detectedBy</seealso>
    let detectedBy = Prefixed_Name(opti, "detectedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#detectsCorrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relaciona un sensor con la medición de corrosión detectada."</para>
    ///   <para>"Relates a sensor with the detected corrosion measurement."</para>
    /// labels<para>"Detects corrosion"</para><para>"Detecta corrosión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#detectsCorrosion">https://w3id.org/optimar#detectsCorrosion</seealso>
    let detectsCorrosion = Prefixed_Name(opti, "detectsCorrosion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Diameter of the component measured in QUDT units."</para>
    ///   <para>"Diámetro del componente medido en unidades QUDT."</para>
    /// labels<para>"Diameter"</para><para>"Diámetro"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#diameter">https://w3id.org/optimar#diameter</seealso>
    let diameter = Prefixed_Name(opti, "diameter") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#displacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Desplazamiento o cambio de posición registrado en el componente."</para>
    ///   <para>"Displacement or position change recorded in the component."</para>
    /// labels<para>"Desplazamiento"</para><para>"Displacement"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#displacement">https://w3id.org/optimar#displacement</seealso>
    let displacement = Prefixed_Name(opti, "displacement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#externalShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Describe la forma externa o geometría del componente."</para>
    ///   <para>"Describe the external shape or geometric of the component."</para>
    /// labels<para>"Forma externa"</para><para>"External shape"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#externalShape">https://w3id.org/optimar#externalShape</seealso>
    let externalShape = Prefixed_Name(opti, "externalShape") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#failureObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relación entre un evento de fallo y la observación realizada por un sensor."</para>
    ///   <para>"Relationship between a failure event and the observation made by a sensor."</para>
    /// labels<para>"Observación de fallo"</para><para>"Failure observation"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#failureObservation">https://w3id.org/optimar#failureObservation</seealso>
    let failureObservation = Prefixed_Name(opti, "failureObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#hasCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Rated generation capacity of the turbine."</para>
    ///   <para>"Capacidad nominal de generación de la turbina."</para>
    /// labels<para>"Capacidad"</para><para>"Capacity"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#hasCapacity">https://w3id.org/optimar#hasCapacity</seealso>
    let hasCapacity = Prefixed_Name(opti, "hasCapacity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#hasFailureCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a failure is caused by a specific environmental condition."</para>
    ///   <para>"Indica que un fallo tiene su origen en una condición ambiental específica."</para>
    /// labels<para>"Causa de fallo"</para><para>"Failure cause"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#hasFailureCause">https://w3id.org/optimar#hasFailureCause</seealso>
    let hasFailureCause = Prefixed_Name(opti, "hasFailureCause") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicas the role that an actor performs within the system."</para>
    ///   <para>"Indica el rol que desempeña un actor dentro del sistema."</para>
    /// labels<para>"Tiene rol"</para><para>"Has role"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#hasRole">https://w3id.org/optimar#hasRole</seealso>
    let hasRole = Prefixed_Name(opti, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Height of the component expressed as a QUDT quantity value."</para>
    ///   <para>"Altura del componente expresada como un valor con unidad QUDT."</para>
    /// labels<para>"Height"</para><para>"Altura"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#height">https://w3id.org/optimar#height</seealso>
    let height = Prefixed_Name(opti, "height") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#houses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indica que un componente contiene o aloja fisicamente a otro en su estructura."</para>
    ///   <para>"Indicates that a component contains or houses physically another in its structure."</para>
    /// labels<para>"Aloja"</para><para>"Houses"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#houses">https://w3id.org/optimar#houses</seealso>
    let houses = Prefixed_Name(opti, "houses") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#imageURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Dirección de acceso a la imagen generada o almacenada."</para>
    ///   <para>"Access URL of the generated or stored image."</para>
    /// labels<para>"Image URL"</para><para>"URL de la imagen"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#imageURL">https://w3id.org/optimar#imageURL</seealso>
    let imageURL = Prefixed_Name(opti, "imageURL") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a component is structurally or functionally supported by another."</para>
    ///   <para>"Indica que un componente depende estructural o funcionalmente de otro para su soporte."</para>
    /// labels<para>"Es soportado por"</para><para>"Is supported by"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#isSupportedBy">https://w3id.org/optimar#isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(opti, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Length of a component, expressed as a QUDT quantity value"</para>
    ///   <para>"Longitud de un componente, expresada como un valor con unidad QUDT"</para>
    /// labels<para>"Length"</para><para>"Longitud"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#length">https://w3id.org/optimar#length</seealso>
    let length = Prefixed_Name(opti, "length") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#lightCorrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Level of light corrosion detected on the material surface."</para>
    ///   <para>"Nivel de corrosión clara detectada en la superficie del material."</para>
    /// labels<para>"Light corrosion"</para><para>"Corrosión clara"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#lightCorrosion">https://w3id.org/optimar#lightCorrosion</seealso>
    let lightCorrosion = Prefixed_Name(opti, "lightCorrosion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indica el lugar en el que se encuentra la plataforma eólica."</para>
    ///   <para>"Indicates the location where the wind power platform is located."</para>
    /// labels<para>"Located in"</para><para>"Ubicado en"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#locatedIn">https://w3id.org/optimar#locatedIn</seealso>
    let locatedIn = Prefixed_Name(opti, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#madeBySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an observation to the sensor that made it."</para>
    ///   <para>"Relaciona una observación con el sensor que la realizó."</para>
    /// labels<para>"Realizada por sensor"</para><para>"Made by sensor"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#madeBySensor">https://w3id.org/optimar#madeBySensor</seealso>
    let madeBySensor = Prefixed_Name(opti, "madeBySensor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#manages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that an actor is responsible for managing a wind power platform or its mooring system."</para>
    ///   <para>"Infica que un actor se encarga de la gestión de una plataforma eólica o su sistema de anclaje."</para>
    /// labels<para>"Administra"</para><para>"Manages"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#manages">https://w3id.org/optimar#manages</seealso>
    let manages = Prefixed_Name(opti, "manages") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Mass of the component expressed as a QUDT quantity value"</para>
    ///   <para>"Masa del componente expresada expresada como un valor con unidad QUDT"</para>
    /// labels<para>"Mass"</para><para>"Masa"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#mass">https://w3id.org/optimar#mass</seealso>
    let mass = Prefixed_Name(opti, "mass") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Material de fabricación del componente (ej. acero, compuesto, fibra de vidrio, etc.)."</para>
    ///   <para>"Material of manufacturing of the component (e.g. steel, composite, fiberglass, etc.)."</para>
    /// labels<para>"Material"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#material">https://w3id.org/optimar#material</seealso>
    let material = Prefixed_Name(opti, "material") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#materialFatigue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Grado de fatiga acumulada en el material."</para>
    ///   <para>"Accumulated material fatigue degree."</para>
    /// labels<para>"Material fatigue"</para><para>"Fatiga material"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#materialFatigue">https://w3id.org/optimar#materialFatigue</seealso>
    let materialFatigue = Prefixed_Name(opti, "materialFatigue") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#materialWear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Grado de desgaste de un material en un componente."</para>
    ///   <para>"Degree of material wear in a component."</para>
    /// labels<para>"Material wear"</para><para>"Desgaste material"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#materialWear">https://w3id.org/optimar#materialWear</seealso>
    let materialWear = Prefixed_Name(opti, "materialWear") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#measuresStress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a sensor measures the stress exerted on a component."</para>
    ///   <para>"Indica que un sensor mide la tensión ejercida sobre un componente."</para>
    /// labels<para>"Measures stress"</para><para>"Mide tensión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#measuresStress">https://w3id.org/optimar#measuresStress</seealso>
    let measuresStress = Prefixed_Name(opti, "measuresStress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#measuresVibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a sensor collects vibration data from a component."</para>
    ///   <para>"Indica que un sensor obtiene datos de vibración de un componente."</para>
    /// labels<para>"Measures vibration"</para><para>"Mide vibración"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#measuresVibration">https://w3id.org/optimar#measuresVibration</seealso>
    let measuresVibration = Prefixed_Name(opti, "measuresVibration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#measuresWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates a sensor with the measurement of wind speed or direction."</para>
    ///   <para>"Relaciona un sensor con la medición de velocidad o dirección del viento."</para>
    /// labels<para>"Mide viento"</para><para>"Measures wind"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#measuresWind">https://w3id.org/optimar#measuresWind</seealso>
    let measuresWind = Prefixed_Name(opti, "measuresWind") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#misalignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Medida de la falta de alineación detectada en un componente."</para>
    ///   <para>"Measure of the misalignment detected in a component."</para>
    /// labels<para>"Desalineación"</para><para>"Misalignment"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#misalignment">https://w3id.org/optimar#misalignment</seealso>
    let misalignment = Prefixed_Name(opti, "misalignment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#monitors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an actor to the components or sensors they monitor."</para>
    ///   <para>"Relaciona a un actor con los componentes o sensores que supervisa."</para>
    /// labels<para>"Monitors"</para><para>"Monitorea"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#monitors">https://w3id.org/optimar#monitors</seealso>
    let monitors = Prefixed_Name(opti, "monitors") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#monitorsDeformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relaciona un sensor con la deformación estructural que mide o supervisa."</para>
    ///   <para>"Relates a sensor to the structural deformation it measures or monitors."</para>
    /// labels<para>"Monitors deformation"</para><para>"Monitorea deformación"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#monitorsDeformation">https://w3id.org/optimar#monitorsDeformation</seealso>
    let monitorsDeformation = Prefixed_Name(opti, "monitorsDeformation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#operationalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Estado de funcionamiento actual de la turbina (ej. operativa, parada, en mantenimiento, etc.)."</para>
    ///   <para>"Current operational status of the turbine (e.g. operative, stopped, under maintenance, etc.)."</para>
    /// labels<para>"Estado operativo"</para><para>"Operational status"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#operationalStatus">https://w3id.org/optimar#operationalStatus</seealso>
    let operationalStatus = Prefixed_Name(opti, "operationalStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#performedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/optimar#performedBy">https://w3id.org/optimar#performedBy</seealso>
    let performedBy = Prefixed_Name(opti, "performedBy") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#performedMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relaciona un actor con el mantenimiento que realiza."</para>
    ///   <para>"Relates an actor with the maintenance that it performs."</para>
    /// labels<para>"Performs maintenance"</para><para>"Realiza mantenimiento"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#performedMaintenance">https://w3id.org/optimar#performedMaintenance</seealso>
    let performedMaintenance =
        Prefixed_Name(opti, "performedMaintenance") |> PrefixedName

    /// <summary>
    ///   <para>w3id:optimar#performsTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an actor with a task that it performs as part of its role."</para>
    ///   <para>"Relaciona un actor con una tarea que ejecuta como parte de su rol."</para>
    /// labels<para>"Realiza tarea"</para><para>"Performs task"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#performsTask">https://w3id.org/optimar#performsTask</seealso>
    let performsTask = Prefixed_Name(opti, "performsTask") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Presión ejercida sobre un componente."</para>
    ///   <para>"Pressure exerted on a component."</para>
    /// labels<para>"Presión"</para><para>"Pressure"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#pressure">https://w3id.org/optimar#pressure</seealso>
    let pressure = Prefixed_Name(opti, "pressure") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#relatedToComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relates an event to the platform component that is affected."</para>
    ///   <para>"Relaciona un evento con el componente de la plataforma que se ve afectado."</para>
    /// labels<para>"Related to component"</para><para>"Relacionado con componente"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#relatedToComponent">https://w3id.org/optimar#relatedToComponent</seealso>
    let relatedToComponent = Prefixed_Name(opti, "relatedToComponent") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#rotationSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Angular speed of a component expressed as a QUDT quantity value."</para>
    ///   <para>"Velocidad angular de un componente expresada como un valor con unidad QUDT."</para>
    /// labels<para>"Rotation speed"</para><para>"Velocidad de rotación"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#rotationSpeed">https://w3id.org/optimar#rotationSpeed</seealso>
    let rotationSpeed = Prefixed_Name(opti, "rotationSpeed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#stress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Stress level recorded in a component."</para>
    ///   <para>"Nivel de tensión registrado en un componente."</para>
    /// labels<para>"Stress"</para><para>"Tensión"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#stress">https://w3id.org/optimar#stress</seealso>
    let stress = Prefixed_Name(opti, "stress") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a component provides structural or functional support to another."</para>
    ///   <para>"Indica que un componente proporciona soporte estructural o funcional a otro."</para>
    /// labels<para>"Soporta a"</para><para>"Supports"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#supports">https://w3id.org/optimar#supports</seealso>
    let supports = Prefixed_Name(opti, "supports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Temperature recorded expressed as a QUDT quantity value."</para>
    ///   <para>"Temperatura registrada expresada como un valor con unidad QUDT."</para>
    /// labels<para>"Temperatura"</para><para>"Temperature"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#temperature">https://w3id.org/optimar#temperature</seealso>
    let temperature = Prefixed_Name(opti, "temperature") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#thickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Thickness of the section or wall of a component measured in QUDT units."</para>
    ///   <para>"Espesor de la sección o pared de un componente medido en unidades QUDT."</para>
    /// labels<para>"Espesor"</para><para>"Thickness"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#thickness">https://w3id.org/optimar#thickness</seealso>
    let thickness = Prefixed_Name(opti, "thickness") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#transmitsMovementTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a component transmits mechanical movement to another."</para>
    ///   <para>"Indica que un componente transmite movimiento mecánico a otro."</para>
    /// labels<para>"Transmite movimiento a"</para><para>"Transmits movement to"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#transmitsMovementTo">https://w3id.org/optimar#transmitsMovementTo</seealso>
    let transmitsMovementTo = Prefixed_Name(opti, "transmitsMovementTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Measurement unit of the recorded value (e.g. m/s, rpm, °C, etc.)."</para>
    ///   <para>"Unidad de medida del valor registrado (ej. m/s, rpm, °C, etc.)."</para>
    /// labels<para>"Unidad"</para><para>"Unit"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#unit">https://w3id.org/optimar#unit</seealso>
    let unit = Prefixed_Name(opti, "unit") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Valor numérico de la medición tomada por un sensor."</para>
    ///   <para>"Numeric value of the measurement taken by a sensor."</para>
    /// labels<para>"Value"</para><para>"Valor"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#value">https://w3id.org/optimar#value</seealso>
    let value = Prefixed_Name(opti, "value") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#vibrations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Nivel de vibraciones registradas en un componente o sistema."</para>
    ///   <para>"Level of vibrations recorded in a component or system."</para>
    /// labels<para>"Vibraciones"</para><para>"Vibrations"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#vibrations">https://w3id.org/optimar#vibrations</seealso>
    let vibrations = Prefixed_Name(opti, "vibrations") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Width of the component expressed as a QUDT quantity value."</para>
    ///   <para>"Anchura del componente expresada como un valor con unidad QUDT."</para>
    /// labels<para>"Width"</para><para>"Anchura"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#width">https://w3id.org/optimar#width</seealso>
    let width = Prefixed_Name(opti, "width") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#windDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Dirección desde la que sopla el viento expresada en valores con unidad QUDT."</para>
    ///   <para>"Direction from which the wind blows expressed as a QUDT quantity value."</para>
    /// labels<para>"Dirección del viento"</para><para>"Wind direction"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#windDirection">https://w3id.org/optimar#windDirection</seealso>
    let windDirection = Prefixed_Name(opti, "windDirection") |> PrefixedName
    /// <summary>
    ///   <para>w3id:optimar#windSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Wind speed expressed as a QUDT quantity value."</para>
    ///   <para>"Velocidad del viento expresada como valor QUDT."</para>
    /// labels<para>"Velocidad del viento"</para><para>"Wind speed"</para></remarks>
    /// <seealso href="https://w3id.org/optimar#windSpeed">https://w3id.org/optimar#windSpeed</seealso>
    let windSpeed = Prefixed_Name(opti, "windSpeed") |> PrefixedName
