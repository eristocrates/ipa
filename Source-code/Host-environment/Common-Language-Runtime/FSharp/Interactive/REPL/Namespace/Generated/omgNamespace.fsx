#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module omg =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/omg#" "omg"
    /// <summary>
    ///   <para>rdfs:label : Current geometry staterdfs:label : Aktueller Geometrie Status</para>
    ///   <para>rdfs:comment : A current geometry state classifies the most current - and thereby valid - geometry state. Which state is most current will be defined by the added timestamp using the prov:generatedAtTime relation.</para>
    ///   <a href="https://w3id.org/omg#CurrentGeometryState">omg:CurrentGeometryState</a>
    /// </summary>
    let CurrentGeometryState = _prefixId.prefix "CurrentGeometryState"
    /// <summary>
    ///   <para>rdfs:label : Geometryrdfs:label : Geometrie</para>
    ///   <para>rdfs:comment : Abstract node for geometry that should not contain geometry descriptions (neither RDF-based or text-based). This node can be used to attach additional information to the information as author, time of creation, geometry context or dependencies with other geometry descriptions as transformations, complementations or derivations. By creating subclasses of this class for specific types of geometry descriptions (e.g. OBJ, GEOM, glTF), more informational value can be added and used in querying for specific geometry description formats.</para>
    ///   <a href="https://w3id.org/omg#Geometry">omg:Geometry</a>
    /// </summary>
    let Geometry = _prefixId.prefix "Geometry"
    /// <summary>
    ///   <para>rdfs:label : Geometry contextrdfs:label : Geometriekontext</para>
    ///   <para>rdfs:comment : Context of one (or multiple) geometry descriptions. A context can help extracting relevant geometry descriptions by connecting those to a specific shared context. Geometric contexts can be views of planners, planning stages (versions), or individually created contexts.</para>
    ///   <a href="https://w3id.org/omg#GeometryContext">omg:GeometryContext</a>
    /// </summary>
    let GeometryContext = _prefixId.prefix "GeometryContext"
    /// <summary>
    ///   <para>rdfs:label : Geometry staterdfs:label : Geometriestatus</para>
    ///   <para>rdfs:comment : A geometry state is an evaluation holding the geometry description and metadata about a geometry that was true for the given time.
    /// In case of geometry states, changing geometric properties does not cause the need for a new geometry state as long as the property was changed using the OPM concepts. If this is not the case, a copy of the now valid graph must be created and attached to a new geometry state. If an object within the geometry graph is changed (e.g. changing the primitive "Box" into a primitive "Sphere"), the old primitive ("Box") should be classified as opm:Deleted and the new primitive ("Sphere") should be added to the geometry graph in the correct place. The new geometry state should then be connected to any object of the geometry graph that is not opm:Deleted using the omg:containsGeometryObject relation.
    /// Metadata of a geometry state must as a minimum be the time of generation stated by prov:generatedAtTime, but preferably also a prov:wasAttributedTo reference to the agent who created the state. In case properties are changed using the OPM concepts, the most current time of generation and agent who created the state will be determined using the omg:containsPropertyState relation.
    /// Derived geometry descriptions are also stored as states as these change when the base geometry changes.</para>
    ///   <a href="https://w3id.org/omg#GeometryState">omg:GeometryState</a>
    /// </summary>
    let GeometryState = _prefixId.prefix "GeometryState"
    /// <summary>
    ///   <para>rdfs:label : complements geometry</para>
    ///   <para>rdfs:comment : Relation between one geometry and another that is composed by the first. E.g. a point cloud of a columns laser scan in a high geometric detail complementing a simplified CSG geometry of the same column. Both geometry descriptions are closely related, but not directly derived from each other. The complementing geometry description may also just depict a small part of the entire geometry (e.g. the column header).</para>
    ///   <a href="https://w3id.org/omg#complementsGeometry">omg:complementsGeometry</a>
    /// </summary>
    let complementsGeometry = _prefixId.prefix "complementsGeometry"
    /// <summary>
    ///   <para>rdfs:label : contains geometry object</para>
    ///   <para>rdfs:comment : Relation between a geometry state and any object (node) of the related RDF-based geometry description that is relevant for this specific geometry state (not including deleted objects).</para>
    ///   <a href="https://w3id.org/omg#containsGeometryObject">omg:containsGeometryObject</a>
    /// </summary>
    let containsGeometryObject = _prefixId.prefix "containsGeometryObject"
    /// <summary>
    ///   <para>rdfs:label : contains property state</para>
    ///   <para>rdfs:comment : Relation between a geometry state and a relevant property state. Any property that belongs to the geometry state's related geometry objects (using the omg:containsGeometryObject relation) can be a host for relevant property states.
    /// This relation can be inferred, as long as the connection to the geometry object (omg:containsGeometryObject), its properties (seas:hasProperty) and the considered property state (opm:hasPropertyState) are modelled correctly.</para>
    ///   <a href="https://w3id.org/omg#containsPropertyState">omg:containsPropertyState</a>
    /// </summary>
    let containsPropertyState = _prefixId.prefix "containsPropertyState"
    /// <summary>
    ///   <para>rdfs:label : has complex geometry description</para>
    ///   <para>rdfs:comment : Relation between an object, a geometry, or a geometry state and its RDF-based geometry description. If more than one geometry description should be added to an object, the relation omg:hasGeometry to a new individual of the type omg:Geometry should be used for each geometry description. This step is necessary to allow interconnections between the geometry descriptions regarding their derivation or complementation for easier upkeep of data integrity. The introduction of subproperties of this property for specific geometry descriptions (e.g. OntoBREP, GEOM, OntoSTEP) may ease querying for wanted geometry description formats.</para>
    ///   <a href="https://w3id.org/omg#hasComplexGeometryDescription">omg:hasComplexGeometryDescription</a>
    /// </summary>
    let hasComplexGeometryDescription = _prefixId.prefix "hasComplexGeometryDescription"
    /// <summary>
    ///   <para>rdfs:label : has geometry</para>
    ///   <para>rdfs:comment : Relation between any object and its geometric representation. An object may have multiple geometric representations, while one geometric represenation may always just be connected to one object (inverse functional).</para>
    ///   <a href="https://w3id.org/omg#hasGeometry">omg:hasGeometry</a>
    /// </summary>
    let hasGeometry = _prefixId.prefix "hasGeometry"
    /// <summary>
    ///   <para>rdfs:label : has geometry context</para>
    ///   <para>rdfs:comment : Relation between a geometry or geometry state and its geometric context. A singular geometry may have multiple contexts, just as one context can be used for different geometries (of different objects)</para>
    ///   <a href="https://w3id.org/omg#hasGeometryContext">omg:hasGeometryContext</a>
    /// </summary>
    let hasGeometryContext = _prefixId.prefix "hasGeometryContext"
    /// <summary>
    ///   <para>rdfs:label : has geometry state</para>
    ///   <para>rdfs:comment : Relation between a geometry and one of its geometry states. For each revision in an RDF-based geometry descriptions where changes were made to the graph nodes and not the properties, a new state must be defined to capture the new graph. This property is inverse functional as one geometry state can only belong to one geometry.</para>
    ///   <a href="https://w3id.org/omg#hasGeometryState">omg:hasGeometryState</a>
    /// </summary>
    let hasGeometryState = _prefixId.prefix "hasGeometryState"
    /// <summary>
    ///   <para>rdfs:label : has inferred property state</para>
    ///   <para>rdfs:comment : Relation between a property and its property state that has been inferred from the omg:isExplicitlyDerivedFrom relation. This relation will be inferred by the a chain axiom for every property that is derived from another (geometric) property (using omg:isExplicitlyDerivedFrom) which in turn has its own property state connected with the opm:hasPropertyState relation.</para>
    ///   <a href="https://w3id.org/omg#hasInferredPropertyState">omg:hasInferredPropertyState</a>
    /// </summary>
    let hasInferredPropertyState = _prefixId.prefix "hasInferredPropertyState"
    /// <summary>
    ///   <para>rdfs:label : has simple geometry description</para>
    ///   <para>rdfs:comment : Datatype property to connect a simple (non RDF-based), text-based or file-based geometry description to an object, geometry or geometry state. In case the geometry description is text-based or in a binary file format, it can be directly added to this property, if it is a file-based geometry description, the URI linking to the file should be added to this property. Should multiple geometries be added to the object, the omg:Geometry class with its relation (omg:hasGeometry) or even geometry states (omg:GeometryState and omg:hasGeometryState) should be introduced for each geometry resp. geometry version.</para>
    ///   <a href="https://w3id.org/omg#hasSimpleGeometryDescription">omg:hasSimpleGeometryDescription</a>
    /// </summary>
    let hasSimpleGeometryDescription = _prefixId.prefix "hasSimpleGeometryDescription"
    /// <summary>
    ///   <para>rdfs:label : is derived from geometry</para>
    ///   <para>rdfs:comment : Relation between two geometry descriptions where the first geometry can be derived from the second. It is possible for a geometry to be derived from multiple sources, as well as to model a bi-directional derivation between two geometries by using this relation.</para>
    ///   <a href="https://w3id.org/omg#isDerivedFromGeometry">omg:isDerivedFromGeometry</a>
    /// </summary>
    let isDerivedFromGeometry = _prefixId.prefix "isDerivedFromGeometry"
    /// <summary>
    ///   <para>rdfs:label : is derived from geometry state</para>
    ///   <para>rdfs:comment : Relation between two geometry states where the first (domain) has been converted from the second (range). A geometry state can only be converted from one other geometry state.</para>
    ///   <a href="https://w3id.org/omg#isDerivedFromGeometryState">omg:isDerivedFromGeometryState</a>
    /// </summary>
    let isDerivedFromGeometryState = _prefixId.prefix "isDerivedFromGeometryState"
    /// <summary>
    ///   <para>rdfs:label : is explicitly derived from</para>
    ///   <para>rdfs:comment : Relation between two properties, where the first property is explicitly derived from the other. This means that the first property will always have the same value as the second. Cases where this relation can be used are if an object's geometry is modelled RDF-based and contains a property defining e.g. the height of the object. Then the non-geometric property for height should be explicitly derived from the geometric property to ensure data integrity.</para>
    ///   <a href="https://w3id.org/omg#isExplicitlyDerivedFrom">omg:isExplicitlyDerivedFrom</a>
    /// </summary>
    let isExplicitlyDerivedFrom = _prefixId.prefix "isExplicitlyDerivedFrom"
    /// <summary>
    ///   <para>rdfs:label : is implicitly derived from</para>
    ///   <para>rdfs:comment : Relation between a property and a geometry, where the property is implicitly derived from the geometry (e.g. properties for volumes or areas). This relation can be used to find inconsistencies, e.g. if the property has been changed while the geometry has not and vice versa.</para>
    ///   <a href="https://w3id.org/omg#isImplicitlyDerivedFrom">omg:isImplicitlyDerivedFrom</a>
    /// </summary>
    let isImplicitlyDerivedFrom = _prefixId.prefix "isImplicitlyDerivedFrom"
    /// <summary>
    ///   <para>rdfs:label : transforms geometry</para>
    ///   <para>rdfs:comment : Relation between one geometry and another one, where the first is a transformation of the second. This might be used when placing multiple objects of the same type and geometry within the same graph (e.g. multiple chairs into a building model). The first geometry will only consist of a transformation or tanslation matrix.</para>
    ///   <a href="https://w3id.org/omg#transformsGeometry">omg:transformsGeometry</a>
    /// </summary>
    let transformsGeometry = _prefixId.prefix "transformsGeometry"
