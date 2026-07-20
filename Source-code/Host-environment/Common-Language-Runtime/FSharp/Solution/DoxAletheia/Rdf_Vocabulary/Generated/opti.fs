namespace https.w3id.org.optimar.hash

open DoxAletheia

module opti =
    let _namespace_name = "https://w3id.org/optimar#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An event that occurs in the offshore wind power platform, such as a failure detection.
    /// <see href="https://w3id.org/optimar#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// A class for representing the measurement data collected by sensors or other systems.
    /// <see href="https://w3id.org/optimar#Data"></see></summary>
    let Data = _prefix "Data"
    /// <summary>
    /// An actor that interacts or manages the offshore wind power platform.
    /// <see href="https://w3id.org/optimar#Actor"></see></summary>
    let Actor = _prefix "Actor"
    /// <summary>
    /// Role focused on data analysis and generation of useful information for decision-making.
    /// <see href="https://w3id.org/optimar#AnalyticalRole"></see></summary>
    let AnalyticalRole = _prefix "AnalyticalRole"
    /// <summary>
    /// The roles of the actors that manage, operate or maintain the offshore wind power platform.
    /// <see href="https://w3id.org/optimar#Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Sensor that measures wind speed and direction in the wind farm.
    /// <see href="https://w3id.org/optimar#Anemometer"></see></summary>
    let Anemometer = _prefix "Anemometer"
    /// <summary>
    /// A device that measures or monitors parameters of the wind platform, such as wind, corrosion, vibrations, etc.
    /// <see href="https://w3id.org/optimar#Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// The base that supports the floating platform.
    /// <see href="https://w3id.org/optimar#Base"></see></summary>
    let Base = _prefix "Base"
    /// <summary>
    /// The structural components that make up the basic infrastructure of the wind platform.
    /// <see href="https://w3id.org/optimar#StructuralComponent"></see></summary>
    let StructuralComponent = _prefix "StructuralComponent"
    /// <summary>
    /// The blades of the turbine that capture the wind energy.
    /// <see href="https://w3id.org/optimar#Blade"></see></summary>
    let Blade = _prefix "Blade"
    /// <summary>
    /// The turbine components that generate energy from the wind.
    /// <see href="https://w3id.org/optimar#TurbineComponent"></see></summary>
    let TurbineComponent = _prefix "TurbineComponent"
    /// <summary>
    /// Responsible for managing and securing cloud services that process data from the platform.
    /// <see href="https://w3id.org/optimar#CloudAdministrator"></see></summary>
    let CloudAdministrator = _prefix "CloudAdministrator"
    /// <summary>
    /// An component of an offshore wind power platform, such as blades, towers, pitch system, etc.
    /// <see href="https://w3id.org/optimar#Component"></see></summary>
    let Component = _prefix "Component"
    /// <summary>
    /// Failure caused by the fracture or breakage of an offshore wind turbine component.
    /// <see href="https://w3id.org/optimar#ComponentBreakage"></see></summary>
    let ComponentBreakage = _prefix "ComponentBreakage"
    /// <summary>
    /// A class that represents identified failures in the wind platform.
    /// <see href="https://w3id.org/optimar#Failure"></see></summary>
    let Failure = _prefix "Failure"
    /// <summary>
    /// General corrosion index detected in a component.
    /// <see href="https://w3id.org/optimar#Corrosion"></see></summary>
    let Corrosion = _prefix "Corrosion"
    /// <summary>
    /// Degradation of the platform's metallic structure due to corrosion effects.
    /// <see href="https://w3id.org/optimar#CorrosionEvent"></see></summary>
    let CorrosionEvent = _prefix "CorrosionEvent"
    /// <summary>
    /// Camera used to detect and monitor corrosion in the platform structure.
    /// <see href="https://w3id.org/optimar#CorrosionCamera"></see></summary>
    let CorrosionCamera = _prefix "CorrosionCamera"
    /// <summary>
    /// Camera dedicated to visual inspection of the structural condition of the platform.
    /// <see href="https://w3id.org/optimar#StructuralCamera"></see></summary>
    let StructuralCamera = _prefix "StructuralCamera"
    /// <summary>
    /// Device that measures dynamic parameters of the platform, such as vibrations and movements.
    /// <see href="https://w3id.org/optimar#DynamicMonitor"></see></summary>
    let DynamicMonitor = _prefix "DynamicMonitor"
    /// <summary>
    /// Event that represents a detected failure in the system, must be caused by at least one failure.
    /// <see href="https://w3id.org/optimar#FailureEvent"></see></summary>
    let FailureEvent = _prefix "FailureEvent"
    /// <summary>
    /// Structural material failure caused by repeated load cycles.
    /// <see href="https://w3id.org/optimar#MaterialFatigue"></see></summary>
    let MaterialFatigue = _prefix "MaterialFatigue"
    /// <summary>
    /// Failure caused by misalignment or lack of proper adjustment between platform components.
    /// <see href="https://w3id.org/optimar#Misalignment"></see></summary>
    let Misalignment = _prefix "Misalignment"
    /// <summary>
    /// Specialist who analyzes collected data to detect patterns, failures, and optimization opportunities.
    /// <see href="https://w3id.org/optimar#DataAnalyst"></see></summary>
    let DataAnalyst = _prefix "DataAnalyst"
    /// <summary>
    /// Degree of deformation recorded in the component.
    /// <see href="https://w3id.org/optimar#Deformation"></see></summary>
    let Deformation = _prefix "Deformation"
    /// <summary>
    /// The environmental conditions that affect the offshore wind power platform, such as wind speed, temperature, etc.
    /// <see href="https://w3id.org/optimar#EnvironmentalCondition"></see></summary>
    let EnvironmentalCondition = _prefix "EnvironmentalCondition"
    /// <summary>
    /// Relates an event with the failure that caused it.
    /// <see href="https://w3id.org/optimar#causedBy"></see></summary>
    let causedBy = _prefix "causedBy"
    /// <summary>
    /// A floating platform that serves as a base for the wind turbine.
    /// <see href="https://w3id.org/optimar#FloatingPlatform"></see></summary>
    let FloatingPlatform = _prefix "FloatingPlatform"
    /// <summary>
    /// The floating substructure that allows the platform to be stable at sea.
    /// <see href="https://w3id.org/optimar#FloatingSubstructure"></see></summary>
    let FloatingSubstructure = _prefix "FloatingSubstructure"
    /// <summary>
    /// Strain gauge system used to measure stresses and deformations in the structure.
    /// <see href="https://w3id.org/optimar#GaugeSystem"></see></summary>
    let GaugeSystem = _prefix "GaugeSystem"
    /// <summary>
    /// The central part of the turbine where the blades are connected.
    /// <see href="https://w3id.org/optimar#Hub"></see></summary>
    let Hub = _prefix "Hub"
    /// <summary>
    /// Specialized system for integrated monitoring of the offshore platform.
    /// <see href="https://w3id.org/optimar#ISUMSystem"></see></summary>
    let ISUMSystem = _prefix "ISUMSystem"
    /// <summary>
    /// A class that represents an image that supports the measurement.
    /// <see href="https://w3id.org/optimar#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// The geographic location of the wind platform.
    /// <see href="https://w3id.org/optimar#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// A class that represents the maintenance of the wind platform.
    /// <see href="https://w3id.org/optimar#Maintenance"></see></summary>
    let Maintenance = _prefix "Maintenance"
    /// <summary>
    ///   <see href="https://w3id.org/optimar#performedBy"></see>
    /// </summary>
    let performedBy = _prefix "performedBy"
    /// <summary>
    /// Person responsible for carrying out preventive and corrective maintenance on the platform.
    /// <see href="https://w3id.org/optimar#MaintenanceOperator"></see></summary>
    let MaintenanceOperator = _prefix "MaintenanceOperator"
    /// <summary>
    /// Role responsible for coordination, planning, and resource management in the wind platform.
    /// <see href="https://w3id.org/optimar#ManagementRole"></see></summary>
    let ManagementRole = _prefix "ManagementRole"
    /// <summary>
    /// Represents a measurement taken by a sensor.
    /// <see href="https://w3id.org/optimar#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// A task aimed at supervising the condition of the platform through sensors and monitoring systems.
    /// <see href="https://w3id.org/optimar#MonitoringTask"></see></summary>
    let MonitoringTask = _prefix "MonitoringTask"
    /// <summary>
    /// A general task related to the operation, monitoring, or maintenance of the wind platform.
    /// <see href="https://w3id.org/optimar#Task"></see></summary>
    let Task = _prefix "Task"
    /// <summary>
    /// The mooring system that keeps the floating platform in place.
    /// <see href="https://w3id.org/optimar#MooringSystem"></see></summary>
    let MooringSystem = _prefix "MooringSystem"
    /// <summary>
    /// The turbine component that houses the generator and other mechanical components.
    /// <see href="https://w3id.org/optimar#Nacelle"></see></summary>
    let Nacelle = _prefix "Nacelle"
    /// <summary>
    /// The result of recording a phenomenon or condition, usually through a sensor or monitoring system.
    /// <see href="https://w3id.org/optimar#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// Relates an observation to the sensor that made it.
    /// <see href="https://w3id.org/optimar#madeBySensor"></see></summary>
    let madeBySensor = _prefix "madeBySensor"
    /// <summary>
    /// Entity or individual owning the offshore wind farm and responsible for its overall operation.
    /// <see href="https://w3id.org/optimar#ParkOwner"></see></summary>
    let ParkOwner = _prefix "ParkOwner"
    /// <summary>
    /// The system that adjusts the angle of the blades of the turbine.
    /// <see href="https://w3id.org/optimar#PitchSystem"></see></summary>
    let PitchSystem = _prefix "PitchSystem"
    /// <summary>
    /// Responsible for making adjustments on the platform, such as mechanical or hydraulic adjustments.
    /// <see href="https://w3id.org/optimar#PlatformActuator"></see></summary>
    let PlatformActuator = _prefix "PlatformActuator"
    /// <summary>
    /// Stress data measured by a sensor.
    /// <see href="https://w3id.org/optimar#StressData"></see></summary>
    let StressData = _prefix "StressData"
    /// <summary>
    /// Failure that compromises the structural stability of the floating platform.
    /// <see href="https://w3id.org/optimar#StructuralInstability"></see></summary>
    let StructuralInstability = _prefix "StructuralInstability"
    /// <summary>
    /// Role associated with technical activities such as operation, repair, and system supervision.
    /// <see href="https://w3id.org/optimar#TechnicalRole"></see></summary>
    let TechnicalRole = _prefix "TechnicalRole"
    /// <summary>
    /// The structure that supports the wind turbine.
    /// <see href="https://w3id.org/optimar#Tower"></see></summary>
    let Tower = _prefix "Tower"
    /// <summary>
    /// A wind turbine that is part of the wind platform.
    /// <see href="https://w3id.org/optimar#Turbine"></see></summary>
    let Turbine = _prefix "Turbine"
    /// <summary>
    /// Vibration data measured by a sensor.
    /// <see href="https://w3id.org/optimar#VibrationData"></see></summary>
    let VibrationData = _prefix "VibrationData"
    /// <summary>
    /// An offshore wind power platform that generates electricity from wind.
    /// <see href="https://w3id.org/optimar#WindPowerPlatform"></see></summary>
    let WindPowerPlatform = _prefix "WindPowerPlatform"
    /// <summary>
    /// Indicas that an actor makes adjustments on a component or pitch system.
    /// <see href="https://w3id.org/optimar#adjusts"></see></summary>
    let adjusts = _prefix "adjusts"
    /// <summary>
    /// Relates an actor to the data or failures that it studies or interprets.
    /// <see href="https://w3id.org/optimar#analyzes"></see></summary>
    let analyzes = _prefix "analyzes"
    /// <summary>
    /// Indicates that a component is connected to another.
    /// <see href="https://w3id.org/optimar#connectedTo"></see></summary>
    let connectedTo = _prefix "connectedTo"
    /// <summary>
    /// Level of dark corrosion detected on the mmaterial surface.
    /// <see href="https://w3id.org/optimar#darkCorrosion"></see></summary>
    let darkCorrosion = _prefix "darkCorrosion"
    /// <summary>
    /// Associated temporal mark to the measurement.
    /// <see href="https://w3id.org/optimar#dateTime"></see></summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    /// Relates an event to the sensor that detected it.
    /// <see href="https://w3id.org/optimar#detectedBy"></see></summary>
    let detectedBy = _prefix "detectedBy"
    /// <summary>
    /// Relates a sensor with the detected corrosion measurement.
    /// <see href="https://w3id.org/optimar#detectsCorrosion"></see></summary>
    let detectsCorrosion = _prefix "detectsCorrosion"
    /// <summary>
    /// Diameter of the component measured in QUDT units.
    /// <see href="https://w3id.org/optimar#diameter"></see></summary>
    let diameter = _prefix "diameter"
    /// <summary>
    /// Displacement or position change recorded in the component.
    /// <see href="https://w3id.org/optimar#displacement"></see></summary>
    let displacement = _prefix "displacement"
    /// <summary>
    /// Describe the external shape or geometric of the component.
    /// <see href="https://w3id.org/optimar#externalShape"></see></summary>
    let externalShape = _prefix "externalShape"
    /// <summary>
    /// Relationship between a failure event and the observation made by a sensor.
    /// <see href="https://w3id.org/optimar#failureObservation"></see></summary>
    let failureObservation = _prefix "failureObservation"
    /// <summary>
    /// Rated generation capacity of the turbine.
    /// <see href="https://w3id.org/optimar#hasCapacity"></see></summary>
    let hasCapacity = _prefix "hasCapacity"
    /// <summary>
    /// Indicates that a failure is caused by a specific environmental condition.
    /// <see href="https://w3id.org/optimar#hasFailureCause"></see></summary>
    let hasFailureCause = _prefix "hasFailureCause"
    /// <summary>
    /// Indicas the role that an actor performs within the system.
    /// <see href="https://w3id.org/optimar#hasRole"></see></summary>
    let hasRole = _prefix "hasRole"
    /// <summary>
    /// Height of the component expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// Indicates that a component contains or houses physically another in its structure.
    /// <see href="https://w3id.org/optimar#houses"></see></summary>
    let houses = _prefix "houses"
    /// <summary>
    /// Access URL of the generated or stored image.
    /// <see href="https://w3id.org/optimar#imageURL"></see></summary>
    let imageURL = _prefix "imageURL"
    /// <summary>
    /// Indicates that a component is structurally or functionally supported by another.
    /// <see href="https://w3id.org/optimar#isSupportedBy"></see></summary>
    let isSupportedBy = _prefix "isSupportedBy"
    /// <summary>
    /// Length of a component, expressed as a QUDT quantity value
    /// <see href="https://w3id.org/optimar#length"></see></summary>
    let length = _prefix "length"
    /// <summary>
    /// Level of light corrosion detected on the material surface.
    /// <see href="https://w3id.org/optimar#lightCorrosion"></see></summary>
    let lightCorrosion = _prefix "lightCorrosion"
    /// <summary>
    /// Indicates the location where the wind power platform is located.
    /// <see href="https://w3id.org/optimar#locatedIn"></see></summary>
    let locatedIn = _prefix "locatedIn"
    /// <summary>
    /// Indicates that an actor is responsible for managing a wind power platform or its mooring system.
    /// <see href="https://w3id.org/optimar#manages"></see></summary>
    let manages = _prefix "manages"
    /// <summary>
    /// Mass of the component expressed as a QUDT quantity value
    /// <see href="https://w3id.org/optimar#mass"></see></summary>
    let mass = _prefix "mass"
    /// <summary>
    /// Material of manufacturing of the component (e.g. steel, composite, fiberglass, etc.).
    /// <see href="https://w3id.org/optimar#material"></see></summary>
    let material = _prefix "material"
    /// <summary>
    /// Accumulated material fatigue degree.
    /// <see href="https://w3id.org/optimar#materialFatigue"></see></summary>
    let materialFatigue = _prefix "materialFatigue"
    /// <summary>
    /// Degree of material wear in a component.
    /// <see href="https://w3id.org/optimar#materialWear"></see></summary>
    let materialWear = _prefix "materialWear"
    /// <summary>
    /// Indicates that a sensor measures the stress exerted on a component.
    /// <see href="https://w3id.org/optimar#measuresStress"></see></summary>
    let measuresStress = _prefix "measuresStress"
    /// <summary>
    /// Indicates that a sensor collects vibration data from a component.
    /// <see href="https://w3id.org/optimar#measuresVibration"></see></summary>
    let measuresVibration = _prefix "measuresVibration"
    /// <summary>
    /// Relates a sensor with the measurement of wind speed or direction.
    /// <see href="https://w3id.org/optimar#measuresWind"></see></summary>
    let measuresWind = _prefix "measuresWind"
    /// <summary>
    /// Measure of the misalignment detected in a component.
    /// <see href="https://w3id.org/optimar#misalignment"></see></summary>
    let misalignment = _prefix "misalignment"
    /// <summary>
    /// Relates an actor to the components or sensors they monitor.
    /// <see href="https://w3id.org/optimar#monitors"></see></summary>
    let monitors = _prefix "monitors"
    /// <summary>
    /// Relates a sensor to the structural deformation it measures or monitors.
    /// <see href="https://w3id.org/optimar#monitorsDeformation"></see></summary>
    let monitorsDeformation = _prefix "monitorsDeformation"
    /// <summary>
    /// Current operational status of the turbine (e.g. operative, stopped, under maintenance, etc.).
    /// <see href="https://w3id.org/optimar#operationalStatus"></see></summary>
    let operationalStatus = _prefix "operationalStatus"
    /// <summary>
    /// Relates an actor with the maintenance that it performs.
    /// <see href="https://w3id.org/optimar#performedMaintenance"></see></summary>
    let performedMaintenance = _prefix "performedMaintenance"
    /// <summary>
    /// Relates an actor with a task that it performs as part of its role.
    /// <see href="https://w3id.org/optimar#performsTask"></see></summary>
    let performsTask = _prefix "performsTask"
    /// <summary>
    /// Pressure exerted on a component.
    /// <see href="https://w3id.org/optimar#pressure"></see></summary>
    let pressure = _prefix "pressure"
    /// <summary>
    /// Relates an event to the platform component that is affected.
    /// <see href="https://w3id.org/optimar#relatedToComponent"></see></summary>
    let relatedToComponent = _prefix "relatedToComponent"
    /// <summary>
    /// Angular speed of a component expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#rotationSpeed"></see></summary>
    let rotationSpeed = _prefix "rotationSpeed"
    /// <summary>
    /// Stress level recorded in a component.
    /// <see href="https://w3id.org/optimar#stress"></see></summary>
    let stress = _prefix "stress"
    /// <summary>
    /// Indicates that a component provides structural or functional support to another.
    /// <see href="https://w3id.org/optimar#supports"></see></summary>
    let supports = _prefix "supports"
    /// <summary>
    /// Temperature recorded expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#temperature"></see></summary>
    let temperature = _prefix "temperature"
    /// <summary>
    /// Thickness of the section or wall of a component measured in QUDT units.
    /// <see href="https://w3id.org/optimar#thickness"></see></summary>
    let thickness = _prefix "thickness"
    /// <summary>
    /// Indicates that a component transmits mechanical movement to another.
    /// <see href="https://w3id.org/optimar#transmitsMovementTo"></see></summary>
    let transmitsMovementTo = _prefix "transmitsMovementTo"
    /// <summary>
    /// Measurement unit of the recorded value (e.g. m/s, rpm, °C, etc.).
    /// <see href="https://w3id.org/optimar#unit"></see></summary>
    let unit = _prefix "unit"
    /// <summary>
    /// Numeric value of the measurement taken by a sensor.
    /// <see href="https://w3id.org/optimar#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Level of vibrations recorded in a component or system.
    /// <see href="https://w3id.org/optimar#vibrations"></see></summary>
    let vibrations = _prefix "vibrations"
    /// <summary>
    /// Width of the component expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// Direction from which the wind blows expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#windDirection"></see></summary>
    let windDirection = _prefix "windDirection"
    /// <summary>
    /// Wind speed expressed as a QUDT quantity value.
    /// <see href="https://w3id.org/optimar#windSpeed"></see></summary>
    let windSpeed = _prefix "windSpeed"
