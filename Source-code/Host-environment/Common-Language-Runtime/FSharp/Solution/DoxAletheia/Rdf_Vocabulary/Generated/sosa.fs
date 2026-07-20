namespace http.www.w3.org.ns.sosa.slash

open DoxAletheia

module sosa =
    let _namespace_name = "http://www.w3.org/ns/sosa/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An actuatable quality (property, characteristic) of a FeatureOfInterest.
    /// <see href="http://www.w3.org/ns/sosa/ActuatableProperty"></see></summary>
    let ActuatableProperty = _prefix "ActuatableProperty"
    /// <summary>
    /// An Actuation carries out an (Actuation) Procedure to change the state of the world using an Actuator.
    /// <see href="http://www.w3.org/ns/sosa/Actuation"></see></summary>
    let Actuation = _prefix "Actuation"
    /// <summary>
    /// A device that is used by, or implements, an (Actuation) Procedure that changes the state of the world.
    /// <see href="http://www.w3.org/ns/sosa/Actuator"></see></summary>
    let Actuator = _prefix "Actuator"
    /// <summary>
    /// The thing whose property is being estimated or calculated in the course of an Observation to arrive at a Result or whose property is being manipulated by an Actuator, or which is being sampled or transformed in an act of Sampling.
    /// <see href="http://www.w3.org/ns/sosa/FeatureOfInterest"></see></summary>
    let FeatureOfInterest = _prefix "FeatureOfInterest"
    /// <summary>
    /// An observable quality (property, characteristic) of a FeatureOfInterest.
    /// <see href="http://www.w3.org/ns/sosa/ObservableProperty"></see></summary>
    let ObservableProperty = _prefix "ObservableProperty"
    /// <summary>
    /// Act of carrying out an (Observation) Procedure to estimate or calculate a value of a property of a FeatureOfInterest. Links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of, and to a FeatureOfInterest to detail what that property was associated with.
    /// <see href="http://www.w3.org/ns/sosa/Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// A Platform is an entity that hosts other entities, particularly Sensors, Actuators, Samplers, and other Platforms.
    /// <see href="http://www.w3.org/ns/sosa/Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// A workflow, protocol, plan, algorithm, or computational method specifying how to make an Observation, create a Sample, or make a change to the state of the world (via an Actuator). A Procedure is re-usable, and might be involved in many Observations, Samplings, or Actuations. It explains the steps to be carried out to arrive at reproducible results.
    /// <see href="http://www.w3.org/ns/sosa/Procedure"></see></summary>
    let Procedure = _prefix "Procedure"
    /// <summary>
    /// The Result of an Observation, Actuation, or act of Sampling. To store an observation's simple result value one can use the hasSimpleResult property.
    /// <see href="http://www.w3.org/ns/sosa/Result"></see></summary>
    let Result = _prefix "Result"
    /// <summary>
    /// Samples are artifacts of an observational strategy, and have no significant function outside of their role in the observation process. The characteristics of the samples themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// A Sample is intended to sample some FatureOfInterest, so there is an expectation of at least one isSampleOf property. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.
    /// Feature which is intended to be representative of a FeatureOfInterest on which Observations may be made.
    /// Physical samples are sometimes known as 'specimens'.
    /// <see href="http://www.w3.org/ns/sosa/Sample"></see></summary>
    let Sample = _prefix "Sample"
    /// <summary>
    /// A device that is used by, or implements, a Sampling Procedure to create or transform one or more samples.
    /// <see href="http://www.w3.org/ns/sosa/Sampler"></see></summary>
    let Sampler = _prefix "Sampler"
    /// <summary>
    /// An act of Sampling carries out a sampling Procedure to create or transform one or more samples.
    /// <see href="http://www.w3.org/ns/sosa/Sampling"></see></summary>
    let Sampling = _prefix "Sampling"
    /// <summary>
    /// Device, agent (including humans), or software (simulation) involved in, or implementing, a Procedure. Sensors respond to a stimulus, e.g., a change in the environment, or input data composed from the results of prior Observations, and generate a Result. Sensors can be mounted on Platforms.
    /// <see href="http://www.w3.org/ns/sosa/Sensor"></see></summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    /// Relation between an Actuation and the property of a FeatureOfInterest it is acting upon.
    /// <see href="http://www.w3.org/ns/sosa/actsOnProperty"></see></summary>
    let actsOnProperty = _prefix "actsOnProperty"
    /// <summary>
    /// Relation between an ActuatableProperty of a FeatureOfInterest and an Actuation changing its state.
    /// <see href="http://www.w3.org/ns/sosa/isActedOnBy"></see></summary>
    let isActedOnBy = _prefix "isActedOnBy"
    /// <summary>
    /// Relation linking an Actuation to the Actuator that made that Actuation.
    /// <see href="http://www.w3.org/ns/sosa/actuationMadeBy"></see></summary>
    let actuationMadeBy = _prefix "actuationMadeBy"
    /// <summary>
    /// Relation between an Actuator and the Actuation it has made.
    /// <see href="http://www.w3.org/ns/sosa/madeActuation"></see></summary>
    let madeActuation = _prefix "madeActuation"
    /// <summary>
    /// A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.
    /// <see href="http://www.w3.org/ns/sosa/hasFeatureOfInterest"></see></summary>
    let hasFeatureOfInterest = _prefix "hasFeatureOfInterest"
    /// <summary>
    /// A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.
    /// <see href="http://www.w3.org/ns/sosa/isFeatureOfInterestOf"></see></summary>
    let isFeatureOfInterestOf = _prefix "isFeatureOfInterestOf"
    /// <summary>
    /// Relation linking an Observation and a Sensor or Actuator and a Result, which contains a value representing the value associated with the observed Property.
    /// <see href="http://www.w3.org/ns/sosa/hasResult"></see></summary>
    let hasResult = _prefix "hasResult"
    /// <summary>
    /// Relation linking a Result to the Observation or Actuation that created or caused it.
    /// <see href="http://www.w3.org/ns/sosa/isResultOf"></see></summary>
    let isResultOf = _prefix "isResultOf"
    /// <summary>
    /// Relation linking an act of Sampling and the new Sample created as a result.
    /// <see href="http://www.w3.org/ns/sosa/hasResultingSample"></see></summary>
    let hasResultingSample = _prefix "hasResultingSample"
    /// <summary>
    /// Relation linking a Sample to the act of Sampling that created or caused it.
    /// <see href="http://www.w3.org/ns/sosa/isSamplingResultOf"></see></summary>
    let isSamplingResultOf = _prefix "isSamplingResultOf"
    /// <summary>
    /// Relation between a FeatureOfInterest and the Sample used to represent it.
    /// <see href="http://www.w3.org/ns/sosa/hasSample"></see></summary>
    let hasSample = _prefix "hasSample"
    /// <summary>
    /// Relation from a Sample to the FeatureOfInterest that it is intended to be representative of.
    /// <see href="http://www.w3.org/ns/sosa/isSampleOf"></see></summary>
    let isSampleOf = _prefix "isSampleOf"
    /// <summary>
    /// The simple value of an Observation or Actuation.
    /// <see href="http://www.w3.org/ns/sosa/hasSimpleResult"></see></summary>
    let hasSimpleResult = _prefix "hasSimpleResult"
    /// <summary>
    /// Relation between a Platform and a Sensor, Actuator, Sampler, or Platform, hosted or mounted on it.
    /// <see href="http://www.w3.org/ns/sosa/hosts"></see></summary>
    let hosts = _prefix "hosts"
    /// <summary>
    /// Relation between a Sensor, Actuator, Sampler, or Platform, and the Platform that it is mounted on or hosted by.
    /// <see href="http://www.w3.org/ns/sosa/isHostedBy"></see></summary>
    let isHostedBy = _prefix "isHostedBy"
    /// <summary>
    /// Relation between an ObservableProperty and the Sensor able to observe it.
    /// <see href="http://www.w3.org/ns/sosa/isObservedBy"></see></summary>
    let isObservedBy = _prefix "isObservedBy"
    /// <summary>
    /// Relation between a Sensor and an ObservableProperty that it is capable of sensing.
    /// <see href="http://www.w3.org/ns/sosa/observes"></see></summary>
    let observes = _prefix "observes"
    /// <summary>
    /// Relation linking an act of Sampling to the Sampler (sampling device or entity) that made it.
    /// <see href="http://www.w3.org/ns/sosa/madeBySampler"></see></summary>
    let madeBySampler = _prefix "madeBySampler"
    /// <summary>
    /// Relation between a Sampler (sampling device or entity) and the Sampling act it performed.
    /// <see href="http://www.w3.org/ns/sosa/madeSampling"></see></summary>
    let madeSampling = _prefix "madeSampling"
    /// <summary>
    /// Relation between an Observation and the Sensor which made the Observation.
    /// <see href="http://www.w3.org/ns/sosa/madeBySensor"></see></summary>
    let madeBySensor = _prefix "madeBySensor"
    /// <summary>
    /// Relation between a Sensor and an Observation it has made.
    /// <see href="http://www.w3.org/ns/sosa/madeObservation"></see></summary>
    let madeObservation = _prefix "madeObservation"
    /// <summary>
    /// Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.
    /// <see href="http://www.w3.org/ns/sosa/observedProperty"></see></summary>
    let observedProperty = _prefix "observedProperty"
    /// <summary>
    /// The time that the Result of an Observation, Actuation or Sampling applies to the FeatureOfInterest. Not necessarily the same as the resultTime. May be an Interval or an Instant, or some other compound TemporalEntity.
    /// <see href="http://www.w3.org/ns/sosa/phenomenonTime"></see></summary>
    let phenomenonTime = _prefix "phenomenonTime"
    /// <summary>
    /// The result time is the instant of time when the Observation, Actuation or Sampling activity was completed.
    /// <see href="http://www.w3.org/ns/sosa/resultTime"></see></summary>
    let resultTime = _prefix "resultTime"
    /// <summary>
    /// A relation to link to a re-usable Procedure used in making an Observation, an Actuation, or a Sample, typically through a Sensor, Actuator or Sampler.
    /// <see href="http://www.w3.org/ns/sosa/usedProcedure"></see></summary>
    let usedProcedure = _prefix "usedProcedure"
