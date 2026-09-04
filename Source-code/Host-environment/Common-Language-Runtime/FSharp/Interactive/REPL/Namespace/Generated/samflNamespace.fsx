#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module samfl =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://def.seegrid.csiro.au/ontology/om/sam-lite#" "samfl"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>dcterms:description : 1-D geometric object^^xsd:string</para>
    ///   <para>rdfs:label : Spatial curve^^xsd:string</para>
    ///   <para>rdfs:comment : 1-D geometric object
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingCurve.  An existing OWL class that represents the notion of a Curve may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Curve in the context of a sam:SamplingCurve instance.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Curve">samfl:Curve</a>
    /// </summary>
    let Curve = _prefixId.prefix "Curve"
    /// <summary>
    ///   <para>dcterms:description : Simple model for elevation, expressed as a vertical offset from a datum^^xsd:string</para>
    ///   <para>rdfs:label : Elevation^^xsd:string</para>
    ///   <para>rdfs:comment : Simple model for elevation, expressed as a vertical offset from a datum^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Elevation">samfl:Elevation</a>
    /// </summary>
    let Elevation = _prefixId.prefix "Elevation"
    /// <summary>
    ///   <para>dcterms:description : Geometry object has properties relating to geometry, incuding positional and topological attributes, reference system, accuracy and precision. Might be geolocated. ^^xsd:string</para>
    ///   <para>rdfs:label : Geometry object^^xsd:string</para>
    ///   <para>rdfs:comment : Geometry object has properties relating to geometry, incuding positional and topological attributes, reference system, accuracy and precision. Might be geolocated.
    ///
    /// This stub is included in the sam: ontology to support references to geometry in various places.  An existing concrete OWL class that represents the notion of a geometry may be asserted to be a sub-class of this stub, without requiring use of a specific representation of Geometry in the context of sampling.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#GeometryObject">samfl:GeometryObject</a>
    /// </summary>
    let GeometryObject = _prefixId.prefix "GeometryObject"
    /// <summary>
    ///   <para>dcterms:description : Location, expressed as either a geometry object or feature^^xsd:string</para>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <para>rdfs:comment : Location, expressed as either a geometry object or feature
    ///
    /// samfl:GeometryObject is subclass
    ///
    /// w3geo:SpatialThing, geosparql:SpatialObject are subclasses^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Location">samfl:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>dcterms:description : Scaled number. ^^xsd:string</para>
    ///   <para>rdfs:label : Measure or quantity^^xsd:string</para>
    ///   <para>rdfs:comment : Scaled number.
    ///
    /// This is an abstract class, which should be substituted by a suitable concrete representation of a measure or quantity at run-tme.
    ///
    /// oml:SimpleMeasure &lt;http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure&gt;
    /// qudt:QuantityValue &lt;http://qudt.org/schema/qudt#QuantityValue&gt;
    /// DUL:Region &lt;http://www.loa-cnr.it/ontologies/DUL.owl#Region&gt;
    ///
    /// are candidates. ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Measure">samfl:Measure</a>
    /// </summary>
    let Measure = _prefixId.prefix "Measure"
    /// <summary>
    ///   <para>dcterms:description : Process used in an observation, including sensors, algorithms, computation methods^^xsd:string</para>
    ///   <para>rdfs:label : Observation process</para>
    ///   <para>rdfs:comment : Process used in an observation, including sensors, algorithms, computation methods
    ///
    /// The result of application of an observation process is an observation result - i.e. an estimate of a property value.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#ObservationProcess">samfl:ObservationProcess</a>
    /// </summary>
    let ObservationProcess = _prefixId.prefix "ObservationProcess"
    /// <summary>
    ///   <para>dcterms:description : 0-D geometric object^^xsd:string</para>
    ///   <para>rdfs:label : Spatial point^^xsd:string</para>
    ///   <para>rdfs:comment : 0-D geometric object
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingPoint.  An existing OWL class that represents the notion of a Point may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Point in the context of a sam:SamplingPoint instance.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Point">samfl:Point</a>
    /// </summary>
    let Point = _prefixId.prefix "Point"
    /// <summary>
    ///   <para>dcterms:description : Agent, device, protocol, or plan involved in sampling. This may include specimen retrieval or processing, surveying a spatial sampling feature, excavation to provide access to a sampling feature, or any other process whose outcome is a new sampling feature.^^xsd:string</para>
    ///   <para>rdfs:label : Sampling process</para>
    ///   <para>rdfs:comment : Agent, device, protocol, or plan responsible for transforming a sampling features.
    ///
    /// The result of a application of a sampling process is a - new or - transformed sample. ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Process">samfl:Process</a>
    /// </summary>
    let Process = _prefixId.prefix "Process"
    /// <summary>
    ///   <para>dcterms:description : Agent, device, protocol, or plan involved in sampling. This may include specimen retrieval or processing, surveying a spatial sampling feature, excavation to provide access to a sampling feature, or any other process whose outcome is a new sampling feature.^^xsd:string</para>
    ///   <para>rdfs:label : Sample transformation agent</para>
    ///   <para>rdfs:comment : Agent, device, protocol, or plan responsible for transforming a sampling features.
    ///
    /// The result of a operation of a sample trasnformation agent is a - new or - transformed sample. ^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SampleTransformationAgent">samfl:SampleTransformationAgent</a>
    /// </summary>
    let SampleTransformationAgent = _prefixId.prefix "SampleTransformationAgent"
    /// <summary>
    ///   <para>dcterms:description : Collection of features on which observations may be made, which are intended to be representative of one or more features that are not fully accessible for some reason. ^^xsd:string</para>
    ///   <para>rdfs:label : Collection of sampling features</para>
    ///   <para>rdfs:comment : Collection of features on which observations may be made, which are intended to be representative of one or more features that are not fully accessible for some reason.
    ///
    /// The features that the member sampling features are intended to sample may be indicated by one or more sampledFeature properties. If only one is present then it may be inferred that this is the sampled feature of all the member sampling features, unless locally overridden.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCollection">samfl:SamplingCollection</a>
    /// </summary>
    let SamplingCollection = _prefixId.prefix "SamplingCollection"
    /// <summary>
    ///   <para>dcterms:description : Spatial sampling feature whose shape is a 1-D manifold (Curve)^^xsd:string</para>
    ///   <para>rdfs:label : Sampling curve</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 1-D manifold (Curve)
    ///
    /// Transect, traverse, flightline, cruise, trajectory, borehole, etc^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCurve">samfl:SamplingCurve</a>
    /// </summary>
    let SamplingCurve = _prefixId.prefix "SamplingCurve"
    /// <summary>
    ///   <para>dcterms:description : Feature on which observations may be made, which is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason. ^^xsd:string</para>
    ///   <para>rdfs:label : Sampling Feature</para>
    ///   <para>rdfs:comment : Feature on which observations may be made, which is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason.
    ///
    /// Sampling features are artefacts of an observational strategy, and have no significant function outside of their role in the observation process. The physical characteristics of the features themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// EXAMPLE A “station” is essentially an identifiable locality where a sensor system or procedure may be deployed and an observation made. In the context of the observation model, it connotes the “world in the vicinity of the station”, so the observed properties relate to the physical medium at the station, and not to any physical artefact such as a mooring, buoy, benchmark, monument, well, etc.
    ///
    /// NOTE A transient sampling feature, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.
    ///
    /// A sampling feature is intended to sample some feature-of-interest in an application domain, so there is an expectation of at least one sampledFeature property. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.^^xsd:stringrdfs:comment : The value for the property 'sampledFeature' may be inherited from a container resource.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeature">samfl:SamplingFeature</a>
    /// </summary>
    let SamplingFeature = _prefixId.prefix "SamplingFeature"
    /// <summary>
    ///   <para>dcterms:description : Resource that relates a sampling feature to another sampling feature with a role indicating the nature of the relationship. ^^xsd:string</para>
    ///   <para>rdfs:label : Sampling feature complex</para>
    ///   <para>rdfs:comment : Resource that relates a sampling feature to another sampling feature with a role indicating the nature of the relationship.
    ///
    /// Sampling features are frequently related to each other, as parts of complexes, through sub-sampling, and in other ways. If present, the association class SamplingFeatureComplex (Figure 9) shall link an SF_SamplingFeature to another SF_SamplingFeature.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeatureComplex">samfl:SamplingFeatureComplex</a>
    /// </summary>
    let SamplingFeatureComplex = _prefixId.prefix "SamplingFeatureComplex"
    /// <summary>
    ///   <para>dcterms:description : Spatial sampling feature whose shape is a 0-D manifold (Point)^^xsd:string</para>
    ///   <para>rdfs:label : Sampling point</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 0-D manifold (Point)
    ///
    /// Often referred to as a 'station', 'pixel', 'probe-spot' etc.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingPoint">samfl:SamplingPoint</a>
    /// </summary>
    let SamplingPoint = _prefixId.prefix "SamplingPoint"
    /// <summary>
    ///   <para>dcterms:description : Spatial sampling feature whose shape is a 3-D manifold (Solid)^^xsd:string</para>
    ///   <para>rdfs:label : Sampling solid</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 3-D manifold (Solid)^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSolid">samfl:SamplingSolid</a>
    /// </summary>
    let SamplingSolid = _prefixId.prefix "SamplingSolid"
    /// <summary>
    ///   <para>dcterms:description : Spatial sampling feature whose shape is a 2-D manifold (Surface)^^xsd:string</para>
    ///   <para>rdfs:label : Sampling surface</para>
    ///   <para>rdfs:comment : Spatial sampling feature whose shape is a 2-D manifold (Surface)
    ///
    /// Scene, swath, cross-section, level, quadrat, area-of-interest, fence, etc.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSurface">samfl:SamplingSurface</a>
    /// </summary>
    let SamplingSurface = _prefixId.prefix "SamplingSurface"
    /// <summary>
    ///   <para>dcterms:description : 3-D geometric object, whose exterior is a shell^^xsd:string</para>
    ///   <para>rdfs:label : Spatial solid^^xsd:string</para>
    ///   <para>rdfs:comment : 3-D geometric object, whose exterior is a shell
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingSolid.  An existing OWL class that represents the notion of a Solid may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Solid in the context of a sam:SamplingSolid instance.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Solid">samfl:Solid</a>
    /// </summary>
    let Solid = _prefixId.prefix "Solid"
    /// <summary>
    ///   <para>dcterms:description : Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.^^xsd:string</para>
    ///   <para>rdfs:label : Spatial sampling feature</para>
    ///   <para>rdfs:comment : Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.
    ///
    /// When observations are made to estimate properties of a geospatial feature, in particular where the value of a property varies within the scope of the feature, a spatial sampling feature is used. Depending on accessibility and on the nature of the expected property variation, the sampling feature may be extensive in one, two or three spatial dimensions. Processing and visualization methods are often dependent on the topological dimension of the sampling manifold, so this provides a natural classification system for sampling features.
    ///
    /// This classification follows common practice in focussing on conventional spatial dimensions. Properties observed on sampling features may be time-dependent, but the temporal axis does not generally contribute to the classification of sampling feature classes. Sampling feature identity is usually less time-dependent than the property value.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SpatialSamplingFeature">samfl:SpatialSamplingFeature</a>
    /// </summary>
    let SpatialSamplingFeature = _prefixId.prefix "SpatialSamplingFeature"
    /// <summary>
    ///   <para>dcterms:description : A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.^^xsd:string</para>
    ///   <para>rdfs:label : Specimen</para>
    ///   <para>rdfs:comment : A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Specimen">samfl:Specimen</a>
    /// </summary>
    let Specimen = _prefixId.prefix "Specimen"
    /// <summary>
    ///   <para>dcterms:description : 2-D geometric object, whose exterior is a ring or polygon^^xsd:string</para>
    ///   <para>rdfs:label : Spatial surface^^xsd:string</para>
    ///   <para>rdfs:comment : This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingSurface.  An existing OWL class that represents the notion of a Surface may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Surface in the context of a sam:SamplingSurface instance.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Surface">samfl:Surface</a>
    /// </summary>
    let Surface = _prefixId.prefix "Surface"
    /// <summary>
    ///   <para>rdfs:label : sampling feature complex^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#complex">samfl:complex</a>
    /// </summary>
    let complex = _prefixId.prefix "complex"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute currentLocation:Location shall describe the location of a physical specimen. This may be a storage location, such as a shelf in a warehouse or a drawer in a museum.
    ///
    /// NOTE If a specimen no longer exists, for example, it was destroyed in connection with an observation act, then the currentLocation should be omitted or carry a suitable null indicator.^^xsd:string</para>
    ///   <para>rdfs:label : current location^^xsd:string</para>
    ///   <para>rdfs:comment : If present, the attribute currentLocation:Location shall describe the location of a physical specimen. This may be a storage location, such as a shelf in a warehouse or a drawer in a museum.
    ///
    /// NOTE If a specimen no longer exists, for example, it was destroyed in connection with an observation act, then the currentLocation should be omitted or carry a suitable null indicator.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#currentLocation">samfl:currentLocation</a>
    /// </summary>
    let currentLocation = _prefixId.prefix "currentLocation"
    /// <summary>
    ///   <para>rdfs:label : vertical offset from a datum^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#elevation">samfl:elevation</a>
    /// </summary>
    let elevation = _prefixId.prefix "elevation"
    /// <summary>
    ///   <para>skos:definition : A common role for a spatial sampling feature is to host instruments or procedures deployed repetitively or permanently. If present, the association Platform shall link the SF_SpatialSamplingFeature to an OM_Process deployed at it. The OM_Process has the role hostedProcedure with respect to the sampling feature.^^xsd:string</para>
    ///   <para>rdfs:label : hosted procedure or instrument^^xsd:string</para>
    ///   <para>rdfs:comment : A common role for a spatial sampling feature is to host instruments or procedures deployed repetitively or permanently. If present, the association Platform shall link the SF_SpatialSamplingFeature to an OM_Process deployed at it. The OM_Process has the role hostedProcedure with respect to the sampling feature.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#hostedProcedure">samfl:hostedProcedure</a>
    /// </summary>
    let hostedProcedure = _prefixId.prefix "hostedProcedure"
    /// <summary>
    ///   <para>rdfs:label : class of material^^xsd:string</para>
    ///   <para>rdfs:comment : Value should be taken from a vocabulary of material classes.
    ///
    /// e.g. aqueous liquid, non-aqueous liquid, soil, rock, tissue, vegetation (broad case) or finer classifications if available^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#materialClass">samfl:materialClass</a>
    /// </summary>
    let materialClass = _prefixId.prefix "materialClass"
    /// <summary>
    ///   <para>rdfs:label : has member^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#member">samfl:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : related sampling feature^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#relatedSamplingFeature">samfl:relatedSamplingFeature</a>
    /// </summary>
    let relatedSamplingFeature = _prefixId.prefix "relatedSamplingFeature"
    /// <summary>
    ///   <para>rdfs:label : role^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#role">samfl:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    /// <summary>
    ///   <para>skos:definition : A sampling feature is established in order to make observations concerning some domain feature. The association Intention shall link the SF_SamplingFeature to the feature which the sampling feature was designed to sample. The target of this association has the role sampledFeature with respect to the sampling feature, and shall not be a sampling feature or observation. It is usually a real-world feature from an application domain (Figures 5 and 10).
    ///
    /// EXAMPLE A profile typically samples a water- or atmospheric-column; a well samples the water in an aquifer; a tissue specimen samples a part of an organism.^^xsd:string</para>
    ///   <para>rdfs:label : sampled feature^^xsd:string</para>
    ///   <para>rdfs:comment : A sampling feature is established in order to make observations concerning some domain feature. The association Intention shall link the SF_SamplingFeature to the feature which the sampling feature was designed to sample. The target of this association has the role sampledFeature with respect to the sampling feature, and shall not be a sampling feature or observation. It is usually a real-world feature from an application domain (Figures 5 and 10).
    ///
    /// EXAMPLE A profile typically samples a water- or atmospheric-column; a well samples the water in an aquifer; a tissue specimen samples a part of an organism.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#sampledFeature">samfl:sampledFeature</a>
    /// </summary>
    let sampledFeature = _prefixId.prefix "sampledFeature"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute samplingElevation shall describe the elevation from where the specimen was obtained, relative to the sampling location.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous elevation then this attribute is not required. However, if the specific elevationat the location, then this attribute supports its description.^^xsd:string</para>
    ///   <para>rdfs:label : sampling elevation^^xsd:string</para>
    ///   <para>rdfs:comment : If present, the attribute samplingElevation shall describe the elevation from where the specimen was obtained, relative to the sampling location.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous elevation then this attribute is not required. However, if the specific elevationat the location, then this attribute supports its description.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingElevation">samfl:samplingElevation</a>
    /// </summary>
    let samplingElevation = _prefixId.prefix "samplingElevation"
    /// <summary>
    ///   <para>skos:definition : If present, the attribute samplingLocation:GM_Object shall describe the location from where the specimen was obtained.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous location then this attribute is not required. However, if the specific sampling location within the sampledFeature is important, then this attribute supports its description.^^xsd:string</para>
    ///   <para>rdfs:label : sampling location^^xsd:string</para>
    ///   <para>rdfs:comment : If present, the attribute samplingLocation:GM_Object shall describe the location from where the specimen was obtained.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous location then this attribute is not required. However, if the specific sampling location within the sampledFeature is important, then this attribute supports its description.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingLocation">samfl:samplingLocation</a>
    /// </summary>
    let samplingLocation = _prefixId.prefix "samplingLocation"
    /// <summary>
    ///   <para>rdfs:label : sampling method^^xsd:string</para>
    ///   <para>rdfs:comment : Process used to obtain the Specimen from its sampledFeature^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingMethod">samfl:samplingMethod</a>
    /// </summary>
    let samplingMethod = _prefixId.prefix "samplingMethod"
    /// <summary>
    ///   <para>skos:definition : samplingTime records when the specimen was retrieved from the sampled feature.^^xsd:string</para>
    ///   <para>rdfs:label : sampling time^^xsd:string</para>
    ///   <para>rdfs:comment : samplingTime records when the specimen was retrieved from the sampled feature.^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingTime">samfl:samplingTime</a>
    /// </summary>
    let samplingTime = _prefixId.prefix "samplingTime"
    /// <summary>
    ///   <para>skos:definition : The association Geometry shall link an SF_SpatialSamplingFeature to a GM_Object that describes its shape.^^xsd:string</para>
    ///   <para>rdfs:label : spatial sampling feature shape^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#shape">samfl:shape</a>
    /// </summary>
    let shape = _prefixId.prefix "shape"
    /// <summary>
    ///   <para>skos:definition : the attribute size:Measure shall describe a physical extent of the specimen. This may be length, mass, volume, etc., as appropriate for the specimen instance and its material class.^^xsd:string</para>
    ///   <para>rdfs:label : specimen size^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#size">samfl:size</a>
    /// </summary>
    let size = _prefixId.prefix "size"
    /// <summary>
    ///   <para>rdfs:label : vertical (elevation) datum^^xsd:string</para>
    ///   <a href="http://def.seegrid.csiro.au/ontology/om/sam-lite#verticalDatum">samfl:verticalDatum</a>
    /// </summary>
    let verticalDatum = _prefixId.prefix "verticalDatum"
