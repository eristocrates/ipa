namespace https.w3id.org.optimar.hash

open DoxAletheia.Rdf_Vocabulary

module opti =
    let _namespace_name = "https://w3id.org/optimar#"
    /// <summary>
    /// An event that occurs in the offshore wind power platform, such as a failure detection.
    /// <see href="https://w3id.org/optimar#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// A class for representing the measurement data collected by sensors or other systems.
    /// <see href="https://w3id.org/optimar#Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName
    /// <summary>
    /// An actor that interacts or manages the offshore wind power platform.
    /// <see href="https://w3id.org/optimar#Actor"></see></summary>
    let Actor = Namespaced_IRI.parse _namespace_name "Actor" |> NamespacedName

    /// <summary>
    /// Role focused on data analysis and generation of useful information for decision-making.
    /// <see href="https://w3id.org/optimar#AnalyticalRole"></see></summary>
    let AnalyticalRole =
        Namespaced_IRI.parse _namespace_name "AnalyticalRole" |> NamespacedName

    /// <summary>
    /// The roles of the actors that manage, operate or maintain the offshore wind power platform.
    /// <see href="https://w3id.org/optimar#Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Sensor that measures wind speed and direction in the wind farm.
    /// <see href="https://w3id.org/optimar#Anemometer"></see></summary>
    let Anemometer = Namespaced_IRI.parse _namespace_name "Anemometer" |> NamespacedName
    /// <summary>
    /// A device that measures or monitors parameters of the wind platform, such as wind, corrosion, vibrations, etc.
    /// <see href="https://w3id.org/optimar#Sensor"></see></summary>
    let Sensor = Namespaced_IRI.parse _namespace_name "Sensor" |> NamespacedName
    /// <summary>
    /// The base that supports the floating platform.
    /// <see href="https://w3id.org/optimar#Base"></see></summary>
    let Base = Namespaced_IRI.parse _namespace_name "Base" |> NamespacedName

    /// <summary>
    /// The structural components that make up the basic infrastructure of the wind platform.
    /// <see href="https://w3id.org/optimar#StructuralComponent"></see></summary>
    let StructuralComponent =
        Namespaced_IRI.parse _namespace_name "StructuralComponent" |> NamespacedName

    /// <summary>
    /// The blades of the turbine that capture the wind energy.
    /// <see href="https://w3id.org/optimar#Blade"></see></summary>
    let Blade = Namespaced_IRI.parse _namespace_name "Blade" |> NamespacedName

    /// <summary>
    /// The turbine components that generate energy from the wind.
    /// <see href="https://w3id.org/optimar#TurbineComponent"></see></summary>
    let TurbineComponent =
        Namespaced_IRI.parse _namespace_name "TurbineComponent" |> NamespacedName

    /// <summary>
    /// Responsible for managing and securing cloud services that process data from the platform.
    /// <see href="https://w3id.org/optimar#CloudAdministrator"></see></summary>
    let CloudAdministrator =
        Namespaced_IRI.parse _namespace_name "CloudAdministrator" |> NamespacedName

    /// <summary>
    /// An component of an offshore wind power platform, such as blades, towers, pitch system, etc.
    /// <see href="https://w3id.org/optimar#Component"></see></summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName

    /// <summary>
    /// Failure caused by the fracture or breakage of an offshore wind turbine component.
    /// <see href="https://w3id.org/optimar#ComponentBreakage"></see></summary>
    let ComponentBreakage =
        Namespaced_IRI.parse _namespace_name "ComponentBreakage" |> NamespacedName

    /// <summary>
    /// A class that represents identified failures in the wind platform.
    /// <see href="https://w3id.org/optimar#Failure"></see></summary>
    let Failure = Namespaced_IRI.parse _namespace_name "Failure" |> NamespacedName
    /// <summary>
    /// General corrosion index detected in a component.
    /// <see href="https://w3id.org/optimar#Corrosion"></see></summary>
    let Corrosion = Namespaced_IRI.parse _namespace_name "Corrosion" |> NamespacedName

    /// <summary>
    /// Degradation of the platform's metallic structure due to corrosion effects.
    /// <see href="https://w3id.org/optimar#CorrosionEvent"></see></summary>
    let CorrosionEvent =
        Namespaced_IRI.parse _namespace_name "CorrosionEvent" |> NamespacedName

    /// <summary>
    /// Camera used to detect and monitor corrosion in the platform structure.
    /// <see href="https://w3id.org/optimar#CorrosionCamera"></see></summary>
    let CorrosionCamera =
        Namespaced_IRI.parse _namespace_name "CorrosionCamera" |> NamespacedName

    /// <summary>
    /// Camera dedicated to visual inspection of the structural condition of the platform.
    /// <see href="https://w3id.org/optimar#StructuralCamera"></see></summary>
    let StructuralCamera =
        Namespaced_IRI.parse _namespace_name "StructuralCamera" |> NamespacedName

    /// <summary>
    /// Device that measures dynamic parameters of the platform, such as vibrations and movements.
    /// <see href="https://w3id.org/optimar#DynamicMonitor"></see></summary>
    let DynamicMonitor =
        Namespaced_IRI.parse _namespace_name "DynamicMonitor" |> NamespacedName

    /// <summary>
    /// Event that represents a detected failure in the system, must be caused by at least one failure.
    /// <see href="https://w3id.org/optimar#FailureEvent"></see></summary>
    let FailureEvent =
        Namespaced_IRI.parse _namespace_name "FailureEvent" |> NamespacedName

    /// <summary>
    /// Structural material failure caused by repeated load cycles.
    /// <see href="https://w3id.org/optimar#MaterialFatigue"></see></summary>
    let MaterialFatigue =
        Namespaced_IRI.parse _namespace_name "MaterialFatigue" |> NamespacedName

    /// <summary>
    /// Failure caused by misalignment or lack of proper adjustment between platform components.
    /// <see href="https://w3id.org/optimar#Misalignment"></see></summary>
    let Misalignment =
        Namespaced_IRI.parse _namespace_name "Misalignment" |> NamespacedName

    /// <summary>
    /// Specialist who analyzes collected data to detect patterns, failures, and optimization opportunities.
    /// <see href="https://w3id.org/optimar#DataAnalyst"></see></summary>
    let DataAnalyst =
        Namespaced_IRI.parse _namespace_name "DataAnalyst" |> NamespacedName

    /// <summary>
    /// Degree of deformation recorded in the component.
    /// <see href="https://w3id.org/optimar#Deformation"></see></summary>
    let Deformation =
        Namespaced_IRI.parse _namespace_name "Deformation" |> NamespacedName

    /// <summary>
    /// The environmental conditions that affect the offshore wind power platform, such as wind speed, temperature, etc.
    /// <see href="https://w3id.org/optimar#EnvironmentalCondition"></see></summary>
    let EnvironmentalCondition =
        Namespaced_IRI.parse _namespace_name "EnvironmentalCondition" |> NamespacedName

    /// <summary>
    /// Relates an event with the failure that caused it.
    /// <see href="https://w3id.org/optimar#causedBy"></see></summary>
    let causedBy = Namespaced_IRI.parse _namespace_name "causedBy" |> NamespacedName

    /// <summary>
    /// A floating platform that serves as a base for the wind turbine.
    /// <see href="https://w3id.org/optimar#FloatingPlatform"></see></summary>
    let FloatingPlatform =
        Namespaced_IRI.parse _namespace_name "FloatingPlatform" |> NamespacedName

    /// <summary>
    /// The floating substructure that allows the platform to be stable at sea.
    /// <see href="https://w3id.org/optimar#FloatingSubstructure"></see></summary>
    let FloatingSubstructure =
        Namespaced_IRI.parse _namespace_name "FloatingSubstructure" |> NamespacedName

    /// <summary>
    /// Strain gauge system used to measure stresses and deformations in the structure.
    /// <see href="https://w3id.org/optimar#GaugeSystem"></see></summary>
    let GaugeSystem =
        Namespaced_IRI.parse _namespace_name "GaugeSystem" |> NamespacedName

    /// <summary>
    /// The central part of the turbine where the blades are connected.
    /// <see href="https://w3id.org/optimar#Hub"></see></summary>
    let Hub = Namespaced_IRI.parse _namespace_name "Hub" |> NamespacedName
    /// <summary>
    /// Specialized system for integrated monitoring of the offshore platform.
    /// <see href="https://w3id.org/optimar#ISUMSystem"></see></summary>
    let ISUMSystem = Namespaced_IRI.parse _namespace_name "ISUMSystem" |> NamespacedName
    /// <summary>
    /// A class that represents an image that supports the measurement.
    /// <see href="https://w3id.org/optimar#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// The geographic location of the wind platform.
    /// <see href="https://w3id.org/optimar#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    /// A class that represents the maintenance of the wind platform.
    /// <see href="https://w3id.org/optimar#Maintenance"></see></summary>
    let Maintenance =
        Namespaced_IRI.parse _namespace_name "Maintenance" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/optimar#performedBy"></see>
    /// </summary>
    let performedBy =
        Namespaced_IRI.parse _namespace_name "performedBy" |> NamespacedName

    /// <summary>
    /// Person responsible for carrying out preventive and corrective maintenance on the platform.
    /// <see href="https://w3id.org/optimar#MaintenanceOperator"></see></summary>
    let MaintenanceOperator =
        Namespaced_IRI.parse _namespace_name "MaintenanceOperator" |> NamespacedName

    /// <summary>
    /// Role responsible for coordination, planning, and resource management in the wind platform.
    /// <see href="https://w3id.org/optimar#ManagementRole"></see></summary>
    let ManagementRole =
        Namespaced_IRI.parse _namespace_name "ManagementRole" |> NamespacedName

    /// <summary>
    /// Represents a measurement taken by a sensor.
    /// <see href="https://w3id.org/optimar#Measurement"></see></summary>
    let Measurement =
        Namespaced_IRI.parse _namespace_name "Measurement" |> NamespacedName

    /// <summary>
    /// A task aimed at supervising the condition of the platform through sensors and monitoring systems.
    /// <see href="https://w3id.org/optimar#MonitoringTask"></see></summary>
    let MonitoringTask =
        Namespaced_IRI.parse _namespace_name "MonitoringTask" |> NamespacedName

    /// <summary>
    /// A general task related to the operation, monitoring, or maintenance of the wind platform.
    /// <see href="https://w3id.org/optimar#Task"></see></summary>
    let Task = Namespaced_IRI.parse _namespace_name "Task" |> NamespacedName

    /// <summary>
    /// The mooring system that keeps the floating platform in place.
    /// <see href="https://w3id.org/optimar#MooringSystem"></see></summary>
    let MooringSystem =
        Namespaced_IRI.parse _namespace_name "MooringSystem" |> NamespacedName

    /// <summary>
    /// The turbine component that houses the generator and other mechanical components.
    /// <see href="https://w3id.org/optimar#Nacelle"></see></summary>
    let Nacelle = Namespaced_IRI.parse _namespace_name "Nacelle" |> NamespacedName

    /// <summary>
    /// The result of recording a phenomenon or condition, usually through a sensor or monitoring system.
    /// <see href="https://w3id.org/optimar#Observation"></see></summary>
    let Observation =
        Namespaced_IRI.parse _namespace_name "Observation" |> NamespacedName

    /// <summary>
    /// Relates an observation to the sensor that made it.
    /// <see href="https://w3id.org/optimar#madeBySensor"></see></summary>
    let madeBySensor =
        Namespaced_IRI.parse _namespace_name "madeBySensor" |> NamespacedName

    /// <summary>
    /// Entity or individual owning the offshore wind farm and responsible for its overall operation.
    /// <see href="https://w3id.org/optimar#ParkOwner"></see></summary>
    let ParkOwner = Namespaced_IRI.parse _namespace_name "ParkOwner" |> NamespacedName

    /// <summary>
    /// The system that adjusts the angle of the blades of the turbine.
    /// <see href="https://w3id.org/optimar#PitchSystem"></see></summary>
    let PitchSystem =
        Namespaced_IRI.parse _namespace_name "PitchSystem" |> NamespacedName

    /// <summary>
    /// Responsible for making adjustments on the platform, such as mechanical or hydraulic adjustments.
    /// <see href="https://w3id.org/optimar#PlatformActuator"></see></summary>
    let PlatformActuator =
        Namespaced_IRI.parse _namespace_name "PlatformActuator" |> NamespacedName

    /// <summary>
    /// Stress data measured by a sensor.
    /// <see href="https://w3id.org/optimar#StressData"></see></summary>
    let StressData = Namespaced_IRI.parse _namespace_name "StressData" |> NamespacedName

    /// <summary>
    /// Failure that compromises the structural stability of the floating platform.
    /// <see href="https://w3id.org/optimar#StructuralInstability"></see></summary>
    let StructuralInstability =
        Namespaced_IRI.parse _namespace_name "StructuralInstability" |> NamespacedName

    /// <summary>
    /// Role associated with technical activities such as operation, repair, and system supervision.
    /// <see href="https://w3id.org/optimar#TechnicalRole"></see></summary>
    let TechnicalRole =
        Namespaced_IRI.parse _namespace_name "TechnicalRole" |> NamespacedName

    /// <summary>
    /// The structure that supports the wind turbine.
    /// <see href="https://w3id.org/optimar#Tower"></see></summary>
    let Tower = Namespaced_IRI.parse _namespace_name "Tower" |> NamespacedName
    /// <summary>
    /// A wind turbine that is part of the wind platform.
    /// <see href="https://w3id.org/optimar#Turbine"></see></summary>
    let Turbine = Namespaced_IRI.parse _namespace_name "Turbine" |> NamespacedName

    /// <summary>
    /// Vibration data measured by a sensor.
    /// <see href="https://w3id.org/optimar#VibrationData"></see></summary>
    let VibrationData =
        Namespaced_IRI.parse _namespace_name "VibrationData" |> NamespacedName

    /// <summary>
    /// An offshore wind power platform that generates electricity from wind.
    /// <see href="https://w3id.org/optimar#WindPowerPlatform"></see></summary>
    let WindPowerPlatform =
        Namespaced_IRI.parse _namespace_name "WindPowerPlatform" |> NamespacedName

    /// <summary>
    /// Indicas that an actor makes adjustments on a component or pitch system.
    /// <see href="https://w3id.org/optimar#adjusts"></see></summary>
    let adjusts = Namespaced_IRI.parse _namespace_name "adjusts" |> NamespacedName
    /// <summary>
    /// Relates an actor to the data or failures that it studies or interprets.
    /// <see href="https://w3id.org/optimar#analyzes"></see></summary>
    let analyzes = Namespaced_IRI.parse _namespace_name "analyzes" |> NamespacedName

    /// <summary>
    /// Indicates that a component is connected to another.
    /// <see href="https://w3id.org/optimar#connectedTo"></see></summary>
    let connectedTo =
        Namespaced_IRI.parse _namespace_name "connectedTo" |> NamespacedName

    /// <summary>
    /// Level of dark corrosion detected on the mmaterial surface.
    /// <see href="https://w3id.org/optimar#darkCorrosion"></see></summary>
    let darkCorrosion =
        Namespaced_IRI.parse _namespace_name "darkCorrosion" |> NamespacedName

    /// <summary>
    /// Associated temporal mark to the measurement.
    /// <see href="https://w3id.org/optimar#dateTime"></see></summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName
    /// <summary>
    /// Relates an event to the sensor that detected it.
    /// <see href="https://w3id.org/optimar#detectedBy"></see></summary>
    let detectedBy = Namespaced_IRI.parse _namespace_name "detectedBy" |> NamespacedName

    /// <summary>
    /// Relates a sensor with the detected corrosion measurement.
    /// <see href="https://w3id.org/optimar#detectsCorrosion"></see></summary>
    let detectsCorrosion =
        Namespaced_IRI.parse _namespace_name "detectsCorrosion" |> NamespacedName

    /// <summary>
    /// Diameter of the component measured in QUDT units.
    /// <see href="https://w3id.org/optimar#diameter"></see></summary>
    let diameter = Namespaced_IRI.parse _namespace_name "diameter" |> NamespacedName

    /// <summary>
    /// Displacement or position change recorded in the component.
    /// <see href="https://w3id.org/optimar#displacement"></see></summary>
    let displacement =
        Namespaced_IRI.parse _namespace_name "displacement" |> NamespacedName

    /// <summary>
    /// Describe the external shape or geometric of the component.
    /// <see href="https://w3id.org/optimar#externalShape"></see></summary>
    let externalShape =
        Namespaced_IRI.parse _namespace_name "externalShape" |> NamespacedName

    /// <summary>
    /// Relationship between a failure event and the observation made by a sensor.
    /// <see href="https://w3id.org/optimar#failureObservation"></see></summary>
    let failureObservation =
        Namespaced_IRI.parse _namespace_name "failureObservation" |> NamespacedName

    /// <summary>
    /// Rated generation capacity of the turbine.
    /// <see href="https://w3id.org/optimar#hasCapacity"></see></summary>
    let hasCapacity =
        Namespaced_IRI.parse _namespace_name "hasCapacity" |> NamespacedName

    /// <summary>
    /// Indicates that a failure is caused by a specific environmental condition.
    /// <see href="https://w3id.org/optimar#hasFailureCause"></see></summary>
    let hasFailureCause =
        Namespaced_IRI.parse _namespace_name "hasFailureCause" |> NamespacedName

    /// <summary>
    /// Indicas the role that an actor performs within the system.
    /// <see href="https://w3id.org/optimar#hasRole"></see></summary>
    let hasRole = Namespaced_IRI.parse _namespace_name "hasRole" |> NamespacedName
    /// <summary>
    /// Height of the component expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// Indicates that a component contains or houses physically another in its structure.
    /// <see href="https://w3id.org/optimar#houses"></see></summary>
    let houses = Namespaced_IRI.parse _namespace_name "houses" |> NamespacedName
    /// <summary>
    /// Access URL of the generated or stored image.
    /// <see href="https://w3id.org/optimar#imageURL"></see></summary>
    let imageURL = Namespaced_IRI.parse _namespace_name "imageURL" |> NamespacedName

    /// <summary>
    /// Indicates that a component is structurally or functionally supported by another.
    /// <see href="https://w3id.org/optimar#isSupportedBy"></see></summary>
    let isSupportedBy =
        Namespaced_IRI.parse _namespace_name "isSupportedBy" |> NamespacedName

    /// <summary>
    /// Length of a component, expressed as a QUDT quantity value
    /// <see href="https://w3id.org/optimar#length"></see></summary>
    let length = Namespaced_IRI.parse _namespace_name "length" |> NamespacedName

    /// <summary>
    /// Level of light corrosion detected on the material surface.
    /// <see href="https://w3id.org/optimar#lightCorrosion"></see></summary>
    let lightCorrosion =
        Namespaced_IRI.parse _namespace_name "lightCorrosion" |> NamespacedName

    /// <summary>
    /// Indicates the location where the wind power platform is located.
    /// <see href="https://w3id.org/optimar#locatedIn"></see></summary>
    let locatedIn = Namespaced_IRI.parse _namespace_name "locatedIn" |> NamespacedName
    /// <summary>
    /// Indicates that an actor is responsible for managing a wind power platform or its mooring system.
    /// <see href="https://w3id.org/optimar#manages"></see></summary>
    let manages = Namespaced_IRI.parse _namespace_name "manages" |> NamespacedName
    /// <summary>
    /// Mass of the component expressed as a QUDT quantity value
    /// <see href="https://w3id.org/optimar#mass"></see></summary>
    let mass = Namespaced_IRI.parse _namespace_name "mass" |> NamespacedName
    /// <summary>
    /// Material of manufacturing of the component (e.g. steel, composite, fiberglass, etc.).
    /// <see href="https://w3id.org/optimar#material"></see></summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName

    /// <summary>
    /// Accumulated material fatigue degree.
    /// <see href="https://w3id.org/optimar#materialFatigue"></see></summary>
    let materialFatigue =
        Namespaced_IRI.parse _namespace_name "materialFatigue" |> NamespacedName

    /// <summary>
    /// Degree of material wear in a component.
    /// <see href="https://w3id.org/optimar#materialWear"></see></summary>
    let materialWear =
        Namespaced_IRI.parse _namespace_name "materialWear" |> NamespacedName

    /// <summary>
    /// Indicates that a sensor measures the stress exerted on a component.
    /// <see href="https://w3id.org/optimar#measuresStress"></see></summary>
    let measuresStress =
        Namespaced_IRI.parse _namespace_name "measuresStress" |> NamespacedName

    /// <summary>
    /// Indicates that a sensor collects vibration data from a component.
    /// <see href="https://w3id.org/optimar#measuresVibration"></see></summary>
    let measuresVibration =
        Namespaced_IRI.parse _namespace_name "measuresVibration" |> NamespacedName

    /// <summary>
    /// Relates a sensor with the measurement of wind speed or direction.
    /// <see href="https://w3id.org/optimar#measuresWind"></see></summary>
    let measuresWind =
        Namespaced_IRI.parse _namespace_name "measuresWind" |> NamespacedName

    /// <summary>
    /// Measure of the misalignment detected in a component.
    /// <see href="https://w3id.org/optimar#misalignment"></see></summary>
    let misalignment =
        Namespaced_IRI.parse _namespace_name "misalignment" |> NamespacedName

    /// <summary>
    /// Relates an actor to the components or sensors they monitor.
    /// <see href="https://w3id.org/optimar#monitors"></see></summary>
    let monitors = Namespaced_IRI.parse _namespace_name "monitors" |> NamespacedName

    /// <summary>
    /// Relates a sensor to the structural deformation it measures or monitors.
    /// <see href="https://w3id.org/optimar#monitorsDeformation"></see></summary>
    let monitorsDeformation =
        Namespaced_IRI.parse _namespace_name "monitorsDeformation" |> NamespacedName

    /// <summary>
    /// Current operational status of the turbine (e.g. operative, stopped, under maintenance, etc.).
    /// <see href="https://w3id.org/optimar#operationalStatus"></see></summary>
    let operationalStatus =
        Namespaced_IRI.parse _namespace_name "operationalStatus" |> NamespacedName

    /// <summary>
    /// Relates an actor with the maintenance that it performs.
    /// <see href="https://w3id.org/optimar#performedMaintenance"></see></summary>
    let performedMaintenance =
        Namespaced_IRI.parse _namespace_name "performedMaintenance" |> NamespacedName

    /// <summary>
    /// Relates an actor with a task that it performs as part of its role.
    /// <see href="https://w3id.org/optimar#performsTask"></see></summary>
    let performsTask =
        Namespaced_IRI.parse _namespace_name "performsTask" |> NamespacedName

    /// <summary>
    /// Pressure exerted on a component.
    /// <see href="https://w3id.org/optimar#pressure"></see></summary>
    let pressure = Namespaced_IRI.parse _namespace_name "pressure" |> NamespacedName

    /// <summary>
    /// Relates an event to the platform component that is affected.
    /// <see href="https://w3id.org/optimar#relatedToComponent"></see></summary>
    let relatedToComponent =
        Namespaced_IRI.parse _namespace_name "relatedToComponent" |> NamespacedName

    /// <summary>
    /// Angular speed of a component expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#rotationSpeed"></see></summary>
    let rotationSpeed =
        Namespaced_IRI.parse _namespace_name "rotationSpeed" |> NamespacedName

    /// <summary>
    /// Stress level recorded in a component.
    /// <see href="https://w3id.org/optimar#stress"></see></summary>
    let stress = Namespaced_IRI.parse _namespace_name "stress" |> NamespacedName
    /// <summary>
    /// Indicates that a component provides structural or functional support to another.
    /// <see href="https://w3id.org/optimar#supports"></see></summary>
    let supports = Namespaced_IRI.parse _namespace_name "supports" |> NamespacedName

    /// <summary>
    /// Temperature recorded expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#temperature"></see></summary>
    let temperature =
        Namespaced_IRI.parse _namespace_name "temperature" |> NamespacedName

    /// <summary>
    /// Thickness of the section or wall of a component measured in QUDT units.
    /// <see href="https://w3id.org/optimar#thickness"></see></summary>
    let thickness = Namespaced_IRI.parse _namespace_name "thickness" |> NamespacedName

    /// <summary>
    /// Indicates that a component transmits mechanical movement to another.
    /// <see href="https://w3id.org/optimar#transmitsMovementTo"></see></summary>
    let transmitsMovementTo =
        Namespaced_IRI.parse _namespace_name "transmitsMovementTo" |> NamespacedName

    /// <summary>
    /// Measurement unit of the recorded value (e.g. m/s, rpm, °C, etc.).
    /// <see href="https://w3id.org/optimar#unit"></see></summary>
    let unit = Namespaced_IRI.parse _namespace_name "unit" |> NamespacedName
    /// <summary>
    /// Numeric value of the measurement taken by a sensor.
    /// <see href="https://w3id.org/optimar#value"></see></summary>
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName
    /// <summary>
    /// Level of vibrations recorded in a component or system.
    /// <see href="https://w3id.org/optimar#vibrations"></see></summary>
    let vibrations = Namespaced_IRI.parse _namespace_name "vibrations" |> NamespacedName
    /// <summary>
    /// Width of the component expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName

    /// <summary>
    /// Direction from which the wind blows expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#windDirection"></see></summary>
    let windDirection =
        Namespaced_IRI.parse _namespace_name "windDirection" |> NamespacedName

    /// <summary>
    /// Wind speed expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#windSpeed"></see></summary>
    let windSpeed = Namespaced_IRI.parse _namespace_name "windSpeed" |> NamespacedName
