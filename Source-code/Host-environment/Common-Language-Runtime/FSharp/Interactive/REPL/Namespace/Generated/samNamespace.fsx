#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module sam =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#" "sam"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>skos:notation : Location^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : Location, expressed as either a spatial object or geographic identifier^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Location">sam:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Not a sampling feature^^xsd:string</para>
    ///   <para>rdfs:comment : Complement of SamplingFeature^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#NotSamplingFeature">sam:NotSamplingFeature</a>
    /// </summary>
    let NotSamplingFeature = _prefixId.prefix "NotSamplingFeature"
    /// <summary>
    ///   <para>rdfs:comment : Discrete stage in specimen-preparation process^^xsd:stringrdfs:comment : In many applications, specimen preparation procedures are applied to the material prior to its use in an observation. The class PreparationStep (Figure 13) shall link an SF_Specimen to an SF_Process that describes a phase of the specimen preparation.^^xsd:string</para>
    ///   <para>skos:notation : PreparationStep^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Preparation step</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#PreparationStep">sam:PreparationStep</a>
    /// </summary>
    let PreparationStep = _prefixId.prefix "PreparationStep"
    /// <summary>
    ///   <para>skos:notation : SF_Process^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling process</para>
    ///   <para>rdfs:comment : Process involved in sampling. This may include specimen retrieval or processing, surveying a spatial sampling feature, excavation to provide access to a sampling feature, or any other process whose outcome is a new sampling feature.^^xsd:stringrdfs:comment : In many applications, specimen preparation procedures are applied to the material prior to its use in an observation. The class PreparationStep (Figure 13) shall link an SF_Specimen to an SF_Process that describes a phase of the specimen preparation.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Process">sam:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>skos:notation : SF_SamplingCurve^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling curve</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 1-D manifold (Curve)^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingCurve">sam:SamplingCurve</a>
    /// </summary>
    let SamplingCurve = _prefixId.prefix "SamplingCurve"
    /// <summary>
    ///   <para>rdfs:comment : Feature on which observations may be made, that is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason. ^^xsd:stringrdfs:comment : Sampling features are artefacts of an observational strategy, and have no significant function outside of their role in the observation process. The physical characteristics of the features themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// EXAMPLE A “station” is essentially an identifiable locality where a sensor system or procedure may be deployed and an observation made. In the context of the observation model, it connotes the “world in the vicinity of the station”, so the observed properties relate to the physical medium at the station, and not to any physical artefact such as a mooring, buoy, benchmark, monument, well, etc.
    ///
    /// NOTE A transient sampling feature, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.
    ///
    /// A sampling feature is intended to sample some feature-of-interest in an application domain. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.^^xsd:string</para>
    ///   <para>skos:notation : SF_SamplingFeature^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling Feature</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeature">sam:SamplingFeature</a>
    /// </summary>
    let SamplingFeature = _prefixId.prefix "SamplingFeature"
    /// <summary>
    ///   <para>skos:notation : SF_SamplingFeatureCollection^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling feature collection</para>
    ///   <para>rdfs:comment : The class SF_SamplingFeatureCollection (Figure 9) is an instance of the «metaclass» GF_FeatureType (ISO 19109), which therefore represents a feature type. SF_SamplingFeatureCollection shall support one association.^^xsd:stringrdfs:comment : Collection of sampling features^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureCollection">sam:SamplingFeatureCollection</a>
    /// </summary>
    let SamplingFeatureCollection = _prefixId.prefix "SamplingFeatureCollection"
    /// <summary>
    ///   <para>skos:notation : SamplingFeatureComplex^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling feature complex</para>
    ///   <para>rdfs:comment : Set of sampling features related to each other in a specific and deliberate way.^^xsd:stringrdfs:comment : Sampling features are frequently related to each other, as parts of complexes, through sub-sampling, and in other ways. If present, the association class SamplingFeatureComplex (Figure 9) shall link an SF_SamplingFeature to another SF_SamplingFeature.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingFeatureComplex">sam:SamplingFeatureComplex</a>
    /// </summary>
    let SamplingFeatureComplex = _prefixId.prefix "SamplingFeatureComplex"
    /// <summary>
    ///   <para>skos:notation : SF_SamplingPoint^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling point</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 0-D manifold (Point)^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingPoint">sam:SamplingPoint</a>
    /// </summary>
    let SamplingPoint = _prefixId.prefix "SamplingPoint"
    /// <summary>
    ///   <para>skos:notation : SF_SamplingSolid^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling solid</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 3-D manifold (Solid)^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSolid">sam:SamplingSolid</a>
    /// </summary>
    let SamplingSolid = _prefixId.prefix "SamplingSolid"
    /// <summary>
    ///   <para>skos:notation : SF_SamplingSurface^^h2o:ISOClassName</para>
    ///   <para>rdfs:label : Sampling surface</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 2-D manifold (Surface)^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SamplingSurface">sam:SamplingSurface</a>
    /// </summary>
    let SamplingSurface = _prefixId.prefix "SamplingSurface"
    /// <summary>
    ///   <para>rdfs:comment : Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.^^xsd:stringrdfs:comment : When observations are made to estimate properties of a geospatial feature, in particular where the value of a property varies within the scope of the feature, a spatial sampling feature is used. Depending on accessibility and on the nature of the expected property variation, the sampling feature may be extensive in one, two or three spatial dimensions. Processing and visualization methods are often dependent on the topological dimension of the sampling manifold, so this provides a natural classification system for sampling features.
    ///
    /// This classification follows common practice in focussing on conventional spatial dimensions. Properties observed on sampling features may be time-dependent, but the temporal axis does not generally contribute to the classification of sampling feature classes. Sampling feature identity is usually less time-dependent than the property value.^^xsd:string</para>
    ///   <para>rdfs:label : Spatial sampling feature</para>
    ///   <para>skos:notation : SF_SpatialSamplingFeature^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#SpatialSamplingFeature">sam:SpatialSamplingFeature</a>
    /// </summary>
    let SpatialSamplingFeature = _prefixId.prefix "SpatialSamplingFeature"
    /// <summary>
    ///   <para>rdfs:label : Specimen</para>
    ///   <para>rdfs:comment : A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.^^xsd:string</para>
    ///   <para>skos:notation : SF_Specimen^^h2o:ISOClassName</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#Specimen">sam:Specimen</a>
    /// </summary>
    let Specimen = _prefixId.prefix "Specimen"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute currentLocation:Location shall describe the location of a physical specimen. This may be a storage location, such as a shelf in a warehouse or a drawer in a museum.
    ///
    /// NOTE If a specimen no longer exists, for example, it was destroyed in connection with an observation act, then the currentLocation should be omitted or carry a suitable null indicator.^^xsd:string</para>
    ///   <para>rdfs:label : current location^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#currentLocation">sam:currentLocation</a>
    /// </summary>
    let currentLocation = _prefixId.prefix "currentLocation"
    /// <summary>
    ///   <para>skos:definition : A common role for a spatial sampling feature is to host instruments or procedures deployed repetitively or permanently. If present, the association Platform shall link the SF_SpatialSamplingFeature to an OM_Process deployed at it. The OM_Process has the role hostedProcedure with respect to the sampling feature.^^xsd:string</para>
    ///   <para>rdfs:label : hosted procedure or instrument^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#hostedProcedure">sam:hostedProcedure</a>
    /// </summary>
    let hostedProcedure = _prefixId.prefix "hostedProcedure"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute lineage:LI_Lineage shall describe the history and provenance of the SF_SamplingFeature. This might include information relating to the handling of the specimen, or details of the survey procedure of a spatial sampling feature.^^xsd:string</para>
    ///   <para>rdfs:label : lineage^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#lineage">sam:lineage</a>
    /// </summary>
    let lineage = _prefixId.prefix "lineage"
    /// <summary>
    ///   <para>skos:definition : The attribute materialClass:GenericName shall provide a basic classification of the material type of the specimen.
    ///
    /// EXAMPLE Soil, water, rock, aqueous, liquid, tissue, vegetation, food.^^xsd:string</para>
    ///   <para>rdfs:label : material class^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#materialClass">sam:materialClass</a>
    /// </summary>
    let materialClass = _prefixId.prefix "materialClass"
    /// <summary>
    ///   <para>skos:definition : The association Collection shall link an SF_SamplingFeatureCollection to member SF_SamplingFeatures.^^xsd:string</para>
    ///   <para>rdfs:label : member sampling feature^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#member">sam:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>skos:definition : the attribute parameter:NamedValue shall describe an arbitrary parameter associated with the SF_SamplingFeature. This might be a parameter that qualifies the interaction with the sampled feature, or an environmental parameter associated with the sampling process.^^xsd:string</para>
    ///   <para>rdfs:label : sampling feature parameter^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#parameter">sam:parameter</a>
    /// </summary>
    let parameter = _prefixId.prefix "parameter"
    /// <summary>
    ///   <para>skos:definition : Positioning metadata is commonly associated with sampling features defined in the context of field surveys. If present, positionalAccuracy:DQ_PositionalAccuracy shall describe the accuracy of the positioning of the sampling feature. Up to two instances of the attribute support the independent description of horizontal and vertical accuracy.^^xsd:string</para>
    ///   <para>rdfs:label : positional accuracy^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#positionalAccuracy">sam:positionalAccuracy</a>
    /// </summary>
    let positionalAccuracy = _prefixId.prefix "positionalAccuracy"
    /// <summary>
    ///   <para>rdfs:label : preparation step^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#preparationStep">sam:preparationStep</a>
    /// </summary>
    let preparationStep = _prefixId.prefix "preparationStep"
    /// <summary>
    ///   <para>skos:definition : the attribute processOperator:CI_ResponsibleParty shall describe the operator of the process involved in the preparation step.^^xsd:string</para>
    ///   <para>rdfs:label : process operator^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processOperator">sam:processOperator</a>
    /// </summary>
    let processOperator = _prefixId.prefix "processOperator"
    /// <summary>
    ///   <para>rdfs:label : processing details^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#processingDetails">sam:processingDetails</a>
    /// </summary>
    let processingDetails = _prefixId.prefix "processingDetails"
    /// <summary>
    ///   <para>skos:definition : Sampling features are distinctive compared with other features from application domains by having navigable associations to observations. If present, the association Design shall link the SF_SamplingFeature to an OM_Observation that was made utilizing the sampling feature, and the description of the sampling feature provides an intrinsic element of the observation protocol, along with the observation procedure (7.2.2) and the decomposition of the domain geometry in the case of a coverage-valued result (8.3.2). The OM_Observation has the role relatedObservation with respect to the sampling feature. Multiple observations may be made on a single sampling feature.^^xsd:string</para>
    ///   <para>rdfs:label : related observation^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedObservation">sam:relatedObservation</a>
    /// </summary>
    let relatedObservation = _prefixId.prefix "relatedObservation"
    /// <summary>
    ///   <para>rdfs:label : related sampling feature^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#relatedSamplingFeature">sam:relatedSamplingFeature</a>
    /// </summary>
    let relatedSamplingFeature = _prefixId.prefix "relatedSamplingFeature"
    /// <summary>
    ///   <para>rdfs:label : role^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#role">sam:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>skos:definition : A sampling feature is established in order to make observations concerning some domain feature. The association Intention shall link the SF_SamplingFeature to the feature which the sampling feature was designed to sample. The target of this association has the role sampledFeature with respect to the sampling feature, and shall not be a sampling feature or observation. It is usually a real-world feature from an application domain (Figures 5 and 10).
    ///
    /// EXAMPLE A profile typically samples a water- or atmospheric-column; a well samples the water in an aquifer; a tissue specimen samples a part of an organism.^^xsd:string</para>
    ///   <para>rdfs:label : sampled feature^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#sampledFeature">sam:sampledFeature</a>
    /// </summary>
    let sampledFeature = _prefixId.prefix "sampledFeature"
    /// <summary>
    ///   <para>rdfs:label : sampling feature complex^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingFeatureComplex">sam:samplingFeatureComplex</a>
    /// </summary>
    let samplingFeatureComplex = _prefixId.prefix "samplingFeatureComplex"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute samplingLocation:GM_Object shall describe the location from where the specimen was obtained.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous location then this attribute is not required. However, if the specific sampling location within the sampledFeature is important, then this attribute supports its description.^^xsd:string</para>
    ///   <para>rdfs:label : sampling location^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingLocation">sam:samplingLocation</a>
    /// </summary>
    let samplingLocation = _prefixId.prefix "samplingLocation"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute samplingMethod:SF_Process shall describe the method used to obtain the specimen from its sampledFeature.^^xsd:string</para>
    ///   <para>rdfs:label : sampling method^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingMethod">sam:samplingMethod</a>
    /// </summary>
    let samplingMethod = _prefixId.prefix "samplingMethod"
    /// <summary>
    ///   <para>skos:definition : The attribute samplingTime:TM_Object shall record when the specimen was retrieved from the sampled feature.^^xsd:string</para>
    ///   <para>rdfs:label : sampling time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#samplingTime">sam:samplingTime</a>
    /// </summary>
    let samplingTime = _prefixId.prefix "samplingTime"
    /// <summary>
    ///   <para>skos:definition : The association Geometry shall link an SF_SpatialSamplingFeature to a GM_Object that describes its shape.^^xsd:string</para>
    ///   <para>rdfs:label : spatial sampling feature shape^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#shape">sam:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>skos:definition : the attribute size:Measure shall describe a physical extent of the specimen. This may be length, mass, volume, etc., as appropriate for the specimen instance and its material class.^^xsd:string</para>
    ///   <para>rdfs:label : specimen size^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#size">sam:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>skos:definition : the attribute specimenType:GenericName shall describe the basic form of the specimen.
    ///
    /// EXAMPLE Polished section; core; pulp; solution.^^xsd:string</para>
    ///   <para>rdfs:label : specimen type^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#specimenType">sam:specimenType</a>
    /// </summary>
    let specimenType = _prefixId.prefix "specimenType"
    /// <summary>
    ///   <para>skos:definition : The attribute time:TM_Object shall describe the time that the SF_Process was applied to the SF_Specimen. It supports ordering of preparation steps.^^xsd:string</para>
    ///   <para>rdfs:label : preparation step time^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/isotc211/iso19156/2011/sampling#time">sam:time</a>
    /// </summary>
    let time = _prefixId.prefix "time"
