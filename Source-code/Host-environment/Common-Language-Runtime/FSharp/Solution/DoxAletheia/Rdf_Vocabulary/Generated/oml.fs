namespace http.def.seegrid.csiro.au.ontology.om.om_lite.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oml =
    let _namespace_iri = Namespace_Iri oml |> NamespaceIRI
    /// <summary>
    ///   <para>oml:count</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Count value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#count">http://def.seegrid.csiro.au/ontology/om/om-lite#count</seealso>
    let count = Prefixed_Name(oml, "count") |> PrefixedName
    /// <summary>
    ///   <para>oml:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>estimate of the value of the observed property</para>
    /// labels<para>observation result</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#result">http://def.seegrid.csiro.au/ontology/om/om-lite#result</seealso>
    let result = Prefixed_Name(oml, "result") |> PrefixedName
    /// <summary>
    ///   <para>oml:MeasureObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scaled number
    ///
    /// This is an abstract class, which should be substituted by a suitable concrete representation of a measure or quantity at run-tme.
    ///
    /// oml:SimpleMeasure
    /// qudt:QuantityValue &lt;http://qudt.org/schema/qudt#QuantityValue&gt;
    /// DUL:Region &lt;http://www.loa-cnr.it/ontologies/DUL.owl#Region&gt;
    ///
    /// are candidates. </para>
    /// labels<para>Measure</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#MeasureObject">http://def.seegrid.csiro.au/ontology/om/om-lite#MeasureObject</seealso>
    let MeasureObject = Prefixed_Name(oml, "MeasureObject") |> PrefixedName
    /// <summary>
    ///   <para>oml:observedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>property whose value is the result of the observation
    ///
    /// The association Phenomenon shall link the OM_Observation to the GF_PropertyType for which the OM_Observation:result (7.2.2.9) provides an estimate of its value. The property type has the role observedProperty with respect to the observation.
    ///
    /// The observed property shall be a phenomenon associated with the feature-of-interest.
    ///
    /// An observed property may be, but need not be, modelled as a property (in the sense of the General Feature Model) in a formal application schema that defines the type of the feature-of-interest.
    ///
    /// An instance of GF_PropertyType shall describe a property that is either assignable or observable (7.1.2), such as “temperature”, “height”, “colour”, “material”. A property type may be an operation or function such as a spatiotemporal coverage. Property-type definitions may be organized into a hierarchy or ontology and managed in a register and catalogued to support discovery functions. The observed property supports semantic or thematic classification of observations, which is useful for discovery and data fusion.
    ///
    /// NOTE In general, the value of a specific observedProperty can be associated with different feature types in different observations, thus allowing the results of observations made in different projects or campaigns, and even from different disciplines, to be combined when required. A property-type register used in observations is most useful if each property type is not tied to a single feature type, or if equivalence relationships between similar property types from different feature types are provided.</para>
    /// labels<para>observed property</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#observedProperty">http://def.seegrid.csiro.au/ontology/om/om-lite#observedProperty</seealso>
    let observedProperty = Prefixed_Name(oml, "observedProperty") |> PrefixedName
    /// <summary>
    ///   <para>oml:TruthObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Object to wrap a truth value</para>
    /// labels<para>Truth object</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObject">http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObject</seealso>
    let TruthObject = Prefixed_Name(oml, "TruthObject") |> PrefixedName
    /// <summary>
    ///   <para>oml:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a scaled number</para>
    /// labels<para>Measurement</para><para>Mesure</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#Measurement">http://def.seegrid.csiro.au/ontology/om/om-lite#Measurement</seealso>
    let Measurement = Prefixed_Name(oml, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>oml:featureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>feature of interest of an observation
    ///
    /// Links the Observation to the Feature that is the ultimate subject of the observation and carries the observed property. This feature is the real-world object whose properties are under observation. An observation instance serves as a propertyValueProvider for its feature-of-interest.</para>
    /// labels<para>feature of interest</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#featureOfInterest">http://def.seegrid.csiro.au/ontology/om/om-lite#featureOfInterest</seealso>
    let featureOfInterest = Prefixed_Name(oml, "featureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>oml:procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>procedure used in making observation. Typically a sensor or sensor-system, algorithm, computational procedure.</para>
    /// labels<para>observation procedure</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#procedure">http://def.seegrid.csiro.au/ontology/om/om-lite#procedure</seealso>
    let procedure = Prefixed_Name(oml, "procedure") |> PrefixedName
    /// <summary>
    ///   <para>oml:phenomenonTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>time at which the estimate of the property that is the result of the observation is associated with the feature of interest</para>
    /// labels<para>phenomenon time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#phenomenonTime">http://def.seegrid.csiro.au/ontology/om/om-lite#phenomenonTime</seealso>
    let phenomenonTime = Prefixed_Name(oml, "phenomenonTime") |> PrefixedName
    /// <summary>
    ///   <para>oml:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.</para>
    /// labels<para>Observation process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#Process">http://def.seegrid.csiro.au/ontology/om/om-lite#Process</seealso>
    let Process = Prefixed_Name(oml, "Process") |> PrefixedName
    /// <summary>
    ///   <para>oml:ObservationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agent, device, sensor, software, protocol, computational method, algorithm or plan responsible for generating an observation result. Input may be a sensor stimulus, or the output from a previous process.</para>
    /// labels<para>Observation agent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationAgent">http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationAgent</seealso>
    let ObservationAgent = Prefixed_Name(oml, "ObservationAgent") |> PrefixedName

    /// <summary>
    ///   <para>oml:ObservationCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A collection of observations.
    ///
    /// The collection may be homogeneous in one or more of the feature-of-interest, observed-property, procedures, phenomenon-time or result-time. If only one value for any of these properties is provided on the collection, then it may be inferred to be a common (default) value for all the member observations, unless locally overridden.</para>
    /// labels<para>Collection of observations</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationCollection">http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationCollection</seealso>
    let ObservationCollection =
        Prefixed_Name(oml, "ObservationCollection") |> PrefixedName

    /// <summary>
    ///   <para>oml:ObservationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Some observations depend on other observations to provide context which is important, sometimes essential, in understanding the result. These dependencies are stronger than mere spatio-temporal coincidences, requiring explicit representation. If present, the association class class ObservationContext (Figure 2) shall link a OM_Observation to another OM_Observation, with the role name relatedObservation for the target. It shall support one attribute.
    ///
    /// EXAMPLES	Some examples include the conditions associated with experimental replicates (e.g., experimental plots and treatments used), biotic factors (e.g., ecological community), interactions among features (e.g., predator-prey), or other temporary relationships occurring at the time of observation that are are not inherent to the observed features themselves (i.e., they change over time), or the related observation may provide input to a process that generates a new result.
    /// This association complements the Intention association which describes relationships between a sampling feature and domain features.</para>
    /// labels<para>Observation context</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationContext">http://def.seegrid.csiro.au/ontology/om/om-lite#ObservationContext</seealso>
    let ObservationContext = Prefixed_Name(oml, "ObservationContext") |> PrefixedName
    /// <summary>
    ///   <para>oml:resultTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>time at which the result became available, after all processing steps were completed</para>
    /// labels<para>result time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#resultTime">http://def.seegrid.csiro.au/ontology/om/om-lite#resultTime</seealso>
    let resultTime = Prefixed_Name(oml, "resultTime") |> PrefixedName
    /// <summary>
    ///   <para>oml:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#member">http://def.seegrid.csiro.au/ontology/om/om-lite#member</seealso>
    let member_ = Prefixed_Name(oml, "member") |> PrefixedName
    /// <summary>
    ///   <para>oml:relatedObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>related observation</para>
    /// labels<para>related observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#relatedObservation">http://def.seegrid.csiro.au/ontology/om/om-lite#relatedObservation</seealso>
    let relatedObservation = Prefixed_Name(oml, "relatedObservation") |> PrefixedName
    /// <summary>
    ///   <para>oml:uom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Unit of measure or scale</para>
    /// </remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#uom">http://def.seegrid.csiro.au/ontology/om/om-lite#uom</seealso>
    let uom = Prefixed_Name(oml, "uom") |> PrefixedName
    /// <summary>
    ///   <para>oml:TemporalObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Temporal geometry or topology, collection or complex.
    ///
    /// Temporal object has properties relating to time only.</para>
    /// labels<para>Temporal object</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObject">http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObject</seealso>
    let TemporalObject = Prefixed_Name(oml, "TemporalObject") |> PrefixedName
    /// <summary>
    ///   <para>oml:TemporalObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a temporal object, such as a time instant or period</para>
    /// labels<para>Temporal Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObservation">http://def.seegrid.csiro.au/ontology/om/om-lite#TemporalObservation</seealso>
    let TemporalObservation = Prefixed_Name(oml, "TemporalObservation") |> PrefixedName
    /// <summary>
    ///   <para>oml:SimpleMeasure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple implementation of a scaled number as an (amount, unit) pair</para>
    /// labels<para>Simple measure (quantity)</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure">http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure</seealso>
    let SimpleMeasure = Prefixed_Name(oml, "SimpleMeasure") |> PrefixedName
    /// <summary>
    ///   <para>oml:amount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>numeric amount value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#amount">http://def.seegrid.csiro.au/ontology/om/om-lite#amount</seealso>
    let amount = Prefixed_Name(oml, "amount") |> PrefixedName
    /// <summary>
    ///   <para>oml:TruthObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is either true or false</para>
    /// labels<para>Truth Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObservation">http://def.seegrid.csiro.au/ontology/om/om-lite#TruthObservation</seealso>
    let TruthObservation = Prefixed_Name(oml, "TruthObservation") |> PrefixedName
    /// <summary>
    ///   <para>oml:truth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>Truth value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#truth">http://def.seegrid.csiro.au/ontology/om/om-lite#truth</seealso>
    let truth = Prefixed_Name(oml, "truth") |> PrefixedName
    /// <summary>
    ///   <para>oml:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>link to related observation
    ///
    /// The first half of the property named 'relatedObservation' in the UML model. (The rule for implementing association classes needs clarification.)</para>
    /// labels<para>observation context</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#context">http://def.seegrid.csiro.au/ontology/om/om-lite#context</seealso>
    let context = Prefixed_Name(oml, "context") |> PrefixedName
    /// <summary>
    ///   <para>oml:memberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>is member of</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#memberOf">http://def.seegrid.csiro.au/ontology/om/om-lite#memberOf</seealso>
    let memberOf = Prefixed_Name(oml, "memberOf") |> PrefixedName
    /// <summary>
    ///   <para>oml:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>role of related observation with respect to the observation of interest</para>
    /// labels<para>role</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#role">http://def.seegrid.csiro.au/ontology/om/om-lite#role</seealso>
    let role = Prefixed_Name(oml, "role") |> PrefixedName
    /// <summary>
    ///   <para>oml:samplingStrategy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>description of the sampling strategy used in an observation (usually a sampling-feature). </para>
    ///   <para>Links to a feature intended to sample the real-world object, as described in Clause 9 of ISO 19156:2011.
    ///
    /// N.B. this formulation varies from the UML model in ISO 19156, in which a sampling-feature is substitutable for the feature-of-interest. In this more explicit formulation, the (mandatory) feature-of-interest always refers to the ultimate feature of interest, whose type can carry the observed property, and the (optional) sampling strategy allows the sampling feature to be made explicit as an additional relationship. This overcomes some semantic sleight-of-hand in ISO 19156, in which the constraint the the observed property was commensurate with the feature-of-interest was allowed to be 'transitive' via the sampledFeature property.</para>
    /// labels<para>sampling strategy</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#samplingStrategy">http://def.seegrid.csiro.au/ontology/om/om-lite#samplingStrategy</seealso>
    let samplingStrategy = Prefixed_Name(oml, "samplingStrategy") |> PrefixedName
    /// <summary>
    ///   <para>oml:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#">http://def.seegrid.csiro.au/ontology/om/om-lite#</seealso>
    let _prefix_iri = Prefixed_Name(oml, "") |> PrefixedName
    /// <summary>
    ///   <para>oml:CountObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Object to wrap a count value</para>
    /// labels<para>Count object</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#CountObject">http://def.seegrid.csiro.au/ontology/om/om-lite#CountObject</seealso>
    let CountObject = Prefixed_Name(oml, "CountObject") |> PrefixedName
    /// <summary>
    ///   <para>oml:CountObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is an integer</para>
    /// labels<para>Count Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#CountObservation">http://def.seegrid.csiro.au/ontology/om/om-lite#CountObservation</seealso>
    let CountObservation = Prefixed_Name(oml, "CountObservation") |> PrefixedName
    /// <summary>
    ///   <para>oml:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry metadata about an instance of a property (of the feature of interest). This property-value metadata complements the dataset and feature metadata that have been conventionally considered (e.g. ISO 19115).
    ///
    /// The values for the properties 'procedure', 'featureOfInterest', 'observedProperty', 'phenomenonTime', 'resultTime' may be inherited from a container resource.</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#Observation">http://def.seegrid.csiro.au/ontology/om/om-lite#Observation</seealso>
    let Observation = Prefixed_Name(oml, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>oml:GeometryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This stub is included in the om: ontology to support references to geometry as the result of a GeometryObservation.  An existing OWL class that represents the notion of a geometry may be asserted to be a sub-class of this stub, without requiring use of a specific representation of Geometry in the context of observations instance.</para>
    /// labels<para>Geometry object</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObject">http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObject</seealso>
    let GeometryObject = Prefixed_Name(oml, "GeometryObject") |> PrefixedName
    /// <summary>
    ///   <para>oml:GeometryObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a geometry object, such as a point, curve, surface or solid</para>
    /// labels<para>Geometry Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObservation">http://def.seegrid.csiro.au/ontology/om/om-lite#GeometryObservation</seealso>
    let GeometryObservation = Prefixed_Name(oml, "GeometryObservation") |> PrefixedName
