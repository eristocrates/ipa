namespace http.def.seegrid.csiro.au.ontology.om.sam_lite.hash

open DoxAletheia

module samfl =
    let _namespace_name = "http://def.seegrid.csiro.au/ontology/om/sam-lite#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#elevation"></see>
    /// </summary>
    let elevation = _prefix "elevation"
    /// <summary>
    /// Agent, device, protocol, or plan responsible for transforming a sampling features.
    ///
    /// The result of a application of a sampling process is a - new or - transformed sample.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Process"></see></summary>
    let Process = _prefix "Process"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#complex"></see>
    /// </summary>
    let complex = _prefix "complex"
    /// <summary>
    /// If present, the attribute samplingElevation shall describe the elevation from where the specimen was obtained, relative to the sampling location.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous elevation then this attribute is not required. However, if the specific elevationat the location, then this attribute supports its description.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingElevation"></see></summary>
    let samplingElevation = _prefix "samplingElevation"
    /// <summary>
    /// Value should be taken from a vocabulary of material classes.
    ///
    /// e.g. aqueous liquid, non-aqueous liquid, soil, rock, tissue, vegetation (broad case) or finer classifications if available
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#materialClass"></see></summary>
    let materialClass = _prefix "materialClass"
    /// <summary>
    /// Scaled number.
    ///
    /// This is an abstract class, which should be substituted by a suitable concrete representation of a measure or quantity at run-tme.
    ///
    /// oml:SimpleMeasure &lt;http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure&gt;
    /// qudt:QuantityValue &lt;http://qudt.org/schema/qudt#QuantityValue&gt;
    /// DUL:Region &lt;http://www.loa-cnr.it/ontologies/DUL.owl#Region&gt;
    ///
    /// are candidates.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Measure"></see></summary>
    let Measure = _prefix "Measure"
    /// <summary>
    /// Spatial sampling feature whose shape is a 1-D manifold (Curve)
    ///
    /// Transect, traverse, flightline, cruise, trajectory, borehole, etc
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCurve"></see></summary>
    let SamplingCurve = _prefix "SamplingCurve"
    /// <summary>
    /// Resource that relates a sampling feature to another sampling feature with a role indicating the nature of the relationship.
    ///
    /// Sampling features are frequently related to each other, as parts of complexes, through sub-sampling, and in other ways. If present, the association class SamplingFeatureComplex (Figure 9) shall link an SF_SamplingFeature to another SF_SamplingFeature.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeatureComplex"></see></summary>
    let SamplingFeatureComplex = _prefix "SamplingFeatureComplex"
    /// <summary>
    /// Geometry object has properties relating to geometry, incuding positional and topological attributes, reference system, accuracy and precision. Might be geolocated.
    ///
    /// This stub is included in the sam: ontology to support references to geometry in various places.  An existing concrete OWL class that represents the notion of a geometry may be asserted to be a sub-class of this stub, without requiring use of a specific representation of Geometry in the context of sampling.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#GeometryObject"></see></summary>
    let GeometryObject = _prefix "GeometryObject"
    /// <summary>
    /// Simple model for elevation, expressed as a vertical offset from a datum
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Elevation"></see></summary>
    let Elevation = _prefix "Elevation"
    /// <summary>
    /// Spatial sampling feature whose shape is a 0-D manifold (Point)
    ///
    /// Often referred to as a 'station', 'pixel', 'probe-spot' etc.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingPoint"></see></summary>
    let SamplingPoint = _prefix "SamplingPoint"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#size"></see>
    /// </summary>
    let size = _prefix "size"
    /// <summary>
    /// A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Specimen"></see></summary>
    let Specimen = _prefix "Specimen"
    /// <summary>
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingSurface.  An existing OWL class that represents the notion of a Surface may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Surface in the context of a sam:SamplingSurface instance.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Surface"></see></summary>
    let Surface = _prefix "Surface"
    /// <summary>
    /// 1-D geometric object
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingCurve.  An existing OWL class that represents the notion of a Curve may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Curve in the context of a sam:SamplingCurve instance.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Curve"></see></summary>
    let Curve = _prefix "Curve"
    /// <summary>
    /// Process used to obtain the Specimen from its sampledFeature
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingMethod"></see></summary>
    let samplingMethod = _prefix "samplingMethod"
    /// <summary>
    /// A sampling feature is established in order to make observations concerning some domain feature. The association Intention shall link the SF_SamplingFeature to the feature which the sampling feature was designed to sample. The target of this association has the role sampledFeature with respect to the sampling feature, and shall not be a sampling feature or observation. It is usually a real-world feature from an application domain (Figures 5 and 10).
    ///
    /// EXAMPLE A profile typically samples a water- or atmospheric-column; a well samples the water in an aquifer; a tissue specimen samples a part of an organism.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#sampledFeature"></see></summary>
    let sampledFeature = _prefix "sampledFeature"
    /// <summary>
    /// Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.
    ///
    /// When observations are made to estimate properties of a geospatial feature, in particular where the value of a property varies within the scope of the feature, a spatial sampling feature is used. Depending on accessibility and on the nature of the expected property variation, the sampling feature may be extensive in one, two or three spatial dimensions. Processing and visualization methods are often dependent on the topological dimension of the sampling manifold, so this provides a natural classification system for sampling features.
    ///
    /// This classification follows common practice in focussing on conventional spatial dimensions. Properties observed on sampling features may be time-dependent, but the temporal axis does not generally contribute to the classification of sampling feature classes. Sampling feature identity is usually less time-dependent than the property value.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SpatialSamplingFeature"></see></summary>
    let SpatialSamplingFeature = _prefix "SpatialSamplingFeature"
    /// <summary>
    /// 3-D geometric object, whose exterior is a shell
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingSolid.  An existing OWL class that represents the notion of a Solid may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Solid in the context of a sam:SamplingSolid instance.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Solid"></see></summary>
    let Solid = _prefix "Solid"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#shape"></see>
    /// </summary>
    let shape = _prefix "shape"
    /// <summary>
    /// Location, expressed as either a geometry object or feature
    ///
    /// samfl:GeometryObject is subclass
    ///
    /// w3geo:SpatialThing, geosparql:SpatialObject are subclasses
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Location"></see></summary>
    let Location = _prefix "Location"
    /// <summary>
    /// Collection of features on which observations may be made, which are intended to be representative of one or more features that are not fully accessible for some reason.
    ///
    /// The features that the member sampling features are intended to sample may be indicated by one or more sampledFeature properties. If only one is present then it may be inferred that this is the sampled feature of all the member sampling features, unless locally overridden.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCollection"></see></summary>
    let SamplingCollection = _prefix "SamplingCollection"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#role"></see>
    /// </summary>
    let role = _prefix "role"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#relatedSamplingFeature"></see>
    /// </summary>
    let relatedSamplingFeature = _prefix "relatedSamplingFeature"
    /// <summary>
    /// Process used in an observation, including sensors, algorithms, computation methods
    ///
    /// The result of application of an observation process is an observation result - i.e. an estimate of a property value.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#ObservationProcess"></see></summary>
    let ObservationProcess = _prefix "ObservationProcess"
    /// <summary>
    /// A common role for a spatial sampling feature is to host instruments or procedures deployed repetitively or permanently. If present, the association Platform shall link the SF_SpatialSamplingFeature to an OM_Process deployed at it. The OM_Process has the role hostedProcedure with respect to the sampling feature.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#hostedProcedure"></see></summary>
    let hostedProcedure = _prefix "hostedProcedure"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#verticalDatum"></see>
    /// </summary>
    let verticalDatum = _prefix "verticalDatum"
    /// <summary>
    /// Spatial sampling feature whose shape is a 3-D manifold (Solid)
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSolid"></see></summary>
    let SamplingSolid = _prefix "SamplingSolid"
    /// <summary>
    /// Spatial sampling feature whose shape is a 2-D manifold (Surface)
    ///
    /// Scene, swath, cross-section, level, quadrat, area-of-interest, fence, etc.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSurface"></see></summary>
    let SamplingSurface = _prefix "SamplingSurface"
    /// <summary>
    /// If present, the attribute currentLocation:Location shall describe the location of a physical specimen. This may be a storage location, such as a shelf in a warehouse or a drawer in a museum.
    ///
    /// NOTE If a specimen no longer exists, for example, it was destroyed in connection with an observation act, then the currentLocation should be omitted or carry a suitable null indicator.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#currentLocation"></see></summary>
    let currentLocation = _prefix "currentLocation"
    /// <summary>
    /// 0-D geometric object
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingPoint.  An existing OWL class that represents the notion of a Point may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Point in the context of a sam:SamplingPoint instance.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Point"></see></summary>
    let Point = _prefix "Point"
    /// <summary>
    /// If present, the attribute samplingLocation:GM_Object shall describe the location from where the specimen was obtained.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous location then this attribute is not required. However, if the specific sampling location within the sampledFeature is important, then this attribute supports its description.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingLocation"></see></summary>
    let samplingLocation = _prefix "samplingLocation"
    /// <summary>
    /// samplingTime records when the specimen was retrieved from the sampled feature.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingTime"></see></summary>
    let samplingTime = _prefix "samplingTime"
    /// <summary>
    /// Feature on which observations may be made, which is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason.
    ///
    /// Sampling features are artefacts of an observational strategy, and have no significant function outside of their role in the observation process. The physical characteristics of the features themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// EXAMPLE A “station” is essentially an identifiable locality where a sensor system or procedure may be deployed and an observation made. In the context of the observation model, it connotes the “world in the vicinity of the station”, so the observed properties relate to the physical medium at the station, and not to any physical artefact such as a mooring, buoy, benchmark, monument, well, etc.
    ///
    /// NOTE A transient sampling feature, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.
    ///
    /// A sampling feature is intended to sample some feature-of-interest in an application domain, so there is an expectation of at least one sampledFeature property. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.
    /// The value for the property 'sampledFeature' may be inherited from a container resource.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeature"></see></summary>
    let SamplingFeature = _prefix "SamplingFeature"
    /// <summary>
    /// Agent, device, protocol, or plan responsible for transforming a sampling features.
    ///
    /// The result of a operation of a sample trasnformation agent is a - new or - transformed sample.
    /// <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SampleTransformationAgent"></see></summary>
    let SampleTransformationAgent = _prefix "SampleTransformationAgent"
    /// <summary>
    ///   <see href="http://def.seegrid.csiro.au/ontology/om/sam-lite#member"></see>
    /// </summary>
    let member_ = _prefix "member"
