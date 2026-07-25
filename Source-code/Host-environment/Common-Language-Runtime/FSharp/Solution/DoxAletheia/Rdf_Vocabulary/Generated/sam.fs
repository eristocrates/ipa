namespace http.def.seegrid.csiro.au.isotc211.iso19156._2011.sampling.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module sam =
    let _namespace_iri = Namespace_Iri sam |> NamespaceIRI
    /// <summary>
    ///   <para>sam:SamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sampling features are artefacts of an observational strategy, and have no significant function outside of their role in the observation process. The physical characteristics of the features themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// EXAMPLE A “station” is essentially an identifiable locality where a sensor system or procedure may be deployed and an observation made. In the context of the observation model, it connotes the “world in the vicinity of the station”, so the observed properties relate to the physical medium at the station, and not to any physical artefact such as a mooring, buoy, benchmark, monument, well, etc.
    ///
    /// NOTE A transient sampling feature, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.
    ///
    /// A sampling feature is intended to sample some feature-of-interest in an application domain. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.</para>
    ///   <para>Feature on which observations may be made, that is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason. </para>
    /// labels<para>Sampling Feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeature">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeature</seealso>
    let SamplingFeature = Prefixed_Name(sam, "SamplingFeature") |> PrefixedName
    /// <summary>
    ///   <para>sam:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>member sampling feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#member">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#member</seealso>
    let member_ = Prefixed_Name(sam, "member") |> PrefixedName
    /// <summary>
    ///   <para>sam:PreparationStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Discrete stage in specimen-preparation process</para>
    ///   <para>In many applications, specimen preparation procedures are applied to the material prior to its use in an observation. The class PreparationStep (Figure 13) shall link an SF_Specimen to an SF_Process that describes a phase of the specimen preparation.</para>
    /// labels<para>Preparation step</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#PreparationStep">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#PreparationStep</seealso>
    let PreparationStep = Prefixed_Name(sam, "PreparationStep") |> PrefixedName
    /// <summary>
    ///   <para>sam:positionalAccuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>positional accuracy</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#positionalAccuracy">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#positionalAccuracy</seealso>
    let positionalAccuracy = Prefixed_Name(sam, "positionalAccuracy") |> PrefixedName
    /// <summary>
    ///   <para>sam:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>role</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#role">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#role</seealso>
    let role = Prefixed_Name(sam, "role") |> PrefixedName
    /// <summary>
    ///   <para>sam:SamplingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 0-D manifold (Point)</para>
    /// labels<para>Sampling point</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingPoint">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingPoint</seealso>
    let SamplingPoint = Prefixed_Name(sam, "SamplingPoint") |> PrefixedName
    /// <summary>
    ///   <para>sam:parameter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampling feature parameter</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#parameter">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#parameter</seealso>
    let parameter = Prefixed_Name(sam, "parameter") |> PrefixedName
    /// <summary>
    ///   <para>sam:processOperator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>process operator</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processOperator">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processOperator</seealso>
    let processOperator = Prefixed_Name(sam, "processOperator") |> PrefixedName
    /// <summary>
    ///   <para>sam:lineage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>lineage</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#lineage">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#lineage</seealso>
    let lineage = Prefixed_Name(sam, "lineage") |> PrefixedName

    /// <summary>
    ///   <para>sam:samplingFeatureComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampling feature complex</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingFeatureComplex">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingFeatureComplex</seealso>
    let samplingFeatureComplex =
        Prefixed_Name(sam, "samplingFeatureComplex") |> PrefixedName

    /// <summary>
    ///   <para>sam:SamplingFeatureCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The class SF_SamplingFeatureCollection (Figure 9) is an instance of the «metaclass» GF_FeatureType (ISO 19109), which therefore represents a feature type. SF_SamplingFeatureCollection shall support one association.</para>
    ///   <para>Collection of sampling features</para>
    /// labels<para>Sampling feature collection</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureCollection">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureCollection</seealso>
    let SamplingFeatureCollection =
        Prefixed_Name(sam, "SamplingFeatureCollection") |> PrefixedName

    /// <summary>
    ///   <para>sam:SamplingSolid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 3-D manifold (Solid)</para>
    /// labels<para>Sampling solid</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSolid">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSolid</seealso>
    let SamplingSolid = Prefixed_Name(sam, "SamplingSolid") |> PrefixedName
    /// <summary>
    ///   <para>sam:relatedObservation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related observation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedObservation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedObservation</seealso>
    let relatedObservation = Prefixed_Name(sam, "relatedObservation") |> PrefixedName
    /// <summary>
    ///   <para>sam:sampledFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampled feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#sampledFeature">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#sampledFeature</seealso>
    let sampledFeature = Prefixed_Name(sam, "sampledFeature") |> PrefixedName

    /// <summary>
    ///   <para>sam:relatedSamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related sampling feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedSamplingFeature">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedSamplingFeature</seealso>
    let relatedSamplingFeature =
        Prefixed_Name(sam, "relatedSamplingFeature") |> PrefixedName

    /// <summary>
    ///   <para>sam:preparationStep</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>preparation step</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#preparationStep">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#preparationStep</seealso>
    let preparationStep = Prefixed_Name(sam, "preparationStep") |> PrefixedName
    /// <summary>
    ///   <para>sam:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specimen size</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#size">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#size</seealso>
    let size = Prefixed_Name(sam, "size") |> PrefixedName
    /// <summary>
    ///   <para>sam:SamplingSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 2-D manifold (Surface)</para>
    /// labels<para>Sampling surface</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSurface">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSurface</seealso>
    let SamplingSurface = Prefixed_Name(sam, "SamplingSurface") |> PrefixedName
    /// <summary>
    ///   <para>sam:processingDetails</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>processing details</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processingDetails">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processingDetails</seealso>
    let processingDetails = Prefixed_Name(sam, "processingDetails") |> PrefixedName
    /// <summary>
    ///   <para>sam:samplingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampling location</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingLocation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingLocation</seealso>
    let samplingLocation = Prefixed_Name(sam, "samplingLocation") |> PrefixedName

    /// <summary>
    ///   <para>sam:SpatialSamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>When observations are made to estimate properties of a geospatial feature, in particular where the value of a property varies within the scope of the feature, a spatial sampling feature is used. Depending on accessibility and on the nature of the expected property variation, the sampling feature may be extensive in one, two or three spatial dimensions. Processing and visualization methods are often dependent on the topological dimension of the sampling manifold, so this provides a natural classification system for sampling features.
    ///
    /// This classification follows common practice in focussing on conventional spatial dimensions. Properties observed on sampling features may be time-dependent, but the temporal axis does not generally contribute to the classification of sampling feature classes. Sampling feature identity is usually less time-dependent than the property value.</para>
    ///   <para>Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.</para>
    /// labels<para>Spatial sampling feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SpatialSamplingFeature">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SpatialSamplingFeature</seealso>
    let SpatialSamplingFeature =
        Prefixed_Name(sam, "SpatialSamplingFeature") |> PrefixedName

    /// <summary>
    ///   <para>sam:Specimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.</para>
    /// labels<para>Specimen</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Specimen">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Specimen</seealso>
    let Specimen = Prefixed_Name(sam, "Specimen") |> PrefixedName
    /// <summary>
    ///   <para>sam:SamplingCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 1-D manifold (Curve)</para>
    /// labels<para>Sampling curve</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingCurve">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingCurve</seealso>
    let SamplingCurve = Prefixed_Name(sam, "SamplingCurve") |> PrefixedName

    /// <summary>
    ///   <para>sam:SamplingFeatureComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Set of sampling features related to each other in a specific and deliberate way.</para>
    ///   <para>Sampling features are frequently related to each other, as parts of complexes, through sub-sampling, and in other ways. If present, the association class SamplingFeatureComplex (Figure 9) shall link an SF_SamplingFeature to another SF_SamplingFeature.</para>
    /// labels<para>Sampling feature complex</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureComplex">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureComplex</seealso>
    let SamplingFeatureComplex =
        Prefixed_Name(sam, "SamplingFeatureComplex") |> PrefixedName

    /// <summary>
    ///   <para>sam:time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>preparation step time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#time">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#time</seealso>
    let time = Prefixed_Name(sam, "time") |> PrefixedName
    /// <summary>
    ///   <para>sam:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#</seealso>
    let _prefix_iri = Prefixed_Name(sam, "") |> PrefixedName
    /// <summary>
    ///   <para>sam:shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>spatial sampling feature shape</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#shape">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#shape</seealso>
    let shape = Prefixed_Name(sam, "shape") |> PrefixedName
    /// <summary>
    ///   <para>sam:currentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>current location</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#currentLocation">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#currentLocation</seealso>
    let currentLocation = Prefixed_Name(sam, "currentLocation") |> PrefixedName
    /// <summary>
    ///   <para>sam:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location, expressed as either a spatial object or geographic identifier</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Location">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Location</seealso>
    let Location = Prefixed_Name(sam, "Location") |> PrefixedName
    /// <summary>
    ///   <para>sam:hostedProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hosted procedure or instrument</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#hostedProcedure">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#hostedProcedure</seealso>
    let hostedProcedure = Prefixed_Name(sam, "hostedProcedure") |> PrefixedName
    /// <summary>
    ///   <para>sam:samplingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampling method</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingMethod">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingMethod</seealso>
    let samplingMethod = Prefixed_Name(sam, "samplingMethod") |> PrefixedName
    /// <summary>
    ///   <para>sam:specimenType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specimen type</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#specimenType">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#specimenType</seealso>
    let specimenType = Prefixed_Name(sam, "specimenType") |> PrefixedName
    /// <summary>
    ///   <para>sam:NotSamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Complement of SamplingFeature</para>
    /// labels<para>Not a sampling feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#NotSamplingFeature">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#NotSamplingFeature</seealso>
    let NotSamplingFeature = Prefixed_Name(sam, "NotSamplingFeature") |> PrefixedName
    /// <summary>
    ///   <para>sam:samplingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampling time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingTime">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingTime</seealso>
    let samplingTime = Prefixed_Name(sam, "samplingTime") |> PrefixedName
    /// <summary>
    ///   <para>sam:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>In many applications, specimen preparation procedures are applied to the material prior to its use in an observation. The class PreparationStep (Figure 13) shall link an SF_Specimen to an SF_Process that describes a phase of the specimen preparation.</para>
    ///   <para>Process involved in sampling. This may include specimen retrieval or processing, surveying a spatial sampling feature, excavation to provide access to a sampling feature, or any other process whose outcome is a new sampling feature.</para>
    /// labels<para>Sampling process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Process">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Process</seealso>
    let Process = Prefixed_Name(sam, "Process") |> PrefixedName
    /// <summary>
    ///   <para>sam:materialClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>material class</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#materialClass">http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#materialClass</seealso>
    let materialClass = Prefixed_Name(sam, "materialClass") |> PrefixedName
