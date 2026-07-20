namespace https.www.w3.org.ns.ssn.slash

open DoxAletheia

module w3c_ssn =
    let _namespace_name = "https://www.w3.org/ns/ssn/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The closeness of agreement between the value of an observation and the true value of the observed quality.
    /// <see href="https://www.w3.org/ns/ssn/Accuracy"></see></summary>
    let Accuracy = _prefix "Accuracy"
    /// <summary>
    /// An identifiable and observable characteristic of a sensor's observations or ability to make observations.
    /// <see href="https://www.w3.org/ns/ssn/MeasurementProperty"></see></summary>
    let MeasurementProperty = _prefix "MeasurementProperty"
    /// <summary>
    /// Total useful life of a battery.
    /// <see href="https://www.w3.org/ns/ssn/BatteryLifetime"></see></summary>
    let BatteryLifetime = _prefix "BatteryLifetime"
    /// <summary>
    /// An identifiable characteristic that represents the extent of the sensors useful life.  Might include for example total battery life or number of recharges, or, for sensors that are used only a fixed number of times, the number of observations that can be made before the sensing capability is depleted.
    /// <see href="https://www.w3.org/ns/ssn/SurvivalProperty"></see></summary>
    let SurvivalProperty = _prefix "SurvivalProperty"
    /// <summary>
    /// Used to specify ranges for qualities that act as conditions on a system/sensor's operation.  For example, wind speed of 10-60m/s is expressed as a condition linking a quality, wind speed, a unit of measurement, metres per second, and a set of values, 10-60, and may be used as the condition on a MeasurementProperty, for example, to state that a sensor has a particular accuracy in that condition.
    /// <see href="https://www.w3.org/ns/ssn/Condition"></see></summary>
    let Condition = _prefix "Condition"
    /// <summary>
    /// An observable Quality of an Event or Object.  That is, not a quality of an abstract entity as is also allowed by DUL's Quality, but rather an aspect of an entity that is intrinsic to and cannot exist without the entity and is observable by a sensor.
    /// <see href="https://www.w3.org/ns/ssn/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// The ongoing Process of Entities (for the purposes of this ontology, mainly sensors) deployed for a particular purpose.  For example, a particular Sensor deployed on a Platform, or a whole network of Sensors deployed for an observation campaign.  The deployment may have sub processes, such as installation, maintenance, addition, and decomissioning and removal.
    /// <see href="https://www.w3.org/ns/ssn/Deployment"></see></summary>
    let Deployment = _prefix "Deployment"
    /// <summary>
    /// Relation between a deployment and the platform on which the system was deployed.
    /// <see href="https://www.w3.org/ns/ssn/deployedOnPlatform"></see></summary>
    let deployedOnPlatform = _prefix "deployedOnPlatform"
    /// <summary>
    /// An Entity to which other Entities can be attached - particuarly Sensors and other Platforms.  For example, a post might act as the Platform, a bouy might act as a Platform, or a fish might act as a Platform for an attached sensor.
    /// <see href="https://www.w3.org/ns/ssn/Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// Relation between a deployment and the deployed system.
    /// <see href="https://www.w3.org/ns/ssn/deployedSystem"></see></summary>
    let deployedSystem = _prefix "deployedSystem"
    /// <summary>
    /// System is a unit of abstraction for pieces of infrastructure (and we largely care that they are) for sensing. A system has components, its subsystems, which are other systems.
    /// <see href="https://www.w3.org/ns/ssn/System"></see></summary>
    let System = _prefix "System"
    /// <summary>
    /// Place to group all the various Processes related to Deployment.  For example, as well as Deplyment, installation, maintenance, deployment of further sensors and the like would all be classified under DeploymentRelatedProcess.
    /// <see href="https://www.w3.org/ns/ssn/DeploymentRelatedProcess"></see></summary>
    let DeploymentRelatedProcess = _prefix "DeploymentRelatedProcess"
    /// <summary>
    /// Has part relation between a deployment process and its constituent processes.
    /// <see href="https://www.w3.org/ns/ssn/deploymentProcessPart"></see></summary>
    let deploymentProcessPart = _prefix "deploymentProcessPart"
    /// <summary>
    /// An observed value for which the probability of falsely claiming the absence of a component in a material is Î², given a probability Î± of falsely claiming its presence.
    /// <see href="https://www.w3.org/ns/ssn/DetectionLimit"></see></summary>
    let DetectionLimit = _prefix "DetectionLimit"
    /// <summary>
    /// A device is a physical piece of technology - a system in a box. Devices may of course be built of smaller devices and software components (i.e. systems have components).
    /// <see href="https://www.w3.org/ns/ssn/Device"></see></summary>
    let Device = _prefix "Device"
    /// <summary>
    /// A, continuous or incremental, change in the reported values of observations over time for an unchanging quality.
    /// <see href="https://www.w3.org/ns/ssn/Drift"></see></summary>
    let Drift = _prefix "Drift"
    /// <summary>
    /// A feature is an abstraction of real world phenomena (thing, person, event, etc).
    /// <see href="https://www.w3.org/ns/ssn/FeatureOfInterest"></see></summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    /// A relation between a FeatureOfInterest and a Property of that feature.
    /// The chain here ensures that the observed property of an observation is a property of the feature of interest.  This restriction is written in O&amp;M; here we can enforce it formally.
    ///
    /// The more obvious formulation:
    ///
    /// featureOfInterest o hasProperty SubPropertyOf observedProperty
    ///
    /// can't be used, because (by the OWL2 decidability restrictions) that would mean cardinality restrictions couldn't be applied to observedProperty (see definition of Observation).
    /// <see href="https://www.w3.org/ns/ssn/hasProperty"></see></summary>
    let hasProperty = _prefix "hasProperty"
    /// <summary>
    /// Schedule of maintenance for a system/sensor in the specified conditions.
    /// <see href="https://www.w3.org/ns/ssn/MaintenanceSchedule"></see></summary>
    let MaintenanceSchedule = _prefix "MaintenanceSchedule"
    /// <summary>
    /// An identifiable characteristic of the environmental and other conditions in which the sensor is intended to operate.  May include power ranges, power sources, standard configurations, attachments and the like.
    /// <see href="https://www.w3.org/ns/ssn/OperatingProperty"></see></summary>
    let OperatingProperty = _prefix "OperatingProperty"
    /// <summary>
    /// Collects together measurement properties (accuracy, range, precision, etc) and the environmental conditions in which those properties hold, representing a specification of a sensor's capability in those conditions.
    ///
    /// The conditions specified here are those that affect the measurement properties, while those in OperatingRange represent the sensor's standard operating conditions, including conditions that don't affect the observations.
    /// <see href="https://www.w3.org/ns/ssn/MeasurementCapability"></see></summary>
    let MeasurementCapability = _prefix "MeasurementCapability"
    /// <summary>
    /// A relation between some aspect of a sensing entity and a property.  For example, from a sensor to the properties it can observe, or from a deployment to the properties it was installed to observe.  Also from a measurement capability to the property the capability is described for.  (Used in conjunction with ofFeature).
    /// <see href="https://www.w3.org/ns/ssn/forProperty"></see></summary>
    let forProperty = _prefix "forProperty"
    /// <summary>
    /// Describes the prevailing environmental conditions for MeasurementCapabilites, OperatingConditions and SurvivalRanges.  Used for example to say that a sensor has a particular accuracy in particular conditions.  (see also MeasurementCapability)
    /// <see href="https://www.w3.org/ns/ssn/inCondition"></see></summary>
    let inCondition = _prefix "inCondition"
    /// <summary>
    /// Relation from a MeasurementCapability to a MeasurementProperty.  For example, to an accuracy (see notes at MeasurementCapability).
    /// <see href="https://www.w3.org/ns/ssn/hasMeasurementProperty"></see></summary>
    let hasMeasurementProperty = _prefix "hasMeasurementProperty"
    /// <summary>
    /// The smallest possible time between one observation and the next.
    /// <see href="https://www.w3.org/ns/ssn/MeasurementFrequency"></see></summary>
    let MeasurementFrequency = _prefix "MeasurementFrequency"
    /// <summary>
    /// The time between a request for an observation and the sensor producing a result (not including network latency to retrieve the result, just time from request to measurement.).
    /// <see href="https://www.w3.org/ns/ssn/MeasurementLatency"></see></summary>
    let MeasurementLatency = _prefix "MeasurementLatency"
    /// <summary>
    /// The set of values that the sensor can return as the result of an observation under the defined conditions with the defined measurement properties.  (If no conditions are specified or the conditions do not specify a range for the observed qualities, the measurement range is to be taken as the condition for the observed qualities.)
    /// <see href="https://www.w3.org/ns/ssn/MeasurementRange"></see></summary>
    let MeasurementRange = _prefix "MeasurementRange"
    /// <summary>
    /// An Observation is a Situation in which a Sensing method has been used to estimate or calculate a value of a Property of a FeatureOfInterest.  Links to Sensing and Sensor describe what made the Observation and how; links to Property and Feature detail what was sensed; the result is the output of a Sensor; other metadata details times etc.
    /// <see href="https://www.w3.org/ns/ssn/Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// A relation between an observation and the entity whose quality was observed.   For example, in an observation of the weight of a person, the feature of interest is the person and the quality is weight.
    /// <see href="https://www.w3.org/ns/ssn/featureOfInterest"></see></summary>
    let featureOfInterest = _prefix "featureOfInterest"
    /// <summary>
    /// A (measurement) procedure is a detailed description of a measurement according to one or more measurement principles and to a given measurement method, based on a measurement model and including any calculation to obtain a measurement result [VIM 2.6]
    /// <see href="https://www.w3.org/ns/ssn/sensingMethodUsed"></see></summary>
    let sensingMethodUsed = _prefix "sensingMethodUsed"
    /// <summary>
    /// The description of a process (i.e. describes the temporal and dataflow dependencies and relationships amongst its parts) that results in the estimation, or calculation, of the value of a phenomenon.
    /// <see href="https://www.w3.org/ns/ssn/Sensing"></see></summary>
    let Sensing = _prefix "Sensing"
    /// <summary>
    /// Relation linking an Observation to the Property that was observed.  The observedProperty should be a Property (hasProperty) of the FeatureOfInterest (linked by featureOfInterest) of this observation.
    /// <see href="https://www.w3.org/ns/ssn/observedProperty"></see></summary>
    let observedProperty = _prefix "observedProperty"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/ssn/observedBy"></see>
    /// </summary>
    let observedBy = _prefix "observedBy"
    /// <summary>
    /// A sensor can do (implements) sensing: that is, a sensor is any entity that can follow a sensing method and thus observe some Property of a FeatureOfInterest.  Sensors may be physical devices, computational methods, a laboratory setup with a person following a method, or any other thing that can follow a Sensing Method to observe a Property.
    /// <see href="https://www.w3.org/ns/ssn/Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// Relation linking an Observation (i.e., a description of the context, the Situation, in which the observatioin was made) and a Result, which contains a value representing the value associated with the observed Property.
    /// <see href="https://www.w3.org/ns/ssn/observationResult"></see></summary>
    let observationResult = _prefix "observationResult"
    /// <summary>
    /// A sensor outputs a piece of information (an observed value), the value itself being represented by an ObservationValue.
    /// <see href="https://www.w3.org/ns/ssn/SensorOutput"></see></summary>
    let SensorOutput = _prefix "SensorOutput"
    /// <summary>
    /// An Event in the real world that 'triggers' the sensor.  The properties associated to the stimulus may be different to eventual observed property.  It is the event, not the object that triggers the sensor.
    /// <see href="https://www.w3.org/ns/ssn/Stimulus"></see></summary>
    let Stimulus = _prefix "Stimulus"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/ssn/fromStimulus"></see>
    /// </summary>
    let fromStimulus = _prefix "fromStimulus"
    /// <summary>
    /// The value of the result of an Observation.  An Observation has a result which is the output of some sensor, the result is an information object that encodes some value for a Feature.
    /// <see href="https://www.w3.org/ns/ssn/ObservationValue"></see></summary>
    let ObservationValue = _prefix "ObservationValue"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/ssn/isValueOf"></see>
    /// </summary>
    let isValueOf = _prefix "isValueOf"
    /// <summary>
    /// Power range in which system/sensor is expected to operate.
    /// <see href="https://www.w3.org/ns/ssn/OperatingPowerRange"></see></summary>
    let OperatingPowerRange = _prefix "OperatingPowerRange"
    /// <summary>
    /// The environmental conditions and characteristics of a system/sensor's normal operating environment.  Can be used to specify for example the standard environmental conditions in which the sensor is expected to operate (a Condition with no OperatingProperty), or how the environmental and other operating properties relate: i.e., that the maintenance schedule or power requirements differ according to the conditions.
    /// <see href="https://www.w3.org/ns/ssn/OperatingRange"></see></summary>
    let OperatingRange = _prefix "OperatingRange"
    /// <summary>
    /// Relation from an OperatingRange to a Property.  For example, to a battery lifetime.
    /// <see href="https://www.w3.org/ns/ssn/hasOperatingProperty"></see></summary>
    let hasOperatingProperty = _prefix "hasOperatingProperty"
    /// <summary>
    /// Relation between a Platform and a Deployment, recording that the object was used as a platform for a system/sensor for a particular deployment: as in this PhysicalObject is acting as a Platform inDeployment Deployment.
    /// <see href="https://www.w3.org/ns/ssn/inDeployment"></see></summary>
    let inDeployment = _prefix "inDeployment"
    /// <summary>
    /// Relation between a Platform and any Systems (e.g., Sensors) that are attached to the Platform.
    /// <see href="https://www.w3.org/ns/ssn/attachedSystem"></see></summary>
    let attachedSystem = _prefix "attachedSystem"
    /// <summary>
    /// The closeness of agreement between replicate observations on an unchanged or similar quality value: i.e., a measure of a sensor's ability to consitently reproduce an observation.
    /// <see href="https://www.w3.org/ns/ssn/Precision"></see></summary>
    let Precision = _prefix "Precision"
    /// <summary>
    /// Relation between a FeatureOfInterest and a Property (a Quality observable by a sensor) of that feature.
    /// <see href="https://www.w3.org/ns/ssn/isPropertyOf"></see></summary>
    let isPropertyOf = _prefix "isPropertyOf"
    /// <summary>
    /// The smallest difference in the value of a quality being observed that would result in perceptably different values of observation results.
    /// <see href="https://www.w3.org/ns/ssn/Resolution"></see></summary>
    let Resolution = _prefix "Resolution"
    /// <summary>
    /// The time between a (step) change inthe value of an observed quality and a sensor (possibly with specified error) 'settling' on an observed value.
    /// <see href="https://www.w3.org/ns/ssn/ResponseTime"></see></summary>
    let ResponseTime = _prefix "ResponseTime"
    /// <summary>
    /// Selectivity is a property of a sensor whereby it provides observed values for one or more qualities such that the values of each quality are independent of other qualities in the phenomenon, body, or substance being investigated.
    /// <see href="https://www.w3.org/ns/ssn/Selectivity"></see></summary>
    let Selectivity = _prefix "Selectivity"
    /// <summary>
    /// A sensing device is a device that implements sensing.
    /// <see href="https://www.w3.org/ns/ssn/SensingDevice"></see></summary>
    let SensingDevice = _prefix "SensingDevice"
    /// <summary>
    /// Sensitivity is the quotient of the change in a result of sensor and the corresponding change in a value of a quality being observed.
    /// <see href="https://www.w3.org/ns/ssn/Sensitivity"></see></summary>
    let Sensitivity = _prefix "Sensitivity"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/ssn/observes"></see>
    /// </summary>
    let observes = _prefix "observes"
    /// <summary>
    /// Relation from a Sensor to a MeasurementCapability describing the measurement properties of the sensor.
    /// <see href="https://www.w3.org/ns/ssn/hasMeasurementCapability"></see></summary>
    let hasMeasurementCapability = _prefix "hasMeasurementCapability"
    /// <summary>
    /// A relation between an entity that implements a method in some executable way and the description of an algorithm, procedure or method.  For example, between a Sensor and the scientific measuring method that the Sensor uses to observe a Property.
    /// <see href="https://www.w3.org/ns/ssn/implements"></see></summary>
    let implements = _prefix "implements"
    /// <summary>
    /// A relation from a sensor to the Stimulus that the sensor can detect.
    /// The Stimulus itself will be serving as a proxy for (see isProxyOf) some observable property.
    /// <see href="https://www.w3.org/ns/ssn/detects"></see></summary>
    let detects = _prefix "detects"
    /// <summary>
    /// A data sheet records properties of a sensor.  A data sheet might describe for example the accuracy in various conditions, the power use, the types of connectors that the sensor has, etc.
    ///
    /// Generally a sensor's properties are recorded directly (with hasMeasurementCapability, for example), but the data sheet can be used for example to record the manufacturers specifications verses observed capabilites, or if more is known than the manufacturer specifies, etc.  The data sheet is an information object about the sensor's properties, rather than a direct link to the actual properties themselves.
    /// <see href="https://www.w3.org/ns/ssn/SensorDataSheet"></see></summary>
    let SensorDataSheet = _prefix "SensorDataSheet"
    /// <summary>
    /// Relation between a producer and a produced entity: for example, between a sensor and the produced output.
    /// <see href="https://www.w3.org/ns/ssn/isProducedBy"></see></summary>
    let isProducedBy = _prefix "isProducedBy"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/ssn/hasValue"></see>
    /// </summary>
    let hasValue = _prefix "hasValue"
    /// <summary>
    /// A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.  For example, the expansion of the quicksilver is a stimulus that serves as a proxy for temperature, or an increase or decrease in the spinning of cups on a wind sensor is serving as a proxy for wind speed.
    /// <see href="https://www.w3.org/ns/ssn/isProxyFor"></see></summary>
    let isProxyFor = _prefix "isProxyFor"
    /// <summary>
    /// The conditions a sensor can be exposed to without damage: i.e., the sensor continues to operate as defined using MeasurementCapability.  If, however, the SurvivalRange is exceeded, the sensor is 'damaged' and MeasurementCapability specifications may no longer hold.
    /// <see href="https://www.w3.org/ns/ssn/SurvivalRange"></see></summary>
    let SurvivalRange = _prefix "SurvivalRange"
    /// <summary>
    /// Relation from a SurvivalRange to a Property describing the survial range of a system.  For example, to the temperature extreme that a system can withstand before being considered damaged.
    /// <see href="https://www.w3.org/ns/ssn/hasSurvivalProperty"></see></summary>
    let hasSurvivalProperty = _prefix "hasSurvivalProperty"
    /// <summary>
    /// Haspart relation between a system and its parts.
    /// <see href="https://www.w3.org/ns/ssn/hasSubSystem"></see></summary>
    let hasSubSystem = _prefix "hasSubSystem"
    /// <summary>
    /// Relation from a System to an OperatingRange describing the normal operating environment of the System.
    /// <see href="https://www.w3.org/ns/ssn/hasOperatingRange"></see></summary>
    let hasOperatingRange = _prefix "hasOperatingRange"
    /// <summary>
    /// A Relation from a System to a SurvivalRange.
    /// <see href="https://www.w3.org/ns/ssn/hasSurvivalRange"></see></summary>
    let hasSurvivalRange = _prefix "hasSurvivalRange"
    /// <summary>
    /// Relation between a System (e.g., a Sensor) and a Platform.  The relation locates the sensor relative to other described entities entities: i.e., the Sensor s1's location is Platform p1.  More precise locations for sensors in space (relative to other entities, where attached to another entity, or in 3D space) are made using DOLCE's Regions (SpaceRegion).
    /// <see href="https://www.w3.org/ns/ssn/onPlatform"></see></summary>
    let onPlatform = _prefix "onPlatform"
    /// <summary>
    /// Relation between a System and a Deployment, recording that the System/Sensor was deployed in that Deployment.
    /// <see href="https://www.w3.org/ns/ssn/hasDeployment"></see></summary>
    let hasDeployment = _prefix "hasDeployment"
    /// <summary>
    /// Total useful life of a sensor/system (expressed as total life since manufacture, time in use, number of operations, etc.).
    /// <see href="https://www.w3.org/ns/ssn/SystemLifetime"></see></summary>
    let SystemLifetime = _prefix "SystemLifetime"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/ssn/featureInObservation"></see>
    /// </summary>
    let featureInObservation = _prefix "featureInObservation"
    /// <summary>
    /// A relation between the description of an algorithm, procedure or method and an entity that implements that method in some executable way.  For example, between a scientific measuring method and a sensor the senses via that method.
    /// <see href="https://www.w3.org/ns/ssn/implementedBy"></see></summary>
    let implementedBy = _prefix "implementedBy"
    /// <summary>
    /// Relation between a Sensor and Observations it has made.
    /// <see href="https://www.w3.org/ns/ssn/madeObservation"></see></summary>
    let madeObservation = _prefix "madeObservation"
    /// <summary>
    /// The result time is the time when the procedure associated with the observation act was applied.
    /// The result time shall describe the time when the result became available, typically when the procedure associated with the observation was completed For some observations this is identical to the phenomenonTime. However, there are important cases where they differ.[O&amp;M]
    /// <see href="https://www.w3.org/ns/ssn/observationResultTime"></see></summary>
    let observationResultTime = _prefix "observationResultTime"
    /// <summary>
    /// The sampling time is the time that the result applies to the feature-of-interest. This is the time usually required for geospatial analysis of the result.
    /// Rebadged as phenomenon time in [O&amp;M]. The phenomenon time shall describe the time that the result applies to the property of the feature-of-interest. This is often the time of interaction by a sampling procedure or observation procedure with a real-world feature.
    /// <see href="https://www.w3.org/ns/ssn/observationSamplingTime"></see></summary>
    let observationSamplingTime = _prefix "observationSamplingTime"
    /// <summary>
    /// A relation between some aspect of a sensing entity and a feature.  For example, from a sensor to the features it can observe properties of, or from a deployment to the features it was installed to observe.  Also from a measurement capability to the feature the capability is described for.  (Used in conjunction with forProperty).
    /// <see href="https://www.w3.org/ns/ssn/ofFeature"></see></summary>
    let ofFeature = _prefix "ofFeature"
    /// <summary>
    /// The chain here means that if a sensor made an observation and that observation has a result, then the result is the one produced by the sensor.  Just ensures that the sensor and the resulting observation agree on the result.
    /// <see href="https://www.w3.org/ns/ssn/produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// Relation linking an Observation to the adjudged quality of the result.  This is of course complimentary to the MeasurementCapability information recorded for the Sensor that made the Observation.
    /// <see href="https://www.w3.org/ns/ssn/qualityOfObservation"></see></summary>
    let qualityOfObservation = _prefix "qualityOfObservation"
