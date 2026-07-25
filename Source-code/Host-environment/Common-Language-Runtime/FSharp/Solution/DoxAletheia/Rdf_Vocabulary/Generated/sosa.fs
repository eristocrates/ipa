namespace http.www.w3.org.ns.sosa.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sosa =
    let _namespace_iri = Namespace_Iri sosa |> NamespaceIRI
    /// <summary>
    ///   <para>sosa:hasSimpleResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The simple value of an Observation or Actuation.</para>
    /// labels<para>has simple result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/hasSimpleResult">http://www.w3.org/ns/sosa/hasSimpleResult</seealso>
    let hasSimpleResult = Prefixed_Name(sosa, "hasSimpleResult") |> PrefixedName
    /// <summary>
    ///   <para>sosa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/">http://www.w3.org/ns/sosa/</seealso>
    let _prefix_iri = Prefixed_Name(sosa, "") |> PrefixedName
    /// <summary>
    ///   <para>sosa:isSamplingResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking a Sample to the act of Sampling that created or caused it.</para>
    /// labels<para>is sampling result of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isSamplingResultOf">http://www.w3.org/ns/sosa/isSamplingResultOf</seealso>
    let isSamplingResultOf = Prefixed_Name(sosa, "isSamplingResultOf") |> PrefixedName
    /// <summary>
    ///   <para>sosa:hasSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a FeatureOfInterest and the Sample used to represent it.</para>
    /// labels<para>has sample</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/hasSample">http://www.w3.org/ns/sosa/hasSample</seealso>
    let hasSample = Prefixed_Name(sosa, "hasSample") |> PrefixedName
    /// <summary>
    ///   <para>sosa:hosts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Platform and a Sensor, Actuator, Sampler, or Platform, hosted or mounted on it.</para>
    /// labels<para>hosts</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/hosts">http://www.w3.org/ns/sosa/hosts</seealso>
    let hosts = Prefixed_Name(sosa, "hosts") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Sampling</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An act of Sampling carries out a sampling Procedure to create or transform one or more samples.</para>
    /// labels<para>Sampling</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Sampling">http://www.w3.org/ns/sosa/Sampling</seealso>
    let Sampling = Prefixed_Name(sosa, "Sampling") |> PrefixedName
    /// <summary>
    ///   <para>sosa:actuationMadeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking an Actuation to the Actuator that made that Actuation.</para>
    /// labels<para>actuation made by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/actuationMadeBy">http://www.w3.org/ns/sosa/actuationMadeBy</seealso>
    let actuationMadeBy = Prefixed_Name(sosa, "actuationMadeBy") |> PrefixedName
    /// <summary>
    ///   <para>sosa:ActuatableProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An actuatable quality (property, characteristic) of a FeatureOfInterest.</para>
    /// labels<para>Actuatable Property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/ActuatableProperty">http://www.w3.org/ns/sosa/ActuatableProperty</seealso>
    let ActuatableProperty = Prefixed_Name(sosa, "ActuatableProperty") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Actuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>An Actuation carries out an (Actuation) Procedure to change the state of the world using an Actuator.</para>
    /// labels<para>Actuation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Actuation">http://www.w3.org/ns/sosa/Actuation</seealso>
    let Actuation = Prefixed_Name(sosa, "Actuation") |> PrefixedName
    /// <summary>
    ///   <para>sosa:FeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>The thing whose property is being estimated or calculated in the course of an Observation to arrive at a Result or whose property is being manipulated by an Actuator, or which is being sampled or transformed in an act of Sampling.</para>
    /// labels<para>Feature Of Interest</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/FeatureOfInterest">http://www.w3.org/ns/sosa/FeatureOfInterest</seealso>
    let FeatureOfInterest = Prefixed_Name(sosa, "FeatureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>sosa:ObservableProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>An observable quality (property, characteristic) of a FeatureOfInterest.</para>
    /// labels<para>Observable Property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/ObservableProperty">http://www.w3.org/ns/sosa/ObservableProperty</seealso>
    let ObservableProperty = Prefixed_Name(sosa, "ObservableProperty") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Act of carrying out an (Observation) Procedure to estimate or calculate a value of a property of a FeatureOfInterest. Links to a Sensor to describe what made the Observation and how; links to an ObservableProperty to describe what the result is an estimate of, and to a FeatureOfInterest to detail what that property was associated with.</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Observation">http://www.w3.org/ns/sosa/Observation</seealso>
    let Observation = Prefixed_Name(sosa, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Actuator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A device that is used by, or implements, an (Actuation) Procedure that changes the state of the world.</para>
    /// labels<para>Actuator</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Actuator">http://www.w3.org/ns/sosa/Actuator</seealso>
    let Actuator = Prefixed_Name(sosa, "Actuator") |> PrefixedName
    /// <summary>
    ///   <para>sosa:observedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking an Observation to the property that was observed. The ObservableProperty should be a property of the FeatureOfInterest (linked by hasFeatureOfInterest) of this Observation.</para>
    /// labels<para>observed property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/observedProperty">http://www.w3.org/ns/sosa/observedProperty</seealso>
    let observedProperty = Prefixed_Name(sosa, "observedProperty") |> PrefixedName
    /// <summary>
    ///   <para>sosa:phenomenonTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The time that the Result of an Observation, Actuation or Sampling applies to the FeatureOfInterest. Not necessarily the same as the resultTime. May be an Interval or an Instant, or some other compound TemporalEntity.</para>
    /// labels<para>phenomenon time</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/phenomenonTime">http://www.w3.org/ns/sosa/phenomenonTime</seealso>
    let phenomenonTime = Prefixed_Name(sosa, "phenomenonTime") |> PrefixedName
    /// <summary>
    ///   <para>sosa:resultTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>The result time is the instant of time when the Observation, Actuation or Sampling activity was completed.</para>
    /// labels<para>result time</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/resultTime">http://www.w3.org/ns/sosa/resultTime</seealso>
    let resultTime = Prefixed_Name(sosa, "resultTime") |> PrefixedName
    /// <summary>
    ///   <para>sosa:usedProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation to link to a re-usable Procedure used in making an Observation, an Actuation, or a Sample, typically through a Sensor, Actuator or Sampler.</para>
    /// labels<para>used procedure</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/usedProcedure">http://www.w3.org/ns/sosa/usedProcedure</seealso>
    let usedProcedure = Prefixed_Name(sosa, "usedProcedure") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A Platform is an entity that hosts other entities, particularly Sensors, Actuators, Samplers, and other Platforms.</para>
    /// labels<para>Platform</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Platform">http://www.w3.org/ns/sosa/Platform</seealso>
    let Platform = Prefixed_Name(sosa, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>A workflow, protocol, plan, algorithm, or computational method specifying how to make an Observation, create a Sample, or make a change to the state of the world (via an Actuator). A Procedure is re-usable, and might be involved in many Observations, Samplings, or Actuations. It explains the steps to be carried out to arrive at reproducible results.</para>
    /// labels<para>Procedure</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Procedure">http://www.w3.org/ns/sosa/Procedure</seealso>
    let Procedure = Prefixed_Name(sosa, "Procedure") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Sample</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>Feature which is intended to be representative of a FeatureOfInterest on which Observations may be made.</para>
    ///   <para>Physical samples are sometimes known as 'specimens'.</para>
    ///   <para>Samples are artifacts of an observational strategy, and have no significant function outside of their role in the observation process. The characteristics of the samples themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// A Sample is intended to sample some FatureOfInterest, so there is an expectation of at least one isSampleOf property. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.</para>
    /// labels<para>Sample</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Sample">http://www.w3.org/ns/sosa/Sample</seealso>
    let Sample = Prefixed_Name(sosa, "Sample") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Sampler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>A device that is used by, or implements, a Sampling Procedure to create or transform one or more samples.</para>
    /// labels<para>Sampler</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Sampler">http://www.w3.org/ns/sosa/Sampler</seealso>
    let Sampler = Prefixed_Name(sosa, "Sampler") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>The Result of an Observation, Actuation, or act of Sampling. To store an observation's simple result value one can use the hasSimpleResult property.</para>
    /// labels<para>Result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Result">http://www.w3.org/ns/sosa/Result</seealso>
    let Result = Prefixed_Name(sosa, "Result") |> PrefixedName
    /// <summary>
    ///   <para>sosa:actsOnProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an Actuation and the property of a FeatureOfInterest it is acting upon.</para>
    /// labels<para>acts on property</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/actsOnProperty">http://www.w3.org/ns/sosa/actsOnProperty</seealso>
    let actsOnProperty = Prefixed_Name(sosa, "actsOnProperty") |> PrefixedName
    /// <summary>
    ///   <para>sosa:isActedOnBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an ActuatableProperty of a FeatureOfInterest and an Actuation changing its state.</para>
    /// labels<para>is acted on by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isActedOnBy">http://www.w3.org/ns/sosa/isActedOnBy</seealso>
    let isActedOnBy = Prefixed_Name(sosa, "isActedOnBy") |> PrefixedName
    /// <summary>
    ///   <para>sosa:madeActuation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an Actuator and the Actuation it has made.</para>
    /// labels<para>made actuation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/madeActuation">http://www.w3.org/ns/sosa/madeActuation</seealso>
    let madeActuation = Prefixed_Name(sosa, "madeActuation") |> PrefixedName
    /// <summary>
    ///   <para>sosa:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>Device, agent (including humans), or software (simulation) involved in, or implementing, a Procedure. Sensors respond to a stimulus, e.g., a change in the environment, or input data composed from the results of prior Observations, and generate a Result. Sensors can be mounted on Platforms.</para>
    /// labels<para>Sensor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/Sensor">http://www.w3.org/ns/sosa/Sensor</seealso>
    let Sensor = Prefixed_Name(sosa, "Sensor") |> PrefixedName

    /// <summary>
    ///   <para>sosa:hasFeatureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between an Observation and the entity whose quality was observed, or between an Actuation and the entity whose property was modified, or between an act of Sampling and the entity that was sampled.</para>
    /// labels<para>has feature of interest</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/hasFeatureOfInterest">http://www.w3.org/ns/sosa/hasFeatureOfInterest</seealso>
    let hasFeatureOfInterest =
        Prefixed_Name(sosa, "hasFeatureOfInterest") |> PrefixedName

    /// <summary>
    ///   <para>sosa:hasResultingSample</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking an act of Sampling and the new Sample created as a result.</para>
    /// labels<para>has resulting sample</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/hasResultingSample">http://www.w3.org/ns/sosa/hasResultingSample</seealso>
    let hasResultingSample = Prefixed_Name(sosa, "hasResultingSample") |> PrefixedName

    /// <summary>
    ///   <para>sosa:isFeatureOfInterestOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A relation between a FeatureOfInterest and an Observation about it, an Actuation acting on it, or an act of Sampling that sampled it.</para>
    /// labels<para>is feature of interest of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isFeatureOfInterestOf">http://www.w3.org/ns/sosa/isFeatureOfInterestOf</seealso>
    let isFeatureOfInterestOf =
        Prefixed_Name(sosa, "isFeatureOfInterestOf") |> PrefixedName

    /// <summary>
    ///   <para>sosa:hasResult</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking an Observation and a Sensor or Actuator and a Result, which contains a value representing the value associated with the observed Property.</para>
    /// labels<para>has result</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/hasResult">http://www.w3.org/ns/sosa/hasResult</seealso>
    let hasResult = Prefixed_Name(sosa, "hasResult") |> PrefixedName
    /// <summary>
    ///   <para>sosa:isResultOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking a Result to the Observation or Actuation that created or caused it.</para>
    /// labels<para>is result of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isResultOf">http://www.w3.org/ns/sosa/isResultOf</seealso>
    let isResultOf = Prefixed_Name(sosa, "isResultOf") |> PrefixedName
    /// <summary>
    ///   <para>sosa:isSampleOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation from a Sample to the FeatureOfInterest that it is intended to be representative of.</para>
    /// labels<para>is sample of</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isSampleOf">http://www.w3.org/ns/sosa/isSampleOf</seealso>
    let isSampleOf = Prefixed_Name(sosa, "isSampleOf") |> PrefixedName
    /// <summary>
    ///   <para>sosa:isHostedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Sensor, Actuator, Sampler, or Platform, and the Platform that it is mounted on or hosted by.</para>
    /// labels<para>is hosted by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isHostedBy">http://www.w3.org/ns/sosa/isHostedBy</seealso>
    let isHostedBy = Prefixed_Name(sosa, "isHostedBy") |> PrefixedName
    /// <summary>
    ///   <para>sosa:isObservedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an ObservableProperty and the Sensor able to observe it.</para>
    /// labels<para>is observed by</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/isObservedBy">http://www.w3.org/ns/sosa/isObservedBy</seealso>
    let isObservedBy = Prefixed_Name(sosa, "isObservedBy") |> PrefixedName
    /// <summary>
    ///   <para>sosa:observes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Sensor and an ObservableProperty that it is capable of sensing.</para>
    /// labels<para>observes</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/observes">http://www.w3.org/ns/sosa/observes</seealso>
    let observes = Prefixed_Name(sosa, "observes") |> PrefixedName
    /// <summary>
    ///   <para>sosa:madeBySampler</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation linking an act of Sampling to the Sampler (sampling device or entity) that made it.</para>
    /// labels<para>made by sampler</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/madeBySampler">http://www.w3.org/ns/sosa/madeBySampler</seealso>
    let madeBySampler = Prefixed_Name(sosa, "madeBySampler") |> PrefixedName
    /// <summary>
    ///   <para>sosa:madeSampling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Sampler (sampling device or entity) and the Sampling act it performed.</para>
    /// labels<para>made sampling</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/madeSampling">http://www.w3.org/ns/sosa/madeSampling</seealso>
    let madeSampling = Prefixed_Name(sosa, "madeSampling") |> PrefixedName
    /// <summary>
    ///   <para>sosa:madeBySensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an Observation and the Sensor which made the Observation.</para>
    /// labels<para>made by sensor</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/madeBySensor">http://www.w3.org/ns/sosa/madeBySensor</seealso>
    let madeBySensor = Prefixed_Name(sosa, "madeBySensor") |> PrefixedName
    /// <summary>
    ///   <para>sosa:madeObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a Sensor and an Observation it has made.</para>
    /// labels<para>made observation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/sosa/madeObservation">http://www.w3.org/ns/sosa/madeObservation</seealso>
    let madeObservation = Prefixed_Name(sosa, "madeObservation") |> PrefixedName
