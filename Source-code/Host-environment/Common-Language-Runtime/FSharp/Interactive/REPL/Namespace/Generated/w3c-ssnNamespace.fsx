#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ``w3c-ssn`` =
    let _prefixId = PrefixId.fromNamespaceLabel "https://www.w3.org/ns/ssn/" "w3c-ssn"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'measurement accuracy/accuracy' [VIM 2.13]
    /// 		                    http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Accuracy^^xsd:string</para>
    ///   <para>rdfs:comment : The closeness of agreement between the value of an observation and the true value of the observed quality.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Accuracy">w3c-ssn:Accuracy</a>
    /// </summary>
    let Accuracy = _prefixId.prefix "Accuracy"
    /// <summary>
    ///   <para>rdfs:label : Battery Lifetime^^xsd:string</para>
    ///   <para>rdfs:comment : Total useful life of a battery.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/BatteryLifetime">w3c-ssn:BatteryLifetime</a>
    /// </summary>
    let BatteryLifetime = _prefixId.prefix "BatteryLifetime"
    /// <summary>
    ///   <para>rdfs:label : Condition^^xsd:string</para>
    ///   <para>rdfs:comment : Used to specify ranges for qualities that act as conditions on a system/sensor's operation.  For example, wind speed of 10-60m/s is expressed as a condition linking a quality, wind speed, a unit of measurement, metres per second, and a set of values, 10-60, and may be used as the condition on a MeasurementProperty, for example, to state that a sensor has a particular accuracy in that condition.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Condition">w3c-ssn:Condition</a>
    /// </summary>
    let Condition = _prefixId.prefix "Condition"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch 'Deployment' [MMI Dev]
    ///                                  http://marinemetadata.org/community/teams/ontdevices^^xsd:string</para>
    ///   <para>rdfs:label : Deployment^^xsd:string</para>
    ///   <para>rdfs:comment : The ongoing Process of Entities (for the purposes of this ontology, mainly sensors) deployed for a particular purpose.  For example, a particular Sensor deployed on a Platform, or a whole network of Sensors deployed for an observation campaign.  The deployment may have sub processes, such as installation, maintenance, addition, and decomissioning and removal.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Deployment">w3c-ssn:Deployment</a>
    /// </summary>
    let Deployment = _prefixId.prefix "Deployment"
    /// <summary>
    ///   <para>rdfs:label : Deployment-related Process^^xsd:string</para>
    ///   <para>rdfs:comment : Place to group all the various Processes related to Deployment.  For example, as well as Deplyment, installation, maintenance, deployment of further sensors and the like would all be classified under DeploymentRelatedProcess.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/DeploymentRelatedProcess">w3c-ssn:DeploymentRelatedProcess</a>
    /// </summary>
    let DeploymentRelatedProcess = _prefixId.prefix "DeploymentRelatedProcess"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'detection limit' [VIM 4.18]
    ///                                  http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : detection limit^^xsd:string</para>
    ///   <para>rdfs:comment : An observed value for which the probability of falsely claiming the absence of a component in a material is Î², given a probability Î± of falsely claiming its presence.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/DetectionLimit">w3c-ssn:DetectionLimit</a>
    /// </summary>
    let DetectionLimit = _prefixId.prefix "DetectionLimit"
    /// <summary>
    ///   <para>rdfs:label : Device^^xsd:string</para>
    ///   <para>rdfs:comment : A device is a physical piece of technology - a system in a box. Devices may of course be built of smaller devices and software components (i.e. systems have components).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Device">w3c-ssn:Device</a>
    /// </summary>
    let Device = _prefixId.prefix "Device"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'instrumental drift' [VIM 4.21]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Drift^^xsd:string</para>
    ///   <para>rdfs:comment : A, continuous or incremental, change in the reported values of observations over time for an unchanging quality.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Drift">w3c-ssn:Drift</a>
    /// </summary>
    let Drift = _prefixId.prefix "Drift"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'feature' [O&amp;M]
    /// 		                    http://www.opengeospatial.org/standards/om^^xsd:string</para>
    ///   <para>rdfs:label : Feature of Interest^^xsd:string</para>
    ///   <para>rdfs:comment : A feature is an abstraction of real world phenomena (thing, person, event, etc).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/FeatureOfInterest">w3c-ssn:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : Maintenance Schedule^^xsd:string</para>
    ///   <para>rdfs:comment : Schedule of maintenance for a system/sensor in the specified conditions.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/MaintenanceSchedule">w3c-ssn:MaintenanceSchedule</a>
    /// </summary>
    let MaintenanceSchedule = _prefixId.prefix "MaintenanceSchedule"
    /// <summary>
    ///   <para>dce:source : Similar idea to MeasurementCapability in MMI Device Ontology
    ///                                   http://marinemetadata.org/community/teams/ontdevices
    ///
    /// But the the two express the relationship between constraints and multiple measurement properties differently.
    ///
    /// The conditions linked to a MeasurementCapability are skos:exactMatch to 'influence quantity' [VIM 2.52]
    /// http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Measurement Capability^^xsd:string</para>
    ///   <para>rdfs:comment : Collects together measurement properties (accuracy, range, precision, etc) and the environmental conditions in which those properties hold, representing a specification of a sensor's capability in those conditions.
    ///
    /// The conditions specified here are those that affect the measurement properties, while those in OperatingRange represent the sensor's standard operating conditions, including conditions that don't affect the observations.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/MeasurementCapability">w3c-ssn:MeasurementCapability</a>
    /// </summary>
    let MeasurementCapability = _prefixId.prefix "MeasurementCapability"
    /// <summary>
    ///   <para>rdfs:label : MeasurementFrequency^^xsd:string</para>
    ///   <para>rdfs:comment : The smallest possible time between one observation and the next.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/MeasurementFrequency">w3c-ssn:MeasurementFrequency</a>
    /// </summary>
    let MeasurementFrequency = _prefixId.prefix "MeasurementFrequency"
    /// <summary>
    ///   <para>rdfs:label : MeasurementLatency^^xsd:string</para>
    ///   <para>rdfs:comment : The time between a request for an observation and the sensor producing a result (not including network latency to retrieve the result, just time from request to measurement.).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/MeasurementLatency">w3c-ssn:MeasurementLatency</a>
    /// </summary>
    let MeasurementLatency = _prefixId.prefix "MeasurementLatency"
    /// <summary>
    ///   <para>rdfs:label : Measurement Property^^xsd:string</para>
    ///   <para>rdfs:comment : An identifiable and observable characteristic of a sensor's observations or ability to make observations.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/MeasurementProperty">w3c-ssn:MeasurementProperty</a>
    /// </summary>
    let MeasurementProperty = _prefixId.prefix "MeasurementProperty"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'measuring interval/measurement range' [VIM 4.7]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Measurement Range^^xsd:string</para>
    ///   <para>rdfs:comment : The set of values that the sensor can return as the result of an observation under the defined conditions with the defined measurement properties.  (If no conditions are specified or the conditions do not specify a range for the observed qualities, the measurement range is to be taken as the condition for the observed qualities.)^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/MeasurementRange">w3c-ssn:MeasurementRange</a>
    /// </summary>
    let MeasurementRange = _prefixId.prefix "MeasurementRange"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch 'observation' [O&amp;M]
    /// 		                    http://www.opengeospatial.org/standards/om
    ///
    /// Observation in this ontology and O&amp;M are described differently (O&amp;M records an observation as an act/event), but they record the same thing and are essentially interchangeable.  The difference is in the ontological structure of the two, not the data or use.
    ///
    /// Observation here records a Situation (the estimation of the value of a Property) and a description of the method that was used (along with the participants), while O&amp;M interprets an Observation as the event itself; there must, however, have been an event that lead to our situation, so both are records of events.  The distinction is between the event itself and the record of what happened in that event.
    ///
    ///
    /// skos:closeMatch 'measurement result' [VIM 2.9] http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf
    ///
    /// Measurement result in VIM is the measured value plus any other relevant information, which means that measurement result and observation will often be associated to the same data (a value, a time, a property, etc.).^^xsd:string</para>
    ///   <para>rdfs:comment : An Observation is a Situation in which a Sensing method has been used to estimate or calculate a value of a Property of a FeatureOfInterest.  Links to Sensing and Sensor describe what made the Observation and how; links to Property and Feature detail what was sensed; the result is the output of a Sensor; other metadata details times etc.^^xsd:string</para>
    ///   <para>rdfs:label : Observation^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Observation">w3c-ssn:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'measured quantity value' [VIM 2.10]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf
    ///
    /// skos:exactMatch 'observed value' [SensorML OGC-0700]
    /// http://www.opengeospatial.org/standards/sensorml
    ///
    /// skos:closeMatch 'observation result' [O&amp;M]
    /// http://www.opengeospatial.org/standards/om
    ///
    /// O&amp;M conflates what we have as SensorOutput and ObservationValue into observation result, though the OGC standard does say "result contains a value" and "a result which has a value", which fits naturally with the model here.^^xsd:string</para>
    ///   <para>rdfs:label : Observation Value^^xsd:string</para>
    ///   <para>rdfs:comment : The value of the result of an Observation.  An Observation has a result which is the output of some sensor, the result is an information object that encodes some value for a Feature.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/ObservationValue">w3c-ssn:ObservationValue</a>
    /// </summary>
    let ObservationValue = _prefixId.prefix "ObservationValue"
    /// <summary>
    ///   <para>rdfs:label : Operating Power Range^^xsd:string</para>
    ///   <para>rdfs:comment : Power range in which system/sensor is expected to operate.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/OperatingPowerRange">w3c-ssn:OperatingPowerRange</a>
    /// </summary>
    let OperatingPowerRange = _prefixId.prefix "OperatingPowerRange"
    /// <summary>
    ///   <para>rdfs:label : Operating Property^^xsd:string</para>
    ///   <para>rdfs:comment : An identifiable characteristic of the environmental and other conditions in which the sensor is intended to operate.  May include power ranges, power sources, standard configurations, attachments and the like.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/OperatingProperty">w3c-ssn:OperatingProperty</a>
    /// </summary>
    let OperatingProperty = _prefixId.prefix "OperatingProperty"
    /// <summary>
    ///   <para>dce:source : skos:broaderMatch 'reference operating condition' [VIM 4.11]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf
    ///
    /// The difference is that here we also allow for qualities that aren't VIM influence quantities [VIM 2.52] - for example, a quantity that alters the power requirements, but doesn't affect the measurement properties - conditions specified in MeasurementCapability should be influence quantities.^^xsd:string</para>
    ///   <para>rdfs:label : Operating Range^^xsd:string</para>
    ///   <para>rdfs:comment : The environmental conditions and characteristics of a system/sensor's normal operating environment.  Can be used to specify for example the standard environmental conditions in which the sensor is expected to operate (a Condition with no OperatingProperty), or how the environmental and other operating properties relate: i.e., that the maintenance schedule or power requirements differ according to the conditions.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/OperatingRange">w3c-ssn:OperatingRange</a>
    /// </summary>
    let OperatingRange = _prefixId.prefix "OperatingRange"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'platform' [SensorML OGC-0700]
    ///                                   http://www.opengeospatial.org/standards/sensorml^^xsd:string</para>
    ///   <para>rdfs:label : Platform^^xsd:string</para>
    ///   <para>rdfs:comment : An Entity to which other Entities can be attached - particuarly Sensors and other Platforms.  For example, a post might act as the Platform, a bouy might act as a Platform, or a fish might act as a Platform for an attached sensor.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Platform">w3c-ssn:Platform</a>
    /// </summary>
    let Platform = _prefixId.prefix "Platform"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'measurement precision/precision' [VIM 2.15]
    ///                                    http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Precision^^xsd:string</para>
    ///   <para>rdfs:comment : The closeness of agreement between replicate observations on an unchanged or similar quality value: i.e., a measure of a sensor's ability to consitently reproduce an observation.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Precision">w3c-ssn:Precision</a>
    /// </summary>
    let Precision = _prefixId.prefix "Precision"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'property' [O&amp;M]
    /// 		                    http://www.opengeospatial.org/standards/om^^xsd:string</para>
    ///   <para>rdfs:label : Property^^xsd:string</para>
    ///   <para>rdfs:comment : An observable Quality of an Event or Object.  That is, not a quality of an abstract entity as is also allowed by DUL's Quality, but rather an aspect of an entity that is intrinsic to and cannot exist without the entity and is observable by a sensor.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Property">w3c-ssn:Property</a>
    /// </summary>
    let Property = _prefixId.prefix "Property"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'resolution' [VIM 4.14]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Resolution^^xsd:string</para>
    ///   <para>rdfs:comment : The smallest difference in the value of a quality being observed that would result in perceptably different values of observation results.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Resolution">w3c-ssn:Resolution</a>
    /// </summary>
    let Resolution = _prefixId.prefix "Resolution"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'step response time' [VIM 4.23]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Response time^^xsd:string</para>
    ///   <para>rdfs:comment : The time between a (step) change inthe value of an observed quality and a sensor (possibly with specified error) 'settling' on an observed value.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/ResponseTime">w3c-ssn:ResponseTime</a>
    /// </summary>
    let ResponseTime = _prefixId.prefix "ResponseTime"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'selectivity' [VIM 4.13]
    ///                                  http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Selectivity^^xsd:string</para>
    ///   <para>rdfs:comment : Selectivity is a property of a sensor whereby it provides observed values for one or more qualities such that the values of each quality are independent of other qualities in the phenomenon, body, or substance being investigated.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Selectivity">w3c-ssn:Selectivity</a>
    /// </summary>
    let Selectivity = _prefixId.prefix "Selectivity"
    /// <summary>
    ///   <para>dce:source : http://www.w3.org/2005/Incubator/sso/^^xsd:string</para>
    ///   <para>rdfs:label : Sensing^^xsd:string</para>
    ///   <para>rdfs:comment : The description of a process (i.e. describes the temporal and dataflow dependencies and relationships amongst its parts) that results in the estimation, or calculation, of the value of a phenomenon.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Sensing">w3c-ssn:Sensing</a>
    /// </summary>
    let Sensing = _prefixId.prefix "Sensing"
    /// <summary>
    ///   <para>rdfs:label : Sensing Device^^xsd:string</para>
    ///   <para>rdfs:comment : A sensing device is a device that implements sensing.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/SensingDevice">w3c-ssn:SensingDevice</a>
    /// </summary>
    let SensingDevice = _prefixId.prefix "SensingDevice"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'sensitivity' [VIM 4.12]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Sensitivity^^xsd:string</para>
    ///   <para>rdfs:comment : Sensitivity is the quotient of the change in a result of sensor and the corresponding change in a value of a quality being observed.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Sensitivity">w3c-ssn:Sensitivity</a>
    /// </summary>
    let Sensitivity = _prefixId.prefix "Sensitivity"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'sensor' [SensorML OGC-0700]
    /// 		                    http://www.opengeospatial.org/standards/sensorml
    ///
    ///                                 skos:closeMatch 'observation procedure' [O&amp;M]
    ///                                 http://www.opengeospatial.org/standards/om
    ///
    /// O&amp;M allows sensors, methods, instruments, systems, algorithms and process chains as the processUsed of an observation; this ontology allows a similar range of things (any thing that can do sensing), just they are all grouped under the term sensor (which is thus wider than the O&amp;M concept).^^xsd:string</para>
    ///   <para>rdfs:label : Sensor^^xsd:string</para>
    ///   <para>rdfs:comment : A sensor can do (implements) sensing: that is, a sensor is any entity that can follow a sensing method and thus observe some Property of a FeatureOfInterest.  Sensors may be physical devices, computational methods, a laboratory setup with a person following a method, or any other thing that can follow a Sensing Method to observe a Property.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Sensor">w3c-ssn:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Sensor Data Sheet^^xsd:string</para>
    ///   <para>rdfs:comment : A data sheet records properties of a sensor.  A data sheet might describe for example the accuracy in various conditions, the power use, the types of connectors that the sensor has, etc.
    ///
    /// Generally a sensor's properties are recorded directly (with hasMeasurementCapability, for example), but the data sheet can be used for example to record the manufacturers specifications verses observed capabilites, or if more is known than the manufacturer specifies, etc.  The data sheet is an information object about the sensor's properties, rather than a direct link to the actual properties themselves.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/SensorDataSheet">w3c-ssn:SensorDataSheet</a>
    /// </summary>
    let SensorDataSheet = _prefixId.prefix "SensorDataSheet"
    /// <summary>
    ///   <para>dce:source : http://www.w3.org/2005/Incubator/ssn/
    ///
    ///                                   skos:closeMatch 'observation result' [O&amp;M]
    ///                                   http://www.opengeospatial.org/standards/om
    ///
    /// See comments at ObservationValue.^^xsd:string</para>
    ///   <para>rdfs:label : Sensor Output^^xsd:string</para>
    ///   <para>rdfs:comment : A sensor outputs a piece of information (an observed value), the value itself being represented by an ObservationValue.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/SensorOutput">w3c-ssn:SensorOutput</a>
    /// </summary>
    let SensorOutput = _prefixId.prefix "SensorOutput"
    /// <summary>
    ///   <para>dce:source : http://www.w3.org/2005/Incubator/sso/^^xsd:string</para>
    ///   <para>rdfs:label : Stimulus^^xsd:string</para>
    ///   <para>rdfs:comment : An Event in the real world that 'triggers' the sensor.  The properties associated to the stimulus may be different to eventual observed property.  It is the event, not the object that triggers the sensor.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/Stimulus">w3c-ssn:Stimulus</a>
    /// </summary>
    let Stimulus = _prefixId.prefix "Stimulus"
    /// <summary>
    ///   <para>rdfs:label : Survival Property^^xsd:string</para>
    ///   <para>rdfs:comment : An identifiable characteristic that represents the extent of the sensors useful life.  Might include for example total battery life or number of recharges, or, for sensors that are used only a fixed number of times, the number of observations that can be made before the sensing capability is depleted.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/SurvivalProperty">w3c-ssn:SurvivalProperty</a>
    /// </summary>
    let SurvivalProperty = _prefixId.prefix "SurvivalProperty"
    /// <summary>
    ///   <para>dce:source : skos:narrowerMatch 'limiting operating condition' [VIM 4.10]
    ///                                   http://www.bipm.org/utils/common/documents/jcgm/JCGM_200_2008.pdf^^xsd:string</para>
    ///   <para>rdfs:label : Survival Range^^xsd:string</para>
    ///   <para>rdfs:comment : The conditions a sensor can be exposed to without damage: i.e., the sensor continues to operate as defined using MeasurementCapability.  If, however, the SurvivalRange is exceeded, the sensor is 'damaged' and MeasurementCapability specifications may no longer hold.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/SurvivalRange">w3c-ssn:SurvivalRange</a>
    /// </summary>
    let SurvivalRange = _prefixId.prefix "SurvivalRange"
    /// <summary>
    ///   <para>rdfs:label : System^^xsd:string</para>
    ///   <para>rdfs:comment : System is a unit of abstraction for pieces of infrastructure (and we largely care that they are) for sensing. A system has components, its subsystems, which are other systems.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/System">w3c-ssn:System</a>
    /// </summary>
    let System = _prefixId.prefix "System"
    /// <summary>
    ///   <para>rdfs:label : System Lifetime^^xsd:string</para>
    ///   <para>rdfs:comment : Total useful life of a sensor/system (expressed as total life since manufacture, time in use, number of operations, etc.).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/SystemLifetime">w3c-ssn:SystemLifetime</a>
    /// </summary>
    let SystemLifetime = _prefixId.prefix "SystemLifetime"
    /// <summary>
    ///   <para>rdfs:label : attached system^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a Platform and any Systems (e.g., Sensors) that are attached to the Platform.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/attachedSystem">w3c-ssn:attachedSystem</a>
    /// </summary>
    let attachedSystem = _prefixId.prefix "attachedSystem"
    /// <summary>
    ///   <para>rdfs:label : deployed on platform^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a deployment and the platform on which the system was deployed.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/deployedOnPlatform">w3c-ssn:deployedOnPlatform</a>
    /// </summary>
    let deployedOnPlatform = _prefixId.prefix "deployedOnPlatform"
    /// <summary>
    ///   <para>rdfs:label : deployed system^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a deployment and the deployed system.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/deployedSystem">w3c-ssn:deployedSystem</a>
    /// </summary>
    let deployedSystem = _prefixId.prefix "deployedSystem"
    /// <summary>
    ///   <para>rdfs:label : deployment process part^^xsd:string</para>
    ///   <para>rdfs:comment : Has part relation between a deployment process and its constituent processes.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/deploymentProcessPart">w3c-ssn:deploymentProcessPart</a>
    /// </summary>
    let deploymentProcessPart = _prefixId.prefix "deploymentProcessPart"
    /// <summary>
    ///   <para>rdfs:label : detects^^xsd:string</para>
    ///   <para>rdfs:comment : A relation from a sensor to the Stimulus that the sensor can detect.
    /// The Stimulus itself will be serving as a proxy for (see isProxyOf) some observable property.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/detects">w3c-ssn:detects</a>
    /// </summary>
    let detects = _prefixId.prefix "detects"
    let featureInObservation = _prefixId.prefix "featureInObservation"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'featureOfInterest' [O&amp;M - ISO/DIS 19156]
    /// 		                    http://portal.opengeospatial.org/files/?artifact_id=41579^^xsd:string</para>
    ///   <para>rdfs:label : feature of interest^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between an observation and the entity whose quality was observed.   For example, in an observation of the weight of a person, the feature of interest is the person and the quality is weight.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/featureOfInterest">w3c-ssn:featureOfInterest</a>
    /// </summary>
    let featureOfInterest = _prefixId.prefix "featureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : for property^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between some aspect of a sensing entity and a property.  For example, from a sensor to the properties it can observe, or from a deployment to the properties it was installed to observe.  Also from a measurement capability to the property the capability is described for.  (Used in conjunction with ofFeature).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/forProperty">w3c-ssn:forProperty</a>
    /// </summary>
    let forProperty = _prefixId.prefix "forProperty"
    let fromStimulus = _prefixId.prefix "fromStimulus"
    /// <summary>
    ///   <para>rdfs:label : has deployment^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a System and a Deployment, recording that the System/Sensor was deployed in that Deployment.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasDeployment">w3c-ssn:hasDeployment</a>
    /// </summary>
    let hasDeployment = _prefixId.prefix "hasDeployment"
    /// <summary>
    ///   <para>rdfs:label : has measurement capability^^xsd:string</para>
    ///   <para>rdfs:comment : Relation from a Sensor to a MeasurementCapability describing the measurement properties of the sensor.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasMeasurementCapability">w3c-ssn:hasMeasurementCapability</a>
    /// </summary>
    let hasMeasurementCapability = _prefixId.prefix "hasMeasurementCapability"
    /// <summary>
    ///   <para>rdfs:label : has measurement property^^xsd:string</para>
    ///   <para>rdfs:comment : Relation from a MeasurementCapability to a MeasurementProperty.  For example, to an accuracy (see notes at MeasurementCapability).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasMeasurementProperty">w3c-ssn:hasMeasurementProperty</a>
    /// </summary>
    let hasMeasurementProperty = _prefixId.prefix "hasMeasurementProperty"
    /// <summary>
    ///   <para>rdfs:label : has operating property^^xsd:string</para>
    ///   <para>rdfs:comment : Relation from an OperatingRange to a Property.  For example, to a battery lifetime.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasOperatingProperty">w3c-ssn:hasOperatingProperty</a>
    /// </summary>
    let hasOperatingProperty = _prefixId.prefix "hasOperatingProperty"
    /// <summary>
    ///   <para>rdfs:label : has operating range^^xsd:string</para>
    ///   <para>rdfs:comment : Relation from a System to an OperatingRange describing the normal operating environment of the System.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasOperatingRange">w3c-ssn:hasOperatingRange</a>
    /// </summary>
    let hasOperatingRange = _prefixId.prefix "hasOperatingRange"
    /// <summary>
    ///   <para>rdfs:label : has property^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between a FeatureOfInterest and a Property of that feature.^^xsd:stringrdfs:comment : The chain here ensures that the observed property of an observation is a property of the feature of interest.  This restriction is written in O&amp;M; here we can enforce it formally.
    ///
    /// The more obvious formulation:
    ///
    /// featureOfInterest o hasProperty SubPropertyOf observedProperty
    ///
    /// can't be used, because (by the OWL2 decidability restrictions) that would mean cardinality restrictions couldn't be applied to observedProperty (see definition of Observation).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasProperty">w3c-ssn:hasProperty</a>
    /// </summary>
    let hasProperty = _prefixId.prefix "hasProperty"
    /// <summary>
    ///   <para>rdfs:label : has subsystem^^xsd:string</para>
    ///   <para>rdfs:comment : Haspart relation between a system and its parts.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasSubSystem">w3c-ssn:hasSubSystem</a>
    /// </summary>
    let hasSubSystem = _prefixId.prefix "hasSubSystem"
    /// <summary>
    ///   <para>rdfs:label : has survival property^^xsd:string</para>
    ///   <para>rdfs:comment : Relation from a SurvivalRange to a Property describing the survial range of a system.  For example, to the temperature extreme that a system can withstand before being considered damaged.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasSurvivalProperty">w3c-ssn:hasSurvivalProperty</a>
    /// </summary>
    let hasSurvivalProperty = _prefixId.prefix "hasSurvivalProperty"
    /// <summary>
    ///   <para>rdfs:label : has survival range^^xsd:string</para>
    ///   <para>rdfs:comment : A Relation from a System to a SurvivalRange.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasSurvivalRange">w3c-ssn:hasSurvivalRange</a>
    /// </summary>
    let hasSurvivalRange = _prefixId.prefix "hasSurvivalRange"
    /// <summary>
    ///   <para>rdfs:label : has value^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/hasValue">w3c-ssn:hasValue</a>
    /// </summary>
    let hasValue = _prefixId.prefix "hasValue"
    /// <summary>
    ///   <para>rdfs:label : implemented by^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between the description of an algorithm, procedure or method and an entity that implements that method in some executable way.  For example, between a scientific measuring method and a sensor the senses via that method.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/implementedBy">w3c-ssn:implementedBy</a>
    /// </summary>
    let implementedBy = _prefixId.prefix "implementedBy"
    /// <summary>
    ///   <para>rdfs:label : implements^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between an entity that implements a method in some executable way and the description of an algorithm, procedure or method.  For example, between a Sensor and the scientific measuring method that the Sensor uses to observe a Property.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/implements">w3c-ssn:implements</a>
    /// </summary>
    let implements = _prefixId.prefix "implements"
    /// <summary>
    ///   <para>rdfs:label : in condition^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the prevailing environmental conditions for MeasurementCapabilites, OperatingConditions and SurvivalRanges.  Used for example to say that a sensor has a particular accuracy in particular conditions.  (see also MeasurementCapability)^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/inCondition">w3c-ssn:inCondition</a>
    /// </summary>
    let inCondition = _prefixId.prefix "inCondition"
    /// <summary>
    ///   <para>rdfs:label : in deployment^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a Platform and a Deployment, recording that the object was used as a platform for a system/sensor for a particular deployment: as in this PhysicalObject is acting as a Platform inDeployment Deployment.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/inDeployment">w3c-ssn:inDeployment</a>
    /// </summary>
    let inDeployment = _prefixId.prefix "inDeployment"
    /// <summary>
    ///   <para>rdfs:label : is produced by^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a producer and a produced entity: for example, between a sensor and the produced output.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/isProducedBy">w3c-ssn:isProducedBy</a>
    /// </summary>
    let isProducedBy = _prefixId.prefix "isProducedBy"
    /// <summary>
    ///   <para>rdfs:label : is property of^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a FeatureOfInterest and a Property (a Quality observable by a sensor) of that feature.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/isPropertyOf">w3c-ssn:isPropertyOf</a>
    /// </summary>
    let isPropertyOf = _prefixId.prefix "isPropertyOf"
    /// <summary>
    ///   <para>rdfs:label : isProxyFor^^xsd:string</para>
    ///   <para>rdfs:comment : A relation from a Stimulus to the Property that the Stimulus is serving as a proxy for.  For example, the expansion of the quicksilver is a stimulus that serves as a proxy for temperature, or an increase or decrease in the spinning of cups on a wind sensor is serving as a proxy for wind speed.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/isProxyFor">w3c-ssn:isProxyFor</a>
    /// </summary>
    let isProxyFor = _prefixId.prefix "isProxyFor"
    let isValueOf = _prefixId.prefix "isValueOf"
    /// <summary>
    ///   <para>rdfs:label : made observation^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a Sensor and Observations it has made.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/madeObservation">w3c-ssn:madeObservation</a>
    /// </summary>
    let madeObservation = _prefixId.prefix "madeObservation"
    /// <summary>
    ///   <para>dce:source : skos:closeMatch 'result' [O&amp;M - ISO/DIS 19156]
    /// 		                    http://portal.opengeospatial.org/files/?artifact_id=41579^^xsd:string</para>
    ///   <para>rdfs:label : observation result^^xsd:string</para>
    ///   <para>rdfs:comment : Relation linking an Observation (i.e., a description of the context, the Situation, in which the observatioin was made) and a Result, which contains a value representing the value associated with the observed Property.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/observationResult">w3c-ssn:observationResult</a>
    /// </summary>
    let observationResult = _prefixId.prefix "observationResult"
    /// <summary>
    ///   <para>dce:source : http://www.opengeospatial.org/standards/om^^xsd:string</para>
    ///   <para>rdfs:label : observation result time^^xsd:string</para>
    ///   <para>rdfs:comment : The result time is the time when the procedure associated with the observation act was applied.^^xsd:stringrdfs:comment : The result time shall describe the time when the result became available, typically when the procedure associated with the observation was completed For some observations this is identical to the phenomenonTime. However, there are important cases where they differ.[O&amp;M]^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/observationResultTime">w3c-ssn:observationResultTime</a>
    /// </summary>
    let observationResultTime = _prefixId.prefix "observationResultTime"
    /// <summary>
    ///   <para>dce:source : http://www.opengeospatial.org/standards/om^^xsd:string</para>
    ///   <para>rdfs:label : observation sampling time^^xsd:string</para>
    ///   <para>rdfs:comment : The sampling time is the time that the result applies to the feature-of-interest. This is the time usually required for geospatial analysis of the result.^^xsd:stringrdfs:comment : Rebadged as phenomenon time in [O&amp;M]. The phenomenon time shall describe the time that the result applies to the property of the feature-of-interest. This is often the time of interaction by a sampling procedure or observation procedure with a real-world feature.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/observationSamplingTime">w3c-ssn:observationSamplingTime</a>
    /// </summary>
    let observationSamplingTime = _prefixId.prefix "observationSamplingTime"
    let observedBy = _prefixId.prefix "observedBy"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'observedProperty' [O&amp;M - ISO/DIS 19156]
    /// 		                    http://portal.opengeospatial.org/files/?artifact_id=41579^^xsd:string</para>
    ///   <para>rdfs:label : observed property^^xsd:string</para>
    ///   <para>rdfs:comment : Relation linking an Observation to the Property that was observed.  The observedProperty should be a Property (hasProperty) of the FeatureOfInterest (linked by featureOfInterest) of this observation.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/observedProperty">w3c-ssn:observedProperty</a>
    /// </summary>
    let observedProperty = _prefixId.prefix "observedProperty"
    let observes = _prefixId.prefix "observes"
    /// <summary>
    ///   <para>rdfs:label : of feature^^xsd:string</para>
    ///   <para>rdfs:comment : A relation between some aspect of a sensing entity and a feature.  For example, from a sensor to the features it can observe properties of, or from a deployment to the features it was installed to observe.  Also from a measurement capability to the feature the capability is described for.  (Used in conjunction with forProperty).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/ofFeature">w3c-ssn:ofFeature</a>
    /// </summary>
    let ofFeature = _prefixId.prefix "ofFeature"
    /// <summary>
    ///   <para>rdfs:label : on platform^^xsd:string</para>
    ///   <para>rdfs:comment : Relation between a System (e.g., a Sensor) and a Platform.  The relation locates the sensor relative to other described entities entities: i.e., the Sensor s1's location is Platform p1.  More precise locations for sensors in space (relative to other entities, where attached to another entity, or in 3D space) are made using DOLCE's Regions (SpaceRegion).^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/onPlatform">w3c-ssn:onPlatform</a>
    /// </summary>
    let onPlatform = _prefixId.prefix "onPlatform"
    /// <summary>
    ///   <para>rdfs:comment : The chain here means that if a sensor made an observation and that observation has a result, then the result is the one produced by the sensor.  Just ensures that the sensor and the resulting observation agree on the result.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/produces">w3c-ssn:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>dce:source : skos:exactMatch 'resultQuality' [O&amp;M - ISO/DIS 19156]
    /// 		                    http://portal.opengeospatial.org/files/?artifact_id=41579^^xsd:string</para>
    ///   <para>rdfs:seeAlso : http://www.w3.org/2005/Incubator/ssn/wiki/SSN_Observation#Observation^^xsd:string</para>
    ///   <para>rdfs:label : quality of observation^^xsd:string</para>
    ///   <para>rdfs:comment : Relation linking an Observation to the adjudged quality of the result.  This is of course complimentary to the MeasurementCapability information recorded for the Sensor that made the Observation.^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/qualityOfObservation">w3c-ssn:qualityOfObservation</a>
    /// </summary>
    let qualityOfObservation = _prefixId.prefix "qualityOfObservation"
    /// <summary>
    ///   <para>dce:source : http://www.bipm.org/en/committees/jc/jcgm/wg2.html^^xsd:string</para>
    ///   <para>rdfs:label : sensing method used^^xsd:string</para>
    ///   <para>rdfs:comment : A (measurement) procedure is a detailed description of a measurement according to one or more measurement principles and to a given measurement method, based on a measurement model and including any calculation to obtain a measurement result [VIM 2.6]^^xsd:string</para>
    ///   <a href="https://www.w3.org/ns/ssn/sensingMethodUsed">w3c-ssn:sensingMethodUsed</a>
    /// </summary>
    let sensingMethodUsed = _prefixId.prefix "sensingMethodUsed"
