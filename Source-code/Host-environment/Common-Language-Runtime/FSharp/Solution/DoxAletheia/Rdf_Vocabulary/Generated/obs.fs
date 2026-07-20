namespace http.def.seegrid.csiro.au.isotc211.iso19156._2011.observation.hash

open DoxAletheia

module obs =
    let _namespace_name =
        "http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Observation whose result is a scaled number
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Measurement"></see></summary>
    let Measurement = _prefix "Measurement"
    /// <summary>
    /// property whose value is the result of the observation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observedProperty"></see></summary>
    let observedProperty = _prefix "observedProperty"
    /// <summary>
    /// Observation whose result is a spatio-temporal field sampled at discete points
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#PointCoverageObservation"></see></summary>
    let PointCoverageObservation = _prefix "PointCoverageObservation"
    /// <summary>
    /// time during which the observation result is recommended for use. Most often used in relation to forecasts, but may be used any time the observation procedure (including inputs) is liable to modification.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#validTime"></see></summary>
    let validTime = _prefix "validTime"
    /// <summary>
    /// Observation whose result is either true or false
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TruthObservation"></see></summary>
    let TruthObservation = _prefix "TruthObservation"
    /// <summary>
    /// Observation whose result is a discrete representation of a spatio-temporal field, including images and time-series
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#DiscreteCoverageObservation"></see></summary>
    let DiscreteCoverageObservation = _prefix "DiscreteCoverageObservation"
    /// <summary>
    /// role of related observation with respect to the observation of interest
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#role"></see></summary>
    let role = _prefix "role"
    /// <summary>
    /// assessment of the quality of the observation result. The value should be specific to this observation instance, in addition to any quality that is inferred from the observation procedure used
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultQuality"></see></summary>
    let resultQuality = _prefix "resultQuality"
    /// <summary>
    /// related observation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#relatedObservation"></see></summary>
    let relatedObservation = _prefix "relatedObservation"
    /// <summary>
    /// value of named value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// The class OM_Process (Figure 2) is an instance of the «metaclass» GF_FeatureType (ISO 19109:2005), which therefore represents a feature type. OM_Process is abstract, and has no attributes, operations or associations. It serves as the base class for observation processes. The purpose of an observation process is to generate an observation result. An instance of OM_Process is often an instrument or sensor, but may be a human observer, a simulator, or a process or algorithm applied to more primitive results used as inputs.
    ///
    /// NOTE	ISO 19115-2:2008 provides MI_Instrument, LE_Processing and LE_Algorithm, which could all be modelled as specializations of OM_Process. OGC SensorML [10] provides a model which is suitable for many observation procedures.
    /// Process used in an observation, including sensors, algorithms, computation methods
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    /// estimate of the value of the observed property
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// time at which the result became available, after all processing steps were completed
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#resultTime"></see></summary>
    let resultTime = _prefix "resultTime"
    /// <summary>
    /// Observation whose result is a spatial object or geometry
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#GeometryObservation"></see></summary>
    let GeometryObservation = _prefix "GeometryObservation"
    /// <summary>
    /// feature of interest of an observation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#featureOfInterest"></see></summary>
    let featureOfInterest = _prefix "featureOfInterest"
    /// <summary>
    /// Some observations depend on other observations to provide context which is important, sometimes essential, in understanding the result. These dependencies are stronger than mere spatio-temporal coincidences, requiring explicit representation. If present, the association class class ObservationContext (Figure 2) shall link a OM_Observation to another OM_Observation, with the role name relatedObservation for the target. It shall support one attribute.
    ///
    /// EXAMPLES	Some examples include the conditions associated with experimental replicates (e.g., experimental plots and treatments used), biotic factors (e.g., ecological community), interactions among features (e.g., predator-prey), or other temporary relationships occurring at the time of observation that are are not inherent to the observed features themselves (i.e., they change over time), or the related observation may provide input to a process that generates a new result.
    /// This association complements the Intention association which describes relationships between a sampling feature and domain features.
    /// Context linking two or more observations
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ObservationContext"></see></summary>
    let ObservationContext = _prefix "ObservationContext"
    /// <summary>
    /// This property is named 'relatedObservation' in the XML implementation. The rule for association classes needs clarification.
    /// link to related observation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#observationContext"></see></summary>
    let observationContext = _prefix "observationContext"
    /// <summary>
    /// An observation is an act associated with a discrete time instant or period through which a number, term or other symbol is assigned to a phenomenon [2]. It involves application of a specified procedure, such as a sensor, instrument, algorithm or process chain. The procedure may be applied in-situ, remotely, or ex-situ with respect to the sampling location. The result of an observation is an estimate of the value of a property of some feature. Use of a common model allows observation data using different procedures to be combined unambiguously.
    ///
    /// The observation itself is also a feature, since it has properties and identity.
    ///
    /// Observation details are important for data discovery and for data quality estimation.
    ///
    /// The observation could be considered to carry “property-level” instance metadata, which complements the dataset-level and feature-level metadata that have been conventionally considered (e.g. ISO 19115).
    /// Generic observation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    /// generic metadata about an observation
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#metadata"></see></summary>
    let metadata = _prefix "metadata"
    /// <summary>
    /// time at which the estimate of the property that is the result of the observation is associated with the feature of interest
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#phenomenonTime"></see></summary>
    let phenomenonTime = _prefix "phenomenonTime"
    /// <summary>
    /// Observation whose result is a classification from some vocabulary or taxonomy
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CategoryObservation"></see></summary>
    let CategoryObservation = _prefix "CategoryObservation"
    /// <summary>
    /// Observation whose result is a temporal object, such as a time instant or period
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TemporalObservation"></see></summary>
    let TemporalObservation = _prefix "TemporalObservation"
    /// <summary>
    /// Typed value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#NamedValue"></see></summary>
    let NamedValue = _prefix "NamedValue"
    /// <summary>
    /// observation-specific parameter not accommodated by the standard observation properties. Often used to record environmental parameters
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#parameter"></see></summary>
    let parameter = _prefix "parameter"
    /// <summary>
    /// Observation whose result is a vector, record, tuple or other complex value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#ComplexObservation"></see></summary>
    let ComplexObservation = _prefix "ComplexObservation"
    /// <summary>
    /// procedure used in making observation. Typically a sensor or sensor-system, algorithm, computational procedure.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#procedure"></see></summary>
    let procedure = _prefix "procedure"
    /// <summary>
    /// Observation whose result is a time-series
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#TimeSeriesObservation"></see></summary>
    let TimeSeriesObservation = _prefix "TimeSeriesObservation"
    /// <summary>
    /// Observation whose result is an integer
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#CountObservation"></see></summary>
    let CountObservation = _prefix "CountObservation"
    /// <summary>
    /// key indicating the type of a named value
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/observation#name"></see></summary>
    let name = _prefix "name"
