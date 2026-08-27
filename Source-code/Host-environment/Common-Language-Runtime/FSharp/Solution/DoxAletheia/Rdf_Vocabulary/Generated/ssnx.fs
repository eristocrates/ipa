namespace http.purl.oclc.org.NET.ssnx.ssn.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ssnx =
    let _namespace_iri = Namespace_Iri ssnx |> NamespaceIRI
    /// <summary>
    ///   <para>ssnx:Accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The closeness of agreement between the value of an observation and the true value of the observed quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accuracy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Accuracy">http://purl.oclc.org/NET/ssnx/ssn#Accuracy</seealso>
    let Accuracy = Prefixed_Name(ssnx, "Accuracy") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:BatteryLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Total useful life of a battery."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery Lifetime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#BatteryLifetime">http://purl.oclc.org/NET/ssnx/ssn#BatteryLifetime</seealso>
    let BatteryLifetime = Prefixed_Name(ssnx, "BatteryLifetime") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Used to specify ranges for qualities that act as conditions on a system/sensor's operation.  For example, wind speed of 10-60m/s is expressed as a condition linking a quality, wind speed, a unit of measurement, metres per second, and a set of values, 10-60, and may be used as the condition on a MeasurementProperty, for example, to state that a sensor has a particular accuracy in that condition."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Condition">http://purl.oclc.org/NET/ssnx/ssn#Condition</seealso>
    let Condition = Prefixed_Name(ssnx, "Condition") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Deployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The ongoing Process of Entities (for the purposes of this ontology, mainly sensors) deployed for a particular purpose.  For example, a particular Sensor deployed on a Platform, or a whole network of Sensors deployed for an observation campaign.  The deployment may have sub processes, such as installation, maintenance, addition, and decomissioning and removal."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Deployment"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Deployment">http://purl.oclc.org/NET/ssnx/ssn#Deployment</seealso>
    let Deployment = Prefixed_Name(ssnx, "Deployment") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:DeploymentRelatedProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Place to group all the various Processes related to Deployment.  For example, as well as Deplyment, installation, maintenance, deployment of further sensors and the like would all be classified under DeploymentRelatedProcess."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Deployment-related Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#DeploymentRelatedProcess">http://purl.oclc.org/NET/ssnx/ssn#DeploymentRelatedProcess</seealso>
    let DeploymentRelatedProcess =
        Prefixed_Name(ssnx, "DeploymentRelatedProcess") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:DetectionLimit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An observed value for which the probability of falsely claiming the absence of a component in a material is Î², given a probability Î± of falsely claiming its presence."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"detection limit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#DetectionLimit">http://purl.oclc.org/NET/ssnx/ssn#DetectionLimit</seealso>
    let DetectionLimit = Prefixed_Name(ssnx, "DetectionLimit") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A device is a physical piece of technology - a system in a box. Devices may of course be built of smaller devices and software components (i.e. systems have components)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>" A device is a physical piece of technology - a system in a box. Devices may of course be built of smaller devices and software components (i.e. systems have components)."</para>
    /// labels<para>"Device"</para><para>"Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Device">http://purl.oclc.org/NET/ssnx/ssn#Device</seealso>
    let Device = Prefixed_Name(ssnx, "Device") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Drift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A, continuous or incremental, change in the reported values of observations over time for an unchanging quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drift"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Drift">http://purl.oclc.org/NET/ssnx/ssn#Drift</seealso>
    let Drift = Prefixed_Name(ssnx, "Drift") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A feature is an abstraction of real world phenomena (thing, person, event, etc)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Feature of Interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#FeatureOfInterest">http://purl.oclc.org/NET/ssnx/ssn#FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(ssnx, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Frequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The smallest possible time between one observation and the next."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Frequency">http://purl.oclc.org/NET/ssnx/ssn#Frequency</seealso>
    let Frequency = Prefixed_Name(ssnx, "Frequency") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Input</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any information that is provided to a process for its use [MMI OntDev]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Input">http://purl.oclc.org/NET/ssnx/ssn#Input</seealso>
    let Input = Prefixed_Name(ssnx, "Input") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Latency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The time between a request for an observation and the sensor providing a result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Latency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Latency">http://purl.oclc.org/NET/ssnx/ssn#Latency</seealso>
    let Latency = Prefixed_Name(ssnx, "Latency") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:MaintenanceSchedule</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Schedule of maintenance for a system/sensor in the specified conditions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maintenance Schedule"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#MaintenanceSchedule">http://purl.oclc.org/NET/ssnx/ssn#MaintenanceSchedule</seealso>
    let MaintenanceSchedule = Prefixed_Name(ssnx, "MaintenanceSchedule") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:MeasurementCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Collects together measurement properties (accuracy, range, precision, etc) and the environmental conditions in which those properties hold, representing a specification of a sensor's capability in those conditions.
    ///
    /// The conditions specified here are those that affect the measurement properties, while those in OperatingRange represent the sensor's standard operating conditions, including conditions that don't affect the observations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement Capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#MeasurementCapability">http://purl.oclc.org/NET/ssnx/ssn#MeasurementCapability</seealso>
    let MeasurementCapability =
        Prefixed_Name(ssnx, "MeasurementCapability") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:MeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"An identifiable and observable characteristic of a sensor's observations or ability to make observations."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement  Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#MeasurementProperty">http://purl.oclc.org/NET/ssnx/ssn#MeasurementProperty</seealso>
    let MeasurementProperty = Prefixed_Name(ssnx, "MeasurementProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:MeasurementRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The set of values that the sensor can return as the result of an observation under the defined conditions with the defined measurement properties.  (If no conditions are specified or the conditions do not specify a range for the observed qualities, the measurement range is to be taken as the condition for the observed qualities.)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Measurement  Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#MeasurementRange">http://purl.oclc.org/NET/ssnx/ssn#MeasurementRange</seealso>
    let MeasurementRange = Prefixed_Name(ssnx, "MeasurementRange") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"An Observation is a Situation in which a Sensing method has been used to estimate or calculate a value of a Property of a FeatureOfInterest.  Links to Sensing and Sensor describe what made the Observation and how; links to Property and Feature detail what was sensed; the result is the output of a Sensor; other metadata details times etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Observation"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Observation">http://purl.oclc.org/NET/ssnx/ssn#Observation</seealso>
    let Observation = Prefixed_Name(ssnx, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:ObservationValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The value of the result of an Observation.  An Observation has a result which is the output of some sensor, the result is an information object that encodes some value for a Feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Observation Value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#ObservationValue">http://purl.oclc.org/NET/ssnx/ssn#ObservationValue</seealso>
    let ObservationValue = Prefixed_Name(ssnx, "ObservationValue") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:OperatingPowerRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Power range in which system/sensor is expected to operate."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Power Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#OperatingPowerRange">http://purl.oclc.org/NET/ssnx/ssn#OperatingPowerRange</seealso>
    let OperatingPowerRange = Prefixed_Name(ssnx, "OperatingPowerRange") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:OperatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifiable characteristic of the environmental and other conditions in which the sensor is intended to operate.  May include power ranges, power sources, standard configurations, attachments and the like."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#OperatingProperty">http://purl.oclc.org/NET/ssnx/ssn#OperatingProperty</seealso>
    let OperatingProperty = Prefixed_Name(ssnx, "OperatingProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:OperatingRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The environmental conditions and characteristics of a system/sensor's normal operating environment.  Can be used to specify for example the standard environmental conditions in which the sensor is expected to operate (a Condition with no OperatingProperty), or how the environmental and other operating properties relate: i.e., that the maintenance schedule or power requirements differ according to the conditions."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Operating Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#OperatingRange">http://purl.oclc.org/NET/ssnx/ssn#OperatingRange</seealso>
    let OperatingRange = Prefixed_Name(ssnx, "OperatingRange") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Output</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Any information that is reported from a process. [MMI OntDev]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Output">http://purl.oclc.org/NET/ssnx/ssn#Output</seealso>
    let Output = Prefixed_Name(ssnx, "Output") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Entity to which other Entities can be attached - particuarly Sensors and other Platforms.  For example, a post might act as the Platform, a bouy might act as a Platform, or a fish might act as a Platform for an attached sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Platform"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Platform">http://purl.oclc.org/NET/ssnx/ssn#Platform</seealso>
    let Platform = Prefixed_Name(ssnx, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Precision</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The closeness of agreement between replicate observations on an unchanged or similar quality value: i.e., a measure of a sensor's ability to consitently reproduce an observation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Precision"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Precision">http://purl.oclc.org/NET/ssnx/ssn#Precision</seealso>
    let Precision = Prefixed_Name(ssnx, "Precision") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A process has an output and possibly inputs and, for a composite process, describes the temporal and dataflow dependencies and relationships amongst its parts. [SSN XG]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Process"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Process">http://purl.oclc.org/NET/ssnx/ssn#Process</seealso>
    let Process = Prefixed_Name(ssnx, "Process") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Property</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An observable Quality of an Event or Object.  That is, not a quality of an abstract entity as is also allowed by DUL's Quality, but rather an aspect of an entity that is intrinsic to and cannot exist without the entity and is observable by a sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Property">http://purl.oclc.org/NET/ssnx/ssn#Property</seealso>
    let Property = Prefixed_Name(ssnx, "Property") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Resolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The smallest difference in the value of a quality being observed that would result in perceptably different values of observation results."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Resolution">http://purl.oclc.org/NET/ssnx/ssn#Resolution</seealso>
    let Resolution = Prefixed_Name(ssnx, "Resolution") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:ResponseTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The time between a (step) change inthe value of an observed quality and a sensor (possibly with specified error) 'settling' on an observed value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Response time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#ResponseTime">http://purl.oclc.org/NET/ssnx/ssn#ResponseTime</seealso>
    let ResponseTime = Prefixed_Name(ssnx, "ResponseTime") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Selectivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Selectivity is a property of a sensor whereby it provides observed values for one or more qualities such that the values of each quality are independent of other qualities in the phenomenon, body, or substance being investigated."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Selectivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Selectivity">http://purl.oclc.org/NET/ssnx/ssn#Selectivity</seealso>
    let Selectivity = Prefixed_Name(ssnx, "Selectivity") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Sensing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensing is a process that results in the estimation, or calculation, of the value of a phenomenon."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Sensing">http://purl.oclc.org/NET/ssnx/ssn#Sensing</seealso>
    let Sensing = Prefixed_Name(ssnx, "Sensing") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SensingDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A sensing device is a device that implements sensing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"A sensing device is a device that implements sensing."</para>
    /// labels<para>"Sensing Device"</para><para>"Sensing Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SensingDevice">http://purl.oclc.org/NET/ssnx/ssn#SensingDevice</seealso>
    let SensingDevice = Prefixed_Name(ssnx, "SensingDevice") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Sensitivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Sensitivity is the quotient of the change in a result of sensor and the corresponding change in a value of a quality being observed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensitivity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Sensitivity">http://purl.oclc.org/NET/ssnx/ssn#Sensitivity</seealso>
    let Sensitivity = Prefixed_Name(ssnx, "Sensitivity") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensor can do (implements) sensing: that is, a sensor is any entity that can follow a sensing method and thus observe some Property of a FeatureOfInterest.  Sensors may be physical devices, computational methods, a laboratory setup with a person following a method, or any other thing that can follow a Sensing Method to observe a Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Sensor"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Sensor">http://purl.oclc.org/NET/ssnx/ssn#Sensor</seealso>
    let Sensor = Prefixed_Name(ssnx, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SensorDataSheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A data sheet records properties of a sensor.  A data sheet might describe for example the accuracy in various conditions, the power use, the types of connectors that the sensor has, etc.
    ///
    /// Generally a sensor's properties are recorded directly (with hasMeasurementCapability, for example), but the data sheet can be used for example to record the manufacturers specifications verses observed capabilites, or if more is known than the manufacturer specifies, etc.  The data sheet is an information object about the sensor's properties, rather than a direct link to the actual properties themselves."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor Data Sheet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SensorDataSheet">http://purl.oclc.org/NET/ssnx/ssn#SensorDataSheet</seealso>
    let SensorDataSheet = Prefixed_Name(ssnx, "SensorDataSheet") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SensorInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Event in the real world that 'triggers' the sensor.  The properties associated to the stimulus may be different to eventual observed property.  It is the event, not the object that triggers the sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor Input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SensorInput">http://purl.oclc.org/NET/ssnx/ssn#SensorInput</seealso>
    let SensorInput = Prefixed_Name(ssnx, "SensorInput") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SensorOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A sensor outputs a piece of information (an observed value), the value itself being represented by an ObservationValue."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensor Output"</para><para>"Sensor Output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SensorOutput">http://purl.oclc.org/NET/ssnx/ssn#SensorOutput</seealso>
    let SensorOutput = Prefixed_Name(ssnx, "SensorOutput") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:Stimulus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Event in the real world that 'triggers' the sensor.  The properties associated to the stimulus may be different to eventual observed property.  It is the event, not the object that triggers the sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stimulus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#Stimulus">http://purl.oclc.org/NET/ssnx/ssn#Stimulus</seealso>
    let Stimulus = Prefixed_Name(ssnx, "Stimulus") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SurvivalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An identifiable characteristic that represents the extent of the sensors useful life.  Might include for example total battery life or number of recharges, or, for sensors that are used only a fixed number of times, the number of observations that can be made before the sensing capability is depleted."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Survival Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SurvivalProperty">http://purl.oclc.org/NET/ssnx/ssn#SurvivalProperty</seealso>
    let SurvivalProperty = Prefixed_Name(ssnx, "SurvivalProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SurvivalRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The conditions a sensor can be exposed to without damage: i.e., the sensor continues to operate as defined using MeasurementCapability.  If, however, the SurvivalRange is exceeded, the sensor is 'damaged' and MeasurementCapability specifications may no longer hold."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Survival Range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SurvivalRange">http://purl.oclc.org/NET/ssnx/ssn#SurvivalRange</seealso>
    let SurvivalRange = Prefixed_Name(ssnx, "SurvivalRange") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:System</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"System is a unit of abstraction for pieces of infrastructure (and we largely care that they are) for sensing. A system has components, its subsystems, which are other systems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"System"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#System">http://purl.oclc.org/NET/ssnx/ssn#System</seealso>
    let System = Prefixed_Name(ssnx, "System") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:SystemLifetime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Total useful life of a sensor/system (expressed as total life since manufacture, time in use, number of operations, etc.)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"System Lifetime"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#SystemLifetime">http://purl.oclc.org/NET/ssnx/ssn#SystemLifetime</seealso>
    let SystemLifetime = Prefixed_Name(ssnx, "SystemLifetime") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:attachedSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Platform and any Systems (e.g., Sensors) that are attached to the Platform."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"attached system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Attached System"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#attachedSystem">http://purl.oclc.org/NET/ssnx/ssn#attachedSystem</seealso>
    let attachedSystem = Prefixed_Name(ssnx, "attachedSystem") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:deployedOnPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a deployment and the platform on which the system was deployed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deployed on platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#deployedOnPlatform">http://purl.oclc.org/NET/ssnx/ssn#deployedOnPlatform</seealso>
    let deployedOnPlatform = Prefixed_Name(ssnx, "deployedOnPlatform") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:deployedSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a deployment and the deployed system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deployed system"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#deployedSystem">http://purl.oclc.org/NET/ssnx/ssn#deployedSystem</seealso>
    let deployedSystem = Prefixed_Name(ssnx, "deployedSystem") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:deploymentProcessPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Has part relation between a deployment process and its constituent processes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"deployment process part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#deploymentProcessPart">http://purl.oclc.org/NET/ssnx/ssn#deploymentProcessPart</seealso>
    let deploymentProcessPart =
        Prefixed_Name(ssnx, "deploymentProcessPart") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:detects</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation from a sensor to the Stimulus that the sensor can detect.
    /// The Stimulus itself will be serving as a proxy for (see isProxyOf) some observable property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"detects"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#detects">http://purl.oclc.org/NET/ssnx/ssn#detects</seealso>
    let detects = Prefixed_Name(ssnx, "detects") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"end time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#endTime">http://purl.oclc.org/NET/ssnx/ssn#endTime</seealso>
    let endTime = Prefixed_Name(ssnx, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:featureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an observation and the entity whose quality was observed.   For example, in an observation of the weight of a person, the feature of interest is the person and the quality is weight."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"feature of interest"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#featureOfInterest">http://purl.oclc.org/NET/ssnx/ssn#featureOfInterest</seealso>
    let featureOfInterest = Prefixed_Name(ssnx, "featureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:forProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between some aspect of a sensing entity and a property.  For example, from a sensor to the properties it can observe, or from a deployment to the properties it was installed to observe.  Also from a measurement capability to the property the capability is described for.  (Used in conjunction with ofFeature)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"for property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#forProperty">http://purl.oclc.org/NET/ssnx/ssn#forProperty</seealso>
    let forProperty = Prefixed_Name(ssnx, "forProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a System and a Deployment, recording that the System/Sensor was deployed in that Deployment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Deployment"</para><para>"has deployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasDeployment">http://purl.oclc.org/NET/ssnx/ssn#hasDeployment</seealso>
    let hasDeployment = Prefixed_Name(ssnx, "hasDeployment") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasInput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasInput">http://purl.oclc.org/NET/ssnx/ssn#hasInput</seealso>
    let hasInput = Prefixed_Name(ssnx, "hasInput") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:hasMeasurementCapability</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a Sensor to a MeasurementCapability describing the measurement properties of the sensor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has measurement  capability"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasMeasurementCapability">http://purl.oclc.org/NET/ssnx/ssn#hasMeasurementCapability</seealso>
    let hasMeasurementCapability =
        Prefixed_Name(ssnx, "hasMeasurementCapability") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:hasMeasurementProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a MeasurementCapability to a MeasurementProperty.  For example, to an accuracy (see notes at MeasurementCapability)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has measurement property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasMeasurementProperty">http://purl.oclc.org/NET/ssnx/ssn#hasMeasurementProperty</seealso>
    let hasMeasurementProperty =
        Prefixed_Name(ssnx, "hasMeasurementProperty") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:hasOperatingProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from an OperatingRange to a Property.  For example, to a battery lifetime."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has operating property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasOperatingProperty">http://purl.oclc.org/NET/ssnx/ssn#hasOperatingProperty</seealso>
    let hasOperatingProperty =
        Prefixed_Name(ssnx, "hasOperatingProperty") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:hasOperatingRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a System to an OperatingRange describing the normal operating environment of the System."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has operating range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasOperatingRange">http://purl.oclc.org/NET/ssnx/ssn#hasOperatingRange</seealso>
    let hasOperatingRange = Prefixed_Name(ssnx, "hasOperatingRange") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"has output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasOutput">http://purl.oclc.org/NET/ssnx/ssn#hasOutput</seealso>
    let hasOutput = Prefixed_Name(ssnx, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between a FeatureOfInterest and a Property of that feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasProperty">http://purl.oclc.org/NET/ssnx/ssn#hasProperty</seealso>
    let hasProperty = Prefixed_Name(ssnx, "hasProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasSubSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Haspart relation between a system and its parts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Has Sub System"</para><para>"has subsystem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasSubSystem">http://purl.oclc.org/NET/ssnx/ssn#hasSubSystem</seealso>
    let hasSubSystem = Prefixed_Name(ssnx, "hasSubSystem") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasSurvivalProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation from a SurvivalRange to a Property describing the survial range of a system.  For example, to the temperature extreme that a system can withstand before being considered damaged."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has survival property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasSurvivalProperty">http://purl.oclc.org/NET/ssnx/ssn#hasSurvivalProperty</seealso>
    let hasSurvivalProperty = Prefixed_Name(ssnx, "hasSurvivalProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasSurvivalRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A Relation from a System to a SurvivalRange."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has survival range"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasSurvivalRange">http://purl.oclc.org/NET/ssnx/ssn#hasSurvivalRange</seealso>
    let hasSurvivalRange = Prefixed_Name(ssnx, "hasSurvivalRange") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Provides a relation between observationValue and actual value."</para>
    /// labels<para>"has value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Has Value"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#hasValue">http://purl.oclc.org/NET/ssnx/ssn#hasValue</seealso>
    let hasValue = Prefixed_Name(ssnx, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:implementedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between the description of an algorithm, procedure or method and an entity that implements that method in some executable way.  For example, between a scientific measuring method and a sensor the senses via that method."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implemented by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#implementedBy">http://purl.oclc.org/NET/ssnx/ssn#implementedBy</seealso>
    let implementedBy = Prefixed_Name(ssnx, "implementedBy") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:implements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between an entity that implements a method in some executable way and the description of an algorithm, procedure or method.  For example, between a Sensor and the scientific measuring method that the Sensor uses to observe a Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"implements"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#implements">http://purl.oclc.org/NET/ssnx/ssn#implements</seealso>
    let implements = Prefixed_Name(ssnx, "implements") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:inCondition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the prevailing environmental conditions for MeasurementCapabilites, OperatingConditions and SurvivalRanges.  Used for example to say that a sensor has a particular accuracy in particular conditions.  (see also MeasurementCapability)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in condition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#inCondition">http://purl.oclc.org/NET/ssnx/ssn#inCondition</seealso>
    let inCondition = Prefixed_Name(ssnx, "inCondition") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:inDeployment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Platform and a Deployment, recording that the object was used as a platform for a system/sensor for a particular deployment: as in this PhysicalObject is acting as a Platform inDeployment Deployment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"in deployment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#inDeployment">http://purl.oclc.org/NET/ssnx/ssn#inDeployment</seealso>
    let inDeployment = Prefixed_Name(ssnx, "inDeployment") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:isProducedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a producer and a produced entity: for example, between a sensor and the produced output."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is produced by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#isProducedBy">http://purl.oclc.org/NET/ssnx/ssn#isProducedBy</seealso>
    let isProducedBy = Prefixed_Name(ssnx, "isProducedBy") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:isPropertyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a FeatureOfInterest and a Property (a Quality observable by a sensor) of that feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is property of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#isPropertyOf">http://purl.oclc.org/NET/ssnx/ssn#isPropertyOf</seealso>
    let isPropertyOf = Prefixed_Name(ssnx, "isPropertyOf") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:isProxyFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.  For example, the expansion of the quicksilver is a stimulus that serves as a proxy for temperature, or an increase or decrease in the spinning of cups on a wind sensor is serving as a proxy for wind speed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"isProxyFor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#isProxyFor">http://purl.oclc.org/NET/ssnx/ssn#isProxyFor</seealso>
    let isProxyFor = Prefixed_Name(ssnx, "isProxyFor") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:madeObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Sensor and Observations it has made."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"made observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Made Observation"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#madeObservation">http://purl.oclc.org/NET/ssnx/ssn#madeObservation</seealso>
    let madeObservation = Prefixed_Name(ssnx, "madeObservation") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:observationResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation (i.e., a description of the context, the Situation, in which the observatioin was made) and a Result, which contains a value representing the value associated with the observed Property."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observation result"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Observation Result"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#observationResult">http://purl.oclc.org/NET/ssnx/ssn#observationResult</seealso>
    let observationResult = Prefixed_Name(ssnx, "observationResult") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:observationResultTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The result time shall describe the time when the result became available, typically when the procedure associated with the observation was completed For some observations this is identical to the phenomenonTime. However, there are important cases where they differ.[O&amp;M]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The result time is the time when the procedure associated with the observation act was applied."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observation result time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#observationResultTime">http://purl.oclc.org/NET/ssnx/ssn#observationResultTime</seealso>
    let observationResultTime =
        Prefixed_Name(ssnx, "observationResultTime") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:observationSamplingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Rebadged as phenomenon time in [O&amp;M]. The phenomenon time shall describe the time that the result applies to the property of the feature-of-interest. This is often the time of interaction by a sampling procedure or observation procedure with a real-world feature."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The sampling time is the time that the result applies to the feature-of-interest. This is the time usually required for geospatial analysis of the result."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observation sampling time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Observation Sampling Time"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#observationSamplingTime">http://purl.oclc.org/NET/ssnx/ssn#observationSamplingTime</seealso>
    let observationSamplingTime =
        Prefixed_Name(ssnx, "observationSamplingTime") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:observedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a observation and it sensor."</para>
    /// labels<para>"observed by"</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#observedBy">http://purl.oclc.org/NET/ssnx/ssn#observedBy</seealso>
    let observedBy = Prefixed_Name(ssnx, "observedBy") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:observedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation to the Property that was observed.  The observedProperty should be a Property (hasProperty) of the FeatureOfInterest (linked by featureOfInterest) of this observation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observed property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"Observed Property"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#observedProperty">http://purl.oclc.org/NET/ssnx/ssn#observedProperty</seealso>
    let observedProperty = Prefixed_Name(ssnx, "observedProperty") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:observes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a Sensor and a Property that the sensor can observe.
    ///
    /// Note that, given the DUL modelling of Qualities, a sensor defined with 'observes only Windspeed' technically links the sensor to particular instances of Windspeed, not to the concept itself - OWL can't express concept-concept relations, only individual-individual.  The property composition ensures that if an observation is made of a particular quality then one can infer that the sensor observes that quality."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"observes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#observes">http://purl.oclc.org/NET/ssnx/ssn#observes</seealso>
    let observes = Prefixed_Name(ssnx, "observes") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:ofFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A relation between some aspect of a sensing entity and a feature.  For example, from a sensor to the features it can observe properties of, or from a deployment to the features it was installed to observe.  Also from a measurement capability to the feature the capability is described for.  (Used in conjunction with forProperty)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"of feature"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#ofFeature">http://purl.oclc.org/NET/ssnx/ssn#ofFeature</seealso>
    let ofFeature = Prefixed_Name(ssnx, "ofFeature") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:onPlatform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation between a System (e.g., a Sensor) and a Platform.  The relation locates the sensor relative to other described entities entities: i.e., the Sensor s1's location is Platform p1.  More precise locations for sensors in space (relative to other entities, where attached to another entity, or in 3D space) are made using DOLCE's Regions (SpaceRegion)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"on platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"On Platform"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#onPlatform">http://purl.oclc.org/NET/ssnx/ssn#onPlatform</seealso>
    let onPlatform = Prefixed_Name(ssnx, "onPlatform") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:qualityOfObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Relation linking an Observation to the adjudged quality of the result.  This is of course complimentary to the MeasurementCapability information recorded for the Sensor that made the Observation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"quality of observation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#qualityOfObservation">http://purl.oclc.org/NET/ssnx/ssn#qualityOfObservation</seealso>
    let qualityOfObservation =
        Prefixed_Name(ssnx, "qualityOfObservation") |> PrefixedName

    /// <summary>
    ///   <para>ssnx:sensingMethodUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A (measurement) procedure is a detailed description of a measurement according to one or more measurement principles and to a given measurement method, based on a measurement model and including any calculation to obtain a measurement result [VIM 2.6]"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"sensing method used"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#sensingMethodUsed">http://purl.oclc.org/NET/ssnx/ssn#sensingMethodUsed</seealso>
    let sensingMethodUsed = Prefixed_Name(ssnx, "sensingMethodUsed") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"start time"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#startTime">http://purl.oclc.org/NET/ssnx/ssn#startTime</seealso>
    let startTime = Prefixed_Name(ssnx, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>ssnx:subPropertyOf</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.oclc.org/NET/ssnx/ssn#subPropertyOf">http://purl.oclc.org/NET/ssnx/ssn#subPropertyOf</seealso>
    let subPropertyOf = Prefixed_Name(ssnx, "subPropertyOf") |> PrefixedName
