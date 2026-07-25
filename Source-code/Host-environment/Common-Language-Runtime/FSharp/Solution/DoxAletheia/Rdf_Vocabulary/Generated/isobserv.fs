namespace http.def.seegrid.csiro.au.isotc211.iso19156._2011.observation.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module isobserv =
    let _namespace_iri = Namespace_Iri isobserv |> NamespaceIRI
    /// <summary>
    ///   <para>isobserv:observedProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>property whose value is the result of the observation</para>
    /// labels<para>observed property</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observedProperty">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observedProperty</seealso>
    let observedProperty = Prefixed_Name(isobserv, "observedProperty") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:value</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>value of named value</para>
    /// labels<para>named value value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#value">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#value</seealso>
    let value = Prefixed_Name(isobserv, "value") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:observationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property is named 'relatedObservation' in the XML implementation. The rule for association classes needs clarification.</para>
    ///   <para>link to related observation</para>
    /// labels<para>observation context</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observationContext">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observationContext</seealso>
    let observationContext =
        Prefixed_Name(isobserv, "observationContext") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:Observation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry “property-level” instance metadata, which complements the dataset-level and feature-level metadata that have been conventionally considered (e.g. ISO 19115).</para>
    ///   <para>Generic observation</para>
    /// labels<para>Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Observation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Observation</seealso>
    let Observation = Prefixed_Name(isobserv, "Observation") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:CountObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is an integer</para>
    /// labels<para>Count Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CountObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CountObservation</seealso>
    let CountObservation = Prefixed_Name(isobserv, "CountObservation") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>key indicating the type of a named value</para>
    /// labels<para>named value key</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#name">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#name</seealso>
    let name = Prefixed_Name(isobserv, "name") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:Measurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a scaled number</para>
    /// labels<para>Measurement</para><para>Mesure</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Measurement">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Measurement</seealso>
    let Measurement = Prefixed_Name(isobserv, "Measurement") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>role of related observation with respect to the observation of interest</para>
    /// labels<para>role</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#role">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#role</seealso>
    let role = Prefixed_Name(isobserv, "role") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class OM_Process (Figure 2) is an instance of the «metaclass» GF_FeatureType (ISO 19109:2005), which therefore represents a feature type. OM_Process is abstract, and has no attributes, operations or associations. It serves as the base class for observation processes. The purpose of an observation process is to generate an observation result. An instance of OM_Process is often an instrument or sensor, but may be a human observer, a simulator, or a process or algorithm applied to more primitive results used as inputs.
    ///
    /// NOTE	ISO 19115-2:2008 provides MI_Instrument, LE_Processing and LE_Algorithm, which could all be modelled as specializations of OM_Process. OGC SensorML [10] provides a model which is suitable for many observation procedures.</para>
    ///   <para>Process used in an observation, including sensors, algorithms, computation methods</para>
    /// labels<para>Observation process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Process">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Process</seealso>
    let Process = Prefixed_Name(isobserv, "Process") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:GeometryObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a spatial object or geometry</para>
    /// labels<para>Geometry Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#GeometryObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#GeometryObservation</seealso>
    let GeometryObservation =
        Prefixed_Name(isobserv, "GeometryObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:phenomenonTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>time at which the estimate of the property that is the result of the observation is associated with the feature of interest</para>
    /// labels<para>phenomenon time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#phenomenonTime">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#phenomenonTime</seealso>
    let phenomenonTime = Prefixed_Name(isobserv, "phenomenonTime") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:CategoryObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a classification from some vocabulary or taxonomy</para>
    /// labels<para>Category Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CategoryObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CategoryObservation</seealso>
    let CategoryObservation =
        Prefixed_Name(isobserv, "CategoryObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:ComplexObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a vector, record, tuple or other complex value</para>
    /// labels<para>Complex Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ComplexObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ComplexObservation</seealso>
    let ComplexObservation =
        Prefixed_Name(isobserv, "ComplexObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:procedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>procedure used in making observation. Typically a sensor or sensor-system, algorithm, computational procedure.</para>
    /// labels<para>observation procedure</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#procedure">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#procedure</seealso>
    let procedure = Prefixed_Name(isobserv, "procedure") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:PointCoverageObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a spatio-temporal field sampled at discete points</para>
    /// labels<para>Point Coverage Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#PointCoverageObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#PointCoverageObservation</seealso>
    let PointCoverageObservation =
        Prefixed_Name(isobserv, "PointCoverageObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:resultQuality</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>assessment of the quality of the observation result. The value should be specific to this observation instance, in addition to any quality that is inferred from the observation procedure used</para>
    /// labels<para>result quality</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultQuality">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultQuality</seealso>
    let resultQuality = Prefixed_Name(isobserv, "resultQuality") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>estimate of the value of the observed property</para>
    /// labels<para>observation result</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#result">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#result</seealso>
    let result = Prefixed_Name(isobserv, "result") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:ObservationContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Some observations depend on other observations to provide context which is important, sometimes essential, in understanding the result. These dependencies are stronger than mere spatio-temporal coincidences, requiring explicit representation. If present, the association class class ObservationContext (Figure 2) shall link a OM_Observation to another OM_Observation, with the role name relatedObservation for the target. It shall support one attribute.
    ///
    /// EXAMPLES	Some examples include the conditions associated with experimental replicates (e.g., experimental plots and treatments used), biotic factors (e.g., ecological community), interactions among features (e.g., predator-prey), or other temporary relationships occurring at the time of observation that are are not inherent to the observed features themselves (i.e., they change over time), or the related observation may provide input to a process that generates a new result.
    /// This association complements the Intention association which describes relationships between a sampling feature and domain features.</para>
    ///   <para>Context linking two or more observations</para>
    /// labels<para>Observation context</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ObservationContext">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ObservationContext</seealso>
    let ObservationContext =
        Prefixed_Name(isobserv, "ObservationContext") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:TemporalObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a temporal object, such as a time instant or period</para>
    /// labels<para>Temporal Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TemporalObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TemporalObservation</seealso>
    let TemporalObservation =
        Prefixed_Name(isobserv, "TemporalObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:validTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>time during which the observation result is recommended for use. Most often used in relation to forecasts, but may be used any time the observation procedure (including inputs) is liable to modification. </para>
    /// labels<para>valid time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#validTime">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#validTime</seealso>
    let validTime = Prefixed_Name(isobserv, "validTime") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:relatedObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>related observation</para>
    /// labels<para>related observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#relatedObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#relatedObservation</seealso>
    let relatedObservation =
        Prefixed_Name(isobserv, "relatedObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:resultTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>time at which the result became available, after all processing steps were completed</para>
    /// labels<para>result time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultTime">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultTime</seealso>
    let resultTime = Prefixed_Name(isobserv, "resultTime") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:metadata</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>generic metadata about an observation</para>
    /// labels<para>observation metadata</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#metadata">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#metadata</seealso>
    let metadata = Prefixed_Name(isobserv, "metadata") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:TimeSeriesObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a time-series</para>
    /// labels<para>Time Series Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TimeSeriesObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TimeSeriesObservation</seealso>
    let TimeSeriesObservation =
        Prefixed_Name(isobserv, "TimeSeriesObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:TruthObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is either true or false</para>
    /// labels<para>Truth Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TruthObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TruthObservation</seealso>
    let TruthObservation = Prefixed_Name(isobserv, "TruthObservation") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:NamedValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Typed value</para>
    /// labels<para>Named value</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#NamedValue">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#NamedValue</seealso>
    let NamedValue = Prefixed_Name(isobserv, "NamedValue") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#</seealso>
    let _prefix_iri = Prefixed_Name(isobserv, "") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:DiscreteCoverageObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Observation whose result is a discrete representation of a spatio-temporal field, including images and time-series</para>
    /// labels<para>Discrete Coverage Observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#DiscreteCoverageObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#DiscreteCoverageObservation</seealso>
    let DiscreteCoverageObservation =
        Prefixed_Name(isobserv, "DiscreteCoverageObservation") |> PrefixedName

    /// <summary>
    ///   <para>isobserv:featureOfInterest</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>feature of interest of an observation</para>
    /// labels<para>feature of interest</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#featureOfInterest">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#featureOfInterest</seealso>
    let featureOfInterest = Prefixed_Name(isobserv, "featureOfInterest") |> PrefixedName
    /// <summary>
    ///   <para>isobserv:parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>observation-specific parameter not accommodated by the standard observation properties. Often used to record environmental parameters</para>
    /// labels<para>parameter</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#parameter">http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#parameter</seealso>
    let parameter = Prefixed_Name(isobserv, "parameter") |> PrefixedName
