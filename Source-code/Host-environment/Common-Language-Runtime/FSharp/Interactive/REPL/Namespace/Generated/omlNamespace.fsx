#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oml =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/ontology/om/om-lite#" "oml"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : Count object^^xsd:string</para>
    ///   <para>rdfs:comment : Object to wrap a count value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#CountObject">oml:CountObject</a>
    /// </summary>
    let CountObject = _prefixId.prefix "CountObject"
    /// <summary>
    ///   <para>dcterms:description : Observation whose result is an integer^^xsd:string</para>
    ///   <para>rdfs:label : Count Observation</para>
    ///   <para>rdfs:comment : Observation whose result is an integer^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#CountObservation">oml:CountObservation</a>
    /// </summary>
    let CountObservation = _prefixId.prefix "CountObservation"
    /// <summary>
    ///   <para>dcterms:description : Geometry object has properties relating to geometry, incuding positional and topological attributes, reference system, accuracy and precision. Might be geolocated. ^^xsd:string</para>
    ///   <para>rdfs:label : Geometry object^^xsd:string</para>
    ///   <para>rdfs:comment : This stub is included in the om: ontology to support references to geometry as the result of a GeometryObservation.  An existing OWL class that represents the notion of a geometry may be asserted to be a sub-class of this stub, without requiring use of a specific representation of Geometry in the context of observations instance.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObject">oml:GeometryObject</a>
    /// </summary>
    let GeometryObject = _prefixId.prefix "GeometryObject"
    /// <summary>
    ///   <para>dcterms:description : Observation whose result is a geometry object, such as a point, curve, surface or solid^^xsd:string</para>
    ///   <para>rdfs:label : Geometry Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a geometry object, such as a point, curve, surface or solid^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObservation">oml:GeometryObservation</a>
    /// </summary>
    let GeometryObservation = _prefixId.prefix "GeometryObservation"
    /// <summary>
    ///   <para>dcterms:description : Scaled number^^xsd:string</para>
    ///   <para>rdfs:label : Measure^^xsd:string</para>
    ///   <para>rdfs:comment : Scaled number
    ///
    /// This is an abstract class, which should be substituted by a suitable concrete representation of a measure or quantity at run-tme.
    ///
    /// oml:SimpleMeasure
    /// qudt:QuantityValue &lt;http://qudt.org/schema/qudt#QuantityValue&gt;
    /// DUL:Region &lt;http://www.loa-cnr.it/ontologies/DUL.owl#Region&gt;
    ///
    /// are candidates. ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#MeasureObject">oml:MeasureObject</a>
    /// </summary>
    let MeasureObject = _prefixId.prefix "MeasureObject"
    /// <summary>
    ///   <para>dcterms:description : Observation whose result is a scaled number^^xsd:string</para>
    ///   <para>rdfs:label : Measurementrdfs:label : Mesure</para>
    ///   <para>rdfs:comment : Observation whose result is a scaled number^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#Measurement">oml:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>skos:prefLabel : Observationskos:prefLabel : Observation</para>
    ///   <para>rdfs:comment : An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry metadata about an instance of a property (of the feature of interest). This property-value metadata complements the dataset and feature metadata that have been conventionally considered (e.g. ISO 19115).
    ///
    /// The values for the properties 'procedure', 'featureOfInterest', 'observedProperty', 'phenomenonTime', 'resultTime' may be inherited from a container resource.^^xsd:string</para>
    ///   <para>skos:altLabel : Generic observation^^xsd:string</para>
    ///   <para>skos:changeNote : A new property oml:samplingStrategy is scoped to this class. In this  formulation, the (mandatory) feature-of-interest always refers to the ultimate feature of interest, whose type can carry the observed property, and the (optional) sampling strategy allows the sampling feature to be made explicit as an additional relationship. This overcomes some semantic sleight-of-hand in ISO 19156, in which the constraint the the observed property was commensurate with the feature-of-interest was allowed to be 'transitive' via the sampledFeature property.^^xsd:string</para>
    ///   <para>dcterms:description : An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry metadata about an instance of a property (of the feature of interest). This property-value metadata complements the dataset and feature metadata that have been conventionally considered (e.g. ISO 19115). ^^xsd:string</para>
    ///   <para>rdfs:label : Observation</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#Observation">oml:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>dcterms:description : Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.^^xsd:string</para>
    ///   <para>rdfs:label : Observation agent</para>
    ///   <para>rdfs:comment : Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationAgent">oml:ObservationAgent</a>
    /// </summary>
    let ObservationAgent = _prefixId.prefix "ObservationAgent"
    /// <summary>
    ///   <para>dcterms:description : A collection of observations.
    ///
    /// The collection may be homogeneous in one or more of the feature-of-interest, observed-property, procedures, phenomenon-time or result-time. If only one value for any of these properties is provided on the collection, then it may be inferred to be a common (default) value for all the member observations, unless locally overridden.^^xsd:string</para>
    ///   <para>rdfs:label : Collection of observations</para>
    ///   <para>rdfs:comment : A collection of observations.
    ///
    /// The collection may be homogeneous in one or more of the feature-of-interest, observed-property, procedures, phenomenon-time or result-time. If only one value for any of these properties is provided on the collection, then it may be inferred to be a common (default) value for all the member observations, unless locally overridden.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationCollection">oml:ObservationCollection</a>
    /// </summary>
    let ObservationCollection = _prefixId.prefix "ObservationCollection"
    /// <summary>
    ///   <para>dcterms:description : Context linking two or more observations^^xsd:string</para>
    ///   <para>rdfs:label : Observation context</para>
    ///   <para>rdfs:comment : Some observations depend on other observations to provide context which is important, sometimes essential, in understanding the result. These dependencies are stronger than mere spatio-temporal coincidences, requiring explicit representation. If present, the association class class ObservationContext (Figure 2) shall link a OM_Observation to another OM_Observation, with the role name relatedObservation for the target. It shall support one attribute.
    ///
    /// EXAMPLES	Some examples include the conditions associated with experimental replicates (e.g., experimental plots and treatments used), biotic factors (e.g., ecological community), interactions among features (e.g., predator-prey), or other temporary relationships occurring at the time of observation that are are not inherent to the observed features themselves (i.e., they change over time), or the related observation may provide input to a process that generates a new result.
    /// This association complements the Intention association which describes relationships between a sampling feature and domain features.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationContext">oml:ObservationContext</a>
    /// </summary>
    let ObservationContext = _prefixId.prefix "ObservationContext"
    /// <summary>
    ///   <para>skos:historyNote : Original description from ISO 19156 says:
    ///
    /// The class OM_Process (Figure 2) is an instance of the «metaclass» GF_FeatureType (ISO 19109:2005), which therefore represents a feature type. OM_Process is abstract, and has no attributes, operations or associations. It serves as the base class for observation processes. The purpose of an observation process is to generate an observation result. An instance of OM_Process is often an instrument or sensor, but may be a human observer, a simulator, or a process or algorithm applied to more primitive results used as inputs.
    ///
    /// NOTE	ISO 19115-2:2008 provides MI_Instrument, LE_Processing and LE_Algorithm, which could all be modelled as specializations of OM_Process. OGC SensorML [10] provides a model which is suitable for many observation procedures.^^xsd:stringskos:historyNote : Original description from OGC SensorML says:
    ///
    /// In SensorML, all components are modeled as processes. This includes components normally viewed as hardware, including transducers, actuators, and processors (which are viewed as process components) and sensors and platforms (which are modeled as systems). All components are modeled as processes that take input, and which through the application of an algorithm defined by a method and parameter values, generate output. All such components can therefore participate in process chains. Process chains are themselves processes with inputs, outputs, and parameters.
    ///
    /// Hence, SensorML can be viewed as a specialized process description language with an emphasis on application to sensor data. Process descriptions in SensorML are agnostic of the development environment in which they might be executed, or the protocol by which data is transported between process execution modules. SensorML does not try to replace other existing technologies (such as BPEL or MATLAB Simulink). It is also conceived that SensorML-defined processes could be imported and executed within other execution environments, such as BPEL or MATLAB Simulink, as well as within SenosrML-enabled process execution software.^^xsd:string</para>
    ///   <para>dcterms:description : Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.^^xsd:string</para>
    ///   <para>rdfs:label : Observation process</para>
    ///   <para>rdfs:comment : Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#Process">oml:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>dcterms:description : Simple implementation of a scaled number as an (amount, unit) pair^^xsd:string</para>
    ///   <para>rdfs:label : Simple measure (quantity)^^xsd:string</para>
    ///   <para>rdfs:comment : Simple implementation of a scaled number as an (amount, unit) pair^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure">oml:SimpleMeasure</a>
    /// </summary>
    let SimpleMeasure = _prefixId.prefix "SimpleMeasure"
    /// <summary>
    ///   <para>dcterms:description : Temporal object has properties relating to time only. ^^xsd:string</para>
    ///   <para>rdfs:label : Temporal object^^xsd:string</para>
    ///   <para>rdfs:comment : Temporal geometry or topology, collection or complex.
    ///
    /// Temporal object has properties relating to time only.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObject">oml:TemporalObject</a>
    /// </summary>
    let TemporalObject = _prefixId.prefix "TemporalObject"
    /// <summary>
    ///   <para>dcterms:description : Observation whose result is a temporal object, such as a time instant or period^^xsd:string</para>
    ///   <para>rdfs:label : Temporal Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a temporal object, such as a time instant or period^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObservation">oml:TemporalObservation</a>
    /// </summary>
    let TemporalObservation = _prefixId.prefix "TemporalObservation"
    /// <summary>
    ///   <para>rdfs:label : Truth object^^xsd:string</para>
    ///   <para>rdfs:comment : Object to wrap a truth value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObject">oml:TruthObject</a>
    /// </summary>
    let TruthObject = _prefixId.prefix "TruthObject"
    /// <summary>
    ///   <para>dcterms:description : Observation whose result is either true or false^^xsd:string</para>
    ///   <para>rdfs:label : Truth Observation</para>
    ///   <para>rdfs:comment : Observation whose result is either true or false^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObservation">oml:TruthObservation</a>
    /// </summary>
    let TruthObservation = _prefixId.prefix "TruthObservation"
    /// <summary>
    ///   <para>rdfs:label : numeric amount value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#amount">oml:amount</a>
    /// </summary>
    let amount = _prefixId.prefix "amount"
    /// <summary>
    ///   <para>dcterms:description : link to related observation^^xsd:string</para>
    ///   <para>rdfs:label : observation context</para>
    ///   <para>rdfs:comment : link to related observation
    ///
    /// The first half of the property named 'relatedObservation' in the UML model. (The rule for implementing association classes needs clarification.)^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#context">oml:context</a>
    /// </summary>
    let context = _prefixId.prefix "context"
    /// <summary>
    ///   <para>rdfs:label : Count value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#count">oml:count</a>
    /// </summary>
    let count = _prefixId.prefix "count"
    /// <summary>
    ///   <para>skos:definition : Links the Observation to the Feature that is the ultimate subject of the observation and carries the observed property. This feature is the real-world object whose properties are under observation. An observation instance serves as a propertyValueProvider for its feature-of-interest.^^xsd:string</para>
    ///   <para>rdfs:label : feature of interest</para>
    ///   <para>rdfs:comment : feature of interest of an observation
    ///
    /// Links the Observation to the Feature that is the ultimate subject of the observation and carries the observed property. This feature is the real-world object whose properties are under observation. An observation instance serves as a propertyValueProvider for its feature-of-interest.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#featureOfInterest">oml:featureOfInterest</a>
    /// </summary>
    let featureOfInterest = _prefixId.prefix "featureOfInterest"
    /// <summary>
    ///   <para>rdfs:label : has member^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#member">oml:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : is member of^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#memberOf">oml:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>skos:definition : The association Phenomenon shall link the OM_Observation to the GF_PropertyType for which the OM_Observation:result (7.2.2.9) provides an estimate of its value. The property type has the role observedProperty with respect to the observation.
    ///
    /// The observed property shall be a phenomenon associated with the feature-of-interest.
    ///
    /// An observed property may be, but need not be, modelled as a property (in the sense of the General Feature Model) in a formal application schema that defines the type of the feature-of-interest.
    ///
    /// An instance of GF_PropertyType shall describe a property that is either assignable or observable (7.1.2), such as “temperature”, “height”, “colour”, “material”. A property type may be an operation or function such as a spatiotemporal coverage. Property-type definitions may be organized into a hierarchy or ontology and managed in a register and catalogued to support discovery functions. The observed property supports semantic or thematic classification of observations, which is useful for discovery and data fusion.
    ///
    /// NOTE In general, the value of a specific observedProperty can be associated with different feature types in different observations, thus allowing the results of observations made in different projects or campaigns, and even from different disciplines, to be combined when required. A property-type register used in observations is most useful if each property type is not tied to a single feature type, or if equivalence relationships between similar property types from different feature types are provided.^^xsd:string</para>
    ///   <para>rdfs:label : observed property</para>
    ///   <para>rdfs:comment : property whose value is the result of the observation
    ///
    /// The association Phenomenon shall link the OM_Observation to the GF_PropertyType for which the OM_Observation:result (7.2.2.9) provides an estimate of its value. The property type has the role observedProperty with respect to the observation.
    ///
    /// The observed property shall be a phenomenon associated with the feature-of-interest.
    ///
    /// An observed property may be, but need not be, modelled as a property (in the sense of the General Feature Model) in a formal application schema that defines the type of the feature-of-interest.
    ///
    /// An instance of GF_PropertyType shall describe a property that is either assignable or observable (7.1.2), such as “temperature”, “height”, “colour”, “material”. A property type may be an operation or function such as a spatiotemporal coverage. Property-type definitions may be organized into a hierarchy or ontology and managed in a register and catalogued to support discovery functions. The observed property supports semantic or thematic classification of observations, which is useful for discovery and data fusion.
    ///
    /// NOTE In general, the value of a specific observedProperty can be associated with different feature types in different observations, thus allowing the results of observations made in different projects or campaigns, and even from different disciplines, to be combined when required. A property-type register used in observations is most useful if each property type is not tied to a single feature type, or if equivalence relationships between similar property types from different feature types are provided.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#observedProperty">oml:observedProperty</a>
    /// </summary>
    let observedProperty = _prefixId.prefix "observedProperty"
    /// <summary>
    ///   <para>skos:definition : The attribute phenomenonTime:TM_Object shall describe the time that the result (7.2.2.9) applies to the property of the feature-of-interest (7.2.2.7). This is often the time of interaction by a sampling procedure (9.1.3) or observation procedure (7.2.2.10) with a real-world feature.
    ///
    /// NOTE The phenomenonTime is the temporal parameter normally used in geospatial analysis of the result.
    ///
    /// If the observedProperty of an observation is ‘occurrence time’ then the result should be the same as the phenomenonTime.^^xsd:string</para>
    ///   <para>rdfs:label : phenomenon time</para>
    ///   <para>rdfs:comment : time at which the estimate of the property that is the result of the observation is associated with the feature of interest^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#phenomenonTime">oml:phenomenonTime</a>
    /// </summary>
    let phenomenonTime = _prefixId.prefix "phenomenonTime"
    /// <summary>
    ///   <para>skos:definition : The association ProcessUsed shall link the OM_Observation to the OM_Process (7.2.3) used to generate the result. The process has the role procedure with respect to the observation. A process might be responsible for more than one generatedObservation.
    ///
    /// The OM_Process shall be suitable for the observed property. As a corollary, details of the observed property are constrained by the procedure used.
    ///
    /// EXAMPLE Observed radiance wavelength is determined by the response characteristics of the sensor.
    ///
    /// A description of the observation procedure provides or implies an indication of the reliability or quality of the observation result.^^xsd:string</para>
    ///   <para>rdfs:label : observation procedure</para>
    ///   <para>rdfs:comment : procedure used in making observation. Typically a sensor or sensor-system, algorithm, computational procedure.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#procedure">oml:procedure</a>
    /// </summary>
    let procedure = _prefixId.prefix "procedure"
    /// <summary>
    ///   <para>rdfs:label : related observation</para>
    ///   <para>rdfs:comment : related observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#relatedObservation">oml:relatedObservation</a>
    /// </summary>
    let relatedObservation = _prefixId.prefix "relatedObservation"
    /// <summary>
    ///   <para>skos:definition : The association Range shall link the OM_Observation to the value generated by the procedure. The value has the role result with respect to the observation. The type of the result is shown as “Any”, since it may represent the value of any feature property.
    ///
    /// NOTE 1 OGC SWE Common [20] provides a model suitable for describing many kinds of observation results.
    ///
    /// The type of the observation result shall be consistent with the observed property, and the scale or scope for the value shall be consistent with the quantity or category type. If the observed property (7.2.2.8) is a spatial operation or function, the type of the result may be a coverage.
    ///
    /// NOTE 2 In some contexts, particularly in earth and environmental sciences, the term “observation” is used to refer to the result itself.^^xsd:string</para>
    ///   <para>rdfs:label : observation result</para>
    ///   <para>rdfs:comment : estimate of the value of the observed property^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#result">oml:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>skos:definition : The attribute resultTime:TM_Instant shall describe the time when the result became available, typically when the procedure (7.2.2.10) associated with the observation was completed. For some observations, this is identical to the phenomenonTime. However, there are important cases where they differ.
    ///
    /// EXAMPLE 1 Where a measurement is made on a specimen in a laboratory, the phenomenonTime is the time the specimen was retrieved from its host, while the resultTime is the time the laboratory procedure was applied.
    ///
    /// EXAMPLE 2 The resultTime also supports disambiguation of repeat measurements made of the same property of a feature using the same procedure.
    ///
    /// EXAMPLE 3 Where sensor observation results are post-processed, the resultTime is the post-processing time, while the phenomenonTime is the time of initial interaction with the world.
    ///
    /// EXAMPLE 4 Simulations can estimate the values for phenomena in the future or past. The phenomenonTime is the time that the result applies to, while the resultTime is the time that the simulation was executed.^^xsd:string</para>
    ///   <para>rdfs:label : result time</para>
    ///   <para>rdfs:comment : time at which the result became available, after all processing steps were completed^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#resultTime">oml:resultTime</a>
    /// </summary>
    let resultTime = _prefixId.prefix "resultTime"
    /// <summary>
    ///   <para>rdfs:label : role</para>
    ///   <para>rdfs:comment : role of related observation with respect to the observation of interest^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#role">oml:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>skos:definition : Links to a feature intended to sample the real-world object, as described in Clause 9 of ISO 19156:2011. ^^xsd:string</para>
    ///   <para>rdfs:label : sampling strategy</para>
    ///   <para>rdfs:comment : Links to a feature intended to sample the real-world object, as described in Clause 9 of ISO 19156:2011.
    ///
    /// N.B. this formulation varies from the UML model in ISO 19156, in which a sampling-feature is substitutable for the feature-of-interest. In this more explicit formulation, the (mandatory) feature-of-interest always refers to the ultimate feature of interest, whose type can carry the observed property, and the (optional) sampling strategy allows the sampling feature to be made explicit as an additional relationship. This overcomes some semantic sleight-of-hand in ISO 19156, in which the constraint the the observed property was commensurate with the feature-of-interest was allowed to be 'transitive' via the sampledFeature property.^^xsd:stringrdfs:comment : description of the sampling strategy used in an observation (usually a sampling-feature). ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#samplingStrategy">oml:samplingStrategy</a>
    /// </summary>
    let samplingStrategy = _prefixId.prefix "samplingStrategy"
    /// <summary>
    ///   <para>rdfs:label : Truth value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#truth">oml:truth</a>
    /// </summary>
    let truth = _prefixId.prefix "truth"
    /// <summary>
    ///   <para>rdfs:comment : Unit of measure or scale^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/om-lite#uom">oml:uom</a>
    /// </summary>
    let uom = _prefixId.prefix "uom"
