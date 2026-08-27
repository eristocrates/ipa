namespace https.www.w3.org.ns.ssn.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module w3c_ssn =
    let _namespace_iri = Namespace_Iri w3c_ssn |> NamespaceIRI
    /// <summary>
    ///   <para>w3c-ssn:Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The closeness of agreement between the value of an observation and the true value of the observed quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Accuracy">https://www.w3.org/ns/ssn/Accuracy</seealso>
    let Accuracy = Prefixed_Name(w3c_ssn, "Accuracy") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:BatteryLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Total useful life of a battery."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery Lifetime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/BatteryLifetime">https://www.w3.org/ns/ssn/BatteryLifetime</seealso>
    let BatteryLifetime = Prefixed_Name(w3c_ssn, "BatteryLifetime") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to specify ranges for qualities that act as conditions on a system/sensor's operation.  For example, wind speed of 10-60m/s is expressed as a condition linking a quality, wind speed, a unit of measurement, metres per second, and a set of values, 10-60, and may be used as the condition on a MeasurementProperty, for example, to state that a sensor has a particular accuracy in that condition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Condition">https://www.w3.org/ns/ssn/Condition</seealso>
    let Condition = Prefixed_Name(w3c_ssn, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ongoing Process of Entities (for the purposes of this ontology, mainly sensors) deployed for a particular purpose.  For example, a particular Sensor deployed on a Platform, or a whole network of Sensors deployed for an observation campaign.  The deployment may have sub processes, such as installation, maintenance, addition, and decomissioning and removal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Deployment">https://www.w3.org/ns/ssn/Deployment</seealso>
    let Deployment = Prefixed_Name(w3c_ssn, "Deployment") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:DeploymentRelatedProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Place to group all the various Processes related to Deployment.  For example, as well as Deplyment, installation, maintenance, deployment of further sensors and the like would all be classified under DeploymentRelatedProcess."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deployment-related Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/DeploymentRelatedProcess">https://www.w3.org/ns/ssn/DeploymentRelatedProcess</seealso>
    let DeploymentRelatedProcess =
        Prefixed_Name(w3c_ssn, "DeploymentRelatedProcess") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:DetectionLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An observed value for which the probability of falsely claiming the absence of a component in a material is Î², given a probability Î± of falsely claiming its presence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"detection limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/DetectionLimit">https://www.w3.org/ns/ssn/DetectionLimit</seealso>
    let DetectionLimit = Prefixed_Name(w3c_ssn, "DetectionLimit") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device is a physical piece of technology - a system in a box. Devices may of course be built of smaller devices and software components (i.e. systems have components)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Device">https://www.w3.org/ns/ssn/Device</seealso>
    let Device = Prefixed_Name(w3c_ssn, "Device") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Drift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A, continuous or incremental, change in the reported values of observations over time for an unchanging quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drift"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Drift">https://www.w3.org/ns/ssn/Drift</seealso>
    let Drift = Prefixed_Name(w3c_ssn, "Drift") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A feature is an abstraction of real world phenomena (thing, person, event, etc)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Feature of Interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/FeatureOfInterest">https://www.w3.org/ns/ssn/FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(w3c_ssn, "FeatureOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:MaintenanceSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Schedule of maintenance for a system/sensor in the specified conditions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maintenance Schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/MaintenanceSchedule">https://www.w3.org/ns/ssn/MaintenanceSchedule</seealso>
    let MaintenanceSchedule =
        Prefixed_Name(w3c_ssn, "MaintenanceSchedule") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:MeasurementCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collects together measurement properties (accuracy, range, precision, etc) and the environmental conditions in which those properties hold, representing a specification of a sensor's capability in those conditions.
    ///
    /// The conditions specified here are those that affect the measurement properties, while those in OperatingRange represent the sensor's standard operating conditions, including conditions that don't affect the observations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/MeasurementCapability">https://www.w3.org/ns/ssn/MeasurementCapability</seealso>
    let MeasurementCapability =
        Prefixed_Name(w3c_ssn, "MeasurementCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:MeasurementFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The smallest possible time between one observation and the next."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementFrequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/MeasurementFrequency">https://www.w3.org/ns/ssn/MeasurementFrequency</seealso>
    let MeasurementFrequency =
        Prefixed_Name(w3c_ssn, "MeasurementFrequency") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:MeasurementLatency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The time between a request for an observation and the sensor producing a result (not including network latency to retrieve the result, just time from request to measurement.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MeasurementLatency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/MeasurementLatency">https://www.w3.org/ns/ssn/MeasurementLatency</seealso>
    let MeasurementLatency =
        Prefixed_Name(w3c_ssn, "MeasurementLatency") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:MeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifiable and observable characteristic of a sensor's observations or ability to make observations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/MeasurementProperty">https://www.w3.org/ns/ssn/MeasurementProperty</seealso>
    let MeasurementProperty =
        Prefixed_Name(w3c_ssn, "MeasurementProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:MeasurementRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of values that the sensor can return as the result of an observation under the defined conditions with the defined measurement properties.  (If no conditions are specified or the conditions do not specify a range for the observed qualities, the measurement range is to be taken as the condition for the observed qualities.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/MeasurementRange">https://www.w3.org/ns/ssn/MeasurementRange</seealso>
    let MeasurementRange = Prefixed_Name(w3c_ssn, "MeasurementRange") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Observation is a Situation in which a Sensing method has been used to estimate or calculate a value of a Property of a FeatureOfInterest.  Links to Sensing and Sensor describe what made the Observation and how; links to Property and Feature detail what was sensed; the result is the output of a Sensor; other metadata details times etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Observation">https://www.w3.org/ns/ssn/Observation</seealso>
    let Observation = Prefixed_Name(w3c_ssn, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:ObservationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The value of the result of an Observation.  An Observation has a result which is the output of some sensor, the result is an information object that encodes some value for a Feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Observation Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/ObservationValue">https://www.w3.org/ns/ssn/ObservationValue</seealso>
    let ObservationValue = Prefixed_Name(w3c_ssn, "ObservationValue") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:OperatingPowerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Power range in which system/sensor is expected to operate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Power Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/OperatingPowerRange">https://www.w3.org/ns/ssn/OperatingPowerRange</seealso>
    let OperatingPowerRange =
        Prefixed_Name(w3c_ssn, "OperatingPowerRange") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:OperatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifiable characteristic of the environmental and other conditions in which the sensor is intended to operate.  May include power ranges, power sources, standard configurations, attachments and the like."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/OperatingProperty">https://www.w3.org/ns/ssn/OperatingProperty</seealso>
    let OperatingProperty = Prefixed_Name(w3c_ssn, "OperatingProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:OperatingRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The environmental conditions and characteristics of a system/sensor's normal operating environment.  Can be used to specify for example the standard environmental conditions in which the sensor is expected to operate (a Condition with no OperatingProperty), or how the environmental and other operating properties relate: i.e., that the maintenance schedule or power requirements differ according to the conditions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/OperatingRange">https://www.w3.org/ns/ssn/OperatingRange</seealso>
    let OperatingRange = Prefixed_Name(w3c_ssn, "OperatingRange") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity to which other Entities can be attached - particuarly Sensors and other Platforms.  For example, a post might act as the Platform, a bouy might act as a Platform, or a fish might act as a Platform for an attached sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Platform">https://www.w3.org/ns/ssn/Platform</seealso>
    let Platform = Prefixed_Name(w3c_ssn, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The closeness of agreement between replicate observations on an unchanged or similar quality value: i.e., a measure of a sensor's ability to consitently reproduce an observation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Precision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Precision">https://www.w3.org/ns/ssn/Precision</seealso>
    let Precision = Prefixed_Name(w3c_ssn, "Precision") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An observable Quality of an Event or Object.  That is, not a quality of an abstract entity as is also allowed by DUL's Quality, but rather an aspect of an entity that is intrinsic to and cannot exist without the entity and is observable by a sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Property">https://www.w3.org/ns/ssn/Property</seealso>
    let Property = Prefixed_Name(w3c_ssn, "Property") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The smallest difference in the value of a quality being observed that would result in perceptably different values of observation results."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Resolution">https://www.w3.org/ns/ssn/Resolution</seealso>
    let Resolution = Prefixed_Name(w3c_ssn, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:ResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The time between a (step) change inthe value of an observed quality and a sensor (possibly with specified error) 'settling' on an observed value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Response time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/ResponseTime">https://www.w3.org/ns/ssn/ResponseTime</seealso>
    let ResponseTime = Prefixed_Name(w3c_ssn, "ResponseTime") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Selectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Selectivity is a property of a sensor whereby it provides observed values for one or more qualities such that the values of each quality are independent of other qualities in the phenomenon, body, or substance being investigated."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Selectivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Selectivity">https://www.w3.org/ns/ssn/Selectivity</seealso>
    let Selectivity = Prefixed_Name(w3c_ssn, "Selectivity") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Sensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The description of a process (i.e. describes the temporal and dataflow dependencies and relationships amongst its parts) that results in the estimation, or calculation, of the value of a phenomenon."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Sensing">https://www.w3.org/ns/ssn/Sensing</seealso>
    let Sensing = Prefixed_Name(w3c_ssn, "Sensing") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:SensingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensing device is a device that implements sensing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensing Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/SensingDevice">https://www.w3.org/ns/ssn/SensingDevice</seealso>
    let SensingDevice = Prefixed_Name(w3c_ssn, "SensingDevice") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Sensitivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensitivity is the quotient of the change in a result of sensor and the corresponding change in a value of a quality being observed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensitivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Sensitivity">https://www.w3.org/ns/ssn/Sensitivity</seealso>
    let Sensitivity = Prefixed_Name(w3c_ssn, "Sensitivity") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensor can do (implements) sensing: that is, a sensor is any entity that can follow a sensing method and thus observe some Property of a FeatureOfInterest.  Sensors may be physical devices, computational methods, a laboratory setup with a person following a method, or any other thing that can follow a Sensing Method to observe a Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Sensor">https://www.w3.org/ns/ssn/Sensor</seealso>
    let Sensor = Prefixed_Name(w3c_ssn, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:SensorDataSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data sheet records properties of a sensor.  A data sheet might describe for example the accuracy in various conditions, the power use, the types of connectors that the sensor has, etc.
    ///
    /// Generally a sensor's properties are recorded directly (with hasMeasurementCapability, for example), but the data sheet can be used for example to record the manufacturers specifications verses observed capabilites, or if more is known than the manufacturer specifies, etc.  The data sheet is an information object about the sensor's properties, rather than a direct link to the actual properties themselves."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor Data Sheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/SensorDataSheet">https://www.w3.org/ns/ssn/SensorDataSheet</seealso>
    let SensorDataSheet = Prefixed_Name(w3c_ssn, "SensorDataSheet") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:SensorOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensor outputs a piece of information (an observed value), the value itself being represented by an ObservationValue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor Output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/SensorOutput">https://www.w3.org/ns/ssn/SensorOutput</seealso>
    let SensorOutput = Prefixed_Name(w3c_ssn, "SensorOutput") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:Stimulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Event in the real world that 'triggers' the sensor.  The properties associated to the stimulus may be different to eventual observed property.  It is the event, not the object that triggers the sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stimulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/Stimulus">https://www.w3.org/ns/ssn/Stimulus</seealso>
    let Stimulus = Prefixed_Name(w3c_ssn, "Stimulus") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:SurvivalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifiable characteristic that represents the extent of the sensors useful life.  Might include for example total battery life or number of recharges, or, for sensors that are used only a fixed number of times, the number of observations that can be made before the sensing capability is depleted."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Survival Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/SurvivalProperty">https://www.w3.org/ns/ssn/SurvivalProperty</seealso>
    let SurvivalProperty = Prefixed_Name(w3c_ssn, "SurvivalProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:SurvivalRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The conditions a sensor can be exposed to without damage: i.e., the sensor continues to operate as defined using MeasurementCapability.  If, however, the SurvivalRange is exceeded, the sensor is 'damaged' and MeasurementCapability specifications may no longer hold."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Survival Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/SurvivalRange">https://www.w3.org/ns/ssn/SurvivalRange</seealso>
    let SurvivalRange = Prefixed_Name(w3c_ssn, "SurvivalRange") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System is a unit of abstraction for pieces of infrastructure (and we largely care that they are) for sensing. A system has components, its subsystems, which are other systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/System">https://www.w3.org/ns/ssn/System</seealso>
    let System = Prefixed_Name(w3c_ssn, "System") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:SystemLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Total useful life of a sensor/system (expressed as total life since manufacture, time in use, number of operations, etc.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Lifetime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/SystemLifetime">https://www.w3.org/ns/ssn/SystemLifetime</seealso>
    let SystemLifetime = Prefixed_Name(w3c_ssn, "SystemLifetime") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:attachedSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Platform and any Systems (e.g., Sensors) that are attached to the Platform."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attached system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/attachedSystem">https://www.w3.org/ns/ssn/attachedSystem</seealso>
    let attachedSystem = Prefixed_Name(w3c_ssn, "attachedSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:deployedOnPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a deployment and the platform on which the system was deployed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deployed on platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/deployedOnPlatform">https://www.w3.org/ns/ssn/deployedOnPlatform</seealso>
    let deployedOnPlatform =
        Prefixed_Name(w3c_ssn, "deployedOnPlatform") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:deployedSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a deployment and the deployed system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deployed system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/deployedSystem">https://www.w3.org/ns/ssn/deployedSystem</seealso>
    let deployedSystem = Prefixed_Name(w3c_ssn, "deployedSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:deploymentProcessPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has part relation between a deployment process and its constituent processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deployment process part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/deploymentProcessPart">https://www.w3.org/ns/ssn/deploymentProcessPart</seealso>
    let deploymentProcessPart =
        Prefixed_Name(w3c_ssn, "deploymentProcessPart") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:detects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation from a sensor to the Stimulus that the sensor can detect.
    /// The Stimulus itself will be serving as a proxy for (see isProxyOf) some observable property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"detects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/detects">https://www.w3.org/ns/ssn/detects</seealso>
    let detects = Prefixed_Name(w3c_ssn, "detects") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:featureInObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/featureInObservation">https://www.w3.org/ns/ssn/featureInObservation</seealso>
    let featureInObservation =
        Prefixed_Name(w3c_ssn, "featureInObservation") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:featureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an observation and the entity whose quality was observed.   For example, in an observation of the weight of a person, the feature of interest is the person and the quality is weight."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"feature of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/featureOfInterest">https://www.w3.org/ns/ssn/featureOfInterest</seealso>
    let featureOfInterest = Prefixed_Name(w3c_ssn, "featureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:forProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between some aspect of a sensing entity and a property.  For example, from a sensor to the properties it can observe, or from a deployment to the properties it was installed to observe.  Also from a measurement capability to the property the capability is described for.  (Used in conjunction with ofFeature)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"for property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/forProperty">https://www.w3.org/ns/ssn/forProperty</seealso>
    let forProperty = Prefixed_Name(w3c_ssn, "forProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:fromStimulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/fromStimulus">https://www.w3.org/ns/ssn/fromStimulus</seealso>
    let fromStimulus = Prefixed_Name(w3c_ssn, "fromStimulus") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:hasDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a System and a Deployment, recording that the System/Sensor was deployed in that Deployment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has deployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasDeployment">https://www.w3.org/ns/ssn/hasDeployment</seealso>
    let hasDeployment = Prefixed_Name(w3c_ssn, "hasDeployment") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:hasMeasurementCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a Sensor to a MeasurementCapability describing the measurement properties of the sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has measurement capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasMeasurementCapability">https://www.w3.org/ns/ssn/hasMeasurementCapability</seealso>
    let hasMeasurementCapability =
        Prefixed_Name(w3c_ssn, "hasMeasurementCapability") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:hasMeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a MeasurementCapability to a MeasurementProperty.  For example, to an accuracy (see notes at MeasurementCapability)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has measurement property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasMeasurementProperty">https://www.w3.org/ns/ssn/hasMeasurementProperty</seealso>
    let hasMeasurementProperty =
        Prefixed_Name(w3c_ssn, "hasMeasurementProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:hasOperatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from an OperatingRange to a Property.  For example, to a battery lifetime."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has operating property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasOperatingProperty">https://www.w3.org/ns/ssn/hasOperatingProperty</seealso>
    let hasOperatingProperty =
        Prefixed_Name(w3c_ssn, "hasOperatingProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:hasOperatingRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a System to an OperatingRange describing the normal operating environment of the System."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has operating range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasOperatingRange">https://www.w3.org/ns/ssn/hasOperatingRange</seealso>
    let hasOperatingRange = Prefixed_Name(w3c_ssn, "hasOperatingRange") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The chain here ensures that the observed property of an observation is a property of the feature of interest.  This restriction is written in O&amp;M; here we can enforce it formally.
    ///
    /// The more obvious formulation:
    ///
    /// featureOfInterest o hasProperty SubPropertyOf observedProperty
    ///
    /// can't be used, because (by the OWL2 decidability restrictions) that would mean cardinality restrictions couldn't be applied to observedProperty (see definition of Observation)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A relation between a FeatureOfInterest and a Property of that feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasProperty">https://www.w3.org/ns/ssn/hasProperty</seealso>
    let hasProperty = Prefixed_Name(w3c_ssn, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:hasSubSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Haspart relation between a system and its parts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has subsystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasSubSystem">https://www.w3.org/ns/ssn/hasSubSystem</seealso>
    let hasSubSystem = Prefixed_Name(w3c_ssn, "hasSubSystem") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:hasSurvivalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a SurvivalRange to a Property describing the survial range of a system.  For example, to the temperature extreme that a system can withstand before being considered damaged."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has survival property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasSurvivalProperty">https://www.w3.org/ns/ssn/hasSurvivalProperty</seealso>
    let hasSurvivalProperty =
        Prefixed_Name(w3c_ssn, "hasSurvivalProperty") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:hasSurvivalRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Relation from a System to a SurvivalRange."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has survival range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasSurvivalRange">https://www.w3.org/ns/ssn/hasSurvivalRange</seealso>
    let hasSurvivalRange = Prefixed_Name(w3c_ssn, "hasSurvivalRange") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/hasValue">https://www.w3.org/ns/ssn/hasValue</seealso>
    let hasValue = Prefixed_Name(w3c_ssn, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between the description of an algorithm, procedure or method and an entity that implements that method in some executable way.  For example, between a scientific measuring method and a sensor the senses via that method."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implemented by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/implementedBy">https://www.w3.org/ns/ssn/implementedBy</seealso>
    let implementedBy = Prefixed_Name(w3c_ssn, "implementedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an entity that implements a method in some executable way and the description of an algorithm, procedure or method.  For example, between a Sensor and the scientific measuring method that the Sensor uses to observe a Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/implements">https://www.w3.org/ns/ssn/implements</seealso>
    let implements = Prefixed_Name(w3c_ssn, "implements") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:inCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the prevailing environmental conditions for MeasurementCapabilites, OperatingConditions and SurvivalRanges.  Used for example to say that a sensor has a particular accuracy in particular conditions.  (see also MeasurementCapability)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/inCondition">https://www.w3.org/ns/ssn/inCondition</seealso>
    let inCondition = Prefixed_Name(w3c_ssn, "inCondition") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:inDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Platform and a Deployment, recording that the object was used as a platform for a system/sensor for a particular deployment: as in this PhysicalObject is acting as a Platform inDeployment Deployment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in deployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/inDeployment">https://www.w3.org/ns/ssn/inDeployment</seealso>
    let inDeployment = Prefixed_Name(w3c_ssn, "inDeployment") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a producer and a produced entity: for example, between a sensor and the produced output."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is produced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/isProducedBy">https://www.w3.org/ns/ssn/isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(w3c_ssn, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a FeatureOfInterest and a Property (a Quality observable by a sensor) of that feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is property of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/isPropertyOf">https://www.w3.org/ns/ssn/isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(w3c_ssn, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:isProxyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.  For example, the expansion of the quicksilver is a stimulus that serves as a proxy for temperature, or an increase or decrease in the spinning of cups on a wind sensor is serving as a proxy for wind speed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isProxyFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/isProxyFor">https://www.w3.org/ns/ssn/isProxyFor</seealso>
    let isProxyFor = Prefixed_Name(w3c_ssn, "isProxyFor") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:isValueOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/isValueOf">https://www.w3.org/ns/ssn/isValueOf</seealso>
    let isValueOf = Prefixed_Name(w3c_ssn, "isValueOf") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:madeObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Sensor and Observations it has made."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"made observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/madeObservation">https://www.w3.org/ns/ssn/madeObservation</seealso>
    let madeObservation = Prefixed_Name(w3c_ssn, "madeObservation") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:observationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation (i.e., a description of the context, the Situation, in which the observatioin was made) and a Result, which contains a value representing the value associated with the observed Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observation result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/observationResult">https://www.w3.org/ns/ssn/observationResult</seealso>
    let observationResult = Prefixed_Name(w3c_ssn, "observationResult") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:observationResultTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The result time is the time when the procedure associated with the observation act was applied."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The result time shall describe the time when the result became available, typically when the procedure associated with the observation was completed For some observations this is identical to the phenomenonTime. However, there are important cases where they differ.[O&amp;M]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observation result time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/observationResultTime">https://www.w3.org/ns/ssn/observationResultTime</seealso>
    let observationResultTime =
        Prefixed_Name(w3c_ssn, "observationResultTime") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:observationSamplingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Rebadged as phenomenon time in [O&amp;M]. The phenomenon time shall describe the time that the result applies to the property of the feature-of-interest. This is often the time of interaction by a sampling procedure or observation procedure with a real-world feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The sampling time is the time that the result applies to the feature-of-interest. This is the time usually required for geospatial analysis of the result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observation sampling time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/observationSamplingTime">https://www.w3.org/ns/ssn/observationSamplingTime</seealso>
    let observationSamplingTime =
        Prefixed_Name(w3c_ssn, "observationSamplingTime") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:observedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/observedBy">https://www.w3.org/ns/ssn/observedBy</seealso>
    let observedBy = Prefixed_Name(w3c_ssn, "observedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:observedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation to the Property that was observed.  The observedProperty should be a Property (hasProperty) of the FeatureOfInterest (linked by featureOfInterest) of this observation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observed property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/observedProperty">https://www.w3.org/ns/ssn/observedProperty</seealso>
    let observedProperty = Prefixed_Name(w3c_ssn, "observedProperty") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:observes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/observes">https://www.w3.org/ns/ssn/observes</seealso>
    let observes = Prefixed_Name(w3c_ssn, "observes") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:ofFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between some aspect of a sensing entity and a feature.  For example, from a sensor to the features it can observe properties of, or from a deployment to the features it was installed to observe.  Also from a measurement capability to the feature the capability is described for.  (Used in conjunction with forProperty)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"of feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/ofFeature">https://www.w3.org/ns/ssn/ofFeature</seealso>
    let ofFeature = Prefixed_Name(w3c_ssn, "ofFeature") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:onPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a System (e.g., a Sensor) and a Platform.  The relation locates the sensor relative to other described entities entities: i.e., the Sensor s1's location is Platform p1.  More precise locations for sensors in space (relative to other entities, where attached to another entity, or in 3D space) are made using DOLCE's Regions (SpaceRegion)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"on platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/onPlatform">https://www.w3.org/ns/ssn/onPlatform</seealso>
    let onPlatform = Prefixed_Name(w3c_ssn, "onPlatform") |> PrefixedName
    /// <summary>
    ///   <para>w3c-ssn:produces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The chain here means that if a sensor made an observation and that observation has a result, then the result is the one produced by the sensor.  Just ensures that the sensor and the resulting observation agree on the result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/produces">https://www.w3.org/ns/ssn/produces</seealso>
    let produces = Prefixed_Name(w3c_ssn, "produces") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:qualityOfObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation to the adjudged quality of the result.  This is of course complimentary to the MeasurementCapability information recorded for the Sensor that made the Observation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quality of observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/qualityOfObservation">https://www.w3.org/ns/ssn/qualityOfObservation</seealso>
    let qualityOfObservation =
        Prefixed_Name(w3c_ssn, "qualityOfObservation") |> PrefixedName

    /// <summary>
    ///   <para>w3c-ssn:sensingMethodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A (measurement) procedure is a detailed description of a measurement according to one or more measurement principles and to a given measurement method, based on a measurement model and including any calculation to obtain a measurement result [VIM 2.6]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sensing method used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://www.w3.org/ns/ssn/sensingMethodUsed">https://www.w3.org/ns/ssn/sensingMethodUsed</seealso>
    let sensingMethodUsed = Prefixed_Name(w3c_ssn, "sensingMethodUsed") |> PrefixedName
