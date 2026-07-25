namespace http.def.seegrid.csiro.au.ontology.om.sam_lite.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module samfl =
    let _namespace_iri = Namespace_Iri samfl |> NamespaceIRI
    /// <summary>
    ///   <para>samfl:samplingElevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If present, the attribute samplingElevation shall describe the elevation from where the specimen was obtained, relative to the sampling location.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous elevation then this attribute is not required. However, if the specific elevationat the location, then this attribute supports its description.</para>
    /// labels<para>sampling elevation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingElevation">http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingElevation</seealso>
    let samplingElevation = Prefixed_Name(samfl, "samplingElevation") |> PrefixedName
    /// <summary>
    ///   <para>samfl:SamplingCurve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 1-D manifold (Curve)
    ///
    /// Transect, traverse, flightline, cruise, trajectory, borehole, etc</para>
    /// labels<para>Sampling curve</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCurve">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCurve</seealso>
    let SamplingCurve = Prefixed_Name(samfl, "SamplingCurve") |> PrefixedName

    /// <summary>
    ///   <para>samfl:SamplingFeatureComplex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Resource that relates a sampling feature to another sampling feature with a role indicating the nature of the relationship.
    ///
    /// Sampling features are frequently related to each other, as parts of complexes, through sub-sampling, and in other ways. If present, the association class SamplingFeatureComplex (Figure 9) shall link an SF_SamplingFeature to another SF_SamplingFeature.</para>
    /// labels<para>Sampling feature complex</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeatureComplex">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeatureComplex</seealso>
    let SamplingFeatureComplex =
        Prefixed_Name(samfl, "SamplingFeatureComplex") |> PrefixedName

    /// <summary>
    ///   <para>samfl:Surface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingSurface.  An existing OWL class that represents the notion of a Surface may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Surface in the context of a sam:SamplingSurface instance.</para>
    /// labels<para>Spatial surface</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Surface">http://def.seegrid.csiro.au/ontology/om/sam-lite#Surface</seealso>
    let Surface = Prefixed_Name(samfl, "Surface") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Curve</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>1-D geometric object
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingCurve.  An existing OWL class that represents the notion of a Curve may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Curve in the context of a sam:SamplingCurve instance.</para>
    /// labels<para>Spatial curve</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Curve">http://def.seegrid.csiro.au/ontology/om/sam-lite#Curve</seealso>
    let Curve = Prefixed_Name(samfl, "Curve") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Location, expressed as either a geometry object or feature
    ///
    /// samfl:GeometryObject is subclass
    ///
    /// w3geo:SpatialThing, geosparql:SpatialObject are subclasses</para>
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Location">http://def.seegrid.csiro.au/ontology/om/sam-lite#Location</seealso>
    let Location = Prefixed_Name(samfl, "Location") |> PrefixedName
    /// <summary>
    ///   <para>samfl:SamplingCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Collection of features on which observations may be made, which are intended to be representative of one or more features that are not fully accessible for some reason.
    ///
    /// The features that the member sampling features are intended to sample may be indicated by one or more sampledFeature properties. If only one is present then it may be inferred that this is the sampled feature of all the member sampling features, unless locally overridden.</para>
    /// labels<para>Collection of sampling features</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCollection">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingCollection</seealso>
    let SamplingCollection = Prefixed_Name(samfl, "SamplingCollection") |> PrefixedName
    /// <summary>
    ///   <para>samfl:ObservationProcess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Process used in an observation, including sensors, algorithms, computation methods
    ///
    /// The result of application of an observation process is an observation result - i.e. an estimate of a property value.</para>
    /// labels<para>Observation process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#ObservationProcess">http://def.seegrid.csiro.au/ontology/om/sam-lite#ObservationProcess</seealso>
    let ObservationProcess = Prefixed_Name(samfl, "ObservationProcess") |> PrefixedName
    /// <summary>
    ///   <para>samfl:hostedProcedure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A common role for a spatial sampling feature is to host instruments or procedures deployed repetitively or permanently. If present, the association Platform shall link the SF_SpatialSamplingFeature to an OM_Process deployed at it. The OM_Process has the role hostedProcedure with respect to the sampling feature.</para>
    /// labels<para>hosted procedure or instrument</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#hostedProcedure">http://def.seegrid.csiro.au/ontology/om/sam-lite#hostedProcedure</seealso>
    let hostedProcedure = Prefixed_Name(samfl, "hostedProcedure") |> PrefixedName
    /// <summary>
    ///   <para>samfl:elevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>vertical offset from a datum</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#elevation">http://def.seegrid.csiro.au/ontology/om/sam-lite#elevation</seealso>
    let elevation = Prefixed_Name(samfl, "elevation") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Process</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agent, device, protocol, or plan responsible for transforming a sampling features.
    ///
    /// The result of a application of a sampling process is a - new or - transformed sample. </para>
    /// labels<para>Sampling process</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Process">http://def.seegrid.csiro.au/ontology/om/sam-lite#Process</seealso>
    let Process = Prefixed_Name(samfl, "Process") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Elevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Simple model for elevation, expressed as a vertical offset from a datum</para>
    /// labels<para>Elevation</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Elevation">http://def.seegrid.csiro.au/ontology/om/sam-lite#Elevation</seealso>
    let Elevation = Prefixed_Name(samfl, "Elevation") |> PrefixedName
    /// <summary>
    ///   <para>samfl:SamplingPoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 0-D manifold (Point)
    ///
    /// Often referred to as a 'station', 'pixel', 'probe-spot' etc.</para>
    /// labels<para>Sampling point</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingPoint">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingPoint</seealso>
    let SamplingPoint = Prefixed_Name(samfl, "SamplingPoint") |> PrefixedName
    /// <summary>
    ///   <para>samfl:materialClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Value should be taken from a vocabulary of material classes.
    ///
    /// e.g. aqueous liquid, non-aqueous liquid, soil, rock, tissue, vegetation (broad case) or finer classifications if available</para>
    /// labels<para>class of material</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#materialClass">http://def.seegrid.csiro.au/ontology/om/sam-lite#materialClass</seealso>
    let materialClass = Prefixed_Name(samfl, "materialClass") |> PrefixedName
    /// <summary>
    ///   <para>samfl:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>specimen size</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#size">http://def.seegrid.csiro.au/ontology/om/sam-lite#size</seealso>
    let size = Prefixed_Name(samfl, "size") |> PrefixedName
    /// <summary>
    ///   <para>samfl:sampledFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A sampling feature is established in order to make observations concerning some domain feature. The association Intention shall link the SF_SamplingFeature to the feature which the sampling feature was designed to sample. The target of this association has the role sampledFeature with respect to the sampling feature, and shall not be a sampling feature or observation. It is usually a real-world feature from an application domain (Figures 5 and 10).
    ///
    /// EXAMPLE A profile typically samples a water- or atmospheric-column; a well samples the water in an aquifer; a tissue specimen samples a part of an organism.</para>
    /// labels<para>sampled feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#sampledFeature">http://def.seegrid.csiro.au/ontology/om/sam-lite#sampledFeature</seealso>
    let sampledFeature = Prefixed_Name(samfl, "sampledFeature") |> PrefixedName
    /// <summary>
    ///   <para>samfl:shape</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>spatial sampling feature shape</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#shape">http://def.seegrid.csiro.au/ontology/om/sam-lite#shape</seealso>
    let shape = Prefixed_Name(samfl, "shape") |> PrefixedName
    /// <summary>
    ///   <para>samfl:SamplingSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 2-D manifold (Surface)
    ///
    /// Scene, swath, cross-section, level, quadrat, area-of-interest, fence, etc.</para>
    /// labels<para>Sampling surface</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSurface">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSurface</seealso>
    let SamplingSurface = Prefixed_Name(samfl, "SamplingSurface") |> PrefixedName
    /// <summary>
    ///   <para>samfl:samplingLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If present, the attribute samplingLocation:GM_Object shall describe the location from where the specimen was obtained.
    ///
    /// NOTE Where a specimen has a relatedSamplingFeature whose location provides an unambiguous location then this attribute is not required. However, if the specific sampling location within the sampledFeature is important, then this attribute supports its description.</para>
    /// labels<para>sampling location</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingLocation">http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingLocation</seealso>
    let samplingLocation = Prefixed_Name(samfl, "samplingLocation") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Measure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Scaled number.
    ///
    /// This is an abstract class, which should be substituted by a suitable concrete representation of a measure or quantity at run-tme.
    ///
    /// oml:SimpleMeasure &lt;http://def.seegrid.csiro.au/ontology/om/om-lite#SimpleMeasure&gt;
    /// qudt:QuantityValue &lt;http://qudt.org/schema/qudt#QuantityValue&gt;
    /// DUL:Region &lt;http://www.loa-cnr.it/ontologies/DUL.owl#Region&gt;
    ///
    /// are candidates. </para>
    /// labels<para>Measure or quantity</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Measure">http://def.seegrid.csiro.au/ontology/om/sam-lite#Measure</seealso>
    let Measure = Prefixed_Name(samfl, "Measure") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Specimen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A Specimen is a physical sample, obtained for observation(s) normally carried out ex-situ, sometimes in a laboratory.</para>
    /// labels<para>Specimen</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Specimen">http://def.seegrid.csiro.au/ontology/om/sam-lite#Specimen</seealso>
    let Specimen = Prefixed_Name(samfl, "Specimen") |> PrefixedName
    /// <summary>
    ///   <para>samfl:verticalDatum</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>vertical (elevation) datum</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#verticalDatum">http://def.seegrid.csiro.au/ontology/om/sam-lite#verticalDatum</seealso>
    let verticalDatum = Prefixed_Name(samfl, "verticalDatum") |> PrefixedName
    /// <summary>
    ///   <para>samfl:samplingTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>samplingTime records when the specimen was retrieved from the sampled feature.</para>
    /// labels<para>sampling time</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingTime">http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingTime</seealso>
    let samplingTime = Prefixed_Name(samfl, "samplingTime") |> PrefixedName

    /// <summary>
    ///   <para>samfl:SpatialSamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Sampling feature whose defining characteristic is that it samples the intended feature by geometric subsetting.
    ///
    /// When observations are made to estimate properties of a geospatial feature, in particular where the value of a property varies within the scope of the feature, a spatial sampling feature is used. Depending on accessibility and on the nature of the expected property variation, the sampling feature may be extensive in one, two or three spatial dimensions. Processing and visualization methods are often dependent on the topological dimension of the sampling manifold, so this provides a natural classification system for sampling features.
    ///
    /// This classification follows common practice in focussing on conventional spatial dimensions. Properties observed on sampling features may be time-dependent, but the temporal axis does not generally contribute to the classification of sampling feature classes. Sampling feature identity is usually less time-dependent than the property value.</para>
    /// labels<para>Spatial sampling feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SpatialSamplingFeature">http://def.seegrid.csiro.au/ontology/om/sam-lite#SpatialSamplingFeature</seealso>
    let SpatialSamplingFeature =
        Prefixed_Name(samfl, "SpatialSamplingFeature") |> PrefixedName

    /// <summary>
    ///   <para>samfl:SamplingSolid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Spatial sampling feature whose shape is a 3-D manifold (Solid)</para>
    /// labels<para>Sampling solid</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSolid">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingSolid</seealso>
    let SamplingSolid = Prefixed_Name(samfl, "SamplingSolid") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Point</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>0-D geometric object
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingPoint.  An existing OWL class that represents the notion of a Point may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Point in the context of a sam:SamplingPoint instance.</para>
    /// labels<para>Spatial point</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Point">http://def.seegrid.csiro.au/ontology/om/sam-lite#Point</seealso>
    let Point = Prefixed_Name(samfl, "Point") |> PrefixedName

    /// <summary>
    ///   <para>samfl:relatedSamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>related sampling feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#relatedSamplingFeature">http://def.seegrid.csiro.au/ontology/om/sam-lite#relatedSamplingFeature</seealso>
    let relatedSamplingFeature =
        Prefixed_Name(samfl, "relatedSamplingFeature") |> PrefixedName

    /// <summary>
    ///   <para>samfl:currentLocation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>If present, the attribute currentLocation:Location shall describe the location of a physical specimen. This may be a storage location, such as a shelf in a warehouse or a drawer in a museum.
    ///
    /// NOTE If a specimen no longer exists, for example, it was destroyed in connection with an observation act, then the currentLocation should be omitted or carry a suitable null indicator.</para>
    /// labels<para>current location</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#currentLocation">http://def.seegrid.csiro.au/ontology/om/sam-lite#currentLocation</seealso>
    let currentLocation = Prefixed_Name(samfl, "currentLocation") |> PrefixedName
    /// <summary>
    ///   <para>samfl:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#">http://def.seegrid.csiro.au/ontology/om/sam-lite#</seealso>
    let _prefix_iri = Prefixed_Name(samfl, "") |> PrefixedName
    /// <summary>
    ///   <para>samfl:SamplingFeature</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Feature on which observations may be made, which is intended to be representative of a different (usually larger) feature that is not fully accessible for some reason.
    ///
    /// Sampling features are artefacts of an observational strategy, and have no significant function outside of their role in the observation process. The physical characteristics of the features themselves are of little interest, except perhaps to the manager of a sampling campaign.
    ///
    /// EXAMPLE A “station” is essentially an identifiable locality where a sensor system or procedure may be deployed and an observation made. In the context of the observation model, it connotes the “world in the vicinity of the station”, so the observed properties relate to the physical medium at the station, and not to any physical artefact such as a mooring, buoy, benchmark, monument, well, etc.
    ///
    /// NOTE A transient sampling feature, such as a ships-track or flight-line, might be identified and described, but is unlikely to be revisited exactly.
    ///
    /// A sampling feature is intended to sample some feature-of-interest in an application domain, so there is an expectation of at least one sampledFeature property. However, in some cases the identity, and even the exact type, of the sampled feature may not be known when observations are made using the sampling features.</para>
    ///   <para>The value for the property 'sampledFeature' may be inherited from a container resource.</para>
    /// labels<para>Sampling Feature</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeature">http://def.seegrid.csiro.au/ontology/om/sam-lite#SamplingFeature</seealso>
    let SamplingFeature = Prefixed_Name(samfl, "SamplingFeature") |> PrefixedName
    /// <summary>
    ///   <para>samfl:member</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#member">http://def.seegrid.csiro.au/ontology/om/sam-lite#member</seealso>
    let member_ = Prefixed_Name(samfl, "member") |> PrefixedName

    /// <summary>
    ///   <para>samfl:SampleTransformationAgent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Agent, device, protocol, or plan responsible for transforming a sampling features.
    ///
    /// The result of a operation of a sample trasnformation agent is a - new or - transformed sample. </para>
    /// labels<para>Sample transformation agent</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#SampleTransformationAgent">http://def.seegrid.csiro.au/ontology/om/sam-lite#SampleTransformationAgent</seealso>
    let SampleTransformationAgent =
        Prefixed_Name(samfl, "SampleTransformationAgent") |> PrefixedName

    /// <summary>
    ///   <para>samfl:complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>sampling feature complex</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#complex">http://def.seegrid.csiro.au/ontology/om/sam-lite#complex</seealso>
    let complex = Prefixed_Name(samfl, "complex") |> PrefixedName
    /// <summary>
    ///   <para>samfl:GeometryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Geometry object has properties relating to geometry, incuding positional and topological attributes, reference system, accuracy and precision. Might be geolocated.
    ///
    /// This stub is included in the sam: ontology to support references to geometry in various places.  An existing concrete OWL class that represents the notion of a geometry may be asserted to be a sub-class of this stub, without requiring use of a specific representation of Geometry in the context of sampling.</para>
    /// labels<para>Geometry object</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#GeometryObject">http://def.seegrid.csiro.au/ontology/om/sam-lite#GeometryObject</seealso>
    let GeometryObject = Prefixed_Name(samfl, "GeometryObject") |> PrefixedName
    /// <summary>
    ///   <para>samfl:samplingMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Process used to obtain the Specimen from its sampledFeature</para>
    /// labels<para>sampling method</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingMethod">http://def.seegrid.csiro.au/ontology/om/sam-lite#samplingMethod</seealso>
    let samplingMethod = Prefixed_Name(samfl, "samplingMethod") |> PrefixedName
    /// <summary>
    ///   <para>samfl:Solid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>3-D geometric object, whose exterior is a shell
    ///
    /// This stub is included in the sam: ontology to support constraints on the sam:shape property of a sam:SamplingSolid.  An existing OWL class that represents the notion of a Solid may be asserted to be a sub-class of this stub, but without requiring use of any particular representation of Solid in the context of a sam:SamplingSolid instance.</para>
    /// labels<para>Spatial solid</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#Solid">http://def.seegrid.csiro.au/ontology/om/sam-lite#Solid</seealso>
    let Solid = Prefixed_Name(samfl, "Solid") |> PrefixedName
    /// <summary>
    ///   <para>samfl:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>role</para></remarks>
    /// <seealso href="http://def.seegrid.csiro.au/ontology/om/sam-lite#role">http://def.seegrid.csiro.au/ontology/om/sam-lite#role</seealso>
    let role = Prefixed_Name(samfl, "role") |> PrefixedName
