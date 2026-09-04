#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module om =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#" "om"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:notation : OM_CategoryObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Category Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a classification from some vocabulary or taxonomy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CategoryObservation">om:CategoryObservation</a>
    /// </summary>
    let CategoryObservation = _prefixId.prefix "CategoryObservation"
    /// <summary>
    ///   <para>skos:notation : OM_ComplexObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Complex Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a vector, record, tuple or other complex value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ComplexObservation">om:ComplexObservation</a>
    /// </summary>
    let ComplexObservation = _prefixId.prefix "ComplexObservation"
    /// <summary>
    ///   <para>skos:notation : OM_CountObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Count Observation</para>
    ///   <para>rdfs:comment : Observation whose result is an integer^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CountObservation">om:CountObservation</a>
    /// </summary>
    let CountObservation = _prefixId.prefix "CountObservation"
    /// <summary>
    ///   <para>skos:notation : OM_DiscreteCoverageObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Discrete Coverage Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a discrete representation of a spatio-temporal field, including images and time-series^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#DiscreteCoverageObservation">om:DiscreteCoverageObservation</a>
    /// </summary>
    let DiscreteCoverageObservation = _prefixId.prefix "DiscreteCoverageObservation"
    /// <summary>
    ///   <para>skos:notation : OM_GeometryObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Geometry Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a spatial object or geometry^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#GeometryObservation">om:GeometryObservation</a>
    /// </summary>
    let GeometryObservation = _prefixId.prefix "GeometryObservation"
    /// <summary>
    ///   <para>skos:notation : OM_Measurement^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Mesurerdfs:label : Measurement</para>
    ///   <para>rdfs:comment : Observation whose result is a scaled number^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Measurement">om:Measurement</a>
    /// </summary>
    let Measurement = _prefixId.prefix "Measurement"
    /// <summary>
    ///   <para>rdfs:label : Named value^^xsd:string</para>
    ///   <para>rdfs:comment : Typed value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#NamedValue">om:NamedValue</a>
    /// </summary>
    let NamedValue = _prefixId.prefix "NamedValue"
    /// <summary>
    ///   <para>rdfs:label : Observation</para>
    ///   <para>rdfs:comment : An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry “property-level” instance metadata, which complements the dataset-level and feature-level metadata that have been conventionally considered (e.g. ISO 19115).^^xsd:stringrdfs:comment : Generic observation^^xsd:string</para>
    ///   <para>skos:notation : OM_Observation^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Observation">om:Observation</a>
    /// </summary>
    let Observation = _prefixId.prefix "Observation"
    /// <summary>
    ///   <para>skos:notation : ObservationContext^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Observation context</para>
    ///   <para>rdfs:comment : Some observations depend on other observations to provide context which is important, sometimes essential, in understanding the result. These dependencies are stronger than mere spatio-temporal coincidences, requiring explicit representation. If present, the association class class ObservationContext (Figure 2) shall link a OM_Observation to another OM_Observation, with the role name relatedObservation for the target. It shall support one attribute.
    ///
    /// EXAMPLES	Some examples include the conditions associated with experimental replicates (e.g., experimental plots and treatments used), biotic factors (e.g., ecological community), interactions among features (e.g., predator-prey), or other temporary relationships occurring at the time of observation that are are not inherent to the observed features themselves (i.e., they change over time), or the related observation may provide input to a process that generates a new result.
    /// This association complements the Intention association which describes relationships between a sampling feature and domain features.^^xsd:stringrdfs:comment : Context linking two or more observations^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ObservationContext">om:ObservationContext</a>
    /// </summary>
    let ObservationContext = _prefixId.prefix "ObservationContext"
    /// <summary>
    ///   <para>skos:notation : OM_PointCoverageObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Point Coverage Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a spatio-temporal field sampled at discete points^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#PointCoverageObservation">om:PointCoverageObservation</a>
    /// </summary>
    let PointCoverageObservation = _prefixId.prefix "PointCoverageObservation"
    /// <summary>
    ///   <para>skos:notation : OM_Process^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Observation process</para>
    ///   <para>rdfs:comment : The class OM_Process (Figure 2) is an instance of the «metaclass» GF_FeatureType (ISO 19109:2005), which therefore represents a feature type. OM_Process is abstract, and has no attributes, operations or associations. It serves as the base class for observation processes. The purpose of an observation process is to generate an observation result. An instance of OM_Process is often an instrument or sensor, but may be a human observer, a simulator, or a process or algorithm applied to more primitive results used as inputs.
    ///
    /// NOTE	ISO 19115-2:2008 provides MI_Instrument, LE_Processing and LE_Algorithm, which could all be modelled as specializations of OM_Process. OGC SensorML [10] provides a model which is suitable for many observation procedures.^^xsd:stringrdfs:comment : Process used in an observation, including sensors, algorithms, computation methods^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Process">om:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>skos:notation : OM_TemporalObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Temporal Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a temporal object, such as a time instant or period^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TemporalObservation">om:TemporalObservation</a>
    /// </summary>
    let TemporalObservation = _prefixId.prefix "TemporalObservation"
    /// <summary>
    ///   <para>skos:notation : OM_TimeSeriesObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Time Series Observation</para>
    ///   <para>rdfs:comment : Observation whose result is a time-series^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TimeSeriesObservation">om:TimeSeriesObservation</a>
    /// </summary>
    let TimeSeriesObservation = _prefixId.prefix "TimeSeriesObservation"
    /// <summary>
    ///   <para>skos:notation : OM_TruthObservation^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Truth Observation</para>
    ///   <para>rdfs:comment : Observation whose result is either true or false^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TruthObservation">om:TruthObservation</a>
    /// </summary>
    let TruthObservation = _prefixId.prefix "TruthObservation"
    /// <summary>
    ///   <para>skos:definition : The association Domain shall link the OM_Observation to the GFI_Feature (C.2.1) that is the subject of the observation and carries the observed property. This feature has the role featureOfInterest with respect to the observation. This feature is the real-world object whose properties are under observation, or is a feature intended to sample the real-world object, as described in Clause 9 of this International Standard. An observation instance serves as a propertyValueProvider for its feature-of-interest.^^xsd:string</para>
    ///   <para>rdfs:label : feature of interest</para>
    ///   <para>rdfs:comment : feature of interest of an observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#featureOfInterest">om:featureOfInterest</a>
    /// </summary>
    let featureOfInterest = _prefixId.prefix "featureOfInterest"
    /// <summary>
    ///   <para>skos:definition : the association Metadata shall link the OM_Observation to descriptive metadata.^^xsd:string</para>
    ///   <para>rdfs:label : observation metadata</para>
    ///   <para>rdfs:comment : generic metadata about an observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#metadata">om:metadata</a>
    /// </summary>
    let metadata = _prefixId.prefix "metadata"
    /// <summary>
    ///   <para>rdfs:label : named value key^^xsd:string</para>
    ///   <para>rdfs:comment : key indicating the type of a named value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#name">om:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : observation context</para>
    ///   <para>rdfs:comment : This property is named 'relatedObservation' in the XML implementation. The rule for association classes needs clarification.^^xsd:stringrdfs:comment : link to related observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observationContext">om:observationContext</a>
    /// </summary>
    let observationContext = _prefixId.prefix "observationContext"
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
    ///   <para>rdfs:comment : property whose value is the result of the observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observedProperty">om:observedProperty</a>
    /// </summary>
    let observedProperty = _prefixId.prefix "observedProperty"
    /// <summary>
    ///   <para>skos:definition : the attributes parameter:NamedValue shall describe an arbitrary event-specific parameter. This might be an environmental parameter, an instrument setting or input, or an event-specific sampling parameter that is not tightly bound to either the feature-of-interest (7.2.2.7) or to the observation procedure (7.2.2.10). To avoid ambiguity, there shall be no more than one parameter with the same name.
    ///
    /// NOTE Parameters that are tightly bound to the procedure can be recorded as part of the procedure description.
    ///
    /// In some contexts, the Observation::procedure (7.2.2.10) is a generic or standard procedure, rather than an event-specific process. In this context, parameters bound to the observation act, such as instrument settings, calibrations or inputs, local position, detection limits, asset identifier, operator, may augment the description of a standard procedure.
    ///
    /// EXAMPLE A time sequence of observations of water quality in a well might be made at variable depths within the well. While these can be associated with specimens taken from the well at this depth as the features-of-interest, a more common approach is to identify the well itself as the feature-of-interest, and add a “samplingDepth” parameter to the
    /// observation (Figure 3). The sampling depth is of secondary interest compared to the temporal variation of water quality at the site.^^xsd:string</para>
    ///   <para>rdfs:label : parameter</para>
    ///   <para>rdfs:comment : observation-specific parameter not accommodated by the standard observation properties. Often used to record environmental parameters^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#parameter">om:parameter</a>
    /// </summary>
    let parameter = _prefixId.prefix "parameter"
    /// <summary>
    ///   <para>skos:definition : The attribute phenomenonTime:TM_Object shall describe the time that the result (7.2.2.9) applies to the property of the feature-of-interest (7.2.2.7). This is often the time of interaction by a sampling procedure (9.1.3) or observation procedure (7.2.2.10) with a real-world feature.
    ///
    /// NOTE The phenomenonTime is the temporal parameter normally used in geospatial analysis of the result.
    ///
    /// If the observedProperty of an observation is ‘occurrence time’ then the result should be the same as the phenomenonTime.^^xsd:string</para>
    ///   <para>rdfs:label : phenomenon time</para>
    ///   <para>rdfs:comment : time at which the estimate of the property that is the result of the observation is associated with the feature of interest^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#phenomenonTime">om:phenomenonTime</a>
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
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#procedure">om:procedure</a>
    /// </summary>
    let procedure = _prefixId.prefix "procedure"
    /// <summary>
    ///   <para>rdfs:label : related observation</para>
    ///   <para>rdfs:comment : related observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#relatedObservation">om:relatedObservation</a>
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
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#result">om:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>skos:definition : the attributes resultQuality:DQ_Element shall describe the quality of the result (7.2.2.9). This instance-specific description complements the description of the observation procedure (7.2.2.10), which provides information concerning the quality of all observations using this procedure. The quality of a result may be assessed following the procedures in ISO 19157. Multiple measures may be provided.^^xsd:string</para>
    ///   <para>rdfs:label : result quality</para>
    ///   <para>rdfs:comment : assessment of the quality of the observation result. The value should be specific to this observation instance, in addition to any quality that is inferred from the observation procedure used^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultQuality">om:resultQuality</a>
    /// </summary>
    let resultQuality = _prefixId.prefix "resultQuality"
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
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultTime">om:resultTime</a>
    /// </summary>
    let resultTime = _prefixId.prefix "resultTime"
    /// <summary>
    ///   <para>rdfs:label : role</para>
    ///   <para>rdfs:comment : role of related observation with respect to the observation of interest^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#role">om:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>skos:definition : the attribute validTime:TM_Period shall describe the time period during which the result is intended to be used.
    ///
    /// NOTE This attribute is commonly required in forecasting applications.^^xsd:string</para>
    ///   <para>rdfs:label : valid time</para>
    ///   <para>rdfs:comment : time during which the observation result is recommended for use. Most often used in relation to forecasts, but may be used any time the observation procedure (including inputs) is liable to modification. ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#validTime">om:validTime</a>
    /// </summary>
    let validTime = _prefixId.prefix "validTime"
    /// <summary>
    ///   <para>rdfs:label : named value value^^xsd:string</para>
    ///   <para>rdfs:comment : value of named value^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#value">om:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
