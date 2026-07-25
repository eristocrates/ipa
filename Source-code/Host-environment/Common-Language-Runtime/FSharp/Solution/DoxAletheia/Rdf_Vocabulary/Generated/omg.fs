namespace https.w3id.org.omg.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module omg =
    let _namespace_iri = Namespace_Iri omg |> NamespaceIRI

    /// <summary>
    ///   <para>omg:hasComplexGeometryDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between an object, a geometry, or a geometry state and its RDF-based geometry description. If more than one geometry description should be added to an object, the relation omg:hasGeometry to a new individual of the type omg:Geometry should be used for each geometry description. This step is necessary to allow interconnections between the geometry descriptions regarding their derivation or complementation for easier upkeep of data integrity. The introduction of subproperties of this property for specific geometry descriptions (e.g. OntoBREP, GEOM, OntoSTEP) may ease querying for wanted geometry description formats.</para>
    /// labels<para>has complex geometry description</para></remarks>
    /// <seealso href="https://w3id.org/omg#hasComplexGeometryDescription">https://w3id.org/omg#hasComplexGeometryDescription</seealso>
    let hasComplexGeometryDescription =
        Prefixed_Name(omg, "hasComplexGeometryDescription") |> PrefixedName

    /// <summary>
    ///   <para>omg:hasGeometryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Relation between a geometry and one of its geometry states. For each revision in an RDF-based geometry descriptions where changes were made to the graph nodes and not the properties, a new state must be defined to capture the new graph. This property is inverse functional as one geometry state can only belong to one geometry.</para>
    /// labels<para>has geometry state</para></remarks>
    /// <seealso href="https://w3id.org/omg#hasGeometryState">https://w3id.org/omg#hasGeometryState</seealso>
    let hasGeometryState = Prefixed_Name(omg, "hasGeometryState") |> PrefixedName

    /// <summary>
    ///   <para>omg:isExplicitlyDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between two properties, where the first property is explicitly derived from the other. This means that the first property will always have the same value as the second. Cases where this relation can be used are if an object's geometry is modelled RDF-based and contains a property defining e.g. the height of the object. Then the non-geometric property for height should be explicitly derived from the geometric property to ensure data integrity.</para>
    /// labels<para>is explicitly derived from</para></remarks>
    /// <seealso href="https://w3id.org/omg#isExplicitlyDerivedFrom">https://w3id.org/omg#isExplicitlyDerivedFrom</seealso>
    let isExplicitlyDerivedFrom =
        Prefixed_Name(omg, "isExplicitlyDerivedFrom") |> PrefixedName

    /// <summary>
    ///   <para>omg:isDerivedFromGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between two geometry descriptions where the first geometry can be derived from the second. It is possible for a geometry to be derived from multiple sources, as well as to model a bi-directional derivation between two geometries by using this relation.</para>
    /// labels<para>is derived from geometry</para></remarks>
    /// <seealso href="https://w3id.org/omg#isDerivedFromGeometry">https://w3id.org/omg#isDerivedFromGeometry</seealso>
    let isDerivedFromGeometry =
        Prefixed_Name(omg, "isDerivedFromGeometry") |> PrefixedName

    /// <summary>
    ///   <para>omg:isImplicitlyDerivedFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a property and a geometry, where the property is implicitly derived from the geometry (e.g. properties for volumes or areas). This relation can be used to find inconsistencies, e.g. if the property has been changed while the geometry has not and vice versa.</para>
    /// labels<para>is implicitly derived from</para></remarks>
    /// <seealso href="https://w3id.org/omg#isImplicitlyDerivedFrom">https://w3id.org/omg#isImplicitlyDerivedFrom</seealso>
    let isImplicitlyDerivedFrom =
        Prefixed_Name(omg, "isImplicitlyDerivedFrom") |> PrefixedName

    /// <summary>
    ///   <para>omg:transformsGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between one geometry and another one, where the first is a transformation of the second. This might be used when placing multiple objects of the same type and geometry within the same graph (e.g. multiple chairs into a building model). The first geometry will only consist of a transformation or tanslation matrix.</para>
    /// labels<para>transforms geometry</para></remarks>
    /// <seealso href="https://w3id.org/omg#transformsGeometry">https://w3id.org/omg#transformsGeometry</seealso>
    let transformsGeometry = Prefixed_Name(omg, "transformsGeometry") |> PrefixedName

    /// <summary>
    ///   <para>omg:CurrentGeometryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A current geometry state classifies the most current - and thereby valid - geometry state. Which state is most current will be defined by the added timestamp using the prov:generatedAtTime relation.</para>
    /// labels<para>Aktueller Geometrie Status</para><para>Current geometry state</para></remarks>
    /// <seealso href="https://w3id.org/omg#CurrentGeometryState">https://w3id.org/omg#CurrentGeometryState</seealso>
    let CurrentGeometryState =
        Prefixed_Name(omg, "CurrentGeometryState") |> PrefixedName

    /// <summary>
    ///   <para>omg:Geometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Abstract node for geometry that should not contain geometry descriptions (neither RDF-based or text-based). This node can be used to attach additional information to the information as author, time of creation, geometry context or dependencies with other geometry descriptions as transformations, complementations or derivations. By creating subclasses of this class for specific types of geometry descriptions (e.g. OBJ, GEOM, glTF), more informational value can be added and used in querying for specific geometry description formats.</para>
    /// labels<para>Geometrie</para><para>Geometry</para></remarks>
    /// <seealso href="https://w3id.org/omg#Geometry">https://w3id.org/omg#Geometry</seealso>
    let Geometry = Prefixed_Name(omg, "Geometry") |> PrefixedName

    /// <summary>
    ///   <para>omg:containsPropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a geometry state and a relevant property state. Any property that belongs to the geometry state's related geometry objects (using the omg:containsGeometryObject relation) can be a host for relevant property states.
    /// This relation can be inferred, as long as the connection to the geometry object (omg:containsGeometryObject), its properties (seas:hasProperty) and the considered property state (opm:hasPropertyState) are modelled correctly.</para>
    /// labels<para>contains property state</para></remarks>
    /// <seealso href="https://w3id.org/omg#containsPropertyState">https://w3id.org/omg#containsPropertyState</seealso>
    let containsPropertyState =
        Prefixed_Name(omg, "containsPropertyState") |> PrefixedName

    /// <summary>
    ///   <para>omg:hasGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:InverseFunctionalProperty</para>
    ///   <para>Relation between any object and its geometric representation. An object may have multiple geometric representations, while one geometric represenation may always just be connected to one object (inverse functional).</para>
    /// labels<para>has geometry</para></remarks>
    /// <seealso href="https://w3id.org/omg#hasGeometry">https://w3id.org/omg#hasGeometry</seealso>
    let hasGeometry = Prefixed_Name(omg, "hasGeometry") |> PrefixedName

    /// <summary>
    ///   <para>omg:hasInferredPropertyState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a property and its property state that has been inferred from the omg:isExplicitlyDerivedFrom relation. This relation will be inferred by the a chain axiom for every property that is derived from another (geometric) property (using omg:isExplicitlyDerivedFrom) which in turn has its own property state connected with the opm:hasPropertyState relation.</para>
    /// labels<para>has inferred property state</para></remarks>
    /// <seealso href="https://w3id.org/omg#hasInferredPropertyState">https://w3id.org/omg#hasInferredPropertyState</seealso>
    let hasInferredPropertyState =
        Prefixed_Name(omg, "hasInferredPropertyState") |> PrefixedName

    /// <summary>
    ///   <para>omg:containsGeometryObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a geometry state and any object (node) of the related RDF-based geometry description that is relevant for this specific geometry state (not including deleted objects).</para>
    /// labels<para>contains geometry object</para></remarks>
    /// <seealso href="https://w3id.org/omg#containsGeometryObject">https://w3id.org/omg#containsGeometryObject</seealso>
    let containsGeometryObject =
        Prefixed_Name(omg, "containsGeometryObject") |> PrefixedName

    /// <summary>
    ///   <para>omg:hasGeometryContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between a geometry or geometry state and its geometric context. A singular geometry may have multiple contexts, just as one context can be used for different geometries (of different objects)</para>
    /// labels<para>has geometry context</para></remarks>
    /// <seealso href="https://w3id.org/omg#hasGeometryContext">https://w3id.org/omg#hasGeometryContext</seealso>
    let hasGeometryContext = Prefixed_Name(omg, "hasGeometryContext") |> PrefixedName

    /// <summary>
    ///   <para>omg:hasSimpleGeometryDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>Datatype property to connect a simple (non RDF-based), text-based or file-based geometry description to an object, geometry or geometry state. In case the geometry description is text-based or in a binary file format, it can be directly added to this property, if it is a file-based geometry description, the URI linking to the file should be added to this property. Should multiple geometries be added to the object, the omg:Geometry class with its relation (omg:hasGeometry) or even geometry states (omg:GeometryState and omg:hasGeometryState) should be introduced for each geometry resp. geometry version.</para>
    /// labels<para>has simple geometry description</para></remarks>
    /// <seealso href="https://w3id.org/omg#hasSimpleGeometryDescription">https://w3id.org/omg#hasSimpleGeometryDescription</seealso>
    let hasSimpleGeometryDescription =
        Prefixed_Name(omg, "hasSimpleGeometryDescription") |> PrefixedName

    /// <summary>
    ///   <para>omg:isDerivedFromGeometryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between two geometry states where the first (domain) has been converted from the second (range). A geometry state can only be converted from one other geometry state.</para>
    /// labels<para>is derived from geometry state</para></remarks>
    /// <seealso href="https://w3id.org/omg#isDerivedFromGeometryState">https://w3id.org/omg#isDerivedFromGeometryState</seealso>
    let isDerivedFromGeometryState =
        Prefixed_Name(omg, "isDerivedFromGeometryState") |> PrefixedName

    /// <summary>
    ///   <para>omg:GeometryState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A geometry state is an evaluation holding the geometry description and metadata about a geometry that was true for the given time.
    /// In case of geometry states, changing geometric properties does not cause the need for a new geometry state as long as the property was changed using the OPM concepts. If this is not the case, a copy of the now valid graph must be created and attached to a new geometry state. If an object within the geometry graph is changed (e.g. changing the primitive "Box" into a primitive "Sphere"), the old primitive ("Box") should be classified as opm:Deleted and the new primitive ("Sphere") should be added to the geometry graph in the correct place. The new geometry state should then be connected to any object of the geometry graph that is not opm:Deleted using the omg:containsGeometryObject relation.
    /// Metadata of a geometry state must as a minimum be the time of generation stated by prov:generatedAtTime, but preferably also a prov:wasAttributedTo reference to the agent who created the state. In case properties are changed using the OPM concepts, the most current time of generation and agent who created the state will be determined using the omg:containsPropertyState relation.
    /// Derived geometry descriptions are also stored as states as these change when the base geometry changes.</para>
    /// labels<para>Geometriestatus</para><para>Geometry state</para></remarks>
    /// <seealso href="https://w3id.org/omg#GeometryState">https://w3id.org/omg#GeometryState</seealso>
    let GeometryState = Prefixed_Name(omg, "GeometryState") |> PrefixedName
    /// <summary>
    ///   <para>omg:GeometryContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Context of one (or multiple) geometry descriptions. A context can help extracting relevant geometry descriptions by connecting those to a specific shared context. Geometric contexts can be views of planners, planning stages (versions), or individually created contexts.</para>
    /// labels<para>Geometriekontext</para><para>Geometry context</para></remarks>
    /// <seealso href="https://w3id.org/omg#GeometryContext">https://w3id.org/omg#GeometryContext</seealso>
    let GeometryContext = Prefixed_Name(omg, "GeometryContext") |> PrefixedName
    /// <summary>
    ///   <para>omg:complementsGeometry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Relation between one geometry and another that is composed by the first. E.g. a point cloud of a columns laser scan in a high geometric detail complementing a simplified CSG geometry of the same column. Both geometry descriptions are closely related, but not directly derived from each other. The complementing geometry description may also just depict a small part of the entire geometry (e.g. the column header).</para>
    /// labels<para>complements geometry</para></remarks>
    /// <seealso href="https://w3id.org/omg#complementsGeometry">https://w3id.org/omg#complementsGeometry</seealso>
    let complementsGeometry = Prefixed_Name(omg, "complementsGeometry") |> PrefixedName
