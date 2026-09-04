#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sosa =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/sosa/" "sosa"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:example : A window actuator acts by changing the state between a frame and a window. The ability of the window to be opened and closed is its ActuatableProperty.</para>
    ///   <para>skos:definition : An actuatable quality (property, characteristic) of a FeatureOfInterest.</para>
    ///   <para>rdfs:label : Actuatable Property</para>
    ///   <para>rdfs:comment : An actuatable quality (property, characteristic) of a FeatureOfInterest.</para>
    ///   <a href="http://www.w3.org/ns/sosa/ActuatableProperty">sosa:ActuatableProperty</a>
    /// </summary>
    let ActuatableProperty = _prefixId.prefix "ActuatableProperty"
    /// <summary>
    ///   <para>skos:example : The activity of automatically closing a window if the temperature in a room drops below 20 degree Celsius. The activity is the Actuation and the device that closes the window is the Actuator. The Procedure is the rule, plan, or specification that defines the conditions that triggers the Actuation, here a drop in temperature. </para>
    ///   <para>skos:definition : An Actuation carries out an (Actuation) Procedure to change the state of the world using an Actuator.</para>
    ///   <para>rdfs:label : Actuation</para>
    ///   <para>rdfs:comment : An Actuation carries out an (Actuation) Procedure to change the state of the world using an Actuator.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Actuation">sosa:Actuation</a>
    /// </summary>
    let Actuation = _prefixId.prefix "Actuation"
    /// <summary>
    ///   <para>skos:example : A window actuator for automatic window control, i.e., opening or closing the window.</para>
    ///   <para>skos:definition : A device that is used by, or implements, an (Actuation) Procedure that changes the state of the world.</para>
    ///   <para>rdfs:label : Actuator</para>
    ///   <para>rdfs:comment : A device that is used by, or implements, an (Actuation) Procedure that changes the state of the world.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Actuator">sosa:Actuator</a>
    /// </summary>
    let Actuator = _prefixId.prefix "Actuator"
    /// <summary>
    ///   <para>skos:example : When measuring the height of a tree, the height is the observed ObservableProperty, 20m may be the Result of the Observation, and the tree is the FeatureOfInterest. A window is a FeatureOfInterest for an automatic window control Actuator.</para>
    ///   <para>skos:definition : The thing whose property is being estimated or calculated in the course of an Observation to arrive at a Result or whose property is being manipulated by an Actuator, or which is being sampled or transformed in an act of Sampling.</para>
    ///   <para>rdfs:label : Feature Of Interest</para>
    ///   <para>rdfs:comment : The thing whose property is being estimated or calculated in the course of an Observation to arrive at a Result or whose property is being manipulated by an Actuator, or which is being sampled or transformed in an act of Sampling.</para>
    ///   <a href="http://www.w3.org/ns/sosa/FeatureOfInterest">sosa:FeatureOfInterest</a>
    /// </summary>
    let FeatureOfInterest = _prefixId.prefix "FeatureOfInterest"
    /// <summary>
    ///   <para>skos:example : The height of a tree, the depth of a water body, or the temperature of a surface are examples of observable properties, while the value of a classic car is not (directly) observable but asserted.</para>
    ///   <para>skos:definition : An observable quality (property, characteristic) of a FeatureOfInterest.</para>
    ///   <para>rdfs:label : Observable Property</para>
    ///   <para>rdfs:comment : An observable quality (property, characteristic) of a FeatureOfInterest.</para>
    ///   <a href="http://www.w3.org/ns/sosa/ObservableProperty">sosa:ObservableProperty</a>
    /// </summary>
    let ObservableProperty = _prefixId.prefix "ObservableProperty"
    /// <summary>
    ///   <para>skos:example : The activity of estimating the intensity of an Earthquake using the Mercalli intensity scale is an Observation as is measuring the moment magnitude, i.e., the energy released by said earthquake.</para>
    ///   <para>skos:definition : Act of carrying out an (Observation) Procedure to estimate or calculate a value of a property of a FeatureOfInterest. Links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of, and to a FeatureOfInterest to detail what that property was associated with.</para>
    ///   <para>rdfs:label : Observation</para>
    ///   <para>rdfs:comment : Act of carrying out an (Observation) Procedure to estimate or calculate a value of a property of a FeatureOfInterest. Links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of, and to a FeatureOfInterest to detail what that property was associated with.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Observation">sosa:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>skos:example : A post, buoy, vehicle, ship, aircraft, satellite, cell-phone, human or animal may act as platforms for (technical or biological) sensors or actuators.</para>
    ///   <para>skos:definition : A Platform is an entity that hosts other entities, particularly Sensors, Actuators, Samplers, and other Platforms.</para>
    ///   <para>rdfs:label : Platform</para>
    ///   <para>rdfs:comment : A Platform is an entity that hosts other entities, particularly Sensors, Actuators, Samplers, and other Platforms.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Platform">sosa:Platform</a>
    /// </summary>
    let Platform = _prefixId.prefix "Platform"
    /// <summary>
    ///   <para>skos:note : Many observations may be created via the same Procedure, the same way as many tables are assembled using the same instructions (as information objects, not their concrete realization).</para>
    ///   <para>skos:example : The measured wind speed differs depending on the height of the sensor above the surface, e.g., due to friction. Consequently, procedures for measuring wind speed define a standard height for anemometers above ground, typically 10m for meteorological measures and 2m in Agrometeorology. This definition of height, sensor placement, and so forth are defined by the Procedure.</para>
    ///   <para>skos:definition : A workflow, protocol, plan, algorithm, or computational method specifying how to make an Observation, create a Sample, or make a change to the state of the world (via an Actuator). A Procedure is re-usable, and might be involved in many Observations, Samplings, or Actuations. It explains the steps to be carried out to arrive at reproducible results.</para>
    ///   <para>rdfs:label : Procedure</para>
    ///   <para>rdfs:comment : A workflow, protocol, plan, algorithm, or computational method specifying how to make an Observation, create a Sample, or make a change to the state of the world (via an Actuator). A Procedure is re-usable, and might be involved in many Observations, Samplings, or Actuations. It explains the steps to be carried out to arrive at reproducible results.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Procedure">sosa:Procedure</a>
    /// </summary>
    let Procedure = _prefixId.prefix "Procedure"
    /// <summary>
    ///   <para>skos:example : The value 20 as the height of a certain tree together with the unit, e.g., Meter.</para>
    ///   <para>skos:definition : The Result of an Observation, Actuation, or act of Sampling. To store an observation's simple result value one can use the hasSimpleResult property.</para>
    ///   <para>rdfs:label : Result</para>
    ///   <para>rdfs:comment : The Result of an Observation, Actuation, or act of Sampling. To store an observation's simple result value one can use the hasSimpleResult property.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Result">sosa:Result</a>
    /// </summary>
    let Result = _prefixId.prefix "Result"
    /// <summary>
    ///   <para>rdfs:comment : Samples are artifacts of an observational strategy, and have no significant function outside of their role in the observation process. The characteristics of the samples themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// A Sample is intended to sample some FatureOfInterest, so there is an expectation of at least one isSampleOf property. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.rdfs:comment : Feature which is intended to be representative of a FeatureOfInterest on which Observations may be made.rdfs:comment : Physical samples are sometimes known as 'specimens'.</para>
    ///   <para>skos:definition : Feature which is intended to be representative of a FeatureOfInterest on which Observations may be made.</para>
    ///   <para>skos:note : A transient sample, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.</para>
    ///   <para>skos:example : A 'station' is essentially an identifiable locality where a sensor system or Procedure may be deployed and an observation made. In the context of the observation model, it connotes the 'world in the vicinity of the station', so the observed properties relate to the physical medium at the station, and not to any physical artifact such as a mooring, buoy, benchmark, monument, well, etc.skos:example : A statistical sample is often designed to be characteristic of an entire population, so that observations can be made regarding the sample that provide a good estimate of the properties of the population.</para>
    ///   <para>rdfs:label : Sample</para>
    ///   <a href="http://www.w3.org/ns/sosa/Sample">sosa:Sample</a>
    /// </summary>
    let Sample = _prefixId.prefix "Sample"
    /// <summary>
    ///   <para>skos:example : A ball mill, diamond drill, hammer, hypodermic syringe and needle, image sensor or a soil auger can all act as sampling devices (i.e., be Samplers).</para>
    ///   <para>skos:definition : A device that is used by, or implements, a Sampling Procedure to create or transform one or more samples.</para>
    ///   <para>rdfs:label : Sampler</para>
    ///   <para>rdfs:comment : A device that is used by, or implements, a Sampling Procedure to create or transform one or more samples.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Sampler">sosa:Sampler</a>
    /// </summary>
    let Sampler = _prefixId.prefix "Sampler"
    /// <summary>
    ///   <para>skos:example : Taking a diamond-drill core from a rock outcrop.skos:example : Drilling an observation well.skos:example : Sieving a powder to separate the subset finer than 100-mesh.skos:example : Selecting a subset of a population.skos:example : Establishing a station for environmental monitoring.skos:example : Dividing a field site into quadrants.skos:example : Drawing blood from a patient.skos:example : Digging a pit through a soil sequence.skos:example : Splitting a piece of drill-core to create two new samples.skos:example : Registering an image of the landscape.skos:example : Crushing a rock sample in a ball mill.</para>
    ///   <para>rdfs:comment : An act of Sampling carries out a sampling Procedure to create or transform one or more samples.</para>
    ///   <para>skos:definition : An act of Sampling carries out a sampling Procedure to create or transform one or more samples.</para>
    ///   <para>rdfs:label : Sampling</para>
    ///   <a href="http://www.w3.org/ns/sosa/Sampling">sosa:Sampling</a>
    /// </summary>
    let Sampling = _prefixId.prefix "Sampling"
    /// <summary>
    ///   <para>skos:example : Accelerometers, gyroscopes, barometers, magnetometers, and so forth are Sensors that are typically mounted on a modern smart phone (which acts as Platform). Other examples of sensors include the human eyes.</para>
    ///   <para>skos:definition : Device, agent (including humans), or software (simulation) involved in, or implementing, a (Sensing) Procedure. Sensors respond to a stimulus, e.g., a change in the environment, or input data composed from the results of prior Observations, and generate a Result. Sensors can be mounted on Platforms.</para>
    ///   <para>rdfs:label : Sensor</para>
    ///   <para>rdfs:comment : Device, agent (including humans), or software (simulation) involved in, or implementing, a Procedure. Sensors respond to a stimulus, e.g., a change in the environment, or input data composed from the results of prior Observations, and generate a Result. Sensors can be mounted on Platforms.</para>
    ///   <a href="http://www.w3.org/ns/sosa/Sensor">sosa:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>skos:example : In the activity (Actuation) of automatically closing a window if the temperature in a room drops below 20 degrees Celsius, the property on which the Actuator acts upon is the state of the window as it changes from being open to being closed. </para>
    ///   <para>skos:definition : Relation between an Actuation and the property of a FeatureOfInterest it is acting upon.</para>
    ///   <para>rdfs:label : acts on property</para>
    ///   <para>rdfs:comment : Relation between an Actuation and the property of a FeatureOfInterest it is acting upon.</para>
    ///   <a href="http://www.w3.org/ns/sosa/actsOnProperty">sosa:actsOnProperty</a>
    /// </summary>
    let actsOnProperty = _prefixId.prefix "actsOnProperty"
    /// <summary>
    ///   <para>skos:definition : Relation linking an Actuation to the Actuator that made that Actuation.</para>
    ///   <para>rdfs:label : actuation made by</para>
    ///   <para>rdfs:comment : Relation linking an Actuation to the Actuator that made that Actuation.</para>
    ///   <a href="http://www.w3.org/ns/sosa/actuationMadeBy">sosa:actuationMadeBy</a>
    /// </summary>
    let actuationMadeBy = _prefixId.prefix "actuationMadeBy"
    /// <summary>
    ///   <para>rdfs:label : has feature of interest</para>
    ///   <para>skos:example : For example, in an Observation of the weight of a person, the FeatureOfInterest is the person and the property is its weight.</para>
    ///   <para>skos:definition : A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.</para>
    ///   <para>rdfs:comment : A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.</para>
    ///   <a href="http://www.w3.org/ns/sosa/hasFeatureOfInterest">sosa:hasFeatureOfInterest</a>
    /// </summary>
    let hasFeatureOfInterest = _prefixId.prefix "hasFeatureOfInterest"
    /// <summary>
    ///   <para>skos:definition : Relation linking an Observation and a Sensor or Actuator and a Result, which contains a value representing the value associated with the observed Property.</para>
    ///   <para>rdfs:label : has result</para>
    ///   <para>rdfs:comment : Relation linking an Observation and a Sensor or Actuator and a Result, which contains a value representing the value associated with the observed Property.</para>
    ///   <a href="http://www.w3.org/ns/sosa/hasResult">sosa:hasResult</a>
    /// </summary>
    let hasResult = _prefixId.prefix "hasResult"
    /// <summary>
    ///   <para>skos:definition : Relation linking an act of Sampling and the new Sample created as a result.</para>
    ///   <para>rdfs:label : has resulting sample</para>
    ///   <para>rdfs:comment : Relation linking an act of Sampling and the new Sample created as a result.</para>
    ///   <a href="http://www.w3.org/ns/sosa/hasResultingSample">sosa:hasResultingSample</a>
    /// </summary>
    let hasResultingSample = _prefixId.prefix "hasResultingSample"
    /// <summary>
    ///   <para>skos:definition : Relation between a FeatureOfInterest and the Sample used to represent it.</para>
    ///   <para>rdfs:label : has sample</para>
    ///   <para>rdfs:comment : Relation between a FeatureOfInterest and the Sample used to represent it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/hasSample">sosa:hasSample</a>
    /// </summary>
    let hasSample = _prefixId.prefix "hasSample"
    /// <summary>
    ///   <para>skos:example : For instance, the values 23 or true.</para>
    ///   <para>skos:definition : The simple value of an Observation or Actuation.</para>
    ///   <para>rdfs:label : has simple result</para>
    ///   <para>rdfs:comment : The simple value of an Observation or Actuation.</para>
    ///   <a href="http://www.w3.org/ns/sosa/hasSimpleResult">sosa:hasSimpleResult</a>
    /// </summary>
    let hasSimpleResult = _prefixId.prefix "hasSimpleResult"
    /// <summary>
    ///   <para>rdfs:label : hosts</para>
    ///   <para>skos:definition : Relation between a Platform and a Sensor, Actuator, Sampler, or Platform, hosted or mounted on it.</para>
    ///   <para>rdfs:comment : Relation between a Platform and a Sensor, Actuator, Sampler, or Platform, hosted or mounted on it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/hosts">sosa:hosts</a>
    /// </summary>
    let hosts = _prefixId.prefix "hosts"
    /// <summary>
    ///   <para>skos:example : In the activity (Actuation) of automatically closing a window if the temperature in a room drops below 20 degrees Celsius, the property on which the Actuator acts upon is the state of the window as it changes from being open to being closed. </para>
    ///   <para>skos:definition : Relation between an ActuatableProperty of a FeatureOfInterest and an Actuation changing its state.</para>
    ///   <para>rdfs:label : is acted on by</para>
    ///   <para>rdfs:comment : Relation between an ActuatableProperty of a FeatureOfInterest and an Actuation changing its state.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isActedOnBy">sosa:isActedOnBy</a>
    /// </summary>
    let isActedOnBy = _prefixId.prefix "isActedOnBy"
    /// <summary>
    ///   <para>rdfs:comment : A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.</para>
    ///   <para>rdfs:label : is feature of interest of</para>
    ///   <para>skos:definition : A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isFeatureOfInterestOf">sosa:isFeatureOfInterestOf</a>
    /// </summary>
    let isFeatureOfInterestOf = _prefixId.prefix "isFeatureOfInterestOf"
    /// <summary>
    ///   <para>rdfs:comment : Relation between a Sensor, Actuator, Sampler, or Platform, and the Platform that it is mounted on or hosted by.</para>
    ///   <para>rdfs:label : is hosted by</para>
    ///   <para>skos:definition : Relation between a Sensor, Actuator, Sampler, or Platform, and the Platform that it is mounted on or hosted by.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isHostedBy">sosa:isHostedBy</a>
    /// </summary>
    let isHostedBy = _prefixId.prefix "isHostedBy"
    /// <summary>
    ///   <para>skos:definition : Relation between an ObservableProperty and the Sensor able to observe it.</para>
    ///   <para>rdfs:label : is observed by</para>
    ///   <para>rdfs:comment : Relation between an ObservableProperty and the Sensor able to observe it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isObservedBy">sosa:isObservedBy</a>
    /// </summary>
    let isObservedBy = _prefixId.prefix "isObservedBy"
    /// <summary>
    ///   <para>skos:definition : Relation linking a Result to the Observation or Actuation that created or caused it.</para>
    ///   <para>rdfs:label : is result of</para>
    ///   <para>rdfs:comment : Relation linking a Result to the Observation or Actuation that created or caused it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isResultOf">sosa:isResultOf</a>
    /// </summary>
    let isResultOf = _prefixId.prefix "isResultOf"
    /// <summary>
    ///   <para>skos:definition : Relation from a Sample to the FeatureOfInterest that it is intended to be representative of.</para>
    ///   <para>rdfs:label : is sample of</para>
    ///   <para>rdfs:comment : Relation from a Sample to the FeatureOfInterest that it is intended to be representative of.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isSampleOf">sosa:isSampleOf</a>
    /// </summary>
    let isSampleOf = _prefixId.prefix "isSampleOf"
    /// <summary>
    ///   <para>skos:definition : Relation linking a Sample to the act of Sampling that created or caused it.</para>
    ///   <para>rdfs:label : is sampling result of</para>
    ///   <para>rdfs:comment : Relation linking a Sample to the act of Sampling that created or caused it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/isSamplingResultOf">sosa:isSamplingResultOf</a>
    /// </summary>
    let isSamplingResultOf = _prefixId.prefix "isSamplingResultOf"
    /// <summary>
    ///   <para>skos:definition : Relation between an Actuator and the Actuation it has made.</para>
    ///   <para>rdfs:label : made actuation</para>
    ///   <para>rdfs:comment : Relation between an Actuator and the Actuation it has made.</para>
    ///   <a href="http://www.w3.org/ns/sosa/madeActuation">sosa:madeActuation</a>
    /// </summary>
    let madeActuation = _prefixId.prefix "madeActuation"
    /// <summary>
    ///   <para>skos:definition : Relation linking an act of Sampling to the Sampler (sampling device or entity) that made it.</para>
    ///   <para>rdfs:label : made by sampler</para>
    ///   <para>rdfs:comment : Relation linking an act of Sampling to the Sampler (sampling device or entity) that made it.</para>
    ///   <a href="http://www.w3.org/ns/sosa/madeBySampler">sosa:madeBySampler</a>
    /// </summary>
    let madeBySampler = _prefixId.prefix "madeBySampler"
    /// <summary>
    ///   <para>skos:definition : Relation between an Observation and the Sensor which made the Observation.</para>
    ///   <para>rdfs:label : made by sensor</para>
    ///   <para>rdfs:comment : Relation between an Observation and the Sensor which made the Observation.</para>
    ///   <a href="http://www.w3.org/ns/sosa/madeBySensor">sosa:madeBySensor</a>
    /// </summary>
    let madeBySensor = _prefixId.prefix "madeBySensor"
    /// <summary>
    ///   <para>skos:definition : Relation between a Sensor and an Observation it has made.</para>
    ///   <para>rdfs:label : made observation</para>
    ///   <para>rdfs:comment : Relation between a Sensor and an Observation it has made.</para>
    ///   <a href="http://www.w3.org/ns/sosa/madeObservation">sosa:madeObservation</a>
    /// </summary>
    let madeObservation = _prefixId.prefix "madeObservation"
    /// <summary>
    ///   <para>skos:definition : Relation between a Sampler (sampling device or entity) and the Sampling act it performed.</para>
    ///   <para>rdfs:label : made sampling</para>
    ///   <para>rdfs:comment : Relation between a Sampler (sampling device or entity) and the Sampling act it performed.</para>
    ///   <a href="http://www.w3.org/ns/sosa/madeSampling">sosa:madeSampling</a>
    /// </summary>
    let madeSampling = _prefixId.prefix "madeSampling"
    /// <summary>
    ///   <para>skos:definition : Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.</para>
    ///   <para>rdfs:label : observed property</para>
    ///   <para>rdfs:comment : Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.</para>
    ///   <a href="http://www.w3.org/ns/sosa/observedProperty">sosa:observedProperty</a>
    /// </summary>
    let observedProperty = _prefixId.prefix "observedProperty"
    /// <summary>
    ///   <para>skos:definition : Relation between a Sensor and an ObservableProperty that it is capable of sensing.</para>
    ///   <para>rdfs:label : observes</para>
    ///   <para>rdfs:comment : Relation between a Sensor and an ObservableProperty that it is capable of sensing.</para>
    ///   <a href="http://www.w3.org/ns/sosa/observes">sosa:observes</a>
    /// </summary>
    let observes = _prefixId.prefix "observes"
    /// <summary>
    ///   <para>skos:definition : The time that the Result of an Observation, Actuation or Sampling applies to the FeatureOfInterest. Not necessarily the same as the resultTime. May be an Interval or an Instant, or some other compound TemporalEntity.</para>
    ///   <para>rdfs:label : phenomenon time</para>
    ///   <para>rdfs:comment : The time that the Result of an Observation, Actuation or Sampling applies to the FeatureOfInterest. Not necessarily the same as the resultTime. May be an Interval or an Instant, or some other compound TemporalEntity.</para>
    ///   <a href="http://www.w3.org/ns/sosa/phenomenonTime">sosa:phenomenonTime</a>
    /// </summary>
    let phenomenonTime = _prefixId.prefix "phenomenonTime"
    /// <summary>
    ///   <para>skos:definition : The result time is the instant of time when the Observation, Actuation or Sampling activity was completed.</para>
    ///   <para>rdfs:label : result time</para>
    ///   <para>rdfs:comment : The result time is the instant of time when the Observation, Actuation or Sampling activity was completed.</para>
    ///   <a href="http://www.w3.org/ns/sosa/resultTime">sosa:resultTime</a>
    /// </summary>
    let resultTime = _prefixId.prefix "resultTime"
    /// <summary>
    ///   <para>skos:definition : A relation to link to a re-usable Procedure used in making an Observation, an Actuation, or a Sample, typically through a Sensor, Actuator or Sampler.</para>
    ///   <para>rdfs:label : used procedure</para>
    ///   <para>rdfs:comment : A relation to link to a re-usable Procedure used in making an Observation, an Actuation, or a Sample, typically through a Sensor, Actuator or Sampler.</para>
    ///   <a href="http://www.w3.org/ns/sosa/usedProcedure">sosa:usedProcedure</a>
    /// </summary>
    let usedProcedure = _prefixId.prefix "usedProcedure"
