namespace http.def.seegrid.csiro.au.ontology.om.om_lite.hash

open DoxAletheia

module oml =
    let _namespace_name = "http://def.seegrid.csiro.au/ontology/om/om-lite#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Object to wrap a count value
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#CountObject"></see></summary>
    let CountObject = _prefix "CountObject"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#count"></see>
    /// </summary>
    let count = _prefix "count"
    /// <summary>
    /// Observation whose result is an integer
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#CountObservation"></see></summary>
    let CountObservation = _prefix "CountObservation"
    /// <summary>
    /// estimate of the value of the observed property
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry metadata about an instance of a property (of the feature of interest). This property-value metadata complements the dataset and feature metadata that have been conventionally considered (e.g. ISO 19115).
    ///
    /// The values for the properties 'procedure', 'featureOfInterest', 'observedProperty', 'phenomenonTime', 'resultTime' may be inherited from a container resource.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// This stub is included in the om: ontology to support references to geometry as the result of a GeometryObservation.  An existing OWL class that represents the notion of a geometry may be asserted to be a sub-class of this stub, without requiring use of a specific representation of Geometry in the context of observations instance.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObject"></see></summary>
    let GeometryObject = _prefix "GeometryObject"
    /// <summary>
    /// Observation whose result is a geometry object, such as a point, curve, surface or solid
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObservation"></see></summary>
    let GeometryObservation = _prefix "GeometryObservation"
    /// <summary>
    /// Scaled number
    ///
    /// This is an abstract class, which should be substituted by a suitable concrete representation of a measure or quantity at run-tme.
    ///
    /// oml:SimpleMeasure
    /// qudt:QuantityValue &lt;http://qudt.org/schema/qudt#QuantityValue&gt;
    /// DUL:Region &lt;http://www.loa-cnr.it/ontologies/DUL.owl#Region&gt;
    ///
    /// are candidates.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#MeasureObject"></see></summary>
    let MeasureObject = _prefix "MeasureObject"
    /// <summary>
    /// Observation whose result is a scaled number
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// property whose value is the result of the observation
    ///
    /// The association Phenomenon shall link the OM_Observation to the GF_PropertyType for which the OM_Observation:result (7.2.2.9) provides an estimate of its value. The property type has the role observedProperty with respect to the observation.
    ///
    /// The observed property shall be a phenomenon associated with the feature-of-interest.
    ///
    /// An observed property may be, but need not be, modelled as a property (in the sense of the General Feature Model) in a formal application schema that defines the type of the feature-of-interest.
    ///
    /// An instance of GF_PropertyType shall describe a property that is either assignable or observable (7.1.2), such as “temperature”, “height”, “colour”, “material”. A property type may be an operation or function such as a spatiotemporal coverage. Property-type definitions may be organized into a hierarchy or ontology and managed in a register and catalogued to support discovery functions. The observed property supports semantic or thematic classification of observations, which is useful for discovery and data fusion.
    ///
    /// NOTE In general, the value of a specific observedProperty can be associated with different feature types in different observations, thus allowing the results of observations made in different projects or campaigns, and even from different disciplines, to be combined when required. A property-type register used in observations is most useful if each property type is not tied to a single feature type, or if equivalence relationships between similar property types from different feature types are provided.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#observedProperty"></see></summary>
    let observedProperty = _prefix "observedProperty"
    /// <summary>
    /// feature of interest of an observation
    ///
    /// Links the Observation to the Feature that is the ultimate subject of the observation and carries the observed property. This feature is the real-world object whose properties are under observation. An observation instance serves as a propertyValueProvider for its feature-of-interest.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#featureOfInterest"></see></summary>
    let featureOfInterest = _prefix "featureOfInterest"
    /// <summary>
    /// procedure used in making observation. Typically a sensor or sensor-system, algorithm, computational procedure.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#procedure"></see></summary>
    let procedure = _prefix "procedure"
    /// <summary>
    /// time at which the estimate of the property that is the result of the observation is associated with the feature of interest
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#phenomenonTime"></see></summary>
    let phenomenonTime = _prefix "phenomenonTime"
    /// <summary>
    /// time at which the result became available, after all processing steps were completed
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#resultTime"></see></summary>
    let resultTime = _prefix "resultTime"
    /// <summary>
    /// Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationAgent"></see></summary>
    let ObservationAgent = _prefix "ObservationAgent"
    /// <summary>
    /// A collection of observations.
    ///
    /// The collection may be homogeneous in one or more of the feature-of-interest, observed-property, procedures, phenomenon-time or result-time. If only one value for any of these properties is provided on the collection, then it may be inferred to be a common (default) value for all the member observations, unless locally overridden.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationCollection"></see></summary>
    let ObservationCollection = _prefix "ObservationCollection"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#member"></see>
    /// </summary>
    let member_ = _prefix "member"
    /// <summary>
    /// Some observations depend on other observations to provide context which is important, sometimes essential, in understanding the result. These dependencies are stronger than mere spatio-temporal coincidences, requiring explicit representation. If present, the association class class ObservationContext (Figure 2) shall link a OM_Observation to another OM_Observation, with the role name relatedObservation for the target. It shall support one attribute.
    ///
    /// EXAMPLES	Some examples include the conditions associated with experimental replicates (e.g., experimental plots and treatments used), biotic factors (e.g., ecological community), interactions among features (e.g., predator-prey), or other temporary relationships occurring at the time of observation that are are not inherent to the observed features themselves (i.e., they change over time), or the related observation may provide input to a process that generates a new result.
    /// This association complements the Intention association which describes relationships between a sampling feature and domain features.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationContext"></see></summary>
    let ObservationContext = _prefix "ObservationContext"
    /// <summary>
    /// related observation
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#relatedObservation"></see></summary>
    let relatedObservation = _prefix "relatedObservation"
    /// <summary>
    /// Simple implementation of a scaled number as an (amount, unit) pair
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure"></see></summary>
    let SimpleMeasure = _prefix "SimpleMeasure"
    /// <summary>
    /// Unit of measure or scale
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#uom"></see></summary>
    let uom = _prefix "uom"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#amount"></see>
    /// </summary>
    let amount = _prefix "amount"
    /// <summary>
    /// Temporal geometry or topology, collection or complex.
    ///
    /// Temporal object has properties relating to time only.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObject"></see></summary>
    let TemporalObject = _prefix "TemporalObject"
    /// <summary>
    /// Observation whose result is a temporal object, such as a time instant or period
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObservation"></see></summary>
    let TemporalObservation = _prefix "TemporalObservation"
    /// <summary>
    /// Object to wrap a truth value
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObject"></see></summary>
    let TruthObject = _prefix "TruthObject"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#truth"></see>
    /// </summary>
    let truth = _prefix "truth"
    /// <summary>
    /// Observation whose result is either true or false
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObservation"></see></summary>
    let TruthObservation = _prefix "TruthObservation"
    /// <summary>
    /// link to related observation
    ///
    /// The first half of the property named 'relatedObservation' in the UML model. (The rule for implementing association classes needs clarification.)
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#memberOf"></see>
    /// </summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// role of related observation with respect to the observation of interest
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// Links to a feature intended to sample the real-world object, as described in Clause 9 of ISO 19156:2011.
    ///
    /// N.B. this formulation varies from the UML model in ISO 19156, in which a sampling-feature is substitutable for the feature-of-interest. In this more explicit formulation, the (mandatory) feature-of-interest always refers to the ultimate feature of interest, whose type can carry the observed property, and the (optional) sampling strategy allows the sampling feature to be made explicit as an additional relationship. This overcomes some semantic sleight-of-hand in ISO 19156, in which the constraint the the observed property was commensurate with the feature-of-interest was allowed to be 'transitive' via the sampledFeature property.
    /// description of the sampling strategy used in an observation (usually a sampling-feature).
    /// <see href="http://def.seegrid.csiro.au/ontology/om/om-lite#samplingStrategy"></see></summary>
    let samplingStrategy = _prefix "samplingStrategy"
