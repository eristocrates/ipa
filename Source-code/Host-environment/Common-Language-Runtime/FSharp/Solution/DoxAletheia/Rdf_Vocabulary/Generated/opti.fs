namespace https.w3id.org.optimar.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module opti =
    let _namespace_iri = Namespace_Iri opti |> NamespaceIRI
    /// <summary>
    ///   <para>opti:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An event that occurs in the offshore wind power platform, such as a failure detection.</para>
    ///   <para>Un evento que ocurre en la plataforma eólica, como la detección de un fallo.</para>
    /// labels<para>Evento</para><para>Event</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Event">https://w3id.org/optimar#Event</seealso>
    let Event = Prefixed_Name(opti, "Event") |> PrefixedName
    /// <summary>
    ///   <para>opti:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una clase general para representar los datos de medición recolectados por sensores u otros sistemas.</para>
    ///   <para>A class for representing the measurement data collected by sensors or other systems.</para>
    /// labels<para>Dato</para><para>Data</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Data">https://w3id.org/optimar#Data</seealso>
    let Data = Prefixed_Name(opti, "Data") |> PrefixedName

    /// <summary>
    ///   <para>opti:FloatingSubstructure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La subestructura flotante que permite que la plataforma sea estable en el mar.</para>
    ///   <para>The floating substructure that allows the platform to be stable at sea.</para>
    /// labels<para>Subestructura flotante</para><para>Floating Substructure</para></remarks>
    /// <seealso href="https://w3id.org/optimar#FloatingSubstructure">https://w3id.org/optimar#FloatingSubstructure</seealso>
    let FloatingSubstructure =
        Prefixed_Name(opti, "FloatingSubstructure") |> PrefixedName

    /// <summary>
    ///   <para>opti:ISUMSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Specialized system for integrated monitoring of the offshore platform.</para>
    ///   <para>Sistema especializado para la monitorización integrada de la plataforma offshore.</para>
    /// labels<para>Sistema ISUM</para><para>ISUM System</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ISUMSystem">https://w3id.org/optimar#ISUMSystem</seealso>
    let ISUMSystem = Prefixed_Name(opti, "ISUMSystem") |> PrefixedName
    /// <summary>
    ///   <para>opti:Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class that represents the maintenance of the wind platform.</para>
    ///   <para>Una clase que representa el mantenimiento de la plataforma eólica.</para>
    /// labels<para>Mantenimiento</para><para>Maintenance</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Maintenance">https://w3id.org/optimar#Maintenance</seealso>
    let Maintenance = Prefixed_Name(opti, "Maintenance") |> PrefixedName
    /// <summary>
    ///   <para>opti:performedBy</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/optimar#performedBy">https://w3id.org/optimar#performedBy</seealso>
    let performedBy = Prefixed_Name(opti, "performedBy") |> PrefixedName
    /// <summary>
    ///   <para>opti:MaintenanceOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person responsible for carrying out preventive and corrective maintenance on the platform.</para>
    ///   <para>Persona encargada de realizar el mantenimiento preventivo y correctivo en la plataforma.</para>
    /// labels<para>Operador de mantenimiento</para><para>Maintenance Operator</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MaintenanceOperator">https://w3id.org/optimar#MaintenanceOperator</seealso>
    let MaintenanceOperator = Prefixed_Name(opti, "MaintenanceOperator") |> PrefixedName
    /// <summary>
    ///   <para>opti:ManagementRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Role responsible for coordination, planning, and resource management in the wind platform.</para>
    ///   <para>Rol encargado de la coordinación, planificación y gestión de recursos en la plataforma eólica.</para>
    /// labels<para>Management Role</para><para>Rol de gestión</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ManagementRole">https://w3id.org/optimar#ManagementRole</seealso>
    let ManagementRole = Prefixed_Name(opti, "ManagementRole") |> PrefixedName
    /// <summary>
    ///   <para>opti:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Representa una medición tomada por un sensor.</para>
    ///   <para>Represents a measurement taken by a sensor.</para>
    /// labels<para>Measurement</para><para>Medición</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Measurement">https://w3id.org/optimar#Measurement</seealso>
    let Measurement = Prefixed_Name(opti, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>opti:Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un actor que interactúa o gestiona la plataforma eólica.</para>
    ///   <para>An actor that interacts or manages the offshore wind power platform.</para>
    /// labels<para>Actor</para><para>Actor</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Actor">https://w3id.org/optimar#Actor</seealso>
    let Actor = Prefixed_Name(opti, "Actor") |> PrefixedName
    /// <summary>
    ///   <para>opti:Anemometer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sensor que mide la velocidad y dirección del viento en el parque eólico.</para>
    ///   <para>Sensor that measures wind speed and direction in the wind farm.</para>
    /// labels<para>Anemometer</para><para>Anemómetro</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Anemometer">https://w3id.org/optimar#Anemometer</seealso>
    let Anemometer = Prefixed_Name(opti, "Anemometer") |> PrefixedName
    /// <summary>
    ///   <para>opti:Base</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La base que soporta la plataforma flotante.</para>
    ///   <para>The base that supports the floating platform.</para>
    /// labels<para>Base (subestructura flotante)</para><para>Base (floating substructure)</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Base">https://w3id.org/optimar#Base</seealso>
    let Base = Prefixed_Name(opti, "Base") |> PrefixedName
    /// <summary>
    ///   <para>opti:Blade</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The blades of the turbine that capture the wind energy.</para>
    ///   <para>Las palas de la turbina que capturan la energía eólica.</para>
    /// labels<para>Blade</para><para>Pala</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Blade">https://w3id.org/optimar#Blade</seealso>
    let Blade = Prefixed_Name(opti, "Blade") |> PrefixedName
    /// <summary>
    ///   <para>opti:TurbineComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Los componentes de la turbina eólica que generan energía a partir del viento.</para>
    ///   <para>The turbine components that generate energy from the wind.</para>
    /// labels<para>Componentes de turbina</para><para>Turbine Components</para></remarks>
    /// <seealso href="https://w3id.org/optimar#TurbineComponent">https://w3id.org/optimar#TurbineComponent</seealso>
    let TurbineComponent = Prefixed_Name(opti, "TurbineComponent") |> PrefixedName
    /// <summary>
    ///   <para>opti:ComponentBreakage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fallo originado por la fractura o rotura de un componente de la plataforma eólica.</para>
    ///   <para>Failure caused by the fracture or breakage of an offshore wind turbine component.</para>
    /// labels<para>Rotura de componente</para><para>Component Breakage</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ComponentBreakage">https://w3id.org/optimar#ComponentBreakage</seealso>
    let ComponentBreakage = Prefixed_Name(opti, "ComponentBreakage") |> PrefixedName
    /// <summary>
    ///   <para>opti:CorrosionEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Degradación de la estructura metálica de la plataforma por efectos de corrosión.</para>
    ///   <para>Degradation of the platform's metallic structure due to corrosion effects.</para>
    /// labels<para>Evento de Corrosión</para><para>Corrosion Event</para></remarks>
    /// <seealso href="https://w3id.org/optimar#CorrosionEvent">https://w3id.org/optimar#CorrosionEvent</seealso>
    let CorrosionEvent = Prefixed_Name(opti, "CorrosionEvent") |> PrefixedName
    /// <summary>
    ///   <para>opti:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Marca temporal asociada a la medición.</para>
    ///   <para>Associated temporal mark to the measurement.</para>
    /// labels<para>Date and time</para><para>Fecha y hora</para></remarks>
    /// <seealso href="https://w3id.org/optimar#dateTime">https://w3id.org/optimar#dateTime</seealso>
    let dateTime = Prefixed_Name(opti, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>opti:detectedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an event to the sensor that detected it.</para>
    ///   <para>Relaciona un evento con el sensor que lo detectó.</para>
    /// labels<para>Detectado por</para><para>Detected by</para></remarks>
    /// <seealso href="https://w3id.org/optimar#detectedBy">https://w3id.org/optimar#detectedBy</seealso>
    let detectedBy = Prefixed_Name(opti, "detectedBy") |> PrefixedName
    /// <summary>
    ///   <para>opti:diameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Diámetro del componente medido en unidades QUDT.</para>
    ///   <para>Diameter of the component measured in QUDT units.</para>
    /// labels<para>Diámetro</para><para>Diameter</para></remarks>
    /// <seealso href="https://w3id.org/optimar#diameter">https://w3id.org/optimar#diameter</seealso>
    let diameter = Prefixed_Name(opti, "diameter") |> PrefixedName
    /// <summary>
    ///   <para>opti:failureObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relación entre un evento de fallo y la observación realizada por un sensor.</para>
    ///   <para>Relationship between a failure event and the observation made by a sensor.</para>
    /// labels<para>Observación de fallo</para><para>Failure observation</para></remarks>
    /// <seealso href="https://w3id.org/optimar#failureObservation">https://w3id.org/optimar#failureObservation</seealso>
    let failureObservation = Prefixed_Name(opti, "failureObservation") |> PrefixedName
    /// <summary>
    ///   <para>opti:hasFailureCause</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a failure is caused by a specific environmental condition.</para>
    ///   <para>Indica que un fallo tiene su origen en una condición ambiental específica.</para>
    /// labels<para>Causa de fallo</para><para>Failure cause</para></remarks>
    /// <seealso href="https://w3id.org/optimar#hasFailureCause">https://w3id.org/optimar#hasFailureCause</seealso>
    let hasFailureCause = Prefixed_Name(opti, "hasFailureCause") |> PrefixedName
    /// <summary>
    ///   <para>opti:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Altura del componente expresada como un valor con unidad QUDT.</para>
    ///   <para>Height of the component expressed as a QUDT quantity value.</para>
    /// labels<para>Height</para><para>Altura</para></remarks>
    /// <seealso href="https://w3id.org/optimar#height">https://w3id.org/optimar#height</seealso>
    let height = Prefixed_Name(opti, "height") |> PrefixedName
    /// <summary>
    ///   <para>opti:AnalyticalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rol orientado al analisis de datos y generación de información útil para la toma de decisiones.</para>
    ///   <para>Role focused on data analysis and generation of useful information for decision-making.</para>
    /// labels<para>Analytical Role</para><para>Rol analítico</para></remarks>
    /// <seealso href="https://w3id.org/optimar#AnalyticalRole">https://w3id.org/optimar#AnalyticalRole</seealso>
    let AnalyticalRole = Prefixed_Name(opti, "AnalyticalRole") |> PrefixedName
    /// <summary>
    ///   <para>opti:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un dispositivo que mide o monitorea parámetros de la plataforma eólica, como viento, corrosión, vibraciones, etc.</para>
    ///   <para>A device that measures or monitors parameters of the wind platform, such as wind, corrosion, vibrations, etc.</para>
    /// labels<para>Sensor</para><para>Sensor</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Sensor">https://w3id.org/optimar#Sensor</seealso>
    let Sensor = Prefixed_Name(opti, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>opti:CloudAdministrator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Responsable de la administración y seguridad de los servicios en la nube que procesan los datos de la plataforma.</para>
    ///   <para>Responsible for managing and securing cloud services that process data from the platform.</para>
    /// labels<para>Administrador de nube</para><para>Cloud Administrator</para></remarks>
    /// <seealso href="https://w3id.org/optimar#CloudAdministrator">https://w3id.org/optimar#CloudAdministrator</seealso>
    let CloudAdministrator = Prefixed_Name(opti, "CloudAdministrator") |> PrefixedName
    /// <summary>
    ///   <para>opti:Role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Los roles de los actores que gestionan, operan o mantienen la plataforma eólica.</para>
    ///   <para>The roles of the actors that manage, operate or maintain the offshore wind power platform.</para>
    /// labels<para>Role</para><para>Rol</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Role">https://w3id.org/optimar#Role</seealso>
    let Role = Prefixed_Name(opti, "Role") |> PrefixedName
    /// <summary>
    ///   <para>opti:Tower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La estructura que sostiene la turbina eólica.</para>
    ///   <para>The structure that supports the wind turbine.</para>
    /// labels<para>Torre</para><para>Tower</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Tower">https://w3id.org/optimar#Tower</seealso>
    let Tower = Prefixed_Name(opti, "Tower") |> PrefixedName
    /// <summary>
    ///   <para>opti:VibrationData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Vibration data measured by a sensor.</para>
    ///   <para>Datos de vibracion medidos por un sensor.</para>
    /// labels<para>Datos de vibración</para><para>Vibration Data</para></remarks>
    /// <seealso href="https://w3id.org/optimar#VibrationData">https://w3id.org/optimar#VibrationData</seealso>
    let VibrationData = Prefixed_Name(opti, "VibrationData") |> PrefixedName
    /// <summary>
    ///   <para>opti:adjusts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicas that an actor makes adjustments on a component or pitch system.</para>
    ///   <para>Indica que un actor realiza ajustes sobre un componente o sistema de pitch.</para>
    /// labels<para>Adjusts</para><para>Ajusta</para></remarks>
    /// <seealso href="https://w3id.org/optimar#adjusts">https://w3id.org/optimar#adjusts</seealso>
    let adjusts = Prefixed_Name(opti, "adjusts") |> PrefixedName
    /// <summary>
    ///   <para>opti:StructuralComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The structural components that make up the basic infrastructure of the wind platform.</para>
    ///   <para>Los componentes estructurales que componen la infraestructura básica de la plataforma eólica.</para>
    /// labels<para>Componentes estructurales</para><para>Structural Components</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StructuralComponent">https://w3id.org/optimar#StructuralComponent</seealso>
    let StructuralComponent = Prefixed_Name(opti, "StructuralComponent") |> PrefixedName
    /// <summary>
    ///   <para>opti:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Un componente de una plataforma eólica offshore, como las palas, torres, sistema de pitch, etc.</para>
    ///   <para>An component of an offshore wind power platform, such as blades, towers, pitch system, etc.</para>
    /// labels<para>Componente</para><para>Component</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Component">https://w3id.org/optimar#Component</seealso>
    let Component = Prefixed_Name(opti, "Component") |> PrefixedName
    /// <summary>
    ///   <para>opti:DynamicMonitor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Device that measures dynamic parameters of the platform, such as vibrations and movements.</para>
    ///   <para>Dispositivo que mide parámetros dinámicos de la plataforma como vibraciones y movimientos.</para>
    /// labels<para>Monitor dinámico</para><para>Dynamic Monitor</para></remarks>
    /// <seealso href="https://w3id.org/optimar#DynamicMonitor">https://w3id.org/optimar#DynamicMonitor</seealso>
    let DynamicMonitor = Prefixed_Name(opti, "DynamicMonitor") |> PrefixedName
    /// <summary>
    ///   <para>opti:Misalignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fallo causado por el desajuste o falta de alineación entre los componentes de la plataforma.</para>
    ///   <para>Failure caused by misalignment or lack of proper adjustment between platform components.</para>
    /// labels<para>Desalineación</para><para>Misalignment</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Misalignment">https://w3id.org/optimar#Misalignment</seealso>
    let Misalignment = Prefixed_Name(opti, "Misalignment") |> PrefixedName
    /// <summary>
    ///   <para>opti:monitors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an actor to the components or sensors they monitor.</para>
    ///   <para>Relaciona a un actor con los componentes o sensores que supervisa.</para>
    /// labels<para>Monitorea</para><para>Monitors</para></remarks>
    /// <seealso href="https://w3id.org/optimar#monitors">https://w3id.org/optimar#monitors</seealso>
    let monitors = Prefixed_Name(opti, "monitors") |> PrefixedName
    /// <summary>
    ///   <para>opti:operationalStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Current operational status of the turbine (e.g. operative, stopped, under maintenance, etc.).</para>
    ///   <para>Estado de funcionamiento actual de la turbina (ej. operativa, parada, en mantenimiento, etc.).</para>
    /// labels<para>Operational status</para><para>Estado operativo</para></remarks>
    /// <seealso href="https://w3id.org/optimar#operationalStatus">https://w3id.org/optimar#operationalStatus</seealso>
    let operationalStatus = Prefixed_Name(opti, "operationalStatus") |> PrefixedName
    /// <summary>
    ///   <para>opti:performsTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relaciona un actor con una tarea que ejecuta como parte de su rol.</para>
    ///   <para>Relates an actor with a task that it performs as part of its role.</para>
    /// labels<para>Performs task</para><para>Realiza tarea</para></remarks>
    /// <seealso href="https://w3id.org/optimar#performsTask">https://w3id.org/optimar#performsTask</seealso>
    let performsTask = Prefixed_Name(opti, "performsTask") |> PrefixedName
    /// <summary>
    ///   <para>opti:relatedToComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relaciona un evento con el componente de la plataforma que se ve afectado.</para>
    ///   <para>Relates an event to the platform component that is affected.</para>
    /// labels<para>Relacionado con componente</para><para>Related to component</para></remarks>
    /// <seealso href="https://w3id.org/optimar#relatedToComponent">https://w3id.org/optimar#relatedToComponent</seealso>
    let relatedToComponent = Prefixed_Name(opti, "relatedToComponent") |> PrefixedName
    /// <summary>
    ///   <para>opti:rotationSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Angular speed of a component expressed as a QUDT quantity value.</para>
    ///   <para>Velocidad angular de un componente expresada como un valor con unidad QUDT.</para>
    /// labels<para>Velocidad de rotación</para><para>Rotation speed</para></remarks>
    /// <seealso href="https://w3id.org/optimar#rotationSpeed">https://w3id.org/optimar#rotationSpeed</seealso>
    let rotationSpeed = Prefixed_Name(opti, "rotationSpeed") |> PrefixedName
    /// <summary>
    ///   <para>opti:supports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a component provides structural or functional support to another.</para>
    ///   <para>Indica que un componente proporciona soporte estructural o funcional a otro.</para>
    /// labels<para>Soporta a</para><para>Supports</para></remarks>
    /// <seealso href="https://w3id.org/optimar#supports">https://w3id.org/optimar#supports</seealso>
    let supports = Prefixed_Name(opti, "supports") |> PrefixedName
    /// <summary>
    ///   <para>opti:temperature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Temperatura registrada expresada como un valor con unidad QUDT.</para>
    ///   <para>Temperature recorded expressed as a QUDT quantity value.</para>
    /// labels<para>Temperatura</para><para>Temperature</para></remarks>
    /// <seealso href="https://w3id.org/optimar#temperature">https://w3id.org/optimar#temperature</seealso>
    let temperature = Prefixed_Name(opti, "temperature") |> PrefixedName
    /// <summary>
    ///   <para>opti:transmitsMovementTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica que un componente transmite movimiento mecánico a otro.</para>
    ///   <para>Indicates that a component transmits mechanical movement to another.</para>
    /// labels<para>Transmite movimiento a</para><para>Transmits movement to</para></remarks>
    /// <seealso href="https://w3id.org/optimar#transmitsMovementTo">https://w3id.org/optimar#transmitsMovementTo</seealso>
    let transmitsMovementTo = Prefixed_Name(opti, "transmitsMovementTo") |> PrefixedName
    /// <summary>
    ///   <para>opti:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Valor numérico de la medición tomada por un sensor.</para>
    ///   <para>Numeric value of the measurement taken by a sensor.</para>
    /// labels<para>Valor</para><para>Value</para></remarks>
    /// <seealso href="https://w3id.org/optimar#value">https://w3id.org/optimar#value</seealso>
    let value = Prefixed_Name(opti, "value") |> PrefixedName
    /// <summary>
    ///   <para>opti:Turbine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A wind turbine that is part of the wind platform.</para>
    ///   <para>Una turbina de viento que forma parte de la plataforma eólica.</para>
    /// labels<para>Turbina</para><para>Turbine</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Turbine">https://w3id.org/optimar#Turbine</seealso>
    let Turbine = Prefixed_Name(opti, "Turbine") |> PrefixedName
    /// <summary>
    ///   <para>opti:WindPowerPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An offshore wind power platform that generates electricity from wind.</para>
    ///   <para>Una plataforma eólica offshore que genera energía electrica a partir del viento.</para>
    /// labels<para>Offshore Wind Power Platform</para><para>Plataforma eólica offshore</para></remarks>
    /// <seealso href="https://w3id.org/optimar#WindPowerPlatform">https://w3id.org/optimar#WindPowerPlatform</seealso>
    let WindPowerPlatform = Prefixed_Name(opti, "WindPowerPlatform") |> PrefixedName
    /// <summary>
    ///   <para>opti:analyzes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relaciona a un actor con los datos o fallos que estudia o interpreta.</para>
    ///   <para>Relates an actor to the data or failures that it studies or interprets.</para>
    /// labels<para>Analyzes</para><para>Analiza</para></remarks>
    /// <seealso href="https://w3id.org/optimar#analyzes">https://w3id.org/optimar#analyzes</seealso>
    let analyzes = Prefixed_Name(opti, "analyzes") |> PrefixedName
    /// <summary>
    ///   <para>opti:connectedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a component is connected to another.</para>
    ///   <para>Indica que un componente está conectado a otro.</para>
    /// labels<para>Connected to</para><para>Conectado a</para></remarks>
    /// <seealso href="https://w3id.org/optimar#connectedTo">https://w3id.org/optimar#connectedTo</seealso>
    let connectedTo = Prefixed_Name(opti, "connectedTo") |> PrefixedName
    /// <summary>
    ///   <para>opti:darkCorrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Level of dark corrosion detected on the mmaterial surface.</para>
    ///   <para>Nivel de corrosión oscura detectada en la superficie del material.</para>
    /// labels<para>Corrosión oscura</para><para>Dark corrosion</para></remarks>
    /// <seealso href="https://w3id.org/optimar#darkCorrosion">https://w3id.org/optimar#darkCorrosion</seealso>
    let darkCorrosion = Prefixed_Name(opti, "darkCorrosion") |> PrefixedName
    /// <summary>
    ///   <para>opti:detectsCorrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a sensor with the detected corrosion measurement.</para>
    ///   <para>Relaciona un sensor con la medición de corrosión detectada.</para>
    /// labels<para>Detecta corrosión</para><para>Detects corrosion</para></remarks>
    /// <seealso href="https://w3id.org/optimar#detectsCorrosion">https://w3id.org/optimar#detectsCorrosion</seealso>
    let detectsCorrosion = Prefixed_Name(opti, "detectsCorrosion") |> PrefixedName
    /// <summary>
    ///   <para>opti:displacement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Displacement or position change recorded in the component.</para>
    ///   <para>Desplazamiento o cambio de posición registrado en el componente.</para>
    /// labels<para>Desplazamiento</para><para>Displacement</para></remarks>
    /// <seealso href="https://w3id.org/optimar#displacement">https://w3id.org/optimar#displacement</seealso>
    let displacement = Prefixed_Name(opti, "displacement") |> PrefixedName
    /// <summary>
    ///   <para>opti:hasCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Rated generation capacity of the turbine.</para>
    ///   <para>Capacidad nominal de generación de la turbina.</para>
    /// labels<para>Capacidad</para><para>Capacity</para></remarks>
    /// <seealso href="https://w3id.org/optimar#hasCapacity">https://w3id.org/optimar#hasCapacity</seealso>
    let hasCapacity = Prefixed_Name(opti, "hasCapacity") |> PrefixedName
    /// <summary>
    ///   <para>opti:hasRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicas the role that an actor performs within the system.</para>
    ///   <para>Indica el rol que desempeña un actor dentro del sistema.</para>
    /// labels<para>Tiene rol</para><para>Has role</para></remarks>
    /// <seealso href="https://w3id.org/optimar#hasRole">https://w3id.org/optimar#hasRole</seealso>
    let hasRole = Prefixed_Name(opti, "hasRole") |> PrefixedName
    /// <summary>
    ///   <para>opti:houses</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica que un componente contiene o aloja fisicamente a otro en su estructura.</para>
    ///   <para>Indicates that a component contains or houses physically another in its structure.</para>
    /// labels<para>Houses</para><para>Aloja</para></remarks>
    /// <seealso href="https://w3id.org/optimar#houses">https://w3id.org/optimar#houses</seealso>
    let houses = Prefixed_Name(opti, "houses") |> PrefixedName
    /// <summary>
    ///   <para>opti:imageURL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Access URL of the generated or stored image.</para>
    ///   <para>Dirección de acceso a la imagen generada o almacenada.</para>
    /// labels<para>URL de la imagen</para><para>Image URL</para></remarks>
    /// <seealso href="https://w3id.org/optimar#imageURL">https://w3id.org/optimar#imageURL</seealso>
    let imageURL = Prefixed_Name(opti, "imageURL") |> PrefixedName
    /// <summary>
    ///   <para>opti:isSupportedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a component is structurally or functionally supported by another.</para>
    ///   <para>Indica que un componente depende estructural o funcionalmente de otro para su soporte.</para>
    /// labels<para>Es soportado por</para><para>Is supported by</para></remarks>
    /// <seealso href="https://w3id.org/optimar#isSupportedBy">https://w3id.org/optimar#isSupportedBy</seealso>
    let isSupportedBy = Prefixed_Name(opti, "isSupportedBy") |> PrefixedName
    /// <summary>
    ///   <para>opti:length</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Length of a component, expressed as a QUDT quantity value</para>
    ///   <para>Longitud de un componente, expresada como un valor con unidad QUDT</para>
    /// labels<para>Longitud</para><para>Length</para></remarks>
    /// <seealso href="https://w3id.org/optimar#length">https://w3id.org/optimar#length</seealso>
    let length = Prefixed_Name(opti, "length") |> PrefixedName
    /// <summary>
    ///   <para>opti:lightCorrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Level of light corrosion detected on the material surface.</para>
    ///   <para>Nivel de corrosión clara detectada en la superficie del material.</para>
    /// labels<para>Light corrosion</para><para>Corrosión clara</para></remarks>
    /// <seealso href="https://w3id.org/optimar#lightCorrosion">https://w3id.org/optimar#lightCorrosion</seealso>
    let lightCorrosion = Prefixed_Name(opti, "lightCorrosion") |> PrefixedName
    /// <summary>
    ///   <para>opti:locatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica el lugar en el que se encuentra la plataforma eólica.</para>
    ///   <para>Indicates the location where the wind power platform is located.</para>
    /// labels<para>Located in</para><para>Ubicado en</para></remarks>
    /// <seealso href="https://w3id.org/optimar#locatedIn">https://w3id.org/optimar#locatedIn</seealso>
    let locatedIn = Prefixed_Name(opti, "locatedIn") |> PrefixedName
    /// <summary>
    ///   <para>opti:mass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Masa del componente expresada expresada como un valor con unidad QUDT</para>
    ///   <para>Mass of the component expressed as a QUDT quantity value</para>
    /// labels<para>Mass</para><para>Masa</para></remarks>
    /// <seealso href="https://w3id.org/optimar#mass">https://w3id.org/optimar#mass</seealso>
    let mass = Prefixed_Name(opti, "mass") |> PrefixedName
    /// <summary>
    ///   <para>opti:material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Material de fabricación del componente (ej. acero, compuesto, fibra de vidrio, etc.).</para>
    ///   <para>Material of manufacturing of the component (e.g. steel, composite, fiberglass, etc.).</para>
    /// labels<para>Material</para><para>Material</para></remarks>
    /// <seealso href="https://w3id.org/optimar#material">https://w3id.org/optimar#material</seealso>
    let material = Prefixed_Name(opti, "material") |> PrefixedName
    /// <summary>
    ///   <para>opti:materialFatigue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Accumulated material fatigue degree.</para>
    ///   <para>Grado de fatiga acumulada en el material.</para>
    /// labels<para>Material fatigue</para><para>Fatiga material</para></remarks>
    /// <seealso href="https://w3id.org/optimar#materialFatigue">https://w3id.org/optimar#materialFatigue</seealso>
    let materialFatigue = Prefixed_Name(opti, "materialFatigue") |> PrefixedName
    /// <summary>
    ///   <para>opti:measuresStress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indicates that a sensor measures the stress exerted on a component.</para>
    ///   <para>Indica que un sensor mide la tensión ejercida sobre un componente.</para>
    /// labels<para>Measures stress</para><para>Mide tensión</para></remarks>
    /// <seealso href="https://w3id.org/optimar#measuresStress">https://w3id.org/optimar#measuresStress</seealso>
    let measuresStress = Prefixed_Name(opti, "measuresStress") |> PrefixedName
    /// <summary>
    ///   <para>opti:measuresWind</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a sensor with the measurement of wind speed or direction.</para>
    ///   <para>Relaciona un sensor con la medición de velocidad o dirección del viento.</para>
    /// labels<para>Measures wind</para><para>Mide viento</para></remarks>
    /// <seealso href="https://w3id.org/optimar#measuresWind">https://w3id.org/optimar#measuresWind</seealso>
    let measuresWind = Prefixed_Name(opti, "measuresWind") |> PrefixedName
    /// <summary>
    ///   <para>opti:Failure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class that represents identified failures in the wind platform.</para>
    ///   <para>Una clase que representa fallos identificados en la plataforma eólica.</para>
    /// labels<para>Failure</para><para>Fallo</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Failure">https://w3id.org/optimar#Failure</seealso>
    let Failure = Prefixed_Name(opti, "Failure") |> PrefixedName
    /// <summary>
    ///   <para>opti:manages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Infica que un actor se encarga de la gestión de una plataforma eólica o su sistema de anclaje.</para>
    ///   <para>Indicates that an actor is responsible for managing a wind power platform or its mooring system.</para>
    /// labels<para>Administra</para><para>Manages</para></remarks>
    /// <seealso href="https://w3id.org/optimar#manages">https://w3id.org/optimar#manages</seealso>
    let manages = Prefixed_Name(opti, "manages") |> PrefixedName
    /// <summary>
    ///   <para>opti:Corrosion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Índice general de corrosión detectada en un componente.</para>
    ///   <para>General corrosion index detected in a component.</para>
    /// labels<para>Corrosion</para><para>Corrosión</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Corrosion">https://w3id.org/optimar#Corrosion</seealso>
    let Corrosion = Prefixed_Name(opti, "Corrosion") |> PrefixedName
    /// <summary>
    ///   <para>opti:StructuralCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cámara dedicada a la inspección visual del estado estructural de la plataforma.</para>
    ///   <para>Camera dedicated to visual inspection of the structural condition of the platform.</para>
    /// labels<para>Cámara estructural</para><para>Structural Camera</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StructuralCamera">https://w3id.org/optimar#StructuralCamera</seealso>
    let StructuralCamera = Prefixed_Name(opti, "StructuralCamera") |> PrefixedName
    /// <summary>
    ///   <para>opti:FailureEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Event that represents a detected failure in the system, must be caused by at least one failure.</para>
    ///   <para>Evento que representa un fallo detectado en el sistema, debe estar causado por al menos un fallo. </para>
    /// labels<para>Evento de fallo</para><para>Failure Event</para></remarks>
    /// <seealso href="https://w3id.org/optimar#FailureEvent">https://w3id.org/optimar#FailureEvent</seealso>
    let FailureEvent = Prefixed_Name(opti, "FailureEvent") |> PrefixedName
    /// <summary>
    ///   <para>opti:materialWear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree of material wear in a component.</para>
    ///   <para>Grado de desgaste de un material en un componente.</para>
    /// labels<para>Desgaste material</para><para>Material wear</para></remarks>
    /// <seealso href="https://w3id.org/optimar#materialWear">https://w3id.org/optimar#materialWear</seealso>
    let materialWear = Prefixed_Name(opti, "materialWear") |> PrefixedName
    /// <summary>
    ///   <para>opti:measuresVibration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Indica que un sensor obtiene datos de vibración de un componente.</para>
    ///   <para>Indicates that a sensor collects vibration data from a component.</para>
    /// labels<para>Measures vibration</para><para>Mide vibración</para></remarks>
    /// <seealso href="https://w3id.org/optimar#measuresVibration">https://w3id.org/optimar#measuresVibration</seealso>
    let measuresVibration = Prefixed_Name(opti, "measuresVibration") |> PrefixedName
    /// <summary>
    ///   <para>opti:misalignment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Measure of the misalignment detected in a component.</para>
    ///   <para>Medida de la falta de alineación detectada en un componente.</para>
    /// labels<para>Desalineación</para><para>Misalignment</para></remarks>
    /// <seealso href="https://w3id.org/optimar#misalignment">https://w3id.org/optimar#misalignment</seealso>
    let misalignment = Prefixed_Name(opti, "misalignment") |> PrefixedName
    /// <summary>
    ///   <para>opti:monitorsDeformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates a sensor to the structural deformation it measures or monitors.</para>
    ///   <para>Relaciona un sensor con la deformación estructural que mide o supervisa.</para>
    /// labels<para>Monitorea deformación</para><para>Monitors deformation</para></remarks>
    /// <seealso href="https://w3id.org/optimar#monitorsDeformation">https://w3id.org/optimar#monitorsDeformation</seealso>
    let monitorsDeformation = Prefixed_Name(opti, "monitorsDeformation") |> PrefixedName

    /// <summary>
    ///   <para>opti:performedMaintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relaciona un actor con el mantenimiento que realiza.</para>
    ///   <para>Relates an actor with the maintenance that it performs.</para>
    /// labels<para>Realiza mantenimiento</para><para>Performs maintenance</para></remarks>
    /// <seealso href="https://w3id.org/optimar#performedMaintenance">https://w3id.org/optimar#performedMaintenance</seealso>
    let performedMaintenance =
        Prefixed_Name(opti, "performedMaintenance") |> PrefixedName

    /// <summary>
    ///   <para>opti:pressure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Pressure exerted on a component.</para>
    ///   <para>Presión ejercida sobre un componente.</para>
    /// labels<para>Pressure</para><para>Presión</para></remarks>
    /// <seealso href="https://w3id.org/optimar#pressure">https://w3id.org/optimar#pressure</seealso>
    let pressure = Prefixed_Name(opti, "pressure") |> PrefixedName
    /// <summary>
    ///   <para>opti:stress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nivel de tensión registrado en un componente.</para>
    ///   <para>Stress level recorded in a component.</para>
    /// labels<para>Tensión</para><para>Stress</para></remarks>
    /// <seealso href="https://w3id.org/optimar#stress">https://w3id.org/optimar#stress</seealso>
    let stress = Prefixed_Name(opti, "stress") |> PrefixedName
    /// <summary>
    ///   <para>opti:thickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Espesor de la sección o pared de un componente medido en unidades QUDT.</para>
    ///   <para>Thickness of the section or wall of a component measured in QUDT units.</para>
    /// labels<para>Thickness</para><para>Espesor</para></remarks>
    /// <seealso href="https://w3id.org/optimar#thickness">https://w3id.org/optimar#thickness</seealso>
    let thickness = Prefixed_Name(opti, "thickness") |> PrefixedName
    /// <summary>
    ///   <para>opti:unit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Unidad de medida del valor registrado (ej. m/s, rpm, °C, etc.).</para>
    ///   <para>Measurement unit of the recorded value (e.g. m/s, rpm, °C, etc.).</para>
    /// labels<para>Unidad</para><para>Unit</para></remarks>
    /// <seealso href="https://w3id.org/optimar#unit">https://w3id.org/optimar#unit</seealso>
    let unit = Prefixed_Name(opti, "unit") |> PrefixedName
    /// <summary>
    ///   <para>opti:vibrations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Nivel de vibraciones registradas en un componente o sistema.</para>
    ///   <para>Level of vibrations recorded in a component or system.</para>
    /// labels<para>Vibraciones</para><para>Vibrations</para></remarks>
    /// <seealso href="https://w3id.org/optimar#vibrations">https://w3id.org/optimar#vibrations</seealso>
    let vibrations = Prefixed_Name(opti, "vibrations") |> PrefixedName
    /// <summary>
    ///   <para>opti:windDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Direction from which the wind blows expressed as a QUDT quantity value.</para>
    ///   <para>Dirección desde la que sopla el viento expresada en valores con unidad QUDT.</para>
    /// labels<para>Dirección del viento</para><para>Wind direction</para></remarks>
    /// <seealso href="https://w3id.org/optimar#windDirection">https://w3id.org/optimar#windDirection</seealso>
    let windDirection = Prefixed_Name(opti, "windDirection") |> PrefixedName
    /// <summary>
    ///   <para>opti:windSpeed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Wind speed expressed as a QUDT quantity value.</para>
    ///   <para>Velocidad del viento expresada como valor QUDT.</para>
    /// labels<para>Velocidad del viento</para><para>Wind speed</para></remarks>
    /// <seealso href="https://w3id.org/optimar#windSpeed">https://w3id.org/optimar#windSpeed</seealso>
    let windSpeed = Prefixed_Name(opti, "windSpeed") |> PrefixedName
    /// <summary>
    ///   <para>opti:CorrosionCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Cámara utilizada para detectar y monitorear corrosión en la estructura de la plataforma.</para>
    ///   <para>Camera used to detect and monitor corrosion in the platform structure.</para>
    /// labels<para>Corrosion Camera</para><para>Cámara corrosión</para></remarks>
    /// <seealso href="https://w3id.org/optimar#CorrosionCamera">https://w3id.org/optimar#CorrosionCamera</seealso>
    let CorrosionCamera = Prefixed_Name(opti, "CorrosionCamera") |> PrefixedName
    /// <summary>
    ///   <para>opti:externalShape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Describe la forma externa o geometría del componente.</para>
    ///   <para>Describe the external shape or geometric of the component.</para>
    /// labels<para>External shape</para><para>Forma externa</para></remarks>
    /// <seealso href="https://w3id.org/optimar#externalShape">https://w3id.org/optimar#externalShape</seealso>
    let externalShape = Prefixed_Name(opti, "externalShape") |> PrefixedName
    /// <summary>
    ///   <para>opti:MaterialFatigue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Structural material failure caused by repeated load cycles.</para>
    ///   <para>Fallo en el material estructural causado por ciclos repetidos de carga.</para>
    /// labels<para>Fatiga del material</para><para>Material Fatigue</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MaterialFatigue">https://w3id.org/optimar#MaterialFatigue</seealso>
    let MaterialFatigue = Prefixed_Name(opti, "MaterialFatigue") |> PrefixedName
    /// <summary>
    ///   <para>opti:DataAnalyst</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Especialista que analiza los datos recolectados para detectar patrones, fallos y oportunidades de optimización.</para>
    ///   <para>Specialist who analyzes collected data to detect patterns, failures, and optimization opportunities.</para>
    /// labels<para>Analista de datos</para><para>Data Analyst</para></remarks>
    /// <seealso href="https://w3id.org/optimar#DataAnalyst">https://w3id.org/optimar#DataAnalyst</seealso>
    let DataAnalyst = Prefixed_Name(opti, "DataAnalyst") |> PrefixedName

    /// <summary>
    ///   <para>opti:EnvironmentalCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The environmental conditions that affect the offshore wind power platform, such as wind speed, temperature, etc.</para>
    ///   <para>Las condiciones ambientales que afectan a la plataforma eólica, como la velocidad del viento, la temperatura, etc.</para>
    /// labels<para>Environmental Condition</para><para>Condición ambiental</para></remarks>
    /// <seealso href="https://w3id.org/optimar#EnvironmentalCondition">https://w3id.org/optimar#EnvironmentalCondition</seealso>
    let EnvironmentalCondition =
        Prefixed_Name(opti, "EnvironmentalCondition") |> PrefixedName

    /// <summary>
    ///   <para>opti:Deformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Degree of deformation recorded in the component.</para>
    ///   <para>Grado de deformación registrado en el componente.</para>
    /// labels<para>Deformation</para><para>Deformación</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Deformation">https://w3id.org/optimar#Deformation</seealso>
    let Deformation = Prefixed_Name(opti, "Deformation") |> PrefixedName
    /// <summary>
    ///   <para>opti:causedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an event with the failure that caused it.</para>
    ///   <para>Relaciona un evento con el fallo que lo provocó.</para>
    /// labels<para>Causado por</para><para>Caused by</para></remarks>
    /// <seealso href="https://w3id.org/optimar#causedBy">https://w3id.org/optimar#causedBy</seealso>
    let causedBy = Prefixed_Name(opti, "causedBy") |> PrefixedName
    /// <summary>
    ///   <para>opti:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Width of the component expressed as a QUDT quantity value.</para>
    ///   <para>Anchura del componente expresada como un valor con unidad QUDT.</para>
    /// labels<para>Anchura</para><para>Width</para></remarks>
    /// <seealso href="https://w3id.org/optimar#width">https://w3id.org/optimar#width</seealso>
    let width = Prefixed_Name(opti, "width") |> PrefixedName
    /// <summary>
    ///   <para>opti:Hub</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>La parte central de la turbina donde se conectan las palas.</para>
    ///   <para>The central part of the turbine where the blades are connected.</para>
    /// labels<para>Hub</para><para>Hub</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Hub">https://w3id.org/optimar#Hub</seealso>
    let Hub = Prefixed_Name(opti, "Hub") |> PrefixedName
    /// <summary>
    ///   <para>opti:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A class that represents an image that supports the measurement.</para>
    ///   <para>Una clase que representa una imagen que soporta la medición.</para>
    /// labels<para>Imagen</para><para>Image</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Image">https://w3id.org/optimar#Image</seealso>
    let Image = Prefixed_Name(opti, "Image") |> PrefixedName
    /// <summary>
    ///   <para>opti:FloatingPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una plataforma flotante que sirve de base para la turbina eólica.</para>
    ///   <para>A floating platform that serves as a base for the wind turbine.</para>
    /// labels<para>Plataforma flotante</para><para>Floating Platform</para></remarks>
    /// <seealso href="https://w3id.org/optimar#FloatingPlatform">https://w3id.org/optimar#FloatingPlatform</seealso>
    let FloatingPlatform = Prefixed_Name(opti, "FloatingPlatform") |> PrefixedName
    /// <summary>
    ///   <para>opti:GaugeSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Strain gauge system used to measure stresses and deformations in the structure.</para>
    ///   <para>Sistema de galgas extensiométricas utilizado para medir tensiones y deformaciones en la estructura.</para>
    /// labels<para>Sistema de galgas</para><para>Gauge System</para></remarks>
    /// <seealso href="https://w3id.org/optimar#GaugeSystem">https://w3id.org/optimar#GaugeSystem</seealso>
    let GaugeSystem = Prefixed_Name(opti, "GaugeSystem") |> PrefixedName
    /// <summary>
    ///   <para>opti:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The geographic location of the wind platform.</para>
    ///   <para>La ubicación geográfica de la plataforma eólica.</para>
    /// labels<para>Ubicación</para><para>Location</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Location">https://w3id.org/optimar#Location</seealso>
    let Location = Prefixed_Name(opti, "Location") |> PrefixedName
    /// <summary>
    ///   <para>opti:MonitoringTask</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una tarea destinada a supervisar el estado de la plataforma mediante sensores y sistemas de monitorización.</para>
    ///   <para>A task aimed at supervising the condition of the platform through sensors and monitoring systems.</para>
    /// labels<para>Tarea de monitoreo</para><para>Monitoring Task</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MonitoringTask">https://w3id.org/optimar#MonitoringTask</seealso>
    let MonitoringTask = Prefixed_Name(opti, "MonitoringTask") |> PrefixedName
    /// <summary>
    ///   <para>opti:Task</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Una tarea general relacionada con la operación, supervisión o mantenimiento de la plataforma eólica.</para>
    ///   <para>A general task related to the operation, monitoring, or maintenance of the wind platform.</para>
    /// labels<para>Tarea</para><para>Task</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Task">https://w3id.org/optimar#Task</seealso>
    let Task = Prefixed_Name(opti, "Task") |> PrefixedName
    /// <summary>
    ///   <para>opti:MooringSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>El sistema de amarre que mantiene la plataforma flotante en su ubicación.</para>
    ///   <para>The mooring system that keeps the floating platform in place.</para>
    /// labels<para>Sistema de amarre</para><para>Mooring System</para></remarks>
    /// <seealso href="https://w3id.org/optimar#MooringSystem">https://w3id.org/optimar#MooringSystem</seealso>
    let MooringSystem = Prefixed_Name(opti, "MooringSystem") |> PrefixedName
    /// <summary>
    ///   <para>opti:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The result of recording a phenomenon or condition, usually through a sensor or monitoring system.</para>
    ///   <para>El resultado de registrar un fenómeno o condición, normalmente a través de un sensor o sistema de monitorización.</para>
    /// labels<para>Observación</para><para>Observation</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Observation">https://w3id.org/optimar#Observation</seealso>
    let Observation = Prefixed_Name(opti, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>opti:StressData</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Datos de tensión medidos por un sensor.</para>
    ///   <para>Stress data measured by a sensor.</para>
    /// labels<para>Datos de tensión</para><para>Stress Data</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StressData">https://w3id.org/optimar#StressData</seealso>
    let StressData = Prefixed_Name(opti, "StressData") |> PrefixedName
    /// <summary>
    ///   <para>opti:ParkOwner</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Entidad o persona propietaria del parque eólico offshore y responsable de su operación general.</para>
    ///   <para>Entity or individual owning the offshore wind farm and responsible for its overall operation.</para>
    /// labels<para>Propietario de parque</para><para>Park Owner</para></remarks>
    /// <seealso href="https://w3id.org/optimar#ParkOwner">https://w3id.org/optimar#ParkOwner</seealso>
    let ParkOwner = Prefixed_Name(opti, "ParkOwner") |> PrefixedName
    /// <summary>
    ///   <para>opti:PlatformActuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Encargado de realizar ajustes sobre la plataforma, como ajustes mecánicos o hidráulicos.</para>
    ///   <para>Responsible for making adjustments on the platform, such as mechanical or hydraulic adjustments.</para>
    /// labels<para>Actuador de plataforma</para><para>Platform Actuator</para></remarks>
    /// <seealso href="https://w3id.org/optimar#PlatformActuator">https://w3id.org/optimar#PlatformActuator</seealso>
    let PlatformActuator = Prefixed_Name(opti, "PlatformActuator") |> PrefixedName

    /// <summary>
    ///   <para>opti:StructuralInstability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Fallo que compromete la estabilidad estructural de la plataforma flotante.</para>
    ///   <para>Failure that compromises the structural stability of the floating platform.</para>
    /// labels<para>Inestabilidad estructural</para><para>Structural Instability</para></remarks>
    /// <seealso href="https://w3id.org/optimar#StructuralInstability">https://w3id.org/optimar#StructuralInstability</seealso>
    let StructuralInstability =
        Prefixed_Name(opti, "StructuralInstability") |> PrefixedName

    /// <summary>
    ///   <para>opti:TechnicalRole</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Rol asociado a actividades técnicas como operación, reparación y supervisión de sistemas.</para>
    ///   <para>Role associated with technical activities such as operation, repair, and system supervision.</para>
    /// labels<para>Technical Role</para><para>Rol técnico</para></remarks>
    /// <seealso href="https://w3id.org/optimar#TechnicalRole">https://w3id.org/optimar#TechnicalRole</seealso>
    let TechnicalRole = Prefixed_Name(opti, "TechnicalRole") |> PrefixedName
    /// <summary>
    ///   <para>opti:Nacelle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>El compartimento de la turbina que aloja el generador y otros componentes mecánicos.</para>
    ///   <para>The turbine component that houses the generator and other mechanical components.</para>
    /// labels<para>Nacelle</para><para>Nacelle</para></remarks>
    /// <seealso href="https://w3id.org/optimar#Nacelle">https://w3id.org/optimar#Nacelle</seealso>
    let Nacelle = Prefixed_Name(opti, "Nacelle") |> PrefixedName
    /// <summary>
    ///   <para>opti:madeBySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relates an observation to the sensor that made it.</para>
    ///   <para>Relaciona una observación con el sensor que la realizó.</para>
    /// labels<para>Realizada por sensor</para><para>Made by sensor</para></remarks>
    /// <seealso href="https://w3id.org/optimar#madeBySensor">https://w3id.org/optimar#madeBySensor</seealso>
    let madeBySensor = Prefixed_Name(opti, "madeBySensor") |> PrefixedName
    /// <summary>
    ///   <para>opti:PitchSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>El sistema que ajusta el ángulo de las palas de la turbina.</para>
    ///   <para>The system that adjusts the angle of the blades of the turbine.</para>
    /// labels<para>Sistema de pitch</para><para>Pitch System</para></remarks>
    /// <seealso href="https://w3id.org/optimar#PitchSystem">https://w3id.org/optimar#PitchSystem</seealso>
    let PitchSystem = Prefixed_Name(opti, "PitchSystem") |> PrefixedName
    /// <summary>
    ///   <para>opti:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="https://w3id.org/optimar#">https://w3id.org/optimar#</seealso>
    let _prefix_iri = Prefixed_Name(opti, "") |> PrefixedName
