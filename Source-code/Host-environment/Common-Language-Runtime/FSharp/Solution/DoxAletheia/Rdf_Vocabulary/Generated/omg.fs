namespace https.w3id.org.omg.hash

open DoxAletheia

module omg =
    let _namespace_name = "https://w3id.org/omg#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A current geometry state classifies the most current - and thereby valid - geometry state. Which state is most current will be defined by the added timestamp using the prov:generatedAtTime relation.
    /// <see href="https://w3id.org/omg#CurrentGeometryState"></see></summary>
    let CurrentGeometryState = _prefix "CurrentGeometryState"
    /// <summary>
    /// A geometry state is an evaluation holding the geometry description and metadata about a geometry that was true for the given time.
    /// In case of geometry states, changing geometric properties does not cause the need for a new geometry state as long as the property was changed using the OPM concepts. If this is not the case, a copy of the now valid graph must be created and attached to a new geometry state. If an object within the geometry graph is changed (e.g. changing the primitive "Box" into a primitive "Sphere"), the old primitive ("Box") should be classified as opm:Deleted and the new primitive ("Sphere") should be added to the geometry graph in the correct place. The new geometry state should then be connected to any object of the geometry graph that is not opm:Deleted using the omg:containsGeometryObject relation.
    /// Metadata of a geometry state must as a minimum be the time of generation stated by prov:generatedAtTime, but preferably also a prov:wasAttributedTo reference to the agent who created the state. In case properties are changed using the OPM concepts, the most current time of generation and agent who created the state will be determined using the omg:containsPropertyState relation.
    /// Derived geometry descriptions are also stored as states as these change when the base geometry changes.
    /// <see href="https://w3id.org/omg#GeometryState"></see></summary>
    let GeometryState = _prefix "GeometryState"
    /// <summary>
    /// Abstract node for geometry that should not contain geometry descriptions (neither RDF-based or text-based). This node can be used to attach additional information to the information as author, time of creation, geometry context or dependencies with other geometry descriptions as transformations, complementations or derivations. By creating subclasses of this class for specific types of geometry descriptions (e.g. OBJ, GEOM, glTF), more informational value can be added and used in querying for specific geometry description formats.
    /// <see href="https://w3id.org/omg#Geometry"></see></summary>
    let Geometry = _prefix "Geometry"
    /// <summary>
    /// Context of one (or multiple) geometry descriptions. A context can help extracting relevant geometry descriptions by connecting those to a specific shared context. Geometric contexts can be views of planners, planning stages (versions), or individually created contexts.
    /// <see href="https://w3id.org/omg#GeometryContext"></see></summary>
    let GeometryContext = _prefix "GeometryContext"
    /// <summary>
    /// Relation between one geometry and another that is composed by the first. E.g. a point cloud of a columns laser scan in a high geometric detail complementing a simplified CSG geometry of the same column. Both geometry descriptions are closely related, but not directly derived from each other. The complementing geometry description may also just depict a small part of the entire geometry (e.g. the column header).
    /// <see href="https://w3id.org/omg#complementsGeometry"></see></summary>
    let complementsGeometry = _prefix "complementsGeometry"
    /// <summary>
    /// Relation between a geometry state and any object (node) of the related RDF-based geometry description that is relevant for this specific geometry state (not including deleted objects).
    /// <see href="https://w3id.org/omg#containsGeometryObject"></see></summary>
    let containsGeometryObject = _prefix "containsGeometryObject"
    /// <summary>
    /// Relation between a geometry state and a relevant property state. Any property that belongs to the geometry state's related geometry objects (using the omg:containsGeometryObject relation) can be a host for relevant property states.
    /// This relation can be inferred, as long as the connection to the geometry object (omg:containsGeometryObject), its properties (seas:hasProperty) and the considered property state (opm:hasPropertyState) are modelled correctly.
    /// <see href="https://w3id.org/omg#containsPropertyState"></see></summary>
    let containsPropertyState = _prefix "containsPropertyState"
    /// <summary>
    /// Relation between an object, a geometry, or a geometry state and its RDF-based geometry description. If more than one geometry description should be added to an object, the relation omg:hasGeometry to a new individual of the type omg:Geometry should be used for each geometry description. This step is necessary to allow interconnections between the geometry descriptions regarding their derivation or complementation for easier upkeep of data integrity. The introduction of subproperties of this property for specific geometry descriptions (e.g. OntoBREP, GEOM, OntoSTEP) may ease querying for wanted geometry description formats.
    /// <see href="https://w3id.org/omg#hasComplexGeometryDescription"></see></summary>
    let hasComplexGeometryDescription = _prefix "hasComplexGeometryDescription"
    /// <summary>
    /// Relation between any object and its geometric representation. An object may have multiple geometric representations, while one geometric represenation may always just be connected to one object (inverse functional).
    /// <see href="https://w3id.org/omg#hasGeometry"></see></summary>
    let hasGeometry = _prefix "hasGeometry"
    /// <summary>
    /// Relation between a geometry or geometry state and its geometric context. A singular geometry may have multiple contexts, just as one context can be used for different geometries (of different objects)
    /// <see href="https://w3id.org/omg#hasGeometryContext"></see></summary>
    let hasGeometryContext = _prefix "hasGeometryContext"
    /// <summary>
    /// Relation between a geometry and one of its geometry states. For each revision in an RDF-based geometry descriptions where changes were made to the graph nodes and not the properties, a new state must be defined to capture the new graph. This property is inverse functional as one geometry state can only belong to one geometry.
    /// <see href="https://w3id.org/omg#hasGeometryState"></see></summary>
    let hasGeometryState = _prefix "hasGeometryState"
    /// <summary>
    /// Relation between a property and its property state that has been inferred from the omg:isExplicitlyDerivedFrom relation. This relation will be inferred by the a chain axiom for every property that is derived from another (geometric) property (using omg:isExplicitlyDerivedFrom) which in turn has its own property state connected with the opm:hasPropertyState relation.
    /// <see href="https://w3id.org/omg#hasInferredPropertyState"></see></summary>
    let hasInferredPropertyState = _prefix "hasInferredPropertyState"
    /// <summary>
    /// Relation between two properties, where the first property is explicitly derived from the other. This means that the first property will always have the same value as the second. Cases where this relation can be used are if an object's geometry is modelled RDF-based and contains a property defining e.g. the height of the object. Then the non-geometric property for height should be explicitly derived from the geometric property to ensure data integrity.
    /// <see href="https://w3id.org/omg#isExplicitlyDerivedFrom"></see></summary>
    let isExplicitlyDerivedFrom = _prefix "isExplicitlyDerivedFrom"
    /// <summary>
    /// Datatype property to connect a simple (non RDF-based), text-based or file-based geometry description to an object, geometry or geometry state. In case the geometry description is text-based or in a binary file format, it can be directly added to this property, if it is a file-based geometry description, the URI linking to the file should be added to this property. Should multiple geometries be added to the object, the omg:Geometry class with its relation (omg:hasGeometry) or even geometry states (omg:GeometryState and omg:hasGeometryState) should be introduced for each geometry resp. geometry version.
    /// <see href="https://w3id.org/omg#hasSimpleGeometryDescription"></see></summary>
    let hasSimpleGeometryDescription = _prefix "hasSimpleGeometryDescription"
    /// <summary>
    /// Relation between two geometry descriptions where the first geometry can be derived from the second. It is possible for a geometry to be derived from multiple sources, as well as to model a bi-directional derivation between two geometries by using this relation.
    /// <see href="https://w3id.org/omg#isDerivedFromGeometry"></see></summary>
    let isDerivedFromGeometry = _prefix "isDerivedFromGeometry"
    /// <summary>
    /// Relation between two geometry states where the first (domain) has been converted from the second (range). A geometry state can only be converted from one other geometry state.
    /// <see href="https://w3id.org/omg#isDerivedFromGeometryState"></see></summary>
    let isDerivedFromGeometryState = _prefix "isDerivedFromGeometryState"
    /// <summary>
    /// Relation between a property and a geometry, where the property is implicitly derived from the geometry (e.g. properties for volumes or areas). This relation can be used to find inconsistencies, e.g. if the property has been changed while the geometry has not and vice versa.
    /// <see href="https://w3id.org/omg#isImplicitlyDerivedFrom"></see></summary>
    let isImplicitlyDerivedFrom = _prefix "isImplicitlyDerivedFrom"
    /// <summary>
    /// Relation between one geometry and another one, where the first is a transformation of the second. This might be used when placing multiple objects of the same type and geometry within the same graph (e.g. multiple chairs into a building model). The first geometry will only consist of a transformation or tanslation matrix.
    /// <see href="https://w3id.org/omg#transformsGeometry"></see></summary>
    let transformsGeometry = _prefix "transformsGeometry"
