namespace http.def.seegrid.csiro.au.isotc211.iso19156._2011.sampling.hash

open DoxAletheia.Rdf_Vocabulary

module sam =
    let _namespace_name = "http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#"

    /// <summary>
    /// Complement of SamplingFeature
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#NotSamplingFeature"></see></summary>
    let NotSamplingFeature =
        Namespaced_IRI.parse _namespace_name "NotSamplingFeature" |> NamespacedName

    /// <summary>
    /// Feature on which observations may be made, that is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason.
    /// Sampling features are artefacts of an observational strategy, and have no significant function outside of their role in the observation process. The physical characteristics of the features themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// EXAMPLE A “station” is essentially an identifiable locality where a sensor system or procedure may be deployed and an observation made. In the context of the observation model, it connotes the “world in the vicinity of the station”, so the observed properties relate to the physical medium at the station, and not to any physical artefact such as a mooring, buoy, benchmark, monument, well, etc.
    ///
    /// NOTE A transient sampling feature, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.
    ///
    /// A sampling feature is intended to sample some feature-of-interest in an application domain. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeature"></see></summary>
    let SamplingFeature =
        Namespaced_IRI.parse _namespace_name "SamplingFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingTime"></see>
    /// </summary>
    let samplingTime =
        Namespaced_IRI.parse _namespace_name "samplingTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#member"></see>
    /// </summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName

    /// <summary>
    /// Discrete stage in specimen-preparation process
    /// In many applications, specimen preparation procedures are applied to the material prior to its use in an observation. The class PreparationStep (Figure 13) shall link an SF_Specimen to an SF_Process that describes a phase of the specimen preparation.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#PreparationStep"></see></summary>
    let PreparationStep =
        Namespaced_IRI.parse _namespace_name "PreparationStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#sampledFeature"></see>
    /// </summary>
    let sampledFeature =
        Namespaced_IRI.parse _namespace_name "sampledFeature" |> NamespacedName

    /// <summary>
    /// Process involved in sampling. This may include specimen retrieval or processing, surveying a spatial sampling feature, excavation to provide access to a sampling feature, or any other process whose outcome is a new sampling feature.
    /// In many applications, specimen preparation procedures are applied to the material prior to its use in an observation. The class PreparationStep (Figure 13) shall link an SF_Specimen to an SF_Process that describes a phase of the specimen preparation.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Process"></see></summary>
    let Process = Namespaced_IRI.parse _namespace_name "Process" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#materialClass"></see>
    /// </summary>
    let materialClass =
        Namespaced_IRI.parse _namespace_name "materialClass" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#preparationStep"></see>
    /// </summary>
    let preparationStep =
        Namespaced_IRI.parse _namespace_name "preparationStep" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingLocation"></see>
    /// </summary>
    let samplingLocation =
        Namespaced_IRI.parse _namespace_name "samplingLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#positionalAccuracy"></see>
    /// </summary>
    let positionalAccuracy =
        Namespaced_IRI.parse _namespace_name "positionalAccuracy" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#role"></see>
    /// </summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedSamplingFeature"></see>
    /// </summary>
    let relatedSamplingFeature =
        Namespaced_IRI.parse _namespace_name "relatedSamplingFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#size"></see>
    /// </summary>
    let size = Namespaced_IRI.parse _namespace_name "size" |> NamespacedName
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#shape"></see>
    /// </summary>
    let shape = Namespaced_IRI.parse _namespace_name "shape" |> NamespacedName

    /// <summary>
    /// Spatial sampling feature whose shape is a 0-D manifold (Point)
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingPoint"></see></summary>
    let SamplingPoint =
        Namespaced_IRI.parse _namespace_name "SamplingPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#parameter"></see>
    /// </summary>
    let parameter = Namespaced_IRI.parse _namespace_name "parameter" |> NamespacedName

    /// <summary>
    /// Spatial sampling feature whose shape is a 2-D manifold (Surface)
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSurface"></see></summary>
    let SamplingSurface =
        Namespaced_IRI.parse _namespace_name "SamplingSurface" |> NamespacedName

    /// <summary>
    /// Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.
    /// When observations are made to estimate properties of a geospatial feature, in particular where the value of a property varies within the scope of the feature, a spatial sampling feature is used. Depending on accessibility and on the nature of the expected property variation, the sampling feature may be extensive in one, two or three spatial dimensions. Processing and visualization methods are often dependent on the topological dimension of the sampling manifold, so this provides a natural classification system for sampling features.
    ///
    /// This classification follows common practice in focussing on conventional spatial dimensions. Properties observed on sampling features may be time-dependent, but the temporal axis does not generally contribute to the classification of sampling feature classes. Sampling feature identity is usually less time-dependent than the property value.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SpatialSamplingFeature"></see></summary>
    let SpatialSamplingFeature =
        Namespaced_IRI.parse _namespace_name "SpatialSamplingFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#hostedProcedure"></see>
    /// </summary>
    let hostedProcedure =
        Namespaced_IRI.parse _namespace_name "hostedProcedure" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processingDetails"></see>
    /// </summary>
    let processingDetails =
        Namespaced_IRI.parse _namespace_name "processingDetails" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processOperator"></see>
    /// </summary>
    let processOperator =
        Namespaced_IRI.parse _namespace_name "processOperator" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#lineage"></see>
    /// </summary>
    let lineage = Namespaced_IRI.parse _namespace_name "lineage" |> NamespacedName
    /// <summary>
    /// A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Specimen"></see></summary>
    let Specimen = Namespaced_IRI.parse _namespace_name "Specimen" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#currentLocation"></see>
    /// </summary>
    let currentLocation =
        Namespaced_IRI.parse _namespace_name "currentLocation" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingMethod"></see>
    /// </summary>
    let samplingMethod =
        Namespaced_IRI.parse _namespace_name "samplingMethod" |> NamespacedName

    /// <summary>
    /// Spatial sampling feature whose shape is a 1-D manifold (Curve)
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingCurve"></see></summary>
    let SamplingCurve =
        Namespaced_IRI.parse _namespace_name "SamplingCurve" |> NamespacedName

    /// <summary>
    /// Location, expressed as either a spatial object or geographic identifier
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Location"></see></summary>
    let Location = Namespaced_IRI.parse _namespace_name "Location" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingFeatureComplex"></see>
    /// </summary>
    let samplingFeatureComplex =
        Namespaced_IRI.parse _namespace_name "samplingFeatureComplex" |> NamespacedName

    /// <summary>
    /// The class SF_SamplingFeatureCollection (Figure 9) is an instance of the «metaclass» GF_FeatureType (ISO 19109), which therefore represents a feature type. SF_SamplingFeatureCollection shall support one association.
    /// Collection of sampling features
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureCollection"></see></summary>
    let SamplingFeatureCollection =
        Namespaced_IRI.parse _namespace_name "SamplingFeatureCollection" |> NamespacedName

    /// <summary>
    /// Set of sampling features related to each other in a specific and deliberate way.
    /// Sampling features are frequently related to each other, as parts of complexes, through sub-sampling, and in other ways. If present, the association class SamplingFeatureComplex (Figure 9) shall link an SF_SamplingFeature to another SF_SamplingFeature.
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureComplex"></see></summary>
    let SamplingFeatureComplex =
        Namespaced_IRI.parse _namespace_name "SamplingFeatureComplex" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#specimenType"></see>
    /// </summary>
    let specimenType =
        Namespaced_IRI.parse _namespace_name "specimenType" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#time"></see>
    /// </summary>
    let time = Namespaced_IRI.parse _namespace_name "time" |> NamespacedName

    /// <summary>
    /// Spatial sampling feature whose shape is a 3-D manifold (Solid)
    /// <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSolid"></see></summary>
    let SamplingSolid =
        Namespaced_IRI.parse _namespace_name "SamplingSolid" |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedObservation"></see>
    /// </summary>
    let relatedObservation =
        Namespaced_IRI.parse _namespace_name "relatedObservation" |> NamespacedName
